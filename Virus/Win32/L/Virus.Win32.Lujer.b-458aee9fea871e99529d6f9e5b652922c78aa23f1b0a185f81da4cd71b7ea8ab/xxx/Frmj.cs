using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using DevComponents.DotNetBar.Controls;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using xxx.My;

namespace xxx;

[DesignerGenerated]
public class Frmj : Office2007Form
{
	private IContainer components;

	[AccessedThroughProperty("LabelX1")]
	private LabelX _LabelX1;

	[AccessedThroughProperty("Tbxczz")]
	private TextBoxX _Tbxczz;

	[AccessedThroughProperty("btnOK")]
	private ButtonX _btnOK;

	[AccessedThroughProperty("LabelX2")]
	private LabelX _LabelX2;

	[AccessedThroughProperty("btnqx")]
	private ButtonX _btnqx;

	[AccessedThroughProperty("PB")]
	private PictureBox _PB;

	[AccessedThroughProperty("Cmbm")]
	private ComboBoxEx _Cmbm;

	private string ff;

	private string log;

	private string[] nn;

	internal virtual LabelX LabelX1
	{
		[DebuggerNonUserCode]
		get
		{
			return _LabelX1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_LabelX1 = value;
		}
	}

	internal virtual TextBoxX Tbxczz
	{
		[DebuggerNonUserCode]
		get
		{
			return _Tbxczz;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Tbxczz = value;
		}
	}

	internal virtual ButtonX btnOK
	{
		[DebuggerNonUserCode]
		get
		{
			return _btnOK;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = btnOK_Click;
			if (_btnOK != null)
			{
				((Control)_btnOK).remove_Click(eventHandler);
			}
			_btnOK = value;
			if (_btnOK != null)
			{
				((Control)_btnOK).add_Click(eventHandler);
			}
		}
	}

	internal virtual LabelX LabelX2
	{
		[DebuggerNonUserCode]
		get
		{
			return _LabelX2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_LabelX2 = value;
		}
	}

	internal virtual ButtonX btnqx
	{
		[DebuggerNonUserCode]
		get
		{
			return _btnqx;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = btnqx_Click;
			if (_btnqx != null)
			{
				((Control)_btnqx).remove_Click(eventHandler);
			}
			_btnqx = value;
			if (_btnqx != null)
			{
				((Control)_btnqx).add_Click(eventHandler);
			}
		}
	}

	public virtual PictureBox PB
	{
		[DebuggerNonUserCode]
		get
		{
			return _PB;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_PB = value;
		}
	}

	public virtual ComboBoxEx Cmbm
	{
		[DebuggerNonUserCode]
		get
		{
			return _Cmbm;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Cmbm = value;
		}
	}

	[DebuggerNonUserCode]
	public Frmj()
	{
		((Form)this).add_Load((EventHandler)Frmj_Load);
		InitializeComponent();
	}

	[DebuggerNonUserCode]
	protected override void Dispose(bool disposing)
	{
		try
		{
			if (disposing && components != null)
			{
				components.Dispose();
			}
		}
		finally
		{
			((Office2007Form)this).Dispose(disposing);
		}
	}

