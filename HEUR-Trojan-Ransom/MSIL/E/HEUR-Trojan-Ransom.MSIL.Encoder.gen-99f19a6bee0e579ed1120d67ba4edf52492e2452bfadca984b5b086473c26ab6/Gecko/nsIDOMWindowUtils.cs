using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[Guid("3f3f2bf4-d411-44b2-b2f7-dee5948c4763")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public interface nsIDOMWindowUtils
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	ushort GetImageAnimationModeAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetImageAnimationModeAttribute(ushort aImageAnimationMode);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool GetDocCharsetIsForcedAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	short GetCursorType();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetDocumentMetadata([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aName, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase retval);

	[MethodImpl(MethodImplOptions.InternalCall)]
	uint Redraw(uint aCount);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void UpdateLayerTree();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetViewportInfo(uint aDisplayWidth, uint aDisplayHeight, ref double aDefaultZoom, [MarshalAs(UnmanagedType.U1)] ref bool aAllowZoom, ref double aMinZoom, ref double aMaxZoom, ref uint aWidth, ref uint aHeight, [MarshalAs(UnmanagedType.U1)] ref bool aAutoSize);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetDisplayPortForElement(float aXPx, float aYPx, float aWidthPx, float aHeightPx, [MarshalAs(UnmanagedType.Interface)] nsIDOMElement aElement, uint aPriority);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetDisplayPortMarginsForElement(float aLeftMargin, float aTopMargin, float aRightMargin, float aBottomMargin, [MarshalAs(UnmanagedType.Interface)] nsIDOMElement aElement, uint aPriority);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetDisplayPortBaseForElement(int aX, int aY, int aWidth, int aHeight, [MarshalAs(UnmanagedType.Interface)] nsIDOMElement aElement);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetResolution(float aResolution);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetResolution(ref float aResolution);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetResolutionAndScaleTo(float aResolution);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool GetIsResolutionSetAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool GetIsFirstPaintAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetIsFirstPaintAttribute([MarshalAs(UnmanagedType.U1)] bool aIsFirstPaint);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetPresShellId(ref uint aPresShellId);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool SendMouseEvent([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aType, float aX, float aY, int aButton, int aClickCount, int aModifiers, [MarshalAs(UnmanagedType.U1)] bool aIgnoreRootScrollFrame, float aPressure, ushort aInputSourceArg, [MarshalAs(UnmanagedType.U1)] bool aIsSynthesized, int argc);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool SendPointerEvent([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aType, float aX, float aY, int aButton, int aClickCount, int aModifiers, [MarshalAs(UnmanagedType.U1)] bool aIgnoreRootScrollFrame, float aPressure, ushort aInputSourceArg, int aPointerId, int aWidth, int aHeight, int aTiltX, int aTiltY, [MarshalAs(UnmanagedType.U1)] bool aIsPrimary, [MarshalAs(UnmanagedType.U1)] bool aIsSynthesized, int argc);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool SendTouchEvent([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aType, [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 8)] uint[] aIdentifiers, [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 8)] int[] aXs, [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 8)] int[] aYs, [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 8)] uint[] aRxs, [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 8)] uint[] aRys, [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 8)] float[] aRotationAngles, [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 8)] float[] aForces, uint count, int aModifiers, [MarshalAs(UnmanagedType.U1)] bool aIgnoreRootScrollFrame);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SendMouseEventToWindow([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aType, float aX, float aY, int aButton, int aClickCount, int aModifiers, [MarshalAs(UnmanagedType.U1)] bool aIgnoreRootScrollFrame, float aPressure, ushort aInputSourceArg, [MarshalAs(UnmanagedType.U1)] bool aIsSynthesized, int argc);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SendPointerEventToWindow([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aType, float aX, float aY, int aButton, int aClickCount, int aModifiers, [MarshalAs(UnmanagedType.U1)] bool aIgnoreRootScrollFrame, float aPressure, ushort aInputSourceArg, int aPointerId, int aWidth, int aHeight, int aTiltX, int aTiltY, [MarshalAs(UnmanagedType.U1)] bool aIsPrimary, [MarshalAs(UnmanagedType.U1)] bool aIsSynthesized, int argc);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool SendTouchEventToWindow([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aType, [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 8)] uint[] aIdentifiers, [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 8)] int[] aXs, [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 8)] int[] aYs, [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 8)] uint[] aRxs, [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 8)] uint[] aRys, [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 8)] float[] aRotationAngles, [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 8)] float[] aForces, uint count, int aModifiers, [MarshalAs(UnmanagedType.U1)] bool aIgnoreRootScrollFrame);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SendWheelEvent(float aX, float aY, double aDeltaX, double aDeltaY, double aDeltaZ, uint aDeltaMode, int aModifiers, int aLineOrPageDeltaX, int aLineOrPageDeltaY, uint aOptions);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool SendKeyEvent([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aType, int aKeyCode, int aCharCode, int aModifiers, uint aAdditionalFlags);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SendNativeKeyEvent(int aNativeKeyboardLayout, int aNativeKeyCode, int aModifierFlags, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aCharacters, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aUnmodifiedCharacters, [MarshalAs(UnmanagedType.Interface)] nsIObserver aObserver);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SendNativeMouseEvent(int aScreenX, int aScreenY, int aNativeMessage, int aModifierFlags, [MarshalAs(UnmanagedType.Interface)] nsIDOMElement aElement, [MarshalAs(UnmanagedType.Interface)] nsIObserver aObserver);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SendNativeMouseScrollEvent(int aScreenX, int aScreenY, uint aNativeMessage, double aDeltaX, double aDeltaY, double aDeltaZ, uint aModifierFlags, uint aAdditionalFlags, [MarshalAs(UnmanagedType.Interface)] nsIDOMElement aElement, [MarshalAs(UnmanagedType.Interface)] nsIObserver aObserver);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SendNativeTouchPoint(uint aPointerId, uint aTouchState, int aScreenX, int aScreenY, double aPressure, uint aOrientation, [MarshalAs(UnmanagedType.Interface)] nsIObserver aObserver);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SendNativeTouchTap(int aScreenX, int aScreenY, [MarshalAs(UnmanagedType.U1)] bool aLongTap, [MarshalAs(UnmanagedType.Interface)] nsIObserver aObserver);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void ClearNativeTouchSequence([MarshalAs(UnmanagedType.Interface)] nsIObserver aObserver);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void ActivateNativeMenuItemAt([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase indexString);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void ForceUpdateNativeMenuAt([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase indexString);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void Focus([MarshalAs(UnmanagedType.Interface)] nsIDOMElement aElement);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GarbageCollect([MarshalAs(UnmanagedType.Interface)] nsICycleCollectorListener aListener, int aExtraForgetSkippableCalls);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void CycleCollect([MarshalAs(UnmanagedType.Interface)] nsICycleCollectorListener aListener, int aExtraForgetSkippableCalls);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void RunNextCollectorTimer();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SendSimpleGestureEvent([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aType, float aX, float aY, uint aDirection, double aDelta, int aModifiers, uint aClickCount);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIDOMElement ElementFromPoint(float aX, float aY, [MarshalAs(UnmanagedType.U1)] bool aIgnoreRootScrollFrame, [MarshalAs(UnmanagedType.U1)] bool aFlushLayout);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIDOMNodeList NodesFromRect(float aX, float aY, float aTopSize, float aRightSize, float aBottomSize, float aLeftSize, [MarshalAs(UnmanagedType.U1)] bool aIgnoreRootScrollFrame, [MarshalAs(UnmanagedType.U1)] bool aFlushLayout);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsITranslationNodeList GetTranslationNodes([MarshalAs(UnmanagedType.Interface)] nsIDOMNode aRoot);

	[MethodImpl(MethodImplOptions.InternalCall)]
	uint CompareCanvases([MarshalAs(UnmanagedType.Interface)] nsIDOMHTMLCanvasElement aCanvas1, [MarshalAs(UnmanagedType.Interface)] nsIDOMHTMLCanvasElement aCanvas2, ref uint aMaxDifference);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool GetIsMozAfterPaintPendingAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SuppressEventHandling([MarshalAs(UnmanagedType.U1)] bool aSuppress);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void ClearMozAfterPaintEvents();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void DisableNonTestMouseEvents([MarshalAs(UnmanagedType.U1)] bool aDisable);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetScrollXY([MarshalAs(UnmanagedType.U1)] bool aFlushLayout, ref int aScrollX, ref int aScrollY);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetScrollXYFloat([MarshalAs(UnmanagedType.U1)] bool aFlushLayout, ref float aScrollX, ref float aScrollY);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetScrollbarSize([MarshalAs(UnmanagedType.U1)] bool aFlushLayout, ref int aWidth, ref int aHeight);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIDOMClientRect GetBoundsWithoutFlushing([MarshalAs(UnmanagedType.Interface)] nsIDOMElement aElement);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIDOMClientRect GetRootBounds();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool GetIMEIsOpenAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	uint GetIMEStatusAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	float GetScreenPixelsPerCSSPixelAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	float GetFullZoomAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool DispatchDOMEventViaPresShell([MarshalAs(UnmanagedType.Interface)] nsIDOMNode aTarget, [MarshalAs(UnmanagedType.Interface)] nsIDOMEvent aEvent, [MarshalAs(UnmanagedType.U1)] bool aTrusted);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool DispatchEventToChromeOnly([MarshalAs(UnmanagedType.Interface)] nsIDOMEventTarget aTarget, [MarshalAs(UnmanagedType.Interface)] nsIDOMEvent aEvent);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.StringMarshaler")]
	string GetClassName(ref JsVal aObject, IntPtr jsContext);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SendContentCommandEvent([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aType, [MarshalAs(UnmanagedType.Interface)] nsITransferable aTransferable);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIQueryContentEventResult SendQueryContentEvent(uint aType, uint aOffset, uint aLength, int aX, int aY, uint aAdditionalFlags);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void RemoteFrameFullscreenChanged([MarshalAs(UnmanagedType.Interface)] nsIDOMElement aFrameElement);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void RemoteFrameFullscreenReverted();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool HandleFullscreenRequests();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void ExitFullscreen();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool SendSelectionSetEvent(uint aOffset, uint aLength, uint aAdditionalFlags);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool SelectAtPoint(float aX, float aY, uint aSelectBehavior);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetVisitedDependentComputedStyle([MarshalAs(UnmanagedType.Interface)] nsIDOMElement aElement, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aPseudoElement, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aPropertyName, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase retval);

	[MethodImpl(MethodImplOptions.InternalCall)]
	ulong GetOuterWindowIDAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	ulong GetCurrentInnerWindowIDAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void EnterModalState();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void LeaveModalState();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool IsInModalState();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetDesktopModeViewport([MarshalAs(UnmanagedType.U1)] bool aDesktopModeViewport);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SuspendTimeouts();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void ResumeTimeouts();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetLayerManagerTypeAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aLayerManagerType);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool GetLayerManagerRemoteAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetSupportsHardwareH264DecodingAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aSupportsHardwareH264Decoding);

	[MethodImpl(MethodImplOptions.InternalCall)]
	uint StartFrameTimeRecording();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void StopFrameTimeRecording(uint startIndex, ref uint frameCount, [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 1)] ref float[] frameIntervals);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void BeginTabSwitch();

	[MethodImpl(MethodImplOptions.InternalCall)]
	float GetDisplayDPIAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIDOMWindow GetOuterWindowWithId(ulong aOuterWindowID);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIDOMElement GetContainerElementAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void RenderDocument(nsConstRect aRect, uint aFlags, nscolor aBackgroundColor, gfxContext aThebesContext);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void AdvanceTimeAndRefresh(long aMilliseconds);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void RestoreNormalRefresh();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool GetIsTestControllingRefreshesAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool GetAsyncPanZoomEnabledAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetAsyncScrollOffset([MarshalAs(UnmanagedType.Interface)] nsIDOMNode aNode, float aX, float aY);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetAsyncZoom([MarshalAs(UnmanagedType.Interface)] nsIDOMNode aRootElement, float aValue);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool FlushApzRepaints();

	[MethodImpl(MethodImplOptions.InternalCall)]
	double ComputeAnimationDistance([MarshalAs(UnmanagedType.Interface)] nsIDOMElement element, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase property, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase value1, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase value2);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsISupports WrapDOMFile([MarshalAs(UnmanagedType.Interface)] nsIFile aFile);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.LPStr)]
	string GetFocusedInputTypeAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIDOMElement FindElementWithViewId(IntPtr aId);

	[MethodImpl(MethodImplOptions.InternalCall)]
	IntPtr GetViewId([MarshalAs(UnmanagedType.Interface)] nsIDOMElement aElement);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool LeafLayersPartitionWindow();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool CheckAndClearPaintedState([MarshalAs(UnmanagedType.Interface)] nsIDOMElement aElement);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool IsPartOfOpaqueLayer([MarshalAs(UnmanagedType.Interface)] nsIDOMElement aElement);

	[MethodImpl(MethodImplOptions.InternalCall)]
	uint NumberOfAssignedPaintedLayers([MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 1)] nsIDOMElement[] aElements, uint count);

	[MethodImpl(MethodImplOptions.InternalCall)]
	int GetFileId(ref JsVal aFile, IntPtr jsContext);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetFilePath(ref JsVal aFile, IntPtr jsContext, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase retval);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool GetFileReferences([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aDatabaseName, long aId, ref JsVal aOptions, ref int aRefCnt, ref int aDBRefCnt, ref int aSliceRefCnt, IntPtr jsContext);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void FlushPendingFileDeletions();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool IsIncrementalGCEnabled(IntPtr jsContext);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void StartPCCountProfiling(IntPtr jsContext);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void StopPCCountProfiling(IntPtr jsContext);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void PurgePCCounts(IntPtr jsContext);

	[MethodImpl(MethodImplOptions.InternalCall)]
	int GetPCCountScriptCount(IntPtr jsContext);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetPCCountScriptSummary(int script, IntPtr jsContext, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase retval);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetPCCountScriptContents(int script, IntPtr jsContext, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase retval);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool GetPaintingSuppressedAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	JsVal GetPluginsAttribute(IntPtr jsContext);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetScrollPositionClampingScrollPortSize(float aWidth, float aHeight);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void DisableDialogs();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void EnableDialogs();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool AreDialogsEnabled();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void LoadSheet([MarshalAs(UnmanagedType.Interface)] nsIURI sheetURI, uint type);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void LoadSheetUsingURIString([MarshalAs(UnmanagedType.LPStruct)] nsACStringBase sheetURI, uint type);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void AddSheet([MarshalAs(UnmanagedType.Interface)] nsIDOMStyleSheet sheet, uint type);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void RemoveSheet([MarshalAs(UnmanagedType.Interface)] nsIURI sheetURI, uint type);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void RemoveSheetUsingURIString([MarshalAs(UnmanagedType.LPStruct)] nsACStringBase sheetURI, uint type);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool GetIsHandlingUserInputAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void AllowScriptsToClose();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool GetIsParentWindowMainWidgetVisibleAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool IsNodeDisabledForEvents([MarshalAs(UnmanagedType.Interface)] nsIDOMNode aNode);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool GetPaintFlashingAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetPaintFlashingAttribute([MarshalAs(UnmanagedType.U1)] bool aPaintFlashing);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetOMTAStyle([MarshalAs(UnmanagedType.Interface)] nsIDOMElement aElement, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aProperty, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aPseudoElement, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase retval);

	[MethodImpl(MethodImplOptions.InternalCall)]
	float RequestCompositorProperty([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aProperty);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIJSRAIIHelper SetHandlingUserInput([MarshalAs(UnmanagedType.U1)] bool aHandlingInput);

	[MethodImpl(MethodImplOptions.InternalCall)]
	JsVal GetContentAPZTestData(IntPtr jsContext);

	[MethodImpl(MethodImplOptions.InternalCall)]
	JsVal GetCompositorAPZTestData(IntPtr jsContext);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void PostRestyleSelfEvent([MarshalAs(UnmanagedType.Interface)] nsIDOMElement aElement);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool GetAudioMutedAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetAudioMutedAttribute([MarshalAs(UnmanagedType.U1)] bool aAudioMuted);

	[MethodImpl(MethodImplOptions.InternalCall)]
	float GetAudioVolumeAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetAudioVolumeAttribute(float aAudioVolume);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void XpconnectArgument([MarshalAs(UnmanagedType.Interface)] nsIDOMWindowUtils aThis);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void AskPermission([MarshalAs(UnmanagedType.Interface)] nsIContentPermissionRequest aRequest);

	[MethodImpl(MethodImplOptions.InternalCall)]
	ulong GetFramesConstructedAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	ulong GetFramesReflowedAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetChromeMargin(int aTop, int aRight, int aBottom, int aLeft);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool GetServiceWorkersTestingEnabledAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetServiceWorkersTestingEnabledAttribute([MarshalAs(UnmanagedType.U1)] bool aServiceWorkersTestingEnabled);

	[MethodImpl(MethodImplOptions.InternalCall)]
	JsVal GetFrameUniformityTestData(IntPtr jsContext);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void EnterChaosMode();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void LeaveChaosMode();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool HasRuleProcessorUsedByMultipleStyleSets(uint aSheetType);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void ForceUseCounterFlush([MarshalAs(UnmanagedType.Interface)] nsIDOMNode aNode);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetNextPaintSyncId(int aSyncId);
}
