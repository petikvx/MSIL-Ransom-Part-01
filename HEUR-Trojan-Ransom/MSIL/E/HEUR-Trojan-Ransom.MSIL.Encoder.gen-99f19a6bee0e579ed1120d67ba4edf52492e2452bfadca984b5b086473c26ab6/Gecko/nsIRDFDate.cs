using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("E13A24E1-C77A-11d2-80BE-006097B76B8E")]
public interface nsIRDFDate : nsIRDFNode
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	new bool EqualsNode([MarshalAs(UnmanagedType.Interface)] nsIRDFNode aNode);

	[MethodImpl(MethodImplOptions.InternalCall)]
	long GetValueAttribute();
}
