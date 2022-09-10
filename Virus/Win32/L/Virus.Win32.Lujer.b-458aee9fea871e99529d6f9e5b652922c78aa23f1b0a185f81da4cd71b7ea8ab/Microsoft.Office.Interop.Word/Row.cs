using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Microsoft.Office.Interop.Word;

[ComImport]
[CompilerGenerated]
[TypeIdentifier]
[DefaultMember("Range")]
[Guid("00020950-0000-0000-C000-000000000046")]
public interface Row
{
	[DispId(5)]
	int HeadingFormat
	{
		[DispId(5)]
		get;
		[DispId(5)]
		[param: In]
		set;
	}

	[DispId(0)]
	Range Range
	{
		[DispId(0)]
		[return: MarshalAs(UnmanagedType.Interface)]
		get;
	}

	[DispId(103)]
	Shading Shading
	{
		[DispId(103)]
		[return: MarshalAs(UnmanagedType.Interface)]
		get;
	}

	void _VtblGap1_7();

	void _VtblGap2_14();
}
