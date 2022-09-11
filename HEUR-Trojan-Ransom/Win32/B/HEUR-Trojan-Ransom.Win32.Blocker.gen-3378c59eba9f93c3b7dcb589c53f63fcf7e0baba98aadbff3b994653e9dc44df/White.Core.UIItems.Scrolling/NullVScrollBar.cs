using System.Windows;

namespace White.Core.UIItems.Scrolling;

public class NullVScrollBar : NullScrollBar, IScrollBar, IVScrollBar
{
	public virtual bool IsScrollable => false;

	public virtual bool IsNotMinimum => false;

	public virtual Rect Bounds => Rect.get_Empty();

	public virtual void ScrollUp()
	{
	}

	public virtual void ScrollDown()
	{
	}

	public virtual void ScrollUpLarge()
	{
	}

	public virtual void ScrollDownLarge()
	{
	}
}
