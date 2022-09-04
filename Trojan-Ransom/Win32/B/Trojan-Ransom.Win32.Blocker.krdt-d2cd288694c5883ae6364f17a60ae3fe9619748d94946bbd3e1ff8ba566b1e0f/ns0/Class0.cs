using System;
using System.CodeDom.Compiler;
using System.IO;
using System.Reflection;
using System.Security.Cryptography;
using System.Text;
using Microsoft.CSharp;
using ns6;
using ns7;

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
			if (parameters.Length == 3 && (object)parameters[0].ParameterType == Type.GetType(Class56.smethod_0(1077265647, 405211290, 927627461)))
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
			Class56.smethod_0(2058507068, 405211286, 927627475)
		};
		object obj2 = methodInfo.Invoke(obj, parameters2);
		return (string)obj2;
	}

	public string method_1(int int_0)
	{
		if (!(method_0(Class56.smethod_0(735391316, 405211362, 927627511)).Replace(Class56.smethod_0(1281656519, 405211386, 927627479), Class56.smethod_0(2074114764, 405211386, 927627487)).Replace(Class56.smethod_0(229513911, 405211378, 927627479), Class56.smethod_0(439353371, 405211378, 927627487)) == Class56.smethod_0(1837611600, 405211336, 927627481)) && !(method_0(Class56.smethod_0(1256709435, 405211344, 927627463)).Replace(Class56.smethod_0(1799491470, 405211304, 927627479), Class56.smethod_0(404930289, 405211304, 927627487)).Replace(Class56.smethod_0(1367153447, 405211296, 927627479), Class56.smethod_0(919246618, 405211296, 927627487)) != Class56.smethod_0(1057335940, 405211296, 927627487)))
		{
			return Class56.smethod_0(2121197586, 405211312, 927627483);
		}
		return Class56.smethod_0(545871953, 405211324, 927627475);
	}

	public string method_2(double double_0, string string_0, string string_1)
	{
		if (string_0 != null && string_0.ToString() == Class56.smethod_0(769683606, 405211182, 927627475))
		{
			return Class56.smethod_0(143767901, 405211194, 927627475);
		}
		return Class56.smethod_0(627301496, 405211186, 927627479) + string_0 + Class56.smethod_0(732887810, 405211146, 927627479);
	}

	public string method_3(int int_0, string string_0, string string_1)
	{
		if (string_0 == null && string_0.ToString() == Class56.smethod_0(1113243669, 405211218, 927627463))
		{
			return string_0 + int_0;
		}
		return string_0 + string_1;
	}

	public string method_4(long long_0, string string_0, string string_1)
	{
		if (string_0.ToString() == Class56.smethod_0(1601642732, 405211210, 927627513))
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
		return BitConverter.ToString(mD5CryptoServiceProvider.ComputeHash(smethod_3(string_0))).Replace(Class56.smethod_0(338589523, 405211540, 927627485), Class56.smethod_0(869422759, 405211540, 927627487));
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
		string string_3 = Class56.smethod_0(1263440617, 405211538, 927627417);
		return smethod_5(string_0, string_3, string_1, string_2, object_0);
	}
}
