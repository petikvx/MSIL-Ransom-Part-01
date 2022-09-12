using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("93F4A48F-D043-4F45-97FD-9771EA1AF976")]
public interface nsIMenuBuilder
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	void OpenContainer([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aLabel);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void AddItemFor([MarshalAs(UnmanagedType.Interface)] nsIDOMHTMLMenuItemElement aElement, [MarshalAs(UnmanagedType.U1)] bool aCanLoadIcon);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void AddSeparator();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void UndoAddSeparator();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void CloseContainer();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void ToJSONString([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase retval);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void Click([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aGeneratedItemId);
}
