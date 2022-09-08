using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

public class CircularProgressBar : Control
{
	public enum _ProgressShape
	{
		Round,
		Flat
	}

	public enum _TextMode
	{
		None,
		Value,
		Percentage,
		Custom
	}

	private long _Value;

	private long _Maximum = 100L;

	private int _LineWitdh = 1;

	private float _BarWidth = 14f;

	private Color _ProgressColor1 = Color.Orange;

	private Color _ProgressColor2 = Color.Orange;

	private Color _LineColor = Color.Silver;

	private LinearGradientMode _GradientMode = (LinearGradientMode)2;

	private _ProgressShape ProgressShapeVal;

	private _TextMode ProgressTextMode;

	[Description("Valor Entero que determina la posision de la Barra de Progreso.")]
	[Category("Behavior")]
	public long Value
	{
		get
		{
			return _Value;
		}
		set
		{
			if (value > _Maximum)
			{
				value = _Maximum;
			}
			_Value = value;
			((Control)this).Invalidate();
		}
	}

	[Category("Behavior")]
	[Description("Obtiene o Establece el Valor Maximo de la barra de Progreso.")]
	public long Maximum
	{
		get
		{
			return _Maximum;
		}
		set
		{
			if (value < 1L)
			{
				value = 1L;
			}
			_Maximum = value;
			((Control)this).Invalidate();
		}
	}

	[Description("Color Inicial de la Barra de Progreso")]
	[Category("Appearance")]
	public Color BarColor1
	{
		get
		{
			return _ProgressColor1;
		}
		set
		{
			_ProgressColor1 = value;
			((Control)this).Invalidate();
		}
	}

	[Description("Color Final de la Barra de Progreso")]
	[Category("Appearance")]
	public Color BarColor2
	{
		get
		{
			return _ProgressColor2;
		}
		set
		{
			_ProgressColor2 = value;
			((Control)this).Invalidate();
		}
	}

	[Description("Ancho de la Barra de Progreso")]
	[Category("Appearance")]
	public float BarWidth
	{
		get
		{
			return _BarWidth;
		}
		set
		{
			_BarWidth = value;
			((Control)this).Invalidate();
		}
	}

