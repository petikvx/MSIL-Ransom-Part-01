using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.Windows.Forms;

namespace FL;

public class AVTheme : ContainerControl
{
	private Color color_0;

	private Color color_1;

	private SolidBrush solidBrush_0;

	private SolidBrush solidBrush_1;

	private Font font_0;

	private string string_0;

	private string string_1;

	private Image image_0;

	private Point point_0;

	private bool bool_0;

	private int int_0;

	public string PageName
	{
		get
		{
			return string_1;
		}
		set
		{
			string_1 = value;
			((Control)this).Invalidate();
		}
	}

	public Image PageImage
	{
		get
		{
			return image_0;
		}
		set
		{
			image_0 = value;
		}
	}

	public AVTheme()
	{
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_0051: Expected O, but got Unknown
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_0062: Expected O, but got Unknown
		//IL_00af: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b9: Expected O, but got Unknown
		Class8.t3hvLuccnmfIO();
		Class8.t3hvLuccnmfIO();
		((ContainerControl)this)._002Ector();
		color_0 = Color.FromArgb(242, 242, 242);
		color_1 = Color.FromArgb(0, 166, 208);
		solidBrush_0 = new SolidBrush(color_0);
		solidBrush_1 = new SolidBrush(color_1);
		string_1 = "Scan";
		point_0 = new Point(0, 0);
		bool_0 = false;
		int_0 = 48;
		((Control)this).set_BackColor(color_0);
		((Control)this).set_DoubleBuffered(true);
		((Control)this).set_Dock((DockStyle)5);
		font_0 = new Font("Segoe UI", 13f, (FontStyle)0);
	}

	protected override void OnMouseDown(MouseEventArgs e)
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Invalid comparison between Unknown and I4
		((Control)this).OnMouseDown(e);
		if (((int)e.get_Button() == 1048576) & new Rectangle(0, 0, ((Control)this).get_Width(), int_0).Contains(e.get_Location()))
		{
			bool_0 = true;
			point_0 = e.get_Location();
		}
	}

	protected override void OnMouseUp(MouseEventArgs e)
	{
		((Control)this).OnMouseUp(e);
		bool_0 = false;
	}

	protected override void OnMouseMove(MouseEventArgs e)
	{
		((Control)this).OnMouseMove(e);
		if (bool_0)
		{
			((Control)this).get_Parent().set_Location(Control.get_MousePosition() - (Size)point_0);
		}
	}

	protected override void OnPaint(PaintEventArgs e)
	{
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Expected O, but got Unknown
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Expected O, but got Unknown
		//IL_018b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0191: Invalid comparison between Unknown and I4
		//IL_01ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d3: Expected O, but got Unknown
		((Control)this).OnPaint(e);
		Graphics graphics = e.get_Graphics();
		graphics.set_SmoothingMode((SmoothingMode)3);
		Bitmap val = ((ContainerControl)this).get_ParentForm().get_Icon().ToBitmap();
		Image val2 = (Image)(object)val;
		string_0 = ((ContainerControl)this).get_ParentForm().get_Text();
		graphics.FillRectangle((Brush)(object)solidBrush_1, new Rectangle(0, 48, ((Control)this).get_Width(), 70));
		checked
		{
			graphics.DrawLine(new Pen((Brush)new SolidBrush(Color.FromArgb(203, 203, 203))), new Point(0, ((Control)this).get_Height() - 49), new Point(((Control)this).get_Width(), ((Control)this).get_Height() - 49));
			graphics.DrawString(string_0, font_0, Brushes.get_Black(), (float)((double)((Control)this).get_Width() / 2.0 - (double)(graphics.MeasureString(string_0, font_0).Width / 2f)), 24f - graphics.MeasureString(string_0, font_0).Height / 2f);
			graphics.DrawImage(val2, new Point((int)Math.Round((double)((Control)this).get_Width() / 2.0 - (double)(graphics.MeasureString(string_0, font_0).Width / 2f) - (double)val2.get_Width() - 2.0), (int)Math.Round((double)val2.get_Height() / 2.0 - 7.0)));
			if (unchecked((int)((ContainerControl)this).get_ParentForm().get_FormBorderStyle()) > 0)
			{
				((ContainerControl)this).get_ParentForm().set_FormBorderStyle((FormBorderStyle)0);
			}
			graphics.set_TextRenderingHint((TextRenderingHint)4);
			graphics.DrawString(string_1, new Font("Verdana", 17f, (FontStyle)0), Brushes.get_White(), 105f, 70f);
			if (image_0 != null)
			{
				graphics.DrawImage(image_0, new Point(70, (int)Math.Round(84.0 - (double)image_0.get_Height() / 2.0)));
			}
		}
	}
}
