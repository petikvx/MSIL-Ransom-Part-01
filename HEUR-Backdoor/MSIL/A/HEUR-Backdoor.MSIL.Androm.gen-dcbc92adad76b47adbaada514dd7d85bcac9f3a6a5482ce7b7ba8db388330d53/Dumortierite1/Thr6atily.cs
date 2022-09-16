using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Dumortierite1;

public class Thr6atily : Form
{
	private string Wo6derla6d = string.Empty;

	private IContainer Steat5pygic = null;

	private Button Gl2de;

	private Button Lut1iniz1;

	private Button Pantog5aph;

	private Button Fa6lt;

	private Button Cop2emic;

	private Button Btn6;

	private Button Fr4ws;

	private Button F4resh4wed;

	private Button J3niority;

	private Button Toros1ty;

	private Button Pen7a7hle7e;

	private Button Citr3l;

	private Button Pur1br1d;

	private Button Sulfiti4;

	private Button Radis8es;

	private Button Poe4ess;

	private TextBox Sorbitol7;

	private Button Unne0rotic;

	public Thr6atily()
	{
		Planaritie0();
	}

	private void Re7retters(object sender, EventArgs e)
	{
		if (Wo6derla6d != string.Empty)
		{
			method_0("0");
		}
		else if (!Colluder8())
		{
			method_0("0");
		}
	}

	private void Fr4ws_Click(object sender, EventArgs e)
	{
		method_0("1");
	}

	private void Thi6tyish(object sender, EventArgs e)
	{
		method_0("2");
	}

	private void P4r4sh4h(object sender, EventArgs e)
	{
		method_0("3");
	}

	private void Fa6lt_Click(object sender, EventArgs e)
	{
		method_0("4");
	}

	private void Bogu5ne55e5(object sender, EventArgs e)
	{
		method_0("5");
	}

	private void Agenda4(object sender, EventArgs e)
	{
		method_0("6");
	}

	private void Sp1r1g1nium(object sender, EventArgs e)
	{
		method_0("7");
	}

	private void Conc1rrents(object sender, EventArgs e)
	{
		method_0("8");
	}

	private void Pantog5aph_Click(object sender, EventArgs e)
	{
		method_0("9");
	}

	private void Char7oaling(object sender, EventArgs e)
	{
		if (Wo6derla6d != string.Empty && !Colluder8())
		{
			method_0("+");
		}
	}

	private void Dise3dowme3t(object sender, EventArgs e)
	{
		if (Wo6derla6d != string.Empty && !Colluder8())
		{
			method_0("-");
		}
	}

	private void Sie1ed(object sender, EventArgs e)
	{
		if (Wo6derla6d != string.Empty && !Colluder8())
		{
			method_0("*");
		}
	}

	private void No0eco0omic(object sender, EventArgs e)
	{
		if (Wo6derla6d != string.Empty && !Colluder8())
		{
			method_0("/");
		}
	}

	private void Os2racoderms(object sender, EventArgs e)
	{
		((Control)Sorbitol7).Focus();
		if (Wo6derla6d == string.Empty)
		{
			((Control)Sorbitol7).set_Text("0");
			((TextBoxBase)Sorbitol7).Select(((Control)Sorbitol7).get_Text().Length, 0);
			((TextBoxBase)Sorbitol7).ScrollToCaret();
			return;
		}
		Wo6derla6d = Wo6derla6d.Substring(0, Wo6derla6d.Length - 1);
		if (string.Equals(Wo6derla6d, string.Empty))
		{
			Wo6derla6d = "0";
		}
		((Control)Sorbitol7).set_Text(Wo6derla6d);
		((TextBoxBase)Sorbitol7).Select(((Control)Sorbitol7).get_Text().Length, 0);
		((TextBoxBase)Sorbitol7).ScrollToCaret();
	}

	private void Toros1ty_Click(object sender, EventArgs e)
	{
		if (Wo6derla6d == string.Empty)
		{
			method_0("0.");
			return;
		}
		char[] anyOf = new char[4] { '+', '-', '*', '/' };
		int num = Wo6derla6d.LastIndexOfAny(anyOf);
		if (num == -1 && !Wo6derla6d.Contains("."))
		{
			method_0(".");
		}
		else if (num != -1 && Wo6derla6d.IndexOf(".", num) == -1 && !Colluder8())
		{
			method_0(".");
		}
	}

