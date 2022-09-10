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
public class ll_ufloadcaserow : Office2007Form
{
	private IContainer components;

	[AccessedThroughProperty("LabelX1")]
	private LabelX _LabelX1;

	[AccessedThroughProperty("ll_txtloadcaserow")]
	private TextBoxX _ll_txtloadcaserow;

	[AccessedThroughProperty("ll_btnadd2cur")]
	private ButtonX _ll_btnadd2cur;

	[AccessedThroughProperty("ll_btnexit")]
	private ButtonX _ll_btnexit;

	[AccessedThroughProperty("ll_lbleformat")]
	private LabelX _ll_lbleformat;

	private string[] temps1;

	private string[] temps2;

	public int nn;

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

	internal virtual TextBoxX ll_txtloadcaserow
	{
		[DebuggerNonUserCode]
		get
		{
			return _ll_txtloadcaserow;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_ll_txtloadcaserow = value;
		}
	}

	internal virtual ButtonX ll_btnadd2cur
	{
		[DebuggerNonUserCode]
		get
		{
			return _ll_btnadd2cur;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = ll_btnadd2cur_Click;
			if (_ll_btnadd2cur != null)
			{
				((Control)_ll_btnadd2cur).remove_Click(eventHandler);
			}
			_ll_btnadd2cur = value;
			if (_ll_btnadd2cur != null)
			{
				((Control)_ll_btnadd2cur).add_Click(eventHandler);
			}
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

	public virtual LabelX ll_lbleformat
	{
		[DebuggerNonUserCode]
		get
		{
			return _ll_lbleformat;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_ll_lbleformat = value;
		}
	}

	[DebuggerNonUserCode]
	public ll_ufloadcaserow()
	{
		((Form)this).add_Load((EventHandler)ll_ufloadcaserow_Load);
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
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0084: Expected O, but got Unknown
		//IL_011a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0124: Expected O, but got Unknown
		//IL_01ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b8: Expected O, but got Unknown
		//IL_0235: Unknown result type (might be due to invalid IL or missing references)
		//IL_023f: Expected O, but got Unknown
		//IL_02e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_02eb: Expected O, but got Unknown
		//IL_038c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0396: Expected O, but got Unknown
		//IL_041c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0426: Expected O, but got Unknown
		LabelX1 = new LabelX();
		ll_lbleformat = new LabelX();
		ll_txtloadcaserow = new TextBoxX();
		ll_btnadd2cur = new ButtonX();
		ll_btnexit = new ButtonX();
		((Control)this).SuspendLayout();
		((BaseItemControl)LabelX1).get_BackgroundStyle().set_Class("");
		((BaseItemControl)LabelX1).get_BackgroundStyle().set_CornerType((eCornerType)1);
		((Control)LabelX1).set_Font(new Font("宋体", 9f, (FontStyle)0, (GraphicsUnit)3, (byte)134));
		LabelX labelX = LabelX1;
		Point location = new Point(12, 6);
		((Control)labelX).set_Location(location);
		((Control)LabelX1).set_Name("LabelX1");
		LabelX labelX2 = LabelX1;
		Size size = new Size(92, 18);
		((Control)labelX2).set_Size(size);
		((Control)LabelX1).set_TabIndex(0);
		LabelX1.set_Text("输入格式说明:");
		((BaseItemControl)ll_lbleformat).get_BackgroundStyle().set_Class("");
		((BaseItemControl)ll_lbleformat).get_BackgroundStyle().set_CornerType((eCornerType)1);
		((Control)ll_lbleformat).set_Font(new Font("宋体", 9f, (FontStyle)0, (GraphicsUnit)3, (byte)134));
		LabelX obj = ll_lbleformat;
		location = new Point(11, 30);
		((Control)obj).set_Location(location);
		((Control)ll_lbleformat).set_Name("ll_lbleformat");
		LabelX obj2 = ll_lbleformat;
		size = new Size(336, 20);
		((Control)obj2).set_Size(size);
		((Control)ll_lbleformat).set_TabIndex(0);
		ll_txtloadcaserow.get_Border().set_Class("TextBoxBorder");
		ll_txtloadcaserow.get_Border().set_CornerType((eCornerType)1);
		((Control)ll_txtloadcaserow).set_Font(new Font("宋体", 9f, (FontStyle)0, (GraphicsUnit)3, (byte)134));
		TextBoxX obj3 = ll_txtloadcaserow;
		location = new Point(11, 56);
		((Control)obj3).set_Location(location);
		((Control)ll_txtloadcaserow).set_Name("ll_txtloadcaserow");
		TextBoxX obj4 = ll_txtloadcaserow;
		size = new Size(336, 21);
		((Control)obj4).set_Size(size);
		((Control)ll_txtloadcaserow).set_TabIndex(1);
		((Control)ll_btnadd2cur).set_AccessibleRole((AccessibleRole)43);
		ll_btnadd2cur.set_ColorTable((eButtonColor)3);
		((Control)ll_btnadd2cur).set_Font(new Font("宋体", 9f, (FontStyle)0, (GraphicsUnit)3, (byte)134));
		ButtonX obj5 = ll_btnadd2cur;
		location = new Point(55, 98);
		((Control)obj5).set_Location(location);
		((Control)ll_btnadd2cur).set_Name("ll_btnadd2cur");
		ButtonX obj6 = ll_btnadd2cur;
		size = new Size(75, 23);
		((Control)obj6).set_Size(size);
		((PopupItemControl)ll_btnadd2cur).set_Style((eDotNetBarStyle)7);
		((Control)ll_btnadd2cur).set_TabIndex(2);
		ll_btnadd2cur.set_Text("追加");
		((Control)ll_btnexit).set_AccessibleRole((AccessibleRole)43);
		ll_btnexit.set_ColorTable((eButtonColor)3);
		ll_btnexit.set_DialogResult((DialogResult)2);
		((Control)ll_btnexit).set_Font(new Font("宋体", 9f, (FontStyle)0, (GraphicsUnit)3, (byte)134));
		ButtonX obj7 = ll_btnexit;
		location = new Point(241, 98);
		((Control)obj7).set_Location(location);
		((Control)ll_btnexit).set_Name("ll_btnexit");
		ButtonX obj8 = ll_btnexit;
		size = new Size(75, 23);
		((Control)obj8).set_Size(size);
		((PopupItemControl)ll_btnexit).set_Style((eDotNetBarStyle)7);
		((Control)ll_btnexit).set_TabIndex(2);
		ll_btnexit.set_Text("取消");
		((Form)this).set_AcceptButton((IButtonControl)(object)ll_btnadd2cur);
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)0);
		((Form)this).set_AutoSizeMode((AutoSizeMode)0);
		((Form)this).set_CancelButton((IButtonControl)(object)ll_btnexit);
		((Office2007Form)this).set_CaptionFont(new Font("宋体", 9f, (FontStyle)0, (GraphicsUnit)3, (byte)134));
		size = new Size(358, 143);
		((Form)this).set_ClientSize(size);
		((Form)this).set_ControlBox(false);
		((Control)this).get_Controls().Add((Control)(object)ll_btnexit);
		((Control)this).get_Controls().Add((Control)(object)ll_btnadd2cur);
		((Control)this).get_Controls().Add((Control)(object)ll_txtloadcaserow);
		((Control)this).get_Controls().Add((Control)(object)ll_lbleformat);
		((Control)this).get_Controls().Add((Control)(object)LabelX1);
		((Control)this).set_Font(new Font("宋体", 9f, (FontStyle)0, (GraphicsUnit)3, (byte)134));
		((Form)this).set_FormBorderStyle((FormBorderStyle)3);
		((Form)this).set_MaximizeBox(false);
		((Form)this).set_MinimizeBox(false);
		((Control)this).set_Name("ll_ufloadcaserow");
		((Form)this).set_ShowIcon(false);
		((Form)this).set_ShowInTaskbar(false);
		((Form)this).set_StartPosition((FormStartPosition)1);
		((Form)this).set_Text("自定义当前行工况信息.");
		((Control)this).ResumeLayout(false);
	}

