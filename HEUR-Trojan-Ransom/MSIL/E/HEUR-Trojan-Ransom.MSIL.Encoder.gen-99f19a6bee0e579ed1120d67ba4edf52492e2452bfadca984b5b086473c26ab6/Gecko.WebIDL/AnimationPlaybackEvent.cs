namespace Gecko.WebIDL;

public class AnimationPlaybackEvent : WebIDLBase
{
	public double? CurrentTime => GetProperty<double?>("currentTime");

	public double? TimelineTime => GetProperty<double?>("timelineTime");

	public AnimationPlaybackEvent(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}
}
