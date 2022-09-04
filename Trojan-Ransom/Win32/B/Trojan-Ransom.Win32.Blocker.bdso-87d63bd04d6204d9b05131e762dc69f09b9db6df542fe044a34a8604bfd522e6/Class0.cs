using System;
using System.IO;
using System.IO.Compression;
using System.Reflection;
using System.Security.Policy;
using System.Text;

internal static class Class0
{
	internal sealed class Class1
	{
		internal static Encoding smethod_0(int int_0, int int_1)
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 75:
					return Class5.smethod_7(252, 233);
				}
			}
		}

		internal static int smethod_1(Stream stream_0, int int_0, int int_1)
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 27:
					return Class5.Class6.smethod_3(stream_0, 620, 633);
				}
			}
		}

		static Class1()
		{
			if (DateTime.Now > new DateTime(635043833219882812L))
			{
				throw new Exception();
			}
			Class15.Class16.smethod_7();
			if (Class15.Class16.smethod_1(Class19.smethod_0(862, 809), new DateTime(635043829566464843L), 266, 294))
			{
				throw new Exception();
			}
			if (Class15.Class16.smethod_1(Class19.smethod_0(344, 303), new DateTime(635043644442001953L), 324, 360))
			{
				throw new Exception();
			}
			Class10.Class11.Class12.smethod_3();
			Class5.Class6.smethod_6();
		}
	}

	internal sealed class Class2
	{
		internal static Assembly smethod_0(int int_0, int int_1)
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 12:
					return Class5.Class8.smethod_3(838, 846);
				}
			}
		}

		internal static int smethod_1(BinaryReader binaryReader_0, int int_0, int int_1)
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 14:
					return Class5.smethod_8(binaryReader_0, 463, 468);
				}
			}
		}

		internal static string smethod_2(object object_0, object object_1, int int_0, int int_1)
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 126:
					return Class5.Class6.smethod_4(object_0, object_1, 734, 696);
				}
			}
		}

		internal static AppDomain smethod_3(int int_0, int int_1)
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 14:
					return Class5.smethod_3(617, 524);
				}
			}
		}

		internal static void smethod_4(AppDomain appDomain_0, string string_0, object object_0, int int_0, int int_1)
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 89:
					Class5.smethod_0(appDomain_0, string_0, object_0, 488, 465);
					return;
				}
			}
		}

		internal static int smethod_5(Stream stream_0, byte[] byte_0, int int_0, int int_1, int int_2, int int_3)
		{
			while (true)
			{
				switch (int_3 ^ int_2)
				{
				case 124:
					return Class5.smethod_9(stream_0, byte_0, int_0, int_1, 941, 918);
				case 125:
					return Class10.Class11.smethod_1(stream_0, byte_0, int_0, int_1, 425, 443);
				}
			}
		}

		static Class2()
		{
			if (DateTime.Now > new DateTime(635043833219912109L))
			{
				throw new Exception();
			}
			Class15.Class16.smethod_7();
			if (Class15.Class16.smethod_1(Class19.smethod_0(206, 185), new DateTime(635043829566494140L), 498, 478))
			{
				throw new Exception();
			}
			if (Class15.Class16.smethod_1(Class19.smethod_0(640, 759), new DateTime(635043824442041015L), 616, 580))
			{
				throw new Exception();
			}
			Class10.Class11.Class12.smethod_3();
			Class5.Class6.smethod_6();
		}
	}

	[STAThread]
	public static int Main(string[] args)
	{
		if (DateTime.Now > new DateTime(635043689219785156L))
		{
			throw new Exception();
		}
		Class15.Class16.smethod_7();
		if (Class15.Class16.smethod_1(Class19.smethod_0(656, 743), new DateTime(635043901566367187L), 537, 565))
		{
			throw new Exception();
		}
		if (Class15.Class16.smethod_1(Class19.smethod_0(844, 827), new DateTime(635043716441650390L), 135, 171))
		{
			throw new Exception();
		}
		Class10.Class11.Class12.smethod_3();
		Class5.Class6.smethod_6();
		Class3.Class4.smethod_3();
		AppDomain appDomain_ = smethod_2(418, 430);
		smethod_3(appDomain_, smethod_0, 877, 892);
		return Class9.smethod_1(appDomain_, new AssemblyName(Class3.Class4.smethod_1(767841096, 4)), null, args, 551, 630);
	}

	public static Assembly smethod_0(object object_0, ResolveEventArgs resolveEventArgs_0)
	{
		return smethod_1(Class10.Class11.smethod_2(Class5.Class8.smethod_4(Class1.smethod_0(446, 501), Class5.Class6.smethod_5(Class3.Class4.smethod_2(resolveEventArgs_0, 889, 772), 19, 89), 591, 524), 328, 304));
	}

	public static Assembly smethod_1(string string_0)
	{
		using Stream stream = Class3.smethod_0(Class2.smethod_0(391, 395), string_0, 50, 38);
		if (stream != null)
		{
			int int_ = Class2.smethod_1(new BinaryReader(stream), 61, 51);
			using DeflateStream input = new DeflateStream(stream, CompressionMode.Decompress);
			return smethod_4(Class3.smethod_1(new BinaryReader(input), int_, 418, 396), 974, 966);
		}
		return null;
	}

	static Class0()
	{
		if (DateTime.Now > new DateTime(635043833219853515L))
		{
			throw new Exception();
		}
		Class15.Class16.smethod_7();
		if (Class15.Class16.smethod_1(Class19.smethod_0(822, 833), new DateTime(635043829566435546L), 312, 276))
		{
			throw new Exception();
		}
		if (Class15.Class16.smethod_1(Class19.smethod_0(0, 119), new DateTime(635043644441972656L), 820, 792))
		{
			throw new Exception();
		}
		Class10.Class11.Class12.smethod_3();
		Class5.Class6.smethod_6();
		Class3.Class4.smethod_3();
	}

	internal static AppDomain smethod_2(int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 12:
				return Class5.smethod_3(951, 978);
			}
		}
	}

	internal static void smethod_3(AppDomain appDomain_0, ResolveEventHandler resolveEventHandler_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 17:
				Class5.Class6.smethod_2(appDomain_0, resolveEventHandler_0, 476, 473);
				return;
			}
		}
	}

	internal static Assembly smethod_4(byte[] byte_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 8:
				return Class5.smethod_10(byte_0, 520, 528);
			}
		}
	}

	internal static object smethod_5(AppDomain appDomain_0, string string_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 73:
				return Class5.smethod_1(appDomain_0, string_0, 688, 674);
			}
		}
	}

	internal static Assembly smethod_6(int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 10:
				return Class5.Class8.smethod_3(706, 714);
			}
		}
	}

	internal static Stream smethod_7(Assembly assembly_0, string string_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 121:
				return Class5.smethod_5(assembly_0, string_0, 517, 611);
			}
		}
	}

	internal static long smethod_8(Stream stream_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 29:
				return Class5.Class7.smethod_1(stream_0, 250, 142);
			}
		}
	}

	internal static Evidence smethod_9(Assembly assembly_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 74:
				return Class9.smethod_2(assembly_0, 730, 747);
			}
		}
	}
}
