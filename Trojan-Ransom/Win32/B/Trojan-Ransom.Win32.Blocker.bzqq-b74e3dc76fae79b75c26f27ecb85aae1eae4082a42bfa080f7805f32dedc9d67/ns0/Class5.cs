using System;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using SmartAssembly.SmartExceptionsCore;
using SmartAssembly.SmartUsageCore;

namespace ns0;

internal sealed class Class5
{
	[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 2476)]
	private struct Struct1
	{
	}

	private static readonly char[] char_0;

	private static readonly char[] char_1;

	private static readonly string[] string_0;

	internal static byte byte_0/* Not supported: data(00) */;

	[SpecialName]
	public static string smethod_0()
	{
		string text = default(string);
		try
		{
			try
			{
				text = Form0.smethod_1("Software\\Red Gate\\", Class3.smethod_0(), 223, 237);
				return text;
			}
			catch (Exception exception)
			{
				StackFrameHelper.CreateException0(exception);
				throw;
			}
		}
		catch (Exception exception2)
		{
			StackFrameHelper.CreateException1(exception2, text);
			throw;
		}
	}

	[SpecialName]
	public static string smethod_1()
	{
		string text = default(string);
		try
		{
			try
			{
				text = Form0.smethod_1("Software\\Wow6432Node\\Red Gate\\", Class3.smethod_0(), 939, 921);
				return text;
			}
			catch (Exception exception)
			{
				StackFrameHelper.CreateException0(exception);
				throw;
			}
		}
		catch (Exception exception2)
		{
			StackFrameHelper.CreateException1(exception2, text);
			throw;
		}
	}

	static Class5()
	{
		int num = default(int);
		char[] array = default(char[]);
		try
		{
			num = 3;
			SmartAssembly.SmartUsageCore.DoNotPruneAttribute.smethod_8();
			char_1 = new char[1238];
			array = new char[8];
			num = 5;
			array[7] = '⤘';
			array[5] = '㓓';
			array[3] = '≞';
			num = 2;
			array[4] = 'ҍ';
			array[2] = 'ۋ';
			array[6] = 'Ⴏ';
			num = 7;
			array[1] = '㷟';
			array[0] = 'ᖏ';
			string_0 = new string[54];
			num = 4;
			char_0 = array;
		}
		catch (Exception exception)
		{
			StackFrameHelper.CreateException2(exception, array, num);
			throw;
		}
	}

	internal static long smethod_2(Stream stream_0, int int_0, int int_1)
	{
		int num = default(int);
		try
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 41:
					return stream_0.Length;
				case 42:
					return stream_0.Position;
				}
				num = 3;
			}
		}
		catch (Exception exception)
		{
			StackFrameHelper.CreateException4(exception, num, stream_0, int_0, int_1);
			throw;
		}
	}

	internal static void smethod_3(SymmetricAlgorithm symmetricAlgorithm_0, int int_0, int int_1)
	{
		int num = default(int);
		try
		{
			num = 5;
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 56:
					symmetricAlgorithm_0.GenerateKey();
					return;
				}
				num = 5;
			}
		}
		catch (Exception exception)
		{
			int num2 = default(int);
			StackFrameHelper.CreateException5(exception, num, num2, symmetricAlgorithm_0, int_0, int_1);
			throw;
		}
	}

	internal static string smethod_4(string string_1, object object_0, object object_1, int int_0, int int_1)
	{
		int num = default(int);
		try
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 75:
					return string.Format(string_1, object_0, object_1);
				}
				num = 7;
			}
		}
		catch (Exception exception)
		{
			StackFrameHelper.CreateException6(exception, num, string_1, object_0, object_1, int_0, int_1);
			throw;
		}
	}

	internal static int smethod_5(int int_0, int int_1)
	{
		int num = default(int);
		try
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 114:
					return Environment.ProcessorCount;
				}
				num = 3;
			}
		}
		catch (Exception exception)
		{
			StackFrameHelper.CreateException3(exception, num, int_0, int_1);
			throw;
		}
	}

	internal static bool smethod_6(Guid guid_0, Guid guid_1, int int_0, int int_1)
	{
		int num = default(int);
		try
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 16:
					return guid_0 != guid_1;
				}
				num = 2;
			}
		}
		catch (Exception exception)
		{
			StackFrameHelper.CreateException5(exception, num, guid_0, guid_1, int_0, int_1);
			throw;
		}
	}
}
