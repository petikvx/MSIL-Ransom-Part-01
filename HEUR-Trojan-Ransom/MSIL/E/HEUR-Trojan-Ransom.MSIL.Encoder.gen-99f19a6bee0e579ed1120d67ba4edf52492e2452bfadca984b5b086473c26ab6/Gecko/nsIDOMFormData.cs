using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("256c9139-5a29-41e1-8698-f9f9aae7d6cf")]
public interface nsIDOMFormData
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	void Append([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase name, [MarshalAs(UnmanagedType.Interface)] nsIVariant value);
}
