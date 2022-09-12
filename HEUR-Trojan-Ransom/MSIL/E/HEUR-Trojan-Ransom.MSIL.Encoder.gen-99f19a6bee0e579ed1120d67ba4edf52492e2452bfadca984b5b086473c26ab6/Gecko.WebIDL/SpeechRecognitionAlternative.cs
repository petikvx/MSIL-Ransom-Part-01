namespace Gecko.WebIDL;

public class SpeechRecognitionAlternative : WebIDLBase
{
	public string Transcript => GetProperty<string>("transcript");

	public float Confidence => GetProperty<float>("confidence");

	public SpeechRecognitionAlternative(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}
}
