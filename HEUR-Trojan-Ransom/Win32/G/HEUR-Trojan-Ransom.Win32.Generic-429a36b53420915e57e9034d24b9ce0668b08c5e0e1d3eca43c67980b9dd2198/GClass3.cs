using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Windows.Forms;

public class GClass3
{
	public static bool smethod_0(string string_0, string string_1)
	{
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Expected O, but got Unknown
		Bitmap val = new Bitmap(Screen.get_PrimaryScreen().get_Bounds().Width, Screen.get_PrimaryScreen().get_Bounds().Height);
		Graphics val2 = Graphics.FromImage((Image)(object)val);
		val2.CopyFromScreen(0, 0, 0, 0, ((Image)val).get_Size());
		try
		{
			smethod_1(Path.Combine(string_1, string_0 + ".jpg"), (Image)(object)val, 25);
			((Image)val).Dispose();
			val = null;
		}
		catch
		{
			return false;
		}
		return true;
	}

	private static void smethod_1(string string_0, Image image_0, int int_0)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Expected O, but got Unknown
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Expected O, but got Unknown
		EncoderParameter val = new EncoderParameter(Encoder.Quality, (long)int_0);
		ImageCodecInfo val2 = smethod_2("image/jpeg");
		EncoderParameters val3 = new EncoderParameters(1);
		val3.get_Param()[0] = val;
		image_0.Save(string_0, val2, val3);
	}

	private static ImageCodecInfo smethod_2(string string_0)
	{
		ImageCodecInfo[] imageEncoders = ImageCodecInfo.GetImageEncoders();
		int num = 0;
		while (true)
		{
			if (num < imageEncoders.Length)
			{
				if (imageEncoders[num].get_MimeType() == string_0)
				{
					break;
				}
				num++;
				continue;
			}
			return null;
		}
		return imageEncoders[num];
	}
}
