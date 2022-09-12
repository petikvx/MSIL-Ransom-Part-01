using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[Guid("63adb599-6dc9-4746-972e-c22e9018020b")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public interface nsIDocShell : nsIDocShellTreeItem
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	new void GetNameAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aName);

	[MethodImpl(MethodImplOptions.InternalCall)]
	new void SetNameAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aName);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	new bool NameEquals([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.WStringMarshaler")] string name);

	[MethodImpl(MethodImplOptions.InternalCall)]
	new int GetItemTypeAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	new void SetItemTypeAttribute(int aItemType);

	[MethodImpl(MethodImplOptions.InternalCall)]
	new int ItemType();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	new nsIDocShellTreeItem GetParentAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	new nsIDocShellTreeItem GetSameTypeParentAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	new nsIDocShellTreeItem GetRootTreeItemAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	new nsIDocShellTreeItem GetSameTypeRootTreeItemAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	new nsIDocShellTreeItem FindItemWithName([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.WStringMarshaler")] string name, [MarshalAs(UnmanagedType.Interface)] nsISupports aRequestor, [MarshalAs(UnmanagedType.Interface)] nsIDocShellTreeItem aOriginalRequestor);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	new nsIDocShellTreeOwner GetTreeOwnerAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	new void SetTreeOwner([MarshalAs(UnmanagedType.Interface)] nsIDocShellTreeOwner treeOwner);

	[MethodImpl(MethodImplOptions.InternalCall)]
	new int GetChildCountAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	new void AddChild([MarshalAs(UnmanagedType.Interface)] nsIDocShellTreeItem child);

	[MethodImpl(MethodImplOptions.InternalCall)]
	new void RemoveChild([MarshalAs(UnmanagedType.Interface)] nsIDocShellTreeItem child);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	new nsIDocShellTreeItem GetChildAt(int index);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	new nsIDocShellTreeItem FindChildWithName([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.WStringMarshaler")] string aName, [MarshalAs(UnmanagedType.U1)] bool aRecurse, [MarshalAs(UnmanagedType.U1)] bool aSameType, [MarshalAs(UnmanagedType.Interface)] nsIDocShellTreeItem aRequestor, [MarshalAs(UnmanagedType.Interface)] nsIDocShellTreeItem aOriginalRequestor);

	[MethodImpl(MethodImplOptions.InternalCall)]
	new IntPtr GetDocument();

	[MethodImpl(MethodImplOptions.InternalCall)]
	new IntPtr GetWindow();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void LoadURI([MarshalAs(UnmanagedType.Interface)] nsIURI uri, [MarshalAs(UnmanagedType.Interface)] nsIDocShellLoadInfo loadInfo, uint aLoadFlags, [MarshalAs(UnmanagedType.U1)] bool firstParty);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void LoadStream([MarshalAs(UnmanagedType.Interface)] nsIInputStream aStream, [MarshalAs(UnmanagedType.Interface)] nsIURI aURI, [MarshalAs(UnmanagedType.LPStruct)] nsACStringBase aContentType, [MarshalAs(UnmanagedType.LPStruct)] nsACStringBase aContentCharset, [MarshalAs(UnmanagedType.Interface)] nsIDocShellLoadInfo aLoadInfo);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void InternalLoad([MarshalAs(UnmanagedType.Interface)] nsIURI aURI, [MarshalAs(UnmanagedType.Interface)] nsIURI aOriginalURI, [MarshalAs(UnmanagedType.U1)] bool aLoadReplace, [MarshalAs(UnmanagedType.Interface)] nsIURI aReferrer, uint aReferrerPolicy, [MarshalAs(UnmanagedType.Interface)] nsISupports aOwner, uint aFlags, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.WStringMarshaler")] string aWindowTarget, [MarshalAs(UnmanagedType.LPStr)] string aTypeHint, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aFileName, [MarshalAs(UnmanagedType.Interface)] nsIInputStream aPostDataStream, [MarshalAs(UnmanagedType.Interface)] nsIInputStream aHeadersStream, uint aLoadFlags, [MarshalAs(UnmanagedType.Interface)] nsISHEntry aSHEntry, [MarshalAs(UnmanagedType.U1)] bool firstParty, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aSrcdoc, [MarshalAs(UnmanagedType.Interface)] nsIDocShell aSourceDocShell, [MarshalAs(UnmanagedType.Interface)] nsIURI aBaseURI, [MarshalAs(UnmanagedType.Interface)] ref nsIDocShell aDocShell, [MarshalAs(UnmanagedType.Interface)] ref nsIRequest aRequest);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void AddState(ref JsVal aData, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aTitle, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aURL, [MarshalAs(UnmanagedType.U1)] bool aReplace, IntPtr jsContext);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void CreateLoadInfo([MarshalAs(UnmanagedType.Interface)] ref nsIDocShellLoadInfo loadInfo);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void PrepareForNewContentModel();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetCurrentURI([MarshalAs(UnmanagedType.Interface)] nsIURI aURI);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void FirePageHideNotification([MarshalAs(UnmanagedType.U1)] bool isUnload);

	[MethodImpl(MethodImplOptions.InternalCall)]
	IntPtr GetPresContextAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	IntPtr GetPresShell();

	[MethodImpl(MethodImplOptions.InternalCall)]
	IntPtr GetEldestPresShellAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIContentViewer GetContentViewerAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIDOMEventTarget GetChromeEventHandlerAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetChromeEventHandlerAttribute([MarshalAs(UnmanagedType.Interface)] nsIDOMEventTarget aChromeEventHandler);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool GetAllowPluginsAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetAllowPluginsAttribute([MarshalAs(UnmanagedType.U1)] bool aAllowPlugins);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool GetAllowJavascriptAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetAllowJavascriptAttribute([MarshalAs(UnmanagedType.U1)] bool aAllowJavascript);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool GetAllowMetaRedirectsAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetAllowMetaRedirectsAttribute([MarshalAs(UnmanagedType.U1)] bool aAllowMetaRedirects);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool GetAllowSubframesAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetAllowSubframesAttribute([MarshalAs(UnmanagedType.U1)] bool aAllowSubframes);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool GetAllowImagesAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetAllowImagesAttribute([MarshalAs(UnmanagedType.U1)] bool aAllowImages);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool GetAllowMediaAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetAllowMediaAttribute([MarshalAs(UnmanagedType.U1)] bool aAllowMedia);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool GetAllowDNSPrefetchAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetAllowDNSPrefetchAttribute([MarshalAs(UnmanagedType.U1)] bool aAllowDNSPrefetch);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool GetAllowWindowControlAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetAllowWindowControlAttribute([MarshalAs(UnmanagedType.U1)] bool aAllowWindowControl);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool GetAllowContentRetargetingAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetAllowContentRetargetingAttribute([MarshalAs(UnmanagedType.U1)] bool aAllowContentRetargeting);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool GetAllowContentRetargetingOnChildrenAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetAllowContentRetargetingOnChildrenAttribute([MarshalAs(UnmanagedType.U1)] bool aAllowContentRetargetingOnChildren);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsISimpleEnumerator GetDocShellEnumerator(int aItemType, int aDirection);

	[MethodImpl(MethodImplOptions.InternalCall)]
	uint GetAppTypeAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetAppTypeAttribute(uint aAppType);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool GetAllowAuthAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetAllowAuthAttribute([MarshalAs(UnmanagedType.U1)] bool aAllowAuth);

	[MethodImpl(MethodImplOptions.InternalCall)]
	float GetZoomAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetZoomAttribute(float aZoom);

	[MethodImpl(MethodImplOptions.InternalCall)]
	int GetMarginWidthAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetMarginWidthAttribute(int aMarginWidth);

	[MethodImpl(MethodImplOptions.InternalCall)]
	int GetMarginHeightAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetMarginHeightAttribute(int aMarginHeight);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool TabToTreeOwner([MarshalAs(UnmanagedType.U1)] bool forward, [MarshalAs(UnmanagedType.U1)] bool forDocumentNavigation);

	[MethodImpl(MethodImplOptions.InternalCall)]
	uint GetBusyFlagsAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	uint GetLoadTypeAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetLoadTypeAttribute(uint aLoadType);

	[MethodImpl(MethodImplOptions.InternalCall)]
	uint GetDefaultLoadFlagsAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetDefaultLoadFlagsAttribute(uint aDefaultLoadFlags);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool IsBeingDestroyed();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool GetIsExecutingOnLoadHandlerAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	IntPtr GetLayoutHistoryStateAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetLayoutHistoryStateAttribute(IntPtr aLayoutHistoryState);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool GetShouldSaveLayoutStateAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsISecureBrowserUI GetSecurityUIAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetSecurityUIAttribute([MarshalAs(UnmanagedType.Interface)] nsISecureBrowserUI aSecurityUI);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SuspendRefreshURIs();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void ResumeRefreshURIs();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void BeginRestore([MarshalAs(UnmanagedType.Interface)] nsIContentViewer viewer, [MarshalAs(UnmanagedType.U1)] bool top);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void FinishRestore();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool GetRestoringDocumentAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool GetUseErrorPagesAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetUseErrorPagesAttribute([MarshalAs(UnmanagedType.U1)] bool aUseErrorPages);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool DisplayLoadError(int aError, [MarshalAs(UnmanagedType.Interface)] nsIURI aURI, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.WStringMarshaler")] string aURL, [MarshalAs(UnmanagedType.Interface)] nsIChannel aFailedChannel);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIChannel GetFailedChannelAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	int GetPreviousTransIndexAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	int GetLoadedTransIndexAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void HistoryPurged(int numEntries);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIDOMStorage GetSessionStorageForPrincipal([MarshalAs(UnmanagedType.Interface)] nsIPrincipal principal, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase documentURI, [MarshalAs(UnmanagedType.U1)] bool create);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void AddSessionStorage([MarshalAs(UnmanagedType.Interface)] nsIPrincipal principal, [MarshalAs(UnmanagedType.Interface)] nsIDOMStorage storage);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIChannel GetCurrentDocumentChannelAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetChildOffset(uint offset);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool GetIsInUnloadAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool GetChannelIsUnsafeAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool GetHasMixedActiveContentLoadedAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool GetHasMixedActiveContentBlockedAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool GetHasMixedDisplayContentLoadedAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool GetHasMixedDisplayContentBlockedAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool GetHasTrackingContentBlockedAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool GetHasTrackingContentLoadedAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void DetachEditorFromWindow();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool GetIsOffScreenBrowserAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetIsOffScreenBrowserAttribute([MarshalAs(UnmanagedType.U1)] bool aIsOffScreenBrowser);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIWebBrowserPrint GetPrintPreviewAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool GetCanExecuteScriptsAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool GetIsActiveAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetIsActiveAttribute([MarshalAs(UnmanagedType.U1)] bool aIsActive);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetIsActiveAndForeground([MarshalAs(UnmanagedType.U1)] bool aIsActive);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetIsPrerendered([MarshalAs(UnmanagedType.U1)] bool prerendered);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool GetIsPrerenderedAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	ulong GetHistoryIDAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool GetIsAppTabAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetIsAppTabAttribute([MarshalAs(UnmanagedType.U1)] bool aIsAppTab);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void CreateAboutBlankContentViewer([MarshalAs(UnmanagedType.Interface)] nsIPrincipal aPrincipal);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetCharsetAttribute([MarshalAs(UnmanagedType.LPStruct)] nsACStringBase aCharset);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetCharsetAttribute([MarshalAs(UnmanagedType.LPStruct)] nsACStringBase aCharset);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GatherCharsetMenuTelemetry();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetForcedCharsetAttribute([MarshalAs(UnmanagedType.LPStruct)] nsACStringBase aForcedCharset);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetForcedCharsetAttribute([MarshalAs(UnmanagedType.LPStruct)] nsACStringBase aForcedCharset);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetParentCharset([MarshalAs(UnmanagedType.LPStruct)] nsACStringBase parentCharset, int parentCharsetSource, [MarshalAs(UnmanagedType.Interface)] nsIPrincipal parentCharsetPrincipal);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetParentCharset([MarshalAs(UnmanagedType.LPStruct)] nsACStringBase parentCharset, ref int parentCharsetSource, [MarshalAs(UnmanagedType.Interface)] ref nsIPrincipal parentCharsetPrincipal);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool GetRecordProfileTimelineMarkersAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetRecordProfileTimelineMarkersAttribute([MarshalAs(UnmanagedType.U1)] bool aRecordProfileTimelineMarkers);

	[MethodImpl(MethodImplOptions.InternalCall)]
	DOMHighResTimeStamp Now();

	[MethodImpl(MethodImplOptions.InternalCall)]
	JsVal PopProfileTimelineMarkers(IntPtr jsContext);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void AddWeakPrivacyTransitionObserver([MarshalAs(UnmanagedType.Interface)] nsIPrivacyTransitionObserver obs);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void AddWeakReflowObserver([MarshalAs(UnmanagedType.Interface)] nsIReflowObserver obs);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void RemoveWeakReflowObserver([MarshalAs(UnmanagedType.Interface)] nsIReflowObserver obs);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void NotifyReflowObservers([MarshalAs(UnmanagedType.U1)] bool interruptible, DOMHighResTimeStamp start, DOMHighResTimeStamp end);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void AddWeakScrollObserver(IntPtr obs);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void RemoveWeakScrollObserver(IntPtr obs);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void NotifyScrollObservers();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool GetIsBrowserElementAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool GetIsAppAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool GetIsBrowserOrAppAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool GetIsInBrowserElementAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool GetIsInBrowserOrAppAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetIsApp(uint ownAppId);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetIsBrowserInsideApp(uint containingAppId);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetIsSignedPackage([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase packageId);

	[MethodImpl(MethodImplOptions.InternalCall)]
	uint GetAppIdAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetAppManifestURLAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aAppManifestURL);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIDocShell GetSameTypeParentIgnoreBrowserAndAppBoundaries();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIDocShell GetSameTypeRootTreeItemIgnoreBrowserAndAppBoundaries();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool GetAsyncPanZoomEnabledAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	uint GetSandboxFlagsAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetSandboxFlagsAttribute(uint aSandboxFlags);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIDocShell GetOnePermittedSandboxedNavigatorAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetOnePermittedSandboxedNavigatorAttribute([MarshalAs(UnmanagedType.Interface)] nsIDocShell aOnePermittedSandboxedNavigator);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool IsSandboxedFrom([MarshalAs(UnmanagedType.Interface)] nsIDocShell aTargetDocShell);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIChannel GetMixedContentChannelAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetMixedContentChannelAttribute([MarshalAs(UnmanagedType.Interface)] nsIChannel aMixedContentChannel);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetAllowMixedContentAndConnectionData([MarshalAs(UnmanagedType.U1)] ref bool rootHasSecureConnection, [MarshalAs(UnmanagedType.U1)] ref bool allowMixedContent, [MarshalAs(UnmanagedType.U1)] ref bool isRootDocShell);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool PluginsAllowedInCurrentDoc();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool GetFullscreenAllowedAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetFullscreenAllowed([MarshalAs(UnmanagedType.U1)] bool allowed);

	[MethodImpl(MethodImplOptions.InternalCall)]
	uint OrientationLock();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetOrientationLock(uint orientationLock);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool GetAffectPrivateSessionLifetimeAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetAffectPrivateSessionLifetimeAttribute([MarshalAs(UnmanagedType.U1)] bool aAffectPrivateSessionLifetime);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool GetMayEnableCharacterEncodingMenuAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIEditor GetEditorAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetEditorAttribute([MarshalAs(UnmanagedType.Interface)] nsIEditor aEditor);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool GetEditableAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool GetHasEditingSessionAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void MakeEditable([MarshalAs(UnmanagedType.U1)] bool inWaitForUriLoad);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsISHEntry GetChildSHEntry(int aChildOffset);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void AddChildSHEntry([MarshalAs(UnmanagedType.Interface)] nsISHEntry aCloneReference, [MarshalAs(UnmanagedType.Interface)] nsISHEntry aHistoryEntry, int aChildOffset, uint aLoadType, [MarshalAs(UnmanagedType.U1)] bool aCloneChilden);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool GetUseGlobalHistoryAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetUseGlobalHistoryAttribute([MarshalAs(UnmanagedType.U1)] bool aUseGlobalHistory);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void RemoveFromSessionHistory();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool GetCreatedDynamicallyAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetCreatedDynamicallyAttribute([MarshalAs(UnmanagedType.U1)] bool aCreatedDynamically);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool GetCurrentSHEntry([MarshalAs(UnmanagedType.Interface)] ref nsISHEntry aEntry);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool IsCommandEnabled([MarshalAs(UnmanagedType.LPStr)] string command);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void DoCommand([MarshalAs(UnmanagedType.LPStr)] string command);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool IsInvisible();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetInvisible([MarshalAs(UnmanagedType.U1)] bool aIsInvisibleDochsell);

	[MethodImpl(MethodImplOptions.InternalCall)]
	IntPtr GetScriptGlobalObject();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool GetDeviceSizeIsPageSizeAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetDeviceSizeIsPageSizeAttribute([MarshalAs(UnmanagedType.U1)] bool aDeviceSizeIsPageSize);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetOpener([MarshalAs(UnmanagedType.Interface)] nsITabParent aOpener);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsITabParent GetOpener();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void NotifyJSRunToCompletionStart([MarshalAs(UnmanagedType.LPStr)] string aReason, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.WStringMarshaler")] string functionName, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.WStringMarshaler")] string fileName, uint lineNumber, ref JsVal asyncStack, ref JsVal asyncCause);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void NotifyJSRunToCompletionStop();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool GetHasLoadedNonBlankURIAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetPaymentRequestIdAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aPaymentRequestId);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetPaymentRequestIdAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aPaymentRequestId);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool GetWindowDraggingAllowedAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetWindowDraggingAllowedAttribute([MarshalAs(UnmanagedType.U1)] bool aWindowDraggingAllowed);
}
