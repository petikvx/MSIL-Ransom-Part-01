namespace Gecko.WebIDL;

public class MozWifiStationInfoEvent : WebIDLBase
{
	public short Station => GetProperty<short>("station");

	public MozWifiStationInfoEvent(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}
}
