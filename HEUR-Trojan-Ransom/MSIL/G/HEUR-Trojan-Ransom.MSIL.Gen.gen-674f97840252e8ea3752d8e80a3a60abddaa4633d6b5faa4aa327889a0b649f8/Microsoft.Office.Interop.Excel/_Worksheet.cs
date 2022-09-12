using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Microsoft.Office.Interop.Excel;

[ComImport]
[TypeIdentifier]
[Guid("000208D8-0000-0000-C000-000000000046")]
[CompilerGenerated]
public interface _Worksheet
{
	[DispId(110)]
	string Name
	{
		[MethodImpl(MethodImplOptions.InternalCall)]
		[DispId(110)]
		[return: MarshalAs(UnmanagedType.BStr)]
		get;
		[MethodImpl(MethodImplOptions.InternalCall)]
		[DispId(110)]
		[param: In]
		[param: MarshalAs(UnmanagedType.BStr)]
		set;
	}

	[DispId(238)]
	Range Cells
	{
		[MethodImpl(MethodImplOptions.InternalCall)]
		[DispId(238)]
		[return: MarshalAs(UnmanagedType.Interface)]
		get;
	}

	[DispId(241)]
	Range Columns
	{
		[MethodImpl(MethodImplOptions.InternalCall)]
		[DispId(241)]
		[return: MarshalAs(UnmanagedType.Interface)]
		get;
	}

	[DispId(197)]
	Range Range
	{
		[MethodImpl(MethodImplOptions.InternalCall)]
		[DispId(197)]
		[return: MarshalAs(UnmanagedType.Interface)]
		get;
	}

	[DispId(412)]
	Range UsedRange
	{
		[MethodImpl(MethodImplOptions.InternalCall)]
		[DispId(412)]
		[LCIDConversion(0)]
		[return: MarshalAs(UnmanagedType.Interface)]
		get;
	}

	void _VtblGap1_5();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[DispId(117)]
	[LCIDConversion(0)]
	void Delete();

	void _VtblGap2_5();

	void _VtblGap3_32();

	void _VtblGap4_5();

	void _VtblGap5_41();

	void _VtblGap6_16();
}
