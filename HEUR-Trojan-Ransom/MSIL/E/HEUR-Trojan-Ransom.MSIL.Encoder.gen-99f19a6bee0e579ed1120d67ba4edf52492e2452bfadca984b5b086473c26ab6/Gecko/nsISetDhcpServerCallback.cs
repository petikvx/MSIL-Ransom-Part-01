using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[Guid("097878b0-19fc-11e3-8ffd-0800200c9a66")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public interface nsISetDhcpServerCallback
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	void DhcpServerResult(ref JsVal error);
}
