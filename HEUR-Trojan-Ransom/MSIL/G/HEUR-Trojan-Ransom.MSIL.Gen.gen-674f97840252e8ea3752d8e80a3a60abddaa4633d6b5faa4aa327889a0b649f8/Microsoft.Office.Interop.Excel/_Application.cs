using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Microsoft.Office.Interop.Excel;

[ComImport]
[CompilerGenerated]
[DefaultMember("_Default")]
[Guid("000208D5-0000-0000-C000-000000000046")]
[TypeIdentifier]
public interface _Application
{
	[DispId(241)]
	Range Columns
	{
		[MethodImpl(MethodImplOptions.InternalCall)]
		[DispId(241)]
		[return: MarshalAs(UnmanagedType.Interface)]
		get;
	}

	[DispId(485)]
	Sheets Sheets
	{
		[MethodImpl(MethodImplOptions.InternalCall)]
		[DispId(485)]
		[return: MarshalAs(UnmanagedType.Interface)]
		get;
	}

	[DispId(572)]
	Workbooks Workbooks
	{
		[MethodImpl(MethodImplOptions.InternalCall)]
		[DispId(572)]
		[return: MarshalAs(UnmanagedType.Interface)]
		get;
	}

	[DispId(0)]
	string _Default
	{
		[MethodImpl(MethodImplOptions.InternalCall)]
		[DispId(0)]
		[return: MarshalAs(UnmanagedType.BStr)]
		get;
	}

	[DispId(343)]
	bool DisplayAlerts
	{
		[MethodImpl(MethodImplOptions.InternalCall)]
		[LCIDConversion(0)]
		[DispId(343)]
		get;
		[MethodImpl(MethodImplOptions.InternalCall)]
		[DispId(343)]
		[LCIDConversion(0)]
		[param: In]
		set;
	}

	[DispId(558)]
	bool Visible
	{
		[MethodImpl(MethodImplOptions.InternalCall)]
		[LCIDConversion(0)]
		[DispId(558)]
		get;
		[MethodImpl(MethodImplOptions.InternalCall)]
		[DispId(558)]
		[LCIDConversion(0)]
		[param: In]
		set;
	}

	void _VtblGap1_17();

	void _VtblGap2_21();

	void _VtblGap3_5();

	void _VtblGap4_60();

	void _VtblGap5_5();

	void _VtblGap6_109();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[DispId(302)]
	void Quit();

	void _VtblGap7_51();
}
