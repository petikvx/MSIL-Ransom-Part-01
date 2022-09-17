using System.Drawing;
using System.Drawing.Imaging;
using System.IO;

namespace StreamLibrary.src;

public class JpgCompression
{
	private EncoderParameter parameter;

	private ImageCodecInfo encoderInfo;

	private EncoderParameters encoderParams;

	public JpgCompression(int Quality)
	{
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Expected O, but got Unknown
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Expected O, but got Unknown
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_0066: Unknown result type (might be due to invalid IL or missing references)
		//IL_006b: Unknown result type (might be due to invalid IL or missing references)
		parameter = new EncoderParameter(Encoder.Quality, (long)Quality);
		encoderInfo = GetEncoderInfo("image/jpeg");
		encoderParams = new EncoderParameters(2);
		encoderParams.get_Param()[0] = parameter;
		encoderParams.get_Param()[1] = new EncoderParameter(Encoder.Compression, 2L);
	}

	public byte[] Compress(Bitmap bmp)
	{
		using MemoryStream memoryStream = new MemoryStream();
		((Image)bmp).Save((Stream)memoryStream, encoderInfo, encoderParams);
		return memoryStream.ToArray();
	}

	public void Compress(Bitmap bmp, ref Stream TargetStream)
	{
		((Image)bmp).Save(TargetStream, encoderInfo, encoderParams);
	}

	private ImageCodecInfo GetEncoderInfo(string mimeType)
	{
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Expected O, but got Unknown
		ImageCodecInfo[] imageEncoders = ImageCodecInfo.GetImageEncoders();
		int num = imageEncoders.Length - 1;
		int num2 = 0;
		while (true)
		{
			if (num2 <= num)
			{
				if (imageEncoders[num2].get_MimeType() == mimeType)
				{
					break;
				}
				num2++;
				continue;
			}
			return null;
		}
		return imageEncoders[num2];
	}
}
