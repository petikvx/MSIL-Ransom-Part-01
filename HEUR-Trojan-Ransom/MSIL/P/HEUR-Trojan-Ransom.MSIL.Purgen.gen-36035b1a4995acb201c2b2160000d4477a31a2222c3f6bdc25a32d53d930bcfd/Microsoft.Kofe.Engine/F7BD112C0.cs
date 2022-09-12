using Microsoft.VisualStudio.Debugger.Interop;

namespace Microsoft.Kofe.Engine;

internal class F7BD112C0 : Microsoft.Kofe.Engine.E43732427<IDebugErrorBreakpoint2, IEnumDebugErrorBreakpoints2>, IEnumDebugErrorBreakpoints2
{
	public F7BD112C0(IDebugErrorBreakpoint2[] breakpoints)
		: base(breakpoints)
	{
	}

	public int DC239B6A3(uint AEAB59954, IDebugErrorBreakpoint2[] D56E674C7, ref uint A86F66A04)
	{
		return base.Next(AEAB59954, D56E674C7, ref A86F66A04);
	}
}
