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

internal class frmNewAlias : Form
{
	private IContainer components;

	public ToolTip ToolTip1;

	[AccessedThroughProperty("txtAlias")]
	private TextBox _txtAlias;

	[AccessedThroughProperty("cmbRep")]
	private ComboBox _cmbRep;

	[AccessedThroughProperty("cmdOK")]
	private Button _cmdOK;

	[AccessedThroughProperty("cmdCancel")]
	private Button _cmdCancel;

	[AccessedThroughProperty("_lblKeystroke_0")]
	private Label __lblKeystroke_0;

	[AccessedThroughProperty("_lblCommand_0")]
	private Label __lblCommand_0;

	[AccessedThroughProperty("lblMain")]
	private Label _lblMain;

	public ArrayList lblCommand;

	public ArrayList lblKeystroke;

	private ResourceManager resManager;

	private static frmNewAlias m_vb6FormDefInstance;

	private static bool m_InitializingDefInstance;

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

	public virtual ComboBox cmbRep
	{
		get
		{
			return _cmbRep;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			//IL_0016: Unknown result type (might be due to invalid IL or missing references)
			//IL_0020: Expected O, but got Unknown
			//IL_0055: Unknown result type (might be due to invalid IL or missing references)
			//IL_005f: Expected O, but got Unknown
			if (_cmbRep != null)
			{
				((Control)_cmbRep).remove_KeyUp(new KeyEventHandler(cmbRep_KeyUp));
				_cmbRep.remove_SelectedIndexChanged((EventHandler)cmbRep_SelectedIndexChanged);
			}
			_cmbRep = value;
			if (_cmbRep != null)
			{
				((Control)_cmbRep).add_KeyUp(new KeyEventHandler(cmbRep_KeyUp));
				_cmbRep.add_SelectedIndexChanged((EventHandler)cmbRep_SelectedIndexChanged);
			}
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

	public virtual Label _lblKeystroke_0
	{
		get
		{
			return __lblKeystroke_0;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			__lblKeystroke_0 = value;
		}
	}

	public virtual Label _lblCommand_0
	{
		get
		{
			return __lblCommand_0;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			__lblCommand_0 = value;
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

	public static frmNewAlias DefInstance
	{
		get
		{
			if (m_vb6FormDefInstance == null || ((Control)m_vb6FormDefInstance).get_IsDisposed())
			{
				m_InitializingDefInstance = true;
				m_vb6FormDefInstance = new frmNewAlias();
				m_InitializingDefInstance = false;
			}
			return m_vb6FormDefInstance;
		}
		set
		{
			m_vb6FormDefInstance = value;
		}
	}

	public frmNewAlias()
	{
		((Form)this).add_Load((EventHandler)frmNewAlias_Load);
		lblCommand = new ArrayList();
		lblKeystroke = new ArrayList();
		resManager = new ResourceManager(typeof(frmNewAlias));
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
		//IL_010e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0118: Expected O, but got Unknown
		//IL_016f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0179: Expected O, but got Unknown
		//IL_038f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0399: Expected O, but got Unknown
		//IL_03fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0406: Expected O, but got Unknown
		//IL_05f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_05fc: Expected O, but got Unknown
		//IL_066e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0678: Expected O, but got Unknown
		//IL_0699: Unknown result type (might be due to invalid IL or missing references)
		//IL_06a3: Expected O, but got Unknown
		//IL_0858: Unknown result type (might be due to invalid IL or missing references)
		//IL_0862: Expected O, but got Unknown
		//IL_08e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_08ea: Expected O, but got Unknown
		//IL_090b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0915: Expected O, but got Unknown
		//IL_0b2b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b35: Expected O, but got Unknown
		//IL_0b56: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b60: Expected O, but got Unknown
		//IL_0d76: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d80: Expected O, but got Unknown
		//IL_0da1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0dab: Expected O, but got Unknown
		//IL_0fc1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fcb: Expected O, but got Unknown
		//IL_0fec: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ff6: Expected O, but got Unknown
		//IL_1204: Unknown result type (might be due to invalid IL or missing references)
		//IL_120e: Expected O, but got Unknown
		//IL_12e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_12f1: Expected O, but got Unknown
		//IL_1304: Unknown result type (might be due to invalid IL or missing references)
		//IL_130e: Expected O, but got Unknown
		components = new Container();
		ResourceManager resourceManager = new ResourceManager(typeof(frmNewAlias));
		ToolTip1 = new ToolTip(components);
		txtAlias = new TextBox();
		cmbRep = new ComboBox();
		cmdOK = new Button();
		cmdCancel = new Button();
		_lblKeystroke_0 = new Label();
		_lblCommand_0 = new Label();
		lblMain = new Label();
		((Control)this).SuspendLayout();
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
		TextBox obj = txtAlias;
		object? @object = resourceManager.GetObject("txtAlias.Location");
		Point point = default(Point);
		((Control)obj).set_Location((@object != null) ? ((Point)@object) : point);
		((TextBoxBase)txtAlias).set_MaxLength(Conversions.ToInteger(resourceManager.GetObject("txtAlias.MaxLength")));
		txtAlias.set_Multiline(Conversions.ToBoolean(resourceManager.GetObject("txtAlias.Multiline")));
		((Control)txtAlias).set_Name("txtAlias");
		txtAlias.set_PasswordChar(Conversions.ToChar(resourceManager.GetObject("txtAlias.PasswordChar")));
		((Control)txtAlias).set_RightToLeft((RightToLeft)Conversions.ToInteger(resourceManager.GetObject("txtAlias.RightToLeft")));
		txtAlias.set_ScrollBars((ScrollBars)Conversions.ToInteger(resourceManager.GetObject("txtAlias.ScrollBars")));
		TextBox obj2 = txtAlias;
		object? object2 = resourceManager.GetObject("txtAlias.Size");
		Size size = default(Size);
		((Control)obj2).set_Size((object2 != null) ? ((Size)object2) : size);
		((Control)txtAlias).set_TabIndex(Conversions.ToInteger(resourceManager.GetObject("txtAlias.TabIndex")));
		txtAlias.set_Text(resourceManager.GetString("txtAlias.Text"));
		txtAlias.set_TextAlign((HorizontalAlignment)Conversions.ToInteger(resourceManager.GetObject("txtAlias.TextAlign")));
		ToolTip1.SetToolTip((Control)(object)txtAlias, resourceManager.GetString("txtAlias.ToolTip"));
		((Control)txtAlias).set_Visible(Conversions.ToBoolean(resourceManager.GetObject("txtAlias.Visible")));
		((TextBoxBase)txtAlias).set_WordWrap(Conversions.ToBoolean(resourceManager.GetObject("txtAlias.WordWrap")));
		((Control)cmbRep).set_AccessibleDescription(resourceManager.GetString("cmbRep.AccessibleDescription"));
		((Control)cmbRep).set_AccessibleName(resourceManager.GetString("cmbRep.AccessibleName"));
		((Control)cmbRep).set_Anchor((AnchorStyles)Conversions.ToInteger(resourceManager.GetObject("cmbRep.Anchor")));
		cmbRep.set_BackColor(SystemColors.Window);
		cmbRep.set_BackgroundImage((Image)resourceManager.GetObject("cmbRep.BackgroundImage"));
		((Control)cmbRep).set_Cursor(Cursors.get_Default());
		((Control)cmbRep).set_Dock((DockStyle)Conversions.ToInteger(resourceManager.GetObject("cmbRep.Dock")));
		cmbRep.set_DropDownStyle((ComboBoxStyle)0);
		((Control)cmbRep).set_Enabled(Conversions.ToBoolean(resourceManager.GetObject("cmbRep.Enabled")));
		((Control)cmbRep).set_Font((Font)resourceManager.GetObject("cmbRep.Font"));
		cmbRep.set_ForeColor(SystemColors.WindowText);
		((Control)cmbRep).set_ImeMode((ImeMode)Conversions.ToInteger(resourceManager.GetObject("cmbRep.ImeMode")));
		cmbRep.set_IntegralHeight(Conversions.ToBoolean(resourceManager.GetObject("cmbRep.IntegralHeight")));
		cmbRep.set_ItemHeight(Conversions.ToInteger(resourceManager.GetObject("cmbRep.ItemHeight")));
		ComboBox obj3 = cmbRep;
		object? object3 = resourceManager.GetObject("cmbRep.Location");
		((Control)obj3).set_Location((object3 != null) ? ((Point)object3) : point);
		cmbRep.set_MaxDropDownItems(Conversions.ToInteger(resourceManager.GetObject("cmbRep.MaxDropDownItems")));
		cmbRep.set_MaxLength(Conversions.ToInteger(resourceManager.GetObject("cmbRep.MaxLength")));
		((Control)cmbRep).set_Name("cmbRep");
		((Control)cmbRep).set_RightToLeft((RightToLeft)Conversions.ToInteger(resourceManager.GetObject("cmbRep.RightToLeft")));
		ComboBox obj4 = cmbRep;
		object? object4 = resourceManager.GetObject("cmbRep.Size");
		((Control)obj4).set_Size((object4 != null) ? ((Size)object4) : size);
		cmbRep.set_Sorted(true);
		((Control)cmbRep).set_TabIndex(Conversions.ToInteger(resourceManager.GetObject("cmbRep.TabIndex")));
		cmbRep.set_Text(resourceManager.GetString("cmbRep.Text"));
		ToolTip1.SetToolTip((Control)(object)cmbRep, resourceManager.GetString("cmbRep.ToolTip"));
		((Control)cmbRep).set_Visible(Conversions.ToBoolean(resourceManager.GetObject("cmbRep.Visible")));
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
		Button obj5 = cmdOK;
		object? object5 = resourceManager.GetObject("cmdOK.Location");
		((Control)obj5).set_Location((object5 != null) ? ((Point)object5) : point);
		((Control)cmdOK).set_Name("cmdOK");
		((Control)cmdOK).set_RightToLeft((RightToLeft)Conversions.ToInteger(resourceManager.GetObject("cmdOK.RightToLeft")));
		Button obj6 = cmdOK;
		object? object6 = resourceManager.GetObject("cmdOK.Size");
		((Control)obj6).set_Size((object6 != null) ? ((Size)object6) : size);
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
		Button obj7 = cmdCancel;
		object? object7 = resourceManager.GetObject("cmdCancel.Location");
		((Control)obj7).set_Location((object7 != null) ? ((Point)object7) : point);
		((Control)cmdCancel).set_Name("cmdCancel");
		((Control)cmdCancel).set_RightToLeft((RightToLeft)Conversions.ToInteger(resourceManager.GetObject("cmdCancel.RightToLeft")));
		Button obj8 = cmdCancel;
		object? object8 = resourceManager.GetObject("cmdCancel.Size");
		((Control)obj8).set_Size((object8 != null) ? ((Size)object8) : size);
		((Control)cmdCancel).set_TabIndex(Conversions.ToInteger(resourceManager.GetObject("cmdCancel.TabIndex")));
		((ButtonBase)cmdCancel).set_Text(resourceManager.GetString("cmdCancel.Text"));
		((ButtonBase)cmdCancel).set_TextAlign((ContentAlignment)Conversions.ToInteger(resourceManager.GetObject("cmdCancel.TextAlign")));
		ToolTip1.SetToolTip((Control)(object)cmdCancel, resourceManager.GetString("cmdCancel.ToolTip"));
		((Control)cmdCancel).set_Visible(Conversions.ToBoolean(resourceManager.GetObject("cmdCancel.Visible")));
		((Control)_lblKeystroke_0).set_AccessibleDescription(resourceManager.GetString("_lblKeystroke_0.AccessibleDescription"));
		((Control)_lblKeystroke_0).set_AccessibleName(resourceManager.GetString("_lblKeystroke_0.AccessibleName"));
		((Control)_lblKeystroke_0).set_Anchor((AnchorStyles)Conversions.ToInteger(resourceManager.GetObject("_lblKeystroke_0.Anchor")));
		_lblKeystroke_0.set_AutoSize(Conversions.ToBoolean(resourceManager.GetObject("_lblKeystroke_0.AutoSize")));
		((Control)_lblKeystroke_0).set_BackColor(SystemColors.Control);
		((Control)_lblKeystroke_0).set_Cursor(Cursors.get_Default());
		((Control)_lblKeystroke_0).set_Dock((DockStyle)Conversions.ToInteger(resourceManager.GetObject("_lblKeystroke_0.Dock")));
		((Control)_lblKeystroke_0).set_Enabled(Conversions.ToBoolean(resourceManager.GetObject("_lblKeystroke_0.Enabled")));
		((Control)_lblKeystroke_0).set_Font((Font)resourceManager.GetObject("_lblKeystroke_0.Font"));
		((Control)_lblKeystroke_0).set_ForeColor(SystemColors.ControlText);
		_lblKeystroke_0.set_Image((Image)resourceManager.GetObject("_lblKeystroke_0.Image"));
		_lblKeystroke_0.set_ImageAlign((ContentAlignment)Conversions.ToInteger(resourceManager.GetObject("_lblKeystroke_0.ImageAlign")));
		_lblKeystroke_0.set_ImageIndex(Conversions.ToInteger(resourceManager.GetObject("_lblKeystroke_0.ImageIndex")));
		_lblKeystroke_0.set_ImeMode((ImeMode)Conversions.ToInteger(resourceManager.GetObject("_lblKeystroke_0.ImeMode")));
		Label lblKeystroke_ = _lblKeystroke_0;
		object? object9 = resourceManager.GetObject("_lblKeystroke_0.Location");
		((Control)lblKeystroke_).set_Location((object9 != null) ? ((Point)object9) : point);
		((Control)_lblKeystroke_0).set_Name("_lblKeystroke_0");
		((Control)_lblKeystroke_0).set_RightToLeft((RightToLeft)Conversions.ToInteger(resourceManager.GetObject("_lblKeystroke_0.RightToLeft")));
		Label lblKeystroke_2 = _lblKeystroke_0;
		object? object10 = resourceManager.GetObject("_lblKeystroke_0.Size");
		((Control)lblKeystroke_2).set_Size((object10 != null) ? ((Size)object10) : size);
		((Control)_lblKeystroke_0).set_TabIndex(Conversions.ToInteger(resourceManager.GetObject("_lblKeystroke_0.TabIndex")));
		_lblKeystroke_0.set_Text(resourceManager.GetString("_lblKeystroke_0.Text"));
		_lblKeystroke_0.set_TextAlign((ContentAlignment)Conversions.ToInteger(resourceManager.GetObject("_lblKeystroke_0.TextAlign")));
		ToolTip1.SetToolTip((Control)(object)_lblKeystroke_0, resourceManager.GetString("_lblKeystroke_0.ToolTip"));
		((Control)_lblKeystroke_0).set_Visible(Conversions.ToBoolean(resourceManager.GetObject("_lblKeystroke_0.Visible")));
		((Control)_lblCommand_0).set_AccessibleDescription(resourceManager.GetString("_lblCommand_0.AccessibleDescription"));
		((Control)_lblCommand_0).set_AccessibleName(resourceManager.GetString("_lblCommand_0.AccessibleName"));
		((Control)_lblCommand_0).set_Anchor((AnchorStyles)Conversions.ToInteger(resourceManager.GetObject("_lblCommand_0.Anchor")));
		_lblCommand_0.set_AutoSize(Conversions.ToBoolean(resourceManager.GetObject("_lblCommand_0.AutoSize")));
		((Control)_lblCommand_0).set_BackColor(SystemColors.Control);
		((Control)_lblCommand_0).set_Cursor(Cursors.get_Default());
		((Control)_lblCommand_0).set_Dock((DockStyle)Conversions.ToInteger(resourceManager.GetObject("_lblCommand_0.Dock")));
		((Control)_lblCommand_0).set_Enabled(Conversions.ToBoolean(resourceManager.GetObject("_lblCommand_0.Enabled")));
		((Control)_lblCommand_0).set_Font((Font)resourceManager.GetObject("_lblCommand_0.Font"));
		((Control)_lblCommand_0).set_ForeColor(SystemColors.ControlText);
		_lblCommand_0.set_Image((Image)resourceManager.GetObject("_lblCommand_0.Image"));
		_lblCommand_0.set_ImageAlign((ContentAlignment)Conversions.ToInteger(resourceManager.GetObject("_lblCommand_0.ImageAlign")));
		_lblCommand_0.set_ImageIndex(Conversions.ToInteger(resourceManager.GetObject("_lblCommand_0.ImageIndex")));
		_lblCommand_0.set_ImeMode((ImeMode)Conversions.ToInteger(resourceManager.GetObject("_lblCommand_0.ImeMode")));
		Label lblCommand_ = _lblCommand_0;
		object? object11 = resourceManager.GetObject("_lblCommand_0.Location");
		((Control)lblCommand_).set_Location((object11 != null) ? ((Point)object11) : point);
		((Control)_lblCommand_0).set_Name("_lblCommand_0");
		((Control)_lblCommand_0).set_RightToLeft((RightToLeft)Conversions.ToInteger(resourceManager.GetObject("_lblCommand_0.RightToLeft")));
		Label lblCommand_2 = _lblCommand_0;
		object? object12 = resourceManager.GetObject("_lblCommand_0.Size");
		((Control)lblCommand_2).set_Size((object12 != null) ? ((Size)object12) : size);
		((Control)_lblCommand_0).set_TabIndex(Conversions.ToInteger(resourceManager.GetObject("_lblCommand_0.TabIndex")));
		_lblCommand_0.set_Text(resourceManager.GetString("_lblCommand_0.Text"));
		_lblCommand_0.set_TextAlign((ContentAlignment)Conversions.ToInteger(resourceManager.GetObject("_lblCommand_0.TextAlign")));
		ToolTip1.SetToolTip((Control)(object)_lblCommand_0, resourceManager.GetString("_lblCommand_0.ToolTip"));
		((Control)_lblCommand_0).set_Visible(Conversions.ToBoolean(resourceManager.GetObject("_lblCommand_0.Visible")));
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
		Label obj9 = lblMain;
		object? object13 = resourceManager.GetObject("lblMain.Location");
		((Control)obj9).set_Location((object13 != null) ? ((Point)object13) : point);
		((Control)lblMain).set_Name("lblMain");
		((Control)lblMain).set_RightToLeft((RightToLeft)Conversions.ToInteger(resourceManager.GetObject("lblMain.RightToLeft")));
		Label obj10 = lblMain;
		object? object14 = resourceManager.GetObject("lblMain.Size");
		((Control)obj10).set_Size((object14 != null) ? ((Size)object14) : size);
		((Control)lblMain).set_TabIndex(Conversions.ToInteger(resourceManager.GetObject("lblMain.TabIndex")));
		lblMain.set_Text(resourceManager.GetString("lblMain.Text"));
		lblMain.set_TextAlign((ContentAlignment)Conversions.ToInteger(resourceManager.GetObject("lblMain.TextAlign")));
		ToolTip1.SetToolTip((Control)(object)lblMain, resourceManager.GetString("lblMain.ToolTip"));
		((Control)lblMain).set_Visible(Conversions.ToBoolean(resourceManager.GetObject("lblMain.Visible")));
		((Form)this).set_AcceptButton((IButtonControl)(object)cmdOK);
		((Control)this).set_AccessibleDescription(resourceManager.GetString("$this.AccessibleDescription"));
		((Control)this).set_AccessibleName(resourceManager.GetString("$this.AccessibleName"));
		object? object15 = resourceManager.GetObject("$this.AutoScaleBaseSize");
		((Form)this).set_AutoScaleBaseSize((object15 != null) ? ((Size)object15) : size);
		((Form)this).set_AutoScroll(Conversions.ToBoolean(resourceManager.GetObject("$this.AutoScroll")));
		object? object16 = resourceManager.GetObject("$this.AutoScrollMargin");
		((ScrollableControl)this).set_AutoScrollMargin((object16 != null) ? ((Size)object16) : size);
		object? object17 = resourceManager.GetObject("$this.AutoScrollMinSize");
		((ScrollableControl)this).set_AutoScrollMinSize((object17 != null) ? ((Size)object17) : size);
		((Form)this).set_BackColor(SystemColors.Control);
		((Control)this).set_BackgroundImage((Image)resourceManager.GetObject("$this.BackgroundImage"));
		((Form)this).set_CancelButton((IButtonControl)(object)cmdCancel);
		object? object18 = resourceManager.GetObject("$this.ClientSize");
		((Form)this).set_ClientSize((object18 != null) ? ((Size)object18) : size);
		((Form)this).set_ControlBox(false);
		((Control)this).get_Controls().Add((Control)(object)txtAlias);
		((Control)this).get_Controls().Add((Control)(object)cmbRep);
		((Control)this).get_Controls().Add((Control)(object)cmdOK);
		((Control)this).get_Controls().Add((Control)(object)cmdCancel);
		((Control)this).get_Controls().Add((Control)(object)_lblKeystroke_0);
		((Control)this).get_Controls().Add((Control)(object)_lblCommand_0);
		((Control)this).get_Controls().Add((Control)(object)lblMain);
		((Control)this).set_Cursor(Cursors.get_Default());
		((Control)this).set_Enabled(Conversions.ToBoolean(resourceManager.GetObject("$this.Enabled")));
		((Control)this).set_Font((Font)resourceManager.GetObject("$this.Font"));
		((Form)this).set_FormBorderStyle((FormBorderStyle)3);
		((Form)this).set_Icon((Icon)resourceManager.GetObject("$this.Icon"));
		((Control)this).set_ImeMode((ImeMode)Conversions.ToInteger(resourceManager.GetObject("$this.ImeMode")));
		object? object19 = resourceManager.GetObject("$this.Location");
		((Form)this).set_Location((object19 != null) ? ((Point)object19) : point);
		((Form)this).set_MaximizeBox(false);
		object? object20 = resourceManager.GetObject("$this.MaximumSize");
		((Form)this).set_MaximumSize((object20 != null) ? ((Size)object20) : size);
		((Form)this).set_MinimizeBox(false);
		object? object21 = resourceManager.GetObject("$this.MinimumSize");
		((Form)this).set_MinimumSize((object21 != null) ? ((Size)object21) : size);
		((Control)this).set_Name("frmNewAlias");
		((Control)this).set_RightToLeft((RightToLeft)Conversions.ToInteger(resourceManager.GetObject("$this.RightToLeft")));
		((Form)this).set_ShowInTaskbar(false);
		((Form)this).set_StartPosition((FormStartPosition)Conversions.ToInteger(resourceManager.GetObject("$this.StartPosition")));
		((Form)this).set_Text(resourceManager.GetString("$this.Text"));
		ToolTip1.SetToolTip((Control)(object)this, resourceManager.GetString("$this.ToolTip"));
		((Control)this).ResumeLayout(false);
	}

	private void cmbRep_SelectedIndexChanged(object sender, EventArgs e)
	{
	}

	private void cmbRep_KeyUp(object sender, KeyEventArgs e)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		short num;
		checked
		{
			num = (short)e.get_KeyCode();
			_ = (short)unchecked(e.get_KeyData() / 65536);
		}
		if (num == 27 || num == 3 || num == 12)
		{
			cmdCancel_Click(cmdCancel, new EventArgs());
		}
	}

	private void CheckDuplicateCmd()
	{
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		//IL_006d: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Invalid comparison between Unknown and I4
		string text = Strings.UCase(cmbRep.get_Text());
		string NewString = cmbRep.get_Text();
		ComboBox listCmds = cmbRep;
		bool num = Main.FindDuplicateCmd(ref NewString, ref listCmds);
		cmbRep = listCmds;
		if (num)
		{
			return;
		}
		MsgBoxResult val = Interaction.MsgBox((object)("'" + text + resManager.GetString("STR_NEWCOMM")), (MsgBoxStyle)4, (object)resManager.GetString("STR_NEWCOMMTITLE"));
		if ((int)val == 6)
		{
			NewString = "";
			string cmdFile = Main.GetCmdFile(ref NewString);
			if (Operators.CompareString(cmdFile, "", false) != 0)
			{
				FileSystem.FileOpen(1, cmdFile, (OpenMode)8, (OpenAccess)(-1), (OpenShare)1, -1);
				FileSystem.WriteLine(1, new object[1] { text });
				FileSystem.FileClose(new int[1] { 1 });
			}
			cmbRep.get_Items().Add((object)text);
		}
	}

	private void cmdCancel_Click(object sender, EventArgs e)
	{
		((Control)DefInstance).Hide();
		if (Main.nEdit == 0)
		{
			txtAlias.set_Text("");
			cmbRep.set_Text("");
		}
		else
		{
			Main.bEditCancel = -1;
			txtAlias.set_Text(Main.sEditAlias);
			cmbRep.set_Text(Main.sEditRep);
		}
	}

	private void cmdOK_Click(object sender, EventArgs e)
	{
		//IL_00e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00eb: Invalid comparison between Unknown and I4
		//IL_016f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0211: Unknown result type (might be due to invalid IL or missing references)
		//IL_0217: Invalid comparison between Unknown and I4
		//IL_027f: Unknown result type (might be due to invalid IL or missing references)
		if (((Operators.CompareString(txtAlias.get_Text(), "", false) == 0) | (Operators.CompareString(cmbRep.get_Text(), "", false) == 0)) && !Main.NoCommandAddedOK())
		{
			return;
		}
		if ((Operators.CompareString(txtAlias.get_Text(), Main.sEditAlias, false) == 0) & (Operators.CompareString(cmbRep.get_Text(), Main.sEditRep, false) == 0))
		{
			Main.bEditCancel = -1;
			((Control)DefInstance).Hide();
			return;
		}
		string NewString = txtAlias.get_Text();
		ListViewItem val = Main.FindDuplicate(ref NewString);
		CheckDuplicateCmd();
		if (val != null)
		{
			short num = 6;
			if (Operators.CompareString(Strings.LCase(val.get_SubItems().get_Item(0).get_Text()), Strings.LCase(cmbRep.get_Text()), false) == 0)
			{
				num = 2;
			}
			else
			{
				if ((int)frmAlias.DefInstance.chkConfirm.get_CheckState() <= 0)
				{
					num = 6;
					goto IL_0207;
				}
				switch (checked((short)Interaction.MsgBox((object)(resManager.GetString("STR_ALREADYUSED1") + txtAlias.get_Text() + resManager.GetString("STR_ALREADYUSED2") + val.get_SubItems().get_Item(1).get_Text() + resManager.GetString("STR_ALREADYUSED3")), (MsgBoxStyle)323, (object)resManager.GetString("STR_ALREADYUSED4"))))
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
					return;
				}
				case 6:
					goto IL_0207;
				default:
					goto IL_0285;
				}
			}
			((Control)txtAlias).Focus();
			txtAlias.set_Text("");
			cmbRep.set_Text("");
			((Control)DefInstance).Hide();
			return;
		}
		goto IL_0285;
		IL_0285:
		((Control)DefInstance).Hide();
		return;
		IL_0207:
		if ((int)frmAlias.DefInstance.chkConfirm.get_CheckState() > 0)
		{
			Interaction.MsgBox((object)(resManager.GetString("STR_ALREADYUSED5") + txtAlias.get_Text() + resManager.GetString("STR_ALREADYUSED6") + cmbRep.get_Text() + resManager.GetString("STR_ALREADYUSED7")), (MsgBoxStyle)0, (object)null);
		}
		goto IL_0285;
	}

	private void frmNewAlias_Load(object sender, EventArgs e)
	{
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Expected O, but got Unknown
		((Control)txtAlias).set_Font(new Font("FixedSys", 8f, (FontStyle)0));
		Main.bEditCancel = 0;
		((Control)txtAlias).set_Enabled(true);
		lblCommand.Add(_lblCommand_0);
		lblKeystroke.Add(_lblKeystroke_0);
		if (cmbRep.get_Items().get_Count() == 0)
		{
			Main.FillInAllCommands();
		}
	}
}
