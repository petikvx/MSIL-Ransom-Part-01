namespace Gecko.WebIDL;

public class CameraRecorderVideoProfile : WebIDLBase
{
	public string Codec => GetProperty<string>("codec");

	public uint BitsPerSecond => GetProperty<uint>("bitsPerSecond");

	public uint FramesPerSecond => GetProperty<uint>("framesPerSecond");

	public object Size => GetProperty<object>("size");

	public uint Width => GetProperty<uint>("width");

	public uint Height => GetProperty<uint>("height");

	public CameraRecorderVideoProfile(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}
}
