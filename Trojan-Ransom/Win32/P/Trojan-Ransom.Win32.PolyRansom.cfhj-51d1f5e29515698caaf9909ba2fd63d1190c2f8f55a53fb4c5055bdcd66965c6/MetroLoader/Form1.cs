using System;
using System.ComponentModel;
using System.Configuration;
using System.Drawing;
using System.Windows.Forms;
using HWIDGrabber;
using MetroFramework;
using MetroFramework.Controls;
using MetroFramework.Forms;
using MetroLoader.Properties;

namespace MetroLoader;

public class Form1 : MetroForm
{
	private bool username;

	private bool usergroup;

	private bool hwid;

	private string hwidstring;

	private bool admin;

	private bool premium;

	private IContainer components = null;

	private MetroTabControl metroTabControl1;

	private MetroTabPage metroTabPage1;

	private WebBrowser webBrowser1;

	private MetroTextBox metroTextBox2;

	private MetroTextBox metroTextBox1;

	private MetroCheckBox metroCheckBox1;

	private MetroButton metroButton1;

	private WebBrowser webBrowser2;

	private WebBrowser webBrowser3;

	private WebBrowser webBrowser4;

	private WebBrowser webBrowser5;

	private PictureBox pictureBox26;

	private PictureBox pictureBox1;

	public Form1()
	{
		InitializeComponent();
	}

	private void Form1_Load(object sender, EventArgs e)
	{
		hwidstring = HWDI.GetMachineGuid();
		((Control)metroTextBox1).set_Text(MetroLoader.Properties.Settings.Default.Username);
		((Control)metroTextBox2).set_Text(MetroLoader.Properties.Settings.Default.Password);
	}

	private void metroButton1_Click(object sender, EventArgs e)
	{
		webBrowser1.Navigate(Settings.host + "check.php?username=" + ((Control)metroTextBox1).get_Text() + "&password=" + ((Control)metroTextBox2).get_Text());
		username = true;
		MetroLoader.Properties.Settings.Default.Username = ((Control)metroTextBox1).get_Text();
		MetroLoader.Properties.Settings.Default.Password = ((Control)metroTextBox2).get_Text();
		MetroLoader.Properties.Settings.Default.Checked = ((CheckBox)metroCheckBox1).get_Checked();
		((SettingsBase)MetroLoader.Properties.Settings.Default).Save();
	}

	private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
	{
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a5: Unknown result type (might be due to invalid IL or missing references)
		if (username)
		{
			if (webBrowser1.get_DocumentText().Contains("0"))
			{
				username = false;
				MessageBox.Show("Parola Hatalı");
			}
			else if (webBrowser1.get_DocumentText().Contains("1"))
			{
				usergroup = true;
				username = false;
				webBrowser2.Navigate(Settings.host + "group.php?username=" + ((Control)metroTextBox1).get_Text());
			}
			else if (webBrowser2.get_DocumentText().Contains("2"))
			{
				username = false;
				MessageBox.Show("Bu Kullanıcı Adı Kayıtlı Değil");
			}
		}
	}

	private void webBrowser2_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
	{
		//IL_00db: Unknown result type (might be due to invalid IL or missing references)
		if (usergroup)
		{
			if (webBrowser2.get_DocumentText().Contains("4") || webBrowser2.get_DocumentText().Contains("8") || webBrowser2.get_DocumentText().Contains("9") || webBrowser2.get_DocumentText().Contains("2") || webBrowser2.get_DocumentText().Contains("6"))
			{
				usergroup = false;
				hwid = true;
				webBrowser3.Navigate(Settings.host + "hwid.php?username=" + ((Control)metroTextBox1).get_Text() + "&hwid=" + hwidstring);
			}
			else
			{
				MessageBox.Show("Yetkiniz Yok");
				usergroup = false;
			}
		}
	}

