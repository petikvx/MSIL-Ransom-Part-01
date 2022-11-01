using System;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YullySpoofer;

internal class ServerTamper
{
	public class AutoClosingMessageBox
	{
		private Timer _timeoutTimer;

		private string _caption;

		private const int WM_CLOSE = 16;

		private AutoClosingMessageBox(string text, string caption, int timeout)
		{
			//IL_0030: Unknown result type (might be due to invalid IL or missing references)
			_caption = caption;
			_timeoutTimer = new Timer(OnTimerElapsed, null, timeout, -1);
			using (_timeoutTimer)
			{
				MessageBox.Show(text, caption);
			}
		}

		[DllImport("user32.dll", SetLastError = true)]
		private static extern IntPtr FindWindow(string lpClassName, string lpWindowName);

		private void OnTimerElapsed(object state)
		{
			IntPtr intPtr = FindWindow("#32770", _caption);
			if (intPtr != IntPtr.Zero)
			{
				SendMessage(intPtr, 16u, IntPtr.Zero, IntPtr.Zero);
			}
			_timeoutTimer.Dispose();
		}

		[DllImport("user32.dll", CharSet = CharSet.Auto)]
		private static extern IntPtr SendMessage(IntPtr hWnd, uint Msg, IntPtr wParam, IntPtr lParam);

		public static void Show(string text, string caption, int timeout)
		{
			new AutoClosingMessageBox(text, caption, timeout);
		}
	}

	public static string ApplicationByteCount { get; set; }

	public static string ApplicationDirectory { get; set; }

	public static string ApplicationName { get; set; }

	public static string ApplicationTimeModifed { get; set; }

	static ServerTamper()
	{
		ApplicationName = Program.KeyAuthApp.var("YullySpoofer6.0.exe");
		ApplicationDirectory = Assembly.GetExecutingAssembly().Location;
	}

	public static void CheckApplication(bool AppNameCheck, bool AppByteCheck, bool AppTimeModified)
	{
		FileInfo fileInfo = new FileInfo(ApplicationDirectory);
		if (AppByteCheck && fileInfo.Length.ToString() != ApplicationByteCount)
		{
			AutoClosingMessageBox.Show("The application bytes do not match.", "Yully Spoofer | Integrity", 2000);
			Process.GetCurrentProcess().Kill();
		}
		DateTime creationTime = File.GetCreationTime(ApplicationDirectory);
		if (AppTimeModified && creationTime.ToString() != ApplicationTimeModifed)
		{
			AutoClosingMessageBox.Show("Application has been modified.", "Yully Spoofer | Integrity", 2000);
			Process.GetCurrentProcess().Kill();
		}
		string fileName = Path.GetFileName(Assembly.GetEntryAssembly()!.Location);
		if (AppNameCheck && fileName != ApplicationName)
		{
			AutoClosingMessageBox.Show("The executable does not match and has been modified.", "Yully Spoofer | Integrity", 2000);
			Process.GetCurrentProcess().Kill();
		}
	}

	public static async void GetCurrentAppInformation()
	{
		Console.ForegroundColor = ConsoleColor.Black;
		FileInfo fileInfo = new FileInfo(Assembly.GetExecutingAssembly().Location);
		string fileName = Path.GetFileName(Assembly.GetEntryAssembly()!.Location);
		DateTime creationTime = File.GetCreationTime(ApplicationDirectory);
		Clipboard.SetText(fileInfo.Length.ToString());
		await Task.Delay(4000);
		Clipboard.SetText(fileName);
		await Task.Delay(4000);
		Clipboard.SetText(creationTime.ToString());
	}
}
