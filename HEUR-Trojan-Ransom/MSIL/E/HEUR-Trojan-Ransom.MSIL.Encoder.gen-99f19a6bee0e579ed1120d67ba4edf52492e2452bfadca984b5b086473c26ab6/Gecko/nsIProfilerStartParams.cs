using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[Guid("0a175ba7-8fcf-4ce9-9c4b-ccc6272f4425")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public interface nsIProfilerStartParams
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	uint GetEntriesAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetEntriesAttribute(uint aEntries);

	[MethodImpl(MethodImplOptions.InternalCall)]
	double GetIntervalAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetIntervalAttribute(double aInterval);

	[MethodImpl(MethodImplOptions.InternalCall)]
	IntPtr GetFeatures();

	[MethodImpl(MethodImplOptions.InternalCall)]
	IntPtr GetThreadFilterNames();
}
