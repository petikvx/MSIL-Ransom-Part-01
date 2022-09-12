namespace Gecko.WebIDL;

public class XULCommandEvent : WebIDLBase
{
	public bool CtrlKey => GetProperty<bool>("ctrlKey");

	public bool ShiftKey => GetProperty<bool>("shiftKey");

	public bool AltKey => GetProperty<bool>("altKey");

	public bool MetaKey => GetProperty<bool>("metaKey");

	public nsIDOMEvent SourceEvent => GetProperty<nsIDOMEvent>("sourceEvent");

	public XULCommandEvent(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}

	public void InitCommandEvent(string type, bool canBubble, bool cancelable, nsIDOMWindow view, int detail, bool ctrlKey, bool altKey, bool shiftKey, bool metaKey, nsIDOMEvent sourceEvent)
	{
		CallVoidMethod("initCommandEvent", type, canBubble, cancelable, view, detail, ctrlKey, altKey, shiftKey, metaKey, sourceEvent);
	}
}
