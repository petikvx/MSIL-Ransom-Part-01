using System;
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
using xxx.My;

namespace xxx;

[DesignerGenerated]
public class Pic : Office2007Form
{
	private IContainer components;

	[AccessedThroughProperty("ll_chkbmpfilter")]
	private CheckBoxX _ll_chkbmpfilter;

	[AccessedThroughProperty("PictureBox1")]
	private PictureBox _PictureBox1;

	[AccessedThroughProperty("lbtplb")]
	private ListBox _lbtplb;

	[AccessedThroughProperty("btngb")]
	private ButtonX _btngb;

	[AccessedThroughProperty("lblog")]
	private LabelX _lblog;

	private string strcsymname;

	private string strcsfpath;

	private string flisname;

	private string strcsname;

	private string fname;

	private bool @checked;

	public virtual CheckBoxX ll_chkbmpfilter
	{
		[DebuggerNonUserCode]
		get
		{
			return _ll_chkbmpfilter;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = ll_chkbmpfilter_CheckedChanged;
			if (_ll_chkbmpfilter != null)
			{
				_ll_chkbmpfilter.remove_CheckedChanged(eventHandler);
			}
			_ll_chkbmpfilter = value;
			if (_ll_chkbmpfilter != null)
			{
				_ll_chkbmpfilter.add_CheckedChanged(eventHandler);
			}
		}
	}

	public virtual PictureBox PictureBox1
	{
		[DebuggerNonUserCode]
		get
		{
			return _PictureBox1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = PictureBox1_Click;
			if (_PictureBox1 != null)
			{
				((Control)_PictureBox1).remove_Click(eventHandler);
			}
			_PictureBox1 = value;
			if (_PictureBox1 != null)
			{
				((Control)_PictureBox1).add_Click(eventHandler);
			}
		}
	}

	public virtual ListBox lbtplb
	{
		[DebuggerNonUserCode]
		get
		{
			return _lbtplb;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = lbtplb_SelectedIndexChanged;
			if (_lbtplb != null)
			{
				_lbtplb.remove_SelectedIndexChanged(eventHandler);
			}
			_lbtplb = value;
			if (_lbtplb != null)
			{
				_lbtplb.add_SelectedIndexChanged(eventHandler);
			}
		}
	}

	internal virtual ButtonX btngb
	{
		[DebuggerNonUserCode]
		get
		{
			return _btngb;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = btngb_Click;
			if (_btngb != null)
			{
				((Control)_btngb).remove_Click(eventHandler);
			}
			_btngb = value;
			if (_btngb != null)
			{
				((Control)_btngb).add_Click(eventHandler);
			}
		}
	}

