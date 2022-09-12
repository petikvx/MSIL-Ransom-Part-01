namespace Gecko.WebIDL;

public class TransitionEvent : WebIDLBase
{
	public string PropertyName => GetProperty<string>("propertyName");

	public float ElapsedTime => GetProperty<float>("elapsedTime");

	public string PseudoElement => GetProperty<string>("pseudoElement");

	public TransitionEvent(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}
}
