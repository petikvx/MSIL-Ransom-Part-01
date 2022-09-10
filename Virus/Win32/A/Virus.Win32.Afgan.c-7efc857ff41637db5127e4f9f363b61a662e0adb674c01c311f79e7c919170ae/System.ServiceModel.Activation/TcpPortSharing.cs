using System.ServiceModel.Activation.Diagnostics;
using System.ServiceProcess;

namespace System.ServiceModel.Activation;

internal class TcpPortSharing : ServiceBase
{
	private class TcpPortSharingCore : SharingService
	{
		internal TcpPortSharingCore()
		{
			//IL_000c: Unknown result type (might be due to invalid IL or missing references)
			_ = 1;
			return ((SharingService)(object)"⡛藾態䪗뱭ﵙ䔑Д⣏\u0fc6ら逌Ⓨ흀⊀䪖둽黎\ua789郜ᓎ媘\uf781ᔐ⾉\ue982縔Ф")._002Ector();
		}
	}

	private _003F serviceCore;

	internal _003F IsPaused => ((SharingService)serviceCore).IsPaused;

	internal TcpPortSharing()
	{
		//Discarded unreachable code: IL_0006, IL_001c, IL_0023, IL_002a, IL_0031, IL_0038, IL_003f
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		/*Error near IL_0001: Unexpected SignatureTypeCode: (0x30b).*/;
	}

	protected override _003F OnContinue()
	{
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Incompatible stack heights: 0 vs 4
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Expected O, but got Unknown
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		if (DiagnosticUtility.get_Item((byte)/*Error near IL_0005: Stack underflow*/ != 0, (byte)/*Error near IL_0005: Stack underflow*/ != 0, (byte)/*Error near IL_0005: Stack underflow*/ != 0, (string)/*Error near IL_0005: Stack underflow*/, (byte)/*Error near IL_0005: Stack underflow*/ != 0) != null)
		{
			_ = 8;
			_ = 589841;
			ListenerTraceUtility.TraceEvent();
		}
		return ((SharingService)serviceCore).OnContinue();
	}

	protected override _003F OnPause()
	{
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Incompatible stack heights: 0 vs 4
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Expected O, but got Unknown
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		if (DiagnosticUtility.get_Item((byte)/*Error near IL_0005: Stack underflow*/ != 0, (byte)/*Error near IL_0005: Stack underflow*/ != 0, (byte)/*Error near IL_0005: Stack underflow*/ != 0, (string)/*Error near IL_0005: Stack underflow*/, (byte)/*Error near IL_0005: Stack underflow*/ != 0) != null)
		{
			_ = 8;
			_ = 589842;
			ListenerTraceUtility.TraceEvent();
		}
		return ((SharingService)serviceCore).OnPause();
	}

	protected override _003F OnShutdown()
	{
		//Discarded unreachable code: IL_001e
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Incompatible stack heights: 0 vs 4
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Expected O, but got Unknown
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		if (DiagnosticUtility.get_Item((byte)/*Error near IL_0005: Stack underflow*/ != 0, (byte)/*Error near IL_0005: Stack underflow*/ != 0, (byte)/*Error near IL_0005: Stack underflow*/ != 0, (string)/*Error near IL_0005: Stack underflow*/, (byte)/*Error near IL_0005: Stack underflow*/ != 0) != null)
		{
			_ = 8;
			_ = 589843;
			ListenerTraceUtility.TraceEvent();
		}
		_ = 30000;
		/*Error near IL_0019: Unexpected SignatureTypeCode: (0x30b).*/;
	}

