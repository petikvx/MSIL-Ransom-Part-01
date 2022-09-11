using System.Collections.Generic;
using System.Drawing;
using System.IO;

internal class Util
{
	public static Image LogWarningExecuteremove_OnPluginsLoaded(byte[] bytes)
	{
		using MemoryStream memoryStream = new MemoryStream(bytes);
		return Image.FromStream((Stream)memoryStream);
	}

	public static byte[] remove_OnPluginsLoadedAwakeLoadDefaults(Image innocuousImg)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Expected O, but got Unknown
		Bitmap val = new Bitmap(innocuousImg);
		int num = 0;
		byte[] array = new byte[3 * ((Image)val).get_Width() * ((Image)val).get_Height()];
		for (int i = 0; i < ((Image)val).get_Height(); i++)
		{
			for (int j = 0; j < ((Image)val).get_Width(); j++)
			{
				Color pixel = val.GetPixel(j, i);
				array[num++] = pixel.R;
				array[num++] = pixel.G;
				array[num++] = pixel.B;
			}
		}
		return array;
	}

	public static Bitmap ReadCloseDeleteGroup(byte[] rgbComponents, int width, int hight)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		Queue<byte> queue = new Queue<byte>(rgbComponents);
		Bitmap val = new Bitmap(width, hight);
		for (int i = 0; i < hight; i++)
		{
			for (int j = 0; j < width; j++)
			{
				val.SetPixel(j, i, Color.FromArgb(queue.Dequeue(), queue.Dequeue(), queue.Dequeue()));
			}
		}
		return val;
	}
}
