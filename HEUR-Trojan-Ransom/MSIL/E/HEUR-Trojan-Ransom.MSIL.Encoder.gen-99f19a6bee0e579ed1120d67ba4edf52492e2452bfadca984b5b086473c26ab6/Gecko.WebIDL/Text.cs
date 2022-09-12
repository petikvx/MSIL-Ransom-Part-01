namespace Gecko.WebIDL;

public class Text : WebIDLBase
{
	public string WholeText => GetProperty<string>("wholeText");

	public Text(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}

	public nsIDOMText SplitText(uint offset)
	{
		return CallMethod<nsIDOMText>("splitText", new object[1] { offset });
	}
}
