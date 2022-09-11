using System.Windows;
using System.Windows.Automation;

namespace White.Core.UIItems.Scrolling;

public abstract class WPFScrollBar : IScrollBar
{
	protected delegate void ScrollBackLarge();

	protected delegate void ScrollForwardLarge();

	private delegate void Scroll();

	protected readonly ScrollPattern scrollPattern;

	public abstract double Value { get; }

	protected abstract double ScrollPercentage { get; }

	public virtual double MinimumValue => 0.0;

	public virtual double MaximumValue => 100.0;

	public abstract Rect Bounds { get; }

	protected WPFScrollBar(AutomationElement parent)
	{
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Expected O, but got Unknown
		scrollPattern = (ScrollPattern)parent.GetCurrentPattern(ScrollPattern.Pattern);
	}

	public abstract void SetToMinimum();

	public abstract void SetToMaximum();

	protected virtual void SetToMaximum(ScrollForwardLarge scrollForwardLarge)
	{
		MoveTo(100.0, delegate
		{
			scrollForwardLarge();
		});
	}

	private void MoveTo(double value, Scroll scroll)
	{
		double num = Value;
		double beforeScrollPercentage = ScrollPercentage;
		while (!value.Equals(num))
		{
			scroll();
			double value2 = Value;
			double scrollPercentage = ScrollPercentage;
			CheckChangeInScrollPosition(num, value2, beforeScrollPercentage, scrollPercentage);
			num = value2;
			beforeScrollPercentage = scrollPercentage;
		}
	}

	private void CheckChangeInScrollPosition(double beforeScrollValue, double currentValue, double beforeScrollPercentage, double currentScrollPercentage)
	{
		if (beforeScrollValue == currentValue && beforeScrollPercentage == currentScrollPercentage)
		{
			throw new UIActionException("Cannot set the scroll bar to the start position");
		}
	}

	protected virtual void SetToMinimum(ScrollBackLarge scrollBackLarge)
	{
		MoveTo(0.0, delegate
		{
			scrollBackLarge();
		});
	}
}
