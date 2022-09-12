using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;

namespace WindowsFormsApplication1;

public static class Imager
{
	public static void SaveJpeg(string path, Image img)
	{
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Expected O, but got Unknown
		EncoderParameter val = new EncoderParameter(Encoder.Quality, 100L);
		ImageCodecInfo encoderInfo = GetEncoderInfo("image/jpeg");
		EncoderParameters val2 = new EncoderParameters(1);
		val2.get_Param()[0] = val;
		img.Save(path, encoderInfo, val2);
	}

	public static void PerformImageResizeAndPutOnCanvas1(string pFilePath, string pFileName, int pWidth, int pHeight, string pOutputFileName)
	{
		Image image = Image.FromFile(pFilePath + pFileName);
		Image image2 = Resize(image, pWidth, pHeight, onlyResizeIfWider: true);
		Image img = PutOnCanvas(image2, pWidth, pHeight, Color.White);
		SaveJpeg(pFilePath + pOutputFileName, img);
	}

	public static void Save(string path, Image img, ImageCodecInfo imageCodecInfo)
	{
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Expected O, but got Unknown
		EncoderParameter val = new EncoderParameter(Encoder.Quality, 100L);
		EncoderParameters val2 = new EncoderParameters(1);
		val2.get_Param()[0] = val;
		img.Save(path, imageCodecInfo, val2);
	}

	public static ImageCodecInfo GetEncoderInfo(string mimeType)
	{
		return ((IEnumerable<ImageCodecInfo>)ImageCodecInfo.GetImageEncoders()).FirstOrDefault((Func<ImageCodecInfo, bool>)((ImageCodecInfo t) => t.get_MimeType() == mimeType));
	}

	public static Image PutOnCanvas(Image image, int width, int height, Color canvasColor)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Expected O, but got Unknown
		Bitmap val = new Bitmap(width, height);
		Graphics val2 = Graphics.FromImage((Image)(object)val);
		try
		{
			val2.Clear(canvasColor);
			int num = (width - image.get_Width()) / 2;
			int num2 = (height - image.get_Height()) / 2;
			val2.DrawImageUnscaled(image, num, num2, image.get_Width(), image.get_Height());
		}
		finally
		{
			((IDisposable)val2)?.Dispose();
		}
		return (Image)(object)val;
	}

	public static Image PutOnWhiteCanvas(Image image, int width, int height)
	{
		return PutOnCanvas(image, width, height, Color.White);
	}

	public static Image Resize(Image image, int newWidth, int maxHeight, bool onlyResizeIfWider)
	{
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Expected O, but got Unknown
		if (onlyResizeIfWider && image.get_Width() <= newWidth)
		{
			newWidth = image.get_Width();
		}
		int num = image.get_Height() * newWidth / image.get_Width();
		if (num > maxHeight)
		{
			newWidth = image.get_Width() * maxHeight / image.get_Height();
			num = maxHeight;
		}
		Bitmap val = new Bitmap(newWidth, num);
		Graphics val2 = Graphics.FromImage((Image)(object)val);
		try
		{
			val2.set_InterpolationMode((InterpolationMode)7);
			val2.set_SmoothingMode((SmoothingMode)2);
			val2.set_PixelOffsetMode((PixelOffsetMode)2);
			val2.set_CompositingQuality((CompositingQuality)2);
			val2.DrawImage(image, 0, 0, newWidth, num);
		}
		finally
		{
			((IDisposable)val2)?.Dispose();
		}
		return (Image)(object)val;
	}

	public static Image Crop(Image img, Rectangle cropArea)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Expected O, but got Unknown
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		Bitmap val = new Bitmap(img);
		return (Image)(object)val.Clone(cropArea, ((Image)val).get_PixelFormat());
	}

	public static byte[] imageToByteArray(Image imageIn)
	{
		MemoryStream memoryStream = new MemoryStream();
		imageIn.Save((Stream)memoryStream, ImageFormat.get_Gif());
		return memoryStream.ToArray();
	}

	public static Image byteArrayToImage(byte[] byteArrayIn)
	{
		MemoryStream memoryStream = new MemoryStream(byteArrayIn);
		return Image.FromStream((Stream)memoryStream);
	}

	public static string GetImage(object img)
	{
		return "data:image/jpg;base64," + Convert.ToBase64String((byte[])img);
	}

	public static void PerformImageResizeAndPutOnCanvas(string pFilePath, string pFileName, int pWidth, int pHeight, string pOutputFileName)
	{
		Image image = Image.FromFile(pFilePath);
		Image image2 = Resize(image, pWidth, pHeight, onlyResizeIfWider: true);
		Image img = PutOnCanvas(image2, pWidth, pHeight, Color.White);
		SaveJpeg(pOutputFileName, img);
	}
}
