using System.Collections;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Microsoft.Office.Interop.Word;

[ComImport]
[TypeIdentifier]
[Guid("0002092D-0000-0000-C000-000000000046")]
[CompilerGenerated]
public interface Styles : IEnumerable
{
	[DispId(0)]
	Style this[[In][MarshalAs(UnmanagedType.Struct)] ref object Index]
	{
		[DispId(0)]
		[return: MarshalAs(UnmanagedType.Interface)]
		get;
	}

	void _VtblGap1_5();
}
