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
using Excel;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.Devices;
using xxx.My;

namespace xxx;

[DesignerGenerated]
public class fanjs : Office2007Form
{
	private IContainer components;

	[AccessedThroughProperty("ll_btncsvar")]
	private ButtonX _ll_btncsvar;

	[AccessedThroughProperty("ll_lbvarfilename")]
	private ListBox _ll_lbvarfilename;

	[AccessedThroughProperty("ll_btneditlcfile")]
	private ButtonX _ll_btneditlcfile;

	[AccessedThroughProperty("ll_lblcfilename")]
	private ListBox _ll_lblcfilename;

	[AccessedThroughProperty("ll_btnout")]
	private ButtonX _ll_btnout;

	[AccessedThroughProperty("ll_btnlookout")]
	private ButtonX _ll_btnlookout;

	[AccessedThroughProperty("ll_lbliucheng")]
	private ListBox _ll_lbliucheng;

	[AccessedThroughProperty("ll_btnexit")]
	private ButtonX _ll_btnexit;

	[AccessedThroughProperty("LabelX1")]
	private LabelX _LabelX1;

	[AccessedThroughProperty("LabelX2")]
	private LabelX _LabelX2;

	[AccessedThroughProperty("LabelX3")]
	private LabelX _LabelX3;

	[AccessedThroughProperty("ll_btnxfccheck")]
	private ButtonX _ll_btnxfccheck;

	public string curenhanceID;

	public string curvarfname;

	public string p;

	public string fp;

	internal virtual ButtonX ll_btncsvar
	{
		[DebuggerNonUserCode]
		get
		{
			return _ll_btncsvar;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = ll_btncsvar_Click;
			if (_ll_btncsvar != null)
			{
				((Control)_ll_btncsvar).remove_Click(eventHandler);
			}
			_ll_btncsvar = value;
			if (_ll_btncsvar != null)
			{
				((Control)_ll_btncsvar).add_Click(eventHandler);
			}
		}
	}

	internal virtual ListBox ll_lbvarfilename
	{
		[DebuggerNonUserCode]
		get
		{
			return _ll_lbvarfilename;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = ll_lbvarfilename_DoubleClick;
			if (_ll_lbvarfilename != null)
			{
				((Control)_ll_lbvarfilename).remove_DoubleClick(eventHandler);
			}
			_ll_lbvarfilename = value;
			if (_ll_lbvarfilename != null)
			{
				((Control)_ll_lbvarfilename).add_DoubleClick(eventHandler);
			}
		}
	}

	internal virtual ButtonX ll_btneditlcfile
	{
		[DebuggerNonUserCode]
		get
		{
			return _ll_btneditlcfile;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = ll_btneditlcfile_Click;
			if (_ll_btneditlcfile != null)
			{
				((Control)_ll_btneditlcfile).remove_Click(eventHandler);
			}
			_ll_btneditlcfile = value;
			if (_ll_btneditlcfile != null)
			{
				((Control)_ll_btneditlcfile).add_Click(eventHandler);
			}
		}
	}

	internal virtual ListBox ll_lblcfilename
	{
		[DebuggerNonUserCode]
		get
		{
			return _ll_lblcfilename;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = ll_lblcfilename_DoubleClick;
			if (_ll_lblcfilename != null)
			{
				((Control)_ll_lblcfilename).remove_DoubleClick(eventHandler);
			}
			_ll_lblcfilename = value;
			if (_ll_lblcfilename != null)
			{
				((Control)_ll_lblcfilename).add_DoubleClick(eventHandler);
			}
		}
	}

	internal virtual ButtonX ll_btnout
	{
		[DebuggerNonUserCode]
		get
		{
			return _ll_btnout;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = ll_btnout_Click;
			if (_ll_btnout != null)
			{
				((Control)_ll_btnout).remove_Click(eventHandler);
			}
			_ll_btnout = value;
			if (_ll_btnout != null)
			{
				((Control)_ll_btnout).add_Click(eventHandler);
			}
		}
	}

