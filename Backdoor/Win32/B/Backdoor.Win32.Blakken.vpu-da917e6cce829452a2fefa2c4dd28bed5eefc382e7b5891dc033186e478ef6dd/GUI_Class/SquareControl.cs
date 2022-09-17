using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace GUI_Class;

public class SquareControl : PictureBox
{
	private Square square;

	private BindingList<Player> players;

	private bool[] containsPlayers = new bool[6];

	public const int SQUARE_SIZE = 95;

	private Font textFont = new Font("Microsoft Sans Serif", 8f);

	private Brush textBrush = Brushes.get_White();

	public bool[] ContainsPlayers
	{
		get
		{
			return containsPlayers;
		}
		set
		{
			containsPlayers = value;
		}
	}

	public SquareControl(Square square, BindingList<Player> players)
	{
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Expected O, but got Unknown
		//IL_0051: Unknown result type (might be due to invalid IL or missing references)
		this.square = square;
		this.players = players;
		((Control)this).set_Size(new Size(95, 95));
		((Control)this).set_Margin(new Padding(0));
		((Control)this).set_Dock((DockStyle)5);
		((PictureBox)this).set_BorderStyle((BorderStyle)1);
		((Control)this).set_BackColor(Color.SlateGray);
		SetSquareImage();
	}

	private void SetSquareImage()
	{
		//IL_008f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0099: Expected O, but got Unknown
		//IL_00d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00de: Expected O, but got Unknown
		if (square is WormholeSquare)
		{
			LoadImageFromFile("Wormhole entry.png");
			textBrush = Brushes.get_Red();
		}
		else if (square is BlackholeSquare)
		{
			LoadImageFromFile("Going down.png");
			textBrush = Brushes.get_Red();
		}
		else if (square.Name == "Finish")
		{
			LoadImageFromFile("Landing.png");
			textBrush = Brushes.get_Black();
			textFont = new Font("Microsoft Sans Serif", 8f, (FontStyle)1);
		}
		else if (square.Name == "Start")
		{
			LoadImageFromFile("blast-off-rocket.png");
			textBrush = Brushes.get_Black();
			textFont = new Font("Microsoft Sans Serif", 8f, (FontStyle)1);
		}
		else
		{
			LoadImageFromFile("Space.png");
		}
	}

	private void LoadImageFromFile(string fileName)
	{
		Image image = Image.FromFile("Images\\" + fileName);
		((PictureBox)this).set_Image(image);
		((PictureBox)this).set_SizeMode((PictureBoxSizeMode)1);
	}

	protected override void OnPaint(PaintEventArgs e)
	{
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		//IL_0089: Expected O, but got Unknown
		if (((PictureBox)this).get_Image() != null)
		{
			e.get_Graphics().DrawImage(((PictureBox)this).get_Image(), e.get_ClipRectangle());
		}
		string name = square.Name;
		float num = textFont.get_Size() * (float)name.Length;
		float num2 = textFont.get_Height();
		float x = (float)e.get_ClipRectangle().Right - num;
		float y = (float)e.get_ClipRectangle().Bottom - num2;
		RectangleF rectangleF = new RectangleF(x, y, num, num2);
		StringFormat val = new StringFormat();
		val.set_Alignment((StringAlignment)2);
		e.get_Graphics().DrawString(name, textFont, textBrush, rectangleF, val);
		for (int i = 0; i < containsPlayers.Length; i++)
		{
			if (containsPlayers[i])
			{
				int num3 = i % 3;
				int num4 = i / 3;
				int num5 = num3 * 28;
				int num6 = num4 * 28;
				Brush playerTokenColour = players[i].PlayerTokenColour;
				e.get_Graphics().FillEllipse(playerTokenColour, num5, num6, 20, 20);
			}
		}
	}
}