	private void webBrowser3_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
	{
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_009a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0118: Unknown result type (might be due to invalid IL or missing references)
		//IL_011d: Unknown result type (might be due to invalid IL or missing references)
		//IL_011f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0122: Invalid comparison between Unknown and I4
		//IL_0133: Unknown result type (might be due to invalid IL or missing references)
		//IL_0136: Invalid comparison between Unknown and I4
		//IL_0186: Unknown result type (might be due to invalid IL or missing references)
		if (!hwid)
		{
			return;
		}
		if (webBrowser3.get_DocumentText().Contains("0"))
		{
			MessageBox.Show("HWID Uyuşmuyor");
			hwid = false;
			Application.Exit();
		}
		else if (webBrowser3.get_DocumentText().Contains("1"))
		{
			((Control)this).Hide();
			Form4 form = new Form4();
			((Form)form).add_Closed((EventHandler)delegate
			{
				((Form)this).Close();
			});
			((Control)form).Show();
		}
		else if (webBrowser3.get_DocumentText().Contains("2"))
		{
			MessageBox.Show("HWID Bulunamadı ?");
			hwid = false;
		}
		else if (webBrowser3.get_DocumentText().Contains("3"))
		{
			DialogResult val = MessageBox.Show("HWID Kilitlendi!" + Environment.NewLine + "HWID: " + hwidstring + Environment.NewLine + "Değiştirmen Için Lazım Olucak!" + Environment.NewLine + "Kopyalamak için 'evet' tuşuna bas.", "HWID Kitlendi", (MessageBoxButtons)4);
			if ((int)val == 6)
			{
				Clipboard.SetText(hwidstring);
			}
			else if ((int)val == 7)
			{
			}
			hwid = false;
			((Control)this).Hide();
			Form4 form2 = new Form4();
			((Form)form2).add_Closed((EventHandler)delegate
			{
				((Form)this).Close();
			});
			((Control)form2).Show();
		}
		else if (webBrowser3.get_DocumentText().Contains("4"))
		{
			MessageBox.Show("SQL datasında hata var (HWID)");
			hwid = false;
		}
	}

	private void webBrowser4_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
	{
	}

	private void metroTabPage1_Click(object sender, EventArgs e)
	{
	}

