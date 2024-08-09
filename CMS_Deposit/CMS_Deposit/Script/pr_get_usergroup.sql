DELIMITER $$

DROP PROCEDURE IF EXISTS `pr_get_usergroup`$$
CREATE procedure `pr_get_usergroup`()
BEGIN
SELECT
    usergroup_gid, usergroup_name
FROM
    soft_mst_tusergroup
WHERE
    delete_flag = 'N';
END $$

DELIMITER ;