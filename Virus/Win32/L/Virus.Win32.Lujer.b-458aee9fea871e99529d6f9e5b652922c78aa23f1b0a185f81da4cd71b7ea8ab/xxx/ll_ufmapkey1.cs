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
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace xxx;

[DesignerGenerated]
public class ll_ufmapkey1 : Office2007Form
{
	private IContainer components;

	[AccessedThroughProperty("ll_lbproelisreadme")]
	private ListBox _ll_lbproelisreadme;

	[AccessedThroughProperty("ll_btnok")]
	private ButtonX _ll_btnok;

	[AccessedThroughProperty("ll_chkcontact")]
	private CheckBoxX _ll_chkcontact;

	private ArrayList ll_lbproelis;

	internal virtual ListBox ll_lbproelisreadme
	{
		[DebuggerNonUserCode]
		get
		{
			return _ll_lbproelisreadme;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_ll_lbproelisreadme = value;
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

	internal virtual CheckBoxX ll_chkcontact
	{
		[DebuggerNonUserCode]
		get
		{
			return _ll_chkcontact;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_ll_chkcontact = value;
		}
	}

	public ll_ufmapkey1()
	{
		((Form)this).add_Load((EventHandler)ll_ufmapkey1_Load);
		ll_lbproelis = new ArrayList();
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
		//IL_01ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c4: Expected O, but got Unknown
		//IL_0221: Unknown result type (might be due to invalid IL or missing references)
		//IL_022b: Expected O, but got Unknown
		ll_lbproelisreadme = new ListBox();
		ll_btnok = new ButtonX();
		ll_chkcontact = new CheckBoxX();
		((Control)this).SuspendLayout();
		((ListControl)ll_lbproelisreadme).set_FormattingEnabled(true);
		ll_lbproelisreadme.set_ItemHeight(12);
		ListBox obj = ll_lbproelisreadme;
		Point location = new Point(3, 12);
		((Control)obj).set_Location(location);
		((Control)ll_lbproelisreadme).set_Name("ll_lbproelisreadme");
		ListBox obj2 = ll_lbproelisreadme;
		Size size = new Size(179, 196);
		((Control)obj2).set_Size(size);
		((Control)ll_lbproelisreadme).set_TabIndex(0);
		((Control)ll_btnok).set_AccessibleRole((AccessibleRole)43);
		ll_btnok.set_ColorTable((eButtonColor)3);
		ButtonX obj3 = ll_btnok;
		location = new Point(3, 243);
		((Control)obj3).set_Location(location);
		((Control)ll_btnok).set_Name("ll_btnok");
		ButtonX obj4 = ll_btnok;
		size = new Size(179, 23);
		((Control)obj4).set_Size(size);
		((PopupItemControl)ll_btnok).set_Style((eDotNetBarStyle)7);
		((Control)ll_btnok).set_TabIndex(1);
		ll_btnok.set_Text("确定");
		((BaseItemControl)ll_chkcontact).get_BackgroundStyle().set_Class("");
		((BaseItemControl)ll_chkcontact).get_BackgroundStyle().set_CornerType((eCornerType)1);
		CheckBoxX obj5 = ll_chkcontact;
		location = new Point(3, 214);
		((Control)obj5).set_Location(location);
		((Control)ll_chkcontact).set_Name("ll_chkcontact");
		CheckBoxX obj6 = ll_chkcontact;
		size = new Size(110, 23);
		((Control)obj6).set_Size(size);
		((BaseItemControl)ll_chkcontact).set_Style((eDotNetBarStyle)7);
		((Control)ll_chkcontact).set_TabIndex(2);
		ll_chkcontact.set_Text("包含接触定义");
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)0);
		((Office2007Form)this).set_CaptionFont(new Font("宋体", 9f, (FontStyle)0, (GraphicsUnit)3, (byte)134));
		size = new Size(186, 273);
		((Form)this).set_ClientSize(size);
		((Control)this).get_Controls().Add((Control)(object)ll_chkcontact);
		((Control)this).get_Controls().Add((Control)(object)ll_btnok);
		((Control)this).get_Controls().Add((Control)(object)ll_lbproelisreadme);
		((Control)this).set_Font(new Font("宋体", 9f, (FontStyle)0, (GraphicsUnit)3, (byte)134));
		((Form)this).set_FormBorderStyle((FormBorderStyle)1);
		((Form)this).set_MaximizeBox(false);
		((Form)this).set_MinimizeBox(false);
		((Control)this).set_Name("ll_ufmapkey1");
		((Form)this).set_ShowIcon(false);
		((Form)this).set_ShowInTaskbar(false);
		((Form)this).set_StartPosition((FormStartPosition)1);
		((Form)this).set_Text("映射键选项");
		((Control)this).ResumeLayout(false);
	}

	private void ll_ufmapkey1_Load(object sender, EventArgs e)
	{
		ll_lbproelis.Clear();
		ll_lbproelisreadme.get_Items().Clear();
		string path = Application.get_StartupPath() + "\\config\\mapkey1\\readme.ini";
		Mod1.lr = new StreamReader(path, Encoding.Default);
		string text = "";
		while (!Information.IsNothing((object)text))
		{
			text = Mod1.lr.ReadLine();
			if (Operators.CompareString(text, "", false) == 0)
			{
				break;
			}
			string[] array = Strings.Split(text, ",", -1, (CompareMethod)0);
			ll_lbproelis.Add(array[0]);
			ll_lbproelisreadme.get_Items().Add((object)array[1]);
		}
		Mod1.lr.Close();
		Mod1.lr.Dispose();
		ll_lbproelisreadme.set_SelectedIndex(0);
		ll_chkcontact.set_Checked(true);
	}

	private void ll_btnok_Click(object sender, EventArgs e)
	{
		Mod1.proex = Conversions.ToString(ll_lbproelis[ll_lbproelisreadme.get_SelectedIndex()]);
		if (ll_chkcontact.get_Checked())
		{
			Mod1.scontact = "c";
		}
		else
		{
			Mod1.scontact = "";
		}
		((Form)this).Close();
	}
}
