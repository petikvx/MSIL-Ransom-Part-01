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
public class InheritedChildForm : Form
{
	private static ArrayList __ENCList = new ArrayList();

	private IContainer components;

	[AccessedThroughProperty("lblLeft")]
	private Label _lblLeft;

	[AccessedThroughProperty("lblRight")]
	private Label _lblRight;

	[AccessedThroughProperty("lblBottom")]
	private Label _lblBottom;

	[AccessedThroughProperty("lblTop")]
	private Label _lblTop;

	[AccessedThroughProperty("grForm")]
	private UltraGroupBox _grForm;

	[AccessedThroughProperty("UltraToolbarsManager1")]
	private UltraToolbarsManager _UltraToolbarsManager1;

	[AccessedThroughProperty("_InheritedForm_Toolbars_Dock_Area_Left")]
	private UltraToolbarsDockArea __InheritedForm_Toolbars_Dock_Area_Left;

	[AccessedThroughProperty("_InheritedForm_Toolbars_Dock_Area_Right")]
	private UltraToolbarsDockArea __InheritedForm_Toolbars_Dock_Area_Right;

	[AccessedThroughProperty("_InheritedForm_Toolbars_Dock_Area_Top")]
	private UltraToolbarsDockArea __InheritedForm_Toolbars_Dock_Area_Top;

	[AccessedThroughProperty("_InheritedForm_Toolbars_Dock_Area_Bottom")]
	private UltraToolbarsDockArea __InheritedForm_Toolbars_Dock_Area_Bottom;

	[AccessedThroughProperty("CloseButton")]
	private UltraButton _CloseButton;

	private string _Caption;

