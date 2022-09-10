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
public class ll_uffbnamejxformat : Office2007Form
{
	private IContainer components;

	[AccessedThroughProperty("ll_lbnameformat")]
	private ListBox _ll_lbnameformat;

	[AccessedThroughProperty("ll_btnok")]
	private ButtonX _ll_btnok;

	public string bz;

	internal virtual ListBox ll_lbnameformat
	{
		[DebuggerNonUserCode]
		get
		{
			return _ll_lbnameformat;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_ll_lbnameformat = value;
		}
	}

	internal virtual ButtonX ll_btnok
	{
		[DebuggerNonUserCode]
		get
		{
			return _ll_btnok;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = ll_btnok_Click;
			if (_ll_btnok != null)
			{
				((Control)_ll_btnok).remove_Click(eventHandler);
			}
			_ll_btnok = value;
			if (_ll_btnok != null)
			{
				((Control)_ll_btnok).add_Click(eventHandler);
			}
		}
	}

	[DebuggerNonUserCode]
	public ll_uffbnamejxformat()
	{
		((Form)this).add_Load((EventHandler)ll_uffbnamejxformat_Load);
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
		//IL_0132: Unknown result type (might be due to invalid IL or missing references)
		//IL_013c: Expected O, but got Unknown
		//IL_0188: Unknown result type (might be due to invalid IL or missing references)
		//IL_0192: Expected O, but got Unknown
		ll_lbnameformat = new ListBox();
		ll_btnok = new ButtonX();
		((Control)this).SuspendLayout();
		((ListControl)ll_lbnameformat).set_FormattingEnabled(true);
		ll_lbnameformat.set_ItemHeight(12);
		ListBox obj = ll_lbnameformat;
		Point location = new Point(6, 12);
		((Control)obj).set_Location(location);
		((Control)ll_lbnameformat).set_Name("ll_lbnameformat");
		ll_lbnameformat.set_SelectionMode((SelectionMode)2);
		ListBox obj2 = ll_lbnameformat;
		Size size = new Size(204, 220);
		((Control)obj2).set_Size(size);
		((Control)ll_lbnameformat).set_TabIndex(0);
		((Control)ll_btnok).set_AccessibleRole((AccessibleRole)43);
		ll_btnok.set_ColorTable((eButtonColor)3);
		ButtonX obj3 = ll_btnok;
		location = new Point(64, 238);
		((Control)obj3).set_Location(location);
		((Control)ll_btnok).set_Name("ll_btnok");
		ButtonX obj4 = ll_btnok;
		size = new Size(88, 23);
		((Control)obj4).set_Size(size);
		((PopupItemControl)ll_btnok).set_Style((eDotNetBarStyle)7);
		((Control)ll_btnok).set_TabIndex(1);
		ll_btnok.set_Text("确定");
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)0);
		((Form)this).set_AutoSizeMode((AutoSizeMode)0);
		((Office2007Form)this).set_CaptionFont(new Font("宋体", 9f, (FontStyle)0, (GraphicsUnit)3, (byte)134));
		size = new Size(216, 266);
		((Form)this).set_ClientSize(size);
		((Control)this).get_Controls().Add((Control)(object)ll_btnok);
		((Control)this).get_Controls().Add((Control)(object)ll_lbnameformat);
		((Control)this).set_Font(new Font("宋体", 9f, (FontStyle)0, (GraphicsUnit)3, (byte)134));
		((Form)this).set_FormBorderStyle((FormBorderStyle)3);
		((Form)this).set_MaximizeBox(false);
		((Form)this).set_MinimizeBox(false);
		((Control)this).set_Name("ll_uffbnamejxformat");
		((Form)this).set_ShowIcon(false);
		((Form)this).set_ShowInTaskbar(false);
		((Form)this).set_StartPosition((FormStartPosition)1);
		((Form)this).set_Text("待选的解析说明.. .");
		((Control)this).ResumeLayout(false);
	}

	private void ll_uffbnamejxformat_Load(object sender, EventArgs e)
	{
		string path = Application.get_StartupPath() + "\\config\\解析格式列表.ini";
		Mod1.lr = new StreamReader(path, Encoding.Default);
		string text = "";
		while (!Information.IsNothing((object)text))
		{
			text = Mod1.lr.ReadLine();
			if (Operators.CompareString(Strings.Trim(text), "", false) != 0)
			{
				ll_lbnameformat.get_Items().Add((object)text);
			}
		}
		Mod1.lr.Close();
		Mod1.lr.Dispose();
	}

	private void ll_btnok_Click(object sender, EventArgs e)
	{
		string text = "_";
		Q_JS.strtempch = "_";
		checked
		{
			if (Operators.CompareString(bz, "【步骤3】", false) == 0)
			{
				int num = ll_lbnameformat.get_Items().get_Count() - 1;
				for (int i = 0; i <= num; i++)
				{
					if (ll_lbnameformat.GetSelected(i))
					{
						string text2 = text;
						ObjectCollection items = ll_lbnameformat.get_Items();
						ObjectCollection obj = items;
						int num2 = i;
						string text3 = Conversions.ToString(obj.get_Item(num2));
						string text4 = Mod1.toen(ref text3);
						items.set_Item(num2, (object)text3);
						text = text2 + "," + text4;
						Q_JS.strtempch = Conversions.ToString(Operators.ConcatenateObject((object)(Q_JS.strtempch + ","), ll_lbnameformat.get_Items().get_Item(i)));
					}
				}
				if (Operators.CompareString(Strings.Trim(text), "_", false) != 0)
				{
					Q_JS.strjxen = text;
					Q_JS.strjxch = Q_JS.strtempch;
					((Form)this).Close();
				}
				return;
			}
			if (Operators.CompareString(bz, "【步骤2】", false) == 0)
			{
				int num3 = ll_lbnameformat.get_Items().get_Count() - 1;
				for (int j = 0; j <= num3; j++)
				{
					if (ll_lbnameformat.GetSelected(j))
					{
						string text5 = text;
						ObjectCollection items = ll_lbnameformat.get_Items();
						ObjectCollection obj2 = items;
						int num2 = j;
						string text3 = Conversions.ToString(obj2.get_Item(num2));
						string text6 = Mod1.toen(ref text3);
						items.set_Item(num2, (object)text3);
						text = text5 + "," + text6;
						Q_JS.strtempch = Conversions.ToString(Operators.ConcatenateObject((object)(Q_JS.strtempch + ","), ll_lbnameformat.get_Items().get_Item(j)));
					}
				}
				if (Operators.CompareString(Strings.Trim(text), "_", false) != 0)
				{
					Q_JS.strjxen = text;
					Q_JS.strjxch = Q_JS.strtempch;
					((Form)this).Close();
				}
				return;
			}
			int num4 = ll_lbnameformat.get_Items().get_Count() - 1;
			for (int k = 0; k <= num4; k++)
			{
				if (ll_lbnameformat.GetSelected(k))
				{
					string text7 = text;
					ObjectCollection items = ll_lbnameformat.get_Items();
					ObjectCollection obj3 = items;
					int num2 = k;
					string text3 = Conversions.ToString(obj3.get_Item(num2));
					string text8 = Mod1.toen(ref text3);
					items.set_Item(num2, (object)text3);
					text = text7 + "," + text8;
					Q_JS.strtempch = Conversions.ToString(Operators.ConcatenateObject((object)(Q_JS.strtempch + ","), ll_lbnameformat.get_Items().get_Item(k)));
				}
			}
			if (Operators.CompareString(Strings.Trim(text), "_", false) != 0)
			{
				((TextBox)MyProject.Forms.ll_ufxnonly1.ll_txtfbformat).set_Text(text);
				MyProject.Forms.ll_ufxnonly1.ll_lbefbnamejxformat.set_Text(Q_JS.strtempch);
				((Form)this).Close();
			}
		}
	}
}
