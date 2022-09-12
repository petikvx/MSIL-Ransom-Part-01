using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[Guid("96fc4671-eeb4-4823-9421-e50fb70ad353")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public interface nsIWritablePropertyBag : nsIPropertyBag
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	new nsISimpleEnumerator GetEnumeratorAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	new nsIVariant GetProperty([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase name);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetProperty([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase name, [MarshalAs(UnmanagedType.Interface)] nsIVariant value);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void DeleteProperty([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase name);
}
