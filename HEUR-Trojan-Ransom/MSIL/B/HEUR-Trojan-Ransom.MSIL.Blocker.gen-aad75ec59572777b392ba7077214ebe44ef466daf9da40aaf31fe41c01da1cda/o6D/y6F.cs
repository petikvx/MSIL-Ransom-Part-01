using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Ez5;
using Microsoft.VisualBasic.CompilerServices;
using Pt8;
using Qm3;
using Xc5;
using z2C5;

namespace o6D;

[DesignerGenerated]
public class y6F : Form
{
	private IContainer components;

	private Button _cmdAddIncome;

	private Button _cmdAddExpense;

	private Label _Label3;

	private PictureBox _PictureBox2;

	private Button _Button3;

	private PictureBox _PictureBox3;

	internal PictureBox e;

	internal Label x;

	internal Label m;

	internal Label I;

	public y6F()
	{
		((Form)this).add_Load((EventHandler)p4M);
		Rj5();
	}

	protected override void Ft3(bool Nn4)
	{
		try
		{
			if (Nn4 && components != null)
			{
				components.Dispose();
			}
		}
		finally
		{
			((Form)this).Dispose(Nn4);
		}
	}

	private void Rj5()
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
		//IL_00d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dd: Expected O, but got Unknown
		//IL_0170: Unknown result type (might be due to invalid IL or missing references)
		//IL_017a: Expected O, but got Unknown
		//IL_0226: Unknown result type (might be due to invalid IL or missing references)
		//IL_0230: Expected O, but got Unknown
		//IL_02e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f1: Expected O, but got Unknown
		//IL_03b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_03be: Expected O, but got Unknown
		//IL_0461: Unknown result type (might be due to invalid IL or missing references)
		//IL_046b: Expected O, but got Unknown
		//IL_0503: Unknown result type (might be due to invalid IL or missing references)
		//IL_050d: Expected O, but got Unknown
		//IL_05b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_05c3: Expected O, but got Unknown
		//IL_0671: Unknown result type (might be due to invalid IL or missing references)
		//IL_067b: Expected O, but got Unknown
		//IL_071a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0724: Expected O, but got Unknown
		//IL_07cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_07d9: Expected O, but got Unknown
		//IL_08b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_08be: Expected O, but got Unknown
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(y6F));
		c6P(new PictureBox());
		k7T(new Button());
		Zg7(new Button());
		As8(new Label());
		Kb1(new Label());
		t8L(new Label());
		Kf3(new PictureBox());
		Jm3(new Button());
		Hm1(new PictureBox());
		c7R(new Label());
		((ISupportInitialize)Dw1()).BeginInit();
		((ISupportInitialize)Ez0()).BeginInit();
		((ISupportInitialize)p6X()).BeginInit();
		((Control)this).SuspendLayout();
		((Control)Dw1()).set_Anchor((AnchorStyles)15);
		((Control)Dw1()).set_BackColor(Color.Transparent);
		((Control)Dw1()).set_BackgroundImage((Image)componentResourceManager.GetObject("PictureBox1.BackgroundImage"));
		((Control)Dw1()).set_BackgroundImageLayout((ImageLayout)3);
		((Control)Dw1()).set_Location(new Point(159, 12));
		((Control)Dw1()).set_Name("PictureBox1");
		((Control)Dw1()).set_Size(new Size(195, 156));
		Dw1().set_TabIndex(0);
		Dw1().set_TabStop(false);
		((Control)Tq3()).set_Anchor((AnchorStyles)15);
		((ButtonBase)Tq3()).set_BackColor(Color.Transparent);
		((Control)Tq3()).set_BackgroundImage((Image)componentResourceManager.GetObject("cmdAddIncome.BackgroundImage"));
		((Control)Tq3()).set_BackgroundImageLayout((ImageLayout)3);
		((ButtonBase)Tq3()).set_FlatStyle((FlatStyle)0);
		((Control)Tq3()).set_ForeColor(Color.Transparent);
		((Control)Tq3()).set_Location(new Point(348, 221));
		((Control)Tq3()).set_Name("cmdAddIncome");
		((Control)Tq3()).set_Size(new Size(90, 82));
		((Control)Tq3()).set_TabIndex(1);
		((ButtonBase)Tq3()).set_UseVisualStyleBackColor(false);
		((Control)Bg5()).set_Anchor((AnchorStyles)15);
		((ButtonBase)Bg5()).set_BackColor(Color.Transparent);
		((Control)Bg5()).set_BackgroundImage((Image)componentResourceManager.GetObject("cmdAddExpense.BackgroundImage"));
		((Control)Bg5()).set_BackgroundImageLayout((ImageLayout)3);
		((ButtonBase)Bg5()).set_FlatStyle((FlatStyle)0);
		((Control)Bg5()).set_ForeColor(Color.Transparent);
		((Control)Bg5()).set_Location(new Point(84, 221));
		((Control)Bg5()).set_Name("cmdAddExpense");
		((Control)Bg5()).set_Size(new Size(94, 82));
		((Control)Bg5()).set_TabIndex(2);
		((ButtonBase)Bg5()).set_UseVisualStyleBackColor(false);
		((Control)Qm3()).set_Anchor((AnchorStyles)15);
		((Control)Qm3()).set_BackColor(Color.GreenYellow);
		Qm3().set_BorderStyle((BorderStyle)2);
		((Control)Qm3()).set_Font(new Font("Comic Sans MS", 11.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)Qm3()).set_ForeColor(Color.Teal);
		Qm3().set_ImageAlign((ContentAlignment)512);
		((Control)Qm3()).set_Location(new Point(144, 180));
		((Control)Qm3()).set_Name("LblBalance");
		((Control)Qm3()).set_Size(new Size(114, 29));
		((Control)Qm3()).set_TabIndex(3);
		Qm3().set_Text("BALANCE : ");
		Qm3().set_TextAlign((ContentAlignment)32);
		((Control)Cb7()).set_Anchor((AnchorStyles)15);
		Cb7().set_AutoSize(true);
		((Control)Cb7()).set_BackColor(Color.LightYellow);
		((Control)Cb7()).set_Font(new Font("Microsoft Sans Serif", 9.75f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)Cb7()).set_ForeColor(Color.Green);
		((Control)Cb7()).set_Location(new Point(92, 310));
		((Control)Cb7()).set_Name("Label2");
		((Control)Cb7()).set_Size(new Size(76, 16));
		((Control)Cb7()).set_TabIndex(4);
		Cb7().set_Text("Expenses");
		((Control)Am4()).set_Anchor((AnchorStyles)15);
		Am4().set_AutoSize(true);
		((Control)Am4()).set_BackColor(Color.LightYellow);
		((Control)Am4()).set_Font(new Font("Microsoft Sans Serif", 9.75f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)Am4()).set_ForeColor(Color.Green);
		((Control)Am4()).set_Location(new Point(349, 310));
		((Control)Am4()).set_Name("Label3");
		((Control)Am4()).set_Size(new Size(90, 16));
		((Control)Am4()).set_TabIndex(5);
		Am4().set_Text("Add Income");
		((Control)Ez0()).set_Anchor((AnchorStyles)15);
		((Control)Ez0()).set_BackColor(Color.Transparent);
		((Control)Ez0()).set_BackgroundImage((Image)componentResourceManager.GetObject("PictureBox2.BackgroundImage"));
		((Control)Ez0()).set_BackgroundImageLayout((ImageLayout)3);
		((Control)Ez0()).set_Location(new Point(12, 337));
		((Control)Ez0()).set_Name("PictureBox2");
		((Control)Ez0()).set_Size(new Size(63, 40));
		Ez0().set_TabIndex(10);
		Ez0().set_TabStop(false);
		((Control)Ce5()).set_Anchor((AnchorStyles)15);
		((ButtonBase)Ce5()).set_BackColor(Color.Lime);
		((Control)Ce5()).set_Cursor(Cursors.get_Hand());
		((ButtonBase)Ce5()).set_FlatStyle((FlatStyle)0);
		((Control)Ce5()).set_Font(new Font("Comic Sans MS", 9.75f, (FontStyle)3, (GraphicsUnit)3, (byte)0));
		((Control)Ce5()).set_ForeColor(Color.White);
		((Control)Ce5()).set_Location(new Point(68, 351));
		((Control)Ce5()).set_Name("Button3");
		((Control)Ce5()).set_Size(new Size(110, 26));
		((Control)Ce5()).set_TabIndex(9);
		((ButtonBase)Ce5()).set_Text(" Go &Back");
		((ButtonBase)Ce5()).set_TextAlign((ContentAlignment)2);
		((ButtonBase)Ce5()).set_UseVisualStyleBackColor(false);
		((Control)p6X()).set_Anchor((AnchorStyles)15);
		((Control)p6X()).set_BackColor(Color.Transparent);
		((Control)p6X()).set_BackgroundImage((Image)componentResourceManager.GetObject("PictureBox3.BackgroundImage"));
		((Control)p6X()).set_BackgroundImageLayout((ImageLayout)3);
		((Control)p6X()).set_Location(new Point(447, 337));
		((Control)p6X()).set_Name("PictureBox3");
		((Control)p6X()).set_Size(new Size(78, 52));
		p6X().set_TabIndex(11);
		p6X().set_TabStop(false);
		((Control)Ss9()).set_Anchor((AnchorStyles)15);
		((Control)Ss9()).set_BackColor(Color.GreenYellow);
		Ss9().set_BorderStyle((BorderStyle)2);
		((Control)Ss9()).set_Font(new Font("Comic Sans MS", 11.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)Ss9()).set_ForeColor(Color.Teal);
		Ss9().set_ImageAlign((ContentAlignment)512);
		((Control)Ss9()).set_Location(new Point(254, 180));
		((Control)Ss9()).set_Name("LblBal");
		((Control)Ss9()).set_Size(new Size(114, 29));
		((Control)Ss9()).set_TabIndex(12);
		Ss9().set_TextAlign((ContentAlignment)32);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(7f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_BackColor(SystemColors.ActiveCaptionText);
		((Control)this).set_BackgroundImage((Image)componentResourceManager.GetObject("$this.BackgroundImage"));
		((Control)this).set_BackgroundImageLayout((ImageLayout)3);
		((Form)this).set_ClientSize(new Size(523, 382));
		((Control)this).get_Controls().Add((Control)(object)Ss9());
		((Control)this).get_Controls().Add((Control)(object)p6X());
		((Control)this).get_Controls().Add((Control)(object)Ez0());
		((Control)this).get_Controls().Add((Control)(object)Ce5());
		((Control)this).get_Controls().Add((Control)(object)Am4());
		((Control)this).get_Controls().Add((Control)(object)Cb7());
		((Control)this).get_Controls().Add((Control)(object)Qm3());
		((Control)this).get_Controls().Add((Control)(object)Bg5());
		((Control)this).get_Controls().Add((Control)(object)Tq3());
		((Control)this).get_Controls().Add((Control)(object)Dw1());
		((Control)this).set_DoubleBuffered(true);
		((Control)this).set_Font(new Font("Microsoft Sans Serif", 8.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)this).set_Name("Form4");
		((Form)this).set_StartPosition((FormStartPosition)1);
		((Form)this).set_Text("Student Expenses");
		((ISupportInitialize)Dw1()).EndInit();
		((ISupportInitialize)Ez0()).EndInit();
		((ISupportInitialize)p6X()).EndInit();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	[SpecialName]
	internal virtual PictureBox Dw1()
	{
		return e;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void c6P(PictureBox Pz8)
	{
		PictureBox val = (e = Pz8);
	}

	[SpecialName]
	internal virtual Button Tq3()
	{
		return _cmdAddIncome;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void k7T(Button p3Q)
	{
		EventHandler eventHandler = Lm0;
		Button cmdAddIncome = _cmdAddIncome;
		if (cmdAddIncome != null)
		{
			((Control)cmdAddIncome).remove_Click(eventHandler);
		}
		_cmdAddIncome = p3Q;
		cmdAddIncome = _cmdAddIncome;
		if (cmdAddIncome != null)
		{
			((Control)cmdAddIncome).add_Click(eventHandler);
		}
	}

	[SpecialName]
	internal virtual Button Bg5()
	{
		return _cmdAddExpense;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Zg7(Button Mx2)
	{
		EventHandler eventHandler = Pw8;
		Button cmdAddExpense = _cmdAddExpense;
		if (cmdAddExpense != null)
		{
			((Control)cmdAddExpense).remove_Click(eventHandler);
		}
		_cmdAddExpense = Mx2;
		cmdAddExpense = _cmdAddExpense;
		if (cmdAddExpense != null)
		{
			((Control)cmdAddExpense).add_Click(eventHandler);
		}
	}

	[SpecialName]
	internal virtual Label Qm3()
	{
		return x;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void As8(Label Ci7)
	{
		Label val = (x = Ci7);
	}

	[SpecialName]
	internal virtual Label Cb7()
	{
		return m;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Kb1(Label Xg0)
	{
		Label val = (m = Xg0);
	}

	[SpecialName]
	internal virtual Label Am4()
	{
		return _Label3;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void t8L(Label Hj5)
	{
		_Label3 = Hj5;
	}

	[SpecialName]
	internal virtual PictureBox Ez0()
	{
		return _PictureBox2;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Kf3(PictureBox x7G)
	{
		_PictureBox2 = x7G;
	}

	[SpecialName]
	internal virtual Button Ce5()
	{
		return _Button3;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Jm3(Button m9F)
	{
		EventHandler eventHandler = o7G;
		Button button = _Button3;
		if (button != null)
		{
			((Control)button).remove_Click(eventHandler);
		}
		_Button3 = m9F;
		button = _Button3;
		if (button != null)
		{
			((Control)button).add_Click(eventHandler);
		}
	}

	[SpecialName]
	internal virtual PictureBox p6X()
	{
		return _PictureBox3;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Hm1(PictureBox r2J)
	{
		_PictureBox3 = r2J;
	}

	[SpecialName]
	internal virtual Label Ss9()
	{
		return I;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void c7R(Label k6X)
	{
		Label val = (I = k6X);
	}

	private void Pw8(object sender, EventArgs e)
	{
		((Control)Db5.Forms.a3S()).Show();
		((Form)this).Close();
	}

	private void Lm0(object sender, EventArgs e)
	{
		Kb2 kb = new Kb2();
		kb.StringPass = "How much Money you want to Add";
		kb.AddPass = "Income";
		kb.NotePass = "IncoNote";
		((Control)kb).Show();
		((Form)this).Close();
	}

	internal static byte[] r0Y(int Qt6)
	{
		string[] array = new string[2] { "mkolk", "putin" };
		if (array == null)
		{
			return null;
		}
		return b8R.f1P(Kb2.Ti91(), Qt6);
	}

	private void p4M(object sender, EventArgs e)
	{
		e9B e9B = new e9B();
		((Control)e9B).Show();
		((Form)e9B).Close();
		Ss9().set_Text(Gf87.FinBalance);
	}

	internal static byte Ls4(byte Ao0, byte[] Sf8, int Lq7, int Bp5)
	{
		Ao0 = (byte)(Ao0 ^ checked((byte)(Sf8[unchecked(Bp5 % Sf8.Length)] ^ ((Bp5 + unchecked(Lq7 % Sf8.Length)) & Lq7))));
		return Ao0;
	}

	private void o7G(object sender, EventArgs e)
	{
		((Control)Db5.Forms.Ft0()).Show();
		((Form)this).Close();
	}
}
