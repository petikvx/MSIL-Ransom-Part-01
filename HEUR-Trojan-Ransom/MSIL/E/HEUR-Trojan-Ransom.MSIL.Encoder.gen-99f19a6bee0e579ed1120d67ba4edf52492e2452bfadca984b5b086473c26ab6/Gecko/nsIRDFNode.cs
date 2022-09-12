using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[Guid("0F78DA50-8321-11d2-8EAC-00805F29F370")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public interface nsIRDFNode
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool EqualsNode([MarshalAs(UnmanagedType.Interface)] nsIRDFNode aNode);
}
