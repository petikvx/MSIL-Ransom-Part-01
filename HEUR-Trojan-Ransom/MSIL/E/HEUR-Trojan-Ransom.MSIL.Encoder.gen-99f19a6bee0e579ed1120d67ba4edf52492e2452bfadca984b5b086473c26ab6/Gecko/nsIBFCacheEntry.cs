using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("a576060e-c7df-4d81-aa8c-5b52bd6ad25d")]
public interface nsIBFCacheEntry
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	void RemoveFromBFCacheSync();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void RemoveFromBFCacheAsync();

	[MethodImpl(MethodImplOptions.InternalCall)]
	ulong GetIDAttribute();
}
