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
public class frmForex : Form
{
	private static ArrayList __ENCList = new ArrayList();

	private IContainer components;

	[AccessedThroughProperty("ugForex")]
	private UltraGrid _ugForex;

	[AccessedThroughProperty("Timer1")]
	private Timer _Timer1;

	[AccessedThroughProperty("SaveFile")]
	private SaveFileDialog _SaveFile;

	[AccessedThroughProperty("UltraGridExcelExporter1")]
	private UltraGridExcelExporter _UltraGridExcelExporter1;

	[AccessedThroughProperty("UltraToolbarsManager1")]
	private UltraToolbarsManager _UltraToolbarsManager1;

	[AccessedThroughProperty("_frmForex_Toolbars_Dock_Area_Left")]
	private UltraToolbarsDockArea __frmForex_Toolbars_Dock_Area_Left;

	[AccessedThroughProperty("_frmForex_Toolbars_Dock_Area_Right")]
	private UltraToolbarsDockArea __frmForex_Toolbars_Dock_Area_Right;

	[AccessedThroughProperty("_frmForex_Toolbars_Dock_Area_Top")]
	private UltraToolbarsDockArea __frmForex_Toolbars_Dock_Area_Top;

	[AccessedThroughProperty("_frmForex_Toolbars_Dock_Area_Bottom")]
	private UltraToolbarsDockArea __frmForex_Toolbars_Dock_Area_Bottom;

