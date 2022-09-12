using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("fa9ba95b-ca3b-498a-b889-7c79cf28fee8")]
public interface nsISSLStatus
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIX509Cert GetServerCertAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetCipherNameAttribute([MarshalAs(UnmanagedType.LPStruct)] nsACStringBase aCipherName);

	[MethodImpl(MethodImplOptions.InternalCall)]
	uint GetKeyLengthAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	uint GetSecretKeyLengthAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	ushort GetProtocolVersionAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool GetIsDomainMismatchAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool GetIsNotValidAtThisTimeAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool GetIsUntrustedAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool GetIsExtendedValidationAttribute();
}
