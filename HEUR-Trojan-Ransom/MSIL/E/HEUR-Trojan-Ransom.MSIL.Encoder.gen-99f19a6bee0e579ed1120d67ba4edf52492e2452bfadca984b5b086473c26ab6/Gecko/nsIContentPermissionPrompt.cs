using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[Guid("F72DE90D-E954-4E69-9A61-917303029301")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public interface nsIContentPermissionPrompt
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	void Prompt([MarshalAs(UnmanagedType.Interface)] nsIContentPermissionRequest request);
}
