using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[Guid("CED8842D-FE37-4767-9A8E-FDFA56510C75")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public interface nsITaskbarPreviewButton
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetTooltipAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aTooltip);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetTooltipAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aTooltip);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool GetDismissOnClickAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetDismissOnClickAttribute([MarshalAs(UnmanagedType.U1)] bool aDismissOnClick);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool GetHasBorderAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetHasBorderAttribute([MarshalAs(UnmanagedType.U1)] bool aHasBorder);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool GetDisabledAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetDisabledAttribute([MarshalAs(UnmanagedType.U1)] bool aDisabled);

	[MethodImpl(MethodImplOptions.InternalCall)]
	imgIContainer GetImageAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetImageAttribute(imgIContainer aImage);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool GetVisibleAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetVisibleAttribute([MarshalAs(UnmanagedType.U1)] bool aVisible);
}
