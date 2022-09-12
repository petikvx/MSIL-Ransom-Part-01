using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Windows.Forms;

namespace ns0;

internal class AboutBox1 : Form
{
	private IContainer icontainer_0 = null;

	private TableLayoutPanel tableLayoutPanel;

	private PictureBox logoPictureBox;

	private Label labelProductName;

	private Label labelVersion;

	private Label labelCopyright;

	private Label labelCompanyName;

	private TextBox textBoxDescription;

	private Button okButton;

	private Panel panel1;

	private Panel panel2;

	private Panel panel3;

	private Panel panel4;

	private Panel panel5;

	private Panel panel6;

	private Panel panel7;

	private Panel panel8;

	private TextBox textBox17;

	private TextBox textBox16;

	private TextBox textBox15;

	private TextBox textBox14;

	private TextBox textBox13;

	private TextBox textBox12;

	private TextBox textBox11;

	private TextBox textBox10;

	private TextBox textBox9;

	private TextBox textBox8;

	private TextBox textBox7;

	private TextBox textBox6;

	private TextBox textBox5;

	private TextBox textBox4;

	private TextBox textBox3;

	private TextBox textBox2;

	private TextBox textBox1;

	private PictureBox pictureBox15;

	private PictureBox pictureBox14;

	private PictureBox pictureBox13;

	private PictureBox pictureBox12;

	private PictureBox pictureBox11;

	private PictureBox pictureBox10;

	private PictureBox pictureBox9;

	private PictureBox pictureBox8;

	private PictureBox pictureBox7;

	private PictureBox pictureBox6;

	private PictureBox pictureBox5;

	private PictureBox pictureBox4;

	private PictureBox pictureBox3;

	private PictureBox pictureBox2;

	private PictureBox pictureBox1;

	public string String_0
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

	public string String_1 => Assembly.GetExecutingAssembly().GetName().Version!.ToString();

	public string String_2
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

	public string String_3
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

	public string String_4
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

