namespace System.ServiceModel.Activation;

internal static class ListenerConfig
{
	private static _003F syncRoot;

	private static _003F tcpData;

	private static _003F pipeData;

	private static _003F diagnosticsSectionInited;

	private static _003F perfCountersEnabled;

	private static _003F SyncRoot => syncRoot;

	public static bool NetTcp
	{
		get
		{
			//IL_0000: Unknown result type (might be due to invalid IL or missing references)
			//IL_0005: Unknown result type (might be due to invalid IL or missing references)
			EnsureInitializedForNetTcp();
			return tcpData;
		}
	}

	public static _003F NetPipe
	{
		get
		{
			//IL_0000: Unknown result type (might be due to invalid IL or missing references)
			//IL_0005: Unknown result type (might be due to invalid IL or missing references)
			EnsureInitializedForNetPipe();
			return pipeData;
		}
	}

	public static _003F PerformanceCountersEnabled
	{
		get
		{
			//IL_0000: Unknown result type (might be due to invalid IL or missing references)
			//IL_0005: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Expected O, but got Unknown
			EnsureInitializedForDiagnostics();
			return (bool[,,,,,,,,,,,,,,,,,,,])perfCountersEnabled;
		}
	}

	private static _003F EnsureInitializedForDiagnostics()
	{
		//Discarded unreachable code: IL_0013, IL_001f, IL_0026, IL_0038
		//Error decoding local variables: Signature type sequence must have at least one element.
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		if ((int)diagnosticsSectionInited == 0)
		{
			_ = SyncRoot;
			/*Error near IL_000d: stloc 1 (out-of-bounds)*/;
			/*Error near IL_000e: Unexpected SignatureTypeCode: (0x30b).*/;
		}
		return /*Error near IL_003a: Stack underflow*/;
	}

	public static _003F EnsureInitializedForNetTcp()
	{
		//Discarded unreachable code: IL_0018, IL_0030
		//Error decoding local variables: Signature type sequence must have at least one element.
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Incompatible stack heights: 1 vs 0
		//IL_0036: Expected I4, but got Unknown
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_0051: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Expected O, but got Unknown
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		//IL_006d: Expected O, but got Unknown
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Expected O, but got Unknown
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0087: Unknown result type (might be due to invalid IL or missing references)
		//IL_0091: Expected O, but got Unknown
		//IL_008c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0096: Expected O, but got Unknown
		//IL_0099: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a3: Expected O, but got Unknown
		//IL_009e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00aa: Unknown result type (might be due to invalid IL or missing references)
		_003F val = EnsureInitializedForDiagnostics();
		if ((int)tcpData == 0)
		{
			_ = SyncRoot;
			/*Error near IL_0012: stloc 0 (out-of-bounds)*/;
			/*Error near IL_0013: Unexpected SignatureTypeCode: (0x30b).*/;
		}
		if (DiagnosticUtility.get_Item((byte)/*Error near IL_0036: Stack underflow*/ != 0, (byte)/*Error near IL_0036: Stack underflow*/ != 0, (byte)/*Error near IL_0036: Stack underflow*/ != 0, (string)/*Error near IL_0036: Stack underflow*/, (byte)(int)val != 0) != null)
		{
			_ = DiagnosticUtility.unknown_0;
			_ = 8;
			_ = 655366;
			_ = new object[5];
			/*Error near IL_004e: stloc 1 (out-of-bounds)*/;
			((object[])/*Error near IL_004f: ldloc 1 (out-of-bounds)*/)[0] = (object)(_0028_0006_0009_FFFD_FFFDa_FFFD_0014_007E_FFFD_FFFD_FFFDA_000BJ_007D_FFFD_0016_0005_FFFD0_FFFDJ_FFFD_FFFD_0003_FFFD_0012_FFFD_0008_FFFD_FFFD_002C_00115_0014_FFFD)((NetTcpSectionData)tcpData).ListenBacklog;
			((object[])/*Error near IL_0061: ldloc 1 (out-of-bounds)*/)[1] = (object)(_0028_0006_0009_FFFD_FFFDa_FFFD_0014_007E_FFFD_FFFD_FFFDA_000BJ_007D_FFFD_0016_0005_FFFD0_FFFDJ_FFFD_FFFD_0003_FFFD_0012_FFFD_0008_FFFD_FFFD_002C_00115_0014_FFFD)((NetTcpSectionData)tcpData).MaxPendingConnections;
			((object[])/*Error near IL_0073: ldloc 1 (out-of-bounds)*/)[2] = (object)(_0028_0006_0009_FFFD_FFFDa_FFFD_0014_007E_FFFD_FFFD_FFFDA_000BJ_007D_FFFD_0016_0005_FFFD0_FFFDJ_FFFD_FFFD_0003_FFFD_0012_FFFD_0008_FFFD_FFFD_002C_00115_0014_FFFD)((NetTcpSectionData)tcpData).MaxPendingAccepts;
			((object[])/*Error near IL_0085: ldloc 1 (out-of-bounds)*/)[3] = (TimeSpan)((NetTcpSectionData)tcpData).ReceiveTimeout;
			((object[])/*Error near IL_0097: ldloc 1 (out-of-bounds)*/)[4] = (object)(_FFFD_0014_007E_FFFD_FFFD_FFFDA_000BJ_007D_FFFD_0016_0005_FFFD0_FFFDJ_FFFD_FFFD_0003_FFFD_0012_FFFD_0008_FFFD_FFFD_002C_00115_0014_FFFD)((NetTcpSectionData)tcpData).TeredoEnabled;
			/*Error near IL_00a9: ldloc 1 (out-of-bounds)*/;
			SR.GetString();
			/*Error near IL_00af: Unexpected SignatureTypeCode: (0x30b).*/;
		}
		return /*Error near IL_00b5: Stack underflow*/;
	}

