using System;
using System.ComponentModel;
using System.Drawing;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace HexConverter;

public class Form1 : Form
{
	private IContainer components;

	private TextBox tBoxBytes;

	private TextBox tBoxHex;

	private TextBox tBoxDecimal;

	private TextBox tBoxBin;

	private Label label1;

	private Label label2;

	private Label label3;

	private Label label4;

	private ComboBox cbBoxType;

	private Button butExit;

	private Label label5;

	private Button butAbout;

	private bool IsUserInput;

	protected override void Dispose(bool disposing)
	{
		if (disposing && components != null)
		{
			components.Dispose();
		}
		((Form)this).Dispose(disposing);
	}

	private void InitializeComponent()
	{
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Expected O, but got Unknown
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Expected O, but got Unknown
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Expected O, but got Unknown
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Expected O, but got Unknown
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Expected O, but got Unknown
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Expected O, but got Unknown
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Expected O, but got Unknown
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Expected O, but got Unknown
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_0073: Expected O, but got Unknown
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Expected O, but got Unknown
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0089: Expected O, but got Unknown
		//IL_008a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0094: Expected O, but got Unknown
		//IL_01dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e7: Expected O, but got Unknown
		//IL_0703: Unknown result type (might be due to invalid IL or missing references)
		//IL_070d: Expected O, but got Unknown
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(Form1));
		tBoxBytes = new TextBox();
		tBoxHex = new TextBox();
		tBoxDecimal = new TextBox();
		tBoxBin = new TextBox();
		label1 = new Label();
		label2 = new Label();
		label3 = new Label();
		label4 = new Label();
		cbBoxType = new ComboBox();
		butExit = new Button();
		label5 = new Label();
		butAbout = new Button();
		((Control)this).SuspendLayout();
		((Control)tBoxBytes).set_Location(new Point(155, 60));
		((Control)tBoxBytes).set_Name("tBoxBytes");
		((TextBoxBase)tBoxBytes).set_ReadOnly(true);
		((Control)tBoxBytes).set_Size(new Size(150, 20));
		((Control)tBoxBytes).set_TabIndex(4);
		((Control)tBoxHex).set_Location(new Point(10, 60));
		((TextBoxBase)tBoxHex).set_MaxLength(16);
		((Control)tBoxHex).set_Name("tBoxHex");
		((Control)tBoxHex).set_Size(new Size(135, 20));
		((Control)tBoxHex).set_TabIndex(3);
		((Control)tBoxHex).add_TextChanged((EventHandler)tBoxHex_TextChanged);
		((Control)tBoxDecimal).set_Location(new Point(10, 20));
		((TextBoxBase)tBoxDecimal).set_MaxLength(20);
		((Control)tBoxDecimal).set_Name("tBoxDecimal");
		((Control)tBoxDecimal).set_Size(new Size(135, 20));
		((Control)tBoxDecimal).set_TabIndex(0);
		((Control)tBoxDecimal).add_TextChanged((EventHandler)tBoxDecimal_TextChanged);
		((Control)tBoxBin).set_Font(new Font("Microsoft Sans Serif", 7f, (FontStyle)0, (GraphicsUnit)3, (byte)136));
		((Control)tBoxBin).set_Location(new Point(10, 100));
		((Control)tBoxBin).set_Name("tBoxBin");
		((TextBoxBase)tBoxBin).set_ReadOnly(true);
		((Control)tBoxBin).set_Size(new Size(330, 18));
		((Control)tBoxBin).set_TabIndex(6);
		((Control)label1).set_AutoSize(true);
		((Control)label1).set_Location(new Point(155, 45));
		((Control)label1).set_Name("label1");
		((Control)label1).set_Size(new Size(72, 13));
		((Control)label1).set_TabIndex(4);
		((Control)label1).set_Text("位元組 Bytes");
		((Control)label2).set_AutoSize(true);
		((Control)label2).set_Location(new Point(10, 45));
		((Control)label2).set_Name("label2");
		((Control)label2).set_Size(new Size(65, 13));
		((Control)label2).set_TabIndex(5);
		((Control)label2).set_Text("16進位 Hex");
		((Control)label3).set_AutoSize(true);
		((Control)label3).set_Location(new Point(10, 5));
		((Control)label3).set_Name("label3");
		((Control)label3).set_Size(new Size(84, 13));
		((Control)label3).set_TabIndex(6);
		((Control)label3).set_Text("10進位 Decimal");
		((Control)label4).set_AutoSize(true);
		((Control)label4).set_Location(new Point(10, 85));
		((Control)label4).set_Name("label4");
		((Control)label4).set_Size(new Size(69, 13));
		((Control)label4).set_TabIndex(7);
		((Control)label4).set_Text("2進位 Binary");
		cbBoxType.set_DropDownStyle((ComboBoxStyle)2);
		((ListControl)cbBoxType).set_FormattingEnabled(true);
		cbBoxType.get_Items().AddRange(new object[10] { "Byte", "Byte (signed)", "2 Bytes", "2 Bytes (signed)", "4 Bytes", "4 Bytes (signed)", "8 Bytes", "8 Bytes (signed)", "Float", "Double" });
		((Control)cbBoxType).set_Location(new Point(155, 20));
		((Control)cbBoxType).set_Name("cbBoxType");
		((Control)cbBoxType).set_Size(new Size(120, 21));
		((Control)cbBoxType).set_TabIndex(1);
		cbBoxType.add_SelectedIndexChanged((EventHandler)comboBox1_SelectedIndexChanged);
		((Control)butExit).set_Location(new Point(280, 20));
		((Control)butExit).set_Name("butExit");
		((Control)butExit).set_Size(new Size(60, 20));
		((Control)butExit).set_TabIndex(5);
		((Control)butExit).set_Text("Exit");
		((ButtonBase)butExit).set_UseVisualStyleBackColor(true);
		((Control)butExit).add_Click((EventHandler)button1_Click);
		((Control)label5).set_AutoSize(true);
		((Control)label5).set_Location(new Point(155, 5));
		((Control)label5).set_Name("label5");
		((Control)label5).set_Size(new Size(58, 13));
		((Control)label5).set_TabIndex(10);
		((Control)label5).set_Text("類型 Type");
		((Control)butAbout).set_Location(new Point(310, 60));
		((Control)butAbout).set_Name("butAbout");
		((Control)butAbout).set_Size(new Size(30, 20));
		((Control)butAbout).set_TabIndex(2);
		((Control)butAbout).set_Text("?");
		((ButtonBase)butAbout).set_UseVisualStyleBackColor(true);
		((Control)butAbout).add_Click((EventHandler)button2_Click);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(349, 128));
		((Control)this).get_Controls().Add((Control)(object)butAbout);
		((Control)this).get_Controls().Add((Control)(object)label5);
		((Control)this).get_Controls().Add((Control)(object)butExit);
		((Control)this).get_Controls().Add((Control)(object)cbBoxType);
		((Control)this).get_Controls().Add((Control)(object)label4);
		((Control)this).get_Controls().Add((Control)(object)label3);
		((Control)this).get_Controls().Add((Control)(object)label2);
		((Control)this).get_Controls().Add((Control)(object)label1);
		((Control)this).get_Controls().Add((Control)(object)tBoxBin);
		((Control)this).get_Controls().Add((Control)(object)tBoxDecimal);
		((Control)this).get_Controls().Add((Control)(object)tBoxHex);
		((Control)this).get_Controls().Add((Control)(object)tBoxBytes);
		((Form)this).set_FormBorderStyle((FormBorderStyle)1);
		((Form)this).set_Icon((Icon)componentResourceManager.GetObject("$this.Icon"));
		((Form)this).set_MaximizeBox(false);
		((Control)this).set_Name("Form1");
		((Form)this).set_StartPosition((FormStartPosition)1);
		((Control)this).set_Text("Hex Converter");
		((Form)this).add_Load((EventHandler)Form1_Load);
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	public Form1()
	{
		InitializeComponent();
	}

	private void button1_Click(object sender, EventArgs e)
	{
		Application.Exit();
	}

	private void Form1_Load(object sender, EventArgs e)
	{
		((ListControl)cbBoxType).set_SelectedIndex(4);
		IsUserInput = true;
	}

	private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
	{
		((Control)tBoxBytes).set_Text("");
		((Control)tBoxHex).set_Text("");
		((Control)tBoxDecimal).set_Text("");
		((Control)tBoxBin).set_Text("");
	}

	private void tBoxDecimal_TextChanged(object sender, EventArgs e)
	{
		if (!IsUserInput)
		{
			return;
		}
		IsUserInput = false;
		int num = ((TextBoxBase)tBoxDecimal).get_SelectionStart();
		string text = ((Control)tBoxDecimal).get_Text();
		byte[] b = null;
		int num2 = 1;
		if (text.Length != 0 && text[0] == '-')
		{
			num2 = -1;
		}
		if (((ListControl)cbBoxType).get_SelectedIndex() == 0)
		{
			text = Regex.Replace(text, "[^0-9]", "");
			if (text.Length == 0)
			{
				b = null;
			}
			else
			{
				if (text.Length > 3)
				{
					text = text.Substring(0, 3);
				}
				if (text.Length == 3 && text.CompareTo("255") > 0)
				{
					text = "255";
				}
				b = new byte[1] { (byte)Convert.ToUInt16(text) };
			}
		}
		else if (((ListControl)cbBoxType).get_SelectedIndex() == 1)
		{
			text = Regex.Replace(text, "[^0-9]", "");
			if (num2 < 0)
			{
				text = '-' + text;
			}
			if (text.Length != 0 && !text.Equals("-"))
			{
				if (num2 > 0)
				{
					if (text.Length > 3)
					{
						text = text.Substring(0, 3);
					}
					if (text.Length == 3 && text.CompareTo("127") > 0)
					{
						text = "127";
					}
					b = new byte[1] { (byte)Convert.ToInt16(text) };
				}
				else
				{
					if (text.Length > 4)
					{
						text = text.Substring(0, 4);
					}
					if (text.Length == 4 && text.CompareTo("-128") > 0)
					{
						text = "-128";
					}
					b = new byte[1] { (byte)Convert.ToInt16(text) };
				}
			}
			else
			{
				b = null;
			}
		}
		else if (((ListControl)cbBoxType).get_SelectedIndex() == 2)
		{
			text = Regex.Replace(text, "[^0-9]", "");
			if (text.Length == 0)
			{
				b = null;
			}
			else
			{
				if (text.Length > 5)
				{
					text = text.Substring(0, 5);
				}
				if (text.Length == 5 && text.CompareTo("65535") > 0)
				{
					text = "65535";
				}
				b = BitConverter.GetBytes(Convert.ToUInt16(text));
			}
		}
		else if (((ListControl)cbBoxType).get_SelectedIndex() == 3)
		{
			text = Regex.Replace(text, "[^0-9]", "");
			if (num2 < 0)
			{
				text = '-' + text;
			}
			if (text.Length != 0 && !text.Equals("-"))
			{
				if (num2 > 0)
				{
					if (text.Length > 5)
					{
						text = text.Substring(0, 5);
					}
					if (text.Length == 5 && text.CompareTo("32767") > 0)
					{
						text = "32767";
					}
					b = BitConverter.GetBytes(Convert.ToInt16(text));
				}
				else
				{
					if (text.Length > 6)
					{
						text = text.Substring(0, 6);
					}
					if (text.Length == 6 && text.CompareTo("-32768") > 0)
					{
						text = "-32768";
					}
					b = BitConverter.GetBytes(Convert.ToInt16(text));
				}
			}
			else
			{
				b = null;
			}
		}
		else if (((ListControl)cbBoxType).get_SelectedIndex() == 4)
		{
			text = Regex.Replace(text, "[^0-9]", "");
			if (text.Length == 0)
			{
				b = null;
			}
			else
			{
				if (text.Length > 10)
				{
					text = text.Substring(0, 10);
				}
				if (text.Length == 10 && text.CompareTo("4294967295") > 0)
				{
					text = "4294967295";
				}
				b = BitConverter.GetBytes(Convert.ToUInt32(text));
			}
		}
		else if (((ListControl)cbBoxType).get_SelectedIndex() == 5)
		{
			text = Regex.Replace(text, "[^0-9]", "");
			if (num2 < 0)
			{
				text = '-' + text;
			}
			if (text.Length != 0 && !text.Equals("-"))
			{
				if (num2 > 0)
				{
					if (text.Length > 10)
					{
						text = text.Substring(0, 10);
					}
					if (text.Length == 10 && text.CompareTo("2147483647") > 0)
					{
						text = "2147483647";
					}
					b = BitConverter.GetBytes(Convert.ToInt32(text));
				}
				else
				{
					if (text.Length > 11)
					{
						text = text.Substring(0, 11);
					}
					if (text.Length == 11 && text.CompareTo("-2147483648") > 0)
					{
						text = "-2147483648";
					}
					b = BitConverter.GetBytes(Convert.ToInt32(text));
				}
			}
			else
			{
				b = null;
			}
		}
		else if (((ListControl)cbBoxType).get_SelectedIndex() == 6)
		{
			text = Regex.Replace(text, "[^0-9]", "");
			if (text.Length == 0)
			{
				b = null;
			}
			else
			{
				if (text.Length > 19 && text.CompareTo("18446744073709551615") > 0)
				{
					text = "18446744073709551615";
				}
				ulong value = Convert.ToUInt64(text);
				b = BitConverter.GetBytes(value);
			}
		}
		else if (((ListControl)cbBoxType).get_SelectedIndex() == 7)
		{
			text = Regex.Replace(text, "[^0-9]", "");
			if (num2 < 0)
			{
				text = '-' + text;
			}
			if (text.Length != 0 && !text.Equals("-"))
			{
				if (num2 > 0)
				{
					if (text.Length > 19 && text.CompareTo("9223372036854775807") > 0)
					{
						text = "9223372036854775807";
					}
					long value2 = Convert.ToInt64(text);
					b = BitConverter.GetBytes(value2);
				}
				else
				{
					if (text.Length > 19 && text.CompareTo("-9223372036854775808") > 0)
					{
						text = "-9223372036854775808";
					}
					long value3 = Convert.ToInt64(text);
					b = BitConverter.GetBytes(value3);
				}
			}
			else
			{
				b = null;
			}
		}
		else
		{
			text = Regex.Replace(text, "[^.0-9]", "");
			int i;
			for (i = 0; i < text.Length && text[i] != '.'; i++)
			{
			}
			for (i++; i < text.Length; i++)
			{
				if (text[i] == '.')
				{
					text = text.Remove(i--, 1);
				}
			}
			if (num2 < 0)
			{
				text = '-' + text;
			}
			if (text.Length > 20)
			{
				text = text.Substring(0, 20);
			}
			if (text.Length != 0 && !text.Equals(".") && !text.Equals("-") && !text.Equals("-."))
			{
				if (((ListControl)cbBoxType).get_SelectedIndex() == 8)
				{
					float value4 = float.Parse(text);
					b = BitConverter.GetBytes(value4);
				}
				else if (((ListControl)cbBoxType).get_SelectedIndex() == 9)
				{
					double value5 = double.Parse(text);
					b = BitConverter.GetBytes(value5);
				}
			}
			else
			{
				b = null;
			}
		}
		((Control)tBoxHex).set_Text(ToHex(b));
		((Control)tBoxBin).set_Text(ToBin(b));
		((Control)tBoxBytes).set_Text(ToRevHex(b));
		((Control)tBoxDecimal).set_Text(text);
		if (num < 0)
		{
			num = 0;
		}
		((TextBoxBase)tBoxDecimal).set_SelectionStart(num);
		IsUserInput = true;
	}

	private void tBoxHex_TextChanged(object sender, EventArgs e)
	{
		if (!IsUserInput)
		{
			return;
		}
		IsUserInput = false;
		int num = ((TextBoxBase)tBoxHex).get_SelectionStart();
		byte[] array = null;
		string input = ((Control)tBoxHex).get_Text().ToUpper();
		input = Regex.Replace(input, "[^0-9A-F]", "");
		if (input.Length == 0)
		{
			array = null;
			((Control)tBoxDecimal).set_Text("");
		}
		else if (((ListControl)cbBoxType).get_SelectedIndex() == 0)
		{
			if (input.Length > 2)
			{
				input = input.Substring(0, 2);
			}
			array = HexToByteArray(input, 1);
			((Control)tBoxDecimal).set_Text(array[0].ToString());
		}
		else if (((ListControl)cbBoxType).get_SelectedIndex() == 1)
		{
			if (input.Length > 2)
			{
				input = input.Substring(0, 2);
			}
			array = HexToByteArray(input, 1);
			((Control)tBoxDecimal).set_Text(((sbyte)array[0]).ToString());
		}
		else if (((ListControl)cbBoxType).get_SelectedIndex() == 2)
		{
			if (input.Length > 4)
			{
				input = input.Substring(0, 4);
			}
			array = HexToByteArray(input, 2);
			((Control)tBoxDecimal).set_Text(BitConverter.ToUInt16(array, 0).ToString());
		}
		else if (((ListControl)cbBoxType).get_SelectedIndex() == 3)
		{
			if (input.Length > 4)
			{
				input = input.Substring(0, 4);
			}
			array = HexToByteArray(input, 2);
			((Control)tBoxDecimal).set_Text(BitConverter.ToInt16(array, 0).ToString());
		}
		else if (((ListControl)cbBoxType).get_SelectedIndex() == 4)
		{
			if (input.Length > 8)
			{
				input = input.Substring(0, 8);
			}
			array = HexToByteArray(input, 4);
			((Control)tBoxDecimal).set_Text(BitConverter.ToUInt32(array, 0).ToString());
		}
		else if (((ListControl)cbBoxType).get_SelectedIndex() == 5)
		{
			if (input.Length > 8)
			{
				input = input.Substring(0, 8);
			}
			array = HexToByteArray(input, 4);
			((Control)tBoxDecimal).set_Text(BitConverter.ToInt32(array, 0).ToString());
		}
		else if (((ListControl)cbBoxType).get_SelectedIndex() == 6)
		{
			if (input.Length > 16)
			{
				input = input.Substring(0, 16);
			}
			array = HexToByteArray(input, 8);
			((Control)tBoxDecimal).set_Text(BitConverter.ToUInt64(array, 0).ToString());
		}
		else if (((ListControl)cbBoxType).get_SelectedIndex() == 7)
		{
			if (input.Length > 16)
			{
				input = input.Substring(0, 16);
			}
			array = HexToByteArray(input, 8);
			((Control)tBoxDecimal).set_Text(BitConverter.ToInt64(array, 0).ToString());
		}
		else if (((ListControl)cbBoxType).get_SelectedIndex() == 8)
		{
			if (input.Length > 8)
			{
				input = input.Substring(0, 8);
			}
			array = HexToByteArray(input, 4);
			((Control)tBoxDecimal).set_Text(BitConverter.ToSingle(array, 0).ToString());
		}
		else if (((ListControl)cbBoxType).get_SelectedIndex() == 9)
		{
			if (input.Length > 16)
			{
				input = input.Substring(0, 16);
			}
			array = HexToByteArray(input, 8);
			((Control)tBoxDecimal).set_Text(BitConverter.ToDouble(array, 0).ToString());
		}
		((Control)tBoxBin).set_Text(ToBin(array));
		((Control)tBoxBytes).set_Text(ToRevHex(array));
		((Control)tBoxHex).set_Text(input);
		if (num < 0)
		{
			num = 0;
		}
		((TextBoxBase)tBoxHex).set_SelectionStart(num);
		IsUserInput = true;
	}

	private byte[] HexToByteArray(string s, int size)
	{
		byte[] array = new byte[size];
		int num = 0;
		for (int num2 = s.Length - 1; num2 >= 0; num2--)
		{
			byte b = (byte)s[num2];
			b = ((b >= 58) ? ((byte)(b - 55)) : ((byte)(b - 48)));
			if (num % 2 == 1)
			{
				b = (byte)(b * 16);
			}
			array[num / 2] += b;
			num++;
		}
		return array;
	}

	private string ToRevHex(byte[] b)
	{
		if (b == null)
		{
			return "";
		}
		string text = "0123456789ABCDEF";
		StringBuilder stringBuilder = new StringBuilder();
		for (int i = 0; i < b.Length; i++)
		{
			stringBuilder.Append(text[b[i] >> 4]);
			stringBuilder.Append(text[b[i] & 0xF]);
			stringBuilder.Append(' ');
		}
		return stringBuilder.ToString();
	}

	private string ToHex(byte[] b)
	{
		if (b == null)
		{
			return "";
		}
		string text = "0123456789ABCDEF";
		StringBuilder stringBuilder = new StringBuilder();
		for (int num = b.Length - 1; num >= 0; num--)
		{
			stringBuilder.Append(text[b[num] >> 4]);
			stringBuilder.Append(text[b[num] & 0xF]);
		}
		return stringBuilder.ToString();
	}

	private string ToBin(byte[] b)
	{
		if (b == null)
		{
			return "";
		}
		StringBuilder stringBuilder = new StringBuilder();
		for (int i = 0; i < b.Length; i++)
		{
			byte b2 = b[i];
			for (int j = 0; j < 8; j++)
			{
				stringBuilder.Insert(0, b2 & 1);
				b2 = (byte)(b2 >> 1);
			}
		}
		return stringBuilder.ToString();
	}

	private void button2_Click(object sender, EventArgs e)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		Form val = (Form)(object)new DialogBox();
		val.ShowDialog();
	}
}
