using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("d65ff270-4a1c-11d3-9890-006008962422")]
public interface nsISupportsCString : nsISupportsPrimitive
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	new ushort GetTypeAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetDataAttribute([MarshalAs(UnmanagedType.LPStruct)] nsACStringBase aData);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetDataAttribute([MarshalAs(UnmanagedType.LPStruct)] nsACStringBase aData);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.StringMarshaler")]
	new string ToString();
}