	internal virtual ButtonX ll_btnlookout
	{
		[DebuggerNonUserCode]
		get
		{
			return _ll_btnlookout;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = ll_btnlookout_Click;
			if (_ll_btnlookout != null)
			{
				((Control)_ll_btnlookout).remove_Click(eventHandler);
			}
			_ll_btnlookout = value;
			if (_ll_btnlookout != null)
			{
				((Control)_ll_btnlookout).add_Click(eventHandler);
			}
		}
	}

	internal virtual ListBox ll_lbliucheng
	{
		[DebuggerNonUserCode]
		get
		{
			return _ll_lbliucheng;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_ll_lbliucheng = value;
		}
	}

	internal virtual ButtonX ll_btnexit
	{
		[DebuggerNonUserCode]
		get
		{
			return _ll_btnexit;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = ll_btnexit_Click;
			if (_ll_btnexit != null)
			{
				((Control)_ll_btnexit).remove_Click(eventHandler);
			}
			_ll_btnexit = value;
			if (_ll_btnexit != null)
			{
				((Control)_ll_btnexit).add_Click(eventHandler);
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

	internal virtual ButtonX ll_btnxfccheck
	{
		[DebuggerNonUserCode]
		get
		{
			return _ll_btnxfccheck;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = ll_btnxfccheck_Click;
			if (_ll_btnxfccheck != null)
			{
				((Control)_ll_btnxfccheck).remove_Click(eventHandler);
			}
			_ll_btnxfccheck = value;
			if (_ll_btnxfccheck != null)
			{
				((Control)_ll_btnxfccheck).add_Click(eventHandler);
			}
		}
	}

	[DebuggerNonUserCode]
	public fanjs()
	{
		((Form)this).add_Load((EventHandler)fanjs_Load);
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
		//IL_06a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_06af: Expected O, but got Unknown
		//IL_07a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_07af: Expected O, but got Unknown
		ll_btncsvar = new ButtonX();
		ll_lbvarfilename = new ListBox();
		ll_btneditlcfile = new ButtonX();
		ll_lblcfilename = new ListBox();
		ll_btnout = new ButtonX();
		ll_btnlookout = new ButtonX();
		ll_lbliucheng = new ListBox();
		ll_btnexit = new ButtonX();
		LabelX1 = new LabelX();
		LabelX2 = new LabelX();
		LabelX3 = new LabelX();
		ll_btnxfccheck = new ButtonX();
		((Control)this).SuspendLayout();
		((Control)ll_btncsvar).set_AccessibleRole((AccessibleRole)43);
		ll_btncsvar.set_ColorTable((eButtonColor)3);
		ButtonX obj = ll_btncsvar;
		Point location = new Point(336, 4);
		((Control)obj).set_Location(location);
		((Control)ll_btncsvar).set_Name("ll_btncsvar");
		ButtonX obj2 = ll_btncsvar;
		Size size = new Size(116, 23);
		((Control)obj2).set_Size(size);
		((PopupItemControl)ll_btncsvar).set_Style((eDotNetBarStyle)7);
		((Control)ll_btncsvar).set_TabIndex(0);
		ll_btncsvar.set_Text("生成参数文本");
		((ListControl)ll_lbvarfilename).set_FormattingEnabled(true);
		ll_lbvarfilename.set_ItemHeight(12);
		ListBox obj3 = ll_lbvarfilename;
		location = new Point(12, 33);
		((Control)obj3).set_Location(location);
		((Control)ll_lbvarfilename).set_Name("ll_lbvarfilename");
		ListBox obj4 = ll_lbvarfilename;
		size = new Size(440, 208);
		((Control)obj4).set_Size(size);
		((Control)ll_lbvarfilename).set_TabIndex(0);
		((Control)ll_btneditlcfile).set_AccessibleRole((AccessibleRole)43);
		ll_btneditlcfile.set_ColorTable((eButtonColor)3);
		ButtonX obj5 = ll_btneditlcfile;
		location = new Point(336, 247);
		((Control)obj5).set_Location(location);
		((Control)ll_btneditlcfile).set_Name("ll_btneditlcfile");
		ButtonX obj6 = ll_btneditlcfile;
		size = new Size(116, 23);
		((Control)obj6).set_Size(size);
		((PopupItemControl)ll_btneditlcfile).set_Style((eDotNetBarStyle)7);
		((Control)ll_btneditlcfile).set_TabIndex(0);
		ll_btneditlcfile.set_Text("编辑工况文本");
		((ListControl)ll_lblcfilename).set_FormattingEnabled(true);
		ll_lblcfilename.set_ItemHeight(12);
		ListBox obj7 = ll_lblcfilename;
		location = new Point(12, 276);
		((Control)obj7).set_Location(location);
		((Control)ll_lblcfilename).set_Name("ll_lblcfilename");
		ListBox obj8 = ll_lblcfilename;
		size = new Size(440, 28);
		((Control)obj8).set_Size(size);
		((Control)ll_lblcfilename).set_TabIndex(0);
		((Control)ll_btnout).set_AccessibleRole((AccessibleRole)43);
		ll_btnout.set_ColorTable((eButtonColor)3);
		ButtonX obj9 = ll_btnout;
		location = new Point(336, 310);
		((Control)obj9).set_Location(location);
		((Control)ll_btnout).set_Name("ll_btnout");
		ButtonX obj10 = ll_btnout;
		size = new Size(116, 23);
		((Control)obj10).set_Size(size);
		((PopupItemControl)ll_btnout).set_Style((eDotNetBarStyle)7);
		((Control)ll_btnout).set_TabIndex(0);
		ll_btnout.set_Text("输出计算文件夹");
		((Control)ll_btnlookout).set_AccessibleRole((AccessibleRole)43);
		ll_btnlookout.set_ColorTable((eButtonColor)3);
		ButtonX obj11 = ll_btnlookout;
		location = new Point(12, 310);
		((Control)obj11).set_Location(location);
		((Control)ll_btnlookout).set_Name("ll_btnlookout");
		ButtonX obj12 = ll_btnlookout;
		size = new Size(116, 23);
		((Control)obj12).set_Size(size);
		((PopupItemControl)ll_btnlookout).set_Style((eDotNetBarStyle)7);
		((Control)ll_btnlookout).set_TabIndex(0);
		ll_btnlookout.set_Text("浏览输出文件夹");
		((ListControl)ll_lbliucheng).set_FormattingEnabled(true);
		ll_lbliucheng.set_ItemHeight(12);
		ListBox obj13 = ll_lbliucheng;
		location = new Point(12, 367);
		((Control)obj13).set_Location(location);
		((Control)ll_lbliucheng).set_Name("ll_lbliucheng");
		ListBox obj14 = ll_lbliucheng;
		size = new Size(440, 148);
		((Control)obj14).set_Size(size);
		((Control)ll_lbliucheng).set_TabIndex(0);
		((Control)ll_btnexit).set_AccessibleRole((AccessibleRole)43);
		ll_btnexit.set_ColorTable((eButtonColor)3);
		ll_btnexit.set_DialogResult((DialogResult)2);
		ButtonX obj15 = ll_btnexit;
		location = new Point(336, 338);
		((Control)obj15).set_Location(location);
		((Control)ll_btnexit).set_Name("ll_btnexit");
		ButtonX obj16 = ll_btnexit;
		size = new Size(116, 23);
		((Control)obj16).set_Size(size);
		((PopupItemControl)ll_btnexit).set_Style((eDotNetBarStyle)7);
		((Control)ll_btnexit).set_TabIndex(0);
		ll_btnexit.set_Text("关闭");
		((BaseItemControl)LabelX1).get_BackgroundStyle().set_Class("");
		((BaseItemControl)LabelX1).get_BackgroundStyle().set_CornerType((eCornerType)1);
		LabelX labelX = LabelX1;
		location = new Point(12, 4);
		((Control)labelX).set_Location(location);
		((Control)LabelX1).set_Name("LabelX1");
		LabelX labelX2 = LabelX1;
		size = new Size(224, 23);
		((Control)labelX2).set_Size(size);
		((Control)LabelX1).set_TabIndex(1);
		LabelX1.set_Text("说明:双击查看相应参数文本");
		((BaseItemControl)LabelX2).get_BackgroundStyle().set_Class("");
		((BaseItemControl)LabelX2).get_BackgroundStyle().set_CornerType((eCornerType)1);
		LabelX labelX3 = LabelX2;
		location = new Point(12, 247);
		((Control)labelX3).set_Location(location);
		((Control)LabelX2).set_Name("LabelX2");
		LabelX labelX4 = LabelX2;
		size = new Size(297, 23);
		((Control)labelX4).set_Size(size);
		((Control)LabelX2).set_TabIndex(1);
		LabelX2.set_Text("说明:双击打开并编辑工况文本,然后保存该文本.");
		((BaseItemControl)LabelX3).get_BackgroundStyle().set_Class("");
		((BaseItemControl)LabelX3).get_BackgroundStyle().set_CornerType((eCornerType)1);
		LabelX labelX5 = LabelX3;
		location = new Point(12, 344);
		((Control)labelX5).set_Location(location);
		((Control)LabelX3).set_Name("LabelX3");
		LabelX labelX6 = LabelX3;
		size = new Size(172, 17);
		((Control)labelX6).set_Size(size);
		((Control)LabelX3).set_TabIndex(1);
		LabelX3.set_Text("操作流程记录...");
		((Control)ll_btnxfccheck).set_AccessibleRole((AccessibleRole)43);
		ll_btnxfccheck.set_ColorTable((eButtonColor)3);
		ButtonX obj17 = ll_btnxfccheck;
		location = new Point(168, 310);
		((Control)obj17).set_Location(location);
		((Control)ll_btnxfccheck).set_Name("ll_btnxfccheck");
		ButtonX obj18 = ll_btnxfccheck;
		size = new Size(116, 23);
		((Control)obj18).set_Size(size);
		((PopupItemControl)ll_btnxfccheck).set_Style((eDotNetBarStyle)7);
		((Control)ll_btnxfccheck).set_TabIndex(0);
		ll_btnxfccheck.set_Text("预览整机模型");
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)0);
		((Form)this).set_AutoSizeMode((AutoSizeMode)0);
		((Form)this).set_CancelButton((IButtonControl)(object)ll_btnexit);
		((Office2007Form)this).set_CaptionFont(new Font("宋体", 9f, (FontStyle)0, (GraphicsUnit)3, (byte)134));
		size = new Size(464, 525);
		((Form)this).set_ClientSize(size);
		((Control)this).get_Controls().Add((Control)(object)ll_btneditlcfile);
		((Control)this).get_Controls().Add((Control)(object)LabelX3);
		((Control)this).get_Controls().Add((Control)(object)LabelX2);
		((Control)this).get_Controls().Add((Control)(object)LabelX1);
		((Control)this).get_Controls().Add((Control)(object)ll_lbliucheng);
		((Control)this).get_Controls().Add((Control)(object)ll_lblcfilename);
		((Control)this).get_Controls().Add((Control)(object)ll_btnxfccheck);
		((Control)this).get_Controls().Add((Control)(object)ll_btnlookout);
		((Control)this).get_Controls().Add((Control)(object)ll_btnexit);
		((Control)this).get_Controls().Add((Control)(object)ll_btnout);
		((Control)this).get_Controls().Add((Control)(object)ll_lbvarfilename);
		((Control)this).get_Controls().Add((Control)(object)ll_btncsvar);
		((Control)this).set_Font(new Font("宋体", 9f, (FontStyle)0, (GraphicsUnit)3, (byte)134));
		((Form)this).set_FormBorderStyle((FormBorderStyle)3);
		((Form)this).set_MaximizeBox(false);
		((Form)this).set_MinimizeBox(false);
		((Control)this).set_Name("fanjs");
		((Form)this).set_ShowIcon(false);
		((Form)this).set_ShowInTaskbar(false);
		((Form)this).set_StartPosition((FormStartPosition)1);
		((Form)this).set_Text("方案计算...");
		((Control)this).ResumeLayout(false);
	}

	private void ll_btncsvar_Click(object sender, EventArgs e)
	{
		//IL_064d: Unknown result type (might be due to invalid IL or missing references)
		ll_lbvarfilename.get_Items().Clear();
		int count = Mod1.wb.Worksheets.Count;
		int num = 1;
		checked
		{
			IEnumerator enumerator = default(IEnumerator);
			int column = default(int);
			while (true)
			{
				if (num > count)
				{
					return;
				}
				Mod1.excelsheet = (Worksheet)Mod1.wb.Sheets.get_Item((object)num);
				if ((Operators.CompareString(Mod1.excelsheet.Name, "动参数临时", false) != 0) & (Operators.CompareString(Mod1.excelsheet.Name, "参数校验", false) != 0))
				{
					int num2 = Strings.InStr(Mod1.excelsheet.Name, "_", (CompareMethod)0);
					if (num2 == 0)
					{
						break;
					}
					string text = Strings.Left(Mod1.excelsheet.Name, num2 - 1);
					string text2 = Mod1.toen(ref text) + "\\" + Strings.Right(Mod1.excelsheet.Name, Strings.Len(Mod1.excelsheet.Name) - num2);
					curvarfname = fp + "\\var\\" + text2 + ".VAR";
					ll_lbvarfilename.get_Items().Add((object)curvarfname);
					Mod1.wr = new StreamWriter(curvarfname, append: false, Encoding.Default);
					bool flag = true;
					try
					{
						enumerator = ((_Worksheet)Mod1.excelsheet).get_Range((object)"1:1", (object)Missing.Value).GetEnumerator();
						while (enumerator.MoveNext())
						{
							Excel.Range range = (Excel.Range)enumerator.Current;
							string text3 = Conversions.ToString(range.get_Value((object)Missing.Value));
							if (Operators.CompareString(Strings.Trim(text3), "", false) != 0)
							{
								if (Operators.CompareString(Strings.UCase(Strings.Trim(text3)), Strings.UCase(Strings.Trim(curenhanceID)), false) == 0)
								{
									column = range.Column;
									break;
								}
								continue;
							}
							flag = false;
							break;
						}
					}
					finally
					{
						if (enumerator is IDisposable)
						{
							(enumerator as IDisposable).Dispose();
						}
					}
					if (unchecked(flag && column > 4 && column < 200))
					{
						Excel.Range range = (Excel.Range)Mod1.excelsheet.Cells[Mod1.excelsheet.Cells.Rows.Count, column];
						int row = range.get_End(XlDirection.xlUp).Row;
						range = (Excel.Range)Mod1.excelsheet.Cells[1, Mod1.excelsheet.Cells.Columns.Count];
						int column2 = range.get_End(XlDirection.xlToLeft).Column;
						int num3 = row;
						for (int i = 2; i <= num3; i++)
						{
							if (Operators.CompareString(Strings.Trim(Conversions.ToString(NewLateBinding.LateGet(Mod1.excelsheet.Cells[i, column], (Type)null, "value", new object[0], (string[])null, (Type[])null, (bool[])null))), "1", false) == 0 && ((Operators.CompareString(Strings.Trim(Conversions.ToString(NewLateBinding.LateGet(Mod1.excelsheet.Cells[i, 2], (Type)null, "value", new object[0], (string[])null, (Type[])null, (bool[])null))), "", false) != 0) & (Operators.CompareString(Strings.Trim(Conversions.ToString(NewLateBinding.LateGet(Mod1.excelsheet.Cells[i, 3], (Type)null, "value", new object[0], (string[])null, (Type[])null, (bool[])null))), "", false) != 0)))
							{
								if (Operators.CompareString(Strings.Trim(Conversions.ToString(NewLateBinding.LateGet(Mod1.excelsheet.Cells[i, column2], (Type)null, "Value", new object[0], (string[])null, (Type[])null, (bool[])null))), "", false) != 0)
								{
									Mod1.wr.WriteLine(Strings.Trim(NewLateBinding.LateGet(Mod1.excelsheet.Cells[i, 2], (Type)null, "Value", new object[0], (string[])null, (Type[])null, (bool[])null).ToString()!.Replace("\t", " ")) + "=" + Strings.Trim(NewLateBinding.LateGet(Mod1.excelsheet.Cells[i, 3], (Type)null, "Value", new object[0], (string[])null, (Type[])null, (bool[])null).ToString()!.Replace("\t", " ")) + "!" + Strings.Trim(NewLateBinding.LateGet(Mod1.excelsheet.Cells[i, column2], (Type)null, "Value", new object[0], (string[])null, (Type[])null, (bool[])null).ToString()!.Replace("\t", " ")));
								}
								else
								{
									Mod1.wr.WriteLine(Strings.Trim(NewLateBinding.LateGet(Mod1.excelsheet.Cells[i, 2], (Type)null, "Value", new object[0], (string[])null, (Type[])null, (bool[])null).ToString()!.Replace("\t", " ")) + "=" + Strings.Trim(NewLateBinding.LateGet(Mod1.excelsheet.Cells[i, 3], (Type)null, "Value", new object[0], (string[])null, (Type[])null, (bool[])null).ToString()!.Replace("\t", " ")) + "!");
								}
							}
						}
					}
					Mod1.wr.WriteLine("\r\n");
					Mod1.wr.Close();
					Mod1.wr.Dispose();
					text2 = "【生成参数文本】--已更新当前参数信息文件.";
					ll_lbliucheng.get_Items().Add((object)text2);
					text2 = "所在路径:" + curvarfname;
					ll_lbliucheng.get_Items().Add((object)text2);
					ll_lbliucheng.set_SelectedIndex(ll_lbliucheng.get_Items().get_Count() - 1);
				}
				num++;
			}
			Interaction.MsgBox((object)("当前参数表中页面名称不合法,即不含有_,请确认是否为消防车结构参数表." + Mod1.excelsheet.Name), (MsgBoxStyle)64, (object)"提示");
		}
	}

	private void ll_lbvarfilename_DoubleClick(object sender, EventArgs e)
	{
		if (File.Exists(ll_lbvarfilename.get_Text()))
		{
			Process.Start(Interaction.Environ("windir") + "\\NOTEPAD.EXE", ll_lbvarfilename.get_Text());
		}
	}

	private void ll_btneditlcfile_Click(object sender, EventArgs e)
	{
		ll_lblcfilename.get_Items().Clear();
		if (File.Exists(fp + "\\LoadC\\DG.TXT"))
		{
			curvarfname = fp + "\\LoadC\\DG.TXT";
			ll_lblcfilename.get_Items().Add((object)curvarfname);
		}
		else
		{
			ll_lbliucheng.get_Items().Add((object)(Conversions.ToString(DateTime.Now) + " 没有找到工况文本！！"));
			ll_lbliucheng.set_SelectedIndex(checked(ll_lbliucheng.get_Items().get_Count() - 1));
		}
	}

	private void ll_lblcfilename_DoubleClick(object sender, EventArgs e)
	{
		if (File.Exists(ll_lblcfilename.get_Text()))
		{
			Process.Start(Interaction.Environ("windir") + "\\NOTEPAD.EXE", ll_lblcfilename.get_Text());
		}
	}

	private void ll_btnexit_Click(object sender, EventArgs e)
	{
		checked
		{
			if (ll_lbliucheng.get_Items().get_Count() != 0)
			{
				int num = ll_lbliucheng.get_Items().get_Count() - 1;
				for (int i = 0; i <= num; i++)
				{
					MyProject.Forms.clxd.lblog.get_Items().Add(RuntimeHelpers.GetObjectValue(ll_lbliucheng.get_Items().get_Item(i)));
				}
			}
			((Form)this).Close();
			((Component)(object)this).Dispose();
		}
	}

	private void ll_btnout_Click(object sender, EventArgs e)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a6: Invalid comparison between Unknown and I4
		//IL_0105: Unknown result type (might be due to invalid IL or missing references)
		//IL_016a: Unknown result type (might be due to invalid IL or missing references)
		//IL_017f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0185: Invalid comparison between Unknown and I4
		//IL_01de: Unknown result type (might be due to invalid IL or missing references)
		FolderBrowserDialog val = new FolderBrowserDialog();
		val.set_Description("请选择保存路径");
		((CommonDialog)val).ShowDialog();
		p = val.get_SelectedPath();
		int num = Strings.Len(p);
		int num2 = 1;
		while (true)
		{
			if (num2 <= num)
			{
				string text = Conversion.Hex(Strings.Asc(Strings.Mid(p, num2, 1)));
				if (!((Strings.Asc(Strings.Left(text, 1)) >= 66) & (Strings.Asc(Strings.Left(text, 1)) <= 70)))
				{
					num2 = checked(num2 + 1);
					continue;
				}
				if ((int)MessageBox.Show("输出路径当中包含有中文，这可能会造成无法直接计算，是否继续输出？", "重要提示", (MessageBoxButtons)4, (MessageBoxIcon)64) == 6 && Directory.Exists(p))
				{
					((Control)this).set_Cursor(Cursors.get_AppStarting());
					((ServerComputer)MyProject.Computer).get_FileSystem().CopyDirectory(fp, p, true);
					((Control)this).set_Cursor(Cursors.get_Arrow());
					((Control)ll_btnout).set_Enabled(false);
					Interaction.MsgBox((object)"输出完成！", (MsgBoxStyle)64, (object)"提示");
				}
				break;
			}
			if (p.IndexOf(" ") != -1)
			{
				if ((int)MessageBox.Show("输出路径当中有空格，这可能会造成无法直接计算，是否继续输出？", "重要提示", (MessageBoxButtons)4, (MessageBoxIcon)64) == 6 && Directory.Exists(p))
				{
					((Control)this).set_Cursor(Cursors.get_AppStarting());
					((ServerComputer)MyProject.Computer).get_FileSystem().CopyDirectory(fp, p, true);
					((Control)this).set_Cursor(Cursors.get_Arrow());
					((Control)ll_btnout).set_Enabled(false);
					Interaction.MsgBox((object)"输出完成！", (MsgBoxStyle)64, (object)"提示");
				}
			}
			else if (Directory.Exists(p))
			{
				((Control)this).set_Cursor(Cursors.get_AppStarting());
				((ServerComputer)MyProject.Computer).get_FileSystem().CopyDirectory(fp, p, true);
				((Control)this).set_Cursor(Cursors.get_Arrow());
				((Control)ll_btnout).set_Enabled(false);
				Interaction.MsgBox((object)"输出完成！", (MsgBoxStyle)64, (object)"提示");
			}
			break;
		}
	}

