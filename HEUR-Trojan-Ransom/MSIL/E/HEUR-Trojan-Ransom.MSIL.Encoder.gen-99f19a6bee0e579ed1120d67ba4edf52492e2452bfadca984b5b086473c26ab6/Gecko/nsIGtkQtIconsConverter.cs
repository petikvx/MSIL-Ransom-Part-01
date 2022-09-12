using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("c0783c34-a831-40c6-8c03-98c9f74cca45")]
public interface nsIGtkQtIconsConverter
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	int Convert([MarshalAs(UnmanagedType.LPStr)] string icon);
}
