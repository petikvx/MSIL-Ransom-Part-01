using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[Guid("594fd36d-5b1b-412f-a74e-ab72099a5bb2")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public interface nsIPrintProgress : nsIWebProgressListener
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	new void OnStateChange([MarshalAs(UnmanagedType.Interface)] nsIWebProgress aWebProgress, [MarshalAs(UnmanagedType.Interface)] nsIRequest aRequest, uint aStateFlags, int aStatus);

	[MethodImpl(MethodImplOptions.InternalCall)]
	new void OnProgressChange([MarshalAs(UnmanagedType.Interface)] nsIWebProgress aWebProgress, [MarshalAs(UnmanagedType.Interface)] nsIRequest aRequest, int aCurSelfProgress, int aMaxSelfProgress, int aCurTotalProgress, int aMaxTotalProgress);

	[MethodImpl(MethodImplOptions.InternalCall)]
	new void OnLocationChange([MarshalAs(UnmanagedType.Interface)] nsIWebProgress aWebProgress, [MarshalAs(UnmanagedType.Interface)] nsIRequest aRequest, [MarshalAs(UnmanagedType.Interface)] nsIURI aLocation, uint aFlags);

	[MethodImpl(MethodImplOptions.InternalCall)]
	new void OnStatusChange([MarshalAs(UnmanagedType.Interface)] nsIWebProgress aWebProgress, [MarshalAs(UnmanagedType.Interface)] nsIRequest aRequest, int aStatus, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.WStringMarshaler")] string aMessage);

	[MethodImpl(MethodImplOptions.InternalCall)]
	new void OnSecurityChange([MarshalAs(UnmanagedType.Interface)] nsIWebProgress aWebProgress, [MarshalAs(UnmanagedType.Interface)] nsIRequest aRequest, uint aState);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void OpenProgressDialog([MarshalAs(UnmanagedType.Interface)] nsIDOMWindow parent, [MarshalAs(UnmanagedType.LPStr)] string dialogURL, [MarshalAs(UnmanagedType.Interface)] nsISupports parameters, [MarshalAs(UnmanagedType.Interface)] nsIObserver openDialogObserver, [MarshalAs(UnmanagedType.U1)] ref bool notifyOnOpen);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void CloseProgressDialog([MarshalAs(UnmanagedType.U1)] bool forceClose);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void RegisterListener([MarshalAs(UnmanagedType.Interface)] nsIWebProgressListener listener);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void UnregisterListener([MarshalAs(UnmanagedType.Interface)] nsIWebProgressListener listener);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void DoneIniting();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIPrompt GetPrompter();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool GetProcessCanceledByUserAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetProcessCanceledByUserAttribute([MarshalAs(UnmanagedType.U1)] bool aProcessCanceledByUser);
}
