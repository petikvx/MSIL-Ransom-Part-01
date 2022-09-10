namespace System.ServiceModel.Activation;

internal class AppAction
{
	private _003F actionType;

	private _003F path;

	private _003F appPoolId;

	private _003F requestsBlocked;

	private _003F bindings;

	public _003F ActionType => actionType;

	public _003F Path => (byte)(int)path != 0;

	public _003F AppPoolId => (byte)(int)appPoolId != 0;

	public bool Bindings => bindings;

	public _003F RequestsBlocked => requestsBlocked;

	private AppAction()
	{
		//Discarded unreachable code: IL_0006
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		/*Error near IL_0001: Unexpected SignatureTypeCode: (0x30b).*/;
	}

	public static _003F CreateDeletedAction()
	{
		_ = 0;
		return new AppAction();
	}

	public static _003F CreateBindingsChangedAction()
	{
		//IL_000e: Expected O, but got Unknown
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		_ = 1;
		new AppAction();
		/*Error near IL_0006: stloc 0 (out-of-bounds)*/;
		((AppAction)/*Error near IL_0007: ldloc 0 (out-of-bounds)*/).bindings = /*Error near IL_0008: ldarg 0 (out-of-bounds)*/;
		return /*Error near IL_000e: ldloc 0 (out-of-bounds)*/;
	}

	public static _003F CreateAppPoolChangedAction()
	{
		//IL_000e: Expected O, but got Unknown
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		_ = 1;
		new AppAction();
		/*Error near IL_0006: stloc 0 (out-of-bounds)*/;
		((AppAction)/*Error near IL_0007: ldloc 0 (out-of-bounds)*/).appPoolId = /*Error near IL_0008: ldarg 0 (out-of-bounds)*/;
		return /*Error near IL_000e: ldloc 0 (out-of-bounds)*/;
	}

	public _003F MergeFromCreatedAction()
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		actionType = 1;
		/*Error near IL_0008: ldarg 1 (out-of-bounds)*/;
		/*Error near IL_0009: ldarg 3 (out-of-bounds)*/;
		return SetSettings();
	}

	public _003F MergeFromDeletedAction()
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		actionType = 0;
		return /*Error near IL_0008: Stack underflow*/;
	}

	public _003F MergeFromBindingChangedAction()
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		bindings = /*Error near IL_0001: ldarg 1 (out-of-bounds)*/;
		return /*Error near IL_0008: Stack underflow*/;
	}

	public _003F MergeFromAppPoolChangedAction()
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		appPoolId = /*Error near IL_0001: ldarg 1 (out-of-bounds)*/;
		return /*Error near IL_0008: Stack underflow*/;
	}

	public _003F MergeFromRequestsBlockedAction()
	{
		//Discarded unreachable code: IL_0007
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		/*Error near IL_0001: ldarg 1 (out-of-bounds)*/;
		/*Error near IL_0002: Unexpected SignatureTypeCode: (0x30).*/;
	}

	private _003F SetSettings()
	{
		//Discarded unreachable code: IL_0015
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		path = /*Error near IL_0001: ldarg 1 (out-of-bounds)*/;
		appPoolId = /*Error near IL_0008: ldarg 2 (out-of-bounds)*/;
		/*Error near IL_000f: ldarg 3 (out-of-bounds)*/;
		/*Error near IL_0010: Unexpected SignatureTypeCode: (0x30).*/;
	}
}
