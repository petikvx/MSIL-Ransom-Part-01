namespace Gecko.WebIDL;

public class MediaStream : WebIDLBase
{
	public string Id => GetProperty<string>("id");

	public double CurrentTime => GetProperty<double>("currentTime");

	public MediaStream(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}

	public nsISupports[] GetAudioTracks()
	{
		return CallMethod<nsISupports[]>("getAudioTracks", new object[0]);
	}

	public nsISupports[] GetVideoTracks()
	{
		return CallMethod<nsISupports[]>("getVideoTracks", new object[0]);
	}

	public nsISupports[] GetTracks()
	{
		return CallMethod<nsISupports[]>("getTracks", new object[0]);
	}

	public void AddTrack(nsISupports track)
	{
		CallVoidMethod("addTrack", track);
	}

	public void RemoveTrack(nsISupports track)
	{
		CallVoidMethod("removeTrack", track);
	}
}
