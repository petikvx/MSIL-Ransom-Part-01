using Microsoft.VisualStudio.Debugger.Interop;

namespace Microsoft.Kofe.Engine;

internal sealed class C387EF2B4 : C368CE8F7, IDebugSymbolSearchEvent2
{
	public const string DFC24A870 = "638F7C54-C160-4c7b-B2D0-E0337BC61F8C";

	private E941D6CC6 EDA7EF5FB;

	private string CEC88B4B1;

	private uint E776C8A9C;

	public C387EF2B4(E941D6CC6 module, string searchInfo, uint symbolFlags)
	{
		EDA7EF5FB = module;
		CEC88B4B1 = searchInfo;
		E776C8A9C = symbolFlags;
	}

	private int B6580B972(out IDebugModule3 A8083BF6E, ref string E34D45225, enum_MODULE_INFO_FLAGS[] E5DB5B6A5)
	{
		A8083BF6E = (IDebugModule3)(object)EDA7EF5FB;
		E34D45225 = CEC88B4B1;
		E5DB5B6A5[0] = (enum_MODULE_INFO_FLAGS)E776C8A9C;
		return 0;
	}
}
