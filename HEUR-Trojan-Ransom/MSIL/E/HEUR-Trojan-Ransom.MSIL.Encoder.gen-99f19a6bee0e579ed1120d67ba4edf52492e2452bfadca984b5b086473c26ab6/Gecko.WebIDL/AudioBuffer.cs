using System;

namespace Gecko.WebIDL;

public class AudioBuffer : WebIDLBase
{
	public float SampleRate => GetProperty<float>("sampleRate");

	public int Length => GetProperty<int>("length");

	public double Duration => GetProperty<double>("duration");

	public int NumberOfChannels => GetProperty<int>("numberOfChannels");

	public AudioBuffer(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}

	public IntPtr GetChannelData(uint channel)
	{
		return CallMethod<IntPtr>("getChannelData", new object[1] { channel });
	}

	public void CopyFromChannel(IntPtr destination, int channelNumber)
	{
		CallVoidMethod("copyFromChannel", destination, channelNumber);
	}

	public void CopyFromChannel(IntPtr destination, int channelNumber, uint startInChannel)
	{
		CallVoidMethod("copyFromChannel", destination, channelNumber, startInChannel);
	}

	public void CopyToChannel(IntPtr source, int channelNumber)
	{
		CallVoidMethod("copyToChannel", source, channelNumber);
	}

	public void CopyToChannel(IntPtr source, int channelNumber, uint startInChannel)
	{
		CallVoidMethod("copyToChannel", source, channelNumber, startInChannel);
	}
}
