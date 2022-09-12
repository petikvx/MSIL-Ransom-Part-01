using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[Guid("DE8DB85F-C1DE-4d87-94BA-7844890F91FE")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public interface nsIAutoCompleteSearch
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	void StartSearch([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase searchString, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase searchParam, [MarshalAs(UnmanagedType.Interface)] nsIAutoCompleteResult previousResult, [MarshalAs(UnmanagedType.Interface)] nsIAutoCompleteObserver listener);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void StopSearch();
}
