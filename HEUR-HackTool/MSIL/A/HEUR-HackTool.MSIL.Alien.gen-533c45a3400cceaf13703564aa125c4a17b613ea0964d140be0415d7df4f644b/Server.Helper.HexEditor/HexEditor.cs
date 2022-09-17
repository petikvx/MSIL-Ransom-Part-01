using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Server.Helper.HexEditor;

public class HexEditor : Control
{
	public enum CaseStyle
	{
		LowerCase,
		UpperCase
	}

	private object _caretLock = new object();

	private object _hexTableLock = new object();

	private IKeyMouseEventHandler _handler;

	private EditView _editView;

	private ByteCollection _hexTable;

	private string _lineCountCaps = "X";

	private int _nrCharsLineCount = 4;

	private Caret _caret;

	private Rectangle _recContent;

	private Rectangle _recLineCount;

	private StringFormat _stringFormat;

	private int _firstByte;

	private int _lastByte;

	private int _maxBytesH;

	private int _maxBytesV;

	private int _maxBytes;

	private int _maxVisibleBytesV;

	private VScrollBar _vScrollBar;

	private int _vScrollBarWidth = 20;

	private int _vScrollPos;

	private int _vScrollMax;

	private int _vScrollMin;

	private int _vScrollSmall;

	private int _vScrollLarge;

	private SizeF _charSize;

	private bool _isVScrollHidden = true;

	private int _bytesPerLine = 8;

	private int _entityMargin = 10;

	private BorderStyle _borderStyle = (BorderStyle)2;

	private Color _borderColor = Color.Empty;

	private Color _selectionBackColor = Color.Blue;

	private Color _selectionForeColor = Color.White;

	private CaseStyle _lineCountCaseStyle = CaseStyle.UpperCase;

	private CaseStyle _hexViewCaseStyle = CaseStyle.UpperCase;

	private bool _isVScrollVisible;

	private bool _dragging;

	public override Font Font
	{
		set
		{
			((Control)this).set_Font(value);
			UpdateRectanglePositioning();
			((Control)this).Invalidate();
		}
	}

