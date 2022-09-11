using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;

public class ImageConverter
{
	public static string imageToByteArray(Image imageIn)
	{
		MemoryStream memoryStream = new MemoryStream();
		imageIn.Save((Stream)memoryStream, ImageFormat.get_Jpeg());
		return Convert.ToBase64String(memoryStream.ToArray());
	}

	public static Image byteArrayToImage(byte[] byteArrayIn)
	{
		return Image.FromStream((Stream)new MemoryStream(byteArrayIn));
	}
}