	public string String_5
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
		((Control)this).set_Text($"Informazioni su {String_0}");
		((Control)labelProductName).set_Text(String_3);
		((Control)labelVersion).set_Text($"Versione {String_1}");
		((Control)labelCopyright).set_Text(String_4);
		((Control)labelCompanyName).set_Text(String_5);
		((Control)textBoxDescription).set_Text(String_2);
	}

	protected override void Dispose(bool disposing)
	{
		if (disposing && icontainer_0 != null)
		{
			icontainer_0.Dispose();
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
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_0073: Expected O, but got Unknown
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Expected O, but got Unknown
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0089: Expected O, but got Unknown
		//IL_008a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0094: Expected O, but got Unknown
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		//IL_009f: Expected O, but got Unknown
		//IL_00a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00aa: Expected O, but got Unknown
		//IL_00ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b5: Expected O, but got Unknown
		//IL_00b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c0: Expected O, but got Unknown
		//IL_00c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cb: Expected O, but got Unknown
		//IL_00cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d6: Expected O, but got Unknown
		//IL_00d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e1: Expected O, but got Unknown
		//IL_00e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ec: Expected O, but got Unknown
		//IL_00ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f7: Expected O, but got Unknown
		//IL_00f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0102: Expected O, but got Unknown
		//IL_0103: Unknown result type (might be due to invalid IL or missing references)
		//IL_010d: Expected O, but got Unknown
		//IL_010e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0118: Expected O, but got Unknown
		//IL_0119: Unknown result type (might be due to invalid IL or missing references)
		//IL_0123: Expected O, but got Unknown
		//IL_0124: Unknown result type (might be due to invalid IL or missing references)
		//IL_012e: Expected O, but got Unknown
		//IL_012f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0139: Expected O, but got Unknown
		//IL_013a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0144: Expected O, but got Unknown
		//IL_0145: Unknown result type (might be due to invalid IL or missing references)
		//IL_014f: Expected O, but got Unknown
		//IL_0150: Unknown result type (might be due to invalid IL or missing references)
		//IL_015a: Expected O, but got Unknown
		//IL_015b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0165: Expected O, but got Unknown
		//IL_0166: Unknown result type (might be due to invalid IL or missing references)
		//IL_0170: Expected O, but got Unknown
		//IL_0171: Unknown result type (might be due to invalid IL or missing references)
		//IL_017b: Expected O, but got Unknown
		//IL_017c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0186: Expected O, but got Unknown
		//IL_0187: Unknown result type (might be due to invalid IL or missing references)
		//IL_0191: Expected O, but got Unknown
		//IL_0192: Unknown result type (might be due to invalid IL or missing references)
		//IL_019c: Expected O, but got Unknown
		//IL_019d: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a7: Expected O, but got Unknown
		//IL_01a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b2: Expected O, but got Unknown
		//IL_01b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bd: Expected O, but got Unknown
		//IL_01be: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c8: Expected O, but got Unknown
		//IL_01c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d3: Expected O, but got Unknown
		//IL_01d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01de: Expected O, but got Unknown
		//IL_01df: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e9: Expected O, but got Unknown
		//IL_01ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f4: Expected O, but got Unknown
		//IL_01f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ff: Expected O, but got Unknown
		//IL_0200: Unknown result type (might be due to invalid IL or missing references)
		//IL_020a: Expected O, but got Unknown
		//IL_020b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0215: Expected O, but got Unknown
		//IL_0216: Unknown result type (might be due to invalid IL or missing references)
		//IL_0220: Expected O, but got Unknown
		//IL_0356: Unknown result type (might be due to invalid IL or missing references)
		//IL_0360: Expected O, but got Unknown
		//IL_0372: Unknown result type (might be due to invalid IL or missing references)
		//IL_037c: Expected O, but got Unknown
		//IL_0472: Unknown result type (might be due to invalid IL or missing references)
		//IL_047c: Expected O, but got Unknown
		//IL_048e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0498: Expected O, but got Unknown
		//IL_04aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_04b4: Expected O, but got Unknown
		//IL_04c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_04d0: Expected O, but got Unknown
		//IL_04e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ec: Expected O, but got Unknown
		//IL_04fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0508: Expected O, but got Unknown
		//IL_054c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0556: Expected O, but got Unknown
		//IL_05f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0690: Unknown result type (might be due to invalid IL or missing references)
		//IL_072a: Unknown result type (might be due to invalid IL or missing references)
		//IL_07c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0860: Unknown result type (might be due to invalid IL or missing references)
		//IL_1891: Unknown result type (might be due to invalid IL or missing references)
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(AboutBox1));
		tableLayoutPanel = new TableLayoutPanel();
		logoPictureBox = new PictureBox();
		labelProductName = new Label();
		labelVersion = new Label();
		labelCopyright = new Label();
		labelCompanyName = new Label();
		textBoxDescription = new TextBox();
		okButton = new Button();
		panel1 = new Panel();
		panel2 = new Panel();
		panel3 = new Panel();
		panel4 = new Panel();
		panel5 = new Panel();
		panel6 = new Panel();
		panel7 = new Panel();
		panel8 = new Panel();
		pictureBox1 = new PictureBox();
		pictureBox2 = new PictureBox();
		pictureBox3 = new PictureBox();
		pictureBox4 = new PictureBox();
		pictureBox5 = new PictureBox();
		pictureBox6 = new PictureBox();
		pictureBox7 = new PictureBox();
		pictureBox8 = new PictureBox();
		pictureBox9 = new PictureBox();
		pictureBox10 = new PictureBox();
		pictureBox11 = new PictureBox();
		pictureBox12 = new PictureBox();
		pictureBox13 = new PictureBox();
		pictureBox14 = new PictureBox();
		pictureBox15 = new PictureBox();
		textBox1 = new TextBox();
		textBox2 = new TextBox();
		textBox3 = new TextBox();
		textBox4 = new TextBox();
		textBox5 = new TextBox();
		textBox6 = new TextBox();
		textBox7 = new TextBox();
		textBox8 = new TextBox();
		textBox9 = new TextBox();
		textBox10 = new TextBox();
		textBox11 = new TextBox();
		textBox12 = new TextBox();
		textBox13 = new TextBox();
		textBox14 = new TextBox();
		textBox15 = new TextBox();
		textBox16 = new TextBox();
		textBox17 = new TextBox();
		((Control)tableLayoutPanel).SuspendLayout();
		((ISupportInitialize)logoPictureBox).BeginInit();
		((Control)panel1).SuspendLayout();
		((Control)panel2).SuspendLayout();
		((Control)panel3).SuspendLayout();
		((Control)panel4).SuspendLayout();
		((Control)panel5).SuspendLayout();
		((Control)panel6).SuspendLayout();
		((Control)panel7).SuspendLayout();
		((Control)panel8).SuspendLayout();
		((ISupportInitialize)pictureBox1).BeginInit();
		((ISupportInitialize)pictureBox2).BeginInit();
		((ISupportInitialize)pictureBox3).BeginInit();
		((ISupportInitialize)pictureBox4).BeginInit();
		((ISupportInitialize)pictureBox5).BeginInit();
		((ISupportInitialize)pictureBox6).BeginInit();
		((ISupportInitialize)pictureBox7).BeginInit();
		((ISupportInitialize)pictureBox8).BeginInit();
		((ISupportInitialize)pictureBox9).BeginInit();
		((ISupportInitialize)pictureBox10).BeginInit();
		((ISupportInitialize)pictureBox11).BeginInit();
		((ISupportInitialize)pictureBox12).BeginInit();
		((ISupportInitialize)pictureBox13).BeginInit();
		((ISupportInitialize)pictureBox14).BeginInit();
		((ISupportInitialize)pictureBox15).BeginInit();
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
		((Control)tableLayoutPanel).set_Size(new Size(696, 265));
		((Control)tableLayoutPanel).set_TabIndex(0);
		((Control)logoPictureBox).set_Dock((DockStyle)5);
		logoPictureBox.set_Image((Image)componentResourceManager.GetObject("logoPictureBox.Image"));
		((Control)logoPictureBox).set_Location(new Point(3, 3));
		((Control)logoPictureBox).set_Name("logoPictureBox");
		tableLayoutPanel.SetRowSpan((Control)(object)logoPictureBox, 6);
		((Control)logoPictureBox).set_Size(new Size(223, 259));
		logoPictureBox.set_SizeMode((PictureBoxSizeMode)1);
		logoPictureBox.set_TabIndex(12);
		logoPictureBox.set_TabStop(false);
		((Control)labelProductName).set_Dock((DockStyle)5);
		((Control)labelProductName).set_Location(new Point(235, 0));
		((Control)labelProductName).set_Margin(new Padding(6, 0, 3, 0));
		((Control)labelProductName).set_MaximumSize(new Size(0, 17));
		((Control)labelProductName).set_Name("labelProductName");
		((Control)labelProductName).set_Size(new Size(458, 17));
		((Control)labelProductName).set_TabIndex(19);
		((Control)labelProductName).set_Text("Nome prodotto");
		labelProductName.set_TextAlign((ContentAlignment)16);
		((Control)labelVersion).set_Dock((DockStyle)5);
		((Control)labelVersion).set_Location(new Point(235, 26));
		((Control)labelVersion).set_Margin(new Padding(6, 0, 3, 0));
		((Control)labelVersion).set_MaximumSize(new Size(0, 17));
		((Control)labelVersion).set_Name("labelVersion");
		((Control)labelVersion).set_Size(new Size(458, 17));
		((Control)labelVersion).set_TabIndex(0);
		((Control)labelVersion).set_Text("Versione");
		labelVersion.set_TextAlign((ContentAlignment)16);
		((Control)labelCopyright).set_Dock((DockStyle)5);
		((Control)labelCopyright).set_Location(new Point(235, 52));
		((Control)labelCopyright).set_Margin(new Padding(6, 0, 3, 0));
		((Control)labelCopyright).set_MaximumSize(new Size(0, 17));
		((Control)labelCopyright).set_Name("labelCopyright");
		((Control)labelCopyright).set_Size(new Size(458, 17));
		((Control)labelCopyright).set_TabIndex(21);
		((Control)labelCopyright).set_Text("Copyright");
		labelCopyright.set_TextAlign((ContentAlignment)16);
		((Control)labelCompanyName).set_Dock((DockStyle)5);
		((Control)labelCompanyName).set_Location(new Point(235, 78));
		((Control)labelCompanyName).set_Margin(new Padding(6, 0, 3, 0));
		((Control)labelCompanyName).set_MaximumSize(new Size(0, 17));
		((Control)labelCompanyName).set_Name("labelCompanyName");
		((Control)labelCompanyName).set_Size(new Size(458, 17));
		((Control)labelCompanyName).set_TabIndex(22);
		((Control)labelCompanyName).set_Text("Nome società");
		labelCompanyName.set_TextAlign((ContentAlignment)16);
		((Control)textBoxDescription).set_Dock((DockStyle)5);
		((Control)textBoxDescription).set_Location(new Point(235, 107));
		((Control)textBoxDescription).set_Margin(new Padding(6, 3, 3, 3));
		((TextBoxBase)textBoxDescription).set_Multiline(true);
		((Control)textBoxDescription).set_Name("textBoxDescription");
		((TextBoxBase)textBoxDescription).set_ReadOnly(true);
		textBoxDescription.set_ScrollBars((ScrollBars)3);
		((Control)textBoxDescription).set_Size(new Size(458, 126));
		((Control)textBoxDescription).set_TabIndex(23);
		((Control)textBoxDescription).set_TabStop(false);
		((Control)textBoxDescription).set_Text("Descrizione");
		((Control)okButton).set_Anchor((AnchorStyles)10);
		okButton.set_DialogResult((DialogResult)2);
		((Control)okButton).set_Location(new Point(618, 239));
		((Control)okButton).set_Name("okButton");
		((Control)okButton).set_Size(new Size(75, 23));
		((Control)okButton).set_TabIndex(24);
		((Control)okButton).set_Text("&OK");
		((Control)panel1).get_Controls().Add((Control)(object)panel2);
		((Control)panel1).set_Location(new Point(0, 0));
		((Control)panel1).set_Name("panel1");
		((Control)panel1).set_Size(new Size(200, 100));
		((Control)panel1).set_TabIndex(1);
		((Control)panel2).get_Controls().Add((Control)(object)panel3);
		((Control)panel2).set_Location(new Point(0, 0));
		((Control)panel2).set_Name("panel2");
		((Control)panel2).set_Size(new Size(200, 100));
		((Control)panel2).set_TabIndex(0);
		((Control)panel3).get_Controls().Add((Control)(object)panel4);
		((Control)panel3).set_Location(new Point(0, 0));
		((Control)panel3).set_Name("panel3");
		((Control)panel3).set_Size(new Size(200, 100));
		((Control)panel3).set_TabIndex(0);
		((Control)panel4).get_Controls().Add((Control)(object)panel5);
		((Control)panel4).set_Location(new Point(0, 0));
		((Control)panel4).set_Name("panel4");
		((Control)panel4).set_Size(new Size(200, 100));
		((Control)panel4).set_TabIndex(0);
		((Control)panel5).get_Controls().Add((Control)(object)panel6);
		((Control)panel5).set_Location(new Point(0, 0));
		((Control)panel5).set_Name("panel5");
		((Control)panel5).set_Size(new Size(200, 100));
		((Control)panel5).set_TabIndex(0);
		((Control)panel6).get_Controls().Add((Control)(object)panel7);
		((Control)panel6).set_Location(new Point(0, 0));
		((Control)panel6).set_Name("panel6");
		((Control)panel6).set_Size(new Size(200, 100));
		((Control)panel6).set_TabIndex(0);
		((Control)panel7).get_Controls().Add((Control)(object)panel8);
		((Control)panel7).set_Location(new Point(0, 0));
		((Control)panel7).set_Name("panel7");
		((Control)panel7).set_Size(new Size(200, 100));
		((Control)panel7).set_TabIndex(0);
		((Control)panel8).get_Controls().Add((Control)(object)textBox17);
		((Control)panel8).get_Controls().Add((Control)(object)textBox16);
		((Control)panel8).get_Controls().Add((Control)(object)textBox15);
		((Control)panel8).get_Controls().Add((Control)(object)textBox14);
		((Control)panel8).get_Controls().Add((Control)(object)textBox13);
		((Control)panel8).get_Controls().Add((Control)(object)textBox12);
		((Control)panel8).get_Controls().Add((Control)(object)textBox11);
		((Control)panel8).get_Controls().Add((Control)(object)textBox10);
		((Control)panel8).get_Controls().Add((Control)(object)textBox9);
		((Control)panel8).get_Controls().Add((Control)(object)textBox8);
		((Control)panel8).get_Controls().Add((Control)(object)textBox7);
		((Control)panel8).get_Controls().Add((Control)(object)textBox6);
		((Control)panel8).get_Controls().Add((Control)(object)textBox5);
		((Control)panel8).get_Controls().Add((Control)(object)textBox4);
		((Control)panel8).get_Controls().Add((Control)(object)textBox3);
		((Control)panel8).get_Controls().Add((Control)(object)textBox2);
		((Control)panel8).get_Controls().Add((Control)(object)textBox1);
		((Control)panel8).get_Controls().Add((Control)(object)pictureBox15);
		((Control)panel8).get_Controls().Add((Control)(object)pictureBox14);
		((Control)panel8).get_Controls().Add((Control)(object)pictureBox13);
		((Control)panel8).get_Controls().Add((Control)(object)pictureBox12);
		((Control)panel8).get_Controls().Add((Control)(object)pictureBox11);
		((Control)panel8).get_Controls().Add((Control)(object)pictureBox10);
		((Control)panel8).get_Controls().Add((Control)(object)pictureBox9);
		((Control)panel8).get_Controls().Add((Control)(object)pictureBox8);
		((Control)panel8).get_Controls().Add((Control)(object)pictureBox7);
		((Control)panel8).get_Controls().Add((Control)(object)pictureBox6);
		((Control)panel8).get_Controls().Add((Control)(object)pictureBox5);
		((Control)panel8).get_Controls().Add((Control)(object)pictureBox4);
		((Control)panel8).get_Controls().Add((Control)(object)pictureBox3);
		((Control)panel8).get_Controls().Add((Control)(object)pictureBox2);
		((Control)panel8).get_Controls().Add((Control)(object)pictureBox1);
		((Control)panel8).set_Location(new Point(0, 0));
		((Control)panel8).set_Name("panel8");
		((Control)panel8).set_Size(new Size(200, 100));
		((Control)panel8).set_TabIndex(0);
		((Control)pictureBox1).set_Location(new Point(0, 0));
		((Control)pictureBox1).set_Name("pictureBox1");
		((Control)pictureBox1).set_Size(new Size(100, 50));
		pictureBox1.set_TabIndex(0);
		pictureBox1.set_TabStop(false);
		((Control)pictureBox2).set_Location(new Point(8, 8));
		((Control)pictureBox2).set_Name("pictureBox2");
		((Control)pictureBox2).set_Size(new Size(100, 50));
		pictureBox2.set_TabIndex(1);
		pictureBox2.set_TabStop(false);
		((Control)pictureBox3).set_Location(new Point(16, 16));
		((Control)pictureBox3).set_Name("pictureBox3");
		((Control)pictureBox3).set_Size(new Size(100, 50));
		pictureBox3.set_TabIndex(2);
		pictureBox3.set_TabStop(false);
		((Control)pictureBox4).set_Location(new Point(24, 24));
		((Control)pictureBox4).set_Name("pictureBox4");
		((Control)pictureBox4).set_Size(new Size(100, 50));
		pictureBox4.set_TabIndex(3);
		pictureBox4.set_TabStop(false);
		((Control)pictureBox5).set_Location(new Point(32, 32));
		((Control)pictureBox5).set_Name("pictureBox5");
		((Control)pictureBox5).set_Size(new Size(100, 50));
		pictureBox5.set_TabIndex(4);
		pictureBox5.set_TabStop(false);
		((Control)pictureBox6).set_Location(new Point(40, 40));
		((Control)pictureBox6).set_Name("pictureBox6");
		((Control)pictureBox6).set_Size(new Size(100, 50));
		pictureBox6.set_TabIndex(5);
		pictureBox6.set_TabStop(false);
		((Control)pictureBox7).set_Location(new Point(48, 48));
		((Control)pictureBox7).set_Name("pictureBox7");
		((Control)pictureBox7).set_Size(new Size(100, 50));
		pictureBox7.set_TabIndex(6);
		pictureBox7.set_TabStop(false);
		((Control)pictureBox8).set_Location(new Point(0, 0));
		((Control)pictureBox8).set_Name("pictureBox8");
		((Control)pictureBox8).set_Size(new Size(100, 50));
		pictureBox8.set_TabIndex(7);
		pictureBox8.set_TabStop(false);
		((Control)pictureBox9).set_Location(new Point(8, 8));
		((Control)pictureBox9).set_Name("pictureBox9");
		((Control)pictureBox9).set_Size(new Size(100, 50));
		pictureBox9.set_TabIndex(8);
		pictureBox9.set_TabStop(false);
		((Control)pictureBox10).set_Location(new Point(16, 16));
		((Control)pictureBox10).set_Name("pictureBox10");
		((Control)pictureBox10).set_Size(new Size(100, 50));
		pictureBox10.set_TabIndex(9);
		pictureBox10.set_TabStop(false);
		((Control)pictureBox11).set_Location(new Point(24, 24));
		((Control)pictureBox11).set_Name("pictureBox11");
		((Control)pictureBox11).set_Size(new Size(100, 50));
		pictureBox11.set_TabIndex(10);
		pictureBox11.set_TabStop(false);
		((Control)pictureBox12).set_Location(new Point(32, 32));
		((Control)pictureBox12).set_Name("pictureBox12");
		((Control)pictureBox12).set_Size(new Size(100, 50));
		pictureBox12.set_TabIndex(11);
		pictureBox12.set_TabStop(false);
		((Control)pictureBox13).set_Location(new Point(40, 40));
		((Control)pictureBox13).set_Name("pictureBox13");
		((Control)pictureBox13).set_Size(new Size(100, 50));
		pictureBox13.set_TabIndex(12);
		pictureBox13.set_TabStop(false);
		((Control)pictureBox14).set_Location(new Point(48, 48));
		((Control)pictureBox14).set_Name("pictureBox14");
		((Control)pictureBox14).set_Size(new Size(100, 50));
		pictureBox14.set_TabIndex(13);
		pictureBox14.set_TabStop(false);
		((Control)pictureBox15).set_Location(new Point(0, 0));
		((Control)pictureBox15).set_Name("pictureBox15");
		((Control)pictureBox15).set_Size(new Size(100, 50));
		pictureBox15.set_TabIndex(14);
		pictureBox15.set_TabStop(false);
		((Control)textBox1).set_Location(new Point(8, 8));
		((Control)textBox1).set_Name("textBox1");
		((Control)textBox1).set_Size(new Size(100, 20));
		((Control)textBox1).set_TabIndex(15);
		((Control)textBox2).set_Location(new Point(16, 16));
		((Control)textBox2).set_Name("textBox2");
		((Control)textBox2).set_Size(new Size(100, 20));
		((Control)textBox2).set_TabIndex(16);
		((Control)textBox3).set_Location(new Point(24, 24));
		((Control)textBox3).set_Name("textBox3");
		((Control)textBox3).set_Size(new Size(100, 20));
		((Control)textBox3).set_TabIndex(17);
		((Control)textBox4).set_Location(new Point(32, 32));
		((Control)textBox4).set_Name("textBox4");
		((Control)textBox4).set_Size(new Size(100, 20));
		((Control)textBox4).set_TabIndex(18);
		((Control)textBox5).set_Location(new Point(40, 40));
		((Control)textBox5).set_Name("textBox5");
		((Control)textBox5).set_Size(new Size(100, 20));
		((Control)textBox5).set_TabIndex(19);
		((Control)textBox6).set_Location(new Point(48, 48));
		((Control)textBox6).set_Name("textBox6");
		((Control)textBox6).set_Size(new Size(100, 20));
		((Control)textBox6).set_TabIndex(20);
		((Control)textBox7).set_Location(new Point(56, 56));
		((Control)textBox7).set_Name("textBox7");
		((Control)textBox7).set_Size(new Size(100, 20));
		((Control)textBox7).set_TabIndex(21);
		((Control)textBox8).set_Location(new Point(64, 64));
		((Control)textBox8).set_Name("textBox8");
		((Control)textBox8).set_Size(new Size(100, 20));
		((Control)textBox8).set_TabIndex(22);
		((Control)textBox9).set_Location(new Point(72, 72));
		((Control)textBox9).set_Name("textBox9");
		((Control)textBox9).set_Size(new Size(100, 20));
		((Control)textBox9).set_TabIndex(23);
		((Control)textBox10).set_Location(new Point(0, 0));
		((Control)textBox10).set_Name("textBox10");
		((Control)textBox10).set_Size(new Size(100, 20));
		((Control)textBox10).set_TabIndex(24);
		((Control)textBox11).set_Location(new Point(8, 8));
		((Control)textBox11).set_Name("textBox11");
		((Control)textBox11).set_Size(new Size(100, 20));
		((Control)textBox11).set_TabIndex(25);
		((Control)textBox12).set_Location(new Point(16, 16));
		((Control)textBox12).set_Name("textBox12");
		((Control)textBox12).set_Size(new Size(100, 20));
		((Control)textBox12).set_TabIndex(26);
		((Control)textBox13).set_Location(new Point(24, 24));
		((Control)textBox13).set_Name("textBox13");
		((Control)textBox13).set_Size(new Size(100, 20));
		((Control)textBox13).set_TabIndex(27);
		((Control)textBox14).set_Location(new Point(32, 32));
		((Control)textBox14).set_Name("textBox14");
		((Control)textBox14).set_Size(new Size(100, 20));
		((Control)textBox14).set_TabIndex(28);
		((Control)textBox15).set_Location(new Point(40, 40));
		((Control)textBox15).set_Name("textBox15");
		((Control)textBox15).set_Size(new Size(100, 20));
		((Control)textBox15).set_TabIndex(29);
		((Control)textBox16).set_Location(new Point(48, 48));
		((Control)textBox16).set_Name("textBox16");
		((Control)textBox16).set_Size(new Size(100, 20));
		((Control)textBox16).set_TabIndex(30);
		((Control)textBox17).set_Location(new Point(56, 56));
		((Control)textBox17).set_Name("textBox17");
		((Control)textBox17).set_Size(new Size(100, 20));
		((Control)textBox17).set_TabIndex(31);
		((Form)this).set_AcceptButton((IButtonControl)(object)okButton);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(714, 283));
		((Control)this).get_Controls().Add((Control)(object)panel1);
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
		((Control)panel1).ResumeLayout(false);
		((Control)panel2).ResumeLayout(false);
		((Control)panel3).ResumeLayout(false);
		((Control)panel4).ResumeLayout(false);
		((Control)panel5).ResumeLayout(false);
		((Control)panel6).ResumeLayout(false);
		((Control)panel7).ResumeLayout(false);
		((Control)panel8).ResumeLayout(false);
		((Control)panel8).PerformLayout();
		((ISupportInitialize)pictureBox1).EndInit();
		((ISupportInitialize)pictureBox2).EndInit();
		((ISupportInitialize)pictureBox3).EndInit();
		((ISupportInitialize)pictureBox4).EndInit();
		((ISupportInitialize)pictureBox5).EndInit();
		((ISupportInitialize)pictureBox6).EndInit();
		((ISupportInitialize)pictureBox7).EndInit();
		((ISupportInitialize)pictureBox8).EndInit();
		((ISupportInitialize)pictureBox9).EndInit();
		((ISupportInitialize)pictureBox10).EndInit();
		((ISupportInitialize)pictureBox11).EndInit();
		((ISupportInitialize)pictureBox12).EndInit();
		((ISupportInitialize)pictureBox13).EndInit();
		((ISupportInitialize)pictureBox14).EndInit();
		((ISupportInitialize)pictureBox15).EndInit();
		((Control)this).ResumeLayout(false);
	}
}
