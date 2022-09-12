using Microsoft.VisualStudio.Debugger.Interop;

namespace Microsoft.Kofe.Engine;

internal sealed class BD52E9688 : C368CE8F7, IDebugEngineCreateEvent2
{
	public const string EF9B897E9 = "FE5B734C-759D-4E59-AB04-F103343BDD06";

	private IDebugEngine2 F1B034AE0;

	private BD52E9688(B92FAA9B7 engine)
	{
		F1B034AE0 = (IDebugEngine2)(object)engine;
	}

	public static void D30D556F9(B92FAA9B7 A9875D341)
	{
		BD52E9688 c0EFB72BE = new BD52E9688(A9875D341);
		A9875D341.F4F01CC92.A66BFCA0B((IDebugEvent2)(object)c0EFB72BE, "FE5B734C-759D-4E59-AB04-F103343BDD06", null, null);
	}

	private int FC8FD7BE8(out IDebugEngine2 CCF2A84E1)
	{
		CCF2A84E1 = F1B034AE0;
		return 0;
	}
}
