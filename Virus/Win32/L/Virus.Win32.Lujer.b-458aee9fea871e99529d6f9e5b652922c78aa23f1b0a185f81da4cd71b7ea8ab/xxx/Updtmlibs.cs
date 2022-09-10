using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using DevComponents.DotNetBar.Controls;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.Devices;
using xxx.My;

namespace xxx;

[DesignerGenerated]
public class Updtmlibs : Office2007Form
{
	private IContainer components;

	[AccessedThroughProperty("LabelX1")]
	private LabelX _LabelX1;

	[AccessedThroughProperty("txtname")]
	private TextBoxX _txtname;

	[AccessedThroughProperty("queding")]
	private ButtonX _queding;

	public string n;

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

	internal virtual TextBoxX txtname
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtname;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtname = value;
		}
	}

	internal virtual ButtonX queding
	{
		[DebuggerNonUserCode]
		get
		{
			return _queding;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = queding_Click;
			if (_queding != null)
			{
				((Control)_queding).remove_Click(eventHandler);
			}
			_queding = value;
			if (_queding != null)
			{
				((Control)_queding).add_Click(eventHandler);
			}
		}
	}

	[DebuggerNonUserCode]
	public Updtmlibs()
	{
		((Form)this).add_Load((EventHandler)Updtmlibs_Load);
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
		//IL_01c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d2: Expected O, but got Unknown
		//IL_0233: Unknown result type (might be due to invalid IL or missing references)
		//IL_023d: Expected O, but got Unknown
		LabelX1 = new LabelX();
		txtname = new TextBoxX();
		queding = new ButtonX();
		((Control)this).SuspendLayout();
		((BaseItemControl)LabelX1).get_BackgroundStyle().set_Class("");
		((BaseItemControl)LabelX1).get_BackgroundStyle().set_CornerType((eCornerType)1);
		LabelX labelX = LabelX1;
		Point location = new Point(23, 10);
		((Control)labelX).set_Location(location);
		((Control)LabelX1).set_Name("LabelX1");
		LabelX labelX2 = LabelX1;
		Size size = new Size(163, 15);
		((Control)labelX2).set_Size(size);
		((Control)LabelX1).set_TabIndex(0);
		LabelX1.set_Text("部件中文/英文名称：");
		txtname.get_Border().set_Class("TextBoxBorder");
		txtname.get_Border().set_CornerType((eCornerType)1);
		TextBoxX obj = txtname;
		location = new Point(23, 31);
		((Control)obj).set_Location(location);
		((Control)txtname).set_Name("txtname");
		TextBoxX obj2 = txtname;
		size = new Size(199, 21);
		((Control)obj2).set_Size(size);
		((Control)txtname).set_TabIndex(1);
		((Control)queding).set_AccessibleRole((AccessibleRole)43);
		queding.set_ColorTable((eButtonColor)3);
		ButtonX obj3 = queding;
		location = new Point(77, 60);
		((Control)obj3).set_Location(location);
		((Control)queding).set_Name("queding");
		ButtonX obj4 = queding;
		size = new Size(96, 24);
		((Control)obj4).set_Size(size);
		((PopupItemControl)queding).set_Style((eDotNetBarStyle)7);
		((Control)queding).set_TabIndex(2);
		queding.set_Text("确定");
		((Form)this).set_AcceptButton((IButtonControl)(object)queding);
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)0);
		((Form)this).set_AutoSizeMode((AutoSizeMode)0);
		((Office2007Form)this).set_CaptionFont(new Font("宋体", 9f, (FontStyle)0, (GraphicsUnit)3, (byte)134));
		size = new Size(247, 93);
		((Form)this).set_ClientSize(size);
		((Form)this).set_ControlBox(false);
		((Control)this).get_Controls().Add((Control)(object)queding);
		((Control)this).get_Controls().Add((Control)(object)txtname);
		((Control)this).get_Controls().Add((Control)(object)LabelX1);
		((Control)this).set_Font(new Font("宋体", 9f, (FontStyle)0, (GraphicsUnit)3, (byte)134));
		((Form)this).set_FormBorderStyle((FormBorderStyle)3);
		((Control)this).set_Name("Updtmlibs");
		((Form)this).set_ShowInTaskbar(false);
		((Form)this).set_StartPosition((FormStartPosition)1);
		((Form)this).set_Text("请输入部件名字");
		((Control)this).ResumeLayout(false);
	}

	public void upmlibs()
	{
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		//IL_006b: Invalid comparison between Unknown and I4
		//IL_00ba: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			Mod1.wr = new StreamWriter(Mod1.Kulujing + "mlibs.lis", append: true, Encoding.Default);
			Mod1.wr.WriteLine(((TextBox)txtname).get_Text() + "," + n);
			Mod1.wr.Close();
			Mod1.wr.Dispose();
			if ((int)MessageBox.Show("是否同时更新与产品对应的源库列表文件？", "重要提示", (MessageBoxButtons)4, (MessageBoxIcon)64) == 6)
			{
				((ServerComputer)MyProject.Computer).get_FileSystem().CopyFile(Mod1.Kulujing + "\\mlibs.lis", Application.get_StartupPath() + "\\Config\\" + Mod1.bb + "\\mlibs.lis", true);
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			Interaction.MsgBox((object)"部件命名失败！", (MsgBoxStyle)64, (object)"提示");
			ProjectData.ClearProjectError();
		}
	}

	private void queding_Click(object sender, EventArgs e)
	{
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cb: Unknown result type (might be due to invalid IL or missing references)
		if (((TextBox)txtname).get_Text().LastIndexOf(" ") != -1)
		{
			Interaction.MsgBox((object)"部件名字中不能有空格！", (MsgBoxStyle)64, (object)"部件名称错误");
		}
		else if (Operators.CompareString(Strings.Trim(((TextBox)txtname).get_Text()), "", false) != 0)
		{
			upmlibs();
			MyProject.Forms.zjbj.txtcheck.get_Items().Add((object)(Conversions.ToString(DateTime.Now) + " 操作员对当前模型库进行了部件追加操作！！部件名字为：" + ((TextBox)txtname).get_Text()));
			MyProject.Forms.zjbj.txtcheck.set_SelectedIndex(checked(MyProject.Forms.zjbj.txtcheck.get_Items().get_Count() - 1));
			((Component)(object)this).Dispose();
		}
		else
		{
			Interaction.MsgBox((object)"部件名字不能为空！", (MsgBoxStyle)64, (object)"部件名称错误");
		}
	}

	private void Updtmlibs_Load(object sender, EventArgs e)
	{
		((TextBox)txtname).set_Text(n);
	}
}
