using System.Windows;

namespace White.Core.UIItems.Scrolling;

public class NullHScrollBar : NullScrollBar, IScrollBar, IHScrollBar
{
	public virtual bool IsScrollable => false;

	public virtual Rect Bounds => Rect.get_Empty();

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
}
