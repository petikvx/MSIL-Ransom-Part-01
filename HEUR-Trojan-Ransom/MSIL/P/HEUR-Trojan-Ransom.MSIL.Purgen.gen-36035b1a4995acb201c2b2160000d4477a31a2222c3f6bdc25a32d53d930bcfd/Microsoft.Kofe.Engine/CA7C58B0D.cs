using Microsoft.VisualStudio.Debugger.Interop;

namespace Microsoft.Kofe.Engine;

internal class CA7C58B0D : Microsoft.Kofe.Engine.E43732427<IDebugThread2, IEnumDebugThreads2>, IEnumDebugThreads2
{
	public CA7C58B0D(IDebugThread2[] threads)
		: base(threads)
	{
	}

	public int F5E5F40DC(uint AEEB9CAFF, IDebugThread2[] E353E3E4A, ref uint FEF39A1B0)
	{
		return base.Next(AEEB9CAFF, E353E3E4A, ref FEF39A1B0);
	}
}
