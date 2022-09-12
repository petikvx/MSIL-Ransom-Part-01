using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("00da7d20-3768-4398-bedc-e310c324b3f0")]
public interface mozIStoragePendingStatement
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	void Cancel();
}
