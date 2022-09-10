using System;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Resources;
using System.Security.Policy;
using System.Threading;

namespace ns0;

internal sealed class Class13
{
	internal sealed class Class14
	{
		internal static string smethod_0(object object_0, object object_1, int int_0, int int_1)
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 0:
					return Class18.smethod_0(object_0, object_1, 591, 580);
				case 1:
					return Class18.smethod_0(object_0, object_1, 177, 186);
				}
			}
		}

		internal static int smethod_1(Stream stream_0, byte[] byte_0, int int_0, int int_1, int int_2, int int_3)
		{
			while (true)
			{
				switch (int_3 ^ int_2)
				{
				case 81:
					return stream_0.Read(byte_0, int_0, int_1);
				case 82:
					return stream_0.Read(byte_0, int_0, int_1);
				case 83:
					return stream_0.Read(byte_0, int_0, int_1);
				}
			}
		}

		internal static bool smethod_2(string string_0, string string_1, int int_0, int int_1)
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 96:
					return Class18.Class19.smethod_1(string_0, string_1, 843, 863);
				}
			}
		}

		internal static void smethod_3(Array array_0, RuntimeFieldHandle runtimeFieldHandle_0, int int_0, int int_1)
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 110:
					Class15.Class16.smethod_3(array_0, runtimeFieldHandle_0, 772, 776);
					return;
				}
			}
		}

		internal static string smethod_4(int int_0, int int_1)
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 98:
					return Class18.smethod_2(620, 519);
				}
			}
		}

		internal static void smethod_5(string string_0, byte[] byte_0, int int_0, int int_1)
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 74:
					Class15.Class17.smethod_4(string_0, byte_0, 136, 182);
					return;
				}
			}
		}

		internal static Assembly smethod_6(byte[] byte_0, int int_0, int int_1)
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 121:
					return Class18.smethod_3(byte_0, 336, 359);
				}
			}
		}

		internal static void smethod_7(AppDomain appDomain_0, ResolveEventHandler resolveEventHandler_0, int int_0, int int_1)
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 76:
					Class15.Class17.smethod_5(appDomain_0, resolveEventHandler_0, 471, 490);
					return;
				}
			}
		}

		internal static string smethod_8(string string_0, string string_1, int int_0, int int_1)
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 4:
					return Class15.Class17.smethod_6(string_0, string_1, 95, 7);
				}
			}
		}

		internal static void smethod_9(ResourceManager resourceManager_0, int int_0, int int_1)
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 52:
					Class18.smethod_4(resourceManager_0, 697, 764);
					return;
				}
			}
		}

		static Class14()
		{
			Class15.smethod_6();
		}
	}

	static Class13()
	{
		Class15.smethod_6();
		Class10.smethod_7();
	}

	internal static AppDomain smethod_0(int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 123:
				return Class15.Class16.smethod_0(765, 702);
			case 124:
				return Class15.Class16.smethod_0(504, 443);
			}
		}
	}

	internal static object smethod_1(AppDomain appDomain_0, string string_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 97:
				return Class18.Class19.smethod_0(appDomain_0, string_0, 551, 557);
			case 98:
				return Class18.Class19.smethod_0(appDomain_0, string_0, 222, 212);
			}
		}
	}

	internal static int smethod_2(Stream stream_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 26:
				return Class15.smethod_1(stream_0, 170, 223);
			case 27:
				return Class15.smethod_1(stream_0, 80, 37);
			}
		}
	}

	internal static void smethod_3(Stream stream_0, byte[] byte_0, int int_0, int int_1, int int_2, int int_3)
	{
		while (true)
		{
			switch (int_3 ^ int_2)
			{
			case 101:
				stream_0.Write(byte_0, int_0, int_1);
				return;
			case 102:
				stream_0.Write(byte_0, int_0, int_1);
				return;
			}
		}
	}

	internal static Evidence smethod_4(Assembly assembly_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 97:
				return Class15.smethod_3(assembly_0, 168, 214);
			case 98:
				return Class15.smethod_3(assembly_0, 144, 238);
			}
		}
	}

	internal static Process smethod_5(string string_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 39:
				return Class18.smethod_5(string_0, 219, 220);
			}
		}
	}

	internal static object smethod_6(ResourceManager resourceManager_0, string string_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 33:
				return Class18.Class19.smethod_2(resourceManager_0, string_0, 941, 959);
			}
		}
	}

	internal static void smethod_7(object object_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 25:
				Class18.smethod_6(object_0, 880, 828);
				return;
			case 26:
				Monitor.Exit(object_0);
				return;
			}
		}
	}

	internal static MethodInfo[] smethod_8(Type type_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 27:
				return Class15.smethod_4(type_0, 151, 155);
			}
		}
	}
}
