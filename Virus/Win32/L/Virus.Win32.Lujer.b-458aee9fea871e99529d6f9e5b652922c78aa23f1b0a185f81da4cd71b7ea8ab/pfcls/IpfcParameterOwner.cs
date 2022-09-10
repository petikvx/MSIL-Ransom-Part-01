using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace pfcls;

[ComImport]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[TypeIdentifier]
[CompilerGenerated]
[Guid("D90E995D-AF01-3193-83CD-2AE5A600CEC4")]
public interface IpfcParameterOwner
{
	[return: MarshalAs(UnmanagedType.Interface)]
	IpfcParameter GetParam([In][MarshalAs(UnmanagedType.BStr)] string _Name);
}
