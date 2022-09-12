using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[Guid("87dbd64a-4466-474e-95f5-1ad1cee5702c")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public interface nsITokenPasswordDialogs
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetPassword([MarshalAs(UnmanagedType.Interface)] nsIInterfaceRequestor ctx, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.WStringMarshaler")] string tokenName, [MarshalAs(UnmanagedType.U1)] ref bool canceled);
}
