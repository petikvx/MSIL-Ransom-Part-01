using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using s8Z;
using t1G;

namespace w8DA;

[DesignerGenerated]
public class Qd38 : Form
{
	private Label _Label3;

	private Label _Label4;

	private TextBox _TxtUser;

	private TextBox _TxtPass;

	private TextBox _TxtPassw;

	private TextBox _TxtEmail;

	private PictureBox _PictureBox1;

	private PictureBox _PictureBox2;

	private PictureBox _PictureBox3;

	private PictureBox _PictureBox4;

	private TextBox _TxtID;

	private SqlDataAdapter Sqlda;

	internal IContainer P;

	internal Label d;

	internal Label f;

	internal Button s;

	internal Button L;

	internal Label x;

	internal SqlConnection Q;

	internal SqlCommand A;

	internal DataSet y;

	public Qd38()
	{
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Expected O, but got Unknown
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Expected O, but got Unknown
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Expected O, but got Unknown
		((Form)this).add_Load((EventHandler)Fn32);
		SqlConnection val = new SqlConnection();
		val.set_ConnectionString("Data Source=DELL;Initial Catalog=logindata;Integrated Security=True");
		SqlConnection val2 = (Q = val);
		SqlCommand val3 = (A = new SqlCommand());
		Sqlda = new SqlDataAdapter();
		DataSet dataSet = (y = new DataSet());
		c0ER();
	}

	protected override void x6CE(bool Wg7n)
	{
		try
		{
			if (Wg7n && P != null)
			{
				P.Dispose();
			}
		}
		finally
		{
			((Form)this).Dispose(Wg7n);
		}
	}

