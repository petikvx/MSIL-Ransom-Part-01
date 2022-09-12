using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("0b976267-4aaa-4f36-a2d4-27b5ca8d73bb")]
public interface nsIEmbeddingSiteWindow
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetDimensions(uint flags, int x, int y, int cx, int cy);

	[MethodImpl(MethodImplOptions.InternalCall)]
	unsafe void GetDimensions(uint flags, int* x, int* y, int* cx, int* cy);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetFocus();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool GetVisibilityAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetVisibilityAttribute([MarshalAs(UnmanagedType.U1)] bool aVisibility);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.WStringMarshaler")]
	string GetTitleAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetTitleAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.WStringMarshaler")] string aTitle);

	[MethodImpl(MethodImplOptions.InternalCall)]
	IntPtr GetSiteWindowAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void Blur();
}
