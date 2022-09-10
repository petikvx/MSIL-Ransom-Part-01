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

namespace xxx;

[DesignerGenerated]
public class ll_ufjmcheck : Office2007Form
{
	private IContainer components;

	[AccessedThroughProperty("ll_bmp")]
	private PictureBox _ll_bmp;

	[AccessedThroughProperty("ll_btnsavetemp")]
	private ButtonX _ll_btnsavetemp;

	[AccessedThroughProperty("ll_btnjs")]
	private ButtonX _ll_btnjs;

	[AccessedThroughProperty("ll_btncheck")]
	private ButtonX _ll_btncheck;

	[AccessedThroughProperty("LabelX1")]
	private LabelX _LabelX1;

	[AccessedThroughProperty("btnexit")]
	private ButtonX _btnexit;

	private string sourcefilepath;

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

	public ll_ufjmcheck()
	{
		((Form)this).add_Load((EventHandler)ll_ufjmcheck_Load);
		sourcefilepath = Application.get_StartupPath() + "\\config\\xfcjy";
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
		//IL_0389: Unknown result type (might be due to invalid IL or missing references)
		//IL_0393: Expected O, but got Unknown
		//IL_0423: Unknown result type (might be due to invalid IL or missing references)
		//IL_042d: Expected O, but got Unknown
		ll_bmp = new PictureBox();
		ll_btnsavetemp = new ButtonX();
		ll_btnjs = new ButtonX();
		ll_btncheck = new ButtonX();
		LabelX1 = new LabelX();
		btnexit = new ButtonX();
		((ISupportInitialize)ll_bmp).BeginInit();
		((Control)this).SuspendLayout();
		ll_bmp.set_BorderStyle((BorderStyle)1);
		PictureBox obj = ll_bmp;
		Point location = new Point(12, 12);
		((Control)obj).set_Location(location);
		((Control)ll_bmp).set_Name("ll_bmp");
		PictureBox obj2 = ll_bmp;
		Size size = new Size(543, 410);
		((Control)obj2).set_Size(size);
		ll_bmp.set_TabIndex(0);
		ll_bmp.set_TabStop(false);
		((Control)ll_btnsavetemp).set_AccessibleRole((AccessibleRole)43);
		ll_btnsavetemp.set_ColorTable((eButtonColor)3);
		ButtonX obj3 = ll_btnsavetemp;
		location = new Point(561, 12);
		((Control)obj3).set_Location(location);
		((Control)ll_btnsavetemp).set_Name("ll_btnsavetemp");
		ButtonX obj4 = ll_btnsavetemp;
		size = new Size(123, 30);
		((Control)obj4).set_Size(size);
		((PopupItemControl)ll_btnsavetemp).set_Style((eDotNetBarStyle)7);
		((Control)ll_btnsavetemp).set_TabIndex(1);
		ll_btnsavetemp.set_Text("生成临时参数文件");
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
		((Control)ll_btnjs).set_TabIndex(1);
		ll_btnjs.set_Text("运算");
		((Control)ll_btncheck).set_AccessibleRole((AccessibleRole)43);
		ll_btncheck.set_ColorTable((eButtonColor)3);
		((Control)ll_btncheck).set_Enabled(false);
		ButtonX obj7 = ll_btncheck;
		location = new Point(561, 84);
		((Control)obj7).set_Location(location);
		((Control)ll_btncheck).set_Name("ll_btncheck");
		ButtonX obj8 = ll_btncheck;
		size = new Size(123, 30);
		((Control)obj8).set_Size(size);
		((PopupItemControl)ll_btncheck).set_Style((eDotNetBarStyle)7);
		((Control)ll_btncheck).set_TabIndex(1);
		ll_btncheck.set_Text("查看");
		((BaseItemControl)LabelX1).get_BackgroundStyle().set_Class("");
		((BaseItemControl)LabelX1).get_BackgroundStyle().set_CornerType((eCornerType)1);
		LabelX labelX = LabelX1;
		location = new Point(12, 425);
		((Control)labelX).set_Location(location);
		((Control)LabelX1).set_Name("LabelX1");
		LabelX labelX2 = LabelX1;
		size = new Size(438, 15);
		((Control)labelX2).set_Size(size);
		((Control)LabelX1).set_TabIndex(2);
		((Control)btnexit).set_AccessibleRole((AccessibleRole)43);
		btnexit.set_ColorTable((eButtonColor)3);
		btnexit.set_DialogResult((DialogResult)2);
		ButtonX obj9 = btnexit;
		location = new Point(561, 120);
		((Control)obj9).set_Location(location);
		((Control)btnexit).set_Name("btnexit");
		ButtonX obj10 = btnexit;
		size = new Size(123, 30);
		((Control)obj10).set_Size(size);
		((PopupItemControl)btnexit).set_Style((eDotNetBarStyle)7);
		((Control)btnexit).set_TabIndex(1);
		btnexit.set_Text("关闭");
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)0);
		((Form)this).set_AutoSize(true);
		((Form)this).set_CancelButton((IButtonControl)(object)btnexit);
		((Office2007Form)this).set_CaptionFont(new Font("宋体", 9f, (FontStyle)0, (GraphicsUnit)3, (byte)134));
		size = new Size(691, 442);
		((Form)this).set_ClientSize(size);
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
		((Control)this).set_Name("ll_ufjmcheck");
		((Form)this).set_ShowIcon(false);
		((Form)this).set_ShowInTaskbar(false);
		((Form)this).set_StartPosition((FormStartPosition)1);
		((ISupportInitialize)ll_bmp).EndInit();
		((Control)this).ResumeLayout(false);
	}

	private void ll_btnsavetemp_Click(object sender, EventArgs e)
	{
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		switch (Mod1.curjmID)
		{
		default:
		{
			string text = "当前截面ID不正确!! !" + Mod1.curjmID;
			Interaction.MsgBox((object)text, (MsgBoxStyle)0, (object)"提示");
			break;
		}
		case "截面ID_1":
		case "截面ID_2":
		case "截面ID_3":
			break;
		}
		string path = sourcefilepath + "\\var\\sect\\Z_TEMP.VAR";
		Mod1.wr = new StreamWriter(path, append: false, Encoding.Default);
		int count = Mod1.wb.Worksheets.Count;
		IEnumerator enumerator = default(IEnumerator);
		int column = default(int);
		for (int i = 1; i <= count; i = checked(i + 1))
		{
			Mod1.excelsheet = (Worksheet)Mod1.wb.Sheets.get_Item((object)i);
			if (!((Operators.CompareString(Mod1.excelsheet.Name, "动参数临时", false) != 0) & (Operators.CompareString(Mod1.excelsheet.Name, "参数校验", false) != 0)))
			{
				continue;
			}
			bool flag = true;
			try
			{
				enumerator = ((_Worksheet)Mod1.excelsheet).get_Range((object)"1:1", (object)Missing.Value).GetEnumerator();
				while (enumerator.MoveNext())
				{
					Excel.Range range = (Excel.Range)enumerator.Current;
					string text2 = Conversions.ToString(range.get_Value((object)Missing.Value));
					if (Operators.CompareString(Strings.Trim(text2), "", false) != 0)
					{
						if (Operators.CompareString(Strings.UCase(Strings.Trim(text2)), Strings.UCase(Strings.Trim(Mod1.curjmID)), false) == 0)
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
			if (flag && column > 4 && column < 200)
			{
				Excel.Range range = (Excel.Range)Mod1.excelsheet.Cells[Mod1.excelsheet.Cells.Rows.Count, column];
				int row = range.get_End(XlDirection.xlUp).Row;
				int num = row;
				for (int j = 2; j <= num; j = checked(j + 1))
				{
					if (Operators.CompareString(Strings.Trim(Conversions.ToString(NewLateBinding.LateGet(Mod1.excelsheet.Cells[j, column], (Type)null, "value", new object[0], (string[])null, (Type[])null, (bool[])null))), "1", false) == 0 && ((Operators.CompareString(Strings.Trim(Conversions.ToString(NewLateBinding.LateGet(Mod1.excelsheet.Cells[j, 2], (Type)null, "value", new object[0], (string[])null, (Type[])null, (bool[])null))), "", false) != 0) & (Operators.CompareString(Strings.Trim(Conversions.ToString(NewLateBinding.LateGet(Mod1.excelsheet.Cells[j, 3], (Type)null, "value", new object[0], (string[])null, (Type[])null, (bool[])null))), "", false) != 0)))
					{
						Mod1.wr.WriteLine(Strings.Trim(Conversions.ToString(NewLateBinding.LateGet(Mod1.excelsheet.Cells[j, 2], (Type)null, "value", new object[0], (string[])null, (Type[])null, (bool[])null))) + "=" + Strings.Trim(Conversions.ToString(NewLateBinding.LateGet(Mod1.excelsheet.Cells[j, 3], (Type)null, "value", new object[0], (string[])null, (Type[])null, (bool[])null))));
					}
				}
			}
			Mod1.wr.WriteLine("\r\n");
		}
		Mod1.wr.Close();
		Mod1.wr.Dispose();
		LabelX1.set_Text("当前文件已更新:" + Conversions.ToString(DateTime.Now));
		((Control)ll_btnjs).set_Enabled(true);
	}

	private void ll_btnjs_Click(object sender, EventArgs e)
	{
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		string text = sourcefilepath + "\\截面检验_TEMP.bat ";
		Interaction.Shell(text, (AppWinStyle)2, false, -1);
		((Control)ll_btnjs).set_Enabled(false);
		((Control)ll_btncheck).set_Enabled(true);
		Interaction.MsgBox((object)"正在生成截面,请等待ansys执行完毕再进行查看.. .", (MsgBoxStyle)0, (object)"提示");
	}

	private void ll_btncheck_Click(object sender, EventArgs e)
	{
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		string text = sourcefilepath + "\\work\\SECT_TEMP.jpg";
		if (File.Exists(text))
		{
			ll_bmp.set_ImageLocation(text);
		}
		else
		{
			Interaction.MsgBox((object)(" 没有找到最新的截面图片文件" + text), (MsgBoxStyle)0, (object)"提示");
		}
	}

	private void btnexit_Click(object sender, EventArgs e)
	{
		((Form)this).Close();
	}

	private void ll_ufjmcheck_Load(object sender, EventArgs e)
	{
		((Form)this).set_Text("截面数据信息【" + Mod1.curjmID + "】");
	}
}
