using System;
using System.IO;
using System.Reflection;
using System.Security.Cryptography;
using System.Text;
using Microsoft.VisualBasic.CompilerServices;

[StandardModule]
internal sealed class Class18
{
	public static string string_0 = "522D4B77-C8AA-4E06-9D54-CF406F661572";

	public static Type smethod_0(byte[] byte_0, Type[] type_0, Type[] type_1)
	{
		Assembly assembly = Assembly.Load(byte_0);
		Type[] types = assembly.GetTypes();
		foreach (Type type in types)
		{
			Type[] interfaces = type.GetInterfaces();
			foreach (Type value in interfaces)
			{
				if (Array.IndexOf(type_0, value) != -1)
				{
					return type;
				}
			}
			ConstructorInfo[] constructors = type.GetConstructors();
			if (constructors.Length != 1)
			{
				continue;
			}
			ParameterInfo[] parameters = constructors[0].GetParameters();
			foreach (ParameterInfo parameterInfo in parameters)
			{
				if (Array.IndexOf(type_1, parameterInfo.ParameterType) != -1)
				{
					return type;
				}
			}
		}
		return null;
	}

	public static byte[] smethod_1(string string_1)
	{
		MD5CryptoServiceProvider mD5CryptoServiceProvider = new MD5CryptoServiceProvider();
		return mD5CryptoServiceProvider.ComputeHash(Encoding.UTF8.GetBytes(string_1));
	}

	public static byte[] smethod_2(byte[] byte_0)
	{
		MD5CryptoServiceProvider mD5CryptoServiceProvider = new MD5CryptoServiceProvider();
		return mD5CryptoServiceProvider.ComputeHash(byte_0);
	}

	public static string smethod_3(Stream stream_0)
	{
		MD5CryptoServiceProvider mD5CryptoServiceProvider = new MD5CryptoServiceProvider();
		return BitConverter.ToString(mD5CryptoServiceProvider.ComputeHash(stream_0)).Replace("-", string.Empty);
	}

	public static string smethod_4(Stream stream_0, int int_0, long long_0)
	{
		byte[] array = new byte[int_0 - 1 + 1];
		MD5CryptoServiceProvider mD5CryptoServiceProvider = new MD5CryptoServiceProvider();
		stream_0.Position = 0L;
		long num = default(long);
		int num2;
		do
		{
			int count = (int)Math.Min(array.Length, long_0 - num);
			num2 = stream_0.Read(array, 0, count);
			mD5CryptoServiceProvider.TransformBlock(array, 0, num2, null, 0);
			num += num2;
		}
		while (num2 != 0);
		mD5CryptoServiceProvider.TransformFinalBlock(new byte[0], 0, 0);
		return BitConverter.ToString(mD5CryptoServiceProvider.Hash).Replace("-", string.Empty);
	}
}
