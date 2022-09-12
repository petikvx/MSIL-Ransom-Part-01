using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.Windows.Forms;
using MetroFramework.Drawing;

namespace MetroFramework.Controls;

[Designer("MetroFramework.Design.MetroTileDesigner, MetroFramework.Design, Version=1.2.0.3, Culture=neutral, PublicKeyToken=5f91a84759bf584a")]
[ToolboxBitmap(typeof(Button))]
public class MetroTile : MetroButtonBase, IContainerControl
{
	private Control activeControl;

	private bool useCustomBackground;

	private bool useCustomForeColor;

	private bool paintTileCount = true;

	private int tileCount;

	private Image tileImage;

	private bool useTileImage;

	private ContentAlignment tileImageAlign = (ContentAlignment)1;

	private MetroTileTextSize tileTextFontSize = MetroTileTextSize.Medium;

	private MetroTileTextWeight tileTextFontWeight;

	private bool isHovered;

	private bool isPressed;

	private bool isFocused;

	[Browsable(false)]
	[DefaultValue(null)]
	public Control ActiveControl
	{
		get
		{
			return activeControl;
		}
		set
		{
			activeControl = value;
		}
	}

	[Category("Metro Appearance")]
	[DefaultValue(false)]
	public bool CustomBackground
	{
		get
		{
			return useCustomBackground;
		}
		set
		{
			useCustomBackground = value;
		}
	}

	[DefaultValue(false)]
	[Category("Metro Appearance")]
	public bool CustomForeColor
	{
		get
		{
			return useCustomForeColor;
		}
		set
		{
			useCustomForeColor = value;
		}
	}

	[Category("Metro Appearance")]
	[DefaultValue(true)]
	public bool PaintTileCount
	{
		get
		{
			return paintTileCount;
		}
		set
		{
			paintTileCount = value;
		}
	}

	[DefaultValue(0)]
	public int TileCount
	{
		get
		{
			return tileCount;
		}
		set
		{
			tileCount = value;
		}
	}

