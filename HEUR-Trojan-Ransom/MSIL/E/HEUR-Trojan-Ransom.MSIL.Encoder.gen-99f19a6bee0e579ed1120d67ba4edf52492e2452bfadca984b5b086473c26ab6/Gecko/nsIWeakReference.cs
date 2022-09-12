using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[Guid("9188bc85-f92e-11d2-81ef-0060083a0bcf")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public interface nsIWeakReference
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	IntPtr QueryReferent(ref Guid uuid);
}
