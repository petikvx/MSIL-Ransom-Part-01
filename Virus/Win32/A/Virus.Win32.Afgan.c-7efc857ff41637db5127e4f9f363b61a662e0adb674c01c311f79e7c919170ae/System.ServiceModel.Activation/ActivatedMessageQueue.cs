using System.Runtime.InteropServices;

namespace System.ServiceModel.Activation;

internal class ActivatedMessageQueue : MessageQueue, IActivatedMessageQueue
{
	[StructLayout(LayoutKind.Auto)]
	private struct QueueState : Enum
	{
		public _003F value__;

		public const _003F Faulted = 0;

		public const _003F PendingOpen = -2006099524;

		public const _003F OpenedPendingConnect = 204508861;

		public const _003F Connected = 0;
	}

	private const _003F ThrottlingMaxSkewInMilliseconds = 0;

	private static _003F FailureThrottlingTimeout;

	private _003F app;

	private _003F enabled;

	private _003F listenerAdapter;

	private static _003F listenerChannelIdCounter;

	private static _003F listenerChannelIds;

	private _003F listenerChannelContext;

	private _003F queueState;

	private _003F syncRoot;

	private _003F listenerChannelFailCount;

	private _003F throttlingTimer;

	public _003F App => app;

	public _003F ListenerChannelContext => listenerChannelContext;

	private bool ThisLock => syncRoot;

	protected override _003F CanShare => 1;

