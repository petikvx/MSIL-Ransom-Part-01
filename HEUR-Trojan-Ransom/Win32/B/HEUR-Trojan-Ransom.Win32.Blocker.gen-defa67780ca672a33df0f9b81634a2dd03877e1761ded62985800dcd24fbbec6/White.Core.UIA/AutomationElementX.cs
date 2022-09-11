using System.Windows;
using System.Windows.Automation;
using White.Core.Mappings;
using log4net;

namespace White.Core.UIA;

public static class AutomationElementX
{
	private static readonly ILog Logger = LogManager.GetLogger(typeof(AutomationElementX));

	public static string Display(this AutomationElement automationElement)
	{
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			if (automationElement == (AutomationElement)null)
			{
				return "(NULL)";
			}
			AutomationElementInformation current = automationElement.get_Current();
			return $"AutomationId:{((AutomationElementInformation)(ref current)).get_AutomationId()}, Name:{((AutomationElementInformation)(ref current)).get_Name()}, ControlType:{((AutomationElementInformation)(ref current)).get_ControlType().get_LocalizedControlType()}, FrameworkId:{((AutomationElementInformation)(ref current)).get_FrameworkId()}";
		}
		catch
		{
			return "Cannot display automation element details. The UIItem might have been disposed";
		}
	}

	public static bool IsPrimaryControl(this AutomationElement automationElement)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		AutomationElementInformation current = automationElement.get_Current();
		return ControlDictionary.Instance.IsPrimaryControl(((AutomationElementInformation)(ref current)).get_ControlType(), ((AutomationElementInformation)(ref current)).get_ClassName(), ((AutomationElementInformation)(ref current)).get_Name());
	}

	public static AutomationElement GetAutomationElementFromPoint(Point location)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			AutomationElement val = AutomationElement.FromPoint(location);
			Logger.DebugFormat("[PositionBasedSearch] Found AutomationElement ({0}) at location ({1})", (object)val.Display(), (object)location);
			return val;
		}
		catch
		{
			return null;
		}
	}
}
