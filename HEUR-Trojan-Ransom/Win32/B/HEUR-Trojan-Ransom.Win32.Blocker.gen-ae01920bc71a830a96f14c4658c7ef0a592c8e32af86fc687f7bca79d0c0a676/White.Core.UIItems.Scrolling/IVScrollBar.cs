namespace White.Core.UIItems.Scrolling;

public interface IVScrollBar : IScrollBar
{
	bool IsScrollable { get; }

	bool IsNotMinimum { get; }

	void ScrollUp();

	void ScrollDown();

	void ScrollUpLarge();

	void ScrollDownLarge();
}
