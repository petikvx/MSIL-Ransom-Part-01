namespace System.ServiceModel.Activation;

internal static class RoutingTable
{
	private class MessageQueueAndPath
	{
		private _003F messageQueue;

		private _003F uri;

		internal _003F MessageQueue => messageQueue;

		internal _003F Uri => uri;

		internal MessageQueueAndPath()
		{
			//Discarded unreachable code: IL_0006
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			/*Error near IL_0001: Unexpected SignatureTypeCode: (0x30b).*/;
		}
	}

	private static _003F namedPipeMessageQueues;

	private static _003F tcpMessageQueues;

	internal static _003F Lookup()
	{
		//Discarded unreachable code: IL_0023, IL_002a, IL_003d, IL_0043, IL_0046, IL_0050, IL_0054, IL_005e, IL_0064, IL_0067, IL_0071, IL_0075, IL_007f, IL_0085, IL_0088, IL_0092, IL_0099, IL_00af, IL_00b6, IL_00b9, IL_00c0
		//Error decoding local variables: Signature type sequence must have at least one element.
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Expected I4, but got Unknown
		//IL_0017: Expected I4, but got Unknown
		//IL_001e: Expected I4, but got Unknown
		//IL_001e: Expected I4, but got Unknown
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_004e: Incompatible stack heights: 0 vs 2
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Incompatible stack heights: 0 vs 2
		//IL_008b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0090: Incompatible stack heights: 0 vs 2
		//IL_00aa: Expected I4, but got Unknown
		//IL_00aa: Expected I4, but got O
		//IL_00b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b1: Incompatible stack heights: 0 vs 3
		//IL_00bf: Expected O, but got Unknown
		//IL_00ba: Unknown result type (might be due to invalid IL or missing references)
		/*Error: ldarg 0 (out-of-bounds)*/;
		/*Error near IL_0001: stloc 0 (out-of-bounds)*/;
		_ = namedPipeMessageQueues;
		/*Error near IL_0007: stloc 1 (out-of-bounds)*/;
		if ((int)/*Error near IL_0008: ldarg 1 (out-of-bounds)*/ != 0)
		{
			_003F val = /*Error near IL_000b: ldarg 0 (out-of-bounds)*/;
			bool num = ((Uri)/*Error near IL_0011: Stack underflow*/)._002F_FFFD_FFFD_FFFD0_000C_FFFDI_FFFD_0015_0004_FFFD_0014_FFFDJ_FFFD_002F_005DI_0014_0016j_FFFD_0019_FFFD_FFFDZ_0014_001D_FFFD_0005_FFFD0_000C_005DtB_j_0355nz_FFFD_FFFD_007En_FFFD_FFFDxj_FFFD_000C_FFFDI4i_FFFD_0019_FFFD_FFFDZ_0014_001D_FFFD_0005_FFFD0_000C_005Dt_003Emi_FFFD_FFFD_007Cn_FFFDb_003Ai_FFFD_FFFD_000C_FFFDI4i_FFFD_0019_FFFD_FFFDZ_0014_001D_FFFD_FFFDUd_030E_FFFD_000C_FFFDՈ0_000CU_0014_FFFD_0014_0004_FFFD_FFFDQ_FFFD_000C_FFFD_FFFD_0005_FFFD7_003F_FFFDr_000F_000D_0005_FFFD_002F_FFFD_000D_FFFD_003F_FFFD_0023_FFFD_002F_FFFD_FFFDq_FFFD_FFFD_0004_FFFD_FFFDQ_FFFD_0014m_002B_FFFD_FFFD_FFFD_FFFD_FFFD_FFFD_FFFD_0008_001D_000C_0004_0013v_FFFD_0004_FFFD8t_0014_0013y0_0004_FFFD_000C_FFFDqu0_000C_FFFD_FFFD_0014_000Cz_FFFD_FFFDr_001Ec_FFFD_000Bz_FFFD_0018f_FFFD0_FFFDJi_FFFD_FFFD_FFFD_001E_FFFD_0006_0019_000Dy_FFFD_FFFD_FFFD鉤_0012_FFFD_0006_0011_000Dz_FFFDc_FFFD_FFFD_FFFD_FFFDa_0001ܚ4o_FFFD0b_FFFD_0016_007E_FFFDVqK_000B_0004_FFFD_FFFDv_0005_FFFD_FFFD_FFFDI_FFFD_0019_0004_FFFD_002C_FFFDJ_FFFD_002F_005D_0029_FFFD_FFFD_FFFDPPv_FFFD_0006_FFFD0_000C_FFFD_FFFD_0020_FFFDZY_FFFDY_FFFD_0012_007E_FFFD_FFFD_FFFD_0008_000F_0005_FFFD0_FFFDJ_FFFD_FFFD_FFFDZU_FFFDv_0015_0016_007E_FFFDV_FFFD0_000Bz_FFFD0b鈆_FFFD_FFFD_0028_000Cz_FFFD_FFFDQ_000D_FFFD_FFFD0_FFFD_0006_0029_000Dy_FFFDc_FFFD_FFFD_FFFD_FFFD_000D_FFFDn_FFFD_FFFDZ_0014_001D_FFFD_FFFDQ_002F_000C_0004_FFFD_FFFD_0018mv_0010a鈦_001C_FFFD0_001C_000C_0004_0013v_0004_0004_FFFD_003Ct_FFFDCz_003E_0004_FFFD_0040_FFFD_FFFDt0_000C_FFFD_FFFD_0024_000Cz_FFFD_FFFDVj_FFFDw_000Bz_FFFD_0018_FFFD_FFFD_FFFD0_FFFDJy_FFFD_FFFD_FFFD_FFFD_FFFD_0018_FFFD_0006_0025_000Dy_FFFD_FFFD_FFFD_FFFD_FFFD_FFFD_00108I_001Cio_FFFD_FFFD_000E_0004_FFFD_0028_FFFDJ_FFFD_FFFD_FFFD_03470_000C_002D_FFFD0_000C_FFFD_001E_FFFD_000A_0004_FFFD_FFFD_000Bz_FFFD0b_FFFD_000E_FFFD_0009_FFFD_FFFD_FFFD8_0016_FFFD_FFFD_0003_FFFD0__0004_FFFD_002C_000CZy_FFFD_FFFDz_FFFDc_FFFD_D85F_DF61_FFFD0_000CW_FFFD_FFFD_0014_FFFD_FFFD_003C_000BV_FFFD_FFFD_FFFDz_0060_FFFD_FFFDՇ0_000C_FFFD_FFFD_001Bڐn_FFFD_FFFDZ_0014_001D_FFFD_0005_FFFD0_000C_005Dt_003BZY_FFFD_007CX3_FFFD_007CX_0005_000C_FFFD_000FbL_FFFD_FFFDZ_0014_001D_FFFD_0005_FFFD0_000C_005Dt_003E_FFFDn_FFFD_FFFD_007Bl_FFFD_FFFD_003Aj_0001_FFFD_000C_FFFDI4i_FFFD_0019_FFFD_FFFDZ_0014_001D_FFFDɁd_030E_FFFD_002C_FFFD_0008_FFFDv_0008_FFFD_FFFD8_FFFDR_FFFD_FFFD_FFFDA_FFFD0_FFFD_FFFD_FFFD_FFFDJ_FFFD_001C_0010_0004_FFFD_0028_FFFDZ_FFFD_FFFDY_FFFD_FFFDHO_FFFD_FFFD_FFFD_FFFD_FFFD_0028HJ_FFFD_FFFD_00168I_001C_003B_0004_FFFD_002C_000CR_FFFD_FFFD_FFFD_0001_FFFD_FFFD_0022_FFFD_FFFD8_FFFDR_FFFD_FFFD_FFFD_0009ӻa_0011_0014_007E_0004k_FFFD4Vyg_FFFD_FFFD_0001_FFFD_FFFD_0010_FFFD_FFFD_001B_000F8I_FFFDebL_FFFD_FFFDZ_0014_001D_FFFD_FFFD50_FFFD_000D_FFFD_FFFD_FFFDA0_FFFD_0011qs_FFFD_0004_FFFD_FFFDQ_FFFD_000C_FFFD_FFFD_0005_FFFD7_003F_FFFDr_FFFD_000F_0005_FFFDcގ_FFFD_FFFDt_0005_FFFD0_000Co_FFFD_FFFDY_000D_FFFD_FFFDL_FFFD_FFFD䏂_003D1_FFFD_000C_FFFD_FFFD_FFFD_FFFD_FFFD0_000Cm_FFFD8_000C_0005_FFFD_FFFD_FFFD_0004_FFFDܕJE_FFFD_FFFD_FFFD_FFFD_FFFD_0015_FFFD_0006_FFFD_0004_000C_FFFD0_FFFD_000C_FFFD_FFFD_FFFDz_FFFD0_000C_FFFD_FFFD_FFFD_000F_FFFD_06DA_000C_FFFD_FFFD8_000BVɹQ_FFFD_000C_FFFD_FFFD_0005_FFFD7_003F_FFFDr_FFFD_000F_0005_FFFD_FFFDQ_FFFD0_000C_0005_0014_FFFD_FFFD_0040_FFFD_FFFD_0025_0014_007E_FFFD_FFFD_FFFD_001C_001CÝ1_FFFDR9_FFFDQ_FFFD_FFFD_0060F_FFFD0R_FFFD_0014_FFFD_FFFD_0040_FFFD_FFFD刦_FFFD_FFFD_FFFD8_000BV_FFFD_002F_FFFD_0011_FFFD_FFFD_0014_FFFDL_002D_000C_0004_000D_FFFD_0014_0004_FFFD_003C_000Bz_FFFD_0018_FFFD_0001_FFFD0_FFFDɑ_FFFD_FFFDz_FFFDc_FFFD_FFFD3_000C_0005_FFFD_FFFD_0014mI_FFFD_FFFD_FFFD_0018_FFFD_FFFD_0019_000C_0004_0013v_FFFD_0004_FFFD8t_0009_FFFDb_FFFD_0004_FFFD_003C_FFFDQr0_000C_FFFD_FFFD_0028_000Cz_FFFD_FFFD_0060_FFFD8_FFFD_000Bz_FFFD_0018F_FFFD0_FFFDJe0_FFFD_000D_FFFD_FFFD_003F_000B_FFFD_002F_FFFD_0011qW_FFFD_0004_FFFD_FFFDQ_0748_FFFD_0014moH_FFFD_FFFD_FFFD_FFFD_0018_FFFD_0019_000C_0004_0013v_FFFD_0004_FFFD8t_0029_FFFD_FFFD_FFFD_0004_FFFD_003C_FFFD_0005r0_000C_FFFD_FFFD_DBFC_DC811_FFFD_0023_000C_FFFD_FFFD_0005_FFFDH_FFFD_FFFDe1_FFFD_0017_000C_FFFD_FFFD_0005_FFFD_003C_FFFD_FFFDQ1_FFFD_000B_000C_FFFD_FFFD_0005_FFFD7_003F_FFFDr_FFFD_000E_0005_FFFDcގ_FFFD_002C_FFFDņ0_000CU_FFFD_FFFD_0004_FFFD_FFFD_002C_FFFD_FFFD_FFFD1_FFFD_000C_FFFD_FFFD_FFFDB_FFFD0_000C_0004_FFFD8t_FFFDS_0012_FFFD_0004_FFFD_002C_FFFD_FFFDq0_000C_FFFD_FFFD_0024_000Cz_FFFD_FFFD_001C_FFFDv_002F_000Cz_FFFD_0019_FFFD_FFFD0_FFFDJy_FFFD_FFFD_FFFD_FFFD_FFFD_0012_FFFD_0006_0021_000Dz_FFFDc_FFFD_FFFD2_000C_0005_FFFD_0002_FFFDZ_FFFD_0019_FFFD_000B_FFFD0_005C_0004_FFFD_0028_FFFDJ_FFFD_FFFD_FFFD_0001_FFFD_FFFD_00138I_001A_FFFD_0006_FFFD0_000Bz_FFFD_FFFD_FFFDB_FFFD_FFFD_000Bz_FFFD_0019Z_FFFD0_FFFDJA_FFFD_FFFD_FFFD_FFFD_FFFD_00138I_001A_FFFD_0006_FFFD0_000Bz_FFFD_002F_FFFD_000Dqw_0009_0004_FFFD_FFFD_FFFDq_FFFD0_000C_FFFDM_003D_FFFDJu_FFFD_FFFD_FFFD_00138I_001A_FFFD_0006_FFFD0_000Bzu_FFFD_000Co_FFFD_002Fb_FFFD_0012v_FFFD8_005B_FFFDa_FFFD_0016_007E_FFFDV_FFFD0v_0005_FFFD_0040_000BZ_007Dn_0010_0005_FFFD_FFFD_FFFDT_000Av_FFFD_0005_FFFD0_000C_FFFD_0006_0005_000Dy_FFFD_FFFD_000C_FFFD_FFFD0v_0005_FFFD_FFFD_FFFD_0004_FFFD_0008w_0009_FFFD0_001C_0005_FFFD_002F_FFFD_FFFD_FFFD0_000BZe_FFFDQ_FFFD_000C_FFFD_FFFD_0005_FFFD7_003F_FFFDrt_000D_0005_FFFD_FFFDa_FFFD_FFFD_002F_FFFD刦_FFFDo_FFFD_002Fb_FFFD_FFFD4_000C_0005I_FFFD_FFFDo_FFFD_FFFD_000C_0015_FFFD0t_0005_FFFD0_000Co_FFFD_002Fb_FFFD_0012v_0608_0006_FFFD_000Cz_FFFDc_FFFD_FFFD1_000C_0005_0014_FFFD_FFFD_FFFD_FFFD_FFFDY_FFFD_000Cv_FFFD_0009r_FFFD_000C_0005_FFFD_FFFDQ_FFFD_0014AGZu_0040_FFFD_FFFD_FFFD0_000Co_FFFD_FFFD_000Co_FFFD_FFFDY_FFFD_FFFD_002Fb_FFFDٻQ_0658_FFFD_005C_000B_FFFD_002F_FFFD鈆ЊI_0040_FFFD_FFFD_FFFD0_000Co_FFFD_FFFD_0020_0007_FFFD0_000BzU_FFFD_000D_0004_FFFD_FFFD_000BZy_FFFD_FFFDz_FFFDY_FFFD_000C_FFFD_0010_0005_FFFD_FFFD_FFFDJU_0040_FFFD_0015Z_002B_FFFD_0008_000C_0003_000D_FFFD_FFFD_FFFD_FFFDF_FFFD_FFFD_FFFD_0009_FFFD0_000C_FFFD_FFFD_FFFD_000Bw_FFFD_002Fb_FFFD_FFFD_FFFD_FFFD_0004_FFFD_FFFDRU0_007E_0009_FFFD_FFFD_FFFD_FFFD_FFFD_002C_000C_0004_000D_FFFD_0014_FFFDI_FFFD_002F_0004_FFFD_FFFDJ_FFFD_002F_005D_0029_FFFD3v_0005_FFFD0_FFFDZI_FFFDv_0004_0015_007E_FFFD_0014_0040r_0012U_FFFD_FFFD_FFFD_0004_FFFD_FFFD_000BzI_FFFDa_000D_FFFD_FFFD0_FFFD_FFFD_0004_001D_FFFD_FFFD_FFFDJE0_FFFDΘ_FFFD_003F_0004_FFFD0u_0005_00091_000Co_FFFD_002F_FFFDو_FFFD_FFFDm_FFFD_FFFD_000C_0005_FFFD0_000BzU0b_0748_FFFD_FFFD_FFFD8_000BU_FFFD_002F_FFFD_FFFD_0014_FFFD_0014_0004_FFFDt_FFFD_0006_0014_0016j_FFFD_0019_FFFD_FFFDZ_0014_001D_FFFD_FFFDm_FFFDQ_FFFD0_000C_0005_FFFD_FFFDJ_007D_FFFDQ_FFFD_0012v_0008m_FFFD8_000C_0005_FFFD0_FFFDZ_FFFD_002F_E_0012v_0008_FFFD_0006_002D_000D_0014_000D<_0021_00210, _0021_00211, _0021_00212, _0021_00213, _0021_00214, _0021_00215, _0021_00216, _0021_00217, _0021_00218, _0021_00219, _0021_002110, _0021_002111>((byte)/*Error near IL_0011: Stack underflow*/ != 0, (byte)/*Error near IL_0011: Stack underflow*/ != 0, (byte)/*Error near IL_0011: Stack underflow*/ != 0, (byte)/*Error near IL_0011: Stack underflow*/ != 0, (byte)(int)val != 0);
			_003F val2 = /*Error near IL_0011: ldarg 0 (out-of-bounds)*/;
			bool num2 = ((Uri)/*Error near IL_0017: Stack underflow*/).Ud_030E_FFFD_000C_FFFDՈ0_000CU_0014_FFFD_0014_0004_FFFD_FFFDQ_FFFD_000C_FFFD_FFFD_0005_FFFD7_003F_FFFDr_000F_000D_0005_FFFD_002F_FFFD_000D_FFFD_003F_FFFD_0023_FFFD_002F_FFFD_FFFDq_FFFD_FFFD_0004_FFFD_FFFDQ_FFFD_0014m_002B_FFFD_FFFD_FFFD_FFFD_FFFD_FFFD_FFFD_0008_001D_000C_0004_0013v_FFFD_0004_FFFD8t_0014_0013y0_0004_FFFD_000C_FFFDqu0_000C_FFFD_FFFD_0014_000Cz_FFFD_FFFDr_001Ec_FFFD_000Bz_FFFD_0018f_FFFD0_FFFDJi_FFFD_FFFD_FFFD_001E_FFFD_0006_0019_000Dy_FFFD_FFFD_FFFD鉤_0012_FFFD_0006_0011_000Dz_FFFDc_FFFD_FFFD_FFFD_FFFDa_0001ܚ4o_FFFD0b_FFFD_0016_007E_FFFDVqK_000B_0004_FFFD_FFFDv_0005_FFFD_FFFD_FFFDI_FFFD_0019_0004_FFFD_002C_FFFDJ_FFFD_002F_005D_0029_FFFD_FFFD_FFFDPPv_FFFD_0006_FFFD0_000C_FFFD_FFFD_0020_FFFDZY_FFFDY_FFFD_0012_007E_FFFD_FFFD_FFFD_0008_000F_0005_FFFD0_FFFDJ_FFFD_FFFD_FFFDZU_FFFDv_0015_0016_007E_FFFDV_FFFD0_000Bz_FFFD0b鈆_FFFD_FFFD_0028_000Cz_FFFD_FFFDQ_000D_FFFD_FFFD0_FFFD_0006_0029_000Dy_FFFDc_FFFD_FFFD_FFFD_FFFD_000D_FFFDn_FFFD_FFFDZ_0014_001D_FFFD_FFFDQ_002F_000C_0004_FFFD_FFFD_0018mv_0010a鈦_001C_FFFD0_001C_000C_0004_0013v_0004_0004_FFFD_003Ct_FFFDCz_003E_0004_FFFD_0040_FFFD_FFFDt0_000C_FFFD_FFFD_0024_000Cz_FFFD_FFFDVj_FFFDw_000Bz_FFFD_0018_FFFD_FFFD_FFFD0_FFFDJy_FFFD_FFFD_FFFD_FFFD_FFFD_0018_FFFD_0006_0025_000Dy_FFFD_FFFD_FFFD_FFFD_FFFD_FFFD_00108I_001Cio_FFFD_FFFD_000E_0004_FFFD_0028_FFFDJ_FFFD_FFFD_FFFD_03470_000C_002D_FFFD0_000C_FFFD_001E_FFFD_000A_0004_FFFD_FFFD_000Bz_FFFD0b_FFFD_000E_FFFD_0009_FFFD_FFFD_FFFD8_0016_FFFD_FFFD_0003_FFFD0__0004_FFFD_002C_000CZy_FFFD_FFFDz_FFFDc_FFFD_D85F_DF61_FFFD0_000CW_FFFD_FFFD_0014_FFFD_FFFD_003C_000BV_FFFD_FFFD_FFFDz_0060_FFFD_FFFDՇ0_000C_FFFD_FFFD_001Bڐn_FFFD_FFFDZ_0014_001D_FFFD_0005_FFFD0_000C_005Dt_003BZY_FFFD_007CX3_FFFD_007CX_0005_000C_FFFD_000FbL_FFFD_FFFDZ_0014_001D_FFFD_0005_FFFD0_000C_005Dt_003E_FFFDn_FFFD_FFFD_007Bl_FFFD_FFFD_003Aj_0001_FFFD_000C_FFFDI4i_FFFD_0019_FFFD_FFFDZ_0014_001D_FFFDɁd_030E_FFFD_002C_FFFD_0008_FFFDv_0008_FFFD_FFFD8_FFFDR_FFFD_FFFD_FFFDA_FFFD0_FFFD_FFFD_FFFD_FFFDJ_FFFD_001C_0010_0004_FFFD_0028_FFFDZ_FFFD_FFFDY_FFFD_FFFDHO_FFFD_FFFD_FFFD_FFFD_FFFD_0028HJ_FFFD_FFFD_00168I_001C_003B_0004_FFFD_002C_000CR_FFFD_FFFD_FFFD_0001_FFFD_FFFD_0022_FFFD_FFFD8_FFFDR_FFFD_FFFD_FFFD_0009ӻa_0011_0014_007E_0004k_FFFD4Vyg_FFFD_FFFD_0001_FFFD_FFFD_0010_FFFD_FFFD_001B_000F8I_FFFDebL_FFFD_FFFDZ_0014_001D_FFFD_FFFD50_FFFD_000D_FFFD_FFFD_FFFDA0_FFFD_0011qs_FFFD_0004_FFFD_FFFDQ_FFFD_000C_FFFD_FFFD_0005_FFFD7_003F_FFFDr_FFFD_000F_0005_FFFDcގ_FFFD_FFFDt_0005_FFFD0_000Co_FFFD_FFFDY_000D_FFFD_FFFDL_FFFD_FFFD䏂_003D1_FFFD_000C_FFFD_FFFD_FFFD_FFFD_FFFD0_000Cm_FFFD8_000C_0005_FFFD_FFFD_FFFD_0004_FFFDܕJE_FFFD_FFFD_FFFD_FFFD_FFFD_0015_FFFD_0006_FFFD_0004_000C_FFFD0_FFFD_000C_FFFD_FFFD_FFFDz_FFFD0_000C_FFFD_FFFD_FFFD_000F_FFFD_06DA_000C_FFFD_FFFD8_000BVɹQ_FFFD_000C_FFFD_FFFD_0005_FFFD7_003F_FFFDr_FFFD_000F_0005_FFFD_FFFDQ_FFFD0_000C_0005_0014_FFFD_FFFD_0040_FFFD_FFFD_0025_0014_007E_FFFD_FFFD_FFFD_001C_001CÝ1_FFFDR9_FFFDQ_FFFD_FFFD_0060F_FFFD0R_FFFD_0014_FFFD_FFFD_0040_FFFD_FFFD刦_FFFD_FFFD_FFFD8_000BV_FFFD_002F_FFFD_0011_FFFD_FFFD_0014_FFFDL_002D_000C_0004_000D_FFFD_0014_0004_FFFD_003C_000Bz_FFFD_0018_FFFD_0001_FFFD0_FFFDɑ_FFFD_FFFDz_FFFDc_FFFD_FFFD3_000C_0005_FFFD_FFFD_0014mI_FFFD_FFFD_FFFD_0018_FFFD_FFFD_0019_000C_0004_0013v_FFFD_0004_FFFD8t_0009_FFFDb_FFFD_0004_FFFD_003C_FFFDQr0_000C_FFFD_FFFD_0028_000Cz_FFFD_FFFD_0060_FFFD8_FFFD_000Bz_FFFD_0018F_FFFD0_FFFDJe0_FFFD_000D_FFFD_FFFD_003F_000B_FFFD_002F_FFFD_0011qW_FFFD_0004_FFFD_FFFDQ_0748_FFFD_0014moH_FFFD_FFFD_FFFD_FFFD_0018_FFFD_0019_000C_0004_0013v_FFFD_0004_FFFD8t_0029_FFFD_FFFD_FFFD_0004_FFFD_003C_FFFD_0005r0_000C_FFFD_FFFD_DBFC_DC811_FFFD_0023_000C_FFFD_FFFD_0005_FFFDH_FFFD_FFFDe1_FFFD_0017_000C_FFFD_FFFD_0005_FFFD_003C_FFFD_FFFDQ1_FFFD_000B_000C_FFFD_FFFD_0005_FFFD7_003F_FFFDr_FFFD_000E_0005_FFFDcގ_FFFD_002C_FFFDņ0_000CU_FFFD_FFFD_0004_FFFD_FFFD_002C_FFFD_FFFD_FFFD1_FFFD_000C_FFFD_FFFD_FFFDB_FFFD0_000C_0004_FFFD8t_FFFDS_0012_FFFD_0004_FFFD_002C_FFFD_FFFDq0_000C_FFFD_FFFD_0024_000Cz_FFFD_FFFD_001C_FFFDv_002F_000Cz_FFFD_0019_FFFD_FFFD0_FFFDJy_FFFD_FFFD_FFFD_FFFD_FFFD_0012_FFFD_0006_0021_000Dz_FFFDc_FFFD_FFFD2_000C_0005_FFFD_0002_FFFDZ_FFFD_0019_FFFD_000B_FFFD0_005C_0004_FFFD_0028_FFFDJ_FFFD_FFFD_FFFD_0001_FFFD_FFFD_00138I_001A_FFFD_0006_FFFD0_000Bz_FFFD_FFFD_FFFDB_FFFD_FFFD_000Bz_FFFD_0019Z_FFFD0_FFFDJA_FFFD_FFFD_FFFD_FFFD_FFFD_00138I_001A_FFFD_0006_FFFD0_000Bz_FFFD_002F_FFFD_000Dqw_0009_0004_FFFD_FFFD_FFFDq_FFFD0_000C_FFFDM_003D_FFFDJu_FFFD_FFFD_FFFD_00138I_001A_FFFD_0006_FFFD0_000Bzu_FFFD_000Co_FFFD_002Fb_FFFD_0012v_FFFD8_005B_FFFDa_FFFD_0016_007E_FFFDV_FFFD0v_0005_FFFD_0040_000BZ_007Dn_0010_0005_FFFD_FFFD_FFFDT_000Av_FFFD_0005_FFFD0_000C_FFFD_0006_0005_000Dy_FFFD_FFFD_000C_FFFD_FFFD0v_0005_FFFD_FFFD_FFFD_0004_FFFD_0008w_0009_FFFD0_001C_0005_FFFD_002F_FFFD_FFFD_FFFD0_000BZe_FFFDQ_FFFD_000C_FFFD_FFFD_0005_FFFD7_003F_FFFDrt_000D_0005_FFFD_FFFDa_FFFD_FFFD_002F_FFFD刦_FFFDo_FFFD_002Fb_FFFD_FFFD4_000C_0005I_FFFD_FFFDo_FFFD_FFFD_000C_0015_FFFD0t_0005_FFFD0_000Co_FFFD_002Fb_FFFD_0012v_0608_0006_FFFD_000Cz_FFFDc_FFFD_FFFD1_000C_0005_0014_FFFD_FFFD_FFFD_FFFD_FFFDY_FFFD_000Cv_FFFD_0009r_FFFD_000C_0005_FFFD_FFFDQ_FFFD_0014AGZu_0040_FFFD_FFFD_FFFD0_000Co_FFFD_FFFD_000Co_FFFD_FFFDY_FFFD_FFFD_002Fb_FFFDٻQ_0658_FFFD_005C_000B_FFFD_002F_FFFD鈆ЊI_0040_FFFD_FFFD_FFFD0_000Co_FFFD_FFFD_0020_0007_FFFD0_000BzU_FFFD_000D_0004_FFFD_FFFD_000BZy_FFFD_FFFDz_FFFDY_FFFD_000C_FFFD_0010_0005_FFFD_FFFD_FFFDJU_0040_FFFD_0015Z_002B_FFFD_0008_000C_0003_000D_FFFD_FFFD_FFFD_FFFDF_FFFD_FFFD_FFFD_0009_FFFD0_000C_FFFD_FFFD_FFFD_000Bw_FFFD_002Fb_FFFD_FFFD_FFFD_FFFD_0004_FFFD_FFFDRU0_007E_0009_FFFD_FFFD_FFFD_FFFD_FFFD_002C_000C_0004_000D_FFFD_0014_FFFDI_FFFD_002F_0004_FFFD_FFFDJ_FFFD_002F_005D_0029_FFFD3v_0005_FFFD0_FFFDZI_FFFDv_0004_0015_007E_FFFD_0014_0040r_0012U_FFFD_FFFD_FFFD_0004_FFFD_FFFD_000BzI_FFFDa_000D_FFFD_FFFD0_FFFD_FFFD_0004_001D_FFFD_FFFD_FFFDJE0_FFFDΘ_FFFD_003F_0004_FFFD0u_0005_00091_000Co_FFFD_002F_FFFDو_FFFD_FFFDm_FFFD_FFFD_000C_0005_FFFD0_000BzU0b_0748_FFFD_FFFD_FFFD8_000BU_FFFD_002F_FFFD_FFFD_0014_FFFD_0014_0004_FFFDt_FFFD_0006_0014_0016j_FFFD_0019_FFFD_FFFDZ_0014_001D_FFFD_FFFDm_FFFDQ_FFFD0_000C_0005_FFFD_FFFDJ_007D_FFFDQ_FFFD_0012v_0008m_FFFD8_000C_0005_FFFD0_FFFDZ_FFFD_002F_E_0012v_0008_FFFD_0006_002D_000D_0014_000D<_0021_00210, _0021_00211, _0021_00212, _0021_00213, _0021_00214, _0021_00215, _0021_00216, _0021_00217, _0021_00218, _0021_00219, _0021_002110, _0021_002111>((byte)/*Error near IL_0017: Stack underflow*/ != 0, (byte)/*Error near IL_0017: Stack underflow*/ != 0, (byte)/*Error near IL_0017: Stack underflow*/ != 0, num, (byte)(int)val2 != 0);
			_003F val3 = /*Error near IL_0017: ldarg 2 (out-of-bounds)*/;
			_003F val4 = /*Error near IL_0018: ldarg 0 (out-of-bounds)*/;
			((Uri)/*Error near IL_001e: Stack underflow*/)._0_000CU_0014_FFFD_0014_0004_FFFD_FFFDQ_FFFD_000C_FFFD_FFFD_0005_FFFD7_003F_FFFDr_000F_000D_0005_FFFD_002F_FFFD_000D_FFFD_003F_FFFD_0023_FFFD_002F_FFFD_FFFDq_FFFD_FFFD_0004_FFFD_FFFDQ_FFFD_0014m_002B_FFFD_FFFD_FFFD_FFFD_FFFD_FFFD_FFFD_0008_001D_000C_0004_0013v_FFFD_0004_FFFD8t_0014_0013y0_0004_FFFD_000C_FFFDqu0_000C_FFFD_FFFD_0014_000Cz_FFFD_FFFDr_001Ec_FFFD_000Bz_FFFD_0018f_FFFD0_FFFDJi_FFFD_FFFD_FFFD_001E_FFFD_0006_0019_000Dy_FFFD_FFFD_FFFD鉤_0012_FFFD_0006_0011_000Dz_FFFDc_FFFD_FFFD_FFFD_FFFDa_0001ܚ4o_FFFD0b_FFFD_0016_007E_FFFDVqK_000B_0004_FFFD_FFFDv_0005_FFFD_FFFD_FFFDI_FFFD_0019_0004_FFFD_002C_FFFDJ_FFFD_002F_005D_0029_FFFD_FFFD_FFFDPPv_FFFD_0006_FFFD0_000C_FFFD_FFFD_0020_FFFDZY_FFFDY_FFFD_0012_007E_FFFD_FFFD_FFFD_0008_000F_0005_FFFD0_FFFDJ_FFFD_FFFD_FFFDZU_FFFDv_0015_0016_007E_FFFDV_FFFD0_000Bz_FFFD0b鈆_FFFD_FFFD_0028_000Cz_FFFD_FFFDQ_000D_FFFD_FFFD0_FFFD_0006_0029_000Dy_FFFDc_FFFD_FFFD_FFFD_FFFD_000D_FFFDn_FFFD_FFFDZ_0014_001D_FFFD_FFFDQ_002F_000C_0004_FFFD_FFFD_0018mv_0010a鈦_001C_FFFD0_001C_000C_0004_0013v_0004_0004_FFFD_003Ct_FFFDCz_003E_0004_FFFD_0040_FFFD_FFFDt0_000C_FFFD_FFFD_0024_000Cz_FFFD_FFFDVj_FFFDw_000Bz_FFFD_0018_FFFD_FFFD_FFFD0_FFFDJy_FFFD_FFFD_FFFD_FFFD_FFFD_0018_FFFD_0006_0025_000Dy_FFFD_FFFD_FFFD_FFFD_FFFD_FFFD_00108I_001Cio_FFFD_FFFD_000E_0004_FFFD_0028_FFFDJ_FFFD_FFFD_FFFD_03470_000C_002D_FFFD0_000C_FFFD_001E_FFFD_000A_0004_FFFD_FFFD_000Bz_FFFD0b_FFFD_000E_FFFD_0009_FFFD_FFFD_FFFD8_0016_FFFD_FFFD_0003_FFFD0__0004_FFFD_002C_000CZy_FFFD_FFFDz_FFFDc_FFFD_D85F_DF61_FFFD0_000CW_FFFD_FFFD_0014_FFFD_FFFD_003C_000BV_FFFD_FFFD_FFFDz_0060_FFFD_FFFDՇ0_000C_FFFD_FFFD_001Bڐn_FFFD_FFFDZ_0014_001D_FFFD_0005_FFFD0_000C_005Dt_003BZY_FFFD_007CX3_FFFD_007CX_0005_000C_FFFD_000FbL_FFFD_FFFDZ_0014_001D_FFFD_0005_FFFD0_000C_005Dt_003E_FFFDn_FFFD_FFFD_007Bl_FFFD_FFFD_003Aj_0001_FFFD_000C_FFFDI4i_FFFD_0019_FFFD_FFFDZ_0014_001D_FFFDɁd_030E_FFFD_002C_FFFD_0008_FFFDv_0008_FFFD_FFFD8_FFFDR_FFFD_FFFD_FFFDA_FFFD0_FFFD_FFFD_FFFD_FFFDJ_FFFD_001C_0010_0004_FFFD_0028_FFFDZ_FFFD_FFFDY_FFFD_FFFDHO_FFFD_FFFD_FFFD_FFFD_FFFD_0028HJ_FFFD_FFFD_00168I_001C_003B_0004_FFFD_002C_000CR_FFFD_FFFD_FFFD_0001_FFFD_FFFD_0022_FFFD_FFFD8_FFFDR_FFFD_FFFD_FFFD_0009ӻa_0011_0014_007E_0004k_FFFD4Vyg_FFFD_FFFD_0001_FFFD_FFFD_0010_FFFD_FFFD_001B_000F8I_FFFDebL_FFFD_FFFDZ_0014_001D_FFFD_FFFD50_FFFD_000D_FFFD_FFFD_FFFDA0_FFFD_0011qs_FFFD_0004_FFFD_FFFDQ_FFFD_000C_FFFD_FFFD_0005_FFFD7_003F_FFFDr_FFFD_000F_0005_FFFDcގ_FFFD_FFFDt_0005_FFFD0_000Co_FFFD_FFFDY_000D_FFFD_FFFDL_FFFD_FFFD䏂_003D1_FFFD_000C_FFFD_FFFD_FFFD_FFFD_FFFD0_000Cm_FFFD8_000C_0005_FFFD_FFFD_FFFD_0004_FFFDܕJE_FFFD_FFFD_FFFD_FFFD_FFFD_0015_FFFD_0006_FFFD_0004_000C_FFFD0_FFFD_000C_FFFD_FFFD_FFFDz_FFFD0_000C_FFFD_FFFD_FFFD_000F_FFFD_06DA_000C_FFFD_FFFD8_000BVɹQ_FFFD_000C_FFFD_FFFD_0005_FFFD7_003F_FFFDr_FFFD_000F_0005_FFFD_FFFDQ_FFFD0_000C_0005_0014_FFFD_FFFD_0040_FFFD_FFFD_0025_0014_007E_FFFD_FFFD_FFFD_001C_001CÝ1_FFFDR9_FFFDQ_FFFD_FFFD_0060F_FFFD0R_FFFD_0014_FFFD_FFFD_0040_FFFD_FFFD刦_FFFD_FFFD_FFFD8_000BV_FFFD_002F_FFFD_0011_FFFD_FFFD_0014_FFFDL_002D_000C_0004_000D_FFFD_0014_0004_FFFD_003C_000Bz_FFFD_0018_FFFD_0001_FFFD0_FFFDɑ_FFFD_FFFDz_FFFDc_FFFD_FFFD3_000C_0005_FFFD_FFFD_0014mI_FFFD_FFFD_FFFD_0018_FFFD_FFFD_0019_000C_0004_0013v_FFFD_0004_FFFD8t_0009_FFFDb_FFFD_0004_FFFD_003C_FFFDQr0_000C_FFFD_FFFD_0028_000Cz_FFFD_FFFD_0060_FFFD8_FFFD_000Bz_FFFD_0018F_FFFD0_FFFDJe0_FFFD_000D_FFFD_FFFD_003F_000B_FFFD_002F_FFFD_0011qW_FFFD_0004_FFFD_FFFDQ_0748_FFFD_0014moH_FFFD_FFFD_FFFD_FFFD_0018_FFFD_0019_000C_0004_0013v_FFFD_0004_FFFD8t_0029_FFFD_FFFD_FFFD_0004_FFFD_003C_FFFD_0005r0_000C_FFFD_FFFD_DBFC_DC811_FFFD_0023_000C_FFFD_FFFD_0005_FFFDH_FFFD_FFFDe1_FFFD_0017_000C_FFFD_FFFD_0005_FFFD_003C_FFFD_FFFDQ1_FFFD_000B_000C_FFFD_FFFD_0005_FFFD7_003F_FFFDr_FFFD_000E_0005_FFFDcގ_FFFD_002C_FFFDņ0_000CU_FFFD_FFFD_0004_FFFD_FFFD_002C_FFFD_FFFD_FFFD1_FFFD_000C_FFFD_FFFD_FFFDB_FFFD0_000C_0004_FFFD8t_FFFDS_0012_FFFD_0004_FFFD_002C_FFFD_FFFDq0_000C_FFFD_FFFD_0024_000Cz_FFFD_FFFD_001C_FFFDv_002F_000Cz_FFFD_0019_FFFD_FFFD0_FFFDJy_FFFD_FFFD_FFFD_FFFD_FFFD_0012_FFFD_0006_0021_000Dz_FFFDc_FFFD_FFFD2_000C_0005_FFFD_0002_FFFDZ_FFFD_0019_FFFD_000B_FFFD0_005C_0004_FFFD_0028_FFFDJ_FFFD_FFFD_FFFD_0001_FFFD_FFFD_00138I_001A_FFFD_0006_FFFD0_000Bz_FFFD_FFFD_FFFDB_FFFD_FFFD_000Bz_FFFD_0019Z_FFFD0_FFFDJA_FFFD_FFFD_FFFD_FFFD_FFFD_00138I_001A_FFFD_0006_FFFD0_000Bz_FFFD_002F_FFFD_000Dqw_0009_0004_FFFD_FFFD_FFFDq_FFFD0_000C_FFFDM_003D_FFFDJu_FFFD_FFFD_FFFD_00138I_001A_FFFD_0006_FFFD0_000Bzu_FFFD_000Co_FFFD_002Fb_FFFD_0012v_FFFD8_005B_FFFDa_FFFD_0016_007E_FFFDV_FFFD0v_0005_FFFD_0040_000BZ_007Dn_0010_0005_FFFD_FFFD_FFFDT_000Av_FFFD_0005_FFFD0_000C_FFFD_0006_0005_000Dy_FFFD_FFFD_000C_FFFD_FFFD0v_0005_FFFD_FFFD_FFFD_0004_FFFD_0008w_0009_FFFD0_001C_0005_FFFD_002F_FFFD_FFFD_FFFD0_000BZe_FFFDQ_FFFD_000C_FFFD_FFFD_0005_FFFD7_003F_FFFDrt_000D_0005_FFFD_FFFDa_FFFD_FFFD_002F_FFFD刦_FFFDo_FFFD_002Fb_FFFD_FFFD4_000C_0005I_FFFD_FFFDo_FFFD_FFFD_000C_0015_FFFD0t_0005_FFFD0_000Co_FFFD_002Fb_FFFD_0012v_0608_0006_FFFD_000Cz_FFFDc_FFFD_FFFD1_000C_0005_0014_FFFD_FFFD_FFFD_FFFD_FFFDY_FFFD_000Cv_FFFD_0009r_FFFD_000C_0005_FFFD_FFFDQ_FFFD_0014AGZu_0040_FFFD_FFFD_FFFD0_000Co_FFFD_FFFD_000Co_FFFD_FFFDY_FFFD_FFFD_002Fb_FFFDٻQ_0658_FFFD_005C_000B_FFFD_002F_FFFD鈆ЊI_0040_FFFD_FFFD_FFFD0_000Co_FFFD_FFFD_0020_0007_FFFD0_000BzU_FFFD_000D_0004_FFFD_FFFD_000BZy_FFFD_FFFDz_FFFDY_FFFD_000C_FFFD_0010_0005_FFFD_FFFD_FFFDJU_0040_FFFD_0015Z_002B_FFFD_0008_000C_0003_000D_FFFD_FFFD_FFFD_FFFDF_FFFD_FFFD_FFFD_0009_FFFD0_000C_FFFD_FFFD_FFFD_000Bw_FFFD_002Fb_FFFD_FFFD_FFFD_FFFD_0004_FFFD_FFFDRU0_007E_0009_FFFD_FFFD_FFFD_FFFD_FFFD_002C_000C_0004_000D_FFFD_0014_FFFDI_FFFD_002F_0004_FFFD_FFFDJ_FFFD_002F_005D_0029_FFFD3v_0005_FFFD0_FFFDZI_FFFDv_0004_0015_007E_FFFD_0014_0040r_0012U_FFFD_FFFD_FFFD_0004_FFFD_FFFD_000BzI_FFFDa_000D_FFFD_FFFD0_FFFD_FFFD_0004_001D_FFFD_FFFD_FFFDJE0_FFFDΘ_FFFD_003F_0004_FFFD0u_0005_00091_000Co_FFFD_002F_FFFDو_FFFD_FFFDm_FFFD_FFFD_000C_0005_FFFD0_000BzU0b_0748_FFFD_FFFD_FFFD8_000BU_FFFD_002F_FFFD_FFFD_0014_FFFD_0014_0004_FFFDt_FFFD_0006_0014_0016j_FFFD_0019_FFFD_FFFDZ_0014_001D_FFFD_FFFDm_FFFDQ_FFFD0_000C_0005_FFFD_FFFDJ_007D_FFFDQ_FFFD_0012v_0008m_FFFD8_000C_0005_FFFD0_FFFDZ_FFFD_002F_E_0012v_0008_FFFD_0006_002D_000D_0014_000D<_0021_00210, _0021_00211, _0021_00212, _0021_00213, _0021_00214, _0021_00215, _0021_00216, _0021_00217, _0021_00218, _0021_00219, _0021_002110, _0021_002111>((byte)/*Error near IL_001e: Stack underflow*/ != 0, (byte)/*Error near IL_001e: Stack underflow*/ != 0, num2, (byte)(int)val3 != 0, (byte)(int)val4 != 0);
			/*Error near IL_001e: Unexpected SignatureTypeCode: (0x30b).*/;
		}
		_ = null;
		/*Error near IL_0032: stloc 3 (out-of-bounds)*/;
		/*Error near IL_0033: ldloc 1 (out-of-bounds)*/;
		/*Error near IL_0034: ldloc 0 (out-of-bounds)*/;
		_ = 0;
		/*Error near IL_0036: ldloca 0 (out-of-bounds)*/;
		/*Error near IL_0038: Unexpected SignatureTypeCode: (0x30).*/;
	}

