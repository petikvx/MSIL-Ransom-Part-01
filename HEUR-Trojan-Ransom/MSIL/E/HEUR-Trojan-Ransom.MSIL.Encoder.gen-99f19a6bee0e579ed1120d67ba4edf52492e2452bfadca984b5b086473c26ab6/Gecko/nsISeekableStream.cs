using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[Guid("8429d350-1040-4661-8b71-f2a6ba455980")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public interface nsISeekableStream
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	void Seek(int whence, long offset);

	[MethodImpl(MethodImplOptions.InternalCall)]
	int Tell();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetEOF();
}
