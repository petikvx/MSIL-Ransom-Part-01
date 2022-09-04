using System;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;
using ns0;
using ns1;
using ns3;
using ns4;
using ns5;
using ns6;

namespace ns2;

internal class Class7
{
	private static Assembly assembly_0 = null;

	private static bool bool_0 = false;

	private static bool bool_1 = false;

	private static bool bool_2 = false;

	private static byte[] byte_0 = null;

	internal static string string_0 = "";

	private static Assembly assembly_1 = null;

	private static readonly byte[] byte_1;

	[CompilerGenerated]
	private static string string_1;

	internal static string String_0
	{
		[CompilerGenerated]
		get
		{
			return string_1;
		}
		[CompilerGenerated]
		set
		{
			string_1 = value;
		}
	}

	internal static void smethod_0(string[] string_2)
	{
		//IL_0118: Unknown result type (might be due to invalid IL or missing references)
		String_0 = "";
		foreach (string text in string_2)
		{
			if (Class18.smethod_4(text, "-pwd=", 38761))
			{
				String_0 = Class18.smethod_13(text, 5, 20889);
			}
		}
		smethod_4();
		smethod_2();
		Stream stream = Class18.smethod_15(Class18.smethod_14(16455), "c", 21202);
		BinaryReader binaryReader_ = new BinaryReader(stream);
		byte[] array = new byte[Class18.smethod_1(stream, 18515)];
		bool_1 = Class18.smethod_16(binaryReader_, 39369);
		bool_0 = Class18.smethod_16(binaryReader_, 39369);
		bool_2 = Class18.smethod_16(binaryReader_, 39369);
		if (bool_2 || bool_0)
		{
			string_0 = Class18.smethod_8(Class18.smethod_6(59429), Class18.smethod_7(binaryReader_, array.Length - 3, 1732), 9886);
		}
		if (bool_2 && Class18.smethod_5(String_0, "", 24791))
		{
			PwdFrm form_ = new PwdFrm();
			Class18.smethod_12((Form)(object)form_, 4970);
			if (Class18.smethod_5(String_0, "", 24790))
			{
				Class18.smethod_11(Class18.smethod_9(26678), Class18.smethod_10(smethod_1(string_2), "-pwd=", String_0, 34121), 53271);
			}
			return;
		}
		if (Class18.smethod_5(String_0, "", 24790))
		{
			MD5 mD = Class18.smethod_17(47608);
			try
			{
				if (!smethod_8(mD, String_0, string_0))
				{
					return;
				}
			}
			finally
			{
				if (mD != null)
				{
					Class17.smethod_7(mD, 15717);
				}
			}
		}
		Class0.smethod_0();
		Stream stream2 = Class18.smethod_15(Class18.smethod_14(16455), "p", 21202);
		BinaryReader binaryReader_2 = new BinaryReader(stream2);
		byte_0 = new byte[Class18.smethod_1(stream2, 18515)];
		Class19.smethod_2(binaryReader_2, byte_0, 0, byte_0.Length, 4252);
		if (bool_0 && !bool_2)
		{
			byte_0 = smethod_7(byte_0, string_0);
		}
		if (bool_2 && Class18.smethod_5(String_0, "", 24790))
		{
			byte_0 = smethod_7(byte_0, String_0);
		}
		if (bool_1)
		{
			byte_0 = smethod_6(byte_0);
		}
		assembly_0 = Class19.smethod_0(byte_0, 40308);
		if (Class19.smethod_1(Class18.smethod_18(assembly_0, 50206), 44373).Length == 0)
		{
			Class18.smethod_19(Class18.smethod_18(assembly_0, 50206), null, null, 45032);
			return;
		}
		string[] array2 = new string[0];
		if (Class18.smethod_5(String_0, "", 24790) && string_2.Length > 0)
		{
			array2 = new string[string_2.Length - 1];
			int num = 0;
			for (int j = 0; j < string_2.Length - 1; j++)
			{
				if (!Class18.smethod_4(string_2[j], "-pwd=", 38761))
				{
					array2[num] = string_2[j];
					num++;
				}
			}
			Class18.smethod_19(Class18.smethod_18(assembly_0, 50206), null, new object[1] { array2 }, 45032);
		}
		else
		{
			Class18.smethod_19(Class18.smethod_18(assembly_0, 50206), null, new object[1] { string_2 }, 45032);
		}
	}

	private static string smethod_1(string[] string_2)
	{
		string result = "";
		foreach (string string_3 in string_2)
		{
			result = Class19.smethod_3(result, "\"", string_3, "\" ", 58935);
		}
		return result;
	}

	public static void smethod_2()
	{
		AppDomain appDomain_ = Class19.smethod_4(5495);
		Class19.smethod_5(appDomain_, smethod_3, 37386);
	}