	private unsafe static _003F ValidateAddress()
	{
		//Discarded unreachable code: IL_000c, IL_000f, IL_001b, IL_001e, IL_0020, IL_0031, IL_0039, IL_003b, IL_0041, IL_0046, IL_0048, IL_004e, IL_0051, IL_0057, IL_005c, IL_005e, IL_005f, IL_0064, IL_0067, IL_0069
		//Error decoding local variables: Signature type sequence must have at least one element.
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Invalid comparison between Unknown and I4
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Invalid comparison between Unknown and I4
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Expected I4, but got Unknown
		//IL_004f: Invalid comparison between Unknown and I4
		//IL_005e: Incompatible stack heights: 0 vs 1
		_ = ((MessageQueueAndPath*)(nint)/*Error: ldarg 1 (out-of-bounds)*/)->Uri;
		/*Error near IL_0007: Unexpected SignatureTypeCode: (0x30b).*/;
	}

	internal static _003F NamedPipeStart()
	{
		//Discarded unreachable code: IL_0005, IL_000b, IL_0015, IL_001e, IL_0025, IL_003b, IL_0042, IL_0044, IL_0050, IL_005b, IL_005d, IL_0064, IL_007a, IL_0081, IL_0085, IL_008f, IL_0094, IL_0099, IL_00a3, IL_00aa, IL_00ab, IL_00b2, IL_00c8, IL_00cf, IL_00d1
		//Error decoding local variables: Signature type sequence must have at least one element.
		//IL_001c: Invalid comparison between Unknown and I4
		//IL_0036: Expected I4, but got Unknown
		//IL_0036: Expected I4, but got O
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Incompatible stack heights: 0 vs 3
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_0075: Expected I4, but got Unknown
		//IL_0075: Expected I4, but got O
		//IL_007c: Unknown result type (might be due to invalid IL or missing references)
		//IL_007c: Incompatible stack heights: 0 vs 3
		//IL_0085: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c3: Expected I4, but got Unknown
		//IL_00c3: Expected I4, but got O
		//IL_00ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ca: Incompatible stack heights: 0 vs 3
		/*Error: Unexpected SignatureTypeCode: (0x30b).*/;
	}

