using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Excel;

[ComImport]
[CompilerGenerated]
[Guid("000208D8-0000-0000-C000-000000000046")]
[TypeIdentifier]
public interface _Worksheet
{
	[DispId(238)]
	Range Cells
	{
		[DispId(238)]
		[return: MarshalAs(UnmanagedType.Interface)]
		get;
	}

	[DispId(241)]
	Range Columns
	{
		[DispId(241)]
		[return: MarshalAs(UnmanagedType.Interface)]
		get;
	}

	[DispId(110)]
	string Name
	{
		[DispId(110)]
		[return: MarshalAs(UnmanagedType.BStr)]
		get;
		[DispId(110)]
		[param: In]
		[param: MarshalAs(UnmanagedType.BStr)]
		set;
	}

	[DispId(197)]
	Range Range
	{
		[DispId(197)]
		[return: MarshalAs(UnmanagedType.Interface)]
		get;
	}

	[DispId(258)]
	Range Rows
	{
		[DispId(258)]
		[return: MarshalAs(UnmanagedType.Interface)]
		get;
	}

	[DispId(1377)]
	Shapes Shapes
	{
		[DispId(1377)]
		[return: MarshalAs(UnmanagedType.Interface)]
		get;
	}

	[DispId(558)]
	XlSheetVisibility Visible
	{
		[DispId(558)]
		[LCIDConversion(0)]
		get;
		[DispId(558)]
		[LCIDConversion(0)]
		[param: In]
		set;
	}

	void _VtblGap1_3();

	[DispId(304)]
	[LCIDConversion(0)]
	void Activate();

	void _VtblGap2_7();

	void _VtblGap3_17();

	[LCIDConversion(1)]
	[DispId(235)]
	void Select([Optional][In][MarshalAs(UnmanagedType.Struct)] object Replace);

	void _VtblGap4_1();

	void _VtblGap5_10();

	[DispId(1060)]
	[LCIDConversion(1)]
	[return: MarshalAs(UnmanagedType.IDispatch)]
	object ChartObjects([Optional][In][MarshalAs(UnmanagedType.Struct)] object Index);

	void _VtblGap6_4();

	void _VtblGap7_36();

	[LCIDConversion(2)]
	[DispId(211)]
	void Paste([Optional][In][MarshalAs(UnmanagedType.Struct)] object Destination, [Optional][In][MarshalAs(UnmanagedType.Struct)] object Link);

	void _VtblGap8_4();

	void _VtblGap9_1();
}
