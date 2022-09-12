namespace Gecko.WebIDL;

public class SVGSVGElement : WebIDLBase
{
	public nsISupports X => GetProperty<nsISupports>("x");

	public nsISupports Y => GetProperty<nsISupports>("y");

	public nsISupports Width => GetProperty<nsISupports>("width");

	public nsISupports Height => GetProperty<nsISupports>("height");

	public float PixelUnitToMillimeterX => GetProperty<float>("pixelUnitToMillimeterX");

	public float PixelUnitToMillimeterY => GetProperty<float>("pixelUnitToMillimeterY");

	public float ScreenPixelToMillimeterX => GetProperty<float>("screenPixelToMillimeterX");

	public float ScreenPixelToMillimeterY => GetProperty<float>("screenPixelToMillimeterY");

	public bool UseCurrentView => GetProperty<bool>("useCurrentView");

	public float CurrentScale
	{
		get
		{
			return GetProperty<float>("currentScale");
		}
		set
		{
			SetProperty("currentScale", value);
		}
	}

	public nsISupports CurrentTranslate => GetProperty<nsISupports>("currentTranslate");

	public SVGSVGElement(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}

	public uint SuspendRedraw(uint maxWaitMilliseconds)
	{
		return CallMethod<uint>("suspendRedraw", new object[1] { maxWaitMilliseconds });
	}

	public void UnsuspendRedraw(uint suspendHandleID)
	{
		CallVoidMethod("unsuspendRedraw", suspendHandleID);
	}

	public void UnsuspendRedrawAll()
	{
		CallVoidMethod("unsuspendRedrawAll");
	}

	public void ForceRedraw()
	{
		CallVoidMethod("forceRedraw");
	}

	public void PauseAnimations()
	{
		CallVoidMethod("pauseAnimations");
	}

	public void UnpauseAnimations()
	{
		CallVoidMethod("unpauseAnimations");
	}

	public bool AnimationsPaused()
	{
		return CallMethod<bool>("animationsPaused", new object[0]);
	}

	public float GetCurrentTime()
	{
		return CallMethod<float>("getCurrentTime", new object[0]);
	}

	public void SetCurrentTime(float seconds)
	{
		CallVoidMethod("setCurrentTime", seconds);
	}

	public void DeselectAll()
	{
		CallVoidMethod("deselectAll");
	}

	public nsISupports CreateSVGNumber()
	{
		return CallMethod<nsISupports>("createSVGNumber", new object[0]);
	}

	public nsISupports CreateSVGLength()
	{
		return CallMethod<nsISupports>("createSVGLength", new object[0]);
	}

	public nsISupports CreateSVGAngle()
	{
		return CallMethod<nsISupports>("createSVGAngle", new object[0]);
	}

	public nsISupports CreateSVGPoint()
	{
		return CallMethod<nsISupports>("createSVGPoint", new object[0]);
	}

	public nsISupports CreateSVGMatrix()
	{
		return CallMethod<nsISupports>("createSVGMatrix", new object[0]);
	}

	public nsISupports CreateSVGRect()
	{
		return CallMethod<nsISupports>("createSVGRect", new object[0]);
	}

	public nsISupports CreateSVGTransform()
	{
		return CallMethod<nsISupports>("createSVGTransform", new object[0]);
	}

	public nsISupports CreateSVGTransformFromMatrix(nsISupports matrix)
	{
		return CallMethod<nsISupports>("createSVGTransformFromMatrix", new object[1] { matrix });
	}

	public nsIDOMElement GetElementById(string elementId)
	{
		return CallMethod<nsIDOMElement>("getElementById", new object[1] { elementId });
	}
}
