namespace Gecko.WebIDL;

public class MutationEvent : WebIDLBase
{
	public nsIDOMNode RelatedNode => GetProperty<nsIDOMNode>("relatedNode");

	public string PrevValue => GetProperty<string>("prevValue");

	public string NewValue => GetProperty<string>("newValue");

	public string AttrName => GetProperty<string>("attrName");

	public ushort AttrChange => GetProperty<ushort>("attrChange");

	public MutationEvent(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}

	public void InitMutationEvent(string type, bool canBubble, bool cancelable, nsIDOMNode relatedNode, string prevValue, string newValue, string attrName, ushort attrChange)
	{
		CallVoidMethod("initMutationEvent", type, canBubble, cancelable, relatedNode, prevValue, newValue, attrName, attrChange);
	}
}
