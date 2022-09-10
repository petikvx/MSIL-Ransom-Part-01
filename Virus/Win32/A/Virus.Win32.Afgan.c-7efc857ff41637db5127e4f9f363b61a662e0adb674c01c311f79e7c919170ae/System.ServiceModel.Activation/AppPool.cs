namespace System.ServiceModel.Activation;

internal class AppPool
{
	private _003F appPoolId;

	private _003F apps;

	private _003F enabled;

	private _003F securityIdentifier;

	internal _003F AppPoolId => (byte)(int)appPoolId != 0;

	internal _003F Enabled => enabled;

	internal _003F IsEnabled => enabled;

	internal AppPool()
	{
		//Discarded unreachable code: IL_0006, IL_000c
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		/*Error near IL_0001: Unexpected SignatureTypeCode: (0x30b).*/;
	}

	internal _003F AddApp()
	{
		//Discarded unreachable code: IL_000d, IL_0012, IL_0019, IL_001a
		//Error decoding local variables: Signature type sequence must have at least one element.
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		_ = apps;
		/*Error near IL_0007: stloc 0 (out-of-bounds)*/;
		/*Error near IL_0008: Unexpected SignatureTypeCode: (0x30b).*/;
	}

	internal _003F RemoveApp()
	{
		//Discarded unreachable code: IL_000d, IL_0012, IL_0019, IL_001a
		//Error decoding local variables: Signature type sequence must have at least one element.
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		_ = apps;
		/*Error near IL_0007: stloc 0 (out-of-bounds)*/;
		/*Error near IL_0008: Unexpected SignatureTypeCode: (0x30b).*/;
	}

	internal _003F SnapshotApps()
	{
		//Discarded unreachable code: IL_000d, IL_0018, IL_0020, IL_0021
		//Error decoding local variables: Signature type sequence must have at least one element.
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		_ = apps;
		/*Error near IL_0007: stloc 1 (out-of-bounds)*/;
		/*Error near IL_0008: Unexpected SignatureTypeCode: (0x30b).*/;
	}

	internal _003F OnDeleted()
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		enabled = 0;
		return /*Error near IL_0008: Stack underflow*/;
	}

	internal _003F SetEnabledState()
	{
		//Discarded unreachable code: IL_001b, IL_001f, IL_0026, IL_0034, IL_0036, IL_0043
		//Error decoding local variables: Signature type sequence must have at least one element.
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Incompatible stack heights: 0 vs 1
		if (enabled != /*Error near IL_0006: ldarg 1 (out-of-bounds)*/)
		{
			enabled = /*Error near IL_000a: ldarg 1 (out-of-bounds)*/;
			_ = apps;
			/*Error near IL_0016: Unexpected SignatureTypeCode: (0x195a).*/;
		}
		return /*Error near IL_0045: Stack underflow*/;
	}

	internal _003F SetIdentity()
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		securityIdentifier = /*Error near IL_0001: ldarg 1 (out-of-bounds)*/;
		return /*Error near IL_0008: Stack underflow*/;
	}
}
