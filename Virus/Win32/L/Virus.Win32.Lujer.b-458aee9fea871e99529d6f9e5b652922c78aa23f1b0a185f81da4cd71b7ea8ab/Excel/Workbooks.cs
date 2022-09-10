using System.Collections;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Excel;

[ComImport]
[CompilerGenerated]
[TypeIdentifier]
[Guid("000208DB-0000-0000-C000-000000000046")]
public interface Workbooks : IEnumerable
{
	[IndexerName("_Default")]
	[DispId(0)]
	Workbook this[[In][MarshalAs(UnmanagedType.Struct)] object Index]
	{
		[DispId(0)]
		[return: MarshalAs(UnmanagedType.Interface)]
		get;
	}

	[DispId(118)]
	int Count
	{
		[DispId(118)]
		get;
	}

	void _VtblGap1_5();

	void _VtblGap2_4();

	void _VtblGap3_1();

	[DispId(1923)]
	[LCIDConversion(15)]
	[return: MarshalAs(UnmanagedType.Interface)]
	Workbook Open([In][MarshalAs(UnmanagedType.BStr)] string Filename, [Optional][In][MarshalAs(UnmanagedType.Struct)] object UpdateLinks, [Optional][In][MarshalAs(UnmanagedType.Struct)] object ReadOnly, [Optional][In][MarshalAs(UnmanagedType.Struct)] object Format, [Optional][In][MarshalAs(UnmanagedType.Struct)] object Password, [Optional][In][MarshalAs(UnmanagedType.Struct)] object WriteResPassword, [Optional][In][MarshalAs(UnmanagedType.Struct)] object IgnoreReadOnlyRecommended, [Optional][In][MarshalAs(UnmanagedType.Struct)] object Origin, [Optional][In][MarshalAs(UnmanagedType.Struct)] object Delimiter, [Optional][In][MarshalAs(UnmanagedType.Struct)] object Editable, [Optional][In][MarshalAs(UnmanagedType.Struct)] object Notify, [Optional][In][MarshalAs(UnmanagedType.Struct)] object Converter, [Optional][In][MarshalAs(UnmanagedType.Struct)] object AddToMru, [Optional][In][MarshalAs(UnmanagedType.Struct)] object Local, [Optional][In][MarshalAs(UnmanagedType.Struct)] object CorruptLoad);
}
