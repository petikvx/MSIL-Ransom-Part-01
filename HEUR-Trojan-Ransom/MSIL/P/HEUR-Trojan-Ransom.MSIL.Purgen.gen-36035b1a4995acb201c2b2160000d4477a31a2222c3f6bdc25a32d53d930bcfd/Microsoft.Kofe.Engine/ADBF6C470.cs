using Microsoft.Kofe.IJDWP;
using Microsoft.VisualStudio.Debugger.Interop;

namespace Microsoft.Kofe.Engine;

internal class ADBF6C470 : IDebugErrorBreakpoint2
{
	private IDebugPendingBreakpoint2 C8C82DCFB;

	private IDebugErrorBreakpointResolution2 A2EF3BB28;

	private IJdwpCodeLocation A5D6E6B8C;

	private string B9D06D4EB;

	public ADBF6C470(IDebugPendingBreakpoint2 pendingBP, IDebugErrorBreakpointResolution2 errorResolution, IJdwpCodeLocation location, string message)
	{
		C8C82DCFB = pendingBP;
		A2EF3BB28 = errorResolution;
		A5D6E6B8C = location;
		B9D06D4EB = message;
	}

	public int ACC97CADF(out IDebugPendingBreakpoint2 D0E6E0FC0)
	{
		D0E6E0FC0 = C8C82DCFB;
		return 0;
	}

	public int AF28D68C8(out IDebugErrorBreakpointResolution2 F09370E1E)
	{
		F09370E1E = A2EF3BB28;
		return 0;
	}

	public IJdwpCodeLocation F477E8871()
	{
		return A5D6E6B8C;
	}

	public string C719C3CCD()
	{
		return B9D06D4EB;
	}
}
