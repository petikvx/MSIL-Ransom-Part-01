using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

public class CtrlCropSearcher : UserControl
{
	private GClass7 gclass7_0;

	private List<GStruct3> list_0;

	private int int_0;

	private int int_1;

	private int int_2;

	private double double_0;

	private bool bool_0;

	private bool bool_1;

	private GStruct1 gstruct1_0;

	private Dictionary<string, GClass1> dictionary_0;

	private IContainer icontainer_0;

	private DataGridView dataGridViewResults;

	private Label lblCenterCoords;

	private Label lblCoordinates;

	private GClass9 panel1;

	private Label label1;

	private StatusStrip statusStrip1;

	private ToolStripProgressBar tsProgressBar;

	private ToolStripStatusLabel tsStatusLabel;

	private Button btnSort;

	private Button btnClose;

	private Button btnExportCVS;

	private Button btnStop;

	private ToolStripStatusLabel tsStatusLabelOasis;

	private DataGridViewTextBoxColumn cCoordinates;

	private DataGridViewTextBoxColumn cType;

	private DataGridViewTextBoxColumn cStatus;

	private DataGridViewTextBoxColumn cBonus;

	public CtrlCropSearcher()
	{
		InitializeComponent();
		list_0 = new List<GStruct3>();
		bool_0 = false;
		bool_1 = false;
		dictionary_0 = new Dictionary<string, GClass1>();
		method_1();
	}

	private bool method_0()
	{
		return bool_1;
	}

