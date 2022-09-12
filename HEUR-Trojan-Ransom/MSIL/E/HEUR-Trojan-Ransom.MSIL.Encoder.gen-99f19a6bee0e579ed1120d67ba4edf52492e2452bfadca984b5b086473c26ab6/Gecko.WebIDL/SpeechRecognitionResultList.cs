namespace Gecko.WebIDL;

public class SpeechRecognitionResultList : WebIDLBase
{
	public uint Length => GetProperty<uint>("length");

	public SpeechRecognitionResultList(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}
}
