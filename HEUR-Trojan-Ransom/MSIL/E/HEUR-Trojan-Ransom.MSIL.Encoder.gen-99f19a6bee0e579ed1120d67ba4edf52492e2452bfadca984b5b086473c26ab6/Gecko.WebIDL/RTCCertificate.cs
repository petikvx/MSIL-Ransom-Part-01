namespace Gecko.WebIDL;

public class RTCCertificate : WebIDLBase
{
	public nsISupports Expires => GetProperty<nsISupports>("expires");

	public RTCCertificate(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}
}
