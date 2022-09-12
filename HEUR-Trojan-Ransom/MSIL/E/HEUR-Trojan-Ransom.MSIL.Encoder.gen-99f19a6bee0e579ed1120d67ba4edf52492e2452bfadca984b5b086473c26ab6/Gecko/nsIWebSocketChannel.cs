using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("ce71d028-322a-4105-a947-a894689b52bf")]
public interface nsIWebSocketChannel
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIURI GetOriginalURIAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIURI GetURIAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIInterfaceRequestor GetNotificationCallbacksAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetNotificationCallbacksAttribute([MarshalAs(UnmanagedType.Interface)] nsIInterfaceRequestor aNotificationCallbacks);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsISupports GetSecurityInfoAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsILoadGroup GetLoadGroupAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetLoadGroupAttribute([MarshalAs(UnmanagedType.Interface)] nsILoadGroup aLoadGroup);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsILoadInfo GetLoadInfoAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetLoadInfoAttribute([MarshalAs(UnmanagedType.Interface)] nsILoadInfo aLoadInfo);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetProtocolAttribute([MarshalAs(UnmanagedType.LPStruct)] nsACStringBase aProtocol);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetProtocolAttribute([MarshalAs(UnmanagedType.LPStruct)] nsACStringBase aProtocol);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetExtensionsAttribute([MarshalAs(UnmanagedType.LPStruct)] nsACStringBase aExtensions);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void InitLoadInfo([MarshalAs(UnmanagedType.Interface)] nsIDOMNode aLoadingNode, [MarshalAs(UnmanagedType.Interface)] nsIPrincipal aLoadingPrincipal, [MarshalAs(UnmanagedType.Interface)] nsIPrincipal aTriggeringPrincipal, uint aSecurityFlags, uint aContentPolicyType);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void AsyncOpen([MarshalAs(UnmanagedType.Interface)] nsIURI aURI, [MarshalAs(UnmanagedType.LPStruct)] nsACStringBase aOrigin, ulong aInnerWindowID, [MarshalAs(UnmanagedType.Interface)] nsIWebSocketListener aListener, [MarshalAs(UnmanagedType.Interface)] nsISupports aContext);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void Close(ushort aCode, [MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase aReason);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SendMsg([MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase aMsg);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SendBinaryMsg([MarshalAs(UnmanagedType.LPStruct)] nsACStringBase aMsg);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SendBinaryStream([MarshalAs(UnmanagedType.Interface)] nsIInputStream aStream, uint length);

	[MethodImpl(MethodImplOptions.InternalCall)]
	uint GetPingIntervalAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetPingIntervalAttribute(uint aPingInterval);

	[MethodImpl(MethodImplOptions.InternalCall)]
	uint GetPingTimeoutAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetPingTimeoutAttribute(uint aPingTimeout);

	[MethodImpl(MethodImplOptions.InternalCall)]
	uint GetSerialAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetSerialAttribute(uint aSerial);
}
