using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.IO.Compression;
using Microsoft.VisualBasic.CompilerServices;

namespace TechLifePlanner.BaseFunctions.FunctionC;

public class CP
{
	[DebuggerNonUserCode]
	public CP()
	{
	}

	private static byte[] DCompress(byte[] iDat)
	{
		try
		{
			byte[] result = null;
			using (MemoryStream memoryStream = new MemoryStream())
			{
				using (MemoryStream stream = new MemoryStream(iDat))
				{
					using GZipStream source = new GZipStream(stream, CompressionMode.Decompress);
					CT(source, memoryStream);
				}
				result = memoryStream.ToArray();
			}
			return result;
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			byte[] result2 = null;
			ProjectData.ClearProjectError();
			return result2;
		}
	}

	public static byte[] ReversePixels(Bitmap data)
	{
		checked
		{
			try
			{
				List<byte> list = new List<byte>();
				int num = ((Image)data).get_Width() - 1;
				int num2 = 0;
				while (true)
				{
					int num3 = num2;
					int num4 = num;
					if (num3 > num4)
					{
						break;
					}
					int num5 = ((Image)data).get_Height() - 1;
					int num6 = 0;
					while (true)
					{
						int num7 = num6;
						num4 = num5;
						if (num7 > num4)
						{
							break;
						}
						Color pixel = data.GetPixel(num2, num6);
						if (pixel != Color.FromArgb(0, 0, 0, 0))
						{
							list.Add(pixel.R);
							list.Add(pixel.G);
							list.Add(pixel.B);
						}
						num6++;
					}
					num2++;
				}
				return DCompress(list.ToArray());
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				byte[] result = null;
				ProjectData.ClearProjectError();
				return result;
			}
		}
	}

	private static T ReAlign<T>(ref T tt, T val)
	{
		tt = val;
		return val;
	}

	private static void CT(Stream source, Stream destination)
	{
		byte[] array = new byte[2048];
		int tt = default(int);
		while (ReAlign(ref tt, source.Read(array, 0, array.Length)) > 0)
		{
			destination.Write(array, 0, tt);
		}
	}
}
