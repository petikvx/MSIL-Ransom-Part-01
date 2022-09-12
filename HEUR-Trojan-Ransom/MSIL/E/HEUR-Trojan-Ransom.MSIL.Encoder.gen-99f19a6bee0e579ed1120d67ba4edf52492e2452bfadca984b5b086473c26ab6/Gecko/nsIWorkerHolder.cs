using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[Guid("c04f3102-1ce8-4d57-9c27-8aece9c2740a")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public interface nsIWorkerHolder
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	JsVal GetWorkerAttribute();
}
