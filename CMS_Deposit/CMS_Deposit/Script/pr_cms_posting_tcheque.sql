DELIMITER $$

DROP PROCEDURE IF EXISTS `pr_cms_posting_tcheque` $$
CREATE PROCEDURE `pr_cms_posting_tcheque`
(
  in in_clrg_gid int,
  in in_client_code varchar(16),
  in in_chq_date varchar(16),
  in in_chq_no varchar(16),
  in in_chq_amount double(15,2),
  out out_msg text,
  out out_result int(10)
)
BEGIN
  declare v_chq_gid int default 0;

  select a.chq_gid into v_chq_gid from cms_trn_tcheque as a
  inner join cms_trn_tdeposit as b on a.deposit_gid=b.deposit_gid and b.delete_flag='N'
  where b.client_code=in_client_code and a.chq_date=in_chq_date
  and a.chq_no=in_chq_no and a.chq_amount=in_chq_amount and a.delete_flag='N';

  if v_chq_gid>0 then
    update cms_trn_tcheque as a
    inner join cms_trn_tdeposit as b on a.deposit_gid=b.deposit_gid and b.delete_flag='N'
    set
      a.clearing_gid=in_clrg_gid
    where b.client_code=in_client_code
    and a.chq_date=in_chq_date
    and a.chq_no=in_chq_no
    and a.chq_amount=in_chq_amount
    and a.delete_flag='N';

    update cms_trn_tclearing set
      chq_gid=v_chq_gid
    where clrg_gid=in_clrg_gid
    and delete_flag='N';

    set out_result=1;
    set out_msg="Record updated successfully !";
  else
    set out_result=0;
    set out_msg="Record not found !";
  end if;
END $$

DELIMITER ;