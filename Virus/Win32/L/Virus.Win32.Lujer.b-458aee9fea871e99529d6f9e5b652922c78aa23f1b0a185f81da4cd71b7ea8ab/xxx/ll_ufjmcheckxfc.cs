using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace xxx;

[DesignerGenerated]
public class ll_ufjmcheckxfc : Office2007Form
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

	[AccessedThroughProperty("ll_bmp")]
	private PictureBox _ll_bmp;

	[AccessedThroughProperty("ll_btncheckmodel")]
	private ButtonX _ll_btncheckmodel;

	private object xfcfilepath;

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
			_btnexit = value;
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
			_ll_bmp = value;
		}
	}

	internal virtual ButtonX ll_btncheckmodel
	{
		[DebuggerNonUserCode]
		get
		{
			return _ll_btncheckmodel;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = ll_btncheckmodel_Click;
			if (_ll_btncheckmodel != null)
			{
				((Control)_ll_btncheckmodel).remove_Click(eventHandler);
			}
			_ll_btncheckmodel = value;
			if (_ll_btncheckmodel != null)
			{
				((Control)_ll_btncheckmodel).add_Click(eventHandler);
			}
		}
	}

	public ll_ufjmcheckxfc()
	{
		((Form)this).add_Load((EventHandler)ll_ufjmcheckxfc_Load);
		xfcfilepath = Application.get_StartupPath() + "\\config\\xfcjy";
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
		//IL_0371: Unknown result type (might be due to invalid IL or missing references)
		//IL_037b: Expected O, but got Unknown
		//IL_040b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0415: Expected O, but got Unknown
		LabelX1 = new LabelX();
		btnexit = new ButtonX();
		ll_btncheck = new ButtonX();
		ll_btnjs = new ButtonX();
		ll_bmp = new PictureBox();
		ll_btncheckmodel = new ButtonX();
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
		location = new Point(561, 120);
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
		ButtonX obj3 = ll_btncheck;
		location = new Point(561, 48);
		((Control)obj3).set_Location(location);
		((Control)ll_btncheck).set_Name("ll_btncheck");
		ButtonX obj4 = ll_btncheck;
		size = new Size(123, 30);
		((Control)obj4).set_Size(size);
		((PopupItemControl)ll_btncheck).set_Style((eDotNetBarStyle)7);
		((Control)ll_btncheck).set_TabIndex(7);
		ll_btncheck.set_Text("查看模型图片");
		((Control)ll_btnjs).set_AccessibleRole((AccessibleRole)43);
		ll_btnjs.set_ColorTable((eButtonColor)3);
		ButtonX obj5 = ll_btnjs;
		location = new Point(561, 12);
		((Control)obj5).set_Location(location);
		((Control)ll_btnjs).set_Name("ll_btnjs");
		ButtonX obj6 = ll_btnjs;
		size = new Size(123, 30);
		((Control)obj6).set_Size(size);
		((PopupItemControl)ll_btnjs).set_Style((eDotNetBarStyle)7);
		((Control)ll_btnjs).set_TabIndex(4);
		ll_btnjs.set_Text("运算");
		ll_bmp.set_BorderStyle((BorderStyle)1);
		PictureBox obj7 = ll_bmp;
		location = new Point(12, 12);
		((Control)obj7).set_Location(location);
		((Control)ll_bmp).set_Name("ll_bmp");
		PictureBox obj8 = ll_bmp;
		size = new Size(543, 410);
		((Control)obj8).set_Size(size);
		ll_bmp.set_TabIndex(3);
		ll_bmp.set_TabStop(false);
		((Control)ll_btncheckmodel).set_AccessibleRole((AccessibleRole)43);
		ll_btncheckmodel.set_ColorTable((eButtonColor)3);
		ButtonX obj9 = ll_btncheckmodel;
		location = new Point(561, 84);
		((Control)obj9).set_Location(location);
		((Control)ll_btncheckmodel).set_Name("ll_btncheckmodel");
		ButtonX obj10 = ll_btncheckmodel;
		size = new Size(123, 30);
		((Control)obj10).set_Size(size);
		((PopupItemControl)ll_btncheckmodel).set_Style((eDotNetBarStyle)7);
		((Control)ll_btncheckmodel).set_TabIndex(5);
		ll_btncheckmodel.set_Text("查看模型");
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)0);
		((Form)this).set_AutoSizeMode((AutoSizeMode)0);
		((Form)this).set_CancelButton((IButtonControl)(object)btnexit);
		((Office2007Form)this).set_CaptionFont(new Font("宋体", 9f, (FontStyle)0, (GraphicsUnit)3, (byte)134));
		size = new Size(700, 443);
		((Form)this).set_ClientSize(size);
		((Control)this).get_Controls().Add((Control)(object)LabelX1);
		((Control)this).get_Controls().Add((Control)(object)btnexit);
		((Control)this).get_Controls().Add((Control)(object)ll_btncheck);
		((Control)this).get_Controls().Add((Control)(object)ll_btnjs);
		((Control)this).get_Controls().Add((Control)(object)ll_btncheckmodel);
		((Control)this).get_Controls().Add((Control)(object)ll_bmp);
		((Control)this).set_Font(new Font("宋体", 9f, (FontStyle)0, (GraphicsUnit)3, (byte)134));
		((Form)this).set_FormBorderStyle((FormBorderStyle)3);
		((Form)this).set_MaximizeBox(false);
		((Form)this).set_MinimizeBox(false);
		((Control)this).set_Name("ll_ufjmcheckxfc");
		((Form)this).set_ShowIcon(false);
		((Form)this).set_ShowInTaskbar(false);
		((Form)this).set_StartPosition((FormStartPosition)1);
		((ISupportInitialize)ll_bmp).EndInit();
		((Control)this).ResumeLayout(false);
	}

	private void ll_ufjmcheckxfc_Load(object sender, EventArgs e)
	{
		((Form)this).set_Text("已更新当前截面和结构数据信息.. .");
	}

	private void ll_btnjs_Click(object sender, EventArgs e)
	{
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		string text = Conversions.ToString(Operators.ConcatenateObject(xfcfilepath, (object)"\\计算模型.bat"));
		Interaction.Shell(text, (AppWinStyle)2, false, -1);
		((Control)ll_btnjs).set_Enabled(false);
		LabelX1.set_Text("当前文件已更新:" + Conversions.ToString(DateTime.Now));
		Interaction.MsgBox((object)"正在生成模型,请等待ansys执行完毕再进行查看.. .", (MsgBoxStyle)0, (object)"提示");
	}

	private void ll_btncheck_Click(object sender, EventArgs e)
	{
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		string text = Conversions.ToString(Operators.ConcatenateObject(xfcfilepath, (object)"\\work\\DG_ALL.JPG"));
		if (File.Exists(text))
		{
			ll_bmp.set_ImageLocation(text);
		}
		else
		{
			Interaction.MsgBox((object)(" 没有找到最新的截面图片文件" + text), (MsgBoxStyle)0, (object)"提示");
		}
	}

	[MethodImpl(MethodImplOptions.NoOptimization)]
	private void ll_btncheckmodel_Click(object sender, EventArgs e)
	{
		string text = Application.get_StartupPath() + "\\config\\xfcjy\\work\\start110.ans";
		string text2 = Application.get_StartupPath() + "\\config\\ansys110\\start110.ans";
		FileSystem.FileCopy(text2, text);
		xfcfilepath = Application.get_StartupPath() + "\\config\\xfcjy";
		string text3 = Conversions.ToString(Operators.ConcatenateObject(xfcfilepath, (object)"\\计算模型查看.bat"));
		Interaction.Shell(text3, (AppWinStyle)2, false, -1);
	}
}
