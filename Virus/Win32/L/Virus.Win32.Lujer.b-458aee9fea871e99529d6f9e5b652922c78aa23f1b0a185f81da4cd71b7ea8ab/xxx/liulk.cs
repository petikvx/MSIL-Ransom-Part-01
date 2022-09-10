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
public class liulk : Office2007Form
{
	private IContainer components;

	[AccessedThroughProperty("LabelX1")]
	private LabelX _LabelX1;

	[AccessedThroughProperty("kulist")]
	private ListBox _kulist;

	[AccessedThroughProperty("btnqd")]
	private ButtonX _btnqd;

	[AccessedThroughProperty("gb")]
	private ButtonX _gb;

	private string f;

	private string[] ff;

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

	internal virtual ListBox kulist
	{
		[DebuggerNonUserCode]
		get
		{
			return _kulist;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = kulist_DoubleClick;
			if (_kulist != null)
			{
				((Control)_kulist).remove_DoubleClick(eventHandler);
			}
			_kulist = value;
			if (_kulist != null)
			{
				((Control)_kulist).add_DoubleClick(eventHandler);
			}
		}
	}

	internal virtual ButtonX btnqd
	{
		[DebuggerNonUserCode]
		get
		{
			return _btnqd;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = btnqd_Click;
			if (_btnqd != null)
			{
				((Control)_btnqd).remove_Click(eventHandler);
			}
			_btnqd = value;
			if (_btnqd != null)
			{
				((Control)_btnqd).add_Click(eventHandler);
			}
		}
	}

	internal virtual ButtonX gb
	{
		[DebuggerNonUserCode]
		get
		{
			return _gb;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = gb_Click;
			if (_gb != null)
			{
				((Control)_gb).remove_Click(eventHandler);
			}
			_gb = value;
			if (_gb != null)
			{
				((Control)_gb).add_Click(eventHandler);
			}
		}
	}

	[DebuggerNonUserCode]
	public liulk()
	{
		((Form)this).add_Load((EventHandler)liulk_Load);
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
		//IL_0263: Unknown result type (might be due to invalid IL or missing references)
		//IL_026d: Expected O, but got Unknown
		//IL_02db: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e5: Expected O, but got Unknown
		LabelX1 = new LabelX();
		kulist = new ListBox();
		btnqd = new ButtonX();
		gb = new ButtonX();
		((Control)this).SuspendLayout();
		((BaseItemControl)LabelX1).get_BackgroundStyle().set_Class("");
		((BaseItemControl)LabelX1).get_BackgroundStyle().set_CornerType((eCornerType)1);
		LabelX labelX = LabelX1;
		Point location = new Point(12, 12);
		((Control)labelX).set_Location(location);
		((Control)LabelX1).set_Name("LabelX1");
		LabelX labelX2 = LabelX1;
		Size size = new Size(164, 17);
		((Control)labelX2).set_Size(size);
		((Control)LabelX1).set_TabIndex(0);
		LabelX1.set_Text("源模型库列表");
		((ListControl)kulist).set_FormattingEnabled(true);
		kulist.set_ItemHeight(12);
		ListBox obj = kulist;
		location = new Point(12, 35);
		((Control)obj).set_Location(location);
		((Control)kulist).set_Name("kulist");
		ListBox obj2 = kulist;
		size = new Size(185, 208);
		((Control)obj2).set_Size(size);
		((Control)kulist).set_TabIndex(1);
		((Control)btnqd).set_AccessibleRole((AccessibleRole)43);
		btnqd.set_ColorTable((eButtonColor)3);
		ButtonX obj3 = btnqd;
		location = new Point(52, 249);
		((Control)obj3).set_Location(location);
		((Control)btnqd).set_Name("btnqd");
		ButtonX obj4 = btnqd;
		size = new Size(102, 23);
		((Control)obj4).set_Size(size);
		((PopupItemControl)btnqd).set_Style((eDotNetBarStyle)7);
		((Control)btnqd).set_TabIndex(2);
		btnqd.set_Text("确定");
		((Control)gb).set_AccessibleRole((AccessibleRole)43);
		gb.set_ColorTable((eButtonColor)3);
		gb.set_DialogResult((DialogResult)2);
		ButtonX obj5 = gb;
		location = new Point(52, 111);
		((Control)obj5).set_Location(location);
		((Control)gb).set_Name("gb");
		ButtonX obj6 = gb;
		size = new Size(102, 23);
		((Control)obj6).set_Size(size);
		((PopupItemControl)gb).set_Style((eDotNetBarStyle)7);
		((Control)gb).set_TabIndex(2);
		gb.set_Text("关闭");
		((Control)gb).set_Visible(false);
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)0);
		((Form)this).set_AutoSizeMode((AutoSizeMode)0);
		((Form)this).set_CancelButton((IButtonControl)(object)gb);
		((Office2007Form)this).set_CaptionFont(new Font("宋体", 9f, (FontStyle)0, (GraphicsUnit)3, (byte)134));
		size = new Size(209, 280);
		((Form)this).set_ClientSize(size);
		((Control)this).get_Controls().Add((Control)(object)btnqd);
		((Control)this).get_Controls().Add((Control)(object)kulist);
		((Control)this).get_Controls().Add((Control)(object)LabelX1);
		((Control)this).get_Controls().Add((Control)(object)gb);
		((Control)this).set_Font(new Font("宋体", 9f, (FontStyle)0, (GraphicsUnit)3, (byte)134));
		((Form)this).set_FormBorderStyle((FormBorderStyle)3);
		((Form)this).set_MaximizeBox(false);
		((Form)this).set_MinimizeBox(false);
		((Control)this).set_Name("liulk");
		((Form)this).set_ShowIcon(false);
		((Form)this).set_ShowInTaskbar(false);
		((Form)this).set_StartPosition((FormStartPosition)1);
		((Form)this).set_Text("浏览当前库...");
		((Control)this).ResumeLayout(false);
	}

	private void gb_Click(object sender, EventArgs e)
	{
		((Component)(object)this).Dispose();
	}

	private void liulk_Load(object sender, EventArgs e)
	{
		kulist.get_Items().Clear();
		Mod1.lr = new StreamReader(Mod1.Kulujing + "mlibs.lis", Encoding.Default);
		f = "";
		while (!Information.IsNothing((object)f))
		{
			f = Mod1.lr.ReadLine();
			if (Information.IsNothing((object)f))
			{
				break;
			}
			kulist.get_Items().Add((object)f);
		}
		Mod1.lr.Close();
		Mod1.lr.Dispose();
	}

	private void btnqd_Click(object sender, EventArgs e)
	{
		if ((kulist.get_SelectedIndex() != -1) & (kulist.get_Items().get_Count() != 0))
		{
			ff = kulist.get_Text().Split(new char[1] { ',' });
			((TextBox)MyProject.Forms.drclk.txtkname).set_Text(ff[1]);
			((Form)this).Close();
		}
	}

	private void kulist_DoubleClick(object sender, EventArgs e)
	{
		ff = kulist.get_Text().Split(new char[1] { ',' });
		((TextBox)MyProject.Forms.drclk.txtkname).set_Text(ff[1]);
		((Form)this).Close();
	}
}
