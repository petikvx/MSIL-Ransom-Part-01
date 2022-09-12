using Microsoft.VisualStudio.Debugger.Interop;

namespace Microsoft.Kofe.Engine;

internal sealed class B46FD4907 : C368CE8F7, IDebugBreakpointBoundEvent2
{
	public const string BB11A57DA = "1dddb704-cf99-4b8a-b746-dabb01dd13a0";

	private C1C0BFBF8 B7DEE6E30;

	private BE52A5725 EEFEE65BE;

	public B46FD4907(C1C0BFBF8 pendingBreakpoint, BE52A5725 boundBreakpoint)
	{
		B7DEE6E30 = pendingBreakpoint;
		EEFEE65BE = boundBreakpoint;
	}

	private int E4D61FD32(out IEnumDebugBoundBreakpoints2 E50F03BCA)
	{
		E50F03BCA = (IEnumDebugBoundBreakpoints2)(object)new EB9D79BED((IDebugBoundBreakpoint2[])(object)new IDebugBoundBreakpoint2[1] { EEFEE65BE });
		return 0;
	}

	private int F01F4B4BB(out IDebugPendingBreakpoint2 B574D1EF5)
	{
		B574D1EF5 = (IDebugPendingBreakpoint2)(object)B7DEE6E30;
		return 0;
	}
}
