using System.Windows.Automation;
using White.Core.UIItems.Actions;

namespace White.Core.UIItems;

public class Thumb : UIItem
{
	protected Thumb()
	{
	}

	public Thumb(AutomationElement automationElement, ActionListener actionListener)
		: base(automationElement, actionListener)
	{
	}

	public virtual void SlideHorizontally(int distance)
	{
		UIItem.mouse.DragHorizontally(this, distance);
		actionListener.ActionPerformed(Action.WindowMessage);
	}

	public virtual void SlideVertically(int distance)
	{
		UIItem.mouse.DragVertically(this, distance);
		actionListener.ActionPerformed(Action.WindowMessage);
	}
}
