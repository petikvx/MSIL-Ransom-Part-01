using System;
using System.ComponentModel;
using System.Drawing;
using System.IO.Ports;
using System.Windows.Forms;

namespace Calculator;

public class frmCalculator : Form
{
	public enum MathOp : byte
	{
		Add,
		Sub,
		Mult,
		Div
	}

	private MathOp mathOp_0;

	private string string_0 = "";

	private string string_1 = "";

	private decimal decimal_0;

	private bool bool_0;

	private bool bool_1;

	private bool bool_2;

	private IContainer icontainer_0 = null;

	private Label LblDisplay;

	private Label LblHistory;

	private Button BtnCE;

	private Button BtnDiv;

	private Button BtnC;

	private Button BtnDel;

	private Button Btn7;

	private Button BtnMult;

	private Button Btn8;

	private Button Btn9;

	private Button Btn4;

	private Button BtnSub;

	private Button Btn5;

	private Button Btn6;

	private Button Btn1;

	private Button BtnAdd;

	private Button Btn2;

	private Button Btn3;

	private Button BtnNeg;

	private Button BtnEq;

	private Button Btn0;

	private Button BtnSep;

	private Button BtnMC;

	private Button BtnMR;

	private Button BtnMplus;

	private Button BtnMminus;

	private Button BtnMS;

	private SerialPort serialPort_0;

	private CheckBox checkBox1;

	private CheckBox checkBox2;

	public frmCalculator()
	{
		InitializeComponent();
		method_1();
	}

	private void Btn0_Click(object sender, EventArgs e)
	{
		if (bool_1)
		{
			method_1();
			method_2();
		}
		if (bool_0)
		{
			if (string_0 != "" && string_0 != "0")
			{
				string_0 += 0;
				method_0();
			}
		}
		else if (string_1 != "" && string_1 != "0")
		{
			string_1 += 0;
			method_0();
		}
	}

	private void Btn3_Click(object sender, EventArgs e)
	{
		Button val = (Button)((sender is Button) ? sender : null);
		int num = Convert.ToInt32(((Control)val).get_Text());
		if (bool_1)
		{
			method_1();
			method_2();
		}
		if (bool_0)
		{
			string_0 += num;
		}
		else
		{
			string_1 += num;
		}
		method_0();
	}

	private void BtnC_Click(object sender, EventArgs e)
	{
		method_1();
		method_2();
		((Control)LblDisplay).set_Text("0");
	}

	private void BtnCE_Click(object sender, EventArgs e)
	{
		if (bool_2)
		{
			string_1 = "";
			((Control)LblDisplay).set_Text("0");
		}
	}

	private void BtnDel_Click(object sender, EventArgs e)
	{
		if (bool_0)
		{
			int length = string_0.Length;
			string_0 = string_0.Substring(0, length - 1);
		}
		else
		{
			int length2 = string_1.Length;
			string_1 = string_1.Substring(0, length2 - 1);
		}
		method_0();
	}

	private void BtnEq_Click(object sender, EventArgs e)
	{
		if (bool_2)
		{
			method_4();
			bool_1 = true;
		}
	}

	private void BtnAdd_Click(object sender, EventArgs e)
	{
		mathOp_0 = MathOp.Add;
		method_5();
		bool_2 = true;
	}

	private void BtnSub_Click(object sender, EventArgs e)
	{
		mathOp_0 = MathOp.Sub;
		method_5();
		bool_2 = true;
	}

	private void BtnMult_Click(object sender, EventArgs e)
	{
		mathOp_0 = MathOp.Mult;
		method_5();
		bool_2 = true;
	}

	private void BtnDiv_Click(object sender, EventArgs e)
	{
		mathOp_0 = MathOp.Div;
		method_5();
		bool_2 = true;
	}

	private void method_0()
	{
		((Control)LblDisplay).set_Text(bool_0 ? string_0.ToString() : string_1.ToString());
	}

	private void method_1()
	{
		bool_0 = true;
		bool_1 = false;
		bool_2 = false;
	}

	private void method_2()
	{
		string_0 = (string_1 = "");
	}

