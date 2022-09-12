using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[Guid("bb929ae3-4a42-4a63-8388-97c4de69200e")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public interface nsINetworkService
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetWifiTethering([MarshalAs(UnmanagedType.U1)] bool enabled, ref JsVal config, [MarshalAs(UnmanagedType.Interface)] nsIWifiTetheringCallback callback);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetDhcpServer([MarshalAs(UnmanagedType.U1)] bool enabled, ref JsVal config, [MarshalAs(UnmanagedType.Interface)] nsISetDhcpServerCallback callback);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetNetworkInterfaceStats([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase networkName, [MarshalAs(UnmanagedType.Interface)] nsINetworkStatsCallback callback);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool SetNetworkInterfaceAlarm([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase networkName, long threshold, [MarshalAs(UnmanagedType.Interface)] nsINetworkUsageAlarmCallback callback);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetWifiOperationMode([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase interfaceName, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase mode, [MarshalAs(UnmanagedType.Interface)] nsIWifiOperationModeCallback callback);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetUSBTethering([MarshalAs(UnmanagedType.U1)] bool enabled, ref JsVal config, [MarshalAs(UnmanagedType.Interface)] nsIUsbTetheringCallback callback);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void ResetRoutingTable([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase interfaceName, [MarshalAs(UnmanagedType.Interface)] nsINativeCommandCallback callback);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetDNS([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase interfaceName, uint dnsesCount, [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 1)] IntPtr[] dnses, uint gatewaysCount, [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 3)] IntPtr[] gateways, [MarshalAs(UnmanagedType.Interface)] nsISetDnsCallback callback);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetDefaultRoute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase interfaceName, uint count, [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 1)] IntPtr[] gateways, [MarshalAs(UnmanagedType.Interface)] nsINativeCommandCallback callback);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void RemoveDefaultRoute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase interfaceName, uint count, [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 1)] IntPtr[] gateways, [MarshalAs(UnmanagedType.Interface)] nsINativeCommandCallback callback);

	[MethodImpl(MethodImplOptions.InternalCall)]
	JsVal ModifyRoute(int action, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase interfaceName, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase host, int prefixLength, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase gateway);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void AddSecondaryRoute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase interfaceName, ref JsVal route, [MarshalAs(UnmanagedType.Interface)] nsINativeCommandCallback callback);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void RemoveSecondaryRoute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase interfaceName, ref JsVal route, [MarshalAs(UnmanagedType.Interface)] nsINativeCommandCallback callback);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void EnableUsbRndis([MarshalAs(UnmanagedType.U1)] bool enable, [MarshalAs(UnmanagedType.Interface)] nsIEnableUsbRndisCallback callback);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void UpdateUpStream(ref JsVal previous, ref JsVal current, [MarshalAs(UnmanagedType.Interface)] nsIUpdateUpStreamCallback callback);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void ConfigureInterface(ref JsVal config, [MarshalAs(UnmanagedType.Interface)] nsINativeCommandCallback callback);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void DhcpRequest([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase interfaceName, [MarshalAs(UnmanagedType.Interface)] nsIDhcpRequestCallback callback);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void StopDhcp([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase ifname, [MarshalAs(UnmanagedType.Interface)] nsINativeCommandCallback callback);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void EnableInterface([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase interfaceName, [MarshalAs(UnmanagedType.Interface)] nsINativeCommandCallback callback);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void DisableInterface([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase interfaceName, [MarshalAs(UnmanagedType.Interface)] nsINativeCommandCallback callback);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void ResetConnections([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase interfaceName, [MarshalAs(UnmanagedType.Interface)] nsINativeCommandCallback callback);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void CreateNetwork([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase interfaceName, [MarshalAs(UnmanagedType.Interface)] nsINativeCommandCallback callback);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void DestroyNetwork([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase interfaceName, [MarshalAs(UnmanagedType.Interface)] nsINativeCommandCallback callback);

	[MethodImpl(MethodImplOptions.InternalCall)]
	JsVal GetNetId([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase interfaceName);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetMtu([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase interfaceName, int mtu, [MarshalAs(UnmanagedType.Interface)] nsINativeCommandCallback callback);
}
