using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

[ComImport]
[DefaultMember("Name")]
[TypeLibType(2)]
[ClassInterface(0)]
[Guid("0BE35203-8F91-11CE-9DE3-00AA004BB851")]
[ComSourceInterfaces("stdole.FontEvents\0")]
public class StdFontClass : IFont, Font, FontEvents_Event, StdFont
{
	[DispId(0)]
	public virtual extern string Name
	{
		[MethodImpl(MethodImplOptions.InternalCall)]
		[DispId(0)]
		get;
		[MethodImpl(MethodImplOptions.InternalCall)]
		[DispId(0)]
		set;
	}

	[DispId(2)]
	public virtual extern decimal Size
	{
		[MethodImpl(MethodImplOptions.InternalCall)]
		[DispId(2)]
		get;
		[MethodImpl(MethodImplOptions.InternalCall)]
		[DispId(2)]
		set;
	}

	[DispId(3)]
	public virtual extern bool Bold
	{
		[MethodImpl(MethodImplOptions.InternalCall)]
		[DispId(3)]
		get;
		[MethodImpl(MethodImplOptions.InternalCall)]
		[DispId(3)]
		set;
	}

	[DispId(4)]
	public virtual extern bool Italic
	{
		[MethodImpl(MethodImplOptions.InternalCall)]
		[DispId(4)]
		get;
		[MethodImpl(MethodImplOptions.InternalCall)]
		[DispId(4)]
		set;
	}

	[DispId(5)]
	public virtual extern bool Underline
	{
		[MethodImpl(MethodImplOptions.InternalCall)]
		[DispId(5)]
		get;
		[MethodImpl(MethodImplOptions.InternalCall)]
		[DispId(5)]
		set;
	}

	[DispId(6)]
	public virtual extern bool Strikethrough
	{
		[MethodImpl(MethodImplOptions.InternalCall)]
		[DispId(6)]
		get;
		[MethodImpl(MethodImplOptions.InternalCall)]
		[DispId(6)]
		set;
	}

	[DispId(7)]
	public virtual extern short Weight
	{
		[MethodImpl(MethodImplOptions.InternalCall)]
		[DispId(7)]
		get;
		[MethodImpl(MethodImplOptions.InternalCall)]
		[DispId(7)]
		set;
	}

	[DispId(8)]
	public virtual extern short Charset
	{
		[MethodImpl(MethodImplOptions.InternalCall)]
		[DispId(8)]
		get;
		[MethodImpl(MethodImplOptions.InternalCall)]
		[DispId(8)]
		set;
	}

	virtual extern string IFont.Name
	{
		[MethodImpl(MethodImplOptions.InternalCall)]
		[return: MarshalAs(UnmanagedType.BStr)]
		get;
		[MethodImpl(MethodImplOptions.InternalCall)]
		[param: In]
		[param: MarshalAs(UnmanagedType.BStr)]
		set;
	}

	virtual extern decimal IFont.Size
	{
		[MethodImpl(MethodImplOptions.InternalCall)]
		[return: MarshalAs(UnmanagedType.Currency)]
		get;
		[MethodImpl(MethodImplOptions.InternalCall)]
		[param: In]
		[param: MarshalAs(UnmanagedType.Currency)]
		set;
	}

	virtual extern bool IFont.Bold
	{
		[MethodImpl(MethodImplOptions.InternalCall)]
		get;
		[MethodImpl(MethodImplOptions.InternalCall)]
		[param: In]
		set;
	}

	virtual extern bool IFont.Italic
	{
		[MethodImpl(MethodImplOptions.InternalCall)]
		get;
		[MethodImpl(MethodImplOptions.InternalCall)]
		[param: In]
		set;
	}

	virtual extern bool IFont.Underline
	{
		[MethodImpl(MethodImplOptions.InternalCall)]
		get;
		[MethodImpl(MethodImplOptions.InternalCall)]
		[param: In]
		set;
	}

	virtual extern bool IFont.Strikethrough
	{
		[MethodImpl(MethodImplOptions.InternalCall)]
		get;
		[MethodImpl(MethodImplOptions.InternalCall)]
		[param: In]
		set;
	}

	virtual extern short IFont.Weight
	{
		[MethodImpl(MethodImplOptions.InternalCall)]
		get;
		[MethodImpl(MethodImplOptions.InternalCall)]
		[param: In]
		set;
	}

	virtual extern short IFont.Charset
	{
		[MethodImpl(MethodImplOptions.InternalCall)]
		get;
		[MethodImpl(MethodImplOptions.InternalCall)]
		[param: In]
		set;
	}

	[ComAliasName("stdole.OLE_HANDLE")]
	public virtual extern int hFont
	{
		[MethodImpl(MethodImplOptions.InternalCall)]
		[return: ComAliasName("stdole.OLE_HANDLE")]
		get;
	}

	public virtual extern event FontEvents_FontChangedEventHandler FontChanged;

	[MethodImpl(MethodImplOptions.InternalCall)]
	public extern StdFontClass();

	[MethodImpl(MethodImplOptions.InternalCall)]
	public virtual extern void Clone([MarshalAs(UnmanagedType.Interface)] out IFont ppfont);

	[MethodImpl(MethodImplOptions.InternalCall)]
	public virtual extern void IsEqual([In][MarshalAs(UnmanagedType.Interface)] IFont pfontOther);

	[MethodImpl(MethodImplOptions.InternalCall)]
	public virtual extern void SetRatio([In] int cyLogical, [In] int cyHimetric);

	[MethodImpl(MethodImplOptions.InternalCall)]
	public virtual extern void AddRefHfont([In][ComAliasName("stdole.OLE_HANDLE")] int hFont);

	[MethodImpl(MethodImplOptions.InternalCall)]
	public virtual extern void ReleaseHfont([In][ComAliasName("stdole.OLE_HANDLE")] int hFont);
}
