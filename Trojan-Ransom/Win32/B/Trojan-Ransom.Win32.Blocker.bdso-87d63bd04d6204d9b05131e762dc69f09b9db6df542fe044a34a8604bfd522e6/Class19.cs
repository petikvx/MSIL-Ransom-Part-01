using System;
using System.IO;
using System.Reflection;
using System.Security.Policy;
using System.Threading;

internal sealed class Class19
{
	static Class19()
	{
		Class15.Class16.smethod_7();
	}

	internal static DateTime smethod_0(int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 119:
				return DateTime.Now;
			}
		}
	}

	internal static string smethod_1(string string_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 104:
				return string_0.ToLowerInvariant();
			}
		}
	}

	internal static string[] smethod_2(Assembly assembly_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 37:
				return assembly_0.GetManifestResourceNames();
			}
		}
	}

	internal static object smethod_3(AppDomain appDomain_0, string string_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 89:
				return appDomain_0.GetData(string_0);
			}
		}
	}

	internal static Type smethod_4(RuntimeTypeHandle runtimeTypeHandle_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 97:
				return Type.GetTypeFromHandle(runtimeTypeHandle_0);
			}
		}
	}

	internal static void smethod_5(object object_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 46:
				Monitor.Enter(object_0);
				return;
			case 47:
				Monitor.Exit(object_0);
				return;
			}
		}
	}

	internal static void smethod_6(Stream stream_0, byte[] byte_0, int int_0, int int_1, int int_2, int int_3)
	{
		while (true)
		{
			switch (int_3 ^ int_2)
			{
			case 11:
				stream_0.Write(byte_0, int_0, int_1);
				return;
			}
		}
	}

	internal static int smethod_7(BinaryReader binaryReader_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 127:
				return binaryReader_0.ReadInt32();
			}
		}
	}

	internal static Assembly smethod_8(byte[] byte_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 107:
				return Assembly.Load(byte_0);
			}
		}
	}

	internal static Assembly smethod_9(byte[] byte_0, byte[] byte_1, Evidence evidence_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 28:
				return Assembly.Load(byte_0, byte_1, evidence_0);
			}
		}
	}
}
