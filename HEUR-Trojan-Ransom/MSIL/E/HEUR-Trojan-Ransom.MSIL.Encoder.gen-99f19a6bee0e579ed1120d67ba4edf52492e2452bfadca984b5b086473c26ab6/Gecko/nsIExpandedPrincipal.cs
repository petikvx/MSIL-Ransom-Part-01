using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("f3e177Df-6a5e-489f-80a7-2dd1481471d8")]
public interface nsIExpandedPrincipal
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	IntPtr GetWhiteListAttribute();
}
