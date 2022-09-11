using System.Windows.Automation;
using White.Core.UIItems.Actions;

namespace White.Core.UIItems;

public class ProgressBar : UIItem
{
	public virtual double Minimum => (double)Property(RangeValuePattern.MinimumProperty);

	public virtual double Maximum => (double)Property(RangeValuePattern.MaximumProperty);

	public virtual double Value => (double)Property(RangeValuePattern.ValueProperty);

	protected ProgressBar()
	{
	}

	public ProgressBar(AutomationElement automationElement, ActionListener actionListener)
		: base(automationElement, actionListener)
	{
	}
}
