namespace White.Core.UIItems.Scrolling;

public interface IHScrollBar : IScrollBar
{
	bool IsScrollable { get; }

	void ScrollLeft();

	void ScrollRight();

	void ScrollLeftLarge();

	void ScrollRightLarge();
}
