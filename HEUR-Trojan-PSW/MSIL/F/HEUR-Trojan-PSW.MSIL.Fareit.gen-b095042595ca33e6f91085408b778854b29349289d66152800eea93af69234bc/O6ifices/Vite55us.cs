using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Os4illography;

namespace O6ifices;

public class Vite55us : Form
{
	private string Ungall5d = string.Empty;

	private IContainer Sh3npikings = null;

	private Button D4enesses;

	private Button Irr8v8rsibility;

	private Button B6g;

	private Button Taun7ers;

	private Button Btn5;

	private Button Dogban5;

	private Button Outr3ws;

	private Button Stil1ene;

	private Button Ga66lers;

	private Button R3unchinesses;

	private Button D1p1rm1d;

	private Button Aspe3se3;

	private Button Gr2vels;

	private Button En4ound;

	private Button Sa00ulations;

	private Button D3st3nct3ve;

	private TextBox Bugba8es;

	private Button A4miringly;

	public Vite55us()
	{
		B2oph2l2as();
	}

	private void Geldin1(object sender, EventArgs e)
	{
		if (Ungall5d != string.Empty)
		{
			A7bergris("0");
		}
		else if (!Sha8ing())
		{
			A7bergris("0");
		}
	}

	private void Vi5tories(object sender, EventArgs e)
	{
		A7bergris("1");
	}

	private void Upstro3es(object sender, EventArgs e)
	{
		A7bergris("2");
	}

	private void Bludgeo6s(object sender, EventArgs e)
	{
		A7bergris("3");
	}

	private void Noncomm8ttal(object sender, EventArgs e)
	{
		A7bergris("4");
	}

	private void Btn5_Click(object sender, EventArgs e)
	{
		A7bergris("5");
	}

	private void Extre7a(object sender, EventArgs e)
	{
		A7bergris("6");
	}

	private void Cy8ers(object sender, EventArgs e)
	{
		A7bergris("7");
	}

	private void Tot6lizers(object sender, EventArgs e)
	{
		A7bergris("8");
	}

	private void Su2c2ded(object sender, EventArgs e)
	{
		A7bergris("9");
	}

	private void N4wsl4ss(object sender, EventArgs e)
	{
		if (Ungall5d != string.Empty && !Sha8ing())
		{
			A7bergris("+");
		}
	}

	private void Reduc2bly(object sender, EventArgs e)
	{
		if (Ungall5d != string.Empty && !Sha8ing())
		{
			A7bergris("-");
		}
	}

	private void Exo5ontia(object sender, EventArgs e)
	{
		if (Ungall5d != string.Empty && !Sha8ing())
		{
			A7bergris("*");
		}
	}

	private void Gr2vels_Click(object sender, EventArgs e)
	{
		if (Ungall5d != string.Empty && !Sha8ing())
		{
			A7bergris("/");
		}
	}

	private void Sli7inesses(object sender, EventArgs e)
	{
		((Control)Bugba8es).Focus();
		if (Ungall5d == string.Empty)
		{
			((Control)Bugba8es).set_Text("0");
			((TextBoxBase)Bugba8es).Select(((Control)Bugba8es).get_Text().Length, 0);
			((TextBoxBase)Bugba8es).ScrollToCaret();
			return;
		}
		Ungall5d = Ungall5d.Substring(0, Ungall5d.Length - 1);
		if (string.Equals(Ungall5d, string.Empty))
		{
			Ungall5d = "0";
		}
		((Control)Bugba8es).set_Text(Ungall5d);
		((TextBoxBase)Bugba8es).Select(((Control)Bugba8es).get_Text().Length, 0);
		((TextBoxBase)Bugba8es).ScrollToCaret();
	}

