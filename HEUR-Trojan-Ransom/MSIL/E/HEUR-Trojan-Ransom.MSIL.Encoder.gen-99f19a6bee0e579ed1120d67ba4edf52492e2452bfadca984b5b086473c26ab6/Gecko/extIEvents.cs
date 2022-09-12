using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[Guid("3a8ec9d0-ab19-11db-abbd-0800200c9a66")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public interface extIEvents
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	void AddListener([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aEvent, extIEventListener aListener);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void RemoveListener([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aEvent, extIEventListener aListener);
}
