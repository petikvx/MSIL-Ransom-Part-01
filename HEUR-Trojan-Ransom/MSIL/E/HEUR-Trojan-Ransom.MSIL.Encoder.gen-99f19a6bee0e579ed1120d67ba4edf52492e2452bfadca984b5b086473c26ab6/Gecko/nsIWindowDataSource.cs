using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("3722A5B9-5323-4ed0-BB1A-8299F27A4E89")]
public interface nsIWindowDataSource
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIDOMWindow GetWindowForResource([MarshalAs(UnmanagedType.LPStr)] string inResource);
}
