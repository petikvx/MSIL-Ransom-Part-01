using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[Guid("4fefb490-5567-11e5-a837-0800200c9a66")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public interface nsIMultiPartChannel
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIChannel GetBaseChannelAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	uint GetPartIDAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool GetIsLastPartAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetPreambleAttribute([MarshalAs(UnmanagedType.LPStruct)] nsACStringBase aPreamble);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetOriginalResponseHeaderAttribute([MarshalAs(UnmanagedType.LPStruct)] nsACStringBase aOriginalResponseHeader);
}
