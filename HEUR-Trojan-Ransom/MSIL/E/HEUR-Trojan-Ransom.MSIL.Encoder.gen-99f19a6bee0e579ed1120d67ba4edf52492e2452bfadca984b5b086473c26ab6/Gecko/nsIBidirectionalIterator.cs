using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[Guid("948defaa-1dd1-11b2-89f6-8ce81f5ebda9")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public interface nsIBidirectionalIterator
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsISupports GetElement();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void PutElement([MarshalAs(UnmanagedType.Interface)] nsISupports anElementToPut);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void StepForward();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void StepBackward();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool IsEqualTo([MarshalAs(UnmanagedType.Interface)] nsISupports anotherIterator);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsISupports Clone();
}
