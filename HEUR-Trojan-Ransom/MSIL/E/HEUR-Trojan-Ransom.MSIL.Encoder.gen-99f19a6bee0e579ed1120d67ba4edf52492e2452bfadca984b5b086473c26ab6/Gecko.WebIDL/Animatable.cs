namespace Gecko.WebIDL;

public class Animatable : WebIDLBase
{
	public Animatable(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}

	public nsISupports[] GetAnimations()
	{
		return CallMethod<nsISupports[]>("getAnimations", new object[0]);
	}
}
