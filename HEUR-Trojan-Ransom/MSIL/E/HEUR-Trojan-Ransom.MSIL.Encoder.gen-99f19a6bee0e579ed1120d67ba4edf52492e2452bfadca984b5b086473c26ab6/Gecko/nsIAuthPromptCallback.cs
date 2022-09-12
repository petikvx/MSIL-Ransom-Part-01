using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("bdc387d7-2d29-4cac-92f1-dd75d786631d")]
public interface nsIAuthPromptCallback
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	void OnAuthAvailable([MarshalAs(UnmanagedType.Interface)] nsISupports aContext, [MarshalAs(UnmanagedType.Interface)] nsIAuthInformation aAuthInfo);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void OnAuthCancelled([MarshalAs(UnmanagedType.Interface)] nsISupports aContext, [MarshalAs(UnmanagedType.U1)] bool userCancel);
}
