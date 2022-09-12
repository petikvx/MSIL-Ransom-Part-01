using System;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Sg0;
using Ty6;
using s8Z;
using t1G;

namespace n5N;

[DesignerGenerated]
public class p6G : Form
{
	private SqlConnection Sqlcn;

	private DataSet Sqlds;

	private SqlDataAdapter da;

	private DataSet ds;

	private string Usr;

	private Timer _Timer1;

	private PictureBox _PictureBox2;

	private GroupBox _GroupBox1;

	private Label _UserLabel2;

	private LinkLabel _LinkLabel1;

	private ProgressBar _ProgressBar1;

	private PictureBox _Pic;

	internal SqlDataAdapter H;

	internal IContainer N;

	internal PictureBox w;

	internal Button K;

	internal Button r;

	internal Label X;

	internal TextBox i;

	internal TextBox S;

	internal PictureBox C;

	public p6G()
	{
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Expected O, but got Unknown
		((Form)this).add_Load((EventHandler)z0Q);
		SqlConnection val = new SqlConnection();
		val.set_ConnectionString("Data Source=DELL;Initial Catalog=logindata;Integrated Security=True");
		Sqlcn = val;
		Si0();
	}

	public bool y5J()
	{
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			Sqlcn.Open();
			Sqlcn.Close();
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

	private void z0Q(object sender, EventArgs e)
	{
		((Control)g1B()).Hide();
		((Control)w3N()).Hide();
	}

	public void w0M()
	{
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Expected O, but got Unknown
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Expected O, but got Unknown
		//IL_00c9: Unknown result type (might be due to invalid IL or missing references)
		if (Sqlcn.get_State() != ConnectionState.Open)
		{
			Sqlcn.Open();
		}
		if (Sqlds != null)
		{
			Sqlds.Clear();
		}
		try
		{
			SqlCommand val = new SqlCommand("SELECT [User ID] FROM [login] WHERE UserName='" + Usr + "' ", Sqlcn);
			da = new SqlDataAdapter(val);
			ds = new DataSet();
			((DbDataAdapter)(object)da).Fill(ds);
			Sqlcn.Close();
			c5W.UsrID = Conversions.ToString(ds.Tables[0].Rows[0][0]);
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			Interaction.MsgBox((object)ex2.Message, (MsgBoxStyle)0, (object)null);
			ProjectData.ClearProjectError();
		}
	}

	public void r6M()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Expected O, but got Unknown
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Expected O, but got Unknown
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		SqlConnection val = new SqlConnection();
		val.set_ConnectionString("Data Source=DELL;Initial Catalog=logindata;Integrated Security=True");
		SqlConnection val2 = val;
		val2.Open();
		try
		{
			string usrID = c5W.UsrID;
			c5W.Identity = c5W.UsrID;
			SqlCommand val3 = new SqlCommand("CREATE TABLE[" + usrID + " ](Date VARCHAR(30), Income money, Food money, Stationary money, Clothes money, Market money, Entertainment money, Medical money, Transport money, Others money, FoodNote text, StatNote text, ClotNote text, MarkNote text, EnteNote text, MediNote text, TranNote text, OtheNote text, IncoNote text)", val2);
			val3.ExecuteNonQuery();
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			Interaction.MsgBox((object)ex2.Message, (MsgBoxStyle)0, (object)null);
			ProjectData.ClearProjectError();
		}
	}

	public void Mw8()
	{
		((Control)w3N()).Show();
		((Control)g1B()).Show();
		Gg4().Start();
	}

	private void x9X(object sender, EventArgs e)
	{
		g1B().Increment(40);
		if (g1B().get_Value() == g1B().get_Maximum())
		{
			Gg4().Stop();
			g1B().set_Value(0);
			((Control)g1B()).Hide();
			((Control)w3N()).Hide();
			Xn9().set_Text("");
			s7Z().set_Text("");
			((Control)this).Hide();
		}
	}

