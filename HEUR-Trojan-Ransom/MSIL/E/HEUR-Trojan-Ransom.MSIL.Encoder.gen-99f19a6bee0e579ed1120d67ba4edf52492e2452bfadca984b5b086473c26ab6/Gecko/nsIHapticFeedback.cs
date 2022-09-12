using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("91917c98-a8f3-4c98-8f10-4afb872f54c7")]
public interface nsIHapticFeedback
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	void PerformSimpleAction(int isLongPress);
}
