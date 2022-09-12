using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

[ComImport]
[DefaultMember("Name")]
[InterfaceType(2)]
[Guid("BEF6E003-A874-101A-8BBA-00AA00300CAB")]
public interface IFontDisp
{
	[DispId(0)]
	string Name
	{
		[MethodImpl(MethodImplOptions.InternalCall)]
		[DispId(0)]
		get;
		[MethodImpl(MethodImplOptions.InternalCall)]
		[DispId(0)]
		set;
	}

	[DispId(2)]
	decimal Size
	{
		[MethodImpl(MethodImplOptions.InternalCall)]
		[DispId(2)]
		get;
		[MethodImpl(MethodImplOptions.InternalCall)]
		[DispId(2)]
		set;
	}

	[DispId(3)]
	bool Bold
	{
		[MethodImpl(MethodImplOptions.InternalCall)]
		[DispId(3)]
		get;
		[MethodImpl(MethodImplOptions.InternalCall)]
		[DispId(3)]
		set;
	}

	[DispId(4)]
	bool Italic
	{
		[MethodImpl(MethodImplOptions.InternalCall)]
		[DispId(4)]
		get;
		[MethodImpl(MethodImplOptions.InternalCall)]
		[DispId(4)]
		set;
	}

	[DispId(5)]
	bool Underline
	{
		[MethodImpl(MethodImplOptions.InternalCall)]
		[DispId(5)]
		get;
		[MethodImpl(MethodImplOptions.InternalCall)]
		[DispId(5)]
		set;
	}

	[DispId(6)]
	bool Strikethrough
	{
		[MethodImpl(MethodImplOptions.InternalCall)]
		[DispId(6)]
		get;
		[MethodImpl(MethodImplOptions.InternalCall)]
		[DispId(6)]
		set;
	}

	[DispId(7)]
	short Weight
	{
		[MethodImpl(MethodImplOptions.InternalCall)]
		[DispId(7)]
		get;
		[MethodImpl(MethodImplOptions.InternalCall)]
		[DispId(7)]
		set;
	}

	[DispId(8)]
	short Charset
	{
		[MethodImpl(MethodImplOptions.InternalCall)]
		[DispId(8)]
		get;
		[MethodImpl(MethodImplOptions.InternalCall)]
		[DispId(8)]
		set;
	}
}
