using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[Guid("17e595fa-b57a-4933-bd0f-b1812e8ab188")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public interface nsIHashable
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool Equals([MarshalAs(UnmanagedType.Interface)] nsIHashable aOther);

	[MethodImpl(MethodImplOptions.InternalCall)]
	uint GetHashCodeAttribute();
}