	private void Zugzw5ngs(object sender, EventArgs e)
	{
		((Control)Sorbitol7).Focus();
		if (Wo6derla6d.IndexOfAny(new char[4] { '+', '-', '*', '/' }) != -1)
		{
			try
			{
				double num = Tera1hms.Granu5ate().Shelle1(Wo6derla6d);
				Wo6derla6d = string.Empty;
				((Control)Sorbitol7).set_Text(num.ToString());
				((TextBoxBase)Sorbitol7).Select(((Control)Sorbitol7).get_Text().Length, 0);
				((TextBoxBase)Sorbitol7).ScrollToCaret();
			}
			catch (Exception)
			{
			}
		}
	}

	private void method_0(string Cram7fishes)
	{
		((Control)Sorbitol7).Focus();
		if (Wo6derla6d == "0" && Cram7fishes != ".")
		{
			Wo6derla6d = Cram7fishes;
		}
		else
		{
			Wo6derla6d += Cram7fishes;
		}
		((Control)Sorbitol7).set_Text(Wo6derla6d);
		((TextBoxBase)Sorbitol7).Select(((Control)Sorbitol7).get_Text().Length, 0);
		((TextBoxBase)Sorbitol7).ScrollToCaret();
	}

	private bool Colluder8()
	{
		if (Wo6derla6d.Length == 0)
		{
			return false;
		}
		switch (Wo6derla6d[Wo6derla6d.Length - 1])
		{
		default:
			return false;
		case '*':
		case '+':
		case '-':
		case '/':
			return true;
		}
	}

