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
using Infragistics.Win.UltraWinGrid.ExcelExport;
using Infragistics.Win.UltraWinToolbars;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace CNBC_MONEY_2009;

[DesignerGenerated]
public class frmBonds : Form
{
	private static ArrayList __ENCList = new ArrayList();

	private IContainer components;

	[AccessedThroughProperty("ugBonds")]
	private UltraGrid _ugBonds;

	[AccessedThroughProperty("Timer1")]
	private Timer _Timer1;

	[AccessedThroughProperty("SaveFile")]
	private SaveFileDialog _SaveFile;

	[AccessedThroughProperty("UltraToolbarsManager1")]
	private UltraToolbarsManager _UltraToolbarsManager1;

	[AccessedThroughProperty("_frmBonds_Toolbars_Dock_Area_Left")]
	private UltraToolbarsDockArea __frmBonds_Toolbars_Dock_Area_Left;

	[AccessedThroughProperty("_frmBonds_Toolbars_Dock_Area_Right")]
	private UltraToolbarsDockArea __frmBonds_Toolbars_Dock_Area_Right;

	[AccessedThroughProperty("_frmBonds_Toolbars_Dock_Area_Top")]
	private UltraToolbarsDockArea __frmBonds_Toolbars_Dock_Area_Top;

	[AccessedThroughProperty("_frmBonds_Toolbars_Dock_Area_Bottom")]
	private UltraToolbarsDockArea __frmBonds_Toolbars_Dock_Area_Bottom;

	[AccessedThroughProperty("UltraGridExcelExporter1")]
	private UltraGridExcelExporter _UltraGridExcelExporter1;

	private string strSQL;

	private DataTable dt;

