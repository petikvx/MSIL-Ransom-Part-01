using System.Collections.Generic;
using System.Windows.Automation;
using White.Core.UIA;
using White.Core.UIItems.Actions;

namespace White.Core.UIItems.PropertyGridItems;

public class PropertyGridCategory : UIItem
{
	private readonly PropertyGridElementFinder gridElementFinder;

	public virtual List<PropertyGridProperty> Properties
	{
		get
		{
			bool flag = false;
			List<PropertyGridProperty> list = new List<PropertyGridProperty>();
			List<AutomationElement> list2 = gridElementFinder.FindRows();
			foreach (AutomationElement item in list2)
			{
				if (((object)item).Equals((object?)automationElement))
				{
					flag = true;
				}
				else if (flag)
				{
					AutomationPatterns automationPatterns = new AutomationPatterns(item);
					if (!automationPatterns.HasPattern(ValuePattern.Pattern))
					{
						return list;
					}
					list.Add(new PropertyGridProperty(item, gridElementFinder, actionListener));
				}
			}
			return list;
		}
	}

	public virtual string Text => Name;

	protected PropertyGridCategory()
	{
	}

	internal PropertyGridCategory(AutomationElement automationElement, ActionListener actionListener, PropertyGridElementFinder gridElementFinder)
		: base(automationElement, actionListener)
	{
		this.gridElementFinder = gridElementFinder;
	}

	public virtual PropertyGridProperty GetProperty(string text)
	{
		return Properties.Find((PropertyGridProperty property) => property.Text.Equals(text));
	}
}
