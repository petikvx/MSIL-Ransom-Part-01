using System;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Reflection;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace Autodesk.ExpressTools.AliasEdit.Autodesk.ExpressTools.AliasEdit;

internal class frmNewShell : Form
{
	private IContainer components;

	public ToolTip ToolTip1;

	[AccessedThroughProperty("comboFlag")]
	private ComboBox _comboFlag;

	[AccessedThroughProperty("cmdOK")]
	private Button _cmdOK;

	[AccessedThroughProperty("cmdCancel")]
	private Button _cmdCancel;

	[AccessedThroughProperty("txtAlias")]
	private TextBox _txtAlias;

	[AccessedThroughProperty("txtPrompt")]
	private TextBox _txtPrompt;

	[AccessedThroughProperty("txtCommand")]
	private TextBox _txtCommand;

	[AccessedThroughProperty("_lblFlag_0")]
	private Label __lblFlag_0;

	[AccessedThroughProperty("_lblKeystroke_1")]
	private Label __lblKeystroke_1;

	[AccessedThroughProperty("lblPrompt")]
	private Label _lblPrompt;

	[AccessedThroughProperty("_lblCommand_1")]
	private Label __lblCommand_1;

	[AccessedThroughProperty("lblMain")]
	private Label _lblMain;

	public ArrayList lblCommand;

	public ArrayList lblFlag;

	public ArrayList lblKeystroke;

	private ResourceManager resManager;

	private static frmNewShell m_vb6FormDefInstance;

	private static bool m_InitializingDefInstance;

	public virtual ComboBox comboFlag
	{
		get
		{
			return _comboFlag;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_comboFlag = value;
		}
	}

	public virtual Button cmdOK
	{
		get
		{
			return _cmdOK;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			if (_cmdOK != null)
			{
				((Control)_cmdOK).remove_Click((EventHandler)cmdOK_Click);
			}
			_cmdOK = value;
			if (_cmdOK != null)
			{
				((Control)_cmdOK).add_Click((EventHandler)cmdOK_Click);
			}
		}
	}

	public virtual Button cmdCancel
	{
		get
		{
			return _cmdCancel;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			if (_cmdCancel != null)
			{
				((Control)_cmdCancel).remove_Click((EventHandler)cmdCancel_Click);
			}
			_cmdCancel = value;
			if (_cmdCancel != null)
			{
				((Control)_cmdCancel).add_Click((EventHandler)cmdCancel_Click);
			}
		}
	}

	public virtual TextBox txtAlias
	{
		get
		{
			return _txtAlias;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_txtAlias = value;
		}
	}

	public virtual TextBox txtPrompt
	{
		get
		{
			return _txtPrompt;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			if (_txtPrompt != null)
			{
				((Control)_txtPrompt).remove_Enter((EventHandler)txtPrompt_Enter);
			}
			_txtPrompt = value;
			if (_txtPrompt != null)
			{
				((Control)_txtPrompt).add_Enter((EventHandler)txtPrompt_Enter);
			}
		}
	}

	public virtual TextBox txtCommand
	{
		get
		{
			return _txtCommand;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			if (_txtCommand != null)
			{
				((Control)_txtCommand).remove_Enter((EventHandler)txtCommand_Enter);
			}
			_txtCommand = value;
			if (_txtCommand != null)
			{
				((Control)_txtCommand).add_Enter((EventHandler)txtCommand_Enter);
			}
		}
	}

	public virtual Label _lblFlag_0
	{
		get
		{
			return __lblFlag_0;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			__lblFlag_0 = value;
		}
	}

	public virtual Label _lblKeystroke_1
	{
		get
		{
			return __lblKeystroke_1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			__lblKeystroke_1 = value;
		}
	}

	public virtual Label lblPrompt
	{
		get
		{
			return _lblPrompt;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_lblPrompt = value;
		}
	}

	public virtual Label _lblCommand_1
	{
		get
		{
			return __lblCommand_1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			__lblCommand_1 = value;
		}
	}

	public virtual Label lblMain
	{
		get
		{
			return _lblMain;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_lblMain = value;
		}
	}

	public static frmNewShell DefInstance
	{
		get
		{
			if (m_vb6FormDefInstance == null || ((Control)m_vb6FormDefInstance).get_IsDisposed())
			{
				m_InitializingDefInstance = true;
				m_vb6FormDefInstance = new frmNewShell();
				m_InitializingDefInstance = false;
			}
			return m_vb6FormDefInstance;
		}
		set
		{
			m_vb6FormDefInstance = value;
		}
	}

	public frmNewShell()
	{
		((Form)this).add_Load((EventHandler)frmNewShell_Load);
		resManager = new ResourceManager(typeof(frmNewShell));
		if (m_vb6FormDefInstance == null)
		{
			if (m_InitializingDefInstance)
			{
				m_vb6FormDefInstance = this;
			}
			else
			{
				try
				{
					if ((object)Assembly.GetExecutingAssembly().EntryPoint!.DeclaringType == ((object)this).GetType())
					{
						m_vb6FormDefInstance = this;
					}
				}
				catch (Exception projectError)
				{
					ProjectData.SetProjectError(projectError);
					ProjectData.ClearProjectError();
				}
			}
		}
		InitializeComponent();
	}

