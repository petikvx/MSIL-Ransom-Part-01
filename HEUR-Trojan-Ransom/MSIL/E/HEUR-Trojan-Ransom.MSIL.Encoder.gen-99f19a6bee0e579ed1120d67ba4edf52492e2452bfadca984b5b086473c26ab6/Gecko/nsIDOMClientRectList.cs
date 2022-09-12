using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[Guid("f474c567-cbcb-458f-abad-ae42363da287")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public interface nsIDOMClientRectList
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	uint GetLengthAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIDOMClientRect Item(uint index);
}
