using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("8238cd2e-e8e3-43e8-b556-56e21389c766")]
public interface nsISimpleUnicharStreamFactory
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIUnicharInputStream CreateInstanceFromString([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aString);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIUnicharInputStream CreateInstanceFromUTF8Stream([MarshalAs(UnmanagedType.Interface)] nsIInputStream aStream);
}
