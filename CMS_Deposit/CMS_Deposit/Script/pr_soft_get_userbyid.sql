DELIMITER $$

DROP PROCEDURE IF EXISTS `pr_soft_get_userbyid` $$
CREATE PROCEDURE `pr_soft_get_userbyid`
(
  in In_user_gid int
)
BEGIN
  select * from soft_mst_tuser
  where user_gid = in_user_gid
  and delete_flag = 'N';
END $$

DELIMITER ;