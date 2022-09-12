using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("7728ab5b-4c01-4483-a606-32bf5b8136cb")]
public interface nsICacheStorageConsumptionObserver
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	void OnNetworkCacheDiskConsumption(long aDiskSize);
}
