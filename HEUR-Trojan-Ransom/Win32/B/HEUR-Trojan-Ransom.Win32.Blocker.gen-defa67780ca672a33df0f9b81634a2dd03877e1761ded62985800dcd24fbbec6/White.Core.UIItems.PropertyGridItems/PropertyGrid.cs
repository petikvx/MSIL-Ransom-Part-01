using System.Collections.Generic;
using System.Windows.Automation;
using White.Core.UIA;
using White.Core.UIItems.Actions;

namespace White.Core.UIItems.PropertyGridItems;

public class PropertyGrid : UIItem
{
	private readonly PropertyGridElementFinder finder;

	public virtual List<PropertyGridCategory> Categories
	{
		get
		{
			List<PropertyGridCategory> list = new List<PropertyGridCategory>();
			List<AutomationElement> list2 = finder.FindRows();
			foreach (AutomationElement item in list2)
			{
				AutomationPatterns automationPatterns = new AutomationPatterns(item);
				if (!automationPatterns.HasPattern(ValuePattern.Pattern))
				{
					list.Add(new PropertyGridCategory(item, actionListener, finder));
				}
			}
			return list;
		}
	}

	protected PropertyGrid()
	{
	}

	public PropertyGrid(AutomationElement automationElement, ActionListener actionListener)
		: base(automationElement, actionListener)
	{
		finder = new PropertyGridElementFinder(automationElement);
	}

	public virtual PropertyGridCategory Category(string name)
	{
		return Categories.Find((PropertyGridCategory category) => object.Equals(name, category.Text));
	}
}
