using System.Windows;

namespace White.Core;

public class HorizontalSpan : Span
{
	public HorizontalSpan(Rect bounds)
		: base(((Rect)(ref bounds)).get_Left(), ((Rect)(ref bounds)).get_Right())
	{
	}

	public virtual bool IsOutside(Rect rect)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		return DoesntContain(rect, ((Rect)(ref rect)).get_Left(), ((Rect)(ref rect)).get_Right());
	}
}
