using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("62f6c5be-ea8c-4fab-8e5c-d1580b50ec3f")]
public interface nsISecureBrowserUI
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	void Init([MarshalAs(UnmanagedType.Interface)] nsIDOMWindow window);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetDocShell([MarshalAs(UnmanagedType.Interface)] nsIDocShell docShell);

	[MethodImpl(MethodImplOptions.InternalCall)]
	uint GetStateAttribute();
}
