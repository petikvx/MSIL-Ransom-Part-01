using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[Guid("ea2ce7a0-5c3d-11d4-90c2-0050041caf44")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public interface nsIContentViewerContainer
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	void Embed([MarshalAs(UnmanagedType.Interface)] nsIContentViewer aDocViewer, [MarshalAs(UnmanagedType.LPStr)] string aCommand, [MarshalAs(UnmanagedType.Interface)] nsISupports aExtraInfo);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetIsPrinting([MarshalAs(UnmanagedType.U1)] bool aIsPrinting);
}
