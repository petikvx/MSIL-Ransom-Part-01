using System.Collections;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Microsoft.Office.Interop.Word;

[ComImport]
[Guid("0002093C-0000-0000-C000-000000000046")]
[TypeIdentifier]
[CompilerGenerated]
public interface Borders : IEnumerable
{
	[DispId(0)]
	Border this[[In] WdBorderType Index]
	{
		[DispId(0)]
		[return: MarshalAs(UnmanagedType.Interface)]
		get;
	}

	[DispId(5)]
	bool Shadow
	{
		[DispId(5)]
		get;
		[DispId(5)]
		[param: In]
		set;
	}

	void _VtblGap1_9();

	void _VtblGap2_34();
}
