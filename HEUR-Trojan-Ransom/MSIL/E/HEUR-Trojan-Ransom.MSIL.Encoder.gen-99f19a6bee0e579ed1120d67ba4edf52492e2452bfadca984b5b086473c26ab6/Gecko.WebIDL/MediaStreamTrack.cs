namespace Gecko.WebIDL;

public class MediaStreamTrack : WebIDLBase
{
	public string Kind => GetProperty<string>("kind");

	public string Id => GetProperty<string>("id");

	public string Label => GetProperty<string>("label");

	public bool Enabled
	{
		get
		{
			return GetProperty<bool>("enabled");
		}
		set
		{
			SetProperty("enabled", value);
		}
	}

	public MediaStreamTrack(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}

	public void Stop()
	{
		CallVoidMethod("stop");
	}

	public Promise ApplyConstraints()
	{
		return CallMethod<Promise>("applyConstraints", new object[0]);
	}

	public Promise ApplyConstraints(object constraints)
	{
		return CallMethod<Promise>("applyConstraints", new object[1] { constraints });
	}
}
