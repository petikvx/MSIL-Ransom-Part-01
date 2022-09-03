using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Text;

namespace ns0;

internal class Class12
{
	public static byte[] smethod_0(byte[] byte_0, bool bool_0)
	{
		try
		{
			Random random = new Random();
			int num = random.Next(-2000000000, 2000000000);
			for (int i = 0; i < byte_0.Length; i++)
			{
				byte_0[i] = (byte_0[i] += (byte)num);
			}
			List<byte> list = new List<byte>();
			list.AddRange(byte_0);
			byte[] bytes = BitConverter.GetBytes(num);
			list.InsertRange(list.Count / 2, bytes);
			byte[] array = list.ToArray();
			list.Clear();
			list = null;
			return bool_0 ? Encoding.ASCII.GetBytes(Convert.ToBase64String(array)) : array;
		}
		catch
		{
		}
		return null;
	}

	public static byte[] smethod_1(byte[] byte_0, bool bool_0)
	{
		try
		{
			List<byte> list = new List<byte>(bool_0 ? ((IEnumerable<byte>)Convert.FromBase64String(Encoding.ASCII.GetString(byte_0))) : ((IEnumerable<byte>)byte_0));
			int num = BitConverter.ToInt32(list.GetRange((list.Count - 4) / 2, 4).ToArray(), 0);
			list.RemoveRange((list.Count - 4) / 2, 4);
			for (int i = 0; i < list.Count; i++)
			{
				list[i] = (list[i] -= (byte)num);
			}
			byte[] result = list.ToArray();
			list.Clear();
			list = null;
			return result;
		}
		catch
		{
		}
		return null;
	}

	public static string smethod_2(string string_0, bool bool_0)
	{
		try
		{
			Random random = new Random();
			int num = random.Next(-2000000000, 2000000000);
			byte[] bytes = Encoding.GetEncoding(1252).GetBytes(string_0);
			for (int i = 0; i < bytes.Length; i++)
			{
				bytes[i] += (byte)num;
			}
			List<byte> list = new List<byte>();
			list.AddRange(bytes);
			byte[] bytes2 = BitConverter.GetBytes(num);
			list.InsertRange(list.Count / 2, bytes2);
			byte[] array = list.ToArray();
			list.Clear();
			list = null;
			return bool_0 ? Convert.ToBase64String(array) : Encoding.GetEncoding(1252).GetString(array);
		}
		catch
		{
		}
		return string.Empty;
	}

	public static string smethod_3(string string_0, bool bool_0)
	{
		try
		{
			List<byte> list = new List<byte>(bool_0 ? Convert.FromBase64String(string_0) : Encoding.GetEncoding(1252).GetBytes(string_0));
			int num = BitConverter.ToInt32(list.GetRange((list.Count - 4) / 2, 4).ToArray(), 0);
			list.RemoveRange((list.Count - 4) / 2, 4);
			for (int i = 0; i < list.Count; i++)
			{
				list[i] = (list[i] -= (byte)num);
			}
			byte[] bytes = list.ToArray();
			list.Clear();
			list = null;
			return Encoding.GetEncoding(1252).GetString(bytes);
		}
		catch
		{
		}
		return string.Empty;
	}

	public static byte[] smethod_4(byte[] byte_0)
	{
		MemoryStream memoryStream = new MemoryStream();
		using (GZipStream gZipStream = new GZipStream(memoryStream, CompressionMode.Compress, leaveOpen: true))
		{
			gZipStream.Write(byte_0, 0, byte_0.Length);
		}
		memoryStream.Position = 0L;
		byte[] array = new byte[memoryStream.Length];
		memoryStream.Read(array, 0, array.Length);
		byte[] array2 = new byte[array.Length + 4];
		Buffer.BlockCopy(array, 0, array2, 4, array.Length);
		Buffer.BlockCopy(BitConverter.GetBytes(byte_0.Length), 0, array2, 0, 4);
		return array2;
	}

	public static byte[] smethod_5(byte[] byte_0)
	{
		using MemoryStream memoryStream = new MemoryStream();
		int num = BitConverter.ToInt32(byte_0, 0);
		memoryStream.Write(byte_0, 4, byte_0.Length - 4);
		byte[] array = new byte[num];
		memoryStream.Position = 0L;
		using (GZipStream gZipStream = new GZipStream(memoryStream, CompressionMode.Decompress))
		{
			gZipStream.Read(array, 0, array.Length);
		}
		return array;
	}
}
