namespace Gecko.WebIDL;

public class MozMobileNetworkInfo : WebIDLBase
{
	public string ShortName => GetProperty<string>("shortName");

	public string LongName => GetProperty<string>("longName");

	public string Mcc => GetProperty<string>("mcc");

	public string Mnc => GetProperty<string>("mnc");

	public MobileNetworkState State => GetProperty<MobileNetworkState>("state");

	public MozMobileNetworkInfo(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}
}
