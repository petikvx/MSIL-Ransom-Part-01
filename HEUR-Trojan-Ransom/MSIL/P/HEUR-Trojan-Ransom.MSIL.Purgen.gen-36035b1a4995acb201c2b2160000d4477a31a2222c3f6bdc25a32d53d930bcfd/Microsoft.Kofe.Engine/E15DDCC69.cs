using System;
using System.Runtime.InteropServices;
using Microsoft.VisualStudio.Debugger.Interop;

namespace Microsoft.Kofe.Engine;

[ComVisible(true)]
[Guid("FF3E23A2-DA7E-4fa7-AF47-6EDEDE4E922E")]
public class E15DDCC69 : IDebugProgramProvider2
{
	private int B969B47FB(enum_PROVIDER_FLAGS B83E136D4, IDebugDefaultPort2 CF3A6F652, AD_PROCESS_ID A0EA1D6E3, CONST_GUID_ARRAY DFF61589F, PROVIDER_PROCESS_DATA[] CD5FF6395)
	{
		return 1;
	}

	private int B396841B9(enum_PROVIDER_FLAGS A7F27073D, IDebugDefaultPort2 D81ED0D42, AD_PROCESS_ID A8C8404BD, ref Guid DB14F4640, ulong FB350065A, out IDebugProgramNode2 DF8534150)
	{
		DF8534150 = null;
		return 1;
	}

	private int B7E48EC54(ushort C8CABC432)
	{
		return 0;
	}

	private int D043D7914(enum_PROVIDER_FLAGS E5AD76B00, IDebugDefaultPort2 B1A14E5D2, AD_PROCESS_ID FCF686946, CONST_GUID_ARRAY E86BD7D3E, ref Guid B0C5D8AE2, IDebugPortNotify2 C9CB2B2B4)
	{
		return 1;
	}
}
