DELIMITER $$

DROP PROCEDURE IF EXISTS `pr_cms_trn_tchequenew`$$
CREATE PROCEDURE  `pr_cms_trn_tchequenew`(
  in in_deposit_gid int,
  in in_chq_gid int,
  in in_chq_date varchar(16),
  in in_chq_no varchar(16),
  in in_chq_amount double(15,2),
  in in_acc_holder varchar(128),
  in in_micr_code varchar(9),
  in in_tran_code varchar(2),
  in in_mapped_amount double(15,2),
  in in_clearing_gid int,
  in in_ref_no varchar(64),
  in in_ref_amount double(15,2),
  in in_action varchar(8),
  in in_action_by varchar(16),
  out out_gid int,
  out out_msg text,
  out out_result int(10)
)
me:BEGIN
  declare err_msg text default '';
  declare err_flag varchar(10) default false;
  declare v_chq_gid int default 0;
  declare v_chq_count int default 0;
  declare v_chq_amount int default 0;
  declare v_deposit_amount int default 0;
  
  DECLARE EXIT HANDLER FOR SQLEXCEPTION
  BEGIN
    GET DIAGNOSTICS CONDITION 1 @sqlstate = RETURNED_SQLSTATE,
    @errno = MYSQL_ERRNO, @text = MESSAGE_TEXT;

    SET @full_error = CONCAT("ERROR ", @errno, " (", @sqlstate, "): ", @text);

    ROLLBACK;

    set out_gid = 0;
    set out_msg = @full_error;
    set out_result = 0;
  END;

  set in_acc_holder = ifnull(in_acc_holder,'');

if in_action = 'INSERT' or in_action = 'UPDATE' then
  if in_deposit_gid=0 then
     set err_msg := concat(err_msg,'Deposit gid cannot be empty,');
	 set err_flag := true;
  end if;
  if in_chq_date='' then
      set err_msg := concat(err_msg,'Chq Date cannot be empty,');
	 set err_flag := true;
  end if;
  if in_chq_no='' then
      set err_msg := concat(err_msg,'Chq no cannot be empty,');
	 set err_flag := true;  
  end if;

  if in_chq_amount=0 then
	 set err_msg := concat(err_msg,'Chq amount cannot be empty,');
	 set err_flag := true;
  end if;

  if in_acc_holder = '' then
	 set err_msg := concat(err_msg,'A/c holder name cannot be empty,');
	 set err_flag := true;
  end if;

  if in_micr_code = '' then
	 set err_msg := concat(err_msg,'Micr Code cannot be empty,');
	 set err_flag := true;
  end if;

  if in_tran_code = '' then
	 set err_msg := concat(err_msg,'Tran Code cannot be empty,');
	 set err_flag := true;
  end if;

  if not exists(select deposit_gid from cms_trn_tdeposit
      where deposit_gid=in_deposit_gid and delete_flag='N'  ) then
      set err_msg := concat(err_msg,'Not valid deposit gid,');
	  set err_flag := true;
  end if;
