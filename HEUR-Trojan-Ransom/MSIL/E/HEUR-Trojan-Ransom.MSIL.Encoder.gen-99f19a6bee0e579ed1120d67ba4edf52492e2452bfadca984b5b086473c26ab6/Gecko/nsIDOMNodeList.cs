using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[Guid("450cf0ba-de90-4f86-85bf-e10cc8b8713f")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public interface nsIDOMNodeList
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIDOMNode Item(uint index);

	[MethodImpl(MethodImplOptions.InternalCall)]
	uint GetLengthAttribute();
}
