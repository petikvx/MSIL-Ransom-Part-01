using System.ComponentModel;
using System.ComponentModel.Design;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

[Designer("System.Windows.Forms.Design.ParentControlDesigner,System.Design", typeof(IDesigner))]
public class GControl8 : GControl2
{
	public GControl8()
	{
		if (1 == 0)
		{
		}
		base._002Ector();
		((Control)this).SetStyle((ControlStyles)16, true);
		((Control)this).SetStyle((ControlStyles)1, true);
		((Control)this).set_DoubleBuffered(true);
		((Control)this).set_BackColor(Color.Transparent);
	}

	protected override void vmethod_0()
	{
	}

	protected override void vmethod_1()
	{
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Expected O, but got Unknown
		//IL_008a: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ec: Expected O, but got Unknown
		//IL_0104: Unknown result type (might be due to invalid IL or missing references)
		//IL_0146: Expected O, but got Unknown
		//IL_0162: Unknown result type (might be due to invalid IL or missing references)
		//IL_017a: Expected O, but got Unknown
		//IL_01a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01aa: Expected O, but got Unknown
		//IL_01be: Unknown result type (might be due to invalid IL or missing references)
		//IL_01db: Expected O, but got Unknown
		//IL_01f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fd: Expected O, but got Unknown
		graphics_0.Clear(Color.FromArgb(60, 60, 60));
		int num = 0;
		HatchBrush val = default(HatchBrush);
		while (true)
		{
			switch (num)
			{
			case 10:
				graphics_0.DrawString(((Control)this).get_Text(), ((Control)this).get_Font(), Brushes.get_White(), 5f, 5f);
				num = 11;
				break;
			case 9:
				method_32(new Pen(Color.FromArgb(90, 90, 90)), 1);
				num = 10;
				break;
			case 8:
				method_35(Pens.get_Black());
				num = 9;
				break;
			case 7:
				graphics_0.DrawLine(new Pen(Color.FromArgb(90, 90, 90)), 1f, ((Control)this).CreateGraphics().MeasureString(((Control)this).get_Text(), ((Control)this).get_Font()).Height + 8f, (float)(((Control)this).get_Width() - 2), ((Control)this).CreateGraphics().MeasureString(((Control)this).get_Text(), ((Control)this).get_Font()).Height + 8f);
				num = 8;
				break;
			case 6:
				graphics_0.FillRectangle((Brush)new SolidBrush(Color.FromArgb(70, Color.Black)), 1f, 1f, (float)(((Control)this).get_Width() - 2), ((Control)this).CreateGraphics().MeasureString(((Control)this).get_Text(), ((Control)this).get_Font()).Height + 8f);
				num = 7;
				break;
			case 5:
				graphics_0.FillRectangle((Brush)new SolidBrush(Color.FromArgb(230, 20, 20, 20)), 0, 0, ((Control)this).get_Width(), ((Control)this).get_Height());
				num = 6;
				break;
			case 4:
				graphics_0.FillRectangle((Brush)(object)val, 0, 0, ((Control)this).get_Width(), ((Control)this).get_Height());
				num = 5;
				break;
			case 3:
				val = new HatchBrush((HatchStyle)18, Color.DimGray);
				num = 4;
				break;
			case 2:
				graphics_0.FillRectangle((Brush)new SolidBrush(Color.FromArgb(60, 60, 60)), new Rectangle(0, 0, ((Control)this).get_Width(), ((Control)this).get_Height()));
				num = 3;
				break;
			case 1:
				val = new HatchBrush((HatchStyle)20, Color.FromArgb(35, Color.Black), Color.FromArgb(0, Color.Gray));
				num = 2;
				break;
			case 0:
				val = null;
				num = 1;
				break;
			default:
				return;
			}
		}
	}
}
