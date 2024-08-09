DELIMITER $$

DROP PROCEDURE IF EXISTS `pr_cms_ins_tclearing` $$
CREATE PROCEDURE `pr_cms_ins_tclearing`
(
  in in_clrg_gid int,
  in in_file_gid int,
  in in_clrg_date varchar(12),
  in in_clrg_loc_code varchar(16),
  in in_client_code varchar(16),
  in in_chq_date varchar(12),
  in in_chq_no varchar(16),
  in in_chq_amount double(15,2),
  in in_micr_code varchar(9),
  in in_tran_code varchar(3),
  in in_base_code varchar(16),
  in in_acc_no varchar(32),
  in in_cust_name varchar(128),
  in in_deposit_date varchar(12),
  in in_deposit_slip_no varchar(16),
  in in_deposit_amount double(15,2),
  in in_loc_code varchar(16),
  in in_bank_code varchar(16),
  in in_bank_acc_no varchar(32),
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
    set out_gid = 0;
    set out_result = 0;
  END;

  if in_action='INSERT' then
    if in_file_gid=0 then
      set err_msg := concat(err_msg,'File Gid cannot be empty,');
		  set err_flag := true;
    end if;

    if in_clrg_date='' then
      set err_msg := concat(err_msg,'Clearing Date cannot be empty,');
		  set err_flag := true;
    end if;

    if in_clrg_loc_code='' then
	    set err_msg := concat(err_msg,'Clearing Location Code cannot be empty,');
		  set err_flag := true;
    end if;

    if in_client_code='' then
	    set err_msg := concat(err_msg,'Client Code cannot be empty,');
		  set err_flag := true;
    end if;

    if in_chq_date='' then
	    set err_msg := concat(err_msg,'Cheque Date cannot be empty,');
		  set err_flag := true;
    end if;

    if in_chq_no='' then
	    set err_msg := concat(err_msg,'Cheque no cannot be empty,');
		  set err_flag := true;
    end if;

    if in_chq_amount=0 then
      set err_msg := concat(err_msg,'Cheque amount cannot be empty,');
		  set err_flag := true;
    end if;

    if in_micr_code='' then
      set err_msg := concat(err_msg,'Micr Code cannot be empty,');
      set err_flag := true;
    end if;

    if in_tran_code='' then
      set err_msg := concat(err_msg,'Tran Code cannot be empty,');
      set err_flag := true;
    end if;

    /*
    if in_base_code='' then
      set err_msg := concat(err_msg,'Base Code cannot be empty,');
      set err_flag := true;
    end if;
    */

    if in_acc_no ='' then
	    set err_msg := concat(err_msg,'Acc No cannot be empty,');
	    set err_flag := true;
    end if;

    if in_cust_name='' then
  	  set err_msg := concat(err_msg,'Customer Name cannot be empty,');
	    set err_flag := true;
    end if;

    if in_deposit_date ='' then
      set err_msg := concat(err_msg,'Deposit Date cannot be empty,');
	    set err_flag := true;
    end if;

    if in_deposit_slip_no='' then
      set err_msg := concat(err_msg,'Deposit Slip NO cannot be empty,');
	    set err_flag := true;
    end if;

    if in_deposit_amount =0 then
      set err_msg := concat(err_msg,'Deposit Amount cannot be empty,');
	    set err_flag := true;
    end if;

    if in_loc_code='' then
      set err_msg := concat(err_msg,'Location Code cannot be empty,');
	    set err_flag := true;
    end if;

    if in_bank_code='' then
      set err_msg := concat(err_msg,'Bank Code cannot be empty,');
	    set err_flag := true;
    end if;

    if in_bank_acc_no='' then
	    set err_msg := concat(err_msg,'Bank acc no cannot be empty,');
	    set err_flag := true;
    end if;

    if exists(select clrg_gid from cms_trn_tclearing where clrg_date=in_clrg_date
      and clrg_loc_code=in_clrg_loc_code and client_code=in_client_code and chq_date=in_chq_date
      and chq_no=in_chq_no and chq_amount=in_chq_amount ) then

      set err_msg := concat(err_msg,'Duplicate Clearing entry!,');
      set err_flag := true;
    end if;
  end if;

  if err_flag = true then
    set out_result = 0;
    set out_msg = err_msg;
    set out_gid=0;
    leave me;
  end if;

  if err_flag=false then
    if in_action='INSERT' then
      Start transaction;
       insert into cms_trn_tclearing(file_gid,clrg_date,clrg_loc_code,client_code,chq_date,chq_no,chq_amount,micr_code,
                                      tran_code,base_code,acc_no,cust_name,deposit_date,deposit_slip_no,deposit_amount,
                                      loc_code,bank_code,bank_acc_no,insert_date,insert_by)
       values(in_file_gid,in_clrg_date,in_clrg_loc_code,in_client_code,in_chq_date,in_chq_no,in_chq_amount,in_micr_code,
              in_tran_code,in_base_code,in_acc_no,in_cust_name,in_deposit_date,in_deposit_slip_no,in_deposit_amount,
                                      in_loc_code,in_bank_code,in_bank_acc_no,now(),in_action_by);
      commit;

      set out_gid = last_insert_id();
			set out_result = 1;
			set out_msg = 'Record Insert Successfully!';
    end if;
  end if;
END $$

DELIMITER ;