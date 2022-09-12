namespace Gecko.WebIDL;

public class MediaRecorder : WebIDLBase
{
	public nsISupports Stream => GetProperty<nsISupports>("stream");

	public RecordingState State => GetProperty<RecordingState>("state");

	public string MimeType => GetProperty<string>("mimeType");

	public MediaRecorder(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}

	public void Start()
	{
		CallVoidMethod("start");
	}

	public void Start(int timeSlice)
	{
		CallVoidMethod("start", timeSlice);
	}

	public void Stop()
	{
		CallVoidMethod("stop");
	}

	public void Pause()
	{
		CallVoidMethod("pause");
	}

	public void Resume()
	{
		CallVoidMethod("resume");
	}

	public void RequestData()
	{
		CallVoidMethod("requestData");
	}
}
