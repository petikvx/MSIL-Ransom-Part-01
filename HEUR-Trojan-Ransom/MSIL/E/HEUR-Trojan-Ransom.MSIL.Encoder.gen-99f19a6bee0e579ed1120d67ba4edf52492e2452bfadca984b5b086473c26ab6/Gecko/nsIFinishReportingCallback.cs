using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[Guid("548b3909-c04d-4ca6-8466-b8bee3837457")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public interface nsIFinishReportingCallback
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	void Callback([MarshalAs(UnmanagedType.Interface)] nsISupports data);
}
