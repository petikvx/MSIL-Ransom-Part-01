using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[Guid("125c0833-746a-400e-9b89-d2d18545c08a")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public interface nsISHistoryListener
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	void OnHistoryNewEntry([MarshalAs(UnmanagedType.Interface)] nsIURI aNewURI);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool OnHistoryGoBack([MarshalAs(UnmanagedType.Interface)] nsIURI aBackURI);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool OnHistoryGoForward([MarshalAs(UnmanagedType.Interface)] nsIURI aForwardURI);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool OnHistoryReload([MarshalAs(UnmanagedType.Interface)] nsIURI aReloadURI, uint aReloadFlags);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool OnHistoryGotoIndex(int aIndex, [MarshalAs(UnmanagedType.Interface)] nsIURI aGotoURI);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool OnHistoryPurge(int aNumEntries);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void OnHistoryReplaceEntry(int aIndex);
}
