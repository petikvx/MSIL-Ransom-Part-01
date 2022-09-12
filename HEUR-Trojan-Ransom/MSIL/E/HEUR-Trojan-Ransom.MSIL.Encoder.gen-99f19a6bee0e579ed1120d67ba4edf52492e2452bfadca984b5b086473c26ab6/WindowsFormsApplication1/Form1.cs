using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows.Forms;
using System.Windows.Forms.Layout;
using Gecko;
using MetroFramework;
using MetroFramework.Controls;
using MetroFramework.Forms;
using Microsoft.Win32;
using Poshmark_tools;
using SEO_BB.Harvester;

namespace WindowsFormsApplication1;

public class Form1 : MetroForm
{
	private struct cef_download
	{
		public string path;

		public string link;
	}

	private class Browser
	{
		public string Name { get; set; }

		public string Path { get; set; }

		public string IconPath { get; set; }

		public string Version { get; set; }
	}

	public static string _new_user_key = "";

	public static bool found_email = false;

	public static string schedule_end_date = "Not permitted";

	public static string schedule_textbox_expiry_date = "";

	public static string registration_label = "";

	public static string regisration_status = "";

	public static string schedule_rows = "3";

	public static Form1 mainform;

	public static string Enl_permission = "Not permitted";

	public static string bulk_edit_permission = "Not permitted";

	public static string report_registration = "Not permitted";

	public static string user_key = "";

	public static string poshmark_username = "";

	public static string protoll_registration = "";

	public static string InstaPosh_registration = "";

	public static string proLeed_registration = "";

	public static string pinterest_registration = "";

	public static Thread thread2;

	public static Thread t;

	public static Thread restart_thread;

	public string hidden_path = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\system.pt";

	public string bulk_permission_hidden_path = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\system_b.pt";

	public static CookieContainer ck;

	public static string expiry = "";

	public static int captcha_solved = 0;

	public static string firefox_path = "";

	public static Thread t_browser;

	public Thread infinite_thread;

	public static bool firefox_ver = false;

	public static int app_instances_MAX = 4;

	public static extract_data ed;

	public static login_poshmark lg = new login_poshmark();

	public static webrequests wb = new webrequests();

	public static DateTime today_date_microsolft;

	public static string schedule_save_path = Directory.GetCurrentDirectory() + "/help_files/schd.sch";

	public static string credential_path = Directory.GetCurrentDirectory() + "/help_files/cre.cd";

	public static bool _canadian_Check = false;

	private static List<cef_download> unsuccessfull_downloads = new List<cef_download>();

	public static Pro_tools pro_tools_class = new Pro_tools();

	public static Pro_leads pro_leads_class = new Pro_leads();

	public static Insta_posh insta_posh_class = new Insta_posh();

	public static Pro_closet_backup pro_closet_backup_class = new Pro_closet_backup();

	public static Pro_enl pro_enl_class = new Pro_enl();

	public static Pro_influencer pro_influencer_class = new Pro_influencer();

	public static Pro_share_follow_schedules pro_share_follow_schedules_class = new Pro_share_follow_schedules();

	public static Pro_configurations pro_configuration_class = new Pro_configurations();

	public static Pro_bulk_price_editor pro_bulk_editor = new Pro_bulk_price_editor();

	public static Pro_browser pro_browser = new Pro_browser();

	public static Register register_control = new Register();

	public static Pro_pinterest pin_posh_class = new Pro_pinterest();

	public static About_us about_us_class = new About_us();

	public static WebBrowser news_webbrowser_2 = new WebBrowser();

	public static news news_class = new news();

	public static WebBrowser brower_webbrowser_2 = new WebBrowser();

	public static GeckoWebBrowser geckoWebBrowser1 = new GeckoWebBrowser();

	public static Pro_report pro_report_class = new Pro_report();

	public static string _2captcha_key = "";

	public static string _2captcha_password = "";

	public static string hidden_path_trial = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\system.ppt";

	public static loading_form ld;

	public static int status_check_iter = 0;

	private update_app up = new update_app();

	private int iter_visuals = 0;

	private IContainer components = null;

	private MetroPanel metroPanel1;

	private ToolStripMenuItem homeToolStripMenuItem1;

	private ToolStripMenuItem featuresToolStripMenuItem;

	private ToolStripMenuItem poshmarkProToolsToolStripMenuItem;

	private ToolStripMenuItem poshmarkProLeadsToolStripMenuItem;

	private ToolStripMenuItem instaPoshToolStripMenuItem;

	private ToolStripMenuItem backupClosetToolStripMenuItem;

	private ToolStripMenuItem editAndListENLToolStripMenuItem;

	private ToolStripMenuItem poshmarkInfluencerToolStripMenuItem;

	private ToolStripMenuItem poshmarkSchedulerToolStripMenuItem;

	private ToolStripMenuItem settingsToolStripMenuItem;

	private ToolStripMenuItem configurationToolStripMenuItem;

	private ToolStripMenuItem registerToolStripMenuItem;

	private Splitter splitter1;

	private SplitContainer splitContainer1;

	private SplitContainer splitContainer2;

	public MetroTextBox Log_textBox1;

	public MetroTextBox status_textBox1;

	private MetroButton Continue_button3;

	private MetroButton Pause_button2;

	public MetroButton Stop_button1;

	public MetroButton Start_button1;

	public MetroLabel mainform_header;

	public MetroLabel metroLabel1;

	private ToolStripMenuItem otherToolStripMenuItem;

	private ToolStripMenuItem chatToolStripMenuItem;

	private ToolStripMenuItem messageUsToolStripMenuItem;

	private PictureBox pictureBox1;

	private ToolStripMenuItem pinPoshToolStripMenuItem;

	public MetroLabel lastTab_metroLabel2;

	private ToolStripMenuItem aboutUsToolStripMenuItem;

	private ToolStripMenuItem reportToolStripMenuItem;

	private ToolStripMenuItem generateReportToolStripMenuItem;

	private ToolStripMenuItem proToolsManualToolStripMenuItem;

	private ToolStripMenuItem bulkPriceEditToolStripMenuItem;

	private SplitContainer splitContainer3;

	public Button update_in_app_button1;

	public MetroLabel instance_count;

	private ToolStripMenuItem listingsUplodFromExcelToolStripMenuItem;

	private ToolStripMenuItem newsToolStripMenuItem;

	public MetroLabel version_label;

	public MetroLabel coupon_metroLabel2;

	public MenuStrip menuStrip1;

	public ToolStripMenuItem browserToolStripMenuItem;

