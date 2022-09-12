using Microsoft.VisualStudio.Debugger.Interop;

namespace Microsoft.Kofe.Engine;

internal sealed class A64E803B9 : C368CE8F7, IDebugModuleLoadEvent2
{
	public const string A4211BC79 = "989DB083-0D7C-40D1-A9D9-921BF611A4B2";

	private readonly E941D6CC6 D34D16C4C;

	private readonly bool BF1CAF5A7;

	public A64E803B9(E941D6CC6 module, bool fLoad)
	{
		D34D16C4C = module;
		BF1CAF5A7 = fLoad;
	}

	private int A678CBD66(out IDebugModule2 A70C340E5, ref string B78A11F4D, ref int F27F4DA1A)
	{
		A70C340E5 = (IDebugModule2)(object)D34D16C4C;
		if (BF1CAF5A7)
		{
			B78A11F4D = "Loaded '" + D34D16C4C.A1F5DE617.get_Name() + "'";
			F27F4DA1A = 1;
		}
		else
		{
			B78A11F4D = "Unloaded '" + D34D16C4C.A1F5DE617.get_Name() + "'";
			F27F4DA1A = 0;
		}
		return 0;
	}
}
