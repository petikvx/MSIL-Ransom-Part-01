using System;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Security.Policy;
using System.Threading;

namespace ns3;

internal sealed class Class5
{
	internal sealed class Class6
	{
		internal sealed class Class7
		{
			internal static string smethod_0(string string_0, int int_0, int int_1)
			{
				while (true)
				{
					switch (int_1 ^ int_0)
					{
					case 51:
						return Class6.smethod_10(string_0, 298, 284);
					case 52:
						return Class6.smethod_10(string_0, 177, 134);
					}
				}
			}

			internal static string smethod_1(ResolveEventArgs resolveEventArgs_0, int int_0, int int_1)
			{
				while (true)
				{
					switch (int_1 ^ int_0)
					{
					case 67:
						return Class6.smethod_11(resolveEventArgs_0, 506, 445);
					}
				}
			}

			internal static Stream smethod_2(Assembly assembly_0, string string_0, int int_0, int int_1)
			{
				while (true)
				{
					switch (int_1 ^ int_0)
					{
					case 64:
						return Class5.smethod_8(assembly_0, string_0, 727, 746);
					}
				}
			}

			internal static AppDomain smethod_3(int int_0, int int_1)
			{
				while (true)
				{
					switch (int_1 ^ int_0)
					{
					case 27:
						return Class6.smethod_12(876, 894);
					}
				}
			}

			internal static void smethod_4(AppDomain appDomain_0, string string_0, object object_0, int int_0, int int_1)
			{
				while (true)
				{
					switch (int_1 ^ int_0)
					{
					case 71:
						Class8.smethod_2(appDomain_0, string_0, object_0, 32, 115);
						return;
					}
				}
			}

			internal static string smethod_5(string string_0, string string_1, int int_0, int int_1)
			{
				while (true)
				{
					switch (int_1 ^ int_0)
					{
					case 27:
						return Class5.smethod_10(string_0, string_1, 807, 870);
					}
				}
			}

			internal static void smethod_6(Process process_0, int int_0, int int_1)
			{
				while (true)
				{
					switch (int_1 ^ int_0)
					{
					case 38:
						smethod_9(process_0, 750, 640);
						return;
					}
				}
			}

			internal static void smethod_7(ProcessStartInfo processStartInfo_0, string string_0, int int_0, int int_1)
			{
				while (true)
				{
					switch (int_1 ^ int_0)
					{
					case 42:
						smethod_14(processStartInfo_0, string_0, 511, 468);
						return;
					}
				}
			}

			internal static void smethod_8(object object_0, int int_0, int int_1)
			{
				while (true)
				{
					switch (int_1 ^ int_0)
					{
					case 75:
						Class8.Class9.smethod_3(object_0, 569, 524);
						return;
					}
				}
			}

			internal static void smethod_9(Process process_0, int int_0, int int_1)
			{
				while (true)
				{
					switch (int_1 ^ int_0)
					{
					case 110:
						process_0.WaitForExit();
						return;
					}
				}
			}

			internal static bool smethod_10(DateTime dateTime_0, DateTime dateTime_1, int int_0, int int_1)
			{
				while (true)
				{
					switch (int_1 ^ int_0)
					{
					case 68:
						return dateTime_0 > dateTime_1;
					}
				}
			}

			internal static Assembly smethod_11(int int_0, int int_1)
			{
				while (true)
				{
					switch (int_1 ^ int_0)
					{
					case 33:
						return Assembly.GetExecutingAssembly();
					}
				}
			}

			internal static void smethod_12(Stream stream_0, byte[] byte_0, int int_0, int int_1, int int_2, int int_3)
			{
				while (true)
				{
					switch (int_3 ^ int_2)
					{
					case 25:
						stream_0.Write(byte_0, int_0, int_1);
						return;
					}
				}
			}
		}

		internal sealed class Class8
		{
			internal sealed class Class9
			{
				internal static ProcessStartInfo smethod_0(Process process_0, int int_0, int int_1)
				{
					while (true)
					{
						switch (int_1 ^ int_0)
						{
						case 38:
							return smethod_9(process_0, 195, 226);
						}
					}
				}

				internal static void smethod_1(AppDomain appDomain_0, ResolveEventHandler resolveEventHandler_0, int int_0, int int_1)
				{
					while (true)
					{
						switch (int_1 ^ int_0)
						{
						case 35:
							Class5.smethod_11(appDomain_0, resolveEventHandler_0, 305, 380);
							return;
						}
					}
				}