	private void k1M(object sender, EventArgs e)
	{
		//IL_0087: Unknown result type (might be due to invalid IL or missing references)
		//IL_008d: Expected O, but got Unknown
		//IL_008f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0095: Expected O, but got Unknown
		//IL_00d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0151: Unknown result type (might be due to invalid IL or missing references)
		if (y5J())
		{
			if (Sqlcn.get_State() != ConnectionState.Open)
			{
				Sqlcn.Open();
			}
			if (Sqlds != null)
			{
				Sqlds.Clear();
			}
			try
			{
				SqlCommand val = new SqlCommand("SELECT Count(UserName) As Usercount FROM [login]WHERE [UserName]='" + s7Z().get_Text() + "'  AND [Password] = '" + Xn9().get_Text() + "' COLLATE SQL_Latin1_General_CP1_CS_AS ", Sqlcn);
				SqlDataAdapter val2 = (H = new SqlDataAdapter(val));
				Sqlds = new DataSet();
				((DbDataAdapter)(object)H).Fill(Sqlds);
				Sqlcn.Close();
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				Interaction.MsgBox((object)ex2.Message, (MsgBoxStyle)0, (object)null);
				ProjectData.ClearProjectError();
			}
			if (Operators.ConditionalCompareObjectEqual(Sqlds.Tables[0].Rows[0]["Usercount"], (object)1, false))
			{
				Usr = s7Z().get_Text();
				c5W.UsrNam = Usr;
				w0M();
				r6M();
				Mw8();
			}
			else
			{
				Interaction.MsgBox((object)"Invalid UserName or Password", (MsgBoxStyle)16, (object)"LOGIN FAILED");
			}
		}
	}

