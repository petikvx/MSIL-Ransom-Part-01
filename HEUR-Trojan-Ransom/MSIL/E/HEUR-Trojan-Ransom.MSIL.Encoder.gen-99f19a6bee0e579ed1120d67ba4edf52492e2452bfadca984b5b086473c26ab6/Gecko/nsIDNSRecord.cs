using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[Guid("f92228ae-c417-4188-a604-0830a95e7eb9")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public interface nsIDNSRecord
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetCanonicalNameAttribute([MarshalAs(UnmanagedType.LPStruct)] nsACStringBase aCanonicalName);

	[MethodImpl(MethodImplOptions.InternalCall)]
	IntPtr GetNextAddr(ushort aPort);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetAddresses(ref IntPtr aAddressArray);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsINetAddr GetScriptableNextAddr(ushort aPort);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetNextAddrAsString([MarshalAs(UnmanagedType.LPStruct)] nsACStringBase retval);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool HasMore();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void Rewind();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void ReportUnusable(ushort aPort);
}
