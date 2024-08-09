DELIMITER $$

DROP PROCEDURE IF EXISTS `pr_cms_ins_pullout` $$
CREATE PROCEDURE `pr_cms_ins_pullout`
(
  in in_chq_gid int,
  in in_pullout_date date,
  in in_pullout_reason varchar(255),
  in in_action_by varchar(16),
  out out_gid int,
  out out_msg text,
  out out_result int(10)
)
me:BEGIN
  declare err_msg text default '';
  declare err_flag varchar(10) default false;
  declare v_pullout_gid int default 0;

 DECLARE EXIT HANDLER FOR SQLEXCEPTION
  BEGIN
    GET DIAGNOSTICS CONDITION 1 @sqlstate = RETURNED_SQLSTATE,
    @errno = MYSQL_ERRNO, @text = MESSAGE_TEXT;

    SET @full_error = CONCAT("ERROR ", @errno, " (", @sqlstate, "): ", @text);

    ROLLBACK;

    set out_msg = @full_error;
    set out_result = 0;
  END;

  if not exists(select chq_gid from cms_trn_tcheque
     where chq_gid=in_chq_gid and pullout_gid = 0 and clearing_gid = 0 and delete_flag='N') then
    set err_msg := concat(err_msg,'Invalid cheque !,');
	  set err_flag := true;
  end if;

  if in_pullout_reason = '' then
    set err_msg := concat(err_msg,'Pullout reason cannot be blank !,');
	  set err_flag := true;
  end if;

  if err_flag = false then
    insert into cms_trn_tpullout
    (
      pullout_date,
      pullout_reason,
      chq_gid,
      insert_date,
      insert_by
    )
    values
    (
      in_pullout_date,
      in_pullout_reason,
      in_chq_gid,
      sysdate(),
      in_action_by
    );

    set v_pullout_gid = (select max(pullout_gid) from cms_trn_tpullout where chq_gid = in_chq_gid and delete_flag = 'N');

    set v_pullout_gid = ifnull(v_pullout_gid,0);

    if v_pullout_gid > 0 then
      update cms_trn_tcheque set
        pullout_gid = in_pullout_gid
      where chq_gid = in_chq_gid
      and pullout_gid = 0
      and clearing_gid = 0
      and delete_flag = 'N';

      set out_result = 1;
      set out_msg = 'Record saved successfully !';
      set out_gid = v_pullout_gid;
    else
      set out_result = 0;
      set out_msg = 'Record failed to save !';
      set out_gid = 0;
    end if;
  else
    set out_result = 0;
    set out_msg = err_msg;
    set out_gid=0;
 end if;
END $$

DELIMITER ;