				internal static bool smethod_2(DateTime dateTime_0, DateTime dateTime_1, int int_0, int int_1)
				{
					while (true)
					{
						switch (int_1 ^ int_0)
						{
						case 79:
							return Class7.smethod_10(dateTime_0, dateTime_1, 947, 1015);
						}
					}
				}

				internal static void smethod_3(object object_0, int int_0, int int_1)
				{
					while (true)
					{
						switch (int_1 ^ int_0)
						{
						case 53:
							Monitor.Enter(object_0);
							return;
						case 54:
							Monitor.Exit(object_0);
							return;
						}
					}
				}

				internal static bool smethod_4(Process process_0, int int_0, int int_1)
				{
					while (true)
					{
						switch (int_1 ^ int_0)
						{
						case 8:
							return process_0.Start();
						}
					}
				}

				internal static int smethod_5(Stream stream_0, byte[] byte_0, int int_0, int int_1, int int_2, int int_3)
				{
					while (true)
					{
						switch (int_3 ^ int_2)
						{
						case 29:
							return stream_0.Read(byte_0, int_0, int_1);
						}
					}
				}

				internal static string[] smethod_6(Assembly assembly_0, int int_0, int int_1)
				{
					while (true)
					{
						switch (int_1 ^ int_0)
						{
						case 88:
							return assembly_0.GetManifestResourceNames();
						}
					}
				}

				internal static Assembly smethod_7(byte[] byte_0, byte[] byte_1, Evidence evidence_0, int int_0, int int_1)
				{
					while (true)
					{
						switch (int_1 ^ int_0)
						{
						case 117:
							return Assembly.Load(byte_0, byte_1, evidence_0);
						}
					}
				}
			}

			internal static DateTime smethod_0(int int_0, int int_1)
			{
				while (true)
				{
					switch (int_1 ^ int_0)
					{
					case 67:
						return smethod_15(76, 40);
					}
				}
			}

			internal static Assembly smethod_1(int int_0, int int_1)
			{
				while (true)
				{
					switch (int_1 ^ int_0)
					{
					case 48:
						return Class7.smethod_11(133, 164);
					}
				}
			}

			internal static void smethod_2(AppDomain appDomain_0, string string_0, object object_0, int int_0, int int_1)
			{
				while (true)
				{
					switch (int_1 ^ int_0)
					{
					case 83:
						Class5.smethod_12(appDomain_0, string_0, object_0, 1009, 971);
						return;
					}
				}
			}

			internal static char[] smethod_3(string string_0, int int_0, int int_1)
			{
				while (true)
				{
					switch (int_1 ^ int_0)
					{
					case 70:
						return smethod_16(string_0, 804, 840);
					}
				}
			}

			internal static long smethod_4(Stream stream_0, int int_0, int int_1)
			{
				while (true)
				{
					switch (int_1 ^ int_0)
					{
					case 69:
						return smethod_17(stream_0, 798, 860);
					}
				}
			}

			internal static bool smethod_5(Process process_0, int int_0, int int_1)
			{
				while (true)
				{
					switch (int_1 ^ int_0)
					{
					case 40:
						return Class9.smethod_4(process_0, 317, 309);
					}
				}
			}

			internal static int smethod_6(Stream stream_0, byte[] byte_0, int int_0, int int_1, int int_2, int int_3)
			{
				while (true)
				{
					switch (int_3 ^ int_2)
					{
					case 122:
						return Class9.smethod_5(stream_0, byte_0, int_0, int_1, 153, 132);
					}
				}
			}

			internal static int smethod_7(string string_0, int int_0, int int_1)
			{
				while (true)
				{
					switch (int_1 ^ int_0)
					{
					case 107:
						return Class5.smethod_13(string_0, 701, 730);
					}
				}
			}

			internal static string[] smethod_8(Assembly assembly_0, int int_0, int int_1)
			{
				while (true)
				{
					switch (int_1 ^ int_0)
					{
					case 113:
						return Class9.smethod_6(assembly_0, 514, 602);
					}
				}
			}

			internal static ProcessStartInfo smethod_9(Process process_0, int int_0, int int_1)
			{
				while (true)
				{
					switch (int_1 ^ int_0)
					{
					case 33:
						return process_0.StartInfo;
					}
				}
			}

