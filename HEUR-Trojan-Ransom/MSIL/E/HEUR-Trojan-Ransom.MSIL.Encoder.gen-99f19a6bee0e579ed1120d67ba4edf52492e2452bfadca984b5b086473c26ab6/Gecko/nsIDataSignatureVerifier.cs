using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[Guid("94066a00-37c9-11e4-916c-0800200c9a66")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public interface nsIDataSignatureVerifier
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool VerifyData([MarshalAs(UnmanagedType.LPStruct)] nsACStringBase aData, [MarshalAs(UnmanagedType.LPStruct)] nsACStringBase aSignature, [MarshalAs(UnmanagedType.LPStruct)] nsACStringBase aPublicKey);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIX509Cert VerifySignature([MarshalAs(UnmanagedType.LPStr)] string aSignature, uint aSignatureLen, [MarshalAs(UnmanagedType.LPStr)] string plaintext, uint plaintextLen, ref int errorCode);
}