	[Description("Modo del Gradiente de Color")]
	[Category("Appearance")]
	public LinearGradientMode GradientMode
	{
		get
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_0007: Unknown result type (might be due to invalid IL or missing references)
			return _GradientMode;
		}
		set
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			//IL_0002: Unknown result type (might be due to invalid IL or missing references)
			_GradientMode = value;
			((Control)this).Invalidate();
		}
	}

	[Category("Appearance")]
	[Description("Color de la Linea Intermedia")]
	public Color LineColor
	{
		get
		{
			return _LineColor;
		}
		set
		{
			_LineColor = value;
			((Control)this).Invalidate();
		}
	}

	[Description("Ancho de la Linea Intermedia")]
	[Category("Appearance")]
	public int LineWidth
	{
		get
		{
			return _LineWitdh;
		}
		set
		{
			_LineWitdh = value;
			((Control)this).Invalidate();
		}
	}

	[Category("Appearance")]
	[Description("Obtiene o Establece la Forma de los terminales de la barra de progreso.")]
	public _ProgressShape ProgressShape
	{
		get
		{
			return ProgressShapeVal;
		}
		set
		{
			ProgressShapeVal = value;
			((Control)this).Invalidate();
		}
	}

	[Category("Behavior")]
	[Description("Obtiene o Establece el Modo como se muestra el Texto dentro de la barra de Progreso.")]
	public _TextMode TextMode
	{
		get
		{
			return ProgressTextMode;
		}
		set
		{
			ProgressTextMode = value;
			((Control)this).Invalidate();
		}
	}

	[Category("Behavior")]
	[Description("Obtiene el Texto que se muestra dentro del Control")]
	public override string Text { get; set; }

	public CircularProgressBar()
	{
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_0099: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a3: Expected O, but got Unknown
		((Control)this).SetStyle((ControlStyles)2048, true);
		((Control)this).SetStyle((ControlStyles)4, true);
		((Control)this).set_BackColor(SystemColors.Control);
		((Control)this).set_ForeColor(Color.DimGray);
		((Control)this).set_Size(new Size(130, 130));
		((Control)this).set_Font(new Font("Segoe UI", 15f));
		((Control)this).set_MinimumSize(new Size(100, 100));
		((Control)this).set_DoubleBuffered(true);
		LineWidth = 1;
		LineColor = Color.DimGray;
		Value = 57L;
		ProgressShape = _ProgressShape.Flat;
		TextMode = _TextMode.Percentage;
	}

	protected override void OnResize(EventArgs e)
	{
		((Control)this).OnResize(e);
		SetStandardSize();
	}

	protected override void OnSizeChanged(EventArgs e)
	{
		((Control)this).OnSizeChanged(e);
		SetStandardSize();
	}

	protected override void OnPaintBackground(PaintEventArgs p)
	{
		((Control)this).OnPaintBackground(p);
	}

	private void SetStandardSize()
	{
		int num = Math.Max(((Control)this).get_Width(), ((Control)this).get_Height());
		((Control)this).set_Size(new Size(num, num));
	}

	public void Increment(int Val)
	{
		_Value += Val;
		((Control)this).Invalidate();
	}

	public void Decrement(int Val)
	{
		_Value -= Val;
		((Control)this).Invalidate();
	}

	protected override void OnPaint(PaintEventArgs e)
	{
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Expected O, but got Unknown
		//IL_008b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0091: Expected O, but got Unknown
		//IL_00d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00df: Expected O, but got Unknown
		//IL_00e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ee: Expected O, but got Unknown
		//IL_020a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0211: Expected O, but got Unknown
		//IL_0232: Unknown result type (might be due to invalid IL or missing references)
		//IL_0239: Expected O, but got Unknown
		((Control)this).OnPaint(e);
		Bitmap val = new Bitmap(((Control)this).get_Width(), ((Control)this).get_Height());
		try
		{
			Graphics val2 = Graphics.FromImage((Image)(object)val);
			try
			{
				val2.set_InterpolationMode((InterpolationMode)6);
				val2.set_CompositingQuality((CompositingQuality)2);
				val2.set_PixelOffsetMode((PixelOffsetMode)2);
				val2.set_SmoothingMode((SmoothingMode)4);
				PaintTransparentBackground((Control)(object)this, e);
				Brush val3 = (Brush)new SolidBrush(((Control)this).get_BackColor());
				try
				{
					val2.FillEllipse(val3, 18, 18, ((Control)this).get_Width() - 48 + 12, ((Control)this).get_Height() - 48 + 12);
				}
				finally
				{
					((IDisposable)val3)?.Dispose();
				}
				Pen val4 = new Pen(LineColor, (float)LineWidth);
				try
				{
					val2.DrawEllipse(val4, 18, 18, ((Control)this).get_Width() - 48 + 12, ((Control)this).get_Height() - 48 + 12);
				}
				finally
				{
					((IDisposable)val4)?.Dispose();
				}
				LinearGradientBrush val5 = new LinearGradientBrush(((Control)this).get_ClientRectangle(), _ProgressColor1, _ProgressColor2, GradientMode);
				try
				{
					Pen val6 = new Pen((Brush)(object)val5, BarWidth);
					try
					{
						switch (ProgressShapeVal)
						{
						case _ProgressShape.Flat:
							val6.set_StartCap((LineCap)0);
							val6.set_EndCap((LineCap)0);
							break;
						case _ProgressShape.Round:
							val6.set_StartCap((LineCap)2);
							val6.set_EndCap((LineCap)2);
							break;
						}
						val2.DrawArc(val6, 18, 18, ((Control)this).get_Width() - 35 - 2, ((Control)this).get_Height() - 35 - 2, -90, (int)Math.Round(360.0 / (double)_Maximum * (double)_Value));
					}
					finally
					{
						((IDisposable)val6)?.Dispose();
					}
				}
				finally
				{
					((IDisposable)val5)?.Dispose();
				}
				switch (TextMode)
				{
				case _TextMode.None:
					((Control)this).set_Text(string.Empty);
					break;
				case _TextMode.Value:
					((Control)this).set_Text(_Value.ToString());
					break;
				case _TextMode.Percentage:
					((Control)this).set_Text(Convert.ToString(Convert.ToInt32(100L / _Maximum * _Value)));
					break;
				}
				if (((Control)this).get_Text() != string.Empty)
				{
					Brush val7 = (Brush)new SolidBrush(((Control)this).get_ForeColor());
					try
					{
						SizeF sizeF = val2.MeasureString(((Control)this).get_Text(), ((Control)this).get_Font());
						SolidBrush val8 = new SolidBrush(Color.FromArgb(100, ((Control)this).get_ForeColor()));
						val2.DrawString(((Control)this).get_Text(), ((Control)this).get_Font(), (Brush)(object)val8, (float)(Convert.ToInt32((float)(((Control)this).get_Width() / 2) - sizeF.Width / 2f) + 2), (float)(Convert.ToInt32((float)(((Control)this).get_Height() / 2) - sizeF.Height / 2f) + 2));
						val2.DrawString(((Control)this).get_Text(), ((Control)this).get_Font(), val7, (float)Convert.ToInt32((float)(((Control)this).get_Width() / 2) - sizeF.Width / 2f), (float)Convert.ToInt32((float)(((Control)this).get_Height() / 2) - sizeF.Height / 2f));
					}
					finally
					{
						((IDisposable)val7)?.Dispose();
					}
				}
				e.get_Graphics().DrawImage((Image)(object)val, 0, 0);
				val2.Dispose();
				((Image)val).Dispose();
			}
			finally
			{
				((IDisposable)val2)?.Dispose();
			}
		}
		finally
		{
			((IDisposable)val)?.Dispose();
		}
	}

	private static void PaintTransparentBackground(Control c, PaintEventArgs e)
	{
		if (c.get_Parent() != null && Application.get_RenderWithVisualStyles())
		{
			ButtonRenderer.DrawParentBackground(e.get_Graphics(), c.get_ClientRectangle(), c);
		}
	}

	private void FillCircle(Graphics g, Brush brush, float centerX, float centerY, float radius)
	{
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Expected O, but got Unknown
		g.set_InterpolationMode((InterpolationMode)6);
		g.set_CompositingQuality((CompositingQuality)2);
		g.set_PixelOffsetMode((PixelOffsetMode)2);
		g.set_SmoothingMode((SmoothingMode)4);
		GraphicsPath val = new GraphicsPath();
		try
		{
			g.FillEllipse(brush, centerX - radius, centerY - radius, radius + radius, radius + radius);
		}
		finally
		{
			((IDisposable)val)?.Dispose();
		}
	}
}
