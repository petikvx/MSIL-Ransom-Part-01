using System;
using System.ComponentModel;
using System.Configuration;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Xml;
using ns0;

namespace VerificareSiuiFarmacie;

public class frmConfigurare : Form
{
	private IContainer icontainer_0 = null;

	private Button btnOk;

	private Button btnCancel;

	private Label lblCaleComunicatie;

	private TextBox txtCaleComunicatie;

	private TextBox txtUserToken;

	private Label lblUserTalken;

	private TextBox txtLicentaSIUI;

	private Label lblLicentaSIUI;

	private TextBox txtUserInregistrareCasa;

	private Label lblUserInregistrareCasa;

	private FolderBrowserDialog folderBrowserDialog_0;

	private Button btnChoseFolder;

	private ImageList imageList_0;

	private CheckBox chkSemnareFisierRaportare;

	private TextBox txtNumarSerialToken;

	private Label lblNumarSerialToken;

	private Label lblPort;

	private MaskedTextBox txtPort;

	private CheckBox chkVersiuneTest;

	private bool bool_0;

	public frmConfigurare()
	{
		InitializeComponent();
	}

	public frmConfigurare(bool _Serveronline)
	{
		bool_0 = _Serveronline;
		InitializeComponent();
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
		//IL_00a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b0: Expected O, but got Unknown
		//IL_00b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bb: Expected O, but got Unknown
		//IL_00bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c6: Expected O, but got Unknown
		//IL_00c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d1: Expected O, but got Unknown
		//IL_00d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dc: Expected O, but got Unknown
		//IL_00dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e7: Expected O, but got Unknown
		//IL_00e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f2: Expected O, but got Unknown
		//IL_010b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0115: Expected O, but got Unknown
		//IL_01ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b8: Expected O, but got Unknown
		//IL_0254: Unknown result type (might be due to invalid IL or missing references)
		//IL_025e: Expected O, but got Unknown
		//IL_0374: Unknown result type (might be due to invalid IL or missing references)
		//IL_037e: Expected O, but got Unknown
		//IL_043b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0445: Expected O, but got Unknown
		//IL_0503: Unknown result type (might be due to invalid IL or missing references)
		//IL_050d: Expected O, but got Unknown
		//IL_05fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0605: Expected O, but got Unknown
		//IL_0660: Unknown result type (might be due to invalid IL or missing references)
		//IL_066a: Expected O, but got Unknown
		//IL_074e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0758: Expected O, but got Unknown
		//IL_07cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_07d5: Expected O, but got Unknown
		//IL_08d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_08e1: Expected O, but got Unknown
		//IL_0ab6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ac0: Expected O, but got Unknown
		icontainer_0 = new Container();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(frmConfigurare));
		btnOk = new Button();
		btnCancel = new Button();
		lblCaleComunicatie = new Label();
		txtCaleComunicatie = new TextBox();
		txtUserToken = new TextBox();
		lblUserTalken = new Label();
		txtLicentaSIUI = new TextBox();
		lblLicentaSIUI = new Label();
		txtUserInregistrareCasa = new TextBox();
		lblUserInregistrareCasa = new Label();
		folderBrowserDialog_0 = new FolderBrowserDialog();
		btnChoseFolder = new Button();
		imageList_0 = new ImageList(icontainer_0);
		chkSemnareFisierRaportare = new CheckBox();
		txtNumarSerialToken = new TextBox();
		lblNumarSerialToken = new Label();
		lblPort = new Label();
		txtPort = new MaskedTextBox();
		chkVersiuneTest = new CheckBox();
		((Control)this).SuspendLayout();
		((Control)btnOk).set_Font(new Font("Microsoft Sans Serif", 8.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)btnOk).set_Location(new Point(80, 282));
		((Control)btnOk).set_Name("btnOk");
		((Control)btnOk).set_Size(new Size(111, 23));
		((Control)btnOk).set_TabIndex(0);
		((Control)btnOk).set_Text("Ok");
		((ButtonBase)btnOk).set_UseVisualStyleBackColor(true);
		((Control)btnOk).add_Click((EventHandler)btnOk_Click);
		btnCancel.set_DialogResult((DialogResult)2);
		((Control)btnCancel).set_Font(new Font("Microsoft Sans Serif", 8.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)btnCancel).set_Location(new Point(219, 282));
		((Control)btnCancel).set_Name("btnCancel");
		((Control)btnCancel).set_Size(new Size(111, 23));
		((Control)btnCancel).set_TabIndex(1);
		((Control)btnCancel).set_Text("Cancel");
		((ButtonBase)btnCancel).set_UseVisualStyleBackColor(true);
		((Control)btnCancel).add_Click((EventHandler)btnCancel_Click);
		((Control)lblCaleComunicatie).set_AutoSize(true);
		((Control)lblCaleComunicatie).set_Font(new Font("Microsoft Sans Serif", 8.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)lblCaleComunicatie).set_Location(new Point(4, 13));
		((Control)lblCaleComunicatie).set_Name("lblCaleComunicatie");
		((Control)lblCaleComunicatie).set_Size(new Size(108, 13));
		((Control)lblCaleComunicatie).set_TabIndex(2);
		((Control)lblCaleComunicatie).set_Text("Cale comunicatie:");
		((Control)txtCaleComunicatie).set_Location(new Point(7, 30));
		((Control)txtCaleComunicatie).set_Name("txtCaleComunicatie");
		((TextBoxBase)txtCaleComunicatie).set_ReadOnly(true);
		((Control)txtCaleComunicatie).set_Size(new Size(375, 20));
		((Control)txtCaleComunicatie).set_TabIndex(3);
		txtUserToken.set_AcceptsReturn(true);
		((Control)txtUserToken).set_Location(new Point(8, 74));
		((Control)txtUserToken).set_Name("txtUserToken");
		((Control)txtUserToken).set_Size(new Size(409, 20));
		((Control)txtUserToken).set_TabIndex(5);
		((Control)lblUserTalken).set_AutoSize(true);
		((Control)lblUserTalken).set_Font(new Font("Microsoft Sans Serif", 8.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)lblUserTalken).set_Location(new Point(5, 57));
		((Control)lblUserTalken).set_Name("lblUserTalken");
		((Control)lblUserTalken).set_Size(new Size(73, 13));
		((Control)lblUserTalken).set_TabIndex(4);
		((Control)lblUserTalken).set_Text("User token:");
		((Control)txtLicentaSIUI).set_Location(new Point(9, 208));
		((Control)txtLicentaSIUI).set_Name("txtLicentaSIUI");
		((Control)txtLicentaSIUI).set_Size(new Size(409, 20));
		((Control)txtLicentaSIUI).set_TabIndex(9);
		((Control)lblLicentaSIUI).set_AutoSize(true);
		((Control)lblLicentaSIUI).set_Font(new Font("Microsoft Sans Serif", 8.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)lblLicentaSIUI).set_Location(new Point(6, 191));
		((Control)lblLicentaSIUI).set_Name("lblLicentaSIUI");
		((Control)lblLicentaSIUI).set_Size(new Size(82, 13));
		((Control)lblLicentaSIUI).set_TabIndex(8);
		((Control)lblLicentaSIUI).set_Text("Licenta SIUI:");
		((Control)txtUserInregistrareCasa).set_Location(new Point(8, 164));
		((Control)txtUserInregistrareCasa).set_Name("txtUserInregistrareCasa");
		((Control)txtUserInregistrareCasa).set_Size(new Size(409, 20));
		((Control)txtUserInregistrareCasa).set_TabIndex(7);
		((Control)lblUserInregistrareCasa).set_AutoSize(true);
		((Control)lblUserInregistrareCasa).set_Font(new Font("Microsoft Sans Serif", 8.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)lblUserInregistrareCasa).set_Location(new Point(5, 147));
		((Control)lblUserInregistrareCasa).set_Name("lblUserInregistrareCasa");
		((Control)lblUserInregistrareCasa).set_Size(new Size(108, 13));
		((Control)lblUserInregistrareCasa).set_TabIndex(6);
		((Control)lblUserInregistrareCasa).set_Text("User inregistrare :");
		folderBrowserDialog_0.set_ShowNewFolderButton(false);
		((Control)btnChoseFolder).set_Location(new Point(386, 31));
		((Control)btnChoseFolder).set_Name("btnChoseFolder");
		((Control)btnChoseFolder).set_Size(new Size(29, 21));
		((Control)btnChoseFolder).set_TabIndex(10);
		((Control)btnChoseFolder).set_Text("...");
		((ButtonBase)btnChoseFolder).set_UseVisualStyleBackColor(true);
		((Control)btnChoseFolder).add_Click((EventHandler)btnChoseFolder_Click);
		imageList_0.set_ImageStream((ImageListStreamer)componentResourceManager.GetObject("imageList1.ImageStream"));
		imageList_0.set_TransparentColor(Color.Transparent);
		imageList_0.get_Images().SetKeyName(0, "pharmec.ico");
		imageList_0.get_Images().SetKeyName(1, "pharmec-red.ico");
		((Control)chkSemnareFisierRaportare).set_AutoSize(true);
		((Control)chkSemnareFisierRaportare).set_Font(new Font("Microsoft Sans Serif", 8.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)chkSemnareFisierRaportare).set_Location(new Point(13, 235));
		((Control)chkSemnareFisierRaportare).set_Name("chkSemnareFisierRaportare");
		((Control)chkSemnareFisierRaportare).set_Size(new Size(161, 17));
		((Control)chkSemnareFisierRaportare).set_TabIndex(11);
		((Control)chkSemnareFisierRaportare).set_Text("Semnare fisier raportare");
		((ButtonBase)chkSemnareFisierRaportare).set_UseVisualStyleBackColor(true);
		chkSemnareFisierRaportare.add_CheckedChanged((EventHandler)chkSemnareFisierRaportare_CheckedChanged);
		((Control)txtNumarSerialToken).set_Location(new Point(8, 118));
		((Control)txtNumarSerialToken).set_Name("txtNumarSerialToken");
		((Control)txtNumarSerialToken).set_Size(new Size(409, 20));
		((Control)txtNumarSerialToken).set_TabIndex(13);
		((Control)lblNumarSerialToken).set_AutoSize(true);
		((Control)lblNumarSerialToken).set_Font(new Font("Microsoft Sans Serif", 8.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)lblNumarSerialToken).set_Location(new Point(5, 101));
		((Control)lblNumarSerialToken).set_Name("lblNumarSerialToken");
		((Control)lblNumarSerialToken).set_Size(new Size(117, 13));
		((Control)lblNumarSerialToken).set_TabIndex(12);
		((Control)lblNumarSerialToken).set_Text("Numar serial token:");
		((Control)lblPort).set_AutoSize(true);
		((Control)lblPort).set_Font(new Font("Microsoft Sans Serif", 8.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)lblPort).set_Location(new Point(204, 236));
		((Control)lblPort).set_Name("lblPort");
		((Control)lblPort).set_Size(new Size(34, 13));
		((Control)lblPort).set_TabIndex(15);
		((Control)lblPort).set_Text("Port:");
		txtPort.set_CutCopyMaskFormat((MaskFormat)0);
		((Control)txtPort).set_Location(new Point(240, 236));
		txtPort.set_Mask("00000");
		((Control)txtPort).set_Name("txtPort");
		((Control)txtPort).set_Size(new Size(71, 20));
		((Control)txtPort).set_TabIndex(16);
		txtPort.set_ValidatingType(typeof(int));
		((Control)chkVersiuneTest).set_AutoSize(true);
		((Control)chkVersiuneTest).set_Enabled(false);
		((Control)chkVersiuneTest).set_Font(new Font("Microsoft Sans Serif", 8.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)chkVersiuneTest).set_Location(new Point(13, 259));
		((Control)chkVersiuneTest).set_Name("chkVersiuneTest");
		((Control)chkVersiuneTest).set_Size(new Size(104, 17));
		((Control)chkVersiuneTest).set_TabIndex(17);
		((Control)chkVersiuneTest).set_Text("Versiune Test");
		((ButtonBase)chkVersiuneTest).set_UseVisualStyleBackColor(true);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_CancelButton((IButtonControl)(object)btnCancel);
		((Form)this).set_ClientSize(new Size(422, 311));
		((Control)this).get_Controls().Add((Control)(object)chkVersiuneTest);
		((Control)this).get_Controls().Add((Control)(object)txtPort);
		((Control)this).get_Controls().Add((Control)(object)lblPort);
		((Control)this).get_Controls().Add((Control)(object)txtNumarSerialToken);
		((Control)this).get_Controls().Add((Control)(object)lblNumarSerialToken);
		((Control)this).get_Controls().Add((Control)(object)chkSemnareFisierRaportare);
		((Control)this).get_Controls().Add((Control)(object)btnChoseFolder);
		((Control)this).get_Controls().Add((Control)(object)txtLicentaSIUI);
		((Control)this).get_Controls().Add((Control)(object)lblLicentaSIUI);
		((Control)this).get_Controls().Add((Control)(object)txtUserInregistrareCasa);
		((Control)this).get_Controls().Add((Control)(object)lblUserInregistrareCasa);
		((Control)this).get_Controls().Add((Control)(object)txtUserToken);
		((Control)this).get_Controls().Add((Control)(object)lblUserTalken);
		((Control)this).get_Controls().Add((Control)(object)txtCaleComunicatie);
		((Control)this).get_Controls().Add((Control)(object)lblCaleComunicatie);
		((Control)this).get_Controls().Add((Control)(object)btnCancel);
		((Control)this).get_Controls().Add((Control)(object)btnOk);
		((Form)this).set_FormBorderStyle((FormBorderStyle)1);
		((Form)this).set_Icon((Icon)componentResourceManager.GetObject("$this.Icon"));
		((Form)this).set_MaximizeBox(false);
		((Form)this).set_MinimizeBox(false);
		((Control)this).set_Name("frmConfigurare");
		((Form)this).set_StartPosition((FormStartPosition)4);
		((Control)this).set_Text("Configurare");
		((Form)this).add_Load((EventHandler)frmConfigurare_Load);
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	private void btnOk_Click(object sender, EventArgs e)
	{
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0094: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cd: Unknown result type (might be due to invalid IL or missing references)
		if (((Control)txtCaleComunicatie).get_Text().Trim().Length == 0)
		{
			MessageBox.Show("Completati campul cale comunicatie");
			((Control)txtCaleComunicatie).Focus();
			return;
		}
		if (((Control)txtUserToken).get_Text().Trim().Length == 0)
		{
			MessageBox.Show("Completati campul User token");
			((Control)txtUserToken).Focus();
			return;
		}
		if (((Control)txtUserInregistrareCasa).get_Text().Trim().Length == 0)
		{
			MessageBox.Show("Completati campul User inregistrare casa");
			((Control)txtUserInregistrareCasa).Focus();
			return;
		}
		if (((Control)txtLicentaSIUI).get_Text().Trim().Length == 0)
		{
			MessageBox.Show("Completati campul Licenta SIUI");
			((Control)txtLicentaSIUI).Focus();
			return;
		}
		((Control)txtNumarSerialToken).set_Text(((Control)txtNumarSerialToken).get_Text().Replace(" ", string.Empty));
		((Control)txtNumarSerialToken).set_Text(Class1.smethod_1(((Control)txtNumarSerialToken).get_Text()));
		bool flag = false;
		XmlDocument xmlDocument = new XmlDocument();
		xmlDocument.Load(AppDomain.CurrentDomain.SetupInformation.get_ConfigurationFile());
		XmlNode xmlNode = xmlDocument.SelectSingleNode("configuration/appSettings");
		foreach (XmlNode childNode in xmlNode.ChildNodes)
		{
			if (childNode.OuterXml.IndexOf("key=\"") <= -1)
			{
				continue;
			}
			switch (childNode.Attributes!["key"]!.Value.ToUpper())
			{
			case "CALE COMUNICATIE":
				if (childNode.Attributes!["value"]!.Value != ((Control)txtCaleComunicatie).get_Text().Trim())
				{
					childNode.Attributes!["value"]!.Value = ((Control)txtCaleComunicatie).get_Text().Trim();
					flag = true;
				}
				break;
			case "USER TOKEN":
				if (childNode.Attributes!["value"]!.Value != ((Control)txtUserToken).get_Text().Trim())
				{
					childNode.Attributes!["value"]!.Value = ((Control)txtUserToken).get_Text().Trim();
					flag = true;
				}
				break;
			case "NUMAR SERIAL TOKEN":
				if (childNode.Attributes!["value"]!.Value != ((Control)txtNumarSerialToken).get_Text().Trim())
				{
					childNode.Attributes!["value"]!.Value = ((Control)txtNumarSerialToken).get_Text().Trim();
					flag = true;
				}
				break;
			case "USER INREGISTRARE CASA":
				if (childNode.Attributes!["value"]!.Value != ((Control)txtUserInregistrareCasa).get_Text().Trim())
				{
					childNode.Attributes!["value"]!.Value = ((Control)txtUserInregistrareCasa).get_Text().Trim();
					flag = true;
				}
				break;
			case "LICENTA SIUI":
				if (childNode.Attributes!["value"]!.Value != ((Control)txtLicentaSIUI).get_Text().Trim())
				{
					childNode.Attributes!["value"]!.Value = ((Control)txtLicentaSIUI).get_Text().Trim();
					flag = true;
				}
				break;
			case "SEMNARE FISIER RAPORTARE":
				if (childNode.Attributes!["value"]!.Value != chkSemnareFisierRaportare.get_Checked().ToString())
				{
					childNode.Attributes!["value"]!.Value = chkSemnareFisierRaportare.get_Checked().ToString();
					flag = true;
				}
				break;
			case "PORT":
				if (childNode.Attributes!["value"]!.Value != ((Control)txtPort).get_Text().Trim())
				{
					childNode.Attributes!["value"]!.Value = ((Control)txtPort).get_Text().Trim();
					flag = true;
				}
				break;
			case "VERSIUNE TEST":
				if (childNode.Attributes!["value"]!.Value != chkVersiuneTest.get_Checked().ToString())
				{
					childNode.Attributes!["value"]!.Value = chkVersiuneTest.get_Checked().ToString();
					flag = true;
				}
				break;
			}
		}
		if (flag)
		{
			ConfigurationSettings.get_AppSettings()["Cale comunicatie"] = ((Control)txtCaleComunicatie).get_Text();
		}
		ConfigurationSettings.get_AppSettings()["User Token"] = ((Control)txtUserToken).get_Text();
		ConfigurationSettings.get_AppSettings()["User Inregistrare Casa"] = ((Control)txtUserInregistrareCasa).get_Text();
		ConfigurationSettings.get_AppSettings()["Licenta SIUI"] = ((Control)txtLicentaSIUI).get_Text();
		ConfigurationSettings.get_AppSettings()["Semnare fisier raportare"] = chkSemnareFisierRaportare.get_Checked().ToString();
		ConfigurationSettings.get_AppSettings()["Numar Serial Token"] = ((Control)txtNumarSerialToken).get_Text().Trim();
		ConfigurationSettings.get_AppSettings()["Port"] = ((Control)txtPort).get_Text().Trim();
		ConfigurationSettings.get_AppSettings()["Versiune Test"] = chkVersiuneTest.get_Checked().ToString();
		xmlDocument.Save(AppDomain.CurrentDomain.SetupInformation.get_ConfigurationFile());
		((Form)this).set_DialogResult((DialogResult)1);
	}

