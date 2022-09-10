using System;
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

internal class frmAbout : Form
{
	private ResourceManager resManager;

	private IContainer components;

	public ToolTip ToolTip1;

	[AccessedThroughProperty("Picture1")]
	private PictureBox _Picture1;

	[AccessedThroughProperty("cmdOk")]
	private Button _cmdOk;

	[AccessedThroughProperty("lblVersion")]
	private Label _lblVersion;

	[AccessedThroughProperty("Line1")]
	private Label _Line1;

	[AccessedThroughProperty("lblMessage")]
	private Label _lblMessage;

	[AccessedThroughProperty("lblCopyright")]
	private Label _lblCopyright;

	[AccessedThroughProperty("lblMain")]
	private Label _lblMain;

	private static frmAbout m_vb6FormDefInstance;

	private static bool m_InitializingDefInstance;

	public virtual PictureBox Picture1
	{
		get
		{
			return _Picture1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_Picture1 = value;
		}
	}

	public virtual Button cmdOk
	{
		get
		{
			return _cmdOk;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			if (_cmdOk != null)
			{
				((Control)_cmdOk).remove_Click((EventHandler)cmdOK_Click);
			}
			_cmdOk = value;
			if (_cmdOk != null)
			{
				((Control)_cmdOk).add_Click((EventHandler)cmdOK_Click);
			}
		}
	}

	public virtual Label lblVersion
	{
		get
		{
			return _lblVersion;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_lblVersion = value;
		}
	}

	public virtual Label Line1
	{
		get
		{
			return _Line1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_Line1 = value;
		}
	}

	public virtual Label lblMessage
	{
		get
		{
			return _lblMessage;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_lblMessage = value;
		}
	}

