using System;
using System.Text;
using System.Windows.Automation;
using White.Core.UIItems;
using log4net;

namespace White.Core;

public static class Debug
{
	private const string Tab = "  ";

	private static readonly ILog Logger = LogManager.GetLogger(typeof(Debug));

	public static void ProcessDetails(string processName)
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Expected O, but got Unknown
		try
		{
			AutomationElement automationElement = AutomationElement.get_RootElement().FindFirst((TreeScope)2, (Condition)new PropertyCondition(AutomationElement.NameProperty, (object)processName));
			Details(automationElement);
		}
		catch (Exception)
		{
			Logger.Warn((object)"Error happened while creating error report");
		}
	}

	public static string Details(AutomationElement automationElement)
	{
		try
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.AppendLine();
			Details(stringBuilder, automationElement, string.Empty);
			return stringBuilder.ToString();
		}
		catch (Exception)
		{
			Logger.Warn((object)"Error happened while creating error report");
			return string.Empty;
		}
	}

	private static void Details(StringBuilder stringBuilder, AutomationElement automationElement, string displayPadding)
	{
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Expected O, but got Unknown
		WriteDetail(automationElement, stringBuilder, displayPadding);
		DisplayPattern(automationElement, stringBuilder, displayPadding);
		AutomationElementCollection val = automationElement.FindAll((TreeScope)2, Condition.TrueCondition);
		foreach (AutomationElement item in val)
		{
			AutomationElement automationElement2 = item;
			Details(stringBuilder, automationElement2, displayPadding + "    ");
		}
	}

	private static void WriteDetail(AutomationElement automationElement, StringBuilder stringBuilder, string displayPadding)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0088: Unknown result type (might be due to invalid IL or missing references)
		//IL_008d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0091: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0112: Unknown result type (might be due to invalid IL or missing references)
		//IL_0117: Unknown result type (might be due to invalid IL or missing references)
		AutomationElementInformation current = automationElement.get_Current();
		WriteDetail(stringBuilder, "AutomationId: " + ((AutomationElementInformation)(ref current)).get_AutomationId(), displayPadding);
		AutomationElementInformation current2 = automationElement.get_Current();
		WriteDetail(stringBuilder, "ControlType: " + ((AutomationIdentifier)((AutomationElementInformation)(ref current2)).get_ControlType()).get_ProgrammaticName(), displayPadding);
		AutomationElementInformation current3 = automationElement.get_Current();
		WriteDetail(stringBuilder, "Name: " + ((AutomationElementInformation)(ref current3)).get_Name(), displayPadding);
		AutomationElementInformation current4 = automationElement.get_Current();
		WriteDetail(stringBuilder, "HelpText: " + ((AutomationElementInformation)(ref current4)).get_HelpText(), displayPadding);
		AutomationElementInformation current5 = automationElement.get_Current();
		WriteDetail(stringBuilder, "Bounding rectangle: " + ((AutomationElementInformation)(ref current5)).get_BoundingRectangle(), displayPadding);
		AutomationElementInformation current6 = automationElement.get_Current();
		WriteDetail(stringBuilder, "ClassName: " + ((AutomationElementInformation)(ref current6)).get_ClassName(), displayPadding);
		AutomationElementInformation current7 = automationElement.get_Current();
		WriteDetail(stringBuilder, "IsOffScreen: " + ((AutomationElementInformation)(ref current7)).get_IsOffscreen(), displayPadding);
		AutomationElementInformation current8 = automationElement.get_Current();
		WriteDetail(stringBuilder, "FrameworkId: " + ((AutomationElementInformation)(ref current8)).get_FrameworkId(), displayPadding);
		AutomationElementInformation current9 = automationElement.get_Current();
		WriteDetail(stringBuilder, "ProcessId: " + ((AutomationElementInformation)(ref current9)).get_ProcessId(), displayPadding);
		stringBuilder.AppendLine();
	}

	private static void WriteDetail(StringBuilder stringBuilder, string message, string padding)
	{
		stringBuilder.AppendLine(padding + message);
	}

	public static string GetAllWindows()
	{
		try
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.AppendLine();
			GetAllWindows(stringBuilder, 0, AutomationElement.get_RootElement());
			return stringBuilder.ToString();
		}
		catch (Exception)
		{
			Logger.Warn((object)"Error happened while creating error report");
		}
		return string.Empty;
	}

	private static void GetAllWindows(StringBuilder stringBuilder, int level, AutomationElement baseElement)
	{
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Expected O, but got Unknown
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Expected O, but got Unknown
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0056: Expected O, but got Unknown
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		//IL_0093: Unknown result type (might be due to invalid IL or missing references)
		//IL_0098: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_00af: Unknown result type (might be due to invalid IL or missing references)
		//IL_00be: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c3: Unknown result type (might be due to invalid IL or missing references)
		string text = ((level == 0) ? string.Empty : "  ");
		PropertyCondition val = new PropertyCondition(AutomationElement.ControlTypeProperty, (object)ControlType.Window);
		AutomationElementCollection val2 = baseElement.FindAll((TreeScope)2, (Condition)(object)val);
		foreach (AutomationElement item in val2)
		{
			AutomationElement val3 = item;
			WindowPattern val4 = (WindowPattern)UIItem.Pattern(val3, WindowPattern.Pattern);
			object obj;
			if (val4 != null)
			{
				WindowPatternInformation current = val4.get_Current();
				obj = ((WindowPatternInformation)(ref current)).get_IsModal().ToString();
			}
			else
			{
				obj = "(null)";
			}
			string text2 = (string)obj;
			object[] array = new object[5] { text, null, null, null, null };
			AutomationElementInformation current2 = val3.get_Current();
			array[1] = ((AutomationElementInformation)(ref current2)).get_Name();
			AutomationElementInformation current3 = val3.get_Current();
			array[2] = ((AutomationElementInformation)(ref current3)).get_BoundingRectangle();
			AutomationElementInformation current4 = val3.get_Current();
			array[3] = ((AutomationElementInformation)(ref current4)).get_ProcessId();
			array[4] = text2;
			stringBuilder.AppendFormat("{0}Name: {1},  Bounds: {2} ProcessId: {3}, Modal: {4}", array);
			stringBuilder.AppendLine();
			if (level == 0)
			{
				GetAllWindows(stringBuilder, 1, val3);
			}
		}
	}

	private static void DisplayPattern(AutomationElement automationElement, StringBuilder stringBuilder, string displayPadding)
	{
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Expected O, but got Unknown
		AutomationPattern[] supportedPatterns = automationElement.GetSupportedPatterns();
		AutomationPattern[] array = supportedPatterns;
		foreach (AutomationPattern val in array)
		{
			BasePattern val2 = (BasePattern)automationElement.GetCurrentPattern(val);
			stringBuilder.Append(displayPadding).AppendLine(((object)val2).ToString());
		}
		stringBuilder.AppendLine();
	}

	public static void LogProperties(UIItem uiItem)
	{
		LogProperties(uiItem.AutomationElement);
	}

	public static void LogProperties(AutomationElement element)
	{
		AutomationProperty[] supportedProperties = element.GetSupportedProperties();
		AutomationProperty[] array = supportedProperties;
		foreach (AutomationProperty val in array)
		{
			Logger.Info((object)(((AutomationIdentifier)val).get_ProgrammaticName() + ":" + element.GetCurrentPropertyValue(val)));
		}
	}

	public static void LogPatterns(UIItem uiItem)
	{
		LogPatterns(uiItem.AutomationElement);
	}

	public static void LogPatterns(AutomationElement automationElement)
	{
		StringBuilder stringBuilder = new StringBuilder();
		DisplayPattern(automationElement, stringBuilder, string.Empty);
		Logger.Info((object)stringBuilder.ToString());
	}
}
