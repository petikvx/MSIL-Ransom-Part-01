namespace Gecko.WebIDL;

public class MediaSource : WebIDLBase
{
	public nsISupports SourceBuffers => GetProperty<nsISupports>("sourceBuffers");

	public nsISupports ActiveSourceBuffers => GetProperty<nsISupports>("activeSourceBuffers");

	public MediaSourceReadyState ReadyState => GetProperty<MediaSourceReadyState>("readyState");

	public double Duration
	{
		get
		{
			return GetProperty<double>("duration");
		}
		set
		{
			SetProperty("duration", value);
		}
	}

	public string MozDebugReaderData => GetProperty<string>("mozDebugReaderData");

	public MediaSource(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}

	public nsISupports AddSourceBuffer(string type)
	{
		return CallMethod<nsISupports>("addSourceBuffer", new object[1] { type });
	}

	public void RemoveSourceBuffer(nsISupports sourceBuffer)
	{
		CallVoidMethod("removeSourceBuffer", sourceBuffer);
	}

	public void EndOfStream()
	{
		CallVoidMethod("endOfStream");
	}

	public void EndOfStream(MediaSourceEndOfStreamError error)
	{
		CallVoidMethod("endOfStream", error);
	}
}
