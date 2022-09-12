using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("6e35dbc0-49ef-4e2c-b1ea-b72ec64450a2")]
public interface nsIAuthModule
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	void Init([MarshalAs(UnmanagedType.LPStr)] string aServiceName, uint aServiceFlags, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.WStringMarshaler")] string aDomain, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.WStringMarshaler")] string aUsername, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.WStringMarshaler")] string aPassword);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetNextToken(IntPtr aInToken, uint aInTokenLength, ref IntPtr aOutToken, ref uint aOutTokenLength);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void Wrap(IntPtr aInToken, uint aInTokenLength, [MarshalAs(UnmanagedType.U1)] bool confidential, ref IntPtr aOutToken, ref uint aOutTokenLength);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void Unwrap(IntPtr aInToken, uint aInTokenLength, ref IntPtr aOutToken, ref uint aOutTokenLength);
}
