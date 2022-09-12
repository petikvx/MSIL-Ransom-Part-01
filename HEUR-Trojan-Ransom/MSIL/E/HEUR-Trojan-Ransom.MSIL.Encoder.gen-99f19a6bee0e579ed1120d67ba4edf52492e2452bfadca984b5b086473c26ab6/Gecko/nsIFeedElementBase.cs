using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[Guid("5215291e-fa0a-40c2-8ce7-e86cd1a1d3fa")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public interface nsIFeedElementBase
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsISAXAttributes GetAttributesAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetAttributesAttribute([MarshalAs(UnmanagedType.Interface)] nsISAXAttributes aAttributes);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIURI GetBaseURIAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetBaseURIAttribute([MarshalAs(UnmanagedType.Interface)] nsIURI aBaseURI);
}
