using System;
using Gecko.Interop;

namespace Gecko.DOM;

public class WindowUtils
{
	private ComPtr<nsIDOMWindowUtils> _windowUtils;

	public ushort ImageAnimationMode
	{
		get
		{
			return _windowUtils.Instance.GetImageAnimationModeAttribute();
		}
		set
		{
			_windowUtils.Instance.SetImageAnimationModeAttribute(value);
		}
	}

	public bool DocCharsetIsForced => _windowUtils.Instance.GetDocCharsetIsForcedAttribute();

	public bool IMEIsOpen => _windowUtils.Instance.GetIMEIsOpenAttribute();

	public uint IMEStatus => _windowUtils.Instance.GetIMEStatusAttribute();

	public float ScreenPixelsPerCSSPixel => _windowUtils.Instance.GetScreenPixelsPerCSSPixelAttribute();

	public float DisplayDPI => _windowUtils.Instance.GetDisplayDPIAttribute();

	public string FocusedInputType => _windowUtils.Instance.GetFocusedInputTypeAttribute();

	public bool MayHaveTouchEventListeners
	{
		get
		{
			throw new NotImplementedException();
		}
	}

	internal WindowUtils(nsIDOMWindowUtils windowUtils)
	{
		_windowUtils = new ComPtr<nsIDOMWindowUtils>(windowUtils);
	}

	public static WindowUtils Create(nsIDOMWindowUtils windowUtils)
	{
		return new WindowUtils(windowUtils);
	}

	public short GetCursorType()
	{
		return _windowUtils.Instance.GetCursorType();
	}

	public string GetDocumentMetadata(string name)
	{
		return nsString.Get(_windowUtils.Instance.GetDocumentMetadata, name);
	}

	public uint Redraw(uint aCount)
	{
		return _windowUtils.Instance.Redraw(aCount);
	}

	public void SetDisplayPortForElement(float aXPx, float aYPx, float aWidthPx, float aHeightPx, GeckoElement aElement, uint aPriority)
	{
		_windowUtils.Instance.SetDisplayPortForElement(aXPx, aYPx, aWidthPx, aHeightPx, (nsIDOMElement)aElement.DomObject, aPriority);
	}

	public void SetResolution(float aResolution)
	{
		_windowUtils.Instance.SetResolution(aResolution);
	}

	public void SendMouseEvent(string aType, float aX, float aY, GeckoMouseButton aButton, int aClickCount, int aModifiers, bool aIgnoreRootScrollFrame, float aPressure, ushort aInputSourceArg)
	{
		using nsAString aType2 = new nsAString(aType);
		_windowUtils.Instance.SendMouseEvent(aType2, aX, aY, (int)aButton, aClickCount, aModifiers, aIgnoreRootScrollFrame, aPressure, aInputSourceArg, aIsSynthesized: false, 10);
	}

	public void SendMouseEventToWindow(string aType, float aX, float aY, GeckoMouseButton aButton, int aClickCount, int aModifiers, bool aIgnoreRootScrollFrame, float aPressure, ushort aInputSourceArg)
	{
		using nsAString aType2 = new nsAString(aType);
		_windowUtils.Instance.SendMouseEventToWindow(aType2, aX, aY, (int)aButton, aClickCount, aModifiers, aIgnoreRootScrollFrame, aPressure, aInputSourceArg, aIsSynthesized: false, 10);
	}

	public bool SendKeyEvent(string aType, int aKeyCode, int aCharCode, int aModifiers, bool aPreventDefault)
	{
		using nsAString aType2 = new nsAString(aType);
		return _windowUtils.Instance.SendKeyEvent(aType2, aKeyCode, aCharCode, aModifiers, aPreventDefault ? 1u : 0u);
	}

	public void SendNativeKeyEvent(int aNativeKeyboardLayout, int aNativeKeyCode, int aModifierFlags, string aCharacters, string aUnmodifiedCharacters)
	{
		using nsAString aCharacters2 = new nsAString(aCharacters);
		using nsAString aUnmodifiedCharacters2 = new nsAString(aUnmodifiedCharacters);
		_windowUtils.Instance.SendNativeKeyEvent(aNativeKeyboardLayout, aNativeKeyCode, aModifierFlags, aCharacters2, aUnmodifiedCharacters2, null);
	}

