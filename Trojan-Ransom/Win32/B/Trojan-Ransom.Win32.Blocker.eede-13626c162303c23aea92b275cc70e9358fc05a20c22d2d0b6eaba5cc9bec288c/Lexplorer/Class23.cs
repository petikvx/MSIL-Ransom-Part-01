using System;
using System.Diagnostics;
using System.Xml;

namespace Lexplorer;

internal class Class23
{
	private const string NODE_LOOP_BEGIN = "LOOP";

	protected const string NODE_ATTRIBUTE_COUNT = "C";

	private string defaultBrowserPath = string.Empty;

	private string defaultBrowserIdentifier = string.Empty;

	private int defaultDisplayWidth;

	private int defaultDisplayHeight;

	private bool prevSoundState;

	public bool WriteLogToConsole { get; set; }

	public bool AllowDisplayPowerControl { get; set; }

	public Class23()
	{
	}

	public Class23(bool writeLog, bool displayPowerControl)
	{
		WriteLogToConsole = writeLog;
		AllowDisplayPowerControl = displayPowerControl;
	}

	public void CloseProgram(string pathToExecutable)
	{
		string exeName = GetExeName(pathToExecutable);
		Process[] processesByName = Process.GetProcessesByName(exeName);
		Process[] array = processesByName;
		foreach (Process process in array)
		{
			if (!process.HasExited)
			{
				process.CloseMainWindow();
			}
		}
	}

	public bool Execute(XmlNode node2, bool forcedExecution)
	{
		XmlNode xmlNode = null;
		WriteDebugLog("The script has {0} steps.", node2.ChildNodes.Count);
		for (int i = 0; i < node2.ChildNodes.Count; i++)
		{
			WriteDebugLog("Step {0}", i + 1);
			xmlNode = node2.ChildNodes[i];
			try
			{
				Class13 @class = Class13.ReadCommand(xmlNode);
				if (@class.GetType() == typeof(Class19))
				{
					Class19 class2 = (Class19)@class;
					class2.CurrentIndex = i + 1;
					class2.Body = node2.ChildNodes;
					class2.WriteLog = WriteLogToConsole;
					class2.AllowMonitorPower = AllowDisplayPowerControl;
					if (!class2.Execute(forcedExecution))
					{
						return false;
					}
					i = class2.CurrentIndex;
					continue;
				}
				WriteDebugLog("Command: {0} Property bag: {1}", @class.ToString(), @class.PropertyBag.ToString());
				bool flag = true;
				if (!AllowDisplayPowerControl)
				{
					if (@class.GetType() == typeof(Class21))
					{
						if (@class.ExecutionMethodName.ToUpper() != "POWER")
						{
							flag = @class.Execute(forcedExecution);
						}
						else
						{
							WriteDebugLog("Display power management disabled in debug mode.");
						}
					}
					else
					{
						flag = @class.Execute(forcedExecution);
					}
				}
				else
				{
					flag = @class.Execute(forcedExecution);
				}
				WriteDebugLog("Success? {0}", flag ? "Yes." : "NO!");
				if (!flag)
				{
					WriteDebugLog("Execution has been aborted.");
					return false;
				}
			}
			catch (Exception ex)
			{
				WriteDebugLog("ERROR in step {0}. {1} Execution has been aborted.", i + 1, ex.Message);
				return false;
			}
		}
		WriteDebugLog("Execution done.");
		return true;
	}

	private static string GetExeName(string pathToExe)
	{
		int num = pathToExe.LastIndexOf('\\');
		int num2 = pathToExe.LastIndexOf(".exe");
		if (num != -1 && num2 != -1)
		{
			return pathToExe.Substring(num + 1, num2 - num - 1);
		}
		return null;
	}

	private void WriteDebugLog(string text, params object[] pars)
	{
		if (WriteLogToConsole)
		{
			string text2 = DateTime.Now.ToLongTimeString();
			Console.WriteLine("[" + text2 + "] " + text, pars);
		}
	}
}
