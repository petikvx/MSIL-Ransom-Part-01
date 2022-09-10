namespace System.ServiceModel.Activation;

internal class AppManager
{
	private _003F apps;

	private _003F pools;

	public _003F AppsCount
	{
		get
		{
			//Discarded unreachable code: IL_000b
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			_ = apps;
			/*Error near IL_0006: Unexpected SignatureTypeCode: (0x30b).*/;
		}
	}

	public _003F Apps => apps;

	public _003F AppPools => pools;

	public AppManager()
	{
		//Discarded unreachable code: IL_0006, IL_000c, IL_0017
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		/*Error near IL_0001: Unexpected SignatureTypeCode: (0x30b).*/;
	}

	public _003F CreateAppPool()
	{
		//Discarded unreachable code: IL_0016
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		/*Error: ldarg 1 (out-of-bounds)*/;
		_ = 0;
		/*Error near IL_0002: ldarg 2 (out-of-bounds)*/;
		new AppPool();
		/*Error near IL_0008: stloc 0 (out-of-bounds)*/;
		_ = pools;
		/*Error near IL_000f: ldarg 1 (out-of-bounds)*/;
		/*Error near IL_0010: ldloc 0 (out-of-bounds)*/;
		/*Error near IL_0011: Unexpected SignatureTypeCode: (0x195a).*/;
	}

	public _003F CreateApp()
	{
		//Discarded unreachable code: IL_000d, IL_0027
		//Error decoding local variables: Signature type sequence must have at least one element.
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Expected O, but got Unknown
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		_ = AppPools;
		/*Error near IL_0008: Unexpected SignatureTypeCode: (0x195a).*/;
	}

	public _003F DeleteAppPool()
	{
		//Discarded unreachable code: IL_000e, IL_0010, IL_0013, IL_001e, IL_0022, IL_0028, IL_0037, IL_0039, IL_0045, IL_0050, IL_0056
		//Error decoding local variables: Signature type sequence must have at least one element.
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Expected O, but got I4
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Incompatible stack heights: 0 vs 3
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_0056: Expected O, but got Unknown
		//IL_0051: Unknown result type (might be due to invalid IL or missing references)
		//IL_0051: Incompatible stack heights: 0 vs 1
		_ = pools;
		/*Error near IL_0006: ldarg 1 (out-of-bounds)*/;
		/*Error near IL_0007: ldloca 0 (out-of-bounds)*/;
		/*Error near IL_0009: Unexpected SignatureTypeCode: (0x195a).*/;
	}

	public _003F DeleteApp()
	{
		//Discarded unreachable code: IL_001d
		//IL_0006: Expected O, but got Unknown
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Expected O, but got Unknown
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Expected I4, but got Unknown
		//IL_0018: Expected I4, but got Unknown
		//IL_0018: Expected I4, but got Unknown
		//IL_0018: Expected I4, but got Unknown
		//IL_0025: Expected O, but got Unknown
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		_003F appPool = ((App)/*Error: ldarg 1 (out-of-bounds)*/).AppPool;
		_003F val = ((AppPool)/*Error near IL_0006: ldarg 1 (out-of-bounds)*/).RemoveApp();
		_003F val2 = apps;
		_003F val3 = /*Error near IL_0012: ldarg 1 (out-of-bounds)*/;
		((App)/*Error near IL_0018: Stack underflow*/).get_AppKey((byte)/*Error near IL_0018: Stack underflow*/ != 0, (byte)(int)appPool != 0, (byte)(int)val != 0, (byte)(int)val2 != 0, (byte)(int)val3 != 0);
		/*Error near IL_0018: Unexpected SignatureTypeCode: (0x30b).*/;
	}

