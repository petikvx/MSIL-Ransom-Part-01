using System;
using System.Collections;
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
public class tjbj : Office2007Form
{
	private IContainer components;

	[AccessedThroughProperty("LabelX1")]
	private LabelX _LabelX1;

	[AccessedThroughProperty("LabelX2")]
	private LabelX _LabelX2;

	[AccessedThroughProperty("qr")]
	private ButtonX _qr;

	[AccessedThroughProperty("qx")]
	private ButtonX _qx;

	[AccessedThroughProperty("bjch")]
	private TextBoxX _bjch;

	[AccessedThroughProperty("bjen")]
	private TextBoxX _bjen;

	private int i;

	private string h;

	public int index;

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

	internal virtual ButtonX qr
	{
		[DebuggerNonUserCode]
		get
		{
			return _qr;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = qr_Click;
			if (_qr != null)
			{
				((Control)_qr).remove_Click(eventHandler);
			}
			_qr = value;
			if (_qr != null)
			{
				((Control)_qr).add_Click(eventHandler);
			}
		}
	}

	internal virtual ButtonX qx
	{
		[DebuggerNonUserCode]
		get
		{
			return _qx;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = qx_Click;
			if (_qx != null)
			{
				((Control)_qx).remove_Click(eventHandler);
			}
			_qx = value;
			if (_qx != null)
			{
				((Control)_qx).add_Click(eventHandler);
			}
		}
	}

	public virtual TextBoxX bjch
	{
		[DebuggerNonUserCode]
		get
		{
			return _bjch;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_bjch = value;
		}
	}

	public virtual TextBoxX bjen
	{
		[DebuggerNonUserCode]
		get
		{
			return _bjen;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_bjen = value;
		}
	}

