using System;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Resources;
using System.Security.Policy;
using System.Text;

namespace ns0;

internal sealed class Class8
{
	internal sealed class Class9
	{
		internal static bool smethod_0(string string_0, string string_1, int int_0, int int_1)
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 118:
					return Class13.Class14.smethod_2(string_0, string_1, 622, 526);
				}
			}
		}

		internal static Type[] smethod_1(Assembly assembly_0, int int_0, int int_1)
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 28:
					return Class10.smethod_4(assembly_0, 670, 759);
				}
			}
		}

		internal static void smethod_2(Stream stream_0, byte[] byte_0, int int_0, int int_1, int int_2, int int_3)
		{
			while (true)
			{
				switch (int_3 ^ int_2)
				{
				case 63:
					Class13.smethod_3(stream_0, byte_0, int_0, int_1, 901, 995);
					return;
				}
			}
		}

		internal static AppDomain smethod_3(int int_0, int int_1)
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 20:
					return Class13.smethod_0(907, 1015);
				}
			}
		}

		internal static Stream smethod_4(Assembly assembly_0, string string_0, int int_0, int int_1)
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 86:
					return Class10.smethod_2(assembly_0, string_0, 195, 231);
				}
			}
		}

		internal static byte[] smethod_5(Encoding encoding_0, string string_0, int int_0, int int_1)
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 63:
					return Class10.Class11.smethod_2(encoding_0, string_0, 888, 887);
				}
			}
		}

		internal static Process smethod_6(string string_0, int int_0, int int_1)
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 16:
					return Class13.smethod_5(string_0, 728, 767);
				}
			}
		}

		internal static string smethod_7(ResolveEventArgs resolveEventArgs_0, int int_0, int int_1)
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 56:
					return Class10.smethod_5(resolveEventArgs_0, 642, 754);
				}
			}
		}

		internal static void smethod_8(AppDomain appDomain_0, string string_0, object object_0, int int_0, int int_1)
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 33:
					Class10.Class11.smethod_0(appDomain_0, string_0, object_0, 576, 548);
					return;
				}
			}
		}

		internal static Assembly smethod_9(int int_0, int int_1)
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 5:
					return Class10.Class11.Class12.smethod_0(926, 969);
				}
			}
		}

		internal static long smethod_10(Stream stream_0, int int_0, int int_1)
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 32:
					return Class10.Class11.smethod_1(stream_0, 394, 460);
				}
			}
		}

		internal static byte[] smethod_11(MemoryStream memoryStream_0, int int_0, int int_1)
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 95:
					return Class10.smethod_3(memoryStream_0, 155, 225);
				}
			}
		}

		static Class9()
		{
			Class15.smethod_6();
			Class10.smethod_7();
		}
	}

	static Class8()
	{
		Class15.smethod_6();
		Class10.smethod_7();
		Class5.Class6.smethod_7();
	}

	internal static void smethod_0(Array array_0, RuntimeFieldHandle runtimeFieldHandle_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 1:
				Class13.Class14.smethod_3(array_0, runtimeFieldHandle_0, 246, 152);
				return;
			}
		}
	}

	internal static object smethod_1(ResourceManager resourceManager_0, string string_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 9:
				return Class13.smethod_6(resourceManager_0, string_0, 759, 726);
			}
		}
	}

	internal static Encoding smethod_2(int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 10:
				return Class10.Class11.Class12.smethod_2(991, 989);
			case 11:
				return Class10.Class11.Class12.smethod_2(496, 499);
			}
		}
	}

	internal static long smethod_3(Stream stream_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 88:
				return Class10.Class11.smethod_1(stream_0, 930, 996);
			}
		}
	}

	internal static string smethod_4(int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 118:
				return Class13.Class14.smethod_4(19, 113);
			}
		}
	}

	internal static string smethod_5(object object_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 73:
				return Class10.Class11.smethod_3(object_0, 968, 975);
			}
		}
	}

	internal static void smethod_6(string string_0, byte[] byte_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 118:
				Class13.Class14.smethod_5(string_0, byte_0, 957, 1015);
				return;
			}
		}
	}

	internal static object smethod_7(AppDomain appDomain_0, string string_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 32:
				return Class13.smethod_1(appDomain_0, string_0, 418, 448);
			}
		}
	}

	internal static int smethod_8(Stream stream_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 96:
				return Class13.smethod_2(stream_0, 378, 353);
			}
		}
	}

	internal static int smethod_9(Stream stream_0, byte[] byte_0, int int_0, int int_1, int int_2, int int_3)
	{
		while (true)
		{
			switch (int_3 ^ int_2)
			{
			case 1:
				return Class13.Class14.smethod_1(stream_0, byte_0, int_0, int_1, 749, 702);
			case 2:
				return stream_0.Read(byte_0, int_0, int_1);
			}
		}
	}

	internal static Assembly smethod_10(byte[] byte_0, byte[] byte_1, Evidence evidence_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 108:
				return Class10.Class11.Class12.smethod_1(byte_0, byte_1, evidence_0, 341, 275);
			}
		}
	}
}
