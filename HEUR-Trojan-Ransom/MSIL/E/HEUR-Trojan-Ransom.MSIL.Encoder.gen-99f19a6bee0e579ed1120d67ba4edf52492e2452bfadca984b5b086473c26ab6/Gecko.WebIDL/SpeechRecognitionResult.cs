namespace Gecko.WebIDL;

public class SpeechRecognitionResult : WebIDLBase
{
	public uint Length => GetProperty<uint>("length");

	public bool IsFinal => GetProperty<bool>("isFinal");

	public SpeechRecognitionResult(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}
}
