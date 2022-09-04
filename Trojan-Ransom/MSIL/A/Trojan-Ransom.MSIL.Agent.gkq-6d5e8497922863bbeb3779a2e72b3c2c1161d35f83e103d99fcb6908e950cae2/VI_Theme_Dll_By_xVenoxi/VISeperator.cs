using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace VI_Theme_Dll_By_xVenoxi;

public class VISeperator : ThemeControl154
{
	private Orientation _Orientation;

	public Orientation Orientation
	{
		get
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_0007: Unknown result type (might be due to invalid IL or missing references)
			return _Orientation;
		}
		set
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			//IL_0002: Unknown result type (might be due to invalid IL or missing references)
			//IL_0007: Unknown result type (might be due to invalid IL or missing references)
			//IL_0009: Invalid comparison between Unknown and I4
			_Orientation = value;
			if ((int)value == 1)
			{
				LockHeight = 0;
				LockWidth = 14;
			}
			else
			{
				LockHeight = 14;
				LockWidth = 0;
			}
			((Control)this).Invalidate();
		}
	}

	public VISeperator()
	{
		Transparent = true;
		BackColor = Color.Transparent;
		LockHeight = 14;
	}

	protected override void ColorHook()
	{
	}

	protected override void PaintHook()
	{
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Expected O, but got Unknown
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0149: Unknown result type (might be due to invalid IL or missing references)
		//IL_014f: Invalid comparison between Unknown and I4
		G.Clear(BackColor);
		ColorBlend val = new ColorBlend();
		ColorBlend val2 = new ColorBlend();
		val.set_Positions(new float[4] { 0f, 0.15f, 0.85f, 1f });
		val2.set_Positions(new float[5] { 0f, 0.15f, 0.5f, 0.85f, 1f });
		val.set_Colors(new Color[4]
		{
			Color.Transparent,
			Color.Black,
			Color.Black,
			Color.Transparent
		});
		val2.set_Colors(new Color[5]
		{
			Color.Transparent,
			Color.FromArgb(24, 24, 24),
			Color.FromArgb(40, 40, 40),
			Color.FromArgb(36, 36, 36),
			Color.Transparent
		});
		if ((int)_Orientation == 1)
		{
			DrawGradient(val, 6, 0, 1, ((Control)this).get_Height());
			DrawGradient(val2, 7, 0, 1, ((Control)this).get_Height());
		}
		else
		{
			DrawGradient(val, 0, 6, ((Control)this).get_Width(), 1, 0f);
			DrawGradient(val2, 0, 7, ((Control)this).get_Width(), 1, 0f);
		}
	}
}
