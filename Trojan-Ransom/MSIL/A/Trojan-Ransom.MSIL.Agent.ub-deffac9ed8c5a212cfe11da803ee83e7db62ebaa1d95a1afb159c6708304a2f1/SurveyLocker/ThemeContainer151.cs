using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace SurveyLocker;

internal abstract class ThemeContainer151 : ContainerControl
{
	protected Graphics G;

	private Rectangle Header;

	protected MouseState State;

	private Point GetIndexPoint;

	private bool B1;

	private bool B2;

	private bool B3;

	private bool B4;

	private int Current;

	private int Previous;

	private Message[] Messages;

	private Color BackColorWait;

	private bool _Movable;

	private bool _Sizable;

	private int _MoveHeight;

	private bool _ControlMode;

	private Color _TransparencyKey;

	private FormBorderStyle _BorderStyle;

	private bool _NoRounding;

	private Image _Image;

	private Size _ImageSize;

	private bool _IsParentForm;

	private int _LockWidth;

	private int _LockHeight;

	private Dictionary<string, Color> Items;

	private string _Customization;

	private Point CenterReturn;

	private Bitmap MeasureBitmap;

	private Graphics MeasureGraphics;

	private SolidBrush DrawCornersBrush;

	private Point DrawTextPoint;

	private Size DrawTextSize;

	private Point DrawImagePoint;

	private LinearGradientBrush DrawGradientBrush;

	private Rectangle DrawGradientRectangle;

	public override Color BackColor
	{
		get
		{
			return ((Control)this).get_BackColor();
		}
		set
		{
			if (((Control)this).get_IsHandleCreated())
			{
				if (!_ControlMode)
				{
					((Control)this).get_Parent().set_BackColor(value);
				}
				((Control)this).set_BackColor(value);
			}
			else
			{
				BackColorWait = value;
			}
		}
	}