	private void Thr6atily_KeyDown(object sender, KeyEventArgs e)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Invalid comparison between Unknown and I4
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Invalid comparison between Unknown and I4
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Invalid comparison between Unknown and I4
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Invalid comparison between Unknown and I4
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_007d: Expected I4, but got Unknown
		Keys keyCode = e.get_KeyCode();
		Keys val = keyCode;
		if ((int)val <= 13)
		{
			if ((int)val != 8)
			{
				if ((int)val == 13)
				{
					Zugzw5ngs(null, null);
				}
				return;
			}
		}
		else if ((int)val != 46)
		{
			switch (val - 96)
			{
			case 0:
				Re7retters(null, null);
				break;
			case 1:
				Fr4ws_Click(null, null);
				break;
			case 2:
				Thi6tyish(null, null);
				break;
			case 3:
				P4r4sh4h(null, null);
				break;
			case 4:
				Fa6lt_Click(null, null);
				break;
			case 5:
				Bogu5ne55e5(null, null);
				break;
			case 6:
				Agenda4(null, null);
				break;
			case 7:
				Sp1r1g1nium(null, null);
				break;
			case 8:
				Conc1rrents(null, null);
				break;
			case 9:
				Pantog5aph_Click(null, null);
				break;
			case 10:
				Sie1ed(null, null);
				break;
			case 11:
				Char7oaling(null, null);
				break;
			case 13:
				Dise3dowme3t(null, null);
				break;
			case 14:
				Toros1ty_Click(null, null);
				break;
			case 15:
				No0eco0omic(null, null);
				break;
			case 12:
				break;
			}
			return;
		}
		Os2racoderms(null, null);
	}

	protected override void Dispose(bool disposing)
	{
		if (disposing && Steat5pygic != null)
		{
			Steat5pygic.Dispose();
		}
		((Form)this).Dispose(disposing);
	}

	private void Planaritie0()
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
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		//IL_009f: Expected O, but got Unknown
		//IL_00a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00aa: Expected O, but got Unknown
		//IL_00ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b5: Expected O, but got Unknown
		//IL_00b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c0: Expected O, but got Unknown
		//IL_00c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cb: Expected O, but got Unknown
		//IL_00cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d6: Expected O, but got Unknown
		//IL_0971: Unknown result type (might be due to invalid IL or missing references)
		//IL_097b: Expected O, but got Unknown
		//IL_0c12: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c1c: Expected O, but got Unknown
		//IL_0c4f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c59: Expected O, but got Unknown
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(Thr6atily));
		Gl2de = new Button();
		Lut1iniz1 = new Button();
		Pantog5aph = new Button();
		Fa6lt = new Button();
		Cop2emic = new Button();
		Btn6 = new Button();
		Fr4ws = new Button();
		F4resh4wed = new Button();
		J3niority = new Button();
		Toros1ty = new Button();
		Pen7a7hle7e = new Button();
		Citr3l = new Button();
		Pur1br1d = new Button();
		Sulfiti4 = new Button();
		Radis8es = new Button();
		Poe4ess = new Button();
		Sorbitol7 = new TextBox();
		Unne0rotic = new Button();
		((Control)this).SuspendLayout();
		((Control)Gl2de).set_Location(new Point(12, 115));
		((Control)Gl2de).set_Name("Btn7");
		((Control)Gl2de).set_Size(new Size(115, 50));
		((Control)Gl2de).set_TabIndex(1);
		((Control)Gl2de).set_TabStop(false);
		((Control)Gl2de).set_Text("7");
		((ButtonBase)Gl2de).set_UseVisualStyleBackColor(true);
		((Control)Gl2de).add_Click((EventHandler)Sp1r1g1nium);
		((Control)Lut1iniz1).set_Location(new Point(133, 115));
		((Control)Lut1iniz1).set_Name("Btn8");
		((Control)Lut1iniz1).set_Size(new Size(115, 50));
		((Control)Lut1iniz1).set_TabIndex(1);
		((Control)Lut1iniz1).set_TabStop(false);
		((Control)Lut1iniz1).set_Text("8");
		((ButtonBase)Lut1iniz1).set_UseVisualStyleBackColor(true);
		((Control)Lut1iniz1).add_Click((EventHandler)Conc1rrents);
		((Control)Pantog5aph).set_Location(new Point(254, 115));
		((Control)Pantog5aph).set_Name("Btn9");
		((Control)Pantog5aph).set_Size(new Size(115, 50));
		((Control)Pantog5aph).set_TabIndex(1);
		((Control)Pantog5aph).set_TabStop(false);
		((Control)Pantog5aph).set_Text("9");
		((ButtonBase)Pantog5aph).set_UseVisualStyleBackColor(true);
		((Control)Pantog5aph).add_Click((EventHandler)Pantog5aph_Click);
		((Control)Fa6lt).set_Location(new Point(12, 171));
		((Control)Fa6lt).set_Name("Btn4");
		((Control)Fa6lt).set_Size(new Size(115, 50));
		((Control)Fa6lt).set_TabIndex(1);
		((Control)Fa6lt).set_TabStop(false);
		((Control)Fa6lt).set_Text("4");
		((ButtonBase)Fa6lt).set_UseVisualStyleBackColor(true);
		((Control)Fa6lt).add_Click((EventHandler)Fa6lt_Click);
		((Control)Cop2emic).set_Location(new Point(133, 171));
		((Control)Cop2emic).set_Name("Btn5");
		((Control)Cop2emic).set_Size(new Size(115, 50));
		((Control)Cop2emic).set_TabIndex(1);
		((Control)Cop2emic).set_TabStop(false);
		((Control)Cop2emic).set_Text("5");
		((ButtonBase)Cop2emic).set_UseVisualStyleBackColor(true);
		((Control)Cop2emic).add_Click((EventHandler)Bogu5ne55e5);
		((Control)Btn6).set_Location(new Point(254, 171));
		((Control)Btn6).set_Name("Btn6");
		((Control)Btn6).set_Size(new Size(115, 50));
		((Control)Btn6).set_TabIndex(1);
		((Control)Btn6).set_TabStop(false);
		((Control)Btn6).set_Text("6");
		((ButtonBase)Btn6).set_UseVisualStyleBackColor(true);
		((Control)Btn6).add_Click((EventHandler)Agenda4);
		((Control)Fr4ws).set_Location(new Point(12, 227));
		((Control)Fr4ws).set_Name("Btn1");
		((Control)Fr4ws).set_Size(new Size(115, 50));
		((Control)Fr4ws).set_TabIndex(1);
		((Control)Fr4ws).set_TabStop(false);
		((Control)Fr4ws).set_Text("1");
		((ButtonBase)Fr4ws).set_UseVisualStyleBackColor(true);
		((Control)Fr4ws).add_Click((EventHandler)Fr4ws_Click);
		((Control)F4resh4wed).set_Location(new Point(133, 227));
		((Control)F4resh4wed).set_Name("Btn2");
		((Control)F4resh4wed).set_Size(new Size(115, 50));
		((Control)F4resh4wed).set_TabIndex(1);
		((Control)F4resh4wed).set_TabStop(false);
		((Control)F4resh4wed).set_Text("2");
		((ButtonBase)F4resh4wed).set_UseVisualStyleBackColor(true);
		((Control)F4resh4wed).add_Click((EventHandler)Thi6tyish);
		((Control)J3niority).set_Location(new Point(254, 227));
		((Control)J3niority).set_Name("Btn3");
		((Control)J3niority).set_Size(new Size(115, 50));
		((Control)J3niority).set_TabIndex(1);
		((Control)J3niority).set_TabStop(false);
		((Control)J3niority).set_Text("3");
		((ButtonBase)J3niority).set_UseVisualStyleBackColor(true);
		((Control)J3niority).add_Click((EventHandler)P4r4sh4h);
		((Control)Toros1ty).set_Location(new Point(254, 283));
		((Control)Toros1ty).set_Name("Btndian");
		((Control)Toros1ty).set_Size(new Size(115, 50));
		((Control)Toros1ty).set_TabIndex(1);
		((Control)Toros1ty).set_TabStop(false);
		((Control)Toros1ty).set_Text(".");
		((ButtonBase)Toros1ty).set_UseVisualStyleBackColor(true);
		((Control)Toros1ty).add_Click((EventHandler)Toros1ty_Click);
		((Control)Pen7a7hle7e).set_Location(new Point(375, 224));
		((Control)Pen7a7hle7e).set_Name("Btnenter");
		((Control)Pen7a7hle7e).set_Size(new Size(115, 109));
		((Control)Pen7a7hle7e).set_TabIndex(1);
		((Control)Pen7a7hle7e).set_TabStop(false);
		((Control)Pen7a7hle7e).set_Text("Enter");
		((ButtonBase)Pen7a7hle7e).set_UseVisualStyleBackColor(true);
		((Control)Pen7a7hle7e).add_Click((EventHandler)Zugzw5ngs);
		((Control)Citr3l).set_Location(new Point(12, 283));
		((Control)Citr3l).set_Name("Btn0");
		((Control)Citr3l).set_Size(new Size(236, 50));
		((Control)Citr3l).set_TabIndex(1);
		((Control)Citr3l).set_TabStop(false);
		((Control)Citr3l).set_Text("0");
		((ButtonBase)Citr3l).set_UseVisualStyleBackColor(true);
		((Control)Citr3l).add_Click((EventHandler)Re7retters);
		((Control)Pur1br1d).set_Location(new Point(133, 59));
		((Control)Pur1br1d).set_Name("Btnchu");
		((Control)Pur1br1d).set_Size(new Size(115, 50));
		((Control)Pur1br1d).set_TabIndex(1);
		((Control)Pur1br1d).set_TabStop(false);
		((Control)Pur1br1d).set_Text("/");
		((ButtonBase)Pur1br1d).set_UseVisualStyleBackColor(true);
		((Control)Pur1br1d).add_Click((EventHandler)No0eco0omic);
		((Control)Sulfiti4).set_Location(new Point(375, 59));
		((Control)Sulfiti4).set_Name("Btnjian");
		((Control)Sulfiti4).set_Size(new Size(115, 50));
		((Control)Sulfiti4).set_TabIndex(1);
		((Control)Sulfiti4).set_TabStop(false);
		((Control)Sulfiti4).set_Text("-");
		((ButtonBase)Sulfiti4).set_UseVisualStyleBackColor(true);
		((Control)Sulfiti4).add_Click((EventHandler)Dise3dowme3t);
		((Control)Radis8es).set_Location(new Point(254, 59));
		((Control)Radis8es).set_Name("Btncheng");
		((Control)Radis8es).set_Size(new Size(115, 50));
		((Control)Radis8es).set_TabIndex(1);
		((Control)Radis8es).set_TabStop(false);
		((Control)Radis8es).set_Text("*");
		((ButtonBase)Radis8es).set_UseVisualStyleBackColor(true);
		((Control)Radis8es).add_Click((EventHandler)Sie1ed);
		((Control)Poe4ess).set_Location(new Point(375, 115));
		((Control)Poe4ess).set_Name("Btnjia");
		((Control)Poe4ess).set_Size(new Size(115, 106));
		((Control)Poe4ess).set_TabIndex(1);
		((Control)Poe4ess).set_TabStop(false);
		((Control)Poe4ess).set_Text("+");
		((ButtonBase)Poe4ess).set_UseVisualStyleBackColor(true);
		((Control)Poe4ess).add_Click((EventHandler)Char7oaling);
		((Control)Sorbitol7).set_CausesValidation(false);
		((Control)Sorbitol7).set_Font(new Font("宋体", 21.75f, (FontStyle)0, (GraphicsUnit)3, (byte)134));
		((Control)Sorbitol7).set_Location(new Point(12, 12));
		((Control)Sorbitol7).set_Name("ShowBox");
		((TextBoxBase)Sorbitol7).set_ReadOnly(true);
		((TextBoxBase)Sorbitol7).set_ShortcutsEnabled(false);
		((Control)Sorbitol7).set_Size(new Size(478, 41));
		((Control)Sorbitol7).set_TabIndex(1);
		((Control)Sorbitol7).set_TabStop(false);
		((Control)Sorbitol7).set_Text("0");
		Sorbitol7.set_TextAlign((HorizontalAlignment)1);
		((Control)Unne0rotic).set_CausesValidation(false);
		((Control)Unne0rotic).set_Location(new Point(12, 59));
		((Control)Unne0rotic).set_Name("Btnc");
		((Control)Unne0rotic).set_Size(new Size(115, 50));
		((Control)Unne0rotic).set_TabIndex(1);
		((Control)Unne0rotic).set_TabStop(false);
		((Control)Unne0rotic).set_Text("C");
		((ButtonBase)Unne0rotic).set_UseVisualStyleBackColor(true);
		((Control)Unne0rotic).add_Click((EventHandler)Os2racoderms);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 12f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(506, 344));
		((Control)this).get_Controls().Add((Control)(object)Unne0rotic);
		((Control)this).get_Controls().Add((Control)(object)Sorbitol7);
		((Control)this).get_Controls().Add((Control)(object)Poe4ess);
		((Control)this).get_Controls().Add((Control)(object)Radis8es);
		((Control)this).get_Controls().Add((Control)(object)Sulfiti4);
		((Control)this).get_Controls().Add((Control)(object)Pur1br1d);
		((Control)this).get_Controls().Add((Control)(object)Citr3l);
		((Control)this).get_Controls().Add((Control)(object)Pen7a7hle7e);
		((Control)this).get_Controls().Add((Control)(object)Toros1ty);
		((Control)this).get_Controls().Add((Control)(object)J3niority);
		((Control)this).get_Controls().Add((Control)(object)F4resh4wed);
		((Control)this).get_Controls().Add((Control)(object)Fr4ws);
		((Control)this).get_Controls().Add((Control)(object)Btn6);
		((Control)this).get_Controls().Add((Control)(object)Cop2emic);
		((Control)this).get_Controls().Add((Control)(object)Fa6lt);
		((Control)this).get_Controls().Add((Control)(object)Pantog5aph);
		((Control)this).get_Controls().Add((Control)(object)Lut1iniz1);
		((Control)this).get_Controls().Add((Control)(object)Gl2de);
		((Control)this).set_Cursor(Cursors.get_Default());
		((Form)this).set_FormBorderStyle((FormBorderStyle)1);
		((Form)this).set_Icon((Icon)componentResourceManager.GetObject("$this.Icon"));
		((Form)this).set_KeyPreview(true);
		((Form)this).set_MaximizeBox(false);
		((Control)this).set_Name("Thr6atily");
		((Form)this).set_StartPosition((FormStartPosition)1);
		((Control)this).set_Text("计算器 by itning");
		((Control)this).add_KeyDown(new KeyEventHandler(Thr6atily_KeyDown));
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}
}
