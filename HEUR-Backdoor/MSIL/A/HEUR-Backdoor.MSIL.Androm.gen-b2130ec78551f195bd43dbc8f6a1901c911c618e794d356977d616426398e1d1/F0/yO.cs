using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace F0;

internal class yO
{
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private int m0;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private Image xc;

	private static yO K4;

	[SpecialName]
	[CompilerGenerated]
	public int l2()
	{
		return m0;
	}

	[SpecialName]
	[CompilerGenerated]
	private void iI(int int_0)
	{
		m0 = int_0;
	}

	[SpecialName]
	[CompilerGenerated]
	public Image Cb()
	{
		return xc;
	}

	[SpecialName]
	[CompilerGenerated]
	private void An(Image image_0)
	{
		xc = image_0;
	}

	public yO(int int_0, string string_0)
	{
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Expected O, but got Unknown
		Rg.XRF6rz();
		base._002Ector();
		iI(int_0);
		An(new Image());
		((FrameworkElement)Cb()).set_Width(20.0);
		((FrameworkElement)Cb()).set_Height(20.0);
		vi(Cb(), (object)new BitmapImage(new Uri(string_0, UriKind.Relative)));
	}

	internal static bool lF()
	{
		return K4 == null;
	}

	internal static yO yC()
	{
		return K4;
	}

	internal static void vi(object object_0, object object_1)
	{
		((Image)object_0).set_Source((ImageSource)object_1);
	}
}
