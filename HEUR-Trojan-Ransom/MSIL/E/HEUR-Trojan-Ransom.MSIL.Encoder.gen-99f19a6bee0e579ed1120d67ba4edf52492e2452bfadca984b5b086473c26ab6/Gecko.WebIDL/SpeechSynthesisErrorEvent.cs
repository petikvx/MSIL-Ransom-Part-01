namespace Gecko.WebIDL;

public class SpeechSynthesisErrorEvent : WebIDLBase
{
	public SpeechSynthesisErrorCode Error => GetProperty<SpeechSynthesisErrorCode>("error");

	public SpeechSynthesisErrorEvent(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}
}
