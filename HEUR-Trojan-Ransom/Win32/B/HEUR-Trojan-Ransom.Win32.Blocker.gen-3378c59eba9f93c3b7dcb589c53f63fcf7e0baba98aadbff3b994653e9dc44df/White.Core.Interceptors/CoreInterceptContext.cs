using System;
using System.Windows.Automation;
using White.Core.Bricks;
using White.Core.UIItems;
using White.Core.UIItems.Actions;

namespace White.Core.Interceptors;

public class CoreInterceptContext : IInterceptContext
{
	private readonly IUIItem uiItem;

	private readonly ActionListener actionListener;

	public virtual IUIItem UiItem => uiItem;

	public virtual ActionListener ActionListener => actionListener;

	public virtual object Target => uiItem;

	public CoreInterceptContext(IUIItem uiItem, ActionListener actionListener)
	{
		this.uiItem = uiItem;
		this.actionListener = actionListener;
	}

	public virtual void VerifyUIItem()
	{
		if (uiItem.AutomationElement == (AutomationElement)null)
		{
			throw new NullReferenceException("AutomationElement in this UIItem is null");
		}
	}
}
