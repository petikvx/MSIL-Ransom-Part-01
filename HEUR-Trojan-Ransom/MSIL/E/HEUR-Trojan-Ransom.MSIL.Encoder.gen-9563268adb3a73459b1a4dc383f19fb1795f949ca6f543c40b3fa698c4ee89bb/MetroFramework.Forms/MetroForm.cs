using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Drawing.Text;
using System.Security;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using MetroFramework.Controls;
using MetroFramework.Drawing;
using MetroFramework.Interfaces;
using MetroFramework.Native;

namespace MetroFramework.Forms;

public class MetroForm : MetroFormBase, IDisposable, IContainerControl, IMetroControl, IMetroComponent, IMetroStyledComponent, IMetroContainerControl, IMetroForm
{
	private enum WindowButtons
	{
		Minimize,
		Maximize,
		Close
	}

	private class MetroFormButton : MetroButtonBase
	{
		private bool isHovered;

		private bool isPressed;

		public MetroFormButton()
		{
			((Control)this).SetStyle((ControlStyles)139282, true);
		}

		protected override void OnPaint(PaintEventArgs e)
		{
			//IL_0100: Unknown result type (might be due to invalid IL or missing references)
			//IL_0106: Expected O, but got Unknown
			Color color = ((((Control)this).get_Parent() == null) ? MetroPaint.BackColor.Form(base.Theme) : ((((Control)this).get_Parent() is IMetroForm) ? MetroPaint.BackColor.Form(base.Theme) : ((!(((Control)this).get_Parent() is IMetroControl)) ? ((Control)this).get_Parent().get_BackColor() : MetroPaint.GetStyleColor(base.Style))));
			Color color2;
			if (isHovered && !isPressed && ((Control)this).get_Enabled())
			{
				color2 = MetroPaint.ForeColor.Button.Normal(base.Theme);
				color = MetroPaint.BackColor.Button.Normal(base.Theme);
			}
			else if (isHovered && isPressed && ((Control)this).get_Enabled())
			{
				color2 = MetroPaint.ForeColor.Button.Press(base.Theme);
				color = MetroPaint.GetStyleColor(base.Style);
			}
			else if (!((Control)this).get_Enabled())
			{
				color2 = MetroPaint.ForeColor.Button.Disabled(base.Theme);
				color = MetroPaint.BackColor.Button.Disabled(base.Theme);
			}
			else
			{
				color2 = MetroPaint.ForeColor.Button.Normal(base.Theme);
			}
			e.get_Graphics().Clear(color);
			Font val = new Font("Webdings", 9.25f);
			TextRenderer.DrawText((IDeviceContext)(object)e.get_Graphics(), ((Control)this).get_Text(), val, ((Control)this).get_ClientRectangle(), color2, color, (TextFormatFlags)32773);
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
	}

	public enum MetroFormShadowType
	{
		None,
		Flat,
		DropShadow,
		SystemShadow,
		AeroShadow
	}

	protected abstract class MetroShadowBase : Form
	{
		private const int TICKS_PER_MS = 10000;

		private const long RESIZE_REDRAW_INTERVAL = 100000L;

		protected const int WS_EX_TRANSPARENT = 32;

		protected const int WS_EX_LAYERED = 524288;

		protected const int WS_EX_NOACTIVATE = 134217728;

		private readonly int _shadowSize;

		private readonly int _wsExStyle;

		private bool _isBringingToFront;

		private long _lastResizedOn;

		protected Form TargetForm { get; private set; }

		protected override CreateParams CreateParams
		{
			get
			{
				CreateParams createParams = ((Form)this).get_CreateParams();
				createParams.set_ExStyle(createParams.get_ExStyle() | _wsExStyle);
				return createParams;
			}
		}

		private bool IsResizing => _lastResizedOn > 0L;

		protected MetroShadowBase(Form targetForm, int shadowSize, int wsExStyle)
		{
			TargetForm = targetForm;
			_shadowSize = shadowSize;
			_wsExStyle = wsExStyle;
			TargetForm.add_Activated((EventHandler)OnTargetFormActivated);
			TargetForm.add_ResizeBegin((EventHandler)OnTargetFormResizeBegin);
			TargetForm.add_ResizeEnd((EventHandler)OnTargetFormResizeEnd);
			((Control)TargetForm).add_VisibleChanged((EventHandler)OnTargetFormVisibleChanged);
			((Control)TargetForm).add_SizeChanged((EventHandler)OnTargetFormSizeChanged);
			((Control)TargetForm).add_Move((EventHandler)OnTargetFormMove);
			((Control)TargetForm).add_Resize((EventHandler)OnTargetFormResize);
			if (TargetForm.get_Owner() != null)
			{
				((Form)this).set_Owner(TargetForm.get_Owner());
			}
			TargetForm.set_Owner((Form)(object)this);
			((Form)this).set_MaximizeBox(false);
			((Form)this).set_MinimizeBox(false);
			((Form)this).set_ShowInTaskbar(false);
			((Form)this).set_ShowIcon(false);
			((Form)this).set_FormBorderStyle((FormBorderStyle)0);
			((Control)this).set_Bounds(GetShadowBounds());
		}

