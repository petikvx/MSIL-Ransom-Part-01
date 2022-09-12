using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[Guid("eedca6c0-1310-11e4-9191-0800200c9a66")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public interface nsISetDnsCallback
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetDnsResult(ref JsVal error);
}
