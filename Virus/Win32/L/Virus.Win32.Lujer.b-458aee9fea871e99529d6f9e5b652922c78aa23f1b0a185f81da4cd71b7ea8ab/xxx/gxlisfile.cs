using System;
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
using xxx.My;

namespace xxx;

[DesignerGenerated]
public class gxlisfile : Office2007Form
{
	private IContainer components;

	[AccessedThroughProperty("lstdir")]
	private ListBox _lstdir;

	[AccessedThroughProperty("LabelX1")]
	private LabelX _LabelX1;

	[AccessedThroughProperty("lstjg")]
	private ListBox _lstjg;

	[AccessedThroughProperty("log")]
	private ListBox _log;

	[AccessedThroughProperty("LabelX3")]
	private LabelX _LabelX3;

	[AccessedThroughProperty("lstnr")]
	private ListBox _lstnr;

	[AccessedThroughProperty("LabelX4")]
	private LabelX _LabelX4;

	[AccessedThroughProperty("btnsy")]
	private ButtonX _btnsy;

	[AccessedThroughProperty("btnsc")]
	private ButtonX _btnsc;

	[AccessedThroughProperty("btnsclis")]
	private ButtonX _btnsclis;

	[AccessedThroughProperty("gb")]
	private ButtonX _gb;

	private string[] dir;