	[Browsable(false)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	public override string Text
	{
		get
		{
			return ((Control)this).get_Text();
		}
		set
		{
			((Control)this).set_Text(value);
		}
	}

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public byte[] HexTable
	{
		get
		{
			lock (_hexTableLock)
			{
				return _hexTable.ToArray();
			}
		}
		set
		{
			lock (_hexTableLock)
			{
				if (value == _hexTable.ToArray())
				{
					return;
				}
				_hexTable = new ByteCollection(value);
			}
			UpdateRectanglePositioning();
			((Control)this).Invalidate();
		}
	}

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public SizeF CharSize
	{
		get
		{
			return _charSize;
		}
		private set
		{
			if (!(_charSize == value))
			{
				_charSize = value;
				if (this.CharSizeChanged != null)
				{
					this.CharSizeChanged(this, EventArgs.Empty);
				}
			}
		}
	}

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public int MaxBytesV => _maxBytesV;

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public int FirstVisibleByte => _firstByte;

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public int LastVisibleByte => _lastByte;

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public bool VScrollBarHidden
	{
		get
		{
			return _isVScrollHidden;
		}
		set
		{
			if (_isVScrollHidden != value)
			{
				_isVScrollHidden = value;
				if (!_isVScrollHidden)
				{
					((Control)this).get_Controls().Add((Control)(object)_vScrollBar);
				}
				else
				{
					((Control)this).get_Controls().Remove((Control)(object)_vScrollBar);
				}
				UpdateRectanglePositioning();
				((Control)this).Invalidate();
			}
		}
	}

	[Description("Property that specifies the number of bytes to display per line.")]
	[Category("Hex")]
	[DefaultValue(8)]
	public int BytesPerLine
	{
		get
		{
			return _bytesPerLine;
		}
		set
		{
			if (_bytesPerLine != value)
			{
				_bytesPerLine = value;
				UpdateRectanglePositioning();
				((Control)this).Invalidate();
			}
		}
	}

	[Description("Property that specifies the margin between each of the entitys in the control.")]
	[Category("Hex")]
	[DefaultValue(10)]
	public int EntityMargin
	{
		get
		{
			return _entityMargin;
		}
		set
		{
			if (_entityMargin != value)
			{
				_entityMargin = value;
				UpdateRectanglePositioning();
				((Control)this).Invalidate();
			}
		}
	}

	[Description("Indicates where the control should have a border.")]
	[DefaultValue(/*Could not decode attribute arguments.*/)]
	[Category("Appearance")]
	public BorderStyle BorderStyle
	{
		get
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			return _borderStyle;
		}
		set
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000a: Unknown result type (might be due to invalid IL or missing references)
			//IL_000c: Invalid comparison between Unknown and I4
			//IL_001a: Unknown result type (might be due to invalid IL or missing references)
			//IL_001b: Unknown result type (might be due to invalid IL or missing references)
			if (_borderStyle != value)
			{
				if ((int)value != 1)
				{
					_borderColor = Color.Empty;
				}
				_borderStyle = value;
				UpdateRectanglePositioning();
				((Control)this).Invalidate();
			}
		}
	}

	[Description("Indicates the color to be used when displaying a FixedSingle border.")]
	[Category("Appearance")]
	[DefaultValue(typeof(Color), "Empty")]
	public Color BorderColor
	{
		get
		{
			return _borderColor;
		}
		set
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			//IL_0007: Invalid comparison between Unknown and I4
			if ((int)BorderStyle == 1 && !(_borderColor == value))
			{
				_borderColor = value;
				((Control)this).Invalidate();
			}
		}
	}

	[DefaultValue(typeof(Color), "Blue")]
	[Description("Property for the background color of the selected text areas.")]
	[Category("Hex")]
	public Color SelectionBackColor
	{
		get
		{
			return _selectionBackColor;
		}
		set
		{
			if (!(_selectionBackColor == value))
			{
				_selectionBackColor = value;
			}
		}
	}

	[Description("Property for the foreground color of the selected text areas.")]
	[Category("Hex")]
	[DefaultValue(typeof(Color), "White")]
	public Color SelectionForeColor
	{
		get
		{
			return _selectionForeColor;
		}
		set
		{
			if (!(_selectionForeColor == value))
			{
				_selectionForeColor = value;
			}
		}
	}

	[Description("Property for the case type to use on the line counter.")]
	[Category("Hex")]
	[DefaultValue(CaseStyle.UpperCase)]
	public CaseStyle LineCountCaseStyle
	{
		get
		{
			return _lineCountCaseStyle;
		}
		set
		{
			if (_lineCountCaseStyle != value)
			{
				_lineCountCaseStyle = value;
				if (_lineCountCaseStyle == CaseStyle.LowerCase)
				{
					_lineCountCaps = "x";
				}
				else
				{
					_lineCountCaps = "X";
				}
				((Control)this).Invalidate();
			}
		}
	}

	[DefaultValue(CaseStyle.UpperCase)]
	[Description("Property for the case type to use for the hexadecimal values view.")]
	[Category("Hex")]
	public CaseStyle HexViewCaseStyle
	{
		get
		{
			return _hexViewCaseStyle;
		}
		set
		{
			if (_hexViewCaseStyle != value)
			{
				_hexViewCaseStyle = value;
				if (_hexViewCaseStyle == CaseStyle.LowerCase)
				{
					_editView.SetLowerCase();
				}
				else
				{
					_editView.SetUpperCase();
				}
				((Control)this).Invalidate();
			}
		}
	}

	[Description("Property for the visibility of the vertical scrollbar.")]
	[Category("Hex")]
	[DefaultValue(false)]
	public bool VScrollBarVisisble
	{
		get
		{
			return _isVScrollVisible;
		}
		set
		{
			if (_isVScrollVisible != value)
			{
				_isVScrollVisible = value;
				UpdateRectanglePositioning();
				((Control)this).Invalidate();
			}
		}
	}

	public int CaretPosX
	{
		get
		{
			lock (_caretLock)
			{
				return _caret.Location.X;
			}
		}
	}

	public int CaretPosY
	{
		get
		{
			lock (_caretLock)
			{
				return _caret.Location.Y;
			}
		}
	}

	public int SelectionStart
	{
		get
		{
			lock (_caretLock)
			{
				return _caret.SelectionStart;
			}
		}
	}

	public int SelectionLength
	{
		get
		{
			lock (_caretLock)
			{
				return _caret.SelectionLength;
			}
		}
	}

	public int CaretIndex
	{
		get
		{
			lock (_caretLock)
			{
				return _caret.CurrentIndex;
			}
		}
	}

	public bool CaretFocused
	{
		get
		{
			lock (_caretLock)
			{
				return _caret.Focused;
			}
		}
	}

	public int HexTableLength
	{
		get
		{
			lock (_hexTableLock)
			{
				return _hexTable.Length;
			}
		}
	}

	[Description("Event that is triggered whenever the hextable has been changed.")]
	public event EventHandler HexTableChanged;

	[Description("Event that is triggered whenever the SelectionStart value is changed.")]
	public event EventHandler SelectionStartChanged;

	[Description("Event that is triggered whenever the SelectionLength value is changed.")]
	public event EventHandler SelectionLengthChanged;

	[Description("Event that is triggered whenever the size of the char is changed.")]
	public event EventHandler CharSizeChanged;

	protected void OnVScrollBarScroll(object sender, ScrollEventArgs e)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Expected I4, but got Unknown
		ScrollEventType type = e.get_Type();
		switch ((int)type)
		{
		case 0:
			ScrollLineUp(1);
			break;
		case 1:
			ScrollLineDown(1);
			break;
		case 2:
			ScrollLineUp(_vScrollLarge);
			break;
		case 3:
			ScrollLineDown(_vScrollLarge);
			break;
		case 5:
			ScrollThumbTrack(e.get_NewValue() - e.get_OldValue());
			break;
		}
		((Control)this).Invalidate();
	}

	protected void CaretSelectionStartChanged(object sender, EventArgs e)
	{
		if (this.SelectionStartChanged != null)
		{
			this.SelectionStartChanged(this, e);
		}
	}

	protected void CaretSelectionLengthChanged(object sender, EventArgs e)
	{
		if (this.SelectionLengthChanged != null)
		{
			this.SelectionLengthChanged(this, e);
		}
	}

	protected override void OnMarginChanged(EventArgs e)
	{
		((Control)this).OnMarginChanged(e);
		UpdateRectanglePositioning();
		((Control)this).Invalidate();
	}

	protected override void OnGotFocus(EventArgs e)
	{
		if (_handler != null)
		{
			_handler.OnGotFocus(e);
		}
		UpdateRectanglePositioning();
		((Control)this).Invalidate();
		((Control)this).OnGotFocus(e);
	}

	protected override void OnLostFocus(EventArgs e)
	{
		_dragging = false;
		DestroyCaret();
		((Control)this).OnLostFocus(e);
	}

	protected override bool IsInputKey(Keys keyData)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_0005: Invalid comparison between Unknown and I4
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Invalid comparison between Unknown and I4
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		if (keyData - 37 > 3 && keyData - 65573 > 3)
		{
			return ((Control)this).IsInputKey(keyData);
		}
		return true;
	}

	protected override void OnKeyPress(KeyPressEventArgs e)
	{
		if (_handler != null)
		{
			_handler.OnKeyPress(e);
		}
		((Control)this).OnKeyPress(e);
	}

	protected override void OnKeyDown(KeyEventArgs e)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Invalid comparison between Unknown and I4
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Invalid comparison between Unknown and I4
		if ((int)e.get_KeyCode() == 34)
		{
			if (!_isVScrollHidden)
			{
				ScrollLineDown(_vScrollLarge);
				((Control)this).Invalidate();
			}
		}
		else if ((int)e.get_KeyCode() == 33)
		{
			if (!_isVScrollHidden)
			{
				ScrollLineUp(_vScrollLarge);
				((Control)this).Invalidate();
			}
		}
		else if (_handler != null)
		{
			_handler.OnKeyDown(e);
		}
		((Control)this).OnKeyDown(e);
	}

	protected override void OnKeyUp(KeyEventArgs e)
	{
		if (_handler != null)
		{
			_handler.OnKeyUp(e);
		}
		((Control)this).OnKeyUp(e);
	}

	protected override void OnMouseDown(MouseEventArgs e)
	{
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Invalid comparison between Unknown and I4
		if (((Control)this).get_Focused())
		{
			if (_handler != null)
			{
				_handler.OnMouseDown(e);
			}
			if ((int)e.get_Button() == 1048576)
			{
				_dragging = true;
				((Control)this).Invalidate();
			}
		}
		else
		{
			((Control)this).Focus();
		}
		((Control)this).OnMouseDown(e);
	}

	protected override void OnMouseMove(MouseEventArgs e)
	{
		if (((Control)this).get_Focused() && _dragging)
		{
			if (_handler != null)
			{
				_handler.OnMouseDragged(e);
			}
			((Control)this).Invalidate();
		}
		((Control)this).OnMouseMove(e);
	}

	protected override void OnMouseUp(MouseEventArgs e)
	{
		_dragging = false;
		if (((Control)this).get_Focused() && _handler != null)
		{
			_handler.OnMouseUp(e);
		}
		((Control)this).OnMouseUp(e);
	}

	protected override void OnMouseDoubleClick(MouseEventArgs e)
	{
		if (((Control)this).get_Focused() && _handler != null)
		{
			_handler.OnMouseDoubleClick(e);
		}
		((Control)this).OnMouseDoubleClick(e);
	}

	public void SetCaretStart(int index, Point location)
	{
		location = ScrollToCaret(index, location);
		lock (_caretLock)
		{
			_caret.SetStartIndex(index);
			_caret.SetCaretLocation(location);
		}
		((Control)this).Invalidate();
	}

	public void SetCaretEnd(int index, Point location)
	{
		location = ScrollToCaret(index, location);
		lock (_caretLock)
		{
			_caret.SetEndIndex(index);
			_caret.SetCaretLocation(location);
		}
		((Control)this).Invalidate();
	}

	public bool IsSelected(int byteIndex)
	{
		lock (_caretLock)
		{
			return _caret.IsSelected(byteIndex);
		}
	}

	public void DestroyCaret()
	{
		lock (_caretLock)
		{
			_caret.Destroy();
		}
	}

	public void RemoveSelectedBytes()
	{
		int selectionStart = SelectionStart;
		int selectionLength = SelectionLength;
		if (selectionLength > 0)
		{
			lock (_hexTableLock)
			{
				_hexTable.RemoveRange(selectionStart, selectionLength);
			}
			UpdateRectanglePositioning();
			((Control)this).Invalidate();
			if (this.HexTableChanged != null)
			{
				this.HexTableChanged(this, EventArgs.Empty);
			}
		}
	}

	public void RemoveByteAt(int index)
	{
		lock (_hexTableLock)
		{
			_hexTable.RemoveAt(index);
		}
		UpdateRectanglePositioning();
		((Control)this).Invalidate();
		if (this.HexTableChanged != null)
		{
			this.HexTableChanged(this, EventArgs.Empty);
		}
	}

	public void AppendByte(byte item)
	{
		lock (_hexTableLock)
		{
			_hexTable.Add(item);
		}
		UpdateRectanglePositioning();
		((Control)this).Invalidate();
		if (this.HexTableChanged != null)
		{
			this.HexTableChanged(this, EventArgs.Empty);
		}
	}

	public void InsertByte(int index, byte item)
	{
		lock (_hexTableLock)
		{
			_hexTable.Insert(index, item);
		}
		UpdateRectanglePositioning();
		((Control)this).Invalidate();
		if (this.HexTableChanged != null)
		{
			this.HexTableChanged(this, EventArgs.Empty);
		}
	}

	public char GetByteAsChar(int index)
	{
		lock (_hexTableLock)
		{
			return _hexTable.GetCharAt(index);
		}
	}

	public byte GetByte(int index)
	{
		lock (_hexTableLock)
		{
			return _hexTable.GetAt(index);
		}
	}

	public void SetByte(int index, byte item)
	{
		lock (_hexTableLock)
		{
			_hexTable.SetAt(index, item);
		}
		((Control)this).Invalidate();
		if (this.HexTableChanged != null)
		{
			this.HexTableChanged(this, EventArgs.Empty);
		}
	}

	public void ScrollLineUp(int lines)
	{
		if (_firstByte <= 0)
		{
			return;
		}
		lines = ((lines > _vScrollPos) ? _vScrollPos : lines);
		_vScrollPos -= _vScrollSmall * lines;
		UpdateVisibleByteIndex();
		UpdateScrollValues();
		if (CaretFocused)
		{
			Point caretLocation = new Point(CaretPosX, CaretPosY);
			caretLocation.Y += _recLineCount.Height * lines;
			lock (_caretLock)
			{
				_caret.SetCaretLocation(caretLocation);
			}
		}
	}

	public void ScrollLineDown(int lines)
	{
		if (_vScrollPos > _vScrollMax - _vScrollLarge)
		{
			return;
		}
		lines = ((lines + _vScrollPos > _vScrollMax - _vScrollLarge) ? (_vScrollMax - _vScrollLarge - _vScrollPos + 1) : lines);
		_vScrollPos += _vScrollSmall * lines;
		UpdateVisibleByteIndex();
		UpdateScrollValues();
		if (!CaretFocused)
		{
			return;
		}
		Point caretLocation = new Point(CaretPosX, CaretPosY);
		caretLocation.Y -= _recLineCount.Height * lines;
		lock (_caretLock)
		{
			_caret.SetCaretLocation(caretLocation);
			if (caretLocation.Y < _recContent.Y)
			{
				_caret.Hide(((Control)this).get_Handle());
			}
		}
	}

	public void ScrollThumbTrack(int lines)
	{
		if (lines != 0)
		{
			if (lines < 0)
			{
				ScrollLineUp(-1 * lines);
			}
			else
			{
				ScrollLineDown(lines);
			}
		}
	}

	public Point ScrollToCaret(int caretIndex, Point position)
	{
		if (position.Y < 0)
		{
			_vScrollPos -= Math.Abs((position.Y - _recContent.Y) / _recLineCount.Height) * _vScrollSmall;
			UpdateVisibleByteIndex();
			UpdateScrollValues();
			if (CaretFocused)
			{
				position.Y = _recContent.Y;
			}
		}
		else if (position.Y > _maxVisibleBytesV * _recLineCount.Height)
		{
			_vScrollPos += (position.Y / _recLineCount.Height - (_maxVisibleBytesV - 1)) * _vScrollSmall;
			if (_vScrollPos > _vScrollMax - (_vScrollLarge - 1))
			{
				_vScrollPos = _vScrollMax - (_vScrollLarge - 1);
			}
			UpdateVisibleByteIndex();
			UpdateScrollValues();
			if (CaretFocused)
			{
				position.Y = (_maxVisibleBytesV - 1) * _recLineCount.Height + _recContent.Y;
			}
		}
		return position;
	}

	private void UpdateRectanglePositioning()
	{
		//IL_007e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0083: Unknown result type (might be due to invalid IL or missing references)
		//IL_009e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00be: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00de: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f8: Invalid comparison between Unknown and I4
		//IL_0149: Unknown result type (might be due to invalid IL or missing references)
		//IL_014f: Invalid comparison between Unknown and I4
		//IL_01de: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0203: Unknown result type (might be due to invalid IL or missing references)
		//IL_0208: Unknown result type (might be due to invalid IL or missing references)
		if (((Control)this).get_ClientRectangle().Width != 0)
		{
			Graphics val = ((Control)this).CreateGraphics();
			SizeF sizeF;
			try
			{
				sizeF = val.MeasureString("D", ((Control)this).get_Font(), 100, _stringFormat);
			}
			finally
			{
				((IDisposable)val)?.Dispose();
			}
			CharSize = new SizeF((float)Math.Ceiling(sizeF.Width), (float)Math.Ceiling(sizeF.Height));
			_recContent = ((Control)this).get_ClientRectangle();
			ref Rectangle recContent = ref _recContent;
			int x = recContent.X;
			Padding margin = ((Control)this).get_Margin();
			recContent.X = x + ((Padding)(ref margin)).get_Left();
			ref Rectangle recContent2 = ref _recContent;
			int y = recContent2.Y;
			margin = ((Control)this).get_Margin();
			recContent2.Y = y + ((Padding)(ref margin)).get_Top();
			ref Rectangle recContent3 = ref _recContent;
			int width = recContent3.Width;
			margin = ((Control)this).get_Margin();
			recContent3.Width = width - ((Padding)(ref margin)).get_Right();
			ref Rectangle recContent4 = ref _recContent;
			int height = recContent4.Height;
			margin = ((Control)this).get_Margin();
			recContent4.Height = height - ((Padding)(ref margin)).get_Bottom();
			if ((int)BorderStyle == 2)
			{
				_recContent.X += 2;
				_recContent.Y += 2;
				_recContent.Width--;
				_recContent.Height--;
			}
			else if ((int)BorderStyle == 1)
			{
				_recContent.X++;
				_recContent.Y++;
				_recContent.Width--;
				_recContent.Height--;
			}
			if (!VScrollBarHidden)
			{
				_recContent.Width -= _vScrollBarWidth;
				VScrollBar vScrollBar = _vScrollBar;
				int num = _recContent.X + _recContent.Width;
				margin = ((Control)this).get_Margin();
				((Control)vScrollBar).set_Left(num - ((Padding)(ref margin)).get_Left());
				VScrollBar vScrollBar2 = _vScrollBar;
				int y2 = _recContent.Y;
				margin = ((Control)this).get_Margin();
				((Control)vScrollBar2).set_Top(y2 - ((Padding)(ref margin)).get_Top());
				((Control)_vScrollBar).set_Width(_vScrollBarWidth);
				((Control)_vScrollBar).set_Height(_recContent.Height);
			}
			_recLineCount = new Rectangle(_recContent.X, _recContent.Y, (int)(_charSize.Width * 4f), (int)_charSize.Height - 2);
			_editView.Update(_recLineCount.X + _recLineCount.Width + _entityMargin / 2, _recContent);
			_maxBytesH = _bytesPerLine;
			_maxBytesV = (int)Math.Ceiling((float)_recContent.Height / (float)_recLineCount.Height);
			_maxBytes = _maxBytesH * _maxBytesV;
			_maxVisibleBytesV = (int)Math.Floor((float)_recContent.Height / (float)_recLineCount.Height);
			UpdateScrollBarSize();
		}
	}

	private void UpdateVisibleByteIndex()
	{
		if (_hexTable.Length == 0)
		{
			_firstByte = 0;
			_lastByte = 0;
		}
		else
		{
			_firstByte = _vScrollPos * _maxBytesH;
			_lastByte = Math.Min(HexTableLength, _firstByte + _maxBytes);
		}
	}

	private void UpdateScrollValues()
	{
		if (!_isVScrollHidden)
		{
			((ScrollBar)_vScrollBar).set_Minimum(_vScrollMin);
			((ScrollBar)_vScrollBar).set_Maximum(_vScrollMax);
			((ScrollBar)_vScrollBar).set_Value(_vScrollPos);
			((ScrollBar)_vScrollBar).set_SmallChange(_vScrollSmall);
			((ScrollBar)_vScrollBar).set_LargeChange(_vScrollLarge);
			((Control)_vScrollBar).set_Visible(true);
		}
		else
		{
			((Control)_vScrollBar).set_Visible(false);
		}
	}

	private void UpdateScrollBarSize()
	{
		if (VScrollBarVisisble && _maxVisibleBytesV > 0 && _maxBytesH > 0)
		{
			int maxVisibleBytesV = _maxVisibleBytesV;
			int num = 1;
			int vScrollMin = 0;
			int num2 = HexTableLength / _maxBytesH;
			int num3 = _firstByte / _maxBytesH;
			if (maxVisibleBytesV != _vScrollLarge || num != _vScrollSmall)
			{
				_vScrollLarge = maxVisibleBytesV;
				_vScrollSmall = num;
			}
			if (num2 >= maxVisibleBytesV)
			{
				if (num2 != _vScrollMax || num3 != _vScrollPos)
				{
					_vScrollMin = vScrollMin;
					_vScrollMax = num2;
					_vScrollPos = num3;
				}
				VScrollBarHidden = false;
				UpdateScrollValues();
			}
			else
			{
				VScrollBarHidden = true;
			}
		}
		else
		{
			VScrollBarHidden = true;
		}
	}

	public HexEditor()
		: this(new ByteCollection())
	{
	}

	public HexEditor(ByteCollection collection)
	{
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_0088: Unknown result type (might be due to invalid IL or missing references)
		//IL_0092: Expected O, but got Unknown
		//IL_00b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bc: Expected O, but got Unknown
		//IL_00c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d3: Expected O, but got Unknown
		_stringFormat = new StringFormat(StringFormat.get_GenericTypographic());
		_stringFormat.set_Alignment((StringAlignment)1);
		_stringFormat.set_LineAlignment((StringAlignment)1);
		_hexTable = collection;
		_vScrollBar = new VScrollBar();
		((ScrollBar)_vScrollBar).add_Scroll(new ScrollEventHandler(OnVScrollBarScroll));
		((Control)this).SetStyle((ControlStyles)16, true);
		((Control)this).SetStyle((ControlStyles)139264, true);
		((Control)this).SetStyle((ControlStyles)512, true);
		_caret = new Caret(this);
		_caret.SelectionStartChanged += CaretSelectionStartChanged;
		_caret.SelectionLengthChanged += CaretSelectionLengthChanged;
		_editView = new EditView(this);
		_handler = _editView;
		((Control)this).set_Cursor(Cursors.get_IBeam());
	}

	private RectangleF GetLineCountBound(int index)
	{
		return new RectangleF(_recLineCount.X, _recLineCount.Y + _recLineCount.Height * index, _recLineCount.Width, _recLineCount.Height);
	}

	protected override void OnPaintBackground(PaintEventArgs pevent)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Invalid comparison between Unknown and I4
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Expected O, but got Unknown
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Invalid comparison between Unknown and I4
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Expected O, but got Unknown
		if ((int)BorderStyle == 2)
		{
			SolidBrush val = new SolidBrush(((Control)this).get_BackColor());
			Rectangle clientRectangle = ((Control)this).get_ClientRectangle();
			pevent.get_Graphics().FillRectangle((Brush)(object)val, clientRectangle);
			ControlPaint.DrawBorder3D(pevent.get_Graphics(), ((Control)this).get_ClientRectangle(), (Border3DStyle)10);
		}
		else if ((int)BorderStyle == 1)
		{
			SolidBrush val2 = new SolidBrush(((Control)this).get_BackColor());
			Rectangle clientRectangle2 = ((Control)this).get_ClientRectangle();
			pevent.get_Graphics().FillRectangle((Brush)(object)val2, clientRectangle2);
			ControlPaint.DrawBorder(pevent.get_Graphics(), ((Control)this).get_ClientRectangle(), BorderColor, (ButtonBorderStyle)3);
		}
		else
		{
			((Control)this).OnPaintBackground(pevent);
		}
	}

	protected override void OnPaint(PaintEventArgs e)
	{
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Expected O, but got Unknown
		((Control)this).OnPaint(e);
		Region val = new Region(((Control)this).get_ClientRectangle());
		val.Exclude(_recContent);
		e.get_Graphics().ExcludeClip(val);
		UpdateVisibleByteIndex();
		PaintLineCount(e.get_Graphics(), _firstByte, _lastByte);
		_editView.Paint(e.get_Graphics(), _firstByte, _lastByte);
	}

	private void PaintLineCount(Graphics g, int startIndex, int lastIndex)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Expected O, but got Unknown
		SolidBrush val = new SolidBrush(((Control)this).get_ForeColor());
		for (int i = 0; i * _maxBytesH + startIndex <= lastIndex; i++)
		{
			RectangleF lineCountBound = GetLineCountBound(i);
			string text = (startIndex + i * _maxBytesH).ToString(_lineCountCaps);
			int num = _nrCharsLineCount - text.Length;
			string text2 = ((num <= -1) ? new string('~', _nrCharsLineCount) : (new string('0', num) + text));
			g.DrawString(text2, ((Control)this).get_Font(), (Brush)(object)val, lineCountBound, _stringFormat);
		}
	}

	protected override void OnResize(EventArgs e)
	{
		((Control)this).OnResize(e);
		UpdateRectanglePositioning();
		((Control)this).Invalidate();
	}
}
