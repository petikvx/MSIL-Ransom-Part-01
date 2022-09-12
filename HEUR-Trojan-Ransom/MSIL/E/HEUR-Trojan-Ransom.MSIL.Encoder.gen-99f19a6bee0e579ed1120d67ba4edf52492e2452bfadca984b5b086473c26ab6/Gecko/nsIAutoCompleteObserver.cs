using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("8bd1dbbc-dcce-4007-9afa-b551eb687b61")]
public interface nsIAutoCompleteObserver
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	void OnSearchResult([MarshalAs(UnmanagedType.Interface)] nsIAutoCompleteSearch search, [MarshalAs(UnmanagedType.Interface)] nsIAutoCompleteResult result);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void OnUpdateSearchResult([MarshalAs(UnmanagedType.Interface)] nsIAutoCompleteSearch search, [MarshalAs(UnmanagedType.Interface)] nsIAutoCompleteResult result);
}
