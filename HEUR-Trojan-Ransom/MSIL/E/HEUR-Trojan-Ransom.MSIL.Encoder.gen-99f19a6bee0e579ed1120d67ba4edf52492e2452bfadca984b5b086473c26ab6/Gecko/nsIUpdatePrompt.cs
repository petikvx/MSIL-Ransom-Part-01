using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[Guid("599fd3c6-ec68-4499-ada5-2997739c97a6")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public interface nsIUpdatePrompt
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	void CheckForUpdates();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void ShowUpdateAvailable([MarshalAs(UnmanagedType.Interface)] nsIUpdate update);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void ShowUpdateDownloaded([MarshalAs(UnmanagedType.Interface)] nsIUpdate update, [MarshalAs(UnmanagedType.U1)] bool background);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void ShowUpdateInstalled();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void ShowUpdateError([MarshalAs(UnmanagedType.Interface)] nsIUpdate update);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void ShowUpdateHistory([MarshalAs(UnmanagedType.Interface)] nsIDOMWindow parent);
}
