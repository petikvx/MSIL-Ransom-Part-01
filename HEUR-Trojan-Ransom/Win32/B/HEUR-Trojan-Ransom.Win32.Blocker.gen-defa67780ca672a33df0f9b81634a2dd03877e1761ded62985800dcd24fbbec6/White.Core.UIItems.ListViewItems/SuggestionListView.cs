using System;
using System.Windows.Automation;
using White.Core.AutomationElementSearch;
using White.Core.Configuration;
using White.Core.UIItems.Actions;
using White.Core.Utility;

namespace White.Core.UIItems.ListViewItems;

public static class SuggestionListView
{
	private static SuggestionList Find(ActionListener actionListener)
	{
		AutomationElement val = new AutomationElementFinder(AutomationElement.get_RootElement()).Child(AutomationSearchCondition.ByClassName("Auto-Suggest Dropdown"));
		if (val == (AutomationElement)null)
		{
			return null;
		}
		AutomationElement val2 = new AutomationElementFinder(val).Child(AutomationSearchCondition.ByControlType(ControlType.DataGrid));
		if (val2 == (AutomationElement)null)
		{
			return null;
		}
		return new ListView(val2, actionListener);
	}

	public static void WaitTillNotPresent()
	{
		WaitTill(new NullActionListener(), "Took too long to select the item in SuggestionList", (SuggestionList obj) => obj != null);
	}

	private static SuggestionList WaitTill(ActionListener actionListener, string failureMessage, Predicate<SuggestionList> shouldRetry)
	{
		try
		{
			return Retry.For(() => Find(actionListener), shouldRetry, CoreAppXmlConfiguration.Instance.SuggestionListTimeout());
		}
		catch (Exception innerException)
		{
			throw new UIActionException(failureMessage + Constants.BusyMessage, innerException);
		}
	}

	public static SuggestionList WaitAndFind(ActionListener actionListener)
	{
		return WaitTill(actionListener, "Took too long to find suggestion list", (SuggestionList obj) => obj == null);
	}
}
