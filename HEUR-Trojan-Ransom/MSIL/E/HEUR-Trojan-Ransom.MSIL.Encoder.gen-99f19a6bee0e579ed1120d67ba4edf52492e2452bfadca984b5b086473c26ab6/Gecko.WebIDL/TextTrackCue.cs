namespace Gecko.WebIDL;

public class TextTrackCue : WebIDLBase
{
	public nsISupports Track => GetProperty<nsISupports>("track");

	public string Id
	{
		get
		{
			return GetProperty<string>("id");
		}
		set
		{
			SetProperty("id", value);
		}
	}

	public double StartTime
	{
		get
		{
			return GetProperty<double>("startTime");
		}
		set
		{
			SetProperty("startTime", value);
		}
	}

	public double EndTime
	{
		get
		{
			return GetProperty<double>("endTime");
		}
		set
		{
			SetProperty("endTime", value);
		}
	}

	public bool PauseOnExit
	{
		get
		{
			return GetProperty<bool>("pauseOnExit");
		}
		set
		{
			SetProperty("pauseOnExit", value);
		}
	}

	public TextTrackCue(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}
}