	private void ll_btnexit_Click(object sender, EventArgs e)
	{
		((Form)this).Close();
	}

	private void ll_ufloadcaserow_Load(object sender, EventArgs e)
	{
		//IL_00a2: Unknown result type (might be due to invalid IL or missing references)
		ll_lbleformat.set_Text(Mod1.curloadcaseformat);
		((TextBox)ll_txtloadcaserow).set_Text(Mod1.curloadcaserow);
		Mod1.cureditflag = false;
		temps1 = Strings.Split(((TextBox)ll_txtloadcaserow).get_Text(), ",", -1, (CompareMethod)0);
		temps2 = Strings.Split(ll_lbleformat.get_Text(), ",", -1, (CompareMethod)0);
		if ((Information.UBound((Array)temps1, 1) != Information.UBound((Array)temps2, 1)) & (Operators.CompareString(Mod1.curloadcaserow, "", false) != 0))
		{
			Interaction.MsgBox((object)"当前列表中的数据与格式要求不一致,请仔细核对!", (MsgBoxStyle)64, (object)"提示");
			((Component)(object)this).Dispose();
		}
	}

	private void ll_btnadd2cur_Click(object sender, EventArgs e)
	{
		//IL_0202: Unknown result type (might be due to invalid IL or missing references)
		//IL_0221: Unknown result type (might be due to invalid IL or missing references)
		temps1 = Strings.Split(Strings.Trim(((TextBox)ll_txtloadcaserow).get_Text()), ",", -1, (CompareMethod)0);
		temps2 = Strings.Split(ll_lbleformat.get_Text(), ",", -1, (CompareMethod)0);
		checked
		{
			int num = temps1.Length - 1;
			int num2 = 0;
			while (true)
			{
				if (num2 <= num)
				{
					if (Operators.CompareString(temps1[num2], string.Empty, false) == 0)
					{
						break;
					}
					num2++;
					continue;
				}
				if (temps1.Length == temps2.Length)
				{
					Mod1.cureditflag = true;
					Mod1.curloadcaserow = ((TextBox)ll_txtloadcaserow).get_Text();
					if (Mod1.cureditflag)
					{
						nn++;
						MyProject.Forms.fxdd.ll_lbloadcase.get_Items().Add((object)(Conversions.ToString(nn) + "," + Mod1.curloadcaserow));
						string text = "【自定义添加当前行】--对当前工况列表进行了自定义添加.序号为: " + Conversions.ToString(nn);
						MyProject.Forms.fxdd.lslog.get_Items().Add((object)text);
						text = "【新序号从1开始】选项为: " + MyProject.Forms.fxdd.ll_checkxh1.get_Text();
						MyProject.Forms.fxdd.lslog.get_Items().Add((object)text);
						MyProject.Forms.fxdd.lslog.get_Items().Add((object)("添加的内容为：" + ((TextBox)ll_txtloadcaserow).get_Text()));
						MyProject.Forms.fxdd.lslog.set_SelectedIndex(MyProject.Forms.fxdd.lslog.get_Items().get_Count() - 1);
						MyProject.Forms.fxdd.ll_lbloadcase.Refresh();
						MyProject.Forms.fxdd.ll_lbloadcase.set_SelectedIndex(MyProject.Forms.fxdd.ll_lbloadcase.get_Items().get_Count() - 1);
					}
				}
				else
				{
					Interaction.MsgBox((object)"当前输入的格式与要求的不一致,输入无效!", (MsgBoxStyle)64, (object)"提示");
					((Control)ll_txtloadcaserow).Focus();
				}
				return;
			}
			Interaction.MsgBox((object)"当前输入的格式与要求的不一致,输入无效!", (MsgBoxStyle)64, (object)"提示");
		}
	}
}
