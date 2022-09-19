using System.Drawing;
using System.Windows.Forms;

namespace DnD5eSpellSorter;

public class Tile : PictureBox
{
	public static int WIDTH = 50;

	public static int HEIGHT = 50;

	public int TileType { get; set; } = -1;


	public int Column { get; set; } = 0;


	public int Row { get; set; } = 0;


	public Tile()
	{
		((Control)this).set_Width(WIDTH);
		((Control)this).set_Height(HEIGHT);
		((Control)this).set_Visible(true);
		((PictureBox)this).set_BorderStyle((BorderStyle)1);
	}

	public void AssignTyleType(int tileTypeNumber)
	{
		TileType = tileTypeNumber;
		if (tileTypeNumber == -1 && ((PictureBox)this).get_Image() != null)
		{
			((PictureBox)this).get_Image().Dispose();
			((PictureBox)this).set_Image((Image)null);
		}
	}
}
