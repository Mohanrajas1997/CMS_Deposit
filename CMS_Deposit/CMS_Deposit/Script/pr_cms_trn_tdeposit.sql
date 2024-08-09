DELIMITER $$

DROP PROCEDURE IF EXISTS `pr_cms_trn_tdeposit` $$
CREATE PROCEDURE `pr_cms_trn_tdeposit`
(
  in in_deposit_gid int,
  in in_deposit_date varchar(16),
  in in_deposit_slip_no varchar(32),
  in in_tot_chqs int,
  in in_deposit_amount double(15,2),
  in in_client_code varchar(16),
  in in_loc_code varchar(8),
  in in_agent_code varchar(16),
  in in_bank_code varchar(8),
  in in_bank_branch varchar(128),
  in in_mapped_amount double(15,2),
  in in_mapped_chq int,
  in in_action varchar(8),
  in in_action_by varchar(16),
  out out_gid int,
  out out_msg text,
  out out_result int(10)
)
me:BEGIN
  declare err_msg text default '';
  declare err_flag varchar(10) default false;
  DECLARE EXIT HANDLER FOR SQLEXCEPTION

  BEGIN
    GET DIAGNOSTICS CONDITION 1 @sqlstate = RETURNED_SQLSTATE,
    @errno = MYSQL_ERRNO, @text = MESSAGE_TEXT;

    SET @full_error = CONCAT("ERROR ", @errno, " (", @sqlstate, "): ", @text);

    ROLLBACK;

    set out_msg = @full_error;
    set out_result = 0;
  END;
  
  if in_action = 'SELECT' then
    set in_deposit_gid := if(in_deposit_gid = 0,null,in_deposit_gid);

		select a.deposit_gid,date_format(a.deposit_date,'%d/%m/%Y') as 'Deposit_Date',a.deposit_slip_no,
        a.tot_chqs,a.deposit_amount,a.client_code,concat(b.qcd_short_code,'-',b.qcd_name) as 'Client_Name',a.loc_code,
        c.qcd_name as 'Location_Name',a.agent_code,d.qcd_name as 'Agent_Name',
        a.bank_code,e.qcd_name as 'Bank_Name',a.bank_branch,a.mapped_amount,a.mapped_chq
    from cms_trn_tdeposit a
    left join cms_mst_tquickcode b on a.client_code = b.qcd_code and b.delete_flag='N'
    left join cms_mst_tquickcode c on a.loc_code=c.qcd_code and c.delete_flag='N'
    left join cms_mst_tquickcode d on a.agent_code=d.qcd_code and d.delete_flag='N'
    left join cms_mst_tquickcode e on a.bank_code=e.qcd_code and e.delete_flag='N'
		where a.deposit_gid = in_deposit_gid and a.delete_flag = 'N';

    select
      (@row_number:=@row_number + 1) AS 'Serial No',attachment_gid as 'attachment_gid',
      file_name as 'File Name','' as 'File Path','' as 'Attachment_image_str',delete_flag
    from cms_trn_tattachment ,(SELECT @row_number:=0) as temp
    where deposit_gid=in_deposit_gid
    and delete_flag='N';
  end if;

  if in_action = 'INSERT' or in_action = 'UPDATE' then
     if in_deposit_slip_no='' then
        set err_msg := concat(err_msg,'Deposit slip no cannot be empty,');
		set err_flag := true;
     end if;
     if in_tot_chqs=0 then
        set err_msg := concat(err_msg,'Cheque Count cannot be empty,');
		set err_flag := true;
     end if;
     if in_deposit_amount=0 then
        set err_msg := concat(err_msg,'Deposit Amount cannot be empty,');
		set err_flag := true;
     end if;
     if in_client_code='' then
        set err_msg := concat(err_msg,'Client Code cannot be empty,');
		set err_flag := true;
     end if;
     if in_loc_code='' then
         set err_msg := concat(err_msg,'Location Code cannot be empty,');
		set err_flag := true;
     end if;
     if in_agent_code='' then
		set err_msg := concat(err_msg,'Agent Code cannot be empty,');
		set err_flag := true;
     end if;
  end if;

  if in_action = 'UPDATE' or in_action = 'DELETE' then
    if in_deposit_gid = 0 then
      set err_msg := concat(err_msg,'Please select the deposit,');
      set err_flag := true;
    end if;
  end if;  
  
 if in_action = 'INSERT' then
      if exists(select deposit_gid from cms_trn_tdeposit
         where deposit_slip_no = in_deposit_slip_no
         and delete_flag = 'N') then
         set err_msg := concat(err_msg,'deposit slip no already exists,');
         set err_flag := true;
      end if;
  if err_flag = false then
       start transaction;
			insert into cms_trn_tdeposit(deposit_date,deposit_slip_no,tot_chqs,deposit_amount,client_code,loc_code,agent_code,bank_code,bank_branch,mapped_amount,mapped_chq,insert_date,insert_by)
			values(in_deposit_date,in_deposit_slip_no,in_tot_chqs,in_deposit_amount,in_client_code,in_loc_code,in_agent_code,in_bank_code,in_bank_branch,in_mapped_amount,in_mapped_chq,now(),in_action_by);
       commit;
			set out_gid = last_insert_id();
			set out_result = 1;
			set out_msg = 'Record Insert Successfully!';
	end if;
 end if; 
 
 if in_action='UPDATE' then
  
      if exists(select deposit_gid from cms_trn_tdeposit
        where deposit_slip_no = in_deposit_slip_no
        and deposit_gid <> in_deposit_gid
        and delete_flag = 'N') then
        set err_msg := concat(err_msg,'Deposit Slip no already exists,');
        set err_flag := true;
      end if;
      
    start transaction;
       update cms_trn_tdeposit set
       deposit_date=in_deposit_date,
       deposit_slip_no=in_deposit_slip_no,
       tot_chqs=in_tot_chqs,
       deposit_amount=in_deposit_amount,
       client_code=in_client_code,
       loc_code=in_loc_code,
       agent_code=in_agent_code,
       bank_code=in_bank_code,
       bank_branch=in_bank_branch,
       update_date=now(),
       update_by=in_action_by
       where deposit_gid=in_deposit_gid
       and delete_flag='N';
    commit;

    set out_gid = in_deposit_gid;
    set out_result = 1;
    set out_msg = 'Record Updated Successfully!';
 end if;

 if in_action='Delete' then
  start transaction;
     update cms_trn_tdeposit set
       delete_flag='Y',
       update_date=now(),
       update_by=in_action_by
     where deposit_gid=in_deposit_gid
     and delete_flag='N';
  commit;

  set out_result = 1;
  set out_msg = 'Record Deleted Successfully!';
end if;
 
 if err_flag = true then
    set out_result = 0;
    set out_msg = err_msg;
    set out_gid=0;
    leave me;
  end if;
END $$

DELIMITER ;