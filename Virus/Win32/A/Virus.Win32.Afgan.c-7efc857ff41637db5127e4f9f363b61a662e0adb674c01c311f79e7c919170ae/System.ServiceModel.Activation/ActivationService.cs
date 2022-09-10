using System.ServiceModel.Activation.Diagnostics;
using System.ServiceProcess;

namespace System.ServiceModel.Activation;

internal abstract class ActivationService : ServiceBase, IActivationService
{
	private _003F listenerAdapter;

	private _003F protocolName;

	private _003F isPaused;

	public _003F IsPaused => isPaused;

	public _003F ActivationServiceName => ((ServiceBase)/*Error near IL_0006: Stack underflow*/)._0015_001Dz_FFFD_FFFDQ_FFFD0_000C_0005tK_FFFD_FFFDmC_FFFD_000EPv_FFFD_0007_FFFD0_000C_FFFDQ_FFFD0_000D_0005_FFFD_FFFDQ_FFFD<_0021_00210, _0021_00211, _0021_00212, _0021_00213, _0021_00214, _0021_00215, _0021_00216, _0021_00217, _0021_00218, _0021_00219, _0021_002110, _0021_002111>((byte)/*Error near IL_0006: Stack underflow*/ != 0, (byte)/*Error near IL_0006: Stack underflow*/ != 0, (byte)/*Error near IL_0006: Stack underflow*/ != 0, (byte)/*Error near IL_0006: Stack underflow*/ != 0, (byte)(int)this != 0);

	public _003F ProtocolName => (byte)(int)protocolName != 0;

	protected ActivationService()
	{
		//Discarded unreachable code: IL_0006, IL_0014, IL_001b, IL_0022, IL_0029, IL_0030, IL_0037
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		/*Error near IL_0001: Unexpected SignatureTypeCode: (0x30b).*/;
	}

	public _003F CreateQueue()
	{
		/*Error: ldarg 1 (out-of-bounds)*/;
		/*Error near IL_0001: ldarg 2 (out-of-bounds)*/;
		return new ActivatedMessageQueue();
	}

	public _003F FindQueue()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		/*Error: ldarg 1 (out-of-bounds)*/;
		return ActivatedMessageQueue.Find();
	}

	protected override _003F OnContinue()
	{
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Incompatible stack heights: 0 vs 4
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		if (DiagnosticUtility.get_Item((byte)/*Error near IL_0005: Stack underflow*/ != 0, (byte)/*Error near IL_0005: Stack underflow*/ != 0, (byte)/*Error near IL_0005: Stack underflow*/ != 0, (string)/*Error near IL_0005: Stack underflow*/, (byte)/*Error near IL_0005: Stack underflow*/ != 0) != null)
		{
			_ = 8;
			_ = 589841;
			ListenerTraceUtility.TraceEvent();
		}
		isPaused = 0;
		return /*Error near IL_001b: Stack underflow*/;
	}

	protected override _003F OnPause()
	{
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Incompatible stack heights: 0 vs 4
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		if (DiagnosticUtility.get_Item((byte)/*Error near IL_0005: Stack underflow*/ != 0, (byte)/*Error near IL_0005: Stack underflow*/ != 0, (byte)/*Error near IL_0005: Stack underflow*/ != 0, (string)/*Error near IL_0005: Stack underflow*/, (byte)/*Error near IL_0005: Stack underflow*/ != 0) != null)
		{
			_ = 8;
			_ = 589842;
			ListenerTraceUtility.TraceEvent();
		}
		isPaused = 1;
		return /*Error near IL_001b: Stack underflow*/;
	}

	protected override _003F OnShutdown()
	{
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Incompatible stack heights: 0 vs 4
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		if (DiagnosticUtility.get_Item((byte)/*Error near IL_0005: Stack underflow*/ != 0, (byte)/*Error near IL_0005: Stack underflow*/ != 0, (byte)/*Error near IL_0005: Stack underflow*/ != 0, (string)/*Error near IL_0005: Stack underflow*/, (byte)/*Error near IL_0005: Stack underflow*/ != 0) != null)
		{
			_ = 8;
			_ = 589843;
			ListenerTraceUtility.TraceEvent();
		}
		return Shutdown();
	}

	protected override _003F OnStop()
	{
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Incompatible stack heights: 0 vs 4
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		if (DiagnosticUtility.get_Item((byte)/*Error near IL_0005: Stack underflow*/ != 0, (byte)/*Error near IL_0005: Stack underflow*/ != 0, (byte)/*Error near IL_0005: Stack underflow*/ != 0, (string)/*Error near IL_0005: Stack underflow*/, (byte)/*Error near IL_0005: Stack underflow*/ != 0) != null)
		{
			_ = 8;
			_ = 589847;
			ListenerTraceUtility.TraceEvent();
		}
		return Shutdown();
	}

	protected override _003F OnStart()
	{
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Incompatible stack heights: 0 vs 4
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		if (DiagnosticUtility.get_Item((byte)/*Error near IL_0005: Stack underflow*/ != 0, (byte)/*Error near IL_0005: Stack underflow*/ != 0, (byte)/*Error near IL_0005: Stack underflow*/ != 0, (string)/*Error near IL_0005: Stack underflow*/, (byte)/*Error near IL_0005: Stack underflow*/ != 0) != null)
		{
			_ = 8;
			_ = 589845;
			ListenerTraceUtility.TraceEvent();
		}
		return Start();
	}

	private _003F Start()
	{
		//Discarded unreachable code: IL_000f, IL_0023, IL_0028
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Expected I4, but got O
		//IL_0037: Expected I4, but got O
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Expected O, but got Unknown
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		if (SMSvcHost.get_IsWebhostSupported((byte)/*Error near IL_0005: Stack underflow*/ != 0, (byte)/*Error near IL_0005: Stack underflow*/ != 0, (byte)/*Error near IL_0005: Stack underflow*/ != 0, (string)/*Error near IL_0005: Stack underflow*/, (byte)/*Error near IL_0005: Stack underflow*/ != 0) == null)
		{
			_ = 50;
			/*Error near IL_000a: Unexpected SignatureTypeCode: (0x30b).*/;
		}
		isPaused = 0;
		ListenerAdapter obj = new ListenerAdapter((byte)/*Error near IL_0037: Stack underflow*/ != 0, (byte)/*Error near IL_0037: Stack underflow*/ != 0, (byte)(int)this != 0, (byte)(int)this != 0, __arglist());
		((ActivationService)/*Error near IL_003c: Stack underflow*/).listenerAdapter = obj;
		return ((ListenerAdapterBase)listenerAdapter).vmethod_6();
	}

	private _003F Shutdown()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected O, but got Unknown
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		return ((ListenerAdapter)listenerAdapter).Close();
	}

	public _003F StopService()
	{
		//Discarded unreachable code: IL_0006
		/*Error near IL_0001: Unexpected SignatureTypeCode: (0x30b).*/;
	}
}
