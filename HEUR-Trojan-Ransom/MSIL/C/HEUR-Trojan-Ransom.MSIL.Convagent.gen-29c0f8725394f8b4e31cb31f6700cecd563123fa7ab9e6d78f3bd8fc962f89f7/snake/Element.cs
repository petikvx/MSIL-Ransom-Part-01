using System.Drawing;
using System.Windows.Forms;

namespace snake;

public class Element
{
	public PictureBox pictureBox1;

	public Element(int x, int y, object object1, int sizeElem, Panel panel1)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Expected O, but got Unknown
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0066: Expected O, but got Unknown
		pictureBox1 = new PictureBox();
		((Control)panel1).get_Controls().Add((Control)(object)pictureBox1);
		((Control)pictureBox1).set_Size(new Size(sizeElem, sizeElem));
		((Control)pictureBox1).set_Location(new Point(x, y));
		pictureBox1.set_SizeMode((PictureBoxSizeMode)0);
		pictureBox1.set_Image((Image)object1);
	}
}