	private decimal method_3(decimal decimal_1, decimal decimal_2)
	{
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		switch (mathOp_0)
		{
		default:
			return -1m;
		case MathOp.Add:
			return decimal_1 + decimal_2;
		case MathOp.Sub:
			return decimal_1 - decimal_2;
		case MathOp.Mult:
			return decimal_1 * decimal_2;
		case MathOp.Div:
			if (decimal_2 > 0m)
			{
				return decimal_1 / decimal_2;
			}
			MessageBox.Show("Error");
			return -1m;
		}
	}

	private void method_4()
	{
		decimal decimal_ = decimal.Parse(string_0);
		decimal decimal_2 = decimal.Parse(string_1);
		decimal_0 = method_3(decimal_, decimal_2);
		((Control)LblDisplay).set_Text(decimal_0.ToString());
		string_0 = decimal_0.ToString();
	}

	private void method_5()
	{
		if (bool_1)
		{
			bool_1 = false;
			string_0 = decimal_0.ToString();
			string_1 = "";
		}
		else if (bool_2)
		{
			method_4();
		}
		else
		{
			bool_0 = false;
		}
	}

	protected override void vmethod_0(bool bool_3)
	{
		if (bool_3 && icontainer_0 != null)
		{
			icontainer_0.Dispose();
		}
		((Form)this).Dispose(bool_3);
	}

