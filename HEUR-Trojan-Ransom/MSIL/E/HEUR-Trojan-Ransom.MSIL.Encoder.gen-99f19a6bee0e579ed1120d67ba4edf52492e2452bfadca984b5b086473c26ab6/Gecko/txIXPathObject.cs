using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[Guid("67706346-dece-4c9b-9fc2-57cf19071014")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public interface txIXPathObject
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	IntPtr GetResult();
}
