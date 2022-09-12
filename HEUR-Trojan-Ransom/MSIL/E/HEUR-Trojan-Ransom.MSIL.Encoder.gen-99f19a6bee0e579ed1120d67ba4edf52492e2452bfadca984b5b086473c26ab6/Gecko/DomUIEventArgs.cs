namespace Gecko;

public class DomUIEventArgs : DomEventArgs
{
	private nsIDOMUIEvent _Event;

	public int Detail => _Event.GetDetailAttribute();

	internal DomUIEventArgs(nsIDOMUIEvent ev)
		: base(ev)
	{
		_Event = ev;
	}

	public static DomUIEventArgs Create(nsIDOMUIEvent ev)
	{
		if (ev is nsIDOMMouseEvent)
		{
			return DomMouseEventArgs.Create((nsIDOMMouseEvent)ev);
		}
		if (ev is nsIDOMKeyEvent)
		{
			return DomKeyEventArgs.Create((nsIDOMKeyEvent)ev);
		}
		return new DomUIEventArgs(ev);
	}
}
