using System;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Infragistics.Win;
using Infragistics.Win.Misc;
using Infragistics.Win.UltraWinToolbars;
using Microsoft.VisualBasic.CompilerServices;

namespace CNBC_MONEY_2009;

[DesignerGenerated]
public class frmHelp : Form
{
	private static ArrayList __ENCList = new ArrayList();

	private IContainer components;

	[AccessedThroughProperty("UltraToolbarsManager1")]
	private UltraToolbarsManager _UltraToolbarsManager1;

	[AccessedThroughProperty("_frmHelp_Toolbars_Dock_Area_Left")]
	private UltraToolbarsDockArea __frmHelp_Toolbars_Dock_Area_Left;

	[AccessedThroughProperty("_frmHelp_Toolbars_Dock_Area_Right")]
	private UltraToolbarsDockArea __frmHelp_Toolbars_Dock_Area_Right;

	[AccessedThroughProperty("_frmHelp_Toolbars_Dock_Area_Top")]
	private UltraToolbarsDockArea __frmHelp_Toolbars_Dock_Area_Top;

	[AccessedThroughProperty("_frmHelp_Toolbars_Dock_Area_Bottom")]
	private UltraToolbarsDockArea __frmHelp_Toolbars_Dock_Area_Bottom;

	[AccessedThroughProperty("btnClose")]
	private UltraButton _btnClose;

