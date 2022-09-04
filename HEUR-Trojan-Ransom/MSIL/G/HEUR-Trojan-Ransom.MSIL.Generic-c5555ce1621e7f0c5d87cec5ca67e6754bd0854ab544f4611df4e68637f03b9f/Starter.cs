using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Net;
using System.Text;
using System.Windows.Forms;
using System.Windows.Forms.Layout;
using System.Xml;
using Microsoft.Win32;

public sealed class Starter : Form
{
	private string string_0;

	private string string_1;

	private string string_2 = "none";

	private string string_3;

	private string string_4 = "none";

	private string string_5 = string.Empty;

	private long long_0;

	private int int_0;

	private int int_1;

	private string string_6 = "us";

	private bool bool_0 = true;

	private bool bool_1 = true;

	private string string_7 = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles), "Downvision");

	private string string_8 = Path.GetTempPath();

	private string string_9 = "41";

	private string string_10 = string.Empty;

	private string string_11 = "0";

	private WebClient webClient_0 = new WebClient();

	private string string_12 = string.Empty;

	private Image image_0 = (Image)(object)Class1.smethod_4();

	private IContainer icontainer_0;

	private Label status;

	private Label FileName;

	private Panel panel1;

	private Panel panel2;

	private Label label2;

	private Panel EUpan;

	private CheckBox checkBox3;

	private CheckBox checkBox2;

	private CheckBox checkBox1;

	private ToolTip toolTip_0;

	private CheckBox EU1;

	private LinkLabel linkLabel1;

	private Label label3;

	private Panel panel3;

	private Panel panel4;

	private Panel panel5;

	private CheckBox AssocEU;

	private Button button1;

	private CheckBox Assoc;

	private Panel EMPTYpanel;

	private CheckBox HomePage;

	private Label label4;

	private Label label6;

	private Label label14;

	private Label label13;

	private Label label12;

	private Label label11;

	private Label label10;

	private Panel USpan;

	private Panel panel6;

	private Label label1;

	private CheckBox US2;

	private Label AssocUSl;

	private Label UShomel;

	private Label US1l;

	private Label UStbl;

	private Label USsearchl;

	private CheckBox AssocUS;

	private Panel panel7;

	private LinkLabel linkLabel2;

	private Label label15;

	private CheckBox US1;

	private CheckBox UShp;

	private CheckBox USsrch;

	private CheckBox UStb;

	public Starter()
	{
		InitializeComponent();
	}

	private void method_0(object sender, PaintEventArgs e)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Expected O, but got Unknown
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Expected O, but got Unknown
		CheckBox val = (CheckBox)sender;
		if (val.get_Checked())
		{
			image_0 = (Image)(object)Class1.smethod_4();
		}
		else
		{
			image_0 = (Image)(object)Class1.smethod_6();
		}
		if ((bool)((Control)val).get_Tag())
		{
			image_0 = (Image)(object)Class1.smethod_5();
		}
		Rectangle rectangle = new Rectangle(0, 0, 18, 18);
		Brush val2 = (Brush)new SolidBrush(((Control)this).get_BackColor());
		e.get_Graphics().FillRectangle(val2, rectangle);
		e.get_Graphics().DrawImageUnscaledAndClipped(image_0, rectangle);
	}

	private void method_1(object sender, EventArgs e)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		((Control)(CheckBox)sender).set_Tag((object)true);
	}

	private void method_2(object sender, EventArgs e)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		((Control)(CheckBox)sender).set_Tag((object)false);
	}

	private void method_3(object sender, EventArgs e)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		if (!((CheckBox)sender).get_Checked())
		{
			((Control)(CheckBox)sender).set_Tag((object)false);
		}
	}

	private string method_4(string string_13)
	{
		if (string_13.Length > 26)
		{
			if (20 < string_13.Length - 26)
			{
				string_13 = string_13.Substring(0, 26) + "\n" + string_13.Substring(26, 20) + "...";
				toolTip_0.set_Tag((object)1);
			}
			else
			{
				string_13 = string_13.Substring(0, 26) + "\n" + string_13.Substring(26, string_13.Length - 26);
			}
		}
		return string_13;
	}

	private void Starter_Load(object sender, EventArgs e)
	{
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Expected O, but got Unknown
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Expected O, but got Unknown
		//IL_00ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d4: Expected O, but got Unknown
		//IL_0104: Unknown result type (might be due to invalid IL or missing references)
		//IL_010e: Expected O, but got Unknown
		//IL_0183: Unknown result type (might be due to invalid IL or missing references)
		//IL_018a: Expected O, but got Unknown
		//IL_01c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ca: Expected O, but got Unknown
		//IL_029b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0321: Unknown result type (might be due to invalid IL or missing references)
		foreach (Control item in (ArrangedElementCollection)((Control)USpan).get_Controls())
		{
			Control val = item;
			CheckBox val2 = (CheckBox)(object)((val is CheckBox) ? val : null);
			if (val2 != null)
			{
				((Control)val2).set_Tag((object)false);
				val2.add_CheckedChanged((EventHandler)method_3);
				((Control)val2).add_Paint(new PaintEventHandler(method_0));
				((Control)val2).add_MouseEnter((EventHandler)method_1);
				((Control)val2).add_MouseLeave((EventHandler)method_2);
				((Control)val2).set_AutoSize(false);
				((Control)val2).set_Width(18);
			}
		}
		foreach (Control item2 in (ArrangedElementCollection)((Control)EMPTYpanel).get_Controls())
		{
			Control val3 = item2;
			CheckBox val4 = (CheckBox)(object)((val3 is CheckBox) ? val3 : null);
			if (val4 != null)
			{
				((Control)val4).set_Tag((object)false);
				val4.add_CheckedChanged((EventHandler)method_3);
				((Control)val4).add_Paint(new PaintEventHandler(method_0));
				((Control)val4).add_MouseEnter((EventHandler)method_1);
				((Control)val4).add_MouseLeave((EventHandler)method_2);
				((Control)val4).set_AutoSize(false);
				((Control)val4).set_Width(18);
			}
		}
		foreach (Control item3 in (ArrangedElementCollection)((Control)EUpan).get_Controls())
		{
			Control val5 = item3;
			CheckBox val6 = (CheckBox)(object)((val5 is CheckBox) ? val5 : null);
			if (val6 != null)
			{
				((Control)val6).set_Tag((object)false);
				val6.add_CheckedChanged((EventHandler)method_3);
				((Control)val6).add_Paint(new PaintEventHandler(method_0));
				((Control)val6).add_MouseEnter((EventHandler)method_1);
				((Control)val6).add_MouseLeave((EventHandler)method_2);
				((Control)val6).set_AutoSize(false);
				((Control)val6).set_Width(18);
			}
		}
		toolTip_0.set_Tag((object)0);
		try
		{
			bool_0 = false;
			string[] array = new string[2] { "DownVision.exe", "update.exe" };
			string[] array2 = array;
			foreach (string path in array2)
			{
				if (!File.Exists(Path.Combine(string_7, path)))
				{
					bool_0 = true;
				}
			}
		}
		catch
		{
			MessageBox.Show("Error");
		}
		if (!(Class1.smethod_9() == "pppppppppppppppppppp") && long.Parse(Class1.smethod_9()) != 0L)
		{
			WebClient webClient = new WebClient();
			webClient.Encoding = Encoding.UTF8;
			long_0 = long.Parse(Class1.smethod_9());
			string xml = string.Empty;
			try
			{
				xml = webClient.DownloadString("http://stat.downvision.com/up.php?id=" + long_0);
			}
			catch
			{
				MessageBox.Show("Failed to get file information. Check your firewall or try again later.");
				method_5();
			}
			try
			{
				XmlDocument xmlDocument = new XmlDocument();
				xmlDocument.LoadXml(xml);
				foreach (XmlNode childNode in xmlDocument.DocumentElement!.ChildNodes)
				{
					string name;
					if ((name = childNode.Name) == null)
					{
						continue;
					}
					if (Class2.dictionary_0 == null)
					{
						Class2.dictionary_0 = new Dictionary<string, int>(11)
						{
							{ "name", 0 },
							{ "size", 1 },
							{ "url", 2 },
							{ "geo", 3 },
							{ "homepage", 4 },
							{ "homelabel", 5 },
							{ "country", 6 },
							{ "saff", 7 },
							{ "affilID", 8 },
							{ "ttl", 9 },
							{ "keyword", 10 }
						};
					}
					if (!Class2.dictionary_0.TryGetValue(name, out var value))
					{
						continue;
					}
					switch (value)
					{
					case 0:
						string_0 = childNode.InnerText;
						break;
					case 1:
						string_1 = childNode.InnerText;
						break;
					case 2:
						string_2 = childNode.InnerText;
						break;
					case 3:
						if (childNode.InnerText.Length > 0)
						{
							string_6 = childNode.InnerText.ToLower();
						}
						break;
					case 4:
						if (childNode.InnerText.Length > 0)
						{
							string_4 = childNode.InnerText.ToLower();
						}
						break;
					case 5:
						if (childNode.InnerText.Length > 0)
						{
							string_5 = childNode.InnerText;
						}
						break;
					case 6:
						string_10 = childNode.InnerText;
						break;
					case 7:
						string_11 = childNode.InnerText;
						break;
					case 8:
						string_9 = childNode.InnerText;
						break;
					case 9:
						int_0 = int.Parse(childNode.InnerText);
						break;
					case 10:
						string_12 = childNode.InnerText;
						break;
					}
				}
				((Control)FileName).set_Text(string_0);
				((Control)status).set_Text("Ready for download file:");
			}
			catch
			{
				method_5();
			}
		}
		else
		{
			method_5();
		}
		switch (string_6)
		{
		case "eu":
			((Control)EUpan).set_Visible(true);
			break;
		case "us":
			((Control)USpan).set_Visible(true);
			break;
		default:
			((Control)this).set_Height(435);
			((Control)EMPTYpanel).set_Visible(true);
			((Control)Assoc).set_Visible(true);
			((Control)label6).set_Text(string_5);
			if (string_4 == "none")
			{
				((Control)label6).set_Visible(false);
				HomePage.set_Checked(false);
				((Control)HomePage).set_Visible(false);
			}
			break;
		}
		string path2 = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Personal), "DownVision\\starturl.dat");
		if (File.Exists(path2))
		{
			try
			{
				File.Delete(path2);
			}
			catch
			{
			}
		}
	}

	private void method_5()
	{
		if (bool_0)
		{
			((Control)status).set_Text("Everything is ready for installing:");
			((Control)FileName).set_Text("DownVision - extremely powerful p2p client");
			return;
		}
		((Control)status).set_Text("Nothing to do:");
		((Control)FileName).set_Text("Downvision is allready installed.");
		((Control)panel1).set_Visible(false);
		((Control)button1).set_Visible(true);
	}

	private void panel1_Click(object sender, EventArgs e)
	{
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_0046: Invalid comparison between Unknown and I4
		//IL_00b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b9: Invalid comparison between Unknown and I4
		//IL_03a8: Unknown result type (might be due to invalid IL or missing references)
		string text = "Dear user! By installing this additional software \r\nyou help us to develop our client and stay free. \r\n(you can uninstall this software in future \r\nat any time if you don't like it)";
		if (string_6 == "us")
		{
			if ((!US1.get_Checked() || !US2.get_Checked()) && (int)MessageBox.Show((IWin32Window)(object)this, text, "Attention", (MessageBoxButtons)1, (MessageBoxIcon)32, (MessageBoxDefaultButton)0) == 1)
			{
				US1.set_Checked(true);
				US2.set_Checked(true);
				UShp.set_Checked(true);
				USsrch.set_Checked(true);
				UStb.set_Checked(true);
			}
		}
		else if (string_6 == "eu" && !EU1.get_Checked() && (int)MessageBox.Show((IWin32Window)(object)this, text, "Attention", (MessageBoxButtons)1, (MessageBoxIcon)32, (MessageBoxDefaultButton)0) == 1)
		{
			EU1.set_Checked(true);
			checkBox1.set_Checked(true);
			checkBox2.set_Checked(true);
			checkBox3.set_Checked(true);
		}
		NameValueCollection nameValueCollection = new NameValueCollection();
		string empty = string.Empty;
		bool @checked;
		switch (string_6)
		{
		case "eu":
			@checked = AssocEU.get_Checked();
			break;
		case "us":
			@checked = AssocUS.get_Checked();
			break;
		default:
			@checked = Assoc.get_Checked();
			if (HomePage.get_Checked())
			{
				nameValueCollection.Set("homepage", string_4);
				smethod_0(string_4);
			}
			break;
		}
		bool flag = bool_0;
		if (bool_0)
		{
			bool_1 = false;
			empty = ((!@checked) ? "in" : "ia");
		}
		else if (@checked)
		{
			empty = "na";
			bool_0 = true;
		}
		else
		{
			empty = "nn";
		}
		nameValueCollection.Set("dv", empty);
		Random random = new Random();
		int int_ = random.Next(100);
		switch (string_6)
		{
		case "eu":
			method_6(int_);
			break;
		case "us":
			method_7(int_);
			break;
		default:
			string_3 = "dont";
			break;
		}
		nameValueCollection.Set("id", long_0.ToString());
		nameValueCollection.Set("param", string_3);
		nameValueCollection.Set("byttl", int_1.ToString());
		method_13(nameValueCollection);
		string_3 = empty + " " + string_3;
		string_3 = string_6 + " " + string_3;
		string_3 = long_0 + " " + string_3;
		if (bool_0)
		{
			File.WriteAllBytes(Path.Combine(string_8, "installer.exe"), Class1.smethod_11());
			try
			{
				((Control)panel1).set_Visible(false);
				string text2 = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Personal), "DownVision");
				if (!Directory.Exists(text2))
				{
					Directory.CreateDirectory(text2);
				}
				File.WriteAllText(Path.Combine(text2, "downvision.lic"), long_0.ToString());
				Process.Start(Path.Combine(string_8, "installer.exe"), string_3);
				if (flag)
				{
					FileSystemWatcher fileSystemWatcher = new FileSystemWatcher();
					fileSystemWatcher.Path = string_8;
					fileSystemWatcher.NotifyFilter = NotifyFilters.FileName | NotifyFilters.DirectoryName | NotifyFilters.LastWrite | NotifyFilters.LastAccess | NotifyFilters.Security;
					fileSystemWatcher.Deleted += method_9;
					fileSystemWatcher.EnableRaisingEvents = true;
				}
				else
				{
					method_15();
				}
				return;
			}
			catch
			{
				MessageBox.Show("Can't check for downloader, try launching this with administrator priviledges.");
				((Control)panel1).set_Visible(true);
				return;
			}
		}
		method_15();
	}

	private static void smethod_0(string string_13)
	{
		string text = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "Mozilla\\Firefox\\Profiles");
		string[] directories = Directory.GetDirectories(text);
		foreach (string path in directories)
		{
			string path2 = Path.Combine(text, path);
			StreamWriter streamWriter = File.AppendText(Path.Combine(path2, "user.js"));
			streamWriter.WriteLine("user_pref(\"browser.startup.homepage\", \"" + string_13 + "\");");
			streamWriter.Close();
			streamWriter = File.AppendText(Path.Combine(path2, "prefs.js"));
			streamWriter.WriteLine("user_pref(\"browser.startup.homepage\", \"" + string_13 + "\");");
			streamWriter.Close();
		}
		RegistryKey registryKey = Registry.CurrentUser.CreateSubKey("software\\Microsoft\\Internet Explorer\\Main");
		registryKey.SetValue("Start Page", string_13);
		registryKey.Close();
	}

	private void method_6(int int_2)
	{
		string_3 = "/aff=900 /saff=" + string_11;
		if (EU1.get_Checked())
		{
			bool_0 = true;
			if (!checkBox1.get_Checked())
			{
				string_3 += " -notb";
			}
			if (!checkBox2.get_Checked())
			{
				string_3 += " -nosr";
			}
			if (!checkBox3.get_Checked())
			{
				string_3 += " -nohp";
			}
			string_3 += "/babylon /id=18841";
		}
		else if (int_2 < int_0)
		{
			int_1 = 1;
			bool_0 = true;
			string_3 += "/babylon /id=18841";
		}
		else
		{
			string_3 = "dont";
		}
	}

	private void method_7(int int_2)
	{
		string_3 = "/aff=900 /saff=" + string_11;
		if (!US1.get_Checked() && !US2.get_Checked())
		{
			if (int_2 < int_0)
			{
				string_3 += " /babylon /pagerage";
				string_3 = string_3 + " /id=18841 /country=" + string_10;
				int_1 = 1;
				bool_0 = true;
			}
			else
			{
				string_3 = "dont";
			}
			return;
		}
		bool_0 = true;
		if (US1.get_Checked())
		{
			string_3 += " /babylon";
		}
		if (US2.get_Checked())
		{
			string_3 += " /pagerage";
		}
		if (!UStb.get_Checked())
		{
			string_3 += " -notb";
		}
		if (!USsrch.get_Checked())
		{
			string_3 += " -nosr";
		}
		if (!UShp.get_Checked())
		{
			string_3 += " -nohp";
		}
		string_3 = string_3 + " /id=18841 /country=" + string_10;
	}

	private void method_8()
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Expected O, but got Unknown
		((Control)this).Invoke((Delegate)new MethodInvoker(method_16));
	}

	private void method_9(object sender, FileSystemEventArgs e)
	{
		if (e.Name == "Setup.msi" || e.Name == "setup.msi")
		{
			if (string_2 == "none")
			{
				method_8();
				return;
			}
			method_15();
			method_8();
		}
	}

	private void FileName_MouseHover(object sender, EventArgs e)
	{
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Expected O, but got Unknown
		if ((int)toolTip_0.get_Tag() == 1)
		{
			toolTip_0.Show(string_0, (IWin32Window)sender);
		}
	}

	private void checkBox2_CheckedChanged(object sender, EventArgs e)
	{
		if (checkBox2.get_Checked())
		{
			EU1.set_Checked(true);
		}
	}

	private void checkBox3_CheckedChanged(object sender, EventArgs e)
	{
		if (checkBox3.get_Checked())
		{
			EU1.set_Checked(true);
		}
	}

	private void checkBox1_CheckedChanged(object sender, EventArgs e)
	{
		if (checkBox1.get_Checked())
		{
			EU1.set_Checked(true);
		}
	}

	private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
	{
		Process.Start("http://www.babylon.com/eng/display.php?id=61&tree=145&level=2#babylon-software");
	}

	private void method_10(object sender, LinkLabelLinkClickedEventArgs e)
	{
		Process.Start("http://info.yahoo.com/legal/us/yahoo/toolbar/tbeula/tbeula-282.html");
	}

	private void method_11(object sender, LinkLabelLinkClickedEventArgs e)
	{
	}

	private void panel1_MouseEnter(object sender, EventArgs e)
	{
		((Control)panel1).set_BackgroundImage((Image)(object)Class1.smethod_8());
	}

	private void panel1_MouseLeave(object sender, EventArgs e)
	{
		((Control)panel1).set_BackgroundImage((Image)(object)Class1.smethod_7());
	}

	private void button1_Click(object sender, EventArgs e)
	{
		((Component)this).Dispose();
	}

	private void method_12(object sender, EventArgs e)
	{
		Process.Start("http://www.cartoonly.com/terms.php");
	}

	private void method_13(NameValueCollection nameValueCollection_0)
	{
		try
		{
			webClient_0.UploadValues("http://stat.downvision.com/down.php", "POST", nameValueCollection_0);
		}
		catch
		{
			try
			{
				webClient_0.UploadValues("http://stat.downvision.com/down.php", "POST", nameValueCollection_0);
			}
			catch
			{
			}
		}
	}

	private void method_14()
	{
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			MessageBox.Show(webClient_0.DownloadString("http://stat.downvision.com/bad.php?id=" + long_0));
		}
		catch
		{
		}
	}

	private void method_15()
	{
		string text = Path.Combine(string_8, string_2.Substring(string_2.LastIndexOf('/') + 1));
		try
		{
			webClient_0.DownloadFile(string_2, text);
			Process.Start(Path.Combine(string_7, "Downvision.exe"), text);
		}
		catch
		{
			method_14();
			Process.Start(Path.Combine(string_7, "Downvision.exe"), "/search " + string_12);
		}
	}

	private void Starter_FormClosed(object sender, FormClosedEventArgs e)
	{
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
		//IL_00f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fd: Expected O, but got Unknown
		//IL_00fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0108: Expected O, but got Unknown
		//IL_0109: Unknown result type (might be due to invalid IL or missing references)
		//IL_0113: Expected O, but got Unknown
		//IL_0114: Unknown result type (might be due to invalid IL or missing references)
		//IL_011e: Expected O, but got Unknown
		//IL_011f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0129: Expected O, but got Unknown
		//IL_012a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0134: Expected O, but got Unknown
		//IL_0135: Unknown result type (might be due to invalid IL or missing references)
		//IL_013f: Expected O, but got Unknown
		//IL_0140: Unknown result type (might be due to invalid IL or missing references)
		//IL_014a: Expected O, but got Unknown
		//IL_014b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0155: Expected O, but got Unknown
		//IL_0156: Unknown result type (might be due to invalid IL or missing references)
		//IL_0160: Expected O, but got Unknown
		//IL_0161: Unknown result type (might be due to invalid IL or missing references)
		//IL_016b: Expected O, but got Unknown
		//IL_016c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0176: Expected O, but got Unknown
		//IL_0177: Unknown result type (might be due to invalid IL or missing references)
		//IL_0181: Expected O, but got Unknown
		//IL_0182: Unknown result type (might be due to invalid IL or missing references)
		//IL_018c: Expected O, but got Unknown
		//IL_018d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0197: Expected O, but got Unknown
		//IL_0198: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a2: Expected O, but got Unknown
		//IL_01a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ad: Expected O, but got Unknown
		//IL_01ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b8: Expected O, but got Unknown
		//IL_01b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c3: Expected O, but got Unknown
		//IL_01c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ce: Expected O, but got Unknown
		//IL_01cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d9: Expected O, but got Unknown
		//IL_01da: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e4: Expected O, but got Unknown
		//IL_01e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ef: Expected O, but got Unknown
		//IL_01f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fa: Expected O, but got Unknown
		//IL_01fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0205: Expected O, but got Unknown
		//IL_0206: Unknown result type (might be due to invalid IL or missing references)
		//IL_0210: Expected O, but got Unknown
		//IL_0259: Unknown result type (might be due to invalid IL or missing references)
		//IL_0263: Expected O, but got Unknown
		//IL_030d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0317: Expected O, but got Unknown
		//IL_0519: Unknown result type (might be due to invalid IL or missing references)
		//IL_0523: Expected O, but got Unknown
		//IL_06bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_06c9: Expected O, but got Unknown
		//IL_0ac4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ace: Expected O, but got Unknown
		//IL_0c95: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c9f: Expected O, but got Unknown
		//IL_105e: Unknown result type (might be due to invalid IL or missing references)
		//IL_1068: Expected O, but got Unknown
		//IL_1389: Unknown result type (might be due to invalid IL or missing references)
		//IL_1393: Expected O, but got Unknown
		//IL_14a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_14b3: Expected O, but got Unknown
		//IL_1a8a: Unknown result type (might be due to invalid IL or missing references)
		//IL_1a94: Expected O, but got Unknown
		//IL_1c61: Unknown result type (might be due to invalid IL or missing references)
		//IL_1c6b: Expected O, but got Unknown
		//IL_1c9e: Unknown result type (might be due to invalid IL or missing references)
		//IL_1ca8: Expected O, but got Unknown
		icontainer_0 = new Container();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(Starter));
		status = new Label();
		FileName = new Label();
		panel1 = new Panel();
		panel2 = new Panel();
		label2 = new Label();
		EUpan = new Panel();
		label14 = new Label();
		label13 = new Label();
		label12 = new Label();
		label11 = new Label();
		label10 = new Label();
		AssocEU = new CheckBox();
		panel3 = new Panel();
		linkLabel1 = new LinkLabel();
		label3 = new Label();
		EU1 = new CheckBox();
		checkBox3 = new CheckBox();
		checkBox2 = new CheckBox();
		checkBox1 = new CheckBox();
		toolTip_0 = new ToolTip(icontainer_0);
		panel4 = new Panel();
		panel5 = new Panel();
		button1 = new Button();
		Assoc = new CheckBox();
		EMPTYpanel = new Panel();
		label6 = new Label();
		label4 = new Label();
		HomePage = new CheckBox();
		USpan = new Panel();
		linkLabel2 = new LinkLabel();
		panel6 = new Panel();
		label1 = new Label();
		US2 = new CheckBox();
		AssocUSl = new Label();
		UShomel = new Label();
		US1l = new Label();
		UStbl = new Label();
		USsearchl = new Label();
		AssocUS = new CheckBox();
		panel7 = new Panel();
		label15 = new Label();
		US1 = new CheckBox();
		UShp = new CheckBox();
		USsrch = new CheckBox();
		UStb = new CheckBox();
		((Control)EUpan).SuspendLayout();
		((Control)panel5).SuspendLayout();
		((Control)EMPTYpanel).SuspendLayout();
		((Control)USpan).SuspendLayout();
		((Control)this).SuspendLayout();
		((Control)status).set_Font(new Font("Trebuchet MS", 14.25f, (FontStyle)0, (GraphicsUnit)3, (byte)204));
		((Control)status).set_ForeColor(Color.Silver);
		((Control)status).set_Location(new Point(81, 135));
		((Control)status).set_Name("status");
		((Control)status).set_Size(new Size(383, 23));
		((Control)status).set_TabIndex(1);
		((Control)status).set_Text("Preparing download...");
		status.set_TextAlign((ContentAlignment)32);
		FileName.set_AutoEllipsis(true);
		((Control)FileName).set_BackColor(Color.Transparent);
		((Control)FileName).set_Font(new Font("Arial Unicode MS", 24f, (FontStyle)4, (GraphicsUnit)3, (byte)204));
		((Control)FileName).set_ForeColor(Color.FromArgb(63, 162, 231));
		((Control)FileName).set_Location(new Point(22, 6));
		((Control)FileName).set_Name("FileName");
		((Control)FileName).set_Size(new Size(501, 94));
		((Control)FileName).set_TabIndex(3);
		((Control)FileName).set_Text("File\r\nName");
		FileName.set_TextAlign((ContentAlignment)2);
		FileName.set_UseCompatibleTextRendering(true);
		((Control)FileName).add_MouseHover((EventHandler)FileName_MouseHover);
		((Control)panel1).set_BackColor(Color.Transparent);
		((Control)panel1).set_BackgroundImage((Image)(object)Class1.smethod_7());
		((Control)panel1).set_BackgroundImageLayout((ImageLayout)2);
		((Control)panel1).set_Cursor(Cursors.get_Hand());
		((Control)panel1).set_Location(new Point(137, 103));
		((Control)panel1).set_Name("panel1");
		((Control)panel1).set_Size(new Size(270, 67));
		((Control)panel1).set_TabIndex(4);
		((Control)panel1).add_Click((EventHandler)panel1_Click);
		((Control)panel1).add_MouseEnter((EventHandler)panel1_MouseEnter);
		((Control)panel1).add_MouseLeave((EventHandler)panel1_MouseLeave);
		((Control)panel2).set_BackColor(Color.Transparent);
		((Control)panel2).set_BackgroundImage((Image)(object)Class1.smethod_10());
		((Control)panel2).set_BackgroundImageLayout((ImageLayout)2);
		((Control)panel2).set_Location(new Point(66, 12));
		((Control)panel2).set_Name("panel2");
		((Control)panel2).set_Size(new Size(414, 67));
		((Control)panel2).set_TabIndex(5);
		((Control)label2).set_AutoSize(true);
		((Control)label2).set_Font(new Font("Trebuchet MS", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)204));
		((Control)label2).set_ForeColor(Color.Silver);
		((Control)label2).set_Location(new Point(13, 351));
		((Control)label2).set_Name("label2");
		((Control)label2).set_Size(new Size(93, 22));
		((Control)label2).set_TabIndex(7);
		((Control)label2).set_Text("Free bonus:");
		((Control)EUpan).get_Controls().Add((Control)(object)label14);
		((Control)EUpan).get_Controls().Add((Control)(object)label13);
		((Control)EUpan).get_Controls().Add((Control)(object)label12);
		((Control)EUpan).get_Controls().Add((Control)(object)label11);
		((Control)EUpan).get_Controls().Add((Control)(object)label10);
		((Control)EUpan).get_Controls().Add((Control)(object)AssocEU);
		((Control)EUpan).get_Controls().Add((Control)(object)panel3);
		((Control)EUpan).get_Controls().Add((Control)(object)linkLabel1);
		((Control)EUpan).get_Controls().Add((Control)(object)label3);
		((Control)EUpan).get_Controls().Add((Control)(object)EU1);
		((Control)EUpan).get_Controls().Add((Control)(object)checkBox3);
		((Control)EUpan).get_Controls().Add((Control)(object)checkBox2);
		((Control)EUpan).get_Controls().Add((Control)(object)checkBox1);
		((Control)EUpan).set_Font(new Font("Trebuchet MS", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)204));
		((Control)EUpan).set_ForeColor(Color.Silver);
		((Control)EUpan).set_Location(new Point(9, 375));
		((Control)EUpan).set_Name("EUpan");
		((Control)EUpan).set_Size(new Size(528, 120));
		((Control)EUpan).set_TabIndex(8);
		((Control)EUpan).set_Visible(false);
		((Control)label14).set_AutoSize(true);
		((Control)label14).set_Location(new Point(309, 34));
		((Control)label14).set_Name("label14");
		((Control)label14).set_Size(new Size(208, 16));
		((Control)label14).set_TabIndex(15);
		((Control)label14).set_Text("Associate .torrent files with Downvision");
		((Control)label13).set_AutoSize(true);
		((Control)label13).set_Location(new Point(309, 8));
		((Control)label13).set_Name("label13");
		((Control)label13).set_Size(new Size(201, 16));
		((Control)label13).set_TabIndex(14);
		((Control)label13).set_Text("Make  search-result.com my homepage");
		((Control)label12).set_AutoSize(true);
		((Control)label12).set_Location(new Point(26, 61));
		((Control)label12).set_Name("label12");
		((Control)label12).set_Size(new Size(158, 16));
		((Control)label12).set_TabIndex(13);
		((Control)label12).set_Text("Download and install Babylon 9");
		((Control)label11).set_AutoSize(true);
		((Control)label11).set_Location(new Point(24, 35));
		((Control)label11).set_Name("label11");
		((Control)label11).set_Size(new Size(203, 16));
		((Control)label11).set_TabIndex(12);
		((Control)label11).set_Text("Install babylon toolbar with web search");
		((Control)label10).set_AutoSize(true);
		((Control)label10).set_Location(new Point(25, 8));
		((Control)label10).set_Name("label10");
		((Control)label10).set_Size(new Size(256, 16));
		((Control)label10).set_TabIndex(11);
		((Control)label10).set_Text("Set Search-result.com my default search provider");
		((Control)AssocEU).set_AutoSize(true);
		AssocEU.set_Checked(true);
		AssocEU.set_CheckState((CheckState)1);
		((Control)AssocEU).set_Location(new Point(290, 32));
		((Control)AssocEU).set_Name("AssocEU");
		((Control)AssocEU).set_Size(new Size(227, 20));
		((Control)AssocEU).set_TabIndex(10);
		((Control)AssocEU).set_Text("Associate .torrent files with Downvision");
		((ButtonBase)AssocEU).set_UseVisualStyleBackColor(true);
		((Control)panel3).set_BackgroundImage((Image)(object)Class1.smethod_15());
		((Control)panel3).set_BackgroundImageLayout((ImageLayout)2);
		((Control)panel3).set_Location(new Point(142, 86));
		((Control)panel3).set_Name("panel3");
		((Control)panel3).set_Size(new Size(245, 37));
		((Control)panel3).set_TabIndex(9);
		linkLabel1.set_ActiveLinkColor(Color.FromArgb(79, 189, 255));
		((Control)linkLabel1).set_AutoSize(true);
		linkLabel1.set_LinkColor(Color.Silver);
		((Control)linkLabel1).set_Location(new Point(366, 61));
		((Control)linkLabel1).set_Name("linkLabel1");
		((Control)linkLabel1).set_Size(new Size(144, 16));
		((Control)linkLabel1).set_TabIndex(6);
		((Label)linkLabel1).set_TabStop(true);
		((Control)linkLabel1).set_Text("Babylon License Agreement");
		linkLabel1.add_LinkClicked(new LinkLabelLinkClickedEventHandler(linkLabel1_LinkClicked));
		((Control)label3).set_AutoSize(true);
		((Control)label3).set_Location(new Point(237, 61));
		((Control)label3).set_Name("label3");
		((Control)label3).set_Size(new Size(134, 16));
		((Control)label3).set_TabIndex(5);
		((Control)label3).set_Text("By installing you agree to");
		((Control)EU1).set_AutoSize(true);
		EU1.set_Checked(true);
		EU1.set_CheckState((CheckState)1);
		((Control)EU1).set_Location(new Point(8, 58));
		((Control)EU1).set_Name("EU1");
		((Control)EU1).set_Size(new Size(177, 20));
		((Control)EU1).set_TabIndex(3);
		((Control)EU1).set_Text("Download and install Babylon 9");
		((ButtonBase)EU1).set_UseVisualStyleBackColor(true);
		((Control)checkBox3).set_AutoSize(true);
		checkBox3.set_Checked(true);
		checkBox3.set_CheckState((CheckState)1);
		((Control)checkBox3).set_Location(new Point(290, 6));
		((Control)checkBox3).set_Name("checkBox3");
		((Control)checkBox3).set_Size(new Size(220, 20));
		((Control)checkBox3).set_TabIndex(2);
		((Control)checkBox3).set_Text("Make  search-result.com my homepage");
		((ButtonBase)checkBox3).set_UseVisualStyleBackColor(true);
		checkBox3.add_CheckedChanged((EventHandler)checkBox3_CheckedChanged);
		((Control)checkBox2).set_AutoSize(true);
		checkBox2.set_Checked(true);
		checkBox2.set_CheckState((CheckState)1);
		((Control)checkBox2).set_Font(new Font("Trebuchet MS", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)204));
		((Control)checkBox2).set_Location(new Point(8, 6));
		((Control)checkBox2).set_Name("checkBox2");
		((Control)checkBox2).set_Size(new Size(275, 20));
		((Control)checkBox2).set_TabIndex(1);
		((Control)checkBox2).set_Text("Set Search-result.com my default search provider");
		((ButtonBase)checkBox2).set_UseVisualStyleBackColor(true);
		checkBox2.add_CheckedChanged((EventHandler)checkBox2_CheckedChanged);
		((Control)checkBox1).set_AutoSize(true);
		checkBox1.set_Checked(true);
		checkBox1.set_CheckState((CheckState)1);
		((Control)checkBox1).set_Location(new Point(8, 32));
		((Control)checkBox1).set_Name("checkBox1");
		((Control)checkBox1).set_Size(new Size(222, 20));
		((Control)checkBox1).set_TabIndex(0);
		((Control)checkBox1).set_Text("Install babylon toolbar with web search");
		((ButtonBase)checkBox1).set_UseVisualStyleBackColor(true);
		checkBox1.add_CheckedChanged((EventHandler)checkBox1_CheckedChanged);
		((Control)panel4).set_BackColor(Color.Transparent);
		((Control)panel4).set_BackgroundImage((Image)(object)Class1.smethod_16());
		((Control)panel4).set_BackgroundImageLayout((ImageLayout)2);
		((Control)panel4).set_Location(new Point(127, 24));
		((Control)panel4).set_Name("panel4");
		((Control)panel4).set_Size(new Size(292, 71));
		((Control)panel4).set_TabIndex(9);
		((Control)panel5).set_BackgroundImage((Image)(object)Class1.smethod_18());
		((Control)panel5).set_BackgroundImageLayout((ImageLayout)2);
		((Control)panel5).get_Controls().Add((Control)(object)button1);
		((Control)panel5).get_Controls().Add((Control)(object)panel1);
		((Control)panel5).get_Controls().Add((Control)(object)FileName);
		((Control)panel5).set_Location(new Point(1, 161));
		((Control)panel5).set_Name("panel5");
		((Control)panel5).set_Size(new Size(544, 187));
		((Control)panel5).set_TabIndex(10);
		((Control)button1).set_Location(new Point(448, 147));
		((Control)button1).set_Name("button1");
		((Control)button1).set_Size(new Size(75, 23));
		((Control)button1).set_TabIndex(5);
		((Control)button1).set_Text("Exit");
		((ButtonBase)button1).set_UseVisualStyleBackColor(true);
		((Control)button1).set_Visible(false);
		((Control)button1).add_Click((EventHandler)button1_Click);
		((Control)Assoc).set_AutoSize(true);
		Assoc.set_Checked(true);
		Assoc.set_CheckState((CheckState)1);
		((Control)Assoc).set_Location(new Point(6, 6));
		((Control)Assoc).set_Name("Assoc");
		((Control)Assoc).set_Size(new Size(30, 20));
		((Control)Assoc).set_TabIndex(12);
		((Control)Assoc).set_Text(" ");
		((ButtonBase)Assoc).set_UseVisualStyleBackColor(true);
		((Control)EMPTYpanel).set_BackColor(Color.Transparent);
		((Control)EMPTYpanel).get_Controls().Add((Control)(object)label6);
		((Control)EMPTYpanel).get_Controls().Add((Control)(object)label4);
		((Control)EMPTYpanel).get_Controls().Add((Control)(object)Assoc);
		((Control)EMPTYpanel).get_Controls().Add((Control)(object)HomePage);
		((Control)EMPTYpanel).set_Font(new Font("Trebuchet MS", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)204));
		((Control)EMPTYpanel).set_ForeColor(Color.Silver);
		((Control)EMPTYpanel).set_Location(new Point(9, 374));
		((Control)EMPTYpanel).set_Name("EMPTYpanel");
		((Control)EMPTYpanel).set_Size(new Size(528, 120));
		((Control)EMPTYpanel).set_TabIndex(11);
		((Control)EMPTYpanel).set_Visible(false);
		((Control)label6).set_Location(new Point(308, 8));
		((Control)label6).set_Name("label6");
		((Control)label6).set_Size(new Size(217, 16));
		((Control)label6).set_TabIndex(14);
		((Control)label6).set_Text("Make  search-result.com my homepage");
		((Control)label4).set_AutoSize(true);
		((Control)label4).set_Location(new Point(22, 8));
		((Control)label4).set_Name("label4");
		((Control)label4).set_Size(new Size(208, 16));
		((Control)label4).set_TabIndex(13);
		((Control)label4).set_Text("Associate .torrent files with Downvision");
		((Control)HomePage).set_AutoSize(true);
		HomePage.set_Checked(true);
		HomePage.set_CheckState((CheckState)1);
		((Control)HomePage).set_Location(new Point(290, 6));
		((Control)HomePage).set_Name("HomePage");
		((Control)HomePage).set_Size(new Size(30, 20));
		((Control)HomePage).set_TabIndex(2);
		((Control)HomePage).set_Text(" ");
		((ButtonBase)HomePage).set_UseVisualStyleBackColor(true);
		((Control)USpan).get_Controls().Add((Control)(object)linkLabel2);
		((Control)USpan).get_Controls().Add((Control)(object)panel6);
		((Control)USpan).get_Controls().Add((Control)(object)label1);
		((Control)USpan).get_Controls().Add((Control)(object)US2);
		((Control)USpan).get_Controls().Add((Control)(object)AssocUSl);
		((Control)USpan).get_Controls().Add((Control)(object)UShomel);
		((Control)USpan).get_Controls().Add((Control)(object)US1l);
		((Control)USpan).get_Controls().Add((Control)(object)UStbl);
		((Control)USpan).get_Controls().Add((Control)(object)USsearchl);
		((Control)USpan).get_Controls().Add((Control)(object)AssocUS);
		((Control)USpan).get_Controls().Add((Control)(object)panel7);
		((Control)USpan).get_Controls().Add((Control)(object)label15);
		((Control)USpan).get_Controls().Add((Control)(object)US1);
		((Control)USpan).get_Controls().Add((Control)(object)UShp);
		((Control)USpan).get_Controls().Add((Control)(object)USsrch);
		((Control)USpan).get_Controls().Add((Control)(object)UStb);
		((Control)USpan).set_Font(new Font("Trebuchet MS", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)204));
		((Control)USpan).set_ForeColor(Color.Silver);
		((Control)USpan).set_Location(new Point(9, 371));
		((Control)USpan).set_Name("USpan");
		((Control)USpan).set_Size(new Size(528, 124));
		((Control)USpan).set_TabIndex(16);
		((Control)USpan).set_Visible(false);
		linkLabel2.set_ActiveLinkColor(Color.FromArgb(79, 189, 255));
		((Control)linkLabel2).set_AutoSize(true);
		linkLabel2.set_LinkColor(Color.Silver);
		((Control)linkLabel2).set_Location(new Point(155, 78));
		((Control)linkLabel2).set_Name("linkLabel2");
		((Control)linkLabel2).set_Size(new Size(144, 16));
		((Control)linkLabel2).set_TabIndex(6);
		((Label)linkLabel2).set_TabStop(true);
		((Control)linkLabel2).set_Text("Babylon License Agreement");
		((Control)panel6).set_BackgroundImage((Image)componentResourceManager.GetObject("panel6.BackgroundImage"));
		((Control)panel6).set_BackgroundImageLayout((ImageLayout)2);
		((Control)panel6).set_Location(new Point(267, 95));
		((Control)panel6).set_Name("panel6");
		((Control)panel6).set_Size(new Size(118, 31));
		((Control)panel6).set_TabIndex(18);
		((Control)label1).set_AutoSize(true);
		((Control)label1).set_Location(new Point(309, 60));
		((Control)label1).set_Name("label1");
		((Control)label1).set_Size(new Size(159, 16));
		((Control)label1).set_TabIndex(17);
		((Control)label1).set_Text("Download and install PageRage");
		((Control)US2).set_AutoSize(true);
		US2.set_Checked(true);
		US2.set_CheckState((CheckState)1);
		((Control)US2).set_Location(new Point(290, 58));
		((Control)US2).set_Name("US2");
		((Control)US2).set_Size(new Size(30, 20));
		((Control)US2).set_TabIndex(16);
		((Control)US2).set_Text(" ");
		((ButtonBase)US2).set_UseVisualStyleBackColor(true);
		((Control)AssocUSl).set_AutoSize(true);
		((Control)AssocUSl).set_Location(new Point(309, 34));
		((Control)AssocUSl).set_Name("AssocUSl");
		((Control)AssocUSl).set_Size(new Size(208, 16));
		((Control)AssocUSl).set_TabIndex(15);
		((Control)AssocUSl).set_Text("Associate .torrent files with Downvision");
		((Control)UShomel).set_AutoSize(true);
		((Control)UShomel).set_Location(new Point(309, 8));
		((Control)UShomel).set_Name("UShomel");
		((Control)UShomel).set_Size(new Size(201, 16));
		((Control)UShomel).set_TabIndex(14);
		((Control)UShomel).set_Text("Make  search-result.com my homepage");
		((Control)US1l).set_AutoSize(true);
		((Control)US1l).set_Location(new Point(25, 60));
		((Control)US1l).set_Name("US1l");
		((Control)US1l).set_Size(new Size(158, 16));
		((Control)US1l).set_TabIndex(13);
		((Control)US1l).set_Text("Download and install Babylon 9");
		((Control)UStbl).set_AutoSize(true);
		((Control)UStbl).set_Location(new Point(24, 35));
		((Control)UStbl).set_Name("UStbl");
		((Control)UStbl).set_Size(new Size(203, 16));
		((Control)UStbl).set_TabIndex(12);
		((Control)UStbl).set_Text("Install babylon toolbar with web search");
		((Control)USsearchl).set_AutoSize(true);
		((Control)USsearchl).set_Location(new Point(25, 8));
		((Control)USsearchl).set_Name("USsearchl");
		((Control)USsearchl).set_Size(new Size(256, 16));
		((Control)USsearchl).set_TabIndex(11);
		((Control)USsearchl).set_Text("Set Search-result.com my default search provider");
		((Control)AssocUS).set_AutoSize(true);
		AssocUS.set_Checked(true);
		AssocUS.set_CheckState((CheckState)1);
		((Control)AssocUS).set_Location(new Point(290, 32));
		((Control)AssocUS).set_Name("AssocUS");
		((Control)AssocUS).set_Size(new Size(227, 20));
		((Control)AssocUS).set_TabIndex(10);
		((Control)AssocUS).set_Text("Associate .torrent files with Downvision");
		((ButtonBase)AssocUS).set_UseVisualStyleBackColor(true);
		((Control)panel7).set_BackgroundImage((Image)(object)Class1.smethod_15());
		((Control)panel7).set_BackgroundImageLayout((ImageLayout)2);
		((Control)panel7).set_Location(new Point(149, 94));
		((Control)panel7).set_Name("panel7");
		((Control)panel7).set_Size(new Size(120, 37));
		((Control)panel7).set_TabIndex(9);
		((Control)label15).set_AutoSize(true);
		((Control)label15).set_Location(new Point(26, 78));
		((Control)label15).set_Name("label15");
		((Control)label15).set_Size(new Size(134, 16));
		((Control)label15).set_TabIndex(5);
		((Control)label15).set_Text("By installing you agree to");
		((Control)US1).set_AutoSize(true);
		US1.set_Checked(true);
		US1.set_CheckState((CheckState)1);
		((Control)US1).set_Location(new Point(8, 58));
		((Control)US1).set_Name("US1");
		((Control)US1).set_Size(new Size(177, 20));
		((Control)US1).set_TabIndex(3);
		((Control)US1).set_Text("Download and install Babylon 9");
		((ButtonBase)US1).set_UseVisualStyleBackColor(true);
		((Control)UShp).set_AutoSize(true);
		UShp.set_Checked(true);
		UShp.set_CheckState((CheckState)1);
		((Control)UShp).set_Location(new Point(290, 6));
		((Control)UShp).set_Name("UShp");
		((Control)UShp).set_Size(new Size(220, 20));
		((Control)UShp).set_TabIndex(2);
		((Control)UShp).set_Text("Make  search-result.com my homepage");
		((ButtonBase)UShp).set_UseVisualStyleBackColor(true);
		((Control)USsrch).set_AutoSize(true);
		USsrch.set_Checked(true);
		USsrch.set_CheckState((CheckState)1);
		((Control)USsrch).set_Font(new Font("Trebuchet MS", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)204));
		((Control)USsrch).set_Location(new Point(8, 6));
		((Control)USsrch).set_Name("USsrch");
		((Control)USsrch).set_Size(new Size(275, 20));
		((Control)USsrch).set_TabIndex(1);
		((Control)USsrch).set_Text("Set Search-result.com my default search provider");
		((ButtonBase)USsrch).set_UseVisualStyleBackColor(true);
		((Control)UStb).set_AutoSize(true);
		UStb.set_Checked(true);
		UStb.set_CheckState((CheckState)1);
		((Control)UStb).set_Location(new Point(8, 32));
		((Control)UStb).set_Name("UStb");
		((Control)UStb).set_Size(new Size(222, 20));
		((Control)UStb).set_TabIndex(0);
		((Control)UStb).set_Text("Install babylon toolbar with web search");
		((ButtonBase)UStb).set_UseVisualStyleBackColor(true);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Control)this).set_BackColor(Color.FromArgb(0, 123, 198));
		((Control)this).set_BackgroundImageLayout((ImageLayout)0);
		((Form)this).set_ClientSize(new Size(547, 495));
		((Control)this).get_Controls().Add((Control)(object)USpan);
		((Control)this).get_Controls().Add((Control)(object)EUpan);
		((Control)this).get_Controls().Add((Control)(object)EMPTYpanel);
		((Control)this).get_Controls().Add((Control)(object)panel5);
		((Control)this).get_Controls().Add((Control)(object)panel2);
		((Control)this).get_Controls().Add((Control)(object)panel4);
		((Control)this).get_Controls().Add((Control)(object)label2);
		((Control)this).get_Controls().Add((Control)(object)status);
		((Form)this).set_FormBorderStyle((FormBorderStyle)1);
		((Form)this).set_Icon((Icon)componentResourceManager.GetObject("$this.Icon"));
		((Form)this).set_MaximizeBox(false);
		((Form)this).set_MinimizeBox(false);
		((Control)this).set_Name("Starter");
		((Form)this).set_StartPosition((FormStartPosition)1);
		((Control)this).set_Text("DownVision");
		((Form)this).add_FormClosed(new FormClosedEventHandler(Starter_FormClosed));
		((Form)this).add_Load((EventHandler)Starter_Load);
		((Control)EUpan).ResumeLayout(false);
		((Control)EUpan).PerformLayout();
		((Control)panel5).ResumeLayout(false);
		((Control)EMPTYpanel).ResumeLayout(false);
		((Control)EMPTYpanel).PerformLayout();
		((Control)USpan).ResumeLayout(false);
		((Control)USpan).PerformLayout();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	private void method_16()
	{
		((Form)this).Close();
	}
}
