using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Microsoft.Office.Interop.Word;

[ComImport]
[DefaultMember("Range")]
[Guid("00020951-0000-0000-C000-000000000046")]
[TypeIdentifier]
[CompilerGenerated]
public interface Table
{
	[DispId(110)]
	bool AllowAutoFit
	{
		[DispId(110)]
		get;
		[DispId(110)]
		[param: In]
		set;
	}

	[DispId(204)]
	bool ApplyStyleFirstColumn
	{
		[DispId(204)]
		get;
		[DispId(204)]
		[param: In]
		set;
	}

	[DispId(202)]
	bool ApplyStyleHeadingRows
	{
		[DispId(202)]
		get;
		[DispId(202)]
		[param: In]
		set;
	}

	[DispId(1100)]
	Borders Borders
	{
		[DispId(1100)]
		[return: MarshalAs(UnmanagedType.Interface)]
		get;
		[DispId(1100)]
		[param: In]
		[param: MarshalAs(UnmanagedType.Interface)]
		set;
	}

	[DispId(100)]
	Columns Columns
	{
		[DispId(100)]
		[return: MarshalAs(UnmanagedType.Interface)]
		get;
	}

	[DispId(0)]
	Range Range
	{
		[DispId(0)]
		[return: MarshalAs(UnmanagedType.Interface)]
		get;
	}

	[DispId(101)]
	Rows Rows
	{
		[DispId(101)]
		[return: MarshalAs(UnmanagedType.Interface)]
		get;
	}

	void _VtblGap1_3();

	void _VtblGap2_11();

	[DispId(17)]
	[return: MarshalAs(UnmanagedType.Interface)]
	Cell Cell([In] int Row, [In] int Column);

	void _VtblGap3_2();

	[DispId(20)]
	void AutoFitBehavior([In] WdAutoFitBehavior Behavior);

	void _VtblGap4_5();

	void _VtblGap5_20();

	void _VtblGap6_2();
}
