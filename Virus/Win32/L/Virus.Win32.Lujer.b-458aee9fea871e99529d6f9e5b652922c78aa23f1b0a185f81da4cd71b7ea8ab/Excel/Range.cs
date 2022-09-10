using System.Collections;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Excel;

[ComImport]
[TypeIdentifier]
[InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]
[Guid("00020846-0000-0000-C000-000000000046")]
[CompilerGenerated]
public interface Range : IEnumerable
{
	[IndexerName("_Default")]
	[DispId(0)]
	object this[[Optional][In][MarshalAs(UnmanagedType.Struct)] object RowIndex, [Optional][In][MarshalAs(UnmanagedType.Struct)] object ColumnIndex]
	{
		[PreserveSig]
		[DispId(0)]
		[return: MarshalAs(UnmanagedType.Struct)]
		get;
		[PreserveSig]
		[DispId(0)]
		[param: In]
		[param: MarshalAs(UnmanagedType.Struct)]
		set;
	}

	[DispId(238)]
	Range Cells
	{
		[PreserveSig]
		[DispId(238)]
		[return: MarshalAs(UnmanagedType.Interface)]
		get;
	}

	[DispId(240)]
	int Column
	{
		[PreserveSig]
		[DispId(240)]
		get;
	}

	[DispId(241)]
	Range Columns
	{
		[PreserveSig]
		[DispId(241)]
		[return: MarshalAs(UnmanagedType.Interface)]
		get;
	}

	[DispId(118)]
	int Count
	{
		[PreserveSig]
		[DispId(118)]
		get;
	}

	[DispId(243)]
	Range CurrentRegion
	{
		[PreserveSig]
		[DispId(243)]
		[return: MarshalAs(UnmanagedType.Interface)]
		get;
	}

	[DispId(500)]
	Range End
	{
		[PreserveSig]
		[DispId(500)]
		[return: MarshalAs(UnmanagedType.Interface)]
		get;
	}

	[DispId(246)]
	Range EntireColumn
	{
		[PreserveSig]
		[DispId(246)]
		[return: MarshalAs(UnmanagedType.Interface)]
		get;
	}

	[DispId(247)]
	Range EntireRow
	{
		[PreserveSig]
		[DispId(247)]
		[return: MarshalAs(UnmanagedType.Interface)]
		get;
	}

	[DispId(146)]
	Font Font
	{
		[PreserveSig]
		[DispId(146)]
		[return: MarshalAs(UnmanagedType.Interface)]
		get;
	}

	[DispId(136)]
	object HorizontalAlignment
	{
		[PreserveSig]
		[DispId(136)]
		[return: MarshalAs(UnmanagedType.Struct)]
		get;
		[PreserveSig]
		[DispId(136)]
		[param: In]
		[param: MarshalAs(UnmanagedType.Struct)]
		set;
	}

	[DispId(129)]
	Interior Interior
	{
		[PreserveSig]
		[DispId(129)]
		[return: MarshalAs(UnmanagedType.Interface)]
		get;
	}

	[DispId(254)]
	Range Offset
	{
		[PreserveSig]
		[DispId(254)]
		[return: MarshalAs(UnmanagedType.Interface)]
		get;
	}

	[DispId(256)]
	Range Resize
	{
		[PreserveSig]
		[DispId(256)]
		[return: MarshalAs(UnmanagedType.Interface)]
		get;
	}

	[DispId(257)]
	int Row
	{
		[PreserveSig]
		[DispId(257)]
		get;
	}

	[DispId(258)]
	Range Rows
	{
		[PreserveSig]
		[DispId(258)]
		[return: MarshalAs(UnmanagedType.Interface)]
		get;
	}

	[DispId(6)]
	object Value
	{
		[PreserveSig]
		[DispId(6)]
		[return: MarshalAs(UnmanagedType.Struct)]
		get;
		[PreserveSig]
		[DispId(6)]
		[param: In]
		[param: MarshalAs(UnmanagedType.Struct)]
		set;
	}

	[DispId(137)]
	object VerticalAlignment
	{
		[PreserveSig]
		[DispId(137)]
		[return: MarshalAs(UnmanagedType.Struct)]
		get;
		[PreserveSig]
		[DispId(137)]
		[param: In]
		[param: MarshalAs(UnmanagedType.Struct)]
		set;
	}

	void _VtblGap1_15();

	[PreserveSig]
	[DispId(237)]
	[return: MarshalAs(UnmanagedType.Struct)]
	object AutoFit();

	void _VtblGap2_5();

	void _VtblGap3_7();

	void _VtblGap4_1();

	void _VtblGap5_3();

	[PreserveSig]
	[DispId(551)]
	[return: MarshalAs(UnmanagedType.Struct)]
	object Copy([Optional][In][MarshalAs(UnmanagedType.Struct)] object Destination);

	void _VtblGap6_2();

	void _VtblGap7_3();

	void _VtblGap8_2();

	[PreserveSig]
	[DispId(117)]
	[return: MarshalAs(UnmanagedType.Struct)]
	object Delete([Optional][In][MarshalAs(UnmanagedType.Struct)] object Shift);

	void _VtblGap9_5();

	void _VtblGap10_7();

	void _VtblGap11_22();

	void _VtblGap12_4();

	void _VtblGap13_17();

	[PreserveSig]
	[DispId(-4)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "System.Runtime.InteropServices.CustomMarshalers.EnumeratorToEnumVariantMarshaler, CustomMarshalers, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
	new IEnumerator GetEnumerator();

	void _VtblGap14_6();

	void _VtblGap15_20();

	void _VtblGap16_3();

	void _VtblGap17_1();

	[PreserveSig]
	[DispId(235)]
	[return: MarshalAs(UnmanagedType.Struct)]
	object Select();

	void _VtblGap18_27();

	void _VtblGap19_2();
}