		private Rectangle GetShadowBounds()
		{
			Rectangle bounds = ((Control)TargetForm).get_Bounds();
			bounds.Inflate(_shadowSize, _shadowSize);
			return bounds;
		}

		protected abstract void PaintShadow();

		protected abstract void ClearShadow();

		[SecuritySafeCritical]
		protected void SetBitmap(Bitmap bitmap, byte opacity)
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Invalid comparison between Unknown and I4
			if ((int)((Image)bitmap).get_PixelFormat() != 2498570)
			{
				throw new ApplicationException("The bitmap must be 32ppp with alpha-channel.");
			}
			IntPtr dC = WinApi.GetDC(IntPtr.Zero);
			IntPtr intPtr = WinApi.CreateCompatibleDC(dC);
			IntPtr intPtr2 = IntPtr.Zero;
			IntPtr hObject = IntPtr.Zero;
			try
			{
				intPtr2 = bitmap.GetHbitmap(Color.FromArgb(0));
				hObject = WinApi.SelectObject(intPtr, intPtr2);
				Size psize = new Size(((Image)bitmap).get_Width(), ((Image)bitmap).get_Height());
				Point pprSrc = new Point(0, 0);
				Point pptDst = new Point(((Control)this).get_Left(), ((Control)this).get_Top());
				WinApi.BLENDFUNCTION bLENDFUNCTION = default(WinApi.BLENDFUNCTION);
				bLENDFUNCTION.BlendOp = 0;
				bLENDFUNCTION.BlendFlags = 0;
				bLENDFUNCTION.SourceConstantAlpha = opacity;
				bLENDFUNCTION.AlphaFormat = 1;
				WinApi.BLENDFUNCTION pblend = bLENDFUNCTION;
				WinApi.UpdateLayeredWindow(((Control)this).get_Handle(), dC, ref pptDst, ref psize, intPtr, ref pprSrc, 0, ref pblend, 2);
			}
			finally
			{
				WinApi.ReleaseDC(IntPtr.Zero, dC);
				if (intPtr2 != IntPtr.Zero)
				{
					WinApi.SelectObject(intPtr, hObject);
					WinApi.DeleteObject(intPtr2);
				}
				WinApi.DeleteDC(intPtr);
			}
		}

		protected override void OnDeactivate(EventArgs e)
		{
			((Form)this).OnDeactivate(e);
			_isBringingToFront = true;
		}

		private void OnTargetFormActivated(object sender, EventArgs e)
		{
			if (((Control)this).get_Visible())
			{
				((Control)this).Update();
			}
			if (_isBringingToFront)
			{
				_isBringingToFront = false;
			}
			else
			{
				((Control)this).BringToFront();
			}
		}

		private void OnTargetFormVisibleChanged(object sender, EventArgs e)
		{
			//IL_0014: Unknown result type (might be due to invalid IL or missing references)
			//IL_001a: Invalid comparison between Unknown and I4
			((Control)this).set_Visible(((Control)TargetForm).get_Visible() && (int)TargetForm.get_WindowState() == 0);
			((Control)this).Update();
		}

		private void OnTargetFormResizeBegin(object sender, EventArgs e)
		{
			_lastResizedOn = DateTime.Now.Ticks;
		}

		private void OnTargetFormMove(object sender, EventArgs e)
		{
			//IL_0013: Unknown result type (might be due to invalid IL or missing references)
			if (((Control)TargetForm).get_Visible() && (int)TargetForm.get_WindowState() == 0)
			{
				((Control)this).set_Bounds(GetShadowBounds());
			}
			else
			{
				((Control)this).set_Visible(false);
			}
		}

		private void OnTargetFormResize(object sender, EventArgs e)
		{
			ClearShadow();
		}

		private void OnTargetFormSizeChanged(object sender, EventArgs e)
		{
			((Control)this).set_Bounds(GetShadowBounds());
			if (IsResizing)
			{
				if (DateTime.Now.Ticks - _lastResizedOn <= 100000L)
				{
					return;
				}
				_lastResizedOn = DateTime.Now.Ticks;
			}
			PaintShadowIfVisible();
		}

		private void OnTargetFormResizeEnd(object sender, EventArgs e)
		{
			_lastResizedOn = 0L;
			PaintShadowIfVisible();
		}

		private void PaintShadowIfVisible()
		{
			//IL_0013: Unknown result type (might be due to invalid IL or missing references)
			if (((Control)TargetForm).get_Visible() && (int)TargetForm.get_WindowState() == 0)
			{
				PaintShadow();
			}
		}
	}

