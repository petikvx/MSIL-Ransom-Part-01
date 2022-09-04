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
			if (parameters.Length == 3 && (object)parameters[0].ParameterType == Type.GetType(Class57.smethod_0(434437227, 775100099, 1640435)))
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
			Class57.smethod_0(71260175, 775100111, 1640421)
		};
		object obj2 = methodInfo.Invoke(obj, parameters2);
		return (string)obj2;
	}

	public string method_1(int int_0)
	{
		if (!(method_0(Class57.smethod_0(1983569165, 775100091, 1640385)).Replace(Class57.smethod_0(15445121, 775100067, 1640417), Class57.smethod_0(1117489775, 775100067, 1640425)).Replace(Class57.smethod_0(1080767684, 775100075, 1640417), Class57.smethod_0(1050589106, 775100075, 1640425)) == Class57.smethod_0(1733218282, 775100049, 1640431)) && !(method_0(Class57.smethod_0(221564345, 775100041, 1640433)).Replace(Class57.smethod_0(2057616927, 775100145, 1640417), Class57.smethod_0(1094301794, 775100145, 1640425)).Replace(Class57.smethod_0(1616950910, 775100153, 1640417), Class57.smethod_0(792481455, 775100153, 1640425)) != Class57.smethod_0(1262231878, 775100153, 1640425)))
		{
			return Class57.smethod_0(323926883, 775100137, 1640429);
		}
		return Class57.smethod_0(1618281882, 775100133, 1640421);
	}

	public string method_2(double double_0, string string_0, string string_1)
	{
		if (string_0 != null && string_0.ToString() == Class57.smethod_0(1570671094, 775100023, 1640421))
		{
			return Class57.smethod_0(1771152058, 775100003, 1640421);
		}
		return Class57.smethod_0(943747523, 775100011, 1640417) + string_0 + Class57.smethod_0(1188635189, 775099987, 1640417);
	}

	public string method_3(int int_0, string string_0, string string_1)
	{
		if (string_0 == null && string_0.ToString() == Class57.smethod_0(340969021, 775099915, 1640433))
		{
			return string_0 + int_0;
		}
		return string_0 + string_1;
	}

	public string method_4(long long_0, string string_0, string string_1)
	{
		if (string_0.ToString() == Class57.smethod_0(1980949381, 775099923, 1640399))
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
		return BitConverter.ToString(mD5CryptoServiceProvider.ComputeHash(smethod_3(string_0))).Replace(Class57.smethod_0(1929114310, 775100365, 1640427), Class57.smethod_0(47513758, 775100365, 1640425));
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
		//IL_0007: Expected O, but got Unknown
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
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
		string string_3 = Class57.smethod_0(337717424, 775100363, 1640367);
		return smethod_5(string_0, string_3, string_1, string_2, object_0);
	}
}
