using System.Collections;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Microsoft.Office.Interop.Word;

[ComImport]
[CompilerGenerated]
[Guid("00020914-0000-0000-C000-000000000046")]
[TypeIdentifier]
public interface TablesOfContents : IEnumerable
{
	[DispId(2)]
	WdTocFormat Format
	{
		[DispId(2)]
		get;
		[DispId(2)]
		[param: In]
		set;
	}

	[DispId(0)]
	TableOfContents this[[In] int Index]
	{
		[DispId(0)]
		[return: MarshalAs(UnmanagedType.Interface)]
		get;
	}

	void _VtblGap1_5();

	void _VtblGap2_3();

	[DispId(103)]
	[return: MarshalAs(UnmanagedType.Interface)]
	TableOfContents Add([In][MarshalAs(UnmanagedType.Interface)] Range Range, [Optional][In][MarshalAs(UnmanagedType.Struct)] ref object UseHeadingStyles, [Optional][In][MarshalAs(UnmanagedType.Struct)] ref object UpperHeadingLevel, [Optional][In][MarshalAs(UnmanagedType.Struct)] ref object LowerHeadingLevel, [Optional][In][MarshalAs(UnmanagedType.Struct)] ref object UseFields, [Optional][In][MarshalAs(UnmanagedType.Struct)] ref object TableID, [Optional][In][MarshalAs(UnmanagedType.Struct)] ref object RightAlignPageNumbers, [Optional][In][MarshalAs(UnmanagedType.Struct)] ref object IncludePageNumbers, [Optional][In][MarshalAs(UnmanagedType.Struct)] ref object AddedStyles, [Optional][In][MarshalAs(UnmanagedType.Struct)] ref object UseHyperlinks, [Optional][In][MarshalAs(UnmanagedType.Struct)] ref object HidePageNumbersInWeb, [Optional][In][MarshalAs(UnmanagedType.Struct)] ref object UseOutlineLevels);
}
