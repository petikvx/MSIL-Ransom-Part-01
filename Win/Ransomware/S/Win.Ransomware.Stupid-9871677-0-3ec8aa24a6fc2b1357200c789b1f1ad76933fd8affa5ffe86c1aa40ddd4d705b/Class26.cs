using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Text;
using Ionic.Zip;

internal static class Class26
{
	public static bool smethod_0(Stream stream_0, ICollection<GClass8> icollection_0, uint uint_0, Zip64Option zip64Option_0, string string_0, Class27 class27_0)
	{
		Stream3 stream = stream_0 as Stream3;
		if (stream != null)
		{
			stream.Boolean_0 = true;
		}
		long num = 0L;
		using (MemoryStream memoryStream = new MemoryStream())
		{
			foreach (GClass8 item in icollection_0)
			{
				if (item.Boolean_7)
				{
					item.method_41(memoryStream);
				}
			}
			byte[] array = memoryStream.ToArray();
			stream_0.Write(array, 0, array.Length);
			num = array.Length;
		}
		long num2 = ((stream_0 is GStream4 gStream) ? gStream.Int64_2 : stream_0.Position);
		long num3 = num2 - num;
		uint num4 = stream?.UInt32_0 ?? 0;
		long num5 = num2 - num3;
		int num6 = smethod_4(icollection_0);
		bool num7 = zip64Option_0 == Zip64Option.Always || num6 >= 65535 || num5 > 4294967295L || num3 > 4294967295L;
		byte[] array2 = null;
		if (num7)
		{
			if (zip64Option_0 == Zip64Option.Default)
			{
				if (new StackFrame(1).GetMethod()!.DeclaringType == typeof(GClass9))
				{
					throw new ZipException("The archive requires a ZIP64 Central Directory. Consider setting the ZipFile.UseZip64WhenSaving property.");
				}
				throw new ZipException("The archive requires a ZIP64 Central Directory. Consider setting the ZipOutputStream.EnableZip64 property.");
			}
			byte[] array3 = smethod_3(num3, num2, num6, uint_0);
			array2 = smethod_2(num3, num2, zip64Option_0, num6, string_0, class27_0);
			if (num4 != 0)
			{
				uint value = stream.method_1(array3.Length + array2.Length);
				Array.Copy(BitConverter.GetBytes(value), 0, array3, 16, 4);
				Array.Copy(BitConverter.GetBytes(value), 0, array3, 20, 4);
				Array.Copy(BitConverter.GetBytes(value), 0, array3, 60, 4);
				Array.Copy(BitConverter.GetBytes(value), 0, array3, 72, 4);
			}
			stream_0.Write(array3, 0, array3.Length);
		}
		else
		{
			array2 = smethod_2(num3, num2, zip64Option_0, num6, string_0, class27_0);
		}
		if (num4 != 0)
		{
			ushort value2 = (ushort)stream.method_1(array2.Length);
			Array.Copy(BitConverter.GetBytes(value2), 0, array2, 4, 2);
			Array.Copy(BitConverter.GetBytes(value2), 0, array2, 6, 2);
		}
		stream_0.Write(array2, 0, array2.Length);
		if (stream != null)
		{
			stream.Boolean_0 = false;
		}
		return num7;
	}

	private static Encoding smethod_1(Class27 class27_0, string string_0)
	{
		switch (class27_0.ZipOption_0)
		{
		case ZipOption.Always:
			return class27_0.Encoding_0;
		default:
		{
			Encoding encoding_ = class27_0.Encoding_1;
			if (string_0 == null)
			{
				return encoding_;
			}
			byte[] bytes = encoding_.GetBytes(string_0);
			if (encoding_.GetString(bytes, 0, bytes.Length).Equals(string_0))
			{
				return encoding_;
			}
			return class27_0.Encoding_0;
		}
		case ZipOption.Default:
			return class27_0.Encoding_1;
		}
	}