	protected override _003F OnStart()
	{
		//Discarded unreachable code: IL_0044
		//Error decoding local variables: Signature type sequence must have at least one element.
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Incompatible stack heights: 0 vs 4
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Expected I4, but got Unknown
		//IL_003d: Expected I4, but got Unknown
		//IL_003d: Expected O, but got I4
		//IL_003e: Expected O, but got I4
		try
		{
			if (DiagnosticUtility.get_Item((byte)/*Error near IL_0005: Stack underflow*/ != 0, (byte)/*Error near IL_0005: Stack underflow*/ != 0, (byte)/*Error near IL_0005: Stack underflow*/ != 0, (string)/*Error near IL_0005: Stack underflow*/, (byte)/*Error near IL_0005: Stack underflow*/ != 0) != null)
			{
				_ = 8;
				_ = 589845;
				ListenerTraceUtility.TraceEvent();
			}
			((TcpPortSharing)ListenerConfig.EnsureInitializedForNetTcp()).Start();
		}
		catch (Exception)
		{
			/*Error near IL_001f: stloc 0 (out-of-bounds)*/;
			_003F eventLog = ListenerTraceUtility.EventLog;
			_ = new _FFFD_FFFDid_030E_FFFD_001Cu_0005_FFFD0_000Co_FFFD_FFFDa_0011_FFFD_FFFDL_FFFD_FFFD_001C_FFFD_FFFDu1_001B_FFFD_FFFD3_000C_0005_FFFD_FFFD_0018_FFFD_FFFD8_005D_FFFDl_002F_000C_0004_000D_FFFD_0014_FFFD_FFFD_002C_FFFD_FFFD_FFFD1_FFFD_0011Pv[1];
			/*Error near IL_0034: stloc 1 (out-of-bounds)*/;
			((object[])eventLog)[2] = ((object)13)._0005_FFFD_FFFDC_0003_FFFD0_000Czi_FFFDa_0011_FFFD_FFFD0_FFFD_FFFDQ_FFFD_FFFD0_000C_0005_FFFD_FFFD_FFFD_FFFD_FFFD_003C_000BVͻQ_FFFDt8_FFFD_000AA2_000C_0005_FFFD_FFFD_FFFDbL_FFFD_FFFDZ_0014_001D_FFFD_FFFD_007D_0019_FFFD_0006_FFFD0_FFFD_007D_FFFD0_001B_FFFD_FFFD1_000C_0005q_FFFD_000D_0005_FFFD_FFFDL_0009_FFFD0_000C_0005A_0029_FFFDE_FFFD_FFFD_FFFDY_FFFDp_000CU_FFFD0_FFFDy_FFFD0_000C_0004_FFFDH_FFFDJ_FFFD_FFFD_FFFD_0001_FFFD_003F_FFFD_FFFD_FFFD0_000C_FFFD_FFFD1_000C_0005_FFFD_FFFD0_0004_FFFD_002C_FFFD_FFFD_FFFD0_000C_FFFDM9v_0005_FFFD_000C_0005_FFFD_FFFD_000Fo_FFFD_FFFD_000Dm_FFFD0_000C_FFFD_FFFD_FFFD_0008_FFFD_FFFD1_000C_0005_FFFD_FFFD_0018_FFFD_FFFD_0028_FFFD_FFFD_FFFD0_001C_FFFDB1_000C_0005_FFFD0_FFFDZ_007D_FFFD_FFFD_FFFD_FFFDp_000C_FFFDr_FFFD_0025E_FFFD_FFFD_000Bz_FFFD0_FFFD_FFFDq_003B_000D_0005_FFFD_002F_005D_0015_000E_FFFD_0015A_0029_FFFDE_FFFD_FFFD_FFFDY_FFFDp_000C_0040_FFFD_0024_FFFD_0017_FFFD_FFFD_0004_FFFDt1_000C_0005_FFFD_FFFD_00208_005B_FFFDa_FFFDt_FFFD_000Bz_FFFD_0019_FFFD_0005_FFFD0_000BU_FFFD_FFFDY_FFFDښL_FFFD_FFFD_FFFDL_0005_000A_0019a_001E_FFFD0_005C_0004_FFFD_002C_FFFD_FFFD_FFFD0_000C_0004_FFFDL_FFFD_FFFD_FFFDw_FFFDZ_007D_FFFDv_0005q_FFFD_000C_0005_FFFD_FFFDť_FFFDp_000C_0008_FFFD_002C_FFFD_FFFD_FFFDIL_0005ښ_000Co_FFFD_0018_FFFD_0005_FFFD0_000BU_FFFD_FFFDQ_FFFD_000C_FFFD_0004_0005_FFFDG_000Bz_FFFD_0019_FFFD_0005_FFFD0_000BU_FFFD_0018_FFFD_0005_FFFD0_FFFDE_FFFDb_000C_0005_FFFD_002F_FFFD_000Dq_FFFD_000C_0005_FFFD_002F_001D_FFFDn_FFFD_FFFD_0009_FFFD_FFFD_FFFDZ_0014_001D_005E_0004_FFFD8t_0005_FFFD0_000C_0004_FFFD_003C_003F_FFFD_0012v_0008_FFFD_FFFD_002FR_0001_0015_FFFD_0008_FFFD_FFFD8_FFFDA_FFFD0_FFFD_FFFD_0014v_0008_FFFD_FFFD8_FFFD_0009_FFFDT_000BJ_FFFD_FFFDY_0001_0015v_0014ˍ8_003A_0004_FFFD_002C_FFFDZ_FFFD_FFFDY_000DO5_001D_0029_FFFDv_0008_FFFD_FFFD_002C_FFFDZ_FFFD_FFFD_0010_0007_FFFD_FFFDi_FFFD_0019_FFFD_FFFDZ_0014_001D_FFFD_0005_FFFD0_000C_005Dt_FFFD_000C_0005_FFFD0_000C_0005_FFFD0_000C_0005_FFFD0_000C_0005_FFFD0_000C_0005_FFFD0_000C_0005_FFFD0_000C_0005_FFFD0_000C_0005_FFFD0_000C_0005_FFFD0_000C_0005_FFFD0_000C_0005_FFFD0_000C_0005_FFFD0_000C_0005_FFFD0_000C_0005_FFFD0_000C_0005_FFFD0_000C_0005_FFFD0_000C_0005_FFFD0_000C_0005_FFFD0_000C_0005_FFFD0_000C_0005_FFFD0_000C_0005_FFFD0_FFFDŌ_FFFD_FFFDZ_0014_001Dj_FFFD_0019_FFFD_FFFDZ_0014_001D_FFFD_FFFDm_FFFD_0004_007B_FFFD0_FFFD_FFFD_FFFDIL_0005_065A_000C_FFFD_FFFD8_000BWɹQ_FFFD_000C_FFFD_FFFD_0005_FFFD_FFFD_FFFD_0007_FFFD0_FFFDR_FFFD_FFFDvEA_0029_FFFDE_FFFD_FFFD_FFFDY_FFFDp_000CU_FFFD_FFFD_FFFD_FFFD8_000B_FFFD_00191_000C_0005_000E_FFFD_0013_FFFD_FFFD_FFFD_FFFD8_000BV_FFFD_0019_FFFD_0007_FFFD0v_0005A_0029_FFFDE_FFFD_FFFD_FFFDY_FFFDp_000CU_FFFD_FFFD_FFFD_FFFDH_001B_000C_0004_000B_0019m_001E_FFFD0_FFFD_FFFD_FFFDIL_0005_FFFD_0018_FFFD_FFFD0_FFFDə_0018_FFFD_FFFD0_FFFDJ_FFFD_FFFDa_0001_0015_007BH_0008_FFFD_002C_FFFDR_FFFD_FFFDQ_FFFD_000C_FFFD_0060_FFFD_FFFD3a_0001_0013_FFFD_FFFD8R_FFFDY_FFFDt_0040_FFFDJ_007D_FFFDa_FFFD_0009m_000E_0005_FFFDE_000BJ_007D_FFFD83_FFFD0_FFFD_FFFD_005CL_0005_FFFD_007D<_0021_00210, _0021_00211, _0021_00212, _0021_00213, _0021_00214, _0021_00215, _0021_00216, _0021_00217, _0021_00218, _0021_00219, _0021_002110, _0021_002111>(true, false, (byte)(int)/*Error near IL_0035: ldloc 1 (out-of-bounds)*/ != 0, false, (byte)(int)/*Error near IL_0037: ldloc 0 (out-of-bounds)*/ != 0);
			/*Error near IL_003e: ldloc 1 (out-of-bounds)*/;
			/*Error near IL_003f: Member reference must be method, but was: Field*/;
		}
		return /*Error near IL_0047: Stack underflow*/;
	}

	private _003F Start()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected O, but got Unknown
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		return ((SharingService)serviceCore).Start();
	}

	protected override _003F OnStop()
	{
		//Discarded unreachable code: IL_001e
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Incompatible stack heights: 0 vs 4
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Expected O, but got Unknown
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		if (DiagnosticUtility.get_Item((byte)/*Error near IL_0005: Stack underflow*/ != 0, (byte)/*Error near IL_0005: Stack underflow*/ != 0, (byte)/*Error near IL_0005: Stack underflow*/ != 0, (string)/*Error near IL_0005: Stack underflow*/, (byte)/*Error near IL_0005: Stack underflow*/ != 0) != null)
		{
			_ = 8;
			_ = 589847;
			ListenerTraceUtility.TraceEvent();
		}
		_ = 30000;
		/*Error near IL_0019: Unexpected SignatureTypeCode: (0x30b).*/;
	}
}
