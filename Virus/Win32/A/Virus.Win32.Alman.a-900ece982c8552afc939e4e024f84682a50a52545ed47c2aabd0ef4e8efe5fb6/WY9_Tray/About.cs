using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.ApplicationServices;
using Microsoft.VisualBasic.CompilerServices;
using WY9_Tray.My;

namespace WY9_Tray;

[DesignerGenerated]
public sealed class About : Form
{
	private static List<WeakReference> __ENCList = new List<WeakReference>();

	[AccessedThroughProperty("TableLayoutPanel")]
	private TableLayoutPanel _TableLayoutPanel;

	[AccessedThroughProperty("LogoPictureBox")]
	private PictureBox _LogoPictureBox;

	[AccessedThroughProperty("LabelProductName")]
	private Label _LabelProductName;

	[AccessedThroughProperty("LabelVersion")]
	private Label _LabelVersion;

	[AccessedThroughProperty("LabelCompanyName")]
	private Label _LabelCompanyName;

	[AccessedThroughProperty("TextBoxDescription")]
	private TextBox _TextBoxDescription;

	[AccessedThroughProperty("OKButton")]
	private Button _OKButton;

	[AccessedThroughProperty("LabelCopyright")]
	private Label _LabelCopyright;

	private IContainer components;

	internal virtual TableLayoutPanel TableLayoutPanel
	{
		[DebuggerNonUserCode]
		get
		{
			return _TableLayoutPanel;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_TableLayoutPanel = value;
		}
	}

	internal virtual PictureBox LogoPictureBox
	{
		[DebuggerNonUserCode]
		get
		{
			return _LogoPictureBox;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_LogoPictureBox = value;
		}
	}

	internal virtual Label LabelProductName
	{
		[DebuggerNonUserCode]
		get
		{
			return _LabelProductName;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_LabelProductName = value;
		}
	}

	internal virtual Label LabelVersion
	{
		[DebuggerNonUserCode]
		get
		{
			return _LabelVersion;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_LabelVersion = value;
		}
	}

	internal virtual Label LabelCompanyName
	{
		[DebuggerNonUserCode]
		get
		{
			return _LabelCompanyName;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_LabelCompanyName = value;
		}
	}

	internal virtual TextBox TextBoxDescription
	{
		[DebuggerNonUserCode]
		get
		{
			return _TextBoxDescription;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_TextBoxDescription = value;
		}
	}

	internal virtual Button OKButton
	{
		[DebuggerNonUserCode]
		get
		{
			return _OKButton;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = OKButton_Click;
			if (_OKButton != null)
			{
				((Control)_OKButton).remove_Click(eventHandler);
			}
			_OKButton = value;
			if (_OKButton != null)
			{
				((Control)_OKButton).add_Click(eventHandler);
			}
		}
	}

	internal virtual Label LabelCopyright
	{
		[DebuggerNonUserCode]
		get
		{
			return _LabelCopyright;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_LabelCopyright = value;
		}
	}

	[DebuggerNonUserCode]
	public About()
	{
		((Form)this).add_Load((EventHandler)AboutBox1_Load);
		lock (__ENCList)
		{
			__ENCList.Add(new WeakReference(this));
		}
		InitializeComponent();
	}

	[DebuggerNonUserCode]
	protected override void Dispose(bool disposing)
	{
		try
		{
			if ((disposing && components != null) ? true : false)
			{
				components.Dispose();
			}
		}
		finally
		{
			((Form)this).Dispose(disposing);
		}
	}

