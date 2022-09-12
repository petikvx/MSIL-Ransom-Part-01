using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[Guid("694abb80-1187-11e4-9191-0800200c9a66")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public interface nsIDhcpRequestCallback
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	void DhcpRequestResult([MarshalAs(UnmanagedType.U1)] bool success, ref JsVal dhcpInfo);
}
