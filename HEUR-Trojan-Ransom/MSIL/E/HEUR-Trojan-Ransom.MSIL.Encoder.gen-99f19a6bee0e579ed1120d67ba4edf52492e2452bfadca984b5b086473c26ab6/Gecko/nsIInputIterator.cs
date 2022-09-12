using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[Guid("85585e12-1dd2-11b2-a930-f6929058269a")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public interface nsIInputIterator
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsISupports GetElement();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void StepForward();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool IsEqualTo([MarshalAs(UnmanagedType.Interface)] nsISupports anotherIterator);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsISupports Clone();
}
