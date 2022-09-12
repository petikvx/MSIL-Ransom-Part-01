using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

[ComImport]
[DefaultMember("Handle")]
[InterfaceType(2)]
[TypeLibType(4096)]
[Guid("7BF80981-BF32-101A-8BBB-00AA00300CAB")]
[ComConversionLoss]
public interface Picture
{
	[DispId(0)]
	[ComAliasName("stdole.OLE_HANDLE")]
	int Handle
	{
		[MethodImpl(MethodImplOptions.InternalCall)]
		[DispId(0)]
		get;
	}

	[DispId(2)]
	[ComAliasName("stdole.OLE_HANDLE")]
	int hPal
	{
		[MethodImpl(MethodImplOptions.InternalCall)]
		[DispId(2)]
		get;
		[MethodImpl(MethodImplOptions.InternalCall)]
		[DispId(2)]
		set;
	}

	[DispId(3)]
	short Type
	{
		[MethodImpl(MethodImplOptions.InternalCall)]
		[DispId(3)]
		get;
	}

	[ComAliasName("stdole.OLE_XSIZE_HIMETRIC")]
	[DispId(4)]
	int Width
	{
		[MethodImpl(MethodImplOptions.InternalCall)]
		[DispId(4)]
		get;
	}

	[ComAliasName("stdole.OLE_YSIZE_HIMETRIC")]
	[DispId(5)]
	int Height
	{
		[MethodImpl(MethodImplOptions.InternalCall)]
		[DispId(5)]
		get;
	}

	[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall)]
	[DispId(6)]
	void Render(int hdc, int x, int y, int cx, int cy, [ComAliasName("stdole.OLE_XPOS_HIMETRIC")] int xSrc, [ComAliasName("stdole.OLE_YPOS_HIMETRIC")] int ySrc, [ComAliasName("stdole.OLE_XSIZE_HIMETRIC")] int cxSrc, [ComAliasName("stdole.OLE_YSIZE_HIMETRIC")] int cySrc, IntPtr prcWBounds);
}
