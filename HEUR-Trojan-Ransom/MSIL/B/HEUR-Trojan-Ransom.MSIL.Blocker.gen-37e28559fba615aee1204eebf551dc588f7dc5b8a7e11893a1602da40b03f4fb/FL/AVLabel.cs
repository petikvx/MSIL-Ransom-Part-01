using System.Drawing;
using System.Drawing.Text;
using System.Windows.Forms;

namespace FL;

public class AVLabel : Control
{
	private string string_0;

	private string string_1;

	private Image image_0;

	public string String1
	{
		get
		{
			return string_0;
		}
		set
		{
			string_0 = value;
			((Control)this).Invalidate();
		}
	}

	public string String2
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

	public Image Image
	{
		get
		{
			return image_0;
		}
		set
		{
			image_0 = value;
			((Control)this).Invalidate();
		}
	}

	public AVLabel()
	{
		Class8.t3hvLuccnmfIO();
		Class8.t3hvLuccnmfIO();
		((Control)this)._002Ector();
		string_0 = "Quick Scan";
		string_1 = "/ Scan running...";
		((Control)this).set_Size(new Size(175, 25));
	}

	protected override void OnPaint(PaintEventArgs e)
	{
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Expected O, but got Unknown
		//IL_0051: Unknown result type (might be due to invalid IL or missing references)
		//IL_0072: Unknown result type (might be due to invalid IL or missing references)
		//IL_007c: Expected O, but got Unknown
		//IL_008f: Expected O, but got Unknown
		((Control)this).OnPaint(e);
		Graphics graphics = e.get_Graphics();
		graphics.set_TextRenderingHint((TextRenderingHint)4);
		graphics.DrawString(string_0, new Font("Segoe UI", 9f, (FontStyle)1), Brushes.get_DimGray(), 32f, 6f);
		graphics.DrawString(string_1, new Font("Segoe UI", 9f), Brushes.get_DimGray(), 33f + graphics.MeasureString(string_0, new Font("Segoe UI", 9f, (FontStyle)1)).Width, 6f);
		if (image_0 != null)
		{
			graphics.DrawImage(image_0, 0, 0);
		}
	}
}
