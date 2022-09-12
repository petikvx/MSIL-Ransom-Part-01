namespace Gecko.WebIDL;

public class MozPhonetic : WebIDLBase
{
	public string Phonetic => GetProperty<string>("phonetic");

	public MozPhonetic(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}
}
