namespace Gecko.WebIDL;

public class AudioTrack : WebIDLBase
{
	public string Id => GetProperty<string>("id");

	public string Kind => GetProperty<string>("kind");

	public string Label => GetProperty<string>("label");

	public string Language => GetProperty<string>("language");

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

	public AudioTrack(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}
}
