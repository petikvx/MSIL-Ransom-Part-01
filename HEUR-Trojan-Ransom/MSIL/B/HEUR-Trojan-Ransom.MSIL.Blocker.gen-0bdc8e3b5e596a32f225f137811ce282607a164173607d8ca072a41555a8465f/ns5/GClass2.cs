using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using ns6;

namespace ns5;

public class GClass2
{
	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct Struct0
	{
		public byte[] h;
	}

	internal string M;

	internal IntPtr g;

	internal ResourceManager N;

	public static IEnumerable<TypeInfo> DefinedTypes
	{
		get
		{
			Type[] array = smethod_1();
			TypeInfo[] array2 = new TypeInfo[array.Length];
			for (int i = 0; i < array.Length; i++)
			{
				TypeInfo typeInfo = array[i].GetTypeInfo();
				int num = i;
				if (!(typeInfo == null))
				{
					array2[num] = typeInfo;
					continue;
				}
				throw new NotSupportedException("NotSupported_NoTypeInfo");
			}
			return array2;
		}
	}

	public static Assembly smethod_0()
	{
		return Assembly.Load(Class2.smethod_0());
	}

	public GClass2(Assembly resourceAssembly, string resourceName)
	{
		if (resourceAssembly == null)
		{
			throw new ArgumentNullException("resourceAssembly");
		}
		if (string.IsNullOrEmpty(resourceName))
		{
			throw new ArgumentNullException("resourceName");
		}
		string text = (M = resourceName.ToLowerInvariant());
		IntPtr intPtr = (g = Marshal.GetHINSTANCE(resourceAssembly.ManifestModule));
		ResourceManager resourceManager = (N = new ResourceManager(new AssemblyName(resourceAssembly.FullName).Name + ".g", resourceAssembly));
	}

	public static Type[] smethod_1()
	{
		Module[] array = smethod_2(bool_0: false);
		int num = array.Length;
		int num2 = 0;
		Type[][] array2 = new Type[num][];
		for (int i = 0; i < num; i++)
		{
			array2[i] = array[i].GetTypes();
			num2 += array2[i].Length;
		}
		int num3 = 0;
		Type[] array3 = new Type[num2];
		for (int j = 0; j < num; j++)
		{
			int num4 = array2[j].Length;
			Array.Copy(array2[j], 0, array3, num3, num4);
			num3 += num4;
		}
		return array3;
	}

	public static Module[] smethod_2(bool bool_0)
	{
		throw new NotImplementedException();
	}

	internal static byte[] smethod_3(byte[] byte_0, ICryptoTransform icryptoTransform_0)
	{
		Struct0 struct0_ = default(Struct0);
		struct0_.h = byte_0;
		using MemoryStream memoryStream = new MemoryStream();
		using CryptoStream cryptoStream = new CryptoStream(memoryStream, icryptoTransform_0, CryptoStreamMode.Write);
		smethod_4(cryptoStream, ref struct0_);
		cryptoStream.FlushFinalBlock();
		return memoryStream.ToArray();
	}

	[CompilerGenerated]
	internal static void smethod_4(CryptoStream cryptoStream_0, ref Struct0 struct0_0)
	{
		cryptoStream_0.Write(struct0_0.h, 0, struct0_0.h.Length);
	}
}