	[DefaultValue(/*Could not decode attribute arguments.*/)]
	public ContentAlignment TextAlign
	{
		get
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			return ((ButtonBase)this).get_TextAlign();
		}
		set
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			((ButtonBase)this).set_TextAlign(value);
		}
	}

	[DefaultValue(null)]
	[Category("Metro Appearance")]
	public Image TileImage
	{
		get
		{
			return tileImage;
		}
		set
		{
			tileImage = value;
		}
	}

	[Category("Metro Appearance")]
	[DefaultValue(false)]
	public bool UseTileImage
	{
		get
		{
			return useTileImage;
		}
		set
		{
			useTileImage = value;
		}
	}

	[Category("Metro Appearance")]
	[DefaultValue(/*Could not decode attribute arguments.*/)]
	public ContentAlignment TileImageAlign
	{
		get
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			return tileImageAlign;
		}
		set
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			//IL_0002: Unknown result type (might be due to invalid IL or missing references)
			tileImageAlign = value;
		}
	}

	[Category("Metro Appearance")]
	[DefaultValue(MetroTileTextSize.Medium)]
	public MetroTileTextSize TileTextFontSize
	{
		get
		{
			return tileTextFontSize;
		}
		set
		{
			tileTextFontSize = value;
			((Control)this).Refresh();
		}
	}

	[Category("Metro Appearance")]
	[DefaultValue(MetroTileTextWeight.Light)]
	public MetroTileTextWeight TileTextFontWeight
	{
		get
		{
			return tileTextFontWeight;
		}
		set
		{
			tileTextFontWeight = value;
			((Control)this).Refresh();
		}
	}

	public bool ActivateControl(Control ctrl)
	{
		if (((Control)this).get_Controls().Contains(ctrl))
		{
			ctrl.Select();
			activeControl = ctrl;
			return true;
		}
		return false;
	}

	public MetroTile()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		((Control)this).SetStyle((ControlStyles)139282, true);
		TextAlign = (ContentAlignment)256;
	}

	protected override void OnPaint(PaintEventArgs e)
	{
		//IL_00e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e6: Expected O, but got Unknown
		//IL_018b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0190: Unknown result type (might be due to invalid IL or missing references)
		//IL_0192: Unknown result type (might be due to invalid IL or missing references)
		//IL_0196: Invalid comparison between Unknown and I4
		//IL_019b: Unknown result type (might be due to invalid IL or missing references)
		//IL_019e: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b4: Expected I4, but got Unknown
		//IL_01b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b8: Invalid comparison between Unknown and I4
		//IL_01ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_01be: Invalid comparison between Unknown and I4
		//IL_0310: Unknown result type (might be due to invalid IL or missing references)
		//IL_0317: Invalid comparison between Unknown and I4
		//IL_031c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0320: Invalid comparison between Unknown and I4
		//IL_0322: Unknown result type (might be due to invalid IL or missing references)
		//IL_0329: Invalid comparison between Unknown and I4
		//IL_03c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ca: Invalid comparison between Unknown and I4
		//IL_03cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d6: Invalid comparison between Unknown and I4
		//IL_054f: Unknown result type (might be due to invalid IL or missing references)
		//IL_055a: Unknown result type (might be due to invalid IL or missing references)
		//IL_055f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0561: Unknown result type (might be due to invalid IL or missing references)
		//IL_0565: Invalid comparison between Unknown and I4
		//IL_0567: Unknown result type (might be due to invalid IL or missing references)
		//IL_056a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0580: Expected I4, but got Unknown
		//IL_0580: Unknown result type (might be due to invalid IL or missing references)
		//IL_0584: Invalid comparison between Unknown and I4
		//IL_0586: Unknown result type (might be due to invalid IL or missing references)
		//IL_058a: Invalid comparison between Unknown and I4
		//IL_058e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0591: Unknown result type (might be due to invalid IL or missing references)
		//IL_0592: Unknown result type (might be due to invalid IL or missing references)
		//IL_0594: Unknown result type (might be due to invalid IL or missing references)
		//IL_0597: Unknown result type (might be due to invalid IL or missing references)
		//IL_0598: Unknown result type (might be due to invalid IL or missing references)
		//IL_059f: Unknown result type (might be due to invalid IL or missing references)
		//IL_05a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_05a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_05a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_05a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_05ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_05b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_05b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_05b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_05b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_05ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_05bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_05bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_05c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_05c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_05c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_05c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_05cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_05cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_05d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_05d7: Invalid comparison between Unknown and I4
		//IL_05d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_05dd: Invalid comparison between Unknown and I4
		//IL_05df: Unknown result type (might be due to invalid IL or missing references)
		//IL_05e6: Invalid comparison between Unknown and I4
		//IL_05ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_05ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_05ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_05f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_05f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_05f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_05f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_05ff: Invalid comparison between Unknown and I4
		//IL_0601: Unknown result type (might be due to invalid IL or missing references)
		//IL_0608: Invalid comparison between Unknown and I4
		//IL_060a: Unknown result type (might be due to invalid IL or missing references)
		//IL_060d: Unknown result type (might be due to invalid IL or missing references)
		//IL_060e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0610: Unknown result type (might be due to invalid IL or missing references)
		//IL_0612: Unknown result type (might be due to invalid IL or missing references)
		//IL_0616: Unknown result type (might be due to invalid IL or missing references)
		//IL_0619: Unknown result type (might be due to invalid IL or missing references)
		//IL_061a: Unknown result type (might be due to invalid IL or missing references)
		//IL_061c: Unknown result type (might be due to invalid IL or missing references)
		//IL_061f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0620: Unknown result type (might be due to invalid IL or missing references)
		//IL_0624: Unknown result type (might be due to invalid IL or missing references)
		//IL_0627: Unknown result type (might be due to invalid IL or missing references)
		//IL_0628: Unknown result type (might be due to invalid IL or missing references)
		//IL_062a: Unknown result type (might be due to invalid IL or missing references)
		//IL_062d: Unknown result type (might be due to invalid IL or missing references)
		//IL_062e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0650: Unknown result type (might be due to invalid IL or missing references)
		Color color = MetroPaint.GetStyleColor(base.Style);
		if (useCustomBackground)
		{
			color = ((Control)this).get_BackColor();
		}
		Color color2 = ((isHovered && !isPressed && ((Control)this).get_Enabled()) ? MetroPaint.ForeColor.Tile.Hover(base.Theme) : ((isHovered && isPressed && ((Control)this).get_Enabled()) ? MetroPaint.ForeColor.Tile.Press(base.Theme) : (((Control)this).get_Enabled() ? MetroPaint.ForeColor.Tile.Normal(base.Theme) : MetroPaint.ForeColor.Tile.Disabled(base.Theme))));
		if (useCustomForeColor)
		{
			color2 = ((Control)this).get_ForeColor();
		}
		e.get_Graphics().set_SmoothingMode((SmoothingMode)2);
		e.get_Graphics().set_CompositingQuality((CompositingQuality)2);
		if (!isPressed)
		{
			e.get_Graphics().Clear(color);
		}
		else
		{
			e.get_Graphics().Clear(MetroPaint.BackColor.Form(base.Theme));
			SolidBrush val = new SolidBrush(color);
			try
			{
				Point[] array = new Point[4]
				{
					new Point(0, 0),
					new Point(((Control)this).get_Width() - 1, 2),
					new Point(((Control)this).get_Width() - 1, ((Control)this).get_Height() - 2),
					new Point(0, ((Control)this).get_Height())
				};
				e.get_Graphics().FillPolygon((Brush)(object)val, array);
			}
			finally
			{
				((IDisposable)val)?.Dispose();
			}
		}
		Rectangle rectangle;
		if (useTileImage && tileImage != null)
		{
			ContentAlignment val2 = tileImageAlign;
			if ((int)val2 <= 32)
			{
				switch (val2 - 1)
				{
				case 0:
					goto IL_0260;
				case 1:
					goto IL_028e;
				case 3:
					goto IL_02d1;
				case 2:
					goto IL_03d8;
				}
				if ((int)val2 != 16)
				{
					if ((int)val2 != 32)
					{
						goto IL_03d8;
					}
					rectangle = new Rectangle(new Point(((Control)this).get_Width() / 2 - TileImage.get_Width() / 2, ((Control)this).get_Height() / 2 - TileImage.get_Height() / 2), new Size(TileImage.get_Width(), TileImage.get_Height()));
				}
				else
				{
					rectangle = new Rectangle(new Point(0, ((Control)this).get_Height() / 2 - TileImage.get_Height() / 2), new Size(TileImage.get_Width(), TileImage.get_Height()));
				}
			}
			else if ((int)val2 <= 256)
			{
				if ((int)val2 != 64)
				{
					if ((int)val2 != 256)
					{
						goto IL_03d8;
					}
					rectangle = new Rectangle(new Point(0, ((Control)this).get_Height() - TileImage.get_Height()), new Size(TileImage.get_Width(), TileImage.get_Height()));
				}
				else
				{
					rectangle = new Rectangle(new Point(((Control)this).get_Width() - TileImage.get_Width(), ((Control)this).get_Height() / 2 - TileImage.get_Height() / 2), new Size(TileImage.get_Width(), TileImage.get_Height()));
				}
			}
			else if ((int)val2 != 512)
			{
				if ((int)val2 != 1024)
				{
					goto IL_03d8;
				}
				rectangle = new Rectangle(new Point(((Control)this).get_Width() - TileImage.get_Width(), ((Control)this).get_Height() - TileImage.get_Height()), new Size(TileImage.get_Width(), TileImage.get_Height()));
			}
			else
			{
				rectangle = new Rectangle(new Point(((Control)this).get_Width() / 2 - TileImage.get_Width() / 2, ((Control)this).get_Height() - TileImage.get_Height()), new Size(TileImage.get_Width(), TileImage.get_Height()));
			}
			goto IL_04a2;
		}
		goto IL_04b5;
		IL_02d1:
		rectangle = new Rectangle(new Point(((Control)this).get_Width() - TileImage.get_Width(), 0), new Size(TileImage.get_Width(), TileImage.get_Height()));
		goto IL_04a2;
		IL_05ae:
		TextFormatFlags val3 = val3;
		val3 = val3;
		goto IL_0630;
		IL_0260:
		rectangle = new Rectangle(new Point(0, 0), new Size(TileImage.get_Width(), TileImage.get_Height()));
		goto IL_04a2;
		IL_0630:
		Rectangle clientRectangle;
		TextRenderer.DrawText((IDeviceContext)(object)e.get_Graphics(), ((Control)this).get_Text(), MetroFonts.Tile(tileTextFontSize, tileTextFontWeight), clientRectangle, color2, val3);
		return;
		IL_028e:
		rectangle = new Rectangle(new Point(((Control)this).get_Width() / 2 - TileImage.get_Width() / 2, 0), new Size(TileImage.get_Width(), TileImage.get_Height()));
		goto IL_04a2;
		IL_03d8:
		rectangle = new Rectangle(new Point(0, 0), new Size(TileImage.get_Width(), TileImage.get_Height()));
		goto IL_04a2;
		IL_04b5:
		if (TileCount > 0 && paintTileCount)
		{
			Size size = TextRenderer.MeasureText(TileCount.ToString(), MetroFonts.TileCount);
			e.get_Graphics().set_TextRenderingHint((TextRenderingHint)4);
			TextRenderer.DrawText((IDeviceContext)(object)e.get_Graphics(), TileCount.ToString(), MetroFonts.TileCount, new Point(((Control)this).get_Width() - size.Width, 0), color2);
			e.get_Graphics().set_TextRenderingHint((TextRenderingHint)0);
		}
		TextRenderer.MeasureText(((Control)this).get_Text(), MetroFonts.Tile(tileTextFontSize, tileTextFontWeight));
		val3 = (TextFormatFlags)536903680;
		clientRectangle = ((Control)this).get_ClientRectangle();
		ContentAlignment textAlign = TextAlign;
		if ((int)textAlign <= 32)
		{
			switch (textAlign - 1)
			{
			case 0:
				goto IL_05ae;
			case 1:
				goto IL_05b8;
			case 3:
				goto IL_05c4;
			case 2:
				goto IL_060a;
			}
			if ((int)textAlign != 16)
			{
				if ((int)textAlign != 32)
				{
					goto IL_060a;
				}
				val3 = (TextFormatFlags)(val3 | 4);
				val3 = (TextFormatFlags)(val3 | 1);
			}
			else
			{
				val3 = (TextFormatFlags)(val3 | 4);
				val3 = val3;
			}
		}
		else if ((int)textAlign <= 256)
		{
			if ((int)textAlign != 64)
			{
				if ((int)textAlign == 256)
				{
				}
				goto IL_060a;
			}
			val3 = (TextFormatFlags)(val3 | 4);
			val3 = (TextFormatFlags)(val3 | 2);
		}
		else if ((int)textAlign != 512)
		{
			if ((int)textAlign != 1024)
			{
				goto IL_060a;
			}
			val3 = (TextFormatFlags)(val3 | 8);
			val3 = (TextFormatFlags)(val3 | 2);
		}
		else
		{
			val3 = (TextFormatFlags)(val3 | 8);
			val3 = (TextFormatFlags)(val3 | 1);
		}
		goto IL_0630;
		IL_060a:
		val3 = (TextFormatFlags)(val3 | 8);
		val3 = val3;
		goto IL_0630;
		IL_04a2:
		e.get_Graphics().DrawImage(TileImage, rectangle);
		goto IL_04b5;
		IL_05c4:
		val3 = val3;
		val3 = (TextFormatFlags)(val3 | 2);
		goto IL_0630;
		IL_05b8:
		val3 = val3;
		val3 = (TextFormatFlags)(val3 | 1);
		goto IL_0630;
	}

	protected override void OnGotFocus(EventArgs e)
	{
		isFocused = true;
		((Control)this).Invalidate();
		((ButtonBase)this).OnGotFocus(e);
	}

	protected override void OnLostFocus(EventArgs e)
	{
		isFocused = false;
		isHovered = false;
		isPressed = false;
		((Control)this).Invalidate();
		((ButtonBase)this).OnLostFocus(e);
	}

	protected override void OnEnter(EventArgs e)
	{
		isFocused = true;
		((Control)this).Invalidate();
		((Control)this).OnEnter(e);
	}

	protected override void OnLeave(EventArgs e)
	{
		isFocused = false;
		isHovered = false;
		isPressed = false;
		((Control)this).Invalidate();
		((Control)this).OnLeave(e);
	}

	protected override void OnKeyDown(KeyEventArgs e)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Invalid comparison between Unknown and I4
		if ((int)e.get_KeyCode() == 32)
		{
			isHovered = true;
			isPressed = true;
			((Control)this).Invalidate();
		}
		((ButtonBase)this).OnKeyDown(e);
	}

	protected override void OnKeyUp(KeyEventArgs e)
	{
		isHovered = false;
		isPressed = false;
		((Control)this).Invalidate();
		((ButtonBase)this).OnKeyUp(e);
	}

	protected override void OnMouseEnter(EventArgs e)
	{
		isHovered = true;
		((Control)this).Invalidate();
		((Button)this).OnMouseEnter(e);
	}

	protected override void OnMouseDown(MouseEventArgs e)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Invalid comparison between Unknown and I4
		if ((int)e.get_Button() == 1048576)
		{
			isPressed = true;
			((Control)this).Invalidate();
		}
		((ButtonBase)this).OnMouseDown(e);
	}

	protected override void OnMouseUp(MouseEventArgs e)
	{
		isPressed = false;
		((Control)this).Invalidate();
		((Button)this).OnMouseUp(e);
	}

	protected override void OnMouseLeave(EventArgs e)
	{
		isHovered = false;
		((Control)this).Invalidate();
		((Button)this).OnMouseLeave(e);
	}

	protected override void OnEnabledChanged(EventArgs e)
	{
		((ButtonBase)this).OnEnabledChanged(e);
		((Control)this).Invalidate();
	}
}
