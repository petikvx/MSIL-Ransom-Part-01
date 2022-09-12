using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("0e33de3e-4faf-4a1a-b96e-24115b8bfd45")]
public interface nsIInputListAutoComplete
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIAutoCompleteResult AutoCompleteSearch([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aSearchString, [MarshalAs(UnmanagedType.Interface)] nsIDOMHTMLInputElement aField);
}
