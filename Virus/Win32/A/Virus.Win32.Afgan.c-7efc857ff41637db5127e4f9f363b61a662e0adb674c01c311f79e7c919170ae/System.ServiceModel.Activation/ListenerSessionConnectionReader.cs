namespace System.ServiceModel.Activation;

internal class ListenerSessionConnectionReader : DupHandleConnectionReader
{
	private _003F decoder;

	public ListenerSessionConnectionReader()
	{
		//Discarded unreachable code: IL_0023
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		/*Error near IL_0001: ldarg 1 (out-of-bounds)*/;
		/*Error near IL_0002: ldarg 2 (out-of-bounds)*/;
		/*Error near IL_0003: ldarg 3 (out-of-bounds)*/;
		base._002Ector();
		_ = 2048;
		_ = 256;
		/*Error near IL_001e: Unexpected SignatureTypeCode: (0x30b).*/;
	}

	protected override _003F CanDupHandle()
	{
		//Discarded unreachable code: IL_000b, IL_000e, IL_001a, IL_001d
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Invalid comparison between Unknown and I4
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		_ = decoder;
		/*Error near IL_0006: Unexpected SignatureTypeCode: (0x30b).*/;
	}

	protected override _003F Decode()
	{
		//Discarded unreachable code: IL_000e
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		_ = decoder;
		/*Error near IL_0006: ldarg 1 (out-of-bounds)*/;
		/*Error near IL_0007: ldarg 2 (out-of-bounds)*/;
		/*Error near IL_0008: ldarg 3 (out-of-bounds)*/;
		/*Error near IL_0009: Unexpected SignatureTypeCode: (0x30b).*/;
	}

	protected override _003F CreatePrematureEOFException()
	{
		//Discarded unreachable code: IL_000b
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		_ = decoder;
		/*Error near IL_0006: Unexpected SignatureTypeCode: (0x30b).*/;
	}
}
