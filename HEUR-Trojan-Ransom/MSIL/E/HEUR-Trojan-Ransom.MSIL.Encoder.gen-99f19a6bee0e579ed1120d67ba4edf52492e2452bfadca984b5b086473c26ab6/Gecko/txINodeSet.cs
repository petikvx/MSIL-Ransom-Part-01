using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[Guid("15d424c0-6b47-11d9-9791-000a95dc234c")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public interface txINodeSet
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIDOMNode Item(uint index);

	[MethodImpl(MethodImplOptions.InternalCall)]
	double ItemAsNumber(uint index);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void ItemAsString(uint index, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase retval);

	[MethodImpl(MethodImplOptions.InternalCall)]
	uint GetLengthAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void Add([MarshalAs(UnmanagedType.Interface)] nsIDOMNode node);
}
