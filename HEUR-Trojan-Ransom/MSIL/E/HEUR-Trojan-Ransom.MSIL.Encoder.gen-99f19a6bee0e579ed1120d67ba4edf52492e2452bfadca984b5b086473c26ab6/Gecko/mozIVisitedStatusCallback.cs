using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[Guid("994092bf-936f-449b-8dd6-0941e024360d")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public interface mozIVisitedStatusCallback
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	void IsVisited([MarshalAs(UnmanagedType.Interface)] nsIURI aURI, [MarshalAs(UnmanagedType.U1)] bool aVisitedStatus);
}
