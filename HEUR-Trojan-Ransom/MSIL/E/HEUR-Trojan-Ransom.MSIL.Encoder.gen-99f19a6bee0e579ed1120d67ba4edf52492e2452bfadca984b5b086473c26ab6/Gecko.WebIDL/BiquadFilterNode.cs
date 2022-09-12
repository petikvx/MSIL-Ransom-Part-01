using System;

namespace Gecko.WebIDL;

public class BiquadFilterNode : WebIDLBase
{
	public BiquadFilterType Type
	{
		get
		{
			return GetProperty<BiquadFilterType>("type");
		}
		set
		{
			SetProperty("type", value);
		}
	}

	public nsISupports Frequency => GetProperty<nsISupports>("frequency");

	public nsISupports Detune => GetProperty<nsISupports>("detune");

	public nsISupports Q => GetProperty<nsISupports>("Q");

	public nsISupports Gain => GetProperty<nsISupports>("gain");

	public BiquadFilterNode(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}

	public void GetFrequencyResponse(IntPtr frequencyHz, IntPtr magResponse, IntPtr phaseResponse)
	{
		CallVoidMethod("getFrequencyResponse", frequencyHz, magResponse, phaseResponse);
	}
}
