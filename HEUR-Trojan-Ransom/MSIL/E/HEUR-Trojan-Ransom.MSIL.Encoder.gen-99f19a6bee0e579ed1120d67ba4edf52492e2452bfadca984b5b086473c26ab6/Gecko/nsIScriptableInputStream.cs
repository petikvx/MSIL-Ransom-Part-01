using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("3fce9015-472a-4080-ac3e-cd875dbe361e")]
public interface nsIScriptableInputStream
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	void Close();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void Init([MarshalAs(UnmanagedType.Interface)] nsIInputStream aInputStream);

	[MethodImpl(MethodImplOptions.InternalCall)]
	uint Available();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.StringMarshaler")]
	string Read(uint aCount);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void ReadBytes(uint aCount, [MarshalAs(UnmanagedType.LPStruct)] nsACStringBase retval);
}
