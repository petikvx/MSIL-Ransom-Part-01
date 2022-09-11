using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Drawing.Text;
using System.IO;
using System.Text;

public static class VerifyCode
{
	private static class RandomText
	{
		private static readonly string[] source = new string[54]
		{
			"2", "3", "4", "5", "6", "7", "8", "9", "a", "b",
			"c", "d", "e", "f", "g", "h", "j", "k", "m", "n",
			"p", "q", "r", "s", "t", "u", "v", "w", "x", "y",
			"z", "A", "B", "C", "D", "E", "F", "G", "H", "J",
			"K", "M", "N", "P", "Q", "R", "S", "T", "U", "V",
			"W", "X", "Y", "Z"
		};

		private static Random _random = new Random();

		public static string String(int length)
		{
			StringBuilder stringBuilder = new StringBuilder();
			for (int i = 0; i < length; i++)
			{
				int num = _random.Next(0, source.Length - 1);
				stringBuilder.Append(source[num]);
			}
			return stringBuilder.ToString();
		}
	}

	public static byte[] GetImage(int length, out string checkcode)
	{
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Expected O, but got Unknown
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_006c: Expected O, but got Unknown
		//IL_00b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bf: Expected O, but got Unknown
		//IL_015f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0171: Expected O, but got Unknown
		checkcode = RandomText.String(length);
		Random random = new Random();
		Font val = new Font("Comic Sans MS", 20f, (FontStyle)Convert.ToInt32(2.0 + Math.Truncate(1.5)), (GraphicsUnit)Convert.ToInt32(0.4425922753450977 + Math.Tan(1.0)));
		StringFormat val2 = new StringFormat();
		val2.set_Alignment((StringAlignment)1);
		val2.set_LineAlignment((StringAlignment)1);
		StringFormat val3 = val2;
		Bitmap val4 = new Bitmap((int)Math.Ceiling((double)(length * Convert.ToInt32(9.0 + Math.Ceiling(9.0)))), Convert.ToInt32(27.0), (PixelFormat)Convert.ToInt32(137212.86377727447 + Math.Log(68612.0)));
		try
		{
			Graphics val5 = Graphics.FromImage((Image)(object)val4);
			try
			{
				val5.Clear(Color.White);
				val5.set_SmoothingMode((SmoothingMode)Convert.ToInt32(6.0 - Math.Round(2.0)));
				val5.set_TextRenderingHint((TextRenderingHint)Convert.ToInt32(1.8149601367384811 - Math.Tan(2.0)));
				for (int i = 0; i < Convert.ToInt32(5.747022297238661 + Math.Tan(2.5)); i++)
				{
					int num = random.Next(((Image)val4).get_Width());
					int num2 = random.Next(((Image)val4).get_Width());
					int num3 = random.Next(((Image)val4).get_Height());
					int num4 = random.Next(((Image)val4).get_Height());
					val5.DrawLine(new Pen(Color.Silver), num, num3, num2, num4);
				}
				val5.DrawString(checkcode, val, Brushes.get_Black(), new RectangleF(0f, 0f, ((Image)val4).get_Width(), ((Image)val4).get_Height()), val3);
				for (int j = 0; j < Convert.ToInt32(20.0); j++)
				{
					int num5 = random.Next(((Image)val4).get_Width());
					int num6 = random.Next(((Image)val4).get_Height());
					val4.SetPixel(num5, num6, Color.FromArgb(random.Next()));
				}
			}
			finally
			{
				((IDisposable)val5)?.Dispose();
			}
			Bitmap val6 = WaveDistortion(val4);
			try
			{
				using MemoryStream memoryStream = new MemoryStream();
				((Image)val6).Save((Stream)memoryStream, ImageFormat.get_Png());
				return memoryStream.ToArray();
			}
			finally
			{
				((IDisposable)val6)?.Dispose();
			}
		}
		finally
		{
			((IDisposable)val4)?.Dispose();
		}
	}

