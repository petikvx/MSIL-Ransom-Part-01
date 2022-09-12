using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[Guid("0c07ffeb-791b-49f3-ae38-2c331fd55a52")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public interface nsIDownloadManagerResult
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	void HandleResult(int aStatus, [MarshalAs(UnmanagedType.Interface)] nsIDownload aDownload);
}
