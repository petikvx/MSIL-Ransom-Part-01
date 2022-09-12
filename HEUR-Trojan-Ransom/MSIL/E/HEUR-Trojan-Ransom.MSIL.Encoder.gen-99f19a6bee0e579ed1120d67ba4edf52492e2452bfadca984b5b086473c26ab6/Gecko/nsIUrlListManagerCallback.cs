using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("fa4caf12-d057-4e7e-81e9-ce066ceee90b")]
public interface nsIUrlListManagerCallback
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	void HandleEvent([MarshalAs(UnmanagedType.LPStruct)] nsACStringBase value);
}
