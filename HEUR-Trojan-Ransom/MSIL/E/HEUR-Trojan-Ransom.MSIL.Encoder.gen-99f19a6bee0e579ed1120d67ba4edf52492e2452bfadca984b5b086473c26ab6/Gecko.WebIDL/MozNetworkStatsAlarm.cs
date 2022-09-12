namespace Gecko.WebIDL;

public class MozNetworkStatsAlarm : WebIDLBase
{
	public uint AlarmId => GetProperty<uint>("alarmId");

	public nsISupports Network => GetProperty<nsISupports>("network");

	public long Threshold => GetProperty<long>("threshold");

	public object Data => GetProperty<object>("data");

	public MozNetworkStatsAlarm(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}
}