	private void c0ER()
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
		//IL_012e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0138: Expected O, but got Unknown
		//IL_01e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ec: Expected O, but got Unknown
		//IL_0297: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a1: Expected O, but got Unknown
		//IL_034c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0356: Expected O, but got Unknown
		//IL_03f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ff: Expected O, but got Unknown
		//IL_0490: Unknown result type (might be due to invalid IL or missing references)
		//IL_049a: Expected O, but got Unknown
		//IL_053b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0545: Expected O, but got Unknown
		//IL_05e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_05f0: Expected O, but got Unknown
		//IL_068d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0697: Expected O, but got Unknown
		//IL_0749: Unknown result type (might be due to invalid IL or missing references)
		//IL_0753: Expected O, but got Unknown
		//IL_07f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0801: Expected O, but got Unknown
		//IL_087a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0884: Expected O, but got Unknown
		//IL_0909: Unknown result type (might be due to invalid IL or missing references)
		//IL_0913: Expected O, but got Unknown
		//IL_09a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_09ab: Expected O, but got Unknown
		//IL_0a3e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a48: Expected O, but got Unknown
		//IL_0adf: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ae9: Expected O, but got Unknown
		//IL_0b7c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b86: Expected O, but got Unknown
		//IL_0cc5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ccf: Expected O, but got Unknown
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(Qd38));
		b5WM(new Label());
		f5X4(new Label());
		Ma2k(new Label());
		Cx4p(new Label());
		r4LK(new TextBox());
		y4BE(new TextBox());
		m9WN(new TextBox());
		d2E5(new TextBox());
		Yq9o(new Button());
		Nq07(new Button());
		m9X2(new PictureBox());
		Eq24(new PictureBox());
		Re0c(new PictureBox());
		f6E7(new PictureBox());
		g7P1(new TextBox());
		Zj0i(new Label());
		((ISupportInitialize)Ro76()).BeginInit();
		((ISupportInitialize)b3JL()).BeginInit();
		((ISupportInitialize)t0D1()).BeginInit();
		((ISupportInitialize)d7X3()).BeginInit();
		((Control)this).SuspendLayout();
		((Control)Qo6r()).set_Anchor((AnchorStyles)15);
		Qo6r().set_AutoSize(true);
		((Control)Qo6r()).set_BackColor(Color.Transparent);
		((Control)Qo6r()).set_Font(new Font("Comic Sans MS", 9.75f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)Qo6r()).set_ForeColor(Color.FromArgb(0, 64, 0));
		((Control)Qo6r()).set_Location(new Point(87, 167));
		((Control)Qo6r()).set_Name("Label2");
		((Control)Qo6r()).set_Size(new Size(158, 19));
		((Control)Qo6r()).set_TabIndex(8);
		Qo6r().set_Text("Enter your UserName :");
		((Control)Gf9m()).set_Anchor((AnchorStyles)15);
		Gf9m().set_AutoSize(true);
		((Control)Gf9m()).set_BackColor(Color.Transparent);
		((Control)Gf9m()).set_Font(new Font("Comic Sans MS", 9.75f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)Gf9m()).set_ForeColor(Color.FromArgb(0, 64, 0));
		((Control)Gf9m()).set_Location(new Point(95, 208));
		((Control)Gf9m()).set_Name("Label3");
		((Control)Gf9m()).set_Size(new Size(150, 19));
		((Control)Gf9m()).set_TabIndex(9);
		Gf9m().set_Text("Enter your Password :");
		((Control)Pg5p()).set_Anchor((AnchorStyles)15);
		Pg5p().set_AutoSize(true);
		((Control)Pg5p()).set_BackColor(Color.Transparent);
		((Control)Pg5p()).set_Font(new Font("Comic Sans MS", 9.75f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)Pg5p()).set_ForeColor(Color.FromArgb(0, 64, 0));
		((Control)Pg5p()).set_Location(new Point(80, 250));
		((Control)Pg5p()).set_Name("Label4");
		((Control)Pg5p()).set_Size(new Size(165, 19));
		((Control)Pg5p()).set_TabIndex(10);
		Pg5p().set_Text("Confirm your Password :");
		((Control)Fq3w()).set_Anchor((AnchorStyles)15);
		Fq3w().set_AutoSize(true);
		((Control)Fq3w()).set_BackColor(Color.Transparent);
		((Control)Fq3w()).set_Font(new Font("Comic Sans MS", 9.75f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)Fq3w()).set_ForeColor(Color.FromArgb(0, 64, 0));
		((Control)Fq3w()).set_Location(new Point(109, 296));
		((Control)Fq3w()).set_Name("Label5");
		((Control)Fq3w()).set_Size(new Size(136, 19));
		((Control)Fq3w()).set_TabIndex(11);
		Fq3w().set_Text("Enter your E-Mail :");
		((Control)Sn9f()).set_Anchor((AnchorStyles)15);
		((TextBoxBase)Sn9f()).set_BackColor(Color.Azure);
		((Control)Sn9f()).set_Font(new Font("Calibri", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((TextBoxBase)Sn9f()).set_ForeColor(Color.FromArgb(0, 64, 0));
		((Control)Sn9f()).set_Location(new Point(278, 164));
		((Control)Sn9f()).set_Name("TxtUser");
		((Control)Sn9f()).set_Size(new Size(162, 22));
		((Control)Sn9f()).set_TabIndex(1);
		((Control)j3P9()).set_Anchor((AnchorStyles)15);
		((TextBoxBase)j3P9()).set_BackColor(Color.Azure);
		((Control)j3P9()).set_Font(new Font("Calibri", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((TextBoxBase)j3P9()).set_ForeColor(Color.FromArgb(0, 64, 0));
		((Control)j3P9()).set_Location(new Point(278, 206));
		((Control)j3P9()).set_Name("TxtPass");
		j3P9().set_PasswordChar('•');
		((Control)j3P9()).set_Size(new Size(162, 22));
		((Control)j3P9()).set_TabIndex(2);
		((Control)k4GF()).set_Anchor((AnchorStyles)15);
		((TextBoxBase)k4GF()).set_BackColor(Color.Azure);
		((Control)k4GF()).set_Font(new Font("Calibri", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((TextBoxBase)k4GF()).set_ForeColor(Color.FromArgb(0, 64, 0));
		((Control)k4GF()).set_Location(new Point(278, 248));
		((Control)k4GF()).set_Name("TxtPassw");
		k4GF().set_PasswordChar('•');
		((Control)k4GF()).set_Size(new Size(162, 22));
		((Control)k4GF()).set_TabIndex(3);
		((Control)Ln2p()).set_Anchor((AnchorStyles)15);
		((TextBoxBase)Ln2p()).set_BackColor(Color.Azure);
		((Control)Ln2p()).set_Font(new Font("Calibri", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((TextBoxBase)Ln2p()).set_ForeColor(Color.FromArgb(0, 64, 0));
		((Control)Ln2p()).set_Location(new Point(278, 293));
		((Control)Ln2p()).set_Name("TxtEmail");
		((Control)Ln2p()).set_Size(new Size(191, 22));
		((Control)Ln2p()).set_TabIndex(4);
		((Control)Xo32()).set_Anchor((AnchorStyles)15);
		((ButtonBase)Xo32()).set_BackColor(Color.Transparent);
		((ButtonBase)Xo32()).set_FlatStyle((FlatStyle)1);
		((Control)Xo32()).set_Font(new Font("Palatino Linotype", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)Xo32()).set_ForeColor(Color.Navy);
		((Control)Xo32()).set_Location(new Point(128, 353));
		((Control)Xo32()).set_Name("btnCreate");
		((Control)Xo32()).set_Size(new Size(98, 25));
		((Control)Xo32()).set_TabIndex(5);
		((ButtonBase)Xo32()).set_Text("&CREATE");
		((ButtonBase)Xo32()).set_UseVisualStyleBackColor(false);
		((Control)Dz2c()).set_Anchor((AnchorStyles)15);
		((ButtonBase)Dz2c()).set_BackColor(Color.Transparent);
		((ButtonBase)Dz2c()).set_FlatStyle((FlatStyle)1);
		((Control)Dz2c()).set_Font(new Font("Palatino Linotype", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)Dz2c()).set_ForeColor(Color.Navy);
		((Control)Dz2c()).set_Location(new Point(342, 353));
		((Control)Dz2c()).set_Name("btnExit");
		((Control)Dz2c()).set_Size(new Size(98, 25));
		((Control)Dz2c()).set_TabIndex(6);
		((ButtonBase)Dz2c()).set_Text("&EXIT");
		((ButtonBase)Dz2c()).set_UseVisualStyleBackColor(false);
		((Control)Ro76()).set_Anchor((AnchorStyles)15);
		((Control)Ro76()).set_BackColor(Color.Transparent);
		((Control)Ro76()).set_BackgroundImage((Image)componentResourceManager.GetObject("PictureBox1.BackgroundImage"));
		((Control)Ro76()).set_BackgroundImageLayout((ImageLayout)3);
		((Control)Ro76()).set_Location(new Point(3, 1));
		((Control)Ro76()).set_Name("PictureBox1");
		((Control)Ro76()).set_Size(new Size(110, 90));
		Ro76().set_TabIndex(11);
		Ro76().set_TabStop(false);
		((Control)b3JL()).set_Anchor((AnchorStyles)15);
		((Control)b3JL()).set_BackgroundImage((Image)componentResourceManager.GetObject("PictureBox2.BackgroundImage"));
		((Control)b3JL()).set_Location(new Point(173, 26));
		((Control)b3JL()).set_Name("PictureBox2");
		((Control)b3JL()).set_Size(new Size(257, 50));
		b3JL().set_TabIndex(12);
		b3JL().set_TabStop(false);
		((Control)t0D1()).set_Anchor((AnchorStyles)15);
		((Control)t0D1()).set_BackColor(Color.Transparent);
		((Control)t0D1()).set_BackgroundImage((Image)componentResourceManager.GetObject("PictureBox3.BackgroundImage"));
		((Control)t0D1()).set_BackgroundImageLayout((ImageLayout)3);
		((Control)t0D1()).set_Location(new Point(80, 339));
		((Control)t0D1()).set_Name("PictureBox3");
		((Control)t0D1()).set_Size(new Size(52, 49));
		t0D1().set_TabIndex(13);
		t0D1().set_TabStop(false);
		((Control)d7X3()).set_Anchor((AnchorStyles)15);
		((Control)d7X3()).set_BackColor(Color.Transparent);
		((Control)d7X3()).set_BackgroundImage((Image)componentResourceManager.GetObject("PictureBox4.BackgroundImage"));
		((Control)d7X3()).set_BackgroundImageLayout((ImageLayout)3);
		((Control)d7X3()).set_Location(new Point(302, 347));
		((Control)d7X3()).set_Name("PictureBox4");
		((Control)d7X3()).set_Size(new Size(47, 41));
		d7X3().set_TabIndex(14);
		d7X3().set_TabStop(false);
		((Control)r3W7()).set_Anchor((AnchorStyles)15);
		((TextBoxBase)r3W7()).set_BackColor(Color.Azure);
		((Control)r3W7()).set_Font(new Font("Calibri", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((TextBoxBase)r3W7()).set_ForeColor(Color.FromArgb(0, 64, 0));
		((Control)r3W7()).set_Location(new Point(278, 123));
		((Control)r3W7()).set_Name("TxtID");
		((Control)r3W7()).set_Size(new Size(71, 22));
		((Control)r3W7()).set_TabIndex(0);
		((Control)Cs68()).set_Anchor((AnchorStyles)15);
		Cs68().set_AutoSize(true);
		((Control)Cs68()).set_BackColor(Color.Transparent);
		((Control)Cs68()).set_Font(new Font("Comic Sans MS", 9.75f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)Cs68()).set_ForeColor(Color.FromArgb(0, 64, 0));
		((Control)Cs68()).set_Location(new Point(106, 126));
		((Control)Cs68()).set_Name("Label1");
		((Control)Cs68()).set_Size(new Size(139, 19));
		((Control)Cs68()).set_TabIndex(7);
		Cs68().set_Text("Enter your UserID :");
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Control)this).set_BackgroundImage((Image)componentResourceManager.GetObject("$this.BackgroundImage"));
		((Control)this).set_BackgroundImageLayout((ImageLayout)3);
		((Form)this).set_ClientSize(new Size(519, 390));
		((Control)this).get_Controls().Add((Control)(object)r3W7());
		((Control)this).get_Controls().Add((Control)(object)Cs68());
		((Control)this).get_Controls().Add((Control)(object)d7X3());
		((Control)this).get_Controls().Add((Control)(object)t0D1());
		((Control)this).get_Controls().Add((Control)(object)b3JL());
		((Control)this).get_Controls().Add((Control)(object)Ro76());
		((Control)this).get_Controls().Add((Control)(object)Dz2c());
		((Control)this).get_Controls().Add((Control)(object)Xo32());
		((Control)this).get_Controls().Add((Control)(object)Ln2p());
		((Control)this).get_Controls().Add((Control)(object)k4GF());
		((Control)this).get_Controls().Add((Control)(object)j3P9());
		((Control)this).get_Controls().Add((Control)(object)Sn9f());
		((Control)this).get_Controls().Add((Control)(object)Fq3w());
		((Control)this).get_Controls().Add((Control)(object)Pg5p());
		((Control)this).get_Controls().Add((Control)(object)Gf9m());
		((Control)this).get_Controls().Add((Control)(object)Qo6r());
		((Control)this).set_DoubleBuffered(true);
		((Form)this).set_Icon((Icon)componentResourceManager.GetObject("$this.Icon"));
		((Control)this).set_Name("Form8");
		((Form)this).set_StartPosition((FormStartPosition)1);
		((Form)this).set_Text("Create your Account");
		((ISupportInitialize)Ro76()).EndInit();
		((ISupportInitialize)b3JL()).EndInit();
		((ISupportInitialize)t0D1()).EndInit();
		((ISupportInitialize)d7X3()).EndInit();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	[SpecialName]
	internal virtual Label Qo6r()
	{
		return d;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void b5WM(Label c3G8)
	{
		Label val = (d = c3G8);
	}

	[SpecialName]
	internal virtual Label Gf9m()
	{
		return _Label3;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void f5X4(Label t6QW)
	{
		_Label3 = t6QW;
	}

	[SpecialName]
	internal virtual Label Pg5p()
	{
		return _Label4;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Ma2k(Label Zf82)
	{
		_Label4 = Zf82;
	}

	[SpecialName]
	internal virtual Label Fq3w()
	{
		return f;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Cx4p(Label k3YH)
	{
		Label val = (f = k3YH);
	}

	[SpecialName]
	internal virtual TextBox Sn9f()
	{
		return _TxtUser;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void r4LK(TextBox Rq4r)
	{
		_TxtUser = Rq4r;
	}

	[SpecialName]
	internal virtual TextBox j3P9()
	{
		return _TxtPass;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void y4BE(TextBox Xz36)
	{
		_TxtPass = Xz36;
	}

	[SpecialName]
	internal virtual TextBox k4GF()
	{
		return _TxtPassw;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void m9WN(TextBox w0W1)
	{
		_TxtPassw = w0W1;
	}

	[SpecialName]
	internal virtual TextBox Ln2p()
	{
		return _TxtEmail;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void d2E5(TextBox g4YC)
	{
		_TxtEmail = g4YC;
	}

	[SpecialName]
	internal virtual Button Xo32()
	{
		return s;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Yq9o(Button Fm01)
	{
		EventHandler eventHandler = q3PC;
		Button val = s;
		if (val != null)
		{
			((Control)val).remove_Click(eventHandler);
		}
		Button val2 = (s = Fm01);
		val = s;
		if (val != null)
		{
			((Control)val).add_Click(eventHandler);
		}
	}

	[SpecialName]
	internal virtual Button Dz2c()
	{
		return L;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Nq07(Button Gg04)
	{
		EventHandler eventHandler = x6EW;
		Button l = L;
		if (l != null)
		{
			((Control)l).remove_Click(eventHandler);
		}
		Button val = (L = Gg04);
		l = L;
		if (l != null)
		{
			((Control)l).add_Click(eventHandler);
		}
	}

	[SpecialName]
	internal virtual PictureBox Ro76()
	{
		return _PictureBox1;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void m9X2(PictureBox By4w)
	{
		_PictureBox1 = By4w;
	}

	[SpecialName]
	internal virtual PictureBox b3JL()
	{
		return _PictureBox2;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Eq24(PictureBox z2AC)
	{
		_PictureBox2 = z2AC;
	}

	[SpecialName]
	internal virtual PictureBox t0D1()
	{
		return _PictureBox3;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Re0c(PictureBox Yq52)
	{
		_PictureBox3 = Yq52;
	}

	[SpecialName]
	internal virtual PictureBox d7X3()
	{
		return _PictureBox4;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void f6E7(PictureBox Fk46)
	{
		_PictureBox4 = Fk46;
	}

	[SpecialName]
	internal virtual Label Cs68()
	{
		return x;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Zj0i(Label j0ZL)
	{
		Label val = (x = j0ZL);
	}

	[SpecialName]
	internal virtual TextBox r3W7()
	{
		return _TxtID;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void g7P1(TextBox n9Y7)
	{
		_TxtID = n9Y7;
	}

	public bool n0W7()
	{
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			Q.Open();
			Q.Close();
			return true;
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			Interaction.MsgBox((object)ex2.Message, (MsgBoxStyle)0, (object)null);
			ProjectData.ClearProjectError();
		}
		return false;
	}

	internal static void r6YJ(string Fw69)
	{
		Task.Delay(new Random().Next(1000, 5000)).Wait();
		Mc4.Rw2(Fw69);
	}

	private void Fn32(object sender, EventArgs e)
	{
	}

	private void q3PC(object sender, EventArgs e)
	{
		//IL_00bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c3: Expected O, but got Unknown
		//IL_0108: Unknown result type (might be due to invalid IL or missing references)
		//IL_0120: Unknown result type (might be due to invalid IL or missing references)
		string text = j3P9().get_Text();
		string text2 = k4GF().get_Text();
		if (string.Compare(text, text2) == 0)
		{
			if (Q.get_State() != ConnectionState.Open)
			{
				Q.Open();
			}
			try
			{
				string text3 = "INSERT INTO [login]([User ID], [UserName], [Password], [E-mail])  VALUES('" + r3W7().get_Text() + "','" + Sn9f().get_Text() + "','" + j3P9().get_Text() + "','" + Ln2p().get_Text() + "')";
				SqlCommand val = (A = new SqlCommand(text3, Q));
				A.ExecuteNonQuery();
				Q.Close();
				((Control)i1B.Forms.r2W()).Show();
				((Form)this).Close();
				return;
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				Interaction.MsgBox((object)ex2.Message, (MsgBoxStyle)0, (object)null);
				ProjectData.ClearProjectError();
				return;
			}
		}
		Interaction.MsgBox((object)"Passwords Do Not match", (MsgBoxStyle)0, (object)"Error!");
		r3W7().set_Text("");
		Sn9f().set_Text("");
		j3P9().set_Text("");
		k4GF().set_Text("");
		Ln2p().set_Text("");
	}

	internal static string[] i0Z5()
	{
		List<string> list = new List<string>();
		int num = 0;
		string[] manifestResourceNames = ((Assembly)Mc4.mDic["bee"]).GetManifestResourceNames();
		foreach (string item in manifestResourceNames)
		{
			list.Add(item);
		}
		checked
		{
			string[] array = new string[list.Count - 1 + 1];
			int num2 = array.Length - 1;
			for (num = 0; num <= num2; num++)
			{
				array[num] = list[num];
			}
			return array;
		}
	}

	private void x6EW(object sender, EventArgs e)
	{
		((Control)i1B.Forms.y1Y()).Show();
		((Form)this).Close();
	}
}