			internal static object smethod_10(AppDomain appDomain_0, string string_0, int int_0, int int_1)
			{
				while (true)
				{
					switch (int_1 ^ int_0)
					{
					case 38:
						return appDomain_0.GetData(string_0);
					}
				}
			}

			internal static void smethod_11(ProcessStartInfo processStartInfo_0, ProcessWindowStyle processWindowStyle_0, int int_0, int int_1)
			{
				while (true)
				{
					switch (int_1 ^ int_0)
					{
					case 58:
						processStartInfo_0.WindowStyle = processWindowStyle_0;
						return;
					}
				}
			}

			internal static string smethod_12(string string_0, int int_0, int int_1)
			{
				while (true)
				{
					switch (int_1 ^ int_0)
					{
					case 56:
						return string.Intern(string_0);
					case 57:
						return Environment.GetEnvironmentVariable(string_0);
					}
				}
			}

			internal static string smethod_13(ResolveEventArgs resolveEventArgs_0, int int_0, int int_1)
			{
				while (true)
				{
					switch (int_1 ^ int_0)
					{
					case 107:
						return resolveEventArgs_0.Name;
					}
				}
			}

			internal static AppDomain smethod_14(int int_0, int int_1)
			{
				while (true)
				{
					switch (int_1 ^ int_0)
					{
					case 81:
						return AppDomain.CurrentDomain;
					}
				}
			}
		}

		internal static int smethod_0(Stream stream_0, byte[] byte_0, int int_0, int int_1, int int_2, int int_3)
		{
			while (true)
			{
				switch (int_3 ^ int_2)
				{
				case 61:
					return Class8.smethod_6(stream_0, byte_0, int_0, int_1, 333, 311);
				}
			}
		}

