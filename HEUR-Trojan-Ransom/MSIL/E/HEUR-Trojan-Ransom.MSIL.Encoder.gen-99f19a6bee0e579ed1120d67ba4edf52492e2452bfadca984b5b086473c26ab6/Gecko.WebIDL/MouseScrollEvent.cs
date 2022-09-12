namespace Gecko.WebIDL;

public class MouseScrollEvent : WebIDLBase
{
	public int Axis => GetProperty<int>("axis");

	public MouseScrollEvent(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}

	public void InitMouseScrollEvent(string type, bool canBubble, bool cancelable, nsIDOMWindow view, int detail, int screenX, int screenY, int clientX, int clientY, bool ctrlKey, bool altKey, bool shiftKey, bool metaKey, ushort button, nsISupports relatedTarget, int axis)
	{
		CallVoidMethod("initMouseScrollEvent", type, canBubble, cancelable, view, detail, screenX, screenY, clientX, clientY, ctrlKey, altKey, shiftKey, metaKey, button, relatedTarget, axis);
	}
}
