using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

[ComImport]
[Guid("BEF6E002-A874-101A-8BBA-00AA00300CAB")]
[TypeLibType(16)]
[InterfaceType(1)]
public interface IFont
{
	[DispId(1610678272)]
	string Name
	{
		[MethodImpl(MethodImplOptions.InternalCall)]
		[return: MarshalAs(UnmanagedType.BStr)]
		get;
		[MethodImpl(MethodImplOptions.InternalCall)]
		[param: In]
		[param: MarshalAs(UnmanagedType.BStr)]
		set;
	}

	[DispId(1610678274)]
	decimal Size
	{
		[MethodImpl(MethodImplOptions.InternalCall)]
		[return: MarshalAs(UnmanagedType.Currency)]
		get;
		[MethodImpl(MethodImplOptions.InternalCall)]
		[param: In]
		[param: MarshalAs(UnmanagedType.Currency)]
		set;
	}

	[DispId(1610678276)]
	bool Bold
	{
		[MethodImpl(MethodImplOptions.InternalCall)]
		get;
		[MethodImpl(MethodImplOptions.InternalCall)]
		[param: In]
		set;
	}

	[DispId(1610678278)]
	bool Italic
	{
		[MethodImpl(MethodImplOptions.InternalCall)]
		get;
		[MethodImpl(MethodImplOptions.InternalCall)]
		[param: In]
		set;
	}

	[DispId(1610678280)]
	bool Underline
	{
		[MethodImpl(MethodImplOptions.InternalCall)]
		get;
		[MethodImpl(MethodImplOptions.InternalCall)]
		[param: In]
		set;
	}

	[DispId(1610678282)]
	bool Strikethrough
	{
		[MethodImpl(MethodImplOptions.InternalCall)]
		get;
		[MethodImpl(MethodImplOptions.InternalCall)]
		[param: In]
		set;
	}

	[DispId(1610678284)]
	short Weight
	{
		[MethodImpl(MethodImplOptions.InternalCall)]
		get;
		[MethodImpl(MethodImplOptions.InternalCall)]
		[param: In]
		set;
	}

	[DispId(1610678286)]
	short Charset
	{
		[MethodImpl(MethodImplOptions.InternalCall)]
		get;
		[MethodImpl(MethodImplOptions.InternalCall)]
		[param: In]
		set;
	}

	[DispId(1610678288)]
	[ComAliasName("stdole.OLE_HANDLE")]
	int hFont
	{
		[MethodImpl(MethodImplOptions.InternalCall)]
		[return: ComAliasName("stdole.OLE_HANDLE")]
		get;
	}

	[MethodImpl(MethodImplOptions.InternalCall)]
	void Clone([MarshalAs(UnmanagedType.Interface)] out IFont ppfont);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void IsEqual([In][MarshalAs(UnmanagedType.Interface)] IFont pfontOther);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetRatio([In] int cyLogical, [In] int cyHimetric);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void AddRefHfont([In][ComAliasName("stdole.OLE_HANDLE")] int hFont);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void ReleaseHfont([In][ComAliasName("stdole.OLE_HANDLE")] int hFont);
}
