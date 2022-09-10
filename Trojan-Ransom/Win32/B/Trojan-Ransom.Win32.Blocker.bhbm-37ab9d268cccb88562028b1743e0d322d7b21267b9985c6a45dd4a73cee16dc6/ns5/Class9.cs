using System;
using System.Configuration;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Reflection;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Policy;
using System.Text;
using System.Threading;
using ns2;

namespace ns5;

internal sealed class Class9
{
	internal sealed class Class10
	{
		internal sealed class Class11
		{
			internal static AppDomain smethod_0(int int_0, int int_1)
			{
				while (true)
				{
					switch (int_1 ^ int_0)
					{
					case 65:
						return AppDomain.CurrentDomain;
					case 66:
						return AppDomain.CurrentDomain;
					}
				}
			}

			internal static object smethod_1(AppDomain appDomain_0, string string_0, int int_0, int int_1)
			{
				while (true)
				{
					switch (int_1 ^ int_0)
					{
					case 12:
						return appDomain_0.GetData(string_0);
					case 13:
						return appDomain_0.GetData(string_0);
					}
				}
			}

			internal static void smethod_2(AppDomain appDomain_0, string string_0, object object_0, int int_0, int int_1)
			{
				while (true)
				{
					switch (int_1 ^ int_0)
					{
					case 90:
						appDomain_0.SetData(string_0, object_0);
						return;
					}
				}
			}

			internal static Stream smethod_3(Assembly assembly_0, string string_0, int int_0, int int_1)
			{
				while (true)
				{
					switch (int_1 ^ int_0)
					{
					case 105:
						return assembly_0.GetManifestResourceStream(string_0);
					case 106:
						return assembly_0.GetManifestResourceStream(string_0);
					}
				}
			}

			internal static void smethod_4(Process process_0, int int_0, int int_1)
			{
				while (true)
				{
					switch (int_1 ^ int_0)
					{
					case 31:
						process_0.Close();
						return;
					}
				}
			}

			internal static MethodInfo smethod_5(Assembly assembly_0, int int_0, int int_1)
			{
				while (true)
				{
					switch (int_1 ^ int_0)
					{
					case 21:
						return assembly_0.EntryPoint;
					}
				}
			}

			internal static string[] smethod_6(Assembly assembly_0, int int_0, int int_1)
			{
				while (true)
				{
					switch (int_1 ^ int_0)
					{
					case 109:
						return assembly_0.GetManifestResourceNames();
					}
				}
			}

			internal static int smethod_7(string string_0, string string_1, bool bool_0, int int_0, int int_1)
			{
				while (true)
				{
					switch (int_1 ^ int_0)
					{
					case 76:
						return string.Compare(string_0, string_1, bool_0);
					}
				}
			}

			internal static void smethod_8(object object_0, int int_0, int int_1)
			{
				while (true)
				{
					switch (int_1 ^ int_0)
					{
					case 10:
						Monitor.Enter(object_0);
						return;
					case 11:
						Monitor.Exit(object_0);
						return;
					}
				}
			}

			static Class11()
			{
				Class12.Class13.Class14.smethod_1();
			}
		}

		internal static Assembly smethod_0(int int_0, int int_1)
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 78:
					return Assembly.GetExecutingAssembly();
				case 79:
					return Assembly.GetExecutingAssembly();
				}
			}
		}

		internal static void smethod_1(Array array_0, RuntimeFieldHandle runtimeFieldHandle_0, int int_0, int int_1)
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 11:
					RuntimeHelpers.InitializeArray(array_0, runtimeFieldHandle_0);
					return;
				}
			}
		}

		internal static string smethod_2(Process process_0, int int_0, int int_1)
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 36:
					return process_0.ProcessName;
				}
			}
		}

		internal static GCHandle smethod_3(object object_0, GCHandleType gchandleType_0, int int_0, int int_1)
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 7:
					return GCHandle.Alloc(object_0, gchandleType_0);
				}
			}
		}

		internal static Type smethod_4(RuntimeTypeHandle runtimeTypeHandle_0, int int_0, int int_1)
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 28:
					return Type.GetTypeFromHandle(runtimeTypeHandle_0);
				}
			}
		}

		internal static Assembly smethod_5(byte[] byte_0, int int_0, int int_1)
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 25:
					return Assembly.Load(byte_0);
				}
			}
		}

		internal static string smethod_6(string string_0, char char_0, char char_1, int int_0, int int_1)
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 36:
					return string_0.Replace(char_0, char_1);
				}
			}
		}

		internal static void smethod_7(Thread thread_0, int int_0, int int_1)
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 79:
					thread_0.Start();
					return;
				}
			}
		}

		static Class10()
		{
			Class12.Class13.Class14.smethod_1();
		}
	}

	static Class9()
	{
		Class12.Class13.Class14.smethod_1();
		Class7.smethod_15();
	}

	internal static int smethod_0(Stream stream_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 119:
				return stream_0.ReadByte();
			}
		}
	}

	internal static byte[] smethod_1(MemoryStream memoryStream_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 51:
				return memoryStream_0.ToArray();
			}
		}
	}

	internal static Evidence smethod_2(Assembly assembly_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 91:
				return assembly_0.get_Evidence();
			}
		}
	}

	internal static void smethod_3(AppDomain appDomain_0, string string_0, object object_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 23:
				appDomain_0.SetData(string_0, object_0);
				return;
			}
		}
	}

	internal static object smethod_4(IntPtr intptr_0, Type type_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 104:
				return Marshal.PtrToStructure(intptr_0, type_0);
			}
		}
	}

	internal static Encoding smethod_5(int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 2:
				return Encoding.UTF8;
			}
		}
	}

	internal static Process smethod_6(int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 45:
				return Process.GetCurrentProcess();
			}
		}
	}

	internal static ParameterInfo[] smethod_7(MethodBase methodBase_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 84:
				return methodBase_0.GetParameters();
			}
		}
	}

	internal static object smethod_8(ResourceManager resourceManager_0, string string_0, CultureInfo cultureInfo_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 107:
				return resourceManager_0.GetObject(string_0, cultureInfo_0);
			}
		}
	}

	internal static string[] smethod_9(string string_0, char[] char_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 64:
				return string_0.Split(char_0);
			}
		}
	}

	internal static Assembly smethod_10(Type type_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 1:
				return type_0.Assembly;
			}
		}
	}

	internal static void smethod_11(ref GCHandle gchandle_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 5:
				gchandle_0.Free();
				return;
			}
		}
	}

	internal static SettingsBase smethod_12(SettingsBase settingsBase_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 75:
				return SettingsBase.Synchronized(settingsBase_0);
			}
		}
	}

	internal static int smethod_13(Type type_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 49:
				return Marshal.SizeOf(type_0);
			}
		}
	}

	internal static string smethod_14(AssemblyName assemblyName_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 47:
				return assemblyName_0.Name;
			}
		}
	}
}
