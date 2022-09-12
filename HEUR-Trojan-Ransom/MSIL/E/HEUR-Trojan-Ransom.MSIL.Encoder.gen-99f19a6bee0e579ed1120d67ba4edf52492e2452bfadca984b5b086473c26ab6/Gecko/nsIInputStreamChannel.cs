using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[Guid("ea730238-4bfd-4015-8489-8f264d05b343")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public interface nsIInputStreamChannel
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetURI([MarshalAs(UnmanagedType.Interface)] nsIURI aURI);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIInputStream GetContentStreamAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetContentStreamAttribute([MarshalAs(UnmanagedType.Interface)] nsIInputStream aContentStream);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetSrcdocDataAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aSrcdocData);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetSrcdocDataAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aSrcdocData);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool GetIsSrcdocChannelAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIURI GetBaseURIAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetBaseURIAttribute([MarshalAs(UnmanagedType.Interface)] nsIURI aBaseURI);
}