	public virtual Label lblCopyright
	{
		get
		{
			return _lblCopyright;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_lblCopyright = value;
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

	public static frmAbout DefInstance
	{
		get
		{
			if (m_vb6FormDefInstance == null || ((Control)m_vb6FormDefInstance).get_IsDisposed())
			{
				m_InitializingDefInstance = true;
				m_vb6FormDefInstance = new frmAbout();
				m_InitializingDefInstance = false;
			}
			return m_vb6FormDefInstance;
		}
		set
		{
			m_vb6FormDefInstance = value;
		}
	}

	public frmAbout()
	{
		((Form)this).add_Load((EventHandler)frmAbout_Load);
		resManager = new ResourceManager(typeof(frmAbout));
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
		//IL_00e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f1: Expected O, but got Unknown
		//IL_0148: Unknown result type (might be due to invalid IL or missing references)
		//IL_0152: Expected O, but got Unknown
		//IL_0173: Unknown result type (might be due to invalid IL or missing references)
		//IL_017d: Expected O, but got Unknown
		//IL_0308: Unknown result type (might be due to invalid IL or missing references)
		//IL_0312: Expected O, but got Unknown
		//IL_0384: Unknown result type (might be due to invalid IL or missing references)
		//IL_038e: Expected O, but got Unknown
		//IL_03af: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b9: Expected O, but got Unknown
		//IL_05df: Unknown result type (might be due to invalid IL or missing references)
		//IL_05e9: Expected O, but got Unknown
		//IL_060a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0614: Expected O, but got Unknown
		//IL_081a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0824: Expected O, but got Unknown
		//IL_0835: Unknown result type (might be due to invalid IL or missing references)
		//IL_083f: Expected O, but got Unknown
		//IL_0a55: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a5f: Expected O, but got Unknown
		//IL_0a80: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a8a: Expected O, but got Unknown
		//IL_0ca0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0caa: Expected O, but got Unknown
		//IL_0ccb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cd5: Expected O, but got Unknown
		//IL_0eeb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ef5: Expected O, but got Unknown
		//IL_0f16: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f20: Expected O, but got Unknown
		//IL_112e: Unknown result type (might be due to invalid IL or missing references)
		//IL_1138: Expected O, but got Unknown
		//IL_1205: Unknown result type (might be due to invalid IL or missing references)
		//IL_120f: Expected O, but got Unknown
		//IL_1222: Unknown result type (might be due to invalid IL or missing references)
		//IL_122c: Expected O, but got Unknown
		components = new Container();
		ResourceManager resourceManager = new ResourceManager(typeof(frmAbout));
		ToolTip1 = new ToolTip(components);
		Picture1 = new PictureBox();
		cmdOk = new Button();
		lblVersion = new Label();
		Line1 = new Label();
		lblMessage = new Label();
		lblCopyright = new Label();
		lblMain = new Label();
		((Control)this).SuspendLayout();
		((Control)Picture1).set_AccessibleDescription(resourceManager.GetString("Picture1.AccessibleDescription"));
		((Control)Picture1).set_AccessibleName(resourceManager.GetString("Picture1.AccessibleName"));
		((Control)Picture1).set_Anchor((AnchorStyles)Conversions.ToInteger(resourceManager.GetObject("Picture1.Anchor")));
		((Control)Picture1).set_BackColor(SystemColors.Menu);
		((Control)Picture1).set_BackgroundImage((Image)resourceManager.GetObject("Picture1.BackgroundImage"));
		((Control)Picture1).set_Cursor(Cursors.get_Default());
		((Control)Picture1).set_Dock((DockStyle)Conversions.ToInteger(resourceManager.GetObject("Picture1.Dock")));
		((Control)Picture1).set_Enabled(Conversions.ToBoolean(resourceManager.GetObject("Picture1.Enabled")));
		Picture1.set_Font((Font)resourceManager.GetObject("Picture1.Font"));
		Picture1.set_ForeColor(SystemColors.WindowText);
		Picture1.set_Image((Image)resourceManager.GetObject("Picture1.Image"));
		Picture1.set_ImeMode((ImeMode)Conversions.ToInteger(resourceManager.GetObject("Picture1.ImeMode")));
		PictureBox picture = Picture1;
		object? @object = resourceManager.GetObject("Picture1.Location");
		Point point = default(Point);
		((Control)picture).set_Location((@object != null) ? ((Point)@object) : point);
		((Control)Picture1).set_Name("Picture1");
		Picture1.set_RightToLeft((RightToLeft)Conversions.ToInteger(resourceManager.GetObject("Picture1.RightToLeft")));
		PictureBox picture2 = Picture1;
		object? object2 = resourceManager.GetObject("Picture1.Size");
		Size size = default(Size);
		((Control)picture2).set_Size((object2 != null) ? ((Size)object2) : size);
		Picture1.set_SizeMode((PictureBoxSizeMode)Conversions.ToInteger(resourceManager.GetObject("Picture1.SizeMode")));
		Picture1.set_TabIndex(Conversions.ToInteger(resourceManager.GetObject("Picture1.TabIndex")));
		Picture1.set_TabStop(false);
		Picture1.set_Text(resourceManager.GetString("Picture1.Text"));
		ToolTip1.SetToolTip((Control)(object)Picture1, resourceManager.GetString("Picture1.ToolTip"));
		((Control)Picture1).set_Visible(Conversions.ToBoolean(resourceManager.GetObject("Picture1.Visible")));
		((Control)cmdOk).set_AccessibleDescription(resourceManager.GetString("cmdOk.AccessibleDescription"));
		((Control)cmdOk).set_AccessibleName(resourceManager.GetString("cmdOk.AccessibleName"));
		((Control)cmdOk).set_Anchor((AnchorStyles)Conversions.ToInteger(resourceManager.GetObject("cmdOk.Anchor")));
		((ButtonBase)cmdOk).set_BackColor(SystemColors.Control);
		((Control)cmdOk).set_BackgroundImage((Image)resourceManager.GetObject("cmdOk.BackgroundImage"));
		((Control)cmdOk).set_Cursor(Cursors.get_Default());
		((Control)cmdOk).set_Dock((DockStyle)Conversions.ToInteger(resourceManager.GetObject("cmdOk.Dock")));
		((Control)cmdOk).set_Enabled(Conversions.ToBoolean(resourceManager.GetObject("cmdOk.Enabled")));
		((ButtonBase)cmdOk).set_FlatStyle((FlatStyle)Conversions.ToInteger(resourceManager.GetObject("cmdOk.FlatStyle")));
		((Control)cmdOk).set_Font((Font)resourceManager.GetObject("cmdOk.Font"));
		((Control)cmdOk).set_ForeColor(SystemColors.ControlText);
		((ButtonBase)cmdOk).set_Image((Image)resourceManager.GetObject("cmdOk.Image"));
		((ButtonBase)cmdOk).set_ImageAlign((ContentAlignment)Conversions.ToInteger(resourceManager.GetObject("cmdOk.ImageAlign")));
		((ButtonBase)cmdOk).set_ImageIndex(Conversions.ToInteger(resourceManager.GetObject("cmdOk.ImageIndex")));
		((ButtonBase)cmdOk).set_ImeMode((ImeMode)Conversions.ToInteger(resourceManager.GetObject("cmdOk.ImeMode")));
		Button obj = cmdOk;
		object? object3 = resourceManager.GetObject("cmdOk.Location");
		((Control)obj).set_Location((object3 != null) ? ((Point)object3) : point);
		((Control)cmdOk).set_Name("cmdOk");
		((Control)cmdOk).set_RightToLeft((RightToLeft)Conversions.ToInteger(resourceManager.GetObject("cmdOk.RightToLeft")));
		Button obj2 = cmdOk;
		object? object4 = resourceManager.GetObject("cmdOk.Size");
		((Control)obj2).set_Size((object4 != null) ? ((Size)object4) : size);
		((Control)cmdOk).set_TabIndex(Conversions.ToInteger(resourceManager.GetObject("cmdOk.TabIndex")));
		((Control)cmdOk).set_Tag((object)"apply current changes");
		((ButtonBase)cmdOk).set_Text(resourceManager.GetString("cmdOk.Text"));
		((ButtonBase)cmdOk).set_TextAlign((ContentAlignment)Conversions.ToInteger(resourceManager.GetObject("cmdOk.TextAlign")));
		ToolTip1.SetToolTip((Control)(object)cmdOk, resourceManager.GetString("cmdOk.ToolTip"));
		((Control)cmdOk).set_Visible(Conversions.ToBoolean(resourceManager.GetObject("cmdOk.Visible")));
		((Control)lblVersion).set_AccessibleDescription(resourceManager.GetString("lblVersion.AccessibleDescription"));
		((Control)lblVersion).set_AccessibleName(resourceManager.GetString("lblVersion.AccessibleName"));
		((Control)lblVersion).set_Anchor((AnchorStyles)Conversions.ToInteger(resourceManager.GetObject("lblVersion.Anchor")));
		lblVersion.set_AutoSize(Conversions.ToBoolean(resourceManager.GetObject("lblVersion.AutoSize")));
		((Control)lblVersion).set_BackColor(SystemColors.Control);
		((Control)lblVersion).set_Cursor(Cursors.get_Default());
		((Control)lblVersion).set_Dock((DockStyle)Conversions.ToInteger(resourceManager.GetObject("lblVersion.Dock")));
		((Control)lblVersion).set_Enabled(Conversions.ToBoolean(resourceManager.GetObject("lblVersion.Enabled")));
		((Control)lblVersion).set_Font((Font)resourceManager.GetObject("lblVersion.Font"));
		((Control)lblVersion).set_ForeColor(SystemColors.ControlText);
		lblVersion.set_Image((Image)resourceManager.GetObject("lblVersion.Image"));
		lblVersion.set_ImageAlign((ContentAlignment)Conversions.ToInteger(resourceManager.GetObject("lblVersion.ImageAlign")));
		lblVersion.set_ImageIndex(Conversions.ToInteger(resourceManager.GetObject("lblVersion.ImageIndex")));
		lblVersion.set_ImeMode((ImeMode)Conversions.ToInteger(resourceManager.GetObject("lblVersion.ImeMode")));
		Label obj3 = lblVersion;
		object? object5 = resourceManager.GetObject("lblVersion.Location");
		((Control)obj3).set_Location((object5 != null) ? ((Point)object5) : point);
		((Control)lblVersion).set_Name("lblVersion");
		((Control)lblVersion).set_RightToLeft((RightToLeft)Conversions.ToInteger(resourceManager.GetObject("lblVersion.RightToLeft")));
		Label obj4 = lblVersion;
		object? object6 = resourceManager.GetObject("lblVersion.Size");
		((Control)obj4).set_Size((object6 != null) ? ((Size)object6) : size);
		((Control)lblVersion).set_TabIndex(Conversions.ToInteger(resourceManager.GetObject("lblVersion.TabIndex")));
		lblVersion.set_Text(resourceManager.GetString("lblVersion.Text"));
		lblVersion.set_TextAlign((ContentAlignment)Conversions.ToInteger(resourceManager.GetObject("lblVersion.TextAlign")));
		ToolTip1.SetToolTip((Control)(object)lblVersion, resourceManager.GetString("lblVersion.ToolTip"));
		((Control)lblVersion).set_Visible(Conversions.ToBoolean(resourceManager.GetObject("lblVersion.Visible")));
		((Control)Line1).set_AccessibleDescription(resourceManager.GetString("Line1.AccessibleDescription"));
		((Control)Line1).set_AccessibleName(resourceManager.GetString("Line1.AccessibleName"));
		((Control)Line1).set_Anchor((AnchorStyles)Conversions.ToInteger(resourceManager.GetObject("Line1.Anchor")));
		Line1.set_AutoSize(Conversions.ToBoolean(resourceManager.GetObject("Line1.AutoSize")));
		((Control)Line1).set_BackColor(SystemColors.WindowText);
		((Control)Line1).set_Dock((DockStyle)Conversions.ToInteger(resourceManager.GetObject("Line1.Dock")));
		((Control)Line1).set_Enabled(Conversions.ToBoolean(resourceManager.GetObject("Line1.Enabled")));
		((Control)Line1).set_Font((Font)resourceManager.GetObject("Line1.Font"));
		Line1.set_Image((Image)resourceManager.GetObject("Line1.Image"));
		Line1.set_ImageAlign((ContentAlignment)Conversions.ToInteger(resourceManager.GetObject("Line1.ImageAlign")));
		Line1.set_ImageIndex(Conversions.ToInteger(resourceManager.GetObject("Line1.ImageIndex")));
		Line1.set_ImeMode((ImeMode)Conversions.ToInteger(resourceManager.GetObject("Line1.ImeMode")));
		Label line = Line1;
		object? object7 = resourceManager.GetObject("Line1.Location");
		((Control)line).set_Location((object7 != null) ? ((Point)object7) : point);
		((Control)Line1).set_Name("Line1");
		((Control)Line1).set_RightToLeft((RightToLeft)Conversions.ToInteger(resourceManager.GetObject("Line1.RightToLeft")));
		Label line2 = Line1;
		object? object8 = resourceManager.GetObject("Line1.Size");
		((Control)line2).set_Size((object8 != null) ? ((Size)object8) : size);
		((Control)Line1).set_TabIndex(Conversions.ToInteger(resourceManager.GetObject("Line1.TabIndex")));
		Line1.set_Text(resourceManager.GetString("Line1.Text"));
		Line1.set_TextAlign((ContentAlignment)Conversions.ToInteger(resourceManager.GetObject("Line1.TextAlign")));
		ToolTip1.SetToolTip((Control)(object)Line1, resourceManager.GetString("Line1.ToolTip"));
		((Control)Line1).set_Visible(Conversions.ToBoolean(resourceManager.GetObject("Line1.Visible")));
		((Control)lblMessage).set_AccessibleDescription(resourceManager.GetString("lblMessage.AccessibleDescription"));
		((Control)lblMessage).set_AccessibleName(resourceManager.GetString("lblMessage.AccessibleName"));
		((Control)lblMessage).set_Anchor((AnchorStyles)Conversions.ToInteger(resourceManager.GetObject("lblMessage.Anchor")));
		lblMessage.set_AutoSize(Conversions.ToBoolean(resourceManager.GetObject("lblMessage.AutoSize")));
		((Control)lblMessage).set_BackColor(SystemColors.Control);
		((Control)lblMessage).set_Cursor(Cursors.get_Default());
		((Control)lblMessage).set_Dock((DockStyle)Conversions.ToInteger(resourceManager.GetObject("lblMessage.Dock")));
		((Control)lblMessage).set_Enabled(Conversions.ToBoolean(resourceManager.GetObject("lblMessage.Enabled")));
		((Control)lblMessage).set_Font((Font)resourceManager.GetObject("lblMessage.Font"));
		((Control)lblMessage).set_ForeColor(SystemColors.ControlText);
		lblMessage.set_Image((Image)resourceManager.GetObject("lblMessage.Image"));
		lblMessage.set_ImageAlign((ContentAlignment)Conversions.ToInteger(resourceManager.GetObject("lblMessage.ImageAlign")));
		lblMessage.set_ImageIndex(Conversions.ToInteger(resourceManager.GetObject("lblMessage.ImageIndex")));
		lblMessage.set_ImeMode((ImeMode)Conversions.ToInteger(resourceManager.GetObject("lblMessage.ImeMode")));
		Label obj5 = lblMessage;
		object? object9 = resourceManager.GetObject("lblMessage.Location");
		((Control)obj5).set_Location((object9 != null) ? ((Point)object9) : point);
		((Control)lblMessage).set_Name("lblMessage");
		((Control)lblMessage).set_RightToLeft((RightToLeft)Conversions.ToInteger(resourceManager.GetObject("lblMessage.RightToLeft")));
		Label obj6 = lblMessage;
		object? object10 = resourceManager.GetObject("lblMessage.Size");
		((Control)obj6).set_Size((object10 != null) ? ((Size)object10) : size);
		((Control)lblMessage).set_TabIndex(Conversions.ToInteger(resourceManager.GetObject("lblMessage.TabIndex")));
		lblMessage.set_Text(resourceManager.GetString("lblMessage.Text"));
		lblMessage.set_TextAlign((ContentAlignment)Conversions.ToInteger(resourceManager.GetObject("lblMessage.TextAlign")));
		ToolTip1.SetToolTip((Control)(object)lblMessage, resourceManager.GetString("lblMessage.ToolTip"));
		((Control)lblMessage).set_Visible(Conversions.ToBoolean(resourceManager.GetObject("lblMessage.Visible")));
		((Control)lblCopyright).set_AccessibleDescription(resourceManager.GetString("lblCopyright.AccessibleDescription"));
		((Control)lblCopyright).set_AccessibleName(resourceManager.GetString("lblCopyright.AccessibleName"));
		((Control)lblCopyright).set_Anchor((AnchorStyles)Conversions.ToInteger(resourceManager.GetObject("lblCopyright.Anchor")));
		lblCopyright.set_AutoSize(Conversions.ToBoolean(resourceManager.GetObject("lblCopyright.AutoSize")));
		((Control)lblCopyright).set_BackColor(SystemColors.Control);
		((Control)lblCopyright).set_Cursor(Cursors.get_Default());
		((Control)lblCopyright).set_Dock((DockStyle)Conversions.ToInteger(resourceManager.GetObject("lblCopyright.Dock")));
		((Control)lblCopyright).set_Enabled(Conversions.ToBoolean(resourceManager.GetObject("lblCopyright.Enabled")));
		((Control)lblCopyright).set_Font((Font)resourceManager.GetObject("lblCopyright.Font"));
		((Control)lblCopyright).set_ForeColor(SystemColors.ControlText);
		lblCopyright.set_Image((Image)resourceManager.GetObject("lblCopyright.Image"));
		lblCopyright.set_ImageAlign((ContentAlignment)Conversions.ToInteger(resourceManager.GetObject("lblCopyright.ImageAlign")));
		lblCopyright.set_ImageIndex(Conversions.ToInteger(resourceManager.GetObject("lblCopyright.ImageIndex")));
		lblCopyright.set_ImeMode((ImeMode)Conversions.ToInteger(resourceManager.GetObject("lblCopyright.ImeMode")));
		Label obj7 = lblCopyright;
		object? object11 = resourceManager.GetObject("lblCopyright.Location");
		((Control)obj7).set_Location((object11 != null) ? ((Point)object11) : point);
		((Control)lblCopyright).set_Name("lblCopyright");
		((Control)lblCopyright).set_RightToLeft((RightToLeft)Conversions.ToInteger(resourceManager.GetObject("lblCopyright.RightToLeft")));
		Label obj8 = lblCopyright;
		object? object12 = resourceManager.GetObject("lblCopyright.Size");
		((Control)obj8).set_Size((object12 != null) ? ((Size)object12) : size);
		((Control)lblCopyright).set_TabIndex(Conversions.ToInteger(resourceManager.GetObject("lblCopyright.TabIndex")));
		lblCopyright.set_Text(resourceManager.GetString("lblCopyright.Text"));
		lblCopyright.set_TextAlign((ContentAlignment)Conversions.ToInteger(resourceManager.GetObject("lblCopyright.TextAlign")));
		ToolTip1.SetToolTip((Control)(object)lblCopyright, resourceManager.GetString("lblCopyright.ToolTip"));
		((Control)lblCopyright).set_Visible(Conversions.ToBoolean(resourceManager.GetObject("lblCopyright.Visible")));
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
		((Form)this).set_AcceptButton((IButtonControl)(object)cmdOk);
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
		object? object18 = resourceManager.GetObject("$this.ClientSize");
		((Form)this).set_ClientSize((object18 != null) ? ((Size)object18) : size);
		((Form)this).set_ControlBox(false);
		((Control)this).get_Controls().Add((Control)(object)Picture1);
		((Control)this).get_Controls().Add((Control)(object)cmdOk);
		((Control)this).get_Controls().Add((Control)(object)lblVersion);
		((Control)this).get_Controls().Add((Control)(object)Line1);
		((Control)this).get_Controls().Add((Control)(object)lblMessage);
		((Control)this).get_Controls().Add((Control)(object)lblCopyright);
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
		((Control)this).set_Name("frmAbout");
		((Control)this).set_RightToLeft((RightToLeft)Conversions.ToInteger(resourceManager.GetObject("$this.RightToLeft")));
		((Form)this).set_ShowInTaskbar(false);
		((Form)this).set_StartPosition((FormStartPosition)Conversions.ToInteger(resourceManager.GetObject("$this.StartPosition")));
		((Form)this).set_Text(resourceManager.GetString("$this.Text"));
		ToolTip1.SetToolTip((Control)(object)this, resourceManager.GetString("$this.ToolTip"));
		((Control)this).ResumeLayout(false);
	}

	private void cmdOK_Click(object sender, EventArgs e)
	{
		((Form)this).Close();
	}

	private void frmAbout_Load(object sender, EventArgs e)
	{
		//IL_00b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c1: Expected O, but got Unknown
		lblVersion.set_Text(resManager.GetString("STR_VERSION") + Conversions.ToString(FileVersionInfo.GetVersionInfo(Assembly.GetExecutingAssembly().Location).FileMajorPart) + resManager.GetString("STR_PERIOD") + Conversions.ToString(FileVersionInfo.GetVersionInfo(Assembly.GetExecutingAssembly().Location).FileMinorPart) + resManager.GetString("STR_PERIOD") + Conversions.ToString(FileVersionInfo.GetVersionInfo(Assembly.GetExecutingAssembly().Location).FileBuildPart));
		((Control)lblMain).set_Font(new Font(((Control)lblMain).get_Font(), (FontStyle)1));
		lblMain.set_Text(resManager.GetString("STR_MAINTEXT"));
		lblCopyright.set_Text(resManager.GetString("STR_COPYRIGHT") + Conversions.ToString(Strings.Chr(169)) + resManager.GetString("STR_YEARS"));
	}
}
