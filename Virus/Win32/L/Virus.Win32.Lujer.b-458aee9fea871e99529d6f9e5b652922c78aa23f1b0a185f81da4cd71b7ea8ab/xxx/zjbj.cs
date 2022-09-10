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
using Microsoft.VisualBasic.Devices;
using xxx.My;

namespace xxx;

[DesignerGenerated]
public class zjbj : Office2007Form
{
	private IContainer components;

	[AccessedThroughProperty("btnpath")]
	private ButtonX _btnpath;

	[AccessedThroughProperty("txtpath")]
	private TextBoxX _txtpath;

	[AccessedThroughProperty("btncheckthis")]
	private ButtonX _btncheckthis;

	[AccessedThroughProperty("btnadd2cur")]
	private ButtonX _btnadd2cur;

	[AccessedThroughProperty("txtcheck")]
	private ListBox _txtcheck;

	[AccessedThroughProperty("gb")]
	private ButtonX _gb;

	private ArrayList Array;

	private string f;

	internal virtual ButtonX btnpath
	{
		[DebuggerNonUserCode]
		get
		{
			return _btnpath;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = btnpath_Click;
			if (_btnpath != null)
			{
				((Control)_btnpath).remove_Click(eventHandler);
			}
			_btnpath = value;
			if (_btnpath != null)
			{
				((Control)_btnpath).add_Click(eventHandler);
			}
		}
	}

