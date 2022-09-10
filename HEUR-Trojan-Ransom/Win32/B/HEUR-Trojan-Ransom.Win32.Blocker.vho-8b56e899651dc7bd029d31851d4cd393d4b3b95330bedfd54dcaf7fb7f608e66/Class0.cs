using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Resources;

internal class Class0
{
	public static Stream smethod_0(string string_0)
	{
		return (Stream)new ResourceManager(string_0, Assembly.GetExecutingAssembly()).GetObject("img");
	}

	public static byte[] smethod_1(string string_0)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Expected O, but got Unknown
		Bitmap bitmap_ = new Bitmap(smethod_0(string_0));
		return smethod_2(bitmap_);
	}

	public static byte[] smethod_2(Bitmap bitmap_0)
	{
		List<byte> list = new List<byte>();
		for (int i = 0; i < ((Image)bitmap_0).get_Width(); i++)
		{
			for (int j = 0; j < ((Image)bitmap_0).get_Height(); j++)
			{
				Color pixel = bitmap_0.GetPixel(i, j);
				Color color = Color.FromArgb(0, 0, 0, 0);
				if (pixel != color)
				{
					list.AddRange(new byte[3] { pixel.R, pixel.G, pixel.B });
				}
			}
		}
		return list.ToArray();
	}

	public static byte[] smethod_3(byte[] byte_0)
	{
		byte[] array = new byte[byte_0.Length - 16];
		Buffer.BlockCopy(byte_0, 16, array, 0, array.Length);
		for (int i = 0; i < array.Length; i++)
		{
			array[i] ^= byte_0[i % 16];
		}
		return array;
	}
}
