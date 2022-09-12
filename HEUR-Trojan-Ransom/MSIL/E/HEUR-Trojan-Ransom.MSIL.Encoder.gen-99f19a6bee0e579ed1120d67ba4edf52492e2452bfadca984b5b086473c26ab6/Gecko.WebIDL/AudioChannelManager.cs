namespace Gecko.WebIDL;

public class AudioChannelManager : WebIDLBase
{
	public bool Headphones => GetProperty<bool>("headphones");

	public string VolumeControlChannel
	{
		get
		{
			return GetProperty<string>("volumeControlChannel");
		}
		set
		{
			SetProperty("volumeControlChannel", value);
		}
	}

	public nsISupports[] AllowedAudioChannels => GetProperty<nsISupports[]>("allowedAudioChannels");

	public AudioChannelManager(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}
}