	internal virtual TextBoxX txtpath
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtpath;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtpath = value;
		}
	}

	internal virtual ButtonX btncheckthis
	{
		[DebuggerNonUserCode]
		get
		{
			return _btncheckthis;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = btncheckthis_Click;
			if (_btncheckthis != null)
			{
				((Control)_btncheckthis).remove_Click(eventHandler);
			}
			_btncheckthis = value;
			if (_btncheckthis != null)
			{
				((Control)_btncheckthis).add_Click(eventHandler);
			}
		}
	}

	internal virtual ButtonX btnadd2cur
	{
		[DebuggerNonUserCode]
		get
		{
			return _btnadd2cur;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = btnadd2cur_Click;
			if (_btnadd2cur != null)
			{
				((Control)_btnadd2cur).remove_Click(eventHandler);
			}
			_btnadd2cur = value;
			if (_btnadd2cur != null)
			{
				((Control)_btnadd2cur).add_Click(eventHandler);
			}
		}
	}

	public virtual ListBox txtcheck
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtcheck;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtcheck = value;
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

	public zjbj()
	{
		Array = new ArrayList();
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
		//IL_037b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0385: Expected O, but got Unknown
		//IL_0415: Unknown result type (might be due to invalid IL or missing references)
		//IL_041f: Expected O, but got Unknown
		btnpath = new ButtonX();
		txtpath = new TextBoxX();
		btncheckthis = new ButtonX();
		btnadd2cur = new ButtonX();
		txtcheck = new ListBox();
		gb = new ButtonX();
		((Control)this).SuspendLayout();
		((Control)btnpath).set_AccessibleRole((AccessibleRole)43);
		btnpath.set_ColorTable((eButtonColor)3);
		ButtonX obj = btnpath;
		Point location = new Point(6, 6);
		((Control)obj).set_Location(location);
		((Control)btnpath).set_Name("btnpath");
		ButtonX obj2 = btnpath;
		Size size = new Size(174, 27);
		((Control)obj2).set_Size(size);
		((PopupItemControl)btnpath).set_Style((eDotNetBarStyle)7);
		((Control)btnpath).set_TabIndex(0);
		btnpath.set_Text("选择要追加部件路径...");
		txtpath.get_Border().set_Class("TextBoxBorder");
		txtpath.get_Border().set_CornerType((eCornerType)1);
		((Control)txtpath).set_Enabled(false);
		TextBoxX obj3 = txtpath;
		location = new Point(6, 39);
		((Control)obj3).set_Location(location);
		((Control)txtpath).set_Name("txtpath");
		TextBoxX obj4 = txtpath;
		size = new Size(555, 21);
		((Control)obj4).set_Size(size);
		((Control)txtpath).set_TabIndex(1);
		((Control)btncheckthis).set_AccessibleRole((AccessibleRole)43);
		btncheckthis.set_ColorTable((eButtonColor)3);
		((Control)btncheckthis).set_Enabled(false);
		ButtonX obj5 = btncheckthis;
		location = new Point(6, 66);
		((Control)obj5).set_Location(location);
		((Control)btncheckthis).set_Name("btncheckthis");
		ButtonX obj6 = btncheckthis;
		size = new Size(174, 27);
		((Control)obj6).set_Size(size);
		((PopupItemControl)btncheckthis).set_Style((eDotNetBarStyle)7);
		((Control)btncheckthis).set_TabIndex(0);
		btncheckthis.set_Text("检查选定部件文件夹的合理性");
		((Control)btnadd2cur).set_AccessibleRole((AccessibleRole)43);
		btnadd2cur.set_ColorTable((eButtonColor)3);
		((Control)btnadd2cur).set_Enabled(false);
		ButtonX obj7 = btnadd2cur;
		location = new Point(242, 66);
		((Control)obj7).set_Location(location);
		((Control)btnadd2cur).set_Name("btnadd2cur");
		ButtonX obj8 = btnadd2cur;
		size = new Size(136, 27);
		((Control)obj8).set_Size(size);
		((PopupItemControl)btnadd2cur).set_Style((eDotNetBarStyle)7);
		((Control)btnadd2cur).set_TabIndex(0);
		btnadd2cur.set_Text("追加该部件至当前库");
		((ListControl)txtcheck).set_FormattingEnabled(true);
		txtcheck.set_ItemHeight(12);
		ListBox obj9 = txtcheck;
		location = new Point(6, 99);
		((Control)obj9).set_Location(location);
		((Control)txtcheck).set_Name("txtcheck");
		ListBox obj10 = txtcheck;
		size = new Size(555, 280);
		((Control)obj10).set_Size(size);
		((Control)txtcheck).set_TabIndex(2);
		((Control)gb).set_AccessibleRole((AccessibleRole)43);
		gb.set_ColorTable((eButtonColor)3);
		ButtonX obj11 = gb;
		location = new Point(448, 66);
		((Control)obj11).set_Location(location);
		((Control)gb).set_Name("gb");
		ButtonX obj12 = gb;
		size = new Size(113, 27);
		((Control)obj12).set_Size(size);
		((PopupItemControl)gb).set_Style((eDotNetBarStyle)7);
		((Control)gb).set_TabIndex(9);
		gb.set_Text("关闭");
		((Form)this).set_AcceptButton((IButtonControl)(object)btnpath);
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)0);
		((Form)this).set_AutoSizeMode((AutoSizeMode)0);
		((Office2007Form)this).set_CaptionFont(new Font("宋体", 9f, (FontStyle)0, (GraphicsUnit)3, (byte)134));
		size = new Size(568, 385);
		((Form)this).set_ClientSize(size);
		((Control)this).get_Controls().Add((Control)(object)txtcheck);
		((Control)this).get_Controls().Add((Control)(object)txtpath);
		((Control)this).get_Controls().Add((Control)(object)btnadd2cur);
		((Control)this).get_Controls().Add((Control)(object)btncheckthis);
		((Control)this).get_Controls().Add((Control)(object)gb);
		((Control)this).get_Controls().Add((Control)(object)btnpath);
		((Control)this).set_Font(new Font("宋体", 9f, (FontStyle)0, (GraphicsUnit)3, (byte)134));
		((Form)this).set_FormBorderStyle((FormBorderStyle)1);
		((Form)this).set_MaximizeBox(false);
		((Form)this).set_MinimizeBox(false);
		((Control)this).set_Name("zjbj");
		((Form)this).set_ShowIcon(false);
		((Form)this).set_ShowInTaskbar(false);
		((Form)this).set_StartPosition((FormStartPosition)1);
		((Form)this).set_Text("追加部件至当前库");
		((Control)this).ResumeLayout(false);
	}

	private void btnpath_Click(object sender, EventArgs e)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		FolderBrowserDialog val = new FolderBrowserDialog();
		val.set_Description("选择部件文件夹");
		((CommonDialog)val).ShowDialog();
		((TextBox)txtpath).set_Text(val.get_SelectedPath());
		if (Operators.CompareString(((TextBox)txtpath).get_Text(), "", false) != 0)
		{
			((Control)btncheckthis).set_Enabled(true);
		}
		else
		{
			((Control)btncheckthis).set_Enabled(false);
		}
	}

	private void gb_Click(object sender, EventArgs e)
	{
		checked
		{
			if (txtcheck.get_Items().get_Count() != 0)
			{
				int num = txtcheck.get_Items().get_Count() - 1;
				for (int i = 0; i <= num; i++)
				{
					MyProject.Forms.mxkgl.log.get_Items().Add(RuntimeHelpers.GetObjectValue(txtcheck.get_Items().get_Item(i)));
				}
			}
			MyProject.Forms.mxkgl.log.get_Items().Add((object)(Conversions.ToString(DateTime.Now) + " 操作员关闭部件追加对话框"));
			((Form)this).Close();
		}
	}

	private void btncheckthis_Click(object sender, EventArgs e)
	{
		((Control)btncheckthis).set_Enabled(false);
		string path = ((TextBox)txtpath).get_Text();
		if (Operators.CompareString(Strings.Trim(path), "", false) != 0)
		{
			if (Operators.CompareString(Strings.Right(path, 1), "\\", false) != 0)
			{
				path += "\\";
			}
			checkreport(ref path);
			if (!Mod1.bcheckreport)
			{
				((Control)btnadd2cur).set_Enabled(false);
				((Control)btncheckthis).set_Enabled(true);
				txtcheck.get_Items().Add((object)(Conversions.ToString(DateTime.Now) + " " + path + " 没有通过验证！！"));
			}
			else
			{
				((Control)btnadd2cur).set_Enabled(true);
				((Control)btncheckthis).set_Enabled(false);
				txtcheck.get_Items().Add((object)(Conversions.ToString(DateTime.Now) + " " + path + " 选择的部件文件夹已通过验证。"));
			}
			txtcheck.set_SelectedIndex(checked(txtcheck.get_Items().get_Count() - 1));
		}
	}

	public void checkreport(ref string path)
	{
		//IL_0235: Unknown result type (might be due to invalid IL or missing references)
		Mod1.bcheckreport = false;
		try
		{
			string[] files = Directory.GetFiles(path, "*.lis", SearchOption.TopDirectoryOnly);
			if (files.Length == 0)
			{
				txtcheck.get_Items().Add((object)(Conversions.ToString(DateTime.Now) + " 在目标路径中没有找到.lis文件！！"));
				Mod1.bcheckreport = false;
			}
			else
			{
				Mod1.bcheckreport = true;
				string text = Directory.GetParent(files[0])!.ToString();
				text = text.Substring(checked(text.LastIndexOf("\\") + 1));
				if (File.Exists(path + text + ".lis"))
				{
					Mod1.bcheckreport = true;
					Mod1.lr = new StreamReader(path + text + ".lis", Encoding.Default);
					f = "";
					while (!Information.IsNothing((object)f))
					{
						f = Mod1.lr.ReadLine();
						if (Information.IsNothing((object)f))
						{
							break;
						}
						string text2 = f;
						if ((Operators.CompareString(f, "参数化模型", false) != 0) & (Operators.CompareString(f, "实例模型", false) != 0))
						{
							txtcheck.get_Items().Add((object)(Conversions.ToString(DateTime.Now) + " 请选择部件的跟目录或指定的部件文件夹不匹配！！"));
							Mod1.bcheckreport = false;
							continue;
						}
						Mod1.bcheckreport = true;
						Array.Add(path + Mod1.toen(ref text2));
						if (!Directory.Exists(path + Mod1.toen(ref text2)))
						{
							txtcheck.get_Items().Add((object)(Conversions.ToString(DateTime.Now) + " 在目标路径中没有找到 " + Mod1.toen(ref text2) + " 文件夹"));
							Mod1.bcheckreport = false;
						}
						else
						{
							Mod1.bcheckreport = true;
						}
					}
					Mod1.lr.Close();
					Mod1.lr.Dispose();
					checkreport1(ref Array);
				}
				else
				{
					txtcheck.get_Items().Add((object)(Conversions.ToString(DateTime.Now) + " 没有找到对应该文件夹的 .list 文件！！"));
					Mod1.bcheckreport = false;
				}
			}
			Array.Clear();
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			Interaction.MsgBox((object)ex2.Message, (MsgBoxStyle)64, (object)"提示");
			ProjectData.ClearProjectError();
		}
	}

	public void checkreport1(ref ArrayList path)
	{
		checked
		{
			int num = path.Count - 1;
			int num2 = 0;
			while (true)
			{
				if (num2 > num)
				{
					return;
				}
				if (Operators.CompareString(Strings.Right(Conversions.ToString(path[num2]), 1), "\\", false) != 0)
				{
					path[num2] = Operators.ConcatenateObject(path[num2], (object)"\\");
				}
				string[] files = Directory.GetFiles(Conversions.ToString(path[num2]), "*.lis", SearchOption.TopDirectoryOnly);
				if (files.Length == 0)
				{
					break;
				}
				Mod1.bcheckreport = true;
				string text = Directory.GetParent(files[0])!.ToString();
				string text2 = text.Substring(text.LastIndexOf("\\") + 1);
				if (Operators.CompareString(Strings.Right(text, 1), "\\", false) != 0)
				{
					text += "\\";
				}
				if (File.Exists(text + text2 + ".lis"))
				{
					Mod1.bcheckreport = true;
					Mod1.lr = new StreamReader(text + text2 + ".lis", Encoding.Default);
					f = "";
					while (!Information.IsNothing((object)f))
					{
						f = Mod1.lr.ReadLine();
						if (Information.IsNothing((object)f))
						{
							break;
						}
						if (!Directory.Exists(text + Mod1.toen(ref f)))
						{
							txtcheck.get_Items().Add((object)(Conversions.ToString(DateTime.Now) + " 在目标路径中没有找到 " + text + Mod1.toen(ref f) + " 文件夹"));
							Mod1.bcheckreport = false;
						}
						else
						{
							Mod1.bcheckreport = true;
						}
					}
					Mod1.lr.Close();
					Mod1.lr.Dispose();
				}
				num2++;
			}
			txtcheck.get_Items().Add((object)(Conversions.ToString(DateTime.Now) + " 没有找到对应的.lis文件！！"));
			Mod1.bcheckreport = false;
		}
	}

	private void btnadd2cur_Click(object sender, EventArgs e)
	{
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Invalid comparison between Unknown and I4
		//IL_00ef: Unknown result type (might be due to invalid IL or missing references)
		string text = ((TextBox)txtpath).get_Text();
		text = text.Substring(checked(text.LastIndexOf("\\") + 1));
		if (Directory.Exists(Mod1.Kulujing + text))
		{
			if ((int)MessageBox.Show("当前部件已经存在，是否覆盖？", "重要提示", (MessageBoxButtons)4, (MessageBoxIcon)64) == 6)
			{
				((ServerComputer)MyProject.Computer).get_FileSystem().CopyDirectory(((TextBox)txtpath).get_Text(), Mod1.Kulujing + text, true);
				txtcheck.get_Items().Add((object)(Conversions.ToString(DateTime.Now) + " 覆盖已有部件成功！！"));
				((Control)btnadd2cur).set_Enabled(false);
			}
		}
		else
		{
			((ServerComputer)MyProject.Computer).get_FileSystem().CopyDirectory(((TextBox)txtpath).get_Text(), Mod1.Kulujing + text, true);
			((Control)btnadd2cur).set_Enabled(false);
			MyProject.Forms.Updtmlibs.n = text;
			((Form)MyProject.Forms.Updtmlibs).ShowDialog();
		}
	}
}
