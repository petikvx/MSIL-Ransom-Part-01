using System.Windows;
using White.Core.SystemExtensions;

namespace White.Core;

public class Span
{
	protected double start;

	protected double end;

	public virtual double Start => start;

	public virtual double End => end;

	protected Span(double start, double end)
	{
		this.start = start;
		this.end = end;
	}

	public override string ToString()
	{
		return $"Start: {start}, End: {end}";
	}

	protected virtual bool DoesntContain(Rect rect, double otherStart, double otherEnd)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		if (((Rect)(ref rect)).Equals(Rect.get_Empty()))
		{
			return true;
		}
		double num = (otherStart + otherEnd) / 2.0;
		if (num.IsInvalid())
		{
			return true;
		}
		if (!(num < start))
		{
			return num > end;
		}
		return true;
	}
}
