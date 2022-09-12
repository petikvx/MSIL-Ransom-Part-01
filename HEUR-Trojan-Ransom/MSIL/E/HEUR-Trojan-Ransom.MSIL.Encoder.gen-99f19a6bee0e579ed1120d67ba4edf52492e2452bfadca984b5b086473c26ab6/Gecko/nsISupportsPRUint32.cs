using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[Guid("e01dc470-4a1c-11d3-9890-006008962422")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public interface nsISupportsPRUint32 : nsISupportsPrimitive
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	new ushort GetTypeAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	uint GetDataAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetDataAttribute(uint aData);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.StringMarshaler")]
	new string ToString();
}
