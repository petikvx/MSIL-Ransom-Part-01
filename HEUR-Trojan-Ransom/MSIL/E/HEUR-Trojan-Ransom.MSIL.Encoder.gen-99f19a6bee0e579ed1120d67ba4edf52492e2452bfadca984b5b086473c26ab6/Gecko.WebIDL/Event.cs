namespace Gecko.WebIDL;

public class Event : WebIDLBase
{
	public string Type => GetProperty<string>("type");

	public nsISupports Target => GetProperty<nsISupports>("target");

	public nsISupports CurrentTarget => GetProperty<nsISupports>("currentTarget");

	public ushort EventPhase => GetProperty<ushort>("eventPhase");

	public bool Bubbles => GetProperty<bool>("bubbles");

	public bool Cancelable => GetProperty<bool>("cancelable");

	public bool DefaultPrevented => GetProperty<bool>("defaultPrevented");

	public bool IsTrusted => GetProperty<bool>("isTrusted");

	public double TimeStamp => GetProperty<double>("timeStamp");

	public nsISupports OriginalTarget => GetProperty<nsISupports>("originalTarget");

	public nsISupports ExplicitOriginalTarget => GetProperty<nsISupports>("explicitOriginalTarget");

	public nsISupports ComposedTarget => GetProperty<nsISupports>("composedTarget");

	public bool MultipleActionsPrevented => GetProperty<bool>("multipleActionsPrevented");

	public bool IsSynthesized => GetProperty<bool>("isSynthesized");

	public Event(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}

	public void StopPropagation()
	{
		CallVoidMethod("stopPropagation");
	}

	public void StopImmediatePropagation()
	{
		CallVoidMethod("stopImmediatePropagation");
	}

	public void PreventDefault()
	{
		CallVoidMethod("preventDefault");
	}

	public void InitEvent(string type, bool bubbles, bool cancelable)
	{
		CallVoidMethod("initEvent", type, bubbles, cancelable);
	}

	public bool GetPreventDefault()
	{
		return CallMethod<bool>("getPreventDefault", new object[0]);
	}
}
