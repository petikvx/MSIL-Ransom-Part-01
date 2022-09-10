using System;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using Excel;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using xxx.My;

namespace xxx;

[DesignerGenerated]
public class Dblcz : Office2007Form
{
	private IContainer components;

	[AccessedThroughProperty("btnok")]
	private ButtonX _btnok;

	[AccessedThroughProperty("lbxnID")]
	private ListBox _lbxnID;

	[AccessedThroughProperty("btntc")]
	private ButtonX _btntc;

	internal virtual ButtonX btnok
	{
		[DebuggerNonUserCode]
		get
		{
			return _btnok;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = btnok_Click;
			if (_btnok != null)
			{
				((Control)_btnok).remove_Click(eventHandler);
			}
			_btnok = value;
			if (_btnok != null)
			{
				((Control)_btnok).add_Click(eventHandler);
			}
		}
	}

	public virtual ListBox lbxnID
	{
		[DebuggerNonUserCode]
		get
		{
			return _lbxnID;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = lbxnID_DoubleClick;
			if (_lbxnID != null)
			{
				((Control)_lbxnID).remove_DoubleClick(eventHandler);
			}
			_lbxnID = value;
			if (_lbxnID != null)
			{
				((Control)_lbxnID).add_DoubleClick(eventHandler);
			}
		}
	}

	internal virtual ButtonX btntc
	{
		[DebuggerNonUserCode]
		get
		{
			return _btntc;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = btntc_Click;
			if (_btntc != null)
			{
				((Control)_btntc).remove_Click(eventHandler);
			}
			_btntc = value;
			if (_btntc != null)
			{
				((Control)_btntc).add_Click(eventHandler);
			}
		}
	}

