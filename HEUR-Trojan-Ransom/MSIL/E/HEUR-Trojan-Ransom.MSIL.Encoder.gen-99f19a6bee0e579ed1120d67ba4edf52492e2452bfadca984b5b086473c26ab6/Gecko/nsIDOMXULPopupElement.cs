using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("cb7eaa79-45d5-4ea3-ae17-b65fdcfe5e30")]
public interface nsIDOMXULPopupElement
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetPositionAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aPosition);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetPositionAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aPosition);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void ShowPopup(ushort alignment, [MarshalAs(UnmanagedType.Interface)] nsIDOMElement target, [MarshalAs(UnmanagedType.Interface)] nsIDOMElement anchor);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void HidePopup();
}
