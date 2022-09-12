using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[Guid("03da5641-a333-454a-a859-036d0bb683b7")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public interface imgINotificationObserver
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	void Notify(imgIRequest aProxy, int aType, [MarshalAs(UnmanagedType.Interface)] nsIntRect aRect);
}
