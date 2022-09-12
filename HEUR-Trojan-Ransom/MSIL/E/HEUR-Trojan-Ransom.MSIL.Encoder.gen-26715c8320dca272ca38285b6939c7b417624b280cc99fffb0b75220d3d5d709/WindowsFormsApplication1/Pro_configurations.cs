using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using MetroFramework;
using MetroFramework.Controls;
using SEO_BB.Harvester;

namespace WindowsFormsApplication1;

public class Pro_configurations : UserControl
{
	private IContainer components = null;

	private MetroLabel label45;

	public MetroCheckBox browser_checkBox1;

	public MetroCheckBox delay_protection_checkBox1;

	public MetroCheckBox Throttle_checkBox1;

	private MetroLabel label33;

	private MetroTextBox textBox1;

	public MetroTextBox catcha_2_username;

	public MetroTextBox captcha_2_password_textbox;

	public MetroTextBox captcha_api2_textbox;

	public MetroLabel captcha_solved_label;

	public MetroLabel captcha_balence;

	private MetroLabel label32;

	private MetroLabel label31;

	private MetroLabel label30;

	private MetroButton _2captcha_configure;

	private MetroLabel metroLabel1;

	public MetroCheckBox poshmark_checkbox;

	private MetroLabel get_license_metroLabel2;

	public MetroCheckBox canadian_closet_metroCheckBox1;

	public MetroCheckBox fetch_all_listings_metroCheckBox1;

	public MetroCheckBox save_login_metroCheckBox1;

	public Pro_configurations()
	{
		InitializeComponent();
	}

	private void _2captcha_configure_Click(object sender, EventArgs e)
	{
		//IL_0182: Unknown result type (might be due to invalid IL or missing references)
		//IL_019c: Unknown result type (might be due to invalid IL or missing references)
		//IL_01af: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fc: Unknown result type (might be due to invalid IL or missing references)
		File.WriteAllText(update_app.folder_path + "\\Captcha_data.txt", ((Control)captcha_api2_textbox).get_Text() + "\r\n" + ((Control)catcha_2_username).get_Text() + "\r\n" + ((Control)captcha_2_password_textbox).get_Text());
		try
		{
			List<string> list = File.ReadAllLines(update_app.folder_path + "\\Captcha_data.txt").ToList();
			((Control)captcha_2_password_textbox).set_Text(list[2]);
			((Control)captcha_api2_textbox).set_Text(list[0]);
			((Control)catcha_2_username).set_Text(list[1]);
			if (!(((Control)captcha_2_password_textbox).get_Text() != "") || !(((Control)captcha_api2_textbox).get_Text() != "") || !(((Control)catcha_2_username).get_Text() != ""))
			{
				return;
			}
			Form1._2captcha_key = ((Control)captcha_api2_textbox).get_Text();
			Form1._2captcha_password = ((Control)captcha_2_password_textbox).get_Text();
			C2CaptchaService c2CaptchaService = new C2CaptchaService(Form1._2captcha_key, Form1._2captcha_password);
			string text = c2CaptchaService.GetBalance().ToString();
			if (text == "-1")
			{
				File.WriteAllText(update_app.folder_path + "\\Captcha_data.txt", "\r\n\r\n\r\n\r\n\r\n\r\n");
				Form1._2captcha_key = "";
				Form1._2captcha_password = "";
				((Control)captcha_balence).set_Text("2Captcha Not Configured");
				MessageBox.Show("Cannot able to autheticate 2captcha, check again");
			}
			else
			{
				if (text == "0.0")
				{
					MessageBox.Show("You 2Captcha balence is 0");
				}
				else
				{
					MessageBox.Show("Your Total balence of captcha is " + text);
				}
				((Control)captcha_balence).set_Text("2Captcha Balence: " + text + " (Configured Successfully)");
			}
		}
		catch
		{
			Form1._2captcha_key = "";
			Form1._2captcha_password = "";
			((Control)captcha_balence).set_Text("2Captcha: (Not Configured)");
			MessageBox.Show("your captcha service has been removed successfully");
		}
	}

