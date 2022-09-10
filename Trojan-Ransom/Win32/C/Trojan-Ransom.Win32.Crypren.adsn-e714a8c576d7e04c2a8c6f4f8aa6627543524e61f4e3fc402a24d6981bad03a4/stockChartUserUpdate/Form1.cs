using System;
using System.ComponentModel;
using System.Data.Common;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Net;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using Microsoft.Win32;

namespace stockChartUserUpdate;

public class Form1 : Form
{
	private int changeState;

	private static string connStr_FOR_SQLIP_HOTELS = "Server=db51.coowo.com;database=stock88168comtw;uid=stock88168comtw;pwd=cBFFr1IVv4Cj;";

	private string http_program_dir = "program2017//";

	private string[] http_program_files = new string[6] { "bb.wav", "bb1.wav", "stockChartUser.exe", "stockChartUser1.exe", "stockNamePKLine.txt", "verson.txt" };

	private string http_hisData_dir = "his_data//";

	private string[] http_hisData_files = new string[3] { "newdata2.exe", "MIN5.exe", "verson_data.txt" };

	private string[] http_hisData_files_ube = new string[1] { "newdata.exe" };

	private string http_hisDatalong_dir = "his_data_long//";

	private string[] http_hisDatalong_files = new string[1] { "newdatalong.exe" };

	private string http_MIN5Datalong_dir = "MIN5_data_long//";

	private string[] http_MIN5Datalong_files = new string[1] { "MIN5.exe" };

	private string[] httpIP = new string[2] { "http://stock88168.ehosting.com.tw//aps//", "http://stock88168.500.com.tw//aps//" };

	private string HOTEL_DOWNLOAD_IP = "http://stock88168.500.com.tw//aps//";

	private int IPaddressCount;

	private string IPaddress;

	private string httpDIR;

	private string[] httpFILES;

	private string ftpIP1 = "ccsun15.cc.nctu.edu.tw";

	private string ftpName1 = "u9312503";

	private string ftpPass1 = "B122018080";

	private string ftpHeadDir1;

	private string ftpIP2 = "stock88168.ehosting.com.tw";

	private string ftpName2 = "89957934";

	private string ftpPass2 = "mike1124";

	private string ftpHeadDir2 = "\\aps\\";

	private string ftpIP3 = "mikehung2.dyndns.org";

	private string ftpName3 = "aps";

	private string ftpPass3 = "1234";

	private string ftpHeadDir3;

	private string ftpIP4 = "mikehung.dyndns.org";

	private string ftpName4 = "aps";

	private string ftpPass4 = "1234";

	private string ftpHeadDir4;

	private string serverNo;

	private string ftpIP;

	private string ftpName;

	private string ftpPass;

	private string ftpHeadDir;

	private bool checkIfFTPConnect;

	private string tempFtpDir;

	private Label label1;

	private Button button1;

	private Button button2;

	private ProgressBar progressBar1;

	private Label label2;

	private ProgressBar progressBar2;

	private Timer timer1;

	private IContainer components;

	private Button button3;

	private Button button4;

	private Timer timer2;

	private MainMenu mainMenu1;

	private MenuItem menuItem2;

	private MenuItem menuItem3;

	private MenuItem menuItem4;

	private MenuItem menuItem66;

	private MenuItem menuItem6;

	private MenuItem menuItem1;

	private StatusStrip statusStrip1;

	private ToolStripStatusLabel toolStripStatusLabel1;

	private MenuItem menuItem5;

	private ColorDialog colorDialog1;

	private Label label3;

	private int MODE;

	private long downloadFileSize;

	private long nowDownloadFileSize;

	private string downloadFileName;

	private bool finishDownload;

	private int errorConnectCount;

	public Form1()
	{
		InitializeComponent();
		MODE = 0;
		((Control)button4).set_Visible(false);
	}

