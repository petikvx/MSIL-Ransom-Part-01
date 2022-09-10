using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Excel;

[ComImport]
[Guid("000208DA-0000-0000-C000-000000000046")]
[TypeIdentifier]
[CompilerGenerated]
public interface _Workbook
{
	[DispId(183)]
	Chart ActiveChart
	{
		[DispId(183)]
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

	[DispId(121)]
	Sheets Charts
	{
		[DispId(121)]
		[return: MarshalAs(UnmanagedType.Interface)]
		get;
	}

	[DispId(110)]
	string Name
	{
		[DispId(110)]
		[return: MarshalAs(UnmanagedType.BStr)]
		get;
	}

	[DispId(442)]
	Names Names
	{
		[DispId(442)]
		[return: MarshalAs(UnmanagedType.Interface)]
		get;
	}

	[DispId(291)]
	string Path
	{
		[LCIDConversion(0)]
		[DispId(291)]
		[return: MarshalAs(UnmanagedType.BStr)]
		get;
	}

	[DispId(2050)]
	bool RemovePersonalInformation
	{
		[DispId(2050)]
		get;
		[DispId(2050)]
		[param: In]
		set;
	}

	[DispId(298)]
	bool Saved
	{
		[DispId(298)]
		[LCIDConversion(0)]
		get;
		[LCIDConversion(0)]
		[DispId(298)]
		[param: In]
		set;
	}

	[DispId(485)]
	Sheets Sheets
	{
		[DispId(485)]
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

	void _VtblGap1_6();

	void _VtblGap2_11();

	[LCIDConversion(3)]
	[DispId(277)]
	void Close([Optional][In][MarshalAs(UnmanagedType.Struct)] object SaveChanges, [Optional][In][MarshalAs(UnmanagedType.Struct)] object Filename, [Optional][In][MarshalAs(UnmanagedType.Struct)] object RouteWorkbook);

	void _VtblGap3_38();

	void _VtblGap4_8();

	void _VtblGap5_25();

	[LCIDConversion(0)]
	[DispId(283)]
	void Save();

	void _VtblGap6_2();

	void _VtblGap7_5();

	void _VtblGap8_18();

	void _VtblGap9_40();

	[LCIDConversion(12)]
	[DispId(1925)]
	void SaveAs([Optional][In][MarshalAs(UnmanagedType.Struct)] object Filename, [Optional][In][MarshalAs(UnmanagedType.Struct)] object FileFormat, [Optional][In][MarshalAs(UnmanagedType.Struct)] object Password, [Optional][In][MarshalAs(UnmanagedType.Struct)] object WriteResPassword, [Optional][In][MarshalAs(UnmanagedType.Struct)] object ReadOnlyRecommended, [Optional][In][MarshalAs(UnmanagedType.Struct)] object CreateBackup, [In] XlSaveAsAccessMode AccessMode = XlSaveAsAccessMode.xlNoChange, [Optional][In][MarshalAs(UnmanagedType.Struct)] object ConflictResolution, [Optional][In][MarshalAs(UnmanagedType.Struct)] object AddToMru, [Optional][In][MarshalAs(UnmanagedType.Struct)] object TextCodepage, [Optional][In][MarshalAs(UnmanagedType.Struct)] object TextVisualLayout, [Optional][In][MarshalAs(UnmanagedType.Struct)] object Local);

	void _VtblGap10_2();
}