	internal virtual UltraGrid ugBonds
	{
		[DebuggerNonUserCode]
		get
		{
			return _ugBonds;
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
			if (_ugBonds != null)
			{
				_ugBonds.remove_InitializeRow(new InitializeRowEventHandler(ugBonds_InitializeRow));
				_ugBonds.remove_InitializeLayout(new InitializeLayoutEventHandler(ugBonds_InitializeLayout));
			}
			_ugBonds = value;
			if (_ugBonds != null)
			{
				_ugBonds.add_InitializeRow(new InitializeRowEventHandler(ugBonds_InitializeRow));
				_ugBonds.add_InitializeLayout(new InitializeLayoutEventHandler(ugBonds_InitializeLayout));
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
			if (_SaveFile != null)
			{
				((FileDialog)_SaveFile).remove_FileOk((CancelEventHandler)SaveFile_FileOk);
			}
			_SaveFile = value;
			if (_SaveFile != null)
			{
				((FileDialog)_SaveFile).add_FileOk((CancelEventHandler)SaveFile_FileOk);
			}
		}
	}

	internal virtual UltraToolbarsManager UltraToolbarsManager1
	{
		[DebuggerNonUserCode]
		get
		{
			return _UltraToolbarsManager1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			//IL_001c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0026: Expected O, but got Unknown
			//IL_0049: Unknown result type (might be due to invalid IL or missing references)
			//IL_0053: Expected O, but got Unknown
			if (_UltraToolbarsManager1 != null)
			{
				_UltraToolbarsManager1.remove_ToolClick(new ToolClickEventHandler(UltraToolbarsManager1_ToolClick));
			}
			_UltraToolbarsManager1 = value;
			if (_UltraToolbarsManager1 != null)
			{
				_UltraToolbarsManager1.add_ToolClick(new ToolClickEventHandler(UltraToolbarsManager1_ToolClick));
			}
		}
	}

	internal virtual UltraToolbarsDockArea _frmBonds_Toolbars_Dock_Area_Left
	{
		[DebuggerNonUserCode]
		get
		{
			return __frmBonds_Toolbars_Dock_Area_Left;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__frmBonds_Toolbars_Dock_Area_Left = value;
		}
	}

	internal virtual UltraToolbarsDockArea _frmBonds_Toolbars_Dock_Area_Right
	{
		[DebuggerNonUserCode]
		get
		{
			return __frmBonds_Toolbars_Dock_Area_Right;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__frmBonds_Toolbars_Dock_Area_Right = value;
		}
	}

	internal virtual UltraToolbarsDockArea _frmBonds_Toolbars_Dock_Area_Top
	{
		[DebuggerNonUserCode]
		get
		{
			return __frmBonds_Toolbars_Dock_Area_Top;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__frmBonds_Toolbars_Dock_Area_Top = value;
		}
	}

	internal virtual UltraToolbarsDockArea _frmBonds_Toolbars_Dock_Area_Bottom
	{
		[DebuggerNonUserCode]
		get
		{
			return __frmBonds_Toolbars_Dock_Area_Bottom;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__frmBonds_Toolbars_Dock_Area_Bottom = value;
		}
	}

	internal virtual UltraGridExcelExporter UltraGridExcelExporter1
	{
		[DebuggerNonUserCode]
		get
		{
			return _UltraGridExcelExporter1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_UltraGridExcelExporter1 = value;
		}
	}

	[DebuggerNonUserCode]
	public frmBonds()
	{
		((Form)this).add_Load((EventHandler)frmBonds_Load);
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
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Expected O, but got Unknown
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0056: Expected O, but got Unknown
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0062: Expected O, but got Unknown
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Expected O, but got Unknown
		//IL_0073: Unknown result type (might be due to invalid IL or missing references)
		//IL_007a: Expected O, but got Unknown
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0086: Expected O, but got Unknown
		//IL_0086: Unknown result type (might be due to invalid IL or missing references)
		//IL_008d: Expected O, but got Unknown
		//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00aa: Expected O, but got Unknown
		//IL_00ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b5: Expected O, but got Unknown
		//IL_00bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c6: Expected O, but got Unknown
		//IL_00c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d1: Expected O, but got Unknown
		//IL_00d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e2: Expected O, but got Unknown
		//IL_00e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ed: Expected O, but got Unknown
		//IL_00ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f8: Expected O, but got Unknown
		//IL_00f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0103: Expected O, but got Unknown
		//IL_0104: Unknown result type (might be due to invalid IL or missing references)
		//IL_010e: Expected O, but got Unknown
		//IL_0115: Unknown result type (might be due to invalid IL or missing references)
		//IL_011f: Expected O, but got Unknown
		//IL_03e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_03f0: Expected O, but got Unknown
		//IL_0900: Unknown result type (might be due to invalid IL or missing references)
		//IL_090a: Expected O, but got Unknown
		components = new Container();
		UltraGridBand val = new UltraGridBand("Band 0", -1);
		Appearance val2 = new Appearance();
		Appearance val3 = new Appearance();
		Appearance val4 = new Appearance();
		Appearance val5 = new Appearance();
		Appearance val6 = new Appearance();
		Appearance val7 = new Appearance();
		UltraToolbar val8 = new UltraToolbar("UltraToolbar1");
		PopupMenuTool val9 = new PopupMenuTool("File");
		PopupMenuTool val10 = new PopupMenuTool("File");
		ButtonTool val11 = new ButtonTool("ExporttoExcel");
		ButtonTool val12 = new ButtonTool("Refresh");
		ButtonTool val13 = new ButtonTool("ExporttoExcel");
		Appearance val14 = new Appearance();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(frmBonds));
		ButtonTool val15 = new ButtonTool("Refresh");
		ugBonds = new UltraGrid();
		Timer1 = new Timer(components);
		SaveFile = new SaveFileDialog();
		UltraToolbarsManager1 = new UltraToolbarsManager(components);
		_frmBonds_Toolbars_Dock_Area_Left = new UltraToolbarsDockArea();
		_frmBonds_Toolbars_Dock_Area_Right = new UltraToolbarsDockArea();
		_frmBonds_Toolbars_Dock_Area_Top = new UltraToolbarsDockArea();
		_frmBonds_Toolbars_Dock_Area_Bottom = new UltraToolbarsDockArea();
		UltraGridExcelExporter1 = new UltraGridExcelExporter(components);
		((ISupportInitialize)ugBonds).BeginInit();
		((ISupportInitialize)UltraToolbarsManager1).BeginInit();
		((Control)this).SuspendLayout();
		val2.set_BackColor(Color.Purple);
		val2.set_BackColor2(Color.Purple);
		val.get_Override().set_SelectedCellAppearance((AppearanceBase)(object)val2);
		((UltraGridBase)ugBonds).get_DisplayLayout().get_BandsSerializer().Add((object)val);
		((UltraGridBase)ugBonds).get_DisplayLayout().set_CaptionVisible((DefaultableBoolean)2);
		((UltraGridBase)ugBonds).get_DisplayLayout().set_MaxColScrollRegions(1);
		((UltraGridBase)ugBonds).get_DisplayLayout().set_MaxRowScrollRegions(1);
		((UltraGridBase)ugBonds).get_DisplayLayout().get_Override().set_AllowRowFiltering((DefaultableBoolean)1);
		val3.set_BackColor(Color.Transparent);
		((UltraGridBase)ugBonds).get_DisplayLayout().get_Override().set_CardAreaAppearance((AppearanceBase)(object)val3);
		((UltraGridBase)ugBonds).get_DisplayLayout().get_Override().set_FilterOperatorDefaultValue((FilterOperatorDefaultValue)11);
		((UltraGridBase)ugBonds).get_DisplayLayout().get_Override().set_FilterOperatorLocation((FilterOperatorLocation)3);
		((UltraGridBase)ugBonds).get_DisplayLayout().get_Override().set_FilterUIType((FilterUIType)2);
		val4.set_BackColor(Color.FromArgb(89, 135, 214));
		val4.set_BackColor2(Color.FromArgb(7, 59, 150));
		val4.set_BackGradientStyle((GradientStyle)2);
		val4.get_FontData().set_BoldAsString("True");
		val4.get_FontData().set_Name("Arial");
		val4.get_FontData().set_SizeInPoints(10f);
		val4.set_ForeColor(Color.White);
		val4.set_ThemedElementAlpha((Alpha)3);
		((UltraGridBase)ugBonds).get_DisplayLayout().get_Override().set_HeaderAppearance((AppearanceBase)(object)val4);
		((UltraGridBase)ugBonds).get_DisplayLayout().get_Override().set_HeaderClickAction((HeaderClickAction)2);
		val5.set_BackGradientAlignment((GradientAlignment)3);
		val5.set_BackGradientStyle((GradientStyle)2);
		val5.set_BackHatchStyle((BackHatchStyle)2);
		((UltraGridBase)ugBonds).get_DisplayLayout().get_Override().set_RowAppearance((AppearanceBase)(object)val5);
		val6.set_BackColor(Color.FromArgb(89, 135, 214));
		val6.set_BackColor2(Color.FromArgb(7, 59, 150));
		val6.set_BackGradientStyle((GradientStyle)2);
		((UltraGridBase)ugBonds).get_DisplayLayout().get_Override().set_RowSelectorAppearance((AppearanceBase)(object)val6);
		((UltraGridBase)ugBonds).get_DisplayLayout().get_Override().set_RowSelectorNumberStyle((RowSelectorNumberStyle)3);
		val7.set_BackColor(Color.FromArgb(251, 230, 148));
		val7.set_BackColor2(Color.FromArgb(238, 149, 21));
		val7.set_BackGradientStyle((GradientStyle)2);
		((UltraGridBase)ugBonds).get_DisplayLayout().get_Override().set_SelectedRowAppearance((AppearanceBase)(object)val7);
		((UltraGridBase)ugBonds).get_DisplayLayout().get_Override().set_SelectTypeRow((SelectType)2);
		((UltraGridBase)ugBonds).get_DisplayLayout().set_ScrollBounds((ScrollBounds)0);
		((Control)ugBonds).set_Dock((DockStyle)5);
		((Control)ugBonds).set_Font(new Font("Verdana", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		UltraGrid obj = ugBonds;
		Point location = new Point(4, 50);
		((Control)obj).set_Location(location);
		((Control)ugBonds).set_Name("ugBonds");
		UltraGrid obj2 = ugBonds;
		Size size = new Size(927, 693);
		((Control)obj2).set_Size(size);
		((Control)ugBonds).set_TabIndex(4);
		Timer1.set_Enabled(true);
		Timer1.set_Interval(120000);
		UltraToolbarsManager1.set_DesignerFlags(1);
		UltraToolbarsManager1.set_DockWithinContainer((Control)(object)this);
		UltraToolbarsManager1.set_Office2007UICompatibility(false);
		UltraToolbarsManager1.get_Ribbon().get_ApplicationMenu().set_Visible(false);
		UltraToolbarsManager1.get_Ribbon().get_QuickAccessToolbar().set_Visible(false);
		UltraToolbarsManager1.get_Ribbon().set_Visible(true);
		UltraToolbarsManager1.set_ShowFullMenusDelay(500);
		val8.set_DockedColumn(0);
		val8.set_DockedRow(0);
		val8.set_Text("UltraToolbar1");
		((ToolsCollectionBase)((UltraToolbarBase)val8).get_Tools()).AddRange((ToolBase[])(object)new ToolBase[1] { (ToolBase)val9 });
		UltraToolbarsManager1.get_Toolbars().AddRange((UltraToolbar[])(object)new UltraToolbar[1] { val8 });
		((ToolPropsBase)((ToolBase)val10).get_SharedProps()).set_Caption("File");
		((ToolsCollectionBase)val10.get_Tools()).AddRange((ToolBase[])(object)new ToolBase[2]
		{
			(ToolBase)val11,
			(ToolBase)val12
		});
		val14.set_Image(RuntimeHelpers.GetObjectValue(componentResourceManager.GetObject("Appearance7.Image")));
		((ToolPropsBase)((ToolBase)val13).get_SharedProps()).get_AppearancesSmall().set_Appearance((AppearanceBase)(object)val14);
		((ToolPropsBase)((ToolBase)val13).get_SharedProps()).set_Caption("Export to Excel");
		((ToolBase)val13).get_SharedProps().set_Shortcut((Shortcut)131141);
		((ToolPropsBase)((ToolBase)val15).get_SharedProps()).set_Caption("Refresh");
		((ToolBase)val15).get_SharedProps().set_Shortcut((Shortcut)116);
		UltraToolbarsManager1.get_Tools().AddRange((ToolBase[])(object)new ToolBase[3]
		{
			(ToolBase)val10,
			(ToolBase)val13,
			(ToolBase)val15
		});
		((Control)_frmBonds_Toolbars_Dock_Area_Left).set_AccessibleRole((AccessibleRole)20);
		((Control)_frmBonds_Toolbars_Dock_Area_Left).set_BackColor(Color.FromArgb(191, 219, 255));
		_frmBonds_Toolbars_Dock_Area_Left.set_DockedPosition((DockedPosition)2);
		((Control)_frmBonds_Toolbars_Dock_Area_Left).set_ForeColor(SystemColors.ControlText);
		_frmBonds_Toolbars_Dock_Area_Left.set_InitialResizeAreaExtent(4);
		UltraToolbarsDockArea frmBonds_Toolbars_Dock_Area_Left = _frmBonds_Toolbars_Dock_Area_Left;
		location = new Point(0, 50);
		((Control)frmBonds_Toolbars_Dock_Area_Left).set_Location(location);
		((Control)_frmBonds_Toolbars_Dock_Area_Left).set_Name("_frmBonds_Toolbars_Dock_Area_Left");
		UltraToolbarsDockArea frmBonds_Toolbars_Dock_Area_Left2 = _frmBonds_Toolbars_Dock_Area_Left;
		size = new Size(4, 693);
		((Control)frmBonds_Toolbars_Dock_Area_Left2).set_Size(size);
		_frmBonds_Toolbars_Dock_Area_Left.set_ToolbarsManager(UltraToolbarsManager1);
		((Control)_frmBonds_Toolbars_Dock_Area_Right).set_AccessibleRole((AccessibleRole)20);
		((Control)_frmBonds_Toolbars_Dock_Area_Right).set_BackColor(Color.FromArgb(191, 219, 255));
		_frmBonds_Toolbars_Dock_Area_Right.set_DockedPosition((DockedPosition)3);
		((Control)_frmBonds_Toolbars_Dock_Area_Right).set_ForeColor(SystemColors.ControlText);
		_frmBonds_Toolbars_Dock_Area_Right.set_InitialResizeAreaExtent(4);
		UltraToolbarsDockArea frmBonds_Toolbars_Dock_Area_Right = _frmBonds_Toolbars_Dock_Area_Right;
		location = new Point(931, 50);
		((Control)frmBonds_Toolbars_Dock_Area_Right).set_Location(location);
		((Control)_frmBonds_Toolbars_Dock_Area_Right).set_Name("_frmBonds_Toolbars_Dock_Area_Right");
		UltraToolbarsDockArea frmBonds_Toolbars_Dock_Area_Right2 = _frmBonds_Toolbars_Dock_Area_Right;
		size = new Size(4, 693);
		((Control)frmBonds_Toolbars_Dock_Area_Right2).set_Size(size);
		_frmBonds_Toolbars_Dock_Area_Right.set_ToolbarsManager(UltraToolbarsManager1);
		((Control)_frmBonds_Toolbars_Dock_Area_Top).set_AccessibleRole((AccessibleRole)20);
		((Control)_frmBonds_Toolbars_Dock_Area_Top).set_BackColor(Color.FromArgb(191, 219, 255));
		_frmBonds_Toolbars_Dock_Area_Top.set_DockedPosition((DockedPosition)0);
		((Control)_frmBonds_Toolbars_Dock_Area_Top).set_ForeColor(SystemColors.ControlText);
		UltraToolbarsDockArea frmBonds_Toolbars_Dock_Area_Top = _frmBonds_Toolbars_Dock_Area_Top;
		location = new Point(0, 0);
		((Control)frmBonds_Toolbars_Dock_Area_Top).set_Location(location);
		((Control)_frmBonds_Toolbars_Dock_Area_Top).set_Name("_frmBonds_Toolbars_Dock_Area_Top");
		UltraToolbarsDockArea frmBonds_Toolbars_Dock_Area_Top2 = _frmBonds_Toolbars_Dock_Area_Top;
		size = new Size(935, 50);
		((Control)frmBonds_Toolbars_Dock_Area_Top2).set_Size(size);
		_frmBonds_Toolbars_Dock_Area_Top.set_ToolbarsManager(UltraToolbarsManager1);
		((Control)_frmBonds_Toolbars_Dock_Area_Bottom).set_AccessibleRole((AccessibleRole)20);
		((Control)_frmBonds_Toolbars_Dock_Area_Bottom).set_BackColor(Color.FromArgb(191, 219, 255));
		_frmBonds_Toolbars_Dock_Area_Bottom.set_DockedPosition((DockedPosition)1);
		((Control)_frmBonds_Toolbars_Dock_Area_Bottom).set_ForeColor(SystemColors.ControlText);
		_frmBonds_Toolbars_Dock_Area_Bottom.set_InitialResizeAreaExtent(4);
		UltraToolbarsDockArea frmBonds_Toolbars_Dock_Area_Bottom = _frmBonds_Toolbars_Dock_Area_Bottom;
		location = new Point(0, 743);
		((Control)frmBonds_Toolbars_Dock_Area_Bottom).set_Location(location);
		((Control)_frmBonds_Toolbars_Dock_Area_Bottom).set_Name("_frmBonds_Toolbars_Dock_Area_Bottom");
		UltraToolbarsDockArea frmBonds_Toolbars_Dock_Area_Bottom2 = _frmBonds_Toolbars_Dock_Area_Bottom;
		size = new Size(935, 4);
		((Control)frmBonds_Toolbars_Dock_Area_Bottom2).set_Size(size);
		_frmBonds_Toolbars_Dock_Area_Bottom.set_ToolbarsManager(UltraToolbarsManager1);
		size = new Size(935, 747);
		((Form)this).set_ClientSize(size);
		((Control)this).get_Controls().Add((Control)(object)ugBonds);
		((Control)this).get_Controls().Add((Control)(object)_frmBonds_Toolbars_Dock_Area_Left);
		((Control)this).get_Controls().Add((Control)(object)_frmBonds_Toolbars_Dock_Area_Right);
		((Control)this).get_Controls().Add((Control)(object)_frmBonds_Toolbars_Dock_Area_Top);
		((Control)this).get_Controls().Add((Control)(object)_frmBonds_Toolbars_Dock_Area_Bottom);
		((Control)this).set_Font(new Font("Verdana", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)this).set_Name("frmBonds");
		((Form)this).set_ShowIcon(false);
		((Form)this).set_Text("BONDS");
		((ISupportInitialize)ugBonds).EndInit();
		((ISupportInitialize)UltraToolbarsManager1).EndInit();
		((Control)this).ResumeLayout(false);
	}

	private void frmBonds_Load(object sender, EventArgs e)
	{
		BindControls();
	}

	private void ugBonds_InitializeLayout(object sender, InitializeLayoutEventArgs e)
	{
		e.get_Layout().get_Bands().get_Item(0)
			.get_Columns()
			.get_Item("Eng Name")
			.set_Width(200);
		e.get_Layout().get_Bands().get_Item(0)
			.get_Override()
			.set_CellClickAction((CellClickAction)2);
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
					if (num2 > 0)
					{
						e.get_Layout().get_Bands().get_Item(0)
							.get_Columns()
							.get_Item(num2)
							.set_FilterOperatorDefaultValue((FilterOperatorDefaultValue)6);
						e.get_Layout().get_Bands().get_Item(0)
							.get_Columns()
							.get_Item(num2)
							.get_CellAppearance()
							.set_TextHAlign((HAlign)3);
					}
					else
					{
						e.get_Layout().get_Bands().get_Item(0)
							.get_Columns()
							.get_Item(num2)
							.set_FilterOperatorDefaultValue((FilterOperatorDefaultValue)11);
					}
					num2++;
					continue;
				}
				break;
			}
		}
	}

	private void ugBonds_InitializeRow(object sender, InitializeRowEventArgs e)
	{
		double num = Conversions.ToDouble(e.get_Row().get_Cells().get_Item("Change")
			.get_Value());
		double num2 = num;
		if (num2 == 0.0)
		{
			e.get_Row().get_Appearance().set_ForeColor(MySettingsProperty.Settings.COLOR_CHANGE_E_ZERO);
		}
		else if (num2 > 0.0)
		{
			e.get_Row().get_Appearance().set_ForeColor(MySettingsProperty.Settings.COLOR_CHANGE_G_ZERO);
		}
		else if (num2 < 0.0)
		{
			e.get_Row().get_Appearance().set_ForeColor(MySettingsProperty.Settings.COLOR_CHANGE_L_ZERO);
		}
	}

	private void Timer1_Tick(object sender, EventArgs e)
	{
		Timer1.set_Enabled(false);
		BindControls();
		Timer1.set_Enabled(true);
	}

	private void UltraToolbarsManager1_ToolClick(object sender, ToolClickEventArgs e)
	{
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			string text = Strings.UCase(((ToolEventArgs)e).get_Tool().get_Key());
			if (Operators.CompareString(text, "EXPORTTOEXCEL", false) == 0)
			{
				((FileDialog)SaveFile).set_Filter("xls (*.xls)|*.xls|All files|*.*");
				((CommonDialog)SaveFile).ShowDialog();
			}
			else if (Operators.CompareString(text, "REFRESH", false) == 0)
			{
				BindControls();
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	private void SaveFile_FileOk(object sender, CancelEventArgs e)
	{
		try
		{
			UltraGridExcelExporter1.Export(ugBonds, ((FileDialog)SaveFile).get_FileName());
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			mdlMain.ShowMessage("Specified Path Does Not Exist", "Invalid File Name");
			ProjectData.ClearProjectError();
		}
	}

	private void BindControls()
	{
		Money_Splash money_Splash = new Money_Splash();
		try
		{
			((Control)money_Splash).Show();
			((Control)money_Splash).Refresh();
			strSQL = "SELECT EngName as [Eng Name],  convert(decimal(10,4),LastPrice) AS [Last Price], convert(decimal(10,4),Change) AS Change, convert(decimal(10,4),PercentChange) AS [% Change],   convert(decimal(10,4),[Close]) AS [Close], convert(decimal(10,4),CYield) AS CYield,  PYield , convert(decimal(10,4),CYield - PYield) AS YieldChange,  CASE WHEN PYield = 0 THEN 0.0000 ELSE convert(decimal(10,4),((CYield - PYield)/PYield) * 100) END AS [% Yield Change]   FROM Bond007Master";
			dt = new DataTable();
			dt = SqlHelper.ExecuteDataset(MySettingsProperty.Settings.strCON, CommandType.Text, strSQL).Tables[0];
			((UltraGridBase)ugBonds).set_DataSource((object)dt);
			((Form)money_Splash).Close();
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			((Form)money_Splash).Close();
			ProjectData.ClearProjectError();
		}
	}
}
