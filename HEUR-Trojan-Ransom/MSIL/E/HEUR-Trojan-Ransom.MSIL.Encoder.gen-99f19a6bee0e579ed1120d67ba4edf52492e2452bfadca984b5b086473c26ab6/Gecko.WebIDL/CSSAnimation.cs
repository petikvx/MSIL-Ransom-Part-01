namespace Gecko.WebIDL;

public class CSSAnimation : WebIDLBase
{
	public string AnimationName => GetProperty<string>("animationName");

	public CSSAnimation(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}
}