	[DebuggerNonUserCode]
	public Dblcz()
	{
		((Form)this).add_Load((EventHandler)Dblcz_Load);
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
		//IL_01b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c3: Expected O, but got Unknown
		//IL_0220: Unknown result type (might be due to invalid IL or missing references)
		//IL_022a: Expected O, but got Unknown
		lbxnID = new ListBox();
		btnok = new ButtonX();
		btntc = new ButtonX();
		((Control)this).SuspendLayout();
		((ListControl)lbxnID).set_FormattingEnabled(true);
		lbxnID.set_ItemHeight(12);
		ListBox obj = lbxnID;
		Point location = new Point(12, 12);
		((Control)obj).set_Location(location);
		((Control)lbxnID).set_Name("lbxnID");
		ListBox obj2 = lbxnID;
		Size size = new Size(194, 232);
		((Control)obj2).set_Size(size);
		((Control)lbxnID).set_TabIndex(0);
		((Control)btnok).set_AccessibleRole((AccessibleRole)43);
		btnok.set_ColorTable((eButtonColor)3);
		ButtonX obj3 = btnok;
		location = new Point(62, 250);
		((Control)obj3).set_Location(location);
		((Control)btnok).set_Name("btnok");
		ButtonX obj4 = btnok;
		size = new Size(95, 23);
		((Control)obj4).set_Size(size);
		((PopupItemControl)btnok).set_Style((eDotNetBarStyle)7);
		((Control)btnok).set_TabIndex(1);
		btnok.set_Text("确定");
		((Control)btntc).set_AccessibleRole((AccessibleRole)43);
		btntc.set_ColorTable((eButtonColor)3);
		ButtonX obj5 = btntc;
		location = new Point(62, 147);
		((Control)obj5).set_Location(location);
		((Control)btntc).set_Name("btntc");
		ButtonX obj6 = btntc;
		size = new Size(95, 23);
		((Control)obj6).set_Size(size);
		((PopupItemControl)btntc).set_Style((eDotNetBarStyle)7);
		((Control)btntc).set_TabIndex(1);
		btntc.set_Text("退出");
		((Form)this).set_AcceptButton((IButtonControl)(object)btnok);
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)0);
		((Office2007Form)this).set_CaptionFont(new Font("宋体", 9f, (FontStyle)0, (GraphicsUnit)3, (byte)134));
		size = new Size(217, 281);
		((Form)this).set_ClientSize(size);
		((Control)this).get_Controls().Add((Control)(object)btnok);
		((Control)this).get_Controls().Add((Control)(object)lbxnID);
		((Control)this).get_Controls().Add((Control)(object)btntc);
		((Control)this).set_Font(new Font("宋体", 9f, (FontStyle)0, (GraphicsUnit)3, (byte)134));
		((Form)this).set_FormBorderStyle((FormBorderStyle)1);
		((Form)this).set_MaximizeBox(false);
		((Form)this).set_MinimizeBox(false);
		((Control)this).set_Name("Dblcz");
		((Form)this).set_ShowIcon(false);
		((Form)this).set_ShowInTaskbar(false);
		((Form)this).set_StartPosition((FormStartPosition)1);
		((Form)this).set_Text("对比列参照对话框");
		((Form)this).set_TopMost(true);
		((Control)this).ResumeLayout(false);
	}

	private void Dblcz_Load(object sender, EventArgs e)
	{
		Mod1.excelsheet = (Worksheet)Mod1.wb.Worksheets[MyProject.Forms.cslr2.lbcsx.get_Text()];
		IEnumerator enumerator = default(IEnumerator);
		try
		{
			enumerator = ((_Worksheet)Mod1.excelsheet).get_Range((object)"1:1", (object)Missing.Value).GetEnumerator();
			while (enumerator.MoveNext())
			{
				Excel.Range range = (Excel.Range)enumerator.Current;
				string text = Conversions.ToString(range.get_Value((object)Missing.Value));
				if (Operators.CompareString(text, "性能计算ID_new", false) != 0)
				{
					if (Operators.CompareString(Strings.Trim(text), "", false) == 0)
					{
						break;
					}
					if ((Strings.InStr(1, text, "ID", (CompareMethod)0) > 1) & (Strings.InStr(1, text, "temp", (CompareMethod)0) < 1))
					{
						lbxnID.get_Items().Add((object)text);
					}
				}
			}
		}
		finally
		{
			if (enumerator is IDisposable)
			{
				(enumerator as IDisposable).Dispose();
			}
		}
	}

	private void btnok_Click(object sender, EventArgs e)
	{
		int liehao = MyProject.Forms.canzhaolie.liehao;
		((Control)this).set_Cursor(Cursors.get_AppStarting());
		checked
		{
			if (Operators.CompareString(lbxnID.get_Text(), "", false) != 0)
			{
				string[] array = lbxnID.get_Text().Split(new char[1] { '_' });
				IEnumerator enumerator = default(IEnumerator);
				int num = default(int);
				try
				{
					enumerator = ((_Worksheet)Mod1.excelsheet).get_Range((object)"1:1", (object)Missing.Value).GetEnumerator();
					while (enumerator.MoveNext())
					{
						Excel.Range range = (Excel.Range)enumerator.Current;
						num++;
						if (Operators.CompareString(range.get_Value((object)Missing.Value).ToString(), "", false) != 0 && Operators.ConditionalCompareObjectEqual((object)array[1], range.get_Value((object)Missing.Value), false))
						{
							break;
						}
					}
				}
				finally
				{
					if (enumerator is IDisposable)
					{
						(enumerator as IDisposable).Dispose();
					}
				}
				((DataGridView)MyProject.Forms.canzhaolie.CZDGV).get_Columns().get_Item(MyProject.Forms.canzhaolie.liehao).set_HeaderText(lbxnID.get_Text());
				int num2 = 0;
				int countH = Mod1.countH;
				for (int i = 2; i <= countH; i++)
				{
					if (Operators.CompareString(Strings.Trim(Conversions.ToString(NewLateBinding.LateGet(Mod1.excelsheet.Cells[i, Mod1.ba], (Type)null, "Value", new object[0], (string[])null, (Type[])null, (bool[])null))), "1", false) == 0)
					{
						if (Operators.CompareString(Strings.Trim(Conversions.ToString(NewLateBinding.LateGet(Mod1.excelsheet.Cells[i, num], (Type)null, "Value", new object[0], (string[])null, (Type[])null, (bool[])null))), "", false) != 0)
						{
							((DataGridView)MyProject.Forms.canzhaolie.CZDGV).get_Rows().get_Item(num2).get_Cells()
								.get_Item(liehao)
								.set_Value((object)NewLateBinding.LateGet(Mod1.excelsheet.Cells[i, num], (Type)null, "value", new object[0], (string[])null, (Type[])null, (bool[])null).ToString());
						}
						else if (Strings.Trim(Conversions.ToString(NewLateBinding.LateGet(Mod1.excelsheet.Cells[i, num], (Type)null, "Value", new object[0], (string[])null, (Type[])null, (bool[])null))) == null)
						{
							((DataGridView)MyProject.Forms.canzhaolie.CZDGV).get_Rows().get_Item(num2).get_Cells()
								.get_Item(liehao)
								.set_Value((object)"");
						}
						num2++;
					}
				}
				((Form)this).Close();
			}
			((Control)this).set_Cursor(Cursors.get_Arrow());
		}
	}

	private void btntc_Click(object sender, EventArgs e)
	{
		((Form)this).Close();
	}

	private void lbxnID_DoubleClick(object sender, EventArgs e)
	{
		btnok_Click(RuntimeHelpers.GetObjectValue(sender), e);
	}
}
