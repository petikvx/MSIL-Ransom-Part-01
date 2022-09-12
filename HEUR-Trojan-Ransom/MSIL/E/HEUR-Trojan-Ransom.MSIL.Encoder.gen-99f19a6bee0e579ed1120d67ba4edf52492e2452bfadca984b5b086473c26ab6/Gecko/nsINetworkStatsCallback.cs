using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("9c128e68-5e4b-4626-bb88-84ec54cce5d8")]
public interface nsINetworkStatsCallback
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	void NetworkStatsAvailable([MarshalAs(UnmanagedType.U1)] bool success, uint rxBytes, uint txBytes, ulong timestamp);
}
