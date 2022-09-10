namespace System.ServiceModel.Activation;

internal class App
{
	private _003F appKey;

	private _003F appPool;

	private _003F siteId;

	private _003F messageQueue;

	private _003F path;

	private _003F requestBlocked;

	private _003F hasInvalidBinding;

	private _003F pendingAction;

	internal _003F PendingAction => pendingAction;

	internal _003F AppKey => (byte)(int)appKey != 0;

	internal _003F AppPool => appPool;

	internal _003F SiteId => siteId;

	internal _003F MessageQueue => messageQueue;

	internal _003F Path
	{
		get
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			//IL_0007: Expected I4, but got Unknown
			return (byte)(int)path != 0;
		}
		set
		{
			//IL_0002: Unknown result type (might be due to invalid IL or missing references)
			path = /*Error near IL_0001: ldarg 1 (out-of-bounds)*/;
			return /*Error near IL_0008: Stack underflow*/;
		}
	}

	internal _003F IsEnabled
	{
		get
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Expected O, but got Unknown
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0016: Unknown result type (might be due to invalid IL or missing references)
			//IL_001c: Invalid comparison between Unknown and I4
			if ((int)((AppPool)appPool).IsEnabled != 0 && (int)requestBlocked == 0)
			{
				return (int)hasInvalidBinding == 0;
			}
			return 0;
		}
	}

	internal App()
	{
		//Discarded unreachable code: IL_0006
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		/*Error near IL_0001: Unexpected SignatureTypeCode: (0x30b).*/;
	}

	internal _003F SetPendingAction()
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		pendingAction = /*Error near IL_0001: ldarg 1 (out-of-bounds)*/;
		return /*Error near IL_0008: Stack underflow*/;
	}

	internal _003F RegisterQueue()
	{
		//Discarded unreachable code: IL_0013
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		if ((int)messageQueue != 0)
		{
			_ = DiagnosticUtility.unknown_1;
			_ = 0;
			/*Error near IL_000e: Unexpected SignatureTypeCode: (0x30b).*/;
		}
		messageQueue = /*Error near IL_0015: ldarg 1 (out-of-bounds)*/;
		return /*Error near IL_001c: Stack underflow*/;
	}

	internal _003F OnAppPoolChanged()
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		appPool = /*Error near IL_0001: ldarg 1 (out-of-bounds)*/;
		return /*Error near IL_0008: Stack underflow*/;
	}

	internal _003F SetRequestBlocked()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Incompatible stack heights: 0 vs 1
		if (requestBlocked != /*Error near IL_0006: ldarg 1 (out-of-bounds)*/)
		{
			requestBlocked = /*Error near IL_000a: ldarg 1 (out-of-bounds)*/;
			OnStateChanged();
		}
		return /*Error near IL_0017: Stack underflow*/;
	}

	internal _003F OnAppPoolStateChanged()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		return OnStateChanged();
	}

	internal _003F OnDeleted()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected O, but got Unknown
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		return ((IActivatedMessageQueue)messageQueue).Delete();
	}

	internal _003F OnInvalidBinding()
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		hasInvalidBinding = /*Error near IL_0001: ldarg 1 (out-of-bounds)*/;
		return OnStateChanged();
	}

	private _003F OnStateChanged()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Expected O, but got Unknown
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		_ = messageQueue;
		return ((IActivatedMessageQueue)IsEnabled).SetEnabledState();
	}
}
