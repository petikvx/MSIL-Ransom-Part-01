using System;
using System.ComponentModel;
using System.Globalization;
using System.Windows.Forms;

namespace Server.Helper;

public class WordTextBox : TextBox
{
	public enum WordType
	{
		DWORD,
		QWORD
	}

	private bool isHexNumber;

	private WordType type;

	private IContainer components;

	public override int MaxLength
	{
		get
		{
			return ((TextBoxBase)this).get_MaxLength();
		}
		set
		{
		}
	}

	public bool IsHexNumber
	{
		get
		{
			return isHexNumber;
		}
		set
		{
			if (isHexNumber == value)
			{
				return;
			}
			if (value)
			{
				if (Type == WordType.DWORD)
				{
					((Control)this).set_Text(UIntValue.ToString("x"));
				}
				else
				{
					((Control)this).set_Text(ULongValue.ToString("x"));
				}
			}
			else if (Type == WordType.DWORD)
			{
				((Control)this).set_Text(UIntValue.ToString());
			}
			else
			{
				((Control)this).set_Text(ULongValue.ToString());
			}
			isHexNumber = value;
			UpdateMaxLength();
		}
	}

	public WordType Type
	{
		get
		{
			return type;
		}
		set
		{
			if (type != value)
			{
				type = value;
				UpdateMaxLength();
			}
		}
	}

	public uint UIntValue
	{
		get
		{
			try
			{
				if (string.IsNullOrEmpty(((Control)this).get_Text()))
				{
					return 0u;
				}
				if (IsHexNumber)
				{
					return uint.Parse(((Control)this).get_Text(), NumberStyles.HexNumber);
				}
				return uint.Parse(((Control)this).get_Text());
			}
			catch (Exception)
			{
				return uint.MaxValue;
			}
		}
	}

	public ulong ULongValue
	{
		get
		{
			try
			{
				if (string.IsNullOrEmpty(((Control)this).get_Text()))
				{
					return 0uL;
				}
				if (IsHexNumber)
				{
					return ulong.Parse(((Control)this).get_Text(), NumberStyles.HexNumber);
				}
				return ulong.Parse(((Control)this).get_Text());
			}
			catch (Exception)
			{
				return ulong.MaxValue;
			}
		}
	}

	public bool IsConversionValid()
	{
		if (string.IsNullOrEmpty(((Control)this).get_Text()))
		{
			return true;
		}
		if (!IsHexNumber)
		{
			return ConvertToHex();
		}
		return true;
	}

	public WordTextBox()
	{
		InitializeComponent();
		((TextBoxBase)this).set_MaxLength(8);
	}

	protected override void OnKeyPress(KeyPressEventArgs e)
	{
		((Control)this).OnKeyPress(e);
		e.set_Handled(!IsValidChar(e.get_KeyChar()));
	}

	private bool IsValidChar(char ch)
	{
		if (!char.IsControl(ch) && !char.IsDigit(ch))
		{
			if (IsHexNumber && char.IsLetter(ch))
			{
				return char.ToLower(ch) <= 'f';
			}
			return false;
		}
		return true;
	}

	private void UpdateMaxLength()
	{
		if (Type == WordType.DWORD)
		{
			if (IsHexNumber)
			{
				((TextBoxBase)this).set_MaxLength(8);
			}
			else
			{
				((TextBoxBase)this).set_MaxLength(10);
			}
		}
		else if (IsHexNumber)
		{
			((TextBoxBase)this).set_MaxLength(16);
		}
		else
		{
			((TextBoxBase)this).set_MaxLength(20);
		}
	}

	private bool ConvertToHex()
	{
		try
		{
			if (Type == WordType.DWORD)
			{
				uint.Parse(((Control)this).get_Text());
			}
			else
			{
				ulong.Parse(((Control)this).get_Text());
			}
			return true;
		}
		catch (Exception)
		{
			return false;
		}
	}

	protected override void Dispose(bool disposing)
	{
		if (disposing && components != null)
		{
			components.Dispose();
		}
		((TextBox)this).Dispose(disposing);
	}

	private void InitializeComponent()
	{
		components = new Container();
	}
}