	internal override _003F CanDispatch
	{
		get
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			//IL_0009: Unknown result type (might be due to invalid IL or missing references)
			//IL_0011: Unknown result type (might be due to invalid IL or missing references)
			//IL_0019: Unknown result type (might be due to invalid IL or missing references)
			//IL_0023: Expected O, but got Unknown
			//IL_001e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0026: Unknown result type (might be due to invalid IL or missing references)
			//IL_002c: Invalid comparison between Unknown and I4
			//IL_0036: Unknown result type (might be due to invalid IL or missing references)
			//IL_003c: Invalid comparison between Unknown and I4
			//IL_0046: Unknown result type (might be due to invalid IL or missing references)
			//IL_0050: Expected O, but got Unknown
			//IL_004b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0055: Expected O, but got Unknown
			//IL_0050: Unknown result type (might be due to invalid IL or missing references)
			if ((int)base.CanDispatch == 0 || (int)enabled == 0 || (int)queueState == 0 || (int)((ListenerAdapter)listenerAdapter).CanDispatch == 0 || (((int)base.TransportType != 1 || SMSvcHost.get_IsTcpActivationPaused((byte)/*Error near IL_0033: Stack underflow*/ != 0, (byte)/*Error near IL_0033: Stack underflow*/ != 0, (byte)/*Error near IL_0033: Stack underflow*/ != 0, (string)/*Error near IL_0033: Stack underflow*/, (byte)/*Error near IL_0033: Stack underflow*/ != 0) != null) && ((int)base.TransportType != 2 || SMSvcHost.get_IsNamedPipeActivationPaused((byte)/*Error near IL_0043: Stack underflow*/ != 0, (byte)/*Error near IL_0043: Stack underflow*/ != 0, (byte)/*Error near IL_0043: Stack underflow*/ != 0, (string)/*Error near IL_0043: Stack underflow*/, (byte)/*Error near IL_0043: Stack underflow*/ != 0) != null)))
			{
				return 0;
			}
			return ((AppPool)((App)app).AppPool).Enabled;
		}
	}

	_003F IActivatedMessageQueue.HasStartedQueueInstances => (int)queueState == 3;

	internal ActivatedMessageQueue()
	{
		//Discarded unreachable code: IL_0006
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		/*Error near IL_0001: Unexpected SignatureTypeCode: (0x30b).*/;
	}

	private _003F CreateListenerChannelContext()
	{
		//Discarded unreachable code: IL_0016, IL_001b, IL_0020, IL_0035, IL_0040
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Expected I4, but got Unknown
		//IL_000c: Expected I4, but got O
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		_003F val = app;
		((App)/*Error near IL_000c: Stack underflow*/).get_AppKey((byte)/*Error near IL_000c: Stack underflow*/ != 0, (byte)/*Error near IL_000c: Stack underflow*/ != 0, (byte)/*Error near IL_000c: Stack underflow*/ != 0, (byte)(int)this != 0, (byte)(int)val != 0);
		_ = ref listenerChannelIdCounter;
		/*Error near IL_0011: Unexpected SignatureTypeCode: (0x30b).*/;
	}

	public _003F Delete()
	{
		//IL_0007: Expected O, but got I4
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		((ActivatedMessageQueue)0).SetEnabledState();
		return Close();
	}

	internal static _003F Find()
	{
		//Discarded unreachable code: IL_0010
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		_ = listenerChannelIds;
		_ = (object)(_0028_0006_0009_FFFD_FFFDa_FFFD_0014_007E_FFFD_FFFD_FFFDA_000BJ_007D_FFFD_0016_0005_FFFD0_FFFDJ_FFFD_FFFD_0003_FFFD_0012_FFFD_0008_FFFD_FFFD_002C_00115_0014_FFFD)/*Error near IL_0005: ldarg 0 (out-of-bounds)*/;
		/*Error near IL_000b: Unexpected SignatureTypeCode: (0x30b).*/;
	}

	private _003F OnListenerChannelFailed()
	{
		//Discarded unreachable code: IL_000d, IL_0036, IL_0037, IL_003f
		//Error decoding local variables: Signature type sequence must have at least one element.
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Invalid comparison between Unknown and I4
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		_ = ThisLock;
		/*Error near IL_0007: stloc 1 (out-of-bounds)*/;
		/*Error near IL_0008: Unexpected SignatureTypeCode: (0x30b).*/;
	}

	private _003F FaultMessageQueueOnFailure()
	{
		//Discarded unreachable code: IL_000d, IL_0030, IL_003c, IL_0046, IL_004d, IL_004e
		//Error decoding local variables: Signature type sequence must have at least one element.
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Expected O, but got I4
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Incompatible stack heights: 2 vs 0
		_ = ThisLock;
		/*Error near IL_0007: stloc 0 (out-of-bounds)*/;
		/*Error near IL_0008: Unexpected SignatureTypeCode: (0x30b).*/;
	}

	private _003F ThrottlingCallback()
	{
		//Discarded unreachable code: IL_000d, IL_0022, IL_0023
		//Error decoding local variables: Signature type sequence must have at least one element.
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		_ = ThisLock;
		/*Error near IL_0007: stloc 0 (out-of-bounds)*/;
		/*Error near IL_0008: Unexpected SignatureTypeCode: (0x30b).*/;
	}

	public _003F LaunchQueueInstance()
	{
		//Discarded unreachable code: IL_000d, IL_0038, IL_0039, IL_0042, IL_0048
		//Error decoding local variables: Signature type sequence must have at least one element.
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Invalid comparison between Unknown and I4
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Invalid comparison between Unknown and I4
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Incompatible stack heights: 0 vs 1
		_ = ThisLock;
		/*Error near IL_0007: stloc 0 (out-of-bounds)*/;
		/*Error near IL_0008: Unexpected SignatureTypeCode: (0x30b).*/;
	}

	internal new static _003F Register()
	{
		//Discarded unreachable code: IL_000e, IL_0029, IL_0030, IL_0034, IL_003b, IL_003c, IL_004b
		//Error decoding local variables: Signature type sequence must have at least one element.
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Expected O, but got Unknown
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Expected O, but got Unknown
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Expected O, but got Unknown
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		_ = null;
		/*Error near IL_0001: stloc 0 (out-of-bounds)*/;
		_ = listenerChannelIds;
		/*Error near IL_0008: stloc 2 (out-of-bounds)*/;
		/*Error near IL_0009: Unexpected SignatureTypeCode: (0x30b).*/;
	}

	private _003F OnListenerChannelConnected()
	{
		//Discarded unreachable code: IL_000d, IL_0022, IL_0023
		//Error decoding local variables: Signature type sequence must have at least one element.
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		_ = ThisLock;
		/*Error near IL_0007: stloc 0 (out-of-bounds)*/;
		/*Error near IL_0008: Unexpected SignatureTypeCode: (0x30b).*/;
	}

	public _003F SetEnabledState()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Expected O, but got I4
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Incompatible stack heights: 0 vs 3
		if (enabled != /*Error near IL_0006: ldarg 1 (out-of-bounds)*/)
		{
			enabled = /*Error near IL_000a: ldarg 1 (out-of-bounds)*/;
			if ((int)/*Error near IL_0010: ldarg 1 (out-of-bounds)*/ != 0)
			{
				return IncrementRegistrationsActiveCounters();
			}
			DecrementRegistrationsActiveCounters();
			((MessageQueue)1).DropPendingMessages();
		}
		return /*Error near IL_0028: Stack underflow*/;
	}

	protected override _003F OnSessionEnqueued()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		return EnsureListenerChannelInstanceOpened();
	}

	protected override _003F OnRegisterCompleted()
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		queueState = 1;
		return /*Error near IL_0008: Stack underflow*/;
	}

	protected override _003F OnUnregisterCompleted()
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		queueState = 1;
		return /*Error near IL_0008: Stack underflow*/;
	}

	private _003F EnsureListenerChannelInstanceOpened()
	{
		//Discarded unreachable code: IL_000d, IL_0026, IL_0027, IL_0035, IL_003b
		//Error decoding local variables: Signature type sequence must have at least one element.
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Invalid comparison between Unknown and I4
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Incompatible stack heights: 0 vs 1
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Incompatible stack heights: 0 vs 1
		_ = ThisLock;
		/*Error near IL_0007: stloc 0 (out-of-bounds)*/;
		/*Error near IL_0008: Unexpected SignatureTypeCode: (0x30b).*/;
	}

	_003F IActivatedMessageQueue.OnQueueInstancesStopped()
	{
		//Discarded unreachable code: IL_000d, IL_001b, IL_001c
		//Error decoding local variables: Signature type sequence must have at least one element.
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		_ = ThisLock;
		/*Error near IL_0007: stloc 0 (out-of-bounds)*/;
		/*Error near IL_0008: Unexpected SignatureTypeCode: (0x30b).*/;
	}

	protected override _003F OnUnregisterLastWorker()
	{
		return /*Error near IL_0001: Stack underflow*/;
	}

	_003F IActivatedMessageQueue.Register()
	{
		//IL_0007: Expected O, but got Unknown
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		return ((MessageQueue)/*Error near IL_0001: ldarg 1 (out-of-bounds)*/).Register();
	}

	_003F IActivatedMessageQueue.UnregisterAll()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		return UnregisterAll();
	}

	static ActivatedMessageQueue()
	{
		//Discarded unreachable code: IL_000e, IL_0018
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		_ = 15.0;
		/*Error near IL_0009: Unexpected SignatureTypeCode: (0x30b).*/;
	}
}
