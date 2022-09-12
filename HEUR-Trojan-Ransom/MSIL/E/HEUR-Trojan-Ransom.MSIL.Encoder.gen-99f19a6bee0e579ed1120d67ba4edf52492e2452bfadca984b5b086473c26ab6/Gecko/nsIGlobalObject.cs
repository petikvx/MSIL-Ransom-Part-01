using System;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[Guid("11afa8be-d997-4e07-a6a3-6f872ec3ee7f")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public interface nsIGlobalObject
{
	IntPtr GetGlobalJSObject();
}
