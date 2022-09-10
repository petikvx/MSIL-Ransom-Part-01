using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using xxx.My;

namespace xxx;

[DesignerGenerated]
public class ll_ufjmcheckall : Office2007Form
{
	private IContainer components;

	[AccessedThroughProperty("LabelX1")]
	private LabelX _LabelX1;

	[AccessedThroughProperty("btnexit")]
	private ButtonX _btnexit;

	[AccessedThroughProperty("ll_btncheck")]
	private ButtonX _ll_btncheck;

	[AccessedThroughProperty("ll_btnjs")]
	private ButtonX _ll_btnjs;

	[AccessedThroughProperty("ll_btnsavetemp")]
	private ButtonX _ll_btnsavetemp;

	[AccessedThroughProperty("ll_bmp")]
	private PictureBox _ll_bmp;

	[AccessedThroughProperty("LabelX2")]
	private LabelX _LabelX2;

	[AccessedThroughProperty("ll_lbjmbmplist")]
	private ListBox _ll_lbjmbmplist;

	private string xfcjypath;

	private string strpath2;

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

	internal virtual ButtonX btnexit
	{
		[DebuggerNonUserCode]
		get
		{
			return _btnexit;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = btnexit_Click;
			if (_btnexit != null)
			{
				((Control)_btnexit).remove_Click(eventHandler);
			}
			_btnexit = value;
			if (_btnexit != null)
			{
				((Control)_btnexit).add_Click(eventHandler);
			}
		}
	}

	internal virtual ButtonX ll_btncheck
	{
		[DebuggerNonUserCode]
		get
		{
			return _ll_btncheck;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = ll_btncheck_Click;
			if (_ll_btncheck != null)
			{
				((Control)_ll_btncheck).remove_Click(eventHandler);
			}
			_ll_btncheck = value;
			if (_ll_btncheck != null)
			{
				((Control)_ll_btncheck).add_Click(eventHandler);
			}
		}
	}

	internal virtual ButtonX ll_btnjs
	{
		[DebuggerNonUserCode]
		get
		{
			return _ll_btnjs;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = ll_btnjs_Click;
			if (_ll_btnjs != null)
			{
				((Control)_ll_btnjs).remove_Click(eventHandler);
			}
			_ll_btnjs = value;
			if (_ll_btnjs != null)
			{
				((Control)_ll_btnjs).add_Click(eventHandler);
			}
		}
	}

	internal virtual ButtonX ll_btnsavetemp
	{
		[DebuggerNonUserCode]
		get
		{
			return _ll_btnsavetemp;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = ll_btnsavetemp_Click;
			if (_ll_btnsavetemp != null)
			{
				((Control)_ll_btnsavetemp).remove_Click(eventHandler);
			}
			_ll_btnsavetemp = value;
			if (_ll_btnsavetemp != null)
			{
				((Control)_ll_btnsavetemp).add_Click(eventHandler);
			}
		}
	}

