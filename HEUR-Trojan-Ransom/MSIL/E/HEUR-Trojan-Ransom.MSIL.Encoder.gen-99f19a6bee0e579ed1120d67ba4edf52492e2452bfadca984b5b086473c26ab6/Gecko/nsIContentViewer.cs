using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("91b6c1f3-fc5f-43a9-88f4-9286bd19387f")]
public interface nsIContentViewer
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	void Init(IntPtr aParentWidget, IntPtr aBounds);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIDocShell GetContainerAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetContainerAttribute([MarshalAs(UnmanagedType.Interface)] nsIDocShell aContainer);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void LoadStart(IntPtr aDoc);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void LoadComplete(int aStatus);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool PermitUnload();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool GetInPermitUnloadAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool PermitUnloadInternal([MarshalAs(UnmanagedType.U1)] ref bool aShouldPrompt);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool GetBeforeUnloadFiringAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void PageHide([MarshalAs(UnmanagedType.U1)] bool isUnload);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void Close([MarshalAs(UnmanagedType.Interface)] nsISHEntry historyEntry);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void Destroy();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void Stop();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIDOMDocument GetDOMDocumentAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetDOMDocumentAttribute([MarshalAs(UnmanagedType.Interface)] nsIDOMDocument aDOMDocument);

	[MethodImpl(MethodImplOptions.InternalCall)]
	IntPtr GetDocument();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetBounds(IntPtr aBounds);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetBounds(IntPtr aBounds);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIContentViewer GetPreviousViewerAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetPreviousViewerAttribute([MarshalAs(UnmanagedType.Interface)] nsIContentViewer aPreviousViewer);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void Move(int aX, int aY);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void Show();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void Hide();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool GetStickyAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetStickyAttribute([MarshalAs(UnmanagedType.U1)] bool aSticky);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool RequestWindowClose();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void Open([MarshalAs(UnmanagedType.Interface)] nsISupports aState, [MarshalAs(UnmanagedType.Interface)] nsISHEntry aSHEntry);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void ClearHistoryEntry();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetPageMode([MarshalAs(UnmanagedType.U1)] bool aPageMode, [MarshalAs(UnmanagedType.Interface)] nsIPrintSettings aPrintSettings);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsISHEntry GetHistoryEntryAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool GetIsTabModalPromptAllowedAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool GetIsHiddenAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetIsHiddenAttribute([MarshalAs(UnmanagedType.U1)] bool aIsHidden);

	[MethodImpl(MethodImplOptions.InternalCall)]
	IntPtr GetPresShellAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	IntPtr GetPresContextAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetDocumentInternal(IntPtr aDocument, [MarshalAs(UnmanagedType.U1)] bool aForceReuseInnerWindow);

	[MethodImpl(MethodImplOptions.InternalCall)]
	IntPtr FindContainerView();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetNavigationTiming(IntPtr aTiming);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void ScrollToNode([MarshalAs(UnmanagedType.Interface)] nsIDOMNode node);

	[MethodImpl(MethodImplOptions.InternalCall)]
	float GetTextZoomAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetTextZoomAttribute(float aTextZoom);

	[MethodImpl(MethodImplOptions.InternalCall)]
	float GetFullZoomAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetFullZoomAttribute(float aFullZoom);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool GetAuthorStyleDisabledAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetAuthorStyleDisabledAttribute([MarshalAs(UnmanagedType.U1)] bool aAuthorStyleDisabled);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetForceCharacterSetAttribute([MarshalAs(UnmanagedType.LPStruct)] nsACStringBase aForceCharacterSet);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetForceCharacterSetAttribute([MarshalAs(UnmanagedType.LPStruct)] nsACStringBase aForceCharacterSet);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetHintCharacterSetAttribute([MarshalAs(UnmanagedType.LPStruct)] nsACStringBase aHintCharacterSet);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetHintCharacterSetAttribute([MarshalAs(UnmanagedType.LPStruct)] nsACStringBase aHintCharacterSet);

	[MethodImpl(MethodImplOptions.InternalCall)]
	int GetHintCharacterSetSourceAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetHintCharacterSetSourceAttribute(int aHintCharacterSetSource);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetContentSize(ref int width, ref int height);

	[MethodImpl(MethodImplOptions.InternalCall)]
	int GetMinFontSizeAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetMinFontSizeAttribute(int aMinFontSize);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void AppendSubtree(IntPtr array);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void EmulateMedium([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aMediaType);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void StopEmulatingMedium();
}
