using System;

namespace Gecko.WebIDL;

public class FMRadio : WebIDLBase
{
	public bool Enabled => GetProperty<bool>("enabled");

	public bool RdsEnabled => GetProperty<bool>("rdsEnabled");

	public bool AntennaAvailable => GetProperty<bool>("antennaAvailable");

	public double? Frequency => GetProperty<double?>("frequency");

	public double FrequencyUpperBound => GetProperty<double>("frequencyUpperBound");

	public double FrequencyLowerBound => GetProperty<double>("frequencyLowerBound");

	public double ChannelWidth => GetProperty<double>("channelWidth");

	public uint RdsGroupMask
	{
		get
		{
			return GetProperty<uint>("rdsGroupMask");
		}
		set
		{
			SetProperty("rdsGroupMask", value);
		}
	}

	public ushort? Pi => GetProperty<ushort?>("pi");

	public byte? Pty => GetProperty<byte?>("pty");

	public string Ps => GetProperty<string>("ps");

	public string Rt => GetProperty<string>("rt");

	public IntPtr Rdsgroup => GetProperty<IntPtr>("rdsgroup");

	public FMRadio(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}

	public nsISupports Disable()
	{
		return CallMethod<nsISupports>("disable", new object[0]);
	}

	public nsISupports Enable(double frequency)
	{
		return CallMethod<nsISupports>("enable", new object[1] { frequency });
	}

	public nsISupports SetFrequency(double frequency)
	{
		return CallMethod<nsISupports>("setFrequency", new object[1] { frequency });
	}

	public nsISupports SeekUp()
	{
		return CallMethod<nsISupports>("seekUp", new object[0]);
	}

	public nsISupports SeekDown()
	{
		return CallMethod<nsISupports>("seekDown", new object[0]);
	}

	public nsISupports CancelSeek()
	{
		return CallMethod<nsISupports>("cancelSeek", new object[0]);
	}

	public nsISupports EnableRDS()
	{
		return CallMethod<nsISupports>("enableRDS", new object[0]);
	}

	public nsISupports DisableRDS()
	{
		return CallMethod<nsISupports>("disableRDS", new object[0]);
	}
}
