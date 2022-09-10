using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using CNBC.DAL;
using CNBC_MONEY_2009.My;
using Infragistics.Shared;
using Infragistics.Win;
using Infragistics.Win.UltraWinDataSource;
using Infragistics.Win.UltraWinGrid;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace CNBC_MONEY_2009;

[DesignerGenerated]
public class frmBSEWires : Form
{
	private static ArrayList __ENCList = new ArrayList();

	private IContainer components;

	[AccessedThroughProperty("UltraDataSource1")]
	private UltraDataSource _UltraDataSource1;

	[AccessedThroughProperty("Timer1")]
	private Timer _Timer1;

	[AccessedThroughProperty("ContextMenuStrip1")]
	private ContextMenuStrip _ContextMenuStrip1;

	[AccessedThroughProperty("ToolStripMenuItem1")]
	private ToolStripMenuItem _ToolStripMenuItem1;

	[AccessedThroughProperty("ugBSEWires")]
	private UltraGrid _ugBSEWires;

	private string strSQL;

	internal virtual UltraDataSource UltraDataSource1
	{
		[DebuggerNonUserCode]
		get
		{
			return _UltraDataSource1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_UltraDataSource1 = value;
		}
	}

	internal virtual Timer Timer1
	{
		[DebuggerNonUserCode]
		get
		{
			return _Timer1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			if (_Timer1 != null)
			{
				_Timer1.remove_Tick((EventHandler)Timer1_Tick);
			}
			_Timer1 = value;
			if (_Timer1 != null)
			{
				_Timer1.add_Tick((EventHandler)Timer1_Tick);
			}
		}
	}

	internal virtual ContextMenuStrip ContextMenuStrip1
	{
		[DebuggerNonUserCode]
		get
		{
			return _ContextMenuStrip1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_ContextMenuStrip1 = value;
		}
	}

	internal virtual ToolStripMenuItem ToolStripMenuItem1
	{
		[DebuggerNonUserCode]
		get
		{
			return _ToolStripMenuItem1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			if (_ToolStripMenuItem1 != null)
			{
				((ToolStripItem)_ToolStripMenuItem1).remove_Click((EventHandler)ToolStripMenuItem1_Click);
			}
			_ToolStripMenuItem1 = value;
			if (_ToolStripMenuItem1 != null)
			{
				((ToolStripItem)_ToolStripMenuItem1).add_Click((EventHandler)ToolStripMenuItem1_Click);
			}
		}
	}

	internal virtual UltraGrid ugBSEWires
	{
		[DebuggerNonUserCode]
		get
		{
			return _ugBSEWires;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			//IL_001c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0026: Expected O, but got Unknown
			//IL_0049: Unknown result type (might be due to invalid IL or missing references)
			//IL_0053: Expected O, but got Unknown
			if (_ugBSEWires != null)
			{
				_ugBSEWires.remove_InitializeLayout(new InitializeLayoutEventHandler(ugBSEWires_InitializeLayout));
			}
			_ugBSEWires = value;
			if (_ugBSEWires != null)
			{
				_ugBSEWires.add_InitializeLayout(new InitializeLayoutEventHandler(ugBSEWires_InitializeLayout));
			}
		}
	}

	[DebuggerNonUserCode]
	public frmBSEWires()
	{
		((Form)this).add_Load((EventHandler)frmBSEWires_Load);
		__ENCList.Add(new WeakReference(this));
		InitializeComponent();
	}

	[DebuggerNonUserCode]
	protected override void Dispose(bool disposing)
	{
		if ((disposing && components != null) ? true : false)
		{
			components.Dispose();
		}
		((Form)this).Dispose(disposing);
	}