	private void webBrowser5_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
	{
		if (webBrowser5.get_DocumentText().Contains("4"))
		{
			admin = true;
			((Control)metroButton1).set_Enabled(true);
		}
		else if (webBrowser5.get_DocumentText().Contains("8"))
		{
			premium = true;
			((Control)metroButton1).set_Enabled(true);
		}
		else if (webBrowser5.get_DocumentText().Contains("2"))
		{
			premium = true;
			((Control)metroButton1).set_Enabled(true);
		}
		else if (webBrowser5.get_DocumentText().Contains("9"))
		{
			admin = true;
			((Control)metroButton1).set_Enabled(true);
		}
		else if (webBrowser5.get_DocumentText().Contains("6"))
		{
			premium = true;
		}
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
		//IL_043b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0445: Expected O, but got Unknown
		//IL_0614: Unknown result type (might be due to invalid IL or missing references)
		//IL_061e: Expected O, but got Unknown
		//IL_0790: Unknown result type (might be due to invalid IL or missing references)
		//IL_079a: Expected O, but got Unknown
		//IL_0808: Unknown result type (might be due to invalid IL or missing references)
		//IL_0812: Expected O, but got Unknown
		//IL_0880: Unknown result type (might be due to invalid IL or missing references)
		//IL_088a: Expected O, but got Unknown
		//IL_08f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0902: Expected O, but got Unknown
		//IL_0b16: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b20: Expected O, but got Unknown
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(Form1));
		metroTabControl1 = new MetroTabControl();
		metroTabPage1 = new MetroTabPage();
		metroTextBox2 = new MetroTextBox();
		metroTextBox1 = new MetroTextBox();
		metroButton1 = new MetroButton();
		metroCheckBox1 = new MetroCheckBox();
		webBrowser1 = new WebBrowser();
		webBrowser2 = new WebBrowser();
		webBrowser3 = new WebBrowser();
		webBrowser4 = new WebBrowser();
		webBrowser5 = new WebBrowser();
		pictureBox26 = new PictureBox();
		pictureBox1 = new PictureBox();
		((Control)metroTabControl1).SuspendLayout();
		((Control)metroTabPage1).SuspendLayout();
		((ISupportInitialize)pictureBox26).BeginInit();
		((ISupportInitialize)pictureBox1).BeginInit();
		((Control)this).SuspendLayout();
		((Control)metroTabControl1).get_Controls().Add((Control)(object)metroTabPage1);
		((Control)metroTabControl1).set_Location(new Point(57, 53));
		((Control)metroTabControl1).set_Name("metroTabControl1");
		((TabControl)metroTabControl1).set_SelectedIndex(0);
		((Control)metroTabControl1).set_Size(new Size(309, 138));
		metroTabControl1.set_Style((MetroColorStyle)13);
		((Control)metroTabControl1).set_TabIndex(0);
		metroTabControl1.set_Theme((MetroThemeStyle)1);
		metroTabControl1.set_UseSelectable(true);
		((Control)metroTabPage1).get_Controls().Add((Control)(object)metroTextBox2);
		((Control)metroTabPage1).get_Controls().Add((Control)(object)metroTextBox1);
		((Control)metroTabPage1).get_Controls().Add((Control)(object)metroButton1);
		metroTabPage1.set_HorizontalScrollbarBarColor(true);
		metroTabPage1.set_HorizontalScrollbarHighlightOnWheel(false);
		metroTabPage1.set_HorizontalScrollbarSize(10);
		((TabPage)metroTabPage1).set_Location(new Point(4, 38));
		((Control)metroTabPage1).set_Name("metroTabPage1");
		((Control)metroTabPage1).set_Size(new Size(301, 96));
		((TabPage)metroTabPage1).set_TabIndex(0);
		((Control)metroTabPage1).set_Text("                                                                        ");
		metroTabPage1.set_Theme((MetroThemeStyle)1);
		metroTabPage1.set_VerticalScrollbarBarColor(true);
		metroTabPage1.set_VerticalScrollbarHighlightOnWheel(false);
		metroTabPage1.set_VerticalScrollbarSize(10);
		((Control)metroTabPage1).add_Click((EventHandler)metroTabPage1_Click);
		metroTextBox2.get_CustomButton().set_Image((Image)null);
		((Control)metroTextBox2.get_CustomButton()).set_Location(new Point(158, 1));
		((Control)metroTextBox2.get_CustomButton()).set_Name("");
		((Control)metroTextBox2.get_CustomButton()).set_Size(new Size(21, 21));
		metroTextBox2.get_CustomButton().set_Style((MetroColorStyle)4);
		((Control)metroTextBox2.get_CustomButton()).set_TabIndex(1);
		metroTextBox2.get_CustomButton().set_Theme((MetroThemeStyle)1);
		metroTextBox2.get_CustomButton().set_UseSelectable(true);
		((Control)metroTextBox2.get_CustomButton()).set_Visible(false);
		metroTextBox2.set_Lines(new string[0]);
		((Control)metroTextBox2).set_Location(new Point(58, 37));
		metroTextBox2.set_MaxLength(32767);
		((Control)metroTextBox2).set_Name("metroTextBox2");
		metroTextBox2.set_PasswordChar('●');
		metroTextBox2.set_PromptText("Parola");
		metroTextBox2.set_ScrollBars((ScrollBars)0);
		metroTextBox2.set_SelectedText("");
		metroTextBox2.set_SelectionLength(0);
		metroTextBox2.set_SelectionStart(0);
		metroTextBox2.set_ShortcutsEnabled(true);
		((Control)metroTextBox2).set_Size(new Size(180, 23));
		metroTextBox2.set_Style((MetroColorStyle)12);
		((Control)metroTextBox2).set_TabIndex(5);
		metroTextBox2.set_Theme((MetroThemeStyle)1);
		metroTextBox2.set_UseSelectable(true);
		metroTextBox2.set_WaterMark("Parola");
		metroTextBox2.set_WaterMarkColor(Color.FromArgb(109, 109, 109));
		metroTextBox2.set_WaterMarkFont(new Font("Segoe UI", 12f, (FontStyle)2, (GraphicsUnit)2));
		metroTextBox1.get_CustomButton().set_Image((Image)null);
		((Control)metroTextBox1.get_CustomButton()).set_Location(new Point(158, 1));
		((Control)metroTextBox1.get_CustomButton()).set_Name("");
		((Control)metroTextBox1.get_CustomButton()).set_Size(new Size(21, 21));
		metroTextBox1.get_CustomButton().set_Style((MetroColorStyle)4);
		((Control)metroTextBox1.get_CustomButton()).set_TabIndex(1);
		metroTextBox1.get_CustomButton().set_Theme((MetroThemeStyle)1);
		metroTextBox1.get_CustomButton().set_UseSelectable(true);
		((Control)metroTextBox1.get_CustomButton()).set_Visible(false);
		metroTextBox1.set_Lines(new string[0]);
		((Control)metroTextBox1).set_Location(new Point(58, 8));
		metroTextBox1.set_MaxLength(32767);
		((Control)metroTextBox1).set_Name("metroTextBox1");
		metroTextBox1.set_PasswordChar('\0');
		metroTextBox1.set_PromptText("Kullanıcı Adı");
		metroTextBox1.set_ScrollBars((ScrollBars)0);
		metroTextBox1.set_SelectedText("");
		metroTextBox1.set_SelectionLength(0);
		metroTextBox1.set_SelectionStart(0);
		metroTextBox1.set_ShortcutsEnabled(true);
		((Control)metroTextBox1).set_Size(new Size(180, 23));
		metroTextBox1.set_Style((MetroColorStyle)12);
		((Control)metroTextBox1).set_TabIndex(4);
		metroTextBox1.set_Theme((MetroThemeStyle)1);
		metroTextBox1.set_UseSelectable(true);
		metroTextBox1.set_WaterMark("Kullanıcı Adı");
		metroTextBox1.set_WaterMarkColor(Color.FromArgb(109, 109, 109));
		metroTextBox1.set_WaterMarkFont(new Font("Segoe UI", 12f, (FontStyle)2, (GraphicsUnit)2));
		((Control)metroButton1).set_Location(new Point(3, 66));
		((Control)metroButton1).set_Name("metroButton1");
		((Control)metroButton1).set_Size(new Size(295, 19));
		metroButton1.set_Style((MetroColorStyle)5);
		((Control)metroButton1).set_TabIndex(2);
		((Control)metroButton1).set_Text("Giriş");
		metroButton1.set_Theme((MetroThemeStyle)1);
		metroButton1.set_UseSelectable(true);
		((Control)metroButton1).add_Click((EventHandler)metroButton1_Click);
		((Control)metroCheckBox1).set_AutoSize(true);
		((Control)metroCheckBox1).set_Location(new Point(-62, 220));
		((Control)metroCheckBox1).set_Name("metroCheckBox1");
		((Control)metroCheckBox1).set_Size(new Size(16, 0));
		metroCheckBox1.set_Style((MetroColorStyle)5);
		((Control)metroCheckBox1).set_TabIndex(3);
		metroCheckBox1.set_Theme((MetroThemeStyle)2);
		metroCheckBox1.set_UseSelectable(true);
		((Control)webBrowser1).set_Location(new Point(531, 63));
		((Control)webBrowser1).set_MinimumSize(new Size(20, 20));
		((Control)webBrowser1).set_Name("webBrowser1");
		((Control)webBrowser1).set_Size(new Size(390, 119));
		((Control)webBrowser1).set_TabIndex(1);
		webBrowser1.add_DocumentCompleted(new WebBrowserDocumentCompletedEventHandler(webBrowser1_DocumentCompleted));
		((Control)webBrowser2).set_Location(new Point(531, 188));
		((Control)webBrowser2).set_MinimumSize(new Size(20, 20));
		((Control)webBrowser2).set_Name("webBrowser2");
		((Control)webBrowser2).set_Size(new Size(390, 119));
		((Control)webBrowser2).set_TabIndex(2);
		webBrowser2.add_DocumentCompleted(new WebBrowserDocumentCompletedEventHandler(webBrowser2_DocumentCompleted));
		((Control)webBrowser3).set_Location(new Point(531, 313));
		((Control)webBrowser3).set_MinimumSize(new Size(20, 20));
		((Control)webBrowser3).set_Name("webBrowser3");
		((Control)webBrowser3).set_Size(new Size(390, 119));
		((Control)webBrowser3).set_TabIndex(3);
		webBrowser3.add_DocumentCompleted(new WebBrowserDocumentCompletedEventHandler(webBrowser3_DocumentCompleted));
		((Control)webBrowser4).set_Location(new Point(531, 438));
		((Control)webBrowser4).set_MinimumSize(new Size(20, 20));
		((Control)webBrowser4).set_Name("webBrowser4");
		((Control)webBrowser4).set_Size(new Size(390, 119));
		((Control)webBrowser4).set_TabIndex(4);
		webBrowser4.add_DocumentCompleted(new WebBrowserDocumentCompletedEventHandler(webBrowser4_DocumentCompleted));
		((Control)webBrowser5).set_Location(new Point(27, 219));
		((Control)webBrowser5).set_MinimumSize(new Size(20, 20));
		((Control)webBrowser5).set_Name("webBrowser5");
		((Control)webBrowser5).set_Size(new Size(390, 119));
		((Control)webBrowser5).set_TabIndex(5);
		pictureBox26.set_Image((Image)(object)Resources.logo);
		((Control)pictureBox26).set_Location(new Point(303, 8));
		((Control)pictureBox26).set_Name("pictureBox26");
		((Control)pictureBox26).set_Size(new Size(75, 64));
		pictureBox26.set_SizeMode((PictureBoxSizeMode)4);
		pictureBox26.set_TabIndex(6);
		pictureBox26.set_TabStop(false);
		pictureBox1.set_Image((Image)(object)Resources.logo);
		((Control)pictureBox1).set_Location(new Point(45, 8));
		((Control)pictureBox1).set_Name("pictureBox1");
		((Control)pictureBox1).set_Size(new Size(75, 64));
		pictureBox1.set_SizeMode((PictureBoxSizeMode)4);
		pictureBox1.set_TabIndex(7);
		pictureBox1.set_TabStop(false);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((MetroForm)this).set_BorderStyle((MetroFormBorderStyle)1);
		((Form)this).set_ClientSize(new Size(429, 224));
		((Control)this).get_Controls().Add((Control)(object)pictureBox1);
		((Control)this).get_Controls().Add((Control)(object)pictureBox26);
		((Control)this).get_Controls().Add((Control)(object)webBrowser5);
		((Control)this).get_Controls().Add((Control)(object)webBrowser4);
		((Control)this).get_Controls().Add((Control)(object)webBrowser3);
		((Control)this).get_Controls().Add((Control)(object)webBrowser2);
		((Control)this).get_Controls().Add((Control)(object)webBrowser1);
		((Control)this).get_Controls().Add((Control)(object)metroCheckBox1);
		((Control)this).get_Controls().Add((Control)(object)metroTabControl1);
		((Form)this).set_Icon((Icon)componentResourceManager.GetObject("$this.Icon"));
		((Form)this).set_MaximizeBox(false);
		((Control)this).set_Name("Form1");
		((MetroForm)this).set_Resizable(false);
		((MetroForm)this).set_ShadowType((MetroFormShadowType)4);
		((MetroForm)this).set_Style((MetroColorStyle)13);
		((Control)this).set_Text("ROOT by patbob");
		((MetroForm)this).set_TextAlign((MetroFormTextAlign)1);
		((Form)this).add_Load((EventHandler)Form1_Load);
		((Control)metroTabControl1).ResumeLayout(false);
		((Control)metroTabPage1).ResumeLayout(false);
		((ISupportInitialize)pictureBox26).EndInit();
		((ISupportInitialize)pictureBox1).EndInit();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}
}
