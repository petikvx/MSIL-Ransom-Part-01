using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[Guid("a2240f6a-f1e4-4548-9e1a-6f3bc9b2426c")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public interface nsIRemoteService
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	void Startup([MarshalAs(UnmanagedType.LPStr)] string appName, [MarshalAs(UnmanagedType.LPStr)] string profileName);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void RegisterWindow([MarshalAs(UnmanagedType.Interface)] nsIDOMWindow aWindow);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void Shutdown();
}
