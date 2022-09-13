using System;
using System.Diagnostics;
using System.IO;
using System.Runtime.InteropServices;
using System.Security.Permissions;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using Ionic.Zip;

internal static class Class21
{
	private static Regex regex_0 = new Regex("^(.*/)?([^/\\\\.]+/\\\\.\\\\./)(.+)$");

	private static Encoding encoding_0 = Encoding.GetEncoding("IBM437");

	private static Encoding encoding_1 = Encoding.GetEncoding("UTF-8");

	public static long smethod_0(string string_0)
	{
		if (!File.Exists(string_0))
		{
			throw new FileNotFoundException(string_0);
		}
		long num = 0L;
		using FileStream fileStream = File.Open(string_0, FileMode.Open, FileAccess.Read, FileShare.ReadWrite | FileShare.Delete);
		return fileStream.Length;
	}

	[Conditional("NETCF")]
	public static void smethod_1(Stream stream_0)
	{
		stream_0.Flush();
	}

	private static string smethod_2(string string_0)
	{
		if (string_0.StartsWith("./"))
		{
			string_0 = string_0.Substring(2);
		}
		string_0 = string_0.Replace("/./", "/");
		string_0 = regex_0.Replace(string_0, "$1$3");
		return string_0;
	}

	public static string smethod_3(string string_0)
	{
		if (string.IsNullOrEmpty(string_0))
		{
			return string_0;
		}
		if (string_0.Length >= 2 && string_0[1] == ':' && string_0[2] == '\\')
		{
			string_0 = string_0.Substring(3);
		}
		string_0 = string_0.Replace('\\', '/');
		while (string_0.StartsWith("/"))
		{
			string_0 = string_0.Substring(1);
		}
		return smethod_2(string_0);
	}

	internal static byte[] smethod_4(string string_0, Encoding encoding_2)
	{
		return encoding_2.GetBytes(string_0);
	}

	internal static byte[] smethod_5(string string_0)
	{
		return smethod_4(string_0, encoding_0);
	}

	internal static string smethod_6(byte[] byte_0)
	{
		return smethod_7(byte_0, encoding_1);
	}

	internal static string smethod_7(byte[] byte_0, Encoding encoding_2)
	{
		return encoding_2.GetString(byte_0, 0, byte_0.Length);
	}

	internal static int smethod_8(Stream stream_0)
	{
		int result = 0;
		try
		{
			result = smethod_11(stream_0, "n/a");
			return result;
		}
		catch (BadReadException)
		{
			return result;
		}
	}

	internal static int smethod_9(Stream stream_0)
	{
		int num = 0;
		try
		{
			num = smethod_11(stream_0, "n/a");
			if (num == 134695760)
			{
				stream_0.Seek(12L, SeekOrigin.Current);
				num = smethod_11(stream_0, "n/a");
				if (num != 67324752)
				{
					stream_0.Seek(8L, SeekOrigin.Current);
					num = smethod_11(stream_0, "n/a");
					if (num != 67324752)
					{
						stream_0.Seek(-24L, SeekOrigin.Current);
						num = smethod_11(stream_0, "n/a");
						return num;
					}
					return num;
				}
				return num;
			}
			return num;
		}
		catch (BadReadException)
		{
			return num;
		}
	}

	internal static int smethod_10(Stream stream_0)
	{
		return smethod_11(stream_0, "Could not read block - no data!  (position 0x{0:X8})");
	}

	private static int smethod_11(Stream stream_0, string string_0)
	{
		byte[] array = new byte[4];
		if (stream_0.Read(array, 0, array.Length) != array.Length)
		{
			throw new BadReadException(string.Format(string_0, stream_0.Position));
		}
		return ((array[3] * 256 + array[2]) * 256 + array[1]) * 256 + array[0];
	}

	internal static long smethod_12(Stream stream_0, int int_0)
	{
		long position = stream_0.Position;
		byte[] array = new byte[4]
		{
			(byte)(int_0 >> 24),
			(byte)((int_0 & 0xFF0000) >> 16),
			(byte)((int_0 & 0xFF00) >> 8),
			(byte)((uint)int_0 & 0xFFu)
		};
		byte[] array2 = new byte[65536];
		int num = 0;
		bool flag = false;
		do
		{
			num = stream_0.Read(array2, 0, array2.Length);
			if (num == 0)
			{
				break;
			}
			for (int i = 0; i < num; i++)
			{
				if (array2[i] == array[3])
				{
					long position2 = stream_0.Position;
					stream_0.Seek(i - num, SeekOrigin.Current);
					if (flag = smethod_8(stream_0) == int_0)
					{
						break;
					}
					stream_0.Seek(position2, SeekOrigin.Begin);
				}
			}
		}
		while (!flag);
		if (!flag)
		{
			stream_0.Seek(position, SeekOrigin.Begin);
			return -1L;
		}
		return stream_0.Position - position - 4L;
	}

