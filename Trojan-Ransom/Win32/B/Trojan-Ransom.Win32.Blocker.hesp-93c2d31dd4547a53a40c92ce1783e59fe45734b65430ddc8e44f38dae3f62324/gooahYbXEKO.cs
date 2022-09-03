using System;
using System.Drawing;
using Microsoft.VisualBasic.CompilerServices;

[StandardModule]
internal sealed class gooahYbXEKO
{
	public static byte[] bitmapToBytes(Bitmap inputBMP)
	{
		checked
		{
			object obj = ((Image)inputBMP).get_Width() * ((Image)inputBMP).get_Height() * 4;
			byte[] array = new byte[Conversions.ToInteger(obj) + 1];
			object obj2 = 0;
			int num = ((Image)inputBMP).get_Width() - 1;
			for (int i = 0; i <= num; i++)
			{
				int num2 = ((Image)inputBMP).get_Width() - 1;
				for (int j = 0; j <= num2; j++)
				{
					object obj3 = inputBMP.GetPixel(i, j);
					array[Conversions.ToInteger(obj2)] = Conversions.ToByte(NewLateBinding.LateGet(obj3, (Type)null, "A", new object[0], (string[])null, (Type[])null, (bool[])null));
					obj2 = Operators.AddObject(obj2, (object)1);
					array[Conversions.ToInteger(obj2)] = Conversions.ToByte(NewLateBinding.LateGet(obj3, (Type)null, "R", new object[0], (string[])null, (Type[])null, (bool[])null));
					obj2 = Operators.AddObject(obj2, (object)1);
					array[Conversions.ToInteger(obj2)] = Conversions.ToByte(NewLateBinding.LateGet(obj3, (Type)null, "G", new object[0], (string[])null, (Type[])null, (bool[])null));
					obj2 = Operators.AddObject(obj2, (object)1);
					array[Conversions.ToInteger(obj2)] = Conversions.ToByte(NewLateBinding.LateGet(obj3, (Type)null, "B", new object[0], (string[])null, (Type[])null, (bool[])null));
					obj2 = Operators.AddObject(obj2, (object)1);
				}
			}
			byte[] array2 = new byte[8];
			int num3 = 0;
			do
			{
				array2[num3] = array[num3];
				num3++;
			}
			while (num3 <= 7);
			object obj4 = BitConverter.ToInt64(array2, 0) - 1L;
			byte[] array3 = new byte[Conversions.ToInteger(obj4) + 1];
			int num4 = Conversions.ToInteger(Operators.AddObject(obj4, (object)8));
			for (int k = 8; k <= num4; k++)
			{
				array3[k - 8] = array[k];
			}
			return array3;
		}
	}
}
