using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("e439d3eb-b1ed-449c-aaf7-c693e399b16f")]
public interface nsIPrintStatusFeedback
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	void ShowStatusString([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.WStringMarshaler")] string status);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void StartMeteors();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void StopMeteors();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void ShowProgress(int percent);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetDocShell([MarshalAs(UnmanagedType.Interface)] nsIDocShell shell, [MarshalAs(UnmanagedType.Interface)] nsIDOMWindow window);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void CloseWindow();
}
