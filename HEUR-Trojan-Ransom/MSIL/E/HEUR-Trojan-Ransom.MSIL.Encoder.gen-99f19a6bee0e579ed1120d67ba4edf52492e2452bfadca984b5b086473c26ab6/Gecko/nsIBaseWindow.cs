using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[Guid("9DA319F3-EEE6-4504-81A5-6A19CF6215BF")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public interface nsIBaseWindow
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	void InitWindow(IntPtr parentNativeWindow, IntPtr parentWidget, int x, int y, int cx, int cy);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void Create();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void Destroy();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetPosition(int x, int y);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetPosition(ref int x, ref int y);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetSize(int cx, int cy, [MarshalAs(UnmanagedType.U1)] bool fRepaint);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetSize(ref int cx, ref int cy);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetPositionAndSize(int x, int y, int cx, int cy, [MarshalAs(UnmanagedType.U1)] bool fRepaint);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetPositionAndSize(ref int x, ref int y, ref int cx, ref int cy);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void Repaint([MarshalAs(UnmanagedType.U1)] bool force);

	[MethodImpl(MethodImplOptions.InternalCall)]
	IntPtr GetParentWidgetAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetParentWidgetAttribute(IntPtr aParentWidget);

	[MethodImpl(MethodImplOptions.InternalCall)]
	IntPtr GetParentNativeWindowAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetParentNativeWindowAttribute(IntPtr aParentNativeWindow);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetNativeHandleAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aNativeHandle);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool GetVisibilityAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetVisibilityAttribute([MarshalAs(UnmanagedType.U1)] bool aVisibility);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool GetEnabledAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetEnabledAttribute([MarshalAs(UnmanagedType.U1)] bool aEnabled);

	[MethodImpl(MethodImplOptions.InternalCall)]
	IntPtr GetMainWidgetAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	double GetUnscaledDevicePixelsPerCSSPixelAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetFocus();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.WStringMarshaler")]
	string GetTitleAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetTitleAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.WStringMarshaler")] string aTitle);
}