	private void ll_btnlookout_Click(object sender, EventArgs e)
	{
		if (Operators.CompareString(p, "", false) != 0)
		{
			Process.Start(p);
		}
	}

	private void fanjs_Load(object sender, EventArgs e)
	{
		string[] array = new string[6]
		{
			Mod1.cshh,
			"\\",
			null,
			null,
			null,
			null
		};
		ListBox lbcl = MyProject.Forms.clxd.lbcl;
		string text = lbcl.get_Text();
		string text2 = Mod1.toen(ref text);
		lbcl.set_Text(text);
		array[2] = text2;
		array[3] = "\\";
		array[4] = MyProject.Forms.clxd.lbsl.get_Text();
		array[5] = "\\source";
		fp = string.Concat(array);
	}

	[MethodImpl(MethodImplOptions.NoOptimization)]
	private void ll_btnxfccheck_Click(object sender, EventArgs e)
	{
		//IL_0122: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			if ((ll_lblcfilename.get_Items().get_Count() != 0) & (ll_lbvarfilename.get_Items().get_Count() != 0))
			{
				string text = Application.get_StartupPath() + "\\config\\xfcjy";
				int num = ll_lbvarfilename.get_Items().get_Count() - 1;
				for (int i = 0; i <= num; i++)
				{
					string text2 = Conversions.ToString(ll_lbvarfilename.get_Items().get_Item(i));
					FileSystem.FileCopy(text2, Strings.Replace(text2, fp, text, 1, -1, (CompareMethod)0));
				}
				int num2 = ll_lblcfilename.get_Items().get_Count() - 1;
				for (int j = 0; j <= num2; j++)
				{
					string text2 = Conversions.ToString(ll_lblcfilename.get_Items().get_Item(j));
					FileSystem.FileCopy(text2, Strings.Replace(text2, fp, text, 1, -1, (CompareMethod)0));
				}
				string text3 = "【预览整机模型】--预览了整机模型: ";
				ll_lbliucheng.get_Items().Add((object)text3);
				ll_lbliucheng.set_SelectedIndex(ll_lbliucheng.get_Items().get_Count() - 1);
				((Form)MyProject.Forms.ll_ufjmcheckxfc).ShowDialog();
				((Component)(object)MyProject.Forms.ll_ufjmcheckxfc).Dispose();
			}
		}
	}
}
