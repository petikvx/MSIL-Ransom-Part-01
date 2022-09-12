using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

[ComImport]
[Guid("0BE35204-8F91-11CE-9DE3-00AA004BB851")]
[ComConversionLoss]
[TypeLibType(2)]
[ClassInterface(0)]
[DefaultMember("Handle")]
public class StdPictureClass : IPicture, Picture, StdPicture
{
	[DispId(0)]
	[ComAliasName("stdole.OLE_HANDLE")]
	public virtual extern int Handle
	{
		[MethodImpl(MethodImplOptions.InternalCall)]
		[DispId(0)]
		get;
	}

	[DispId(2)]
	[ComAliasName("stdole.OLE_HANDLE")]
	public virtual extern int hPal
	{
		[MethodImpl(MethodImplOptions.InternalCall)]
		[DispId(2)]
		get;
		[MethodImpl(MethodImplOptions.InternalCall)]
		[DispId(2)]
		set;
	}

	[DispId(3)]
	public virtual extern short Type
	{
		[MethodImpl(MethodImplOptions.InternalCall)]
		[DispId(3)]
		get;
	}

	[ComAliasName("stdole.OLE_XSIZE_HIMETRIC")]
	[DispId(4)]
	public virtual extern int Width
	{
		[MethodImpl(MethodImplOptions.InternalCall)]
		[DispId(4)]
		get;
	}

	[ComAliasName("stdole.OLE_YSIZE_HIMETRIC")]
	[DispId(5)]
	public virtual extern int Height
	{
		[MethodImpl(MethodImplOptions.InternalCall)]
		[DispId(5)]
		get;
	}

	[ComAliasName("stdole.OLE_HANDLE")]
	virtual extern int IPicture.Handle
	{
		[MethodImpl(MethodImplOptions.InternalCall)]
		[return: ComAliasName("stdole.OLE_HANDLE")]
		get;
	}

	[ComAliasName("stdole.OLE_HANDLE")]
	virtual extern int IPicture.hPal
	{
		[MethodImpl(MethodImplOptions.InternalCall)]
		[return: ComAliasName("stdole.OLE_HANDLE")]
		get;
		[MethodImpl(MethodImplOptions.InternalCall)]
		[param: In]
		[param: ComAliasName("stdole.OLE_HANDLE")]
		set;
	}

	virtual extern short IPicture.Type
	{
		[MethodImpl(MethodImplOptions.InternalCall)]
		get;
	}

	[ComAliasName("stdole.OLE_XSIZE_HIMETRIC")]
	virtual extern int IPicture.Width
	{
		[MethodImpl(MethodImplOptions.InternalCall)]
		[return: ComAliasName("stdole.OLE_XSIZE_HIMETRIC")]
		get;
	}

	[ComAliasName("stdole.OLE_YSIZE_HIMETRIC")]
	virtual extern int IPicture.Height
	{
		[MethodImpl(MethodImplOptions.InternalCall)]
		[return: ComAliasName("stdole.OLE_YSIZE_HIMETRIC")]
		get;
	}

	public virtual extern int CurDC
	{
		[MethodImpl(MethodImplOptions.InternalCall)]
		get;
	}

	public virtual extern bool KeepOriginalFormat
	{
		[MethodImpl(MethodImplOptions.InternalCall)]
		get;
		[MethodImpl(MethodImplOptions.InternalCall)]
		[param: In]
		set;
	}

	public virtual extern int Attributes
	{
		[MethodImpl(MethodImplOptions.InternalCall)]
		get;
	}

	[MethodImpl(MethodImplOptions.InternalCall)]
	public extern StdPictureClass();

	[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall)]
	[DispId(6)]
	public virtual extern void Render(int hdc, int x, int y, int cx, int cy, [ComAliasName("stdole.OLE_XPOS_HIMETRIC")] int xSrc, [ComAliasName("stdole.OLE_YPOS_HIMETRIC")] int ySrc, [ComAliasName("stdole.OLE_XSIZE_HIMETRIC")] int cxSrc, [ComAliasName("stdole.OLE_YSIZE_HIMETRIC")] int cySrc, IntPtr prcWBounds);

	[MethodImpl(MethodImplOptions.InternalCall)]
	public virtual extern void IPicture_Render([In] int hdc, [In] int x, [In] int y, [In] int cx, [In] int cy, [In][ComAliasName("stdole.OLE_XPOS_HIMETRIC")] int xSrc, [In][ComAliasName("stdole.OLE_YPOS_HIMETRIC")] int ySrc, [In][ComAliasName("stdole.OLE_XSIZE_HIMETRIC")] int cxSrc, [In][ComAliasName("stdole.OLE_YSIZE_HIMETRIC")] int cySrc, [In] IntPtr prcWBounds);

	void IPicture.Render([In] int hdc, [In] int x, [In] int y, [In] int cx, [In] int cy, [In][ComAliasName("stdole.OLE_XPOS_HIMETRIC")] int xSrc, [In][ComAliasName("stdole.OLE_YPOS_HIMETRIC")] int ySrc, [In][ComAliasName("stdole.OLE_XSIZE_HIMETRIC")] int cxSrc, [In][ComAliasName("stdole.OLE_YSIZE_HIMETRIC")] int cySrc, [In] IntPtr prcWBounds)
	{
		//ILSpy generated this explicit interface implementation from .override directive in IPicture_Render
		this.IPicture_Render(hdc, x, y, cx, cy, xSrc, ySrc, cxSrc, cySrc, prcWBounds);
	}

	[MethodImpl(MethodImplOptions.InternalCall)]
	public virtual extern void SelectPicture([In] int hdcIn, out int phdcOut, [ComAliasName("stdole.OLE_HANDLE")] out int phbmpOut);

	[MethodImpl(MethodImplOptions.InternalCall)]
	public virtual extern void PictureChanged();

	[MethodImpl(MethodImplOptions.InternalCall)]
	public virtual extern void SaveAsFile([In] IntPtr pstm, [In] bool fSaveMemCopy, out int pcbSize);

	[MethodImpl(MethodImplOptions.InternalCall)]
	public virtual extern void SetHdc([In][ComAliasName("stdole.OLE_HANDLE")] int hdc);
}
