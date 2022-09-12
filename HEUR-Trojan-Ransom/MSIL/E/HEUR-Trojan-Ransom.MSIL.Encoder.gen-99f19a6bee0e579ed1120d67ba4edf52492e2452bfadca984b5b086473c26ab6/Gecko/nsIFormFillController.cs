using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("07f0a0dc-f6e9-4cdd-a55f-56d770523a4c")]
public interface nsIFormFillController
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	void AttachToBrowser([MarshalAs(UnmanagedType.Interface)] nsIDocShell docShell, [MarshalAs(UnmanagedType.Interface)] nsIAutoCompletePopup popup);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void DetachFromBrowser([MarshalAs(UnmanagedType.Interface)] nsIDocShell docShell);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void MarkAsLoginManagerField([MarshalAs(UnmanagedType.Interface)] nsIDOMHTMLInputElement aInput);
}
