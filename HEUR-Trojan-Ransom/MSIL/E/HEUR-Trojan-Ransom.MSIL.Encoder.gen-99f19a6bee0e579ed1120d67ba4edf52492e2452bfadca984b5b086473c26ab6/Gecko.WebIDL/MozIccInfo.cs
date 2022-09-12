namespace Gecko.WebIDL;

public class MozIccInfo : WebIDLBase
{
	public IccType IccType => GetProperty<IccType>("iccType");

	public string Iccid => GetProperty<string>("iccid");

	public string Mcc => GetProperty<string>("mcc");

	public string Mnc => GetProperty<string>("mnc");

	public string Spn => GetProperty<string>("spn");

	public bool IsDisplayNetworkNameRequired => GetProperty<bool>("isDisplayNetworkNameRequired");

	public bool IsDisplaySpnRequired => GetProperty<bool>("isDisplaySpnRequired");

	public MozIccInfo(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}
}
