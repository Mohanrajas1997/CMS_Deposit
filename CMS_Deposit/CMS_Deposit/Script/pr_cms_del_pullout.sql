DELIMITER $$

DROP PROCEDURE IF EXISTS `pr_cms_del_pullout` $$
CREATE PROCEDURE `pr_cms_del_pullout`
(
  in in_pullout_gid int,
  in in_chq_gid int,
  in in_action_by varchar(16),
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

  if not exists(select pullout_gid from cms_trn_tpullout
     where pullout_gid=in_pullout_gid and chq_gid = in_chq_gid and delete_flag='N') then
    set err_msg := concat(err_msg,'Invalid cheque !,');
	  set err_flag := true;
  end if;

  if err_flag = false then
    update cms_trn_tpullout set
      delete_flag = 'Y',
      update_date = sysdate(),
      update_by = in_action_by
    where pullout_gid = in_pullout_gid
    and chq_gid = in_chq_gid
    and delete_flag = 'N';

    update cms_trn_tcheque set
      pullout_gid = 0
    where chq_gid = in_chq_gid
    and pullout_gid = in_pullout_gid
    and clearing_gid = 0
    and delete_flag = 'N';

    set out_result = 1;
    set out_msg = 'Record deleted successfully !';
  else
    set out_result = 0;
    set out_msg = err_msg;
 end if;
END $$

DELIMITER ;