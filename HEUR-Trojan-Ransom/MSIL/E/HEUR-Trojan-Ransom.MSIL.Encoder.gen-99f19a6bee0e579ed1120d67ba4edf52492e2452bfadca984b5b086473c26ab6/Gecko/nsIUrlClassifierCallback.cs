using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("4ca27b6b-a674-4b3d-ab30-d21e2da2dffb")]
public interface nsIUrlClassifierCallback
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	void HandleEvent([MarshalAs(UnmanagedType.LPStruct)] nsACStringBase value);
}
