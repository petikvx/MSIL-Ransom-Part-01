using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[Guid("37ec75d3-97ad-4da8-afaa-eabe5b4afd73")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public interface nsITransfer : nsIWebProgressListener, nsIWebProgressListener2
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
	new void OnProgressChange64([MarshalAs(UnmanagedType.Interface)] nsIWebProgress aWebProgress, [MarshalAs(UnmanagedType.Interface)] nsIRequest aRequest, long aCurSelfProgress, long aMaxSelfProgress, long aCurTotalProgress, long aMaxTotalProgress);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	new bool OnRefreshAttempted([MarshalAs(UnmanagedType.Interface)] nsIWebProgress aWebProgress, [MarshalAs(UnmanagedType.Interface)] nsIURI aRefreshURI, int aMillis, [MarshalAs(UnmanagedType.U1)] bool aSameURI);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void Init([MarshalAs(UnmanagedType.Interface)] nsIURI aSource, [MarshalAs(UnmanagedType.Interface)] nsIURI aTarget, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aDisplayName, [MarshalAs(UnmanagedType.Interface)] nsIMIMEInfo aMIMEInfo, long startTime, [MarshalAs(UnmanagedType.Interface)] nsIFile aTempFile, [MarshalAs(UnmanagedType.Interface)] nsICancelable aCancelable, [MarshalAs(UnmanagedType.U1)] bool aIsPrivate);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetSha256Hash([MarshalAs(UnmanagedType.LPStruct)] nsACStringBase aHash);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetSignatureInfo([MarshalAs(UnmanagedType.Interface)] nsIArray aSignatureInfo);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetRedirects([MarshalAs(UnmanagedType.Interface)] nsIArray aRedirects);
}
