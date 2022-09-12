using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[Guid("9bd6fdb0-1dd1-11b2-9101-d15375968230")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public interface nsIRandomAccessIterator
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsISupports GetElement();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsISupports GetElementAt(int anOffset);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void PutElement([MarshalAs(UnmanagedType.Interface)] nsISupports anElementToPut);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void PutElementAt(int anOffset, [MarshalAs(UnmanagedType.Interface)] nsISupports anElementToPut);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void StepForward();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void StepForwardBy(int anOffset);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void StepBackward();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void StepBackwardBy(int anOffset);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool IsEqualTo([MarshalAs(UnmanagedType.Interface)] nsISupports anotherIterator);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsISupports Clone();
}