	private void frmConfigurare_Load(object sender, EventArgs e)
	{
		//IL_00f6: Unknown result type (might be due to invalid IL or missing references)
		method_0("Semnare fisier raportare", "false");
		method_0("Numar Serial Token", "");
		method_0("Port", "");
		method_0("Versiune Test", "false");
		((Control)txtCaleComunicatie).set_Text(ConfigurationSettings.get_AppSettings()["Cale comunicatie"]);
		((Control)txtUserToken).set_Text(ConfigurationSettings.get_AppSettings()["User Token"]);
		((Control)txtUserInregistrareCasa).set_Text(ConfigurationSettings.get_AppSettings()["User Inregistrare Casa"]);
		((Control)txtLicentaSIUI).set_Text(ConfigurationSettings.get_AppSettings()["Licenta SIUI"]);
		((Control)txtNumarSerialToken).set_Text(ConfigurationSettings.get_AppSettings()["Numar Serial Token"]);
		((Control)txtPort).set_Text(ConfigurationSettings.get_AppSettings()["Port"]);
		if (!bool_0)
		{
			((Form)this).set_Icon(Icon.FromHandle(((Bitmap)imageList_0.get_Images().get_Item(1)).GetHicon()));
		}
		if (ConfigurationSettings.get_AppSettings()["Semnare fisier raportare"] != null && Enum.GetNames(typeof(TrueFalse)).Contains(ConfigurationSettings.get_AppSettings()["Semnare fisier raportare"]!.ToString().ToUpper()))
		{
			chkSemnareFisierRaportare.set_Checked(Convert.ToBoolean(ConfigurationSettings.get_AppSettings()["Semnare fisier raportare"]));
		}
		if (ConfigurationSettings.get_AppSettings()["Versiune Test"] != null && Enum.GetNames(typeof(TrueFalse)).Contains(ConfigurationSettings.get_AppSettings()["Versiune Test"]!.ToString().ToUpper()))
		{
			chkVersiuneTest.set_Checked(Convert.ToBoolean(ConfigurationSettings.get_AppSettings()["Versiune Test"]));
		}
	}

