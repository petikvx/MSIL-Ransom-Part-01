using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[Guid("b903dc8f-dff1-42fe-894b-36e7a59bb801")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public interface nsIUrlClassifierLookupCallback
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	void LookupComplete(IntPtr results);
}
