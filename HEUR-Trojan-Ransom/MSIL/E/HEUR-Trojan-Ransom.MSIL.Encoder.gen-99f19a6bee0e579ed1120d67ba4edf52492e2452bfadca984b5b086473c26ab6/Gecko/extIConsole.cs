using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[Guid("ae8482e0-aa5a-11db-abbd-0800200c9a66")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public interface extIConsole
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	void Log([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aMsg);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void Open();
}
