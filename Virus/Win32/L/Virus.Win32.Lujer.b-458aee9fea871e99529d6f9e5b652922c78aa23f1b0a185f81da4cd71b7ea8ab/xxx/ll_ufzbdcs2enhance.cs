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
using DevComponents.DotNetBar.Controls;
using Excel;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using xxx.My;

namespace xxx;

[DesignerGenerated]
public class ll_ufzbdcs2enhance : Office2007Form
{
	private IContainer components;

	[AccessedThroughProperty("LabelX1")]
	private LabelX _LabelX1;

	[AccessedThroughProperty("LabelX2")]
	private LabelX _LabelX2;

	[AccessedThroughProperty("LabelX3")]
	private LabelX _LabelX3;

	[AccessedThroughProperty("ll_lbxy")]
	private ListBox _ll_lbxy;

	[AccessedThroughProperty("ll_lb12")]
	private ListBox _ll_lb12;

	[AccessedThroughProperty("ll_lbreadme")]
	private ListBox _ll_lbreadme;

	[AccessedThroughProperty("ll_lbexy")]
	private LabelX _ll_lbexy;

	[AccessedThroughProperty("ll_txtvalue")]
	private TextBoxX _ll_txtvalue;

	[AccessedThroughProperty("ll_btnmodify")]
	private ButtonX _ll_btnmodify;

	[AccessedThroughProperty("ll_btnupdate")]
	private ButtonX _ll_btnupdate;

	[AccessedThroughProperty("ll_btnexit")]
	private ButtonX _ll_btnexit;

	[AccessedThroughProperty("LabelX5")]
	private LabelX _LabelX5;

	[AccessedThroughProperty("ll_lbupdateresult")]
	private ListBox _ll_lbupdateresult;

	private Worksheet sh;

	private Worksheet sh2;

	private int iitotal;

	private int iitotal2;

	private int curindexone;

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

	internal virtual ListBox ll_lbxy
	{
		[DebuggerNonUserCode]
		get
		{
			return _ll_lbxy;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = ll_lbxy_SelectedIndexChanged;
			if (_ll_lbxy != null)
			{
				_ll_lbxy.remove_SelectedIndexChanged(eventHandler);
			}
			_ll_lbxy = value;
			if (_ll_lbxy != null)
			{
				_ll_lbxy.add_SelectedIndexChanged(eventHandler);
			}
		}
	}

	internal virtual ListBox ll_lb12
	{
		[DebuggerNonUserCode]
		get
		{
			return _ll_lb12;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = ll_lb12_SelectedIndexChanged;
			if (_ll_lb12 != null)
			{
				_ll_lb12.remove_SelectedIndexChanged(eventHandler);
			}
			_ll_lb12 = value;
			if (_ll_lb12 != null)
			{
				_ll_lb12.add_SelectedIndexChanged(eventHandler);
			}
		}
	}

	internal virtual ListBox ll_lbreadme
	{
		[DebuggerNonUserCode]
		get
		{
			return _ll_lbreadme;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = ll_lbreadme_SelectedIndexChanged;
			if (_ll_lbreadme != null)
			{
				_ll_lbreadme.remove_SelectedIndexChanged(eventHandler);
			}
			_ll_lbreadme = value;
			if (_ll_lbreadme != null)
			{
				_ll_lbreadme.add_SelectedIndexChanged(eventHandler);
			}
		}
	}

	internal virtual LabelX ll_lbexy
	{
		[DebuggerNonUserCode]
		get
		{
			return _ll_lbexy;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_ll_lbexy = value;
		}
	}

	internal virtual TextBoxX ll_txtvalue
	{
		[DebuggerNonUserCode]
		get
		{
			return _ll_txtvalue;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_ll_txtvalue = value;
		}
	}

	internal virtual ButtonX ll_btnmodify
	{
		[DebuggerNonUserCode]
		get
		{
			return _ll_btnmodify;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = ll_btnmodify_Click;
			if (_ll_btnmodify != null)
			{
				((Control)_ll_btnmodify).remove_Click(eventHandler);
			}
			_ll_btnmodify = value;
			if (_ll_btnmodify != null)
			{
				((Control)_ll_btnmodify).add_Click(eventHandler);
			}
		}
	}