	internal static DateTime smethod_13(DateTime dateTime_0)
	{
		if (dateTime_0.Kind == DateTimeKind.Utc)
		{
			return dateTime_0;
		}
		DateTime result = dateTime_0;
		if (DateTime.Now.IsDaylightSavingTime() && !dateTime_0.IsDaylightSavingTime())
		{
			result = dateTime_0 - new TimeSpan(1, 0, 0);
		}
		else if (!DateTime.Now.IsDaylightSavingTime() && dateTime_0.IsDaylightSavingTime())
		{
			result = dateTime_0 + new TimeSpan(1, 0, 0);
		}
		return result;
	}

	internal static DateTime smethod_14(int int_0)
	{
		if (int_0 != 65535 && int_0 != 0)
		{
			short num = (short)(int_0 & 0xFFFF);
			short num2 = (short)((int_0 & 0xFFFF0000L) >> 16);
			int i = 1980 + ((num2 & 0xFE00) >> 9);
			int j = (num2 & 0x1E0) >> 5;
			int k = num2 & 0x1F;
			int num3 = (num & 0xF800) >> 11;
			int l = (num & 0x7E0) >> 5;
			int m = (num & 0x1F) * 2;
			if (m >= 60)
			{
				l++;
				m = 0;
			}
			if (l >= 60)
			{
				num3++;
				l = 0;
			}
			if (num3 >= 24)
			{
				k++;
				num3 = 0;
			}
			DateTime value = DateTime.Now;
			bool flag = false;
			try
			{
				value = new DateTime(i, j, k, num3, l, m, 0);
				flag = true;
			}
			catch (ArgumentOutOfRangeException)
			{
				if (i == 1980 && (j == 0 || k == 0))
				{
					try
					{
						value = new DateTime(1980, 1, 1, num3, l, m, 0);
						flag = true;
					}
					catch (ArgumentOutOfRangeException)
					{
						try
						{
							value = new DateTime(1980, 1, 1, 0, 0, 0, 0);
							flag = true;
							goto end_IL_00e3;
						}
						catch (ArgumentOutOfRangeException)
						{
							goto end_IL_00e3;
						}
						end_IL_00e3:;
					}
				}
				else
				{
					try
					{
						for (; i < 1980; i++)
						{
						}
						while (i > 2030)
						{
							i--;
						}
						for (; j < 1; j++)
						{
						}
						while (j > 12)
						{
							j--;
						}
						for (; k < 1; k++)
						{
						}
						while (k > 28)
						{
							k--;
						}
						for (; l < 0; l++)
						{
						}
						while (l > 59)
						{
							l--;
						}
						for (; m < 0; m++)
						{
						}
						while (m > 59)
						{
							m--;
						}
						value = new DateTime(i, j, k, num3, l, m, 0);
						flag = true;
					}
					catch (ArgumentOutOfRangeException)
					{
					}
				}
			}
			if (!flag)
			{
				string arg = $"y({i}) m({j}) d({k}) h({num3}) m({l}) s({m})";
				throw new ZipException($"Bad date/time format in the zip file. ({arg})");
			}
			return DateTime.SpecifyKind(value, DateTimeKind.Local);
		}
		return new DateTime(1995, 1, 1, 0, 0, 0, 0);
	}

	internal static int smethod_15(DateTime dateTime_0)
	{
		dateTime_0 = dateTime_0.ToLocalTime();
		ushort num = (ushort)((dateTime_0.Day & 0x1F) | ((dateTime_0.Month << 5) & 0x1E0) | ((dateTime_0.Year - 1980 << 9) & 0xFE00));
		ushort num2 = (ushort)(((uint)(dateTime_0.Second / 2) & 0x1Fu) | ((uint)(dateTime_0.Minute << 5) & 0x7E0u) | ((uint)(dateTime_0.Hour << 11) & 0xF800u));
		return (num << 16) | num2;
	}

	public static void smethod_16(string string_0, out Stream stream_0, out string string_1)
	{
		for (int i = 0; i < 3; i++)
		{
			try
			{
				string_1 = Path.Combine(string_0, smethod_17());
				stream_0 = new FileStream(string_1, FileMode.CreateNew);
				return;
			}
			catch (IOException)
			{
				if (i == 2)
				{
					throw;
				}
			}
		}
		throw new IOException();
	}

	public static string smethod_17()
	{
		return "DotNetZip-" + Path.GetRandomFileName().Substring(0, 8) + ".tmp";
	}

	internal static int smethod_18(Stream stream_0, byte[] byte_0, int int_0, int int_1, string string_0)
	{
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		int result = 0;
		bool flag = false;
		int num = 0;
		do
		{
			try
			{
				result = stream_0.Read(byte_0, int_0, int_1);
				flag = true;
			}
			catch (IOException ex)
			{
				if (new SecurityPermission(SecurityPermissionFlag.UnmanagedCode).IsUnrestricted())
				{
					if (smethod_19(ex) != 2147942433u)
					{
						throw new IOException($"Cannot read file {string_0}", ex);
					}
					num++;
					if (num > 10)
					{
						throw new IOException($"Cannot read file {string_0}, at offset 0x{int_0:X8} after 10 retries", ex);
					}
					Thread.Sleep(250 + num * 550);
					continue;
				}
				throw;
			}
		}
		while (!flag);
		return result;
	}

	private static uint smethod_19(Exception exception_0)
	{
		return (uint)Marshal.GetHRForException(exception_0);
	}
}
