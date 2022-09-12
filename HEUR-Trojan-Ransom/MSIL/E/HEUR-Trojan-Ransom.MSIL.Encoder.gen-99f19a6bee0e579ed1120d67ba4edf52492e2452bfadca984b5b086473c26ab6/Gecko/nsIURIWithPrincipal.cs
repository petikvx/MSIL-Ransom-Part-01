using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[Guid("626a5c0c-bfd8-4531-8b47-a8451b0daa33")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public interface nsIURIWithPrincipal
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIPrincipal GetPrincipalAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIURI GetPrincipalUriAttribute();
}
