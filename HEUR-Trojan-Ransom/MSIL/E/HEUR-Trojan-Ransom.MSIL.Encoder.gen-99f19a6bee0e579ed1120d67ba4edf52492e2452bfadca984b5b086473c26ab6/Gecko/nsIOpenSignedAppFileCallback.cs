using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("fc2b60e5-9a07-47c2-a2cd-b83b68a660ac")]
public interface nsIOpenSignedAppFileCallback
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	void OpenSignedAppFileFinished(int rv, [MarshalAs(UnmanagedType.Interface)] nsIZipReader aZipReader, [MarshalAs(UnmanagedType.Interface)] nsIX509Cert aSignerCert);
}
