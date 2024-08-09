DELIMITER $$

DROP PROCEDURE IF EXISTS `pr_cms_get_tchqlist` $$
CREATE PROCEDURE `pr_cms_get_tchqlist`(IN in_deposit_gid int)
BEGIN
	select
    a.chq_gid,
    a.deposit_gid,
    a.pullout_gid,
    a.chq_no as 'Cheque No',
    date_format(a.chq_date,'%d/%m/%Y') as 'Cheque Date',
    a.chq_amount as 'Cheque Amount',
    b.pullout_date as 'Pullout Date',
    b.pullout_reason as 'Pullout Reason'
	from cms_trn_tcheque as a
  left join cms_trn_tpullout as b on a.chq_gid = b.chq_gid and b.delete_flag = 'N'
	where a.deposit_gid=in_deposit_gid
  and a.clearing_gid = 0 
  and a.delete_flag='N';
END $$

DELIMITER ;