using Microsoft.VisualStudio.Debugger.Interop;

namespace Microsoft.Kofe.Engine;

internal class ABE09AC6A : C368CE8F7, IDebugBreakpointErrorEvent2
{
	public const string F116B4F18 = "abb0ca42-f82b-4622-84e4-6903ae90f210";

	private ADBF6C470 F443A8075;

	public ABE09AC6A(ADBF6C470 errorBP)
	{
		F443A8075 = errorBP;
	}

	public int A656479D9(out IDebugErrorBreakpoint2 A32F69EF7)
	{
		A32F69EF7 = (IDebugErrorBreakpoint2)(object)F443A8075;
		return 0;
	}
}
