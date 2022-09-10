using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Microsoft.Office.Interop.Word;

[ComImport]
[TypeIdentifier]
[CompilerGenerated]
[DefaultMember("Text")]
[Guid("00020975-0000-0000-C000-000000000046")]
public interface Selection
{
	[DispId(400)]
	Range Range
	{
		[DispId(400)]
		[return: MarshalAs(UnmanagedType.Interface)]
		get;
	}

	[DispId(8)]
	object Style
	{
		[DispId(8)]
		[return: MarshalAs(UnmanagedType.Struct)]
		get;
		[DispId(8)]
		[param: In]
		[param: MarshalAs(UnmanagedType.Struct)]
		set;
	}

	[DispId(50)]
	Tables Tables
	{
		[DispId(50)]
		[return: MarshalAs(UnmanagedType.Interface)]
		get;
	}

	[DispId(0)]
	string Text
	{
		[DispId(0)]
		[return: MarshalAs(UnmanagedType.BStr)]
		get;
		[DispId(0)]
		[param: In]
		[param: MarshalAs(UnmanagedType.BStr)]
		set;
	}

	void _VtblGap1_10();

	void _VtblGap2_35();

	void _VtblGap3_38();

	[DispId(120)]
	void Copy();

	void _VtblGap4_20();

	[DispId(173)]
	[return: MarshalAs(UnmanagedType.Interface)]
	Range GoTo([Optional][In][MarshalAs(UnmanagedType.Struct)] ref object What, [Optional][In][MarshalAs(UnmanagedType.Struct)] ref object Which, [Optional][In][MarshalAs(UnmanagedType.Struct)] ref object Count, [Optional][In][MarshalAs(UnmanagedType.Struct)] ref object Name);

	void _VtblGap5_10();

	[DispId(501)]
	int MoveRight([Optional][In][MarshalAs(UnmanagedType.Struct)] ref object Unit, [Optional][In][MarshalAs(UnmanagedType.Struct)] ref object Count, [Optional][In][MarshalAs(UnmanagedType.Struct)] ref object Extend);

	void _VtblGap6_2();

	[DispId(504)]
	int HomeKey([Optional][In][MarshalAs(UnmanagedType.Struct)] ref object Unit, [Optional][In][MarshalAs(UnmanagedType.Struct)] ref object Extend);

	void _VtblGap7_2();

	[DispId(507)]
	void TypeText([In][MarshalAs(UnmanagedType.BStr)] string Text);

	void _VtblGap8_2();

	[DispId(512)]
	void TypeParagraph();

	void _VtblGap9_11();

	[DispId(524)]
	void WholeStory();

	void _VtblGap10_40();

	[DispId(1014)]
	void PasteExcelTable([In] bool LinkedToExcel, [In] bool WordFormatting, [In] bool RTF);
}
