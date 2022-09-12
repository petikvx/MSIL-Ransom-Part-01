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
using WindowsApplication5.My;

namespace WindowsApplication5;

[DesignerGenerated]
public sealed class AboutBox1 : Form
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
	public AboutBox1()
	{
		((Form)this).add_Load((EventHandler)AboutBox1_Load);
		__ENCAddToList(this);
		InitializeComponent();
	}

	[DebuggerNonUserCode]
	private static void __ENCAddToList(object value)
	{
		checked
		{
			lock (__ENCList)
			{
				if (__ENCList.Count == __ENCList.Capacity)
				{
					int num = 0;
					int num2 = __ENCList.Count - 1;
					int num3 = 0;
					while (true)
					{
						int num4 = num3;
						int num5 = num2;
						if (num4 > num5)
						{
							break;
						}
						WeakReference weakReference = __ENCList[num3];
						if (weakReference.IsAlive)
						{
							if (num3 != num)
							{
								__ENCList[num] = __ENCList[num3];
							}
							num++;
						}
						num3++;
					}
					__ENCList.RemoveRange(num, __ENCList.Count - num);
					__ENCList.Capacity = __ENCList.Count;
				}
				__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
			}
		}
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
		//IL_01c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ca: Expected O, but got Unknown
		//IL_01dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e6: Expected O, but got Unknown
		//IL_01f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0202: Expected O, but got Unknown
		//IL_0214: Unknown result type (might be due to invalid IL or missing references)
		//IL_021e: Expected O, but got Unknown
		//IL_0230: Unknown result type (might be due to invalid IL or missing references)
		//IL_023a: Expected O, but got Unknown
		//IL_024c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0256: Expected O, but got Unknown
		//IL_029e: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a8: Expected O, but got Unknown
		//IL_0354: Unknown result type (might be due to invalid IL or missing references)
		//IL_03fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_04a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_054f: Unknown result type (might be due to invalid IL or missing references)
		//IL_05f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0776: Unknown result type (might be due to invalid IL or missing references)
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(AboutBox1));
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
		Point location = new Point(9, 9);
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
		Size size = new Size(396, 258);
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
		size = new Size(124, 252);
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
		size = new Size(0, 17);
		((Control)labelProductName3).set_MaximumSize(size);
		((Control)LabelProductName).set_Name("LabelProductName");
		Label labelProductName4 = LabelProductName;
		size = new Size(257, 17);
		((Control)labelProductName4).set_Size(size);
		((Control)LabelProductName).set_TabIndex(0);
		LabelProductName.set_Text("Product Name");
		LabelProductName.set_TextAlign((ContentAlignment)16);
		((Control)LabelVersion).set_Dock((DockStyle)5);
		Label labelVersion = LabelVersion;
		location = new Point(136, 25);
		((Control)labelVersion).set_Location(location);
		Label labelVersion2 = LabelVersion;
		((Padding)(ref val))._002Ector(6, 0, 3, 0);
		((Control)labelVersion2).set_Margin(val);
		Label labelVersion3 = LabelVersion;
		size = new Size(0, 17);
		((Control)labelVersion3).set_MaximumSize(size);
		((Control)LabelVersion).set_Name("LabelVersion");
		Label labelVersion4 = LabelVersion;
		size = new Size(257, 17);
		((Control)labelVersion4).set_Size(size);
		((Control)LabelVersion).set_TabIndex(0);
		LabelVersion.set_Text("Version");
		LabelVersion.set_TextAlign((ContentAlignment)16);
		((Control)LabelCopyright).set_Dock((DockStyle)5);
		Label labelCopyright = LabelCopyright;
		location = new Point(136, 50);
		((Control)labelCopyright).set_Location(location);
		Label labelCopyright2 = LabelCopyright;
		((Padding)(ref val))._002Ector(6, 0, 3, 0);
		((Control)labelCopyright2).set_Margin(val);
		Label labelCopyright3 = LabelCopyright;
		size = new Size(0, 17);
		((Control)labelCopyright3).set_MaximumSize(size);
		((Control)LabelCopyright).set_Name("LabelCopyright");
		Label labelCopyright4 = LabelCopyright;
		size = new Size(257, 17);
		((Control)labelCopyright4).set_Size(size);
		((Control)LabelCopyright).set_TabIndex(0);
		LabelCopyright.set_Text("Copyright");
		LabelCopyright.set_TextAlign((ContentAlignment)16);
		((Control)LabelCompanyName).set_Dock((DockStyle)5);
		Label labelCompanyName = LabelCompanyName;
		location = new Point(136, 75);
		((Control)labelCompanyName).set_Location(location);
		Label labelCompanyName2 = LabelCompanyName;
		((Padding)(ref val))._002Ector(6, 0, 3, 0);
		((Control)labelCompanyName2).set_Margin(val);
		Label labelCompanyName3 = LabelCompanyName;
		size = new Size(0, 17);
		((Control)labelCompanyName3).set_MaximumSize(size);
		((Control)LabelCompanyName).set_Name("LabelCompanyName");
		Label labelCompanyName4 = LabelCompanyName;
		size = new Size(257, 17);
		((Control)labelCompanyName4).set_Size(size);
		((Control)LabelCompanyName).set_TabIndex(0);
		LabelCompanyName.set_Text("Company Name");
		LabelCompanyName.set_TextAlign((ContentAlignment)16);
		((Control)TextBoxDescription).set_Dock((DockStyle)5);
		TextBox textBoxDescription = TextBoxDescription;
		location = new Point(136, 103);
		((Control)textBoxDescription).set_Location(location);
		TextBox textBoxDescription2 = TextBoxDescription;
		((Padding)(ref val))._002Ector(6, 3, 3, 3);
		((Control)textBoxDescription2).set_Margin(val);
		TextBoxDescription.set_Multiline(true);
		((Control)TextBoxDescription).set_Name("TextBoxDescription");
		((TextBoxBase)TextBoxDescription).set_ReadOnly(true);
		TextBoxDescription.set_ScrollBars((ScrollBars)3);
		TextBox textBoxDescription3 = TextBoxDescription;
		size = new Size(257, 123);
		((Control)textBoxDescription3).set_Size(size);
		((Control)TextBoxDescription).set_TabIndex(0);
		((Control)TextBoxDescription).set_TabStop(false);
		TextBoxDescription.set_Text(componentResourceManager.GetString("TextBoxDescription.Text"));
		((Control)OKButton).set_Anchor((AnchorStyles)10);
		OKButton.set_DialogResult((DialogResult)2);
		Button oKButton = OKButton;
		location = new Point(318, 232);
		((Control)oKButton).set_Location(location);
		((Control)OKButton).set_Name("OKButton");
		Button oKButton2 = OKButton;
		size = new Size(75, 23);
		((Control)oKButton2).set_Size(size);
		((Control)OKButton).set_TabIndex(0);
		((ButtonBase)OKButton).set_Text("&OK");
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).set_AutoScaleDimensions(autoScaleDimensions);
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_CancelButton((IButtonControl)(object)OKButton);
		size = new Size(414, 276);
		((Form)this).set_ClientSize(size);
		((Control)this).get_Controls().Add((Control)(object)TableLayoutPanel);
		((Form)this).set_FormBorderStyle((FormBorderStyle)3);
		((Form)this).set_MaximizeBox(false);
		((Form)this).set_MinimizeBox(false);
		((Control)this).set_Name("AboutBox1");
		((Padding)(ref val))._002Ector(9);
		((Control)this).set_Padding(val);
		((Form)this).set_ShowInTaskbar(false);
		((Form)this).set_StartPosition((FormStartPosition)4);
		((Form)this).set_Text("AboutBox1");
		((Control)TableLayoutPanel).ResumeLayout(false);
		((Control)TableLayoutPanel).PerformLayout();
		((ISupportInitialize)LogoPictureBox).EndInit();
		((Control)this).ResumeLayout(false);
	}

	[MethodImpl(MethodImplOptions.NoOptimization)]
	private void AboutBox1_Load(object sender, EventArgs e)
	{
		string arg = ((Operators.CompareString(((ApplicationBase)MyProject.Application).get_Info().get_Title(), "", false) == 0) ? Path.GetFileNameWithoutExtension(((ApplicationBase)MyProject.Application).get_Info().get_AssemblyName()) : ((ApplicationBase)MyProject.Application).get_Info().get_Title());
		((Form)this).set_Text($"About {arg}");
		LabelProductName.set_Text(((ApplicationBase)MyProject.Application).get_Info().get_ProductName());
		LabelVersion.set_Text($"Version {((ApplicationBase)MyProject.Application).get_Info().get_Version().ToString()}");
		LabelCopyright.set_Text(((ApplicationBase)MyProject.Application).get_Info().get_Copyright());
		LabelCompanyName.set_Text(((ApplicationBase)MyProject.Application).get_Info().get_CompanyName());
		TextBoxDescription.set_Text(((ApplicationBase)MyProject.Application).get_Info().get_Description());
	}

	private void OKButton_Click(object sender, EventArgs e)
	{
		((Form)this).Close();
	}
}
