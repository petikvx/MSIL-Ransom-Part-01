using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("2d00b1bb-8b21-4a63-bcc6-7213f513ac2e")]
public interface nsIUnicharOutputStream
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool Write(uint aCount, char[] c);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool WriteString([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase str);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void Flush();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void Close();
}
