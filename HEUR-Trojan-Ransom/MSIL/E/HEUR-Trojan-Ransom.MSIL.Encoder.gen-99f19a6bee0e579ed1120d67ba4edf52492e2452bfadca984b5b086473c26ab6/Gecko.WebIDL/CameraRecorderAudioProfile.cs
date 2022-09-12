namespace Gecko.WebIDL;

public class CameraRecorderAudioProfile : WebIDLBase
{
	public string Codec => GetProperty<string>("codec");

	public uint BitsPerSecond => GetProperty<uint>("bitsPerSecond");

	public uint SamplesPerSecond => GetProperty<uint>("samplesPerSecond");

	public uint Channels => GetProperty<uint>("channels");

	public CameraRecorderAudioProfile(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}
}
