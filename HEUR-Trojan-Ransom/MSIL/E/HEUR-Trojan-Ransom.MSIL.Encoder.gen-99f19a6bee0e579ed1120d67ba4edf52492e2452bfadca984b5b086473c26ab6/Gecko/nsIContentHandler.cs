using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("49439df2-b3d2-441c-bf62-866bdaf56fd2")]
public interface nsIContentHandler
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	void HandleContent([MarshalAs(UnmanagedType.LPStr)] string aContentType, [MarshalAs(UnmanagedType.Interface)] nsIInterfaceRequestor aWindowContext, [MarshalAs(UnmanagedType.Interface)] nsIRequest aRequest);
}