end if;

  if in_action = 'INSERT' then
    if exists(select deposit_gid from cms_trn_tcheque
			where deposit_gid = in_deposit_gid
			and chq_date=in_chq_date
			and chq_no=in_chq_no
			and chq_amount=in_chq_amount
			and delete_flag = 'N') then

      set err_msg := concat(err_msg,'Cheque entry already exists,');
      set err_flag := true;
    end if;

    select sum(chq_amount) into v_chq_amount from cms_trn_tcheque
    where deposit_gid=in_deposit_gid and delete_flag='N';

    select deposit_amount into v_deposit_amount from cms_trn_tdeposit
    where deposit_gid=in_deposit_gid and delete_flag='N';

    set v_chq_amount=(ifnull(v_chq_amount,0) + in_chq_amount);

	  if v_chq_amount > v_deposit_amount then
	   set err_msg := concat(err_msg,'Chq Amount greater then deposit amount,');
	   set err_flag := true;
    end if;

    if err_flag=false then
        insert into cms_trn_tcheque(deposit_gid,chq_date,chq_no,chq_amount,acc_holder_name,micr_code,tran_code,insert_date,insert_by)
        values(in_deposit_gid,in_chq_date,in_chq_no,in_chq_amount,in_acc_holder,in_micr_code,in_tran_code,now(),in_action_by);

        set v_chq_gid=last_insert_id();
        set out_gid=last_insert_id();

        update cms_trn_tdeposit set
          mapped_chq=(mapped_chq+1) ,
          mapped_amount=v_chq_amount
        where deposit_gid=in_deposit_gid
        and delete_flag='N';

        insert into cms_trn_tenrichment(deposit_gid,chq_gid,ref_no,ref_amount,insert_date,insert_by)
        values(in_deposit_gid,v_chq_gid,in_ref_no,in_ref_amount,now(),in_action_by);

        set out_result = 1;
			  set out_msg = 'Record Insert Successfully!';

        update cms_trn_tcheque set
          mapped_amount=(mapped_amount+in_ref_amount)
        where chq_gid=v_chq_gid
        and deposit_gid=in_deposit_gid
        and delete_flag='N';
    end if;
  end if;

  if in_action = 'UPDATE' then
    select
      sum(chq_amount) into v_chq_amount
    from cms_trn_tcheque
    where chq_gid <>in_chq_gid
    and deposit_gid=in_deposit_gid
    and delete_flag='N';

    select deposit_amount into v_deposit_amount from cms_trn_tdeposit
    where deposit_gid=in_deposit_gid
    and delete_flag='N';

    set v_chq_amount=(v_chq_amount + in_chq_amount);

	  if v_chq_amount > v_deposit_amount then
	     set err_msg := concat(err_msg,'Chq Amount greater then deposit amount,');
	     set err_flag := true;
    end if;

    if err_flag=false then
      update cms_trn_tcheque set
        chq_date=in_chq_date,
        chq_no=in_chq_no,
        chq_amount=in_chq_amount,
        acc_holder_name = in_acc_holder,
        micr_code = in_micr_code,
        tran_code = in_tran_code,
        update_date=now(),
        update_by=in_action_by
      where chq_gid=in_chq_gid
      and deposit_gid=in_deposit_gid
      and delete_flag='N';

      set out_gid=in_chq_gid;
      set out_result = 1;
      set out_msg = 'Record Updated Successfully!';

      select count(*),sum(chq_amount) into v_chq_count,v_chq_amount from cms_trn_tcheque
      where deposit_gid=in_deposit_gid and delete_flag='N';

      update cms_trn_tdeposit set
        mapped_chq=v_chq_count ,
        mapped_amount=v_chq_amount
      where deposit_gid=in_deposit_gid
      and delete_flag='N';
    end if;
  end if;

  if in_action = 'DELETE' then
    select
      sum(chq_amount) into v_chq_amount
    from cms_trn_tcheque
    where deposit_gid=in_deposit_gid
    and chq_gid=in_chq_gid
    and delete_flag='N';

	update cms_trn_tcheque set
      delete_flag='Y',
      update_date=now(),
      update_by=in_action_by
    where chq_gid=in_chq_gid
    and deposit_gid=in_deposit_gid
    and delete_flag='N';

    update cms_trn_tdeposit set
      mapped_amount=(mapped_amount-v_chq_amount),
      mapped_chq=(mapped_chq-1)
    where deposit_gid=in_deposit_gid
    and delete_flag='N';

	update cms_trn_tenrichment set 
      delete_flag='Y',
      update_date=now(),
      update_by=in_action_by
    where chq_gid=in_chq_gid
    and deposit_gid=in_deposit_gid
    and delete_flag='N';
    
    set out_gid=in_chq_gid;
    set out_result = 1;
    set out_msg = 'Record Deleted Successfully!';
  end if;

  if err_flag = true then
    set out_result = 0;
    set out_msg = err_msg;
    set out_gid=0;
 end if;
END $$

DELIMITER ;