	public void SendNativeMouseEvent(int aScreenX, int aScreenY, int aNativeMessage, int aModifierFlags, GeckoElement aElement)
	{
		_windowUtils.Instance.SendNativeMouseEvent(aScreenX, aScreenY, aNativeMessage, aModifierFlags, (nsIDOMElement)aElement.DomObject, null);
	}

	public void SendWheelEvent(float aX, float aY, double aDeltaX, double aDeltaY, double aDeltaZ, uint aDeltaMode, int aModifiers, int aLineOrPageDeltaX, int aLineOrPageDeltaY, uint aOptions)
	{
		_windowUtils.Instance.SendWheelEvent(aX, aY, aDeltaX, aDeltaY, aDeltaZ, aDeltaMode, aModifiers, aLineOrPageDeltaX, aLineOrPageDeltaY, aOptions);
	}

	public void ActivateNativeMenuItemAt(string indexString)
	{
		nsString.Set(_windowUtils.Instance.ActivateNativeMenuItemAt, indexString);
	}

	public void ForceUpdateNativeMenuAt(string indexString)
	{
		nsString.Set(_windowUtils.Instance.ForceUpdateNativeMenuAt, indexString);
	}

	public void Focus(GeckoElement aElement)
	{
		_windowUtils.Instance.Focus(aElement.DOMElement);
	}

	public void GarbageCollect(nsICycleCollectorListener aListener, int aExtraForgetSkippableCalls)
	{
		_windowUtils.Instance.GarbageCollect(aListener, aExtraForgetSkippableCalls);
	}

	public void CycleCollect(nsICycleCollectorListener aListener, int aExtraForgetSkippableCalls)
	{
		_windowUtils.Instance.GarbageCollect(aListener, aExtraForgetSkippableCalls);
	}

	public void SendSimpleGestureEvent(string aType, float aX, float aY, uint aDirection, double aDelta, int aModifiers)
	{
		throw new NotImplementedException();
	}

	public GeckoElement ElementFromPoint(float aX, float aY, bool aIgnoreRootScrollFrame, bool aFlushLayout)
	{
		nsIDOMElement nsIDOMElement = _windowUtils.Instance.ElementFromPoint(aX, aY, aIgnoreRootScrollFrame, aFlushLayout);
		if (nsIDOMElement == null)
		{
			return null;
		}
		return GeckoElement.CreateDomElementWrapper(nsIDOMElement);
	}

	public GeckoNodeCollection NodesFromRect(float aX, float aY, float aTopSize, float aRightSize, float aBottomSize, float aLeftSize, bool aIgnoreRootScrollFrame, bool aFlushLayout)
	{
		throw new NotImplementedException();
	}

	public uint CompareCanvases(GeckoCanvasElement aCanvas1, GeckoCanvasElement aCanvas2, ref uint aMaxDifference)
	{
		throw new NotImplementedException();
	}

	public bool GetIsMozAfterPaintPendingAttribute()
	{
		throw new NotImplementedException();
	}

	public void SuppressEventHandling(bool aSuppress)
	{
		throw new NotImplementedException();
	}

	public void ClearMozAfterPaintEvents()
	{
		throw new NotImplementedException();
	}

	public void DisableNonTestMouseEvents(bool aDisable)
	{
		throw new NotImplementedException();
	}

	public void GetScrollXY(bool aFlushLayout, ref int aScrollX, ref int aScrollY)
	{
		throw new NotImplementedException();
	}

	public bool DispatchDOMEventViaPresShell(GeckoNode aTarget, GeckoNode aEvent, bool aTrusted)
	{
		throw new NotImplementedException();
	}

	public string GetClassName(JsVal aObject, IntPtr jsContext)
	{
		throw new NotImplementedException();
	}

	public void SendContentCommandEvent(string aType, nsITransferable aTransferable)
	{
		throw new NotImplementedException();
	}

	public void SendCompositionEvent(string aType, string aData, string aLocale)
	{
		throw new NotImplementedException();
	}

