namespace Gecko.WebIDL;

public class MozMobileCellInfo : WebIDLBase
{
	public int GsmLocationAreaCode => GetProperty<int>("gsmLocationAreaCode");

	public long GsmCellId => GetProperty<long>("gsmCellId");

	public int CdmaBaseStationId => GetProperty<int>("cdmaBaseStationId");

	public int CdmaBaseStationLatitude => GetProperty<int>("cdmaBaseStationLatitude");

	public int CdmaBaseStationLongitude => GetProperty<int>("cdmaBaseStationLongitude");

	public int CdmaSystemId => GetProperty<int>("cdmaSystemId");

	public int CdmaNetworkId => GetProperty<int>("cdmaNetworkId");

	public MozMobileCellInfo(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}
}