	private void btnCancel_Click(object sender, EventArgs e)
	{
		((Form)this).set_DialogResult((DialogResult)2);
	}

	private void btnChoseFolder_Click(object sender, EventArgs e)
	{
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_0056: Invalid comparison between Unknown and I4
		if (((Control)txtCaleComunicatie).get_Text().Trim() != "")
		{
			folderBrowserDialog_0.set_SelectedPath(((Control)txtCaleComunicatie).get_Text().Trim());
		}
		folderBrowserDialog_0.set_Description("Selectati calea de comunicatie");
		if ((int)((CommonDialog)folderBrowserDialog_0).ShowDialog() == 1)
		{
			((Control)txtCaleComunicatie).set_Text(folderBrowserDialog_0.get_SelectedPath());
		}
	}

	private void method_0(string string_0, string string_1)
	{
		bool flag = false;
		XmlDocument xmlDocument = new XmlDocument();
		xmlDocument.Load(AppDomain.CurrentDomain.SetupInformation.get_ConfigurationFile());
		XmlNode xmlNode = xmlDocument.SelectSingleNode("configuration/appSettings");
		foreach (XmlNode childNode in xmlNode.ChildNodes)
		{
			if (childNode.Attributes!["key"]!.Value.ToUpper() == string_0.ToUpper())
			{
				flag = true;
			}
		}
		if (!flag)
		{
			XmlNode xmlNode3 = xmlDocument.CreateElement("add");
			XmlAttribute xmlAttribute = xmlDocument.CreateAttribute("value");
			XmlAttribute xmlAttribute2 = xmlDocument.CreateAttribute("key");
			xmlAttribute.Value = string_1;
			xmlAttribute2.Value = string_0;
			xmlNode3.Attributes!.Append(xmlAttribute2);
			xmlNode3.Attributes!.Append(xmlAttribute);
			xmlNode.AppendChild(xmlNode3);
			xmlDocument.Save(AppDomain.CurrentDomain.SetupInformation.get_ConfigurationFile());
		}
	}

	private void chkSemnareFisierRaportare_CheckedChanged(object sender, EventArgs e)
	{
	}
}