	public _003F Clear()
	{
		//Discarded unreachable code: IL_0010, IL_0014, IL_001b, IL_002a, IL_002c, IL_0034, IL_0039, IL_003a, IL_0045, IL_0050
		//Error decoding local variables: Signature type sequence must have at least one element.
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected I4, but got Unknown
		//IL_0023: Expected O, but got I4
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Incompatible stack heights: 0 vs 2
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		_003F val = apps;
		byte._002F_E_0012v_0004_FFFD_0006_0029_000D_0014_000D_FFFD_000D_0005_FFFD_FFFD_000C_000D_FFFD0v_0005_0014_007E_0014_0004_FFFDp_FFFDJ_007D_FFFD_FFFD_FFFD_FFFD_003F_FFFD8_FFFD0_000Cm_FFFD8_000C_0005_FFFD_FFFD_0008o_FFFD_FFFDQ_000D_FFFD_FFFD_FFFD_0005_FFFD0_FFFDJy_FFFD_FFFD_FFFD_FFFD_003F_FFFD_000F_FFFD0_000C_FFFD_0006_0021_000B_000C_FFFD0_001B_FFFD_FFFD1_000C_0005_0014_FFFD_FFFD_FFFD_FFFD_002C_FFFD_0009_FFFD0_000Bz_007D_FFFD_000A_000C_FFFD0_FFFDJ_FFFD_002F_005Dq_0012v_FFFD_FFFD_0006_0021_000E_0014_0015_0009_000D_0005_FFFD_FFFD_FFFD_FFFD_FFFD8_000C_0005_FFFD_FFFD_FFFD_0005_FFFD0_FFFDZ_007D_FFFDY_FFFDO5_0016_0005_FFFD5v_0005_FFFD_FFFD_0014_0004_FFFD_0024_FFFD_FFFD_FFFD0_000C_FFFD_FFFD_002C_001C_FFFD_FFFD1_FFFD_FFFD_FFFD_003F_FFFD_FFFD_FFFD0_000C_FFFD_FFFD_0024_001C_FFFD_FFFD1_FFFD_FFFD_FFFD_003F_FFFD_FFFD_FFFD0_000C_FFFD_FFFD_002C_001CÓ_FFFD_FFFD_FFFD0_000C_FFFD_FFFD_0024_001CÙ_FFFD_FFFD_FFFD0_000C_0040S_FFFD_0010_FFFD_FFFD_001B_007F_0004_FFFD_0028w_0005_FFFD_003B_FFFDm0_000CU_FFFD_FFFD<_0021_00210, _0021_00211, _0021_00212, _0021_00213, _0021_00214, _0021_00215, _0021_00216, _0021_00217, _0021_00218, _0021_00219, _0021_002110, _0021_002111, _0021_002112, _0021_002113, _0021_002114, _0021_002115, _0021_002116, _0021_002117, _0021_002118, _0021_002119, _0021_002120, _0021_002121, _0021_002122, _0021_002123, _0021_002124, _0021_002125, _0021_002126, _0021_002127, _0021_002128, _0021_002129, _0021_002130, _0021_002131, _0021_002132, _0021_002133, _0021_002134, _0021_002135, _0021_002136, _0021_002137, _0021_002138, _0021_002139, _0021_002140, _0021_002141, _0021_002142, _0021_002143, _0021_002144, _0021_002145, _0021_002146, _0021_002147, _0021_002148, _0021_002149, _0021_002150, _0021_002151, _0021_002152, _0021_002153, _0021_002154, _0021_002155, _0021_002156, _0021_002157, _0021_002158, _0021_002159, _0021_002160, _0021_002161, _0021_002162, _0021_002163, _0021_002164, _0021_002165, _0021_002166, _0021_002167, _0021_002168, _0021_002169, _0021_002170, _0021_002171, _0021_002172, _0021_002173, _0021_002174, _0021_002175, _0021_002176, _0021_002177, _0021_002178, _0021_002179, _0021_002180, _0021_002181, _0021_002182, _0021_002183, _0021_002184, _0021_002185, _0021_002186, _0021_002187, _0021_002188, _0021_002189, _0021_002190, _0021_002191, _0021_002192, _0021_002193, _0021_002194, _0021_002195, _0021_002196, _0021_002197, _0021_002198, _0021_002199, _0021_0021100, _0021_0021101, _0021_0021102, _0021_0021103, _0021_0021104, _0021_0021105, _0021_0021106, _0021_0021107, _0021_0021108, _0021_0021109, _0021_0021110, _0021_0021111, _0021_0021112, _0021_0021113, _0021_0021114, _0021_0021115, _0021_0021116, _0021_0021117>((byte)/*Error near IL_000b: Stack underflow*/ != 0, (byte)/*Error near IL_000b: Stack underflow*/ != 0, (float)/*Error near IL_000b: Stack underflow*/, (byte)/*Error near IL_000b: Stack underflow*/ != 0, (short)/*Error near IL_000b: Stack underflow*/, (byte)/*Error near IL_000b: Stack underflow*/ != 0, (double)/*Error near IL_000b: Stack underflow*/, (byte)(int)val != 0);
		/*Error near IL_000b: Unexpected SignatureTypeCode: (0x3151).*/;
	}
}
