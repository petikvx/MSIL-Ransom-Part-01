using System;
using System.IO;
using System.Text;
using Microsoft.VisualBasic;
using ns0;

namespace ns4;

internal class Class10
{
	public struct Struct2
	{
		public long long_0;

		public long long_1;
	}

	public struct Struct3
	{
		public long long_0;

		public string[] string_0;
	}

	public struct Struct4
	{
		public long long_0;

		public string string_0;

		public string string_1;

		public string string_2;

		public long long_1;

		public string string_3;
	}

	public static byte[] byte_0;

	public static ushort ushort_0;

	public static ulong ulong_0;

	public static Struct4[] struct4_0;

	public static byte[] byte_1 = new byte[10] { 0, 1, 2, 3, 4, 6, 8, 8, 0, 0 };

	public static Struct3[] struct3_0;

	public static string[] string_0;

	public Class10(string string_1)
	{
		checked
		{
			if (File.Exists(string_1))
			{
				FileSystem.FileOpen(1, string_1, (OpenMode)32, (OpenAccess)1, (OpenShare)3, -1);
				string s = Strings.Space((int)FileSystem.LOF(1));
				FileSystem.FileGet(1, ref s, -1L, false);
				FileSystem.FileClose(new int[1] { 1 });
				byte_0 = Encoding.Default.GetBytes(s);
				if (Encoding.Default.GetString(byte_0, 0, 15).CompareTo(Class42.smethod_161("k6yy1tOle8zc0a282o2SBg==", "False")) != 0)
				{
					throw new Exception(Class42.smethod_161("ks7ekcRk1cvdzKh/vcKvrdPPkZZko8vlxKbA3daDisjW1gY=", "False"));
				}
				if (byte_0[52] != 0)
				{
					throw new Exception(Class42.smethod_161("bbzGyHiiqLXOwJlntbq7jam+vmuQqMa6rY26t3m0n2fAyL9MusfJu5u5xr6vGg==", "False"));
				}
				if (decimal.Compare(new decimal(Class42.smethod_9(44, 4)), new decimal(4L)) >= 0)
				{
					throw new Exception(Class42.smethod_161("dLBsxrqWsbvFuYulbKaojqa5tGWSosW4t0antb+qU6e7xbKHtSI=", "False"));
				}
				ushort_0 = (ushort)Class42.smethod_9(16, 2);
				ulong_0 = Class42.smethod_9(56, 4);
				if (decimal.Compare(new decimal(ulong_0), 0m) == 0)
				{
					ulong_0 = 1uL;
				}
				Class42.smethod_53(this, 100uL);
			}
		}
	}
}
