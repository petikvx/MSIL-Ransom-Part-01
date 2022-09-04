using System;
using System.IO;
using System.Reflection;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Policy;
using System.Text;
using System.Threading;

namespace ns0;

internal sealed class Class9
{
	internal sealed class Class10
	{
		internal static int smethod_0(Stream stream_0, byte[] byte_0, int int_0, int int_1, int int_2, int int_3)
		{
			while (true)
			{
				switch (int_3 ^ int_2)
				{
				case 42:
					return stream_0.Read(byte_0, int_0, int_1);
				}
			}
		}

		internal static DateTime smethod_1(int int_0, int int_1)
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 81:
					return DateTime.Now;
				}
			}
		}

		internal static void smethod_2(ResourceManager resourceManager_0, int int_0, int int_1)
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 1:
					resourceManager_0.ReleaseAllResources();
					return;
				}
			}
		}

		internal static int smethod_3(string string_0, int int_0, int int_1)
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 35:
					return string_0.Length;
				}
			}
		}

		internal static void smethod_4(AppDomain appDomain_0, ResolveEventHandler resolveEventHandler_0, int int_0, int int_1)
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 82:
					appDomain_0.ResourceResolve += resolveEventHandler_0;
					return;
				}
			}
		}

		internal static void smethod_5(Stream stream_0, byte[] byte_0, int int_0, int int_1, int int_2, int int_3)
		{
			while (true)
			{
				switch (int_3 ^ int_2)
				{
				case 123:
					stream_0.Write(byte_0, int_0, int_1);
					return;
				}
			}
		}
	}

	internal sealed class Class11
	{
		internal static void smethod_0(AppDomain appDomain_0, string string_0, object object_0, int int_0, int int_1)
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 120:
					appDomain_0.SetData(string_0, object_0);
					return;
				}
			}
		}

		internal static string smethod_1(string string_0, string string_1, int int_0, int int_1)
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 20:
					return string_0 + string_1;
				}
			}
		}

		internal static Assembly smethod_2(byte[] byte_0, byte[] byte_1, Evidence evidence_0, int int_0, int int_1)
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 109:
					return Assembly.Load(byte_0, byte_1, evidence_0);
				}
			}
		}

		internal static string smethod_3(ResolveEventArgs resolveEventArgs_0, int int_0, int int_1)
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 73:
					return resolveEventArgs_0.Name;
				}
			}
		}

		internal static ParameterInfo[] smethod_4(MethodBase methodBase_0, int int_0, int int_1)
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 38:
					return methodBase_0.GetParameters();
				}
			}
		}

		internal static int smethod_5(int int_0, int int_1)
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 66:
					return Environment.TickCount;
				}
			}
		}

		internal static Type smethod_6(RuntimeTypeHandle runtimeTypeHandle_0, int int_0, int int_1)
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 112:
					return Type.GetTypeFromHandle(runtimeTypeHandle_0);
				}
			}
		}

		internal static bool smethod_7(DateTime dateTime_0, DateTime dateTime_1, int int_0, int int_1)
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 113:
					return dateTime_0 > dateTime_1;
				}
			}
		}

		internal static void smethod_8(object object_0, int int_0, int int_1)
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 78:
					Monitor.Enter(object_0);
					return;
				case 79:
					Monitor.Exit(object_0);
					return;
				}
			}
		}
	}

	[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 78)]
	private struct Struct3
	{
	}

	private static readonly char[] char_0;

	private static readonly char[] char_1;

	private static readonly string[] string_0;

	internal static byte byte_0/* Not supported: data(00) */;

	static Class9()
	{
		char_1 = new char[39];
		char[] array = new char[8];
		array[7] = '⚂';
		array[6] = '㬑';
		array[5] = '\u20e3';
		array[1] = 'ዷ';
		array[0] = '⹉';
		array[4] = '⡡';
		array[3] = '\u1f17';
		array[2] = '⮬';
		string_0 = new string[1];
		char_0 = array;
	}

	internal static string smethod_0(string string_1, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 113:
				return string.Intern(string_1);
			}
		}
	}

	internal static byte[] smethod_1(Encoding encoding_0, string string_1, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 58:
				return encoding_0.GetBytes(string_1);
			}
		}
	}

	internal static Evidence smethod_2(Assembly assembly_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 100:
				return assembly_0.get_Evidence();
			}
		}
	}

	internal static void smethod_3(Array array_0, RuntimeFieldHandle runtimeFieldHandle_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 50:
				RuntimeHelpers.InitializeArray(array_0, runtimeFieldHandle_0);
				return;
			}
		}
	}

	internal static Assembly smethod_4(byte[] byte_1, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 123:
				return Assembly.Load(byte_1);
			}
		}
	}

	internal static object smethod_5(AppDomain appDomain_0, string string_1, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 97:
				return appDomain_0.GetData(string_1);
			}
		}
	}

	internal static Stream smethod_6(Assembly assembly_0, string string_1, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 61:
				return assembly_0.GetManifestResourceStream(string_1);
			}
		}
	}

	internal static object smethod_7(ResourceManager resourceManager_0, string string_1, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 76:
				return resourceManager_0.GetObject(string_1);
			}
		}
	}

	internal static string[] smethod_8(Assembly assembly_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 52:
				return assembly_0.GetManifestResourceNames();
			}
		}
	}
}
