using System.Windows.Automation;
using White.Core.Factory;
using White.Core.Sessions;
using White.Core.UIItems.Actions;
using White.Core.WindowsAPI;

namespace White.Core.UIItems;

public abstract class Slider : UIItem
{
	private readonly UIItemContainer uiItemContainer;

	public virtual double Value
	{
		get
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Unknown result type (might be due to invalid IL or missing references)
			RangeValuePatternInformation current = RangePattern().get_Current();
			return ((RangeValuePatternInformation)(ref current)).get_Value();
		}
		set
		{
			RangePattern().SetValue(value);
		}
	}

	public virtual Button LargeIncrementButton => uiItemContainer.Get<Button>(IncrementButtonId());

	public virtual Button LargeDecrementButton => uiItemContainer.Get<Button>(DecrementButtonId());

	public virtual double LargeChangeAmount
	{
		get
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Unknown result type (might be due to invalid IL or missing references)
			RangeValuePatternInformation current = RangePattern().get_Current();
			return ((RangeValuePatternInformation)(ref current)).get_LargeChange();
		}
	}

	public virtual double SmallChangeAmount
	{
		get
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Unknown result type (might be due to invalid IL or missing references)
			RangeValuePatternInformation current = RangePattern().get_Current();
			return ((RangeValuePatternInformation)(ref current)).get_SmallChange();
		}
	}

	protected Slider()
	{
	}

	public Slider(AutomationElement automationElement, ActionListener actionListener)
		: base(automationElement, actionListener)
	{
		uiItemContainer = new UIItemContainer(automationElement, actionListener, InitializeOption.NoCache, new NullWindowSession());
	}

	private RangeValuePattern RangePattern()
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Expected O, but got Unknown
		return (RangeValuePattern)Pattern(RangeValuePattern.Pattern);
	}

	protected abstract string IncrementButtonId();

	protected abstract string DecrementButtonId();

	public virtual void SmallIncrement()
	{
		keyboard.PressSpecialKey(KeyboardInput.SpecialKeys.RIGHT, actionListener);
	}

	public virtual void SmallDecrement()
	{
		keyboard.PressSpecialKey(KeyboardInput.SpecialKeys.LEFT, actionListener);
	}
}
