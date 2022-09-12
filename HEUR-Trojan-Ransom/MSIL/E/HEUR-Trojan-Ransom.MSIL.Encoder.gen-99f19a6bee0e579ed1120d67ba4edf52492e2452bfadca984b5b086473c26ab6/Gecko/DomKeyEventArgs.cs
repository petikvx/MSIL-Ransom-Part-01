namespace Gecko;

public class DomKeyEventArgs : DomUIEventArgs
{
	private nsIDOMKeyEvent _Event;

	public uint KeyChar => _Event.GetCharCodeAttribute();

	public uint KeyCode => _Event.GetKeyCodeAttribute();

	public bool AltKey => _Event.GetAltKeyAttribute();

	public bool CtrlKey => _Event.GetCtrlKeyAttribute();

	public bool ShiftKey => _Event.GetShiftKeyAttribute();

	protected DomKeyEventArgs(nsIDOMKeyEvent ev)
		: base(ev)
	{
		_Event = ev;
	}

	public static DomKeyEventArgs Create(nsIDOMKeyEvent ev)
	{
		return new DomKeyEventArgs(ev);
	}
}
