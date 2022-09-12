using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[Guid("8712a243-5539-447c-9f47-8653f40c3a09")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public interface nsIKeygenThread
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	void StartKeyGeneration([MarshalAs(UnmanagedType.Interface)] nsIObserver observer);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void UserCanceled([MarshalAs(UnmanagedType.U1)] ref bool threadAlreadyClosedDialog);
}
