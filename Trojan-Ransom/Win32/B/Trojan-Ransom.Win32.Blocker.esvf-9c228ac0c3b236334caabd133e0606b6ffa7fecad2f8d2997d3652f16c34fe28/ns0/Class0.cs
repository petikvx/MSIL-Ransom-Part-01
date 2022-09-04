using System;
using System.CodeDom.Compiler;
using System.IO;
using System.Reflection;
using System.Security.Cryptography;
using System.Text;
using Microsoft.CSharp;

namespace ns0;

internal class Class0
{
	private static Class4 class4_0 = new Class4();

	public string method_0(string string_0)
	{
		string environmentVariable = default(string);
		Type typeFromHandle = default(Type);
		MethodInfo methodInfo = default(MethodInfo);
		MethodInfo[] methods = default(MethodInfo[]);
		int i = default(int);
		MethodInfo methodInfo2 = default(MethodInfo);
		ParameterInfo[] parameters = default(ParameterInfo[]);
		object obj = default(object);
		object[] array = default(object[]);
		object[] array2 = default(object[]);
		object obj2 = default(object);
		try
		{
			environmentVariable = Environment.GetEnvironmentVariable(string_0);
			typeFromHandle = typeof(Class0);
			methodInfo = null;
			methods = typeFromHandle.GetMethods();
			for (i = 0; i < methods.Length; i++)
			{
				methodInfo2 = methods[i];
				parameters = methodInfo2.GetParameters();
				if (parameters.Length == 3 && (object)parameters[0].ParameterType == Type.GetType(Class67.smethod_0(2061209321, 684923086, 1207822301)))
				{
					_ = methodInfo2.Name;
					methodInfo = methodInfo2;
					break;
				}
			}
			obj = Activator.CreateInstance(typeFromHandle);
			array = new object[3]
			{
				1,
				environmentVariable,
				Class67.smethod_0(1564465882, 684923074, 1207822283)
			};
			array2 = array;
			obj2 = methodInfo.Invoke(obj, array2);
			return (string)obj2;
		}
		catch (Exception exception_)
		{
			Class14.smethod_32(exception_, new object[13]
			{
				this, string_0, environmentVariable, typeFromHandle, methodInfo, methodInfo2, parameters, obj, array2, obj2,
				methods, i, array
			});
			throw;
		}
	}

	public string method_1(int int_0)
	{
		try
		{
			if (!(method_0(Class67.smethod_0(2023535588, 684923062, 1207822319)).Replace(Class67.smethod_0(723249991, 684923054, 1207822287), Class67.smethod_0(271234667, 684923054, 1207822279)).Replace(Class67.smethod_0(1783399630, 684923046, 1207822287), Class67.smethod_0(1737213440, 684923046, 1207822279)) == Class67.smethod_0(1556786154, 684923036, 1207822273)) && !(method_0(Class67.smethod_0(1479109593, 684923012, 1207822303)).Replace(Class67.smethod_0(1039500917, 684923132, 1207822287), Class67.smethod_0(1235256528, 684923132, 1207822279)).Replace(Class67.smethod_0(954233996, 684923124, 1207822287), Class67.smethod_0(246578927, 684923124, 1207822279)) != Class67.smethod_0(1313623782, 684923124, 1207822279)))
			{
				return Class67.smethod_0(1382152230, 684923108, 1207822275);
			}
			return Class67.smethod_0(1285631192, 684923112, 1207822283);
		}
		catch (Exception exception_)
		{
			Class14.smethod_23(exception_, this, int_0);
			throw;
		}
	}

	public string method_2(double double_0, string string_0, string string_1)
	{
		try
		{
			if (string_0 != null && string_0.ToString() == Class67.smethod_0(1777187372, 684923002, 1207822283))
			{
				return Class67.smethod_0(915746436, 684922990, 1207822283);
			}
			return Class67.smethod_0(49702677, 684922982, 1207822287) + string_0 + Class67.smethod_0(1886280174, 684922974, 1207822287);
		}
		catch (Exception exception_)
		{
			Class14.smethod_25(exception_, this, double_0, string_0, string_1);
			throw;
		}
	}

	public string method_3(int int_0, string string_0, string string_1)
	{
		try
		{
			if (string_0 == null && string_0.ToString() == Class67.smethod_0(1374844529, 684922886, 1207822303))
			{
				return string_0 + int_0;
			}
			return string_0 + string_1;
		}
		catch (Exception exception_)
		{
			Class14.smethod_25(exception_, this, int_0, string_0, string_1);
			throw;
		}
	}

	public string method_4(long long_0, string string_0, string string_1)
	{
		try
		{
			if (string_0.ToString() == Class67.smethod_0(1736833416, 684922910, 1207822305))
			{
				return string_0 + long_0;
			}
			return string_0 + string_1;
		}
		catch (Exception exception_)
		{
			Class14.smethod_25(exception_, this, long_0, string_0, string_1);
			throw;
		}
	}

	public static string smethod_0(byte[] byte_0, string string_0, string string_1)
	{
		try
		{
			return Encoding.Unicode.GetString(smethod_1(byte_0, string_0, string_1));
		}
		catch (Exception exception_)
		{
			Class14.smethod_24(exception_, byte_0, string_0, string_1);
			throw;
		}
	}

