using System;
using System.Drawing;
using System.Windows.Forms;

public sealed class GClass3 : Label
{
	public GClass3()
	{
		((Control)this).SetStyle((ControlStyles)2, true);
	}

	protected override void OnPaint(PaintEventArgs e)
	{
		//IL_0078: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Expected O, but got Unknown
		//IL_00ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f6: Expected O, but got Unknown
		SizeF sizeF = e.get_Graphics().MeasureString(((Label)this).get_Text(), Class24.font_0);
		if (((Label)this).get_Image() != null)
		{
			e.get_Graphics().DrawImage(((Label)this).get_Image(), new Point(0, 0));
		}
		Color color = default(Color);
		color = Color.FromArgb(120, ((Control)this).get_BackColor().R, ((Control)this).get_BackColor().G, ((Control)this).get_BackColor().B);
		SolidBrush val = new SolidBrush(color);
		try
		{
			e.get_Graphics().FillEllipse((Brush)(object)val, ((float)((Control)this).get_ClientSize().Width - sizeF.Width) / 2f, ((float)((Control)this).get_ClientSize().Height - sizeF.Height) / 2f, sizeF.Width, sizeF.Height);
		}
		finally
		{
			((IDisposable)val).Dispose();
		}
		Color color2 = Color.White;
		if (Class24.bool_1)
		{
			color2 = Color.Black;
		}
		SolidBrush val2 = new SolidBrush(color2);
		try
		{
			e.get_Graphics().DrawString(((Label)this).get_Text(), Class24.font_0, (Brush)(object)val2, ((float)((Control)this).get_ClientSize().Width - sizeF.Width) / 2f, ((float)((Control)this).get_ClientSize().Height - sizeF.Height) / 2f);
		}
		finally
		{
			((IDisposable)val2).Dispose();
		}
	}
}
