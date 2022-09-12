using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[Guid("876A2015-6B66-11D7-8F18-0003938A9D96")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public interface nsIClipboardDragDropHookList
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	void AddClipboardDragDropHooks([MarshalAs(UnmanagedType.Interface)] nsIClipboardDragDropHooks aHooks);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void RemoveClipboardDragDropHooks([MarshalAs(UnmanagedType.Interface)] nsIClipboardDragDropHooks aHooks);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsISimpleEnumerator GetHookEnumerator();
}
