using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using DevComponents.DotNetBar.Controls;
using Excel;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.Devices;
using xxx.My;

namespace xxx;

[DesignerGenerated]
public class ll_ufbt : Office2007Form
{
	private IContainer components;

	[AccessedThroughProperty("ll_txt1")]
	private TextBoxX _ll_txt1;

	[AccessedThroughProperty("ll_txt2")]
	private TextBoxX _ll_txt2;

	[AccessedThroughProperty("ll_lbetempqx")]
	private LabelX _ll_lbetempqx;

	[AccessedThroughProperty("ll_bmp")]
	private PictureBox _ll_bmp;

	[AccessedThroughProperty("btnexit")]
	private ButtonX _btnexit;

	[AccessedThroughProperty("ll_btnviewXY")]
	private ButtonX _ll_btnviewXY;

	[AccessedThroughProperty("ll_btnupdatedata")]
	private ButtonX _ll_btnupdatedata;

	[AccessedThroughProperty("ll_btncsv2")]
	private ButtonX _ll_btncsv2;

	[AccessedThroughProperty("ll_btncsv1")]
	private ButtonX _ll_btncsv1;

	[AccessedThroughProperty("GetOpenFilename")]
	private OpenFileDialog _GetOpenFilename;

	[AccessedThroughProperty("SaveJpg")]
	private ButtonX _SaveJpg;

	[AccessedThroughProperty("SaveFile")]
	private SaveFileDialog _SaveFile;

	private string fname;

	private XlCutCopyMode CutCopyMode;

	internal virtual TextBoxX ll_txt1
	{
		[DebuggerNonUserCode]
		get
		{
			return _ll_txt1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_ll_txt1 = value;
		}
	}

	internal virtual TextBoxX ll_txt2
	{
		[DebuggerNonUserCode]
		get
		{
			return _ll_txt2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_ll_txt2 = value;
		}
	}

	internal virtual LabelX ll_lbetempqx
	{
		[DebuggerNonUserCode]
		get
		{
			return _ll_lbetempqx;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_ll_lbetempqx = value;
		}
	}

	internal virtual PictureBox ll_bmp
	{
		[DebuggerNonUserCode]
		get
		{
			return _ll_bmp;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_ll_bmp = value;
		}
	}

	internal virtual ButtonX btnexit
	{
		[DebuggerNonUserCode]
		get
		{
			return _btnexit;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = btnexit_Click;
			if (_btnexit != null)
			{
				((Control)_btnexit).remove_Click(eventHandler);
			}
			_btnexit = value;
			if (_btnexit != null)
			{
				((Control)_btnexit).add_Click(eventHandler);
			}
		}
	}

	internal virtual ButtonX ll_btnviewXY
	{
		[DebuggerNonUserCode]
		get
		{
			return _ll_btnviewXY;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = ll_btnviewXY_Click;
			if (_ll_btnviewXY != null)
			{
				((Control)_ll_btnviewXY).remove_Click(eventHandler);
			}
			_ll_btnviewXY = value;
			if (_ll_btnviewXY != null)
			{
				((Control)_ll_btnviewXY).add_Click(eventHandler);
			}
		}
	}

	internal virtual ButtonX ll_btnupdatedata
	{
		[DebuggerNonUserCode]
		get
		{
			return _ll_btnupdatedata;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = ll_btnupdatedata_Click;
			if (_ll_btnupdatedata != null)
			{
				((Control)_ll_btnupdatedata).remove_Click(eventHandler);
			}
			_ll_btnupdatedata = value;
			if (_ll_btnupdatedata != null)
			{
				((Control)_ll_btnupdatedata).add_Click(eventHandler);
			}
		}
	}

	internal virtual ButtonX ll_btncsv2
	{
		[DebuggerNonUserCode]
		get
		{
			return _ll_btncsv2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = ll_btncsv2_Click;
			if (_ll_btncsv2 != null)
			{
				((Control)_ll_btncsv2).remove_Click(eventHandler);
			}
			_ll_btncsv2 = value;
			if (_ll_btncsv2 != null)
			{
				((Control)_ll_btncsv2).add_Click(eventHandler);
			}
		}
	}

	internal virtual ButtonX ll_btncsv1
	{
		[DebuggerNonUserCode]
		get
		{
			return _ll_btncsv1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = ll_btncsv1_Click;
			if (_ll_btncsv1 != null)
			{
				((Control)_ll_btncsv1).remove_Click(eventHandler);
			}
			_ll_btncsv1 = value;
			if (_ll_btncsv1 != null)
			{
				((Control)_ll_btncsv1).add_Click(eventHandler);
			}
		}
	}

