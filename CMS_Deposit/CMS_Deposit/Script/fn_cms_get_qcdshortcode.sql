DELIMITER $$

DROP FUNCTION IF EXISTS `fn_cms_get_qcdshortcode` $$
CREATE FUNCTION `fn_cms_get_qcdshortcode`
(
  in_master_code varchar(32),
  in_qcd_code varchar(32)
) RETURNS text CHARSET latin1
begin
  declare v_result text default '';

  set v_result =  (select qcd_short_code from cms_mst_tquickcode
                   where master_code = in_master_code
                   and qcd_code = in_qcd_code
                   and delete_flag = 'N');

  set v_result = ifnull(v_result,'');

  return v_result;
END $$

DELIMITER ;