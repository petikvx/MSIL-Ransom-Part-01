using System;
using Gecko.DOM;
using Gecko.Interop;

namespace Gecko;

public class DomEventArgs : EventArgs
{
	private nsIDOMEvent _event;

	private bool _Handled;

	public nsIDOMEvent DomEvent => _event;

	public string Type => nsString.Get(_event.GetTypeAttribute);

	public bool Bubbles => _event.GetBubblesAttribute();

	public bool Cancelable => _event.GetCancelableAttribute();

	public bool GetDefaultPrevented => _event.GetDefaultPreventedAttribute();

	public long Timestamp => _event.GetTimeStampAttribute();

	public EventPhase EventPhase => (EventPhase)_event.GetEventPhaseAttribute();

	public DomEventTarget CurrentTarget => _event.GetCurrentTargetAttribute().Wrap(DomEventTarget.Create);

	public DomEventTarget Target => _event.GetTargetAttribute().Wrap(DomEventTarget.Create);

	public bool Handled
	{
		get
		{
			return _Handled;
		}
		set
		{
			_Handled = value;
		}
	}

	protected DomEventArgs(nsIDOMEvent ev)
	{
		_event = ev;
	}

	public static DomEventArgs Create(nsIDOMEvent ev)
	{
		switch (nsString.Get(ev.GetTypeAttribute).ToLowerInvariant())
		{
		case "dommousescroll":
			return DomMouseScrollEventArgs.Create((nsIDOMMouseScrollEvent)ev);
		case "keydown":
		case "keyup":
		case "keypress":
			return DomKeyEventArgs.Create((nsIDOMKeyEvent)ev);
		case "dragleave":
		case "dragend":
		case "dragenter":
		case "drag":
		case "drop":
		case "dragover":
		case "dragstart":
			return DomDragEventArgs.Create((nsIDOMDragEvent)ev);
		default:
			if (ev is nsIDOMUIEvent)
			{
				return DomUIEventArgs.Create((nsIDOMUIEvent)ev);
			}
			if (ev is nsIDOMMessageEvent)
			{
				return DomMessageEventArgs.Create((nsIDOMMessageEvent)ev);
			}
			return new DomEventArgs(ev);
		case "mousedown":
		case "mouseout":
		case "contextmenu":
		case "mouseover":
		case "mouseup":
		case "mousemove":
			return DomMouseEventArgs.Create((nsIDOMMouseEvent)ev);
		}
	}

	public void PreventDefault()
	{
		_event.PreventDefault();
	}

	public void StopPropagation()
	{
		_event.StopPropagation();
	}

	public void StopImmediatePropagation()
	{
		_event.StopImmediatePropagation();
	}
}
