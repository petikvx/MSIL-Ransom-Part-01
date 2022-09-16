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
		this.id = id;
		picture = Car.smethod_0();
		Car.smethod_1((FrameworkElement)(object)picture, 20.0);
		Car.smethod_2((FrameworkElement)(object)picture, 20.0);
		Car.smethod_5(picture, (ImageSource)(object)Car.smethod_4(Car.smethod_3(path, UriKind.Relative)));
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
