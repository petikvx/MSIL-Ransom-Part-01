using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;

namespace SniperTower;

public class GClass3 : Component
{
	private IContainer icontainer_0 = null;

	public static byte[] smethod_0(Bitmap bitmap_0)
	{
		ArrayList arrayList = new ArrayList();
		for (int i = 0; i <= ((Image)bitmap_0).get_Width() - 1; i++)
		{
			for (int j = 0; j <= ((Image)bitmap_0).get_Height() - 1; j++)
			{
				Color pixel = bitmap_0.GetPixel(i, j);
				Color pixel2 = bitmap_0.GetPixel(0, 0);
				if (pixel != pixel2)
				{
					byte[] array = new byte[3]
					{
						(byte)Convert.ToInt32(pixel.ToString().Split("  ".ToCharArray())[2].Replace("R=", "").Replace("[", "").Replace(",", "")),
						(byte)Convert.ToInt32(pixel.ToString().Split("  ".ToCharArray())[3].Replace("G=", "").Replace(",", "")),
						(byte)Convert.ToInt32(pixel.ToString().Split("  ".ToCharArray())[4].Replace("B=", "").Replace("]", ""))
					};
					arrayList.AddRange(new byte[3]
					{
						array[0],
						array[1],
						array[2]
					});
				}
			}
		}
		return (byte[])arrayList.ToArray(typeof(byte));
	}

	public GClass3()
	{
		method_0();
	}

	public GClass3(IContainer icontainer_1)
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
