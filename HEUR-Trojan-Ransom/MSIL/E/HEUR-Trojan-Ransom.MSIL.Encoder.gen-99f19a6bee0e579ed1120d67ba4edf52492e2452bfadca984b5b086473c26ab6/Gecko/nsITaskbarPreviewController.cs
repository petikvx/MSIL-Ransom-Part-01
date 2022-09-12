using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[Guid("4FC0AFBB-3E22-4FBA-AC21-953350AF0411")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public interface nsITaskbarPreviewController
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	uint GetWidthAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	uint GetHeightAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	float GetThumbnailAspectRatioAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool DrawPreview([MarshalAs(UnmanagedType.Interface)] nsISupports ctx);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool DrawThumbnail([MarshalAs(UnmanagedType.Interface)] nsISupports ctx, uint width, uint height);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void OnClose();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool OnActivate();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void OnClick([MarshalAs(UnmanagedType.Interface)] nsITaskbarPreviewButton button);
}