		internal static void smethod_1(ProcessStartInfo processStartInfo_0, string string_0, int int_0, int int_1)
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 19:
					Class7.smethod_7(processStartInfo_0, string_0, 331, 353);
					return;
				}
			}
		}

		internal static void smethod_2(AppDomain appDomain_0, ResolveEventHandler resolveEventHandler_0, int int_0, int int_1)
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 110:
					Class8.Class9.smethod_1(appDomain_0, resolveEventHandler_0, 498, 465);
					return;
				}
			}
		}

		internal static Evidence smethod_3(Assembly assembly_0, int int_0, int int_1)
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 97:
					return smethod_13(assembly_0, 630, 613);
				}
			}
		}

		internal static bool smethod_4(Process process_0, int int_0, int int_1)
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 3:
					return Class8.smethod_5(process_0, 830, 790);
				}
			}
		}

		internal static int smethod_5(string string_0, int int_0, int int_1)
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 5:
					return Class8.smethod_7(string_0, 50, 89);
				}
			}
		}

		internal static object smethod_6(AppDomain appDomain_0, string string_0, int int_0, int int_1)
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 58:
					return Class8.smethod_10(appDomain_0, string_0, 139, 173);
				}
			}
		}

		internal static void smethod_7(Stream stream_0, byte[] byte_0, int int_0, int int_1, int int_2, int int_3)
		{
			while (true)
			{
				switch (int_3 ^ int_2)
				{
				case 12:
					Class7.smethod_12(stream_0, byte_0, int_0, int_1, 541, 516);
					return;
				}
			}
		}

		internal static void smethod_8(ProcessStartInfo processStartInfo_0, ProcessWindowStyle processWindowStyle_0, int int_0, int int_1)
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 44:
					Class8.smethod_11(processStartInfo_0, processWindowStyle_0, 395, 433);
					return;
				}
			}
		}

		internal static byte[] smethod_9(MemoryStream memoryStream_0, int int_0, int int_1)
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 39:
					return smethod_18(memoryStream_0, 150, 133);
				}
			}
		}

		internal static string smethod_10(string string_0, int int_0, int int_1)
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 54:
					return Class8.smethod_12(string_0, 460, 500);
				case 55:
					return Class8.smethod_12(string_0, 602, 611);
				}
			}
		}

		internal static string smethod_11(ResolveEventArgs resolveEventArgs_0, int int_0, int int_1)
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 71:
					return Class8.smethod_13(resolveEventArgs_0, 578, 553);
				}
			}
		}

		internal static AppDomain smethod_12(int int_0, int int_1)
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 18:
					return Class8.smethod_14(401, 448);
				}
			}
		}

		internal static Evidence smethod_13(Assembly assembly_0, int int_0, int int_1)
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 19:
					return Class5.smethod_14(assembly_0, 1010, 1018);
				}
			}
		}

		internal static void smethod_14(ProcessStartInfo processStartInfo_0, string string_0, int int_0, int int_1)
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 43:
					processStartInfo_0.FileName = string_0;
					return;
				}
			}
		}

		internal static DateTime smethod_15(int int_0, int int_1)
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 100:
					return DateTime.Now;
				}
			}
		}

		internal static char[] smethod_16(string string_0, int int_0, int int_1)
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 108:
					return string_0.ToCharArray();
				}
			}
		}

		internal static long smethod_17(Stream stream_0, int int_0, int int_1)
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 66:
					return stream_0.Length;
				}
			}
		}

		internal static byte[] smethod_18(MemoryStream memoryStream_0, int int_0, int int_1)
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 19:
					return memoryStream_0.ToArray();
				}
			}
		}

		internal static void smethod_19(Array array_0, RuntimeFieldHandle runtimeFieldHandle_0, int int_0, int int_1)
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 91:
					RuntimeHelpers.InitializeArray(array_0, runtimeFieldHandle_0);
					return;
				}
			}
		}

		internal static Stream smethod_20(Assembly assembly_0, string string_0, int int_0, int int_1)
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 53:
					return assembly_0.GetManifestResourceStream(string_0);
				}
			}
		}
	}

	internal static string[] smethod_0(Assembly assembly_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 82:
				return Class6.Class8.smethod_8(assembly_0, 127, 14);
			}
		}
	}

	internal static ProcessStartInfo smethod_1(Process process_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 23:
				return Class6.Class8.Class9.smethod_0(process_0, 142, 168);
			}
		}
	}

	internal static void smethod_2(object object_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 9:
				Class6.Class7.smethod_8(object_0, 846, 773);
				return;
			case 10:
				Class6.Class8.Class9.smethod_3(object_0, 754, 708);
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
			case 56:
				return Class6.Class8.Class9.smethod_2(dateTime_0, dateTime_1, 88, 23);
			}
		}
	}

	internal static Assembly smethod_4(byte[] byte_0, byte[] byte_1, Evidence evidence_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 92:
				return smethod_9(byte_0, byte_1, evidence_0, 175, 245);
			}
		}
	}

	internal static void smethod_5(Array array_0, RuntimeFieldHandle runtimeFieldHandle_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 90:
				Class6.smethod_19(array_0, runtimeFieldHandle_0, 720, 651);
				return;
			}
		}
	}

	internal static void smethod_6(Stream stream_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 66:
				smethod_15(stream_0, 876, 781);
				return;
			case 67:
				stream_0.Close();
				return;
			}
		}
	}

	internal static Type smethod_7(RuntimeTypeHandle runtimeTypeHandle_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 114:
				return smethod_16(runtimeTypeHandle_0, 85, 126);
			}
		}
	}

	internal static Stream smethod_8(Assembly assembly_0, string string_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 61:
				return Class6.smethod_20(assembly_0, string_0, 964, 1009);
			}
		}
	}

	internal static Assembly smethod_9(byte[] byte_0, byte[] byte_1, Evidence evidence_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 90:
				return Class6.Class8.Class9.smethod_7(byte_0, byte_1, evidence_0, 533, 608);
			}
		}
	}

	internal static string smethod_10(string string_0, string string_1, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 65:
				return string_0 + string_1;
			}
		}
	}

	internal static void smethod_11(AppDomain appDomain_0, ResolveEventHandler resolveEventHandler_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 77:
				appDomain_0.ResourceResolve += resolveEventHandler_0;
				return;
			}
		}
	}

	internal static void smethod_12(AppDomain appDomain_0, string string_0, object object_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 58:
				appDomain_0.SetData(string_0, object_0);
				return;
			}
		}
	}

	internal static int smethod_13(string string_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 103:
				return string_0.Length;
			}
		}
	}

	internal static Evidence smethod_14(Assembly assembly_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 8:
				return assembly_0.get_Evidence();
			}
		}
	}

	internal static void smethod_15(Stream stream_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 97:
				stream_0.Dispose();
				return;
			}
		}
	}

	internal static Type smethod_16(RuntimeTypeHandle runtimeTypeHandle_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 43:
				return Type.GetTypeFromHandle(runtimeTypeHandle_0);
			}
		}
	}
}
