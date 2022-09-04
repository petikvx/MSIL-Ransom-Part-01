using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Windows.Forms;

namespace liona;

internal class AboutBox1 : Form
{
	private IContainer components = null;

	private TableLayoutPanel tableLayoutPanel;

	private PictureBox logoPictureBox;

	private Label labelProductName;

	private Label labelVersion;

	private Label labelCopyright;

	private Label labelCompanyName;

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

	public AboutBox1()
	{
		InitializeComponent();
		((Control)this).set_Text($"À propos de {AssemblyTitle}");
		((Control)labelProductName).set_Text(AssemblyProduct);
		((Control)labelVersion).set_Text($"Version {AssemblyVersion}");
		((Control)labelCopyright).set_Text(AssemblyCopyright);
		((Control)labelCompanyName).set_Text(AssemblyCompany);
		((Control)textBoxDescription).set_Text(AssemblyDescription);
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
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Expected O, but got Unknown
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Expected O, but got Unknown
		//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ab: Expected O, but got Unknown
		//IL_00bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c7: Expected O, but got Unknown
		//IL_01bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c7: Expected O, but got Unknown
		//IL_01d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e3: Expected O, but got Unknown
		//IL_01f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ff: Expected O, but got Unknown
		//IL_0211: Unknown result type (might be due to invalid IL or missing references)
		//IL_021b: Expected O, but got Unknown
		//IL_022d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0237: Expected O, but got Unknown
		//IL_0249: Unknown result type (might be due to invalid IL or missing references)
		//IL_0253: Expected O, but got Unknown
		//IL_0297: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a1: Expected O, but got Unknown
		//IL_0340: Unknown result type (might be due to invalid IL or missing references)
		//IL_03db: Unknown result type (might be due to invalid IL or missing references)
		//IL_0475: Unknown result type (might be due to invalid IL or missing references)
		//IL_0510: Unknown result type (might be due to invalid IL or missing references)
		//IL_05ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_070e: Unknown result type (might be due to invalid IL or missing references)
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(AboutBox1));
		tableLayoutPanel = new TableLayoutPanel();
		logoPictureBox = new PictureBox();
		labelProductName = new Label();
		labelVersion = new Label();
		labelCopyright = new Label();
		labelCompanyName = new Label();
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
		tableLayoutPanel.get_Controls().Add((Control)(object)labelCopyright, 1, 2);
		tableLayoutPanel.get_Controls().Add((Control)(object)labelCompanyName, 1, 3);
		tableLayoutPanel.get_Controls().Add((Control)(object)textBoxDescription, 1, 4);
		tableLayoutPanel.get_Controls().Add((Control)(object)okButton, 1, 5);
		((Control)tableLayoutPanel).set_Dock((DockStyle)5);
		((Control)tableLayoutPanel).set_Location(new Point(9, 9));
		((Control)tableLayoutPanel).set_Name("tableLayoutPanel");
		tableLayoutPanel.set_RowCount(6);
		tableLayoutPanel.get_RowStyles().Add(new RowStyle((SizeType)2, 10f));
		tableLayoutPanel.get_RowStyles().Add(new RowStyle((SizeType)2, 10f));
		tableLayoutPanel.get_RowStyles().Add(new RowStyle((SizeType)2, 10f));
		tableLayoutPanel.get_RowStyles().Add(new RowStyle((SizeType)2, 10f));
		tableLayoutPanel.get_RowStyles().Add(new RowStyle((SizeType)2, 50f));
		tableLayoutPanel.get_RowStyles().Add(new RowStyle((SizeType)2, 10f));
		((Control)tableLayoutPanel).set_Size(new Size(417, 265));
		((Control)tableLayoutPanel).set_TabIndex(0);
		((Control)logoPictureBox).set_Dock((DockStyle)5);
		logoPictureBox.set_Image((Image)componentResourceManager.GetObject("logoPictureBox.Image"));
		((Control)logoPictureBox).set_Location(new Point(3, 3));
		((Control)logoPictureBox).set_Name("logoPictureBox");
		tableLayoutPanel.SetRowSpan((Control)(object)logoPictureBox, 6);
		((Control)logoPictureBox).set_Size(new Size(131, 259));
		logoPictureBox.set_SizeMode((PictureBoxSizeMode)1);
		logoPictureBox.set_TabIndex(12);
		logoPictureBox.set_TabStop(false);
		((Control)labelProductName).set_Dock((DockStyle)5);
		((Control)labelProductName).set_Location(new Point(143, 0));
		((Control)labelProductName).set_Margin(new Padding(6, 0, 3, 0));
		((Control)labelProductName).set_MaximumSize(new Size(0, 17));
		((Control)labelProductName).set_Name("labelProductName");
		((Control)labelProductName).set_Size(new Size(271, 17));
		((Control)labelProductName).set_TabIndex(19);
		((Control)labelProductName).set_Text("Nom du produit");
		labelProductName.set_TextAlign((ContentAlignment)16);
		((Control)labelVersion).set_Dock((DockStyle)5);
		((Control)labelVersion).set_Location(new Point(143, 26));
		((Control)labelVersion).set_Margin(new Padding(6, 0, 3, 0));
		((Control)labelVersion).set_MaximumSize(new Size(0, 17));
		((Control)labelVersion).set_Name("labelVersion");
		((Control)labelVersion).set_Size(new Size(271, 17));
		((Control)labelVersion).set_TabIndex(0);
		((Control)labelVersion).set_Text("Version");
		labelVersion.set_TextAlign((ContentAlignment)16);
		((Control)labelCopyright).set_Dock((DockStyle)5);
		((Control)labelCopyright).set_Location(new Point(143, 52));
		((Control)labelCopyright).set_Margin(new Padding(6, 0, 3, 0));
		((Control)labelCopyright).set_MaximumSize(new Size(0, 17));
		((Control)labelCopyright).set_Name("labelCopyright");
		((Control)labelCopyright).set_Size(new Size(271, 17));
		((Control)labelCopyright).set_TabIndex(21);
		((Control)labelCopyright).set_Text("Copyright");
		labelCopyright.set_TextAlign((ContentAlignment)16);
		((Control)labelCompanyName).set_Dock((DockStyle)5);
		((Control)labelCompanyName).set_Location(new Point(143, 78));
		((Control)labelCompanyName).set_Margin(new Padding(6, 0, 3, 0));
		((Control)labelCompanyName).set_MaximumSize(new Size(0, 17));
		((Control)labelCompanyName).set_Name("labelCompanyName");
		((Control)labelCompanyName).set_Size(new Size(271, 17));
		((Control)labelCompanyName).set_TabIndex(22);
		((Control)labelCompanyName).set_Text("Nom de la société");
		labelCompanyName.set_TextAlign((ContentAlignment)16);
		((Control)textBoxDescription).set_Dock((DockStyle)5);
		((Control)textBoxDescription).set_Location(new Point(143, 107));
		((Control)textBoxDescription).set_Margin(new Padding(6, 3, 3, 3));
		((TextBoxBase)textBoxDescription).set_Multiline(true);
		((Control)textBoxDescription).set_Name("textBoxDescription");
		((TextBoxBase)textBoxDescription).set_ReadOnly(true);
		textBoxDescription.set_ScrollBars((ScrollBars)3);
		((Control)textBoxDescription).set_Size(new Size(271, 126));
		((Control)textBoxDescription).set_TabIndex(23);
		((Control)textBoxDescription).set_TabStop(false);
		((Control)textBoxDescription).set_Text("Description");
		((Control)okButton).set_Anchor((AnchorStyles)10);
		okButton.set_DialogResult((DialogResult)2);
		((Control)okButton).set_Location(new Point(339, 239));
		((Control)okButton).set_Name("okButton");
		((Control)okButton).set_Size(new Size(75, 23));
		((Control)okButton).set_TabIndex(24);
		((Control)okButton).set_Text("&OK");
		((Form)this).set_AcceptButton((IButtonControl)(object)okButton);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(435, 283));
		((Control)this).get_Controls().Add((Control)(object)tableLayoutPanel);
		((Form)this).set_FormBorderStyle((FormBorderStyle)3);
		((Form)this).set_MaximizeBox(false);
		((Form)this).set_MinimizeBox(false);
		((Control)this).set_Name("AboutBox1");
		((Control)this).set_Padding(new Padding(9));
		((Form)this).set_ShowIcon(false);
		((Form)this).set_ShowInTaskbar(false);
		((Form)this).set_StartPosition((FormStartPosition)4);
		((Control)this).set_Text("AboutBox1");
		((Control)tableLayoutPanel).ResumeLayout(false);
		((Control)tableLayoutPanel).PerformLayout();
		((ISupportInitialize)logoPictureBox).EndInit();
		((Control)this).ResumeLayout(false);
	}
}
