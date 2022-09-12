using Microsoft.VisualStudio.Debugger.Interop;

namespace Microsoft.Kofe.Engine;

internal class FDCBE81FE : Microsoft.Kofe.Engine.E43732427<IDebugProgram2, IEnumDebugPrograms2>, IEnumDebugPrograms2
{
	public FDCBE81FE(IDebugProgram2[] data)
		: base(data)
	{
	}

	public int F4E2527B5(uint C569D12C8, IDebugProgram2[] AD6F41086, ref uint CA5A794ED)
	{
		return base.Next(C569D12C8, AD6F41086, ref CA5A794ED);
	}
}
