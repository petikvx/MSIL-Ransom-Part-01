using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Excel;

[ComImport]
[Guid("000208D6-0000-0000-C000-000000000046")]
[CompilerGenerated]
[TypeIdentifier]
public interface _Chart
{
	[DispId(81)]
	ChartTitle ChartTitle
	{
		[DispId(81)]
		[LCIDConversion(0)]
		[return: MarshalAs(UnmanagedType.Interface)]
		get;
	}

	[DispId(1400)]
	XlChartType ChartType
	{
		[DispId(1400)]
		get;
		[DispId(1400)]
		[param: In]
		set;
	}

	[DispId(53)]
	bool HasLegend
	{
		[LCIDConversion(0)]
		[DispId(53)]
		get;
		[DispId(53)]
		[LCIDConversion(0)]
		[param: In]
		set;
	}

	[DispId(54)]
	bool HasTitle
	{
		[DispId(54)]
		[LCIDConversion(0)]
		get;
		[DispId(54)]
		[LCIDConversion(0)]
		[param: In]
		set;
	}

	void _VtblGap1_42();

	[LCIDConversion(2)]
	[DispId(23)]
	[return: MarshalAs(UnmanagedType.IDispatch)]
	object Axes([Optional][In][MarshalAs(UnmanagedType.Struct)] object Type, [In] XlAxisGroup AxisGroup = XlAxisGroup.xlPrimary);

	void _VtblGap2_7();

	void _VtblGap3_31();

	void _VtblGap4_9();

	[DispId(1397)]
	[return: MarshalAs(UnmanagedType.Interface)]
	Chart Location([In] XlChartLocation Where, [Optional][In][MarshalAs(UnmanagedType.Struct)] object Name);

	void _VtblGap5_31();

	void _VtblGap6_19();

	[DispId(1413)]
	void SetSourceData([In][MarshalAs(UnmanagedType.Interface)] Range Source, [Optional][In][MarshalAs(UnmanagedType.Struct)] object PlotBy);

	[DispId(1414)]
	bool Export([In][MarshalAs(UnmanagedType.BStr)] string Filename, [Optional][In][MarshalAs(UnmanagedType.Struct)] object FilterName, [Optional][In][MarshalAs(UnmanagedType.Struct)] object Interactive);
}
