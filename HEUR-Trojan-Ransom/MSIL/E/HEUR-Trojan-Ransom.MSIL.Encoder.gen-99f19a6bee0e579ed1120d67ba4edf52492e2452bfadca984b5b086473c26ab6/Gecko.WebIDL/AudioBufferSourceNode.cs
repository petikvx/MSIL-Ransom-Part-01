namespace Gecko.WebIDL;

public class AudioBufferSourceNode : WebIDLBase
{
	public nsISupports Buffer
	{
		get
		{
			return GetProperty<nsISupports>("buffer");
		}
		set
		{
			SetProperty("buffer", value);
		}
	}

	public nsISupports PlaybackRate => GetProperty<nsISupports>("playbackRate");

	public nsISupports Detune => GetProperty<nsISupports>("detune");

	public bool Loop
	{
		get
		{
			return GetProperty<bool>("loop");
		}
		set
		{
			SetProperty("loop", value);
		}
	}

	public double LoopStart
	{
		get
		{
			return GetProperty<double>("loopStart");
		}
		set
		{
			SetProperty("loopStart", value);
		}
	}

	public double LoopEnd
	{
		get
		{
			return GetProperty<double>("loopEnd");
		}
		set
		{
			SetProperty("loopEnd", value);
		}
	}

	public AudioBufferSourceNode(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}

	public void Start()
	{
		CallVoidMethod("start");
	}

	public void Start(double when)
	{
		CallVoidMethod("start", when);
	}

	public void Start(double when, double grainOffset)
	{
		CallVoidMethod("start", when, grainOffset);
	}

	public void Start(double when, double grainOffset, double grainDuration)
	{
		CallVoidMethod("start", when, grainOffset, grainDuration);
	}

	public void Stop()
	{
		CallVoidMethod("stop");
	}

	public void Stop(double when)
	{
		CallVoidMethod("stop", when);
	}
}
