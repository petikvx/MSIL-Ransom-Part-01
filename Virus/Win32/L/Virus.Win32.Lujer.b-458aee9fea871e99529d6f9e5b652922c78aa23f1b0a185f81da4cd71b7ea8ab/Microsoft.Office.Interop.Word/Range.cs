using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Microsoft.Office.Interop.Word;

[ComImport]
[TypeIdentifier]
[DefaultMember("Text")]
[Guid("0002095E-0000-0000-C000-000000000046")]
[CompilerGenerated]
public interface Range
{
	[DispId(5)]
	Font Font
	{
		[DispId(5)]
		[return: MarshalAs(UnmanagedType.Interface)]
		get;
		[DispId(5)]
		[param: In]
		[param: MarshalAs(UnmanagedType.Interface)]
		set;
	}

	[DispId(1102)]
	ParagraphFormat ParagraphFormat
	{
		[DispId(1102)]
		[return: MarshalAs(UnmanagedType.Interface)]
		get;
		[DispId(1102)]
		[param: In]
		[param: MarshalAs(UnmanagedType.Interface)]
		set;
	}

	[DispId(0)]
	string Text
	{
		[DispId(0)]
		[return: MarshalAs(UnmanagedType.BStr)]
		get;
		[DispId(0)]
		[param: In]
		[param: MarshalAs(UnmanagedType.BStr)]
		set;
	}

	void _VtblGap1_6();

	void _VtblGap2_20();

	void _VtblGap3_60();

	[DispId(104)]
	void InsertAfter([In][MarshalAs(UnmanagedType.BStr)] string Text);
}
