using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("8da01646-1dd2-11b2-98a7-c7009045be7e")]
public interface nsIForwardIterator
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsISupports GetElement();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void PutElement([MarshalAs(UnmanagedType.Interface)] nsISupports anElementToPut);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void StepForward();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool IsEqualTo([MarshalAs(UnmanagedType.Interface)] nsISupports anotherIterator);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsISupports Clone();
}
