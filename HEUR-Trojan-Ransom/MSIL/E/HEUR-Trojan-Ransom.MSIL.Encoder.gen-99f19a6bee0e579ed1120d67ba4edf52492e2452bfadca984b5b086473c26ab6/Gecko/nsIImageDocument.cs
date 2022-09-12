using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("87c27f98-37dc-4b64-a8cd-92003624bcee")]
public interface nsIImageDocument
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool GetImageResizingEnabledAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool GetImageIsOverflowingAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool GetImageIsResizedAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	imgIRequest GetImageRequestAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void ShrinkToFit();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void RestoreImage();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void RestoreImageTo(int x, int y);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void ToggleImageSize();
}
