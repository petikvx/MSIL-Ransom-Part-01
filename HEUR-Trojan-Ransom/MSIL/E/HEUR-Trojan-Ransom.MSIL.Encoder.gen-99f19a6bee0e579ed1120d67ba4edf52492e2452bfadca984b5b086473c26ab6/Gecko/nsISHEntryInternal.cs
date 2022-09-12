using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("bb66ac35-253b-471f-a317-3ece940f04c5")]
public interface nsISHEntryInternal
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	void RemoveFromBFCacheAsync();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void RemoveFromBFCacheSync();

	[MethodImpl(MethodImplOptions.InternalCall)]
	uint GetLastTouchedAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetLastTouchedAttribute(uint aLastTouched);

	[MethodImpl(MethodImplOptions.InternalCall)]
	IntPtr GetSharedState();
}