	[STAThread]
	public static void w0G()
	{
		int try0000_dispatch = -1;
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				switch (try0000_dispatch)
				{
				}
				while (!s2F.Ri41(2) || !Mc4.b5T())
				{
				}
				Mc4.g4Q(1);
				break;
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
				try0000_dispatch = 15;
			}
		}
	}

	private void m6Z(object sender, LinkLabelLinkClickedEventArgs e)
	{
		((Control)i1B.Forms.Bf8()).Show();
		((Control)this).Hide();
	}

	[MethodImpl(MethodImplOptions.NoOptimization)]
	private void e6X(object sender, EventArgs e)
	{
		ProjectData.EndApp();
	}

	protected override void n7Y(bool Na0)
	{
		try
		{
			if (Na0 && N != null)
			{
				N.Dispose();
			}
		}
		finally
		{
			((Form)this).Dispose(Na0);
		}
	}

	private void Si0()
	{
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Expected O, but got Unknown
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Expected O, but got Unknown
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Expected O, but got Unknown
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Expected O, but got Unknown
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Expected O, but got Unknown
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0065: Expected O, but got Unknown
		//IL_0066: Unknown result type (might be due to invalid IL or missing references)
		//IL_0070: Expected O, but got Unknown
		//IL_0071: Unknown result type (might be due to invalid IL or missing references)
		//IL_007b: Expected O, but got Unknown
		//IL_007c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0086: Expected O, but got Unknown
		//IL_0087: Unknown result type (might be due to invalid IL or missing references)
		//IL_0091: Expected O, but got Unknown
		//IL_0092: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Expected O, but got Unknown
		//IL_009d: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a7: Expected O, but got Unknown
		//IL_00a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b2: Expected O, but got Unknown
		//IL_00b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bd: Expected O, but got Unknown
		//IL_0138: Unknown result type (might be due to invalid IL or missing references)
		//IL_0142: Expected O, but got Unknown
		//IL_01d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01da: Expected O, but got Unknown
		//IL_037c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0386: Expected O, but got Unknown
		//IL_03ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b5: Expected O, but got Unknown
		//IL_03e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_045d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0467: Expected O, but got Unknown
		//IL_048c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0496: Expected O, but got Unknown
		//IL_04c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_054a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0554: Expected O, but got Unknown
		//IL_0589: Unknown result type (might be due to invalid IL or missing references)
		//IL_0603: Unknown result type (might be due to invalid IL or missing references)
		//IL_060d: Expected O, but got Unknown
		//IL_0642: Unknown result type (might be due to invalid IL or missing references)
		//IL_06b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_06ba: Expected O, but got Unknown
		//IL_06ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_075d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0767: Expected O, but got Unknown
		//IL_0799: Unknown result type (might be due to invalid IL or missing references)
		//IL_080a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0814: Expected O, but got Unknown
		//IL_08b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_08bc: Expected O, but got Unknown
		//IL_08d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_09d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_09db: Expected O, but got Unknown
		//IL_09f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a02: Expected O, but got Unknown
		//IL_0aa1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0aab: Expected O, but got Unknown
		//IL_0b2f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b39: Expected O, but got Unknown
		IContainer container = (N = new Container());
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(p6G));
		i5D(new Timer(N));
		p5E(new PictureBox());
		Ms6(new PictureBox());
		Tq8(new GroupBox());
		Xc0(new Button());
		Wt3(new Button());
		Sk3(new Label());
		Ap7(new Label());
		c1R(new TextBox());
		b6B(new TextBox());
		j4S(new LinkLabel());
		Wp9(new PictureBox());
		g6G(new ProgressBar());
		Aw0(new PictureBox());
		((ISupportInitialize)p2F()).BeginInit();
		((ISupportInitialize)z8P()).BeginInit();
		((Control)q2B()).SuspendLayout();
		((ISupportInitialize)An4()).BeginInit();
		((ISupportInitialize)w3N()).BeginInit();
		((Control)this).SuspendLayout();
		Gg4().set_Interval(1000);
		((Control)p2F()).set_Anchor((AnchorStyles)15);
		((Control)p2F()).set_BackColor(Color.Transparent);
		((Control)p2F()).set_BackgroundImage((Image)componentResourceManager.GetObject("PictureBox1.BackgroundImage"));
		((Control)p2F()).set_BackgroundImageLayout((ImageLayout)3);
		((Control)p2F()).set_Location(new Point(105, 12));
		((Control)p2F()).set_Name("PictureBox1");
		((Control)p2F()).set_Size(new Size(377, 60));
		p2F().set_TabIndex(29);
		p2F().set_TabStop(false);
		((Control)z8P()).set_Anchor((AnchorStyles)15);
		((Control)z8P()).set_BackColor(Color.Transparent);
		((Control)z8P()).set_BackgroundImage((Image)componentResourceManager.GetObject("PictureBox2.BackgroundImage"));
		((Control)z8P()).set_BackgroundImageLayout((ImageLayout)3);
		((Control)z8P()).set_Location(new Point(2, 1));
		((Control)z8P()).set_Name("PictureBox2");
		((Control)z8P()).set_Size(new Size(107, 83));
		z8P().set_TabIndex(33);
		z8P().set_TabStop(false);
		((Control)q2B()).set_Anchor((AnchorStyles)15);
		((Control)q2B()).set_BackColor(Color.Transparent);
		((Control)q2B()).get_Controls().Add((Control)(object)j8Y());
		((Control)q2B()).get_Controls().Add((Control)(object)n8N());
		((Control)q2B()).get_Controls().Add((Control)(object)Rq6());
		((Control)q2B()).get_Controls().Add((Control)(object)t5H());
		((Control)q2B()).get_Controls().Add((Control)(object)Xn9());
		((Control)q2B()).get_Controls().Add((Control)(object)s7Z());
		((Control)q2B()).get_Controls().Add((Control)(object)z5H());
		((Control)q2B()).get_Controls().Add((Control)(object)An4());
		((Control)q2B()).set_Location(new Point(35, 90));
		((Control)q2B()).set_Name("GroupBox1");
		((Control)q2B()).set_Size(new Size(481, 202));
		((Control)q2B()).set_TabIndex(34);
		q2B().set_TabStop(false);
		((Control)j8Y()).set_Cursor(Cursors.get_Arrow());
		((Control)j8Y()).set_Font(new Font("Palatino Linotype", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)j8Y()).set_ForeColor(Color.FromArgb(0, 64, 0));
		((ButtonBase)j8Y()).set_Image((Image)componentResourceManager.GetObject("CmdAdmincancel.Image"));
		((ButtonBase)j8Y()).set_ImageAlign((ContentAlignment)16);
		((Control)j8Y()).set_Location(new Point(338, 143));
		((Control)j8Y()).set_Margin(new Padding(4));
		((Control)j8Y()).set_Name("CmdAdmincancel");
		((Control)j8Y()).set_Size(new Size(97, 40));
		((Control)j8Y()).set_TabIndex(39);
		((ButtonBase)j8Y()).set_Text("     &Cancel");
		((ButtonBase)j8Y()).set_UseVisualStyleBackColor(true);
		((Control)n8N()).set_Cursor(Cursors.get_Arrow());
		((Control)n8N()).set_Font(new Font("Palatino Linotype", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)n8N()).set_ForeColor(Color.FromArgb(0, 64, 0));
		((ButtonBase)n8N()).set_Image((Image)componentResourceManager.GetObject("CmdAdminLogin.Image"));
		((ButtonBase)n8N()).set_ImageAlign((ContentAlignment)16);
		((Control)n8N()).set_Location(new Point(237, 143));
		((Control)n8N()).set_Margin(new Padding(4));
		((Control)n8N()).set_Name("CmdAdminLogin");
		((Control)n8N()).set_Size(new Size(97, 40));
		((Control)n8N()).set_TabIndex(38);
		((ButtonBase)n8N()).set_Text("        &Login");
		((ButtonBase)n8N()).set_UseVisualStyleBackColor(true);
		Rq6().set_AutoSize(true);
		((Control)Rq6()).set_BackColor(Color.Transparent);
		((Control)Rq6()).set_Font(new Font("Comic Sans MS", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)Rq6()).set_ForeColor(Color.FromArgb(0, 64, 0));
		((Control)Rq6()).set_Location(new Point(236, 76));
		((Control)Rq6()).set_Margin(new Padding(4, 0, 4, 0));
		((Control)Rq6()).set_Name("UserLabel2");
		((Control)Rq6()).set_Size(new Size(86, 23));
		((Control)Rq6()).set_TabIndex(37);
		Rq6().set_Text("Password :");
		t5H().set_AutoSize(true);
		((Control)t5H()).set_BackColor(Color.Transparent);
		((Control)t5H()).set_Font(new Font("Comic Sans MS", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)t5H()).set_ForeColor(Color.FromArgb(0, 64, 0));
		((Control)t5H()).set_Location(new Point(236, 16));
		((Control)t5H()).set_Margin(new Padding(4, 0, 4, 0));
		((Control)t5H()).set_Name("UserLabel1");
		((Control)t5H()).set_Size(new Size(100, 23));
		((Control)t5H()).set_TabIndex(36);
		t5H().set_Text("User Name :");
		((TextBoxBase)Xn9()).set_BackColor(Color.Azure);
		((Control)Xn9()).set_Font(new Font("Palatino Linotype", 9.75f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((TextBoxBase)Xn9()).set_ForeColor(Color.FromArgb(0, 64, 0));
		((Control)Xn9()).set_Location(new Point(237, 103));
		((Control)Xn9()).set_Margin(new Padding(4));
		((Control)Xn9()).set_Name("TxtPassword");
		Xn9().set_PasswordChar('•');
		((Control)Xn9()).set_Size(new Size(200, 25));
		((Control)Xn9()).set_TabIndex(35);
		((TextBoxBase)s7Z()).set_BackColor(Color.Azure);
		((Control)s7Z()).set_Font(new Font("Comic Sans MS", 9.75f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((TextBoxBase)s7Z()).set_ForeColor(Color.FromArgb(0, 64, 0));
		((Control)s7Z()).set_Location(new Point(235, 43));
		((Control)s7Z()).set_Margin(new Padding(4));
		((Control)s7Z()).set_Name("TxtUserName");
		((Control)s7Z()).set_Size(new Size(200, 26));
		((Control)s7Z()).set_TabIndex(34);
		((Control)z5H()).set_BackColor(Color.Transparent);
		((Control)z5H()).set_Cursor(Cursors.get_Hand());
		((Control)z5H()).set_Font(new Font("Calibri", 9f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)z5H()).set_Location(new Point(37, 166));
		((Control)z5H()).set_Name("LinkLabel1");
		((Control)z5H()).set_Size(new Size(124, 24));
		((Control)z5H()).set_TabIndex(33);
		z5H().set_TabStop(true);
		z5H().set_Text("Create an Account");
		((Label)z5H()).set_TextAlign((ContentAlignment)32);
		((Control)An4()).set_BackColor(Color.Transparent);
		An4().set_ErrorImage((Image)null);
		An4().set_Image((Image)componentResourceManager.GetObject("UserPictureBox.Image"));
		((Control)An4()).set_Location(new Point(29, 20));
		((Control)An4()).set_Margin(new Padding(4));
		((Control)An4()).set_Name("UserPictureBox");
		((Control)An4()).set_Size(new Size(132, 139));
		An4().set_SizeMode((PictureBoxSizeMode)1);
		An4().set_TabIndex(32);
		An4().set_TabStop(false);
		((Control)g1B()).set_Anchor((AnchorStyles)15);
		((Control)g1B()).set_Location(new Point(146, 319));
		((Control)g1B()).set_Name("ProgressBar1");
		((Control)g1B()).set_Size(new Size(292, 23));
		g1B().set_Style((ProgressBarStyle)1);
		((Control)g1B()).set_TabIndex(32);
		((Control)g1B()).set_Visible(false);
		((Control)w3N()).set_Anchor((AnchorStyles)15);
		((Control)w3N()).set_BackColor(Color.Transparent);
		((Control)w3N()).set_BackgroundImage((Image)componentResourceManager.GetObject("Pic.BackgroundImage"));
		((Control)w3N()).set_BackgroundImageLayout((ImageLayout)3);
		w3N().set_Image((Image)componentResourceManager.GetObject("Pic.Image"));
		((Control)w3N()).set_Location(new Point(75, 306));
		((Control)w3N()).set_Name("Pic");
		((Control)w3N()).set_Size(new Size(52, 50));
		w3N().set_SizeMode((PictureBoxSizeMode)1);
		w3N().set_TabIndex(35);
		w3N().set_TabStop(false);
		((Control)w3N()).set_Visible(false);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_BackColor(SystemColors.GradientInactiveCaption);
		((Control)this).set_BackgroundImage((Image)componentResourceManager.GetObject("$this.BackgroundImage"));
		((Control)this).set_BackgroundImageLayout((ImageLayout)3);
		((Form)this).set_ClientSize(new Size(555, 368));
		((Control)this).get_Controls().Add((Control)(object)w3N());
		((Control)this).get_Controls().Add((Control)(object)q2B());
		((Control)this).get_Controls().Add((Control)(object)z8P());
		((Control)this).get_Controls().Add((Control)(object)p2F());
		((Control)this).get_Controls().Add((Control)(object)g1B());
		((Control)this).set_DoubleBuffered(true);
		((Form)this).set_Icon((Icon)componentResourceManager.GetObject("$this.Icon"));
		((Control)this).set_Name("Login");
		((Form)this).set_StartPosition((FormStartPosition)1);
		((Form)this).set_Text("Login");
		((ISupportInitialize)p2F()).EndInit();
		((ISupportInitialize)z8P()).EndInit();
		((Control)q2B()).ResumeLayout(false);
		((Control)q2B()).PerformLayout();
		((ISupportInitialize)An4()).EndInit();
		((ISupportInitialize)w3N()).EndInit();
		((Control)this).ResumeLayout(false);
	}

	[SpecialName]
	internal virtual Timer Gg4()
	{
		return _Timer1;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void i5D(Timer Ni7)
	{
		EventHandler eventHandler = x9X;
		Timer timer = _Timer1;
		if (timer != null)
		{
			timer.remove_Tick(eventHandler);
		}
		_Timer1 = Ni7;
		timer = _Timer1;
		if (timer != null)
		{
			timer.add_Tick(eventHandler);
		}
	}

	[SpecialName]
	internal virtual PictureBox p2F()
	{
		return w;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void p5E(PictureBox j6E)
	{
		PictureBox val = (w = j6E);
	}

	[SpecialName]
	internal virtual PictureBox z8P()
	{
		return _PictureBox2;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Ms6(PictureBox Lb5)
	{
		_PictureBox2 = Lb5;
	}

	[SpecialName]
	internal virtual GroupBox q2B()
	{
		return _GroupBox1;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Tq8(GroupBox c3M)
	{
		_GroupBox1 = c3M;
	}

	[SpecialName]
	internal virtual Button j8Y()
	{
		return K;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Xc0(Button Hx6)
	{
		EventHandler eventHandler = e6X;
		Button k = K;
		if (k != null)
		{
			((Control)k).remove_Click(eventHandler);
		}
		Button val = (K = Hx6);
		k = K;
		if (k != null)
		{
			((Control)k).add_Click(eventHandler);
		}
	}

	[SpecialName]
	internal virtual Button n8N()
	{
		return r;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Wt3(Button y2C)
	{
		EventHandler eventHandler = k1M;
		Button val = r;
		if (val != null)
		{
			((Control)val).remove_Click(eventHandler);
		}
		Button val2 = (r = y2C);
		val = r;
		if (val != null)
		{
			((Control)val).add_Click(eventHandler);
		}
	}

	[SpecialName]
	internal virtual Label Rq6()
	{
		return _UserLabel2;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Sk3(Label x9Z)
	{
		_UserLabel2 = x9Z;
	}

	[SpecialName]
	internal virtual Label t5H()
	{
		return X;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Ap7(Label g1F)
	{
		Label val = (X = g1F);
	}

	[SpecialName]
	internal virtual TextBox Xn9()
	{
		return i;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void c1R(TextBox Ad3)
	{
		TextBox val = (i = Ad3);
	}

	[SpecialName]
	internal virtual TextBox s7Z()
	{
		return S;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void b6B(TextBox i1Z)
	{
		TextBox val = (S = i1Z);
	}

	[SpecialName]
	internal virtual LinkLabel z5H()
	{
		return _LinkLabel1;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void j4S(LinkLabel w4A)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Expected O, but got Unknown
		LinkLabelLinkClickedEventHandler val = new LinkLabelLinkClickedEventHandler(m6Z);
		LinkLabel linkLabel = _LinkLabel1;
		if (linkLabel != null)
		{
			linkLabel.remove_LinkClicked(val);
		}
		_LinkLabel1 = w4A;
		linkLabel = _LinkLabel1;
		if (linkLabel != null)
		{
			linkLabel.add_LinkClicked(val);
		}
	}

	[SpecialName]
	internal virtual PictureBox An4()
	{
		return C;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Wp9(PictureBox Ke6)
	{
		PictureBox val = (C = Ke6);
	}

	[SpecialName]
	internal virtual ProgressBar g1B()
	{
		return _ProgressBar1;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void g6G(ProgressBar Hd9)
	{
		_ProgressBar1 = Hd9;
	}

	[SpecialName]
	internal virtual PictureBox w3N()
	{
		return _Pic;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Aw0(PictureBox e1P)
	{
		_Pic = e1P;
	}
}
