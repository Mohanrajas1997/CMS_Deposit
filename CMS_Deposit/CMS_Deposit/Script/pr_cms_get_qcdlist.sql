DELIMITER $$

DROP PROCEDURE IF EXISTS `pr_cms_get_qcdlist` $$
CREATE PROCEDURE `pr_cms_get_qcdlist`
(
  in in_master_code varchar(64)
)
BEGIN

  SELECT
    qcd_gid,
    qcd_code,
    qcd_short_code,
    qcd_name,
    master_code,
    depend_flag,
    depend_master_code,
    depend_qcd_code,
    fn_cms_get_qcdshortcode(depend_master_code,depend_qcd_code) as depend_qcd_short_code,
    fn_cms_get_qcdname(depend_master_code,depend_qcd_code) as depend_qcd_name
  FROM cms_mst_tquickcode
  where master_code = in_master_code
  and  delete_flag = 'N'
  order by qcd_name;
END $$

DELIMITER ;