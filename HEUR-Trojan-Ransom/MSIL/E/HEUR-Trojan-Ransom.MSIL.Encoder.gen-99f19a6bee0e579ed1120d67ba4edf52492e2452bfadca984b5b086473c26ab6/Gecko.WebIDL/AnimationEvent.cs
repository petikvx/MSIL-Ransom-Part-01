namespace Gecko.WebIDL;

public class AnimationEvent : WebIDLBase
{
	public string AnimationName => GetProperty<string>("animationName");

	public float ElapsedTime => GetProperty<float>("elapsedTime");

	public string PseudoElement => GetProperty<string>("pseudoElement");

	public AnimationEvent(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}
}
