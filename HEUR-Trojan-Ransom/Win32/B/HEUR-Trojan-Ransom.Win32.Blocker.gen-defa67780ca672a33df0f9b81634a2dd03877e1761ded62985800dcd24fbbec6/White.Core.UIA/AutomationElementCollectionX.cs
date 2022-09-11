using System;
using System.Windows.Automation;

namespace White.Core.UIA;

public static class AutomationElementCollectionX
{
	public static bool Contains(this AutomationElementCollection collection, Predicate<AutomationElement> predicate)
	{
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Expected O, but got Unknown
		foreach (AutomationElement item in collection)
		{
			AutomationElement obj = item;
			if (predicate(obj))
			{
				return true;
			}
		}
		return false;
	}
}
