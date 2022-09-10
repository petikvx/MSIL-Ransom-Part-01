using System;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
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
public class CreateINI : Office2007Form
{
	private IContainer components;

	[AccessedThroughProperty("txtpath1")]
	private TextBoxX _txtpath1;

	[AccessedThroughProperty("BtnSelectPath")]
	private ButtonX _BtnSelectPath;

	[AccessedThroughProperty("lblog")]
	private ListBox _lblog;

	[AccessedThroughProperty("btnOK")]
	private ButtonX _btnOK;

	[AccessedThroughProperty("btnExit")]
	private ButtonX _btnExit;

	[AccessedThroughProperty("LabelX1")]
	private LabelX _LabelX1;

	[AccessedThroughProperty("LabelX2")]
	private LabelX _LabelX2;

	[AccessedThroughProperty("lbdir")]
	private ListBox _lbdir;

	[AccessedThroughProperty("LabelX3")]
	private LabelX _LabelX3;

	private int jishu;

	private bool Banshen;

	private bool Quanshen;

	private bool gangdu;

	private bool qiangdu;

	private bool CQGSS;

	private bool bfg;

	public StreamWriter wr;

	public bool Chbzbyx;

	public ArrayList zbcd;

	public ArrayList fbcd;

	public ArrayList pz;

	public ArrayList jd;

