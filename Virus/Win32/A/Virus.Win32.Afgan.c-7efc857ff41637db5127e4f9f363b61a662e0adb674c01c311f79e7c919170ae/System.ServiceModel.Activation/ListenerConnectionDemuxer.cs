using System.ServiceModel.Activation.Diagnostics;

namespace System.ServiceModel.Activation;

internal class ListenerConnectionDemuxer
{
	private _003F acceptor;

	private _003F connectionReaders;

	private _003F isDisposed;

	private _003F onConnectionModeKnown;

	private _003F onConnectionClosed;

	private _003F connectionHandleDuplicated;

	private _003F onViaDecoded;

	private _003F transportType;

	private _003F channelInitializationTimeout;

	private bool ThisLock => this;

	public ListenerConnectionDemuxer()
	{
		//Discarded unreachable code: IL_0006, IL_0013, IL_0031, IL_0036, IL_0050
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Expected O, but got I
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		/*Error near IL_0001: Unexpected SignatureTypeCode: (0x30b).*/;
	}

	public _003F Dispose()
	{
		//Discarded unreachable code: IL_000d, IL_0025, IL_0026, IL_002a, IL_0036, IL_003b, IL_003f, IL_004b, IL_004d, IL_0058, IL_0063
		//Error decoding local variables: Signature type sequence must have at least one element.
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		_ = ThisLock;
		/*Error near IL_0007: stloc 1 (out-of-bounds)*/;
		/*Error near IL_0008: Unexpected SignatureTypeCode: (0x30b).*/;
	}

	private unsafe _003F SetupModeReader()
	{
		//Discarded unreachable code: IL_003a, IL_0047, IL_0050, IL_0059, IL_005a
		//Error decoding local variables: Signature type sequence must have at least one element.
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Expected O, but got I
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Incompatible stack heights: 0 vs 2
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		if ((int)onConnectionModeKnown == 0)
		{
			((ListenerConnectionDemuxer)__ldftn(ListenerConnectionDemuxer.OnConnectionModeKnown)).onConnectionModeKnown = new ListenerConnectionModeCallback();
		}
		/*Error near IL_001a: ldarg 1 (out-of-bounds)*/;
		_ = onConnectionModeKnown;
		_ = onConnectionClosed;
		new ListenerConnectionModeReader();
		/*Error near IL_002c: stloc 0 (out-of-bounds)*/;
		_ = ThisLock;
		/*Error near IL_0034: stloc 2 (out-of-bounds)*/;
		/*Error near IL_0035: Unexpected SignatureTypeCode: (0x30b).*/;
	}

	private _003F OnConnectionAvailable()
	{
		//Discarded unreachable code: IL_0034
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Invalid comparison between Unknown and I4
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Expected O, but got Unknown
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected I4, but got Unknown
		//IL_002d: Expected O, but got Unknown
		if ((int)transportType != 1)
		{
			ListenerPerfCounters.IncrementConnectionsAcceptedNamedPipe();
		}
		else
			ListenerPerfCounters.IncrementConnectionsAcceptedTcp();
		((ListenerConnectionDemuxer)/*Error near IL_0016: ldarg 1 (out-of-bounds)*/).SetupModeReader();
		/*Error near IL_001c: stloc 0 (out-of-bounds)*/;
		if ((int)/*Error near IL_001d: ldloc 0 (out-of-bounds)*/ != 0)
		{
			/*Error near IL_0020: ldloc 0 (out-of-bounds)*/;
			return ((ListenerConnectionModeReader)channelInitializationTimeout).StartReading((byte)(int)/*Error near IL_0027: ldarg 2 (out-of-bounds)*/ != 0);
		}
		/*Error near IL_002e: ldarg 2 (out-of-bounds)*/;
		/*Error near IL_002f: Unexpected SignatureTypeCode: (0x30b).*/;
	}

	private _003F OnConnectionModeKnown()
	{
		//Discarded unreachable code: IL_000e, IL_0020, IL_0027, IL_0028, IL_0066, IL_0073, IL_007f, IL_008a, IL_00b6, IL_00de, IL_00e0
		//Error decoding local variables: Signature type sequence must have at least one element.
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Expected O, but got Unknown
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Expected I4, but got Unknown
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_006d: Expected I4, but got Unknown
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0092: Expected O, but got Unknown
		//IL_008d: Unknown result type (might be due to invalid IL or missing references)
		//IL_009b: Expected O, but got Unknown
		//IL_0096: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ca: Expected I4, but got Unknown
		//IL_00cc: Unknown result type (might be due to invalid IL or missing references)
		_ = ThisLock;
		/*Error near IL_0007: stloc 0 (out-of-bounds)*/;
		/*Error near IL_0009: Unexpected SignatureTypeCode: (0x30b).*/;
	}

	private _003F OnViaDecoded()
	{
		//Discarded unreachable code: IL_001a, IL_0029, IL_0030, IL_0031
		//Error decoding local variables: Signature type sequence must have at least one element.
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			/*Error near IL_0005: Stack underflow*/();
		}
		finally
		{
			((ListenerSessionConnection)/*Error near IL_000c: Stack underflow*/).TriggerDequeuedCallback();
		}
		_ = ThisLock;
		/*Error near IL_0014: stloc 0 (out-of-bounds)*/;
		/*Error near IL_0015: Unexpected SignatureTypeCode: (0x30b).*/;
	}

	private _003F OnConnectionClosed()
	{
		//Discarded unreachable code: IL_000d, IL_001c, IL_0023, IL_0024
		//Error decoding local variables: Signature type sequence must have at least one element.
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		_ = ThisLock;
		/*Error near IL_0007: stloc 0 (out-of-bounds)*/;
		/*Error near IL_0008: Unexpected SignatureTypeCode: (0x30b).*/;
	}

	private _003F OnSingletonConnection()
	{
		//Discarded unreachable code: IL_0006, IL_000c, IL_0043, IL_0050, IL_0057, IL_005e, IL_005f, IL_0071
		//Error decoding local variables: Signature type sequence must have at least one element.
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Expected O, but got Unknown
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Expected O, but got Unknown
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Expected O, but got Unknown
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_0066: Expected O, but got Unknown
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		//IL_006c: Expected O, but got Unknown
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		//IL_0071: Expected O, but got Unknown
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		//IL_006c: Incompatible stack heights: 0 vs 3
		/*Error: ldarg 1 (out-of-bounds)*/;
		/*Error near IL_0001: Unexpected SignatureTypeCode: (0x30b).*/;
	}

	private _003F OnDuplexConnection()
	{
		//Discarded unreachable code: IL_0006, IL_000c, IL_0043, IL_0050, IL_0057, IL_005e, IL_005f, IL_0071
		//Error decoding local variables: Signature type sequence must have at least one element.
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Expected O, but got Unknown
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Expected O, but got Unknown
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Expected O, but got Unknown
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_0066: Expected O, but got Unknown
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		//IL_006c: Expected O, but got Unknown
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		//IL_0071: Expected O, but got Unknown
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		//IL_006c: Incompatible stack heights: 0 vs 3
		/*Error: ldarg 1 (out-of-bounds)*/;
		/*Error near IL_0001: Unexpected SignatureTypeCode: (0x30b).*/;
	}

	public _003F StartDemuxing()
	{
		//Discarded unreachable code: IL_000b
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		_ = acceptor;
		/*Error near IL_0006: Unexpected SignatureTypeCode: (0x30b).*/;
	}
}