	[AccessedThroughProperty("PictureBox1")]
	private PictureBox _PictureBox1;

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
			_UltraToolbarsManager1 = value;
		}
	}

	internal virtual UltraToolbarsDockArea _frmHelp_Toolbars_Dock_Area_Left
	{
		[DebuggerNonUserCode]
		get
		{
			return __frmHelp_Toolbars_Dock_Area_Left;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__frmHelp_Toolbars_Dock_Area_Left = value;
		}
	}

	internal virtual UltraToolbarsDockArea _frmHelp_Toolbars_Dock_Area_Right
	{
		[DebuggerNonUserCode]
		get
		{
			return __frmHelp_Toolbars_Dock_Area_Right;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__frmHelp_Toolbars_Dock_Area_Right = value;
		}
	}

	internal virtual UltraToolbarsDockArea _frmHelp_Toolbars_Dock_Area_Top
	{
		[DebuggerNonUserCode]
		get
		{
			return __frmHelp_Toolbars_Dock_Area_Top;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__frmHelp_Toolbars_Dock_Area_Top = value;
		}
	}

	internal virtual UltraToolbarsDockArea _frmHelp_Toolbars_Dock_Area_Bottom
	{
		[DebuggerNonUserCode]
		get
		{
			return __frmHelp_Toolbars_Dock_Area_Bottom;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__frmHelp_Toolbars_Dock_Area_Bottom = value;
		}
	}

	internal virtual UltraButton btnClose
	{
		[DebuggerNonUserCode]
		get
		{
			return _btnClose;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			if (_btnClose != null)
			{
				((Control)_btnClose).remove_Click((EventHandler)btnClose_Click);
			}
			_btnClose = value;
			if (_btnClose != null)
			{
				((Control)_btnClose).add_Click((EventHandler)btnClose_Click);
			}
		}
	}

	internal virtual PictureBox PictureBox1
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
			_PictureBox1 = value;
		}
	}

	[DebuggerNonUserCode]
	public frmHelp()
	{
		((Form)this).add_Load((EventHandler)frmHelp_Load);
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
		//IL_041d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0427: Expected O, but got Unknown
		//IL_053a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0544: Expected O, but got Unknown
		//IL_0550: Unknown result type (might be due to invalid IL or missing references)
		//IL_055a: Expected O, but got Unknown
		components = new Container();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(frmHelp));
		UltraToolbarsManager1 = new UltraToolbarsManager(components);
		_frmHelp_Toolbars_Dock_Area_Left = new UltraToolbarsDockArea();
		_frmHelp_Toolbars_Dock_Area_Right = new UltraToolbarsDockArea();
		_frmHelp_Toolbars_Dock_Area_Top = new UltraToolbarsDockArea();
		_frmHelp_Toolbars_Dock_Area_Bottom = new UltraToolbarsDockArea();
		btnClose = new UltraButton();
		PictureBox1 = new PictureBox();
		((ISupportInitialize)UltraToolbarsManager1).BeginInit();
		((ISupportInitialize)PictureBox1).BeginInit();
		((Control)this).SuspendLayout();
		UltraToolbarsManager1.set_DesignerFlags(1);
		UltraToolbarsManager1.set_DockWithinContainer((Control)(object)this);
		UltraToolbarsManager1.set_Office2007UICompatibility(false);
		UltraToolbarsManager1.get_Ribbon().get_ApplicationMenu().set_Visible(false);
		UltraToolbarsManager1.get_Ribbon().get_QuickAccessToolbar().set_Visible(false);
		UltraToolbarsManager1.get_Ribbon().set_Visible(true);
		UltraToolbarsManager1.set_ShowFullMenusDelay(500);
		((Control)_frmHelp_Toolbars_Dock_Area_Left).set_AccessibleRole((AccessibleRole)20);
		((Control)_frmHelp_Toolbars_Dock_Area_Left).set_BackColor(Color.FromArgb(191, 219, 255));
		_frmHelp_Toolbars_Dock_Area_Left.set_DockedPosition((DockedPosition)2);
		((Control)_frmHelp_Toolbars_Dock_Area_Left).set_ForeColor(SystemColors.ControlText);
		_frmHelp_Toolbars_Dock_Area_Left.set_InitialResizeAreaExtent(4);
		UltraToolbarsDockArea frmHelp_Toolbars_Dock_Area_Left = _frmHelp_Toolbars_Dock_Area_Left;
		Point location = new Point(0, 24);
		((Control)frmHelp_Toolbars_Dock_Area_Left).set_Location(location);
		((Control)_frmHelp_Toolbars_Dock_Area_Left).set_Name("_frmHelp_Toolbars_Dock_Area_Left");
		UltraToolbarsDockArea frmHelp_Toolbars_Dock_Area_Left2 = _frmHelp_Toolbars_Dock_Area_Left;
		Size size = new Size(4, 860);
		((Control)frmHelp_Toolbars_Dock_Area_Left2).set_Size(size);
		_frmHelp_Toolbars_Dock_Area_Left.set_ToolbarsManager(UltraToolbarsManager1);
		((Control)_frmHelp_Toolbars_Dock_Area_Right).set_AccessibleRole((AccessibleRole)20);
		((Control)_frmHelp_Toolbars_Dock_Area_Right).set_BackColor(Color.FromArgb(191, 219, 255));
		_frmHelp_Toolbars_Dock_Area_Right.set_DockedPosition((DockedPosition)3);
		((Control)_frmHelp_Toolbars_Dock_Area_Right).set_ForeColor(SystemColors.ControlText);
		_frmHelp_Toolbars_Dock_Area_Right.set_InitialResizeAreaExtent(4);
		UltraToolbarsDockArea frmHelp_Toolbars_Dock_Area_Right = _frmHelp_Toolbars_Dock_Area_Right;
		location = new Point(528, 24);
		((Control)frmHelp_Toolbars_Dock_Area_Right).set_Location(location);
		((Control)_frmHelp_Toolbars_Dock_Area_Right).set_Name("_frmHelp_Toolbars_Dock_Area_Right");
		UltraToolbarsDockArea frmHelp_Toolbars_Dock_Area_Right2 = _frmHelp_Toolbars_Dock_Area_Right;
		size = new Size(4, 860);
		((Control)frmHelp_Toolbars_Dock_Area_Right2).set_Size(size);
		_frmHelp_Toolbars_Dock_Area_Right.set_ToolbarsManager(UltraToolbarsManager1);
		((Control)_frmHelp_Toolbars_Dock_Area_Top).set_AccessibleRole((AccessibleRole)20);
		((Control)_frmHelp_Toolbars_Dock_Area_Top).set_BackColor(Color.FromArgb(191, 219, 255));
		_frmHelp_Toolbars_Dock_Area_Top.set_DockedPosition((DockedPosition)0);
		((Control)_frmHelp_Toolbars_Dock_Area_Top).set_ForeColor(SystemColors.ControlText);
		UltraToolbarsDockArea frmHelp_Toolbars_Dock_Area_Top = _frmHelp_Toolbars_Dock_Area_Top;
		location = new Point(0, 0);
		((Control)frmHelp_Toolbars_Dock_Area_Top).set_Location(location);
		((Control)_frmHelp_Toolbars_Dock_Area_Top).set_Name("_frmHelp_Toolbars_Dock_Area_Top");
		UltraToolbarsDockArea frmHelp_Toolbars_Dock_Area_Top2 = _frmHelp_Toolbars_Dock_Area_Top;
		size = new Size(532, 24);
		((Control)frmHelp_Toolbars_Dock_Area_Top2).set_Size(size);
		_frmHelp_Toolbars_Dock_Area_Top.set_ToolbarsManager(UltraToolbarsManager1);
		((Control)_frmHelp_Toolbars_Dock_Area_Bottom).set_AccessibleRole((AccessibleRole)20);
		((Control)_frmHelp_Toolbars_Dock_Area_Bottom).set_BackColor(Color.FromArgb(191, 219, 255));
		_frmHelp_Toolbars_Dock_Area_Bottom.set_DockedPosition((DockedPosition)1);
		((Control)_frmHelp_Toolbars_Dock_Area_Bottom).set_ForeColor(SystemColors.ControlText);
		_frmHelp_Toolbars_Dock_Area_Bottom.set_InitialResizeAreaExtent(4);
		UltraToolbarsDockArea frmHelp_Toolbars_Dock_Area_Bottom = _frmHelp_Toolbars_Dock_Area_Bottom;
		location = new Point(0, 884);
		((Control)frmHelp_Toolbars_Dock_Area_Bottom).set_Location(location);
		((Control)_frmHelp_Toolbars_Dock_Area_Bottom).set_Name("_frmHelp_Toolbars_Dock_Area_Bottom");
		UltraToolbarsDockArea frmHelp_Toolbars_Dock_Area_Bottom2 = _frmHelp_Toolbars_Dock_Area_Bottom;
		size = new Size(532, 4);
		((Control)frmHelp_Toolbars_Dock_Area_Bottom2).set_Size(size);
		_frmHelp_Toolbars_Dock_Area_Bottom.set_ToolbarsManager(UltraToolbarsManager1);
		((UltraButtonBase)btnClose).set_ButtonStyle((UIElementButtonStyle)17);
		((UltraButtonBase)btnClose).set_DialogResult((DialogResult)2);
		UltraButton obj = btnClose;
		location = new Point(382, 229);
		((Control)obj).set_Location(location);
		((Control)btnClose).set_Name("btnClose");
		UltraButton obj2 = btnClose;
		size = new Size(75, 23);
		((Control)obj2).set_Size(size);
		((Control)btnClose).set_TabIndex(15);
		((ControlBase)btnClose).set_Text("Close");
		((Control)PictureBox1).set_Dock((DockStyle)5);
		PictureBox1.set_Image((Image)componentResourceManager.GetObject("PictureBox1.Image"));
		PictureBox pictureBox = PictureBox1;
		location = new Point(4, 24);
		((Control)pictureBox).set_Location(location);
		((Control)PictureBox1).set_Name("PictureBox1");
		PictureBox pictureBox2 = PictureBox1;
		size = new Size(524, 860);
		((Control)pictureBox2).set_Size(size);
		PictureBox1.set_TabIndex(20);
		PictureBox1.set_TabStop(false);
		SizeF autoScaleDimensions = new SizeF(7f, 13f);
		((ContainerControl)this).set_AutoScaleDimensions(autoScaleDimensions);
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_CancelButton((IButtonControl)(object)btnClose);
		size = new Size(532, 888);
		((Form)this).set_ClientSize(size);
		((Control)this).get_Controls().Add((Control)(object)PictureBox1);
		((Control)this).get_Controls().Add((Control)(object)btnClose);
		((Control)this).get_Controls().Add((Control)(object)_frmHelp_Toolbars_Dock_Area_Left);
		((Control)this).get_Controls().Add((Control)(object)_frmHelp_Toolbars_Dock_Area_Right);
		((Control)this).get_Controls().Add((Control)(object)_frmHelp_Toolbars_Dock_Area_Top);
		((Control)this).get_Controls().Add((Control)(object)_frmHelp_Toolbars_Dock_Area_Bottom);
		((Control)this).set_Font(new Font("Verdana", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Form)this).set_Icon((Icon)componentResourceManager.GetObject("$this.Icon"));
		((Form)this).set_MaximizeBox(false);
		((Control)this).set_Name("frmHelp");
		((Form)this).set_ShowIcon(false);
		((Form)this).set_StartPosition((FormStartPosition)1);
		((Form)this).set_Text("CNBC MONEY 2010 HELP");
		((ISupportInitialize)UltraToolbarsManager1).EndInit();
		((ISupportInitialize)PictureBox1).EndInit();
		((Control)this).ResumeLayout(false);
	}

	private void frmHelp_Load(object sender, EventArgs e)
	{
	}

	private void btnClose_Click(object sender, EventArgs e)
	{
		try
		{
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}
}
