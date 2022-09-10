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
using Infragistics.Win.UltraWinGrid;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace CNBC_MONEY_2009;

[DesignerGenerated]
public class frmDJWires : Form
{
	private static ArrayList __ENCList = new ArrayList();

	private IContainer components;

	[AccessedThroughProperty("ugDJWires")]
	private UltraGrid _ugDJWires;

	[AccessedThroughProperty("Timer1")]
	private Timer _Timer1;

	[AccessedThroughProperty("ContextMenuStrip1")]
	private ContextMenuStrip _ContextMenuStrip1;

	[AccessedThroughProperty("ToolStripMenuItem1")]
	private ToolStripMenuItem _ToolStripMenuItem1;

	internal virtual UltraGrid ugDJWires
	{
		[DebuggerNonUserCode]
		get
		{
			return _ugDJWires;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			//IL_001c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0026: Expected O, but got Unknown
			//IL_0034: Unknown result type (might be due to invalid IL or missing references)
			//IL_003e: Expected O, but got Unknown
			//IL_0061: Unknown result type (might be due to invalid IL or missing references)
			//IL_006b: Expected O, but got Unknown
			//IL_0079: Unknown result type (might be due to invalid IL or missing references)
			//IL_0083: Expected O, but got Unknown
			if (_ugDJWires != null)
			{
				_ugDJWires.remove_InitializeLayout(new InitializeLayoutEventHandler(ugDJWires_InitializeLayout));
				_ugDJWires.remove_InitializeRow(new InitializeRowEventHandler(ugDJWires_InitializeRow));
			}
			_ugDJWires = value;
			if (_ugDJWires != null)
			{
				_ugDJWires.add_InitializeLayout(new InitializeLayoutEventHandler(ugDJWires_InitializeLayout));
				_ugDJWires.add_InitializeRow(new InitializeRowEventHandler(ugDJWires_InitializeRow));
			}
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

	[DebuggerNonUserCode]
	public frmDJWires()
	{
		((Form)this).add_Load((EventHandler)frmDJWires_Load);
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
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Expected O, but got Unknown
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Expected O, but got Unknown
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0065: Expected O, but got Unknown
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Expected O, but got Unknown
		//IL_034e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0358: Expected O, but got Unknown
		//IL_0486: Unknown result type (might be due to invalid IL or missing references)
		//IL_0490: Expected O, but got Unknown
		components = new Container();
		UltraGridBand val = new UltraGridBand("Band 0", -1);
		Appearance val2 = new Appearance();
		Appearance val3 = new Appearance();
		Appearance val4 = new Appearance();
		Appearance val5 = new Appearance();
		Appearance val6 = new Appearance();
		Appearance val7 = new Appearance();
		ugDJWires = new UltraGrid();
		ContextMenuStrip1 = new ContextMenuStrip(components);
		ToolStripMenuItem1 = new ToolStripMenuItem();
		Timer1 = new Timer(components);
		((ISupportInitialize)ugDJWires).BeginInit();
		((Control)ContextMenuStrip1).SuspendLayout();
		((Control)this).SuspendLayout();
		((Control)ugDJWires).set_ContextMenuStrip(ContextMenuStrip1);
		val2.set_BackColor(Color.Purple);
		val2.set_BackColor2(Color.Purple);
		val.get_Override().set_SelectedCellAppearance((AppearanceBase)(object)val2);
		((UltraGridBase)ugDJWires).get_DisplayLayout().get_BandsSerializer().Add((object)val);
		((UltraGridBase)ugDJWires).get_DisplayLayout().set_CaptionVisible((DefaultableBoolean)2);
		((UltraGridBase)ugDJWires).get_DisplayLayout().set_MaxColScrollRegions(1);
		((UltraGridBase)ugDJWires).get_DisplayLayout().set_MaxRowScrollRegions(1);
		((UltraGridBase)ugDJWires).get_DisplayLayout().get_Override().set_AllowRowFiltering((DefaultableBoolean)1);
		val3.set_BackColor(Color.Transparent);
		((UltraGridBase)ugDJWires).get_DisplayLayout().get_Override().set_CardAreaAppearance((AppearanceBase)(object)val3);
		((UltraGridBase)ugDJWires).get_DisplayLayout().get_Override().set_FilterOperatorDefaultValue((FilterOperatorDefaultValue)11);
		((UltraGridBase)ugDJWires).get_DisplayLayout().get_Override().set_FilterOperatorLocation((FilterOperatorLocation)3);
		((UltraGridBase)ugDJWires).get_DisplayLayout().get_Override().set_FilterUIType((FilterUIType)2);
		val4.set_BackColor(Color.FromArgb(89, 135, 214));
		val4.set_BackColor2(Color.FromArgb(7, 59, 150));
		val4.set_BackGradientStyle((GradientStyle)2);
		val4.get_FontData().set_BoldAsString("True");
		val4.get_FontData().set_Name("Arial");
		val4.get_FontData().set_SizeInPoints(10f);
		val4.set_ForeColor(Color.White);
		val4.set_ThemedElementAlpha((Alpha)3);
		((UltraGridBase)ugDJWires).get_DisplayLayout().get_Override().set_HeaderAppearance((AppearanceBase)(object)val4);
		((UltraGridBase)ugDJWires).get_DisplayLayout().get_Override().set_HeaderClickAction((HeaderClickAction)2);
		val5.set_BackGradientAlignment((GradientAlignment)3);
		val5.set_BackGradientStyle((GradientStyle)2);
		val5.set_BackHatchStyle((BackHatchStyle)2);
		((UltraGridBase)ugDJWires).get_DisplayLayout().get_Override().set_RowAppearance((AppearanceBase)(object)val5);
		val6.set_BackColor(Color.FromArgb(89, 135, 214));
		val6.set_BackColor2(Color.FromArgb(7, 59, 150));
		val6.set_BackGradientStyle((GradientStyle)2);
		((UltraGridBase)ugDJWires).get_DisplayLayout().get_Override().set_RowSelectorAppearance((AppearanceBase)(object)val6);
		((UltraGridBase)ugDJWires).get_DisplayLayout().get_Override().set_RowSelectorNumberStyle((RowSelectorNumberStyle)3);
		val7.set_BackColor(Color.FromArgb(251, 230, 148));
		val7.set_BackColor2(Color.FromArgb(238, 149, 21));
		val7.set_BackGradientStyle((GradientStyle)2);
		((UltraGridBase)ugDJWires).get_DisplayLayout().get_Override().set_SelectedRowAppearance((AppearanceBase)(object)val7);
		((UltraGridBase)ugDJWires).get_DisplayLayout().get_Override().set_SelectTypeRow((SelectType)2);
		((UltraGridBase)ugDJWires).get_DisplayLayout().set_ScrollBounds((ScrollBounds)0);
		((Control)ugDJWires).set_Dock((DockStyle)5);
		((Control)ugDJWires).set_Font(new Font("Verdana", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		UltraGrid obj = ugDJWires;
		Point location = new Point(0, 0);
		((Control)obj).set_Location(location);
		((Control)ugDJWires).set_Name("ugDJWires");
		UltraGrid obj2 = ugDJWires;
		Size size = new Size(994, 693);
		((Control)obj2).set_Size(size);
		((Control)ugDJWires).set_TabIndex(5);
		((ToolStrip)ContextMenuStrip1).get_Items().AddRange((ToolStripItem[])(object)new ToolStripItem[1] { (ToolStripItem)ToolStripMenuItem1 });
		((Control)ContextMenuStrip1).set_Name("ContextMenuStrip1");
		ContextMenuStrip contextMenuStrip = ContextMenuStrip1;
		size = new Size(130, 26);
		((Control)contextMenuStrip).set_Size(size);
		((ToolStripItem)ToolStripMenuItem1).set_Name("ToolStripMenuItem1");
		ToolStripMenuItem toolStripMenuItem = ToolStripMenuItem1;
		size = new Size(129, 22);
		((ToolStripItem)toolStripMenuItem).set_Size(size);
		((ToolStripItem)ToolStripMenuItem1).set_Text("Show Story");
		Timer1.set_Enabled(true);
		Timer1.set_Interval(20000);
		size = new Size(994, 693);
		((Form)this).set_ClientSize(size);
		((Control)this).get_Controls().Add((Control)(object)ugDJWires);
		((Control)this).set_Font(new Font("Verdana", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)this).set_Name("frmDJWires");
		((Form)this).set_Text("DowJone Wires");
		((ISupportInitialize)ugDJWires).EndInit();
		((Control)ContextMenuStrip1).ResumeLayout(false);
		((Control)this).ResumeLayout(false);
	}

	private void frmDJWires_Load(object sender, EventArgs e)
	{
		Money_Splash money_Splash = new Money_Splash();
		((Control)money_Splash).Show();
		((Control)money_Splash).Refresh();
		BindControls();
		((Form)money_Splash).Close();
	}

	private void ToolStripMenuItem1_Click(object sender, EventArgs e)
	{
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		frmDJNewBody frmDJNewBody2 = new frmDJNewBody();
		frmDJNewBody2.NewsID = Conversions.ToString(((UltraGridBase)ugDJWires).get_ActiveRow().get_Cells().get_Item("NewsID")
			.get_Value());
		((Form)frmDJNewBody2).ShowDialog();
	}

	private void ugDJWires_InitializeLayout(object sender, InitializeLayoutEventArgs e)
	{
		checked
		{
			int num = ((DisposableObjectCollectionBase)e.get_Layout().get_Bands().get_Item(0)
				.get_Columns()).get_Count() - 1;
			int num2 = 0;
			while (true)
			{
				int num3 = num2;
				int num4 = num;
				if (num3 > num4)
				{
					break;
				}
				e.get_Layout().get_Bands().get_Item(0)
					.get_Columns()
					.get_Item(num2)
					.set_CellActivation((Activation)3);
				e.get_Layout().get_Bands().get_Item(0)
					.get_Override()
					.set_CellClickAction((CellClickAction)2);
				num2++;
			}
			e.get_Layout().get_Bands().get_Item(0)
				.get_Columns()
				.get_Item("DATED")
				.set_Width(50);
			e.get_Layout().get_Bands().get_Item(0)
				.get_Columns()
				.get_Item("NEWSSUB")
				.set_Width(600);
			e.get_Layout().get_Bands().get_Item(0)
				.get_Columns()
				.get_Item("NEWSSUB")
				.set_FilterOperatorDefaultValue((FilterOperatorDefaultValue)15);
			e.get_Layout().get_Bands().get_Item(0)
				.get_Columns()
				.get_Item("NEWSID")
				.set_Hidden(true);
			e.get_Layout().get_Bands().get_Item(0)
				.get_Columns()
				.get_Item("CMW_TYPE")
				.set_Hidden(true);
		}
	}

	private void ugDJWires_InitializeRow(object sender, InitializeRowEventArgs e)
	{
		if (Strings.InStr(1, Conversions.ToString(e.get_Row().get_Cells().get_Item("CMW_TYPE")
			.get_Value()), "ONE", (CompareMethod)0) > 0)
		{
			e.get_Row().get_Appearance().set_BackColor(Color.Yellow);
			e.get_Row().get_Appearance().set_ForeColor(Color.Red);
			e.get_Row().get_Appearance().get_FontData()
				.set_Bold((DefaultableBoolean)1);
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
		try
		{
			string text = "Select CMW_STORY_NUMBER AS NEWSID, CONVERT(VARCHAR(5),Transmission_datetime,108) as DATED,headline as NEWSSUB,ISNULL(CMW_TYPE,0) as CMW_TYPE from CMW_Wires order by transmission_datetime desc";
			DataTable dataSource = SqlHelper.ExecuteDataset(MySettingsProperty.Settings.strCON, CommandType.Text, text).Tables[0];
			((UltraGridBase)ugDJWires).set_DataSource((object)dataSource);
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}
}