	private void browser_checkBox1_CheckedChanged(object sender, EventArgs e)
	{
		string text = "0";
		if (((CheckBox)browser_checkBox1).get_Checked())
		{
			text = "1";
		}
		if (!File.Exists(update_app.folder_path + "//browser.ck"))
		{
			File.WriteAllText(update_app.folder_path + "//browser.ck", text);
			Process.Start(Directory.GetCurrentDirectory() + "\\Poshmark_tools.exe");
			Environment.Exit(1);
		}
		string text2 = File.ReadAllText(update_app.folder_path + "//browser.ck");
		if (!(text2 == text))
		{
			File.WriteAllText(update_app.folder_path + "//browser.ck", text);
			try
			{
				Process.Start(Directory.GetCurrentDirectory() + "\\Poshmark_tools.exe");
				Environment.Exit(1);
			}
			catch
			{
			}
		}
	}

	private void label33_Click(object sender, EventArgs e)
	{
		Process.Start("https://2captcha.com?from=5020607");
	}

	private void metroLabel1_Click(object sender, EventArgs e)
	{
		Process.Start("http://bit.ly/2KqADHR");
	}

	private void get_license_metroLabel2_Click(object sender, EventArgs e)
	{
		Process.Start("http://poshmarktools.com/pricing");
	}

	private void canadian_closet_metroCheckBox1_CheckedChanged(object sender, EventArgs e)
	{
		try
		{
			if (((CheckBox)Form1.pro_configuration_class.canadian_closet_metroCheckBox1).get_Checked())
			{
				if (!Form1.pro_browser.canadian_closet_CheckBox1.get_Checked())
				{
					Form1.pro_browser.canadian_closet_CheckBox1.set_Checked(true);
				}
			}
			else if (Form1.pro_browser.canadian_closet_CheckBox1.get_Checked())
			{
				Form1.pro_browser.canadian_closet_CheckBox1.set_Checked(false);
			}
			if (((CheckBox)Form1.pro_configuration_class.browser_checkBox1).get_Checked())
			{
				if (((CheckBox)Form1.pro_configuration_class.canadian_closet_metroCheckBox1).get_Checked())
				{
					Form1.eob.get_WebView().set_Url("https://poshmark.ca/login");
				}
				else
				{
					Form1.eob.get_WebView().set_Url("https://poshmark.com/login");
				}
			}
			else if (((CheckBox)Form1.pro_configuration_class.canadian_closet_metroCheckBox1).get_Checked())
			{
				Form1.brower_webbrowser_2.Navigate("https://poshmark.ca/login");
			}
			else
			{
				Form1.brower_webbrowser_2.Navigate("https://poshmark.com/login");
			}
		}
		catch
		{
		}
	}

	private void fetch_all_listings_metroCheckBox1_CheckedChanged(object sender, EventArgs e)
	{
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		Control val = (Control)((sender is Control) ? sender : null);
		if (val is CheckBox)
		{
			if (((CheckBox)val).get_Checked())
			{
				Form1.update_backup_data(((object)this).GetType().Name + "______;" + ((Control)(CheckBox)val).get_Name(), "T");
			}
			else
			{
				Form1.update_backup_data(((object)this).GetType().Name + "______;" + ((Control)(CheckBox)val).get_Name(), "F");
			}
		}
	}

	protected override void Dispose(bool disposing)
	{
		if (disposing && components != null)
		{
			components.Dispose();
		}
		((ContainerControl)this).Dispose(disposing);
	}

