namespace Gecko.WebIDL;

public class KeyframeEffectReadOnly : WebIDLBase
{
	public nsIDOMElement Target => GetProperty<nsIDOMElement>("target");

	public IterationCompositeOperation IterationComposite => GetProperty<IterationCompositeOperation>("iterationComposite");

	public CompositeOperation Composite => GetProperty<CompositeOperation>("composite");

	public string Spacing => GetProperty<string>("spacing");

	public KeyframeEffectReadOnly(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}

	public object[] GetFrames()
	{
		return CallMethod<object[]>("getFrames", new object[0]);
	}
}