	internal virtual TextBoxX txtpath1
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtpath1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtpath1 = value;
		}
	}

	internal virtual ButtonX BtnSelectPath
	{
		[DebuggerNonUserCode]
		get
		{
			return _BtnSelectPath;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = BtnSelectPath_Click;
			if (_BtnSelectPath != null)
			{
				((Control)_BtnSelectPath).remove_Click(eventHandler);
			}
			_BtnSelectPath = value;
			if (_BtnSelectPath != null)
			{
				((Control)_BtnSelectPath).add_Click(eventHandler);
			}
		}
	}

	internal virtual ListBox lblog
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

	internal virtual ButtonX btnOK
	{
		[DebuggerNonUserCode]
		get
		{
			return _btnOK;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = btnOK_Click;
			if (_btnOK != null)
			{
				((Control)_btnOK).remove_Click(eventHandler);
			}
			_btnOK = value;
			if (_btnOK != null)
			{
				((Control)_btnOK).add_Click(eventHandler);
			}
		}
	}

	internal virtual ButtonX btnExit
	{
		[DebuggerNonUserCode]
		get
		{
			return _btnExit;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = btnExit_Click;
			if (_btnExit != null)
			{
				((Control)_btnExit).remove_Click(eventHandler);
			}
			_btnExit = value;
			if (_btnExit != null)
			{
				((Control)_btnExit).add_Click(eventHandler);
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

	internal virtual ListBox lbdir
	{
		[DebuggerNonUserCode]
		get
		{
			return _lbdir;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = lbdir_SelectedIndexChanged;
			if (_lbdir != null)
			{
				_lbdir.remove_SelectedIndexChanged(eventHandler);
			}
			_lbdir = value;
			if (_lbdir != null)
			{
				_lbdir.add_SelectedIndexChanged(eventHandler);
			}
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

	[DebuggerNonUserCode]
	public CreateINI()
	{
		((Form)this).add_Load((EventHandler)CreateINI_Load);
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
		//IL_0517: Unknown result type (might be due to invalid IL or missing references)
		//IL_0521: Expected O, but got Unknown
		//IL_05e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_05ee: Expected O, but got Unknown
		txtpath1 = new TextBoxX();
		BtnSelectPath = new ButtonX();
		lblog = new ListBox();
		btnOK = new ButtonX();
		btnExit = new ButtonX();
		LabelX1 = new LabelX();
		LabelX2 = new LabelX();
		lbdir = new ListBox();
		LabelX3 = new LabelX();
		((Control)this).SuspendLayout();
		txtpath1.get_Border().set_Class("TextBoxBorder");
		txtpath1.get_Border().set_CornerType((eCornerType)1);
		TextBoxX obj = txtpath1;
		Point location = new Point(6, 21);
		((Control)obj).set_Location(location);
		((Control)txtpath1).set_Name("txtpath1");
		((TextBoxBase)txtpath1).set_ReadOnly(true);
		TextBoxX obj2 = txtpath1;
		Size size = new Size(727, 21);
		((Control)obj2).set_Size(size);
		((Control)txtpath1).set_TabIndex(0);
		((Control)BtnSelectPath).set_AccessibleRole((AccessibleRole)43);
		BtnSelectPath.set_ColorTable((eButtonColor)3);
		ButtonX btnSelectPath = BtnSelectPath;
		location = new Point(739, 21);
		((Control)btnSelectPath).set_Location(location);
		((Control)BtnSelectPath).set_Name("BtnSelectPath");
		ButtonX btnSelectPath2 = BtnSelectPath;
		size = new Size(85, 23);
		((Control)btnSelectPath2).set_Size(size);
		((PopupItemControl)BtnSelectPath).set_Style((eDotNetBarStyle)7);
		((Control)BtnSelectPath).set_TabIndex(1);
		BtnSelectPath.set_Text("选择路径");
		((ListControl)lblog).set_FormattingEnabled(true);
		lblog.set_ItemHeight(12);
		ListBox obj3 = lblog;
		location = new Point(148, 72);
		((Control)obj3).set_Location(location);
		((Control)lblog).set_Name("lblog");
		ListBox obj4 = lblog;
		size = new Size(585, 268);
		((Control)obj4).set_Size(size);
		((Control)lblog).set_TabIndex(2);
		((Control)btnOK).set_AccessibleRole((AccessibleRole)43);
		btnOK.set_ColorTable((eButtonColor)3);
		((Control)btnOK).set_Enabled(false);
		ButtonX obj5 = btnOK;
		location = new Point(739, 72);
		((Control)obj5).set_Location(location);
		((Control)btnOK).set_Name("btnOK");
		ButtonX obj6 = btnOK;
		size = new Size(85, 23);
		((Control)obj6).set_Size(size);
		((PopupItemControl)btnOK).set_Style((eDotNetBarStyle)7);
		((Control)btnOK).set_TabIndex(3);
		btnOK.set_Text("生成ini");
		((Control)btnExit).set_AccessibleRole((AccessibleRole)43);
		btnExit.set_ColorTable((eButtonColor)3);
		btnExit.set_DialogResult((DialogResult)2);
		ButtonX obj7 = btnExit;
		location = new Point(739, 101);
		((Control)obj7).set_Location(location);
		((Control)btnExit).set_Name("btnExit");
		ButtonX obj8 = btnExit;
		size = new Size(85, 23);
		((Control)obj8).set_Size(size);
		((PopupItemControl)btnExit).set_Style((eDotNetBarStyle)7);
		((Control)btnExit).set_TabIndex(3);
		btnExit.set_Text("关闭");
		((BaseItemControl)LabelX1).get_BackgroundStyle().set_Class("");
		((BaseItemControl)LabelX1).get_BackgroundStyle().set_CornerType((eCornerType)1);
		LabelX labelX = LabelX1;
		location = new Point(148, 48);
		((Control)labelX).set_Location(location);
		((Control)LabelX1).set_Name("LabelX1");
		LabelX labelX2 = LabelX1;
		size = new Size(75, 18);
		((Control)labelX2).set_Size(size);
		((Control)LabelX1).set_TabIndex(4);
		LabelX1.set_Text("记录");
		((BaseItemControl)LabelX2).get_BackgroundStyle().set_Class("");
		((BaseItemControl)LabelX2).get_BackgroundStyle().set_CornerType((eCornerType)1);
		LabelX labelX3 = LabelX2;
		location = new Point(6, 1);
		((Control)labelX3).set_Location(location);
		((Control)LabelX2).set_Name("LabelX2");
		LabelX labelX4 = LabelX2;
		size = new Size(75, 18);
		((Control)labelX4).set_Size(size);
		((Control)LabelX2).set_TabIndex(4);
		LabelX2.set_Text("路径：");
		((ListControl)lbdir).set_FormattingEnabled(true);
		lbdir.set_ItemHeight(12);
		ListBox obj9 = lbdir;
		location = new Point(6, 72);
		((Control)obj9).set_Location(location);
		((Control)lbdir).set_Name("lbdir");
		ListBox obj10 = lbdir;
		size = new Size(136, 268);
		((Control)obj10).set_Size(size);
		((Control)lbdir).set_TabIndex(2);
		((BaseItemControl)LabelX3).get_BackgroundStyle().set_Class("");
		((BaseItemControl)LabelX3).get_BackgroundStyle().set_CornerType((eCornerType)1);
		LabelX labelX5 = LabelX3;
		location = new Point(6, 48);
		((Control)labelX5).set_Location(location);
		((Control)LabelX3).set_Name("LabelX3");
		LabelX labelX6 = LabelX3;
		size = new Size(114, 18);
		((Control)labelX6).set_Size(size);
		((Control)LabelX3).set_TabIndex(4);
		LabelX3.set_Text("当前存在结构");
		SizeF autoScaleDimensions = new SizeF(6f, 12f);
		((ContainerControl)this).set_AutoScaleDimensions(autoScaleDimensions);
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_CancelButton((IButtonControl)(object)btnExit);
		((Office2007Form)this).set_CaptionFont(new Font("宋体", 9f, (FontStyle)0, (GraphicsUnit)3, (byte)134));
		size = new Size(836, 348);
		((Form)this).set_ClientSize(size);
		((Control)this).get_Controls().Add((Control)(object)LabelX2);
		((Control)this).get_Controls().Add((Control)(object)LabelX3);
		((Control)this).get_Controls().Add((Control)(object)LabelX1);
		((Control)this).get_Controls().Add((Control)(object)btnExit);
		((Control)this).get_Controls().Add((Control)(object)btnOK);
		((Control)this).get_Controls().Add((Control)(object)lbdir);
		((Control)this).get_Controls().Add((Control)(object)lblog);
		((Control)this).get_Controls().Add((Control)(object)BtnSelectPath);
		((Control)this).get_Controls().Add((Control)(object)txtpath1);
		((Control)this).set_Font(new Font("宋体", 9f, (FontStyle)0, (GraphicsUnit)3, (byte)134));
		((Form)this).set_FormBorderStyle((FormBorderStyle)1);
		((Form)this).set_MaximizeBox(false);
		((Form)this).set_MinimizeBox(false);
		((Control)this).set_Name("CreateINI");
		((Form)this).set_ShowIcon(false);
		((Form)this).set_ShowInTaskbar(false);
		((Form)this).set_StartPosition((FormStartPosition)1);
		((Form)this).set_Text("生成索引文件");
		((Control)this).ResumeLayout(false);
	}

	private void CreateINI_Load(object sender, EventArgs e)
	{
		zbcd = new ArrayList();
		fbcd = new ArrayList();
		pz = new ArrayList();
		jd = new ArrayList();
	}

	public void sczhubi(string pp)
	{
		ArrayList arrayList = new ArrayList();
		string[] files = Directory.GetFiles(pp, "*.xls", SearchOption.TopDirectoryOnly);
		checked
		{
			if (files.Count() != 0)
			{
				int num = files.Count() - 1;
				for (int i = 0; i <= num; i++)
				{
					string text = files[i].Substring(files[i].LastIndexOf("\\") + 1);
					switch (text)
					{
					case "半伸_倾翻.xls":
					case "半伸_支腿.xls":
					case "回转支承.xls":
					case "全伸_倾翻.xls":
					case "全伸_支腿.xls":
						lblog.get_Items().Add((object)(Conversions.ToString(i + 1) + "/" + Conversions.ToString(files.Count()) + " " + files[i]));
						lblog.Refresh();
						lblog.set_SelectedIndex(lblog.get_Items().get_Count() - 1);
						zbini(files[i], text, arrayList);
						break;
					}
				}
				xiezbini(arrayList, pp);
			}
			else
			{
				lblog.get_Items().Add((object)"xls 文件没有找到");
			}
		}
	}

	public void zbini(string path, string filename, ArrayList zbpz)
	{
		Mod1.wb = Mod1.excelapp.Workbooks.Open(path, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value);
		switch (filename.ToLower())
		{
		case "半伸_支腿.xls":
		case "半伸_倾翻.xls":
			Banshen = true;
			break;
		case "全伸_支腿.xls":
		case "全伸_倾翻.xls":
			Quanshen = true;
			break;
		}
		checked
		{
			int num = Mod1.wb.Worksheets.Count - 1;
			for (int i = 0; i <= num; i++)
			{
				Mod1.excelsheet = (Worksheet)Mod1.wb.Worksheets[i + 1];
				if (!((Operators.CompareString(Mod1.excelsheet.Name, "ALL", false) != 0) & (Operators.CompareString(Mod1.excelsheet.Name, "ALLTEMP", false) != 0)))
				{
					continue;
				}
				if (zbpz.Count != 0)
				{
					if (chongfu(Conversions.ToDouble(Mod1.excelsheet.Name), zbpz))
					{
						zbpz.Add(Mod1.excelsheet.Name);
					}
				}
				else
				{
					zbpz.Add(Mod1.excelsheet.Name);
				}
			}
			Mod1.wb.Close(Missing.Value, Missing.Value, Missing.Value);
		}
	}

	public void xiezbini(ArrayList array, string p)
	{
		checked
		{
			string text = p.Substring(p.LastIndexOf("\\") + 1);
			wr = new StreamWriter(p + "\\" + text + ".ini", append: false, Encoding.Default);
			int num = array.Count - 1;
			string text2 = default(string);
			for (int i = 0; i <= num; i++)
			{
				text2 = ((Operators.CompareString(text2, "", false) != 0) ? Conversions.ToString(Operators.ConcatenateObject((object)(text2 + ","), array[i])) : Conversions.ToString(array[i]));
			}
			wr.WriteLine("配重_" + text2 + ",ALL");
			string text3 = "";
			if (Quanshen)
			{
				text3 = "全伸";
				if (Banshen)
				{
					text3 += ",半伸";
				}
			}
			else if (Banshen)
			{
				text3 = "半伸";
			}
			text3 = ((Operators.CompareString(text3, "", false) != 0) ? ("支腿跨距_" + text3 + ",ALL") : "支腿跨距_ALL");
			wr.WriteLine(text3);
			wr.Close();
			wr.Dispose();
		}
	}

	public void zhubijguding(string pp)
	{
		string[] directories = Directory.GetDirectories(pp);
		checked
		{
			if (directories.Count() != 0)
			{
				int num = directories.Count() - 1;
				for (int i = 0; i <= num; i++)
				{
					string text = directories[i].Substring(directories[i].LastIndexOf("\\") + 1);
					if (chongfu(Conversions.ToDouble(text), jd))
					{
						jd.Add(text);
					}
					string[] files = Directory.GetFiles(directories[i], "*.xls", SearchOption.TopDirectoryOnly);
					int num2 = files.Count() - 1;
					for (int j = 0; j <= num2; j++)
					{
						string text2 = files[j].Substring(files[j].LastIndexOf("\\") + 1);
						gangdu = false;
						bfg = false;
						qiangdu = false;
						CQGSS = false;
						switch (text2)
						{
						case "全伸_支腿.xls":
						case "全伸_倾翻.xls":
						case "半伸_支腿.xls":
						case "半伸_倾翻.xls":
						case "强度.xls":
						case "变幅缸.xls":
						case "刚度.xls":
						case "超起钢丝绳.xls":
						case "回转支承.xls":
							lblog.get_Items().Add((object)(Conversions.ToString(j + 1) + "/" + Conversions.ToString(files.Count()) + " " + files[j]));
							lblog.Refresh();
							lblog.set_SelectedIndex(lblog.get_Items().get_Count() - 1);
							xls(files[j], zbcd, fbcd, pz, jd, text2);
							break;
						}
					}
					lblog.get_Items().Add((object)"");
					lblog.set_SelectedIndex(lblog.get_Items().get_Count() - 1);
				}
			}
			else
			{
				lblog.get_Items().Add((object)"没有找到角度(仰角)文件夹!");
			}
		}
	}

	public void xls(string xlspath, ArrayList zbcd, ArrayList fbcd, ArrayList pz, ArrayList jd, string fname)
	{
		jishu = 0;
		switch (fname.ToLower())
		{
		case "强度.xls":
			qiangdu = true;
			break;
		case "变幅缸.xls":
			bfg = true;
			break;
		case "刚度.xls":
			gangdu = true;
			break;
		case "超起钢丝绳.xls":
			CQGSS = true;
			break;
		case "半伸_支腿.xls":
		case "半伸_倾翻.xls":
			Banshen = true;
			break;
		case "全伸_支腿.xls":
		case "全伸_倾翻.xls":
			Quanshen = true;
			break;
		}
		Mod1.wb = Mod1.excelapp.Workbooks.Open(xlspath, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value);
		checked
		{
			int num = Mod1.wb.Worksheets.Count - 1;
			for (int i = 0; i <= num; i++)
			{
				Mod1.excelsheet = (Worksheet)Mod1.wb.Worksheets[i + 1];
				if (!((Operators.CompareString(Mod1.excelsheet.Name, "ALL", false) != 0) & (Operators.CompareString(Mod1.excelsheet.Name, "ALLTEMP", false) != 0)) || Mod1.excelsheet.Name.IndexOf("_") == -1)
				{
					continue;
				}
				string[] array = Mod1.excelsheet.Name.Split(new char[1] { '_' });
				Excel.Range range = (Excel.Range)Mod1.excelsheet.Cells[1, Mod1.excelsheet.Cells.Columns.Count];
				int column = range.get_End(XlDirection.xlToLeft).Column;
				int num2 = column;
				for (int j = 2; j <= num2; j++)
				{
					if (!Chbzbyx)
					{
						if (((zbcd.Count != 0) & (fbcd.Count != 0)) | (pz.Count != 0))
						{
							if (chongfu(Conversions.ToDouble(NewLateBinding.LateGet(Mod1.excelsheet.Cells[1, j], (Type)null, "Value", new object[0], (string[])null, (Type[])null, (bool[])null)), zbcd))
							{
								zbcd.Add(RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(Mod1.excelsheet.Cells[1, j], (Type)null, "Value", new object[0], (string[])null, (Type[])null, (bool[])null)));
							}
							if (chongfu(Conversions.ToDouble(array[1]), fbcd))
							{
								fbcd.Add(array[1]);
							}
							if ((!gangdu & !bfg & !gangdu & !qiangdu & !CQGSS) && chongfu(Conversions.ToDouble(array[0]), pz))
							{
								pz.Add(array[0]);
							}
						}
						else
						{
							zbcd.Add(RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(Mod1.excelsheet.Cells[1, j], (Type)null, "Value", new object[0], (string[])null, (Type[])null, (bool[])null)));
							fbcd.Add(array[1]);
							if (!gangdu & !bfg & !gangdu & !qiangdu & !CQGSS)
							{
								pz.Add(array[0]);
							}
						}
					}
					else if ((zbcd.Count != 0) & (fbcd.Count != 0) & (pz.Count != 0))
					{
						if (chongfu(Conversions.ToDouble(NewLateBinding.LateGet(Mod1.excelsheet.Cells[1, j], (Type)null, "Value", new object[0], (string[])null, (Type[])null, (bool[])null)), fbcd))
						{
							fbcd.Add(RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(Mod1.excelsheet.Cells[1, j], (Type)null, "Value", new object[0], (string[])null, (Type[])null, (bool[])null)));
						}
						if (chongfu(Conversions.ToDouble(array[1]), zbcd))
						{
							zbcd.Add(array[1]);
						}
						if ((!gangdu & !bfg & !gangdu & !qiangdu & !CQGSS) && chongfu(Conversions.ToDouble(array[0]), pz))
						{
							pz.Add(array[0]);
						}
					}
					else
					{
						zbcd.Add(array[1]);
						fbcd.Add(RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(Mod1.excelsheet.Cells[1, j], (Type)null, "Value", new object[0], (string[])null, (Type[])null, (bool[])null)));
						if (!gangdu & !bfg & !gangdu & !qiangdu & !CQGSS)
						{
							pz.Add(array[0]);
						}
					}
				}
			}
			Mod1.wb.Close(Missing.Value, Missing.Value, Missing.Value);
		}
	}

	public void zbjfbini(ref string p)
	{
		string text = p;
		checked
		{
			string text2 = text.Substring(text.LastIndexOf("\\") + 1);
			wr = new StreamWriter(text + "\\" + text2 + ".ini", append: false, Encoding.Default);
			text2 = "";
			int num = jd.Count - 1;
			for (int i = 0; i <= num; i++)
			{
				text2 = ((Operators.CompareString(text2, "", false) != 0) ? Conversions.ToString(Operators.ConcatenateObject((object)(text2 + ","), jd[i])) : Conversions.ToString(jd[i]));
			}
			string text3 = lbdir.get_Text();
			if (Operators.CompareString(text3, "主臂+塔式副臂", false) != 0 && Operators.CompareString(text3, "主臂+塔式副臂+超起", false) != 0)
			{
				wr.WriteLine("副臂主臂安装角列表_" + text2 + ",ALL");
			}
			else
			{
				wr.WriteLine("副臂主臂仰角列表_" + text2 + ",ALL");
			}
			text2 = "";
			int num2 = zbcd.Count - 1;
			for (int j = 0; j <= num2; j++)
			{
				text2 = ((Operators.CompareString(text2, "", false) != 0) ? Conversions.ToString(Operators.ConcatenateObject((object)(text2 + ","), zbcd[j])) : Conversions.ToString(zbcd[j]));
			}
			wr.WriteLine("副臂主臂长度列表_" + text2 + ",ALL");
			text2 = "";
			int num3 = fbcd.Count - 1;
			for (int k = 0; k <= num3; k++)
			{
				text2 = ((Operators.CompareString(text2, "", false) != 0) ? Conversions.ToString(Operators.ConcatenateObject((object)(text2 + ","), fbcd[k])) : Conversions.ToString(fbcd[k]));
			}
			wr.WriteLine("副臂副臂长度列表_" + text2 + ",ALL");
			text2 = "";
			int num4 = pz.Count - 1;
			for (int l = 0; l <= num4; l++)
			{
				text2 = ((Operators.CompareString(text2, "", false) != 0) ? Conversions.ToString(Operators.ConcatenateObject((object)(text2 + ","), pz[l])) : Conversions.ToString(pz[l]));
			}
			wr.WriteLine("配重_" + text2 + ",ALL");
			string text4 = "";
			if (Quanshen)
			{
				text4 = "全伸";
				if (Banshen)
				{
					text4 += ",半伸";
				}
			}
			else if (Banshen)
			{
				text4 = "半伸";
			}
			text4 = ((Operators.CompareString(text4, "", false) != 0) ? ("支腿跨距_" + text4 + ",ALL") : "支腿跨距_ALL");
			wr.WriteLine(text4);
			wr.Close();
			wr.Dispose();
		}
	}

	public bool chongfu(double zhi, ArrayList array)
	{
		bool result = false;
		jishu = 0;
		checked
		{
			int num = array.Count - 1;
			for (int i = 0; i <= num; i++)
			{
				if (Operators.ConditionalCompareObjectEqual(array[i], (object)zhi, false))
				{
					jishu++;
					break;
				}
			}
			if (jishu == 0)
			{
				result = true;
			}
			return result;
		}
	}

	private void btnOK_Click(object sender, EventArgs e)
	{
		//IL_00e9: Unknown result type (might be due to invalid IL or missing references)
		if (!((Operators.CompareString(Strings.Trim(((TextBox)txtpath1).get_Text()), "", false) != 0) & (Operators.CompareString(lbdir.get_Text(), "", false) != 0)))
		{
			return;
		}
		try
		{
			if (Operators.CompareString(Strings.Right(((TextBox)txtpath1).get_Text(), 1), "\\", false) != 0)
			{
				((TextBox)txtpath1).set_Text(((TextBox)txtpath1).get_Text() + "\\");
			}
			((Control)this).set_Cursor(Cursors.get_AppStarting());
			CreateIni(((TextBox)txtpath1).get_Text() + lbdir.get_Text());
			((Control)this).set_Cursor(Cursors.get_Arrow());
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			Interaction.MsgBox((object)(ex2.Message.ToString() + "\r" + ex2.StackTrace!.ToString()), (MsgBoxStyle)64, (object)"提示");
			ProjectData.ClearProjectError();
		}
	}

	public void CreateIni(string p)
	{
		//IL_00d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00da: Invalid comparison between Unknown and I4
		//IL_047f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0485: Invalid comparison between Unknown and I4
		string p2 = p;
		checked
		{
			string text = p2.Substring(p2.LastIndexOf("\\") + 1);
			switch (text)
			{
			case "主臂+固定副臂":
			case "主臂+塔式副臂":
			case "主臂+固定副臂+超起":
			case "主臂+塔式副臂+超起":
			{
				string text2 = text;
				string[] directories = Directory.GetDirectories(p2);
				if (directories.Count() == 0)
				{
					break;
				}
				if (File.Exists(p2 + "\\" + text2 + ".ini"))
				{
					if (unchecked((int)MessageBox.Show(p2 + "\\" + text2 + ".ini 已经存在，是否覆盖？", "提示", (MessageBoxButtons)4, (MessageBoxIcon)64)) == 7)
					{
						lblog.get_Items().Add((object)("没有覆盖 " + text2 + " 下的ini文件..."));
						return;
					}
					int num = directories.Count() - 1;
					for (int i = 0; i <= num; i++)
					{
						text = directories[i].Substring(directories[i].LastIndexOf("\\") + 1);
						if (Operators.CompareString(text, "副臂优先", false) == 0)
						{
							Chbzbyx = false;
							lblog.get_Items().Add((object)"");
							lblog.get_Items().Add((object)("正在生成 " + text2 + ".ini ..."));
							lblog.get_Items().Add((object)"正在提取副臂优先数据...");
							lblog.get_Items().Add((object)"");
							lblog.Refresh();
							zhubijguding(directories[i]);
						}
						else if (Operators.CompareString(text, "主臂优先", false) == 0)
						{
							Chbzbyx = true;
							lblog.get_Items().Add((object)"");
							lblog.get_Items().Add((object)("正在生成 " + text2 + ".ini ..."));
							lblog.get_Items().Add((object)"正在提取主臂优先数据...");
							lblog.get_Items().Add((object)"");
							lblog.Refresh();
							zhubijguding(directories[i]);
						}
					}
				}
				else
				{
					int num2 = directories.Count() - 1;
					for (int j = 0; j <= num2; j++)
					{
						text = directories[j].Substring(directories[j].LastIndexOf("\\") + 1);
						if (Operators.CompareString(text, "副臂优先", false) == 0)
						{
							Chbzbyx = false;
							lblog.get_Items().Add((object)"");
							lblog.get_Items().Add((object)("正在生成 " + text2 + ".ini ..."));
							lblog.get_Items().Add((object)"正在提取副臂优先数据...");
							lblog.get_Items().Add((object)"");
							lblog.Refresh();
							zhubijguding(directories[j]);
						}
						else if (Operators.CompareString(text, "主臂优先", false) == 0)
						{
							Chbzbyx = true;
							lblog.get_Items().Add((object)"");
							lblog.get_Items().Add((object)("正在生成 " + text2 + ".ini ..."));
							lblog.get_Items().Add((object)"正在提取主臂优先数据...");
							lblog.get_Items().Add((object)"");
							lblog.Refresh();
							zhubijguding(directories[j]);
						}
					}
				}
				zbjfbini(ref p2);
				lblog.get_Items().Add((object)("生成的 " + text2 + ".ini 路径为;" + p2 + "\\" + text2 + ".ini"));
				lblog.set_SelectedIndex(lblog.get_Items().get_Count() - 1);
				break;
			}
			case "主臂":
			case "主臂+超起":
				if (File.Exists(p2 + "\\" + text + ".ini"))
				{
					if (unchecked((int)MessageBox.Show(p2 + "\\" + text + ".ini 已经存在，是否覆盖？", "提示", (MessageBoxButtons)4, (MessageBoxIcon)64)) != 6)
					{
						lblog.get_Items().Add((object)("没有覆盖 " + text + " 下的ini文件..."));
						return;
					}
					lblog.get_Items().Add((object)"");
					lblog.get_Items().Add((object)("正在生成 " + text + ".ini ..."));
					lblog.get_Items().Add((object)"");
					lblog.Refresh();
					sczhubi(p2);
					lblog.get_Items().Add((object)"");
					lblog.get_Items().Add((object)("生成的 " + text + ".ini路径为;" + p2 + "\\" + text + ".ini"));
					lblog.set_SelectedIndex(lblog.get_Items().get_Count() - 1);
				}
				else
				{
					lblog.get_Items().Add((object)"");
					lblog.get_Items().Add((object)("正在生成 " + text + ".ini ..."));
					lblog.get_Items().Add((object)"");
					lblog.Refresh();
					sczhubi(p2);
					lblog.get_Items().Add((object)"");
					lblog.get_Items().Add((object)("生成的 " + text + ".ini路径为;" + p2 + "\\" + text + ".ini"));
					lblog.set_SelectedIndex(lblog.get_Items().get_Count() - 1);
				}
				break;
			}
			((Control)this).set_Cursor(Cursors.get_Arrow());
		}
	}

	private void btnExit_Click(object sender, EventArgs e)
	{
		checked
		{
			if (lblog.get_Items().get_Count() != 0)
			{
				int num = lblog.get_Items().get_Count() - 1;
				for (int i = 0; i <= num; i++)
				{
					MyProject.Forms.Main.lslog.get_Items().Add(RuntimeHelpers.GetObjectValue(lblog.get_Items().get_Item(i)));
				}
			}
			MyProject.Forms.Main.lslog.set_SelectedIndex(MyProject.Forms.Main.lslog.get_Items().get_Count() - 1);
			((Form)this).Close();
		}
	}

	private void BtnSelectPath_Click(object sender, EventArgs e)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Invalid comparison between Unknown and I4
		//IL_0185: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			FolderBrowserDialog val = new FolderBrowserDialog();
			val.set_Description("选择保存文件夹路径");
			if ((int)((CommonDialog)val).ShowDialog() != 1)
			{
				return;
			}
			lbdir.get_Items().Clear();
			Quanshen = false;
			Banshen = false;
			qiangdu = false;
			bfg = false;
			gangdu = false;
			CQGSS = false;
			((TextBox)txtpath1).set_Text(val.get_SelectedPath());
			string[] directories = Directory.GetDirectories(((TextBox)txtpath1).get_Text());
			checked
			{
				int num = directories.Count() - 1;
				for (int i = 0; i <= num; i++)
				{
					string text = directories[i].Substring(directories[i].LastIndexOf("\\") + 1);
					switch (text)
					{
					case "主臂":
					case "主臂+超起":
					case "主臂+固定副臂":
					case "主臂+塔式副臂":
					case "主臂+固定副臂+超起":
					case "主臂+塔式副臂+超起":
						lbdir.get_Items().Add((object)text);
						break;
					}
				}
				if (lbdir.get_Items().get_Count() == 0)
				{
					lblog.get_Items().Add((object)"选择的路径中没有包含有效组合的文件夹名称！");
					((Control)btnOK).set_Enabled(false);
				}
				else
				{
					Checkini();
				}
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			Interaction.MsgBox((object)ex2.Message.ToString(), (MsgBoxStyle)64, (object)"提示");
			ProjectData.ClearProjectError();
		}
	}

	private void Checkini()
	{
		string text = ((TextBox)txtpath1).get_Text();
		if (Operators.CompareString(Strings.Right(text, 1), "\\", false) != 0)
		{
			text += "\\";
		}
		checked
		{
			int num = lbdir.get_Items().get_Count() - 1;
			for (int i = 0; i <= num; i++)
			{
				string text2 = Conversions.ToString(Operators.ConcatenateObject((object)text, lbdir.get_Items().get_Item(i)));
				object obj = lbdir.get_Items().get_Item(i);
				if (Conversions.ToBoolean((Conversions.ToBoolean(Operators.CompareObjectEqual(obj, (object)"主臂", false)) || Conversions.ToBoolean(Operators.CompareObjectEqual(obj, (object)"主臂+超起", false))) ? ((object)true) : ((object)false)))
				{
					if (File.Exists(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject((object)(text2 + "\\"), lbdir.get_Items().get_Item(i)), (object)".ini"))))
					{
						lblog.get_Items().Add(Operators.ConcatenateObject(Operators.ConcatenateObject((object)(text2 + "\\"), lbdir.get_Items().get_Item(i)), (object)".ini 已存在."));
					}
					else
					{
						lblog.get_Items().Add(Operators.ConcatenateObject(Operators.ConcatenateObject((object)(text2 + "\\"), lbdir.get_Items().get_Item(i)), (object)".ini 不存在!"));
					}
				}
				else if (Conversions.ToBoolean((Conversions.ToBoolean(Operators.CompareObjectEqual(obj, (object)"主臂+固定副臂", false)) || Conversions.ToBoolean(Operators.CompareObjectEqual(obj, (object)"主臂+塔式副臂", false)) || Conversions.ToBoolean(Operators.CompareObjectEqual(obj, (object)"主臂+固定副臂+超起", false)) || Conversions.ToBoolean(Operators.CompareObjectEqual(obj, (object)"主臂+塔式副臂+超起", false))) ? ((object)true) : ((object)false)))
				{
					if (File.Exists(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject((object)(text2 + "\\"), lbdir.get_Items().get_Item(i)), (object)".ini"))))
					{
						lblog.get_Items().Add(Operators.ConcatenateObject(Operators.ConcatenateObject((object)(text2 + "\\"), lbdir.get_Items().get_Item(i)), (object)".ini 已存在."));
					}
					else
					{
						lblog.get_Items().Add(Operators.ConcatenateObject(Operators.ConcatenateObject((object)(text2 + "\\"), lbdir.get_Items().get_Item(i)), (object)".ini 不存在！"));
					}
				}
			}
		}
	}

	private void lbdir_SelectedIndexChanged(object sender, EventArgs e)
	{
		if (Operators.CompareString(lbdir.get_Text(), "", false) != 0)
		{
			((Control)btnOK).set_Enabled(true);
		}
		else
		{
			((Control)btnOK).set_Enabled(false);
		}
	}
}
