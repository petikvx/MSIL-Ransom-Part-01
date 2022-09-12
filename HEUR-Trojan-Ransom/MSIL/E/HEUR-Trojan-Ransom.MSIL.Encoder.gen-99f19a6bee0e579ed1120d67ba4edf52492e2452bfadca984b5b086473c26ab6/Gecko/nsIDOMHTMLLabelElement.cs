using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("efc0eaf2-5756-4388-a229-fbec2033529d")]
public interface nsIDOMHTMLLabelElement
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIDOMHTMLFormElement GetFormAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetHtmlForAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aHtmlFor);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetHtmlForAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aHtmlFor);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIDOMHTMLElement GetControlAttribute();
}
