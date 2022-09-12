namespace Gecko.WebIDL;

public class ResourceStatsManager : WebIDLBase
{
	public string[] ResourceTypes => GetProperty<string[]>("resourceTypes");

	public uint SampleRate => GetProperty<uint>("sampleRate");

	public ulong MaxStorageAge => GetProperty<ulong>("maxStorageAge");

	public ResourceStatsManager(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}

	public Promise<nsISupports> GetStats()
	{
		return CallMethod<Promise<nsISupports>>("getStats", new object[0]);
	}

	public Promise<nsISupports> GetStats(object statsOptions)
	{
		return CallMethod<Promise<nsISupports>>("getStats", new object[1] { statsOptions });
	}

	public Promise<nsISupports> GetStats(object statsOptions, nsISupports start)
	{
		return CallMethod<Promise<nsISupports>>("getStats", new object[2] { statsOptions, start });
	}

	public Promise<nsISupports> GetStats(object statsOptions, nsISupports start, nsISupports end)
	{
		return CallMethod<Promise<nsISupports>>("getStats", new object[3] { statsOptions, start, end });
	}

	public Promise<object> ClearStats()
	{
		return CallMethod<Promise<object>>("clearStats", new object[0]);
	}

	public Promise<object> ClearStats(object statsOptions)
	{
		return CallMethod<Promise<object>>("clearStats", new object[1] { statsOptions });
	}

	public Promise<object> ClearStats(object statsOptions, nsISupports start)
	{
		return CallMethod<Promise<object>>("clearStats", new object[2] { statsOptions, start });
	}

	public Promise<object> ClearStats(object statsOptions, nsISupports start, nsISupports end)
	{
		return CallMethod<Promise<object>>("clearStats", new object[3] { statsOptions, start, end });
	}

	public Promise<object> ClearAllStats()
	{
		return CallMethod<Promise<object>>("clearAllStats", new object[0]);
	}

	public Promise<uint> AddAlarm(ulong threshold)
	{
		return CallMethod<Promise<uint>>("addAlarm", new object[1] { threshold });
	}

	public Promise<uint> AddAlarm(ulong threshold, object statsOptions)
	{
		return CallMethod<Promise<uint>>("addAlarm", new object[2] { threshold, statsOptions });
	}

	public Promise<uint> AddAlarm(ulong threshold, object statsOptions, object alarmOptions)
	{
		return CallMethod<Promise<uint>>("addAlarm", new object[3] { threshold, statsOptions, alarmOptions });
	}

	public Promise<nsISupports[]> GetAlarms()
	{
		return CallMethod<Promise<nsISupports[]>>("getAlarms", new object[0]);
	}

	public Promise<nsISupports[]> GetAlarms(object statsOptions)
	{
		return CallMethod<Promise<nsISupports[]>>("getAlarms", new object[1] { statsOptions });
	}

	public Promise<object> RemoveAlarm(uint alarmId)
	{
		return CallMethod<Promise<object>>("removeAlarm", new object[1] { alarmId });
	}

	public Promise<object> RemoveAllAlarms()
	{
		return CallMethod<Promise<object>>("removeAllAlarms", new object[0]);
	}

	public Promise<string[]> GetAvailableComponents()
	{
		return CallMethod<Promise<string[]>>("getAvailableComponents", new object[0]);
	}
}
