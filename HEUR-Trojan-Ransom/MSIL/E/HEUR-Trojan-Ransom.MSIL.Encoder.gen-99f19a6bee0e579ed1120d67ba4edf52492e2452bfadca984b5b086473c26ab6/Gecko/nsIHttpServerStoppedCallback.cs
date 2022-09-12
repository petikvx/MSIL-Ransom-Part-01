using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("925a6d33-9937-4c63-abe1-a1c56a986455")]
public interface nsIHttpServerStoppedCallback
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	void OnStopped();
}