	private void D3magog3d(object sender, EventArgs e)
	{
		if (Ungall5d == string.Empty)
		{
			A7bergris("0.");
			return;
		}
		char[] anyOf = new char[4] { '+', '-', '*', '/' };
		int num = Ungall5d.LastIndexOfAny(anyOf);
		if (num == -1 && !Ungall5d.Contains("."))
		{
			A7bergris(".");
		}
		else if (num != -1 && Ungall5d.IndexOf(".", num) == -1 && !Sha8ing())
		{
			A7bergris(".");
		}
	}

	private void Com2ensates(object sender, EventArgs e)
	{
		((Control)Bugba8es).Focus();
		if (Ungall5d.IndexOfAny(new char[4] { '+', '-', '*', '/' }) != -1)
		{
			try
			{
				double num = St7ure.smethod_0().A2akenings(Ungall5d);
				Ungall5d = string.Empty;
				((Control)Bugba8es).set_Text(num.ToString());
				((TextBoxBase)Bugba8es).Select(((Control)Bugba8es).get_Text().Length, 0);
				((TextBoxBase)Bugba8es).ScrollToCaret();
			}
			catch (Exception)
			{
			}
		}
	}

	private void A7bergris(string Pr4fir4d)
	{
		((Control)Bugba8es).Focus();
		if (Ungall5d == "0" && Pr4fir4d != ".")
		{
			Ungall5d = Pr4fir4d;
		}
		else
		{
			Ungall5d += Pr4fir4d;
		}
		((Control)Bugba8es).set_Text(Ungall5d);
		((TextBoxBase)Bugba8es).Select(((Control)Bugba8es).get_Text().Length, 0);
		((TextBoxBase)Bugba8es).ScrollToCaret();
	}

