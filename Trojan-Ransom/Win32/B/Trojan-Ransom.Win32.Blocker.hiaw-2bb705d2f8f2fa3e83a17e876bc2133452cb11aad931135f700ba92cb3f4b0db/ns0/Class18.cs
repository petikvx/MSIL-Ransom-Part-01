using System;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Resources;
using System.Text;
using System.Threading;

namespace ns0;

internal sealed class Class18
{
	internal sealed class Class19
	{
		internal static object smethod_0(AppDomain appDomain_0, string string_0, int int_0, int int_1)
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 9:
					return appDomain_0.GetData(string_0);
				case 10:
					return appDomain_0.GetData(string_0);
				}
			}
		}

		internal static bool smethod_1(string string_0, string string_1, int int_0, int int_1)
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 20:
					return string_0.Contains(string_1);
				}
			}
		}

		internal static object smethod_2(ResourceManager resourceManager_0, string string_0, int int_0, int int_1)
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 18:
					return resourceManager_0.GetObject(string_0);
				}
			}
		}

		internal static string[] smethod_3(Assembly assembly_0, int int_0, int int_1)
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 18:
					return assembly_0.GetManifestResourceNames();
				}
			}
		}
	}

	static Class18()
	{
		Class15.smethod_6();
	}

	internal static string smethod_0(object object_0, object object_1, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 10:
				return string.Concat(object_0, object_1);
			case 11:
				return string.Concat(object_0, object_1);
			}
		}
	}

	internal static void smethod_1(AppDomain appDomain_0, string string_0, object object_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 98:
				appDomain_0.SetData(string_0, object_0);
				return;
			case 99:
				appDomain_0.SetData(string_0, object_0);
				return;
			}
		}
	}

	internal static string smethod_2(int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 107:
				return Path.GetTempPath();
			}
		}
	}

	internal static Assembly smethod_3(byte[] byte_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 55:
				return Assembly.Load(byte_0);
			}
		}
	}

	internal static void smethod_4(ResourceManager resourceManager_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 69:
				resourceManager_0.ReleaseAllResources();
				return;
			}
		}
	}

	internal static Process smethod_5(string string_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 7:
				return Process.Start(string_0);
			}
		}
	}

	internal static void smethod_6(object object_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 76:
				Monitor.Enter(object_0);
				return;
			case 77:
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
			case 31:
				return methodBase_0.Invoke(object_0, object_1);
			}
		}
	}

	internal static byte[] smethod_8(Encoding encoding_0, string string_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 15:
				return encoding_0.GetBytes(string_0);
			}
		}
	}
}