	internal virtual UltraGrid ugForex
	{
		[DebuggerNonUserCode]
		get
		{
			return _ugForex;
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
			if (_ugForex != null)
			{
				_ugForex.remove_InitializeLayout(new InitializeLayoutEventHandler(ugForex_InitializeLayout));
				_ugForex.remove_InitializeRow(new InitializeRowEventHandler(ugForex_InitializeRow));
			}
			_ugForex = value;
			if (_ugForex != null)
			{
				_ugForex.add_InitializeLayout(new InitializeLayoutEventHandler(ugForex_InitializeLayout));
				_ugForex.add_InitializeRow(new InitializeRowEventHandler(ugForex_InitializeRow));
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

	internal virtual UltraToolbarsDockArea _frmForex_Toolbars_Dock_Area_Left
	{
		[DebuggerNonUserCode]
		get
		{
			return __frmForex_Toolbars_Dock_Area_Left;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__frmForex_Toolbars_Dock_Area_Left = value;
		}
	}

	internal virtual UltraToolbarsDockArea _frmForex_Toolbars_Dock_Area_Right
	{
		[DebuggerNonUserCode]
		get
		{
			return __frmForex_Toolbars_Dock_Area_Right;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__frmForex_Toolbars_Dock_Area_Right = value;
		}
	}

	internal virtual UltraToolbarsDockArea _frmForex_Toolbars_Dock_Area_Top
	{
		[DebuggerNonUserCode]
		get
		{
			return __frmForex_Toolbars_Dock_Area_Top;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__frmForex_Toolbars_Dock_Area_Top = value;
		}
	}

	internal virtual UltraToolbarsDockArea _frmForex_Toolbars_Dock_Area_Bottom
	{
		[DebuggerNonUserCode]
		get
		{
			return __frmForex_Toolbars_Dock_Area_Bottom;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__frmForex_Toolbars_Dock_Area_Bottom = value;
		}
	}

	[DebuggerNonUserCode]
	public frmForex()
	{
		((Form)this).add_Load((EventHandler)frmForex_Load);
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
		//IL_00aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b1: Expected O, but got Unknown
		//IL_00b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bc: Expected O, but got Unknown
		//IL_00c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cd: Expected O, but got Unknown
		//IL_00ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d8: Expected O, but got Unknown
		//IL_00df: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e9: Expected O, but got Unknown
		//IL_00f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fa: Expected O, but got Unknown
		//IL_00fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0105: Expected O, but got Unknown
		//IL_0106: Unknown result type (might be due to invalid IL or missing references)
		//IL_0110: Expected O, but got Unknown
		//IL_0111: Unknown result type (might be due to invalid IL or missing references)
		//IL_011b: Expected O, but got Unknown
		//IL_011c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0126: Expected O, but got Unknown
		//IL_03ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_03f7: Expected O, but got Unknown
		//IL_0952: Unknown result type (might be due to invalid IL or missing references)
		//IL_095c: Expected O, but got Unknown
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
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(frmForex));
		ButtonTool val15 = new ButtonTool("Refresh");
		Appearance val16 = new Appearance();
		ugForex = new UltraGrid();
		Timer1 = new Timer(components);
		SaveFile = new SaveFileDialog();
		UltraGridExcelExporter1 = new UltraGridExcelExporter(components);
		UltraToolbarsManager1 = new UltraToolbarsManager(components);
		_frmForex_Toolbars_Dock_Area_Left = new UltraToolbarsDockArea();
		_frmForex_Toolbars_Dock_Area_Right = new UltraToolbarsDockArea();
		_frmForex_Toolbars_Dock_Area_Top = new UltraToolbarsDockArea();
		_frmForex_Toolbars_Dock_Area_Bottom = new UltraToolbarsDockArea();
		((ISupportInitialize)ugForex).BeginInit();
		((ISupportInitialize)UltraToolbarsManager1).BeginInit();
		((Control)this).SuspendLayout();
		val2.set_BackColor(Color.Purple);
		val2.set_BackColor2(Color.Purple);
		val.get_Override().set_SelectedCellAppearance((AppearanceBase)(object)val2);
		((UltraGridBase)ugForex).get_DisplayLayout().get_BandsSerializer().Add((object)val);
		((UltraGridBase)ugForex).get_DisplayLayout().set_CaptionVisible((DefaultableBoolean)2);
		((UltraGridBase)ugForex).get_DisplayLayout().set_MaxColScrollRegions(1);
		((UltraGridBase)ugForex).get_DisplayLayout().set_MaxRowScrollRegions(1);
		((UltraGridBase)ugForex).get_DisplayLayout().get_Override().set_AllowRowFiltering((DefaultableBoolean)1);
		val3.set_BackColor(Color.Transparent);
		((UltraGridBase)ugForex).get_DisplayLayout().get_Override().set_CardAreaAppearance((AppearanceBase)(object)val3);
		((UltraGridBase)ugForex).get_DisplayLayout().get_Override().set_FilterOperatorDefaultValue((FilterOperatorDefaultValue)11);
		((UltraGridBase)ugForex).get_DisplayLayout().get_Override().set_FilterOperatorLocation((FilterOperatorLocation)3);
		((UltraGridBase)ugForex).get_DisplayLayout().get_Override().set_FilterUIType((FilterUIType)2);
		val4.set_BackColor(Color.FromArgb(89, 135, 214));
		val4.set_BackColor2(Color.FromArgb(7, 59, 150));
		val4.set_BackGradientStyle((GradientStyle)2);
		val4.get_FontData().set_BoldAsString("True");
		val4.get_FontData().set_Name("Arial");
		val4.get_FontData().set_SizeInPoints(10f);
		val4.set_ForeColor(Color.White);
		val4.set_ThemedElementAlpha((Alpha)3);
		((UltraGridBase)ugForex).get_DisplayLayout().get_Override().set_HeaderAppearance((AppearanceBase)(object)val4);
		((UltraGridBase)ugForex).get_DisplayLayout().get_Override().set_HeaderClickAction((HeaderClickAction)2);
		val5.set_BackGradientAlignment((GradientAlignment)3);
		val5.set_BackGradientStyle((GradientStyle)2);
		val5.set_BackHatchStyle((BackHatchStyle)2);
		((UltraGridBase)ugForex).get_DisplayLayout().get_Override().set_RowAppearance((AppearanceBase)(object)val5);
		val6.set_BackColor(Color.FromArgb(89, 135, 214));
		val6.set_BackColor2(Color.FromArgb(7, 59, 150));
		val6.set_BackGradientStyle((GradientStyle)2);
		((UltraGridBase)ugForex).get_DisplayLayout().get_Override().set_RowSelectorAppearance((AppearanceBase)(object)val6);
		((UltraGridBase)ugForex).get_DisplayLayout().get_Override().set_RowSelectorNumberStyle((RowSelectorNumberStyle)3);
		val7.set_BackColor(Color.FromArgb(251, 230, 148));
		val7.set_BackColor2(Color.FromArgb(238, 149, 21));
		val7.set_BackGradientStyle((GradientStyle)2);
		((UltraGridBase)ugForex).get_DisplayLayout().get_Override().set_SelectedRowAppearance((AppearanceBase)(object)val7);
		((UltraGridBase)ugForex).get_DisplayLayout().get_Override().set_SelectTypeRow((SelectType)2);
		((UltraGridBase)ugForex).get_DisplayLayout().set_ScrollBounds((ScrollBounds)0);
		((Control)ugForex).set_Dock((DockStyle)5);
		((Control)ugForex).set_Font(new Font("Verdana", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		UltraGrid obj = ugForex;
		Point location = new Point(4, 50);
		((Control)obj).set_Location(location);
		((Control)ugForex).set_Name("ugForex");
		UltraGrid obj2 = ugForex;
		Size size = new Size(685, 272);
		((Control)obj2).set_Size(size);
		((Control)ugForex).set_TabIndex(5);
		Timer1.set_Enabled(true);
		Timer1.set_Interval(15000);
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
		val16.set_Image(RuntimeHelpers.GetObjectValue(componentResourceManager.GetObject("Appearance8.Image")));
		((ToolPropsBase)((ToolBase)val15).get_SharedProps()).get_AppearancesSmall().set_Appearance((AppearanceBase)(object)val16);
		((ToolPropsBase)((ToolBase)val15).get_SharedProps()).set_Caption("Refresh");
		((ToolBase)val15).get_SharedProps().set_Shortcut((Shortcut)116);
		UltraToolbarsManager1.get_Tools().AddRange((ToolBase[])(object)new ToolBase[3]
		{
			(ToolBase)val10,
			(ToolBase)val13,
			(ToolBase)val15
		});
		((Control)_frmForex_Toolbars_Dock_Area_Left).set_AccessibleRole((AccessibleRole)20);
		((Control)_frmForex_Toolbars_Dock_Area_Left).set_BackColor(Color.FromArgb(191, 219, 255));
		_frmForex_Toolbars_Dock_Area_Left.set_DockedPosition((DockedPosition)2);
		((Control)_frmForex_Toolbars_Dock_Area_Left).set_ForeColor(SystemColors.ControlText);
		_frmForex_Toolbars_Dock_Area_Left.set_InitialResizeAreaExtent(4);
		UltraToolbarsDockArea frmForex_Toolbars_Dock_Area_Left = _frmForex_Toolbars_Dock_Area_Left;
		location = new Point(0, 50);
		((Control)frmForex_Toolbars_Dock_Area_Left).set_Location(location);
		((Control)_frmForex_Toolbars_Dock_Area_Left).set_Name("_frmForex_Toolbars_Dock_Area_Left");
		UltraToolbarsDockArea frmForex_Toolbars_Dock_Area_Left2 = _frmForex_Toolbars_Dock_Area_Left;
		size = new Size(4, 272);
		((Control)frmForex_Toolbars_Dock_Area_Left2).set_Size(size);
		_frmForex_Toolbars_Dock_Area_Left.set_ToolbarsManager(UltraToolbarsManager1);
		((Control)_frmForex_Toolbars_Dock_Area_Right).set_AccessibleRole((AccessibleRole)20);
		((Control)_frmForex_Toolbars_Dock_Area_Right).set_BackColor(Color.FromArgb(191, 219, 255));
		_frmForex_Toolbars_Dock_Area_Right.set_DockedPosition((DockedPosition)3);
		((Control)_frmForex_Toolbars_Dock_Area_Right).set_ForeColor(SystemColors.ControlText);
		_frmForex_Toolbars_Dock_Area_Right.set_InitialResizeAreaExtent(4);
		UltraToolbarsDockArea frmForex_Toolbars_Dock_Area_Right = _frmForex_Toolbars_Dock_Area_Right;
		location = new Point(689, 50);
		((Control)frmForex_Toolbars_Dock_Area_Right).set_Location(location);
		((Control)_frmForex_Toolbars_Dock_Area_Right).set_Name("_frmForex_Toolbars_Dock_Area_Right");
		UltraToolbarsDockArea frmForex_Toolbars_Dock_Area_Right2 = _frmForex_Toolbars_Dock_Area_Right;
		size = new Size(4, 272);
		((Control)frmForex_Toolbars_Dock_Area_Right2).set_Size(size);
		_frmForex_Toolbars_Dock_Area_Right.set_ToolbarsManager(UltraToolbarsManager1);
		((Control)_frmForex_Toolbars_Dock_Area_Top).set_AccessibleRole((AccessibleRole)20);
		((Control)_frmForex_Toolbars_Dock_Area_Top).set_BackColor(Color.FromArgb(191, 219, 255));
		_frmForex_Toolbars_Dock_Area_Top.set_DockedPosition((DockedPosition)0);
		((Control)_frmForex_Toolbars_Dock_Area_Top).set_ForeColor(SystemColors.ControlText);
		UltraToolbarsDockArea frmForex_Toolbars_Dock_Area_Top = _frmForex_Toolbars_Dock_Area_Top;
		location = new Point(0, 0);
		((Control)frmForex_Toolbars_Dock_Area_Top).set_Location(location);
		((Control)_frmForex_Toolbars_Dock_Area_Top).set_Name("_frmForex_Toolbars_Dock_Area_Top");
		UltraToolbarsDockArea frmForex_Toolbars_Dock_Area_Top2 = _frmForex_Toolbars_Dock_Area_Top;
		size = new Size(693, 50);
		((Control)frmForex_Toolbars_Dock_Area_Top2).set_Size(size);
		_frmForex_Toolbars_Dock_Area_Top.set_ToolbarsManager(UltraToolbarsManager1);
		((Control)_frmForex_Toolbars_Dock_Area_Bottom).set_AccessibleRole((AccessibleRole)20);
		((Control)_frmForex_Toolbars_Dock_Area_Bottom).set_BackColor(Color.FromArgb(191, 219, 255));
		_frmForex_Toolbars_Dock_Area_Bottom.set_DockedPosition((DockedPosition)1);
		((Control)_frmForex_Toolbars_Dock_Area_Bottom).set_ForeColor(SystemColors.ControlText);
		_frmForex_Toolbars_Dock_Area_Bottom.set_InitialResizeAreaExtent(4);
		UltraToolbarsDockArea frmForex_Toolbars_Dock_Area_Bottom = _frmForex_Toolbars_Dock_Area_Bottom;
		location = new Point(0, 322);
		((Control)frmForex_Toolbars_Dock_Area_Bottom).set_Location(location);
		((Control)_frmForex_Toolbars_Dock_Area_Bottom).set_Name("_frmForex_Toolbars_Dock_Area_Bottom");
		UltraToolbarsDockArea frmForex_Toolbars_Dock_Area_Bottom2 = _frmForex_Toolbars_Dock_Area_Bottom;
		size = new Size(693, 4);
		((Control)frmForex_Toolbars_Dock_Area_Bottom2).set_Size(size);
		_frmForex_Toolbars_Dock_Area_Bottom.set_ToolbarsManager(UltraToolbarsManager1);
		SizeF autoScaleDimensions = new SizeF(7f, 13f);
		((ContainerControl)this).set_AutoScaleDimensions(autoScaleDimensions);
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		size = new Size(693, 326);
		((Form)this).set_ClientSize(size);
		((Control)this).get_Controls().Add((Control)(object)ugForex);
		((Control)this).get_Controls().Add((Control)(object)_frmForex_Toolbars_Dock_Area_Left);
		((Control)this).get_Controls().Add((Control)(object)_frmForex_Toolbars_Dock_Area_Right);
		((Control)this).get_Controls().Add((Control)(object)_frmForex_Toolbars_Dock_Area_Top);
		((Control)this).get_Controls().Add((Control)(object)_frmForex_Toolbars_Dock_Area_Bottom);
		((Control)this).set_Font(new Font("Verdana", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)this).set_Name("frmForex");
		((Form)this).set_ShowIcon(false);
		((Form)this).set_Text("FOREX");
		((ISupportInitialize)ugForex).EndInit();
		((ISupportInitialize)UltraToolbarsManager1).EndInit();
		((Control)this).ResumeLayout(false);
	}

	private void frmForex_Load(object sender, EventArgs e)
	{
		BindControls();
	}

	private void ugForex_InitializeLayout(object sender, InitializeLayoutEventArgs e)
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
				if (num3 <= num4)
				{
					e.get_Layout().get_Bands().get_Item(0)
						.get_Columns()
						.get_Item(num2)
						.set_CellActivation((Activation)3);
					e.get_Layout().get_Bands().get_Item(0)
						.get_Override()
						.set_CellClickAction((CellClickAction)2);
					if (num2 > 4)
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

	private void ugForex_InitializeRow(object sender, InitializeRowEventArgs e)
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
			UltraGridExcelExporter1.Export(ugForex, ((FileDialog)SaveFile).get_FileName());
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
			DataTable dataTable = new DataTable();
			string text = "Select a.Series as Seriess,a.Market_type as Mkt_Type ,Exchangesymbol,BRIDGESYMBOL,shortname as Name,LastPrice,convert(decimal(10,2), [LastPrice]-[Close]) as Change ,convert(decimal(10,2) , ((LastPrice-[Close])/[CLOSE])*100) as PercentChange,convert(decimal(10,0), Volume) as Volume,[CLOSE] as Prevday_Closing ,ISNULL(WEEKHIGH52,0) as WEEKHIGH52,ISNULL(WEEKLOW52,0) as WEEKLOW52 ,ISNULL(LIFETIMEHIGH,0) as LIFETIMEHIGH ,ISNULL(LIFETIMELOW,0) as LIFETIMELOW, (ISNULL(LastPrice,0) *ISNULL(VOLUME,0)) as Turnover ,ISNULL(UPPER_CIRCUIT,0) as UpperC ,ISNULL(LOWER_CIRCUIT,0) as LowerC,ISNULL(DAY_10_AVERAGE,0) as DAY_10_AVERAGE,ISNULL(SHAREOUTSTANDING,0) as SHAREOUTSTANDING ,ISNULL([OPEN],0)  as OPENN,ISNULL(HIGH,0)  as HIGH,ISNULL(LOW,0)  as LOW from  equity_transaction_data a where  LastPrice is not null AND [CLOSE] IS NOT NULL AND [CLOSE]<>0 and series='FX' and CMW=1 order by name";
			dataTable = SqlHelper.ExecuteDataset(MySettingsProperty.Settings.strCON, CommandType.Text, text).Tables[0];
			((UltraGridBase)ugForex).set_DataSource((object)dataTable);
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
