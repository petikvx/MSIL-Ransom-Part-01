using System;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Security;
using System.Text;
using System.Windows.Forms;
using DVDVideoSoft.AppFxApi;
using DVDVideoSoft.Resources;
using DVDVideoSoft.Utils;
using IWshRuntimeLibrary;

internal class Class1
{
	private static string string_0;

	internal static void smethod_0(object object_0)
	{
		//IL_015f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0164: Unknown result type (might be due to invalid IL or missing references)
		//IL_0166: Unknown result type (might be due to invalid IL or missing references)
		//IL_0169: Invalid comparison between Unknown and I4
		string text = Regedit.ReadString(localMachine: false, Programs.DVS_REG_ROOT + "Manager", Defs.PN.CurrentCulture.ToString(), LocaleUtils.DefaultLocaleName);
		LocaleUtils.SetThreadCulture(text);
		if (SysUtils.CheckForNetFx35())
		{
			string path = Regedit.ReadString(localMachine: true, Programs.APP_PATHS_REG_KEY, Programs.ID.FreeUploaderForFacebook.ToString(), "");
			try
			{
				path = Path.Combine(Path.GetDirectoryName(path), string_0);
				Regedit.WriteValue(localMachine: true, Programs.APP_PATHS_REG_KEY, Programs.ID.FreeUploaderForFacebook.ToString(), path);
				StringBuilder stringBuilder = new StringBuilder(260);
				WinApi.SHGetSpecialFolderPath(IntPtr.Zero, stringBuilder, 23, fCreate: false);
				smethod_1("Free Uploader for Facebook.lnk", path, Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory));
				smethod_1("Free Uploader for Facebook.lnk", path, Path.Combine(stringBuilder.ToString(), "DVDVideoSoft\\Programs\\"));
				ProcessStartInfo startInfo = new ProcessStartInfo(path);
				Process.Start(startInfo);
				return;
			}
			catch (SecurityException ex)
			{
				try
				{
					ProcessStartInfo processStartInfo = new ProcessStartInfo();
					processStartInfo.UseShellExecute = true;
					processStartInfo.WorkingDirectory = Environment.CurrentDirectory;
					Uri uri = new Uri(Assembly.GetExecutingAssembly().GetName().CodeBase);
					processStartInfo.FileName = uri.LocalPath;
					processStartInfo.Verb = "runas";
					Process process = Process.Start(processStartInfo);
					process.WaitForExit();
					return;
				}
				catch (Win32Exception)
				{
					_ = ex.Message;
					return;
				}
			}
			catch (Exception ex3)
			{
				_ = ex3.Message;
				return;
			}
		}
		DialogResult val = MessageBox.Show(CommonData.get_NetFx35Install(), CommonData.get_Information(), (MessageBoxButtons)4);
		if ((int)val == 6)
		{
			string arg = "http://www.microsoft.com/download";
			string text2 = smethod_2(text);
			string fileName = ((!text2.Equals("en")) ? string.Format("{0}s/{1}/{2}", arg, text2, "confirmation.aspx?familyid=ab99342f-5d1a-413d-8319-81da479ab0d7") : string.Format("{0}/{1}/{2}", arg, text2, "confirmation.aspx?id=22"));
			ProcessStartInfo startInfo2 = new ProcessStartInfo(fileName);
			Process.Start(startInfo2);
		}
	}

	private static void smethod_1(string string_1, string string_2, string string_3)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		WshShellClass val = new WshShellClass();
		object obj = val.CreateShortcut(Path.Combine(string_3, string_1));
		IWshShortcut val2 = (IWshShortcut)((obj is IWshShortcut) ? obj : null);
		val2.set_TargetPath(string_2);
		val2.set_WindowStyle(1);
		val2.set_Description(string_1);
		val2.set_IconLocation(string_2);
		val2.Save();
	}

	private static string smethod_2(string string_1)
	{
		switch (string_1)
		{
		case "it-IT":
			return "it-it";
		case "fr-FR":
			return "fr-fr";
		case "de-DE":
			return "de-de";
		case "ja-JP":
			return "ja-jp";
		case "es-ES":
			return "es-es";
		case "ru-RU":
			return "ru-ru";
		case "pt-PT":
			return "pt-pt";
		case "zh-Hant":
		case "zh-CHS":
			return "zh-tw";
		case "nl-NL":
			return "nl-nl";
		case "pl-PL":
			return "pl-PL";
		default:
			return "en";
		}
	}

	public Class1()
	{
		Class3.AGYkg95zoPvWD();
		base._002Ector();
	}

	static Class1()
	{
		Class3.AGYkg95zoPvWD();
		string_0 = "FreeUploaderForFacebook.exe";
	}
}
