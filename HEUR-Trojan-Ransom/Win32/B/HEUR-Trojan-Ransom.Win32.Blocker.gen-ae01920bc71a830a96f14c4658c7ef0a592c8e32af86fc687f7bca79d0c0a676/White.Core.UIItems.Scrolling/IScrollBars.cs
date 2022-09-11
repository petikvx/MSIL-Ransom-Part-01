namespace White.Core.UIItems.Scrolling;

public interface IScrollBars
{
	IHScrollBar Horizontal { get; }

	IVScrollBar Vertical { get; }

	bool CanScroll { get; }
}