	private void InitializeComponent()
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Expected O, but got Unknown
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Expected O, but got Unknown
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Expected O, but got Unknown
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Expected O, but got Unknown
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Expected O, but got Unknown
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Expected O, but got Unknown
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Expected O, but got Unknown
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Expected O, but got Unknown
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Expected O, but got Unknown
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0079: Expected O, but got Unknown
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0084: Expected O, but got Unknown
		//IL_0085: Unknown result type (might be due to invalid IL or missing references)
		//IL_008f: Expected O, but got Unknown
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		//IL_009a: Expected O, but got Unknown
		//IL_009b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a5: Expected O, but got Unknown
		//IL_00a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b0: Expected O, but got Unknown
		//IL_00b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bb: Expected O, but got Unknown
		//IL_00bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c6: Expected O, but got Unknown
		//IL_00c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d1: Expected O, but got Unknown
		//IL_00d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dc: Expected O, but got Unknown
		//IL_00dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e7: Expected O, but got Unknown
		//IL_00e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f2: Expected O, but got Unknown
		//IL_00f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fd: Expected O, but got Unknown
		//IL_00fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0108: Expected O, but got Unknown
		//IL_0109: Unknown result type (might be due to invalid IL or missing references)
		//IL_0113: Expected O, but got Unknown
		//IL_0114: Unknown result type (might be due to invalid IL or missing references)
		//IL_011e: Expected O, but got Unknown
		//IL_011f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0129: Expected O, but got Unknown
		//IL_012a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0134: Expected O, but got Unknown
		//IL_013b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0145: Expected O, but got Unknown
		//IL_0146: Unknown result type (might be due to invalid IL or missing references)
		//IL_0150: Expected O, but got Unknown
		//IL_0151: Unknown result type (might be due to invalid IL or missing references)
		//IL_015b: Expected O, but got Unknown
		//IL_0180: Unknown result type (might be due to invalid IL or missing references)
		//IL_018a: Expected O, but got Unknown
		//IL_0201: Unknown result type (might be due to invalid IL or missing references)
		//IL_020b: Expected O, but got Unknown
		//IL_0281: Unknown result type (might be due to invalid IL or missing references)
		//IL_028b: Expected O, but got Unknown
		//IL_02ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_033c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0346: Expected O, but got Unknown
		//IL_036a: Unknown result type (might be due to invalid IL or missing references)
		//IL_03fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_0404: Expected O, but got Unknown
		//IL_0428: Unknown result type (might be due to invalid IL or missing references)
		//IL_04b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_04c2: Expected O, but got Unknown
		//IL_04e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0576: Unknown result type (might be due to invalid IL or missing references)
		//IL_0580: Expected O, but got Unknown
		//IL_05a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0631: Unknown result type (might be due to invalid IL or missing references)
		//IL_063b: Expected O, but got Unknown
		//IL_065f: Unknown result type (might be due to invalid IL or missing references)
		//IL_06ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_06f9: Expected O, but got Unknown
		//IL_071d: Unknown result type (might be due to invalid IL or missing references)
		//IL_07ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_07b7: Expected O, but got Unknown
		//IL_07db: Unknown result type (might be due to invalid IL or missing references)
		//IL_086b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0875: Expected O, but got Unknown
		//IL_0896: Unknown result type (might be due to invalid IL or missing references)
		//IL_0926: Unknown result type (might be due to invalid IL or missing references)
		//IL_0930: Expected O, but got Unknown
		//IL_0954: Unknown result type (might be due to invalid IL or missing references)
		//IL_09e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_09ee: Expected O, but got Unknown
		//IL_0a12: Unknown result type (might be due to invalid IL or missing references)
		//IL_0aa2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0aac: Expected O, but got Unknown
		//IL_0ad0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b60: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b6a: Expected O, but got Unknown
		//IL_0b8b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c1b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c25: Expected O, but got Unknown
		//IL_0c49: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cd9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ce3: Expected O, but got Unknown
		//IL_0d07: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d97: Unknown result type (might be due to invalid IL or missing references)
		//IL_0da1: Expected O, but got Unknown
		//IL_0dc5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e55: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e5f: Expected O, but got Unknown
		//IL_0e80: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ef9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f03: Expected O, but got Unknown
		//IL_0f27: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fb7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fc1: Expected O, but got Unknown
		//IL_0fe5: Unknown result type (might be due to invalid IL or missing references)
		//IL_1075: Unknown result type (might be due to invalid IL or missing references)
		//IL_107f: Expected O, but got Unknown
		//IL_10a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_110c: Unknown result type (might be due to invalid IL or missing references)
		//IL_1116: Expected O, but got Unknown
		//IL_1137: Unknown result type (might be due to invalid IL or missing references)
		//IL_11a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_11aa: Expected O, but got Unknown
		//IL_11cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_1234: Unknown result type (might be due to invalid IL or missing references)
		//IL_123e: Expected O, but got Unknown
		//IL_1262: Unknown result type (might be due to invalid IL or missing references)
		//IL_12cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_12d5: Expected O, but got Unknown
		//IL_12f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_1362: Unknown result type (might be due to invalid IL or missing references)
		//IL_136c: Expected O, but got Unknown
		//IL_1390: Unknown result type (might be due to invalid IL or missing references)
		//IL_16f6: Unknown result type (might be due to invalid IL or missing references)
		icontainer_0 = new Container();
		LblDisplay = new Label();
		LblHistory = new Label();
		BtnCE = new Button();
		BtnDiv = new Button();
		BtnC = new Button();
		BtnDel = new Button();
		Btn7 = new Button();
		BtnMult = new Button();
		Btn8 = new Button();
		Btn9 = new Button();
		Btn4 = new Button();
		BtnSub = new Button();
		Btn5 = new Button();
		Btn6 = new Button();
		Btn1 = new Button();
		BtnAdd = new Button();
		Btn2 = new Button();
		Btn3 = new Button();
		BtnNeg = new Button();
		BtnEq = new Button();
		Btn0 = new Button();
		BtnSep = new Button();
		BtnMC = new Button();
		BtnMR = new Button();
		BtnMplus = new Button();
		BtnMminus = new Button();
		BtnMS = new Button();
		serialPort_0 = new SerialPort(icontainer_0);
		checkBox1 = new CheckBox();
		checkBox2 = new CheckBox();
		((Control)this).SuspendLayout();
		LblDisplay.set_BorderStyle((BorderStyle)1);
		((Control)LblDisplay).set_Font(new Font("Microsoft Sans Serif", 28.2f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)LblDisplay).set_Location(new Point(25, 39));
		((Control)LblDisplay).set_Name("LblDisplay");
		((Control)LblDisplay).set_Size(new Size(438, 78));
		((Control)LblDisplay).set_TabIndex(0);
		((Control)LblDisplay).set_Text("0");
		LblDisplay.set_TextAlign((ContentAlignment)64);
		((Control)LblHistory).set_Font(new Font("Microsoft Sans Serif", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)LblHistory).set_Location(new Point(45, 7));
		((Control)LblHistory).set_Name("LblHistory");
		((Control)LblHistory).set_Size(new Size(405, 30));
		((Control)LblHistory).set_TabIndex(0);
		LblHistory.set_TextAlign((ContentAlignment)64);
		((Control)BtnCE).set_BackColor(SystemColors.ControlLight);
		((Control)BtnCE).set_Font(new Font("Microsoft Sans Serif", 18f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)BtnCE).set_Location(new Point(21, 188));
		((Control)BtnCE).set_Margin(new Padding(3, 2, 3, 2));
		((Control)BtnCE).set_Name("BtnCE");
		((Control)BtnCE).set_Size(new Size(99, 80));
		((Control)BtnCE).set_TabIndex(1);
		((Control)BtnCE).set_Text("CE");
		((ButtonBase)BtnCE).set_UseVisualStyleBackColor(false);
		((Control)BtnCE).add_Click((EventHandler)BtnCE_Click);
		((Control)BtnDiv).set_BackColor(SystemColors.ControlLight);
		((Control)BtnDiv).set_Font(new Font("Microsoft Sans Serif", 18f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)BtnDiv).set_Location(new Point(364, 188));
		((Control)BtnDiv).set_Margin(new Padding(3, 2, 3, 2));
		((Control)BtnDiv).set_Name("BtnDiv");
		((Control)BtnDiv).set_Size(new Size(99, 80));
		((Control)BtnDiv).set_TabIndex(1);
		((Control)BtnDiv).set_Text("/");
		((ButtonBase)BtnDiv).set_UseVisualStyleBackColor(false);
		((Control)BtnDiv).add_Click((EventHandler)BtnDiv_Click);
		((Control)BtnC).set_BackColor(SystemColors.ControlLight);
		((Control)BtnC).set_Font(new Font("Microsoft Sans Serif", 18f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)BtnC).set_Location(new Point(136, 188));
		((Control)BtnC).set_Margin(new Padding(3, 2, 3, 2));
		((Control)BtnC).set_Name("BtnC");
		((Control)BtnC).set_Size(new Size(99, 80));
		((Control)BtnC).set_TabIndex(1);
		((Control)BtnC).set_Text("C");
		((ButtonBase)BtnC).set_UseVisualStyleBackColor(false);
		((Control)BtnC).add_Click((EventHandler)BtnC_Click);
		((Control)BtnDel).set_BackColor(SystemColors.ControlLight);
		((Control)BtnDel).set_Font(new Font("Microsoft Sans Serif", 18f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)BtnDel).set_Location(new Point(251, 188));
		((Control)BtnDel).set_Margin(new Padding(3, 2, 3, 2));
		((Control)BtnDel).set_Name("BtnDel");
		((Control)BtnDel).set_Size(new Size(99, 80));
		((Control)BtnDel).set_TabIndex(1);
		((Control)BtnDel).set_Text("Del");
		((ButtonBase)BtnDel).set_UseVisualStyleBackColor(false);
		((Control)BtnDel).add_Click((EventHandler)BtnDel_Click);
		((Control)Btn7).set_BackColor(SystemColors.ButtonFace);
		((Control)Btn7).set_Font(new Font("Microsoft Sans Serif", 19.8f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)Btn7).set_Location(new Point(21, 286));
		((Control)Btn7).set_Margin(new Padding(3, 2, 3, 2));
		((Control)Btn7).set_Name("Btn7");
		((Control)Btn7).set_Size(new Size(99, 80));
		((Control)Btn7).set_TabIndex(1);
		((Control)Btn7).set_Text("7");
		((ButtonBase)Btn7).set_UseVisualStyleBackColor(false);
		((Control)Btn7).add_Click((EventHandler)Btn3_Click);
		((Control)BtnMult).set_BackColor(SystemColors.ControlLight);
		((Control)BtnMult).set_Font(new Font("Microsoft Sans Serif", 18f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)BtnMult).set_Location(new Point(364, 286));
		((Control)BtnMult).set_Margin(new Padding(3, 2, 3, 2));
		((Control)BtnMult).set_Name("BtnMult");
		((Control)BtnMult).set_Size(new Size(99, 80));
		((Control)BtnMult).set_TabIndex(1);
		((Control)BtnMult).set_Text("x");
		((ButtonBase)BtnMult).set_UseVisualStyleBackColor(false);
		((Control)BtnMult).add_Click((EventHandler)BtnMult_Click);
		((Control)Btn8).set_BackColor(SystemColors.ButtonFace);
		((Control)Btn8).set_Font(new Font("Microsoft Sans Serif", 19.8f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)Btn8).set_Location(new Point(136, 286));
		((Control)Btn8).set_Margin(new Padding(3, 2, 3, 2));
		((Control)Btn8).set_Name("Btn8");
		((Control)Btn8).set_Size(new Size(99, 80));
		((Control)Btn8).set_TabIndex(1);
		((Control)Btn8).set_Text("8");
		((ButtonBase)Btn8).set_UseVisualStyleBackColor(false);
		((Control)Btn8).add_Click((EventHandler)Btn3_Click);
		((Control)Btn9).set_BackColor(SystemColors.ButtonFace);
		((Control)Btn9).set_Font(new Font("Microsoft Sans Serif", 19.8f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)Btn9).set_Location(new Point(251, 286));
		((Control)Btn9).set_Margin(new Padding(3, 2, 3, 2));
		((Control)Btn9).set_Name("Btn9");
		((Control)Btn9).set_Size(new Size(99, 80));
		((Control)Btn9).set_TabIndex(1);
		((Control)Btn9).set_Text("9");
		((ButtonBase)Btn9).set_UseVisualStyleBackColor(false);
		((Control)Btn9).add_Click((EventHandler)Btn3_Click);
		((Control)Btn4).set_BackColor(SystemColors.ButtonFace);
		((Control)Btn4).set_Font(new Font("Microsoft Sans Serif", 19.8f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)Btn4).set_Location(new Point(21, 382));
		((Control)Btn4).set_Margin(new Padding(3, 2, 3, 2));
		((Control)Btn4).set_Name("Btn4");
		((Control)Btn4).set_Size(new Size(99, 80));
		((Control)Btn4).set_TabIndex(1);
		((Control)Btn4).set_Text("4");
		((ButtonBase)Btn4).set_UseVisualStyleBackColor(false);
		((Control)Btn4).add_Click((EventHandler)Btn3_Click);
		((Control)BtnSub).set_BackColor(SystemColors.ControlLight);
		((Control)BtnSub).set_Font(new Font("Microsoft Sans Serif", 19.8f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)BtnSub).set_Location(new Point(364, 382));
		((Control)BtnSub).set_Margin(new Padding(3, 2, 3, 2));
		((Control)BtnSub).set_Name("BtnSub");
		((Control)BtnSub).set_Size(new Size(99, 80));
		((Control)BtnSub).set_TabIndex(1);
		((Control)BtnSub).set_Text("-");
		((ButtonBase)BtnSub).set_UseVisualStyleBackColor(false);
		((Control)BtnSub).add_Click((EventHandler)BtnSub_Click);
		((Control)Btn5).set_BackColor(SystemColors.ButtonFace);
		((Control)Btn5).set_Font(new Font("Microsoft Sans Serif", 19.8f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)Btn5).set_Location(new Point(136, 382));
		((Control)Btn5).set_Margin(new Padding(3, 2, 3, 2));
		((Control)Btn5).set_Name("Btn5");
		((Control)Btn5).set_Size(new Size(99, 80));
		((Control)Btn5).set_TabIndex(1);
		((Control)Btn5).set_Text("5");
		((ButtonBase)Btn5).set_UseVisualStyleBackColor(false);
		((Control)Btn5).add_Click((EventHandler)Btn3_Click);
		((Control)Btn6).set_BackColor(SystemColors.ButtonFace);
		((Control)Btn6).set_Font(new Font("Microsoft Sans Serif", 19.8f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)Btn6).set_Location(new Point(251, 382));
		((Control)Btn6).set_Margin(new Padding(3, 2, 3, 2));
		((Control)Btn6).set_Name("Btn6");
		((Control)Btn6).set_Size(new Size(99, 80));
		((Control)Btn6).set_TabIndex(1);
		((Control)Btn6).set_Text("6");
		((ButtonBase)Btn6).set_UseVisualStyleBackColor(false);
		((Control)Btn6).add_Click((EventHandler)Btn3_Click);
		((Control)Btn1).set_BackColor(SystemColors.ButtonFace);
		((Control)Btn1).set_Font(new Font("Microsoft Sans Serif", 19.8f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)Btn1).set_Location(new Point(21, 478));
		((Control)Btn1).set_Margin(new Padding(3, 2, 3, 2));
		((Control)Btn1).set_Name("Btn1");
		((Control)Btn1).set_Size(new Size(99, 80));
		((Control)Btn1).set_TabIndex(1);
		((Control)Btn1).set_Text("1");
		((ButtonBase)Btn1).set_UseVisualStyleBackColor(false);
		((Control)Btn1).add_Click((EventHandler)Btn3_Click);
		((Control)BtnAdd).set_BackColor(SystemColors.ControlLight);
		((Control)BtnAdd).set_Font(new Font("Microsoft Sans Serif", 19.8f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)BtnAdd).set_Location(new Point(364, 478));
		((Control)BtnAdd).set_Margin(new Padding(3, 2, 3, 2));
		((Control)BtnAdd).set_Name("BtnAdd");
		((Control)BtnAdd).set_Size(new Size(99, 80));
		((Control)BtnAdd).set_TabIndex(1);
		((Control)BtnAdd).set_Text("+");
		((ButtonBase)BtnAdd).set_UseVisualStyleBackColor(false);
		((Control)BtnAdd).add_Click((EventHandler)BtnAdd_Click);
		((Control)Btn2).set_BackColor(SystemColors.ButtonFace);
		((Control)Btn2).set_Font(new Font("Microsoft Sans Serif", 19.8f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)Btn2).set_Location(new Point(136, 478));
		((Control)Btn2).set_Margin(new Padding(3, 2, 3, 2));
		((Control)Btn2).set_Name("Btn2");
		((Control)Btn2).set_Size(new Size(99, 80));
		((Control)Btn2).set_TabIndex(1);
		((Control)Btn2).set_Text("2");
		((ButtonBase)Btn2).set_UseVisualStyleBackColor(false);
		((Control)Btn2).add_Click((EventHandler)Btn3_Click);
		((Control)Btn3).set_BackColor(SystemColors.ButtonFace);
		((Control)Btn3).set_Font(new Font("Microsoft Sans Serif", 19.8f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)Btn3).set_Location(new Point(251, 478));
		((Control)Btn3).set_Margin(new Padding(3, 2, 3, 2));
		((Control)Btn3).set_Name("Btn3");
		((Control)Btn3).set_Size(new Size(99, 80));
		((Control)Btn3).set_TabIndex(1);
		((Control)Btn3).set_Text("3");
		((ButtonBase)Btn3).set_UseVisualStyleBackColor(false);
		((Control)Btn3).add_Click((EventHandler)Btn3_Click);
		((Control)BtnNeg).set_BackColor(SystemColors.ControlLight);
		((Control)BtnNeg).set_Font(new Font("Microsoft Sans Serif", 19.8f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)BtnNeg).set_Location(new Point(21, 576));
		((Control)BtnNeg).set_Margin(new Padding(3, 2, 3, 2));
		((Control)BtnNeg).set_Name("BtnNeg");
		((Control)BtnNeg).set_Size(new Size(99, 80));
		((Control)BtnNeg).set_TabIndex(1);
		((Control)BtnNeg).set_Text("+/-");
		((ButtonBase)BtnNeg).set_UseVisualStyleBackColor(false);
		((Control)BtnEq).set_BackColor(SystemColors.ControlLight);
		((Control)BtnEq).set_Font(new Font("Microsoft Sans Serif", 19.8f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)BtnEq).set_Location(new Point(364, 576));
		((Control)BtnEq).set_Margin(new Padding(3, 2, 3, 2));
		((Control)BtnEq).set_Name("BtnEq");
		((Control)BtnEq).set_Size(new Size(99, 80));
		((Control)BtnEq).set_TabIndex(1);
		((Control)BtnEq).set_Text("=");
		((ButtonBase)BtnEq).set_UseVisualStyleBackColor(false);
		((Control)BtnEq).add_Click((EventHandler)BtnEq_Click);
		((Control)Btn0).set_BackColor(SystemColors.ButtonFace);
		((Control)Btn0).set_Font(new Font("Microsoft Sans Serif", 19.8f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)Btn0).set_Location(new Point(136, 576));
		((Control)Btn0).set_Margin(new Padding(3, 2, 3, 2));
		((Control)Btn0).set_Name("Btn0");
		((Control)Btn0).set_Size(new Size(99, 80));
		((Control)Btn0).set_TabIndex(1);
		((Control)Btn0).set_Text("0");
		((ButtonBase)Btn0).set_UseVisualStyleBackColor(false);
		((Control)Btn0).add_Click((EventHandler)Btn0_Click);
		((Control)BtnSep).set_BackColor(SystemColors.ControlLight);
		((Control)BtnSep).set_Font(new Font("Microsoft Sans Serif", 19.8f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)BtnSep).set_Location(new Point(251, 576));
		((Control)BtnSep).set_Margin(new Padding(3, 2, 3, 2));
		((Control)BtnSep).set_Name("BtnSep");
		((Control)BtnSep).set_Size(new Size(99, 80));
		((Control)BtnSep).set_TabIndex(1);
		((Control)BtnSep).set_Text(",");
		((ButtonBase)BtnSep).set_UseVisualStyleBackColor(false);
		((Control)BtnMC).set_Font(new Font("Microsoft Sans Serif", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)BtnMC).set_Location(new Point(25, 139));
		((Control)BtnMC).set_Margin(new Padding(3, 2, 3, 2));
		((Control)BtnMC).set_Name("BtnMC");
		((Control)BtnMC).set_Size(new Size(75, 32));
		((Control)BtnMC).set_TabIndex(2);
		((Control)BtnMC).set_Text("MC");
		((ButtonBase)BtnMC).set_UseVisualStyleBackColor(true);
		((Control)BtnMR).set_Font(new Font("Microsoft Sans Serif", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)BtnMR).set_Location(new Point(115, 139));
		((Control)BtnMR).set_Margin(new Padding(3, 2, 3, 2));
		((Control)BtnMR).set_Name("BtnMR");
		((Control)BtnMR).set_Size(new Size(75, 32));
		((Control)BtnMR).set_TabIndex(2);
		((Control)BtnMR).set_Text("MR");
		((ButtonBase)BtnMR).set_UseVisualStyleBackColor(true);
		((Control)BtnMplus).set_Font(new Font("Microsoft Sans Serif", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)BtnMplus).set_Location(new Point(205, 139));
		((Control)BtnMplus).set_Margin(new Padding(3, 2, 3, 2));
		((Control)BtnMplus).set_Name("BtnMplus");
		((Control)BtnMplus).set_Size(new Size(75, 32));
		((Control)BtnMplus).set_TabIndex(2);
		((Control)BtnMplus).set_Text("M+");
		((ButtonBase)BtnMplus).set_UseVisualStyleBackColor(true);
		((Control)BtnMminus).set_Font(new Font("Microsoft Sans Serif", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)BtnMminus).set_Location(new Point(295, 139));
		((Control)BtnMminus).set_Margin(new Padding(3, 2, 3, 2));
		((Control)BtnMminus).set_Name("BtnMminus");
		((Control)BtnMminus).set_Size(new Size(75, 32));
		((Control)BtnMminus).set_TabIndex(2);
		((Control)BtnMminus).set_Text("M-");
		((ButtonBase)BtnMminus).set_UseVisualStyleBackColor(true);
		((Control)BtnMS).set_Font(new Font("Microsoft Sans Serif", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)BtnMS).set_Location(new Point(386, 139));
		((Control)BtnMS).set_Margin(new Padding(3, 2, 3, 2));
		((Control)BtnMS).set_Name("BtnMS");
		((Control)BtnMS).set_Size(new Size(75, 32));
		((Control)BtnMS).set_TabIndex(2);
		((Control)BtnMS).set_Text("MS");
		((ButtonBase)BtnMS).set_UseVisualStyleBackColor(true);
		((Control)checkBox1).set_AutoSize(true);
		((Control)checkBox1).set_Location(new Point(92, 40));
		((Control)checkBox1).set_Name("checkBox1");
		((Control)checkBox1).set_Size(new Size(98, 21));
		((Control)checkBox1).set_TabIndex(3);
		((Control)checkBox1).set_Text("checkBox1");
		((ButtonBase)checkBox1).set_UseVisualStyleBackColor(true);
		((Control)checkBox2).set_AutoSize(true);
		((Control)checkBox2).set_Location(new Point(361, 58));
		((Control)checkBox2).set_Name("checkBox2");
		((Control)checkBox2).set_Size(new Size(98, 21));
		((Control)checkBox2).set_TabIndex(4);
		((Control)checkBox2).set_Text("checkBox2");
		((ButtonBase)checkBox2).set_UseVisualStyleBackColor(true);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(8f, 16f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Control)this).set_AutoSize(true);
		((Control)this).set_BackColor(SystemColors.ButtonFace);
		((Form)this).set_ClientSize(new Size(489, 682));
		((Control)this).get_Controls().Add((Control)(object)checkBox2);
		((Control)this).get_Controls().Add((Control)(object)checkBox1);
		((Control)this).get_Controls().Add((Control)(object)BtnMS);
		((Control)this).get_Controls().Add((Control)(object)BtnMminus);
		((Control)this).get_Controls().Add((Control)(object)BtnMplus);
		((Control)this).get_Controls().Add((Control)(object)BtnMR);
		((Control)this).get_Controls().Add((Control)(object)BtnMC);
		((Control)this).get_Controls().Add((Control)(object)BtnSep);
		((Control)this).get_Controls().Add((Control)(object)Btn3);
		((Control)this).get_Controls().Add((Control)(object)Btn6);
		((Control)this).get_Controls().Add((Control)(object)Btn9);
		((Control)this).get_Controls().Add((Control)(object)BtnDel);
		((Control)this).get_Controls().Add((Control)(object)Btn0);
		((Control)this).get_Controls().Add((Control)(object)Btn2);
		((Control)this).get_Controls().Add((Control)(object)Btn5);
		((Control)this).get_Controls().Add((Control)(object)Btn8);
		((Control)this).get_Controls().Add((Control)(object)BtnC);
		((Control)this).get_Controls().Add((Control)(object)BtnEq);
		((Control)this).get_Controls().Add((Control)(object)BtnAdd);
		((Control)this).get_Controls().Add((Control)(object)BtnSub);
		((Control)this).get_Controls().Add((Control)(object)BtnMult);
		((Control)this).get_Controls().Add((Control)(object)BtnDiv);
		((Control)this).get_Controls().Add((Control)(object)BtnNeg);
		((Control)this).get_Controls().Add((Control)(object)Btn1);
		((Control)this).get_Controls().Add((Control)(object)Btn4);
		((Control)this).get_Controls().Add((Control)(object)Btn7);
		((Control)this).get_Controls().Add((Control)(object)BtnCE);
		((Control)this).get_Controls().Add((Control)(object)LblHistory);
		((Control)this).get_Controls().Add((Control)(object)LblDisplay);
		((Form)this).set_Margin(new Padding(3, 2, 3, 2));
		((Form)this).set_MaximizeBox(false);
		((Form)this).set_MinimizeBox(false);
		((Control)this).set_Name("frmCalculator");
		((Form)this).set_ShowIcon(false);
		((Form)this).set_StartPosition((FormStartPosition)1);
		((Control)this).set_Text("Calculator");
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}
}
