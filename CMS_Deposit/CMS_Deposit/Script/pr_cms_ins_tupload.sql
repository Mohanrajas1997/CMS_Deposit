DELIMITER $$

DROP PROCEDURE IF EXISTS `pr_cms_ins_tupload` $$
CREATE PROCEDURE `pr_cms_ins_tupload`(
in in_clrg_fromdt varchar(16),
in in_clrg_todt varchar(16),
in in_upload_gid int,
in in_upload_code varchar(8),
in in_upload_sno int,
in in_action varchar(8),
in in_action_by varchar(16),
  out out_gid int,
  out out_msg text,
  out out_result int(10)
)
me:BEGIN
  declare err_msg text default '';
  declare err_flag bool default false;
  declare v_chq_amount double(15,2) default 0;
  declare v_ref_amount double(15,2) default 0;
  
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
  
  if in_action='INSERT' then
    if in_upload_code='' then
		 set err_msg := concat(err_msg,'Upload Code cannot be empty,');
		 set err_flag := true;
    end if;

    if in_upload_sno=0 then
		  set err_msg := concat(err_msg,'Upload slno cannot be empty,');
		  set err_flag := true;
    end if;

    if exists(select upload_gid from cms_trn_tupload where upload_code=in_upload_code and delete_flag='N') then
      set err_msg := concat(err_msg,'Duplicate Upload code,');
      set err_flag := true;
    end if;

    if exists(select chq_gid from cms_trn_tclearing where chq_gid = 0 and delete_flag = 'N') then
      set err_msg := concat(err_msg,'Few clearing cheque(s) were not posted !,');
      set err_flag := true;
    end if;
  end if;

if in_action='DELETE' then
	 if in_upload_gid =0 then
		set err_msg := concat(err_msg,'Upload gid cannot be empty,');
		set err_flag := true;
	 end if;
end if;

if err_flag=false then

  select in_action,err_msg,err_flag;

  if in_action='INSERT' then
     if exists(select clrg_gid from cms_trn_tclearing where clrg_date >=in_clrg_fromdt
       and clrg_date <=in_clrg_todt and chq_gid>0 and upload_gid=0 and delete_flag='N' ) then

       start transaction;
         insert into  cms_trn_tupload(upload_date,upload_code,upload_sno,insert_date,insert_by)
         value(CURDATE(),in_upload_code,in_upload_sno,now(),in_action_by);
       commit;

       set out_gid=last_insert_id();
       set out_result = 1;
       set out_msg = 'Record Insert successfully!';

       start transaction;
         update cms_trn_tclearing
         set upload_gid=out_gid
         where clrg_date >=in_clrg_fromdt
         and clrg_date <=in_clrg_todt
         and chq_gid>0
         and upload_gid=0
         and delete_flag='N';
       commit;
	   else
       set out_gid = 0;
       set out_result = 0;
       set out_msg = 'No record found !';
     end if;
  end if;

	if in_action='DELETE' then
	  start transaction;

		update cms_trn_tupload
		set delete_flag='Y'
		where upload_gid=in_upload_gid
		and delete_flag='N';

		update cms_trn_tclearing
		set upload_gid=0
		where upload_gid=in_upload_gid
		and delete_flag='N';

	  commit;

		set out_gid=in_upload_gid;
		set out_result = 1;
		set out_msg = 'Record deleted successfully!';
	end if;
else
  set out_result = 0;
  set out_msg = err_msg;
  set out_gid=0;
end if;
END $$

DELIMITER ;