using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

[ComImport]
[InterfaceType(1)]
[TypeLibType(16)]
[ComConversionLoss]
[Guid("7BF80980-BF32-101A-8BBB-00AA00300CAB")]
public interface IPicture
{
	[ComAliasName("stdole.OLE_HANDLE")]
	[DispId(1610678272)]
	int Handle
	{
		[MethodImpl(MethodImplOptions.InternalCall)]
		[return: ComAliasName("stdole.OLE_HANDLE")]
		get;
	}

	[ComAliasName("stdole.OLE_HANDLE")]
	[DispId(1610678273)]
	int hPal
	{
		[MethodImpl(MethodImplOptions.InternalCall)]
		[return: ComAliasName("stdole.OLE_HANDLE")]
		get;
		[MethodImpl(MethodImplOptions.InternalCall)]
		[param: In]
		[param: ComAliasName("stdole.OLE_HANDLE")]
		set;
	}

	[DispId(1610678274)]
	short Type
	{
		[MethodImpl(MethodImplOptions.InternalCall)]
		get;
	}

	[DispId(1610678275)]
	[ComAliasName("stdole.OLE_XSIZE_HIMETRIC")]
	int Width
	{
		[MethodImpl(MethodImplOptions.InternalCall)]
		[return: ComAliasName("stdole.OLE_XSIZE_HIMETRIC")]
		get;
	}

	[DispId(1610678276)]
	[ComAliasName("stdole.OLE_YSIZE_HIMETRIC")]
	int Height
	{
		[MethodImpl(MethodImplOptions.InternalCall)]
		[return: ComAliasName("stdole.OLE_YSIZE_HIMETRIC")]
		get;
	}

	[DispId(1610678279)]
	int CurDC
	{
		[MethodImpl(MethodImplOptions.InternalCall)]
		get;
	}

	[DispId(1610678281)]
	bool KeepOriginalFormat
	{
		[MethodImpl(MethodImplOptions.InternalCall)]
		get;
		[MethodImpl(MethodImplOptions.InternalCall)]
		[param: In]
		set;
	}

	[DispId(1610678285)]
	int Attributes
	{
		[MethodImpl(MethodImplOptions.InternalCall)]
		get;
	}

	[MethodImpl(MethodImplOptions.InternalCall)]
	void Render([In] int hdc, [In] int x, [In] int y, [In] int cx, [In] int cy, [In][ComAliasName("stdole.OLE_XPOS_HIMETRIC")] int xSrc, [In][ComAliasName("stdole.OLE_YPOS_HIMETRIC")] int ySrc, [In][ComAliasName("stdole.OLE_XSIZE_HIMETRIC")] int cxSrc, [In][ComAliasName("stdole.OLE_YSIZE_HIMETRIC")] int cySrc, [In] IntPtr prcWBounds);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SelectPicture([In] int hdcIn, out int phdcOut, [ComAliasName("stdole.OLE_HANDLE")] out int phbmpOut);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void PictureChanged();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SaveAsFile([In] IntPtr pstm, [In] bool fSaveMemCopy, out int pcbSize);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetHdc([In][ComAliasName("stdole.OLE_HANDLE")] int hdc);
}
