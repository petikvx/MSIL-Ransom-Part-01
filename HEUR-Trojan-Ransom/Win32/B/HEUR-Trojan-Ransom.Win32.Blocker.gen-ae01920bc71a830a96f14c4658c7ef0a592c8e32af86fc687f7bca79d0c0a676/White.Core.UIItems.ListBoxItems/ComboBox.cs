using System.Threading;
using System.Windows.Automation;
using White.Core.AutomationElementSearch;
using White.Core.Configuration;
using White.Core.Recording;
using White.Core.UIItemEvents;
using White.Core.UIItems.Actions;
using White.Core.UIItems.Scrolling;

namespace White.Core.UIItems.ListBoxItems;

public class ComboBox : ListControl
{
	private AutomationPropertyChangedEventHandler handler;

	private ListItem lastSelectedItem;

	public override VerticalSpan VerticalSpan
	{
		get
		{
			//IL_0023: Unknown result type (might be due to invalid IL or missing references)
			//IL_002e: Unknown result type (might be due to invalid IL or missing references)
			AutomationElement val = finder.Child(AutomationSearchCondition.ByControlType(ControlType.List));
			UIItem uIItem = new UIItem(val, new NullActionListener());
			return new VerticalSpan(uIItem.Bounds).Union(uIItem.Bounds);
		}
	}

	public override IScrollBars ScrollBars => new ComboBoxScrollBars(automationElement, actionListener);

	public virtual string EditableText
	{
		get
		{
			return EditableItem.Text;
		}
		set
		{
			EditableItem.Text = value;
		}
	}

	protected virtual TextBox EditableItem
	{
		get
		{
			AutomationElement val = EditableElement();
			if (!(val != (AutomationElement)null))
			{
				throw new WhiteException("ComboBox is not editable");
			}
			return new TextBox(val, actionListener);
		}
	}

	public virtual bool IsEditable => EditableElement() != (AutomationElement)null;

	protected ComboBox()
	{
	}

	public ComboBox(AutomationElement automationElement, ActionListener actionListener)
		: base(automationElement, actionListener)
	{
		base.actionListener = actionListener;
		MakeActionReady();
	}

	private AutomationElement EditableElement()
	{
		return finder.Child(AutomationSearchCondition.ByControlType(ControlType.Edit));
	}

	public override void Select(string itemText)
	{
		if (!Enabled)
		{
			logger.WarnFormat("Could not select {0}in {1} since it is disabled", (object)itemText, (object)Name);
		}
		else if (!object.Equals(itemText, SelectedItemText))
		{
			ToggleDropDown();
			base.Select(itemText);
		}
	}

	public override void Select(int index)
	{
		if (!Enabled)
		{
			logger.Warn((object)("Could not select " + index + "in " + Name + " since it is disabled"));
		}
		else
		{
			ToggleDropDown();
			base.Select(index);
		}
	}

	protected virtual void MakeActionReady()
	{
		if (CoreAppXmlConfiguration.Instance.ComboBoxItemsPopulatedWithoutDropDownOpen)
		{
			object currentPattern = AutomationElement.GetCurrentPattern(ExpandCollapsePattern.Pattern);
			ExpandCollapsePattern val = (ExpandCollapsePattern)((currentPattern is ExpandCollapsePattern) ? currentPattern : null);
			if (val != null)
			{
				val.Expand();
				Thread.Sleep(100);
				val.Collapse();
			}
		}
	}

	protected virtual void ToggleDropDown()
	{
		Button button = new Button(finder.Child(AutomationSearchCondition.ByControlType(ControlType.Button)), actionListener);
		button.PerformClick();
	}

	public override void HookEvents(UIItemEventListener eventListener)
	{
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Expected O, but got Unknown
		lastSelectedItem = SelectedItem;
		handler = (AutomationPropertyChangedEventHandler)delegate(object sender, AutomationPropertyChangedEventArgs e)
		{
			if (SelectedItem != null && !e.get_NewValue().Equals(1) && !SameListItem())
			{
				lastSelectedItem = SelectedItem;
				eventListener.EventOccured(new ComboBoxEvent(this, SelectedItemText));
			}
		};
		Automation.AddAutomationPropertyChangedEventHandler(automationElement, (TreeScope)1, handler, (AutomationProperty[])(object)new AutomationProperty[1] { ExpandCollapsePattern.ExpandCollapseStateProperty });
	}

	public override void UnHookEvents()
	{
		Automation.RemoveAutomationPropertyChangedEventHandler(automationElement, handler);
	}

	private bool SameListItem()
	{
		if (lastSelectedItem == null && SelectedItem != null)
		{
			return false;
		}
		return object.Equals(SelectedItemText, (lastSelectedItem == null) ? null : lastSelectedItem.Text);
	}
}
