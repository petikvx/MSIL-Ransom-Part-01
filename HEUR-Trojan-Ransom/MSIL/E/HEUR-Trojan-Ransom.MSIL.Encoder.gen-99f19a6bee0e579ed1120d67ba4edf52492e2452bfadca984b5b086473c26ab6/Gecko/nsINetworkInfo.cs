using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[Guid("f439ab5d-64bd-4a6c-8863-30235fa784d2")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public interface nsINetworkInfo
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	int GetStateAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	int GetTypeAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetNameAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aName);

	[MethodImpl(MethodImplOptions.InternalCall)]
	uint GetAddresses([MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 2)] ref IntPtr[] ips, [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 2)] ref uint[] prefixLengths);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetGateways(ref uint count, [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 0)] ref IntPtr[] gateways);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetDnses(ref uint count, [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 0)] ref IntPtr[] dnses);
}
