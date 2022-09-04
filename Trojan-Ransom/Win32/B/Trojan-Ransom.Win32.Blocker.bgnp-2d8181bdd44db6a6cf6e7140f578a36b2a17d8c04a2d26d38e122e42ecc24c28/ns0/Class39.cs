using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Policy;
using System.Text;
using System.Threading;
using Microsoft.VisualBasic.CompilerServices;

namespace ns0;

internal sealed class Class39
{
	internal sealed class Class40
	{
		[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 86)]
		private struct Struct13
		{
		}

		private static readonly char[] char_0;

		private static readonly char[] char_1;

		private static readonly string[] string_0;

		internal static byte byte_0/* Not supported: data(00) */;

		internal static DateTime smethod_0(int int_0, int int_1)
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 59:
					return DateTime.Now;
				}
			}
		}

		internal static byte[] smethod_1(MemoryStream memoryStream_0, int int_0, int int_1)
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 121:
					return memoryStream_0.ToArray();
				}
			}
		}

		internal static void smethod_2(AppDomain appDomain_0, ResolveEventHandler resolveEventHandler_0, int int_0, int int_1)
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 83:
					appDomain_0.ResourceResolve += resolveEventHandler_0;
					return;
				}
			}
		}

		internal static char smethod_3(string string_1, int int_0, int int_1, int int_2)
		{
			while (true)
			{
				switch (int_2 ^ int_1)
				{
				case 113:
					return string_1[int_0];
				}
			}
		}

		internal static MethodInfo smethod_4(Assembly assembly_0, int int_0, int int_1)
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 47:
					return assembly_0.EntryPoint;
				}
			}
		}

		internal static string smethod_5(Encoding encoding_0, byte[] byte_1, int int_0, int int_1)
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 94:
					return encoding_0.GetString(byte_1);
				}
			}
		}

		internal static Stream smethod_6(Assembly assembly_0, string string_1, int int_0, int int_1)
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 34:
					return assembly_0.GetManifestResourceStream(string_1);
				}
			}
		}

		internal static void smethod_7(Process process_0, int int_0, int int_1)
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 93:
					process_0.Kill();
					return;
				}
			}
		}

		internal static int smethod_8(ref IntPtr intptr_0, int int_0, int int_1)
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 115:
					return intptr_0.ToInt32();
				}
			}
		}

		static Class40()
		{
			char_1 = new char[43];
			char[] array = new char[8];
			array[0] = '\u0f9c';
			array[6] = '㞕';
			array[4] = '㹮';
			array[5] = 'コ';
			array[7] = 'Ժ';
			array[3] = '⬸';
			array[1] = 'ᖘ';
			array[2] = '\u1a9e';
			string_0 = new string[1];
			char_0 = array;
		}

		internal static void smethod_9(AppDomain appDomain_0, string string_1, object object_0, int int_0, int int_1)
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 68:
					appDomain_0.SetData(string_1, object_0);
					return;
				}
			}
		}

		internal static long smethod_10(Stream stream_0, int int_0, int int_1)
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 70:
					return stream_0.Length;
				}
			}
		}
	}

	static Class39()
	{
		Class36.Class37.smethod_15();
	}

	internal static Assembly smethod_0(int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 101:
				return Assembly.GetEntryAssembly();
			}
		}
	}

	internal static byte smethod_1(ref Color color_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 70:
				return color_0.A;
			case 71:
				return color_0.G;
			case 72:
				return color_0.B;
			}
		}
	}

	internal static void smethod_2(object object_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 44:
				Monitor.Enter(object_0);
				return;
			case 45:
				Monitor.Exit(object_0);
				return;
			}
		}
	}

	internal static void smethod_3(AppDomain appDomain_0, string string_0, object object_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 37:
				appDomain_0.SetData(string_0, object_0);
				return;
			}
		}
	}

	internal static string smethod_4(char char_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 28:
				return Conversions.ToString(char_0);
			}
		}
	}

	internal static string smethod_5(string string_0, string string_1, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 7:
				return string_0 + string_1;
			}
		}
	}

	internal static Assembly smethod_6(byte[] byte_0, byte[] byte_1, Evidence evidence_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 8:
				return Assembly.Load(byte_0, byte_1, evidence_0);
			}
		}
	}

	internal static object smethod_7(object object_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 36:
				return RuntimeHelpers.GetObjectValue(object_0);
			}
		}
	}

	internal static int smethod_8(Stream stream_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 109:
				return stream_0.ReadByte();
			}
		}
	}

	internal static object smethod_9(AppDomain appDomain_0, string string_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 71:
				return appDomain_0.GetData(string_0);
			}
		}
	}

	internal static Encoding smethod_10(int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 72:
				return Encoding.UTF8;
			}
		}
	}

	internal static void smethod_11(Array array_0, RuntimeFieldHandle runtimeFieldHandle_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 33:
				RuntimeHelpers.InitializeArray(array_0, runtimeFieldHandle_0);
				return;
			}
		}
	}

	internal static string smethod_12(Assembly assembly_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 104:
				return assembly_0.Location;
			}
		}
	}

	internal static object smethod_13(MethodBase methodBase_0, object object_0, object[] object_1, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 4:
				return methodBase_0.Invoke(object_0, object_1);
			}
		}
	}

	internal static void smethod_14(Thread thread_0, object object_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 0:
				thread_0.Start(object_0);
				return;
			}
		}
	}

	internal static string smethod_15(object object_0, object object_1, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 62:
				return string.Concat(object_0, object_1);
			}
		}
	}

	internal static void smethod_16(Stream stream_0, byte[] byte_0, int int_0, int int_1, int int_2, int int_3)
	{
		while (true)
		{
			switch (int_3 ^ int_2)
			{
			case 120:
				stream_0.Write(byte_0, int_0, int_1);
				return;
			}
		}
	}

	internal static Evidence smethod_17(Assembly assembly_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 0:
				return assembly_0.get_Evidence();
			}
		}
	}
}