	public static _003F EnsureInitializedForNetPipe()
	{
		//Discarded unreachable code: IL_0018, IL_0030
		//Error decoding local variables: Signature type sequence must have at least one element.
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Incompatible stack heights: 1 vs 0
		//IL_0036: Expected I4, but got Unknown
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_0051: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Expected O, but got Unknown
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		//IL_006d: Expected O, but got Unknown
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Expected O, but got Unknown
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0084: Expected O, but got Unknown
		//IL_0086: Unknown result type (might be due to invalid IL or missing references)
		_003F val = EnsureInitializedForDiagnostics();
		if ((int)pipeData == 0)
		{
			_ = SyncRoot;
			/*Error near IL_0012: stloc 0 (out-of-bounds)*/;
			/*Error near IL_0013: Unexpected SignatureTypeCode: (0x30b).*/;
		}
		if (DiagnosticUtility.get_Item((byte)/*Error near IL_0036: Stack underflow*/ != 0, (byte)/*Error near IL_0036: Stack underflow*/ != 0, (byte)/*Error near IL_0036: Stack underflow*/ != 0, (string)/*Error near IL_0036: Stack underflow*/, (byte)(int)val != 0) != null)
		{
			_ = DiagnosticUtility.unknown_0;
			_ = 8;
			_ = 655367;
			_ = new object[3];
			/*Error near IL_004e: stloc 1 (out-of-bounds)*/;
			((object[])/*Error near IL_004f: ldloc 1 (out-of-bounds)*/)[0] = (object)(_0028_0006_0009_FFFD_FFFDa_FFFD_0014_007E_FFFD_FFFD_FFFDA_000BJ_007D_FFFD_0016_0005_FFFD0_FFFDJ_FFFD_FFFD_0003_FFFD_0012_FFFD_0008_FFFD_FFFD_002C_00115_0014_FFFD)((NetPipeSectionData)pipeData).MaxPendingConnections;
			((object[])/*Error near IL_0061: ldloc 1 (out-of-bounds)*/)[1] = (object)(_0028_0006_0009_FFFD_FFFDa_FFFD_0014_007E_FFFD_FFFD_FFFDA_000BJ_007D_FFFD_0016_0005_FFFD0_FFFDJ_FFFD_FFFD_0003_FFFD_0012_FFFD_0008_FFFD_FFFD_002C_00115_0014_FFFD)((NetPipeSectionData)pipeData).MaxPendingAccepts;
			((object[])/*Error near IL_0073: ldloc 1 (out-of-bounds)*/)[2] = (TimeSpan)((NetPipeSectionData)pipeData).ReceiveTimeout;
			/*Error near IL_0085: ldloc 1 (out-of-bounds)*/;
			SR.GetString();
			/*Error near IL_008b: Unexpected SignatureTypeCode: (0x30b).*/;
		}
		return /*Error near IL_0091: Stack underflow*/;
	}

	public static _003F GetAllowAccounts()
	{
		//Discarded unreachable code: IL_0013, IL_0015, IL_0039, IL_003e, IL_003f, IL_005d, IL_005f, IL_0083, IL_0088, IL_0089
		//Error decoding local variables: Signature type sequence must have at least one element.
		//IL_0002: Invalid comparison between Unknown and I4
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected O, but got Unknown
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Expected O, but got Unknown
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Invalid comparison between Unknown and I4
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Expected O, but got Unknown
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0079: Unknown result type (might be due to invalid IL or missing references)
		//IL_0089: Unknown result type (might be due to invalid IL or missing references)
		//IL_0093: Expected O, but got Unknown
		//IL_008e: Unknown result type (might be due to invalid IL or missing references)
		if ((int)/*Error: ldarg 0 (out-of-bounds)*/ == 1)
		{
			_ = ((NetTcpSectionData)NetTcp).AllowAccounts;
			/*Error near IL_000e: Unexpected SignatureTypeCode: (0x30b).*/;
		}
		if ((int)/*Error near IL_004a: ldarg 0 (out-of-bounds)*/ == 2)
		{
			_ = ((NetPipeSectionData)NetPipe).AllowAccounts;
			/*Error near IL_0058: Unexpected SignatureTypeCode: (0x30b).*/;
		}
		return null;
	}

	static ListenerConfig()
	{
		//Discarded unreachable code: IL_0005
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		/*Error: Unexpected SignatureTypeCode: (0x30b).*/;
	}
}
