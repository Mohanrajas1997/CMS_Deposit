DELIMITER $$

DROP PROCEDURE IF EXISTS `pr_cms_trn_tpickup` $$
CREATE PROCEDURE `pr_cms_trn_tpickup`
(
 in in_pickup_gid int,
 in in_pickup_date varchar(64),
 in in_loc_code varchar(16),
 in in_agent_code varchar(16),
 in in_action varchar(16),
 in in_action_by varchar(16),
  out out_gid int,
  out out_msg text,
  out out_result int
)
me:BEGIN
  declare err_msg text default '';
  declare err_flag boolean default false;

  DECLARE EXIT HANDLER FOR SQLEXCEPTION
  BEGIN
    GET DIAGNOSTICS CONDITION 1 @sqlstate = RETURNED_SQLSTATE,
    @errno = MYSQL_ERRNO, @text = MESSAGE_TEXT;

    SET @full_error = CONCAT("ERROR ", @errno, " (", @sqlstate, "): ", @text);

    ROLLBACK;
    set out_result = 0;
    set out_msg = @full_error;
  END;
  IF in_action = "SELECT" THEN
    set in_pickup_gid := if(in_pickup_gid = 0,null,in_pickup_gid);
 
    SELECT a.pickup_gid, date_format(a.pickup_date,'%d/%m/%Y') as 'Pickup_Date', b.qcd_name as loc_name,c.qcd_name as agent_desc
	FROM cms_trn_tpickup a
    inner join cms_mst_tquickcode b on a.loc_code = b.qcd_code
    inner join cms_mst_tquickcode c on a.agent_code=c.qcd_code
    WHERE pickup_gid = ifnull(in_pickup_gid,a.pickup_gid)  and a.delete_flag = 'N';

	SELECT pickupdtl_gid as 'PickupdtlsGid',pickup_gid as 'Pickup_Gid',client_code as 'qcd_client_code', 
    b.qcd_short_code as 'Client_Code',b.qcd_name as 'ClientName',pp_code as 'qcd_pickup_code',
    c.qcd_name as 'PickupPoint',tot_chqs as 'Tot_chqs',case when client_ack='Y' then 'YES' else 'NO' end as 'Client_Ack',
    'N' as SaveFlag,a.delete_flag as DeleteFlag
    FROM cms_trn_tpickupdtl a inner join cms_mst_tquickcode b
    on a.client_code=b.qcd_code and b.delete_flag='N'
    inner join cms_mst_tquickcode as c on a.pp_code=c.qcd_code and c.delete_flag='N'
    WHERE pickup_gid = ifnull(in_pickup_gid,pickup_gid)   and a.delete_flag = 'N';
 
  END IF;
  	set out_gid=0;
  IF in_action = "SELECT" THEN
    set in_pickup_gid := if(in_pickup_gid = 0,null,in_pickup_gid);
  END IF;
  IF in_action = "INSERT" THEN
	  if exists(select pickup_gid from cms_trn_tpickup
      where pickup_date = in_pickup_date and loc_code=in_loc_code and agent_code= in_agent_code
      and delete_flag = 'N') then
		  set err_msg := concat(err_msg,'Duplicate entity code,');
		  set err_flag := true;
    end if;
     if err_flag = false then
		  START TRANSACTION;

		  INSERT INTO cms_trn_tpickup(pickup_date, loc_code, agent_code, insert_date, insert_by)
		  VALUES (in_pickup_date,in_loc_code,in_agent_code,now(),in_action_by);

		  COMMIT;
      set out_gid = LAST_INSERT_ID(); 
      set out_msg = 'Record saved successfully';
    else
      set out_result = 0;
      set out_msg = err_msg;
      leave me;
    end if;
  End if;  
    IF in_action = "UPDATE" THEN
	  if in_pickup_gid = 0 then
		  set err_msg := concat(err_msg,'Blank pickup gid,');
		  set err_flag := true;
	  end if;
      
  if err_flag = false then
      START TRANSACTION;

      UPDATE cms_trn_tpickup set
        pickup_date = in_pickup_date,
        loc_code = in_loc_code,
        agent_code = in_agent_code,  
        update_date = sysdate(),
        update_by = in_action_by
      WHERE pickup_gid = in_pickup_gid
      and delete_flag = 'N';

      COMMIT;
	  set out_gid=in_pickup_gid;
      set out_msg = 'Record saved successfully';
    else
      set out_result = 0;
      set out_msg = err_msg;
      leave me;
    end if;	
   End if; 
   
 IF in_action = "DELETE" THEN
    START TRANSACTION;

    UPDATE cms_trn_tpickup set
      delete_flag = 'Y',
      update_date = sysdate(),
      update_by = in_action_by
    WHERE pickup_gid = in_pickup_gid
    and delete_flag = 'N';

    COMMIT;

    set out_msg = 'Record deleted successfully';
  END IF;
 
  set out_result = 1;
END $$

DELIMITER ;