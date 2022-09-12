using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[Guid("5BEC321F-59AC-413a-A4AD-8A8D7C50A0D0")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public interface nsITextServicesFilter
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool Skip([MarshalAs(UnmanagedType.Interface)] nsIDOMNode aNode);
}