	internal static _003F Start()
	{
		//IL_0006: Expected O, but got Unknown
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Invalid comparison between Unknown and I4
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		if ((int)((MessageQueue)/*Error: ldarg 0 (out-of-bounds)*/).TransportType == 1)
		{
			/*Error near IL_0009: ldarg 0 (out-of-bounds)*/;
			/*Error near IL_000a: ldarg 1 (out-of-bounds)*/;
			return TcpStart();
		}
		/*Error near IL_0011: ldarg 0 (out-of-bounds)*/;
		/*Error near IL_0012: ldarg 1 (out-of-bounds)*/;
		return NamedPipeStart();
	}

	private static _003F GetEndPoint()
	{
		//Discarded unreachable code: IL_0005, IL_000c, IL_000f, IL_0015, IL_0018, IL_0023, IL_0024, IL_002b, IL_0030
		//Error decoding local variables: Signature type sequence must have at least one element.
		//IL_000d: Invalid comparison between Unknown and I4
		//IL_0016: Invalid comparison between Unknown and I4
		//IL_001e: Expected I4, but got Unknown
		/*Error: Unexpected SignatureTypeCode: (0x30b).*/;
	}

	internal static _003F Stop()
	{
		//Discarded unreachable code: IL_000f, IL_0026, IL_002c, IL_0031, IL_0043, IL_0049, IL_004e
		//Error decoding local variables: Signature type sequence must have at least one element.
		//IL_0006: Expected O, but got Unknown
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Invalid comparison between Unknown and I4
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		if ((int)((MessageQueue)/*Error: ldarg 0 (out-of-bounds)*/).TransportType == 1)
		{
			/*Error near IL_0009: ldarg 1 (out-of-bounds)*/;
			/*Error near IL_000a: Unexpected SignatureTypeCode: (0x30b).*/;
		}
		/*Error near IL_0032: ldarg 1 (out-of-bounds)*/;
		TransportListener.Stop();
		_ = namedPipeMessageQueues;
		/*Error near IL_003d: ldarg 1 (out-of-bounds)*/;
		/*Error near IL_003e: Unexpected SignatureTypeCode: (0x30b).*/;
	}

