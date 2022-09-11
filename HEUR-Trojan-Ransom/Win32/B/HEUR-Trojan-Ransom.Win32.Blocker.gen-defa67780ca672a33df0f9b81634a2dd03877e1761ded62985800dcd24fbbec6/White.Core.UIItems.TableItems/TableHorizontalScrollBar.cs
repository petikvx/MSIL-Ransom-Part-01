using System;
using System.Windows;
using System.Windows.Automation;
using White.Core.UIItems.Actions;
using White.Core.UIItems.Scrolling;

namespace White.Core.UIItems.TableItems;

public class TableHorizontalScrollBar : IScrollBar, IHScrollBar
{
	public virtual bool IsScrollable => false;

	public virtual double Value => 0.0;

	public virtual double MinimumValue => 0.0;

	public virtual double MaximumValue => 100.0;

	public virtual Rect Bounds
	{
		get
		{
			throw new NotSupportedException();
		}
	}

	protected TableHorizontalScrollBar()
	{
	}

	public TableHorizontalScrollBar(AutomationElement automationElement, ActionListener actionListener)
	{
	}

	public virtual void ScrollLeft()
	{
	}

	public virtual void ScrollRight()
	{
	}

	public virtual void ScrollLeftLarge()
	{
	}

	public virtual void ScrollRightLarge()
	{
	}

	public virtual void SetToMinimum()
	{
	}

	public virtual void SetToMaximum()
	{
	}
}
