using Gecko.DOM;

namespace Gecko;

public class DomMouseEventArgs : DomUIEventArgs
{
	private nsIDOMMouseEvent _domMouseEvent;

	public int ClientX => _domMouseEvent.GetClientXAttribute();

	public int ClientY => _domMouseEvent.GetClientYAttribute();

	public int ScreenX => _domMouseEvent.GetScreenXAttribute();

	public int ScreenY => _domMouseEvent.GetScreenYAttribute();

	public GeckoMouseButton Button => (GeckoMouseButton)_domMouseEvent.GetButtonAttribute();

	public bool AltKey => _domMouseEvent.GetAltKeyAttribute();

	public bool CtrlKey => _domMouseEvent.GetCtrlKeyAttribute();

	public bool ShiftKey => _domMouseEvent.GetShiftKeyAttribute();

	protected DomMouseEventArgs(nsIDOMMouseEvent ev)
		: base(ev)
	{
		_domMouseEvent = ev;
	}

	public static DomMouseEventArgs Create(nsIDOMMouseEvent ev)
	{
		if (ev is nsIDOMMouseScrollEvent)
		{
			return DomMouseScrollEventArgs.Create((nsIDOMMouseScrollEvent)ev);
		}
		if (ev is nsIDOMDragEvent)
		{
			return DomDragEventArgs.Create((nsIDOMDragEvent)ev);
		}
		return new DomMouseEventArgs(ev);
	}

	public void InitMouseEvent(string type, bool canBubble, bool cancelable, GeckoWindow view, int detail, int screenX, int screenY, int clientX, int clientY, bool ctrlKey, bool altKey, bool shiftKey, bool metaKey, ushort button, DomEventTarget target)
	{
		using nsAString typeArg = new nsAString(type);
		_domMouseEvent.InitMouseEvent(typeArg, canBubble, cancelable, view.DomWindow, detail, screenX, screenY, clientX, clientY, ctrlKey, altKey, shiftKey, metaKey, button, target.NativeObject);
	}
}
