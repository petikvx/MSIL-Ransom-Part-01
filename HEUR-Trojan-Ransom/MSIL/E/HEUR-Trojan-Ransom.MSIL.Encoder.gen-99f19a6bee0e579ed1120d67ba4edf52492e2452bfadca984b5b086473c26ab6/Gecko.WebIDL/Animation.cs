namespace Gecko.WebIDL;

public class Animation : WebIDLBase
{
	public nsISupports Effect => GetProperty<nsISupports>("effect");

	public nsISupports Timeline => GetProperty<nsISupports>("timeline");

	public double? StartTime
	{
		get
		{
			return GetProperty<double?>("startTime");
		}
		set
		{
			SetProperty("startTime", value);
		}
	}

	public double? CurrentTime
	{
		get
		{
			return GetProperty<double?>("currentTime");
		}
		set
		{
			SetProperty("currentTime", value);
		}
	}

	public double PlaybackRate
	{
		get
		{
			return GetProperty<double>("playbackRate");
		}
		set
		{
			SetProperty("playbackRate", value);
		}
	}

	public AnimationPlayState PlayState => GetProperty<AnimationPlayState>("playState");

	public Promise<nsISupports> Ready => GetProperty<Promise<nsISupports>>("ready");

	public Promise<nsISupports> Finished => GetProperty<Promise<nsISupports>>("finished");

	public bool IsRunningOnCompositor => GetProperty<bool>("isRunningOnCompositor");

	public Animation(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}

	public void Cancel()
	{
		CallVoidMethod("cancel");
	}

	public void Finish()
	{
		CallVoidMethod("finish");
	}

	public void Play()
	{
		CallVoidMethod("play");
	}

	public void Pause()
	{
		CallVoidMethod("pause");
	}

	public void Reverse()
	{
		CallVoidMethod("reverse");
	}
}
