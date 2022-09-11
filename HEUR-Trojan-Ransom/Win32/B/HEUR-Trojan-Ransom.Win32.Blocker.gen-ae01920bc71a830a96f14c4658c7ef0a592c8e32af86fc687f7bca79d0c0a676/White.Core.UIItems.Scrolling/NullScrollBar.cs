namespace White.Core.UIItems.Scrolling;

public class NullScrollBar
{
	private double currentValue;

	public virtual double Value => currentValue;

	public virtual double MinimumValue => 0.0;

	public virtual double MaximumValue => 100.0;

	public virtual void SetToMinimum()
	{
		currentValue = MinimumValue;
	}

	public virtual void SetToMaximum()
	{
		currentValue = MaximumValue;
	}
}
