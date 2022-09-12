using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("3503de34-6631-4594-b7be-c36ff6a520c4")]
public interface nsIDOMNSEditableElement
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIEditor GetEditorAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetUserInput([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase input);
}