	internal static Assembly smethod_3(object object_0, ResolveEventArgs resolveEventArgs_0)
	{
		if (Class19.smethod_6(assembly_1, null, 57933))
		{
			Stream stream = Class18.smethod_15(Class18.smethod_14(16455), "dbrsrc", 21202);
			BinaryReader binaryReader_ = new BinaryReader(stream);
			byte[] array = new byte[Class18.smethod_1(stream, 18515)];
			Class19.smethod_2(binaryReader_, array, 0, array.Length, 4252);
			assembly_1 = Class19.smethod_0(smethod_6(smethod_7(array, "399eGcVPQb0nPJws")), 40308);
		}
		string[] array2 = Class19.smethod_7(assembly_1, 47127);
		string[] array3 = array2;
		int num = 0;
		while (true)
		{
			if (num < array3.Length)
			{
				string text = array3[num];
				if (Class18.smethod_5(text, Class19.smethod_8(resolveEventArgs_0, 60371), 24791))
				{
					break;
				}
				num++;
				continue;
			}
			if (byte_0 == null)
			{
				return null;
			}
			Assembly result = Class19.smethod_0(byte_0, 40308);
			array2 = Class19.smethod_7(result, 47127);
			string[] array4 = array2;
			int num2 = 0;
			while (true)
			{
				if (num2 < array4.Length)
				{
					string text2 = array4[num2];
					if (Class18.smethod_5(text2, Class19.smethod_8(resolveEventArgs_0, 60371), 24791))
					{
						break;
					}
					num2++;
					continue;
				}
				return null;
			}
			return result;
		}
		return assembly_1;
	}

	private static void smethod_4()
	{
		AppDomain appDomain_ = Class19.smethod_4(5495);
		Class19.smethod_5(appDomain_, smethod_5, 37387);
	}

	private static Assembly smethod_5(object object_0, ResolveEventArgs resolveEventArgs_0)
	{
		try
		{
			string text = Class19.smethod_11(Class19.smethod_8(resolveEventArgs_0, 60371), 0, Class19.smethod_10(Class19.smethod_9(Class19.smethod_8(resolveEventArgs_0, 60371), 24439), ",", 28030), 37060);
			text = Class19.smethod_12(text, ".dll", 38610);
			Stream stream = Class18.smethod_15(Class18.smethod_14(16455), text, 21202);
			if (stream != null)
			{
				BinaryReader binaryReader_ = new BinaryReader(stream);
				byte[] array = new byte[Class18.smethod_1(stream, 18515)];
				Class19.smethod_2(binaryReader_, array, 0, array.Length, 4252);
				if (bool_0 && !bool_2)
				{
					array = smethod_7(array, string_0);
				}
				if (bool_2 && Class18.smethod_5(String_0, "", 24790))
				{
					array = smethod_7(array, String_0);
				}
				if (bool_1)
				{
					array = smethod_6(array);
				}
				assembly_0 = Class19.smethod_0(array, 40308);
				return assembly_0;
			}
			return null;
		}
		catch
		{
			return null;
		}
	}

	public static byte[] smethod_6(byte[] byte_2)
	{
		MemoryStream stream_ = new MemoryStream(byte_2);
		GClass0 gClass = new GClass0();
		Class19.smethod_13(stream_, 0L, SeekOrigin.Begin, 57225);
		MemoryStream memoryStream = new MemoryStream();
		byte[] array = new byte[5];
		if (Class19.smethod_14(stream_, array, 0, 5, 10263) != 5)
		{
			throw new Exception("input .lzma is too short");
		}
		long num = 0L;
		for (int i = 0; i < 8; i++)
		{
			int num2 = Class17.smethod_19(stream_, 39689);
			if (num2 >= 0)
			{
				num |= (long)((ulong)(byte)num2 << 8 * i);
				continue;
			}
			throw new Exception("Can't Read 1");
		}
		gClass.imethod_1(array);
		long long_ = Class18.smethod_1(stream_, 18515) - Class18.smethod_1(stream_, 18514);
		gClass.imethod_0(stream_, memoryStream, long_, num, null);
		return Class19.smethod_15(memoryStream, 34849);
	}

	public static byte[] smethod_7(byte[] byte_2, string string_2)
	{
		Rijndael symmetricAlgorithm_ = Class19.smethod_16(4702);
		Rfc2898DeriveBytes deriveBytes_ = new Rfc2898DeriveBytes(string_2, byte_1);
		Class19.smethod_18(symmetricAlgorithm_, Class19.smethod_17(deriveBytes_, 32, 41887), 8939);
		Class19.smethod_19(symmetricAlgorithm_, Class19.smethod_17(deriveBytes_, 16, 41887), 20192);
		MemoryStream memoryStream = new MemoryStream();
		CryptoStream stream_ = new CryptoStream(memoryStream, Class20.smethod_0(symmetricAlgorithm_, 56251), CryptoStreamMode.Write);
		Class18.smethod_0(stream_, byte_2, 0, byte_2.Length, 18525);
		Class18.smethod_2(stream_, 35274);
		return Class19.smethod_15(memoryStream, 34849);
	}

	internal static bool smethod_8(MD5 md5_0, string string_2, string string_3)
	{
		string text = smethod_9(md5_0, string_2);
		StringComparer stringComparer_ = Class20.smethod_1(31261);
		if (Class20.smethod_2(stringComparer_, text, string_3, 5830) == 0)
		{
			return true;
		}
		return false;
	}

	internal static string smethod_9(MD5 md5_0, string string_2)
	{
		byte[] array = Class20.smethod_4(md5_0, Class20.smethod_3(Class18.smethod_6(59429), string_2, 14168), 40890);
		StringBuilder stringBuilder = new StringBuilder();
		for (int i = 0; i < array.Length; i++)
		{
			Class20.smethod_5(stringBuilder, array[i].ToString("x2"), 20318);
		}
		return Class20.smethod_6(stringBuilder, 53051);
	}

	static Class7()
	{
		byte[] array_ = new byte[16];
		Class20.smethod_7(array_, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/, 2863);
		byte_1 = array_;
	}
}