	internal virtual PictureBox ll_bmp
	{
		[DebuggerNonUserCode]
		get
		{
			return _ll_bmp;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = ll_bmp_Click;
			if (_ll_bmp != null)
			{
				((Control)_ll_bmp).remove_Click(eventHandler);
			}
			_ll_bmp = value;
			if (_ll_bmp != null)
			{
				((Control)_ll_bmp).add_Click(eventHandler);
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

	internal virtual ListBox ll_lbjmbmplist
	{
		[DebuggerNonUserCode]
		get
		{
			return _ll_lbjmbmplist;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = ll_lbjmbmplist_SelectedIndexChanged;
			if (_ll_lbjmbmplist != null)
			{
				_ll_lbjmbmplist.remove_SelectedIndexChanged(eventHandler);
			}
			_ll_lbjmbmplist = value;
			if (_ll_lbjmbmplist != null)
			{
				_ll_lbjmbmplist.add_SelectedIndexChanged(eventHandler);
			}
		}
	}

	public ll_ufjmcheckall()
	{
		((Form)this).add_Load((EventHandler)ll_ufjmcheckall_Load);
		xfcjypath = Application.get_StartupPath() + "\\config\\xfcjy";
		strpath2 = Application.get_StartupPath() + "\\config\\xfcjy\\work";
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
		//IL_048e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0498: Expected O, but got Unknown
		//IL_054a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0554: Expected O, but got Unknown
		LabelX1 = new LabelX();
		btnexit = new ButtonX();
		ll_btncheck = new ButtonX();
		ll_btnjs = new ButtonX();
		ll_btnsavetemp = new ButtonX();
		ll_bmp = new PictureBox();
		LabelX2 = new LabelX();
		ll_lbjmbmplist = new ListBox();
		((ISupportInitialize)ll_bmp).BeginInit();
		((Control)this).SuspendLayout();
		((BaseItemControl)LabelX1).get_BackgroundStyle().set_Class("");
		((BaseItemControl)LabelX1).get_BackgroundStyle().set_CornerType((eCornerType)1);
		LabelX labelX = LabelX1;
		Point location = new Point(12, 425);
		((Control)labelX).set_Location(location);
		((Control)LabelX1).set_Name("LabelX1");
		LabelX labelX2 = LabelX1;
		Size size = new Size(438, 15);
		((Control)labelX2).set_Size(size);
		((Control)LabelX1).set_TabIndex(8);
		((Control)btnexit).set_AccessibleRole((AccessibleRole)43);
		btnexit.set_ColorTable((eButtonColor)3);
		btnexit.set_DialogResult((DialogResult)2);
		ButtonX obj = btnexit;
		location = new Point(561, 392);
		((Control)obj).set_Location(location);
		((Control)btnexit).set_Name("btnexit");
		ButtonX obj2 = btnexit;
		size = new Size(123, 30);
		((Control)obj2).set_Size(size);
		((PopupItemControl)btnexit).set_Style((eDotNetBarStyle)7);
		((Control)btnexit).set_TabIndex(6);
		btnexit.set_Text("关闭");
		((Control)ll_btncheck).set_AccessibleRole((AccessibleRole)43);
		ll_btncheck.set_ColorTable((eButtonColor)3);
		((Control)ll_btncheck).set_Enabled(false);
		ButtonX obj3 = ll_btncheck;
		location = new Point(561, 84);
		((Control)obj3).set_Location(location);
		((Control)ll_btncheck).set_Name("ll_btncheck");
		ButtonX obj4 = ll_btncheck;
		size = new Size(123, 30);
		((Control)obj4).set_Size(size);
		((PopupItemControl)ll_btncheck).set_Style((eDotNetBarStyle)7);
		((Control)ll_btncheck).set_TabIndex(7);
		ll_btncheck.set_Text("提取截面图片列表");
		((Control)ll_btnjs).set_AccessibleRole((AccessibleRole)43);
		ll_btnjs.set_ColorTable((eButtonColor)3);
		((Control)ll_btnjs).set_Enabled(false);
		ButtonX obj5 = ll_btnjs;
		location = new Point(561, 48);
		((Control)obj5).set_Location(location);
		((Control)ll_btnjs).set_Name("ll_btnjs");
		ButtonX obj6 = ll_btnjs;
		size = new Size(123, 30);
		((Control)obj6).set_Size(size);
		((PopupItemControl)ll_btnjs).set_Style((eDotNetBarStyle)7);
		((Control)ll_btnjs).set_TabIndex(4);
		ll_btnjs.set_Text("运算");
		((Control)ll_btnsavetemp).set_AccessibleRole((AccessibleRole)43);
		ll_btnsavetemp.set_ColorTable((eButtonColor)3);
		ButtonX obj7 = ll_btnsavetemp;
		location = new Point(561, 12);
		((Control)obj7).set_Location(location);
		((Control)ll_btnsavetemp).set_Name("ll_btnsavetemp");
		ButtonX obj8 = ll_btnsavetemp;
		size = new Size(123, 30);
		((Control)obj8).set_Size(size);
		((PopupItemControl)ll_btnsavetemp).set_Style((eDotNetBarStyle)7);
		((Control)ll_btnsavetemp).set_TabIndex(5);
		ll_btnsavetemp.set_Text("更新系列截面文件");
		ll_bmp.set_BorderStyle((BorderStyle)1);
		PictureBox obj9 = ll_bmp;
		location = new Point(12, 12);
		((Control)obj9).set_Location(location);
		((Control)ll_bmp).set_Name("ll_bmp");
		PictureBox obj10 = ll_bmp;
		size = new Size(543, 410);
		((Control)obj10).set_Size(size);
		ll_bmp.set_TabIndex(3);
		ll_bmp.set_TabStop(false);
		((BaseItemControl)LabelX2).get_BackgroundStyle().set_Class("");
		((BaseItemControl)LabelX2).get_BackgroundStyle().set_CornerType((eCornerType)1);
		LabelX labelX3 = LabelX2;
		location = new Point(561, 128);
		((Control)labelX3).set_Location(location);
		((Control)LabelX2).set_Name("LabelX2");
		LabelX labelX4 = LabelX2;
		size = new Size(119, 15);
		((Control)labelX4).set_Size(size);
		((Control)LabelX2).set_TabIndex(0);
		LabelX2.set_Text("截面图片列表");
		((ListControl)ll_lbjmbmplist).set_FormattingEnabled(true);
		ll_lbjmbmplist.set_ItemHeight(12);
		ListBox obj11 = ll_lbjmbmplist;
		location = new Point(561, 149);
		((Control)obj11).set_Location(location);
		((Control)ll_lbjmbmplist).set_Name("ll_lbjmbmplist");
		ListBox obj12 = ll_lbjmbmplist;
		size = new Size(123, 232);
		((Control)obj12).set_Size(size);
		((Control)ll_lbjmbmplist).set_TabIndex(9);
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)0);
		((Form)this).set_CancelButton((IButtonControl)(object)btnexit);
		((Office2007Form)this).set_CaptionFont(new Font("宋体", 9f, (FontStyle)0, (GraphicsUnit)3, (byte)134));
		size = new Size(692, 442);
		((Form)this).set_ClientSize(size);
		((Control)this).get_Controls().Add((Control)(object)ll_lbjmbmplist);
		((Control)this).get_Controls().Add((Control)(object)LabelX2);
		((Control)this).get_Controls().Add((Control)(object)LabelX1);
		((Control)this).get_Controls().Add((Control)(object)btnexit);
		((Control)this).get_Controls().Add((Control)(object)ll_btncheck);
		((Control)this).get_Controls().Add((Control)(object)ll_btnjs);
		((Control)this).get_Controls().Add((Control)(object)ll_btnsavetemp);
		((Control)this).get_Controls().Add((Control)(object)ll_bmp);
		((Control)this).set_Font(new Font("宋体", 9f, (FontStyle)0, (GraphicsUnit)3, (byte)134));
		((Form)this).set_FormBorderStyle((FormBorderStyle)3);
		((Form)this).set_MaximizeBox(false);
		((Form)this).set_MinimizeBox(false);
		((Control)this).set_Name("ll_ufjmcheckall");
		((Form)this).set_ShowIcon(false);
		((Form)this).set_ShowInTaskbar(false);
		((Form)this).set_StartPosition((FormStartPosition)1);
		((Form)this).set_Text("ll_ufjmcheckall");
		((ISupportInitialize)ll_bmp).EndInit();
		((Control)this).ResumeLayout(false);
	}

	private void btnexit_Click(object sender, EventArgs e)
	{
		((Form)this).Close();
	}

	private void ll_ufjmcheckall_Load(object sender, EventArgs e)
	{
		((Form)this).set_Text("截面数据信息.. .");
		((Control)ll_btnjs).set_Enabled(false);
	}

	[MethodImpl(MethodImplOptions.NoOptimization)]
	private void ll_btnsavetemp_Click(object sender, EventArgs e)
	{
		checked
		{
			if (Operators.CompareString(Strings.Trim(MyProject.Forms.jmsaveinfo.sourcefilepath), "", false) != 0)
			{
				string path = MyProject.Forms.jmsaveinfo.sourcefilepath + "\\source\\var\\sect\\";
				string[] files = Directory.GetFiles(path, "*.var", SearchOption.TopDirectoryOnly);
				int num = files.Count() - 1;
				for (int i = 0; i <= num; i++)
				{
					string text = files[i];
					FileSystem.FileCopy(text, Strings.Replace(text, MyProject.Forms.jmsaveinfo.sourcefilepath + "\\source", xfcjypath, 1, -1, (CompareMethod)0));
				}
			}
			((Control)ll_btnjs).set_Enabled(true);
			LabelX1.set_Text("当前文件已更新:" + Conversions.ToString(DateTime.Now));
			((Control)ll_btnjs).set_Enabled(true);
			ll_lbjmbmplist.get_Items().Clear();
		}
	}

	private void ll_btnjs_Click(object sender, EventArgs e)
	{
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		string text = Application.get_StartupPath() + "\\config\\xfcjy";
		string text2 = text + "\\截面检验.bat";
		Interaction.Shell(text2, (AppWinStyle)2, false, -1);
		((Control)ll_btnjs).set_Enabled(false);
		((Control)ll_btncheck).set_Enabled(true);
		Interaction.MsgBox((object)"正在生成截面,请等待ansys执行完毕再进行查看.. .", (MsgBoxStyle)0, (object)"提示");
	}

	private void ll_btncheck_Click(object sender, EventArgs e)
	{
		ll_lbjmbmplist.get_Items().Clear();
		string[] files = Directory.GetFiles(strpath2, "JM_*.jpg", SearchOption.TopDirectoryOnly);
		checked
		{
			if (files.Length != 0)
			{
				int num = files.Count() - 1;
				for (int i = 0; i <= num; i++)
				{
					string text = files[i];
					int num2 = Strings.InStrRev(text, "\\", -1, (CompareMethod)0);
					string text2 = Strings.Right(text, Strings.Len(text) - num2);
					ll_lbjmbmplist.get_Items().Add((object)text2);
				}
				ll_lbjmbmplist.set_SelectedIndex(0);
			}
		}
	}

	private void ll_lbjmbmplist_SelectedIndexChanged(object sender, EventArgs e)
	{
		//IL_005d: Unknown result type (might be due to invalid IL or missing references)
		string text = Conversions.ToString(Operators.ConcatenateObject((object)(strpath2 + "\\"), ll_lbjmbmplist.get_Items().get_Item(ll_lbjmbmplist.get_SelectedIndex())));
		if (File.Exists(text))
		{
			ll_bmp.set_ImageLocation(text);
		}
		else
		{
			Interaction.MsgBox((object)(" 没有找到最新的截面图片文件" + text), (MsgBoxStyle)0, (object)"提示");
		}
	}

	private void ll_bmp_Click(object sender, EventArgs e)
	{
		checked
		{
			if (ll_lbjmbmplist.get_Items().get_Count() != 0)
			{
				if (ll_lbjmbmplist.get_SelectedIndex() != ll_lbjmbmplist.get_Items().get_Count() - 1)
				{
					ll_lbjmbmplist.set_SelectedIndex(ll_lbjmbmplist.get_SelectedIndex() + 1);
				}
				else
				{
					ll_lbjmbmplist.set_SelectedIndex(0);
				}
			}
		}
	}
}