	private static byte[] smethod_2(long long_0, long long_1, Zip64Option zip64Option_0, int int_0, string string_0, Class27 class27_0)
	{
		Encoding encoding = smethod_1(class27_0, string_0);
		int num = 0;
		byte[] array = null;
		short num2 = 0;
		if (string_0 != null && string_0.Length != 0)
		{
			array = encoding.GetBytes(string_0);
			num2 = (short)array.Length;
		}
		byte[] array2 = new byte[22 + num2];
		int num3 = 0;
		Array.Copy(BitConverter.GetBytes(101010256u), 0, array2, 0, 4);
		num3 = 4;
		num3 = 5;
		array2[4] = 0;
		num3 = 6;
		array2[5] = 0;
		num3 = 7;
		array2[6] = 0;
		num3 = 8;
		array2[7] = 0;
		if (int_0 < 65535 && zip64Option_0 != Zip64Option.Always)
		{
			array2[num3++] = (byte)((uint)int_0 & 0xFFu);
			array2[num3++] = (byte)((int_0 & 0xFF00) >> 8);
			array2[num3++] = (byte)((uint)int_0 & 0xFFu);
			array2[num3++] = (byte)((int_0 & 0xFF00) >> 8);
		}
		else
		{
			for (num = 0; num < 4; num++)
			{
				array2[num3++] = byte.MaxValue;
			}
		}
		long num4 = long_1 - long_0;
		if (num4 < 4294967295L && long_0 < 4294967295L)
		{
			array2[num3++] = (byte)((ulong)num4 & 0xFFuL);
			array2[num3++] = (byte)((num4 & 0xFF00L) >> 8);
			array2[num3++] = (byte)((num4 & 0xFF0000L) >> 16);
			array2[num3++] = (byte)((num4 & 0xFF000000L) >> 24);
			array2[num3++] = (byte)((ulong)long_0 & 0xFFuL);
			array2[num3++] = (byte)((long_0 & 0xFF00L) >> 8);
			array2[num3++] = (byte)((long_0 & 0xFF0000L) >> 16);
			array2[num3++] = (byte)((long_0 & 0xFF000000L) >> 24);
		}
		else
		{
			for (num = 0; num < 8; num++)
			{
				array2[num3++] = byte.MaxValue;
			}
		}
		if (string_0 != null && string_0.Length != 0)
		{
			if (num2 + num3 + 2 > array2.Length)
			{
				num2 = (short)(array2.Length - num3 - 2);
			}
			array2[num3++] = (byte)((uint)num2 & 0xFFu);
			array2[num3++] = (byte)((num2 & 0xFF00) >> 8);
			if (num2 != 0)
			{
				for (num = 0; num < num2 && num3 + num < array2.Length; num++)
				{
					array2[num3 + num] = array[num];
				}
				num3 += num;
			}
		}
		else
		{
			array2[num3++] = 0;
			array2[num3++] = 0;
		}
		return array2;
	}

	private static byte[] smethod_3(long long_0, long long_1, int int_0, uint uint_0)
	{
		byte[] array = new byte[76];
		int num = 0;
		Array.Copy(BitConverter.GetBytes(101075792u), 0, array, 0, 4);
		num = 4;
		Array.Copy(BitConverter.GetBytes(44L), 0, array, 4, 8);
		num = 12;
		num = 13;
		array[12] = 45;
		num = 14;
		array[13] = 0;
		num = 15;
		array[14] = 45;
		num = 16;
		array[15] = 0;
		for (int i = 0; i < 8; i++)
		{
			array[num++] = 0;
		}
		long value = int_0;
		Array.Copy(BitConverter.GetBytes(value), 0, array, num, 8);
		num += 8;
		Array.Copy(BitConverter.GetBytes(value), 0, array, num, 8);
		num += 8;
		Array.Copy(BitConverter.GetBytes(long_1 - long_0), 0, array, num, 8);
		num += 8;
		Array.Copy(BitConverter.GetBytes(long_0), 0, array, num, 8);
		num += 8;
		Array.Copy(BitConverter.GetBytes(117853008u), 0, array, num, 4);
		num += 4;
		Array.Copy(BitConverter.GetBytes((uint_0 != 0) ? (uint_0 - 1) : 0u), 0, array, num, 4);
		num += 4;
		Array.Copy(BitConverter.GetBytes(long_1), 0, array, num, 8);
		num += 8;
		Array.Copy(BitConverter.GetBytes(uint_0), 0, array, num, 4);
		num += 4;
		return array;
	}

	private static int smethod_4(ICollection<GClass8> icollection_0)
	{
		int num = 0;
		foreach (GClass8 item in icollection_0)
		{
			if (item.Boolean_7)
			{
				num++;
			}
		}
		return num;
	}
}
