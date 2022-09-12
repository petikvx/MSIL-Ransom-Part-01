using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("75767928-ecb1-4e6c-9f55-c118b297fcef")]
public interface xpcIJSWeakReference
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	JsVal Get(IntPtr jsContext);
}
