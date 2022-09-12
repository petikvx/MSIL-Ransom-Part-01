using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[Guid("e3d56a20-c7ec-11d3-8cda-0060b0fc14a3")]
public interface nsIFileInputStream : nsIInputStream
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	void Init([MarshalAs(UnmanagedType.Interface)] nsIFile file, int ioFlags, int perm, int behaviorFlags);
}
