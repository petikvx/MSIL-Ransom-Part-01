using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("85cd2640-e91e-41ac-bdca-1dbf10dc131e")]
public interface nsIRedirectResultListener
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	void OnRedirectResult([MarshalAs(UnmanagedType.U1)] bool proceeding);
}
