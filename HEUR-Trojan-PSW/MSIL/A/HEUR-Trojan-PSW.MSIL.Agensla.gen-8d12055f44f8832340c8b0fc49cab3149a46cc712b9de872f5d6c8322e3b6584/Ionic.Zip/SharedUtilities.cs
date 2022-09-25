using System;
using System.IO;
using System.Runtime.InteropServices;
using System.Security.Permissions;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;

namespace Ionic.Zip;

internal static class SharedUtilities
{
	private static Regex doubleDotRegex1 = new Regex("^(.*/)?([^/\\\\.]+/\\\\.\\\\./)(.+)$");

	private static Encoding utf8 = Encoding.GetEncoding("UTF-8");

	public static long GetFileLength(string fileName)
	{
		if (!File.Exists(fileName))
		{
			throw new FileNotFoundException($"Could not find file '{fileName}'.", fileName);
		}
		using FileStream fileStream = File.Open(fileName, FileMode.Open, FileAccess.Read, FileShare.ReadWrite | FileShare.Delete);
		return fileStream.Length;
	}

	private static string SimplifyFwdSlashPath(string path)
	{
		if (path.StartsWith("./"))
		{
			path = path.Substring(2);
		}
		path = path.Replace("/./", "/");
		path = doubleDotRegex1.Replace(path, "$1$3");
		return path;
	}

	public static string NormalizePathForUseInZipFile(string pathName)
	{
		if (string.IsNullOrEmpty(pathName))
		{
			return pathName;
		}
		if (pathName.Length >= 2 && pathName[1] == ':' && pathName[2] == '\\')
		{
			pathName = pathName.Substring(3);
		}
		pathName = pathName.Replace('\\', '/');
		while (pathName.StartsWith("/"))
		{
			pathName = pathName.Substring(1);
		}
		return SimplifyFwdSlashPath(pathName);
	}

	internal static byte[] StringToByteArray(string value, Encoding encoding)
	{
		return encoding.GetBytes(value);
	}

	internal static byte[] StringToByteArray(string value)
	{
		Encoding encoding = null;
		try
		{
			encoding = Encoding.GetEncoding("IBM437");
		}
		catch (Exception)
		{
		}
		if (encoding == null)
		{
			try
			{
				encoding = Encoding.GetEncoding(1252);
			}
			catch (Exception)
			{
			}
		}
		return StringToByteArray(value, encoding);
	}

	internal static string Utf8StringFromBuffer(byte[] buf)
	{
		return StringFromBuffer(buf, utf8);
	}

	internal static string StringFromBuffer(byte[] buf, Encoding encoding)
	{
		return encoding.GetString(buf);
	}

	internal static int ReadSignature(Stream s)
	{
		int result = 0;
		try
		{
			result = _ReadFourBytes(s, "n/a");
			return result;
		}
		catch (BadReadException)
		{
			return result;
		}
	}

