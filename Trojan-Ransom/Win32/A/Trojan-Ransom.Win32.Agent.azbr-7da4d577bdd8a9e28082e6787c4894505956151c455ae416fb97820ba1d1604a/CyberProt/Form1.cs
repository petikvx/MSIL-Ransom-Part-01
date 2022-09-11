using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Net;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.AccessControl;
using System.Security.Cryptography;
using System.Security.Principal;
using System.ServiceProcess;
using System.Text;
using System.Threading;
using System.Web.Script.Serialization;
using System.Windows.Forms;
using System.Windows.Forms.Layout;
using LicenseSpot.Framework;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.Devices;
using Microsoft.Win32;

namespace CyberProt;

[DesignerGenerated]
public class Form1 : Form
{
	public enum ShowWindowConstants
	{
		SW_HIDE = 0,
		SW_SHOWNORMAL = 1,
		SW_NORMAL = 1,
		SW_SHOWMINIMIZED = 2,
		SW_SHOWMAXIMIZED = 3,
		SW_MAXIMIZE = 3,
		SW_SHOWNOACTIVATE = 4,
		SW_SHOW = 5,
		SW_MINIMIZE = 6,
		SW_SHOWMINNOACTIVE = 7,
		SW_SHOWNA = 8,
		SW_RESTORE = 9,
		SW_SHOWDEFAULT = 10,
		SW_FORCEMINIMIZE = 11,
		SW_MAX = 11
	}

	public struct SHFILEINFO
	{
		public IntPtr hIcon;

		public int iIcon;

		public int dwAttributes;

		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 260)]
		public string szDisplayName;

		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 80)]
		public string szTypeName;
	}

	public struct DB
	{
		public string version;

		public List<string> Standard;

		public List<string> Likes;
	}

	[CompilerGenerated]
	internal sealed class a
	{
		public bool a;

		public Form1 b;

		[SpecialName]
		internal void c()
		{
			b.UpdateW(a);
		}
	}

	[CompilerGenerated]
	internal sealed class b
	{
		public Label a;

		public string b;

		public Form1 c;

		[SpecialName]
		internal void d()
		{
			c.UpdateLab(a, b);
		}
	}

	[CompilerGenerated]
	internal sealed class c
	{
		public Control a;

		public string b;

		public Form1 c;

		[SpecialName]
		internal void d()
		{
			c.UpdateTag(a, b);
		}
	}

	[CompilerGenerated]
	internal sealed class d
	{
		public bool a;

		public Form1 b;

		public d(d A_0)
		{
			if (A_0 != null)
			{
				a = A_0.a;
			}
		}

		[SpecialName]
		internal void c()
		{
			b.Lic(a);
		}
	}

	[CompilerGenerated]
	internal sealed class e
	{
		public Control a;

		public bool b;

		public Form1 c;

		[SpecialName]
		internal void d()
		{
			c.UpdateF(a, b);
		}
	}

	[CompilerGenerated]
	internal sealed class f
	{
		public string a;

		public string b;

		public MessageBoxButtons c;

		public MessageBoxIcon d;

		[SpecialName]
		internal void e()
		{
			//IL_000d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0013: Unknown result type (might be due to invalid IL or missing references)
			//IL_0018: Unknown result type (might be due to invalid IL or missing references)
			MessageBox.Show(a, b, c, d);
		}
	}

	[CompilerGenerated]
	internal sealed class g
	{
		public PictureBox a;

		public bool b;

		public Form1 c;

		[SpecialName]
		internal void d()
		{
			c.UpdatePB(a, b);
		}
	}

	[CompilerGenerated]
	internal sealed class h
	{
		public PictureBox a;

		public Image b;

		public Form1 c;

		[SpecialName]
		internal void d()
		{
			c.UpdateIMG(a, b);
		}
	}

	[CompilerGenerated]
	internal sealed class i
	{
		public Control a;

		public bool b;

		public Form1 c;

		[SpecialName]
		internal void d()
		{
			c.UpdateE(a, b);
		}
	}

	private Form2 m_a;

	public const int WM_NCLBUTTONDOWN = 161;

	public const int HTCAPTION = 2;

	private const uint m_b = 793u;

	private const uint m_c = 10u;

	private const uint m_d = 9u;

	private const uint m_e = 8u;

	public bool WinStart;

	public bool CredentalRequired;

	public bool DisableTraps;

	public bool DisableRenamesScan;

	public bool MailOK;

	public bool AppdataExec;

	public bool ArchiveExec;

	private const uint m_f = 256u;

	private const uint m_g = 0u;

	private const uint m_h = 1u;

	private const uint m_i = 16u;

	private const uint m_j = 4096u;

	private const uint m_k = 16384u;

	private const uint m_l = 4u;

	private const uint m_m = 2u;

	private const uint m_n = 1u;

	private const uint m_o = 32u;

	private const uint m_p = 128u;

	private DB m_q;

	public bool DoDatabaseVersion;

	public string ServerVer;

	private bool m_r;

	private ExtendedLicense m_s;

	private bool m_t;

	public bool DoLic;

	private bool m_u;

	private int m_v;

	public bool ENG;

	public bool DoUpdater;

	public string ReadedDatabase;

	public bool DoUpdate;

	public string SCStatus;

	public bool LogRefs;

	private string m_w;

	private SolidBrush m_x;

	private SolidBrush m_y;

	private IContainer m_z;

	[AccessedThroughProperty("Panel1")]
	[CompilerGenerated]
	private Panel m_aa;

	[AccessedThroughProperty("NotifyIcon1")]
	[CompilerGenerated]
	private NotifyIcon m_ab;

	[AccessedThroughProperty("Panel2")]
	[CompilerGenerated]
	private Panel m_ac;

	[AccessedThroughProperty("Label1")]
	[CompilerGenerated]
	private Label m_ad;

	[CompilerGenerated]
	[AccessedThroughProperty("PictureBox2")]
	private PictureBox m_ae;

	[AccessedThroughProperty("Panel3")]
	[CompilerGenerated]
	private Panel m_af;

	[CompilerGenerated]
	[AccessedThroughProperty("Label5")]
	private Label m_ag;

	[AccessedThroughProperty("Label4")]
	[CompilerGenerated]
	private Label m_ah;

	[CompilerGenerated]
	[AccessedThroughProperty("Label2")]
	private Label m_ai;

	[CompilerGenerated]
	[AccessedThroughProperty("PictureBox3")]
	private PictureBox m_aj;

	[AccessedThroughProperty("PictureBox5")]
	[CompilerGenerated]
	private PictureBox m_ak;

	[CompilerGenerated]
	[AccessedThroughProperty("PictureBox6")]
	private PictureBox m_al;

	[CompilerGenerated]
	[AccessedThroughProperty("PictureBox7")]
	private PictureBox m_am;

	[CompilerGenerated]
	[AccessedThroughProperty("PictureBox8")]
	private PictureBox m_an;

	[AccessedThroughProperty("StatusPanelMain")]
	[CompilerGenerated]
	private Panel m_ao;

	[CompilerGenerated]
	[AccessedThroughProperty("ContextMenuStrip1")]
	private ContextMenuStrip m_ap;

	[CompilerGenerated]
	[AccessedThroughProperty("OpenToolStripMenuItem")]
	private ToolStripMenuItem m_aq;

	[AccessedThroughProperty("ExitToolStripMenuItem")]
	[CompilerGenerated]
	private ToolStripMenuItem m_ar;

	[AccessedThroughProperty("GeneralSettingsPanelMain")]
	[CompilerGenerated]
	private Panel m_as;

	[CompilerGenerated]
	[AccessedThroughProperty("ImageList1")]
	private ImageList m_at;

	[AccessedThroughProperty("PictureBox9")]
	[CompilerGenerated]
	private PictureBox m_au;

	[AccessedThroughProperty("Panel5")]
	[CompilerGenerated]
	private Panel m_av;

	[AccessedThroughProperty("Label11")]
	[CompilerGenerated]
	private Label m_aw;

	[AccessedThroughProperty("ToolTip1")]
	[CompilerGenerated]
	private ToolTip m_ax;

	[AccessedThroughProperty("Panel7")]
	[CompilerGenerated]
	private Panel m_ay;

	[AccessedThroughProperty("Label22")]
	[CompilerGenerated]
	private Label m_az;

	[AccessedThroughProperty("PictureBox27")]
	[CompilerGenerated]
	private PictureBox m_a0;

	[AccessedThroughProperty("ActionsPanelMain")]
	[CompilerGenerated]
	private Panel m_a1;

	[AccessedThroughProperty("Panel11")]
	[CompilerGenerated]
	private Panel m_a2;

	[CompilerGenerated]
	[AccessedThroughProperty("PictureBox30")]
	private PictureBox m_a3;

	[CompilerGenerated]
	[AccessedThroughProperty("Label24")]
	private Label m_a4;

	[AccessedThroughProperty("PictureBox31")]
	[CompilerGenerated]
	private PictureBox m_a5;

	[AccessedThroughProperty("Panel18")]
	[CompilerGenerated]
	private Panel m_a6;

	[AccessedThroughProperty("PictureBox46")]
	[CompilerGenerated]
	private PictureBox m_a7;

	[CompilerGenerated]
	[AccessedThroughProperty("Label33")]
	private Label m_a8;

	[CompilerGenerated]
	[AccessedThroughProperty("PictureBox47")]
	private PictureBox m_a9;

	[CompilerGenerated]
	[AccessedThroughProperty("Panel10")]
	private Panel m_ba;

	[AccessedThroughProperty("PictureBox38")]
	[CompilerGenerated]
	private PictureBox m_bb;

	[CompilerGenerated]
	[AccessedThroughProperty("Label29")]
	private Label m_bc;

	[AccessedThroughProperty("PictureBox39")]
	[CompilerGenerated]
	private PictureBox m_bd;

	[AccessedThroughProperty("Panel12")]
	[CompilerGenerated]
	private Panel m_be;

	[CompilerGenerated]
	[AccessedThroughProperty("PictureBox32")]
	private PictureBox m_bf;

	[CompilerGenerated]
	[AccessedThroughProperty("PictureBox54")]
	private PictureBox m_bg;

	[CompilerGenerated]
	[AccessedThroughProperty("ImageList2")]
	private ImageList m_bh;

	[AccessedThroughProperty("Panel20")]
	[CompilerGenerated]
	private Panel m_bi;

	[AccessedThroughProperty("MaskedTextBox1")]
	[CompilerGenerated]
	private MaskedTextBox m_bj;

	[CompilerGenerated]
	[AccessedThroughProperty("TrialStatus")]
	private Label m_bk;

	[CompilerGenerated]
	[AccessedThroughProperty("LicenseStatus")]
	private Label m_bl;

	[CompilerGenerated]
	[AccessedThroughProperty("Timer1")]
	private Timer m_bm;

	[CompilerGenerated]
	[AccessedThroughProperty("Panel22")]
	private Panel m_bn;

	[CompilerGenerated]
	[AccessedThroughProperty("Label6")]
	private Label m_bo;

	[CompilerGenerated]
	[AccessedThroughProperty("PictureBox57")]
	private PictureBox m_bp;

	[AccessedThroughProperty("Label36")]
	[CompilerGenerated]
	private Label m_bq;

	[CompilerGenerated]
	[AccessedThroughProperty("ImageList3")]
	private ImageList m_br;

	[CompilerGenerated]
	[AccessedThroughProperty("Label38")]
	private Label m_bs;

	[CompilerGenerated]
	[AccessedThroughProperty("Timer2")]
	private Timer m_bt;

	[CompilerGenerated]
	[AccessedThroughProperty("Timer3")]
	private Timer m_bu;

	[AccessedThroughProperty("Panel33")]
	[CompilerGenerated]
	private Panel m_bv;

	[CompilerGenerated]
	[AccessedThroughProperty("Label50")]
	private Label m_bw;

	[AccessedThroughProperty("PictureBox77")]
	[CompilerGenerated]
	private PictureBox m_bx;

	[AccessedThroughProperty("AdvancedPanelMain")]
	[CompilerGenerated]
	private Panel m_by;

	[AccessedThroughProperty("Panel23")]
	[CompilerGenerated]
	private Panel m_bz;

	[CompilerGenerated]
	[AccessedThroughProperty("ContextMenuStrip2")]
	private ContextMenuStrip m_b0;

	[AccessedThroughProperty("SelectAllToolStripMenuItem")]
	[CompilerGenerated]
	private ToolStripMenuItem m_b1;

	[AccessedThroughProperty("Label42")]
	[CompilerGenerated]
	private Label m_b2;

	[AccessedThroughProperty("Timer4")]
	[CompilerGenerated]
	private Timer m_b3;

	[AccessedThroughProperty("PictureBox62")]
	[CompilerGenerated]
	private PictureBox m_b4;

	[CompilerGenerated]
	[AccessedThroughProperty("PictureBox61")]
	private PictureBox m_b5;

	[AccessedThroughProperty("PictureBox60")]
	[CompilerGenerated]
	private PictureBox m_b6;

	[CompilerGenerated]
	[AccessedThroughProperty("PictureBox1")]
	private PictureBox m_b7;

	[CompilerGenerated]
	[AccessedThroughProperty("PictureBox63")]
	private PictureBox m_b8;

	[CompilerGenerated]
	[AccessedThroughProperty("Label8")]
	private Label m_b9;

	[CompilerGenerated]
	[AccessedThroughProperty("Panel27")]
	private Panel m_ca;

	[AccessedThroughProperty("PictureBox64")]
	[CompilerGenerated]
	private PictureBox m_cb;

	[CompilerGenerated]
	[AccessedThroughProperty("Panel26")]
	private Panel m_cc;

	[AccessedThroughProperty("PictureBox50")]
	[CompilerGenerated]
	private PictureBox m_cd;

	[AccessedThroughProperty("Panel25")]
	[CompilerGenerated]
	private Panel m_ce;

	[CompilerGenerated]
	[AccessedThroughProperty("PictureBox53")]
	private PictureBox m_cf;

	[AccessedThroughProperty("Label52")]
	[CompilerGenerated]
	private Label m_cg;

	[CompilerGenerated]
	[AccessedThroughProperty("Label51")]
	private Label m_ch;

	[CompilerGenerated]
	[AccessedThroughProperty("Label44")]
	private Label m_ci;

	[AccessedThroughProperty("PictureBox65")]
	[CompilerGenerated]
	private PictureBox m_cj;

	[CompilerGenerated]
	[AccessedThroughProperty("Panel28")]
	private Panel m_ck;

	[CompilerGenerated]
	[AccessedThroughProperty("PictureBox67")]
	private PictureBox m_cl;

	[CompilerGenerated]
	[AccessedThroughProperty("Label37")]
	private Label m_cm;

	[AccessedThroughProperty("Panel34")]
	[CompilerGenerated]
	private Panel m_cn;

	[CompilerGenerated]
	[AccessedThroughProperty("Label55")]
	private Label m_co;

	[AccessedThroughProperty("Label56")]
	[CompilerGenerated]
	private Label m_cp;

	[CompilerGenerated]
	[AccessedThroughProperty("PictureBox66")]
	private PictureBox m_cq;

	[AccessedThroughProperty("Label25")]
	[CompilerGenerated]
	private Label m_cr;

	[AccessedThroughProperty("Label35")]
	[CompilerGenerated]
	private Label m_cs;

	[CompilerGenerated]
	[AccessedThroughProperty("PictureBox68")]
	private PictureBox m_ct;

	[AccessedThroughProperty("Panel24")]
	[CompilerGenerated]
	private Panel m_cu;

	[AccessedThroughProperty("Panel35")]
	[CompilerGenerated]
	private Panel m_cv;

	[CompilerGenerated]
	[AccessedThroughProperty("Label43")]
	private Label m_cw;

	[CompilerGenerated]
	[AccessedThroughProperty("ListBox1")]
	private ListBox m_cx;

	[AccessedThroughProperty("ContextMenuStrip3")]
	[CompilerGenerated]
	private ContextMenuStrip m_cy;

	[AccessedThroughProperty("ToolStripMenuItem1")]
	[CompilerGenerated]
	private ToolStripMenuItem m_cz;

	[AccessedThroughProperty("RemoveFolderToolStripMenuItem")]
	[CompilerGenerated]
	private ToolStripMenuItem m_c0;

	[AccessedThroughProperty("FolderBrowserDialog1")]
	[CompilerGenerated]
	private FolderBrowserDialog m_c1;

	[CompilerGenerated]
	[AccessedThroughProperty("ImageList4")]
	private ImageList m_c2;

	[AccessedThroughProperty("PictureBox78")]
	[CompilerGenerated]
	private PictureBox m_c3;

	[AccessedThroughProperty("Panel36")]
	[CompilerGenerated]
	private Panel m_c4;

	[AccessedThroughProperty("Label64")]
	[CompilerGenerated]
	private Label m_c5;

	[CompilerGenerated]
	[AccessedThroughProperty("PictureBox91")]
	private PictureBox m_c6;

	[AccessedThroughProperty("LogPanelMain")]
	[CompilerGenerated]
	private Panel m_c7;

	[CompilerGenerated]
	[AccessedThroughProperty("DataGridView1")]
	private DataGridView m_c8;

	[AccessedThroughProperty("TextBox8")]
	[CompilerGenerated]
	private TextBox m_c9;

	[CompilerGenerated]
	[AccessedThroughProperty("ImageList5")]
	private ImageList m_da;

	[AccessedThroughProperty("Panel4")]
	[CompilerGenerated]
	private Panel m_db;

	[AccessedThroughProperty("PictureBox4")]
	[CompilerGenerated]
	private PictureBox m_dc;

	[CompilerGenerated]
	[AccessedThroughProperty("Label3")]
	private Label m_dd;

	[AccessedThroughProperty("Panel6")]
	[CompilerGenerated]
	private Panel m_de;

	[AccessedThroughProperty("Label7")]
	[CompilerGenerated]
	private Label m_df;

	[CompilerGenerated]
	[AccessedThroughProperty("Panel8")]
	private Panel m_dg;

	[CompilerGenerated]
	[AccessedThroughProperty("Label9")]
	private Label m_dh;

	[AccessedThroughProperty("Panel13")]
	[CompilerGenerated]
	private Panel m_di;

	[AccessedThroughProperty("Label10")]
	[CompilerGenerated]
	private Label m_dj;

	[CompilerGenerated]
	[AccessedThroughProperty("Label26")]
	private Label m_dk;

	[CompilerGenerated]
	[AccessedThroughProperty("Label23")]
	private Label m_dl;

	[AccessedThroughProperty("Label12")]
	[CompilerGenerated]
	private Label m_dm;

	[AccessedThroughProperty("Label13")]
	[CompilerGenerated]
	private Label m_dn;

	[AccessedThroughProperty("Label14")]
	[CompilerGenerated]
	private Label m_do;

	[CompilerGenerated]
	[AccessedThroughProperty("Label16")]
	private Label m_dp;

	[CompilerGenerated]
	[AccessedThroughProperty("Label18")]
	private Label m_dq;

	[CompilerGenerated]
	[AccessedThroughProperty("Label17")]
	private Label m_dr;

	[AccessedThroughProperty("DataGridView2")]
	[CompilerGenerated]
	private DataGridView m_ds;

	[AccessedThroughProperty("ContextMenuStrip4")]
	[CompilerGenerated]
	private ContextMenuStrip m_dt;

	[CompilerGenerated]
	[AccessedThroughProperty("ToolStripMenuItem2")]
	private ToolStripMenuItem m_du;

	[AccessedThroughProperty("ToolStripMenuItem3")]
	[CompilerGenerated]
	private ToolStripMenuItem m_dv;

	[CompilerGenerated]
	[AccessedThroughProperty("ToolStripSeparator1")]
	private ToolStripSeparator m_dw;

	[AccessedThroughProperty("ToolStripMenuItem4")]
	[CompilerGenerated]
	private ToolStripMenuItem m_dx;

	[AccessedThroughProperty("ContextMenuStrip5")]
	[CompilerGenerated]
	private ContextMenuStrip m_dy;

	[CompilerGenerated]
	[AccessedThroughProperty("SmartScanPanelMain")]
	private Panel m_dz;

	[CompilerGenerated]
	[AccessedThroughProperty("Label15")]
	private Label m_d0;

	[CompilerGenerated]
	[AccessedThroughProperty("DataGridViewTextBoxColumn2")]
	private DataGridViewTextBoxColumn m_d1;

	[CompilerGenerated]
	[AccessedThroughProperty("DataGridViewTextBoxColumn4")]
	private DataGridViewTextBoxColumn m_d2;

	[CompilerGenerated]
	[AccessedThroughProperty("DataGridViewTextBoxColumn3")]
	private DataGridViewTextBoxColumn m_d3;

	[AccessedThroughProperty("ClearToolStripMenuItem")]
	[CompilerGenerated]
	private ToolStripMenuItem d4;

	[CompilerGenerated]
	[AccessedThroughProperty("WipeAllFilesToolStripMenuItem")]
	private ToolStripMenuItem d5;

	[AccessedThroughProperty("ToolStripSeparator2")]
	[CompilerGenerated]
	private ToolStripSeparator d6;

	[AccessedThroughProperty("ToolStripMenuItem5")]
	[CompilerGenerated]
	private ToolStripMenuItem d7;

	[AccessedThroughProperty("ToolStripSeparator3")]
	[CompilerGenerated]
	private ToolStripSeparator d8;

	[AccessedThroughProperty("TextBox1")]
	[CompilerGenerated]
	private TextBox d9;

	[CompilerGenerated]
	[AccessedThroughProperty("Label19")]
	private Label ea;

	[CompilerGenerated]
	[AccessedThroughProperty("Button2")]
	private Button eb;

	[AccessedThroughProperty("Button1")]
	[CompilerGenerated]
	private Button ec;

	[AccessedThroughProperty("Column1")]
	[CompilerGenerated]
	private DataGridViewImageColumn ed;

	[AccessedThroughProperty("Level")]
	[CompilerGenerated]
	private DataGridViewTextBoxColumn ee;

	[AccessedThroughProperty("Column3")]
	[CompilerGenerated]
	private DataGridViewTextBoxColumn ef;

	[AccessedThroughProperty("Column2")]
	[CompilerGenerated]
	private DataGridViewTextBoxColumn eg;

	[AccessedThroughProperty("Column4")]
	[CompilerGenerated]
	private DataGridViewTextBoxColumn eh;

	protected override CreateParams CreateParams
	{
		get
		{
			CreateParams createParams = ((Form)this).get_CreateParams();
			createParams.set_ExStyle(createParams.get_ExStyle() | 0x2000000);
			return createParams;
		}
	}

	internal virtual Panel Panel1
	{
		[CompilerGenerated]
		get
		{
			return this.m_aa;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = ar;
			Panel val = this.m_aa;
			if (val != null)
			{
				((Control)val).remove_MouseEnter(eventHandler);
			}
			this.m_aa = value;
			val = this.m_aa;
			if (val != null)
			{
				((Control)val).add_MouseEnter(eventHandler);
			}
		}
	}

	internal virtual NotifyIcon NotifyIcon1
	{
		[CompilerGenerated]
		get
		{
			return this.m_ab;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			//IL_0007: Unknown result type (might be due to invalid IL or missing references)
			//IL_000d: Expected O, but got Unknown
			MouseEventHandler val = new MouseEventHandler(f);
			EventHandler eventHandler = cl;
			NotifyIcon val2 = this.m_ab;
			if (val2 != null)
			{
				val2.remove_MouseClick(val);
				val2.remove_BalloonTipClicked(eventHandler);
			}
			this.m_ab = value;
			val2 = this.m_ab;
			if (val2 != null)
			{
				val2.add_MouseClick(val);
				val2.add_BalloonTipClicked(eventHandler);
			}
		}
	}

	internal virtual Panel Panel2
	{
		[CompilerGenerated]
		get
		{
			return this.m_ac;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			this.m_ac = value;
		}
	}

	internal virtual Label Label1
	{
		[CompilerGenerated]
		get
		{
			return this.m_ad;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = d2;
			EventHandler eventHandler2 = ai;
			EventHandler eventHandler3 = ah;
			Label val = this.m_ad;
			if (val != null)
			{
				((Control)val).remove_Click(eventHandler);
				((Control)val).remove_MouseEnter(eventHandler2);
				((Control)val).remove_MouseLeave(eventHandler3);
			}
			this.m_ad = value;
			val = this.m_ad;
			if (val != null)
			{
				((Control)val).add_Click(eventHandler);
				((Control)val).add_MouseEnter(eventHandler2);
				((Control)val).add_MouseLeave(eventHandler3);
			}
		}
	}

	internal virtual PictureBox PictureBox2
	{
		[CompilerGenerated]
		get
		{
			return this.m_ae;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = dj;
			EventHandler eventHandler2 = di;
			EventHandler eventHandler3 = dh;
			PictureBox val = this.m_ae;
			if (val != null)
			{
				((Control)val).remove_MouseEnter(eventHandler);
				((Control)val).remove_MouseLeave(eventHandler2);
				((Control)val).remove_Click(eventHandler3);
			}
			this.m_ae = value;
			val = this.m_ae;
			if (val != null)
			{
				((Control)val).add_MouseEnter(eventHandler);
				((Control)val).add_MouseLeave(eventHandler2);
				((Control)val).add_Click(eventHandler3);
			}
		}
	}

	internal virtual Panel Panel3
	{
		[CompilerGenerated]
		get
		{
			return this.m_af;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			this.m_af = value;
		}
	}

	internal virtual Label Label5
	{
		[CompilerGenerated]
		get
		{
			return this.m_ag;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = ds;
			EventHandler eventHandler2 = @do;
			EventHandler eventHandler3 = y;
			Label val = this.m_ag;
			if (val != null)
			{
				((Control)val).remove_MouseEnter(eventHandler);
				((Control)val).remove_MouseLeave(eventHandler2);
				((Control)val).remove_Click(eventHandler3);
			}
			this.m_ag = value;
			val = this.m_ag;
			if (val != null)
			{
				((Control)val).add_MouseEnter(eventHandler);
				((Control)val).add_MouseLeave(eventHandler2);
				((Control)val).add_Click(eventHandler3);
			}
		}
	}

	internal virtual Label Label4
	{
		[CompilerGenerated]
		get
		{
			return this.m_ah;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = dt;
			EventHandler eventHandler2 = dp;
			Label val = this.m_ah;
			if (val != null)
			{
				((Control)val).remove_MouseEnter(eventHandler);
				((Control)val).remove_MouseLeave(eventHandler2);
			}
			this.m_ah = value;
			val = this.m_ah;
			if (val != null)
			{
				((Control)val).add_MouseEnter(eventHandler);
				((Control)val).add_MouseLeave(eventHandler2);
			}
		}
	}

	internal virtual Label Label2
	{
		[CompilerGenerated]
		get
		{
			return this.m_ai;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = dw;
			EventHandler eventHandler2 = dv;
			EventHandler eventHandler3 = dr;
			Label val = this.m_ai;
			if (val != null)
			{
				((Control)val).remove_Click(eventHandler);
				((Control)val).remove_MouseEnter(eventHandler2);
				((Control)val).remove_MouseLeave(eventHandler3);
			}
			this.m_ai = value;
			val = this.m_ai;
			if (val != null)
			{
				((Control)val).add_Click(eventHandler);
				((Control)val).add_MouseEnter(eventHandler2);
				((Control)val).add_MouseLeave(eventHandler3);
			}
		}
	}

	internal virtual PictureBox PictureBox3
	{
		[CompilerGenerated]
		get
		{
			return this.m_aj;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = db;
			EventHandler eventHandler2 = da;
			EventHandler eventHandler3 = c9;
			PictureBox val = this.m_aj;
			if (val != null)
			{
				((Control)val).remove_Click(eventHandler);
				((Control)val).remove_MouseEnter(eventHandler2);
				((Control)val).remove_MouseLeave(eventHandler3);
			}
			this.m_aj = value;
			val = this.m_aj;
			if (val != null)
			{
				((Control)val).add_Click(eventHandler);
				((Control)val).add_MouseEnter(eventHandler2);
				((Control)val).add_MouseLeave(eventHandler3);
			}
		}
	}

	internal virtual PictureBox PictureBox5
	{
		[CompilerGenerated]
		get
		{
			return this.m_ak;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			this.m_ak = value;
		}
	}

	internal virtual PictureBox PictureBox6
	{
		[CompilerGenerated]
		get
		{
			return this.m_al;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = dz;
			PictureBox val = this.m_al;
			if (val != null)
			{
				((Control)val).remove_Click(eventHandler);
			}
			this.m_al = value;
			val = this.m_al;
			if (val != null)
			{
				((Control)val).add_Click(eventHandler);
			}
		}
	}

	internal virtual PictureBox PictureBox7
	{
		[CompilerGenerated]
		get
		{
			return this.m_am;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = d1;
			PictureBox val = this.m_am;
			if (val != null)
			{
				((Control)val).remove_Click(eventHandler);
			}
			this.m_am = value;
			val = this.m_am;
			if (val != null)
			{
				((Control)val).add_Click(eventHandler);
			}
		}
	}

	internal virtual PictureBox PictureBox8
	{
		[CompilerGenerated]
		get
		{
			return this.m_an;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			//IL_0007: Unknown result type (might be due to invalid IL or missing references)
			//IL_000d: Expected O, but got Unknown
			MouseEventHandler val = new MouseEventHandler(h);
			PictureBox val2 = this.m_an;
			if (val2 != null)
			{
				((Control)val2).remove_MouseMove(val);
			}
			this.m_an = value;
			val2 = this.m_an;
			if (val2 != null)
			{
				((Control)val2).add_MouseMove(val);
			}
		}
	}

	internal virtual Panel StatusPanelMain
	{
		[CompilerGenerated]
		get
		{
			return this.m_ao;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = aq;
			Panel val = this.m_ao;
			if (val != null)
			{
				((Control)val).remove_MouseEnter(eventHandler);
			}
			this.m_ao = value;
			val = this.m_ao;
			if (val != null)
			{
				((Control)val).add_MouseEnter(eventHandler);
			}
		}
	}

	internal virtual ContextMenuStrip ContextMenuStrip1
	{
		[CompilerGenerated]
		get
		{
			return this.m_ap;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			CancelEventHandler cancelEventHandler = d;
			ContextMenuStrip val = this.m_ap;
			if (val != null)
			{
				((ToolStripDropDown)val).remove_Opening(cancelEventHandler);
			}
			this.m_ap = value;
			val = this.m_ap;
			if (val != null)
			{
				((ToolStripDropDown)val).add_Opening(cancelEventHandler);
			}
		}
	}

	internal virtual ToolStripMenuItem OpenToolStripMenuItem
	{
		[CompilerGenerated]
		get
		{
			return this.m_aq;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = d0;
			ToolStripMenuItem val = this.m_aq;
			if (val != null)
			{
				((ToolStripItem)val).remove_Click(eventHandler);
			}
			this.m_aq = value;
			val = this.m_aq;
			if (val != null)
			{
				((ToolStripItem)val).add_Click(eventHandler);
			}
		}
	}

	internal virtual ToolStripMenuItem ExitToolStripMenuItem
	{
		[CompilerGenerated]
		get
		{
			return this.m_ar;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = dy;
			ToolStripMenuItem val = this.m_ar;
			if (val != null)
			{
				((ToolStripItem)val).remove_Click(eventHandler);
			}
			this.m_ar = value;
			val = this.m_ar;
			if (val != null)
			{
				((ToolStripItem)val).add_Click(eventHandler);
			}
		}
	}

	internal virtual Panel GeneralSettingsPanelMain
	{
		[CompilerGenerated]
		get
		{
			return this.m_as;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = am;
			Panel val = this.m_as;
			if (val != null)
			{
				((Control)val).remove_MouseEnter(eventHandler);
			}
			this.m_as = value;
			val = this.m_as;
			if (val != null)
			{
				((Control)val).add_MouseEnter(eventHandler);
			}
		}
	}

	internal virtual ImageList ImageList1
	{
		[CompilerGenerated]
		get
		{
			return this.m_at;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			this.m_at = value;
		}
	}

	internal virtual PictureBox PictureBox9
	{
		[CompilerGenerated]
		get
		{
			return this.m_au;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = dn;
			PictureBox val = this.m_au;
			if (val != null)
			{
				((Control)val).remove_Click(eventHandler);
			}
			this.m_au = value;
			val = this.m_au;
			if (val != null)
			{
				((Control)val).add_Click(eventHandler);
			}
		}
	}

	internal virtual Panel Panel5
	{
		[CompilerGenerated]
		get
		{
			return this.m_av;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			this.m_av = value;
		}
	}

	internal virtual Label Label11
	{
		[CompilerGenerated]
		get
		{
			return this.m_aw;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			this.m_aw = value;
		}
	}

	internal virtual ToolTip ToolTip1
	{
		[CompilerGenerated]
		get
		{
			return this.m_ax;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			this.m_ax = value;
		}
	}

	internal virtual Panel Panel7
	{
		[CompilerGenerated]
		get
		{
			return this.m_ay;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			this.m_ay = value;
		}
	}

	internal virtual Label Label22
	{
		[CompilerGenerated]
		get
		{
			return this.m_az;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			this.m_az = value;
		}
	}

	internal virtual PictureBox PictureBox27
	{
		[CompilerGenerated]
		get
		{
			return this.m_a0;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = dl;
			PictureBox val = this.m_a0;
			if (val != null)
			{
				((Control)val).remove_Click(eventHandler);
			}
			this.m_a0 = value;
			val = this.m_a0;
			if (val != null)
			{
				((Control)val).add_Click(eventHandler);
			}
		}
	}

	internal virtual Panel ActionsPanelMain
	{
		[CompilerGenerated]
		get
		{
			return this.m_a1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = ap;
			Panel val = this.m_a1;
			if (val != null)
			{
				((Control)val).remove_MouseEnter(eventHandler);
			}
			this.m_a1 = value;
			val = this.m_a1;
			if (val != null)
			{
				((Control)val).add_MouseEnter(eventHandler);
			}
		}
	}

	internal virtual Panel Panel11
	{
		[CompilerGenerated]
		get
		{
			return this.m_a2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			this.m_a2 = value;
		}
	}

	internal virtual PictureBox PictureBox30
	{
		[CompilerGenerated]
		get
		{
			return this.m_a3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			this.m_a3 = value;
		}
	}

	internal virtual Label Label24
	{
		[CompilerGenerated]
		get
		{
			return this.m_a4;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			this.m_a4 = value;
		}
	}

	internal virtual PictureBox PictureBox31
	{
		[CompilerGenerated]
		get
		{
			return this.m_a5;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			this.m_a5 = value;
		}
	}

	internal virtual Panel Panel18
	{
		[CompilerGenerated]
		get
		{
			return this.m_a6;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			this.m_a6 = value;
		}
	}

	internal virtual PictureBox PictureBox46
	{
		[CompilerGenerated]
		get
		{
			return this.m_a7;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			this.m_a7 = value;
		}
	}

	internal virtual Label Label33
	{
		[CompilerGenerated]
		get
		{
			return this.m_a8;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			this.m_a8 = value;
		}
	}

	internal virtual PictureBox PictureBox47
	{
		[CompilerGenerated]
		get
		{
			return this.m_a9;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			this.m_a9 = value;
		}
	}

	internal virtual Panel Panel10
	{
		[CompilerGenerated]
		get
		{
			return this.m_ba;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			this.m_ba = value;
		}
	}

	internal virtual PictureBox PictureBox38
	{
		[CompilerGenerated]
		get
		{
			return this.m_bb;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			this.m_bb = value;
		}
	}

	internal virtual Label Label29
	{
		[CompilerGenerated]
		get
		{
			return this.m_bc;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			this.m_bc = value;
		}
	}

	internal virtual PictureBox PictureBox39
	{
		[CompilerGenerated]
		get
		{
			return this.m_bd;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			this.m_bd = value;
		}
	}

	internal virtual Panel Panel12
	{
		[CompilerGenerated]
		get
		{
			return this.m_be;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			this.m_be = value;
		}
	}

	internal virtual PictureBox PictureBox32
	{
		[CompilerGenerated]
		get
		{
			return this.m_bf;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = dg;
			EventHandler eventHandler2 = df;
			EventHandler eventHandler3 = de;
			PictureBox val = this.m_bf;
			if (val != null)
			{
				((Control)val).remove_Click(eventHandler);
				((Control)val).remove_MouseEnter(eventHandler2);
				((Control)val).remove_MouseLeave(eventHandler3);
			}
			this.m_bf = value;
			val = this.m_bf;
			if (val != null)
			{
				((Control)val).add_Click(eventHandler);
				((Control)val).add_MouseEnter(eventHandler2);
				((Control)val).add_MouseLeave(eventHandler3);
			}
		}
	}

	internal virtual PictureBox PictureBox54
	{
		[CompilerGenerated]
		get
		{
			return this.m_bg;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			this.m_bg = value;
		}
	}

	internal virtual ImageList ImageList2
	{
		[CompilerGenerated]
		get
		{
			return this.m_bh;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			this.m_bh = value;
		}
	}

	internal virtual Panel Panel20
	{
		[CompilerGenerated]
		get
		{
			return this.m_bi;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			this.m_bi = value;
		}
	}

	internal virtual MaskedTextBox MaskedTextBox1
	{
		[CompilerGenerated]
		get
		{
			return this.m_bj;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			//IL_0007: Unknown result type (might be due to invalid IL or missing references)
			//IL_000d: Expected O, but got Unknown
			MouseEventHandler val = new MouseEventHandler(g);
			MaskedTextBox val2 = this.m_bj;
			if (val2 != null)
			{
				((TextBoxBase)val2).remove_MouseClick(val);
			}
			this.m_bj = value;
			val2 = this.m_bj;
			if (val2 != null)
			{
				((TextBoxBase)val2).add_MouseClick(val);
			}
		}
	}

	internal virtual Label TrialStatus
	{
		[CompilerGenerated]
		get
		{
			return this.m_bk;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			this.m_bk = value;
		}
	}

	internal virtual Label LicenseStatus
	{
		[CompilerGenerated]
		get
		{
			return this.m_bl;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			this.m_bl = value;
		}
	}

	private virtual Timer Timer1
	{
		[CompilerGenerated]
		get
		{
			return this.m_bm;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = c6;
			Timer val = this.m_bm;
			if (val != null)
			{
				val.remove_Tick(eventHandler);
			}
			this.m_bm = value;
			val = this.m_bm;
			if (val != null)
			{
				val.add_Tick(eventHandler);
			}
		}
	}

	internal virtual Panel Panel22
	{
		[CompilerGenerated]
		get
		{
			return this.m_bn;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			this.m_bn = value;
		}
	}

	internal virtual Label Label6
	{
		[CompilerGenerated]
		get
		{
			return this.m_bo;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			this.m_bo = value;
		}
	}

	internal virtual PictureBox PictureBox57
	{
		[CompilerGenerated]
		get
		{
			return this.m_bp;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = c5;
			PictureBox val = this.m_bp;
			if (val != null)
			{
				((Control)val).remove_Click(eventHandler);
			}
			this.m_bp = value;
			val = this.m_bp;
			if (val != null)
			{
				((Control)val).add_Click(eventHandler);
			}
		}
	}

	internal virtual Label Label36
	{
		[CompilerGenerated]
		get
		{
			return this.m_bq;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = c3;
			EventHandler eventHandler2 = ax;
			EventHandler eventHandler3 = aw;
			EventHandler eventHandler4 = av;
			Label val = this.m_bq;
			if (val != null)
			{
				((Control)val).remove_Click(eventHandler);
				((Control)val).remove_MouseEnter(eventHandler2);
				((Control)val).remove_MouseLeave(eventHandler3);
				((Control)val).remove_TextChanged(eventHandler4);
			}
			this.m_bq = value;
			val = this.m_bq;
			if (val != null)
			{
				((Control)val).add_Click(eventHandler);
				((Control)val).add_MouseEnter(eventHandler2);
				((Control)val).add_MouseLeave(eventHandler3);
				((Control)val).add_TextChanged(eventHandler4);
			}
		}
	}

	internal virtual ImageList ImageList3
	{
		[CompilerGenerated]
		get
		{
			return this.m_br;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			this.m_br = value;
		}
	}

	internal virtual Label Label38
	{
		[CompilerGenerated]
		get
		{
			return this.m_bs;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			this.m_bs = value;
		}
	}

	internal virtual Timer Timer2
	{
		[CompilerGenerated]
		get
		{
			return this.m_bt;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = cz;
			Timer val = this.m_bt;
			if (val != null)
			{
				val.remove_Tick(eventHandler);
			}
			this.m_bt = value;
			val = this.m_bt;
			if (val != null)
			{
				val.add_Tick(eventHandler);
			}
		}
	}

	internal virtual Timer Timer3
	{
		[CompilerGenerated]
		get
		{
			return this.m_bu;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = cy;
			Timer val = this.m_bu;
			if (val != null)
			{
				val.remove_Tick(eventHandler);
			}
			this.m_bu = value;
			val = this.m_bu;
			if (val != null)
			{
				val.add_Tick(eventHandler);
			}
		}
	}

	internal virtual Panel Panel33
	{
		[CompilerGenerated]
		get
		{
			return this.m_bv;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			this.m_bv = value;
		}
	}

	internal virtual Label Label50
	{
		[CompilerGenerated]
		get
		{
			return this.m_bw;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = cx;
			EventHandler eventHandler2 = cv;
			EventHandler eventHandler3 = ct;
			Label val = this.m_bw;
			if (val != null)
			{
				((Control)val).remove_Click(eventHandler);
				((Control)val).remove_MouseEnter(eventHandler2);
				((Control)val).remove_MouseLeave(eventHandler3);
			}
			this.m_bw = value;
			val = this.m_bw;
			if (val != null)
			{
				((Control)val).add_Click(eventHandler);
				((Control)val).add_MouseEnter(eventHandler2);
				((Control)val).add_MouseLeave(eventHandler3);
			}
		}
	}

	internal virtual PictureBox PictureBox77
	{
		[CompilerGenerated]
		get
		{
			return this.m_bx;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = cw;
			EventHandler eventHandler2 = cu;
			EventHandler eventHandler3 = cs;
			PictureBox val = this.m_bx;
			if (val != null)
			{
				((Control)val).remove_Click(eventHandler);
				((Control)val).remove_MouseEnter(eventHandler2);
				((Control)val).remove_MouseLeave(eventHandler3);
			}
			this.m_bx = value;
			val = this.m_bx;
			if (val != null)
			{
				((Control)val).add_Click(eventHandler);
				((Control)val).add_MouseEnter(eventHandler2);
				((Control)val).add_MouseLeave(eventHandler3);
			}
		}
	}

	internal virtual Panel AdvancedPanelMain
	{
		[CompilerGenerated]
		get
		{
			return this.m_by;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = ao;
			Panel val = this.m_by;
			if (val != null)
			{
				((Control)val).remove_MouseEnter(eventHandler);
			}
			this.m_by = value;
			val = this.m_by;
			if (val != null)
			{
				((Control)val).add_MouseEnter(eventHandler);
			}
		}
	}

	internal virtual Panel Panel23
	{
		[CompilerGenerated]
		get
		{
			return this.m_bz;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = t;
			Panel val = this.m_bz;
			if (val != null)
			{
				((Control)val).remove_VisibleChanged(eventHandler);
			}
			this.m_bz = value;
			val = this.m_bz;
			if (val != null)
			{
				((Control)val).add_VisibleChanged(eventHandler);
			}
		}
	}

	internal virtual ContextMenuStrip ContextMenuStrip2
	{
		[CompilerGenerated]
		get
		{
			return this.m_b0;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			this.m_b0 = value;
		}
	}

	internal virtual ToolStripMenuItem SelectAllToolStripMenuItem
	{
		[CompilerGenerated]
		get
		{
			return this.m_b1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			this.m_b1 = value;
		}
	}

	internal virtual Label Label42
	{
		[CompilerGenerated]
		get
		{
			return this.m_b2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = cr;
			EventHandler eventHandler2 = az;
			EventHandler eventHandler3 = ay;
			EventHandler eventHandler4 = a;
			Label val = this.m_b2;
			if (val != null)
			{
				((Control)val).remove_Click(eventHandler);
				((Control)val).remove_MouseEnter(eventHandler2);
				((Control)val).remove_MouseLeave(eventHandler3);
				((Control)val).remove_VisibleChanged(eventHandler4);
			}
			this.m_b2 = value;
			val = this.m_b2;
			if (val != null)
			{
				((Control)val).add_Click(eventHandler);
				((Control)val).add_MouseEnter(eventHandler2);
				((Control)val).add_MouseLeave(eventHandler3);
				((Control)val).add_VisibleChanged(eventHandler4);
			}
		}
	}

	internal virtual Timer Timer4
	{
		[CompilerGenerated]
		get
		{
			return this.m_b3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = cq;
			Timer val = this.m_b3;
			if (val != null)
			{
				val.remove_Tick(eventHandler);
			}
			this.m_b3 = value;
			val = this.m_b3;
			if (val != null)
			{
				val.add_Tick(eventHandler);
			}
		}
	}

	internal virtual PictureBox PictureBox62
	{
		[CompilerGenerated]
		get
		{
			return this.m_b4;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = cn;
			PictureBox val = this.m_b4;
			if (val != null)
			{
				((Control)val).remove_Click(eventHandler);
			}
			this.m_b4 = value;
			val = this.m_b4;
			if (val != null)
			{
				((Control)val).add_Click(eventHandler);
			}
		}
	}

	internal virtual PictureBox PictureBox61
	{
		[CompilerGenerated]
		get
		{
			return this.m_b5;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = co;
			PictureBox val = this.m_b5;
			if (val != null)
			{
				((Control)val).remove_Click(eventHandler);
			}
			this.m_b5 = value;
			val = this.m_b5;
			if (val != null)
			{
				((Control)val).add_Click(eventHandler);
			}
		}
	}

	internal virtual PictureBox PictureBox60
	{
		[CompilerGenerated]
		get
		{
			return this.m_b6;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = cp;
			PictureBox val = this.m_b6;
			if (val != null)
			{
				((Control)val).remove_Click(eventHandler);
			}
			this.m_b6 = value;
			val = this.m_b6;
			if (val != null)
			{
				((Control)val).add_Click(eventHandler);
			}
		}
	}

	internal virtual PictureBox PictureBox1
	{
		[CompilerGenerated]
		get
		{
			return this.m_b7;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			this.m_b7 = value;
		}
	}

	internal virtual PictureBox PictureBox63
	{
		[CompilerGenerated]
		get
		{
			return this.m_b8;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = cm;
			PictureBox val = this.m_b8;
			if (val != null)
			{
				((Control)val).remove_Click(eventHandler);
			}
			this.m_b8 = value;
			val = this.m_b8;
			if (val != null)
			{
				((Control)val).add_Click(eventHandler);
			}
		}
	}

	internal virtual Label Label8
	{
		[CompilerGenerated]
		get
		{
			return this.m_b9;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			this.m_b9 = value;
		}
	}

	internal virtual Panel Panel27
	{
		[CompilerGenerated]
		get
		{
			return this.m_ca;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			//IL_0007: Unknown result type (might be due to invalid IL or missing references)
			//IL_000d: Expected O, but got Unknown
			MouseEventHandler val = new MouseEventHandler(e);
			EventHandler eventHandler = bo;
			EventHandler eventHandler2 = bn;
			Panel val2 = this.m_ca;
			if (val2 != null)
			{
				((Control)val2).remove_MouseClick(val);
				((Control)val2).remove_MouseEnter(eventHandler);
				((Control)val2).remove_MouseLeave(eventHandler2);
			}
			this.m_ca = value;
			val2 = this.m_ca;
			if (val2 != null)
			{
				((Control)val2).add_MouseClick(val);
				((Control)val2).add_MouseEnter(eventHandler);
				((Control)val2).add_MouseLeave(eventHandler2);
			}
		}
	}

	internal virtual PictureBox PictureBox64
	{
		[CompilerGenerated]
		get
		{
			return this.m_cb;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = bm;
			EventHandler eventHandler2 = bk;
			EventHandler eventHandler3 = bj;
			PictureBox val = this.m_cb;
			if (val != null)
			{
				((Control)val).remove_Click(eventHandler);
				((Control)val).remove_MouseEnter(eventHandler2);
				((Control)val).remove_MouseLeave(eventHandler3);
			}
			this.m_cb = value;
			val = this.m_cb;
			if (val != null)
			{
				((Control)val).add_Click(eventHandler);
				((Control)val).add_MouseEnter(eventHandler2);
				((Control)val).add_MouseLeave(eventHandler3);
			}
		}
	}

	internal virtual Panel Panel26
	{
		[CompilerGenerated]
		get
		{
			return this.m_cc;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			//IL_0007: Unknown result type (might be due to invalid IL or missing references)
			//IL_000d: Expected O, but got Unknown
			MouseEventHandler val = new MouseEventHandler(d);
			EventHandler eventHandler = bd;
			EventHandler eventHandler2 = bc;
			Panel val2 = this.m_cc;
			if (val2 != null)
			{
				((Control)val2).remove_MouseClick(val);
				((Control)val2).remove_MouseEnter(eventHandler);
				((Control)val2).remove_MouseLeave(eventHandler2);
			}
			this.m_cc = value;
			val2 = this.m_cc;
			if (val2 != null)
			{
				((Control)val2).add_MouseClick(val);
				((Control)val2).add_MouseEnter(eventHandler);
				((Control)val2).add_MouseLeave(eventHandler2);
			}
		}
	}

	internal virtual PictureBox PictureBox50
	{
		[CompilerGenerated]
		get
		{
			return this.m_cd;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = bg;
			EventHandler eventHandler2 = bb;
			EventHandler eventHandler3 = ba;
			PictureBox val = this.m_cd;
			if (val != null)
			{
				((Control)val).remove_Click(eventHandler);
				((Control)val).remove_MouseEnter(eventHandler2);
				((Control)val).remove_MouseLeave(eventHandler3);
			}
			this.m_cd = value;
			val = this.m_cd;
			if (val != null)
			{
				((Control)val).add_Click(eventHandler);
				((Control)val).add_MouseEnter(eventHandler2);
				((Control)val).add_MouseLeave(eventHandler3);
			}
		}
	}

	internal virtual Panel Panel25
	{
		[CompilerGenerated]
		get
		{
			return this.m_ce;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			//IL_0007: Unknown result type (might be due to invalid IL or missing references)
			//IL_000d: Expected O, but got Unknown
			MouseEventHandler val = new MouseEventHandler(c);
			EventHandler eventHandler = a7;
			EventHandler eventHandler2 = a4;
			Panel val2 = this.m_ce;
			if (val2 != null)
			{
				((Control)val2).remove_MouseClick(val);
				((Control)val2).remove_MouseEnter(eventHandler);
				((Control)val2).remove_MouseLeave(eventHandler2);
			}
			this.m_ce = value;
			val2 = this.m_ce;
			if (val2 != null)
			{
				((Control)val2).add_MouseClick(val);
				((Control)val2).add_MouseEnter(eventHandler);
				((Control)val2).add_MouseLeave(eventHandler2);
			}
		}
	}

	internal virtual PictureBox PictureBox53
	{
		[CompilerGenerated]
		get
		{
			return this.m_cf;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = a9;
			EventHandler eventHandler2 = a6;
			EventHandler eventHandler3 = a3;
			PictureBox val = this.m_cf;
			if (val != null)
			{
				((Control)val).remove_Click(eventHandler);
				((Control)val).remove_MouseEnter(eventHandler2);
				((Control)val).remove_MouseLeave(eventHandler3);
			}
			this.m_cf = value;
			val = this.m_cf;
			if (val != null)
			{
				((Control)val).add_Click(eventHandler);
				((Control)val).add_MouseEnter(eventHandler2);
				((Control)val).add_MouseLeave(eventHandler3);
			}
		}
	}

	internal virtual Label Label52
	{
		[CompilerGenerated]
		get
		{
			return this.m_cg;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = bl;
			EventHandler eventHandler2 = bi;
			EventHandler eventHandler3 = bh;
			Label val = this.m_cg;
			if (val != null)
			{
				((Control)val).remove_Click(eventHandler);
				((Control)val).remove_MouseEnter(eventHandler2);
				((Control)val).remove_MouseLeave(eventHandler3);
			}
			this.m_cg = value;
			val = this.m_cg;
			if (val != null)
			{
				((Control)val).add_Click(eventHandler);
				((Control)val).add_MouseEnter(eventHandler2);
				((Control)val).add_MouseLeave(eventHandler3);
			}
		}
	}

	internal virtual Label Label51
	{
		[CompilerGenerated]
		get
		{
			return this.m_ch;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = br;
			EventHandler eventHandler2 = bf;
			EventHandler eventHandler3 = be;
			Label val = this.m_ch;
			if (val != null)
			{
				((Control)val).remove_Click(eventHandler);
				((Control)val).remove_MouseEnter(eventHandler2);
				((Control)val).remove_MouseLeave(eventHandler3);
			}
			this.m_ch = value;
			val = this.m_ch;
			if (val != null)
			{
				((Control)val).add_Click(eventHandler);
				((Control)val).add_MouseEnter(eventHandler2);
				((Control)val).add_MouseLeave(eventHandler3);
			}
		}
	}

	internal virtual Label Label44
	{
		[CompilerGenerated]
		get
		{
			return this.m_ci;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = a8;
			EventHandler eventHandler2 = a5;
			EventHandler eventHandler3 = a2;
			Label val = this.m_ci;
			if (val != null)
			{
				((Control)val).remove_Click(eventHandler);
				((Control)val).remove_MouseEnter(eventHandler2);
				((Control)val).remove_MouseLeave(eventHandler3);
			}
			this.m_ci = value;
			val = this.m_ci;
			if (val != null)
			{
				((Control)val).add_Click(eventHandler);
				((Control)val).add_MouseEnter(eventHandler2);
				((Control)val).add_MouseLeave(eventHandler3);
			}
		}
	}

	internal virtual PictureBox PictureBox65
	{
		[CompilerGenerated]
		get
		{
			return this.m_cj;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			this.m_cj = value;
		}
	}

	internal virtual Panel Panel28
	{
		[CompilerGenerated]
		get
		{
			return this.m_ck;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			this.m_ck = value;
		}
	}

	internal virtual PictureBox PictureBox67
	{
		[CompilerGenerated]
		get
		{
			return this.m_cl;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			this.m_cl = value;
		}
	}

	internal virtual Label Label37
	{
		[CompilerGenerated]
		get
		{
			return this.m_cm;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = bq;
			EventHandler eventHandler2 = a1;
			EventHandler eventHandler3 = a0;
			Label val = this.m_cm;
			if (val != null)
			{
				((Control)val).remove_Click(eventHandler);
				((Control)val).remove_MouseEnter(eventHandler2);
				((Control)val).remove_MouseLeave(eventHandler3);
			}
			this.m_cm = value;
			val = this.m_cm;
			if (val != null)
			{
				((Control)val).add_Click(eventHandler);
				((Control)val).add_MouseEnter(eventHandler2);
				((Control)val).add_MouseLeave(eventHandler3);
			}
		}
	}

	internal virtual Panel Panel34
	{
		[CompilerGenerated]
		get
		{
			return this.m_cn;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			this.m_cn = value;
		}
	}

	internal virtual Label Label55
	{
		[CompilerGenerated]
		get
		{
			return this.m_co;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = ak;
			Label val = this.m_co;
			if (val != null)
			{
				((Control)val).remove_TextChanged(eventHandler);
			}
			this.m_co = value;
			val = this.m_co;
			if (val != null)
			{
				((Control)val).add_TextChanged(eventHandler);
			}
		}
	}

	internal virtual Label Label56
	{
		[CompilerGenerated]
		get
		{
			return this.m_cp;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = al;
			Label val = this.m_cp;
			if (val != null)
			{
				((Control)val).remove_TextChanged(eventHandler);
			}
			this.m_cp = value;
			val = this.m_cp;
			if (val != null)
			{
				((Control)val).add_TextChanged(eventHandler);
			}
		}
	}

	internal virtual PictureBox PictureBox66
	{
		[CompilerGenerated]
		get
		{
			return this.m_cq;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = bp;
			PictureBox val = this.m_cq;
			if (val != null)
			{
				((Control)val).remove_Click(eventHandler);
			}
			this.m_cq = value;
			val = this.m_cq;
			if (val != null)
			{
				((Control)val).add_Click(eventHandler);
			}
		}
	}

	internal virtual Label Label25
	{
		[CompilerGenerated]
		get
		{
			return this.m_cr;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			this.m_cr = value;
		}
	}

	internal virtual Label Label35
	{
		[CompilerGenerated]
		get
		{
			return this.m_cs;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = aj;
			Label val = this.m_cs;
			if (val != null)
			{
				((Control)val).remove_TextChanged(eventHandler);
			}
			this.m_cs = value;
			val = this.m_cs;
			if (val != null)
			{
				((Control)val).add_TextChanged(eventHandler);
			}
		}
	}

	internal virtual PictureBox PictureBox68
	{
		[CompilerGenerated]
		get
		{
			return this.m_ct;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			this.m_ct = value;
		}
	}

	internal virtual Panel Panel24
	{
		[CompilerGenerated]
		get
		{
			return this.m_cu;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			this.m_cu = value;
		}
	}

	internal virtual Panel Panel35
	{
		[CompilerGenerated]
		get
		{
			return this.m_cv;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			this.m_cv = value;
		}
	}

	internal virtual Label Label43
	{
		[CompilerGenerated]
		get
		{
			return this.m_cw;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = s;
			Label val = this.m_cw;
			if (val != null)
			{
				((Control)val).remove_Click(eventHandler);
			}
			this.m_cw = value;
			val = this.m_cw;
			if (val != null)
			{
				((Control)val).add_Click(eventHandler);
			}
		}
	}

	internal virtual ListBox ListBox1
	{
		[CompilerGenerated]
		get
		{
			return this.m_cx;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			//IL_0007: Unknown result type (might be due to invalid IL or missing references)
			//IL_000d: Expected O, but got Unknown
			//IL_0014: Unknown result type (might be due to invalid IL or missing references)
			//IL_001a: Expected O, but got Unknown
			//IL_0021: Unknown result type (might be due to invalid IL or missing references)
			//IL_0027: Expected O, but got Unknown
			//IL_002e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0034: Expected O, but got Unknown
			KeyEventHandler val = new KeyEventHandler(c);
			MouseEventHandler val2 = new MouseEventHandler(b);
			DrawItemEventHandler val3 = new DrawItemEventHandler(a);
			MouseEventHandler val4 = new MouseEventHandler(a);
			ListBox val5 = this.m_cx;
			if (val5 != null)
			{
				((Control)val5).remove_KeyDown(val);
				((Control)val5).remove_MouseMove(val2);
				val5.remove_DrawItem(val3);
				((Control)val5).remove_MouseDown(val4);
			}
			this.m_cx = value;
			val5 = this.m_cx;
			if (val5 != null)
			{
				((Control)val5).add_KeyDown(val);
				((Control)val5).add_MouseMove(val2);
				val5.add_DrawItem(val3);
				((Control)val5).add_MouseDown(val4);
			}
		}
	}

	internal virtual ContextMenuStrip ContextMenuStrip3
	{
		[CompilerGenerated]
		get
		{
			return this.m_cy;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			CancelEventHandler cancelEventHandler = c;
			ContextMenuStrip val = this.m_cy;
			if (val != null)
			{
				((ToolStripDropDown)val).remove_Opening(cancelEventHandler);
			}
			this.m_cy = value;
			val = this.m_cy;
			if (val != null)
			{
				((ToolStripDropDown)val).add_Opening(cancelEventHandler);
			}
		}
	}

	internal virtual ToolStripMenuItem ToolStripMenuItem1
	{
		[CompilerGenerated]
		get
		{
			return this.m_cz;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = au;
			ToolStripMenuItem val = this.m_cz;
			if (val != null)
			{
				((ToolStripItem)val).remove_Click(eventHandler);
			}
			this.m_cz = value;
			val = this.m_cz;
			if (val != null)
			{
				((ToolStripItem)val).add_Click(eventHandler);
			}
		}
	}

	internal virtual ToolStripMenuItem RemoveFolderToolStripMenuItem
	{
		[CompilerGenerated]
		get
		{
			return this.m_c0;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = at;
			ToolStripMenuItem val = this.m_c0;
			if (val != null)
			{
				((ToolStripItem)val).remove_Click(eventHandler);
			}
			this.m_c0 = value;
			val = this.m_c0;
			if (val != null)
			{
				((ToolStripItem)val).add_Click(eventHandler);
			}
		}
	}

	internal virtual FolderBrowserDialog FolderBrowserDialog1
	{
		[CompilerGenerated]
		get
		{
			return this.m_c1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			this.m_c1 = value;
		}
	}

	internal virtual ImageList ImageList4
	{
		[CompilerGenerated]
		get
		{
			return this.m_c2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			this.m_c2 = value;
		}
	}

	internal virtual PictureBox PictureBox78
	{
		[CompilerGenerated]
		get
		{
			return this.m_c3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = r;
			PictureBox val = this.m_c3;
			if (val != null)
			{
				((Control)val).remove_Click(eventHandler);
			}
			this.m_c3 = value;
			val = this.m_c3;
			if (val != null)
			{
				((Control)val).add_Click(eventHandler);
			}
		}
	}

	internal virtual Panel Panel36
	{
		[CompilerGenerated]
		get
		{
			return this.m_c4;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			this.m_c4 = value;
		}
	}

	internal virtual Label Label64
	{
		[CompilerGenerated]
		get
		{
			return this.m_c5;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = ag;
			EventHandler eventHandler2 = af;
			EventHandler eventHandler3 = ae;
			Label val = this.m_c5;
			if (val != null)
			{
				((Control)val).remove_Click(eventHandler);
				((Control)val).remove_MouseEnter(eventHandler2);
				((Control)val).remove_MouseLeave(eventHandler3);
			}
			this.m_c5 = value;
			val = this.m_c5;
			if (val != null)
			{
				((Control)val).add_Click(eventHandler);
				((Control)val).add_MouseEnter(eventHandler2);
				((Control)val).add_MouseLeave(eventHandler3);
			}
		}
	}

	internal virtual PictureBox PictureBox91
	{
		[CompilerGenerated]
		get
		{
			return this.m_c6;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = ad;
			EventHandler eventHandler2 = ac;
			EventHandler eventHandler3 = ab;
			PictureBox val = this.m_c6;
			if (val != null)
			{
				((Control)val).remove_Click(eventHandler);
				((Control)val).remove_MouseEnter(eventHandler2);
				((Control)val).remove_MouseLeave(eventHandler3);
			}
			this.m_c6 = value;
			val = this.m_c6;
			if (val != null)
			{
				((Control)val).add_Click(eventHandler);
				((Control)val).add_MouseEnter(eventHandler2);
				((Control)val).add_MouseLeave(eventHandler3);
			}
		}
	}

	internal virtual Panel LogPanelMain
	{
		[CompilerGenerated]
		get
		{
			return this.m_c7;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			this.m_c7 = value;
		}
	}

	internal virtual DataGridView DataGridView1
	{
		[CompilerGenerated]
		get
		{
			return this.m_c8;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			//IL_0007: Unknown result type (might be due to invalid IL or missing references)
			//IL_000d: Expected O, but got Unknown
			//IL_0021: Unknown result type (might be due to invalid IL or missing references)
			//IL_0027: Expected O, but got Unknown
			//IL_002e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0034: Expected O, but got Unknown
			DataGridViewCellEventHandler val = new DataGridViewCellEventHandler(a);
			EventHandler eventHandler = aa;
			KeyEventHandler val2 = new KeyEventHandler(b);
			DataGridViewCellMouseEventHandler val3 = new DataGridViewCellMouseEventHandler(a);
			DataGridView val4 = this.m_c8;
			if (val4 != null)
			{
				val4.remove_RowEnter(val);
				val4.remove_SelectionChanged(eventHandler);
				((Control)val4).remove_KeyDown(val2);
				val4.remove_CellMouseDown(val3);
			}
			this.m_c8 = value;
			val4 = this.m_c8;
			if (val4 != null)
			{
				val4.add_RowEnter(val);
				val4.add_SelectionChanged(eventHandler);
				((Control)val4).add_KeyDown(val2);
				val4.add_CellMouseDown(val3);
			}
		}
	}

	internal virtual TextBox TextBox8
	{
		[CompilerGenerated]
		get
		{
			return this.m_c9;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			//IL_0007: Unknown result type (might be due to invalid IL or missing references)
			//IL_000d: Expected O, but got Unknown
			KeyEventHandler val = new KeyEventHandler(a);
			TextBox val2 = this.m_c9;
			if (val2 != null)
			{
				((Control)val2).remove_KeyDown(val);
			}
			this.m_c9 = value;
			val2 = this.m_c9;
			if (val2 != null)
			{
				((Control)val2).add_KeyDown(val);
			}
		}
	}

	internal virtual ImageList ImageList5
	{
		[CompilerGenerated]
		get
		{
			return this.m_da;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			this.m_da = value;
		}
	}

	internal virtual Panel Panel4
	{
		[CompilerGenerated]
		get
		{
			return this.m_db;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			this.m_db = value;
		}
	}

	internal virtual PictureBox PictureBox4
	{
		[CompilerGenerated]
		get
		{
			return this.m_dc;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = q;
			PictureBox val = this.m_dc;
			if (val != null)
			{
				((Control)val).remove_Click(eventHandler);
			}
			this.m_dc = value;
			val = this.m_dc;
			if (val != null)
			{
				((Control)val).add_Click(eventHandler);
			}
		}
	}

	internal virtual Label Label3
	{
		[CompilerGenerated]
		get
		{
			return this.m_dd;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = p;
			Label val = this.m_dd;
			if (val != null)
			{
				((Control)val).remove_Click(eventHandler);
			}
			this.m_dd = value;
			val = this.m_dd;
			if (val != null)
			{
				((Control)val).add_Click(eventHandler);
			}
		}
	}

	internal virtual Panel Panel6
	{
		[CompilerGenerated]
		get
		{
			return this.m_de;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = i;
			Panel val = this.m_de;
			if (val != null)
			{
				((Control)val).remove_Click(eventHandler);
			}
			this.m_de = value;
			val = this.m_de;
			if (val != null)
			{
				((Control)val).add_Click(eventHandler);
			}
		}
	}

	internal virtual Label Label7
	{
		[CompilerGenerated]
		get
		{
			return this.m_df;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = v;
			Label val = this.m_df;
			if (val != null)
			{
				((Control)val).remove_Click(eventHandler);
			}
			this.m_df = value;
			val = this.m_df;
			if (val != null)
			{
				((Control)val).add_Click(eventHandler);
			}
		}
	}

	internal virtual Panel Panel8
	{
		[CompilerGenerated]
		get
		{
			return this.m_dg;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = j;
			Panel val = this.m_dg;
			if (val != null)
			{
				((Control)val).remove_Click(eventHandler);
			}
			this.m_dg = value;
			val = this.m_dg;
			if (val != null)
			{
				((Control)val).add_Click(eventHandler);
			}
		}
	}

	internal virtual Label Label9
	{
		[CompilerGenerated]
		get
		{
			return this.m_dh;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = k;
			Label val = this.m_dh;
			if (val != null)
			{
				((Control)val).remove_Click(eventHandler);
			}
			this.m_dh = value;
			val = this.m_dh;
			if (val != null)
			{
				((Control)val).add_Click(eventHandler);
			}
		}
	}

	internal virtual Panel Panel13
	{
		[CompilerGenerated]
		get
		{
			return this.m_di;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = h;
			Panel val = this.m_di;
			if (val != null)
			{
				((Control)val).remove_Click(eventHandler);
			}
			this.m_di = value;
			val = this.m_di;
			if (val != null)
			{
				((Control)val).add_Click(eventHandler);
			}
		}
	}

	internal virtual Label Label10
	{
		[CompilerGenerated]
		get
		{
			return this.m_dj;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = w;
			Label val = this.m_dj;
			if (val != null)
			{
				((Control)val).remove_Click(eventHandler);
			}
			this.m_dj = value;
			val = this.m_dj;
			if (val != null)
			{
				((Control)val).add_Click(eventHandler);
			}
		}
	}

	internal virtual Label Label26
	{
		[CompilerGenerated]
		get
		{
			return this.m_dk;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = u;
			Label val = this.m_dk;
			if (val != null)
			{
				((Control)val).remove_Click(eventHandler);
			}
			this.m_dk = value;
			val = this.m_dk;
			if (val != null)
			{
				((Control)val).add_Click(eventHandler);
			}
		}
	}

	internal virtual Label Label23
	{
		[CompilerGenerated]
		get
		{
			return this.m_dl;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = l;
			Label val = this.m_dl;
			if (val != null)
			{
				((Control)val).remove_Click(eventHandler);
			}
			this.m_dl = value;
			val = this.m_dl;
			if (val != null)
			{
				((Control)val).add_Click(eventHandler);
			}
		}
	}

	internal virtual Label Label12
	{
		[CompilerGenerated]
		get
		{
			return this.m_dm;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = x;
			Label val = this.m_dm;
			if (val != null)
			{
				((Control)val).remove_Click(eventHandler);
			}
			this.m_dm = value;
			val = this.m_dm;
			if (val != null)
			{
				((Control)val).add_Click(eventHandler);
			}
		}
	}

	internal virtual Label Label13
	{
		[CompilerGenerated]
		get
		{
			return this.m_dn;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			this.m_dn = value;
		}
	}

	internal virtual Label Label14
	{
		[CompilerGenerated]
		get
		{
			return this.m_do;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			this.m_do = value;
		}
	}

	internal virtual Label Label16
	{
		[CompilerGenerated]
		get
		{
			return this.m_dp;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			this.m_dp = value;
		}
	}

	internal virtual Label Label18
	{
		[CompilerGenerated]
		get
		{
			return this.m_dq;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			this.m_dq = value;
		}
	}

	internal virtual Label Label17
	{
		[CompilerGenerated]
		get
		{
			return this.m_dr;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			this.m_dr = value;
		}
	}

	internal virtual DataGridView DataGridView2
	{
		[CompilerGenerated]
		get
		{
			return this.m_ds;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			//IL_0007: Unknown result type (might be due to invalid IL or missing references)
			//IL_000d: Expected O, but got Unknown
			DataGridViewCellMouseEventHandler val = new DataGridViewCellMouseEventHandler(b);
			DataGridView val2 = this.m_ds;
			if (val2 != null)
			{
				val2.remove_CellMouseDown(val);
			}
			this.m_ds = value;
			val2 = this.m_ds;
			if (val2 != null)
			{
				val2.add_CellMouseDown(val);
			}
		}
	}

	internal virtual ContextMenuStrip ContextMenuStrip4
	{
		[CompilerGenerated]
		get
		{
			return this.m_dt;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			CancelEventHandler cancelEventHandler = b;
			ContextMenuStrip val = this.m_dt;
			if (val != null)
			{
				((ToolStripDropDown)val).remove_Opening(cancelEventHandler);
			}
			this.m_dt = value;
			val = this.m_dt;
			if (val != null)
			{
				((ToolStripDropDown)val).add_Opening(cancelEventHandler);
			}
		}
	}

	internal virtual ToolStripMenuItem ToolStripMenuItem2
	{
		[CompilerGenerated]
		get
		{
			return this.m_du;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = o;
			ToolStripMenuItem val = this.m_du;
			if (val != null)
			{
				((ToolStripItem)val).remove_Click(eventHandler);
			}
			this.m_du = value;
			val = this.m_du;
			if (val != null)
			{
				((ToolStripItem)val).add_Click(eventHandler);
			}
		}
	}

	internal virtual ToolStripMenuItem ToolStripMenuItem3
	{
		[CompilerGenerated]
		get
		{
			return this.m_dv;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = n;
			ToolStripMenuItem val = this.m_dv;
			if (val != null)
			{
				((ToolStripItem)val).remove_Click(eventHandler);
			}
			this.m_dv = value;
			val = this.m_dv;
			if (val != null)
			{
				((ToolStripItem)val).add_Click(eventHandler);
			}
		}
	}

	internal virtual ToolStripSeparator ToolStripSeparator1
	{
		[CompilerGenerated]
		get
		{
			return this.m_dw;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			this.m_dw = value;
		}
	}

	internal virtual ToolStripMenuItem ToolStripMenuItem4
	{
		[CompilerGenerated]
		get
		{
			return this.m_dx;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = m;
			ToolStripMenuItem val = this.m_dx;
			if (val != null)
			{
				((ToolStripItem)val).remove_Click(eventHandler);
			}
			this.m_dx = value;
			val = this.m_dx;
			if (val != null)
			{
				((ToolStripItem)val).add_Click(eventHandler);
			}
		}
	}

	internal virtual ContextMenuStrip ContextMenuStrip5
	{
		[CompilerGenerated]
		get
		{
			return this.m_dy;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			CancelEventHandler cancelEventHandler = a;
			ContextMenuStrip val = this.m_dy;
			if (val != null)
			{
				((ToolStripDropDown)val).remove_Opening(cancelEventHandler);
			}
			this.m_dy = value;
			val = this.m_dy;
			if (val != null)
			{
				((ToolStripDropDown)val).add_Opening(cancelEventHandler);
			}
		}
	}

	internal virtual Panel SmartScanPanelMain
	{
		[CompilerGenerated]
		get
		{
			return this.m_dz;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			this.m_dz = value;
		}
	}

	internal virtual Label Label15
	{
		[CompilerGenerated]
		get
		{
			return this.m_d0;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			this.m_d0 = value;
		}
	}

	internal virtual DataGridViewTextBoxColumn DataGridViewTextBoxColumn2
	{
		[CompilerGenerated]
		get
		{
			return this.m_d1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			this.m_d1 = value;
		}
	}

	internal virtual DataGridViewTextBoxColumn DataGridViewTextBoxColumn4
	{
		[CompilerGenerated]
		get
		{
			return this.m_d2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			this.m_d2 = value;
		}
	}

	internal virtual DataGridViewTextBoxColumn DataGridViewTextBoxColumn3
	{
		[CompilerGenerated]
		get
		{
			return this.m_d3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			this.m_d3 = value;
		}
	}

	internal virtual ToolStripMenuItem ClearToolStripMenuItem
	{
		[CompilerGenerated]
		get
		{
			return d4;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = g;
			ToolStripMenuItem val = d4;
			if (val != null)
			{
				((ToolStripItem)val).remove_Click(eventHandler);
			}
			d4 = value;
			val = d4;
			if (val != null)
			{
				((ToolStripItem)val).add_Click(eventHandler);
			}
		}
	}

	internal virtual ToolStripMenuItem WipeAllFilesToolStripMenuItem
	{
		[CompilerGenerated]
		get
		{
			return d5;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = f;
			ToolStripMenuItem val = d5;
			if (val != null)
			{
				((ToolStripItem)val).remove_Click(eventHandler);
			}
			d5 = value;
			val = d5;
			if (val != null)
			{
				((ToolStripItem)val).add_Click(eventHandler);
			}
		}
	}

	internal virtual ToolStripSeparator ToolStripSeparator2
	{
		[CompilerGenerated]
		get
		{
			return d6;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			d6 = value;
		}
	}

	internal virtual ToolStripMenuItem ToolStripMenuItem5
	{
		[CompilerGenerated]
		get
		{
			return d7;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = e;
			ToolStripMenuItem val = d7;
			if (val != null)
			{
				((ToolStripItem)val).remove_Click(eventHandler);
			}
			d7 = value;
			val = d7;
			if (val != null)
			{
				((ToolStripItem)val).add_Click(eventHandler);
			}
		}
	}

	internal virtual ToolStripSeparator ToolStripSeparator3
	{
		[CompilerGenerated]
		get
		{
			return d8;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			d8 = value;
		}
	}

	internal virtual TextBox TextBox1
	{
		[CompilerGenerated]
		get
		{
			return d9;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			//IL_0014: Unknown result type (might be due to invalid IL or missing references)
			//IL_001a: Expected O, but got Unknown
			EventHandler eventHandler = c;
			KeyPressEventHandler val = new KeyPressEventHandler(a);
			TextBox val2 = d9;
			if (val2 != null)
			{
				((Control)val2).remove_TextChanged(eventHandler);
				((Control)val2).remove_KeyPress(val);
			}
			d9 = value;
			val2 = d9;
			if (val2 != null)
			{
				((Control)val2).add_TextChanged(eventHandler);
				((Control)val2).add_KeyPress(val);
			}
		}
	}

	internal virtual Label Label19
	{
		[CompilerGenerated]
		get
		{
			return ea;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			ea = value;
		}
	}

	internal virtual Button Button2
	{
		[CompilerGenerated]
		get
		{
			return eb;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = d;
			Button val = eb;
			if (val != null)
			{
				((Control)val).remove_Click(eventHandler);
			}
			eb = value;
			val = eb;
			if (val != null)
			{
				((Control)val).add_Click(eventHandler);
			}
		}
	}

	internal virtual Button Button1
	{
		[CompilerGenerated]
		get
		{
			return ec;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = b;
			Button val = ec;
			if (val != null)
			{
				((Control)val).remove_Click(eventHandler);
			}
			ec = value;
			val = ec;
			if (val != null)
			{
				((Control)val).add_Click(eventHandler);
			}
		}
	}

	internal virtual DataGridViewImageColumn Column1
	{
		[CompilerGenerated]
		get
		{
			return ed;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			ed = value;
		}
	}

	internal virtual DataGridViewTextBoxColumn Level
	{
		[CompilerGenerated]
		get
		{
			return ee;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			ee = value;
		}
	}

	internal virtual DataGridViewTextBoxColumn Column3
	{
		[CompilerGenerated]
		get
		{
			return ef;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			ef = value;
		}
	}

	internal virtual DataGridViewTextBoxColumn Column2
	{
		[CompilerGenerated]
		get
		{
			return eg;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			eg = value;
		}
	}

	internal virtual DataGridViewTextBoxColumn Column4
	{
		[CompilerGenerated]
		get
		{
			return eh;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			eh = value;
		}
	}

	[DllImport("user32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern void ReleaseCapture();

	[DllImport("user32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern void SendMessageA(int A_0, int A_1, int A_2, int A_3);

	[DllImport("kernel32.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern bool Beep(int freq, int duration);

	public int ShowWindowAsync(IntPtr hWnd, int swCommand)
	{
		return 0;
	}

	public void MaxSound()
	{
		int num = 1;
		do
		{
			SendMessageA((int)((Control)this).get_Handle(), 793, 197266, 655360);
			num = checked(num + 1);
		}
		while (num <= 100);
	}

	public Form1()
	{
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Expected O, but got Unknown
		//IL_010f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0119: Expected O, but got Unknown
		//IL_0121: Unknown result type (might be due to invalid IL or missing references)
		//IL_012b: Expected O, but got Unknown
		((Form)this).add_Load((EventHandler)d3);
		((Control)this).add_MouseMove(new MouseEventHandler(i));
		((Form)this).add_Closing((CancelEventHandler)e);
		((Control)this).add_MouseEnter((EventHandler)@as);
		this.m_a = new Form2();
		WinStart = false;
		CredentalRequired = false;
		DisableTraps = false;
		DisableRenamesScan = false;
		MailOK = false;
		AppdataExec = false;
		ArchiveExec = false;
		this.m_q = default(DB);
		DoDatabaseVersion = false;
		ServerVer = "";
		this.m_r = false;
		this.m_t = true;
		DoLic = false;
		this.m_u = true;
		this.m_v = -1;
		ENG = false;
		DoUpdater = false;
		ReadedDatabase = "";
		DoUpdate = false;
		SCStatus = "";
		LogRefs = false;
		this.m_w = "";
		this.m_x = new SolidBrush(Color.FromKnownColor(KnownColor.Control));
		this.m_y = new SolidBrush(Color.FromKnownColor(KnownColor.ControlText));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)2);
		b();
	}

	public void LoadSettings()
	{
		int num = default(int);
		try
		{
			WinStart = Conversions.ToBoolean(Registry.LocalMachine.CreateSubKey("SOFTWARE\\Cyber Prot", RegistryKeyPermissionCheck.ReadWriteSubTree).GetValue("StartWithWindows", true));
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex, num);
			Registry.LocalMachine.CreateSubKey("SOFTWARE\\Cyber Prot", RegistryKeyPermissionCheck.ReadWriteSubTree).SetValue("StartWithWindows", true);
			WinStart = true;
			ProjectData.ClearProjectError();
		}
		while (true)
		{
			num = 1012;
			if (WinStart)
			{
				if (!AddToStartUP())
				{
					WinStart = false;
					continue;
				}
				PictureBox9.set_Image(ImageList1.get_Images().get_Item(0));
				((Control)PictureBox9).set_Tag((object)"ON");
				break;
			}
			try
			{
				CMDcuRSP("SCHTASKS /Delete /TN \"CyberProt\" /F ");
			}
			catch (Exception ex2)
			{
				ProjectData.SetProjectError(ex2, num);
				ProjectData.ClearProjectError();
			}
			PictureBox9.set_Image(ImageList1.get_Images().get_Item(1));
			((Control)PictureBox9).set_Tag((object)"OFF");
			break;
		}
		try
		{
			DisableTraps = Conversions.ToBoolean(Registry.LocalMachine.CreateSubKey("SOFTWARE\\Cyber Prot", RegistryKeyPermissionCheck.ReadWriteSubTree).GetValue("UseHeuristics", true));
		}
		catch (Exception ex3)
		{
			ProjectData.SetProjectError(ex3, num);
			Registry.LocalMachine.CreateSubKey("SOFTWARE\\Cyber Prot", RegistryKeyPermissionCheck.ReadWriteSubTree).SetValue("UseHeuristics", true);
			DisableTraps = true;
			ProjectData.ClearProjectError();
		}
		if (DisableTraps)
		{
			PictureBox27.set_Image(ImageList1.get_Images().get_Item(0));
			((Control)PictureBox27).set_Tag((object)"ON");
		}
		else
		{
			PictureBox27.set_Image(ImageList1.get_Images().get_Item(1));
			((Control)PictureBox27).set_Tag((object)"OFF");
		}
		try
		{
			DisableRenamesScan = Conversions.ToBoolean(Registry.LocalMachine.CreateSubKey("SOFTWARE\\Cyber Prot", RegistryKeyPermissionCheck.ReadWriteSubTree).GetValue("DisableRenamesScan", true));
		}
		catch (Exception ex4)
		{
			ProjectData.SetProjectError(ex4, num);
			Registry.LocalMachine.CreateSubKey("SOFTWARE\\Cyber Prot", RegistryKeyPermissionCheck.ReadWriteSubTree).SetValue("DisableRenamesScan", true);
			DisableRenamesScan = true;
			ProjectData.ClearProjectError();
		}
		try
		{
			AppdataExec = Conversions.ToBoolean(Registry.LocalMachine.CreateSubKey("SOFTWARE\\Cyber Prot", RegistryKeyPermissionCheck.ReadWriteSubTree).GetValue("UseProactive", true));
		}
		catch (Exception ex5)
		{
			ProjectData.SetProjectError(ex5, num);
			Registry.LocalMachine.CreateSubKey("SOFTWARE\\Cyber Prot", RegistryKeyPermissionCheck.ReadWriteSubTree).SetValue("UseProactive", true);
			AppdataExec = true;
			ProjectData.ClearProjectError();
		}
		if (AppdataExec)
		{
			PictureBox57.set_Image(ImageList1.get_Images().get_Item(0));
			((Control)PictureBox57).set_Tag((object)"ON");
		}
		else
		{
			PictureBox57.set_Image(ImageList1.get_Images().get_Item(1));
			((Control)PictureBox57).set_Tag((object)"OFF");
		}
		ClearMem();
	}

	public void Splash()
	{
		((Control)this.m_a).Show();
		double num = 0.0;
		do
		{
			((Form)this.m_a).set_Opacity(num);
			Application.DoEvents();
			Thread.Sleep(10);
			Application.DoEvents();
			num += 0.01;
		}
		while (num <= 1.0);
		while (!Timer1.get_Enabled())
		{
			Application.DoEvents();
		}
		double num2 = 1.0;
		while (((Control)this.m_a).get_Visible())
		{
			((Form)this.m_a).set_Opacity(num2);
			Application.DoEvents();
			Thread.Sleep(10);
			Application.DoEvents();
			num2 += -0.05;
			if (num2 < 0.0)
			{
				((Control)this.m_a).Hide();
				((Form)this.m_a).Close();
				this.m_a = null;
				UpdateW(value: true);
				break;
			}
		}
	}

	public void UpdateW(bool value)
	{
		if (((Control)this).get_InvokeRequired())
		{
			((Control)this).Invoke((Delegate)(global::a)delegate
			{
				UpdateW(value);
			});
			return;
		}
		((Control)this).set_Visible(value);
		if (value)
		{
			((Form)this).set_WindowState((FormWindowState)0);
			if ((((Control)this).get_Top() == 0) & (((Control)this).get_Left() == 0))
			{
				((Form)this).CenterToScreen();
			}
			((Form)this).set_TopMost(true);
			Application.DoEvents();
			((Form)this).set_TopMost(false);
		}
		else
		{
			((Form)this).set_WindowState((FormWindowState)1);
		}
	}

	[DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
	private static extern IntPtr FindWindow([MarshalAs(UnmanagedType.VBByRefStr)] ref string A_0, [MarshalAs(UnmanagedType.VBByRefStr)] ref string A_1);

	[DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
	private static extern IntPtr FindWindowEx(IntPtr A_0, IntPtr A_1, [MarshalAs(UnmanagedType.VBByRefStr)] ref string A_2, [MarshalAs(UnmanagedType.VBByRefStr)] ref string A_3);

	[DllImport("user32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern long ShowWindow(long hwnd, int nCmdShow);

	[DllImport("Shell32.dll", CharSet = CharSet.Unicode, ExactSpelling = true, SetLastError = true)]
	private static extern IntPtr SHGetFileInfoW([MarshalAs(UnmanagedType.VBByRefStr)] ref string A_0, uint A_1, ref SHFILEINFO A_2, uint A_3, uint A_4);

	private static IntPtr a(string A_0, uint A_1, ref SHFILEINFO A_2, uint A_3, uint A_4)
	{
		CultureInfo currentCulture = Application.get_CurrentCulture();
		IntPtr result = SHGetFileInfoW(ref A_0, A_1, ref A_2, A_3, A_4);
		CultureInfo currentCulture2 = Application.get_CurrentCulture();
		if (Operators.CompareString(currentCulture2.Name, currentCulture2.Name, false) != 0 || currentCulture != currentCulture2)
		{
			Application.set_CurrentCulture(currentCulture);
		}
		return result;
	}

	private Icon b(string A_0)
	{
		SHFILEINFO A_ = default(SHFILEINFO);
		A_.szDisplayName = new string('\0', 260);
		A_.szTypeName = new string('\0', 80);
		a(A_0, 0u, ref A_, checked((uint)Marshal.SizeOf((object)A_)), 257u);
		try
		{
			return Icon.FromHandle(A_.hIcon);
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			Icon application = SystemIcons.get_Application();
			ProjectData.ClearProjectError();
			return application;
		}
	}

	[MethodImpl(MethodImplOptions.NoOptimization)]
	private void d3(object sender, EventArgs e)
	{
		//IL_00b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0137: Unknown result type (might be due to invalid IL or missing references)
		//IL_0193: Unknown result type (might be due to invalid IL or missing references)
		((Control)this).set_Visible(false);
		((Control)this).Hide();
		bool flag = HaveMinInArgs();
		Process[] processesByName = Process.GetProcessesByName("Cyber Prot");
		((Form)this).set_StartPosition((FormStartPosition)1);
		int num2 = default(int);
		if (processesByName.Length > 1)
		{
			if (flag)
			{
				Application.Exit();
				ProjectData.EndApp();
			}
			if ((int)processesByName[0].MainWindowHandle == 0)
			{
				((Form)this).set_Text("");
				string A_ = null;
				string A_2 = "Cyber Prot";
				int num = (int)FindWindow(ref A_, ref A_2);
				((Form)this).set_Text("Cyber Prot");
				if (num > 0)
				{
					try
					{
						Registry.LocalMachine.CreateSubKey("SOFTWARE\\Cyber Prot", RegistryKeyPermissionCheck.ReadWriteSubTree).SetValue("MSG", "UP");
					}
					catch (Exception ex)
					{
						ProjectData.SetProjectError(ex, num2);
						if (!flag)
						{
							MessageBox.Show("You don't have privileges to use this application!\r\nPlease contact your administrator.", "Cyber Prot", (MessageBoxButtons)0, (MessageBoxIcon)16);
						}
						Application.Exit();
						ProjectData.EndApp();
						ProjectData.ClearProjectError();
					}
				}
				else if (Operators.CompareString(processesByName[0].MainWindowTitle, "", false) == 0 && processesByName.Length == 2)
				{
					MessageBox.Show("Cyber Prot is already started!\r\nPlease open it from the system tray.", "Cyber Prot", (MessageBoxButtons)0, (MessageBoxIcon)16);
				}
			}
			else
			{
				try
				{
					Registry.LocalMachine.CreateSubKey("SOFTWARE\\Cyber Prot", RegistryKeyPermissionCheck.ReadWriteSubTree).SetValue("MSG", "UP");
				}
				catch (Exception ex2)
				{
					ProjectData.SetProjectError(ex2, num2);
					if (!flag)
					{
						MessageBox.Show("You don't have privileges to use this application!\r\nPlease contact your administrator.", "Cyber Prot", (MessageBoxButtons)0, (MessageBoxIcon)16);
					}
					Application.Exit();
					ProjectData.EndApp();
					ProjectData.ClearProjectError();
				}
			}
			num2 = 11;
			Application.Exit();
			ProjectData.EndApp();
		}
		try
		{
			Registry.LocalMachine.CreateSubKey("SOFTWARE\\Cyber Prot", RegistryKeyPermissionCheck.ReadWriteSubTree).SetValue("MSG", "");
		}
		catch (Exception ex3)
		{
			ProjectData.SetProjectError(ex3, num2);
			if (!flag)
			{
				MessageBox.Show("You don't have privileges to use this application!\r\nPlease contact your administrator.", "Cyber Prot", (MessageBoxButtons)0, (MessageBoxIcon)16);
			}
			Application.Exit();
			ProjectData.EndApp();
			ProjectData.ClearProjectError();
		}
		if (flag)
		{
			CreateLog("Application started", "Application version " + Application.get_ProductVersion() + " automatically started", (EventLogEntryType)4, Repair: true, 4);
		}
		else
		{
			CreateLog("Application started", "Application version " + Application.get_ProductVersion() + " started", (EventLogEntryType)4, Repair: true, 4);
		}
		if (!flag)
		{
			new Thread(Splash).Start();
		}
		CountExepts();
		LoadSettings();
		SwitchPanels(StatusPanelMain);
		Label38.set_Text("Application version: " + ((Control)this).get_ProductVersion().ToString());
		((Control)Label38).Refresh();
		this.m_s = ExtendedLicenseManager.GetLicense(typeof(Form1), (object)this, "<RSAKeyValue><Modulus>2dcMtFP2/lYJvgI4fi9k7XMt+MU36zxvh/3plTgyeeiUQEgPLu01DbHyzeiLG+r99bYTw0KR3a60A2kH+icsO7uYoFlJkjQUtpD7WGPVlTRyAUnCwjTzAATnzlyeQX2LXhy9vJZeLf33lR32bm925c5kbsykTc+un6m18/EafK5jCbE+MVHsmEg9d3G5Qpp3vUT/ZY4atINRLYE3qBC+ETG8xUSpxFkb7YM9j0Te/kt7pYpe6UIyfD7PP24L+GRumOXbjWrMSXQeeH6ck7kXCgol+nUH9JIboZ1Vm0zpiGIBJ+xE/k4WKPJremp9cq2sCve5etXd9Xjd1aPsREsEhQ==</Modulus><Exponent>AQAB</Exponent></RSAKeyValue>");
		licentiere();
		Timer1.set_Enabled(true);
		NotifyIcon1.set_Visible(true);
		Update(Er: false);
		FixTextCiudat();
		RefreshQuarantine();
	}

	public bool HaveMinInArgs()
	{
		checked
		{
			try
			{
				string[] commandLineArgs = Environment.GetCommandLineArgs();
				int num = commandLineArgs.Length - 1;
				for (int i = 0; i <= num; i++)
				{
					if (Operators.CompareString(commandLineArgs[i], "min", false) == 0)
					{
						return true;
					}
				}
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
			}
			return false;
		}
	}

	public void databaseVersion()
	{
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		if (DoDatabaseVersion)
		{
			return;
		}
		DoDatabaseVersion = true;
		int num = 0;
		while (true)
		{
			int num2 = 10;
			try
			{
				try
				{
					StreamReader streamReader = new StreamReader("Database.cp", detectEncodingFromByteOrderMarks: true);
					string cipherText = streamReader.ReadToEnd();
					streamReader.Close();
					JavaScriptSerializer val = new JavaScriptSerializer();
					val.set_MaxJsonLength(2147483644);
					DB dB = val.Deserialize<DB>(Decrypt(cipherText));
					Label8.set_Text("Definitions version: " + dB.version.Replace(".000000", "").Replace("T", " ").Replace("Z", "")
						.Trim());
					this.m_q = dB;
					if (num > 0)
					{
						CallService();
					}
				}
				catch (FileNotFoundException ex)
				{
					ProjectData.SetProjectError((Exception)ex, num2);
					if (num >= 2)
					{
						Label8.set_Text("Local database is missing! Try to update!");
						ProjectData.ClearProjectError();
						break;
					}
					num = checked(num + 1);
					Thread thread = new Thread(DownloadDatabase);
					thread.Start();
					while (thread.IsAlive)
					{
						Thread.Sleep(50);
						Application.DoEvents();
					}
					Thread.Sleep(100);
					ProjectData.ClearProjectError();
					continue;
				}
			}
			catch (Exception ex2)
			{
				ProjectData.SetProjectError(ex2, num2);
				ProjectData.ClearProjectError();
			}
			break;
		}
		DoDatabaseVersion = false;
	}

	public void DownloadDatabase()
	{
		try
		{
			new WebClient().DownloadFile("http://www.cyberland.ro/Database.cp", "Database.cp");
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	public void DownloadVer()
	{
		try
		{
			string address = "http://www.cyberland.ro/ver.txt";
			WebClient webClient = new WebClient();
			StreamReader streamReader = new StreamReader(webClient.OpenRead(address));
			ServerVer = streamReader.ReadToEnd();
			streamReader.Close();
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ServerVer = "Error";
			ProjectData.ClearProjectError();
		}
	}

	public object Update(bool Er, bool SH = false)
	{
		//IL_01a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a8: Invalid comparison between Unknown and I4
		Timer2.set_Enabled(false);
		string text = "";
		object result = default(object);
		try
		{
			string text2 = "";
			ServerVer = "Error";
			Thread thread = new Thread(DownloadVer);
			thread.Start();
			while (thread.IsAlive)
			{
				Thread.Sleep(50);
				Application.DoEvents();
			}
			if (Operators.CompareString(ServerVer, "Error", false) == 0)
			{
				((Control)Label35).set_Tag((object)"Error checking for updates");
				Label35.set_Text("Error checking for updates");
				if (SH)
				{
					Timer2.set_Enabled(true);
					return result;
				}
				if (Er)
				{
					ShowMessageBox("Error checking for updates.\r\nMake sure you are connected to internet and try again.", "Cyber Prot", (MessageBoxButtons)0, (MessageBoxIcon)16);
				}
				text = "Error checking for updates";
			}
			else
			{
				text2 = ServerVer;
				if (Operators.CompareString(Application.get_ProductVersion().ToString(), text2, false) != 0)
				{
					Label38.set_Text("Application version: " + ((Control)this).get_ProductVersion().ToString());
					((Control)Label38).Refresh();
					Label44.set_Text("Update now");
					((Control)Label35).set_Tag((object)"Updates are available");
					Label35.set_Text("Updates are available");
					if (SH)
					{
						if (!((Control)this).get_Visible() && !Er)
						{
							NotifyIcon1.ShowBalloonTip(30000, "Cyber Prot", "A new version (" + text2 + ") has been released.\r\nPlease update your product!", (ToolTipIcon)2);
						}
						Timer2.set_Enabled(true);
						return result;
					}
					((Control)this).set_Enabled(false);
					((Form)this).set_TopMost(true);
					if ((int)MessageBox.Show((IWin32Window)(object)this, "A new version (" + text2 + ") has been released.\r\nDo you want to install it now?", "Cyber Prot", (MessageBoxButtons)4, (MessageBoxIcon)48) == 6)
					{
						try
						{
							Thread thread2 = new Thread(StartUpdate);
							thread2.Start();
							while (thread2.IsAlive)
							{
								Thread.Sleep(50);
								Application.DoEvents();
							}
						}
						catch (Exception projectError)
						{
							ProjectData.SetProjectError(projectError);
							Process.Start("http://www.cyberland.ro/index.html#download");
							ProjectData.ClearProjectError();
						}
						text = "Update available";
					}
					((Control)this).set_Enabled(true);
					((Form)this).set_TopMost(false);
					Timer2.set_Enabled(true);
					return result;
				}
				((Control)Label35).set_Tag((object)"Cyber Prot is up to date");
				Label35.set_Text("Cyber Prot is up to date");
				if (Er)
				{
					ShowMessageBox("No updates available.", "Cyber Prot", (MessageBoxButtons)0, (MessageBoxIcon)64);
				}
				text = "No updates available.";
			}
		}
		catch (Exception projectError2)
		{
			ProjectData.SetProjectError(projectError2);
			((Control)Label35).set_Tag((object)"Error checking for updates");
			Label35.set_Text("Error checking for updates");
			if (SH)
			{
				Timer2.set_Enabled(true);
				ProjectData.ClearProjectError();
				return result;
			}
			if (Er)
			{
				ShowMessageBox("Error checking for updates.\r\nMake sure you are connected to internet and try again.", "Cyber Prot", (MessageBoxButtons)0, (MessageBoxIcon)16);
			}
			text = "Error checking for updates.";
			ProjectData.ClearProjectError();
		}
		Label44.set_Text("Check for updates");
		FixTextCiudat();
		Timer2.set_Enabled(true);
		return text;
	}

	public void UpdateLab(Label txtBox, string value)
	{
		if (((Control)txtBox).get_InvokeRequired())
		{
			((Control)txtBox).Invoke((Delegate)(global::a)delegate
			{
				UpdateLab(txtBox, value);
			});
		}
		else
		{
			txtBox.set_Text(value);
		}
	}

	public void UpdateTag(Control txtBox, string value)
	{
		if (txtBox.get_InvokeRequired())
		{
			txtBox.Invoke((Delegate)(global::a)delegate
			{
				UpdateTag(txtBox, value);
			});
		}
		else
		{
			txtBox.set_Tag((object)value);
		}
	}

	public void Lic(bool Verb = false)
	{
		//IL_03e3: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			UpdateTag((Control)(object)LicenseStatus, "");
			this.m_t = true;
			this.m_s = null;
			this.m_s = ExtendedLicenseManager.GetLicense(typeof(Form1), (object)this, "<RSAKeyValue><Modulus>2dcMtFP2/lYJvgI4fi9k7XMt+MU36zxvh/3plTgyeeiUQEgPLu01DbHyzeiLG+r99bYTw0KR3a60A2kH+icsO7uYoFlJkjQUtpD7WGPVlTRyAUnCwjTzAATnzlyeQX2LXhy9vJZeLf33lR32bm925c5kbsykTc+un6m18/EafK5jCbE+MVHsmEg9d3G5Qpp3vUT/ZY4atINRLYE3qBC+ETG8xUSpxFkb7YM9j0Te/kt7pYpe6UIyfD7PP24L+GRumOXbjWrMSXQeeH6ck7kXCgol+nUH9JIboZ1Vm0zpiGIBJ+xE/k4WKPJremp9cq2sCve5etXd9Xjd1aPsREsEhQ==</Modulus><Exponent>AQAB</Exponent></RSAKeyValue>");
			try
			{
				this.m_s.Refresh();
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
			}
			try
			{
				this.m_s.IsGenuine();
			}
			catch (Exception projectError2)
			{
				ProjectData.SetProjectError(projectError2);
				ProjectData.ClearProjectError();
			}
			try
			{
				this.m_s.Validate();
			}
			catch (Exception projectError3)
			{
				ProjectData.SetProjectError(projectError3);
				ProjectData.ClearProjectError();
			}
			if (this.m_s.get_IsActivated())
			{
				UpdateIMG(PictureBox65, PictureBox65.get_InitialImage());
				UpdateTag((Control)(object)LicenseStatus, "license");
				UpdateLab(Label36, "Reactivate license");
				UpdateF((Control)(object)Label42, value: true);
				DateTime dateTime = default(DateTime);
				foreach (Limit limit in this.m_s.get_Limits())
				{
					if (Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet((object)limit, (Type)null, "Name", new object[0], (string[])null, (Type[])null, (bool[])null), (object)"Time", false))
					{
						dateTime = Conversions.ToDate(NewLateBinding.LateGet((object)limit, (Type)null, "EndDate", new object[0], (string[])null, (Type[])null, (bool[])null));
					}
				}
				int num = checked((int)Math.Abs(Conversion.Int(DateAndTime.DateDiff((DateInterval)4, DateAndTime.get_Now(), dateTime, (FirstDayOfWeek)1, (FirstWeekOfYear)1))));
				UpdateTag((Control)(object)TrialStatus, Conversions.ToString(num));
				if (this.m_s.get_InvalidReason() != null)
				{
					UpdateLab(LicenseStatus, "Not activated");
					UpdateLab(TrialStatus, this.m_s.get_InvalidReason());
					this.m_t = false;
					if (Verb)
					{
						((Control)this).Invoke((Delegate)(global::a)delegate
						{
							//IL_001d: Unknown result type (might be due to invalid IL or missing references)
							MessageBox.Show("License error:\r\n" + this.m_s.get_InvalidReason(), "Cyber Prot", (MessageBoxButtons)0, (MessageBoxIcon)16);
						});
					}
				}
				else
				{
					UpdateLab(LicenseStatus, "Product is activated");
					UpdateLab(TrialStatus, "Valid until " + Strings.Format((object)dateTime.AddDays(-1.0), "MMMM dd yyyy"));
				}
			}
			else
			{
				UpdateIMG(PictureBox65, PictureBox65.get_ErrorImage());
				UpdateF((Control)(object)Label42, value: false);
				UpdateTag((Control)(object)LicenseStatus, "trial");
				UpdateLab(LicenseStatus, "Trial mode");
				if (!Directory.Exists(Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData) + "\\IPManager\\"))
				{
					Directory.CreateDirectory(Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData) + "\\IPManager\\");
				}
				DateTime creationTime = Directory.GetCreationTime(Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData) + "\\IPManager\\");
				if (DateTime.Compare(creationTime, DateAndTime.get_Now()) > 0)
				{
					UpdateTag((Control)(object)TrialStatus, "-1");
					this.m_t = false;
					UpdateLab(TrialStatus, "Expired. You are not protected!");
				}
				else
				{
					creationTime = creationTime.AddDays(30.0);
					UpdateTag((Control)(object)TrialStatus, Conversions.ToString(Math.Abs(DateAndTime.DateDiff((DateInterval)4, DateAndTime.get_Now(), creationTime, (FirstDayOfWeek)1, (FirstWeekOfYear)1))));
					if (DateAndTime.DateDiff((DateInterval)4, creationTime, DateAndTime.get_Now(), (FirstDayOfWeek)1, (FirstWeekOfYear)1) >= 0L)
					{
						this.m_t = false;
						UpdateLab(TrialStatus, "Expired. You are not protected!");
						UpdateTag((Control)(object)TrialStatus, "-1");
					}
					else
					{
						UpdateLab(TrialStatus, "Valid until " + Strings.Format((object)creationTime.AddDays(-1.0), "MMMM dd yyyy"));
					}
				}
			}
		}
		catch (Exception projectError4)
		{
			ProjectData.SetProjectError(projectError4);
			UpdateLab(LicenseStatus, "License error");
			this.m_t = false;
			UpdateLab(TrialStatus, "Contact your administrator");
			ProjectData.ClearProjectError();
		}
		if (!this.m_t)
		{
			try
			{
				new ServiceController("CyberProtService").Stop();
				Thread.Sleep(100);
			}
			catch (Exception projectError5)
			{
				ProjectData.SetProjectError(projectError5);
				CMDcuRSP("taskkill /IM \"Cyber Prot Service.exe\" /F");
				CreateLog("Engine stopped", "Engine has been stopped", (EventLogEntryType)2, Repair: true, 0);
				ProjectData.ClearProjectError();
			}
		}
		FixTextCiudat();
		this.m_r = true;
	}

	public void licentiere(bool Verb = false)
	{
		d a_ = default(d);
		d CS_0024_003C_003E8__locals0 = new d(a_);
		CS_0024_003C_003E8__locals0.b = this;
		CS_0024_003C_003E8__locals0.a = Verb;
		if (!DoLic)
		{
			DoLic = true;
			Thread thread = new Thread((ThreadStart)delegate
			{
				CS_0024_003C_003E8__locals0.b.Lic(CS_0024_003C_003E8__locals0.a);
			});
			thread.Start();
			while (thread.IsAlive)
			{
				Thread.Sleep(50);
				Application.DoEvents();
			}
			DoLic = false;
		}
	}

	private void i(object sender, MouseEventArgs e)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Invalid comparison between Unknown and I4
		if ((int)e.get_Button() == 1048576)
		{
			ReleaseCapture();
			SendMessageA(((Control)this).get_Handle().ToInt32(), 161, 2, 0);
		}
	}

	public void SwitchPanels(Panel P)
	{
		//IL_005d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Expected O, but got Unknown
		((Control)this).SuspendLayout();
		((Control)Panel20).set_Visible(false);
		try
		{
			string name = ((Control)P).get_Name();
			if (Operators.CompareString(name, "StatusPanelMain", false) == 0)
			{
				databaseVersion();
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
		if (((Control)P).get_Visible())
		{
			return;
		}
		IEnumerator enumerator = default(IEnumerator);
		try
		{
			enumerator = ((Control)this).get_Controls().GetEnumerator();
			while (enumerator.MoveNext())
			{
				Control val = (Control)enumerator.Current;
				try
				{
					if (val.get_Name().EndsWith("PanelMain"))
					{
						if (Operators.CompareString(((Control)P).get_Name(), val.get_Name(), false) == 0)
						{
							((Control)P).set_Left(151);
							((Control)P).set_Top(30);
							((Control)P).set_Width(602);
							((Control)P).set_Height(433);
							((Control)P).set_Visible(true);
						}
						else
						{
							val.set_Visible(false);
						}
					}
				}
				catch (Exception projectError2)
				{
					ProjectData.SetProjectError(projectError2);
					ProjectData.ClearProjectError();
				}
			}
		}
		finally
		{
			if (enumerator is IDisposable)
			{
				(enumerator as IDisposable).Dispose();
			}
		}
		((Control)this).ResumeLayout();
	}

	private void d2(object sender, EventArgs e)
	{
		SwitchPanels(StatusPanelMain);
	}

	private void d1(object sender, EventArgs e)
	{
		UpdateW(value: false);
		SwitchPanels(StatusPanelMain);
		databaseVersion();
		ClearMem();
	}

	public void UpdateF(Control txtBox, bool value)
	{
		try
		{
			if (txtBox.get_InvokeRequired())
			{
				txtBox.Invoke((Delegate)(global::a)delegate
				{
					UpdateF(txtBox, value);
				});
				return;
			}
			txtBox.set_Visible(value);
			if (!value)
			{
				txtBox.Hide();
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	private void h(object sender, MouseEventArgs e)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Invalid comparison between Unknown and I4
		if ((int)e.get_Button() == 1048576)
		{
			ReleaseCapture();
			SendMessageA(((Control)this).get_Handle().ToInt32(), 161, 2, 0);
		}
	}

	private void d0(object sender, EventArgs e)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Invalid comparison between Unknown and I4
		if ((int)((Form)this).get_WindowState() == 1)
		{
			SwitchPanels(StatusPanelMain);
		}
		((Form)this).set_WindowState((FormWindowState)0);
		if ((((Control)this).get_Top() == 0) & (((Control)this).get_Left() == 0))
		{
			((Form)this).CenterToScreen();
		}
		((Form)this).set_TopMost(true);
		Application.DoEvents();
		((Form)this).set_TopMost(false);
	}

	[MethodImpl(MethodImplOptions.NoOptimization)]
	private void dz(object sender, EventArgs e)
	{
		UpdateW(value: false);
		SwitchPanels(StatusPanelMain);
		databaseVersion();
		ClearMem();
	}

	[MethodImpl(MethodImplOptions.NoOptimization)]
	private void dy(object sender, EventArgs e)
	{
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_0056: Invalid comparison between Unknown and I4
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		NotifyIcon1.set_Visible(false);
		((Control)this).set_Visible(false);
		Application.DoEvents();
		int num = default(int);
		if (Operators.ConditionalCompareObjectEqual(Registry.LocalMachine.CreateSubKey("SOFTWARE\\Cyber Prot", RegistryKeyPermissionCheck.ReadWriteSubTree).GetValue("ShowCloseMessage", false), (object)false, false))
		{
			try
			{
				if ((int)new ServiceController("CyberProtService").get_Status() == 4)
				{
					MessageBox.Show("Cyber Prot's engine is still running in background!\r\nYou can further customize or disable it by reopening this application.", "Cyber Prot", (MessageBoxButtons)0, (MessageBoxIcon)64);
					Registry.LocalMachine.CreateSubKey("SOFTWARE\\Cyber Prot", RegistryKeyPermissionCheck.ReadWriteSubTree).SetValue("ShowCloseMessage", true);
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex, num);
				ProjectData.ClearProjectError();
			}
		}
		num = 10;
		Application.DoEvents();
		Application.Exit();
		ProjectData.EndApp();
	}

	private void dx(object sender, EventArgs e)
	{
		SwitchPanels(GeneralSettingsPanelMain);
	}

	private void dw(object sender, EventArgs e)
	{
		SwitchPanels(GeneralSettingsPanelMain);
	}

	private void dv(object sender, EventArgs e)
	{
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Expected O, but got Unknown
		Font font = new Font(((Control)Label2).get_Font().get_Name(), ((Control)Label2).get_Font().get_Size(), (FontStyle)4);
		((Control)Label2).set_Font(font);
	}

	private void du(object sender, EventArgs e)
	{
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Expected O, but got Unknown
		Font font = new Font(((Control)Label7).get_Font().get_Name(), ((Control)Label7).get_Font().get_Size(), (FontStyle)4);
		((Control)Label7).set_Font(font);
	}

	private void dt(object sender, EventArgs e)
	{
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Expected O, but got Unknown
		Font font = new Font(((Control)Label4).get_Font().get_Name(), ((Control)Label4).get_Font().get_Size(), (FontStyle)4);
		((Control)Label4).set_Font(font);
	}

	private void ds(object sender, EventArgs e)
	{
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Expected O, but got Unknown
		Font font = new Font(((Control)Label5).get_Font().get_Name(), ((Control)Label5).get_Font().get_Size(), (FontStyle)4);
		((Control)Label5).set_Font(font);
	}

	private void dr(object sender, EventArgs e)
	{
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Expected O, but got Unknown
		Font font = new Font(((Control)Label2).get_Font().get_Name(), ((Control)Label2).get_Font().get_Size(), (FontStyle)0);
		((Control)Label2).set_Font(font);
	}

	private void dq(object sender, EventArgs e)
	{
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Expected O, but got Unknown
		Font font = new Font(((Control)Label7).get_Font().get_Name(), ((Control)Label7).get_Font().get_Size(), (FontStyle)0);
		((Control)Label7).set_Font(font);
	}

	private void dp(object sender, EventArgs e)
	{
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Expected O, but got Unknown
		Font font = new Font(((Control)Label4).get_Font().get_Name(), ((Control)Label4).get_Font().get_Size(), (FontStyle)0);
		((Control)Label4).set_Font(font);
	}

	private void @do(object sender, EventArgs e)
	{
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Expected O, but got Unknown
		Font font = new Font(((Control)Label5).get_Font().get_Name(), ((Control)Label5).get_Font().get_Size(), (FontStyle)0);
		((Control)Label5).set_Font(font);
	}

	public void SliderClick(PictureBox P)
	{
		if (Operators.ConditionalCompareObjectEqual(((Control)P).get_Tag(), (object)"ON", false))
		{
			P.set_Image(ImageList1.get_Images().get_Item(2));
			Application.DoEvents();
			Thread.Sleep(100);
			switch (((Control)P).get_Name())
			{
			case "PictureBox10":
				Registry.LocalMachine.CreateSubKey("SOFTWARE\\Cyber Prot", RegistryKeyPermissionCheck.ReadWriteSubTree).SetValue("MuteSounds", false);
				break;
			case "PictureBox9":
				Registry.LocalMachine.CreateSubKey("SOFTWARE\\Cyber Prot", RegistryKeyPermissionCheck.ReadWriteSubTree).SetValue("StartWithWindows", false);
				break;
			case "PictureBox29":
				Registry.LocalMachine.CreateSubKey("SOFTWARE\\Cyber Prot", RegistryKeyPermissionCheck.ReadWriteSubTree).SetValue("DisableRenamesScan", true);
				break;
			case "PictureBox27":
				Registry.LocalMachine.CreateSubKey("SOFTWARE\\Cyber Prot", RegistryKeyPermissionCheck.ReadWriteSubTree).SetValue("UseHeuristics", false);
				break;
			case "PictureBox57":
				Registry.LocalMachine.CreateSubKey("SOFTWARE\\Cyber Prot", RegistryKeyPermissionCheck.ReadWriteSubTree).SetValue("UseProactive", false);
				break;
			case "PictureBox55":
				Registry.LocalMachine.CreateSubKey("SOFTWARE\\Cyber Prot", RegistryKeyPermissionCheck.ReadWriteSubTree).SetValue("AppdataExec", true);
				break;
			}
			P.set_Image(ImageList1.get_Images().get_Item(1));
			((Control)P).set_Tag((object)"OFF");
		}
		else
		{
			P.set_Image(ImageList1.get_Images().get_Item(2));
			Application.DoEvents();
			Thread.Sleep(100);
			switch (((Control)P).get_Name())
			{
			case "PictureBox10":
				Registry.LocalMachine.CreateSubKey("SOFTWARE\\Cyber Prot", RegistryKeyPermissionCheck.ReadWriteSubTree).SetValue("MuteSounds", true);
				break;
			case "PictureBox9":
				Registry.LocalMachine.CreateSubKey("SOFTWARE\\Cyber Prot", RegistryKeyPermissionCheck.ReadWriteSubTree).SetValue("StartWithWindows", true);
				break;
			case "PictureBox29":
				Registry.LocalMachine.CreateSubKey("SOFTWARE\\Cyber Prot", RegistryKeyPermissionCheck.ReadWriteSubTree).SetValue("DisableRenamesScan", false);
				break;
			case "PictureBox27":
				Registry.LocalMachine.CreateSubKey("SOFTWARE\\Cyber Prot", RegistryKeyPermissionCheck.ReadWriteSubTree).SetValue("UseHeuristics", true);
				break;
			case "PictureBox55":
				Registry.LocalMachine.CreateSubKey("SOFTWARE\\Cyber Prot", RegistryKeyPermissionCheck.ReadWriteSubTree).SetValue("AppdataExec", false);
				break;
			case "PictureBox57":
				Registry.LocalMachine.CreateSubKey("SOFTWARE\\Cyber Prot", RegistryKeyPermissionCheck.ReadWriteSubTree).SetValue("UseProactive", true);
				break;
			}
			P.set_Image(ImageList1.get_Images().get_Item(0));
			((Control)P).set_Tag((object)"ON");
		}
		if (!((Operators.CompareString(((Control)P).get_Name(), "PictureBox10", false) == 0) | (Operators.CompareString(((Control)P).get_Name(), "PictureBox9", false) == 0) | (Operators.CompareString(((Control)P).get_Name(), "PictureBox12", false) == 0)))
		{
			CallService();
		}
	}

	public bool AddToStartUP()
	{
		try
		{
			Process process = new Process();
			string executablePath = Application.get_ExecutablePath();
			process.StartInfo.FileName = "schtasks";
			try
			{
				if (File.Exists("CP.xml"))
				{
					File.Delete(executablePath.Substring(0, executablePath.LastIndexOf("\\")) + "\\CP.xml");
				}
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
			}
			StreamWriter streamWriter = new StreamWriter(executablePath.Substring(0, executablePath.LastIndexOf("\\")) + "\\CP.xml");
			string text = "<?xml version=\"1.0\" encoding=\"UTF-16\"?>";
			text += "\r\n<Task version = \"1.2\" xmlns=\"http://schemas.microsoft.com/windows/2004/02/mit/task\">";
			text += "\r\n<RegistrationInfo>";
			text += "\r\n<Date>2016-09-22T02:09:04.9764186</Date>";
			text += "\r\n<Author>CyberProt</Author>";
			text += "\r\n<URI>\\CyberProt</URI>";
			text += "\r\n</RegistrationInfo>";
			text += "\r\n<Triggers>";
			text += "\r\n<LogonTrigger>";
			text += "\r\n<Enabled>true</Enabled>";
			text += "\r\n</LogonTrigger>";
			text += "\r\n</Triggers>";
			text += "\r\n<Principals>";
			text += "\r\n<Principal id = \"Author\" >";
			text += "\r\n<GroupId>S-1-5-32-545</GroupId>";
			text += "\r\n<RunLevel>HighestAvailable</RunLevel>";
			text += "\r\n</Principal>";
			text += "\r\n</Principals>";
			text += "\r\n<Settings>";
			text += "\r\n<MultipleInstancesPolicy>IgnoreNew</MultipleInstancesPolicy>";
			text += "\r\n<DisallowStartIfOnBatteries>false</DisallowStartIfOnBatteries>";
			text += "\r\n<AllowHardTerminate>true</AllowHardTerminate>";
			text += "\r\n<StartWhenAvailable>false</StartWhenAvailable>";
			text += "\r\n<RunOnlyIfNetworkAvailable>false</RunOnlyIfNetworkAvailable>";
			text += "\r\n<IdleSettings>";
			text += "\r\n<RestartOnIdle>false</RestartOnIdle>";
			text += "\r\n</IdleSettings>";
			text += "\r\n<AllowStartOnDemand>true</AllowStartOnDemand>";
			text += "\r\n<Enabled>true</Enabled>";
			text += "\r\n<Hidden>false</Hidden>";
			text += "\r\n<RunOnlyIfIdle>false</RunOnlyIfIdle>";
			text += "\r\n<WakeToRun>false</WakeToRun>";
			text += "\r\n<Priority>7</Priority>";
			text += "\r\n</Settings>";
			text += "\r\n<Actions Context = \"Author\" >";
			text += "\r\n<Exec>";
			text = text + "\r\n<Command>\"" + Application.get_ExecutablePath() + "\"</Command>";
			text += "\r\n<Arguments>min</Arguments>";
			text = text + "\r\n<WorkingDirectory>" + Application.get_ExecutablePath().Substring(0, checked(Application.get_ExecutablePath().LastIndexOf("\\") + 1)) + "</WorkingDirectory>";
			text += "\r\n</Exec>";
			text += "\r\n</Actions>";
			text += "\r\n</Task>";
			streamWriter.Write(text);
			streamWriter.Close();
			process.StartInfo.Arguments = " /create /TN CyberProt /XML \"" + executablePath.Substring(0, executablePath.LastIndexOf("\\")) + "\\CP.xml\" /F";
			process.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
			process.StartInfo.UseShellExecute = true;
			process.Start();
			process.WaitForExit(2500);
			try
			{
				if (File.Exists(executablePath.Substring(0, executablePath.LastIndexOf("\\")) + "\\CP.xml"))
				{
					File.Delete(executablePath.Substring(0, executablePath.LastIndexOf("\\")) + "\\CP.xml");
				}
			}
			catch (Exception projectError2)
			{
				ProjectData.SetProjectError(projectError2);
				ProjectData.ClearProjectError();
			}
			return true;
		}
		catch (Exception projectError3)
		{
			ProjectData.SetProjectError(projectError3);
			bool result = false;
			ProjectData.ClearProjectError();
			return result;
		}
	}

	private void dn(object sender, EventArgs e)
	{
		SliderClick(PictureBox9);
		if (WinStart)
		{
			WinStart = false;
			CMDcuRSP("SCHTASKS /Delete /TN \"CyberProt\" /F ");
			CreateLog("Autostart disabled", "Autostart has been disabled", (EventLogEntryType)2, Repair: true, 1);
			return;
		}
		WinStart = true;
		if (!AddToStartUP())
		{
			SliderClick(PictureBox9);
			WinStart = false;
			ShowMessageBox("Something went wrong!", "Cyber Prot", (MessageBoxButtons)0, (MessageBoxIcon)16);
		}
		else
		{
			CreateLog("Autostart enabled", "Autostart has been enabled", (EventLogEntryType)2, Repair: true, 1);
		}
	}

	public string Encrypt(string plainText)
	{
		try
		{
			string strPassword = "STEAUA";
			string text = "BUCURESTI";
			string strHashName = "SHA1";
			string text2 = "@1B2c3D4e5F6g7H8";
			byte[] bytes = Encoding.ASCII.GetBytes(text2);
			byte[] bytes2 = Encoding.ASCII.GetBytes(text);
			byte[] bytes3 = Encoding.UTF8.GetBytes(plainText);
			byte[] bytes4 = new PasswordDeriveBytes(strPassword, bytes2, strHashName, 2).GetBytes(32);
			ICryptoTransform transform = new RijndaelManaged
			{
				Mode = CipherMode.CBC
			}.CreateEncryptor(bytes4, bytes);
			MemoryStream memoryStream = new MemoryStream();
			CryptoStream cryptoStream = new CryptoStream(memoryStream, transform, CryptoStreamMode.Write);
			cryptoStream.Write(bytes3, 0, bytes3.Length);
			cryptoStream.FlushFinalBlock();
			byte[] inArray = memoryStream.ToArray();
			memoryStream.Close();
			cryptoStream.Close();
			return Convert.ToBase64String(inArray);
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
			return plainText;
		}
	}

	public string Decrypt(string cipherText)
	{
		try
		{
			string strPassword = "STEAUA";
			string text = "BUCURESTI";
			string strHashName = "SHA1";
			string text2 = "@1B2c3D4e5F6g7H8";
			byte[] bytes = Encoding.ASCII.GetBytes(text2);
			byte[] bytes2 = Encoding.ASCII.GetBytes(text);
			byte[] array = Convert.FromBase64String(cipherText);
			byte[] bytes3 = new PasswordDeriveBytes(strPassword, bytes2, strHashName, 2).GetBytes(32);
			ICryptoTransform transform = new RijndaelManaged
			{
				Mode = CipherMode.CBC
			}.CreateDecryptor(bytes3, bytes);
			MemoryStream memoryStream = new MemoryStream(array);
			CryptoStream cryptoStream = new CryptoStream(memoryStream, transform, CryptoStreamMode.Read);
			byte[] array2 = new byte[checked(array.Length - 1 + 1)];
			int count = cryptoStream.Read(array2, 0, array2.Length);
			memoryStream.Close();
			cryptoStream.Close();
			return Encoding.UTF8.GetString(array2, 0, count);
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
			return cipherText;
		}
	}

	public void ShowMessageBox(string textToShow, string caption, MessageBoxButtons buttons, MessageBoxIcon icon)
	{
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		((Control)this).BeginInvoke((Delegate)(global::a)delegate
		{
			//IL_000d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0013: Unknown result type (might be due to invalid IL or missing references)
			//IL_0018: Unknown result type (might be due to invalid IL or missing references)
			MessageBox.Show(textToShow, caption, buttons, icon);
		});
	}

	public void UpdatePB(PictureBox txtBox, bool value)
	{
		if (((Control)txtBox).get_InvokeRequired())
		{
			((Control)txtBox).Invoke((Delegate)(global::a)delegate
			{
				UpdatePB(txtBox, value);
			});
		}
		else
		{
			((Control)txtBox).set_Visible(value);
		}
	}

	private void dm(object sender, EventArgs e)
	{
		if (CredentalRequired)
		{
			CredentalRequired = false;
		}
		else
		{
			CredentalRequired = true;
		}
	}

	private void dl(object sender, EventArgs e)
	{
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Invalid comparison between Unknown and I4
		SliderClick(PictureBox27);
		if (DisableTraps)
		{
			if ((int)MessageBox.Show((IWin32Window)(object)this, "If you disable heuristic engine, your data is at risk from new ransomware versions, that are not yet in the definitions database. If you have problems with false positive alerts, it's better to use the white lists to avoid them. Are you sure you need to disable the heuristic engine?", "Are you sure?", (MessageBoxButtons)4, (MessageBoxIcon)48) == 7)
			{
				SliderClick(PictureBox27);
				return;
			}
			DisableTraps = false;
			CreateLog("Heuristic engine disabled", "Heuristic engine has been disabled", (EventLogEntryType)2, Repair: true, 1);
		}
		else
		{
			DisableTraps = true;
			CreateLog("Heuristic engine enabled", "Heuristic engine has been enabled", (EventLogEntryType)2, Repair: true, 1);
		}
	}

	private void dk(object sender, EventArgs e)
	{
		if (DisableRenamesScan)
		{
			DisableRenamesScan = false;
		}
		else
		{
			DisableRenamesScan = true;
		}
	}

	public void CallService(int T = 0)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected O, but got Unknown
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Invalid comparison between Unknown and I4
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			ServiceController val = new ServiceController("CyberProtService");
			if ((int)val.get_Status() != 4)
			{
				val.Start();
				return;
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
		try
		{
			new ServiceController("CyberProtService").ExecuteCommand(checked(201 + T));
		}
		catch (Exception projectError2)
		{
			ProjectData.SetProjectError(projectError2);
			ProjectData.ClearProjectError();
		}
		ClearMem();
	}

	private void dj(object sender, EventArgs e)
	{
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Expected O, but got Unknown
		Font font = new Font(((Control)Label1).get_Font().get_Name(), ((Control)Label1).get_Font().get_Size(), (FontStyle)4);
		((Control)Label1).set_Font(font);
	}

	private void di(object sender, EventArgs e)
	{
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Expected O, but got Unknown
		Font font = new Font(((Control)Label1).get_Font().get_Name(), ((Control)Label1).get_Font().get_Size(), (FontStyle)0);
		((Control)Label1).set_Font(font);
	}

	private void dh(object sender, EventArgs e)
	{
		SwitchPanels(StatusPanelMain);
	}

	private void dg(object sender, EventArgs e)
	{
		SwitchPanels(GeneralSettingsPanelMain);
	}

	private void df(object sender, EventArgs e)
	{
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Expected O, but got Unknown
		Font font = new Font(((Control)Label2).get_Font().get_Name(), ((Control)Label2).get_Font().get_Size(), (FontStyle)4);
		((Control)Label2).set_Font(font);
	}

	private void de(object sender, EventArgs e)
	{
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Expected O, but got Unknown
		Font font = new Font(((Control)Label2).get_Font().get_Name(), ((Control)Label2).get_Font().get_Size(), (FontStyle)0);
		((Control)Label2).set_Font(font);
	}

	private void dd(object sender, EventArgs e)
	{
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Expected O, but got Unknown
		Font font = new Font(((Control)Label7).get_Font().get_Name(), ((Control)Label7).get_Font().get_Size(), (FontStyle)4);
		((Control)Label7).set_Font(font);
	}

	private void dc(object sender, EventArgs e)
	{
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Expected O, but got Unknown
		Font font = new Font(((Control)Label7).get_Font().get_Name(), ((Control)Label7).get_Font().get_Size(), (FontStyle)0);
		((Control)Label7).set_Font(font);
	}

	private void db(object sender, EventArgs e)
	{
		SwitchPanels(ActionsPanelMain);
	}

	private void da(object sender, EventArgs e)
	{
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Expected O, but got Unknown
		Font font = new Font(((Control)Label5).get_Font().get_Name(), ((Control)Label5).get_Font().get_Size(), (FontStyle)4);
		((Control)Label5).set_Font(font);
	}

	private void c9(object sender, EventArgs e)
	{
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Expected O, but got Unknown
		Font font = new Font(((Control)Label5).get_Font().get_Name(), ((Control)Label5).get_Font().get_Size(), (FontStyle)0);
		((Control)Label5).set_Font(font);
	}

	private void c8(object sender, EventArgs e)
	{
		this.m_s.Deactivate();
		licentiere();
	}

	private void c7(object sender, EventArgs e)
	{
		this.m_s.Activate();
		licentiere();
	}

	public void UpdateIMG(PictureBox txtBox, Image value)
	{
		try
		{
			if (((Control)txtBox).get_InvokeRequired())
			{
				((Control)txtBox).Invoke((Delegate)(global::a)delegate
				{
					UpdateIMG(txtBox, value);
				});
			}
			else
			{
				txtBox.set_Image(value);
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	[MethodImpl(MethodImplOptions.NoOptimization)]
	private void c6(object sender, EventArgs e)
	{
		Timer1.set_Enabled(false);
		Timer1.set_Interval(1000);
		if (Operators.CompareString(LicenseStatus.get_Text(), "Product status", false) == 0)
		{
			Application.Exit();
			ProjectData.EndApp();
		}
		if (this.m_u)
		{
			try
			{
				if (Conversions.ToBoolean(Operators.OrObject(Operators.CompareObjectEqual(((Control)LicenseStatus).get_Tag(), (object)"trial", false), Operators.CompareObjectEqual(((Control)LicenseStatus).get_Tag(), (object)"license", false))))
				{
					if (this.m_s.get_IsActivated() & (this.m_s.get_InvalidReason() != null))
					{
						if (Operators.ConditionalCompareObjectEqual(((Control)LicenseStatus).get_Tag(), (object)"license", false))
						{
							NotifyIcon1.ShowBalloonTip(30000, "Cyber Prot", Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject((object)"Your ", ((Control)LicenseStatus).get_Tag()), (object)" is expired! You are no longer protected!")), (ToolTipIcon)3);
						}
					}
					else if (Operators.ConditionalCompareObjectLess(((Control)TrialStatus).get_Tag(), (object)0, false))
					{
						NotifyIcon1.ShowBalloonTip(30000, "Cyber Prot", Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject((object)"Your ", ((Control)LicenseStatus).get_Tag()), (object)" is expired! You are no longer protected!")), (ToolTipIcon)3);
					}
					else if (Operators.ConditionalCompareObjectLessEqual(((Control)TrialStatus).get_Tag(), (object)1, false))
					{
						NotifyIcon1.ShowBalloonTip(30000, "Cyber Prot", Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject((object)"Your ", ((Control)LicenseStatus).get_Tag()), (object)" expires today!")), (ToolTipIcon)2);
					}
					else if (Operators.ConditionalCompareObjectEqual(((Control)TrialStatus).get_Tag(), (object)2, false))
					{
						NotifyIcon1.ShowBalloonTip(30000, "Cyber Prot", Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject((object)"Your ", ((Control)LicenseStatus).get_Tag()), (object)" will expire tomorrow!")), (ToolTipIcon)2);
					}
					else if (Conversions.ToBoolean(Operators.AndObject(Operators.CompareObjectGreater(((Control)TrialStatus).get_Tag(), (object)2, false), Operators.CompareObjectLess(((Control)TrialStatus).get_Tag(), (object)8, false))))
					{
						NotifyIcon1.ShowBalloonTip(30000, "Cyber Prot", Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject((object)"Your ", ((Control)LicenseStatus).get_Tag()), (object)" will expire in "), ((Control)TrialStatus).get_Tag()), (object)" days!")), (ToolTipIcon)2);
					}
				}
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
			}
		}
		if (this.m_u)
		{
			this.m_u = false;
			ClearMem();
		}
		StatusCheck();
		try
		{
			string text = Conversions.ToString(Registry.LocalMachine.CreateSubKey("SOFTWARE\\Cyber Prot", RegistryKeyPermissionCheck.ReadWriteSubTree).GetValue("MSGV", ""));
			Registry.LocalMachine.CreateSubKey("SOFTWARE\\Cyber Prot", RegistryKeyPermissionCheck.ReadWriteSubTree).SetValue("MSGV", "");
			if (Operators.CompareString(text, "0", false) == 0)
			{
				RefreshQuarantine();
			}
		}
		catch (Exception projectError2)
		{
			ProjectData.SetProjectError(projectError2);
			ProjectData.ClearProjectError();
		}
	}

	public void StatusCheck()
	{
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Expected O, but got Unknown
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Invalid comparison between Unknown and I4
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Invalid comparison between Unknown and I4
		//IL_0348: Unknown result type (might be due to invalid IL or missing references)
		//IL_034e: Invalid comparison between Unknown and I4
		Timer1.set_Enabled(false);
		int num = default(int);
		if (!ENG)
		{
			try
			{
				try
				{
					ServiceController val = new ServiceController("CyberProtService");
					Label label = Label56;
					ServiceControllerStatus status = val.get_Status();
					((Control)label).set_Tag((object)((Enum)(ServiceControllerStatus)(ref status)).ToString());
					status = val.get_Status();
					if ((int)status != 1)
					{
						if ((int)status == 4)
						{
							Label55.set_Text("You are protected");
							((Control)PictureBox66).set_Tag((object)"Stop");
							if (this.m_t)
							{
								PictureBox54.set_Image(ImageList2.get_Images().get_Item(0));
								ChangeIcon(0);
							}
							else
							{
								PictureBox54.set_Image(ImageList2.get_Images().get_Item(1));
								ChangeIcon(1);
							}
						}
						else
						{
							((Control)Label56).set_Tag((object)"Working");
							((Control)PictureBox66).set_Tag((object)"Working");
							Label55.set_Text("You are at risk");
							if (this.m_t)
							{
								PictureBox54.set_Image(ImageList2.get_Images().get_Item(2));
								ChangeIcon(2);
							}
							else
							{
								PictureBox54.set_Image(ImageList2.get_Images().get_Item(1));
								ChangeIcon(1);
							}
						}
					}
					else
					{
						Label55.set_Text("You are at risk");
						((Control)PictureBox66).set_Tag((object)"Start");
						PictureBox54.set_Image(ImageList2.get_Images().get_Item(1));
						ChangeIcon(1);
					}
					val = null;
				}
				catch (Exception ex)
				{
					ProjectData.SetProjectError(ex, num);
					((Control)PictureBox66).set_Tag((object)"Start");
					Label56.set_Text("Service error");
					PictureBox54.set_Image(ImageList2.get_Images().get_Item(1));
					ChangeIcon(1);
					ProjectData.ClearProjectError();
				}
				object tag = ((Control)PictureBox66).get_Tag();
				if (Operators.ConditionalCompareObjectEqual(tag, (object)"Stop", false))
				{
					UpdateIMG(PictureBox66, ImageList1.get_Images().get_Item(0));
				}
				else if (Operators.ConditionalCompareObjectEqual(tag, (object)"Start", false))
				{
					UpdateIMG(PictureBox66, ImageList1.get_Images().get_Item(1));
				}
				else
				{
					UpdateIMG(PictureBox66, ImageList1.get_Images().get_Item(2));
				}
				if (((Control)Label56).get_Tag() != null)
				{
					Label56.set_Text(Conversions.ToString(((Control)Label56).get_Tag()));
				}
				try
				{
				}
				catch (Exception ex2)
				{
					ProjectData.SetProjectError(ex2, num);
					ProjectData.ClearProjectError();
				}
				try
				{
					string text = Conversions.ToString(Registry.LocalMachine.CreateSubKey("SOFTWARE\\Cyber Prot", RegistryKeyPermissionCheck.ReadWriteSubTree).GetValue("MSG", ""));
					if (Operators.CompareString(text, "", false) != 0)
					{
						Registry.LocalMachine.CreateSubKey("SOFTWARE\\Cyber Prot", RegistryKeyPermissionCheck.ReadWriteSubTree).SetValue("MSG", "");
						if (Operators.CompareString(text, "UP", false) == 0)
						{
							if ((((Control)this).get_Top() == 0) & (((Control)this).get_Left() == 0))
							{
								((Form)this).CenterToScreen();
							}
							if ((int)((Form)this).get_WindowState() == 1)
							{
								SwitchPanels(StatusPanelMain);
							}
							((Control)this).Refresh();
							((Control)this).set_Visible(true);
							((Form)this).set_WindowState((FormWindowState)0);
							if ((((Control)this).get_Top() == 0) & (((Control)this).get_Left() == 0))
							{
								((Form)this).CenterToScreen();
							}
							((Form)this).set_TopMost(true);
							Application.DoEvents();
							((Form)this).set_TopMost(false);
						}
						else
						{
							try
							{
								int num2 = checked((int)Math.Round(Conversion.Val(text.Substring(0, 1))));
								text = text.Substring(1);
								NotifyIcon1.set_Tag((object)"0");
								switch (num2)
								{
								default:
									NotifyIcon1.ShowBalloonTip(30000, "Cyber Prot", text, (ToolTipIcon)2);
									break;
								case 0:
									NotifyIcon1.ShowBalloonTip(30000, "Cyber Prot", text, (ToolTipIcon)1);
									break;
								case 1:
									NotifyIcon1.ShowBalloonTip(30000, "Cyber Prot", text, (ToolTipIcon)2);
									break;
								case 2:
									NotifyIcon1.ShowBalloonTip(30000, "Cyber Prot", text, (ToolTipIcon)3);
									NotifyIcon1.set_Tag((object)"1");
									break;
								}
								if (text.StartsWith("Ransomware definitions "))
								{
									databaseVersion();
								}
							}
							catch (Exception ex3)
							{
								ProjectData.SetProjectError(ex3, num);
								ProjectData.ClearProjectError();
							}
						}
					}
				}
				catch (Exception ex4)
				{
					ProjectData.SetProjectError(ex4, num);
					ProjectData.ClearProjectError();
				}
			}
			catch (Exception ex5)
			{
				ProjectData.SetProjectError(ex5, num);
				ProjectData.ClearProjectError();
			}
		}
		num = 11;
		Timer1.set_Enabled(true);
	}

	private void c5(object sender, EventArgs e)
	{
		SliderClick(PictureBox57);
		if (AppdataExec)
		{
			AppdataExec = false;
			CreateLog("Proactive protection disabled", "Proactive protection has been disabled", (EventLogEntryType)2, Repair: true, 1);
		}
		else
		{
			AppdataExec = true;
			CreateLog("Proactive protection enabled", "Proactive protection has been enabled", (EventLogEntryType)2, Repair: true, 1);
		}
	}

	public static string CMDcuRSP(string Comanda)
	{
		string text = "";
		try
		{
			Process process = new Process();
			process.StartInfo = new ProcessStartInfo
			{
				FileName = "cmd",
				RedirectStandardInput = true,
				RedirectStandardOutput = true,
				WindowStyle = ProcessWindowStyle.Hidden,
				CreateNoWindow = true,
				UseShellExecute = false
			};
			process.Start();
			StreamReader standardOutput = process.StandardOutput;
			StreamWriter standardInput = process.StandardInput;
			standardInput.WriteLine(Comanda);
			standardInput.WriteLine("exit\r");
			process.WaitForExit(3000);
			text = standardOutput.ReadToEnd();
			standardInput.Close();
			standardOutput.Close();
			process.Dispose();
			return text;
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			text = "ERROR";
			ProjectData.ClearProjectError();
			return text;
		}
	}

	private void g(object sender, MouseEventArgs e)
	{
		((TextBoxBase)MaskedTextBox1).SelectAll();
	}

	private void c4(object sender, EventArgs e)
	{
		try
		{
			Process.Start("http://www.cyberland.ro/index.html#buy");
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	private void c3(object sender, EventArgs e)
	{
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Expected O, but got Unknown
		if (((Control)Panel20).get_Visible())
		{
			((Control)Panel20).set_Visible(false);
			return;
		}
		((Control)Label36).set_Cursor(Cursors.get_Arrow());
		((TextBoxBase)MaskedTextBox1).Clear();
		Font font = new Font(((Control)Label1).get_Font().get_Name(), ((Control)Label1).get_Font().get_Size(), (FontStyle)0);
		((Control)Label36).set_Font(font);
		if (!Label36.get_Text().StartsWith("Re"))
		{
			((Control)Panel20).set_Visible(true);
			((Control)MaskedTextBox1).Focus();
			((TextBoxBase)MaskedTextBox1).SelectAll();
		}
		else
		{
			bq(null, null);
		}
	}

	private void c2(object sender, EventArgs e)
	{
		((Control)Panel20).set_Visible(true);
	}

	private void c1(object sender, EventArgs e)
	{
		try
		{
			this.m_s.Deactivate();
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
		try
		{
			this.m_s.Activate();
		}
		catch (Exception projectError2)
		{
			ProjectData.SetProjectError(projectError2);
			ProjectData.ClearProjectError();
		}
		licentiere();
	}

	public void ChangeIcon(object X)
	{
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Invalid comparison between Unknown and I4
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Expected O, but got Unknown
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		//IL_006b: Invalid comparison between Unknown and I4
		if (Operators.ConditionalCompareObjectEqual(X, (object)this.m_v, false))
		{
			return;
		}
		try
		{
			if (Conversions.ToBoolean(Operators.AndObject(Operators.AndObject(Operators.CompareObjectGreaterEqual(((Control)TrialStatus).get_Tag(), (object)0, false), (object)((int)((Form)this).get_WindowState() == 1)), (object)this.m_r)))
			{
				ServiceController val = new ServiceController("CyberProtService");
				if ((int)val.get_Status() != 4)
				{
					val.Start();
				}
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
		try
		{
			this.m_v = Conversions.ToInteger(X);
			NotifyIcon notifyIcon = NotifyIcon1;
			ImageCollection images = ImageList3.get_Images();
			object[] obj = new object[1] { X };
			object[] array = obj;
			bool[] obj2 = new bool[1] { true };
			bool[] array2 = obj2;
			object obj3 = NewLateBinding.LateGet((object)images, (Type)null, "Item", obj, (string[])null, (Type[])null, obj2);
			if (array2[0])
			{
				X = RuntimeHelpers.GetObjectValue(array[0]);
			}
			object obj4 = NewLateBinding.LateGet(obj3, (Type)null, "GetHicon", new object[0], (string[])null, (Type[])null, (bool[])null);
			notifyIcon.set_Icon(Icon.FromHandle((obj4 != null) ? ((IntPtr)obj4) : default(IntPtr)));
		}
		catch (Exception projectError2)
		{
			ProjectData.SetProjectError(projectError2);
			NotifyIcon1.set_Icon(((Form)this).get_Icon());
			ProjectData.ClearProjectError();
		}
		if (Operators.ConditionalCompareObjectEqual(X, (object)0, false))
		{
			NotifyIcon1.set_Text("Cyber Prot v" + ((Control)this).get_ProductVersion().ToString() + "\r\nStatus: Protected");
		}
		else
		{
			NotifyIcon1.set_Text("Cyber Prot v" + ((Control)this).get_ProductVersion().ToString() + "\r\nStatus: Not protected");
		}
	}

	private void c0(object sender, EventArgs e)
	{
		Update(Er: true);
	}

	private void cz(object sender, EventArgs e)
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Invalid comparison between Unknown and I4
		Update(Er: false, SH: true);
		if ((int)((Form)this).get_WindowState() != 1)
		{
			return;
		}
		try
		{
			if (Conversions.ToBoolean(Operators.OrObject(Operators.CompareObjectEqual(((Control)LicenseStatus).get_Tag(), (object)"trial", false), Operators.CompareObjectEqual(((Control)LicenseStatus).get_Tag(), (object)"license", false))) && Conversions.ToBoolean(Operators.AndObject(Operators.CompareObjectGreater(((Control)TrialStatus).get_Tag(), (object)2, false), Operators.CompareObjectLess(((Control)TrialStatus).get_Tag(), (object)8, false))))
			{
				NotifyIcon1.ShowBalloonTip(30000, "Cyber Prot", Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject((object)"Your ", ((Control)LicenseStatus).get_Tag()), (object)" will expire in "), ((Control)TrialStatus).get_Tag()), (object)" days!")), (ToolTipIcon)2);
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	[DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
	private static extern bool SetProcessWorkingSetSize(IntPtr A_0, int A_1, int A_2);

	public void ClearMem()
	{
		try
		{
			GC.Collect();
			GC.WaitForPendingFinalizers();
			SetProcessWorkingSetSize(Process.GetCurrentProcess().Handle, -1, -1);
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	private void cy(object sender, EventArgs e)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Invalid comparison between Unknown and I4
		//IL_021b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0220: Unknown result type (might be due to invalid IL or missing references)
		//IL_0226: Invalid comparison between Unknown and I4
		licentiere();
		databaseVersion();
		ClearMem();
		if ((int)((Form)this).get_WindowState() != 1 || Operators.ConditionalCompareObjectEqual(((Control)LicenseStatus).get_Tag(), (object)"", false))
		{
			return;
		}
		try
		{
			if (Conversions.ToBoolean(Operators.OrObject(Operators.CompareObjectEqual(((Control)LicenseStatus).get_Tag(), (object)"trial", false), Operators.CompareObjectEqual(((Control)LicenseStatus).get_Tag(), (object)"license", false))))
			{
				if (this.m_s.get_IsActivated() & (this.m_s.get_InvalidReason() != null))
				{
					if (Operators.ConditionalCompareObjectEqual(((Control)LicenseStatus).get_Tag(), (object)"license", false))
					{
						NotifyIcon1.ShowBalloonTip(30000, "Cyber Prot", Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject((object)"Your ", ((Control)LicenseStatus).get_Tag()), (object)" is expired! You are no longer protected!")), (ToolTipIcon)3);
					}
				}
				else if (Operators.ConditionalCompareObjectLess(((Control)TrialStatus).get_Tag(), (object)0, false))
				{
					NotifyIcon1.ShowBalloonTip(30000, "Cyber Prot", Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject((object)"Your ", ((Control)LicenseStatus).get_Tag()), (object)" is expired! You are no longer protected!")), (ToolTipIcon)3);
				}
				else if (Operators.ConditionalCompareObjectLessEqual(((Control)TrialStatus).get_Tag(), (object)1, false))
				{
					NotifyIcon1.ShowBalloonTip(30000, "Cyber Prot", Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject((object)"Your ", ((Control)LicenseStatus).get_Tag()), (object)" expires today!")), (ToolTipIcon)2);
				}
				else if (Operators.ConditionalCompareObjectEqual(((Control)TrialStatus).get_Tag(), (object)2, false))
				{
					NotifyIcon1.ShowBalloonTip(30000, "Cyber Prot", Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject((object)"Your ", ((Control)LicenseStatus).get_Tag()), (object)" will expire tomorrow!")), (ToolTipIcon)2);
				}
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
		try
		{
			if (Operators.ConditionalCompareObjectGreaterEqual(((Control)TrialStatus).get_Tag(), (object)0, false) && (int)new ServiceController("CyberProtService").get_Status() != 4)
			{
				NotifyIcon1.ShowBalloonTip(30000, "Cyber Prot", "Cyber Prot Engine is not running!\r\nYou should enable it ASAP!", (ToolTipIcon)3);
			}
		}
		catch (Exception projectError2)
		{
			ProjectData.SetProjectError(projectError2);
			ProjectData.ClearProjectError();
		}
	}

	private void cx(object sender, EventArgs e)
	{
		SwitchPanels(AdvancedPanelMain);
		((Control)Panel23).set_Visible(false);
	}

	private void cw(object sender, EventArgs e)
	{
		SwitchPanels(AdvancedPanelMain);
		((Control)Panel23).set_Visible(false);
	}

	private void cv(object sender, EventArgs e)
	{
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Expected O, but got Unknown
		Font font = new Font(((Control)Label50).get_Font().get_Name(), ((Control)Label50).get_Font().get_Size(), (FontStyle)4);
		((Control)Label50).set_Font(font);
	}

	private void cu(object sender, EventArgs e)
	{
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Expected O, but got Unknown
		Font font = new Font(((Control)Label50).get_Font().get_Name(), ((Control)Label50).get_Font().get_Size(), (FontStyle)4);
		((Control)Label50).set_Font(font);
	}

	private void ct(object sender, EventArgs e)
	{
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Expected O, but got Unknown
		Font font = new Font(((Control)Label50).get_Font().get_Name(), ((Control)Label50).get_Font().get_Size(), (FontStyle)0);
		((Control)Label50).set_Font(font);
	}

	private void cs(object sender, EventArgs e)
	{
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Expected O, but got Unknown
		Font font = new Font(((Control)Label50).get_Font().get_Name(), ((Control)Label50).get_Font().get_Size(), (FontStyle)0);
		((Control)Label50).set_Font(font);
	}

	public void MakeFilterList()
	{
		List<string> list = new List<string>();
		List<string> list2 = new List<string>();
		try
		{
			foreach (string like in this.m_q.Likes)
			{
				list2.Add(like);
			}
			foreach (string item in this.m_q.Standard)
			{
				list.Add(item);
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	public List<string> MakeAppsList()
	{
		return new List<string>
		{
			"ADE", "ADP", "BAS", "CHM", "CRT", "HLP", "HTA", "ISP", "MDB", "MDE",
			"OCX", "PCD", "URL", "WSC", "BAT", "CMD", "COM", "CPL", "EXE", "GADGET",
			"INF", "INS", "INX", "ISU", "JOB", "JSE", "MSC", "MSI", "MSP", "MST",
			"PAF", "PIF", "PS1", "REG", "RGS", "SCR", "SCT", "SHB", "SHS", "U3P",
			"VB", "VBE", "VBS", "VBSCRIPT", "WS", "WSF", "WSH", "BIN", "JS", "DOCM",
			"XLSM", "PPSM"
		};
	}

	private void cr(object sender, EventArgs e)
	{
		//IL_00a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ab: Invalid comparison between Unknown and I4
		bool flag = false;
		try
		{
			string[] files = Directory.GetFiles(new Uri(Path.GetDirectoryName(Assembly.GetExecutingAssembly().CodeBase)).LocalPath + "\\", "*.lic");
			if (0 < files.Length)
			{
				flag = true;
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
		try
		{
			string[] files2 = Directory.GetFiles(new Uri(Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData) + "\\IPManager").LocalPath + "\\", "*.lic");
			if (0 < files2.Length)
			{
				flag = true;
			}
		}
		catch (Exception projectError2)
		{
			ProjectData.SetProjectError(projectError2);
			ProjectData.ClearProjectError();
		}
		if (flag && (int)MessageBox.Show("If you remove the subscription for this computer your data will no longer be protected!\r\nAre you sure you want to remove it?", "Cyber Prot", (MessageBoxButtons)4, (MessageBoxIcon)48) != 6)
		{
			return;
		}
		try
		{
			this.m_s.Deactivate();
		}
		catch (Exception projectError3)
		{
			ProjectData.SetProjectError(projectError3);
			ProjectData.ClearProjectError();
		}
		checked
		{
			try
			{
				string[] files3 = Directory.GetFiles(new Uri(Path.GetDirectoryName(Assembly.GetExecutingAssembly().CodeBase)).LocalPath + "\\", "*.lic");
				for (int i = 0; i < files3.Length; i++)
				{
					File.Delete(files3[i]);
				}
			}
			catch (Exception projectError4)
			{
				ProjectData.SetProjectError(projectError4);
				ProjectData.ClearProjectError();
			}
			try
			{
				string[] files4 = Directory.GetFiles(new Uri(Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData) + "\\IPManager").LocalPath + "\\", "*.lic");
				for (int j = 0; j < files4.Length; j++)
				{
					File.Delete(files4[j]);
				}
			}
			catch (Exception projectError5)
			{
				ProjectData.SetProjectError(projectError5);
				ProjectData.ClearProjectError();
			}
			CreateLog("License disabled", "The Cyber Prot's license for this computer has been removed", (EventLogEntryType)2, Repair: true, 7);
			((Control)Label42).set_Visible(false);
			Label36.set_Text("Activate license");
			licentiere();
			c3(null, null);
		}
	}

	[MethodImpl(MethodImplOptions.NoOptimization)]
	private void cq(object sender, EventArgs e)
	{
		Timer4.set_Enabled(false);
		try
		{
			if (File.Exists(Application.get_StartupPath() + "\\LicenseSpot.Framework.dll"))
			{
				return;
			}
			try
			{
				Thread thread = new Thread(StartUpdate);
				thread.Start();
				while (thread.IsAlive)
				{
					Thread.Sleep(50);
					Application.DoEvents();
				}
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				Process.Start("http://www.cyberland.ro/download");
				ProjectData.ClearProjectError();
			}
			Application.Exit();
			ProjectData.EndApp();
		}
		catch (Exception projectError2)
		{
			ProjectData.SetProjectError(projectError2);
			ProjectData.ClearProjectError();
		}
	}

	private void cp(object sender, EventArgs e)
	{
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			Process.Start("https://www.facebook.com/cyberlandprot");
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			try
			{
				Process.Start("iexplore.exe", "https://www.facebook.com/cyberlandprot");
			}
			catch (Exception projectError2)
			{
				ProjectData.SetProjectError(projectError2);
				MessageBox.Show("Can't open your browser!\r\nPlease visit https://www.facebook.com/cyberlandpro", "Cyber Prot", (MessageBoxButtons)0, (MessageBoxIcon)16);
				ProjectData.ClearProjectError();
			}
			ProjectData.ClearProjectError();
		}
	}

	private void co(object sender, EventArgs e)
	{
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			Process.Start("https://www.youtube.com/channel/UC5iwANq7TKdDID4r_6gQw_A");
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			try
			{
				Process.Start("iexplore.exe", "https://www.youtube.com/channel/UC5iwANq7TKdDID4r_6gQw_A");
			}
			catch (Exception projectError2)
			{
				ProjectData.SetProjectError(projectError2);
				MessageBox.Show("Can't open your browser!\r\nPlease visit https://www.youtube.com/channel/UC5iwANq7TKdDID4r_6gQw_A", "Cyber Prot", (MessageBoxButtons)0, (MessageBoxIcon)16);
				ProjectData.ClearProjectError();
			}
			ProjectData.ClearProjectError();
		}
	}

	private void cn(object sender, EventArgs e)
	{
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			Process.Start("http://cyberland.ro/");
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			try
			{
				Process.Start("iexplore.exe", "http://cyberland.ro/");
			}
			catch (Exception projectError2)
			{
				ProjectData.SetProjectError(projectError2);
				MessageBox.Show("Can't open your browser!\r\nPlease visit http://cyberland.ro/", "Cyber Prot", (MessageBoxButtons)0, (MessageBoxIcon)16);
				ProjectData.ClearProjectError();
			}
			ProjectData.ClearProjectError();
		}
	}

	private void cm(object sender, EventArgs e)
	{
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			if (!OpenEmail("feedback@cyberland.ro", "Cyber Prot feedback message"))
			{
				MessageBox.Show("Can't send mail!\r\nPlease manually send a mail to feedback@cyberland.ro", "Cyber Prot", (MessageBoxButtons)0, (MessageBoxIcon)16);
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			MessageBox.Show("Can't open your default mail program!\r\nPlease manually send a mail to feedback@cyberland.ro", "Cyber Prot", (MessageBoxButtons)0, (MessageBoxIcon)16);
			ProjectData.ClearProjectError();
		}
	}

	public bool OpenEmail(string EmailAddress, string Subject = "", string Body = "")
	{
		bool result = true;
		try
		{
			string text = EmailAddress;
			if (Operators.CompareString(Strings.LCase(Strings.Left(text, 7)), "mailto:", false) != 0)
			{
				text = "mailto:" + text;
			}
			if (Operators.CompareString(Subject, "", false) != 0)
			{
				text = text + "?subject=" + Subject;
			}
			if (Operators.CompareString(Body, "", false) != 0)
			{
				text = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject((object)text, Interaction.IIf(Operators.CompareString(Subject, "", false) == 0, (object)"?", (object)"&")), (object)"body="), (object)Body));
			}
			Process.Start(text);
			return result;
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			result = false;
			ProjectData.ClearProjectError();
			return result;
		}
	}

	private void e(object sender, CancelEventArgs e)
	{
		CreateLog("Application stopped", "Application stopped", (EventLogEntryType)4, Repair: true, 4);
		NotifyIcon1.set_Visible(false);
	}

	private void f(object sender, MouseEventArgs e)
	{
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Invalid comparison between Unknown and I4
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Invalid comparison between Unknown and I4
		int try0000_dispatch = -1;
		int num = default(int);
		int num2 = default(int);
		int num3 = default(int);
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				switch (try0000_dispatch)
				{
				default:
					num = 1;
					Application.DoEvents();
					goto IL_0007;
				case 288:
					{
						num2 = num;
						switch (num3)
						{
						case 1:
							break;
						default:
							goto end_IL_0000;
						}
						int num4 = num2 + 1;
						num2 = 0;
						switch (num4)
						{
						case 1:
							break;
						case 2:
							goto IL_0007;
						case 3:
							goto IL_000e;
						case 5:
							goto IL_002b;
						case 6:
							goto IL_003d;
						case 7:
							goto IL_0054;
						case 8:
							goto IL_005c;
						case 9:
							goto IL_0065;
						case 10:
							goto IL_0071;
						case 11:
							goto IL_0080;
						case 12:
							goto IL_008a;
						case 13:
							goto IL_00a2;
						case 14:
							goto IL_00ab;
						case 15:
							goto IL_00b5;
						case 16:
							goto end_IL_0000_2;
						default:
							goto end_IL_0000;
						case 4:
						case 17:
							goto end_IL_0000_3;
						}
						goto default;
					}
					IL_00b5:
					num = 15;
					Application.DoEvents();
					break;
					IL_0007:
					ProjectData.ClearProjectError();
					num3 = 1;
					goto IL_000e;
					IL_000e:
					num = 3;
					if (Operators.CompareString(LicenseStatus.get_Text(), "Product status", false) == 0)
					{
						goto end_IL_0000_3;
					}
					goto IL_002b;
					IL_002b:
					num = 5;
					if ((int)e.get_Button() != 1048576)
					{
						goto end_IL_0000_3;
					}
					goto IL_003d;
					IL_003d:
					num = 6;
					if ((((Control)this).get_Top() == 0) & (((Control)this).get_Left() == 0))
					{
						goto IL_0054;
					}
					goto IL_005c;
					IL_0054:
					num = 7;
					((Form)this).CenterToScreen();
					goto IL_005c;
					IL_005c:
					num = 8;
					((Control)this).set_Visible(true);
					goto IL_0065;
					IL_0065:
					num = 9;
					if ((int)((Form)this).get_WindowState() == 1)
					{
						goto IL_0071;
					}
					goto IL_0080;
					IL_0071:
					num = 10;
					SwitchPanels(StatusPanelMain);
					goto IL_0080;
					IL_0080:
					num = 11;
					((Form)this).set_WindowState((FormWindowState)0);
					goto IL_008a;
					IL_008a:
					num = 12;
					if ((((Control)this).get_Top() == 0) & (((Control)this).get_Left() == 0))
					{
						goto IL_00a2;
					}
					goto IL_00ab;
					IL_00a2:
					num = 13;
					((Form)this).CenterToScreen();
					goto IL_00ab;
					IL_00ab:
					num = 14;
					((Form)this).set_TopMost(true);
					goto IL_00b5;
					end_IL_0000_2:
					break;
				}
				num = 16;
				((Form)this).set_TopMost(false);
				break;
				end_IL_0000:;
			}
			catch (object obj) when (obj is Exception && num3 != 0 && num2 == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0000_dispatch = 288;
				continue;
			}
			throw ProjectData.CreateProjectError(-2146828237);
			continue;
			end_IL_0000_3:
			break;
		}
		if (num2 != 0)
		{
			ProjectData.ClearProjectError();
		}
	}

	private void cl(object sender, EventArgs e)
	{
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		Application.DoEvents();
		if (Operators.CompareString(LicenseStatus.get_Text(), "Product status", false) != 0)
		{
			((Control)this).set_Visible(true);
			((Form)this).get_WindowState();
			if ((((Control)this).get_Top() == 0) & (((Control)this).get_Left() == 0))
			{
				((Form)this).CenterToScreen();
			}
			((Form)this).set_WindowState((FormWindowState)0);
			if ((((Control)this).get_Top() == 0) & (((Control)this).get_Left() == 0))
			{
				((Form)this).CenterToScreen();
			}
			if (Operators.ConditionalCompareObjectEqual(NotifyIcon1.get_Tag(), (object)"1", false))
			{
				SwitchPanels(LogPanelMain);
				a("");
			}
			else
			{
				SwitchPanels(StatusPanelMain);
			}
			((Form)this).set_TopMost(true);
			Application.DoEvents();
			((Form)this).set_TopMost(false);
		}
	}

	private void ck(object sender, EventArgs e)
	{
		ToolTip1.set_ToolTipTitle("Advanced - Exclusions");
	}

	private void cj(object sender, EventArgs e)
	{
		ToolTip1.set_ToolTipTitle("Advanced - Watch filter list");
	}

	private void ci(object sender, EventArgs e)
	{
		ToolTip1.set_ToolTipTitle("Advanced - Archives executable extensions list");
	}

	private void ch(object sender, EventArgs e)
	{
		ToolTip1.set_ToolTipTitle("Advanced - %APPDATA% folders executable extensions list");
	}

	private void cg(object sender, EventArgs e)
	{
		ToolTip1.set_ToolTipTitle("Advanced - Find shutter filter by filename");
	}

	private void cf(object sender, EventArgs e)
	{
		ToolTip1.set_ToolTipTitle("Actions - Show alert message");
	}

	private void ce(object sender, EventArgs e)
	{
		ToolTip1.set_ToolTipTitle("Actions - Create log file on public desktop");
	}

	private void cd(object sender, EventArgs e)
	{
		ToolTip1.set_ToolTipTitle("Actions - Sound alert");
	}

	private void cc(object sender, EventArgs e)
	{
	}

	private void cb(object sender, EventArgs e)
	{
		ToolTip1.set_ToolTipTitle("Actions - Send mail");
	}

	private void ca(object sender, EventArgs e)
	{
		ToolTip1.set_ToolTipTitle("Actions - Disable network connections");
	}

	private void b9(object sender, EventArgs e)
	{
		ToolTip1.set_ToolTipTitle("Actions - Log off and disable local users account");
	}

	private void b8(object sender, EventArgs e)
	{
		ToolTip1.set_ToolTipTitle("Actions - Delete OS entry in BCD and reboot");
	}

	private void b7(object sender, EventArgs e)
	{
		ToolTip1.set_ToolTipTitle("Actions - Shutdown computer");
	}

	private void b6(object sender, EventArgs e)
	{
		ToolTip1.set_ToolTipTitle("Mail setup - Validation and saving settings");
	}

	private void b5(object sender, EventArgs e)
	{
		ToolTip1.set_ToolTipTitle("Mail setup - Password");
	}

	private void b4(object sender, EventArgs e)
	{
		ToolTip1.set_ToolTipTitle("Mail setup - Authentication is required");
	}

	private void b3(object sender, EventArgs e)
	{
		ToolTip1.set_ToolTipTitle("Mail setup - Encryption");
	}

	private void b2(object sender, EventArgs e)
	{
		ToolTip1.set_ToolTipTitle("Mail setup - SMTP Server");
	}

	private void b1(object sender, EventArgs e)
	{
		ToolTip1.set_ToolTipTitle("Mail setup - E-mail");
	}

	private void b0(object sender, EventArgs e)
	{
		ToolTip1.set_ToolTipTitle("Mail setup - Recipient(s)");
	}

	private void bz(object sender, EventArgs e)
	{
		ToolTip1.set_ToolTipTitle("Mail setup - Username");
	}

	private void by(object sender, EventArgs e)
	{
		ToolTip1.set_ToolTipTitle("Mail setup - Port");
	}

	private void bx(object sender, EventArgs e)
	{
		ToolTip1.set_ToolTipTitle("Settings - Start when I login");
	}

	private void bw(object sender, EventArgs e)
	{
		ToolTip1.set_ToolTipTitle("Settings - Mute all sounds");
	}

	private void bv(object sender, EventArgs e)
	{
		ToolTip1.set_ToolTipTitle("Settings - Activate trap folders");
	}

	private void bu(object sender, EventArgs e)
	{
		ToolTip1.set_ToolTipTitle("Settings - Enable check based on fast multiple file renames");
	}

	private void bt(object sender, EventArgs e)
	{
		ToolTip1.set_ToolTipTitle("Settings - Block execution from archives");
	}

	private void bs(object sender, EventArgs e)
	{
		ToolTip1.set_ToolTipTitle("Settings - Block execution from %APPDATA% folders");
	}

	private void br(object sender, EventArgs e)
	{
		try
		{
			Process.Start("http://www.cyberland.ro/index.html#buy");
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	private void bq(object sender, EventArgs e)
	{
		//IL_01ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_020a: Unknown result type (might be due to invalid IL or missing references)
		int num = default(int);
		try
		{
			this.m_s.Deactivate();
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex, num);
			ProjectData.ClearProjectError();
		}
		if (Operators.CompareString(MaskedTextBox1.get_Text().Replace(" ", "").Replace("-", "")
			.Trim(), "", false) == 0)
		{
			try
			{
				this.m_s.Activate();
				try
				{
					this.m_s.Refresh();
				}
				catch (Exception ex2)
				{
					ProjectData.SetProjectError(ex2, num);
					ProjectData.ClearProjectError();
				}
				((Control)Panel20).set_Visible(false);
			}
			catch (Exception ex3)
			{
				ProjectData.SetProjectError(ex3, num);
				Exception ex4 = ex3;
				ShowMessageBox(ex4.Message, "Cyber Prot", (MessageBoxButtons)0, (MessageBoxIcon)16);
				if (this.m_s.get_InvalidReason() == null && this.m_s.get_IsActivated())
				{
					ProjectData.ClearProjectError();
				}
				else
				{
					ProjectData.ClearProjectError();
				}
			}
		}
		else
		{
			try
			{
				string directoryName = Path.GetDirectoryName(Assembly.GetExecutingAssembly().CodeBase);
				directoryName = new Uri(directoryName).LocalPath;
				this.m_s.Activate(MaskedTextBox1.get_Text());
				try
				{
					this.m_s.Refresh();
				}
				catch (Exception ex5)
				{
					ProjectData.SetProjectError(ex5, num);
					ProjectData.ClearProjectError();
				}
				string[] files = Directory.GetFiles(directoryName + "\\", "*.lic");
				foreach (string path in files)
				{
					try
					{
						File.Delete(path);
					}
					catch (Exception ex6)
					{
						ProjectData.SetProjectError(ex6, num);
						ProjectData.ClearProjectError();
					}
				}
				((Control)Panel20).set_Visible(false);
				((TextBoxBase)MaskedTextBox1).Clear();
			}
			catch (Exception ex7)
			{
				ProjectData.SetProjectError(ex7, num);
				Exception ex8 = ex7;
				ShowMessageBox(ex8.Message, "Cyber Prot", (MessageBoxButtons)0, (MessageBoxIcon)16);
				ProjectData.ClearProjectError();
			}
		}
		num = 10;
		licentiere(Verb: true);
		try
		{
			if (this.m_s.get_InvalidReason() == null && this.m_s.get_IsActivated())
			{
				CreateLog("License activated", "The Cyber Prot's license for this computer has been successfully activated", (EventLogEntryType)2, Repair: true, 7);
				try
				{
					new ServiceController("CyberProtService").Start();
					return;
				}
				catch (Exception ex9)
				{
					ProjectData.SetProjectError(ex9, num);
					try
					{
						try
						{
							new ServiceController("CyberProtService").Stop();
							Thread.Sleep(100);
						}
						catch (Exception ex10)
						{
							ProjectData.SetProjectError(ex10, num);
							CMDcuRSP("taskkill /IM \"Cyber Prot Service.exe\" /F");
							CreateLog("Engine stopped", "Engine has been stopped", (EventLogEntryType)2, Repair: true, 0);
							ProjectData.ClearProjectError();
						}
						try
						{
							CMDcuRSP("sc delete CyberProtService");
						}
						catch (Exception ex11)
						{
							ProjectData.SetProjectError(ex11, num);
							ProjectData.ClearProjectError();
						}
						try
						{
							Process process = new Process();
							process.StartInfo = new ProcessStartInfo
							{
								FileName = "cyber prot service.exe",
								RedirectStandardInput = true,
								RedirectStandardOutput = true,
								WindowStyle = ProcessWindowStyle.Hidden,
								CreateNoWindow = true,
								UseShellExecute = false,
								Arguments = "+911"
							};
							process.Start();
							process.WaitForExit(5000);
							process.Dispose();
						}
						catch (Exception ex12)
						{
							ProjectData.SetProjectError(ex12, num);
							ProjectData.ClearProjectError();
						}
					}
					catch (Exception ex13)
					{
						ProjectData.SetProjectError(ex13, num);
						ProjectData.ClearProjectError();
					}
					ProjectData.ClearProjectError();
					return;
				}
			}
			if (this.m_s.get_InvalidReason() != null)
			{
				CreateLog("License error", "Unable to activate license: " + this.m_s.get_InvalidReason(), (EventLogEntryType)2, Repair: true, 7);
			}
			else
			{
				CreateLog("License error", "Unable to activate license!", (EventLogEntryType)2, Repair: true, 7);
			}
			try
			{
				cr(null, null);
				this.m_s.Deactivate();
				licentiere();
			}
			catch (Exception ex14)
			{
				ProjectData.SetProjectError(ex14, num);
				ProjectData.ClearProjectError();
			}
		}
		catch (Exception ex15)
		{
			ProjectData.SetProjectError(ex15, num);
			ProjectData.ClearProjectError();
		}
	}

	public void CreateLog(string Titlu, string Mesaj, EventLogEntryType tip, bool Repair, int ID)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Invalid comparison between Unknown and I4
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		if (Repair)
		{
			try
			{
				ServiceController val = new ServiceController("EventLog");
				if ((int)val.get_Status() == 1)
				{
					CMDcuRSP("sc config \"EventLog\" start= auto");
					val.Start();
				}
				val = null;
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
			}
		}
		try
		{
			if (!EventLog.SourceExists(Titlu, "."))
			{
				EventLog.CreateEventSource(Titlu, "Cyber Prot", ".");
			}
			new EventLog("Cyber Prot", ".", Titlu).WriteEntry(Mesaj, tip, ID);
		}
		catch (Exception projectError2)
		{
			ProjectData.SetProjectError(projectError2);
			ProjectData.ClearProjectError();
		}
	}

	private void bp(object sender, EventArgs e)
	{
		//IL_00c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0138: Unknown result type (might be due to invalid IL or missing references)
		//IL_013e: Invalid comparison between Unknown and I4
		//IL_01a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c5: Unknown result type (might be due to invalid IL or missing references)
		if ((DoUpdate | ENG) || Conversions.ToBoolean(Operators.AndObject(Operators.CompareObjectNotEqual(((Control)PictureBox66).get_Tag(), (object)"Start", false), Operators.CompareObjectNotEqual(((Control)PictureBox66).get_Tag(), (object)"Stop", false))) || Operators.CompareString(Label56.get_Text(), "Working", false) == 0)
		{
			return;
		}
		UpdateIMG(PictureBox66, ImageList1.get_Images().get_Item(2));
		Label56.set_Text("Working");
		Application.DoEvents();
		ENG = true;
		object tag = ((Control)PictureBox66).get_Tag();
		int num = default(int);
		if (Operators.ConditionalCompareObjectEqual(tag, (object)"Stop", false))
		{
			try
			{
				new ServiceController("CyberProtService").Stop();
				Thread.Sleep(100);
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex, num);
				CMDcuRSP("taskkill /IM \"Cyber Prot Service.exe\" /F");
				CreateLog("Engine stopped", "Engine has been stopped", (EventLogEntryType)2, Repair: true, 0);
				ProjectData.ClearProjectError();
			}
			Application.DoEvents();
			StatusCheck();
		}
		else if (Operators.ConditionalCompareObjectEqual(tag, (object)"Start", false))
		{
			try
			{
				if (!File.Exists("Cyber Prot Service.exe"))
				{
					if ((int)MessageBox.Show("Service is missing or corrupted! You need to reinstall Cyber Prot!\r\nDo you want to download it now?", "Cyber Prot", (MessageBoxButtons)4, (MessageBoxIcon)48) != 6)
					{
						goto IL_02b3;
					}
					try
					{
						Thread thread = new Thread(StartUpdate);
						thread.Start();
						while (thread.IsAlive)
						{
							Thread.Sleep(50);
							Application.DoEvents();
						}
					}
					catch (Exception ex2)
					{
						ProjectData.SetProjectError(ex2, num);
						Process.Start("http://www.cyberland.ro/index.html#download");
						ProjectData.ClearProjectError();
					}
				}
			}
			catch (Exception ex3)
			{
				ProjectData.SetProjectError(ex3, num);
				ProjectData.ClearProjectError();
			}
			try
			{
				new ServiceController("CyberProtService").Start();
				Application.DoEvents();
			}
			catch (Exception ex4)
			{
				ProjectData.SetProjectError(ex4, num);
				try
				{
					try
					{
						new ServiceController("CyberProtService").Stop();
						Thread.Sleep(100);
					}
					catch (Exception ex5)
					{
						ProjectData.SetProjectError(ex5, num);
						CMDcuRSP("taskkill /IM \"Cyber Prot Service.exe\" /F");
						CreateLog("Engine stopped", "Engine has been stopped", (EventLogEntryType)2, Repair: true, 0);
						ProjectData.ClearProjectError();
					}
					try
					{
						CMDcuRSP("sc delete CyberProtService");
					}
					catch (Exception ex6)
					{
						ProjectData.SetProjectError(ex6, num);
						ProjectData.ClearProjectError();
					}
					try
					{
						Process process = new Process();
						process.StartInfo = new ProcessStartInfo
						{
							FileName = "cyber prot service.exe",
							RedirectStandardInput = true,
							RedirectStandardOutput = true,
							WindowStyle = ProcessWindowStyle.Hidden,
							CreateNoWindow = true,
							UseShellExecute = false,
							Arguments = "+911"
						};
						process.Start();
						process.WaitForExit(5000);
						process.Dispose();
					}
					catch (Exception ex7)
					{
						ProjectData.SetProjectError(ex7, num);
						ProjectData.ClearProjectError();
					}
				}
				catch (Exception ex8)
				{
					ProjectData.SetProjectError(ex8, num);
					ProjectData.ClearProjectError();
				}
				Application.DoEvents();
				ProjectData.ClearProjectError();
			}
			licentiere();
		}
		goto IL_02b3;
		IL_02b3:
		num = 20;
		ENG = false;
	}

	private void e(object sender, MouseEventArgs e)
	{
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			if (OpenEmail("feedback@cyberland.ro", "Cyber Prot support request"))
			{
				return;
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
		try
		{
			Process.Start("http://www.cyberland.ro/#contact");
		}
		catch (Exception projectError2)
		{
			ProjectData.SetProjectError(projectError2);
			try
			{
				Process.Start("iexplore.exe", "http://www.cyberland.ro/#contact");
			}
			catch (Exception projectError3)
			{
				ProjectData.SetProjectError(projectError3);
				MessageBox.Show("Can't open your default mail program!\r\nPlease manually send a mail to feedback@cyberland.ro", "Cyber Prot", (MessageBoxButtons)0, (MessageBoxIcon)16);
				ProjectData.ClearProjectError();
			}
			ProjectData.ClearProjectError();
		}
	}

	private void bo(object sender, EventArgs e)
	{
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Expected O, but got Unknown
		Font font = new Font(((Control)Label1).get_Font().get_Name(), ((Control)Label1).get_Font().get_Size(), (FontStyle)4);
		((Control)Label52).set_Font(font);
	}

	private void bn(object sender, EventArgs e)
	{
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Expected O, but got Unknown
		Font font = new Font(((Control)Label1).get_Font().get_Name(), ((Control)Label1).get_Font().get_Size(), (FontStyle)0);
		((Control)Label52).set_Font(font);
	}

	private void bm(object sender, EventArgs e)
	{
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			if (OpenEmail("feedback@cyberland.ro", "Cyber Prot support request"))
			{
				return;
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
		try
		{
			Process.Start("http://www.cyberland.ro/#contact");
		}
		catch (Exception projectError2)
		{
			ProjectData.SetProjectError(projectError2);
			try
			{
				Process.Start("iexplore.exe", "http://www.cyberland.ro/#contact");
			}
			catch (Exception projectError3)
			{
				ProjectData.SetProjectError(projectError3);
				MessageBox.Show("Can't open your default mail program!\r\nPlease manually send a mail to feedback@cyberland.ro", "Cyber Prot", (MessageBoxButtons)0, (MessageBoxIcon)16);
				ProjectData.ClearProjectError();
			}
			ProjectData.ClearProjectError();
		}
	}

	private void bl(object sender, EventArgs e)
	{
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			if (OpenEmail("feedback@cyberland.ro", "Cyber Prot support request"))
			{
				return;
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
		try
		{
			Process.Start("http://www.cyberland.ro/#contact");
		}
		catch (Exception projectError2)
		{
			ProjectData.SetProjectError(projectError2);
			try
			{
				Process.Start("iexplore.exe", "http://www.cyberland.ro/#contact");
			}
			catch (Exception projectError3)
			{
				ProjectData.SetProjectError(projectError3);
				MessageBox.Show("Can't open your default mail program!\r\nPlease manually send a mail to feedback@cyberland.ro", "Cyber Prot", (MessageBoxButtons)0, (MessageBoxIcon)16);
				ProjectData.ClearProjectError();
			}
			ProjectData.ClearProjectError();
		}
	}

	private void bk(object sender, EventArgs e)
	{
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Expected O, but got Unknown
		Font font = new Font(((Control)Label1).get_Font().get_Name(), ((Control)Label1).get_Font().get_Size(), (FontStyle)4);
		((Control)Label52).set_Font(font);
	}

	private void bj(object sender, EventArgs e)
	{
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Expected O, but got Unknown
		Font font = new Font(((Control)Label1).get_Font().get_Name(), ((Control)Label1).get_Font().get_Size(), (FontStyle)0);
		((Control)Label52).set_Font(font);
	}

	private void bi(object sender, EventArgs e)
	{
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Expected O, but got Unknown
		Font font = new Font(((Control)Label1).get_Font().get_Name(), ((Control)Label1).get_Font().get_Size(), (FontStyle)4);
		((Control)Label52).set_Font(font);
	}

	private void bh(object sender, EventArgs e)
	{
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Expected O, but got Unknown
		Font font = new Font(((Control)Label1).get_Font().get_Name(), ((Control)Label1).get_Font().get_Size(), (FontStyle)0);
		((Control)Label52).set_Font(font);
	}

	private void bg(object sender, EventArgs e)
	{
		try
		{
			Process.Start("http://www.cyberland.ro/index.html#buy");
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	private void d(object sender, MouseEventArgs e)
	{
		try
		{
			Process.Start("http://www.cyberland.ro/index.html#buy");
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	private void bf(object sender, EventArgs e)
	{
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Expected O, but got Unknown
		Font font = new Font(((Control)Label1).get_Font().get_Name(), ((Control)Label1).get_Font().get_Size(), (FontStyle)4);
		((Control)Label51).set_Font(font);
	}

	private void be(object sender, EventArgs e)
	{
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Expected O, but got Unknown
		Font font = new Font(((Control)Label1).get_Font().get_Name(), ((Control)Label1).get_Font().get_Size(), (FontStyle)0);
		((Control)Label51).set_Font(font);
	}

	private void bd(object sender, EventArgs e)
	{
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Expected O, but got Unknown
		Font font = new Font(((Control)Label1).get_Font().get_Name(), ((Control)Label1).get_Font().get_Size(), (FontStyle)4);
		((Control)Label51).set_Font(font);
	}

	private void bc(object sender, EventArgs e)
	{
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Expected O, but got Unknown
		Font font = new Font(((Control)Label1).get_Font().get_Name(), ((Control)Label1).get_Font().get_Size(), (FontStyle)0);
		((Control)Label51).set_Font(font);
	}

	private void bb(object sender, EventArgs e)
	{
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Expected O, but got Unknown
		Font font = new Font(((Control)Label1).get_Font().get_Name(), ((Control)Label1).get_Font().get_Size(), (FontStyle)4);
		((Control)Label51).set_Font(font);
	}

	private void ba(object sender, EventArgs e)
	{
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Expected O, but got Unknown
		Font font = new Font(((Control)Label1).get_Font().get_Name(), ((Control)Label1).get_Font().get_Size(), (FontStyle)0);
		((Control)Label51).set_Font(font);
	}

	private void c(object sender, MouseEventArgs e)
	{
		UpdaterClick();
	}

	private void a9(object sender, EventArgs e)
	{
		UpdaterClick();
	}

	private void a8(object sender, EventArgs e)
	{
		UpdaterClick();
	}

	private void a7(object sender, EventArgs e)
	{
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Expected O, but got Unknown
		Font font = new Font(((Control)Label1).get_Font().get_Name(), ((Control)Label1).get_Font().get_Size(), (FontStyle)4);
		((Control)Label44).set_Font(font);
	}

	private void a6(object sender, EventArgs e)
	{
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Expected O, but got Unknown
		Font font = new Font(((Control)Label1).get_Font().get_Name(), ((Control)Label1).get_Font().get_Size(), (FontStyle)4);
		((Control)Label44).set_Font(font);
	}

	private void a5(object sender, EventArgs e)
	{
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Expected O, but got Unknown
		Font font = new Font(((Control)Label1).get_Font().get_Name(), ((Control)Label1).get_Font().get_Size(), (FontStyle)4);
		((Control)Label44).set_Font(font);
	}

	private void a4(object sender, EventArgs e)
	{
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Expected O, but got Unknown
		Font font = new Font(((Control)Label1).get_Font().get_Name(), ((Control)Label1).get_Font().get_Size(), (FontStyle)0);
		((Control)Label44).set_Font(font);
	}

	private void a3(object sender, EventArgs e)
	{
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Expected O, but got Unknown
		Font font = new Font(((Control)Label1).get_Font().get_Name(), ((Control)Label1).get_Font().get_Size(), (FontStyle)0);
		((Control)Label44).set_Font(font);
	}

	private void a2(object sender, EventArgs e)
	{
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Expected O, but got Unknown
		Font font = new Font(((Control)Label1).get_Font().get_Name(), ((Control)Label1).get_Font().get_Size(), (FontStyle)0);
		((Control)Label44).set_Font(font);
	}

	public void ReadDatabase()
	{
		try
		{
			string address = "http://www.cyberland.ro/Database.cp";
			WebClient webClient = new WebClient();
			StreamReader streamReader = new StreamReader(webClient.OpenRead(address));
			ReadedDatabase = streamReader.ReadToEnd();
			streamReader.Close();
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ReadedDatabase = "Error";
			ProjectData.ClearProjectError();
		}
	}

	public void UpdateE(Control txtBox, bool value)
	{
		try
		{
			if (txtBox.get_InvokeRequired())
			{
				txtBox.Invoke((Delegate)(global::a)delegate
				{
					UpdateE(txtBox, value);
				});
			}
			else
			{
				txtBox.set_Enabled(value);
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	[MethodImpl(MethodImplOptions.NoOptimization)]
	public void StartUpdate()
	{
		DoUpdate = true;
		UpdateE((Control)(object)Panel25, value: false);
		try
		{
			try
			{
				File.Delete(Application.get_StartupPath() + "\\Setup.exe");
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
			}
			new WebClient().DownloadFile("http://www.cyberland.ro/Setup.exe", Application.get_StartupPath() + "\\Setup.exe");
			CreateLog("Updating Cyber Prot", "Cyber Prot is being updated", (EventLogEntryType)4, Repair: true, 4);
			Process.Start(Application.get_StartupPath() + "\\Setup.exe");
			Application.Exit();
			ProjectData.EndApp();
		}
		catch (Exception projectError2)
		{
			ProjectData.SetProjectError(projectError2);
			((Control)this).Invoke((Delegate)(global::a)delegate
			{
				//IL_000d: Unknown result type (might be due to invalid IL or missing references)
				MessageBox.Show("Unable to update. Please check your internet connection", "Cyber Prot", (MessageBoxButtons)0, (MessageBoxIcon)16);
			});
			ProjectData.ClearProjectError();
		}
		UpdateE((Control)(object)Panel25, value: true);
		DoUpdate = false;
	}

	public void UpdaterClick()
	{
		//IL_010d: Unknown result type (might be due to invalid IL or missing references)
		//IL_013f: Unknown result type (might be due to invalid IL or missing references)
		//IL_015c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0161: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_0250: Unknown result type (might be due to invalid IL or missing references)
		//IL_0274: Unknown result type (might be due to invalid IL or missing references)
		((Control)Panel25).set_Enabled(false);
		if (Operators.CompareString(Label44.get_Text(), "Update now", false) == 0)
		{
			try
			{
				Thread thread = new Thread(StartUpdate);
				thread.Start();
				while (thread.IsAlive)
				{
					Thread.Sleep(50);
					Application.DoEvents();
				}
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				Process.Start("http://www.cyberland.ro/index.html#download");
				ProjectData.ClearProjectError();
			}
		}
		else
		{
			string text = Conversions.ToString(Update(Er: false));
			try
			{
				string cipherText = "";
				string text2 = "";
				try
				{
					StreamReader streamReader = new StreamReader("Database.cp", detectEncodingFromByteOrderMarks: true);
					cipherText = streamReader.ReadToEnd();
					streamReader.Close();
				}
				catch (Exception projectError2)
				{
					ProjectData.SetProjectError(projectError2);
					ProjectData.ClearProjectError();
				}
				try
				{
					ReadedDatabase = "Error";
					Thread thread2 = new Thread(ReadDatabase);
					thread2.Start();
					while (thread2.IsAlive)
					{
						Thread.Sleep(50);
						Application.DoEvents();
					}
					if (Operators.CompareString(ReadedDatabase, "Error", false) == 0)
					{
						MessageBox.Show("Can't check for updates!\r\nPlease make sure you are connected to internet and try again.", "Cyber Prot", (MessageBoxButtons)0, (MessageBoxIcon)16);
						((Control)Panel25).set_Enabled(true);
						return;
					}
					text2 = ReadedDatabase;
				}
				catch (Exception projectError3)
				{
					ProjectData.SetProjectError(projectError3);
					MessageBox.Show("Can't check for updates!\r\nPlease make sure you are connected to internet and try again.", "Cyber Prot", (MessageBoxButtons)0, (MessageBoxIcon)16);
					((Control)Panel25).set_Enabled(true);
					ProjectData.ClearProjectError();
					return;
				}
				DB dB;
				try
				{
					JavaScriptSerializer val = new JavaScriptSerializer();
					val.set_MaxJsonLength(2147483644);
					dB = val.Deserialize<DB>(Decrypt(cipherText));
				}
				catch (Exception projectError4)
				{
					ProjectData.SetProjectError(projectError4);
					string path = "Database.cp";
					StreamWriter streamWriter = new StreamWriter(path, append: false);
					streamWriter.WriteLine(text2);
					streamWriter.Close();
					CallService();
					databaseVersion();
					((Control)Panel25).set_Enabled(true);
					MessageBox.Show("Ransomware definitions local database was restored", "Cyber Prot", (MessageBoxButtons)0, (MessageBoxIcon)64);
					CreateLog("Definitions database", "Ransomware definitions local database was restored", (EventLogEntryType)4, Repair: true, 4);
					ProjectData.ClearProjectError();
					return;
				}
				JavaScriptSerializer val2 = new JavaScriptSerializer();
				val2.set_MaxJsonLength(2147483644);
				DB dB2 = (this.m_q = val2.Deserialize<DB>(Decrypt(text2)));
				if (Operators.CompareString(dB.version, dB2.version, false) != 0)
				{
					string path2 = "Database.cp";
					StreamWriter streamWriter2 = new StreamWriter(path2, append: false);
					streamWriter2.WriteLine(text2);
					streamWriter2.Close();
					CallService();
					MessageBox.Show("Ransomware definitions updated", "Cyber Prot", (MessageBoxButtons)0, (MessageBoxIcon)64);
					CreateLog("Definitions database", "Ransomware definitions updated", (EventLogEntryType)4, Repair: true, 4);
				}
				else
				{
					MessageBox.Show(text, "Cyber Prot", (MessageBoxButtons)0, (MessageBoxIcon)64);
				}
				databaseVersion();
			}
			catch (Exception projectError5)
			{
				ProjectData.SetProjectError(projectError5);
				ProjectData.ClearProjectError();
			}
		}
		((Control)Panel25).set_Enabled(true);
		FixTextCiudat();
	}

	private void d(object sender, CancelEventArgs e)
	{
	}

	private void a1(object sender, EventArgs e)
	{
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Expected O, but got Unknown
		Font font = new Font(((Control)Label37).get_Font().get_Name(), ((Control)Label37).get_Font().get_Size(), (FontStyle)4);
		((Control)Label37).set_Font(font);
	}

	private void a0(object sender, EventArgs e)
	{
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Expected O, but got Unknown
		Font font = new Font(((Control)Label37).get_Font().get_Name(), ((Control)Label37).get_Font().get_Size(), (FontStyle)0);
		((Control)Label37).set_Font(font);
	}

	private void az(object sender, EventArgs e)
	{
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Expected O, but got Unknown
		Font font = new Font(((Control)Label1).get_Font().get_Name(), ((Control)Label1).get_Font().get_Size(), (FontStyle)4);
		((Control)Label42).set_Font(font);
	}

	private void ay(object sender, EventArgs e)
	{
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Expected O, but got Unknown
		Font font = new Font(((Control)Label1).get_Font().get_Name(), ((Control)Label1).get_Font().get_Size(), (FontStyle)0);
		((Control)Label42).set_Font(font);
	}

	private void ax(object sender, EventArgs e)
	{
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Expected O, but got Unknown
		if (((Control)Panel20).get_Visible())
		{
			((Control)Label36).set_Cursor(Cursors.get_Arrow());
			return;
		}
		((Control)Label36).set_Cursor(Cursors.get_Hand());
		Font font = new Font(((Control)Label1).get_Font().get_Name(), ((Control)Label1).get_Font().get_Size(), (FontStyle)4);
		((Control)Label36).set_Font(font);
	}

	private void aw(object sender, EventArgs e)
	{
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Expected O, but got Unknown
		Font font = new Font(((Control)Label1).get_Font().get_Name(), ((Control)Label1).get_Font().get_Size(), (FontStyle)0);
		((Control)Label36).set_Font(font);
	}

	private void av(object sender, EventArgs e)
	{
		if (Label36.get_Text().StartsWith("Re"))
		{
			((Control)Label36).set_Width(160);
			((Control)Label36).set_Visible(false);
		}
		else
		{
			((Control)Label36).set_Visible(true);
			((Control)Label36).set_Width(145);
		}
	}

	private void au(object sender, EventArgs e)
	{
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Expected O, but got Unknown
		//IL_008e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0094: Invalid comparison between Unknown and I4
		//IL_0120: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_0228: Unknown result type (might be due to invalid IL or missing references)
		//IL_023e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0244: Invalid comparison between Unknown and I4
		//IL_0272: Unknown result type (might be due to invalid IL or missing references)
		//IL_02fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0330: Unknown result type (might be due to invalid IL or missing references)
		//IL_0336: Invalid comparison between Unknown and I4
		//IL_04bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_04c1: Invalid comparison between Unknown and I4
		//IL_0500: Unknown result type (might be due to invalid IL or missing references)
		//IL_0506: Invalid comparison between Unknown and I4
		//IL_063f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0668: Unknown result type (might be due to invalid IL or missing references)
		//IL_0693: Unknown result type (might be due to invalid IL or missing references)
		int num = default(int);
		if (Operators.ConditionalCompareObjectEqual(((Control)PictureBox4).get_Tag(), (object)"1", false))
		{
			OpenFileDialog val = new OpenFileDialog();
			((FileDialog)val).set_InitialDirectory(Environment.GetFolderPath(Environment.SpecialFolder.Desktop));
			string text = "Applications |";
			foreach (string item in MakeAppsList())
			{
				text = text + "*." + item + ";";
			}
			((FileDialog)val).set_Filter(text);
			((FileDialog)val).set_Title("Select an application");
			((FileDialog)val).set_RestoreDirectory(true);
			if ((int)((CommonDialog)val).ShowDialog() != 1)
			{
				return;
			}
			checked
			{
				try
				{
					string fileName = ((FileDialog)val).get_FileName();
					try
					{
						IEnumerator<DriveInfo> enumerator2 = ((ServerComputer)global::d.e()).get_FileSystem().get_Drives().GetEnumerator();
						while (enumerator2.MoveNext())
						{
							DriveInfo current2 = enumerator2.Current;
							try
							{
								if (current2.DriveType == DriveType.Fixed && fileName.ToLower().StartsWith(current2.Name.ToLower()))
								{
									goto IL_012b;
								}
							}
							catch (Exception ex)
							{
								ProjectData.SetProjectError(ex, num);
								ProjectData.ClearProjectError();
							}
						}
					}
					catch (Exception ex2)
					{
						ProjectData.SetProjectError(ex2, num);
						ProjectData.ClearProjectError();
					}
					MessageBox.Show("Only applications from fixed drives can be selected!", "Cyber Prot", (MessageBoxButtons)0, (MessageBoxIcon)16);
					return;
					IL_012b:
					num = 11;
					int num2 = ListBox1.get_Items().get_Count() - 1;
					int num3 = 0;
					while (true)
					{
						if (num3 <= num2)
						{
							if (Operators.CompareString(fileName.ToUpper().Trim(), ListBox1.get_Items().get_Item(num3).ToString()!.ToUpper().Trim(), false) == 0)
							{
								break;
							}
							num3++;
							continue;
						}
						ListBox1.get_Items().Add((object)fileName);
						ListBox1.set_Text(fileName);
						BList();
						c();
						CreateLog("App added to white list", "Application " + fileName + " has been added to white list", (EventLogEntryType)2, Repair: true, 1);
						return;
					}
					ListBox1.set_Text(fileName);
					MessageBox.Show(fileName + " is already excluded!", "Cyber Prot", (MessageBoxButtons)0, (MessageBoxIcon)16);
					return;
				}
				catch (Exception ex3)
				{
					ProjectData.SetProjectError(ex3, num);
					Exception ex4 = ex3;
					MessageBox.Show("Error adding application: \r\n\r\n" + ex4.Message, "Cyber Prot", (MessageBoxButtons)0, (MessageBoxIcon)16);
					ProjectData.ClearProjectError();
					return;
				}
			}
		}
		if ((int)((CommonDialog)FolderBrowserDialog1).ShowDialog() != 1)
		{
			return;
		}
		try
		{
			string selectedPath = FolderBrowserDialog1.get_SelectedPath();
			if (LikeOperator.LikeString(selectedPath, "?:\\___CyberProt_Trap_Folder*", (CompareMethod)0))
			{
				MessageBox.Show("Can't select own trap folders!", "Cyber Prot", (MessageBoxButtons)0, (MessageBoxIcon)16);
				return;
			}
			try
			{
				IEnumerator<DriveInfo> enumerator3 = ((ServerComputer)global::d.e()).get_FileSystem().get_Drives().GetEnumerator();
				while (enumerator3.MoveNext())
				{
					DriveInfo current3 = enumerator3.Current;
					try
					{
						if (current3.DriveType == DriveType.Fixed && selectedPath.ToLower().StartsWith(current3.Name.ToLower()))
						{
							goto IL_0308;
						}
					}
					catch (Exception ex5)
					{
						ProjectData.SetProjectError(ex5, num);
						ProjectData.ClearProjectError();
					}
				}
			}
			catch (Exception ex6)
			{
				ProjectData.SetProjectError(ex6, num);
				ProjectData.ClearProjectError();
			}
			MessageBox.Show("Only fixed drives can be selected!", "Cyber Prot", (MessageBoxButtons)0, (MessageBoxIcon)16);
			return;
			IL_0308:
			num = 10;
			if (selectedPath.Length == 3 && (int)MessageBox.Show((IWin32Window)(object)this, "Are you sure you want to white list the entire drive " + selectedPath + "?", "Cyber Prot", (MessageBoxButtons)4, (MessageBoxIcon)48) == 7)
			{
				return;
			}
			string text2 = "";
			int num4 = 0;
			checked
			{
				int num5 = ListBox1.get_Items().get_Count() - 1;
				int num6 = 0;
				while (true)
				{
					if (num6 <= num5)
					{
						if (Operators.CompareString(selectedPath.ToUpper().Trim(), ListBox1.get_Items().get_Item(num6).ToString()!.ToUpper().Trim(), false) == 0)
						{
							break;
						}
						num6++;
						continue;
					}
					int num7 = ListBox1.get_Items().get_Count() - 1;
					int num8 = 0;
					while (true)
					{
						if (num8 <= num7)
						{
							if (selectedPath.ToUpper().Trim().StartsWith(ListBox1.get_Items().get_Item(num8).ToString()!.ToUpper().Trim()))
							{
								break;
							}
							if (ListBox1.get_Items().get_Item(num8).ToString()!.ToUpper().Trim().StartsWith(selectedPath.ToUpper().Trim()))
							{
								if (num4 > 0)
								{
									text2 += "\r\n";
								}
								text2 += ListBox1.get_Items().get_Item(num8).ToString();
								num4++;
							}
							num8++;
							continue;
						}
						if (num4 > 0)
						{
							List<string> list = new List<string>(text2.Split(new char[1] { '\r' }));
							unchecked
							{
								if (num4 == 1)
								{
									if ((int)MessageBox.Show((IWin32Window)(object)this, list[0] + " is a subfolder of " + selectedPath + " and needs to be removed from the list first!\r\nDo you want to remove it?", "Cyber Prot", (MessageBoxButtons)4, (MessageBoxIcon)48) == 7)
									{
										return;
									}
								}
								else if ((int)MessageBox.Show((IWin32Window)(object)this, Conversions.ToString(num4) + " subfolders of " + selectedPath + " needs to be removed from the list first!\r\nDo you want to remove the following entrys?\r\n" + text2, "Cyber Prot", (MessageBoxButtons)4, (MessageBoxIcon)48) == 7)
								{
									return;
								}
							}
							foreach (string item2 in list)
							{
								if (Operators.CompareString(item2.Trim(), "", false) == 0)
								{
									continue;
								}
								int num9 = ListBox1.get_Items().get_Count() - 1;
								for (int i = 0; i <= num9; i++)
								{
									if (Operators.CompareString(ListBox1.get_Items().get_Item(i).ToString()!.ToUpper().Trim(), item2.ToUpper().Trim(), false) == 0)
									{
										ListBox1.get_Items().RemoveAt(i);
										break;
									}
								}
							}
						}
						ListBox1.get_Items().Add((object)selectedPath);
						ListBox1.set_Text(selectedPath);
						BList();
						c();
						CreateLog("Path added to white list", "Folder " + selectedPath + " has been added to white list", (EventLogEntryType)2, Repair: true, 1);
						return;
					}
					ListBox1.set_SelectedIndex(num8);
					MessageBox.Show(selectedPath + " is already excluded as subfolder of " + ListBox1.get_Text(), "Cyber Prot", (MessageBoxButtons)0, (MessageBoxIcon)16);
					return;
				}
				ListBox1.set_Text(selectedPath);
				MessageBox.Show(selectedPath + " is already excluded!", "Cyber Prot", (MessageBoxButtons)0, (MessageBoxIcon)16);
			}
		}
		catch (Exception ex7)
		{
			ProjectData.SetProjectError(ex7, num);
			Exception ex8 = ex7;
			MessageBox.Show("Error adding folder: \r\n\r\n" + ex8.Message, "Cyber Prot", (MessageBoxButtons)0, (MessageBoxIcon)16);
			ProjectData.ClearProjectError();
		}
	}

	private void at(object sender, EventArgs e)
	{
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Invalid comparison between Unknown and I4
		if ((int)MessageBox.Show((IWin32Window)(object)this, "Do you want to remove " + ListBox1.get_Text() + "?", "Cyber Prot", (MessageBoxButtons)4, (MessageBoxIcon)48) != 7)
		{
			if (Operators.ConditionalCompareObjectEqual(((Control)PictureBox4).get_Tag(), (object)"1", false))
			{
				CreateLog("App deleted from white list", "Application " + ListBox1.get_Text() + " has been removed from white list", (EventLogEntryType)2, Repair: true, 1);
			}
			else
			{
				CreateLog("Path deleted from white list", "Folder " + ListBox1.get_Text() + " has been removed from white list", (EventLogEntryType)2, Repair: true, 1);
			}
			ListBox1.get_Items().RemoveAt(ListBox1.get_SelectedIndex());
			BList();
			c();
		}
	}

	private void c(object sender, CancelEventArgs e)
	{
		if (ListBox1.get_SelectedItems().get_Count() > 0)
		{
			if (Operators.CompareString(((ToolStrip)ContextMenuStrip3).get_Items().get_Item(0).get_Text(), "Add new application", false) == 0)
			{
				((ToolStrip)ContextMenuStrip3).get_Items().get_Item(1).set_Text("Remove " + ListBox1.get_Text().Substring(checked(ListBox1.get_Text().LastIndexOf("\\") + 1)) + " from white list");
				((ToolStrip)ContextMenuStrip3).get_Items().get_Item(3).set_Text("Clear all applications from white list");
			}
			else
			{
				((ToolStrip)ContextMenuStrip3).get_Items().get_Item(1).set_Text("Remove " + ListBox1.get_Text() + " from white list");
				((ToolStrip)ContextMenuStrip3).get_Items().get_Item(3).set_Text("Clear all paths from white list");
			}
		}
		int count = ListBox1.get_Items().get_Count();
		if (count == 1)
		{
			if (!ListBox1.get_Text().Contains("\\"))
			{
				((ToolStripItem)RemoveFolderToolStripMenuItem).set_Visible(false);
			}
			else
			{
				((ToolStripItem)RemoveFolderToolStripMenuItem).set_Visible(true);
			}
			((ToolStripItem)ClearToolStripMenuItem).set_Visible(false);
			((ToolStripItem)ToolStripSeparator2).set_Visible(false);
		}
		else
		{
			((ToolStripItem)RemoveFolderToolStripMenuItem).set_Visible(true);
			((ToolStripItem)ClearToolStripMenuItem).set_Visible(true);
			((ToolStripItem)ToolStripSeparator2).set_Visible(true);
		}
	}

	private void c(object sender, KeyEventArgs e)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Invalid comparison between Unknown and I4
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Invalid comparison between Unknown and I4
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Invalid comparison between Unknown and I4
		if ((((int)e.get_KeyCode() == 46) | ((int)e.get_KeyCode() == 8)) && ListBox1.get_SelectedItems().get_Count() >= 1 && (int)MessageBox.Show((IWin32Window)(object)this, "Do you want to remove " + ListBox1.get_Text() + "?", "Cyber Prot", (MessageBoxButtons)4, (MessageBoxIcon)48) != 7)
		{
			ListBox1.get_Items().RemoveAt(ListBox1.get_SelectedIndex());
			BList();
			c();
		}
	}

	private void @as(object sender, EventArgs e)
	{
		((Control)this).Focus();
	}

	private void ar(object sender, EventArgs e)
	{
		((Control)this).Focus();
	}

	private void aq(object sender, EventArgs e)
	{
		((Control)this).Focus();
	}

	private void ap(object sender, EventArgs e)
	{
		((Control)this).Focus();
	}

	private void ao(object sender, EventArgs e)
	{
		((Control)this).Focus();
	}

	private void an(object sender, EventArgs e)
	{
		((Control)this).Focus();
	}

	private void am(object sender, EventArgs e)
	{
		((Control)this).Focus();
	}

	private void al(object sender, EventArgs e)
	{
		if (!((Operators.CompareString(Label56.get_Text(), "Running", false) != 0) & (Operators.CompareString(Label56.get_Text(), "Stopped", false) != 0)) && Operators.CompareString(Label56.get_Text(), SCStatus, false) != 0)
		{
			SCStatus = Label56.get_Text();
			licentiere();
		}
	}

	private void ak(object sender, EventArgs e)
	{
		FixTextCiudat();
	}

	private void aj(object sender, EventArgs e)
	{
	}

	public void FixTextCiudat()
	{
		if (Conversions.ToBoolean(Operators.AndObject((object)(Operators.CompareString(Label55.get_Text(), "You are at risk", false) == 0), Operators.CompareObjectEqual(((Control)Label35).get_Tag(), (object)"Cyber Prot is up to date", false))))
		{
			if (LikeOperator.LikeString(TrialStatus.get_Text(), "*You are not protected!", (CompareMethod)0))
			{
				Label35.set_Text("Please check your license");
			}
			else
			{
				Label35.set_Text("Your data is not protected!");
			}
		}
		else
		{
			Label35.set_Text(Conversions.ToString(((Control)Label35).get_Tag()));
		}
	}

	private void ai(object sender, EventArgs e)
	{
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Expected O, but got Unknown
		Font font = new Font(((Control)Label1).get_Font().get_Name(), ((Control)Label1).get_Font().get_Size(), (FontStyle)4);
		((Control)Label1).set_Font(font);
	}

	private void ah(object sender, EventArgs e)
	{
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Expected O, but got Unknown
		Font font = new Font(((Control)Label1).get_Font().get_Name(), ((Control)Label1).get_Font().get_Size(), (FontStyle)0);
		((Control)Label1).set_Font(font);
	}

	private void ag(object sender, EventArgs e)
	{
		SwitchPanels(LogPanelMain);
		a("");
	}

	private void af(object sender, EventArgs e)
	{
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Expected O, but got Unknown
		Font font = new Font(((Control)Label64).get_Font().get_Name(), ((Control)Label64).get_Font().get_Size(), (FontStyle)4);
		((Control)Label64).set_Font(font);
	}

	private void ae(object sender, EventArgs e)
	{
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Expected O, but got Unknown
		Font font = new Font(((Control)Label64).get_Font().get_Name(), ((Control)Label64).get_Font().get_Size(), (FontStyle)0);
		((Control)Label64).set_Font(font);
	}

	private void ad(object sender, EventArgs e)
	{
		SwitchPanels(LogPanelMain);
		a("");
	}

	private void ac(object sender, EventArgs e)
	{
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Expected O, but got Unknown
		Font font = new Font(((Control)Label64).get_Font().get_Name(), ((Control)Label64).get_Font().get_Size(), (FontStyle)4);
		((Control)Label64).set_Font(font);
	}

	private void ab(object sender, EventArgs e)
	{
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Expected O, but got Unknown
		Font font = new Font(((Control)Label64).get_Font().get_Name(), ((Control)Label64).get_Font().get_Size(), (FontStyle)0);
		((Control)Label64).set_Font(font);
	}

	private void a(string A_0 = "")
	{
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Expected O, but got Unknown
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0051: Invalid comparison between Unknown and I4
		//IL_00cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d2: Expected O, but got Unknown
		//IL_00e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ef: Expected O, but got Unknown
		//IL_00f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f5: Unknown result type (might be due to invalid IL or missing references)
		if (LogRefs)
		{
			return;
		}
		LogRefs = true;
		if (Operators.CompareString(A_0, "", false) != 0)
		{
			TextBox1.set_Text(A_0);
		}
		else
		{
			TextBox1.set_Text("");
		}
		try
		{
			ServiceController val = new ServiceController("EventLog");
			if ((int)val.get_Status() == 1)
			{
				CMDcuRSP("sc config \"EventLog\" start= auto");
				val.Start();
				val = null;
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
		try
		{
			if (Operators.CompareString(A_0, "", false) == 0)
			{
				TextBox8.set_Text("Loading...");
			}
			else
			{
				TextBox8.set_Text("Searching...");
			}
			DataGridView1.get_Rows().Clear();
			Application.DoEvents();
			((Control)DataGridView1).SuspendLayout();
			EventLog val2 = new EventLog("Cyber Prot");
			IEnumerator enumerator = default(IEnumerator);
			try
			{
				enumerator = val2.get_Entries().GetEnumerator();
				while (enumerator.MoveNext())
				{
					EventLogEntry val3 = (EventLogEntry)enumerator.Current;
					try
					{
						EventLogEntryType entryType = val3.get_EntryType();
						string text = ((Enum)(EventLogEntryType)(ref entryType)).ToString();
						try
						{
							if (val3.get_EventID() == 0)
							{
								text = "Engine status";
							}
							if (val3.get_EventID() == 1)
							{
								text = "Setting changed";
							}
							if (val3.get_EventID() == 2)
							{
								text = "Critical error";
							}
							if (val3.get_EventID() == 3)
							{
								text = "Threat detected";
							}
							if (val3.get_EventID() == 4)
							{
								text = "Application";
							}
							if (val3.get_EventID() == 5)
							{
								text = "File wiped";
							}
							if (val3.get_EventID() == 6)
							{
								text = "File restored";
							}
							if (val3.get_EventID() == 7)
							{
								text = "License changed";
							}
							if (val3.get_EventID() == 8)
							{
								text = "Proactivity applied";
							}
						}
						catch (Exception projectError2)
						{
							ProjectData.SetProjectError(projectError2);
							ProjectData.ClearProjectError();
						}
						if (Operators.CompareString(A_0, "", false) == 0 || LikeOperator.LikeString(val3.get_Source().ToLower(), "*" + TextBox1.get_Text().Trim().ToLower() + "*", (CompareMethod)0) || LikeOperator.LikeString(val3.get_Message().ToLower(), "*" + TextBox1.get_Text().Trim().ToLower() + "*", (CompareMethod)0))
						{
							string[] array = new string[5]
							{
								null,
								text,
								Strings.Format((object)val3.get_TimeGenerated(), "yyyy-MM-dd HH:mm:ss"),
								val3.get_Source(),
								val3.get_Message()
							};
							DataGridView1.get_Rows().Add((object[])array);
							Image value = ImageList5.get_Images().get_Item(val3.get_EventID());
							try
							{
								DataGridView1.get_Item(0, checked(DataGridView1.get_Rows().get_Count() - 1)).set_Value((object)value);
							}
							catch (Exception projectError3)
							{
								ProjectData.SetProjectError(projectError3);
								ProjectData.ClearProjectError();
							}
						}
					}
					catch (Exception projectError4)
					{
						ProjectData.SetProjectError(projectError4);
						ProjectData.ClearProjectError();
					}
				}
			}
			finally
			{
				if (enumerator is IDisposable)
				{
					(enumerator as IDisposable).Dispose();
				}
			}
			try
			{
				DataGridView1.Sort(DataGridView1.get_Columns().get_Item(2), ListSortDirection.Descending);
			}
			catch (Exception projectError5)
			{
				ProjectData.SetProjectError(projectError5);
				ProjectData.ClearProjectError();
			}
		}
		catch (Exception projectError6)
		{
			ProjectData.SetProjectError(projectError6);
			ProjectData.ClearProjectError();
		}
		TextBox8.set_Text("");
		try
		{
			((Control)DataGridView1).ResumeLayout();
		}
		catch (Exception projectError7)
		{
			ProjectData.SetProjectError(projectError7);
			ProjectData.ClearProjectError();
		}
		try
		{
			DataGridView1.get_Rows().get_Item(0).set_Selected(true);
			TextBox8.set_Text(Conversions.ToString(DataGridView1.get_Item(4, 0).get_Value()));
		}
		catch (Exception projectError8)
		{
			ProjectData.SetProjectError(projectError8);
			ProjectData.ClearProjectError();
		}
		LogRefs = false;
	}

	private void a(object sender, DataGridViewCellEventArgs e)
	{
	}

	private void aa(object sender, EventArgs e)
	{
		if (!LogRefs)
		{
			TextBox8.set_Text(Conversions.ToString(DataGridView1.get_Item(4, DataGridView1.get_CurrentCell().get_RowIndex()).get_Value()));
		}
	}

	private void b(object sender, KeyEventArgs e)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Invalid comparison between Unknown and I4
		if ((int)e.get_KeyCode() == 116)
		{
			a("");
		}
	}

	private void z(object sender, EventArgs e)
	{
		a("");
	}

	private void a(object sender, KeyEventArgs e)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Invalid comparison between Unknown and I4
		if ((int)e.get_KeyCode() == 116)
		{
			a("");
		}
	}

	private void y(object sender, EventArgs e)
	{
		SwitchPanels(ActionsPanelMain);
	}

	private void x(object sender, EventArgs e)
	{
		SwitchPanels(ActionsPanelMain);
	}

	private void w(object sender, EventArgs e)
	{
		SwitchPanels(ActionsPanelMain);
	}

	private void v(object sender, EventArgs e)
	{
		SwitchPanels(AdvancedPanelMain);
		((Control)Panel23).set_Visible(false);
		ExPaths();
	}

	private void u(object sender, EventArgs e)
	{
		SwitchPanels(AdvancedPanelMain);
		((Control)Panel23).set_Visible(false);
		ExPaths();
	}

	private void t(object sender, EventArgs e)
	{
		if (!((Control)Panel23).get_Visible())
		{
			((Control)Panel35).set_Top(15);
			((Control)Panel4).set_Top(94);
			((Control)PictureBox78).set_Tag((object)"0");
			((Control)PictureBox4).set_Tag((object)"0");
			PictureBox78.set_Image(ImageList4.get_Images().get_Item(0));
			PictureBox4.set_Image(ImageList4.get_Images().get_Item(0));
		}
	}

	private void s(object sender, EventArgs e)
	{
		ExPaths();
	}

	private void r(object sender, EventArgs e)
	{
		ExPaths();
	}

	public void ExPaths()
	{
		PictureBox78.set_Image(ImageList4.get_Images().get_Item(1));
		PictureBox4.set_Image(ImageList4.get_Images().get_Item(0));
		ListBox1.get_Items().Clear();
		checked
		{
			try
			{
				string text = Decrypt(Conversions.ToString(Registry.LocalMachine.CreateSubKey("SOFTWARE\\Cyber Prot", RegistryKeyPermissionCheck.ReadWriteSubTree).GetValue("ExclusionPaths", "")));
				List<string> list = new List<string>(text.Split(new char[1] { ';' }));
				if (list.Count > 0)
				{
					int num = list.Count - 1;
					for (int i = 0; i <= num; i++)
					{
						if (Operators.CompareString(list[i].Trim(), "", false) != 0)
						{
							ListBox1.get_Items().Add((object)list[i]);
						}
					}
				}
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
			}
			((ToolStrip)ContextMenuStrip3).get_Items().get_Item(0).set_Text("Add new path");
			((ToolStrip)ContextMenuStrip3).get_Items().get_Item(1).set_Text("Remove path");
			((ToolStrip)ContextMenuStrip3).get_Items().get_Item(2).set_Text("Clear all");
			this.m_w = "Right click to add a path";
			((Control)PictureBox4).set_Tag((object)"0");
			if (Operators.ConditionalCompareObjectEqual(((Control)PictureBox78).get_Tag(), (object)"0", false))
			{
				((Control)PictureBox78).set_Tag((object)"1");
				((Control)Panel35).set_Top(15);
				((Control)Panel23).set_Visible(true);
				((Control)Panel23).set_Top(((Control)Panel35).get_Top() + ((Control)Panel35).get_Height());
				((Control)Panel4).set_Top(((Control)Panel23).get_Top() + ((Control)Panel23).get_Height() + 7);
				BList();
			}
			else
			{
				((Control)Panel23).set_Visible(false);
			}
		}
	}

	private void q(object sender, EventArgs e)
	{
		ExApps();
	}

	private void p(object sender, EventArgs e)
	{
		ExApps();
	}

	public void ExApps()
	{
		PictureBox78.set_Image(ImageList4.get_Images().get_Item(0));
		PictureBox4.set_Image(ImageList4.get_Images().get_Item(1));
		ListBox1.get_Items().Clear();
		checked
		{
			try
			{
				string text = Decrypt(Conversions.ToString(Registry.LocalMachine.CreateSubKey("SOFTWARE\\Cyber Prot", RegistryKeyPermissionCheck.ReadWriteSubTree).GetValue("ExclusionApps", "")));
				List<string> list = new List<string>(text.Split(new char[1] { ';' }));
				if (list.Count > 0)
				{
					int num = list.Count - 1;
					for (int i = 0; i <= num; i++)
					{
						if (Operators.CompareString(list[i].Trim(), "", false) != 0)
						{
							ListBox1.get_Items().Add((object)list[i]);
						}
					}
				}
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
			}
			((ToolStrip)ContextMenuStrip3).get_Items().get_Item(0).set_Text("Add new application");
			((ToolStrip)ContextMenuStrip3).get_Items().get_Item(1).set_Text("Remove application");
			((ToolStrip)ContextMenuStrip3).get_Items().get_Item(2).set_Text("Clear all");
			this.m_w = "Right click to add an application";
			((Control)PictureBox78).set_Tag((object)"0");
			if (Operators.ConditionalCompareObjectEqual(((Control)PictureBox4).get_Tag(), (object)"0", false))
			{
				((Control)PictureBox4).set_Tag((object)"1");
				((Control)Panel35).set_Top(15);
				((Control)Panel4).set_Top(94);
				((Control)Panel23).set_Visible(true);
				((Control)Panel23).set_Top(((Control)Panel4).get_Top() + ((Control)Panel4).get_Height());
				BList();
			}
			else
			{
				((Control)Panel23).set_Visible(false);
			}
		}
	}

	public void BList()
	{
		if (ListBox1.get_Items().get_Count() == 0)
		{
			ListBox1.get_Items().Add((object)this.m_w);
			ListBox1.set_ForeColor(Color.FromKnownColor(KnownColor.Control));
			RemoveFolderToolStripMenuItem.set_Enabled(false);
			ListBox1.set_SelectionMode((SelectionMode)0);
			return;
		}
		if (ListBox1.get_Items().get_Count() == 1)
		{
			if (Operators.ConditionalCompareObjectEqual(ListBox1.get_Items().get_Item(0), (object)this.m_w, false))
			{
				ListBox1.set_ForeColor(Color.FromKnownColor(KnownColor.Control));
				RemoveFolderToolStripMenuItem.set_Enabled(false);
				ListBox1.set_SelectionMode((SelectionMode)0);
			}
			else
			{
				ListBox1.set_ForeColor(Color.Black);
				RemoveFolderToolStripMenuItem.set_Enabled(true);
				ListBox1.set_SelectionMode((SelectionMode)1);
			}
			return;
		}
		checked
		{
			int num = ListBox1.get_Items().get_Count() - 1;
			for (int i = 0; i <= num; i++)
			{
				if (Operators.ConditionalCompareObjectEqual(ListBox1.get_Items().get_Item(i), (object)this.m_w, false))
				{
					ListBox1.get_Items().RemoveAt(i);
				}
			}
			RemoveFolderToolStripMenuItem.set_Enabled(true);
			ListBox1.set_SelectionMode((SelectionMode)1);
			ListBox1.set_ForeColor(Color.Black);
		}
	}

	private void c()
	{
		//IL_00dc: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			string text = "";
			IEnumerator enumerator = default(IEnumerator);
			try
			{
				enumerator = ListBox1.get_Items().GetEnumerator();
				while (enumerator.MoveNext())
				{
					string text2 = Conversions.ToString(enumerator.Current);
					if (Operators.CompareString(text2, this.m_w, false) != 0)
					{
						text = text + text2 + ";";
					}
				}
			}
			finally
			{
				if (enumerator is IDisposable)
				{
					(enumerator as IDisposable).Dispose();
				}
			}
			if (Operators.ConditionalCompareObjectEqual(((Control)PictureBox78).get_Tag(), (object)"1", false))
			{
				Registry.LocalMachine.CreateSubKey("SOFTWARE\\Cyber Prot", RegistryKeyPermissionCheck.ReadWriteSubTree).SetValue("ExclusionPaths", Encrypt(text));
			}
			else
			{
				Registry.LocalMachine.CreateSubKey("SOFTWARE\\Cyber Prot", RegistryKeyPermissionCheck.ReadWriteSubTree).SetValue("ExclusionApps", Encrypt(text));
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			MessageBox.Show("Error saving list: \r\n\r\n" + ex2.Message, "Cyber Prot", (MessageBoxButtons)0, (MessageBoxIcon)16);
			ProjectData.ClearProjectError();
			return;
		}
		CountExepts();
		CallService(1);
	}

	public void CountExepts()
	{
		List<string> list = new List<string>();
		List<string> list2 = new List<string>();
		checked
		{
			int num = default(int);
			try
			{
				string text = Decrypt(Conversions.ToString(Registry.LocalMachine.CreateSubKey("SOFTWARE\\Cyber Prot", RegistryKeyPermissionCheck.ReadWriteSubTree).GetValue("ExclusionApps", "")));
				list = new List<string>(text.Split(new char[1] { ';' }));
				while (true)
				{
					IL_008f:
					num = 11;
					if (list.Count <= 0)
					{
						break;
					}
					int num2 = list.Count - 1;
					int num3 = 0;
					while (num3 <= num2)
					{
						if (Operators.CompareString(list[num3].Trim(), "", false) != 0)
						{
							num3++;
							continue;
						}
						list.RemoveAt(num3);
						goto IL_008f;
					}
					break;
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex, num);
				list = new List<string>();
				ProjectData.ClearProjectError();
			}
			try
			{
				string text2 = Decrypt(Conversions.ToString(Registry.LocalMachine.CreateSubKey("SOFTWARE\\Cyber Prot", RegistryKeyPermissionCheck.ReadWriteSubTree).GetValue("ExclusionPaths", "")));
				list2 = new List<string>(text2.Split(new char[1] { ';' }));
				while (true)
				{
					IL_0136:
					num = 110;
					if (list2.Count <= 0)
					{
						break;
					}
					int num4 = list2.Count - 1;
					int num5 = 0;
					while (num5 <= num4)
					{
						if (Operators.CompareString(list2[num5].Trim(), "", false) != 0)
						{
							num5++;
							continue;
						}
						list2.RemoveAt(num5);
						goto IL_0136;
					}
					break;
				}
			}
			catch (Exception ex2)
			{
				ProjectData.SetProjectError(ex2, num);
				list2 = new List<string>();
				ProjectData.ClearProjectError();
			}
			Label43.set_Text("White listed paths");
			if (list2.Count > 0)
			{
				Label43.set_Text(Label43.get_Text() + " (" + Conversions.ToString(list2.Count) + ")");
			}
			Label3.set_Text("White listed applications");
			if (list.Count > 0)
			{
				Label3.set_Text(Label3.get_Text() + " (" + Conversions.ToString(list.Count) + ")");
			}
			Label26.set_Text(Conversions.ToString(list2.Count));
			Label23.set_Text(Conversions.ToString(list.Count));
		}
	}

	public void RefreshQuarantine()
	{
		//IL_0209: Unknown result type (might be due to invalid IL or missing references)
		((Control)DataGridView2).SuspendLayout();
		DataGridView2.get_Rows().Clear();
		checked
		{
			int num2 = default(int);
			try
			{
				string subkey = "SOFTWARE\\Cyber Prot\\Vault";
				using RegistryKey registryKey = Registry.LocalMachine.CreateSubKey(subkey);
				string[] valueNames = registryKey.GetValueNames();
				foreach (string text in valueNames)
				{
					try
					{
						string text2 = Decrypt(Conversions.ToString(Registry.LocalMachine.CreateSubKey(subkey).GetValue(text)));
						if (Operators.CompareString(text2.Trim(), "", false) != 0)
						{
							string value;
							long ticks;
							string text3;
							string tag;
							if (text2.StartsWith("LOCK|"))
							{
								value = "Security locked";
								ticks = Conversions.ToLong(text2.Substring(5));
								text3 = Decrypt(text);
								tag = text;
							}
							else if (text2.StartsWith("SRP|"))
							{
								value = "Execution blocked";
								tag = text;
								List<string> list = new List<string>(text2.Split(new char[1] { '|' }));
								ticks = Conversions.ToLong(list[1]);
								text3 = list[2];
							}
							else
							{
								value = "Quarantined";
								tag = text;
								List<string> list2 = new List<string>(text2.Split(new char[1] { '|' }));
								ticks = Conversions.ToLong(list2[1]);
								text3 = list2[0];
							}
							try
							{
								int num = DataGridView2.get_Rows().get_Count() - 1;
								for (int j = 0; j <= num; j++)
								{
									try
									{
										if (Operators.CompareString(DataGridView2.get_Item(1, j).get_Value().ToString()!.Trim().ToLower(), text3.Trim().ToLower(), false) != 0)
										{
											goto end_IL_0153;
										}
										if (Operators.CompareString(DataGridView2.get_Item(2, j).get_Value().ToString()!.Trim(), "Quarantined", false) != 0)
										{
											DataGridView2.get_Rows().RemoveAt(j);
											break;
										}
										goto end_IL_0044;
										end_IL_0153:;
									}
									catch (Exception ex)
									{
										ProjectData.SetProjectError(ex, num2);
										ProjectData.ClearProjectError();
									}
								}
							}
							catch (Exception ex2)
							{
								ProjectData.SetProjectError(ex2, num2);
								ProjectData.ClearProjectError();
							}
							int num3 = DataGridView2.get_Rows().Add();
							new DataGridViewRow();
							DataGridViewRow obj = DataGridView2.get_Rows().get_Item(num3);
							obj.get_Cells().get_Item(0).set_Value((object)new DateTime(ticks));
							obj.get_Cells().get_Item(1).set_Value((object)text3);
							obj.get_Cells().get_Item(2).set_Value((object)value);
							((DataGridViewBand)DataGridView2.get_Rows().get_Item(num3)).set_Tag((object)tag);
						}
						else
						{
							try
							{
								Registry.LocalMachine.CreateSubKey(subkey).DeleteValue(text);
							}
							catch (Exception ex3)
							{
								ProjectData.SetProjectError(ex3, num2);
								ProjectData.ClearProjectError();
							}
						}
						end_IL_0044:;
					}
					catch (Exception ex4)
					{
						ProjectData.SetProjectError(ex4, num2);
						ProjectData.ClearProjectError();
					}
					num2 = 10;
				}
			}
			catch (Exception ex5)
			{
				ProjectData.SetProjectError(ex5, num2);
				ProjectData.ClearProjectError();
			}
			Label12.set_Text(Conversions.ToString(DataGridView2.get_Rows().get_Count()));
			if (Conversion.Val((object)(Conversions.ToDouble(Label12.get_Text()) > 0.0)) != 0.0)
			{
				try
				{
					DataGridView2.Sort(DataGridView2.get_Columns().get_Item(0), ListSortDirection.Descending);
				}
				catch (Exception ex6)
				{
					ProjectData.SetProjectError(ex6, num2);
					ProjectData.ClearProjectError();
				}
				((Control)DataGridView2).set_Visible(true);
				((Control)DataGridView2).ResumeLayout();
				((Control)Label15).set_Visible(false);
			}
			else
			{
				((Control)DataGridView2).set_Visible(false);
				((Control)Label15).set_Visible(true);
			}
		}
	}

	private void b(object sender, CancelEventArgs e)
	{
		try
		{
			if (((DataGridViewBand)DataGridView2.get_CurrentRow()).get_Index() < 0)
			{
				e.Cancel = true;
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			e.Cancel = true;
			ProjectData.ClearProjectError();
		}
		if (DataGridView2.get_Rows().get_Count() > 1)
		{
			((ToolStripItem)WipeAllFilesToolStripMenuItem).set_Visible(true);
		}
		else
		{
			((ToolStripItem)WipeAllFilesToolStripMenuItem).set_Visible(false);
		}
		string text = Conversions.ToString(DataGridView2.get_Item(1, ((DataGridViewBand)DataGridView2.get_CurrentRow()).get_Index()).get_Value());
		((Control)ContextMenuStrip4).set_Tag((object)((DataGridViewBand)DataGridView2.get_CurrentRow()).get_Index());
		checked
		{
			((ToolStripItem)ToolStripMenuItem2).set_Text("Restore " + text.Substring(text.LastIndexOf("\\") + 1));
			((ToolStripItem)ToolStripMenuItem3).set_Text("Restore " + text.Substring(text.LastIndexOf("\\") + 1) + " and add to white list");
			((ToolStripItem)ToolStripMenuItem4).set_Text("Wipe " + text.Substring(text.LastIndexOf("\\") + 1));
		}
	}

	private void b(object sender, DataGridViewCellMouseEventArgs e)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Invalid comparison between Unknown and I4
		if ((int)((MouseEventArgs)e).get_Button() == 2097152)
		{
			DataGridView2.set_CurrentCell(DataGridView2.get_Item(e.get_ColumnIndex(), e.get_RowIndex()));
			DataGridView2.get_CurrentCell().set_Selected(false);
			Application.DoEvents();
			DataGridView2.get_CurrentCell().set_Selected(true);
		}
	}

	public void RestoreQ(int RowIndex, bool AddToExceptions = false)
	{
		string text = Conversions.ToString(DataGridView2.get_Item(1, RowIndex).get_Value());
		UnLock(text);
		UnLock(Conversions.ToString(((DataGridViewBand)DataGridView2.get_Rows().get_Item(RowIndex)).get_Tag()));
		try
		{
			bool flag = false;
			try
			{
				while (DeleteSRP(Conversions.ToString(((DataGridViewBand)DataGridView2.get_Rows().get_Item(RowIndex)).get_Tag())))
				{
					flag = true;
				}
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
			}
			try
			{
				while (DeleteSRP(text))
				{
					flag = true;
				}
			}
			catch (Exception projectError2)
			{
				ProjectData.SetProjectError(projectError2);
				ProjectData.ClearProjectError();
			}
			if (flag)
			{
				KillExplorer();
			}
		}
		catch (Exception projectError3)
		{
			ProjectData.SetProjectError(projectError3);
			ProjectData.ClearProjectError();
		}
		try
		{
			File.Copy(Conversions.ToString(Operators.ConcatenateObject((object)(Application.get_StartupPath() + "\\Vault\\"), ((DataGridViewBand)DataGridView2.get_Rows().get_Item(RowIndex)).get_Tag())), text, overwrite: true);
		}
		catch (Exception projectError4)
		{
			ProjectData.SetProjectError(projectError4);
			ProjectData.ClearProjectError();
		}
		try
		{
			if (Operators.ConditionalCompareObjectNotEqual(Registry.LocalMachine.CreateSubKey(Conversions.ToString(Operators.ConcatenateObject((object)"SOFTWARE\\Policies\\Microsoft\\Windows\\safer\\codeidentifiers\\0\\Paths\\", ((DataGridViewBand)DataGridView2.get_Rows().get_Item(RowIndex)).get_Tag())), RegistryKeyPermissionCheck.ReadWriteSubTree).GetValue("ItemData", ""), (object)"", false))
			{
				Registry.LocalMachine.DeleteSubKey(Conversions.ToString(Operators.ConcatenateObject((object)"SOFTWARE\\Policies\\Microsoft\\Windows\\safer\\codeidentifiers\\0\\Paths\\", ((DataGridViewBand)DataGridView2.get_Rows().get_Item(RowIndex)).get_Tag())), throwOnMissingSubKey: true);
				KillExplorer();
			}
		}
		catch (Exception projectError5)
		{
			ProjectData.SetProjectError(projectError5);
			ProjectData.ClearProjectError();
		}
		try
		{
			Registry.LocalMachine.OpenSubKey("SOFTWARE\\Cyber Prot\\Vault", writable: true)!.DeleteValue(Conversions.ToString(((DataGridViewBand)DataGridView2.get_Rows().get_Item(RowIndex)).get_Tag()));
		}
		catch (Exception projectError6)
		{
			ProjectData.SetProjectError(projectError6);
			ProjectData.ClearProjectError();
		}
		try
		{
			RegistryKey registryKey = Registry.LocalMachine.OpenSubKey("SOFTWARE\\Cyber Prot\\Vault", writable: true);
			string[] valueNames = registryKey.GetValueNames();
			foreach (string name in valueNames)
			{
				string text2 = Conversions.ToString(registryKey.GetValue(name));
				if (text2.ToLower().EndsWith("|" + text.ToLower()) || Decrypt(text2).ToLower().EndsWith("|" + text.ToLower()))
				{
					Registry.LocalMachine.OpenSubKey("SOFTWARE\\Cyber Prot\\Vault", writable: true)!.DeleteValue(name, throwOnMissingValue: false);
				}
			}
		}
		catch (Exception projectError7)
		{
			ProjectData.SetProjectError(projectError7);
			ProjectData.ClearProjectError();
		}
		try
		{
			File.Delete(Conversions.ToString(Operators.ConcatenateObject((object)(Application.get_StartupPath() + "\\Vault\\"), ((DataGridViewBand)DataGridView2.get_Rows().get_Item(RowIndex)).get_Tag())));
		}
		catch (Exception projectError8)
		{
			ProjectData.SetProjectError(projectError8);
			ProjectData.ClearProjectError();
		}
		CreateLog("File restored", "File " + text + " has been restored.", (EventLogEntryType)2, Repair: true, 6);
		if (AddToExceptions)
		{
			AddExcept(text);
		}
		RefreshQuarantine();
	}

	public bool DeleteSRP(string Path)
	{
		string text = CheckifExistsSRP(Path);
		if (Operators.CompareString(text, "", false) != 0)
		{
			try
			{
				Registry.LocalMachine.DeleteSubKeyTree("SOFTWARE\\Policies\\Microsoft\\Windows\\safer\\codeidentifiers\\0\\Paths\\" + text, throwOnMissingSubKey: true);
				return true;
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
			}
			return false;
		}
		return false;
	}

	public string CheckifExistsSRP(string Path)
	{
		string result = "";
		try
		{
			object objectValue = RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(Interaction.CreateObject("WbemScripting.SWbemLocator", "")))), (Type)null, "ConnectServer", new object[2] { ".", "Root\\DEFAULT" }, (string[])null, (Type[])null, (bool[])null)))), (Type)null, "Get", new object[1] { "StdRegProv" }, (string[])null, (Type[])null, (bool[])null)));
			int num = -2147483646;
			string text = "SOFTWARE\\Policies\\Microsoft\\Windows\\safer\\codeidentifiers\\0\\Paths";
			object obj = null;
			object objectValue2 = RuntimeHelpers.GetObjectValue(objectValue);
			Type type = null;
			string text2 = "EnumKey";
			object[] array = new object[3]
			{
				-2147483646,
				text,
				RuntimeHelpers.GetObjectValue(obj)
			};
			object[] array2 = array;
			string[] array3 = null;
			Type[] array4 = null;
			bool[] array5 = new bool[3] { true, true, true };
			NewLateBinding.LateCall(RuntimeHelpers.GetObjectValue(objectValue2), type, text2, array2, array3, array4, array5, true);
			if (array5[0])
			{
				num = Conversions.ToInteger(Conversions.ChangeType(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(array[0])), typeof(int)));
			}
			if (array5[1])
			{
				text = Conversions.ToString(Conversions.ChangeType(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(array[1])), typeof(string)));
			}
			if (array5[2])
			{
				obj = RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(array[2]));
			}
			try
			{
				IEnumerator enumerator = ((IEnumerable)obj).GetEnumerator();
				while (enumerator.MoveNext())
				{
					string text3 = Conversions.ToString(RuntimeHelpers.GetObjectValue(enumerator.Current));
					try
					{
						string text4 = "";
						object objectValue3 = RuntimeHelpers.GetObjectValue(objectValue);
						Type type2 = null;
						string text5 = "getstringvalue";
						object[] array6 = new object[4]
						{
							num,
							text + "\\" + text3,
							"ItemData",
							text4
						};
						object[] array7 = array6;
						string[] array8 = null;
						Type[] array9 = null;
						array5 = new bool[4] { true, false, false, true };
						NewLateBinding.LateCall(RuntimeHelpers.GetObjectValue(objectValue3), type2, text5, array7, array8, array9, array5, true);
						if (array5[0])
						{
							num = Conversions.ToInteger(Conversions.ChangeType(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(array6[0])), typeof(int)));
						}
						if (array5[3])
						{
							text4 = Conversions.ToString(Conversions.ChangeType(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(array6[3])), typeof(string)));
						}
						if (Operators.CompareString(text4.Trim().ToLower(), Path.ToLower(), false) == 0)
						{
							result = text3;
							return result;
						}
					}
					catch (Exception projectError)
					{
						ProjectData.SetProjectError(projectError);
						ProjectData.ClearProjectError();
					}
				}
			}
			finally
			{
				IEnumerator enumerator2 = default(IEnumerator);
				if (enumerator2 is IDisposable)
				{
					(enumerator2 as IDisposable).Dispose();
				}
			}
			result = "";
		}
		catch (Exception projectError2)
		{
			ProjectData.SetProjectError(projectError2);
			ProjectData.ClearProjectError();
		}
		return result;
	}

	public bool UnLock(string Path)
	{
		try
		{
			FileInfo fileInfo = new FileInfo(Path);
			FileSecurity accessControl = fileInfo.GetAccessControl();
			try
			{
				accessControl.RemoveAccessRule(new FileSystemAccessRule(new SecurityIdentifier(WellKnownSidType.WorldSid, null), FileSystemRights.FullControl, InheritanceFlags.None, PropagationFlags.None, AccessControlType.Deny));
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
			}
			accessControl.AddAccessRule(new FileSystemAccessRule(new SecurityIdentifier(WellKnownSidType.WorldSid, null), FileSystemRights.FullControl, InheritanceFlags.None, PropagationFlags.None, AccessControlType.Allow));
			fileInfo.SetAccessControl(accessControl);
			Registry.LocalMachine.DeleteValue("SOFTWARE\\Cyber Prot\\Vault\\" + Encrypt(Path), throwOnMissingValue: true);
			return true;
		}
		catch (Exception projectError2)
		{
			ProjectData.SetProjectError(projectError2);
			bool result = false;
			ProjectData.ClearProjectError();
			return result;
		}
	}

	public void KillExplorer()
	{
		Process[] processes = Process.GetProcesses();
		checked
		{
			int num = processes.Length - 1;
			for (int i = 0; i <= num; i++)
			{
				Process process = processes[i];
				try
				{
					if (Operators.CompareString(process.MainModule!.ModuleName, "explorer.exe", false) == 0)
					{
						process.Kill();
					}
				}
				catch (Exception projectError)
				{
					ProjectData.SetProjectError(projectError);
					ProjectData.ClearProjectError();
				}
			}
			RestoreExplorer();
		}
	}

	public void RestoreExplorer()
	{
		checked
		{
			try
			{
				Thread.Sleep(3000);
				Process[] processes = Process.GetProcesses();
				int num = processes.Length - 1;
				for (int i = 0; i <= num; i++)
				{
					Process process = processes[i];
					try
					{
						if (Operators.CompareString(process.MainModule!.ModuleName, "explorer.exe", false) == 0)
						{
							return;
						}
					}
					catch (Exception projectError)
					{
						ProjectData.SetProjectError(projectError);
						ProjectData.ClearProjectError();
					}
				}
				Interaction.Shell("explorer", (AppWinStyle)2, false, -1);
			}
			catch (Exception projectError2)
			{
				ProjectData.SetProjectError(projectError2);
				ProjectData.ClearProjectError();
			}
		}
	}

	public void AddExcept(object filename)
	{
		string text = Decrypt(Conversions.ToString(Registry.LocalMachine.CreateSubKey("SOFTWARE\\Cyber Prot", RegistryKeyPermissionCheck.ReadWriteSubTree).GetValue("ExclusionApps", "")));
		if (!text.ToUpper().Contains(Conversions.ToString(NewLateBinding.LateGet(filename, (Type)null, "ToUpper", new object[0], (string[])null, (Type[])null, (bool[])null))))
		{
			if ((text.Trim().Length <= 0 || !text.EndsWith(";")) && text.Trim().Length > 0)
			{
				text += ";";
			}
			text = Conversions.ToString(Operators.ConcatenateObject((object)text, filename));
			Registry.LocalMachine.CreateSubKey("SOFTWARE\\Cyber Prot", RegistryKeyPermissionCheck.ReadWriteSubTree).SetValue("ExclusionApps", Encrypt(text));
			CallService(1);
			CountExepts();
		}
	}

	private void o(object sender, EventArgs e)
	{
		RestoreQ(Conversions.ToInteger(((Control)ContextMenuStrip4).get_Tag()));
	}

	private void n(object sender, EventArgs e)
	{
		RestoreQ(Conversions.ToInteger(((Control)ContextMenuStrip4).get_Tag()), AddToExceptions: true);
	}

	public void Kill(string Path)
	{
		try
		{
			string fileName = System.IO.Path.GetFileName(Path);
			Process[] processesByName = Process.GetProcessesByName(fileName.Substring(0, fileName.LastIndexOf('.')));
			if (processesByName.Length <= 0)
			{
				return;
			}
			Process[] array = processesByName;
			foreach (Process process in array)
			{
				try
				{
					process.Kill();
				}
				catch (Exception projectError)
				{
					ProjectData.SetProjectError(projectError);
					ProjectData.ClearProjectError();
				}
			}
		}
		catch (Exception projectError2)
		{
			ProjectData.SetProjectError(projectError2);
			ProjectData.ClearProjectError();
		}
	}

	private void m(object sender, EventArgs e)
	{
		try
		{
			int index = ((DataGridViewBand)DataGridView2.get_CurrentRow()).get_Index();
			string text = Conversions.ToString(DataGridView2.get_Item(1, index).get_Value());
			UnLock(text);
			UnLock(Conversions.ToString(((DataGridViewBand)DataGridView2.get_Rows().get_Item(index)).get_Tag()));
			try
			{
				bool flag = false;
				try
				{
					while (DeleteSRP(Conversions.ToString(((DataGridViewBand)DataGridView2.get_Rows().get_Item(index)).get_Tag())))
					{
						flag = true;
					}
				}
				catch (Exception projectError)
				{
					ProjectData.SetProjectError(projectError);
					ProjectData.ClearProjectError();
				}
				try
				{
					while (DeleteSRP(text))
					{
						flag = true;
					}
				}
				catch (Exception projectError2)
				{
					ProjectData.SetProjectError(projectError2);
					ProjectData.ClearProjectError();
				}
				if (flag)
				{
					KillExplorer();
				}
			}
			catch (Exception projectError3)
			{
				ProjectData.SetProjectError(projectError3);
				ProjectData.ClearProjectError();
			}
			try
			{
				File.Delete(text);
			}
			catch (Exception projectError4)
			{
				ProjectData.SetProjectError(projectError4);
				ProjectData.ClearProjectError();
			}
			try
			{
				if (Operators.ConditionalCompareObjectNotEqual(Registry.LocalMachine.CreateSubKey(Conversions.ToString(Operators.ConcatenateObject((object)"SOFTWARE\\Policies\\Microsoft\\Windows\\safer\\codeidentifiers\\0\\Paths\\", ((DataGridViewBand)DataGridView2.get_Rows().get_Item(index)).get_Tag())), RegistryKeyPermissionCheck.ReadWriteSubTree).GetValue("ItemData", ""), (object)"", false))
				{
					Registry.LocalMachine.DeleteSubKey(Conversions.ToString(Operators.ConcatenateObject((object)"SOFTWARE\\Policies\\Microsoft\\Windows\\safer\\codeidentifiers\\0\\Paths\\", ((DataGridViewBand)DataGridView2.get_Rows().get_Item(index)).get_Tag())), throwOnMissingSubKey: true);
					KillExplorer();
				}
			}
			catch (Exception projectError5)
			{
				ProjectData.SetProjectError(projectError5);
				ProjectData.ClearProjectError();
			}
			try
			{
				Registry.LocalMachine.OpenSubKey("SOFTWARE\\Cyber Prot\\Vault", writable: true)!.DeleteValue(Conversions.ToString(((DataGridViewBand)DataGridView2.get_Rows().get_Item(index)).get_Tag()));
			}
			catch (Exception projectError6)
			{
				ProjectData.SetProjectError(projectError6);
				ProjectData.ClearProjectError();
			}
			try
			{
				RegistryKey registryKey = Registry.LocalMachine.OpenSubKey("SOFTWARE\\Cyber Prot\\Vault", writable: true);
				string[] valueNames = registryKey.GetValueNames();
				foreach (string name in valueNames)
				{
					string text2 = Conversions.ToString(registryKey.GetValue(name));
					if (text2.ToLower().EndsWith("|" + text.ToLower()) || Decrypt(text2).ToLower().EndsWith("|" + text.ToLower()))
					{
						Registry.LocalMachine.OpenSubKey("SOFTWARE\\Cyber Prot\\Vault", writable: true)!.DeleteValue(name, throwOnMissingValue: false);
					}
				}
			}
			catch (Exception projectError7)
			{
				ProjectData.SetProjectError(projectError7);
				ProjectData.ClearProjectError();
			}
			try
			{
				File.Delete(Conversions.ToString(Operators.ConcatenateObject((object)(Application.get_StartupPath() + "\\Vault\\"), ((DataGridViewBand)DataGridView2.get_Rows().get_Item(index)).get_Tag())));
			}
			catch (Exception projectError8)
			{
				ProjectData.SetProjectError(projectError8);
				ProjectData.ClearProjectError();
			}
			CreateLog("File wiped", "File " + text + " has been permanently deleted.", (EventLogEntryType)2, Repair: true, 5);
		}
		catch (Exception projectError9)
		{
			ProjectData.SetProjectError(projectError9);
			ProjectData.ClearProjectError();
		}
		RefreshQuarantine();
	}

	private void a(object sender, CancelEventArgs e)
	{
		//IL_00e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e6: Expected O, but got Unknown
		//IL_01b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bb: Expected O, but got Unknown
		//IL_023e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0245: Expected O, but got Unknown
		//IL_027c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0283: Expected O, but got Unknown
		//IL_0371: Unknown result type (might be due to invalid IL or missing references)
		//IL_0378: Expected O, but got Unknown
		//IL_03ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b3: Expected O, but got Unknown
		//IL_03e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ee: Expected O, but got Unknown
		//IL_04bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_04c3: Expected O, but got Unknown
		//IL_0529: Unknown result type (might be due to invalid IL or missing references)
		//IL_0530: Expected O, but got Unknown
		//IL_06d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_06db: Expected O, but got Unknown
		//IL_0712: Unknown result type (might be due to invalid IL or missing references)
		//IL_0719: Expected O, but got Unknown
		//IL_0781: Unknown result type (might be due to invalid IL or missing references)
		//IL_0788: Expected O, but got Unknown
		//IL_0932: Unknown result type (might be due to invalid IL or missing references)
		//IL_09ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_09b3: Expected O, but got Unknown
		//IL_0a46: Unknown result type (might be due to invalid IL or missing references)
		//IL_0aa7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0aae: Expected O, but got Unknown
		//IL_0bc7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c2a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c31: Expected O, but got Unknown
		//IL_0ca7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d06: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d0d: Expected O, but got Unknown
		//IL_0d8a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d91: Expected O, but got Unknown
		//IL_0e74: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e7b: Expected O, but got Unknown
		//IL_0f04: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f0b: Expected O, but got Unknown
		//IL_0f8d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f94: Expected O, but got Unknown
		//IL_1118: Unknown result type (might be due to invalid IL or missing references)
		//IL_1192: Unknown result type (might be due to invalid IL or missing references)
		//IL_1199: Expected O, but got Unknown
		//IL_120b: Unknown result type (might be due to invalid IL or missing references)
		//IL_1269: Unknown result type (might be due to invalid IL or missing references)
		//IL_1270: Expected O, but got Unknown
		//IL_13a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_1404: Unknown result type (might be due to invalid IL or missing references)
		//IL_140b: Expected O, but got Unknown
		//IL_1481: Unknown result type (might be due to invalid IL or missing references)
		//IL_14e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_14e7: Expected O, but got Unknown
		//IL_1564: Unknown result type (might be due to invalid IL or missing references)
		//IL_156b: Expected O, but got Unknown
		//IL_164e: Unknown result type (might be due to invalid IL or missing references)
		//IL_1655: Expected O, but got Unknown
		//IL_16de: Unknown result type (might be due to invalid IL or missing references)
		//IL_16e5: Expected O, but got Unknown
		//IL_1767: Unknown result type (might be due to invalid IL or missing references)
		//IL_176e: Expected O, but got Unknown
		//IL_18c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_1942: Unknown result type (might be due to invalid IL or missing references)
		//IL_1949: Expected O, but got Unknown
		//IL_19dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_1a3d: Unknown result type (might be due to invalid IL or missing references)
		//IL_1a44: Expected O, but got Unknown
		//IL_1b5d: Unknown result type (might be due to invalid IL or missing references)
		//IL_1bc0: Unknown result type (might be due to invalid IL or missing references)
		//IL_1bc7: Expected O, but got Unknown
		//IL_1c3d: Unknown result type (might be due to invalid IL or missing references)
		//IL_1c9c: Unknown result type (might be due to invalid IL or missing references)
		//IL_1ca3: Expected O, but got Unknown
		//IL_1d20: Unknown result type (might be due to invalid IL or missing references)
		//IL_1d27: Expected O, but got Unknown
		//IL_1e0a: Unknown result type (might be due to invalid IL or missing references)
		//IL_1e11: Expected O, but got Unknown
		//IL_1e9a: Unknown result type (might be due to invalid IL or missing references)
		//IL_1ea1: Expected O, but got Unknown
		//IL_1f23: Unknown result type (might be due to invalid IL or missing references)
		//IL_1f2a: Expected O, but got Unknown
		//IL_2051: Unknown result type (might be due to invalid IL or missing references)
		//IL_2058: Expected O, but got Unknown
		//IL_20e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_20ef: Expected O, but got Unknown
		//IL_2188: Unknown result type (might be due to invalid IL or missing references)
		//IL_218f: Expected O, but got Unknown
		//IL_2223: Unknown result type (might be due to invalid IL or missing references)
		//IL_222a: Expected O, but got Unknown
		//IL_22cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_22d6: Expected O, but got Unknown
		//IL_23b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_23c0: Expected O, but got Unknown
		//IL_2449: Unknown result type (might be due to invalid IL or missing references)
		//IL_2450: Expected O, but got Unknown
		//IL_24d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_24d9: Expected O, but got Unknown
		checked
		{
			int num = default(int);
			try
			{
				((ToolStrip)ContextMenuStrip5).get_Items().Clear();
				if (Operators.ConditionalCompareObjectEqual(DataGridView1.get_Item(1, ((DataGridViewBand)DataGridView1.get_SelectedRows().get_Item(0)).get_Index()).get_Value(), (object)"File restored", false))
				{
					string text = Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(DataGridView1.get_Item(4, ((DataGridViewBand)DataGridView1.get_SelectedRows().get_Item(0)).get_Index()).get_Value(), (Type)null, "replace", new object[2] { "File ", "" }, (string[])null, (Type[])null, (bool[])null), (Type)null, "replace", new object[2] { " has been restored.", "" }, (string[])null, (Type[])null, (bool[])null), (Type)null, "trim", new object[0], (string[])null, (Type[])null, (bool[])null));
					if (File.Exists(text))
					{
						text = OrigCase(text);
						ToolStripMenuItem val = new ToolStripMenuItem();
						((ToolStripItem)val).add_Click((EventHandler)item_Click);
						if (text.Contains("\\"))
						{
							((ToolStripItem)val).set_Text("Wipe " + text.Substring(text.LastIndexOf("\\") + 1));
						}
						else
						{
							((ToolStripItem)val).set_Text(text);
						}
						((ToolStripItem)val).set_Tag((object)text);
						((ToolStrip)ContextMenuStrip5).get_Items().Add((ToolStripItem)(object)val);
					}
				}
				if (Operators.ConditionalCompareObjectEqual(DataGridView1.get_Item(1, ((DataGridViewBand)DataGridView1.get_SelectedRows().get_Item(0)).get_Index()).get_Value(), (object)"Critical error", false))
				{
					if (Operators.ConditionalCompareObjectEqual(DataGridView1.get_Item(3, ((DataGridViewBand)DataGridView1.get_SelectedRows().get_Item(0)).get_Index()).get_Value(), (object)"License error", false))
					{
						ToolStripMenuItem val2 = new ToolStripMenuItem();
						((ToolStripItem)val2).add_Click((EventHandler)item_Click);
						((ToolStripItem)val2).set_Text("Go to dashboard");
						((ToolStrip)ContextMenuStrip5).get_Items().Add((ToolStripItem)(object)val2);
					}
					else if (Operators.ConditionalCompareObjectEqual(DataGridView1.get_Item(3, ((DataGridViewBand)DataGridView1.get_SelectedRows().get_Item(0)).get_Index()).get_Value(), (object)"Files missing", false))
					{
						if (Operators.CompareString(Label56.get_Text(), "Running", false) != 0)
						{
							ToolStripMenuItem val3 = new ToolStripMenuItem();
							((ToolStripItem)val3).add_Click((EventHandler)item_Click);
							((ToolStripItem)val3).set_Text("Reinstall Cyber Prot");
							((ToolStrip)ContextMenuStrip5).get_Items().Add((ToolStripItem)(object)val3);
						}
						else
						{
							ToolStripMenuItem val4 = new ToolStripMenuItem();
							((ToolStripItem)val4).add_Click((EventHandler)item_Click);
							((ToolStripItem)val4).set_Text("Go to dashboard");
							((ToolStrip)ContextMenuStrip5).get_Items().Add((ToolStripItem)(object)val4);
						}
					}
					else if (Operators.ConditionalCompareObjectEqual(DataGridView1.get_Item(3, ((DataGridViewBand)DataGridView1.get_SelectedRows().get_Item(0)).get_Index()).get_Value(), (object)"Driver error", false))
					{
						Conversions.ToString(DataGridView1.get_Item(4, ((DataGridViewBand)DataGridView1.get_SelectedRows().get_Item(0)).get_Index()).get_Value());
						if (Operators.CompareString(Label56.get_Text(), "Running", false) != 0)
						{
							if (Conversions.ToString(DataGridView1.get_Item(4, ((DataGridViewBand)DataGridView1.get_SelectedRows().get_Item(0)).get_Index()).get_Value()).StartsWith("Cyber Prot's CBFS driver needs a reboot to install properly!"))
							{
								ToolStripMenuItem val5 = new ToolStripMenuItem();
								((ToolStripItem)val5).add_Click((EventHandler)item_Click);
								((ToolStripItem)val5).set_Text("Reboot computer");
								((ToolStrip)ContextMenuStrip5).get_Items().Add((ToolStripItem)(object)val5);
							}
							else
							{
								ToolStripMenuItem val6 = new ToolStripMenuItem();
								((ToolStripItem)val6).add_Click((EventHandler)item_Click);
								((ToolStripItem)val6).set_Text("Reinstall Cyber Prot");
								((ToolStrip)ContextMenuStrip5).get_Items().Add((ToolStripItem)(object)val6);
							}
						}
						else
						{
							ToolStripMenuItem val7 = new ToolStripMenuItem();
							((ToolStripItem)val7).add_Click((EventHandler)item_Click);
							((ToolStripItem)val7).set_Text("Go to dashboard");
							((ToolStrip)ContextMenuStrip5).get_Items().Add((ToolStripItem)(object)val7);
						}
					}
				}
				if (Operators.ConditionalCompareObjectEqual(DataGridView1.get_Item(1, ((DataGridViewBand)DataGridView1.get_SelectedRows().get_Item(0)).get_Index()).get_Value(), (object)"Engine status", false) || Operators.ConditionalCompareObjectEqual(DataGridView1.get_Item(1, ((DataGridViewBand)DataGridView1.get_SelectedRows().get_Item(0)).get_Index()).get_Value(), (object)"License changed", false) || Operators.ConditionalCompareObjectEqual(DataGridView1.get_Item(1, ((DataGridViewBand)DataGridView1.get_SelectedRows().get_Item(0)).get_Index()).get_Value(), (object)"Application", false))
				{
					ToolStripMenuItem val8 = new ToolStripMenuItem();
					((ToolStripItem)val8).add_Click((EventHandler)item_Click);
					((ToolStripItem)val8).set_Text("Go to dashboard");
					((ToolStrip)ContextMenuStrip5).get_Items().Add((ToolStripItem)(object)val8);
				}
				if (Operators.ConditionalCompareObjectEqual(DataGridView1.get_Item(1, ((DataGridViewBand)DataGridView1.get_SelectedRows().get_Item(0)).get_Index()).get_Value(), (object)"Proactivity applied", false))
				{
					ToolStripMenuItem val9 = new ToolStripMenuItem();
					((ToolStripItem)val9).add_Click((EventHandler)item_Click);
					((ToolStripItem)val9).set_Text("Go to settings");
					((ToolStrip)ContextMenuStrip5).get_Items().Add((ToolStripItem)(object)val9);
				}
				if (Operators.ConditionalCompareObjectEqual(DataGridView1.get_Item(1, ((DataGridViewBand)DataGridView1.get_SelectedRows().get_Item(0)).get_Index()).get_Value(), (object)"Setting changed", false))
				{
					if (Conversions.ToBoolean((object)(Conversions.ToBoolean(NewLateBinding.LateGet(DataGridView1.get_Item(3, ((DataGridViewBand)DataGridView1.get_SelectedRows().get_Item(0)).get_Index()).get_Value(), (Type)null, "endswith", new object[1] { " white list" }, (string[])null, (Type[])null, (bool[])null)) || Conversions.ToBoolean(NewLateBinding.LateGet(DataGridView1.get_Item(3, ((DataGridViewBand)DataGridView1.get_SelectedRows().get_Item(0)).get_Index()).get_Value(), (Type)null, "startswith", new object[1] { "Path white list" }, (string[])null, (Type[])null, (bool[])null)) || Conversions.ToBoolean(NewLateBinding.LateGet(DataGridView1.get_Item(3, ((DataGridViewBand)DataGridView1.get_SelectedRows().get_Item(0)).get_Index()).get_Value(), (Type)null, "startswith", new object[1] { "App white list" }, (string[])null, (Type[])null, (bool[])null)))))
					{
						if (Conversions.ToBoolean(NewLateBinding.LateGet(DataGridView1.get_Item(3, ((DataGridViewBand)DataGridView1.get_SelectedRows().get_Item(0)).get_Index()).get_Value(), (Type)null, "startswith", new object[1] { "Path " }, (string[])null, (Type[])null, (bool[])null)))
						{
							ToolStripMenuItem val10 = new ToolStripMenuItem();
							((ToolStripItem)val10).add_Click((EventHandler)item_Click);
							((ToolStripItem)val10).set_Text("Go to white listed paths");
							((ToolStrip)ContextMenuStrip5).get_Items().Add((ToolStripItem)(object)val10);
						}
						else
						{
							ToolStripMenuItem val11 = new ToolStripMenuItem();
							((ToolStripItem)val11).add_Click((EventHandler)item_Click);
							((ToolStripItem)val11).set_Text("Go to white listed applications");
							((ToolStrip)ContextMenuStrip5).get_Items().Add((ToolStripItem)(object)val11);
						}
					}
					else if (!Operators.ConditionalCompareObjectEqual(DataGridView1.get_Item(3, ((DataGridViewBand)DataGridView1.get_SelectedRows().get_Item(0)).get_Index()).get_Value(), (object)"File wiped", false))
					{
						ToolStripMenuItem val12 = new ToolStripMenuItem();
						((ToolStripItem)val12).add_Click((EventHandler)item_Click);
						((ToolStripItem)val12).set_Text("Go to settings");
						((ToolStrip)ContextMenuStrip5).get_Items().Add((ToolStripItem)(object)val12);
					}
				}
				if (Operators.ConditionalCompareObjectEqual(DataGridView1.get_Item(1, ((DataGridViewBand)DataGridView1.get_SelectedRows().get_Item(0)).get_Index()).get_Value(), (object)"Threat detected", false))
				{
					string text2 = Conversions.ToString(DataGridView1.get_Item(4, ((DataGridViewBand)DataGridView1.get_SelectedRows().get_Item(0)).get_Index()).get_Value());
					List<string> list = new List<string>(text2.Split(new char[1] { '\r' }));
					IEnumerator enumerator3 = default(IEnumerator);
					IEnumerator enumerator4 = default(IEnumerator);
					IEnumerator enumerator6 = default(IEnumerator);
					IEnumerator enumerator7 = default(IEnumerator);
					IEnumerator enumerator8 = default(IEnumerator);
					IEnumerator enumerator10 = default(IEnumerator);
					IEnumerator enumerator11 = default(IEnumerator);
					IEnumerator enumerator13 = default(IEnumerator);
					IEnumerator enumerator14 = default(IEnumerator);
					IEnumerator enumerator15 = default(IEnumerator);
					IEnumerator enumerator17 = default(IEnumerator);
					IEnumerator enumerator18 = default(IEnumerator);
					IEnumerator enumerator20 = default(IEnumerator);
					IEnumerator enumerator21 = default(IEnumerator);
					IEnumerator enumerator22 = default(IEnumerator);
					IEnumerator enumerator24 = default(IEnumerator);
					IEnumerator enumerator25 = default(IEnumerator);
					IEnumerator enumerator26 = default(IEnumerator);
					foreach (string item in list)
					{
						if (!item.Trim().StartsWith("Heuristic engine detected multirename suspicious activity ") && !item.Trim().StartsWith("Heuristic engine detected suspicious activity on trap folders done by process"))
						{
							if (item.Trim().StartsWith("Scanning engine detected suspicious file rename attempted by process"))
							{
								List<string> list2 = new List<string>(item.Split(new char[1] { '"' }));
								List<string> list3 = new List<string>(list2[5].Split(new char[1] { '"' }));
								using (List<string>.Enumerator enumerator2 = list3.GetEnumerator())
								{
									for (; enumerator2.MoveNext(); num = 16)
									{
										string current2 = enumerator2.Current;
										if (!current2.Contains("\\"))
										{
											continue;
										}
										if (!IsInWhitePath(current2.Substring(0, current2.LastIndexOf("\\"))))
										{
											try
											{
												enumerator3 = ((ArrangedElementCollection)((ToolStrip)ContextMenuStrip5).get_Items()).GetEnumerator();
												while (enumerator3.MoveNext())
												{
													if (Operators.CompareString(((ToolStripItem)enumerator3.Current).get_Text(), "Add to white list path " + OrigCase(current2.Substring(0, current2.LastIndexOf("\\"))), false) != 0)
													{
														continue;
													}
													goto IL_0b25;
												}
											}
											finally
											{
												if (enumerator3 is IDisposable)
												{
													(enumerator3 as IDisposable).Dispose();
												}
											}
											if (Directory.Exists(current2.Substring(0, current2.LastIndexOf("\\"))))
											{
												ToolStripMenuItem val13 = new ToolStripMenuItem();
												((ToolStripItem)val13).add_Click((EventHandler)item_Click);
												((ToolStripItem)val13).set_Text("Add to white list path " + OrigCase(current2.Substring(0, current2.LastIndexOf("\\"))));
												((ToolStripItem)val13).set_Tag((object)OrigCase(current2.Substring(0, current2.LastIndexOf("\\"))));
												((ToolStrip)ContextMenuStrip5).get_Items().Add((ToolStripItem)(object)val13);
											}
											continue;
										}
										try
										{
											enumerator4 = ((ArrangedElementCollection)((ToolStrip)ContextMenuStrip5).get_Items()).GetEnumerator();
											while (enumerator4.MoveNext())
											{
												if (Operators.CompareString(((ToolStripItem)enumerator4.Current).get_Text(), "Remove path " + OrigCase(current2.Substring(0, current2.LastIndexOf("\\"))) + " from white list", false) != 0)
												{
													continue;
												}
												goto IL_0b25;
											}
										}
										finally
										{
											if (enumerator4 is IDisposable)
											{
												(enumerator4 as IDisposable).Dispose();
											}
										}
										ToolStripMenuItem val14 = new ToolStripMenuItem();
										((ToolStripItem)val14).add_Click((EventHandler)item_Click);
										((ToolStripItem)val14).set_Text("Remove path " + OrigCase(current2.Substring(0, current2.LastIndexOf("\\"))) + " from white list");
										((ToolStripItem)val14).set_Tag((object)OrigCase(current2.Substring(0, current2.LastIndexOf("\\"))));
										((ToolStrip)ContextMenuStrip5).get_Items().Add((ToolStripItem)(object)val14);
										IL_0b25:;
									}
								}
								List<string> list4 = new List<string>(list2[1].Split(new char[1] { '"' }));
								using (List<string>.Enumerator enumerator5 = list4.GetEnumerator())
								{
									for (; enumerator5.MoveNext(); num = 27)
									{
										string current3 = enumerator5.Current;
										bool flag = false;
										if (current3 == null)
										{
											continue;
										}
										current3 = OrigCase(current3);
										if (current3.Contains("\\"))
										{
											if (!IsInWhiteApp(current3))
											{
												try
												{
													enumerator6 = ((ArrangedElementCollection)((ToolStrip)ContextMenuStrip5).get_Items()).GetEnumerator();
													while (enumerator6.MoveNext())
													{
														if (Operators.CompareString(((ToolStripItem)enumerator6.Current).get_Text(), "Add to white list application " + current3.Substring(current3.LastIndexOf("\\") + 1), false) != 0)
														{
															continue;
														}
														goto IL_1023;
													}
												}
												finally
												{
													if (enumerator6 is IDisposable)
													{
														(enumerator6 as IDisposable).Dispose();
													}
												}
												if (File.Exists(current3))
												{
													ToolStripMenuItem val15 = new ToolStripMenuItem();
													((ToolStripItem)val15).add_Click((EventHandler)item_Click);
													((ToolStripItem)val15).set_Text("Add to white list application " + current3.Substring(current3.LastIndexOf("\\") + 1));
													((ToolStripItem)val15).set_Tag((object)current3);
													((ToolStrip)ContextMenuStrip5).get_Items().Add((ToolStripItem)(object)val15);
												}
											}
											else
											{
												try
												{
													enumerator7 = ((ArrangedElementCollection)((ToolStrip)ContextMenuStrip5).get_Items()).GetEnumerator();
													while (enumerator7.MoveNext())
													{
														if (Operators.CompareString(((ToolStripItem)enumerator7.Current).get_Text(), "Remove application " + current3.Substring(current3.LastIndexOf("\\") + 1) + " from white list", false) != 0)
														{
															continue;
														}
														flag = true;
														goto IL_1023;
													}
												}
												finally
												{
													if (enumerator7 is IDisposable)
													{
														(enumerator7 as IDisposable).Dispose();
													}
												}
												ToolStripMenuItem val16 = new ToolStripMenuItem();
												((ToolStripItem)val16).add_Click((EventHandler)item_Click);
												((ToolStripItem)val16).set_Text("Remove application " + current3.Substring(current3.LastIndexOf("\\") + 1) + " from white list");
												((ToolStripItem)val16).set_Tag((object)current3);
												flag = true;
												((ToolStrip)ContextMenuStrip5).get_Items().Add((ToolStripItem)(object)val16);
											}
										}
										goto IL_1023;
										IL_1023:
										num = 17;
										try
										{
											enumerator8 = ((ArrangedElementCollection)((ToolStrip)ContextMenuStrip5).get_Items()).GetEnumerator();
											while (enumerator8.MoveNext())
											{
												ToolStripItem val17 = (ToolStripItem)enumerator8.Current;
												if (current3.Contains("\\"))
												{
													if (Operators.CompareString(val17.get_Text(), "Restore " + current3.Substring(current3.LastIndexOf("\\") + 1) + " from quarantine", false) != 0)
													{
														continue;
													}
												}
												else if (Operators.CompareString(val17.get_Text(), "Restore " + current3 + " from quarantine", false) != 0)
												{
													continue;
												}
												goto IL_101b;
											}
										}
										finally
										{
											if (enumerator8 is IDisposable)
											{
												(enumerator8 as IDisposable).Dispose();
											}
										}
										int num2 = DataGridView2.get_Rows().get_Count() - 1;
										for (int i = 0; i <= num2; i++)
										{
											if (Operators.CompareString(DataGridView2.get_Item(1, i).get_Value().ToString()!.Trim().ToLower(), current3.Trim().ToLower(), false) != 0)
											{
												continue;
											}
											ToolStripMenuItem val18 = new ToolStripMenuItem();
											((ToolStripItem)val18).add_Click((EventHandler)item_Click);
											if (current3.Contains("\\"))
											{
												((ToolStripItem)val18).set_Text("Restore " + current3.Substring(current3.LastIndexOf("\\") + 1) + " from quarantine");
											}
											else
											{
												((ToolStripItem)val18).set_Text("Restore " + current3 + " from quarantine");
											}
											((ToolStripItem)val18).set_Tag((object)current3);
											((ToolStrip)ContextMenuStrip5).get_Items().Add((ToolStripItem)(object)val18);
											if (!flag)
											{
												val18 = new ToolStripMenuItem();
												((ToolStripItem)val18).add_Click((EventHandler)item_Click);
												if (current3.Contains("\\"))
												{
													((ToolStripItem)val18).set_Text("Restore " + current3.Substring(current3.LastIndexOf("\\") + 1) + " from quarantine and add it to white list");
												}
												else
												{
													((ToolStripItem)val18).set_Text("Restore " + current3 + " from quarantine and add it to white list");
												}
												((ToolStripItem)val18).set_Tag((object)current3);
												((ToolStrip)ContextMenuStrip5).get_Items().Add((ToolStripItem)(object)val18);
											}
											val18 = new ToolStripMenuItem();
											((ToolStripItem)val18).add_Click((EventHandler)item_Click);
											if (current3.Contains("\\"))
											{
												((ToolStripItem)val18).set_Text("Wipe " + current3.Substring(current3.LastIndexOf("\\") + 1));
											}
											else
											{
												((ToolStripItem)val18).set_Text("Wipe " + current3);
											}
											((ToolStripItem)val18).set_Tag((object)current3);
											((ToolStrip)ContextMenuStrip5).get_Items().Add((ToolStripItem)(object)val18);
										}
										IL_101b:;
									}
								}
								continue;
							}
							if (!item.Trim().StartsWith("Heuristic engine detected suspicious file creation") && !item.Trim().StartsWith("Scanning engine detected suspicious file creation") && !item.Trim().StartsWith("Heuristic engine detected suspicious activity on file "))
							{
								if (item.Trim().StartsWith("from "))
								{
									List<string> list5 = new List<string>(item.Split(new char[1] { '"' }));
									using List<string>.Enumerator enumerator9 = list5.GetEnumerator();
									for (; enumerator9.MoveNext(); num = 10)
									{
										string current4 = enumerator9.Current;
										if (!current4.Contains("\\"))
										{
											continue;
										}
										if (!IsInWhitePath(current4.Substring(0, current4.LastIndexOf("\\"))))
										{
											try
											{
												enumerator10 = ((ArrangedElementCollection)((ToolStrip)ContextMenuStrip5).get_Items()).GetEnumerator();
												while (enumerator10.MoveNext())
												{
													if (Operators.CompareString(((ToolStripItem)enumerator10.Current).get_Text(), "Add to white list path " + OrigCase(current4.Substring(0, current4.LastIndexOf("\\"))), false) != 0)
													{
														continue;
													}
													goto IL_12c6;
												}
											}
											finally
											{
												if (enumerator10 is IDisposable)
												{
													(enumerator10 as IDisposable).Dispose();
												}
											}
											if (Directory.Exists(current4.Substring(0, current4.LastIndexOf("\\"))))
											{
												ToolStripMenuItem val19 = new ToolStripMenuItem();
												((ToolStripItem)val19).add_Click((EventHandler)item_Click);
												((ToolStripItem)val19).set_Text("Add to white list path " + OrigCase(current4.Substring(0, current4.LastIndexOf("\\"))));
												((ToolStrip)ContextMenuStrip5).get_Items().Add((ToolStripItem)(object)val19);
											}
											continue;
										}
										try
										{
											enumerator11 = ((ArrangedElementCollection)((ToolStrip)ContextMenuStrip5).get_Items()).GetEnumerator();
											while (enumerator11.MoveNext())
											{
												if (Operators.CompareString(((ToolStripItem)enumerator11.Current).get_Text(), "Remove path " + OrigCase(current4.Substring(0, current4.LastIndexOf("\\"))) + " from white list", false) != 0)
												{
													continue;
												}
												goto IL_12c6;
											}
										}
										finally
										{
											if (enumerator11 is IDisposable)
											{
												(enumerator11 as IDisposable).Dispose();
											}
										}
										ToolStripMenuItem val20 = new ToolStripMenuItem();
										((ToolStripItem)val20).add_Click((EventHandler)item_Click);
										((ToolStripItem)val20).set_Text("Remove path " + OrigCase(current4.Substring(0, current4.LastIndexOf("\\"))) + " from white list");
										((ToolStrip)ContextMenuStrip5).get_Items().Add((ToolStripItem)(object)val20);
										IL_12c6:;
									}
								}
								else
								{
									if (!item.Trim().EndsWith(" was locked.") && !item.Trim().EndsWith(" was quarantined.") && !item.Trim().EndsWith(" was killed."))
									{
										continue;
									}
									List<string> list6 = new List<string>(item.Split(new char[1] { '"' }));
									using List<string>.Enumerator enumerator12 = list6.GetEnumerator();
									for (; enumerator12.MoveNext(); num = 25)
									{
										string current5 = enumerator12.Current;
										bool flag2 = false;
										if (current5 == null)
										{
											continue;
										}
										current5 = OrigCase(current5);
										if (current5.Contains("\\"))
										{
											if (!IsInWhiteApp(current5))
											{
												try
												{
													enumerator13 = ((ArrangedElementCollection)((ToolStrip)ContextMenuStrip5).get_Items()).GetEnumerator();
													while (enumerator13.MoveNext())
													{
														if (Operators.CompareString(((ToolStripItem)enumerator13.Current).get_Text(), "Add to white list application " + current5.Substring(current5.LastIndexOf("\\") + 1), false) != 0)
														{
															continue;
														}
														goto IL_17fd;
													}
												}
												finally
												{
													if (enumerator13 is IDisposable)
													{
														(enumerator13 as IDisposable).Dispose();
													}
												}
												if (File.Exists(current5))
												{
													ToolStripMenuItem val21 = new ToolStripMenuItem();
													((ToolStripItem)val21).add_Click((EventHandler)item_Click);
													((ToolStripItem)val21).set_Text("Add to white list application " + current5.Substring(current5.LastIndexOf("\\") + 1));
													((ToolStripItem)val21).set_Tag((object)current5);
													((ToolStrip)ContextMenuStrip5).get_Items().Add((ToolStripItem)(object)val21);
												}
											}
											else
											{
												try
												{
													enumerator14 = ((ArrangedElementCollection)((ToolStrip)ContextMenuStrip5).get_Items()).GetEnumerator();
													while (enumerator14.MoveNext())
													{
														if (Operators.CompareString(((ToolStripItem)enumerator14.Current).get_Text(), "Remove application " + current5.Substring(current5.LastIndexOf("\\") + 1) + " from white list", false) != 0)
														{
															continue;
														}
														flag2 = true;
														goto IL_17fd;
													}
												}
												finally
												{
													if (enumerator14 is IDisposable)
													{
														(enumerator14 as IDisposable).Dispose();
													}
												}
												ToolStripMenuItem val22 = new ToolStripMenuItem();
												((ToolStripItem)val22).add_Click((EventHandler)item_Click);
												((ToolStripItem)val22).set_Text("Remove application " + current5.Substring(current5.LastIndexOf("\\") + 1) + " from white list");
												((ToolStripItem)val22).set_Tag((object)current5);
												flag2 = true;
												((ToolStrip)ContextMenuStrip5).get_Items().Add((ToolStripItem)(object)val22);
											}
										}
										goto IL_17fd;
										IL_17fd:
										num = 15;
										try
										{
											enumerator15 = ((ArrangedElementCollection)((ToolStrip)ContextMenuStrip5).get_Items()).GetEnumerator();
											while (enumerator15.MoveNext())
											{
												ToolStripItem val23 = (ToolStripItem)enumerator15.Current;
												if (current5.Contains("\\"))
												{
													if (Operators.CompareString(val23.get_Text(), "Restore " + current5.Substring(current5.LastIndexOf("\\") + 1) + " from quarantine", false) != 0)
													{
														continue;
													}
												}
												else if (Operators.CompareString(val23.get_Text(), "Restore " + current5 + " from quarantine", false) != 0)
												{
													continue;
												}
												goto IL_17f5;
											}
										}
										finally
										{
											if (enumerator15 is IDisposable)
											{
												(enumerator15 as IDisposable).Dispose();
											}
										}
										int num3 = DataGridView2.get_Rows().get_Count() - 1;
										for (int j = 0; j <= num3; j++)
										{
											if (Operators.CompareString(DataGridView2.get_Item(1, j).get_Value().ToString()!.Trim().ToLower(), current5.Trim().ToLower(), false) != 0)
											{
												continue;
											}
											ToolStripMenuItem val24 = new ToolStripMenuItem();
											((ToolStripItem)val24).add_Click((EventHandler)item_Click);
											if (current5.Contains("\\"))
											{
												((ToolStripItem)val24).set_Text("Restore " + current5.Substring(current5.LastIndexOf("\\") + 1) + " from quarantine");
											}
											else
											{
												((ToolStripItem)val24).set_Text("Restore " + current5 + " from quarantine");
											}
											((ToolStripItem)val24).set_Tag((object)current5);
											((ToolStrip)ContextMenuStrip5).get_Items().Add((ToolStripItem)(object)val24);
											if (!flag2)
											{
												val24 = new ToolStripMenuItem();
												((ToolStripItem)val24).add_Click((EventHandler)item_Click);
												if (current5.Contains("\\"))
												{
													((ToolStripItem)val24).set_Text("Restore " + current5.Substring(current5.LastIndexOf("\\") + 1) + " from quarantine and add it to white list");
												}
												else
												{
													((ToolStripItem)val24).set_Text("Restore " + current5 + " from quarantine and add it to white list");
												}
												((ToolStripItem)val24).set_Tag((object)current5);
												((ToolStrip)ContextMenuStrip5).get_Items().Add((ToolStripItem)(object)val24);
											}
											val24 = new ToolStripMenuItem();
											((ToolStripItem)val24).add_Click((EventHandler)item_Click);
											if (current5.Contains("\\"))
											{
												((ToolStripItem)val24).set_Text("Wipe " + current5.Substring(current5.LastIndexOf("\\") + 1));
											}
											else
											{
												((ToolStripItem)val24).set_Text("Wipe " + current5);
											}
											((ToolStripItem)val24).set_Tag((object)current5);
											((ToolStrip)ContextMenuStrip5).get_Items().Add((ToolStripItem)(object)val24);
										}
										IL_17f5:;
									}
								}
								continue;
							}
							List<string> list7 = new List<string>(item.Replace(" done by process ", " attempted by process ").Split(new char[1] { '"' }));
							List<string> list8 = new List<string>(list7[1].Split(new char[1] { '"' }));
							using (List<string>.Enumerator enumerator16 = list8.GetEnumerator())
							{
								for (; enumerator16.MoveNext(); num = 12)
								{
									string current6 = enumerator16.Current;
									if (!current6.Contains("\\"))
									{
										continue;
									}
									if (!IsInWhitePath(current6.Substring(0, current6.LastIndexOf("\\"))))
									{
										try
										{
											enumerator17 = ((ArrangedElementCollection)((ToolStrip)ContextMenuStrip5).get_Items()).GetEnumerator();
											while (enumerator17.MoveNext())
											{
												if (Operators.CompareString(((ToolStripItem)enumerator17.Current).get_Text(), "Add to white list path " + OrigCase(current6.Substring(0, current6.LastIndexOf("\\"))), false) != 0)
												{
													continue;
												}
												goto IL_1abb;
											}
										}
										finally
										{
											if (enumerator17 is IDisposable)
											{
												(enumerator17 as IDisposable).Dispose();
											}
										}
										if (Directory.Exists(current6.Substring(0, current6.LastIndexOf("\\"))))
										{
											ToolStripMenuItem val25 = new ToolStripMenuItem();
											((ToolStripItem)val25).add_Click((EventHandler)item_Click);
											((ToolStripItem)val25).set_Text("Add to white list path " + OrigCase(current6.Substring(0, current6.LastIndexOf("\\"))));
											((ToolStripItem)val25).set_Tag((object)OrigCase(current6.Substring(0, current6.LastIndexOf("\\"))));
											((ToolStrip)ContextMenuStrip5).get_Items().Add((ToolStripItem)(object)val25);
										}
										continue;
									}
									try
									{
										enumerator18 = ((ArrangedElementCollection)((ToolStrip)ContextMenuStrip5).get_Items()).GetEnumerator();
										while (enumerator18.MoveNext())
										{
											if (Operators.CompareString(((ToolStripItem)enumerator18.Current).get_Text(), "Remove path " + OrigCase(current6.Substring(0, current6.LastIndexOf("\\"))) + " from white list", false) != 0)
											{
												continue;
											}
											goto IL_1abb;
										}
									}
									finally
									{
										if (enumerator18 is IDisposable)
										{
											(enumerator18 as IDisposable).Dispose();
										}
									}
									ToolStripMenuItem val26 = new ToolStripMenuItem();
									((ToolStripItem)val26).add_Click((EventHandler)item_Click);
									((ToolStripItem)val26).set_Text("Remove path " + OrigCase(current6.Substring(0, current6.LastIndexOf("\\"))) + " from white list");
									((ToolStripItem)val26).set_Tag((object)OrigCase(current6.Substring(0, current6.LastIndexOf("\\"))));
									((ToolStrip)ContextMenuStrip5).get_Items().Add((ToolStripItem)(object)val26);
									IL_1abb:;
								}
							}
							List<string> list9 = new List<string>(list7[3].Split(new char[1] { '"' }));
							using (List<string>.Enumerator enumerator19 = list9.GetEnumerator())
							{
								for (; enumerator19.MoveNext(); num = 24)
								{
									string current7 = enumerator19.Current;
									bool flag3 = false;
									if (current7 == null)
									{
										continue;
									}
									current7 = OrigCase(current7);
									if (current7.Contains("\\"))
									{
										if (!IsInWhiteApp(current7))
										{
											try
											{
												enumerator20 = ((ArrangedElementCollection)((ToolStrip)ContextMenuStrip5).get_Items()).GetEnumerator();
												while (enumerator20.MoveNext())
												{
													if (Operators.CompareString(((ToolStripItem)enumerator20.Current).get_Text(), "Add to white list application " + current7.Substring(current7.LastIndexOf("\\") + 1), false) != 0)
													{
														continue;
													}
													goto IL_1fb9;
												}
											}
											finally
											{
												if (enumerator20 is IDisposable)
												{
													(enumerator20 as IDisposable).Dispose();
												}
											}
											if (File.Exists(current7))
											{
												ToolStripMenuItem val27 = new ToolStripMenuItem();
												((ToolStripItem)val27).add_Click((EventHandler)item_Click);
												((ToolStripItem)val27).set_Text("Add to white list application " + current7.Substring(current7.LastIndexOf("\\") + 1));
												((ToolStripItem)val27).set_Tag((object)current7);
												((ToolStrip)ContextMenuStrip5).get_Items().Add((ToolStripItem)(object)val27);
											}
										}
										else
										{
											try
											{
												enumerator21 = ((ArrangedElementCollection)((ToolStrip)ContextMenuStrip5).get_Items()).GetEnumerator();
												while (enumerator21.MoveNext())
												{
													if (Operators.CompareString(((ToolStripItem)enumerator21.Current).get_Text(), "Remove application " + current7.Substring(current7.LastIndexOf("\\") + 1) + " from white list", false) != 0)
													{
														continue;
													}
													flag3 = true;
													goto IL_1fb9;
												}
											}
											finally
											{
												if (enumerator21 is IDisposable)
												{
													(enumerator21 as IDisposable).Dispose();
												}
											}
											ToolStripMenuItem val28 = new ToolStripMenuItem();
											((ToolStripItem)val28).add_Click((EventHandler)item_Click);
											((ToolStripItem)val28).set_Text("Remove application " + current7.Substring(current7.LastIndexOf("\\") + 1) + " from white list");
											((ToolStripItem)val28).set_Tag((object)current7);
											flag3 = true;
											((ToolStrip)ContextMenuStrip5).get_Items().Add((ToolStripItem)(object)val28);
										}
									}
									goto IL_1fb9;
									IL_1fb9:
									num = 14;
									try
									{
										enumerator22 = ((ArrangedElementCollection)((ToolStrip)ContextMenuStrip5).get_Items()).GetEnumerator();
										while (enumerator22.MoveNext())
										{
											ToolStripItem val29 = (ToolStripItem)enumerator22.Current;
											if (current7.Contains("\\"))
											{
												if (Operators.CompareString(val29.get_Text(), "Restore " + current7.Substring(current7.LastIndexOf("\\") + 1) + " from quarantine", false) != 0)
												{
													continue;
												}
											}
											else if (Operators.CompareString(val29.get_Text(), "Restore " + current7 + " from quarantine", false) != 0)
											{
												continue;
											}
											goto IL_1fb1;
										}
									}
									finally
									{
										if (enumerator22 is IDisposable)
										{
											(enumerator22 as IDisposable).Dispose();
										}
									}
									int num4 = DataGridView2.get_Rows().get_Count() - 1;
									for (int k = 0; k <= num4; k++)
									{
										if (Operators.CompareString(DataGridView2.get_Item(1, k).get_Value().ToString()!.Trim().ToLower(), current7.Trim().ToLower(), false) != 0)
										{
											continue;
										}
										ToolStripMenuItem val30 = new ToolStripMenuItem();
										((ToolStripItem)val30).add_Click((EventHandler)item_Click);
										if (current7.Contains("\\"))
										{
											((ToolStripItem)val30).set_Text("Restore " + current7.Substring(current7.LastIndexOf("\\") + 1) + " from quarantine");
										}
										else
										{
											((ToolStripItem)val30).set_Text("Restore " + current7 + " from quarantine");
										}
										((ToolStripItem)val30).set_Tag((object)current7);
										((ToolStrip)ContextMenuStrip5).get_Items().Add((ToolStripItem)(object)val30);
										if (!flag3)
										{
											val30 = new ToolStripMenuItem();
											((ToolStripItem)val30).add_Click((EventHandler)item_Click);
											if (current7.Contains("\\"))
											{
												((ToolStripItem)val30).set_Text("Restore " + current7.Substring(current7.LastIndexOf("\\") + 1) + " from quarantine and add it to white list");
											}
											else
											{
												((ToolStripItem)val30).set_Text("Restore " + current7 + " from quarantine and add it to white list");
											}
											((ToolStripItem)val30).set_Tag((object)current7);
											((ToolStrip)ContextMenuStrip5).get_Items().Add((ToolStripItem)(object)val30);
										}
										val30 = new ToolStripMenuItem();
										((ToolStripItem)val30).add_Click((EventHandler)item_Click);
										if (current7.Contains("\\"))
										{
											((ToolStripItem)val30).set_Text("Wipe " + current7.Substring(current7.LastIndexOf("\\") + 1));
										}
										else
										{
											((ToolStripItem)val30).set_Text("Wipe " + current7);
										}
										((ToolStripItem)val30).set_Tag((object)current7);
										((ToolStrip)ContextMenuStrip5).get_Items().Add((ToolStripItem)(object)val30);
									}
									IL_1fb1:;
								}
							}
							continue;
						}
						List<string> list10 = new List<string>(item.Split(new char[1] { '"' }));
						using List<string>.Enumerator enumerator23 = list10.GetEnumerator();
						for (; enumerator23.MoveNext(); num = 21)
						{
							string current8 = enumerator23.Current;
							current8 = OrigCase(current8);
							bool flag4 = false;
							if (current8.Contains("\\"))
							{
								if (!IsInWhiteApp(current8))
								{
									try
									{
										enumerator24 = ((ArrangedElementCollection)((ToolStrip)ContextMenuStrip5).get_Items()).GetEnumerator();
										while (enumerator24.MoveNext())
										{
											ToolStripItem val31 = (ToolStripItem)enumerator24.Current;
											if (current8.Contains("\\"))
											{
												if (Operators.CompareString(val31.get_Text(), "Add to white list application " + current8.Substring(current8.LastIndexOf("\\") + 1), false) != 0)
												{
													continue;
												}
											}
											else if (Operators.CompareString(val31.get_Text(), "Add to white list application " + current8, false) != 0)
											{
												continue;
											}
											goto IL_2568;
										}
									}
									finally
									{
										if (enumerator24 is IDisposable)
										{
											(enumerator24 as IDisposable).Dispose();
										}
									}
									if (File.Exists(current8))
									{
										ToolStripMenuItem val32 = new ToolStripMenuItem();
										((ToolStripItem)val32).add_Click((EventHandler)item_Click);
										if (current8.Contains("\\"))
										{
											((ToolStripItem)val32).set_Text("Add to white list application " + current8.Substring(current8.LastIndexOf("\\") + 1));
										}
										else
										{
											((ToolStripItem)val32).set_Text("Add to white list application " + current8);
										}
										((ToolStripItem)val32).set_Tag((object)current8);
										((ToolStrip)ContextMenuStrip5).get_Items().Add((ToolStripItem)(object)val32);
									}
								}
								else
								{
									try
									{
										enumerator25 = ((ArrangedElementCollection)((ToolStrip)ContextMenuStrip5).get_Items()).GetEnumerator();
										while (enumerator25.MoveNext())
										{
											ToolStripItem val33 = (ToolStripItem)enumerator25.Current;
											if (current8.Contains("\\"))
											{
												if (Operators.CompareString(val33.get_Text(), "Remove application " + current8.Substring(current8.LastIndexOf("\\") + 1) + " from white list", false) != 0)
												{
													continue;
												}
												flag4 = true;
											}
											else
											{
												if (Operators.CompareString(val33.get_Text(), "Remove application " + current8 + " from white list", false) != 0)
												{
													continue;
												}
												flag4 = true;
											}
											goto IL_2568;
										}
									}
									finally
									{
										if (enumerator25 is IDisposable)
										{
											(enumerator25 as IDisposable).Dispose();
										}
									}
									ToolStripMenuItem val34 = new ToolStripMenuItem();
									((ToolStripItem)val34).add_Click((EventHandler)item_Click);
									if (current8.Contains("\\"))
									{
										((ToolStripItem)val34).set_Text("Remove application " + current8.Substring(current8.LastIndexOf("\\") + 1) + " from white list");
									}
									else
									{
										((ToolStripItem)val34).set_Text("Remove application " + current8 + " from white list");
									}
									((ToolStripItem)val34).set_Tag((object)current8);
									flag4 = true;
									((ToolStrip)ContextMenuStrip5).get_Items().Add((ToolStripItem)(object)val34);
								}
							}
							goto IL_2568;
							IL_2568:
							num = 11;
							try
							{
								enumerator26 = ((ArrangedElementCollection)((ToolStrip)ContextMenuStrip5).get_Items()).GetEnumerator();
								while (enumerator26.MoveNext())
								{
									ToolStripItem val35 = (ToolStripItem)enumerator26.Current;
									if (current8.Contains("\\"))
									{
										if (Operators.CompareString(val35.get_Text(), "Restore " + current8.Substring(current8.LastIndexOf("\\") + 1) + " from quarantine", false) != 0)
										{
											continue;
										}
									}
									else if (Operators.CompareString(val35.get_Text(), "Restore " + current8 + " from quarantine", false) != 0)
									{
										continue;
									}
									goto IL_2560;
								}
							}
							finally
							{
								if (enumerator26 is IDisposable)
								{
									(enumerator26 as IDisposable).Dispose();
								}
							}
							int num5 = DataGridView2.get_Rows().get_Count() - 1;
							for (int l = 0; l <= num5; l++)
							{
								if (Operators.CompareString(DataGridView2.get_Item(1, l).get_Value().ToString()!.Trim().ToLower(), current8.Trim().ToLower(), false) != 0)
								{
									continue;
								}
								ToolStripMenuItem val36 = new ToolStripMenuItem();
								((ToolStripItem)val36).add_Click((EventHandler)item_Click);
								if (current8.Contains("\\"))
								{
									((ToolStripItem)val36).set_Text("Restore " + current8.Substring(current8.LastIndexOf("\\") + 1) + " from quarantine");
								}
								else
								{
									((ToolStripItem)val36).set_Text("Restore " + current8 + " from quarantine");
								}
								((ToolStripItem)val36).set_Tag((object)current8);
								((ToolStrip)ContextMenuStrip5).get_Items().Add((ToolStripItem)(object)val36);
								if (!flag4)
								{
									val36 = new ToolStripMenuItem();
									((ToolStripItem)val36).add_Click((EventHandler)item_Click);
									if (current8.Contains("\\"))
									{
										((ToolStripItem)val36).set_Text("Restore " + current8.Substring(current8.LastIndexOf("\\") + 1) + " from quarantine and add it to white list");
									}
									else
									{
										((ToolStripItem)val36).set_Text("Restore " + current8 + " from quarantine and add it to white list");
									}
									((ToolStripItem)val36).set_Tag((object)current8);
									((ToolStrip)ContextMenuStrip5).get_Items().Add((ToolStripItem)(object)val36);
								}
								val36 = new ToolStripMenuItem();
								((ToolStripItem)val36).add_Click((EventHandler)item_Click);
								if (current8.Contains("\\"))
								{
									((ToolStripItem)val36).set_Text("Wipe " + current8.Substring(current8.LastIndexOf("\\") + 1));
								}
								else
								{
									((ToolStripItem)val36).set_Text("Wipe " + current8);
								}
								((ToolStripItem)val36).set_Tag((object)current8);
								((ToolStrip)ContextMenuStrip5).get_Items().Add((ToolStripItem)(object)val36);
							}
							IL_2560:;
						}
					}
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex, num);
				ProjectData.ClearProjectError();
			}
			if (((ArrangedElementCollection)((ToolStrip)ContextMenuStrip5).get_Items()).get_Count() == 0)
			{
				e.Cancel = true;
			}
		}
	}

	public void item_Click(object sender, EventArgs e)
	{
		string text = Conversions.ToString(NewLateBinding.LateGet(sender, (Type)null, "text", new object[0], (string[])null, (Type[])null, (bool[])null));
		checked
		{
			if (text.StartsWith("Add to white list application "))
			{
				Addw(Conversions.ToString(NewLateBinding.LateGet(sender, (Type)null, "tag", new object[0], (string[])null, (Type[])null, (bool[])null)));
			}
			else
			{
				switch (text)
				{
				case "Reboot computer":
					Interaction.Shell("Shutdown -r -f -t 0", (AppWinStyle)0, true, -1);
					return;
				case "Reinstall Cyber Prot":
					try
					{
						Thread thread = new Thread(StartUpdate);
						thread.Start();
						while (thread.IsAlive)
						{
							Thread.Sleep(50);
							Application.DoEvents();
						}
						return;
					}
					catch (Exception ex)
					{
						int num = default(int);
						ProjectData.SetProjectError(ex, num);
						Process.Start("http://www.cyberland.ro/index.html#download");
						ProjectData.ClearProjectError();
						return;
					}
				case "Go to dashboard":
					SwitchPanels(StatusPanelMain);
					return;
				case "Go to white listed applications":
					SwitchPanels(AdvancedPanelMain);
					((Control)Panel23).set_Visible(false);
					ExApps();
					return;
				case "Go to white listed paths":
					SwitchPanels(AdvancedPanelMain);
					((Control)Panel23).set_Visible(false);
					ExPaths();
					return;
				case "Go to settings":
					SwitchPanels(GeneralSettingsPanelMain);
					return;
				}
				if (text.StartsWith("Add to white list path "))
				{
					Addp(text.Replace("Add to white list path ", "").Trim());
				}
				else if (text.StartsWith("Remove application ") && text.EndsWith(" from white list"))
				{
					DELwA(Conversions.ToString(NewLateBinding.LateGet(sender, (Type)null, "tag", new object[0], (string[])null, (Type[])null, (bool[])null)));
				}
				else if (text.StartsWith("Remove path ") && text.EndsWith(" from white list"))
				{
					DELwP(text.Replace("Remove path ", "").Replace(" from white list", "").Trim());
				}
				else if (text.StartsWith("Wipe "))
				{
					text = Conversions.ToString(NewLateBinding.LateGet(sender, (Type)null, "tag", new object[0], (string[])null, (Type[])null, (bool[])null));
					int num;
					while (true)
					{
						IL_02dd:
						num = 86;
						int num2 = DataGridView2.get_Rows().get_Count() - 1;
						for (int i = 0; i <= num2; i++)
						{
							try
							{
								if (Operators.CompareString(DataGridView2.get_Item(1, i).get_Value().ToString()!.Trim().ToLower(), text.Trim().ToLower(), false) == 0)
								{
									DataGridView2.set_CurrentCell(DataGridView2.get_Item(1, i));
									DataGridView2.get_CurrentCell().set_Selected(false);
									Application.DoEvents();
									DataGridView2.get_CurrentCell().set_Selected(true);
									m(null, null);
									goto IL_02dd;
								}
							}
							catch (Exception ex2)
							{
								ProjectData.SetProjectError(ex2, num);
								ProjectData.ClearProjectError();
							}
						}
						break;
					}
					UnLock(text);
					Kill(text);
					try
					{
						if (File.Exists(text))
						{
							File.Delete(text);
						}
						CreateLog("File wiped", "File " + text + " has been permanently deleted.", (EventLogEntryType)2, Repair: true, 5);
					}
					catch (Exception ex3)
					{
						ProjectData.SetProjectError(ex3, num);
						ProjectData.ClearProjectError();
					}
				}
				else if (text.StartsWith("Restore "))
				{
					bool addToExceptions = false;
					if (text.EndsWith(" from quarantine and add it to white list"))
					{
						text = text.Replace(" from quarantine and add it to white list", "");
						addToExceptions = true;
					}
					if (text.EndsWith(" from quarantine"))
					{
						text = text.Replace(" from quarantine", "");
						addToExceptions = false;
					}
					text = Conversions.ToString(NewLateBinding.LateGet(sender, (Type)null, "tag", new object[0], (string[])null, (Type[])null, (bool[])null));
					while (true)
					{
						int num = 87;
						int num3 = DataGridView2.get_Rows().get_Count() - 1;
						int num4 = 0;
						while (num4 <= num3)
						{
							if (Operators.CompareString(DataGridView2.get_Item(1, num4).get_Value().ToString()!.Trim().ToLower(), text.Trim().ToLower(), false) != 0)
							{
								num4++;
								continue;
							}
							goto IL_0405;
						}
						break;
						IL_0405:
						DataGridView2.set_CurrentCell(DataGridView2.get_Item(1, num4));
						DataGridView2.get_CurrentCell().set_Selected(false);
						Application.DoEvents();
						DataGridView2.get_CurrentCell().set_Selected(true);
						RestoreQ(((DataGridViewBand)DataGridView2.get_CurrentRow()).get_Index(), addToExceptions);
					}
				}
			}
			a("");
		}
	}

	public void DELwP(string path)
	{
		//IL_00cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_01df: Unknown result type (might be due to invalid IL or missing references)
		//IL_021c: Unknown result type (might be due to invalid IL or missing references)
		ListBox1.get_Items().Clear();
		checked
		{
			try
			{
				string text = Decrypt(Conversions.ToString(Registry.LocalMachine.CreateSubKey("SOFTWARE\\Cyber Prot", RegistryKeyPermissionCheck.ReadWriteSubTree).GetValue("ExclusionPaths", "")));
				List<string> list = new List<string>(text.Split(new char[1] { ';' }));
				if (list.Count > 0)
				{
					int num = list.Count - 1;
					for (int i = 0; i <= num; i++)
					{
						if (Operators.CompareString(list[i].Trim(), "", false) != 0)
						{
							ListBox1.get_Items().Add((object)list[i]);
						}
					}
				}
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
			}
			try
			{
				if (LikeOperator.LikeString(path, "?:\\___CyberProt_Trap_Folder*", (CompareMethod)0))
				{
					MessageBox.Show("Can't select own trap folders!", "Cyber Prot", (MessageBoxButtons)0, (MessageBoxIcon)16);
					return;
				}
				ListBox1.set_Text(path);
				ListBox1.get_Items().RemoveAt(ListBox1.get_SelectedIndex());
				BList();
				try
				{
					string text2 = "";
					IEnumerator enumerator = default(IEnumerator);
					try
					{
						enumerator = ListBox1.get_Items().GetEnumerator();
						while (enumerator.MoveNext())
						{
							string text3 = Conversions.ToString(enumerator.Current);
							if (Operators.CompareString(text3, this.m_w, false) != 0)
							{
								text2 = text2 + text3 + ";";
							}
						}
					}
					finally
					{
						if (enumerator is IDisposable)
						{
							(enumerator as IDisposable).Dispose();
						}
					}
					Registry.LocalMachine.CreateSubKey("SOFTWARE\\Cyber Prot", RegistryKeyPermissionCheck.ReadWriteSubTree).SetValue("ExclusionPaths", Encrypt(text2));
					CreateLog("Path deleted from white list", "Folder " + ListBox1.get_Text() + " has been removed from white list", (EventLogEntryType)2, Repair: true, 1);
				}
				catch (Exception ex)
				{
					ProjectData.SetProjectError(ex);
					Exception ex2 = ex;
					MessageBox.Show("Error saving list: \r\n\r\n" + ex2.Message, "Cyber Prot", (MessageBoxButtons)0, (MessageBoxIcon)16);
					ProjectData.ClearProjectError();
					return;
				}
				CountExepts();
				CallService(1);
			}
			catch (Exception ex3)
			{
				ProjectData.SetProjectError(ex3);
				Exception ex4 = ex3;
				MessageBox.Show("Error deleting folder: \r\n\r\n" + ex4.Message, "Cyber Prot", (MessageBoxButtons)0, (MessageBoxIcon)16);
				ProjectData.ClearProjectError();
			}
		}
	}

	public void Addp(string path)
	{
		//IL_00d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_015c: Unknown result type (might be due to invalid IL or missing references)
		//IL_018f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0195: Invalid comparison between Unknown and I4
		//IL_031a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0320: Invalid comparison between Unknown and I4
		//IL_035f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0365: Invalid comparison between Unknown and I4
		//IL_0521: Unknown result type (might be due to invalid IL or missing references)
		//IL_056f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0598: Unknown result type (might be due to invalid IL or missing references)
		//IL_05c3: Unknown result type (might be due to invalid IL or missing references)
		ListBox1.get_Items().Clear();
		checked
		{
			int num2 = default(int);
			try
			{
				string text = Decrypt(Conversions.ToString(Registry.LocalMachine.CreateSubKey("SOFTWARE\\Cyber Prot", RegistryKeyPermissionCheck.ReadWriteSubTree).GetValue("ExclusionPaths", "")));
				List<string> list = new List<string>(text.Split(new char[1] { ';' }));
				if (list.Count > 0)
				{
					int num = list.Count - 1;
					for (int i = 0; i <= num; i++)
					{
						if (Operators.CompareString(list[i].Trim(), "", false) != 0)
						{
							ListBox1.get_Items().Add((object)list[i]);
						}
					}
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex, num2);
				ProjectData.ClearProjectError();
			}
			try
			{
				if (LikeOperator.LikeString(path, "?:\\___CyberProt_Trap_Folder*", (CompareMethod)0))
				{
					MessageBox.Show("Can't select own trap folders!", "Cyber Prot", (MessageBoxButtons)0, (MessageBoxIcon)16);
					return;
				}
				try
				{
					IEnumerator<DriveInfo> enumerator = ((ServerComputer)global::d.e()).get_FileSystem().get_Drives().GetEnumerator();
					while (enumerator.MoveNext())
					{
						DriveInfo current = enumerator.Current;
						try
						{
							if (current.DriveType == DriveType.Fixed && path.ToLower().StartsWith(current.Name.ToLower()))
							{
								goto IL_0167;
							}
						}
						catch (Exception ex2)
						{
							ProjectData.SetProjectError(ex2, num2);
							ProjectData.ClearProjectError();
						}
					}
				}
				catch (Exception ex3)
				{
					ProjectData.SetProjectError(ex3, num2);
					ProjectData.ClearProjectError();
				}
				MessageBox.Show("Only fixed drives can be selected!", "Cyber Prot", (MessageBoxButtons)0, (MessageBoxIcon)16);
				return;
				IL_0167:
				num2 = 10;
				if (path.Length == 3 && unchecked((int)MessageBox.Show((IWin32Window)(object)this, "Are you sure you want to white list the entire drive " + path + "?", "Cyber Prot", (MessageBoxButtons)4, (MessageBoxIcon)48)) == 7)
				{
					return;
				}
				string text2 = "";
				int num3 = 0;
				int num4 = ListBox1.get_Items().get_Count() - 1;
				int num5 = 0;
				IEnumerator enumerator3 = default(IEnumerator);
				while (true)
				{
					if (num5 <= num4)
					{
						if (Operators.CompareString(path.ToUpper().Trim(), ListBox1.get_Items().get_Item(num5).ToString()!.ToUpper().Trim(), false) == 0)
						{
							break;
						}
						num5++;
						continue;
					}
					int num6 = ListBox1.get_Items().get_Count() - 1;
					int num7 = 0;
					while (true)
					{
						if (num7 <= num6)
						{
							if (path.ToUpper().Trim().StartsWith(ListBox1.get_Items().get_Item(num7).ToString()!.ToUpper().Trim()))
							{
								break;
							}
							if (ListBox1.get_Items().get_Item(num7).ToString()!.ToUpper().Trim().StartsWith(path.ToUpper().Trim()))
							{
								if (num3 > 0)
								{
									text2 += "\r\n";
								}
								text2 += ListBox1.get_Items().get_Item(num7).ToString();
								num3++;
							}
							num7++;
							continue;
						}
						if (num3 > 0)
						{
							List<string> list2 = new List<string>(text2.Split(new char[1] { '\r' }));
							unchecked
							{
								if (num3 == 1)
								{
									if ((int)MessageBox.Show((IWin32Window)(object)this, list2[0] + " is a subfolder of " + path + " and needs to be removed from the list first!\r\nDo you want to remove it?", "Cyber Prot", (MessageBoxButtons)4, (MessageBoxIcon)48) == 7)
									{
										return;
									}
								}
								else if ((int)MessageBox.Show((IWin32Window)(object)this, Conversions.ToString(num3) + " subfolders of " + path + " needs to be removed from the list first!\r\nDo you want to remove the following entrys?\r\n" + text2, "Cyber Prot", (MessageBoxButtons)4, (MessageBoxIcon)48) == 7)
								{
									return;
								}
							}
							foreach (string item in list2)
							{
								if (Operators.CompareString(item.Trim(), "", false) == 0)
								{
									continue;
								}
								int num8 = ListBox1.get_Items().get_Count() - 1;
								for (int j = 0; j <= num8; j++)
								{
									if (Operators.CompareString(ListBox1.get_Items().get_Item(j).ToString()!.ToUpper().Trim(), item.ToUpper().Trim(), false) == 0)
									{
										ListBox1.get_Items().RemoveAt(j);
										break;
									}
								}
							}
						}
						ListBox1.get_Items().Add((object)path);
						ListBox1.set_Text(path);
						BList();
						try
						{
							string text3 = "";
							try
							{
								enumerator3 = ListBox1.get_Items().GetEnumerator();
								while (enumerator3.MoveNext())
								{
									string text4 = Conversions.ToString(enumerator3.Current);
									if (Operators.CompareString(text4, this.m_w, false) != 0)
									{
										text3 = text3 + text4 + ";";
									}
								}
							}
							finally
							{
								if (enumerator3 is IDisposable)
								{
									(enumerator3 as IDisposable).Dispose();
								}
							}
							Registry.LocalMachine.CreateSubKey("SOFTWARE\\Cyber Prot", RegistryKeyPermissionCheck.ReadWriteSubTree).SetValue("ExclusionPaths", Encrypt(text3));
							CreateLog("Path added to white list", "Folder " + ListBox1.get_Text() + " has been added to white list", (EventLogEntryType)2, Repair: true, 1);
						}
						catch (Exception ex4)
						{
							ProjectData.SetProjectError(ex4, num2);
							Exception ex5 = ex4;
							MessageBox.Show("Error saving list: \r\n\r\n" + ex5.Message, "Cyber Prot", (MessageBoxButtons)0, (MessageBoxIcon)16);
							ProjectData.ClearProjectError();
							return;
						}
						CountExepts();
						CallService(1);
						return;
					}
					ListBox1.set_SelectedIndex(num7);
					MessageBox.Show(path + " is already excluded as subfolder of " + ListBox1.get_Text(), "Cyber Prot", (MessageBoxButtons)0, (MessageBoxIcon)16);
					return;
				}
				ListBox1.set_Text(path);
				MessageBox.Show(path + " is already excluded!", "Cyber Prot", (MessageBoxButtons)0, (MessageBoxIcon)16);
			}
			catch (Exception ex6)
			{
				ProjectData.SetProjectError(ex6, num2);
				Exception ex7 = ex6;
				MessageBox.Show("Error adding folder: \r\n\r\n" + ex7.Message, "Cyber Prot", (MessageBoxButtons)0, (MessageBoxIcon)16);
				ProjectData.ClearProjectError();
			}
		}
	}

	public void Addw(string app)
	{
		//IL_0134: Unknown result type (might be due to invalid IL or missing references)
		//IL_029f: Unknown result type (might be due to invalid IL or missing references)
		//IL_02dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0307: Unknown result type (might be due to invalid IL or missing references)
		ListBox1.get_Items().Clear();
		checked
		{
			int num2 = default(int);
			try
			{
				string text = Decrypt(Conversions.ToString(Registry.LocalMachine.CreateSubKey("SOFTWARE\\Cyber Prot", RegistryKeyPermissionCheck.ReadWriteSubTree).GetValue("ExclusionApps", "")));
				List<string> list = new List<string>(text.Split(new char[1] { ';' }));
				if (list.Count > 0)
				{
					int num = list.Count - 1;
					for (int i = 0; i <= num; i++)
					{
						if (Operators.CompareString(list[i].Trim(), "", false) != 0)
						{
							ListBox1.get_Items().Add((object)list[i]);
						}
					}
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex, num2);
				ProjectData.ClearProjectError();
			}
			try
			{
				try
				{
					IEnumerator<DriveInfo> enumerator = ((ServerComputer)global::d.e()).get_FileSystem().get_Drives().GetEnumerator();
					while (enumerator.MoveNext())
					{
						DriveInfo current = enumerator.Current;
						try
						{
							if (current.DriveType == DriveType.Fixed && app.ToLower().StartsWith(current.Name.ToLower()))
							{
								goto IL_013f;
							}
						}
						catch (Exception ex2)
						{
							ProjectData.SetProjectError(ex2, num2);
							ProjectData.ClearProjectError();
						}
					}
				}
				catch (Exception ex3)
				{
					ProjectData.SetProjectError(ex3, num2);
					ProjectData.ClearProjectError();
				}
				MessageBox.Show("Only applications from fixed drives can be selected!", "Cyber Prot", (MessageBoxButtons)0, (MessageBoxIcon)16);
				return;
				IL_013f:
				num2 = 11;
				int num3 = ListBox1.get_Items().get_Count() - 1;
				int num4 = 0;
				IEnumerator enumerator2 = default(IEnumerator);
				while (true)
				{
					if (num4 <= num3)
					{
						if (Operators.CompareString(app.ToUpper().Trim(), ListBox1.get_Items().get_Item(num4).ToString()!.ToUpper().Trim(), false) == 0)
						{
							break;
						}
						num4++;
						continue;
					}
					ListBox1.get_Items().Add((object)app);
					ListBox1.set_Text(app);
					BList();
					try
					{
						string text2 = "";
						try
						{
							enumerator2 = ListBox1.get_Items().GetEnumerator();
							while (enumerator2.MoveNext())
							{
								string text3 = Conversions.ToString(enumerator2.Current);
								if (Operators.CompareString(text3, this.m_w, false) != 0)
								{
									text2 = text2 + text3 + ";";
								}
							}
						}
						finally
						{
							if (enumerator2 is IDisposable)
							{
								(enumerator2 as IDisposable).Dispose();
							}
						}
						Registry.LocalMachine.CreateSubKey("SOFTWARE\\Cyber Prot", RegistryKeyPermissionCheck.ReadWriteSubTree).SetValue("ExclusionApps", Encrypt(text2));
						CreateLog("App added to white list", "Application " + ListBox1.get_Text() + " has been added to white list", (EventLogEntryType)2, Repair: true, 1);
					}
					catch (Exception ex4)
					{
						ProjectData.SetProjectError(ex4, num2);
						Exception ex5 = ex4;
						MessageBox.Show("Error saving list: \r\n\r\n" + ex5.Message, "Cyber Prot", (MessageBoxButtons)0, (MessageBoxIcon)16);
						ProjectData.ClearProjectError();
						return;
					}
					CountExepts();
					CallService(1);
					return;
				}
				ListBox1.set_Text(app);
				MessageBox.Show(app + " is already excluded!", "Cyber Prot", (MessageBoxButtons)0, (MessageBoxIcon)16);
			}
			catch (Exception ex6)
			{
				ProjectData.SetProjectError(ex6, num2);
				Exception ex7 = ex6;
				MessageBox.Show("Error adding application: \r\n\r\n" + ex7.Message, "Cyber Prot", (MessageBoxButtons)0, (MessageBoxIcon)16);
				ProjectData.ClearProjectError();
			}
		}
	}

	public void DELwA(string app)
	{
		//IL_01b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f5: Unknown result type (might be due to invalid IL or missing references)
		ListBox1.get_Items().Clear();
		checked
		{
			try
			{
				string text = Decrypt(Conversions.ToString(Registry.LocalMachine.CreateSubKey("SOFTWARE\\Cyber Prot", RegistryKeyPermissionCheck.ReadWriteSubTree).GetValue("ExclusionApps", "")));
				List<string> list = new List<string>(text.Split(new char[1] { ';' }));
				if (list.Count > 0)
				{
					int num = list.Count - 1;
					for (int i = 0; i <= num; i++)
					{
						if (Operators.CompareString(list[i].Trim(), "", false) != 0)
						{
							ListBox1.get_Items().Add((object)list[i]);
						}
					}
				}
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
			}
			try
			{
				ListBox1.set_Text(app);
				ListBox1.get_Items().RemoveAt(ListBox1.get_SelectedIndex());
				BList();
				try
				{
					string text2 = "";
					IEnumerator enumerator = default(IEnumerator);
					try
					{
						enumerator = ListBox1.get_Items().GetEnumerator();
						while (enumerator.MoveNext())
						{
							string text3 = Conversions.ToString(enumerator.Current);
							if (Operators.CompareString(text3, this.m_w, false) != 0)
							{
								text2 = text2 + text3 + ";";
							}
						}
					}
					finally
					{
						if (enumerator is IDisposable)
						{
							(enumerator as IDisposable).Dispose();
						}
					}
					Registry.LocalMachine.CreateSubKey("SOFTWARE\\Cyber Prot", RegistryKeyPermissionCheck.ReadWriteSubTree).SetValue("ExclusionApps", Encrypt(text2));
					CreateLog("App deleted from white list", "Application " + ListBox1.get_Text() + " has been deleted from white list", (EventLogEntryType)2, Repair: true, 1);
				}
				catch (Exception ex)
				{
					ProjectData.SetProjectError(ex);
					Exception ex2 = ex;
					MessageBox.Show("Error saving list: \r\n\r\n" + ex2.Message, "Cyber Prot", (MessageBoxButtons)0, (MessageBoxIcon)16);
					ProjectData.ClearProjectError();
					return;
				}
				CountExepts();
				CallService(1);
			}
			catch (Exception ex3)
			{
				ProjectData.SetProjectError(ex3);
				Exception ex4 = ex3;
				MessageBox.Show("Error deleting application: \r\n\r\n" + ex4.Message, "Cyber Prot", (MessageBoxButtons)0, (MessageBoxIcon)16);
				ProjectData.ClearProjectError();
			}
		}
	}

	public string OrigCase(string filename)
	{
		return filename;
	}

	public bool IsInWhitePath(string path)
	{
		string text = Decrypt(Conversions.ToString(Registry.LocalMachine.CreateSubKey("SOFTWARE\\Cyber Prot", RegistryKeyPermissionCheck.ReadWriteSubTree).GetValue("ExclusionPaths", "")));
		List<string> list = new List<string>(text.Split(new char[1] { ';' }));
		checked
		{
			if (list.Count > 0)
			{
				int num = list.Count - 1;
				for (int i = 0; i <= num; i++)
				{
					if (Operators.CompareString(list[i].Trim(), "", false) != 0 && (list[i].Trim().ToLower().StartsWith(path.Trim().ToLower()) || Operators.CompareString(list[i].Trim().ToLower(), path.Trim().ToLower(), false) == 0 || path.Trim().ToLower().StartsWith(list[i].Trim().ToLower())))
					{
						return true;
					}
				}
			}
			return false;
		}
	}

	public bool IsInWhiteApp(string path)
	{
		string text = Decrypt(Conversions.ToString(Registry.LocalMachine.CreateSubKey("SOFTWARE\\Cyber Prot", RegistryKeyPermissionCheck.ReadWriteSubTree).GetValue("ExclusionApps", "")));
		List<string> list = new List<string>(text.Split(new char[1] { ';' }));
		checked
		{
			if (list.Count > 0)
			{
				int num = list.Count - 1;
				for (int i = 0; i <= num; i++)
				{
					if (Operators.CompareString(list[i].Trim(), "", false) != 0 && Operators.CompareString(list[i].Trim().ToLower(), path.Trim().ToLower(), false) == 0)
					{
						return true;
					}
				}
			}
			return false;
		}
	}

	private void a(object sender, DataGridViewCellMouseEventArgs e)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Invalid comparison between Unknown and I4
		if ((int)((MouseEventArgs)e).get_Button() == 2097152)
		{
			DataGridView1.set_CurrentCell(DataGridView1.get_Item(e.get_ColumnIndex(), e.get_RowIndex()));
			DataGridView1.get_CurrentCell().set_Selected(false);
			Application.DoEvents();
			DataGridView1.get_CurrentCell().set_Selected(true);
			if (!((ToolStripDropDown)ContextMenuStrip5).get_Visible())
			{
				((ToolStripDropDown)ContextMenuStrip5).Show();
			}
		}
	}

	private void b(object sender, MouseEventArgs e)
	{
		int try0000_dispatch = -1;
		int num3 = default(int);
		int num2 = default(int);
		int num = default(int);
		Point point = default(Point);
		int num5 = default(int);
		string text = default(string);
		Graphics val = default(Graphics);
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				switch (try0000_dispatch)
				{
				default:
					ProjectData.ClearProjectError();
					num3 = 1;
					goto IL_0007;
				case 421:
					{
						num2 = num;
						switch (num3)
						{
						case 1:
							break;
						default:
							goto end_IL_0000;
						}
						int num4 = num2 + 1;
						num2 = 0;
						switch (num4)
						{
						case 1:
							break;
						case 2:
							goto IL_0007;
						case 3:
							goto IL_0051;
						case 4:
							goto IL_005f;
						case 6:
							goto IL_0072;
						case 7:
							goto IL_0080;
						case 8:
							goto IL_0093;
						case 9:
							goto IL_00a3;
						case 10:
							goto IL_00ae;
						case 11:
							goto IL_00ca;
						case 12:
							goto IL_00da;
						case 13:
							goto IL_0111;
						case 15:
							goto IL_0129;
						case 14:
						case 16:
							goto end_IL_0000_2;
						default:
							goto end_IL_0000;
						case 5:
						case 17:
							goto end_IL_0000_3;
						}
						goto default;
					}
					IL_0129:
					num = 15;
					ToolTip1.SetToolTip((Control)(object)ListBox1, "");
					break;
					IL_0007:
					num = 2;
					if (Conversions.ToBoolean(NewLateBinding.LateGet(NewLateBinding.LateGet(ListBox1.get_Items().get_Item(0), (Type)null, "trim", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "startswith", new object[1] { "Right " }, (string[])null, (Type[])null, (bool[])null)))
					{
						goto IL_0051;
					}
					goto IL_0072;
					IL_0051:
					num = 3;
					ListBox1.set_SelectedIndex(-1);
					goto IL_005f;
					IL_005f:
					num = 4;
					ListBox1.set_SelectionMode((SelectionMode)0);
					goto end_IL_0000_3;
					IL_0072:
					num = 6;
					ListBox1.set_SelectionMode((SelectionMode)1);
					goto IL_0080;
					IL_0080:
					num = 7;
					point = ((Control)ListBox1).PointToClient(Control.get_MousePosition());
					goto IL_0093;
					IL_0093:
					num = 8;
					num5 = ListBox1.IndexFromPoint(point);
					goto IL_00a3;
					IL_00a3:
					num = 9;
					if (num5 <= -1)
					{
						goto end_IL_0000_3;
					}
					goto IL_00ae;
					IL_00ae:
					num = 10;
					text = ListBox1.get_Items().get_Item(num5).ToString();
					goto IL_00ca;
					IL_00ca:
					num = 11;
					val = ((Control)ListBox1).CreateGraphics();
					goto IL_00da;
					IL_00da:
					num = 12;
					if (val.MeasureString(text, ListBox1.get_Font()).Width > (float)((Control)ListBox1).get_ClientRectangle().Width)
					{
						goto IL_0111;
					}
					goto IL_0129;
					IL_0111:
					num = 13;
					ToolTip1.SetToolTip((Control)(object)ListBox1, text);
					break;
					end_IL_0000_2:
					break;
				}
				num = 16;
				val.Dispose();
				break;
				end_IL_0000:;
			}
			catch (object obj) when (obj is Exception && num3 != 0 && num2 == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0000_dispatch = 421;
				continue;
			}
			throw ProjectData.CreateProjectError(-2146828237);
			continue;
			end_IL_0000_3:
			break;
		}
		if (num2 != 0)
		{
			ProjectData.ClearProjectError();
		}
	}

	private void l(object sender, EventArgs e)
	{
		SwitchPanels(AdvancedPanelMain);
		((Control)Panel23).set_Visible(false);
		ExApps();
	}

	private void k(object sender, EventArgs e)
	{
		SwitchPanels(AdvancedPanelMain);
		((Control)Panel23).set_Visible(false);
		ExApps();
	}

	private void a(object sender, DrawItemEventArgs e)
	{
		//IL_0088: Unknown result type (might be due to invalid IL or missing references)
		//IL_008e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0090: Invalid comparison between Unknown and I4
		//IL_009f: Unknown result type (might be due to invalid IL or missing references)
		//IL_00af: Expected O, but got Unknown
		//IL_00b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00be: Expected O, but got Unknown
		//IL_0130: Unknown result type (might be due to invalid IL or missing references)
		//IL_0136: Unknown result type (might be due to invalid IL or missing references)
		//IL_0138: Invalid comparison between Unknown and I4
		int try0000_dispatch = -1;
		int num3 = default(int);
		int num2 = default(int);
		int num = default(int);
		object objectValue = default(object);
		Rectangle bounds = default(Rectangle);
		Rectangle rectangle = default(Rectangle);
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				checked
				{
					SolidBrush val;
					switch (try0000_dispatch)
					{
					default:
						ProjectData.ClearProjectError();
						num3 = 1;
						goto IL_0007;
					case 793:
						{
							num2 = num;
							switch (num3)
							{
							case 1:
								break;
							default:
								goto end_IL_0000;
							}
							int num4 = unchecked(num2 + 1);
							num2 = 0;
							switch (num4)
							{
							case 1:
								break;
							case 2:
								goto IL_0007;
							case 3:
								goto IL_0014;
							case 4:
								goto IL_0061;
							case 5:
								goto IL_006f;
							case 6:
								goto IL_007d;
							case 7:
								goto IL_0085;
							case 8:
								goto IL_0092;
							case 9:
								goto IL_00af;
							case 10:
								goto IL_0110;
							case 11:
								goto IL_0119;
							case 13:
								goto IL_012c;
							case 14:
								goto IL_013a;
							case 15:
								goto IL_018c;
							case 16:
								goto IL_01ab;
							case 17:
								goto IL_01b6;
							case 18:
								goto IL_01cf;
							case 19:
								goto IL_0212;
							case 20:
								goto IL_0265;
							case 21:
								goto IL_0291;
							case 22:
								goto end_IL_0000_2;
							default:
								goto end_IL_0000;
							case 12:
							case 23:
								goto end_IL_0000_3;
							}
							goto default;
						}
						IL_0291:
						num = 21;
						e.DrawFocusRectangle();
						break;
						IL_0007:
						num = 2;
						((Control)ListBox1).SuspendLayout();
						goto IL_0014;
						IL_0014:
						num = 3;
						if (Conversions.ToBoolean(NewLateBinding.LateGet(NewLateBinding.LateGet(ListBox1.get_Items().get_Item(0), (Type)null, "trim", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "startswith", new object[1] { "Right " }, (string[])null, (Type[])null, (bool[])null)))
						{
							goto IL_0061;
						}
						goto IL_012c;
						IL_0061:
						num = 4;
						ListBox1.set_SelectionMode((SelectionMode)0);
						goto IL_006f;
						IL_006f:
						num = 5;
						ListBox1.set_SelectedIndex(-1);
						goto IL_007d;
						IL_007d:
						num = 6;
						e.DrawBackground();
						goto IL_0085;
						IL_0085:
						num = 7;
						if ((e.get_State() & 1) == 1)
						{
							goto IL_0092;
						}
						goto IL_00af;
						IL_0092:
						num = 8;
						e.get_Graphics().FillRectangle((Brush)new SolidBrush(Color.White), e.get_Bounds());
						goto IL_00af;
						IL_00af:
						num = 9;
						val = new SolidBrush(Color.LightGray);
						try
						{
							e.get_Graphics().DrawString(((ListControl)ListBox1).GetItemText(RuntimeHelpers.GetObjectValue(ListBox1.get_Items().get_Item(e.get_Index()))), e.get_Font(), (Brush)(object)val, (RectangleF)e.get_Bounds());
						}
						finally
						{
							((IDisposable)val)?.Dispose();
						}
						goto IL_0110;
						IL_0110:
						num = 10;
						e.DrawFocusRectangle();
						goto IL_0119;
						IL_0119:
						num = 11;
						((Control)ListBox1).ResumeLayout();
						goto end_IL_0000_3;
						IL_012c:
						num = 13;
						if ((e.get_State() & 1) == 1)
						{
							goto IL_013a;
						}
						goto IL_018c;
						IL_013a:
						num = 14;
						e.get_Graphics().FillRectangle((Brush)(object)this.m_x, e.get_Bounds().Left, e.get_Bounds().Top, e.get_Bounds().Width, e.get_Bounds().Height + 5);
						goto IL_018c;
						IL_018c:
						num = 15;
						objectValue = RuntimeHelpers.GetObjectValue(ListBox1.get_Items().get_Item(e.get_Index()));
						goto IL_01ab;
						IL_01ab:
						num = 16;
						bounds = e.get_Bounds();
						goto IL_01b6;
						IL_01b6:
						num = 17;
						bounds.Width = e.get_Bounds().Height;
						goto IL_01cf;
						IL_01cf:
						num = 18;
						e.get_Graphics().DrawIcon(b(Conversions.ToString(objectValue)), new Rectangle(e.get_Bounds().Left, e.get_Bounds().Top + 7, 15, 15));
						goto IL_0212;
						IL_0212:
						num = 19;
						rectangle = new Rectangle(e.get_Bounds().X + 18, e.get_Bounds().Y + 5, e.get_Bounds().Width - bounds.Width, e.get_Bounds().Height);
						goto IL_0265;
						IL_0265:
						num = 20;
						e.get_Graphics().DrawString(objectValue.ToString(), e.get_Font(), (Brush)(object)this.m_y, (RectangleF)rectangle, StringFormat.get_GenericDefault());
						goto IL_0291;
						end_IL_0000_2:
						break;
					}
					num = 22;
					((Control)ListBox1).ResumeLayout();
					break;
				}
				end_IL_0000:;
			}
			catch (object obj) when (obj is Exception && num3 != 0 && num2 == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0000_dispatch = 793;
				continue;
			}
			throw ProjectData.CreateProjectError(-2146828237);
			continue;
			end_IL_0000_3:
			break;
		}
		if (num2 != 0)
		{
			ProjectData.ClearProjectError();
		}
	}

	private void a(object sender, MouseEventArgs e)
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Invalid comparison between Unknown and I4
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Expected O, but got Unknown
		int try0000_dispatch = -1;
		int num3 = default(int);
		int num2 = default(int);
		int num = default(int);
		int num5 = default(int);
		ListBox val = default(ListBox);
		Point point = default(Point);
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				switch (try0000_dispatch)
				{
				default:
					ProjectData.ClearProjectError();
					num3 = 1;
					goto IL_0007;
				case 157:
					{
						num2 = num;
						switch (num3)
						{
						case 1:
							break;
						default:
							goto end_IL_0000;
						}
						int num4 = num2 + 1;
						num2 = 0;
						switch (num4)
						{
						case 1:
							break;
						case 2:
							goto IL_0007;
						case 3:
							goto IL_0016;
						case 4:
							goto IL_001f;
						case 5:
							goto IL_0034;
						case 6:
							goto IL_0040;
						case 7:
							goto end_IL_0000_2;
						default:
							goto end_IL_0000;
						case 8:
							goto end_IL_0000_3;
						}
						goto default;
					}
					IL_0040:
					num = 6;
					if (num5 < 0)
					{
						goto end_IL_0000_3;
					}
					break;
					IL_0007:
					num = 2;
					if ((int)e.get_Button() != 2097152)
					{
						goto end_IL_0000_3;
					}
					goto IL_0016;
					IL_0016:
					num = 3;
					val = (ListBox)sender;
					goto IL_001f;
					IL_001f:
					num = 4;
					point = new Point(e.get_X(), e.get_Y());
					goto IL_0034;
					IL_0034:
					num = 5;
					num5 = val.IndexFromPoint(point);
					goto IL_0040;
					end_IL_0000_2:
					break;
				}
				num = 7;
				ListBox1.set_SelectedItem(RuntimeHelpers.GetObjectValue(ListBox1.get_Items().get_Item(num5)));
				break;
				end_IL_0000:;
			}
			catch (object obj) when (obj is Exception && num3 != 0 && num2 == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0000_dispatch = 157;
				continue;
			}
			throw ProjectData.CreateProjectError(-2146828237);
			continue;
			end_IL_0000_3:
			break;
		}
		if (num2 != 0)
		{
			ProjectData.ClearProjectError();
		}
	}

	private void j(object sender, EventArgs e)
	{
		SwitchPanels(AdvancedPanelMain);
		((Control)Panel23).set_Visible(false);
		ExApps();
	}

	private void i(object sender, EventArgs e)
	{
		SwitchPanels(AdvancedPanelMain);
		((Control)Panel23).set_Visible(false);
		ExPaths();
	}

	private void h(object sender, EventArgs e)
	{
		SwitchPanels(ActionsPanelMain);
	}

	private void g(object sender, EventArgs e)
	{
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Invalid comparison between Unknown and I4
		//IL_0051: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Invalid comparison between Unknown and I4
		if (Operators.ConditionalCompareObjectEqual(((Control)PictureBox4).get_Tag(), (object)"1", false))
		{
			if ((int)MessageBox.Show((IWin32Window)(object)this, "Are you sure want to remove all white listed applications?", "Cyber Prot", (MessageBoxButtons)4, (MessageBoxIcon)48) == 7)
			{
				return;
			}
			CreateLog("App white list cleared", "The application white list has been cleared", (EventLogEntryType)2, Repair: true, 1);
		}
		else
		{
			if ((int)MessageBox.Show((IWin32Window)(object)this, "Are you sure want to remove all white listed paths?", "Cyber Prot", (MessageBoxButtons)4, (MessageBoxIcon)48) == 7)
			{
				return;
			}
			CreateLog("Path white list cleared", "The path white list has been cleared", (EventLogEntryType)2, Repair: true, 1);
		}
		ListBox1.get_Items().Clear();
		BList();
		c();
	}

	private void f(object sender, EventArgs e)
	{
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Invalid comparison between Unknown and I4
		if ((int)MessageBox.Show((IWin32Window)(object)this, "Are you sure you want to permanently delete all quarantined items?", "Cyber Prot", (MessageBoxButtons)4, (MessageBoxIcon)48) == 7)
		{
			return;
		}
		try
		{
			while (DataGridView2.get_Rows().get_Count() > 0)
			{
				DataGridView2.get_Rows().get_Item(0).set_Selected(true);
				m(null, null);
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	private void e(object sender, EventArgs e)
	{
		int try0000_dispatch = -1;
		int num = default(int);
		int num2 = default(int);
		int num3 = default(int);
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				switch (try0000_dispatch)
				{
				default:
					num = 1;
					SwitchPanels(LogPanelMain);
					goto IL_000e;
				case 101:
					{
						num2 = num;
						switch (num3)
						{
						case 1:
							break;
						default:
							goto end_IL_0000;
						}
						int num4 = num2 + 1;
						num2 = 0;
						switch (num4)
						{
						case 1:
							break;
						case 2:
							goto IL_000e;
						case 3:
							goto end_IL_0000_2;
						default:
							goto end_IL_0000;
						case 4:
							goto end_IL_0000_3;
						}
						goto default;
					}
					IL_000e:
					ProjectData.ClearProjectError();
					num3 = 1;
					break;
					end_IL_0000_2:
					break;
				}
				num = 3;
				a(Conversions.ToString(DataGridView2.get_Item(1, Conversions.ToInteger(((Control)ContextMenuStrip4).get_Tag())).get_Value()));
				break;
				end_IL_0000:;
			}
			catch (object obj) when (obj is Exception && num3 != 0 && num2 == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0000_dispatch = 101;
				continue;
			}
			throw ProjectData.CreateProjectError(-2146828237);
			continue;
			end_IL_0000_3:
			break;
		}
		if (num2 != 0)
		{
			ProjectData.ClearProjectError();
		}
	}

	private void d(object sender, EventArgs e)
	{
		TextBox1.set_Text("");
		a("");
	}

	private void c(object sender, EventArgs e)
	{
	}

	private void a(object sender, KeyPressEventArgs e)
	{
		if (Operators.CompareString(Conversions.ToString(e.get_KeyChar()), "\r", false) == 0)
		{
			a(TextBox1.get_Text());
		}
	}

	private void b(object sender, EventArgs e)
	{
		a(TextBox1.get_Text());
	}

	private void a(object sender, EventArgs e)
	{
		((Control)Label42).set_Left(((Control)Label36).get_Left());
	}

	[DebuggerNonUserCode]
	protected override void Dispose(bool disposing)
	{
		try
		{
			if (disposing && this.m_z != null)
			{
				this.m_z.Dispose();
			}
		}
		finally
		{
			((Form)this).Dispose(disposing);
		}
	}

	[DebuggerStepThrough]
	private void b()
	{
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Expected O, but got Unknown
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Expected O, but got Unknown
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Expected O, but got Unknown
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Expected O, but got Unknown
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Expected O, but got Unknown
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Expected O, but got Unknown
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Expected O, but got Unknown
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Expected O, but got Unknown
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Expected O, but got Unknown
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0065: Expected O, but got Unknown
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		//IL_006c: Expected O, but got Unknown
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0073: Expected O, but got Unknown
		//IL_0073: Unknown result type (might be due to invalid IL or missing references)
		//IL_007a: Expected O, but got Unknown
		//IL_007b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0085: Expected O, but got Unknown
		//IL_0086: Unknown result type (might be due to invalid IL or missing references)
		//IL_0090: Expected O, but got Unknown
		//IL_0091: Unknown result type (might be due to invalid IL or missing references)
		//IL_009b: Expected O, but got Unknown
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a6: Expected O, but got Unknown
		//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b1: Expected O, but got Unknown
		//IL_00b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bc: Expected O, but got Unknown
		//IL_00bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c7: Expected O, but got Unknown
		//IL_00c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d2: Expected O, but got Unknown
		//IL_00d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dd: Expected O, but got Unknown
		//IL_00de: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e8: Expected O, but got Unknown
		//IL_00e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f3: Expected O, but got Unknown
		//IL_00f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fe: Expected O, but got Unknown
		//IL_00ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0109: Expected O, but got Unknown
		//IL_010a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0114: Expected O, but got Unknown
		//IL_0115: Unknown result type (might be due to invalid IL or missing references)
		//IL_011f: Expected O, but got Unknown
		//IL_0120: Unknown result type (might be due to invalid IL or missing references)
		//IL_012a: Expected O, but got Unknown
		//IL_012b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0135: Expected O, but got Unknown
		//IL_0136: Unknown result type (might be due to invalid IL or missing references)
		//IL_0140: Expected O, but got Unknown
		//IL_0141: Unknown result type (might be due to invalid IL or missing references)
		//IL_014b: Expected O, but got Unknown
		//IL_014c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0156: Expected O, but got Unknown
		//IL_0157: Unknown result type (might be due to invalid IL or missing references)
		//IL_0161: Expected O, but got Unknown
		//IL_0162: Unknown result type (might be due to invalid IL or missing references)
		//IL_016c: Expected O, but got Unknown
		//IL_0173: Unknown result type (might be due to invalid IL or missing references)
		//IL_017d: Expected O, but got Unknown
		//IL_0184: Unknown result type (might be due to invalid IL or missing references)
		//IL_018e: Expected O, but got Unknown
		//IL_018f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0199: Expected O, but got Unknown
		//IL_019a: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a4: Expected O, but got Unknown
		//IL_01a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01af: Expected O, but got Unknown
		//IL_01b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ba: Expected O, but got Unknown
		//IL_01bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c5: Expected O, but got Unknown
		//IL_01c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d0: Expected O, but got Unknown
		//IL_01d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01db: Expected O, but got Unknown
		//IL_01dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e6: Expected O, but got Unknown
		//IL_01e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f1: Expected O, but got Unknown
		//IL_01f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fc: Expected O, but got Unknown
		//IL_01fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0207: Expected O, but got Unknown
		//IL_0208: Unknown result type (might be due to invalid IL or missing references)
		//IL_0212: Expected O, but got Unknown
		//IL_0213: Unknown result type (might be due to invalid IL or missing references)
		//IL_021d: Expected O, but got Unknown
		//IL_021e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0228: Expected O, but got Unknown
		//IL_0229: Unknown result type (might be due to invalid IL or missing references)
		//IL_0233: Expected O, but got Unknown
		//IL_0234: Unknown result type (might be due to invalid IL or missing references)
		//IL_023e: Expected O, but got Unknown
		//IL_023f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0249: Expected O, but got Unknown
		//IL_024a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0254: Expected O, but got Unknown
		//IL_0255: Unknown result type (might be due to invalid IL or missing references)
		//IL_025f: Expected O, but got Unknown
		//IL_0260: Unknown result type (might be due to invalid IL or missing references)
		//IL_026a: Expected O, but got Unknown
		//IL_026b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0275: Expected O, but got Unknown
		//IL_0276: Unknown result type (might be due to invalid IL or missing references)
		//IL_0280: Expected O, but got Unknown
		//IL_0281: Unknown result type (might be due to invalid IL or missing references)
		//IL_028b: Expected O, but got Unknown
		//IL_028c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0296: Expected O, but got Unknown
		//IL_0297: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a1: Expected O, but got Unknown
		//IL_02a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ac: Expected O, but got Unknown
		//IL_02ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b7: Expected O, but got Unknown
		//IL_02b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c2: Expected O, but got Unknown
		//IL_02c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_02cd: Expected O, but got Unknown
		//IL_02ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d8: Expected O, but got Unknown
		//IL_02d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e3: Expected O, but got Unknown
		//IL_02e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ee: Expected O, but got Unknown
		//IL_02ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f9: Expected O, but got Unknown
		//IL_02fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_0304: Expected O, but got Unknown
		//IL_0305: Unknown result type (might be due to invalid IL or missing references)
		//IL_030f: Expected O, but got Unknown
		//IL_0310: Unknown result type (might be due to invalid IL or missing references)
		//IL_031a: Expected O, but got Unknown
		//IL_031b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0325: Expected O, but got Unknown
		//IL_0326: Unknown result type (might be due to invalid IL or missing references)
		//IL_0330: Expected O, but got Unknown
		//IL_0331: Unknown result type (might be due to invalid IL or missing references)
		//IL_033b: Expected O, but got Unknown
		//IL_033c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0346: Expected O, but got Unknown
		//IL_0347: Unknown result type (might be due to invalid IL or missing references)
		//IL_0351: Expected O, but got Unknown
		//IL_0352: Unknown result type (might be due to invalid IL or missing references)
		//IL_035c: Expected O, but got Unknown
		//IL_035d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0367: Expected O, but got Unknown
		//IL_0368: Unknown result type (might be due to invalid IL or missing references)
		//IL_0372: Expected O, but got Unknown
		//IL_0373: Unknown result type (might be due to invalid IL or missing references)
		//IL_037d: Expected O, but got Unknown
		//IL_037e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0388: Expected O, but got Unknown
		//IL_0389: Unknown result type (might be due to invalid IL or missing references)
		//IL_0393: Expected O, but got Unknown
		//IL_0394: Unknown result type (might be due to invalid IL or missing references)
		//IL_039e: Expected O, but got Unknown
		//IL_039f: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a9: Expected O, but got Unknown
		//IL_03aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b4: Expected O, but got Unknown
		//IL_03b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_03bf: Expected O, but got Unknown
		//IL_03c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ca: Expected O, but got Unknown
		//IL_03cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d5: Expected O, but got Unknown
		//IL_03d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e0: Expected O, but got Unknown
		//IL_03e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_03eb: Expected O, but got Unknown
		//IL_03f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_03fc: Expected O, but got Unknown
		//IL_0403: Unknown result type (might be due to invalid IL or missing references)
		//IL_040d: Expected O, but got Unknown
		//IL_040e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0418: Expected O, but got Unknown
		//IL_0419: Unknown result type (might be due to invalid IL or missing references)
		//IL_0423: Expected O, but got Unknown
		//IL_0424: Unknown result type (might be due to invalid IL or missing references)
		//IL_042e: Expected O, but got Unknown
		//IL_042f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0439: Expected O, but got Unknown
		//IL_043a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0444: Expected O, but got Unknown
		//IL_0445: Unknown result type (might be due to invalid IL or missing references)
		//IL_044f: Expected O, but got Unknown
		//IL_0456: Unknown result type (might be due to invalid IL or missing references)
		//IL_0460: Expected O, but got Unknown
		//IL_0461: Unknown result type (might be due to invalid IL or missing references)
		//IL_046b: Expected O, but got Unknown
		//IL_046c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0476: Expected O, but got Unknown
		//IL_0477: Unknown result type (might be due to invalid IL or missing references)
		//IL_0481: Expected O, but got Unknown
		//IL_0482: Unknown result type (might be due to invalid IL or missing references)
		//IL_048c: Expected O, but got Unknown
		//IL_048d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0497: Expected O, but got Unknown
		//IL_0498: Unknown result type (might be due to invalid IL or missing references)
		//IL_04a2: Expected O, but got Unknown
		//IL_04a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ad: Expected O, but got Unknown
		//IL_04b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_04be: Expected O, but got Unknown
		//IL_04c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_04cf: Expected O, but got Unknown
		//IL_04d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_04e0: Expected O, but got Unknown
		//IL_04e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_04f1: Expected O, but got Unknown
		//IL_04f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0502: Expected O, but got Unknown
		//IL_0503: Unknown result type (might be due to invalid IL or missing references)
		//IL_050d: Expected O, but got Unknown
		//IL_050e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0518: Expected O, but got Unknown
		//IL_0519: Unknown result type (might be due to invalid IL or missing references)
		//IL_0523: Expected O, but got Unknown
		//IL_0524: Unknown result type (might be due to invalid IL or missing references)
		//IL_052e: Expected O, but got Unknown
		//IL_052f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0539: Expected O, but got Unknown
		//IL_053a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0544: Expected O, but got Unknown
		//IL_0545: Unknown result type (might be due to invalid IL or missing references)
		//IL_054f: Expected O, but got Unknown
		//IL_0550: Unknown result type (might be due to invalid IL or missing references)
		//IL_055a: Expected O, but got Unknown
		//IL_055b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0565: Expected O, but got Unknown
		//IL_0566: Unknown result type (might be due to invalid IL or missing references)
		//IL_0570: Expected O, but got Unknown
		//IL_0571: Unknown result type (might be due to invalid IL or missing references)
		//IL_057b: Expected O, but got Unknown
		//IL_0582: Unknown result type (might be due to invalid IL or missing references)
		//IL_058c: Expected O, but got Unknown
		//IL_058d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0597: Expected O, but got Unknown
		//IL_0598: Unknown result type (might be due to invalid IL or missing references)
		//IL_05a2: Expected O, but got Unknown
		//IL_05a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_05ad: Expected O, but got Unknown
		//IL_05ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_05b8: Expected O, but got Unknown
		//IL_05bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_05c9: Expected O, but got Unknown
		//IL_05ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_05d4: Expected O, but got Unknown
		//IL_05db: Unknown result type (might be due to invalid IL or missing references)
		//IL_05e5: Expected O, but got Unknown
		//IL_05e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_05f0: Expected O, but got Unknown
		//IL_05f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0601: Expected O, but got Unknown
		//IL_0602: Unknown result type (might be due to invalid IL or missing references)
		//IL_060c: Expected O, but got Unknown
		//IL_060d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0617: Expected O, but got Unknown
		//IL_0618: Unknown result type (might be due to invalid IL or missing references)
		//IL_0622: Expected O, but got Unknown
		//IL_0623: Unknown result type (might be due to invalid IL or missing references)
		//IL_062d: Expected O, but got Unknown
		//IL_062e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0638: Expected O, but got Unknown
		//IL_0639: Unknown result type (might be due to invalid IL or missing references)
		//IL_0643: Expected O, but got Unknown
		//IL_0644: Unknown result type (might be due to invalid IL or missing references)
		//IL_064e: Expected O, but got Unknown
		//IL_064f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0659: Expected O, but got Unknown
		//IL_065a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0664: Expected O, but got Unknown
		//IL_0665: Unknown result type (might be due to invalid IL or missing references)
		//IL_066f: Expected O, but got Unknown
		//IL_0670: Unknown result type (might be due to invalid IL or missing references)
		//IL_067a: Expected O, but got Unknown
		//IL_067b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0685: Expected O, but got Unknown
		//IL_068c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0696: Expected O, but got Unknown
		//IL_069d: Unknown result type (might be due to invalid IL or missing references)
		//IL_06a7: Expected O, but got Unknown
		//IL_06a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_06b2: Expected O, but got Unknown
		//IL_06b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_06bd: Expected O, but got Unknown
		//IL_06be: Unknown result type (might be due to invalid IL or missing references)
		//IL_06c8: Expected O, but got Unknown
		//IL_06c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_06d3: Expected O, but got Unknown
		//IL_06d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_06de: Expected O, but got Unknown
		//IL_0a7d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a87: Expected O, but got Unknown
		//IL_0aa0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b3f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bac: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bb6: Expected O, but got Unknown
		//IL_0be4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c4f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c59: Expected O, but got Unknown
		//IL_0c72: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cf1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cfb: Expected O, but got Unknown
		//IL_0d19: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d99: Unknown result type (might be due to invalid IL or missing references)
		//IL_0da3: Expected O, but got Unknown
		//IL_0dc1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e41: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e4b: Expected O, but got Unknown
		//IL_0e69: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ee8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ef2: Expected O, but got Unknown
		//IL_0f0f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fc0: Unknown result type (might be due to invalid IL or missing references)
		//IL_102c: Unknown result type (might be due to invalid IL or missing references)
		//IL_1036: Expected O, but got Unknown
		//IL_1064: Unknown result type (might be due to invalid IL or missing references)
		//IL_10cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_10d9: Expected O, but got Unknown
		//IL_10f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_11a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_120f: Unknown result type (might be due to invalid IL or missing references)
		//IL_1219: Expected O, but got Unknown
		//IL_1247: Unknown result type (might be due to invalid IL or missing references)
		//IL_12b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_12bc: Expected O, but got Unknown
		//IL_12d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_139c: Unknown result type (might be due to invalid IL or missing references)
		//IL_1408: Unknown result type (might be due to invalid IL or missing references)
		//IL_1412: Expected O, but got Unknown
		//IL_143f: Unknown result type (might be due to invalid IL or missing references)
		//IL_1499: Unknown result type (might be due to invalid IL or missing references)
		//IL_14a3: Expected O, but got Unknown
		//IL_14bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_153d: Unknown result type (might be due to invalid IL or missing references)
		//IL_1547: Expected O, but got Unknown
		//IL_1575: Unknown result type (might be due to invalid IL or missing references)
		//IL_161e: Unknown result type (might be due to invalid IL or missing references)
		//IL_168a: Unknown result type (might be due to invalid IL or missing references)
		//IL_1694: Expected O, but got Unknown
		//IL_16c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_172d: Unknown result type (might be due to invalid IL or missing references)
		//IL_1737: Expected O, but got Unknown
		//IL_1750: Unknown result type (might be due to invalid IL or missing references)
		//IL_17bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_17c9: Expected O, but got Unknown
		//IL_17e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_184b: Unknown result type (might be due to invalid IL or missing references)
		//IL_1855: Expected O, but got Unknown
		//IL_18ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_18f8: Expected O, but got Unknown
		//IL_193d: Unknown result type (might be due to invalid IL or missing references)
		//IL_1947: Expected O, but got Unknown
		//IL_1b86: Unknown result type (might be due to invalid IL or missing references)
		//IL_1b90: Expected O, but got Unknown
		//IL_1bac: Unknown result type (might be due to invalid IL or missing references)
		//IL_1c2a: Unknown result type (might be due to invalid IL or missing references)
		//IL_1c34: Expected O, but got Unknown
		//IL_1c51: Unknown result type (might be due to invalid IL or missing references)
		//IL_1d66: Unknown result type (might be due to invalid IL or missing references)
		//IL_1d70: Expected O, but got Unknown
		//IL_1d8c: Unknown result type (might be due to invalid IL or missing references)
		//IL_1e0a: Unknown result type (might be due to invalid IL or missing references)
		//IL_1e14: Expected O, but got Unknown
		//IL_1e31: Unknown result type (might be due to invalid IL or missing references)
		//IL_1f42: Unknown result type (might be due to invalid IL or missing references)
		//IL_1f4c: Expected O, but got Unknown
		//IL_1f68: Unknown result type (might be due to invalid IL or missing references)
		//IL_1fe5: Unknown result type (might be due to invalid IL or missing references)
		//IL_1fef: Expected O, but got Unknown
		//IL_200c: Unknown result type (might be due to invalid IL or missing references)
		//IL_20c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_212c: Unknown result type (might be due to invalid IL or missing references)
		//IL_2136: Expected O, but got Unknown
		//IL_2157: Unknown result type (might be due to invalid IL or missing references)
		//IL_2161: Expected O, but got Unknown
		//IL_21e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_21f0: Expected O, but got Unknown
		//IL_220a: Unknown result type (might be due to invalid IL or missing references)
		//IL_230e: Unknown result type (might be due to invalid IL or missing references)
		//IL_2318: Expected O, but got Unknown
		//IL_2339: Unknown result type (might be due to invalid IL or missing references)
		//IL_2343: Expected O, but got Unknown
		//IL_23d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_23e0: Expected O, but got Unknown
		//IL_2401: Unknown result type (might be due to invalid IL or missing references)
		//IL_240b: Expected O, but got Unknown
		//IL_2579: Unknown result type (might be due to invalid IL or missing references)
		//IL_2583: Expected O, but got Unknown
		//IL_2594: Unknown result type (might be due to invalid IL or missing references)
		//IL_259e: Expected O, but got Unknown
		//IL_25af: Unknown result type (might be due to invalid IL or missing references)
		//IL_25b9: Expected O, but got Unknown
		//IL_25d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_2658: Unknown result type (might be due to invalid IL or missing references)
		//IL_2662: Expected O, but got Unknown
		//IL_2680: Unknown result type (might be due to invalid IL or missing references)
		//IL_26de: Unknown result type (might be due to invalid IL or missing references)
		//IL_26e8: Expected O, but got Unknown
		//IL_2702: Unknown result type (might be due to invalid IL or missing references)
		//IL_2773: Unknown result type (might be due to invalid IL or missing references)
		//IL_277d: Expected O, but got Unknown
		//IL_279e: Unknown result type (might be due to invalid IL or missing references)
		//IL_280a: Unknown result type (might be due to invalid IL or missing references)
		//IL_2814: Expected O, but got Unknown
		//IL_2832: Unknown result type (might be due to invalid IL or missing references)
		//IL_289e: Unknown result type (might be due to invalid IL or missing references)
		//IL_28a8: Expected O, but got Unknown
		//IL_28c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_2a29: Unknown result type (might be due to invalid IL or missing references)
		//IL_2a33: Expected O, but got Unknown
		//IL_2a51: Unknown result type (might be due to invalid IL or missing references)
		//IL_2ac5: Unknown result type (might be due to invalid IL or missing references)
		//IL_2acf: Expected O, but got Unknown
		//IL_2b34: Unknown result type (might be due to invalid IL or missing references)
		//IL_2b3e: Expected O, but got Unknown
		//IL_2b58: Unknown result type (might be due to invalid IL or missing references)
		//IL_2bc9: Unknown result type (might be due to invalid IL or missing references)
		//IL_2bd3: Expected O, but got Unknown
		//IL_2bf4: Unknown result type (might be due to invalid IL or missing references)
		//IL_2c5d: Unknown result type (might be due to invalid IL or missing references)
		//IL_2c67: Expected O, but got Unknown
		//IL_2c88: Unknown result type (might be due to invalid IL or missing references)
		//IL_2cf1: Unknown result type (might be due to invalid IL or missing references)
		//IL_2cfb: Expected O, but got Unknown
		//IL_2d19: Unknown result type (might be due to invalid IL or missing references)
		//IL_2d86: Unknown result type (might be due to invalid IL or missing references)
		//IL_2d90: Expected O, but got Unknown
		//IL_2dae: Unknown result type (might be due to invalid IL or missing references)
		//IL_2ec2: Unknown result type (might be due to invalid IL or missing references)
		//IL_2ecc: Expected O, but got Unknown
		//IL_2eea: Unknown result type (might be due to invalid IL or missing references)
		//IL_2f56: Unknown result type (might be due to invalid IL or missing references)
		//IL_2f60: Expected O, but got Unknown
		//IL_2f79: Unknown result type (might be due to invalid IL or missing references)
		//IL_3094: Unknown result type (might be due to invalid IL or missing references)
		//IL_309e: Expected O, but got Unknown
		//IL_30bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_3127: Unknown result type (might be due to invalid IL or missing references)
		//IL_3131: Expected O, but got Unknown
		//IL_314a: Unknown result type (might be due to invalid IL or missing references)
		//IL_3262: Unknown result type (might be due to invalid IL or missing references)
		//IL_326c: Expected O, but got Unknown
		//IL_328a: Unknown result type (might be due to invalid IL or missing references)
		//IL_32f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_3302: Expected O, but got Unknown
		//IL_331b: Unknown result type (might be due to invalid IL or missing references)
		//IL_3539: Unknown result type (might be due to invalid IL or missing references)
		//IL_3543: Expected O, but got Unknown
		//IL_3718: Unknown result type (might be due to invalid IL or missing references)
		//IL_3722: Expected O, but got Unknown
		//IL_38f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_3901: Expected O, but got Unknown
		//IL_39c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_39d3: Expected O, but got Unknown
		//IL_3b16: Unknown result type (might be due to invalid IL or missing references)
		//IL_3b20: Expected O, but got Unknown
		//IL_3c2a: Unknown result type (might be due to invalid IL or missing references)
		//IL_3c34: Expected O, but got Unknown
		//IL_3cd7: Unknown result type (might be due to invalid IL or missing references)
		//IL_3ce1: Expected O, but got Unknown
		//IL_3d7c: Unknown result type (might be due to invalid IL or missing references)
		//IL_3d86: Expected O, but got Unknown
		//IL_3e40: Unknown result type (might be due to invalid IL or missing references)
		//IL_3e4a: Expected O, but got Unknown
		//IL_3eb5: Unknown result type (might be due to invalid IL or missing references)
		//IL_3ebf: Expected O, but got Unknown
		//IL_3f1c: Unknown result type (might be due to invalid IL or missing references)
		//IL_3f26: Expected O, but got Unknown
		//IL_410e: Unknown result type (might be due to invalid IL or missing references)
		//IL_4118: Expected O, but got Unknown
		//IL_4197: Unknown result type (might be due to invalid IL or missing references)
		//IL_41a1: Expected O, but got Unknown
		//IL_4211: Unknown result type (might be due to invalid IL or missing references)
		//IL_421b: Expected O, but got Unknown
		//IL_450b: Unknown result type (might be due to invalid IL or missing references)
		//IL_4515: Expected O, but got Unknown
		//IL_4726: Unknown result type (might be due to invalid IL or missing references)
		//IL_4730: Expected O, but got Unknown
		//IL_4846: Unknown result type (might be due to invalid IL or missing references)
		//IL_4850: Expected O, but got Unknown
		//IL_4883: Unknown result type (might be due to invalid IL or missing references)
		//IL_496b: Unknown result type (might be due to invalid IL or missing references)
		//IL_4975: Expected O, but got Unknown
		//IL_49ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_49c4: Expected O, but got Unknown
		//IL_4ab7: Unknown result type (might be due to invalid IL or missing references)
		//IL_4ac1: Expected O, but got Unknown
		//IL_4b47: Unknown result type (might be due to invalid IL or missing references)
		//IL_4b51: Expected O, but got Unknown
		//IL_4e55: Unknown result type (might be due to invalid IL or missing references)
		//IL_4e5f: Expected O, but got Unknown
		//IL_4e7c: Unknown result type (might be due to invalid IL or missing references)
		//IL_4f74: Unknown result type (might be due to invalid IL or missing references)
		//IL_4f7e: Expected O, but got Unknown
		//IL_503b: Unknown result type (might be due to invalid IL or missing references)
		//IL_5045: Expected O, but got Unknown
		//IL_50f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_50ff: Expected O, but got Unknown
		//IL_523c: Unknown result type (might be due to invalid IL or missing references)
		//IL_5246: Expected O, but got Unknown
		//IL_52b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_52ba: Expected O, but got Unknown
		//IL_5324: Unknown result type (might be due to invalid IL or missing references)
		//IL_532e: Expected O, but got Unknown
		//IL_5399: Unknown result type (might be due to invalid IL or missing references)
		//IL_53a3: Expected O, but got Unknown
		//IL_5434: Unknown result type (might be due to invalid IL or missing references)
		//IL_543e: Expected O, but got Unknown
		//IL_5525: Unknown result type (might be due to invalid IL or missing references)
		//IL_552f: Expected O, but got Unknown
		//IL_55be: Unknown result type (might be due to invalid IL or missing references)
		//IL_55c8: Expected O, but got Unknown
		//IL_55e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_5674: Unknown result type (might be due to invalid IL or missing references)
		//IL_567e: Expected O, but got Unknown
		//IL_569b: Unknown result type (might be due to invalid IL or missing references)
		//IL_570e: Unknown result type (might be due to invalid IL or missing references)
		//IL_5718: Expected O, but got Unknown
		//IL_5736: Unknown result type (might be due to invalid IL or missing references)
		//IL_590d: Unknown result type (might be due to invalid IL or missing references)
		//IL_5917: Expected O, but got Unknown
		//IL_5919: Unknown result type (might be due to invalid IL or missing references)
		this.m_z = new Container();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(Form1));
		DataGridViewCellStyle val = new DataGridViewCellStyle();
		DataGridViewCellStyle val2 = new DataGridViewCellStyle();
		DataGridViewCellStyle val3 = new DataGridViewCellStyle();
		DataGridViewCellStyle val4 = new DataGridViewCellStyle();
		DataGridViewCellStyle val5 = new DataGridViewCellStyle();
		DataGridViewCellStyle val6 = new DataGridViewCellStyle();
		DataGridViewCellStyle val7 = new DataGridViewCellStyle();
		DataGridViewCellStyle val8 = new DataGridViewCellStyle();
		DataGridViewCellStyle val9 = new DataGridViewCellStyle();
		DataGridViewCellStyle val10 = new DataGridViewCellStyle();
		DataGridViewCellStyle val11 = new DataGridViewCellStyle();
		DataGridViewCellStyle val12 = new DataGridViewCellStyle();
		DataGridViewCellStyle val13 = new DataGridViewCellStyle();
		DataGridViewCellStyle val14 = new DataGridViewCellStyle();
		Panel1 = new Panel();
		Panel36 = new Panel();
		Label64 = new Label();
		PictureBox91 = new PictureBox();
		PictureBox63 = new PictureBox();
		PictureBox62 = new PictureBox();
		PictureBox61 = new PictureBox();
		PictureBox60 = new PictureBox();
		Panel33 = new Panel();
		Label50 = new Label();
		PictureBox77 = new PictureBox();
		Panel12 = new Panel();
		Label5 = new Label();
		PictureBox3 = new PictureBox();
		Panel3 = new Panel();
		Label4 = new Label();
		PictureBox32 = new PictureBox();
		Label2 = new Label();
		Panel2 = new Panel();
		Label1 = new Label();
		PictureBox2 = new PictureBox();
		PictureBox1 = new PictureBox();
		NotifyIcon1 = new NotifyIcon(this.m_z);
		ContextMenuStrip1 = new ContextMenuStrip(this.m_z);
		OpenToolStripMenuItem = new ToolStripMenuItem();
		ExitToolStripMenuItem = new ToolStripMenuItem();
		StatusPanelMain = new Panel();
		Panel6 = new Panel();
		Label26 = new Label();
		Label7 = new Label();
		Panel8 = new Panel();
		Label23 = new Label();
		Label9 = new Label();
		Panel13 = new Panel();
		Label12 = new Label();
		Label10 = new Label();
		Panel20 = new Panel();
		Label37 = new Label();
		MaskedTextBox1 = new MaskedTextBox();
		Panel24 = new Panel();
		Label36 = new Label();
		Label42 = new Label();
		Panel34 = new Panel();
		PictureBox65 = new PictureBox();
		Label35 = new Label();
		PictureBox54 = new PictureBox();
		LicenseStatus = new Label();
		Label55 = new Label();
		TrialStatus = new Label();
		Panel28 = new Panel();
		PictureBox68 = new PictureBox();
		PictureBox66 = new PictureBox();
		PictureBox67 = new PictureBox();
		Label25 = new Label();
		Label56 = new Label();
		Label38 = new Label();
		Label8 = new Label();
		Panel27 = new Panel();
		Label52 = new Label();
		PictureBox64 = new PictureBox();
		Panel26 = new Panel();
		Label51 = new Label();
		PictureBox50 = new PictureBox();
		Panel25 = new Panel();
		Label44 = new Label();
		PictureBox53 = new PictureBox();
		GeneralSettingsPanelMain = new Panel();
		Panel22 = new Panel();
		Label16 = new Label();
		Label6 = new Label();
		PictureBox57 = new PictureBox();
		Panel7 = new Panel();
		Label14 = new Label();
		Label22 = new Label();
		PictureBox27 = new PictureBox();
		Panel5 = new Panel();
		Label13 = new Label();
		Label11 = new Label();
		PictureBox9 = new PictureBox();
		ImageList1 = new ImageList(this.m_z);
		ToolTip1 = new ToolTip(this.m_z);
		ActionsPanelMain = new Panel();
		Label15 = new Label();
		DataGridView2 = new DataGridView();
		DataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
		DataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
		DataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
		ContextMenuStrip4 = new ContextMenuStrip(this.m_z);
		ToolStripMenuItem5 = new ToolStripMenuItem();
		ToolStripSeparator3 = new ToolStripSeparator();
		ToolStripMenuItem2 = new ToolStripMenuItem();
		ToolStripMenuItem3 = new ToolStripMenuItem();
		ToolStripSeparator1 = new ToolStripSeparator();
		ToolStripMenuItem4 = new ToolStripMenuItem();
		WipeAllFilesToolStripMenuItem = new ToolStripMenuItem();
		ImageList2 = new ImageList(this.m_z);
		Timer1 = new Timer(this.m_z);
		ImageList3 = new ImageList(this.m_z);
		Timer2 = new Timer(this.m_z);
		Timer3 = new Timer(this.m_z);
		AdvancedPanelMain = new Panel();
		Panel4 = new Panel();
		Label18 = new Label();
		PictureBox4 = new PictureBox();
		Label3 = new Label();
		Panel35 = new Panel();
		Label17 = new Label();
		PictureBox78 = new PictureBox();
		Label43 = new Label();
		Panel23 = new Panel();
		ListBox1 = new ListBox();
		ContextMenuStrip3 = new ContextMenuStrip(this.m_z);
		ToolStripMenuItem1 = new ToolStripMenuItem();
		RemoveFolderToolStripMenuItem = new ToolStripMenuItem();
		ToolStripSeparator2 = new ToolStripSeparator();
		ClearToolStripMenuItem = new ToolStripMenuItem();
		ContextMenuStrip2 = new ContextMenuStrip(this.m_z);
		SelectAllToolStripMenuItem = new ToolStripMenuItem();
		Timer4 = new Timer(this.m_z);
		FolderBrowserDialog1 = new FolderBrowserDialog();
		ImageList4 = new ImageList(this.m_z);
		LogPanelMain = new Panel();
		Button2 = new Button();
		Button1 = new Button();
		TextBox1 = new TextBox();
		Label19 = new Label();
		TextBox8 = new TextBox();
		DataGridView1 = new DataGridView();
		Column1 = new DataGridViewImageColumn();
		Level = new DataGridViewTextBoxColumn();
		Column3 = new DataGridViewTextBoxColumn();
		Column2 = new DataGridViewTextBoxColumn();
		Column4 = new DataGridViewTextBoxColumn();
		ContextMenuStrip5 = new ContextMenuStrip(this.m_z);
		ImageList5 = new ImageList(this.m_z);
		PictureBox8 = new PictureBox();
		PictureBox7 = new PictureBox();
		PictureBox6 = new PictureBox();
		PictureBox5 = new PictureBox();
		SmartScanPanelMain = new Panel();
		((Control)Panel1).SuspendLayout();
		((Control)Panel36).SuspendLayout();
		((ISupportInitialize)PictureBox91).BeginInit();
		((ISupportInitialize)PictureBox63).BeginInit();
		((ISupportInitialize)PictureBox62).BeginInit();
		((ISupportInitialize)PictureBox61).BeginInit();
		((ISupportInitialize)PictureBox60).BeginInit();
		((Control)Panel33).SuspendLayout();
		((ISupportInitialize)PictureBox77).BeginInit();
		((Control)Panel12).SuspendLayout();
		((ISupportInitialize)PictureBox3).BeginInit();
		((Control)Panel3).SuspendLayout();
		((ISupportInitialize)PictureBox32).BeginInit();
		((Control)Panel2).SuspendLayout();
		((ISupportInitialize)PictureBox2).BeginInit();
		((ISupportInitialize)PictureBox1).BeginInit();
		((Control)ContextMenuStrip1).SuspendLayout();
		((Control)StatusPanelMain).SuspendLayout();
		((Control)Panel6).SuspendLayout();
		((Control)Panel8).SuspendLayout();
		((Control)Panel13).SuspendLayout();
		((Control)Panel20).SuspendLayout();
		((Control)Panel24).SuspendLayout();
		((Control)Panel34).SuspendLayout();
		((ISupportInitialize)PictureBox65).BeginInit();
		((ISupportInitialize)PictureBox54).BeginInit();
		((Control)Panel28).SuspendLayout();
		((ISupportInitialize)PictureBox68).BeginInit();
		((ISupportInitialize)PictureBox66).BeginInit();
		((ISupportInitialize)PictureBox67).BeginInit();
		((Control)Panel27).SuspendLayout();
		((ISupportInitialize)PictureBox64).BeginInit();
		((Control)Panel26).SuspendLayout();
		((ISupportInitialize)PictureBox50).BeginInit();
		((Control)Panel25).SuspendLayout();
		((ISupportInitialize)PictureBox53).BeginInit();
		((Control)GeneralSettingsPanelMain).SuspendLayout();
		((Control)Panel22).SuspendLayout();
		((ISupportInitialize)PictureBox57).BeginInit();
		((Control)Panel7).SuspendLayout();
		((ISupportInitialize)PictureBox27).BeginInit();
		((Control)Panel5).SuspendLayout();
		((ISupportInitialize)PictureBox9).BeginInit();
		((Control)ActionsPanelMain).SuspendLayout();
		((ISupportInitialize)DataGridView2).BeginInit();
		((Control)ContextMenuStrip4).SuspendLayout();
		((Control)AdvancedPanelMain).SuspendLayout();
		((Control)Panel4).SuspendLayout();
		((ISupportInitialize)PictureBox4).BeginInit();
		((Control)Panel35).SuspendLayout();
		((ISupportInitialize)PictureBox78).BeginInit();
		((Control)Panel23).SuspendLayout();
		((Control)ContextMenuStrip3).SuspendLayout();
		((Control)ContextMenuStrip2).SuspendLayout();
		((Control)LogPanelMain).SuspendLayout();
		((ISupportInitialize)DataGridView1).BeginInit();
		((ISupportInitialize)PictureBox8).BeginInit();
		((ISupportInitialize)PictureBox7).BeginInit();
		((ISupportInitialize)PictureBox6).BeginInit();
		((ISupportInitialize)PictureBox5).BeginInit();
		((Control)this).SuspendLayout();
		((Control)Panel1).set_BackColor(Color.FromArgb(46, 62, 78));
		((Control)Panel1).get_Controls().Add((Control)(object)Panel36);
		((Control)Panel1).get_Controls().Add((Control)(object)PictureBox63);
		((Control)Panel1).get_Controls().Add((Control)(object)PictureBox62);
		((Control)Panel1).get_Controls().Add((Control)(object)PictureBox61);
		((Control)Panel1).get_Controls().Add((Control)(object)PictureBox60);
		((Control)Panel1).get_Controls().Add((Control)(object)Panel33);
		((Control)Panel1).get_Controls().Add((Control)(object)Panel12);
		((Control)Panel1).get_Controls().Add((Control)(object)Panel3);
		((Control)Panel1).get_Controls().Add((Control)(object)Panel2);
		((Control)Panel1).get_Controls().Add((Control)(object)PictureBox1);
		((Control)Panel1).set_Font(new Font("Microsoft Sans Serif", 10.2f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)Panel1).set_Location(new Point(0, 0));
		((Control)Panel1).set_Margin(new Padding(2));
		((Control)Panel1).set_Name("Panel1");
		((Control)Panel1).set_Size(new Size(150, 466));
		((Control)Panel1).set_TabIndex(0);
		((Control)Panel36).set_BackColor(Color.FromArgb(48, 58, 73));
		((Control)Panel36).get_Controls().Add((Control)(object)Label64);
		((Control)Panel36).get_Controls().Add((Control)(object)PictureBox91);
		((Control)Panel36).set_Location(new Point(5, 327));
		((Control)Panel36).set_Margin(new Padding(2));
		((Control)Panel36).set_Name("Panel36");
		((Control)Panel36).set_Size(new Size(136, 42));
		((Control)Panel36).set_TabIndex(11);
		Label64.set_AutoSize(true);
		((Control)Label64).set_Cursor(Cursors.get_Hand());
		((Control)Label64).set_Font(new Font("MS Reference Sans Serif", 10.2f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)Label64).set_ForeColor(Color.DarkGray);
		((Control)Label64).set_Location(new Point(34, 13));
		((Control)Label64).set_Margin(new Padding(2, 0, 2, 0));
		((Control)Label64).set_Name("Label64");
		((Control)Label64).set_Size(new Size(87, 18));
		((Control)Label64).set_TabIndex(4);
		Label64.set_Text("Events Log");
		((Control)PictureBox91).set_Cursor(Cursors.get_Hand());
		PictureBox91.set_Image((Image)componentResourceManager.GetObject("PictureBox91.Image"));
		((Control)PictureBox91).set_Location(new Point(8, 8));
		((Control)PictureBox91).set_Margin(new Padding(2));
		((Control)PictureBox91).set_Name("PictureBox91");
		((Control)PictureBox91).set_Size(new Size(23, 25));
		PictureBox91.set_SizeMode((PictureBoxSizeMode)4);
		PictureBox91.set_TabIndex(0);
		PictureBox91.set_TabStop(false);
		((Control)PictureBox63).set_BackgroundImageLayout((ImageLayout)0);
		((Control)PictureBox63).set_Cursor(Cursors.get_Hand());
		PictureBox63.set_Image((Image)componentResourceManager.GetObject("PictureBox63.Image"));
		((Control)PictureBox63).set_Location(new Point(116, 432));
		((Control)PictureBox63).set_Margin(new Padding(2));
		((Control)PictureBox63).set_Name("PictureBox63");
		((Control)PictureBox63).set_Size(new Size(25, 27));
		PictureBox63.set_SizeMode((PictureBoxSizeMode)4);
		PictureBox63.set_TabIndex(10);
		PictureBox63.set_TabStop(false);
		((Control)PictureBox62).set_BackgroundImageLayout((ImageLayout)0);
		((Control)PictureBox62).set_Cursor(Cursors.get_Hand());
		PictureBox62.set_Image((Image)componentResourceManager.GetObject("PictureBox62.Image"));
		((Control)PictureBox62).set_Location(new Point(80, 432));
		((Control)PictureBox62).set_Margin(new Padding(2));
		((Control)PictureBox62).set_Name("PictureBox62");
		((Control)PictureBox62).set_Size(new Size(25, 27));
		PictureBox62.set_SizeMode((PictureBoxSizeMode)4);
		PictureBox62.set_TabIndex(9);
		PictureBox62.set_TabStop(false);
		((Control)PictureBox61).set_BackgroundImageLayout((ImageLayout)0);
		((Control)PictureBox61).set_Cursor(Cursors.get_Hand());
		PictureBox61.set_Image((Image)componentResourceManager.GetObject("PictureBox61.Image"));
		((Control)PictureBox61).set_Location(new Point(42, 432));
		((Control)PictureBox61).set_Margin(new Padding(2));
		((Control)PictureBox61).set_Name("PictureBox61");
		((Control)PictureBox61).set_Size(new Size(25, 27));
		PictureBox61.set_SizeMode((PictureBoxSizeMode)4);
		PictureBox61.set_TabIndex(8);
		PictureBox61.set_TabStop(false);
		((Control)PictureBox60).set_BackgroundImageLayout((ImageLayout)0);
		((Control)PictureBox60).set_Cursor(Cursors.get_Hand());
		PictureBox60.set_Image((Image)componentResourceManager.GetObject("PictureBox60.Image"));
		((Control)PictureBox60).set_Location(new Point(5, 432));
		((Control)PictureBox60).set_Margin(new Padding(2));
		((Control)PictureBox60).set_Name("PictureBox60");
		((Control)PictureBox60).set_Size(new Size(25, 27));
		PictureBox60.set_SizeMode((PictureBoxSizeMode)4);
		PictureBox60.set_TabIndex(7);
		PictureBox60.set_TabStop(false);
		((Control)Panel33).set_BackColor(Color.FromArgb(48, 58, 73));
		((Control)Panel33).get_Controls().Add((Control)(object)Label50);
		((Control)Panel33).get_Controls().Add((Control)(object)PictureBox77);
		((Control)Panel33).set_Location(new Point(5, 280));
		((Control)Panel33).set_Margin(new Padding(2));
		((Control)Panel33).set_Name("Panel33");
		((Control)Panel33).set_Size(new Size(136, 42));
		((Control)Panel33).set_TabIndex(6);
		Label50.set_AutoSize(true);
		((Control)Label50).set_Cursor(Cursors.get_Hand());
		((Control)Label50).set_Font(new Font("MS Reference Sans Serif", 10.2f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)Label50).set_ForeColor(Color.DarkGray);
		((Control)Label50).set_Location(new Point(34, 13));
		((Control)Label50).set_Margin(new Padding(2, 0, 2, 0));
		((Control)Label50).set_Name("Label50");
		((Control)Label50).set_Size(new Size(79, 18));
		((Control)Label50).set_TabIndex(4);
		Label50.set_Text("White List");
		((Control)PictureBox77).set_Cursor(Cursors.get_Hand());
		PictureBox77.set_Image((Image)componentResourceManager.GetObject("PictureBox77.Image"));
		((Control)PictureBox77).set_Location(new Point(8, 8));
		((Control)PictureBox77).set_Margin(new Padding(2));
		((Control)PictureBox77).set_Name("PictureBox77");
		((Control)PictureBox77).set_Size(new Size(23, 25));
		PictureBox77.set_SizeMode((PictureBoxSizeMode)4);
		PictureBox77.set_TabIndex(0);
		PictureBox77.set_TabStop(false);
		((Control)Panel12).set_BackColor(Color.FromArgb(48, 58, 73));
		((Control)Panel12).get_Controls().Add((Control)(object)Label5);
		((Control)Panel12).get_Controls().Add((Control)(object)PictureBox3);
		((Control)Panel12).set_Location(new Point(5, 233));
		((Control)Panel12).set_Margin(new Padding(2));
		((Control)Panel12).set_Name("Panel12");
		((Control)Panel12).set_Size(new Size(136, 42));
		((Control)Panel12).set_TabIndex(5);
		Label5.set_AutoSize(true);
		((Control)Label5).set_Cursor(Cursors.get_Hand());
		((Control)Label5).set_Font(new Font("MS Reference Sans Serif", 10.2f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)Label5).set_ForeColor(Color.DarkGray);
		((Control)Label5).set_Location(new Point(34, 13));
		((Control)Label5).set_Margin(new Padding(2, 0, 2, 0));
		((Control)Label5).set_Name("Label5");
		((Control)Label5).set_Size(new Size(85, 18));
		((Control)Label5).set_TabIndex(4);
		Label5.set_Text("Quarantine");
		((Control)PictureBox3).set_Cursor(Cursors.get_Hand());
		PictureBox3.set_Image((Image)componentResourceManager.GetObject("PictureBox3.Image"));
		((Control)PictureBox3).set_Location(new Point(8, 8));
		((Control)PictureBox3).set_Margin(new Padding(2));
		((Control)PictureBox3).set_Name("PictureBox3");
		((Control)PictureBox3).set_Size(new Size(23, 25));
		PictureBox3.set_SizeMode((PictureBoxSizeMode)4);
		PictureBox3.set_TabIndex(0);
		PictureBox3.set_TabStop(false);
		((Control)Panel3).set_BackColor(Color.FromArgb(48, 58, 73));
		((Control)Panel3).get_Controls().Add((Control)(object)Label4);
		((Control)Panel3).get_Controls().Add((Control)(object)PictureBox32);
		((Control)Panel3).get_Controls().Add((Control)(object)Label2);
		((Control)Panel3).set_Location(new Point(5, 186));
		((Control)Panel3).set_Margin(new Padding(2));
		((Control)Panel3).set_Name("Panel3");
		((Control)Panel3).set_Size(new Size(136, 42));
		((Control)Panel3).set_TabIndex(2);
		Label4.set_AutoSize(true);
		((Control)Label4).set_Cursor(Cursors.get_Hand());
		((Control)Label4).set_Font(new Font("MS Reference Sans Serif", 10.2f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)Label4).set_ForeColor(Color.White);
		((Control)Label4).set_Location(new Point(4, 96));
		((Control)Label4).set_Margin(new Padding(2, 0, 2, 0));
		((Control)Label4).set_Name("Label4");
		((Control)Label4).set_Size(new Size(0, 18));
		((Control)Label4).set_TabIndex(3);
		((Control)PictureBox32).set_Cursor(Cursors.get_Hand());
		PictureBox32.set_Image((Image)componentResourceManager.GetObject("PictureBox32.Image"));
		((Control)PictureBox32).set_Location(new Point(8, 8));
		((Control)PictureBox32).set_Margin(new Padding(2));
		((Control)PictureBox32).set_Name("PictureBox32");
		((Control)PictureBox32).set_Size(new Size(23, 25));
		PictureBox32.set_SizeMode((PictureBoxSizeMode)4);
		PictureBox32.set_TabIndex(0);
		PictureBox32.set_TabStop(false);
		Label2.set_AutoSize(true);
		((Control)Label2).set_Cursor(Cursors.get_Hand());
		((Control)Label2).set_Font(new Font("MS Reference Sans Serif", 10.2f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)Label2).set_ForeColor(Color.DarkGray);
		((Control)Label2).set_Location(new Point(34, 13));
		((Control)Label2).set_Margin(new Padding(2, 0, 2, 0));
		((Control)Label2).set_Name("Label2");
		((Control)Label2).set_Size(new Size(67, 18));
		((Control)Label2).set_TabIndex(1);
		Label2.set_Text("Settings");
		((Control)Panel2).set_BackColor(Color.FromArgb(48, 58, 73));
		((Control)Panel2).get_Controls().Add((Control)(object)Label1);
		((Control)Panel2).get_Controls().Add((Control)(object)PictureBox2);
		((Control)Panel2).set_Location(new Point(5, 139));
		((Control)Panel2).set_Margin(new Padding(2));
		((Control)Panel2).set_Name("Panel2");
		((Control)Panel2).set_Size(new Size(136, 42));
		((Control)Panel2).set_TabIndex(1);
		Label1.set_AutoSize(true);
		((Control)Label1).set_Cursor(Cursors.get_Hand());
		((Control)Label1).set_Font(new Font("MS Reference Sans Serif", 10.2f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)Label1).set_ForeColor(Color.DarkGray);
		((Control)Label1).set_Location(new Point(34, 13));
		((Control)Label1).set_Margin(new Padding(2, 0, 2, 0));
		((Control)Label1).set_Name("Label1");
		((Control)Label1).set_Size(new Size(85, 18));
		((Control)Label1).set_TabIndex(1);
		Label1.set_Text("Dashboard");
		((Control)PictureBox2).set_Cursor(Cursors.get_Hand());
		PictureBox2.set_Image((Image)componentResourceManager.GetObject("PictureBox2.Image"));
		((Control)PictureBox2).set_Location(new Point(8, 8));
		((Control)PictureBox2).set_Margin(new Padding(2));
		((Control)PictureBox2).set_Name("PictureBox2");
		((Control)PictureBox2).set_Size(new Size(23, 25));
		PictureBox2.set_SizeMode((PictureBoxSizeMode)4);
		PictureBox2.set_TabIndex(0);
		PictureBox2.set_TabStop(false);
		((Control)PictureBox1).set_BackgroundImageLayout((ImageLayout)0);
		PictureBox1.set_Image((Image)componentResourceManager.GetObject("PictureBox1.Image"));
		((Control)PictureBox1).set_Location(new Point(0, 0));
		((Control)PictureBox1).set_Margin(new Padding(2));
		((Control)PictureBox1).set_Name("PictureBox1");
		((Control)PictureBox1).set_Size(new Size(150, 134));
		PictureBox1.set_SizeMode((PictureBoxSizeMode)4);
		PictureBox1.set_TabIndex(0);
		PictureBox1.set_TabStop(false);
		NotifyIcon1.set_Icon((Icon)componentResourceManager.GetObject("NotifyIcon1.Icon"));
		NotifyIcon1.set_Text("Cyber Prot");
		((ToolStrip)ContextMenuStrip1).set_ImageScalingSize(new Size(20, 20));
		((ToolStrip)ContextMenuStrip1).get_Items().AddRange((ToolStripItem[])(object)new ToolStripItem[2]
		{
			(ToolStripItem)OpenToolStripMenuItem,
			(ToolStripItem)ExitToolStripMenuItem
		});
		((Control)ContextMenuStrip1).set_Name("ContextMenuStrip1");
		((ToolStripDropDownMenu)ContextMenuStrip1).set_ShowImageMargin(false);
		((ToolStrip)ContextMenuStrip1).set_ShowItemToolTips(false);
		((Control)ContextMenuStrip1).set_Size(new Size(79, 48));
		((ToolStripItem)OpenToolStripMenuItem).set_Image((Image)componentResourceManager.GetObject("OpenToolStripMenuItem.Image"));
		((ToolStripItem)OpenToolStripMenuItem).set_Name("OpenToolStripMenuItem");
		((ToolStripItem)OpenToolStripMenuItem).set_Size(new Size(78, 22));
		((ToolStripItem)OpenToolStripMenuItem).set_Text("Open");
		((ToolStripItem)ExitToolStripMenuItem).set_Image((Image)componentResourceManager.GetObject("ExitToolStripMenuItem.Image"));
		((ToolStripItem)ExitToolStripMenuItem).set_Name("ExitToolStripMenuItem");
		((ToolStripItem)ExitToolStripMenuItem).set_Size(new Size(78, 22));
		((ToolStripItem)ExitToolStripMenuItem).set_Text("Exit");
		((Control)StatusPanelMain).set_BackColor(Color.Transparent);
		((Control)StatusPanelMain).set_BackgroundImageLayout((ImageLayout)0);
		((Control)StatusPanelMain).get_Controls().Add((Control)(object)Panel6);
		((Control)StatusPanelMain).get_Controls().Add((Control)(object)Panel8);
		((Control)StatusPanelMain).get_Controls().Add((Control)(object)Panel13);
		((Control)StatusPanelMain).get_Controls().Add((Control)(object)Panel20);
		((Control)StatusPanelMain).get_Controls().Add((Control)(object)Panel24);
		((Control)StatusPanelMain).get_Controls().Add((Control)(object)Panel34);
		((Control)StatusPanelMain).get_Controls().Add((Control)(object)Panel28);
		((Control)StatusPanelMain).get_Controls().Add((Control)(object)Panel27);
		((Control)StatusPanelMain).get_Controls().Add((Control)(object)Panel26);
		((Control)StatusPanelMain).get_Controls().Add((Control)(object)Panel25);
		((Control)StatusPanelMain).set_Location(new Point(153, 32));
		((Control)StatusPanelMain).set_Name("StatusPanelMain");
		((Control)StatusPanelMain).set_Size(new Size(593, 510));
		((Control)StatusPanelMain).set_TabIndex(5);
		((Control)StatusPanelMain).set_Visible(false);
		((Control)Panel6).set_BackColor(Color.White);
		((Control)Panel6).get_Controls().Add((Control)(object)Label26);
		((Control)Panel6).get_Controls().Add((Control)(object)Label7);
		((Control)Panel6).set_Cursor(Cursors.get_Hand());
		((Control)Panel6).set_Location(new Point(401, 103));
		((Control)Panel6).set_Name("Panel6");
		((Control)Panel6).set_Size(new Size(185, 84));
		((Control)Panel6).set_TabIndex(24);
		((Control)Label26).set_Cursor(Cursors.get_Hand());
		((Control)Label26).set_Font(new Font("MS Reference Sans Serif", 27.75f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)Label26).set_Location(new Point(6, 4));
		((Control)Label26).set_Margin(new Padding(2, 0, 2, 0));
		((Control)Label26).set_Name("Label26");
		((Control)Label26).set_Size(new Size(173, 55));
		((Control)Label26).set_TabIndex(10);
		Label26.set_Text("0");
		Label26.set_TextAlign((ContentAlignment)32);
		((Control)Label7).set_Cursor(Cursors.get_Hand());
		((Control)Label7).set_Font(new Font("MS Reference Sans Serif", 10.2f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)Label7).set_Location(new Point(2, 59));
		((Control)Label7).set_Margin(new Padding(2, 0, 2, 0));
		((Control)Label7).set_Name("Label7");
		((Control)Label7).set_Size(new Size(181, 18));
		((Control)Label7).set_TabIndex(9);
		Label7.set_Text("White listed paths");
		Label7.set_TextAlign((ContentAlignment)32);
		((Control)Panel8).set_BackColor(Color.White);
		((Control)Panel8).get_Controls().Add((Control)(object)Label23);
		((Control)Panel8).get_Controls().Add((Control)(object)Label9);
		((Control)Panel8).set_Cursor(Cursors.get_Hand());
		((Control)Panel8).set_Location(new Point(205, 103));
		((Control)Panel8).set_Name("Panel8");
		((Control)Panel8).set_Size(new Size(185, 84));
		((Control)Panel8).set_TabIndex(23);
		((Control)Label23).set_Cursor(Cursors.get_Hand());
		((Control)Label23).set_Font(new Font("MS Reference Sans Serif", 27.75f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)Label23).set_Location(new Point(6, 4));
		((Control)Label23).set_Margin(new Padding(2, 0, 2, 0));
		((Control)Label23).set_Name("Label23");
		((Control)Label23).set_Size(new Size(173, 55));
		((Control)Label23).set_TabIndex(9);
		Label23.set_Text("0");
		Label23.set_TextAlign((ContentAlignment)32);
		((Control)Label9).set_Cursor(Cursors.get_Hand());
		((Control)Label9).set_Font(new Font("MS Reference Sans Serif", 10.2f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)Label9).set_Location(new Point(5, 59));
		((Control)Label9).set_Margin(new Padding(2, 0, 2, 0));
		((Control)Label9).set_Name("Label9");
		((Control)Label9).set_Size(new Size(178, 18));
		((Control)Label9).set_TabIndex(8);
		Label9.set_Text("White listed applications");
		Label9.set_TextAlign((ContentAlignment)32);
		((Control)Panel13).set_BackColor(Color.White);
		((Control)Panel13).get_Controls().Add((Control)(object)Label12);
		((Control)Panel13).get_Controls().Add((Control)(object)Label10);
		((Control)Panel13).set_Cursor(Cursors.get_Hand());
		((Control)Panel13).set_Location(new Point(10, 103));
		((Control)Panel13).set_Name("Panel13");
		((Control)Panel13).set_Size(new Size(185, 84));
		((Control)Panel13).set_TabIndex(22);
		((Control)Label12).set_Cursor(Cursors.get_Hand());
		((Control)Label12).set_Font(new Font("MS Reference Sans Serif", 27.75f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)Label12).set_Location(new Point(6, 4));
		((Control)Label12).set_Margin(new Padding(2, 0, 2, 0));
		((Control)Label12).set_Name("Label12");
		((Control)Label12).set_Size(new Size(173, 55));
		((Control)Label12).set_TabIndex(8);
		Label12.set_Text("0");
		Label12.set_TextAlign((ContentAlignment)32);
		((Control)Label10).set_Cursor(Cursors.get_Hand());
		((Control)Label10).set_Font(new Font("MS Reference Sans Serif", 10.2f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)Label10).set_Location(new Point(8, 59));
		((Control)Label10).set_Margin(new Padding(2, 0, 2, 0));
		((Control)Label10).set_Name("Label10");
		((Control)Label10).set_Size(new Size(173, 18));
		((Control)Label10).set_TabIndex(7);
		Label10.set_Text("Quarantined files");
		Label10.set_TextAlign((ContentAlignment)32);
		((Control)Panel20).set_BackColor(Color.White);
		((Control)Panel20).get_Controls().Add((Control)(object)Label37);
		((Control)Panel20).get_Controls().Add((Control)(object)MaskedTextBox1);
		((Control)Panel20).set_Location(new Point(10, 394));
		((Control)Panel20).set_Margin(new Padding(2));
		((Control)Panel20).set_Name("Panel20");
		((Control)Panel20).set_Size(new Size(574, 37));
		((Control)Panel20).set_TabIndex(4);
		((Control)Panel20).set_Visible(false);
		((Control)Label37).set_Cursor(Cursors.get_Hand());
		((Control)Label37).set_Font(new Font("MS Reference Sans Serif", 11.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)Label37).set_ForeColor(Color.Black);
		Label37.set_Image((Image)componentResourceManager.GetObject("Label37.Image"));
		Label37.set_ImageAlign((ContentAlignment)16);
		((Control)Label37).set_Location(new Point(444, 12));
		((Control)Label37).set_Name("Label37");
		((Control)Label37).set_Size(new Size(87, 19));
		((Control)Label37).set_TabIndex(19);
		Label37.set_Text("Activate license");
		Label37.set_TextAlign((ContentAlignment)64);
		((Control)MaskedTextBox1).set_Font(new Font("Consolas", 14.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)MaskedTextBox1).set_Location(new Point(29, 2));
		((Control)MaskedTextBox1).set_Margin(new Padding(2));
		MaskedTextBox1.set_Mask("aaaa-aaaa-aaaa-aaaa-aaaa-aaaa-aaaa");
		((Control)MaskedTextBox1).set_Name("MaskedTextBox1");
		((Control)MaskedTextBox1).set_Size(new Size(392, 30));
		((Control)MaskedTextBox1).set_TabIndex(17);
		MaskedTextBox1.set_TextAlign((HorizontalAlignment)2);
		((Control)Panel24).set_BackColor(Color.White);
		((Control)Panel24).get_Controls().Add((Control)(object)Label36);
		((Control)Panel24).get_Controls().Add((Control)(object)Label42);
		((Control)Panel24).set_Location(new Point(10, 358));
		((Control)Panel24).set_Name("Panel24");
		((Control)Panel24).set_Size(new Size(576, 50));
		((Control)Panel24).set_TabIndex(21);
		((Control)Label36).set_Cursor(Cursors.get_Hand());
		((Control)Label36).set_Font(new Font("MS Reference Sans Serif", 10.2f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)Label36).set_ForeColor(Color.Black);
		Label36.set_Image((Image)componentResourceManager.GetObject("Label36.Image"));
		Label36.set_ImageAlign((ContentAlignment)16);
		((Control)Label36).set_Location(new Point(4, 15));
		((Control)Label36).set_Name("Label36");
		((Control)Label36).set_Size(new Size(156, 18));
		((Control)Label36).set_TabIndex(0);
		Label36.set_Text("Activate license");
		Label36.set_TextAlign((ContentAlignment)64);
		((Control)Label42).set_Cursor(Cursors.get_Hand());
		((Control)Label42).set_Font(new Font("MS Reference Sans Serif", 10.2f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)Label42).set_ForeColor(Color.Black);
		Label42.set_Image((Image)componentResourceManager.GetObject("Label42.Image"));
		Label42.set_ImageAlign((ContentAlignment)16);
		((Control)Label42).set_Location(new Point(376, 14));
		((Control)Label42).set_Name("Label42");
		((Control)Label42).set_Size(new Size(142, 18));
		((Control)Label42).set_TabIndex(12);
		Label42.set_Text("Remove license");
		Label42.set_TextAlign((ContentAlignment)64);
		((Control)Label42).set_Visible(false);
		((Control)Panel34).set_BackColor(Color.White);
		((Control)Panel34).get_Controls().Add((Control)(object)PictureBox65);
		((Control)Panel34).get_Controls().Add((Control)(object)Label35);
		((Control)Panel34).get_Controls().Add((Control)(object)PictureBox54);
		((Control)Panel34).get_Controls().Add((Control)(object)LicenseStatus);
		((Control)Panel34).get_Controls().Add((Control)(object)Label55);
		((Control)Panel34).get_Controls().Add((Control)(object)TrialStatus);
		((Control)Panel34).set_Location(new Point(10, 11));
		((Control)Panel34).set_Name("Panel34");
		((Control)Panel34).set_Size(new Size(576, 82));
		((Control)Panel34).set_TabIndex(20);
		PictureBox65.set_ErrorImage((Image)componentResourceManager.GetObject("PictureBox65.ErrorImage"));
		PictureBox65.set_Image((Image)componentResourceManager.GetObject("PictureBox65.Image"));
		PictureBox65.set_InitialImage((Image)componentResourceManager.GetObject("PictureBox65.InitialImage"));
		((Control)PictureBox65).set_Location(new Point(267, 16));
		((Control)PictureBox65).set_Margin(new Padding(2));
		((Control)PictureBox65).set_Name("PictureBox65");
		((Control)PictureBox65).set_Size(new Size(55, 47));
		PictureBox65.set_SizeMode((PictureBoxSizeMode)1);
		PictureBox65.set_TabIndex(7);
		PictureBox65.set_TabStop(false);
		Label35.set_AutoSize(true);
		((Control)Label35).set_BackColor(Color.Transparent);
		((Control)Label35).set_Font(new Font("MS Reference Sans Serif", 11.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)Label35).set_Location(new Point(63, 43));
		((Control)Label35).set_Margin(new Padding(2, 0, 2, 0));
		((Control)Label35).set_Name("Label35");
		((Control)Label35).set_Size(new Size(181, 19));
		((Control)Label35).set_TabIndex(8);
		Label35.set_Text("Checking for updates...");
		PictureBox54.set_Image((Image)componentResourceManager.GetObject("PictureBox54.Image"));
		((Control)PictureBox54).set_Location(new Point(7, 16));
		((Control)PictureBox54).set_Margin(new Padding(2));
		((Control)PictureBox54).set_Name("PictureBox54");
		((Control)PictureBox54).set_Size(new Size(55, 47));
		PictureBox54.set_SizeMode((PictureBoxSizeMode)1);
		PictureBox54.set_TabIndex(2);
		PictureBox54.set_TabStop(false);
		LicenseStatus.set_AutoSize(true);
		((Control)LicenseStatus).set_Font(new Font("MS Reference Sans Serif", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)LicenseStatus).set_Location(new Point(323, 16));
		((Control)LicenseStatus).set_Margin(new Padding(2, 0, 2, 0));
		((Control)LicenseStatus).set_Name("LicenseStatus");
		((Control)LicenseStatus).set_Size(new Size(128, 20));
		((Control)LicenseStatus).set_TabIndex(5);
		LicenseStatus.set_Text("Product status");
		Label55.set_AutoSize(true);
		((Control)Label55).set_Font(new Font("MS Reference Sans Serif", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)Label55).set_Location(new Point(63, 16));
		((Control)Label55).set_Margin(new Padding(2, 0, 2, 0));
		((Control)Label55).set_Name("Label55");
		((Control)Label55).set_Size(new Size(168, 20));
		((Control)Label55).set_TabIndex(7);
		Label55.set_Text("Protection status...");
		TrialStatus.set_AutoSize(true);
		((Control)TrialStatus).set_Font(new Font("MS Reference Sans Serif", 11.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)TrialStatus).set_Location(new Point(323, 43));
		((Control)TrialStatus).set_Margin(new Padding(2, 0, 2, 0));
		((Control)TrialStatus).set_Name("TrialStatus");
		((Control)TrialStatus).set_Size(new Size(102, 19));
		((Control)TrialStatus).set_TabIndex(6);
		TrialStatus.set_Text("not available");
		((Control)Panel28).set_BackColor(Color.White);
		((Control)Panel28).get_Controls().Add((Control)(object)PictureBox68);
		((Control)Panel28).get_Controls().Add((Control)(object)PictureBox66);
		((Control)Panel28).get_Controls().Add((Control)(object)PictureBox67);
		((Control)Panel28).get_Controls().Add((Control)(object)Label25);
		((Control)Panel28).get_Controls().Add((Control)(object)Label56);
		((Control)Panel28).get_Controls().Add((Control)(object)Label38);
		((Control)Panel28).get_Controls().Add((Control)(object)Label8);
		((Control)Panel28).set_Location(new Point(10, 199));
		((Control)Panel28).set_Name("Panel28");
		((Control)Panel28).set_Size(new Size(576, 67));
		((Control)Panel28).set_TabIndex(19);
		((Control)PictureBox68).set_Cursor(Cursors.get_Arrow());
		PictureBox68.set_Image((Image)componentResourceManager.GetObject("PictureBox68.Image"));
		((Control)PictureBox68).set_Location(new Point(379, 16));
		((Control)PictureBox68).set_Margin(new Padding(2));
		((Control)PictureBox68).set_Name("PictureBox68");
		((Control)PictureBox68).set_Size(new Size(38, 38));
		PictureBox68.set_SizeMode((PictureBoxSizeMode)4);
		PictureBox68.set_TabIndex(22);
		PictureBox68.set_TabStop(false);
		((Control)PictureBox66).set_Cursor(Cursors.get_Hand());
		PictureBox66.set_Image((Image)componentResourceManager.GetObject("PictureBox66.Image"));
		((Control)PictureBox66).set_Location(new Point(427, 36));
		((Control)PictureBox66).set_Name("PictureBox66");
		((Control)PictureBox66).set_Size(new Size(31, 16));
		PictureBox66.set_TabIndex(21);
		PictureBox66.set_TabStop(false);
		PictureBox67.set_Image((Image)componentResourceManager.GetObject("PictureBox67.Image"));
		((Control)PictureBox67).set_Location(new Point(4, 15));
		((Control)PictureBox67).set_Margin(new Padding(2));
		((Control)PictureBox67).set_Name("PictureBox67");
		((Control)PictureBox67).set_Size(new Size(35, 39));
		PictureBox67.set_SizeMode((PictureBoxSizeMode)1);
		PictureBox67.set_TabIndex(2);
		PictureBox67.set_TabStop(false);
		Label25.set_AutoSize(true);
		((Control)Label25).set_Font(new Font("MS Reference Sans Serif", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)Label25).set_Location(new Point(423, 12));
		((Control)Label25).set_Margin(new Padding(2, 0, 2, 0));
		((Control)Label25).set_Name("Label25");
		((Control)Label25).set_Size(new Size(122, 20));
		((Control)Label25).set_TabIndex(8);
		Label25.set_Text("Engine status");
		Label56.set_AutoSize(true);
		((Control)Label56).set_Font(new Font("MS Reference Sans Serif", 11.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)Label56).set_Location(new Point(463, 33));
		((Control)Label56).set_Margin(new Padding(2, 0, 2, 0));
		((Control)Label56).set_Name("Label56");
		((Control)Label56).set_Size(new Size(14, 19));
		((Control)Label56).set_TabIndex(8);
		Label56.set_Text(" ");
		Label38.set_AutoSize(true);
		((Control)Label38).set_Font(new Font("MS Reference Sans Serif", 10.8f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)Label38).set_Location(new Point(44, 13));
		((Control)Label38).set_Margin(new Padding(2, 0, 2, 0));
		((Control)Label38).set_Name("Label38");
		((Control)Label38).set_Size(new Size(147, 19));
		((Control)Label38).set_TabIndex(10);
		Label38.set_Text("Application version");
		Label8.set_AutoSize(true);
		((Control)Label8).set_Font(new Font("MS Reference Sans Serif", 9f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)Label8).set_Location(new Point(44, 38));
		((Control)Label8).set_Margin(new Padding(2, 0, 2, 0));
		((Control)Label8).set_Name("Label8");
		((Control)Label8).set_Size(new Size(52, 16));
		((Control)Label8).set_TabIndex(13);
		Label8.set_Text("0.0.0.0");
		((Control)Panel27).set_BackColor(Color.White);
		((Control)Panel27).get_Controls().Add((Control)(object)Label52);
		((Control)Panel27).get_Controls().Add((Control)(object)PictureBox64);
		((Control)Panel27).set_Cursor(Cursors.get_Hand());
		((Control)Panel27).set_Location(new Point(401, 276));
		((Control)Panel27).set_Name("Panel27");
		((Control)Panel27).set_Size(new Size(185, 46));
		((Control)Panel27).set_TabIndex(18);
		Label52.set_AutoSize(true);
		((Control)Label52).set_Cursor(Cursors.get_Hand());
		((Control)Label52).set_Font(new Font("MS Reference Sans Serif", 10.2f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)Label52).set_Location(new Point(44, 16));
		((Control)Label52).set_Margin(new Padding(2, 0, 2, 0));
		((Control)Label52).set_Name("Label52");
		((Control)Label52).set_Size(new Size(124, 18));
		((Control)Label52).set_TabIndex(9);
		Label52.set_Text("Contact support");
		((Control)PictureBox64).set_Cursor(Cursors.get_Hand());
		PictureBox64.set_Image((Image)componentResourceManager.GetObject("PictureBox64.Image"));
		((Control)PictureBox64).set_Location(new Point(4, 6));
		((Control)PictureBox64).set_Margin(new Padding(2));
		((Control)PictureBox64).set_Name("PictureBox64");
		((Control)PictureBox64).set_Size(new Size(35, 33));
		PictureBox64.set_SizeMode((PictureBoxSizeMode)1);
		PictureBox64.set_TabIndex(2);
		PictureBox64.set_TabStop(false);
		((Control)Panel26).set_BackColor(Color.White);
		((Control)Panel26).get_Controls().Add((Control)(object)Label51);
		((Control)Panel26).get_Controls().Add((Control)(object)PictureBox50);
		((Control)Panel26).set_Cursor(Cursors.get_Hand());
		((Control)Panel26).set_Location(new Point(205, 276));
		((Control)Panel26).set_Name("Panel26");
		((Control)Panel26).set_Size(new Size(185, 46));
		((Control)Panel26).set_TabIndex(17);
		Label51.set_AutoSize(true);
		((Control)Label51).set_Cursor(Cursors.get_Hand());
		((Control)Label51).set_Font(new Font("MS Reference Sans Serif", 10.2f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)Label51).set_Location(new Point(44, 16));
		((Control)Label51).set_Margin(new Padding(2, 0, 2, 0));
		((Control)Label51).set_Name("Label51");
		((Control)Label51).set_Size(new Size(122, 18));
		((Control)Label51).set_TabIndex(8);
		Label51.set_Text("Purchase license");
		((Control)PictureBox50).set_Cursor(Cursors.get_Hand());
		PictureBox50.set_Image((Image)componentResourceManager.GetObject("PictureBox50.Image"));
		((Control)PictureBox50).set_Location(new Point(4, 6));
		((Control)PictureBox50).set_Margin(new Padding(2));
		((Control)PictureBox50).set_Name("PictureBox50");
		((Control)PictureBox50).set_Size(new Size(35, 33));
		PictureBox50.set_SizeMode((PictureBoxSizeMode)1);
		PictureBox50.set_TabIndex(2);
		PictureBox50.set_TabStop(false);
		((Control)Panel25).set_BackColor(Color.White);
		((Control)Panel25).get_Controls().Add((Control)(object)Label44);
		((Control)Panel25).get_Controls().Add((Control)(object)PictureBox53);
		((Control)Panel25).set_Cursor(Cursors.get_Hand());
		((Control)Panel25).set_Location(new Point(10, 276));
		((Control)Panel25).set_Name("Panel25");
		((Control)Panel25).set_Size(new Size(185, 46));
		((Control)Panel25).set_TabIndex(16);
		Label44.set_AutoSize(true);
		((Control)Label44).set_Cursor(Cursors.get_Hand());
		((Control)Label44).set_Font(new Font("MS Reference Sans Serif", 10.2f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)Label44).set_Location(new Point(44, 16));
		((Control)Label44).set_Margin(new Padding(2, 0, 2, 0));
		((Control)Label44).set_Name("Label44");
		((Control)Label44).set_Size(new Size(137, 18));
		((Control)Label44).set_TabIndex(7);
		Label44.set_Text("Check for updates");
		((Control)PictureBox53).set_Cursor(Cursors.get_Hand());
		PictureBox53.set_Image((Image)componentResourceManager.GetObject("PictureBox53.Image"));
		((Control)PictureBox53).set_Location(new Point(4, 6));
		((Control)PictureBox53).set_Margin(new Padding(2));
		((Control)PictureBox53).set_Name("PictureBox53");
		((Control)PictureBox53).set_Size(new Size(35, 33));
		PictureBox53.set_SizeMode((PictureBoxSizeMode)1);
		PictureBox53.set_TabIndex(2);
		PictureBox53.set_TabStop(false);
		((Control)GeneralSettingsPanelMain).set_BackColor(Color.Transparent);
		((Control)GeneralSettingsPanelMain).get_Controls().Add((Control)(object)Panel22);
		((Control)GeneralSettingsPanelMain).get_Controls().Add((Control)(object)Panel7);
		((Control)GeneralSettingsPanelMain).get_Controls().Add((Control)(object)Panel5);
		((Control)GeneralSettingsPanelMain).set_Location(new Point(572, 66));
		((Control)GeneralSettingsPanelMain).set_Name("GeneralSettingsPanelMain");
		((Control)GeneralSettingsPanelMain).set_Size(new Size(754, 510));
		((Control)GeneralSettingsPanelMain).set_TabIndex(7);
		((Control)GeneralSettingsPanelMain).set_Visible(false);
		((Control)Panel22).set_BackColor(Color.White);
		((Control)Panel22).get_Controls().Add((Control)(object)Label16);
		((Control)Panel22).get_Controls().Add((Control)(object)Label6);
		((Control)Panel22).get_Controls().Add((Control)(object)PictureBox57);
		((Control)Panel22).set_Location(new Point(8, 172));
		((Control)Panel22).set_Name("Panel22");
		((Control)Panel22).set_Size(new Size(579, 72));
		((Control)Panel22).set_TabIndex(7);
		((Control)Label16).set_Location(new Point(10, 40));
		((Control)Label16).set_Name("Label16");
		((Control)Label16).set_Size(new Size(558, 26));
		((Control)Label16).set_TabIndex(7);
		Label16.set_Text("Block execution of programs from well known ransomware preferred folders and from archives so is less likely to run by mistake (e.g. from an email attachment).");
		Label6.set_AutoSize(true);
		((Control)Label6).set_BackColor(Color.White);
		((Control)Label6).set_Font(new Font("MS Reference Sans Serif", 14.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)Label6).set_Location(new Point(56, 10));
		((Control)Label6).set_Name("Label6");
		((Control)Label6).set_Size(new Size(273, 24));
		((Control)Label6).set_TabIndex(3);
		Label6.set_Text("Enable proactive protection");
		((Control)PictureBox57).set_Cursor(Cursors.get_Hand());
		((Control)PictureBox57).set_Location(new Point(13, 16));
		((Control)PictureBox57).set_Name("PictureBox57");
		((Control)PictureBox57).set_Size(new Size(31, 16));
		PictureBox57.set_TabIndex(2);
		PictureBox57.set_TabStop(false);
		((Control)Panel7).set_BackColor(Color.White);
		((Control)Panel7).get_Controls().Add((Control)(object)Label14);
		((Control)Panel7).get_Controls().Add((Control)(object)Label22);
		((Control)Panel7).get_Controls().Add((Control)(object)PictureBox27);
		((Control)Panel7).set_Location(new Point(8, 94));
		((Control)Panel7).set_Name("Panel7");
		((Control)Panel7).set_Size(new Size(579, 72));
		((Control)Panel7).set_TabIndex(5);
		((Control)Label14).set_Location(new Point(10, 40));
		((Control)Label14).set_Name("Label14");
		((Control)Label14).set_Size(new Size(558, 32));
		((Control)Label14).set_TabIndex(6);
		Label14.set_Text("Enable heurisitc analysis such as detection of mime type changes, multiple fire renames or trap folders. We highly recommend to enable this option.");
		Label22.set_AutoSize(true);
		((Control)Label22).set_BackColor(Color.White);
		((Control)Label22).set_Font(new Font("MS Reference Sans Serif", 14.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)Label22).set_Location(new Point(56, 10));
		((Control)Label22).set_Name("Label22");
		((Control)Label22).set_Size(new Size(247, 24));
		((Control)Label22).set_TabIndex(3);
		Label22.set_Text("Enable heuristic analysis");
		((Control)PictureBox27).set_Cursor(Cursors.get_Hand());
		((Control)PictureBox27).set_Location(new Point(13, 16));
		((Control)PictureBox27).set_Name("PictureBox27");
		((Control)PictureBox27).set_Size(new Size(31, 16));
		PictureBox27.set_TabIndex(2);
		PictureBox27.set_TabStop(false);
		((Control)Panel5).set_BackColor(Color.White);
		((Control)Panel5).get_Controls().Add((Control)(object)Label13);
		((Control)Panel5).get_Controls().Add((Control)(object)Label11);
		((Control)Panel5).get_Controls().Add((Control)(object)PictureBox9);
		((Control)Panel5).set_Location(new Point(8, 15));
		((Control)Panel5).set_Name("Panel5");
		((Control)Panel5).set_Size(new Size(579, 72));
		((Control)Panel5).set_TabIndex(3);
		((Control)Label13).set_Location(new Point(10, 40));
		((Control)Label13).set_Name("Label13");
		((Control)Label13).set_Size(new Size(558, 32));
		((Control)Label13).set_TabIndex(5);
		Label13.set_Text("Make this application run on system startup. This do not affect engine's activity as it will run regardless, but you will not be notified about engine's actions.");
		Label11.set_AutoSize(true);
		((Control)Label11).set_BackColor(Color.White);
		((Control)Label11).set_Font(new Font("MS Reference Sans Serif", 14.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)Label11).set_Location(new Point(56, 10));
		((Control)Label11).set_Name("Label11");
		((Control)Label11).set_Size(new Size(184, 24));
		((Control)Label11).set_TabIndex(3);
		Label11.set_Text("Start when I login");
		((Control)PictureBox9).set_Cursor(Cursors.get_Hand());
		((Control)PictureBox9).set_Location(new Point(13, 16));
		((Control)PictureBox9).set_Name("PictureBox9");
		((Control)PictureBox9).set_Size(new Size(31, 16));
		PictureBox9.set_TabIndex(2);
		PictureBox9.set_TabStop(false);
		ImageList1.set_ImageStream((ImageListStreamer)componentResourceManager.GetObject("ImageList1.ImageStream"));
		ImageList1.set_TransparentColor(Color.Transparent);
		ImageList1.get_Images().SetKeyName(0, "on.png");
		ImageList1.get_Images().SetKeyName(1, "off.png");
		ImageList1.get_Images().SetKeyName(2, "neutru.png");
		ToolTip1.set_AutomaticDelay(0);
		ToolTip1.set_AutoPopDelay(90000);
		ToolTip1.set_InitialDelay(550);
		ToolTip1.set_ReshowDelay(110);
		((Control)ActionsPanelMain).set_BackColor(Color.Transparent);
		((Control)ActionsPanelMain).get_Controls().Add((Control)(object)Label15);
		((Control)ActionsPanelMain).get_Controls().Add((Control)(object)DataGridView2);
		((Control)ActionsPanelMain).set_Location(new Point(168, 411));
		((Control)ActionsPanelMain).set_Name("ActionsPanelMain");
		((Control)ActionsPanelMain).set_Size(new Size(754, 510));
		((Control)ActionsPanelMain).set_TabIndex(9);
		((Control)ActionsPanelMain).set_Visible(false);
		Label15.set_AutoSize(true);
		((Control)Label15).set_Font(new Font("MS Reference Sans Serif", 18f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)Label15).set_ForeColor(Color.DarkGray);
		((Control)Label15).set_Location(new Point(142, 169));
		((Control)Label15).set_Name("Label15");
		((Control)Label15).set_Size(new Size(302, 29));
		((Control)Label15).set_TabIndex(3);
		Label15.set_Text("The quarantine is empty");
		((Control)Label15).set_Visible(false);
		DataGridView2.set_AllowUserToAddRows(false);
		DataGridView2.set_AllowUserToDeleteRows(false);
		DataGridView2.set_AllowUserToResizeColumns(false);
		DataGridView2.set_AllowUserToResizeRows(false);
		DataGridView2.set_AutoSizeColumnsMode((DataGridViewAutoSizeColumnsMode)6);
		DataGridView2.set_BackgroundColor(Color.White);
		DataGridView2.set_BorderStyle((BorderStyle)0);
		DataGridView2.set_CellBorderStyle((DataGridViewCellBorderStyle)4);
		DataGridView2.set_ColumnHeadersBorderStyle((DataGridViewHeaderBorderStyle)4);
		val.set_Alignment((DataGridViewContentAlignment)16);
		val.set_BackColor(Color.White);
		val.set_Font(new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		val.set_ForeColor(SystemColors.WindowText);
		val.set_SelectionBackColor(SystemColors.Highlight);
		val.set_SelectionForeColor(SystemColors.HighlightText);
		val.set_WrapMode((DataGridViewTriState)1);
		DataGridView2.set_ColumnHeadersDefaultCellStyle(val);
		DataGridView2.set_ColumnHeadersHeightSizeMode((DataGridViewColumnHeadersHeightSizeMode)2);
		DataGridView2.get_Columns().AddRange((DataGridViewColumn[])(object)new DataGridViewColumn[3]
		{
			(DataGridViewColumn)DataGridViewTextBoxColumn2,
			(DataGridViewColumn)DataGridViewTextBoxColumn4,
			(DataGridViewColumn)DataGridViewTextBoxColumn3
		});
		((Control)DataGridView2).set_ContextMenuStrip(ContextMenuStrip4);
		val2.set_Alignment((DataGridViewContentAlignment)16);
		val2.set_BackColor(Color.White);
		val2.set_Font(new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		val2.set_ForeColor(SystemColors.ControlText);
		val2.set_SelectionBackColor(SystemColors.Control);
		val2.set_SelectionForeColor(SystemColors.ControlText);
		val2.set_WrapMode((DataGridViewTriState)2);
		DataGridView2.set_DefaultCellStyle(val2);
		DataGridView2.set_EditMode((DataGridViewEditMode)4);
		((Control)DataGridView2).set_Location(new Point(4, 8));
		DataGridView2.set_MultiSelect(false);
		((Control)DataGridView2).set_Name("DataGridView2");
		DataGridView2.set_ReadOnly(true);
		val3.set_Alignment((DataGridViewContentAlignment)16);
		val3.set_BackColor(Color.White);
		val3.set_Font(new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		val3.set_ForeColor(SystemColors.WindowText);
		val3.set_SelectionBackColor(SystemColors.Highlight);
		val3.set_SelectionForeColor(SystemColors.HighlightText);
		val3.set_WrapMode((DataGridViewTriState)1);
		DataGridView2.set_RowHeadersDefaultCellStyle(val3);
		DataGridView2.set_RowHeadersVisible(false);
		DataGridView2.set_SelectionMode((DataGridViewSelectionMode)1);
		DataGridView2.set_ShowCellErrors(false);
		DataGridView2.set_ShowEditingIcon(false);
		DataGridView2.set_ShowRowErrors(false);
		((Control)DataGridView2).set_Size(new Size(594, 421));
		((Control)DataGridView2).set_TabIndex(2);
		((Control)DataGridView2).set_Visible(false);
		((DataGridViewColumn)DataGridViewTextBoxColumn2).set_AutoSizeMode((DataGridViewAutoSizeColumnMode)6);
		val4.set_Font(new Font("MS Reference Sans Serif", 8.25f));
		((DataGridViewColumn)DataGridViewTextBoxColumn2).set_DefaultCellStyle(val4);
		((DataGridViewColumn)DataGridViewTextBoxColumn2).set_DividerWidth(1);
		((DataGridViewColumn)DataGridViewTextBoxColumn2).set_HeaderText("Time created");
		((DataGridViewColumn)DataGridViewTextBoxColumn2).set_Name("DataGridViewTextBoxColumn2");
		((DataGridViewColumn)DataGridViewTextBoxColumn2).set_ReadOnly(true);
		((DataGridViewColumn)DataGridViewTextBoxColumn2).set_Width(95);
		((DataGridViewColumn)DataGridViewTextBoxColumn4).set_AutoSizeMode((DataGridViewAutoSizeColumnMode)16);
		val5.set_Font(new Font("MS Reference Sans Serif", 8.25f));
		((DataGridViewColumn)DataGridViewTextBoxColumn4).set_DefaultCellStyle(val5);
		((DataGridViewColumn)DataGridViewTextBoxColumn4).set_DividerWidth(1);
		((DataGridViewColumn)DataGridViewTextBoxColumn4).set_HeaderText("File name");
		((DataGridViewColumn)DataGridViewTextBoxColumn4).set_Name("DataGridViewTextBoxColumn4");
		((DataGridViewColumn)DataGridViewTextBoxColumn4).set_ReadOnly(true);
		((DataGridViewColumn)DataGridViewTextBoxColumn3).set_AutoSizeMode((DataGridViewAutoSizeColumnMode)6);
		val6.set_Font(new Font("MS Reference Sans Serif", 8.25f));
		((DataGridViewColumn)DataGridViewTextBoxColumn3).set_DefaultCellStyle(val6);
		((DataGridViewColumn)DataGridViewTextBoxColumn3).set_DividerWidth(1);
		((DataGridViewColumn)DataGridViewTextBoxColumn3).set_HeaderText("Method");
		((DataGridViewColumn)DataGridViewTextBoxColumn3).set_Name("DataGridViewTextBoxColumn3");
		((DataGridViewColumn)DataGridViewTextBoxColumn3).set_ReadOnly(true);
		((DataGridViewColumn)DataGridViewTextBoxColumn3).set_Width(69);
		((ToolStrip)ContextMenuStrip4).get_Items().AddRange((ToolStripItem[])(object)new ToolStripItem[7]
		{
			(ToolStripItem)ToolStripMenuItem5,
			(ToolStripItem)ToolStripSeparator3,
			(ToolStripItem)ToolStripMenuItem2,
			(ToolStripItem)ToolStripMenuItem3,
			(ToolStripItem)ToolStripSeparator1,
			(ToolStripItem)ToolStripMenuItem4,
			(ToolStripItem)WipeAllFilesToolStripMenuItem
		});
		((Control)ContextMenuStrip4).set_Name("ContextMenuStrip4");
		((ToolStripDropDownMenu)ContextMenuStrip4).set_ShowImageMargin(false);
		((ToolStrip)ContextMenuStrip4).set_ShowItemToolTips(false);
		((Control)ContextMenuStrip4).set_Size(new Size(196, 126));
		((ToolStripItem)ToolStripMenuItem5).set_Name("ToolStripMenuItem5");
		((ToolStripItem)ToolStripMenuItem5).set_Size(new Size(195, 22));
		((ToolStripItem)ToolStripMenuItem5).set_Text("Search Events Log");
		((ToolStripItem)ToolStripSeparator3).set_Name("ToolStripSeparator3");
		((ToolStripItem)ToolStripSeparator3).set_Size(new Size(192, 6));
		((ToolStripItem)ToolStripMenuItem2).set_Name("ToolStripMenuItem2");
		((ToolStripItem)ToolStripMenuItem2).set_Size(new Size(195, 22));
		((ToolStripItem)ToolStripMenuItem2).set_Text("Restore file");
		((ToolStripItem)ToolStripMenuItem3).set_Name("ToolStripMenuItem3");
		((ToolStripItem)ToolStripMenuItem3).set_Size(new Size(195, 22));
		((ToolStripItem)ToolStripMenuItem3).set_Text("Restore and add to whitelist");
		((ToolStripItem)ToolStripSeparator1).set_Name("ToolStripSeparator1");
		((ToolStripItem)ToolStripSeparator1).set_Size(new Size(192, 6));
		((ToolStripItem)ToolStripMenuItem4).set_Image((Image)componentResourceManager.GetObject("ToolStripMenuItem4.Image"));
		((ToolStripItem)ToolStripMenuItem4).set_Name("ToolStripMenuItem4");
		((ToolStripItem)ToolStripMenuItem4).set_Size(new Size(195, 22));
		((ToolStripItem)ToolStripMenuItem4).set_Text("Wipe this file");
		((ToolStripItem)WipeAllFilesToolStripMenuItem).set_Name("WipeAllFilesToolStripMenuItem");
		((ToolStripItem)WipeAllFilesToolStripMenuItem).set_Size(new Size(195, 22));
		((ToolStripItem)WipeAllFilesToolStripMenuItem).set_Text("Wipe all quarantined items");
		ImageList2.set_ImageStream((ImageListStreamer)componentResourceManager.GetObject("ImageList2.ImageStream"));
		ImageList2.set_TransparentColor(Color.Transparent);
		ImageList2.get_Images().SetKeyName(0, "protected.png");
		ImageList2.get_Images().SetKeyName(1, "e-rau.png");
		ImageList2.get_Images().SetKeyName(2, "warning.png");
		Timer1.set_Interval(10);
		ImageList3.set_ImageStream((ImageListStreamer)componentResourceManager.GetObject("ImageList3.ImageStream"));
		ImageList3.set_TransparentColor(Color.Transparent);
		ImageList3.get_Images().SetKeyName(0, "ico.ico");
		ImageList3.get_Images().SetKeyName(1, "e-rau.png");
		ImageList3.get_Images().SetKeyName(2, "warning.png");
		Timer2.set_Enabled(true);
		Timer2.set_Interval(86400000);
		Timer3.set_Enabled(true);
		Timer3.set_Interval(3600000);
		((Control)AdvancedPanelMain).set_BackColor(Color.Transparent);
		((Control)AdvancedPanelMain).get_Controls().Add((Control)(object)Panel4);
		((Control)AdvancedPanelMain).get_Controls().Add((Control)(object)Panel35);
		((Control)AdvancedPanelMain).get_Controls().Add((Control)(object)Panel23);
		((Control)AdvancedPanelMain).set_Location(new Point(538, 108));
		((Control)AdvancedPanelMain).set_Name("AdvancedPanelMain");
		((Control)AdvancedPanelMain).set_Size(new Size(788, 512));
		((Control)AdvancedPanelMain).set_TabIndex(10);
		((Control)AdvancedPanelMain).set_Visible(false);
		((Control)Panel4).set_BackColor(Color.White);
		((Control)Panel4).get_Controls().Add((Control)(object)Label18);
		((Control)Panel4).get_Controls().Add((Control)(object)PictureBox4);
		((Control)Panel4).get_Controls().Add((Control)(object)Label3);
		((Control)Panel4).set_Location(new Point(8, 94));
		((Control)Panel4).set_Name("Panel4");
		((Control)Panel4).set_Size(new Size(579, 72));
		((Control)Panel4).set_TabIndex(18);
		((Control)Panel4).set_Tag((object)"0");
		((Control)Label18).set_Location(new Point(10, 40));
		((Control)Label18).set_Name("Label18");
		((Control)Label18).set_Size(new Size(558, 30));
		((Control)Label18).set_TabIndex(11);
		Label18.set_Text("This applications are allowed to change any file in any way. Use this if a legit software you are running is causing false positives.");
		((Control)PictureBox4).set_Cursor(Cursors.get_Hand());
		((Control)PictureBox4).set_Location(new Point(13, 13));
		((Control)PictureBox4).set_Name("PictureBox4");
		((Control)PictureBox4).set_Size(new Size(31, 16));
		PictureBox4.set_SizeMode((PictureBoxSizeMode)4);
		PictureBox4.set_TabIndex(9);
		PictureBox4.set_TabStop(false);
		((Control)PictureBox4).set_Tag((object)"0");
		Label3.set_AutoSize(true);
		((Control)Label3).set_BackColor(Color.White);
		((Control)Label3).set_Cursor(Cursors.get_Hand());
		((Control)Label3).set_Font(new Font("MS Reference Sans Serif", 14.25f));
		((Control)Label3).set_Location(new Point(56, 10));
		((Control)Label3).set_Name("Label3");
		((Control)Label3).set_Size(new Size(253, 24));
		((Control)Label3).set_TabIndex(3);
		Label3.set_Text("White listed  applications");
		((Control)Panel35).set_BackColor(Color.White);
		((Control)Panel35).get_Controls().Add((Control)(object)Label17);
		((Control)Panel35).get_Controls().Add((Control)(object)PictureBox78);
		((Control)Panel35).get_Controls().Add((Control)(object)Label43);
		((Control)Panel35).set_Location(new Point(8, 15));
		((Control)Panel35).set_Name("Panel35");
		((Control)Panel35).set_Size(new Size(579, 72));
		((Control)Panel35).set_TabIndex(17);
		((Control)Panel35).set_Tag((object)"0");
		((Control)Label17).set_Location(new Point(10, 40));
		((Control)Label17).set_Name("Label17");
		((Control)Label17).set_Size(new Size(558, 32));
		((Control)Label17).set_TabIndex(10);
		Label17.set_Text("All changes made in this folders will be allowed. Please note that subfolders are also affected. This is intended for path that may contain corrupted files (e.g. recovered data).");
		((Control)PictureBox78).set_Cursor(Cursors.get_Hand());
		((Control)PictureBox78).set_Location(new Point(13, 13));
		((Control)PictureBox78).set_Name("PictureBox78");
		((Control)PictureBox78).set_Size(new Size(31, 16));
		PictureBox78.set_SizeMode((PictureBoxSizeMode)4);
		PictureBox78.set_TabIndex(9);
		PictureBox78.set_TabStop(false);
		((Control)PictureBox78).set_Tag((object)"0");
		Label43.set_AutoSize(true);
		((Control)Label43).set_BackColor(Color.White);
		((Control)Label43).set_Cursor(Cursors.get_Hand());
		((Control)Label43).set_Font(new Font("MS Reference Sans Serif", 14.25f));
		((Control)Label43).set_Location(new Point(56, 10));
		((Control)Label43).set_Name("Label43");
		((Control)Label43).set_Size(new Size(183, 24));
		((Control)Label43).set_TabIndex(3);
		Label43.set_Text("White listed paths");
		((Control)Panel23).set_BackColor(Color.White);
		((Control)Panel23).get_Controls().Add((Control)(object)ListBox1);
		((Control)Panel23).set_Location(new Point(8, 171));
		((Control)Panel23).set_Name("Panel23");
		((Control)Panel23).set_Size(new Size(578, 256));
		((Control)Panel23).set_TabIndex(16);
		ListBox1.set_BackColor(Color.White);
		ListBox1.set_BorderStyle((BorderStyle)0);
		((Control)ListBox1).set_ContextMenuStrip(ContextMenuStrip3);
		ListBox1.set_DrawMode((DrawMode)2);
		ListBox1.set_Font(new Font("MS Reference Sans Serif", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((ListControl)ListBox1).set_FormattingEnabled(true);
		ListBox1.set_ItemHeight(24);
		((Control)ListBox1).set_Location(new Point(9, 8));
		((Control)ListBox1).set_Margin(new Padding(2));
		((Control)ListBox1).set_Name("ListBox1");
		((Control)ListBox1).set_Size(new Size(564, 234));
		ListBox1.set_Sorted(true);
		((Control)ListBox1).set_TabIndex(25);
		((ToolStrip)ContextMenuStrip3).set_ImageScalingSize(new Size(20, 20));
		((ToolStrip)ContextMenuStrip3).get_Items().AddRange((ToolStripItem[])(object)new ToolStripItem[4]
		{
			(ToolStripItem)ToolStripMenuItem1,
			(ToolStripItem)RemoveFolderToolStripMenuItem,
			(ToolStripItem)ToolStripSeparator2,
			(ToolStripItem)ClearToolStripMenuItem
		});
		((Control)ContextMenuStrip3).set_Name("ContextMenuStrip2");
		((ToolStripDropDownMenu)ContextMenuStrip3).set_ShowImageMargin(false);
		((ToolStrip)ContextMenuStrip3).set_ShowItemToolTips(false);
		((Control)ContextMenuStrip3).set_Size(new Size(127, 76));
		((ToolStripItem)ToolStripMenuItem1).set_Image((Image)componentResourceManager.GetObject("ToolStripMenuItem1.Image"));
		((ToolStripItem)ToolStripMenuItem1).set_Name("ToolStripMenuItem1");
		((ToolStripItem)ToolStripMenuItem1).set_Size(new Size(126, 22));
		((ToolStripItem)ToolStripMenuItem1).set_Text("Add folder");
		((ToolStripItem)RemoveFolderToolStripMenuItem).set_Image((Image)componentResourceManager.GetObject("RemoveFolderToolStripMenuItem.Image"));
		((ToolStripItem)RemoveFolderToolStripMenuItem).set_Name("RemoveFolderToolStripMenuItem");
		((ToolStripItem)RemoveFolderToolStripMenuItem).set_Size(new Size(126, 22));
		((ToolStripItem)RemoveFolderToolStripMenuItem).set_Text("Remove folder");
		((ToolStripItem)ToolStripSeparator2).set_Name("ToolStripSeparator2");
		((ToolStripItem)ToolStripSeparator2).set_Size(new Size(123, 6));
		((ToolStripItem)ClearToolStripMenuItem).set_Name("ClearToolStripMenuItem");
		((ToolStripItem)ClearToolStripMenuItem).set_Size(new Size(126, 22));
		((ToolStripItem)ClearToolStripMenuItem).set_Text("Clear");
		((ToolStrip)ContextMenuStrip2).set_ImageScalingSize(new Size(20, 20));
		((ToolStrip)ContextMenuStrip2).get_Items().AddRange((ToolStripItem[])(object)new ToolStripItem[1] { (ToolStripItem)SelectAllToolStripMenuItem });
		((Control)ContextMenuStrip2).set_Name("ContextMenuStrip2");
		((Control)ContextMenuStrip2).set_Size(new Size(127, 30));
		((ToolStripItem)SelectAllToolStripMenuItem).set_Image((Image)componentResourceManager.GetObject("SelectAllToolStripMenuItem.Image"));
		((ToolStripItem)SelectAllToolStripMenuItem).set_Name("SelectAllToolStripMenuItem");
		((ToolStripItem)SelectAllToolStripMenuItem).set_Size(new Size(126, 26));
		((ToolStripItem)SelectAllToolStripMenuItem).set_Text("Select All");
		Timer4.set_Enabled(true);
		Timer4.set_Interval(1);
		FolderBrowserDialog1.set_Description("Please select a folder to exclude.  All subfolders will be also excluded.");
		FolderBrowserDialog1.set_RootFolder(Environment.SpecialFolder.MyComputer);
		FolderBrowserDialog1.set_ShowNewFolderButton(false);
		ImageList4.set_ImageStream((ImageListStreamer)componentResourceManager.GetObject("ImageList4.ImageStream"));
		ImageList4.set_TransparentColor(Color.Transparent);
		ImageList4.get_Images().SetKeyName(0, "images (1).png");
		ImageList4.get_Images().SetKeyName(1, "images.png");
		((Control)LogPanelMain).set_BackColor(Color.Transparent);
		((Control)LogPanelMain).get_Controls().Add((Control)(object)Button2);
		((Control)LogPanelMain).get_Controls().Add((Control)(object)Button1);
		((Control)LogPanelMain).get_Controls().Add((Control)(object)TextBox1);
		((Control)LogPanelMain).get_Controls().Add((Control)(object)Label19);
		((Control)LogPanelMain).get_Controls().Add((Control)(object)TextBox8);
		((Control)LogPanelMain).get_Controls().Add((Control)(object)DataGridView1);
		((Control)LogPanelMain).set_Location(new Point(389, 188));
		((Control)LogPanelMain).set_Name("LogPanelMain");
		((Control)LogPanelMain).set_Size(new Size(754, 517));
		((Control)LogPanelMain).set_TabIndex(11);
		((Control)LogPanelMain).set_Visible(false);
		((ButtonBase)Button2).set_BackColor(Color.White);
		((Control)Button2).set_Cursor(Cursors.get_Hand());
		((Control)Button2).set_Location(new Point(537, 4));
		((Control)Button2).set_Name("Button2");
		((Control)Button2).set_Size(new Size(50, 23));
		((Control)Button2).set_TabIndex(7);
		((ButtonBase)Button2).set_Text("Clear");
		((ButtonBase)Button2).set_UseVisualStyleBackColor(false);
		((ButtonBase)Button1).set_BackColor(Color.White);
		((Control)Button1).set_Cursor(Cursors.get_Hand());
		((Control)Button1).set_Location(new Point(473, 3));
		((Control)Button1).set_Name("Button1");
		((Control)Button1).set_Size(new Size(53, 23));
		((Control)Button1).set_TabIndex(6);
		((ButtonBase)Button1).set_Text("Search");
		((ButtonBase)Button1).set_UseVisualStyleBackColor(false);
		((Control)TextBox1).set_Location(new Point(79, 4));
		((Control)TextBox1).set_Name("TextBox1");
		((Control)TextBox1).set_Size(new Size(388, 20));
		((Control)TextBox1).set_TabIndex(5);
		Label19.set_AutoSize(true);
		((Control)Label19).set_Location(new Point(4, 7));
		((Control)Label19).set_Name("Label19");
		((Control)Label19).set_Size(new Size(73, 13));
		((Control)Label19).set_TabIndex(4);
		Label19.set_Text("Quick search:");
		((TextBoxBase)TextBox8).set_BackColor(Color.White);
		((TextBoxBase)TextBox8).set_BorderStyle((BorderStyle)0);
		((Control)TextBox8).set_Font(new Font("MS Reference Sans Serif", 9.75f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)TextBox8).set_Location(new Point(3, 291));
		((Control)TextBox8).set_Margin(new Padding(0));
		TextBox8.set_Multiline(true);
		((Control)TextBox8).set_Name("TextBox8");
		((TextBoxBase)TextBox8).set_ReadOnly(true);
		TextBox8.set_ScrollBars((ScrollBars)2);
		((Control)TextBox8).set_Size(new Size(594, 137));
		((Control)TextBox8).set_TabIndex(3);
		DataGridView1.set_AllowUserToAddRows(false);
		DataGridView1.set_AllowUserToDeleteRows(false);
		DataGridView1.set_AllowUserToResizeColumns(false);
		DataGridView1.set_AllowUserToResizeRows(false);
		DataGridView1.set_AutoSizeColumnsMode((DataGridViewAutoSizeColumnsMode)6);
		DataGridView1.set_BackgroundColor(Color.White);
		DataGridView1.set_BorderStyle((BorderStyle)0);
		DataGridView1.set_CellBorderStyle((DataGridViewCellBorderStyle)4);
		DataGridView1.set_ColumnHeadersBorderStyle((DataGridViewHeaderBorderStyle)4);
		val7.set_Alignment((DataGridViewContentAlignment)16);
		val7.set_BackColor(Color.White);
		val7.set_Font(new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		val7.set_ForeColor(SystemColors.WindowText);
		val7.set_SelectionBackColor(SystemColors.Highlight);
		val7.set_SelectionForeColor(SystemColors.HighlightText);
		val7.set_WrapMode((DataGridViewTriState)1);
		DataGridView1.set_ColumnHeadersDefaultCellStyle(val7);
		DataGridView1.set_ColumnHeadersHeightSizeMode((DataGridViewColumnHeadersHeightSizeMode)2);
		DataGridView1.get_Columns().AddRange((DataGridViewColumn[])(object)new DataGridViewColumn[5]
		{
			(DataGridViewColumn)Column1,
			(DataGridViewColumn)Level,
			(DataGridViewColumn)Column3,
			(DataGridViewColumn)Column2,
			(DataGridViewColumn)Column4
		});
		((Control)DataGridView1).set_ContextMenuStrip(ContextMenuStrip5);
		val8.set_Alignment((DataGridViewContentAlignment)16);
		val8.set_BackColor(Color.White);
		val8.set_Font(new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		val8.set_ForeColor(SystemColors.ControlText);
		val8.set_SelectionBackColor(SystemColors.Control);
		val8.set_SelectionForeColor(SystemColors.ControlText);
		val8.set_WrapMode((DataGridViewTriState)2);
		DataGridView1.set_DefaultCellStyle(val8);
		DataGridView1.set_EditMode((DataGridViewEditMode)4);
		((Control)DataGridView1).set_Location(new Point(3, 30));
		DataGridView1.set_MultiSelect(false);
		((Control)DataGridView1).set_Name("DataGridView1");
		DataGridView1.set_ReadOnly(true);
		DataGridView1.set_RowHeadersBorderStyle((DataGridViewHeaderBorderStyle)4);
		val9.set_Alignment((DataGridViewContentAlignment)16);
		val9.set_BackColor(Color.White);
		val9.set_Font(new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		val9.set_ForeColor(SystemColors.WindowText);
		val9.set_SelectionBackColor(SystemColors.Highlight);
		val9.set_SelectionForeColor(SystemColors.HighlightText);
		val9.set_WrapMode((DataGridViewTriState)1);
		DataGridView1.set_RowHeadersDefaultCellStyle(val9);
		DataGridView1.set_RowHeadersVisible(false);
		DataGridView1.set_SelectionMode((DataGridViewSelectionMode)1);
		DataGridView1.set_ShowCellErrors(false);
		DataGridView1.set_ShowEditingIcon(false);
		DataGridView1.set_ShowRowErrors(false);
		((Control)DataGridView1).set_Size(new Size(594, 256));
		((Control)DataGridView1).set_TabIndex(1);
		((DataGridViewColumn)Column1).set_AutoSizeMode((DataGridViewAutoSizeColumnMode)1);
		val10.set_Alignment((DataGridViewContentAlignment)32);
		val10.set_BackColor(Color.White);
		val10.set_NullValue((object)null);
		val10.set_SelectionBackColor(Color.White);
		Column1.set_DefaultCellStyle(val10);
		((DataGridViewColumn)Column1).set_HeaderText("");
		((DataGridViewColumn)Column1).set_MinimumWidth(2);
		((DataGridViewColumn)Column1).set_Name("Column1");
		((DataGridViewColumn)Column1).set_ReadOnly(true);
		((DataGridViewColumn)Column1).set_Width(25);
		((DataGridViewColumn)Level).set_AutoSizeMode((DataGridViewAutoSizeColumnMode)6);
		val11.set_Font(new Font("MS Reference Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((DataGridViewColumn)Level).set_DefaultCellStyle(val11);
		((DataGridViewColumn)Level).set_DividerWidth(1);
		((DataGridViewColumn)Level).set_HeaderText("Type");
		((DataGridViewColumn)Level).set_Name("Level");
		((DataGridViewColumn)Level).set_ReadOnly(true);
		((DataGridViewColumn)Level).set_Width(57);
		((DataGridViewColumn)Column3).set_AutoSizeMode((DataGridViewAutoSizeColumnMode)6);
		val12.set_Font(new Font("MS Reference Sans Serif", 8.25f));
		((DataGridViewColumn)Column3).set_DefaultCellStyle(val12);
		((DataGridViewColumn)Column3).set_DividerWidth(1);
		((DataGridViewColumn)Column3).set_HeaderText("Time created");
		((DataGridViewColumn)Column3).set_Name("Column3");
		((DataGridViewColumn)Column3).set_ReadOnly(true);
		((DataGridViewColumn)Column3).set_Width(95);
		((DataGridViewColumn)Column2).set_AutoSizeMode((DataGridViewAutoSizeColumnMode)6);
		val13.set_Font(new Font("MS Reference Sans Serif", 8.25f));
		((DataGridViewColumn)Column2).set_DefaultCellStyle(val13);
		((DataGridViewColumn)Column2).set_DividerWidth(1);
		((DataGridViewColumn)Column2).set_HeaderText("Event");
		((DataGridViewColumn)Column2).set_Name("Column2");
		((DataGridViewColumn)Column2).set_ReadOnly(true);
		((DataGridViewColumn)Column2).set_Width(61);
		((DataGridViewColumn)Column4).set_AutoSizeMode((DataGridViewAutoSizeColumnMode)16);
		val14.set_Font(new Font("MS Reference Sans Serif", 8.25f));
		((DataGridViewColumn)Column4).set_DefaultCellStyle(val14);
		((DataGridViewColumn)Column4).set_DividerWidth(1);
		((DataGridViewColumn)Column4).set_HeaderText("Message");
		((DataGridViewColumn)Column4).set_Name("Column4");
		((DataGridViewColumn)Column4).set_ReadOnly(true);
		((Control)ContextMenuStrip5).set_Name("ContextMenuStrip5");
		((ToolStripDropDownMenu)ContextMenuStrip5).set_ShowImageMargin(false);
		((ToolStrip)ContextMenuStrip5).set_ShowItemToolTips(false);
		((Control)ContextMenuStrip5).set_Size(new Size(36, 4));
		ImageList5.set_ImageStream((ImageListStreamer)componentResourceManager.GetObject("ImageList5.ImageStream"));
		ImageList5.set_TransparentColor(Color.Transparent);
		ImageList5.get_Images().SetKeyName(0, "1484392186993.png");
		ImageList5.get_Images().SetKeyName(1, "2048ad6b60e75b5ace88f4aa4661bb53-setting-icon.png");
		ImageList5.get_Images().SetKeyName(2, "error-solid.png");
		ImageList5.get_Images().SetKeyName(3, "alarm-hazard-exclamation-danger-alert-problem-risk-6349.ico");
		ImageList5.get_Images().SetKeyName(4, "Cyber-Prot-M.png");
		ImageList5.get_Images().SetKeyName(5, "index.png");
		ImageList5.get_Images().SetKeyName(6, "565593.png");
		ImageList5.get_Images().SetKeyName(7, "166828.png");
		ImageList5.get_Images().SetKeyName(8, "images.png");
		PictureBox8.set_Image((Image)componentResourceManager.GetObject("PictureBox8.Image"));
		((Control)PictureBox8).set_Location(new Point(392, 2));
		((Control)PictureBox8).set_Name("PictureBox8");
		((Control)PictureBox8).set_Size(new Size(110, 20));
		PictureBox8.set_SizeMode((PictureBoxSizeMode)4);
		PictureBox8.set_TabIndex(4);
		PictureBox8.set_TabStop(false);
		((Control)PictureBox7).set_BackColor(Color.Transparent);
		((Control)PictureBox7).set_Cursor(Cursors.get_Hand());
		PictureBox7.set_Image((Image)componentResourceManager.GetObject("PictureBox7.Image"));
		((Control)PictureBox7).set_Location(new Point(706, 0));
		((Control)PictureBox7).set_Margin(new Padding(2));
		((Control)PictureBox7).set_Name("PictureBox7");
		((Control)PictureBox7).set_Size(new Size(22, 24));
		PictureBox7.set_SizeMode((PictureBoxSizeMode)4);
		PictureBox7.set_TabIndex(3);
		PictureBox7.set_TabStop(false);
		((Control)PictureBox7).set_Visible(false);
		((Control)PictureBox6).set_BackColor(Color.Transparent);
		((Control)PictureBox6).set_Cursor(Cursors.get_Hand());
		PictureBox6.set_Image((Image)componentResourceManager.GetObject("PictureBox6.Image"));
		((Control)PictureBox6).set_Location(new Point(730, 0));
		((Control)PictureBox6).set_Margin(new Padding(2));
		((Control)PictureBox6).set_Name("PictureBox6");
		((Control)PictureBox6).set_Size(new Size(22, 24));
		PictureBox6.set_SizeMode((PictureBoxSizeMode)4);
		PictureBox6.set_TabIndex(2);
		PictureBox6.set_TabStop(false);
		((Control)PictureBox5).set_BackColor(Color.Transparent);
		PictureBox5.set_Image((Image)componentResourceManager.GetObject("PictureBox5.Image"));
		((Control)PictureBox5).set_Location(new Point(153, 25));
		((Control)PictureBox5).set_Margin(new Padding(2));
		((Control)PictureBox5).set_Name("PictureBox5");
		((Control)PictureBox5).set_Size(new Size(600, 2));
		PictureBox5.set_SizeMode((PictureBoxSizeMode)4);
		PictureBox5.set_TabIndex(1);
		PictureBox5.set_TabStop(false);
		((Control)SmartScanPanelMain).set_BackColor(Color.Transparent);
		((Control)SmartScanPanelMain).set_Location(new Point(687, 76));
		((Control)SmartScanPanelMain).set_Name("SmartScanPanelMain");
		((Control)SmartScanPanelMain).set_Size(new Size(754, 517));
		((Control)SmartScanPanelMain).set_TabIndex(12);
		((Control)SmartScanPanelMain).set_Visible(false);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_BackColor(Color.FromArgb(250, 250, 250));
		((Form)this).set_ClientSize(new Size(754, 465));
		((Control)this).get_Controls().Add((Control)(object)StatusPanelMain);
		((Control)this).get_Controls().Add((Control)(object)GeneralSettingsPanelMain);
		((Control)this).get_Controls().Add((Control)(object)LogPanelMain);
		((Control)this).get_Controls().Add((Control)(object)ActionsPanelMain);
		((Control)this).get_Controls().Add((Control)(object)SmartScanPanelMain);
		((Control)this).get_Controls().Add((Control)(object)AdvancedPanelMain);
		((Control)this).get_Controls().Add((Control)(object)PictureBox8);
		((Control)this).get_Controls().Add((Control)(object)PictureBox7);
		((Control)this).get_Controls().Add((Control)(object)PictureBox6);
		((Control)this).get_Controls().Add((Control)(object)PictureBox5);
		((Control)this).get_Controls().Add((Control)(object)Panel1);
		((Form)this).set_FormBorderStyle((FormBorderStyle)0);
		((Form)this).set_Icon((Icon)componentResourceManager.GetObject("$this.Icon"));
		((Form)this).set_Margin(new Padding(2));
		((Control)this).set_Name("Form1");
		((Form)this).set_ShowInTaskbar(false);
		((Form)this).set_StartPosition((FormStartPosition)1);
		((Form)this).set_Text("Cyber Prot");
		((Form)this).set_WindowState((FormWindowState)1);
		((Control)Panel1).ResumeLayout(false);
		((Control)Panel36).ResumeLayout(false);
		((Control)Panel36).PerformLayout();
		((ISupportInitialize)PictureBox91).EndInit();
		((ISupportInitialize)PictureBox63).EndInit();
		((ISupportInitialize)PictureBox62).EndInit();
		((ISupportInitialize)PictureBox61).EndInit();
		((ISupportInitialize)PictureBox60).EndInit();
		((Control)Panel33).ResumeLayout(false);
		((Control)Panel33).PerformLayout();
		((ISupportInitialize)PictureBox77).EndInit();
		((Control)Panel12).ResumeLayout(false);
		((Control)Panel12).PerformLayout();
		((ISupportInitialize)PictureBox3).EndInit();
		((Control)Panel3).ResumeLayout(false);
		((Control)Panel3).PerformLayout();
		((ISupportInitialize)PictureBox32).EndInit();
		((Control)Panel2).ResumeLayout(false);
		((Control)Panel2).PerformLayout();
		((ISupportInitialize)PictureBox2).EndInit();
		((ISupportInitialize)PictureBox1).EndInit();
		((Control)ContextMenuStrip1).ResumeLayout(false);
		((Control)StatusPanelMain).ResumeLayout(false);
		((Control)Panel6).ResumeLayout(false);
		((Control)Panel8).ResumeLayout(false);
		((Control)Panel13).ResumeLayout(false);
		((Control)Panel20).ResumeLayout(false);
		((Control)Panel20).PerformLayout();
		((Control)Panel24).ResumeLayout(false);
		((Control)Panel34).ResumeLayout(false);
		((Control)Panel34).PerformLayout();
		((ISupportInitialize)PictureBox65).EndInit();
		((ISupportInitialize)PictureBox54).EndInit();
		((Control)Panel28).ResumeLayout(false);
		((Control)Panel28).PerformLayout();
		((ISupportInitialize)PictureBox68).EndInit();
		((ISupportInitialize)PictureBox66).EndInit();
		((ISupportInitialize)PictureBox67).EndInit();
		((Control)Panel27).ResumeLayout(false);
		((Control)Panel27).PerformLayout();
		((ISupportInitialize)PictureBox64).EndInit();
		((Control)Panel26).ResumeLayout(false);
		((Control)Panel26).PerformLayout();
		((ISupportInitialize)PictureBox50).EndInit();
		((Control)Panel25).ResumeLayout(false);
		((Control)Panel25).PerformLayout();
		((ISupportInitialize)PictureBox53).EndInit();
		((Control)GeneralSettingsPanelMain).ResumeLayout(false);
		((Control)Panel22).ResumeLayout(false);
		((Control)Panel22).PerformLayout();
		((ISupportInitialize)PictureBox57).EndInit();
		((Control)Panel7).ResumeLayout(false);
		((Control)Panel7).PerformLayout();
		((ISupportInitialize)PictureBox27).EndInit();
		((Control)Panel5).ResumeLayout(false);
		((Control)Panel5).PerformLayout();
		((ISupportInitialize)PictureBox9).EndInit();
		((Control)ActionsPanelMain).ResumeLayout(false);
		((Control)ActionsPanelMain).PerformLayout();
		((ISupportInitialize)DataGridView2).EndInit();
		((Control)ContextMenuStrip4).ResumeLayout(false);
		((Control)AdvancedPanelMain).ResumeLayout(false);
		((Control)Panel4).ResumeLayout(false);
		((Control)Panel4).PerformLayout();
		((ISupportInitialize)PictureBox4).EndInit();
		((Control)Panel35).ResumeLayout(false);
		((Control)Panel35).PerformLayout();
		((ISupportInitialize)PictureBox78).EndInit();
		((Control)Panel23).ResumeLayout(false);
		((Control)ContextMenuStrip3).ResumeLayout(false);
		((Control)ContextMenuStrip2).ResumeLayout(false);
		((Control)LogPanelMain).ResumeLayout(false);
		((Control)LogPanelMain).PerformLayout();
		((ISupportInitialize)DataGridView1).EndInit();
		((ISupportInitialize)PictureBox8).EndInit();
		((ISupportInitialize)PictureBox7).EndInit();
		((ISupportInitialize)PictureBox6).EndInit();
		((ISupportInitialize)PictureBox5).EndInit();
		((Control)this).ResumeLayout(false);
	}

	[SpecialName]
	[CompilerGenerated]
	private void a()
	{
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		MessageBox.Show("License error:\r\n" + this.m_s.get_InvalidReason(), "Cyber Prot", (MessageBoxButtons)0, (MessageBoxIcon)16);
	}
}
