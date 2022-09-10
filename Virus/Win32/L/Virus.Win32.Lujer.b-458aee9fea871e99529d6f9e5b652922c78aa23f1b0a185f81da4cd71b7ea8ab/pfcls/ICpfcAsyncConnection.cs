using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace pfcls;

[ComImport]
[Guid("B2B5C5CF-984B-3377-A62F-DFB98F79F5CC")]
[TypeIdentifier]
[CompilerGenerated]
public interface ICpfcAsyncConnection
{
	void _VtblGap1_1();

	[DispId(1610743809)]
	[return: MarshalAs(UnmanagedType.Interface)]
	IpfcAsyncConnection Connect([In][MarshalAs(UnmanagedType.Struct)] object _Display, [In][MarshalAs(UnmanagedType.Struct)] object _UserID, [In][MarshalAs(UnmanagedType.Struct)] object _TextPath, [In][MarshalAs(UnmanagedType.Struct)] object _TimeoutSec);
}
