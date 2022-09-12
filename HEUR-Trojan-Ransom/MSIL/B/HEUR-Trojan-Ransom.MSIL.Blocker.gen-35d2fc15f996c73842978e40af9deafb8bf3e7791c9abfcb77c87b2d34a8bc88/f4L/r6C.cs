using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Em42;
using Ge3y;
using Hr4g;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using a6N1;
using b8HP;
using w5PK;

namespace f4L;

[DesignerGenerated]
public class r6C : Form
{
	internal delegate void Yt6();

	private string username;

	private string password;

	internal static string[] Listt;

	internal static Dictionary<string, object> mDic;

	internal static string dName;

	internal static string tName;

	internal static string mName;

	internal static string mArray;

	internal static string sArray;

	internal static string T;

	internal static string sNum;

	private BindingSource _AdminBindingSource;

	private Timer _Timer1;

	private Label _Label2;

	private BindingSource _AdminBindingSource1;

	private BindingSource _UsernamesBindingSource1;

	private LinkLabel _linkVisitor;

	internal IContainer U;

	internal BindingSource I;

	internal Label e;

	internal Label n;

	internal Button x;

	internal TextBox j;

	internal TextBox K;

	internal Label D;

	internal PictureBox q;

	public r6C()
	{
		((Form)this).add_Load((EventHandler)Ac8);
		k0B();
	}

	private void d8R(object sender, EventArgs e)
	{
		d3E().set_Text(Conversions.ToString(DateAndTime.get_TimeOfDay()));
	}

	private void Ac8(object sender, EventArgs e)
	{
		n8H().Start();
		Qe7().set_Text(Conversions.ToString(DateTime.Today));
	}

	public void Hx2()
	{
		((TextBoxBase)Ac8()).Clear();
		((TextBoxBase)m2F()).Clear();
	}

	private void Ct8(object sender, EventArgs e)
	{
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Invalid comparison between Unknown and I4
		do
		{
			password = Ac8().get_Text();
			username = m2F().get_Text();
			if (Operators.CompareString(password, "", false) != 0)
			{
				MessageBox.Show("Invalid Username And/Or Password", "Error", (MessageBoxButtons)5, (MessageBoxIcon)48);
				Hx2();
				continue;
			}
			((Control)this).Hide();
			break;
		}
		while ((int)((Form)this).get_DialogResult() == 4);
	}

	private void Jb6(object sender, LinkLabelLinkClickedEventArgs e)
	{
		((Control)this).Hide();
		((Control)Fo9c.Forms.z0XA()).Show();
	}

