using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("0765c92c-6145-4253-9db4-594d8023087e")]
public interface nsIUpdateTimerManager
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	void RegisterTimer([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase id, [MarshalAs(UnmanagedType.Interface)] nsITimerCallback callback, uint interval);
}
