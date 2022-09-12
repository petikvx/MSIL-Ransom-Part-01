namespace Gecko.WebIDL;

public class KeyEvent : WebIDLBase
{
	public KeyEvent(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}

	public void InitKeyEvent(string type, bool canBubble, bool cancelable, nsIDOMWindow view, bool ctrlKey, bool altKey, bool shiftKey, bool metaKey, uint keyCode, uint charCode)
	{
		CallVoidMethod("initKeyEvent", type, canBubble, cancelable, view, ctrlKey, altKey, shiftKey, metaKey, keyCode, charCode);
	}
}
