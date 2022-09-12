using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[Guid("e02b6693-6cca-11da-be43-001422106990")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public interface nsISAXErrorHandler
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	void Error([MarshalAs(UnmanagedType.Interface)] nsISAXLocator locator, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase error);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void FatalError([MarshalAs(UnmanagedType.Interface)] nsISAXLocator locator, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase error);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void IgnorableWarning([MarshalAs(UnmanagedType.Interface)] nsISAXLocator locator, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase error);
}
