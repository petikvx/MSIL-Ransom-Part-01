using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("2362d97a-747a-4576-8863-697667309209")]
public interface nsIRandomGenerator
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	void GenerateRandomBytes(uint aLength, out IntPtr aBuffer);
}
