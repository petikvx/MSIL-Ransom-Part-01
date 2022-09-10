using System;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.Devices;
using xxx.My;

namespace xxx;

[DesignerGenerated]
public class dcbj : Office2007Form
{
	private IContainer components;

	[AccessedThroughProperty("LabelX1")]
	private LabelX _LabelX1;

	[AccessedThroughProperty("bjlist")]
	private ListBox _bjlist;

	[AccessedThroughProperty("btndcbj")]
	private ButtonX _btndcbj;

	[AccessedThroughProperty("gb")]
	private ButtonX _gb;

	private string[] dir;

	private string n;

	private string[] nn;

	private ArrayList list1;

	private string f;

	private string temp;

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
			EventHandler eventHandler = bjlist_SelectedIndexChanged;
			if (_bjlist != null)
			{
				_bjlist.remove_SelectedIndexChanged(eventHandler);
			}
			_bjlist = value;
			if (_bjlist != null)
			{
				_bjlist.add_SelectedIndexChanged(eventHandler);
			}
		}
	}

	internal virtual ButtonX btndcbj
	{
		[DebuggerNonUserCode]
		get
		{
			return _btndcbj;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = btndcbj_Click;
			if (_btndcbj != null)
			{
				((Control)_btndcbj).remove_Click(eventHandler);
			}
			_btndcbj = value;
			if (_btndcbj != null)
			{
				((Control)_btndcbj).add_Click(eventHandler);
			}
		}
	}

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

	public dcbj()
	{
		((Form)this).add_Load((EventHandler)dcbj_Load);
		list1 = new ArrayList();
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
		//IL_025c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0266: Expected O, but got Unknown
		//IL_02db: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e5: Expected O, but got Unknown
		LabelX1 = new LabelX();
		bjlist = new ListBox();
		btndcbj = new ButtonX();
		gb = new ButtonX();
		((Control)this).SuspendLayout();
		((BaseItemControl)LabelX1).get_BackgroundStyle().set_Class("");
		((BaseItemControl)LabelX1).get_BackgroundStyle().set_CornerType((eCornerType)1);
		LabelX labelX = LabelX1;
		Point location = new Point(12, 3);
		((Control)labelX).set_Location(location);
		((Control)LabelX1).set_Name("LabelX1");
		LabelX labelX2 = LabelX1;
		Size size = new Size(221, 20);
		((Control)labelX2).set_Size(size);
		((Control)LabelX1).set_TabIndex(0);
		LabelX1.set_Text("当前模型库中存在的所有部件");
		((ListControl)bjlist).set_FormattingEnabled(true);
		bjlist.set_ItemHeight(12);
		ListBox obj = bjlist;
		location = new Point(12, 27);
		((Control)obj).set_Location(location);
		((Control)bjlist).set_Name("bjlist");
		ListBox obj2 = bjlist;
		size = new Size(226, 268);
		((Control)obj2).set_Size(size);
		((Control)bjlist).set_TabIndex(1);
		((Control)btndcbj).set_AccessibleRole((AccessibleRole)43);
		btndcbj.set_ColorTable((eButtonColor)3);
		ButtonX obj3 = btndcbj;
		location = new Point(12, 301);
		((Control)obj3).set_Location(location);
		((Control)btndcbj).set_Name("btndcbj");
		ButtonX obj4 = btndcbj;
		size = new Size(110, 23);
		((Control)obj4).set_Size(size);
		((PopupItemControl)btndcbj).set_Style((eDotNetBarStyle)7);
		((Control)btndcbj).set_TabIndex(2);
		btndcbj.set_Text("导出部件");
		((Control)gb).set_AccessibleRole((AccessibleRole)43);
		gb.set_ColorTable((eButtonColor)3);
		gb.set_DialogResult((DialogResult)2);
		ButtonX obj5 = gb;
		location = new Point(128, 301);
		((Control)obj5).set_Location(location);
		((Control)gb).set_Name("gb");
		ButtonX obj6 = gb;
		size = new Size(110, 23);
		((Control)obj6).set_Size(size);
		((PopupItemControl)gb).set_Style((eDotNetBarStyle)7);
		((Control)gb).set_TabIndex(2);
		gb.set_Text("关闭");
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)0);
		((Form)this).set_AutoSizeMode((AutoSizeMode)0);
		((Form)this).set_CancelButton((IButtonControl)(object)gb);
		((Office2007Form)this).set_CaptionFont(new Font("宋体", 9f, (FontStyle)0, (GraphicsUnit)3, (byte)134));
		size = new Size(250, 336);
		((Form)this).set_ClientSize(size);
		((Form)this).set_ControlBox(false);
		((Control)this).get_Controls().Add((Control)(object)gb);
		((Control)this).get_Controls().Add((Control)(object)btndcbj);
		((Control)this).get_Controls().Add((Control)(object)bjlist);
		((Control)this).get_Controls().Add((Control)(object)LabelX1);
		((Control)this).set_Font(new Font("宋体", 9f, (FontStyle)0, (GraphicsUnit)3, (byte)134));
		((Form)this).set_FormBorderStyle((FormBorderStyle)3);
		((Control)this).set_Name("dcbj");
		((Form)this).set_ShowInTaskbar(false);
		((Form)this).set_StartPosition((FormStartPosition)1);
		((Form)this).set_Text("部件导出");
		((Control)this).ResumeLayout(false);
	}

	private void dcbj_Load(object sender, EventArgs e)
	{
		list1.Clear();
		Readmlibs();
	}

	private void gb_Click(object sender, EventArgs e)
	{
		MyProject.Forms.mxkgl.log.get_Items().Add((object)(Conversions.ToString(DateTime.Now) + " 操作员关闭导出部件对话框"));
		((Form)this).Close();
	}

	private void btndcbj_Click(object sender, EventArgs e)
	{
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Expected O, but got Unknown
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ac: Invalid comparison between Unknown and I4
		//IL_012d: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_026a: Unknown result type (might be due to invalid IL or missing references)
		if (bjlist.get_SelectedIndex() != -1)
		{
			FolderBrowserDialog val = new FolderBrowserDialog();
			val.set_Description("选择保存文件夹");
			((CommonDialog)val).ShowDialog();
			if (Operators.CompareString(val.get_SelectedPath(), "", false) != 0)
			{
				if (!Directory.Exists(val.get_SelectedPath()))
				{
					return;
				}
				temp = bjlist.get_Text();
				if (Directory.Exists(Conversions.ToString(Operators.ConcatenateObject((object)(val.get_SelectedPath() + "\\"), list1[bjlist.get_SelectedIndex()]))))
				{
					if ((int)MessageBox.Show("选定的目录下已经存在该部件，是否覆盖？", "重要提示", (MessageBoxButtons)4, (MessageBoxIcon)64) == 6)
					{
						((Control)this).set_Cursor(Cursors.get_AppStarting());
						((ServerComputer)MyProject.Computer).get_FileSystem().CopyDirectory(Conversions.ToString(Operators.ConcatenateObject((object)Mod1.Kulujing, list1[bjlist.get_SelectedIndex()])), Conversions.ToString(Operators.ConcatenateObject((object)(val.get_SelectedPath() + "\\"), list1[bjlist.get_SelectedIndex()])), true);
						Interaction.MsgBox((object)"覆盖部件完成!", (MsgBoxStyle)64, (object)"完成");
						MyProject.Forms.mxkgl.log.get_Items().Add((object)(Conversions.ToString(DateTime.Now) + " 操作员对当前库部件进行了导出操作，并且遇到了同名部件，操作结果：已覆盖。"));
						((Control)this).set_Cursor(Cursors.get_Arrow());
					}
				}
				else
				{
					((Control)this).set_Cursor(Cursors.get_AppStarting());
					((ServerComputer)MyProject.Computer).get_FileSystem().CopyDirectory(Conversions.ToString(Operators.ConcatenateObject((object)Mod1.Kulujing, list1[bjlist.get_SelectedIndex()])), Conversions.ToString(Operators.ConcatenateObject((object)(val.get_SelectedPath() + "\\"), list1[bjlist.get_SelectedIndex()])), true);
					Interaction.MsgBox((object)"导出部件完成!", (MsgBoxStyle)64, (object)"完成");
					((Control)this).set_Cursor(Cursors.get_Arrow());
					MyProject.Forms.mxkgl.log.get_Items().Add(Operators.ConcatenateObject((object)string.Concat(string.Concat(Conversions.ToString(DateTime.Now) + " 操作员对当前库部件进行了导出操作，导出路径为：", val.get_SelectedPath()), "\\"), list1[bjlist.get_SelectedIndex()]));
				}
			}
		}
		else
		{
			Interaction.MsgBox((object)"请选择一个要导出的部件", (MsgBoxStyle)64, (object)"导出失败");
		}
		((Control)btndcbj).set_Enabled(false);
	}

	public void Readmlibs()
	{
		f = "";
		Mod1.lr = new StreamReader(Mod1.Kulujing + "mlibs.lis", Encoding.Default);
		while (!Information.IsNothing((object)f))
		{
			f = Mod1.lr.ReadLine();
			if (Information.IsNothing((object)f))
			{
				break;
			}
			nn = f.Split(new char[1] { ',' });
			bjlist.get_Items().Add((object)nn[0]);
			list1.Add(nn[1]);
		}
		Mod1.lr.Close();
		Mod1.lr.Dispose();
	}

	private void bjlist_SelectedIndexChanged(object sender, EventArgs e)
	{
		if (Operators.CompareString(temp, bjlist.get_Text(), false) != 0)
		{
			((Control)btndcbj).set_Enabled(true);
		}
	}
}
