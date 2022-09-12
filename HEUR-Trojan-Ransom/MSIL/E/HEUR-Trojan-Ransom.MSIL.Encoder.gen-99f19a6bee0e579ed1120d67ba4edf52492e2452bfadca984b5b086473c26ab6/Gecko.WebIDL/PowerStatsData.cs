namespace Gecko.WebIDL;

public class PowerStatsData : WebIDLBase
{
	public ulong ConsumedPower => GetProperty<ulong>("consumedPower");

	public nsISupports Timestamp => GetProperty<nsISupports>("timestamp");

	public PowerStatsData(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}
}