	protected override void Dispose(bool Disposing)
	{
		if (Disposing && components != null)
		{
			components.Dispose();
		}
		((Form)this).Dispose(Disposing);
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
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0079: Expected O, but got Unknown
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0084: Expected O, but got Unknown
		//IL_0085: Unknown result type (might be due to invalid IL or missing references)
		//IL_008f: Expected O, but got Unknown
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		//IL_009a: Expected O, but got Unknown
		//IL_009b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a5: Expected O, but got Unknown
		//IL_0113: Unknown result type (might be due to invalid IL or missing references)
		//IL_011d: Expected O, but got Unknown
		//IL_0180: Unknown result type (might be due to invalid IL or missing references)
		//IL_018a: Expected O, but got Unknown
		//IL_046a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0474: Expected O, but got Unknown
		//IL_04e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_04f0: Expected O, but got Unknown
		//IL_0511: Unknown result type (might be due to invalid IL or missing references)
		//IL_051b: Expected O, but got Unknown
		//IL_06d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_06da: Expected O, but got Unknown
		//IL_0758: Unknown result type (might be due to invalid IL or missing references)
		//IL_0762: Expected O, but got Unknown
		//IL_0783: Unknown result type (might be due to invalid IL or missing references)
		//IL_078d: Expected O, but got Unknown
		//IL_0969: Unknown result type (might be due to invalid IL or missing references)
		//IL_0973: Expected O, but got Unknown
		//IL_09ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_09d4: Expected O, but got Unknown
		//IL_0c11: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c1b: Expected O, but got Unknown
		//IL_0c72: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c7c: Expected O, but got Unknown
		//IL_0eb9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ec3: Expected O, but got Unknown
		//IL_0f1a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f24: Expected O, but got Unknown
		//IL_119b: Unknown result type (might be due to invalid IL or missing references)
		//IL_11a5: Expected O, but got Unknown
		//IL_11c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_11d0: Expected O, but got Unknown
		//IL_13e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_13f0: Expected O, but got Unknown
		//IL_1411: Unknown result type (might be due to invalid IL or missing references)
		//IL_141b: Expected O, but got Unknown
		//IL_1631: Unknown result type (might be due to invalid IL or missing references)
		//IL_163b: Expected O, but got Unknown
		//IL_165c: Unknown result type (might be due to invalid IL or missing references)
		//IL_1666: Expected O, but got Unknown
		//IL_187c: Unknown result type (might be due to invalid IL or missing references)
		//IL_1886: Expected O, but got Unknown
		//IL_18a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_18b1: Expected O, but got Unknown
		//IL_1ac7: Unknown result type (might be due to invalid IL or missing references)
		//IL_1ad1: Expected O, but got Unknown
		//IL_1af2: Unknown result type (might be due to invalid IL or missing references)
		//IL_1afc: Expected O, but got Unknown
		//IL_1d0a: Unknown result type (might be due to invalid IL or missing references)
		//IL_1d14: Expected O, but got Unknown
		//IL_1e31: Unknown result type (might be due to invalid IL or missing references)
		//IL_1e3b: Expected O, but got Unknown
		//IL_1e55: Unknown result type (might be due to invalid IL or missing references)
		//IL_1e5f: Expected O, but got Unknown
		components = new Container();
		ResourceManager resourceManager = new ResourceManager(typeof(frmNewShell));
		ToolTip1 = new ToolTip(components);
		comboFlag = new ComboBox();
		cmdOK = new Button();
		cmdCancel = new Button();
		txtAlias = new TextBox();
		txtPrompt = new TextBox();
		txtCommand = new TextBox();
		_lblFlag_0 = new Label();
		_lblKeystroke_1 = new Label();
		lblPrompt = new Label();
		_lblCommand_1 = new Label();
		lblMain = new Label();
		((Control)this).SuspendLayout();
		((Control)comboFlag).set_AccessibleDescription(resourceManager.GetString("comboFlag.AccessibleDescription"));
		((Control)comboFlag).set_AccessibleName(resourceManager.GetString("comboFlag.AccessibleName"));
		((Control)comboFlag).set_Anchor((AnchorStyles)Conversions.ToInteger(resourceManager.GetObject("comboFlag.Anchor")));
		comboFlag.set_BackColor(SystemColors.Window);
		comboFlag.set_BackgroundImage((Image)resourceManager.GetObject("comboFlag.BackgroundImage"));
		((Control)comboFlag).set_Cursor(Cursors.get_Default());
		((Control)comboFlag).set_Dock((DockStyle)Conversions.ToInteger(resourceManager.GetObject("comboFlag.Dock")));
		comboFlag.set_DropDownStyle((ComboBoxStyle)2);
		((Control)comboFlag).set_Enabled(Conversions.ToBoolean(resourceManager.GetObject("comboFlag.Enabled")));
		((Control)comboFlag).set_Font((Font)resourceManager.GetObject("comboFlag.Font"));
		comboFlag.set_ForeColor(SystemColors.WindowText);
		((Control)comboFlag).set_ImeMode((ImeMode)Conversions.ToInteger(resourceManager.GetObject("comboFlag.ImeMode")));
		comboFlag.set_IntegralHeight(Conversions.ToBoolean(resourceManager.GetObject("comboFlag.IntegralHeight")));
		comboFlag.set_ItemHeight(Conversions.ToInteger(resourceManager.GetObject("comboFlag.ItemHeight")));
		comboFlag.get_Items().AddRange(new object[16]
		{
			resourceManager.GetString("comboFlag.Items"),
			resourceManager.GetString("comboFlag.Items1"),
			resourceManager.GetString("comboFlag.Items2"),
			resourceManager.GetString("comboFlag.Items3"),
			resourceManager.GetString("comboFlag.Items4"),
			resourceManager.GetString("comboFlag.Items5"),
			resourceManager.GetString("comboFlag.Items6"),
			resourceManager.GetString("comboFlag.Items7"),
			resourceManager.GetString("comboFlag.Items8"),
			resourceManager.GetString("comboFlag.Items9"),
			resourceManager.GetString("comboFlag.Items10"),
			resourceManager.GetString("comboFlag.Items11"),
			resourceManager.GetString("comboFlag.Items12"),
			resourceManager.GetString("comboFlag.Items13"),
			resourceManager.GetString("comboFlag.Items14"),
			resourceManager.GetString("comboFlag.Items15")
		});
		ComboBox obj = comboFlag;
		object? @object = resourceManager.GetObject("comboFlag.Location");
		Point point = default(Point);
		((Control)obj).set_Location((@object != null) ? ((Point)@object) : point);
		comboFlag.set_MaxDropDownItems(Conversions.ToInteger(resourceManager.GetObject("comboFlag.MaxDropDownItems")));
		comboFlag.set_MaxLength(Conversions.ToInteger(resourceManager.GetObject("comboFlag.MaxLength")));
		((Control)comboFlag).set_Name("comboFlag");
		((Control)comboFlag).set_RightToLeft((RightToLeft)Conversions.ToInteger(resourceManager.GetObject("comboFlag.RightToLeft")));
		ComboBox obj2 = comboFlag;
		object? object2 = resourceManager.GetObject("comboFlag.Size");
		Size size = default(Size);
		((Control)obj2).set_Size((object2 != null) ? ((Size)object2) : size);
		((Control)comboFlag).set_TabIndex(Conversions.ToInteger(resourceManager.GetObject("comboFlag.TabIndex")));
		comboFlag.set_Text(resourceManager.GetString("comboFlag.Text"));
		ToolTip1.SetToolTip((Control)(object)comboFlag, resourceManager.GetString("comboFlag.ToolTip"));
		((Control)comboFlag).set_Visible(Conversions.ToBoolean(resourceManager.GetObject("comboFlag.Visible")));
		((Control)cmdOK).set_AccessibleDescription(resourceManager.GetString("cmdOK.AccessibleDescription"));
		((Control)cmdOK).set_AccessibleName(resourceManager.GetString("cmdOK.AccessibleName"));
		((Control)cmdOK).set_Anchor((AnchorStyles)Conversions.ToInteger(resourceManager.GetObject("cmdOK.Anchor")));
		((ButtonBase)cmdOK).set_BackColor(SystemColors.Control);
		((Control)cmdOK).set_BackgroundImage((Image)resourceManager.GetObject("cmdOK.BackgroundImage"));
		((Control)cmdOK).set_Cursor(Cursors.get_Default());
		((Control)cmdOK).set_Dock((DockStyle)Conversions.ToInteger(resourceManager.GetObject("cmdOK.Dock")));
		((Control)cmdOK).set_Enabled(Conversions.ToBoolean(resourceManager.GetObject("cmdOK.Enabled")));
		((ButtonBase)cmdOK).set_FlatStyle((FlatStyle)Conversions.ToInteger(resourceManager.GetObject("cmdOK.FlatStyle")));
		((Control)cmdOK).set_Font((Font)resourceManager.GetObject("cmdOK.Font"));
		((Control)cmdOK).set_ForeColor(SystemColors.ControlText);
		((ButtonBase)cmdOK).set_Image((Image)resourceManager.GetObject("cmdOK.Image"));
		((ButtonBase)cmdOK).set_ImageAlign((ContentAlignment)Conversions.ToInteger(resourceManager.GetObject("cmdOK.ImageAlign")));
		((ButtonBase)cmdOK).set_ImageIndex(Conversions.ToInteger(resourceManager.GetObject("cmdOK.ImageIndex")));
		((ButtonBase)cmdOK).set_ImeMode((ImeMode)Conversions.ToInteger(resourceManager.GetObject("cmdOK.ImeMode")));
		Button obj3 = cmdOK;
		object? object3 = resourceManager.GetObject("cmdOK.Location");
		((Control)obj3).set_Location((object3 != null) ? ((Point)object3) : point);
		((Control)cmdOK).set_Name("cmdOK");
		((Control)cmdOK).set_RightToLeft((RightToLeft)Conversions.ToInteger(resourceManager.GetObject("cmdOK.RightToLeft")));
		Button obj4 = cmdOK;
		object? object4 = resourceManager.GetObject("cmdOK.Size");
		((Control)obj4).set_Size((object4 != null) ? ((Size)object4) : size);
		((Control)cmdOK).set_TabIndex(Conversions.ToInteger(resourceManager.GetObject("cmdOK.TabIndex")));
		((ButtonBase)cmdOK).set_Text(resourceManager.GetString("cmdOK.Text"));
		((ButtonBase)cmdOK).set_TextAlign((ContentAlignment)Conversions.ToInteger(resourceManager.GetObject("cmdOK.TextAlign")));
		ToolTip1.SetToolTip((Control)(object)cmdOK, resourceManager.GetString("cmdOK.ToolTip"));
		((Control)cmdOK).set_Visible(Conversions.ToBoolean(resourceManager.GetObject("cmdOK.Visible")));
		((Control)cmdCancel).set_AccessibleDescription(resourceManager.GetString("cmdCancel.AccessibleDescription"));
		((Control)cmdCancel).set_AccessibleName(resourceManager.GetString("cmdCancel.AccessibleName"));
		((Control)cmdCancel).set_Anchor((AnchorStyles)Conversions.ToInteger(resourceManager.GetObject("cmdCancel.Anchor")));
		((ButtonBase)cmdCancel).set_BackColor(SystemColors.Control);
		((Control)cmdCancel).set_BackgroundImage((Image)resourceManager.GetObject("cmdCancel.BackgroundImage"));
		((Control)cmdCancel).set_Cursor(Cursors.get_Default());
		cmdCancel.set_DialogResult((DialogResult)2);
		((Control)cmdCancel).set_Dock((DockStyle)Conversions.ToInteger(resourceManager.GetObject("cmdCancel.Dock")));
		((Control)cmdCancel).set_Enabled(Conversions.ToBoolean(resourceManager.GetObject("cmdCancel.Enabled")));
		((ButtonBase)cmdCancel).set_FlatStyle((FlatStyle)Conversions.ToInteger(resourceManager.GetObject("cmdCancel.FlatStyle")));
		((Control)cmdCancel).set_Font((Font)resourceManager.GetObject("cmdCancel.Font"));
		((Control)cmdCancel).set_ForeColor(SystemColors.ControlText);
		((ButtonBase)cmdCancel).set_Image((Image)resourceManager.GetObject("cmdCancel.Image"));
		((ButtonBase)cmdCancel).set_ImageAlign((ContentAlignment)Conversions.ToInteger(resourceManager.GetObject("cmdCancel.ImageAlign")));
		((ButtonBase)cmdCancel).set_ImageIndex(Conversions.ToInteger(resourceManager.GetObject("cmdCancel.ImageIndex")));
		((ButtonBase)cmdCancel).set_ImeMode((ImeMode)Conversions.ToInteger(resourceManager.GetObject("cmdCancel.ImeMode")));
		Button obj5 = cmdCancel;
		object? object5 = resourceManager.GetObject("cmdCancel.Location");
		((Control)obj5).set_Location((object5 != null) ? ((Point)object5) : point);
		((Control)cmdCancel).set_Name("cmdCancel");
		((Control)cmdCancel).set_RightToLeft((RightToLeft)Conversions.ToInteger(resourceManager.GetObject("cmdCancel.RightToLeft")));
		Button obj6 = cmdCancel;
		object? object6 = resourceManager.GetObject("cmdCancel.Size");
		((Control)obj6).set_Size((object6 != null) ? ((Size)object6) : size);
		((Control)cmdCancel).set_TabIndex(Conversions.ToInteger(resourceManager.GetObject("cmdCancel.TabIndex")));
		((ButtonBase)cmdCancel).set_Text(resourceManager.GetString("cmdCancel.Text"));
		((ButtonBase)cmdCancel).set_TextAlign((ContentAlignment)Conversions.ToInteger(resourceManager.GetObject("cmdCancel.TextAlign")));
		ToolTip1.SetToolTip((Control)(object)cmdCancel, resourceManager.GetString("cmdCancel.ToolTip"));
		((Control)cmdCancel).set_Visible(Conversions.ToBoolean(resourceManager.GetObject("cmdCancel.Visible")));
		txtAlias.set_AcceptsReturn(true);
		((Control)txtAlias).set_AccessibleDescription(resourceManager.GetString("txtAlias.AccessibleDescription"));
		((Control)txtAlias).set_AccessibleName(resourceManager.GetString("txtAlias.AccessibleName"));
		((Control)txtAlias).set_Anchor((AnchorStyles)Conversions.ToInteger(resourceManager.GetObject("txtAlias.Anchor")));
		((TextBoxBase)txtAlias).set_AutoSize(Conversions.ToBoolean(resourceManager.GetObject("txtAlias.AutoSize")));
		((TextBoxBase)txtAlias).set_BackColor(SystemColors.Window);
		((TextBoxBase)txtAlias).set_BackgroundImage((Image)resourceManager.GetObject("txtAlias.BackgroundImage"));
		((Control)txtAlias).set_Cursor(Cursors.get_IBeam());
		((Control)txtAlias).set_Dock((DockStyle)Conversions.ToInteger(resourceManager.GetObject("txtAlias.Dock")));
		((Control)txtAlias).set_Enabled(Conversions.ToBoolean(resourceManager.GetObject("txtAlias.Enabled")));
		((Control)txtAlias).set_Font((Font)resourceManager.GetObject("txtAlias.Font"));
		((TextBoxBase)txtAlias).set_ForeColor(SystemColors.WindowText);
		((Control)txtAlias).set_ImeMode((ImeMode)Conversions.ToInteger(resourceManager.GetObject("txtAlias.ImeMode")));
		TextBox obj7 = txtAlias;
		object? object7 = resourceManager.GetObject("txtAlias.Location");
		((Control)obj7).set_Location((object7 != null) ? ((Point)object7) : point);
		((TextBoxBase)txtAlias).set_MaxLength(Conversions.ToInteger(resourceManager.GetObject("txtAlias.MaxLength")));
		txtAlias.set_Multiline(Conversions.ToBoolean(resourceManager.GetObject("txtAlias.Multiline")));
		((Control)txtAlias).set_Name("txtAlias");
		txtAlias.set_PasswordChar(Conversions.ToChar(resourceManager.GetObject("txtAlias.PasswordChar")));
		((Control)txtAlias).set_RightToLeft((RightToLeft)Conversions.ToInteger(resourceManager.GetObject("txtAlias.RightToLeft")));
		txtAlias.set_ScrollBars((ScrollBars)Conversions.ToInteger(resourceManager.GetObject("txtAlias.ScrollBars")));
		TextBox obj8 = txtAlias;
		object? object8 = resourceManager.GetObject("txtAlias.Size");
		((Control)obj8).set_Size((object8 != null) ? ((Size)object8) : size);
		((Control)txtAlias).set_TabIndex(Conversions.ToInteger(resourceManager.GetObject("txtAlias.TabIndex")));
		txtAlias.set_Text(resourceManager.GetString("txtAlias.Text"));
		txtAlias.set_TextAlign((HorizontalAlignment)Conversions.ToInteger(resourceManager.GetObject("txtAlias.TextAlign")));
		ToolTip1.SetToolTip((Control)(object)txtAlias, resourceManager.GetString("txtAlias.ToolTip"));
		((Control)txtAlias).set_Visible(Conversions.ToBoolean(resourceManager.GetObject("txtAlias.Visible")));
		((TextBoxBase)txtAlias).set_WordWrap(Conversions.ToBoolean(resourceManager.GetObject("txtAlias.WordWrap")));
		txtPrompt.set_AcceptsReturn(true);
		((Control)txtPrompt).set_AccessibleDescription(resourceManager.GetString("txtPrompt.AccessibleDescription"));
		((Control)txtPrompt).set_AccessibleName(resourceManager.GetString("txtPrompt.AccessibleName"));
		((Control)txtPrompt).set_Anchor((AnchorStyles)Conversions.ToInteger(resourceManager.GetObject("txtPrompt.Anchor")));
		((TextBoxBase)txtPrompt).set_AutoSize(Conversions.ToBoolean(resourceManager.GetObject("txtPrompt.AutoSize")));
		((TextBoxBase)txtPrompt).set_BackColor(SystemColors.Window);
		((TextBoxBase)txtPrompt).set_BackgroundImage((Image)resourceManager.GetObject("txtPrompt.BackgroundImage"));
		((Control)txtPrompt).set_Cursor(Cursors.get_IBeam());
		((Control)txtPrompt).set_Dock((DockStyle)Conversions.ToInteger(resourceManager.GetObject("txtPrompt.Dock")));
		((Control)txtPrompt).set_Enabled(Conversions.ToBoolean(resourceManager.GetObject("txtPrompt.Enabled")));
		((Control)txtPrompt).set_Font((Font)resourceManager.GetObject("txtPrompt.Font"));
		((TextBoxBase)txtPrompt).set_ForeColor(SystemColors.WindowText);
		((Control)txtPrompt).set_ImeMode((ImeMode)Conversions.ToInteger(resourceManager.GetObject("txtPrompt.ImeMode")));
		TextBox obj9 = txtPrompt;
		object? object9 = resourceManager.GetObject("txtPrompt.Location");
		((Control)obj9).set_Location((object9 != null) ? ((Point)object9) : point);
		((TextBoxBase)txtPrompt).set_MaxLength(Conversions.ToInteger(resourceManager.GetObject("txtPrompt.MaxLength")));
		txtPrompt.set_Multiline(Conversions.ToBoolean(resourceManager.GetObject("txtPrompt.Multiline")));
		((Control)txtPrompt).set_Name("txtPrompt");
		txtPrompt.set_PasswordChar(Conversions.ToChar(resourceManager.GetObject("txtPrompt.PasswordChar")));
		((Control)txtPrompt).set_RightToLeft((RightToLeft)Conversions.ToInteger(resourceManager.GetObject("txtPrompt.RightToLeft")));
		txtPrompt.set_ScrollBars((ScrollBars)Conversions.ToInteger(resourceManager.GetObject("txtPrompt.ScrollBars")));
		TextBox obj10 = txtPrompt;
		object? object10 = resourceManager.GetObject("txtPrompt.Size");
		((Control)obj10).set_Size((object10 != null) ? ((Size)object10) : size);
		((Control)txtPrompt).set_TabIndex(Conversions.ToInteger(resourceManager.GetObject("txtPrompt.TabIndex")));
		txtPrompt.set_Text(resourceManager.GetString("txtPrompt.Text"));
		txtPrompt.set_TextAlign((HorizontalAlignment)Conversions.ToInteger(resourceManager.GetObject("txtPrompt.TextAlign")));
		ToolTip1.SetToolTip((Control)(object)txtPrompt, resourceManager.GetString("txtPrompt.ToolTip"));
		((Control)txtPrompt).set_Visible(Conversions.ToBoolean(resourceManager.GetObject("txtPrompt.Visible")));
		((TextBoxBase)txtPrompt).set_WordWrap(Conversions.ToBoolean(resourceManager.GetObject("txtPrompt.WordWrap")));
		txtCommand.set_AcceptsReturn(true);
		((Control)txtCommand).set_AccessibleDescription(resourceManager.GetString("txtCommand.AccessibleDescription"));
		((Control)txtCommand).set_AccessibleName(resourceManager.GetString("txtCommand.AccessibleName"));
		((Control)txtCommand).set_Anchor((AnchorStyles)Conversions.ToInteger(resourceManager.GetObject("txtCommand.Anchor")));
		((TextBoxBase)txtCommand).set_AutoSize(Conversions.ToBoolean(resourceManager.GetObject("txtCommand.AutoSize")));
		((TextBoxBase)txtCommand).set_BackColor(SystemColors.Window);
		((TextBoxBase)txtCommand).set_BackgroundImage((Image)resourceManager.GetObject("txtCommand.BackgroundImage"));
		((Control)txtCommand).set_Cursor(Cursors.get_IBeam());
		((Control)txtCommand).set_Dock((DockStyle)Conversions.ToInteger(resourceManager.GetObject("txtCommand.Dock")));
		((Control)txtCommand).set_Enabled(Conversions.ToBoolean(resourceManager.GetObject("txtCommand.Enabled")));
		((Control)txtCommand).set_Font((Font)resourceManager.GetObject("txtCommand.Font"));
		((TextBoxBase)txtCommand).set_ForeColor(SystemColors.WindowText);
		((Control)txtCommand).set_ImeMode((ImeMode)Conversions.ToInteger(resourceManager.GetObject("txtCommand.ImeMode")));
		TextBox obj11 = txtCommand;
		object? object11 = resourceManager.GetObject("txtCommand.Location");
		((Control)obj11).set_Location((object11 != null) ? ((Point)object11) : point);
		((TextBoxBase)txtCommand).set_MaxLength(Conversions.ToInteger(resourceManager.GetObject("txtCommand.MaxLength")));
		txtCommand.set_Multiline(Conversions.ToBoolean(resourceManager.GetObject("txtCommand.Multiline")));
		((Control)txtCommand).set_Name("txtCommand");
		txtCommand.set_PasswordChar(Conversions.ToChar(resourceManager.GetObject("txtCommand.PasswordChar")));
		((Control)txtCommand).set_RightToLeft((RightToLeft)Conversions.ToInteger(resourceManager.GetObject("txtCommand.RightToLeft")));
		txtCommand.set_ScrollBars((ScrollBars)Conversions.ToInteger(resourceManager.GetObject("txtCommand.ScrollBars")));
		TextBox obj12 = txtCommand;
		object? object12 = resourceManager.GetObject("txtCommand.Size");
		((Control)obj12).set_Size((object12 != null) ? ((Size)object12) : size);
		((Control)txtCommand).set_TabIndex(Conversions.ToInteger(resourceManager.GetObject("txtCommand.TabIndex")));
		txtCommand.set_Text(resourceManager.GetString("txtCommand.Text"));
		txtCommand.set_TextAlign((HorizontalAlignment)Conversions.ToInteger(resourceManager.GetObject("txtCommand.TextAlign")));
		ToolTip1.SetToolTip((Control)(object)txtCommand, resourceManager.GetString("txtCommand.ToolTip"));
		((Control)txtCommand).set_Visible(Conversions.ToBoolean(resourceManager.GetObject("txtCommand.Visible")));
		((TextBoxBase)txtCommand).set_WordWrap(Conversions.ToBoolean(resourceManager.GetObject("txtCommand.WordWrap")));
		((Control)_lblFlag_0).set_AccessibleDescription(resourceManager.GetString("_lblFlag_0.AccessibleDescription"));
		((Control)_lblFlag_0).set_AccessibleName(resourceManager.GetString("_lblFlag_0.AccessibleName"));
		((Control)_lblFlag_0).set_Anchor((AnchorStyles)Conversions.ToInteger(resourceManager.GetObject("_lblFlag_0.Anchor")));
		_lblFlag_0.set_AutoSize(Conversions.ToBoolean(resourceManager.GetObject("_lblFlag_0.AutoSize")));
		((Control)_lblFlag_0).set_BackColor(SystemColors.Control);
		((Control)_lblFlag_0).set_Cursor(Cursors.get_Default());
		((Control)_lblFlag_0).set_Dock((DockStyle)Conversions.ToInteger(resourceManager.GetObject("_lblFlag_0.Dock")));
		((Control)_lblFlag_0).set_Enabled(Conversions.ToBoolean(resourceManager.GetObject("_lblFlag_0.Enabled")));
		((Control)_lblFlag_0).set_Font((Font)resourceManager.GetObject("_lblFlag_0.Font"));
		((Control)_lblFlag_0).set_ForeColor(SystemColors.ControlText);
		_lblFlag_0.set_Image((Image)resourceManager.GetObject("_lblFlag_0.Image"));
		_lblFlag_0.set_ImageAlign((ContentAlignment)Conversions.ToInteger(resourceManager.GetObject("_lblFlag_0.ImageAlign")));
		_lblFlag_0.set_ImageIndex(Conversions.ToInteger(resourceManager.GetObject("_lblFlag_0.ImageIndex")));
		_lblFlag_0.set_ImeMode((ImeMode)Conversions.ToInteger(resourceManager.GetObject("_lblFlag_0.ImeMode")));
		Label lblFlag_ = _lblFlag_0;
		object? object13 = resourceManager.GetObject("_lblFlag_0.Location");
		((Control)lblFlag_).set_Location((object13 != null) ? ((Point)object13) : point);
		((Control)_lblFlag_0).set_Name("_lblFlag_0");
		((Control)_lblFlag_0).set_RightToLeft((RightToLeft)Conversions.ToInteger(resourceManager.GetObject("_lblFlag_0.RightToLeft")));
		Label lblFlag_2 = _lblFlag_0;
		object? object14 = resourceManager.GetObject("_lblFlag_0.Size");
		((Control)lblFlag_2).set_Size((object14 != null) ? ((Size)object14) : size);
		((Control)_lblFlag_0).set_TabIndex(Conversions.ToInteger(resourceManager.GetObject("_lblFlag_0.TabIndex")));
		_lblFlag_0.set_Text(resourceManager.GetString("_lblFlag_0.Text"));
		_lblFlag_0.set_TextAlign((ContentAlignment)Conversions.ToInteger(resourceManager.GetObject("_lblFlag_0.TextAlign")));
		ToolTip1.SetToolTip((Control)(object)_lblFlag_0, resourceManager.GetString("_lblFlag_0.ToolTip"));
		((Control)_lblFlag_0).set_Visible(Conversions.ToBoolean(resourceManager.GetObject("_lblFlag_0.Visible")));
		((Control)_lblKeystroke_1).set_AccessibleDescription(resourceManager.GetString("_lblKeystroke_1.AccessibleDescription"));
		((Control)_lblKeystroke_1).set_AccessibleName(resourceManager.GetString("_lblKeystroke_1.AccessibleName"));
		((Control)_lblKeystroke_1).set_Anchor((AnchorStyles)Conversions.ToInteger(resourceManager.GetObject("_lblKeystroke_1.Anchor")));
		_lblKeystroke_1.set_AutoSize(Conversions.ToBoolean(resourceManager.GetObject("_lblKeystroke_1.AutoSize")));
		((Control)_lblKeystroke_1).set_BackColor(SystemColors.Control);
		((Control)_lblKeystroke_1).set_Cursor(Cursors.get_Default());
		((Control)_lblKeystroke_1).set_Dock((DockStyle)Conversions.ToInteger(resourceManager.GetObject("_lblKeystroke_1.Dock")));
		((Control)_lblKeystroke_1).set_Enabled(Conversions.ToBoolean(resourceManager.GetObject("_lblKeystroke_1.Enabled")));
		((Control)_lblKeystroke_1).set_Font((Font)resourceManager.GetObject("_lblKeystroke_1.Font"));
		((Control)_lblKeystroke_1).set_ForeColor(SystemColors.ControlText);
		_lblKeystroke_1.set_Image((Image)resourceManager.GetObject("_lblKeystroke_1.Image"));
		_lblKeystroke_1.set_ImageAlign((ContentAlignment)Conversions.ToInteger(resourceManager.GetObject("_lblKeystroke_1.ImageAlign")));
		_lblKeystroke_1.set_ImageIndex(Conversions.ToInteger(resourceManager.GetObject("_lblKeystroke_1.ImageIndex")));
		_lblKeystroke_1.set_ImeMode((ImeMode)Conversions.ToInteger(resourceManager.GetObject("_lblKeystroke_1.ImeMode")));
		Label lblKeystroke_ = _lblKeystroke_1;
		object? object15 = resourceManager.GetObject("_lblKeystroke_1.Location");
		((Control)lblKeystroke_).set_Location((object15 != null) ? ((Point)object15) : point);
		((Control)_lblKeystroke_1).set_Name("_lblKeystroke_1");
		((Control)_lblKeystroke_1).set_RightToLeft((RightToLeft)Conversions.ToInteger(resourceManager.GetObject("_lblKeystroke_1.RightToLeft")));
		Label lblKeystroke_2 = _lblKeystroke_1;
		object? object16 = resourceManager.GetObject("_lblKeystroke_1.Size");
		((Control)lblKeystroke_2).set_Size((object16 != null) ? ((Size)object16) : size);
		((Control)_lblKeystroke_1).set_TabIndex(Conversions.ToInteger(resourceManager.GetObject("_lblKeystroke_1.TabIndex")));
		_lblKeystroke_1.set_Text(resourceManager.GetString("_lblKeystroke_1.Text"));
		_lblKeystroke_1.set_TextAlign((ContentAlignment)Conversions.ToInteger(resourceManager.GetObject("_lblKeystroke_1.TextAlign")));
		ToolTip1.SetToolTip((Control)(object)_lblKeystroke_1, resourceManager.GetString("_lblKeystroke_1.ToolTip"));
		((Control)_lblKeystroke_1).set_Visible(Conversions.ToBoolean(resourceManager.GetObject("_lblKeystroke_1.Visible")));
		((Control)lblPrompt).set_AccessibleDescription(resourceManager.GetString("lblPrompt.AccessibleDescription"));
		((Control)lblPrompt).set_AccessibleName(resourceManager.GetString("lblPrompt.AccessibleName"));
		((Control)lblPrompt).set_Anchor((AnchorStyles)Conversions.ToInteger(resourceManager.GetObject("lblPrompt.Anchor")));
		lblPrompt.set_AutoSize(Conversions.ToBoolean(resourceManager.GetObject("lblPrompt.AutoSize")));
		((Control)lblPrompt).set_BackColor(SystemColors.Control);
		((Control)lblPrompt).set_Cursor(Cursors.get_Default());
		((Control)lblPrompt).set_Dock((DockStyle)Conversions.ToInteger(resourceManager.GetObject("lblPrompt.Dock")));
		((Control)lblPrompt).set_Enabled(Conversions.ToBoolean(resourceManager.GetObject("lblPrompt.Enabled")));
		((Control)lblPrompt).set_Font((Font)resourceManager.GetObject("lblPrompt.Font"));
		((Control)lblPrompt).set_ForeColor(SystemColors.ControlText);
		lblPrompt.set_Image((Image)resourceManager.GetObject("lblPrompt.Image"));
		lblPrompt.set_ImageAlign((ContentAlignment)Conversions.ToInteger(resourceManager.GetObject("lblPrompt.ImageAlign")));
		lblPrompt.set_ImageIndex(Conversions.ToInteger(resourceManager.GetObject("lblPrompt.ImageIndex")));
		lblPrompt.set_ImeMode((ImeMode)Conversions.ToInteger(resourceManager.GetObject("lblPrompt.ImeMode")));
		Label obj13 = lblPrompt;
		object? object17 = resourceManager.GetObject("lblPrompt.Location");
		((Control)obj13).set_Location((object17 != null) ? ((Point)object17) : point);
		((Control)lblPrompt).set_Name("lblPrompt");
		((Control)lblPrompt).set_RightToLeft((RightToLeft)Conversions.ToInteger(resourceManager.GetObject("lblPrompt.RightToLeft")));
		Label obj14 = lblPrompt;
		object? object18 = resourceManager.GetObject("lblPrompt.Size");
		((Control)obj14).set_Size((object18 != null) ? ((Size)object18) : size);
		((Control)lblPrompt).set_TabIndex(Conversions.ToInteger(resourceManager.GetObject("lblPrompt.TabIndex")));
		lblPrompt.set_Text(resourceManager.GetString("lblPrompt.Text"));
		lblPrompt.set_TextAlign((ContentAlignment)Conversions.ToInteger(resourceManager.GetObject("lblPrompt.TextAlign")));
		ToolTip1.SetToolTip((Control)(object)lblPrompt, resourceManager.GetString("lblPrompt.ToolTip"));
		((Control)lblPrompt).set_Visible(Conversions.ToBoolean(resourceManager.GetObject("lblPrompt.Visible")));
		((Control)_lblCommand_1).set_AccessibleDescription(resourceManager.GetString("_lblCommand_1.AccessibleDescription"));
		((Control)_lblCommand_1).set_AccessibleName(resourceManager.GetString("_lblCommand_1.AccessibleName"));
		((Control)_lblCommand_1).set_Anchor((AnchorStyles)Conversions.ToInteger(resourceManager.GetObject("_lblCommand_1.Anchor")));
		_lblCommand_1.set_AutoSize(Conversions.ToBoolean(resourceManager.GetObject("_lblCommand_1.AutoSize")));
		((Control)_lblCommand_1).set_BackColor(SystemColors.Control);
		((Control)_lblCommand_1).set_Cursor(Cursors.get_Default());
		((Control)_lblCommand_1).set_Dock((DockStyle)Conversions.ToInteger(resourceManager.GetObject("_lblCommand_1.Dock")));
		((Control)_lblCommand_1).set_Enabled(Conversions.ToBoolean(resourceManager.GetObject("_lblCommand_1.Enabled")));
		((Control)_lblCommand_1).set_Font((Font)resourceManager.GetObject("_lblCommand_1.Font"));
		((Control)_lblCommand_1).set_ForeColor(SystemColors.ControlText);
		_lblCommand_1.set_Image((Image)resourceManager.GetObject("_lblCommand_1.Image"));
		_lblCommand_1.set_ImageAlign((ContentAlignment)Conversions.ToInteger(resourceManager.GetObject("_lblCommand_1.ImageAlign")));
		_lblCommand_1.set_ImageIndex(Conversions.ToInteger(resourceManager.GetObject("_lblCommand_1.ImageIndex")));
		_lblCommand_1.set_ImeMode((ImeMode)Conversions.ToInteger(resourceManager.GetObject("_lblCommand_1.ImeMode")));
		Label lblCommand_ = _lblCommand_1;
		object? object19 = resourceManager.GetObject("_lblCommand_1.Location");
		((Control)lblCommand_).set_Location((object19 != null) ? ((Point)object19) : point);
		((Control)_lblCommand_1).set_Name("_lblCommand_1");
		((Control)_lblCommand_1).set_RightToLeft((RightToLeft)Conversions.ToInteger(resourceManager.GetObject("_lblCommand_1.RightToLeft")));
		Label lblCommand_2 = _lblCommand_1;
		object? object20 = resourceManager.GetObject("_lblCommand_1.Size");
		((Control)lblCommand_2).set_Size((object20 != null) ? ((Size)object20) : size);
		((Control)_lblCommand_1).set_TabIndex(Conversions.ToInteger(resourceManager.GetObject("_lblCommand_1.TabIndex")));
		_lblCommand_1.set_Text(resourceManager.GetString("_lblCommand_1.Text"));
		_lblCommand_1.set_TextAlign((ContentAlignment)Conversions.ToInteger(resourceManager.GetObject("_lblCommand_1.TextAlign")));
		ToolTip1.SetToolTip((Control)(object)_lblCommand_1, resourceManager.GetString("_lblCommand_1.ToolTip"));
		((Control)_lblCommand_1).set_Visible(Conversions.ToBoolean(resourceManager.GetObject("_lblCommand_1.Visible")));
		((Control)lblMain).set_AccessibleDescription(resourceManager.GetString("lblMain.AccessibleDescription"));
		((Control)lblMain).set_AccessibleName(resourceManager.GetString("lblMain.AccessibleName"));
		((Control)lblMain).set_Anchor((AnchorStyles)Conversions.ToInteger(resourceManager.GetObject("lblMain.Anchor")));
		lblMain.set_AutoSize(Conversions.ToBoolean(resourceManager.GetObject("lblMain.AutoSize")));
		((Control)lblMain).set_BackColor(SystemColors.Control);
		((Control)lblMain).set_Cursor(Cursors.get_Default());
		((Control)lblMain).set_Dock((DockStyle)Conversions.ToInteger(resourceManager.GetObject("lblMain.Dock")));
		((Control)lblMain).set_Enabled(Conversions.ToBoolean(resourceManager.GetObject("lblMain.Enabled")));
		((Control)lblMain).set_Font((Font)resourceManager.GetObject("lblMain.Font"));
		((Control)lblMain).set_ForeColor(SystemColors.ControlText);
		lblMain.set_Image((Image)resourceManager.GetObject("lblMain.Image"));
		lblMain.set_ImageAlign((ContentAlignment)Conversions.ToInteger(resourceManager.GetObject("lblMain.ImageAlign")));
		lblMain.set_ImageIndex(Conversions.ToInteger(resourceManager.GetObject("lblMain.ImageIndex")));
		lblMain.set_ImeMode((ImeMode)Conversions.ToInteger(resourceManager.GetObject("lblMain.ImeMode")));
		Label obj15 = lblMain;
		object? object21 = resourceManager.GetObject("lblMain.Location");
		((Control)obj15).set_Location((object21 != null) ? ((Point)object21) : point);
		((Control)lblMain).set_Name("lblMain");
		((Control)lblMain).set_RightToLeft((RightToLeft)Conversions.ToInteger(resourceManager.GetObject("lblMain.RightToLeft")));
		Label obj16 = lblMain;
		object? object22 = resourceManager.GetObject("lblMain.Size");
		((Control)obj16).set_Size((object22 != null) ? ((Size)object22) : size);
		((Control)lblMain).set_TabIndex(Conversions.ToInteger(resourceManager.GetObject("lblMain.TabIndex")));
		lblMain.set_Text(resourceManager.GetString("lblMain.Text"));
		lblMain.set_TextAlign((ContentAlignment)Conversions.ToInteger(resourceManager.GetObject("lblMain.TextAlign")));
		ToolTip1.SetToolTip((Control)(object)lblMain, resourceManager.GetString("lblMain.ToolTip"));
		((Control)lblMain).set_Visible(Conversions.ToBoolean(resourceManager.GetObject("lblMain.Visible")));
		((Form)this).set_AcceptButton((IButtonControl)(object)cmdOK);
		((Control)this).set_AccessibleDescription(resourceManager.GetString("$this.AccessibleDescription"));
		((Control)this).set_AccessibleName(resourceManager.GetString("$this.AccessibleName"));
		object? object23 = resourceManager.GetObject("$this.AutoScaleBaseSize");
		((Form)this).set_AutoScaleBaseSize((object23 != null) ? ((Size)object23) : size);
		((Form)this).set_AutoScroll(Conversions.ToBoolean(resourceManager.GetObject("$this.AutoScroll")));
		object? object24 = resourceManager.GetObject("$this.AutoScrollMargin");
		((ScrollableControl)this).set_AutoScrollMargin((object24 != null) ? ((Size)object24) : size);
		object? object25 = resourceManager.GetObject("$this.AutoScrollMinSize");
		((ScrollableControl)this).set_AutoScrollMinSize((object25 != null) ? ((Size)object25) : size);
		((Form)this).set_BackColor(SystemColors.Control);
		((Control)this).set_BackgroundImage((Image)resourceManager.GetObject("$this.BackgroundImage"));
		((Form)this).set_CancelButton((IButtonControl)(object)cmdCancel);
		object? object26 = resourceManager.GetObject("$this.ClientSize");
		((Form)this).set_ClientSize((object26 != null) ? ((Size)object26) : size);
		((Form)this).set_ControlBox(false);
		((Control)this).get_Controls().Add((Control)(object)comboFlag);
		((Control)this).get_Controls().Add((Control)(object)cmdOK);
		((Control)this).get_Controls().Add((Control)(object)cmdCancel);
		((Control)this).get_Controls().Add((Control)(object)txtAlias);
		((Control)this).get_Controls().Add((Control)(object)txtPrompt);
		((Control)this).get_Controls().Add((Control)(object)txtCommand);
		((Control)this).get_Controls().Add((Control)(object)_lblFlag_0);
		((Control)this).get_Controls().Add((Control)(object)_lblKeystroke_1);
		((Control)this).get_Controls().Add((Control)(object)lblPrompt);
		((Control)this).get_Controls().Add((Control)(object)_lblCommand_1);
		((Control)this).get_Controls().Add((Control)(object)lblMain);
		((Control)this).set_Cursor(Cursors.get_Default());
		((Control)this).set_Enabled(Conversions.ToBoolean(resourceManager.GetObject("$this.Enabled")));
		((Control)this).set_Font((Font)resourceManager.GetObject("$this.Font"));
		((Form)this).set_FormBorderStyle((FormBorderStyle)3);
		((Form)this).set_HelpButton(true);
		((Form)this).set_Icon((Icon)resourceManager.GetObject("$this.Icon"));
		((Control)this).set_ImeMode((ImeMode)Conversions.ToInteger(resourceManager.GetObject("$this.ImeMode")));
		object? object27 = resourceManager.GetObject("$this.Location");
		((Form)this).set_Location((object27 != null) ? ((Point)object27) : point);
		((Form)this).set_MaximizeBox(false);
		object? object28 = resourceManager.GetObject("$this.MaximumSize");
		((Form)this).set_MaximumSize((object28 != null) ? ((Size)object28) : size);
		((Form)this).set_MinimizeBox(false);
		object? object29 = resourceManager.GetObject("$this.MinimumSize");
		((Form)this).set_MinimumSize((object29 != null) ? ((Size)object29) : size);
		((Control)this).set_Name("frmNewShell");
		((Control)this).set_RightToLeft((RightToLeft)Conversions.ToInteger(resourceManager.GetObject("$this.RightToLeft")));
		((Form)this).set_ShowInTaskbar(false);
		((Form)this).set_StartPosition((FormStartPosition)Conversions.ToInteger(resourceManager.GetObject("$this.StartPosition")));
		((Form)this).set_Text(resourceManager.GetString("$this.Text"));
		ToolTip1.SetToolTip((Control)(object)this, resourceManager.GetString("$this.ToolTip"));
		((Control)this).ResumeLayout(false);
	}

