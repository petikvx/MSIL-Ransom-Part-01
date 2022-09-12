using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("CBFDF766-D002-403B-A3D9-B091C9AD465B")]
public interface nsITaskbarPreview
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsITaskbarPreviewController GetControllerAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetControllerAttribute([MarshalAs(UnmanagedType.Interface)] nsITaskbarPreviewController aController);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetTooltipAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aTooltip);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetTooltipAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aTooltip);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool GetVisibleAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetVisibleAttribute([MarshalAs(UnmanagedType.U1)] bool aVisible);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool GetActiveAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetActiveAttribute([MarshalAs(UnmanagedType.U1)] bool aActive);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void Invalidate();
}