	[Browsable(false)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public override Color ForeColor
	{
		get
		{
			return Color.Empty;
		}
		set
		{
		}
	}

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[Browsable(false)]
	public override Image BackgroundImage
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	[Browsable(false)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	public override ImageLayout BackgroundImageLayout
	{
		get
		{
			return (ImageLayout)0;
		}
		set
		{
		}
	}

	public override string Text
	{
		get
		{
			return ((Control)this).get_Text();
		}
		set
		{
			((Control)this).set_Text(value);
			((Control)this).Invalidate();
		}
	}

	public override Font Font
	{
		get
		{
			return ((Control)this).get_Font();
		}
		set
		{
			((Control)this).set_Font(value);
			((Control)this).Invalidate();
		}
	}

	public bool Movable
	{
		get
		{
			return _Movable;
		}
		set
		{
			_Movable = value;
		}
	}

	public bool Sizable
	{
		get
		{
			return _Sizable;
		}
		set
		{
			_Sizable = value;
		}
	}

	protected int MoveHeight
	{
		get
		{
			return _MoveHeight;
		}
		set
		{
			if (value >= 8)
			{
				ref Rectangle header = ref Header;
				header = checked(new Rectangle(7, 7, ((Control)this).get_Width() - 14, value - 7));
				_MoveHeight = value;
				((Control)this).Invalidate();
			}
		}
	}

	protected bool ControlMode
	{
		get
		{
			return _ControlMode;
		}
		set
		{
			_ControlMode = value;
		}
	}

	public Color TransparencyKey
	{
		get
		{
			if ((_IsParentForm && !_ControlMode) ? true : false)
			{
				return ((ContainerControl)this).get_ParentForm().get_TransparencyKey();
			}
			return _TransparencyKey;
		}
		set
		{
			if ((_IsParentForm && !_ControlMode) ? true : false)
			{
				((ContainerControl)this).get_ParentForm().set_TransparencyKey(value);
			}
			_TransparencyKey = value;
		}
	}

	public FormBorderStyle BorderStyle
	{
		get
		{
			//IL_001c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0021: Unknown result type (might be due to invalid IL or missing references)
			//IL_0025: Unknown result type (might be due to invalid IL or missing references)
			//IL_002a: Unknown result type (might be due to invalid IL or missing references)
			//IL_002b: Unknown result type (might be due to invalid IL or missing references)
			if ((_IsParentForm && !_ControlMode) ? true : false)
			{
				return ((ContainerControl)this).get_ParentForm().get_FormBorderStyle();
			}
			return _BorderStyle;
		}
		set
		{
			//IL_001c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0023: Unknown result type (might be due to invalid IL or missing references)
			//IL_0024: Unknown result type (might be due to invalid IL or missing references)
			if ((_IsParentForm && !_ControlMode) ? true : false)
			{
				((ContainerControl)this).get_ParentForm().set_FormBorderStyle(value);
			}
			_BorderStyle = value;
		}
	}

	public bool NoRounding
	{
		get
		{
			return _NoRounding;
		}
		set
		{
			_NoRounding = value;
			((Control)this).Invalidate();
		}
	}

	public Image Image
	{
		get
		{
			return _Image;
		}
		set
		{
			if (value == null)
			{
				_ImageSize = Size.Empty;
			}
			else
			{
				_ImageSize = value.get_Size();
			}
			_Image = value;
			((Control)this).Invalidate();
		}
	}

	protected Size ImageSize => _ImageSize;

	protected bool IsParentForm => _IsParentForm;

	protected int LockWidth
	{
		get
		{
			return _LockWidth;
		}
		set
		{
			_LockWidth = value;
			if ((LockWidth != 0 && ((Control)this).get_IsHandleCreated()) ? true : false)
			{
				((Control)this).set_Width(LockWidth);
			}
		}
	}

	protected int LockHeight
	{
		get
		{
			return _LockHeight;
		}
		set
		{
			_LockHeight = value;
			if ((LockHeight != 0 && ((Control)this).get_IsHandleCreated()) ? true : false)
			{
				((Control)this).set_Height(LockHeight);
			}
		}
	}

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
	public Bloom[] Colors
	{
		get
		{
			List<Bloom> list = new List<Bloom>();
			Dictionary<string, Color>.Enumerator enumerator = Items.GetEnumerator();
			while (enumerator.MoveNext())
			{
				list.Add(new Bloom(enumerator.Current.Key, enumerator.Current.Value));
			}
			return list.ToArray();
		}
		set
		{
			foreach (Bloom bloom in value)
			{
				if (Items.ContainsKey(bloom.Name))
				{
					Items[bloom.Name] = bloom.Value;
				}
			}
			InvalidateCustimization();
			ColorHook();
			((Control)this).Invalidate();
		}
	}

	public string Customization
	{
		get
		{
			return _Customization;
		}
		set
		{
			if (Operators.CompareString(value, _Customization, false) == 0)
			{
				return;
			}
			Bloom[] colors = Colors;
			checked
			{
				try
				{
					byte[] value2 = Convert.FromBase64String(value);
					int num = colors.Length - 1;
					int num2 = 0;
					while (true)
					{
						int num3 = num2;
						int num4 = num;
						if (num3 <= num4)
						{
							colors[num2].Value = Color.FromArgb(BitConverter.ToInt32(value2, num2 * 4));
							num2++;
							continue;
						}
						break;
					}
				}
				catch (Exception projectError)
				{
					ProjectData.SetProjectError(projectError);
					ProjectData.ClearProjectError();
					return;
				}
				_Customization = value;
				Colors = colors;
				ColorHook();
				((Control)this).Invalidate();
			}
		}
	}

	public ThemeContainer151()
	{
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Expected O, but got Unknown
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Expected O, but got Unknown
		Messages = (Message[])(object)new Message[9];
		_Movable = true;
		_Sizable = true;
		_MoveHeight = 24;
		Items = new Dictionary<string, Color>();
		((Control)this).SetStyle((ControlStyles)139270, true);
		_ImageSize = Size.Empty;
		MeasureBitmap = new Bitmap(1, 1);
		MeasureGraphics = Graphics.FromImage((Image)(object)MeasureBitmap);
		Font = new Font("Verdana", 8f);
		InvalidateCustimization();
	}

	protected override void SetBoundsCore(int x, int y, int width, int height, BoundsSpecified specified)
	{
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		if (_LockWidth != 0)
		{
			width = _LockWidth;
		}
		if (_LockHeight != 0)
		{
			height = _LockHeight;
		}
		((Control)this).SetBoundsCore(x, y, width, height, specified);
	}

	protected sealed override void OnSizeChanged(EventArgs e)
	{
		((Control)this).OnSizeChanged(e);
		if ((_Movable && !_ControlMode) ? true : false)
		{
			ref Rectangle header = ref Header;
			header = checked(new Rectangle(7, 7, ((Control)this).get_Width() - 14, _MoveHeight - 7));
		}
		((Control)this).Invalidate();
	}

	protected sealed override void OnPaint(PaintEventArgs e)
	{
		if ((((Control)this).get_Width() != 0 && ((Control)this).get_Height() != 0) || 1 == 0)
		{
			G = e.get_Graphics();
			PaintHook();
		}
	}

	protected sealed override void OnHandleCreated(EventArgs e)
	{
		//IL_00a6: Unknown result type (might be due to invalid IL or missing references)
		InitializeMessages();
		InvalidateCustimization();
		ColorHook();
		_IsParentForm = ((Control)this).get_Parent() is Form;
		if (!_ControlMode)
		{
			((Control)this).set_Dock((DockStyle)5);
		}
		if (_LockWidth != 0)
		{
			((Control)this).set_Width(_LockWidth);
		}
		if (_LockHeight != 0)
		{
			((Control)this).set_Height(_LockHeight);
		}
		Color color = default(Color);
		if (!(BackColorWait == color))
		{
			BackColor = BackColorWait;
		}
		if ((_IsParentForm && !_ControlMode) ? true : false)
		{
			((ContainerControl)this).get_ParentForm().set_FormBorderStyle(_BorderStyle);
			((ContainerControl)this).get_ParentForm().set_TransparencyKey(_TransparencyKey);
		}
		OnCreation();
		((Control)this).OnHandleCreated(e);
	}

	protected virtual void OnCreation()
	{
	}

	private void SetState(MouseState current)
	{
		State = current;
		((Control)this).Invalidate();
	}

	protected override void OnMouseMove(MouseEventArgs e)
	{
		if ((_Sizable && !_ControlMode) ? true : false)
		{
			InvalidateMouse();
		}
		((Control)this).OnMouseMove(e);
	}

	protected override void OnEnabledChanged(EventArgs e)
	{
		if (((Control)this).get_Enabled())
		{
			SetState(MouseState.None);
		}
		else
		{
			SetState(MouseState.Block);
		}
		((Control)this).OnEnabledChanged(e);
	}

	protected override void OnMouseEnter(EventArgs e)
	{
		SetState(MouseState.Over);
		((Control)this).OnMouseEnter(e);
	}

	protected override void OnMouseUp(MouseEventArgs e)
	{
		SetState(MouseState.Over);
		((Control)this).OnMouseUp(e);
	}

	protected override void OnMouseLeave(EventArgs e)
	{
		SetState(MouseState.None);
		if ((_Sizable && !_ControlMode && ((Control)this).GetChildAtPoint(((Control)this).PointToClient(Control.get_MousePosition())) != null) ? true : false)
		{
			((Control)this).set_Cursor(Cursors.get_Default());
			Previous = 0;
		}
		((Control)this).OnMouseLeave(e);
	}

	protected override void OnMouseDown(MouseEventArgs e)
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Invalid comparison between Unknown and I4
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Invalid comparison between Unknown and I4
		((Control)this).OnMouseDown(e);
		if ((int)e.get_Button() != 1048576)
		{
			return;
		}
		SetState(MouseState.Down);
		if (((!_IsParentForm || (int)((ContainerControl)this).get_ParentForm().get_WindowState() != 2) && !_ControlMode) || 1 == 0)
		{
			if ((_Movable && Header.Contains(e.get_Location())) ? true : false)
			{
				((Control)this).set_Capture(false);
				((Control)this).DefWndProc(ref Messages[0]);
			}
			else if ((_Sizable && Previous != 0) ? true : false)
			{
				((Control)this).set_Capture(false);
				((Control)this).DefWndProc(ref Messages[Previous]);
			}
		}
	}

	private int GetIndex()
	{
		GetIndexPoint = ((Control)this).PointToClient(Control.get_MousePosition());
		B1 = GetIndexPoint.X < 7;
		checked
		{
			B2 = GetIndexPoint.X > ((Control)this).get_Width() - 7;
			B3 = GetIndexPoint.Y < 7;
			B4 = GetIndexPoint.Y > ((Control)this).get_Height() - 7;
			if ((B1 && B3) ? true : false)
			{
				return 4;
			}
			if ((B1 && B4) ? true : false)
			{
				return 7;
			}
			if ((B2 && B3) ? true : false)
			{
				return 5;
			}
			if ((B2 && B4) ? true : false)
			{
				return 8;
			}
			if (B1)
			{
				return 1;
			}
			if (B2)
			{
				return 2;
			}
			if (B3)
			{
				return 3;
			}
			if (B4)
			{
				return 6;
			}
			return 0;
		}
	}

	private void InvalidateMouse()
	{
		Current = GetIndex();
		if (Current != Previous)
		{
			Previous = Current;
			switch (Previous)
			{
			case 0:
				((Control)this).set_Cursor(Cursors.get_Default());
				break;
			case 1:
			case 2:
				((Control)this).set_Cursor(Cursors.get_SizeWE());
				break;
			case 3:
			case 6:
				((Control)this).set_Cursor(Cursors.get_SizeNS());
				break;
			case 5:
			case 7:
				((Control)this).set_Cursor(Cursors.get_SizeNESW());
				break;
			case 4:
			case 8:
				((Control)this).set_Cursor(Cursors.get_SizeNWSE());
				break;
			}
		}
	}

	private void InitializeMessages()
	{
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		ref Message reference = ref Messages[0];
		IntPtr handle = ((Control)this).get_Parent().get_Handle();
		IntPtr intPtr = new IntPtr(2);
		reference = Message.Create(handle, 161, intPtr, IntPtr.Zero);
		int num = 1;
		checked
		{
			do
			{
				ref Message reference2 = ref Messages[num];
				IntPtr handle2 = ((Control)this).get_Parent().get_Handle();
				intPtr = new IntPtr(num + 9);
				reference2 = Message.Create(handle2, 161, intPtr, IntPtr.Zero);
				num++;
			}
			while (num <= 8);
		}
	}

	protected Color GetColor(string name)
	{
		return Items[name];
	}

	protected void SetColor(string name, Color color)
	{
		if (Items.ContainsKey(name))
		{
			Items[name] = color;
		}
		else
		{
			Items.Add(name, color);
		}
	}

	protected void SetColor(string name, byte r, byte g, byte b)
	{
		SetColor(name, Color.FromArgb(r, g, b));
	}

	protected void SetColor(string name, byte a, byte r, byte g, byte b)
	{
		SetColor(name, Color.FromArgb(a, r, g, b));
	}

	protected void SetColor(string name, byte a, Color color)
	{
		SetColor(name, Color.FromArgb(a, color));
	}

	private void InvalidateCustimization()
	{
		MemoryStream memoryStream = new MemoryStream(checked(Items.Count * 4));
		Bloom[] colors = Colors;
		foreach (Bloom bloom in colors)
		{
			memoryStream.Write(BitConverter.GetBytes(bloom.Value.ToArgb()), 0, 4);
		}
		memoryStream.Close();
		_Customization = Convert.ToBase64String(memoryStream.ToArray());
	}

	protected abstract void ColorHook();

	protected abstract void PaintHook();

	protected Point Center(Rectangle r1, Size s1)
	{
		ref Point centerReturn = ref CenterReturn;
		checked
		{
			centerReturn = new Point(unchecked(r1.Width / 2) - unchecked(s1.Width / 2) + r1.X, unchecked(r1.Height / 2) - unchecked(s1.Height / 2) + r1.Y);
			return CenterReturn;
		}
	}

	protected Point Center(Rectangle r1, Rectangle r2)
	{
		return Center(r1, r2.Size);
	}

	protected Point Center(int w1, int h1, int w2, int h2)
	{
		ref Point centerReturn = ref CenterReturn;
		checked
		{
			centerReturn = new Point(unchecked(w1 / 2) - unchecked(w2 / 2), unchecked(h1 / 2) - unchecked(h2 / 2));
			return CenterReturn;
		}
	}

	protected Point Center(Size s1, Size s2)
	{
		return Center(s1.Width, s1.Height, s2.Width, s2.Height);
	}

	protected Point Center(Rectangle r1)
	{
		return Center(((Control)this).get_ClientRectangle().Width, ((Control)this).get_ClientRectangle().Height, r1.Width, r1.Height);
	}

	protected Point Center(Size s1)
	{
		return Center(((Control)this).get_Width(), ((Control)this).get_Height(), s1.Width, s1.Height);
	}

	protected Point Center(int w1, int h1)
	{
		return Center(((Control)this).get_Width(), ((Control)this).get_Height(), w1, h1);
	}

	protected Size Measure(string text)
	{
		return MeasureGraphics.MeasureString(text, Font, ((Control)this).get_Width()).ToSize();
	}

	protected Size Measure()
	{
		return MeasureGraphics.MeasureString(Text, Font).ToSize();
	}

	protected void DrawCorners(Color c1)
	{
		DrawCorners(c1, 0, 0, ((Control)this).get_Width(), ((Control)this).get_Height());
	}

	protected void DrawCorners(Color c1, Rectangle r1)
	{
		DrawCorners(c1, r1.X, r1.Y, r1.Width, r1.Height);
	}

	protected void DrawCorners(Color c1, int x, int y, int width, int height)
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		checked
		{
			if (!_NoRounding)
			{
				DrawCornersBrush = new SolidBrush(c1);
				G.FillRectangle((Brush)(object)DrawCornersBrush, x, y, 1, 1);
				G.FillRectangle((Brush)(object)DrawCornersBrush, x + (width - 1), y, 1, 1);
				G.FillRectangle((Brush)(object)DrawCornersBrush, x, y + (height - 1), 1, 1);
				G.FillRectangle((Brush)(object)DrawCornersBrush, x + (width - 1), y + (height - 1), 1, 1);
			}
		}
	}

