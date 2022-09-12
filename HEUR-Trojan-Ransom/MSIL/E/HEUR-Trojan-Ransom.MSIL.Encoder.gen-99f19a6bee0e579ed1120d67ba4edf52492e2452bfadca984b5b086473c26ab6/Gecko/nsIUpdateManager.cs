using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[Guid("f8371237-10a6-46a5-b23f-f6f7684e9d71")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public interface nsIUpdateManager
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIUpdate GetUpdateAt(int index);

	[MethodImpl(MethodImplOptions.InternalCall)]
	int GetUpdateCountAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIUpdate GetActiveUpdateAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetActiveUpdateAttribute([MarshalAs(UnmanagedType.Interface)] nsIUpdate aActiveUpdate);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SaveUpdates();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void RefreshUpdateStatus();
}
