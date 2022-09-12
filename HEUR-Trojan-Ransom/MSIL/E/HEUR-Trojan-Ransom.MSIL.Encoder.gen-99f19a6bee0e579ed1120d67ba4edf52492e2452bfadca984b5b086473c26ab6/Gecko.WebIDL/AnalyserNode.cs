using System;

namespace Gecko.WebIDL;

public class AnalyserNode : WebIDLBase
{
	public uint FftSize
	{
		get
		{
			return GetProperty<uint>("fftSize");
		}
		set
		{
			SetProperty("fftSize", value);
		}
	}

	public uint FrequencyBinCount => GetProperty<uint>("frequencyBinCount");

	public double MinDecibels
	{
		get
		{
			return GetProperty<double>("minDecibels");
		}
		set
		{
			SetProperty("minDecibels", value);
		}
	}

	public double MaxDecibels
	{
		get
		{
			return GetProperty<double>("maxDecibels");
		}
		set
		{
			SetProperty("maxDecibels", value);
		}
	}

	public double SmoothingTimeConstant
	{
		get
		{
			return GetProperty<double>("smoothingTimeConstant");
		}
		set
		{
			SetProperty("smoothingTimeConstant", value);
		}
	}

	public AnalyserNode(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}

	public void GetFloatFrequencyData(IntPtr array)
	{
		CallVoidMethod("getFloatFrequencyData", array);
	}

	public void GetByteFrequencyData(IntPtr array)
	{
		CallVoidMethod("getByteFrequencyData", array);
	}

	public void GetFloatTimeDomainData(IntPtr array)
	{
		CallVoidMethod("getFloatTimeDomainData", array);
	}

	public void GetByteTimeDomainData(IntPtr array)
	{
		CallVoidMethod("getByteTimeDomainData", array);
	}
}
