using System;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Net;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.ApplicationServices;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.Devices;
using z1Y;

namespace Hk29;

[DesignerGenerated]
public class Wg15 : Form
{
	private IContainer components;

	protected SqlConnection Conn;

	public bool login_yn;

	private object i_conn;

	private string dbid;

	private string dbpw;

	private readonly object i_cmd;

	private readonly object eShortcut;

	internal virtual object DotNetBarManager1
	{
		[CompilerGenerated]
		get
		{
			return _DotNetBarManager1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			_DotNetBarManager1 = RuntimeHelpers.GetObjectValue(value);
		}
	}

	internal virtual object BottomDock
	{
		[CompilerGenerated]
		get
		{
			return _BottomDock;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			_BottomDock = RuntimeHelpers.GetObjectValue(value);
		}
	}

	internal virtual object LeftDock
	{
		[CompilerGenerated]
		get
		{
			return _LeftDock;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			_LeftDock = RuntimeHelpers.GetObjectValue(value);
		}
	}

	internal virtual object RightDock
	{
		[CompilerGenerated]
		get
		{
			return _RightDock;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			_RightDock = RuntimeHelpers.GetObjectValue(value);
		}
	}

	internal virtual object TopDock
	{
		[CompilerGenerated]
		get
		{
			return _TopDock;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			_TopDock = RuntimeHelpers.GetObjectValue(value);
		}
	}

	internal virtual object ToolBarLeftDock
	{
		[CompilerGenerated]
		get
		{
			return _ToolBarLeftDock;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			_ToolBarLeftDock = RuntimeHelpers.GetObjectValue(value);
		}
	}

	internal virtual object ToolBarRightDock
	{
		[CompilerGenerated]
		get
		{
			return _ToolBarRightDock;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			_ToolBarRightDock = RuntimeHelpers.GetObjectValue(value);
		}
	}

	internal virtual object ToolBarTopDock
	{
		[CompilerGenerated]
		get
		{
			return _ToolBarTopDock;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			_ToolBarTopDock = RuntimeHelpers.GetObjectValue(value);
		}
	}

	internal virtual object ToolBarBottomDock
	{
		[CompilerGenerated]
		get
		{
			return _ToolBarBottomDock;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			_ToolBarBottomDock = RuntimeHelpers.GetObjectValue(value);
		}
	}

	internal virtual object MainMenu
	{
		[CompilerGenerated]
		get
		{
			return _MainMenu;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			_MainMenu = RuntimeHelpers.GetObjectValue(value);
		}
	}

	internal virtual object DockSite1
	{
		[CompilerGenerated]
		get
		{
			return _DockSite1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			_DockSite1 = RuntimeHelpers.GetObjectValue(value);
		}
	}

	internal virtual object TabFrm
	{
		[CompilerGenerated]
		get
		{
			return _TabFrm;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			_TabFrm = RuntimeHelpers.GetObjectValue(value);
		}
	}

	[field: AccessedThroughProperty("ImageList1")]
	internal virtual ImageList ImageList1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual object StatusBar1
	{
		[CompilerGenerated]
		get
		{
			return _StatusBar1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			_StatusBar1 = RuntimeHelpers.GetObjectValue(value);
		}
	}

	[field: AccessedThroughProperty("ImageList2")]
	internal virtual ImageList ImageList2
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual object ComboItem1
	{
		[CompilerGenerated]
		get
		{
			return _ComboItem1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			_ComboItem1 = RuntimeHelpers.GetObjectValue(value);
		}
	}

	internal virtual object ProgressBarItem1
	{
		[CompilerGenerated]
		get
		{
			return _ProgressBarItem1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			_ProgressBarItem1 = RuntimeHelpers.GetObjectValue(value);
		}
	}

	internal virtual object DockContainerItem1
	{
		[CompilerGenerated]
		get
		{
			return _DockContainerItem1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			_DockContainerItem1 = RuntimeHelpers.GetObjectValue(value);
		}
	}

	internal virtual object PanelDockContainer1
	{
		[CompilerGenerated]
		get
		{
			return _PanelDockContainer1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			_PanelDockContainer1 = RuntimeHelpers.GetObjectValue(value);
		}
	}

	internal virtual object MenuList
	{
		[CompilerGenerated]
		get
		{
			return _MenuList;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			_MenuList = RuntimeHelpers.GetObjectValue(value);
		}
	}

	internal virtual object DockContainerItem2
	{
		[CompilerGenerated]
		get
		{
			return _DockContainerItem2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			_DockContainerItem2 = RuntimeHelpers.GetObjectValue(value);
		}
	}

	internal virtual object LabelItem1
	{
		[CompilerGenerated]
		get
		{
			return _LabelItem1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			_LabelItem1 = RuntimeHelpers.GetObjectValue(value);
		}
	}

	internal virtual object ComboBoxItem1
	{
		[CompilerGenerated]
		get
		{
			return _ComboBoxItem1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			_ComboBoxItem1 = RuntimeHelpers.GetObjectValue(value);
		}
	}

	internal virtual object LabelItem2
	{
		[CompilerGenerated]
		get
		{
			return _LabelItem2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			_LabelItem2 = RuntimeHelpers.GetObjectValue(value);
		}
	}

	internal virtual object DockContainerItem4
	{
		[CompilerGenerated]
		get
		{
			return _DockContainerItem4;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			_DockContainerItem4 = RuntimeHelpers.GetObjectValue(value);
		}
	}

	internal virtual object DockContainerItem3
	{
		[CompilerGenerated]
		get
		{
			return _DockContainerItem3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			_DockContainerItem3 = RuntimeHelpers.GetObjectValue(value);
		}
	}

	internal virtual object DockContainerItem5
	{
		[CompilerGenerated]
		get
		{
			return _DockContainerItem5;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			_DockContainerItem5 = RuntimeHelpers.GetObjectValue(value);
		}
	}

	internal virtual object ContextMenuBar1
	{
		[CompilerGenerated]
		get
		{
			return _ContextMenuBar1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			_ContextMenuBar1 = RuntimeHelpers.GetObjectValue(value);
		}
	}

	internal virtual object ButtonItem1
	{
		[CompilerGenerated]
		get
		{
			return _ButtonItem1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			_ButtonItem1 = RuntimeHelpers.GetObjectValue(value);
		}
	}

	internal virtual object ButtonItem2
	{
		[CompilerGenerated]
		get
		{
			return _ButtonItem2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			_ButtonItem2 = RuntimeHelpers.GetObjectValue(value);
		}
	}

	internal virtual object ContextMenuBar2
	{
		[CompilerGenerated]
		get
		{
			return _ContextMenuBar2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			_ContextMenuBar2 = RuntimeHelpers.GetObjectValue(value);
		}
	}

	internal virtual object ButtonItem3
	{
		[CompilerGenerated]
		get
		{
			return _ButtonItem3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			_ButtonItem3 = RuntimeHelpers.GetObjectValue(value);
		}
	}

	internal virtual object ButtonItem4
	{
		[CompilerGenerated]
		get
		{
			return _ButtonItem4;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			_ButtonItem4 = RuntimeHelpers.GetObjectValue(value);
		}
	}

	internal virtual object SliderItem1
	{
		[CompilerGenerated]
		get
		{
			return _SliderItem1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			_SliderItem1 = RuntimeHelpers.GetObjectValue(value);
		}
	}

	internal virtual object RibbonBar1
	{
		[CompilerGenerated]
		get
		{
			return _RibbonBar1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			_RibbonBar1 = RuntimeHelpers.GetObjectValue(value);
		}
	}

	public object Site_id
	{
		[CompilerGenerated]
		get
		{
			return _Site_id;
		}
		[CompilerGenerated]
		set
		{
			_Site_id = RuntimeHelpers.GetObjectValue(value);
		}
	}

	public int Emp_No { get; set; }

	public object LoginFrm
	{
		[CompilerGenerated]
		get
		{
			return _LoginFrm;
		}
		[CompilerGenerated]
		set
		{
			_LoginFrm = RuntimeHelpers.GetObjectValue(value);
		}
	}

	private object db_conn
	{
		get
		{
			throw new NotImplementedException();
		}
	}

	public string SVR { get; set; }

	public int Site_nm { get; set; }

	public string Emp_Nm { get; set; }

	public object eButtonStyle
	{
		[CompilerGenerated]
		get
		{
			return _eButtonStyle;
		}
		[CompilerGenerated]
		set
		{
			_eButtonStyle = RuntimeHelpers.GetObjectValue(value);
		}
	}

	public object eOrientation
	{
		[CompilerGenerated]
		get
		{
			return _eOrientation;
		}
		[CompilerGenerated]
		set
		{
			_eOrientation = RuntimeHelpers.GetObjectValue(value);
		}
	}

	public object FrmUSPwChg
	{
		[CompilerGenerated]
		get
		{
			return _FrmUSPwChg;
		}
		[CompilerGenerated]
		set
		{
			_FrmUSPwChg = RuntimeHelpers.GetObjectValue(value);
		}
	}

	public string OP_No { get; set; }

	public string OP_Nm { get; set; }

	[DebuggerNonUserCode]
	protected override void p9T3(bool o8Y4)
	{
		try
		{
			if (o8Y4 && components != null)
			{
				components.Dispose();
			}
		}
		finally
		{
			((Form)this).Dispose(o8Y4);
		}
	}

