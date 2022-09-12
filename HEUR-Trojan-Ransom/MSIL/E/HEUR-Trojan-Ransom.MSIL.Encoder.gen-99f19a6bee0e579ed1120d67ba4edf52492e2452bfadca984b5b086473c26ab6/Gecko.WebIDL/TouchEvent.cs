namespace Gecko.WebIDL;

public class TouchEvent : WebIDLBase
{
	public nsISupports Touches => GetProperty<nsISupports>("touches");

	public nsISupports TargetTouches => GetProperty<nsISupports>("targetTouches");

	public nsISupports ChangedTouches => GetProperty<nsISupports>("changedTouches");

	public bool AltKey => GetProperty<bool>("altKey");

	public bool MetaKey => GetProperty<bool>("metaKey");

	public bool CtrlKey => GetProperty<bool>("ctrlKey");

	public bool ShiftKey => GetProperty<bool>("shiftKey");

	public TouchEvent(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}

	public void InitTouchEvent(string type, bool canBubble, bool cancelable, nsIDOMWindow view, int detail, bool ctrlKey, bool altKey, bool shiftKey, bool metaKey, nsISupports touches, nsISupports targetTouches, nsISupports changedTouches)
	{
		CallVoidMethod("initTouchEvent", type, canBubble, cancelable, view, detail, ctrlKey, altKey, shiftKey, metaKey, touches, targetTouches, changedTouches);
	}
}
