using System.Windows;

namespace White.Core;

public class VerticalSpan : Span
{
	public VerticalSpan(Rect bounds)
		: base(((Rect)(ref bounds)).get_Top(), ((Rect)(ref bounds)).get_Bottom())
	{
	}

	public VerticalSpan(double start, double end)
		: base(start, end)
	{
	}

	public virtual bool DoesntContain(Rect rect)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		return DoesntContain(rect, ((Rect)(ref rect)).get_Top(), ((Rect)(ref rect)).get_Bottom());
	}

	public virtual bool Contains(Rect rect)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		return !DoesntContain(rect);
	}

	public virtual VerticalSpan Union(Rect rect)
	{
		double num = ((((Rect)(ref rect)).get_Top() < start) ? ((Rect)(ref rect)).get_Top() : start);
		double num2 = ((((Rect)(ref rect)).get_Bottom() > end) ? ((Rect)(ref rect)).get_Bottom() : end);
		return new VerticalSpan(num, num2);
	}

	public virtual VerticalSpan Minus(Rect rect)
	{
		if (((Rect)(ref rect)).get_Top() > start && ((Rect)(ref rect)).get_Top() < end)
		{
			return new VerticalSpan(start, ((Rect)(ref rect)).get_Top());
		}
		return this;
	}
}
