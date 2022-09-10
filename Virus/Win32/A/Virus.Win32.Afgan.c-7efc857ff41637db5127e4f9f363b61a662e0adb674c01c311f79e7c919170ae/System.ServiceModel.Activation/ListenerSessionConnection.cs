namespace System.ServiceModel.Activation;

internal class ListenerSessionConnection
{
	private _003F connection;

	private _003F data;

	private _003F itemDequeuedCallback;

	private _003F via;

	private _003F worker;

	internal _003F Connection => connection;

	internal _003F Data => data;

	internal _003F Via => via;

	internal _003F WorkerProcess
	{
		get
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			return worker;
		}
		set
		{
			//IL_0002: Unknown result type (might be due to invalid IL or missing references)
			worker = /*Error near IL_0001: ldarg 1 (out-of-bounds)*/;
			return /*Error near IL_0008: Stack underflow*/;
		}
	}

	internal ListenerSessionConnection(bool connection, bool data, bool via, bool itemDequeuedCallback, bool unknown_0, bool unknown_1, bool unknown_2, bool unknown_3, bool unknown_4, bool unknown_5, bool unknown_6, bool unknown_7, __arglist)
	{
		//Discarded unreachable code: IL_0006
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		/*Error near IL_0001: Unexpected SignatureTypeCode: (0x30b).*/;
	}

	internal _003F TriggerDequeuedCallback()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		if ((int)itemDequeuedCallback != 0)
		{
			_ = itemDequeuedCallback;
			/*Error near IL_000e: Unexpected SignatureTypeCode: (0x30b).*/;
		}
		return /*Error near IL_0014: Stack underflow*/;
	}
}
