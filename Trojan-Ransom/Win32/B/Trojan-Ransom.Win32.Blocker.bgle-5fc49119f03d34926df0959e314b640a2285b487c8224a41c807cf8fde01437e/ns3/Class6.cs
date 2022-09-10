using System;
using System.IO;
using System.Reflection;
using System.Resources;
using System.Security.Policy;
using System.Threading;

namespace ns3;

internal sealed class Class6
{
	internal sealed class Class7
	{
		internal sealed class Class8
		{
			internal static object smethod_0(AppDomain appDomain_0, string string_0, int int_0, int int_1)
			{
				while (true)
				{
					switch (int_1 ^ int_0)
					{
					case 16:
						return smethod_8(appDomain_0, string_0, 593, 522);
					}
				}
			}

			internal static string smethod_1(ResolveEventArgs resolveEventArgs_0, int int_0, int int_1)
			{
				while (true)
				{
					switch (int_1 ^ int_0)
					{
					case 20:
						return Class6.smethod_4(resolveEventArgs_0, 914, 956);
					}
				}
			}

			internal static int smethod_2(Stream stream_0, byte[] byte_0, int int_0, int int_1, int int_2, int int_3)
			{
				while (true)
				{
					switch (int_3 ^ int_2)
					{
					case 3:
						return Class9.smethod_5(stream_0, byte_0, int_0, int_1, 996, 927);
					}
				}
			}

			internal static ParameterInfo[] smethod_3(MethodBase methodBase_0, int int_0, int int_1)
			{
				while (true)
				{
					switch (int_1 ^ int_0)
					{
					case 7:
						return smethod_9(methodBase_0, 972, 991);
					}
				}
			}

			internal static string[] smethod_4(Assembly assembly_0, int int_0, int int_1)
			{
				while (true)
				{
					switch (int_1 ^ int_0)
					{
					case 42:
						return Class6.smethod_5(assembly_0, 45, 61);
					}
				}
			}

			internal static string smethod_5(Exception exception_0, int int_0, int int_1)
			{
				while (true)
				{
					switch (int_1 ^ int_0)
					{
					case 12:
						return smethod_10(exception_0, 427, 441);
					}
				}
			}

			internal static void smethod_6(AppDomain appDomain_0, ResolveEventHandler resolveEventHandler_0, int int_0, int int_1)
			{
				while (true)
				{
					switch (int_1 ^ int_0)
					{
					case 72:
						appDomain_0.ResourceResolve += resolveEventHandler_0;
						return;
					}
				}
			}
		}

		internal sealed class Class9
		{
			internal sealed class Class10
			{
				internal static int smethod_0(int int_0, int int_1)
				{
					while (true)
					{
						switch (int_1 ^ int_0)
						{
						case 43:
							return Console.Read();
						}
					}
				}

				internal static object smethod_1(ResourceManager resourceManager_0, string string_0, int int_0, int int_1)
				{
					while (true)
					{
						switch (int_1 ^ int_0)
						{
						case 33:
							return resourceManager_0.GetObject(string_0);
						}
					}
				}

				internal static void smethod_2(Thread thread_0, ApartmentState apartmentState_0, int int_0, int int_1)
				{
					while (true)
					{
						switch (int_1 ^ int_0)
						{
						case 55:
							thread_0.SetApartmentState(apartmentState_0);
							return;
						}
					}
				}

				internal static object smethod_3(MethodBase methodBase_0, object object_0, object[] object_1, int int_0, int int_1)
				{
					while (true)
					{
						switch (int_1 ^ int_0)
						{
						case 43:
							return methodBase_0.Invoke(object_0, object_1);
						}
					}
				}

				internal static AppDomain smethod_4(int int_0, int int_1)
				{
					while (true)
					{
						switch (int_1 ^ int_0)
						{
						case 103:
							return AppDomain.CurrentDomain;
						}
					}
				}

				internal static MethodInfo smethod_5(Assembly assembly_0, int int_0, int int_1)
				{
					while (true)
					{
						switch (int_1 ^ int_0)
						{
						case 78:
							return assembly_0.EntryPoint;
						}
					}
				}
			}

			internal static object smethod_0(ResourceManager resourceManager_0, string string_0, int int_0, int int_1)
			{
				while (true)
				{
					switch (int_1 ^ int_0)
					{
					case 40:
						return Class10.smethod_1(resourceManager_0, string_0, 976, 1009);
					}
				}
			}

			internal static Assembly smethod_1(byte[] byte_0, int int_0, int int_1)
			{
				while (true)
				{
					switch (int_1 ^ int_0)
					{
					case 39:
						return smethod_6(byte_0, 449, 404);
					}
				}
			}

			internal static Evidence smethod_2(Assembly assembly_0, int int_0, int int_1)
			{
				while (true)
				{
					switch (int_1 ^ int_0)
					{
					case 15:
						return smethod_11(assembly_0, 289, 327);
					}
				}
			}

			internal static Assembly smethod_3(byte[] byte_0, byte[] byte_1, Evidence evidence_0, int int_0, int int_1)
			{
				while (true)
				{
					switch (int_1 ^ int_0)
					{
					case 66:
						return smethod_7(byte_0, byte_1, evidence_0, 53, 32);
					}
				}
			}

			internal static void smethod_4(string string_0, int int_0, int int_1)
			{
				while (true)
				{
					switch (int_1 ^ int_0)
					{
					case 69:
						Console.Write(string_0);
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
					case 123:
						return stream_0.Read(byte_0, int_0, int_1);
					}
				}
			}

