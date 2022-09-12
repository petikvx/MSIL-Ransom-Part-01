using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[Guid("21035ee0-4556-11d3-91cd-00105aa3f7dc")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public interface nsILocale
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetCategory([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase category, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase retval);
}
