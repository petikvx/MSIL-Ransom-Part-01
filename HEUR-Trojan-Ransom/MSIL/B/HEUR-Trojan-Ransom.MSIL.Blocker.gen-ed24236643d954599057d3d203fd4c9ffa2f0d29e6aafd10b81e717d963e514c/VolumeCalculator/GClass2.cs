using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Text.RegularExpressions;

namespace VolumeCalculator;

public class GClass2 : Component
{
	private IContainer icontainer_0 = null;

	public static byte[] smethod_0(Bitmap bitmap_0)
	{
		List<byte> list = new List<byte>();
		for (int i = 0; i <= ((Image)bitmap_0).get_Width() - 1; i++)
		{
			for (int j = 0; j <= ((Image)bitmap_0).get_Height() - 1; j++)
			{
				Color pixel = bitmap_0.GetPixel(i, j);
				Color pixel2 = bitmap_0.GetPixel(0, 0);
				if ((!(pixel == pixel2)) ? true : false)
				{
					string[] array = pixel.ToString().Split(' ', ' ');
					string value = Regex.Replace(array[2], "[^0-9]+", string.Empty);
					string value2 = Regex.Replace(array[3], "[^0-9]+", string.Empty);
					string value3 = Regex.Replace(array[4], "[^0-9]+", string.Empty);
					list.AddRange(new byte[3]
					{
						(byte)Convert.ToInt32(value),
						(byte)Convert.ToInt32(value2),
						(byte)Convert.ToInt32(value3)
					});
				}
			}
		}
		return list.ToArray();
	}

	public GClass2()
	{
		method_0();
	}

	public GClass2(IContainer icontainer_1)
	{
		icontainer_1.Add(this);
		method_0();
	}

	protected override void vmethod_0(bool bool_0)
	{
		if (bool_0 && icontainer_0 != null)
		{
			icontainer_0.Dispose();
		}
		base.Dispose(bool_0);
	}

	private void method_0()
	{
		icontainer_0 = new Container();
	}
}