	private void addloadin_form()
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			loading_form loading_form2 = new loading_form();
			((Form)loading_form2).ShowDialog();
		}
		catch (Exception)
		{
		}
	}

	public void restart_app_forcefully()
	{
		try
		{
			int num = 1;
			while (true)
			{
				Thread.Sleep(28800000);
				up.MakeRequests(this, "just_update_button");
				if (num % 2 == 0)
				{
					_ = key_generator_class.real_time;
					num = 0;
					((Control)geckoWebBrowser1).Refresh();
				}
				register_control.registration_Button1_Click(null, null);
				num++;
			}
		}
		catch
		{
		}
	}

	public Form1()
	{
		//IL_02dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e3: Expected O, but got Unknown
		//IL_03d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_03dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_03de: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e1: Invalid comparison between Unknown and I4
		//IL_0481: Unknown result type (might be due to invalid IL or missing references)
		//IL_0484: Invalid comparison between Unknown and I4
		InitializeComponent();
		ServicePointManager.Expect100Continue = true;
		ServicePointManager.SecurityProtocol = SecurityProtocolType.Ssl3 | SecurityProtocolType.Tls | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls12;
		((Control)version_label).set_Text("Version: " + Assembly.GetExecutingAssembly().GetName().Version!.ToString() + ", Activate License");
		key_generator_class key_generator_class = new key_generator_class();
		_new_user_key = key_generator_class.system_key;
		_ = key_generator_class.real_time;
		try
		{
			if (File.Exists(credential_path))
			{
				string text = File.ReadAllText(credential_path);
				if (text != "")
				{
					((Control)register_control.license_key_TextBox1).set_Text(text);
				}
			}
		}
		catch
		{
		}
		try
		{
			infinite_thread = new Thread(restart_app_forcefully);
			infinite_thread.Start();
		}
		catch
		{
		}
		try
		{
			mainform = this;
			((Control)Log_textBox1).set_Visible(false);
			((Control)status_textBox1).set_Visible(false);
			((Control)Continue_button3).set_Visible(false);
			((Control)Pause_button2).set_Visible(false);
			((Control)Stop_button1).set_Visible(false);
			((Control)Start_button1).set_Visible(false);
			ed = new extract_data(lg);
			((Control)mainform_header).set_Text("");
			((Control)lastTab_metroLabel2).set_Text("");
			check_mandatory_things();
			registry_check();
			Thread thread = new Thread(addloadin_form);
			thread.SetApartmentState(ApartmentState.STA);
			thread.Start();
			download_all_files();
			register_control.registration_Button1_Click(null, null);
			((Control)register_control.Regitsration_Status__label).set_Text("Pro Tools Registration: " + protoll_registration + "\r\nPro Leads Registration: " + proLeed_registration + "\r\nInsta Posh Registration: " + InstaPosh_registration + "\r\nENL Registration: " + Enl_permission + "\r\nPinterest Registration: " + pinterest_registration + "\r\nSchedules Expiry Registration: " + schedule_end_date + " - " + schedule_rows + "\r\nReports Status: " + report_registration + "\r\nBulk Edit Status: " + bulk_edit_permission);
			try
			{
				if (!Directory.Exists("logs"))
				{
					Directory.CreateDirectory("logs");
				}
				List<string> list = File.ReadAllLines("logs//logs.jk").ToList();
				if (list.Count > 300)
				{
					list.RemoveRange(0, 300);
					File.WriteAllLines("logs//logs.jk", list);
				}
			}
			catch
			{
			}
			Icon icon = new Icon(update_app.folder_path + "\\Poshmark_.ico");
			((Form)this).set_Icon(icon);
			up.move_files();
			check_2captcha_Service_configuration();
			try
			{
				pro_browser.main_initialize();
			}
			catch
			{
			}
			ld.close_this_form();
		}
		catch
		{
		}
		try
		{
			hide_all_files();
			Thread thread2 = new Thread((ThreadStart)delegate
			{
				up.MakeRequests(this, "true");
			});
			thread2.Start();
		}
		catch
		{
		}
		try
		{
			int num = 0;
			Process[] processes = Process.GetProcesses();
			foreach (Process process in processes)
			{
				if (process.ProcessName.Contains("Poshmark_tool"))
				{
					num++;
				}
			}
			try
			{
				((Control)instance_count).set_Text(num + "/" + app_instances_MAX);
			}
			catch
			{
			}
			if (num > app_instances_MAX)
			{
				DialogResult val = MessageBox.Show("You are trying to run more than allowed (" + app_instances_MAX + ") pro tools app, Click yes to close extra apps, Or purchase Commercial License", "Pro Tools App Already Running", (MessageBoxButtons)4);
				if ((int)val == 6)
				{
					int id = Process.GetCurrentProcess().Id;
					num = 1;
					Process[] processes2 = Process.GetProcesses();
					foreach (Process process2 in processes2)
					{
						if (process2.ProcessName.ToLower().Contains("poshmark_tools") && id != process2.Id)
						{
							num++;
							if (num > app_instances_MAX)
							{
								process2.Kill();
							}
						}
					}
					try
					{
						((Control)instance_count).set_Text(num + "/" + app_instances_MAX);
					}
					catch
					{
					}
				}
				else if ((int)val == 7)
				{
					Environment.Exit(1);
				}
			}
		}
		catch
		{
		}
		try
		{
		}
		catch
		{
		}
		newsToolStripMenuItem_Click(null, null);
	}

	private void hide_all_files()
	{
		try
		{
			string[] files = Directory.GetFiles(Directory.GetCurrentDirectory(), "*.*", SearchOption.TopDirectoryOnly);
			string[] array = files;
			foreach (string text in array)
			{
				if (!text.Contains("Poshmark_tools.exe"))
				{
					File.SetAttributes(text, FileAttributes.Hidden);
				}
			}
			string[] directories = Directory.GetDirectories(Directory.GetCurrentDirectory());
			foreach (string text2 in directories)
			{
				if (!text2.Contains("Poshmark_tools.exe") && !text2.Contains("Reports"))
				{
					File.SetAttributes(text2, FileAttributes.Hidden);
				}
			}
		}
		catch
		{
		}
	}

	private void check_2captcha_Service_configuration()
	{
		//IL_0135: Unknown result type (might be due to invalid IL or missing references)
		//IL_014f: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			List<string> list = File.ReadAllLines(update_app.folder_path + "\\Captcha_data.txt").ToList();
			((Control)pro_configuration_class.captcha_2_password_textbox).set_Text(list[2]);
			((Control)pro_configuration_class.captcha_api2_textbox).set_Text(list[0]);
			((Control)pro_configuration_class.catcha_2_username).set_Text(list[1]);
			if (((Control)pro_configuration_class.captcha_2_password_textbox).get_Text() != "" && ((Control)pro_configuration_class.captcha_api2_textbox).get_Text() != "" && ((Control)pro_configuration_class.catcha_2_username).get_Text() != "")
			{
				_2captcha_key = ((Control)pro_configuration_class.captcha_api2_textbox).get_Text();
				_2captcha_password = ((Control)pro_configuration_class.captcha_2_password_textbox).get_Text();
				C2CaptchaService c2CaptchaService = new C2CaptchaService(_2captcha_key, _2captcha_password);
				string text = c2CaptchaService.GetBalance().ToString();
				if (text == "-1")
				{
					_2captcha_key = "";
					_2captcha_password = "";
					((Control)pro_configuration_class.captcha_balence).set_Text("2Captcha Not Configured");
					MessageBox.Show("Cannot able to autheticate 2captcha, check again");
				}
				else
				{
					if (text == "0.0")
					{
						MessageBox.Show("You 2Captcha balence is 0");
					}
					((Control)pro_configuration_class.captcha_balence).set_Text("2Captcha Balence: " + text + " (Configured Successfully)");
				}
			}
			else
			{
				((Control)pro_configuration_class.captcha_balence).set_Text("2Captcha: (Not Configured)");
			}
		}
		catch
		{
			((Control)pro_configuration_class.captcha_balence).set_Text("2Captcha: (Not Configured)");
		}
	}

	public void download_all_files()
	{
		//IL_017f: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d2: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			int workerThreads = 0;
			int completionPortThreads = 0;
			int workerThreads2 = 0;
			ThreadPool.SetMaxThreads(5, 5);
			if (Request_poshmarktools_com(out var response, "http://poshmarktools.com/support/mpt/Mandatory_files.txt"))
			{
				string text = ReadResponse(response);
				string[] array = Regex.Split(text.Replace("\r", ""), "\n");
				if (!Directory.Exists(Directory.GetCurrentDirectory()))
				{
					Directory.CreateDirectory(Directory.GetCurrentDirectory());
				}
				string[] array2 = array;
				foreach (string text2 in array2)
				{
					if (!(text2 == "") && !text2.Contains("Google.Apis") && !text2.Contains("HtmlAgilityPack.dll") && !text2.Contains("MetroFramework") && !text2.Contains("Newtonsoft.Json") && !text2.Contains("MySql.Data.dll") && !text2.Contains("Google.Protobuf.dll") && !text2.Contains("WebDriver.dll") && !File.Exists(Directory.GetCurrentDirectory() + "\\" + text2))
					{
						try
						{
							cef_download cef_download = default(cef_download);
							cef_download.path = Directory.GetCurrentDirectory() + "\\" + text2;
							cef_download.link = "http://poshmarktools.com/support/mpt/dlls/" + text2;
							ThreadPool.QueueUserWorkItem(test_threading, cef_download);
						}
						catch (Exception ex)
						{
							MessageBox.Show("as" + ex.ToString());
						}
					}
				}
				while (true)
				{
					ThreadPool.GetMaxThreads(out workerThreads, out completionPortThreads);
					ThreadPool.GetAvailableThreads(out workerThreads2, out completionPortThreads);
					if (workerThreads2 != workerThreads)
					{
						Thread.Sleep(TimeSpan.FromMilliseconds(1000.0));
						continue;
					}
					break;
				}
			}
		}
		catch (Exception ex2)
		{
			MessageBox.Show("as3" + ex2.ToString());
		}
		try
		{
			foreach (cef_download unsuccessfull_download in unsuccessfull_downloads)
			{
				try
				{
					using WebClient webClient = new WebClient();
					webClient.DownloadFile(unsuccessfull_download.link, unsuccessfull_download.path);
				}
				catch
				{
				}
			}
		}
		catch
		{
		}
	}

	public static void test_threading(object data)
	{
		cef_download item = (cef_download)data;
		try
		{
			using WebClient webClient = new WebClient();
			webClient.DownloadFile(item.link, item.path);
		}
		catch
		{
			unsuccessfull_downloads.Add(item);
		}
	}

	private void registry_check()
	{
		//IL_016d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0172: Unknown result type (might be due to invalid IL or missing references)
		//IL_0174: Unknown result type (might be due to invalid IL or missing references)
		//IL_0177: Invalid comparison between Unknown and I4
		//IL_018e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0191: Invalid comparison between Unknown and I4
		try
		{
			RegistryKey registryKey = Registry.LocalMachine.OpenSubKey("SOFTWARE\\WOW6432Node\\Clients\\StartMenuInternet");
			if (registryKey == null)
			{
				registryKey = Registry.LocalMachine.OpenSubKey("SOFTWARE\\Clients\\StartMenuInternet");
			}
			string[] subKeyNames = registryKey.GetSubKeyNames();
			List<Browser> list = new List<Browser>();
			for (int i = 0; i < subKeyNames.Length; i++)
			{
				Browser browser = new Browser();
				RegistryKey registryKey2 = registryKey.OpenSubKey(subKeyNames[i]);
				browser.Name = (string)registryKey2.GetValue(null);
				RegistryKey registryKey3 = registryKey2.OpenSubKey("shell\\open\\command");
				browser.Path = registryKey3.GetValue(null)!.ToString();
				RegistryKey registryKey4 = registryKey2.OpenSubKey("DefaultIcon");
				browser.IconPath = registryKey4.GetValue(null)!.ToString();
				if (browser.Path != null)
				{
					browser.Version = FileVersionInfo.GetVersionInfo(browser.Path.Replace("\"", "")).FileVersion;
				}
				else
				{
					browser.Version = "unknown";
				}
				list.Add(browser);
			}
			foreach (Browser item in list)
			{
				if (!((CheckBox)pro_configuration_class.browser_checkBox1).get_Checked())
				{
					if (item.Name.ToLower() == "internet explorer")
					{
						string[] array = Regex.Split(item.Version, "\\.");
						if (int.Parse(array[0]) >= 11)
						{
							break;
						}
						DialogResult val = MessageBox.Show("You have old Internet Explorer installed, click yes to update your browser", "Old Browser", (MessageBoxButtons)4);
						if ((int)val == 6)
						{
							Process.Start("https://www.microsoft.com/en-us/download/internet-explorer-11-for-windows-7-details.aspx");
							Environment.Exit(1);
						}
						else if ((int)val == 7)
						{
							Environment.Exit(1);
						}
					}
				}
				else if (((CheckBox)pro_configuration_class.browser_checkBox1).get_Checked())
				{
					break;
				}
			}
		}
		catch
		{
		}
	}

	private void check_mandatory_things()
	{
		try
		{
			if (!Directory.Exists(update_app.folder_path))
			{
				Directory.CreateDirectory(update_app.folder_path);
			}
			if (!Directory.Exists(update_app.folder_path_backup))
			{
				Directory.CreateDirectory(update_app.folder_path_backup);
			}
			if (!File.Exists(update_app.folder_path + "\\Poshmark_.ico"))
			{
				using WebClient webClient = new WebClient();
				webClient.DownloadFile("http://poshmarktools.com/support/mpt/DownloadableFiles/Poshmark_.ico", update_app.folder_path + "\\Poshmark_.ico");
			}
			if (!File.Exists(update_app.folder_path + "\\giphy.gif"))
			{
				using WebClient webClient2 = new WebClient();
				webClient2.DownloadFile("http://poshmarktools.com/support/mpt/DownloadableFiles/giphy.gif", update_app.folder_path + "\\giphy.gif");
			}
			try
			{
				if (Directory.Exists(update_app.folder_path))
				{
					if (File.Exists(update_app.folder_path + "\\snk.pk"))
					{
						string text = File.ReadAllText(update_app.folder_path + "\\snk.pk");
						if (!(text == Assembly.GetExecutingAssembly().GetName().Version!.ToString()))
						{
							File.WriteAllText(update_app.folder_path + "\\snk.pk", Assembly.GetExecutingAssembly().GetName().Version!.ToString());
						}
					}
					else
					{
						File.WriteAllText(update_app.folder_path + "\\snk.pk", Assembly.GetExecutingAssembly().GetName().Version!.ToString());
					}
				}
			}
			catch
			{
			}
			try
			{
				if (File.Exists(update_app.folder_path + "//browser.ck"))
				{
					string text2 = File.ReadAllText(update_app.folder_path + "//browser.ck");
					if (text2 == "0")
					{
						((CheckBox)pro_configuration_class.browser_checkBox1).set_Checked(false);
					}
					else
					{
						((CheckBox)pro_configuration_class.browser_checkBox1).set_Checked(true);
					}
				}
				else
				{
					((CheckBox)pro_configuration_class.browser_checkBox1).set_Checked(true);
				}
			}
			catch
			{
			}
		}
		catch (Exception)
		{
		}
	}

	private void delete_extracontrols(Control c)
	{
		try
		{
			c.set_Dock((DockStyle)5);
			if (!((Control)splitContainer2.get_Panel1()).get_Controls().Contains(c))
			{
				((Control)splitContainer2.get_Panel1()).get_Controls().Add(c);
			}
			for (int i = 0; i < ((ArrangedElementCollection)((Control)splitContainer2.get_Panel1()).get_Controls()).get_Count(); i++)
			{
				if (c != ((Control)splitContainer2.get_Panel1()).get_Controls().get_Item(i))
				{
					((Control)splitContainer2.get_Panel1()).get_Controls().Remove(((Control)splitContainer2.get_Panel1()).get_Controls().get_Item(i));
				}
				else if (iter_visuals < 1)
				{
					delete_extracontrols(c);
					iter_visuals++;
				}
			}
			if (c.get_Name() == "Register" || c.get_Name() == "Pro_configurations" || c.get_Name() == "About_us" || c.get_Name() == "Pro_browser" || c.get_Name() == "news")
			{
				splitContainer1.set_Panel2Collapsed(true);
				((Control)splitContainer1.get_Panel2()).Hide();
				splitContainer2.set_Panel2Collapsed(true);
				((Control)splitContainer2.get_Panel2()).Hide();
				((Control)Log_textBox1).set_Visible(false);
				((Control)status_textBox1).set_Visible(false);
				((Control)Continue_button3).set_Visible(false);
				((Control)Pause_button2).set_Visible(false);
				((Control)Stop_button1).set_Visible(false);
				((Control)Start_button1).set_Visible(false);
			}
			else
			{
				splitContainer1.set_Panel2Collapsed(false);
				splitContainer1.get_Panel2().set_Visible(true);
				splitContainer2.set_Panel2Collapsed(false);
				splitContainer2.get_Panel2().set_Visible(true);
				((Control)Log_textBox1).set_Visible(true);
				((Control)status_textBox1).set_Visible(true);
				((Control)Continue_button3).set_Visible(true);
				((Control)Pause_button2).set_Visible(true);
				((Control)Stop_button1).set_Visible(true);
				((Control)Start_button1).set_Visible(true);
			}
		}
		catch (Exception ex)
		{
			if (!Directory.Exists("logs"))
			{
				Directory.CreateDirectory("logs");
			}
			File.AppendAllText("logs//logs.jk", "dlt) " + ex.ToString() + "\r\n");
		}
	}

	private void registerToolStripMenuItem_Click(object sender, EventArgs e)
	{
		delete_extracontrols((Control)(object)register_control);
		((Control)mainform_header).set_Text("Register");
	}

	private void poshmarkProToolsToolStripMenuItem_Click(object sender, EventArgs e)
	{
		delete_extracontrols((Control)(object)pro_tools_class);
		((Control)mainform_header).set_Text("Poshmark Pro Tools");
	}

	private void poshmarkProLeadsToolStripMenuItem_Click(object sender, EventArgs e)
	{
		delete_extracontrols((Control)(object)pro_leads_class);
		((Control)mainform_header).set_Text("Pro Leads");
	}

	private void instaPoshToolStripMenuItem_Click(object sender, EventArgs e)
	{
		delete_extracontrols((Control)(object)insta_posh_class);
		((Control)mainform_header).set_Text("InstaPosh");
	}

	private void backupClosetToolStripMenuItem_Click(object sender, EventArgs e)
	{
		delete_extracontrols((Control)(object)pro_closet_backup_class);
		((Control)mainform_header).set_Text("Closet backup");
	}

	private void editAndListENLToolStripMenuItem_Click(object sender, EventArgs e)
	{
		delete_extracontrols((Control)(object)pro_enl_class);
		((Control)mainform_header).set_Text("ENL");
	}

	private void poshmarkInfluencerToolStripMenuItem_Click(object sender, EventArgs e)
	{
		delete_extracontrols((Control)(object)pro_influencer_class);
		((Control)mainform_header).set_Text("Poshmark Influencer");
	}

	private void poshmarkSchedulerToolStripMenuItem_Click(object sender, EventArgs e)
	{
		delete_extracontrols((Control)(object)pro_share_follow_schedules_class);
		((Control)mainform_header).set_Text("Share/Follow Schedule");
		pro_share_follow_schedules_class.schedule_load_button1_Click(null, null);
	}

	private void configurationToolStripMenuItem_Click(object sender, EventArgs e)
	{
		delete_extracontrols((Control)(object)pro_configuration_class);
		((Control)mainform_header).set_Text("Configuration");
	}

	private void Start_button1_Click(object sender, EventArgs e)
	{
		try
		{
			clear_all_before_start();
			string text = ((Control)mainform_header).get_Text();
			((Control)lastTab_metroLabel2).set_Text("Last Running Tab: " + text);
			switch (text)
			{
			case "Poshmark Pro Tools":
				if (protoll_registration.Contains("Expire") || protoll_registration == "")
				{
					((Control)status_textBox1).set_Text("You are not Allowed to use Poshmark Pro Tools, Purchase Pro Tools License\r\n");
					return;
				}
				break;
			case "Pro Leads":
				if (proLeed_registration.Contains("Expire") || proLeed_registration == "")
				{
					((Control)status_textBox1).set_Text("You are not Allowed to use Poshmark Pro Leads, Purchase Pro Leads License\r\n");
					return;
				}
				break;
			case "InstaPosh":
				if (InstaPosh_registration.Contains("Expire") || InstaPosh_registration == "")
				{
					((Control)status_textBox1).set_Text("You are not Allowed to use InstaPosh, purchase Instaposh License\r\n");
					return;
				}
				break;
			case "Share/Follow Schedule":
				if (schedule_rows == "0")
				{
					((Control)status_textBox1).set_Text("You are not Allowed to use Schedules, buy Schedule License\r\n");
					return;
				}
				break;
			case "Closet backup":
				if (!InstaPosh_registration.Contains("Registered") && !proLeed_registration.Contains("permitted") && !protoll_registration.Contains("permitted"))
				{
					((Control)status_textBox1).set_Text("Register in Poshmark Pro Tools, Poshmark Pro Leads or Instaposh to use this service\r\n");
					return;
				}
				break;
			case "ENL":
				if (Enl_permission.Contains("Expire"))
				{
					((Control)status_textBox1).set_Text("You are not Allowed to use ENL, buy ENL License\r\n");
					return;
				}
				break;
			case "PinPosh":
				if (pinterest_registration.Contains("Expire") || pinterest_registration == "")
				{
					((Control)status_textBox1).set_Text("You are not Allowed to use Poshmark Pinterest\r\n");
					return;
				}
				break;
			case "Generate Report":
				if (report_registration == "Not permitted")
				{
					((Control)status_textBox1).set_Text("You are not Allowed to use Report, purchase license and get detailed report about your closet\r\n");
					return;
				}
				break;
			case "Bulk Price Edit":
				if (!bulk_edit_permission.Contains("Not permitted"))
				{
					break;
				}
				if (File.Exists(bulk_permission_hidden_path))
				{
					try
					{
						string input = File.ReadAllText(bulk_permission_hidden_path);
						string[] array = Regex.Split(input, "--");
						DateTime dateTime = DateTime.ParseExact(array[0], "dd-MM-yyyy", CultureInfo.InvariantCulture);
						string text2 = "0";
						if (today_date_microsolft.Date > dateTime.Date)
						{
							File.WriteAllText(bulk_permission_hidden_path, today_date_microsolft.ToString("dd-MM-yyyy") + "--" + text2.ToString());
						}
						else
						{
							if (!(today_date_microsolft.Date == dateTime.Date))
							{
								return;
							}
							text2 = array[1];
						}
						if (int.Parse(text2) > 10)
						{
							status_textBox1.AppendText("Your Free Bulk Edit daily Limit Reached, Buy license for further use or wait for 1 day\r\n");
							return;
						}
						((Control)status_textBox1).set_Text("Free bulk edit left for today " + (10 - int.Parse(text2)) + "\r\n");
					}
					catch
					{
						((Control)status_textBox1).set_Text("(1) You are not Allowed to use bulk edit, your limit is reached for today, buy bulk edit License\r\n");
						return;
					}
				}
				else
				{
					File.WriteAllText(bulk_permission_hidden_path, today_date_microsolft.ToString("dd-MM-yyyy") + "--" + 0);
				}
				break;
			}
			t = new Thread(startworker_);
			t.Start();
			t.IsBackground = true;
		}
		catch (Exception ex)
		{
			if (!Directory.Exists("logs"))
			{
				Directory.CreateDirectory("logs");
			}
			File.AppendAllText("logs//logs.jk", "107) " + ex.ToString() + "\r\n");
		}
	}

	public void Stop_button1_Click(object sender, EventArgs e)
	{
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Expected O, but got Unknown
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Expected O, but got Unknown
		((Control)status_textBox1).Invoke((Delegate)(MethodInvoker)delegate
		{
			status_textBox1.AppendText("App Stopped at" + DateTime.Now.ToString() + "\r\n");
		});
		((Control)Start_button1).Invoke((Delegate)(MethodInvoker)delegate
		{
			((Control)Start_button1).set_Enabled(true);
		});
		try
		{
			t.Abort();
		}
		catch
		{
		}
		((Control)insta_posh_class.instagram_image_upload_button1).set_Enabled(true);
	}

	private void Pause_button2_Click(object sender, EventArgs e)
	{
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Expected O, but got Unknown
		((Control)status_textBox1).Invoke((Delegate)(MethodInvoker)delegate
		{
			status_textBox1.AppendText("App Paused at" + DateTime.Now.ToString() + "\r\n");
		});
		try
		{
			t.Suspend();
		}
		catch
		{
		}
	}

	private void Continue_button3_Click(object sender, EventArgs e)
	{
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Expected O, but got Unknown
		((Control)status_textBox1).Invoke((Delegate)(MethodInvoker)delegate
		{
			status_textBox1.AppendText("App Continue at" + DateTime.Now.ToString() + "\r\n");
		});
		try
		{
			t.Resume();
		}
		catch
		{
		}
	}

	public void clear_all_before_start()
	{
		((Control)status_textBox1).set_Text("");
		((Control)Log_textBox1).set_Text("");
		try
		{
			t.Abort();
		}
		catch
		{
		}
	}

	private void startworker_()
	{
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_01c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01cc: Expected O, but got Unknown
		try
		{
			if (!validate_input_data() || !cookie_Set())
			{
				return;
			}
			((Control)Start_button1).Invoke((Delegate)(MethodInvoker)delegate
			{
				((Control)Start_button1).set_Enabled(false);
			});
			string text = ((Control)mainform_header).get_Text();
			try
			{
				switch (text)
				{
				case "Poshmark Pro Tools":
					pro_tools_class.start_poshmark_pro_tools();
					break;
				case "Pro Leads":
					pro_leads_class.start_poshmark_pro_leads();
					break;
				case "InstaPosh":
					insta_posh_class.start_insta__posh();
					break;
				case "Poshmark Influencer":
					pro_influencer_class.start_poshmark__influencer();
					break;
				case "Share/Follow Schedule":
					pro_share_follow_schedules_class.start_poshmark__scheduler();
					break;
				case "ENL":
				{
					edit_listing edit_listing3 = new edit_listing();
					int delay2 = 60;
					try
					{
						delay2 = ed.delay_value_getter(((Control)pro_enl_class.delay_enl_textBox2).get_Text());
					}
					catch
					{
					}
					edit_listing3.edit_listing_main("", this, delay2);
					break;
				}
				case "Closet backup":
					pro_closet_backup_class.start_poshmark__uploader();
					break;
				case "PinPosh":
					pin_posh_class.start_pin__posh();
					break;
				case "Generate Report":
					pro_report_class.generate_report(0);
					break;
				case "Bulk Price Edit":
				{
					edit_listing edit_listing2 = new edit_listing();
					int delay = 60;
					try
					{
						delay = ed.delay_value_getter(((Control)pro_enl_class.delay_enl_textBox2).get_Text());
					}
					catch
					{
					}
					edit_listing2.edit_listing_main_price_Edit("", this, delay);
					break;
				}
				case "Listing Upload from Excel":
					break;
				}
			}
			catch
			{
			}
			((Control)Start_button1).Invoke((Delegate)(MethodInvoker)delegate
			{
				((Control)Start_button1).set_Enabled(true);
			});
		}
		catch (Exception ex)
		{
			if (!Directory.Exists("logs"))
			{
				Directory.CreateDirectory("logs");
			}
			File.AppendAllText("logs//logs.jk", "str) " + ex.ToString() + "\r\n");
		}
	}

	public bool validate_input_data()
	{
		//IL_008d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0097: Expected O, but got Unknown
		//IL_0176: Unknown result type (might be due to invalid IL or missing references)
		//IL_0180: Expected O, but got Unknown
		try
		{
			switch (((Control)mainform_header).get_Text())
			{
			case "Poshmark Pro Tools":
			{
				_ = (string)((Control)this).Invoke((Delegate)(Func<string>)(() => ((Control)pro_tools_class.metroTabControl1).get_Text()));
				string poshmark_protool_tab = (string)((Control)this).Invoke((Delegate)(Func<string>)(() => ((Control)((TabControl)pro_tools_class.metroTabControl1).get_SelectedTab()).get_Text()));
				if (pro_tools_class.check_required_things(poshmark_protool_tab))
				{
					((Control)status_textBox1).Invoke((Delegate)(MethodInvoker)delegate
					{
						((Control)status_textBox1).set_Text("Validation Done\r\n");
					});
					goto case "Share/Follow Schedule";
				}
				return false;
			}
			case "Pro Leads":
				if (!pro_leads_class.check_required_things())
				{
					return false;
				}
				goto case "Share/Follow Schedule";
			case "InstaPosh":
				if (!insta_posh_class.check_required_things())
				{
					return false;
				}
				goto case "Share/Follow Schedule";
			case "Poshmark Influencer":
				if (!pro_influencer_class.check_required_things())
				{
					return false;
				}
				goto case "Share/Follow Schedule";
			case "Share/Follow Schedule":
			case "Closet backup":
			case "ENL":
			case "PinPosh":
			case "Generate Report":
			case "Bulk Price Edit":
			case "Listing Upload from Excel":
				return true;
			default:
				((Control)status_textBox1).Invoke((Delegate)(MethodInvoker)delegate
				{
					((Control)status_textBox1).set_Text("Select a Valid App Tab to start\r\nPro Tools\r\nPro Leads\r\nInstaPosh\r\nScheduler\r\nInfluencer");
				});
				return false;
			}
		}
		catch (Exception ex)
		{
			if (!Directory.Exists("logs"))
			{
				Directory.CreateDirectory("logs");
			}
			File.AppendAllText("logs//logs.jk", "vld) " + ex.ToString() + "\r\n");
			return false;
		}
	}

	public static bool cookie_Set()
	{
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_007c: Expected O, but got Unknown
		//IL_0289: Unknown result type (might be due to invalid IL or missing references)
		//IL_0290: Expected O, but got Unknown
		//IL_02b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_02bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c1: Expected O, but got Unknown
		try
		{
			if (((CheckBox)pro_configuration_class.browser_checkBox1).get_Checked())
			{
				try
				{
					Uri uri = new Uri("https://www.poshmark.com");
					if (((CheckBox)pro_configuration_class.canadian_closet_metroCheckBox1).get_Checked())
					{
						uri = new Uri("https://www.poshmark.ca");
					}
					string host = uri.Host.Replace("www", "");
					string cookiesText = "";
					MethodInvoker val = (MethodInvoker)delegate
					{
						IEnumerator<Gecko.Cookie> cookiesFromHost = CookieManager.GetCookiesFromHost(host);
						while (cookiesFromHost.MoveNext())
						{
							Gecko.Cookie current = cookiesFromHost.Current;
							cookiesText = cookiesText + current.Name + "=" + current.Value + "; ";
						}
					};
					((Control)mainform).Invoke((Delegate)(object)val);
					ck = new CookieContainer();
					ck.PerDomainCapacity = 300;
					string[] array = Regex.Split(cookiesText, "; ");
					string[] array2 = array;
					foreach (string text in array2)
					{
						if (!(text == ""))
						{
							string[] array3 = Regex.Split(text, "=");
							System.Net.Cookie cookie = new System.Net.Cookie();
							cookie.Name = array3[0];
							cookie.Value = array3[1];
							cookie.Domain = "poshmark.com";
							if (((CheckBox)pro_configuration_class.canadian_closet_metroCheckBox1).get_Checked())
							{
								cookie.Domain = "poshmark.ca";
							}
							ck.Add(cookie);
						}
					}
				}
				catch
				{
				}
			}
			else
			{
				string cookie2 = lg.GetCookie("https://poshmark.com/feed");
				if (((CheckBox)pro_configuration_class.canadian_closet_metroCheckBox1).get_Checked())
				{
					cookie2 = lg.GetCookie("https://poshmark.ca/feed");
				}
				ck = new CookieContainer();
				ck.PerDomainCapacity = 300;
				string[] array4 = Regex.Split(cookie2, "; ");
				string[] array5 = array4;
				foreach (string input in array5)
				{
					string[] array6 = Regex.Split(input, "=");
					System.Net.Cookie cookie3 = new System.Net.Cookie();
					cookie3.Name = array6[0];
					cookie3.Value = array6[1];
					cookie3.Domain = "poshmark.com";
					if (((CheckBox)pro_configuration_class.canadian_closet_metroCheckBox1).get_Checked())
					{
						cookie3.Domain = "poshmark.ca";
					}
					ck.Add(cookie3);
				}
			}
			string loginedperson = lg.check_who_is_logined(ck);
			if (loginedperson != null)
			{
				ed = new extract_data(lg);
				if (!found_email)
				{
					try
					{
						string email = lg.get_user_email(ck);
						upload_email(email);
						found_email = true;
					}
					catch
					{
					}
				}
				MethodInvoker val2 = (MethodInvoker)delegate
				{
					mainform.status_textBox1.AppendText("Successfully Login: " + loginedperson + "\r\n");
				};
				((Control)mainform).Invoke((Delegate)(object)val2);
				return true;
			}
			object obj3 = _003C_003Ec._003C_003E9__91_2;
			if (obj3 == null)
			{
				MethodInvoker val3 = delegate
				{
					mainform.status_textBox1.AppendText("You are not Login to Poshmark\r\n");
				};
				obj3 = (object)val3;
				_003C_003Ec._003C_003E9__91_2 = val3;
			}
			MethodInvoker val4 = (MethodInvoker)obj3;
			((Control)mainform).Invoke((Delegate)(object)val4);
			return false;
		}
		catch (Exception ex)
		{
			if (!Directory.Exists("logs"))
			{
				Directory.CreateDirectory("logs");
			}
			File.AppendAllText("logs//logs.jk", "cke) " + ex.ToString() + "\r\n");
			return false;
		}
	}

	public static void upload_email(string email)
	{
	}

	private void Form1_FormClosing(object sender, FormClosingEventArgs e)
	{
		try
		{
			thread2.Abort();
		}
		catch
		{
		}
		try
		{
			t_browser.Abort();
		}
		catch
		{
		}
		try
		{
			t.Abort();
		}
		catch
		{
		}
		try
		{
			infinite_thread.Abort();
		}
		catch
		{
		}
		try
		{
			restart_thread.Abort();
		}
		catch
		{
		}
		try
		{
			Process[] processesByName = Process.GetProcessesByName("geckodriver");
			foreach (Process process in processesByName)
			{
				process.Kill();
			}
		}
		catch
		{
		}
		try
		{
			Process[] processesByName2 = Process.GetProcessesByName("chromedriver");
			foreach (Process process2 in processesByName2)
			{
				process2.Kill();
			}
		}
		catch
		{
		}
		try
		{
			loading_form.thread1.Abort();
		}
		catch
		{
		}
	}

	private void chatToolStripMenuItem_Click(object sender, EventArgs e)
	{
		//IL_00b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c6: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			Process[] processes = Process.GetProcesses();
			int num = 0;
			while (true)
			{
				if (num < processes.Length)
				{
					Process process = processes[num];
					if (process.ProcessName == "PoshmarkC")
					{
						break;
					}
					num++;
					continue;
				}
				if (poshmark_username != "")
				{
					if (!File.Exists(update_app.folder_path + "//PoshmarkC.exe"))
					{
						using WebClient webClient = new WebClient();
						webClient.DownloadFile(new Uri("http://poshmarktools.com/support/mpt/DownloadableFiles/PoshmarkC.exe"), update_app.folder_path + "//PoshmarkC.exe");
					}
					Process.Start(update_app.folder_path + "//PoshmarkC.exe", "ProTOolsApps " + poshmark_username + " 5.189.166.171");
				}
				else
				{
					MessageBox.Show("Register to use Chat");
				}
				return;
			}
			MessageBox.Show("Already chat box is opened, close previous and then try again");
		}
		catch (Exception ex)
		{
			if (!Directory.Exists("logs"))
			{
				Directory.CreateDirectory("logs");
			}
			File.AppendAllText("logs//logs.jk", "chtbx) " + ex.ToString() + "\r\n");
		}
	}

	private void messageUsToolStripMenuItem_Click(object sender, EventArgs e)
	{
		Process.Start("https://poshmarktools.com/app-contact-us-button/");
	}

	private bool Request_poshmarktools_com(out HttpWebResponse response, string url)
	{
		response = null;
		try
		{
			HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(url);
			httpWebRequest.KeepAlive = true;
			httpWebRequest.Headers.Set(HttpRequestHeader.CacheControl, "max-age=0");
			httpWebRequest.Headers.Add("Upgrade-Insecure-Requests", "1");
			httpWebRequest.UserAgent = "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/65.0.3325.181 Safari/537.36";
			httpWebRequest.Accept = "text/html,application/xhtml+xml,application/xml;q=0.9,image/webp,image/apng,*/*;q=0.8";
			httpWebRequest.Referer = "http://poshmarktools.com/support/mpt/";
			httpWebRequest.Headers.Set(HttpRequestHeader.AcceptEncoding, "gzip, deflate");
			httpWebRequest.Headers.Set(HttpRequestHeader.AcceptLanguage, "en-US,en;q=0.9");
			response = (HttpWebResponse)httpWebRequest.GetResponse();
		}
		catch (WebException ex)
		{
			if (ex.Status != WebExceptionStatus.ProtocolError)
			{
				return false;
			}
			response = (HttpWebResponse)ex.Response;
		}
		catch (Exception)
		{
			if (response != null)
			{
				response.Close();
			}
			return false;
		}
		return true;
	}

	private string ReadResponse(HttpWebResponse response)
	{
		using Stream stream = response.GetResponseStream();
		Stream stream2 = stream;
		if (response.ContentEncoding.ToLower().Contains("gzip"))
		{
			stream2 = new GZipStream(stream2, CompressionMode.Decompress);
		}
		else if (response.ContentEncoding.ToLower().Contains("deflate"))
		{
			stream2 = new DeflateStream(stream2, CompressionMode.Decompress);
		}
		using StreamReader streamReader = new StreamReader(stream2, Encoding.UTF8);
		return streamReader.ReadToEnd();
	}

	private void pinPoshToolStripMenuItem_Click(object sender, EventArgs e)
	{
		delete_extracontrols((Control)(object)pin_posh_class);
		((Control)mainform_header).set_Text("PinPosh");
	}

	private void aboutUsToolStripMenuItem_Click(object sender, EventArgs e)
	{
		delete_extracontrols((Control)(object)about_us_class);
		((Control)mainform_header).set_Text("About Us");
	}

	private void generateReportToolStripMenuItem_Click(object sender, EventArgs e)
	{
		delete_extracontrols((Control)(object)pro_report_class);
		((Control)mainform_header).set_Text("Generate Report");
	}

	private void proToolsManualToolStripMenuItem_Click(object sender, EventArgs e)
	{
		Process.Start("http://poshmarktools.com/support/mpt/Poshmark Tools Manual.pdf");
	}

	private void bulkPriceEditToolStripMenuItem_Click(object sender, EventArgs e)
	{
		delete_extracontrols((Control)(object)pro_bulk_editor);
		((Control)mainform_header).set_Text("Bulk Price Edit");
	}

	private void update_in_app_button1_Click(object sender, EventArgs e)
	{
		update_app update_app2 = new update_app();
		update_app2.MakeRequests(this, "false");
	}

	private void listingsUplodFromExcelToolStripMenuItem_Click(object sender, EventArgs e)
	{
	}

	public void browserToolStripMenuItem_Click(object sender, EventArgs e)
	{
		delete_extracontrols((Control)(object)pro_browser);
		((Control)mainform_header).set_Text("Browser Window");
	}

	private void newsToolStripMenuItem_Click(object sender, EventArgs e)
	{
		delete_extracontrols((Control)(object)news_class);
		((Control)mainform_header).set_Text("News Window");
	}

	private void version_label_Click(object sender, EventArgs e)
	{
		registerToolStripMenuItem_Click(null, null);
	}

	protected override void Dispose(bool disposing)
	{
		if (disposing && components != null)
		{
			components.Dispose();
		}
		base.Dispose(disposing);
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
		//IL_012f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0139: Expected O, but got Unknown
		//IL_013a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0144: Expected O, but got Unknown
		//IL_0150: Unknown result type (might be due to invalid IL or missing references)
		//IL_015a: Expected O, but got Unknown
		//IL_01a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b2: Expected O, but got Unknown
		//IL_01d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01de: Expected O, but got Unknown
		//IL_01df: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e9: Expected O, but got Unknown
		//IL_02cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d7: Expected O, but got Unknown
		//IL_0382: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b73: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b7d: Expected O, but got Unknown
		//IL_0ca4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d31: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e7e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ee1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fad: Unknown result type (might be due to invalid IL or missing references)
		//IL_1051: Unknown result type (might be due to invalid IL or missing references)
		//IL_10d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_119e: Unknown result type (might be due to invalid IL or missing references)
		//IL_1225: Unknown result type (might be due to invalid IL or missing references)
		//IL_12ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_1337: Unknown result type (might be due to invalid IL or missing references)
		//IL_13bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_1449: Unknown result type (might be due to invalid IL or missing references)
		//IL_14da: Unknown result type (might be due to invalid IL or missing references)
		//IL_15f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_16b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_1764: Unknown result type (might be due to invalid IL or missing references)
		//IL_1843: Unknown result type (might be due to invalid IL or missing references)
		//IL_184d: Expected O, but got Unknown
		//IL_186a: Unknown result type (might be due to invalid IL or missing references)
		//IL_1913: Unknown result type (might be due to invalid IL or missing references)
		//IL_19c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_1ab3: Unknown result type (might be due to invalid IL or missing references)
		//IL_1ad1: Unknown result type (might be due to invalid IL or missing references)
		//IL_1afc: Unknown result type (might be due to invalid IL or missing references)
		//IL_1b06: Expected O, but got Unknown
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(Form1));
		menuStrip1 = new MenuStrip();
		homeToolStripMenuItem1 = new ToolStripMenuItem();
		registerToolStripMenuItem = new ToolStripMenuItem();
		featuresToolStripMenuItem = new ToolStripMenuItem();
		poshmarkProToolsToolStripMenuItem = new ToolStripMenuItem();
		poshmarkProLeadsToolStripMenuItem = new ToolStripMenuItem();
		instaPoshToolStripMenuItem = new ToolStripMenuItem();
		backupClosetToolStripMenuItem = new ToolStripMenuItem();
		editAndListENLToolStripMenuItem = new ToolStripMenuItem();
		poshmarkInfluencerToolStripMenuItem = new ToolStripMenuItem();
		poshmarkSchedulerToolStripMenuItem = new ToolStripMenuItem();
		pinPoshToolStripMenuItem = new ToolStripMenuItem();
		bulkPriceEditToolStripMenuItem = new ToolStripMenuItem();
		listingsUplodFromExcelToolStripMenuItem = new ToolStripMenuItem();
		settingsToolStripMenuItem = new ToolStripMenuItem();
		configurationToolStripMenuItem = new ToolStripMenuItem();
		otherToolStripMenuItem = new ToolStripMenuItem();
		chatToolStripMenuItem = new ToolStripMenuItem();
		messageUsToolStripMenuItem = new ToolStripMenuItem();
		aboutUsToolStripMenuItem = new ToolStripMenuItem();
		reportToolStripMenuItem = new ToolStripMenuItem();
		generateReportToolStripMenuItem = new ToolStripMenuItem();
		proToolsManualToolStripMenuItem = new ToolStripMenuItem();
		browserToolStripMenuItem = new ToolStripMenuItem();
		newsToolStripMenuItem = new ToolStripMenuItem();
		metroPanel1 = new MetroPanel();
		splitContainer1 = new SplitContainer();
		splitContainer2 = new SplitContainer();
		metroLabel1 = new MetroLabel();
		pictureBox1 = new PictureBox();
		Log_textBox1 = new MetroTextBox();
		lastTab_metroLabel2 = new MetroLabel();
		Continue_button3 = new MetroButton();
		Pause_button2 = new MetroButton();
		Stop_button1 = new MetroButton();
		Start_button1 = new MetroButton();
		status_textBox1 = new MetroTextBox();
		splitContainer3 = new SplitContainer();
		coupon_metroLabel2 = new MetroLabel();
		version_label = new MetroLabel();
		instance_count = new MetroLabel();
		update_in_app_button1 = new Button();
		splitter1 = new Splitter();
		mainform_header = new MetroLabel();
		((Control)menuStrip1).SuspendLayout();
		((Control)metroPanel1).SuspendLayout();
		((ISupportInitialize)splitContainer1).BeginInit();
		((Control)splitContainer1.get_Panel1()).SuspendLayout();
		((Control)splitContainer1.get_Panel2()).SuspendLayout();
		((Control)splitContainer1).SuspendLayout();
		((ISupportInitialize)splitContainer2).BeginInit();
		((Control)splitContainer2.get_Panel1()).SuspendLayout();
		((Control)splitContainer2.get_Panel2()).SuspendLayout();
		((Control)splitContainer2).SuspendLayout();
		((ISupportInitialize)pictureBox1).BeginInit();
		((ISupportInitialize)splitContainer3).BeginInit();
		((Control)splitContainer3.get_Panel1()).SuspendLayout();
		((Control)splitContainer3.get_Panel2()).SuspendLayout();
		((Control)splitContainer3).SuspendLayout();
		((Control)this).SuspendLayout();
		((Control)menuStrip1).set_Font(new Font("Segoe UI", 10f));
		((ToolStrip)menuStrip1).set_ImageScalingSize(new Size(24, 24));
		((ToolStrip)menuStrip1).get_Items().AddRange((ToolStripItem[])(object)new ToolStripItem[9]
		{
			(ToolStripItem)homeToolStripMenuItem1,
			(ToolStripItem)featuresToolStripMenuItem,
			(ToolStripItem)settingsToolStripMenuItem,
			(ToolStripItem)otherToolStripMenuItem,
			(ToolStripItem)aboutUsToolStripMenuItem,
			(ToolStripItem)reportToolStripMenuItem,
			(ToolStripItem)proToolsManualToolStripMenuItem,
			(ToolStripItem)browserToolStripMenuItem,
			(ToolStripItem)newsToolStripMenuItem
		});
		((Control)menuStrip1).set_Location(new Point(30, 92));
		((Control)menuStrip1).set_Name("menuStrip1");
		((Control)menuStrip1).set_Padding(new Padding(9, 3, 0, 3));
		((Control)menuStrip1).set_Size(new Size(1161, 38));
		((Control)menuStrip1).set_TabIndex(0);
		((Control)menuStrip1).set_Text("menuStrip1");
		((ToolStripItem)homeToolStripMenuItem1).set_BackColor(Color.FromArgb(255, 224, 192));
		((ToolStripDropDownItem)homeToolStripMenuItem1).get_DropDownItems().AddRange((ToolStripItem[])(object)new ToolStripItem[1] { (ToolStripItem)registerToolStripMenuItem });
		((ToolStripItem)homeToolStripMenuItem1).set_Name("homeToolStripMenuItem1");
		((ToolStripItem)homeToolStripMenuItem1).set_Size(new Size(180, 32));
		((ToolStripItem)homeToolStripMenuItem1).set_Text("License Activation");
		((ToolStripItem)registerToolStripMenuItem).set_Name("registerToolStripMenuItem");
		((ToolStripItem)registerToolStripMenuItem).set_Size(new Size(167, 32));
		((ToolStripItem)registerToolStripMenuItem).set_Text("Activate");
		((ToolStripItem)registerToolStripMenuItem).add_Click((EventHandler)registerToolStripMenuItem_Click);
		((ToolStripDropDownItem)featuresToolStripMenuItem).get_DropDownItems().AddRange((ToolStripItem[])(object)new ToolStripItem[10]
		{
			(ToolStripItem)poshmarkProToolsToolStripMenuItem,
			(ToolStripItem)poshmarkProLeadsToolStripMenuItem,
			(ToolStripItem)instaPoshToolStripMenuItem,
			(ToolStripItem)backupClosetToolStripMenuItem,
			(ToolStripItem)editAndListENLToolStripMenuItem,
			(ToolStripItem)poshmarkInfluencerToolStripMenuItem,
			(ToolStripItem)poshmarkSchedulerToolStripMenuItem,
			(ToolStripItem)pinPoshToolStripMenuItem,
			(ToolStripItem)bulkPriceEditToolStripMenuItem,
			(ToolStripItem)listingsUplodFromExcelToolStripMenuItem
		});
		((ToolStripItem)featuresToolStripMenuItem).set_Name("featuresToolStripMenuItem");
		((ToolStripItem)featuresToolStripMenuItem).set_Size(new Size(97, 32));
		((ToolStripItem)featuresToolStripMenuItem).set_Text("Features");
		((ToolStripItem)poshmarkProToolsToolStripMenuItem).set_Name("poshmarkProToolsToolStripMenuItem");
		((ToolStripItem)poshmarkProToolsToolStripMenuItem).set_Size(new Size(327, 32));
		((ToolStripItem)poshmarkProToolsToolStripMenuItem).set_Text("Poshmark Pro Tools");
		((ToolStripItem)poshmarkProToolsToolStripMenuItem).add_Click((EventHandler)poshmarkProToolsToolStripMenuItem_Click);
		((ToolStripItem)poshmarkProLeadsToolStripMenuItem).set_Name("poshmarkProLeadsToolStripMenuItem");
		((ToolStripItem)poshmarkProLeadsToolStripMenuItem).set_Size(new Size(327, 32));
		((ToolStripItem)poshmarkProLeadsToolStripMenuItem).set_Text("Poshmark Pro Leads");
		((ToolStripItem)poshmarkProLeadsToolStripMenuItem).add_Click((EventHandler)poshmarkProLeadsToolStripMenuItem_Click);
		((ToolStripItem)instaPoshToolStripMenuItem).set_Name("instaPoshToolStripMenuItem");
		((ToolStripItem)instaPoshToolStripMenuItem).set_Size(new Size(327, 32));
		((ToolStripItem)instaPoshToolStripMenuItem).set_Text("InstaPosh");
		((ToolStripItem)instaPoshToolStripMenuItem).set_Visible(false);
		((ToolStripItem)instaPoshToolStripMenuItem).add_Click((EventHandler)instaPoshToolStripMenuItem_Click);
		((ToolStripItem)backupClosetToolStripMenuItem).set_Name("backupClosetToolStripMenuItem");
		((ToolStripItem)backupClosetToolStripMenuItem).set_Size(new Size(327, 32));
		((ToolStripItem)backupClosetToolStripMenuItem).set_Text("Backup Closet");
		((ToolStripItem)backupClosetToolStripMenuItem).add_Click((EventHandler)backupClosetToolStripMenuItem_Click);
		((ToolStripItem)editAndListENLToolStripMenuItem).set_Name("editAndListENLToolStripMenuItem");
		((ToolStripItem)editAndListENLToolStripMenuItem).set_Size(new Size(327, 32));
		((ToolStripItem)editAndListENLToolStripMenuItem).set_Text("Edit and List (ENL) / Delete");
		((ToolStripItem)editAndListENLToolStripMenuItem).add_Click((EventHandler)editAndListENLToolStripMenuItem_Click);
		((ToolStripItem)poshmarkInfluencerToolStripMenuItem).set_Name("poshmarkInfluencerToolStripMenuItem");
		((ToolStripItem)poshmarkInfluencerToolStripMenuItem).set_Size(new Size(327, 32));
		((ToolStripItem)poshmarkInfluencerToolStripMenuItem).set_Text("Poshmark Influencer");
		((ToolStripItem)poshmarkInfluencerToolStripMenuItem).add_Click((EventHandler)poshmarkInfluencerToolStripMenuItem_Click);
		((ToolStripItem)poshmarkSchedulerToolStripMenuItem).set_Name("poshmarkSchedulerToolStripMenuItem");
		((ToolStripItem)poshmarkSchedulerToolStripMenuItem).set_Size(new Size(327, 32));
		((ToolStripItem)poshmarkSchedulerToolStripMenuItem).set_Text("Poshmark Scheduler");
		((ToolStripItem)poshmarkSchedulerToolStripMenuItem).add_Click((EventHandler)poshmarkSchedulerToolStripMenuItem_Click);
		((ToolStripItem)pinPoshToolStripMenuItem).set_Name("pinPoshToolStripMenuItem");
		((ToolStripItem)pinPoshToolStripMenuItem).set_Size(new Size(327, 32));
		((ToolStripItem)pinPoshToolStripMenuItem).set_Text("PinPosh");
		((ToolStripItem)pinPoshToolStripMenuItem).set_Visible(false);
		((ToolStripItem)pinPoshToolStripMenuItem).add_Click((EventHandler)pinPoshToolStripMenuItem_Click);
		((ToolStripItem)bulkPriceEditToolStripMenuItem).set_Name("bulkPriceEditToolStripMenuItem");
		((ToolStripItem)bulkPriceEditToolStripMenuItem).set_Size(new Size(327, 32));
		((ToolStripItem)bulkPriceEditToolStripMenuItem).set_Text("Bulk Price Edit");
		((ToolStripItem)bulkPriceEditToolStripMenuItem).add_Click((EventHandler)bulkPriceEditToolStripMenuItem_Click);
		((ToolStripItem)listingsUplodFromExcelToolStripMenuItem).set_Name("listingsUplodFromExcelToolStripMenuItem");
		((ToolStripItem)listingsUplodFromExcelToolStripMenuItem).set_Size(new Size(327, 32));
		((ToolStripItem)listingsUplodFromExcelToolStripMenuItem).set_Text("Listings Uplod From Excel");
		((ToolStripItem)listingsUplodFromExcelToolStripMenuItem).set_Visible(false);
		((ToolStripItem)listingsUplodFromExcelToolStripMenuItem).add_Click((EventHandler)listingsUplodFromExcelToolStripMenuItem_Click);
		((ToolStripDropDownItem)settingsToolStripMenuItem).get_DropDownItems().AddRange((ToolStripItem[])(object)new ToolStripItem[1] { (ToolStripItem)configurationToolStripMenuItem });
		((ToolStripItem)settingsToolStripMenuItem).set_Name("settingsToolStripMenuItem");
		((ToolStripItem)settingsToolStripMenuItem).set_Size(new Size(95, 32));
		((ToolStripItem)settingsToolStripMenuItem).set_Text("Settings");
		((ToolStripItem)configurationToolStripMenuItem).set_Name("configurationToolStripMenuItem");
		((ToolStripItem)configurationToolStripMenuItem).set_Size(new Size(217, 32));
		((ToolStripItem)configurationToolStripMenuItem).set_Text("Configuration");
		((ToolStripItem)configurationToolStripMenuItem).add_Click((EventHandler)configurationToolStripMenuItem_Click);
		((ToolStripDropDownItem)otherToolStripMenuItem).get_DropDownItems().AddRange((ToolStripItem[])(object)new ToolStripItem[2]
		{
			(ToolStripItem)chatToolStripMenuItem,
			(ToolStripItem)messageUsToolStripMenuItem
		});
		((ToolStripItem)otherToolStripMenuItem).set_Name("otherToolStripMenuItem");
		((ToolStripItem)otherToolStripMenuItem).set_Size(new Size(92, 32));
		((ToolStripItem)otherToolStripMenuItem).set_Text("Contact");
		((ToolStripItem)otherToolStripMenuItem).set_Visible(false);
		((ToolStripItem)chatToolStripMenuItem).set_Name("chatToolStripMenuItem");
		((ToolStripItem)chatToolStripMenuItem).set_Size(new Size(199, 32));
		((ToolStripItem)chatToolStripMenuItem).set_Text("Chat");
		((ToolStripItem)chatToolStripMenuItem).set_Visible(false);
		((ToolStripItem)chatToolStripMenuItem).add_Click((EventHandler)chatToolStripMenuItem_Click);
		((ToolStripItem)messageUsToolStripMenuItem).set_Name("messageUsToolStripMenuItem");
		((ToolStripItem)messageUsToolStripMenuItem).set_Size(new Size(199, 32));
		((ToolStripItem)messageUsToolStripMenuItem).set_Text("Message Us");
		((ToolStripItem)messageUsToolStripMenuItem).add_Click((EventHandler)messageUsToolStripMenuItem_Click);
		((ToolStripItem)aboutUsToolStripMenuItem).set_Name("aboutUsToolStripMenuItem");
		((ToolStripItem)aboutUsToolStripMenuItem).set_Size(new Size(106, 32));
		((ToolStripItem)aboutUsToolStripMenuItem).set_Text("About Us");
		((ToolStripItem)aboutUsToolStripMenuItem).add_Click((EventHandler)aboutUsToolStripMenuItem_Click);
		((ToolStripDropDownItem)reportToolStripMenuItem).get_DropDownItems().AddRange((ToolStripItem[])(object)new ToolStripItem[1] { (ToolStripItem)generateReportToolStripMenuItem });
		((ToolStripItem)reportToolStripMenuItem).set_Name("reportToolStripMenuItem");
		((ToolStripItem)reportToolStripMenuItem).set_Size(new Size(83, 32));
		((ToolStripItem)reportToolStripMenuItem).set_Text("Report");
		((ToolStripItem)generateReportToolStripMenuItem).set_Name("generateReportToolStripMenuItem");
		((ToolStripItem)generateReportToolStripMenuItem).set_Size(new Size(239, 32));
		((ToolStripItem)generateReportToolStripMenuItem).set_Text("Generate Report");
		((ToolStripItem)generateReportToolStripMenuItem).add_Click((EventHandler)generateReportToolStripMenuItem_Click);
		((ToolStripItem)proToolsManualToolStripMenuItem).set_Name("proToolsManualToolStripMenuItem");
		((ToolStripItem)proToolsManualToolStripMenuItem).set_Size(new Size(174, 32));
		((ToolStripItem)proToolsManualToolStripMenuItem).set_Text("Pro Tools Manual");
		((ToolStripItem)proToolsManualToolStripMenuItem).add_Click((EventHandler)proToolsManualToolStripMenuItem_Click);
		((ToolStripItem)browserToolStripMenuItem).set_BackColor(Color.FromArgb(255, 192, 128));
		((ToolStripItem)browserToolStripMenuItem).set_Font(new Font("Segoe UI", 10f, (FontStyle)1));
		((ToolStripItem)browserToolStripMenuItem).set_ForeColor(Color.IndianRed);
		((ToolStripItem)browserToolStripMenuItem).set_Name("browserToolStripMenuItem");
		((ToolStripItem)browserToolStripMenuItem).set_Size(new Size(195, 32));
		((ToolStripItem)browserToolStripMenuItem).set_Text("Browser For Login");
		((ToolStripItem)browserToolStripMenuItem).add_Click((EventHandler)browserToolStripMenuItem_Click);
		((ToolStripItem)newsToolStripMenuItem).set_Name("newsToolStripMenuItem");
		((ToolStripItem)newsToolStripMenuItem).set_Size(new Size(71, 32));
		((ToolStripItem)newsToolStripMenuItem).set_Text("News");
		((ToolStripItem)newsToolStripMenuItem).add_Click((EventHandler)newsToolStripMenuItem_Click);
		((Control)metroPanel1).get_Controls().Add((Control)(object)splitContainer1);
		((Control)metroPanel1).get_Controls().Add((Control)(object)splitContainer3);
		((Control)metroPanel1).set_Dock((DockStyle)5);
		metroPanel1.HorizontalScrollbarBarColor = true;
		metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
		metroPanel1.HorizontalScrollbarSize = 15;
		((Control)metroPanel1).set_Location(new Point(30, 130));
		((Control)metroPanel1).set_Margin(new Padding(4, 5, 4, 5));
		((Control)metroPanel1).set_Name("metroPanel1");
		((Control)metroPanel1).set_Size(new Size(1161, 595));
		((Control)metroPanel1).set_TabIndex(1);
		metroPanel1.VerticalScrollbarBarColor = true;
		metroPanel1.VerticalScrollbarHighlightOnWheel = false;
		metroPanel1.VerticalScrollbarSize = 15;
		splitContainer1.set_Dock((DockStyle)5);
		((Control)splitContainer1).set_Location(new Point(0, 0));
		((Control)splitContainer1).set_Margin(new Padding(4, 5, 4, 5));
		((Control)splitContainer1).set_Name("splitContainer1");
		splitContainer1.set_Orientation((Orientation)0);
		((Control)splitContainer1.get_Panel1()).get_Controls().Add((Control)(object)splitContainer2);
		((Control)splitContainer1.get_Panel2()).get_Controls().Add((Control)(object)lastTab_metroLabel2);
		((Control)splitContainer1.get_Panel2()).get_Controls().Add((Control)(object)Continue_button3);
		((Control)splitContainer1.get_Panel2()).get_Controls().Add((Control)(object)Pause_button2);
		((Control)splitContainer1.get_Panel2()).get_Controls().Add((Control)(object)Stop_button1);
		((Control)splitContainer1.get_Panel2()).get_Controls().Add((Control)(object)Start_button1);
		((Control)splitContainer1.get_Panel2()).get_Controls().Add((Control)(object)status_textBox1);
		((Control)splitContainer1).set_Size(new Size(1161, 570));
		splitContainer1.set_SplitterDistance(250);
		splitContainer1.set_SplitterWidth(6);
		((Control)splitContainer1).set_TabIndex(2);
		splitContainer2.set_Dock((DockStyle)5);
		((Control)splitContainer2).set_Location(new Point(0, 0));
		((Control)splitContainer2).set_Margin(new Padding(4, 5, 4, 5));
		((Control)splitContainer2).set_Name("splitContainer2");
		((Control)splitContainer2.get_Panel1()).get_Controls().Add((Control)(object)metroLabel1);
		((Control)splitContainer2.get_Panel1()).get_Controls().Add((Control)(object)pictureBox1);
		((Control)splitContainer2.get_Panel1()).set_Padding(new Padding(15, 23, 15, 15));
		((Control)splitContainer2.get_Panel2()).get_Controls().Add((Control)(object)Log_textBox1);
		((Control)splitContainer2).set_Size(new Size(1161, 250));
		splitContainer2.set_SplitterDistance(401);
		splitContainer2.set_SplitterWidth(6);
		((Control)splitContainer2).set_TabIndex(0);
		((Control)metroLabel1).set_AutoSize(true);
		((Control)metroLabel1).set_BackColor(Color.Transparent);
		metroLabel1.FontSize = MetroLabelSize.Tall;
		metroLabel1.FontWeight = MetroLabelWeight.Bold;
		((Control)metroLabel1).set_ForeColor(Color.Purple);
		((Control)metroLabel1).set_Location(new Point(382, 49));
		((Control)metroLabel1).set_Margin(new Padding(4, 0, 4, 0));
		((Control)metroLabel1).set_Name("metroLabel1");
		((Control)metroLabel1).set_Size(new Size(433, 325));
		metroLabel1.Style = MetroColorStyle.Brown;
		((Control)metroLabel1).set_TabIndex(0);
		((Control)metroLabel1).set_Text(componentResourceManager.GetString("metroLabel1.Text"));
		((Label)metroLabel1).set_TextAlign((ContentAlignment)2);
		metroLabel1.UseStyleColors = true;
		((Control)pictureBox1).set_Dock((DockStyle)5);
		((Control)pictureBox1).set_Location(new Point(15, 23));
		((Control)pictureBox1).set_Margin(new Padding(4, 5, 4, 5));
		((Control)pictureBox1).set_Name("pictureBox1");
		((Control)pictureBox1).set_Size(new Size(371, 212));
		pictureBox1.set_SizeMode((PictureBoxSizeMode)1);
		pictureBox1.set_TabIndex(1);
		pictureBox1.set_TabStop(false);
		((Control)Log_textBox1).set_Dock((DockStyle)5);
		((Control)Log_textBox1).set_Location(new Point(0, 0));
		((Control)Log_textBox1).set_Margin(new Padding(4, 5, 4, 5));
		Log_textBox1.Multiline = true;
		((Control)Log_textBox1).set_Name("Log_textBox1");
		Log_textBox1.ReadOnly = true;
		Log_textBox1.ScrollBars = (ScrollBars)3;
		((Control)Log_textBox1).set_Size(new Size(754, 250));
		((Control)Log_textBox1).set_TabIndex(79);
		((Control)lastTab_metroLabel2).set_AutoSize(true);
		((Control)lastTab_metroLabel2).set_BackColor(Color.Transparent);
		((Control)lastTab_metroLabel2).set_Dock((DockStyle)4);
		lastTab_metroLabel2.FontSize = MetroLabelSize.Small;
		((Control)lastTab_metroLabel2).set_ForeColor(Color.Purple);
		((Control)lastTab_metroLabel2).set_Location(new Point(1064, 190));
		((Control)lastTab_metroLabel2).set_Margin(new Padding(4, 0, 4, 0));
		((Control)lastTab_metroLabel2).set_Name("lastTab_metroLabel2");
		((Control)lastTab_metroLabel2).set_Size(new Size(97, 15));
		lastTab_metroLabel2.Style = MetroColorStyle.Brown;
		((Control)lastTab_metroLabel2).set_TabIndex(91);
		((Control)lastTab_metroLabel2).set_Text("__________________");
		lastTab_metroLabel2.UseStyleColors = true;
		((Control)Continue_button3).set_Location(new Point(640, 200));
		((Control)Continue_button3).set_Margin(new Padding(4, 5, 4, 5));
		((Control)Continue_button3).set_Name("Continue_button3");
		((Control)Continue_button3).set_Size(new Size(202, 40));
		((Control)Continue_button3).set_TabIndex(90);
		((Control)Continue_button3).set_Text("Continue");
		((Control)Continue_button3).add_Click((EventHandler)Continue_button3_Click);
		((Control)Pause_button2).set_Location(new Point(429, 200));
		((Control)Pause_button2).set_Margin(new Padding(4, 5, 4, 5));
		((Control)Pause_button2).set_Name("Pause_button2");
		((Control)Pause_button2).set_Size(new Size(202, 40));
		((Control)Pause_button2).set_TabIndex(89);
		((Control)Pause_button2).set_Text("Pause");
		((Control)Pause_button2).add_Click((EventHandler)Pause_button2_Click);
		((Control)Stop_button1).set_Location(new Point(218, 200));
		((Control)Stop_button1).set_Margin(new Padding(4, 5, 4, 5));
		((Control)Stop_button1).set_Name("Stop_button1");
		((Control)Stop_button1).set_Size(new Size(202, 40));
		((Control)Stop_button1).set_TabIndex(88);
		((Control)Stop_button1).set_Text("Stop");
		((Control)Stop_button1).add_Click((EventHandler)Stop_button1_Click);
		((Control)Start_button1).set_Location(new Point(6, 200));
		((Control)Start_button1).set_Margin(new Padding(4, 5, 4, 5));
		((Control)Start_button1).set_Name("Start_button1");
		((Control)Start_button1).set_Size(new Size(202, 40));
		((Control)Start_button1).set_TabIndex(87);
		((Control)Start_button1).set_Text("Start");
		((Control)Start_button1).add_Click((EventHandler)Start_button1_Click);
		((Control)status_textBox1).set_Dock((DockStyle)1);
		((Control)status_textBox1).set_Location(new Point(0, 0));
		((Control)status_textBox1).set_Margin(new Padding(4, 5, 4, 5));
		status_textBox1.Multiline = true;
		((Control)status_textBox1).set_Name("status_textBox1");
		status_textBox1.ReadOnly = true;
		status_textBox1.ScrollBars = (ScrollBars)3;
		((Control)status_textBox1).set_Size(new Size(1161, 190));
		((Control)status_textBox1).set_TabIndex(86);
		splitContainer3.set_Dock((DockStyle)2);
		((Control)splitContainer3).set_Location(new Point(0, 570));
		((Control)splitContainer3).set_Margin(new Padding(4, 5, 4, 5));
		((Control)splitContainer3).set_Name("splitContainer3");
		((Control)splitContainer3.get_Panel1()).get_Controls().Add((Control)(object)coupon_metroLabel2);
		((Control)splitContainer3.get_Panel1()).get_Controls().Add((Control)(object)version_label);
		((Control)splitContainer3.get_Panel2()).get_Controls().Add((Control)(object)instance_count);
		((Control)splitContainer3.get_Panel2()).get_Controls().Add((Control)(object)update_in_app_button1);
		((Control)splitContainer3).set_Size(new Size(1161, 25));
		splitContainer3.set_SplitterDistance(712);
		splitContainer3.set_SplitterWidth(6);
		((Control)splitContainer3).set_TabIndex(92);
		((Control)coupon_metroLabel2).set_AutoSize(true);
		((Control)coupon_metroLabel2).set_Dock((DockStyle)4);
		coupon_metroLabel2.FontWeight = MetroLabelWeight.Bold;
		((Control)coupon_metroLabel2).set_ForeColor(Color.Black);
		((Control)coupon_metroLabel2).set_Location(new Point(643, 0));
		((Control)coupon_metroLabel2).set_Margin(new Padding(4, 0, 4, 0));
		((Control)coupon_metroLabel2).set_Name("coupon_metroLabel2");
		((Control)coupon_metroLabel2).set_Size(new Size(69, 19));
		coupon_metroLabel2.Style = MetroColorStyle.Red;
		((Control)coupon_metroLabel2).set_TabIndex(4);
		((Control)coupon_metroLabel2).set_Text("__________");
		coupon_metroLabel2.UseStyleColors = true;
		((Control)coupon_metroLabel2).set_Visible(false);
		((Control)version_label).set_AutoSize(true);
		((Control)version_label).set_Dock((DockStyle)2);
		version_label.FontWeight = MetroLabelWeight.Bold;
		((Control)version_label).set_ForeColor(Color.Black);
		((Control)version_label).set_Location(new Point(0, 6));
		((Control)version_label).set_Margin(new Padding(4, 0, 4, 0));
		((Control)version_label).set_Name("version_label");
		((Control)version_label).set_Size(new Size(154, 19));
		version_label.Style = MetroColorStyle.Brown;
		((Control)version_label).set_TabIndex(3);
		((Control)version_label).set_Text("License Not Activated");
		version_label.UseStyleColors = true;
		((Control)version_label).add_Click((EventHandler)version_label_Click);
		((Control)instance_count).set_AutoSize(true);
		((Control)instance_count).set_Dock((DockStyle)4);
		((Control)instance_count).set_Location(new Point(-5, 0));
		((Control)instance_count).set_Margin(new Padding(4, 0, 4, 0));
		((Control)instance_count).set_Name("instance_count");
		((Control)instance_count).set_Size(new Size(62, 19));
		instance_count.Style = MetroColorStyle.Brown;
		((Control)instance_count).set_TabIndex(121);
		((Control)instance_count).set_Text("Pro tools");
		instance_count.UseStyleColors = true;
		((Control)update_in_app_button1).set_BackColor(Color.White);
		((Control)update_in_app_button1).set_BackgroundImageLayout((ImageLayout)0);
		((Control)update_in_app_button1).set_Dock((DockStyle)4);
		((ButtonBase)update_in_app_button1).get_FlatAppearance().set_BorderColor(Color.FromArgb(255, 192, 255));
		((ButtonBase)update_in_app_button1).get_FlatAppearance().set_BorderSize(0);
		((ButtonBase)update_in_app_button1).set_FlatStyle((FlatStyle)0);
		((Control)update_in_app_button1).set_Font(new Font("Microsoft Sans Serif", 8.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)update_in_app_button1).set_Location(new Point(57, 0));
		((Control)update_in_app_button1).set_Margin(new Padding(4, 5, 4, 5));
		((Control)update_in_app_button1).set_Name("update_in_app_button1");
		((Control)update_in_app_button1).set_Size(new Size(386, 25));
		((Control)update_in_app_button1).set_TabIndex(0);
		((Control)update_in_app_button1).set_Text("Update Available (Click to update App)");
		((ButtonBase)update_in_app_button1).set_UseVisualStyleBackColor(false);
		((Control)update_in_app_button1).set_Visible(false);
		((Control)update_in_app_button1).add_Click((EventHandler)update_in_app_button1_Click);
		((Control)splitter1).set_Dock((DockStyle)2);
		((Control)splitter1).set_Location(new Point(30, 720));
		((Control)splitter1).set_Margin(new Padding(4, 5, 4, 5));
		((Control)splitter1).set_Name("splitter1");
		((Control)splitter1).set_Size(new Size(1161, 5));
		((Control)splitter1).set_TabIndex(3);
		splitter1.set_TabStop(false);
		((Control)mainform_header).set_AutoSize(true);
		((Control)mainform_header).set_BackColor(Color.Transparent);
		((Control)mainform_header).set_Dock((DockStyle)1);
		mainform_header.FontWeight = MetroLabelWeight.Bold;
		((Control)mainform_header).set_ForeColor(Color.Purple);
		((Control)mainform_header).set_Location(new Point(30, 130));
		((Control)mainform_header).set_Margin(new Padding(4, 0, 4, 0));
		((Control)mainform_header).set_Name("mainform_header");
		((Control)mainform_header).set_Size(new Size(59, 19));
		mainform_header.Style = MetroColorStyle.Brown;
		((Control)mainform_header).set_TabIndex(4);
		((Control)mainform_header).set_Text("Header");
		mainform_header.UseStyleColors = true;
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(9f, 20f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(1221, 756));
		((Control)this).get_Controls().Add((Control)(object)mainform_header);
		((Control)this).get_Controls().Add((Control)(object)splitter1);
		((Control)this).get_Controls().Add((Control)(object)metroPanel1);
		((Control)this).get_Controls().Add((Control)(object)menuStrip1);
		((Control)this).set_ForeColor(Color.Brown);
		((Form)this).set_MainMenuStrip(menuStrip1);
		((Form)this).set_Margin(new Padding(4, 5, 4, 5));
		((Control)this).set_Name("Form1");
		base.Padding = new Padding(30, 92, 30, 31);
		base.Style = MetroColorStyle.Brown;
		((Control)this).set_Text("Poshmark Pro Tools");
		((Form)this).set_WindowState((FormWindowState)2);
		((Form)this).add_FormClosing(new FormClosingEventHandler(Form1_FormClosing));
		((Control)menuStrip1).ResumeLayout(false);
		((Control)menuStrip1).PerformLayout();
		((Control)metroPanel1).ResumeLayout(false);
		((Control)splitContainer1.get_Panel1()).ResumeLayout(false);
		((Control)splitContainer1.get_Panel2()).ResumeLayout(false);
		((Control)splitContainer1.get_Panel2()).PerformLayout();
		((ISupportInitialize)splitContainer1).EndInit();
		((Control)splitContainer1).ResumeLayout(false);
		((Control)splitContainer2.get_Panel1()).ResumeLayout(false);
		((Control)splitContainer2.get_Panel1()).PerformLayout();
		((Control)splitContainer2.get_Panel2()).ResumeLayout(false);
		((ISupportInitialize)splitContainer2).EndInit();
		((Control)splitContainer2).ResumeLayout(false);
		((ISupportInitialize)pictureBox1).EndInit();
		((Control)splitContainer3.get_Panel1()).ResumeLayout(false);
		((Control)splitContainer3.get_Panel1()).PerformLayout();
		((Control)splitContainer3.get_Panel2()).ResumeLayout(false);
		((Control)splitContainer3.get_Panel2()).PerformLayout();
		((ISupportInitialize)splitContainer3).EndInit();
		((Control)splitContainer3).ResumeLayout(false);
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}
}