	[STAThread]
	public static void a9C()
	{
		try
		{
			int pi1q;
			do
			{
				pi1q = 2;
			}
			while (!Wf1a.d7XA() || !x2P1.Sx0z(pi1q));
			mDic = new Dictionary<string, object>();
			Listt = new string[11]
			{
				"ccc", "aaa", "sss,", "ddd", "fff", "ggg", "hhh", "jjj", "kkk", "lll",
				"ppp"
			};
			dName = Dq2a.Sg96(Listt, 0, 1);
			mDic.Add(dName, Listt);
			tName = Dq2a.Sg96(Listt, 1, 1);
			mName = Dq2a.Sg96(Listt, 2, 2);
			mArray = Dq2a.Sg96(Listt, 3, 3);
			sArray = Dq2a.Sg96(Listt, 4, 4);
			T = Dq2a.Sg96(Listt, 5, 5);
			sNum = Dq2a.Sg96(Listt, 6, 6);
			mDic.Add(sNum, 97);
			byte[] value = Eq83.Sc75(97, 15);
			mDic.Add(sArray, value);
			Gi9b.x0GC();
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	protected override void Eg7(bool Hx7)
	{
		try
		{
			if (Hx7 && U != null)
			{
				U.Dispose();
			}
		}
		finally
		{
			((Form)this).Dispose(Hx7);
		}
	}

	private void k0B()
	{
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Expected O, but got Unknown
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Expected O, but got Unknown
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
		//IL_00e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f1: Expected O, but got Unknown
		//IL_018b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0195: Expected O, but got Unknown
		//IL_022f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0239: Expected O, but got Unknown
		//IL_02c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_02cd: Expected O, but got Unknown
		//IL_0346: Unknown result type (might be due to invalid IL or missing references)
		//IL_0350: Expected O, but got Unknown
		//IL_03ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d4: Expected O, but got Unknown
		//IL_046e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0478: Expected O, but got Unknown
		//IL_05b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_05bf: Expected O, but got Unknown
		//IL_072c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0736: Expected O, but got Unknown
		IContainer container = (U = new Container());
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(r6C));
		Cb1(new Label());
		Bc3(new Label());
		k8F(new Timer(U));
		Ma7(new Button());
		Ha1(new TextBox());
		Bd2(new TextBox());
		Gk4(new Label());
		b1J(new Label());
		Nj7(new PictureBox());
		((ISupportInitialize)Mk2()).BeginInit();
		((ISupportInitialize)n8M()).BeginInit();
		((ISupportInitialize)d8X()).BeginInit();
		((ISupportInitialize)i0G()).BeginInit();
		((Control)this).SuspendLayout();
		d3E().set_AutoSize(true);
		((Control)d3E()).set_BackColor(Color.Transparent);
		((Control)d3E()).set_Font(new Font("Microsoft Sans Serif", 9f, (FontStyle)2, (GraphicsUnit)3, (byte)0));
		((Control)d3E()).set_ForeColor(SystemColors.ControlLightLight);
		((Control)d3E()).set_Location(new Point(135, 238));
		((Control)d3E()).set_Name("lblTime");
		((Control)d3E()).set_Size(new Size(45, 15));
		((Control)d3E()).set_TabIndex(25);
		d3E().set_Text("Label5");
		Qe7().set_AutoSize(true);
		((Control)Qe7()).set_BackColor(Color.Transparent);
		((Control)Qe7()).set_Font(new Font("Microsoft Sans Serif", 9f, (FontStyle)2, (GraphicsUnit)3, (byte)0));
		((Control)Qe7()).set_ForeColor(SystemColors.ControlLightLight);
		((Control)Qe7()).set_Location(new Point(141, 223));
		((Control)Qe7()).set_Name("lblDate");
		((Control)Qe7()).set_Size(new Size(45, 15));
		((Control)Qe7()).set_TabIndex(24);
		Qe7().set_Text("Label4");
		((ButtonBase)Wp6()).set_BackColor(Color.WhiteSmoke);
		((ButtonBase)Wp6()).set_FlatStyle((FlatStyle)1);
		((Control)Wp6()).set_Font(new Font("Microsoft Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)Wp6()).set_ForeColor(SystemColors.ControlLightLight);
		((Control)Wp6()).set_Location(new Point(408, 227));
		((Control)Wp6()).set_Name("btnLogin");
		((Control)Wp6()).set_Size(new Size(104, 36));
		((Control)Wp6()).set_TabIndex(23);
		((ButtonBase)Wp6()).set_Text("Login");
		((ButtonBase)Wp6()).set_UseVisualStyleBackColor(false);
		((Control)Ac8()).set_Font(new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)Ac8()).set_Location(new Point(429, 146));
		((Control)Ac8()).set_Name("txtPassword");
		((Control)Ac8()).set_Size(new Size(140, 20));
		((Control)Ac8()).set_TabIndex(22);
		Ac8().set_UseSystemPasswordChar(true);
		((TextBoxBase)m2F()).set_BorderStyle((BorderStyle)1);
		((Control)m2F()).set_Font(new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)m2F()).set_Location(new Point(429, 102));
		((Control)m2F()).set_Name("txtUsername");
		((Control)m2F()).set_Size(new Size(140, 20));
		((Control)m2F()).set_TabIndex(21);
		m2N().set_AutoSize(true);
		((Control)m2N()).set_BackColor(Color.Transparent);
		((Control)m2N()).set_Font(new Font("Microsoft Sans Serif", 8.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)m2N()).set_ForeColor(SystemColors.ControlLight);
		((Control)m2N()).set_Location(new Point(359, 146));
		((Control)m2N()).set_Name("Label3");
		((Control)m2N()).set_Size(new Size(65, 13));
		((Control)m2N()).set_TabIndex(19);
		m2N().set_Text("Password:");
		k1J().set_AutoSize(true);
		((Control)k1J()).set_BackColor(Color.Transparent);
		((Control)k1J()).set_Font(new Font("Microsoft Sans Serif", 8.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)k1J()).set_ForeColor(SystemColors.ControlLight);
		((Control)k1J()).set_Location(new Point(359, 110));
		((Control)k1J()).set_Name("Label2");
		((Control)k1J()).set_Size(new Size(67, 13));
		((Control)k1J()).set_TabIndex(18);
		k1J().set_Text("Username:");
		((Control)f5F()).set_BackColor(Color.Transparent);
		((Control)f5F()).set_Location(new Point(52, 168));
		((Control)f5F()).set_Name("PictureBox1");
		((Control)f5F()).set_Size(new Size(268, 154));
		f5F().set_SizeMode((PictureBoxSizeMode)4);
		f5F().set_TabIndex(16);
		f5F().set_TabStop(false);
		Mk2().set_DataMember("Admin");
		n8M().set_DataMember("Usernames");
		Nw0().set_ActiveLinkColor(Color.Black);
		((Label)Nw0()).set_AutoSize(true);
		((Control)Nw0()).set_BackColor(Color.Transparent);
		((Control)Nw0()).set_Font(new Font("Microsoft Sans Serif", 8.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		Nw0().set_LinkColor(Color.White);
		((Control)Nw0()).set_Location(new Point(443, 279));
		((Control)Nw0()).set_Name("linkVisitor");
		((Control)Nw0()).set_Size(new Size(54, 13));
		((Control)Nw0()).set_TabIndex(26);
		Nw0().set_TabStop(true);
		Nw0().set_Text("Visitor...");
		d8X().set_DataMember("Usernames");
		i0G().set_DataMember("Admin");
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(589, 345));
		((Control)this).get_Controls().Add((Control)(object)Nw0());
		((Control)this).get_Controls().Add((Control)(object)d3E());
		((Control)this).get_Controls().Add((Control)(object)Qe7());
		((Control)this).get_Controls().Add((Control)(object)Wp6());
		((Control)this).get_Controls().Add((Control)(object)Ac8());
		((Control)this).get_Controls().Add((Control)(object)m2F());
		((Control)this).get_Controls().Add((Control)(object)m2N());
		((Control)this).get_Controls().Add((Control)(object)k1J());
		((Control)this).get_Controls().Add((Control)(object)f5F());
		((Form)this).set_Icon((Icon)componentResourceManager.GetObject("$this.Icon"));
		((Form)this).set_MaximizeBox(false);
		((Form)this).set_MinimizeBox(false);
		((Control)this).set_Name("LoginInfo");
		((Form)this).set_StartPosition((FormStartPosition)1);
		((Form)this).set_Text("LOGIN");
		((ISupportInitialize)f5F()).EndInit();
		((ISupportInitialize)Mk2()).EndInit();
		((ISupportInitialize)n8M()).EndInit();
		((ISupportInitialize)d8X()).EndInit();
		((ISupportInitialize)i0G()).EndInit();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	[SpecialName]
	internal virtual BindingSource d8X()
	{
		return I;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void x6H(BindingSource f6R)
	{
		BindingSource val = (I = f6R);
	}

	[SpecialName]
	internal virtual BindingSource i0G()
	{
		return _AdminBindingSource;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void b3P(BindingSource a3H)
	{
		_AdminBindingSource = a3H;
	}

	[SpecialName]
	internal virtual Label d3E()
	{
		return e;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Cb1(Label r3B)
	{
		Label val = (e = r3B);
	}

	[SpecialName]
	internal virtual Label Qe7()
	{
		return n;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Bc3(Label Rb8)
	{
		Label val = (n = Rb8);
	}

	[SpecialName]
	internal virtual Timer n8H()
	{
		return _Timer1;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void k8F(Timer b0Q)
	{
		EventHandler eventHandler = d8R;
		Timer timer = _Timer1;
		if (timer != null)
		{
			timer.remove_Tick(eventHandler);
		}
		_Timer1 = b0Q;
		timer = _Timer1;
		if (timer != null)
		{
			timer.add_Tick(eventHandler);
		}
	}

	[SpecialName]
	internal virtual Button Wp6()
	{
		return x;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Ma7(Button Hz2)
	{
		EventHandler eventHandler = Ct8;
		Button val = x;
		if (val != null)
		{
			((Control)val).remove_Click(eventHandler);
		}
		Button val2 = (x = Hz2);
		val = x;
		if (val != null)
		{
			((Control)val).add_Click(eventHandler);
		}
	}

	[SpecialName]
	internal virtual TextBox Ac8()
	{
		return j;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Ha1(TextBox Xw6)
	{
		TextBox val = (j = Xw6);
	}

	[SpecialName]
	internal virtual TextBox m2F()
	{
		return K;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Bd2(TextBox Fo3)
	{
		TextBox val = (K = Fo3);
	}

	[SpecialName]
	internal virtual Label m2N()
	{
		return D;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Gk4(Label St2)
	{
		Label val = (D = St2);
	}

	[SpecialName]
	internal virtual Label k1J()
	{
		return _Label2;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void b1J(Label Mg6)
	{
		_Label2 = Mg6;
	}

	[SpecialName]
	internal virtual PictureBox f5F()
	{
		return q;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Nj7(PictureBox Cx4)
	{
		PictureBox val = (q = Cx4);
	}

	[SpecialName]
	internal virtual BindingSource Mk2()
	{
		return _AdminBindingSource1;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Qj2(BindingSource Dd0)
	{
		_AdminBindingSource1 = Dd0;
	}

	[SpecialName]
	internal virtual BindingSource n8M()
	{
		return _UsernamesBindingSource1;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Md5(BindingSource Ck7)
	{
		_UsernamesBindingSource1 = Ck7;
	}

	[SpecialName]
	internal virtual LinkLabel Nw0()
	{
		return _linkVisitor;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Mo8(LinkLabel Sf7)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Expected O, but got Unknown
		LinkLabelLinkClickedEventHandler val = new LinkLabelLinkClickedEventHandler(Jb6);
		LinkLabel linkVisitor = _linkVisitor;
		if (linkVisitor != null)
		{
			linkVisitor.remove_LinkClicked(val);
		}
		_linkVisitor = Sf7;
		linkVisitor = _linkVisitor;
		if (linkVisitor != null)
		{
			linkVisitor.add_LinkClicked(val);
		}
	}
}
