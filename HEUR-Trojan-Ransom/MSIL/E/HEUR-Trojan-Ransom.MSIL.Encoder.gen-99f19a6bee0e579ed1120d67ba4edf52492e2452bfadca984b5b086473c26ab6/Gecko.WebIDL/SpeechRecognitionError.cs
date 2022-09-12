namespace Gecko.WebIDL;

public class SpeechRecognitionError : WebIDLBase
{
	public SpeechRecognitionErrorCode Error => GetProperty<SpeechRecognitionErrorCode>("error");

	public string Message => GetProperty<string>("message");

	public SpeechRecognitionError(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}
}
