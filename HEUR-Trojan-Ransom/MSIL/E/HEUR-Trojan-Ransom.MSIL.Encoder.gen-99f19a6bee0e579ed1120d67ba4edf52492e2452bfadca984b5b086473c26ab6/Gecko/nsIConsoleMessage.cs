using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("3aba9617-10e2-4839-83ae-2e6fc4df428b")]
public interface nsIConsoleMessage
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	uint GetLogLevelAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	long GetTimeStampAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.WStringMarshaler")]
	string GetMessageAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void ToString([MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase retval);
}
