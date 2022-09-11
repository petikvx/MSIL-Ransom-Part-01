using System;
using System.Windows.Automation;
using White.Core.AutomationElementSearch;
using White.Core.Configuration;
using White.Core.Factory;
using White.Core.UIItems.Actions;
using White.Core.UIItems.Finders;
using White.Core.Utility;

namespace White.Core.UIItems.Scrolling;

public class ScrollBar : UIItem, IScrollBar
{
	private readonly ScrollBarButtonAutomationIds automationIds;

	private readonly PrimaryUIItemFactory primaryUIItemFactory;

	protected virtual Button BackSmallChangeButton => FindButton(actionListener, automationIds.BackwardSmall);

	protected virtual Button ForwardSmallChangeButton => FindButton(actionListener, automationIds.ForwardSmall);

	protected virtual Button BackLargeChangeButton => FindButton(actionListener, automationIds.BackwardLarge);

	protected virtual Button ForwardLargeChangeButton => FindButton(actionListener, automationIds.ForwardLarge);

	public virtual double Value => (double)Property(RangeValuePattern.ValueProperty);

	public virtual double MinimumValue => (double)Property(RangeValuePattern.MinimumProperty);

	public virtual double MaximumValue => (double)Property(RangeValuePattern.MaximumProperty);

	protected ScrollBar()
	{
	}

	protected ScrollBar(AutomationElement automationElement, ActionListener actionListener, ScrollBarButtonAutomationIds automationIds)
		: base(automationElement, actionListener)
	{
		this.automationIds = automationIds;
		AutomationElementFinder finder = new AutomationElementFinder(automationElement);
		primaryUIItemFactory = new PrimaryUIItemFactory(finder);
	}

	private Button FindButton(ActionListener listener, string automationId)
	{
		return (Button)primaryUIItemFactory.Create(SearchCriteria.ByControlType(ControlType.Button).AndAutomationId(automationId), listener);
	}

	public virtual void SetToMinimum()
	{
		double num = Retry.For(delegate
		{
			BackLargeChangeButton.PerformClick();
			return Value;
		}, (double v) => v > 0.0, CoreAppXmlConfiguration.Instance.BusyTimeout(), TimeSpan.FromMilliseconds(0.0));
		if (num > 0.0)
		{
			throw new UIActionException($"Could not set the ScrollBar to minimum visible{Constants.BusyMessage}");
		}
		logger.DebugFormat("ScrollBar position set to {0}", (object)Value);
	}

	public virtual void SetToMaximum()
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		((RangeValuePattern)Pattern(RangeValuePattern.Pattern)).SetValue(MaximumValue);
	}
}
