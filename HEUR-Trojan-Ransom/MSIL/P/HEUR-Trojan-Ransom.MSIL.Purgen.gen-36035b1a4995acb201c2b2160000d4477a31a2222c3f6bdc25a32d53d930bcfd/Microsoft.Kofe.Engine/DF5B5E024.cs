using Microsoft.VisualStudio.Debugger.Interop;

namespace Microsoft.Kofe.Engine;

internal sealed class DF5B5E024 : BE9A0B98B, IDebugBreakpointEvent2
{
	public const string EB07304DD = "501C1E21-C557-48B8-BA30-A1EAB0BC4A74";

	private IEnumDebugBoundBreakpoints2 B3DBC41B2;

	public DF5B5E024(IEnumDebugBoundBreakpoints2 boundBreakpoints)
	{
		B3DBC41B2 = boundBreakpoints;
	}

	private int E616834F9(out IEnumDebugBoundBreakpoints2 E3E36A028)
	{
		E3E36A028 = B3DBC41B2;
		return 0;
	}
}
