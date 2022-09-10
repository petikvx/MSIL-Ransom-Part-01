using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Microsoft.Office.Interop.Word;

[ComImport]
[CompilerGenerated]
[TypeIdentifier]
[Guid("00020970-0000-0000-C000-000000000046")]
[DefaultMember("Name")]
public interface _Application
{
	[DispId(3)]
	Document ActiveDocument
	{
		[DispId(3)]
		[return: MarshalAs(UnmanagedType.Interface)]
		get;
	}

	[DispId(94)]
	WdAlertLevel DisplayAlerts
	{
		[DispId(94)]
		get;
		[DispId(94)]
		[param: In]
		set;
	}

	[DispId(6)]
	Documents Documents
	{
		[DispId(6)]
		[return: MarshalAs(UnmanagedType.Interface)]
		get;
	}

	[DispId(0)]
	string Name
	{
		[DispId(0)]
		[return: MarshalAs(UnmanagedType.BStr)]
		get;
	}

	[DispId(93)]
	Options Options
	{
		[DispId(93)]
		[return: MarshalAs(UnmanagedType.Interface)]
		get;
	}

	[DispId(5)]
	Selection Selection
	{
		[DispId(5)]
		[return: MarshalAs(UnmanagedType.Interface)]
		get;
	}

	[DispId(97)]
	string StatusBar
	{
		[DispId(97)]
		[param: In]
		[param: MarshalAs(UnmanagedType.BStr)]
		set;
	}

	[DispId(23)]
	bool Visible
	{
		[DispId(23)]
		get;
		[DispId(23)]
		[param: In]
		set;
	}

	void _VtblGap1_3();

	void _VtblGap2_1();

	void _VtblGap3_1();

	void _VtblGap4_17();

	void _VtblGap5_61();

	void _VtblGap6_2();

	void _VtblGap7_18();

	[DispId(1105)]
	void Quit([Optional][In][MarshalAs(UnmanagedType.Struct)] ref object SaveChanges, [Optional][In][MarshalAs(UnmanagedType.Struct)] ref object OriginalFormat, [Optional][In][MarshalAs(UnmanagedType.Struct)] ref object RouteDocument);
}