	[DebuggerStepThrough]
	private void InitializeComponent()
	{
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Expected O, but got Unknown
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Expected O, but got Unknown
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Expected O, but got Unknown
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Expected O, but got Unknown
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Expected O, but got Unknown
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Expected O, but got Unknown
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Expected O, but got Unknown
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Expected O, but got Unknown
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Expected O, but got Unknown
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		//IL_006b: Expected O, but got Unknown
		//IL_0072: Unknown result type (might be due to invalid IL or missing references)
		//IL_007c: Expected O, but got Unknown
		//IL_007d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0087: Expected O, but got Unknown
		//IL_0406: Unknown result type (might be due to invalid IL or missing references)
		//IL_0410: Expected O, but got Unknown
		//IL_0498: Unknown result type (might be due to invalid IL or missing references)
		//IL_04a2: Expected O, but got Unknown
		components = new Container();
		UltraGridBand val = new UltraGridBand("Band 0", -1);
		Appearance val2 = new Appearance();
		Appearance val3 = new Appearance();
		Appearance val4 = new Appearance();
		Appearance val5 = new Appearance();
		Appearance val6 = new Appearance();
		Appearance val7 = new Appearance();
		ContextMenuStrip1 = new ContextMenuStrip(components);
		ToolStripMenuItem1 = new ToolStripMenuItem();
		UltraDataSource1 = new UltraDataSource(components);
		Timer1 = new Timer(components);
		ugBSEWires = new UltraGrid();
		((Control)ContextMenuStrip1).SuspendLayout();
		((ISupportInitialize)UltraDataSource1).BeginInit();
		((ISupportInitialize)ugBSEWires).BeginInit();
		((Control)this).SuspendLayout();
		((ToolStrip)ContextMenuStrip1).get_Items().AddRange((ToolStripItem[])(object)new ToolStripItem[1] { (ToolStripItem)ToolStripMenuItem1 });
		((Control)ContextMenuStrip1).set_Name("ContextMenuStrip1");
		ContextMenuStrip contextMenuStrip = ContextMenuStrip1;
		Size size = new Size(155, 26);
		((Control)contextMenuStrip).set_Size(size);
		((ToolStripItem)ToolStripMenuItem1).set_Name("ToolStripMenuItem1");
		ToolStripMenuItem1.set_ShortcutKeys((Keys)122);
		ToolStripMenuItem toolStripMenuItem = ToolStripMenuItem1;
		size = new Size(154, 22);
		((ToolStripItem)toolStripMenuItem).set_Size(size);
		((ToolStripItem)ToolStripMenuItem1).set_Text("Show Story");
		Timer1.set_Enabled(true);
		Timer1.set_Interval(20000);
		((Control)ugBSEWires).set_ContextMenuStrip(ContextMenuStrip1);
		val2.set_BackColor(Color.Purple);
		val2.set_BackColor2(Color.Purple);
		val.get_Override().set_SelectedCellAppearance((AppearanceBase)(object)val2);
		((UltraGridBase)ugBSEWires).get_DisplayLayout().get_BandsSerializer().Add((object)val);
		((UltraGridBase)ugBSEWires).get_DisplayLayout().set_CaptionVisible((DefaultableBoolean)2);
		((UltraGridBase)ugBSEWires).get_DisplayLayout().set_MaxColScrollRegions(1);
		((UltraGridBase)ugBSEWires).get_DisplayLayout().set_MaxRowScrollRegions(1);
		((UltraGridBase)ugBSEWires).get_DisplayLayout().get_Override().set_AllowRowFiltering((DefaultableBoolean)1);
		val3.set_BackColor(Color.Transparent);
		((UltraGridBase)ugBSEWires).get_DisplayLayout().get_Override().set_CardAreaAppearance((AppearanceBase)(object)val3);
		((UltraGridBase)ugBSEWires).get_DisplayLayout().get_Override().set_FilterOperatorLocation((FilterOperatorLocation)3);
		((UltraGridBase)ugBSEWires).get_DisplayLayout().get_Override().set_FilterUIType((FilterUIType)2);
		val4.set_BackColor(Color.FromArgb(89, 135, 214));
		val4.set_BackColor2(Color.FromArgb(7, 59, 150));
		val4.set_BackGradientStyle((GradientStyle)2);
		val4.get_FontData().set_BoldAsString("True");
		val4.get_FontData().set_Name("Arial");
		val4.get_FontData().set_SizeInPoints(10f);
		val4.set_ForeColor(Color.White);
		val4.set_ThemedElementAlpha((Alpha)3);
		((UltraGridBase)ugBSEWires).get_DisplayLayout().get_Override().set_HeaderAppearance((AppearanceBase)(object)val4);
		((UltraGridBase)ugBSEWires).get_DisplayLayout().get_Override().set_HeaderClickAction((HeaderClickAction)2);
		val5.set_BackGradientAlignment((GradientAlignment)3);
		val5.set_BackGradientStyle((GradientStyle)2);
		val5.set_BackHatchStyle((BackHatchStyle)2);
		((UltraGridBase)ugBSEWires).get_DisplayLayout().get_Override().set_RowAppearance((AppearanceBase)(object)val5);
		val6.set_BackColor(Color.FromArgb(89, 135, 214));
		val6.set_BackColor2(Color.FromArgb(7, 59, 150));
		val6.set_BackGradientStyle((GradientStyle)2);
		((UltraGridBase)ugBSEWires).get_DisplayLayout().get_Override().set_RowSelectorAppearance((AppearanceBase)(object)val6);
		((UltraGridBase)ugBSEWires).get_DisplayLayout().get_Override().set_RowSelectorNumberStyle((RowSelectorNumberStyle)3);
		val7.set_BackColor(Color.FromArgb(251, 230, 148));
		val7.set_BackColor2(Color.FromArgb(238, 149, 21));
		val7.set_BackGradientStyle((GradientStyle)2);
		((UltraGridBase)ugBSEWires).get_DisplayLayout().get_Override().set_SelectedRowAppearance((AppearanceBase)(object)val7);
		((UltraGridBase)ugBSEWires).get_DisplayLayout().get_Override().set_SelectTypeRow((SelectType)2);
		((UltraGridBase)ugBSEWires).get_DisplayLayout().set_ScrollBounds((ScrollBounds)0);
		((Control)ugBSEWires).set_Dock((DockStyle)5);
		((Control)ugBSEWires).set_Font(new Font("Verdana", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		UltraGrid obj = ugBSEWires;
		Point location = new Point(0, 0);
		((Control)obj).set_Location(location);
		((Control)ugBSEWires).set_Name("ugBSEWires");
		UltraGrid obj2 = ugBSEWires;
		size = new Size(920, 528);
		((Control)obj2).set_Size(size);
		((Control)ugBSEWires).set_TabIndex(6);
		size = new Size(920, 528);
		((Form)this).set_ClientSize(size);
		((Control)this).get_Controls().Add((Control)(object)ugBSEWires);
		((Control)this).set_Font(new Font("Verdana", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)this).set_Name("frmBSEWires");
		((Form)this).set_Text("BSEWires");
		((Control)ContextMenuStrip1).ResumeLayout(false);
		((ISupportInitialize)UltraDataSource1).EndInit();
		((ISupportInitialize)ugBSEWires).EndInit();
		((Control)this).ResumeLayout(false);
	}

	private void frmBSEWires_Load(object sender, EventArgs e)
	{
		Money_Splash money_Splash = new Money_Splash();
		((Control)money_Splash).Show();
		((Control)money_Splash).Refresh();
		BindControls();
		((Form)money_Splash).Close();
	}

	private void ToolStripMenuItem1_Click(object sender, EventArgs e)
	{
		if (IsActiveRow())
		{
			clsEquity clsEquity2 = new clsEquity();
			clsEquity2.ShowNews(Conversions.ToString(((UltraGridBase)ugBSEWires).get_ActiveRow().get_Cells().get_Item("NewsID")
				.get_Value()), Conversions.ToString(((UltraGridBase)ugBSEWires).get_ActiveRow().get_Cells().get_Item("FeedSource")
				.get_Value()));
		}
	}

	private void ugBSEWires_InitializeLayout(object sender, InitializeLayoutEventArgs e)
	{
		e.get_Layout().get_Bands().get_Item(0)
			.get_Columns()
			.get_Item("DATED")
			.set_Width(100);
		e.get_Layout().get_Bands().get_Item(0)
			.get_Columns()
			.get_Item("NEWSSUB")
			.set_Width(600);
		e.get_Layout().get_Bands().get_Item(0)
			.get_Columns()
			.get_Item("FEEDSOURCE")
			.set_Width(130);
		e.get_Layout().get_Bands().get_Item(0)
			.get_Columns()
			.get_Item("ATTACHMENT")
			.set_Width(220);
		e.get_Layout().get_Bands().get_Item(0)
			.get_Columns()
			.get_Item("NewsID")
			.set_Hidden(true);
		e.get_Layout().get_Bands().get_Item(0)
			.get_Columns()
			.get_Item("NEWSSUB")
			.set_FilterOperatorDefaultValue((FilterOperatorDefaultValue)15);
		e.get_Layout().get_Bands().get_Item(0)
			.get_Columns()
			.get_Item("COMPANYNAME")
			.set_FilterOperatorDefaultValue((FilterOperatorDefaultValue)15);
		checked
		{
			int num = ((DisposableObjectCollectionBase)e.get_Layout().get_Bands().get_Item(0)
				.get_Columns()).get_Count() - 1;
			int num2 = 0;
			while (true)
			{
				int num3 = num2;
				int num4 = num;
				if (num3 <= num4)
				{
					e.get_Layout().get_Bands().get_Item(0)
						.get_Columns()
						.get_Item(num2)
						.set_CellActivation((Activation)3);
					e.get_Layout().get_Bands().get_Item(0)
						.get_Override()
						.set_CellClickAction((CellClickAction)2);
					num2++;
					continue;
				}
				break;
			}
		}
	}

	private void Timer1_Tick(object sender, EventArgs e)
	{
		Timer1.set_Enabled(false);
		BindControls();
		Timer1.set_Enabled(true);
	}

	private void BindControls()
	{
		checked
		{
			try
			{
				DataTable dataTable = new DataTable();
				DataTable dataTable2 = new DataTable();
				strSQL = "Select CONVERT(VARCHAR(5),Dated,108) AS DATED,NEWSSUB,NEWSID,COMPANYNAME=ISNULL((Select top 1 shortname from Equity_transaction_data where exchangesymbol=a.scrip),''),'WEB' as FEEDSOURCE,ATTACHMENT from BSE_Announcements_WIRE_Gamma a  UNION  SELECT CONVERT(VARCHAR(5),Dated,108) AS DATED,COMPANYNAME + ' : ' + NEWSSUB AS NEWSSUB,CONVERT(VARCHAR,ID) AS NEWSID,COMPANYNAME,'NSE_XML_RESULTS' AS FEEDSOURCE, '' AS ATTACHMENT FROM Earnings_Results a  UNION  Select CONVERT(VARCHAR(5),Dated,108) AS DATED,NEWSSUB,NEWSID,COMPANYNAME=ISNULL((Select top 1 shortname from Equity_transaction_data where exchangesymbol=a.scrip),''),'FEED'  as FEEDSOURCE,ATTACHMENT from bse_announcements_wire a WHERE CONVERT(VARCHAR,dated,101) > CONVERT(VARCHAR,DATEADD(d,-1,GETDATE()),101)  order by dated DESC";
				dataTable = SqlHelper.ExecuteDataset(MySettingsProperty.Settings.strCON, CommandType.Text, strSQL).Tables[0];
				int num = dataTable.Columns.Count - 1;
				int num2 = 0;
				while (true)
				{
					int num3 = num2;
					int num4 = num;
					if (num3 > num4)
					{
						break;
					}
					dataTable2.Columns.Add(dataTable.Columns[num2].ColumnName);
					num2++;
				}
				string text = "";
				int num5 = dataTable.Rows.Count - 1;
				int num6 = 0;
				while (true)
				{
					int num7 = num6;
					int num4 = num5;
					if (num7 > num4)
					{
						break;
					}
					string text2 = text;
					Type typeFromHandle = typeof(Strings);
					object[] array = new object[1];
					object[] array2 = array;
					DataRow dataRow = dataTable.Rows[num6];
					DataRow dataRow2 = dataRow;
					string columnName = "NewsSub";
					array2[0] = RuntimeHelpers.GetObjectValue(dataRow2[columnName]);
					object[] array3 = array;
					object[] array4 = array3;
					bool[] array5 = new bool[1] { true };
					object obj = NewLateBinding.LateGet((object)null, typeFromHandle, "UCase", array4, (string[])null, (Type[])null, array5);
					if (array5[0])
					{
						dataRow[columnName] = RuntimeHelpers.GetObjectValue(array3[0]);
					}
					string text3 = Strings.Trim(Conversions.ToString(obj));
					Type typeFromHandle2 = typeof(Strings);
					object[] array6 = new object[1];
					object[] array7 = array6;
					DataRow dataRow3 = dataTable.Rows[num6];
					DataRow dataRow4 = dataRow3;
					string columnName2 = "attachment";
					array7[0] = RuntimeHelpers.GetObjectValue(dataRow4[columnName2]);
					object[] array8 = array6;
					object[] array9 = array8;
					bool[] array10 = new bool[1] { true };
					object obj2 = NewLateBinding.LateGet((object)null, typeFromHandle2, "UCase", array9, (string[])null, (Type[])null, array10);
					if (array10[0])
					{
						dataRow3[columnName2] = RuntimeHelpers.GetObjectValue(array8[0]);
					}
					if (Operators.CompareString(text2, text3 + Strings.Trim(Conversions.ToString(obj2)), false) != 0)
					{
						DataRow dataRow5 = dataTable2.NewRow();
						int num8 = dataTable.Columns.Count - 1;
						int num9 = 0;
						while (true)
						{
							int num10 = num9;
							num4 = num8;
							if (num10 > num4)
							{
								break;
							}
							dataRow5[num9] = Strings.Trim(Conversions.ToString(dataTable.Rows[num6][num9]));
							num9++;
						}
						dataTable2.Rows.Add(dataRow5);
						Type typeFromHandle3 = typeof(Strings);
						array8 = new object[1];
						object[] array11 = array8;
						dataRow3 = dataTable.Rows[num6];
						DataRow dataRow6 = dataRow3;
						columnName2 = "NewsSub";
						array11[0] = RuntimeHelpers.GetObjectValue(dataRow6[columnName2]);
						array6 = array8;
						object[] array12 = array6;
						array10 = new bool[1] { true };
						object obj3 = NewLateBinding.LateGet((object)null, typeFromHandle3, "UCase", array12, (string[])null, (Type[])null, array10);
						if (array10[0])
						{
							dataRow3[columnName2] = RuntimeHelpers.GetObjectValue(array6[0]);
						}
						string text4 = Strings.Trim(Conversions.ToString(obj3));
						Type typeFromHandle4 = typeof(Strings);
						array3 = new object[1];
						object[] array13 = array3;
						dataRow = dataTable.Rows[num6];
						DataRow dataRow7 = dataRow;
						columnName = "attachment";
						array13[0] = RuntimeHelpers.GetObjectValue(dataRow7[columnName]);
						array = array3;
						object[] array14 = array;
						array5 = new bool[1] { true };
						object obj4 = NewLateBinding.LateGet((object)null, typeFromHandle4, "UCase", array14, (string[])null, (Type[])null, array5);
						if (array5[0])
						{
							dataRow[columnName] = RuntimeHelpers.GetObjectValue(array[0]);
						}
						text = text4 + Strings.Trim(Conversions.ToString(obj4));
					}
					num6++;
				}
				((UltraGridBase)ugBSEWires).set_DataSource((object)dataTable2);
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
			}
		}
	}

	private bool IsActiveRow(string strTitle = "")
	{
		if ((((UltraGridBase)ugBSEWires).get_ActiveRow() == null) | ((UltraGridBase)ugBSEWires).get_ActiveRow().get_IsFilterRow())
		{
			mdlMain.ShowMessage("Select a stock.", "UltraToolbarsManager1_ToolClick :: " + strTitle);
			return false;
		}
		return true;
	}
}
