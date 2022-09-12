using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[Guid("e30d94b0-4a1c-11d3-9890-006008962422")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public interface nsISupportsPRInt16 : nsISupportsPrimitive
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	new ushort GetTypeAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	short GetDataAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetDataAttribute(short aData);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.StringMarshaler")]
	new string ToString();
}
