using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("9f620be4-e535-11d6-b254-00039310a47a")]
public interface nsISemanticUnitScanner
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	void Start([MarshalAs(UnmanagedType.LPStr)] string characterSet);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool Next([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.WStringMarshaler")] string text, int length, int pos, [MarshalAs(UnmanagedType.U1)] bool isLastBuffer, ref int begin, ref int end);
}
