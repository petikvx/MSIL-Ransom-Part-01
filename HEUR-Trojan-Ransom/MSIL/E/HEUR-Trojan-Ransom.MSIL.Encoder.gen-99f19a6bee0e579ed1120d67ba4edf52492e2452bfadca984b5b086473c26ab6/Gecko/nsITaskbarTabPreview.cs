using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[Guid("11E4C8BD-5C2D-4E1A-A9A1-79DD5B0FE544")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public interface nsITaskbarTabPreview : nsITaskbarPreview
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
	void GetTitleAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aTitle);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetTitleAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aTitle);

	[MethodImpl(MethodImplOptions.InternalCall)]
	imgIContainer GetIconAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetIconAttribute(imgIContainer aIcon);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void Move([MarshalAs(UnmanagedType.Interface)] nsITaskbarTabPreview aNext);

	[MethodImpl(MethodImplOptions.InternalCall)]
	IntPtr GetHWND();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void EnsureRegistration();
}
