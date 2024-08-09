DELIMITER $$

DROP PROCEDURE IF EXISTS `pr_soft_ins_user` $$
CREATE PROCEDURE `pr_soft_ins_user`(
  in in_user_gid int,
  in in_user_code varchar(16),
  in in_user_name varchar(128),
  in in_addr1 text,
  in in_addr2 varchar(64),
  in in_addr3 varchar(64),
  in in_addr4 varchar(64),
  in in_city varchar(64),
  in in_pincode varchar(8),
  in in_mobile_no varchar(255),
  in in_mail_id varchar(128),
  in in_sex varchar(8),
  in in_dob date,
  in in_doj date, 
  in in_desig_name varchar(64),
  in in_dept_name varchar(64),
  in in_user_status char(1),
  in in_pwd_flag boolean,
  in in_usergroup_gid int,
  in in_action varchar(8),
  out out_gid int,
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
  
   if in_action = 'INSERT' or in_action = 'UPDATE' then
    if in_user_code = '' then
      set err_msg := concat(err_msg,'User code cannot be empty,');
      set err_flag := true;
    end if;
    
   if in_user_name = '' then
      set err_msg := concat(err_msg,'User name cannot be empty,');
      set err_flag := true;
    end if;
    if in_sex = '' then
      set err_msg := concat(err_msg,'Sex cannot be empty,');
      set err_flag := true;
    end if;
    if in_desig_name = '' then
      set err_msg := concat(err_msg,'Designation cannot be empty,');
      set err_flag := true;
    end if;
    if in_dept_name = '' then
      set err_msg := concat(err_msg,'Department cannot be empty,');
      set err_flag := true;
    end if;
   end if; 
  if in_action = 'UPDATE' or in_action = 'DELETE' then
    if in_user_gid = 0 then
      set err_msg := concat(err_msg,'Please select the user,');
      set err_flag := true;
    end if;
  end if;
  if err_flag = false then
    if in_action = 'INSERT' then
      if exists(select user_gid from soft_mst_tuser
        where user_code = in_user_code
        and delete_flag = 'N') then
        set err_msg := concat(err_msg,'User code already exists,');
        set err_flag := true;
      end if;

      if exists(select user_gid from soft_mst_tuser
        where mobile_no = in_mobile_no
        and delete_flag = 'N') then
        set err_msg := concat(err_msg,'Mobile no already exists,');
        set err_flag := true;
      end if;

      if exists(select user_gid from soft_mst_tuser
        where mail_id = in_mail_id
        and delete_flag = 'N') then
        set err_msg := concat(err_msg,'Mail id already exists,');
        set err_flag := true;
      end if;
    end if;

	if in_action = 'UPDATE' then
      if exists(select user_gid from soft_mst_tuser
        where user_code = in_user_code
        and user_gid <> in_user_gid
        and delete_flag = 'N') then
        set err_msg := concat(err_msg,'User code already exists,');
        set err_flag := true;
      end if;

      if exists(select user_gid from soft_mst_tuser
        where mobile_no = in_mobile_no
        and user_gid <> in_user_gid
        and delete_flag = 'N') then
        set err_msg := concat(err_msg,'Mobile no already exists,');
        set err_flag := true;
      end if;

      if exists(select user_gid from soft_mst_tuser
        where mail_id = in_mail_id
        and user_gid <> in_user_gid
        and delete_flag = 'N') then
        set err_msg := concat(err_msg,'Mail id already exists,');
        set err_flag := true;
      end if;
    end if;

    if in_action = 'DELETE' then
      if 1 = 2
        then
        set err_msg := concat(err_msg,'Duplicate record,');
        set err_flag := true;
      end if;
    end if;
   end if;
   if err_flag = true then
    set out_result = 0;
    set out_msg = err_msg;
    leave me;
  end if;
  if in_action = 'SELECT' then
  set in_user_gid := if(in_user_gid = 0,null,in_user_gid);
		select a.user_gid,a.user_code,a.user_name,a.sex,a.addr1,a.addr2,a.addr3,a.addr4,a.city,a.pincode,
        a.mobile_no,a.mail_id,a.dob,a.doj,a.dor,a.desig_name,a.dept_name,b.usergroup_name,a.user_status,a.auth_flag
        from soft_mst_tuser a
        inner join soft_mst_tusergroup b on b.usergroup_gid = a.usergroup_gid
		where a.user_gid = in_user_gid and a.delete_flag = 'N';

    Select a.entity_gid as entitygid,b.entity_code as entitycode,entity_name as entityname from soft_mst_tuserentity a
        inner join kha_mst_tentity b on a.entity_gid = b.entity_gid where a.user_gid = in_user_gid
        and a.delete_flag = 'N' order by b.entity_name asc;
  end if;

  if in_action = 'INSERT' then
   start transaction;
   insert into soft_mst_tuser
    (
      user_code,
      user_name,
      addr1,
      addr2,
      addr3,
      addr4,
      city,
      pincode,
      mobile_no,
      mail_id,
      sex,
      dob,
      doj,
      desig_name,
      dept_name,
      user_status,
      usergroup_gid,
      auth_flag
    )
    values
    (
      in_user_code,
      in_user_name,
      in_addr1,
      in_addr2,
      in_addr3,
      in_addr4,
      in_city,
      in_pincode,
      in_mobile_no,
      in_mail_id,
      in_sex,
      in_dob,
      in_doj,
      in_desig_name,
      in_dept_name,
      'Y',
      in_usergroup_gid,
      'Y'
    );



 commit;
    set out_gid = last_insert_id();
     set out_result = 1;
     set out_msg = 'Record Insert Successfully!';
end if;

if in_action='UPDATE' then
  start transaction;
   update soft_mst_tuser set
      user_code=in_user_code,
      user_name=in_user_name,
      addr1=in_addr1,
      addr2=in_addr2,
      addr3=in_addr3,
      addr4=in_addr4,
      city=in_city,
      pincode=in_pincode,
      mobile_no=in_mobile_no,
      mail_id=in_mail_id,
      sex=in_sex,
      dob=in_dob,
      doj=in_doj,
      desig_name=in_desig_name,
      dept_name=in_dept_name,
      pwd = if(in_pwd_flag = true,'',pwd),
      user_status='Y',
      usergroup_gid=in_usergroup_gid,
      auth_flag='Y'
      where user_gid=in_user_gid;

   commit;
    set out_gid = in_user_gid;
	 set out_result = 1;
     set out_msg = 'Record Updated Successfully!';
end if;
if in_action='Delete' then
  start transaction;
   update soft_mst_tuser
   set delete_flag='Y'
   where user_gid=in_user_gid
   and delete_flag='N';
  commit;
  	 set out_result = 1;
     set out_msg = 'Record Deleted Successfully!';
end if;
END $$

DELIMITER ;