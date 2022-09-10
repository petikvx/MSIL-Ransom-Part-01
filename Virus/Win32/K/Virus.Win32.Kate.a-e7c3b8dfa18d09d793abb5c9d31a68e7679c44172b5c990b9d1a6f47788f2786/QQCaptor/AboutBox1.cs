using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Windows.Forms;

namespace QQCaptor;

internal class AboutBox1 : Form
{
	private IContainer components;

	private TableLayoutPanel tableLayoutPanel;

	private PictureBox logoPictureBox;

	private Label labelProductName;

	private Label labelVersion;

	private TextBox textBoxDescription;

	private Button okButton;

	public string AssemblyTitle
	{
		get
		{
			object[] customAttributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyTitleAttribute), inherit: false);
			if (customAttributes.Length > 0)
			{
				AssemblyTitleAttribute assemblyTitleAttribute = (AssemblyTitleAttribute)customAttributes[0];
				if (assemblyTitleAttribute.Title != "")
				{
					return assemblyTitleAttribute.Title;
				}
			}
			return Path.GetFileNameWithoutExtension(Assembly.GetExecutingAssembly().CodeBase);
		}
	}

	public string AssemblyVersion => Assembly.GetExecutingAssembly().GetName().Version!.ToString();

	public string AssemblyDescription
	{
		get
		{
			object[] customAttributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyDescriptionAttribute), inherit: false);
			if (customAttributes.Length == 0)
			{
				return "";
			}
			return ((AssemblyDescriptionAttribute)customAttributes[0]).Description;
		}
	}

	public string AssemblyProduct
	{
		get
		{
			object[] customAttributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyProductAttribute), inherit: false);
			if (customAttributes.Length == 0)
			{
				return "";
			}
			return ((AssemblyProductAttribute)customAttributes[0]).Product;
		}
	}

	public string AssemblyCopyright
	{
		get
		{
			object[] customAttributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyCopyrightAttribute), inherit: false);
			if (customAttributes.Length == 0)
			{
				return "";
			}
			return ((AssemblyCopyrightAttribute)customAttributes[0]).Copyright;
		}
	}

	public string AssemblyCompany
	{
		get
		{
			object[] customAttributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyCompanyAttribute), inherit: false);
			if (customAttributes.Length == 0)
			{
				return "";
			}
			return ((AssemblyCompanyAttribute)customAttributes[0]).Company;
		}
	}

	protected override void Dispose(bool disposing)
	{
		if (disposing && components != null)
		{
			components.Dispose();
		}
		((Form)this).Dispose(disposing);
	}

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
		//IL_008b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0095: Expected O, but got Unknown
		//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b1: Expected O, but got Unknown
		//IL_0176: Unknown result type (might be due to invalid IL or missing references)
		//IL_0180: Expected O, but got Unknown
		//IL_0192: Unknown result type (might be due to invalid IL or missing references)
		//IL_019c: Expected O, but got Unknown
		//IL_01ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b8: Expected O, but got Unknown
		//IL_01ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d4: Expected O, but got Unknown
		//IL_01e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f0: Expected O, but got Unknown
		//IL_0202: Unknown result type (might be due to invalid IL or missing references)
		//IL_020c: Expected O, but got Unknown
		//IL_0250: Unknown result type (might be due to invalid IL or missing references)
		//IL_025a: Expected O, but got Unknown
		//IL_02f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0394: Unknown result type (might be due to invalid IL or missing references)
		//IL_042e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0598: Unknown result type (might be due to invalid IL or missing references)
		//IL_05a2: Expected O, but got Unknown
		//IL_05c2: Unknown result type (might be due to invalid IL or missing references)
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(AboutBox1));
		tableLayoutPanel = new TableLayoutPanel();
		logoPictureBox = new PictureBox();
		labelProductName = new Label();
		labelVersion = new Label();
		textBoxDescription = new TextBox();
		okButton = new Button();
		((Control)tableLayoutPanel).SuspendLayout();
		((ISupportInitialize)logoPictureBox).BeginInit();
		((Control)this).SuspendLayout();
		tableLayoutPanel.set_ColumnCount(2);
		tableLayoutPanel.get_ColumnStyles().Add(new ColumnStyle((SizeType)2, 33f));
		tableLayoutPanel.get_ColumnStyles().Add(new ColumnStyle((SizeType)2, 67f));
		tableLayoutPanel.get_Controls().Add((Control)(object)logoPictureBox, 0, 0);
		tableLayoutPanel.get_Controls().Add((Control)(object)labelProductName, 1, 0);
		tableLayoutPanel.get_Controls().Add((Control)(object)labelVersion, 1, 1);
		tableLayoutPanel.get_Controls().Add((Control)(object)textBoxDescription, 1, 4);
		tableLayoutPanel.get_Controls().Add((Control)(object)okButton, 1, 5);
		((Control)tableLayoutPanel).set_Dock((DockStyle)5);
		((Control)tableLayoutPanel).set_Location(new Point(9, 8));
		((Control)tableLayoutPanel).set_Name("tableLayoutPanel");
		tableLayoutPanel.set_RowCount(6);
		tableLayoutPanel.get_RowStyles().Add(new RowStyle((SizeType)2, 10f));
		tableLayoutPanel.get_RowStyles().Add(new RowStyle((SizeType)2, 10f));
		tableLayoutPanel.get_RowStyles().Add(new RowStyle((SizeType)2, 10f));
		tableLayoutPanel.get_RowStyles().Add(new RowStyle((SizeType)2, 10f));
		tableLayoutPanel.get_RowStyles().Add(new RowStyle((SizeType)2, 50f));
		tableLayoutPanel.get_RowStyles().Add(new RowStyle((SizeType)2, 10f));
		((Control)tableLayoutPanel).set_Size(new Size(417, 245));
		((Control)tableLayoutPanel).set_TabIndex(0);
		((Control)logoPictureBox).set_Dock((DockStyle)5);
		logoPictureBox.set_Image((Image)componentResourceManager.GetObject("logoPictureBox.Image"));
		((Control)logoPictureBox).set_Location(new Point(3, 3));
		((Control)logoPictureBox).set_Name("logoPictureBox");
		tableLayoutPanel.SetRowSpan((Control)(object)logoPictureBox, 6);
		((Control)logoPictureBox).set_Size(new Size(131, 239));
		logoPictureBox.set_SizeMode((PictureBoxSizeMode)1);
		logoPictureBox.set_TabIndex(12);
		logoPictureBox.set_TabStop(false);
		((Control)labelProductName).set_Dock((DockStyle)5);
		((Control)labelProductName).set_Location(new Point(143, 0));
		((Control)labelProductName).set_Margin(new Padding(6, 0, 3, 0));
		((Control)labelProductName).set_MaximumSize(new Size(0, 16));
		((Control)labelProductName).set_Name("labelProductName");
		((Control)labelProductName).set_Size(new Size(271, 16));
		((Control)labelProductName).set_TabIndex(19);
		((Control)labelProductName).set_Text("产品名称：QQ捕快2009");
		labelProductName.set_TextAlign((ContentAlignment)16);
		((Control)labelVersion).set_Dock((DockStyle)5);
		((Control)labelVersion).set_Location(new Point(143, 24));
		((Control)labelVersion).set_Margin(new Padding(6, 0, 3, 0));
		((Control)labelVersion).set_MaximumSize(new Size(0, 16));
		((Control)labelVersion).set_Name("labelVersion");
		((Control)labelVersion).set_Size(new Size(271, 16));
		((Control)labelVersion).set_TabIndex(0);
		((Control)labelVersion).set_Text("版本：1.0.1");
		labelVersion.set_TextAlign((ContentAlignment)16);
		((Control)textBoxDescription).set_Dock((DockStyle)5);
		((Control)textBoxDescription).set_Location(new Point(143, 99));
		((Control)textBoxDescription).set_Margin(new Padding(6, 3, 3, 3));
		((TextBoxBase)textBoxDescription).set_Multiline(true);
		((Control)textBoxDescription).set_Name("textBoxDescription");
		((TextBoxBase)textBoxDescription).set_ReadOnly(true);
		textBoxDescription.set_ScrollBars((ScrollBars)3);
		((Control)textBoxDescription).set_Size(new Size(271, 116));
		((Control)textBoxDescription).set_TabIndex(23);
		((Control)textBoxDescription).set_TabStop(false);
		((Control)textBoxDescription).set_Text("永久免费");
		((Control)okButton).set_Anchor((AnchorStyles)10);
		okButton.set_DialogResult((DialogResult)2);
		((Control)okButton).set_Location(new Point(339, 221));
		((Control)okButton).set_Name("okButton");
		((Control)okButton).set_Size(new Size(75, 21));
		((Control)okButton).set_TabIndex(24);
		((Control)okButton).set_Text("确定(&O)");
		((Control)okButton).add_Click((EventHandler)okButton_Click);
		((Form)this).set_AcceptButton((IButtonControl)(object)okButton);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 12f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(435, 261));
		((Control)this).get_Controls().Add((Control)(object)tableLayoutPanel);
		((Form)this).set_FormBorderStyle((FormBorderStyle)3);
		((Form)this).set_Icon((Icon)componentResourceManager.GetObject("$this.Icon"));
		((Form)this).set_MaximizeBox(false);
		((Form)this).set_MinimizeBox(false);
		((Control)this).set_Name("AboutBox1");
		((Control)this).set_Padding(new Padding(9, 8, 9, 8));
		((Form)this).set_ShowIcon(false);
		((Form)this).set_ShowInTaskbar(false);
		((Form)this).set_StartPosition((FormStartPosition)4);
		((Control)this).set_Text("关于QQ捕快2009");
		((Form)this).set_TopMost(true);
		((Control)tableLayoutPanel).ResumeLayout(false);
		((Control)tableLayoutPanel).PerformLayout();
		((ISupportInitialize)logoPictureBox).EndInit();
		((Control)this).ResumeLayout(false);
	}

	public AboutBox1()
	{
		InitializeComponent();
		((Control)this).set_Text($"关于 {AssemblyTitle}");
		((Control)labelProductName).set_Text(AssemblyProduct);
		((Control)textBoxDescription).set_Text(AssemblyDescription);
		((Control)textBoxDescription).set_Text("永久免费");
		((Control)labelVersion).set_Text("0");
	}

	private void okButton_Click(object sender, EventArgs e)
	{
		((Form)this).Close();
	}
}
