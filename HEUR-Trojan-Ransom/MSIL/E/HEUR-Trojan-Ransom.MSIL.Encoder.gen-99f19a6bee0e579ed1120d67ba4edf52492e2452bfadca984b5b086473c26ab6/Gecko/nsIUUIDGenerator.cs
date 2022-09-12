using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[Guid("138ad1b2-c694-41cc-b201-333ce936d8b8")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public interface nsIUUIDGenerator
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	IntPtr GenerateUUID();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GenerateUUIDInPlace(IntPtr id);
}