	public void SendTextEvent(string aCompositionString, int aFirstClauseLength, uint aFirstClauseAttr, int aSecondClauseLength, uint aSecondClauseAttr, int aThirdClauseLength, uint aThirdClauseAttr, int aCaretStart, int aCaretLength)
	{
		throw new NotImplementedException();
	}

	public nsIQueryContentEventResult SendQueryContentEvent(uint aType, uint aOffset, uint aLength, int aX, int aY)
	{
		throw new NotImplementedException();
	}

	public bool SendSelectionSetEvent(uint aOffset, uint aLength, bool aReverse)
	{
		throw new NotImplementedException();
	}

	public string GetVisitedDependentComputedStyle(GeckoHtmlElement aElement, string aPseudoElement, string aPropertyName)
	{
		throw new NotImplementedException();
	}

	public JsVal GetParent(JsVal obj, IntPtr jsContext)
	{
		throw new NotImplementedException();
	}

	public ulong GetOuterWindowIDAttribute()
	{
		return _windowUtils.Instance.GetOuterWindowIDAttribute();
	}

	public ulong GetCurrentInnerWindowIDAttribute()
	{
		return _windowUtils.Instance.GetCurrentInnerWindowIDAttribute();
	}

	public void EnterModalState()
	{
		_windowUtils.Instance.EnterModalState();
	}

	public void LeaveModalState()
	{
		_windowUtils.Instance.LeaveModalState();
	}

	public bool IsInModalState()
	{
		return _windowUtils.Instance.IsInModalState();
	}

	public void SuspendTimeouts()
	{
		_windowUtils.Instance.SuspendTimeouts();
	}

	public void ResumeTimeouts()
	{
		_windowUtils.Instance.ResumeTimeouts();
	}

	public void GetLayerManagerTypeAttribute(string aLayerManagerType)
	{
		throw new NotImplementedException();
	}

	public void StartFrameTimeRecording()
	{
		throw new NotImplementedException();
	}

	public void StopFrameTimeRecording(ref uint frameCount, float[] frameTime)
	{
		throw new NotImplementedException();
	}

	public GeckoWindow GetOuterWindowWithId(ulong aOuterWindowID)
	{
		return _windowUtils.Instance.GetOuterWindowWithId(aOuterWindowID).Wrap((nsIDOMWindow x) => new GeckoWindow(x));
	}

	public void RenderDocument(nsConstRect aRect, uint aFlags, nscolor aBackgroundColor, gfxContext aThebesContext)
	{
		throw new NotImplementedException();
	}

	public void AdvanceTimeAndRefresh(long aMilliseconds)
	{
		throw new NotImplementedException();
	}

	public void RestoreNormalRefresh()
	{
		throw new NotImplementedException();
	}

	public double ComputeAnimationDistance(GeckoHtmlElement element, string property, string value1, string value2)
	{
		throw new NotImplementedException();
	}

	public GeckoHtmlElement FindElementWithViewId(IntPtr aId)
	{
		throw new NotImplementedException();
	}

	public bool LeafLayersPartitionWindow()
	{
		throw new NotImplementedException();
	}

	public bool CheckAndClearPaintedState(GeckoHtmlElement aElement)
	{
		throw new NotImplementedException();
	}

	public int GetFileId(nsIDOMBlob aBlob)
	{
		throw new NotImplementedException();
	}

	public bool GetFileReferences(string aDatabaseName, long aId, ref int aRefCnt, ref int aDBRefCnt, ref int aSliceRefCnt)
	{
		throw new NotImplementedException();
	}

	public void StartPCCountProfiling(IntPtr jsContext)
	{
		throw new NotImplementedException();
	}

	public void StopPCCountProfiling(IntPtr jsContext)
	{
		throw new NotImplementedException();
	}

	public void PurgePCCounts(IntPtr jsContext)
	{
		throw new NotImplementedException();
	}

	public int GetPCCountScriptCount(IntPtr jsContext)
	{
		throw new NotImplementedException();
	}

	public string GetPCCountScriptSummary(int script, IntPtr jsContext)
	{
		throw new NotImplementedException();
	}

	public string GetPCCountScriptContents(int script, IntPtr jsContext)
	{
		throw new NotImplementedException();
	}

	private bool GetPaintingSuppressedAttribute()
	{
		throw new NotImplementedException();
	}
}