	internal static int ReadEntrySignature(Stream s)
	{
		int num = 0;
		try
		{
			num = _ReadFourBytes(s, "n/a");
			if (num == 134695760)
			{
				s.Seek(12L, SeekOrigin.Current);
				num = _ReadFourBytes(s, "n/a");
				if (num != 67324752)
				{
					s.Seek(8L, SeekOrigin.Current);
					num = _ReadFourBytes(s, "n/a");
					if (num != 67324752)
					{
						s.Seek(-24L, SeekOrigin.Current);
						num = _ReadFourBytes(s, "n/a");
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

	internal static int ReadInt(Stream s)
	{
		return _ReadFourBytes(s, "Could not read block - no data!  (position 0x{0:X8})");
	}

	private static int _ReadFourBytes(Stream s, string message)
	{
		byte[] array = new byte[4];
		if (s.Read(array, 0, array.Length) != array.Length)
		{
			throw new BadReadException(string.Format(message, s.Position));
		}
		return ((array[3] * 256 + array[2]) * 256 + array[1]) * 256 + array[0];
	}

	internal static long FindSignature(Stream stream, int SignatureToFind)
	{
		long position = stream.Position;
		byte[] array = new byte[4]
		{
			(byte)(SignatureToFind >> 24),
			(byte)((SignatureToFind & 0xFF0000) >> 16),
			(byte)((SignatureToFind & 0xFF00) >> 8),
			(byte)((uint)SignatureToFind & 0xFFu)
		};
		byte[] array2 = new byte[65536];
		int num = 0;
		bool flag = false;
		do
		{
			num = stream.Read(array2, 0, array2.Length);
			if (num == 0)
			{
				break;
			}
			for (int i = 0; i < num; i++)
			{
				if (array2[i] == array[3])
				{
					long position2 = stream.Position;
					stream.Seek(i - num, SeekOrigin.Current);
					if (flag = ReadSignature(stream) == SignatureToFind)
					{
						break;
					}
					stream.Seek(position2, SeekOrigin.Begin);
				}
			}
		}
		while (!flag);
		if (!flag)
		{
			stream.Seek(position, SeekOrigin.Begin);
			return -1L;
		}
		return stream.Position - position - 4L;
	}

	internal static DateTime AdjustTime_Reverse(DateTime time)
	{
		if (time.Kind == DateTimeKind.Utc)
		{
			return time;
		}
		DateTime result = time;
		if (DateTime.Now.IsDaylightSavingTime() && !time.IsDaylightSavingTime())
		{
			result = time - new TimeSpan(1, 0, 0);
		}
		else if (!DateTime.Now.IsDaylightSavingTime() && time.IsDaylightSavingTime())
		{
			result = time + new TimeSpan(1, 0, 0);
		}
		return result;
	}

	internal static DateTime PackedToDateTime(int packedDateTime)
	{
		if (packedDateTime != 65535 && packedDateTime != 0)
		{
			short num = (short)(packedDateTime & 0xFFFF);
			short num2 = (short)((packedDateTime & 0xFFFF0000L) >> 16);
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

	internal static int DateTimeToPacked(DateTime time)
	{
		time = time.ToLocalTime();
		ushort num = (ushort)((time.Day & 0x1F) | ((time.Month << 5) & 0x1E0) | ((time.Year - 1980 << 9) & 0xFE00));
		ushort num2 = (ushort)(((uint)(time.Second / 2) & 0x1Fu) | ((uint)(time.Minute << 5) & 0x7E0u) | ((uint)(time.Hour << 11) & 0xF800u));
		return (num << 16) | num2;
	}

	public static void CreateAndOpenUniqueTempFile(string dir, out Stream fs, out string filename)
	{
		for (int i = 0; i < 3; i++)
		{
			try
			{
				filename = Path.Combine(dir, InternalGetTempFileName());
				fs = new FileStream(filename, FileMode.CreateNew);
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

	public static string InternalGetTempFileName()
	{
		return "DotNetZip-" + Path.GetRandomFileName().Substring(0, 8) + ".tmp";
	}

	internal static int ReadWithRetry(Stream s, byte[] buffer, int offset, int count, string FileName)
	{
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		int result = 0;
		bool flag = false;
		int num = 0;
		do
		{
			try
			{
				result = s.Read(buffer, offset, count);
				flag = true;
			}
			catch (IOException ex)
			{
				if (new SecurityPermission(SecurityPermissionFlag.UnmanagedCode).IsUnrestricted())
				{
					if (_HRForException(ex) != 2147942433u)
					{
						throw new IOException($"Cannot read file {FileName}", ex);
					}
					num++;
					if (num > 10)
					{
						throw new IOException($"Cannot read file {FileName}, at offset 0x{offset:X8} after 10 retries", ex);
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

	private static uint _HRForException(Exception ex1)
	{
		return (uint)Marshal.GetHRForException(ex1);
	}
}
