namespace Gecko.WebIDL;

public class AnimationTimeline : WebIDLBase
{
	public double? CurrentTime => GetProperty<double?>("currentTime");

	public AnimationTimeline(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}

	public nsISupports[] GetAnimations()
	{
		return CallMethod<nsISupports[]>("getAnimations", new object[0]);
	}
}
