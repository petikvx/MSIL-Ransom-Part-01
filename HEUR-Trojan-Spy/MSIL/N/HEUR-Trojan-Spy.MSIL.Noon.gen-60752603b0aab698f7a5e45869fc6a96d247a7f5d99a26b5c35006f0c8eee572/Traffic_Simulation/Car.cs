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
			int num = -417015032;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xC86987EAu) % 9u)
				{
				case 8u:
					Car.smethod_1((FrameworkElement)(object)picture, 20.0);
					num = ((int)num2 * -134774850) ^ 0x2F61F9FF;
					continue;
				case 7u:
					picture = Car.smethod_0();
					num = ((int)num2 * -2070285226) ^ -309670928;
					continue;
				case 6u:
					this.id = id;
					num = (int)((num2 * 1694615271) ^ 0x744B844C);
					continue;
				case 5u:
					Car.smethod_5(picture, (ImageSource)(object)Car.smethod_4(Car.smethod_3(path, UriKind.Relative)));
					num = ((int)num2 * -1372344097) ^ 0x4D827410;
					continue;
				case 4u:
					num = (int)(num2 * 810208914) ^ -593214614;
					continue;
				case 1u:
					num = (int)(num2 * 1245940398) ^ -2129455419;
					continue;
				case 0u:
					Car.smethod_2((FrameworkElement)(object)picture, 20.0);
					num = (int)((num2 * 893832400) ^ 0x461A5DAF);
					continue;
				default:
					return;
				case 2u:
					break;
				case 3u:
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
