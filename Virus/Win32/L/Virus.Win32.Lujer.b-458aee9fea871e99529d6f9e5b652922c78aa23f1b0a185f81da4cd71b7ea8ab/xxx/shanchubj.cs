using System;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.Devices;
using Microsoft.VisualBasic.FileIO;
using xxx.My;

namespace xxx;

[DesignerGenerated]
public class shanchubj : Office2007Form
{
	private IContainer components;

	[AccessedThroughProperty("gb")]
	private ButtonX _gb;

	[AccessedThroughProperty("btnshanchu")]
	private ButtonX _btnshanchu;

	[AccessedThroughProperty("bjlist")]
	private ListBox _bjlist;

	[AccessedThroughProperty("LabelX1")]
	private LabelX _LabelX1;

	private string[] dir;

	private string n;

	private string f;

	private string[] nn;

	private ArrayList list1;

	private ArrayList bjname;

	internal virtual ButtonX gb
	{
		[DebuggerNonUserCode]
		get
		{
			return _gb;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = gb_Click;
			if (_gb != null)
			{
				((Control)_gb).remove_Click(eventHandler);
			}
			_gb = value;
			if (_gb != null)
			{
				((Control)_gb).add_Click(eventHandler);
			}
		}
	}

	internal virtual ButtonX btnshanchu
	{
		[DebuggerNonUserCode]
		get
		{
			return _btnshanchu;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = btnshanchu_Click;
			if (_btnshanchu != null)
			{
				((Control)_btnshanchu).remove_Click(eventHandler);
			}
			_btnshanchu = value;
			if (_btnshanchu != null)
			{
				((Control)_btnshanchu).add_Click(eventHandler);
			}
		}
	}

	internal virtual ListBox bjlist
	{
		[DebuggerNonUserCode]
		get
		{
			return _bjlist;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_bjlist = value;
		}
	}

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

