using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[Guid("7330650e-1dd2-11b2-a0c2-9ff86ee97bed")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public interface nsIOutputIterator
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	void PutElement([MarshalAs(UnmanagedType.Interface)] nsISupports anElementToPut);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void StepForward();
}
