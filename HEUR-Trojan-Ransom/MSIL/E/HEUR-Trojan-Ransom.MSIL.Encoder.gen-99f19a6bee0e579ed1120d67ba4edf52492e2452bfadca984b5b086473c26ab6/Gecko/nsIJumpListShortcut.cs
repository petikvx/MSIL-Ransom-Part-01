using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[Guid("CBE3A37C-BCE1-4fec-80A5-5FFBC7F33EEA")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public interface nsIJumpListShortcut : nsIJumpListItem
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	new short GetTypeAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	new bool Equals([MarshalAs(UnmanagedType.Interface)] nsIJumpListItem item);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsILocalHandlerApp GetAppAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetAppAttribute([MarshalAs(UnmanagedType.Interface)] nsILocalHandlerApp aApp);

	[MethodImpl(MethodImplOptions.InternalCall)]
	int GetIconIndexAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetIconIndexAttribute(int aIconIndex);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIURI GetFaviconPageUriAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetFaviconPageUriAttribute([MarshalAs(UnmanagedType.Interface)] nsIURI aFaviconPageUri);
}
