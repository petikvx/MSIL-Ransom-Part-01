using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[Guid("EC67CC57-342D-4064-B4C6-74A375E07B10")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public interface nsITaskbarWindowPreview : nsITaskbarPreview
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	new nsITaskbarPreviewController GetControllerAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	new void SetControllerAttribute([MarshalAs(UnmanagedType.Interface)] nsITaskbarPreviewController aController);

	[MethodImpl(MethodImplOptions.InternalCall)]
	new void GetTooltipAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aTooltip);

	[MethodImpl(MethodImplOptions.InternalCall)]
	new void SetTooltipAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aTooltip);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	new bool GetVisibleAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	new void SetVisibleAttribute([MarshalAs(UnmanagedType.U1)] bool aVisible);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	new bool GetActiveAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	new void SetActiveAttribute([MarshalAs(UnmanagedType.U1)] bool aActive);

	[MethodImpl(MethodImplOptions.InternalCall)]
	new void Invalidate();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsITaskbarPreviewButton GetButton(uint index);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool GetEnableCustomDrawingAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetEnableCustomDrawingAttribute([MarshalAs(UnmanagedType.U1)] bool aEnableCustomDrawing);
}
