using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[Guid("73e6ff4a-ab99-4d99-ac00-ba39ccb8e4d7")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public interface nsIXPConnectJSObjectHolder
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	IntPtr GetJSObject();
}
