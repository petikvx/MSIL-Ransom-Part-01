using System.Collections;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Microsoft.Office.Interop.Word;

[ComImport]
[CompilerGenerated]
[TypeIdentifier]
[Guid("0002094C-0000-0000-C000-000000000046")]
public interface Rows : IEnumerable
{
	[DispId(0)]
	Row this[[In] int Index]
	{
		[DispId(0)]
		[return: MarshalAs(UnmanagedType.Interface)]
		get;
	}

	void _VtblGap1_24();
}