	protected class MetroAeroDropShadow : MetroShadowBase
	{
		public MetroAeroDropShadow(Form targetForm)
			: base(targetForm, 0, 134217760)
		{
			((Form)this).set_FormBorderStyle((FormBorderStyle)6);
			((Form)this).set_TransparencyKey(Color.Black);
		}

		protected override void SetBoundsCore(int x, int y, int width, int height, BoundsSpecified specified)
		{
			//IL_0000: Unknown result type (might be due to invalid IL or missing references)
			//IL_0004: Invalid comparison between Unknown and I4
			//IL_000d: Unknown result type (might be due to invalid IL or missing references)
			if ((int)specified != 12)
			{
				((Form)this).SetBoundsCore(x, y, width, height, specified);
			}
		}

		protected override void PaintShadow()
		{
			((Control)this).set_Visible(true);
		}

		protected override void ClearShadow()
		{
		}

		protected override void OnPaint(PaintEventArgs e)
		{
			e.get_Graphics().Clear(Color.Black);
		}
	}

	protected class MetroFlatDropShadow : MetroShadowBase
	{
		private Point Offset = new Point(-6, -6);

		public MetroFlatDropShadow(Form targetForm)
			: base(targetForm, 6, 134742048)
		{
		}

		protected override void OnLoad(EventArgs e)
		{
			((Form)this).OnLoad(e);
			PaintShadow();
		}

		protected override void OnPaint(PaintEventArgs e)
		{
			((Control)this).set_Visible(true);
			PaintShadow();
		}

		protected override void PaintShadow()
		{
			Bitmap val = DrawBlurBorder();
			try
			{
				SetBitmap(val, byte.MaxValue);
			}
			finally
			{
				((IDisposable)val)?.Dispose();
			}
		}

		protected override void ClearShadow()
		{
		}

		private Bitmap DrawBlurBorder()
		{
			//IL_002e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0034: Expected O, but got Unknown
			return (Bitmap)DrawOutsetShadow(Color.Black, new Rectangle(0, 0, ((Control)this).get_ClientRectangle().Width, ((Control)this).get_ClientRectangle().Height));
		}

		private Image DrawOutsetShadow(Color color, Rectangle shadowCanvasArea)
		{
			//IL_0078: Unknown result type (might be due to invalid IL or missing references)
			//IL_007e: Expected O, but got Unknown
			//IL_009f: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a6: Expected O, but got Unknown
			//IL_00c9: Unknown result type (might be due to invalid IL or missing references)
			//IL_00d0: Expected O, but got Unknown
			Rectangle rectangle = shadowCanvasArea;
			Rectangle rectangle2 = new Rectangle(shadowCanvasArea.X + (-Offset.X - 1), shadowCanvasArea.Y + (-Offset.Y - 1), shadowCanvasArea.Width - (-Offset.X * 2 - 1), shadowCanvasArea.Height - (-Offset.Y * 2 - 1));
			Bitmap val = new Bitmap(rectangle.Width, rectangle.Height, (PixelFormat)2498570);
			Graphics val2 = Graphics.FromImage((Image)(object)val);
			val2.set_SmoothingMode((SmoothingMode)4);
			val2.set_InterpolationMode((InterpolationMode)7);
			Brush val3 = (Brush)new SolidBrush(Color.FromArgb(30, Color.Black));
			try
			{
				val2.FillRectangle(val3, rectangle);
			}
			finally
			{
				((IDisposable)val3)?.Dispose();
			}
			Brush val4 = (Brush)new SolidBrush(Color.FromArgb(60, Color.Black));
			try
			{
				val2.FillRectangle(val4, rectangle2);
			}
			finally
			{
				((IDisposable)val4)?.Dispose();
			}
			val2.Flush();
			val2.Dispose();
			return (Image)(object)val;
		}
	}

	protected class MetroRealisticDropShadow : MetroShadowBase
	{
		public MetroRealisticDropShadow(Form targetForm)
			: base(targetForm, 15, 134742048)
		{
		}

		protected override void OnLoad(EventArgs e)
		{
			((Form)this).OnLoad(e);
			PaintShadow();
		}

		protected override void OnPaint(PaintEventArgs e)
		{
			((Control)this).set_Visible(true);
			PaintShadow();
		}

		protected override void PaintShadow()
		{
			Bitmap val = DrawBlurBorder();
			try
			{
				SetBitmap(val, byte.MaxValue);
			}
			finally
			{
				((IDisposable)val)?.Dispose();
			}
		}

		protected override void ClearShadow()
		{
			//IL_0011: Unknown result type (might be due to invalid IL or missing references)
			//IL_0017: Expected O, but got Unknown
			Bitmap val = new Bitmap(((Control)this).get_Width(), ((Control)this).get_Height(), (PixelFormat)2498570);
			Graphics val2 = Graphics.FromImage((Image)(object)val);
			val2.Clear(Color.Transparent);
			val2.Flush();
			val2.Dispose();
			SetBitmap(val, byte.MaxValue);
			((Image)val).Dispose();
		}

