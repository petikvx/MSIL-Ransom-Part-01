using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("04971e14-d6b3-4ada-8cbb-c3a13842b349")]
public interface nsICollationFactory
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsICollation CreateCollation([MarshalAs(UnmanagedType.Interface)] nsILocale locale);
}
