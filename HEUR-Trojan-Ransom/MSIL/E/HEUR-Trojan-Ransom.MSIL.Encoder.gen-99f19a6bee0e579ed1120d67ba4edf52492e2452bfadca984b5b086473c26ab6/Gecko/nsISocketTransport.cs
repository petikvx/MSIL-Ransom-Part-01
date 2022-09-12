using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("79221831-85e2-43a8-8152-05d77d6fde31")]
public interface nsISocketTransport : nsITransport
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	new nsIInputStream OpenInputStream(uint aFlags, uint aSegmentSize, uint aSegmentCount);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	new nsIOutputStream OpenOutputStream(uint aFlags, uint aSegmentSize, uint aSegmentCount);

	[MethodImpl(MethodImplOptions.InternalCall)]
	new void Close(int aReason);

	[MethodImpl(MethodImplOptions.InternalCall)]
	new void SetEventSink([MarshalAs(UnmanagedType.Interface)] nsITransportEventSink aSink, [MarshalAs(UnmanagedType.Interface)] nsIEventTarget aEventTarget);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetHostAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase aHost);

	[MethodImpl(MethodImplOptions.InternalCall)]
	int GetPortAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetNetworkInterfaceIdAttribute([MarshalAs(UnmanagedType.LPStruct)] nsACStringBase aNetworkInterfaceId);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetNetworkInterfaceIdAttribute([MarshalAs(UnmanagedType.LPStruct)] nsACStringBase aNetworkInterfaceId);

	[MethodImpl(MethodImplOptions.InternalCall)]
	IntPtr GetPeerAddr();

	[MethodImpl(MethodImplOptions.InternalCall)]
	IntPtr GetSelfAddr();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void Bind(IntPtr aLocalAddr);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsINetAddr GetScriptablePeerAddr();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsINetAddr GetScriptableSelfAddr();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsISupports GetSecurityInfoAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIInterfaceRequestor GetSecurityCallbacksAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetSecurityCallbacksAttribute([MarshalAs(UnmanagedType.Interface)] nsIInterfaceRequestor aSecurityCallbacks);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool IsAlive();

	[MethodImpl(MethodImplOptions.InternalCall)]
	uint GetTimeout(uint aType);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetTimeout(uint aType, uint aValue);

	[MethodImpl(MethodImplOptions.InternalCall)]
	uint GetConnectionFlagsAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetConnectionFlagsAttribute(uint aConnectionFlags);

	[MethodImpl(MethodImplOptions.InternalCall)]
	IntPtr GetQoSBitsAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetQoSBitsAttribute(IntPtr aQoSBits);

	[MethodImpl(MethodImplOptions.InternalCall)]
	uint GetRecvBufferSizeAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetRecvBufferSizeAttribute(uint aRecvBufferSize);

	[MethodImpl(MethodImplOptions.InternalCall)]
	uint GetSendBufferSizeAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetSendBufferSizeAttribute(uint aSendBufferSize);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool GetKeepaliveEnabledAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetKeepaliveEnabledAttribute([MarshalAs(UnmanagedType.U1)] bool aKeepaliveEnabled);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetKeepaliveVals(int keepaliveIdleTime, int keepaliveRetryInterval);
}
