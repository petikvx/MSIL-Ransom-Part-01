using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("425f73b9-b2db-4e8a-88c5-9ac2512934ce")]
public interface nsILoginManagerPrompter
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	void Init([MarshalAs(UnmanagedType.Interface)] nsIDOMWindow aWindow);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetE10sData([MarshalAs(UnmanagedType.Interface)] nsIDOMElement aBrowser, [MarshalAs(UnmanagedType.Interface)] nsIDOMWindow aOpener);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void PromptToSavePassword([MarshalAs(UnmanagedType.Interface)] nsILoginInfo aLogin);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void PromptToChangePassword([MarshalAs(UnmanagedType.Interface)] nsILoginInfo aOldLogin, [MarshalAs(UnmanagedType.Interface)] nsILoginInfo aNewLogin);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void PromptToChangePasswordWithUsernames([MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 1)] nsILoginInfo[] logins, uint count, [MarshalAs(UnmanagedType.Interface)] nsILoginInfo aNewLogin);
}
