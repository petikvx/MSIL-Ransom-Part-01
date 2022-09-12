using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[Guid("34A4FCF0-66FC-11d4-9528-0020183BF181")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public interface nsICommandHandler
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.StringMarshaler")]
	string Exec([MarshalAs(UnmanagedType.LPStr)] string aCommand, [MarshalAs(UnmanagedType.LPStr)] string aParameters);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.StringMarshaler")]
	string Query([MarshalAs(UnmanagedType.LPStr)] string aCommand, [MarshalAs(UnmanagedType.LPStr)] string aParameters);
}
