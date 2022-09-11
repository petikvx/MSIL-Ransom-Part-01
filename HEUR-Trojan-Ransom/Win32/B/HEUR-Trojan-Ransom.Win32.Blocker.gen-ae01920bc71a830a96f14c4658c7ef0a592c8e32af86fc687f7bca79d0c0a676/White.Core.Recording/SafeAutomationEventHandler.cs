using System;
using System.Windows.Automation;
using White.Core.UIItemEvents;
using White.Core.UIItems;
using log4net;

namespace White.Core.Recording;

public class SafeAutomationEventHandler
{
	public delegate UserEvent Create(object[] parameters);

	private readonly IUIItem uiItem;

	private readonly Create createUserEvent;

	private readonly UIItemEventListener eventListener;

	private readonly ILog logger = LogManager.GetLogger(typeof(SafeAutomationEventHandler));

	public SafeAutomationEventHandler(IUIItem uiItem, UIItemEventListener eventListener, Create createUserEvent)
	{
		this.uiItem = uiItem;
		this.eventListener = eventListener;
		this.createUserEvent = createUserEvent;
	}

	public virtual void PropertyChange(object sender, AutomationPropertyChangedEventArgs e)
	{
		UserEvent userEvent = UserEvent(e);
		if (userEvent == null)
		{
			return;
		}
		try
		{
			eventListener.EventOccured(userEvent);
		}
		catch (Exception ex)
		{
			logger.Error((object)"", ex);
		}
	}

	private UserEvent UserEvent(AutomationPropertyChangedEventArgs e)
	{
		try
		{
			return createUserEvent(new object[1] { e });
		}
		catch (Exception exception)
		{
			return new ExceptionEvent(uiItem, exception);
		}
	}
}
