namespace Gecko.WebIDL;

public class OscillatorNode : WebIDLBase
{
	public OscillatorType Type
	{
		get
		{
			return GetProperty<OscillatorType>("type");
		}
		set
		{
			SetProperty("type", value);
		}
	}

	public nsISupports Frequency => GetProperty<nsISupports>("frequency");

	public nsISupports Detune => GetProperty<nsISupports>("detune");

	public OscillatorNode(nsIDOMWindow globalWindow, nsISupports thisObject)
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

	public void Stop()
	{
		CallVoidMethod("stop");
	}

	public void Stop(double when)
	{
		CallVoidMethod("stop", when);
	}

	public void SetPeriodicWave(nsISupports periodicWave)
	{
		CallVoidMethod("setPeriodicWave", periodicWave);
	}
}
