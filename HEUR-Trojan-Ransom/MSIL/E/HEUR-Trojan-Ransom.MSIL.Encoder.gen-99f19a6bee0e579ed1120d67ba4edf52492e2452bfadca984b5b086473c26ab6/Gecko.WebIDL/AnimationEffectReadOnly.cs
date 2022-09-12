namespace Gecko.WebIDL;

public class AnimationEffectReadOnly : WebIDLBase
{
	public AnimationEffectReadOnly(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}

	public object GetComputedTiming()
	{
		return CallMethod<object>("getComputedTiming", new object[0]);
	}
}