	internal virtual ButtonX ll_btnupdate
	{
		[DebuggerNonUserCode]
		get
		{
			return _ll_btnupdate;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = ll_btnupdate_Click;
			if (_ll_btnupdate != null)
			{
				((Control)_ll_btnupdate).remove_Click(eventHandler);
			}
			_ll_btnupdate = value;
			if (_ll_btnupdate != null)
			{
				((Control)_ll_btnupdate).add_Click(eventHandler);
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

	internal virtual LabelX LabelX5
	{
		[DebuggerNonUserCode]
		get
		{
			return _LabelX5;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_LabelX5 = value;
		}
	}

	internal virtual ListBox ll_lbupdateresult
	{
		[DebuggerNonUserCode]
		get
		{
			return _ll_lbupdateresult;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_ll_lbupdateresult = value;
		}
	}

	[DebuggerNonUserCode]
	public ll_ufzbdcs2enhance()
	{
		((Form)this).add_Load((EventHandler)ll_ufzbdcs2enhance_Load);
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
		//IL_0085: Unknown result type (might be due to invalid IL or missing references)
		//IL_008f: Expected O, but got Unknown
		//IL_071f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0729: Expected O, but got Unknown
		//IL_0830: Unknown result type (might be due to invalid IL or missing references)
		//IL_083a: Expected O, but got Unknown
		LabelX1 = new LabelX();
		LabelX2 = new LabelX();
		LabelX3 = new LabelX();
		ll_lbxy = new ListBox();
		ll_lb12 = new ListBox();
		ll_lbreadme = new ListBox();
		ll_lbexy = new LabelX();
		ll_txtvalue = new TextBoxX();
		ll_btnmodify = new ButtonX();
		ll_btnupdate = new ButtonX();
		ll_btnexit = new ButtonX();
		LabelX5 = new LabelX();
		ll_lbupdateresult = new ListBox();
		((Control)this).SuspendLayout();
		((BaseItemControl)LabelX1).get_BackgroundStyle().set_Class("");
		((BaseItemControl)LabelX1).get_BackgroundStyle().set_CornerType((eCornerType)1);
		LabelX labelX = LabelX1;
		Point location = new Point(8, 12);
		((Control)labelX).set_Location(location);
		((Control)LabelX1).set_Name("LabelX1");
		LabelX labelX2 = LabelX1;
		Size size = new Size(75, 23);
		((Control)labelX2).set_Size(size);
		((Control)LabelX1).set_TabIndex(0);
		LabelX1.set_Text("待替换字符");
		((BaseItemControl)LabelX2).get_BackgroundStyle().set_Class("");
		((BaseItemControl)LabelX2).get_BackgroundStyle().set_CornerType((eCornerType)1);
		LabelX labelX3 = LabelX2;
		location = new Point(134, 12);
		((Control)labelX3).set_Location(location);
		((Control)LabelX2).set_Name("LabelX2");
		LabelX labelX4 = LabelX2;
		size = new Size(75, 23);
		((Control)labelX4).set_Size(size);
		((Control)LabelX2).set_TabIndex(0);
		LabelX2.set_Text("替换为");
		((BaseItemControl)LabelX3).get_BackgroundStyle().set_Class("");
		((BaseItemControl)LabelX3).get_BackgroundStyle().set_CornerType((eCornerType)1);
		LabelX labelX5 = LabelX3;
		location = new Point(260, 12);
		((Control)labelX5).set_Location(location);
		((Control)LabelX3).set_Name("LabelX3");
		LabelX labelX6 = LabelX3;
		size = new Size(75, 23);
		((Control)labelX6).set_Size(size);
		((Control)LabelX3).set_TabIndex(0);
		LabelX3.set_Text("备注");
		((ListControl)ll_lbxy).set_FormattingEnabled(true);
		ll_lbxy.set_ItemHeight(12);
		ListBox obj = ll_lbxy;
		location = new Point(8, 41);
		((Control)obj).set_Location(location);
		((Control)ll_lbxy).set_Name("ll_lbxy");
		ListBox obj2 = ll_lbxy;
		size = new Size(120, 208);
		((Control)obj2).set_Size(size);
		((Control)ll_lbxy).set_TabIndex(1);
		((ListControl)ll_lb12).set_FormattingEnabled(true);
		ll_lb12.set_ItemHeight(12);
		ListBox obj3 = ll_lb12;
		location = new Point(134, 41);
		((Control)obj3).set_Location(location);
		((Control)ll_lb12).set_Name("ll_lb12");
		ListBox obj4 = ll_lb12;
		size = new Size(120, 208);
		((Control)obj4).set_Size(size);
		((Control)ll_lb12).set_TabIndex(1);
		((ListControl)ll_lbreadme).set_FormattingEnabled(true);
		ll_lbreadme.set_ItemHeight(12);
		ListBox obj5 = ll_lbreadme;
		location = new Point(260, 41);
		((Control)obj5).set_Location(location);
		((Control)ll_lbreadme).set_Name("ll_lbreadme");
		ListBox obj6 = ll_lbreadme;
		size = new Size(352, 208);
		((Control)obj6).set_Size(size);
		((Control)ll_lbreadme).set_TabIndex(1);
		((BaseItemControl)ll_lbexy).get_BackgroundStyle().set_Class("");
		((BaseItemControl)ll_lbexy).get_BackgroundStyle().set_CornerType((eCornerType)1);
		LabelX obj7 = ll_lbexy;
		location = new Point(73, 255);
		((Control)obj7).set_Location(location);
		((Control)ll_lbexy).set_Name("ll_lbexy");
		((Control)ll_lbexy).set_RightToLeft((RightToLeft)1);
		LabelX obj8 = ll_lbexy;
		size = new Size(55, 23);
		((Control)obj8).set_Size(size);
		((Control)ll_lbexy).set_TabIndex(0);
		ll_txtvalue.get_Border().set_Class("TextBoxBorder");
		ll_txtvalue.get_Border().set_CornerType((eCornerType)1);
		TextBoxX obj9 = ll_txtvalue;
		location = new Point(134, 255);
		((Control)obj9).set_Location(location);
		((Control)ll_txtvalue).set_Name("ll_txtvalue");
		TextBoxX obj10 = ll_txtvalue;
		size = new Size(120, 21);
		((Control)obj10).set_Size(size);
		((Control)ll_txtvalue).set_TabIndex(2);
		((Control)ll_btnmodify).set_AccessibleRole((AccessibleRole)43);
		ll_btnmodify.set_ColorTable((eButtonColor)3);
		ButtonX obj11 = ll_btnmodify;
		location = new Point(260, 254);
		((Control)obj11).set_Location(location);
		((Control)ll_btnmodify).set_Name("ll_btnmodify");
		ButtonX obj12 = ll_btnmodify;
		size = new Size(75, 23);
		((Control)obj12).set_Size(size);
		((PopupItemControl)ll_btnmodify).set_Style((eDotNetBarStyle)7);
		((Control)ll_btnmodify).set_TabIndex(3);
		ll_btnmodify.set_Text("修改当前值");
		ll_btnmodify.set_Tooltip("待替换字符区分大小写");
		((Control)ll_btnupdate).set_AccessibleRole((AccessibleRole)43);
		ll_btnupdate.set_ColorTable((eButtonColor)3);
		ButtonX obj13 = ll_btnupdate;
		location = new Point(464, 255);
		((Control)obj13).set_Location(location);
		((Control)ll_btnupdate).set_Name("ll_btnupdate");
		ButtonX obj14 = ll_btnupdate;
		size = new Size(148, 23);
		((Control)obj14).set_Size(size);
		((PopupItemControl)ll_btnupdate).set_Style((eDotNetBarStyle)7);
		((Control)ll_btnupdate).set_TabIndex(3);
		ll_btnupdate.set_Text("来自[动参数]的继承");
		((Control)ll_btnexit).set_AccessibleRole((AccessibleRole)43);
		ll_btnexit.set_ColorTable((eButtonColor)3);
		ll_btnexit.set_DialogResult((DialogResult)2);
		ButtonX obj15 = ll_btnexit;
		location = new Point(464, 284);
		((Control)obj15).set_Location(location);
		((Control)ll_btnexit).set_Name("ll_btnexit");
		ButtonX obj16 = ll_btnexit;
		size = new Size(148, 23);
		((Control)obj16).set_Size(size);
		((PopupItemControl)ll_btnexit).set_Style((eDotNetBarStyle)7);
		((Control)ll_btnexit).set_TabIndex(3);
		ll_btnexit.set_Text("关闭");
		((BaseItemControl)LabelX5).get_BackgroundStyle().set_Class("");
		((BaseItemControl)LabelX5).get_BackgroundStyle().set_CornerType((eCornerType)1);
		LabelX labelX7 = LabelX5;
		location = new Point(8, 288);
		((Control)labelX7).set_Location(location);
		((Control)LabelX5).set_Name("LabelX5");
		LabelX labelX8 = LabelX5;
		size = new Size(120, 23);
		((Control)labelX8).set_Size(size);
		((Control)LabelX5).set_TabIndex(0);
		LabelX5.set_Text("继承的结果");
		((ListControl)ll_lbupdateresult).set_FormattingEnabled(true);
		ll_lbupdateresult.set_ItemHeight(12);
		ListBox obj17 = ll_lbupdateresult;
		location = new Point(8, 313);
		((Control)obj17).set_Location(location);
		((Control)ll_lbupdateresult).set_Name("ll_lbupdateresult");
		ListBox obj18 = ll_lbupdateresult;
		size = new Size(604, 136);
		((Control)obj18).set_Size(size);
		((Control)ll_lbupdateresult).set_TabIndex(1);
		((Form)this).set_AcceptButton((IButtonControl)(object)ll_btnmodify);
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)0);
		((Form)this).set_AutoSizeMode((AutoSizeMode)0);
		((Form)this).set_CancelButton((IButtonControl)(object)ll_btnexit);
		((Office2007Form)this).set_CaptionFont(new Font("宋体", 9f, (FontStyle)0, (GraphicsUnit)3, (byte)134));
		size = new Size(617, 458);
		((Form)this).set_ClientSize(size);
		((Control)this).get_Controls().Add((Control)(object)ll_btnexit);
		((Control)this).get_Controls().Add((Control)(object)ll_btnupdate);
		((Control)this).get_Controls().Add((Control)(object)ll_btnmodify);
		((Control)this).get_Controls().Add((Control)(object)ll_txtvalue);
		((Control)this).get_Controls().Add((Control)(object)ll_lbupdateresult);
		((Control)this).get_Controls().Add((Control)(object)ll_lbreadme);
		((Control)this).get_Controls().Add((Control)(object)ll_lb12);
		((Control)this).get_Controls().Add((Control)(object)ll_lbxy);
		((Control)this).get_Controls().Add((Control)(object)LabelX3);
		((Control)this).get_Controls().Add((Control)(object)LabelX2);
		((Control)this).get_Controls().Add((Control)(object)LabelX5);
		((Control)this).get_Controls().Add((Control)(object)ll_lbexy);
		((Control)this).get_Controls().Add((Control)(object)LabelX1);
		((Control)this).set_Font(new Font("宋体", 9f, (FontStyle)0, (GraphicsUnit)3, (byte)134));
		((Form)this).set_FormBorderStyle((FormBorderStyle)3);
		((Form)this).set_MaximizeBox(false);
		((Form)this).set_MinimizeBox(false);
		((Control)this).set_Name("ll_ufzbdcs2enhance");
		((Form)this).set_ShowIcon(false);
		((Form)this).set_ShowInTaskbar(false);
		((Form)this).set_StartPosition((FormStartPosition)1);
		((Form)this).set_Text("继承配置.. .");
		((Control)this).ResumeLayout(false);
	}

	private void ll_ufzbdcs2enhance_Load(object sender, EventArgs e)
	{
		string path = Application.get_StartupPath() + "\\config\\主臂动参数列表2.ini";
		if (File.Exists(path))
		{
			Mod1.lr = new StreamReader(path, Encoding.Default);
			string text = "";
			while (!Information.IsNothing((object)text))
			{
				text = Mod1.lr.ReadLine();
				if (Information.IsNothing((object)text))
				{
					break;
				}
				string[] array = Strings.Split(text, ",", -1, (CompareMethod)0);
				ll_lbxy.get_Items().Add((object)array[0]);
				ll_lbreadme.get_Items().Add((object)array[1]);
				ll_lb12.get_Items().Add((object)"");
			}
			Mod1.lr.Close();
			Mod1.lr.Dispose();
		}
		((Control)ll_btnupdate).set_ForeColor(Color.Red);
	}

	private void IndexOne()
	{
		ll_lbxy.set_SelectedIndex(curindexone);
		ll_lb12.set_SelectedIndex(curindexone);
		ll_lbreadme.set_SelectedIndex(curindexone);
	}

	private void ll_lbxy_SelectedIndexChanged(object sender, EventArgs e)
	{
		curindexone = ll_lbxy.get_SelectedIndex();
		IndexOne();
	}

	private void ll_lb12_SelectedIndexChanged(object sender, EventArgs e)
	{
		curindexone = ll_lb12.get_SelectedIndex();
		IndexOne();
		((TextBox)ll_txtvalue).set_Text(ll_lb12.get_Text());
		ll_lbexy.set_Text(ll_lbxy.get_Text());
		((Control)ll_txtvalue).Focus();
		((TextBoxBase)ll_txtvalue).set_SelectionStart(0);
		((TextBoxBase)ll_txtvalue).set_SelectionLength(100);
	}

	private void ll_lbreadme_SelectedIndexChanged(object sender, EventArgs e)
	{
		curindexone = ll_lbreadme.get_SelectedIndex();
		IndexOne();
	}

	private void ll_btnmodify_Click(object sender, EventArgs e)
	{
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0079: Unknown result type (might be due to invalid IL or missing references)
		if (ll_lb12.get_SelectedIndex() == -1)
		{
			return;
		}
		if (Operators.CompareString(Strings.Trim(((TextBox)ll_txtvalue).get_Text()), "", false) == 0)
		{
			Interaction.MsgBox((object)"输入的值不能为空！", (MsgBoxStyle)64, (object)"提示");
			((Control)ll_txtvalue).Focus();
			return;
		}
		TextBoxX val = ll_txtvalue;
		string txt = ((TextBox)val).get_Text();
		bool num = Checktxt(ref txt);
		((TextBox)val).set_Text(txt);
		if (!num)
		{
			Interaction.MsgBox((object)"输入的值只能为英文或数字，不能有汉字！", (MsgBoxStyle)64, (object)"提示");
			((TextBox)ll_txtvalue).set_Text("");
			((Control)ll_txtvalue).Focus();
			return;
		}
		ll_lb12.get_Items().set_Item(ll_lb12.get_SelectedIndex(), (object)((TextBox)ll_txtvalue).get_Text());
		ll_lbupdateresult.get_Items().Add(Operators.ConcatenateObject(Operators.ConcatenateObject(ll_lbxy.get_Items().get_Item(ll_lb12.get_SelectedIndex()), (object)" = "), (object)((TextBox)ll_txtvalue).get_Text()));
		checked
		{
			if (ll_lb12.get_SelectedIndex() < ll_lb12.get_Items().get_Count() - 1)
			{
				ll_lb12.set_SelectedIndex(ll_lb12.get_SelectedIndex() + 1);
			}
			else
			{
				ll_lb12.set_SelectedIndex(0);
			}
		}
	}

	private void ll_btnupdate_Click(object sender, EventArgs e)
	{
		Hashtable hashtable = new Hashtable();
		if (Mod1.excelapp.Workbooks.Count != 1)
		{
			return;
		}
		ll_lbupdateresult.get_Items().Clear();
		((Control)MyProject.Forms.jinduclxd).Show();
		sh = (Worksheet)Mod1.excelapp.Worksheets["动参数"];
		sh2 = (Worksheet)Mod1.excelapp.Worksheets["动参数2"];
		iitotal = Conversions.ToInteger(NewLateBinding.LateGet(NewLateBinding.LateGet(sh.Cells[sh.Cells.Rows.Count, 2], (Type)null, "End", new object[1] { XlDirection.xlUp }, (string[])null, (Type[])null, (bool[])null), (Type)null, "Row", new object[0], (string[])null, (Type[])null, (bool[])null));
		iitotal2 = Conversions.ToInteger(NewLateBinding.LateGet(NewLateBinding.LateGet(sh2.Cells[sh.Cells.Rows.Count, 2], (Type)null, "End", new object[1] { XlDirection.xlUp }, (string[])null, (Type[])null, (bool[])null), (Type)null, "Row", new object[0], (string[])null, (Type[])null, (bool[])null));
		MyProject.Forms.jinduclxd.PBZ.set_Maximum(1);
		MyProject.Forms.jinduclxd.PBZ.set_Value(1);
		MyProject.Forms.jinduclxd.PBD.set_Maximum(iitotal2);
		int num = iitotal;
		checked
		{
			for (int i = 2; i <= num; i++)
			{
				if (Operators.CompareString(Strings.Trim(Conversions.ToString(NewLateBinding.LateGet(sh.Cells[i, 3], (Type)null, "Value", new object[0], (string[])null, (Type[])null, (bool[])null))), "", false) == 0)
				{
					hashtable.Add(RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(sh.Cells[i, 2], (Type)null, "Value", new object[0], (string[])null, (Type[])null, (bool[])null)), "");
				}
				else
				{
					hashtable.Add(RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(sh.Cells[i, 2], (Type)null, "Value", new object[0], (string[])null, (Type[])null, (bool[])null)), RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(sh.Cells[i, 3], (Type)null, "Value", new object[0], (string[])null, (Type[])null, (bool[])null)));
				}
			}
			int num2 = iitotal2;
			for (int j = 2; j <= num2; j++)
			{
				MyProject.Forms.jinduclxd.PBD.set_Value(j);
				string text = Conversions.ToString(NewLateBinding.LateGet(sh2.Cells[j, 2], (Type)null, "Value", new object[0], (string[])null, (Type[])null, (bool[])null));
				int num3 = ll_lb12.get_Items().get_Count() - 1;
				for (int k = 0; k <= num3; k++)
				{
					string text2 = Strings.Replace(text, Conversions.ToString(ll_lbxy.get_Items().get_Item(k)), Conversions.ToString(ll_lb12.get_Items().get_Item(k)), 1, -1, (CompareMethod)0);
					if (Operators.CompareString(text2, text, false) != 0)
					{
						string text3 = Conversions.ToString(hashtable[text2]);
						NewLateBinding.LateSetComplex(sh2.Cells[j, 3], (Type)null, "Value", new object[1] { text3 }, (string[])null, (Type[])null, false, true);
						MyProject.Forms.jinduclxd.xx.set_Text(Conversions.ToString(Operators.ConcatenateObject((object)string.Concat(string.Concat(text + ", ", text2), " = "), hashtable[text2])));
						((Control)MyProject.Forms.jinduclxd).Refresh();
						ll_lbupdateresult.get_Items().Add(Operators.ConcatenateObject((object)string.Concat(string.Concat(text + ", ", text2), " = "), hashtable[text2]));
					}
				}
			}
			((Component)(object)MyProject.Forms.jinduclxd).Dispose();
			((Control)ll_btnupdate).set_ForeColor(Color.Green);
			ll_lbupdateresult.get_Items().Add((object)"更新了当前 [动参数2] 中的相应参数.");
			ll_lbupdateresult.set_SelectedIndex(ll_lbupdateresult.get_Items().get_Count() - 1);
		}
	}

	private void ll_btnexit_Click(object sender, EventArgs e)
	{
		checked
		{
			if (ll_lbupdateresult.get_Items().get_Count() != 0)
			{
				int num = ll_lbupdateresult.get_Items().get_Count() - 1;
				for (int i = 0; i <= num; i++)
				{
					MyProject.Forms.clxd.lblog.get_Items().Add(RuntimeHelpers.GetObjectValue(ll_lbupdateresult.get_Items().get_Item(i)));
				}
			}
			((Form)this).Close();
		}
	}

	public bool Checktxt(ref string txt)
	{
		bool result = true;
		int num = Strings.Len(txt);
		for (int i = 1; i <= num; i = checked(i + 1))
		{
			string text = Conversion.Hex(Strings.Asc(Strings.Mid(txt, i, 1)));
			if ((Strings.Asc(Strings.Left(text, 1)) >= 66) & (Strings.Asc(Strings.Left(text, 1)) <= 70))
			{
				result = false;
				break;
			}
		}
		return result;
	}
}
