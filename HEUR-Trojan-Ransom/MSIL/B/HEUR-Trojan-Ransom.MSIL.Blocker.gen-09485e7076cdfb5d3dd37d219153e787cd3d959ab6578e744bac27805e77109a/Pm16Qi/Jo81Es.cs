using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Net;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace Pm16Qi;

[DesignerGenerated]
public class Jo81Es : UserControl
{
	private IContainer components;

	private string strQuerry;

	private string creationDate;

	private int user_id;

	private string Path;

	private string BackupPath;

	private string DatabaseName;

	private object dlg_updateuser;

	private object dlg_fillup;

	private object dlg_savesuccessfully;

	private object dlg_addusers;

	private object dlg_backupsuccessfully;

	private object dlg_backuprestoresuccessfully;

	[field: AccessedThroughProperty("TabControl1")]
	internal virtual TabControl TabControl1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("TabPage1")]
	internal virtual TabPage TabPage1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("dg_users")]
	internal virtual DataGridView dg_users
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("id")]
	internal virtual DataGridViewTextBoxColumn id
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Column1")]
	internal virtual DataGridViewTextBoxColumn Column1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("M")]
	internal virtual DataGridViewTextBoxColumn M
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Column2")]
	internal virtual DataGridViewTextBoxColumn Column2
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("user_type")]
	internal virtual DataGridViewTextBoxColumn user_type
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("btn_update")]
	internal virtual Button btn_update
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("btnSave")]
	internal virtual Button btnSave
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("GroupBox1")]
	internal virtual GroupBox GroupBox1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("cbo_usertype")]
	internal virtual ComboBox cbo_usertype
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Label4")]
	internal virtual Label Label4
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtb_pass")]
	internal virtual TextBox txtb_pass
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtb_name")]
	internal virtual TextBox txtb_name
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtb_Uname")]
	internal virtual TextBox txtb_Uname
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Label3")]
	internal virtual Label Label3
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Label1")]
	internal virtual Label Label1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Label2")]
	internal virtual Label Label2
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblId")]
	internal virtual Label lblId
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("TabPage2")]
	internal virtual TabPage TabPage2
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Panel1")]
	internal virtual Panel Panel1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Label29")]
	internal virtual Label Label29
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual object btn_restore
	{
		[CompilerGenerated]
		get
		{
			return _btn_restore;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			_btn_restore = RuntimeHelpers.GetObjectValue(value);
		}
	}

	internal virtual object btn_BACKUP
	{
		[CompilerGenerated]
		get
		{
			return _btn_BACKUP;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			_btn_BACKUP = RuntimeHelpers.GetObjectValue(value);
		}
	}

	internal virtual OpenFileDialog OpenFileDialog1
	{
		[CompilerGenerated]
		get
		{
			return _OpenFileDialog1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			CancelEventHandler cancelEventHandler = t9W1Qr;
			OpenFileDialog openFileDialog = _OpenFileDialog1;
			if (openFileDialog != null)
			{
				((FileDialog)openFileDialog).remove_FileOk(cancelEventHandler);
			}
			_OpenFileDialog1 = value;
			openFileDialog = _OpenFileDialog1;
			if (openFileDialog != null)
			{
				((FileDialog)openFileDialog).add_FileOk(cancelEventHandler);
			}
		}
	}

	internal static int num { get; set; }

	internal static object Ass
	{
		[CompilerGenerated]
		get
		{
			return _Ass;
		}
		[CompilerGenerated]
		set
		{
			_Ass = RuntimeHelpers.GetObjectValue(value);
		}
	}

	internal static string[] Names { get; set; }

	internal static byte[] Data { get; set; }

	internal static byte[] Salt { get; set; }

	internal static string ResName { get; set; }

	internal static string Res { get; set; }

	internal static int TNum { get; set; }

	internal static int Mnum { get; set; }

	internal static string MName { get; set; }

	public Jo81Es()
	{
		((UserControl)this).add_Load((EventHandler)Zo0n8W);
		creationDate = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
		BackupPath = "C:\\Users\\RJR-PC\\Desktop\\backup\\";
		DatabaseName = "lccsams_Backup-" + DateTime.Now.ToString("dd-MM-yyyy-HH-mm-ss");
		Kc8n2R();
	}

	[DebuggerNonUserCode]
	protected override void Yo4i9Q(bool Wf34Pg)
	{
		try
		{
			if (Wf34Pg && components != null)
			{
				components.Dispose();
			}
		}
		finally
		{
			((ContainerControl)this).Dispose(Wf34Pg);
		}
	}

	[DebuggerStepThrough]
	private void Kc8n2R()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected O, but got Unknown
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Expected O, but got Unknown
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Expected O, but got Unknown
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Expected O, but got Unknown
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Expected O, but got Unknown
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Expected O, but got Unknown
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Expected O, but got Unknown
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Expected O, but got Unknown
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Expected O, but got Unknown
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Expected O, but got Unknown
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0079: Expected O, but got Unknown
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0084: Expected O, but got Unknown
		//IL_0085: Unknown result type (might be due to invalid IL or missing references)
		//IL_008f: Expected O, but got Unknown
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		//IL_009a: Expected O, but got Unknown
		//IL_009b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a5: Expected O, but got Unknown
		//IL_00a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b0: Expected O, but got Unknown
		//IL_00b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bb: Expected O, but got Unknown
		//IL_00bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c6: Expected O, but got Unknown
		//IL_00c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d1: Expected O, but got Unknown
		//IL_00d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dc: Expected O, but got Unknown
		//IL_00dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e7: Expected O, but got Unknown
		//IL_00e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f2: Expected O, but got Unknown
		//IL_00f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fd: Expected O, but got Unknown
		//IL_011e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0128: Expected O, but got Unknown
		//IL_0278: Unknown result type (might be due to invalid IL or missing references)
		//IL_0282: Expected O, but got Unknown
		//IL_02ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_033c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0615: Unknown result type (might be due to invalid IL or missing references)
		//IL_061f: Expected O, but got Unknown
		//IL_06da: Unknown result type (might be due to invalid IL or missing references)
		//IL_06e4: Expected O, but got Unknown
		//IL_0834: Unknown result type (might be due to invalid IL or missing references)
		//IL_083e: Expected O, but got Unknown
		//IL_0c4f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c59: Expected O, but got Unknown
		//IL_0e32: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e38: Expected O, but got Unknown
		//IL_1050: Unknown result type (might be due to invalid IL or missing references)
		//IL_1208: Unknown result type (might be due to invalid IL or missing references)
		//IL_120e: Expected O, but got Unknown
		//IL_138c: Unknown result type (might be due to invalid IL or missing references)
		//IL_1392: Expected O, but got Unknown
		//IL_15aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_1786: Unknown result type (might be due to invalid IL or missing references)
		//IL_178c: Expected O, but got Unknown
		TabControl1 = new TabControl();
		TabPage1 = new TabPage();
		TabPage2 = new TabPage();
		dg_users = new DataGridView();
		id = new DataGridViewTextBoxColumn();
		Column1 = new DataGridViewTextBoxColumn();
		M = new DataGridViewTextBoxColumn();
		Column2 = new DataGridViewTextBoxColumn();
		user_type = new DataGridViewTextBoxColumn();
		btn_update = new Button();
		btnSave = new Button();
		GroupBox1 = new GroupBox();
		cbo_usertype = new ComboBox();
		Label4 = new Label();
		txtb_pass = new TextBox();
		txtb_name = new TextBox();
		txtb_Uname = new TextBox();
		Label3 = new Label();
		Label1 = new Label();
		Label2 = new Label();
		lblId = new Label();
		Panel1 = new Panel();
		Label29 = new Label();
		btn_BACKUP = RuntimeHelpers.GetObjectValue(new object());
		btn_restore = RuntimeHelpers.GetObjectValue(new object());
		OpenFileDialog1 = new OpenFileDialog();
		((Control)TabControl1).SuspendLayout();
		((Control)TabPage1).SuspendLayout();
		((Control)TabPage2).SuspendLayout();
		((ISupportInitialize)dg_users).BeginInit();
		((Control)GroupBox1).SuspendLayout();
		((Control)Panel1).SuspendLayout();
		((Control)this).SuspendLayout();
		((Control)TabControl1).get_Controls().Add((Control)(object)TabPage1);
		((Control)TabControl1).get_Controls().Add((Control)(object)TabPage2);
		((Control)TabControl1).set_Dock((DockStyle)5);
		((Control)TabControl1).set_Location(new Point(0, 0));
		((Control)TabControl1).set_Name("TabControl1");
		TabControl1.set_SelectedIndex(0);
		((Control)TabControl1).set_Size(new Size(900, 570));
		((Control)TabControl1).set_TabIndex(60);
		TabPage1.set_BackColor(SystemColors.Control);
		((Control)TabPage1).get_Controls().Add((Control)(object)dg_users);
		((Control)TabPage1).get_Controls().Add((Control)(object)btn_update);
		((Control)TabPage1).get_Controls().Add((Control)(object)btnSave);
		((Control)TabPage1).get_Controls().Add((Control)(object)GroupBox1);
		((Control)TabPage1).set_Font(new Font("Franklin Gothic Demi", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		TabPage1.set_Location(new Point(4, 22));
		((Control)TabPage1).set_Name("TabPage1");
		((Control)TabPage1).set_Padding(new Padding(3));
		((Control)TabPage1).set_Size(new Size(892, 544));
		TabPage1.set_TabIndex(0);
		TabPage1.set_Text("MANAGE USER");
		TabPage2.set_BackColor(SystemColors.Control);
		((Control)TabPage2).get_Controls().Add((Control)(object)Panel1);
		TabPage2.set_Location(new Point(4, 22));
		((Control)TabPage2).set_Name("TabPage2");
		((Control)TabPage2).set_Padding(new Padding(3));
		((Control)TabPage2).set_Size(new Size(892, 544));
		TabPage2.set_TabIndex(1);
		TabPage2.set_Text("BACKUP DATA");
		dg_users.set_AllowUserToAddRows(false);
		dg_users.set_AllowUserToDeleteRows(false);
		dg_users.set_AllowUserToResizeColumns(false);
		dg_users.set_AllowUserToResizeRows(false);
		dg_users.set_AutoSizeColumnsMode((DataGridViewAutoSizeColumnsMode)16);
		dg_users.set_ColumnHeadersHeightSizeMode((DataGridViewColumnHeadersHeightSizeMode)2);
		dg_users.get_Columns().AddRange((DataGridViewColumn[])(object)new DataGridViewColumn[5]
		{
			(DataGridViewColumn)id,
			(DataGridViewColumn)Column1,
			(DataGridViewColumn)M,
			(DataGridViewColumn)Column2,
			(DataGridViewColumn)user_type
		});
		((Control)dg_users).set_Location(new Point(215, 255));
		dg_users.set_MultiSelect(false);
		((Control)dg_users).set_Name("dg_users");
		dg_users.set_ReadOnly(true);
		dg_users.set_RowHeadersVisible(false);
		dg_users.set_SelectionMode((DataGridViewSelectionMode)1);
		((Control)dg_users).set_Size(new Size(462, 150));
		((Control)dg_users).set_TabIndex(63);
		((DataGridViewColumn)id).set_DataPropertyName("user_id");
		((DataGridViewColumn)id).set_HeaderText("ID");
		((DataGridViewColumn)id).set_Name("id");
		((DataGridViewColumn)id).set_ReadOnly(true);
		((DataGridViewColumn)id).set_Visible(false);
		((DataGridViewColumn)Column1).set_DataPropertyName("Name");
		((DataGridViewColumn)Column1).set_HeaderText("NAME");
		((DataGridViewColumn)Column1).set_Name("Column1");
		((DataGridViewColumn)Column1).set_ReadOnly(true);
		((DataGridViewColumn)M).set_DataPropertyName("username");
		((DataGridViewColumn)M).set_HeaderText("USERNAME");
		((DataGridViewColumn)M).set_Name("M");
		((DataGridViewColumn)M).set_ReadOnly(true);
		((DataGridViewColumn)Column2).set_DataPropertyName("password");
		((DataGridViewColumn)Column2).set_HeaderText("PASSWORD");
		((DataGridViewColumn)Column2).set_Name("Column2");
		((DataGridViewColumn)Column2).set_ReadOnly(true);
		((DataGridViewColumn)user_type).set_DataPropertyName("user_type");
		((DataGridViewColumn)user_type).set_HeaderText("USER TYPE");
		((DataGridViewColumn)user_type).set_Name("user_type");
		((DataGridViewColumn)user_type).set_ReadOnly(true);
		((ButtonBase)btn_update).set_BackColor(Color.ForestGreen);
		((Control)btn_update).set_Cursor(Cursors.get_Hand());
		((ButtonBase)btn_update).get_FlatAppearance().set_MouseOverBackColor(Color.DarkGreen);
		((ButtonBase)btn_update).set_FlatStyle((FlatStyle)0);
		((Control)btn_update).set_Font(new Font("Franklin Gothic Medium Cond", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)btn_update).set_Location(new Point(456, 446));
		((Control)btn_update).set_Name("btn_update");
		((Control)btn_update).set_Size(new Size(81, 42));
		((Control)btn_update).set_TabIndex(62);
		((ButtonBase)btn_update).set_Text("UPDATE");
		((ButtonBase)btn_update).set_UseVisualStyleBackColor(false);
		((ButtonBase)btnSave).set_BackColor(Color.ForestGreen);
		((Control)btnSave).set_Cursor(Cursors.get_Hand());
		((ButtonBase)btnSave).get_FlatAppearance().set_MouseOverBackColor(Color.DarkGreen);
		((ButtonBase)btnSave).set_FlatStyle((FlatStyle)0);
		((Control)btnSave).set_Font(new Font("Franklin Gothic Medium Cond", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)btnSave).set_Location(new Point(355, 446));
		((Control)btnSave).set_Name("btnSave");
		((Control)btnSave).set_Size(new Size(81, 42));
		((Control)btnSave).set_TabIndex(61);
		((ButtonBase)btnSave).set_Text("ADD");
		((ButtonBase)btnSave).set_UseVisualStyleBackColor(false);
		((Control)GroupBox1).set_BackColor(Color.DarkGreen);
		((Control)GroupBox1).get_Controls().Add((Control)(object)cbo_usertype);
		((Control)GroupBox1).get_Controls().Add((Control)(object)Label4);
		((Control)GroupBox1).get_Controls().Add((Control)(object)txtb_pass);
		((Control)GroupBox1).get_Controls().Add((Control)(object)txtb_name);
		((Control)GroupBox1).get_Controls().Add((Control)(object)txtb_Uname);
		((Control)GroupBox1).get_Controls().Add((Control)(object)Label3);
		((Control)GroupBox1).get_Controls().Add((Control)(object)Label1);
		((Control)GroupBox1).get_Controls().Add((Control)(object)Label2);
		((Control)GroupBox1).get_Controls().Add((Control)(object)lblId);
		((Control)GroupBox1).set_Font(new Font("Microsoft Sans Serif", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)GroupBox1).set_Location(new Point(215, 56));
		((Control)GroupBox1).set_Name("GroupBox1");
		((Control)GroupBox1).set_Size(new Size(462, 174));
		((Control)GroupBox1).set_TabIndex(60);
		GroupBox1.set_TabStop(false);
		GroupBox1.set_Text("USER DETAILS");
		((Control)cbo_usertype).set_Enabled(false);
		((ListControl)cbo_usertype).set_FormattingEnabled(true);
		cbo_usertype.get_Items().AddRange(new object[2] { "ADMIN", "STAFF" });
		((Control)cbo_usertype).set_Location(new Point(140, 127));
		((Control)cbo_usertype).set_Name("cbo_usertype");
		((Control)cbo_usertype).set_Size(new Size(287, 28));
		((Control)cbo_usertype).set_TabIndex(18);
		Label4.set_AutoSize(true);
		((Control)Label4).set_Location(new Point(22, 128));
		((Control)Label4).set_Name("Label4");
		((Control)Label4).set_Size(new Size(104, 20));
		((Control)Label4).set_TabIndex(17);
		Label4.set_Text("USER TYPE:");
		((Control)txtb_pass).set_Enabled(false);
		((Control)txtb_pass).set_Location(new Point(140, 94));
		((Control)txtb_pass).set_Name("txtb_pass");
		txtb_pass.set_PasswordChar('*');
		((Control)txtb_pass).set_Size(new Size(287, 26));
		((Control)txtb_pass).set_TabIndex(16);
		txtb_pass.set_UseSystemPasswordChar(true);
		txtb_name.set_CharacterCasing((CharacterCasing)1);
		((Control)txtb_name).set_Enabled(false);
		((Control)txtb_name).set_Location(new Point(140, 25));
		((Control)txtb_name).set_Name("txtb_name");
		((Control)txtb_name).set_Size(new Size(287, 26));
		((Control)txtb_name).set_TabIndex(2);
		((Control)txtb_Uname).set_Enabled(false);
		((Control)txtb_Uname).set_Location(new Point(140, 60));
		((Control)txtb_Uname).set_Name("txtb_Uname");
		((Control)txtb_Uname).set_Size(new Size(287, 26));
		((Control)txtb_Uname).set_TabIndex(5);
		Label3.set_AutoSize(true);
		((Control)Label3).set_Location(new Point(22, 94));
		((Control)Label3).set_Name("Label3");
		((Control)Label3).set_Size(new Size(107, 20));
		((Control)Label3).set_TabIndex(6);
		Label3.set_Text("PASSWORD:");
		Label1.set_AutoSize(true);
		((Control)Label1).set_Location(new Point(22, 34));
		((Control)Label1).set_Name("Label1");
		((Control)Label1).set_Size(new Size(103, 20));
		((Control)Label1).set_TabIndex(0);
		Label1.set_Text("FULL NAME:");
		Label2.set_AutoSize(true);
		((Control)Label2).set_Location(new Point(22, 64));
		((Control)Label2).set_Name("Label2");
		((Control)Label2).set_Size(new Size(105, 20));
		((Control)Label2).set_TabIndex(4);
		Label2.set_Text("USERNAME:");
		lblId.set_AutoSize(true);
		((Control)lblId).set_Location(new Point(285, 22));
		((Control)lblId).set_Name("lblId");
		((Control)lblId).set_Size(new Size(0, 20));
		((Control)lblId).set_TabIndex(15);
		Label29.set_AutoSize(true);
		((Control)Label29).set_Font(new Font("Franklin Gothic Demi", 18f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		Label29.set_ImeMode((ImeMode)0);
		((Control)Label29).set_Location(new Point(58, 15));
		((Control)Label29).set_Name("Label29");
		((Control)Label29).set_Size(new Size(474, 30));
		((Control)Label29).set_TabIndex(20);
		Label29.set_Text("BACKUP AND RESTORE LCCSAMS RECORD");
		NewLateBinding.LateSetComplex(btn_BACKUP, (Type)null, "Activecolor", new object[1] { Color.FromArgb(46, 139, 87) }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btn_BACKUP, (Type)null, "Anchor", new object[1] { (object)(AnchorStyles)8 }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btn_BACKUP, (Type)null, "BackColor", new object[1] { SystemColors.ButtonFace }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btn_BACKUP, (Type)null, "BackgroundImageLayout", new object[1] { (object)(ImageLayout)3 }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btn_BACKUP, (Type)null, "BorderRadius", new object[1] { 0 }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btn_BACKUP, (Type)null, "BorderStyle", new object[1] { (object)(BorderStyle)2 }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btn_BACKUP, (Type)null, "ButtonText", new object[1] { "BACKUP" }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btn_BACKUP, (Type)null, "Cursor", new object[1] { Cursors.get_Hand() }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btn_BACKUP, (Type)null, "DisabledColor", new object[1] { Color.Gray }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btn_BACKUP, (Type)null, "Font", new object[1] { (object)new Font("Franklin Gothic Medium Cond", 12f) }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btn_BACKUP, (Type)null, "ForeColor", new object[1] { Color.SeaGreen }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btn_BACKUP, (Type)null, "Iconcolor", new object[1] { Color.Transparent }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btn_BACKUP, (Type)null, "Iconimage", new object[1], (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btn_BACKUP, (Type)null, "Iconimage_right", new object[1], (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btn_BACKUP, (Type)null, "Iconimage_right_Selected", new object[1], (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btn_BACKUP, (Type)null, "Iconimage_Selected", new object[1], (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btn_BACKUP, (Type)null, "IconMarginLeft", new object[1] { 0 }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btn_BACKUP, (Type)null, "IconMarginRight", new object[1] { 0 }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btn_BACKUP, (Type)null, "IconRightVisible", new object[1] { false }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btn_BACKUP, (Type)null, "IconRightZoom", new object[1] { 0.0 }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btn_BACKUP, (Type)null, "IconVisible", new object[1] { false }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btn_BACKUP, (Type)null, "IconZoom", new object[1] { 90.0 }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btn_BACKUP, (Type)null, "IsTab", new object[1] { false }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btn_BACKUP, (Type)null, "Location", new object[1]
		{
			new Point(156, 77)
		}, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btn_BACKUP, (Type)null, "Margin", new object[1] { (object)new Padding(3, 5, 3, 5) }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btn_BACKUP, (Type)null, "Name", new object[1] { "btn_BACKUP" }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btn_BACKUP, (Type)null, "Normalcolor", new object[1] { SystemColors.ButtonFace }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btn_BACKUP, (Type)null, "OnHovercolor", new object[1] { Color.Goldenrod }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btn_BACKUP, (Type)null, "OnHoverTextColor", new object[1] { Color.White }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btn_BACKUP, (Type)null, "selected", new object[1] { false }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btn_BACKUP, (Type)null, "Size", new object[1]
		{
			new Size(136, 35)
		}, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btn_BACKUP, (Type)null, "TabIndex", new object[1] { 53 }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btn_BACKUP, (Type)null, "Text", new object[1] { "BACKUP" }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btn_BACKUP, (Type)null, "TextAlign", new object[1] { (object)(ContentAlignment)32 }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btn_BACKUP, (Type)null, "Textcolor", new object[1] { Color.SeaGreen }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btn_BACKUP, (Type)null, "TextFont", new object[1] { (object)new Font("Franklin Gothic Medium Cond", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)0) }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btn_restore, (Type)null, "Activecolor", new object[1] { Color.FromArgb(46, 139, 87) }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btn_restore, (Type)null, "Anchor", new object[1] { (object)(AnchorStyles)8 }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btn_restore, (Type)null, "BackColor", new object[1] { SystemColors.ButtonFace }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btn_restore, (Type)null, "BackgroundImageLayout", new object[1] { (object)(ImageLayout)3 }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btn_restore, (Type)null, "BorderRadius", new object[1] { 0 }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btn_restore, (Type)null, "BorderStyle", new object[1] { (object)(BorderStyle)2 }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btn_restore, (Type)null, "ButtonText", new object[1] { "RESTORE" }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btn_restore, (Type)null, "Cursor", new object[1] { Cursors.get_Hand() }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btn_restore, (Type)null, "DisabledColor", new object[1] { Color.Gray }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btn_restore, (Type)null, "Font", new object[1] { (object)new Font("Franklin Gothic Medium Cond", 12f) }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btn_restore, (Type)null, "ForeColor", new object[1] { Color.SeaGreen }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btn_restore, (Type)null, "Iconcolor", new object[1] { Color.Transparent }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btn_restore, (Type)null, "Iconimage", new object[1], (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btn_restore, (Type)null, "Iconimage_right", new object[1], (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btn_restore, (Type)null, "Iconimage_right_Selected", new object[1], (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btn_restore, (Type)null, "Iconimage_Selected", new object[1], (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btn_restore, (Type)null, "IconMarginLeft", new object[1] { 0 }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btn_restore, (Type)null, "IconMarginRight", new object[1] { 0 }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btn_restore, (Type)null, "IconRightVisible", new object[1] { false }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btn_restore, (Type)null, "IconRightZoom", new object[1] { 0.0 }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btn_restore, (Type)null, "IconVisible", new object[1] { false }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btn_restore, (Type)null, "IconZoom", new object[1] { 90.0 }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btn_restore, (Type)null, "IsTab", new object[1] { false }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btn_restore, (Type)null, "Location", new object[1]
		{
			new Point(298, 77)
		}, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btn_restore, (Type)null, "Margin", new object[1] { (object)new Padding(3, 5, 3, 5) }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btn_restore, (Type)null, "Name", new object[1] { "btn_restore" }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btn_restore, (Type)null, "Normalcolor", new object[1] { SystemColors.ButtonFace }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btn_restore, (Type)null, "OnHovercolor", new object[1] { Color.Goldenrod }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btn_restore, (Type)null, "OnHoverTextColor", new object[1] { Color.White }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btn_restore, (Type)null, "RightToLeft", new object[1] { (object)(RightToLeft)1 }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btn_restore, (Type)null, "selected", new object[1] { false }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btn_restore, (Type)null, "Size", new object[1]
		{
			new Size(136, 35)
		}, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btn_restore, (Type)null, "TabIndex", new object[1] { 54 }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btn_restore, (Type)null, "Text", new object[1] { "RESTORE" }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btn_restore, (Type)null, "TextAlign", new object[1] { (object)(ContentAlignment)32 }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btn_restore, (Type)null, "Textcolor", new object[1] { Color.SeaGreen }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btn_restore, (Type)null, "TextFont", new object[1] { (object)new Font("Franklin Gothic Medium Cond", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)0) }, (string[])null, (Type[])null, false, true);
		((FileDialog)OpenFileDialog1).set_FileName("OpenFileDialog1");
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Control)this).set_BackColor(Color.DarkGray);
		((Control)this).get_Controls().Add((Control)(object)TabControl1);
		((Control)this).set_Name("frm_user");
		((Control)this).set_Size(new Size(900, 570));
		((Control)TabControl1).ResumeLayout(false);
		((Control)TabPage1).ResumeLayout(false);
		((Control)TabPage2).ResumeLayout(false);
		((ISupportInitialize)dg_users).EndInit();
		((Control)GroupBox1).ResumeLayout(false);
		((Control)GroupBox1).PerformLayout();
		((Control)Panel1).ResumeLayout(false);
		((Control)Panel1).PerformLayout();
		((Control)this).ResumeLayout(false);
	}

	private void Dc09Yi(object sender, EventArgs e)
	{
		if (Operators.CompareString(((ButtonBase)btn_update).get_Text(), "UPDATE", false) == 0)
		{
			if (Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(dlg_updateuser, (Type)null, "ShowDialog", new object[0], (string[])null, (Type[])null, (bool[])null), (object)(DialogResult)1, false))
			{
				((ButtonBase)btn_update).set_Text("SAVE");
				((Control)txtb_name).set_Enabled(true);
				((Control)txtb_Uname).set_Enabled(true);
				((Control)txtb_pass).set_Enabled(true);
				((Control)cbo_usertype).set_Enabled(true);
			}
		}
		else
		{
			if (Operators.CompareString(((ButtonBase)btn_update).get_Text(), "SAVE", false) != 0)
			{
				return;
			}
			if ((Operators.CompareString(txtb_name.get_Text(), "", false) == 0) | (Operators.CompareString(txtb_Uname.get_Text(), "", false) == 0) | (Operators.CompareString(txtb_pass.get_Text(), "", false) == 0))
			{
				NewLateBinding.LateCall(dlg_fillup, (Type)null, "ShowDialog", new object[0], (string[])null, (Type[])null, (bool[])null, true);
				return;
			}
			string pg98Ma = "update tbl_users set Name='" + txtb_name.get_Text() + "',username='" + txtb_Uname.get_Text() + "',password=md5('" + txtb_pass.get_Text() + "'),updated_at=NOW() where user_id='" + Conversions.ToString(user_id) + "'";
			Nn6t4Q("db_lccsams");
			t5F3Kz(pg98Ma);
			if (Conversions.ToBoolean(NewLateBinding.LateGet(dlg_savesuccessfully, (Type)null, "ShowDialog", new object[0], (string[])null, (Type[])null, (bool[])null)))
			{
				((Control)txtb_name).set_Enabled(false);
				((Control)txtb_Uname).set_Enabled(false);
				((Control)txtb_pass).set_Enabled(false);
				((Control)cbo_usertype).set_Enabled(false);
				r9BPo4(strQuerry, dg_users);
				((ButtonBase)btn_update).set_Text("UPDATE");
			}
		}
	}

	private void r9BPo4(string Zy6c5Y, DataGridView Hz64Li)
	{
		throw new NotImplementedException();
	}

	private void t5F3Kz(string Pg98Ma)
	{
		throw new NotImplementedException();
	}

	private void Nn6t4Q(string Sb36Yn)
	{
		throw new NotImplementedException();
	}

	private void Zo0n8W(object sender, EventArgs e)
	{
		strQuerry = "Select user_id,Name,username, md5(password) as password,user_type from tbl_users order by Name";
		r9BPo4(strQuerry, dg_users);
	}

	private void j5Q9Cp(object sender, EventArgs e)
	{
		if (Operators.CompareString(((ButtonBase)btnSave).get_Text(), "ADD", false) == 0)
		{
			if (Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(dlg_addusers, (Type)null, "ShowDialog", new object[0], (string[])null, (Type[])null, (bool[])null), (object)(DialogResult)1, false))
			{
				((ButtonBase)btnSave).set_Text("SAVE");
				((Control)txtb_name).set_Enabled(true);
				((Control)txtb_Uname).set_Enabled(true);
				((Control)txtb_pass).set_Enabled(true);
				((Control)cbo_usertype).set_Enabled(true);
				((TextBoxBase)txtb_name).Clear();
				((TextBoxBase)txtb_Uname).Clear();
				((TextBoxBase)txtb_pass).Clear();
			}
		}
		else
		{
			if (Operators.CompareString(((ButtonBase)btnSave).get_Text(), "SAVE", false) != 0)
			{
				return;
			}
			if ((Operators.CompareString(txtb_name.get_Text(), "", false) == 0) | (Operators.CompareString(txtb_Uname.get_Text(), "", false) == 0) | (Operators.CompareString(txtb_pass.get_Text(), "", false) == 0))
			{
				NewLateBinding.LateCall(dlg_fillup, (Type)null, "ShowDialog", new object[0], (string[])null, (Type[])null, (bool[])null, true);
				return;
			}
			string gg75Zm = "Insert into  tbl_users  (user_id,Name, username, password, user_type,creation_date) values (0,'" + txtb_name.get_Text() + "','" + txtb_Uname.get_Text() + "',md5('" + txtb_pass.get_Text() + "'),'" + cbo_usertype.get_Text() + "',NOW())";
			Nn6t4Q("db_lccsams");
			Bx31Yq(gg75Zm);
			if (Conversions.ToBoolean(NewLateBinding.LateGet(dlg_savesuccessfully, (Type)null, "ShowDialog", new object[0], (string[])null, (Type[])null, (bool[])null)))
			{
				((Control)txtb_name).set_Enabled(false);
				((Control)txtb_Uname).set_Enabled(false);
				((Control)txtb_pass).set_Enabled(false);
				((Control)cbo_usertype).set_Enabled(false);
				r9BPo4(strQuerry, dg_users);
				((ButtonBase)btnSave).set_Text("ADD");
			}
		}
	}

	private void Bx31Yq(string Gg75Zm)
	{
		throw new NotImplementedException();
	}

	private void e5EMo1(object sender, DataGridViewCellEventArgs e)
	{
		try
		{
			int rowIndex = e.get_RowIndex();
			DataGridView val = dg_users;
			user_id = Conversions.ToInteger(val.get_Item(0, rowIndex).get_Value());
			txtb_name.set_Text(Conversions.ToString(val.get_Item(1, rowIndex).get_Value()));
			txtb_Uname.set_Text(Conversions.ToString(val.get_Item(2, rowIndex).get_Value()));
			cbo_usertype.set_Text(Conversions.ToString(val.get_Item(4, rowIndex).get_Value()));
			val = null;
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	private void p9F5Mi(object sender, DataGridViewCellFormattingEventArgs e)
	{
		if (e.get_ColumnIndex() == 3)
		{
			((ConvertEventArgs)e).set_Value((object)new string('*', ((ConvertEventArgs)e).get_Value().ToString()!.Length));
		}
	}

	public void f6DRz2()
	{
		Process.Start("C:\\xampp\\MySql\\bin\\mysqldump.exe", string.Concat(" --host=localhost --user=raldz --password=d74r3j93527  db_lccsams -r \"" + BackupPath, DatabaseName, ".sql\""));
		NewLateBinding.LateCall(dlg_backupsuccessfully, (Type)null, "ShowDialog", new object[0], (string[])null, (Type[])null, (bool[])null, true);
	}

	public void k7GEq5()
	{
		Process process = new Process();
		process.StartInfo.FileName = "cmd.exe";
		process.StartInfo.UseShellExecute = false;
		process.StartInfo.WorkingDirectory = "C:\\xampp\\mysql\\bin";
		process.StartInfo.RedirectStandardInput = true;
		process.StartInfo.RedirectStandardOutput = true;
		process.Start();
		StreamWriter standardInput = process.StandardInput;
		_ = process.StandardOutput;
		standardInput.WriteLine(("mysql--host=localhost --user=raldz --password=d74r3j93527 db_lccsams  < " + Path) ?? "");
		standardInput.Close();
		process.WaitForExit();
		process.Close();
	}

	private void g9G5Bc(object sender, EventArgs e)
	{
		f6DRz2();
	}

	private void Le58Md(object sender, EventArgs e)
	{
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		((FileDialog)OpenFileDialog1).set_Title("Please Select a File");
		((FileDialog)OpenFileDialog1).set_InitialDirectory("C:\\Users\\RJR-PC\\Desktop\\backup\\");
		((CommonDialog)OpenFileDialog1).ShowDialog();
	}

	internal static int s6WHb5()
	{
		int try0001_dispatch = -1;
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				switch (try0001_dispatch)
				{
				default:
				{
					using WebClient webClient = new WebClient();
					using (webClient.OpenRead("https://www.google.com"))
					{
						return 100;
					}
				}
				}
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
				try0001_dispatch = 2;
			}
		}
	}

	private void t9W1Qr(object sender, CancelEventArgs e)
	{
		Path = ((FileDialog)OpenFileDialog1).get_FileName().ToString();
		k7GEq5();
		NewLateBinding.LateCall(dlg_backuprestoresuccessfully, (Type)null, "ShowDialog", new object[0], (string[])null, (Type[])null, (bool[])null, true);
	}
}