	private void InitializeComponent()
	{
		//IL_011a: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_0281: Unknown result type (might be due to invalid IL or missing references)
		//IL_031a: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_04a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0546: Unknown result type (might be due to invalid IL or missing references)
		//IL_05d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0657: Unknown result type (might be due to invalid IL or missing references)
		//IL_06da: Unknown result type (might be due to invalid IL or missing references)
		//IL_077a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0801: Unknown result type (might be due to invalid IL or missing references)
		//IL_0893: Unknown result type (might be due to invalid IL or missing references)
		//IL_0923: Unknown result type (might be due to invalid IL or missing references)
		//IL_09b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a7b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b3e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c04: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cba: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d6a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e1d: Unknown result type (might be due to invalid IL or missing references)
		//IL_1035: Unknown result type (might be due to invalid IL or missing references)
		label45 = new MetroLabel();
		browser_checkBox1 = new MetroCheckBox();
		delay_protection_checkBox1 = new MetroCheckBox();
		Throttle_checkBox1 = new MetroCheckBox();
		label33 = new MetroLabel();
		textBox1 = new MetroTextBox();
		catcha_2_username = new MetroTextBox();
		captcha_2_password_textbox = new MetroTextBox();
		captcha_api2_textbox = new MetroTextBox();
		captcha_solved_label = new MetroLabel();
		captcha_balence = new MetroLabel();
		_2captcha_configure = new MetroButton();
		label32 = new MetroLabel();
		label31 = new MetroLabel();
		label30 = new MetroLabel();
		metroLabel1 = new MetroLabel();
		poshmark_checkbox = new MetroCheckBox();
		get_license_metroLabel2 = new MetroLabel();
		canadian_closet_metroCheckBox1 = new MetroCheckBox();
		fetch_all_listings_metroCheckBox1 = new MetroCheckBox();
		save_login_metroCheckBox1 = new MetroCheckBox();
		((Control)this).SuspendLayout();
		((Control)label45).set_AutoSize(true);
		((Control)label45).set_Location(new Point(819, 23));
		((Control)label45).set_Margin(new Padding(4, 0, 4, 0));
		((Control)label45).set_Name("label45");
		((Control)label45).set_Size(new Size(97, 19));
		label45.Style = MetroColorStyle.Brown;
		((Control)label45).set_TabIndex(118);
		((Control)label45).set_Text("(check for CEF)");
		label45.UseStyleColors = true;
		((Control)label45).set_Visible(false);
		((Control)browser_checkBox1).set_AutoSize(true);
		((CheckBox)browser_checkBox1).set_Checked(true);
		((CheckBox)browser_checkBox1).set_CheckState((CheckState)1);
		((Control)browser_checkBox1).set_Location(new Point(693, 23));
		((Control)browser_checkBox1).set_Margin(new Padding(4, 5, 4, 5));
		((Control)browser_checkBox1).set_Name("browser_checkBox1");
		((Control)browser_checkBox1).set_Size(new Size(109, 15));
		browser_checkBox1.Style = MetroColorStyle.Brown;
		((Control)browser_checkBox1).set_TabIndex(117);
		((Control)browser_checkBox1).set_Text("Change Browser");
		browser_checkBox1.UseStyleColors = true;
		((ButtonBase)browser_checkBox1).set_UseVisualStyleBackColor(true);
		((CheckBox)browser_checkBox1).add_CheckedChanged((EventHandler)browser_checkBox1_CheckedChanged);
		((Control)delay_protection_checkBox1).set_AutoSize(true);
		((Control)delay_protection_checkBox1).set_Location(new Point(428, 20));
		((Control)delay_protection_checkBox1).set_Margin(new Padding(4, 5, 4, 5));
		((Control)delay_protection_checkBox1).set_Name("delay_protection_checkBox1");
		((Control)delay_protection_checkBox1).set_Size(new Size(110, 15));
		delay_protection_checkBox1.Style = MetroColorStyle.Brown;
		((Control)delay_protection_checkBox1).set_TabIndex(116);
		((Control)delay_protection_checkBox1).set_Text("Delay Protection");
		delay_protection_checkBox1.UseStyleColors = true;
		((ButtonBase)delay_protection_checkBox1).set_UseVisualStyleBackColor(true);
		((Control)Throttle_checkBox1).set_AutoSize(true);
		((Control)Throttle_checkBox1).set_Location(new Point(44, 23));
		((Control)Throttle_checkBox1).set_Margin(new Padding(4, 5, 4, 5));
		((Control)Throttle_checkBox1).set_Name("Throttle_checkBox1");
		((Control)Throttle_checkBox1).set_Size(new Size(104, 15));
		Throttle_checkBox1.Style = MetroColorStyle.Brown;
		((Control)Throttle_checkBox1).set_TabIndex(115);
		((Control)Throttle_checkBox1).set_Text("Throttle Limiter");
		Throttle_checkBox1.UseStyleColors = true;
		((ButtonBase)Throttle_checkBox1).set_UseVisualStyleBackColor(true);
		((Control)label33).set_AutoSize(true);
		((Label)label33).set_BorderStyle((BorderStyle)2);
		((Control)label33).set_Cursor(Cursors.get_Hand());
		((Control)label33).set_ForeColor(Color.Blue);
		((Control)label33).set_Location(new Point(3, 482));
		((Control)label33).set_Margin(new Padding(4, 0, 4, 0));
		((Control)label33).set_Name("label33");
		((Control)label33).set_Size(new Size(436, 19));
		label33.Style = MetroColorStyle.Magenta;
		((Control)label33).set_TabIndex(114);
		((Control)label33).set_Text("Click Here To Buy 2Captcha Credits: https://2captcha.com?from=5020607");
		label33.UseStyleColors = true;
		((Control)label33).add_Click((EventHandler)label33_Click);
		((Control)textBox1).set_BackColor(Color.Silver);
		((Control)textBox1).set_ForeColor(Color.Black);
		((Control)textBox1).set_Location(new Point(39, 262));
		((Control)textBox1).set_Margin(new Padding(4, 5, 4, 5));
		textBox1.Multiline = true;
		((Control)textBox1).set_Name("textBox1");
		((Control)textBox1).set_Size(new Size(933, 38));
		textBox1.Style = MetroColorStyle.Brown;
		((Control)textBox1).set_TabIndex(110);
		((Control)textBox1).set_Text("Provide Details and click cnfigure, if you dont want to use 2captcha service empty all fields and click configure again");
		textBox1.UseStyleColors = true;
		((Control)catcha_2_username).set_ForeColor(SystemColors.GrayText);
		((Control)catcha_2_username).set_Location(new Point(327, 162));
		((Control)catcha_2_username).set_Margin(new Padding(4, 5, 4, 5));
		((Control)catcha_2_username).set_Name("catcha_2_username");
		((Control)catcha_2_username).set_Size(new Size(381, 31));
		catcha_2_username.Style = MetroColorStyle.Brown;
		((Control)catcha_2_username).set_TabIndex(105);
		catcha_2_username.UseStyleColors = true;
		((Control)captcha_2_password_textbox).set_ForeColor(SystemColors.GrayText);
		((Control)captcha_2_password_textbox).set_Location(new Point(327, 215));
		((Control)captcha_2_password_textbox).set_Margin(new Padding(4, 5, 4, 5));
		((Control)captcha_2_password_textbox).set_Name("captcha_2_password_textbox");
		((Control)captcha_2_password_textbox).set_Size(new Size(381, 31));
		captcha_2_password_textbox.Style = MetroColorStyle.Brown;
		((Control)captcha_2_password_textbox).set_TabIndex(104);
		captcha_2_password_textbox.UseStyleColors = true;
		((Control)captcha_api2_textbox).set_ForeColor(SystemColors.GrayText);
		((Control)captcha_api2_textbox).set_Location(new Point(327, 109));
		((Control)captcha_api2_textbox).set_Margin(new Padding(4, 5, 4, 5));
		((Control)captcha_api2_textbox).set_Name("captcha_api2_textbox");
		((Control)captcha_api2_textbox).set_Size(new Size(381, 31));
		captcha_api2_textbox.Style = MetroColorStyle.Brown;
		((Control)captcha_api2_textbox).set_TabIndex(103);
		captcha_api2_textbox.UseStyleColors = true;
		((Control)captcha_solved_label).set_AutoSize(true);
		((Control)captcha_solved_label).set_Location(new Point(38, 437));
		((Control)captcha_solved_label).set_Margin(new Padding(4, 0, 4, 0));
		((Control)captcha_solved_label).set_Name("captcha_solved_label");
		((Control)captcha_solved_label).set_Size(new Size(51, 19));
		captcha_solved_label.Style = MetroColorStyle.Brown;
		((Control)captcha_solved_label).set_TabIndex(112);
		((Control)captcha_solved_label).set_Text("_______");
		captcha_solved_label.UseStyleColors = true;
		((Control)captcha_balence).set_AutoSize(true);
		((Control)captcha_balence).set_ForeColor(Color.Purple);
		((Control)captcha_balence).set_Location(new Point(39, 380));
		((Control)captcha_balence).set_Margin(new Padding(4, 0, 4, 0));
		((Control)captcha_balence).set_Name("captcha_balence");
		((Control)captcha_balence).set_Size(new Size(105, 19));
		captcha_balence.Style = MetroColorStyle.Brown;
		((Control)captcha_balence).set_TabIndex(111);
		((Control)captcha_balence).set_Text("________________");
		captcha_balence.UseStyleColors = true;
		((Control)_2captcha_configure).set_Location(new Point(327, 302));
		((Control)_2captcha_configure).set_Margin(new Padding(4, 5, 4, 5));
		((Control)_2captcha_configure).set_Name("_2captcha_configure");
		((Control)_2captcha_configure).set_Size(new Size(381, 65));
		((Control)_2captcha_configure).set_TabIndex(109);
		((Control)_2captcha_configure).set_Text("Configure 2Captcha ");
		((Control)_2captcha_configure).add_Click((EventHandler)_2captcha_configure_Click);
		((Control)label32).set_AutoSize(true);
		((Control)label32).set_Location(new Point(38, 225));
		((Control)label32).set_Margin(new Padding(4, 0, 4, 0));
		((Control)label32).set_Name("label32");
		((Control)label32).set_Size(new Size(122, 19));
		label32.Style = MetroColorStyle.Brown;
		((Control)label32).set_TabIndex(108);
		((Control)label32).set_Text("2Captcha Password");
		label32.UseStyleColors = true;
		((Control)label31).set_AutoSize(true);
		((Control)label31).set_Location(new Point(38, 171));
		((Control)label31).set_Margin(new Padding(4, 0, 4, 0));
		((Control)label31).set_Name("label31");
		((Control)label31).set_Size(new Size(127, 19));
		label31.Style = MetroColorStyle.Brown;
		((Control)label31).set_TabIndex(107);
		((Control)label31).set_Text("2Captcha Username");
		label31.UseStyleColors = true;
		((Control)label30).set_AutoSize(true);
		((Control)label30).set_Location(new Point(38, 118));
		((Control)label30).set_Margin(new Padding(4, 0, 4, 0));
		((Control)label30).set_Name("label30");
		((Control)label30).set_Size(new Size(112, 19));
		label30.Style = MetroColorStyle.Brown;
		((Control)label30).set_TabIndex(106);
		((Control)label30).set_Text("2Captcha API Key");
		label30.UseStyleColors = true;
		((Control)metroLabel1).set_AutoSize(true);
		((Label)metroLabel1).set_BorderStyle((BorderStyle)2);
		((Control)metroLabel1).set_Cursor(Cursors.get_Hand());
		metroLabel1.FontWeight = MetroLabelWeight.Regular;
		((Control)metroLabel1).set_ForeColor(Color.Blue);
		((Control)metroLabel1).set_Location(new Point(774, 482));
		((Control)metroLabel1).set_Margin(new Padding(4, 0, 4, 0));
		((Control)metroLabel1).set_Name("metroLabel1");
		((Control)metroLabel1).set_Size(new Size(157, 19));
		metroLabel1.Style = MetroColorStyle.Purple;
		((Control)metroLabel1).set_TabIndex(119);
		((Control)metroLabel1).set_Text("Our Youtube Channel.....");
		metroLabel1.UseStyleColors = true;
		((Control)metroLabel1).add_Click((EventHandler)metroLabel1_Click);
		((Control)poshmark_checkbox).set_AutoSize(true);
		((CheckBox)poshmark_checkbox).set_Checked(true);
		((CheckBox)poshmark_checkbox).set_CheckState((CheckState)1);
		((Control)poshmark_checkbox).set_Location(new Point(428, 54));
		((Control)poshmark_checkbox).set_Margin(new Padding(4, 5, 4, 5));
		((Control)poshmark_checkbox).set_Name("poshmark_checkbox");
		((Control)poshmark_checkbox).set_Size(new Size(200, 15));
		poshmark_checkbox.Style = MetroColorStyle.Brown;
		((Control)poshmark_checkbox).set_TabIndex(120);
		((Control)poshmark_checkbox).set_Text("Force Poshmarket Selection (ALL)");
		poshmark_checkbox.UseStyleColors = true;
		((ButtonBase)poshmark_checkbox).set_UseVisualStyleBackColor(true);
		((Control)poshmark_checkbox).set_Visible(false);
		((Control)get_license_metroLabel2).set_AutoSize(true);
		((Label)get_license_metroLabel2).set_BorderStyle((BorderStyle)2);
		get_license_metroLabel2.FontWeight = MetroLabelWeight.Bold;
		((Control)get_license_metroLabel2).set_Location(new Point(774, 437));
		((Control)get_license_metroLabel2).set_Margin(new Padding(4, 0, 4, 0));
		((Control)get_license_metroLabel2).set_Name("get_license_metroLabel2");
		((Control)get_license_metroLabel2).set_Size(new Size(158, 19));
		get_license_metroLabel2.Style = MetroColorStyle.Green;
		((Control)get_license_metroLabel2).set_TabIndex(121);
		((Control)get_license_metroLabel2).set_Text("Purchase license          ");
		get_license_metroLabel2.UseStyleColors = true;
		((Control)get_license_metroLabel2).set_Visible(false);
		((Control)get_license_metroLabel2).add_Click((EventHandler)get_license_metroLabel2_Click);
		((Control)canadian_closet_metroCheckBox1).set_AutoSize(true);
		((Control)canadian_closet_metroCheckBox1).set_Location(new Point(693, 54));
		((Control)canadian_closet_metroCheckBox1).set_Margin(new Padding(4, 5, 4, 5));
		((Control)canadian_closet_metroCheckBox1).set_Name("canadian_closet_metroCheckBox1");
		((Control)canadian_closet_metroCheckBox1).set_Size(new Size(109, 15));
		canadian_closet_metroCheckBox1.Style = MetroColorStyle.Brown;
		((Control)canadian_closet_metroCheckBox1).set_TabIndex(122);
		((Control)canadian_closet_metroCheckBox1).set_Text("Canadian Closet");
		canadian_closet_metroCheckBox1.UseStyleColors = true;
		((ButtonBase)canadian_closet_metroCheckBox1).set_UseVisualStyleBackColor(true);
		((CheckBox)canadian_closet_metroCheckBox1).add_CheckedChanged((EventHandler)canadian_closet_metroCheckBox1_CheckedChanged);
		((Control)fetch_all_listings_metroCheckBox1).set_AutoSize(true);
		((Control)fetch_all_listings_metroCheckBox1).set_Location(new Point(44, 48));
		((Control)fetch_all_listings_metroCheckBox1).set_Margin(new Padding(4, 5, 4, 5));
		((Control)fetch_all_listings_metroCheckBox1).set_Name("fetch_all_listings_metroCheckBox1");
		((Control)fetch_all_listings_metroCheckBox1).set_Size(new Size(235, 15));
		fetch_all_listings_metroCheckBox1.Style = MetroColorStyle.Brown;
		((Control)fetch_all_listings_metroCheckBox1).set_TabIndex(123);
		((Control)fetch_all_listings_metroCheckBox1).set_Text("Force Listings fetch (not recommended)");
		fetch_all_listings_metroCheckBox1.UseStyleColors = true;
		((ButtonBase)fetch_all_listings_metroCheckBox1).set_UseVisualStyleBackColor(true);
		((CheckBox)fetch_all_listings_metroCheckBox1).add_CheckedChanged((EventHandler)fetch_all_listings_metroCheckBox1_CheckedChanged);
		((Control)save_login_metroCheckBox1).set_AutoSize(true);
		((Control)save_login_metroCheckBox1).set_Location(new Point(44, 73));
		((Control)save_login_metroCheckBox1).set_Margin(new Padding(4, 5, 4, 5));
		((Control)save_login_metroCheckBox1).set_Name("save_login_metroCheckBox1");
		((Control)save_login_metroCheckBox1).set_Size(new Size(122, 15));
		save_login_metroCheckBox1.Style = MetroColorStyle.Brown;
		((Control)save_login_metroCheckBox1).set_TabIndex(124);
		((Control)save_login_metroCheckBox1).set_Text("Save Login Session");
		save_login_metroCheckBox1.UseStyleColors = true;
		((ButtonBase)save_login_metroCheckBox1).set_UseVisualStyleBackColor(true);
		((Control)save_login_metroCheckBox1).set_Visible(false);
		((CheckBox)save_login_metroCheckBox1).add_CheckedChanged((EventHandler)fetch_all_listings_metroCheckBox1_CheckedChanged);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(9f, 20f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Control)this).get_Controls().Add((Control)(object)save_login_metroCheckBox1);
		((Control)this).get_Controls().Add((Control)(object)fetch_all_listings_metroCheckBox1);
		((Control)this).get_Controls().Add((Control)(object)canadian_closet_metroCheckBox1);
		((Control)this).get_Controls().Add((Control)(object)get_license_metroLabel2);
		((Control)this).get_Controls().Add((Control)(object)poshmark_checkbox);
		((Control)this).get_Controls().Add((Control)(object)metroLabel1);
		((Control)this).get_Controls().Add((Control)(object)label45);
		((Control)this).get_Controls().Add((Control)(object)browser_checkBox1);
		((Control)this).get_Controls().Add((Control)(object)delay_protection_checkBox1);
		((Control)this).get_Controls().Add((Control)(object)Throttle_checkBox1);
		((Control)this).get_Controls().Add((Control)(object)label33);
		((Control)this).get_Controls().Add((Control)(object)textBox1);
		((Control)this).get_Controls().Add((Control)(object)catcha_2_username);
		((Control)this).get_Controls().Add((Control)(object)captcha_2_password_textbox);
		((Control)this).get_Controls().Add((Control)(object)captcha_api2_textbox);
		((Control)this).get_Controls().Add((Control)(object)captcha_solved_label);
		((Control)this).get_Controls().Add((Control)(object)captcha_balence);
		((Control)this).get_Controls().Add((Control)(object)_2captcha_configure);
		((Control)this).get_Controls().Add((Control)(object)label32);
		((Control)this).get_Controls().Add((Control)(object)label31);
		((Control)this).get_Controls().Add((Control)(object)label30);
		((Control)this).set_Margin(new Padding(4, 5, 4, 5));
		((Control)this).set_Name("Pro_configurations");
		((Control)this).set_Size(new Size(1096, 588));
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}
}