	[DebuggerStepThrough]
	private void InitializeComponent()
	{
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Expected O, but got Unknown
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Expected O, but got Unknown
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Expected O, but got Unknown
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Expected O, but got Unknown
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Expected O, but got Unknown
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Expected O, but got Unknown
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Expected O, but got Unknown
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Expected O, but got Unknown
		//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ab: Expected O, but got Unknown
		//IL_00bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c7: Expected O, but got Unknown
		//IL_01bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c9: Expected O, but got Unknown
		//IL_01db: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e5: Expected O, but got Unknown
		//IL_01f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0201: Expected O, but got Unknown
		//IL_0213: Unknown result type (might be due to invalid IL or missing references)
		//IL_021d: Expected O, but got Unknown
		//IL_022f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0239: Expected O, but got Unknown
		//IL_024b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0255: Expected O, but got Unknown
		//IL_029c: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a6: Expected O, but got Unknown
		//IL_0351: Unknown result type (might be due to invalid IL or missing references)
		//IL_03f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_049d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0543: Unknown result type (might be due to invalid IL or missing references)
		//IL_05e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0746: Unknown result type (might be due to invalid IL or missing references)
		//IL_0750: Expected O, but got Unknown
		//IL_0777: Unknown result type (might be due to invalid IL or missing references)
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(About));
		TableLayoutPanel = new TableLayoutPanel();
		LogoPictureBox = new PictureBox();
		LabelProductName = new Label();
		LabelVersion = new Label();
		LabelCopyright = new Label();
		LabelCompanyName = new Label();
		TextBoxDescription = new TextBox();
		OKButton = new Button();
		((Control)TableLayoutPanel).SuspendLayout();
		((ISupportInitialize)LogoPictureBox).BeginInit();
		((Control)this).SuspendLayout();
		TableLayoutPanel.set_ColumnCount(2);
		TableLayoutPanel.get_ColumnStyles().Add(new ColumnStyle((SizeType)2, 33f));
		TableLayoutPanel.get_ColumnStyles().Add(new ColumnStyle((SizeType)2, 67f));
		TableLayoutPanel.get_Controls().Add((Control)(object)LogoPictureBox, 0, 0);
		TableLayoutPanel.get_Controls().Add((Control)(object)LabelProductName, 1, 0);
		TableLayoutPanel.get_Controls().Add((Control)(object)LabelVersion, 1, 1);
		TableLayoutPanel.get_Controls().Add((Control)(object)LabelCopyright, 1, 2);
		TableLayoutPanel.get_Controls().Add((Control)(object)LabelCompanyName, 1, 3);
		TableLayoutPanel.get_Controls().Add((Control)(object)TextBoxDescription, 1, 4);
		TableLayoutPanel.get_Controls().Add((Control)(object)OKButton, 1, 5);
		((Control)TableLayoutPanel).set_Dock((DockStyle)5);
		TableLayoutPanel tableLayoutPanel = TableLayoutPanel;
		Point location = new Point(9, 8);
		((Control)tableLayoutPanel).set_Location(location);
		((Control)TableLayoutPanel).set_Name("TableLayoutPanel");
		TableLayoutPanel.set_RowCount(6);
		TableLayoutPanel.get_RowStyles().Add(new RowStyle((SizeType)2, 10f));
		TableLayoutPanel.get_RowStyles().Add(new RowStyle((SizeType)2, 10f));
		TableLayoutPanel.get_RowStyles().Add(new RowStyle((SizeType)2, 10f));
		TableLayoutPanel.get_RowStyles().Add(new RowStyle((SizeType)2, 10f));
		TableLayoutPanel.get_RowStyles().Add(new RowStyle((SizeType)2, 50f));
		TableLayoutPanel.get_RowStyles().Add(new RowStyle((SizeType)2, 10f));
		TableLayoutPanel tableLayoutPanel2 = TableLayoutPanel;
		Size size = new Size(396, 239);
		((Control)tableLayoutPanel2).set_Size(size);
		((Control)TableLayoutPanel).set_TabIndex(0);
		((Control)LogoPictureBox).set_Dock((DockStyle)5);
		LogoPictureBox.set_Image((Image)componentResourceManager.GetObject("LogoPictureBox.Image"));
		PictureBox logoPictureBox = LogoPictureBox;
		location = new Point(3, 3);
		((Control)logoPictureBox).set_Location(location);
		((Control)LogoPictureBox).set_Name("LogoPictureBox");
		TableLayoutPanel.SetRowSpan((Control)(object)LogoPictureBox, 6);
		PictureBox logoPictureBox2 = LogoPictureBox;
		size = new Size(124, 233);
		((Control)logoPictureBox2).set_Size(size);
		LogoPictureBox.set_SizeMode((PictureBoxSizeMode)1);
		LogoPictureBox.set_TabIndex(0);
		LogoPictureBox.set_TabStop(false);
		((Control)LabelProductName).set_Dock((DockStyle)5);
		Label labelProductName = LabelProductName;
		location = new Point(136, 0);
		((Control)labelProductName).set_Location(location);
		Label labelProductName2 = LabelProductName;
		Padding val = default(Padding);
		((Padding)(ref val))._002Ector(6, 0, 3, 0);
		((Control)labelProductName2).set_Margin(val);
		Label labelProductName3 = LabelProductName;
		size = new Size(0, 16);
		((Control)labelProductName3).set_MaximumSize(size);
		((Control)LabelProductName).set_Name("LabelProductName");
		Label labelProductName4 = LabelProductName;
		size = new Size(257, 16);
		((Control)labelProductName4).set_Size(size);
		((Control)LabelProductName).set_TabIndex(0);
		LabelProductName.set_Text("产品名称");
		LabelProductName.set_TextAlign((ContentAlignment)16);
		((Control)LabelVersion).set_Dock((DockStyle)5);
		Label labelVersion = LabelVersion;
		location = new Point(136, 23);
		((Control)labelVersion).set_Location(location);
		Label labelVersion2 = LabelVersion;
		((Padding)(ref val))._002Ector(6, 0, 3, 0);
		((Control)labelVersion2).set_Margin(val);
		Label labelVersion3 = LabelVersion;
		size = new Size(0, 16);
		((Control)labelVersion3).set_MaximumSize(size);
		((Control)LabelVersion).set_Name("LabelVersion");
		Label labelVersion4 = LabelVersion;
		size = new Size(257, 16);
		((Control)labelVersion4).set_Size(size);
		((Control)LabelVersion).set_TabIndex(0);
		LabelVersion.set_Text("版本");
		LabelVersion.set_TextAlign((ContentAlignment)16);
		((Control)LabelCopyright).set_Dock((DockStyle)5);
		Label labelCopyright = LabelCopyright;
		location = new Point(136, 46);
		((Control)labelCopyright).set_Location(location);
		Label labelCopyright2 = LabelCopyright;
		((Padding)(ref val))._002Ector(6, 0, 3, 0);
		((Control)labelCopyright2).set_Margin(val);
		Label labelCopyright3 = LabelCopyright;
		size = new Size(0, 16);
		((Control)labelCopyright3).set_MaximumSize(size);
		((Control)LabelCopyright).set_Name("LabelCopyright");
		Label labelCopyright4 = LabelCopyright;
		size = new Size(257, 16);
		((Control)labelCopyright4).set_Size(size);
		((Control)LabelCopyright).set_TabIndex(0);
		LabelCopyright.set_Text("版权");
		LabelCopyright.set_TextAlign((ContentAlignment)16);
		((Control)LabelCompanyName).set_Dock((DockStyle)5);
		Label labelCompanyName = LabelCompanyName;
		location = new Point(136, 69);
		((Control)labelCompanyName).set_Location(location);
		Label labelCompanyName2 = LabelCompanyName;
		((Padding)(ref val))._002Ector(6, 0, 3, 0);
		((Control)labelCompanyName2).set_Margin(val);
		Label labelCompanyName3 = LabelCompanyName;
		size = new Size(0, 16);
		((Control)labelCompanyName3).set_MaximumSize(size);
		((Control)LabelCompanyName).set_Name("LabelCompanyName");
		Label labelCompanyName4 = LabelCompanyName;
		size = new Size(257, 16);
		((Control)labelCompanyName4).set_Size(size);
		((Control)LabelCompanyName).set_TabIndex(0);
		LabelCompanyName.set_Text("公司名称");
		LabelCompanyName.set_TextAlign((ContentAlignment)16);
		((Control)TextBoxDescription).set_Dock((DockStyle)5);
		TextBox textBoxDescription = TextBoxDescription;
		location = new Point(136, 95);
		((Control)textBoxDescription).set_Location(location);
		TextBox textBoxDescription2 = TextBoxDescription;
		((Padding)(ref val))._002Ector(6, 3, 3, 3);
		((Control)textBoxDescription2).set_Margin(val);
		TextBoxDescription.set_Multiline(true);
		((Control)TextBoxDescription).set_Name("TextBoxDescription");
		((TextBoxBase)TextBoxDescription).set_ReadOnly(true);
		TextBoxDescription.set_ScrollBars((ScrollBars)3);
		TextBox textBoxDescription3 = TextBoxDescription;
		size = new Size(257, 113);
		((Control)textBoxDescription3).set_Size(size);
		((Control)TextBoxDescription).set_TabIndex(1);
		((Control)TextBoxDescription).set_TabStop(false);
		TextBoxDescription.set_Text("说明 :\r\n\r\n(在运行时，将用应用程序的程序集信息替换这些标签的文本。\r\n在");
		((Control)OKButton).set_Anchor((AnchorStyles)10);
		OKButton.set_DialogResult((DialogResult)2);
		Button oKButton = OKButton;
		location = new Point(318, 215);
		((Control)oKButton).set_Location(location);
		((Control)OKButton).set_Name("OKButton");
		Button oKButton2 = OKButton;
		size = new Size(75, 21);
		((Control)oKButton2).set_Size(size);
		((Control)OKButton).set_TabIndex(0);
		((ButtonBase)OKButton).set_Text("确定(&O)");
		SizeF autoScaleDimensions = new SizeF(6f, 12f);
		((ContainerControl)this).set_AutoScaleDimensions(autoScaleDimensions);
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_CancelButton((IButtonControl)(object)OKButton);
		size = new Size(414, 255);
		((Form)this).set_ClientSize(size);
		((Control)this).get_Controls().Add((Control)(object)TableLayoutPanel);
		((Form)this).set_FormBorderStyle((FormBorderStyle)3);
		((Form)this).set_Icon((Icon)componentResourceManager.GetObject("$this.Icon"));
		((Form)this).set_MaximizeBox(false);
		((Form)this).set_MinimizeBox(false);
		((Control)this).set_Name("About");
		((Padding)(ref val))._002Ector(9, 8, 9, 8);
		((Control)this).set_Padding(val);
		((Form)this).set_ShowInTaskbar(false);
		((Form)this).set_StartPosition((FormStartPosition)1);
		((Form)this).set_Text("About");
		((Control)TableLayoutPanel).ResumeLayout(false);
		((Control)TableLayoutPanel).PerformLayout();
		((ISupportInitialize)LogoPictureBox).EndInit();
		((Control)this).ResumeLayout(false);
	}

	private void AboutBox1_Load(object sender, EventArgs e)
	{
		string title;
		if (Operators.CompareString(((ApplicationBase)MyProject.Application).get_Info().get_Title(), "", false) != 0)
		{
			title = ((ApplicationBase)MyProject.Application).get_Info().get_Title();
		}
		else
		{
			title = Path.GetFileNameWithoutExtension(((ApplicationBase)MyProject.Application).get_Info().get_AssemblyName());
		}
		title = ((Form)MyProject.Forms.MainForm).get_Text();
		((Form)this).set_Text($"关于 {title}" + " Tray");
		LabelProductName.set_Text(((ApplicationBase)MyProject.Application).get_Info().get_ProductName());
		LabelVersion.set_Text($"版本 {((ApplicationBase)MyProject.Application).get_Info().get_Version().ToString()}");
		LabelCopyright.set_Text(((ApplicationBase)MyProject.Application).get_Info().get_Copyright());
		LabelCompanyName.set_Text(((ApplicationBase)MyProject.Application).get_Info().get_CompanyName());
		TextBoxDescription.set_Text(((ApplicationBase)MyProject.Application).get_Info().get_Description());
	}

	private void OKButton_Click(object sender, EventArgs e)
	{
		((Form)this).Close();
	}
}
