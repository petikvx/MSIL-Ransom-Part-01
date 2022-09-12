using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[Guid("e2b05e40-4a1c-11d3-9890-006008962422")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public interface nsISupportsChar : nsISupportsPrimitive
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	new ushort GetTypeAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	char GetDataAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetDataAttribute(char aData);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.StringMarshaler")]
	new string ToString();
}
