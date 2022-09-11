using System.Windows;
using System.Windows.Automation;
using White.Core.UIItems.Actions;

namespace White.Core.UIItems.Scrolling;

[PlatformSpecificItem(ReferAsType = typeof(IHScrollBar))]
public class WPFHScrollBar : WPFScrollBar, IScrollBar, IHScrollBar
{
	private readonly ActionListener actionListener;

	public override double Value
	{
		get
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Unknown result type (might be due to invalid IL or missing references)
			ScrollPatternInformation current = scrollPattern.get_Current();
			return ((ScrollPatternInformation)(ref current)).get_HorizontalScrollPercent();
		}
	}

	protected override double ScrollPercentage
	{
		get
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Unknown result type (might be due to invalid IL or missing references)
			ScrollPatternInformation current = scrollPattern.get_Current();
			return ((ScrollPatternInformation)(ref current)).get_HorizontalViewSize();
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
			return ((ScrollPatternInformation)(ref current)).get_HorizontallyScrollable();
		}
	}

	public WPFHScrollBar(AutomationElement parent, ActionListener actionListener)
		: base(parent)
	{
		this.actionListener = actionListener;
	}

	protected virtual void Scroll(ScrollAmount amount)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		if (IsScrollable)
		{
			scrollPattern.ScrollHorizontal(amount);
			actionListener.ActionPerformed(Action.WindowMessage);
		}
	}

	public virtual void ScrollLeft()
	{
		Scroll((ScrollAmount)1);
	}

	public virtual void ScrollRight()
	{
		Scroll((ScrollAmount)4);
	}

	public virtual void ScrollLeftLarge()
	{
		Scroll((ScrollAmount)0);
	}

	public virtual void ScrollRightLarge()
	{
		Scroll((ScrollAmount)3);
	}

	public override void SetToMinimum()
	{
		SetToMinimum(ScrollLeftLarge);
	}

	public override void SetToMaximum()
	{
		SetToMaximum(ScrollRightLarge);
	}
}
