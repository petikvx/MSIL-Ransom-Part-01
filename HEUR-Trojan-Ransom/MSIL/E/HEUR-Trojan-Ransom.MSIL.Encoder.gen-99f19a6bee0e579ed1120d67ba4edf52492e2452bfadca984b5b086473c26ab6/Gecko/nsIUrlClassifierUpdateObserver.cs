using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("9fa11561-5816-4e1b-bcc9-b629ca05cce6")]
public interface nsIUrlClassifierUpdateObserver
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	void UpdateUrlRequested([MarshalAs(UnmanagedType.LPStruct)] nsACStringBase url, [MarshalAs(UnmanagedType.LPStruct)] nsACStringBase table);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void StreamFinished(int status, uint delay);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void UpdateError(int error);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void UpdateSuccess(uint requestedTimeout);
}