		private Bitmap DrawBlurBorder()
		{
			//IL_0033: Unknown result type (might be due to invalid IL or missing references)
			//IL_0039: Expected O, but got Unknown
			return (Bitmap)DrawOutsetShadow(0, 0, 40, 1, Color.Black, new Rectangle(1, 1, ((Control)this).get_ClientRectangle().Width, ((Control)this).get_ClientRectangle().Height));
		}

		private Image DrawOutsetShadow(int hShadow, int vShadow, int blur, int spread, Color color, Rectangle shadowCanvasArea)
		{
			//IL_0043: Unknown result type (might be due to invalid IL or missing references)
			//IL_0049: Expected O, but got Unknown
			Rectangle rectangle = shadowCanvasArea;
			Rectangle rectangle2 = shadowCanvasArea;
			rectangle2.Offset(hShadow, vShadow);
			rectangle2.Inflate(-blur, -blur);
			rectangle.Inflate(spread, spread);
			rectangle.Offset(hShadow, vShadow);
			Rectangle rectangle3 = rectangle;
			Bitmap val = new Bitmap(rectangle3.Width, rectangle3.Height, (PixelFormat)2498570);
			Graphics val2 = Graphics.FromImage((Image)(object)val);
			val2.set_SmoothingMode((SmoothingMode)4);
			val2.set_InterpolationMode((InterpolationMode)7);
			int cornerRadius = 0;
			do
			{
				double num = (double)(rectangle.Height - rectangle2.Height) / (double)(blur * 2 + spread * 2);
				Color fillColor = Color.FromArgb((int)(200.0 * (num * num)), color);
				Rectangle bounds = rectangle2;
				bounds.Offset(-rectangle3.Left, -rectangle3.Top);
				DrawRoundedRectangle(val2, bounds, cornerRadius, Pens.get_Transparent(), fillColor);
				rectangle2.Inflate(1, 1);
				cornerRadius = (int)((double)blur * (1.0 - num * num));
			}
			while (rectangle.Contains(rectangle2));
			val2.Flush();
			val2.Dispose();
			return (Image)(object)val;
		}

		private void DrawRoundedRectangle(Graphics g, Rectangle bounds, int cornerRadius, Pen drawPen, Color fillColor)
		{
			//IL_001f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0025: Expected O, but got Unknown
			//IL_00e9: Unknown result type (might be due to invalid IL or missing references)
			//IL_00ef: Expected O, but got Unknown
			//IL_0113: Unknown result type (might be due to invalid IL or missing references)
			//IL_0119: Expected O, but got Unknown
			int num = Convert.ToInt32(Math.Ceiling(drawPen.get_Width()));
			bounds = Rectangle.Inflate(bounds, -num, -num);
			GraphicsPath val = new GraphicsPath();
			if (cornerRadius > 0)
			{
				val.AddArc(bounds.X, bounds.Y, cornerRadius, cornerRadius, 180f, 90f);
				val.AddArc(bounds.X + bounds.Width - cornerRadius, bounds.Y, cornerRadius, cornerRadius, 270f, 90f);
				val.AddArc(bounds.X + bounds.Width - cornerRadius, bounds.Y + bounds.Height - cornerRadius, cornerRadius, cornerRadius, 0f, 90f);
				val.AddArc(bounds.X, bounds.Y + bounds.Height - cornerRadius, cornerRadius, cornerRadius, 90f, 90f);
			}
			else
			{
				val.AddRectangle(bounds);
			}
			val.CloseAllFigures();
			if (cornerRadius > 5)
			{
				SolidBrush val2 = new SolidBrush(fillColor);
				try
				{
					g.FillPath((Brush)(object)val2, val);
				}
				finally
				{
					((IDisposable)val2)?.Dispose();
				}
			}
			if (drawPen != Pens.get_Transparent())
			{
				Pen val3 = new Pen(drawPen.get_Color());
				try
				{
					val3.set_StartCap((LineCap)2);
					val3.set_EndCap((LineCap)2);
					g.DrawPath(val3, val);
				}
				finally
				{
					((IDisposable)val3)?.Dispose();
				}
			}
		}
	}

	private const int borderWidth = 5;

	private const int CS_DROPSHADOW = 131072;

	private HorizontalAlign textAlign;

	private MetroBorderStyle _borderStyle;

	private bool isMovable = true;

	private bool displayHeader = true;

	private bool isResizable = true;

	private MetroFormShadowType shadowType = MetroFormShadowType.AeroShadow;

	private Dictionary<WindowButtons, MetroFormButton> windowButtonList;

	private Form shadowForm;

	private bool _barrierProxyShadowForm;

