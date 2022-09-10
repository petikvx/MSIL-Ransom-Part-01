using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using DevComponents.DotNetBar.Controls;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using xxx.My;

namespace xxx;

[DesignerGenerated]
public class jsbaogao : Office2007Form
{
	private IContainer components;

	[AccessedThroughProperty("Label2")]
	private Label _Label2;

	[AccessedThroughProperty("WizardPage3")]
	private WizardPage _WizardPage3;

	[AccessedThroughProperty("Label1")]
	private Label _Label1;

	[AccessedThroughProperty("Label3")]
	private Label _Label3;

	[AccessedThroughProperty("WizardPage1")]
	private WizardPage _WizardPage1;

	[AccessedThroughProperty("CBXchuli")]
	private CheckBoxX _CBXchuli;

	[AccessedThroughProperty("Wizard1")]
	private Wizard _Wizard1;

	[AccessedThroughProperty("WizardPage2")]
	private WizardPage _WizardPage2;

	[AccessedThroughProperty("SelectDir")]
	private ButtonX _SelectDir;

	[AccessedThroughProperty("txtPath")]
	private TextBoxX _txtPath;

	[AccessedThroughProperty("PBX1")]
	private ProgressBarX _PBX1;

	[AccessedThroughProperty("lbjd")]
	private LabelX _lbjd;

	[AccessedThroughProperty("lb1")]
	private ListBox _lb1;

	[AccessedThroughProperty("CBXlog")]
	private CheckBoxX _CBXlog;

	[AccessedThroughProperty("btnstop")]
	private ButtonX _btnstop;

