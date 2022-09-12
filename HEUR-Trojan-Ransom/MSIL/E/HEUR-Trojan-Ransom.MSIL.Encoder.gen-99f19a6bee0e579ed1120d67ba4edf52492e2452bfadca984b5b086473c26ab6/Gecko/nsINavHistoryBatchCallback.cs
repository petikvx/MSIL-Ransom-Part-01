using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("5a5a9154-95ac-4e3d-90df-558816297407")]
public interface nsINavHistoryBatchCallback
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	void RunBatched([MarshalAs(UnmanagedType.Interface)] nsISupports aUserData);
}