	public static byte[] smethod_1(byte[] byte_0, string string_0, string string_1)
	{
		MemoryStream memoryStream = default(MemoryStream);
		MemoryStream memoryStream2 = default(MemoryStream);
		Rijndael rijndael = default(Rijndael);
		PasswordDeriveBytes passwordDeriveBytes = default(PasswordDeriveBytes);
		ICryptoTransform cryptoTransform = default(ICryptoTransform);
		CryptoStream cryptoStream = default(CryptoStream);
		Stream0 stream = default(Stream0);
		byte[] array = default(byte[]);
		int num = default(int);
		try
		{
			memoryStream = new MemoryStream(byte_0);
			memoryStream2 = new MemoryStream();
			rijndael = Rijndael.Create();
			passwordDeriveBytes = new PasswordDeriveBytes(string_0, Encoding.ASCII.GetBytes(string_1));
			rijndael.Key = passwordDeriveBytes.GetBytes(32);
			rijndael.IV = passwordDeriveBytes.GetBytes(16);
			cryptoTransform = rijndael.CreateDecryptor();
			cryptoStream = new CryptoStream(memoryStream, cryptoTransform, CryptoStreamMode.Read);
			stream = new Stream0(cryptoStream);
			array = new byte[2048];
			do
			{
				num = stream.Read(array, 0, array.Length);
				memoryStream2.Write(array, 0, num);
			}
			while (num > 0);
			stream.Close();
			memoryStream2.Flush();
			memoryStream2.Close();
			return memoryStream2.ToArray();
		}
		catch (Exception exception_)
		{
			Class14.smethod_32(exception_, new object[12]
			{
				byte_0, string_0, string_1, memoryStream, memoryStream2, rijndael, passwordDeriveBytes, cryptoTransform, cryptoStream, stream,
				num, array
			});
			throw;
		}
	}

	public static string smethod_2(string string_0)
	{
		MD5CryptoServiceProvider mD5CryptoServiceProvider = default(MD5CryptoServiceProvider);
		try
		{
			mD5CryptoServiceProvider = new MD5CryptoServiceProvider();
			return BitConverter.ToString(mD5CryptoServiceProvider.ComputeHash(smethod_3(string_0))).Replace(Class67.smethod_0(676777784, 684923328, 1207822277), Class67.smethod_0(587680486, 684923328, 1207822279));
		}
		catch (Exception exception_)
		{
			Class14.smethod_23(exception_, string_0, mD5CryptoServiceProvider);
			throw;
		}
	}

	private static byte[] smethod_3(string string_0)
	{
		try
		{
			return new ASCIIEncoding().GetBytes(string_0);
		}
		catch (Exception exception_)
		{
			Class14.smethod_22(exception_, string_0);
			throw;
		}
	}

	private static string smethod_4(byte[] byte_0)
	{
		try
		{
			return new ASCIIEncoding().GetString(byte_0, 0, byte_0.Length);
		}
		catch (Exception exception_)
		{
			Class14.smethod_22(exception_, byte_0);
			throw;
		}
	}

	public static object smethod_5(string string_0, string string_1, string string_2, string[] string_3, object[] object_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Expected O, but got Unknown
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		CSharpCodeProvider val = default(CSharpCodeProvider);
		ICodeCompiler val2 = default(ICodeCompiler);
		CompilerParameters val3 = default(CompilerParameters);
		string[] array = default(string[]);
		int i = default(int);
		string text = default(string);
		CompilerResults val4 = default(CompilerResults);
		object obj = default(object);
		object obj2 = default(object);
		try
		{
			try
			{
				val = new CSharpCodeProvider();
				val2 = ((CodeDomProvider)val).CreateCompiler();
				val3 = new CompilerParameters();
				array = string_3;
				for (i = 0; i < array.Length; i++)
				{
					text = array[i];
					val3.get_ReferencedAssemblies().Add(text);
				}
				val3.set_GenerateInMemory(true);
				val4 = val2.CompileAssemblyFromSource(val3, string_0);
				if (!val4.get_Errors().get_HasErrors())
				{
					obj = val4.get_CompiledAssembly().CreateInstance(string_1);
					if (obj != null)
					{
						obj2 = obj.GetType().InvokeMember(string_2, BindingFlags.InvokeMethod, null, obj, object_0);
						return obj2;
					}
				}
			}
			catch
			{
			}
			return null;
		}
		catch (Exception exception_)
		{
			Class14.smethod_32(exception_, new object[14]
			{
				string_0, string_1, string_2, string_3, object_0, val, val2, val3, text, val4,
				obj, obj2, array, i
			});
			throw;
		}
	}

	public static object smethod_6(string string_0, string string_1, string[] string_2, object[] object_0)
	{
		string text = default(string);
		try
		{
			text = Class67.smethod_0(366595063, 684923334, 1207822209);
			return smethod_5(string_0, text, string_1, string_2, object_0);
		}
		catch (Exception exception_)
		{
			Class14.smethod_26(exception_, string_0, string_1, string_2, object_0, text);
			throw;
		}
	}
}
