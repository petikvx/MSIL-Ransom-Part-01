using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("2F276982-0D60-4377-A595-D350BA516395")]
public interface nsIWindowMediatorListener
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	void OnWindowTitleChange([MarshalAs(UnmanagedType.Interface)] nsIXULWindow window, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.WStringMarshaler")] string newTitle);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void OnOpenWindow([MarshalAs(UnmanagedType.Interface)] nsIXULWindow window);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void OnCloseWindow([MarshalAs(UnmanagedType.Interface)] nsIXULWindow window);
}
