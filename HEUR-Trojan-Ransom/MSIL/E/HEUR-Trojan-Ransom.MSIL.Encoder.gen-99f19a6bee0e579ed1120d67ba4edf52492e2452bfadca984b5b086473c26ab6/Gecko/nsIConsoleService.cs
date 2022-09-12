using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("0eb81d20-c37e-42d4-82a8-ca9ae96bdf52")]
public interface nsIConsoleService
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	void LogMessage([MarshalAs(UnmanagedType.Interface)] nsIConsoleMessage message);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void LogStringMessage([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.WStringMarshaler")] string message);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetMessageArray(ref uint count, [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 0)] ref nsIConsoleMessage[] messages);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void RegisterListener([MarshalAs(UnmanagedType.Interface)] nsIConsoleListener listener);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void UnregisterListener([MarshalAs(UnmanagedType.Interface)] nsIConsoleListener listener);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void Reset();
}
