namespace Gecko.WebIDL;

public class VideoPlaybackQuality : WebIDLBase
{
	public double CreationTime => GetProperty<double>("creationTime");

	public uint TotalVideoFrames => GetProperty<uint>("totalVideoFrames");

	public uint DroppedVideoFrames => GetProperty<uint>("droppedVideoFrames");

	public uint CorruptedVideoFrames => GetProperty<uint>("corruptedVideoFrames");

	public VideoPlaybackQuality(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}
}