	protected void DrawBorders(Pen p1, int x, int y, int width, int height, int offset)
	{
		checked
		{
			DrawBorders(p1, x + offset, y + offset, width - offset * 2, height - offset * 2);
		}
	}

	protected void DrawBorders(Pen p1, int offset)
	{
		DrawBorders(p1, 0, 0, ((Control)this).get_Width(), ((Control)this).get_Height(), offset);
	}

	protected void DrawBorders(Pen p1, Rectangle r, int offset)
	{
		DrawBorders(p1, r.X, r.Y, r.Width, r.Height, offset);
	}

	protected void DrawBorders(Pen p1, int x, int y, int width, int height)
	{
		checked
		{
			G.DrawRectangle(p1, x, y, width - 1, height - 1);
		}
	}

	protected void DrawBorders(Pen p1)
	{
		DrawBorders(p1, 0, 0, ((Control)this).get_Width(), ((Control)this).get_Height());
	}

	protected void DrawBorders(Pen p1, Rectangle r)
	{
		DrawBorders(p1, r.X, r.Y, r.Width, r.Height);
	}

	protected void DrawText(Brush b1, HorizontalAlignment a, int x, int y)
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		DrawText(b1, Text, a, x, y);
	}

	protected void DrawText(Brush b1, Point p1)
	{
		DrawText(b1, Text, p1.X, p1.Y);
	}

	protected void DrawText(Brush b1, int x, int y)
	{
		DrawText(b1, Text, x, y);
	}

	protected void DrawText(Brush b1, string text, HorizontalAlignment a, int x, int y)
	{
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_0054: Expected I4, but got Unknown
		checked
		{
			if (text.Length != 0)
			{
				DrawTextSize = Measure(text);
				ref Point drawTextPoint = ref DrawTextPoint;
				drawTextPoint = new Point(unchecked(((Control)this).get_Width() / 2) - unchecked(DrawTextSize.Width / 2), unchecked(MoveHeight / 2) - unchecked(DrawTextSize.Height / 2));
				switch (unchecked((int)a))
				{
				case 0:
					DrawText(b1, text, x, DrawTextPoint.Y + y);
					break;
				case 1:
					DrawText(b1, text, ((Control)this).get_Width() - DrawTextSize.Width - x, DrawTextPoint.Y + y);
					break;
				case 2:
					DrawText(b1, text, DrawTextPoint.X + x, DrawTextPoint.Y + y);
					break;
				}
			}
		}
	}

	protected void DrawText(Brush b1, string text, Point p1)
	{
		DrawText(b1, text, p1.X, p1.Y);
	}

	protected void DrawText(Brush b1, string text, int x, int y)
	{
		if (text.Length != 0)
		{
			G.DrawString(text, Font, b1, (float)x, (float)y);
		}
	}

	protected void DrawImage(HorizontalAlignment a, int x, int y)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		DrawImage(_Image, a, x, y);
	}

	protected void DrawImage(Point p1)
	{
		DrawImage(_Image, p1.X, p1.Y);
	}

	protected void DrawImage(int x, int y)
	{
		DrawImage(_Image, x, y);
	}

	protected void DrawImage(Image image, HorizontalAlignment a, int x, int y)
	{
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Expected I4, but got Unknown
		checked
		{
			if (image != null)
			{
				ref Point drawImagePoint = ref DrawImagePoint;
				drawImagePoint = new Point(unchecked(((Control)this).get_Width() / 2) - unchecked(image.get_Width() / 2), unchecked(MoveHeight / 2) - unchecked(image.get_Height() / 2));
				switch (unchecked((int)a))
				{
				case 0:
					DrawImage(image, x, DrawImagePoint.Y + y);
					break;
				case 1:
					DrawImage(image, ((Control)this).get_Width() - image.get_Width() - x, DrawImagePoint.Y + y);
					break;
				case 2:
					DrawImage(image, DrawImagePoint.X + x, DrawImagePoint.Y + y);
					break;
				}
			}
		}
	}

	protected void DrawImage(Image image, Point p1)
	{
		DrawImage(image, p1.X, p1.Y);
	}

	protected void DrawImage(Image image, int x, int y)
	{
		if (image != null)
		{
			G.DrawImage(image, x, y, image.get_Width(), image.get_Height());
		}
	}

	protected void DrawGradient(ColorBlend blend, int x, int y, int width, int height)
	{
		DrawGradient(blend, x, y, width, height, 90f);
	}

	protected void DrawGradient(Color c1, Color c2, int x, int y, int width, int height)
	{
		DrawGradient(c1, c2, x, y, width, height, 90f);
	}

	protected void DrawGradient(ColorBlend blend, int x, int y, int width, int height, float angle)
	{
		ref Rectangle drawGradientRectangle = ref DrawGradientRectangle;
		drawGradientRectangle = new Rectangle(x, y, width, height);
		DrawGradient(blend, DrawGradientRectangle, angle);
	}

	protected void DrawGradient(Color c1, Color c2, int x, int y, int width, int height, float angle)
	{
		ref Rectangle drawGradientRectangle = ref DrawGradientRectangle;
		drawGradientRectangle = new Rectangle(x, y, width, height);
		DrawGradient(c1, c2, DrawGradientRectangle, angle);
	}

	protected void DrawGradient(ColorBlend blend, Rectangle r, float angle)
	{
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Expected O, but got Unknown
		DrawGradientBrush = new LinearGradientBrush(r, Color.Empty, Color.Empty, angle);
		DrawGradientBrush.set_InterpolationColors(blend);
		G.FillRectangle((Brush)(object)DrawGradientBrush, r);
	}

	protected void DrawGradient(Color c1, Color c2, Rectangle r, float angle)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Expected O, but got Unknown
		DrawGradientBrush = new LinearGradientBrush(r, c1, c2, angle);
		G.FillRectangle((Brush)(object)DrawGradientBrush, r);
	}
}
