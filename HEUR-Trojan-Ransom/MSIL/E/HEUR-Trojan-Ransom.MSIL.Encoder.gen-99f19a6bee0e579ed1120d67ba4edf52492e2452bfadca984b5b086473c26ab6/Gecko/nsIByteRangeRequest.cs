using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[Guid("C1B1F426-7E83-4759-9F88-0E1B17F49366")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public interface nsIByteRangeRequest
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool GetIsByteRangeRequestAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	long GetStartRangeAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	long GetEndRangeAttribute();
}
