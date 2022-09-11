using System.Collections.Generic;
using System.Linq;
using System.Windows.Automation;
using White.Core.UIItems.Actions;
using White.Core.UIItems.Finders;

namespace White.Core.UIItems.WindowStripControls;

public class WPFStatusBar : UIItem
{
	public virtual UIItemCollection Items
	{
		get
		{
			IEnumerable<IUIItem> entities = factory.CreateAll(SearchCriteria.All, actionListener).Where(delegate(IUIItem i)
			{
				//IL_0006: Unknown result type (might be due to invalid IL or missing references)
				//IL_000b: Unknown result type (might be due to invalid IL or missing references)
				AutomationElementInformation current = i.AutomationElement.get_Current();
				return ((AutomationElementInformation)(ref current)).get_ClassName() == "StatusBarItem";
			});
			return new UIItemCollection(entities);
		}
	}

	protected WPFStatusBar()
	{
	}

	public WPFStatusBar(AutomationElement automationElement, ActionListener actionListener)
		: base(automationElement, actionListener)
	{
	}
}
