namespace Gecko.WebIDL;

public class MozSpeakerManager : WebIDLBase
{
	public bool Speakerforced => GetProperty<bool>("speakerforced");

	public bool Forcespeaker
	{
		get
		{
			return GetProperty<bool>("forcespeaker");
		}
		set
		{
			SetProperty("forcespeaker", value);
		}
	}

	public MozSpeakerManager(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}
}
