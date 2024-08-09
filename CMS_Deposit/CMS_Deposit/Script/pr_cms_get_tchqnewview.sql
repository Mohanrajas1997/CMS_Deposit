DELIMITER $$

DROP PROCEDURE IF EXISTS `pr_cms_get_tchqnewview` $$
CREATE PROCEDURE `pr_cms_get_tchqnewview`(IN in_deposit_gid int)
BEGIN
	select a.chq_gid as chq_gid,
    a.deposit_gid as deposit_gid,
    a.chq_no as chq_no,
    date_format(a.chq_date,'%d/%m/%Y') as chq_date,
    a.chq_amount as chq_amount,
    ifnull(a.acc_holder_name,'') as acc_holder_name,
    ifnull(a.micr_code,'') as micr_code,
    ifnull(a.tran_code,'') as tran_code
	from cms_trn_tcheque as a
  inner join cms_trn_tdeposit as b on a.deposit_gid=b.deposit_gid and b.delete_flag='N'
	where 1 = 1
  and a.deposit_gid=in_deposit_gid
  and a.delete_flag='N';
END $$

DELIMITER ;