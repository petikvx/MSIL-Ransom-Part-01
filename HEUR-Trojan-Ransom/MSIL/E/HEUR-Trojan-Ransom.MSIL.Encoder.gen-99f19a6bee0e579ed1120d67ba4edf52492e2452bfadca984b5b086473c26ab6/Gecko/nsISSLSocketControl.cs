using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("418265c8-654e-4fbb-ba62-4eed27de1f03")]
public interface nsISSLSocketControl
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIInterfaceRequestor GetNotificationCallbacksAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetNotificationCallbacksAttribute([MarshalAs(UnmanagedType.Interface)] nsIInterfaceRequestor aNotificationCallbacks);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void ProxyStartSSL();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void StartTLS();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetNPNList(IntPtr aNPNList);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetNegotiatedNPNAttribute([MarshalAs(UnmanagedType.LPStruct)] nsACStringBase aNegotiatedNPN);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool JoinConnection([MarshalAs(UnmanagedType.LPStruct)] nsACStringBase npnProtocol, [MarshalAs(UnmanagedType.LPStruct)] nsACStringBase hostname, int port);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool IsAcceptableForHost([MarshalAs(UnmanagedType.LPStruct)] nsACStringBase hostname);

	[MethodImpl(MethodImplOptions.InternalCall)]
	short GetKEAUsedAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	uint GetKEAKeyBitsAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	uint GetProviderFlagsAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	short GetSSLVersionUsedAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	short GetSSLVersionOfferedAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	short GetMACAlgorithmUsedAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIX509Cert GetClientCertAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetClientCertAttribute([MarshalAs(UnmanagedType.Interface)] nsIX509Cert aClientCert);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool GetBypassAuthenticationAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool GetFailedVerificationAttribute();
}
