using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[Guid("27d49bfe-280c-49e0-bbaa-f6200c232c3d")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public interface nsIDNSListener
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	void OnLookupComplete([MarshalAs(UnmanagedType.Interface)] nsICancelable aRequest, [MarshalAs(UnmanagedType.Interface)] nsIDNSRecord aRecord, int aStatus);
}