	public shanchubj()
	{
		((Form)this).add_Load((EventHandler)shanchubj_Load);
		list1 = new ArrayList();
		bjname = new ArrayList();
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
		//IL_0257: Unknown result type (might be due to invalid IL or missing references)
		//IL_0261: Expected O, but got Unknown
		//IL_02d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e0: Expected O, but got Unknown
		gb = new ButtonX();
		btnshanchu = new ButtonX();
		bjlist = new ListBox();
		LabelX1 = new LabelX();
		((Control)this).SuspendLayout();
		((Control)gb).set_AccessibleRole((AccessibleRole)43);
		gb.set_ColorTable((eButtonColor)3);
		gb.set_DialogResult((DialogResult)2);
		ButtonX obj = gb;
		Point location = new Point(124, 310);
		((Control)obj).set_Location(location);
		((Control)gb).set_Name("gb");
		ButtonX obj2 = gb;
		Size size = new Size(110, 23);
		((Control)obj2).set_Size(size);
		((PopupItemControl)gb).set_Style((eDotNetBarStyle)7);
		((Control)gb).set_TabIndex(5);
		gb.set_Text("关闭");
		((Control)btnshanchu).set_AccessibleRole((AccessibleRole)43);
		btnshanchu.set_ColorTable((eButtonColor)3);
		ButtonX obj3 = btnshanchu;
		location = new Point(8, 310);
		((Control)obj3).set_Location(location);
		((Control)btnshanchu).set_Name("btnshanchu");
		ButtonX obj4 = btnshanchu;
		size = new Size(110, 23);
		((Control)obj4).set_Size(size);
		((PopupItemControl)btnshanchu).set_Style((eDotNetBarStyle)7);
		((Control)btnshanchu).set_TabIndex(6);
		btnshanchu.set_Text("删除部件");
		((ListControl)bjlist).set_FormattingEnabled(true);
		bjlist.set_ItemHeight(12);
		ListBox obj5 = bjlist;
		location = new Point(8, 36);
		((Control)obj5).set_Location(location);
		((Control)bjlist).set_Name("bjlist");
		ListBox obj6 = bjlist;
		size = new Size(226, 268);
		((Control)obj6).set_Size(size);
		((Control)bjlist).set_TabIndex(4);
		((BaseItemControl)LabelX1).get_BackgroundStyle().set_Class("");
		((BaseItemControl)LabelX1).get_BackgroundStyle().set_CornerType((eCornerType)1);
		LabelX labelX = LabelX1;
		location = new Point(8, 12);
		((Control)labelX).set_Location(location);
		((Control)LabelX1).set_Name("LabelX1");
		LabelX labelX2 = LabelX1;
		size = new Size(221, 20);
		((Control)labelX2).set_Size(size);
		((Control)LabelX1).set_TabIndex(3);
		LabelX1.set_Text("当前模型库中存在的所有部件");
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)0);
		((Form)this).set_AutoSizeMode((AutoSizeMode)0);
		((Form)this).set_CancelButton((IButtonControl)(object)gb);
		((Office2007Form)this).set_CaptionFont(new Font("宋体", 9f, (FontStyle)0, (GraphicsUnit)3, (byte)134));
		size = new Size(241, 340);
		((Form)this).set_ClientSize(size);
		((Form)this).set_ControlBox(false);
		((Control)this).get_Controls().Add((Control)(object)gb);
		((Control)this).get_Controls().Add((Control)(object)btnshanchu);
		((Control)this).get_Controls().Add((Control)(object)bjlist);
		((Control)this).get_Controls().Add((Control)(object)LabelX1);
		((Control)this).set_Font(new Font("宋体", 9f, (FontStyle)0, (GraphicsUnit)3, (byte)134));
		((Form)this).set_FormBorderStyle((FormBorderStyle)3);
		((Control)this).set_Name("shanchubj");
		((Form)this).set_ShowInTaskbar(false);
		((Form)this).set_StartPosition((FormStartPosition)1);
		((Form)this).set_Text("部件删除");
		((Control)this).ResumeLayout(false);
	}

	private void gb_Click(object sender, EventArgs e)
	{
		MyProject.Forms.mxkgl.log.get_Items().Add((object)(Conversions.ToString(DateTime.Now) + " 操作员关闭了删除部件对话框"));
		((Form)this).Close();
	}

	private void shanchubj_Load(object sender, EventArgs e)
	{
		list1.Clear();
		bjname.Clear();
		Readmlibs();
	}

	private void btnshanchu_Click(object sender, EventArgs e)
	{
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Invalid comparison between Unknown and I4
		//IL_0134: Unknown result type (might be due to invalid IL or missing references)
		//IL_013a: Invalid comparison between Unknown and I4
		//IL_0189: Unknown result type (might be due to invalid IL or missing references)
		if (bjlist.get_SelectedIndex() == -1)
		{
			return;
		}
		if ((Operators.CompareString(Mod1.bjlb1, bjlist.get_Text(), false) == 0) | !Mod1.Saved)
		{
			if ((int)MessageBox.Show("即将删除的部件中文件已被打开或参数文件已经被更改，是否继续删除选定的部件？", "重要提示", (MessageBoxButtons)4, (MessageBoxIcon)64) == 6)
			{
				try
				{
					Mod1.wb.Close(Missing.Value, Missing.Value, Missing.Value);
				}
				catch (Exception projectError)
				{
					ProjectData.SetProjectError(projectError);
					ProjectData.ClearProjectError();
				}
				((BaseItem)MyProject.Forms.Main.ToolsInput).set_Enabled(false);
				((BaseItem)MyProject.Forms.Main.Toolsfxxd).set_Enabled(false);
				((BaseItem)MyProject.Forms.Main.ToolsSave).set_Enabled(false);
				Mod1.Saved = true;
				del();
				Updatamlibs();
				bjlist.get_Items().Clear();
				Readmlibs();
				bjlist.Refresh();
				((Component)(object)MyProject.Forms.FrmOf).Dispose();
			}
		}
		else if (Directory.Exists(Conversions.ToString(Operators.ConcatenateObject((object)Mod1.Kulujing, list1[bjlist.get_SelectedIndex()]))))
		{
			if ((int)MessageBox.Show("你确定要删除选择的部件吗？", "重要提示", (MessageBoxButtons)4, (MessageBoxIcon)64) == 6)
			{
				del();
				Updatamlibs();
				bjlist.get_Items().Clear();
				Readmlibs();
				bjlist.Refresh();
				((Component)(object)MyProject.Forms.FrmOf).Dispose();
			}
		}
		else
		{
			Interaction.MsgBox((object)"删除的部件文件夹已经不存在，程序将从列表中删除当前部件名称！", (MsgBoxStyle)48, (object)"警告");
			list1.RemoveAt(bjlist.get_SelectedIndex());
			bjname.RemoveAt(bjlist.get_SelectedIndex());
			bjlist.get_Items().RemoveAt(bjlist.get_SelectedIndex());
			Updatamlibs();
			((Component)(object)MyProject.Forms.FrmOf).Dispose();
		}
	}

	public void del()
	{
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fc: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			((ServerComputer)MyProject.Computer).get_FileSystem().DeleteDirectory(Conversions.ToString(Operators.ConcatenateObject((object)Mod1.Kulujing, list1[bjlist.get_SelectedIndex()])), (DeleteDirectoryOption)5);
			Interaction.MsgBox((object)"部件删除成功！！", (MsgBoxStyle)64, (object)"成功");
			list1.RemoveAt(bjlist.get_SelectedIndex());
			bjname.RemoveAt(bjlist.get_SelectedIndex());
			MyProject.Forms.Main.arr.RemoveAt(bjlist.get_SelectedIndex());
			MyProject.Forms.mxkgl.log.get_Items().Add((object)(Conversions.ToString(DateTime.Now) + " 操作员删除了当前库的部件，名字为： " + bjlist.get_Text()));
			bjlist.get_Items().RemoveAt(bjlist.get_SelectedIndex());
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			Interaction.MsgBox((object)ex2.Message, (MsgBoxStyle)64, (object)"删除失败");
			ProjectData.ClearProjectError();
		}
	}

	public void Readmlibs()
	{
		f = "";
		list1.Clear();
		bjname.Clear();
		Mod1.lr = new StreamReader(Mod1.Kulujing + "mlibs.lis", Encoding.Default);
		while (!Information.IsNothing((object)f))
		{
			f = Mod1.lr.ReadLine();
			if (Information.IsNothing((object)f))
			{
				break;
			}
			bjname.Add(f);
			nn = f.Split(new char[1] { ',' });
			bjlist.get_Items().Add((object)nn[0]);
			list1.Add(nn[1]);
		}
		Mod1.lr.Close();
		Mod1.lr.Dispose();
	}

	public void Updatamlibs()
	{
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		//IL_007b: Invalid comparison between Unknown and I4
		Mod1.wr = new StreamWriter(Mod1.Kulujing + "mlibs.lis", append: false, Encoding.Default);
		checked
		{
			int num = bjname.Count - 1;
			for (int i = 0; i <= num; i++)
			{
				Mod1.wr.WriteLine(RuntimeHelpers.GetObjectValue(bjname[i]));
			}
			Mod1.wr.Close();
			Mod1.wr.Dispose();
		}
		if ((int)MessageBox.Show("是否同时更新与产品对应的源库列表文件？", "重要提示", (MessageBoxButtons)4, (MessageBoxIcon)64) == 6)
		{
			((ServerComputer)MyProject.Computer).get_FileSystem().CopyFile(Mod1.Kulujing + "\\mlibs.lis", Application.get_StartupPath() + "\\Config\\" + Mod1.bb + "\\mlibs.lis", true);
		}
	}
}
