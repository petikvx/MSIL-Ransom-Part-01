using System.Drawing;
using System.Windows.Forms;
using ns0;

namespace ns2;

internal class Class14
{
	public static void smethod_0()
	{
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Expected O, but got Unknown
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0065: Expected O, but got Unknown
		if (Screen.get_PrimaryScreen().get_Bounds().Width < 1600)
		{
			((Control)Class1.Forms.frmLock.lblInfo).set_Font(new Font("Arial Narrow", 9f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
			((Control)Class1.Forms.frmLock.lblInfo2).set_Font(new Font("Arial Narrow", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		}
	}
}
