using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("e6cd620a-edbb-41d2-9e42-9a2ffc8107f3")]
public interface nsIVersionComparator
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	int Compare([MarshalAs(UnmanagedType.LPStruct)] nsACStringBase A, [MarshalAs(UnmanagedType.LPStruct)] nsACStringBase B);
}
