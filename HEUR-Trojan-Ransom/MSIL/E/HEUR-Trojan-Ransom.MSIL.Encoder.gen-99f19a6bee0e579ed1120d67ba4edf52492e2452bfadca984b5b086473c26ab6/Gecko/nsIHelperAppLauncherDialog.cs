using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[Guid("bfc739f3-8d75-4034-a6f8-1039a5996bad")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public interface nsIHelperAppLauncherDialog
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	void Show([MarshalAs(UnmanagedType.Interface)] nsIHelperAppLauncher aLauncher, [MarshalAs(UnmanagedType.Interface)] nsISupports aWindowContext, uint aReason);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void PromptForSaveToFileAsync([MarshalAs(UnmanagedType.Interface)] nsIHelperAppLauncher aLauncher, [MarshalAs(UnmanagedType.Interface)] nsISupports aWindowContext, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.WStringMarshaler")] string aDefaultFileName, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.WStringMarshaler")] string aSuggestedFileExtension, [MarshalAs(UnmanagedType.U1)] bool aForcePrompt);
}
