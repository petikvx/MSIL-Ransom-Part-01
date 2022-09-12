using Microsoft.VisualStudio.Debugger.Interop;

namespace Microsoft.Kofe.Engine;

internal sealed class C1DFE54C0 : C368CE8F7, IDebugOutputStringEvent2
{
	public const string C3E98087F = "569c4bb1-7b82-46fc-ae28-4536ddad753e";

	private string B291D6736;

	public C1DFE54C0(string str)
	{
		B291D6736 = str;
	}

	private int C9A89D326(out string D05FC7848)
	{
		D05FC7848 = B291D6736;
		return 0;
	}
}
