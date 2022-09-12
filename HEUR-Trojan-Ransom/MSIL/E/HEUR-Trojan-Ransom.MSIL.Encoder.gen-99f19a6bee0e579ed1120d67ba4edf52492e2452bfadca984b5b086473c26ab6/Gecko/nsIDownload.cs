using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("2258f465-656e-4566-87cb-f791dbaf0322")]
public interface nsIDownload : nsIWebProgressListener, nsIWebProgressListener2, nsITransfer
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
	new void Init([MarshalAs(UnmanagedType.Interface)] nsIURI aSource, [MarshalAs(UnmanagedType.Interface)] nsIURI aTarget, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aDisplayName, [MarshalAs(UnmanagedType.Interface)] nsIMIMEInfo aMIMEInfo, long startTime, [MarshalAs(UnmanagedType.Interface)] nsIFile aTempFile, [MarshalAs(UnmanagedType.Interface)] nsICancelable aCancelable, [MarshalAs(UnmanagedType.U1)] bool aIsPrivate);

	[MethodImpl(MethodImplOptions.InternalCall)]
	new void SetSha256Hash([MarshalAs(UnmanagedType.LPStruct)] nsACStringBase aHash);

	[MethodImpl(MethodImplOptions.InternalCall)]
	new void SetSignatureInfo([MarshalAs(UnmanagedType.Interface)] nsIArray aSignatureInfo);

	[MethodImpl(MethodImplOptions.InternalCall)]
	new void SetRedirects([MarshalAs(UnmanagedType.Interface)] nsIArray aRedirects);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIFile GetTargetFileAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	int GetPercentCompleteAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	long GetAmountTransferredAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	long GetSizeAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIURI GetSourceAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIURI GetTargetAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsICancelable GetCancelableAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetDisplayNameAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aDisplayName);

	[MethodImpl(MethodImplOptions.InternalCall)]
	long GetStartTimeAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	double GetSpeedAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIMIMEInfo GetMIMEInfoAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	uint GetIdAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetGuidAttribute([MarshalAs(UnmanagedType.LPStruct)] nsACStringBase aGuid);

	[MethodImpl(MethodImplOptions.InternalCall)]
	short GetStateAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIURI GetReferrerAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool GetResumableAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool GetIsPrivateAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void Cancel();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void Pause();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void Resume();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void Remove();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void Retry();
}
