namespace Gecko.WebIDL;

public class VideoTrack : WebIDLBase
{
	public string Id => GetProperty<string>("id");

	public string Kind => GetProperty<string>("kind");

	public string Label => GetProperty<string>("label");

	public string Language => GetProperty<string>("language");

	public bool Selected
	{
		get
		{
			return GetProperty<bool>("selected");
		}
		set
		{
			SetProperty("selected", value);
		}
	}

	public VideoTrack(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}
}