	private void cmdCancel_Click(object sender, EventArgs e)
	{
		((Control)DefInstance).Hide();
		if (Main.nEdit == 0)
		{
			txtAlias.set_Text("");
			txtCommand.set_Text("");
			txtPrompt.set_Text("");
		}
		else
		{
			Main.bEditCancel = -1;
			txtAlias.set_Text(Main.sEditAlias);
			txtCommand.set_Text(Main.sEditRep);
			txtPrompt.set_Text(Main.sEditPrompt);
			comboFlag.set_Text(Main.sEditFlag);
		}
	}

	private void cmdOK_Click(object sender, EventArgs e)
	{
		//IL_00bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0193: Unknown result type (might be due to invalid IL or missing references)
		//IL_0199: Invalid comparison between Unknown and I4
		//IL_01ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_031f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0325: Invalid comparison between Unknown and I4
		//IL_03e8: Unknown result type (might be due to invalid IL or missing references)
		int try0000_dispatch = -1;
		int num2 = default(int);
		int num = default(int);
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				ListViewItem val;
				bool flag;
				bool flag2;
				bool flag3;
				string text2;
				string text3;
				string text4;
				switch (try0000_dispatch)
				{
				default:
				{
					ProjectData.ClearProjectError();
					num2 = 2;
					if (Operators.CompareString(txtAlias.get_Text(), "", false) == 0 && !Main.NoCommandAddedOK())
					{
						goto end_IL_0000;
					}
					if (Operators.CompareString(txtCommand.get_Text(), "", false) == 0)
					{
						Interaction.MsgBox((object)(resManager.GetString("STR_OK1") + "\r\n\r\n" + resManager.GetString("STR_OK2") + txtAlias.get_Text() + resManager.GetString("STR_OK3")), (MsgBoxStyle)64, (object)resManager.GetString("STR_OK4"));
					}
					string NewString = txtAlias.get_Text();
					val = Main.FindDuplicate(ref NewString);
					if (val == null)
					{
						goto IL_03ee;
					}
					short num3 = 6;
					flag = Operators.CompareString(Strings.LCase(val.get_SubItems().get_Item(0).get_Text()), Strings.LCase(txtCommand.get_Text()), false) != 0;
					flag2 = Operators.CompareString(val.get_SubItems().get_Item(1).get_Text(), comboFlag.get_Text(), false) != 0;
					flag3 = Operators.CompareString(Strings.LCase(val.get_SubItems().get_Item(2).get_Text()), Strings.LCase(txtPrompt.get_Text()), false) != 0;
					if (!flag && !flag2 && !flag3)
					{
						num3 = 2;
					}
					else
					{
						if ((int)frmAlias.DefInstance.chkConfirm.get_CheckState() <= 0)
						{
							num3 = 6;
							goto IL_029d;
						}
						string @string = resManager.GetString("STR_DUP1");
						string text = resManager.GetString("STR_DUP2") + txtAlias.get_Text() + resManager.GetString("STR_DUP3");
						switch (checked((short)Interaction.MsgBox((object)text, (MsgBoxStyle)323, (object)@string)))
						{
						case 2:
							break;
						case 7:
						{
							TextBox val2 = txtAlias;
							((Control)val2).Focus();
							((TextBoxBase)val2).set_SelectionStart(0);
							((TextBoxBase)val2).set_SelectionLength(Strings.Len(txtAlias.get_Text()));
							val2 = null;
							goto end_IL_0000_2;
						}
						case 6:
							goto IL_029d;
						default:
							goto IL_03ee;
						}
					}
					((Control)txtAlias).Focus();
					txtAlias.set_Text("");
					txtCommand.set_Text("");
					txtPrompt.set_Text("");
					((Control)DefInstance).Hide();
					goto end_IL_0000_2;
				}
				case 1088:
					{
						num = -1;
						switch (num2)
						{
						case 2:
							break;
						default:
							goto IL_047a;
						}
						break;
					}
					IL_03ee:
					((Control)DefInstance).Hide();
					break;
					IL_029d:
					text2 = ((!flag) ? "" : ("'" + txtCommand.get_Text() + "'"));
					text3 = ((!flag2) ? "" : ("'" + comboFlag.get_Text() + "'"));
					text4 = ((!flag3) ? "" : ("'" + txtPrompt.get_Text() + "'"));
					if ((int)frmAlias.DefInstance.chkConfirm.get_CheckState() > 0)
					{
						Interaction.MsgBox((object)(resManager.GetString("STR_CHKPROP1") + val.get_SubItems().get_Item(0).get_Text() + resManager.GetString("STR_CHKPROP2") + "\r\n\r\n" + resManager.GetString("STR_CHKPROP3") + text2 + "\r\n" + resManager.GetString("STR_CHKPROP4") + text3 + "\r\n" + resManager.GetString("STR_CHKPROP5") + text4), (MsgBoxStyle)0, (object)null);
					}
					goto IL_03ee;
				}
				if (Information.Err().get_Number() == 32755)
				{
					((TextBoxBase)txtAlias).set_SelectionStart(0);
					((TextBoxBase)txtAlias).set_SelectionLength(Strings.Len(txtAlias.get_Text()));
					((Control)txtAlias).Focus();
				}
				end_IL_0000_2:;
			}
			catch (object obj) when (obj is Exception && num2 != 0 && num == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0000_dispatch = 1088;
				continue;
			}
			break;
			IL_047a:
			throw ProjectData.CreateProjectError(-2146828237);
			continue;
			end_IL_0000:
			break;
		}
		if (num != 0)
		{
			ProjectData.ClearProjectError();
		}
	}

	private void frmNewShell_Load(object sender, EventArgs e)
	{
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Expected O, but got Unknown
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Expected O, but got Unknown
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_0051: Expected O, but got Unknown
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		//IL_006c: Expected O, but got Unknown
		((Control)txtPrompt).set_Font(new Font("FixedSys", 8f, (FontStyle)0));
		((Control)txtAlias).set_Font(new Font("FixedSys", 8f, (FontStyle)0));
		((Control)txtCommand).set_Font(new Font("FixedSys", 8f, (FontStyle)0));
		((Control)comboFlag).set_Font(new Font("FixedSys", 8f, (FontStyle)0));
		Main.bEditCancel = 0;
	}

	private void txtCommand_Enter(object sender, EventArgs e)
	{
		((TextBoxBase)txtCommand).set_SelectionStart(0);
		((TextBoxBase)txtCommand).set_SelectionLength(Strings.Len(txtCommand.get_Text()));
	}

	private void txtPrompt_Enter(object sender, EventArgs e)
	{
		((TextBoxBase)txtPrompt).set_SelectionStart(0);
		((TextBoxBase)txtPrompt).set_SelectionLength(Strings.Len(txtPrompt.get_Text()));
	}
}
