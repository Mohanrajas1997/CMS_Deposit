DELIMITER $$

DROP PROCEDURE IF EXISTS `pr_cms_get_Masterlist` $$
CREATE PROCEDURE `pr_cms_get_Masterlist`
(
  in in_master_code varchar(64)
)
BEGIN
  SELECT  a.qcd_gid as 'id',
    b.qcd_name as 'master code',a.qcd_code,a.qcd_short_code as 'short code',
    a.qcd_name as 'short desc',
    a.depend_flag as 'Dependent',
    fn_cms_get_qcdvalue(0,'QCD_MAST',a.depend_master_code) as 'Depnt Master',
    fn_cms_get_qcdvalue(0,a.depend_master_code,a.depend_qcd_code) as 'Depnt Code' FROM cms_mst_tquickcode a
  inner join cms_mst_tquickcode b on a.master_code = b.qcd_code
  where a.master_code = in_master_code and  a.delete_flag = 'N';
END $$

DELIMITER ;