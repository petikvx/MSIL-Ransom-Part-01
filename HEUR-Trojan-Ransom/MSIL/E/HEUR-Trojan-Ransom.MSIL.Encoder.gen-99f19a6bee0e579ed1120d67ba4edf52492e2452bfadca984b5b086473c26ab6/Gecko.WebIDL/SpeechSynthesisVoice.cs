namespace Gecko.WebIDL;

public class SpeechSynthesisVoice : WebIDLBase
{
	public string VoiceURI => GetProperty<string>("voiceURI");

	public string Name => GetProperty<string>("name");

	public string Lang => GetProperty<string>("lang");

	public bool LocalService => GetProperty<bool>("localService");

	public bool Default => GetProperty<bool>("default");

	public SpeechSynthesisVoice(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}
}