	internal virtual Label Label2
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label2 = value;
		}
	}

	internal virtual WizardPage WizardPage3
	{
		[DebuggerNonUserCode]
		get
		{
			return _WizardPage3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_WizardPage3 = value;
		}
	}

	internal virtual Label Label1
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label1 = value;
		}
	}

	internal virtual Label Label3
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label3 = value;
		}
	}

	internal virtual WizardPage WizardPage1
	{
		[DebuggerNonUserCode]
		get
		{
			return _WizardPage1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_WizardPage1 = value;
		}
	}

	internal virtual CheckBoxX CBXchuli
	{
		[DebuggerNonUserCode]
		get
		{
			return _CBXchuli;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_CBXchuli = value;
		}
	}

	internal virtual Wizard Wizard1
	{
		[DebuggerNonUserCode]
		get
		{
			return _Wizard1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Wizard1 = value;
		}
	}

	internal virtual WizardPage WizardPage2
	{
		[DebuggerNonUserCode]
		get
		{
			return _WizardPage2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			CancelEventHandler cancelEventHandler = WizardPage2_FinishButtonClick;
			if (_WizardPage2 != null)
			{
				_WizardPage2.remove_FinishButtonClick(cancelEventHandler);
			}
			_WizardPage2 = value;
			if (_WizardPage2 != null)
			{
				_WizardPage2.add_FinishButtonClick(cancelEventHandler);
			}
		}
	}

	internal virtual ButtonX SelectDir
	{
		[DebuggerNonUserCode]
		get
		{
			return _SelectDir;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = SelectDir_Click;
			if (_SelectDir != null)
			{
				((Control)_SelectDir).remove_Click(eventHandler);
			}
			_SelectDir = value;
			if (_SelectDir != null)
			{
				((Control)_SelectDir).add_Click(eventHandler);
			}
		}
	}

	internal virtual TextBoxX txtPath
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtPath;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtPath = value;
		}
	}

	public virtual ProgressBarX PBX1
	{
		[DebuggerNonUserCode]
		get
		{
			return _PBX1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_PBX1 = value;
		}
	}

	public virtual LabelX lbjd
	{
		[DebuggerNonUserCode]
		get
		{
			return _lbjd;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lbjd = value;
		}
	}

	public virtual ListBox lb1
	{
		[DebuggerNonUserCode]
		get
		{
			return _lb1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lb1 = value;
		}
	}

	internal virtual CheckBoxX CBXlog
	{
		[DebuggerNonUserCode]
		get
		{
			return _CBXlog;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_CBXlog = value;
		}
	}

	internal virtual ButtonX btnstop
	{
		[DebuggerNonUserCode]
		get
		{
			return _btnstop;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = btnstop_Click;
			if (_btnstop != null)
			{
				((Control)_btnstop).remove_Click(eventHandler);
			}
			_btnstop = value;
			if (_btnstop != null)
			{
				((Control)_btnstop).add_Click(eventHandler);
			}
		}
	}

	[DebuggerNonUserCode]
	public jsbaogao()
	{
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Expected O, but got Unknown
		((Form)this).add_Load((EventHandler)jsbaogao_Load);
		((Form)this).add_FormClosed(new FormClosedEventHandler(jsbaogao_FormClosed));
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
		//IL_03af: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b9: Expected O, but got Unknown
		//IL_0506: Unknown result type (might be due to invalid IL or missing references)
		//IL_0510: Expected O, but got Unknown
		//IL_0816: Unknown result type (might be due to invalid IL or missing references)
		//IL_0820: Expected O, but got Unknown
		//IL_0885: Unknown result type (might be due to invalid IL or missing references)
		//IL_088f: Expected O, but got Unknown
		//IL_08a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_08b0: Expected O, but got Unknown
		//IL_0dfe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e08: Expected O, but got Unknown
		//IL_0e44: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e4e: Expected O, but got Unknown
		Label2 = new Label();
		PBX1 = new ProgressBarX();
		lbjd = new LabelX();
		WizardPage3 = new WizardPage();
		Label1 = new Label();
		Label3 = new Label();
		WizardPage1 = new WizardPage();
		SelectDir = new ButtonX();
		txtPath = new TextBoxX();
		CBXchuli = new CheckBoxX();
		Wizard1 = new Wizard();
		WizardPage2 = new WizardPage();
		btnstop = new ButtonX();
		CBXlog = new CheckBoxX();
		lb1 = new ListBox();
		((Control)WizardPage3).SuspendLayout();
		((Control)WizardPage1).SuspendLayout();
		((Control)Wizard1).SuspendLayout();
		((Control)WizardPage2).SuspendLayout();
		((Control)this).SuspendLayout();
		((Control)Label2).set_Anchor((AnchorStyles)15);
		((Control)Label2).set_BackColor(Color.Transparent);
		Label label = Label2;
		Point location = new Point(210, 100);
		((Control)label).set_Location(location);
		((Control)Label2).set_Name("Label2");
		Label label2 = Label2;
		Size size = new Size(290, 142);
		((Control)label2).set_Size(size);
		((Control)Label2).set_TabIndex(1);
		Label2.set_Text("本向导可以帮助您自动建立\"计算报告\"WORD文件");
		((BaseItemControl)PBX1).get_BackgroundStyle().set_Class("");
		((BaseItemControl)PBX1).get_BackgroundStyle().set_CornerType((eCornerType)1);
		ProgressBarX pBX = PBX1;
		location = new Point(0, 178);
		((Control)pBX).set_Location(location);
		((Control)PBX1).set_Name("PBX1");
		ProgressBarX pBX2 = PBX1;
		size = new Size(456, 23);
		((Control)pBX2).set_Size(size);
		((Control)PBX1).set_TabIndex(5);
		((BaseItemControl)lbjd).get_BackgroundStyle().set_Class("");
		((BaseItemControl)lbjd).get_BackgroundStyle().set_CornerType((eCornerType)1);
		LabelX obj = lbjd;
		location = new Point(462, 178);
		((Control)obj).set_Location(location);
		((Control)lbjd).set_Name("lbjd");
		LabelX obj2 = lbjd;
		size = new Size(35, 23);
		((Control)obj2).set_Size(size);
		((Control)lbjd).set_TabIndex(6);
		lbjd.set_Text("0%");
		((Control)WizardPage3).set_Anchor((AnchorStyles)15);
		WizardPage3.set_BackColor(Color.Transparent);
		((Control)WizardPage3).get_Controls().Add((Control)(object)Label1);
		((Control)WizardPage3).get_Controls().Add((Control)(object)Label2);
		((Control)WizardPage3).get_Controls().Add((Control)(object)Label3);
		WizardPage3.set_InteriorPage(false);
		WizardPage wizardPage = WizardPage3;
		location = new Point(0, 0);
		((Control)wizardPage).set_Location(location);
		((Control)WizardPage3).set_Name("WizardPage3");
		WizardPage wizardPage2 = WizardPage3;
		size = new Size(600, 338);
		((Control)wizardPage2).set_Size(size);
		((PanelControl)WizardPage3).get_Style().set_Class("");
		((PanelControl)WizardPage3).get_Style().set_CornerType((eCornerType)1);
		((PanelControl)WizardPage3).get_StyleMouseDown().set_Class("");
		((PanelControl)WizardPage3).get_StyleMouseDown().set_CornerType((eCornerType)1);
		((PanelControl)WizardPage3).get_StyleMouseOver().set_Class("");
		((PanelControl)WizardPage3).get_StyleMouseOver().set_CornerType((eCornerType)1);
		((Control)WizardPage3).set_TabIndex(9);
		((Control)Label1).set_Anchor((AnchorStyles)13);
		((Control)Label1).set_BackColor(Color.Transparent);
		((Control)Label1).set_Font(new Font("Tahoma", 16f));
		Label label3 = Label1;
		location = new Point(210, 18);
		((Control)label3).set_Location(location);
		((Control)Label1).set_Name("Label1");
		Label label4 = Label1;
		size = new Size(376, 66);
		((Control)label4).set_Size(size);
		((Control)Label1).set_TabIndex(0);
		Label1.set_Text("欢迎使用计算报告生成向导...");
		((Control)Label3).set_Anchor((AnchorStyles)6);
		((Control)Label3).set_BackColor(Color.Transparent);
		Label label5 = Label3;
		location = new Point(210, 301);
		((Control)label5).set_Location(location);
		((Control)Label3).set_Name("Label3");
		Label label6 = Label3;
		size = new Size(234, 15);
		((Control)label6).set_Size(size);
		((Control)Label3).set_TabIndex(2);
		Label3.set_Text("单击\"下一步\"开始填写基本信息");
		((Control)WizardPage1).set_Anchor((AnchorStyles)15);
		WizardPage1.set_BackColor(Color.Transparent);
		((PanelControl)WizardPage1).set_ColorSchemeStyle((eDotNetBarStyle)4);
		((Control)WizardPage1).get_Controls().Add((Control)(object)SelectDir);
		((Control)WizardPage1).get_Controls().Add((Control)(object)txtPath);
		((Control)WizardPage1).set_Font(new Font("宋体", 9f, (FontStyle)0, (GraphicsUnit)3, (byte)134));
		WizardPage wizardPage3 = WizardPage1;
		location = new Point(7, 102);
		((Control)wizardPage3).set_Location(location);
		((Control)WizardPage1).set_Name("WizardPage1");
		WizardPage1.set_PageTitle("性能表文件夹");
		WizardPage wizardPage4 = WizardPage1;
		size = new Size(586, 224);
		((Control)wizardPage4).set_Size(size);
		((PanelControl)WizardPage1).get_Style().set_Class("");
		((PanelControl)WizardPage1).get_Style().set_CornerType((eCornerType)1);
		((PanelControl)WizardPage1).get_StyleMouseDown().set_Class("");
		((PanelControl)WizardPage1).get_StyleMouseDown().set_CornerType((eCornerType)1);
		((PanelControl)WizardPage1).get_StyleMouseOver().set_Class("");
		((PanelControl)WizardPage1).get_StyleMouseOver().set_CornerType((eCornerType)1);
		((Control)WizardPage1).set_TabIndex(10);
		((Control)SelectDir).set_AccessibleRole((AccessibleRole)43);
		SelectDir.set_ColorTable((eButtonColor)3);
		ButtonX selectDir = SelectDir;
		location = new Point(356, 26);
		((Control)selectDir).set_Location(location);
		((Control)SelectDir).set_Name("SelectDir");
		ButtonX selectDir2 = SelectDir;
		size = new Size(75, 23);
		((Control)selectDir2).set_Size(size);
		((PopupItemControl)SelectDir).set_Style((eDotNetBarStyle)7);
		((Control)SelectDir).set_TabIndex(1);
		SelectDir.set_Text("选择文件夹");
		txtPath.get_Border().set_Class("TextBoxBorder");
		txtPath.get_Border().set_CornerType((eCornerType)1);
		TextBoxX obj3 = txtPath;
		location = new Point(125, 26);
		((Control)obj3).set_Location(location);
		((Control)txtPath).set_Name("txtPath");
		((TextBoxBase)txtPath).set_ReadOnly(true);
		TextBoxX obj4 = txtPath;
		size = new Size(225, 21);
		((Control)obj4).set_Size(size);
		((Control)txtPath).set_TabIndex(0);
		((BaseItemControl)CBXchuli).get_BackgroundStyle().set_Class("");
		((BaseItemControl)CBXchuli).get_BackgroundStyle().set_CornerType((eCornerType)1);
		CheckBoxX cBXchuli = CBXchuli;
		location = new Point(135, 207);
		((Control)cBXchuli).set_Location(location);
		((Control)CBXchuli).set_Name("CBXchuli");
		CheckBoxX cBXchuli2 = CBXchuli;
		size = new Size(191, 20);
		((Control)cBXchuli2).set_Size(size);
		((BaseItemControl)CBXchuli).set_Style((eDotNetBarStyle)7);
		((Control)CBXchuli).set_TabIndex(3);
		CBXchuli.set_Text("WORD计算报告生成过程可见");
		Wizard1.set_BackButtonText("上一步");
		((Control)Wizard1).set_BackColor(Color.FromArgb(205, 229, 253));
		Wizard1.set_ButtonStyle((eWizardStyle)1);
		Wizard1.set_CancelButtonText("取消");
		((Control)Wizard1).set_Cursor(Cursors.get_Default());
		((Control)Wizard1).set_Dock((DockStyle)5);
		Wizard1.set_FinishButtonTabIndex(3);
		Wizard1.set_FinishButtonText("开始生成");
		((Control)Wizard1).set_Font(new Font("宋体", 9f, (FontStyle)0, (GraphicsUnit)3, (byte)134));
		Wizard1.get_FooterStyle().set_BackColor(Color.Transparent);
		Wizard1.get_FooterStyle().set_Class("");
		Wizard1.get_FooterStyle().set_CornerType((eCornerType)1);
		((Control)Wizard1).set_ForeColor(Color.FromArgb(15, 57, 129));
		Wizard1.set_HeaderCaptionFont(new Font("宋体", 12f, (FontStyle)1));
		Wizard1.set_HeaderDescriptionFont(new Font("宋体", 9f, (FontStyle)0, (GraphicsUnit)3, (byte)134));
		Wizard1.set_HeaderDescriptionIndent(62);
		Wizard1.set_HeaderDescriptionVisible(false);
		Wizard1.set_HeaderHeight(90);
		Wizard1.set_HeaderImageAlignment((eWizardTitleImageAlignment)0);
		Wizard1.set_HeaderImageVisible(false);
		Wizard1.get_HeaderStyle().set_BackColor(Color.Transparent);
		Wizard1.get_HeaderStyle().set_BackColorGradientAngle(90);
		Wizard1.get_HeaderStyle().set_BorderBottom((eStyleBorderType)1);
		Wizard1.get_HeaderStyle().set_BorderBottomColor(Color.FromArgb(121, 157, 182));
		Wizard1.get_HeaderStyle().set_BorderBottomWidth(1);
		Wizard1.get_HeaderStyle().set_BorderColor(SystemColors.Control);
		Wizard1.get_HeaderStyle().set_BorderLeftWidth(1);
		Wizard1.get_HeaderStyle().set_BorderRightWidth(1);
		Wizard1.get_HeaderStyle().set_BorderTopWidth(1);
		Wizard1.get_HeaderStyle().set_Class("");
		Wizard1.get_HeaderStyle().set_CornerType((eCornerType)1);
		Wizard1.get_HeaderStyle().set_TextAlignment((eStyleTextAlignment)1);
		Wizard1.get_HeaderStyle().set_TextColorSchemePart((eColorSchemePart)54);
		Wizard1.set_HeaderTitleIndent(62);
		Wizard1.set_HelpButtonText("帮助");
		Wizard1.set_HelpButtonVisible(false);
		Wizard wizard = Wizard1;
		location = new Point(0, 0);
		((Control)wizard).set_Location(location);
		((Control)Wizard1).set_Name("Wizard1");
		Wizard1.set_NextButtonText("下一步");
		Wizard1.set_PageChangeDisableButtons(false);
		Wizard1.set_PageChangeWaitCursor(false);
		Wizard wizard2 = Wizard1;
		size = new Size(600, 384);
		((Control)wizard2).set_Size(size);
		((Control)Wizard1).set_TabIndex(2);
		Wizard1.get_WizardPages().AddRange((WizardPage[])(object)new WizardPage[3] { WizardPage3, WizardPage1, WizardPage2 });
		((Control)WizardPage2).set_Anchor((AnchorStyles)15);
		((PanelControl)WizardPage2).set_AntiAlias(false);
		WizardPage2.set_BackColor(Color.Transparent);
		((PanelControl)WizardPage2).set_ColorSchemeStyle((eDotNetBarStyle)0);
		((Control)WizardPage2).get_Controls().Add((Control)(object)btnstop);
		((Control)WizardPage2).get_Controls().Add((Control)(object)CBXchuli);
		((Control)WizardPage2).get_Controls().Add((Control)(object)CBXlog);
		((Control)WizardPage2).get_Controls().Add((Control)(object)lbjd);
		((Control)WizardPage2).get_Controls().Add((Control)(object)PBX1);
		((Control)WizardPage2).get_Controls().Add((Control)(object)lb1);
		WizardPage wizardPage5 = WizardPage2;
		location = new Point(7, 102);
		((Control)wizardPage5).set_Location(location);
		((Control)WizardPage2).set_Name("WizardPage2");
		WizardPage2.set_PageTitle("生成过程信息");
		WizardPage wizardPage6 = WizardPage2;
		size = new Size(586, 224);
		((Control)wizardPage6).set_Size(size);
		((PanelControl)WizardPage2).get_Style().set_Class("");
		((PanelControl)WizardPage2).get_Style().set_CornerType((eCornerType)1);
		((PanelControl)WizardPage2).get_StyleMouseDown().set_Class("");
		((PanelControl)WizardPage2).get_StyleMouseDown().set_CornerType((eCornerType)1);
		((PanelControl)WizardPage2).get_StyleMouseOver().set_Class("");
		((PanelControl)WizardPage2).get_StyleMouseOver().set_CornerType((eCornerType)1);
		((Control)WizardPage2).set_TabIndex(11);
		((Control)btnstop).set_AccessibleRole((AccessibleRole)43);
		btnstop.set_ColorTable((eButtonColor)3);
		((Control)btnstop).set_Enabled(false);
		ButtonX obj5 = btnstop;
		location = new Point(503, 178);
		((Control)obj5).set_Location(location);
		((Control)btnstop).set_Name("btnstop");
		ButtonX obj6 = btnstop;
		size = new Size(75, 23);
		((Control)obj6).set_Size(size);
		((PopupItemControl)btnstop).set_Style((eDotNetBarStyle)7);
		((Control)btnstop).set_TabIndex(7);
		btnstop.set_Text("强行终止");
		((BaseItemControl)CBXlog).get_BackgroundStyle().set_Class("");
		((BaseItemControl)CBXlog).get_BackgroundStyle().set_CornerType((eCornerType)1);
		CheckBoxX cBXlog = CBXlog;
		location = new Point(1, 207);
		((Control)cBXlog).set_Location(location);
		((Control)CBXlog).set_Name("CBXlog");
		CheckBoxX cBXlog2 = CBXlog;
		size = new Size(128, 20);
		((Control)cBXlog2).set_Size(size);
		((BaseItemControl)CBXlog).set_Style((eDotNetBarStyle)7);
		((Control)CBXlog).set_TabIndex(1);
		CBXlog.set_Text("追加操作流程信息");
		((Control)CBXlog).set_Visible(false);
		((ListControl)lb1).set_FormattingEnabled(true);
		lb1.set_ItemHeight(12);
		ListBox obj7 = lb1;
		location = new Point(0, 0);
		((Control)obj7).set_Location(location);
		((Control)lb1).set_Name("lb1");
		ListBox obj8 = lb1;
		size = new Size(578, 172);
		((Control)obj8).set_Size(size);
		((Control)lb1).set_TabIndex(0);
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)0);
		((Office2007Form)this).set_CaptionFont(new Font("宋体", 9f, (FontStyle)0, (GraphicsUnit)3, (byte)134));
		size = new Size(600, 384);
		((Form)this).set_ClientSize(size);
		((Control)this).get_Controls().Add((Control)(object)Wizard1);
		((Control)this).set_Font(new Font("宋体", 9f, (FontStyle)0, (GraphicsUnit)3, (byte)134));
		((Form)this).set_MaximizeBox(false);
		((Form)this).set_MinimizeBox(false);
		((Control)this).set_Name("jsbaogao");
		((Form)this).set_ShowIcon(false);
		((Form)this).set_ShowInTaskbar(false);
		((Form)this).set_StartPosition((FormStartPosition)1);
		((Form)this).set_Text("计算报告生成向导");
		((Control)WizardPage3).ResumeLayout(false);
		((Control)WizardPage1).ResumeLayout(false);
		((Control)Wizard1).ResumeLayout(false);
		((Control)WizardPage2).ResumeLayout(false);
		((Control)this).ResumeLayout(false);
	}

	private void SelectDir_Click(object sender, EventArgs e)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		FolderBrowserDialog val = new FolderBrowserDialog();
		val.set_Description("选择保存文件夹路径");
		((CommonDialog)val).ShowDialog();
		if (Operators.CompareString(val.get_SelectedPath(), "", false) != 0)
		{
			((TextBox)txtPath).set_Text(val.get_SelectedPath());
			WizardPage1.set_NextButtonEnabled((eWizardButtonState)0);
		}
		else
		{
			WizardPage1.set_NextButtonEnabled((eWizardButtonState)1);
		}
	}

	private void WizardPage2_FinishButtonClick(object sender, CancelEventArgs e)
	{
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			ModWord.jsbgexit = false;
			WizardPage2.set_BackButtonEnabled((eWizardButtonState)1);
			ModWord.HQbiaoqian(((TextBox)txtPath).get_Text());
			((Component)(object)this).Dispose();
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			if (!ModWord.jsbgexit)
			{
				((Form)this).Close();
				Interaction.MsgBox((object)(ex2.Message.ToString() + "\r" + ex2.StackTrace!.ToString()), (MsgBoxStyle)64, (object)"提示");
			}
			ProjectData.ClearProjectError();
		}
	}

	private void jsbaogao_FormClosed(object sender, FormClosedEventArgs e)
	{
		checked
		{
			if (lb1.get_Items().get_Count() != 0)
			{
				int num = lb1.get_Items().get_Count() - 1;
				for (int i = 0; i <= num; i++)
				{
					MyProject.Forms.Main.lslog.get_Items().Add(RuntimeHelpers.GetObjectValue(lb1.get_Items().get_Item(i)));
				}
			}
			ModWord.Quit();
			MyProject.Forms.Main.lslog.set_SelectedIndex(MyProject.Forms.Main.lslog.get_Items().get_Count() - 1);
		}
	}

	private void btnstop_Click(object sender, EventArgs e)
	{
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Invalid comparison between Unknown and I4
		//IL_00f3: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			if ((int)MessageBox.Show("是否停止生成计算报告？", "提示", (MessageBoxButtons)4, (MessageBoxIcon)64) == 6)
			{
				ModWord.jsbgexit = true;
				((Control)btnstop).set_Enabled(false);
				ModWord.SaveAs(((TextBox)txtPath).get_Text() + "\\test.doc");
				lb1.get_Items().Add((object)"");
				lb1.get_Items().Add((object)(Conversions.ToString(DateTime.Now) + " 已经终止生成计算报告,请看文件;" + ((TextBox)txtPath).get_Text() + "\\test.doc"));
				lb1.set_SelectedIndex(checked(lb1.get_Items().get_Count() - 1));
				ModWord.CloseAllDocuments();
				ModWord.Quit();
				((Form)this).Close();
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			if (!ModWord.jsbgexit)
			{
				Interaction.MsgBox((object)(ex2.Message.ToString() + "\r" + ex2.StackTrace!.ToString()), (MsgBoxStyle)64, (object)"提示");
			}
			ProjectData.ClearProjectError();
		}
	}

	private void jsbaogao_Load(object sender, EventArgs e)
	{
		WizardPage1.set_NextButtonEnabled((eWizardButtonState)1);
	}
}
