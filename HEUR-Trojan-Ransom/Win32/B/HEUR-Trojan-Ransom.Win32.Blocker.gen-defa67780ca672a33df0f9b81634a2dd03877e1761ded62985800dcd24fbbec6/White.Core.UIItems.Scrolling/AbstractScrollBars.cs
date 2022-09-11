namespace White.Core.UIItems.Scrolling;

public abstract class AbstractScrollBars : IScrollBars
{
	public abstract IHScrollBar Horizontal { get; }

	public abstract IVScrollBar Vertical { get; }

	public virtual bool CanScroll
	{
		get
		{
			if (Horizontal is NullScrollBar)
			{
				return !(Vertical is NullScrollBar);
			}
			return true;
		}
	}
}
