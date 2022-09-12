using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[Guid("bfd9b82b-0ab3-4b6b-9e54-aa961ff4b732")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public interface nsIFormAutoComplete
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	void AutoCompleteSearchAsync([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aInputName, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aSearchString, [MarshalAs(UnmanagedType.Interface)] nsIDOMHTMLInputElement aField, [MarshalAs(UnmanagedType.Interface)] nsIAutoCompleteResult aPreviousResult, [MarshalAs(UnmanagedType.Interface)] nsIAutoCompleteResult aDatalistResult, [MarshalAs(UnmanagedType.Interface)] nsIFormAutoCompleteObserver aListener);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void StopAutoCompleteSearch();
}
