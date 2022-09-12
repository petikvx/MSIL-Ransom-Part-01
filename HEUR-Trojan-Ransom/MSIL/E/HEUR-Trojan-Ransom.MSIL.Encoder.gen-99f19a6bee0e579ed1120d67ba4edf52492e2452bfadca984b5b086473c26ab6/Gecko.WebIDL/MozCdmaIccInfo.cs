namespace Gecko.WebIDL;

public class MozCdmaIccInfo : WebIDLBase
{
	public string Mdn => GetProperty<string>("mdn");

	public int PrlVersion => GetProperty<int>("prlVersion");

	public MozCdmaIccInfo(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}
}
