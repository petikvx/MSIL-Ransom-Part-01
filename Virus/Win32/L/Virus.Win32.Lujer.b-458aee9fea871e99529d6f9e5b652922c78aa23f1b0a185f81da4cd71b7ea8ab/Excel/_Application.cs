using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Excel;

[ComImport]
[TypeIdentifier]
[CompilerGenerated]
[DefaultMember("_Default")]
[Guid("000208D5-0000-0000-C000-000000000046")]
public interface _Application
{
	[DispId(0)]
	string _Default
	{
		[DispId(0)]
		[return: MarshalAs(UnmanagedType.BStr)]
		get;
	}

	[DispId(305)]
	Range ActiveCell
	{
		[DispId(305)]
		[return: MarshalAs(UnmanagedType.Interface)]
		get;
	}

	[DispId(307)]
	object ActiveSheet
	{
		[DispId(307)]
		[return: MarshalAs(UnmanagedType.IDispatch)]
		get;
	}

	[DispId(759)]
	Window ActiveWindow
	{
		[DispId(759)]
		[return: MarshalAs(UnmanagedType.Interface)]
		get;
	}

	[DispId(308)]
	Workbook ActiveWorkbook
	{
		[DispId(308)]
		[return: MarshalAs(UnmanagedType.Interface)]
		get;
	}

	[DispId(148)]
	Application Application
	{
		[DispId(148)]
		[return: MarshalAs(UnmanagedType.Interface)]
		get;
	}

	[DispId(330)]
	XlCutCopyMode CutCopyMode
	{
		[LCIDConversion(0)]
		[DispId(330)]
		get;
		[DispId(330)]
		[LCIDConversion(0)]
		[param: In]
		set;
	}

	[DispId(343)]
	bool DisplayAlerts
	{
		[LCIDConversion(0)]
		[DispId(343)]
		get;
		[LCIDConversion(0)]
		[DispId(343)]
		[param: In]
		set;
	}

	[DispId(1096)]
	XlEnableCancelKey EnableCancelKey
	{
		[DispId(1096)]
		[LCIDConversion(0)]
		get;
		[LCIDConversion(0)]
		[DispId(1096)]
		[param: In]
		set;
	}

	[DispId(382)]
	bool ScreenUpdating
	{
		[DispId(382)]
		[LCIDConversion(0)]
		get;
		[DispId(382)]
		[LCIDConversion(0)]
		[param: In]
		set;
	}

	[DispId(147)]
	object Selection
	{
		[DispId(147)]
		[LCIDConversion(0)]
		[return: MarshalAs(UnmanagedType.IDispatch)]
		get;
	}

	[DispId(485)]
	Sheets Sheets
	{
		[DispId(485)]
		[return: MarshalAs(UnmanagedType.Interface)]
		get;
	}

	[DispId(386)]
	object StatusBar
	{
		[DispId(386)]
		[LCIDConversion(0)]
		[return: MarshalAs(UnmanagedType.Struct)]
		get;
		[LCIDConversion(0)]
		[DispId(386)]
		[param: In]
		[param: MarshalAs(UnmanagedType.Struct)]
		set;
	}

	[DispId(558)]
	bool Visible
	{
		[DispId(558)]
		[LCIDConversion(0)]
		get;
		[LCIDConversion(0)]
		[DispId(558)]
		[param: In]
		set;
	}

	[DispId(430)]
	Windows Windows
	{
		[DispId(430)]
		[return: MarshalAs(UnmanagedType.Interface)]
		get;
	}

	[DispId(572)]
	Workbooks Workbooks
	{
		[DispId(572)]
		[return: MarshalAs(UnmanagedType.Interface)]
		get;
	}

	[DispId(1440)]
	WorksheetFunction WorksheetFunction
	{
		[DispId(1440)]
		[return: MarshalAs(UnmanagedType.Interface)]
		get;
	}

	[DispId(494)]
	Sheets Worksheets
	{
		[DispId(494)]
		[return: MarshalAs(UnmanagedType.Interface)]
		get;
	}

	void _VtblGap1_2();

	void _VtblGap2_5();

	void _VtblGap3_25();

	void _VtblGap4_1();

	void _VtblGap5_4();

	void _VtblGap6_43();

	void _VtblGap7_13();

	void _VtblGap8_5();

	void _VtblGap9_21();

	void _VtblGap10_99();

	void _VtblGap11_12();

	void _VtblGap12_23();
}