	private static _003F TcpStart()
	{
		//Discarded unreachable code: IL_0005, IL_000b, IL_0015, IL_001e, IL_0025, IL_003b, IL_0042, IL_0044, IL_004a, IL_005c, IL_0067, IL_0069, IL_0070, IL_0086, IL_008d, IL_0091, IL_009b, IL_00a0, IL_00a5, IL_00af, IL_00b6, IL_00b7, IL_00be, IL_00d4, IL_00db, IL_00dd
		//Error decoding local variables: Signature type sequence must have at least one element.
		//IL_001c: Invalid comparison between Unknown and I4
		//IL_0036: Expected I4, but got Unknown
		//IL_0036: Expected I4, but got O
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Incompatible stack heights: 0 vs 3
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0081: Expected I4, but got Unknown
		//IL_0081: Expected I4, but got O
		//IL_0088: Unknown result type (might be due to invalid IL or missing references)
		//IL_0088: Incompatible stack heights: 0 vs 3
		//IL_0091: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cf: Expected I4, but got Unknown
		//IL_00cf: Expected I4, but got O
		//IL_00d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d6: Incompatible stack heights: 0 vs 3
		/*Error: Unexpected SignatureTypeCode: (0x30b).*/;
	}

	static RoutingTable()
	{
		//Discarded unreachable code: IL_0005, IL_0010
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		/*Error: Unexpected SignatureTypeCode: (0x30).*/;
	}
}