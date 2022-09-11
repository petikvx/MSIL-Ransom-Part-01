using System.Windows;
using System.Windows.Automation;
using White.Core.UIItems.Actions;

namespace White.Core.UIItems.Scrolling;

[PlatformSpecificItem(ReferAsType = typeof(IVScrollBar))]
public class WPFVScrollBar : WPFScrollBar, IScrollBar, IVScrollBar
{
	private readonly ActionListener actionListener;

	protected override double ScrollPercentage
	{
		get
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Unknown result type (might be due to invalid IL or missing references)
			ScrollPatternInformation current = scrollPattern.get_Current();
			return ((ScrollPatternInformation)(ref current)).get_VerticalViewSize();
		}
	}

	public override double Value
	{
		get
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Unknown result type (might be due to invalid IL or missing references)
			ScrollPatternInformation current = scrollPattern.get_Current();
			return ((ScrollPatternInformation)(ref current)).get_VerticalScrollPercent();
		}
	}

	public override Rect Bounds => Rect.get_Empty();

	public virtual bool IsScrollable
	{
		get
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Unknown result type (might be due to invalid IL or missing references)
			ScrollPatternInformation current = scrollPattern.get_Current();
			return ((ScrollPatternInformation)(ref current)).get_VerticallyScrollable();
		}
	}

	public virtual bool IsNotMinimum => Value > 0.0;

	public WPFVScrollBar(AutomationElement parent, ActionListener actionListener)
		: base(parent)
	{
		this.actionListener = actionListener;
	}

	public virtual void ScrollUp()
	{
		Scroll((ScrollAmount)1);
	}

	public virtual void ScrollDown()
	{
		Scroll((ScrollAmount)4);
	}

	public virtual void ScrollUpLarge()
	{
		Scroll((ScrollAmount)0);
	}

	public virtual void ScrollDownLarge()
	{
		Scroll((ScrollAmount)3);
	}

	public override void SetToMinimum()
	{
		SetToMinimum(ScrollUpLarge);
	}

	public override void SetToMaximum()
	{
		SetToMaximum(ScrollDownLarge);
	}

	protected virtual void Scroll(ScrollAmount amount)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		if (IsScrollable)
		{
			scrollPattern.ScrollVertical(amount);
			actionListener.ActionPerformed(Action.Scroll);
		}
	}
}