	private void method_1()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Expected O, but got Unknown
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Expected O, but got Unknown
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Expected O, but got Unknown
		ToolTip val = new ToolTip();
		val.set_InitialDelay(0);
		val.SetToolTip((Control)(object)btnStop, "Stop the current search.");
		val = new ToolTip();
		val.set_InitialDelay(0);
		val.SetToolTip((Control)(object)btnSort, "Sort fields by distance to search center.");
		val = new ToolTip();
		val.set_InitialDelay(0);
		val.SetToolTip((Control)(object)btnExportCVS, "Export search results to CVS file.");
		val = new ToolTip();
		val.set_InitialDelay(0);
		val.SetToolTip((Control)(object)btnClose, "Close dialog.");
	}

	public void method_2(int int_3, int int_4, int int_5, double double_1, GStruct1 gstruct1_1)
	{
		int_0 = int_3;
		int_1 = int_4;
		int_2 = int_5;
		double_0 = double_1;
		gstruct1_0 = gstruct1_1;
		method_6(int_3, int_4);
		gclass7_0 = new GClass7(int_3, int_4, int_5, double_1);
		gclass7_0.ProgressChanged += gclass7_0_ProgressChanged;
		gclass7_0.RunWorkerCompleted += gclass7_0_RunWorkerCompleted;
		gclass7_0.RunWorkerAsync();
	}

	private void method_3(int int_3, int int_4, int int_5)
	{
		GClass1 gClass = new GClass1(int_3, int_4, double_0, int_5, method_11, method_8);
		gClass.method_0(method_4);
		dictionary_0.Add(gClass.method_5(), gClass);
		method_5(dictionary_0);
		gClass.method_7();
	}

	protected void method_4(GClass1 gclass1_0)
	{
		GStruct3 value = list_0[gclass1_0.method_6()];
		value.string_2 = gclass1_0.method_4() + "%";
		list_0[gclass1_0.method_6()] = value;
		string text = gclass1_0.method_5();
		for (int i = 0; i < dataGridViewResults.get_RowCount() - 1; i++)
		{
			if (dataGridViewResults.get_Rows().get_Item(i).get_Cells()
				.get_Item("cCoordinates")
				.get_Value()
				.ToString() == text)
			{
				dataGridViewResults.get_Rows().get_Item(i).get_Cells()
					.get_Item("cBonus")
					.set_Value((object)value.string_2);
				break;
			}
		}
		if (dictionary_0.ContainsKey(gclass1_0.method_5()))
		{
			dictionary_0.Remove(gclass1_0.method_5());
		}
		method_5(dictionary_0);
	}

	private void method_5(Dictionary<string, GClass1> dictionary_1)
	{
		if (dictionary_1.Count == 0)
		{
			((ToolStripItem)tsStatusLabelOasis).set_Text("");
		}
		else
		{
			((ToolStripItem)tsStatusLabelOasis).set_Text("Number of pending crop bonus calculations: " + dictionary_1.Count);
		}
	}

	private void method_6(int int_3, int int_4)
	{
		((Control)lblCoordinates).set_Text("(" + int_3 + ", " + int_4 + ")");
	}

	private void gclass7_0_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
	{
		if (bool_0)
		{
			((ContainerControl)this).get_ParentForm().Close();
		}
		bool_1 = true;
		((Control)btnStop).set_Enabled(false);
	}

	protected void gclass7_0_ProgressChanged(object sender, ProgressChangedEventArgs e)
	{
		GStruct2 gStruct = (GStruct2)e.UserState;
		switch (gStruct.string_0)
		{
		case "Found":
			method_7(gStruct.string_1, gStruct.string_3, gStruct.string_2, gStruct.string_4);
			break;
		case "Progress":
			tsProgressBar.set_Value(e.ProgressPercentage);
			((ToolStripItem)tsStatusLabel).set_Text(e.ProgressPercentage + " of " + tsProgressBar.get_Maximum());
			break;
		case "Stop":
		case "Finish":
			tsProgressBar.set_Value(0);
			((ToolStripItem)tsStatusLabel).set_Text("");
			((Control)btnSort).set_Enabled(true);
			((Control)btnExportCVS).set_Enabled(true);
			break;
		case "Start":
			tsProgressBar.set_Value(0);
			tsProgressBar.set_Minimum(gStruct.int_0);
			tsProgressBar.set_Maximum(gStruct.int_1);
			break;
		}
	}

	protected void method_7(string string_0, string string_1, string string_2, string string_3)
	{
		if (string_0 == "$$")
		{
			return;
		}
		Regex regex = new Regex("\\<div class=\"ddb\"\\>([\\w]*|[\\|]*|[\\s]*|[&#%@£$!-\\.\\)\\(\\/;:\\[\\]\\+]*)*\\</div\\>");
		Regex regex2 = new Regex("([-]*[0-9]*)\\|([-]*[0-9]*)", RegexOptions.IgnoreCase);
		Regex regex3 = new Regex("[\\(]*[\\)]*", RegexOptions.IgnoreCase);
		Match match = regex.Match(string_2);
		Match match2 = regex2.Match(string_1);
		string text = "";
		if (match.Success)
		{
			text = match.Value.Replace("<div class=\"ddb\">", "").Replace("</div>", "");
		}
		else
		{
			text = regex2.Replace(string_1, "");
			text = regex3.Replace(text, "");
		}
		if (text.Trim() == "")
		{
			text = "Taken";
		}
		if (!method_10(string_0.Trim().ToLower()))
		{
			return;
		}
		string text2 = method_11(string_0.Trim().ToLower());
		string string_4 = "";
		if (text2 == "Oasis")
		{
			string string_5 = method_8(string_3);
			string_4 = GClass2.gclass2_0.method_0(string_5);
		}
		GStruct3 gStruct = default(GStruct3);
		gStruct.string_0 = text2;
		gStruct.string_1 = text;
		gStruct.string_2 = string_4;
		gStruct.int_2 = int_0;
		gStruct.int_3 = int_1;
		string[] array = match2.Value.Split(new string[1] { "|" }, StringSplitOptions.RemoveEmptyEntries);
		if (array.Length == 2)
		{
			try
			{
				gStruct.int_0 = Convert.ToInt32(array[0]);
				gStruct.int_1 = Convert.ToInt32(array[1]);
			}
			catch
			{
				return;
			}
		}
		list_0.Add(gStruct);
		if (gStruct.string_0 == "1W 1C 1I 15C" || gStruct.string_0 == "3W 3C 3I 9C")
		{
			method_3(gStruct.int_0, gStruct.int_1, list_0.Count - 1);
			gStruct.string_2 = "Pending... (please wait)";
		}
		method_9(gStruct);
	}

	private string method_8(string string_0)
	{
		Regex regex = new Regex("\\<img src=[\\s\\S]*id=\"resfeld\">");
		Regex regex2 = new Regex("src=[\\s\\S]*[.jpg|.JPG]");
		Match match = regex.Match(string_0);
		if (!match.Success)
		{
			return "";
		}
		Match match2 = regex2.Match(match.Value);
		if (!match2.Success)
		{
			return "";
		}
		string value = match2.Value;
		int num = value.LastIndexOf('/') + 1;
		int num2 = value.LastIndexOf('.');
		return value.Substring(num, num2 - num);
	}

	private void method_9(GStruct3 gstruct3_0)
	{
		int num = dataGridViewResults.get_Rows().Add();
		DataGridViewRow val = dataGridViewResults.get_Rows().get_Item(num);
		val.get_Cells().get_Item(0).set_Value((object)("( " + gstruct3_0.int_0 + " | " + gstruct3_0.int_1 + " )"));
		val.get_Cells().get_Item(1).set_Value((object)gstruct3_0.string_0);
		val.get_Cells().get_Item(2).set_Value((object)gstruct3_0.string_1);
		val.get_Cells().get_Item(3).set_Value((object)(gstruct3_0.string_2 ?? ""));
	}

	private bool method_10(string string_0)
	{
		return string_0 switch
		{
			"f1" => gstruct1_0.bool_0, 
			"f2" => gstruct1_0.bool_1, 
			"f3" => gstruct1_0.bool_2, 
			"f4" => gstruct1_0.bool_3, 
			"f5" => gstruct1_0.bool_4, 
			"f6" => gstruct1_0.bool_5, 
			"f?" => gstruct1_0.bool_6, 
			_ => false, 
		};
	}

	private string method_11(string string_0)
	{
		return string_0 switch
		{
			"f1" => "3W 3C 3I 9C", 
			"f2" => "3W 4C 5I 6C", 
			"f3" => "4W 4C 4I 6C", 
			"f4" => "4W 5C 3I 6C", 
			"f5" => "5W 3C 4I 6C", 
			"f6" => "1W 1C 1I 15C", 
			_ => "Oasis", 
		};
	}

	public void method_12()
	{
		if (method_0())
		{
			((ContainerControl)this).get_ParentForm().Close();
			return;
		}
		gclass7_0.CancelAsync();
		Dictionary<string, GClass1>.Enumerator enumerator = dictionary_0.GetEnumerator();
		while (enumerator.MoveNext())
		{
			enumerator.Current.Value.method_8();
		}
		bool_0 = true;
	}

	private void btnClose_Click(object sender, EventArgs e)
	{
		method_12();
	}

	private void btnSort_Click(object sender, EventArgs e)
	{
		List<GStruct3> list = CloneList(list_0);
		list.Sort();
		method_13(list);
		method_1();
	}

	private void method_13(List<GStruct3> list_1)
	{
		dataGridViewResults.get_Rows().Clear();
		for (int i = 0; i < list_1.Count; i++)
		{
			int num = dataGridViewResults.get_Rows().Add();
			DataGridViewRow val = dataGridViewResults.get_Rows().get_Item(num);
			GStruct3 gStruct = list_1[i];
			val.get_Cells().get_Item(0).set_Value((object)("( " + gStruct.int_0 + " | " + gStruct.int_1 + " )"));
			val.get_Cells().get_Item(1).set_Value((object)gStruct.string_0);
			val.get_Cells().get_Item(2).set_Value((object)gStruct.string_1);
			val.get_Cells().get_Item(3).set_Value((object)gStruct.string_2);
		}
	}

	private List<T> CloneList<T>(List<T> lstItems)
	{
		List<T> list = new List<T>();
		foreach (T lstItem in lstItems)
		{
			list.Add(lstItem);
		}
		return list;
	}

	private void btnExportCVS_Click(object sender, EventArgs e)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Invalid comparison between Unknown and I4
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		SaveFileDialog val = new SaveFileDialog();
		((FileDialog)val).set_DefaultExt("csv");
		((FileDialog)val).set_Filter("CSV files (*.csv)|*.csv|All files (*.*)|*.*");
		((FileDialog)val).set_FilterIndex(1);
		DialogResult val2 = ((CommonDialog)val).ShowDialog();
		if ((int)val2 == 1)
		{
			try
			{
				method_14(dataGridViewResults, ((FileDialog)val).get_FileName());
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
				return;
			}
			MessageBox.Show("CSV file was successfully created.");
		}
		method_1();
	}

	private void method_14(DataGridView dataGridView_0, string string_0)
	{
		string text = ";";
		string text2 = "";
		string text3 = "";
		for (int i = 0; i < ((BaseCollection)dataGridView_0.get_Columns()).get_Count(); i++)
		{
			text3 += Convert.ToString(dataGridView_0.get_Columns().get_Item(i).get_HeaderText());
			if (i < ((BaseCollection)dataGridView_0.get_Columns()).get_Count() - 1)
			{
				text3 += text;
			}
		}
		text2 = text2 + text3 + "\r\n";
		for (int j = 0; j < dataGridView_0.get_RowCount(); j++)
		{
			string text4 = "";
			for (int k = 0; k < ((BaseCollection)dataGridView_0.get_Rows().get_Item(j).get_Cells()).get_Count(); k++)
			{
				text4 += Convert.ToString(dataGridView_0.get_Rows().get_Item(j).get_Cells()
					.get_Item(k)
					.get_Value());
				if (k < ((BaseCollection)dataGridView_0.get_Rows().get_Item(j).get_Cells()).get_Count() - 1)
				{
					text4 += text;
				}
			}
			text2 = text2 + text4 + "\r\n";
		}
		UTF8Encoding uTF8Encoding = new UTF8Encoding();
		byte[] bytes = uTF8Encoding.GetBytes(text2);
		FileStream fileStream = new FileStream(string_0, FileMode.Create);
		BinaryWriter binaryWriter = new BinaryWriter(fileStream);
		binaryWriter.Write(bytes, 0, bytes.Length);
		binaryWriter.Flush();
		binaryWriter.Close();
		fileStream.Close();
	}

	private void btnStop_Click(object sender, EventArgs e)
	{
		gclass7_0.CancelAsync();
		method_1();
	}

	private void dataGridViewResults_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
	{
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Expected O, but got Unknown
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		//IL_007b: Expected O, but got Unknown
		//IL_00a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ae: Expected O, but got Unknown
		//IL_0115: Unknown result type (might be due to invalid IL or missing references)
		//IL_011b: Expected O, but got Unknown
		if (e.get_ColumnIndex() == ((DataGridViewBand)dataGridViewResults.get_Columns().get_Item("cType")).get_Index() && ((ConvertEventArgs)e).get_Value() != null)
		{
			Font val = new Font("Courier new", 9f, (FontStyle)0);
			switch (((ConvertEventArgs)e).get_Value().ToString())
			{
			case "1W 1C 1I 15C":
				val = new Font("Courier new", 10f, (FontStyle)1);
				e.get_CellStyle().set_ForeColor(Color.Blue);
				e.get_CellStyle().set_SelectionForeColor(Color.Blue);
				break;
			case "3W 3C 3I 9C":
				val = new Font("Courier new", 10f, (FontStyle)1);
				e.get_CellStyle().set_ForeColor(Color.OrangeRed);
				e.get_CellStyle().set_SelectionForeColor(Color.OrangeRed);
				break;
			}
			e.get_CellStyle().set_Font(val);
			val.Dispose();
		}
		if (e.get_ColumnIndex() == ((DataGridViewBand)dataGridViewResults.get_Columns().get_Item("cBonus")).get_Index() && ((ConvertEventArgs)e).get_Value() != null)
		{
			Font val2 = new Font(FontFamily.get_GenericSansSerif(), 8.25f, (FontStyle)1);
			e.get_CellStyle().set_Font(val2);
			if (((ConvertEventArgs)e).get_Value().ToString() != "")
			{
				e.get_CellStyle().set_ForeColor(Color.Green);
				e.get_CellStyle().set_SelectionForeColor(Color.Green);
			}
			val2.Dispose();
		}
	}

	protected override void Dispose(bool disposing)
	{
		if (disposing && icontainer_0 != null)
		{
			icontainer_0.Dispose();
		}
		((ContainerControl)this).Dispose(disposing);
	}

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
		//IL_009b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a5: Expected O, but got Unknown
		//IL_00a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b0: Expected O, but got Unknown
		//IL_00b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bb: Expected O, but got Unknown
		//IL_01c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01cb: Expected O, but got Unknown
		//IL_044b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0455: Expected O, but got Unknown
		//IL_04ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0509: Expected O, but got Unknown
		//IL_05c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_05cc: Expected O, but got Unknown
		//IL_067a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0684: Expected O, but got Unknown
		//IL_0805: Unknown result type (might be due to invalid IL or missing references)
		//IL_080f: Expected O, but got Unknown
		//IL_089e: Unknown result type (might be due to invalid IL or missing references)
		//IL_08a8: Expected O, but got Unknown
		//IL_093a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0944: Expected O, but got Unknown
		dataGridViewResults = new DataGridView();
		cCoordinates = new DataGridViewTextBoxColumn();
		cType = new DataGridViewTextBoxColumn();
		cStatus = new DataGridViewTextBoxColumn();
		cBonus = new DataGridViewTextBoxColumn();
		statusStrip1 = new StatusStrip();
		tsProgressBar = new ToolStripProgressBar();
		tsStatusLabel = new ToolStripStatusLabel();
		tsStatusLabelOasis = new ToolStripStatusLabel();
		btnSort = new Button();
		btnClose = new Button();
		btnExportCVS = new Button();
		btnStop = new Button();
		panel1 = new GClass9();
		label1 = new Label();
		lblCoordinates = new Label();
		lblCenterCoords = new Label();
		((ISupportInitialize)dataGridViewResults).BeginInit();
		((Control)statusStrip1).SuspendLayout();
		((Control)panel1).SuspendLayout();
		((Control)this).SuspendLayout();
		dataGridViewResults.set_AllowUserToDeleteRows(false);
		dataGridViewResults.set_AllowUserToOrderColumns(true);
		((Control)dataGridViewResults).set_Anchor((AnchorStyles)15);
		dataGridViewResults.set_ColumnHeadersHeightSizeMode((DataGridViewColumnHeadersHeightSizeMode)2);
		dataGridViewResults.get_Columns().AddRange((DataGridViewColumn[])(object)new DataGridViewColumn[4]
		{
			(DataGridViewColumn)cCoordinates,
			(DataGridViewColumn)cType,
			(DataGridViewColumn)cStatus,
			(DataGridViewColumn)cBonus
		});
		dataGridViewResults.set_GridColor(SystemColors.ControlDarkDark);
		((Control)dataGridViewResults).set_Location(new Point(0, 32));
		((Control)dataGridViewResults).set_Name("dataGridViewResults");
		dataGridViewResults.set_ReadOnly(true);
		((Control)dataGridViewResults).set_Size(new Size(644, 260));
		((Control)dataGridViewResults).set_TabIndex(3);
		dataGridViewResults.add_CellFormatting(new DataGridViewCellFormattingEventHandler(dataGridViewResults_CellFormatting));
		((DataGridViewColumn)cCoordinates).set_HeaderText("Coordinates");
		((DataGridViewColumn)cCoordinates).set_Name("cCoordinates");
		((DataGridViewBand)cCoordinates).set_ReadOnly(true);
		((DataGridViewColumn)cType).set_HeaderText("Type");
		((DataGridViewColumn)cType).set_Name("cType");
		((DataGridViewBand)cType).set_ReadOnly(true);
		((DataGridViewColumn)cType).set_Width(150);
		((DataGridViewColumn)cStatus).set_HeaderText("Status");
		((DataGridViewColumn)cStatus).set_Name("cStatus");
		((DataGridViewBand)cStatus).set_ReadOnly(true);
		((DataGridViewColumn)cStatus).set_Width(200);
		((DataGridViewColumn)cBonus).set_HeaderText("Bonus");
		((DataGridViewColumn)cBonus).set_Name("cBonus");
		((DataGridViewBand)cBonus).set_ReadOnly(true);
		((DataGridViewColumn)cBonus).set_Width(150);
		((ToolStrip)statusStrip1).get_Items().AddRange((ToolStripItem[])(object)new ToolStripItem[3]
		{
			(ToolStripItem)tsProgressBar,
			(ToolStripItem)tsStatusLabel,
			(ToolStripItem)tsStatusLabelOasis
		});
		((Control)statusStrip1).set_Location(new Point(0, 324));
		((Control)statusStrip1).set_Name("statusStrip1");
		((Control)statusStrip1).set_Size(new Size(644, 22));
		((Control)statusStrip1).set_TabIndex(26);
		((Control)statusStrip1).set_Text("statusStrip1");
		((ToolStripItem)tsProgressBar).set_Name("tsProgressBar");
		((ToolStripItem)tsProgressBar).set_Size(new Size(200, 16));
		((ToolStripItem)tsStatusLabel).set_AutoSize(false);
		tsStatusLabel.set_BorderSides((ToolStripStatusLabelBorderSides)15);
		tsStatusLabel.set_BorderStyle((Border3DStyle)2);
		((ToolStripItem)tsStatusLabel).set_ImageAlign((ContentAlignment)16);
		((ToolStripItem)tsStatusLabel).set_Name("tsStatusLabel");
		((ToolStripItem)tsStatusLabel).set_Size(new Size(150, 17));
		((ToolStripItem)tsStatusLabelOasis).set_AutoSize(false);
		tsStatusLabelOasis.set_BorderSides((ToolStripStatusLabelBorderSides)15);
		tsStatusLabelOasis.set_BorderStyle((Border3DStyle)2);
		((ToolStripItem)tsStatusLabelOasis).set_Name("tsStatusLabelOasis");
		((ToolStripItem)tsStatusLabelOasis).set_Size(new Size(246, 17));
		tsStatusLabelOasis.set_Spring(true);
		((ToolStripItem)tsStatusLabelOasis).set_Tag((object)"jijijijjiojoijoijh");
		((Control)btnSort).set_Anchor((AnchorStyles)6);
		((Control)btnSort).set_Enabled(false);
		((Control)btnSort).set_Font(new Font("Microsoft Sans Serif", 10f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)btnSort).set_ForeColor(Color.Green);
		((Control)btnSort).set_Location(new Point(4, 292));
		((Control)btnSort).set_Name("btnSort");
		((Control)btnSort).set_Size(new Size(116, 32));
		((Control)btnSort).set_TabIndex(27);
		((Control)btnSort).set_Text("Sort results");
		((ButtonBase)btnSort).set_UseVisualStyleBackColor(true);
		((Control)btnSort).add_Click((EventHandler)btnSort_Click);
		((Control)btnClose).set_Anchor((AnchorStyles)10);
		((Control)btnClose).set_Font(new Font("Microsoft Sans Serif", 10f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)btnClose).set_ForeColor(Color.Green);
		((Control)btnClose).set_Location(new Point(518, 292));
		((Control)btnClose).set_Name("btnClose");
		((Control)btnClose).set_Size(new Size(122, 32));
		((Control)btnClose).set_TabIndex(28);
		((Control)btnClose).set_Text("Close");
		((ButtonBase)btnClose).set_UseVisualStyleBackColor(true);
		((Control)btnClose).add_Click((EventHandler)btnClose_Click);
		((Control)btnExportCVS).set_Anchor((AnchorStyles)6);
		((Control)btnExportCVS).set_Enabled(false);
		((Control)btnExportCVS).set_Font(new Font("Microsoft Sans Serif", 10f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)btnExportCVS).set_ForeColor(Color.Green);
		((Control)btnExportCVS).set_Location(new Point(123, 292));
		((Control)btnExportCVS).set_Name("btnExportCVS");
		((Control)btnExportCVS).set_Size(new Size(185, 32));
		((Control)btnExportCVS).set_TabIndex(29);
		((Control)btnExportCVS).set_Text("Export results to file");
		((ButtonBase)btnExportCVS).set_UseVisualStyleBackColor(true);
		((Control)btnExportCVS).add_Click((EventHandler)btnExportCVS_Click);
		((Control)btnStop).set_Anchor((AnchorStyles)10);
		((Control)btnStop).set_Font(new Font("Microsoft Sans Serif", 10f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)btnStop).set_ForeColor(Color.Green);
		((Control)btnStop).set_Location(new Point(393, 292));
		((Control)btnStop).set_Name("btnStop");
		((Control)btnStop).set_Size(new Size(122, 32));
		((Control)btnStop).set_TabIndex(30);
		((Control)btnStop).set_Text("Stop search");
		((ButtonBase)btnStop).set_UseVisualStyleBackColor(true);
		((Control)btnStop).add_Click((EventHandler)btnStop_Click);
		((Control)panel1).set_Anchor((AnchorStyles)13);
		panel1.method_1(SystemColors.ControlLightLight);
		panel1.method_9(Color.FromArgb(0, 192, 0));
		panel1.method_7((BorderStyle)1);
		((Control)panel1).get_Controls().Add((Control)(object)label1);
		((Control)panel1).get_Controls().Add((Control)(object)lblCoordinates);
		((Control)panel1).get_Controls().Add((Control)(object)lblCenterCoords);
		panel1.method_13(10);
		((Control)panel1).set_Location(new Point(4, 5));
		((Control)panel1).set_Name("panel1");
		((Control)panel1).set_Size(new Size(637, 23));
		((Control)panel1).set_TabIndex(6);
		((Control)label1).set_AutoSize(true);
		((Control)label1).set_Font(new Font("Arial", 12f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)label1).set_ForeColor(Color.Green);
		((Control)label1).set_Location(new Point(11, 2));
		((Control)label1).set_Name("label1");
		((Control)label1).set_Size(new Size(67, 19));
		((Control)label1).set_TabIndex(0);
		((Control)label1).set_Text("Results");
		((Control)lblCoordinates).set_Anchor((AnchorStyles)9);
		((Control)lblCoordinates).set_AutoSize(true);
		((Control)lblCoordinates).set_Font(new Font("Microsoft Sans Serif", 10f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)lblCoordinates).set_ForeColor(Color.DimGray);
		((Control)lblCoordinates).set_Location(new Point(554, 2));
		((Control)lblCoordinates).set_Name("lblCoordinates");
		((Control)lblCoordinates).set_Size(new Size(80, 17));
		((Control)lblCoordinates).set_TabIndex(5);
		((Control)lblCoordinates).set_Text("(-999,-999)");
		((Control)lblCenterCoords).set_Anchor((AnchorStyles)9);
		((Control)lblCenterCoords).set_AutoSize(true);
		((Control)lblCenterCoords).set_Font(new Font("Microsoft Sans Serif", 10f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)lblCenterCoords).set_ForeColor(Color.DimGray);
		((Control)lblCenterCoords).set_Location(new Point(435, 2));
		((Control)lblCenterCoords).set_Name("lblCenterCoords");
		((Control)lblCenterCoords).set_Size(new Size(129, 17));
		((Control)lblCenterCoords).set_TabIndex(4);
		((Control)lblCenterCoords).set_Text("Center coordinate: ");
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Control)this).get_Controls().Add((Control)(object)btnStop);
		((Control)this).get_Controls().Add((Control)(object)btnExportCVS);
		((Control)this).get_Controls().Add((Control)(object)btnClose);
		((Control)this).get_Controls().Add((Control)(object)btnSort);
		((Control)this).get_Controls().Add((Control)(object)statusStrip1);
		((Control)this).get_Controls().Add((Control)(object)panel1);
		((Control)this).get_Controls().Add((Control)(object)dataGridViewResults);
		((Control)this).set_Name("CtrlCropSearcher");
		((Control)this).set_Size(new Size(644, 346));
		((ISupportInitialize)dataGridViewResults).EndInit();
		((Control)statusStrip1).ResumeLayout(false);
		((Control)statusStrip1).PerformLayout();
		((Control)panel1).ResumeLayout(false);
		((Control)panel1).PerformLayout();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}
}
