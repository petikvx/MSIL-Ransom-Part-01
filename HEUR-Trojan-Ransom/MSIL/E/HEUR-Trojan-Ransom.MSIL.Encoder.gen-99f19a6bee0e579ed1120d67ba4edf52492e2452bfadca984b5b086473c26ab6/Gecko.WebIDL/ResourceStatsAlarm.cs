namespace Gecko.WebIDL;

public class ResourceStatsAlarm : WebIDLBase
{
	public uint AlarmId => GetProperty<uint>("alarmId");

	public ResourceType Type => GetProperty<ResourceType>("type");

	public string Component => GetProperty<string>("component");

	public SystemService ServiceType => GetProperty<SystemService>("serviceType");

	public string ManifestURL => GetProperty<string>("manifestURL");

	public ulong Threshold => GetProperty<ulong>("threshold");

	public object Data => GetProperty<object>("data");

	public ResourceStatsAlarm(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}
}
