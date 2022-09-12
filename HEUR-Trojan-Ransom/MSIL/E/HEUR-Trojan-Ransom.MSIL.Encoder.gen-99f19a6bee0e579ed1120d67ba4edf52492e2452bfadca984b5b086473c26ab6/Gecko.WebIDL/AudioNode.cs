namespace Gecko.WebIDL;

public class AudioNode : WebIDLBase
{
	public nsISupports Context => GetProperty<nsISupports>("context");

	public uint NumberOfInputs => GetProperty<uint>("numberOfInputs");

	public uint NumberOfOutputs => GetProperty<uint>("numberOfOutputs");

	public uint ChannelCount
	{
		get
		{
			return GetProperty<uint>("channelCount");
		}
		set
		{
			SetProperty("channelCount", value);
		}
	}

	public ChannelCountMode ChannelCountMode
	{
		get
		{
			return GetProperty<ChannelCountMode>("channelCountMode");
		}
		set
		{
			SetProperty("channelCountMode", value);
		}
	}

	public ChannelInterpretation ChannelInterpretation
	{
		get
		{
			return GetProperty<ChannelInterpretation>("channelInterpretation");
		}
		set
		{
			SetProperty("channelInterpretation", value);
		}
	}

	public uint Id => GetProperty<uint>("id");

	public AudioNode(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}

	public nsISupports Connect(nsISupports destination)
	{
		return CallMethod<nsISupports>("connect", new object[1] { destination });
	}

	public nsISupports Connect(nsISupports destination, uint output)
	{
		return CallMethod<nsISupports>("connect", new object[2] { destination, output });
	}

	public nsISupports Connect(nsISupports destination, uint output, uint input)
	{
		return CallMethod<nsISupports>("connect", new object[3] { destination, output, input });
	}

	public void Disconnect()
	{
		CallVoidMethod("disconnect");
	}

	public void Disconnect(uint output)
	{
		CallVoidMethod("disconnect", output);
	}
}
