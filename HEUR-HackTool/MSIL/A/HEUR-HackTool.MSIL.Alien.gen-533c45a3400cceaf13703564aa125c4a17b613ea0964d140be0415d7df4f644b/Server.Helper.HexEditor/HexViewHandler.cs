using System;
using System.Drawing;
using System.Windows.Forms;

namespace Server.Helper.HexEditor;

public class HexViewHandler
{
	private bool _isEditing;

	private string _hexType = "X2";

	private Rectangle _recHexValue;

	private StringFormat _stringFormat;

	private HexEditor _editor;

	public int MaxWidth => _recHexValue.X + _recHexValue.Width * _editor.BytesPerLine;

	public HexViewHandler(HexEditor editor)
	{
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Expected O, but got Unknown
		_editor = editor;
		_stringFormat = new StringFormat(StringFormat.get_GenericTypographic());
		_stringFormat.set_Alignment((StringAlignment)1);
		_stringFormat.set_LineAlignment((StringAlignment)1);
	}

	public void OnKeyPress(KeyPressEventArgs e)
	{
		if (IsHex(e.get_KeyChar()))
		{
			HandleUserInput(e.get_KeyChar());
		}
	}

	public void OnKeyDown(KeyEventArgs e)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Invalid comparison between Unknown and I4
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Invalid comparison between Unknown and I4
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Invalid comparison between Unknown and I4
		//IL_013b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0142: Invalid comparison between Unknown and I4
		//IL_021a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0221: Invalid comparison between Unknown and I4
		//IL_0252: Unknown result type (might be due to invalid IL or missing references)
		//IL_0259: Invalid comparison between Unknown and I4
		//IL_02e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ed: Invalid comparison between Unknown and I4
		//IL_033f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0345: Invalid comparison between Unknown and I4
		if ((int)e.get_KeyCode() != 46 && (int)e.get_KeyCode() != 8)
		{
			if ((int)e.get_KeyCode() == 38 && _editor.CaretIndex - _editor.BytesPerLine >= 0)
			{
				int num = _editor.CaretIndex - _editor.BytesPerLine;
				if (num % _editor.BytesPerLine == 0 && _editor.CaretPosX >= _recHexValue.X + _recHexValue.Width * _editor.BytesPerLine)
				{
					Point location = new Point(_editor.CaretPosX, _editor.CaretPosY - _recHexValue.Height);
					if (num == 0)
					{
						location = new Point(_editor.CaretPosX, _editor.CaretPosY);
						num = _editor.BytesPerLine;
					}
					if (e.get_Shift())
					{
						_editor.SetCaretEnd(num, location);
					}
					else
					{
						_editor.SetCaretStart(num, location);
					}
					_isEditing = false;
				}
				else
				{
					HandleArrowKeys(num, e.get_Shift());
				}
			}
			else if ((int)e.get_KeyCode() == 40 && (_editor.CaretIndex - 1) / _editor.BytesPerLine < _editor.HexTableLength / _editor.BytesPerLine)
			{
				int num2 = _editor.CaretIndex + _editor.BytesPerLine;
				if (num2 > _editor.HexTableLength)
				{
					num2 = _editor.HexTableLength;
					HandleArrowKeys(num2, e.get_Shift());
					return;
				}
				Point location2 = new Point(_editor.CaretPosX, _editor.CaretPosY + _recHexValue.Height);
				if (e.get_Shift())
				{
					_editor.SetCaretEnd(num2, location2);
				}
				else
				{
					_editor.SetCaretStart(num2, location2);
				}
				_isEditing = false;
			}
			else if ((int)e.get_KeyCode() == 37 && _editor.CaretIndex - 1 >= 0)
			{
				int index = _editor.CaretIndex - 1;
				HandleArrowKeys(index, e.get_Shift());
			}
			else if ((int)e.get_KeyCode() == 39 && _editor.CaretIndex + 1 <= _editor.HexTableLength)
			{
				int index2 = _editor.CaretIndex + 1;
				HandleArrowKeys(index2, e.get_Shift());
			}
			return;
		}
		if (_editor.SelectionLength > 0)
		{
			HandleUserRemove();
			int caretIndex = _editor.CaretIndex;
			Point caretLocation = GetCaretLocation(caretIndex);
			_editor.SetCaretStart(caretIndex, caretLocation);
		}
		else if (_editor.CaretIndex < _editor.LastVisibleByte && (int)e.get_KeyCode() == 46)
		{
			_editor.RemoveByteAt(_editor.CaretIndex);
			Point caretLocation2 = GetCaretLocation(_editor.CaretIndex);
			_editor.SetCaretStart(_editor.CaretIndex, caretLocation2);
		}
		else if (_editor.CaretIndex > 0 && (int)e.get_KeyCode() == 8)
		{
			int index3 = _editor.CaretIndex - 1;
			if (_isEditing)
			{
				index3 = _editor.CaretIndex;
			}
			_editor.RemoveByteAt(index3);
			Point caretLocation3 = GetCaretLocation(index3);
			_editor.SetCaretStart(index3, caretLocation3);
		}
		_isEditing = false;
	}

	public void HandleArrowKeys(int index, bool isShiftDown)
	{
		Point caretLocation = GetCaretLocation(index);
		if (isShiftDown)
		{
			_editor.SetCaretEnd(index, caretLocation);
		}
		else
		{
			_editor.SetCaretStart(index, caretLocation);
		}
		_isEditing = false;
	}

	public void OnMouseDown(int x, int y)
	{
		int num = (x - _recHexValue.X) / _recHexValue.Width;
		int num2 = (y - _recHexValue.Y) / _recHexValue.Height;
		num = ((num > _editor.BytesPerLine) ? _editor.BytesPerLine : num);
		num = ((num >= 0) ? num : 0);
		num2 = ((num2 > _editor.MaxBytesV) ? _editor.MaxBytesV : num2);
		num2 = ((num2 >= 0) ? num2 : 0);
		if ((_editor.LastVisibleByte - _editor.FirstVisibleByte) / _editor.BytesPerLine <= num2)
		{
			if ((_editor.LastVisibleByte - _editor.FirstVisibleByte) % _editor.BytesPerLine <= num)
			{
				num = (_editor.LastVisibleByte - _editor.FirstVisibleByte) % _editor.BytesPerLine;
			}
			num2 = (_editor.LastVisibleByte - _editor.FirstVisibleByte) / _editor.BytesPerLine;
		}
		int index = Math.Min(_editor.LastVisibleByte, _editor.FirstVisibleByte + num + num2 * _editor.BytesPerLine);
		int x2 = num * _recHexValue.Width + _recHexValue.X;
		int y2 = num2 * _recHexValue.Height + _recHexValue.Y;
		_editor.SetCaretStart(index, new Point(x2, y2));
		_isEditing = false;
	}

	public void OnMouseDragged(int x, int y)
	{
		int num = (x - _recHexValue.X) / _recHexValue.Width;
		int num2 = (y - _recHexValue.Y) / _recHexValue.Height;
		num = ((num > _editor.BytesPerLine) ? _editor.BytesPerLine : num);
		num = ((num >= 0) ? num : 0);
		num2 = ((num2 > _editor.MaxBytesV) ? _editor.MaxBytesV : num2);
		num2 = ((_editor.FirstVisibleByte <= 0) ? ((num2 >= 0) ? num2 : 0) : ((num2 < 0) ? (-1) : num2));
		if ((_editor.LastVisibleByte - _editor.FirstVisibleByte) / _editor.BytesPerLine <= num2)
		{
			if ((_editor.LastVisibleByte - _editor.FirstVisibleByte) % _editor.BytesPerLine <= num)
			{
				num = (_editor.LastVisibleByte - _editor.FirstVisibleByte) % _editor.BytesPerLine;
			}
			num2 = (_editor.LastVisibleByte - _editor.FirstVisibleByte) / _editor.BytesPerLine;
		}
		int index = Math.Min(_editor.LastVisibleByte, _editor.FirstVisibleByte + num + num2 * _editor.BytesPerLine);
		int x2 = num * _recHexValue.Width + _recHexValue.X;
		int y2 = num2 * _recHexValue.Height + _recHexValue.Y;
		_editor.SetCaretEnd(index, new Point(x2, y2));
	}

	public void OnMouseDoubleClick()
	{
		if (_editor.CaretIndex < _editor.LastVisibleByte)
		{
			int index = _editor.CaretIndex + 1;
			Point caretLocation = GetCaretLocation(index);
			_editor.SetCaretEnd(index, caretLocation);
		}
	}

	public void Update(int startPositionX, Rectangle area)
	{
		_recHexValue = new Rectangle(startPositionX, area.Y, (int)(_editor.CharSize.Width * 3f), (int)_editor.CharSize.Height - 2);
		_recHexValue.X += _editor.EntityMargin;
	}

	public void Paint(Graphics g, int index, int startIndex)
	{
		Point byteColumnAndRow = GetByteColumnAndRow(index);
		if (_editor.IsSelected(index + startIndex))
		{
			PaintByteAsSelected(g, byteColumnAndRow, index + startIndex);
		}
		else
		{
			PaintByte(g, byteColumnAndRow, index + startIndex);
		}
	}

	private void PaintByteAsSelected(Graphics g, Point point, int index)
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Expected O, but got Unknown
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Expected O, but got Unknown
		SolidBrush val = new SolidBrush(_editor.SelectionBackColor);
		SolidBrush val2 = new SolidBrush(_editor.SelectionForeColor);
		RectangleF bound = GetBound(point);
		string text = _editor.GetByte(index).ToString(_hexType);
		g.FillRectangle((Brush)(object)val, bound);
		g.DrawString(text, ((Control)_editor).get_Font(), (Brush)(object)val2, bound, _stringFormat);
	}

	private void PaintByte(Graphics g, Point point, int index)
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Expected O, but got Unknown
		SolidBrush val = new SolidBrush(((Control)_editor).get_ForeColor());
		RectangleF bound = GetBound(point);
		string text = _editor.GetByte(index).ToString(_hexType);
		g.DrawString(text, ((Control)_editor).get_Font(), (Brush)(object)val, bound, _stringFormat);
	}

	public void SetLowerCase()
	{
		_hexType = "x2";
	}

	public void SetUpperCase()
	{
		_hexType = "X2";
	}

	public void Focus()
	{
		int caretIndex = _editor.CaretIndex;
		Point caretLocation = GetCaretLocation(caretIndex);
		_editor.SetCaretStart(caretIndex, caretLocation);
	}

	private Point GetCaretLocation(int index)
	{
		int x = _recHexValue.X + _recHexValue.Width * (index % _editor.BytesPerLine);
		int y = _recHexValue.Y + _recHexValue.Height * ((index - (_editor.FirstVisibleByte + index % _editor.BytesPerLine)) / _editor.BytesPerLine);
		return new Point(x, y);
	}

	private void HandleUserRemove()
	{
		int selectionStart = _editor.SelectionStart;
		Point caretLocation = GetCaretLocation(selectionStart);
		_editor.RemoveSelectedBytes();
		_editor.SetCaretStart(selectionStart, caretLocation);
	}

	private void HandleUserInput(char key)
	{
		if (!_editor.CaretFocused)
		{
			return;
		}
		HandleUserRemove();
		if (_isEditing)
		{
			_isEditing = false;
			byte @byte = _editor.GetByte(_editor.CaretIndex);
			@byte = (byte)(@byte + Convert.ToByte(key.ToString(), 16));
			_editor.SetByte(_editor.CaretIndex, @byte);
			int index = _editor.CaretIndex + 1;
			Point caretLocation = GetCaretLocation(index);
			_editor.SetCaretStart(index, caretLocation);
			return;
		}
		_isEditing = true;
		byte item = Convert.ToByte(key + "0", 16);
		if (_editor.HexTable.Length == 0)
		{
			_editor.AppendByte(item);
		}
		else
		{
			_editor.InsertByte(_editor.CaretIndex, item);
		}
		int x = _recHexValue.X + _recHexValue.Width * (_editor.CaretIndex % _editor.BytesPerLine) + _recHexValue.Width / 2;
		int y = _recHexValue.Y + _recHexValue.Height * ((_editor.CaretIndex - (_editor.FirstVisibleByte + _editor.CaretIndex % _editor.BytesPerLine)) / _editor.BytesPerLine);
		_editor.SetCaretStart(_editor.CaretIndex, new Point(x, y));
	}

	private Point GetByteColumnAndRow(int index)
	{
		int x = index % _editor.BytesPerLine;
		int y = index / _editor.BytesPerLine;
		return new Point(x, y);
	}

	private RectangleF GetBound(Point point)
	{
		return new RectangleF(_recHexValue.X + point.X * _recHexValue.Width, _recHexValue.Y + point.Y * _recHexValue.Height, _recHexValue.Width, _recHexValue.Height);
	}

	private bool IsHex(char c)
	{
		if ((c >= 'a' && c <= 'f') || (c >= 'A' && c <= 'F'))
		{
			return true;
		}
		return char.IsDigit(c);
	}
}
