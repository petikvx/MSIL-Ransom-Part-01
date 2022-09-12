using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[Guid("701093ac-5c7f-429c-99e3-423b041fccb4")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public interface nsIHttpAuthenticableChannel : nsIProxiedChannel
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	new nsIProxyInfo GetProxyInfoAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool GetIsSSLAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool GetProxyMethodIsConnectAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void Cancel(int aStatus);

	[MethodImpl(MethodImplOptions.InternalCall)]
	uint GetLoadFlagsAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIURI GetURIAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsILoadGroup GetLoadGroupAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIInterfaceRequestor GetNotificationCallbacksAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetRequestMethodAttribute([MarshalAs(UnmanagedType.LPStruct)] nsACStringBase aRequestMethod);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetServerResponseHeaderAttribute([MarshalAs(UnmanagedType.LPStruct)] nsACStringBase aServerResponseHeader);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetProxyChallengesAttribute([MarshalAs(UnmanagedType.LPStruct)] nsACStringBase aProxyChallenges);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetWWWChallengesAttribute([MarshalAs(UnmanagedType.LPStruct)] nsACStringBase aWWWChallenges);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetProxyCredentials([MarshalAs(UnmanagedType.LPStruct)] nsACStringBase credentials);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetWWWCredentials([MarshalAs(UnmanagedType.LPStruct)] nsACStringBase credentials);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void OnAuthAvailable();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void OnAuthCancelled([MarshalAs(UnmanagedType.U1)] bool userCancel);
}
