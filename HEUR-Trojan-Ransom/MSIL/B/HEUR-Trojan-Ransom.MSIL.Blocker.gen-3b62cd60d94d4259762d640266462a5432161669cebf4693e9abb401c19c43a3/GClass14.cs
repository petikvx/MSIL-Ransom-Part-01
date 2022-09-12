using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;

public class GClass14
{
	private readonly ImageCodecInfo imageCodecInfo_0;

	private readonly EncoderParameters encoderParameters_0;

	private readonly EncoderParameter encoderParameter_0;

	public extern GClass14(int int_0);

	public extern byte[] method_0(Bitmap bitmap_0, byte[] byte_0 = null);

	public extern void method_1(Bitmap bitmap_0, Stream stream_0, byte[] byte_0 = null);

	private extern ImageCodecInfo method_2(string string_0);

	static extern EncoderParameter smethod_0(Encoder encoder_0, long long_0);

	static extern EncoderParameters smethod_1(int int_0);

	static extern EncoderParameter[] smethod_2(EncoderParameters encoderParameters_1);

	static extern MemoryStream smethod_3();

	static extern void smethod_4(Stream stream_0, byte[] byte_0, int int_0, int int_1);

	static extern void smethod_5(Image image_0, Stream stream_0, ImageCodecInfo imageCodecInfo_1, EncoderParameters encoderParameters_1);

	static extern byte[] smethod_6(MemoryStream memoryStream_0);

	static extern void smethod_7(IDisposable idisposable_0);

	static extern ImageCodecInfo[] smethod_8();

	static extern string smethod_9(ImageCodecInfo imageCodecInfo_1);

	static bool smethod_10(string string_0, string string_1)
	{
		//Discarded unreachable code: IL_0006, IL_000b, IL_0011
		while (true)
		{
		}
	}
}