	[DebuggerStepThrough]
	private void Ea02()
	{
		//IL_0605: Unknown result type (might be due to invalid IL or missing references)
		//IL_060b: Expected O, but got Unknown
		//IL_0740: Unknown result type (might be due to invalid IL or missing references)
		//IL_0746: Expected O, but got Unknown
		//IL_0db0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0db6: Expected O, but got Unknown
		//IL_1162: Unknown result type (might be due to invalid IL or missing references)
		//IL_1168: Expected O, but got Unknown
		//IL_1350: Unknown result type (might be due to invalid IL or missing references)
		//IL_1356: Expected O, but got Unknown
		//IL_16bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_16c1: Expected O, but got Unknown
		//IL_1a07: Unknown result type (might be due to invalid IL or missing references)
		//IL_1a0d: Expected O, but got Unknown
		//IL_1b57: Unknown result type (might be due to invalid IL or missing references)
		//IL_1b61: Expected O, but got Unknown
		//IL_254b: Unknown result type (might be due to invalid IL or missing references)
		//IL_2555: Expected O, but got Unknown
		//IL_2748: Unknown result type (might be due to invalid IL or missing references)
		//IL_2752: Expected O, but got Unknown
		//IL_275e: Unknown result type (might be due to invalid IL or missing references)
		//IL_2768: Expected O, but got Unknown
		//IL_2774: Unknown result type (might be due to invalid IL or missing references)
		//IL_277e: Expected O, but got Unknown
		//IL_278a: Unknown result type (might be due to invalid IL or missing references)
		//IL_2794: Expected O, but got Unknown
		//IL_27a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_27aa: Expected O, but got Unknown
		//IL_27b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_27c0: Expected O, but got Unknown
		//IL_27cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_27d6: Expected O, but got Unknown
		//IL_27e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_27ec: Expected O, but got Unknown
		//IL_27f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_2802: Expected O, but got Unknown
		//IL_2810: Unknown result type (might be due to invalid IL or missing references)
		//IL_281a: Expected O, but got Unknown
		//IL_282d: Unknown result type (might be due to invalid IL or missing references)
		//IL_2837: Expected O, but got Unknown
		components = new Container();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(Wg15));
		NewLateBinding.LateCall(BottomDock, (Type)null, "SuspendLayout", new object[0], (string[])null, (Type[])null, (bool[])null, true);
		((ISupportInitialize)StatusBar1).BeginInit();
		NewLateBinding.LateCall(DockSite1, (Type)null, "SuspendLayout", new object[0], (string[])null, (Type[])null, (bool[])null, true);
		((ISupportInitialize)TabFrm).BeginInit();
		NewLateBinding.LateCall(TabFrm, (Type)null, "SuspendLayout", new object[0], (string[])null, (Type[])null, (bool[])null, true);
		((ISupportInitialize)ContextMenuBar2).BeginInit();
		((ISupportInitialize)ContextMenuBar1).BeginInit();
		((ISupportInitialize)MainMenu).BeginInit();
		NewLateBinding.LateCall(MainMenu, (Type)null, "SuspendLayout", new object[0], (string[])null, (Type[])null, (bool[])null, true);
		NewLateBinding.LateCall(PanelDockContainer1, (Type)null, "SuspendLayout", new object[0], (string[])null, (Type[])null, (bool[])null, true);
		NewLateBinding.LateCall(LeftDock, (Type)null, "SuspendLayout", new object[0], (string[])null, (Type[])null, (bool[])null, true);
		((Control)this).SuspendLayout();
		NewLateBinding.LateSetComplex(DotNetBarManager1, (Type)null, "BottomDockSite", new object[1] { BottomDock }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(DotNetBarManager1, (Type)null, "DispatchShortcuts", new object[1] { true }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(DotNetBarManager1, (Type)null, "EnableFullSizeDock", new object[1] { false }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(DotNetBarManager1, (Type)null, "FillDockSite", new object[1] { DockSite1 }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(DotNetBarManager1, (Type)null, "LeftDockSite", new object[1] { LeftDock }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(DotNetBarManager1, (Type)null, "LicenseKey", new object[1] { "F962CEC7-CD8F-4911-A9E9-CAB39962FC1F" }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(DotNetBarManager1, (Type)null, "ParentForm", new object[1] { this }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(DotNetBarManager1, (Type)null, "RightDockSite", new object[1] { RightDock }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(DotNetBarManager1, (Type)null, "ShowCustomizeContextMenu", new object[1] { false }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(DotNetBarManager1, (Type)null, "ToolbarBottomDockSite", new object[1] { ToolBarBottomDock }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(DotNetBarManager1, (Type)null, "ToolbarLeftDockSite", new object[1] { ToolBarLeftDock }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(DotNetBarManager1, (Type)null, "ToolbarRightDockSite", new object[1] { ToolBarRightDock }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(DotNetBarManager1, (Type)null, "ToolbarTopDockSite", new object[1] { ToolBarTopDock }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(DotNetBarManager1, (Type)null, "TopDockSite", new object[1] { TopDock }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(DotNetBarManager1, (Type)null, "UseCustomCustomizeDialog", new object[1] { true }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(BottomDock, (Type)null, "AccessibleRole", new object[1] { (object)(AccessibleRole)9 }, (string[])null, (Type[])null, false, true);
		object obj = NewLateBinding.LateGet(BottomDock, (Type)null, "Controls", new object[0], (string[])null, (Type[])null, (bool[])null);
		object[] obj2 = new object[1] { StatusBar1 };
		object[] array = obj2;
		bool[] obj3 = new bool[1] { true };
		bool[] array2 = obj3;
		NewLateBinding.LateCall(obj, (Type)null, "Add", obj2, (string[])null, (Type[])null, obj3, true);
		if (array2[0])
		{
			StatusBar1 = RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(array[0]));
		}
		NewLateBinding.LateSetComplex(BottomDock, (Type)null, "Dock", new object[1] { (object)(DockStyle)2 }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(BottomDock, (Type)null, "Location", new object[1]
		{
			new Point(0, 707)
		}, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(BottomDock, (Type)null, "Name", new object[1] { "BottomDock" }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(BottomDock, (Type)null, "Size", new object[1]
		{
			new Size(1008, 25)
		}, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(BottomDock, (Type)null, "TabIndex", new object[1] { 4 }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(BottomDock, (Type)null, "TabStop", new object[1] { false }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(StatusBar1, (Type)null, "AccessibleDescription", new object[1] { "StatusBar1 (StatusBar1)" }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(StatusBar1, (Type)null, "AccessibleName", new object[1] { "StatusBar1" }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(StatusBar1, (Type)null, "AccessibleRole", new object[1] { (object)(AccessibleRole)22 }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(StatusBar1, (Type)null, "AutoSyncBarCaption", new object[1] { true }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(StatusBar1, (Type)null, "CloseSingleTab", new object[1] { true }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateCall(ContextMenuBar1, (Type)null, "SetContextMenuEx", array = new object[2] { StatusBar1, ButtonItem1 }, (string[])null, (Type[])null, array2 = new bool[2] { true, true }, true);
		if (array2[0])
		{
			StatusBar1 = RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(array[0]));
		}
		if (array2[1])
		{
			ButtonItem1 = RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(array[1]));
		}
		NewLateBinding.LateSetComplex(StatusBar1, (Type)null, "Dock", new object[1] { (object)(DockStyle)5 }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(StatusBar1, (Type)null, "Font", new object[1] { (object)new Font("Verdana", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0) }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(StatusBar1, (Type)null, "Location", new object[1]
		{
			new Point(0, 0)
		}, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(StatusBar1, (Type)null, "Name", new object[1] { "StatusBar1" }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(StatusBar1, (Type)null, "Size", new object[1]
		{
			new Size(1008, 25)
		}, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(StatusBar1, (Type)null, "Stretch", new object[1] { true }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(StatusBar1, (Type)null, "TabIndex", new object[1] { 0 }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(StatusBar1, (Type)null, "TabStop", new object[1] { false }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(StatusBar1, (Type)null, "Text", new object[1] { "StatusBar1" }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(LabelItem1, (Type)null, "Font", new object[1] { (object)new Font("Verdana", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0) }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(LabelItem1, (Type)null, "ForeColor", new object[1] { Color.MidnightBlue }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(LabelItem1, (Type)null, "Name", new object[1] { "LabelItem1" }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(LabelItem1, (Type)null, "TextAlignment", new object[1] { (object)(StringAlignment)1 }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(ComboBoxItem1, (Type)null, "ComboWidth", new object[1] { 200 }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(ComboBoxItem1, (Type)null, "DropDownHeight", new object[1] { 106 }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(ComboBoxItem1, (Type)null, "DropDownWidth", new object[1] { 242 }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(ComboBoxItem1, (Type)null, "Name", new object[1] { "ComboBoxItem1" }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(ComboBoxItem1, (Type)null, "Visible", new object[1] { false }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(ProgressBarItem1, (Type)null, "Name", new object[1] { "ProgressBarItem1" }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(ProgressBarItem1, (Type)null, "RecentlyUsed", new object[1] { false }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(ProgressBarItem1, (Type)null, "TextVisible", new object[1] { true }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(ProgressBarItem1, (Type)null, "Width", new object[1] { 200 }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(LabelItem2, (Type)null, "Name", new object[1] { "LabelItem2" }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(DockSite1, (Type)null, "AccessibleRole", new object[1] { (object)(AccessibleRole)9 }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateCall(NewLateBinding.LateGet(DockSite1, (Type)null, "Controls", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Add", array = new object[1] { TabFrm }, (string[])null, (Type[])null, array2 = new bool[1] { true }, true);
		if (array2[0])
		{
			TabFrm = RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(array[0]));
		}
		NewLateBinding.LateSetComplex(DockSite1, (Type)null, "Dock", new object[1] { (object)(DockStyle)5 }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(DockSite1, (Type)null, "Location", new object[1]
		{
			new Point(192, 0)
		}, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(DockSite1, (Type)null, "Name", new object[1] { "DockSite1" }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(DockSite1, (Type)null, "Size", new object[1]
		{
			new Size(816, 707)
		}, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(DockSite1, (Type)null, "TabIndex", new object[1] { 9 }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(DockSite1, (Type)null, "TabStop", new object[1] { false }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(TabFrm, (Type)null, "AccessibleDescription", new object[1] { "DotNetBar Bar (TabFrm)" }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(TabFrm, (Type)null, "AccessibleName", new object[1] { "DotNetBar Bar" }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(TabFrm, (Type)null, "AccessibleRole", new object[1] { (object)(AccessibleRole)2 }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(TabFrm, (Type)null, "AlwaysDisplayDockTab", new object[1] { true }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(TabFrm, (Type)null, "AutoHide", new object[1] { true }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(TabFrm, (Type)null, "AutoHideTabTextAlwaysVisible", new object[1] { true }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(TabFrm, (Type)null, "AutoSyncBarCaption", new object[1] { true }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(TabFrm, (Type)null, "CanCustomize", new object[1] { false }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(TabFrm, (Type)null, "CanDockDocument", new object[1] { true }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(TabFrm, (Type)null, "CanHide", new object[1] { true }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(TabFrm, (Type)null, "CanUndock", new object[1] { false }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateCall(NewLateBinding.LateGet(TabFrm, (Type)null, "Controls", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Add", array = new object[1] { RibbonBar1 }, (string[])null, (Type[])null, array2 = new bool[1] { true }, true);
		if (array2[0])
		{
			RibbonBar1 = RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(array[0]));
		}
		NewLateBinding.LateCall(NewLateBinding.LateGet(TabFrm, (Type)null, "Controls", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Add", array = new object[1] { ContextMenuBar2 }, (string[])null, (Type[])null, array2 = new bool[1] { true }, true);
		if (array2[0])
		{
			ContextMenuBar2 = RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(array[0]));
		}
		NewLateBinding.LateCall(NewLateBinding.LateGet(TabFrm, (Type)null, "Controls", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Add", array = new object[1] { ContextMenuBar1 }, (string[])null, (Type[])null, array2 = new bool[1] { true }, true);
		if (array2[0])
		{
			ContextMenuBar1 = RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(array[0]));
		}
		NewLateBinding.LateSetComplex(TabFrm, (Type)null, "DisplayMoreItemsOnMenu", new object[1] { true }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(TabFrm, (Type)null, "DockTabCloseButtonVisible", new object[1] { true }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(TabFrm, (Type)null, "Font", new object[1] { (object)new Font("Verdana", 8.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0) }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(TabFrm, (Type)null, "Images", new object[1] { ImageList2 }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(TabFrm, (Type)null, "Location", new object[1]
		{
			new Point(0, 0)
		}, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(TabFrm, (Type)null, "MenuBar", new object[1] { true }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(TabFrm, (Type)null, "Name", new object[1] { "TabFrm" }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(TabFrm, (Type)null, "Size", new object[1]
		{
			new Size(816, 707)
		}, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(TabFrm, (Type)null, "Stretch", new object[1] { true }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(TabFrm, (Type)null, "TabIndex", new object[1] { 0 }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(TabFrm, (Type)null, "TabNavigation", new object[1] { true }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(TabFrm, (Type)null, "TabStop", new object[1] { false }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(TabFrm, (Type)null, "Text", new object[1] { "MAIN" }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(RibbonBar1, (Type)null, "AutoOverflowEnabled", new object[1] { true }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(RibbonBar1, (Type)null, "ContainerControlProcessDialogKey", new object[1] { true }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateCall(ContextMenuBar2, (Type)null, "SetContextMenuEx", array = new object[2] { RibbonBar1, ButtonItem3 }, (string[])null, (Type[])null, array2 = new bool[2] { true, true }, true);
		if (array2[0])
		{
			RibbonBar1 = RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(array[0]));
		}
		if (array2[1])
		{
			ButtonItem3 = RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(array[1]));
		}
		NewLateBinding.LateSetComplex(RibbonBar1, (Type)null, "Dock", new object[1] { (object)(DockStyle)1 }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(RibbonBar1, (Type)null, "ItemSpacing", new object[1] { 10 }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(RibbonBar1, (Type)null, "LicenseKey", new object[1] { "F962CEC7-CD8F-4911-A9E9-CAB39962FC1F" }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(RibbonBar1, (Type)null, "Location", new object[1]
		{
			new Point(0, 0)
		}, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(RibbonBar1, (Type)null, "Name", new object[1] { "RibbonBar1" }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(RibbonBar1, (Type)null, "Size", new object[1]
		{
			new Size(816, 28)
		}, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(RibbonBar1, (Type)null, "TabIndex", new object[1] { 23 }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(RibbonBar1, (Type)null, "Text", new object[1] { "RibbonBar1" }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(RibbonBar1, (Type)null, "TitleVisible", new object[1] { false }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(ContextMenuBar2, (Type)null, "Font", new object[1] { (object)new Font("Malgun Gothic", 9f) }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(ContextMenuBar2, (Type)null, "Location", new object[1]
		{
			new Point(252, 236)
		}, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(ContextMenuBar2, (Type)null, "Name", new object[1] { "ContextMenuBar2" }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(ContextMenuBar2, (Type)null, "Size", new object[1]
		{
			new Size(108, 27)
		}, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(ContextMenuBar2, (Type)null, "Stretch", new object[1] { true }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(ContextMenuBar2, (Type)null, "TabIndex", new object[1] { 19 }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(ContextMenuBar2, (Type)null, "TabStop", new object[1] { false }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(ContextMenuBar2, (Type)null, "Text", new object[1] { "ContextMenuBar2" }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(ButtonItem3, (Type)null, "AutoExpandOnClick", new object[1] { true }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(ButtonItem3, (Type)null, "Name", new object[1] { "ButtonItem3" }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(ButtonItem3, (Type)null, "Text", new object[1] { "ButtonItem3" }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(ButtonItem4, (Type)null, "Name", new object[1] { "ButtonItem4" }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(ButtonItem4, (Type)null, "Text", new object[1] { "Show Side Menu" }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(ContextMenuBar1, (Type)null, "Font", new object[1] { (object)new Font("Malgun Gothic", 9f) }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(ContextMenuBar1, (Type)null, "Location", new object[1]
		{
			new Point(79, 124)
		}, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(ContextMenuBar1, (Type)null, "Name", new object[1] { "ContextMenuBar1" }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(ContextMenuBar1, (Type)null, "Size", new object[1]
		{
			new Size(102, 27)
		}, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(ContextMenuBar1, (Type)null, "Stretch", new object[1] { true }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(ContextMenuBar1, (Type)null, "TabIndex", new object[1] { 17 }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(ContextMenuBar1, (Type)null, "TabStop", new object[1] { false }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(ContextMenuBar1, (Type)null, "Text", new object[1] { "ContextMenuBar1" }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(ButtonItem1, (Type)null, "AutoExpandOnClick", new object[1] { true }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(ButtonItem1, (Type)null, "Name", new object[1] { "ButtonItem1" }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(ButtonItem1, (Type)null, "Text", new object[1] { "ButtonItem1" }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(ButtonItem2, (Type)null, "Name", new object[1] { "ButtonItem2" }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(ButtonItem2, (Type)null, "Text", new object[1] { "Show Top Menu" }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(MainMenu, (Type)null, "AccessibleDescription", new object[1] { "DotNetBar Bar (MainMenu)" }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(MainMenu, (Type)null, "AccessibleName", new object[1] { "DotNetBar Bar" }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(MainMenu, (Type)null, "AccessibleRole", new object[1] { (object)(AccessibleRole)22 }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(MainMenu, (Type)null, "AutoSyncBarCaption", new object[1] { true }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(MainMenu, (Type)null, "CloseSingleTab", new object[1] { true }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateCall(ContextMenuBar1, (Type)null, "SetContextMenuEx", array = new object[2] { MainMenu, ButtonItem1 }, (string[])null, (Type[])null, array2 = new bool[2] { true, true }, true);
		if (array2[0])
		{
			MainMenu = RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(array[0]));
		}
		if (array2[1])
		{
			ButtonItem1 = RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(array[1]));
		}
		NewLateBinding.LateCall(NewLateBinding.LateGet(MainMenu, (Type)null, "Controls", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Add", array = new object[1] { PanelDockContainer1 }, (string[])null, (Type[])null, array2 = new bool[1] { true }, true);
		if (array2[0])
		{
			PanelDockContainer1 = RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(array[0]));
		}
		NewLateBinding.LateSetComplex(MainMenu, (Type)null, "Font", new object[1] { (object)new Font("Verdana", 8.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0) }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(MainMenu, (Type)null, "Location", new object[1]
		{
			new Point(0, 0)
		}, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(MainMenu, (Type)null, "Name", new object[1] { "MainMenu" }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(MainMenu, (Type)null, "Size", new object[1]
		{
			new Size(189, 707)
		}, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(MainMenu, (Type)null, "Stretch", new object[1] { true }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(MainMenu, (Type)null, "TabIndex", new object[1] { 1 }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(MainMenu, (Type)null, "TabStop", new object[1] { false }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(MainMenu, (Type)null, "Text", new object[1] { "DockContainerItem2" }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateCall(NewLateBinding.LateGet(PanelDockContainer1, (Type)null, "Controls", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Add", array = new object[1] { MenuList }, (string[])null, (Type[])null, array2 = new bool[1] { true }, true);
		if (array2[0])
		{
			MenuList = RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(array[0]));
		}
		NewLateBinding.LateSetComplex(PanelDockContainer1, (Type)null, "Location", new object[1]
		{
			new Point(3, 23)
		}, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(PanelDockContainer1, (Type)null, "Name", new object[1] { "PanelDockContainer1" }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(PanelDockContainer1, (Type)null, "Size", new object[1]
		{
			new Size(183, 681)
		}, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(NewLateBinding.LateGet(PanelDockContainer1, (Type)null, "Style", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Alignment", new object[1] { (object)(StringAlignment)1 }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(NewLateBinding.LateGet(PanelDockContainer1, (Type)null, "Style", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "GradientAngle", new object[1] { 90 }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(PanelDockContainer1, (Type)null, "TabIndex", new object[1] { 0 }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(MenuList, (Type)null, "AccessibleRole", new object[1] { (object)(AccessibleRole)22 }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(MenuList, (Type)null, "BackColor", new object[1] { Color.FromArgb(128, 128, 255) }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(MenuList, (Type)null, "Dock", new object[1] { (object)(DockStyle)5 }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(MenuList, (Type)null, "ExpandedPanel", new object[1], (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(MenuList, (Type)null, "Font", new object[1] { (object)new Font("Malgun Gothic", 9f, (FontStyle)0, (GraphicsUnit)3, (byte)0) }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(MenuList, (Type)null, "Location", new object[1]
		{
			new Point(0, 0)
		}, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(MenuList, (Type)null, "Name", new object[1] { "MenuList" }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(MenuList, (Type)null, "Size", new object[1]
		{
			new Size(183, 681)
		}, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(MenuList, (Type)null, "TabIndex", new object[1] { 2 }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(MenuList, (Type)null, "Text", new object[1] { "Menu List" }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(DockContainerItem2, (Type)null, "Control", new object[1] { PanelDockContainer1 }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(DockContainerItem2, (Type)null, "Name", new object[1] { "DockContainerItem2" }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(DockContainerItem2, (Type)null, "Text", new object[1] { "DockContainerItem2" }, (string[])null, (Type[])null, false, true);
		ImageList2.set_ImageStream((ImageListStreamer)componentResourceManager.GetObject("ImageList2.ImageStream"));
		ImageList2.set_TransparentColor(Color.Transparent);
		ImageList2.get_Images().SetKeyName(0, "document-new.png");
		ImageList2.get_Images().SetKeyName(1, "document-open.png");
		ImageList2.get_Images().SetKeyName(2, "filesave.png");
		ImageList2.get_Images().SetKeyName(3, "edit-delete.png");
		ImageList2.get_Images().SetKeyName(4, "fileprint.png");
		ImageList2.get_Images().SetKeyName(5, "gnome-mime-application-vnd.ms-excel.png");
		NewLateBinding.LateSetComplex(LeftDock, (Type)null, "AccessibleRole", new object[1] { (object)(AccessibleRole)9 }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateCall(NewLateBinding.LateGet(LeftDock, (Type)null, "Controls", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Add", array = new object[1] { MainMenu }, (string[])null, (Type[])null, array2 = new bool[1] { true }, true);
		if (array2[0])
		{
			MainMenu = RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(array[0]));
		}
		NewLateBinding.LateSetComplex(LeftDock, (Type)null, "Dock", new object[1] { (object)(DockStyle)3 }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(LeftDock, (Type)null, "Location", new object[1]
		{
			new Point(0, 0)
		}, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(LeftDock, (Type)null, "Name", new object[1] { "LeftDock" }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(LeftDock, (Type)null, "Size", new object[1]
		{
			new Size(192, 707)
		}, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(LeftDock, (Type)null, "TabIndex", new object[1] { 1 }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(LeftDock, (Type)null, "TabStop", new object[1] { false }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(LeftDock, (Type)null, "Text", new object[1] { "LeftDock" }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(RightDock, (Type)null, "AccessibleRole", new object[1] { (object)(AccessibleRole)9 }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(RightDock, (Type)null, "Dock", new object[1] { (object)(DockStyle)4 }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(RightDock, (Type)null, "Location", new object[1]
		{
			new Point(1008, 0)
		}, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(RightDock, (Type)null, "Name", new object[1] { "RightDock" }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(RightDock, (Type)null, "Size", new object[1]
		{
			new Size(0, 707)
		}, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(RightDock, (Type)null, "TabIndex", new object[1] { 2 }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(RightDock, (Type)null, "TabStop", new object[1] { false }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(ToolBarBottomDock, (Type)null, "AccessibleRole", new object[1] { (object)(AccessibleRole)9 }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(ToolBarBottomDock, (Type)null, "Dock", new object[1] { (object)(DockStyle)2 }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(ToolBarBottomDock, (Type)null, "Location", new object[1]
		{
			new Point(0, 732)
		}, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(ToolBarBottomDock, (Type)null, "Name", new object[1] { "ToolBarBottomDock" }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(ToolBarBottomDock, (Type)null, "Size", new object[1]
		{
			new Size(1008, 0)
		}, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(ToolBarBottomDock, (Type)null, "TabIndex", new object[1] { 8 }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(ToolBarBottomDock, (Type)null, "TabStop", new object[1] { false }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(ToolBarLeftDock, (Type)null, "AccessibleRole", new object[1] { (object)(AccessibleRole)9 }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(ToolBarLeftDock, (Type)null, "Dock", new object[1] { (object)(DockStyle)3 }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(ToolBarLeftDock, (Type)null, "Location", new object[1]
		{
			new Point(0, 0)
		}, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(ToolBarLeftDock, (Type)null, "Name", new object[1] { "ToolBarLeftDock" }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(ToolBarLeftDock, (Type)null, "Size", new object[1]
		{
			new Size(0, 732)
		}, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(ToolBarLeftDock, (Type)null, "TabIndex", new object[1] { 5 }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(ToolBarLeftDock, (Type)null, "TabStop", new object[1] { false }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(ToolBarRightDock, (Type)null, "AccessibleRole", new object[1] { (object)(AccessibleRole)9 }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(ToolBarRightDock, (Type)null, "Dock", new object[1] { (object)(DockStyle)4 }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(ToolBarRightDock, (Type)null, "Location", new object[1]
		{
			new Point(1008, 0)
		}, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(ToolBarRightDock, (Type)null, "Name", new object[1] { "ToolBarRightDock" }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(ToolBarRightDock, (Type)null, "Size", new object[1]
		{
			new Size(0, 732)
		}, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(ToolBarRightDock, (Type)null, "TabIndex", new object[1] { 6 }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(ToolBarRightDock, (Type)null, "TabStop", new object[1] { false }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(ToolBarTopDock, (Type)null, "AccessibleRole", new object[1] { (object)(AccessibleRole)9 }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(ToolBarTopDock, (Type)null, "Dock", new object[1] { (object)(DockStyle)1 }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(ToolBarTopDock, (Type)null, "Location", new object[1]
		{
			new Point(0, 0)
		}, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(ToolBarTopDock, (Type)null, "Name", new object[1] { "ToolBarTopDock" }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(ToolBarTopDock, (Type)null, "Size", new object[1]
		{
			new Size(1008, 0)
		}, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(ToolBarTopDock, (Type)null, "TabIndex", new object[1] { 7 }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(ToolBarTopDock, (Type)null, "TabStop", new object[1] { false }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(ToolBarTopDock, (Type)null, "Text", new object[1] { "ToolBarTopDock" }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(TopDock, (Type)null, "AccessibleRole", new object[1] { (object)(AccessibleRole)9 }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(TopDock, (Type)null, "Dock", new object[1] { (object)(DockStyle)1 }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(TopDock, (Type)null, "Location", new object[1]
		{
			new Point(0, 0)
		}, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(TopDock, (Type)null, "Name", new object[1] { "TopDock" }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(TopDock, (Type)null, "Size", new object[1]
		{
			new Size(1008, 0)
		}, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(TopDock, (Type)null, "TabIndex", new object[1] { 3 }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(TopDock, (Type)null, "TabStop", new object[1] { false }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(SliderItem1, (Type)null, "Name", new object[1] { "SliderItem1" }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(SliderItem1, (Type)null, "Text", new object[1] { "SliderItem1" }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(SliderItem1, (Type)null, "Value", new object[1] { 0 }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(SliderItem1, (Type)null, "Visible", new object[1] { false }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(DockContainerItem4, (Type)null, "Name", new object[1] { "DockContainerItem4" }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(DockContainerItem4, (Type)null, "Text", new object[1] { "MAIN" }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(ComboItem1, (Type)null, "Text", new object[1] { "ComboItem1" }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(DockContainerItem1, (Type)null, "Name", new object[1] { "DockContainerItem1" }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(DockContainerItem1, (Type)null, "Text", new object[1] { "Main Menu" }, (string[])null, (Type[])null, false, true);
		ImageList1.set_ImageStream((ImageListStreamer)componentResourceManager.GetObject("ImageList1.ImageStream"));
		ImageList1.set_TransparentColor(Color.Transparent);
		ImageList1.get_Images().SetKeyName(0, "filenew.png");
		ImageList1.get_Images().SetKeyName(1, "fileopen.png");
		ImageList1.get_Images().SetKeyName(2, "filesave.png");
		ImageList1.get_Images().SetKeyName(3, "filequickprint.png");
		ImageList1.get_Images().SetKeyName(4, "gtk-undo-ltr.png");
		ImageList1.get_Images().SetKeyName(5, "gtk-redo-ltr.png");
		ImageList1.get_Images().SetKeyName(6, "editcut.png");
		ImageList1.get_Images().SetKeyName(7, "edit-copy.png");
		ImageList1.get_Images().SetKeyName(8, "gtk-paste.png");
		ImageList1.get_Images().SetKeyName(9, "edit-select-all.png");
		NewLateBinding.LateSetComplex(DockContainerItem3, (Type)null, "Name", new object[1] { "DockContainerItem3" }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(DockContainerItem3, (Type)null, "Text", new object[1] { "MAIN" }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(DockContainerItem5, (Type)null, "Name", new object[1] { "DockContainerItem5" }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(DockContainerItem5, (Type)null, "Text", new object[1] { "DockContainerItem5" }, (string[])null, (Type[])null, false, true);
		((Form)this).set_BackColor(Color.White);
		((Form)this).set_ClientSize(new Size(1008, 732));
		NewLateBinding.LateCall(ContextMenuBar1, (Type)null, "SetContextMenuEx", array = new object[2] { this, ButtonItem1 }, (string[])null, (Type[])null, array2 = new bool[2] { false, true }, true);
		if (array2[1])
		{
			ButtonItem1 = RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(array[1]));
		}
		((Control)this).get_Controls().Add((Control)DockSite1);
		((Control)this).get_Controls().Add((Control)RightDock);
		((Control)this).get_Controls().Add((Control)LeftDock);
		((Control)this).get_Controls().Add((Control)TopDock);
		((Control)this).get_Controls().Add((Control)BottomDock);
		((Control)this).get_Controls().Add((Control)ToolBarLeftDock);
		((Control)this).get_Controls().Add((Control)ToolBarRightDock);
		((Control)this).get_Controls().Add((Control)ToolBarTopDock);
		((Control)this).get_Controls().Add((Control)ToolBarBottomDock);
		((Control)this).set_Font(new Font("Verdana", 8.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Form)this).set_HelpButton(true);
		((Form)this).set_Icon((Icon)componentResourceManager.GetObject("$this.Icon"));
		((Form)this).set_KeyPreview(true);
		((Control)this).set_Name("MainFrm");
		((Form)this).set_Text("SCOTTII KOREA 통합관리시스템");
		((Form)this).set_WindowState((FormWindowState)2);
		NewLateBinding.LateCall(BottomDock, (Type)null, "ResumeLayout", new object[1] { false }, (string[])null, (Type[])null, (bool[])null, true);
		((ISupportInitialize)StatusBar1).EndInit();
		NewLateBinding.LateCall(DockSite1, (Type)null, "ResumeLayout", new object[1] { false }, (string[])null, (Type[])null, (bool[])null, true);
		((ISupportInitialize)TabFrm).EndInit();
		NewLateBinding.LateCall(TabFrm, (Type)null, "ResumeLayout", new object[1] { false }, (string[])null, (Type[])null, (bool[])null, true);
		((ISupportInitialize)ContextMenuBar2).EndInit();
		((ISupportInitialize)ContextMenuBar1).EndInit();
		((ISupportInitialize)MainMenu).EndInit();
		NewLateBinding.LateCall(MainMenu, (Type)null, "ResumeLayout", new object[1] { false }, (string[])null, (Type[])null, (bool[])null, true);
		NewLateBinding.LateCall(PanelDockContainer1, (Type)null, "ResumeLayout", new object[1] { false }, (string[])null, (Type[])null, (bool[])null, true);
		NewLateBinding.LateCall(LeftDock, (Type)null, "ResumeLayout", new object[1] { false }, (string[])null, (Type[])null, (bool[])null, true);
		((Control)this).ResumeLayout(false);
	}

	public Wg15()
	{
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Expected O, but got Unknown
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Expected O, but got Unknown
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Expected O, but got Unknown
		((Form)this).add_FormClosed(new FormClosedEventHandler(b8ZJ));
		((Form)this).add_FormClosing(new FormClosingEventHandler(Tb52));
		((Form)this).add_Load((EventHandler)Td2e);
		Conn = new SqlConnection();
		Ea02();
	}

	private void b8ZJ(object sender, FormClosedEventArgs e)
	{
		string text = "";
		IPAddress[] hostAddresses = Dns.GetHostAddresses(((ServerComputer)Pk3.Computer).get_Name());
		IPAddress[] array = hostAddresses;
		foreach (IPAddress iPAddress in array)
		{
			text = iPAddress.ToString();
			if (Strings.InStr(text, ".", (CompareMethod)0) > 0)
			{
				break;
			}
		}
		if (Site_id != null && e4L7(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject((object)"EXEC SP_COMMON_LOGSTATUS_C '", Site_id), (object)"','"), (object)Emp_No), (object)"','"), (object)text), (object)"','"), (object)Conversions.ToString(((ApplicationBase)Pk3.Application).get_Info().get_Version().Major)), (object)"."), (object)Conversions.ToString(((ApplicationBase)Pk3.Application).get_Info().get_Version().Minor)), (object)"."), (object)Conversions.ToString(((ApplicationBase)Pk3.Application).get_Info().get_Version().Build)), (object)"."), (object)Conversions.ToString(((ApplicationBase)Pk3.Application).get_Info().get_Version().Revision)), (object)"','"), (object)DateAndTime.get_Now()), (object)"'")))
		{
		}
	}

	private bool e4L7(object Wj6i)
	{
		throw new NotImplementedException();
	}

	private void Tb52(object sender, FormClosingEventArgs e)
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Invalid comparison between Unknown and I4
		if ((int)MessageBox.Show("시스템을 종료하시겠습니까? ", "시스템 종료", (MessageBoxButtons)4) == 7)
		{
			((CancelEventArgs)(object)e).Cancel = true;
		}
	}

	private void Td2e(object sender, EventArgs e)
	{
		//IL_01d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0318: Unknown result type (might be due to invalid IL or missing references)
		//IL_039e: Unknown result type (might be due to invalid IL or missing references)
		NewLateBinding.LateSetComplex(SliderItem1, (Type)null, "Value", new object[1] { 100 }, (string[])null, (Type[])null, false, true);
		try
		{
			NewLateBinding.LateCall(LoginFrm, (Type)null, "ShowDialog", new object[0], (string[])null, (Type[])null, (bool[])null, true);
			if (!login_yn)
			{
				((Form)this).Close();
				return;
			}
			NewLateBinding.LateCall(i_conn, (Type)null, "Open", new object[1] { this.get_db_conn(1) }, (string[])null, (Type[])null, (bool[])null, true);
			NewLateBinding.LateSetComplex(i_cmd, (Type)null, "ActiveConnection", new object[1] { i_conn }, (string[])null, (Type[])null, false, true);
			((Form)this).set_Text("SCOTTII KOREA 통합관리시스템");
			if (Conversions.ToBoolean(Operators.AndObject(Operators.CompareObjectNotEqual(Site_id, (object)"", false), (object)((double)Emp_No != Conversions.ToDouble("")))))
			{
				if (!((Operators.CompareString(SVR, "", false) != 0) & (Operators.CompareString(dbid, "", false) != 0) & (Operators.CompareString(dbpw, "", false) != 0)))
				{
				}
				NewLateBinding.LateSetComplex(LabelItem1, (Type)null, "Text", new object[1] { Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject((object)"[", Site_id), (object)"] "), (object)Site_nm) }, (string[])null, (Type[])null, false, true);
				NewLateBinding.LateSetComplex(DockContainerItem2, (Type)null, "Text", new object[1] { "SCOTTII KOREA" }, (string[])null, (Type[])null, false, true);
				if (!Wg72(RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(ComboBoxItem1, (Type)null, "ComboBoxEx", new object[0], (string[])null, (Type[])null, (bool[])null)), "sELECT '[' + EMP_NO + ']' + EMP_NM FROM TBL_EMPMASTER WHERE dept_cd = (select dept_cd from tbl_empmaster where emp_no = '" + Conversions.ToString(Emp_No) + "') and RETIRE_YN = 'N' ORDER BY EMP_NO"))
				{
					MessageBox.Show("error");
				}
				NewLateBinding.LateSetComplex(NewLateBinding.LateGet(ComboBoxItem1, (Type)null, "ComboBoxEx", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Text", new object[1] { "[" + Conversions.ToString(Emp_No) + "]" + Emp_Nm }, (string[])null, (Type[])null, false, true);
				((Form)this).set_Text(((Form)this).get_Text() + "(Version " + Conversions.ToString(((ApplicationBase)Pk3.Application).get_Info().get_Version().Major) + "." + Conversions.ToString(((ApplicationBase)Pk3.Application).get_Info().get_Version().Minor) + "." + Conversions.ToString(((ApplicationBase)Pk3.Application).get_Info().get_Version().Build) + "." + Conversions.ToString(((ApplicationBase)Pk3.Application).get_Info().get_Version().Revision) + ")");
			}
			NewLateBinding.LateSetComplex(RibbonBar1, (Type)null, "Visible", new object[1] { false }, (string[])null, (Type[])null, false, true);
			if (!b5ZL())
			{
				MessageBox.Show("ShowSideMenu Show error");
			}
			NewLateBinding.LateSetComplex(LabelItem2, (Type)null, "Text", new object[1] { "   Logined by [" + Conversions.ToString(Emp_No) + "] " + Emp_Nm }, (string[])null, (Type[])null, false, true);
			NewLateBinding.LateCall(MainMenu, (Type)null, "Refresh", new object[0], (string[])null, (Type[])null, (bool[])null, true);
			d6SR();
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			MessageBox.Show("Error: " + ex2.Message, "ERROR");
			ProjectData.ClearProjectError();
		}
	}

	private bool Wg72(object o1EN, string k2R9)
	{
		throw new NotImplementedException();
	}

	private bool Xd6f(string Qt2n)
	{
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		bool result = default(bool);
		try
		{
			object objectValue = RuntimeHelpers.GetObjectValue(new object());
			NewLateBinding.LateSet(objectValue, (Type)null, "Text", new object[1] { Qt2n + "(&" + Strings.Mid(Qt2n, 1, 1) + ")" }, (string[])null, (Type[])null);
			return result;
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			MessageBox.Show("Error: " + ex2.Message, "ERROR");
			ProjectData.ClearProjectError();
			return result;
		}
	}

	private bool s1C3(string m8N7, string s9J3, int x8JA, object b8QK)
	{
		//IL_00fc: Unknown result type (might be due to invalid IL or missing references)
		bool result = default(bool);
		try
		{
			RuntimeHelpers.GetObjectValue(new object());
			object objectValue = RuntimeHelpers.GetObjectValue(new object());
			NewLateBinding.LateSet(objectValue, (Type)null, "Text", new object[1] { "&" + s9J3 }, (string[])null, (Type[])null);
			if (x8JA < 99)
			{
				NewLateBinding.LateSet(objectValue, (Type)null, "Image", new object[1] { ImageList1.get_Images().get_Item(x8JA) }, (string[])null, (Type[])null);
			}
			if (Operators.ConditionalCompareObjectNotEqual(b8QK, NewLateBinding.LateGet(eShortcut, (Type)null, "None", new object[0], (string[])null, (Type[])null, (bool[])null), false))
			{
				object[] array;
				bool[] array2;
				NewLateBinding.LateCall(NewLateBinding.LateGet(objectValue, (Type)null, "Shortcuts", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Add", array = new object[1] { b8QK }, (string[])null, (Type[])null, array2 = new bool[1] { true }, true);
				if (array2[0])
				{
					b8QK = RuntimeHelpers.GetObjectValue(array[0]);
					return result;
				}
				return result;
			}
			return result;
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			MessageBox.Show("Error: " + ex2.Message, "ERROR");
			ProjectData.ClearProjectError();
			return result;
		}
	}

	private bool Xg21(string Xf62, string Jm8e, int Qa2e, object Hj18)
	{
		//IL_00f2: Unknown result type (might be due to invalid IL or missing references)
		bool result = default(bool);
		try
		{
			object objectValue = RuntimeHelpers.GetObjectValue(new object());
			objectValue = RuntimeHelpers.GetObjectValue(new object());
			NewLateBinding.LateSet(objectValue, (Type)null, "Tooltip", new object[1] { Jm8e }, (string[])null, (Type[])null);
			if (Qa2e < 99)
			{
				NewLateBinding.LateSet(objectValue, (Type)null, "Image", new object[1] { ImageList2.get_Images().get_Item(Qa2e) }, (string[])null, (Type[])null);
			}
			if (Operators.ConditionalCompareObjectNotEqual(Hj18, NewLateBinding.LateGet(eShortcut, (Type)null, "None", new object[0], (string[])null, (Type[])null, (bool[])null), false))
			{
				object[] array;
				bool[] array2;
				NewLateBinding.LateCall(NewLateBinding.LateGet(objectValue, (Type)null, "Shortcuts", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Add", array = new object[1] { Hj18 }, (string[])null, (Type[])null, array2 = new bool[1] { true }, true);
				if (array2[0])
				{
					Hj18 = RuntimeHelpers.GetObjectValue(array[0]);
					return result;
				}
				return result;
			}
			return result;
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			MessageBox.Show("Error: " + ex2.Message, "ERROR");
			ProjectData.ClearProjectError();
			return result;
		}
	}

	private bool b5ZL()
	{
		object objectValue = RuntimeHelpers.GetObjectValue(new object());
		object objectValue2 = RuntimeHelpers.GetObjectValue(new object());
		object objectValue3 = RuntimeHelpers.GetObjectValue(new object());
		object objectValue4 = RuntimeHelpers.GetObjectValue(new object());
		object objectValue5 = RuntimeHelpers.GetObjectValue(new object());
		object objectValue6 = RuntimeHelpers.GetObjectValue(new object());
		object objectValue7 = RuntimeHelpers.GetObjectValue(new object());
		objectValue = RuntimeHelpers.GetObjectValue(Ti9m("select menu1, isnull(menu2,''), isnull(menu3,''), callform from tbl_menu order by orderdisp"));
		string text = "";
		string text2 = "";
		int num = Conversions.ToInteger(Operators.SubtractObject(NewLateBinding.LateGet(objectValue, (Type)null, "RecordCount", new object[0], (string[])null, (Type[])null, (bool[])null), (object)1));
		for (int i = 0; i <= num; i = checked(i + 1))
		{
			if (Operators.ConditionalCompareObjectNotEqual((object)text, NewLateBinding.LateGet(NewLateBinding.LateIndexGet(objectValue, new object[1] { 0 }, (string[])null), (Type)null, "Value", new object[0], (string[])null, (Type[])null, (bool[])null), false))
			{
				objectValue2 = RuntimeHelpers.GetObjectValue(new object());
				NewLateBinding.LateSet(objectValue2, (Type)null, "FontBold", new object[1] { true }, (string[])null, (Type[])null);
				object obj = NewLateBinding.LateGet(MenuList, (Type)null, "Panels", new object[0], (string[])null, (Type[])null, (bool[])null);
				object[] obj2 = new object[1] { objectValue2 };
				object[] array = obj2;
				bool[] obj3 = new bool[1] { true };
				bool[] array2 = obj3;
				NewLateBinding.LateCall(obj, (Type)null, "Add", obj2, (string[])null, (Type[])null, obj3, true);
				if (array2[0])
				{
					objectValue2 = RuntimeHelpers.GetObjectValue(array[0]);
				}
				text = Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateIndexGet(objectValue, new object[1] { 0 }, (string[])null), (Type)null, "Value", new object[0], (string[])null, (Type[])null, (bool[])null));
				objectValue5 = RuntimeHelpers.GetObjectValue(new object());
				NewLateBinding.LateSet(objectValue5, (Type)null, "GlobalName", new object[1] { NewLateBinding.LateGet(NewLateBinding.LateIndexGet(objectValue, new object[1] { 3 }, (string[])null), (Type)null, "Value", new object[0], (string[])null, (Type[])null, (bool[])null) }, (string[])null, (Type[])null);
				NewLateBinding.LateSet(objectValue5, (Type)null, "Text", new object[1] { NewLateBinding.LateGet(NewLateBinding.LateIndexGet(objectValue, new object[1] { 0 }, (string[])null), (Type)null, "Value", new object[0], (string[])null, (Type[])null, (bool[])null) }, (string[])null, (Type[])null);
				NewLateBinding.LateCall(NewLateBinding.LateGet(RibbonBar1, (Type)null, "Items", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Add", array = new object[1] { objectValue5 }, (string[])null, (Type[])null, array2 = new bool[1] { true }, true);
				if (array2[0])
				{
					objectValue5 = RuntimeHelpers.GetObjectValue(array[0]);
				}
			}
			if (Conversions.ToBoolean(Operators.AndObject(Operators.CompareObjectEqual((object)text, NewLateBinding.LateGet(NewLateBinding.LateIndexGet(objectValue, new object[1] { 0 }, (string[])null), (Type)null, "Value", new object[0], (string[])null, (Type[])null, (bool[])null), false), Operators.CompareObjectNotEqual((object)text2, NewLateBinding.LateGet(NewLateBinding.LateIndexGet(objectValue, new object[1] { 1 }, (string[])null), (Type)null, "Value", new object[0], (string[])null, (Type[])null, (bool[])null), false))) && b0Y7(RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(NewLateBinding.LateIndexGet(objectValue, new object[1] { 3 }, (string[])null), (Type)null, "Value", new object[0], (string[])null, (Type[])null, (bool[])null))))
			{
				objectValue3 = RuntimeHelpers.GetObjectValue(new object());
				NewLateBinding.LateSet(objectValue3, (Type)null, "GlobalName", new object[1] { NewLateBinding.LateGet(NewLateBinding.LateIndexGet(objectValue, new object[1] { 3 }, (string[])null), (Type)null, "Value", new object[0], (string[])null, (Type[])null, (bool[])null) }, (string[])null, (Type[])null);
				NewLateBinding.LateSet(objectValue3, (Type)null, "ImagePaddingHorizontal", new object[1] { 13 }, (string[])null, (Type[])null);
				object obj4 = NewLateBinding.LateGet(objectValue2, (Type)null, "SubItems", new object[0], (string[])null, (Type[])null, (bool[])null);
				object[] obj5 = new object[1] { objectValue3 };
				object[] array = obj5;
				bool[] obj6 = new bool[1] { true };
				bool[] array2 = obj6;
				NewLateBinding.LateCall(obj4, (Type)null, "Add", obj5, (string[])null, (Type[])null, obj6, true);
				if (array2[0])
				{
					objectValue3 = RuntimeHelpers.GetObjectValue(array[0]);
				}
				text2 = Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateIndexGet(objectValue, new object[1] { 1 }, (string[])null), (Type)null, "Value", new object[0], (string[])null, (Type[])null, (bool[])null));
				objectValue6 = RuntimeHelpers.GetObjectValue(new object());
				NewLateBinding.LateSet(objectValue6, (Type)null, "GlobalName", new object[1] { NewLateBinding.LateGet(NewLateBinding.LateIndexGet(objectValue, new object[1] { 3 }, (string[])null), (Type)null, "Value", new object[0], (string[])null, (Type[])null, (bool[])null) }, (string[])null, (Type[])null);
				NewLateBinding.LateSet(objectValue6, (Type)null, "Text", new object[1] { NewLateBinding.LateGet(NewLateBinding.LateIndexGet(objectValue, new object[1] { 1 }, (string[])null), (Type)null, "Value", new object[0], (string[])null, (Type[])null, (bool[])null) }, (string[])null, (Type[])null);
				NewLateBinding.LateCall(NewLateBinding.LateGet(objectValue5, (Type)null, "SubItems", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Add", array = new object[1] { objectValue6 }, (string[])null, (Type[])null, array2 = new bool[1] { true }, true);
				if (array2[0])
				{
					objectValue6 = RuntimeHelpers.GetObjectValue(array[0]);
				}
			}
			if (Conversions.ToBoolean(Operators.AndObject(Operators.AndObject(Operators.CompareObjectEqual((object)text, NewLateBinding.LateGet(NewLateBinding.LateIndexGet(objectValue, new object[1] { 0 }, (string[])null), (Type)null, "Value", new object[0], (string[])null, (Type[])null, (bool[])null), false), Operators.CompareObjectEqual((object)text2, NewLateBinding.LateGet(NewLateBinding.LateIndexGet(objectValue, new object[1] { 1 }, (string[])null), (Type)null, "Value", new object[0], (string[])null, (Type[])null, (bool[])null), false)), Operators.CompareObjectNotEqual(NewLateBinding.LateGet(NewLateBinding.LateIndexGet(objectValue, new object[1] { 2 }, (string[])null), (Type)null, "Value", new object[0], (string[])null, (Type[])null, (bool[])null), (object)"", false))) && b0Y7(RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(NewLateBinding.LateIndexGet(objectValue, new object[1] { 3 }, (string[])null), (Type)null, "Value", new object[0], (string[])null, (Type[])null, (bool[])null))))
			{
				objectValue4 = RuntimeHelpers.GetObjectValue(new object());
				NewLateBinding.LateSet(objectValue4, (Type)null, "GlobalName", new object[1] { NewLateBinding.LateGet(NewLateBinding.LateIndexGet(objectValue, new object[1] { 3 }, (string[])null), (Type)null, "Value", new object[0], (string[])null, (Type[])null, (bool[])null) }, (string[])null, (Type[])null);
				NewLateBinding.LateSet(objectValue4, (Type)null, "ImagePaddingHorizontal", new object[1] { 13 }, (string[])null, (Type[])null);
				NewLateBinding.LateSet(objectValue4, (Type)null, "ButtonStyle", new object[1] { NewLateBinding.LateGet(eButtonStyle, (Type)null, "TextOnlyAlways", new object[0], (string[])null, (Type[])null, (bool[])null) }, (string[])null, (Type[])null);
				object obj7 = NewLateBinding.LateGet(objectValue3, (Type)null, "SubItems", new object[0], (string[])null, (Type[])null, (bool[])null);
				object[] obj8 = new object[1] { objectValue4 };
				object[] array = obj8;
				bool[] obj9 = new bool[1] { true };
				bool[] array2 = obj9;
				NewLateBinding.LateCall(obj7, (Type)null, "Add", obj8, (string[])null, (Type[])null, obj9, true);
				if (array2[0])
				{
					objectValue4 = RuntimeHelpers.GetObjectValue(array[0]);
				}
				Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateIndexGet(objectValue, new object[1] { 2 }, (string[])null), (Type)null, "Value", new object[0], (string[])null, (Type[])null, (bool[])null));
				objectValue7 = RuntimeHelpers.GetObjectValue(new object());
				NewLateBinding.LateSet(objectValue7, (Type)null, "GlobalName", new object[1] { NewLateBinding.LateGet(NewLateBinding.LateIndexGet(objectValue, new object[1] { 3 }, (string[])null), (Type)null, "Value", new object[0], (string[])null, (Type[])null, (bool[])null) }, (string[])null, (Type[])null);
				NewLateBinding.LateSet(objectValue7, (Type)null, "Text", new object[1] { NewLateBinding.LateGet(NewLateBinding.LateIndexGet(objectValue, new object[1] { 2 }, (string[])null), (Type)null, "Value", new object[0], (string[])null, (Type[])null, (bool[])null) }, (string[])null, (Type[])null);
				NewLateBinding.LateCall(NewLateBinding.LateGet(objectValue6, (Type)null, "SubItems", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Add", array = new object[1] { objectValue7 }, (string[])null, (Type[])null, array2 = new bool[1] { true }, true);
				if (array2[0])
				{
					objectValue7 = RuntimeHelpers.GetObjectValue(array[0]);
				}
			}
			NewLateBinding.LateCall(objectValue, (Type)null, "MoveNext", new object[0], (string[])null, (Type[])null, (bool[])null, true);
		}
		NewLateBinding.LateSetComplex(RibbonBar1, (Type)null, "LayoutOrientation", new object[1] { NewLateBinding.LateGet(eOrientation, (Type)null, "Horizontal", new object[0], (string[])null, (Type[])null, (bool[])null) }, (string[])null, (Type[])null, false, true);
		return true;
	}

	private bool b0Y7(object Yo76)
	{
		throw new NotImplementedException();
	}

	private object Ti9m(string Tn1z)
	{
		throw new NotImplementedException();
	}

	private void Mb9o(object sender, EventArgs e)
	{
		//IL_02cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d6: Expected O, but got Unknown
		//IL_03e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ed: Expected O, but got Unknown
		//IL_041d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0424: Expected O, but got Unknown
		//IL_0432: Unknown result type (might be due to invalid IL or missing references)
		object obj = default(object);
		if (!Operators.ConditionalCompareObjectGreater(NewLateBinding.LateGet(NewLateBinding.LateGet(obj, (Type)null, "GlobalName", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Length", new object[0], (string[])null, (Type[])null, (bool[])null), (object)0, false))
		{
			return;
		}
		object objectValue = RuntimeHelpers.GetObjectValue(new object());
		if (Operators.ConditionalCompareObjectGreater(NewLateBinding.LateGet(NewLateBinding.LateGet(obj, (Type)null, "SubItems", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Count", new object[0], (string[])null, (Type[])null, (bool[])null), (object)0, false))
		{
			NewLateBinding.LateSet(objectValue, (Type)null, "Text", new object[1] { NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(obj, (Type)null, "SubItems", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Item", new object[1] { 0 }, (string[])null, (Type[])null, (bool[])null), (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null) }, (string[])null, (Type[])null);
			NewLateBinding.LateSet(objectValue, (Type)null, "Name", new object[1] { NewLateBinding.LateGet(obj, (Type)null, "GlobalName", new object[0], (string[])null, (Type[])null, (bool[])null) }, (string[])null, (Type[])null);
		}
		else
		{
			NewLateBinding.LateSet(objectValue, (Type)null, "Text", new object[1] { NewLateBinding.LateGet(obj, (Type)null, "Name", new object[0], (string[])null, (Type[])null, (bool[])null) }, (string[])null, (Type[])null);
			NewLateBinding.LateSet(objectValue, (Type)null, "Name", new object[1] { NewLateBinding.LateGet(obj, (Type)null, "GlobalName", new object[0], (string[])null, (Type[])null, (bool[])null) }, (string[])null, (Type[])null);
		}
		checked
		{
			if (Operators.CompareString(z3N4(Operators.ConcatenateObject(Operators.ConcatenateObject((object)"select isnull(type,'0') from tbl_menu where callform ='", NewLateBinding.LateGet(obj, (Type)null, "GlobalName", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"'")), "1", false) == 0)
			{
				Type typeFromHandle = typeof(Strings);
				object[] array = new object[1];
				object obj2 = objectValue;
				array[0] = NewLateBinding.LateGet(obj2, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null);
				object[] array2 = array;
				bool[] obj3 = new bool[1] { true };
				bool[] array3 = obj3;
				object obj4 = NewLateBinding.LateGet((object)null, typeFromHandle, "UCase", array, (string[])null, (Type[])null, obj3);
				if (array3[0])
				{
					NewLateBinding.LateSetComplex(obj2, (Type)null, "Text", new object[1] { array2[0] }, (string[])null, (Type[])null, true, false);
				}
				if (Operators.ConditionalCompareObjectEqual(obj4, (object)"MANUAL", false))
				{
					Fm6b();
				}
				else
				{
					Type typeFromHandle2 = typeof(Strings);
					object[] array4 = new object[1];
					obj2 = objectValue;
					array4[0] = NewLateBinding.LateGet(obj2, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null);
					array2 = array4;
					bool[] obj5 = new bool[1] { true };
					array3 = obj5;
					obj4 = NewLateBinding.LateGet((object)null, typeFromHandle2, "UCase", array4, (string[])null, (Type[])null, obj5);
					if (array3[0])
					{
						NewLateBinding.LateSetComplex(obj2, (Type)null, "Text", new object[1] { array2[0] }, (string[])null, (Type[])null, true, false);
					}
					if (Operators.ConditionalCompareObjectEqual(obj4, (object)"Change Password", false))
					{
						NewLateBinding.LateCall(FrmUSPwChg, (Type)null, "ShowDialog", new object[0], (string[])null, (Type[])null, (bool[])null, true);
					}
				}
			}
			else
			{
				Form val = new Form();
				try
				{
					val = ((!Conversions.ToBoolean(Operators.OrObject(Operators.OrObject(Operators.OrObject(Operators.OrObject(Operators.CompareObjectEqual(NewLateBinding.LateGet(obj, (Type)null, "GlobalName", new object[0], (string[])null, (Type[])null, (bool[])null), (object)"FrmUSMontoring1", false), Operators.CompareObjectEqual(NewLateBinding.LateGet(obj, (Type)null, "GlobalName", new object[0], (string[])null, (Type[])null, (bool[])null), (object)"FrmSAOrder1", false)), Operators.CompareObjectEqual(NewLateBinding.LateGet(obj, (Type)null, "GlobalName", new object[0], (string[])null, (Type[])null, (bool[])null), (object)"FrmMCMaster1", false)), Operators.CompareObjectEqual(NewLateBinding.LateGet(obj, (Type)null, "GlobalName", new object[0], (string[])null, (Type[])null, (bool[])null), (object)"FrmPRResult1", false)), Operators.CompareObjectEqual(NewLateBinding.LateGet(obj, (Type)null, "GlobalName", new object[0], (string[])null, (Type[])null, (bool[])null), (object)"FrmEQSum1", false)))) ? ((Form)Activator.CreateInstance(Type.GetType(Conversions.ToString(Operators.AddObject((object)"SMSPLUS.", NewLateBinding.LateGet(obj, (Type)null, "GlobalName", new object[0], (string[])null, (Type[])null, (bool[])null)))))) : ((Form)Activator.CreateInstance(Type.GetType("SMSPLUS." + Strings.Mid(Conversions.ToString(NewLateBinding.LateGet(obj, (Type)null, "GlobalName", new object[0], (string[])null, (Type[])null, (bool[])null)), 1, Strings.Len(RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(obj, (Type)null, "GlobalName", new object[0], (string[])null, (Type[])null, (bool[])null))) - 1)))));
				}
				catch (Exception projectError)
				{
					ProjectData.SetProjectError(projectError);
					MessageBox.Show("Under Construction!");
					ProjectData.ClearProjectError();
					return;
				}
				val.set_TopLevel(false);
				val.set_Location(new Point(0, 0));
				val.set_ShowInTaskbar(false);
				val.set_FormBorderStyle((FormBorderStyle)0);
				((Control)val).set_Dock((DockStyle)5);
				int num = Conversions.ToInteger(Operators.SubtractObject(NewLateBinding.LateGet(TabFrm, (Type)null, "VisibleItemCount", new object[0], (string[])null, (Type[])null, (bool[])null), (object)1));
				object[] array2;
				bool[] array3;
				for (int i = 0; i <= num; i++)
				{
					object obj2 = NewLateBinding.LateGet(TabFrm, (Type)null, "Items", array2 = new object[1] { i }, (string[])null, (Type[])null, array3 = new bool[1] { true });
					if (array3[0])
					{
						i = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array2[0]), typeof(int));
					}
					if (Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(obj2, (Type)null, "Name", new object[0], (string[])null, (Type[])null, (bool[])null), NewLateBinding.LateGet(objectValue, (Type)null, "Name", new object[0], (string[])null, (Type[])null, (bool[])null), false))
					{
						object tabFrm = TabFrm;
						object[] array5 = new object[1];
						object tabFrm2 = TabFrm;
						object[] obj6 = new object[1] { i };
						array2 = obj6;
						bool[] obj7 = new bool[1] { true };
						array3 = obj7;
						obj2 = NewLateBinding.LateGet(tabFrm2, (Type)null, "Items", obj6, (string[])null, (Type[])null, obj7);
						if (array3[0])
						{
							i = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array2[0]), typeof(int));
						}
						array5[0] = obj2;
						NewLateBinding.LateSetComplex(tabFrm, (Type)null, "SelectedDockContainerItem", array5, (string[])null, (Type[])null, false, true);
						return;
					}
				}
				NewLateBinding.LateSet(objectValue, (Type)null, "Control", new object[1] { val }, (string[])null, (Type[])null);
				NewLateBinding.LateCall(NewLateBinding.LateGet(TabFrm, (Type)null, "Items", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Add", array2 = new object[1] { objectValue }, (string[])null, (Type[])null, array3 = new bool[1] { true }, true);
				if (array3[0])
				{
					objectValue = RuntimeHelpers.GetObjectValue(array2[0]);
				}
				((Control)val).Show();
				((Control)val).Update();
				NewLateBinding.LateSetComplex(TabFrm, (Type)null, "SelectedDockContainerItem", new object[1] { objectValue }, (string[])null, (Type[])null, false, true);
				if (Conversions.ToBoolean(Operators.NotObject(NewLateBinding.LateGet(TabFrm, (Type)null, "Visible", new object[0], (string[])null, (Type[])null, (bool[])null))))
				{
					NewLateBinding.LateSetComplex(TabFrm, (Type)null, "Visible", new object[1] { true }, (string[])null, (Type[])null, false, true);
				}
				else
				{
					NewLateBinding.LateCall(TabFrm, (Type)null, "RecalcLayout", new object[0], (string[])null, (Type[])null, (bool[])null, true);
				}
			}
			if (Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(MainMenu, (Type)null, "Visible", new object[0], (string[])null, (Type[])null, (bool[])null), (object)true, false))
			{
				NewLateBinding.LateSetComplex(MainMenu, (Type)null, "AutoHide", new object[1] { true }, (string[])null, (Type[])null, false, true);
			}
		}
	}

	private void Fm6b()
	{
		throw new NotImplementedException();
	}

	private string z3N4(object i2SR)
	{
		throw new NotImplementedException();
	}

	private void Ns1d(object s9W0, object y1EQ)
	{
		NewLateBinding.LateSet(y1EQ, (Type)null, "RemoveDockTab", new object[1] { true }, (string[])null, (Type[])null);
	}

	private void d4W5(object sender, EventArgs e)
	{
		OP_No = Strings.Mid(Conversions.ToString(NewLateBinding.LateGet(ComboBoxItem1, (Type)null, "SelectedItem", new object[0], (string[])null, (Type[])null, (bool[])null)), 2, checked(Strings.InStr(Conversions.ToString(NewLateBinding.LateGet(ComboBoxItem1, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), "]", (CompareMethod)0) - 2));
		OP_Nm = z3N4("select emp_nm from tbl_empmaster where emp_no = '" + OP_No + "'");
	}

	private void d6CP(object sender, EventArgs e)
	{
		NewLateBinding.LateSetComplex(RibbonBar1, (Type)null, "Visible", new object[1] { true }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(MainMenu, (Type)null, "Visible", new object[1] { false }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(SliderItem1, (Type)null, "Orientation", new object[1] { NewLateBinding.LateGet(eOrientation, (Type)null, "Horizontal", new object[0], (string[])null, (Type[])null, (bool[])null) }, (string[])null, (Type[])null, false, true);
	}

	private void d8CN(object sender, EventArgs e)
	{
		NewLateBinding.LateSetComplex(RibbonBar1, (Type)null, "Visible", new object[1] { false }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(MainMenu, (Type)null, "Visible", new object[1] { true }, (string[])null, (Type[])null, false, true);
	}

	private void d6SR()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		//IL_009d: Expected O, but got Unknown
		Form val = new Form();
		object objectValue = RuntimeHelpers.GetObjectValue(Ti9m(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject((object)"select isnull(a.menu3,a.menu2),a.callform from tbl_menu a, tbl_empmaster b where b.site_id = '", Site_id), (object)"' and a.callform = b.init_form and b.emp_no = '"), (object)Emp_No), (object)"'"))));
		if (objectValue != null)
		{
			val = (Form)Activator.CreateInstance(Type.GetType(Conversions.ToString(Operators.AddObject((object)"KEMS.", NewLateBinding.LateGet(NewLateBinding.LateIndexGet(objectValue, new object[1] { 1 }, (string[])null), (Type)null, "Value", new object[0], (string[])null, (Type[])null, (bool[])null)))));
			val.set_TopLevel(false);
			val.set_Location(new Point(0, 0));
			val.set_ShowInTaskbar(false);
			val.set_FormBorderStyle((FormBorderStyle)0);
			((Control)val).set_Dock((DockStyle)5);
			object objectValue2 = default(object);
			NewLateBinding.LateSet(objectValue2, (Type)null, "Text", new object[1] { NewLateBinding.LateGet(NewLateBinding.LateIndexGet(objectValue, new object[1] { 0 }, (string[])null), (Type)null, "Value", new object[0], (string[])null, (Type[])null, (bool[])null) }, (string[])null, (Type[])null);
			NewLateBinding.LateSet(objectValue2, (Type)null, "Name", new object[1] { ((Control)val).get_Name() }, (string[])null, (Type[])null);
			NewLateBinding.LateSet(objectValue2, (Type)null, "Control", new object[1] { val }, (string[])null, (Type[])null);
			object obj = NewLateBinding.LateGet(TabFrm, (Type)null, "Items", new object[0], (string[])null, (Type[])null, (bool[])null);
			object[] obj2 = new object[1] { objectValue2 };
			object[] array = obj2;
			bool[] obj3 = new bool[1] { true };
			bool[] array2 = obj3;
			NewLateBinding.LateCall(obj, (Type)null, "Add", obj2, (string[])null, (Type[])null, obj3, true);
			if (array2[0])
			{
				objectValue2 = RuntimeHelpers.GetObjectValue(array[0]);
			}
			((Control)val).Show();
			((Control)val).Update();
			NewLateBinding.LateCall(TabFrm, (Type)null, "RecalcLayout", new object[0], (string[])null, (Type[])null, (bool[])null, true);
			NewLateBinding.LateSetComplex(TabFrm, (Type)null, "SelectedDockContainerItem", new object[1] { objectValue2 }, (string[])null, (Type[])null, false, true);
		}
	}

	internal static object d9NR(int k0Y6, int Hc95)
	{
		return (k0Y6 & ~Hc95) | (~k0Y6 & Hc95);
	}
}
