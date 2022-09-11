using System.Windows;
using System.Windows.Automation;
using White.Core.UIA;
using White.Core.UIItems.Actions;
using White.Core.UIItems.Scrolling;

namespace White.Core.UIItems.ListBoxItems;

[PlatformSpecificItem]
public class WPFComboBox : ComboBox
{
	public override IScrollBars ScrollBars
	{
		get
		{
			if (scrollBars == null)
			{
				scrollBars = new WPFScrollBars(automationElement, actionListener);
			}
			return scrollBars;
		}
	}

	public override VerticalSpan VerticalSpan
	{
		get
		{
			//IL_000b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0011: Expected O, but got Unknown
			//IL_0012: Unknown result type (might be due to invalid IL or missing references)
			//IL_0023: Unknown result type (might be due to invalid IL or missing references)
			//IL_0040: Unknown result type (might be due to invalid IL or missing references)
			//IL_0046: Unknown result type (might be due to invalid IL or missing references)
			//IL_004b: Unknown result type (might be due to invalid IL or missing references)
			ScrollPattern val = (ScrollPattern)Pattern(ScrollPattern.Pattern);
			Rect bounds = Bounds;
			Rect bounds2 = Items[0].Bounds;
			Rect bounds3 = Items[Items.Count - 1].Bounds;
			ScrollPatternInformation current = val.get_Current();
			WPFComboBoxVerticalSpanCalculator wPFComboBoxVerticalSpanCalculator = new WPFComboBoxVerticalSpanCalculator(bounds, bounds2, bounds3, ((ScrollPatternInformation)(ref current)).get_VerticalViewSize());
			return wPFComboBoxVerticalSpanCalculator.VerticalSpan;
		}
	}

	protected WPFComboBox()
	{
	}

	public WPFComboBox(AutomationElement automationElement, ActionListener actionListener)
		: base(automationElement, actionListener)
	{
	}

	protected override void ToggleDropDown()
	{
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		Point val;
		if (!IsEditable)
		{
			AutomationElementInformation current = automationElement.get_Current();
			val = ((AutomationElementInformation)(ref current)).get_BoundingRectangle().Center();
		}
		else
		{
			val = EditableItem.Bounds.ImmediateExteriorEast();
		}
		Point point = val;
		UIItem.mouse.Click(point, actionListener);
	}
}
