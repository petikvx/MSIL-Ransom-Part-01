namespace Gecko.WebIDL;

public class SVGAnimationElement : WebIDLBase
{
	public nsISupports TargetElement => GetProperty<nsISupports>("targetElement");

	public SVGAnimationElement(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}

	public float GetStartTime()
	{
		return CallMethod<float>("getStartTime", new object[0]);
	}

	public float GetCurrentTime()
	{
		return CallMethod<float>("getCurrentTime", new object[0]);
	}

	public float GetSimpleDuration()
	{
		return CallMethod<float>("getSimpleDuration", new object[0]);
	}

	public void BeginElement()
	{
		CallVoidMethod("beginElement");
	}

	public void BeginElementAt(float offset)
	{
		CallVoidMethod("beginElementAt", offset);
	}

	public void EndElement()
	{
		CallVoidMethod("endElement");
	}

	public void EndElementAt(float offset)
	{
		CallVoidMethod("endElementAt", offset);
	}
}
