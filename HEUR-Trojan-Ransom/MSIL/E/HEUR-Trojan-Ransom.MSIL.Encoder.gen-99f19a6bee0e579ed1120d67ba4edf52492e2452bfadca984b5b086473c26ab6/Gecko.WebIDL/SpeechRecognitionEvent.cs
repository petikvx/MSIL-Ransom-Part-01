namespace Gecko.WebIDL;

public class SpeechRecognitionEvent : WebIDLBase
{
	public uint ResultIndex => GetProperty<uint>("resultIndex");

	public nsISupports Results => GetProperty<nsISupports>("results");

	public object Interpretation => GetProperty<object>("interpretation");

	public nsIDOMDocument Emma => GetProperty<nsIDOMDocument>("emma");

	public SpeechRecognitionEvent(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}
}
