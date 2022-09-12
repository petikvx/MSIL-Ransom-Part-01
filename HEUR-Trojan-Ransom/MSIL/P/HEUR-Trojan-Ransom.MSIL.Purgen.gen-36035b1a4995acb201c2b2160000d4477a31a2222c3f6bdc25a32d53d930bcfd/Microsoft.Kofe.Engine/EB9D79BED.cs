using Microsoft.VisualStudio.Debugger.Interop;

namespace Microsoft.Kofe.Engine;

internal class EB9D79BED : Microsoft.Kofe.Engine.E43732427<IDebugBoundBreakpoint2, IEnumDebugBoundBreakpoints2>, IEnumDebugBoundBreakpoints2
{
	public EB9D79BED(IDebugBoundBreakpoint2[] breakpoints)
		: base(breakpoints)
	{
	}

	public int ADB5280E2(uint B22DCEF44, IDebugBoundBreakpoint2[] CA18442B8, ref uint F6AB20021)
	{
		return base.Next(B22DCEF44, CA18442B8, ref F6AB20021);
	}
}
