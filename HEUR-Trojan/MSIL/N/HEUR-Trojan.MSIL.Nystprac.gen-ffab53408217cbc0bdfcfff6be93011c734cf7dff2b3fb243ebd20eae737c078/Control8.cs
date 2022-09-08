using System.ComponentModel;
using System.ComponentModel.Design;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

[Designer("System.Windows.Forms.Design.ParentControlDesigner,System.Design", typeof(IDesigner))]
internal class Control8 : Control2
{
	public Control8()
	{
		Class14.hYiyYvszsKHjE();
		base._002Ector();
		((Control)this).SetStyle((ControlStyles)16, true);
		((Control)this).SetStyle((ControlStyles)1, true);
		((Control)this).set_DoubleBuffered(true);
		BackColor = Color.Transparent;
	}

	protected override void ColorHook()
	{
	}

	protected override void PaintHook()
	{
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Expected O, but got Unknown
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_0066: Expected O, but got Unknown
		//IL_006d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0073: Expected O, but got Unknown
		//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bb: Expected O, but got Unknown
		//IL_00cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_010f: Expected O, but got Unknown
		//IL_0120: Unknown result type (might be due to invalid IL or missing references)
		//IL_0182: Expected O, but got Unknown
		//IL_0199: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a4: Expected O, but got Unknown
		graphics_0.Clear(Color.FromArgb(60, 60, 60));
		HatchBrush val = new HatchBrush((HatchStyle)20, Color.FromArgb(35, Color.Black), Color.FromArgb(0, Color.Gray));
		Graphics obj = graphics_0;
		SolidBrush val2 = new SolidBrush(Color.FromArgb(60, 60, 60));
		Rectangle rectangle = new Rectangle(0, 0, ((Control)this).get_Width(), ((Control)this).get_Height());
		obj.FillRectangle((Brush)val2, rectangle);
		val = new HatchBrush((HatchStyle)18, Color.DimGray);
		graphics_0.FillRectangle((Brush)(object)val, 0, 0, ((Control)this).get_Width(), ((Control)this).get_Height());
		graphics_0.FillRectangle((Brush)new SolidBrush(Color.FromArgb(230, 20, 20, 20)), 0, 0, ((Control)this).get_Width(), ((Control)this).get_Height());
		checked
		{
			graphics_0.FillRectangle((Brush)new SolidBrush(Color.FromArgb(70, Color.Black)), 1f, 1f, (float)(((Control)this).get_Width() - 2), ((Control)this).CreateGraphics().MeasureString(Text, Font).Height + 8f);
			graphics_0.DrawLine(new Pen(Color.FromArgb(90, 90, 90)), 1f, ((Control)this).CreateGraphics().MeasureString(Text, Font).Height + 8f, (float)(((Control)this).get_Width() - 2), ((Control)this).CreateGraphics().MeasureString(Text, Font).Height + 8f);
			method_50(Pens.get_Black());
			method_47(new Pen(Color.FromArgb(90, 90, 90)), 1);
			graphics_0.DrawString(Text, Font, Brushes.get_White(), 5f, 5f);
		}
	}
}
