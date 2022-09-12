using Gecko.DOM;

namespace Gecko;

public class DomMouseScrollEventArgs : DomMouseEventArgs
{
	private nsIDOMMouseScrollEvent _mouseScrollEvent;

	public int Axis => _mouseScrollEvent.GetAxisAttribute();

	private DomMouseScrollEventArgs(nsIDOMMouseScrollEvent ev)
		: base(ev)
	{
		_mouseScrollEvent = ev;
	}

	public static DomMouseScrollEventArgs Create(nsIDOMMouseScrollEvent ev)
	{
		return new DomMouseScrollEventArgs(ev);
	}

	public void InitMouseScrollEvent(string type, bool canBubble, bool cancelable, GeckoWindow view, int detail, int screenX, int screenY, int clientX, int clientY, bool ctrlKey, bool altKey, bool shiftKey, bool metaKey, ushort button, DomEventTarget target, int axis)
	{
		using nsAString typeArg = new nsAString(type);
		_mouseScrollEvent.InitMouseScrollEvent(typeArg, canBubble, cancelable, view.DomWindow, detail, screenX, screenY, clientX, clientY, ctrlKey, altKey, shiftKey, metaKey, button, target.NativeObject, axis);
	}
}
