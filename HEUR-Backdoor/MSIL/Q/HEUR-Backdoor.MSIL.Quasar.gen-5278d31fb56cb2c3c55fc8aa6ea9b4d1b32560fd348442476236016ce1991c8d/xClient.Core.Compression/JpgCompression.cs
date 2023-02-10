using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;

namespace xClient.Core.Compression;

public class JpgCompression : IDisposable
{
	private readonly ImageCodecInfo _encoderInfo;

	private readonly EncoderParameters _encoderParams;

	public JpgCompression(long quality)
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Expected O, but got Unknown
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Expected O, but got Unknown
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_0056: Expected O, but got Unknown
		EncoderParameter val = new EncoderParameter(Encoder.Quality, quality);
		_encoderInfo = GetEncoderInfo("image/jpeg");
		_encoderParams = new EncoderParameters(2);
		_encoderParams.get_Param()[0] = val;
		_encoderParams.get_Param()[1] = new EncoderParameter(Encoder.Compression, 5L);
	}

	public void Dispose()
	{
		Dispose(disposing: true);
		GC.SuppressFinalize(this);
	}

	protected virtual void Dispose(bool disposing)
	{
		if (disposing && _encoderParams != null)
		{
			_encoderParams.Dispose();
		}
	}

	public byte[] Compress(Bitmap bmp)
	{
		using MemoryStream memoryStream = new MemoryStream();
		((Image)bmp).Save((Stream)memoryStream, _encoderInfo, _encoderParams);
		return memoryStream.ToArray();
	}

	public void Compress(Bitmap bmp, ref Stream targetStream)
	{
		((Image)bmp).Save(targetStream, _encoderInfo, _encoderParams);
	}

	private ImageCodecInfo GetEncoderInfo(string mimeType)
	{
		ImageCodecInfo[] imageEncoders = ImageCodecInfo.GetImageEncoders();
		int num = imageEncoders.Length - 1;
		for (int i = 0; i <= num; i++)
		{
			if (imageEncoders[i].get_MimeType() == mimeType)
			{
				return imageEncoders[i];
			}
		}
		return null;
	}
}
