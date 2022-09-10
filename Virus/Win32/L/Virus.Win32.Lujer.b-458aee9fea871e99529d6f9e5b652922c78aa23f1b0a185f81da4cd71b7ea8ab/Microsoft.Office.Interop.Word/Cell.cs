using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Microsoft.Office.Interop.Word;

[ComImport]
[CompilerGenerated]
[TypeIdentifier]
[DefaultMember("Range")]
[Guid("0002094E-0000-0000-C000-000000000046")]
public interface Cell
{
	[DispId(0)]
	Range Range
	{
		[DispId(0)]
		[return: MarshalAs(UnmanagedType.Interface)]
		get;
	}
}
