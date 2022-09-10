using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace NoobCrypt2._0;

internal abstract class ThemeContainer154 : ContainerControl
{
	protected Graphics G;

	protected Bitmap B;

	private bool DoneCreation;

	private bool HasShown;

	private Rectangle Frame;

	protected MouseState State;

	private bool WM_LMBUTTONDOWN;

	private Point GetIndexPoint;

	private bool B1;

	private bool B2;

	private bool B3;

	private bool B4;

	private int Current;

	private int Previous;

	private Message[] Messages;

	private bool _BackColor;

	private bool _SmartBounds;

	private bool _Movable;

	private bool _Sizable;

	private Color _TransparencyKey;

	private FormBorderStyle _BorderStyle;

	private FormStartPosition _StartPosition;

	private bool _NoRounding;

	private Image _Image;

	private Dictionary<string, Color> Items;

	private string _Customization;

	private bool _Transparent;

	private Size _ImageSize;

	private bool _IsParentForm;

	private int _LockWidth;

	private int _LockHeight;

	private int _Header;

	private bool _ControlMode;

	private bool _IsAnimated;

	private Rectangle OffsetReturnRectangle;

	private Size OffsetReturnSize;

	private Point OffsetReturnPoint;

	private Point CenterReturn;

	private Bitmap MeasureBitmap;

	private Graphics MeasureGraphics;

	private SolidBrush DrawPixelBrush;

	private SolidBrush DrawCornersBrush;

	private Point DrawTextPoint;

	private Size DrawTextSize;

	private Point DrawImagePoint;

	private LinearGradientBrush DrawGradientBrush;

	private Rectangle DrawGradientRectangle;

	private GraphicsPath DrawRadialPath;

	private PathGradientBrush DrawRadialBrush1;

	private LinearGradientBrush DrawRadialBrush2;

	private Rectangle DrawRadialRectangle;

	private GraphicsPath CreateRoundPath;

	private Rectangle CreateRoundRectangle;

