using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("52cbb839-6e63-4a70-b21a-1db4ca706c49")]
public interface imgIContainerDebug
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	uint GetFramesNotifiedAttribute();
}
