using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[Guid("8cd752a4-60b1-42c3-a819-65c7a1138a28")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public interface nsIWebBrowserPersist : nsICancelable
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	new void Cancel(int aReason);

	[MethodImpl(MethodImplOptions.InternalCall)]
	uint GetPersistFlagsAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetPersistFlagsAttribute(uint aPersistFlags);

	[MethodImpl(MethodImplOptions.InternalCall)]
	uint GetCurrentStateAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	int GetResultAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIWebProgressListener GetProgressListenerAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetProgressListenerAttribute([MarshalAs(UnmanagedType.Interface)] nsIWebProgressListener aProgressListener);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SaveURI([MarshalAs(UnmanagedType.Interface)] nsIURI aURI, [MarshalAs(UnmanagedType.Interface)] nsISupports aCacheKey, [MarshalAs(UnmanagedType.Interface)] nsIURI aReferrer, uint aReferrerPolicy, [MarshalAs(UnmanagedType.Interface)] nsIInputStream aPostData, [MarshalAs(UnmanagedType.LPStr)] string aExtraHeaders, [MarshalAs(UnmanagedType.Interface)] nsISupports aFile, [MarshalAs(UnmanagedType.Interface)] nsILoadContext aPrivacyContext);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SavePrivacyAwareURI([MarshalAs(UnmanagedType.Interface)] nsIURI aURI, [MarshalAs(UnmanagedType.Interface)] nsISupports aCacheKey, [MarshalAs(UnmanagedType.Interface)] nsIURI aReferrer, uint aReferrerPolicy, [MarshalAs(UnmanagedType.Interface)] nsIInputStream aPostData, [MarshalAs(UnmanagedType.LPStr)] string aExtraHeaders, [MarshalAs(UnmanagedType.Interface)] nsISupports aFile, [MarshalAs(UnmanagedType.U1)] bool aIsPrivate);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SaveChannel([MarshalAs(UnmanagedType.Interface)] nsIChannel aChannel, [MarshalAs(UnmanagedType.Interface)] nsISupports aFile);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SaveDocument([MarshalAs(UnmanagedType.Interface)] nsISupports aDocument, [MarshalAs(UnmanagedType.Interface)] nsISupports aFile, [MarshalAs(UnmanagedType.Interface)] nsISupports aDataPath, [MarshalAs(UnmanagedType.LPStr)] string aOutputContentType, uint aEncodingFlags, uint aWrapColumn);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void CancelSave();
}