	internal virtual ListBox lstdir
	{
		[DebuggerNonUserCode]
		get
		{
			return _lstdir;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = lstdir_SelectedIndexChanged;
			if (_lstdir != null)
			{
				_lstdir.remove_SelectedIndexChanged(eventHandler);
			}
			_lstdir = value;
			if (_lstdir != null)
			{
				_lstdir.add_SelectedIndexChanged(eventHandler);
			}
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

	internal virtual ListBox lstjg
	{
		[DebuggerNonUserCode]
		get
		{
			return _lstjg;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = lstjg_SelectedIndexChanged;
			if (_lstjg != null)
			{
				_lstjg.remove_SelectedIndexChanged(eventHandler);
			}
			_lstjg = value;
			if (_lstjg != null)
			{
				_lstjg.add_SelectedIndexChanged(eventHandler);
			}
		}
	}

	internal virtual ListBox log
	{
		[DebuggerNonUserCode]
		get
		{
			return _log;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = log_SelectedIndexChanged;
			if (_log != null)
			{
				_log.remove_SelectedIndexChanged(eventHandler);
			}
			_log = value;
			if (_log != null)
			{
				_log.add_SelectedIndexChanged(eventHandler);
			}
		}
	}

	internal virtual LabelX LabelX3
	{
		[DebuggerNonUserCode]
		get
		{
			return _LabelX3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_LabelX3 = value;
		}
	}

	internal virtual ListBox lstnr
	{
		[DebuggerNonUserCode]
		get
		{
			return _lstnr;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lstnr = value;
		}
	}

	internal virtual LabelX LabelX4
	{
		[DebuggerNonUserCode]
		get
		{
			return _LabelX4;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_LabelX4 = value;
		}
	}

	internal virtual ButtonX btnsy
	{
		[DebuggerNonUserCode]
		get
		{
			return _btnsy;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = btnsy_Click;
			if (_btnsy != null)
			{
				((Control)_btnsy).remove_Click(eventHandler);
			}
			_btnsy = value;
			if (_btnsy != null)
			{
				((Control)_btnsy).add_Click(eventHandler);
			}
		}
	}

	internal virtual ButtonX btnsc
	{
		[DebuggerNonUserCode]
		get
		{
			return _btnsc;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = btnsc_Click;
			if (_btnsc != null)
			{
				((Control)_btnsc).remove_Click(eventHandler);
			}
			_btnsc = value;
			if (_btnsc != null)
			{
				((Control)_btnsc).add_Click(eventHandler);
			}
		}
	}

	internal virtual ButtonX btnsclis
	{
		[DebuggerNonUserCode]
		get
		{
			return _btnsclis;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = btnsclis_Click;
			if (_btnsclis != null)
			{
				((Control)_btnsclis).remove_Click(eventHandler);
			}
			_btnsclis = value;
			if (_btnsclis != null)
			{
				((Control)_btnsclis).add_Click(eventHandler);
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

	[DebuggerNonUserCode]
	public gxlisfile()
	{
		((Form)this).add_Load((EventHandler)gxlisfile_Load);
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
		//IL_0634: Unknown result type (might be due to invalid IL or missing references)
		//IL_063e: Expected O, but got Unknown
		//IL_0723: Unknown result type (might be due to invalid IL or missing references)
		//IL_072d: Expected O, but got Unknown
		lstdir = new ListBox();
		LabelX1 = new LabelX();
		lstjg = new ListBox();
		log = new ListBox();
		LabelX3 = new LabelX();
		lstnr = new ListBox();
		LabelX4 = new LabelX();
		btnsy = new ButtonX();
		btnsc = new ButtonX();
		btnsclis = new ButtonX();
		gb = new ButtonX();
		((Control)this).SuspendLayout();
		((ListControl)lstdir).set_FormattingEnabled(true);
		lstdir.set_ItemHeight(12);
		ListBox obj = lstdir;
		Point location = new Point(12, 26);
		((Control)obj).set_Location(location);
		((Control)lstdir).set_Name("lstdir");
		ListBox obj2 = lstdir;
		Size size = new Size(367, 184);
		((Control)obj2).set_Size(size);
		((Control)lstdir).set_TabIndex(0);
		((BaseItemControl)LabelX1).get_BackgroundStyle().set_Class("");
		((BaseItemControl)LabelX1).get_BackgroundStyle().set_CornerType((eCornerType)1);
		LabelX labelX = LabelX1;
		location = new Point(12, 6);
		((Control)labelX).set_Location(location);
		((Control)LabelX1).set_Name("LabelX1");
		LabelX labelX2 = LabelX1;
		size = new Size(119, 16);
		((Control)labelX2).set_Size(size);
		((Control)LabelX1).set_TabIndex(1);
		LabelX1.set_Text("部件文件夹");
		lstjg.set_BackColor(Color.Gray);
		lstjg.set_ForeColor(Color.White);
		((ListControl)lstjg).set_FormattingEnabled(true);
		lstjg.set_ItemHeight(12);
		ListBox obj3 = lstjg;
		location = new Point(385, 26);
		((Control)obj3).set_Location(location);
		((Control)lstjg).set_Name("lstjg");
		ListBox obj4 = lstjg;
		size = new Size(44, 184);
		((Control)obj4).set_Size(size);
		((Control)lstjg).set_TabIndex(0);
		((ListControl)log).set_FormattingEnabled(true);
		log.set_ItemHeight(12);
		ListBox obj5 = log;
		location = new Point(12, 236);
		((Control)obj5).set_Location(location);
		((Control)log).set_Name("log");
		ListBox obj6 = log;
		size = new Size(537, 160);
		((Control)obj6).set_Size(size);
		((Control)log).set_TabIndex(0);
		((BaseItemControl)LabelX3).get_BackgroundStyle().set_Class("");
		((BaseItemControl)LabelX3).get_BackgroundStyle().set_CornerType((eCornerType)1);
		LabelX labelX3 = LabelX3;
		location = new Point(12, 213);
		((Control)labelX3).set_Location(location);
		((Control)LabelX3).set_Name("LabelX3");
		LabelX labelX4 = LabelX3;
		size = new Size(263, 17);
		((Control)labelX4).set_Size(size);
		((Control)LabelX3).set_TabIndex(1);
		LabelX3.set_Text("当前.lis文件处理(单击列表文件可查看内容)");
		lstnr.set_BackColor(Color.Gray);
		lstnr.set_ForeColor(SystemColors.Info);
		((ListControl)lstnr).set_FormattingEnabled(true);
		lstnr.set_ItemHeight(12);
		ListBox obj7 = lstnr;
		location = new Point(12, 424);
		((Control)obj7).set_Location(location);
		((Control)lstnr).set_Name("lstnr");
		ListBox obj8 = lstnr;
		size = new Size(537, 124);
		((Control)obj8).set_Size(size);
		((Control)lstnr).set_TabIndex(0);
		((BaseItemControl)LabelX4).get_BackgroundStyle().set_Class("");
		((BaseItemControl)LabelX4).get_BackgroundStyle().set_CornerType((eCornerType)1);
		LabelX labelX5 = LabelX4;
		location = new Point(12, 402);
		((Control)labelX5).set_Location(location);
		((Control)LabelX4).set_Name("LabelX4");
		LabelX labelX6 = LabelX4;
		size = new Size(221, 16);
		((Control)labelX6).set_Size(size);
		((Control)LabelX4).set_TabIndex(1);
		LabelX4.set_Text("显示当前选中的.lis文件内容");
		((Control)btnsy).set_AccessibleRole((AccessibleRole)43);
		btnsy.set_ColorTable((eButtonColor)3);
		ButtonX obj9 = btnsy;
		location = new Point(435, 26);
		((Control)obj9).set_Location(location);
		((Control)btnsy).set_Name("btnsy");
		ButtonX obj10 = btnsy;
		size = new Size(114, 25);
		((Control)obj10).set_Size(size);
		((PopupItemControl)btnsy).set_Style((eDotNetBarStyle)7);
		((Control)btnsy).set_TabIndex(2);
		btnsy.set_Text("查找所有.lis文件");
		((Control)btnsc).set_AccessibleRole((AccessibleRole)43);
		btnsc.set_ColorTable((eButtonColor)3);
		ButtonX obj11 = btnsc;
		location = new Point(435, 57);
		((Control)obj11).set_Location(location);
		((Control)btnsc).set_Name("btnsc");
		ButtonX obj12 = btnsc;
		size = new Size(114, 25);
		((Control)obj12).set_Size(size);
		((PopupItemControl)btnsc).set_Style((eDotNetBarStyle)7);
		((Control)btnsc).set_TabIndex(2);
		btnsc.set_Text("删除所有.lis文件");
		((Control)btnsclis).set_AccessibleRole((AccessibleRole)43);
		btnsclis.set_ColorTable((eButtonColor)3);
		ButtonX obj13 = btnsclis;
		location = new Point(435, 88);
		((Control)obj13).set_Location(location);
		((Control)btnsclis).set_Name("btnsclis");
		ButtonX obj14 = btnsclis;
		size = new Size(114, 25);
		((Control)obj14).set_Size(size);
		((PopupItemControl)btnsclis).set_Style((eDotNetBarStyle)7);
		((Control)btnsclis).set_TabIndex(2);
		btnsclis.set_Text("生成所有.lis文件");
		((Control)gb).set_AccessibleRole((AccessibleRole)43);
		gb.set_ColorTable((eButtonColor)3);
		gb.set_DialogResult((DialogResult)2);
		ButtonX obj15 = gb;
		location = new Point(435, 185);
		((Control)obj15).set_Location(location);
		((Control)gb).set_Name("gb");
		ButtonX obj16 = gb;
		size = new Size(114, 25);
		((Control)obj16).set_Size(size);
		((PopupItemControl)gb).set_Style((eDotNetBarStyle)7);
		((Control)gb).set_TabIndex(2);
		gb.set_Text("关闭");
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)0);
		((Form)this).set_AutoSizeMode((AutoSizeMode)0);
		((Form)this).set_CancelButton((IButtonControl)(object)gb);
		((Office2007Form)this).set_CaptionFont(new Font("宋体", 9f, (FontStyle)0, (GraphicsUnit)3, (byte)134));
		size = new Size(561, 555);
		((Form)this).set_ClientSize(size);
		((Control)this).get_Controls().Add((Control)(object)gb);
		((Control)this).get_Controls().Add((Control)(object)btnsclis);
		((Control)this).get_Controls().Add((Control)(object)btnsc);
		((Control)this).get_Controls().Add((Control)(object)btnsy);
		((Control)this).get_Controls().Add((Control)(object)LabelX3);
		((Control)this).get_Controls().Add((Control)(object)LabelX4);
		((Control)this).get_Controls().Add((Control)(object)LabelX1);
		((Control)this).get_Controls().Add((Control)(object)log);
		((Control)this).get_Controls().Add((Control)(object)lstjg);
		((Control)this).get_Controls().Add((Control)(object)lstnr);
		((Control)this).get_Controls().Add((Control)(object)lstdir);
		((Control)this).set_Font(new Font("宋体", 9f, (FontStyle)0, (GraphicsUnit)3, (byte)134));
		((Form)this).set_FormBorderStyle((FormBorderStyle)3);
		((Form)this).set_MaximizeBox(false);
		((Form)this).set_MinimizeBox(false);
		((Control)this).set_Name("gxlisfile");
		((Form)this).set_ShowIcon(false);
		((Form)this).set_ShowInTaskbar(false);
		((Form)this).set_StartPosition((FormStartPosition)1);
		((Form)this).set_Text("更新当前库中子列表信息...");
		((Control)this).ResumeLayout(false);
	}

	private void gxlisfile_Load(object sender, EventArgs e)
	{
		checked
		{
			if (lstdir.get_Items().get_Count() == 0)
			{
				dir = Directory.GetDirectories(Mod1.Kulujing);
				int num = dir.Length - 1;
				for (int i = 0; i <= num; i++)
				{
					string text = dir[i];
					text = text.Substring(text.LastIndexOf("\\") + 1);
					lstdir.get_Items().Add((object)text);
				}
			}
		}
	}

	private void gb_Click(object sender, EventArgs e)
	{
		checked
		{
			if (log.get_Items().get_Count() != 0)
			{
				int num = log.get_Items().get_Count() - 1;
				for (int i = 0; i <= num; i++)
				{
					MyProject.Forms.mxkgl.log.get_Items().Add(RuntimeHelpers.GetObjectValue(log.get_Items().get_Item(i)));
				}
			}
			log.get_Items().Clear();
			MyProject.Forms.mxkgl.log.get_Items().Add((object)(Conversions.ToString(DateTime.Now) + " 操作员关闭了更新当前库中子列表信息对话框"));
			((Form)this).Close();
		}
	}

	private void btnsy_Click(object sender, EventArgs e)
	{
		log.get_Items().Add((object)(Conversions.ToString(DateTime.Now) + " 操作员查找了当前模型库文件夹中所有的.lis文件。"));
		checked
		{
			int num = dir.Length - 1;
			for (int i = 0; i <= num; i++)
			{
				string[] files = Directory.GetFiles(dir[i], "*.lis", SearchOption.AllDirectories);
				int num2 = files.Length - 1;
				for (int j = 0; j <= num2; j++)
				{
					log.get_Items().Add((object)files[j]);
				}
				if (files.Length == 0)
				{
					log.get_Items().Add((object)(Conversions.ToString(DateTime.Now) + " " + dir[i] + " 没有找到.lis文件！ "));
				}
			}
			log.set_SelectedIndex(log.get_Items().get_Count() - 1);
		}
	}

	private void log_SelectedIndexChanged(object sender, EventArgs e)
	{
		lstnr.get_Items().Clear();
		if (!File.Exists(log.get_Text()))
		{
			return;
		}
		Mod1.lr = new StreamReader(log.get_Text(), Encoding.Default);
		string text = "";
		while (!Information.IsNothing((object)text))
		{
			text = Mod1.lr.ReadLine();
			if (Information.IsNothing((object)text))
			{
				break;
			}
			lstnr.get_Items().Add((object)text);
		}
		Mod1.lr.Close();
		Mod1.lr.Dispose();
	}

	[MethodImpl(MethodImplOptions.NoOptimization)]
	private void btnsc_Click(object sender, EventArgs e)
	{
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Invalid comparison between Unknown and I4
		checked
		{
			if (unchecked((int)MessageBox.Show("你确定要删除当前库下的所有【.lis】文件吗？", "重要提示", (MessageBoxButtons)4, (MessageBoxIcon)64)) == 6)
			{
				log.get_Items().Add((object)(Conversions.ToString(DateTime.Now) + " 操作员删除了当前模型库文件夹中所有的.lis文件。"));
				lstjg.get_Items().Clear();
				int num = dir.Length - 1;
				for (int i = 0; i <= num; i++)
				{
					lstjg.get_Items().Add((object)"×");
					string[] files = Directory.GetFiles(dir[i], "*.lis", SearchOption.AllDirectories);
					if (files.Length != 0)
					{
						int num2 = files.Length - 1;
						for (int j = 0; j <= num2; j++)
						{
							FileSystem.Kill(files[j]);
						}
						log.get_Items().Add((object)(Conversions.ToString(DateTime.Now) + " " + dir[i] + " .lis 文件删除完毕。"));
					}
					else
					{
						log.get_Items().Add((object)(Conversions.ToString(DateTime.Now) + " " + dir[i] + ".lis 文件不存在！"));
					}
				}
			}
			log.set_SelectedIndex(log.get_Items().get_Count() - 1);
		}
	}

	private void btnsclis_Click(object sender, EventArgs e)
	{
		lstjg.get_Items().Clear();
		log.get_Items().Add((object)(Conversions.ToString(DateTime.Now) + " 操作员生成了当前模型库文件夹中所有的.lis文件。"));
		checked
		{
			int num = dir.Length - 1;
			for (int i = 0; i <= num; i++)
			{
				string text = dir[i];
				text = text.Substring(text.LastIndexOf("\\") + 1);
				string[] directories = Directory.GetDirectories(dir[i]);
				log.get_Items().Add((object)(Conversions.ToString(DateTime.Now) + " " + dir[i] + " 生成完毕！"));
				lstjg.get_Items().Add((object)"√");
				int num2 = directories.Length - 1;
				for (int j = 0; j <= num2; j++)
				{
					string text2 = directories[j];
					text2 = text2.Substring(text2.LastIndexOf("\\") + 1);
					if (Operators.CompareString(Mod1.toch(text2), "", false) == 0)
					{
						continue;
					}
					if (!File.Exists(dir[i] + "\\" + text + ".lis"))
					{
						Mod1.wr = new StreamWriter(dir[i] + "\\" + text + ".lis", append: true, Encoding.Default);
						Mod1.wr.WriteLine(Mod1.toch(text2));
						Mod1.wr.Close();
					}
					else
					{
						string path = dir[i] + "\\" + text + ".lis";
						string nr = Mod1.toch(text2);
						if (Operators.ConditionalCompareObjectNotEqual(Checklis(ref path, ref nr), (object)false, false))
						{
							Mod1.wr = new StreamWriter(dir[i] + "\\" + text + ".lis", append: true, Encoding.Default);
							Mod1.wr.WriteLine(Mod1.toch(text2));
							Mod1.wr.Close();
						}
					}
					string[] directories2 = Directory.GetDirectories(dir[i] + "\\" + text2);
					int num3 = directories2.Length - 1;
					for (int k = 0; k <= num3; k++)
					{
						string text3 = directories2[k];
						text3 = text3.Substring(text3.LastIndexOf("\\") + 1);
						if (Operators.CompareString(Mod1.toch(text3), "", false) == 0)
						{
							continue;
						}
						if (!File.Exists(dir[i] + "\\" + text2 + "\\" + text2 + ".lis"))
						{
							StreamWriter streamWriter = new StreamWriter(dir[i] + "\\" + text2 + "\\" + text2 + ".lis", append: true, Encoding.Default);
							streamWriter.WriteLine(Mod1.toch(text3));
							streamWriter.Close();
							continue;
						}
						string nr = dir[i] + "\\" + text2 + "\\" + text2 + ".lis";
						string path = Mod1.toch(text3);
						if (Operators.ConditionalCompareObjectNotEqual(Checklis(ref nr, ref path), (object)false, false))
						{
							StreamWriter streamWriter = new StreamWriter(dir[i] + "\\" + text2 + "\\" + text2 + ".lis", append: true, Encoding.Default);
							streamWriter.WriteLine(Mod1.toch(text3));
							streamWriter.Close();
						}
					}
				}
			}
			log.get_Items().Add((object)(Conversions.ToString(DateTime.Now) + " .lis文件生成完毕！"));
			log.set_SelectedIndex(log.get_Items().get_Count() - 1);
		}
	}

	[MethodImpl(MethodImplOptions.NoOptimization)]
	public void dellis()
	{
		checked
		{
			int num = dir.Length - 1;
			for (int i = 0; i <= num; i++)
			{
				string[] files = Directory.GetFiles(dir[i], "*.lis", SearchOption.AllDirectories);
				if (files.Length != 0)
				{
					int num2 = files.Length - 1;
					for (int j = 0; j <= num2; j++)
					{
						FileSystem.Kill(files[j]);
					}
				}
			}
		}
	}

	private void lstdir_SelectedIndexChanged(object sender, EventArgs e)
	{
		if (lstjg.get_Items().get_Count() != 0)
		{
			lstjg.set_SelectedIndex(lstdir.get_SelectedIndex());
		}
	}

	private void lstjg_SelectedIndexChanged(object sender, EventArgs e)
	{
		if (lstdir.get_Items().get_Count() != 0)
		{
			lstdir.set_SelectedIndex(lstjg.get_SelectedIndex());
		}
	}

	public object Checklis(ref string path, ref string nr)
	{
		Mod1.lr = new StreamReader(path, Encoding.Default);
		string text = "";
		object result = default(object);
		while (!Information.IsNothing((object)text))
		{
			text = Mod1.lr.ReadLine();
			if (Information.IsNothing((object)text))
			{
				break;
			}
			if (Operators.CompareString(nr, text, false) != 0)
			{
				result = true;
				continue;
			}
			result = false;
			break;
		}
		Mod1.lr.Close();
		Mod1.lr.Dispose();
		return result;
	}
}
