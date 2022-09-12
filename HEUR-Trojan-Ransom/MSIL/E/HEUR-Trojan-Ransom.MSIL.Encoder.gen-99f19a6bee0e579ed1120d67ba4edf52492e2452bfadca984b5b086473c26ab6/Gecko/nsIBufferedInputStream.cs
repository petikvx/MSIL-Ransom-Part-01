using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[Guid("616f5b48-da09-11d3-8cda-0060b0fc14a3")]
public interface nsIBufferedInputStream : nsIInputStream
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	void Init([MarshalAs(UnmanagedType.Interface)] nsIInputStream fillFromStream, uint bufferSize);
}
