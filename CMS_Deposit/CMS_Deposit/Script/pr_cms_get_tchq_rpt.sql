DELIMITER $$

DROP PROCEDURE IF EXISTS `pr_cms_get_tchq_rpt` $$
CREATE PROCEDURE `pr_cms_get_tchq_rpt`(IN In_Condition Longtext)
BEGIN
   set @rownum=0;
	set @v_query=concat('select @rownum := @rownum + 1 as ''Sl No'', date_format(a.chq_date,''%d/%m/%Y'') as ''Cheque Date'',
                a.chq_no as ''Cheque No'',a.chq_amount as ''Cheque Amount'',
                a.mapped_amount as ''Mapped Amount'',date_format(b.deposit_date,''%d/%m/%Y'') as ''Deposit Date'',
                b.deposit_slip_no as ''Deposit Slip No'',b.loc_code as ''Location Code'',
                fn_cms_get_qcdname(''QCD_LOCATION'',b.loc_code) as ''Location Name'',
                b.client_code as ''Client Code'',
                fn_cms_get_qcdname(''QCD_CLIENT'',b.client_code) as ''Client Name'',
                b.bank_code as ''Bank Code'',
                fn_cms_get_qcdname(''QCD_BANK'',b.bank_code) as ''Bank Name'',b.bank_branch as ''Bank Branch'',
                b.tot_chqs as ''Total Chqs'',b.deposit_amount as ''Deposit Amount'',a.chq_gid as ''Chq Gid'',
                a.clearing_gid as ''Clearing Id'',a.deposit_gid as ''Deposit Id'',
                a.pullout_gid as ''Pullout Id'',
                c.pullout_date as ''Pullout Date'',
                c.pullout_reason as ''Pullout Reason''
                from cms_trn_tcheque as a
                inner join  cms_trn_tdeposit as b on a.deposit_gid=b.deposit_gid
                  and b.delete_flag=''N''
                left join cms_trn_tpullout as c on a.pullout_gid = c.pullout_gid and c.delete_flag = ''N''
				        Where a.delete_flag =''N''', In_Condition ,'');
            
                set @stmt_str =  @v_query;
  prepare stmt from @stmt_str;
  execute stmt;
  deallocate prepare stmt;
END $$

DELIMITER ;