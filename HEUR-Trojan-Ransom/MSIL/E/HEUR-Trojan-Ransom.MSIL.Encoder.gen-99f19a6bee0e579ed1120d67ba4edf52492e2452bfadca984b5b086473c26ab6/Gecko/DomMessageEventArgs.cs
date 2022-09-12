using System;

namespace Gecko;

public class DomMessageEventArgs : DomEventArgs
{
	private nsIDOMMessageEvent _messageEvent;

	public string Message
	{
		get
		{
			using AutoJSContext autoJSContext = new AutoJSContext(_messageEvent.GetTargetAttribute().GetJSContextForEventHandlers());
			JsVal dataAttribute = _messageEvent.GetDataAttribute(autoJSContext.ContextPointer);
			try
			{
				return dataAttribute.ToString();
			}
			catch (AccessViolationException ex)
			{
				throw ex;
			}
		}
	}

	private DomMessageEventArgs(nsIDOMMessageEvent ev)
		: base(ev)
	{
		_messageEvent = ev;
	}

	public static DomMessageEventArgs Create(nsIDOMMessageEvent ev)
	{
		return new DomMessageEventArgs(ev);
	}
}