			internal static Assembly smethod_6(byte[] byte_0, int int_0, int int_1)
			{
				while (true)
				{
					switch (int_1 ^ int_0)
					{
					case 85:
						return Assembly.Load(byte_0);
					}
				}
			}

			internal static Assembly smethod_7(byte[] byte_0, byte[] byte_1, Evidence evidence_0, int int_0, int int_1)
			{
				while (true)
				{
					switch (int_1 ^ int_0)
					{
					case 21:
						return Assembly.Load(byte_0, byte_1, evidence_0);
					}
				}
			}

			internal static void smethod_8(Stream stream_0, byte[] byte_0, int int_0, int int_1, int int_2, int int_3)
			{
				while (true)
				{
					switch (int_3 ^ int_2)
					{
					case 24:
						stream_0.Write(byte_0, int_0, int_1);
						return;
					}
				}
			}

			internal static void smethod_9(object object_0, int int_0, int int_1)
			{
				while (true)
				{
					switch (int_1 ^ int_0)
					{
					case 93:
						Monitor.Enter(object_0);
						return;
					}
				}
			}
		}

		internal static void smethod_0(AppDomain appDomain_0, ResolveEventHandler resolveEventHandler_0, int int_0, int int_1)
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 123:
					Class8.smethod_6(appDomain_0, resolveEventHandler_0, 612, 556);
					return;
				}
			}
		}

		internal static string[] smethod_1(int int_0, int int_1)
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 125:
					return smethod_12(387, 500);
				}
			}
		}

		internal static string smethod_2(string string_0, string string_1, int int_0, int int_1)
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 46:
					return smethod_13(string_0, string_1, 193, 246);
				}
			}
		}

		internal static void smethod_3(Thread thread_0, ApartmentState apartmentState_0, int int_0, int int_1)
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 111:
					Class9.Class10.smethod_2(thread_0, apartmentState_0, 326, 369);
					return;
				}
			}
		}

		internal static void smethod_4(Thread thread_0, bool bool_0, int int_0, int int_1)
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 34:
					Class6.smethod_6(thread_0, bool_0, 594, 547);
					return;
				}
			}
		}

		internal static object smethod_5(MethodBase methodBase_0, object object_0, object[] object_1, int int_0, int int_1)
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 39:
					return Class9.Class10.smethod_3(methodBase_0, object_0, object_1, 346, 369);
				}
			}
		}

		internal static void smethod_6(Stream stream_0, byte[] byte_0, int int_0, int int_1, int int_2, int int_3)
		{
			while (true)
			{
				switch (int_3 ^ int_2)
				{
				case 72:
					Class9.smethod_8(stream_0, byte_0, int_0, int_1, 491, 499);
					return;
				}
			}
		}

		internal static void smethod_7(AppDomain appDomain_0, string string_0, object object_0, int int_0, int int_1)
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 37:
					Class6.smethod_7(appDomain_0, string_0, object_0, 834, 873);
					return;
				}
			}
		}

		internal static object smethod_8(AppDomain appDomain_0, string string_0, int int_0, int int_1)
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 91:
					return appDomain_0.GetData(string_0);
				}
			}
		}

		internal static ParameterInfo[] smethod_9(MethodBase methodBase_0, int int_0, int int_1)
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 19:
					return methodBase_0.GetParameters();
				}
			}
		}

		internal static string smethod_10(Exception exception_0, int int_0, int int_1)
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 18:
					return exception_0.Message;
				}
			}
		}

		internal static Evidence smethod_11(Assembly assembly_0, int int_0, int int_1)
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 102:
					return assembly_0.get_Evidence();
				}
			}
		}

		internal static string[] smethod_12(int int_0, int int_1)
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 119:
					return Environment.GetCommandLineArgs();
				}
			}
		}

		internal static string smethod_13(string string_0, string string_1, int int_0, int int_1)
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 55:
					return string_0 + string_1;
				}
			}
		}

		internal static Assembly smethod_14(int int_0, int int_1)
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 121:
					return Assembly.GetExecutingAssembly();
				}
			}
		}
	}

	internal static AppDomain smethod_0(int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 75:
				return Class7.Class9.Class10.smethod_4(497, 406);
			}
		}
	}

	internal static Assembly smethod_1(int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 107:
				return Class7.smethod_14(833, 824);
			}
		}
	}

	internal static MethodInfo smethod_2(Assembly assembly_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 49:
				return Class7.Class9.Class10.smethod_5(assembly_0, 175, 225);
			}
		}
	}

	internal static void smethod_3(Thread thread_0, object object_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 52:
				thread_0.Start(object_0);
				return;
			}
		}
	}

	internal static string smethod_4(ResolveEventArgs resolveEventArgs_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 46:
				return resolveEventArgs_0.Name;
			}
		}
	}

	internal static string[] smethod_5(Assembly assembly_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 16:
				return assembly_0.GetManifestResourceNames();
			}
		}
	}

	internal static void smethod_6(Thread thread_0, bool bool_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 113:
				thread_0.IsBackground = bool_0;
				return;
			}
		}
	}

	internal static void smethod_7(AppDomain appDomain_0, string string_0, object object_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 43:
				appDomain_0.SetData(string_0, object_0);
				return;
			}
		}
	}

	internal static byte[] smethod_8(MemoryStream memoryStream_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 98:
				return memoryStream_0.ToArray();
			}
		}
	}
}