	internal virtual OpenFileDialog GetOpenFilename
	{
		[DebuggerNonUserCode]
		get
		{
			return _GetOpenFilename;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_GetOpenFilename = value;
		}
	}

	internal virtual ButtonX SaveJpg
	{
		[DebuggerNonUserCode]
		get
		{
			return _SaveJpg;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = SaveJpg_Click;
			if (_SaveJpg != null)
			{
				((Control)_SaveJpg).remove_Click(eventHandler);
			}
			_SaveJpg = value;
			if (_SaveJpg != null)
			{
				((Control)_SaveJpg).add_Click(eventHandler);
			}
		}
	}

	internal virtual SaveFileDialog SaveFile
	{
		[DebuggerNonUserCode]
		get
		{
			return _SaveFile;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_SaveFile = value;
		}
	}

	[DebuggerNonUserCode]
	public ll_ufbt()
	{
		CutCopyMode = default(XlCutCopyMode);
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
		//IL_061e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0628: Expected O, but got Unknown
		//IL_06fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0707: Expected O, but got Unknown
		ll_txt1 = new TextBoxX();
		ll_txt2 = new TextBoxX();
		ll_lbetempqx = new LabelX();
		ll_bmp = new PictureBox();
		btnexit = new ButtonX();
		ll_btnviewXY = new ButtonX();
		ll_btnupdatedata = new ButtonX();
		ll_btncsv2 = new ButtonX();
		ll_btncsv1 = new ButtonX();
		GetOpenFilename = new OpenFileDialog();
		SaveJpg = new ButtonX();
		SaveFile = new SaveFileDialog();
		((ISupportInitialize)ll_bmp).BeginInit();
		((Control)this).SuspendLayout();
		((TextBoxBase)ll_txt1).set_BackColor(Color.White);
		ll_txt1.get_Border().set_Class("TextBoxBorder");
		ll_txt1.get_Border().set_CornerType((eCornerType)1);
		((TextBoxBase)ll_txt1).set_ForeColor(Color.Black);
		TextBoxX obj = ll_txt1;
		Point location = new Point(153, 12);
		((Control)obj).set_Location(location);
		((Control)ll_txt1).set_Name("ll_txt1");
		((TextBoxBase)ll_txt1).set_ReadOnly(true);
		TextBoxX obj2 = ll_txt1;
		Size size = new Size(486, 21);
		((Control)obj2).set_Size(size);
		((Control)ll_txt1).set_TabIndex(1);
		((TextBoxBase)ll_txt2).set_BackColor(Color.White);
		ll_txt2.get_Border().set_Class("TextBoxBorder");
		ll_txt2.get_Border().set_CornerType((eCornerType)1);
		((TextBoxBase)ll_txt2).set_ForeColor(Color.Black);
		TextBoxX obj3 = ll_txt2;
		location = new Point(153, 51);
		((Control)obj3).set_Location(location);
		((Control)ll_txt2).set_Name("ll_txt2");
		((TextBoxBase)ll_txt2).set_ReadOnly(true);
		TextBoxX obj4 = ll_txt2;
		size = new Size(486, 21);
		((Control)obj4).set_Size(size);
		((Control)ll_txt2).set_TabIndex(1);
		((BaseItemControl)ll_lbetempqx).get_BackgroundStyle().set_Class("");
		((BaseItemControl)ll_lbetempqx).get_BackgroundStyle().set_CornerType((eCornerType)1);
		LabelX obj5 = ll_lbetempqx;
		location = new Point(153, 419);
		((Control)obj5).set_Location(location);
		((Control)ll_lbetempqx).set_Name("ll_lbetempqx");
		LabelX obj6 = ll_lbetempqx;
		size = new Size(486, 17);
		((Control)obj6).set_Size(size);
		((Control)ll_lbetempqx).set_TabIndex(2);
		ll_bmp.set_BorderStyle((BorderStyle)1);
		PictureBox obj7 = ll_bmp;
		location = new Point(153, 95);
		((Control)obj7).set_Location(location);
		((Control)ll_bmp).set_Name("ll_bmp");
		PictureBox obj8 = ll_bmp;
		size = new Size(486, 318);
		((Control)obj8).set_Size(size);
		ll_bmp.set_SizeMode((PictureBoxSizeMode)3);
		ll_bmp.set_TabIndex(3);
		ll_bmp.set_TabStop(false);
		((Control)btnexit).set_AccessibleRole((AccessibleRole)43);
		btnexit.set_ColorTable((eButtonColor)3);
		btnexit.set_DialogResult((DialogResult)2);
		ButtonX obj9 = btnexit;
		location = new Point(12, 207);
		((Control)obj9).set_Location(location);
		((Control)btnexit).set_Name("btnexit");
		ButtonX obj10 = btnexit;
		size = new Size(122, 28);
		((Control)obj10).set_Size(size);
		((PopupItemControl)btnexit).set_Style((eDotNetBarStyle)7);
		((Control)btnexit).set_TabIndex(7);
		btnexit.set_Text("关闭");
		((Control)ll_btnviewXY).set_AccessibleRole((AccessibleRole)43);
		ll_btnviewXY.set_ColorTable((eButtonColor)3);
		ButtonX obj11 = ll_btnviewXY;
		location = new Point(12, 129);
		((Control)obj11).set_Location(location);
		((Control)ll_btnviewXY).set_Name("ll_btnviewXY");
		ButtonX obj12 = ll_btnviewXY;
		size = new Size(122, 28);
		((Control)obj12).set_Size(size);
		((PopupItemControl)ll_btnviewXY).set_Style((eDotNetBarStyle)7);
		((Control)ll_btnviewXY).set_TabIndex(8);
		ll_btnviewXY.set_Text("查看曲线");
		((Control)ll_btnupdatedata).set_AccessibleRole((AccessibleRole)43);
		ll_btnupdatedata.set_ColorTable((eButtonColor)3);
		ButtonX obj13 = ll_btnupdatedata;
		location = new Point(12, 95);
		((Control)obj13).set_Location(location);
		((Control)ll_btnupdatedata).set_Name("ll_btnupdatedata");
		ButtonX obj14 = ll_btnupdatedata;
		size = new Size(122, 28);
		((Control)obj14).set_Size(size);
		((PopupItemControl)ll_btnupdatedata).set_Style((eDotNetBarStyle)7);
		((Control)ll_btnupdatedata).set_TabIndex(6);
		ll_btnupdatedata.set_Text("更新数据源");
		((Control)ll_btncsv2).set_AccessibleRole((AccessibleRole)43);
		ll_btncsv2.set_ColorTable((eButtonColor)3);
		ButtonX obj15 = ll_btncsv2;
		location = new Point(12, 51);
		((Control)obj15).set_Location(location);
		((Control)ll_btncsv2).set_Name("ll_btncsv2");
		ButtonX obj16 = ll_btncsv2;
		size = new Size(122, 28);
		((Control)obj16).set_Size(size);
		((PopupItemControl)ll_btncsv2).set_Style((eDotNetBarStyle)7);
		((Control)ll_btncsv2).set_TabIndex(4);
		ll_btncsv2.set_Text("指定dg_2.csv");
		((Control)ll_btncsv1).set_AccessibleRole((AccessibleRole)43);
		ll_btncsv1.set_ColorTable((eButtonColor)3);
		ButtonX obj17 = ll_btncsv1;
		location = new Point(12, 12);
		((Control)obj17).set_Location(location);
		((Control)ll_btncsv1).set_Name("ll_btncsv1");
		ButtonX obj18 = ll_btncsv1;
		size = new Size(122, 28);
		((Control)obj18).set_Size(size);
		((PopupItemControl)ll_btncsv1).set_Style((eDotNetBarStyle)7);
		((Control)ll_btncsv1).set_TabIndex(5);
		ll_btncsv1.set_Text("指定dg_1.csv");
		((Control)SaveJpg).set_AccessibleRole((AccessibleRole)43);
		SaveJpg.set_ColorTable((eButtonColor)3);
		ButtonX saveJpg = SaveJpg;
		location = new Point(12, 168);
		((Control)saveJpg).set_Location(location);
		((Control)SaveJpg).set_Name("SaveJpg");
		ButtonX saveJpg2 = SaveJpg;
		size = new Size(122, 28);
		((Control)saveJpg2).set_Size(size);
		((PopupItemControl)SaveJpg).set_Style((eDotNetBarStyle)7);
		((Control)SaveJpg).set_TabIndex(8);
		SaveJpg.set_Text("曲线文件另存为...");
		((FileDialog)SaveFile).set_Filter("*.xls|*.xls");
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)0);
		((Form)this).set_AutoSizeMode((AutoSizeMode)0);
		((Form)this).set_CancelButton((IButtonControl)(object)btnexit);
		((Office2007Form)this).set_CaptionFont(new Font("宋体", 9f, (FontStyle)0, (GraphicsUnit)3, (byte)134));
		size = new Size(656, 435);
		((Form)this).set_ClientSize(size);
		((Control)this).get_Controls().Add((Control)(object)btnexit);
		((Control)this).get_Controls().Add((Control)(object)SaveJpg);
		((Control)this).get_Controls().Add((Control)(object)ll_btnviewXY);
		((Control)this).get_Controls().Add((Control)(object)ll_btnupdatedata);
		((Control)this).get_Controls().Add((Control)(object)ll_btncsv2);
		((Control)this).get_Controls().Add((Control)(object)ll_btncsv1);
		((Control)this).get_Controls().Add((Control)(object)ll_bmp);
		((Control)this).get_Controls().Add((Control)(object)ll_lbetempqx);
		((Control)this).get_Controls().Add((Control)(object)ll_txt2);
		((Control)this).get_Controls().Add((Control)(object)ll_txt1);
		((Control)this).set_Font(new Font("宋体", 9f, (FontStyle)0, (GraphicsUnit)3, (byte)134));
		((Form)this).set_FormBorderStyle((FormBorderStyle)3);
		((Form)this).set_MaximizeBox(false);
		((Form)this).set_MinimizeBox(false);
		((Control)this).set_Name("ll_ufbt");
		((Form)this).set_ShowIcon(false);
		((Form)this).set_ShowInTaskbar(false);
		((Form)this).set_StartPosition((FormStartPosition)1);
		((Form)this).set_Text("臂头曲线自动生成.. .");
		((ISupportInitialize)ll_bmp).EndInit();
		((Control)this).ResumeLayout(false);
	}

	private void btnexit_Click(object sender, EventArgs e)
	{
		((Form)this).Close();
	}

	private void ll_btncsv1_Click(object sender, EventArgs e)
	{
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Invalid comparison between Unknown and I4
		//IL_0066: Unknown result type (might be due to invalid IL or missing references)
		((FileDialog)GetOpenFilename).set_Filter("曲线(*.csv)|*.csv");
		if ((int)((CommonDialog)GetOpenFilename).ShowDialog() != 1)
		{
			return;
		}
		fname = ((FileDialog)GetOpenFilename).get_FileName();
		if (Operators.CompareString(fname, "", false) != 0)
		{
			if (!File.Exists(fname))
			{
				Interaction.MsgBox((object)("不存在文件:" + fname), (MsgBoxStyle)0, (object)"提示");
			}
			else
			{
				((TextBox)ll_txt1).set_Text(fname);
			}
		}
	}

	private void ll_btncsv2_Click(object sender, EventArgs e)
	{
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Invalid comparison between Unknown and I4
		//IL_0071: Unknown result type (might be due to invalid IL or missing references)
		fname = "";
		((FileDialog)GetOpenFilename).set_Filter("曲线(*.csv)|*.csv");
		if ((int)((CommonDialog)GetOpenFilename).ShowDialog() != 1)
		{
			return;
		}
		fname = ((FileDialog)GetOpenFilename).get_FileName();
		if (Operators.CompareString(fname, "", false) != 0)
		{
			if (!File.Exists(fname))
			{
				Interaction.MsgBox((object)("不存在文件:" + fname), (MsgBoxStyle)0, (object)"提示");
			}
			else
			{
				((TextBox)ll_txt2).set_Text(fname);
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoOptimization)]
	private void ll_btnupdatedata_Click(object sender, EventArgs e)
	{
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0227: Unknown result type (might be due to invalid IL or missing references)
		//IL_0340: Unknown result type (might be due to invalid IL or missing references)
		//IL_0803: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			try
			{
				if ((Operators.CompareString(Strings.Trim(((TextBox)ll_txt1).get_Text()), "", false) == 0) & (Operators.CompareString(Strings.Trim(((TextBox)ll_txt2).get_Text()), "", false) == 0))
				{
					Interaction.MsgBox((object)"请至少指定一个csv文件.", (MsgBoxStyle)0, (object)"提示");
					return;
				}
				if (File.Exists(Application.get_StartupPath() + "\\temp\\tempqx.gif"))
				{
					FileSystem.Kill(Application.get_StartupPath() + "\\temp\\tempqx.gif");
				}
				if (File.Exists(Application.get_StartupPath() + "\\temp\\tempqx.xls"))
				{
					FileSystem.Kill(Application.get_StartupPath() + "\\temp\\tempqx.xls");
				}
				Workbook workbook = Mod1.excelapp.Workbooks.Open(Application.get_StartupPath() + "\\config\\TempQX.xls", Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value);
				Worksheet worksheet = (Worksheet)workbook.Worksheets["data"];
				int num = 2;
				int num2 = 0;
				fname = ((TextBox)ll_txt1).get_Text();
				if (Operators.CompareString(Strings.Trim(fname), "", false) != 0)
				{
					Mod1.lr = new StreamReader(fname, Encoding.Default);
					string text = "";
					while (!Information.IsNothing((object)text))
					{
						text = Mod1.lr.ReadLine();
						if (Information.IsNothing((object)text))
						{
							break;
						}
						num2++;
						if (num2 >= 2)
						{
							string[] array = Strings.Split(text, ",", -1, (CompareMethod)0);
							if (Information.UBound((Array)array, 1) < 6)
							{
								Interaction.MsgBox((object)"当前文件格式不是曲线文件格式,请仔细核对.", (MsgBoxStyle)0, (object)"提示");
								break;
							}
							float num3 = Conversions.ToSingle(Strings.Trim(array[5]));
							float num4 = Conversions.ToSingle(Strings.Trim(array[6]));
							worksheet.Cells[num, 1] = num3;
							worksheet.Cells[num, 2] = num4;
							num++;
						}
					}
					Mod1.lr.Close();
					Mod1.lr.Dispose();
				}
				num2 = 0;
				fname = ((TextBox)ll_txt2).get_Text();
				if (Operators.CompareString(Strings.Trim(fname), "", false) != 0)
				{
					Mod1.lr = new StreamReader(fname, Encoding.Default);
					string text = "";
					while (!Information.IsNothing((object)text))
					{
						text = Mod1.lr.ReadLine();
						if (Information.IsNothing((object)text))
						{
							break;
						}
						num2++;
						if (num2 >= 2)
						{
							string[] array = Strings.Split(text, ",", -1, (CompareMethod)0);
							if (Information.UBound((Array)array, 1) < 6)
							{
								Interaction.MsgBox((object)"当前文件格式不是曲线文件格式,请仔细核对.", (MsgBoxStyle)0, (object)"提示");
								break;
							}
							float num3 = Conversions.ToSingle(Strings.Trim(array[5]));
							float num4 = Conversions.ToSingle(Strings.Trim(array[6]));
							worksheet.Cells[num, 1] = num3;
							worksheet.Cells[num, 2] = num4;
							num++;
						}
					}
					Mod1.lr.Close();
					Mod1.lr.Dispose();
				}
				if ((Operators.CompareString(Strings.Trim(((TextBox)ll_txt1).get_Text()), "", false) != 0) | (Operators.CompareString(Strings.Trim(((TextBox)ll_txt2).get_Text()), "", false) != 0))
				{
					NewLateBinding.LateCall(worksheet.Columns["A:B", Missing.Value], (Type)null, "Select", new object[0], (string[])null, (Type[])null, (bool[])null, true);
					CutCopyMode = (XlCutCopyMode)0;
					workbook.Charts.Add(Missing.Value, Missing.Value, Missing.Value, Missing.Value);
					workbook.ActiveChart.ChartType = XlChartType.xlXYScatter;
					string text2 = "A1:B" + Conversions.ToString(num - 1);
					Chart activeChart = workbook.ActiveChart;
					object obj = workbook.Sheets["data"];
					object[] array2 = new object[1] { text2 };
					object[] array3 = array2;
					bool[] array4 = new bool[1] { true };
					object obj2 = NewLateBinding.LateGet(obj, (Type)null, "Range", array3, (string[])null, (Type[])null, array4);
					if (array4[0])
					{
						text2 = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array2[0]), typeof(string));
					}
					activeChart.SetSourceData((Excel.Range)obj2, XlRowCol.xlColumns);
					workbook.ActiveChart.Location(XlChartLocation.xlLocationAsObject, "data");
					Chart activeChart2 = workbook.ActiveChart;
					activeChart2.HasTitle = true;
					activeChart2.ChartTitle.get_Characters((object)Missing.Value, (object)Missing.Value).Text = "臂头曲线";
					NewLateBinding.LateSetComplex(activeChart2.Axes(XlAxisType.xlCategory), (Type)null, "HasTitle", new object[1] { true }, (string[])null, (Type[])null, false, true);
					NewLateBinding.LateSetComplex(NewLateBinding.LateGet(NewLateBinding.LateGet(activeChart2.Axes(XlAxisType.xlCategory), (Type)null, "AxisTitle", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Characters", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Text", new object[1] { "幅度mm" }, (string[])null, (Type[])null, false, true);
					NewLateBinding.LateSetComplex(activeChart2.Axes(XlAxisType.xlValue), (Type)null, "HasTitle", new object[1] { true }, (string[])null, (Type[])null, false, true);
					NewLateBinding.LateSetComplex(NewLateBinding.LateGet(NewLateBinding.LateGet(activeChart2.Axes(XlAxisType.xlValue), (Type)null, "AxisTitle", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Characters", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Text", new object[1] { "臂头高度mm" }, (string[])null, (Type[])null, false, true);
					activeChart2 = null;
					object obj3 = workbook.ActiveChart.Axes(XlAxisType.xlCategory);
					NewLateBinding.LateSetComplex(obj3, (Type)null, "HasMajorGridlines", new object[1] { false }, (string[])null, (Type[])null, false, true);
					NewLateBinding.LateSetComplex(obj3, (Type)null, "HasMinorGridlines", new object[1] { false }, (string[])null, (Type[])null, false, true);
					obj3 = null;
					object obj4 = workbook.ActiveChart.Axes(XlAxisType.xlValue);
					NewLateBinding.LateSetComplex(obj4, (Type)null, "HasMajorGridlines", new object[1] { true }, (string[])null, (Type[])null, false, true);
					NewLateBinding.LateSetComplex(obj4, (Type)null, "HasMinorGridlines", new object[1] { false }, (string[])null, (Type[])null, false, true);
					obj4 = null;
					workbook.ActiveChart.HasLegend = false;
					ChartObject chartObject = (ChartObject)worksheet.ChartObjects("图表 1");
					chartObject.Chart.Export(Application.get_StartupPath() + "\\temp\\tempqx.gif", "gif", Missing.Value);
					Mod1.excelapp.DisplayAlerts = false;
					fname = Application.get_StartupPath() + "\\temp\\tempqx.xls";
					workbook.SaveAs(fname, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, XlSaveAsAccessMode.xlNoChange, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value);
					workbook.Close(Missing.Value, Missing.Value, Missing.Value);
					Mod1.excelapp.DisplayAlerts = true;
					ll_lbetempqx.set_Text("臂头曲线xls文件位置:" + fname + " 更新时间:" + Conversions.ToString(DateTime.Now));
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				string text3 = "当前指定的CSV文件格式不正确！";
				Interaction.MsgBox((object)(text3 + "\r" + ex2.Message.ToString() + "\r" + ex2.StackTrace!.ToString()), (MsgBoxStyle)64, (object)"提示");
				ProjectData.ClearProjectError();
			}
		}
	}

	private void ll_btnviewXY_Click(object sender, EventArgs e)
	{
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		fname = Application.get_StartupPath() + "\\temp\\tempqx.gif";
		if (File.Exists(fname))
		{
			ll_bmp.set_ImageLocation(fname);
		}
		else
		{
			Interaction.MsgBox((object)(" 没有找到最新的曲线图片文件" + fname), (MsgBoxStyle)0, (object)"提示");
		}
	}

	private void SaveJpg_Click(object sender, EventArgs e)
	{
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Invalid comparison between Unknown and I4
		//IL_0073: Unknown result type (might be due to invalid IL or missing references)
		//IL_0087: Unknown result type (might be due to invalid IL or missing references)
		if (File.Exists(Application.get_StartupPath() + "\\temp\\tempqx.xls"))
		{
			if ((int)((CommonDialog)SaveFile).ShowDialog() == 1 && Operators.CompareString(((FileDialog)SaveFile).get_FileName(), "", false) != 0)
			{
				((ServerComputer)MyProject.Computer).get_FileSystem().CopyFile(Application.get_StartupPath() + "\\temp\\tempqx.xls", ((FileDialog)SaveFile).get_FileName(), true);
				Interaction.MsgBox((object)"保存完成！", (MsgBoxStyle)64, (object)"提示");
			}
		}
		else
		{
			Interaction.MsgBox((object)"没有找到最新的曲线文件 tempqx.xls", (MsgBoxStyle)64, (object)"提示");
		}
	}
}