	[DebuggerStepThrough]
	private void InitializeComponent()
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
		//IL_009b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a5: Expected O, but got Unknown
		//IL_013f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0149: Expected O, but got Unknown
		//IL_01d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e0: Expected O, but got Unknown
		//IL_0289: Unknown result type (might be due to invalid IL or missing references)
		//IL_0293: Expected O, but got Unknown
		//IL_032f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0339: Expected O, but got Unknown
		//IL_03e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ee: Expected O, but got Unknown
		//IL_04f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0500: Expected O, but got Unknown
		//IL_059d: Unknown result type (might be due to invalid IL or missing references)
		//IL_05a7: Expected O, but got Unknown
		LabelX1 = new LabelX();
		Tbxczz = new TextBoxX();
		btnOK = new ButtonX();
		LabelX2 = new LabelX();
		btnqx = new ButtonX();
		Cmbm = new ComboBoxEx();
		PB = new PictureBox();
		((ISupportInitialize)PB).BeginInit();
		((Control)this).SuspendLayout();
		((BaseItemControl)LabelX1).get_BackgroundStyle().set_Class("");
		((BaseItemControl)LabelX1).get_BackgroundStyle().set_CornerType((eCornerType)1);
		((Control)LabelX1).set_Font(new Font("宋体", 9f, (FontStyle)0, (GraphicsUnit)3, (byte)134));
		LabelX labelX = LabelX1;
		Point location = new Point(12, 384);
		((Control)labelX).set_Location(location);
		((Control)LabelX1).set_Name("LabelX1");
		LabelX labelX2 = LabelX1;
		Size size = new Size(48, 23);
		((Control)labelX2).set_Size(size);
		((Control)LabelX1).set_TabIndex(0);
		LabelX1.set_Text("操作者");
		Tbxczz.get_Border().set_Class("TextBoxBorder");
		Tbxczz.get_Border().set_CornerType((eCornerType)1);
		((Control)Tbxczz).set_Font(new Font("宋体", 9f, (FontStyle)0, (GraphicsUnit)3, (byte)134));
		TextBoxX tbxczz = Tbxczz;
		location = new Point(57, 383);
		((Control)tbxczz).set_Location(location);
		((Control)Tbxczz).set_Name("Tbxczz");
		TextBoxX tbxczz2 = Tbxczz;
		size = new Size(96, 21);
		((Control)tbxczz2).set_Size(size);
		((Control)Tbxczz).set_TabIndex(0);
		((TextBox)Tbxczz).set_Text("Admin");
		((Control)btnOK).set_AccessibleRole((AccessibleRole)43);
		btnOK.set_ColorTable((eButtonColor)3);
		((Control)btnOK).set_Font(new Font("宋体", 9f, (FontStyle)0, (GraphicsUnit)3, (byte)134));
		ButtonX obj = btnOK;
		location = new Point(306, 382);
		((Control)obj).set_Location(location);
		((Control)btnOK).set_Name("btnOK");
		ButtonX obj2 = btnOK;
		size = new Size(95, 23);
		((Control)obj2).set_Size(size);
		((PopupItemControl)btnOK).set_Style((eDotNetBarStyle)7);
		((Control)btnOK).set_TabIndex(2);
		btnOK.set_Text("确 定");
		((BaseItemControl)LabelX2).get_BackgroundStyle().set_Class("");
		((BaseItemControl)LabelX2).get_BackgroundStyle().set_CornerType((eCornerType)1);
		((Control)LabelX2).set_Font(new Font("宋体", 9f, (FontStyle)0, (GraphicsUnit)3, (byte)134));
		LabelX labelX3 = LabelX2;
		location = new Point(159, 383);
		((Control)labelX3).set_Location(location);
		((Control)LabelX2).set_Name("LabelX2");
		LabelX labelX4 = LabelX2;
		size = new Size(48, 23);
		((Control)labelX4).set_Size(size);
		((Control)LabelX2).set_TabIndex(0);
		LabelX2.set_Text("部  门");
		((Control)btnqx).set_AccessibleRole((AccessibleRole)43);
		btnqx.set_ColorTable((eButtonColor)3);
		btnqx.set_DialogResult((DialogResult)2);
		((Control)btnqx).set_Font(new Font("宋体", 9f, (FontStyle)0, (GraphicsUnit)3, (byte)134));
		ButtonX obj3 = btnqx;
		location = new Point(417, 382);
		((Control)obj3).set_Location(location);
		((Control)btnqx).set_Name("btnqx");
		ButtonX obj4 = btnqx;
		size = new Size(95, 23);
		((Control)obj4).set_Size(size);
		((PopupItemControl)btnqx).set_Style((eDotNetBarStyle)7);
		((Control)btnqx).set_TabIndex(3);
		btnqx.set_Text("退 出");
		((ListControl)Cmbm).set_DisplayMember("Text");
		((ComboBox)Cmbm).set_DrawMode((DrawMode)1);
		((ComboBox)Cmbm).set_DropDownStyle((ComboBoxStyle)2);
		((Control)Cmbm).set_Font(new Font("宋体", 9f, (FontStyle)0, (GraphicsUnit)3, (byte)134));
		((ComboBox)Cmbm).set_ItemHeight(15);
		ComboBoxEx cmbm = Cmbm;
		location = new Point(204, 383);
		((Control)cmbm).set_Location(location);
		((Control)Cmbm).set_Name("Cmbm");
		ComboBoxEx cmbm2 = Cmbm;
		size = new Size(96, 21);
		((Control)cmbm2).set_Size(size);
		Cmbm.set_Style((eDotNetBarStyle)7);
		((Control)Cmbm).set_TabIndex(1);
		PictureBox pB = PB;
		location = new Point(12, 0);
		((Control)pB).set_Location(location);
		((Control)PB).set_Name("PB");
		PictureBox pB2 = PB;
		size = new Size(500, 375);
		((Control)pB2).set_Size(size);
		PB.set_SizeMode((PictureBoxSizeMode)3);
		PB.set_TabIndex(4);
		PB.set_TabStop(false);
		((Form)this).set_AcceptButton((IButtonControl)(object)btnOK);
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)0);
		((Form)this).set_AutoSizeMode((AutoSizeMode)0);
		((Form)this).set_CancelButton((IButtonControl)(object)btnqx);
		((Office2007Form)this).set_CaptionFont(new Font("宋体", 9f, (FontStyle)0, (GraphicsUnit)3, (byte)134));
		size = new Size(523, 413);
		((Form)this).set_ClientSize(size);
		((Control)this).get_Controls().Add((Control)(object)PB);
		((Control)this).get_Controls().Add((Control)(object)Cmbm);
		((Control)this).get_Controls().Add((Control)(object)btnqx);
		((Control)this).get_Controls().Add((Control)(object)btnOK);
		((Control)this).get_Controls().Add((Control)(object)Tbxczz);
		((Control)this).get_Controls().Add((Control)(object)LabelX1);
		((Control)this).get_Controls().Add((Control)(object)LabelX2);
		((Control)this).set_Font(new Font("宋体", 9f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Form)this).set_FormBorderStyle((FormBorderStyle)3);
		((Form)this).set_MaximizeBox(false);
		((Form)this).set_MinimizeBox(false);
		((Control)this).set_Name("Frmj");
		((Form)this).set_StartPosition((FormStartPosition)1);
		((ISupportInitialize)PB).EndInit();
		((Control)this).ResumeLayout(false);
	}

	private void btnOK_Click(object sender, EventArgs e)
	{
		if (Operators.CompareString(Strings.Trim(((TextBox)Tbxczz).get_Text()), "", false) == 0)
		{
			((TextBox)Tbxczz).set_Text("Admin");
		}
		ff = Conversions.ToString(DateTime.Now) + " 操作员：" + ((TextBox)Tbxczz).get_Text() + " 进入系统 所属部门：" + ((ComboBox)Cmbm).get_Text();
		MyProject.Forms.Main.lslog.get_Items().Add((object)ff);
		MyProject.Forms.Main.lslog.get_Items().Add((object)"操作过程如下：");
		((Control)MyProject.Forms.Main).Show();
		((Control)this).Hide();
	}

	private void btnqx_Click(object sender, EventArgs e)
	{
		Application.Exit();
	}

	private void Frmj_Load(object sender, EventArgs e)
	{
		//IL_008d: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d4: Unknown result type (might be due to invalid IL or missing references)
		string fileNameWithoutExtension = Path.GetFileNameWithoutExtension(Application.get_ExecutablePath());
		((Control)btnOK).set_Enabled(true);
		if (Mod1.banben())
		{
			if (Process.GetProcessesByName(fileNameWithoutExtension).LongCount() <= 1L)
			{
				Mod1.processExcel();
				if (Directory.Exists(Mod1.Kulujing))
				{
					Mod1.copymblis();
					return;
				}
				((Control)btnOK).set_Enabled(false);
				((Control)Tbxczz).set_Enabled(false);
				((Control)Cmbm).set_Enabled(false);
				Interaction.MsgBox((object)("当前不存在合法的库路径！" + Mod1.Kulujing), (MsgBoxStyle)64, (object)"提示");
			}
			else
			{
				((Control)btnOK).set_Enabled(false);
				((Control)Tbxczz).set_Enabled(false);
				((Control)Cmbm).set_Enabled(false);
				Interaction.MsgBox((object)("用户已经已经打开本程序 " + Mod1.bb + "，请勿重复操作！"), (MsgBoxStyle)64, (object)"提示");
			}
		}
		else
		{
			((Control)btnOK).set_Enabled(false);
			((Control)Tbxczz).set_Enabled(false);
			((Control)Cmbm).set_Enabled(false);
		}
	}
}
