using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("2f8896be-232f-4140-afb3-1faffb56f3c6")]
public interface nsICacheEntryDoomCallback
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	void OnCacheEntryDoomed(int aResult);
}
