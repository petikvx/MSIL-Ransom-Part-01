using System.Windows.Automation;
using White.Core.UIItems.Actions;
using White.Core.UIItems.Finders;

namespace White.Core.UIItems.MenuItems;

public class Menu : UIItem
{
	private Menus childMenus;

	public virtual Menus ChildMenus
	{
		get
		{
			if (childMenus != null)
			{
				return childMenus;
			}
			childMenus = new Menus(automationElement, actionListener);
			return childMenus;
		}
	}

	protected Menu()
	{
	}

	public Menu(AutomationElement automationElement, ActionListener actionListener)
		: base(automationElement, actionListener)
	{
	}

	public virtual Menu SubMenu(string text)
	{
		return SubMenu(SearchCriteria.ByText(text));
	}

	public virtual Menu SubMenu(SearchCriteria searchCriteria)
	{
		return ChildMenus.Find(searchCriteria);
	}
}
