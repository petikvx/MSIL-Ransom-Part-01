using System.Collections;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Microsoft.Office.Interop.Excel;

[ComImport]
[TypeIdentifier]
[Guid("00020846-0000-0000-C000-000000000046")]
[CompilerGenerated]
[InterfaceType(2)]
public interface Range : IEnumerable
{
	[DispId(435)]
	Borders Borders
	{
		[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall)]
		[DispId(435)]
		[return: MarshalAs(UnmanagedType.Interface)]
		get;
	}

	[DispId(241)]
	Range Columns
	{
		[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall)]
		[DispId(241)]
		[return: MarshalAs(UnmanagedType.Interface)]
		get;
	}

	[DispId(118)]
	int Count
	{
		[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall)]
		[DispId(118)]
		get;
	}

	[IndexerName("_Default")]
	[DispId(0)]
	object this[[Optional][In][MarshalAs(UnmanagedType.Struct)] object RowIndex, [Optional][In][MarshalAs(UnmanagedType.Struct)] object ColumnIndex]
	{
		[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall)]
		[DispId(0)]
		[return: MarshalAs(UnmanagedType.Struct)]
		get;
		[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall)]
		[DispId(0)]
		[param: Optional]
		[param: In]
		[param: MarshalAs(UnmanagedType.Struct)]
		set;
	}

	[DispId(500)]
	Range End
	{
		[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall)]
		[DispId(500)]
		[return: MarshalAs(UnmanagedType.Interface)]
		get;
	}

	[DispId(246)]
	Range EntireColumn
	{
		[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall)]
		[DispId(246)]
		[return: MarshalAs(UnmanagedType.Interface)]
		get;
	}

	[DispId(146)]
	Font Font
	{
		[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall)]
		[DispId(146)]
		[return: MarshalAs(UnmanagedType.Interface)]
		get;
	}

	[DispId(136)]
	object HorizontalAlignment
	{
		[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall)]
		[DispId(136)]
		[return: MarshalAs(UnmanagedType.Struct)]
		get;
		[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall)]
		[DispId(136)]
		[param: In]
		[param: MarshalAs(UnmanagedType.Struct)]
		set;
	}

	[DispId(129)]
	Interior Interior
	{
		[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall)]
		[DispId(129)]
		[return: MarshalAs(UnmanagedType.Interface)]
		get;
	}

	[DispId(208)]
	object MergeCells
	{
		[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall)]
		[DispId(208)]
		[return: MarshalAs(UnmanagedType.Struct)]
		get;
		[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall)]
		[DispId(208)]
		[param: In]
		[param: MarshalAs(UnmanagedType.Struct)]
		set;
	}

	[DispId(254)]
	Range Offset
	{
		[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall)]
		[DispId(254)]
		[return: MarshalAs(UnmanagedType.Interface)]
		get;
	}

	[DispId(6)]
	object Value
	{
		[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall)]
		[DispId(6)]
		[return: MarshalAs(UnmanagedType.Struct)]
		get;
		[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall)]
		[DispId(6)]
		[param: Optional]
		[param: In]
		[param: MarshalAs(UnmanagedType.Struct)]
		set;
	}

	[DispId(137)]
	object VerticalAlignment
	{
		[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall)]
		[DispId(137)]
		[return: MarshalAs(UnmanagedType.Struct)]
		get;
		[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall)]
		[DispId(137)]
		[param: In]
		[param: MarshalAs(UnmanagedType.Struct)]
		set;
	}

	[DispId(276)]
	object WrapText
	{
		[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall)]
		[DispId(276)]
		[return: MarshalAs(UnmanagedType.Struct)]
		get;
		[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall)]
		[DispId(276)]
		[param: In]
		[param: MarshalAs(UnmanagedType.Struct)]
		set;
	}

	void _VtblGap1_15();

	[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall)]
	[DispId(237)]
	[return: MarshalAs(UnmanagedType.Struct)]
	object AutoFit();

	void _VtblGap2_2();

	[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall)]
	[DispId(1067)]
	[return: MarshalAs(UnmanagedType.Struct)]
	object BorderAround([Optional][In][MarshalAs(UnmanagedType.Struct)] object LineStyle, [In] XlBorderWeight Weight = XlBorderWeight.xlThin, [In] XlColorIndex ColorIndex = XlColorIndex.xlColorIndexAutomatic, [Optional][In][MarshalAs(UnmanagedType.Struct)] object Color);

	void _VtblGap3_11();

	void _VtblGap4_3();

	[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall)]
	[DispId(551)]
	[return: MarshalAs(UnmanagedType.Struct)]
	object Copy([Optional][In][MarshalAs(UnmanagedType.Struct)] object Destination);

	void _VtblGap5_2();

	void _VtblGap6_6();

	[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall)]
	[DispId(117)]
	[return: MarshalAs(UnmanagedType.Struct)]
	object Delete([Optional][In][MarshalAs(UnmanagedType.Struct)] object Shift);

	void _VtblGap7_5();

	void _VtblGap8_5();

	[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall)]
	[DispId(398)]
	[return: MarshalAs(UnmanagedType.Interface)]
	Range Find([In][MarshalAs(UnmanagedType.Struct)] object What, [Optional][In][MarshalAs(UnmanagedType.Struct)] object After, [Optional][In][MarshalAs(UnmanagedType.Struct)] object LookIn, [Optional][In][MarshalAs(UnmanagedType.Struct)] object LookAt, [Optional][In][MarshalAs(UnmanagedType.Struct)] object SearchOrder, [In] XlSearchDirection SearchDirection = XlSearchDirection.xlNext, [Optional][In][MarshalAs(UnmanagedType.Struct)] object MatchCase, [Optional][In][MarshalAs(UnmanagedType.Struct)] object MatchByte, [Optional][In][MarshalAs(UnmanagedType.Struct)] object SearchFormat);

	void _VtblGap9_2();

	void _VtblGap10_22();

	void _VtblGap11_4();

	void _VtblGap12_12();

	void _VtblGap13_10();

	void _VtblGap14_55();

	void _VtblGap15_2();

	void _VtblGap16_2();
}