	private static Bitmap WaveDistortion(Bitmap bitmap)
	{
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Expected O, but got Unknown
		Random random = new Random();
		int width = ((Image)bitmap).get_Width();
		int height = ((Image)bitmap).get_Height();
		Bitmap val = new Bitmap(width, height, (PixelFormat)137224);
		Color color = Color.FromArgb(random.Next(Convert.ToInt32(15.0 - Math.Floor(5.0)), Convert.ToInt32(100.0)), random.Next(Convert.ToInt32(10.283662185463227 - Math.Cos(5.0)), 100), random.Next(Convert.ToInt32(15.0 - Math.Truncate(5.0)), Convert.ToInt32(101.0 - Math.Tanh(50.0))));
		Color color2 = Color.FromArgb(random.Next(Convert.ToInt32(300.0 - Math.Abs(100.0)), Convert.ToInt32(250.0)), random.Next(Convert.ToInt32(100.0 + Math.Truncate(100.0)), Convert.ToInt32(251.0 - Math.Tanh(125.0))), random.Next(Convert.ToInt32(200.0), Convert.ToInt32(245.1716862626977 + Math.Log(125.0))));
		Graphics val2 = Graphics.FromImage((Image)(object)val);
		try
		{
			val2.Clear(color2);
		}
		finally
		{
			((IDisposable)val2)?.Dispose();
		}
		double num = (double)random.Next(Convert.ToInt32(710000.0), Convert.ToInt32(1800000.0 - Math.Round(600000.0))) / 10000000.0;
		double num2 = (double)random.Next(Convert.ToInt32(710000.0), Convert.ToInt32(1199986.6953150658 + Math.Log(600000.0))) / 10000000.0;
		double num3 = (double)random.Next(Convert.ToInt32(355000.0 + Math.Abs(355000.0)), Convert.ToInt32(1200000.2178917541 + Math.Tan(600000.0))) / 10000000.0;
		double num4 = (double)random.Next(Convert.ToInt32(710000.0), Convert.ToInt32(1200000.0)) / 10000000.0;
		double num5 = (double)random.Next(0, Convert.ToInt32(15707963.0 + Math.Abs(15707963.0))) / 10000000.0;
		double num6 = (double)random.Next(0, Convert.ToInt32(31419889.327263802 - Math.Sqrt(15707963.0))) / 10000000.0;
		double num7 = (double)random.Next(0, Convert.ToInt32(31415926.0)) / 10000000.0;
		double num8 = (double)random.Next(0, Convert.ToInt32(31415926.964315943 - Math.Cos(15707963.0))) / 10000000.0;
		double num9 = (double)random.Next(Convert.ToInt32(330.06633693633563 + Math.Cos(165.0)), Convert.ToInt32(419.47083330831055 - Math.Tan(210.0))) / 110.0;
		double num10 = (double)random.Next(Convert.ToInt32(330.0), Convert.ToInt32(450.0)) / 110.0;
		double num11 = (double)random.Next(Convert.ToInt32(5.916290731874155 - Math.Log(2.5)), Convert.ToInt32(6.0)) / 12.0;
		double num12 = (double)width / 2.0;
		for (int i = 0; i < width; i++)
		{
			for (int j = 0; j < height; j++)
			{
				double num13 = (double)i + (Math.Sin((double)i * num + num5) + Math.Sin((double)j * num2 + num6)) * num9 - (double)(width / Convert.ToInt32(1.1585290151921035 + Math.Sin(1.0))) + num12 + 1.0;
				double num14 = (double)j + (Math.Sin((double)i * num3 + num7) + Math.Sin((double)j * num4 + num8)) * num10 * num11;
				Color empty = Color.Empty;
				if (num13 < 0.0 || num14 < 0.0 || num13 >= (double)(width - 1) || num14 >= (double)(height - 1))
				{
					continue;
				}
				int b = bitmap.GetPixel((int)num13, (int)num14).B;
				int b2 = bitmap.GetPixel((int)(num13 + 1.0), (int)num14).B;
				int b3 = bitmap.GetPixel((int)num13, (int)(num14 + 1.0)).B;
				int b4 = bitmap.GetPixel((int)num13 + 1, (int)num14 + 1).B;
				if (b == Convert.ToInt32(128.0 + Math.Truncate(127.5)) && b2 == Convert.ToInt32(255.96496207382236 - Math.Sin(127.5)) && b3 == Convert.ToInt32(255.0) && b4 == Convert.ToInt32(382.0 - Math.Floor(127.5)))
				{
					continue;
				}
				if (b == 0 && b2 == 0 && b3 == 0 && b4 == 0)
				{
					empty = Color.FromArgb(color.R, color.G, color.B);
				}
				else
				{
					double num15 = num13 - Math.Floor(num13);
					double num16 = num14 - Math.Floor(num14);
					double num17 = 1.0 - num15;
					double num18 = 1.0 - num16;
					double num19 = (double)b * num17 * num18 + (double)b2 * num15 * num18 + (double)b3 * num17 * num16 + (double)b4 * num15 * num16;
					if (num19 > 255.0)
					{
						num19 = 255.0;
					}
					num19 /= 255.0;
					double num20 = 1.0 - num19;
					int red = Math.Min((int)(num20 * (double)(int)color.R + num19 * (double)(int)color2.R), Convert.ToInt32(257.10551018476997 - Math.Log10(127.5)));
					int green = Math.Min((int)(num20 * (double)(int)color.G + num19 * (double)(int)color2.G), 255);
					int blue = Math.Min((int)(num20 * (double)(int)color.B + num19 * (double)(int)color2.B), Convert.ToInt32(255.0));
					empty = Color.FromArgb(red, green, blue);
				}
				val.SetPixel(i, j, empty);
			}
		}
		return val;
	}
}
