namespace Gecko.WebIDL;

public class OfflineAudioCompletionEvent : WebIDLBase
{
	public nsISupports RenderedBuffer => GetProperty<nsISupports>("renderedBuffer");

	public OfflineAudioCompletionEvent(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}
}
