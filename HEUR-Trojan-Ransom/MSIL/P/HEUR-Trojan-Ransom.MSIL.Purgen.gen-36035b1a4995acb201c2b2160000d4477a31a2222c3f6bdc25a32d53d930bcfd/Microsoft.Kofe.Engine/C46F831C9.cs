using Microsoft.VisualStudio.Debugger.Interop;

namespace Microsoft.Kofe.Engine;

internal sealed class C46F831C9 : C368CE8F7, IDebugThreadDestroyEvent2
{
	public const string E19330A15 = "2C3B7532-A36F-4A6E-9072-49BE649B8541";

	private readonly uint AD45F684F;

	public C46F831C9(uint exitCode)
	{
		AD45F684F = exitCode;
	}

	private int D81C44906(out uint A04BFA959)
	{
		A04BFA959 = AD45F684F;
		return 0;
	}
}
