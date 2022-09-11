using System.Windows.Automation;
using White.Core.UIA;
using White.Core.UIItems.Actions;
using White.Core.UIItems.Scrolling;

namespace White.Core.UIItems.TableItems;

public class TableVerticalScrollBar : UIItem, IScrollBar, IVScrollBar
{
	private readonly TableVerticalScrollOffset offset;

	public virtual bool IsScrollable => true;

	public virtual bool IsNotMinimum => !offset.IsOnTop;

	public virtual double Value => 0.0;

	public virtual double MinimumValue => 0.0;

	public virtual double MaximumValue => 100.0;

	protected TableVerticalScrollBar()
	{
	}

	public TableVerticalScrollBar(AutomationElement automationElement, ActionListener actionListener, TableVerticalScrollOffset offset)
		: base(automationElement, actionListener)
	{
		this.offset = offset;
	}

	public virtual void ScrollUp()
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		UIItem.mouse.Click(Bounds.ImmediateInteriorNorth(), actionListener);
	}

	public virtual void ScrollDown()
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		UIItem.mouse.Click(Bounds.ImmediateInteriorSouth(), actionListener);
	}

	public virtual void ScrollUpLarge()
	{
		ScrollUp();
	}

	public virtual void ScrollDownLarge()
	{
		ScrollDown();
	}

	public virtual void SetToMinimum()
	{
		while (IsNotMinimum)
		{
			ScrollUpLarge();
		}
	}

	public virtual void SetToMaximum()
	{
	}
}