	public Form1(string s)
	{
		InitializeComponent();
		if (s.Equals("DATA"))
		{
			MODE = 1;
		}
		else if (s.Equals("LONGDATA"))
		{
			MODE = 2;
		}
		else if (s.Equals("DATAAUTO"))
		{
			MODE = 3;
		}
		else if (s.Equals("LONGDATA_HK"))
		{
			MODE = 4;
		}
		else if (s.Equals("DATAAUTO_HK"))
		{
			MODE = 5;
		}
		else if (s.Equals("MIN5DATA"))
		{
			MODE = 6;
		}
		else if (s.Equals("MIN5DATA_MIN"))
		{
			MODE = 7;
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
		//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b1: Expected O, but got Unknown
		//IL_00b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bc: Expected O, but got Unknown
		//IL_00bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c7: Expected O, but got Unknown
		//IL_00c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d2: Expected O, but got Unknown
		//IL_00d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dd: Expected O, but got Unknown
		//IL_00de: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e8: Expected O, but got Unknown
		//IL_00e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f3: Expected O, but got Unknown
		//IL_00f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fe: Expected O, but got Unknown
		//IL_00ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0109: Expected O, but got Unknown
		//IL_010a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0114: Expected O, but got Unknown
		//IL_0115: Unknown result type (might be due to invalid IL or missing references)
		//IL_011f: Expected O, but got Unknown
		//IL_0147: Unknown result type (might be due to invalid IL or missing references)
		//IL_0151: Expected O, but got Unknown
		//IL_079e: Unknown result type (might be due to invalid IL or missing references)
		//IL_07a8: Expected O, but got Unknown
		//IL_08fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0906: Expected O, but got Unknown
		components = new Container();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(Form1));
		label1 = new Label();
		button1 = new Button();
		button2 = new Button();
		progressBar1 = new ProgressBar();
		label2 = new Label();
		progressBar2 = new ProgressBar();
		timer1 = new Timer(components);
		button3 = new Button();
		button4 = new Button();
		timer2 = new Timer(components);
		mainMenu1 = new MainMenu(components);
		menuItem2 = new MenuItem();
		menuItem3 = new MenuItem();
		menuItem4 = new MenuItem();
		menuItem66 = new MenuItem();
		menuItem1 = new MenuItem();
		menuItem5 = new MenuItem();
		menuItem6 = new MenuItem();
		statusStrip1 = new StatusStrip();
		toolStripStatusLabel1 = new ToolStripStatusLabel();
		colorDialog1 = new ColorDialog();
		label3 = new Label();
		((Control)statusStrip1).SuspendLayout();
		((Control)this).SuspendLayout();
		((Control)label1).set_Font(new Font("新細明體", 15f, (FontStyle)1, (GraphicsUnit)3, (byte)136));
		((Control)label1).set_ForeColor(Color.Red);
		((Control)label1).set_Location(new Point(14, 9));
		((Control)label1).set_Name("label1");
		((Control)label1).set_Size(new Size(471, 140));
		((Control)label1).set_TabIndex(0);
		((Control)label1).set_Text("請按下方按鈕開始自動更新");
		label1.set_TextAlign((ContentAlignment)32);
		((Control)label1).add_Click((EventHandler)label1_Click);
		((Control)button1).set_Location(new Point(393, 165));
		((Control)button1).set_Name("button1");
		((Control)button1).set_Size(new Size(92, 24));
		((Control)button1).set_TabIndex(1);
		((Control)button1).set_Text("開始更新");
		((Control)button1).add_Click((EventHandler)button1_Click_1);
		((Control)button2).set_Location(new Point(393, 165));
		((Control)button2).set_Name("button2");
		((Control)button2).set_Size(new Size(92, 24));
		((Control)button2).set_TabIndex(1);
		((Control)button2).set_Text("執行主程式");
		((Control)button2).add_Click((EventHandler)button2_Click);
		((Control)progressBar1).set_Location(new Point(83, 200));
		((Control)progressBar1).set_Name("progressBar1");
		((Control)progressBar1).set_Size(new Size(295, 17));
		((Control)progressBar1).set_TabIndex(3);
		((Control)progressBar1).add_Click((EventHandler)progressBar1_Click);
		((Control)label2).set_AutoSize(true);
		((Control)label2).set_Location(new Point(12, 199));
		((Control)label2).set_Name("label2");
		((Control)label2).set_Size(new Size(65, 12));
		((Control)label2).set_TabIndex(4);
		((Control)label2).set_Text("更新進度：");
		((Control)progressBar2).set_Location(new Point(83, 171));
		((Control)progressBar2).set_Name("progressBar2");
		((Control)progressBar2).set_Size(new Size(294, 17));
		((Control)progressBar2).set_TabIndex(5);
		timer1.add_Tick((EventHandler)timer1_Tick);
		((Control)button3).set_Location(new Point(393, 165));
		((Control)button3).set_Name("button3");
		((Control)button3).set_Size(new Size(92, 23));
		((Control)button3).set_TabIndex(6);
		((Control)button3).set_Text("關閉");
		((ButtonBase)button3).set_UseVisualStyleBackColor(true);
		((Control)button3).set_Visible(false);
		((Control)button3).add_Click((EventHandler)button3_Click_1);
		((Control)button4).set_Location(new Point(393, 194));
		((Control)button4).set_Name("button4");
		((Control)button4).set_Size(new Size(92, 23));
		((Control)button4).set_TabIndex(7);
		((Control)button4).set_Text("關閉");
		((ButtonBase)button4).set_UseVisualStyleBackColor(true);
		((Control)button4).add_Click((EventHandler)button4_Click);
		timer2.add_Tick((EventHandler)timer2_Tick);
		((Menu)mainMenu1).get_MenuItems().AddRange((MenuItem[])(object)new MenuItem[3] { menuItem2, menuItem5, menuItem6 });
		menuItem2.set_Index(0);
		((Menu)menuItem2).get_MenuItems().AddRange((MenuItem[])(object)new MenuItem[4] { menuItem3, menuItem4, menuItem66, menuItem1 });
		menuItem2.set_Text("選擇伺服器");
		menuItem3.set_Checked(true);
		menuItem3.set_Index(0);
		menuItem3.set_Text("伺服器1");
		menuItem3.add_Click((EventHandler)menuItem3_Click);
		menuItem4.set_Index(1);
		menuItem4.set_Text("伺服器2");
		menuItem4.add_Click((EventHandler)menuItem4_Click);
		menuItem66.set_Index(2);
		menuItem66.set_Text("伺服器3");
		menuItem66.set_Visible(false);
		menuItem66.add_Click((EventHandler)menuItem66_Click);
		menuItem1.set_Index(3);
		menuItem1.set_Text("伺服器4");
		menuItem1.set_Visible(false);
		menuItem1.add_Click((EventHandler)menuItem1_Click);
		menuItem5.set_Index(1);
		menuItem5.set_Text("遠端協助");
		menuItem5.add_Click((EventHandler)menuItem5_Click);
		menuItem6.set_Index(2);
		menuItem6.set_Text("關閉");
		menuItem6.add_Click((EventHandler)menuItem6_Click);
		((ToolStrip)statusStrip1).get_Items().AddRange((ToolStripItem[])(object)new ToolStripItem[1] { (ToolStripItem)toolStripStatusLabel1 });
		((Control)statusStrip1).set_Location(new Point(0, 237));
		((Control)statusStrip1).set_Name("statusStrip1");
		((Control)statusStrip1).set_Size(new Size(497, 22));
		((Control)statusStrip1).set_TabIndex(8);
		((Control)statusStrip1).set_Text("statusStrip1");
		((ToolStripItem)toolStripStatusLabel1).set_Name("toolStripStatusLabel1");
		((ToolStripItem)toolStripStatusLabel1).set_Size(new Size(0, 17));
		((Control)label3).set_AutoSize(true);
		((Control)label3).set_Font(new Font("新細明體", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)136));
		((Control)label3).set_Location(new Point(427, 17));
		((Control)label3).set_Name("label3");
		((Control)label3).set_RightToLeft((RightToLeft)1);
		((Control)label3).set_Size(new Size(48, 11));
		((Control)label3).set_TabIndex(9);
		((Control)label3).set_Text("v2.011731");
		((Control)label3).add_Click((EventHandler)label3_Click);
		((Form)this).set_AutoScaleBaseSize(new Size(5, 15));
		((Form)this).set_ClientSize(new Size(497, 259));
		((Control)this).get_Controls().Add((Control)(object)label3);
		((Control)this).get_Controls().Add((Control)(object)statusStrip1);
		((Control)this).get_Controls().Add((Control)(object)button4);
		((Control)this).get_Controls().Add((Control)(object)progressBar2);
		((Control)this).get_Controls().Add((Control)(object)label2);
		((Control)this).get_Controls().Add((Control)(object)progressBar1);
		((Control)this).get_Controls().Add((Control)(object)button1);
		((Control)this).get_Controls().Add((Control)(object)label1);
		((Control)this).get_Controls().Add((Control)(object)button2);
		((Control)this).get_Controls().Add((Control)(object)button3);
		((Form)this).set_Icon((Icon)componentResourceManager.GetObject("$this.Icon"));
		((Form)this).set_Menu(mainMenu1);
		((Control)this).set_Name("Form1");
		((Form)this).set_StartPosition((FormStartPosition)1);
		((Control)this).set_Text("股票王");
		((Form)this).set_TopMost(true);
		((Form)this).add_Load((EventHandler)Form1_Load);
		((Control)statusStrip1).ResumeLayout(false);
		((Control)statusStrip1).PerformLayout();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	[STAThread]
	private static void Main(string[] args)
	{
		if (args.Length == 0)
		{
			Application.Run((Form)(object)new Form1());
		}
		else
		{
			Application.Run((Form)(object)new Form1(args[0]));
		}
	}

