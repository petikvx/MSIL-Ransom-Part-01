using Microsoft.VisualStudio.Debugger.Interop;

namespace Microsoft.Kofe.Engine;

internal class D04E124C3 : Microsoft.Kofe.Engine.E43732427<IDebugModule2, IEnumDebugModules2>, IEnumDebugModules2
{
	public D04E124C3(IDebugModule2[] modules)
		: base(modules)
	{
	}

	public int C12F82B2F(uint BFE6A5967, IDebugModule2[] AE5C89ACA, ref uint DA092BC1D)
	{
		return base.Next(BFE6A5967, AE5C89ACA, ref DA092BC1D);
	}
}
