using System;
using System.Drawing;
using System.Drawing.Text;
using System.Windows.Forms;

namespace ns1;

public class EtherealTheme : ContainerControl
{
	public enum TitlePostion
	{
		Left,
		Center
	}

	private bool bool_0;

	private TitlePostion titlePostion_0;

	private static Point point_0 = new Point(0, 0);

	private int int_0 = 50;

	private bool bool_1;

	private Color color_0 = HelperMethods.smethod_11(" ");

	private Color color_1 = Color.White;

	internal Color color_2;

	public bool ShowIcon
	{
		get
		{
			return bool_1;
		}
		set
		{
			if (value != bool_1)
			{
				((Control)this).FindForm().set_ShowIcon(value);
				((Control)this).Invalidate();
				bool_1 = value;
			}
		}
	}

	public TitlePostion TitleTextPostion
	{
		get
		{
			return titlePostion_0;
		}
		set
		{
			titlePostion_0 = value;
			((Control)this).Invalidate();
		}
	}

	public Color HeaderColor
	{
		get
		{
			return color_0;
		}
		set
		{
			color_0 = value;
			((Control)this).Invalidate();
		}
	}

	public override Color BackColor
	{
		get
		{
			return color_1;
		}
		set
		{
			color_1 = value;
			((Control)this).set_BackColor(value);
			((Control)this).Invalidate();
		}
	}

	public Color BorderColor
	{
		get
		{
			return color_2;
		}
		set
		{
			Color color = (color_2 = value);
			((Control)this).Invalidate();
		}
	}

	internal static byte smethod_0(byte[] byte_0, int int_1)
	{
		return byte_0[int_1 % byte_0.Length];
	}

	public EtherealTheme()
	{
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Expected O, but got Unknown
		Color color = (color_2 = HelperMethods.smethod_11(" "));
		((ContainerControl)this)._002Ector();
		((Control)this).SetStyle((ControlStyles)141330, true);
		((Control)this).set_DoubleBuffered(true);
		((Control)this).UpdateStyles();
		((Control)this).set_Font(new Font(" ", 14f, (FontStyle)1));
	}

	protected override void vmethod_0()
	{
		((ContainerControl)this).OnCreateControl();
		((ContainerControl)this).get_ParentForm().set_FormBorderStyle((FormBorderStyle)0);
		((ContainerControl)this).get_ParentForm().set_TransparencyKey(Color.Fuchsia);
		((Control)this).set_Dock((DockStyle)5);
	}

	protected override void vmethod_1(MouseEventArgs mouseEventArgs_0)
	{
		((Control)this).OnMouseMove(mouseEventArgs_0);
		int x = Control.get_MousePosition().X;
		int y = Control.get_MousePosition().Y;
		int x2 = point_0.X;
		int y2 = point_0.Y;
		if (bool_0)
		{
			((Control)this).get_Parent().set_Location(new Point(x - x2, y - y2));
		}
		((Control)this).Focus();
	}

	protected override void vmethod_2(MouseEventArgs mouseEventArgs_0)
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Invalid comparison between Unknown and I4
		((Control)this).OnMouseDown(mouseEventArgs_0);
		if ((int)mouseEventArgs_0.get_Button() == 1048576 && new Rectangle(0, 0, ((Control)this).get_Width(), int_0).Contains(mouseEventArgs_0.get_Location()))
		{
			bool_0 = true;
			point_0 = mouseEventArgs_0.get_Location();
		}
	}

	protected override void vmethod_3(MouseEventArgs mouseEventArgs_0)
	{
		((Control)this).OnMouseUp(mouseEventArgs_0);
		bool_0 = false;
	}

	protected override void vmethod_4(PaintEventArgs paintEventArgs_0)
	{
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Expected O, but got Unknown
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0073: Expected O, but got Unknown
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a0: Expected O, but got Unknown
		//IL_018d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0199: Expected O, but got Unknown
		((Control)this).OnPaint(paintEventArgs_0);
		new Rectangle(1, 1, (int)((double)((Control)this).get_Width() - 2.5), (int)((double)((Control)this).get_Height() - 2.5));
		Bitmap val = new Bitmap(((Control)this).get_Width(), ((Control)this).get_Height());
		Graphics val2 = Graphics.FromImage((Image)(object)val);
		try
		{
			val2.set_TextRenderingHint((TextRenderingHint)5);
			HelperMethods.smethod_18(val2, (Brush)new SolidBrush(HeaderColor), new Rectangle(0, 0, ((Control)this).get_Width(), 50));
			val2.DrawRectangle(new Pen(BorderColor, 2f), new Rectangle(1, 1, ((Control)this).get_Width() - 2, ((Control)this).get_Height() - 2));
			if (((Control)this).FindForm().get_ShowIcon())
			{
				val2.DrawIcon(((Control)this).FindForm().get_Icon(), new Rectangle(5, 13, 20, 20));
				switch (TitleTextPostion)
				{
				case TitlePostion.Center:
					HelperMethods.smethod_16(val2, ((Control)this).get_Text(), ((Control)this).get_Font(), Brushes.get_White(), new Rectangle(0, 0, ((Control)this).get_Width(), 50));
					break;
				case TitlePostion.Left:
					val2.DrawString(((Control)this).get_Text(), ((Control)this).get_Font(), Brushes.get_White(), 27f, 10f);
					break;
				}
			}
			else
			{
				switch (TitleTextPostion)
				{
				case TitlePostion.Center:
					HelperMethods.smethod_16(val2, ((Control)this).get_Text(), ((Control)this).get_Font(), Brushes.get_White(), new Rectangle(0, 0, ((Control)this).get_Width(), 50));
					break;
				case TitlePostion.Left:
					val2.DrawString(((Control)this).get_Text(), ((Control)this).get_Font(), Brushes.get_White(), 5f, 10f);
					break;
				}
			}
			paintEventArgs_0.get_Graphics().DrawImage((Image)((Image)val).Clone(), 0, 0);
			val2.Dispose();
			((Image)val).Dispose();
		}
		finally
		{
			((IDisposable)val2)?.Dispose();
		}
	}
}
