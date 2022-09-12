using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("6758d0d7-e96a-4c5c-bca8-3bcbe5a15943")]
public interface nsIJSInspector
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	uint EnterNestedEventLoop(ref JsVal requestor);

	[MethodImpl(MethodImplOptions.InternalCall)]
	uint ExitNestedEventLoop();

	[MethodImpl(MethodImplOptions.InternalCall)]
	uint GetEventLoopNestLevelAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	JsVal GetLastNestRequestorAttribute();
}
