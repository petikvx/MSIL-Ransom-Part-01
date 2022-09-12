using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("a36fa816-31da-4b23-bc97-6412771f0867")]
public interface IJSDebugger
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	void AddClass(ref JsVal global, IntPtr jsContext);
}
