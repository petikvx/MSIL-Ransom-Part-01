using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[Guid("08923af1-e7a3-4fae-ba02-128502193994")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public interface nsIProfileUnlocker
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	void Unlock(uint aSeverity);
}