	[DebuggerNonUserCode]
	public tjbj()
	{
		((Form)this).add_Load((EventHandler)tjbj_Load);
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
		//IL_037f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0389: Expected O, but got Unknown
		//IL_0416: Unknown result type (might be due to invalid IL or missing references)
		//IL_0420: Expected O, but got Unknown
		LabelX1 = new LabelX();
		bjch = new TextBoxX();
		LabelX2 = new LabelX();
		bjen = new TextBoxX();
		qr = new ButtonX();
		qx = new ButtonX();
		((Control)this).SuspendLayout();
		((BaseItemControl)LabelX1).get_BackgroundStyle().set_Class("");
		((BaseItemControl)LabelX1).get_BackgroundStyle().set_CornerType((eCornerType)1);
		LabelX labelX = LabelX1;
		Point location = new Point(22, 12);
		((Control)labelX).set_Location(location);
		((Control)LabelX1).set_Name("LabelX1");
		LabelX labelX2 = LabelX1;
		Size size = new Size(87, 19);
		((Control)labelX2).set_Size(size);
		((Control)LabelX1).set_TabIndex(0);
		LabelX1.set_Text("部件中文名：");
		bjch.get_Border().set_Class("TextBoxBorder");
		bjch.get_Border().set_CornerType((eCornerType)1);
		TextBoxX obj = bjch;
		location = new Point(99, 9);
		((Control)obj).set_Location(location);
		((Control)bjch).set_Name("bjch");
		TextBoxX obj2 = bjch;
		size = new Size(141, 21);
		((Control)obj2).set_Size(size);
		((Control)bjch).set_TabIndex(0);
		((BaseItemControl)LabelX2).get_BackgroundStyle().set_Class("");
		((BaseItemControl)LabelX2).get_BackgroundStyle().set_CornerType((eCornerType)1);
		LabelX labelX3 = LabelX2;
		location = new Point(22, 41);
		((Control)labelX3).set_Location(location);
		((Control)LabelX2).set_Name("LabelX2");
		LabelX labelX4 = LabelX2;
		size = new Size(84, 19);
		((Control)labelX4).set_Size(size);
		((Control)LabelX2).set_TabIndex(0);
		LabelX2.set_Text("部件英文名：");
		bjen.get_Border().set_Class("TextBoxBorder");
		bjen.get_Border().set_CornerType((eCornerType)1);
		TextBoxX obj3 = bjen;
		location = new Point(99, 39);
		((Control)obj3).set_Location(location);
		((Control)bjen).set_Name("bjen");
		((TextBoxBase)bjen).set_ReadOnly(true);
		TextBoxX obj4 = bjen;
		size = new Size(141, 21);
		((Control)obj4).set_Size(size);
		((Control)bjen).set_TabIndex(1);
		((Control)qr).set_AccessibleRole((AccessibleRole)43);
		qr.set_ColorTable((eButtonColor)3);
		ButtonX obj5 = qr;
		location = new Point(22, 76);
		((Control)obj5).set_Location(location);
		((Control)qr).set_Name("qr");
		ButtonX obj6 = qr;
		size = new Size(87, 23);
		((Control)obj6).set_Size(size);
		((PopupItemControl)qr).set_Style((eDotNetBarStyle)7);
		((Control)qr).set_TabIndex(2);
		qr.set_Text("确认");
		((Control)qx).set_AccessibleRole((AccessibleRole)43);
		qx.set_ColorTable((eButtonColor)3);
		qx.set_DialogResult((DialogResult)2);
		ButtonX obj7 = qx;
		location = new Point(153, 76);
		((Control)obj7).set_Location(location);
		((Control)qx).set_Name("qx");
		ButtonX obj8 = qx;
		size = new Size(87, 23);
		((Control)obj8).set_Size(size);
		((PopupItemControl)qx).set_Style((eDotNetBarStyle)7);
		((Control)qx).set_TabIndex(3);
		qx.set_Text("取消");
		((Form)this).set_AcceptButton((IButtonControl)(object)qr);
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)0);
		((Form)this).set_AutoSizeMode((AutoSizeMode)0);
		((Form)this).set_CancelButton((IButtonControl)(object)qx);
		((Office2007Form)this).set_CaptionFont(new Font("宋体", 9f, (FontStyle)0, (GraphicsUnit)3, (byte)134));
		size = new Size(257, 117);
		((Form)this).set_ClientSize(size);
		((Control)this).get_Controls().Add((Control)(object)qx);
		((Control)this).get_Controls().Add((Control)(object)qr);
		((Control)this).get_Controls().Add((Control)(object)bjen);
		((Control)this).get_Controls().Add((Control)(object)bjch);
		((Control)this).get_Controls().Add((Control)(object)LabelX2);
		((Control)this).get_Controls().Add((Control)(object)LabelX1);
		((Control)this).set_Font(new Font("宋体", 9f, (FontStyle)0, (GraphicsUnit)3, (byte)134));
		((Form)this).set_FormBorderStyle((FormBorderStyle)3);
		((Form)this).set_MaximizeBox(false);
		((Form)this).set_MinimizeBox(false);
		((Control)this).set_Name("tjbj");
		((Form)this).set_ShowIcon(false);
		((Form)this).set_ShowInTaskbar(false);
		((Form)this).set_StartPosition((FormStartPosition)1);
		((Control)this).ResumeLayout(false);
	}

	private void qr_Click(object sender, EventArgs e)
	{
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_01df: Unknown result type (might be due to invalid IL or missing references)
		//IL_020e: Unknown result type (might be due to invalid IL or missing references)
		//IL_030c: Unknown result type (might be due to invalid IL or missing references)
		if (MyProject.Forms.bjmlibs.bjname.get_Items().get_Count() != 0)
		{
			if (Operators.CompareString(((Form)this).get_Text(), "编辑部件名称", false) != 0)
			{
				if (((TextBox)bjen).get_Text().IndexOf("\\") != -1)
				{
					Interaction.MsgBox((object)"英文名称当中不能有【\\】！", (MsgBoxStyle)64, (object)"提示");
					return;
				}
				if ((Operators.CompareString(Strings.Trim(((TextBox)bjch).get_Text()), "", false) != 0) & (Operators.CompareString(Strings.Trim(((TextBox)bjen).get_Text()), "", false) != 0))
				{
					if (Operators.ConditionalCompareObjectNotEqual(CheckName(), (object)false, false) && Operators.ConditionalCompareObjectNotEqual(CheckGS(), (object)false, false) && Operators.ConditionalCompareObjectNotEqual(CheckCF(), (object)false, false))
					{
						MyProject.Forms.bjmlibs.bjname.get_Items().Add((object)(((TextBox)bjch).get_Text() + "," + ((TextBox)bjen).get_Text()));
						MyProject.Forms.bjmlibs.log.get_Items().Add((object)(Conversions.ToString(DateTime.Now) + " 添加部件的名字为：" + ((TextBox)bjch).get_Text() + "," + ((TextBox)bjen).get_Text().ToLower()));
						((Control)MyProject.Forms.bjmlibs.bc).set_Enabled(false);
						((TextBox)bjch).set_Text("");
						((TextBox)bjen).set_Text("");
						((Control)bjch).Focus();
					}
				}
				else
				{
					Interaction.MsgBox((object)"中文名或英文名不能为空", (MsgBoxStyle)64, (object)"提示");
				}
			}
			else
			{
				if (((TextBox)bjen).get_Text().IndexOf("\\") != -1)
				{
					Interaction.MsgBox((object)"英文名称当中不能有【\\】！", (MsgBoxStyle)64, (object)"提示");
					return;
				}
				if ((Operators.CompareString(Strings.Trim(((TextBox)bjch).get_Text()), "", false) != 0) & (Operators.CompareString(Strings.Trim(((TextBox)bjen).get_Text()), "", false) != 0))
				{
					if (Operators.ConditionalCompareObjectNotEqual(CheckName(), (object)false, false) && Operators.ConditionalCompareObjectNotEqual(CheckGS(), (object)false, false) && Operators.ConditionalCompareObjectNotEqual(CheckCF(), (object)false, false))
					{
						MyProject.Forms.bjmlibs.bjname.get_Items().set_Item(index, (object)(((TextBox)bjch).get_Text() + "," + ((TextBox)bjen).get_Text().ToLower()));
						((Control)MyProject.Forms.bjmlibs.bc).set_Enabled(false);
						((Form)this).Close();
					}
				}
				else
				{
					Interaction.MsgBox((object)"中文名或英文名不能为空", (MsgBoxStyle)64, (object)"提示");
				}
			}
		}
		((Component)(object)this).Dispose();
	}

	private void qx_Click(object sender, EventArgs e)
	{
		((Form)this).Close();
	}

	public object CheckName()
	{
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_0103: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			object result;
			if ((((TextBox)bjen).get_Text().IndexOf(" ") != -1) | (((TextBox)bjch).get_Text().IndexOf(" ") != -1))
			{
				Interaction.MsgBox((object)"部件名中文名或英文名中不能有空格！！", (MsgBoxStyle)64, (object)"提示");
				((Control)bjch).Focus();
				result = false;
			}
			else
			{
				result = true;
				int num = Strings.Len(((TextBox)bjen).get_Text());
				i = 1;
				while (i <= num)
				{
					h = Conversion.Hex(Strings.Asc(Strings.Mid(((TextBox)bjen).get_Text(), i, 1)));
					if (!((Strings.Asc(Strings.Left(h, 1)) >= 66) & (Strings.Asc(Strings.Left(h, 1)) <= 70)))
					{
						i++;
						continue;
					}
					Interaction.MsgBox((object)"英文部件名不能有中文！！", (MsgBoxStyle)64, (object)"提示");
					((Control)bjen).Focus();
					result = false;
					break;
				}
			}
			return result;
		}
	}

	public object CheckCF()
	{
		//IL_015e: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_040b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0436: Unknown result type (might be due to invalid IL or missing references)
		object result = true;
		checked
		{
			if (Operators.CompareString(((Form)this).get_Text(), "编辑部件名称", false) == 0)
			{
				string text = MyProject.Forms.bjmlibs.bjname.get_Text();
				string[] array = text.Split(new char[1] { ',' });
				if (Operators.CompareString(array[0], ((TextBox)bjch).get_Text(), false) != 0)
				{
					ArrayList arrayList = new ArrayList();
					int num = MyProject.Forms.bjmlibs.bjname.get_Items().get_Count() - 1;
					for (int i = 0; i <= num; i++)
					{
						text = Conversions.ToString(MyProject.Forms.bjmlibs.bjname.get_Items().get_Item(i));
						array = text.Split(new char[1] { ',' });
						arrayList.Add(array[0]);
					}
					arrayList.Add(((TextBox)bjch).get_Text());
					int num2 = arrayList.Count - 2;
					this.i = 0;
					while (this.i <= num2)
					{
						if (!Operators.ConditionalCompareObjectEqual(arrayList[arrayList.Count - 1], arrayList[this.i], false))
						{
							this.i++;
							continue;
						}
						goto IL_0142;
					}
				}
				text = MyProject.Forms.bjmlibs.bjname.get_Text();
				string[] array2 = text.Split(new char[1] { ',' });
				if (Operators.CompareString(array2[1].ToLower(), ((TextBox)bjen).get_Text().ToLower(), false) != 0)
				{
					ArrayList arrayList2 = new ArrayList();
					arrayList2.Clear();
					int num3 = MyProject.Forms.bjmlibs.bjname.get_Items().get_Count() - 1;
					for (int j = 0; j <= num3; j++)
					{
						text = Conversions.ToString(MyProject.Forms.bjmlibs.bjname.get_Items().get_Item(j));
						array = text.Split(new char[1] { ',' });
						arrayList2.Add(array[1].ToLower());
					}
					arrayList2.Add(((TextBox)bjen).get_Text().ToLower());
					int num4 = arrayList2.Count - 2;
					this.i = 0;
					while (this.i <= num4)
					{
						if (!Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(arrayList2[arrayList2.Count - 1], (Type)null, "ToLower", new object[0], (string[])null, (Type[])null, (bool[])null), NewLateBinding.LateGet(arrayList2[this.i], (Type)null, "ToLower", new object[0], (string[])null, (Type[])null, (bool[])null), false))
						{
							this.i++;
							continue;
						}
						Interaction.MsgBox((object)(((TextBox)bjen).get_Text() + " 部件名已存在！"), (MsgBoxStyle)64, (object)"提示");
						result = false;
						break;
					}
				}
			}
			else if (MyProject.Forms.bjmlibs.bjname.get_Items().get_Count() != 0)
			{
				int num5 = MyProject.Forms.bjmlibs.bjname.get_Items().get_Count() - 1;
				this.i = 0;
				while (this.i <= num5)
				{
					string text2 = Conversions.ToString(MyProject.Forms.bjmlibs.bjname.get_Items().get_Item(this.i));
					string[] array3 = text2.Split(new char[1] { ',' });
					if (Operators.CompareString(array3[0].ToLower(), ((TextBox)bjch).get_Text(), false) != 0)
					{
						if (Operators.CompareString(array3[1].ToLower(), ((TextBox)bjen).get_Text().ToLower(), false) != 0)
						{
							this.i++;
							continue;
						}
						Interaction.MsgBox((object)(((TextBox)bjen).get_Text() + " 部件名已存在！"), (MsgBoxStyle)64, (object)"提示");
						result = false;
						break;
					}
					Interaction.MsgBox((object)(((TextBox)bjch).get_Text() + " 部件名已存在！"), (MsgBoxStyle)64, (object)"提示");
					result = false;
					break;
				}
			}
			goto IL_0443;
		}
		IL_0443:
		return result;
		IL_0142:
		Interaction.MsgBox((object)(((TextBox)bjch).get_Text() + " 部件名已存在 ！！"), (MsgBoxStyle)64, (object)"提示");
		result = false;
		goto IL_0443;
	}

	public object CheckGS()
	{
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0098: Unknown result type (might be due to invalid IL or missing references)
		object result = true;
		if (Conversions.ToDouble(Strings.Trim(Conversions.ToString(((TextBox)bjch).get_Text().IndexOf(",")))) != -1.0)
		{
			Interaction.MsgBox((object)"中文部件名中不能包含逗号！", (MsgBoxStyle)64, (object)"提示");
			result = false;
			((Control)bjch).Focus();
		}
		else if (Conversions.ToDouble(Strings.Trim(Conversions.ToString(((TextBox)bjen).get_Text().IndexOf(",")))) != -1.0)
		{
			Interaction.MsgBox((object)"英文部件名中不能包含逗号！", (MsgBoxStyle)64, (object)"提示");
			result = false;
			((Control)bjen).Focus();
		}
		return result;
	}

	private void tjbj_Load(object sender, EventArgs e)
	{
		((Control)bjch).Focus();
	}
}
