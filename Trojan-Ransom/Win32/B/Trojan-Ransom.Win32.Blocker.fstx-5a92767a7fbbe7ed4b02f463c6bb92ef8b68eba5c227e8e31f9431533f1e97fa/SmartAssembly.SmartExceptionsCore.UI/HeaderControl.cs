using System;
using System.Drawing;
using System.Windows.Forms;

namespace SmartAssembly.SmartExceptionsCore.UI;

public class HeaderControl : Control
{
	private Label label = new Label();

	private Image image;

	private Icon applicationIcon;

	private Bitmap stateImage;

	private IconState iconState;

	private float dx = 1f;

	private float dy = 1f;

	public override string Text
	{
		get
		{
			return ((Control)label).get_Text();
		}
		set
		{
			((Control)label).set_Text(value);
		}
	}

	public IconState IconState
	{
		set
		{
			if (iconState != value)
			{
				iconState = value;
				switch (iconState)
				{
				default:
					stateImage = null;
					break;
				case IconState.Error:
					stateImage = Resources.GetBitmap("error16");
					break;
				case IconState.Warning:
					stateImage = Resources.GetBitmap("warning16");
					break;
				}
				((Control)this).Refresh();
			}
		}
	}

	protected override void Dispose(bool disposing)
	{
		if (disposing)
		{
			if (applicationIcon != null)
			{
				applicationIcon.Dispose();
				applicationIcon = null;
			}
			if (image != null)
			{
				image.Dispose();
				image = null;
			}
			if (stateImage != null)
			{
				((Image)stateImage).Dispose();
				stateImage = null;
			}
		}
		((Control)this).Dispose(disposing);
	}

	protected override void OnResize(EventArgs e)
	{
		((Control)label).SetBounds(Convert.ToInt32(13f * dx), Convert.ToInt32(15f * dy), ((Control)this).get_Width() - Convert.ToInt32(69f * dx), ((Control)this).get_Height() - Convert.ToInt32(18f * dy));
		((Control)this).OnResize(e);
	}

	protected override void ScaleCore(float x, float y)
	{
		dx = x;
		dy = y;
		((Control)this).ScaleCore(x, y);
		((Control)this).OnResize(EventArgs.Empty);
	}

	protected override void OnPaint(PaintEventArgs e)
	{
		((Control)this).OnPaint(e);
		e.get_Graphics().DrawLine(SystemPens.get_ControlDark(), 0, ((Control)this).get_ClientSize().Height - 2, ((Control)this).get_ClientSize().Width, ((Control)this).get_ClientSize().Height - 2);
		e.get_Graphics().DrawLine(SystemPens.get_ControlLightLight(), 0, ((Control)this).get_ClientSize().Height - 1, ((Control)this).get_ClientSize().Width, ((Control)this).get_ClientSize().Height - 1);
		Rectangle rectangle = new Rectangle(((Control)this).get_ClientSize().Width - Convert.ToInt32(48f * dx), Convert.ToInt32(11f * dy), Convert.ToInt32(32f * dx), Convert.ToInt32(32f * dy));
		if (image != null)
		{
			e.get_Graphics().DrawImage(image, rectangle, new Rectangle(0, 0, 32, 32), (GraphicsUnit)2);
		}
		else if (applicationIcon != null)
		{
			e.get_Graphics().DrawIcon(applicationIcon, rectangle);
			if (stateImage != null)
			{
				e.get_Graphics().DrawImage((Image)(object)stateImage, new Rectangle(rectangle.Right - Convert.ToInt32(12f * dx), rectangle.Bottom - Convert.ToInt32(12f * dy), Convert.ToInt32(16f * dx), Convert.ToInt32(16f * dy)), new Rectangle(0, 0, 16, 16), (GraphicsUnit)2);
			}
		}
	}

	protected override void OnFontChanged(EventArgs e)
	{
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Expected O, but got Unknown
		try
		{
			((Control)label).set_Font(new Font(((Control)this).get_Font(), (FontStyle)1));
			((Control)this).OnFontChanged(e);
		}
		catch
		{
		}
	}

	public HeaderControl()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected O, but got Unknown
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Expected O, but got Unknown
		try
		{
			label.set_FlatStyle((FlatStyle)3);
			((Control)label).set_Font(new Font(((Control)this).get_Font(), (FontStyle)1));
		}
		catch
		{
		}
		((Control)this).get_Controls().Add((Control)(object)label);
		((Control)this).set_BackColor(SystemColors.Window);
		((Control)this).set_TabStop(false);
		((Control)this).set_Dock((DockStyle)1);
		((Control)this).set_Height(58);
		((Control)this).SetStyle((ControlStyles)75794, true);
		applicationIcon = Win32.GetApplicationIcon();
		((Control)this).OnResize(EventArgs.Empty);
	}

	public HeaderControl(string string_0)
		: this()
	{
		((Control)label).set_Text(string_0);
	}
}