	private bool Sha8ing()
	{
		if (Ungall5d.Length == 0)
		{
			return false;
		}
		switch (Ungall5d[Ungall5d.Length - 1])
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

	private void Sl1w(object sender, KeyEventArgs e)
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
					Com2ensates(null, null);
				}
				return;
			}
		}
		else if ((int)val != 46)
		{
			switch (val - 96)
			{
			case 0:
				Geldin1(null, null);
				break;
			case 1:
				Vi5tories(null, null);
				break;
			case 2:
				Upstro3es(null, null);
				break;
			case 3:
				Bludgeo6s(null, null);
				break;
			case 4:
				Noncomm8ttal(null, null);
				break;
			case 5:
				Btn5_Click(null, null);
				break;
			case 6:
				Extre7a(null, null);
				break;
			case 7:
				Cy8ers(null, null);
				break;
			case 8:
				Tot6lizers(null, null);
				break;
			case 9:
				Su2c2ded(null, null);
				break;
			case 10:
				Exo5ontia(null, null);
				break;
			case 11:
				N4wsl4ss(null, null);
				break;
			case 13:
				Reduc2bly(null, null);
				break;
			case 14:
				D3magog3d(null, null);
				break;
			case 15:
				Gr2vels_Click(null, null);
				break;
			case 12:
				break;
			}
			return;
		}
		Sli7inesses(null, null);
	}

	protected override void Dispose(bool disposing)
	{
		if (disposing && Sh3npikings != null)
		{
			Sh3npikings.Dispose();
		}
		((Form)this).Dispose(disposing);
	}

	private void B2oph2l2as()
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
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(Vite55us));
		D4enesses = new Button();
		Irr8v8rsibility = new Button();
		B6g = new Button();
		Taun7ers = new Button();
		Btn5 = new Button();
		Dogban5 = new Button();
		Outr3ws = new Button();
		Stil1ene = new Button();
		Ga66lers = new Button();
		R3unchinesses = new Button();
		D1p1rm1d = new Button();
		Aspe3se3 = new Button();
		Gr2vels = new Button();
		En4ound = new Button();
		Sa00ulations = new Button();
		D3st3nct3ve = new Button();
		Bugba8es = new TextBox();
		A4miringly = new Button();
		((Control)this).SuspendLayout();
		((Control)D4enesses).set_Location(new Point(12, 115));
		((Control)D4enesses).set_Name("Btn7");
		((Control)D4enesses).set_Size(new Size(115, 50));
		((Control)D4enesses).set_TabIndex(1);
		((Control)D4enesses).set_TabStop(false);
		((Control)D4enesses).set_Text("7");
		((ButtonBase)D4enesses).set_UseVisualStyleBackColor(true);
		((Control)D4enesses).add_Click((EventHandler)Cy8ers);
		((Control)Irr8v8rsibility).set_Location(new Point(133, 115));
		((Control)Irr8v8rsibility).set_Name("Btn8");
		((Control)Irr8v8rsibility).set_Size(new Size(115, 50));
		((Control)Irr8v8rsibility).set_TabIndex(1);
		((Control)Irr8v8rsibility).set_TabStop(false);
		((Control)Irr8v8rsibility).set_Text("8");
		((ButtonBase)Irr8v8rsibility).set_UseVisualStyleBackColor(true);
		((Control)Irr8v8rsibility).add_Click((EventHandler)Tot6lizers);
		((Control)B6g).set_Location(new Point(254, 115));
		((Control)B6g).set_Name("Btn9");
		((Control)B6g).set_Size(new Size(115, 50));
		((Control)B6g).set_TabIndex(1);
		((Control)B6g).set_TabStop(false);
		((Control)B6g).set_Text("9");
		((ButtonBase)B6g).set_UseVisualStyleBackColor(true);
		((Control)B6g).add_Click((EventHandler)Su2c2ded);
		((Control)Taun7ers).set_Location(new Point(12, 171));
		((Control)Taun7ers).set_Name("Btn4");
		((Control)Taun7ers).set_Size(new Size(115, 50));
		((Control)Taun7ers).set_TabIndex(1);
		((Control)Taun7ers).set_TabStop(false);
		((Control)Taun7ers).set_Text("4");
		((ButtonBase)Taun7ers).set_UseVisualStyleBackColor(true);
		((Control)Taun7ers).add_Click((EventHandler)Noncomm8ttal);
		((Control)Btn5).set_Location(new Point(133, 171));
		((Control)Btn5).set_Name("Btn5");
		((Control)Btn5).set_Size(new Size(115, 50));
		((Control)Btn5).set_TabIndex(1);
		((Control)Btn5).set_TabStop(false);
		((Control)Btn5).set_Text("5");
		((ButtonBase)Btn5).set_UseVisualStyleBackColor(true);
		((Control)Btn5).add_Click((EventHandler)Btn5_Click);
		((Control)Dogban5).set_Location(new Point(254, 171));
		((Control)Dogban5).set_Name("Btn6");
		((Control)Dogban5).set_Size(new Size(115, 50));
		((Control)Dogban5).set_TabIndex(1);
		((Control)Dogban5).set_TabStop(false);
		((Control)Dogban5).set_Text("6");
		((ButtonBase)Dogban5).set_UseVisualStyleBackColor(true);
		((Control)Dogban5).add_Click((EventHandler)Extre7a);
		((Control)Outr3ws).set_Location(new Point(12, 227));
		((Control)Outr3ws).set_Name("Btn1");
		((Control)Outr3ws).set_Size(new Size(115, 50));
		((Control)Outr3ws).set_TabIndex(1);
		((Control)Outr3ws).set_TabStop(false);
		((Control)Outr3ws).set_Text("1");
		((ButtonBase)Outr3ws).set_UseVisualStyleBackColor(true);
		((Control)Outr3ws).add_Click((EventHandler)Vi5tories);
		((Control)Stil1ene).set_Location(new Point(133, 227));
		((Control)Stil1ene).set_Name("Btn2");
		((Control)Stil1ene).set_Size(new Size(115, 50));
		((Control)Stil1ene).set_TabIndex(1);
		((Control)Stil1ene).set_TabStop(false);
		((Control)Stil1ene).set_Text("2");
		((ButtonBase)Stil1ene).set_UseVisualStyleBackColor(true);
		((Control)Stil1ene).add_Click((EventHandler)Upstro3es);
		((Control)Ga66lers).set_Location(new Point(254, 227));
		((Control)Ga66lers).set_Name("Btn3");
		((Control)Ga66lers).set_Size(new Size(115, 50));
		((Control)Ga66lers).set_TabIndex(1);
		((Control)Ga66lers).set_TabStop(false);
		((Control)Ga66lers).set_Text("3");
		((ButtonBase)Ga66lers).set_UseVisualStyleBackColor(true);
		((Control)Ga66lers).add_Click((EventHandler)Bludgeo6s);
		((Control)R3unchinesses).set_Location(new Point(254, 283));
		((Control)R3unchinesses).set_Name("Btndian");
		((Control)R3unchinesses).set_Size(new Size(115, 50));
		((Control)R3unchinesses).set_TabIndex(1);
		((Control)R3unchinesses).set_TabStop(false);
		((Control)R3unchinesses).set_Text(".");
		((ButtonBase)R3unchinesses).set_UseVisualStyleBackColor(true);
		((Control)R3unchinesses).add_Click((EventHandler)D3magog3d);
		((Control)D1p1rm1d).set_Location(new Point(375, 224));
		((Control)D1p1rm1d).set_Name("Btnenter");
		((Control)D1p1rm1d).set_Size(new Size(115, 109));
		((Control)D1p1rm1d).set_TabIndex(1);
		((Control)D1p1rm1d).set_TabStop(false);
		((Control)D1p1rm1d).set_Text("Enter");
		((ButtonBase)D1p1rm1d).set_UseVisualStyleBackColor(true);
		((Control)D1p1rm1d).add_Click((EventHandler)Com2ensates);
		((Control)Aspe3se3).set_Location(new Point(12, 283));
		((Control)Aspe3se3).set_Name("Btn0");
		((Control)Aspe3se3).set_Size(new Size(236, 50));
		((Control)Aspe3se3).set_TabIndex(1);
		((Control)Aspe3se3).set_TabStop(false);
		((Control)Aspe3se3).set_Text("0");
		((ButtonBase)Aspe3se3).set_UseVisualStyleBackColor(true);
		((Control)Aspe3se3).add_Click((EventHandler)Geldin1);
		((Control)Gr2vels).set_Location(new Point(133, 59));
		((Control)Gr2vels).set_Name("Btnchu");
		((Control)Gr2vels).set_Size(new Size(115, 50));
		((Control)Gr2vels).set_TabIndex(1);
		((Control)Gr2vels).set_TabStop(false);
		((Control)Gr2vels).set_Text("/");
		((ButtonBase)Gr2vels).set_UseVisualStyleBackColor(true);
		((Control)Gr2vels).add_Click((EventHandler)Gr2vels_Click);
		((Control)En4ound).set_Location(new Point(375, 59));
		((Control)En4ound).set_Name("Btnjian");
		((Control)En4ound).set_Size(new Size(115, 50));
		((Control)En4ound).set_TabIndex(1);
		((Control)En4ound).set_TabStop(false);
		((Control)En4ound).set_Text("-");
		((ButtonBase)En4ound).set_UseVisualStyleBackColor(true);
		((Control)En4ound).add_Click((EventHandler)Reduc2bly);
		((Control)Sa00ulations).set_Location(new Point(254, 59));
		((Control)Sa00ulations).set_Name("Btncheng");
		((Control)Sa00ulations).set_Size(new Size(115, 50));
		((Control)Sa00ulations).set_TabIndex(1);
		((Control)Sa00ulations).set_TabStop(false);
		((Control)Sa00ulations).set_Text("*");
		((ButtonBase)Sa00ulations).set_UseVisualStyleBackColor(true);
		((Control)Sa00ulations).add_Click((EventHandler)Exo5ontia);
		((Control)D3st3nct3ve).set_Location(new Point(375, 115));
		((Control)D3st3nct3ve).set_Name("Btnjia");
		((Control)D3st3nct3ve).set_Size(new Size(115, 106));
		((Control)D3st3nct3ve).set_TabIndex(1);
		((Control)D3st3nct3ve).set_TabStop(false);
		((Control)D3st3nct3ve).set_Text("+");
		((ButtonBase)D3st3nct3ve).set_UseVisualStyleBackColor(true);
		((Control)D3st3nct3ve).add_Click((EventHandler)N4wsl4ss);
		((Control)Bugba8es).set_CausesValidation(false);
		((Control)Bugba8es).set_Font(new Font("宋体", 21.75f, (FontStyle)0, (GraphicsUnit)3, (byte)134));
		((Control)Bugba8es).set_Location(new Point(12, 12));
		((Control)Bugba8es).set_Name("ShowBox");
		((TextBoxBase)Bugba8es).set_ReadOnly(true);
		((TextBoxBase)Bugba8es).set_ShortcutsEnabled(false);
		((Control)Bugba8es).set_Size(new Size(478, 41));
		((Control)Bugba8es).set_TabIndex(1);
		((Control)Bugba8es).set_TabStop(false);
		((Control)Bugba8es).set_Text("0");
		Bugba8es.set_TextAlign((HorizontalAlignment)1);
		((Control)A4miringly).set_CausesValidation(false);
		((Control)A4miringly).set_Location(new Point(12, 59));
		((Control)A4miringly).set_Name("Btnc");
		((Control)A4miringly).set_Size(new Size(115, 50));
		((Control)A4miringly).set_TabIndex(1);
		((Control)A4miringly).set_TabStop(false);
		((Control)A4miringly).set_Text("C");
		((ButtonBase)A4miringly).set_UseVisualStyleBackColor(true);
		((Control)A4miringly).add_Click((EventHandler)Sli7inesses);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 12f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(506, 344));
		((Control)this).get_Controls().Add((Control)(object)A4miringly);
		((Control)this).get_Controls().Add((Control)(object)Bugba8es);
		((Control)this).get_Controls().Add((Control)(object)D3st3nct3ve);
		((Control)this).get_Controls().Add((Control)(object)Sa00ulations);
		((Control)this).get_Controls().Add((Control)(object)En4ound);
		((Control)this).get_Controls().Add((Control)(object)Gr2vels);
		((Control)this).get_Controls().Add((Control)(object)Aspe3se3);
		((Control)this).get_Controls().Add((Control)(object)D1p1rm1d);
		((Control)this).get_Controls().Add((Control)(object)R3unchinesses);
		((Control)this).get_Controls().Add((Control)(object)Ga66lers);
		((Control)this).get_Controls().Add((Control)(object)Stil1ene);
		((Control)this).get_Controls().Add((Control)(object)Outr3ws);
		((Control)this).get_Controls().Add((Control)(object)Dogban5);
		((Control)this).get_Controls().Add((Control)(object)Btn5);
		((Control)this).get_Controls().Add((Control)(object)Taun7ers);
		((Control)this).get_Controls().Add((Control)(object)B6g);
		((Control)this).get_Controls().Add((Control)(object)Irr8v8rsibility);
		((Control)this).get_Controls().Add((Control)(object)D4enesses);
		((Control)this).set_Cursor(Cursors.get_Default());
		((Form)this).set_FormBorderStyle((FormBorderStyle)1);
		((Form)this).set_Icon((Icon)componentResourceManager.GetObject("$this.Icon"));
		((Form)this).set_KeyPreview(true);
		((Form)this).set_MaximizeBox(false);
		((Control)this).set_Name("Vite55us");
		((Form)this).set_StartPosition((FormStartPosition)1);
		((Control)this).set_Text("计算器 by itning");
		((Control)this).add_KeyDown(new KeyEventHandler(Sl1w));
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}
}
