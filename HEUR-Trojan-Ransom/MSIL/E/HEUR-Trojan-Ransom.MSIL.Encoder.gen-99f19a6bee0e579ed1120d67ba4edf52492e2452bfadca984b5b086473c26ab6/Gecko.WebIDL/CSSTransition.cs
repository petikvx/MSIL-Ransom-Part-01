namespace Gecko.WebIDL;

public class CSSTransition : WebIDLBase
{
	public string TransitionProperty => GetProperty<string>("transitionProperty");

	public CSSTransition(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}
}
