using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace Traffic_Simulation;

internal class Car
{
	public int id { get; private set; }

	public Image picture { get; private set; }

	public Car(int id, string path)
	{
		while (true)
		{
			int num = -2141889945;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xEEF68E91u) % 10u)
				{
				case 9u:
					picture = Car.smethod_0();
					num = ((int)num2 * -315005189) ^ -1111415511;
					continue;
				case 8u:
					this.id = id;
					num = ((int)num2 * -1366430247) ^ -445350596;
					continue;
				case 6u:
					num = (int)(num2 * 229783360) ^ -1263042713;
					continue;
				case 4u:
					num = ((int)num2 * -1872028951) ^ -1803515834;
					continue;
				case 3u:
					num = (int)(num2 * 1147045492) ^ -536491257;
					continue;
				case 2u:
					Car.smethod_2((FrameworkElement)(object)picture, 20.0);
					num = ((int)num2 * -1183045411) ^ -126342195;
					continue;
				case 1u:
					Car.smethod_1((FrameworkElement)(object)picture, 20.0);
					num = ((int)num2 * -275367938) ^ -4736348;
					continue;
				case 0u:
					Car.smethod_5(picture, (ImageSource)(object)Car.smethod_4(Car.smethod_3(path, UriKind.Relative)));
					num = ((int)num2 * -643454942) ^ 0x3CC46C27;
					continue;
				default:
					return;
				case 7u:
					break;
				case 5u:
					return;
				}
				break;
			}
		}
	}

	static Image smethod_0()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		return new Image();
	}

	static void smethod_1(FrameworkElement frameworkElement_0, double double_0)
	{
		frameworkElement_0.set_Width(double_0);
	}

	static void smethod_2(FrameworkElement frameworkElement_0, double double_0)
	{
		frameworkElement_0.set_Height(double_0);
	}

	static Uri smethod_3(string string_0, UriKind uriKind_0)
	{
		return new Uri(string_0, uriKind_0);
	}

	static BitmapImage smethod_4(Uri uri_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Expected O, but got Unknown
		return new BitmapImage(uri_0);
	}

	static void smethod_5(Image image_0, ImageSource imageSource_0)
	{
		image_0.set_Source(imageSource_0);
	}
}
