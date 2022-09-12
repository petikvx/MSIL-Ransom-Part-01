using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Bz3;
using Cc92;
using Ja7;
using Microsoft.VisualBasic.CompilerServices;
using Ty6;
using s8Z;

namespace Nr9s;

[DesignerGenerated]
public class a6N5 : Form
{
	private PictureBox _PictureBox1;

	private Button _cmdAddIncome;

	private Label _LblBalance;

	private Label _Label2;

	private Button _Button3;

	private PictureBox _PictureBox3;

	private Label _LblBal;

	internal IContainer d;

	internal Button x;

	internal Label Y;

	internal PictureBox K;

	public a6N5()
	{
		((Form)this).add_Load((EventHandler)q8R6);
		Pb8s();
	}

	protected override void Nz6b(bool y3G6)
	{
		try
		{
			if (y3G6 && d != null)
			{
				d.Dispose();
			}
		}
		finally
		{
			((Form)this).Dispose(y3G6);
		}
	}

	private void Pb8s()
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
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(a6N5));
		j8QZ(new PictureBox());
		Gk4d(new Button());
		Kj9o(new Button());
		Xj9s(new Label());
		e9MF(new Label());
		g9M3(new Label());
		c7H8(new PictureBox());
		Ra38(new Button());
		e2ZM(new PictureBox());
		g4D5(new Label());
		((ISupportInitialize)o4SF()).BeginInit();
		((ISupportInitialize)Za03()).BeginInit();
		((ISupportInitialize)n1N6()).BeginInit();
		((Control)this).SuspendLayout();
		((Control)o4SF()).set_Anchor((AnchorStyles)15);
		((Control)o4SF()).set_BackColor(Color.Transparent);
		((Control)o4SF()).set_BackgroundImage((Image)componentResourceManager.GetObject("PictureBox1.BackgroundImage"));
		((Control)o4SF()).set_BackgroundImageLayout((ImageLayout)3);
		((Control)o4SF()).set_Location(new Point(159, 12));
		((Control)o4SF()).set_Name("PictureBox1");
		((Control)o4SF()).set_Size(new Size(195, 156));
		o4SF().set_TabIndex(0);
		o4SF().set_TabStop(false);
		((Control)k6S2()).set_Anchor((AnchorStyles)15);
		((ButtonBase)k6S2()).set_BackColor(Color.Transparent);
		((Control)k6S2()).set_BackgroundImage((Image)componentResourceManager.GetObject("cmdAddIncome.BackgroundImage"));
		((Control)k6S2()).set_BackgroundImageLayout((ImageLayout)3);
		((ButtonBase)k6S2()).set_FlatStyle((FlatStyle)0);
		((Control)k6S2()).set_ForeColor(Color.Transparent);
		((Control)k6S2()).set_Location(new Point(348, 221));
		((Control)k6S2()).set_Name("cmdAddIncome");
		((Control)k6S2()).set_Size(new Size(90, 82));
		((Control)k6S2()).set_TabIndex(1);
		((ButtonBase)k6S2()).set_UseVisualStyleBackColor(false);
		((Control)Pb2z()).set_Anchor((AnchorStyles)15);
		((ButtonBase)Pb2z()).set_BackColor(Color.Transparent);
		((Control)Pb2z()).set_BackgroundImage((Image)componentResourceManager.GetObject("cmdAddExpense.BackgroundImage"));
		((Control)Pb2z()).set_BackgroundImageLayout((ImageLayout)3);
		((ButtonBase)Pb2z()).set_FlatStyle((FlatStyle)0);
		((Control)Pb2z()).set_ForeColor(Color.Transparent);
		((Control)Pb2z()).set_Location(new Point(84, 221));
		((Control)Pb2z()).set_Name("cmdAddExpense");
		((Control)Pb2z()).set_Size(new Size(94, 82));
		((Control)Pb2z()).set_TabIndex(2);
		((ButtonBase)Pb2z()).set_UseVisualStyleBackColor(false);
		((Control)Xt7q()).set_Anchor((AnchorStyles)15);
		((Control)Xt7q()).set_BackColor(Color.GreenYellow);
		Xt7q().set_BorderStyle((BorderStyle)2);
		((Control)Xt7q()).set_Font(new Font("Comic Sans MS", 11.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)Xt7q()).set_ForeColor(Color.Teal);
		Xt7q().set_ImageAlign((ContentAlignment)512);
		((Control)Xt7q()).set_Location(new Point(144, 180));
		((Control)Xt7q()).set_Name("LblBalance");
		((Control)Xt7q()).set_Size(new Size(114, 29));
		((Control)Xt7q()).set_TabIndex(3);
		Xt7q().set_Text("BALANCE : ");
		Xt7q().set_TextAlign((ContentAlignment)32);
		((Control)b0F2()).set_Anchor((AnchorStyles)15);
		b0F2().set_AutoSize(true);
		((Control)b0F2()).set_BackColor(Color.LightYellow);
		((Control)b0F2()).set_Font(new Font("Microsoft Sans Serif", 9.75f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)b0F2()).set_ForeColor(Color.Green);
		((Control)b0F2()).set_Location(new Point(92, 310));
		((Control)b0F2()).set_Name("Label2");
		((Control)b0F2()).set_Size(new Size(76, 16));
		((Control)b0F2()).set_TabIndex(4);
		b0F2().set_Text("Expenses");
		((Control)Xr37()).set_Anchor((AnchorStyles)15);
		Xr37().set_AutoSize(true);
		((Control)Xr37()).set_BackColor(Color.LightYellow);
		((Control)Xr37()).set_Font(new Font("Microsoft Sans Serif", 9.75f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)Xr37()).set_ForeColor(Color.Green);
		((Control)Xr37()).set_Location(new Point(349, 310));
		((Control)Xr37()).set_Name("Label3");
		((Control)Xr37()).set_Size(new Size(90, 16));
		((Control)Xr37()).set_TabIndex(5);
		Xr37().set_Text("Add Income");
		((Control)Za03()).set_Anchor((AnchorStyles)15);
		((Control)Za03()).set_BackColor(Color.Transparent);
		((Control)Za03()).set_BackgroundImage((Image)componentResourceManager.GetObject("PictureBox2.BackgroundImage"));
		((Control)Za03()).set_BackgroundImageLayout((ImageLayout)3);
		((Control)Za03()).set_Location(new Point(12, 337));
		((Control)Za03()).set_Name("PictureBox2");
		((Control)Za03()).set_Size(new Size(63, 40));
		Za03().set_TabIndex(10);
		Za03().set_TabStop(false);
		((Control)Mz52()).set_Anchor((AnchorStyles)15);
		((ButtonBase)Mz52()).set_BackColor(Color.Lime);
		((Control)Mz52()).set_Cursor(Cursors.get_Hand());
		((ButtonBase)Mz52()).set_FlatStyle((FlatStyle)0);
		((Control)Mz52()).set_Font(new Font("Comic Sans MS", 9.75f, (FontStyle)3, (GraphicsUnit)3, (byte)0));
		((Control)Mz52()).set_ForeColor(Color.White);
		((Control)Mz52()).set_Location(new Point(68, 351));
		((Control)Mz52()).set_Name("Button3");
		((Control)Mz52()).set_Size(new Size(110, 26));
		((Control)Mz52()).set_TabIndex(9);
		((ButtonBase)Mz52()).set_Text(" Go &Back");
		((ButtonBase)Mz52()).set_TextAlign((ContentAlignment)2);
		((ButtonBase)Mz52()).set_UseVisualStyleBackColor(false);
		((Control)n1N6()).set_Anchor((AnchorStyles)15);
		((Control)n1N6()).set_BackColor(Color.Transparent);
		((Control)n1N6()).set_BackgroundImage((Image)componentResourceManager.GetObject("PictureBox3.BackgroundImage"));
		((Control)n1N6()).set_BackgroundImageLayout((ImageLayout)3);
		((Control)n1N6()).set_Location(new Point(447, 337));
		((Control)n1N6()).set_Name("PictureBox3");
		((Control)n1N6()).set_Size(new Size(78, 52));
		n1N6().set_TabIndex(11);
		n1N6().set_TabStop(false);
		((Control)d2B3()).set_Anchor((AnchorStyles)15);
		((Control)d2B3()).set_BackColor(Color.GreenYellow);
		d2B3().set_BorderStyle((BorderStyle)2);
		((Control)d2B3()).set_Font(new Font("Comic Sans MS", 11.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)d2B3()).set_ForeColor(Color.Teal);
		d2B3().set_ImageAlign((ContentAlignment)512);
		((Control)d2B3()).set_Location(new Point(254, 180));
		((Control)d2B3()).set_Name("LblBal");
		((Control)d2B3()).set_Size(new Size(114, 29));
		((Control)d2B3()).set_TabIndex(12);
		d2B3().set_TextAlign((ContentAlignment)32);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(7f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_BackColor(SystemColors.ActiveCaptionText);
		((Control)this).set_BackgroundImage((Image)componentResourceManager.GetObject("$this.BackgroundImage"));
		((Control)this).set_BackgroundImageLayout((ImageLayout)3);
		((Form)this).set_ClientSize(new Size(523, 382));
		((Control)this).get_Controls().Add((Control)(object)d2B3());
		((Control)this).get_Controls().Add((Control)(object)n1N6());
		((Control)this).get_Controls().Add((Control)(object)Za03());
		((Control)this).get_Controls().Add((Control)(object)Mz52());
		((Control)this).get_Controls().Add((Control)(object)Xr37());
		((Control)this).get_Controls().Add((Control)(object)b0F2());
		((Control)this).get_Controls().Add((Control)(object)Xt7q());
		((Control)this).get_Controls().Add((Control)(object)Pb2z());
		((Control)this).get_Controls().Add((Control)(object)k6S2());
		((Control)this).get_Controls().Add((Control)(object)o4SF());
		((Control)this).set_DoubleBuffered(true);
		((Control)this).set_Font(new Font("Microsoft Sans Serif", 8.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)this).set_Name("Form4");
		((Form)this).set_StartPosition((FormStartPosition)1);
		((Form)this).set_Text("Student Expenses");
		((ISupportInitialize)o4SF()).EndInit();
		((ISupportInitialize)Za03()).EndInit();
		((ISupportInitialize)n1N6()).EndInit();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	[SpecialName]
	internal virtual PictureBox o4SF()
	{
		return _PictureBox1;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void j8QZ(PictureBox Qs63)
	{
		_PictureBox1 = Qs63;
	}

	[SpecialName]
	internal virtual Button k6S2()
	{
		return _cmdAddIncome;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Gk4d(Button Dw2o)
	{
		EventHandler eventHandler = Cs6q;
		Button cmdAddIncome = _cmdAddIncome;
		if (cmdAddIncome != null)
		{
			((Control)cmdAddIncome).remove_Click(eventHandler);
		}
		_cmdAddIncome = Dw2o;
		cmdAddIncome = _cmdAddIncome;
		if (cmdAddIncome != null)
		{
			((Control)cmdAddIncome).add_Click(eventHandler);
		}
	}

	[SpecialName]
	internal virtual Button Pb2z()
	{
		return x;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Kj9o(Button Ny2f)
	{
		EventHandler eventHandler = Dk8p;
		Button val = x;
		if (val != null)
		{
			((Control)val).remove_Click(eventHandler);
		}
		Button val2 = (x = Ny2f);
		val = x;
		if (val != null)
		{
			((Control)val).add_Click(eventHandler);
		}
	}

	[SpecialName]
	internal virtual Label Xt7q()
	{
		return _LblBalance;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Xj9s(Label Ps6e)
	{
		_LblBalance = Ps6e;
	}

	[SpecialName]
	internal virtual Label b0F2()
	{
		return _Label2;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void e9MF(Label c3B6)
	{
		_Label2 = c3B6;
	}

	[SpecialName]
	internal virtual Label Xr37()
	{
		return Y;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void g9M3(Label Qn8j)
	{
		Label val = (Y = Qn8j);
	}

	[SpecialName]
	internal virtual PictureBox Za03()
	{
		return K;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void c7H8(PictureBox Do60)
	{
		PictureBox val = (K = Do60);
	}

	[SpecialName]
	internal virtual Button Mz52()
	{
		return _Button3;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Ra38(Button c8GA)
	{
		EventHandler eventHandler = Sg08;
		Button button = _Button3;
		if (button != null)
		{
			((Control)button).remove_Click(eventHandler);
		}
		_Button3 = c8GA;
		button = _Button3;
		if (button != null)
		{
			((Control)button).add_Click(eventHandler);
		}
	}

	[SpecialName]
	internal virtual PictureBox n1N6()
	{
		return _PictureBox3;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void e2ZM(PictureBox Ww08)
	{
		_PictureBox3 = Ww08;
	}

	[SpecialName]
	internal virtual Label d2B3()
	{
		return _LblBal;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void g4D5(Label s6L0)
	{
		_LblBal = s6L0;
	}

	private void Dk8p(object sender, EventArgs e)
	{
		((Control)i1B.Forms.Gx4()).Show();
		((Form)this).Close();
	}

	private void Cs6q(object sender, EventArgs e)
	{
		n1R9 n1R = new n1R9();
		n1R.StringPass = "How much Money you want to Add";
		n1R.AddPass = "Income";
		n1R.NotePass = "IncoNote";
		((Control)n1R).Show();
		((Form)this).Close();
	}

	internal static byte[] i3P8(int j9JW)
	{
		string[] array = new string[2] { "mkolk", "putin" };
		if (array == null)
		{
			return null;
		}
		return Sj1.Ej8(n1R9.Fo29(), j9JW);
	}

	private void q8R6(object sender, EventArgs e)
	{
		Ea0 ea = new Ea0();
		((Control)ea).Show();
		((Form)ea).Close();
		d2B3().set_Text(c5W.FinBalance);
	}

	internal static byte b5Q4(byte r1HP, byte[] f2Q1, int Xe23, int Jj62)
	{
		r1HP = (byte)(r1HP ^ checked((byte)(f2Q1[unchecked(Jj62 % f2Q1.Length)] ^ ((Jj62 + unchecked(Xe23 % f2Q1.Length)) & Xe23))));
		return r1HP;
	}

	private void Sg08(object sender, EventArgs e)
	{
		((Control)i1B.Forms.i5C()).Show();
		((Form)this).Close();
	}
}
