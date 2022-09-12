using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[Guid("033A1470-8B2A-11d3-AF88-00A024FFC08C")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public interface nsIInterfaceRequestor
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	IntPtr GetInterface(ref Guid uuid);
}
