using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[Guid("4b71113a-cb0d-479f-8ed5-01daeba2e8d4")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public interface nsIConverterOutputStream : nsIUnicharOutputStream
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	new bool Write(uint aCount, char[] c);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	new bool WriteString([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase str);

	[MethodImpl(MethodImplOptions.InternalCall)]
	new void Flush();

	[MethodImpl(MethodImplOptions.InternalCall)]
	new void Close();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void Init([MarshalAs(UnmanagedType.Interface)] nsIOutputStream aOutStream, [MarshalAs(UnmanagedType.LPStr)] string aCharset, uint aBufferSize, char aReplacementCharacter);
}
