using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("ba915921-b9c0-400d-8e4f-ca1b80c5699a")]
public interface nsIBlocklistPrompt
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	void Prompt([MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 1)] nsIVariant[] aAddons, uint aCount);
}
