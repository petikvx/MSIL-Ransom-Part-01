using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Security.Policy;
using System.Threading;

namespace ns0;

internal sealed class Class34
{
	internal sealed class Class35
	{
		internal static string[] smethod_0(string string_0, char[] char_0, int int_0, int int_1)
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 1:
					return Class36.Class37.smethod_1(string_0, char_0, 1, 1);
				}
			}
		}

		internal static Assembly smethod_1(int int_0, int int_1)
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 80:
					return Class39.smethod_0(457, 428);
				}
			}
		}

		internal static byte smethod_2(ref Color color_0, int int_0, int int_1)
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 109:
					return Class39.smethod_1(ref color_0, 407, 465);
				case 110:
					return Class39.smethod_1(ref color_0, 300, 363);
				}
			}
		}

		internal static char smethod_3(int int_0, int int_1, int int_2)
		{
			while (true)
			{
				switch (int_2 ^ int_1)
				{
				case 7:
					return Class36.smethod_0(int_0, 349, 289);
				}
			}
		}

		internal static bool smethod_4(string string_0, string string_1, int int_0, int int_1)
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 27:
					return Class36.smethod_1(string_0, string_1, 527, 527);
				}
			}
		}

		internal static void smethod_5(object object_0, int int_0, int int_1)
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 15:
					Class39.smethod_2(object_0, 936, 900);
					return;
				}
			}
		}

		internal static void smethod_6(object object_0, int int_0, int int_1)
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 37:
					Monitor.Exit(object_0);
					return;
				}
			}
		}

		internal static object smethod_7(MethodBase methodBase_0, object object_0, object[] object_1, int int_0, int int_1)
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 86:
					return Class39.smethod_13(methodBase_0, object_0, object_1, 125, 121);
				}
			}
		}

		internal static void smethod_8(AppDomain appDomain_0, string string_0, object object_0, int int_0, int int_1)
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 124:
					Class39.smethod_3(appDomain_0, string_0, object_0, 626, 599);
					return;
				}
			}
		}

		internal static Stream smethod_9(Assembly assembly_0, string string_0, int int_0, int int_1)
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 74:
					return Class39.Class40.smethod_6(assembly_0, string_0, 609, 579);
				}
			}
		}

		internal static void smethod_10(Stream stream_0, byte[] byte_0, int int_0, int int_1, int int_2, int int_3)
		{
			while (true)
			{
				switch (int_3 ^ int_2)
				{
				case 43:
					Class36.smethod_2(stream_0, byte_0, int_0, int_1, 296, 298);
					return;
				}
			}
		}

		internal static int smethod_11(ref Color color_0, int int_0, int int_1)
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 101:
					return Class36.Class38.smethod_4(ref color_0, 3, 76);
				}
			}
		}

		internal static void smethod_12(Thread thread_0, object object_0, int int_0, int int_1)
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 52:
					Class39.smethod_14(thread_0, object_0, 361, 361);
					return;
				}
			}
		}

		internal static object smethod_13(AppDomain appDomain_0, string string_0, int int_0, int int_1)
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 54:
					return Class39.smethod_9(appDomain_0, string_0, 767, 696);
				}
			}
		}

		internal static byte[] smethod_14(MemoryStream memoryStream_0, int int_0, int int_1)
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 12:
					return Class39.Class40.smethod_1(memoryStream_0, 553, 592);
				}
			}
		}

		internal static Evidence smethod_15(Assembly assembly_0, int int_0, int int_1)
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 9:
					return Class36.Class37.smethod_14(assembly_0, 837, 870);
				}
			}
		}

		static Class35()
		{
			Class36.Class37.smethod_15();
		}
	}

	static Class34()
	{
		Class36.Class37.smethod_15();
		Class31.Class32.smethod_12();
	}

	internal static int smethod_0(Stream stream_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 110:
				return Class39.smethod_8(stream_0, 843, 806);
			}
		}
	}

	internal static void smethod_1(Array array_0, RuntimeFieldHandle runtimeFieldHandle_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 17:
				Class39.smethod_11(array_0, runtimeFieldHandle_0, 76, 109);
				return;
			}
		}
	}

	internal static void smethod_2(Thread thread_0, ApartmentState apartmentState_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 37:
				Class36.Class38.smethod_5(thread_0, apartmentState_0, 776, 771);
				return;
			}
		}
	}

	internal static bool smethod_3(DateTime dateTime_0, DateTime dateTime_1, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 48:
				return Class36.Class38.smethod_6(dateTime_0, dateTime_1, 834, 814);
			}
		}
	}

	internal static Assembly smethod_4(byte[] byte_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 39:
				return Class36.Class38.smethod_7(byte_0, 85, 79);
			}
		}
	}

	internal static void smethod_5(Array array_0, int int_0, Array array_1, int int_1, int int_2, int int_3, int int_4)
	{
		while (true)
		{
			switch (int_4 ^ int_3)
			{
			case 91:
				Class36.Class38.smethod_8(array_0, int_0, array_1, int_1, int_2, 298, 360);
				return;
			}
		}
	}

	internal static int smethod_6(string string_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 72:
				return Class36.smethod_10(string_0, 512, 592);
			}
		}
	}

	internal static void smethod_7(Process process_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 86:
				Class39.Class40.smethod_7(process_0, 913, 972);
				return;
			}
		}
	}

	internal static long smethod_8(Stream stream_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 37:
				return Class36.Class38.smethod_3(stream_0, 990, 1006);
			}
		}
	}

	internal static string[] smethod_9(string string_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 65:
				return Class36.smethod_11(string_0, 647, 670);
			}
		}
	}

	internal static int smethod_10(ref IntPtr intptr_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 4:
				return Class39.Class40.smethod_8(ref intptr_0, 199, 180);
			}
		}
	}

	internal static Delegate smethod_11(IntPtr intptr_0, Type type_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 24:
				return Class36.Class38.smethod_9(intptr_0, type_0, 611, 629);
			}
		}
	}

	internal static Exception smethod_12(int int_0, int int_1, int int_2)
	{
		while (true)
		{
			switch (int_2 ^ int_1)
			{
			case 117:
				return Class36.Class38.smethod_10(int_0, 5, 75);
			}
		}
	}

	internal static string smethod_13(object object_0, object object_1, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 11:
				return Class36.Class37.smethod_10(object_0, object_1, 190, 233);
			}
		}
	}

	internal static Assembly smethod_14(int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 104:
				return Class36.smethod_6(137, 214);
			}
		}
	}

	internal static Stream smethod_15(Assembly assembly_0, string string_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 52:
				return Class39.Class40.smethod_6(assembly_0, string_0, 570, 536);
			}
		}
	}
}