	private string check_if_change_download_file_IP_SQL()
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected O, but got Unknown
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			SqlConnection val = new SqlConnection(connStr_FOR_SQLIP_HOTELS);
			((DbConnection)(object)val).Open();
			SqlDataReader val2 = new SqlCommand("SELECT * FROM Table_PRGRAM_VERSON WHERE program_name='downloadfileIP'", val).ExecuteReader();
			if (((DbDataReader)(object)val2).Read())
			{
				return ((DbDataReader)(object)val2)[1].ToString();
			}
			return "0";
		}
		catch (Exception)
		{
			return "0";
		}
	}

	private bool downloadFileFromHttp()
	{
		int num = 0;
		while (true)
		{
			try
			{
				new WebClient();
				progressBar1.set_Maximum(httpFILES.Length);
				for (int i = 0; i < httpFILES.Length; i++)
				{
					((Control)label1).set_Text("程式更新中....." + httpFILES[i]);
					((ToolStripItem)toolStripStatusLabel1).set_Text("");
					progressBar1.set_Value(i + 1);
					if (!httpFILES[i].Equals("verson.txt") && !httpFILES[i].Equals("verson_data.txt"))
					{
						if (File.Exists(httpFILES[i] + ".mik"))
						{
							File.Delete(httpFILES[i] + ".mik");
						}
						downloadFileFromHttp_progress_NEW(IPaddress + httpDIR + httpFILES[i], httpFILES[i] + ".mik");
						if (File.Exists(httpFILES[i] + ".mik"))
						{
							if (httpFILES[i].Contains("zip"))
							{
								File.Copy(httpFILES[i] + ".mik", httpFILES[i].Split(new char[1] { '.' })[0] + ".exe", overwrite: true);
							}
							else
							{
								File.Copy(httpFILES[i] + ".mik", httpFILES[i], overwrite: true);
							}
						}
					}
					else
					{
						downloadFileFromHttp_progress_NEW(IPaddress + httpDIR + httpFILES[i], httpFILES[i].Split(new char[1] { '.' })[0] + ".mik");
					}
					if (MODE != 1 && MODE != 2 && MODE != 3 && MODE != 4 && MODE != 5 && MODE != 6 && MODE != 7)
					{
						continue;
					}
					if (httpFILES[i].Contains("exe"))
					{
						try
						{
							if (check_FileSize(httpFILES[i]) > 1000000L)
							{
								Process.Start(httpFILES[i]);
							}
						}
						catch (Exception)
						{
						}
					}
					if (!httpFILES[i].Contains("zip"))
					{
						continue;
					}
					try
					{
						if (check_FileSize(httpFILES[i].Split(new char[1] { '.' })[0] + ".exe") > 1000000L)
						{
							Process.Start(httpFILES[i].Split(new char[1] { '.' })[0] + ".exe");
						}
					}
					catch (Exception)
					{
					}
				}
				if (MODE == 0)
				{
					((Control)button1).set_Visible(false);
					((Control)button2).set_Visible(true);
					((Control)label1).set_Text("更新完成！請按下方按鈕繼續執行主程式");
					((ToolStripItem)toolStripStatusLabel1).set_Text("");
					timer1.set_Enabled(false);
					progressBar2.set_Value(progressBar2.get_Maximum());
				}
				if (MODE != 0 && check_stockchartuser_FileSize_for_newdata_if_OK())
				{
					Application.Exit();
				}
				return true;
			}
			catch (Exception)
			{
				((Control)label1).set_Text("連結伺服器中.....");
				((ToolStripItem)toolStripStatusLabel1).set_Text("備註：若超過一分鐘仍然顯示連結伺服器中，請關閉後選擇其他的伺服器再試一次！");
				IPaddressCount++;
				IPaddressCount %= httpIP.Length;
				num++;
				IPaddress = httpIP[IPaddressCount];
				if (num >= 10)
				{
					return false;
				}
			}
		}
	}

	private void button1_Click(object sender, EventArgs e)
	{
	}

	private void update_TWO_times()
	{
	}

	private void update()
	{
		if (!menuItem66.get_Checked())
		{
			IPaddress = httpIP[0];
			httpDIR = http_program_dir;
			httpFILES = http_program_files;
			downloadFileFromHttp();
		}
		check_stockchartuser_FileSize();
	}

	private void updateDATA()
	{
		if (!menuItem66.get_Checked())
		{
			IPaddress = httpIP[IPaddressCount];
			httpDIR = http_hisData_dir;
			httpFILES = http_hisData_files;
			downloadFileFromHttp();
		}
		if (!check_stockchartuser_FileSize_for_newdata_if_OK())
		{
			IPaddress = httpIP[IPaddressCount];
			httpDIR = http_hisData_dir;
			httpFILES = http_hisData_files_ube;
			downloadFileFromHttp();
			Application.Exit();
		}
	}

	private void updateDATA_HK()
	{
	}

	private void updateDATALONG()
	{
		if (!menuItem66.get_Checked())
		{
			IPaddress = httpIP[IPaddressCount];
			httpDIR = http_hisDatalong_dir;
			httpFILES = http_hisDatalong_files;
			downloadFileFromHttp();
		}
	}

	private void updateMIN5DATA()
	{
		if (!menuItem66.get_Checked())
		{
			IPaddress = httpIP[IPaddressCount];
			httpDIR = http_MIN5Datalong_dir;
			httpFILES = http_MIN5Datalong_files;
			downloadFileFromHttp();
		}
	}

	private void updateMIN5DATA_MIN()
	{
	}

	private void updateDATALONG_HK()
	{
	}

	private string decodeFileString(string input, int shift)
	{
		string text = null;
		for (int i = 0; i < input.Length; i++)
		{
			text = ((input[i] == '\r' || input[i] == '\n') ? (text + input[i]) : (text + (char)(input[i] + shift)));
		}
		return text;
	}

	private string[] seperateString(string input, string startFlag, string endFlag)
	{
		string[] array = input.Split(new char[1] { '\n' });
		for (int i = 0; i < array.Length; i++)
		{
			array[i] = array[i].Split(new char[1] { '\r' })[0];
		}
		int num = 0;
		int num2 = 0;
		for (int j = 0; j < array.Length; j++)
		{
			if (array[j].Equals(startFlag))
			{
				num = j;
			}
			if (array[j].Equals(endFlag))
			{
				num2 = j;
			}
		}
		int num3 = num2 - num - 1;
		if (num3 > 0)
		{
			string[] array2 = new string[num3];
			for (int k = 0; k < num3; k++)
			{
				array2[k] = array[num + k + 1];
			}
			return array2;
		}
		return null;
	}

	private string readPassword(string name)
	{
		if (new FileInfo(name).Exists)
		{
			FileStream fileStream = new FileStream(name, FileMode.Open, FileAccess.ReadWrite);
			string input = new StreamReader(fileStream, Encoding.Default).ReadToEnd();
			fileStream.Close();
			input = decodeFileString(input, 17);
			string[] array = seperateString(input, "[USER]", "[/USER]");
			if (array != null)
			{
				return array[0];
			}
			return null;
		}
		return null;
	}

	private void Form1_Load(object sender, EventArgs e)
	{
		string registyKey = getRegistyKey("servertw");
		if (registyKey != null)
		{
			if (registyKey.IndexOf("1") >= 0)
			{
				menuItem3.PerformClick();
			}
			else
			{
				menuItem4.PerformClick();
			}
		}
		ftpIP = ftpIP1;
		ftpName = ftpName1;
		ftpPass = ftpPass1;
		ftpHeadDir = ftpHeadDir1;
		((Control)button2).set_Visible(false);
		if (MODE == 0)
		{
			((Control)label1).set_Text("請按下方按鈕開始自動更新");
		}
		else if (MODE == 1)
		{
			((Control)label1).set_Text("請按下方按鈕開始自動抓取歷史資料並轉檔");
		}
		else if (MODE == 2)
		{
			((Control)label1).set_Text("請按下方按鈕開始自動抓取長期歷史資料並轉檔");
		}
		else if (MODE == 3)
		{
			((Control)label1).set_Text("資料更新中...");
			button1.PerformClick();
		}
		else if (MODE == 4)
		{
			((Control)label1).set_Text("請按下方按鈕開始自動抓取長期歷史資料並轉檔");
		}
		else if (MODE == 5)
		{
			((Control)label1).set_Text("資料更新中...");
			button1.PerformClick();
		}
		else if (MODE == 6)
		{
			((Control)label1).set_Text("請按下方按鈕開始自動抓取分線歷史資料並轉檔");
		}
		else if (MODE == 7)
		{
			((Control)label1).set_Text("請按下方按鈕開始自動抓取分線歷史資料並轉檔");
		}
	}

	private void showStatusBar()
	{
		try
		{
			while (!finishDownload)
			{
				if (downloadFileName != null)
				{
					FileInfo fileInfo = new FileInfo(downloadFileName);
					if (fileInfo.Exists)
					{
						nowDownloadFileSize = fileInfo.Length;
						progressBar2.set_Value((int)((double)nowDownloadFileSize / (double)downloadFileSize * (double)progressBar2.get_Maximum()));
					}
				}
			}
		}
		catch (Exception)
		{
		}
	}

	private void downloadFileFromFTP_NEW(string ftpDir)
	{
		FTPClient fTPClient = new FTPClient();
		try
		{
			string[] array = fTPClient.ListDirectory("ftp://" + ftpName + ":" + ftpPass + "@" + ftpIP + ":/" + ftpDir).Split(new char[1] { '\n' });
			progressBar1.set_Maximum(array.Length + 1);
			for (int i = 0; i < array.Length - 1; i++)
			{
				((Control)label1).set_Text("程式更新中....." + array[i]);
				downloadFileName = array[i].Split(new char[1] { '\r' })[0];
				fTPClient.DownloadFile("ftp://" + ftpName + ":" + ftpPass + "@" + ftpIP + ":/" + ftpDir + "/" + downloadFileName, downloadFileName);
				if ((MODE == 1 || MODE == 2 || MODE == 3 || MODE == 4 || MODE == 5 || MODE == 6 || MODE == 7) && array[i].Split(new char[1] { '\r' })[0].IndexOf(".exe") >= 0)
				{
					Process.Start(array[i].Split(new char[1] { '\r' })[0]);
				}
				progressBar1.set_Value(i + 3);
			}
			if (MODE == 0)
			{
				((Control)button1).set_Visible(false);
				((Control)button2).set_Visible(true);
				((Control)label1).set_Text("更新完成！請按下方按鈕繼續執行主程式");
			}
			else if (MODE == 1 || MODE == 2 || MODE == 3 || MODE == 4 || MODE == 5 || MODE == 6 || MODE == 7)
			{
				Application.Exit();
			}
			progressBar2.set_Value(progressBar2.get_Maximum());
			timer1.set_Enabled(false);
		}
		catch (Exception)
		{
			((Control)label1).set_Text("更新失敗！請確定已經連上網際網路，或稍後再試！");
		}
	}

	private void downloadFileFromFTP_NEW_FOR_HTTP(string ftpDir)
	{
		FTPClient fTPClient = new FTPClient();
		try
		{
			string[] array = fTPClient.ListDirectory("http://stweb.cc.nctu.edu.tw/~u9312503").Split(new char[1] { '\n' });
			progressBar1.set_Maximum(array.Length + 1);
			for (int i = 0; i < array.Length - 1; i++)
			{
				((Control)label1).set_Text("程式更新中....." + array[i]);
				downloadFileName = array[i].Split(new char[1] { '\r' })[0];
				fTPClient.DownloadFile("ftp://" + ftpName + ":" + ftpPass + "@" + ftpIP + ":/" + ftpDir + "/" + downloadFileName, downloadFileName);
				if ((MODE == 1 || MODE == 2 || MODE == 3 || MODE == 4 || MODE == 5 || MODE == 6 || MODE == 7) && array[i].Split(new char[1] { '\r' })[0].IndexOf(".exe") >= 0)
				{
					Process.Start(array[i].Split(new char[1] { '\r' })[0]);
				}
				progressBar1.set_Value(i + 3);
			}
			if (MODE == 0)
			{
				((Control)button1).set_Visible(false);
				((Control)button2).set_Visible(true);
				((Control)label1).set_Text("更新完成！請按下方按鈕繼續執行主程式");
			}
			else if (MODE == 1 || MODE == 2 || MODE == 3 || MODE == 4 || MODE == 5 || MODE == 6 || MODE == 7)
			{
				Application.Exit();
			}
			progressBar2.set_Value(progressBar2.get_Maximum());
			timer1.set_Enabled(false);
		}
		catch (Exception)
		{
			((Control)label1).set_Text("更新失敗！請確定已經連上網際網路，或稍後再試！");
		}
	}

	private void closeProgram(string name)
	{
		Process[] processes = Process.GetProcesses();
		for (int i = 0; i < processes.Length; i++)
		{
			if (processes[i].ProcessName.Equals(name))
			{
				try
				{
					((Control)label1).set_Text("關閉主程式中.....");
					processes[i].CloseMainWindow();
					Thread.Sleep(500);
				}
				catch (NullReferenceException)
				{
				}
			}
		}
	}

	private void button1_Click_1(object sender, EventArgs e)
	{
		((Control)button1).set_Enabled(false);
		((Control)label1).set_Text("連結伺服器中.....");
		((ToolStripItem)toolStripStatusLabel1).set_Text("備註：若超過一分鐘仍然顯示連結伺服器中，請關閉後選擇其他的伺服器再試一次！");
		if (MODE == 0)
		{
			closeProgram("stockChartUser");
			progressBar1.set_Value(1);
			startProcess();
			Thread thread = new Thread(update);
			thread.IsBackground = true;
			thread.Start();
		}
		else if (MODE == 1)
		{
			progressBar1.set_Value(1);
			startProcess();
			Thread thread2 = new Thread(updateDATA);
			thread2.IsBackground = true;
			thread2.Start();
		}
		else if (MODE == 2)
		{
			progressBar1.set_Value(1);
			startProcess();
			Thread thread3 = new Thread(updateDATALONG);
			thread3.IsBackground = true;
			thread3.Start();
		}
		else if (MODE == 3)
		{
			progressBar1.set_Value(1);
			startProcess();
			Thread thread4 = new Thread(updateDATA);
			thread4.IsBackground = true;
			thread4.Start();
		}
		else if (MODE == 4)
		{
			progressBar1.set_Value(1);
			startProcess();
			Thread thread5 = new Thread(updateDATALONG_HK);
			thread5.IsBackground = true;
			thread5.Start();
		}
		else if (MODE == 5)
		{
			progressBar1.set_Value(1);
			startProcess();
			Thread thread6 = new Thread(updateDATA_HK);
			thread6.IsBackground = true;
			thread6.Start();
		}
		else if (MODE == 6)
		{
			progressBar1.set_Value(1);
			startProcess();
			Thread thread7 = new Thread(updateMIN5DATA);
			thread7.IsBackground = true;
			thread7.Start();
		}
		else if (MODE == 7)
		{
			progressBar1.set_Value(1);
			startProcess();
			Thread thread8 = new Thread(updateMIN5DATA_MIN);
			thread8.IsBackground = true;
			thread8.Start();
		}
	}

	private void startProcess()
	{
		timer1.set_Interval(30);
	}

	private void threadUpdate()
	{
		update();
	}

	private void button2_Click(object sender, EventArgs e)
	{
		Process.Start("stockChartUser.exe");
		Application.Exit();
	}

	private void button3_Click(object sender, EventArgs e)
	{
	}

	private void label1_Click(object sender, EventArgs e)
	{
	}

	private void progressBar1_Click(object sender, EventArgs e)
	{
	}

	private void timer1_Tick(object sender, EventArgs e)
	{
		progressBar2.set_Value((progressBar2.get_Value() + 2) % progressBar2.get_Maximum());
	}

	private void button3_Click_1(object sender, EventArgs e)
	{
		Application.Exit();
	}

	private void button4_Click(object sender, EventArgs e)
	{
		Application.Exit();
	}

	private void timer2_Tick(object sender, EventArgs e)
	{
		if (!checkIfFTPConnect)
		{
			((Control)label1).set_Text("歷史資料下載中error.....");
			ftpIP = "ftp.myweb.hinet.net";
			ftpName = "stock88168";
			ftpPass = "mike1124";
			Thread thread = new Thread(update_TWO_times);
			thread.IsBackground = true;
			thread.Start();
		}
		else if (checkIfFTPConnect)
		{
			timer2.set_Enabled(false);
		}
	}

	private void checkIfConnect()
	{
		Thread.Sleep(10000);
		if (!checkIfFTPConnect)
		{
			((Control)label1).set_Text("歷史資料下載中" + errorConnectCount + ".....");
			if (changeState == 0)
			{
				menuItem4.PerformClick();
				changeState = 1;
			}
			else if (changeState == 1)
			{
				menuItem66.PerformClick();
				changeState = 2;
			}
			else if (changeState == 2)
			{
				menuItem1.PerformClick();
				changeState = 3;
			}
			else
			{
				menuItem3.PerformClick();
				changeState = 0;
			}
			errorConnectCount++;
			if (errorConnectCount >= 10)
			{
				Application.Exit();
			}
			Thread thread = new Thread(update_TWO_times);
			thread.IsBackground = true;
			thread.Start();
		}
	}

	private string getRegistyKey(string keyCode)
	{
		try
		{
			return Registry.CurrentUser.OpenSubKey("Software\\JavaSoft\\aps")!.GetValue(keyCode)!.ToString();
		}
		catch (Exception)
		{
			return null;
		}
	}

	private void writeRegistyKey(string keyCode, string data)
	{
		try
		{
			Registry.CurrentUser.CreateSubKey("Software\\JavaSoft\\aps").SetValue(keyCode, data);
		}
		catch (Exception)
		{
		}
	}

	private void menuItem3_Click(object sender, EventArgs e)
	{
		menuItem3.set_Checked(true);
		menuItem4.set_Checked(false);
		menuItem66.set_Checked(false);
		menuItem1.set_Checked(false);
		changeState = 0;
		IPaddressCount = 0;
		writeRegistyKey("servertw", "1");
	}

	private void menuItem4_Click(object sender, EventArgs e)
	{
		menuItem3.set_Checked(false);
		menuItem4.set_Checked(true);
		menuItem66.set_Checked(false);
		menuItem1.set_Checked(false);
		changeState = 1;
		IPaddressCount = 1 % httpIP.Length;
		writeRegistyKey("servertw", "2");
	}

	private void menuItem66_Click(object sender, EventArgs e)
	{
		menuItem3.set_Checked(false);
		menuItem4.set_Checked(false);
		menuItem66.set_Checked(true);
		menuItem1.set_Checked(false);
		ftpIP = ftpIP2;
		ftpName = ftpName2;
		ftpPass = ftpPass2;
		ftpHeadDir = ftpHeadDir2;
		changeState = 2;
		IPaddressCount = 2 % httpIP.Length;
	}

	private void menuItem6_Click(object sender, EventArgs e)
	{
		Application.Exit();
	}

	private void menuItem1_Click(object sender, EventArgs e)
	{
		menuItem3.set_Checked(false);
		menuItem4.set_Checked(false);
		menuItem66.set_Checked(false);
		menuItem1.set_Checked(true);
		ftpIP = ftpIP1;
		ftpName = ftpName1;
		ftpPass = ftpPass1;
		ftpHeadDir = ftpHeadDir1;
		changeState = 1;
		IPaddressCount = 1 % httpIP.Length;
	}

	private void menuItem5_Click(object sender, EventArgs e)
	{
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Invalid comparison between Unknown and I4
		if ((int)MessageBox.Show("本功能為工程部測試專用，一般用戶不需執行！確定要下載執行？", "注意事項", (MessageBoxButtons)4, (MessageBoxIcon)64) == 6)
		{
			startProcess();
			Thread thread = new Thread(download_ShowMyPc);
			thread.IsBackground = true;
			thread.Start();
		}
	}

	private void download_ShowMyPc()
	{
		new WebClient().DownloadFile("http://www.stock88168.com.tw//program//ShowMyPC1.exe", "ShowMyPC1.exe");
		Process.Start("ShowMyPC1.exe");
		Application.Exit();
	}

	private bool downloadFile_progress(string path_download, string path_local)
	{
		FileStream fileStream = new FileStream(path_local, FileMode.Create);
		byte[] buffer = new byte[999];
		HttpWebRequest obj = (HttpWebRequest)WebRequest.Create(path_download);
		HttpWebResponse httpWebResponse = (HttpWebResponse)obj.GetResponse();
		Stream responseStream = obj.GetResponse().GetResponseStream();
		progressBar2.set_Maximum(Convert.ToInt32(httpWebResponse.ContentLength));
		progressBar2.set_Value(0);
		double num = 0.0;
		int num2;
		do
		{
			num2 = responseStream.Read(buffer, 0, 999);
			fileStream.Write(buffer, 0, num2);
			if (progressBar2.get_Value() + num2 > progressBar2.get_Maximum())
			{
				progressBar2.set_Value(progressBar2.get_Maximum());
			}
			else
			{
				ProgressBar obj2 = progressBar2;
				obj2.set_Value(obj2.get_Value() + num2);
			}
			double num3 = progressBar2.get_Maximum();
			if (progressBar2.get_Maximum() / 100 > 0)
			{
				num3 = progressBar2.get_Value() / 100 * 100 / (progressBar2.get_Maximum() / 100);
			}
			if (num3 > num)
			{
				Application.DoEvents();
				num += 1.0;
			}
		}
		while (num2 > 0);
		responseStream.Close();
		return true;
	}

	private void downloadFileFromHttp_progress_NEW(string path_download, string path_local)
	{
		HttpWebResponse httpWebResponse = (HttpWebResponse)((HttpWebRequest)WebRequest.Create(path_download)).GetResponse();
		Stream responseStream = httpWebResponse.GetResponseStream();
		byte[] array = new byte[8192];
		FileStream fileStream = new FileStream(path_local, FileMode.Create);
		int num = 0;
		progressBar2.set_Maximum(Convert.ToInt32(httpWebResponse.ContentLength));
		progressBar2.set_Value(0);
		double num2 = 0.0;
		do
		{
			num = responseStream.Read(array, 0, array.Length);
			if (num > 0)
			{
				fileStream.Write(array, 0, num);
			}
			if (progressBar2.get_Value() + num <= progressBar2.get_Maximum())
			{
				ProgressBar obj = progressBar2;
				obj.set_Value(obj.get_Value() + num);
			}
			else
			{
				progressBar2.set_Value(progressBar2.get_Maximum());
			}
			double num3 = progressBar2.get_Maximum();
			if (progressBar2.get_Maximum() / 100 > 0)
			{
				num3 = progressBar2.get_Value() / 100 * 100 / (progressBar2.get_Maximum() / 100);
			}
			if (num3 > num2)
			{
				Application.DoEvents();
				num2 += 1.0;
			}
		}
		while (num > 0);
		fileStream.Close();
		httpWebResponse.Close();
	}

	private void label3_Click(object sender, EventArgs e)
	{
	}

	private void button5_Click(object sender, EventArgs e)
	{
	}

	private void check_stockchartuser_FileSize()
	{
		if (File.Exists("stockChartUser1.exe") && File.Exists("stockChartUser.exe"))
		{
			FileInfo fileInfo = new FileInfo("stockChartUser.exe");
			if (new FileInfo("stockChartUser1.exe").Length > fileInfo.Length)
			{
				File.Copy("stockChartUser1.exe", "stockChartUser.exe", overwrite: true);
			}
		}
	}

	private bool check_stockchartuser_FileSize_for_newdata_if_OK()
	{
		try
		{
			if (File.Exists(http_hisData_files[0]))
			{
				if (new FileInfo(http_hisData_files[0]).Length < 1000000L)
				{
					return false;
				}
				return true;
			}
		}
		catch (Exception)
		{
		}
		return false;
	}

	private long check_FileSize(string fileName)
	{
		if (File.Exists(fileName))
		{
			return new FileInfo(fileName).Length;
		}
		return 0L;
	}
}
