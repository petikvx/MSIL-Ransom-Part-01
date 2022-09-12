namespace Gecko.WebIDL;

public class SpeechSynthesisEvent : WebIDLBase
{
	public nsISupports Utterance => GetProperty<nsISupports>("utterance");

	public uint CharIndex => GetProperty<uint>("charIndex");

	public float ElapsedTime => GetProperty<float>("elapsedTime");

	public string Name => GetProperty<string>("name");

	public SpeechSynthesisEvent(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}
}
