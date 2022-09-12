using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[Guid("07f679e4-9601-4bd1-b510-cd3852edb881")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public interface nsIFileMetadata
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	long GetSizeAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	long GetLastModifiedAttribute();
}
