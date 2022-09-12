using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("91375f52-20e6-4757-9835-eb04fabe5498")]
public interface nsIHTMLAbsPosEditor
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool GetSelectionContainerAbsolutelyPositionedAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIDOMElement GetPositionedElementAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool GetAbsolutePositioningEnabledAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetAbsolutePositioningEnabledAttribute([MarshalAs(UnmanagedType.U1)] bool aAbsolutePositioningEnabled);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool GetSnapToGridEnabledAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetSnapToGridEnabledAttribute([MarshalAs(UnmanagedType.U1)] bool aSnapToGridEnabled);

	[MethodImpl(MethodImplOptions.InternalCall)]
	uint GetGridSizeAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetGridSizeAttribute(uint aGridSize);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIDOMElement GetAbsolutelyPositionedSelectionContainerAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void AbsolutePositionSelection([MarshalAs(UnmanagedType.U1)] bool aEnabled);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void RelativeChangeZIndex(int aChange);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void AbsolutelyPositionElement([MarshalAs(UnmanagedType.Interface)] nsIDOMElement aElement, [MarshalAs(UnmanagedType.U1)] bool aEnabled);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetElementPosition([MarshalAs(UnmanagedType.Interface)] nsIDOMElement aElement, int aX, int aY);

	[MethodImpl(MethodImplOptions.InternalCall)]
	int GetElementZIndex([MarshalAs(UnmanagedType.Interface)] nsIDOMElement aElement);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetElementZIndex([MarshalAs(UnmanagedType.Interface)] nsIDOMElement aElement, int aZorder);

	[MethodImpl(MethodImplOptions.InternalCall)]
	int RelativeChangeElementZIndex([MarshalAs(UnmanagedType.Interface)] nsIDOMElement aElement, int aChange);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void ShowGrabberOnElement([MarshalAs(UnmanagedType.Interface)] nsIDOMElement aElement);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void HideGrabber();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void RefreshGrabber();
}
