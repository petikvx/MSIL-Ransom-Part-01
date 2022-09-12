using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[Guid("651395EB-8612-4876-8AC0-A88D4DCE9E1E")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public interface nsIAuthPrompt2
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool PromptAuth([MarshalAs(UnmanagedType.Interface)] nsIChannel aChannel, uint level, [MarshalAs(UnmanagedType.Interface)] nsIAuthInformation authInfo);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsICancelable AsyncPromptAuth([MarshalAs(UnmanagedType.Interface)] nsIChannel aChannel, [MarshalAs(UnmanagedType.Interface)] nsIAuthPromptCallback aCallback, [MarshalAs(UnmanagedType.Interface)] nsISupports aContext, uint level, [MarshalAs(UnmanagedType.Interface)] nsIAuthInformation authInfo);
}
