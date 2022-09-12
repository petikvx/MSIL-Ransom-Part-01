namespace Gecko.WebIDL;

public class TVProgram : WebIDLBase
{
	public string EventId => GetProperty<string>("eventId");

	public nsISupports Channel => GetProperty<nsISupports>("channel");

	public string Title => GetProperty<string>("title");

	public ulong StartTime => GetProperty<ulong>("startTime");

	public ulong Duration => GetProperty<ulong>("duration");

	public string Description => GetProperty<string>("description");

	public string Rating => GetProperty<string>("rating");

	public TVProgram(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}

	public string[] GetAudioLanguages()
	{
		return CallMethod<string[]>("getAudioLanguages", new object[0]);
	}

	public string[] GetSubtitleLanguages()
	{
		return CallMethod<string[]>("getSubtitleLanguages", new object[0]);
	}
}
