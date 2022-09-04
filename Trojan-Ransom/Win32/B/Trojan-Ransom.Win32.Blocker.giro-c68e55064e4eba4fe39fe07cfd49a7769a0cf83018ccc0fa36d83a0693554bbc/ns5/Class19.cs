using System;
using System.IO;
using System.Reflection;
using System.Security.Cryptography;

namespace ns5;

internal class Class19
{
	internal static Assembly smethod_0(byte[] byte_0, int int_0)
	{
		return (int_0 ^ 0x9D74) switch
		{
			_ => Assembly.Load(byte_0), 
		};
	}

	internal static ParameterInfo[] smethod_1(MethodBase methodBase_0, int int_0)
	{
		return (int_0 ^ 0xAD55) switch
		{
			_ => methodBase_0.GetParameters(), 
		};
	}

	internal static int smethod_2(BinaryReader binaryReader_0, byte[] byte_0, int int_0, int int_1, int int_2)
	{
		return (int_2 ^ 0x109C) switch
		{
			_ => binaryReader_0.Read(byte_0, int_0, int_1), 
		};
	}

	internal static string smethod_3(string string_0, string string_1, string string_2, string string_3, int int_0)
	{
		return (int_0 ^ 0xE637) switch
		{
			_ => string_0 + string_1 + string_2 + string_3, 
		};
	}

	internal static AppDomain smethod_4(int int_0)
	{
		return (int_0 ^ 0x1577) switch
		{
			_ => AppDomain.CurrentDomain, 
		};
	}

	internal static void smethod_5(AppDomain appDomain_0, ResolveEventHandler resolveEventHandler_0, int int_0)
	{
		switch (int_0 ^ 0x920A)
		{
		default:
			appDomain_0.ResourceResolve += resolveEventHandler_0;
			break;
		case 1:
			appDomain_0.AssemblyResolve += resolveEventHandler_0;
			break;
		}
	}

	internal static bool smethod_6(Assembly assembly_0, Assembly assembly_1, int int_0)
	{
		return (int_0 ^ 0xE24D) switch
		{
			_ => assembly_0 == assembly_1, 
		};
	}

	internal static string[] smethod_7(Assembly assembly_0, int int_0)
	{
		return (int_0 ^ 0xB817) switch
		{
			_ => assembly_0.GetManifestResourceNames(), 
		};
	}

	internal static string smethod_8(ResolveEventArgs resolveEventArgs_0, int int_0)
	{
		return (int_0 ^ 0xEBD3) switch
		{
			_ => resolveEventArgs_0.Name, 
		};
	}

	internal static string smethod_9(string string_0, int int_0)
	{
		return (int_0 ^ 0x5F77) switch
		{
			_ => string_0.Trim(), 
		};
	}

	internal static int smethod_10(string string_0, string string_1, int int_0)
	{
		return (int_0 ^ 0x6D7E) switch
		{
			_ => string_0.IndexOf(string_1), 
		};
	}

	internal static string smethod_11(string string_0, int int_0, int int_1, int int_2)
	{
		return (int_2 ^ 0x90C4) switch
		{
			_ => string_0.Substring(int_0, int_1), 
		};
	}

	internal static string smethod_12(string string_0, string string_1, int int_0)
	{
		return (int_0 ^ 0x96D2) switch
		{
			_ => string_0 + string_1, 
		};
	}

	internal static long smethod_13(Stream stream_0, long long_0, SeekOrigin seekOrigin_0, int int_0)
	{
		return (int_0 ^ 0xDF89) switch
		{
			_ => stream_0.Seek(long_0, seekOrigin_0), 
		};
	}

	internal static int smethod_14(Stream stream_0, byte[] byte_0, int int_0, int int_1, int int_2)
	{
		return (int_2 ^ 0x2817) switch
		{
			_ => stream_0.Read(byte_0, int_0, int_1), 
		};
	}

	internal static byte[] smethod_15(MemoryStream memoryStream_0, int int_0)
	{
		return (int_0 ^ 0x8821) switch
		{
			_ => memoryStream_0.ToArray(), 
		};
	}

	internal static Rijndael smethod_16(int int_0)
	{
		return (int_0 ^ 0x125E) switch
		{
			_ => Rijndael.Create(), 
		};
	}

	internal static byte[] smethod_17(DeriveBytes deriveBytes_0, int int_0, int int_1)
	{
		return (int_1 ^ 0xA39F) switch
		{
			_ => deriveBytes_0.GetBytes(int_0), 
		};
	}

	internal static void smethod_18(SymmetricAlgorithm symmetricAlgorithm_0, byte[] byte_0, int int_0)
	{
		switch (int_0 ^ 0x22EB)
		{
		}
		symmetricAlgorithm_0.Key = byte_0;
	}

	internal static void smethod_19(SymmetricAlgorithm symmetricAlgorithm_0, byte[] byte_0, int int_0)
	{
		switch (int_0 ^ 0x4EE0)
		{
		}
		symmetricAlgorithm_0.IV = byte_0;
	}
}
