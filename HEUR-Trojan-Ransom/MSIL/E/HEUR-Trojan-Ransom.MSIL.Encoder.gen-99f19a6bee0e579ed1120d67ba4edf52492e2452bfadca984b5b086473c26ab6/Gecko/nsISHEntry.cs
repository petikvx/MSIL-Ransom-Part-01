using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("3a5e5fa0-5364-4fbb-a87a-3f12a6b51903")]
public interface nsISHEntry
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIURI GetURIAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIURI GetOriginalURIAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetOriginalURIAttribute([MarshalAs(UnmanagedType.Interface)] nsIURI aOriginalURI);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool GetLoadReplaceAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetLoadReplaceAttribute([MarshalAs(UnmanagedType.U1)] bool aLoadReplace);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.WStringMarshaler")]
	string GetTitleAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool GetIsSubFrameAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetURI([MarshalAs(UnmanagedType.Interface)] nsIURI aURI);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIURI GetReferrerURIAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetReferrerURIAttribute([MarshalAs(UnmanagedType.Interface)] nsIURI aReferrerURI);

	[MethodImpl(MethodImplOptions.InternalCall)]
	uint GetReferrerPolicyAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetReferrerPolicyAttribute(uint aReferrerPolicy);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIContentViewer GetContentViewerAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetContentViewerAttribute([MarshalAs(UnmanagedType.Interface)] nsIContentViewer aContentViewer);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool GetStickyAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetStickyAttribute([MarshalAs(UnmanagedType.U1)] bool aSticky);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsISupports GetWindowStateAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetWindowStateAttribute([MarshalAs(UnmanagedType.Interface)] nsISupports aWindowState);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetViewerBounds([MarshalAs(UnmanagedType.Interface)] nsIntRect bounds);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetViewerBounds([MarshalAs(UnmanagedType.Interface)] nsIntRect bounds);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void AddChildShell([MarshalAs(UnmanagedType.Interface)] nsIDocShellTreeItem shell);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIDocShellTreeItem ChildShellAt(int index);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void ClearChildShells();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsISupportsArray GetRefreshURIListAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetRefreshURIListAttribute([MarshalAs(UnmanagedType.Interface)] nsISupportsArray aRefreshURIList);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SyncPresentationState();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetTitle([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aTitle);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIInputStream GetPostDataAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetPostDataAttribute([MarshalAs(UnmanagedType.Interface)] nsIInputStream aPostData);

	[MethodImpl(MethodImplOptions.InternalCall)]
	IntPtr GetLayoutHistoryStateAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetLayoutHistoryStateAttribute(IntPtr aLayoutHistoryState);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsISHEntry GetParentAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetParentAttribute([MarshalAs(UnmanagedType.Interface)] nsISHEntry aParent);

	[MethodImpl(MethodImplOptions.InternalCall)]
	uint GetLoadTypeAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetLoadTypeAttribute(uint aLoadType);

	[MethodImpl(MethodImplOptions.InternalCall)]
	uint GetIDAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetIDAttribute(uint aID);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsISupports GetCacheKeyAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetCacheKeyAttribute([MarshalAs(UnmanagedType.Interface)] nsISupports aCacheKey);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool GetSaveLayoutStateFlagAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetSaveLayoutStateFlagAttribute([MarshalAs(UnmanagedType.U1)] bool aSaveLayoutStateFlag);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool GetExpirationStatusAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetExpirationStatusAttribute([MarshalAs(UnmanagedType.U1)] bool aExpirationStatus);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetContentTypeAttribute([MarshalAs(UnmanagedType.LPStruct)] nsACStringBase aContentType);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetContentTypeAttribute([MarshalAs(UnmanagedType.LPStruct)] nsACStringBase aContentType);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool GetURIWasModifiedAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetURIWasModifiedAttribute([MarshalAs(UnmanagedType.U1)] bool aURIWasModified);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetScrollPosition(int x, int y);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetScrollPosition(ref int x, ref int y);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void Create([MarshalAs(UnmanagedType.Interface)] nsIURI URI, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase title, [MarshalAs(UnmanagedType.Interface)] nsIInputStream inputStream, IntPtr layoutHistoryState, [MarshalAs(UnmanagedType.Interface)] nsISupports cacheKey, [MarshalAs(UnmanagedType.LPStruct)] nsACStringBase contentType, [MarshalAs(UnmanagedType.Interface)] nsISupports owner, ulong docshellID, [MarshalAs(UnmanagedType.U1)] bool dynamicCreation);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsISHEntry Clone();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetIsSubFrame([MarshalAs(UnmanagedType.U1)] bool aFlag);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIContentViewer GetAnyContentViewer([MarshalAs(UnmanagedType.Interface)] ref nsISHEntry ownerEntry);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsISupports GetOwnerAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetOwnerAttribute([MarshalAs(UnmanagedType.Interface)] nsISupports aOwner);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIStructuredCloneContainer GetStateDataAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetStateDataAttribute([MarshalAs(UnmanagedType.Interface)] nsIStructuredCloneContainer aStateData);

	[MethodImpl(MethodImplOptions.InternalCall)]
	IntPtr ForgetEditorData();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetEditorData(IntPtr aData);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool HasDetachedEditor();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool IsDynamicallyAdded();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool HasDynamicallyAddedChild();

	[MethodImpl(MethodImplOptions.InternalCall)]
	ulong GetDocshellIDAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetDocshellIDAttribute(ulong aDocshellID);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIBFCacheEntry GetBFCacheEntryAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool HasBFCacheEntry([MarshalAs(UnmanagedType.Interface)] nsIBFCacheEntry aEntry);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void AdoptBFCacheEntry([MarshalAs(UnmanagedType.Interface)] nsISHEntry aEntry);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void AbandonBFCacheEntry();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool SharesDocumentWith([MarshalAs(UnmanagedType.Interface)] nsISHEntry aEntry);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool GetIsSrcdocEntryAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetSrcdocDataAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aSrcdocData);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetSrcdocDataAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aSrcdocData);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIURI GetBaseURIAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetBaseURIAttribute([MarshalAs(UnmanagedType.Interface)] nsIURI aBaseURI);
}
