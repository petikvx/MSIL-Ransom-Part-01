using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[Guid("5ab02a98-5122-4b90-93cd-f259c4b42e3a")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public interface nsISyncJPAKE
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	void Round1([MarshalAs(UnmanagedType.LPStruct)] nsACStringBase aSignerID, [MarshalAs(UnmanagedType.LPStruct)] nsACStringBase aGX1, [MarshalAs(UnmanagedType.LPStruct)] nsACStringBase aGV1, [MarshalAs(UnmanagedType.LPStruct)] nsACStringBase aR1, [MarshalAs(UnmanagedType.LPStruct)] nsACStringBase aGX2, [MarshalAs(UnmanagedType.LPStruct)] nsACStringBase aGV2, [MarshalAs(UnmanagedType.LPStruct)] nsACStringBase aR2);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void Round2([MarshalAs(UnmanagedType.LPStruct)] nsACStringBase aPeerID, [MarshalAs(UnmanagedType.LPStruct)] nsACStringBase aPIN, [MarshalAs(UnmanagedType.LPStruct)] nsACStringBase aGX3, [MarshalAs(UnmanagedType.LPStruct)] nsACStringBase aGV3, [MarshalAs(UnmanagedType.LPStruct)] nsACStringBase aR3, [MarshalAs(UnmanagedType.LPStruct)] nsACStringBase aGX4, [MarshalAs(UnmanagedType.LPStruct)] nsACStringBase aGV4, [MarshalAs(UnmanagedType.LPStruct)] nsACStringBase aR4, [MarshalAs(UnmanagedType.LPStruct)] nsACStringBase aA, [MarshalAs(UnmanagedType.LPStruct)] nsACStringBase aGVA, [MarshalAs(UnmanagedType.LPStruct)] nsACStringBase aRA);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void Final([MarshalAs(UnmanagedType.LPStruct)] nsACStringBase aB, [MarshalAs(UnmanagedType.LPStruct)] nsACStringBase aGVB, [MarshalAs(UnmanagedType.LPStruct)] nsACStringBase aRB, [MarshalAs(UnmanagedType.LPStruct)] nsACStringBase aHkdfInfo, [MarshalAs(UnmanagedType.LPStruct)] nsACStringBase aAES256Key, [MarshalAs(UnmanagedType.LPStruct)] nsACStringBase aHMAC256Key);
}