	public override DockStyle Dock
	{
		get
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_0007: Unknown result type (might be due to invalid IL or missing references)
			return ((Control)this).get_Dock();
		}
		set
		{
			//IL_000c: Unknown result type (might be due to invalid IL or missing references)
			if (_ControlMode)
			{
				((Control)this).set_Dock(value);
			}
		}
	}

	[Category("Misc")]
	public override Color BackColor
	{
		get
		{
			return ((Control)this).get_BackColor();
		}
		set
		{
			if (value == ((Control)this).get_BackColor())
			{
				return;
			}
			if ((!((Control)this).get_IsHandleCreated() && _ControlMode && value == Color.Transparent) ? true : false)
			{
				_BackColor = true;
				return;
			}
			((Control)this).set_BackColor(value);
			if (((Control)this).get_Parent() != null)
			{
				if (!_ControlMode)
				{
					((Control)this).get_Parent().set_BackColor(value);
				}
				ColorHook();
			}
		}
	}

	public override Size MinimumSize
	{
		get
		{
			return ((Control)this).get_MinimumSize();
		}
		set
		{
			((Control)this).set_MinimumSize(value);
			if (((Control)this).get_Parent() != null)
			{
				((Control)this).get_Parent().set_MinimumSize(value);
			}
		}
	}

	public override Size MaximumSize
	{
		get
		{
			return ((Control)this).get_MaximumSize();
		}
		set
		{
			((Control)this).set_MaximumSize(value);
			if (((Control)this).get_Parent() != null)
			{
				((Control)this).get_Parent().set_MaximumSize(value);
			}
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

	[EditorBrowsable(EditorBrowsableState.Never)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[Browsable(false)]
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
	[Browsable(false)]
	[EditorBrowsable(EditorBrowsableState.Never)]
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
	[EditorBrowsable(EditorBrowsableState.Never)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
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

	public bool SmartBounds
	{
		get
		{
			return _SmartBounds;
		}
		set
		{
			_SmartBounds = value;
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
			if (!(value == _TransparencyKey))
			{
				_TransparencyKey = value;
				if ((_IsParentForm && !_ControlMode) ? true : false)
				{
					((ContainerControl)this).get_ParentForm().set_TransparencyKey(value);
					ColorHook();
				}
			}
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
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			//IL_0002: Unknown result type (might be due to invalid IL or missing references)
			//IL_0023: Unknown result type (might be due to invalid IL or missing references)
			//IL_0029: Unknown result type (might be due to invalid IL or missing references)
			//IL_002b: Invalid comparison between Unknown and I4
			_BorderStyle = value;
			if ((_IsParentForm && !_ControlMode) ? true : false)
			{
				((ContainerControl)this).get_ParentForm().set_FormBorderStyle(value);
				if ((int)value != 0)
				{
					Movable = false;
					Sizable = false;
				}
			}
		}
	}

	public FormStartPosition StartPosition
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
				return ((ContainerControl)this).get_ParentForm().get_StartPosition();
			}
			return _StartPosition;
		}
		set
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			//IL_0002: Unknown result type (might be due to invalid IL or missing references)
			//IL_0023: Unknown result type (might be due to invalid IL or missing references)
			_StartPosition = value;
			if ((_IsParentForm && !_ControlMode) ? true : false)
			{
				((ContainerControl)this).get_ParentForm().set_StartPosition(value);
			}
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

	public Bloom[] Colors
	{
		get
		{
			List<Bloom> list = new List<Bloom>();
			Dictionary<string, Color>.Enumerator enumerator = Items.GetEnumerator();
			while (enumerator.MoveNext())
			{
				Bloom item = new Bloom(enumerator.Current.Key, enumerator.Current.Value);
				list.Add(item);
			}
			return list.ToArray();
		}
		set
		{
			for (int i = 0; i < value.Length; i = checked(i + 1))
			{
				Bloom bloom = value[i];
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

	public bool Transparent
	{
		get
		{
			return _Transparent;
		}
		set
		{
			_Transparent = value;
			if ((((Control)this).get_IsHandleCreated() || _ControlMode) && 0 == 0)
			{
				if ((!value && BackColor.A != byte.MaxValue) ? true : false)
				{
					throw new Exception("Unable to change value to false while a transparent BackColor is in use.");
				}
				((Control)this).SetStyle((ControlStyles)4, !value);
				((Control)this).SetStyle((ControlStyles)2048, value);
				InvalidateBitmap();
				((Control)this).Invalidate();
			}
		}
	}

	protected Size ImageSize => _ImageSize;

	protected bool IsParentForm => _IsParentForm;

	protected bool IsParentMdi
	{
		get
		{
			if (((Control)this).get_Parent() == null)
			{
				return false;
			}
			return ((Control)this).get_Parent().get_Parent() != null;
		}
	}

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

	protected int Header
	{
		get
		{
			return _Header;
		}
		set
		{
			_Header = value;
			if (!_ControlMode)
			{
				ref Rectangle frame = ref Frame;
				frame = checked(new Rectangle(7, 7, ((Control)this).get_Width() - 14, value - 7));
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
			Transparent = _Transparent;
			if ((_Transparent && _BackColor) ? true : false)
			{
				BackColor = Color.Transparent;
			}
			InvalidateBitmap();
			((Control)this).Invalidate();
		}
	}

	protected bool IsAnimated
	{
		get
		{
			return _IsAnimated;
		}
		set
		{
			_IsAnimated = value;
			InvalidateTimer();
		}
	}

	public ThemeContainer154()
	{
		//IL_005d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Expected O, but got Unknown
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Expected O, but got Unknown
		//IL_0086: Unknown result type (might be due to invalid IL or missing references)
		//IL_0090: Expected O, but got Unknown
		Messages = (Message[])(object)new Message[9];
		_SmartBounds = true;
		_Movable = true;
		_Sizable = true;
		Items = new Dictionary<string, Color>();
		_Header = 24;
		((Control)this).SetStyle((ControlStyles)139270, true);
		_ImageSize = Size.Empty;
		Font = new Font("Verdana", 8f);
		MeasureBitmap = new Bitmap(1, 1);
		MeasureGraphics = Graphics.FromImage((Image)(object)MeasureBitmap);
		DrawRadialPath = new GraphicsPath();
		InvalidateCustimization();
	}

	protected sealed override void OnHandleCreated(EventArgs e)
	{
		if (DoneCreation)
		{
			InitializeMessages();
		}
		InvalidateCustimization();
		ColorHook();
		if (_LockWidth != 0)
		{
			((Control)this).set_Width(_LockWidth);
		}
		if (_LockHeight != 0)
		{
			((Control)this).set_Height(_LockHeight);
		}
		if (!_ControlMode)
		{
			((Control)this).set_Dock((DockStyle)5);
		}
		Transparent = _Transparent;
		if ((_Transparent && _BackColor) ? true : false)
		{
			BackColor = Color.Transparent;
		}
		((Control)this).OnHandleCreated(e);
	}

	protected sealed override void OnParentChanged(EventArgs e)
	{
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		((ContainerControl)this).OnParentChanged(e);
		if (((Control)this).get_Parent() == null)
		{
			return;
		}
		_IsParentForm = ((Control)this).get_Parent() is Form;
		if (!_ControlMode)
		{
			InitializeMessages();
			if (_IsParentForm)
			{
				((ContainerControl)this).get_ParentForm().set_FormBorderStyle(_BorderStyle);
				((ContainerControl)this).get_ParentForm().set_TransparencyKey(_TransparencyKey);
				if (!((Component)(object)this).DesignMode)
				{
					((ContainerControl)this).get_ParentForm().add_Shown((EventHandler)FormShown);
				}
			}
			((Control)this).get_Parent().set_BackColor(BackColor);
		}
		OnCreation();
		DoneCreation = true;
		InvalidateTimer();
	}

	private void DoAnimation(bool i)
	{
		OnAnimation();
		if (i)
		{
			((Control)this).Invalidate();
		}
	}

	protected sealed override void OnPaint(PaintEventArgs e)
	{
		if ((((Control)this).get_Width() != 0 && ((Control)this).get_Height() != 0) || 1 == 0)
		{
			if ((_Transparent && _ControlMode) ? true : false)
			{
				PaintHook();
				e.get_Graphics().DrawImage((Image)(object)B, 0, 0);
			}
			else
			{
				G = e.get_Graphics();
				PaintHook();
			}
		}
	}

	protected override void OnHandleDestroyed(EventArgs e)
	{
		ThemeShare.RemoveAnimationCallback(DoAnimation);
		((Control)this).OnHandleDestroyed(e);
	}

	private void FormShown(object sender, EventArgs e)
	{
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Invalid comparison between Unknown and I4
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Invalid comparison between Unknown and I4
		if ((!_ControlMode && !HasShown) || 1 == 0)
		{
			if (((int)_StartPosition == 4 || (int)_StartPosition == 1) ? true : false)
			{
				Rectangle bounds = Screen.get_PrimaryScreen().get_Bounds();
				Rectangle bounds2 = ((Control)((ContainerControl)this).get_ParentForm()).get_Bounds();
				Form parentForm = ((ContainerControl)this).get_ParentForm();
				checked
				{
					Point location = new Point(unchecked(bounds.Width / 2) - unchecked(bounds2.Width / 2), unchecked(bounds.Height / 2) - unchecked(bounds2.Width / 2));
					parentForm.set_Location(location);
				}
			}
			HasShown = true;
		}
	}

	protected sealed override void OnSizeChanged(EventArgs e)
	{
		if ((_Movable && !_ControlMode) ? true : false)
		{
			ref Rectangle frame = ref Frame;
			frame = checked(new Rectangle(7, 7, ((Control)this).get_Width() - 14, _Header - 7));
		}
		InvalidateBitmap();
		((Control)this).Invalidate();
		((Control)this).OnSizeChanged(e);
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

	private void SetState(MouseState current)
	{
		State = current;
		((Control)this).Invalidate();
	}

	protected override void OnMouseMove(MouseEventArgs e)
	{
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Invalid comparison between Unknown and I4
		if ((!_IsParentForm || (int)((ContainerControl)this).get_ParentForm().get_WindowState() != 2) && true && ((_Sizable && !_ControlMode) ? true : false))
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
		if (((Control)this).GetChildAtPoint(((Control)this).PointToClient(Control.get_MousePosition())) != null && ((_Sizable && !_ControlMode) ? true : false))
		{
			((Control)this).set_Cursor(Cursors.get_Default());
			Previous = 0;
		}
		((Control)this).OnMouseLeave(e);
	}

	protected override void OnMouseDown(MouseEventArgs e)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Invalid comparison between Unknown and I4
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Invalid comparison between Unknown and I4
		if ((int)e.get_Button() == 1048576)
		{
			SetState(MouseState.Down);
		}
		if ((!_IsParentForm || (int)((ContainerControl)this).get_ParentForm().get_WindowState() != 2) && ((!_ControlMode) ? true : false))
		{
			if ((_Movable && Frame.Contains(e.get_Location())) ? true : false)
			{
				((Control)this).set_Capture(false);
				WM_LMBUTTONDOWN = true;
				((Control)this).DefWndProc(ref Messages[0]);
			}
			else if ((_Sizable && Previous != 0) ? true : false)
			{
				((Control)this).set_Capture(false);
				WM_LMBUTTONDOWN = true;
				((Control)this).DefWndProc(ref Messages[Previous]);
			}
		}
		((Control)this).OnMouseDown(e);
	}

	protected override void WndProc(ref Message m)
	{
		((ContainerControl)this).WndProc(ref m);
		if (!WM_LMBUTTONDOWN || ((Message)(ref m)).get_Msg() != 513 || 1 == 0)
		{
			return;
		}
		WM_LMBUTTONDOWN = false;
		SetState(MouseState.Over);
		if (_SmartBounds)
		{
			if (IsParentMdi)
			{
				Rectangle bounds = new Rectangle(Point.Empty, ((Control)this).get_Parent().get_Parent().get_Size());
				CorrectBounds(bounds);
			}
			else
			{
				CorrectBounds(Screen.FromControl(((Control)this).get_Parent()).get_WorkingArea());
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

	private void CorrectBounds(Rectangle bounds)
	{
		if (((Control)this).get_Parent().get_Width() > bounds.Width)
		{
			((Control)this).get_Parent().set_Width(bounds.Width);
		}
		if (((Control)this).get_Parent().get_Height() > bounds.Height)
		{
			((Control)this).get_Parent().set_Height(bounds.Height);
		}
		int num = ((Control)this).get_Parent().get_Location().X;
		int num2 = ((Control)this).get_Parent().get_Location().Y;
		if (num < bounds.X)
		{
			num = bounds.X;
		}
		if (num2 < bounds.Y)
		{
			num2 = bounds.Y;
		}
		checked
		{
			int num3 = bounds.X + bounds.Width;
			int num4 = bounds.Y + bounds.Height;
			if (num + ((Control)this).get_Parent().get_Width() > num3)
			{
				num = num3 - ((Control)this).get_Parent().get_Width();
			}
			if (num2 + ((Control)this).get_Parent().get_Height() > num4)
			{
				num2 = num4 - ((Control)this).get_Parent().get_Height();
			}
			Control parent = ((Control)this).get_Parent();
			Point location = new Point(num, num2);
			parent.set_Location(location);
		}
	}

	protected Pen GetPen(string name)
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Expected O, but got Unknown
		return new Pen(Items[name]);
	}

	protected Pen GetPen(string name, float width)
	{
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Expected O, but got Unknown
		return new Pen(Items[name], width);
	}

	protected SolidBrush GetBrush(string name)
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Expected O, but got Unknown
		return new SolidBrush(Items[name]);
	}

	protected Color GetColor(string name)
	{
		return Items[name];
	}

	protected void SetColor(string name, Color value)
	{
		if (Items.ContainsKey(name))
		{
			Items[name] = value;
		}
		else
		{
			Items.Add(name, value);
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

	protected void SetColor(string name, byte a, Color value)
	{
		SetColor(name, Color.FromArgb(a, value));
	}

	private void InvalidateBitmap()
	{
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Expected O, but got Unknown
		if ((_Transparent && _ControlMode) ? true : false)
		{
			if ((((Control)this).get_Width() != 0 && ((Control)this).get_Height() != 0) || 1 == 0)
			{
				B = new Bitmap(((Control)this).get_Width(), ((Control)this).get_Height(), (PixelFormat)925707);
				G = Graphics.FromImage((Image)(object)B);
			}
		}
		else
		{
			G = null;
			B = null;
		}
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

	private void InvalidateTimer()
	{
		if ((!((Component)(object)this).DesignMode && DoneCreation) || 1 == 0)
		{
			if (_IsAnimated)
			{
				ThemeShare.AddAnimationCallback(DoAnimation);
			}
			else
			{
				ThemeShare.RemoveAnimationCallback(DoAnimation);
			}
		}
	}

	protected abstract void ColorHook();

	protected abstract void PaintHook();

	protected virtual void OnCreation()
	{
	}

	protected virtual void OnAnimation()
	{
	}

	protected Rectangle Offset(Rectangle r, int amount)
	{
		ref Rectangle offsetReturnRectangle = ref OffsetReturnRectangle;
		offsetReturnRectangle = checked(new Rectangle(r.X + amount, r.Y + amount, r.Width - amount * 2, r.Height - amount * 2));
		return OffsetReturnRectangle;
	}

	protected Size Offset(Size s, int amount)
	{
		ref Size offsetReturnSize = ref OffsetReturnSize;
		offsetReturnSize = checked(new Size(s.Width + amount, s.Height + amount));
		return OffsetReturnSize;
	}

	protected Point Offset(Point p, int amount)
	{
		ref Point offsetReturnPoint = ref OffsetReturnPoint;
		offsetReturnPoint = checked(new Point(p.X + amount, p.Y + amount));
		return OffsetReturnPoint;
	}

	protected Point Center(Rectangle p, Rectangle c)
	{
		ref Point centerReturn = ref CenterReturn;
		checked
		{
			centerReturn = new Point(unchecked(p.Width / 2) - unchecked(c.Width / 2) + p.X + c.X, unchecked(p.Height / 2) - unchecked(c.Height / 2) + p.Y + c.Y);
			return CenterReturn;
		}
	}

	protected Point Center(Rectangle p, Size c)
	{
		ref Point centerReturn = ref CenterReturn;
		checked
		{
			centerReturn = new Point(unchecked(p.Width / 2) - unchecked(c.Width / 2) + p.X, unchecked(p.Height / 2) - unchecked(c.Height / 2) + p.Y);
			return CenterReturn;
		}
	}

	protected Point Center(Rectangle child)
	{
		return Center(((Control)this).get_Width(), ((Control)this).get_Height(), child.Width, child.Height);
	}

	protected Point Center(Size child)
	{
		return Center(((Control)this).get_Width(), ((Control)this).get_Height(), child.Width, child.Height);
	}

	protected Point Center(int childWidth, int childHeight)
	{
		return Center(((Control)this).get_Width(), ((Control)this).get_Height(), childWidth, childHeight);
	}

	protected Point Center(Size p, Size c)
	{
		return Center(p.Width, p.Height, c.Width, c.Height);
	}

	protected Point Center(int pWidth, int pHeight, int cWidth, int cHeight)
	{
		ref Point centerReturn = ref CenterReturn;
		checked
		{
			centerReturn = new Point(unchecked(pWidth / 2) - unchecked(cWidth / 2), unchecked(pHeight / 2) - unchecked(cHeight / 2));
			return CenterReturn;
		}
	}

	protected Size Measure()
	{
		lock (MeasureGraphics)
		{
			return MeasureGraphics.MeasureString(Text, Font, ((Control)this).get_Width()).ToSize();
		}
	}

	protected Size Measure(string text)
	{
		lock (MeasureGraphics)
		{
			return MeasureGraphics.MeasureString(text, Font, ((Control)this).get_Width()).ToSize();
		}
	}

	protected void DrawPixel(Color c1, int x, int y)
	{
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Expected O, but got Unknown
		if (_Transparent)
		{
			B.SetPixel(x, y, c1);
			return;
		}
		DrawPixelBrush = new SolidBrush(c1);
		G.FillRectangle((Brush)(object)DrawPixelBrush, x, y, 1, 1);
	}

	protected void DrawCorners(Color c1, int offset)
	{
		DrawCorners(c1, 0, 0, ((Control)this).get_Width(), ((Control)this).get_Height(), offset);
	}

	protected void DrawCorners(Color c1, Rectangle r1, int offset)
	{
		DrawCorners(c1, r1.X, r1.Y, r1.Width, r1.Height, offset);
	}

	protected void DrawCorners(Color c1, int x, int y, int width, int height, int offset)
	{
		checked
		{
			DrawCorners(c1, x + offset, y + offset, width - offset * 2, height - offset * 2);
		}
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
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		//IL_006d: Expected O, but got Unknown
		checked
		{
			if (!_NoRounding)
			{
				if (_Transparent)
				{
					B.SetPixel(x, y, c1);
					B.SetPixel(x + (width - 1), y, c1);
					B.SetPixel(x, y + (height - 1), c1);
					B.SetPixel(x + (width - 1), y + (height - 1), c1);
				}
				else
				{
					DrawCornersBrush = new SolidBrush(c1);
					G.FillRectangle((Brush)(object)DrawCornersBrush, x, y, 1, 1);
					G.FillRectangle((Brush)(object)DrawCornersBrush, x + (width - 1), y, 1, 1);
					G.FillRectangle((Brush)(object)DrawCornersBrush, x, y + (height - 1), 1, 1);
					G.FillRectangle((Brush)(object)DrawCornersBrush, x + (width - 1), y + (height - 1), 1, 1);
				}
			}
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

	protected void DrawBorders(Pen p1, int x, int y, int width, int height, int offset)
	{
		checked
		{
			DrawBorders(p1, x + offset, y + offset, width - offset * 2, height - offset * 2);
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

	protected void DrawBorders(Pen p1, int x, int y, int width, int height)
	{
		checked
		{
			G.DrawRectangle(p1, x, y, width - 1, height - 1);
		}
	}

	protected void DrawText(Brush b1, HorizontalAlignment a, int x, int y)
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		DrawText(b1, Text, a, x, y);
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
				drawTextPoint = new Point(unchecked(((Control)this).get_Width() / 2) - unchecked(DrawTextSize.Width / 2), unchecked(Header / 2) - unchecked(DrawTextSize.Height / 2));
				switch (unchecked((int)a))
				{
				case 0:
					G.DrawString(text, Font, b1, (float)x, (float)(DrawTextPoint.Y + y));
					break;
				case 1:
					G.DrawString(text, Font, b1, (float)(((Control)this).get_Width() - DrawTextSize.Width - x), (float)(DrawTextPoint.Y + y));
					break;
				case 2:
					G.DrawString(text, Font, b1, (float)(DrawTextPoint.X + x), (float)(DrawTextPoint.Y + y));
					break;
				}
			}
		}
	}

	protected void DrawText(Brush b1, Point p1)
	{
		if (Text.Length != 0)
		{
			G.DrawString(Text, Font, b1, (PointF)p1);
		}
	}

	protected void DrawText(Brush b1, int x, int y)
	{
		if (Text.Length != 0)
		{
			G.DrawString(Text, Font, b1, (float)x, (float)y);
		}
	}

	protected void DrawImage(HorizontalAlignment a, int x, int y)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		DrawImage(_Image, a, x, y);
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
				drawImagePoint = new Point(unchecked(((Control)this).get_Width() / 2) - unchecked(image.get_Width() / 2), unchecked(Header / 2) - unchecked(image.get_Height() / 2));
				switch (unchecked((int)a))
				{
				case 0:
					G.DrawImage(image, x, DrawImagePoint.Y + y, image.get_Width(), image.get_Height());
					break;
				case 1:
					G.DrawImage(image, ((Control)this).get_Width() - image.get_Width() - x, DrawImagePoint.Y + y, image.get_Width(), image.get_Height());
					break;
				case 2:
					G.DrawImage(image, DrawImagePoint.X + x, DrawImagePoint.Y + y, image.get_Width(), image.get_Height());
					break;
				}
			}
		}
	}

	protected void DrawImage(Point p1)
	{
		DrawImage(_Image, p1.X, p1.Y);
	}

	protected void DrawImage(int x, int y)
	{
		DrawImage(_Image, x, y);
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
		ref Rectangle drawGradientRectangle = ref DrawGradientRectangle;
		drawGradientRectangle = new Rectangle(x, y, width, height);
		DrawGradient(blend, DrawGradientRectangle);
	}

	protected void DrawGradient(ColorBlend blend, int x, int y, int width, int height, float angle)
	{
		ref Rectangle drawGradientRectangle = ref DrawGradientRectangle;
		drawGradientRectangle = new Rectangle(x, y, width, height);
		DrawGradient(blend, DrawGradientRectangle, angle);
	}

	protected void DrawGradient(ColorBlend blend, Rectangle r)
	{
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Expected O, but got Unknown
		DrawGradientBrush = new LinearGradientBrush(r, Color.Empty, Color.Empty, 90f);
		DrawGradientBrush.set_InterpolationColors(blend);
		G.FillRectangle((Brush)(object)DrawGradientBrush, r);
	}

	protected void DrawGradient(ColorBlend blend, Rectangle r, float angle)
	{
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Expected O, but got Unknown
		DrawGradientBrush = new LinearGradientBrush(r, Color.Empty, Color.Empty, angle);
		DrawGradientBrush.set_InterpolationColors(blend);
		G.FillRectangle((Brush)(object)DrawGradientBrush, r);
	}

	protected void DrawGradient(Color c1, Color c2, int x, int y, int width, int height)
	{
		ref Rectangle drawGradientRectangle = ref DrawGradientRectangle;
		drawGradientRectangle = new Rectangle(x, y, width, height);
		DrawGradient(c1, c2, DrawGradientRectangle);
	}

	protected void DrawGradient(Color c1, Color c2, int x, int y, int width, int height, float angle)
	{
		ref Rectangle drawGradientRectangle = ref DrawGradientRectangle;
		drawGradientRectangle = new Rectangle(x, y, width, height);
		DrawGradient(c1, c2, DrawGradientRectangle, angle);
	}

	protected void DrawGradient(Color c1, Color c2, Rectangle r)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Expected O, but got Unknown
		DrawGradientBrush = new LinearGradientBrush(r, c1, c2, 90f);
		G.FillRectangle((Brush)(object)DrawGradientBrush, r);
	}

	protected void DrawGradient(Color c1, Color c2, Rectangle r, float angle)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Expected O, but got Unknown
		DrawGradientBrush = new LinearGradientBrush(r, c1, c2, angle);
		G.FillRectangle((Brush)(object)DrawGradientBrush, r);
	}

	public void DrawRadial(ColorBlend blend, int x, int y, int width, int height)
	{
		ref Rectangle drawRadialRectangle = ref DrawRadialRectangle;
		drawRadialRectangle = new Rectangle(x, y, width, height);
		DrawRadial(blend, DrawRadialRectangle, width / 2, height / 2);
	}

	public void DrawRadial(ColorBlend blend, int x, int y, int width, int height, Point center)
	{
		ref Rectangle drawRadialRectangle = ref DrawRadialRectangle;
		drawRadialRectangle = new Rectangle(x, y, width, height);
		DrawRadial(blend, DrawRadialRectangle, center.X, center.Y);
	}

	public void DrawRadial(ColorBlend blend, int x, int y, int width, int height, int cx, int cy)
	{
		ref Rectangle drawRadialRectangle = ref DrawRadialRectangle;
		drawRadialRectangle = new Rectangle(x, y, width, height);
		DrawRadial(blend, DrawRadialRectangle, cx, cy);
	}

	public void DrawRadial(ColorBlend blend, Rectangle r)
	{
		DrawRadial(blend, r, r.Width / 2, r.Height / 2);
	}

	public void DrawRadial(ColorBlend blend, Rectangle r, Point center)
	{
		DrawRadial(blend, r, center.X, center.Y);
	}

	public void DrawRadial(ColorBlend blend, Rectangle r, int cx, int cy)
	{
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Expected O, but got Unknown
		//IL_0084: Unknown result type (might be due to invalid IL or missing references)
		//IL_008a: Invalid comparison between Unknown and I4
		DrawRadialPath.Reset();
		checked
		{
			DrawRadialPath.AddEllipse(r.X, r.Y, r.Width - 1, r.Height - 1);
			DrawRadialBrush1 = new PathGradientBrush(DrawRadialPath);
			PathGradientBrush drawRadialBrush = DrawRadialBrush1;
			Point point = new Point(r.X + cx, r.Y + cy);
			drawRadialBrush.set_CenterPoint((PointF)point);
			DrawRadialBrush1.set_InterpolationColors(blend);
			if (unchecked((int)G.get_SmoothingMode()) == 4)
			{
				G.FillEllipse((Brush)(object)DrawRadialBrush1, r.X + 1, r.Y + 1, r.Width - 3, r.Height - 3);
			}
			else
			{
				G.FillEllipse((Brush)(object)DrawRadialBrush1, r);
			}
		}
	}

	protected void DrawRadial(Color c1, Color c2, int x, int y, int width, int height)
	{
		ref Rectangle drawRadialRectangle = ref DrawRadialRectangle;
		drawRadialRectangle = new Rectangle(x, y, width, height);
		DrawRadial(c1, c2, DrawGradientRectangle);
	}

	protected void DrawRadial(Color c1, Color c2, int x, int y, int width, int height, float angle)
	{
		ref Rectangle drawRadialRectangle = ref DrawRadialRectangle;
		drawRadialRectangle = new Rectangle(x, y, width, height);
		DrawRadial(c1, c2, DrawGradientRectangle, angle);
	}

	protected void DrawRadial(Color c1, Color c2, Rectangle r)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Expected O, but got Unknown
		DrawRadialBrush2 = new LinearGradientBrush(r, c1, c2, 90f);
		G.FillRectangle((Brush)(object)DrawGradientBrush, r);
	}

	protected void DrawRadial(Color c1, Color c2, Rectangle r, float angle)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Expected O, but got Unknown
		DrawRadialBrush2 = new LinearGradientBrush(r, c1, c2, angle);
		G.FillEllipse((Brush)(object)DrawGradientBrush, r);
	}

	public GraphicsPath CreateRound(int x, int y, int width, int height, int slope)
	{
		ref Rectangle createRoundRectangle = ref CreateRoundRectangle;
		createRoundRectangle = new Rectangle(x, y, width, height);
		return CreateRound(CreateRoundRectangle, slope);
	}

	public GraphicsPath CreateRound(Rectangle r, int slope)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Expected O, but got Unknown
		CreateRoundPath = new GraphicsPath((FillMode)1);
		CreateRoundPath.AddArc(r.X, r.Y, slope, slope, 180f, 90f);
		checked
		{
			CreateRoundPath.AddArc(r.Right - slope, r.Y, slope, slope, 270f, 90f);
			CreateRoundPath.AddArc(r.Right - slope, r.Bottom - slope, slope, slope, 0f, 90f);
			CreateRoundPath.AddArc(r.X, r.Bottom - slope, slope, slope, 90f, 90f);
			CreateRoundPath.CloseFigure();
			return CreateRoundPath;
		}
	}
}
