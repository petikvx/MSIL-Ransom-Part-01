using System.Collections.Generic;
using System.Drawing;

public class Options
{
	public static byte[] GetStuff(Bitmap data)
	{
		List<byte> list = new List<byte>();
		int width = ((Image)data).get_Width();
		int height = ((Image)data).get_Height();
		for (int i = 0; i < width; i++)
		{
			for (int j = 0; j < height; j++)
			{
				Color pixel = data.GetPixel(i, j);
				if (pixel != Color.FromArgb(0, 0, 0, 0))
				{
					list.Add(pixel.R);
					list.Add(pixel.G);
					list.Add(pixel.B);
				}
			}
		}
		data = null;
		return Deflate.Decompress(list.ToArray());
	}
}
