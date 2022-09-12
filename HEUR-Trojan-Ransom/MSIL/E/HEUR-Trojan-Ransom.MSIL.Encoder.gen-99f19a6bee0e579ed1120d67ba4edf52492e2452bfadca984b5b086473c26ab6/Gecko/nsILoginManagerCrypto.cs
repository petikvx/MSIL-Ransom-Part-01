using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[Guid("2030770e-542e-40cd-8061-cd9d4ad4227f")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public interface nsILoginManagerCrypto
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	void Encrypt([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase plainText, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase retval);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void Decrypt([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase cipherText, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase retval);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool GetUiBusyAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool GetIsLoggedInAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	uint GetDefaultEncTypeAttribute();
}
