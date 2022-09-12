using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("e4f0e59c-b922-48b0-a7b6-1735c1f96fed")]
public interface nsIUrlClassifierUtils
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetKeyForURI([MarshalAs(UnmanagedType.Interface)] nsIURI uri, [MarshalAs(UnmanagedType.LPStruct)] nsACStringBase retval);
}