	public virtual LabelX lblog
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblog;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblog = value;
		}
	}

	[DebuggerNonUserCode]
	public Pic()
	{
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Expected O, but got Unknown
		((Form)this).add_Load((EventHandler)Pic_Load);
		((Form)this).add_FormClosed(new FormClosedEventHandler(Pic_FormClosed));
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
		//IL_00d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e0: Expected O, but got Unknown
		//IL_0304: Unknown result type (might be due to invalid IL or missing references)
		//IL_030e: Expected O, but got Unknown
		//IL_038d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0397: Expected O, but got Unknown
		PictureBox1 = new PictureBox();
		lbtplb = new ListBox();
		ll_chkbmpfilter = new CheckBoxX();
		btngb = new ButtonX();
		lblog = new LabelX();
		((ISupportInitialize)PictureBox1).BeginInit();
		((Control)this).SuspendLayout();
		((Control)PictureBox1).set_BackgroundImageLayout((ImageLayout)2);
		PictureBox pictureBox = PictureBox1;
		Point location = new Point(212, 3);
		((Control)pictureBox).set_Location(location);
		((Control)PictureBox1).set_Name("PictureBox1");
		PictureBox pictureBox2 = PictureBox1;
		Size size = new Size(652, 300);
		((Control)pictureBox2).set_Size(size);
		PictureBox1.set_SizeMode((PictureBoxSizeMode)4);
		PictureBox1.set_TabIndex(43);
		PictureBox1.set_TabStop(false);
		lbtplb.set_Font(new Font("宋体", 9f, (FontStyle)0, (GraphicsUnit)3, (byte)134));
		((ListControl)lbtplb).set_FormattingEnabled(true);
		lbtplb.set_ItemHeight(12);
		ListBox obj = lbtplb;
		location = new Point(4, 3);
		((Control)obj).set_Location(location);
		((Control)lbtplb).set_Name("lbtplb");
		ListBox obj2 = lbtplb;
		size = new Size(202, 280);
		((Control)obj2).set_Size(size);
		((Control)lbtplb).set_TabIndex(44);
		((BaseItemControl)ll_chkbmpfilter).get_BackgroundStyle().set_Class("");
		((BaseItemControl)ll_chkbmpfilter).get_BackgroundStyle().set_CornerType((eCornerType)1);
		((BaseItemControl)ll_chkbmpfilter).set_FocusCuesEnabled(false);
		CheckBoxX obj3 = ll_chkbmpfilter;
		location = new Point(4, 286);
		((Control)obj3).set_Location(location);
		((Control)ll_chkbmpfilter).set_Name("ll_chkbmpfilter");
		CheckBoxX obj4 = ll_chkbmpfilter;
		size = new Size(127, 19);
		((Control)obj4).set_Size(size);
		((BaseItemControl)ll_chkbmpfilter).set_Style((eDotNetBarStyle)7);
		((Control)ll_chkbmpfilter).set_TabIndex(45);
		ll_chkbmpfilter.set_Text("参数示意图过滤");
		((Control)btngb).set_AccessibleRole((AccessibleRole)43);
		btngb.set_ColorTable((eButtonColor)3);
		btngb.set_DialogResult((DialogResult)2);
		ButtonX obj5 = btngb;
		location = new Point(338, 57);
		((Control)obj5).set_Location(location);
		((Control)btngb).set_Name("btngb");
		ButtonX obj6 = btngb;
		size = new Size(75, 23);
		((Control)obj6).set_Size(size);
		((PopupItemControl)btngb).set_Style((eDotNetBarStyle)7);
		((Control)btngb).set_TabIndex(46);
		((BaseItemControl)lblog).get_BackgroundStyle().set_Class("");
		((BaseItemControl)lblog).get_BackgroundStyle().set_CornerType((eCornerType)1);
		LabelX obj7 = lblog;
		location = new Point(4, 311);
		((Control)obj7).set_Location(location);
		((Control)lblog).set_Name("lblog");
		LabelX obj8 = lblog;
		size = new Size(860, 23);
		((Control)obj8).set_Size(size);
		((Control)lblog).set_TabIndex(47);
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)0);
		((Form)this).set_AutoSizeMode((AutoSizeMode)0);
		((Form)this).set_CancelButton((IButtonControl)(object)btngb);
		((Office2007Form)this).set_CaptionFont(new Font("宋体", 9f, (FontStyle)0, (GraphicsUnit)3, (byte)134));
		size = new Size(867, 335);
		((Form)this).set_ClientSize(size);
		((Control)this).get_Controls().Add((Control)(object)lblog);
		((Control)this).get_Controls().Add((Control)(object)PictureBox1);
		((Control)this).get_Controls().Add((Control)(object)lbtplb);
		((Control)this).get_Controls().Add((Control)(object)ll_chkbmpfilter);
		((Control)this).get_Controls().Add((Control)(object)btngb);
		((Control)this).set_Font(new Font("宋体", 9f, (FontStyle)0, (GraphicsUnit)3, (byte)134));
		((Form)this).set_FormBorderStyle((FormBorderStyle)3);
		((Form)this).set_MaximizeBox(false);
		((Control)this).set_Name("Pic");
		((Form)this).set_ShowIcon(false);
		((Form)this).set_StartPosition((FormStartPosition)1);
		((Form)this).set_Text("示意图");
		((Form)this).set_TopMost(true);
		((ISupportInitialize)PictureBox1).EndInit();
		((Control)this).ResumeLayout(false);
	}

	private void Pic_FormClosed(object sender, FormClosedEventArgs e)
	{
		MyProject.Forms.cslr2.CBX1.set_Checked(false);
	}

	private void PictureBox1_Click(object sender, EventArgs e)
	{
		checked
		{
			try
			{
				if (ll_chkbmpfilter.get_Checked())
				{
					strcsymname = Strings.Trim(Conversions.ToString(MyProject.Forms.cslr2.lbcsx.get_Items().get_Item(MyProject.Forms.cslr2.lbcsx.get_SelectedIndex())));
					strcsname = Strings.UCase(Strings.Trim(MyProject.Forms.cslr2.csmc0));
					fname = Conversions.ToString(Operators.ConcatenateObject((object)string.Concat(string.Concat(string.Concat(strcsfpath + "\\cs", "\\bmp\\"), strcsymname), "\\"), lbtplb.get_Items().get_Item(lbtplb.get_SelectedIndex())));
					if (File.Exists(fname))
					{
						PictureBox1.set_ImageLocation(fname);
					}
					else
					{
						lblog.set_Text("不存在参数示意图文件!");
						((Control)lblog).set_ForeColor(Color.Red);
						((Control)lblog).Refresh();
					}
					if (lbtplb.get_Items().get_Count() != 0)
					{
						if (lbtplb.get_SelectedIndex() < lbtplb.get_Items().get_Count() - 1)
						{
							lbtplb.set_SelectedIndex(lbtplb.get_SelectedIndex() + 1);
							PictureBox1.set_ImageLocation(Application.get_StartupPath() + "\\Temp\\" + lbtplb.get_Text());
						}
						else
						{
							lbtplb.set_SelectedIndex(0);
						}
					}
					else
					{
						PictureBox1.set_ImageLocation(Application.get_StartupPath() + "\\config\\" + Mod1.bb + "\\ll521.bmp");
					}
				}
				else if (lbtplb.get_Items().get_Count() != 0)
				{
					if (lbtplb.get_SelectedIndex() < lbtplb.get_Items().get_Count() - 1)
					{
						lbtplb.set_SelectedIndex(lbtplb.get_SelectedIndex() + 1);
						PictureBox1.set_ImageLocation(Application.get_StartupPath() + "\\Temp\\" + lbtplb.get_Text());
					}
					else
					{
						lbtplb.set_SelectedIndex(0);
					}
				}
				else
				{
					PictureBox1.set_ImageLocation(Application.get_StartupPath() + "\\config\\" + Mod1.bb + "\\ll521.bmp");
				}
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
			}
		}
	}

	private void lbtplb_SelectedIndexChanged(object sender, EventArgs e)
	{
		try
		{
			if (ll_chkbmpfilter.get_Checked() & (((DataGridView)MyProject.Forms.cslr2.DGV).get_Rows().get_Count() != 0))
			{
				lblog.set_Text("");
				((Control)lblog).Refresh();
				strcsymname = Strings.Trim(Conversions.ToString(MyProject.Forms.cslr2.lbcsx.get_Items().get_Item(MyProject.Forms.cslr2.lbcsx.get_SelectedIndex())));
				strcsname = Strings.UCase(Strings.Trim(MyProject.Forms.cslr2.csmc0));
				fname = Conversions.ToString(Operators.ConcatenateObject((object)string.Concat(string.Concat(string.Concat(strcsfpath + "\\cs", "\\bmp\\"), strcsymname), "\\"), lbtplb.get_Items().get_Item(lbtplb.get_SelectedIndex())));
				if (File.Exists(fname))
				{
					PictureBox1.set_ImageLocation(fname);
					lblog.set_Text(fname);
					((Control)lblog).set_ForeColor(Color.Green);
					((Control)lblog).Refresh();
				}
				else if (Operators.CompareString(lbtplb.get_Text(), "", false) != 0)
				{
					lblog.set_Text("不存在参数示意图文件!");
					((Control)lblog).set_ForeColor(Color.Red);
					((Control)lblog).Refresh();
				}
			}
			else if (File.Exists(Application.get_StartupPath() + "\\Temp\\" + lbtplb.get_Text()))
			{
				PictureBox1.set_ImageLocation(Application.get_StartupPath() + "\\Temp\\" + lbtplb.get_Text());
				((Control)PictureBox1).Refresh();
				Mod1.t = lbtplb.get_SelectedIndex();
			}
			else
			{
				lblog.set_Text("不存在参数示意图文件!");
				((Control)lblog).set_ForeColor(Color.Red);
				((Control)lblog).Refresh();
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	private void btngb_Click(object sender, EventArgs e)
	{
		((Form)this).Close();
	}

	public void ll_chkbmpfilter_CheckedChanged(object sender, EventArgs e)
	{
		if (ll_chkbmpfilter.get_Checked())
		{
			strcsymname = Strings.Trim(Conversions.ToString(MyProject.Forms.cslr2.lbcsx.get_Items().get_Item(MyProject.Forms.cslr2.lbcsx.get_SelectedIndex())));
			strcsfpath = Mod1.path1;
			flisname = strcsfpath + "\\cs\\bmp\\" + strcsymname + "\\" + strcsymname + ".ini";
			if (!File.Exists(flisname))
			{
				lblog.set_Text("当前参数库中不存在合法的图片列表文件.该选项无效！");
				((Control)lblog).set_ForeColor(Color.Red);
				((Control)lblog).Refresh();
				@checked = true;
				ll_chkbmpfilter.set_Checked(false);
			}
			else
			{
				bmpadd_XN();
			}
		}
		else
		{
			MyProject.Forms.cslr2.Addpic();
		}
	}

	public void bmpadd_XN()
	{
		strcsymname = Strings.Trim(Conversions.ToString(MyProject.Forms.cslr2.lbcsx.get_Items().get_Item(MyProject.Forms.cslr2.lbcsx.get_SelectedIndex())));
		string text = Strings.UCase(Strings.Trim(MyProject.Forms.cslr2.csmc0));
		strcsfpath = Mod1.path1;
		flisname = strcsfpath + "\\cs\\bmp\\" + strcsymname + "\\" + strcsymname + ".ini";
		Mod1.lr = new StreamReader(flisname, Encoding.Default);
		lbtplb.get_Items().Clear();
		string text2 = strcsymname + "Picture ";
		Mod1.ff = "";
		while (!Information.IsNothing((object)Mod1.ff))
		{
			Mod1.ff = Mod1.lr.ReadLine();
			if (Information.IsNothing((object)Mod1.ff))
			{
				break;
			}
			string[] array = Strings.Split(Mod1.ff, ",", -1, (CompareMethod)0);
			int num = Information.UBound((Array)array, 1);
			if (num == 1)
			{
				int num2 = Strings.InStr(1, text, Strings.UCase(Strings.Trim(array[0])), (CompareMethod)0);
				if (num2 >= 1)
				{
					lbtplb.get_Items().Add((object)(text2 + array[1] + ".gif"));
				}
			}
			if (num != 2)
			{
				continue;
			}
			if (Operators.CompareString(Strings.Trim(array[2]), "", false) == 0)
			{
				array[2] = "0";
			}
			string text3 = Strings.Trim(array[2]);
			if (Operators.CompareString(text3, "0", false) == 0)
			{
				int num2 = Strings.InStr(1, text, Strings.UCase(Strings.Trim(array[0])), (CompareMethod)0);
				if (num2 >= 1)
				{
					lbtplb.get_Items().Add((object)(text2 + array[1] + ".gif"));
				}
			}
			else if (Operators.CompareString(text3, "1", false) == 0)
			{
				int num2 = Strings.InStr(1, text, Strings.UCase(Strings.Trim(array[0])), (CompareMethod)0);
				if (num2 == 1)
				{
					lbtplb.get_Items().Add((object)(text2 + array[1] + ".gif"));
				}
			}
			else
			{
				int num2 = Strings.InStrRev(text, Strings.UCase(Strings.Trim(array[0])), -1, (CompareMethod)0);
				if ((num2 >= 1) & (num2 == checked(Strings.Len(Strings.Trim(text)) - Strings.Len(Strings.Trim(array[0])) + 1)))
				{
					lbtplb.get_Items().Add((object)(text2 + array[1] + ".gif"));
				}
			}
		}
		Mod1.lr.Close();
		Mod1.lr.Dispose();
		if (lbtplb.get_Items().get_Count() == 0)
		{
			PictureBox1.set_ImageLocation(Application.get_StartupPath() + "\\config\\" + Mod1.bb + "\\ll521.bmp");
		}
		else
		{
			lbtplb.set_SelectedIndex(0);
		}
	}

	private void Pic_Load(object sender, EventArgs e)
	{
		if (lbtplb.get_Items().get_Count() == 0)
		{
			PictureBox1.set_ImageLocation(Application.get_StartupPath() + "\\config\\" + Mod1.bb + "\\ll521.bmp");
		}
	}
}