	[Category("Metro Appearance")]
	[Browsable(true)]
	public HorizontalAlign TextAlign
	{
		get
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			return textAlign;
		}
		set
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			//IL_0002: Unknown result type (might be due to invalid IL or missing references)
			textAlign = value;
		}
	}

	[Browsable(false)]
	public override Color BackColor => MetroPaint.BackColor.Form(base.Theme);

	[Category("Metro Appearance")]
	[Browsable(true)]
	[DefaultValue(MetroBorderStyle.None)]
	public MetroBorderStyle BorderStyle
	{
		get
		{
			return _borderStyle;
		}
		set
		{
			_borderStyle = value;
		}
	}

	[Category("Metro Appearance")]
	public bool Movable
	{
		get
		{
			return isMovable;
		}
		set
		{
			isMovable = value;
		}
	}

	public Padding Padding
	{
		get
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			return ((Control)this).get_Padding();
		}
		set
		{
			//IL_0022: Unknown result type (might be due to invalid IL or missing references)
			((Padding)(ref value)).set_Top(Math.Max(((Padding)(ref value)).get_Top(), DisplayHeader ? 60 : 30));
			((Control)this).set_Padding(value);
		}
	}

	protected override Padding DefaultPadding => new Padding(20, DisplayHeader ? 60 : 20, 20, 20);

	[Category("Metro Appearance")]
	[DefaultValue(true)]
	public bool DisplayHeader
	{
		get
		{
			return displayHeader;
		}
		set
		{
			//IL_000a: Unknown result type (might be due to invalid IL or missing references)
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0028: Unknown result type (might be due to invalid IL or missing references)
			if (value != displayHeader)
			{
				Padding padding = ((Control)this).get_Padding();
				((Padding)(ref padding)).set_Top(((Padding)(ref padding)).get_Top() + (value ? 30 : (-30)));
				((Control)this).set_Padding(padding);
			}
			displayHeader = value;
		}
	}

	[Category("Metro Appearance")]
	public bool Resizable
	{
		get
		{
			return isResizable;
		}
		set
		{
			isResizable = value;
		}
	}

	[DefaultValue(MetroFormShadowType.AeroShadow)]
	[Category("Metro Appearance")]
	public MetroFormShadowType ShadowType
	{
		get
		{
			return shadowType;
		}
		set
		{
			shadowType = value;
		}
	}

	public Form MdiParent
	{
		get
		{
			return ((Form)this).get_MdiParent();
		}
		set
		{
			if (value != null)
			{
				RemoveShadow();
				shadowType = MetroFormShadowType.None;
			}
			((Form)this).set_MdiParent(value);
		}
	}

	protected override CreateParams CreateParams
	{
		get
		{
			CreateParams createParams = ((Form)this).get_CreateParams();
			if (ShadowType == MetroFormShadowType.SystemShadow)
			{
				createParams.set_ClassStyle(createParams.get_ClassStyle() | 0x20000);
			}
			return createParams;
		}
	}

	public MetroForm()
	{
		((Control)this).SetStyle((ControlStyles)131090, true);
		((Form)this).set_FormBorderStyle((FormBorderStyle)0);
		((Control)this).set_Name("MetroForm");
		((Form)this).set_StartPosition((FormStartPosition)1);
	}

	protected override void Dispose(bool disposing)
	{
		if (disposing)
		{
			RemoveShadow();
		}
		base.Dispose(disposing);
	}

	protected override void OnPaintBackground(PaintEventArgs e)
	{
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0081: Expected O, but got Unknown
		//IL_0123: Unknown result type (might be due to invalid IL or missing references)
		//IL_0128: Unknown result type (might be due to invalid IL or missing references)
		//IL_013c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0141: Unknown result type (might be due to invalid IL or missing references)
		//IL_0174: Unknown result type (might be due to invalid IL or missing references)
		//IL_0179: Unknown result type (might be due to invalid IL or missing references)
		//IL_017a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0190: Unknown result type (might be due to invalid IL or missing references)
		//IL_019d: Unknown result type (might be due to invalid IL or missing references)
		//IL_01aa: Unknown result type (might be due to invalid IL or missing references)
		((ScrollableControl)this).OnPaintBackground(e);
		Color color = MetroPaint.BackColor.Form(base.Theme);
		Color color2 = MetroPaint.ForeColor.Form(base.Theme);
		e.get_Graphics().Clear(color);
		SolidBrush styleBrush = MetroPaint.GetStyleBrush(base.Style);
		try
		{
			Rectangle rectangle = new Rectangle(0, 0, ((Control)this).get_Width(), 5);
			e.get_Graphics().FillRectangle((Brush)(object)styleBrush, rectangle);
		}
		finally
		{
			((IDisposable)styleBrush)?.Dispose();
		}
		if (BorderStyle != 0)
		{
			Color color3 = MetroPaint.BorderColor.Form(base.Theme);
			Pen val = new Pen(color3);
			try
			{
				e.get_Graphics().DrawLines(val, new Point[4]
				{
					new Point(0, 5),
					new Point(0, ((Control)this).get_Height() - 1),
					new Point(((Control)this).get_Width() - 1, ((Control)this).get_Height() - 1),
					new Point(((Control)this).get_Width() - 1, 5)
				});
			}
			finally
			{
				((IDisposable)val)?.Dispose();
			}
		}
		if (displayHeader)
		{
			TextRenderingHint textRenderingHint = e.get_Graphics().get_TextRenderingHint();
			e.get_Graphics().set_TextRenderingHint((TextRenderingHint)5);
			SmoothingMode smoothingMode = e.get_Graphics().get_SmoothingMode();
			e.get_Graphics().set_SmoothingMode((SmoothingMode)2);
			Rectangle rectangle2 = new Rectangle(20, 20, ((Control)this).get_ClientRectangle().Width - 40, 40);
			TextFormatFlags val2 = (TextFormatFlags)(0x8000 | GetTextFormatFlags());
			TextRenderer.DrawText((IDeviceContext)(object)e.get_Graphics(), ((Control)this).get_Text(), MetroFonts.Title, rectangle2, color2, val2);
			e.get_Graphics().set_TextRenderingHint(textRenderingHint);
			e.get_Graphics().set_SmoothingMode(smoothingMode);
		}
	}

	protected override void OnPaint(PaintEventArgs e)
	{
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Invalid comparison between Unknown and I4
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Expected O, but got Unknown
		((Form)this).OnPaint(e);
		if (Resizable && ((int)((Form)this).get_SizeGripStyle() == 0 || (int)((Form)this).get_SizeGripStyle() == 1))
		{
			SolidBrush val = new SolidBrush(MetroPaint.ForeColor.Button.Disabled(base.Theme));
			try
			{
				Size size = new Size(2, 2);
				e.get_Graphics().FillRectangles((Brush)(object)val, new Rectangle[6]
				{
					new Rectangle(new Point(((Control)this).get_ClientRectangle().Width - 6, ((Control)this).get_ClientRectangle().Height - 6), size),
					new Rectangle(new Point(((Control)this).get_ClientRectangle().Width - 10, ((Control)this).get_ClientRectangle().Height - 10), size),
					new Rectangle(new Point(((Control)this).get_ClientRectangle().Width - 10, ((Control)this).get_ClientRectangle().Height - 6), size),
					new Rectangle(new Point(((Control)this).get_ClientRectangle().Width - 6, ((Control)this).get_ClientRectangle().Height - 10), size),
					new Rectangle(new Point(((Control)this).get_ClientRectangle().Width - 14, ((Control)this).get_ClientRectangle().Height - 6), size),
					new Rectangle(new Point(((Control)this).get_ClientRectangle().Width - 6, ((Control)this).get_ClientRectangle().Height - 14), size)
				});
			}
			finally
			{
				((IDisposable)val)?.Dispose();
			}
		}
	}

	private TextFormatFlags GetTextFormatFlags()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected I4, but got Unknown
		HorizontalAlign val = TextAlign;
		return (TextFormatFlags)((int)val switch
		{
			0 => 0, 
			1 => 1, 
			2 => 2, 
			_ => throw new InvalidOperationException(), 
		});
	}

	protected override void OnClosing(CancelEventArgs e)
	{
		((Form)this).OnClosing(e);
		if (!e.Cancel && !(this is MetroTaskWindow))
		{
			MetroTaskWindow.ForceClose();
		}
	}

	protected override void OnClosed(EventArgs e)
	{
		RemoveShadow();
		((Form)this).OnClosed(e);
	}

	[SecuritySafeCritical]
	public bool FocusMe()
	{
		return WinApi.SetForegroundWindow(((Control)this).get_Handle());
	}

	protected override void OnHandleCreated(EventArgs e)
	{
		((Form)this).OnHandleCreated(e);
		if (!((Component)(object)this).DesignMode)
		{
			CreateShadow();
		}
	}

	protected override void OnLoad(EventArgs e)
	{
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Invalid comparison between Unknown and I4
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Invalid comparison between Unknown and I4
		((Form)this).OnLoad(e);
		if (((Component)(object)this).DesignMode)
		{
			return;
		}
		FormStartPosition startPosition = ((Form)this).get_StartPosition();
		if ((int)startPosition != 1)
		{
			if ((int)startPosition == 4)
			{
				((Form)this).CenterToParent();
			}
		}
		else if (((Form)this).get_IsMdiChild())
		{
			((Form)this).CenterToParent();
		}
		else
		{
			((Form)this).CenterToScreen();
		}
		RemoveCloseButton();
		if (((Form)this).get_ControlBox())
		{
			AddWindowButton(WindowButtons.Close);
			if (((Form)this).get_MaximizeBox())
			{
				AddWindowButton(WindowButtons.Maximize);
			}
			if (((Form)this).get_MinimizeBox())
			{
				AddWindowButton(WindowButtons.Minimize);
			}
			UpdateWindowButtonPosition();
		}
	}

	protected override void OnActivated(EventArgs e)
	{
		((Form)this).OnActivated(e);
		_ = ((Component)(object)this).DesignMode;
	}

	protected override void OnEnabledChanged(EventArgs e)
	{
		((Form)this).OnEnabledChanged(e);
		((Control)this).Invalidate();
	}

	protected override void OnResizeEnd(EventArgs e)
	{
		((Form)this).OnResizeEnd(e);
		UpdateWindowButtonPosition();
	}

	protected override void WndProc(ref Message m)
	{
		if (((Component)(object)this).DesignMode)
		{
			((Form)this).WndProc(ref m);
			return;
		}
		switch (((Message)(ref m)).get_Msg())
		{
		case 132:
		{
			WinApi.HitTest hitTest = HitTestNCA(((Message)(ref m)).get_HWnd(), ((Message)(ref m)).get_WParam(), ((Message)(ref m)).get_LParam());
			if (hitTest != WinApi.HitTest.HTCLIENT)
			{
				((Message)(ref m)).set_Result((IntPtr)(long)hitTest);
				return;
			}
			break;
		}
		case 163:
		case 515:
			if (!((Form)this).get_MaximizeBox())
			{
				return;
			}
			break;
		case 274:
			switch (((Message)(ref m)).get_WParam().ToInt32() & 0xFFF0)
			{
			case 61456:
				if (!Movable)
				{
					return;
				}
				break;
			}
			break;
		}
		((Form)this).WndProc(ref m);
		int msg = ((Message)(ref m)).get_Msg();
		if (msg == 36)
		{
			OnGetMinMaxInfo(((Message)(ref m)).get_HWnd(), ((Message)(ref m)).get_LParam());
		}
	}

	[SecuritySafeCritical]
	private unsafe void OnGetMinMaxInfo(IntPtr hwnd, IntPtr lParam)
	{
		WinApi.MINMAXINFO* ptr = (WinApi.MINMAXINFO*)(void*)lParam;
		Screen val = Screen.FromHandle(hwnd);
		ptr->ptMaxSize.X = val.get_WorkingArea().Width;
		ptr->ptMaxSize.Y = val.get_WorkingArea().Height;
		ptr->ptMaxPosition.X = Math.Abs(val.get_WorkingArea().Left - val.get_Bounds().Left);
		ptr->ptMaxPosition.Y = Math.Abs(val.get_WorkingArea().Top - val.get_Bounds().Top);
	}

	private WinApi.HitTest HitTestNCA(IntPtr hwnd, IntPtr wparam, IntPtr lparam)
	{
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		Point pt = new Point((short)(int)lparam, (short)((int)lparam >> 16));
		Padding padding = Padding;
		int right = ((Padding)(ref padding)).get_Right();
		Padding padding2 = Padding;
		int num = Math.Max(right, ((Padding)(ref padding2)).get_Bottom());
		if (Resizable && ((Control)this).RectangleToScreen(new Rectangle(((Control)this).get_ClientRectangle().Width - num, ((Control)this).get_ClientRectangle().Height - num, num, num)).Contains(pt))
		{
			return WinApi.HitTest.HTBOTTOMRIGHT;
		}
		if (((Control)this).RectangleToScreen(new Rectangle(5, 5, ((Control)this).get_ClientRectangle().Width - 10, 50)).Contains(pt))
		{
			return WinApi.HitTest.HTCAPTION;
		}
		return WinApi.HitTest.HTCLIENT;
	}

	protected override void OnMouseDown(MouseEventArgs e)
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Invalid comparison between Unknown and I4
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Invalid comparison between Unknown and I4
		((Control)this).OnMouseDown(e);
		if ((int)e.get_Button() == 1048576 && Movable && (int)((Form)this).get_WindowState() != 2 && ((Control)this).get_Width() - 5 > e.get_Location().X && e.get_Location().X > 5 && e.get_Location().Y > 5)
		{
			MoveControl();
		}
	}

	[SecuritySafeCritical]
	private void MoveControl()
	{
		WinApi.ReleaseCapture();
		WinApi.SendMessage(((Control)this).get_Handle(), 161, 2, 0);
	}

	private void AddWindowButton(WindowButtons button)
	{
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		if (windowButtonList == null)
		{
			windowButtonList = new Dictionary<WindowButtons, MetroFormButton>();
		}
		if (windowButtonList.ContainsKey(button))
		{
			return;
		}
		MetroFormButton metroFormButton = new MetroFormButton();
		switch (button)
		{
		case WindowButtons.Close:
			((Control)metroFormButton).set_Text("r");
			break;
		case WindowButtons.Minimize:
			((Control)metroFormButton).set_Text("0");
			break;
		case WindowButtons.Maximize:
			if ((int)((Form)this).get_WindowState() == 0)
			{
				((Control)metroFormButton).set_Text("1");
			}
			else
			{
				((Control)metroFormButton).set_Text("2");
			}
			break;
		}
		((Control)metroFormButton).set_Tag((object)button);
		((Control)metroFormButton).set_Size(new Size(25, 20));
		((Control)metroFormButton).set_Anchor((AnchorStyles)9);
		((Control)metroFormButton).add_Click((EventHandler)WindowButton_Click);
		((Control)this).get_Controls().Add((Control)(object)metroFormButton);
		windowButtonList.Add(button, metroFormButton);
	}

	private void WindowButton_Click(object sender, EventArgs e)
	{
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		if (!(sender is MetroFormButton metroFormButton))
		{
			return;
		}
		switch ((WindowButtons)((Control)metroFormButton).get_Tag())
		{
		case WindowButtons.Close:
			((Form)this).Close();
			break;
		case WindowButtons.Minimize:
			((Form)this).set_WindowState((FormWindowState)1);
			break;
		case WindowButtons.Maximize:
			if ((int)((Form)this).get_WindowState() == 0)
			{
				((Form)this).set_WindowState((FormWindowState)2);
				((Control)metroFormButton).set_Text("2");
			}
			else
			{
				((Form)this).set_WindowState((FormWindowState)0);
				((Control)metroFormButton).set_Text("1");
			}
			break;
		}
	}

	private void UpdateWindowButtonPosition()
	{
		if (!((Form)this).get_ControlBox())
		{
			return;
		}
		Dictionary<int, WindowButtons> dictionary = new Dictionary<int, WindowButtons>(3);
		dictionary.Add(0, WindowButtons.Close);
		dictionary.Add(1, WindowButtons.Maximize);
		dictionary.Add(2, WindowButtons.Minimize);
		Dictionary<int, WindowButtons> dictionary2 = dictionary;
		Point location = new Point(((Control)this).get_ClientRectangle().Width - 5 - 25, 5);
		int num = location.X - 25;
		MetroFormButton metroFormButton = null;
		if (windowButtonList.Count == 1)
		{
			foreach (KeyValuePair<WindowButtons, MetroFormButton> windowButton in windowButtonList)
			{
				((Control)windowButton.Value).set_Location(location);
			}
		}
		else
		{
			foreach (KeyValuePair<int, WindowButtons> item in dictionary2)
			{
				bool flag = windowButtonList.ContainsKey(item.Value);
				if (metroFormButton == null && flag)
				{
					metroFormButton = windowButtonList[item.Value];
					((Control)metroFormButton).set_Location(location);
				}
				else if (metroFormButton != null && flag)
				{
					((Control)windowButtonList[item.Value]).set_Location(new Point(num, 5));
					num -= 25;
				}
			}
		}
		((Control)this).Refresh();
	}

	private void CreateShadow()
	{
		switch (ShadowType)
		{
		case MetroFormShadowType.Flat:
			shadowForm = (Form)(object)new MetroFlatDropShadow((Form)(object)this);
			break;
		case MetroFormShadowType.DropShadow:
			shadowForm = (Form)(object)new MetroRealisticDropShadow((Form)(object)this);
			break;
		case MetroFormShadowType.AeroShadow:
			shadowForm = (Form)(object)new MetroAeroDropShadow((Form)(object)this);
			break;
		case MetroFormShadowType.SystemShadow:
			break;
		}
	}

	private void RemoveShadow()
	{
		if (shadowForm != null && !((Control)shadowForm).get_IsDisposed())
		{
			((Control)shadowForm).set_Visible(false);
			((Form)this).set_Owner(shadowForm.get_Owner());
			shadowForm.set_Owner((Form)null);
			((Component)(object)shadowForm).Dispose();
			shadowForm = null;
		}
	}

	protected override void SetVisibleCore(bool value)
	{
		if (_barrierProxyShadowForm)
		{
			return;
		}
		if (shadowForm != null)
		{
			_barrierProxyShadowForm = true;
			try
			{
				((Control)shadowForm).set_Visible(value);
			}
			finally
			{
				_barrierProxyShadowForm = false;
			}
		}
		((Form)this).SetVisibleCore(value);
	}

	[SecuritySafeCritical]
	public void RemoveCloseButton()
	{
		IntPtr systemMenu = WinApi.GetSystemMenu(((Control)this).get_Handle(), bRevert: false);
		if (!(systemMenu == IntPtr.Zero))
		{
			int menuItemCount = WinApi.GetMenuItemCount(systemMenu);
			if (menuItemCount > 0)
			{
				WinApi.RemoveMenu(systemMenu, (uint)(menuItemCount - 1), 5120u);
				WinApi.RemoveMenu(systemMenu, (uint)(menuItemCount - 2), 5120u);
				WinApi.DrawMenuBar(((Control)this).get_Handle());
			}
		}
	}

	private Rectangle MeasureText(Graphics g, Rectangle clientRectangle, Font font, string text, TextFormatFlags flags)
	{
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		Size size = new Size(int.MaxValue, int.MinValue);
		Size size2 = TextRenderer.MeasureText((IDeviceContext)(object)g, text, font, size, flags);
		return new Rectangle(clientRectangle.X, clientRectangle.Y, size2.Width, size2.Height);
	}
}