	internal virtual Label lblLeft
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblLeft;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblLeft = value;
		}
	}

	internal virtual Label lblRight
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblRight;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblRight = value;
		}
	}

	internal virtual Label lblBottom
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblBottom;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblBottom = value;
		}
	}

	internal virtual Label lblTop
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblTop;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblTop = value;
		}
	}

	public virtual UltraGroupBox grForm
	{
		[DebuggerNonUserCode]
		get
		{
			return _grForm;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_grForm = value;
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
			_UltraToolbarsManager1 = value;
		}
	}

	internal virtual UltraToolbarsDockArea _InheritedForm_Toolbars_Dock_Area_Left
	{
		[DebuggerNonUserCode]
		get
		{
			return __InheritedForm_Toolbars_Dock_Area_Left;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__InheritedForm_Toolbars_Dock_Area_Left = value;
		}
	}

	internal virtual UltraToolbarsDockArea _InheritedForm_Toolbars_Dock_Area_Right
	{
		[DebuggerNonUserCode]
		get
		{
			return __InheritedForm_Toolbars_Dock_Area_Right;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__InheritedForm_Toolbars_Dock_Area_Right = value;
		}
	}

	internal virtual UltraToolbarsDockArea _InheritedForm_Toolbars_Dock_Area_Top
	{
		[DebuggerNonUserCode]
		get
		{
			return __InheritedForm_Toolbars_Dock_Area_Top;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__InheritedForm_Toolbars_Dock_Area_Top = value;
		}
	}

	internal virtual UltraToolbarsDockArea _InheritedForm_Toolbars_Dock_Area_Bottom
	{
		[DebuggerNonUserCode]
		get
		{
			return __InheritedForm_Toolbars_Dock_Area_Bottom;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__InheritedForm_Toolbars_Dock_Area_Bottom = value;
		}
	}

	public virtual UltraButton CloseButton
	{
		[DebuggerNonUserCode]
		get
		{
			return _CloseButton;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			if (_CloseButton != null)
			{
				((Control)_CloseButton).remove_Click((EventHandler)CloseButton_Click);
			}
			_CloseButton = value;
			if (_CloseButton != null)
			{
				((Control)_CloseButton).add_Click((EventHandler)CloseButton_Click);
			}
		}
	}

	public string Caption
	{
		get
		{
			return _Caption;
		}
		set
		{
			_Caption = value;
		}
	}

	public InheritedChildForm()
	{
		((Form)this).add_Load((EventHandler)InheritedForm_Load);
		__ENCList.Add(new WeakReference(this));
		_Caption = "UltraGroupBox1";
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
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Expected O, but got Unknown
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Expected O, but got Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Expected O, but got Unknown
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Expected O, but got Unknown
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Expected O, but got Unknown
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Expected O, but got Unknown
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Expected O, but got Unknown
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Expected O, but got Unknown
		//IL_0070: Unknown result type (might be due to invalid IL or missing references)
		//IL_007a: Expected O, but got Unknown
		//IL_007b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0085: Expected O, but got Unknown
		//IL_0086: Unknown result type (might be due to invalid IL or missing references)
		//IL_0090: Expected O, but got Unknown
		//IL_0091: Unknown result type (might be due to invalid IL or missing references)
		//IL_009b: Expected O, but got Unknown
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a6: Expected O, but got Unknown
		//IL_066f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0679: Expected O, but got Unknown
		//IL_07e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_07ed: Expected O, but got Unknown
		//IL_0800: Unknown result type (might be due to invalid IL or missing references)
		//IL_080a: Expected O, but got Unknown
		components = new Container();
		Appearance val = new Appearance();
		Appearance val2 = new Appearance();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(InheritedChildForm));
		lblLeft = new Label();
		lblRight = new Label();
		lblBottom = new Label();
		lblTop = new Label();
		grForm = new UltraGroupBox();
		UltraToolbarsManager1 = new UltraToolbarsManager(components);
		_InheritedForm_Toolbars_Dock_Area_Left = new UltraToolbarsDockArea();
		_InheritedForm_Toolbars_Dock_Area_Right = new UltraToolbarsDockArea();
		_InheritedForm_Toolbars_Dock_Area_Top = new UltraToolbarsDockArea();
		_InheritedForm_Toolbars_Dock_Area_Bottom = new UltraToolbarsDockArea();
		CloseButton = new UltraButton();
		((ISupportInitialize)grForm).BeginInit();
		((ISupportInitialize)UltraToolbarsManager1).BeginInit();
		((Control)this).SuspendLayout();
		((Control)lblLeft).set_BackColor(Color.SteelBlue);
		((Control)lblLeft).set_Dock((DockStyle)3);
		Label obj = lblLeft;
		Point location = new Point(4, 24);
		((Control)obj).set_Location(location);
		((Control)lblLeft).set_Name("lblLeft");
		Label obj2 = lblLeft;
		Size size = new Size(2, 376);
		((Control)obj2).set_Size(size);
		((Control)lblLeft).set_TabIndex(0);
		((Control)lblRight).set_BackColor(Color.SteelBlue);
		((Control)lblRight).set_Dock((DockStyle)4);
		Label obj3 = lblRight;
		location = new Point(495, 24);
		((Control)obj3).set_Location(location);
		((Control)lblRight).set_Name("lblRight");
		Label obj4 = lblRight;
		size = new Size(2, 376);
		((Control)obj4).set_Size(size);
		((Control)lblRight).set_TabIndex(1);
		((Control)lblBottom).set_BackColor(Color.SteelBlue);
		((Control)lblBottom).set_Dock((DockStyle)2);
		Label obj5 = lblBottom;
		location = new Point(6, 398);
		((Control)obj5).set_Location(location);
		((Control)lblBottom).set_Name("lblBottom");
		Label obj6 = lblBottom;
		size = new Size(489, 2);
		((Control)obj6).set_Size(size);
		((Control)lblBottom).set_TabIndex(2);
		((Control)lblTop).set_BackColor(Color.SteelBlue);
		((Control)lblTop).set_Dock((DockStyle)1);
		Label obj7 = lblTop;
		location = new Point(6, 24);
		((Control)obj7).set_Location(location);
		((Control)lblTop).set_Name("lblTop");
		Label obj8 = lblTop;
		size = new Size(489, 2);
		((Control)obj8).set_Size(size);
		((Control)lblTop).set_TabIndex(3);
		grForm.set_CaptionAlignment((GroupBoxCaptionAlignment)1);
		((Control)grForm).set_Dock((DockStyle)5);
		val.get_FontData().set_BoldAsString("True");
		val.get_FontData().set_SizeInPoints(10f);
		grForm.set_HeaderAppearance((AppearanceBase)(object)val);
		grForm.set_HeaderBorderStyle((UIElementBorderStyle)1);
		grForm.set_HeaderPosition((GroupBoxHeaderPosition)3);
		UltraGroupBox obj9 = grForm;
		location = new Point(4, 24);
		((Control)obj9).set_Location(location);
		((Control)grForm).set_Name("grForm");
		UltraGroupBox obj10 = grForm;
		size = new Size(493, 376);
		((Control)obj10).set_Size(size);
		((Control)grForm).set_TabIndex(4);
		grForm.set_ViewStyle((GroupBoxViewStyle)3);
		UltraToolbarsManager1.set_DesignerFlags(1);
		UltraToolbarsManager1.set_DockWithinContainer((Control)(object)this);
		UltraToolbarsManager1.set_Office2007UICompatibility(false);
		UltraToolbarsManager1.get_Ribbon().get_ApplicationMenu().set_Visible(false);
		UltraToolbarsManager1.get_Ribbon().get_QuickAccessToolbar().set_Visible(false);
		UltraToolbarsManager1.get_Ribbon().set_Visible(true);
		UltraToolbarsManager1.set_ShowFullMenusDelay(500);
		((Control)_InheritedForm_Toolbars_Dock_Area_Left).set_AccessibleRole((AccessibleRole)20);
		((Control)_InheritedForm_Toolbars_Dock_Area_Left).set_BackColor(Color.FromArgb(191, 219, 255));
		_InheritedForm_Toolbars_Dock_Area_Left.set_DockedPosition((DockedPosition)2);
		((Control)_InheritedForm_Toolbars_Dock_Area_Left).set_ForeColor(SystemColors.ControlText);
		_InheritedForm_Toolbars_Dock_Area_Left.set_InitialResizeAreaExtent(4);
		UltraToolbarsDockArea inheritedForm_Toolbars_Dock_Area_Left = _InheritedForm_Toolbars_Dock_Area_Left;
		location = new Point(0, 24);
		((Control)inheritedForm_Toolbars_Dock_Area_Left).set_Location(location);
		((Control)_InheritedForm_Toolbars_Dock_Area_Left).set_Name("_InheritedForm_Toolbars_Dock_Area_Left");
		UltraToolbarsDockArea inheritedForm_Toolbars_Dock_Area_Left2 = _InheritedForm_Toolbars_Dock_Area_Left;
		size = new Size(4, 376);
		((Control)inheritedForm_Toolbars_Dock_Area_Left2).set_Size(size);
		_InheritedForm_Toolbars_Dock_Area_Left.set_ToolbarsManager(UltraToolbarsManager1);
		((Control)_InheritedForm_Toolbars_Dock_Area_Right).set_AccessibleRole((AccessibleRole)20);
		((Control)_InheritedForm_Toolbars_Dock_Area_Right).set_BackColor(Color.FromArgb(191, 219, 255));
		_InheritedForm_Toolbars_Dock_Area_Right.set_DockedPosition((DockedPosition)3);
		((Control)_InheritedForm_Toolbars_Dock_Area_Right).set_ForeColor(SystemColors.ControlText);
		_InheritedForm_Toolbars_Dock_Area_Right.set_InitialResizeAreaExtent(4);
		UltraToolbarsDockArea inheritedForm_Toolbars_Dock_Area_Right = _InheritedForm_Toolbars_Dock_Area_Right;
		location = new Point(497, 24);
		((Control)inheritedForm_Toolbars_Dock_Area_Right).set_Location(location);
		((Control)_InheritedForm_Toolbars_Dock_Area_Right).set_Name("_InheritedForm_Toolbars_Dock_Area_Right");
		UltraToolbarsDockArea inheritedForm_Toolbars_Dock_Area_Right2 = _InheritedForm_Toolbars_Dock_Area_Right;
		size = new Size(4, 376);
		((Control)inheritedForm_Toolbars_Dock_Area_Right2).set_Size(size);
		_InheritedForm_Toolbars_Dock_Area_Right.set_ToolbarsManager(UltraToolbarsManager1);
		((Control)_InheritedForm_Toolbars_Dock_Area_Top).set_AccessibleRole((AccessibleRole)20);
		((Control)_InheritedForm_Toolbars_Dock_Area_Top).set_BackColor(Color.FromArgb(191, 219, 255));
		_InheritedForm_Toolbars_Dock_Area_Top.set_DockedPosition((DockedPosition)0);
		((Control)_InheritedForm_Toolbars_Dock_Area_Top).set_ForeColor(SystemColors.ControlText);
		UltraToolbarsDockArea inheritedForm_Toolbars_Dock_Area_Top = _InheritedForm_Toolbars_Dock_Area_Top;
		location = new Point(0, 0);
		((Control)inheritedForm_Toolbars_Dock_Area_Top).set_Location(location);
		((Control)_InheritedForm_Toolbars_Dock_Area_Top).set_Name("_InheritedForm_Toolbars_Dock_Area_Top");
		UltraToolbarsDockArea inheritedForm_Toolbars_Dock_Area_Top2 = _InheritedForm_Toolbars_Dock_Area_Top;
		size = new Size(501, 24);
		((Control)inheritedForm_Toolbars_Dock_Area_Top2).set_Size(size);
		_InheritedForm_Toolbars_Dock_Area_Top.set_ToolbarsManager(UltraToolbarsManager1);
		((Control)_InheritedForm_Toolbars_Dock_Area_Bottom).set_AccessibleRole((AccessibleRole)20);
		((Control)_InheritedForm_Toolbars_Dock_Area_Bottom).set_BackColor(Color.FromArgb(191, 219, 255));
		_InheritedForm_Toolbars_Dock_Area_Bottom.set_DockedPosition((DockedPosition)1);
		((Control)_InheritedForm_Toolbars_Dock_Area_Bottom).set_ForeColor(SystemColors.ControlText);
		_InheritedForm_Toolbars_Dock_Area_Bottom.set_InitialResizeAreaExtent(4);
		UltraToolbarsDockArea inheritedForm_Toolbars_Dock_Area_Bottom = _InheritedForm_Toolbars_Dock_Area_Bottom;
		location = new Point(0, 400);
		((Control)inheritedForm_Toolbars_Dock_Area_Bottom).set_Location(location);
		((Control)_InheritedForm_Toolbars_Dock_Area_Bottom).set_Name("_InheritedForm_Toolbars_Dock_Area_Bottom");
		UltraToolbarsDockArea inheritedForm_Toolbars_Dock_Area_Bottom2 = _InheritedForm_Toolbars_Dock_Area_Bottom;
		size = new Size(501, 4);
		((Control)inheritedForm_Toolbars_Dock_Area_Bottom2).set_Size(size);
		_InheritedForm_Toolbars_Dock_Area_Bottom.set_ToolbarsManager(UltraToolbarsManager1);
		val2.set_BorderColor(Color.Black);
		val2.set_BorderColor2(Color.Black);
		((ControlBase)CloseButton).set_Appearance((AppearanceBase)(object)val2);
		((UltraButtonBase)CloseButton).set_ButtonStyle((UIElementButtonStyle)17);
		((UltraButtonBase)CloseButton).set_DialogResult((DialogResult)2);
		((Control)CloseButton).set_Font(new Font("Verdana", 10f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		UltraButton closeButton = CloseButton;
		location = new Point(410, 346);
		((Control)closeButton).set_Location(location);
		((Control)CloseButton).set_Name("CloseButton");
		UltraButton closeButton2 = CloseButton;
		size = new Size(38, 21);
		((Control)closeButton2).set_Size(size);
		((Control)CloseButton).set_TabIndex(14);
		((ControlBase)CloseButton).set_Text("X");
		SizeF autoScaleDimensions = new SizeF(7f, 13f);
		((ContainerControl)this).set_AutoScaleDimensions(autoScaleDimensions);
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_BackColor(Color.AliceBlue);
		((Form)this).set_CancelButton((IButtonControl)(object)CloseButton);
		size = new Size(501, 404);
		((Form)this).set_ClientSize(size);
		((Control)this).get_Controls().Add((Control)(object)lblTop);
		((Control)this).get_Controls().Add((Control)(object)lblBottom);
		((Control)this).get_Controls().Add((Control)(object)lblRight);
		((Control)this).get_Controls().Add((Control)(object)lblLeft);
		((Control)this).get_Controls().Add((Control)(object)grForm);
		((Control)this).get_Controls().Add((Control)(object)CloseButton);
		((Control)this).get_Controls().Add((Control)(object)_InheritedForm_Toolbars_Dock_Area_Left);
		((Control)this).get_Controls().Add((Control)(object)_InheritedForm_Toolbars_Dock_Area_Right);
		((Control)this).get_Controls().Add((Control)(object)_InheritedForm_Toolbars_Dock_Area_Top);
		((Control)this).get_Controls().Add((Control)(object)_InheritedForm_Toolbars_Dock_Area_Bottom);
		((Control)this).set_Font(new Font("Verdana", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Form)this).set_FormBorderStyle((FormBorderStyle)1);
		((Form)this).set_Icon((Icon)componentResourceManager.GetObject("$this.Icon"));
		((Form)this).set_MaximizeBox(false);
		((Form)this).set_MinimizeBox(false);
		((Control)this).set_Name("InheritedChildForm");
		((Form)this).set_StartPosition((FormStartPosition)1);
		((ISupportInitialize)grForm).EndInit();
		((ISupportInitialize)UltraToolbarsManager1).EndInit();
		((Control)this).ResumeLayout(false);
	}

	private void InheritedForm_Load(object sender, EventArgs e)
	{
	}

	private void CloseButton_Click(object sender, EventArgs e)
	{
		((Form)this).Close();
	}
}
